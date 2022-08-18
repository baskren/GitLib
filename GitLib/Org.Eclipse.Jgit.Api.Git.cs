using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Offers a "GitPorcelain"-like API to interact with a git repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/Git", DoNotGenerateAcw=true)]
	public partial class Git : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/Git", typeof (Git));

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

		protected Git (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">the git repository this class is interacting with.
		///            <c>null</c> is not allowed</param>
		/// <summary>Constructs a new <c>Git</c> object which can interact with the specified
		/// git repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/constructor[@name='Git' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe Git (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getRepository;
#pragma warning disable 0169
		static Delegate GetGetRepositoryHandler ()
		{
			if (cb_getRepository == null)
				cb_getRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepository);
			return cb_getRepository;
		}

		static IntPtr n_GetRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		/// <returns>the git repository this class is interacting with</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "GetGetRepositoryHandler")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/lib/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add;
#pragma warning disable 0169
		static Delegate GetAddHandler ()
		{
			if (cb_add == null)
				cb_add = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Add);
			return cb_add;
		}

		static IntPtr n_Add (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Add ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>Add</c> command</summary>
		/// <returns>a <c>AddCommand</c> used to collect all optional parameters and
		///         to finally execute the <c>Add</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='add' and count(parameter)=0]"
		[Register ("add", "()Lorg/eclipse/jgit/api/AddCommand;", "GetAddHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.AddCommand Add ()
		{
			const string __id = "add.()Lorg/eclipse/jgit/api/AddCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_apply;
#pragma warning disable 0169
		static Delegate GetApplyHandler ()
		{
			if (cb_apply == null)
				cb_apply = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Apply);
			return cb_apply;
		}

		static IntPtr n_Apply (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>apply</c> command</summary>
		/// <returns>a <c>ApplyCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>apply</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='apply' and count(parameter)=0]"
		[Register ("apply", "()Lorg/eclipse/jgit/api/ApplyCommand;", "GetApplyHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ApplyCommand Apply ()
		{
			const string __id = "apply.()Lorg/eclipse/jgit/api/ApplyCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ApplyCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_archive;
#pragma warning disable 0169
		static Delegate GetArchiveHandler ()
		{
			if (cb_archive == null)
				cb_archive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Archive);
			return cb_archive;
		}

		static IntPtr n_Archive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Archive ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command to create an archive from a tree</summary>
		/// <returns>a <c>ArchiveCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='archive' and count(parameter)=0]"
		[Register ("archive", "()Lorg/eclipse/jgit/api/ArchiveCommand;", "GetArchiveHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ArchiveCommand Archive ()
		{
			const string __id = "archive.()Lorg/eclipse/jgit/api/ArchiveCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_blame;
#pragma warning disable 0169
		static Delegate GetBlameHandler ()
		{
			if (cb_blame == null)
				cb_blame = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Blame);
			return cb_blame;
		}

		static IntPtr n_Blame (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Blame ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>blame</c> command</summary>
		/// <returns>a <c>BlameCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>blame</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='blame' and count(parameter)=0]"
		[Register ("blame", "()Lorg/eclipse/jgit/api/BlameCommand;", "GetBlameHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.BlameCommand Blame ()
		{
			const string __id = "blame.()Lorg/eclipse/jgit/api/BlameCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.BlameCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_branchCreate;
#pragma warning disable 0169
		static Delegate GetBranchCreateHandler ()
		{
			if (cb_branchCreate == null)
				cb_branchCreate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_BranchCreate);
			return cb_branchCreate;
		}

		static IntPtr n_BranchCreate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BranchCreate ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to create branches</summary>
		/// <returns>a <c>CreateBranchCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='branchCreate' and count(parameter)=0]"
		[Register ("branchCreate", "()Lorg/eclipse/jgit/api/CreateBranchCommand;", "GetBranchCreateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CreateBranchCommand BranchCreate ()
		{
			const string __id = "branchCreate.()Lorg/eclipse/jgit/api/CreateBranchCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_branchDelete;
#pragma warning disable 0169
		static Delegate GetBranchDeleteHandler ()
		{
			if (cb_branchDelete == null)
				cb_branchDelete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_BranchDelete);
			return cb_branchDelete;
		}

		static IntPtr n_BranchDelete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BranchDelete ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to delete branches</summary>
		/// <returns>a <c>DeleteBranchCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='branchDelete' and count(parameter)=0]"
		[Register ("branchDelete", "()Lorg/eclipse/jgit/api/DeleteBranchCommand;", "GetBranchDeleteHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DeleteBranchCommand BranchDelete ()
		{
			const string __id = "branchDelete.()Lorg/eclipse/jgit/api/DeleteBranchCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_branchList;
#pragma warning disable 0169
		static Delegate GetBranchListHandler ()
		{
			if (cb_branchList == null)
				cb_branchList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_BranchList);
			return cb_branchList;
		}

		static IntPtr n_BranchList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BranchList ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to list branches</summary>
		/// <returns>a <c>ListBranchCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='branchList' and count(parameter)=0]"
		[Register ("branchList", "()Lorg/eclipse/jgit/api/ListBranchCommand;", "GetBranchListHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ListBranchCommand BranchList ()
		{
			const string __id = "branchList.()Lorg/eclipse/jgit/api/ListBranchCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_branchRename;
#pragma warning disable 0169
		static Delegate GetBranchRenameHandler ()
		{
			if (cb_branchRename == null)
				cb_branchRename = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_BranchRename);
			return cb_branchRename;
		}

		static IntPtr n_BranchRename (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BranchRename ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to rename branches</summary>
		/// <returns>a <c>RenameBranchCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='branchRename' and count(parameter)=0]"
		[Register ("branchRename", "()Lorg/eclipse/jgit/api/RenameBranchCommand;", "GetBranchRenameHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RenameBranchCommand BranchRename ()
		{
			const string __id = "branchRename.()Lorg/eclipse/jgit/api/RenameBranchCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RenameBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_checkout;
#pragma warning disable 0169
		static Delegate GetCheckoutHandler ()
		{
			if (cb_checkout == null)
				cb_checkout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Checkout);
			return cb_checkout;
		}

		static IntPtr n_Checkout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Checkout ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>checkout</c> command</summary>
		/// <returns>a <c>CheckoutCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>checkout</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='checkout' and count(parameter)=0]"
		[Register ("checkout", "()Lorg/eclipse/jgit/api/CheckoutCommand;", "GetCheckoutHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand Checkout ()
		{
			const string __id = "checkout.()Lorg/eclipse/jgit/api/CheckoutCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cherryPick;
#pragma warning disable 0169
		static Delegate GetCherryPickHandler ()
		{
			if (cb_cherryPick == null)
				cb_cherryPick = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CherryPick);
			return cb_cherryPick;
		}

		static IntPtr n_CherryPick (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CherryPick ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>cherry-pick</c> command</summary>
		/// <returns>a <c>CherryPickCommand</c> used to collect all optional
		///         parameters and to finally execute the <c>cherry-pick</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='cherryPick' and count(parameter)=0]"
		[Register ("cherryPick", "()Lorg/eclipse/jgit/api/CherryPickCommand;", "GetCherryPickHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CherryPickCommand CherryPick ()
		{
			const string __id = "cherryPick.()Lorg/eclipse/jgit/api/CherryPickCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CherryPickCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clean;
#pragma warning disable 0169
		static Delegate GetCleanHandler ()
		{
			if (cb_clean == null)
				cb_clean = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clean);
			return cb_clean;
		}

		static IntPtr n_Clean (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clean ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>clean</c> command</summary>
		/// <returns>a <c>CleanCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>clean</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='clean' and count(parameter)=0]"
		[Register ("clean", "()Lorg/eclipse/jgit/api/CleanCommand;", "GetCleanHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CleanCommand Clean ()
		{
			const string __id = "clean.()Lorg/eclipse/jgit/api/CleanCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Returns a command object to execute a <c>clone</c> command</summary>
		/// <returns>a <c>CloneCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>clone</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='cloneRepository' and count(parameter)=0]"
		[Register ("cloneRepository", "()Lorg/eclipse/jgit/api/CloneCommand;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Api.CloneCommand CloneRepository ()
		{
			const string __id = "cloneRepository.()Lorg/eclipse/jgit/api/CloneCommand;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CloneCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		/// <summary>Frees resources held by the underlying <c>Repository</c> instance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_commit;
#pragma warning disable 0169
		static Delegate GetCommitHandler ()
		{
			if (cb_commit == null)
				cb_commit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Commit);
			return cb_commit;
		}

		static IntPtr n_Commit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Commit ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>Commit</c> command</summary>
		/// <returns>a <c>CommitCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>Commit</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='commit' and count(parameter)=0]"
		[Register ("commit", "()Lorg/eclipse/jgit/api/CommitCommand;", "GetCommitHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand Commit ()
		{
			const string __id = "commit.()Lorg/eclipse/jgit/api/CommitCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_describe;
#pragma warning disable 0169
		static Delegate GetDescribeHandler ()
		{
			if (cb_describe == null)
				cb_describe = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Describe);
			return cb_describe;
		}

		static IntPtr n_Describe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Describe ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to come up with a short name that describes a
		/// commit in terms of the nearest git tag.</summary>
		/// <returns>a <c>DescribeCommand</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='describe' and count(parameter)=0]"
		[Register ("describe", "()Lorg/eclipse/jgit/api/DescribeCommand;", "GetDescribeHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DescribeCommand Describe ()
		{
			const string __id = "describe.()Lorg/eclipse/jgit/api/DescribeCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DescribeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_diff;
#pragma warning disable 0169
		static Delegate GetDiffHandler ()
		{
			if (cb_diff == null)
				cb_diff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Diff);
			return cb_diff;
		}

		static IntPtr n_Diff (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Diff ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>diff</c> command</summary>
		/// <returns>a <c>DiffCommand</c> used to collect all optional parameters and
		///         to finally execute the <c>diff</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='diff' and count(parameter)=0]"
		[Register ("diff", "()Lorg/eclipse/jgit/api/DiffCommand;", "GetDiffHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand Diff ()
		{
			const string __id = "diff.()Lorg/eclipse/jgit/api/DiffCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fetch;
#pragma warning disable 0169
		static Delegate GetFetchHandler ()
		{
			if (cb_fetch == null)
				cb_fetch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Fetch);
			return cb_fetch;
		}

		static IntPtr n_Fetch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fetch ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>Fetch</c> command</summary>
		/// <returns>a <c>FetchCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>Fetch</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='fetch' and count(parameter)=0]"
		[Register ("fetch", "()Lorg/eclipse/jgit/api/FetchCommand;", "GetFetchHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand Fetch ()
		{
			const string __id = "fetch.()Lorg/eclipse/jgit/api/FetchCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_gc;
#pragma warning disable 0169
		static Delegate GetGcHandler ()
		{
			if (cb_gc == null)
				cb_gc = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Gc);
			return cb_gc;
		}

		static IntPtr n_Gc (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Gc ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>gc</c> command</summary>
		/// <returns>a <c>GarbageCollectCommand</c> used to collect all optional
		///         parameters and to finally execute the <c>gc</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='gc' and count(parameter)=0]"
		[Register ("gc", "()Lorg/eclipse/jgit/api/GarbageCollectCommand;", "GetGcHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.GarbageCollectCommand Gc ()
		{
			const string __id = "gc.()Lorg/eclipse/jgit/api/GarbageCollectCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GarbageCollectCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Returns a command object to execute a <c>init</c> command</summary>
		/// <returns>a <c>InitCommand</c> used to collect all optional parameters and
		///         to finally execute the <c>init</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()Lorg/eclipse/jgit/api/InitCommand;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Api.InitCommand Init ()
		{
			const string __id = "init.()Lorg/eclipse/jgit/api/InitCommand;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.InitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_log;
#pragma warning disable 0169
		static Delegate GetLogHandler ()
		{
			if (cb_log == null)
				cb_log = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Log);
			return cb_log;
		}

		static IntPtr n_Log (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Log ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>Log</c> command</summary>
		/// <returns>a <c>LogCommand</c> used to collect all optional parameters and
		///         to finally execute the <c>Log</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='log' and count(parameter)=0]"
		[Register ("log", "()Lorg/eclipse/jgit/api/LogCommand;", "GetLogHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LogCommand Log ()
		{
			const string __id = "log.()Lorg/eclipse/jgit/api/LogCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_lsRemote;
#pragma warning disable 0169
		static Delegate GetLsRemoteHandler ()
		{
			if (cb_lsRemote == null)
				cb_lsRemote = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LsRemote);
			return cb_lsRemote;
		}

		static IntPtr n_LsRemote (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LsRemote ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>ls-remote</c> command</summary>
		/// <returns>a <c>LsRemoteCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>status</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='lsRemote' and count(parameter)=0]"
		[Register ("lsRemote", "()Lorg/eclipse/jgit/api/LsRemoteCommand;", "GetLsRemoteHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LsRemoteCommand LsRemote ()
		{
			const string __id = "lsRemote.()Lorg/eclipse/jgit/api/LsRemoteCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Returns a command to list remote branches/tags without a local
		/// repository.</summary>
		/// <returns>a <c>LsRemoteCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='lsRemoteRepository' and count(parameter)=0]"
		[Register ("lsRemoteRepository", "()Lorg/eclipse/jgit/api/LsRemoteCommand;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Api.LsRemoteCommand LsRemoteRepository ()
		{
			const string __id = "lsRemoteRepository.()Lorg/eclipse/jgit/api/LsRemoteCommand;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LsRemoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_merge;
#pragma warning disable 0169
		static Delegate GetMergeHandler ()
		{
			if (cb_merge == null)
				cb_merge = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Merge);
			return cb_merge;
		}

		static IntPtr n_Merge (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Merge ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>Merge</c> command</summary>
		/// <returns>a <c>MergeCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>Merge</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='merge' and count(parameter)=0]"
		[Register ("merge", "()Lorg/eclipse/jgit/api/MergeCommand;", "GetMergeHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand Merge ()
		{
			const string __id = "merge.()Lorg/eclipse/jgit/api/MergeCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nameRev;
#pragma warning disable 0169
		static Delegate GetNameRevHandler ()
		{
			if (cb_nameRev == null)
				cb_nameRev = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NameRev);
			return cb_nameRev;
		}

		static IntPtr n_NameRev (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NameRev ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to find human-readable names of revisions.</summary>
		/// <returns>a <c>NameRevCommand</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='nameRev' and count(parameter)=0]"
		[Register ("nameRev", "()Lorg/eclipse/jgit/api/NameRevCommand;", "GetNameRevHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.NameRevCommand NameRev ()
		{
			const string __id = "nameRev.()Lorg/eclipse/jgit/api/NameRevCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notesAdd;
#pragma warning disable 0169
		static Delegate GetNotesAddHandler ()
		{
			if (cb_notesAdd == null)
				cb_notesAdd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NotesAdd);
			return cb_notesAdd;
		}

		static IntPtr n_NotesAdd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotesAdd ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command to add notes to an object</summary>
		/// <returns>a <c>AddNoteCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='notesAdd' and count(parameter)=0]"
		[Register ("notesAdd", "()Lorg/eclipse/jgit/api/AddNoteCommand;", "GetNotesAddHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.AddNoteCommand NotesAdd ()
		{
			const string __id = "notesAdd.()Lorg/eclipse/jgit/api/AddNoteCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddNoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notesList;
#pragma warning disable 0169
		static Delegate GetNotesListHandler ()
		{
			if (cb_notesList == null)
				cb_notesList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NotesList);
			return cb_notesList;
		}

		static IntPtr n_NotesList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotesList ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command to list all notes</summary>
		/// <returns>a <c>ListNotesCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='notesList' and count(parameter)=0]"
		[Register ("notesList", "()Lorg/eclipse/jgit/api/ListNotesCommand;", "GetNotesListHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ListNotesCommand NotesList ()
		{
			const string __id = "notesList.()Lorg/eclipse/jgit/api/ListNotesCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListNotesCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notesRemove;
#pragma warning disable 0169
		static Delegate GetNotesRemoveHandler ()
		{
			if (cb_notesRemove == null)
				cb_notesRemove = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NotesRemove);
			return cb_notesRemove;
		}

		static IntPtr n_NotesRemove (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotesRemove ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command to remove notes on an object</summary>
		/// <returns>a <c>RemoveNoteCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='notesRemove' and count(parameter)=0]"
		[Register ("notesRemove", "()Lorg/eclipse/jgit/api/RemoveNoteCommand;", "GetNotesRemoveHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RemoveNoteCommand NotesRemove ()
		{
			const string __id = "notesRemove.()Lorg/eclipse/jgit/api/RemoveNoteCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RemoveNoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notesShow;
#pragma warning disable 0169
		static Delegate GetNotesShowHandler ()
		{
			if (cb_notesShow == null)
				cb_notesShow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NotesShow);
			return cb_notesShow;
		}

		static IntPtr n_NotesShow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotesShow ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command to show notes on an object</summary>
		/// <returns>a <c>ShowNoteCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='notesShow' and count(parameter)=0]"
		[Register ("notesShow", "()Lorg/eclipse/jgit/api/ShowNoteCommand;", "GetNotesShowHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ShowNoteCommand NotesShow ()
		{
			const string __id = "notesShow.()Lorg/eclipse/jgit/api/ShowNoteCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ShowNoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="dir">the repository to open. May be either the GIT_DIR, or the
		///            working tree directory that contains <c>.git</c>.</param>
		/// <returns>a <c>Git</c> object for the existing git repository</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='open' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("open", "(Ljava/io/File;)Lorg/eclipse/jgit/api/Git;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Api.Git Open (global::Java.IO.File dir)
		{
			const string __id = "open.(Ljava/io/File;)Lorg/eclipse/jgit/api/Git;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (dir);
			}
		}

		/// <param name="dir">the repository to open. May be either the GIT_DIR, or the
		///            working tree directory that contains <c>.git</c>.</param>
		/// <param name="fs">filesystem abstraction to use when accessing the repository.</param>
		/// <returns>a <c>Git</c> object for the existing git repository</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='open' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register ("open", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/api/Git;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Api.Git Open (global::Java.IO.File dir, global::Org.Eclipse.Jgit.Util.FS fs)
		{
			const string __id = "open.(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/api/Git;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (dir);
				global::System.GC.KeepAlive (fs);
			}
		}

		static Delegate cb_pull;
#pragma warning disable 0169
		static Delegate GetPullHandler ()
		{
			if (cb_pull == null)
				cb_pull = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Pull);
			return cb_pull;
		}

		static IntPtr n_Pull (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pull ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>Pull</c> command</summary>
		/// <returns>a <c>PullCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='pull' and count(parameter)=0]"
		[Register ("pull", "()Lorg/eclipse/jgit/api/PullCommand;", "GetPullHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PullCommand Pull ()
		{
			const string __id = "pull.()Lorg/eclipse/jgit/api/PullCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PullCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_push;
#pragma warning disable 0169
		static Delegate GetPushHandler ()
		{
			if (cb_push == null)
				cb_push = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Push);
			return cb_push;
		}

		static IntPtr n_Push (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Push ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>Push</c> command</summary>
		/// <returns>a <c>PushCommand</c> used to collect all optional parameters and
		///         to finally execute the <c>Push</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='push' and count(parameter)=0]"
		[Register ("push", "()Lorg/eclipse/jgit/api/PushCommand;", "GetPushHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand Push ()
		{
			const string __id = "push.()Lorg/eclipse/jgit/api/PushCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rebase;
#pragma warning disable 0169
		static Delegate GetRebaseHandler ()
		{
			if (cb_rebase == null)
				cb_rebase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Rebase);
			return cb_rebase;
		}

		static IntPtr n_Rebase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rebase ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>Rebase</c> command</summary>
		/// <returns>a <c>RebaseCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>rebase</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='rebase' and count(parameter)=0]"
		[Register ("rebase", "()Lorg/eclipse/jgit/api/RebaseCommand;", "GetRebaseHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand Rebase ()
		{
			const string __id = "rebase.()Lorg/eclipse/jgit/api/RebaseCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reflog;
#pragma warning disable 0169
		static Delegate GetReflogHandler ()
		{
			if (cb_reflog == null)
				cb_reflog = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Reflog);
			return cb_reflog;
		}

		static IntPtr n_Reflog (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reflog ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>reflog</c> command</summary>
		/// <returns>a <c>ReflogCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>reflog</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='reflog' and count(parameter)=0]"
		[Register ("reflog", "()Lorg/eclipse/jgit/api/ReflogCommand;", "GetReflogHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ReflogCommand Reflog ()
		{
			const string __id = "reflog.()Lorg/eclipse/jgit/api/ReflogCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ReflogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Reset);
			return cb_reset;
		}

		static IntPtr n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reset ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>reset</c> command</summary>
		/// <returns>a <c>ResetCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>reset</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()Lorg/eclipse/jgit/api/ResetCommand;", "GetResetHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ResetCommand Reset ()
		{
			const string __id = "reset.()Lorg/eclipse/jgit/api/ResetCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ResetCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_revert;
#pragma warning disable 0169
		static Delegate GetRevertHandler ()
		{
			if (cb_revert == null)
				cb_revert = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Revert);
			return cb_revert;
		}

		static IntPtr n_Revert (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Revert ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>revert</c> command</summary>
		/// <returns>a <c>RevertCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>cherry-pick</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='revert' and count(parameter)=0]"
		[Register ("revert", "()Lorg/eclipse/jgit/api/RevertCommand;", "GetRevertHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RevertCommand Revert ()
		{
			const string __id = "revert.()Lorg/eclipse/jgit/api/RevertCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RevertCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rm;
#pragma warning disable 0169
		static Delegate GetRmHandler ()
		{
			if (cb_rm == null)
				cb_rm = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Rm);
			return cb_rm;
		}

		static IntPtr n_Rm (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rm ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>rm</c> command</summary>
		/// <returns>a <c>RmCommand</c> used to collect all optional parameters and
		///         to finally execute the <c>rm</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='rm' and count(parameter)=0]"
		[Register ("rm", "()Lorg/eclipse/jgit/api/RmCommand;", "GetRmHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RmCommand Rm ()
		{
			const string __id = "rm.()Lorg/eclipse/jgit/api/RmCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RmCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stashApply;
#pragma warning disable 0169
		static Delegate GetStashApplyHandler ()
		{
			if (cb_stashApply == null)
				cb_stashApply = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_StashApply);
			return cb_stashApply;
		}

		static IntPtr n_StashApply (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StashApply ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to apply a stashed commit</summary>
		/// <returns>a <c>StashApplyCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='stashApply' and count(parameter)=0]"
		[Register ("stashApply", "()Lorg/eclipse/jgit/api/StashApplyCommand;", "GetStashApplyHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashApplyCommand StashApply ()
		{
			const string __id = "stashApply.()Lorg/eclipse/jgit/api/StashApplyCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashApplyCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stashCreate;
#pragma warning disable 0169
		static Delegate GetStashCreateHandler ()
		{
			if (cb_stashCreate == null)
				cb_stashCreate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_StashCreate);
			return cb_stashCreate;
		}

		static IntPtr n_StashCreate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StashCreate ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to create a stashed commit</summary>
		/// <returns>a <c>StashCreateCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='stashCreate' and count(parameter)=0]"
		[Register ("stashCreate", "()Lorg/eclipse/jgit/api/StashCreateCommand;", "GetStashCreateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashCreateCommand StashCreate ()
		{
			const string __id = "stashCreate.()Lorg/eclipse/jgit/api/StashCreateCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stashDrop;
#pragma warning disable 0169
		static Delegate GetStashDropHandler ()
		{
			if (cb_stashDrop == null)
				cb_stashDrop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_StashDrop);
			return cb_stashDrop;
		}

		static IntPtr n_StashDrop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StashDrop ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to drop a stashed commit</summary>
		/// <returns>a <c>StashDropCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='stashDrop' and count(parameter)=0]"
		[Register ("stashDrop", "()Lorg/eclipse/jgit/api/StashDropCommand;", "GetStashDropHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashDropCommand StashDrop ()
		{
			const string __id = "stashDrop.()Lorg/eclipse/jgit/api/StashDropCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashDropCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stashList;
#pragma warning disable 0169
		static Delegate GetStashListHandler ()
		{
			if (cb_stashList == null)
				cb_stashList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_StashList);
			return cb_stashList;
		}

		static IntPtr n_StashList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StashList ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to list stashed commits</summary>
		/// <returns>a <c>StashListCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='stashList' and count(parameter)=0]"
		[Register ("stashList", "()Lorg/eclipse/jgit/api/StashListCommand;", "GetStashListHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashListCommand StashList ()
		{
			const string __id = "stashList.()Lorg/eclipse/jgit/api/StashListCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashListCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_status;
#pragma warning disable 0169
		static Delegate GetStatusHandler ()
		{
			if (cb_status == null)
				cb_status = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Status);
			return cb_status;
		}

		static IntPtr n_Status (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>status</c> command</summary>
		/// <returns>a <c>StatusCommand</c> used to collect all optional parameters
		///         and to finally execute the <c>status</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='status' and count(parameter)=0]"
		[Register ("status", "()Lorg/eclipse/jgit/api/StatusCommand;", "GetStatusHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StatusCommand Status ()
		{
			const string __id = "status.()Lorg/eclipse/jgit/api/StatusCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StatusCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_submoduleAdd;
#pragma warning disable 0169
		static Delegate GetSubmoduleAddHandler ()
		{
			if (cb_submoduleAdd == null)
				cb_submoduleAdd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SubmoduleAdd);
			return cb_submoduleAdd;
		}

		static IntPtr n_SubmoduleAdd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubmoduleAdd ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>submodule add</c> command</summary>
		/// <returns>a <c>SubmoduleAddCommand</c> used to add a new submodule to a
		///         parent repository</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='submoduleAdd' and count(parameter)=0]"
		[Register ("submoduleAdd", "()Lorg/eclipse/jgit/api/SubmoduleAddCommand;", "GetSubmoduleAddHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand SubmoduleAdd ()
		{
			const string __id = "submoduleAdd.()Lorg/eclipse/jgit/api/SubmoduleAddCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleAddCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_submoduleInit;
#pragma warning disable 0169
		static Delegate GetSubmoduleInitHandler ()
		{
			if (cb_submoduleInit == null)
				cb_submoduleInit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SubmoduleInit);
			return cb_submoduleInit;
		}

		static IntPtr n_SubmoduleInit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubmoduleInit ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>submodule init</c> command</summary>
		/// <returns>a <c>SubmoduleInitCommand</c> used to initialize the
		///         repository's config with settings from the .gitmodules file in
		///         the working tree</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='submoduleInit' and count(parameter)=0]"
		[Register ("submoduleInit", "()Lorg/eclipse/jgit/api/SubmoduleInitCommand;", "GetSubmoduleInitHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleInitCommand SubmoduleInit ()
		{
			const string __id = "submoduleInit.()Lorg/eclipse/jgit/api/SubmoduleInitCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleInitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_submoduleStatus;
#pragma warning disable 0169
		static Delegate GetSubmoduleStatusHandler ()
		{
			if (cb_submoduleStatus == null)
				cb_submoduleStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SubmoduleStatus);
			return cb_submoduleStatus;
		}

		static IntPtr n_SubmoduleStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubmoduleStatus ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>submodule status</c> command</summary>
		/// <returns>a <c>SubmoduleStatusCommand</c> used to report the status of a
		///         repository's configured submodules</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='submoduleStatus' and count(parameter)=0]"
		[Register ("submoduleStatus", "()Lorg/eclipse/jgit/api/SubmoduleStatusCommand;", "GetSubmoduleStatusHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleStatusCommand SubmoduleStatus ()
		{
			const string __id = "submoduleStatus.()Lorg/eclipse/jgit/api/SubmoduleStatusCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleStatusCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_submoduleSync;
#pragma warning disable 0169
		static Delegate GetSubmoduleSyncHandler ()
		{
			if (cb_submoduleSync == null)
				cb_submoduleSync = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SubmoduleSync);
			return cb_submoduleSync;
		}

		static IntPtr n_SubmoduleSync (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubmoduleSync ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>submodule sync</c> command</summary>
		/// <returns>a <c>SubmoduleSyncCommand</c> used to update the URL of a
		///         submodule from the parent repository's .gitmodules file</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='submoduleSync' and count(parameter)=0]"
		[Register ("submoduleSync", "()Lorg/eclipse/jgit/api/SubmoduleSyncCommand;", "GetSubmoduleSyncHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleSyncCommand SubmoduleSync ()
		{
			const string __id = "submoduleSync.()Lorg/eclipse/jgit/api/SubmoduleSyncCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleSyncCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_submoduleUpdate;
#pragma warning disable 0169
		static Delegate GetSubmoduleUpdateHandler ()
		{
			if (cb_submoduleUpdate == null)
				cb_submoduleUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SubmoduleUpdate);
			return cb_submoduleUpdate;
		}

		static IntPtr n_SubmoduleUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubmoduleUpdate ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>submodule update</c> command</summary>
		/// <returns>a <c>SubmoduleUpdateCommand</c> used to update the submodules in
		///         a repository to the configured revision</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='submoduleUpdate' and count(parameter)=0]"
		[Register ("submoduleUpdate", "()Lorg/eclipse/jgit/api/SubmoduleUpdateCommand;", "GetSubmoduleUpdateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand SubmoduleUpdate ()
		{
			const string __id = "submoduleUpdate.()Lorg/eclipse/jgit/api/SubmoduleUpdateCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_tag;
#pragma warning disable 0169
		static Delegate GetTagHandler ()
		{
			if (cb_tag == null)
				cb_tag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Tag);
			return cb_tag;
		}

		static IntPtr n_Tag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tag ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object to execute a <c>Tag</c> command</summary>
		/// <returns>a <c>TagCommand</c> used to collect all optional parameters and
		///         to finally execute the <c>Tag</c> command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='tag' and count(parameter)=0]"
		[Register ("tag", "()Lorg/eclipse/jgit/api/TagCommand;", "GetTagHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.TagCommand Tag ()
		{
			const string __id = "tag.()Lorg/eclipse/jgit/api/TagCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_tagDelete;
#pragma warning disable 0169
		static Delegate GetTagDeleteHandler ()
		{
			if (cb_tagDelete == null)
				cb_tagDelete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_TagDelete);
			return cb_tagDelete;
		}

		static IntPtr n_TagDelete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TagDelete ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to delete tags</summary>
		/// <returns>a <c>DeleteTagCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='tagDelete' and count(parameter)=0]"
		[Register ("tagDelete", "()Lorg/eclipse/jgit/api/DeleteTagCommand;", "GetTagDeleteHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DeleteTagCommand TagDelete ()
		{
			const string __id = "tagDelete.()Lorg/eclipse/jgit/api/DeleteTagCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteTagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_tagList;
#pragma warning disable 0169
		static Delegate GetTagListHandler ()
		{
			if (cb_tagList == null)
				cb_tagList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_TagList);
			return cb_tagList;
		}

		static IntPtr n_TagList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TagList ());
		}
#pragma warning restore 0169

		/// <summary>Returns a command object used to list tags</summary>
		/// <returns>a <c>ListTagCommand</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='tagList' and count(parameter)=0]"
		[Register ("tagList", "()Lorg/eclipse/jgit/api/ListTagCommand;", "GetTagListHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ListTagCommand TagList ()
		{
			const string __id = "tagList.()Lorg/eclipse/jgit/api/ListTagCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListTagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="repo">the git repository this class is interacting with.
		///            <c>null</c> is not allowed</param>
		/// <returns>a <c>Git</c> object for the existing git repository</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Git']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("wrap", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/api/Git;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Api.Git Wrap (global::Org.Eclipse.Jgit.Lib.Repository repo)
		{
			const string __id = "wrap.(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/api/Git;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Git> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

	}
}
