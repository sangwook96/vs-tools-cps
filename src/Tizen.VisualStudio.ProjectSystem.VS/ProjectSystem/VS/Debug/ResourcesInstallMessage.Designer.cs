﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tizen.VisualStudio.ProjectSystem.VS.Debug {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourcesInstallMessage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourcesInstallMessage() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tizen.VisualStudio.ProjectSystem.VS.Debug.ResourcesInstallMessage", typeof(ResourcesInstallMessage).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current certificate is invalid for selected device..
        /// </summary>
        internal static string CHECK_CERTIFICATE_ERROR {
            get {
                return ResourceManager.GetString("CHECK_CERTIFICATE_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General error occurred..
        /// </summary>
        internal static string GENERAL_ERROR {
            get {
                return ResourceManager.GetString("GENERAL_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SDB(Smart Debug Bridge) is not installed, or selected device refuses app install..
        /// </summary>
        internal static string INSTALL_NOT_TRIED {
            get {
                return ResourceManager.GetString("INSTALL_NOT_TRIED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This TPK file contains no tizen-manifest.xml file or invalid manifest information..
        /// </summary>
        internal static string MANIFEST_NOT_FOUND {
            get {
                return ResourceManager.GetString("MANIFEST_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This package contains app ID(s) already contained in another package. Find and uninstall the older package from selected device, or change the app ID(s).
        ///
        ///Note : To debug this app project with its main app, try to debug main app project before, and use &quot;Debug -&gt; Start new instance&quot; menu item..
        /// </summary>
        internal static string REGISTER_APPLICATION_ERROR {
            get {
                return ResourceManager.GetString("REGISTER_APPLICATION_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some privileges in tizen-manifest.xml can not be used on the current certificate signature level. Please check the output pane messages and remove the privileges. Otherwise, you can get the higher level of certificate to use the privileges..
        /// </summary>
        internal static string SIGNATURE_ERROR {
            get {
                return ResourceManager.GetString("SIGNATURE_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout occurred while install the app..
        /// </summary>
        internal static string TIMEOUT {
            get {
                return ResourceManager.GetString("TIMEOUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error occurred. Try to install the application manually with &quot;sdb.exe install [TPK FILEPATH]&quot; command and check the console output message..
        /// </summary>
        internal static string UNDEFINED_BY_VS_ERROR {
            get {
                return ResourceManager.GetString("UNDEFINED_BY_VS_ERROR", resourceCulture);
            }
        }
    }
}
