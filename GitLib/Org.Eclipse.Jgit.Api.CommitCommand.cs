using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>Commit</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/CommitCommand", DoNotGenerateAcw=true)]
	public partial class CommitCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Revwalk.RevCommit> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CommitCommand", typeof (CommitCommand));

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

		protected CommitCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/constructor[@name='CommitCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe CommitCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAuthor;
#pragma warning disable 0169
		static Delegate GetGetAuthorHandler ()
		{
			if (cb_getAuthor == null)
				cb_getAuthor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthor);
			return cb_getAuthor;
		}

		static IntPtr n_GetAuthor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Author);
		}
#pragma warning restore 0169

		/// <returns>the author used for the <c>commit</c>. If no author was
		///         specified <c>null</c> is returned and the default
		///         <c>PersonIdent</c> of this repo is used during execution of the
		///         command</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent Author {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='getAuthor' and count(parameter)=0]"
			[Register ("getAuthor", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetAuthorHandler")]
			get {
				const string __id = "getAuthor.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCommitter;
#pragma warning disable 0169
		static Delegate GetGetCommitterHandler ()
		{
			if (cb_getCommitter == null)
				cb_getCommitter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommitter);
			return cb_getCommitter;
		}

		static IntPtr n_GetCommitter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Committer);
		}
#pragma warning restore 0169

		/// <returns>the committer used for the <c>commit</c>. If no committer was
		///         specified <c>null</c> is returned and the default
		///         <c>PersonIdent</c> of this repo is used during execution of the
		///         command</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent Committer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='getCommitter' and count(parameter)=0]"
			[Register ("getCommitter", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetCommitterHandler")]
			get {
				const string __id = "getCommitter.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		/// <returns>the commit message used for the &lt;code&gt;commit&lt;/code&gt;</returns>
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>commit</c> command with all the options and parameters
		/// collected by the setter methods of this class.</summary>
		/// <returns>a <c>RevCommit</c> object representing the successful commit.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='call' and count(parameter)=0]"
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

		static Delegate cb_setAll_Z;
#pragma warning disable 0169
		static Delegate GetSetAll_ZHandler ()
		{
			if (cb_setAll_Z == null)
				cb_setAll_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAll_Z);
			return cb_setAll_Z;
		}

		static IntPtr n_SetAll_Z (IntPtr jnienv, IntPtr native__this, bool all)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAll (all));
		}
#pragma warning restore 0169

		/// <param name="all">all</param>
		/// <summary>If set to true the Commit command automatically stages files that have
		/// been modified and deleted, but new files not known by the repository are
		/// not affected.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setAll' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAll", "(Z)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetAll_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetAll (bool all)
		{
			const string __id = "setAll.(Z)Lorg/eclipse/jgit/api/CommitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (all);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAmend_Z;
#pragma warning disable 0169
		static Delegate GetSetAmend_ZHandler ()
		{
			if (cb_setAmend_Z == null)
				cb_setAmend_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAmend_Z);
			return cb_setAmend_Z;
		}

		static IntPtr n_SetAmend_Z (IntPtr jnienv, IntPtr native__this, bool amend)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAmend (amend));
		}
#pragma warning restore 0169

		/// <param name="amend">amend</param>
		/// <summary>Used to amend the tip of the current branch.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setAmend' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAmend", "(Z)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetAmend_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetAmend (bool amend)
		{
			const string __id = "setAmend.(Z)Lorg/eclipse/jgit/api/CommitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (amend);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAuthor_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthor_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthor_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAuthor_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetAuthor_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAuthor_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetAuthor_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_email)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var email = JNIEnv.GetString (native_email, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAuthor (name, email));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">the name of the author used for the <c>commit</c></param>
		/// <param name="email">the email of the author used for the <c>commit</c></param>
		/// <summary>Sets the author for this <c>commit</c>.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setAuthor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAuthor", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetAuthor_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetAuthor (string name, string email)
		{
			const string __id = "setAuthor.(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_email = JNIEnv.NewString ((string)email);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_email);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_email);
			}
		}

		static Delegate cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static IntPtr n_SetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_author)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var author = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_author, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAuthor (author));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="author">the author used for the <c>commit</c></param>
		/// <summary>Sets the author for this <c>commit</c>.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setAuthor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
		[Register ("setAuthor", "(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetAuthor (global::Org.Eclipse.Jgit.Lib.PersonIdent author)
		{
			const string __id = "setAuthor.(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/api/CommitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((author == null) ? IntPtr.Zero : ((global::Java.Lang.Object) author).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (author);
			}
		}

		static Delegate cb_setCommitter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCommitter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setCommitter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setCommitter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetCommitter_Ljava_lang_String_Ljava_lang_String_);
			return cb_setCommitter_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetCommitter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_email)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var email = JNIEnv.GetString (native_email, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCommitter (name, email));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">the name of the committer used for the <c>commit</c></param>
		/// <param name="email">the email of the committer used for the <c>commit</c></param>
		/// <summary>Sets the committer for this <c>commit</c>.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setCommitter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setCommitter", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetCommitter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetCommitter (string name, string email)
		{
			const string __id = "setCommitter.(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_email = JNIEnv.NewString ((string)email);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_email);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_email);
			}
		}

		static Delegate cb_setCommitter_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetCommitter_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setCommitter_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setCommitter_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCommitter_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setCommitter_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static IntPtr n_SetCommitter_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_committer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var committer = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_committer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCommitter (committer));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="committer">the committer used for the <c>commit</c></param>
		/// <summary>Sets the committer for this <c>commit</c>.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setCommitter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
		[Register ("setCommitter", "(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetCommitter_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetCommitter (global::Org.Eclipse.Jgit.Lib.PersonIdent committer)
		{
			const string __id = "setCommitter.(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/api/CommitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((committer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) committer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (committer);
			}
		}

		static Delegate cb_setHookOutputStream_Ljava_io_PrintStream_;
#pragma warning disable 0169
		static Delegate GetSetHookOutputStream_Ljava_io_PrintStream_Handler ()
		{
			if (cb_setHookOutputStream_Ljava_io_PrintStream_ == null)
				cb_setHookOutputStream_Ljava_io_PrintStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetHookOutputStream_Ljava_io_PrintStream_);
			return cb_setHookOutputStream_Ljava_io_PrintStream_;
		}

		static IntPtr n_SetHookOutputStream_Ljava_io_PrintStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hookStdOut)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hookStdOut = global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (native_hookStdOut, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHookOutputStream (hookStdOut));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="hookStdOut">the output stream for hook scripts executed by this command</param>
		/// <summary>Set the output stream for hook scripts executed by this command.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setHookOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.PrintStream']]"
		[Register ("setHookOutputStream", "(Ljava/io/PrintStream;)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetHookOutputStream_Ljava_io_PrintStream_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetHookOutputStream (global::Java.IO.PrintStream hookStdOut)
		{
			const string __id = "setHookOutputStream.(Ljava/io/PrintStream;)Lorg/eclipse/jgit/api/CommitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((hookStdOut == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hookStdOut).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (hookStdOut);
			}
		}

		static Delegate cb_setInsertChangeId_Z;
#pragma warning disable 0169
		static Delegate GetSetInsertChangeId_ZHandler ()
		{
			if (cb_setInsertChangeId_Z == null)
				cb_setInsertChangeId_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetInsertChangeId_Z);
			return cb_setInsertChangeId_Z;
		}

		static IntPtr n_SetInsertChangeId_Z (IntPtr jnienv, IntPtr native__this, bool insertChangeId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetInsertChangeId (insertChangeId));
		}
#pragma warning restore 0169

		/// <param name="insertChangeId">insertChangeId</param>
		/// <summary>If set to true a change id will be inserted into the commit message</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setInsertChangeId' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInsertChangeId", "(Z)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetInsertChangeId_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetInsertChangeId (bool insertChangeId)
		{
			const string __id = "setInsertChangeId.(Z)Lorg/eclipse/jgit/api/CommitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (insertChangeId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static IntPtr n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (message));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="message">the commit message used for the <c>commit</c></param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessage", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetMessage (string message)
		{
			const string __id = "setMessage.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_setNoVerify_Z;
#pragma warning disable 0169
		static Delegate GetSetNoVerify_ZHandler ()
		{
			if (cb_setNoVerify_Z == null)
				cb_setNoVerify_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetNoVerify_Z);
			return cb_setNoVerify_Z;
		}

		static IntPtr n_SetNoVerify_Z (IntPtr jnienv, IntPtr native__this, bool noVerify)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNoVerify (noVerify));
		}
#pragma warning restore 0169

		/// <param name="noVerify">Whether this commit should be verified by the pre-commit and
		///            commit-msg hooks.</param>
		/// <summary>Sets the <c>#noVerify</c> option on this commit command.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setNoVerify' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNoVerify", "(Z)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetNoVerify_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetNoVerify (bool noVerify)
		{
			const string __id = "setNoVerify.(Z)Lorg/eclipse/jgit/api/CommitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noVerify);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnly_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOnly_Ljava_lang_String_Handler ()
		{
			if (cb_setOnly_Ljava_lang_String_ == null)
				cb_setOnly_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOnly_Ljava_lang_String_);
			return cb_setOnly_Ljava_lang_String_;
		}

		static IntPtr n_SetOnly_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_only)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var only = JNIEnv.GetString (native_only, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnly (only));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="only">path to commit (with &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>Commit dedicated path only.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setOnly' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOnly", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetOnly_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetOnly (string only)
		{
			const string __id = "setOnly.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;";
			IntPtr native_only = JNIEnv.NewString ((string)only);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_only);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_only);
			}
		}

		static Delegate cb_setReflogComment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReflogComment_Ljava_lang_String_Handler ()
		{
			if (cb_setReflogComment_Ljava_lang_String_ == null)
				cb_setReflogComment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetReflogComment_Ljava_lang_String_);
			return cb_setReflogComment_Ljava_lang_String_;
		}

		static IntPtr n_SetReflogComment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reflogComment)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reflogComment = JNIEnv.GetString (native_reflogComment, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReflogComment (reflogComment));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="reflogComment">reflogComment</param>
		/// <summary>Override the message written to the reflog</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CommitCommand']/method[@name='setReflogComment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setReflogComment", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;", "GetSetReflogComment_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CommitCommand SetReflogComment (string reflogComment)
		{
			const string __id = "setReflogComment.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CommitCommand;";
			IntPtr native_reflogComment = JNIEnv.NewString ((string)reflogComment);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_reflogComment);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CommitCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_reflogComment);
			}
		}

	}
}
