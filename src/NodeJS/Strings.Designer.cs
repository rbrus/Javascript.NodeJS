﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jering.Javascript.NodeJS {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Jering.Javascript.NodeJS.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to If moduleSourceType is cache, moduleSource cannot be null..
        /// </summary>
        internal static string ArgumentException_InvocationRequest_ModuleSourceCannotBeNull {
            get {
                return ResourceManager.GetString("ArgumentException_InvocationRequest_ModuleSourceCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If moduleSourceType is file or string, moduleSource cannot be null, whitespace or an empty string..
        /// </summary>
        internal static string ArgumentException_InvocationRequest_ModuleSourceCannotBeNullWhitespaceOrAnEmptyString {
            get {
                return ResourceManager.GetString("ArgumentException_InvocationRequest_ModuleSourceCannotBeNullWhitespaceOrAnEmptySt" +
                        "ring", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If moduleSourceType is stream, moduleStreamSource cannot be null..
        /// </summary>
        internal static string ArgumentException_InvocationRequest_ModuleStreamSourceCannotBeNull {
            get {
                return ResourceManager.GetString("ArgumentException_InvocationRequest_ModuleStreamSourceCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process has exited..
        /// </summary>
        internal static string ArgumentException_NodeJSProcess_ProcessHasExited {
            get {
                return ResourceManager.GetString("ArgumentException_NodeJSProcess_ProcessHasExited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process has not been started or has been disposed of..
        /// </summary>
        internal static string ArgumentException_NodeJSProcess_ProcessHasNotBeenStartedOrHasBeenDisposed {
            get {
                return ResourceManager.GetString("ArgumentException_NodeJSProcess_ProcessHasNotBeenStartedOrHasBeenDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be empty..
        /// </summary>
        internal static string ArgumentException_Shared_ValueCannotBeEmpty {
            get {
                return ResourceManager.GetString("ArgumentException_Shared_ValueCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null, whitespace or an empty string..
        /// </summary>
        internal static string ArgumentException_Shared_ValueCannotBeNullWhitespaceOrAnEmptyString {
            get {
                return ResourceManager.GetString("ArgumentException_Shared_ValueCannotBeNullWhitespaceOrAnEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to connect to Node timed out after {0}ms. Process exited: {1}. Exit status: {2}..
        /// </summary>
        internal static string ConnectionException_OutOfProcessNodeJSService_ConnectionAttemptTimedOut {
            get {
                return ResourceManager.GetString("ConnectionException_OutOfProcessNodeJSService_ConnectionAttemptTimedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to connect to NodeJS. Refer to the inner exception for details..
        /// </summary>
        internal static string ConnectionException_OutOfProcessNodeJSService_FailedToConnect {
            get {
                return ResourceManager.GetString("ConnectionException_OutOfProcessNodeJSService_FailedToConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream is null..
        /// </summary>
        internal static string InvalidOperationException_InvocationRequest_StreamIsNull {
            get {
                return ResourceManager.GetString("InvalidOperationException_InvocationRequest_StreamIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream is unseekable..
        /// </summary>
        internal static string InvalidOperationException_InvocationRequest_StreamIsUnseekable {
            get {
                return ResourceManager.GetString("InvalidOperationException_InvocationRequest_StreamIsUnseekable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to start Node process. To resolve this:
        ///
        ///[1] Ensure that NodeJS is installed and can be found in one of the PATH directories. The current PATH enviroment variable is: {0}. Make sure that the Node executable is in one of those directories, or update your PATH.
        ///
        ///[2] Refer to the InnerException for further details..
        /// </summary>
        internal static string InvalidOperationException_NodeJSProcessFactory_FailedToStartNodeProcess {
            get {
                return ResourceManager.GetString("InvalidOperationException_NodeJSProcessFactory_FailedToStartNodeProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received a HTTP response with an unexpected status code: {0}..
        /// </summary>
        internal static string InvocationException_HttpNodeJSService_UnexpectedStatusCode {
            get {
                return ResourceManager.GetString("InvocationException_HttpNodeJSService_UnexpectedStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Node invocation timed out after {0}ms. You can change the timeout duration by setting the {1} property on {2}. Do ensure that your NodeJS function always invokes the callback (or throws an exception synchronously), even if it encounters an error..
        /// </summary>
        internal static string InvocationException_OutOfProcessNodeJSService_InvocationTimedOut {
            get {
                return ResourceManager.GetString("InvocationException_OutOfProcessNodeJSService_InvocationTimedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Before set, thread ID: {0}..
        /// </summary>
        internal static string LogDebug_OutOfProcessNodeJSService_BeforeSet {
            get {
                return ResourceManager.GetString("LogDebug_OutOfProcessNodeJSService_BeforeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Before wait, thread ID: {0}..
        /// </summary>
        internal static string LogDebug_OutOfProcessNodeJSService_BeforeWait {
            get {
                return ResourceManager.GetString("LogDebug_OutOfProcessNodeJSService_BeforeWait", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to NodeJS process: {0}..
        /// </summary>
        internal static string LogInformation_ConnectedToNodeJSProcess {
            get {
                return ResourceManager.GetString("LogInformation_ConnectedToNodeJSProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File changed: &quot;{0}&quot;. Moving to new NodeJS process..
        /// </summary>
        internal static string LogInformation_FileChangedMovingtoNewNodeJSProcess {
            get {
                return ResourceManager.GetString("LogInformation_FileChangedMovingtoNewNodeJSProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Killing NodeJS process: {0}..
        /// </summary>
        internal static string LogInformation_KillingNodeJSProcess {
            get {
                return ResourceManager.GetString("LogInformation_KillingNodeJSProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An attempt to connect to NodeJS failed. Retries remaining: {0}.
        ///Exception:
        ///  {1}.
        /// </summary>
        internal static string LogWarning_ConnectionAttemptFailed {
            get {
                return ResourceManager.GetString("LogWarning_ConnectionAttemptFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invocation attempt failed. Retries remaining: {0}.
        ///Exception:
        ///  {1}.
        /// </summary>
        internal static string LogWarning_InvocationAttemptFailed {
            get {
                return ResourceManager.GetString("LogWarning_InvocationAttemptFailed", resourceCulture);
            }
        }
    }
}
