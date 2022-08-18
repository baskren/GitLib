using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Encapsulates the result of a <c>MergeCommand</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/MergeResult", DoNotGenerateAcw=true)]
	public partial class MergeResult : global::Java.Lang.Object {
		/// <summary>The status the merge resulted in.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/MergeResult$MergeStatus", DoNotGenerateAcw=true)]
		public abstract partial class MergeStatus : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='ABORTED']"
			[Register ("ABORTED")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus Aborted {
				get {
					const string __id = "ABORTED.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='ALREADY_UP_TO_DATE']"
			[Register ("ALREADY_UP_TO_DATE")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus AlreadyUpToDate {
				get {
					const string __id = "ALREADY_UP_TO_DATE.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='CHECKOUT_CONFLICT']"
			[Register ("CHECKOUT_CONFLICT")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus CheckoutConflict {
				get {
					const string __id = "CHECKOUT_CONFLICT.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='CONFLICTING']"
			[Register ("CONFLICTING")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus Conflicting {
				get {
					const string __id = "CONFLICTING.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus Failed {
				get {
					const string __id = "FAILED.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='FAST_FORWARD']"
			[Register ("FAST_FORWARD")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus FastForward {
				get {
					const string __id = "FAST_FORWARD.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='FAST_FORWARD_SQUASHED']"
			[Register ("FAST_FORWARD_SQUASHED")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus FastForwardSquashed {
				get {
					const string __id = "FAST_FORWARD_SQUASHED.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='MERGED']"
			[Register ("MERGED")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus Merged {
				get {
					const string __id = "MERGED.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='MERGED_NOT_COMMITTED']"
			[Register ("MERGED_NOT_COMMITTED")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus MergedNotCommitted {
				get {
					const string __id = "MERGED_NOT_COMMITTED.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='MERGED_SQUASHED']"
			[Register ("MERGED_SQUASHED")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus MergedSquashed {
				get {
					const string __id = "MERGED_SQUASHED.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='MERGED_SQUASHED_NOT_COMMITTED']"
			[Register ("MERGED_SQUASHED_NOT_COMMITTED")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus MergedSquashedNotCommitted {
				get {
					const string __id = "MERGED_SQUASHED_NOT_COMMITTED.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/field[@name='NOT_SUPPORTED']"
			[Register ("NOT_SUPPORTED")]
			public static global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus NotSupported {
				get {
					const string __id = "NOT_SUPPORTED.Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/MergeResult$MergeStatus", typeof (MergeStatus));

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

			protected MergeStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSuccessful;
			}
#pragma warning restore 0169

			public abstract bool IsSuccessful {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/method[@name='isSuccessful' and count(parameter)=0]"
				[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
				get; 
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/MergeResult$MergeStatus;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/api/MergeResult$MergeStatus;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus));
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/api/MergeResult$MergeStatus", DoNotGenerateAcw=true)]
		internal partial class MergeStatusInvoker : MergeStatus {
			public MergeStatusInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/MergeResult$MergeStatus", typeof (MergeStatusInvoker));

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
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult.MergeStatus']/method[@name='isSuccessful' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/MergeResult", typeof (MergeResult));

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

		protected MergeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="checkoutConflicts">the conflicting files</param>
		/// <summary>Creates a new result that represents a checkout conflict before the
		/// operation even started for real.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/constructor[@name='MergeResult' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe MergeResult (global::System.Collections.Generic.IList<string> checkoutConflicts) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_checkoutConflicts = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (checkoutConflicts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_checkoutConflicts);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_checkoutConflicts);
				global::System.GC.KeepAlive (checkoutConflicts);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/constructor[@name='MergeResult' and count(parameter)=6 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId[]'] and parameter[4][@type='org.eclipse.jgit.api.MergeResult.MergeStatus'] and parameter[5][@type='org.eclipse.jgit.merge.MergeStrategy'] and parameter[6][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.merge.MergeResult&lt;?&gt;&gt;']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;[Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/api/MergeResult$MergeStatus;Lorg/eclipse/jgit/merge/MergeStrategy;Ljava/util/Map;)V", "")]
		public unsafe MergeResult (global::Org.Eclipse.Jgit.Lib.ObjectId newHead, global::Org.Eclipse.Jgit.Lib.ObjectId @base, global::Org.Eclipse.Jgit.Lib.ObjectId[] mergedCommits, global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus mergeStatus, global::Org.Eclipse.Jgit.Merge.MergeStrategy mergeStrategy, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.MergeResult> lowLevelResults) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;[Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/api/MergeResult$MergeStatus;Lorg/eclipse/jgit/merge/MergeStrategy;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mergedCommits = JNIEnv.NewArray (mergedCommits);
			IntPtr native_lowLevelResults = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.MergeResult>.ToLocalJniHandle (lowLevelResults);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((newHead == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newHead).Handle);
				__args [1] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [2] = new JniArgumentValue (native_mergedCommits);
				__args [3] = new JniArgumentValue ((mergeStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeStatus).Handle);
				__args [4] = new JniArgumentValue ((mergeStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeStrategy).Handle);
				__args [5] = new JniArgumentValue (native_lowLevelResults);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (mergedCommits != null) {
					JNIEnv.CopyArray (native_mergedCommits, mergedCommits);
					JNIEnv.DeleteLocalRef (native_mergedCommits);
				}
				JNIEnv.DeleteLocalRef (native_lowLevelResults);
				global::System.GC.KeepAlive (newHead);
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (mergedCommits);
				global::System.GC.KeepAlive (mergeStatus);
				global::System.GC.KeepAlive (mergeStrategy);
				global::System.GC.KeepAlive (lowLevelResults);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/constructor[@name='MergeResult' and count(parameter)=7 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId[]'] and parameter[4][@type='org.eclipse.jgit.api.MergeResult.MergeStatus'] and parameter[5][@type='org.eclipse.jgit.merge.MergeStrategy'] and parameter[6][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.merge.MergeResult&lt;?&gt;&gt;'] and parameter[7][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;[Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/api/MergeResult$MergeStatus;Lorg/eclipse/jgit/merge/MergeStrategy;Ljava/util/Map;Ljava/lang/String;)V", "")]
		public unsafe MergeResult (global::Org.Eclipse.Jgit.Lib.ObjectId newHead, global::Org.Eclipse.Jgit.Lib.ObjectId @base, global::Org.Eclipse.Jgit.Lib.ObjectId[] mergedCommits, global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus mergeStatus, global::Org.Eclipse.Jgit.Merge.MergeStrategy mergeStrategy, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.MergeResult> lowLevelResults, string description) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;[Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/api/MergeResult$MergeStatus;Lorg/eclipse/jgit/merge/MergeStrategy;Ljava/util/Map;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mergedCommits = JNIEnv.NewArray (mergedCommits);
			IntPtr native_lowLevelResults = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.MergeResult>.ToLocalJniHandle (lowLevelResults);
			IntPtr native_description = JNIEnv.NewString ((string)description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((newHead == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newHead).Handle);
				__args [1] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [2] = new JniArgumentValue (native_mergedCommits);
				__args [3] = new JniArgumentValue ((mergeStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeStatus).Handle);
				__args [4] = new JniArgumentValue ((mergeStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeStrategy).Handle);
				__args [5] = new JniArgumentValue (native_lowLevelResults);
				__args [6] = new JniArgumentValue (native_description);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (mergedCommits != null) {
					JNIEnv.CopyArray (native_mergedCommits, mergedCommits);
					JNIEnv.DeleteLocalRef (native_mergedCommits);
				}
				JNIEnv.DeleteLocalRef (native_lowLevelResults);
				JNIEnv.DeleteLocalRef (native_description);
				global::System.GC.KeepAlive (newHead);
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (mergedCommits);
				global::System.GC.KeepAlive (mergeStatus);
				global::System.GC.KeepAlive (mergeStrategy);
				global::System.GC.KeepAlive (lowLevelResults);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/constructor[@name='MergeResult' and count(parameter)=8 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId[]'] and parameter[4][@type='org.eclipse.jgit.api.MergeResult.MergeStatus'] and parameter[5][@type='org.eclipse.jgit.merge.MergeStrategy'] and parameter[6][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.merge.MergeResult&lt;?&gt;&gt;'] and parameter[7][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.merge.ResolveMerger.MergeFailureReason&gt;'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;[Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/api/MergeResult$MergeStatus;Lorg/eclipse/jgit/merge/MergeStrategy;Ljava/util/Map;Ljava/util/Map;Ljava/lang/String;)V", "")]
		public unsafe MergeResult (global::Org.Eclipse.Jgit.Lib.ObjectId newHead, global::Org.Eclipse.Jgit.Lib.ObjectId @base, global::Org.Eclipse.Jgit.Lib.ObjectId[] mergedCommits, global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus mergeStatus, global::Org.Eclipse.Jgit.Merge.MergeStrategy mergeStrategy, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.MergeResult> lowLevelResults, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> failingPaths, string description) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;[Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/api/MergeResult$MergeStatus;Lorg/eclipse/jgit/merge/MergeStrategy;Ljava/util/Map;Ljava/util/Map;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mergedCommits = JNIEnv.NewArray (mergedCommits);
			IntPtr native_lowLevelResults = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.MergeResult>.ToLocalJniHandle (lowLevelResults);
			IntPtr native_failingPaths = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason>.ToLocalJniHandle (failingPaths);
			IntPtr native_description = JNIEnv.NewString ((string)description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((newHead == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newHead).Handle);
				__args [1] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [2] = new JniArgumentValue (native_mergedCommits);
				__args [3] = new JniArgumentValue ((mergeStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeStatus).Handle);
				__args [4] = new JniArgumentValue ((mergeStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeStrategy).Handle);
				__args [5] = new JniArgumentValue (native_lowLevelResults);
				__args [6] = new JniArgumentValue (native_failingPaths);
				__args [7] = new JniArgumentValue (native_description);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (mergedCommits != null) {
					JNIEnv.CopyArray (native_mergedCommits, mergedCommits);
					JNIEnv.DeleteLocalRef (native_mergedCommits);
				}
				JNIEnv.DeleteLocalRef (native_lowLevelResults);
				JNIEnv.DeleteLocalRef (native_failingPaths);
				JNIEnv.DeleteLocalRef (native_description);
				global::System.GC.KeepAlive (newHead);
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (mergedCommits);
				global::System.GC.KeepAlive (mergeStatus);
				global::System.GC.KeepAlive (mergeStrategy);
				global::System.GC.KeepAlive (lowLevelResults);
				global::System.GC.KeepAlive (failingPaths);
			}
		}

		static Delegate cb_getBase;
#pragma warning disable 0169
		static Delegate GetGetBaseHandler ()
		{
			if (cb_getBase == null)
				cb_getBase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBase);
			return cb_getBase;
		}

		static IntPtr n_GetBase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Base);
		}
#pragma warning restore 0169

		/// <returns>base the common base which was used to produce a content-merge.
		///         May be &lt;code&gt;null&lt;/code&gt; if the merge-result was produced without
		///         computing a common base</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Base {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='getBase' and count(parameter)=0]"
			[Register ("getBase", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetBaseHandler")]
			get {
				const string __id = "getBase.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCheckoutConflicts;
#pragma warning disable 0169
		static Delegate GetGetCheckoutConflictsHandler ()
		{
			if (cb_getCheckoutConflicts == null)
				cb_getCheckoutConflicts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCheckoutConflicts);
			return cb_getCheckoutConflicts;
		}

		static IntPtr n_GetCheckoutConflicts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CheckoutConflicts);
		}
#pragma warning restore 0169

		/// <summary>Returns a list of paths that cause a checkout conflict.</summary>
		/// <returns>the list of files that caused the checkout conflict.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> CheckoutConflicts {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='getCheckoutConflicts' and count(parameter)=0]"
			[Register ("getCheckoutConflicts", "()Ljava/util/List;", "GetGetCheckoutConflictsHandler")]
			get {
				const string __id = "getCheckoutConflicts.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, int[][]>.ToLocalJniHandle (__this.Conflicts);
		}
#pragma warning restore 0169

		static Delegate cb_setConflicts_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetConflicts_Ljava_util_Map_Handler ()
		{
			if (cb_setConflicts_Ljava_util_Map_ == null)
				cb_setConflicts_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConflicts_Ljava_util_Map_);
			return cb_setConflicts_Ljava_util_Map_;
		}

		static void n_SetConflicts_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conflicts)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var conflicts = global::Android.Runtime.JavaDictionary<string, int[][]>.FromJniHandle (native_conflicts, JniHandleOwnership.DoNotTransfer);
			__this.Conflicts = conflicts;
		}
#pragma warning restore 0169

		/// <summary>Returns information about the conflicts which occurred during a
		/// <c>MergeCommand</c>.</summary>
		/// <returns>the conflicts or &lt;code&gt;null&lt;/code&gt; if no conflict occurred</returns>
		/// <param name="conflicts">the conflicts to set</param>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, int[][]> Conflicts {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='getConflicts' and count(parameter)=0]"
			[Register ("getConflicts", "()Ljava/util/Map;", "GetGetConflictsHandler")]
			get {
				const string __id = "getConflicts.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, int[][]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='setConflicts' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, int[][]&gt;']]"
			[Register ("setConflicts", "(Ljava/util/Map;)V", "GetSetConflicts_Ljava_util_Map_Handler")]
			set {
				const string __id = "setConflicts.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, int[][]>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason>.ToLocalJniHandle (__this.FailingPaths);
		}
#pragma warning restore 0169

		/// <summary>Returns a list of paths causing this merge to fail as returned by
		/// <c>ResolveMerger#getFailingPaths()</c></summary>
		/// <returns>the list of paths causing this merge to fail or &lt;code&gt;null&lt;/code&gt;
		///         if no failure occurred</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> FailingPaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='getFailingPaths' and count(parameter)=0]"
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

		static Delegate cb_getNewHead;
#pragma warning disable 0169
		static Delegate GetGetNewHeadHandler ()
		{
			if (cb_getNewHead == null)
				cb_getNewHead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewHead);
			return cb_getNewHead;
		}

		static IntPtr n_GetNewHead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewHead);
		}
#pragma warning restore 0169

		/// <returns>the object the head points at after the merge</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId NewHead {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='getNewHead' and count(parameter)=0]"
			[Register ("getNewHead", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetNewHeadHandler")]
			get {
				const string __id = "getNewHead.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addConflict_Ljava_lang_String_arrayarrayI;
#pragma warning disable 0169
		static Delegate GetAddConflict_Ljava_lang_String_arrayarrayIHandler ()
		{
			if (cb_addConflict_Ljava_lang_String_arrayarrayI == null)
				cb_addConflict_Ljava_lang_String_arrayarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddConflict_Ljava_lang_String_arrayarrayI);
			return cb_addConflict_Ljava_lang_String_arrayarrayI;
		}

		static void n_AddConflict_Ljava_lang_String_arrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_conflictingRanges)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			var conflictingRanges = (int[][]) JNIEnv.GetArray (native_conflictingRanges, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.AddConflict (path, conflictingRanges);
			if (conflictingRanges != null)
				JNIEnv.CopyArray (conflictingRanges, native_conflictingRanges);
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <param name="conflictingRanges">the conflicts to set</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='addConflict' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int[][]']]"
		[Register ("addConflict", "(Ljava/lang/String;[[I)V", "GetAddConflict_Ljava_lang_String_arrayarrayIHandler")]
		public virtual unsafe void AddConflict (string path, int[][] conflictingRanges)
		{
			const string __id = "addConflict.(Ljava/lang/String;[[I)V";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			IntPtr native_conflictingRanges = JNIEnv.NewArray (conflictingRanges);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_conflictingRanges);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				if (conflictingRanges != null) {
					JNIEnv.CopyArray (native_conflictingRanges, conflictingRanges);
					JNIEnv.DeleteLocalRef (native_conflictingRanges);
				}
				global::System.GC.KeepAlive (conflictingRanges);
			}
		}

		static Delegate cb_addConflict_Ljava_lang_String_Lorg_eclipse_jgit_merge_MergeResult_;
#pragma warning disable 0169
		static Delegate GetAddConflict_Ljava_lang_String_Lorg_eclipse_jgit_merge_MergeResult_Handler ()
		{
			if (cb_addConflict_Ljava_lang_String_Lorg_eclipse_jgit_merge_MergeResult_ == null)
				cb_addConflict_Ljava_lang_String_Lorg_eclipse_jgit_merge_MergeResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddConflict_Ljava_lang_String_Lorg_eclipse_jgit_merge_MergeResult_);
			return cb_addConflict_Ljava_lang_String_Lorg_eclipse_jgit_merge_MergeResult_;
		}

		static void n_AddConflict_Ljava_lang_String_Lorg_eclipse_jgit_merge_MergeResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_lowLevelResult)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			var lowLevelResult = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeResult> (native_lowLevelResult, JniHandleOwnership.DoNotTransfer);
			__this.AddConflict (path, lowLevelResult);
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <param name="lowLevelResult">lowLevelResult</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='addConflict' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.merge.MergeResult&lt;?&gt;']]"
		[Register ("addConflict", "(Ljava/lang/String;Lorg/eclipse/jgit/merge/MergeResult;)V", "GetAddConflict_Ljava_lang_String_Lorg_eclipse_jgit_merge_MergeResult_Handler")]
		public virtual unsafe void AddConflict (string path, global::Org.Eclipse.Jgit.Merge.MergeResult lowLevelResult)
		{
			const string __id = "addConflict.(Ljava/lang/String;Lorg/eclipse/jgit/merge/MergeResult;)V";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((lowLevelResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lowLevelResult).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (lowLevelResult);
			}
		}

		static Delegate cb_getMergeStatus;
#pragma warning disable 0169
		static Delegate GetGetMergeStatusHandler ()
		{
			if (cb_getMergeStatus == null)
				cb_getMergeStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMergeStatus);
			return cb_getMergeStatus;
		}

		static IntPtr n_GetMergeStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMergeStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='getMergeStatus' and count(parameter)=0]"
		[Register ("getMergeStatus", "()Lorg/eclipse/jgit/api/MergeResult$MergeStatus;", "GetGetMergeStatusHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus GetMergeStatus ()
		{
			const string __id = "getMergeStatus.()Lorg/eclipse/jgit/api/MergeResult$MergeStatus;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult.MergeStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMergedCommits;
#pragma warning disable 0169
		static Delegate GetGetMergedCommitsHandler ()
		{
			if (cb_getMergedCommits == null)
				cb_getMergedCommits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMergedCommits);
			return cb_getMergedCommits;
		}

		static IntPtr n_GetMergedCommits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMergedCommits ());
		}
#pragma warning restore 0169

		/// <returns>all the commits which have been merged together</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeResult']/method[@name='getMergedCommits' and count(parameter)=0]"
		[Register ("getMergedCommits", "()[Lorg/eclipse/jgit/lib/ObjectId;", "GetGetMergedCommitsHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId[] GetMergedCommits ()
		{
			const string __id = "getMergedCommits.()[Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Jgit.Lib.ObjectId[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.ObjectId));
			} finally {
			}
		}

	}
}
