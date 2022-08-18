using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>Add</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/AddCommand", DoNotGenerateAcw=true)]
	public partial class AddCommand : global::Org.Eclipse.Jgit.Api.GitCommand<Dircache.DirCache> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/AddCommand", typeof (AddCommand));

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

		protected AddCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddCommand']/constructor[@name='AddCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe AddCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isUpdate;
#pragma warning disable 0169
		static Delegate GetIsUpdateHandler ()
		{
			if (cb_isUpdate == null)
				cb_isUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUpdate);
			return cb_isUpdate;
		}

		static bool n_IsUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUpdate;
		}
#pragma warning restore 0169

		/// <returns>is the parameter update is set</returns>
		public virtual unsafe bool IsUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddCommand']/method[@name='isUpdate' and count(parameter)=0]"
			[Register ("isUpdate", "()Z", "GetIsUpdateHandler")]
			get {
				const string __id = "isUpdate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addFilepattern_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddFilepattern_Ljava_lang_String_Handler ()
		{
			if (cb_addFilepattern_Ljava_lang_String_ == null)
				cb_addFilepattern_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddFilepattern_Ljava_lang_String_);
			return cb_addFilepattern_Ljava_lang_String_;
		}

		static IntPtr n_AddFilepattern_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filepattern)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filepattern = JNIEnv.GetString (native_filepattern, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddFilepattern (filepattern));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="filepattern">repository-relative path of file/directory to add (with
		///            &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>Add a path to a file/directory whose content should be added.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddCommand']/method[@name='addFilepattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addFilepattern", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/AddCommand;", "GetAddFilepattern_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.AddCommand AddFilepattern (string filepattern)
		{
			const string __id = "addFilepattern.(Ljava/lang/String;)Lorg/eclipse/jgit/api/AddCommand;";
			IntPtr native_filepattern = JNIEnv.NewString ((string)filepattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filepattern);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filepattern);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Add</c> command.</summary>
		/// <returns>the DirCache after Add</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/dircache/DirCache;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Dircache.DirCache Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUpdate_Z;
#pragma warning disable 0169
		static Delegate GetSetUpdate_ZHandler ()
		{
			if (cb_setUpdate_Z == null)
				cb_setUpdate_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetUpdate_Z);
			return cb_setUpdate_Z;
		}

		static IntPtr n_SetUpdate_Z (IntPtr jnienv, IntPtr native__this, bool update)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetUpdate (update));
		}
#pragma warning restore 0169

		/// <param name="update">If set to true, the command only matches <c>filepattern</c>
		///            against already tracked files in the index rather than the
		///            working tree. That means that it will never stage new files,
		///            but that it will stage modified new contents of tracked files
		///            and that it will remove files from the index if the
		///            corresponding files in the working tree have been removed.
		///            In contrast to the git command line a <c>filepattern</c> must
		///            exist also if update is set to true as there is no
		///            concept of a working directory here.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddCommand']/method[@name='setUpdate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUpdate", "(Z)Lorg/eclipse/jgit/api/AddCommand;", "GetSetUpdate_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.AddCommand SetUpdate (bool update)
		{
			const string __id = "setUpdate.(Z)Lorg/eclipse/jgit/api/AddCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (update);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_;
#pragma warning disable 0169
		static Delegate GetSetWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Handler ()
		{
			if (cb_setWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ == null)
				cb_setWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_);
			return cb_setWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_;
		}

		static IntPtr n_SetWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (native_f, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetWorkingTreeIterator (f));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="f">f</param>
		/// <summary>Allow clients to provide their own implementation of a FileTreeIterator</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddCommand']/method[@name='setWorkingTreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator']]"
		[Register ("setWorkingTreeIterator", "(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)Lorg/eclipse/jgit/api/AddCommand;", "GetSetWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.AddCommand SetWorkingTreeIterator (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator f)
		{
			const string __id = "setWorkingTreeIterator.(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)Lorg/eclipse/jgit/api/AddCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

	}
}
