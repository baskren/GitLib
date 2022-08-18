using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>Holds configuration for merging into a given branch</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/MergeConfig", DoNotGenerateAcw=true)]
	public partial class MergeConfig : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/MergeConfig", typeof (MergeConfig));

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

		protected MergeConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getFastForwardMode;
#pragma warning disable 0169
		static Delegate GetGetFastForwardModeHandler ()
		{
			if (cb_getFastForwardMode == null)
				cb_getFastForwardMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFastForwardMode);
			return cb_getFastForwardMode;
		}

		static IntPtr n_GetFastForwardMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FastForwardMode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode FastForwardMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeConfig']/method[@name='getFastForwardMode' and count(parameter)=0]"
			[Register ("getFastForwardMode", "()Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;", "GetGetFastForwardModeHandler")]
			get {
				const string __id = "getFastForwardMode.()Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCommit;
#pragma warning disable 0169
		static Delegate GetIsCommitHandler ()
		{
			if (cb_isCommit == null)
				cb_isCommit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCommit);
			return cb_isCommit;
		}

		static bool n_IsCommit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCommit;
		}
#pragma warning restore 0169

		/// <returns>false if --no-commit is configured for this branch, true
		///         otherwise (event if --squash is configured)</returns>
		public virtual unsafe bool IsCommit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeConfig']/method[@name='isCommit' and count(parameter)=0]"
			[Register ("isCommit", "()Z", "GetIsCommitHandler")]
			get {
				const string __id = "isCommit.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSquash;
#pragma warning disable 0169
		static Delegate GetIsSquashHandler ()
		{
			if (cb_isSquash == null)
				cb_isSquash = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSquash);
			return cb_isSquash;
		}

		static bool n_IsSquash (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSquash;
		}
#pragma warning restore 0169

		/// <returns>true if merges into this branch are configured to be squash
		///         merges, false otherwise</returns>
		public virtual unsafe bool IsSquash {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeConfig']/method[@name='isSquash' and count(parameter)=0]"
			[Register ("isSquash", "()Z", "GetIsSquashHandler")]
			get {
				const string __id = "isSquash.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="repo">repo</param>
		/// <returns>merge configuration for the current branch of the repository</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeConfig']/method[@name='getConfigForCurrentBranch' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("getConfigForCurrentBranch", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/merge/MergeConfig;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Merge.MergeConfig GetConfigForCurrentBranch (global::Org.Eclipse.Jgit.Lib.Repository repo)
		{
			const string __id = "getConfigForCurrentBranch.(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/merge/MergeConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeConfig']/method[@name='getParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParser", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Config$SectionParser;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.Config.ISectionParser GetParser (string branch)
		{
			const string __id = "getParser.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Config$SectionParser;";
			IntPtr native_branch = JNIEnv.NewString ((string)branch);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_branch);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.ISectionParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_branch);
			}
		}

	}
}
