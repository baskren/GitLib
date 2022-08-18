using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Submodule {

	/// <summary>Enumeration of different statuses that a submodule can be in</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatusType']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/submodule/SubmoduleStatusType", DoNotGenerateAcw=true)]
	public sealed partial class SubmoduleStatusType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatusType']/field[@name='INITIALIZED']"
		[Register ("INITIALIZED")]
		public static global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType Initialized {
			get {
				const string __id = "INITIALIZED.Lorg/eclipse/jgit/submodule/SubmoduleStatusType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatusType']/field[@name='MISSING']"
		[Register ("MISSING")]
		public static global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType Missing {
			get {
				const string __id = "MISSING.Lorg/eclipse/jgit/submodule/SubmoduleStatusType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatusType']/field[@name='REV_CHECKED_OUT']"
		[Register ("REV_CHECKED_OUT")]
		public static global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType RevCheckedOut {
			get {
				const string __id = "REV_CHECKED_OUT.Lorg/eclipse/jgit/submodule/SubmoduleStatusType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatusType']/field[@name='UNINITIALIZED']"
		[Register ("UNINITIALIZED")]
		public static global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType Uninitialized {
			get {
				const string __id = "UNINITIALIZED.Lorg/eclipse/jgit/submodule/SubmoduleStatusType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/submodule/SubmoduleStatusType", typeof (SubmoduleStatusType));

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

		internal SubmoduleStatusType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatusType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/submodule/SubmoduleStatusType;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/submodule/SubmoduleStatusType;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatusType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/eclipse/jgit/submodule/SubmoduleStatusType;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType[] Values ()
		{
			const string __id = "values.()[Lorg/eclipse/jgit/submodule/SubmoduleStatusType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType));
			} finally {
			}
		}

	}
}
