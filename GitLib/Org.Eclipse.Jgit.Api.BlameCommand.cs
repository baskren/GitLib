using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Blame command for building a <c>BlameResult</c> for a file path.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/BlameCommand", DoNotGenerateAcw=true)]
	public partial class BlameCommand : global::Org.Eclipse.Jgit.Api.GitCommand<Blame.BlameResult> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/BlameCommand", typeof (BlameCommand));

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

		protected BlameCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']/constructor[@name='BlameCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe BlameCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Generate a list of lines with information about when the lines were
		/// introduced into the file path.</summary>
		/// <returns>list of lines</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/blame/BlameResult;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Blame.BlameResult Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/blame/BlameResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetReverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_Handler ()
		{
			if (cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_ == null)
				cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_);
			return cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_;
		}

		static IntPtr n_Reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_start, IntPtr native_end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var start = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_start, JniHandleOwnership.DoNotTransfer);
			var end = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_end, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Reverse (start, end));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="start">oldest commit to traverse from. The result file will be loaded
		///            from this commit's tree.</param>
		/// <param name="end">most recent commits to stop traversal at. Usually an active
		///            branch tip, tag, or HEAD.</param>
		/// <summary>Configure the generator to compute reverse blame (history of deletes).</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']/method[@name='reverse' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("reverse", "(Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/util/Collection;)Lorg/eclipse/jgit/api/BlameCommand;", "GetReverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.BlameCommand Reverse (global::Org.Eclipse.Jgit.Lib.AnyObjectId start, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> end)
		{
			const string __id = "reverse.(Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/util/Collection;)Lorg/eclipse/jgit/api/BlameCommand;";
			IntPtr native_end = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (end);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((start == null) ? IntPtr.Zero : ((global::Java.Lang.Object) start).Handle);
				__args [1] = new JniArgumentValue (native_end);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_end);
				global::System.GC.KeepAlive (start);
				global::System.GC.KeepAlive (end);
			}
		}

		static Delegate cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetReverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_start, IntPtr native_end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var start = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_start, JniHandleOwnership.DoNotTransfer);
			var end = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_end, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Reverse (start, end));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="start">oldest commit to traverse from. The result file will be loaded
		///            from this commit's tree.</param>
		/// <param name="end">most recent commit to stop traversal at. Usually an active
		///            branch tip, tag, or HEAD.</param>
		/// <summary>Configure the command to compute reverse blame (history of deletes).</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']/method[@name='reverse' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("reverse", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/BlameCommand;", "GetReverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.BlameCommand Reverse (global::Org.Eclipse.Jgit.Lib.AnyObjectId start, global::Org.Eclipse.Jgit.Lib.AnyObjectId end)
		{
			const string __id = "reverse.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/BlameCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((start == null) ? IntPtr.Zero : ((global::Java.Lang.Object) start).Handle);
				__args [1] = new JniArgumentValue ((end == null) ? IntPtr.Zero : ((global::Java.Lang.Object) end).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (start);
				global::System.GC.KeepAlive (end);
			}
		}

		static Delegate cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_;
#pragma warning disable 0169
		static Delegate GetSetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_Handler ()
		{
			if (cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ == null)
				cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_);
			return cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_;
		}

		static IntPtr n_SetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ (IntPtr jnienv, IntPtr native__this, IntPtr native_diffAlgorithm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var diffAlgorithm = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm> (native_diffAlgorithm, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDiffAlgorithm (diffAlgorithm));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="diffAlgorithm">diffAlgorithm</param>
		/// <summary>Set diff algorithm</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']/method[@name='setDiffAlgorithm' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffAlgorithm']]"
		[Register ("setDiffAlgorithm", "(Lorg/eclipse/jgit/diff/DiffAlgorithm;)Lorg/eclipse/jgit/api/BlameCommand;", "GetSetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.BlameCommand SetDiffAlgorithm (global::Org.Eclipse.Jgit.Diff.DiffAlgorithm diffAlgorithm)
		{
			const string __id = "setDiffAlgorithm.(Lorg/eclipse/jgit/diff/DiffAlgorithm;)Lorg/eclipse/jgit/api/BlameCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((diffAlgorithm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) diffAlgorithm).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (diffAlgorithm);
			}
		}

		static Delegate cb_setFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setFilePath_Ljava_lang_String_ == null)
				cb_setFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetFilePath_Ljava_lang_String_);
			return cb_setFilePath_Ljava_lang_String_;
		}

		static IntPtr n_SetFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filePath)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filePath = JNIEnv.GetString (native_filePath, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFilePath (filePath));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="filePath">file path (with &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>Set file path.</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']/method[@name='setFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFilePath", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/BlameCommand;", "GetSetFilePath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.BlameCommand SetFilePath (string filePath)
		{
			const string __id = "setFilePath.(Ljava/lang/String;)Lorg/eclipse/jgit/api/BlameCommand;";
			IntPtr native_filePath = JNIEnv.NewString ((string)filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static Delegate cb_setFollowFileRenames_Z;
#pragma warning disable 0169
		static Delegate GetSetFollowFileRenames_ZHandler ()
		{
			if (cb_setFollowFileRenames_Z == null)
				cb_setFollowFileRenames_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetFollowFileRenames_Z);
			return cb_setFollowFileRenames_Z;
		}

		static IntPtr n_SetFollowFileRenames_Z (IntPtr jnienv, IntPtr native__this, bool follow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFollowFileRenames (follow));
		}
#pragma warning restore 0169

		/// <param name="follow">enable following.</param>
		/// <summary>Enable (or disable) following file renames.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']/method[@name='setFollowFileRenames' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFollowFileRenames", "(Z)Lorg/eclipse/jgit/api/BlameCommand;", "GetSetFollowFileRenames_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.BlameCommand SetFollowFileRenames (bool follow)
		{
			const string __id = "setFollowFileRenames.(Z)Lorg/eclipse/jgit/api/BlameCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (follow);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStartCommit_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetStartCommit_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setStartCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setStartCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetStartCommit_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setStartCommit_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_SetStartCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_commit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_commit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStartCommit (commit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="commit">commit</param>
		/// <summary>Set start commit id</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']/method[@name='setStartCommit' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setStartCommit", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/BlameCommand;", "GetSetStartCommit_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.BlameCommand SetStartCommit (global::Org.Eclipse.Jgit.Lib.AnyObjectId commit)
		{
			const string __id = "setStartCommit.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/BlameCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (commit);
			}
		}

		static Delegate cb_setTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_;
#pragma warning disable 0169
		static Delegate GetSetTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_Handler ()
		{
			if (cb_setTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_ == null)
				cb_setTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_);
			return cb_setTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_;
		}

		static IntPtr n_SetTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textComparator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var textComparator = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (native_textComparator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTextComparator (textComparator));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="textComparator">textComparator</param>
		/// <summary>Set raw text comparator</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='BlameCommand']/method[@name='setTextComparator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.RawTextComparator']]"
		[Register ("setTextComparator", "(Lorg/eclipse/jgit/diff/RawTextComparator;)Lorg/eclipse/jgit/api/BlameCommand;", "GetSetTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.BlameCommand SetTextComparator (global::Org.Eclipse.Jgit.Diff.RawTextComparator textComparator)
		{
			const string __id = "setTextComparator.(Lorg/eclipse/jgit/diff/RawTextComparator;)Lorg/eclipse/jgit/api/BlameCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((textComparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textComparator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (textComparator);
			}
		}

	}
}
