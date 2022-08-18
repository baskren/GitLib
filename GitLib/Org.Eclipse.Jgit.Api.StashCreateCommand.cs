using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Command class to stash changes in the working directory and index in a
	/// commit.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashCreateCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/StashCreateCommand", DoNotGenerateAcw=true)]
	public partial class StashCreateCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Revwalk.RevCommit> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/StashCreateCommand", typeof (StashCreateCommand));

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

		protected StashCreateCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		/// <summary>Create a command to stash changes in the working directory and index</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashCreateCommand']/constructor[@name='StashCreateCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe StashCreateCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Stash the contents on the working directory and index in separate commits
		/// and reset to the current HEAD commit.</summary>
		/// <returns>stashed commit or null if no changes to stash</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashCreateCommand']/method[@name='call' and count(parameter)=0]"
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

		static Delegate cb_setIncludeUntracked_Z;
#pragma warning disable 0169
		static Delegate GetSetIncludeUntracked_ZHandler ()
		{
			if (cb_setIncludeUntracked_Z == null)
				cb_setIncludeUntracked_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetIncludeUntracked_Z);
			return cb_setIncludeUntracked_Z;
		}

		static IntPtr n_SetIncludeUntracked_Z (IntPtr jnienv, IntPtr native__this, bool includeUntracked)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIncludeUntracked (includeUntracked));
		}
#pragma warning restore 0169

		/// <param name="includeUntracked">includeUntracked</param>
		/// <summary>Whether to include untracked files in the stash.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashCreateCommand']/method[@name='setIncludeUntracked' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIncludeUntracked", "(Z)Lorg/eclipse/jgit/api/StashCreateCommand;", "GetSetIncludeUntracked_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashCreateCommand SetIncludeUntracked (bool includeUntracked)
		{
			const string __id = "setIncludeUntracked.(Z)Lorg/eclipse/jgit/api/StashCreateCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (includeUntracked);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIndexMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIndexMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setIndexMessage_Ljava_lang_String_ == null)
				cb_setIndexMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetIndexMessage_Ljava_lang_String_);
			return cb_setIndexMessage_Ljava_lang_String_;
		}

		static IntPtr n_SetIndexMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIndexMessage (message));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="message">message</param>
		/// <summary>Set the message used when committing index changes</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashCreateCommand']/method[@name='setIndexMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setIndexMessage", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/StashCreateCommand;", "GetSetIndexMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashCreateCommand SetIndexMessage (string message)
		{
			const string __id = "setIndexMessage.(Ljava/lang/String;)Lorg/eclipse/jgit/api/StashCreateCommand;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_setPerson_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetPerson_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setPerson_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setPerson_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPerson_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setPerson_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static IntPtr n_SetPerson_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_person)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var person = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_person, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPerson (person));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="person">person</param>
		/// <summary>Set the person to use as the author and committer in the commits made</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashCreateCommand']/method[@name='setPerson' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
		[Register ("setPerson", "(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/api/StashCreateCommand;", "GetSetPerson_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashCreateCommand SetPerson (global::Org.Eclipse.Jgit.Lib.PersonIdent person)
		{
			const string __id = "setPerson.(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/api/StashCreateCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((person == null) ? IntPtr.Zero : ((global::Java.Lang.Object) person).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (person);
			}
		}

		static Delegate cb_setRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRef_Ljava_lang_String_Handler ()
		{
			if (cb_setRef_Ljava_lang_String_ == null)
				cb_setRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRef_Ljava_lang_String_);
			return cb_setRef_Ljava_lang_String_;
		}

		static IntPtr n_SetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRef (@ref));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ref">ref</param>
		/// <summary>Set the reference to update with the stashed commit id
		/// If null, no reference is updated</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashCreateCommand']/method[@name='setRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/StashCreateCommand;", "GetSetRef_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashCreateCommand SetRef (string @ref)
		{
			const string __id = "setRef.(Ljava/lang/String;)Lorg/eclipse/jgit/api/StashCreateCommand;";
			IntPtr native__ref = JNIEnv.NewString ((string)@ref);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__ref);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__ref);
			}
		}

		static Delegate cb_setWorkingDirectoryMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWorkingDirectoryMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setWorkingDirectoryMessage_Ljava_lang_String_ == null)
				cb_setWorkingDirectoryMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetWorkingDirectoryMessage_Ljava_lang_String_);
			return cb_setWorkingDirectoryMessage_Ljava_lang_String_;
		}

		static IntPtr n_SetWorkingDirectoryMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetWorkingDirectoryMessage (message));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="message">message</param>
		/// <summary>Set the message used when committing working directory changes</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashCreateCommand']/method[@name='setWorkingDirectoryMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setWorkingDirectoryMessage", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/StashCreateCommand;", "GetSetWorkingDirectoryMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashCreateCommand SetWorkingDirectoryMessage (string message)
		{
			const string __id = "setWorkingDirectoryMessage.(Ljava/lang/String;)Lorg/eclipse/jgit/api/StashCreateCommand;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashCreateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
