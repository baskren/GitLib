using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Events {

	/// <summary>Manages a thread-safe list of <c>RepositoryListener</c>s.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='ListenerList']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/events/ListenerList", DoNotGenerateAcw=true)]
	public partial class ListenerList : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/events/ListenerList", typeof (ListenerList));

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

		protected ListenerList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='ListenerList']/constructor[@name='ListenerList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ListenerList () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_addConfigChangedListener_Lorg_eclipse_jgit_events_ConfigChangedListener_;
#pragma warning disable 0169
		static Delegate GetAddConfigChangedListener_Lorg_eclipse_jgit_events_ConfigChangedListener_Handler ()
		{
			if (cb_addConfigChangedListener_Lorg_eclipse_jgit_events_ConfigChangedListener_ == null)
				cb_addConfigChangedListener_Lorg_eclipse_jgit_events_ConfigChangedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddConfigChangedListener_Lorg_eclipse_jgit_events_ConfigChangedListener_);
			return cb_addConfigChangedListener_Lorg_eclipse_jgit_events_ConfigChangedListener_;
		}

		static IntPtr n_AddConfigChangedListener_Lorg_eclipse_jgit_events_ConfigChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Org.Eclipse.Jgit.Events.IConfigChangedListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.IConfigChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddConfigChangedListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="listener">the listener implementation.</param>
		/// <summary>Register a ConfigChangedListener.</summary>
		/// <returns>handle to later remove the listener.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='ListenerList']/method[@name='addConfigChangedListener' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.events.ConfigChangedListener']]"
		[Register ("addConfigChangedListener", "(Lorg/eclipse/jgit/events/ConfigChangedListener;)Lorg/eclipse/jgit/events/ListenerHandle;", "GetAddConfigChangedListener_Lorg_eclipse_jgit_events_ConfigChangedListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Events.ListenerHandle AddConfigChangedListener (global::Org.Eclipse.Jgit.Events.IConfigChangedListener listener)
		{
			const string __id = "addConfigChangedListener.(Lorg/eclipse/jgit/events/ConfigChangedListener;)Lorg/eclipse/jgit/events/ListenerHandle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_addIndexChangedListener_Lorg_eclipse_jgit_events_IndexChangedListener_;
#pragma warning disable 0169
		static Delegate GetAddIndexChangedListener_Lorg_eclipse_jgit_events_IndexChangedListener_Handler ()
		{
			if (cb_addIndexChangedListener_Lorg_eclipse_jgit_events_IndexChangedListener_ == null)
				cb_addIndexChangedListener_Lorg_eclipse_jgit_events_IndexChangedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddIndexChangedListener_Lorg_eclipse_jgit_events_IndexChangedListener_);
			return cb_addIndexChangedListener_Lorg_eclipse_jgit_events_IndexChangedListener_;
		}

		static IntPtr n_AddIndexChangedListener_Lorg_eclipse_jgit_events_IndexChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Org.Eclipse.Jgit.Events.IIndexChangedListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.IIndexChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddIndexChangedListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="listener">the listener implementation.</param>
		/// <summary>Register an IndexChangedListener.</summary>
		/// <returns>handle to later remove the listener.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='ListenerList']/method[@name='addIndexChangedListener' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.events.IndexChangedListener']]"
		[Register ("addIndexChangedListener", "(Lorg/eclipse/jgit/events/IndexChangedListener;)Lorg/eclipse/jgit/events/ListenerHandle;", "GetAddIndexChangedListener_Lorg_eclipse_jgit_events_IndexChangedListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Events.ListenerHandle AddIndexChangedListener (global::Org.Eclipse.Jgit.Events.IIndexChangedListener listener)
		{
			const string __id = "addIndexChangedListener.(Lorg/eclipse/jgit/events/IndexChangedListener;)Lorg/eclipse/jgit/events/ListenerHandle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_addListener_Ljava_lang_Class_Lorg_eclipse_jgit_events_RepositoryListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Ljava_lang_Class_Lorg_eclipse_jgit_events_RepositoryListener_Handler ()
		{
			if (cb_addListener_Ljava_lang_Class_Lorg_eclipse_jgit_events_RepositoryListener_ == null)
				cb_addListener_Ljava_lang_Class_Lorg_eclipse_jgit_events_RepositoryListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddListener_Ljava_lang_Class_Lorg_eclipse_jgit_events_RepositoryListener_);
			return cb_addListener_Ljava_lang_Class_Lorg_eclipse_jgit_events_RepositoryListener_;
		}

		static IntPtr n_AddListener_Ljava_lang_Class_Lorg_eclipse_jgit_events_RepositoryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_type, JniHandleOwnership.DoNotTransfer);
			var listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddListener (type, listener));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="&lt;T&gt;">the type of listener being registered.</param>
		/// <param name="type">type of listener being registered.</param>
		/// <param name="listener">the listener instance.</param>
		/// <summary>Add a listener to the list.</summary>
		/// <returns>a handle to later remove the registration, if desired.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='ListenerList']/method[@name='addListener' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='T']]"
		[Register ("addListener", "(Ljava/lang/Class;Lorg/eclipse/jgit/events/RepositoryListener;)Lorg/eclipse/jgit/events/ListenerHandle;", "GetAddListener_Ljava_lang_Class_Lorg_eclipse_jgit_events_RepositoryListener_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.events.RepositoryListener"})]
		public virtual unsafe global::Org.Eclipse.Jgit.Events.ListenerHandle AddListener (global::Java.Lang.Class type, global::Java.Lang.Object listener)
		{
			const string __id = "addListener.(Ljava/lang/Class;Lorg/eclipse/jgit/events/RepositoryListener;)Lorg/eclipse/jgit/events/ListenerHandle;";
			IntPtr native_listener = JNIEnv.ToLocalJniHandle (listener);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (native_listener);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_listener);
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_addRefsChangedListener_Lorg_eclipse_jgit_events_RefsChangedListener_;
#pragma warning disable 0169
		static Delegate GetAddRefsChangedListener_Lorg_eclipse_jgit_events_RefsChangedListener_Handler ()
		{
			if (cb_addRefsChangedListener_Lorg_eclipse_jgit_events_RefsChangedListener_ == null)
				cb_addRefsChangedListener_Lorg_eclipse_jgit_events_RefsChangedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddRefsChangedListener_Lorg_eclipse_jgit_events_RefsChangedListener_);
			return cb_addRefsChangedListener_Lorg_eclipse_jgit_events_RefsChangedListener_;
		}

		static IntPtr n_AddRefsChangedListener_Lorg_eclipse_jgit_events_RefsChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Org.Eclipse.Jgit.Events.IRefsChangedListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.IRefsChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddRefsChangedListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="listener">the listener implementation.</param>
		/// <summary>Register a RefsChangedListener.</summary>
		/// <returns>handle to later remove the listener.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='ListenerList']/method[@name='addRefsChangedListener' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.events.RefsChangedListener']]"
		[Register ("addRefsChangedListener", "(Lorg/eclipse/jgit/events/RefsChangedListener;)Lorg/eclipse/jgit/events/ListenerHandle;", "GetAddRefsChangedListener_Lorg_eclipse_jgit_events_RefsChangedListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Events.ListenerHandle AddRefsChangedListener (global::Org.Eclipse.Jgit.Events.IRefsChangedListener listener)
		{
			const string __id = "addRefsChangedListener.(Lorg/eclipse/jgit/events/RefsChangedListener;)Lorg/eclipse/jgit/events/ListenerHandle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_dispatch_Lorg_eclipse_jgit_events_RepositoryEvent_;
#pragma warning disable 0169
		static Delegate GetDispatch_Lorg_eclipse_jgit_events_RepositoryEvent_Handler ()
		{
			if (cb_dispatch_Lorg_eclipse_jgit_events_RepositoryEvent_ == null)
				cb_dispatch_Lorg_eclipse_jgit_events_RepositoryEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Dispatch_Lorg_eclipse_jgit_events_RepositoryEvent_);
			return cb_dispatch_Lorg_eclipse_jgit_events_RepositoryEvent_;
		}

		static void n_Dispatch_Lorg_eclipse_jgit_events_RepositoryEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.RepositoryEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Dispatch (e);
		}
#pragma warning restore 0169

		/// <param name="event">the event to deliver.</param>
		/// <summary>Dispatch an event to all interested listeners.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='ListenerList']/method[@name='dispatch' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.events.RepositoryEvent']]"
		[Register ("dispatch", "(Lorg/eclipse/jgit/events/RepositoryEvent;)V", "GetDispatch_Lorg_eclipse_jgit_events_RepositoryEvent_Handler")]
		public unsafe void Dispatch (global::Org.Eclipse.Jgit.Events.RepositoryEvent e)
		{
			const string __id = "dispatch.(Lorg/eclipse/jgit/events/RepositoryEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

	}
}
