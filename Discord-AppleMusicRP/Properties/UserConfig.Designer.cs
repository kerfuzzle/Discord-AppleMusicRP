﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Discord_AppleMusicRP.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
    internal sealed partial class UserConfig : global::System.Configuration.ApplicationSettingsBase {
        
        private static UserConfig defaultInstance = ((UserConfig)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UserConfig())));
        
        public static UserConfig Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1084164353579827260")]
        public string clientId {
            get {
                return ((string)(this["clientId"]));
            }
            set {
                this["clientId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{title}")]
        public string detailsFormat {
            get {
                return ((string)(this["detailsFormat"]));
            }
            set {
                this["detailsFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("by {artist}")]
        public string stateFormat {
            get {
                return ((string)(this["stateFormat"]));
            }
            set {
                this["stateFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Discord AppleMusicRP (by Kerfuzzle#2472)")]
        public string largeImageTextFormat {
            get {
                return ((string)(this["largeImageTextFormat"]));
            }
            set {
                this["largeImageTextFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("apple_music_icon")]
        public string largeImageKey {
            get {
                return ((string)(this["largeImageKey"]));
            }
            set {
                this["largeImageKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{status}")]
        public string smallImageTextFormat {
            get {
                return ((string)(this["smallImageTextFormat"]));
            }
            set {
                this["smallImageTextFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("apple_music_icon")]
        public string smallImageKey {
            get {
                return ((string)(this["smallImageKey"]));
            }
            set {
                this["smallImageKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("playing_icon")]
        public string playingImageKey {
            get {
                return ((string)(this["playingImageKey"]));
            }
            set {
                this["playingImageKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("paused_icon")]
        public string pausedImageKey {
            get {
                return ((string)(this["pausedImageKey"]));
            }
            set {
                this["pausedImageKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Search on Apple Music")]
        public string buttonLabelFormat {
            get {
                return ((string)(this["buttonLabelFormat"]));
            }
            set {
                this["buttonLabelFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useTrackTimestamps {
            get {
                return ((bool)(this["useTrackTimestamps"]));
            }
            set {
                this["useTrackTimestamps"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useStatusSymbols {
            get {
                return ((bool)(this["useStatusSymbols"]));
            }
            set {
                this["useStatusSymbols"] = value;
            }
        }
    }
}
