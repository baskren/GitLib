using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>revert</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/RevertCommand", DoNotGenerateAcw=true)]
	public partial class RevertCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Revwalk.RevCommit> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/RevertCommand", typeof (RevertCommand));

		internal static new IntPtr class_ref {
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

		protected RevertCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/constructor[@name='RevertCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe RevertCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_getFailingResult;
#pragma warning disable 0169
		static Delegate GetGetFailingResultHandler ()
		{
			if (cb_getFailingResult == null)
				cb_getFailingResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFailingResult);
			return cb_getFailingResult;
		}

		static IntPtr n_GetFailingResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FailingResult);
		}
#pragma warning restore 0169

		/// <returns>the result of the merge failure, &lt;code&gt;null&lt;/code&gt; if no merge
		///         failure occurred during the revert</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeResult FailingResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/method[@name='getFailingResult' and count(parameter)=0]"
			[Register ("getFailingResult", "()Lorg/eclipse/jgit/api/MergeResult;", "GetGetFailingResultHandler")]
			get {
				const string __id = "getFailingResult.()Lorg/eclipse/jgit/api/MergeResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRevertedRefs;
#pragma warning disable 0169
		static Delegate GetGetRevertedRefsHandler ()
		{
			if (cb_getRevertedRefs == null)
				cb_getRevertedRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRevertedRefs);
			return cb_getRevertedRefs;
		}

		static IntPtr n_GetRevertedRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.RevertedRefs);
		}
#pragma warning restore 0169

		/// <returns>the list of successfully reverted <c>Ref</c>'s. Never
		///         &lt;code&gt;null&lt;/code&gt; but maybe an empty list if no commit was
		///         successfully cherry-picked</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> RevertedRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/method[@name='getRevertedRefs' and count(parameter)=0]"
			[Register ("getRevertedRefs", "()Ljava/util/List;", "GetGetRevertedRefsHandler")]
			get {
				const string __id = "getRevertedRefs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnmergedPaths;
#pragma warning disable 0169
		static Delegate GetGetUnmergedPathsHandler ()
		{
			if (cb_getUnmergedPaths == null)
				cb_getUnmergedPaths = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUnmergedPaths);
			return cb_getUnmergedPaths;
		}

		static IntPtr n_GetUnmergedPaths (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UnmergedPaths);
		}
#pragma warning restore 0169

		/// <returns>the unmerged paths, will be null if no merge conflicts</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> UnmergedPaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/method[@name='getUnmergedPaths' and count(parameter)=0]"
			[Register ("getUnmergedPaths", "()Ljava/util/List;", "GetGetUnmergedPathsHandler")]
			get {
				const string __id = "getUnmergedPaths.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>revert</c> command with all the options and parameters
		/// collected by the setter methods (e.</summary>
		/// <returns>on success the <c>RevCommit</c> pointed to by the new HEAD is
		///         returned. If a failure occurred during revert &lt;code&gt;null&lt;/code&gt;
		///         is returned. The list of successfully reverted <c>Ref</c>'s can
		///         be obtained by calling <c>#getRevertedRefs()</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/revwalk/RevCommit;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetInclude_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_commit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var commit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_commit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (name, commit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">a name given to the commit</param>
		/// <param name="commit">the Id of a commit which is reverted into the current head</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/method[@name='include' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("include", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/RevertCommand;", "GetInclude_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RevertCommand Include (string name, global::Org.Eclipse.Jgit.Lib.AnyObjectId commit)
		{
			const string __id = "include.(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/RevertCommand;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (commit);
			}
		}

		static Delegate cb_include_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetInclude_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_include_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_include_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Include_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_include_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Include_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_commit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_commit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (commit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="commit">the Id of a commit which is reverted into the current head</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("include", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/RevertCommand;", "GetInclude_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RevertCommand Include (global::Org.Eclipse.Jgit.Lib.AnyObjectId commit)
		{
			const string __id = "include.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/RevertCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (commit);
			}
		}

		static Delegate cb_include_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetInclude_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_include_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_include_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Include_Lorg_eclipse_jgit_lib_Ref_);
			return cb_include_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_Include_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_commit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commit = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_commit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (commit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="commit">a reference to a commit which is reverted into the current
		///            head</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("include", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/RevertCommand;", "GetInclude_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RevertCommand Include (global::Org.Eclipse.Jgit.Lib.IRef commit)
		{
			const string __id = "include.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/RevertCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (commit);
			}
		}

		static Delegate cb_setOurCommitName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOurCommitName_Ljava_lang_String_Handler ()
		{
			if (cb_setOurCommitName_Ljava_lang_String_ == null)
				cb_setOurCommitName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOurCommitName_Ljava_lang_String_);
			return cb_setOurCommitName_Ljava_lang_String_;
		}

		static IntPtr n_SetOurCommitName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ourCommitName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ourCommitName = JNIEnv.GetString (native_ourCommitName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOurCommitName (ourCommitName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ourCommitName">the name that should be used in the "OURS" place for conflict
		///            markers</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/method[@name='setOurCommitName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOurCommitName", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/RevertCommand;", "GetSetOurCommitName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RevertCommand SetOurCommitName (string ourCommitName)
		{
			const string __id = "setOurCommitName.(Ljava/lang/String;)Lorg/eclipse/jgit/api/RevertCommand;";
			IntPtr native_ourCommitName = JNIEnv.NewString ((string)ourCommitName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ourCommitName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_ourCommitName);
			}
		}

		static Delegate cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_;
#pragma warning disable 0169
		static Delegate GetSetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_Handler ()
		{
			if (cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_ == null)
				cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_);
			return cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_;
		}

		static IntPtr n_SetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStrategy (strategy));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="strategy">The merge strategy to use during this revert command.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RevertCommand']/method[@name='setStrategy' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.merge.MergeStrategy']]"
		[Register ("setStrategy", "(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/RevertCommand;", "GetSetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RevertCommand SetStrategy (global::Org.Eclipse.Jgit.Merge.MergeStrategy strategy)
		{
			const string __id = "setStrategy.(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/RevertCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
			}
		}

	}
}
