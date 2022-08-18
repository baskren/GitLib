using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Events {

	public abstract partial class RepositoryEvent<T> : RepositoryEvent
	{
        protected RepositoryEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		public unsafe RepositoryEvent() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer) { }

		/*
        static Delegate cb_dispatch_Lorg_eclipse_jgit_events_RepositoryListener_;
#pragma warning disable 0169
        static Delegate GetDispatch_Lorg_eclipse_jgit_events_RepositoryListener_Handler()
        {
            if (cb_dispatch_Lorg_eclipse_jgit_events_RepositoryListener_ == null)
                cb_dispatch_Lorg_eclipse_jgit_events_RepositoryListener_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_Dispatch_Lorg_eclipse_jgit_events_RepositoryListener_);
            return cb_dispatch_Lorg_eclipse_jgit_events_RepositoryListener_;
        }

        static void n_Dispatch_Lorg_eclipse_jgit_events_RepositoryListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.RepositoryEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_listener, JniHandleOwnership.DoNotTransfer);
            __this.Dispatch(listener);
        }
#pragma warning restore 0169
		*/
        /// <param name="listener">listener that wants this event.</param>
        /// <summary>Dispatch this event to the given listener.</summary>
        // Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='RepositoryEvent']/method[@name='dispatch' and count(parameter)=1 and parameter[1][@type='T']]"
        [Register("dispatch", "(Lorg/eclipse/jgit/events/RepositoryListener;)V", "GetDispatch_Lorg_eclipse_jgit_events_RepositoryListener_Handler")]
        public virtual void Dispatch(T listener) { throw new NotImplementedException(); }

    }

    /// <param name="&lt;T&gt;">type of listener this event dispatches to.</param>
    /// <summary>Describes a modification made to a repository.</summary>
    // Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='RepositoryEvent']"
    [global::Android.Runtime.Register ("org/eclipse/jgit/events/RepositoryEvent", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.events.RepositoryListener"})]
	public abstract partial class RepositoryEvent: global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/events/RepositoryEvent", typeof (RepositoryEvent));

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

		protected RepositoryEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='RepositoryEvent']/constructor[@name='RepositoryEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RepositoryEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.RepositoryEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListenerType);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Class ListenerType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='RepositoryEvent']/method[@name='getListenerType' and count(parameter)=0]"
			[Register ("getListenerType", "()Ljava/lang/Class;", "GetGetListenerTypeHandler")]
			get; 
		}

		static Delegate cb_getRepository;
#pragma warning disable 0169
		static Delegate GetGetRepositoryHandler ()
		{
			if (cb_getRepository == null)
				cb_getRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepository);
			return cb_getRepository;
		}

		static IntPtr n_GetRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.RepositoryEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		static Delegate cb_setRepository_Lorg_eclipse_jgit_lib_Repository_;
#pragma warning disable 0169
		static Delegate GetSetRepository_Lorg_eclipse_jgit_lib_Repository_Handler ()
		{
			if (cb_setRepository_Lorg_eclipse_jgit_lib_Repository_ == null)
				cb_setRepository_Lorg_eclipse_jgit_lib_Repository_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRepository_Lorg_eclipse_jgit_lib_Repository_);
			return cb_setRepository_Lorg_eclipse_jgit_lib_Repository_;
		}

		static void n_SetRepository_Lorg_eclipse_jgit_lib_Repository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.RepositoryEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.Repository = r;
		}
#pragma warning restore 0169

		/// <returns>the repository that was changed.</returns>
		/// <summary>Set the repository this event occurred on.</summary>
		/// <param name="r">the repository.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='RepositoryEvent']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "GetGetRepositoryHandler")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/lib/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='RepositoryEvent']/method[@name='setRepository' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
			[Register ("setRepository", "(Lorg/eclipse/jgit/lib/Repository;)V", "GetSetRepository_Lorg_eclipse_jgit_lib_Repository_Handler")]
			set {
				const string __id = "setRepository.(Lorg/eclipse/jgit/lib/Repository;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}


	}

	/*
	[global::Android.Runtime.Register ("org/eclipse/jgit/events/RepositoryEvent", DoNotGenerateAcw=true)]
	internal partial class RepositoryEventInvoker : RepositoryEvent {
		public RepositoryEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/events/RepositoryEvent", typeof (RepositoryEventInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		/// <returns>type of listener this event dispatches to.</returns>
		public override unsafe global::Java.Lang.Class ListenerType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='RepositoryEvent']/method[@name='getListenerType' and count(parameter)=0]"
			[Register ("getListenerType", "()Ljava/lang/Class;", "GetGetListenerTypeHandler")]
			get {
				const string __id = "getListenerType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <param name="listener">listener that wants this event.</param>
		/// <summary>Dispatch this event to the given listener.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.events']/class[@name='RepositoryEvent']/method[@name='dispatch' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("dispatch", "(Lorg/eclipse/jgit/events/RepositoryListener;)V", "GetDispatch_Lorg_eclipse_jgit_events_RepositoryListener_Handler")]
		public override unsafe void Dispatch (global::Java.Lang.Object listener)
		{
			const string __id = "dispatch.(Lorg/eclipse/jgit/events/RepositoryListener;)V";
			IntPtr native_listener = JNIEnv.ToLocalJniHandle (listener);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_listener);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_listener);
				global::System.GC.KeepAlive (listener);
			}
		}

	}
	*/
}
