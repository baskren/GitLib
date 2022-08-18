using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport.Http {

	/// <summary>The interface of a factory returning <c>HttpConnection</c></summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnectionFactory']"
	[Register ("org/eclipse/jgit/transport/http/HttpConnectionFactory", "", "Org.Eclipse.Jgit.Transport.Http.IHttpConnectionFactoryInvoker")]
	public partial interface IHttpConnectionFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnectionFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		/// <param name="url">url</param>
		/// <summary>Creates a new connection to a destination defined by a <c>URL</c></summary>
		/// <returns>a <c>HttpConnection</c></returns>
		[Register ("create", "(Ljava/net/URL;)Lorg/eclipse/jgit/transport/http/HttpConnection;", "GetCreate_Ljava_net_URL_Handler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionFactoryInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection Create (global::Java.Net.URL url);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnectionFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.net.Proxy']]"
		/// <param name="url">url</param>
		/// <param name="proxy">the proxy to be used</param>
		/// <summary>Creates a new connection to a destination defined by a <c>URL</c> using
		/// a proxy</summary>
		/// <returns>a <c>HttpConnection</c></returns>
		[Register ("create", "(Ljava/net/URL;Ljava/net/Proxy;)Lorg/eclipse/jgit/transport/http/HttpConnection;", "GetCreate_Ljava_net_URL_Ljava_net_Proxy_Handler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionFactoryInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection Create (global::Java.Net.URL url, global::Java.Net.Proxy proxy);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/http/HttpConnectionFactory", DoNotGenerateAcw=true)]
	internal partial class IHttpConnectionFactoryInvoker : global::Java.Lang.Object, IHttpConnectionFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/http/HttpConnectionFactory", typeof (IHttpConnectionFactoryInvoker));

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

		public static IHttpConnectionFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpConnectionFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.http.HttpConnectionFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpConnectionFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (url));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_create_Ljava_net_URL_;
		public unsafe global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection Create (global::Java.Net.URL url)
		{
			if (id_create_Ljava_net_URL_ == IntPtr.Zero)
				id_create_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "create", "(Ljava/net/URL;)Lorg/eclipse/jgit/transport/http/HttpConnection;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			var proxy = global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (native_proxy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (url, proxy));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_create_Ljava_net_URL_Ljava_net_Proxy_;
		public unsafe global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection Create (global::Java.Net.URL url, global::Java.Net.Proxy proxy)
		{
			if (id_create_Ljava_net_URL_Ljava_net_Proxy_ == IntPtr.Zero)
				id_create_Ljava_net_URL_Ljava_net_Proxy_ = JNIEnv.GetMethodID (class_ref, "create", "(Ljava/net/URL;Ljava/net/Proxy;)Lorg/eclipse/jgit/transport/http/HttpConnection;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
			__args [1] = new JValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Ljava_net_URL_Ljava_net_Proxy_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
