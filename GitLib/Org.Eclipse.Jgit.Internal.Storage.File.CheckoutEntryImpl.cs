using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Parsed information about a checkout.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='CheckoutEntryImpl']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/CheckoutEntryImpl", DoNotGenerateAcw=true)]
	public partial class CheckoutEntryImpl : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Lib.ICheckoutEntry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/CheckoutEntryImpl", typeof (CheckoutEntryImpl));

		internal static IntPtr class_ref {
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

		protected CheckoutEntryImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getFromBranch;
#pragma warning disable 0169
		static Delegate GetGetFromBranchHandler ()
		{
			if (cb_getFromBranch == null)
				cb_getFromBranch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFromBranch);
			return cb_getFromBranch;
		}

		static IntPtr n_GetFromBranch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.CheckoutEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FromBranch);
		}
#pragma warning restore 0169

		public virtual unsafe string FromBranch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='CheckoutEntryImpl']/method[@name='getFromBranch' and count(parameter)=0]"
			[Register ("getFromBranch", "()Ljava/lang/String;", "GetGetFromBranchHandler")]
			get {
				const string __id = "getFromBranch.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getToBranch;
#pragma warning disable 0169
		static Delegate GetGetToBranchHandler ()
		{
			if (cb_getToBranch == null)
				cb_getToBranch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetToBranch);
			return cb_getToBranch;
		}

		static IntPtr n_GetToBranch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.CheckoutEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToBranch);
		}
#pragma warning restore 0169

		public virtual unsafe string ToBranch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='CheckoutEntryImpl']/method[@name='getToBranch' and count(parameter)=0]"
			[Register ("getToBranch", "()Ljava/lang/String;", "GetGetToBranchHandler")]
			get {
				const string __id = "getToBranch.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
