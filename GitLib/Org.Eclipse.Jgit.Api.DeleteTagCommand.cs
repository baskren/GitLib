using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Used to delete one or several tags.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DeleteTagCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/DeleteTagCommand", DoNotGenerateAcw=true)]
	public partial class DeleteTagCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::System.Collections.Generic.IList<string>> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/DeleteTagCommand", typeof (DeleteTagCommand));

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

		protected DeleteTagCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DeleteTagCommand']/constructor[@name='DeleteTagCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe DeleteTagCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteTagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <returns>the list with the full names of the deleted tags</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DeleteTagCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/List;", "GetCallHandler")]
		public override unsafe global::System.Collections.Generic.IList<string> Call ()
		{
			const string __id = "call.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTags_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTags_arrayLjava_lang_String_Handler ()
		{
			if (cb_setTags_arrayLjava_lang_String_ == null)
				cb_setTags_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTags_arrayLjava_lang_String_);
			return cb_setTags_arrayLjava_lang_String_;
		}

		static IntPtr n_SetTags_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteTagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tags = (string[]) JNIEnv.GetArray (native_tags, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTags (tags));
			if (tags != null)
				JNIEnv.CopyArray (tags, native_tags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DeleteTagCommand']/method[@name='setTags' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setTags", "([Ljava/lang/String;)Lorg/eclipse/jgit/api/DeleteTagCommand;", "GetSetTags_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DeleteTagCommand SetTags (params string[] tags)
		{
			const string __id = "setTags.([Ljava/lang/String;)Lorg/eclipse/jgit/api/DeleteTagCommand;";
			IntPtr native_tags = JNIEnv.NewArray (tags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tags);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteTagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (tags != null) {
					JNIEnv.CopyArray (native_tags, tags);
					JNIEnv.DeleteLocalRef (native_tags);
				}
				global::System.GC.KeepAlive (tags);
			}
		}

	}
}
