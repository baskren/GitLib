using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>FS implementaton for Java5</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS_POSIX_Java5']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/FS_POSIX_Java5", DoNotGenerateAcw=true)]
	public partial class FS_POSIX_Java5 : global::Org.Eclipse.Jgit.Util.FS_POSIX {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/FS_POSIX_Java5", typeof (FS_POSIX_Java5));

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

		protected FS_POSIX_Java5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Constructor</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS_POSIX_Java5']/constructor[@name='FS_POSIX_Java5' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FS_POSIX_Java5 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="src">instance whose attributes to copy</param>
		/// <summary>Constructor</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS_POSIX_Java5']/constructor[@name='FS_POSIX_Java5' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.FS']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/util/FS;)V", "")]
		public unsafe FS_POSIX_Java5 (global::Org.Eclipse.Jgit.Util.FS src) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/util/FS;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		static Delegate cb_canExecute_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetCanExecute_Ljava_io_File_Handler ()
		{
			if (cb_canExecute_Ljava_io_File_ == null)
				cb_canExecute_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanExecute_Ljava_io_File_);
			return cb_canExecute_Ljava_io_File_;
		}

		static bool n_CanExecute_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS_POSIX_Java5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_f, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanExecute (f);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS_POSIX_Java5']/method[@name='canExecute' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("canExecute", "(Ljava/io/File;)Z", "GetCanExecute_Ljava_io_File_Handler")]
		public override unsafe bool CanExecute (global::Java.IO.File f)
		{
			const string __id = "canExecute.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		static Delegate cb_newInstance;
#pragma warning disable 0169
		static Delegate GetNewInstanceHandler ()
		{
			if (cb_newInstance == null)
				cb_newInstance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewInstance);
			return cb_newInstance;
		}

		static IntPtr n_NewInstance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS_POSIX_Java5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewInstance ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS_POSIX_Java5']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lorg/eclipse/jgit/util/FS;", "GetNewInstanceHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Util.FS NewInstance ()
		{
			const string __id = "newInstance.()Lorg/eclipse/jgit/util/FS;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_retryFailedLockFileCommit;
#pragma warning disable 0169
		static Delegate GetRetryFailedLockFileCommitHandler ()
		{
			if (cb_retryFailedLockFileCommit == null)
				cb_retryFailedLockFileCommit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_RetryFailedLockFileCommit);
			return cb_retryFailedLockFileCommit;
		}

		static bool n_RetryFailedLockFileCommit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS_POSIX_Java5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryFailedLockFileCommit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS_POSIX_Java5']/method[@name='retryFailedLockFileCommit' and count(parameter)=0]"
		[Register ("retryFailedLockFileCommit", "()Z", "GetRetryFailedLockFileCommitHandler")]
		public override unsafe bool RetryFailedLockFileCommit ()
		{
			const string __id = "retryFailedLockFileCommit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setExecute_Ljava_io_File_Z;
#pragma warning disable 0169
		static Delegate GetSetExecute_Ljava_io_File_ZHandler ()
		{
			if (cb_setExecute_Ljava_io_File_Z == null)
				cb_setExecute_Ljava_io_File_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_SetExecute_Ljava_io_File_Z);
			return cb_setExecute_Ljava_io_File_Z;
		}

		static bool n_SetExecute_Ljava_io_File_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_f, bool canExec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS_POSIX_Java5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_f, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetExecute (f, canExec);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS_POSIX_Java5']/method[@name='setExecute' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='boolean']]"
		[Register ("setExecute", "(Ljava/io/File;Z)Z", "GetSetExecute_Ljava_io_File_ZHandler")]
		public override unsafe bool SetExecute (global::Java.IO.File f, bool canExec)
		{
			const string __id = "setExecute.(Ljava/io/File;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (canExec);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		static Delegate cb_supportsExecute;
#pragma warning disable 0169
		static Delegate GetSupportsExecuteHandler ()
		{
			if (cb_supportsExecute == null)
				cb_supportsExecute = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_SupportsExecute);
			return cb_supportsExecute;
		}

		static bool n_SupportsExecute (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS_POSIX_Java5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SupportsExecute ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS_POSIX_Java5']/method[@name='supportsExecute' and count(parameter)=0]"
		[Register ("supportsExecute", "()Z", "GetSupportsExecuteHandler")]
		public override unsafe bool SupportsExecute ()
		{
			const string __id = "supportsExecute.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
