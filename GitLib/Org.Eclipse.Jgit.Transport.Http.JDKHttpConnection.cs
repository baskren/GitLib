using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport.Http {

	/// <summary>A <c>HttpConnection</c> which simply delegates every call to a
	/// <c>HttpURLConnection</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/http/JDKHttpConnection", DoNotGenerateAcw=true)]
	public partial class JDKHttpConnection : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection {
		public static class InterfaceConsts {
			// The following are fields from: org.eclipse.jgit.transport.http.HttpConnection

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/field[@name='HTTP_FORBIDDEN']"
			[Register ("HTTP_FORBIDDEN")]
			public const int HttpForbidden = (int) 403;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/field[@name='HTTP_NOT_FOUND']"
			[Register ("HTTP_NOT_FOUND")]
			public const int HttpNotFound = (int) 404;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/field[@name='HTTP_OK']"
			[Register ("HTTP_OK")]
			public const int HttpOk = (int) 200;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/field[@name='HTTP_UNAUTHORIZED']"
			[Register ("HTTP_UNAUTHORIZED")]
			public const int HttpUnauthorized = (int) 401;

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/http/JDKHttpConnection", typeof (JDKHttpConnection));

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

		protected JDKHttpConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="url">url</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/constructor[@name='JDKHttpConnection' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/net/URL;)V", "")]
		protected unsafe JDKHttpConnection (global::Java.Net.URL url) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URL;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (url);
			}
		}

		/// <param name="url">url</param>
		/// <param name="proxy">proxy</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/constructor[@name='JDKHttpConnection' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.net.Proxy']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/net/Proxy;)V", "")]
		protected unsafe JDKHttpConnection (global::Java.Net.URL url, global::Java.Net.Proxy proxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URL;Ljava/net/Proxy;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (url);
				global::System.GC.KeepAlive (proxy);
			}
		}

		static Delegate cb_getContentLength;
#pragma warning disable 0169
		static Delegate GetGetContentLengthHandler ()
		{
			if (cb_getContentLength == null)
				cb_getContentLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetContentLength);
			return cb_getContentLength;
		}

		static int n_GetContentLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		public virtual unsafe int ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()I", "GetGetContentLengthHandler")]
			get {
				const string __id = "getContentLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				const string __id = "getContentType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderFields;
#pragma warning disable 0169
		static Delegate GetGetHeaderFieldsHandler ()
		{
			if (cb_getHeaderFields == null)
				cb_getHeaderFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHeaderFields);
			return cb_getHeaderFields;
		}

		static IntPtr n_GetHeaderFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.HeaderFields);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> HeaderFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getHeaderFields' and count(parameter)=0]"
			[Register ("getHeaderFields", "()Ljava/util/Map;", "GetGetHeaderFieldsHandler")]
			get {
				const string __id = "getHeaderFields.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				const string __id = "getInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				const string __id = "getOutputStream.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestMethod;
#pragma warning disable 0169
		static Delegate GetGetRequestMethodHandler ()
		{
			if (cb_getRequestMethod == null)
				cb_getRequestMethod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestMethod);
			return cb_getRequestMethod;
		}

		static IntPtr n_GetRequestMethod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestMethod);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestMethod_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestMethod_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestMethod_Ljava_lang_String_ == null)
				cb_setRequestMethod_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestMethod_Ljava_lang_String_);
			return cb_setRequestMethod_Ljava_lang_String_;
		}

		static void n_SetRequestMethod_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_method)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
			__this.RequestMethod = method;
		}
#pragma warning restore 0169

		public virtual unsafe string RequestMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getRequestMethod' and count(parameter)=0]"
			[Register ("getRequestMethod", "()Ljava/lang/String;", "GetGetRequestMethodHandler")]
			get {
				const string __id = "getRequestMethod.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setRequestMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestMethod", "(Ljava/lang/String;)V", "GetSetRequestMethod_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRequestMethod.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseCode;
#pragma warning disable 0169
		static Delegate GetGetResponseCodeHandler ()
		{
			if (cb_getResponseCode == null)
				cb_getResponseCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetResponseCode);
			return cb_getResponseCode;
		}

		static int n_GetResponseCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseCode;
		}
#pragma warning restore 0169

		public virtual unsafe int ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler")]
			get {
				const string __id = "getResponseCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getResponseMessage;
#pragma warning disable 0169
		static Delegate GetGetResponseMessageHandler ()
		{
			if (cb_getResponseMessage == null)
				cb_getResponseMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseMessage);
			return cb_getResponseMessage;
		}

		static IntPtr n_GetResponseMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseMessage);
		}
#pragma warning restore 0169

		public virtual unsafe string ResponseMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getResponseMessage' and count(parameter)=0]"
			[Register ("getResponseMessage", "()Ljava/lang/String;", "GetGetResponseMessageHandler")]
			get {
				const string __id = "getResponseMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getURL;
#pragma warning disable 0169
		static Delegate GetGetURLHandler ()
		{
			if (cb_getURL == null)
				cb_getURL = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetURL);
			return cb_getURL;
		}

		static IntPtr n_GetURL (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.URL);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.URL URL {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getURL' and count(parameter)=0]"
			[Register ("getURL", "()Ljava/net/URL;", "GetGetURLHandler")]
			get {
				const string __id = "getURL.()Ljava/net/URL;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_;
#pragma warning disable 0169
		static Delegate GetConfigure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_Handler ()
		{
			if (cb_configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_ == null)
				cb_configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_);
			return cb_configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_;
		}

		static void n_Configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_km, IntPtr native_tm, IntPtr native_random)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var km = (global::Javax.Net.Ssl.IKeyManager[]) JNIEnv.GetArray (native_km, JniHandleOwnership.DoNotTransfer, typeof (global::Javax.Net.Ssl.IKeyManager));
			var tm = (global::Javax.Net.Ssl.ITrustManager[]) JNIEnv.GetArray (native_tm, JniHandleOwnership.DoNotTransfer, typeof (global::Javax.Net.Ssl.ITrustManager));
			var random = global::Java.Lang.Object.GetObject<global::Java.Security.SecureRandom> (native_random, JniHandleOwnership.DoNotTransfer);
			__this.Configure (km, tm, random);
			if (km != null)
				JNIEnv.CopyArray (km, native_km);
			if (tm != null)
				JNIEnv.CopyArray (tm, native_tm);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='configure' and count(parameter)=3 and parameter[1][@type='javax.net.ssl.KeyManager[]'] and parameter[2][@type='javax.net.ssl.TrustManager[]'] and parameter[3][@type='java.security.SecureRandom']]"
		[Register ("configure", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V", "GetConfigure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_Handler")]
		public virtual unsafe void Configure (global::Javax.Net.Ssl.IKeyManager[] km, global::Javax.Net.Ssl.ITrustManager[] tm, global::Java.Security.SecureRandom random)
		{
			const string __id = "configure.([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V";
			IntPtr native_km = JNIEnv.NewArray (km);
			IntPtr native_tm = JNIEnv.NewArray (tm);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_km);
				__args [1] = new JniArgumentValue (native_tm);
				__args [2] = new JniArgumentValue ((random == null) ? IntPtr.Zero : ((global::Java.Lang.Object) random).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (km != null) {
					JNIEnv.CopyArray (native_km, km);
					JNIEnv.DeleteLocalRef (native_km);
				}
				if (tm != null) {
					JNIEnv.CopyArray (native_tm, tm);
					JNIEnv.DeleteLocalRef (native_tm);
				}
				global::System.GC.KeepAlive (km);
				global::System.GC.KeepAlive (tm);
				global::System.GC.KeepAlive (random);
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual unsafe void Connect ()
		{
			const string __id = "connect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getHeaderField_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHeaderField_Ljava_lang_String_Handler ()
		{
			if (cb_getHeaderField_Ljava_lang_String_ == null)
				cb_getHeaderField_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetHeaderField_Ljava_lang_String_);
			return cb_getHeaderField_Ljava_lang_String_;
		}

		static IntPtr n_GetHeaderField_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetHeaderField (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='getHeaderField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetHeaderField_Ljava_lang_String_Handler")]
		public virtual unsafe string GetHeaderField (string name)
		{
			const string __id = "getHeaderField.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setChunkedStreamingMode_I;
#pragma warning disable 0169
		static Delegate GetSetChunkedStreamingMode_IHandler ()
		{
			if (cb_setChunkedStreamingMode_I == null)
				cb_setChunkedStreamingMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetChunkedStreamingMode_I);
			return cb_setChunkedStreamingMode_I;
		}

		static void n_SetChunkedStreamingMode_I (IntPtr jnienv, IntPtr native__this, int chunklen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChunkedStreamingMode (chunklen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setChunkedStreamingMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChunkedStreamingMode", "(I)V", "GetSetChunkedStreamingMode_IHandler")]
		public virtual unsafe void SetChunkedStreamingMode (int chunklen)
		{
			const string __id = "setChunkedStreamingMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (chunklen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setConnectTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetConnectTimeout_IHandler ()
		{
			if (cb_setConnectTimeout_I == null)
				cb_setConnectTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetConnectTimeout_I);
			return cb_setConnectTimeout_I;
		}

		static void n_SetConnectTimeout_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectTimeout (timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConnectTimeout", "(I)V", "GetSetConnectTimeout_IHandler")]
		public virtual unsafe void SetConnectTimeout (int timeout)
		{
			const string __id = "setConnectTimeout.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDoOutput_Z;
#pragma warning disable 0169
		static Delegate GetSetDoOutput_ZHandler ()
		{
			if (cb_setDoOutput_Z == null)
				cb_setDoOutput_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDoOutput_Z);
			return cb_setDoOutput_Z;
		}

		static void n_SetDoOutput_Z (IntPtr jnienv, IntPtr native__this, bool dooutput)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDoOutput (dooutput);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setDoOutput' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDoOutput", "(Z)V", "GetSetDoOutput_ZHandler")]
		public virtual unsafe void SetDoOutput (bool dooutput)
		{
			const string __id = "setDoOutput.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dooutput);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFixedLengthStreamingMode_I;
#pragma warning disable 0169
		static Delegate GetSetFixedLengthStreamingMode_IHandler ()
		{
			if (cb_setFixedLengthStreamingMode_I == null)
				cb_setFixedLengthStreamingMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetFixedLengthStreamingMode_I);
			return cb_setFixedLengthStreamingMode_I;
		}

		static void n_SetFixedLengthStreamingMode_I (IntPtr jnienv, IntPtr native__this, int contentLength)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFixedLengthStreamingMode (contentLength);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setFixedLengthStreamingMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFixedLengthStreamingMode", "(I)V", "GetSetFixedLengthStreamingMode_IHandler")]
		public virtual unsafe void SetFixedLengthStreamingMode (int contentLength)
		{
			const string __id = "setFixedLengthStreamingMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (contentLength);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
#pragma warning disable 0169
		static Delegate GetSetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_Handler ()
		{
			if (cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ == null)
				cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_);
			return cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
		}

		static void n_SetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostnameverifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hostnameverifier = (global::Javax.Net.Ssl.IHostnameVerifier)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (native_hostnameverifier, JniHandleOwnership.DoNotTransfer);
			__this.SetHostnameVerifier (hostnameverifier);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setHostnameVerifier' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.HostnameVerifier']]"
		[Register ("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", "GetSetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_Handler")]
		public virtual unsafe void SetHostnameVerifier (global::Javax.Net.Ssl.IHostnameVerifier hostnameverifier)
		{
			const string __id = "setHostnameVerifier.(Ljavax/net/ssl/HostnameVerifier;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((hostnameverifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hostnameverifier).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (hostnameverifier);
			}
		}

		static Delegate cb_setInstanceFollowRedirects_Z;
#pragma warning disable 0169
		static Delegate GetSetInstanceFollowRedirects_ZHandler ()
		{
			if (cb_setInstanceFollowRedirects_Z == null)
				cb_setInstanceFollowRedirects_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetInstanceFollowRedirects_Z);
			return cb_setInstanceFollowRedirects_Z;
		}

		static void n_SetInstanceFollowRedirects_Z (IntPtr jnienv, IntPtr native__this, bool followRedirects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInstanceFollowRedirects (followRedirects);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setInstanceFollowRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInstanceFollowRedirects", "(Z)V", "GetSetInstanceFollowRedirects_ZHandler")]
		public virtual unsafe void SetInstanceFollowRedirects (bool followRedirects)
		{
			const string __id = "setInstanceFollowRedirects.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (followRedirects);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setReadTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetReadTimeout_IHandler ()
		{
			if (cb_setReadTimeout_I == null)
				cb_setReadTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetReadTimeout_I);
			return cb_setReadTimeout_I;
		}

		static void n_SetReadTimeout_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReadTimeout (timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setReadTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReadTimeout", "(I)V", "GetSetReadTimeout_IHandler")]
		public virtual unsafe void SetReadTimeout (int timeout)
		{
			const string __id = "setReadTimeout.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestProperty (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRequestProperty (string key, string value)
		{
			const string __id = "setRequestProperty.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString ((string)key);
			IntPtr native_value = JNIEnv.NewString ((string)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setUseCaches_Z;
#pragma warning disable 0169
		static Delegate GetSetUseCaches_ZHandler ()
		{
			if (cb_setUseCaches_Z == null)
				cb_setUseCaches_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseCaches_Z);
			return cb_setUseCaches_Z;
		}

		static void n_SetUseCaches_Z (IntPtr jnienv, IntPtr native__this, bool usecaches)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseCaches (usecaches);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='setUseCaches' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseCaches", "(Z)V", "GetSetUseCaches_ZHandler")]
		public virtual unsafe void SetUseCaches (bool usecaches)
		{
			const string __id = "setUseCaches.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (usecaches);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_usingProxy;
#pragma warning disable 0169
		static Delegate GetUsingProxyHandler ()
		{
			if (cb_usingProxy == null)
				cb_usingProxy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_UsingProxy);
			return cb_usingProxy;
		}

		static bool n_UsingProxy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.JDKHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UsingProxy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/class[@name='JDKHttpConnection']/method[@name='usingProxy' and count(parameter)=0]"
		[Register ("usingProxy", "()Z", "GetUsingProxyHandler")]
		public virtual unsafe bool UsingProxy ()
		{
			const string __id = "usingProxy.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
