using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util.IO {

	/// <summary>InputStream with a configurable timeout.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='TimeoutInputStream']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/io/TimeoutInputStream", DoNotGenerateAcw=true)]
	public partial class TimeoutInputStream : global::Java.IO.FilterInputStream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/io/TimeoutInputStream", typeof (TimeoutInputStream));

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

		protected TimeoutInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="src">base input stream (to read from). The stream must be
		///            interruptible (most socket streams are).</param>
		/// <param name="timer">timer to manage the timeouts during reads.</param>
		/// <summary>Wrap an input stream with a timeout on all read operations.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='TimeoutInputStream']/constructor[@name='TimeoutInputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='org.eclipse.jgit.util.io.InterruptTimer']]"
		[Register (".ctor", "(Ljava/io/InputStream;Lorg/eclipse/jgit/util/io/InterruptTimer;)V", "")]
		public unsafe TimeoutInputStream (global::System.IO.Stream src, global::Org.Eclipse.Jgit.Util.IO.InterruptTimer timer) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;Lorg/eclipse/jgit/util/io/InterruptTimer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_src = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (src);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_src);
				__args [1] = new JniArgumentValue ((timer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_src);
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (timer);
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.TimeoutInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int millis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.TimeoutInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = millis;
		}
#pragma warning restore 0169

		/// <returns>number of milliseconds before aborting a read.</returns>
		/// <param name="millis">number of milliseconds before aborting a read. Must be &amp;gt; 0.</param>
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='TimeoutInputStream']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				const string __id = "getTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='TimeoutInputStream']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
			set {
				const string __id = "setTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
