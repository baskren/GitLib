using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>Exception thrown if a merge fails because no merge base could be determined.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/NoMergeBaseException", DoNotGenerateAcw=true)]
	public partial class NoMergeBaseException : global::Java.IO.IOException {
		/// <summary>An enum listing the different reason why no merge base could be
		/// determined.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException.MergeBaseFailureReason']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason", DoNotGenerateAcw=true)]
		public sealed partial class MergeBaseFailureReason : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException.MergeBaseFailureReason']/field[@name='CONFLICTS_DURING_MERGE_BASE_CALCULATION']"
			[Register ("CONFLICTS_DURING_MERGE_BASE_CALCULATION")]
			public static global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason ConflictsDuringMergeBaseCalculation {
				get {
					const string __id = "CONFLICTS_DURING_MERGE_BASE_CALCULATION.Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException.MergeBaseFailureReason']/field[@name='MULTIPLE_MERGE_BASES_NOT_SUPPORTED']"
			[Register ("MULTIPLE_MERGE_BASES_NOT_SUPPORTED")]
			public static global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason MultipleMergeBasesNotSupported {
				get {
					const string __id = "MULTIPLE_MERGE_BASES_NOT_SUPPORTED.Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException.MergeBaseFailureReason']/field[@name='TOO_MANY_MERGE_BASES']"
			[Register ("TOO_MANY_MERGE_BASES")]
			public static global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason TooManyMergeBases {
				get {
					const string __id = "TOO_MANY_MERGE_BASES.Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason", typeof (MergeBaseFailureReason));

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

			internal MergeBaseFailureReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException.MergeBaseFailureReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException.MergeBaseFailureReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/NoMergeBaseException", typeof (NoMergeBaseException));

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

		protected NoMergeBaseException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException']/constructor[@name='NoMergeBaseException' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.errors.NoMergeBaseException.MergeBaseFailureReason'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;Ljava/lang/String;)V", "")]
		public unsafe NoMergeBaseException (global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason reason, string message) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reason == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reason).Handle);
				__args [1] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (reason);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException']/constructor[@name='NoMergeBaseException' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.errors.NoMergeBaseException.MergeBaseFailureReason'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe NoMergeBaseException (global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason reason, string message, global::Java.Lang.Throwable why) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((reason == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reason).Handle);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((why == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) why).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (reason);
				global::System.GC.KeepAlive (why);
			}
		}

		static Delegate cb_getReason;
#pragma warning disable 0169
		static Delegate GetGetReasonHandler ()
		{
			if (cb_getReason == null)
				cb_getReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReason);
			return cb_getReason;
		}

		static IntPtr n_GetReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.NoMergeBaseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reason);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason Reason {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoMergeBaseException']/method[@name='getReason' and count(parameter)=0]"
			[Register ("getReason", "()Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;", "GetGetReasonHandler")]
			get {
				const string __id = "getReason.()Lorg/eclipse/jgit/errors/NoMergeBaseException$MergeBaseFailureReason;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.NoMergeBaseException.MergeBaseFailureReason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
