﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WAGO_CodesysV23_Protocols.DataAccess.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WAGO_CodesysV23_Protocols.DataAccess.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] IEC_104_Conf {
            get {
                object obj = ResourceManager.GetObject("IEC_104_Conf", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-16&quot;?&gt;
        ///&lt;IEC60870ProjectDescription Version=&quot;2.9.0&quot; Guid=&quot;BCAB5D0D-5CE5-406E-8736-146506C81871&quot; Generated=&quot;01.11.2021 12:10:54&quot;&gt;
        ///  &lt;CConfiguration Name=&quot;IEC60870 Konfiguration&quot;&gt;
        ///    &lt;Text&gt;IEC60870 Konfiguration&lt;/Text&gt;
        ///    &lt;Parameter Name=&quot;AfzDefault&quot; Type=&quot;Time&quot; Val=&quot;t#2s&quot; /&gt;
        ///    &lt;Parameter Name=&quot;AfzKurz&quot; Type=&quot;Time&quot; Val=&quot;t#500ms&quot; /&gt;
        ///    &lt;Parameter Name=&quot;AfzLang&quot; Type=&quot;Time&quot; Val=&quot;t#5s&quot; /&gt;
        ///    &lt;Parameter Name=&quot;ClockSyncMode&quot; Type=&quot;ENUM_TimeSync&quot; Val=&quot;2&quot; /&gt;
        ///    &lt;Paramet [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IEC_104_Conf1 {
            get {
                return ResourceManager.GetString("IEC_104_Conf1", resourceCulture);
            }
        }
    }
}
