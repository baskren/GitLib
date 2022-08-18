using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Create an empty git repository or reinitalize an existing one</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='InitCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/InitCommand", DoNotGenerateAcw=true)]
	public partial class InitCommand : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/InitCommand", typeof (InitCommand));

		internal static IntPtr class_ref {
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

		protected InitCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='InitCommand']/constructor[@name='InitCommand' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InitCommand () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}
        /*
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.InitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Init</c> command.</summary>
		/// <returns>the newly created <c>Git</c> object with associated repository</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='InitCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/api/Git;", "GetCallHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.Git Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/api/Git;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}*/

        //[Register("call", "()Ljava/lang/Object;", "GetCallHandler")]
        global::Java.Lang.Object Java.Util.Concurrent.ICallable.Call() { throw new NotImplementedException(); }


        static Delegate cb_setBare_Z;
#pragma warning disable 0169
		static Delegate GetSetBare_ZHandler ()
		{
			if (cb_setBare_Z == null)
				cb_setBare_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetBare_Z);
			return cb_setBare_Z;
		}

		static IntPtr n_SetBare_Z (IntPtr jnienv, IntPtr native__this, bool bare)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.InitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBare (bare));
		}
#pragma warning restore 0169

		/// <param name="bare">whether the repository is bare or not</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='InitCommand']/method[@name='setBare' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setBare", "(Z)Lorg/eclipse/jgit/api/InitCommand;", "GetSetBare_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.InitCommand SetBare (bool bare)
		{
			const string __id = "setBare.(Z)Lorg/eclipse/jgit/api/InitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bare);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.InitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDirectory_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetDirectory_Ljava_io_File_Handler ()
		{
			if (cb_setDirectory_Ljava_io_File_ == null)
				cb_setDirectory_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDirectory_Ljava_io_File_);
			return cb_setDirectory_Ljava_io_File_;
		}

		static IntPtr n_SetDirectory_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_directory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.InitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var directory = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_directory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDirectory (directory));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="directory">the directory to init to</param>
		/// <summary>The optional directory associated with the init operation.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='InitCommand']/method[@name='setDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setDirectory", "(Ljava/io/File;)Lorg/eclipse/jgit/api/InitCommand;", "GetSetDirectory_Ljava_io_File_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.InitCommand SetDirectory (global::Java.IO.File directory)
		{
			const string __id = "setDirectory.(Ljava/io/File;)Lorg/eclipse/jgit/api/InitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.InitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (directory);
			}
		}

		static Delegate cb_setGitDir_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetGitDir_Ljava_io_File_Handler ()
		{
			if (cb_setGitDir_Ljava_io_File_ == null)
				cb_setGitDir_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetGitDir_Ljava_io_File_);
			return cb_setGitDir_Ljava_io_File_;
		}

		static IntPtr n_SetGitDir_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gitDir)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.InitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gitDir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_gitDir, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGitDir (gitDir));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="gitDir">the repository meta directory</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='InitCommand']/method[@name='setGitDir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setGitDir", "(Ljava/io/File;)Lorg/eclipse/jgit/api/InitCommand;", "GetSetGitDir_Ljava_io_File_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.InitCommand SetGitDir (global::Java.IO.File gitDir)
		{
			const string __id = "setGitDir.(Ljava/io/File;)Lorg/eclipse/jgit/api/InitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gitDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gitDir).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.InitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (gitDir);
			}
		}

	}
}
