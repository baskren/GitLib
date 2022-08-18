using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Creates and destroys SSH connections to a remote system.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshSessionFactory']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/SshSessionFactory", DoNotGenerateAcw=true)]
	public abstract partial class SshSessionFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/SshSessionFactory", typeof (SshSessionFactory));

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

		protected SshSessionFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshSessionFactory']/constructor[@name='SshSessionFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SshSessionFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <summary>Get the currently configured JVM-wide factory. -or- Change the JVM-wide factory to a different implementation.</summary>
		/// <returns>factory the current factory for this JVM.</returns>
		/// <param name="newFactory">factory for future sessions to be created through. If null the
		///            default factory will be restored.s</param>
		public static unsafe global::Org.Eclipse.Jgit.Transport.SshSessionFactory Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshSessionFactory']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/eclipse/jgit/transport/SshSessionFactory;", "")]
			get {
				const string __id = "getInstance.()Lorg/eclipse/jgit/transport/SshSessionFactory;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SshSessionFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshSessionFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.SshSessionFactory']]"
			[Register ("setInstance", "(Lorg/eclipse/jgit/transport/SshSessionFactory;)V", "")]
			set {
				const string __id = "setInstance.(Lorg/eclipse/jgit/transport/SshSessionFactory;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getSession_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_transport_CredentialsProvider_Lorg_eclipse_jgit_util_FS_I;
#pragma warning disable 0169
		static Delegate GetGetSession_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_transport_CredentialsProvider_Lorg_eclipse_jgit_util_FS_IHandler ()
		{
			if (cb_getSession_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_transport_CredentialsProvider_Lorg_eclipse_jgit_util_FS_I == null)
				cb_getSession_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_transport_CredentialsProvider_Lorg_eclipse_jgit_util_FS_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLI_L) n_GetSession_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_transport_CredentialsProvider_Lorg_eclipse_jgit_util_FS_I);
			return cb_getSession_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_transport_CredentialsProvider_Lorg_eclipse_jgit_util_FS_I;
		}

		static IntPtr n_GetSession_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_transport_CredentialsProvider_Lorg_eclipse_jgit_util_FS_I (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_credentialsProvider, IntPtr native_fs, int tms)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SshSessionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			var credentialsProvider = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (native_credentialsProvider, JniHandleOwnership.DoNotTransfer);
			var fs = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (native_fs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSession (uri, credentialsProvider, fs, tms));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uri">URI information about the remote host</param>
		/// <param name="credentialsProvider">provider to support authentication, may be null.</param>
		/// <param name="fs">the file system abstraction which will be necessary to
		///            perform certain file system operations.</param>
		/// <param name="tms">Timeout value, in milliseconds.</param>
		/// <summary>Open (or reuse) a session to a host.</summary>
		/// <returns>a session that can contact the remote host.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshSessionFactory']/method[@name='getSession' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.transport.CredentialsProvider'] and parameter[3][@type='org.eclipse.jgit.util.FS'] and parameter[4][@type='int']]"
		[Register ("getSession", "(Lorg/eclipse/jgit/transport/URIish;Lorg/eclipse/jgit/transport/CredentialsProvider;Lorg/eclipse/jgit/util/FS;I)Lorg/eclipse/jgit/transport/RemoteSession;", "GetGetSession_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_transport_CredentialsProvider_Lorg_eclipse_jgit_util_FS_IHandler")]
		public abstract global::Org.Eclipse.Jgit.Transport.IRemoteSession GetSession (global::Org.Eclipse.Jgit.Transport.URIish uri, global::Org.Eclipse.Jgit.Transport.CredentialsProvider credentialsProvider, global::Org.Eclipse.Jgit.Util.FS fs, int tms);

		static Delegate cb_releaseSession_Lorg_eclipse_jgit_transport_RemoteSession_;
#pragma warning disable 0169
		static Delegate GetReleaseSession_Lorg_eclipse_jgit_transport_RemoteSession_Handler ()
		{
			if (cb_releaseSession_Lorg_eclipse_jgit_transport_RemoteSession_ == null)
				cb_releaseSession_Lorg_eclipse_jgit_transport_RemoteSession_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReleaseSession_Lorg_eclipse_jgit_transport_RemoteSession_);
			return cb_releaseSession_Lorg_eclipse_jgit_transport_RemoteSession_;
		}

		static void n_ReleaseSession_Lorg_eclipse_jgit_transport_RemoteSession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_session)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SshSessionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var session = (global::Org.Eclipse.Jgit.Transport.IRemoteSession)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRemoteSession> (native_session, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseSession (session);
		}
#pragma warning restore 0169

		/// <param name="session">a session previously obtained from this factory's
		///            <c>#getSession(URIish, CredentialsProvider, FS, int)</c>
		///            method.</param>
		/// <summary>Close (or recycle) a session to a host.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshSessionFactory']/method[@name='releaseSession' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RemoteSession']]"
		[Register ("releaseSession", "(Lorg/eclipse/jgit/transport/RemoteSession;)V", "GetReleaseSession_Lorg_eclipse_jgit_transport_RemoteSession_Handler")]
		public virtual unsafe void ReleaseSession (global::Org.Eclipse.Jgit.Transport.IRemoteSession session)
		{
			const string __id = "releaseSession.(Lorg/eclipse/jgit/transport/RemoteSession;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (session);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/SshSessionFactory", DoNotGenerateAcw=true)]
	internal partial class SshSessionFactoryInvoker : SshSessionFactory {
		public SshSessionFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/SshSessionFactory", typeof (SshSessionFactoryInvoker));

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

		/// <param name="uri">URI information about the remote host</param>
		/// <param name="credentialsProvider">provider to support authentication, may be null.</param>
		/// <param name="fs">the file system abstraction which will be necessary to
		///            perform certain file system operations.</param>
		/// <param name="tms">Timeout value, in milliseconds.</param>
		/// <summary>Open (or reuse) a session to a host.</summary>
		/// <returns>a session that can contact the remote host.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SshSessionFactory']/method[@name='getSession' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.transport.CredentialsProvider'] and parameter[3][@type='org.eclipse.jgit.util.FS'] and parameter[4][@type='int']]"
		[Register ("getSession", "(Lorg/eclipse/jgit/transport/URIish;Lorg/eclipse/jgit/transport/CredentialsProvider;Lorg/eclipse/jgit/util/FS;I)Lorg/eclipse/jgit/transport/RemoteSession;", "GetGetSession_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_transport_CredentialsProvider_Lorg_eclipse_jgit_util_FS_IHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IRemoteSession GetSession (global::Org.Eclipse.Jgit.Transport.URIish uri, global::Org.Eclipse.Jgit.Transport.CredentialsProvider credentialsProvider, global::Org.Eclipse.Jgit.Util.FS fs, int tms)
		{
			const string __id = "getSession.(Lorg/eclipse/jgit/transport/URIish;Lorg/eclipse/jgit/transport/CredentialsProvider;Lorg/eclipse/jgit/util/FS;I)Lorg/eclipse/jgit/transport/RemoteSession;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue ((credentialsProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentialsProvider).Handle);
				__args [2] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [3] = new JniArgumentValue (tms);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRemoteSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (credentialsProvider);
				global::System.GC.KeepAlive (fs);
			}
		}

	}
}
