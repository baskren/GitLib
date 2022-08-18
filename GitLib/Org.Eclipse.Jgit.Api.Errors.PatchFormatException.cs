using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api.Errors {

	/// <summary>Exception thrown when applying a patch fails due to an invalid format</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='PatchFormatException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/errors/PatchFormatException", DoNotGenerateAcw=true)]
	public partial class PatchFormatException : global::Org.Eclipse.Jgit.Api.Errors.GitAPIException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/errors/PatchFormatException", typeof (PatchFormatException));

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

		protected PatchFormatException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="errors">errors</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='PatchFormatException']/constructor[@name='PatchFormatException' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.patch.FormatError&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe PatchFormatException (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Patch.FormatError> errors) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errors = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Patch.FormatError>.ToLocalJniHandle (errors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_errors);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errors);
				global::System.GC.KeepAlive (errors);
			}
		}

		static Delegate cb_getErrors;
#pragma warning disable 0169
		static Delegate GetGetErrorsHandler ()
		{
			if (cb_getErrors == null)
				cb_getErrors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrors);
			return cb_getErrors;
		}

		static IntPtr n_GetErrors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Errors.PatchFormatException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Patch.FormatError>.ToLocalJniHandle (__this.Errors);
		}
#pragma warning restore 0169

		/// <returns>all the errors where unresolved conflicts have been detected</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Patch.FormatError> Errors {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='PatchFormatException']/method[@name='getErrors' and count(parameter)=0]"
			[Register ("getErrors", "()Ljava/util/List;", "GetGetErrorsHandler")]
			get {
				const string __id = "getErrors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Patch.FormatError>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
