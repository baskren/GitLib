using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport.Http {

	/// <summary>A factory returning instances of <c>JDKHttpConnection</c></summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnectionFactory']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/http/JDKHttpConnectionFactory", DoNotGenerateAcw=true)]
	public partial class JDKHttpConnectionFactory : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.Http.IHttpConnectionFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/http/JDKHttpConnectionFactory", typeof (JDKHttpConnectionFactory));

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

		protected JDKHttpConnectionFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnectionFactory']/constructor[@name='JDKHttpConnectionFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JDKHttpConnectionFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_create_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetCreate_Ljava_net_URL_Handler ()
		{
			if (cb_create_Ljava_net_URL_ == null)
				cb_create_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Create_Ljava_net_URL_);
			return cb_create_Ljava_net_URL_;
		}

		static IntPtr n_Create_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (url));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnectionFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("create", "(Ljava/net/URL;)Lorg/eclipse/jgit/transport/http/HttpConnection;", "GetCreate_Ljava_net_URL_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection Create (global::Java.Net.URL url)
		{
			const string __id = "create.(Ljava/net/URL;)Lorg/eclipse/jgit/transport/http/HttpConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (url);
			}
		}

		static Delegate cb_create_Ljava_net_URL_Ljava_net_Proxy_;
#pragma warning disable 0169
		static Delegate GetCreate_Ljava_net_URL_Ljava_net_Proxy_Handler ()
		{
			if (cb_create_Ljava_net_URL_Ljava_net_Proxy_ == null)
				cb_create_Ljava_net_URL_Ljava_net_Proxy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Create_Ljava_net_URL_Ljava_net_Proxy_);
			return cb_create_Ljava_net_URL_Ljava_net_Proxy_;
		}

		static IntPtr n_Create_Ljava_net_URL_Ljava_net_Proxy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_proxy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			var proxy = global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (native_proxy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (url, proxy));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnectionFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.net.Proxy']]"
		[Register ("create", "(Ljava/net/URL;Ljava/net/Proxy;)Lorg/eclipse/jgit/transport/http/HttpConnection;", "GetCreate_Ljava_net_URL_Ljava_net_Proxy_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection Create (global::Java.Net.URL url, global::Java.Net.Proxy proxy)
		{
			const string __id = "create.(Ljava/net/URL;Ljava/net/Proxy;)Lorg/eclipse/jgit/transport/http/HttpConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (url);
				global::System.GC.KeepAlive (proxy);
			}
		}

	}
}
