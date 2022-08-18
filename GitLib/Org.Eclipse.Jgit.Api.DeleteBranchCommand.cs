using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Used to delete one or several branches.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DeleteBranchCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/DeleteBranchCommand", DoNotGenerateAcw=true)]
	public partial class DeleteBranchCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::System.Collections.Generic.IList<string>> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/DeleteBranchCommand", typeof (DeleteBranchCommand));

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

		protected DeleteBranchCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DeleteBranchCommand']/constructor[@name='DeleteBranchCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe DeleteBranchCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <returns>the list with the (full) names of the deleted branches</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DeleteBranchCommand']/method[@name='call' and count(parameter)=0]"
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

		static Delegate cb_setBranchNames_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBranchNames_arrayLjava_lang_String_Handler ()
		{
			if (cb_setBranchNames_arrayLjava_lang_String_ == null)
				cb_setBranchNames_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetBranchNames_arrayLjava_lang_String_);
			return cb_setBranchNames_arrayLjava_lang_String_;
		}

		static IntPtr n_SetBranchNames_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_branchnames)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var branchnames = (string[]) JNIEnv.GetArray (native_branchnames, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBranchNames (branchnames));
			if (branchnames != null)
				JNIEnv.CopyArray (branchnames, native_branchnames);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DeleteBranchCommand']/method[@name='setBranchNames' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setBranchNames", "([Ljava/lang/String;)Lorg/eclipse/jgit/api/DeleteBranchCommand;", "GetSetBranchNames_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DeleteBranchCommand SetBranchNames (params string[] branchnames)
		{
			const string __id = "setBranchNames.([Ljava/lang/String;)Lorg/eclipse/jgit/api/DeleteBranchCommand;";
			IntPtr native_branchnames = JNIEnv.NewArray (branchnames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_branchnames);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (branchnames != null) {
					JNIEnv.CopyArray (native_branchnames, branchnames);
					JNIEnv.DeleteLocalRef (native_branchnames);
				}
				global::System.GC.KeepAlive (branchnames);
			}
		}

		static Delegate cb_setForce_Z;
#pragma warning disable 0169
		static Delegate GetSetForce_ZHandler ()
		{
			if (cb_setForce_Z == null)
				cb_setForce_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetForce_Z);
			return cb_setForce_Z;
		}

		static IntPtr n_SetForce_Z (IntPtr jnienv, IntPtr native__this, bool force)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetForce (force));
		}
#pragma warning restore 0169

		/// <param name="force">&lt;code&gt;true&lt;/code&gt; corresponds to the -D option,
		///            &lt;code&gt;false&lt;/code&gt; to the -d option (default) &lt;br&gt;
		///            if &lt;code&gt;false&lt;/code&gt; a check will be performed whether the
		///            branch to be deleted is already merged into the current branch
		///            and deletion will be refused in this case</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DeleteBranchCommand']/method[@name='setForce' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setForce", "(Z)Lorg/eclipse/jgit/api/DeleteBranchCommand;", "GetSetForce_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DeleteBranchCommand SetForce (bool force)
		{
			const string __id = "setForce.(Z)Lorg/eclipse/jgit/api/DeleteBranchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (force);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DeleteBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
