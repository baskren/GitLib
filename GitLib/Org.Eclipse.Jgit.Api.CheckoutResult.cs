using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Encapsulates the result of a <c>CheckoutCommand</c></summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/CheckoutResult", DoNotGenerateAcw=true)]
	public partial class CheckoutResult : global::Java.Lang.Object {

		/// <summary>The <c>Status#ERROR</c> result;</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult']/field[@name='ERROR_RESULT']"
		[Register ("ERROR_RESULT")]
		public static global::Org.Eclipse.Jgit.Api.CheckoutResult ErrorResult {
			get {
				const string __id = "ERROR_RESULT.Lorg/eclipse/jgit/api/CheckoutResult;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>The <c>Status#NOT_TRIED</c> result;</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult']/field[@name='NOT_TRIED_RESULT']"
		[Register ("NOT_TRIED_RESULT")]
		public static global::Org.Eclipse.Jgit.Api.CheckoutResult NotTriedResult {
			get {
				const string __id = "NOT_TRIED_RESULT.Lorg/eclipse/jgit/api/CheckoutResult;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>The status</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult.Status']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/CheckoutResult$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult.Status']/field[@name='CONFLICTS']"
			[Register ("CONFLICTS")]
			public static global::Org.Eclipse.Jgit.Api.CheckoutResult.Status Conflicts {
				get {
					const string __id = "CONFLICTS.Lorg/eclipse/jgit/api/CheckoutResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult.Status']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Org.Eclipse.Jgit.Api.CheckoutResult.Status Error {
				get {
					const string __id = "ERROR.Lorg/eclipse/jgit/api/CheckoutResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult.Status']/field[@name='NONDELETED']"
			[Register ("NONDELETED")]
			public static global::Org.Eclipse.Jgit.Api.CheckoutResult.Status Nondeleted {
				get {
					const string __id = "NONDELETED.Lorg/eclipse/jgit/api/CheckoutResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult.Status']/field[@name='NOT_TRIED']"
			[Register ("NOT_TRIED")]
			public static global::Org.Eclipse.Jgit.Api.CheckoutResult.Status NotTried {
				get {
					const string __id = "NOT_TRIED.Lorg/eclipse/jgit/api/CheckoutResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult.Status']/field[@name='OK']"
			[Register ("OK")]
			public static global::Org.Eclipse.Jgit.Api.CheckoutResult.Status Ok {
				get {
					const string __id = "OK.Lorg/eclipse/jgit/api/CheckoutResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CheckoutResult$Status", typeof (Status));

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

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutResult$Status;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.CheckoutResult.Status ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutResult$Status;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/api/CheckoutResult$Status;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.CheckoutResult.Status[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/api/CheckoutResult$Status;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Api.CheckoutResult.Status[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.CheckoutResult.Status));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CheckoutResult", typeof (CheckoutResult));

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

		protected CheckoutResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getConflictList;
#pragma warning disable 0169
		static Delegate GetGetConflictListHandler ()
		{
			if (cb_getConflictList == null)
				cb_getConflictList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConflictList);
			return cb_getConflictList;
		}

		static IntPtr n_GetConflictList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ConflictList);
		}
#pragma warning restore 0169

		/// <returns>the list of files that created a checkout conflict, or an empty
		///         list if <c>#getStatus()</c> is not <c>Status#CONFLICTS</c>;</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> ConflictList {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult']/method[@name='getConflictList' and count(parameter)=0]"
			[Register ("getConflictList", "()Ljava/util/List;", "GetGetConflictListHandler")]
			get {
				const string __id = "getConflictList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModifiedList;
#pragma warning disable 0169
		static Delegate GetGetModifiedListHandler ()
		{
			if (cb_getModifiedList == null)
				cb_getModifiedList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModifiedList);
			return cb_getModifiedList;
		}

		static IntPtr n_GetModifiedList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ModifiedList);
		}
#pragma warning restore 0169

		/// <returns>the list of files that where modified during checkout, or an
		///         empty list if <c>#getStatus()</c> is not <c>Status#OK</c></returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> ModifiedList {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult']/method[@name='getModifiedList' and count(parameter)=0]"
			[Register ("getModifiedList", "()Ljava/util/List;", "GetGetModifiedListHandler")]
			get {
				const string __id = "getModifiedList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemovedList;
#pragma warning disable 0169
		static Delegate GetGetRemovedListHandler ()
		{
			if (cb_getRemovedList == null)
				cb_getRemovedList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemovedList);
			return cb_getRemovedList;
		}

		static IntPtr n_GetRemovedList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.RemovedList);
		}
#pragma warning restore 0169

		/// <returns>the list of files that where removed during checkout, or an empty
		///         list if <c>#getStatus()</c> is not <c>Status#OK</c></returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> RemovedList {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult']/method[@name='getRemovedList' and count(parameter)=0]"
			[Register ("getRemovedList", "()Ljava/util/List;", "GetGetRemovedListHandler")]
			get {
				const string __id = "getRemovedList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUndeletedList;
#pragma warning disable 0169
		static Delegate GetGetUndeletedListHandler ()
		{
			if (cb_getUndeletedList == null)
				cb_getUndeletedList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUndeletedList);
			return cb_getUndeletedList;
		}

		static IntPtr n_GetUndeletedList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UndeletedList);
		}
#pragma warning restore 0169

		/// <returns>the list of files that could not be deleted during checkout, or
		///         an empty list if <c>#getStatus()</c> is not
		///         <c>Status#NONDELETED</c>;</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> UndeletedList {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult']/method[@name='getUndeletedList' and count(parameter)=0]"
			[Register ("getUndeletedList", "()Ljava/util/List;", "GetGetUndeletedListHandler")]
			get {
				const string __id = "getUndeletedList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutResult']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lorg/eclipse/jgit/api/CheckoutResult$Status;", "GetGetStatusHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutResult.Status GetStatus ()
		{
			const string __id = "getStatus.()Lorg/eclipse/jgit/api/CheckoutResult$Status;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
