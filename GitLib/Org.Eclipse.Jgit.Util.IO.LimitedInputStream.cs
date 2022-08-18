using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util.IO {

	/// <summary>Wraps a <c>InputStream</c>, limiting the number of bytes which can be
	/// read.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='LimitedInputStream']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/io/LimitedInputStream", DoNotGenerateAcw=true)]
	public abstract partial class LimitedInputStream : global::Java.IO.FilterInputStream {

		/// <summary>Max number of bytes to be read from the wrapped stream</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='LimitedInputStream']/field[@name='limit']"
		[Register ("limit")]
		protected long Limit {
			get {
				const string __id = "limit.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "limit.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/io/LimitedInputStream", typeof (LimitedInputStream));

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

		protected LimitedInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="in">an InputStream</param>
		/// <param name="limit">max number of bytes to read from the InputStream</param>
		/// <summary>Create a new LimitedInputStream</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='LimitedInputStream']/constructor[@name='LimitedInputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Ljava/io/InputStream;J)V", "")]
		protected unsafe LimitedInputStream (global::System.IO.Stream @in, long limit) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (limit);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate cb_limitExceeded;
#pragma warning disable 0169
		static Delegate GetLimitExceededHandler ()
		{
			if (cb_limitExceeded == null)
				cb_limitExceeded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_LimitExceeded);
			return cb_limitExceeded;
		}

		static void n_LimitExceeded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.LimitedInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LimitExceeded ();
		}
#pragma warning restore 0169

		/// <summary>Called when trying to read past the given <c>#limit</c> and the wrapped
		/// InputStream <c>#in</c> hasn't yet reached its EOF</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='LimitedInputStream']/method[@name='limitExceeded' and count(parameter)=0]"
		[Register ("limitExceeded", "()V", "GetLimitExceededHandler")]
		protected abstract void LimitExceeded ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/util/io/LimitedInputStream", DoNotGenerateAcw=true)]
	internal partial class LimitedInputStreamInvoker : LimitedInputStream {
		public LimitedInputStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/io/LimitedInputStream", typeof (LimitedInputStreamInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		/// <summary>Called when trying to read past the given <c>#limit</c> and the wrapped
		/// InputStream <c>#in</c> hasn't yet reached its EOF</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='LimitedInputStream']/method[@name='limitExceeded' and count(parameter)=0]"
		[Register ("limitExceeded", "()V", "GetLimitExceededHandler")]
		protected override unsafe void LimitExceeded ()
		{
			const string __id = "limitExceeded.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
