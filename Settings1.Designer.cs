﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bluetooth_DotMetrix {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Settings1 : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings1 defaultInstance = ((Settings1)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings1())));
        
        public static Settings1 Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM6")]
        public string CurrentCOM {
            get {
                return ((string)(this["CurrentCOM"]));
            }
            set {
                this["CurrentCOM"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isSendTime {
            get {
                return ((bool)(this["isSendTime"]));
            }
            set {
                this["isSendTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isSendDate {
            get {
                return ((bool)(this["isSendDate"]));
            }
            set {
                this["isSendDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool isSendNews {
            get {
                return ((bool)(this["isSendNews"]));
            }
            set {
                this["isSendNews"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("KTN01")]
        public string zone {
            get {
                return ((string)(this["zone"]));
            }
            set {
                this["zone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Kelantan")]
        public string state {
            get {
                return ((string)(this["state"]));
            }
            set {
                this["state"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("14")]
        public int waktuSolatHari {
            get {
                return ((int)(this["waktuSolatHari"]));
            }
            set {
                this["waktuSolatHari"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int waktuSolatBulan {
            get {
                return ((int)(this["waktuSolatBulan"]));
            }
            set {
                this["waktuSolatBulan"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2020")]
        public int waktusolatTahun {
            get {
                return ((int)(this["waktusolatTahun"]));
            }
            set {
                this["waktusolatTahun"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Kota Bharu")]
        public string lokasiZone {
            get {
                return ((string)(this["lokasiZone"]));
            }
            set {
                this["lokasiZone"] = value;
            }
        }
    }
}
