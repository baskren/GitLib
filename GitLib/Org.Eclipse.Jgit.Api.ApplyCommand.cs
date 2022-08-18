using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Apply a patch to files and/or to the index.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ApplyCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/ApplyCommand", DoNotGenerateAcw=true)]
	public partial class ApplyCommand : global::Org.Eclipse.Jgit.Api.GitCommand<ApplyResult> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/ApplyCommand", typeof (ApplyCommand));

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

		protected ApplyCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ApplyCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>ApplyCommand</c> command with all the options and
		/// parameters collected by the setter methods (e.</summary>
		/// <returns>an <c>ApplyResult</c> object representing the command result</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ApplyCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/api/ApplyResult;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Api.ApplyResult Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/api/ApplyResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ApplyResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPatch_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetPatch_Ljava_io_InputStream_Handler ()
		{
			if (cb_setPatch_Ljava_io_InputStream_ == null)
				cb_setPatch_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPatch_Ljava_io_InputStream_);
			return cb_setPatch_Ljava_io_InputStream_;
		}

		static IntPtr n_SetPatch_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ApplyCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPatch (@in));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="in">the patch to apply</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ApplyCommand']/method[@name='setPatch' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("setPatch", "(Ljava/io/InputStream;)Lorg/eclipse/jgit/api/ApplyCommand;", "GetSetPatch_Ljava_io_InputStream_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ApplyCommand SetPatch (global::System.IO.Stream @in)
		{
			const string __id = "setPatch.(Ljava/io/InputStream;)Lorg/eclipse/jgit/api/ApplyCommand;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ApplyCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

	}
}
