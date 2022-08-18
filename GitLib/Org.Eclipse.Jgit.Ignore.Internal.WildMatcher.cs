using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Ignore.Internal {

	/// <summary>Wildmatch matcher for "double star" (&lt;code&gt;**&lt;/code&gt;) pattern only.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='WildMatcher']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/ignore/internal/WildMatcher", DoNotGenerateAcw=true)]
	public sealed partial class WildMatcher : global::Org.Eclipse.Jgit.Ignore.Internal.AbstractMatcher {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/ignore/internal/WildMatcher", typeof (WildMatcher));

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

		internal WildMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='WildMatcher']/method[@name='matches' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("matches", "(Ljava/lang/String;Z)Z", "")]
		public override sealed unsafe bool Matches (string path, bool assumeDirectory)
		{
			const string __id = "matches.(Ljava/lang/String;Z)Z";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (assumeDirectory);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='WildMatcher']/method[@name='matches' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("matches", "(Ljava/lang/String;IIZ)Z", "")]
		public override sealed unsafe bool Matches (string segment, int startIncl, int endExcl, bool assumeDirectory)
		{
			const string __id = "matches.(Ljava/lang/String;IIZ)Z";
			IntPtr native_segment = JNIEnv.NewString ((string)segment);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_segment);
				__args [1] = new JniArgumentValue (startIncl);
				__args [2] = new JniArgumentValue (endExcl);
				__args [3] = new JniArgumentValue (assumeDirectory);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_segment);
			}
		}

	}
}
