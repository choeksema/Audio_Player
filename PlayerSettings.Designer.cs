﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Player {
	
	
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("ICSharpCode.SettingsEditor.SettingsCodeGeneratorTool", "4.4.1.9729")]
	internal sealed partial class PlayerSettings : global::System.Configuration.ApplicationSettingsBase {
		
		private static PlayerSettings defaultInstance = ((PlayerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new PlayerSettings())));
		
		public static PlayerSettings Default {
			get {
				return defaultInstance;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string File_Path {
			get {
				return ((string)(this["File_Path"]));
			}
			set {
				this["File_Path"] = value;
			}
		}
	}
}
