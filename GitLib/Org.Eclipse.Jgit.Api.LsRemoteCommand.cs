using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>The ls-remote command</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LsRemoteCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/LsRemoteCommand", DoNotGenerateAcw=true)]
	public partial class LsRemoteCommand : global::Org.Eclipse.Jgit.Api.TransportCommand<global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef>> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/LsRemoteCommand", typeof (LsRemoteCommand));

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

		protected LsRemoteCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">local repository or null for operation without local
		///            repository</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LsRemoteCommand']/constructor[@name='LsRemoteCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe LsRemoteCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>LsRemote</c> command with all the options and parameters
		/// collected by the setter methods (e.</summary>
		/// <returns>a collection of references in the remote repository</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LsRemoteCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/Collection;", "GetCallHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> Call ()
		{
			const string __id = "call.()Ljava/util/Collection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_callAsMap;
#pragma warning disable 0169
		static Delegate GetCallAsMapHandler ()
		{
			if (cb_callAsMap == null)
				cb_callAsMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CallAsMap);
			return cb_callAsMap;
		}

		static IntPtr n_CallAsMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.CallAsMap ());
		}
#pragma warning restore 0169

		/// <summary>Same as <c>#call()</c>, but return Map instead of Collection.</summary>
		/// <returns>a map from names to references in the remote repository</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LsRemoteCommand']/method[@name='callAsMap' and count(parameter)=0]"
		[Register ("callAsMap", "()Ljava/util/Map;", "GetCallAsMapHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> CallAsMap ()
		{
			const string __id = "callAsMap.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHeads_Z;
#pragma warning disable 0169
		static Delegate GetSetHeads_ZHandler ()
		{
			if (cb_setHeads_Z == null)
				cb_setHeads_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetHeads_Z);
			return cb_setHeads_Z;
		}

		static IntPtr n_SetHeads_Z (IntPtr jnienv, IntPtr native__this, bool heads)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeads (heads));
		}
#pragma warning restore 0169

		/// <param name="heads">heads</param>
		/// <summary>Include refs/heads in references results</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LsRemoteCommand']/method[@name='setHeads' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHeads", "(Z)Lorg/eclipse/jgit/api/LsRemoteCommand;", "GetSetHeads_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LsRemoteCommand SetHeads (bool heads)
		{
			const string __id = "setHeads.(Z)Lorg/eclipse/jgit/api/LsRemoteCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (heads);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRemote_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRemote_Ljava_lang_String_Handler ()
		{
			if (cb_setRemote_Ljava_lang_String_ == null)
				cb_setRemote_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRemote_Ljava_lang_String_);
			return cb_setRemote_Ljava_lang_String_;
		}

		static IntPtr n_SetRemote_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remote)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var remote = JNIEnv.GetString (native_remote, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRemote (remote));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="remote">remote</param>
		/// <summary>The remote (uri or name) used for the fetch operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LsRemoteCommand']/method[@name='setRemote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRemote", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/LsRemoteCommand;", "GetSetRemote_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LsRemoteCommand SetRemote (string remote)
		{
			const string __id = "setRemote.(Ljava/lang/String;)Lorg/eclipse/jgit/api/LsRemoteCommand;";
			IntPtr native_remote = JNIEnv.NewString ((string)remote);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_remote);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remote);
			}
		}

		static Delegate cb_setTags_Z;
#pragma warning disable 0169
		static Delegate GetSetTags_ZHandler ()
		{
			if (cb_setTags_Z == null)
				cb_setTags_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetTags_Z);
			return cb_setTags_Z;
		}

		static IntPtr n_SetTags_Z (IntPtr jnienv, IntPtr native__this, bool tags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTags (tags));
		}
#pragma warning restore 0169

		/// <param name="tags">tags</param>
		/// <summary>Include refs/tags in references results</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LsRemoteCommand']/method[@name='setTags' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTags", "(Z)Lorg/eclipse/jgit/api/LsRemoteCommand;", "GetSetTags_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LsRemoteCommand SetTags (bool tags)
		{
			const string __id = "setTags.(Z)Lorg/eclipse/jgit/api/LsRemoteCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tags);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUploadPack_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUploadPack_Ljava_lang_String_Handler ()
		{
			if (cb_setUploadPack_Ljava_lang_String_ == null)
				cb_setUploadPack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUploadPack_Ljava_lang_String_);
			return cb_setUploadPack_Ljava_lang_String_;
		}

		static IntPtr n_SetUploadPack_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uploadPack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uploadPack = JNIEnv.GetString (native_uploadPack, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUploadPack (uploadPack));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uploadPack">uploadPack</param>
		/// <summary>The full path of git-upload-pack on the remote host</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LsRemoteCommand']/method[@name='setUploadPack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUploadPack", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/LsRemoteCommand;", "GetSetUploadPack_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LsRemoteCommand SetUploadPack (string uploadPack)
		{
			const string __id = "setUploadPack.(Ljava/lang/String;)Lorg/eclipse/jgit/api/LsRemoteCommand;";
			IntPtr native_uploadPack = JNIEnv.NewString ((string)uploadPack);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uploadPack);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uploadPack);
			}
		}

	}
}
