using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>Status</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StatusCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/StatusCommand", DoNotGenerateAcw=true)]
	public partial class StatusCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Api.Status> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/StatusCommand", typeof (StatusCommand));

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

		protected StatusCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StatusCommand']/constructor[@name='StatusCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe StatusCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getPaths;
#pragma warning disable 0169
		static Delegate GetGetPathsHandler ()
		{
			if (cb_getPaths == null)
				cb_getPaths = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPaths);
			return cb_getPaths;
		}

		static IntPtr n_GetPaths (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Paths);
		}
#pragma warning restore 0169

		/// <summary>Returns the paths filtering this status.</summary>
		/// <returns>the paths for which the status is shown or &lt;code&gt;null&lt;/code&gt; if
		///         the complete status for the whole repo is shown.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> Paths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StatusCommand']/method[@name='getPaths' and count(parameter)=0]"
			[Register ("getPaths", "()Ljava/util/List;", "GetGetPathsHandler")]
			get {
				const string __id = "getPaths.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddPath_Ljava_lang_String_Handler ()
		{
			if (cb_addPath_Ljava_lang_String_ == null)
				cb_addPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddPath_Ljava_lang_String_);
			return cb_addPath_Ljava_lang_String_;
		}

		static IntPtr n_AddPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPath (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">repository-relative path of file/directory to show status for
		///            (with &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>Show only the status of files which match the given paths.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StatusCommand']/method[@name='addPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPath", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/StatusCommand;", "GetAddPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StatusCommand AddPath (string path)
		{
			const string __id = "addPath.(Ljava/lang/String;)Lorg/eclipse/jgit/api/StatusCommand;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Status</c> command with all the options and parameters
		/// collected by the setter methods of this class.</summary>
		/// <returns>a <c>Status</c> object telling about each path where working
		///         tree, index or HEAD differ from each other.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StatusCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/api/Status;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Api.Status Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/api/Status;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIgnoreSubmodules_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_;
#pragma warning disable 0169
		static Delegate GetSetIgnoreSubmodules_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_Handler ()
		{
			if (cb_setIgnoreSubmodules_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_ == null)
				cb_setIgnoreSubmodules_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetIgnoreSubmodules_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_);
			return cb_setIgnoreSubmodules_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_;
		}

		static IntPtr n_SetIgnoreSubmodules_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIgnoreSubmodules (mode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StatusCommand']/method[@name='setIgnoreSubmodules' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.submodule.SubmoduleWalk.IgnoreSubmoduleMode']]"
		[Register ("setIgnoreSubmodules", "(Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;)Lorg/eclipse/jgit/api/StatusCommand;", "GetSetIgnoreSubmodules_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StatusCommand SetIgnoreSubmodules (global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode mode)
		{
			const string __id = "setIgnoreSubmodules.(Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;)Lorg/eclipse/jgit/api/StatusCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mode);
			}
		}

		static Delegate cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_progressMonitor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var progressMonitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_progressMonitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (progressMonitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="progressMonitor">progressMonitor</param>
		/// <summary>To set the <c>ProgressMonitor</c> which contains callback methods to
		/// inform you about the progress of this command.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StatusCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/StatusCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StatusCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor progressMonitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/StatusCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((progressMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressMonitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (progressMonitor);
			}
		}

		static Delegate cb_setWorkingTreeIt_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_;
#pragma warning disable 0169
		static Delegate GetSetWorkingTreeIt_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Handler ()
		{
			if (cb_setWorkingTreeIt_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ == null)
				cb_setWorkingTreeIt_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetWorkingTreeIt_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_);
			return cb_setWorkingTreeIt_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_;
		}

		static IntPtr n_SetWorkingTreeIt_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_workingTreeIt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var workingTreeIt = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (native_workingTreeIt, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetWorkingTreeIt (workingTreeIt));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="workingTreeIt">a working tree iterator</param>
		/// <summary>To set the <c>WorkingTreeIterator</c> which should be used.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StatusCommand']/method[@name='setWorkingTreeIt' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator']]"
		[Register ("setWorkingTreeIt", "(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)Lorg/eclipse/jgit/api/StatusCommand;", "GetSetWorkingTreeIt_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StatusCommand SetWorkingTreeIt (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator workingTreeIt)
		{
			const string __id = "setWorkingTreeIt.(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)Lorg/eclipse/jgit/api/StatusCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((workingTreeIt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) workingTreeIt).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (workingTreeIt);
			}
		}

	}
}
