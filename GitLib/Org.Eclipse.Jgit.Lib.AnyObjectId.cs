using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A (possibly mutable) SHA-1 abstraction.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/AnyObjectId", DoNotGenerateAcw=true)]
	public partial class AnyObjectId : global::Java.Lang.Object, global::Java.Lang.IComparable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/AnyObjectId", typeof (AnyObjectId));

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

		protected AnyObjectId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/constructor[@name='AnyObjectId' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnyObjectId () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <summary>Get the first 8 bits of the ObjectId.</summary>
		/// <returns>a discriminator usable for a fan-out style map. Returned values
		///         are unsigned and thus are in the range [0,255] rather than the
		///         signed byte range of [-128, 127].</returns>
		public unsafe int FirstByte {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='getFirstByte' and count(parameter)=0]"
			[Register ("getFirstByte", "()I", "")]
			get {
				const string __id = "getFirstByte.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>string form of the SHA-1, in lower case hexadecimal.</returns>
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_abbreviate_I;
#pragma warning disable 0169
		static Delegate GetAbbreviate_IHandler ()
		{
			if (cb_abbreviate_I == null)
				cb_abbreviate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Abbreviate_I);
			return cb_abbreviate_I;
		}

		static IntPtr n_Abbreviate_I (IntPtr jnienv, IntPtr native__this, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Abbreviate (len));
		}
#pragma warning restore 0169

		/// <param name="len">length of the abbreviated string.</param>
		/// <summary>Return an abbreviation (prefix) of this object SHA-1.</summary>
		/// <returns>SHA-1 abbreviation.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='abbreviate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("abbreviate", "(I)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetAbbreviate_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId Abbreviate (int len)
		{
			const string __id = "abbreviate.(I)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (len);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="bs">array containing the other ObjectId in network byte order.</param>
		/// <param name="p">position within <c>bs</c> to start the compare at. At least
		///            20 bytes, starting at this position are required.</param>
		/// <summary>Compare this ObjectId to a network-byte-order ObjectId.</summary>
		/// <returns>a negative integer, zero, or a positive integer as this object is
		///         less than, equal to, or greater than the specified object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("compareTo", "([BI)I", "")]
		public unsafe int CompareTo (byte[] bs, int p)
		{
			const string __id = "compareTo.([BI)I";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bs);
				__args [1] = new JniArgumentValue (p);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		/// <param name="bs">array containing the other ObjectId in network byte order.</param>
		/// <param name="p">position within <c>bs</c> to start the compare at. At least 5
		///            integers, starting at this position are required.</param>
		/// <summary>Compare this ObjectId to a network-byte-order ObjectId.</summary>
		/// <returns>a negative integer, zero, or a positive integer as this object is
		///         less than, equal to, or greater than the specified object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("compareTo", "([II)I", "")]
		public unsafe int CompareTo (int[] bs, int p)
		{
			const string __id = "compareTo.([II)I";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bs);
				__args [1] = new JniArgumentValue (p);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		/// <param name="other">the other id to compare to. Must not be null.</param>
		/// <summary>Compare this ObjectId to another and obtain a sort ordering.</summary>
		/// <returns>&amp;lt; 0 if this id comes before other; 0 if this id is equal to
		///         other; &amp;gt; 0 if this id comes after other.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("compareTo", "(Lorg/eclipse/jgit/lib/AnyObjectId;)I", "")]
		public unsafe int CompareTo (global::Org.Eclipse.Jgit.Lib.AnyObjectId other)
		{
			const string __id = "compareTo.(Lorg/eclipse/jgit/lib/AnyObjectId;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		/// <summary>Obtain an immutable copy of this current object name value.</summary>
		/// <returns>an immutable copy, using the smallest memory footprint possible.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Copy ()
		{
			const string __id = "copy.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_copyRawTo_arrayBI;
#pragma warning disable 0169
		static Delegate GetCopyRawTo_arrayBIHandler ()
		{
			if (cb_copyRawTo_arrayBI == null)
				cb_copyRawTo_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_CopyRawTo_arrayBI);
			return cb_copyRawTo_arrayBI;
		}

		static void n_CopyRawTo_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_b, int o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var b = (byte[]) JNIEnv.GetArray (native_b, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CopyRawTo (b, o);
			if (b != null)
				JNIEnv.CopyArray (b, native_b);
		}
#pragma warning restore 0169

		/// <param name="b">the buffer to copy to.</param>
		/// <param name="o">the offset within b to write at.</param>
		/// <summary>Copy this ObjectId to a byte array.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyRawTo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("copyRawTo", "([BI)V", "GetCopyRawTo_arrayBIHandler")]
		public virtual unsafe void CopyRawTo (byte[] b, int o)
		{
			const string __id = "copyRawTo.([BI)V";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (o);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_copyRawTo_arrayII;
#pragma warning disable 0169
		static Delegate GetCopyRawTo_arrayIIHandler ()
		{
			if (cb_copyRawTo_arrayII == null)
				cb_copyRawTo_arrayII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_CopyRawTo_arrayII);
			return cb_copyRawTo_arrayII;
		}

		static void n_CopyRawTo_arrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_b, int o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var b = (int[]) JNIEnv.GetArray (native_b, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.CopyRawTo (b, o);
			if (b != null)
				JNIEnv.CopyArray (b, native_b);
		}
#pragma warning restore 0169

		/// <param name="b">the buffer to copy to.</param>
		/// <param name="o">the offset within b to write at.</param>
		/// <summary>Copy this ObjectId to an int array.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyRawTo' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("copyRawTo", "([II)V", "GetCopyRawTo_arrayIIHandler")]
		public virtual unsafe void CopyRawTo (int[] b, int o)
		{
			const string __id = "copyRawTo.([II)V";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (o);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_copyRawTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetCopyRawTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_copyRawTo_Ljava_io_OutputStream_ == null)
				cb_copyRawTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CopyRawTo_Ljava_io_OutputStream_);
			return cb_copyRawTo_Ljava_io_OutputStream_;
		}

		static void n_CopyRawTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_w)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var w = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_w, JniHandleOwnership.DoNotTransfer);
			__this.CopyRawTo (w);
		}
#pragma warning restore 0169

		/// <param name="w">the stream to write to.</param>
		/// <summary>Copy this ObjectId to an output writer in raw binary.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyRawTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("copyRawTo", "(Ljava/io/OutputStream;)V", "GetCopyRawTo_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void CopyRawTo (global::System.IO.Stream w)
		{
			const string __id = "copyRawTo.(Ljava/io/OutputStream;)V";
			IntPtr native_w = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (w);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_w);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_w);
				global::System.GC.KeepAlive (w);
			}
		}

		static Delegate cb_copyRawTo_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetCopyRawTo_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_copyRawTo_Ljava_nio_ByteBuffer_ == null)
				cb_copyRawTo_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CopyRawTo_Ljava_nio_ByteBuffer_);
			return cb_copyRawTo_Ljava_nio_ByteBuffer_;
		}

		static void n_CopyRawTo_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_w)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var w = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_w, JniHandleOwnership.DoNotTransfer);
			__this.CopyRawTo (w);
		}
#pragma warning restore 0169

		/// <param name="w">the buffer to copy to. Must be in big endian order.</param>
		/// <summary>Copy this ObjectId to an output writer in raw binary.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyRawTo' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("copyRawTo", "(Ljava/nio/ByteBuffer;)V", "GetCopyRawTo_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void CopyRawTo (global::Java.Nio.ByteBuffer w)
		{
			const string __id = "copyRawTo.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((w == null) ? IntPtr.Zero : ((global::Java.Lang.Object) w).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (w);
			}
		}

		static Delegate cb_copyTo_arrayBI;
#pragma warning disable 0169
		static Delegate GetCopyTo_arrayBIHandler ()
		{
			if (cb_copyTo_arrayBI == null)
				cb_copyTo_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_CopyTo_arrayBI);
			return cb_copyTo_arrayBI;
		}

		static void n_CopyTo_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_b, int o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var b = (byte[]) JNIEnv.GetArray (native_b, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CopyTo (b, o);
			if (b != null)
				JNIEnv.CopyArray (b, native_b);
		}
#pragma warning restore 0169

		/// <param name="b">the buffer to copy to.</param>
		/// <param name="o">the offset within b to write at.</param>
		/// <summary>Copy this ObjectId to a byte array in hex format.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyTo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("copyTo", "([BI)V", "GetCopyTo_arrayBIHandler")]
		public virtual unsafe void CopyTo (byte[] b, int o)
		{
			const string __id = "copyTo.([BI)V";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (o);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_copyTo_arrayCLjava_io_Writer_;
#pragma warning disable 0169
		static Delegate GetCopyTo_arrayCLjava_io_Writer_Handler ()
		{
			if (cb_copyTo_arrayCLjava_io_Writer_ == null)
				cb_copyTo_arrayCLjava_io_Writer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CopyTo_arrayCLjava_io_Writer_);
			return cb_copyTo_arrayCLjava_io_Writer_;
		}

		static void n_CopyTo_arrayCLjava_io_Writer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tmp, IntPtr native_w)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tmp = (char[]) JNIEnv.GetArray (native_tmp, JniHandleOwnership.DoNotTransfer, typeof (char));
			var w = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_w, JniHandleOwnership.DoNotTransfer);
			__this.CopyTo (tmp, w);
			if (tmp != null)
				JNIEnv.CopyArray (tmp, native_tmp);
		}
#pragma warning restore 0169

		/// <param name="tmp">temporary char array to buffer construct into before writing.
		///            Must be at least large enough to hold 2 digits for each byte
		///            of object id (40 characters or larger).</param>
		/// <param name="w">the stream to copy to.</param>
		/// <summary>Copy this ObjectId to an output writer in hex format.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyTo' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='java.io.Writer']]"
		[Register ("copyTo", "([CLjava/io/Writer;)V", "GetCopyTo_arrayCLjava_io_Writer_Handler")]
		public virtual unsafe void CopyTo (char[] tmp, global::Java.IO.Writer w)
		{
			const string __id = "copyTo.([CLjava/io/Writer;)V";
			IntPtr native_tmp = JNIEnv.NewArray (tmp);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tmp);
				__args [1] = new JniArgumentValue ((w == null) ? IntPtr.Zero : ((global::Java.Lang.Object) w).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (tmp != null) {
					JNIEnv.CopyArray (native_tmp, tmp);
					JNIEnv.DeleteLocalRef (native_tmp);
				}
				global::System.GC.KeepAlive (tmp);
				global::System.GC.KeepAlive (w);
			}
		}

		static Delegate cb_copyTo_arrayCLjava_lang_StringBuilder_;
#pragma warning disable 0169
		static Delegate GetCopyTo_arrayCLjava_lang_StringBuilder_Handler ()
		{
			if (cb_copyTo_arrayCLjava_lang_StringBuilder_ == null)
				cb_copyTo_arrayCLjava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CopyTo_arrayCLjava_lang_StringBuilder_);
			return cb_copyTo_arrayCLjava_lang_StringBuilder_;
		}

		static void n_CopyTo_arrayCLjava_lang_StringBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tmp, IntPtr native_w)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tmp = (char[]) JNIEnv.GetArray (native_tmp, JniHandleOwnership.DoNotTransfer, typeof (char));
			var w = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_w, JniHandleOwnership.DoNotTransfer);
			__this.CopyTo (tmp, w);
			if (tmp != null)
				JNIEnv.CopyArray (tmp, native_tmp);
		}
#pragma warning restore 0169

		/// <param name="tmp">temporary char array to buffer construct into before writing.
		///            Must be at least large enough to hold 2 digits for each byte
		///            of object id (40 characters or larger).</param>
		/// <param name="w">the string to append onto.</param>
		/// <summary>Copy this ObjectId to a StringBuilder in hex format.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyTo' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='java.lang.StringBuilder']]"
		[Register ("copyTo", "([CLjava/lang/StringBuilder;)V", "GetCopyTo_arrayCLjava_lang_StringBuilder_Handler")]
		public virtual unsafe void CopyTo (char[] tmp, global::Java.Lang.StringBuilder w)
		{
			const string __id = "copyTo.([CLjava/lang/StringBuilder;)V";
			IntPtr native_tmp = JNIEnv.NewArray (tmp);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tmp);
				__args [1] = new JniArgumentValue ((w == null) ? IntPtr.Zero : ((global::Java.Lang.Object) w).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (tmp != null) {
					JNIEnv.CopyArray (native_tmp, tmp);
					JNIEnv.DeleteLocalRef (native_tmp);
				}
				global::System.GC.KeepAlive (tmp);
				global::System.GC.KeepAlive (w);
			}
		}

		static Delegate cb_copyTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetCopyTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_copyTo_Ljava_io_OutputStream_ == null)
				cb_copyTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CopyTo_Ljava_io_OutputStream_);
			return cb_copyTo_Ljava_io_OutputStream_;
		}

		static void n_CopyTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_w)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var w = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_w, JniHandleOwnership.DoNotTransfer);
			__this.CopyTo (w);
		}
#pragma warning restore 0169

		/// <param name="w">the stream to copy to.</param>
		/// <summary>Copy this ObjectId to an output writer in hex format.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("copyTo", "(Ljava/io/OutputStream;)V", "GetCopyTo_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void CopyTo (global::System.IO.Stream w)
		{
			const string __id = "copyTo.(Ljava/io/OutputStream;)V";
			IntPtr native_w = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (w);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_w);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_w);
				global::System.GC.KeepAlive (w);
			}
		}

		static Delegate cb_copyTo_Ljava_io_Writer_;
#pragma warning disable 0169
		static Delegate GetCopyTo_Ljava_io_Writer_Handler ()
		{
			if (cb_copyTo_Ljava_io_Writer_ == null)
				cb_copyTo_Ljava_io_Writer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CopyTo_Ljava_io_Writer_);
			return cb_copyTo_Ljava_io_Writer_;
		}

		static void n_CopyTo_Ljava_io_Writer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_w)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var w = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_w, JniHandleOwnership.DoNotTransfer);
			__this.CopyTo (w);
		}
#pragma warning restore 0169

		/// <param name="w">the stream to copy to.</param>
		/// <summary>Copy this ObjectId to an output writer in hex format.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyTo' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register ("copyTo", "(Ljava/io/Writer;)V", "GetCopyTo_Ljava_io_Writer_Handler")]
		public virtual unsafe void CopyTo (global::Java.IO.Writer w)
		{
			const string __id = "copyTo.(Ljava/io/Writer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((w == null) ? IntPtr.Zero : ((global::Java.Lang.Object) w).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (w);
			}
		}

		static Delegate cb_copyTo_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetCopyTo_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_copyTo_Ljava_nio_ByteBuffer_ == null)
				cb_copyTo_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CopyTo_Ljava_nio_ByteBuffer_);
			return cb_copyTo_Ljava_nio_ByteBuffer_;
		}

		static void n_CopyTo_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_b, JniHandleOwnership.DoNotTransfer);
			__this.CopyTo (b);
		}
#pragma warning restore 0169

		/// <param name="b">the buffer to copy to.</param>
		/// <summary>Copy this ObjectId to a ByteBuffer in hex format.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='copyTo' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("copyTo", "(Ljava/nio/ByteBuffer;)V", "GetCopyTo_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void CopyTo (global::Java.Nio.ByteBuffer b)
		{
			const string __id = "copyTo.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (b);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object o)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		/// <param name="other">the other id to compare to. May be null.</param>
		/// <summary>Determine if this ObjectId has exactly the same value as another.</summary>
		/// <returns>true only if both ObjectIds have identical bits.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("equals", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "")]
		public unsafe bool Equals (global::Org.Eclipse.Jgit.Lib.AnyObjectId other)
		{
			const string __id = "equals.(Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		/// <param name="firstObjectId">the first identifier to compare. Must not be null.</param>
		/// <param name="secondObjectId">the second identifier to compare. Must not be null.</param>
		/// <summary>Compare to object identifier byte sequences for equality.</summary>
		/// <returns>true if the two identifiers are the same.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("equals", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "")]
		public static unsafe bool Equals (global::Org.Eclipse.Jgit.Lib.AnyObjectId firstObjectId, global::Org.Eclipse.Jgit.Lib.AnyObjectId secondObjectId)
		{
			const string __id = "equals.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((firstObjectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstObjectId).Handle);
				__args [1] = new JniArgumentValue ((secondObjectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secondObjectId).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (firstObjectId);
				global::System.GC.KeepAlive (secondObjectId);
			}
		}

		/// <param name="index">index of the byte to obtain from the raw form of the ObjectId.
		///            Must be in range [0, <c>Constants#OBJECT_ID_LENGTH</c>).</param>
		/// <summary>Get any byte from the ObjectId.</summary>
		/// <returns>the value of the requested byte at <c>index</c>. Returned values
		///         are unsigned and thus are in the range [0,255] rather than the
		///         signed byte range of [-128, 127].</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getByte", "(I)I", "")]
		public unsafe int GetByte (int index)
		{
			const string __id = "getByte.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <returns>string form of the SHA-1, in lower case hexadecimal.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "")]
		public unsafe string InvokeName ()
		{
			const string __id = "name.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_startsWith_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_;
#pragma warning disable 0169
		static Delegate GetStartsWith_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_Handler ()
		{
			if (cb_startsWith_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_ == null)
				cb_startsWith_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_StartsWith_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_);
			return cb_startsWith_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_;
		}

		static bool n_StartsWith_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_abbr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var abbr = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (native_abbr, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartsWith (abbr);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="abbr">the abbreviation.</param>
		/// <summary>Tests if this ObjectId starts with the given abbreviation.</summary>
		/// <returns>true if this ObjectId begins with the abbreviation; else false.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='startsWith' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AbbreviatedObjectId']]"
		[Register ("startsWith", "(Lorg/eclipse/jgit/lib/AbbreviatedObjectId;)Z", "GetStartsWith_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_Handler")]
		public virtual unsafe bool StartsWith (global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId abbr)
		{
			const string __id = "startsWith.(Lorg/eclipse/jgit/lib/AbbreviatedObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((abbr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) abbr).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (abbr);
			}
		}

		static Delegate cb_toObjectId;
#pragma warning disable 0169
		static Delegate GetToObjectIdHandler ()
		{
			if (cb_toObjectId == null)
				cb_toObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToObjectId);
			return cb_toObjectId;
		}

		static IntPtr n_ToObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToObjectId ());
		}
#pragma warning restore 0169

		/// <summary>Obtain an immutable copy of this current object name value.</summary>
		/// <returns>an immutable copy. May be &lt;code&gt;this&lt;/code&gt; if this is already
		///         an immutable instance.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='toObjectId' and count(parameter)=0]"
		[Register("toObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetToObjectIdHandler")]
		public virtual global::Org.Eclipse.Jgit.Lib.ObjectId ToObjectId() { throw new NotImplementedException(); }

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (o);
			return __ret;
		}
#pragma warning restore 0169

		[Register("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public virtual int CompareTo(global::Java.Lang.Object o) { throw new NotImplementedException(); }

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/AnyObjectId", DoNotGenerateAcw=true)]
	internal partial class AnyObjectIdInvoker : AnyObjectId {
		public AnyObjectIdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/AnyObjectId", typeof (AnyObjectIdInvoker));

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

		/// <summary>Obtain an immutable copy of this current object name value.</summary>
		/// <returns>an immutable copy. May be &lt;code&gt;this&lt;/code&gt; if this is already
		///         an immutable instance.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AnyObjectId']/method[@name='toObjectId' and count(parameter)=0]"
		[Register ("toObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetToObjectIdHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ToObjectId ()
		{
			const string __id = "toObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public override unsafe int CompareTo (global::Java.Lang.Object o)
		{
			const string __id = "compareTo.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

	}
}
