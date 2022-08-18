using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Events {

	/// <summary>Receives <c>RefsChangedEvent</c>s.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.events']/interface[@name='RefsChangedListener']"
	[Register ("org/eclipse/jgit/events/RefsChangedListener", "", "Org.Eclipse.Jgit.Events.IRefsChangedListenerInvoker")]
	public partial interface IRefsChangedListener : global::Org.Eclipse.Jgit.Events.IRepositoryListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/interface[@name='RefsChangedListener']/method[@name='onRefsChanged' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.events.RefsChangedEvent']]"
		/// <param name="event">information about the changes.</param>
		/// <summary>Invoked when any reference changes.</summary>
		[Register ("onRefsChanged", "(Lorg/eclipse/jgit/events/RefsChangedEvent;)V", "GetOnRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_Handler:Org.Eclipse.Jgit.Events.IRefsChangedListenerInvoker, AndroidBindableLibrary")]
		void OnRefsChanged (global::Org.Eclipse.Jgit.Events.RefsChangedEvent e);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/events/RefsChangedListener", DoNotGenerateAcw=true)]
	internal partial class IRefsChangedListenerInvoker : global::Java.Lang.Object, IRefsChangedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/events/RefsChangedListener", typeof (IRefsChangedListenerInvoker));

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

		public static IRefsChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRefsChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.events.RefsChangedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefsChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_;
#pragma warning disable 0169
		static Delegate GetOnRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_Handler ()
		{
			if (cb_onRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_ == null)
				cb_onRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_);
			return cb_onRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_;
		}

		static void n_OnRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.IRefsChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.RefsChangedEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnRefsChanged (e);
		}
#pragma warning restore 0169

		IntPtr id_onRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_;
		public unsafe void OnRefsChanged (global::Org.Eclipse.Jgit.Events.RefsChangedEvent e)
		{
			if (id_onRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_ == IntPtr.Zero)
				id_onRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_ = JNIEnv.GetMethodID (class_ref, "onRefsChanged", "(Lorg/eclipse/jgit/events/RefsChangedEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRefsChanged_Lorg_eclipse_jgit_events_RefsChangedEvent_, __args);
		}

	}
}
