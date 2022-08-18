using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Creates, updates or deletes any reference.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefUpdate", DoNotGenerateAcw=true)]
	public abstract partial class RefUpdate : global::Java.Lang.Object {
		/// <summary>Status of an update request.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefUpdate$Result", DoNotGenerateAcw=true)]
		public sealed partial class Result : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='FAST_FORWARD']"
			[Register ("FAST_FORWARD")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result FastForward {
				get {
					const string __id = "FAST_FORWARD.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='FORCED']"
			[Register ("FORCED")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Forced {
				get {
					const string __id = "FORCED.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='IO_FAILURE']"
			[Register ("IO_FAILURE")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result IoFailure {
				get {
					const string __id = "IO_FAILURE.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='LOCK_FAILURE']"
			[Register ("LOCK_FAILURE")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result LockFailure {
				get {
					const string __id = "LOCK_FAILURE.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result New {
				get {
					const string __id = "NEW.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='NOT_ATTEMPTED']"
			[Register ("NOT_ATTEMPTED")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result NotAttempted {
				get {
					const string __id = "NOT_ATTEMPTED.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='NO_CHANGE']"
			[Register ("NO_CHANGE")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result NoChange {
				get {
					const string __id = "NO_CHANGE.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='REJECTED']"
			[Register ("REJECTED")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Rejected {
				get {
					const string __id = "REJECTED.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='REJECTED_CURRENT_BRANCH']"
			[Register ("REJECTED_CURRENT_BRANCH")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result RejectedCurrentBranch {
				get {
					const string __id = "REJECTED_CURRENT_BRANCH.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/field[@name='RENAMED']"
			[Register ("RENAMED")]
			public static global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Renamed {
				get {
					const string __id = "RENAMED.Lorg/eclipse/jgit/lib/RefUpdate$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefUpdate$Result", typeof (Result));

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

			internal Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefUpdate$Result;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate.Result']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/lib/RefUpdate$Result;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/lib/RefUpdate$Result;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Lib.RefUpdate.Result[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.RefUpdate.Result));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefUpdate", typeof (RefUpdate));

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

		protected RefUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="ref">the reference that will be updated by this operation.</param>
		/// <summary>Construct a new update operation for the reference.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/constructor[@name='RefUpdate' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Ref;)V", "")]
		protected unsafe RefUpdate (global::Org.Eclipse.Jgit.Lib.IRef @ref) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Ref;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@ref);
			}
		}

		static Delegate cb_getExpectedOldObjectId;
#pragma warning disable 0169
		static Delegate GetGetExpectedOldObjectIdHandler ()
		{
			if (cb_getExpectedOldObjectId == null)
				cb_getExpectedOldObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExpectedOldObjectId);
			return cb_getExpectedOldObjectId;
		}

		static IntPtr n_GetExpectedOldObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpectedOldObjectId);
		}
#pragma warning restore 0169

		/// <returns>the expected value of the ref after the lock is taken, but before
		///         update occurs. Null to avoid the compare and swap test. Use
		///         <c>ObjectId#zeroId()</c> to indicate expectation of a
		///         non-existant ref.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ExpectedOldObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getExpectedOldObjectId' and count(parameter)=0]"
			[Register ("getExpectedOldObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetExpectedOldObjectIdHandler")]
			get {
				const string __id = "getExpectedOldObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isForceUpdate;
#pragma warning disable 0169
		static Delegate GetIsForceUpdateHandler ()
		{
			if (cb_isForceUpdate == null)
				cb_isForceUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsForceUpdate);
			return cb_isForceUpdate;
		}

		static bool n_IsForceUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForceUpdate;
		}
#pragma warning restore 0169

		static Delegate cb_setForceUpdate_Z;
#pragma warning disable 0169
		static Delegate GetSetForceUpdate_ZHandler ()
		{
			if (cb_setForceUpdate_Z == null)
				cb_setForceUpdate_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetForceUpdate_Z);
			return cb_setForceUpdate_Z;
		}

		static void n_SetForceUpdate_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceUpdate = b;
		}
#pragma warning restore 0169

		/// <summary>Check if this update wants to forcefully change the ref. -or- Set if this update wants to forcefully change the ref.</summary>
		/// <returns>true if this update should ignore merge tests.</returns>
		/// <param name="b">true if this update should ignore merge tests.</param>
		public virtual unsafe bool ForceUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='isForceUpdate' and count(parameter)=0]"
			[Register ("isForceUpdate", "()Z", "GetIsForceUpdateHandler")]
			get {
				const string __id = "isForceUpdate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='setForceUpdate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setForceUpdate", "(Z)V", "GetSetForceUpdate_ZHandler")]
			set {
				const string __id = "setForceUpdate.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRefLogIncludingResult;
#pragma warning disable 0169
		static Delegate GetIsRefLogIncludingResultHandler ()
		{
			if (cb_isRefLogIncludingResult == null)
				cb_isRefLogIncludingResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRefLogIncludingResult);
			return cb_isRefLogIncludingResult;
		}

		static bool n_IsRefLogIncludingResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRefLogIncludingResult;
		}
#pragma warning restore 0169

		/// <returns>
		///   <c>true</c> if the ref log message should show the result.</returns>
		protected virtual unsafe bool IsRefLogIncludingResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='isRefLogIncludingResult' and count(parameter)=0]"
			[Register ("isRefLogIncludingResult", "()Z", "GetIsRefLogIncludingResultHandler")]
			get {
				const string __id = "isRefLogIncludingResult.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		/// <summary>Get the name of the ref this update will operate on.</summary>
		/// <returns>name of underlying ref.</returns>
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNewObjectId;
#pragma warning disable 0169
		static Delegate GetGetNewObjectIdHandler ()
		{
			if (cb_getNewObjectId == null)
				cb_getNewObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewObjectId);
			return cb_getNewObjectId;
		}

		static IntPtr n_GetNewObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewObjectId);
		}
#pragma warning restore 0169

		/// <summary>Get the new value the ref will be (or was) updated to.</summary>
		/// <returns>new value. Null if the caller has not configured it.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId NewObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getNewObjectId' and count(parameter)=0]"
			[Register ("getNewObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetNewObjectIdHandler")]
			get {
				const string __id = "getNewObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldObjectId;
#pragma warning disable 0169
		static Delegate GetGetOldObjectIdHandler ()
		{
			if (cb_getOldObjectId == null)
				cb_getOldObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOldObjectId);
			return cb_getOldObjectId;
		}

		static IntPtr n_GetOldObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldObjectId);
		}
#pragma warning restore 0169

		/// <summary>The old value of the ref, prior to the update being attempted.</summary>
		/// <returns>the value of the ref prior to the update being attempted; null if
		///         the updated has not been attempted yet.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId OldObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getOldObjectId' and count(parameter)=0]"
			[Register ("getOldObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetOldObjectIdHandler")]
			get {
				const string __id = "getOldObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRef;
#pragma warning disable 0169
		static Delegate GetGetRefHandler ()
		{
			if (cb_getRef == null)
				cb_getRef = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRef);
			return cb_getRef;
		}

		static IntPtr n_GetRef (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ref);
		}
#pragma warning restore 0169

		/// <returns>the reference this update will create or modify.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IRef Ref {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getRef' and count(parameter)=0]"
			[Register ("getRef", "()Lorg/eclipse/jgit/lib/Ref;", "GetGetRefHandler")]
			get {
				const string __id = "getRef.()Lorg/eclipse/jgit/lib/Ref;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefDatabase;
#pragma warning disable 0169
		static Delegate GetGetRefDatabaseHandler ()
		{
			if (cb_getRefDatabase == null)
				cb_getRefDatabase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefDatabase);
			return cb_getRefDatabase;
		}

		static IntPtr n_GetRefDatabase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefDatabase);
		}
#pragma warning restore 0169

		protected abstract global::Org.Eclipse.Jgit.Lib.RefDatabase RefDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getRefDatabase' and count(parameter)=0]"
			[Register ("getRefDatabase", "()Lorg/eclipse/jgit/lib/RefDatabase;", "GetGetRefDatabaseHandler")]
			get; 
		}

		static Delegate cb_getRefLogIdent;
#pragma warning disable 0169
		static Delegate GetGetRefLogIdentHandler ()
		{
			if (cb_getRefLogIdent == null)
				cb_getRefLogIdent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefLogIdent);
			return cb_getRefLogIdent;
		}

		static IntPtr n_GetRefLogIdent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefLogIdent);
		}
#pragma warning restore 0169

		static Delegate cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static void n_SetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pi)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pi = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_pi, JniHandleOwnership.DoNotTransfer);
			__this.RefLogIdent = pi;
		}
#pragma warning restore 0169

		/// <returns>identity of the user making the change in the reflog.</returns>
		/// <summary>Set the identity of the user appearing in the reflog.</summary>
		/// <param name="pi">identity of the user. If null the identity will be
		///            automatically determined based on the repository
		///            configuration.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent RefLogIdent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getRefLogIdent' and count(parameter)=0]"
			[Register ("getRefLogIdent", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetRefLogIdentHandler")]
			get {
				const string __id = "getRefLogIdent.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='setRefLogIdent' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
			[Register ("setRefLogIdent", "(Lorg/eclipse/jgit/lib/PersonIdent;)V", "GetSetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
			set {
				const string __id = "setRefLogIdent.(Lorg/eclipse/jgit/lib/PersonIdent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getRefLogMessage;
#pragma warning disable 0169
		static Delegate GetGetRefLogMessageHandler ()
		{
			if (cb_getRefLogMessage == null)
				cb_getRefLogMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefLogMessage);
			return cb_getRefLogMessage;
		}

		static IntPtr n_GetRefLogMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefLogMessage);
		}
#pragma warning restore 0169

		/// <summary>Get the message to include in the reflog.</summary>
		/// <returns>message the caller wants to include in the reflog; null if the
		///         update should not be logged.</returns>
		public virtual unsafe string RefLogMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getRefLogMessage' and count(parameter)=0]"
			[Register ("getRefLogMessage", "()Ljava/lang/String;", "GetGetRefLogMessageHandler")]
			get {
				const string __id = "getRefLogMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRepository;
#pragma warning disable 0169
		static Delegate GetGetRepositoryHandler ()
		{
			if (cb_getRepository == null)
				cb_getRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepository);
			return cb_getRepository;
		}

		static IntPtr n_GetRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		protected abstract global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "GetGetRepositoryHandler")]
			get; 
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Delete);
			return cb_delete;
		}

		static IntPtr n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Delete ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDeleteHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Delete ()
		{
			const string __id = "delete.()Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_delete_Lorg_eclipse_jgit_revwalk_RevWalk_;
#pragma warning disable 0169
		static Delegate GetDelete_Lorg_eclipse_jgit_revwalk_RevWalk_Handler ()
		{
			if (cb_delete_Lorg_eclipse_jgit_revwalk_RevWalk_ == null)
				cb_delete_Lorg_eclipse_jgit_revwalk_RevWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Delete_Lorg_eclipse_jgit_revwalk_RevWalk_);
			return cb_delete_Lorg_eclipse_jgit_revwalk_RevWalk_;
		}

		static IntPtr n_Delete_Lorg_eclipse_jgit_revwalk_RevWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walk)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Delete (walk));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk']]"
		[Register ("delete", "(Lorg/eclipse/jgit/revwalk/RevWalk;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDelete_Lorg_eclipse_jgit_revwalk_RevWalk_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Delete (global::Org.Eclipse.Jgit.Revwalk.RevWalk walk)
		{
			const string __id = "delete.(Lorg/eclipse/jgit/revwalk/RevWalk;)Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (walk);
			}
		}

		static Delegate cb_disableRefLog;
#pragma warning disable 0169
		static Delegate GetDisableRefLogHandler ()
		{
			if (cb_disableRefLog == null)
				cb_disableRefLog = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisableRefLog);
			return cb_disableRefLog;
		}

		static void n_DisableRefLog (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableRefLog ();
		}
#pragma warning restore 0169

		/// <summary>Don't record this update in the ref's associated reflog.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='disableRefLog' and count(parameter)=0]"
		[Register ("disableRefLog", "()V", "GetDisableRefLogHandler")]
		public virtual unsafe void DisableRefLog ()
		{
			const string __id = "disableRefLog.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doDelete_Lorg_eclipse_jgit_lib_RefUpdate_Result_;
#pragma warning disable 0169
		static Delegate GetDoDelete_Lorg_eclipse_jgit_lib_RefUpdate_Result_Handler ()
		{
			if (cb_doDelete_Lorg_eclipse_jgit_lib_RefUpdate_Result_ == null)
				cb_doDelete_Lorg_eclipse_jgit_lib_RefUpdate_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DoDelete_Lorg_eclipse_jgit_lib_RefUpdate_Result_);
			return cb_doDelete_Lorg_eclipse_jgit_lib_RefUpdate_Result_;
		}

		static IntPtr n_DoDelete_Lorg_eclipse_jgit_lib_RefUpdate_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_desiredResult)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desiredResult = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (native_desiredResult, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoDelete (desiredResult));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='doDelete' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.RefUpdate.Result']]"
		[Register ("doDelete", "(Lorg/eclipse/jgit/lib/RefUpdate$Result;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDoDelete_Lorg_eclipse_jgit_lib_RefUpdate_Result_Handler")]
		protected abstract global::Org.Eclipse.Jgit.Lib.RefUpdate.Result DoDelete (global::Org.Eclipse.Jgit.Lib.RefUpdate.Result desiredResult);

		static Delegate cb_doLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoLink_Ljava_lang_String_Handler ()
		{
			if (cb_doLink_Ljava_lang_String_ == null)
				cb_doLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DoLink_Ljava_lang_String_);
			return cb_doLink_Ljava_lang_String_;
		}

		static IntPtr n_DoLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoLink (target));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='doLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("doLink", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDoLink_Ljava_lang_String_Handler")]
		protected abstract global::Org.Eclipse.Jgit.Lib.RefUpdate.Result DoLink (string target);

		static Delegate cb_doUpdate_Lorg_eclipse_jgit_lib_RefUpdate_Result_;
#pragma warning disable 0169
		static Delegate GetDoUpdate_Lorg_eclipse_jgit_lib_RefUpdate_Result_Handler ()
		{
			if (cb_doUpdate_Lorg_eclipse_jgit_lib_RefUpdate_Result_ == null)
				cb_doUpdate_Lorg_eclipse_jgit_lib_RefUpdate_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DoUpdate_Lorg_eclipse_jgit_lib_RefUpdate_Result_);
			return cb_doUpdate_Lorg_eclipse_jgit_lib_RefUpdate_Result_;
		}

		static IntPtr n_DoUpdate_Lorg_eclipse_jgit_lib_RefUpdate_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_desiredResult)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desiredResult = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (native_desiredResult, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoUpdate (desiredResult));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='doUpdate' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.RefUpdate.Result']]"
		[Register ("doUpdate", "(Lorg/eclipse/jgit/lib/RefUpdate$Result;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDoUpdate_Lorg_eclipse_jgit_lib_RefUpdate_Result_Handler")]
		protected abstract global::Org.Eclipse.Jgit.Lib.RefUpdate.Result DoUpdate (global::Org.Eclipse.Jgit.Lib.RefUpdate.Result desiredResult);

		static Delegate cb_forceUpdate;
#pragma warning disable 0169
		static Delegate GetInvokeForceUpdateHandler ()
		{
			if (cb_forceUpdate == null)
				cb_forceUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_InvokeForceUpdate);
			return cb_forceUpdate;
		}

		static IntPtr n_InvokeForceUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeForceUpdate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='forceUpdate' and count(parameter)=0]"
		[Register ("forceUpdate", "()Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetInvokeForceUpdateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result InvokeForceUpdate ()
		{
			const string __id = "forceUpdate.()Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetResult ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getResult' and count(parameter)=0]"
		[Register ("getResult", "()Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetGetResultHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result GetResult ()
		{
			const string __id = "getResult.()Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_link_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLink_Ljava_lang_String_Handler ()
		{
			if (cb_link_Ljava_lang_String_ == null)
				cb_link_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Link_Ljava_lang_String_);
			return cb_link_Ljava_lang_String_;
		}

		static IntPtr n_Link_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Link (target));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='link' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("link", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetLink_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Link (string target)
		{
			const string __id = "link.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			IntPtr native_target = JNIEnv.NewString ((string)target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_target);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
			}
		}

		static Delegate cb_setCheckConflicting_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckConflicting_ZHandler ()
		{
			if (cb_setCheckConflicting_Z == null)
				cb_setCheckConflicting_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCheckConflicting_Z);
			return cb_setCheckConflicting_Z;
		}

		static void n_SetCheckConflicting_Z (IntPtr jnienv, IntPtr native__this, bool check)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCheckConflicting (check);
		}
#pragma warning restore 0169

		/// <param name="check">check</param>
		/// <summary>Enable/disable the check for conflicting ref names.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='setCheckConflicting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCheckConflicting", "(Z)V", "GetSetCheckConflicting_ZHandler")]
		public virtual unsafe void SetCheckConflicting (bool check)
		{
			const string __id = "setCheckConflicting.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (check);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDetachingSymbolicRef;
#pragma warning disable 0169
		static Delegate GetSetDetachingSymbolicRefHandler ()
		{
			if (cb_setDetachingSymbolicRef == null)
				cb_setDetachingSymbolicRef = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetDetachingSymbolicRef);
			return cb_setDetachingSymbolicRef;
		}

		static void n_SetDetachingSymbolicRef (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDetachingSymbolicRef ();
		}
#pragma warning restore 0169

		/// <summary>Tells this RefUpdate that it is actually detaching a symbolic ref.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='setDetachingSymbolicRef' and count(parameter)=0]"
		[Register ("setDetachingSymbolicRef", "()V", "GetSetDetachingSymbolicRefHandler")]
		public virtual unsafe void SetDetachingSymbolicRef ()
		{
			const string __id = "setDetachingSymbolicRef.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setExpectedOldObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetExpectedOldObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setExpectedOldObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setExpectedOldObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExpectedOldObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setExpectedOldObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_SetExpectedOldObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.SetExpectedOldObjectId (id);
		}
#pragma warning restore 0169

		/// <param name="id">the expected value of the ref after the lock is taken, but
		///            before update occurs. Null to avoid the compare and swap test.
		///            Use <c>ObjectId#zeroId()</c> to indicate expectation of a
		///            non-existant ref.</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='setExpectedOldObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setExpectedOldObjectId", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetSetExpectedOldObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void SetExpectedOldObjectId (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "setExpectedOldObjectId.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_setNewObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetNewObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setNewObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setNewObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNewObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setNewObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_SetNewObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.SetNewObjectId (id);
		}
#pragma warning restore 0169

		/// <param name="id">the new value.</param>
		/// <summary>Set the new value the ref will update to.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='setNewObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setNewObjectId", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetSetNewObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void SetNewObjectId (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "setNewObjectId.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_setOldObjectId_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetSetOldObjectId_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_setOldObjectId_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_setOldObjectId_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOldObjectId_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_setOldObjectId_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static void n_SetOldObjectId_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_old)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var old = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_old, JniHandleOwnership.DoNotTransfer);
			__this.SetOldObjectId (old);
		}
#pragma warning restore 0169

		/// <param name="old">the old value.</param>
		/// <summary>Set the old value of the ref.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='setOldObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("setOldObjectId", "(Lorg/eclipse/jgit/lib/ObjectId;)V", "GetSetOldObjectId_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		protected virtual unsafe void SetOldObjectId (global::Org.Eclipse.Jgit.Lib.ObjectId old)
		{
			const string __id = "setOldObjectId.(Lorg/eclipse/jgit/lib/ObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((old == null) ? IntPtr.Zero : ((global::Java.Lang.Object) old).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (old);
			}
		}

		static Delegate cb_setRefLogMessage_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetRefLogMessage_Ljava_lang_String_ZHandler ()
		{
			if (cb_setRefLogMessage_Ljava_lang_String_Z == null)
				cb_setRefLogMessage_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_SetRefLogMessage_Ljava_lang_String_Z);
			return cb_setRefLogMessage_Ljava_lang_String_Z;
		}

		static void n_SetRefLogMessage_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, bool appendStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.SetRefLogMessage (msg, appendStatus);
		}
#pragma warning restore 0169

		/// <param name="msg">the message to describe this change. It may be null if
		///            appendStatus is null in order not to append to the reflog</param>
		/// <param name="appendStatus">true if the status of the ref change (fast-forward or
		///            forced-update) should be appended to the user supplied
		///            message.</param>
		/// <summary>Set the message to include in the reflog.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='setRefLogMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setRefLogMessage", "(Ljava/lang/String;Z)V", "GetSetRefLogMessage_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SetRefLogMessage (string msg, bool appendStatus)
		{
			const string __id = "setRefLogMessage.(Ljava/lang/String;Z)V";
			IntPtr native_msg = JNIEnv.NewString ((string)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (appendStatus);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_tryLock_Z;
#pragma warning disable 0169
		static Delegate GetTryLock_ZHandler ()
		{
			if (cb_tryLock_Z == null)
				cb_tryLock_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_TryLock_Z);
			return cb_tryLock_Z;
		}

		static bool n_TryLock_Z (IntPtr jnienv, IntPtr native__this, bool deref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TryLock (deref);
		}
#pragma warning restore 0169

		/// <param name="deref">true if the lock should be taken against the leaf level
		///            reference; false if it should be taken exactly against the
		///            current reference.</param>
		/// <summary>Try to acquire the lock on the reference.</summary>
		/// <returns>true if the lock was acquired and the reference is likely
		///         protected from concurrent modification; false if it failed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='tryLock' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("tryLock", "(Z)Z", "GetTryLock_ZHandler")]
		protected abstract bool TryLock (bool deref);

		static Delegate cb_unlock;
#pragma warning disable 0169
		static Delegate GetUnlockHandler ()
		{
			if (cb_unlock == null)
				cb_unlock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unlock);
			return cb_unlock;
		}

		static void n_Unlock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		/// <summary>Releases the lock taken by <c>#tryLock</c> if it succeeded.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler")]
		protected abstract void Unlock ();

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Update);
			return cb_update;
		}

		static IntPtr n_Update (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Update ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetUpdateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Update ()
		{
			const string __id = "update.()Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_update_Lorg_eclipse_jgit_revwalk_RevWalk_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lorg_eclipse_jgit_revwalk_RevWalk_Handler ()
		{
			if (cb_update_Lorg_eclipse_jgit_revwalk_RevWalk_ == null)
				cb_update_Lorg_eclipse_jgit_revwalk_RevWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Update_Lorg_eclipse_jgit_revwalk_RevWalk_);
			return cb_update_Lorg_eclipse_jgit_revwalk_RevWalk_;
		}

		static IntPtr n_Update_Lorg_eclipse_jgit_revwalk_RevWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walk)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Update (walk));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='update' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk']]"
		[Register ("update", "(Lorg/eclipse/jgit/revwalk/RevWalk;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetUpdate_Lorg_eclipse_jgit_revwalk_RevWalk_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Update (global::Org.Eclipse.Jgit.Revwalk.RevWalk walk)
		{
			const string __id = "update.(Lorg/eclipse/jgit/revwalk/RevWalk;)Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (walk);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefUpdate", DoNotGenerateAcw=true)]
	internal partial class RefUpdateInvoker : RefUpdate {
		public RefUpdateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefUpdate", typeof (RefUpdateInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		/// <returns>the reference database this update modifies.</returns>
		protected override unsafe global::Org.Eclipse.Jgit.Lib.RefDatabase RefDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getRefDatabase' and count(parameter)=0]"
			[Register ("getRefDatabase", "()Lorg/eclipse/jgit/lib/RefDatabase;", "GetGetRefDatabaseHandler")]
			get {
				const string __id = "getRefDatabase.()Lorg/eclipse/jgit/lib/RefDatabase;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>the repository storing the database's objects.</returns>
		protected override unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "GetGetRepositoryHandler")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/lib/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='doDelete' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.RefUpdate.Result']]"
		[Register ("doDelete", "(Lorg/eclipse/jgit/lib/RefUpdate$Result;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDoDelete_Lorg_eclipse_jgit_lib_RefUpdate_Result_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result DoDelete (global::Org.Eclipse.Jgit.Lib.RefUpdate.Result desiredResult)
		{
			const string __id = "doDelete.(Lorg/eclipse/jgit/lib/RefUpdate$Result;)Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((desiredResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) desiredResult).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (desiredResult);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='doLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("doLink", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDoLink_Ljava_lang_String_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result DoLink (string target)
		{
			const string __id = "doLink.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			IntPtr native_target = JNIEnv.NewString ((string)target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_target);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='doUpdate' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.RefUpdate.Result']]"
		[Register ("doUpdate", "(Lorg/eclipse/jgit/lib/RefUpdate$Result;)Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDoUpdate_Lorg_eclipse_jgit_lib_RefUpdate_Result_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result DoUpdate (global::Org.Eclipse.Jgit.Lib.RefUpdate.Result desiredResult)
		{
			const string __id = "doUpdate.(Lorg/eclipse/jgit/lib/RefUpdate$Result;)Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((desiredResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) desiredResult).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (desiredResult);
			}
		}

		/// <param name="deref">true if the lock should be taken against the leaf level
		///            reference; false if it should be taken exactly against the
		///            current reference.</param>
		/// <summary>Try to acquire the lock on the reference.</summary>
		/// <returns>true if the lock was acquired and the reference is likely
		///         protected from concurrent modification; false if it failed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='tryLock' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("tryLock", "(Z)Z", "GetTryLock_ZHandler")]
		protected override unsafe bool TryLock (bool deref)
		{
			const string __id = "tryLock.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (deref);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		/// <summary>Releases the lock taken by <c>#tryLock</c> if it succeeded.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefUpdate']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler")]
		protected override unsafe void Unlock ()
		{
			const string __id = "unlock.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
