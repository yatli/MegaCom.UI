﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaCom.UI {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class MegaComSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MegaComSettings defaultInstance = ((MegaComSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MegaComSettings())));
        
        public static MegaComSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Port {
            get {
                return ((string)(this["Port"]));
            }
            set {
                this["Port"] = value;
            }
        }
    }
}
