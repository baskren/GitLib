using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>An exception thrown when a <c>CredentialItem</c> is requested from a
	/// <c>CredentialsProvider</c> which is not supported by this provider.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='UnsupportedCredentialItem']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/UnsupportedCredentialItem", DoNotGenerateAcw=true)]
	public partial class UnsupportedCredentialItem : global::Java.Lang.RuntimeException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/UnsupportedCredentialItem", typeof (UnsupportedCredentialItem));

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

		protected UnsupportedCredentialItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="uri">URI used for transport</param>
		/// <param name="s">message</param>
		/// <summary>Constructs an UnsupportedCredentialItem with the specified detail message
		/// prefixed with provided URI.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='UnsupportedCredentialItem']/constructor[@name='UnsupportedCredentialItem' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/transport/URIish;Ljava/lang/String;)V", "")]
		public unsafe UnsupportedCredentialItem (global::Org.Eclipse.Jgit.Transport.URIish uri, string s) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/transport/URIish;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_s);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				global::System.GC.KeepAlive (uri);
			}
		}

	}
}
