using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>The result of a <c>RebaseCommand</c> execution</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/RebaseResult", DoNotGenerateAcw=true)]
	public partial class RebaseResult : global::Java.Lang.Object {
		/// <summary>The overall status</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/RebaseResult$Status", DoNotGenerateAcw=true)]
		public abstract partial class Status : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='ABORTED']"
			[Register ("ABORTED")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status Aborted {
				get {
					const string __id = "ABORTED.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='CONFLICTS']"
			[Register ("CONFLICTS")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status Conflicts {
				get {
					const string __id = "CONFLICTS.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='EDIT']"
			[Register ("EDIT")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status Edit {
				get {
					const string __id = "EDIT.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status Failed {
				get {
					const string __id = "FAILED.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='FAST_FORWARD']"
			[Register ("FAST_FORWARD")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status FastForward {
				get {
					const string __id = "FAST_FORWARD.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='INTERACTIVE_PREPARED']"
			[Register ("INTERACTIVE_PREPARED")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status InteractivePrepared {
				get {
					const string __id = "INTERACTIVE_PREPARED.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='NOTHING_TO_COMMIT']"
			[Register ("NOTHING_TO_COMMIT")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status NothingToCommit {
				get {
					const string __id = "NOTHING_TO_COMMIT.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='OK']"
			[Register ("OK")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status Ok {
				get {
					const string __id = "OK.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='STASH_APPLY_CONFLICTS']"
			[Register ("STASH_APPLY_CONFLICTS")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status StashApplyConflicts {
				get {
					const string __id = "STASH_APPLY_CONFLICTS.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='STOPPED']"
			[Register ("STOPPED")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status Stopped {
				get {
					const string __id = "STOPPED.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='UNCOMMITTED_CHANGES']"
			[Register ("UNCOMMITTED_CHANGES")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status UncommittedChanges {
				get {
					const string __id = "UNCOMMITTED_CHANGES.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/field[@name='UP_TO_DATE']"
			[Register ("UP_TO_DATE")]
			public static global::Org.Eclipse.Jgit.Api.RebaseResult.Status UpToDate {
				get {
					const string __id = "UP_TO_DATE.Lorg/eclipse/jgit/api/RebaseResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/RebaseResult$Status", typeof (Status));

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

			protected Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate cb_isSuccessful;
#pragma warning disable 0169
			static Delegate GetIsSuccessfulHandler ()
			{
				if (cb_isSuccessful == null)
					cb_isSuccessful = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuccessful);
				return cb_isSuccessful;
			}

			static bool n_IsSuccessful (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSuccessful;
			}
#pragma warning restore 0169

			public abstract bool IsSuccessful {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/method[@name='isSuccessful' and count(parameter)=0]"
				[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
				get; 
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/RebaseResult$Status;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.RebaseResult.Status ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/RebaseResult$Status;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/api/RebaseResult$Status;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.RebaseResult.Status[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/api/RebaseResult$Status;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Api.RebaseResult.Status[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.RebaseResult.Status));
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/api/RebaseResult$Status", DoNotGenerateAcw=true)]
		internal partial class StatusInvoker : Status {
			public StatusInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/RebaseResult$Status", typeof (StatusInvoker));

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

			/// <returns>whether the status indicates a successful result</returns>
			public override unsafe bool IsSuccessful {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult.Status']/method[@name='isSuccessful' and count(parameter)=0]"
				[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
				get {
					const string __id = "isSuccessful.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/RebaseResult", typeof (RebaseResult));

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

		protected RebaseResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getConflicts;
#pragma warning disable 0169
		static Delegate GetGetConflictsHandler ()
		{
			if (cb_getConflicts == null)
				cb_getConflicts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConflicts);
			return cb_getConflicts;
		}

		static IntPtr n_GetConflicts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Conflicts);
		}
#pragma warning restore 0169

		/// <returns>the list of conflicts if status is <c>Status#CONFLICTS</c></returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> Conflicts {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult']/method[@name='getConflicts' and count(parameter)=0]"
			[Register ("getConflicts", "()Ljava/util/List;", "GetGetConflictsHandler")]
			get {
				const string __id = "getConflicts.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentCommit;
#pragma warning disable 0169
		static Delegate GetGetCurrentCommitHandler ()
		{
			if (cb_getCurrentCommit == null)
				cb_getCurrentCommit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentCommit);
			return cb_getCurrentCommit;
		}

		static IntPtr n_GetCurrentCommit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentCommit);
		}
#pragma warning restore 0169

		/// <returns>the current commit if status is <c>Status#STOPPED</c>, otherwise
		///         &lt;code&gt;null&lt;/code&gt;</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit CurrentCommit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult']/method[@name='getCurrentCommit' and count(parameter)=0]"
			[Register ("getCurrentCommit", "()Lorg/eclipse/jgit/revwalk/RevCommit;", "GetGetCurrentCommitHandler")]
			get {
				const string __id = "getCurrentCommit.()Lorg/eclipse/jgit/revwalk/RevCommit;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFailingPaths;
#pragma warning disable 0169
		static Delegate GetGetFailingPathsHandler ()
		{
			if (cb_getFailingPaths == null)
				cb_getFailingPaths = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFailingPaths);
			return cb_getFailingPaths;
		}

		static IntPtr n_GetFailingPaths (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason>.ToLocalJniHandle (__this.FailingPaths);
		}
#pragma warning restore 0169

		/// <returns>the list of paths causing this rebase to fail (see
		///         <c>ResolveMerger#getFailingPaths()</c> for details) if status is
		///         <c>Status#FAILED</c>, otherwise &lt;code&gt;null&lt;/code&gt;</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> FailingPaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult']/method[@name='getFailingPaths' and count(parameter)=0]"
			[Register ("getFailingPaths", "()Ljava/util/Map;", "GetGetFailingPathsHandler")]
			get {
				const string __id = "getFailingPaths.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUncommittedChanges;
#pragma warning disable 0169
		static Delegate GetGetUncommittedChangesHandler ()
		{
			if (cb_getUncommittedChanges == null)
				cb_getUncommittedChanges = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUncommittedChanges);
			return cb_getUncommittedChanges;
		}

		static IntPtr n_GetUncommittedChanges (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UncommittedChanges);
		}
#pragma warning restore 0169

		/// <returns>the list of uncommitted changes if status is
		///         <c>Status#UNCOMMITTED_CHANGES</c></returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> UncommittedChanges {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult']/method[@name='getUncommittedChanges' and count(parameter)=0]"
			[Register ("getUncommittedChanges", "()Ljava/util/List;", "GetGetUncommittedChangesHandler")]
			get {
				const string __id = "getUncommittedChanges.()Ljava/util/List;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseResult']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lorg/eclipse/jgit/api/RebaseResult$Status;", "GetGetStatusHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseResult.Status GetStatus ()
		{
			const string __id = "getStatus.()Lorg/eclipse/jgit/api/RebaseResult$Status;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
