/*
 * Created by SharpDevelop.
 * User: Caleb
 * Date: 2021-05-01
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Player
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.FileBtn = new System.Windows.Forms.ToolStripSplitButton();
			this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.BtnPlayPause = new System.Windows.Forms.Button();
			this.BtnShuffle = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.SongList = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.CurTrackLabel = new System.Windows.Forms.Label();
			this.DurationLabel = new System.Windows.Forms.Label();
			this.PositionLabel = new System.Windows.Forms.Label();
			this.ScrubBar = new System.Windows.Forms.AudioBar();
			this.TimeToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SongList)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.SongList, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.ScrubBar, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 416);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrip1.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.FileBtn});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(579, 30);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "Menu";
			// 
			// FileBtn
			// 
			this.FileBtn.BackColor = System.Drawing.Color.Transparent;
			this.FileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.FileBtn.DropDownButtonWidth = 25;
			this.FileBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.openFilesToolStripMenuItem,
									this.saveListToolStripMenuItem,
									this.recentToolStripMenuItem});
			this.FileBtn.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.FileBtn.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.FileBtn.Name = "FileBtn";
			this.FileBtn.Size = new System.Drawing.Size(61, 27);
			this.FileBtn.Text = "File";
			// 
			// openFilesToolStripMenuItem
			// 
			this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
			this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
			this.openFilesToolStripMenuItem.Text = "Open Files";
			this.openFilesToolStripMenuItem.Click += new System.EventHandler(this.OpenFilesToolStripMenuItemClick);
			// 
			// saveListToolStripMenuItem
			// 
			this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
			this.saveListToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
			this.saveListToolStripMenuItem.Text = "Save List";
			// 
			// recentToolStripMenuItem
			// 
			this.recentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.listToolStripMenuItem});
			this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
			this.recentToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
			this.recentToolStripMenuItem.Text = "Recent";
			// 
			// listToolStripMenuItem
			// 
			this.listToolStripMenuItem.Name = "listToolStripMenuItem";
			this.listToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
			this.listToolStripMenuItem.Text = "List";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.BtnPlayPause, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.BtnShuffle, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.trackBar1, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 352);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(573, 58);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// BtnPlayPause
			// 
			this.BtnPlayPause.BackColor = System.Drawing.Color.Transparent;
			this.BtnPlayPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayPause.BackgroundImage")));
			this.BtnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnPlayPause.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.BtnPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.BtnPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.BtnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPlayPause.ForeColor = System.Drawing.Color.Transparent;
			this.BtnPlayPause.Location = new System.Drawing.Point(261, 6);
			this.BtnPlayPause.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.BtnPlayPause.Name = "BtnPlayPause";
			this.BtnPlayPause.Size = new System.Drawing.Size(50, 46);
			this.BtnPlayPause.TabIndex = 5;
			this.BtnPlayPause.UseVisualStyleBackColor = false;
			this.BtnPlayPause.Click += new System.EventHandler(this.BtnPlayPauseClick);
			// 
			// BtnShuffle
			// 
			this.BtnShuffle.BackColor = System.Drawing.Color.Transparent;
			this.BtnShuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnShuffle.BackgroundImage")));
			this.BtnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnShuffle.Dock = System.Windows.Forms.DockStyle.Left;
			this.BtnShuffle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.BtnShuffle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.BtnShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.BtnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnShuffle.ForeColor = System.Drawing.Color.Transparent;
			this.BtnShuffle.Location = new System.Drawing.Point(3, 6);
			this.BtnShuffle.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.BtnShuffle.Name = "BtnShuffle";
			this.BtnShuffle.Size = new System.Drawing.Size(50, 46);
			this.BtnShuffle.TabIndex = 2;
			this.BtnShuffle.UseVisualStyleBackColor = false;
			this.BtnShuffle.Click += new System.EventHandler(this.BtnShuffleClick);
			// 
			// trackBar1
			// 
			this.trackBar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.trackBar1.Location = new System.Drawing.Point(420, 6);
			this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.trackBar1.Maximum = 25;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(150, 46);
			this.trackBar1.TabIndex = 4;
			// 
			// SongList
			// 
			this.SongList.AllowDrop = true;
			this.SongList.AllowUserToAddRows = false;
			this.SongList.AllowUserToDeleteRows = false;
			this.SongList.AllowUserToOrderColumns = true;
			this.SongList.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.SongList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.SongList.BackgroundColor = System.Drawing.Color.White;
			this.SongList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.SongList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.SongList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.SongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.SongList.DefaultCellStyle = dataGridViewCellStyle3;
			this.SongList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SongList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.SongList.Location = new System.Drawing.Point(3, 36);
			this.SongList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.SongList.MultiSelect = false;
			this.SongList.Name = "SongList";
			this.SongList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.SongList.RowHeadersVisible = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.SongList.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.SongList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.SongList.Size = new System.Drawing.Size(573, 259);
			this.SongList.TabIndex = 3;
			this.SongList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SongListCellDoubleClick);
			this.SongList.DragEnter += new System.Windows.Forms.DragEventHandler(this.SongListDragEnter);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
			this.tableLayoutPanel3.Controls.Add(this.CurTrackLabel, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.DurationLabel, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.PositionLabel, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 319);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(573, 24);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// CurTrackLabel
			// 
			this.CurTrackLabel.BackColor = System.Drawing.Color.Transparent;
			this.CurTrackLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CurTrackLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.CurTrackLabel.Location = new System.Drawing.Point(108, 0);
			this.CurTrackLabel.Name = "CurTrackLabel";
			this.CurTrackLabel.Size = new System.Drawing.Size(357, 24);
			this.CurTrackLabel.TabIndex = 2;
			this.CurTrackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DurationLabel
			// 
			this.DurationLabel.BackColor = System.Drawing.Color.Transparent;
			this.DurationLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.DurationLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.DurationLabel.Location = new System.Drawing.Point(471, 0);
			this.DurationLabel.Name = "DurationLabel";
			this.DurationLabel.Size = new System.Drawing.Size(99, 24);
			this.DurationLabel.TabIndex = 1;
			this.DurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PositionLabel
			// 
			this.PositionLabel.BackColor = System.Drawing.Color.Transparent;
			this.PositionLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.PositionLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.PositionLabel.Location = new System.Drawing.Point(3, 0);
			this.PositionLabel.Name = "PositionLabel";
			this.PositionLabel.Size = new System.Drawing.Size(99, 24);
			this.PositionLabel.TabIndex = 0;
			this.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ScrubBar
			// 
			this.ScrubBar.BackColor = System.Drawing.Color.DimGray;
			this.ScrubBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ScrubBar.Location = new System.Drawing.Point(3, 304);
			this.ScrubBar.Maximum = 100;
			this.ScrubBar.Minimum = 0;
			this.ScrubBar.Name = "ScrubBar";
			this.ScrubBar.ProgressBarColor = System.Drawing.Color.DarkTurquoise;
			this.ScrubBar.Size = new System.Drawing.Size(573, 9);
			this.ScrubBar.TabIndex = 6;
			this.TimeToolTip.SetToolTip(this.ScrubBar, "TimeToolTip");
			this.ScrubBar.Value = 0;
			this.ScrubBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScrubBarMouseClick);
			this.ScrubBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScrubBarMouseMove);
			// 
			// TimeToolTip
			// 
			this.TimeToolTip.BackColor = System.Drawing.Color.White;
			this.TimeToolTip.ForeColor = System.Drawing.Color.Black;
			this.TimeToolTip.Tag = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 34F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(579, 416);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = global::Player.Icons.GoodIcon;
			this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.Name = "MainForm";
			this.Text = "Audio";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SongList)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button BtnPlayPause;
		private System.Windows.Forms.ToolTip TimeToolTip;
		public System.Windows.Forms.AudioBar ScrubBar;
		private System.Windows.Forms.Label CurTrackLabel;
		private System.Windows.Forms.Label PositionLabel;
		private System.Windows.Forms.Label DurationLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.DataGridView SongList;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button BtnShuffle;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSplitButton FileBtn;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
