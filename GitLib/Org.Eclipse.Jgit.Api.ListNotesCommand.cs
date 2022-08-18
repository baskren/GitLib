using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>List object notes.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListNotesCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/ListNotesCommand", DoNotGenerateAcw=true)]
	public partial class ListNotesCommand : global::Org.Eclipse.Jgit.Api.GitCommand {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/ListNotesCommand", typeof (ListNotesCommand));

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

		protected ListNotesCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListNotesCommand']/constructor[@name='ListNotesCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe ListNotesCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListNotesCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Notes.Note>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <returns>the requested notes</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListNotesCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/List;", "GetCallHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Notes.Note> Call ()
		{
			const string __id = "call.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Notes.Note>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListNotesCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListNotesCommand']/method[@name='setNotesRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNotesRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/ListNotesCommand;", "GetSetNotesRef_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ListNotesCommand SetNotesRef (string notesRef)
		{
			const string __id = "setNotesRef.(Ljava/lang/String;)Lorg/eclipse/jgit/api/ListNotesCommand;";
			IntPtr native_notesRef = JNIEnv.NewString ((string)notesRef);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_notesRef);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListNotesCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_notesRef);
			}
		}

	}
}
