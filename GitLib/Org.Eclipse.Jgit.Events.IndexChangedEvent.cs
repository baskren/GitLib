using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Events {

	/// <summary>Describes a change to one or more paths in the index file.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='IndexChangedEvent']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/events/IndexChangedEvent", DoNotGenerateAcw=true)]
	public partial class IndexChangedEvent : global::Org.Eclipse.Jgit.Events.RepositoryEvent<global::Org.Eclipse.Jgit.Events.IIndexChangedListener> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/events/IndexChangedEvent", typeof (IndexChangedEvent));

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

		protected IndexChangedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='IndexChangedEvent']/constructor[@name='IndexChangedEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IndexChangedEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getListenerType;
#pragma warning disable 0169
		static Delegate GetGetListenerTypeHandler ()
		{
			if (cb_getListenerType == null)
				cb_getListenerType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetListenerType);
			return cb_getListenerType;
		}

		static IntPtr n_GetListenerType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.IndexChangedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListenerType);
		}
#pragma warning restore 0169

		public override unsafe global::Java.Lang.Class ListenerType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='IndexChangedEvent']/method[@name='getListenerType' and count(parameter)=0]"
			[Register ("getListenerType", "()Ljava/lang/Class;", "GetGetListenerTypeHandler")]
			get {
				const string __id = "getListenerType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_dispatch_Lorg_eclipse_jgit_events_IndexChangedListener_;
#pragma warning disable 0169
		static Delegate GetDispatch_Lorg_eclipse_jgit_events_IndexChangedListener_Handler ()
		{
			if (cb_dispatch_Lorg_eclipse_jgit_events_IndexChangedListener_ == null)
				cb_dispatch_Lorg_eclipse_jgit_events_IndexChangedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Dispatch_Lorg_eclipse_jgit_events_IndexChangedListener_);
			return cb_dispatch_Lorg_eclipse_jgit_events_IndexChangedListener_;
		}

		static void n_Dispatch_Lorg_eclipse_jgit_events_IndexChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.IndexChangedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Org.Eclipse.Jgit.Events.IIndexChangedListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.IIndexChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Dispatch (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='IndexChangedEvent']/method[@name='dispatch' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.events.IndexChangedListener']]"
		[Register ("dispatch", "(Lorg/eclipse/jgit/events/IndexChangedListener;)V", "GetDispatch_Lorg_eclipse_jgit_events_IndexChangedListener_Handler")]
		public override unsafe void Dispatch (global::Org.Eclipse.Jgit.Events.IIndexChangedListener listener)
		{
			const string __id = "dispatch.(Lorg/eclipse/jgit/events/IndexChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

	}
}
