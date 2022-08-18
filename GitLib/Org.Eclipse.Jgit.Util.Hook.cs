using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>An enum describing the different hooks a user can implement to customize his
	/// repositories.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/Hook", DoNotGenerateAcw=true)]
	public sealed partial class Hook : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']/field[@name='COMMIT_MSG']"
		[Register ("COMMIT_MSG")]
		public static global::Org.Eclipse.Jgit.Util.Hook CommitMsg {
			get {
				const string __id = "COMMIT_MSG.Lorg/eclipse/jgit/util/Hook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']/field[@name='POST_COMMIT']"
		[Register ("POST_COMMIT")]
		public static global::Org.Eclipse.Jgit.Util.Hook PostCommit {
			get {
				const string __id = "POST_COMMIT.Lorg/eclipse/jgit/util/Hook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']/field[@name='POST_REWRITE']"
		[Register ("POST_REWRITE")]
		public static global::Org.Eclipse.Jgit.Util.Hook PostRewrite {
			get {
				const string __id = "POST_REWRITE.Lorg/eclipse/jgit/util/Hook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']/field[@name='PREPARE_COMMIT_MSG']"
		[Register ("PREPARE_COMMIT_MSG")]
		public static global::Org.Eclipse.Jgit.Util.Hook PrepareCommitMsg {
			get {
				const string __id = "PREPARE_COMMIT_MSG.Lorg/eclipse/jgit/util/Hook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']/field[@name='PRE_COMMIT']"
		[Register ("PRE_COMMIT")]
		public static global::Org.Eclipse.Jgit.Util.Hook PreCommit {
			get {
				const string __id = "PRE_COMMIT.Lorg/eclipse/jgit/util/Hook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']/field[@name='PRE_REBASE']"
		[Register ("PRE_REBASE")]
		public static global::Org.Eclipse.Jgit.Util.Hook PreRebase {
			get {
				const string __id = "PRE_REBASE.Lorg/eclipse/jgit/util/Hook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/Hook", typeof (Hook));

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

		internal Hook (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <returns>The name of this hook.</returns>
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/util/Hook;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Util.Hook ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/util/Hook;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Hook']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/eclipse/jgit/util/Hook;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Util.Hook[] Values ()
		{
			const string __id = "values.()[Lorg/eclipse/jgit/util/Hook;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Eclipse.Jgit.Util.Hook[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Util.Hook));
			} finally {
			}
		}

	}
}
