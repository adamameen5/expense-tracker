﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalExpenseTracker.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PersonalExpenseTracker.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Please fill in all the text fields..
        /// </summary>
        internal static string ALL_FIELDS_REQUIRED_MESSAGE {
            get {
                return ResourceManager.GetString("ALL_FIELDS_REQUIRED_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap EG_Logo {
            get {
                object obj = ResourceManager.GetObject("EG_Logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event details were successfully added!.
        /// </summary>
        internal static string EVENT_DETAILS_SUCCESSFULLY_SAVED {
            get {
                return ResourceManager.GetString("EVENT_DETAILS_SUCCESSFULLY_SAVED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your financial details were successfully added!.
        /// </summary>
        internal static string FINANCIAL_DETAILS_SUCCESSFULLY_ADDED {
            get {
                return ResourceManager.GetString("FINANCIAL_DETAILS_SUCCESSFULLY_ADDED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email or password you entered is not valid..
        /// </summary>
        internal static string INVALID_LOGIN_CREDENTIALS {
            get {
                return ResourceManager.GetString("INVALID_LOGIN_CREDENTIALS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Payee details were successfully added!.
        /// </summary>
        internal static string PAYEE_DETAILS_SUCCESSFULLY_SAVED {
            get {
                return ResourceManager.GetString("PAYEE_DETAILS_SUCCESSFULLY_SAVED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Payor details were successfully added!.
        /// </summary>
        internal static string PAYOR_DETAILS_SUCCESSFULLY_SAVED {
            get {
                return ResourceManager.GetString("PAYOR_DETAILS_SUCCESSFULLY_SAVED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your personal details were successfully added!.
        /// </summary>
        internal static string PERSONAL_DETAILS_SUCCESSFULLY_ADDED {
            get {
                return ResourceManager.GetString("PERSONAL_DETAILS_SUCCESSFULLY_ADDED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to go back to the dashboard?.
        /// </summary>
        internal static string RedirectToDashboardConfirmationMessage {
            get {
                return ResourceManager.GetString("RedirectToDashboardConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your account is now created!.
        /// </summary>
        internal static string SIGN_UP_SUCCESSFUL_MESSAGE {
            get {
                return ResourceManager.GetString("SIGN_UP_SUCCESSFUL_MESSAGE", resourceCulture);
            }
        }
    }
}
