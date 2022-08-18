using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util.IO {

	/// <summary>An alternative PrintWriter that doesn't catch exceptions.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/io/ThrowingPrintWriter", DoNotGenerateAcw=true)]
	public partial class ThrowingPrintWriter : global::Java.IO.Writer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/io/ThrowingPrintWriter", typeof (ThrowingPrintWriter));

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

		protected ThrowingPrintWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="out">the underlying <c>Writer</c></param>
		/// <summary>Construct a JGitPrintWriter</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/constructor[@name='ThrowingPrintWriter' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register (".ctor", "(Ljava/io/Writer;)V", "")]
		public unsafe ThrowingPrintWriter (global::Java.IO.Writer @out) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@out);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public override unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_format_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_format_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_format_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Format_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_format_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Format_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fmt, IntPtr native_args)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fmt = JNIEnv.GetString (native_fmt, JniHandleOwnership.DoNotTransfer);
			var args = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Format (fmt, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("format", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetFormat_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Format (string fmt, params global::Java.Lang.Object[] args)
		{
			const string __id = "format.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_fmt = JNIEnv.NewString ((string)fmt);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fmt);
				__args [1] = new JniArgumentValue (native_args);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fmt);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

		static Delegate cb_print_C;
#pragma warning disable 0169
		static Delegate GetPrint_CHandler ()
		{
			if (cb_print_C == null)
				cb_print_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_V) n_Print_C);
			return cb_print_C;
		}

		static void n_Print_C (IntPtr jnienv, IntPtr native__this, char value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Print (value);
		}
#pragma warning restore 0169

		/// <param name="value">value</param>
		/// <summary>Print a char</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='print' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("print", "(C)V", "GetPrint_CHandler")]
		public virtual unsafe void Print (char value)
		{
			const string __id = "print.(C)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_print_I;
#pragma warning disable 0169
		static Delegate GetPrint_IHandler ()
		{
			if (cb_print_I == null)
				cb_print_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Print_I);
			return cb_print_I;
		}

		static void n_Print_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Print (value);
		}
#pragma warning restore 0169

		/// <param name="value">value</param>
		/// <summary>Print an int as string</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='print' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("print", "(I)V", "GetPrint_IHandler")]
		public virtual unsafe void Print (int value)
		{
			const string __id = "print.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_print_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPrint_Ljava_lang_Object_Handler ()
		{
			if (cb_print_Ljava_lang_Object_ == null)
				cb_print_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Print_Ljava_lang_Object_);
			return cb_print_Ljava_lang_Object_;
		}

		static void n_Print_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_any)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var any = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_any, JniHandleOwnership.DoNotTransfer);
			__this.Print (any);
		}
#pragma warning restore 0169

		/// <param name="any">any</param>
		/// <summary>Print an object's toString representations</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='print' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("print", "(Ljava/lang/Object;)V", "GetPrint_Ljava_lang_Object_Handler")]
		public virtual unsafe void Print (global::Java.Lang.Object any)
		{
			const string __id = "print.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((any == null) ? IntPtr.Zero : ((global::Java.Lang.Object) any).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (any);
			}
		}

		static Delegate cb_print_J;
#pragma warning disable 0169
		static Delegate GetPrint_JHandler ()
		{
			if (cb_print_J == null)
				cb_print_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Print_J);
			return cb_print_J;
		}

		static void n_Print_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Print (value);
		}
#pragma warning restore 0169

		/// <param name="value">value</param>
		/// <summary>Print a long as string</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='print' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("print", "(J)V", "GetPrint_JHandler")]
		public virtual unsafe void Print (long value)
		{
			const string __id = "print.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_print_S;
#pragma warning disable 0169
		static Delegate GetPrint_SHandler ()
		{
			if (cb_print_S == null)
				cb_print_S = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPS_V) n_Print_S);
			return cb_print_S;
		}

		static void n_Print_S (IntPtr jnienv, IntPtr native__this, short value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Print (value);
		}
#pragma warning restore 0169

		/// <param name="value">value</param>
		/// <summary>Print a short as string</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='print' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("print", "(S)V", "GetPrint_SHandler")]
		public virtual unsafe void Print (short value)
		{
			const string __id = "print.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_println;
#pragma warning disable 0169
		static Delegate GetPrintlnHandler ()
		{
			if (cb_println == null)
				cb_println = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Println);
			return cb_println;
		}

		static void n_Println (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Println ();
		}
#pragma warning restore 0169

		/// <summary>Print a platform dependent new line</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='println' and count(parameter)=0]"
		[Register ("println", "()V", "GetPrintlnHandler")]
		public virtual unsafe void Println ()
		{
			const string __id = "println.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_println_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrintln_Ljava_lang_String_Handler ()
		{
			if (cb_println_Ljava_lang_String_ == null)
				cb_println_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Println_Ljava_lang_String_);
			return cb_println_Ljava_lang_String_;
		}

		static void n_Println_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.Println (s);
		}
#pragma warning restore 0169

		/// <param name="s">s</param>
		/// <summary>Print a string and terminate with a line feed.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='println' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("println", "(Ljava/lang/String;)V", "GetPrintln_Ljava_lang_String_Handler")]
		public virtual unsafe void Println (string s)
		{
			const string __id = "println.(Ljava/lang/String;)V";
			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_write_arrayCII;
#pragma warning disable 0169
		static Delegate GetWrite_arrayCIIHandler ()
		{
			if (cb_write_arrayCII == null)
				cb_write_arrayCII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_Write_arrayCII);
			return cb_write_arrayCII;
		}

		static void n_Write_arrayCII (IntPtr jnienv, IntPtr native__this, IntPtr native_cbuf, int off, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.ThrowingPrintWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cbuf = (char[]) JNIEnv.GetArray (native_cbuf, JniHandleOwnership.DoNotTransfer, typeof (char));
			__this.Write (cbuf, off, len);
			if (cbuf != null)
				JNIEnv.CopyArray (cbuf, native_cbuf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='ThrowingPrintWriter']/method[@name='write' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([CII)V", "GetWrite_arrayCIIHandler")]
		public override unsafe void Write (char[] cbuf, int off, int len)
		{
			const string __id = "write.([CII)V";
			IntPtr native_cbuf = JNIEnv.NewArray (cbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_cbuf);
				__args [1] = new JniArgumentValue (off);
				__args [2] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (cbuf != null) {
					JNIEnv.CopyArray (native_cbuf, cbuf);
					JNIEnv.DeleteLocalRef (native_cbuf);
				}
				global::System.GC.KeepAlive (cbuf);
			}
		}

	}
}
