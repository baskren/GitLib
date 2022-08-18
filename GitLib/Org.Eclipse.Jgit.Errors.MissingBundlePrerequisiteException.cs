using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>Indicates a base/common object was required, but is not found.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='MissingBundlePrerequisiteException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/MissingBundlePrerequisiteException", DoNotGenerateAcw=true)]
	public partial class MissingBundlePrerequisiteException : global::Org.Eclipse.Jgit.Errors.TransportException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/MissingBundlePrerequisiteException", typeof (MissingBundlePrerequisiteException));

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

		protected MissingBundlePrerequisiteException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="uri">URI used for transport</param>
		/// <param name="missingCommits">the Map of the base/common object(s) we don't have. Keys are
		///            ids of the missing objects and values are short descriptions.</param>
		/// <summary>Constructs a MissingBundlePrerequisiteException for a set of objects.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='MissingBundlePrerequisiteException']/constructor[@name='MissingBundlePrerequisiteException' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='java.util.Map&lt;org.eclipse.jgit.lib.ObjectId, java.lang.String&gt;']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/transport/URIish;Ljava/util/Map;)V", "")]
		public unsafe MissingBundlePrerequisiteException (global::Org.Eclipse.Jgit.Transport.URIish uri, global::System.Collections.Generic.IDictionary<global::Org.Eclipse.Jgit.Lib.ObjectId, string> missingCommits) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/transport/URIish;Ljava/util/Map;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_missingCommits = global::Android.Runtime.JavaDictionary<global::Org.Eclipse.Jgit.Lib.ObjectId, string>.ToLocalJniHandle (missingCommits);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_missingCommits);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_missingCommits);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (missingCommits);
			}
		}

	}
}
