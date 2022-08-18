using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Parsed information about a checkout.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='CheckoutEntry']"
	[Register ("org/eclipse/jgit/lib/CheckoutEntry", "", "Org.Eclipse.Jgit.Lib.ICheckoutEntryInvoker")]
	public partial interface ICheckoutEntry : IJavaObject, IJavaPeerable {
		string FromBranch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='CheckoutEntry']/method[@name='getFromBranch' and count(parameter)=0]"
			[Register ("getFromBranch", "()Ljava/lang/String;", "GetGetFromBranchHandler:Org.Eclipse.Jgit.Lib.ICheckoutEntryInvoker, AndroidBindableLibrary")]
			get; 
		}

		string ToBranch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='CheckoutEntry']/method[@name='getToBranch' and count(parameter)=0]"
			[Register ("getToBranch", "()Ljava/lang/String;", "GetGetToBranchHandler:Org.Eclipse.Jgit.Lib.ICheckoutEntryInvoker, AndroidBindableLibrary")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/CheckoutEntry", DoNotGenerateAcw=true)]
	internal partial class ICheckoutEntryInvoker : global::Java.Lang.Object, ICheckoutEntry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/CheckoutEntry", typeof (ICheckoutEntryInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ICheckoutEntry GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICheckoutEntry> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.CheckoutEntry'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICheckoutEntryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ICheckoutEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FromBranch);
		}
#pragma warning restore 0169

		IntPtr id_getFromBranch;
		public unsafe string FromBranch {
			get {
				if (id_getFromBranch == IntPtr.Zero)
					id_getFromBranch = JNIEnv.GetMethodID (class_ref, "getFromBranch", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromBranch), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ICheckoutEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToBranch);
		}
#pragma warning restore 0169

		IntPtr id_getToBranch;
		public unsafe string ToBranch {
			get {
				if (id_getToBranch == IntPtr.Zero)
					id_getToBranch = JNIEnv.GetMethodID (class_ref, "getToBranch", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToBranch), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
