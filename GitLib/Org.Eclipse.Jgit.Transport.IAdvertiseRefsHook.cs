using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	[Register ("org/eclipse/jgit/transport/AdvertiseRefsHook", DoNotGenerateAcw=true)]
	public abstract class AdvertiseRefsHook : Java.Lang.Object {
		internal AdvertiseRefsHook ()
		{
		}


		/// <summary>A simple hook that advertises the default refs.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='AdvertiseRefsHook']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook Default {
			get {
				const string __id = "DEFAULT.Lorg/eclipse/jgit/transport/AdvertiseRefsHook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/AdvertiseRefsHook", typeof (AdvertiseRefsHook));

	}

	[Register ("org/eclipse/jgit/transport/AdvertiseRefsHook", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AdvertiseRefsHook' type. This type will be removed in a future release.", error: true)]
	public abstract class AdvertiseRefsHookConsts : AdvertiseRefsHook {
		private AdvertiseRefsHookConsts ()
		{
		}

	}

	/// <summary>Hook to allow callers to take over advertising refs to the client.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='AdvertiseRefsHook']"
	[Register ("org/eclipse/jgit/transport/AdvertiseRefsHook", "", "Org.Eclipse.Jgit.Transport.IAdvertiseRefsHookInvoker")]
	public partial interface IAdvertiseRefsHook : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='AdvertiseRefsHook']/method[@name='advertiseRefs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.BaseReceivePack']]"
		/// <param name="receivePack">instance on which to call
		///            <c>BaseReceivePack#setAdvertisedRefs(java.util.Map,java.util.Set)</c>
		///            if necessary.</param>
		/// <summary>Advertise refs for receive-pack.</summary>
		[Register ("advertiseRefs", "(Lorg/eclipse/jgit/transport/BaseReceivePack;)V", "GetAdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_Handler:Org.Eclipse.Jgit.Transport.IAdvertiseRefsHookInvoker, AndroidBindableLibrary")]
		void AdvertiseRefs (global::Org.Eclipse.Jgit.Transport.BaseReceivePack receivePack);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='AdvertiseRefsHook']/method[@name='advertiseRefs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack']]"
		/// <param name="uploadPack">instance on which to call
		///            <c>UploadPack#setAdvertisedRefs(java.util.Map)</c>
		///            if necessary.</param>
		/// <summary>Advertise refs for upload-pack.</summary>
		[Register ("advertiseRefs", "(Lorg/eclipse/jgit/transport/UploadPack;)V", "GetAdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_Handler:Org.Eclipse.Jgit.Transport.IAdvertiseRefsHookInvoker, AndroidBindableLibrary")]
		void AdvertiseRefs (global::Org.Eclipse.Jgit.Transport.UploadPack uploadPack);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/AdvertiseRefsHook", DoNotGenerateAcw=true)]
	internal partial class IAdvertiseRefsHookInvoker : global::Java.Lang.Object, IAdvertiseRefsHook {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/AdvertiseRefsHook", typeof (IAdvertiseRefsHookInvoker));

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

		public static IAdvertiseRefsHook GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertiseRefsHook> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.AdvertiseRefsHook'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertiseRefsHookInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_;
#pragma warning disable 0169
		static Delegate GetAdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_Handler ()
		{
			if (cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ == null)
				cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_);
			return cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_;
		}

		static void n_AdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receivePack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var receivePack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (native_receivePack, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseRefs (receivePack);
		}
#pragma warning restore 0169

		IntPtr id_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_;
		public unsafe void AdvertiseRefs (global::Org.Eclipse.Jgit.Transport.BaseReceivePack receivePack)
		{
			if (id_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ == IntPtr.Zero)
				id_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ = JNIEnv.GetMethodID (class_ref, "advertiseRefs", "(Lorg/eclipse/jgit/transport/BaseReceivePack;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((receivePack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receivePack).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_, __args);
		}

		static Delegate cb_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_;
#pragma warning disable 0169
		static Delegate GetAdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_Handler ()
		{
			if (cb_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_ == null)
				cb_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_);
			return cb_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_;
		}

		static void n_AdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uploadPack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uploadPack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_uploadPack, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseRefs (uploadPack);
		}
#pragma warning restore 0169

		IntPtr id_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_;
		public unsafe void AdvertiseRefs (global::Org.Eclipse.Jgit.Transport.UploadPack uploadPack)
		{
			if (id_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_ == IntPtr.Zero)
				id_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_ = JNIEnv.GetMethodID (class_ref, "advertiseRefs", "(Lorg/eclipse/jgit/transport/UploadPack;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((uploadPack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uploadPack).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_, __args);
		}

	}
}
