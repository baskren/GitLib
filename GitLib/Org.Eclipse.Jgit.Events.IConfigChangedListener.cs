using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Events {

	/// <summary>Receives <c>ConfigChangedEvent</c>s.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.events']/interface[@name='ConfigChangedListener']"
	[Register ("org/eclipse/jgit/events/ConfigChangedListener", "", "Org.Eclipse.Jgit.Events.IConfigChangedListenerInvoker")]
	public partial interface IConfigChangedListener : global::Org.Eclipse.Jgit.Events.IRepositoryListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/interface[@name='ConfigChangedListener']/method[@name='onConfigChanged' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.events.ConfigChangedEvent']]"
		/// <param name="event">information about the changes.</param>
		/// <summary>Invoked when any change is made to the configuration.</summary>
		[Register ("onConfigChanged", "(Lorg/eclipse/jgit/events/ConfigChangedEvent;)V", "GetOnConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_Handler:Org.Eclipse.Jgit.Events.IConfigChangedListenerInvoker, AndroidBindableLibrary")]
		void OnConfigChanged (global::Org.Eclipse.Jgit.Events.ConfigChangedEvent e);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/events/ConfigChangedListener", DoNotGenerateAcw=true)]
	internal partial class IConfigChangedListenerInvoker : global::Java.Lang.Object, IConfigChangedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/events/ConfigChangedListener", typeof (IConfigChangedListenerInvoker));

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

		public static IConfigChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfigChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.events.ConfigChangedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_;
#pragma warning disable 0169
		static Delegate GetOnConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_Handler ()
		{
			if (cb_onConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_ == null)
				cb_onConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_);
			return cb_onConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_;
		}

		static void n_OnConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.IConfigChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ConfigChangedEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigChanged (e);
		}
#pragma warning restore 0169

		IntPtr id_onConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_;
		public unsafe void OnConfigChanged (global::Org.Eclipse.Jgit.Events.ConfigChangedEvent e)
		{
			if (id_onConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_ == IntPtr.Zero)
				id_onConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_ = JNIEnv.GetMethodID (class_ref, "onConfigChanged", "(Lorg/eclipse/jgit/events/ConfigChangedEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConfigChanged_Lorg_eclipse_jgit_events_ConfigChangedEvent_, __args);
		}

	}
}
