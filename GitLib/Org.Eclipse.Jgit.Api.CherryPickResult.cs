using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Encapsulates the result of a <c>CherryPickCommand</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/CherryPickResult", DoNotGenerateAcw=true)]
	public partial class CherryPickResult : global::Java.Lang.Object {

		/// <summary>A &lt;code&gt;CherryPickResult&lt;/code&gt; with status
		/// <c>CherryPickStatus#CONFLICTING</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult']/field[@name='CONFLICT']"
		[Register ("CONFLICT")]
		public static global::Org.Eclipse.Jgit.Api.CherryPickResult Conflict {
			get {
				const string __id = "CONFLICT.Lorg/eclipse/jgit/api/CherryPickResult;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>The cherry-pick status</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult.CherryPickStatus']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/CherryPickResult$CherryPickStatus", DoNotGenerateAcw=true)]
		public partial class CherryPickStatus : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult.CherryPickStatus']/field[@name='CONFLICTING']"
			[Register ("CONFLICTING")]
			public static global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus Conflicting {
				get {
					const string __id = "CONFLICTING.Lorg/eclipse/jgit/api/CherryPickResult$CherryPickStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult.CherryPickStatus']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus Failed {
				get {
					const string __id = "FAILED.Lorg/eclipse/jgit/api/CherryPickResult$CherryPickStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult.CherryPickStatus']/field[@name='OK']"
			[Register ("OK")]
			public static global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus Ok {
				get {
					const string __id = "OK.Lorg/eclipse/jgit/api/CherryPickResult$CherryPickStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CherryPickResult$CherryPickStatus", typeof (CherryPickStatus));

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

			protected CherryPickStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult.CherryPickStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CherryPickResult$CherryPickStatus;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CherryPickResult$CherryPickStatus;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult.CherryPickStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/api/CherryPickResult$CherryPickStatus;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/api/CherryPickResult$CherryPickStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CherryPickResult", typeof (CherryPickResult));

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

		protected CherryPickResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="failingPaths">list of paths causing this cherry-pick to fail (see
		///            <c>ResolveMerger#getFailingPaths()</c> for details)</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult']/constructor[@name='CherryPickResult' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.merge.ResolveMerger.MergeFailureReason&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe CherryPickResult (global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> failingPaths) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_failingPaths = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason>.ToLocalJniHandle (failingPaths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_failingPaths);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_failingPaths);
				global::System.GC.KeepAlive (failingPaths);
			}
		}

		/// <param name="newHead">commit the head points at after this cherry-pick</param>
		/// <param name="cherryPickedRefs">list of successfully cherry-picked &lt;code&gt;Ref&lt;/code&gt;'s</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult']/constructor[@name='CherryPickResult' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.lib.Ref&gt;']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/revwalk/RevCommit;Ljava/util/List;)V", "")]
		public unsafe CherryPickResult (global::Org.Eclipse.Jgit.Revwalk.RevCommit newHead, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> cherryPickedRefs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/revwalk/RevCommit;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_cherryPickedRefs = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (cherryPickedRefs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((newHead == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newHead).Handle);
				__args [1] = new JniArgumentValue (native_cherryPickedRefs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cherryPickedRefs);
				global::System.GC.KeepAlive (newHead);
				global::System.GC.KeepAlive (cherryPickedRefs);
			}
		}

		static Delegate cb_getCherryPickedRefs;
#pragma warning disable 0169
		static Delegate GetGetCherryPickedRefsHandler ()
		{
			if (cb_getCherryPickedRefs == null)
				cb_getCherryPickedRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCherryPickedRefs);
			return cb_getCherryPickedRefs;
		}

		static IntPtr n_GetCherryPickedRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.CherryPickedRefs);
		}
#pragma warning restore 0169

		/// <returns>the list of successfully cherry-picked &lt;code&gt;Ref&lt;/code&gt;'s,
		///         &lt;code&gt;null&lt;/code&gt; if <c>#getStatus</c> is not
		///         <c>CherryPickStatus#OK</c></returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> CherryPickedRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult']/method[@name='getCherryPickedRefs' and count(parameter)=0]"
			[Register ("getCherryPickedRefs", "()Ljava/util/List;", "GetGetCherryPickedRefsHandler")]
			get {
				const string __id = "getCherryPickedRefs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason>.ToLocalJniHandle (__this.FailingPaths);
		}
#pragma warning restore 0169

		/// <returns>the list of paths causing this cherry-pick to fail (see
		///         <c>ResolveMerger#getFailingPaths()</c> for details),
		///         &lt;code&gt;null&lt;/code&gt; if <c>#getStatus</c> is not
		///         <c>CherryPickStatus#FAILED</c></returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> FailingPaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult']/method[@name='getFailingPaths' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewHead);
		}
#pragma warning restore 0169

		/// <returns>the commit the head points at after this cherry-pick,
		///         &lt;code&gt;null&lt;/code&gt; if <c>#getStatus</c> is not
		///         <c>CherryPickStatus#OK</c></returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit NewHead {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult']/method[@name='getNewHead' and count(parameter)=0]"
			[Register ("getNewHead", "()Lorg/eclipse/jgit/revwalk/RevCommit;", "GetGetNewHeadHandler")]
			get {
				const string __id = "getNewHead.()Lorg/eclipse/jgit/revwalk/RevCommit;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickResult']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lorg/eclipse/jgit/api/CherryPickResult$CherryPickStatus;", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()Lorg/eclipse/jgit/api/CherryPickResult$CherryPickStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult.CherryPickStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
