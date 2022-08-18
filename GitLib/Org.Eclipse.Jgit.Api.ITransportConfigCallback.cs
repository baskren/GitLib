using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Receives a callback allowing type-specific configuration to be set
	/// on the Transport instance after it's been created.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.api']/interface[@name='TransportConfigCallback']"
	[Register ("org/eclipse/jgit/api/TransportConfigCallback", "", "Org.Eclipse.Jgit.Api.ITransportConfigCallbackInvoker")]
	public partial interface ITransportConfigCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/interface[@name='TransportConfigCallback']/method[@name='configure' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.Transport']]"
		/// <param name="transport">transport</param>
		/// <summary>Add any additional transport-specific configuration required.</summary>
		[Register ("configure", "(Lorg/eclipse/jgit/transport/Transport;)V", "GetConfigure_Lorg_eclipse_jgit_transport_Transport_Handler:Org.Eclipse.Jgit.Api.ITransportConfigCallbackInvoker, AndroidBindableLibrary")]
		void Configure (global::Org.Eclipse.Jgit.Transport.Transport transport);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/api/TransportConfigCallback", DoNotGenerateAcw=true)]
	internal partial class ITransportConfigCallbackInvoker : global::Java.Lang.Object, ITransportConfigCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/TransportConfigCallback", typeof (ITransportConfigCallbackInvoker));

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

		public static ITransportConfigCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransportConfigCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.api.TransportConfigCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransportConfigCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_configure_Lorg_eclipse_jgit_transport_Transport_;
#pragma warning disable 0169
		static Delegate GetConfigure_Lorg_eclipse_jgit_transport_Transport_Handler ()
		{
			if (cb_configure_Lorg_eclipse_jgit_transport_Transport_ == null)
				cb_configure_Lorg_eclipse_jgit_transport_Transport_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Configure_Lorg_eclipse_jgit_transport_Transport_);
			return cb_configure_Lorg_eclipse_jgit_transport_Transport_;
		}

		static void n_Configure_Lorg_eclipse_jgit_transport_Transport_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transport)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ITransportConfigCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transport = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (native_transport, JniHandleOwnership.DoNotTransfer);
			__this.Configure (transport);
		}
#pragma warning restore 0169

		IntPtr id_configure_Lorg_eclipse_jgit_transport_Transport_;
		public unsafe void Configure (global::Org.Eclipse.Jgit.Transport.Transport transport)
		{
			if (id_configure_Lorg_eclipse_jgit_transport_Transport_ == IntPtr.Zero)
				id_configure_Lorg_eclipse_jgit_transport_Transport_ = JNIEnv.GetMethodID (class_ref, "configure", "(Lorg/eclipse/jgit/transport/Transport;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((transport == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transport).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configure_Lorg_eclipse_jgit_transport_Transport_, __args);
		}

	}
}
