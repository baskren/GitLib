using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a submodule add command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleAddCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/SubmoduleAddCommand", DoNotGenerateAcw=true)]
	public partial class SubmoduleAddCommand : global::Org.Eclipse.Jgit.Api.TransportCommand<global::Org.Eclipse.Jgit.Lib.Repository> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/SubmoduleAddCommand", typeof (SubmoduleAddCommand));

		internal static new IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SubmoduleAddCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleAddCommand']/constructor[@name='SubmoduleAddCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe SubmoduleAddCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>SubmoduleAddCommand</c>
		/// 
		/// The <c>Repository</c> instance returned by this command needs to be
		/// closed by the caller to free resources held by the <c>Repository</c>
		/// instance.</summary>
		/// <returns>the newly created <c>Repository</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleAddCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/lib/Repository;", "GetCallHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/lib/Repository;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPath_Ljava_lang_String_Handler ()
		{
			if (cb_setPath_Ljava_lang_String_ == null)
				cb_setPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPath_Ljava_lang_String_);
			return cb_setPath_Ljava_lang_String_;
		}

		static IntPtr n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPath (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">(with &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>Set repository-relative path of submodule</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleAddCommand']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPath", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/SubmoduleAddCommand;", "GetSetPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand SetPath (string path)
		{
			const string __id = "setPath.(Ljava/lang/String;)Lorg/eclipse/jgit/api/SubmoduleAddCommand;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (monitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">monitor</param>
		/// <summary>The progress monitor associated with the clone operation.</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleAddCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/SubmoduleAddCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/SubmoduleAddCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (monitor);
			}
		}

		static Delegate cb_setURI_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetURI_Ljava_lang_String_Handler ()
		{
			if (cb_setURI_Ljava_lang_String_ == null)
				cb_setURI_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetURI_Ljava_lang_String_);
			return cb_setURI_Ljava_lang_String_;
		}

		static IntPtr n_SetURI_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetURI (uri));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uri">uri</param>
		/// <summary>Set URI to clone submodule from</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleAddCommand']/method[@name='setURI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setURI", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/SubmoduleAddCommand;", "GetSetURI_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand SetURI (string uri)
		{
			const string __id = "setURI.(Ljava/lang/String;)Lorg/eclipse/jgit/api/SubmoduleAddCommand;";
			IntPtr native_uri = JNIEnv.NewString ((string)uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		static Delegate cb_submoduleExists;
#pragma warning disable 0169
		static Delegate GetSubmoduleExistsHandler ()
		{
			if (cb_submoduleExists == null)
				cb_submoduleExists = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_SubmoduleExists);
			return cb_submoduleExists;
		}

		static bool n_SubmoduleExists (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubmoduleExists ();
		}
#pragma warning restore 0169

		/// <summary>Is the configured already a submodule in the index?</summary>
		/// <returns>true if submodule exists in index, false otherwise</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleAddCommand']/method[@name='submoduleExists' and count(parameter)=0]"
		[Register ("submoduleExists", "()Z", "GetSubmoduleExistsHandler")]
		protected virtual unsafe bool SubmoduleExists ()
		{
			const string __id = "submoduleExists.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
