using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Result of push operation to the remote repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PushResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PushResult", DoNotGenerateAcw=true)]
	public partial class PushResult : global::Org.Eclipse.Jgit.Transport.OperationResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PushResult", typeof (PushResult));

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

		protected PushResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PushResult']/constructor[@name='PushResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getRemoteUpdates;
#pragma warning disable 0169
		static Delegate GetGetRemoteUpdatesHandler ()
		{
			if (cb_getRemoteUpdates == null)
				cb_getRemoteUpdates = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemoteUpdates);
			return cb_getRemoteUpdates;
		}

		static IntPtr n_GetRemoteUpdates (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PushResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.ToLocalJniHandle (__this.RemoteUpdates);
		}
#pragma warning restore 0169

		/// <summary>Get status of remote refs updates.</summary>
		/// <returns>collection of remote refs updates</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> RemoteUpdates {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PushResult']/method[@name='getRemoteUpdates' and count(parameter)=0]"
			[Register ("getRemoteUpdates", "()Ljava/util/Collection;", "GetGetRemoteUpdatesHandler")]
			get {
				const string __id = "getRemoteUpdates.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoteUpdate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRemoteUpdate_Ljava_lang_String_Handler ()
		{
			if (cb_getRemoteUpdate_Ljava_lang_String_ == null)
				cb_getRemoteUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRemoteUpdate_Ljava_lang_String_);
			return cb_getRemoteUpdate_Ljava_lang_String_;
		}

		static IntPtr n_GetRemoteUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PushResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRemoteUpdate (refName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="refName">remote ref name</param>
		/// <summary>Get status of specific remote ref update by remote ref name.</summary>
		/// <returns>status of remote ref update</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PushResult']/method[@name='getRemoteUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRemoteUpdate", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RemoteRefUpdate;", "GetGetRemoteUpdate_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate GetRemoteUpdate (string refName)
		{
			const string __id = "getRemoteUpdate.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RemoteRefUpdate;";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
			}
		}

	}
}
