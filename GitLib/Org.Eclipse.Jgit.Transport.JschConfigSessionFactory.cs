using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>The base session factory that loads known hosts and private keys from
	/// &lt;code&gt;$HOME/.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='JschConfigSessionFactory']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/JschConfigSessionFactory", DoNotGenerateAcw=true)]
	public abstract partial class JschConfigSessionFactory : global::Org.Eclipse.Jgit.Transport.SshSessionFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/JschConfigSessionFactory", typeof (JschConfigSessionFactory));

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

		protected JschConfigSessionFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='JschConfigSessionFactory']/constructor[@name='JschConfigSessionFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JschConfigSessionFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.JschConfigSessionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			var credentialsProvider = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (native_credentialsProvider, JniHandleOwnership.DoNotTransfer);
			var fs = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (native_fs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSession (uri, credentialsProvider, fs, tms));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='JschConfigSessionFactory']/method[@name='getSession' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.transport.CredentialsProvider'] and parameter[3][@type='org.eclipse.jgit.util.FS'] and parameter[4][@type='int']]"
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
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRemoteSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (credentialsProvider);
				global::System.GC.KeepAlive (fs);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/JschConfigSessionFactory", DoNotGenerateAcw=true)]
	internal partial class JschConfigSessionFactoryInvoker : JschConfigSessionFactory {
		public JschConfigSessionFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/JschConfigSessionFactory", typeof (JschConfigSessionFactoryInvoker));

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

	}
}
