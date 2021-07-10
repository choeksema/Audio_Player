
 /* Created by SharpDevelop.
 * User: Caleb
 * Date: 2021-05-01
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Windows.Input;

namespace Player
{
	/*
	 * Using ID so you can add the same track multiple times, faster searching, easier shuffling (but that requires reassigning all the values or skipping non-matching values)
	 */
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private class SongInfo
		{
			public string TrackName = "";
			public string Artist = "";
			public int RowNumber = 0;
			public TimeSpan Position = new TimeSpan();
			public string Path = "";
			public string Title = "";
			public TimeSpan Duration = new TimeSpan();
			public bool nowPlaying = false;
		}
		
		Color ThemeColour = Color.DarkTurquoise;
		
		SongInfo NowPlaying = new SongInfo();    // TODO: Update on list reordering
		
		DataTable SongListSource = new DataTable();
		System.Windows.Media.MediaPlayer Player = new System.Windows.Media.MediaPlayer();
		Timer PlaybackTimer = new Timer();
		
		bool ShuffleOn = false;    // UNDONE: Save for next time you start the app - in settings
		// bool LoopTrack = false;
		bool LoopList = true;
		
		List<string> TrackColumns = new List<string> {"Title", "Track Name", "Artist", "Duration", "Path"};
		List<string> HideColumns = new List<string> {"Path"};
		
		public MainForm()
		{
			InitializeComponent();
			UpdateAllColours();
		
			PlaybackTimer.Tick += new EventHandler(this.updatePlayback);
			Player.MediaOpened += new EventHandler(this.getTrackDuration);
			Player.MediaEnded += new EventHandler(this.nextTrack);
			
			// SongList.BackgroundImage = Player.Icons.Add;    // UNDONE: Add icon in the back for adding more tracks
			
			foreach (var column in TrackColumns)
			{
				SongListSource.Columns.Add(new DataColumn(column));
			}
			
			// TODO: Save column types and order in settings
		}
		
		public void UpdateAllColours()
		{
			FileBtn.ForeColor = ThemeColour;
			CurTrackLabel.ForeColor = ThemeColour;
			DurationLabel.ForeColor = ThemeColour;
			PositionLabel.ForeColor = ThemeColour;
			ScrubBar.ProgressBarColor = ThemeColour;
		}
		
		void OpenFilesToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				string path = @"C:\";
				
				if (File.Exists(PlayerSettings.Default.File_Path))
				{
					path = PlayerSettings.Default.File_Path;
				}
				
				var fileDialogue = new System.Windows.Forms.OpenFileDialog
				{
					InitialDirectory = path,
					Title = "Select Files",
					Filter = "audio files (*.mp3, *.wav)|*.mp3; *.wav|All files (*.*)|*.*",
					Multiselect = true
				};
							
				if (fileDialogue.ShowDialog() != System.Windows.Forms.DialogResult.OK)
				{
					return;
				}
				
				if (fileDialogue.FileNames.Length > 0)
				{
					PlayerSettings.Default.File_Path = Path.GetFullPath(fileDialogue.FileNames[0]);
					PlayerSettings.Default.Save();    // TODO: Change to save on any change
				}
				
				fileSort(fileDialogue.FileNames);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Open Files: " + ex.Message + ": " + ex.ToString());
			}
		}
		
		// TODO: Determine filetypes based on contents
		// TODO: Auto resize columns when double click header
		// TODO: Sort columns only on double click or right click
		// TODO: Make columns wide enough to a max when adding
		// FIXME: Theme colours (icons, also highlighting) 
		// TODO: Loop Track
		// TODO: Deal with track count limit, filling in unused numbers, and stuff
		// TODO: Removing tracks
		// TODO: Highlight current track
		// TODO: Mono?
		// TODO: Time when hovering over track bar
		// TODO: Taskbar controls
		// TODO: Add title column (for tracks with no tags)
		// TODO: Progress bar chugging
		// FIXME: Path saving
		// TODO: Similar names
		// TODO: Button on or off
		
		void fileSort(string[] fileNames)
		{
			try
			{
				string title = "", trackName = "", artists = "", duration = "";
				// TODO: GET other attributes for optional columns
				
				foreach (string file in fileNames)
				{
					try
					{
						title = Path.GetFileNameWithoutExtension(file);
						TagLib.File fileId3Tags = TagLib.File.Create(file);
						
						trackName = fileId3Tags.Tag.Title;
						artists = String.Join(", ", fileId3Tags.Tag.Performers);
						duration = fileId3Tags.Properties.Duration.ToString(@"hh\:mm\:ss");    // FIXME: Trim hour field if empty
						
						SongListSource.Rows.Add(title, trackName, artists, duration, file);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Failed adding " + Path.GetFileNameWithoutExtension(file) + ": " + ex.Message);
					}
				}
				SongList.DataSource = SongListSource;
				foreach (string column in HideColumns)
				{
					SongList.Columns[column].Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Sort Files: " + ex.Message + ": " + ex.ToString());
			}
		}
		
		void SongListDragEnter(object sender, DragEventArgs e)
		{
			fileSort((string[])e.Data.GetData(DataFormats.FileDrop, false));
		}
		
		void SongListDragDrop(object sender, DragEventArgs e)
		{
			// TODO: Set up song reordering	
		}
		
		void updatePlayback(object sender, EventArgs e)
		{
			PositionLabel.Text = Player.Position.ToString(@"hh\:mm\:ss");
			NowPlaying.Position = Player.Position;
			try
			{
				if (NowPlaying.Duration.Ticks > 0)
				{
					ScrubBar.Value = (int)(((float)NowPlaying.Position.Ticks/(float)NowPlaying.Duration.Ticks) * 100);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void getTrackDuration(object sender, EventArgs e)
		{
			DurationLabel.Text = Player.NaturalDuration.TimeSpan.ToString(@"hh\:mm\:ss");
			NowPlaying.Duration = Player.NaturalDuration.TimeSpan;
		}
		
		void BtnShuffleClick(object sender, EventArgs e)
		{
			ShuffleOn = !ShuffleOn;
		}
		
		void nextTrack(object sender, EventArgs e)
		{
			if (!ShuffleOn)
			{
				int newTrackRow = ((NowPlaying.RowNumber + 1 >= SongList.Rows.Count) && LoopList) ? 0 : NowPlaying.RowNumber + 1;
				
				var NextSongPlaying = new SongInfo();
				NextSongPlaying.TrackName = SongList.Rows[newTrackRow].Cells["Title"].Value.ToString();
				NextSongPlaying.Artist = SongList.Rows[newTrackRow].Cells["Artist"].Value.ToString();
				NextSongPlaying.Path = SongList.Rows[newTrackRow].Cells["Path"].Value.ToString();
				NextSongPlaying.RowNumber = newTrackRow;
				NextSongPlaying.Position = new TimeSpan(0);
				
				NowPlaying = NextSongPlaying;
				playTrack();
			}
		}
		
		void SongListCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			NowPlaying.TrackName = SongList.Rows[e.RowIndex].Cells["Title"].Value.ToString();
			NowPlaying.Artist = SongList.Rows[e.RowIndex].Cells["Artist"].Value.ToString();
			NowPlaying.RowNumber = e.RowIndex;
			NowPlaying.Path = SongList.Rows[e.RowIndex].Cells["Path"].Value.ToString();
			NowPlaying.Position =  new TimeSpan(0);
			playTrack();
		}
		
		void ScrubBarMouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Point mouseLocation = Control.MousePosition;
			Point coordinatesInBar = ScrubBar.PointToClient(mouseLocation);
			
			int positionInBar = coordinatesInBar.X;
			int totalBarLength = ScrubBar.Width;
			long totalTrackLength = NowPlaying.Duration.Ticks;
			long currentTrackPosition = (positionInBar * totalTrackLength) / totalBarLength;
			
			TimeSpan songTime = new TimeSpan(currentTrackPosition);
			NowPlaying.Position = songTime;
			Player.Position = songTime;
		}
		
		void ScrubBarMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Point mouseLocation = Control.MousePosition;
			Point coordinatesInBar = ScrubBar.PointToClient(mouseLocation);
			
			int positionInBar = coordinatesInBar.X;
			int totalBarLength = ScrubBar.Width;
			long totalTrackLength = NowPlaying.Duration.Ticks;
			long currentTrackPosition = (positionInBar * totalTrackLength) / totalBarLength;
			
			TimeSpan songTime = new TimeSpan(currentTrackPosition);
			TimeToolTip.Tag = songTime.ToString(@"hh\:mm\:ss");
		}
		
		void playTrack()
		{
			if (SongList.Rows.Count <= 0)
			{
				return;
			}
			
			if (String.IsNullOrEmpty(NowPlaying.TrackName))
			{
				NowPlaying.Title = SongList.Rows[0].Cells["Title"].Value.ToString();
				NowPlaying.TrackName = SongList.Rows[0].Cells["Track Name"].Value.ToString();
				NowPlaying.Artist = SongList.Rows[0].Cells["Artist"].Value.ToString();
				NowPlaying.Path = SongList.Rows[0].Cells["Path"].Value.ToString();
				NowPlaying.RowNumber = 0;
			}
			
			// FIXME: Get random song if Shuffle is on
			
			// Check if in the middle of a song - TODO: Check if already playing or not
			if ((NowPlaying.Position != null) && (NowPlaying.Position.CompareTo(new TimeSpan(0)) > 0))
			{
				Player.Position = NowPlaying.Position;
			}
			else if (SongList.Rows.Count > 0)
			{
				Player.Open(new Uri(NowPlaying.Path));
				PlaybackTimer.Start();
				CurTrackLabel.Text = NowPlaying.Title;
			}
			BtnPlayPause.BackgroundImage = Icons.Pause;
			NowPlaying.nowPlaying = true;
			Player.Play();	
		}
				
		void BtnPlayPauseClick(object sender, EventArgs e)
		{
			if (!NowPlaying.nowPlaying)
			{
				// Do Play Stuff
				playTrack();
			}
			
			else
			{
				// Do pause stuff
				Player.Pause();
				NowPlaying.Position = Player.Position;
				BtnPlayPause.BackgroundImage = Icons.Play;
				NowPlaying.nowPlaying = false;
			}
		}
	}
}
