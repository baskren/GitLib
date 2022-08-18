using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util.IO {

	/// <summary>Thread to copy from an input stream to an output stream.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='StreamCopyThread']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/io/StreamCopyThread", DoNotGenerateAcw=true)]
	public partial class StreamCopyThread : global::Java.Lang.Thread {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/io/StreamCopyThread", typeof (StreamCopyThread));

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

		protected StreamCopyThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="i">stream to copy from. The thread terminates when this stream
		///            reaches EOF. The thread closes this stream before it exits.</param>
		/// <param name="o">stream to copy into. The destination stream is automatically
		///            closed when the thread terminates.</param>
		/// <summary>Create a thread to copy data from an input stream to an output stream.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='StreamCopyThread']/constructor[@name='StreamCopyThread' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "")]
		public unsafe StreamCopyThread (global::System.IO.Stream i, global::System.IO.Stream o) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;Ljava/io/OutputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_i = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (i);
			IntPtr native_o = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (o);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_i);
				__args [1] = new JniArgumentValue (native_o);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_i);
				JNIEnv.DeleteLocalRef (native_o);
				global::System.GC.KeepAlive (i);
				global::System.GC.KeepAlive (o);
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.StreamCopyThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		/// <summary>Request the thread to flush the output stream as soon as possible.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='StreamCopyThread']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_halt;
#pragma warning disable 0169
		static Delegate GetHaltHandler ()
		{
			if (cb_halt == null)
				cb_halt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Halt);
			return cb_halt;
		}

		static void n_Halt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.StreamCopyThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Halt ();
		}
#pragma warning restore 0169

		/// <summary>Request that the thread terminate, and wait for it.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='StreamCopyThread']/method[@name='halt' and count(parameter)=0]"
		[Register ("halt", "()V", "GetHaltHandler")]
		public virtual unsafe void Halt ()
		{
			const string __id = "halt.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
