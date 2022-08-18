using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Handy utility functions to parse raw object contents.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/RawParseUtils", DoNotGenerateAcw=true)]
	public sealed partial class RawParseUtils : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/field[@name='UTF8_CHARSET']"
		[Register ("UTF8_CHARSET")]
		public static global::Java.Nio.Charset.Charset Utf8Charset {
			get {
				const string __id = "UTF8_CHARSET.Ljava/nio/charset/Charset;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/RawParseUtils", typeof (RawParseUtils));

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

		internal RawParseUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position in buffer to start the scan at. Most callers should
		///            pass 0 to ensure the scan starts from the beginning of the
		///            commit buffer and does not accidentally look at message body.</param>
		/// <summary>Locate the "author " header line data.</summary>
		/// <returns>position just after the space in "author ", so the first
		///         character of the author's name. If no author header can be
		///         located -1 is returned.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='author' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("author", "([BI)I", "")]
		public static unsafe int Author (byte[] b, int ptr)
		{
			const string __id = "author.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position in buffer to start the scan at. Most callers should
		///            pass 0 to ensure the scan starts from the beginning of the
		///            commit buffer.</param>
		/// <summary>Locate the position of the commit message body.</summary>
		/// <returns>position of the user's message buffer.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='commitMessage' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("commitMessage", "([BI)I", "")]
		public static unsafe int CommitMessage (byte[] b, int ptr)
		{
			const string __id = "commitMessage.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position in buffer to start the scan at. Most callers should
		///            pass 0 to ensure the scan starts from the beginning of the
		///            commit buffer and does not accidentally look at message body.</param>
		/// <summary>Locate the "committer " header line data.</summary>
		/// <returns>position just after the space in "committer ", so the first
		///         character of the committer's name. If no committer header can be
		///         located -1 is returned.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='committer' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("committer", "([BI)I", "")]
		public static unsafe int Committer (byte[] b, int ptr)
		{
			const string __id = "committer.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="buffer">buffer to pull raw bytes from.</param>
		/// <summary>Decode a buffer under UTF-8, if possible.</summary>
		/// <returns>a string representation of the range &lt;code&gt;[start,end)&lt;/code&gt;,
		///         after decoding the region through the specified character set.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)Ljava/lang/String;", "")]
		public static unsafe string Decode (byte[] buffer)
		{
			const string __id = "decode.([B)Ljava/lang/String;";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_buffer);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (buffer);
			}
		}

		/// <param name="buffer">buffer to pull raw bytes from.</param>
		/// <param name="start">start position in buffer</param>
		/// <param name="end">one position past the last location within the buffer to take
		///            data from.</param>
		/// <summary>Decode a buffer under UTF-8, if possible.</summary>
		/// <returns>a string representation of the range &lt;code&gt;[start,end)&lt;/code&gt;,
		///         after decoding the region through the specified character set.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("decode", "([BII)Ljava/lang/String;", "")]
		public static unsafe string Decode (byte[] buffer, int start, int end)
		{
			const string __id = "decode.([BII)Ljava/lang/String;";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (buffer);
			}
		}

		/// <param name="cs">character set to use when decoding the buffer.</param>
		/// <param name="buffer">buffer to pull raw bytes from.</param>
		/// <summary>Decode a buffer under the specified character set if possible.</summary>
		/// <returns>a string representation of the range &lt;code&gt;[start,end)&lt;/code&gt;,
		///         after decoding the region through the specified character set.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.nio.charset.Charset'] and parameter[2][@type='byte[]']]"
		[Register ("decode", "(Ljava/nio/charset/Charset;[B)Ljava/lang/String;", "")]
		public static unsafe string Decode (global::Java.Nio.Charset.Charset cs, byte[] buffer)
		{
			const string __id = "decode.(Ljava/nio/charset/Charset;[B)Ljava/lang/String;";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cs).Handle);
				__args [1] = new JniArgumentValue (native_buffer);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (cs);
				global::System.GC.KeepAlive (buffer);
			}
		}

		/// <param name="cs">character set to use when decoding the buffer.</param>
		/// <param name="buffer">buffer to pull raw bytes from.</param>
		/// <param name="start">first position within the buffer to take data from.</param>
		/// <param name="end">one position past the last location within the buffer to take
		///            data from.</param>
		/// <summary>Decode a region of the buffer under the specified character set if possible.</summary>
		/// <returns>a string representation of the range &lt;code&gt;[start,end)&lt;/code&gt;,
		///         after decoding the region through the specified character set.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='decode' and count(parameter)=4 and parameter[1][@type='java.nio.charset.Charset'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("decode", "(Ljava/nio/charset/Charset;[BII)Ljava/lang/String;", "")]
		public static unsafe string Decode (global::Java.Nio.Charset.Charset cs, byte[] buffer, int start, int end)
		{
			const string __id = "decode.(Ljava/nio/charset/Charset;[BII)Ljava/lang/String;";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((cs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cs).Handle);
				__args [1] = new JniArgumentValue (native_buffer);
				__args [2] = new JniArgumentValue (start);
				__args [3] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (cs);
				global::System.GC.KeepAlive (buffer);
			}
		}

		/// <param name="cs">character set to use when decoding the buffer.</param>
		/// <param name="buffer">buffer to pull raw bytes from.</param>
		/// <param name="start">first position within the buffer to take data from.</param>
		/// <param name="end">one position past the last location within the buffer to take
		///            data from.</param>
		/// <summary>Decode a region of the buffer under the specified character set if
		/// possible.</summary>
		/// <returns>a string representation of the range &lt;code&gt;[start,end)&lt;/code&gt;,
		///         after decoding the region through the specified character set.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='decodeNoFallback' and count(parameter)=4 and parameter[1][@type='java.nio.charset.Charset'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("decodeNoFallback", "(Ljava/nio/charset/Charset;[BII)Ljava/lang/String;", "")]
		public static unsafe string DecodeNoFallback (global::Java.Nio.Charset.Charset cs, byte[] buffer, int start, int end)
		{
			const string __id = "decodeNoFallback.(Ljava/nio/charset/Charset;[BII)Ljava/lang/String;";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((cs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cs).Handle);
				__args [1] = new JniArgumentValue (native_buffer);
				__args [2] = new JniArgumentValue (start);
				__args [3] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (cs);
				global::System.GC.KeepAlive (buffer);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position in buffer to start the scan at. Most callers should
		///            pass 0 to ensure the scan starts from the beginning of the
		///            buffer and does not accidentally look at the message body.</param>
		/// <summary>Locate the "encoding " header line.</summary>
		/// <returns>position just after the space in "encoding ", so the first
		///         character of the encoding's name. If no encoding header can be
		///         located -1 is returned (and UTF-8 should be assumed).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='encoding' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encoding", "([BI)I", "")]
		public static unsafe int Encoding (byte[] b, int ptr)
		{
			const string __id = "encoding.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="raw">buffer to scan.</param>
		/// <param name="ptr">first position within raw to consider as a footer line key.</param>
		/// <summary>Locate the end of a footer line key string.</summary>
		/// <returns>position of the ':' which terminates the footer line key if this
		///         is otherwise a valid footer line key; otherwise -1.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='endOfFooterLineKey' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("endOfFooterLineKey", "([BI)I", "")]
		public static unsafe int EndOfFooterLineKey (byte[] raw, int ptr)
		{
			const string __id = "endOfFooterLineKey.([BI)I";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="start">position in buffer to start the scan at. Most callers will
		///            want to pass the first position of the commit message (as
		///            found by <c>#commitMessage(byte[], int)</c>.</param>
		/// <summary>Locate the end of a paragraph.</summary>
		/// <returns>position of the LF at the end of the paragraph;
		///         &lt;code&gt;b.length&lt;/code&gt; if no paragraph end could be located.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='endOfParagraph' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("endOfParagraph", "([BI)I", "")]
		public static unsafe int EndOfParagraph (byte[] b, int start)
		{
			const string __id = "endOfParagraph.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (start);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="buffer">buffer to pull raw bytes from.</param>
		/// <param name="start">first position within the buffer to take data from.</param>
		/// <param name="end">one position past the last location within the buffer to take
		///            data from.</param>
		/// <summary>Decode a region of the buffer under the ISO-8859-1 encoding.</summary>
		/// <returns>a string representation of the range &lt;code&gt;[start,end)&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='extractBinaryString' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("extractBinaryString", "([BII)Ljava/lang/String;", "")]
		public static unsafe string ExtractBinaryString (byte[] buffer, int start, int end)
		{
			const string __id = "extractBinaryString.([BII)Ljava/lang/String;";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (buffer);
			}
		}

		/// <param name="b">buffer to write into.</param>
		/// <param name="o">one offset past the location where writing will begin; writing
		///            proceeds towards lower index values.</param>
		/// <param name="value">the value to store.</param>
		/// <summary>Format a base 10 numeric into a temporary buffer.</summary>
		/// <returns>the new offset value &lt;code&gt;o&lt;/code&gt;. This is the position of
		///         the last byte written. Additional writing should start at one
		///         position earlier.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='formatBase10' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("formatBase10", "([BII)I", "")]
		public static unsafe int FormatBase10 (byte[] b, int o, int value)
		{
			const string __id = "formatBase10.([BII)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (o);
				__args [2] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="buf">buffer to scan.</param>
		/// <param name="ptr">position within the buffer corresponding to the first byte of
		///            line 1.</param>
		/// <param name="end">1 past the end of the content within &lt;code&gt;buf&lt;/code&gt;.</param>
		/// <summary>Index the region between &lt;code&gt;[ptr, end)&lt;/code&gt; to find line starts.</summary>
		/// <returns>a line map indexing the start position of each line.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='lineMap' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("lineMap", "([BII)Lorg/eclipse/jgit/util/IntList;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Util.IntList LineMap (byte[] buf, int ptr, int end)
		{
			const string __id = "lineMap.([BII)Lorg/eclipse/jgit/util/IntList;";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IntList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

		/// <param name="b">the buffer to scan.</param>
		/// <param name="ptr">first position within b, this should match src[0].</param>
		/// <param name="src">the buffer to test for equality with b.</param>
		/// <summary>Determine if b[ptr] matches src.</summary>
		/// <returns>ptr + src.length if b[ptr..src.length] == src; else -1.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='match' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("match", "([BI[B)I", "")]
		public static unsafe int Match (byte[] b, int ptr, byte[] src)
		{
			const string __id = "match.([BI[B)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (native_src);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				global::System.GC.KeepAlive (b);
				global::System.GC.KeepAlive (src);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position within buffer to start looking for chrA at.</param>
		/// <param name="chrA">character to find.</param>
		/// <summary>Locate the first position after a given character.</summary>
		/// <returns>new position just after chrA.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='next' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("next", "([BIC)I", "")]
		public static unsafe int Next (byte[] b, int ptr, char chrA)
		{
			const string __id = "next.([BIC)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (chrA);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position within buffer to start looking for LF at.</param>
		/// <summary>Locate the first position after the next LF.</summary>
		/// <returns>new position just after the first LF found.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='nextLF' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("nextLF", "([BI)I", "")]
		public static unsafe int NextLF (byte[] b, int ptr)
		{
			const string __id = "nextLF.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position within buffer to start looking for chrA or LF at.</param>
		/// <param name="chrA">character to find.</param>
		/// <summary>Locate the first position after either the given character or LF.</summary>
		/// <returns>new position just after the first chrA or LF to be found.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='nextLF' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("nextLF", "([BIC)I", "")]
		public static unsafe int NextLF (byte[] b, int ptr, char chrA)
		{
			const string __id = "nextLF.([BIC)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (chrA);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position within buffer to start parsing digits at.</param>
		/// <param name="ptrResult">optional location to return the new ptr value through. If null
		///            the ptr value will be discarded.</param>
		/// <summary>Parse a base 10 numeric from a sequence of ASCII digits into an int.</summary>
		/// <returns>the value at this location; 0 if the location is not a valid
		///         numeric.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parseBase10' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.jgit.util.MutableInteger']]"
		[Register ("parseBase10", "([BILorg/eclipse/jgit/util/MutableInteger;)I", "")]
		public static unsafe int ParseBase10 (byte[] b, int ptr, global::Org.Eclipse.Jgit.Util.MutableInteger ptrResult)
		{
			const string __id = "parseBase10.([BILorg/eclipse/jgit/util/MutableInteger;)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue ((ptrResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ptrResult).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
				global::System.GC.KeepAlive (ptrResult);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <summary>Parse the "encoding " header into a character set reference.</summary>
		/// <returns>the Java character set representation. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parseEncoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseEncoding", "([B)Ljava/nio/charset/Charset;", "")]
		public static unsafe global::Java.Nio.Charset.Charset ParseEncoding (byte[] b)
		{
			const string __id = "parseEncoding.([B)Ljava/nio/charset/Charset;";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="bs">buffer to parse digits from; positions <c>[p, p+4)</c> will
		///            be parsed.</param>
		/// <param name="p">first position within the buffer to parse.</param>
		/// <summary>Parse 4 character base 16 (hex) formatted string to unsigned integer.</summary>
		/// <returns>the integer value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parseHexInt16' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("parseHexInt16", "([BI)I", "")]
		public static unsafe int ParseHexInt16 (byte[] bs, int p)
		{
			const string __id = "parseHexInt16.([BI)I";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bs);
				__args [1] = new JniArgumentValue (p);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		/// <param name="bs">buffer to parse digits from; positions <c>[p, p+8)</c> will
		///            be parsed.</param>
		/// <param name="p">first position within the buffer to parse.</param>
		/// <summary>Parse 8 character base 16 (hex) formatted string to unsigned integer.</summary>
		/// <returns>the integer value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parseHexInt32' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("parseHexInt32", "([BI)I", "")]
		public static unsafe int ParseHexInt32 (byte[] bs, int p)
		{
			const string __id = "parseHexInt32.([BI)I";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bs);
				__args [1] = new JniArgumentValue (p);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		/// <param name="digit">hex character to parse.</param>
		/// <summary>Parse a single hex digit to its numeric value (0-15).</summary>
		/// <returns>numeric value, in the range 0-15.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parseHexInt4' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("parseHexInt4", "(B)I", "")]
		public static unsafe int ParseHexInt4 (sbyte digit)
		{
			const string __id = "parseHexInt4.(B)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (digit);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position within buffer to start parsing digits at.</param>
		/// <param name="ptrResult">optional location to return the new ptr value through. If null
		///            the ptr value will be discarded.</param>
		/// <summary>Parse a base 10 numeric from a sequence of ASCII digits into a long.</summary>
		/// <returns>the value at this location; 0 if the location is not a valid
		///         numeric.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parseLongBase10' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.jgit.util.MutableInteger']]"
		[Register ("parseLongBase10", "([BILorg/eclipse/jgit/util/MutableInteger;)J", "")]
		public static unsafe long ParseLongBase10 (byte[] b, int ptr, global::Org.Eclipse.Jgit.Util.MutableInteger ptrResult)
		{
			const string __id = "parseLongBase10.([BILorg/eclipse/jgit/util/MutableInteger;)J";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue ((ptrResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ptrResult).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
				global::System.GC.KeepAlive (ptrResult);
			}
		}

		/// <param name="raw">the buffer to parse character data from.</param>
		/// <param name="nameB">first position of the identity information. This should be the
		///            first position after the space which delimits the header field
		///            name (e.g. "author" or "committer") from the rest of the
		///            identity line.</param>
		/// <summary>Parse a name line (e.</summary>
		/// <returns>the parsed identity or null in case the identity could not be
		///         parsed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parsePersonIdent' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("parsePersonIdent", "([BI)Lorg/eclipse/jgit/lib/PersonIdent;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent ParsePersonIdent (byte[] raw, int nameB)
		{
			const string __id = "parsePersonIdent.([BI)Lorg/eclipse/jgit/lib/PersonIdent;";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (nameB);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="in">the string to parse a name from.</param>
		/// <summary>Parse a name string (e.</summary>
		/// <returns>the parsed identity or null in case the identity could not be
		///         parsed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parsePersonIdent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parsePersonIdent", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/PersonIdent;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent ParsePersonIdent (string @in)
		{
			const string __id = "parsePersonIdent.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/PersonIdent;";
			IntPtr native__in = JNIEnv.NewString ((string)@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		/// <param name="raw">the buffer to parse character data from.</param>
		/// <param name="nameB">first position of the identity information. This should be the
		///            first position after the space which delimits the header field
		///            name (e.g. "author" or "committer") from the rest of the
		///            identity line.</param>
		/// <summary>Parse a name data (e.</summary>
		/// <returns>the parsed identity. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parsePersonIdentOnly' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("parsePersonIdentOnly", "([BI)Lorg/eclipse/jgit/lib/PersonIdent;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent ParsePersonIdentOnly (byte[] raw, int nameB)
		{
			const string __id = "parsePersonIdentOnly.([BI)Lorg/eclipse/jgit/lib/PersonIdent;";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (nameB);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position within buffer to start parsing digits at.</param>
		/// <summary>Parse a Git style timezone string.</summary>
		/// <returns>the timezone at this location, expressed in minutes.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='parseTimeZoneOffset' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("parseTimeZoneOffset", "([BI)I", "")]
		public static unsafe int ParseTimeZoneOffset (byte[] b, int ptr)
		{
			const string __id = "parseTimeZoneOffset.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position within buffer to start looking for chrA at.</param>
		/// <param name="chrA">character to find.</param>
		/// <summary>Locate the first position before a given character.</summary>
		/// <returns>new position just before chrA, -1 for not found</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='prev' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("prev", "([BIC)I", "")]
		public static unsafe int Prev (byte[] b, int ptr, char chrA)
		{
			const string __id = "prev.([BIC)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (chrA);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position within buffer to start looking for LF at.</param>
		/// <summary>Locate the first position before the previous LF.</summary>
		/// <returns>new position just before the first LF found, -1 for not found</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='prevLF' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("prevLF", "([BI)I", "")]
		public static unsafe int PrevLF (byte[] b, int ptr)
		{
			const string __id = "prevLF.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position within buffer to start looking for chrA or LF at.</param>
		/// <param name="chrA">character to find.</param>
		/// <summary>Locate the previous position before either the given character or LF.</summary>
		/// <returns>new position just before the first chrA or LF to be found, -1 for
		///         not found</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='prevLF' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("prevLF", "([BIC)I", "")]
		public static unsafe int PrevLF (byte[] b, int ptr, char chrA)
		{
			const string __id = "prevLF.([BIC)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (chrA);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position in buffer to start the scan at. Most callers should
		///            pass 0 to ensure the scan starts from the beginning of the tag
		///            buffer.</param>
		/// <summary>Locate the position of the tag message body.</summary>
		/// <returns>position of the user's message buffer.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='tagMessage' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("tagMessage", "([BI)I", "")]
		public static unsafe int TagMessage (byte[] b, int ptr)
		{
			const string __id = "tagMessage.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="b">buffer to scan.</param>
		/// <param name="ptr">position in buffer to start the scan at. Most callers should
		///            pass 0 to ensure the scan starts from the beginning of the tag
		///            buffer and does not accidentally look at message body.</param>
		/// <summary>Locate the "tagger " header line data.</summary>
		/// <returns>position just after the space in "tagger ", so the first
		///         character of the tagger's name. If no tagger header can be
		///         located -1 is returned.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawParseUtils']/method[@name='tagger' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("tagger", "([BI)I", "")]
		public static unsafe int Tagger (byte[] b, int ptr)
		{
			const string __id = "tagger.([BI)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

	}
}
