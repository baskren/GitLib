using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Remove files from the index and working directory (or optionally only from
	/// the index).</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RmCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/RmCommand", DoNotGenerateAcw=true)]
	public partial class RmCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Dircache.DirCache> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/RmCommand", typeof (RmCommand));

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

		protected RmCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RmCommand']/constructor[@name='RmCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe RmCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_addFilepattern_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddFilepattern_Ljava_lang_String_Handler ()
		{
			if (cb_addFilepattern_Ljava_lang_String_ == null)
				cb_addFilepattern_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddFilepattern_Ljava_lang_String_);
			return cb_addFilepattern_Ljava_lang_String_;
		}

		static IntPtr n_AddFilepattern_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filepattern)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RmCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filepattern = JNIEnv.GetString (native_filepattern, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddFilepattern (filepattern));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="filepattern">repository-relative path of file to remove (with
		///            &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RmCommand']/method[@name='addFilepattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addFilepattern", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/RmCommand;", "GetAddFilepattern_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RmCommand AddFilepattern (string filepattern)
		{
			const string __id = "addFilepattern.(Ljava/lang/String;)Lorg/eclipse/jgit/api/RmCommand;";
			IntPtr native_filepattern = JNIEnv.NewString ((string)filepattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filepattern);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RmCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filepattern);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RmCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Rm</c> command.</summary>
		/// <returns>the DirCache after Rm</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RmCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/dircache/DirCache;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Dircache.DirCache Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCached_Z;
#pragma warning disable 0169
		static Delegate GetSetCached_ZHandler ()
		{
			if (cb_setCached_Z == null)
				cb_setCached_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCached_Z);
			return cb_setCached_Z;
		}

		static IntPtr n_SetCached_Z (IntPtr jnienv, IntPtr native__this, bool cached)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RmCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCached (cached));
		}
#pragma warning restore 0169

		/// <param name="cached">true if files should only be removed from index, false if
		///            files should also be deleted from the working directory</param>
		/// <summary>Only remove the specified files from the index.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RmCommand']/method[@name='setCached' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCached", "(Z)Lorg/eclipse/jgit/api/RmCommand;", "GetSetCached_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RmCommand SetCached (bool cached)
		{
			const string __id = "setCached.(Z)Lorg/eclipse/jgit/api/RmCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cached);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RmCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
