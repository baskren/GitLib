using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util.IO {

	/// <summary>Triggers an interrupt on the calling thread if it doesn't complete a block.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='InterruptTimer']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/io/InterruptTimer", DoNotGenerateAcw=true)]
	public sealed partial class InterruptTimer : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/io/InterruptTimer", typeof (InterruptTimer));

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

		internal InterruptTimer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a new timer with a default thread name.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='InterruptTimer']/constructor[@name='InterruptTimer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InterruptTimer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="threadName">name of the timer thread.</param>
		/// <summary>Create a new timer to signal on interrupt on the caller.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='InterruptTimer']/constructor[@name='InterruptTimer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe InterruptTimer (string threadName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_threadName = JNIEnv.NewString ((string)threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_threadName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		/// <param name="timeout">number of milliseconds before the interrupt should trigger.
		///            Must be &amp;gt; 0.</param>
		/// <summary>Arm the interrupt timer before entering a blocking operation.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='InterruptTimer']/method[@name='begin' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("begin", "(I)V", "")]
		public unsafe void Begin (int timeout)
		{
			const string __id = "begin.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <summary>Disable the interrupt timer, as the operation is complete.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='InterruptTimer']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "")]
		public unsafe void End ()
		{
			const string __id = "end.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <summary>Shutdown the timer thread, and wait for it to terminate.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='InterruptTimer']/method[@name='terminate' and count(parameter)=0]"
		[Register ("terminate", "()V", "")]
		public unsafe void Terminate ()
		{
			const string __id = "terminate.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
