using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>The reflog command</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ReflogCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/ReflogCommand", DoNotGenerateAcw=true)]
	public partial class ReflogCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IReflogEntry>> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/ReflogCommand", typeof (ReflogCommand));

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

		protected ReflogCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ReflogCommand']/constructor[@name='ReflogCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe ReflogCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ReflogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IReflogEntry>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Run the reflog command</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ReflogCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/Collection;", "GetCallHandler")]
		public override unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IReflogEntry> Call ()
		{
			const string __id = "call.()Ljava/util/Collection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IReflogEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ReflogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRef (@ref));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ref">ref</param>
		/// <summary>The ref used for the reflog operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ReflogCommand']/method[@name='setRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/ReflogCommand;", "GetSetRef_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ReflogCommand SetRef (string @ref)
		{
			const string __id = "setRef.(Ljava/lang/String;)Lorg/eclipse/jgit/api/ReflogCommand;";
			IntPtr native__ref = JNIEnv.NewString ((string)@ref);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__ref);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ReflogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__ref);
			}
		}

	}
}
