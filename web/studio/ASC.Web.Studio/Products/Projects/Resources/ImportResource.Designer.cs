﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASC.Web.Projects.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ImportResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ImportResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASC.Web.Projects.Resources.ImportResource", typeof(ImportResource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty Email.
        /// </summary>
        public static string EmptyEmail {
            get {
                return ResourceManager.GetString("EmptyEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URL field is empty.
        /// </summary>
        public static string EmptyURL {
            get {
                return ResourceManager.GetString("EmptyURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Importing completed.
        /// </summary>
        public static string ImportCompleted {
            get {
                return ResourceManager.GetString("ImportCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while importing.
        /// </summary>
        public static string ImportFailed {
            get {
                return ResourceManager.GetString("ImportFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid company URL..
        /// </summary>
        public static string InvalidCompaniUrl {
            get {
                return ResourceManager.GetString("InvalidCompaniUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid email..
        /// </summary>
        public static string InvalidEmail {
            get {
                return ResourceManager.GetString("InvalidEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Importing from Basecamp.
        /// </summary>
        public static string PopupPanelHeader {
            get {
                return ResourceManager.GetString("PopupPanelHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to awaiting.
        /// </summary>
        public static string StatusAwaiting {
            get {
                return ResourceManager.GetString("StatusAwaiting", resourceCulture);
            }
        }
    }
}
