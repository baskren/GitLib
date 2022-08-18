using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Sorting strategies supported by <c>RevWalk</c> and <c>ObjectWalk</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevSort']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevSort", DoNotGenerateAcw=true)]
	public sealed partial class RevSort : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevSort']/field[@name='BOUNDARY']"
		[Register ("BOUNDARY")]
		public static global::Org.Eclipse.Jgit.Revwalk.RevSort Boundary {
			get {
				const string __id = "BOUNDARY.Lorg/eclipse/jgit/revwalk/RevSort;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevSort> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevSort']/field[@name='COMMIT_TIME_DESC']"
		[Register ("COMMIT_TIME_DESC")]
		public static global::Org.Eclipse.Jgit.Revwalk.RevSort CommitTimeDesc {
			get {
				const string __id = "COMMIT_TIME_DESC.Lorg/eclipse/jgit/revwalk/RevSort;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevSort> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevSort']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Org.Eclipse.Jgit.Revwalk.RevSort None {
			get {
				const string __id = "NONE.Lorg/eclipse/jgit/revwalk/RevSort;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevSort> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevSort']/field[@name='REVERSE']"
		[Register ("REVERSE")]
		public static global::Org.Eclipse.Jgit.Revwalk.RevSort Reverse {
			get {
				const string __id = "REVERSE.Lorg/eclipse/jgit/revwalk/RevSort;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevSort> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevSort']/field[@name='TOPO']"
		[Register ("TOPO")]
		public static global::Org.Eclipse.Jgit.Revwalk.RevSort Topo {
			get {
				const string __id = "TOPO.Lorg/eclipse/jgit/revwalk/RevSort;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevSort> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevSort", typeof (RevSort));

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

		internal RevSort (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevSort']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/revwalk/RevSort;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.RevSort ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/revwalk/RevSort;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevSort> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevSort']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/eclipse/jgit/revwalk/RevSort;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.RevSort[] Values ()
		{
			const string __id = "values.()[Lorg/eclipse/jgit/revwalk/RevSort;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Eclipse.Jgit.Revwalk.RevSort[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Revwalk.RevSort));
			} finally {
			}
		}

	}
}
