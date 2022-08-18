using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Add object notes.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddNoteCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/AddNoteCommand", DoNotGenerateAcw=true)]
	public partial class AddNoteCommand : global::Org.Eclipse.Jgit.Api.GitCommand<Notes.Note> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/AddNoteCommand", typeof (AddNoteCommand));

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

		protected AddNoteCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddNoteCommand']/constructor[@name='AddNoteCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe AddNoteCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddNoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddNoteCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/notes/Note;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Notes.Note Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/notes/Note;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddNoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (message));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="message">the notes message used when adding a note</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddNoteCommand']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessage", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/AddNoteCommand;", "GetSetMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.AddNoteCommand SetMessage (string message)
		{
			const string __id = "setMessage.(Ljava/lang/String;)Lorg/eclipse/jgit/api/AddNoteCommand;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddNoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_setNotesRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotesRef_Ljava_lang_String_Handler ()
		{
			if (cb_setNotesRef_Ljava_lang_String_ == null)
				cb_setNotesRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetNotesRef_Ljava_lang_String_);
			return cb_setNotesRef_Ljava_lang_String_;
		}

		static IntPtr n_SetNotesRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_notesRef)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddNoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var notesRef = JNIEnv.GetString (native_notesRef, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNotesRef (notesRef));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="notesRef">the ref to read notes from. Note, the default value of
		///            <c>Constants#R_NOTES_COMMITS</c> will be used if nothing is
		///            set</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddNoteCommand']/method[@name='setNotesRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNotesRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/AddNoteCommand;", "GetSetNotesRef_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.AddNoteCommand SetNotesRef (string notesRef)
		{
			const string __id = "setNotesRef.(Ljava/lang/String;)Lorg/eclipse/jgit/api/AddNoteCommand;";
			IntPtr native_notesRef = JNIEnv.NewString ((string)notesRef);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_notesRef);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddNoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_notesRef);
			}
		}

		static Delegate cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetSetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static IntPtr n_SetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddNoteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetObjectId (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">id</param>
		/// <summary>Sets the object id of object you want a note on.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='AddNoteCommand']/method[@name='setObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("setObjectId", "(Lorg/eclipse/jgit/revwalk/RevObject;)Lorg/eclipse/jgit/api/AddNoteCommand;", "GetSetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.AddNoteCommand SetObjectId (global::Org.Eclipse.Jgit.Revwalk.RevObject id)
		{
			const string __id = "setObjectId.(Lorg/eclipse/jgit/revwalk/RevObject;)Lorg/eclipse/jgit/api/AddNoteCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.AddNoteCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

	}
}
