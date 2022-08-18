using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Utility functions related to quoted string handling.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/QuotedString", DoNotGenerateAcw=true)]
	public abstract partial class QuotedString : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']/field[@name='BOURNE']"
		[Register ("BOURNE")]
		public static global::Org.Eclipse.Jgit.Util.QuotedString.BourneStyle Bourne {
			get {
				const string __id = "BOURNE.Lorg/eclipse/jgit/util/QuotedString$BourneStyle;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.QuotedString.BourneStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']/field[@name='BOURNE_USER_PATH']"
		[Register ("BOURNE_USER_PATH")]
		public static global::Org.Eclipse.Jgit.Util.QuotedString.BourneUserPathStyle BourneUserPath {
			get {
				const string __id = "BOURNE_USER_PATH.Lorg/eclipse/jgit/util/QuotedString$BourneUserPathStyle;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.QuotedString.BourneUserPathStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']/field[@name='GIT_PATH']"
		[Register ("GIT_PATH")]
		public static global::Org.Eclipse.Jgit.Util.QuotedString.GitPathStyle GitPath {
			get {
				const string __id = "GIT_PATH.Lorg/eclipse/jgit/util/QuotedString$GitPathStyle;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.QuotedString.GitPathStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>Quoting style used by the Bourne shell.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString.BourneStyle']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/QuotedString$BourneStyle", DoNotGenerateAcw=true)]
		public partial class BourneStyle : global::Org.Eclipse.Jgit.Util.QuotedString {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/QuotedString$BourneStyle", typeof (BourneStyle));

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

			protected BourneStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString.BourneStyle']/constructor[@name='QuotedString.BourneStyle' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BourneStyle () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_dequote_arrayBII;
#pragma warning disable 0169
			static Delegate GetDequote_arrayBIIHandler ()
			{
				if (cb_dequote_arrayBII == null)
					cb_dequote_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Dequote_arrayBII);
				return cb_dequote_arrayBII;
			}

			static IntPtr n_Dequote_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native__in, int ip, int ie)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.QuotedString.BourneStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @in = (byte[]) JNIEnv.GetArray (native__in, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewString (__this.Dequote (@in, ip, ie));
				if (@in != null)
					JNIEnv.CopyArray (@in, native__in);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString.BourneStyle']/method[@name='dequote' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("dequote", "([BII)Ljava/lang/String;", "GetDequote_arrayBIIHandler")]
			public override unsafe string Dequote (byte[] @in, int ip, int ie)
			{
				const string __id = "dequote.([BII)Ljava/lang/String;";
				IntPtr native__in = JNIEnv.NewArray (@in);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native__in);
					__args [1] = new JniArgumentValue (ip);
					__args [2] = new JniArgumentValue (ie);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (@in != null) {
						JNIEnv.CopyArray (native__in, @in);
						JNIEnv.DeleteLocalRef (native__in);
					}
					global::System.GC.KeepAlive (@in);
				}
			}

			static Delegate cb_quote_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetQuote_Ljava_lang_String_Handler ()
			{
				if (cb_quote_Ljava_lang_String_ == null)
					cb_quote_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Quote_Ljava_lang_String_);
				return cb_quote_Ljava_lang_String_;
			}

			static IntPtr n_Quote_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.QuotedString.BourneStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @in = JNIEnv.GetString (native__in, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.Quote (@in));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString.BourneStyle']/method[@name='quote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("quote", "(Ljava/lang/String;)Ljava/lang/String;", "GetQuote_Ljava_lang_String_Handler")]
			public override unsafe string Quote (string @in)
			{
				const string __id = "quote.(Ljava/lang/String;)Ljava/lang/String;";
				IntPtr native__in = JNIEnv.NewString ((string)@in);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native__in);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native__in);
				}
			}

		}

		/// <summary>Bourne style, but permits &lt;code&gt;~user&lt;/code&gt; at the start of the string.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString.BourneUserPathStyle']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/QuotedString$BourneUserPathStyle", DoNotGenerateAcw=true)]
		public partial class BourneUserPathStyle : global::Org.Eclipse.Jgit.Util.QuotedString.BourneStyle {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/QuotedString$BourneUserPathStyle", typeof (BourneUserPathStyle));

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

			protected BourneUserPathStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString.BourneUserPathStyle']/constructor[@name='QuotedString.BourneUserPathStyle' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BourneUserPathStyle () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		/// <summary>Quoting style that obeys the rules Git applies to file names</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString.GitPathStyle']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/QuotedString$GitPathStyle", DoNotGenerateAcw=true)]
		public sealed partial class GitPathStyle : global::Org.Eclipse.Jgit.Util.QuotedString {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/QuotedString$GitPathStyle", typeof (GitPathStyle));

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

			internal GitPathStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString.GitPathStyle']/method[@name='dequote' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("dequote", "([BII)Ljava/lang/String;", "")]
			public override unsafe string Dequote (byte[] @in, int inPtr, int inEnd)
			{
				const string __id = "dequote.([BII)Ljava/lang/String;";
				IntPtr native__in = JNIEnv.NewArray (@in);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native__in);
					__args [1] = new JniArgumentValue (inPtr);
					__args [2] = new JniArgumentValue (inEnd);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (@in != null) {
						JNIEnv.CopyArray (native__in, @in);
						JNIEnv.DeleteLocalRef (native__in);
					}
					global::System.GC.KeepAlive (@in);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString.GitPathStyle']/method[@name='quote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("quote", "(Ljava/lang/String;)Ljava/lang/String;", "")]
			public override unsafe string Quote (string instr)
			{
				const string __id = "quote.(Ljava/lang/String;)Ljava/lang/String;";
				IntPtr native_instr = JNIEnv.NewString ((string)instr);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_instr);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_instr);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/QuotedString", typeof (QuotedString));

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

		protected QuotedString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']/constructor[@name='QuotedString' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QuotedString () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dequote_arrayBII;
#pragma warning disable 0169
		static Delegate GetDequote_arrayBIIHandler ()
		{
			if (cb_dequote_arrayBII == null)
				cb_dequote_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Dequote_arrayBII);
			return cb_dequote_arrayBII;
		}

		static IntPtr n_Dequote_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native__in, int offset, int end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.QuotedString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = (byte[]) JNIEnv.GetArray (native__in, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.Dequote (@in, offset, end));
			if (@in != null)
				JNIEnv.CopyArray (@in, native__in);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="in">the input buffer to parse.</param>
		/// <param name="offset">first position within &lt;code&gt;in&lt;/code&gt; to scan.</param>
		/// <param name="end">one position past in &lt;code&gt;in&lt;/code&gt; to scan.</param>
		/// <summary>Decode a previously quoted input, scanning a UTF-8 encoded buffer.</summary>
		/// <returns>the cleaned string.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']/method[@name='dequote' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dequote", "([BII)Ljava/lang/String;", "GetDequote_arrayBIIHandler")]
		public abstract string Dequote (byte[] @in, int offset, int end);

		static Delegate cb_dequote_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDequote_Ljava_lang_String_Handler ()
		{
			if (cb_dequote_Ljava_lang_String_ == null)
				cb_dequote_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Dequote_Ljava_lang_String_);
			return cb_dequote_Ljava_lang_String_;
		}

		static IntPtr n_Dequote_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.QuotedString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = JNIEnv.GetString (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Dequote (@in));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="in">a Unicode string to remove quoting from.</param>
		/// <summary>Clean a previously quoted input, decoding the result via UTF-8.</summary>
		/// <returns>the cleaned string.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']/method[@name='dequote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dequote", "(Ljava/lang/String;)Ljava/lang/String;", "GetDequote_Ljava_lang_String_Handler")]
		public virtual unsafe string Dequote (string @in)
		{
			const string __id = "dequote.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__in = JNIEnv.NewString ((string)@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static Delegate cb_quote_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuote_Ljava_lang_String_Handler ()
		{
			if (cb_quote_Ljava_lang_String_ == null)
				cb_quote_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Quote_Ljava_lang_String_);
			return cb_quote_Ljava_lang_String_;
		}

		static IntPtr n_Quote_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.QuotedString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = JNIEnv.GetString (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Quote (@in));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="in">any non-null Unicode string.</param>
		/// <summary>Quote an input string by the quoting rules.</summary>
		/// <returns>a quoted string. See above for details.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']/method[@name='quote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("quote", "(Ljava/lang/String;)Ljava/lang/String;", "GetQuote_Ljava_lang_String_Handler")]
		public abstract string Quote (string @in);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/util/QuotedString", DoNotGenerateAcw=true)]
	internal partial class QuotedStringInvoker : QuotedString {
		public QuotedStringInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/QuotedString", typeof (QuotedStringInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		/// <param name="in">the input buffer to parse.</param>
		/// <param name="offset">first position within &lt;code&gt;in&lt;/code&gt; to scan.</param>
		/// <param name="end">one position past in &lt;code&gt;in&lt;/code&gt; to scan.</param>
		/// <summary>Decode a previously quoted input, scanning a UTF-8 encoded buffer.</summary>
		/// <returns>the cleaned string.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']/method[@name='dequote' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dequote", "([BII)Ljava/lang/String;", "GetDequote_arrayBIIHandler")]
		public override unsafe string Dequote (byte[] @in, int offset, int end)
		{
			const string __id = "dequote.([BII)Ljava/lang/String;";
			IntPtr native__in = JNIEnv.NewArray (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (@in != null) {
					JNIEnv.CopyArray (native__in, @in);
					JNIEnv.DeleteLocalRef (native__in);
				}
				global::System.GC.KeepAlive (@in);
			}
		}

		/// <param name="in">any non-null Unicode string.</param>
		/// <summary>Quote an input string by the quoting rules.</summary>
		/// <returns>a quoted string. See above for details.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='QuotedString']/method[@name='quote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("quote", "(Ljava/lang/String;)Ljava/lang/String;", "GetQuote_Ljava_lang_String_Handler")]
		public override unsafe string Quote (string @in)
		{
			const string __id = "quote.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__in = JNIEnv.NewString ((string)@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

	}
}
