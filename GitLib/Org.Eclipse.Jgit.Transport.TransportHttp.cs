using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Transport over HTTP and FTP protocols.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportHttp']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TransportHttp", DoNotGenerateAcw=true)]
	public partial class TransportHttp : global::Org.Eclipse.Jgit.Transport.HttpTransport, global::Org.Eclipse.Jgit.Transport.IPackTransport, global::Org.Eclipse.Jgit.Transport.IWalkTransport {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TransportHttp", typeof (TransportHttp));

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

		protected TransportHttp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportHttp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportHttp']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_httpOpen_Ljava_lang_String_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetHttpOpen_Ljava_lang_String_Ljava_net_URL_Handler ()
		{
			if (cb_httpOpen_Ljava_lang_String_Ljava_net_URL_ == null)
				cb_httpOpen_Ljava_lang_String_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_HttpOpen_Ljava_lang_String_Ljava_net_URL_);
			return cb_httpOpen_Ljava_lang_String_Ljava_net_URL_;
		}

		static IntPtr n_HttpOpen_Ljava_lang_String_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_method, IntPtr native_u)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportHttp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
			var u = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_u, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HttpOpen (method, u));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="method">method</param>
		/// <param name="u">u</param>
		/// <summary>Open an HTTP connection.</summary>
		/// <returns>the connection</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportHttp']/method[@name='httpOpen' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.net.URL']]"
		[Register ("httpOpen", "(Ljava/lang/String;Ljava/net/URL;)Lorg/eclipse/jgit/transport/http/HttpConnection;", "GetHttpOpen_Ljava_lang_String_Ljava_net_URL_Handler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection HttpOpen (string method, global::Java.Net.URL u)
		{
			const string __id = "httpOpen.(Ljava/lang/String;Ljava/net/URL;)Lorg/eclipse/jgit/transport/http/HttpConnection;";
			IntPtr native_method = JNIEnv.NewString ((string)method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_method);
				__args [1] = new JniArgumentValue ((u == null) ? IntPtr.Zero : ((global::Java.Lang.Object) u).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
				global::System.GC.KeepAlive (u);
			}
		}

		static Delegate cb_openFetch;
#pragma warning disable 0169
		static Delegate GetOpenFetchHandler ()
		{
			if (cb_openFetch == null)
				cb_openFetch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenFetch);
			return cb_openFetch;
		}

		static IntPtr n_OpenFetch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportHttp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenFetch ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportHttp']/method[@name='openFetch' and count(parameter)=0]"
		[Register ("openFetch", "()Lorg/eclipse/jgit/transport/FetchConnection;", "GetOpenFetchHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IFetchConnection OpenFetch ()
		{
			const string __id = "openFetch.()Lorg/eclipse/jgit/transport/FetchConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_openPush;
#pragma warning disable 0169
		static Delegate GetOpenPushHandler ()
		{
			if (cb_openPush == null)
				cb_openPush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenPush);
			return cb_openPush;
		}

		static IntPtr n_OpenPush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportHttp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenPush ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportHttp']/method[@name='openPush' and count(parameter)=0]"
		[Register ("openPush", "()Lorg/eclipse/jgit/transport/PushConnection;", "GetOpenPushHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IPushConnection OpenPush ()
		{
			const string __id = "openPush.()Lorg/eclipse/jgit/transport/PushConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAdditionalHeaders_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetAdditionalHeaders_Ljava_util_Map_Handler ()
		{
			if (cb_setAdditionalHeaders_Ljava_util_Map_ == null)
				cb_setAdditionalHeaders_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAdditionalHeaders_Ljava_util_Map_);
			return cb_setAdditionalHeaders_Ljava_util_Map_;
		}

		static void n_SetAdditionalHeaders_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_headers)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportHttp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			__this.SetAdditionalHeaders (headers);
		}
#pragma warning restore 0169

		/// <param name="headers">a map of name:values that are to be set as headers on the HTTP
		///            connection</param>
		/// <summary>Set additional headers on the HTTP connection</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportHttp']/method[@name='setAdditionalHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setAdditionalHeaders", "(Ljava/util/Map;)V", "GetSetAdditionalHeaders_Ljava_util_Map_Handler")]
		public virtual unsafe void SetAdditionalHeaders (global::System.Collections.Generic.IDictionary<string, string> headers)
		{
			const string __id = "setAdditionalHeaders.(Ljava/util/Map;)V";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headers);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
				global::System.GC.KeepAlive (headers);
			}
		}

		static Delegate cb_setUseSmartHttp_Z;
#pragma warning disable 0169
		static Delegate GetSetUseSmartHttp_ZHandler ()
		{
			if (cb_setUseSmartHttp_Z == null)
				cb_setUseSmartHttp_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseSmartHttp_Z);
			return cb_setUseSmartHttp_Z;
		}

		static void n_SetUseSmartHttp_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportHttp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseSmartHttp (on);
		}
#pragma warning restore 0169

		/// <param name="on">if <c>true</c> (default), smart HTTP is enabled.</param>
		/// <summary>Toggle whether or not smart HTTP transport should be used.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportHttp']/method[@name='setUseSmartHttp' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseSmartHttp", "(Z)V", "GetSetUseSmartHttp_ZHandler")]
		public virtual unsafe void SetUseSmartHttp (bool on)
		{
			const string __id = "setUseSmartHttp.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
