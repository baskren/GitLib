using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>A simple HTTP REST client for the Amazon S3 service.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AmazonS3']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/AmazonS3", DoNotGenerateAcw=true)]
	public partial class AmazonS3 : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/AmazonS3", typeof (AmazonS3));

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

		protected AmazonS3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="props">connection properties.</param>
		/// <summary>Create a new S3 client for the supplied user information.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AmazonS3']/constructor[@name='AmazonS3' and count(parameter)=1 and parameter[1][@type='java.util.Properties']]"
		[Register (".ctor", "(Ljava/util/Properties;)V", "")]
		public unsafe AmazonS3 (global::Java.Util.Properties props) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Properties;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((props == null) ? IntPtr.Zero : ((global::Java.Lang.Object) props).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (props);
			}
		}

		static Delegate cb_beginPut_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBeginPut_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_String_Handler ()
		{
			if (cb_beginPut_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_String_ == null)
				cb_beginPut_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_BeginPut_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_String_);
			return cb_beginPut_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_String_;
		}

		static IntPtr n_BeginPut_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucket, IntPtr native_key, IntPtr native_monitor, IntPtr native_monitorTask)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AmazonS3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bucket = JNIEnv.GetString (native_bucket, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var monitorTask = JNIEnv.GetString (native_monitorTask, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.BeginPut (bucket, key, monitor, monitorTask));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="bucket">name of the bucket storing the object.</param>
		/// <param name="key">key of the object within its bucket.</param>
		/// <param name="monitor">(optional) progress monitor to post upload completion to
		///            during the stream's close method.</param>
		/// <param name="monitorTask">(optional) task name to display during the close method.</param>
		/// <summary>Atomically create or replace a single large object.</summary>
		/// <returns>a stream which accepts the new data, and transmits once closed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AmazonS3']/method[@name='beginPut' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[4][@type='java.lang.String']]"
		[Register ("beginPut", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/lang/String;)Ljava/io/OutputStream;", "GetBeginPut_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.IO.Stream BeginPut (string bucket, string key, global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, string monitorTask)
		{
			const string __id = "beginPut.(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/lang/String;)Ljava/io/OutputStream;";
			IntPtr native_bucket = JNIEnv.NewString ((string)bucket);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			IntPtr native_monitorTask = JNIEnv.NewString ((string)monitorTask);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_bucket);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [3] = new JniArgumentValue (native_monitorTask);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucket);
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_monitorTask);
				global::System.GC.KeepAlive (monitor);
			}
		}

		static Delegate cb_decrypt_Ljava_net_URLConnection_;
#pragma warning disable 0169
		static Delegate GetDecrypt_Ljava_net_URLConnection_Handler ()
		{
			if (cb_decrypt_Ljava_net_URLConnection_ == null)
				cb_decrypt_Ljava_net_URLConnection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Decrypt_Ljava_net_URLConnection_);
			return cb_decrypt_Ljava_net_URLConnection_;
		}

		static IntPtr n_Decrypt_Ljava_net_URLConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_u)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AmazonS3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var u = global::Java.Lang.Object.GetObject<global::Java.Net.URLConnection> (native_u, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Decrypt (u));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AmazonS3']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.net.URLConnection']]"
		[Register ("decrypt", "(Ljava/net/URLConnection;)Ljava/io/InputStream;", "GetDecrypt_Ljava_net_URLConnection_Handler")]
		public virtual unsafe global::System.IO.Stream Decrypt (global::Java.Net.URLConnection u)
		{
			const string __id = "decrypt.(Ljava/net/URLConnection;)Ljava/io/InputStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((u == null) ? IntPtr.Zero : ((global::Java.Lang.Object) u).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (u);
			}
		}

		static Delegate cb_delete_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Delete_Ljava_lang_String_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Delete_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucket, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AmazonS3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bucket = JNIEnv.GetString (native_bucket, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Delete (bucket, key);
		}
#pragma warning restore 0169

		/// <param name="bucket">name of the bucket storing the object.</param>
		/// <param name="key">key of the object within its bucket.</param>
		/// <summary>Delete a single object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AmazonS3']/method[@name='delete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;Ljava/lang/String;)V", "GetDelete_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Delete (string bucket, string key)
		{
			const string __id = "delete.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_bucket = JNIEnv.NewString ((string)bucket);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bucket);
				__args [1] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucket);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Get_Ljava_lang_String_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucket, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AmazonS3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bucket = JNIEnv.GetString (native_bucket, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (bucket, key));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="bucket">name of the bucket storing the object.</param>
		/// <param name="key">key of the object within its bucket.</param>
		/// <summary>Get the content of a bucket object.</summary>
		/// <returns>connection to stream the content of the object. The request
		///         properties of the connection may not be modified by the caller as
		///         the request parameters have already been signed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AmazonS3']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/net/URLConnection;", "GetGet_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Net.URLConnection Get (string bucket, string key)
		{
			const string __id = "get.(Ljava/lang/String;Ljava/lang/String;)Ljava/net/URLConnection;";
			IntPtr native_bucket = JNIEnv.NewString ((string)bucket);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bucket);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.URLConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucket);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_list_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetList_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_list_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_list_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_List_Ljava_lang_String_Ljava_lang_String_);
			return cb_list_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_List_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bucket, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AmazonS3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bucket = JNIEnv.GetString (native_bucket, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.List (bucket, prefix));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="bucket">name of the bucket whose objects should be listed.</param>
		/// <param name="prefix">common prefix to filter the results by. Must not be null.
		///            Supplying the empty string will list all keys in the bucket.
		///            Supplying a non-empty string will act as though a trailing '/'
		///            appears in prefix, even if it does not.</param>
		/// <summary>List the names of keys available within a bucket.</summary>
		/// <returns>list of keys starting with &lt;code&gt;prefix&lt;/code&gt;, after removing
		///         &lt;code&gt;prefix&lt;/code&gt; (or &lt;code&gt;prefix + "/"&lt;/code&gt;)from all
		///         of them.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AmazonS3']/method[@name='list' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("list", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetList_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> List (string bucket, string prefix)
		{
			const string __id = "list.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_bucket = JNIEnv.NewString ((string)bucket);
			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bucket);
				__args [1] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucket);
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Put_Ljava_lang_String_Ljava_lang_String_arrayB);
			return cb_put_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bucket, IntPtr native_key, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AmazonS3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bucket = JNIEnv.GetString (native_bucket, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Put (bucket, key, data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		/// <param name="bucket">name of the bucket storing the object.</param>
		/// <param name="key">key of the object within its bucket.</param>
		/// <param name="data">new data content for the object. Must not be null. Zero length
		///            array will create a zero length object.</param>
		/// <summary>Atomically create or replace a single small object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AmazonS3']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;[B)V", "GetPut_Ljava_lang_String_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe void Put (string bucket, string key, byte[] data)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;[B)V";
			IntPtr native_bucket = JNIEnv.NewString ((string)bucket);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bucket);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucket);
				JNIEnv.DeleteLocalRef (native_key);
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
