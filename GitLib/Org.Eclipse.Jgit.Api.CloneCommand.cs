using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Clone a repository into a new working directory</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/CloneCommand", DoNotGenerateAcw=true)]
	public partial class CloneCommand : global::Org.Eclipse.Jgit.Api.TransportCommand<Git> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CloneCommand", typeof (CloneCommand));

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

		protected CloneCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create clone command with no repository set</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/constructor[@name='CloneCommand' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CloneCommand () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Clone</c> command.</summary>
		/// <returns>the newly created <c>Git</c> object with associated repository</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/api/Git;", "GetCallHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.Git Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/api/Git;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBare_Z;
#pragma warning disable 0169
		static Delegate GetSetBare_ZHandler ()
		{
			if (cb_setBare_Z == null)
				cb_setBare_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetBare_Z);
			return cb_setBare_Z;
		}

		static IntPtr n_SetBare_Z (IntPtr jnienv, IntPtr native__this, bool bare)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBare (bare));
		}
#pragma warning restore 0169

		/// <param name="bare">whether the cloned repository is bare or not</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setBare' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setBare", "(Z)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetBare_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetBare (bool bare)
		{
			const string __id = "setBare.(Z)Lorg/eclipse/jgit/api/CloneCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bare);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBranch_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBranch_Ljava_lang_String_Handler ()
		{
			if (cb_setBranch_Ljava_lang_String_ == null)
				cb_setBranch_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetBranch_Ljava_lang_String_);
			return cb_setBranch_Ljava_lang_String_;
		}

		static IntPtr n_SetBranch_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_branch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var branch = JNIEnv.GetString (native_branch, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBranch (branch));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="branch">the initial branch to check out when cloning the repository.
		///            Can be specified as ref name (&lt;code&gt;refs/heads/master&lt;/code&gt;),
		///            branch name (&lt;code&gt;master&lt;/code&gt;) or tag name (&lt;code&gt;v1.2.3&lt;/code&gt;).</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setBranch' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBranch", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetBranch_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetBranch (string branch)
		{
			const string __id = "setBranch.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CloneCommand;";
			IntPtr native_branch = JNIEnv.NewString ((string)branch);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_branch);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_branch);
			}
		}

		static Delegate cb_setBranchesToClone_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetBranchesToClone_Ljava_util_Collection_Handler ()
		{
			if (cb_setBranchesToClone_Ljava_util_Collection_ == null)
				cb_setBranchesToClone_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetBranchesToClone_Ljava_util_Collection_);
			return cb_setBranchesToClone_Ljava_util_Collection_;
		}

		static IntPtr n_SetBranchesToClone_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_branchesToClone)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var branchesToClone = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_branchesToClone, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBranchesToClone (branchesToClone));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="branchesToClone">collection of branches to clone. Ignored when allSelected is
		///            true. Must be specified as full ref names (e.g.
		///            &lt;code&gt;refs/heads/master&lt;/code&gt;).</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setBranchesToClone' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("setBranchesToClone", "(Ljava/util/Collection;)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetBranchesToClone_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetBranchesToClone (global::System.Collections.Generic.ICollection<string> branchesToClone)
		{
			const string __id = "setBranchesToClone.(Ljava/util/Collection;)Lorg/eclipse/jgit/api/CloneCommand;";
			IntPtr native_branchesToClone = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (branchesToClone);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_branchesToClone);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_branchesToClone);
				global::System.GC.KeepAlive (branchesToClone);
			}
		}

		static Delegate cb_setCloneAllBranches_Z;
#pragma warning disable 0169
		static Delegate GetSetCloneAllBranches_ZHandler ()
		{
			if (cb_setCloneAllBranches_Z == null)
				cb_setCloneAllBranches_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCloneAllBranches_Z);
			return cb_setCloneAllBranches_Z;
		}

		static IntPtr n_SetCloneAllBranches_Z (IntPtr jnienv, IntPtr native__this, bool cloneAllBranches)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCloneAllBranches (cloneAllBranches));
		}
#pragma warning restore 0169

		/// <param name="cloneAllBranches">true when all branches have to be fetched (indicates wildcard
		///            in created fetch refspec), false otherwise.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setCloneAllBranches' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCloneAllBranches", "(Z)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetCloneAllBranches_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetCloneAllBranches (bool cloneAllBranches)
		{
			const string __id = "setCloneAllBranches.(Z)Lorg/eclipse/jgit/api/CloneCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cloneAllBranches);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCloneSubmodules_Z;
#pragma warning disable 0169
		static Delegate GetSetCloneSubmodules_ZHandler ()
		{
			if (cb_setCloneSubmodules_Z == null)
				cb_setCloneSubmodules_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCloneSubmodules_Z);
			return cb_setCloneSubmodules_Z;
		}

		static IntPtr n_SetCloneSubmodules_Z (IntPtr jnienv, IntPtr native__this, bool cloneSubmodules)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCloneSubmodules (cloneSubmodules));
		}
#pragma warning restore 0169

		/// <param name="cloneSubmodules">true to initialize and update submodules. Ignored when
		///            <c>#setBare(boolean)</c> is set to true.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setCloneSubmodules' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCloneSubmodules", "(Z)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetCloneSubmodules_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetCloneSubmodules (bool cloneSubmodules)
		{
			const string __id = "setCloneSubmodules.(Z)Lorg/eclipse/jgit/api/CloneCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cloneSubmodules);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDirectory_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetDirectory_Ljava_io_File_Handler ()
		{
			if (cb_setDirectory_Ljava_io_File_ == null)
				cb_setDirectory_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDirectory_Ljava_io_File_);
			return cb_setDirectory_Ljava_io_File_;
		}

		static IntPtr n_SetDirectory_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_directory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var directory = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_directory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDirectory (directory));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="directory">the directory to clone to</param>
		/// <summary>The optional directory associated with the clone operation.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setDirectory", "(Ljava/io/File;)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetDirectory_Ljava_io_File_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetDirectory (global::Java.IO.File directory)
		{
			const string __id = "setDirectory.(Ljava/io/File;)Lorg/eclipse/jgit/api/CloneCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (directory);
			}
		}

		static Delegate cb_setGitDir_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetGitDir_Ljava_io_File_Handler ()
		{
			if (cb_setGitDir_Ljava_io_File_ == null)
				cb_setGitDir_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetGitDir_Ljava_io_File_);
			return cb_setGitDir_Ljava_io_File_;
		}

		static IntPtr n_SetGitDir_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gitDir)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gitDir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_gitDir, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGitDir (gitDir));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="gitDir">the repository meta directory</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setGitDir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setGitDir", "(Ljava/io/File;)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetGitDir_Ljava_io_File_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetGitDir (global::Java.IO.File gitDir)
		{
			const string __id = "setGitDir.(Ljava/io/File;)Lorg/eclipse/jgit/api/CloneCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gitDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gitDir).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (gitDir);
			}
		}

		static Delegate cb_setNoCheckout_Z;
#pragma warning disable 0169
		static Delegate GetSetNoCheckout_ZHandler ()
		{
			if (cb_setNoCheckout_Z == null)
				cb_setNoCheckout_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetNoCheckout_Z);
			return cb_setNoCheckout_Z;
		}

		static IntPtr n_SetNoCheckout_Z (IntPtr jnienv, IntPtr native__this, bool noCheckout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNoCheckout (noCheckout));
		}
#pragma warning restore 0169

		/// <param name="noCheckout">if set to &lt;code&gt;true&lt;/code&gt; no branch will be checked out
		///            after the clone. This enhances performance of the clone
		///            command when there is no need for a checked out branch.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setNoCheckout' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNoCheckout", "(Z)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetNoCheckout_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetNoCheckout (bool noCheckout)
		{
			const string __id = "setNoCheckout.(Z)Lorg/eclipse/jgit/api/CloneCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noCheckout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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

		static IntPtr n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (monitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">monitor</param>
		/// <summary>The progress monitor associated with the clone operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/CloneCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (monitor);
			}
		}

		static Delegate cb_setRemote_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRemote_Ljava_lang_String_Handler ()
		{
			if (cb_setRemote_Ljava_lang_String_ == null)
				cb_setRemote_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRemote_Ljava_lang_String_);
			return cb_setRemote_Ljava_lang_String_;
		}

		static IntPtr n_SetRemote_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remote)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var remote = JNIEnv.GetString (native_remote, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRemote (remote));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="remote">name that keeps track of the upstream repository</param>
		/// <summary>The remote name used to keep track of the upstream repository for the
		/// clone operation.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setRemote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRemote", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetRemote_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetRemote (string remote)
		{
			const string __id = "setRemote.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CloneCommand;";
			IntPtr native_remote = JNIEnv.NewString ((string)remote);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_remote);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remote);
			}
		}

		static Delegate cb_setURI_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetURI_Ljava_lang_String_Handler ()
		{
			if (cb_setURI_Ljava_lang_String_ == null)
				cb_setURI_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetURI_Ljava_lang_String_);
			return cb_setURI_Ljava_lang_String_;
		}

		static IntPtr n_SetURI_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetURI (uri));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uri">the uri to clone from</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CloneCommand']/method[@name='setURI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setURI", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CloneCommand;", "GetSetURI_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CloneCommand SetURI (string uri)
		{
			const string __id = "setURI.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CloneCommand;";
			IntPtr native_uri = JNIEnv.NewString ((string)uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

	}
}
