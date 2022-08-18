using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util.IO {

	/// <summary>An input stream which canonicalizes EOLs bytes on the fly to '\n'.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='EolCanonicalizingInputStream']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/io/EolCanonicalizingInputStream", DoNotGenerateAcw=true)]
	public partial class EolCanonicalizingInputStream : global::Java.IO.InputStream {
		/// <summary>A special exception thrown when <c>EolCanonicalizingInputStream</c> is
		/// told to throw an exception when attempting to read a binary file.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='EolCanonicalizingInputStream.IsBinaryException']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/io/EolCanonicalizingInputStream$IsBinaryException", DoNotGenerateAcw=true)]
		public partial class IsBinaryException : global::Java.IO.IOException {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/io/EolCanonicalizingInputStream$IsBinaryException", typeof (IsBinaryException));

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

			protected IsBinaryException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/io/EolCanonicalizingInputStream", typeof (EolCanonicalizingInputStream));

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

		protected EolCanonicalizingInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="in">raw input stream</param>
		/// <param name="detectBinary">whether binaries should be detected</param>
		/// <summary>Creates a new InputStream, wrapping the specified stream</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='EolCanonicalizingInputStream']/constructor[@name='EolCanonicalizingInputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/InputStream;Z)V", "")]
		public unsafe EolCanonicalizingInputStream (global::System.IO.Stream @in, bool detectBinary) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (detectBinary);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		/// <param name="in">raw input stream</param>
		/// <param name="detectBinary">whether binaries should be detected</param>
		/// <param name="abortIfBinary">throw an IOException if the file is binary</param>
		/// <summary>Creates a new InputStream, wrapping the specified stream</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='EolCanonicalizingInputStream']/constructor[@name='EolCanonicalizingInputStream' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/InputStream;ZZ)V", "")]
		public unsafe EolCanonicalizingInputStream (global::System.IO.Stream @in, bool detectBinary, bool abortIfBinary) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;ZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (detectBinary);
				__args [2] = new JniArgumentValue (abortIfBinary);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate cb_isBinary;
#pragma warning disable 0169
		static Delegate GetIsBinaryHandler ()
		{
			if (cb_isBinary == null)
				cb_isBinary = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBinary);
			return cb_isBinary;
		}

		static bool n_IsBinary (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.EolCanonicalizingInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBinary;
		}
#pragma warning restore 0169

		/// <returns>true if the stream has detected as a binary so far</returns>
		public virtual unsafe bool IsBinary {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='EolCanonicalizingInputStream']/method[@name='isBinary' and count(parameter)=0]"
			[Register ("isBinary", "()Z", "GetIsBinaryHandler")]
			get {
				const string __id = "isBinary.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.EolCanonicalizingInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='EolCanonicalizingInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		public override unsafe int Read ()
		{
			const string __id = "read.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
