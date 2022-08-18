using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Indicates a transport service may not continue execution.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ServiceMayNotContinueException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/ServiceMayNotContinueException", DoNotGenerateAcw=true)]
	public partial class ServiceMayNotContinueException : global::Java.IO.IOException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/ServiceMayNotContinueException", typeof (ServiceMayNotContinueException));

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

		protected ServiceMayNotContinueException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Initialize with no message.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ServiceMayNotContinueException']/constructor[@name='ServiceMayNotContinueException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServiceMayNotContinueException () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		/// <param name="msg">a message explaining why it cannot continue. This message may
		///            be shown to an end-user.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ServiceMayNotContinueException']/constructor[@name='ServiceMayNotContinueException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ServiceMayNotContinueException (string msg) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="msg">a message explaining why it cannot continue. This message may
		///            be shown to an end-user.</param>
		/// <param name="cause">the cause of the exception.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ServiceMayNotContinueException']/constructor[@name='ServiceMayNotContinueException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe ServiceMayNotContinueException (string msg, global::Java.Lang.Throwable cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="cause">the cause of the exception.</param>
		/// <summary>Initialize with an "internal server error" message and a cause.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ServiceMayNotContinueException']/constructor[@name='ServiceMayNotContinueException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe ServiceMayNotContinueException (global::Java.Lang.Throwable cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cause);
			}
		}

		static Delegate cb_isOutput;
#pragma warning disable 0169
		static Delegate GetIsOutputHandler ()
		{
			if (cb_isOutput == null)
				cb_isOutput = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOutput);
			return cb_isOutput;
		}

		static bool n_IsOutput (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ServiceMayNotContinueException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOutput;
		}
#pragma warning restore 0169

		/// <returns>true if the message was already output to the client.</returns>
		public virtual unsafe bool IsOutput {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ServiceMayNotContinueException']/method[@name='isOutput' and count(parameter)=0]"
			[Register ("isOutput", "()Z", "GetIsOutputHandler")]
			get {
				const string __id = "isOutput.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_setOutput;
#pragma warning disable 0169
		static Delegate GetSetOutputHandler ()
		{
			if (cb_setOutput == null)
				cb_setOutput = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetOutput);
			return cb_setOutput;
		}

		static void n_SetOutput (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ServiceMayNotContinueException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOutput ();
		}
#pragma warning restore 0169

		/// <summary>Mark this message has being sent to the client.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ServiceMayNotContinueException']/method[@name='setOutput' and count(parameter)=0]"
		[Register ("setOutput", "()V", "GetSetOutputHandler")]
		public virtual unsafe void SetOutput ()
		{
			const string __id = "setOutput.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
