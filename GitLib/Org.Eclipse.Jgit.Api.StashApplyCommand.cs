using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Command class to apply a stashed commit.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashApplyCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/StashApplyCommand", DoNotGenerateAcw=true)]
	public partial class StashApplyCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Lib.ObjectId> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/StashApplyCommand", typeof (StashApplyCommand));

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

		protected StashApplyCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		/// <summary>Create command to apply the changes of a stashed commit</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashApplyCommand']/constructor[@name='StashApplyCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe StashApplyCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Apply the changes in a stashed commit to the working directory and index</summary>
		/// <returns>id of stashed commit that was applied TODO: Does anyone depend on
		///         this, or could we make it more like Merge/CherryPick/Revert?</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashApplyCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_ignoreRepositoryState_Z;
#pragma warning disable 0169
		static Delegate GetIgnoreRepositoryState_ZHandler ()
		{
			if (cb_ignoreRepositoryState_Z == null)
				cb_ignoreRepositoryState_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_IgnoreRepositoryState_Z);
			return cb_ignoreRepositoryState_Z;
		}

		static IntPtr n_IgnoreRepositoryState_Z (IntPtr jnienv, IntPtr native__this, bool willIgnoreRepositoryState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IgnoreRepositoryState (willIgnoreRepositoryState));
		}
#pragma warning restore 0169

		/// <param name="willIgnoreRepositoryState">willIgnoreRepositoryState</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashApplyCommand']/method[@name='ignoreRepositoryState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("ignoreRepositoryState", "(Z)Lorg/eclipse/jgit/api/StashApplyCommand;", "GetIgnoreRepositoryState_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashApplyCommand IgnoreRepositoryState (bool willIgnoreRepositoryState)
		{
			const string __id = "ignoreRepositoryState.(Z)Lorg/eclipse/jgit/api/StashApplyCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (willIgnoreRepositoryState);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setApplyIndex_Z;
#pragma warning disable 0169
		static Delegate GetSetApplyIndex_ZHandler ()
		{
			if (cb_setApplyIndex_Z == null)
				cb_setApplyIndex_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetApplyIndex_Z);
			return cb_setApplyIndex_Z;
		}

		static void n_SetApplyIndex_Z (IntPtr jnienv, IntPtr native__this, bool applyIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetApplyIndex (applyIndex);
		}
#pragma warning restore 0169

		/// <param name="applyIndex">true (default) if the command should restore the index state</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashApplyCommand']/method[@name='setApplyIndex' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setApplyIndex", "(Z)V", "GetSetApplyIndex_ZHandler")]
		public virtual unsafe void SetApplyIndex (bool applyIndex)
		{
			const string __id = "setApplyIndex.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (applyIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setApplyUntracked_Z;
#pragma warning disable 0169
		static Delegate GetSetApplyUntracked_ZHandler ()
		{
			if (cb_setApplyUntracked_Z == null)
				cb_setApplyUntracked_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetApplyUntracked_Z);
			return cb_setApplyUntracked_Z;
		}

		static void n_SetApplyUntracked_Z (IntPtr jnienv, IntPtr native__this, bool applyUntracked)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetApplyUntracked (applyUntracked);
		}
#pragma warning restore 0169

		/// <param name="applyUntracked">true (default) if the command should restore untracked files</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashApplyCommand']/method[@name='setApplyUntracked' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setApplyUntracked", "(Z)V", "GetSetApplyUntracked_ZHandler")]
		public virtual unsafe void SetApplyUntracked (bool applyUntracked)
		{
			const string __id = "setApplyUntracked.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (applyUntracked);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStashRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStashRef_Ljava_lang_String_Handler ()
		{
			if (cb_setStashRef_Ljava_lang_String_ == null)
				cb_setStashRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetStashRef_Ljava_lang_String_);
			return cb_setStashRef_Ljava_lang_String_;
		}

		static IntPtr n_SetStashRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stashRef)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var stashRef = JNIEnv.GetString (native_stashRef, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStashRef (stashRef));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="stashRef">stashRef</param>
		/// <summary>Set the stash reference to apply</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashApplyCommand']/method[@name='setStashRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setStashRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/StashApplyCommand;", "GetSetStashRef_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashApplyCommand SetStashRef (string stashRef)
		{
			const string __id = "setStashRef.(Ljava/lang/String;)Lorg/eclipse/jgit/api/StashApplyCommand;";
			IntPtr native_stashRef = JNIEnv.NewString ((string)stashRef);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stashRef);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stashRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStrategy (strategy));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="strategy">The merge strategy to use in order to merge during this
		///            command execution.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashApplyCommand']/method[@name='setStrategy' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.merge.MergeStrategy']]"
		[Register ("setStrategy", "(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/StashApplyCommand;", "GetSetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashApplyCommand SetStrategy (global::Org.Eclipse.Jgit.Merge.MergeStrategy strategy)
		{
			const string __id = "setStrategy.(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/StashApplyCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
			}
		}

	}
}
