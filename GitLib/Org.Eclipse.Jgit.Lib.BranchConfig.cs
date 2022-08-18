using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Branch section of a Git configuration file.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BranchConfig", DoNotGenerateAcw=true)]
	public partial class BranchConfig : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchConfig']/field[@name='LOCAL_REPOSITORY']"
		[Register ("LOCAL_REPOSITORY")]
		public const string LocalRepository = (string) ".";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BranchConfig", typeof (BranchConfig));

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

		protected BranchConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="config">the config to read from</param>
		/// <param name="branchName">the short branch name of the section to read</param>
		/// <summary>Create a new branch config, which will read configuration from config
		/// about specified branch.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchConfig']/constructor[@name='BranchConfig' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Config;Ljava/lang/String;)V", "")]
		public unsafe BranchConfig (global::Org.Eclipse.Jgit.Lib.Config config, string branchName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Config;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_branchName = JNIEnv.NewString ((string)branchName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [1] = new JniArgumentValue (native_branchName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_branchName);
				global::System.GC.KeepAlive (config);
			}
		}

		static Delegate cb_isRebase;
#pragma warning disable 0169
		static Delegate GetIsRebaseHandler ()
		{
			if (cb_isRebase == null)
				cb_isRebase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRebase);
			return cb_isRebase;
		}

		static bool n_IsRebase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRebase;
		}
#pragma warning restore 0169

		/// <returns>
		///   <c>true</c> if the branch is configured to be rebased</returns>
		public virtual unsafe bool IsRebase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchConfig']/method[@name='isRebase' and count(parameter)=0]"
			[Register ("isRebase", "()Z", "GetIsRebaseHandler")]
			get {
				const string __id = "isRebase.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRemoteLocal;
#pragma warning disable 0169
		static Delegate GetIsRemoteLocalHandler ()
		{
			if (cb_isRemoteLocal == null)
				cb_isRemoteLocal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRemoteLocal);
			return cb_isRemoteLocal;
		}

		static bool n_IsRemoteLocal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRemoteLocal;
		}
#pragma warning restore 0169

		/// <returns>
		///   <c>true</c> if the "remote" setting points to the local
		///         repository (with <c>#LOCAL_REPOSITORY</c>), false otherwise</returns>
		public virtual unsafe bool IsRemoteLocal {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchConfig']/method[@name='isRemoteLocal' and count(parameter)=0]"
			[Register ("isRemoteLocal", "()Z", "GetIsRemoteLocalHandler")]
			get {
				const string __id = "isRemoteLocal.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMerge;
#pragma warning disable 0169
		static Delegate GetGetMergeHandler ()
		{
			if (cb_getMerge == null)
				cb_getMerge = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMerge);
			return cb_getMerge;
		}

		static IntPtr n_GetMerge (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Merge);
		}
#pragma warning restore 0169

		/// <returns>the name of the upstream branch as it is called on the remote, or
		///         <c>null</c> if not defined</returns>
		public virtual unsafe string Merge {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchConfig']/method[@name='getMerge' and count(parameter)=0]"
			[Register ("getMerge", "()Ljava/lang/String;", "GetGetMergeHandler")]
			get {
				const string __id = "getMerge.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemote;
#pragma warning disable 0169
		static Delegate GetGetRemoteHandler ()
		{
			if (cb_getRemote == null)
				cb_getRemote = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemote);
			return cb_getRemote;
		}

		static IntPtr n_GetRemote (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Remote);
		}
#pragma warning restore 0169

		/// <returns>the remote this branch is configured to fetch from/push to, or
		///         <c>null</c> if not defined</returns>
		public virtual unsafe string Remote {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchConfig']/method[@name='getRemote' and count(parameter)=0]"
			[Register ("getRemote", "()Ljava/lang/String;", "GetGetRemoteHandler")]
			get {
				const string __id = "getRemote.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemoteTrackingBranch);
		}
#pragma warning restore 0169

		/// <returns>the full remote-tracking branch name or <c>null</c> if it could
		///         not be determined. If you also want local tracked branches use
		///         <c>#getTrackingBranch()</c> instead.</returns>
		public virtual unsafe string RemoteTrackingBranch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchConfig']/method[@name='getRemoteTrackingBranch' and count(parameter)=0]"
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

		static Delegate cb_getTrackingBranch;
#pragma warning disable 0169
		static Delegate GetGetTrackingBranchHandler ()
		{
			if (cb_getTrackingBranch == null)
				cb_getTrackingBranch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTrackingBranch);
			return cb_getTrackingBranch;
		}

		static IntPtr n_GetTrackingBranch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BranchConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackingBranch);
		}
#pragma warning restore 0169

		/// <returns>the full tracking branch name or &lt;code&gt;null&lt;/code&gt; if it could
		///         not be determined</returns>
		public virtual unsafe string TrackingBranch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BranchConfig']/method[@name='getTrackingBranch' and count(parameter)=0]"
			[Register ("getTrackingBranch", "()Ljava/lang/String;", "GetGetTrackingBranchHandler")]
			get {
				const string __id = "getTrackingBranch.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
