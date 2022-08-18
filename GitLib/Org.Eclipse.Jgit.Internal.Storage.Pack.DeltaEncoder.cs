using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>Encodes an instruction stream for <c>BinaryDelta</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaEncoder']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/DeltaEncoder", DoNotGenerateAcw=true)]
	public partial class DeltaEncoder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/DeltaEncoder", typeof (DeltaEncoder));

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

		protected DeltaEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="out">buffer to store the instructions written.</param>
		/// <param name="baseSize">size of the base object, in bytes.</param>
		/// <param name="resultSize">size of the resulting object, after applying this instruction
		///            stream to the base object, in bytes.</param>
		/// <summary>Create an encoder with no upper bound on the instruction stream size.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaEncoder']/constructor[@name='DeltaEncoder' and count(parameter)=3 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/io/OutputStream;JJ)V", "")]
		public unsafe DeltaEncoder (global::System.IO.Stream @out, long baseSize, long resultSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/OutputStream;JJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__out);
				__args [1] = new JniArgumentValue (baseSize);
				__args [2] = new JniArgumentValue (resultSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (@out);
			}
		}

		/// <param name="out">buffer to store the instructions written.</param>
		/// <param name="baseSize">size of the base object, in bytes.</param>
		/// <param name="resultSize">size of the resulting object, after applying this instruction
		///            stream to the base object, in bytes.</param>
		/// <param name="limit">maximum number of bytes to write to the out buffer declaring
		///            the stream is over limit and should be discarded. May be 0 to
		///            specify an infinite limit.</param>
		/// <summary>Create an encoder with an upper limit on the instruction size.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaEncoder']/constructor[@name='DeltaEncoder' and count(parameter)=4 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/io/OutputStream;JJI)V", "")]
		public unsafe DeltaEncoder (global::System.IO.Stream @out, long baseSize, long resultSize, int limit) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/OutputStream;JJI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native__out);
				__args [1] = new JniArgumentValue (baseSize);
				__args [2] = new JniArgumentValue (resultSize);
				__args [3] = new JniArgumentValue (limit);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.DeltaEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		/// <returns>current size of the delta stream, in bytes.</returns>
		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaEncoder']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_copy_JI;
#pragma warning disable 0169
		static Delegate GetCopy_JIHandler ()
		{
			if (cb_copy_JI == null)
				cb_copy_JI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJI_Z) n_Copy_JI);
			return cb_copy_JI;
		}

		static bool n_Copy_JI (IntPtr jnienv, IntPtr native__this, long offset, int cnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.DeltaEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Copy (offset, cnt);
		}
#pragma warning restore 0169

		/// <param name="offset">position in the base object to copy from. This is absolute,
		///            from the beginning of the base.</param>
		/// <param name="cnt">number of bytes to copy.</param>
		/// <summary>Create a copy instruction to copy from the base object.</summary>
		/// <returns>true if the copy fits within the limit; false if the copy
		///         would cause the instruction stream to exceed the limit.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaEncoder']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("copy", "(JI)Z", "GetCopy_JIHandler")]
		public virtual unsafe bool Copy (long offset, int cnt)
		{
			const string __id = "copy.(JI)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue (cnt);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_insert_arrayB;
#pragma warning disable 0169
		static Delegate GetInsert_arrayBHandler ()
		{
			if (cb_insert_arrayB == null)
				cb_insert_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Insert_arrayB);
			return cb_insert_arrayB;
		}

		static bool n_Insert_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.DeltaEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = (byte[]) JNIEnv.GetArray (native_text, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Insert (text);
			if (text != null)
				JNIEnv.CopyArray (text, native_text);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="text">the binary to insert.</param>
		/// <summary>Insert a literal binary sequence.</summary>
		/// <returns>true if the insert fits within the limit; false if the insert
		///         would cause the instruction stream to exceed the limit.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaEncoder']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("insert", "([B)Z", "GetInsert_arrayBHandler")]
		public virtual unsafe bool Insert (byte[] text)
		{
			const string __id = "insert.([B)Z";
			IntPtr native_text = JNIEnv.NewArray (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (text != null) {
					JNIEnv.CopyArray (native_text, text);
					JNIEnv.DeleteLocalRef (native_text);
				}
				global::System.GC.KeepAlive (text);
			}
		}

		static Delegate cb_insert_arrayBII;
#pragma warning disable 0169
		static Delegate GetInsert_arrayBIIHandler ()
		{
			if (cb_insert_arrayBII == null)
				cb_insert_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_Z) n_Insert_arrayBII);
			return cb_insert_arrayBII;
		}

		static bool n_Insert_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_text, int off, int cnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.DeltaEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = (byte[]) JNIEnv.GetArray (native_text, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Insert (text, off, cnt);
			if (text != null)
				JNIEnv.CopyArray (text, native_text);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="text">the binary to insert.</param>
		/// <param name="off">offset within <c>text</c> to start copying from.</param>
		/// <param name="cnt">number of bytes to insert.</param>
		/// <summary>Insert a literal binary sequence.</summary>
		/// <returns>true if the insert fits within the limit; false if the insert
		///         would cause the instruction stream to exceed the limit.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaEncoder']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("insert", "([BII)Z", "GetInsert_arrayBIIHandler")]
		public virtual unsafe bool Insert (byte[] text, int off, int cnt)
		{
			const string __id = "insert.([BII)Z";
			IntPtr native_text = JNIEnv.NewArray (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (off);
				__args [2] = new JniArgumentValue (cnt);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (text != null) {
					JNIEnv.CopyArray (native_text, text);
					JNIEnv.DeleteLocalRef (native_text);
				}
				global::System.GC.KeepAlive (text);
			}
		}

		static Delegate cb_insert_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInsert_Ljava_lang_String_Handler ()
		{
			if (cb_insert_Ljava_lang_String_ == null)
				cb_insert_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Insert_Ljava_lang_String_);
			return cb_insert_Ljava_lang_String_;
		}

		static bool n_Insert_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.DeltaEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Insert (text);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="text">the string to insert.</param>
		/// <summary>Insert a literal string of text, in UTF-8 encoding.</summary>
		/// <returns>true if the insert fits within the limit; false if the insert
		///         would cause the instruction stream to exceed the limit.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaEncoder']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("insert", "(Ljava/lang/String;)Z", "GetInsert_Ljava_lang_String_Handler")]
		public virtual unsafe bool Insert (string text)
		{
			const string __id = "insert.(Ljava/lang/String;)Z";
			IntPtr native_text = JNIEnv.NewString ((string)text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

	}
}
