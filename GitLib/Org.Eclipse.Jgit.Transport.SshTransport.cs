using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>The base class for transports that use SSH protocol.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshTransport']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/SshTransport", DoNotGenerateAcw=true)]
	public abstract partial class SshTransport : global::Org.Eclipse.Jgit.Transport.TcpTransport {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/SshTransport", typeof (SshTransport));

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

		protected SshTransport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="local">the repository this instance will fetch into, or push out of.
		///            This must be the repository passed to
		///            <c>#open(Repository, URIish)</c>.</param>
		/// <param name="uri">the URI used to access the remote repository. This must be the
		///            URI passed to <c>#open(Repository, URIish)</c>.</param>
		/// <summary>Create a new transport instance.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshTransport']/constructor[@name='SshTransport' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.URIish']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;)V", "")]
		protected unsafe SshTransport (global::Org.Eclipse.Jgit.Lib.Repository local, global::Org.Eclipse.Jgit.Transport.URIish uri) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (uri);
			}
		}

		/// <param name="uri">the URI used to access the remote repository. This must be the
		///            URI passed to <c>#open(URIish)</c>.</param>
		/// <summary>Create a new transport instance without a local repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshTransport']/constructor[@name='SshTransport' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/transport/URIish;)V", "")]
		protected unsafe SshTransport (global::Org.Eclipse.Jgit.Transport.URIish uri) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/transport/URIish;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		static Delegate cb_getSession;
#pragma warning disable 0169
		static Delegate GetGetSessionHandler ()
		{
			if (cb_getSession == null)
				cb_getSession = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSession);
			return cb_getSession;
		}

		static IntPtr n_GetSession (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SshTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Session);
		}
#pragma warning restore 0169

		/// <summary>Get the default SSH session</summary>
		/// <returns>a remote session</returns>
		protected virtual unsafe global::Org.Eclipse.Jgit.Transport.IRemoteSession Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshTransport']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lorg/eclipse/jgit/transport/RemoteSession;", "GetGetSessionHandler")]
			get {
				const string __id = "getSession.()Lorg/eclipse/jgit/transport/RemoteSession;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRemoteSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSshSessionFactory;
#pragma warning disable 0169
		static Delegate GetGetSshSessionFactoryHandler ()
		{
			if (cb_getSshSessionFactory == null)
				cb_getSshSessionFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSshSessionFactory);
			return cb_getSshSessionFactory;
		}

		static IntPtr n_GetSshSessionFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SshTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SshSessionFactory);
		}
#pragma warning restore 0169

		static Delegate cb_setSshSessionFactory_Lorg_eclipse_jgit_transport_SshSessionFactory_;
#pragma warning disable 0169
		static Delegate GetSetSshSessionFactory_Lorg_eclipse_jgit_transport_SshSessionFactory_Handler ()
		{
			if (cb_setSshSessionFactory_Lorg_eclipse_jgit_transport_SshSessionFactory_ == null)
				cb_setSshSessionFactory_Lorg_eclipse_jgit_transport_SshSessionFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSshSessionFactory_Lorg_eclipse_jgit_transport_SshSessionFactory_);
			return cb_setSshSessionFactory_Lorg_eclipse_jgit_transport_SshSessionFactory_;
		}

		static void n_SetSshSessionFactory_Lorg_eclipse_jgit_transport_SshSessionFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_factory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SshTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var factory = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SshSessionFactory> (native_factory, JniHandleOwnership.DoNotTransfer);
			__this.SshSessionFactory = factory;
		}
#pragma warning restore 0169

		/// <returns>the SSH session factory that will be used for creating SSH sessions</returns>
		/// <summary>Set SSH session factory instead of the default one for this instance of
		/// the transport.</summary>
		/// <param name="factory">a factory to set, must not be null</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.SshSessionFactory SshSessionFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshTransport']/method[@name='getSshSessionFactory' and count(parameter)=0]"
			[Register ("getSshSessionFactory", "()Lorg/eclipse/jgit/transport/SshSessionFactory;", "GetGetSshSessionFactoryHandler")]
			get {
				const string __id = "getSshSessionFactory.()Lorg/eclipse/jgit/transport/SshSessionFactory;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SshSessionFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshTransport']/method[@name='setSshSessionFactory' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.SshSessionFactory']]"
			[Register ("setSshSessionFactory", "(Lorg/eclipse/jgit/transport/SshSessionFactory;)V", "GetSetSshSessionFactory_Lorg_eclipse_jgit_transport_SshSessionFactory_Handler")]
			set {
				const string __id = "setSshSessionFactory.(Lorg/eclipse/jgit/transport/SshSessionFactory;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SshTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshTransport']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/SshTransport", DoNotGenerateAcw=true)]
	internal partial class SshTransportInvoker : SshTransport {
		public SshTransportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/SshTransport", typeof (SshTransportInvoker));

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

		/// <summary>Begins a new connection for fetching from the remote repository.</summary>
		/// <returns>a fresh connection to fetch from the remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openFetch' and count(parameter)=0]"
		[Register ("openFetch", "()Lorg/eclipse/jgit/transport/FetchConnection;", "GetOpenFetchHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IFetchConnection OpenFetch ()
		{
			const string __id = "openFetch.()Lorg/eclipse/jgit/transport/FetchConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Begins a new connection for pushing into the remote repository.</summary>
		/// <returns>a fresh connection to push into the remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openPush' and count(parameter)=0]"
		[Register ("openPush", "()Lorg/eclipse/jgit/transport/PushConnection;", "GetOpenPushHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IPushConnection OpenPush ()
		{
			const string __id = "openPush.()Lorg/eclipse/jgit/transport/PushConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
