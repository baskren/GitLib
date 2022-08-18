using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util.IO {

	/// <summary>Input/Output utilities</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/IO", DoNotGenerateAcw=true)]
	public partial class IO : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/IO", typeof (IO));

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

		protected IO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="channel">channel to read data from.</param>
		/// <param name="dst">buffer that must be fully populated, [off, off+len).</param>
		/// <param name="off">position within the buffer to start writing to.</param>
		/// <param name="len">number of bytes that should be read.</param>
		/// <summary>Read as much of the array as possible from a channel.</summary>
		/// <returns>number of bytes actually read.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']/method[@name='read' and count(parameter)=4 and parameter[1][@type='java.nio.channels.ReadableByteChannel'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("read", "(Ljava/nio/channels/ReadableByteChannel;[BII)I", "")]
		public static unsafe int Read (global::Java.Nio.Channels.IReadableByteChannel channel, byte[] dst, int off, int len)
		{
			const string __id = "read.(Ljava/nio/channels/ReadableByteChannel;[BII)I";
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((channel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) channel).Handle);
				__args [1] = new JniArgumentValue (native_dst);
				__args [2] = new JniArgumentValue (off);
				__args [3] = new JniArgumentValue (len);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
				global::System.GC.KeepAlive (channel);
				global::System.GC.KeepAlive (dst);
			}
		}

		/// <param name="path">location of the file to read.</param>
		/// <summary>Read an entire local file into memory as a byte array.</summary>
		/// <returns>complete contents of the requested local file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']/method[@name='readFully' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readFully", "(Ljava/io/File;)[B", "")]
		public static unsafe byte[] ReadFully (global::Java.IO.File path)
		{
			const string __id = "readFully.(Ljava/io/File;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		/// <param name="path">location of the file to read.</param>
		/// <param name="max">maximum number of bytes to read, if the file is larger than
		///            this limit an IOException is thrown.</param>
		/// <summary>Read an entire local file into memory as a byte array.</summary>
		/// <returns>complete contents of the requested local file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']/method[@name='readFully' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register ("readFully", "(Ljava/io/File;I)[B", "")]
		public static unsafe byte[] ReadFully (global::Java.IO.File path, int max)
		{
			const string __id = "readFully.(Ljava/io/File;I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				__args [1] = new JniArgumentValue (max);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		/// <param name="fd">input stream to read the data from.</param>
		/// <param name="dst">buffer that must be fully populated, [off, off+len).</param>
		/// <param name="off">position within the buffer to start writing to.</param>
		/// <summary>Read the entire byte array into memory, unless input is shorter</summary>
		/// <returns>number of bytes in buffer or stream, whichever is shortest</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']/method[@name='readFully' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("readFully", "(Ljava/io/InputStream;[BI)I", "")]
		public static unsafe int ReadFully (global::System.IO.Stream fd, byte[] dst, int off)
		{
			const string __id = "readFully.(Ljava/io/InputStream;[BI)I";
			IntPtr native_fd = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (fd);
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_fd);
				__args [1] = new JniArgumentValue (native_dst);
				__args [2] = new JniArgumentValue (off);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fd);
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
				global::System.GC.KeepAlive (fd);
				global::System.GC.KeepAlive (dst);
			}
		}

		/// <param name="fd">input stream to read the data from.</param>
		/// <param name="dst">buffer that must be fully populated, [off, off+len).</param>
		/// <param name="off">position within the buffer to start writing to.</param>
		/// <param name="len">number of bytes that must be read.</param>
		/// <summary>Read the entire byte array into memory, or throw an exception.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']/method[@name='readFully' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readFully", "(Ljava/io/InputStream;[BII)V", "")]
		public static unsafe void ReadFully (global::System.IO.Stream fd, byte[] dst, int off, int len)
		{
			const string __id = "readFully.(Ljava/io/InputStream;[BII)V";
			IntPtr native_fd = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (fd);
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_fd);
				__args [1] = new JniArgumentValue (native_dst);
				__args [2] = new JniArgumentValue (off);
				__args [3] = new JniArgumentValue (len);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fd);
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
				global::System.GC.KeepAlive (fd);
				global::System.GC.KeepAlive (dst);
			}
		}

		/// <param name="s">the string to read</param>
		/// <summary>Divides the given string into lines.</summary>
		/// <returns>the string divided into lines</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']/method[@name='readLines' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readLines", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> ReadLines (string s)
		{
			const string __id = "readLines.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		/// <param name="path">location of the file to read.</param>
		/// <param name="limit">maximum number of bytes to read, if the file is larger than
		///            only the first limit number of bytes are returned</param>
		/// <summary>Read at most limit bytes from the local file into memory as a byte array.</summary>
		/// <returns>complete contents of the requested local file. If the contents
		///         exceeds the limit, then only the limit is returned.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']/method[@name='readSome' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register ("readSome", "(Ljava/io/File;I)[B", "")]
		public static unsafe byte[] ReadSome (global::Java.IO.File path, int limit)
		{
			const string __id = "readSome.(Ljava/io/File;I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				__args [1] = new JniArgumentValue (limit);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		/// <param name="in">input stream to be read.</param>
		/// <param name="sizeHint">a hint on the approximate number of bytes contained in the
		///            stream, used to allocate temporary buffers more efficiently</param>
		/// <summary>Read an entire input stream into memory as a ByteBuffer.</summary>
		/// <returns>complete contents of the input stream. The ByteBuffer always has
		///         a writable backing array, with <c>position() == 0</c> and
		///         <c>limit()</c> equal to the actual length read. Callers may rely
		///         on obtaining the underlying array for efficient data access. If
		///         <c>sizeHint</c> was too large, the array may be over-allocated,
		///         resulting in <c>limit() &lt; array().length</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']/method[@name='readWholeStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("readWholeStream", "(Ljava/io/InputStream;I)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer ReadWholeStream (global::System.IO.Stream @in, int sizeHint)
		{
			const string __id = "readWholeStream.(Ljava/io/InputStream;I)Ljava/nio/ByteBuffer;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (sizeHint);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		/// <param name="fd">the stream to skip bytes from.</param>
		/// <param name="toSkip">total number of bytes to be discarded. Must be &amp;gt;= 0.</param>
		/// <summary>Skip an entire region of an input stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IO']/method[@name='skipFully' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register ("skipFully", "(Ljava/io/InputStream;J)V", "")]
		public static unsafe void SkipFully (global::System.IO.Stream fd, long toSkip)
		{
			const string __id = "skipFully.(Ljava/io/InputStream;J)V";
			IntPtr native_fd = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (fd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fd);
				__args [1] = new JniArgumentValue (toSkip);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fd);
				global::System.GC.KeepAlive (fd);
			}
		}

	}
}
