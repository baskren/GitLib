using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Given a commit, show the most recent tag that is reachable from a commit.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DescribeCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/DescribeCommand", DoNotGenerateAcw=true)]
	public partial class DescribeCommand : global::Org.Eclipse.Jgit.Api.GitCommand<string> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/DescribeCommand", typeof (DescribeCommand));

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

		protected DescribeCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DescribeCommand']/constructor[@name='DescribeCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe DescribeCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DescribeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Describes the specified commit.</summary>
		/// <returns>if there's a tag that points to the commit being described, this
		///         tag name is returned. Otherwise additional suffix is added to the
		///         nearest tag, just like git-describe(1).
		///         &lt;p&gt;
		///         If none of the ancestors of the commit being described has any
		///         tags at all, then this method returns null, indicating that
		///         there's no way to describe this tag.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DescribeCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/String;", "GetCallHandler")]
		public override unsafe string Call ()
		{
			const string __id = "call.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTarget_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTarget_Ljava_lang_String_Handler ()
		{
			if (cb_setTarget_Ljava_lang_String_ == null)
				cb_setTarget_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTarget_Ljava_lang_String_);
			return cb_setTarget_Ljava_lang_String_;
		}

		static IntPtr n_SetTarget_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rev)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DescribeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rev = JNIEnv.GetString (native_rev, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTarget (rev));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="rev">Commit ID, tag, branch, ref, etc.
		/// 		See <c>Repository#resolve(String)</c> for allowed syntax.</param>
		/// <summary>Sets the commit to be described.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DescribeCommand']/method[@name='setTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTarget", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/DescribeCommand;", "GetSetTarget_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DescribeCommand SetTarget (string rev)
		{
			const string __id = "setTarget.(Ljava/lang/String;)Lorg/eclipse/jgit/api/DescribeCommand;";
			IntPtr native_rev = JNIEnv.NewString ((string)rev);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rev);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DescribeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rev);
			}
		}

		static Delegate cb_setTarget_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetSetTarget_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_setTarget_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_setTarget_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTarget_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_setTarget_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static IntPtr n_SetTarget_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DescribeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_target, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTarget (target));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="target">A non-null object ID to be described.</param>
		/// <summary>Sets the commit to be described.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DescribeCommand']/method[@name='setTarget' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("setTarget", "(Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/api/DescribeCommand;", "GetSetTarget_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DescribeCommand SetTarget (global::Org.Eclipse.Jgit.Lib.ObjectId target)
		{
			const string __id = "setTarget.(Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/api/DescribeCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DescribeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (target);
			}
		}

	}
}
