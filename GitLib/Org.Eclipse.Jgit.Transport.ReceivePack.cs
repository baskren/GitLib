using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Implements the server side of a push connection, receiving objects.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceivePack']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/ReceivePack", DoNotGenerateAcw=true)]
	public partial class ReceivePack : global::Org.Eclipse.Jgit.Transport.BaseReceivePack {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/ReceivePack", typeof (ReceivePack));

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

		protected ReceivePack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="into">the destination repository.</param>
		/// <summary>Create a new pack receive for an open repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceivePack']/constructor[@name='ReceivePack' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe ReceivePack (global::Org.Eclipse.Jgit.Lib.Repository into) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((into == null) ? IntPtr.Zero : ((global::Java.Lang.Object) into).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (into);
			}
		}

		static Delegate cb_getLockMessageProcessName;
#pragma warning disable 0169
		static Delegate GetGetLockMessageProcessNameHandler ()
		{
			if (cb_getLockMessageProcessName == null)
				cb_getLockMessageProcessName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLockMessageProcessName);
			return cb_getLockMessageProcessName;
		}

		static IntPtr n_GetLockMessageProcessName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LockMessageProcessName);
		}
#pragma warning restore 0169

		protected override unsafe string LockMessageProcessName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceivePack']/method[@name='getLockMessageProcessName' and count(parameter)=0]"
			[Register ("getLockMessageProcessName", "()Ljava/lang/String;", "GetGetLockMessageProcessNameHandler")]
			get {
				const string __id = "getLockMessageProcessName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPostReceiveHook;
#pragma warning disable 0169
		static Delegate GetGetPostReceiveHookHandler ()
		{
			if (cb_getPostReceiveHook == null)
				cb_getPostReceiveHook = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPostReceiveHook);
			return cb_getPostReceiveHook;
		}

		static IntPtr n_GetPostReceiveHook (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PostReceiveHook);
		}
#pragma warning restore 0169

		static Delegate cb_setPostReceiveHook_Lorg_eclipse_jgit_transport_PostReceiveHook_;
#pragma warning disable 0169
		static Delegate GetSetPostReceiveHook_Lorg_eclipse_jgit_transport_PostReceiveHook_Handler ()
		{
			if (cb_setPostReceiveHook_Lorg_eclipse_jgit_transport_PostReceiveHook_ == null)
				cb_setPostReceiveHook_Lorg_eclipse_jgit_transport_PostReceiveHook_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPostReceiveHook_Lorg_eclipse_jgit_transport_PostReceiveHook_);
			return cb_setPostReceiveHook_Lorg_eclipse_jgit_transport_PostReceiveHook_;
		}

		static void n_SetPostReceiveHook_Lorg_eclipse_jgit_transport_PostReceiveHook_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var h = (global::Org.Eclipse.Jgit.Transport.IPostReceiveHook)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPostReceiveHook> (native_h, JniHandleOwnership.DoNotTransfer);
			__this.PostReceiveHook = h;
		}
#pragma warning restore 0169

		/// <returns>the hook invoked after updates occur.</returns>
		/// <summary>Set the hook which is invoked after commands are executed.</summary>
		/// <param name="h">the hook instance; may be null to disable the hook.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.IPostReceiveHook PostReceiveHook {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceivePack']/method[@name='getPostReceiveHook' and count(parameter)=0]"
			[Register ("getPostReceiveHook", "()Lorg/eclipse/jgit/transport/PostReceiveHook;", "GetGetPostReceiveHookHandler")]
			get {
				const string __id = "getPostReceiveHook.()Lorg/eclipse/jgit/transport/PostReceiveHook;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPostReceiveHook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceivePack']/method[@name='setPostReceiveHook' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PostReceiveHook']]"
			[Register ("setPostReceiveHook", "(Lorg/eclipse/jgit/transport/PostReceiveHook;)V", "GetSetPostReceiveHook_Lorg_eclipse_jgit_transport_PostReceiveHook_Handler")]
			set {
				const string __id = "setPostReceiveHook.(Lorg/eclipse/jgit/transport/PostReceiveHook;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getPreReceiveHook;
#pragma warning disable 0169
		static Delegate GetGetPreReceiveHookHandler ()
		{
			if (cb_getPreReceiveHook == null)
				cb_getPreReceiveHook = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPreReceiveHook);
			return cb_getPreReceiveHook;
		}

		static IntPtr n_GetPreReceiveHook (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreReceiveHook);
		}
#pragma warning restore 0169

		static Delegate cb_setPreReceiveHook_Lorg_eclipse_jgit_transport_PreReceiveHook_;
#pragma warning disable 0169
		static Delegate GetSetPreReceiveHook_Lorg_eclipse_jgit_transport_PreReceiveHook_Handler ()
		{
			if (cb_setPreReceiveHook_Lorg_eclipse_jgit_transport_PreReceiveHook_ == null)
				cb_setPreReceiveHook_Lorg_eclipse_jgit_transport_PreReceiveHook_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPreReceiveHook_Lorg_eclipse_jgit_transport_PreReceiveHook_);
			return cb_setPreReceiveHook_Lorg_eclipse_jgit_transport_PreReceiveHook_;
		}

		static void n_SetPreReceiveHook_Lorg_eclipse_jgit_transport_PreReceiveHook_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var h = (global::Org.Eclipse.Jgit.Transport.IPreReceiveHook)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreReceiveHook> (native_h, JniHandleOwnership.DoNotTransfer);
			__this.PreReceiveHook = h;
		}
#pragma warning restore 0169

		/// <returns>the hook invoked before updates occur.</returns>
		/// <summary>Set the hook which is invoked prior to commands being executed.</summary>
		/// <param name="h">the hook instance; may be null to disable the hook.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.IPreReceiveHook PreReceiveHook {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceivePack']/method[@name='getPreReceiveHook' and count(parameter)=0]"
			[Register ("getPreReceiveHook", "()Lorg/eclipse/jgit/transport/PreReceiveHook;", "GetGetPreReceiveHookHandler")]
			get {
				const string __id = "getPreReceiveHook.()Lorg/eclipse/jgit/transport/PreReceiveHook;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreReceiveHook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceivePack']/method[@name='setPreReceiveHook' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PreReceiveHook']]"
			[Register ("setPreReceiveHook", "(Lorg/eclipse/jgit/transport/PreReceiveHook;)V", "GetSetPreReceiveHook_Lorg_eclipse_jgit_transport_PreReceiveHook_Handler")]
			set {
				const string __id = "setPreReceiveHook.(Lorg/eclipse/jgit/transport/PreReceiveHook;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_receive_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetReceive_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_receive_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_ == null)
				cb_receive_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Receive_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_);
			return cb_receive_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_;
		}

		static void n_Receive_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input, IntPtr native_output, IntPtr native_messages)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_input, JniHandleOwnership.DoNotTransfer);
			var output = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_output, JniHandleOwnership.DoNotTransfer);
			var messages = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_messages, JniHandleOwnership.DoNotTransfer);
			__this.Receive (input, output, messages);
		}
#pragma warning restore 0169

		/// <param name="input">raw input to read client commands and pack data from. Caller
		///            must ensure the input is buffered, otherwise read performance
		///            may suffer.</param>
		/// <param name="output">response back to the Git network client. Caller must ensure
		///            the output is buffered, otherwise write performance may
		///            suffer.</param>
		/// <param name="messages">secondary "notice" channel to send additional messages out
		///            through. When run over SSH this should be tied back to the
		///            standard error channel of the command execution. For most
		///            other network connections this should be null.</param>
		/// <summary>Execute the receive task on the socket.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceivePack']/method[@name='receive' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='java.io.OutputStream']]"
		[Register ("receive", "(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/io/OutputStream;)V", "GetReceive_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Receive (global::System.IO.Stream input, global::System.IO.Stream output, global::System.IO.Stream messages)
		{
			const string __id = "receive.(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/io/OutputStream;)V";
			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			IntPtr native_output = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (output);
			IntPtr native_messages = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (messages);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (native_output);
				__args [2] = new JniArgumentValue (native_messages);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_output);
				JNIEnv.DeleteLocalRef (native_messages);
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (output);
				global::System.GC.KeepAlive (messages);
			}
		}

		static Delegate cb_setEchoCommandFailures_Z;
#pragma warning disable 0169
		static Delegate GetSetEchoCommandFailures_ZHandler ()
		{
			if (cb_setEchoCommandFailures_Z == null)
				cb_setEchoCommandFailures_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEchoCommandFailures_Z);
			return cb_setEchoCommandFailures_Z;
		}

		static void n_SetEchoCommandFailures_Z (IntPtr jnienv, IntPtr native__this, bool echo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEchoCommandFailures (echo);
		}
#pragma warning restore 0169

		/// <param name="echo">if true this class will report command failures as warning
		///            messages before sending the command results. This is usually
		///            not necessary, but may help buggy Git clients that discard the
		///            errors when all branches fail.</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceivePack']/method[@name='setEchoCommandFailures' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEchoCommandFailures", "(Z)V", "GetSetEchoCommandFailures_ZHandler")]
		public virtual unsafe void SetEchoCommandFailures (bool echo)
		{
			const string __id = "setEchoCommandFailures.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (echo);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
