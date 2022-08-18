using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Encodes and decodes to and from Base64 notation.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Base64']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/Base64", typeof (Base64));

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

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="source">The Base64 encoded data</param>
		/// <param name="off">The offset of where to begin decoding</param>
		/// <param name="len">The length of characters to decode</param>
		/// <summary>Low-level decoding ASCII characters from a byte array.</summary>
		/// <returns>decoded data</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Base64']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("decode", "([BII)[B", "")]
		public static unsafe byte[] Decode (byte[] source, int off, int len)
		{
			const string __id = "decode.([BII)[B";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_source);
				__args [1] = new JniArgumentValue (off);
				__args [2] = new JniArgumentValue (len);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
				global::System.GC.KeepAlive (source);
			}
		}

		/// <param name="s">the string to decode</param>
		/// <summary>Decodes data from Base64 notation.</summary>
		/// <returns>the decoded data</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Base64']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Decode (string s)
		{
			const string __id = "decode.(Ljava/lang/String;)[B";
			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		/// <param name="source">The data to convert</param>
		/// <summary>Encodes a byte array into Base64 notation.</summary>
		/// <returns>encoded base64 representation of source.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBytes", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] source)
		{
			const string __id = "encodeBytes.([B)Ljava/lang/String;";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_source);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
				global::System.GC.KeepAlive (source);
			}
		}

		/// <param name="source">The data to convert</param>
		/// <param name="off">Offset in array where conversion should begin</param>
		/// <param name="len">Length of data to convert</param>
		/// <summary>Encodes a byte array into Base64 notation.</summary>
		/// <returns>encoded base64 representation of source.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("encodeBytes", "([BII)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] source, int off, int len)
		{
			const string __id = "encodeBytes.([BII)Ljava/lang/String;";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_source);
				__args [1] = new JniArgumentValue (off);
				__args [2] = new JniArgumentValue (len);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
				global::System.GC.KeepAlive (source);
			}
		}

	}
}
