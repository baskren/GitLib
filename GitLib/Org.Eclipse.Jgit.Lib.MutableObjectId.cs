using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A mutable SHA-1 abstraction.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/MutableObjectId", DoNotGenerateAcw=true)]
	public partial class MutableObjectId : global::Org.Eclipse.Jgit.Lib.AnyObjectId {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/MutableObjectId", typeof (MutableObjectId));

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

		protected MutableObjectId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Empty constructor.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/constructor[@name='MutableObjectId' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MutableObjectId () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		/// <summary>Make this id match <c>ObjectId#zeroId()</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fromObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetFromObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_fromObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_fromObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FromObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_fromObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_FromObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_src, JniHandleOwnership.DoNotTransfer);
			__this.FromObjectId (src);
		}
#pragma warning restore 0169

		/// <param name="src">the source id to copy from.</param>
		/// <summary>Copy an ObjectId into this mutable buffer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='fromObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("fromObjectId", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetFromObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void FromObjectId (global::Org.Eclipse.Jgit.Lib.AnyObjectId src)
		{
			const string __id = "fromObjectId.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		static Delegate cb_fromRaw_arrayB;
#pragma warning disable 0169
		static Delegate GetFromRaw_arrayBHandler ()
		{
			if (cb_fromRaw_arrayB == null)
				cb_fromRaw_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FromRaw_arrayB);
			return cb_fromRaw_arrayB;
		}

		static void n_FromRaw_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bs = (byte[]) JNIEnv.GetArray (native_bs, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.FromRaw (bs);
			if (bs != null)
				JNIEnv.CopyArray (bs, native_bs);
		}
#pragma warning restore 0169

		/// <param name="bs">the raw byte buffer to read from. At least 20 bytes must be
		///            available within this byte array.</param>
		/// <summary>Convert an ObjectId from raw binary representation.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='fromRaw' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("fromRaw", "([B)V", "GetFromRaw_arrayBHandler")]
		public virtual unsafe void FromRaw (byte[] bs)
		{
			const string __id = "fromRaw.([B)V";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		static Delegate cb_fromRaw_arrayBI;
#pragma warning disable 0169
		static Delegate GetFromRaw_arrayBIHandler ()
		{
			if (cb_fromRaw_arrayBI == null)
				cb_fromRaw_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_FromRaw_arrayBI);
			return cb_fromRaw_arrayBI;
		}

		static void n_FromRaw_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_bs, int p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bs = (byte[]) JNIEnv.GetArray (native_bs, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.FromRaw (bs, p);
			if (bs != null)
				JNIEnv.CopyArray (bs, native_bs);
		}
#pragma warning restore 0169

		/// <param name="bs">the raw byte buffer to read from. At least 20 bytes after p
		///            must be available within this byte array.</param>
		/// <param name="p">position to read the first byte of data from.</param>
		/// <summary>Convert an ObjectId from raw binary representation.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='fromRaw' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("fromRaw", "([BI)V", "GetFromRaw_arrayBIHandler")]
		public virtual unsafe void FromRaw (byte[] bs, int p)
		{
			const string __id = "fromRaw.([BI)V";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bs);
				__args [1] = new JniArgumentValue (p);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		static Delegate cb_fromRaw_arrayI;
#pragma warning disable 0169
		static Delegate GetFromRaw_arrayIHandler ()
		{
			if (cb_fromRaw_arrayI == null)
				cb_fromRaw_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FromRaw_arrayI);
			return cb_fromRaw_arrayI;
		}

		static void n_FromRaw_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_ints)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ints = (int[]) JNIEnv.GetArray (native_ints, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.FromRaw (ints);
			if (ints != null)
				JNIEnv.CopyArray (ints, native_ints);
		}
#pragma warning restore 0169

		/// <param name="ints">the raw int buffer to read from. At least 5 integers must be
		///            available within this integers array.</param>
		/// <summary>Convert an ObjectId from binary representation expressed in integers.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='fromRaw' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("fromRaw", "([I)V", "GetFromRaw_arrayIHandler")]
		public virtual unsafe void FromRaw (int[] ints)
		{
			const string __id = "fromRaw.([I)V";
			IntPtr native_ints = JNIEnv.NewArray (ints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ints);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (ints != null) {
					JNIEnv.CopyArray (native_ints, ints);
					JNIEnv.DeleteLocalRef (native_ints);
				}
				global::System.GC.KeepAlive (ints);
			}
		}

		static Delegate cb_fromRaw_arrayII;
#pragma warning disable 0169
		static Delegate GetFromRaw_arrayIIHandler ()
		{
			if (cb_fromRaw_arrayII == null)
				cb_fromRaw_arrayII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_FromRaw_arrayII);
			return cb_fromRaw_arrayII;
		}

		static void n_FromRaw_arrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_ints, int p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ints = (int[]) JNIEnv.GetArray (native_ints, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.FromRaw (ints, p);
			if (ints != null)
				JNIEnv.CopyArray (ints, native_ints);
		}
#pragma warning restore 0169

		/// <param name="ints">the raw int buffer to read from. At least 5 integers after p
		///            must be available within this integers array.</param>
		/// <param name="p">position to read the first integer of data from.</param>
		/// <summary>Convert an ObjectId from binary representation expressed in integers.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='fromRaw' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("fromRaw", "([II)V", "GetFromRaw_arrayIIHandler")]
		public virtual unsafe void FromRaw (int[] ints, int p)
		{
			const string __id = "fromRaw.([II)V";
			IntPtr native_ints = JNIEnv.NewArray (ints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_ints);
				__args [1] = new JniArgumentValue (p);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (ints != null) {
					JNIEnv.CopyArray (native_ints, ints);
					JNIEnv.DeleteLocalRef (native_ints);
				}
				global::System.GC.KeepAlive (ints);
			}
		}

		static Delegate cb_fromString_arrayBI;
#pragma warning disable 0169
		static Delegate GetFromString_arrayBIHandler ()
		{
			if (cb_fromString_arrayBI == null)
				cb_fromString_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_FromString_arrayBI);
			return cb_fromString_arrayBI;
		}

		static void n_FromString_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, int offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = (byte[]) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.FromString (buf, offset);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		/// <param name="buf">the US-ASCII buffer to read from. At least 40 bytes after
		///            offset must be available within this byte array.</param>
		/// <param name="offset">position to read the first character from.</param>
		/// <summary>Convert an ObjectId from hex characters (US-ASCII).</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='fromString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("fromString", "([BI)V", "GetFromString_arrayBIHandler")]
		public virtual unsafe void FromString (byte[] buf, int offset)
		{
			const string __id = "fromString.([BI)V";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

		static Delegate cb_fromString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFromString_Ljava_lang_String_Handler ()
		{
			if (cb_fromString_Ljava_lang_String_ == null)
				cb_fromString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FromString_Ljava_lang_String_);
			return cb_fromString_Ljava_lang_String_;
		}

		static void n_FromString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			__this.FromString (str);
		}
#pragma warning restore 0169

		/// <param name="str">the string to read from. Must be 40 characters long.</param>
		/// <summary>Convert an ObjectId from hex characters.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)V", "GetFromString_Ljava_lang_String_Handler")]
		public virtual unsafe void FromString (string str)
		{
			const string __id = "fromString.(Ljava/lang/String;)V";
			IntPtr native_str = JNIEnv.NewString ((string)str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_setByte_II;
#pragma warning disable 0169
		static Delegate GetSetByte_IIHandler ()
		{
			if (cb_setByte_II == null)
				cb_setByte_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetByte_II);
			return cb_setByte_II;
		}

		static void n_SetByte_II (IntPtr jnienv, IntPtr native__this, int index, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetByte (index, value);
		}
#pragma warning restore 0169

		/// <param name="index">index of the byte to set in the raw form of the ObjectId. Must
		///            be in range [0, <c>Constants#OBJECT_ID_LENGTH</c>).</param>
		/// <param name="value">the value of the specified byte at <c>index</c>. Values are
		///            unsigned and thus are in the range [0,255] rather than the
		///            signed byte range of [-128, 127].</param>
		/// <summary>Set any byte in the id.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='setByte' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setByte", "(II)V", "GetSetByte_IIHandler")]
		public virtual unsafe void SetByte (int index, int value)
		{
			const string __id = "setByte.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToObjectId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='MutableObjectId']/method[@name='toObjectId' and count(parameter)=0]"
		[Register ("toObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetToObjectIdHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ToObjectId ()
		{
			const string __id = "toObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
