using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Extra utilities to support usage of HTTP.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/HttpSupport", DoNotGenerateAcw=true)]
	public partial class HttpSupport : global::Java.Lang.Object {
		/// <summary>The <c>gzip</c> encoding value for <c>#HDR_ACCEPT_ENCODING</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='ENCODING_GZIP']"
		[Register ("ENCODING_GZIP")]
		public const string EncodingGzip = (string) "gzip";

		/// <summary>The <c>Accept</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_ACCEPT']"
		[Register ("HDR_ACCEPT")]
		public const string HdrAccept = (string) "Accept";

		/// <summary>The <c>Accept-Encoding</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_ACCEPT_ENCODING']"
		[Register ("HDR_ACCEPT_ENCODING")]
		public const string HdrAcceptEncoding = (string) "Accept-Encoding";

		/// <summary>The <c>Accept-Ranges</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_ACCEPT_RANGES']"
		[Register ("HDR_ACCEPT_RANGES")]
		public const string HdrAcceptRanges = (string) "Accept-Ranges";

		/// <summary>The <c>Authorization</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_AUTHORIZATION']"
		[Register ("HDR_AUTHORIZATION")]
		public const string HdrAuthorization = (string) "Authorization";

		/// <summary>The <c>Cache-Control</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_CACHE_CONTROL']"
		[Register ("HDR_CACHE_CONTROL")]
		public const string HdrCacheControl = (string) "Cache-Control";

		/// <summary>The <c>Content-Encoding</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_CONTENT_ENCODING']"
		[Register ("HDR_CONTENT_ENCODING")]
		public const string HdrContentEncoding = (string) "Content-Encoding";

		/// <summary>The <c>Content-Length</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_CONTENT_LENGTH']"
		[Register ("HDR_CONTENT_LENGTH")]
		public const string HdrContentLength = (string) "Content-Length";

		/// <summary>The <c>Content-Range</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_CONTENT_RANGE']"
		[Register ("HDR_CONTENT_RANGE")]
		public const string HdrContentRange = (string) "Content-Range";

		/// <summary>The <c>Content-Type</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_CONTENT_TYPE']"
		[Register ("HDR_CONTENT_TYPE")]
		public const string HdrContentType = (string) "Content-Type";

		/// <summary>The <c>Date</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_DATE']"
		[Register ("HDR_DATE")]
		public const string HdrDate = (string) "Date";

		/// <summary>The <c>ETag</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_ETAG']"
		[Register ("HDR_ETAG")]
		public const string HdrEtag = (string) "ETag";

		/// <summary>The <c>Expires</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_EXPIRES']"
		[Register ("HDR_EXPIRES")]
		public const string HdrExpires = (string) "Expires";

		/// <summary>The <c>If-Modified-Since</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_IF_MODIFIED_SINCE']"
		[Register ("HDR_IF_MODIFIED_SINCE")]
		public const string HdrIfModifiedSince = (string) "If-Modified-Since";

		/// <summary>The <c>If-None-Match</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_IF_NONE_MATCH']"
		[Register ("HDR_IF_NONE_MATCH")]
		public const string HdrIfNoneMatch = (string) "If-None-Match";

		/// <summary>The <c>If-Range</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_IF_RANGE']"
		[Register ("HDR_IF_RANGE")]
		public const string HdrIfRange = (string) "If-Range";

		/// <summary>The <c>Last-Modified</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_LAST_MODIFIED']"
		[Register ("HDR_LAST_MODIFIED")]
		public const string HdrLastModified = (string) "Last-Modified";

		/// <summary>The <c>Pragma</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_PRAGMA']"
		[Register ("HDR_PRAGMA")]
		public const string HdrPragma = (string) "Pragma";

		/// <summary>The <c>Range</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_RANGE']"
		[Register ("HDR_RANGE")]
		public const string HdrRange = (string) "Range";

		/// <summary>The <c>User-Agent</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_USER_AGENT']"
		[Register ("HDR_USER_AGENT")]
		public const string HdrUserAgent = (string) "User-Agent";

		/// <summary>The <c>WWW-Authenticate</c> header.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='HDR_WWW_AUTHENTICATE']"
		[Register ("HDR_WWW_AUTHENTICATE")]
		public const string HdrWwwAuthenticate = (string) "WWW-Authenticate";

		/// <summary>The <c>GET</c> HTTP method.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='METHOD_GET']"
		[Register ("METHOD_GET")]
		public const string MethodGet = (string) "GET";

		/// <summary>The <c>POST</c> HTTP method.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='METHOD_POST']"
		[Register ("METHOD_POST")]
		public const string MethodPost = (string) "POST";

		/// <summary>The standard <c>text/plain</c> MIME type.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/field[@name='TEXT_PLAIN']"
		[Register ("TEXT_PLAIN")]
		public const string TextPlain = (string) "text/plain";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/HttpSupport", typeof (HttpSupport));

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

		protected HttpSupport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="urlstr">the output buffer.</param>
		/// <param name="key">value which must be encoded to protected special characters.</param>
		/// <summary>URL encode a value string into an output buffer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/StringBuilder;Ljava/lang/String;)V", "")]
		public static unsafe void Encode (global::Java.Lang.StringBuilder urlstr, string key)
		{
			const string __id = "encode.(Ljava/lang/StringBuilder;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString ((string)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((urlstr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) urlstr).Handle);
				__args [1] = new JniArgumentValue (native_key);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (urlstr);
			}
		}

		/// <param name="proxySelector">proxy support for the caller.</param>
		/// <param name="u">location of the server caller wants to talk to.</param>
		/// <summary>Determine the proxy server (if any) needed to obtain a URL.</summary>
		/// <returns>proxy to communicate with the supplied URL.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/method[@name='proxyFor' and count(parameter)=2 and parameter[1][@type='java.net.ProxySelector'] and parameter[2][@type='java.net.URL']]"
		[Register ("proxyFor", "(Ljava/net/ProxySelector;Ljava/net/URL;)Ljava/net/Proxy;", "")]
		public static unsafe global::Java.Net.Proxy ProxyFor (global::Java.Net.ProxySelector proxySelector, global::Java.Net.URL u)
		{
			const string __id = "proxyFor.(Ljava/net/ProxySelector;Ljava/net/URL;)Ljava/net/Proxy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((proxySelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxySelector).Handle);
				__args [1] = new JniArgumentValue ((u == null) ? IntPtr.Zero : ((global::Java.Lang.Object) u).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (proxySelector);
				global::System.GC.KeepAlive (u);
			}
		}

		/// <param name="c">connection the code should be obtained from.</param>
		/// <summary>Get the HTTP response code from the request.</summary>
		/// <returns>r HTTP status code, usually 200 to indicate success. See
		///         <c>HttpConnection</c> for other defined constants.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/method[@name='response' and count(parameter)=1 and parameter[1][@type='java.net.HttpURLConnection']]"
		[Register ("response", "(Ljava/net/HttpURLConnection;)I", "")]
		public static unsafe int Response (global::Java.Net.HttpURLConnection c)
		{
			const string __id = "response.(Ljava/net/HttpURLConnection;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		/// <param name="c">connection the code should be obtained from.</param>
		/// <summary>Get the HTTP response code from the request.</summary>
		/// <returns>r HTTP status code, usually 200 to indicate success. See
		///         <c>HttpConnection</c> for other defined constants.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='HttpSupport']/method[@name='response' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.http.HttpConnection']]"
		[Register ("response", "(Lorg/eclipse/jgit/transport/http/HttpConnection;)I", "")]
		public static unsafe int Response (global::Org.Eclipse.Jgit.Transport.Http.IHttpConnection c)
		{
			const string __id = "response.(Lorg/eclipse/jgit/transport/http/HttpConnection;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

	}
}
