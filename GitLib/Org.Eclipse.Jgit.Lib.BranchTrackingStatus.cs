using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Status of a branch's relation to its remote-tracking branch.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchTrackingStatus']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BranchTrackingStatus", DoNotGenerateAcw=true)]
	public partial class BranchTrackingStatus : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BranchTrackingStatus", typeof (BranchTrackingStatus));

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

		protected BranchTrackingStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAheadCount;
#pragma warning disable 0169
		static Delegate GetGetAheadCountHandler ()
		{
			if (cb_getAheadCount == null)
				cb_getAheadCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAheadCount);
			return cb_getAheadCount;
		}

		static int n_GetAheadCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AheadCount;
		}
#pragma warning restore 0169

		/// <returns>number of commits that the local branch is ahead of the
		///         remote-tracking branch</returns>
		public virtual unsafe int AheadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchTrackingStatus']/method[@name='getAheadCount' and count(parameter)=0]"
			[Register ("getAheadCount", "()I", "GetGetAheadCountHandler")]
			get {
				const string __id = "getAheadCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBehindCount;
#pragma warning disable 0169
		static Delegate GetGetBehindCountHandler ()
		{
			if (cb_getBehindCount == null)
				cb_getBehindCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBehindCount);
			return cb_getBehindCount;
		}

		static int n_GetBehindCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BehindCount;
		}
#pragma warning restore 0169

		/// <returns>number of commits that the local branch is behind of the
		///         remote-tracking branch</returns>
		public virtual unsafe int BehindCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchTrackingStatus']/method[@name='getBehindCount' and count(parameter)=0]"
			[Register ("getBehindCount", "()I", "GetGetBehindCountHandler")]
			get {
				const string __id = "getBehindCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRemoteTrackingBranch;
#pragma warning disable 0169
		static Delegate GetGetRemoteTrackingBranchHandler ()
		{
			if (cb_getRemoteTrackingBranch == null)
				cb_getRemoteTrackingBranch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemoteTrackingBranch);
			return cb_getRemoteTrackingBranch;
		}

		static IntPtr n_GetRemoteTrackingBranch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemoteTrackingBranch);
		}
#pragma warning restore 0169

		/// <returns>full remote-tracking branch name</returns>
		public virtual unsafe string RemoteTrackingBranch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchTrackingStatus']/method[@name='getRemoteTrackingBranch' and count(parameter)=0]"
			[Register ("getRemoteTrackingBranch", "()Ljava/lang/String;", "GetGetRemoteTrackingBranchHandler")]
			get {
				const string __id = "getRemoteTrackingBranch.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <param name="repository">the git repository to compute the status from</param>
		/// <param name="branchName">the local branch</param>
		/// <summary>Compute the tracking status for the &lt;code&gt;branchName&lt;/code&gt; in
		/// &lt;code&gt;repository&lt;/code&gt;.</summary>
		/// <returns>the tracking status, or null if it is not known</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchTrackingStatus']/method[@name='of' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String']]"
		[Register ("of", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Lorg/eclipse/jgit/lib/BranchTrackingStatus;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.BranchTrackingStatus Of (global::Org.Eclipse.Jgit.Lib.Repository repository, string branchName)
		{
			const string __id = "of.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Lorg/eclipse/jgit/lib/BranchTrackingStatus;";
			IntPtr native_branchName = JNIEnv.NewString ((string)branchName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue (native_branchName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchTrackingStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_branchName);
				global::System.GC.KeepAlive (repository);
			}
		}

	}
}
