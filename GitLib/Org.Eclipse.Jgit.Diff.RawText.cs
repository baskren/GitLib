using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>A Sequence supporting UNIX formatted text in byte[] format.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/RawText", DoNotGenerateAcw=true)]
	public partial class RawText : global::Org.Eclipse.Jgit.Diff.Sequence {

		/// <summary>The file content for this sequence.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/field[@name='content']"
		[Register ("content")]
		protected IList<byte> Content {
			get {
				const string __id = "content.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "content.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>A Rawtext of length 0</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/field[@name='EMPTY_TEXT']"
		[Register ("EMPTY_TEXT")]
		public static global::Org.Eclipse.Jgit.Diff.RawText EmptyText {
			get {
				const string __id = "EMPTY_TEXT.Lorg/eclipse/jgit/diff/RawText;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Map of line number to starting position within <c>#content</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/field[@name='lines']"
		[Register ("lines")]
		protected global::Org.Eclipse.Jgit.Util.IntList Lines {
			get {
				const string __id = "lines.Lorg/eclipse/jgit/util/IntList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IntList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lines.Lorg/eclipse/jgit/util/IntList;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/RawText", typeof (RawText));

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

		protected RawText (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="input">the content array. The array is never modified, so passing
		///            through cached arrays is safe.</param>
		/// <summary>Create a new sequence from an existing content byte array.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/constructor[@name='RawText' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe RawText (byte[] input) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
				global::System.GC.KeepAlive (input);
			}
		}

		/// <param name="file">the text file.</param>
		/// <summary>Create a new sequence from a file.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/constructor[@name='RawText' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe RawText (global::Java.IO.File file) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (file);
			}
		}

		static Delegate cb_isMissingNewlineAtEnd;
#pragma warning disable 0169
		static Delegate GetIsMissingNewlineAtEndHandler ()
		{
			if (cb_isMissingNewlineAtEnd == null)
				cb_isMissingNewlineAtEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMissingNewlineAtEnd);
			return cb_isMissingNewlineAtEnd;
		}

		static bool n_IsMissingNewlineAtEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMissingNewlineAtEnd;
		}
#pragma warning restore 0169

		/// <summary>Determine if the file ends with a LF ('\n').</summary>
		/// <returns>true if the last line has an LF; false otherwise.</returns>
		public virtual unsafe bool IsMissingNewlineAtEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='isMissingNewlineAtEnd' and count(parameter)=0]"
			[Register ("isMissingNewlineAtEnd", "()Z", "GetIsMissingNewlineAtEndHandler")]
			get {
				const string __id = "isMissingNewlineAtEnd.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLineDelimiter;
#pragma warning disable 0169
		static Delegate GetGetLineDelimiterHandler ()
		{
			if (cb_getLineDelimiter == null)
				cb_getLineDelimiter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLineDelimiter);
			return cb_getLineDelimiter;
		}

		static IntPtr n_GetLineDelimiter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LineDelimiter);
		}
#pragma warning restore 0169

		/// <summary>Get the line delimiter for the first line.</summary>
		/// <returns>the line delimiter or &lt;code&gt;null&lt;/code&gt;</returns>
		public virtual unsafe string LineDelimiter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='getLineDelimiter' and count(parameter)=0]"
			[Register ("getLineDelimiter", "()Ljava/lang/String;", "GetGetLineDelimiterHandler")]
			get {
				const string __id = "getLineDelimiter.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_decode_II;
#pragma warning disable 0169
		static Delegate GetDecode_IIHandler ()
		{
			if (cb_decode_II == null)
				cb_decode_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_Decode_II);
			return cb_decode_II;
		}

		static IntPtr n_Decode_II (IntPtr jnienv, IntPtr native__this, int start, int end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Decode (start, end));
		}
#pragma warning restore 0169

		/// <param name="start">first byte of the content to decode.</param>
		/// <param name="end">one past the last byte of the content to decode.</param>
		/// <summary>Decode a region of the text into a String.</summary>
		/// <returns>the region <c>[start, end)</c> decoded as a String.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("decode", "(II)Ljava/lang/String;", "GetDecode_IIHandler")]
		protected virtual unsafe string Decode (int start, int end)
		{
			const string __id = "decode.(II)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (end);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getString_I;
#pragma warning disable 0169
		static Delegate GetGetString_IHandler ()
		{
			if (cb_getString_I == null)
				cb_getString_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetString_I);
			return cb_getString_I;
		}

		static IntPtr n_GetString_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetString (i));
		}
#pragma warning restore 0169

		/// <param name="i">index of the line to extract. Note this is 0-based, so line
		///            number 1 is actually index 0.</param>
		/// <summary>Get the text for a single line.</summary>
		/// <returns>the text for the line, without a trailing LF.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getString", "(I)Ljava/lang/String;", "GetGetString_IHandler")]
		public virtual unsafe string GetString (int i)
		{
			const string __id = "getString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getString_IIZ;
#pragma warning disable 0169
		static Delegate GetGetString_IIZHandler ()
		{
			if (cb_getString_IIZ == null)
				cb_getString_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIZ_L) n_GetString_IIZ);
			return cb_getString_IIZ;
		}

		static IntPtr n_GetString_IIZ (IntPtr jnienv, IntPtr native__this, int begin, int end, bool dropLF)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetString (begin, end, dropLF));
		}
#pragma warning restore 0169

		/// <param name="begin">index of the first line to extract. Note this is 0-based, so
		///            line number 1 is actually index 0.</param>
		/// <param name="end">index of one past the last line to extract.</param>
		/// <param name="dropLF">if true the trailing LF ('\n') of the last returned line is
		///            dropped, if present.</param>
		/// <summary>Get the text for a region of lines.</summary>
		/// <returns>the text for lines <c>[begin, end)</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='getString' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("getString", "(IIZ)Ljava/lang/String;", "GetGetString_IIZHandler")]
		public virtual unsafe string GetString (int begin, int end, bool dropLF)
		{
			const string __id = "getString.(IIZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (begin);
				__args [1] = new JniArgumentValue (end);
				__args [2] = new JniArgumentValue (dropLF);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="raw">the raw file content.</param>
		/// <summary>Determine heuristically whether a byte array represents binary (as
		/// opposed to text) content.</summary>
		/// <returns>true if raw is likely to be a binary file, false otherwise</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='isBinary' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isBinary", "([B)Z", "")]
		public static unsafe bool IsBinary (byte[] raw)
		{
			const string __id = "isBinary.([B)Z";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_raw);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="raw">the raw file content.</param>
		/// <param name="length">number of bytes in <c>raw</c> to evaluate. This should be
		///            <c>raw.length</c> unless <c>raw</c> was over-allocated by
		///            the caller.</param>
		/// <summary>Determine heuristically whether a byte array represents binary (as
		/// opposed to text) content.</summary>
		/// <returns>true if raw is likely to be a binary file, false otherwise</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='isBinary' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("isBinary", "([BI)Z", "")]
		public static unsafe bool IsBinary (byte[] raw, int length)
		{
			const string __id = "isBinary.([BI)Z";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="raw">input stream containing the raw file content.</param>
		/// <summary>Determine heuristically whether the bytes contained in a stream
		/// represents binary (as opposed to text) content.</summary>
		/// <returns>true if raw is likely to be a binary file, false otherwise</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='isBinary' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("isBinary", "(Ljava/io/InputStream;)Z", "")]
		public static unsafe bool IsBinary (global::System.IO.Stream raw)
		{
			const string __id = "isBinary.(Ljava/io/InputStream;)Z";
			IntPtr native_raw = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_raw);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_raw);
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		/// <returns>total number of items in the sequence.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_writeLine_Ljava_io_OutputStream_I;
#pragma warning disable 0169
		static Delegate GetWriteLine_Ljava_io_OutputStream_IHandler ()
		{
			if (cb_writeLine_Ljava_io_OutputStream_I == null)
				cb_writeLine_Ljava_io_OutputStream_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteLine_Ljava_io_OutputStream_I);
			return cb_writeLine_Ljava_io_OutputStream_I;
		}

		static void n_WriteLine_Ljava_io_OutputStream_I (IntPtr jnienv, IntPtr native__this, IntPtr native__out, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.WriteLine (@out, i);
		}
#pragma warning restore 0169

		/// <param name="out">stream to copy the line data onto.</param>
		/// <param name="i">index of the line to extract. Note this is 0-based, so line
		///            number 1 is actually index 0.</param>
		/// <summary>Write a specific line to the output stream, without its trailing LF.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawText']/method[@name='writeLine' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='int']]"
		[Register ("writeLine", "(Ljava/io/OutputStream;I)V", "GetWriteLine_Ljava_io_OutputStream_IHandler")]
		public virtual unsafe void WriteLine (global::System.IO.Stream @out, int i)
		{
			const string __id = "writeLine.(Ljava/io/OutputStream;I)V";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__out);
				__args [1] = new JniArgumentValue (i);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (@out);
			}
		}

	}
}
