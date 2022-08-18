using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Encapsulates the result of a <c>PullCommand</c></summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PullResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/PullResult", DoNotGenerateAcw=true)]
	public partial class PullResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/PullResult", typeof (PullResult));

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

		protected PullResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getFetchResult;
#pragma warning disable 0169
		static Delegate GetGetFetchResultHandler ()
		{
			if (cb_getFetchResult == null)
				cb_getFetchResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFetchResult);
			return cb_getFetchResult;
		}

		static IntPtr n_GetFetchResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PullResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FetchResult);
		}
#pragma warning restore 0169

		/// <returns>the fetch result, or &lt;code&gt;null&lt;/code&gt;</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.FetchResult FetchResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PullResult']/method[@name='getFetchResult' and count(parameter)=0]"
			[Register ("getFetchResult", "()Lorg/eclipse/jgit/transport/FetchResult;", "GetGetFetchResultHandler")]
			get {
				const string __id = "getFetchResult.()Lorg/eclipse/jgit/transport/FetchResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.FetchResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFetchedFrom;
#pragma warning disable 0169
		static Delegate GetGetFetchedFromHandler ()
		{
			if (cb_getFetchedFrom == null)
				cb_getFetchedFrom = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFetchedFrom);
			return cb_getFetchedFrom;
		}

		static IntPtr n_GetFetchedFrom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PullResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FetchedFrom);
		}
#pragma warning restore 0169

		/// <returns>the name of the remote configuration from which fetch was tried,
		///         or &lt;code&gt;null&lt;/code&gt;</returns>
		public virtual unsafe string FetchedFrom {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PullResult']/method[@name='getFetchedFrom' and count(parameter)=0]"
			[Register ("getFetchedFrom", "()Ljava/lang/String;", "GetGetFetchedFromHandler")]
			get {
				const string __id = "getFetchedFrom.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PullResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccessful;
		}
#pragma warning restore 0169

		/// <returns>whether the pull was successful</returns>
		public virtual unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PullResult']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
			get {
				const string __id = "isSuccessful.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMergeResult;
#pragma warning disable 0169
		static Delegate GetGetMergeResultHandler ()
		{
			if (cb_getMergeResult == null)
				cb_getMergeResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMergeResult);
			return cb_getMergeResult;
		}

		static IntPtr n_GetMergeResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PullResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MergeResult);
		}
#pragma warning restore 0169

		/// <returns>the merge result, or &lt;code&gt;null&lt;/code&gt;</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeResult MergeResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PullResult']/method[@name='getMergeResult' and count(parameter)=0]"
			[Register ("getMergeResult", "()Lorg/eclipse/jgit/api/MergeResult;", "GetGetMergeResultHandler")]
			get {
				const string __id = "getMergeResult.()Lorg/eclipse/jgit/api/MergeResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRebaseResult;
#pragma warning disable 0169
		static Delegate GetGetRebaseResultHandler ()
		{
			if (cb_getRebaseResult == null)
				cb_getRebaseResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRebaseResult);
			return cb_getRebaseResult;
		}

		static IntPtr n_GetRebaseResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PullResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RebaseResult);
		}
#pragma warning restore 0169

		/// <returns>the rebase result, or &lt;code&gt;null&lt;/code&gt;</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseResult RebaseResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PullResult']/method[@name='getRebaseResult' and count(parameter)=0]"
			[Register ("getRebaseResult", "()Lorg/eclipse/jgit/api/RebaseResult;", "GetGetRebaseResultHandler")]
			get {
				const string __id = "getRebaseResult.()Lorg/eclipse/jgit/api/RebaseResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
