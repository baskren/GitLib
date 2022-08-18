using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	public abstract partial class TransportCommand<T> : global::Org.Eclipse.Jgit.Api.TransportCommand
	{
        protected TransportCommand(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		protected unsafe TransportCommand(global::Org.Eclipse.Jgit.Lib.Repository repo) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer) { }


    }

    /// <param name="&lt;C&gt;">&lt;C&gt;</param>
    /// <param name="&lt;T&gt;">&lt;T&gt;</param>
    /// <summary>Base class for commands that use a <c>Transport</c> during execution.</summary>
    // Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']"
    [global::Android.Runtime.Register ("org/eclipse/jgit/api/TransportCommand", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"C extends org.eclipse.jgit.api.GitCommand", "T"})]
	public abstract partial class TransportCommand : global::Org.Eclipse.Jgit.Api.GitCommand {

		/// <summary>Configured credentials provider</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/field[@name='credentialsProvider']"
		[Register ("credentialsProvider")]
		protected global::Org.Eclipse.Jgit.Transport.CredentialsProvider CredentialsProvider {
			get {
				const string __id = "credentialsProvider.Lorg/eclipse/jgit/transport/CredentialsProvider;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "credentialsProvider.Lorg/eclipse/jgit/transport/CredentialsProvider;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Configured transport timeout</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/field[@name='timeout']"
		[Register ("timeout")]
		protected int Timeout {
			get {
				const string __id = "timeout.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "timeout.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		/// <summary>Configured callback for transport configuration</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/field[@name='transportConfigCallback']"
		[Register ("transportConfigCallback")]
		protected global::Org.Eclipse.Jgit.Api.ITransportConfigCallback TransportConfigCallback {
			get {
				const string __id = "transportConfigCallback.Lorg/eclipse/jgit/api/TransportConfigCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ITransportConfigCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportConfigCallback.Lorg/eclipse/jgit/api/TransportConfigCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/TransportCommand", typeof (TransportCommand));

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

		protected TransportCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/constructor[@name='TransportCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe TransportCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_configure_Lorg_eclipse_jgit_api_TransportCommand_;
#pragma warning disable 0169
		static Delegate GetConfigure_Lorg_eclipse_jgit_api_TransportCommand_Handler ()
		{
			if (cb_configure_Lorg_eclipse_jgit_api_TransportCommand_ == null)
				cb_configure_Lorg_eclipse_jgit_api_TransportCommand_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Configure_Lorg_eclipse_jgit_api_TransportCommand_);
			return cb_configure_Lorg_eclipse_jgit_api_TransportCommand_;
		}

		static IntPtr n_Configure_Lorg_eclipse_jgit_api_TransportCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_childCommand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TransportCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var childCommand = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TransportCommand> (native_childCommand, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Configure (childCommand));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="childCommand">childCommand</param>
		/// <summary>Configure a child command with the current configuration set in
		/// <c>this</c> command</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/method[@name='configure' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.TransportCommand']]"
		[Register ("configure", "(Lorg/eclipse/jgit/api/TransportCommand;)Lorg/eclipse/jgit/api/GitCommand;", "GetConfigure_Lorg_eclipse_jgit_api_TransportCommand_Handler")]
		protected virtual unsafe global::Java.Lang.Object Configure (global::Org.Eclipse.Jgit.Api.TransportCommand childCommand)
		{
			const string __id = "configure.(Lorg/eclipse/jgit/api/TransportCommand;)Lorg/eclipse/jgit/api/GitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((childCommand == null) ? IntPtr.Zero : ((global::Java.Lang.Object) childCommand).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (childCommand);
			}
		}

		static Delegate cb_configure_Lorg_eclipse_jgit_transport_Transport_;
#pragma warning disable 0169
		static Delegate GetConfigure_Lorg_eclipse_jgit_transport_Transport_Handler ()
		{
			if (cb_configure_Lorg_eclipse_jgit_transport_Transport_ == null)
				cb_configure_Lorg_eclipse_jgit_transport_Transport_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Configure_Lorg_eclipse_jgit_transport_Transport_);
			return cb_configure_Lorg_eclipse_jgit_transport_Transport_;
		}

		static IntPtr n_Configure_Lorg_eclipse_jgit_transport_Transport_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transport)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TransportCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transport = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (native_transport, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Configure (transport));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="transport">transport</param>
		/// <summary>Configure transport with credentials provider, timeout, and config
		/// callback</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/method[@name='configure' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.Transport']]"
		[Register ("configure", "(Lorg/eclipse/jgit/transport/Transport;)Lorg/eclipse/jgit/api/GitCommand;", "GetConfigure_Lorg_eclipse_jgit_transport_Transport_Handler")]
		protected virtual unsafe global::Java.Lang.Object Configure (global::Org.Eclipse.Jgit.Transport.Transport transport)
		{
			const string __id = "configure.(Lorg/eclipse/jgit/transport/Transport;)Lorg/eclipse/jgit/api/GitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transport == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transport).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (transport);
			}
		}

		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/method[@name='self' and count(parameter)=0]"
		[Register ("self", "()Lorg/eclipse/jgit/api/GitCommand;", "")]
		protected unsafe global::Java.Lang.Object Self ()
		{
			const string __id = "self.()Lorg/eclipse/jgit/api/GitCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_;
#pragma warning disable 0169
		static Delegate GetSetCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_Handler ()
		{
			if (cb_setCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_ == null)
				cb_setCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_);
			return cb_setCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_;
		}

		static IntPtr n_SetCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentialsProvider)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TransportCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var credentialsProvider = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (native_credentialsProvider, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCredentialsProvider (credentialsProvider));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="credentialsProvider">the <c>CredentialsProvider</c> to use</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/method[@name='setCredentialsProvider' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.CredentialsProvider']]"
		[Register ("setCredentialsProvider", "(Lorg/eclipse/jgit/transport/CredentialsProvider;)Lorg/eclipse/jgit/api/GitCommand;", "GetSetCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_Handler")]
		public virtual unsafe global::Java.Lang.Object SetCredentialsProvider (global::Org.Eclipse.Jgit.Transport.CredentialsProvider credentialsProvider)
		{
			const string __id = "setCredentialsProvider.(Lorg/eclipse/jgit/transport/CredentialsProvider;)Lorg/eclipse/jgit/api/GitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((credentialsProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialsProvider).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (credentialsProvider);
			}
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static IntPtr n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TransportCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTimeout (timeout));
		}
#pragma warning restore 0169

		/// <param name="timeout">the timeout used for the transport step</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)Lorg/eclipse/jgit/api/GitCommand;", "GetSetTimeout_IHandler")]
		public virtual unsafe global::Java.Lang.Object SetTimeout (int timeout)
		{
			const string __id = "setTimeout.(I)Lorg/eclipse/jgit/api/GitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTransportConfigCallback_Lorg_eclipse_jgit_api_TransportConfigCallback_;
#pragma warning disable 0169
		static Delegate GetSetTransportConfigCallback_Lorg_eclipse_jgit_api_TransportConfigCallback_Handler ()
		{
			if (cb_setTransportConfigCallback_Lorg_eclipse_jgit_api_TransportConfigCallback_ == null)
				cb_setTransportConfigCallback_Lorg_eclipse_jgit_api_TransportConfigCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTransportConfigCallback_Lorg_eclipse_jgit_api_TransportConfigCallback_);
			return cb_setTransportConfigCallback_Lorg_eclipse_jgit_api_TransportConfigCallback_;
		}

		static IntPtr n_SetTransportConfigCallback_Lorg_eclipse_jgit_api_TransportConfigCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transportConfigCallback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TransportCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transportConfigCallback = (global::Org.Eclipse.Jgit.Api.ITransportConfigCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ITransportConfigCallback> (native_transportConfigCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTransportConfigCallback (transportConfigCallback));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="transportConfigCallback">if set, the callback will be invoked after the
		///            <c>Transport</c> has created, but before the
		///            <c>Transport</c> is used. The callback can use this
		///            opportunity to set additional type-specific configuration on
		///            the <c>Transport</c> instance.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TransportCommand']/method[@name='setTransportConfigCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.TransportConfigCallback']]"
		[Register ("setTransportConfigCallback", "(Lorg/eclipse/jgit/api/TransportConfigCallback;)Lorg/eclipse/jgit/api/GitCommand;", "GetSetTransportConfigCallback_Lorg_eclipse_jgit_api_TransportConfigCallback_Handler")]
		public virtual unsafe global::Java.Lang.Object SetTransportConfigCallback (global::Org.Eclipse.Jgit.Api.ITransportConfigCallback transportConfigCallback)
		{
			const string __id = "setTransportConfigCallback.(Lorg/eclipse/jgit/api/TransportConfigCallback;)Lorg/eclipse/jgit/api/GitCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transportConfigCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transportConfigCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (transportConfigCallback);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/api/TransportCommand", DoNotGenerateAcw=true)]
	internal partial class TransportCommandInvoker : TransportCommand {
		public TransportCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/TransportCommand", typeof (TransportCommandInvoker));

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

		/*
		[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
		public override unsafe global::Java.Lang.Object Call ()
		{
			const string __id = "call.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}
		*/
	}
}
