﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResumeParse.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F:\\Rohit\\c#learning\\GitHub\\ResumeParse\\Temp")]
        public string TempResumeFolder {
            get {
                return ((string)(this["TempResumeFolder"]));
            }
            set {
                this["TempResumeFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F:\\Rohit\\c#learning\\Databases\\ResumeDataBase.sdf")]
        public string ResumeDBpath {
            get {
                return ((string)(this["ResumeDBpath"]));
            }
            set {
                this["ResumeDBpath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F:\\Rohit\\c#learning\\GitHub\\ResumeParse\\TempOut")]
        public string TempOutput {
            get {
                return ((string)(this["TempOutput"]));
            }
            set {
                this["TempOutput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F:\\Rohit\\c#learning\\GitHub\\ResumeParse\\TempOut\\Convert\\Resume.doc")]
        public string TempOutFile {
            get {
                return ((string)(this["TempOutFile"]));
            }
            set {
                this["TempOutFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F:\\Rohit\\c#learning\\GitHub\\ResumeParse\\Temp\\Input\\Resume.txt")]
        public string TempInFile {
            get {
                return ((string)(this["TempInFile"]));
            }
            set {
                this["TempInFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F:\\Rohit\\c#learning\\GitHub\\ResumeParse\\TempOut\\Convert\\Resume.txt")]
        public string textout {
            get {
                return ((string)(this["textout"]));
            }
            set {
                this["textout"] = value;
            }
        }
    }
}