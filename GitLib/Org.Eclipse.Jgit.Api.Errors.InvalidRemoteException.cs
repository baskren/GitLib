using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api.Errors {

	/// <summary>Exception thrown when a fetch command was called with an invalid remote</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='InvalidRemoteException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/errors/InvalidRemoteException", DoNotGenerateAcw=true)]
	public partial class InvalidRemoteException : global::Org.Eclipse.Jgit.Api.Errors.GitAPIException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/errors/InvalidRemoteException", typeof (InvalidRemoteException));

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

		protected InvalidRemoteException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="msg">message describing the invalid remote.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='InvalidRemoteException']/constructor[@name='InvalidRemoteException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe InvalidRemoteException (string msg) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_msg = JNIEnv.NewString ((string)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		/// <param name="msg">message describing the invalid remote.</param>
		/// <param name="cause">why the remote is invalid.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='InvalidRemoteException']/constructor[@name='InvalidRemoteException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe InvalidRemoteException (string msg, global::Java.Lang.Throwable cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_msg = JNIEnv.NewString ((string)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (cause);
			}
		}

	}
}
