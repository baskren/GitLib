using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Conversion utilities for network byte order handling.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/NB", DoNotGenerateAcw=true)]
	public sealed partial class NB : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/NB", typeof (NB));

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

		internal NB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="a">the first value to compare.</param>
		/// <param name="b">the second value to compare.</param>
		/// <summary>Compare a 32 bit unsigned integer stored in a 32 bit signed integer.</summary>
		/// <returns>&amp;lt; 0 if a &amp;lt; b; 0 if a == b; &amp;gt; 0 if a &amp;gt; b.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']/method[@name='compareUInt32' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("compareUInt32", "(II)I", "")]
		public static unsafe int CompareUInt32 (int a, int b)
		{
			const string __id = "compareUInt32.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (a);
				__args [1] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		/// <param name="intbuf">buffer to acquire the 4 bytes of data from.</param>
		/// <param name="offset">position within the buffer to begin reading from. This
		///            position and the next 3 bytes after it (for a total of 4
		///            bytes) will be read.</param>
		/// <summary>Convert sequence of 4 bytes (network byte order) into signed value.</summary>
		/// <returns>signed integer value that matches the 32 bits read.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']/method[@name='decodeInt32' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decodeInt32", "([BI)I", "")]
		public static unsafe int DecodeInt32 (byte[] intbuf, int offset)
		{
			const string __id = "decodeInt32.([BI)I";
			IntPtr native_intbuf = JNIEnv.NewArray (intbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_intbuf);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (intbuf != null) {
					JNIEnv.CopyArray (native_intbuf, intbuf);
					JNIEnv.DeleteLocalRef (native_intbuf);
				}
				global::System.GC.KeepAlive (intbuf);
			}
		}

		/// <param name="intbuf">buffer to acquire the 8 bytes of data from.</param>
		/// <param name="offset">position within the buffer to begin reading from. This
		///            position and the next 7 bytes after it (for a total of 8
		///            bytes) will be read.</param>
		/// <summary>Convert sequence of 8 bytes (network byte order) into signed value.</summary>
		/// <returns>signed integer value that matches the 64 bits read.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']/method[@name='decodeInt64' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decodeInt64", "([BI)J", "")]
		public static unsafe long DecodeInt64 (byte[] intbuf, int offset)
		{
			const string __id = "decodeInt64.([BI)J";
			IntPtr native_intbuf = JNIEnv.NewArray (intbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_intbuf);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (intbuf != null) {
					JNIEnv.CopyArray (native_intbuf, intbuf);
					JNIEnv.DeleteLocalRef (native_intbuf);
				}
				global::System.GC.KeepAlive (intbuf);
			}
		}

		/// <param name="intbuf">buffer to acquire the 2 bytes of data from.</param>
		/// <param name="offset">position within the buffer to begin reading from. This
		///            position and the next byte after it (for a total of 2 bytes)
		///            will be read.</param>
		/// <summary>Convert sequence of 2 bytes (network byte order) into unsigned value.</summary>
		/// <returns>unsigned integer value that matches the 16 bits read.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']/method[@name='decodeUInt16' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decodeUInt16", "([BI)I", "")]
		public static unsafe int DecodeUInt16 (byte[] intbuf, int offset)
		{
			const string __id = "decodeUInt16.([BI)I";
			IntPtr native_intbuf = JNIEnv.NewArray (intbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_intbuf);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (intbuf != null) {
					JNIEnv.CopyArray (native_intbuf, intbuf);
					JNIEnv.DeleteLocalRef (native_intbuf);
				}
				global::System.GC.KeepAlive (intbuf);
			}
		}

		/// <param name="intbuf">buffer to acquire the 4 bytes of data from.</param>
		/// <param name="offset">position within the buffer to begin reading from. This
		///            position and the next 3 bytes after it (for a total of 4
		///            bytes) will be read.</param>
		/// <summary>Convert sequence of 4 bytes (network byte order) into unsigned value.</summary>
		/// <returns>unsigned integer value that matches the 32 bits read.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']/method[@name='decodeUInt32' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decodeUInt32", "([BI)J", "")]
		public static unsafe long DecodeUInt32 (byte[] intbuf, int offset)
		{
			const string __id = "decodeUInt32.([BI)J";
			IntPtr native_intbuf = JNIEnv.NewArray (intbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_intbuf);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (intbuf != null) {
					JNIEnv.CopyArray (native_intbuf, intbuf);
					JNIEnv.DeleteLocalRef (native_intbuf);
				}
				global::System.GC.KeepAlive (intbuf);
			}
		}

		/// <param name="intbuf">buffer to acquire the 8 bytes of data from.</param>
		/// <param name="offset">position within the buffer to begin reading from. This
		///            position and the next 7 bytes after it (for a total of 8
		///            bytes) will be read.</param>
		/// <summary>Convert sequence of 8 bytes (network byte order) into unsigned value.</summary>
		/// <returns>unsigned integer value that matches the 64 bits read.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']/method[@name='decodeUInt64' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decodeUInt64", "([BI)J", "")]
		public static unsafe long DecodeUInt64 (byte[] intbuf, int offset)
		{
			const string __id = "decodeUInt64.([BI)J";
			IntPtr native_intbuf = JNIEnv.NewArray (intbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_intbuf);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (intbuf != null) {
					JNIEnv.CopyArray (native_intbuf, intbuf);
					JNIEnv.DeleteLocalRef (native_intbuf);
				}
				global::System.GC.KeepAlive (intbuf);
			}
		}

		/// <param name="intbuf">buffer to write the 2 bytes of data into.</param>
		/// <param name="offset">position within the buffer to begin writing to. This position
		///            and the next byte after it (for a total of 2 bytes) will be
		///            replaced.</param>
		/// <param name="v">the value to write.</param>
		/// <summary>Write a 16 bit integer as a sequence of 2 bytes (network byte order).</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']/method[@name='encodeInt16' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("encodeInt16", "([BII)V", "")]
		public static unsafe void EncodeInt16 (byte[] intbuf, int offset, int v)
		{
			const string __id = "encodeInt16.([BII)V";
			IntPtr native_intbuf = JNIEnv.NewArray (intbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_intbuf);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (v);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (intbuf != null) {
					JNIEnv.CopyArray (native_intbuf, intbuf);
					JNIEnv.DeleteLocalRef (native_intbuf);
				}
				global::System.GC.KeepAlive (intbuf);
			}
		}

		/// <param name="intbuf">buffer to write the 4 bytes of data into.</param>
		/// <param name="offset">position within the buffer to begin writing to. This position
		///            and the next 3 bytes after it (for a total of 4 bytes) will be
		///            replaced.</param>
		/// <param name="v">the value to write.</param>
		/// <summary>Write a 32 bit integer as a sequence of 4 bytes (network byte order).</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']/method[@name='encodeInt32' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("encodeInt32", "([BII)V", "")]
		public static unsafe void EncodeInt32 (byte[] intbuf, int offset, int v)
		{
			const string __id = "encodeInt32.([BII)V";
			IntPtr native_intbuf = JNIEnv.NewArray (intbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_intbuf);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (v);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (intbuf != null) {
					JNIEnv.CopyArray (native_intbuf, intbuf);
					JNIEnv.DeleteLocalRef (native_intbuf);
				}
				global::System.GC.KeepAlive (intbuf);
			}
		}

		/// <param name="intbuf">buffer to write the 8 bytes of data into.</param>
		/// <param name="offset">position within the buffer to begin writing to. This position
		///            and the next 7 bytes after it (for a total of 8 bytes) will be
		///            replaced.</param>
		/// <param name="v">the value to write.</param>
		/// <summary>Write a 64 bit integer as a sequence of 8 bytes (network byte order).</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='NB']/method[@name='encodeInt64' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("encodeInt64", "([BIJ)V", "")]
		public static unsafe void EncodeInt64 (byte[] intbuf, int offset, long v)
		{
			const string __id = "encodeInt64.([BIJ)V";
			IntPtr native_intbuf = JNIEnv.NewArray (intbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_intbuf);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (v);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (intbuf != null) {
					JNIEnv.CopyArray (native_intbuf, intbuf);
					JNIEnv.DeleteLocalRef (native_intbuf);
				}
				global::System.GC.KeepAlive (intbuf);
			}
		}

	}
}
