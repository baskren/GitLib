using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A SHA-1 abstraction.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectId", DoNotGenerateAcw=true)]
	public partial class ObjectId : global::Org.Eclipse.Jgit.Lib.AnyObjectId, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectId", typeof (ObjectId));

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

		protected ObjectId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="src">another already parsed ObjectId to copy the value out of.</param>
		/// <summary>Initialize this instance by copying another existing ObjectId.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/constructor[@name='ObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
		protected unsafe ObjectId (global::Org.Eclipse.Jgit.Lib.AnyObjectId src) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/AnyObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		/// <param name="firstBuffer">the first buffer to compare against. Must have at least 20
		///            bytes from position ai through the end of the buffer.</param>
		/// <param name="fi">first offset within firstBuffer to begin testing.</param>
		/// <param name="secondBuffer">the second buffer to compare against. Must have at least 2
		///            bytes from position bi through the end of the buffer.</param>
		/// <param name="si">first offset within secondBuffer to begin testing.</param>
		/// <summary>Compare to object identifier byte sequences for equality.</summary>
		/// <returns>true if the two identifiers are the same.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='equals' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("equals", "([BI[BI)Z", "")]
		public static unsafe bool Equals (byte[] firstBuffer, int fi, byte[] secondBuffer, int si)
		{
			const string __id = "equals.([BI[BI)Z";
			IntPtr native_firstBuffer = JNIEnv.NewArray (firstBuffer);
			IntPtr native_secondBuffer = JNIEnv.NewArray (secondBuffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_firstBuffer);
				__args [1] = new JniArgumentValue (fi);
				__args [2] = new JniArgumentValue (native_secondBuffer);
				__args [3] = new JniArgumentValue (si);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (firstBuffer != null) {
					JNIEnv.CopyArray (native_firstBuffer, firstBuffer);
					JNIEnv.DeleteLocalRef (native_firstBuffer);
				}
				if (secondBuffer != null) {
					JNIEnv.CopyArray (native_secondBuffer, secondBuffer);
					JNIEnv.DeleteLocalRef (native_secondBuffer);
				}
				global::System.GC.KeepAlive (firstBuffer);
				global::System.GC.KeepAlive (secondBuffer);
			}
		}

		/// <param name="bs">the raw byte buffer to read from. At least 20 bytes must be
		///            available within this byte array.</param>
		/// <summary>Convert an ObjectId from raw binary representation.</summary>
		/// <returns>the converted object id.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='fromRaw' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("fromRaw", "([B)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.ObjectId FromRaw (byte[] bs)
		{
			const string __id = "fromRaw.([B)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		/// <param name="bs">the raw byte buffer to read from. At least 20 bytes after p
		///            must be available within this byte array.</param>
		/// <param name="p">position to read the first byte of data from.</param>
		/// <summary>Convert an ObjectId from raw binary representation.</summary>
		/// <returns>the converted object id.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='fromRaw' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("fromRaw", "([BI)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.ObjectId FromRaw (byte[] bs, int p)
		{
			const string __id = "fromRaw.([BI)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bs);
				__args [1] = new JniArgumentValue (p);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		/// <param name="is">the raw integers buffer to read from. At least 5 integers must
		///            be available within this int array.</param>
		/// <summary>Convert an ObjectId from raw binary representation.</summary>
		/// <returns>the converted object id.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='fromRaw' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("fromRaw", "([I)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.ObjectId FromRaw (int[] @is)
		{
			const string __id = "fromRaw.([I)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native__is = JNIEnv.NewArray (@is);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__is);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (@is != null) {
					JNIEnv.CopyArray (native__is, @is);
					JNIEnv.DeleteLocalRef (native__is);
				}
				global::System.GC.KeepAlive (@is);
			}
		}

		/// <param name="is">the raw integers buffer to read from. At least 5 integers
		///            after p must be available within this int array.</param>
		/// <param name="p">position to read the first integer of data from.</param>
		/// <summary>Convert an ObjectId from raw binary representation.</summary>
		/// <returns>the converted object id.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='fromRaw' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("fromRaw", "([II)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.ObjectId FromRaw (int[] @is, int p)
		{
			const string __id = "fromRaw.([II)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native__is = JNIEnv.NewArray (@is);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__is);
				__args [1] = new JniArgumentValue (p);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (@is != null) {
					JNIEnv.CopyArray (native__is, @is);
					JNIEnv.DeleteLocalRef (native__is);
				}
				global::System.GC.KeepAlive (@is);
			}
		}

		/// <param name="buf">the US-ASCII buffer to read from. At least 40 bytes after
		///            offset must be available within this byte array.</param>
		/// <param name="offset">position to read the first character from.</param>
		/// <summary>Convert an ObjectId from hex characters (US-ASCII).</summary>
		/// <returns>the converted object id.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='fromString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("fromString", "([BI)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.ObjectId FromString (byte[] buf, int offset)
		{
			const string __id = "fromString.([BI)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

		/// <param name="str">the string to read from. Must be 40 characters long.</param>
		/// <summary>Convert an ObjectId from hex characters.</summary>
		/// <returns>the converted object id.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.ObjectId FromString (string str)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_str = JNIEnv.NewString ((string)str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		/// <param name="id">the string to test.</param>
		/// <summary>Test a string of characters to verify it is a hex format.</summary>
		/// <returns>true if the string can converted into an ObjectId.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='isId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isId", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsId (string id)
		{
			const string __id = "isId.(Ljava/lang/String;)Z";
			IntPtr native_id = JNIEnv.NewString ((string)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToObjectId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='toObjectId' and count(parameter)=0]"
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

		/// <param name="i">the id to convert. May be null.</param>
		/// <summary>Convert an ObjectId into a hex string representation.</summary>
		/// <returns>the hex string conversion of this id's content.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("toString", "(Lorg/eclipse/jgit/lib/ObjectId;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Org.Eclipse.Jgit.Lib.ObjectId i)
		{
			const string __id = "toString.(Lorg/eclipse/jgit/lib/ObjectId;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((i == null) ? IntPtr.Zero : ((global::Java.Lang.Object) i).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (i);
			}
		}

		/// <summary>Get the special all-null ObjectId.</summary>
		/// <returns>the all-null ObjectId, often used to stand-in for no object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectId']/method[@name='zeroId' and count(parameter)=0]"
		[Register ("zeroId", "()Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ZeroId ()
		{
			const string __id = "zeroId.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
