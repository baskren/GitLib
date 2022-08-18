using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk.Filter {

	/// <summary>Matches only commits whose author name matches the pattern.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='AuthorRevFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/AuthorRevFilter", DoNotGenerateAcw=true)]
	public partial class AuthorRevFilter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/AuthorRevFilter", typeof (AuthorRevFilter));

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

		protected AuthorRevFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="pattern">regular expression pattern to match.</param>
		/// <summary>Create a new author filter.</summary>
		/// <returns>a new filter that matches the given expression against the author
		///         name and address of a commit.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='AuthorRevFilter']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Create (string pattern)
		{
			const string __id = "create.(Ljava/lang/String;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pattern);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

	}
}
