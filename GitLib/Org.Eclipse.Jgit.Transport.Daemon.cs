using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Basic daemon for the anonymous &lt;code&gt;git://&lt;/code&gt; transport protocol.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/Daemon", DoNotGenerateAcw=true)]
	public partial class Daemon : global::Java.Lang.Object {
		/// <summary>9418: IANA assigned port number for Git.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/field[@name='DEFAULT_PORT']"
		[Register ("DEFAULT_PORT")]
		public const int DefaultPort = (int) 9418;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/Daemon", typeof (Daemon));

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

		protected Daemon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Configure a daemon to listen on any available network port.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/constructor[@name='Daemon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Daemon () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="addr">address to listen for connections on. If null, any available
		///            port will be chosen on all network interfaces.</param>
		/// <summary>Configure a new daemon for the specified network address.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/constructor[@name='Daemon' and count(parameter)=1 and parameter[1][@type='java.net.InetSocketAddress']]"
		[Register (".ctor", "(Ljava/net/InetSocketAddress;)V", "")]
		public unsafe Daemon (global::Java.Net.InetSocketAddress addr) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/InetSocketAddress;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((addr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) addr).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (addr);
			}
		}

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Address);
		}
#pragma warning restore 0169

		/// <returns>the address connections are received on.</returns>
		public virtual unsafe global::Java.Net.InetSocketAddress Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/net/InetSocketAddress;", "GetGetAddressHandler")]
			get {
				const string __id = "getAddress.()Ljava/net/InetSocketAddress;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		/// <returns>true if this daemon is receiving connections.</returns>
		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				const string __id = "isRunning.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPackConfig;
#pragma warning disable 0169
		static Delegate GetGetPackConfigHandler ()
		{
			if (cb_getPackConfig == null)
				cb_getPackConfig = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackConfig);
			return cb_getPackConfig;
		}

		static IntPtr n_GetPackConfig (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackConfig);
		}
#pragma warning restore 0169

		static Delegate cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
#pragma warning disable 0169
		static Delegate GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler ()
		{
			if (cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ == null)
				cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_);
			return cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
		}

		static void n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (native_pc, JniHandleOwnership.DoNotTransfer);
			__this.PackConfig = pc;
		}
#pragma warning restore 0169

		/// <returns>configuration controlling packing, may be null.</returns>
		/// <summary>Set the configuration used by the pack generator.</summary>
		/// <param name="pc">configuration controlling packing parameters. If null the
		///            source repository's settings will be used.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Storage.Pack.PackConfig PackConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='getPackConfig' and count(parameter)=0]"
			[Register ("getPackConfig", "()Lorg/eclipse/jgit/storage/pack/PackConfig;", "GetGetPackConfigHandler")]
			get {
				const string __id = "getPackConfig.()Lorg/eclipse/jgit/storage/pack/PackConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='setPackConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.storage.pack.PackConfig']]"
			[Register ("setPackConfig", "(Lorg/eclipse/jgit/storage/pack/PackConfig;)V", "GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler")]
			set {
				const string __id = "setPackConfig.(Lorg/eclipse/jgit/storage/pack/PackConfig;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int seconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = seconds;
		}
#pragma warning restore 0169

		/// <returns>timeout (in seconds) before aborting an IO operation.</returns>
		/// <summary>Set the timeout before willing to abort an IO call.</summary>
		/// <param name="seconds">number of seconds to wait (with no data transfer occurring)
		///            before aborting an IO read or write operation with the
		///            connected client.</param>
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				const string __id = "getTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
			set {
				const string __id = "setTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetService_Ljava_lang_String_Handler ()
		{
			if (cb_getService_Ljava_lang_String_ == null)
				cb_getService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetService_Ljava_lang_String_);
			return cb_getService_Ljava_lang_String_;
		}

		static IntPtr n_GetService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetService (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">name of the service; e.g. "receive-pack"/"git-receive-pack" or
		///            "upload-pack"/"git-upload-pack".</param>
		/// <summary>Lookup a supported service so it can be reconfigured.</summary>
		/// <returns>the service; null if this daemon implementation doesn't support
		///         the requested service type.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='getService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getService", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/DaemonService;", "GetGetService_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.DaemonService GetService (string name)
		{
			const string __id = "getService.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/DaemonService;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.DaemonService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setReceivePackFactory_Lorg_eclipse_jgit_transport_resolver_ReceivePackFactory_;
#pragma warning disable 0169
		static Delegate GetSetReceivePackFactory_Lorg_eclipse_jgit_transport_resolver_ReceivePackFactory_Handler ()
		{
			if (cb_setReceivePackFactory_Lorg_eclipse_jgit_transport_resolver_ReceivePackFactory_ == null)
				cb_setReceivePackFactory_Lorg_eclipse_jgit_transport_resolver_ReceivePackFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetReceivePackFactory_Lorg_eclipse_jgit_transport_resolver_ReceivePackFactory_);
			return cb_setReceivePackFactory_Lorg_eclipse_jgit_transport_resolver_ReceivePackFactory_;
		}

		static void n_SetReceivePackFactory_Lorg_eclipse_jgit_transport_resolver_ReceivePackFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_factory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var factory = (global::Org.Eclipse.Jgit.Transport.Resolver.IReceivePackFactory)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.IReceivePackFactory> (native_factory, JniHandleOwnership.DoNotTransfer);
			__this.SetReceivePackFactory (factory);
		}
#pragma warning restore 0169

		/// <param name="factory">the factory. If null receive-pack is disabled.</param>
		/// <summary>Set the factory to construct and configure per-request ReceivePack.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='setReceivePackFactory' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.resolver.ReceivePackFactory&lt;org.eclipse.jgit.transport.DaemonClient&gt;']]"
		[Register ("setReceivePackFactory", "(Lorg/eclipse/jgit/transport/resolver/ReceivePackFactory;)V", "GetSetReceivePackFactory_Lorg_eclipse_jgit_transport_resolver_ReceivePackFactory_Handler")]
		public virtual unsafe void SetReceivePackFactory (global::Org.Eclipse.Jgit.Transport.Resolver.IReceivePackFactory factory)
		{
			const string __id = "setReceivePackFactory.(Lorg/eclipse/jgit/transport/resolver/ReceivePackFactory;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (factory);
			}
		}

		static Delegate cb_setRepositoryResolver_Lorg_eclipse_jgit_transport_resolver_RepositoryResolver_;
#pragma warning disable 0169
		static Delegate GetSetRepositoryResolver_Lorg_eclipse_jgit_transport_resolver_RepositoryResolver_Handler ()
		{
			if (cb_setRepositoryResolver_Lorg_eclipse_jgit_transport_resolver_RepositoryResolver_ == null)
				cb_setRepositoryResolver_Lorg_eclipse_jgit_transport_resolver_RepositoryResolver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRepositoryResolver_Lorg_eclipse_jgit_transport_resolver_RepositoryResolver_);
			return cb_setRepositoryResolver_Lorg_eclipse_jgit_transport_resolver_RepositoryResolver_;
		}

		static void n_SetRepositoryResolver_Lorg_eclipse_jgit_transport_resolver_RepositoryResolver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resolver)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resolver = (global::Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolver)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolver> (native_resolver, JniHandleOwnership.DoNotTransfer);
			__this.SetRepositoryResolver (resolver);
		}
#pragma warning restore 0169

		/// <param name="resolver">the resolver instance.</param>
		/// <summary>Set the resolver used to locate a repository by name.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='setRepositoryResolver' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.resolver.RepositoryResolver&lt;org.eclipse.jgit.transport.DaemonClient&gt;']]"
		[Register ("setRepositoryResolver", "(Lorg/eclipse/jgit/transport/resolver/RepositoryResolver;)V", "GetSetRepositoryResolver_Lorg_eclipse_jgit_transport_resolver_RepositoryResolver_Handler")]
		public virtual unsafe void SetRepositoryResolver (global::Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolver resolver)
		{
			const string __id = "setRepositoryResolver.(Lorg/eclipse/jgit/transport/resolver/RepositoryResolver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resolver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resolver).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (resolver);
			}
		}

		static Delegate cb_setUploadPackFactory_Lorg_eclipse_jgit_transport_resolver_UploadPackFactory_;
#pragma warning disable 0169
		static Delegate GetSetUploadPackFactory_Lorg_eclipse_jgit_transport_resolver_UploadPackFactory_Handler ()
		{
			if (cb_setUploadPackFactory_Lorg_eclipse_jgit_transport_resolver_UploadPackFactory_ == null)
				cb_setUploadPackFactory_Lorg_eclipse_jgit_transport_resolver_UploadPackFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUploadPackFactory_Lorg_eclipse_jgit_transport_resolver_UploadPackFactory_);
			return cb_setUploadPackFactory_Lorg_eclipse_jgit_transport_resolver_UploadPackFactory_;
		}

		static void n_SetUploadPackFactory_Lorg_eclipse_jgit_transport_resolver_UploadPackFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_factory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var factory = (global::Org.Eclipse.Jgit.Transport.Resolver.IUploadPackFactory)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.IUploadPackFactory> (native_factory, JniHandleOwnership.DoNotTransfer);
			__this.SetUploadPackFactory (factory);
		}
#pragma warning restore 0169

		/// <param name="factory">the factory. If null upload-pack is disabled.</param>
		/// <summary>Set the factory to construct and configure per-request UploadPack.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='setUploadPackFactory' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.resolver.UploadPackFactory&lt;org.eclipse.jgit.transport.DaemonClient&gt;']]"
		[Register ("setUploadPackFactory", "(Lorg/eclipse/jgit/transport/resolver/UploadPackFactory;)V", "GetSetUploadPackFactory_Lorg_eclipse_jgit_transport_resolver_UploadPackFactory_Handler")]
		public virtual unsafe void SetUploadPackFactory (global::Org.Eclipse.Jgit.Transport.Resolver.IUploadPackFactory factory)
		{
			const string __id = "setUploadPackFactory.(Lorg/eclipse/jgit/transport/resolver/UploadPackFactory;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (factory);
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		/// <summary>Start this daemon on a background thread.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Daemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		/// <summary>Stop this daemon.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Daemon']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
