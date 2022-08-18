using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>cherry-pick</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/CherryPickCommand", DoNotGenerateAcw=true)]
	public partial class CherryPickCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Api.CherryPickResult> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CherryPickCommand", typeof (CherryPickCommand));

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

		protected CherryPickCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/constructor[@name='CherryPickCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe CherryPickCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Cherry-Pick</c> command with all the options and
		/// parameters collected by the setter methods (e.</summary>
		/// <returns>the result of the cherry-pick</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/api/CherryPickResult;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Api.CherryPickResult Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/api/CherryPickResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var commit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_commit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (name, commit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">a name given to the commit</param>
		/// <param name="commit">the Id of a commit which is cherry-picked to the current head</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/method[@name='include' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("include", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/CherryPickCommand;", "GetInclude_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickCommand Include (string name, global::Org.Eclipse.Jgit.Lib.AnyObjectId commit)
		{
			const string __id = "include.(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/CherryPickCommand;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_commit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (commit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="commit">the Id of a commit which is cherry-picked to the current head</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("include", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/CherryPickCommand;", "GetInclude_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickCommand Include (global::Org.Eclipse.Jgit.Lib.AnyObjectId commit)
		{
			const string __id = "include.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/CherryPickCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commit = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_commit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (commit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="commit">a reference to a commit which is cherry-picked to the current
		///            head</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("include", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/CherryPickCommand;", "GetInclude_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickCommand Include (global::Org.Eclipse.Jgit.Lib.IRef commit)
		{
			const string __id = "include.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/CherryPickCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (commit);
			}
		}

		static Delegate cb_setMainlineParentNumber_I;
#pragma warning disable 0169
		static Delegate GetSetMainlineParentNumber_IHandler ()
		{
			if (cb_setMainlineParentNumber_I == null)
				cb_setMainlineParentNumber_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetMainlineParentNumber_I);
			return cb_setMainlineParentNumber_I;
		}

		static IntPtr n_SetMainlineParentNumber_I (IntPtr jnienv, IntPtr native__this, int mainlineParentNumber)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMainlineParentNumber (mainlineParentNumber));
		}
#pragma warning restore 0169

		/// <param name="mainlineParentNumber">the (1-based) parent number to diff against. This allows
		///            cherry-picking of merges.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/method[@name='setMainlineParentNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMainlineParentNumber", "(I)Lorg/eclipse/jgit/api/CherryPickCommand;", "GetSetMainlineParentNumber_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickCommand SetMainlineParentNumber (int mainlineParentNumber)
		{
			const string __id = "setMainlineParentNumber.(I)Lorg/eclipse/jgit/api/CherryPickCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mainlineParentNumber);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNoCommit_Z;
#pragma warning disable 0169
		static Delegate GetSetNoCommit_ZHandler ()
		{
			if (cb_setNoCommit_Z == null)
				cb_setNoCommit_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetNoCommit_Z);
			return cb_setNoCommit_Z;
		}

		static IntPtr n_SetNoCommit_Z (IntPtr jnienv, IntPtr native__this, bool noCommit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNoCommit (noCommit));
		}
#pragma warning restore 0169

		/// <param name="noCommit">true to cherry-pick without committing, false to commit after
		///            each pick (default)</param>
		/// <summary>Allows cherry-picking changes without committing them.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/method[@name='setNoCommit' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNoCommit", "(Z)Lorg/eclipse/jgit/api/CherryPickCommand;", "GetSetNoCommit_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickCommand SetNoCommit (bool noCommit)
		{
			const string __id = "setNoCommit.(Z)Lorg/eclipse/jgit/api/CherryPickCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noCommit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/method[@name='setOurCommitName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOurCommitName", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CherryPickCommand;", "GetSetOurCommitName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickCommand SetOurCommitName (string ourCommitName)
		{
			const string __id = "setOurCommitName.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CherryPickCommand;";
			IntPtr native_ourCommitName = JNIEnv.NewString ((string)ourCommitName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ourCommitName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_ourCommitName);
			}
		}

		static Delegate cb_setReflogPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReflogPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setReflogPrefix_Ljava_lang_String_ == null)
				cb_setReflogPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetReflogPrefix_Ljava_lang_String_);
			return cb_setReflogPrefix_Ljava_lang_String_;
		}

		static IntPtr n_SetReflogPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReflogPrefix (prefix));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="prefix">including ":"</param>
		/// <summary>Set the prefix to use in the reflog.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/method[@name='setReflogPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setReflogPrefix", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CherryPickCommand;", "GetSetReflogPrefix_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickCommand SetReflogPrefix (string prefix)
		{
			const string __id = "setReflogPrefix.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CherryPickCommand;";
			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStrategy (strategy));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="strategy">The merge strategy to use during this Cherry-pick.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CherryPickCommand']/method[@name='setStrategy' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.merge.MergeStrategy']]"
		[Register ("setStrategy", "(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/CherryPickCommand;", "GetSetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickCommand SetStrategy (global::Org.Eclipse.Jgit.Merge.MergeStrategy strategy)
		{
			const string __id = "setStrategy.(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/CherryPickCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
			}
		}

	}
}
