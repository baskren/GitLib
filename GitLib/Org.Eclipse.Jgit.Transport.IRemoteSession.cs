using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Create a remote "session" for executing remote commands.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='RemoteSession']"
	[Register ("org/eclipse/jgit/transport/RemoteSession", "", "Org.Eclipse.Jgit.Transport.IRemoteSessionInvoker")]
	public partial interface IRemoteSession : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='RemoteSession']/method[@name='disconnect' and count(parameter)=0]"
		/// <summary>Disconnect the remote session</summary>
		[Register ("disconnect", "()V", "GetDisconnectHandler:Org.Eclipse.Jgit.Transport.IRemoteSessionInvoker, AndroidBindableLibrary")]
		void Disconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='RemoteSession']/method[@name='exec' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		/// <param name="commandName">command to execute</param>
		/// <param name="timeout">timeout value, in seconds, for command execution</param>
		/// <summary>Generate a new remote process to execute the given command.</summary>
		/// <returns>a new remote process</returns>
		[Register ("exec", "(Ljava/lang/String;I)Ljava/lang/Process;", "GetExec_Ljava_lang_String_IHandler:Org.Eclipse.Jgit.Transport.IRemoteSessionInvoker, AndroidBindableLibrary")]
		global::Java.Lang.Process Exec (string commandName, int timeout);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/RemoteSession", DoNotGenerateAcw=true)]
	internal partial class IRemoteSessionInvoker : global::Java.Lang.Object, IRemoteSession {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RemoteSession", typeof (IRemoteSessionInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IRemoteSession GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoteSession> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.RemoteSession'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoteSessionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRemoteSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		IntPtr id_disconnect;
		public unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
		}

		static Delegate cb_exec_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetExec_Ljava_lang_String_IHandler ()
		{
			if (cb_exec_Ljava_lang_String_I == null)
				cb_exec_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_Exec_Ljava_lang_String_I);
			return cb_exec_Ljava_lang_String_I;
		}

		static IntPtr n_Exec_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_commandName, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRemoteSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commandName = JNIEnv.GetString (native_commandName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Exec (commandName, timeout));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_exec_Ljava_lang_String_I;
		public unsafe global::Java.Lang.Process Exec (string commandName, int timeout)
		{
			if (id_exec_Ljava_lang_String_I == IntPtr.Zero)
				id_exec_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "exec", "(Ljava/lang/String;I)Ljava/lang/Process;");
			IntPtr native_commandName = JNIEnv.NewString ((string)commandName);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_commandName);
			__args [1] = new JValue (timeout);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Process> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_exec_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_commandName);
			return __ret;
		}

	}
}
