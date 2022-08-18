using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport.Http {

	[Register ("org/eclipse/jgit/transport/http/HttpConnection", DoNotGenerateAcw=true)]
	public abstract class HttpConnection : Java.Lang.Object {
		internal HttpConnection ()
		{
		}

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

	[Register ("org/eclipse/jgit/transport/http/HttpConnection", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'HttpConnection' type. This type will be removed in a future release.", error: true)]
	public abstract class HttpConnectionConsts : HttpConnection {
		private HttpConnectionConsts ()
		{
		}

	}

	/// <summary>The interface of connections used during HTTP communication.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']"
	[Register ("org/eclipse/jgit/transport/http/HttpConnection", "", "Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker")]
	public partial interface IHttpConnection : IJavaObject, IJavaPeerable {
		int ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()I", "GetGetContentLengthHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> HeaderFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getHeaderFields' and count(parameter)=0]"
			[Register ("getHeaderFields", "()Ljava/util/Map;", "GetGetHeaderFieldsHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		string RequestMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getRequestMethod' and count(parameter)=0]"
			[Register ("getRequestMethod", "()Ljava/lang/String;", "GetGetRequestMethodHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setRequestMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestMethod", "(Ljava/lang/String;)V", "GetSetRequestMethod_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			set; 
		}

		int ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		string ResponseMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getResponseMessage' and count(parameter)=0]"
			[Register ("getResponseMessage", "()Ljava/lang/String;", "GetGetResponseMessageHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Java.Net.URL URL {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getURL' and count(parameter)=0]"
			[Register ("getURL", "()Ljava/net/URL;", "GetGetURLHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='configure' and count(parameter)=3 and parameter[1][@type='javax.net.ssl.KeyManager[]'] and parameter[2][@type='javax.net.ssl.TrustManager[]'] and parameter[3][@type='java.security.SecureRandom']]"
		/// <param name="km">the keymanager managing the key material used to authenticate
		///            the local SSLSocket to its peer</param>
		/// <param name="tm">the trustmanager responsible for managing the trust material
		///            that is used when making trust decisions, and for deciding
		///            whether credentials presented by a peer should be accepted.</param>
		/// <param name="random">the source of randomness for this generator or null. See
		///            <c>SSLContext#init(KeyManager[], TrustManager[], SecureRandom)</c></param>
		/// <summary>Configure the connection so that it can be used for https communication.</summary>
		[Register ("configure", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V", "GetConfigure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_Handler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void Configure (global::Javax.Net.Ssl.IKeyManager[] km, global::Javax.Net.Ssl.ITrustManager[] tm, global::Java.Security.SecureRandom random);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void Connect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='getHeaderField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		/// <param name="name">the name of a header field.</param>
		/// <returns>the value of the named header field, or &lt;code&gt;null&lt;/code&gt; if
		///         there is no such field in the header.</returns>
		[Register ("getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetHeaderField_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		string GetHeaderField (string name);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setChunkedStreamingMode' and count(parameter)=1 and parameter[1][@type='int']]"
		/// <param name="chunklen">The number of bytes to write in each chunk. If chunklen is
		///            less than or equal to zero, a default value will be used.</param>
		[Register ("setChunkedStreamingMode", "(I)V", "GetSetChunkedStreamingMode_IHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void SetChunkedStreamingMode (int chunklen);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		/// <param name="timeout">an &lt;code&gt;int&lt;/code&gt; that specifies the connect timeout value
		///            in milliseconds</param>
		[Register ("setConnectTimeout", "(I)V", "GetSetConnectTimeout_IHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void SetConnectTimeout (int timeout);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setDoOutput' and count(parameter)=1 and parameter[1][@type='boolean']]"
		/// <param name="dooutput">the new value.</param>
		[Register ("setDoOutput", "(Z)V", "GetSetDoOutput_ZHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void SetDoOutput (bool dooutput);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setFixedLengthStreamingMode' and count(parameter)=1 and parameter[1][@type='int']]"
		/// <param name="contentLength">The number of bytes which will be written to the OutputStream.</param>
		[Register ("setFixedLengthStreamingMode", "(I)V", "GetSetFixedLengthStreamingMode_IHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void SetFixedLengthStreamingMode (int contentLength);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setHostnameVerifier' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.HostnameVerifier']]"
		/// <param name="hostnameverifier">hostnameverifier</param>
		/// <summary>Set the <c>HostnameVerifier</c> used during https communication</summary>
		[Register ("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", "GetSetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_Handler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void SetHostnameVerifier (global::Javax.Net.Ssl.IHostnameVerifier hostnameverifier);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setInstanceFollowRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
		/// <param name="followRedirects">a &lt;code&gt;boolean&lt;/code&gt; indicating whether or not to follow
		///            HTTP redirects.</param>
		[Register ("setInstanceFollowRedirects", "(Z)V", "GetSetInstanceFollowRedirects_ZHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void SetInstanceFollowRedirects (bool followRedirects);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setReadTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		/// <param name="timeout">an &lt;code&gt;int&lt;/code&gt; that specifies the timeout value to be
		///            used in milliseconds</param>
		[Register ("setReadTimeout", "(I)V", "GetSetReadTimeout_IHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void SetReadTimeout (int timeout);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		/// <param name="key">the keyword by which the request is known (e.g., "
		///            &lt;code&gt;Accept&lt;/code&gt;").</param>
		/// <param name="value">the value associated with it.</param>
		[Register ("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void SetRequestProperty (string key, string value);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='setUseCaches' and count(parameter)=1 and parameter[1][@type='boolean']]"
		/// <param name="usecaches">a &lt;code&gt;boolean&lt;/code&gt; indicating whether or not to allow
		///            caching</param>
		[Register ("setUseCaches", "(Z)V", "GetSetUseCaches_ZHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		void SetUseCaches (bool usecaches);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.http']/interface[@name='HttpConnection']/method[@name='usingProxy' and count(parameter)=0]"
		/// <returns>a boolean indicating if the connection is using a proxy.</returns>
		[Register ("usingProxy", "()Z", "GetUsingProxyHandler:Org.Eclipse.Jgit.Transport.Http.IHttpConnectionInvoker, AndroidBindableLibrary")]
		bool UsingProxy ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/http/HttpConnection", DoNotGenerateAcw=true)]
	internal partial class IHttpConnectionInvoker : global::Java.Lang.Object, IHttpConnection {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/http/HttpConnection", typeof (IHttpConnectionInvoker));

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

		public static IHttpConnection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpConnection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.http.HttpConnection'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		IntPtr id_getContentLength;
		public unsafe int ContentLength {
			get {
				if (id_getContentLength == IntPtr.Zero)
					id_getContentLength = JNIEnv.GetMethodID (class_ref, "getContentLength", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getContentLength);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		IntPtr id_getContentType;
		public unsafe string ContentType {
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.HeaderFields);
		}
#pragma warning restore 0169

		IntPtr id_getHeaderFields;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> HeaderFields {
			get {
				if (id_getHeaderFields == IntPtr.Zero)
					id_getHeaderFields = JNIEnv.GetMethodID (class_ref, "getHeaderFields", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderFields), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		IntPtr id_getInputStream;
		public unsafe global::System.IO.Stream InputStream {
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		IntPtr id_getOutputStream;
		public unsafe global::System.IO.Stream OutputStream {
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
			__this.RequestMethod = method;
		}
#pragma warning restore 0169

		IntPtr id_getRequestMethod;
		IntPtr id_setRequestMethod_Ljava_lang_String_;
		public unsafe string RequestMethod {
			get {
				if (id_getRequestMethod == IntPtr.Zero)
					id_getRequestMethod = JNIEnv.GetMethodID (class_ref, "getRequestMethod", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestMethod), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setRequestMethod_Ljava_lang_String_ == IntPtr.Zero)
					id_setRequestMethod_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestMethod", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString ((string)value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestMethod_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseCode;
		}
#pragma warning restore 0169

		IntPtr id_getResponseCode;
		public unsafe int ResponseCode {
			get {
				if (id_getResponseCode == IntPtr.Zero)
					id_getResponseCode = JNIEnv.GetMethodID (class_ref, "getResponseCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getResponseCode);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseMessage);
		}
#pragma warning restore 0169

		IntPtr id_getResponseMessage;
		public unsafe string ResponseMessage {
			get {
				if (id_getResponseMessage == IntPtr.Zero)
					id_getResponseMessage = JNIEnv.GetMethodID (class_ref, "getResponseMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseMessage), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.URL);
		}
#pragma warning restore 0169

		IntPtr id_getURL;
		public unsafe global::Java.Net.URL URL {
			get {
				if (id_getURL == IntPtr.Zero)
					id_getURL = JNIEnv.GetMethodID (class_ref, "getURL", "()Ljava/net/URL;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getURL), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		IntPtr id_configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_;
		public unsafe void Configure (global::Javax.Net.Ssl.IKeyManager[] km, global::Javax.Net.Ssl.ITrustManager[] tm, global::Java.Security.SecureRandom random)
		{
			if (id_configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_ == IntPtr.Zero)
				id_configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_ = JNIEnv.GetMethodID (class_ref, "configure", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V");
			IntPtr native_km = JNIEnv.NewArray (km);
			IntPtr native_tm = JNIEnv.NewArray (tm);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_km);
			__args [1] = new JValue (native_tm);
			__args [2] = new JValue ((random == null) ? IntPtr.Zero : ((global::Java.Lang.Object) random).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configure_arrayLjavax_net_ssl_KeyManager_arrayLjavax_net_ssl_TrustManager_Ljava_security_SecureRandom_, __args);
			if (km != null) {
				JNIEnv.CopyArray (native_km, km);
				JNIEnv.DeleteLocalRef (native_km);
			}
			if (tm != null) {
				JNIEnv.CopyArray (native_tm, tm);
				JNIEnv.DeleteLocalRef (native_tm);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		IntPtr id_connect;
		public unsafe void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetHeaderField (name));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHeaderField_Ljava_lang_String_;
		public unsafe string GetHeaderField (string name)
		{
			if (id_getHeaderField_Ljava_lang_String_ == IntPtr.Zero)
				id_getHeaderField_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_name = JNIEnv.NewString ((string)name);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_name);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderField_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChunkedStreamingMode (chunklen);
		}
#pragma warning restore 0169

		IntPtr id_setChunkedStreamingMode_I;
		public unsafe void SetChunkedStreamingMode (int chunklen)
		{
			if (id_setChunkedStreamingMode_I == IntPtr.Zero)
				id_setChunkedStreamingMode_I = JNIEnv.GetMethodID (class_ref, "setChunkedStreamingMode", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (chunklen);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChunkedStreamingMode_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectTimeout (timeout);
		}
#pragma warning restore 0169

		IntPtr id_setConnectTimeout_I;
		public unsafe void SetConnectTimeout (int timeout)
		{
			if (id_setConnectTimeout_I == IntPtr.Zero)
				id_setConnectTimeout_I = JNIEnv.GetMethodID (class_ref, "setConnectTimeout", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (timeout);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectTimeout_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDoOutput (dooutput);
		}
#pragma warning restore 0169

		IntPtr id_setDoOutput_Z;
		public unsafe void SetDoOutput (bool dooutput)
		{
			if (id_setDoOutput_Z == IntPtr.Zero)
				id_setDoOutput_Z = JNIEnv.GetMethodID (class_ref, "setDoOutput", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (dooutput);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDoOutput_Z, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFixedLengthStreamingMode (contentLength);
		}
#pragma warning restore 0169

		IntPtr id_setFixedLengthStreamingMode_I;
		public unsafe void SetFixedLengthStreamingMode (int contentLength)
		{
			if (id_setFixedLengthStreamingMode_I == IntPtr.Zero)
				id_setFixedLengthStreamingMode_I = JNIEnv.GetMethodID (class_ref, "setFixedLengthStreamingMode", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (contentLength);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFixedLengthStreamingMode_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hostnameverifier = (global::Javax.Net.Ssl.IHostnameVerifier)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (native_hostnameverifier, JniHandleOwnership.DoNotTransfer);
			__this.SetHostnameVerifier (hostnameverifier);
		}
#pragma warning restore 0169

		IntPtr id_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
		public unsafe void SetHostnameVerifier (global::Javax.Net.Ssl.IHostnameVerifier hostnameverifier)
		{
			if (id_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ == IntPtr.Zero)
				id_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ = JNIEnv.GetMethodID (class_ref, "setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((hostnameverifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hostnameverifier).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInstanceFollowRedirects (followRedirects);
		}
#pragma warning restore 0169

		IntPtr id_setInstanceFollowRedirects_Z;
		public unsafe void SetInstanceFollowRedirects (bool followRedirects)
		{
			if (id_setInstanceFollowRedirects_Z == IntPtr.Zero)
				id_setInstanceFollowRedirects_Z = JNIEnv.GetMethodID (class_ref, "setInstanceFollowRedirects", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (followRedirects);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInstanceFollowRedirects_Z, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReadTimeout (timeout);
		}
#pragma warning restore 0169

		IntPtr id_setReadTimeout_I;
		public unsafe void SetReadTimeout (int timeout)
		{
			if (id_setReadTimeout_I == IntPtr.Zero)
				id_setReadTimeout_I = JNIEnv.GetMethodID (class_ref, "setReadTimeout", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (timeout);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReadTimeout_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestProperty (key, value);
		}
#pragma warning restore 0169

		IntPtr id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetRequestProperty (string key, string value)
		{
			if (id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_key = JNIEnv.NewString ((string)key);
			IntPtr native_value = JNIEnv.NewString ((string)value);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_key);
			__args [1] = new JValue (native_value);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_key);
			JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseCaches (usecaches);
		}
#pragma warning restore 0169

		IntPtr id_setUseCaches_Z;
		public unsafe void SetUseCaches (bool usecaches)
		{
			if (id_setUseCaches_Z == IntPtr.Zero)
				id_setUseCaches_Z = JNIEnv.GetMethodID (class_ref, "setUseCaches", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (usecaches);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUseCaches_Z, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UsingProxy ();
		}
#pragma warning restore 0169

		IntPtr id_usingProxy;
		public unsafe bool UsingProxy ()
		{
			if (id_usingProxy == IntPtr.Zero)
				id_usingProxy = JNIEnv.GetMethodID (class_ref, "usingProxy", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_usingProxy);
		}

	}
}
