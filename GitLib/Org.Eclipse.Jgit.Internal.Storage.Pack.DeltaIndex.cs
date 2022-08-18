using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>Index of blocks in a source file.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaIndex']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/DeltaIndex", DoNotGenerateAcw=true)]
	public partial class DeltaIndex : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/DeltaIndex", typeof (DeltaIndex));

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

		protected DeltaIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="sourceBuffer">the source file's raw contents. The buffer will be held by the
		///            index instance to facilitate matching, and therefore must not
		///            be modified by the caller.</param>
		/// <summary>Construct an index from the source file.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaIndex']/constructor[@name='DeltaIndex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe DeltaIndex (byte[] sourceBuffer) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sourceBuffer = JNIEnv.NewArray (sourceBuffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourceBuffer);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (sourceBuffer != null) {
					JNIEnv.CopyArray (native_sourceBuffer, sourceBuffer);
					JNIEnv.DeleteLocalRef (native_sourceBuffer);
				}
				global::System.GC.KeepAlive (sourceBuffer);
			}
		}

		static Delegate cb_getIndexSize;
#pragma warning disable 0169
		static Delegate GetGetIndexSizeHandler ()
		{
			if (cb_getIndexSize == null)
				cb_getIndexSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetIndexSize);
			return cb_getIndexSize;
		}

		static long n_GetIndexSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.DeltaIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexSize;
		}
#pragma warning restore 0169

		/// <summary>Get an estimate of the memory required by this index.</summary>
		/// <returns>an approximation of the number of bytes used by this index in
		///         memory. The size includes the cached source buffer size from
		///         <c>#getSourceSize()</c>, as well as a rough approximation of JVM
		///         object overheads.</returns>
		public virtual unsafe long IndexSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaIndex']/method[@name='getIndexSize' and count(parameter)=0]"
			[Register ("getIndexSize", "()J", "GetGetIndexSizeHandler")]
			get {
				const string __id = "getIndexSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSourceSize;
#pragma warning disable 0169
		static Delegate GetGetSourceSizeHandler ()
		{
			if (cb_getSourceSize == null)
				cb_getSourceSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSourceSize);
			return cb_getSourceSize;
		}

		static long n_GetSourceSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.DeltaIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SourceSize;
		}
#pragma warning restore 0169

		/// <returns>size of the source buffer this index has scanned.</returns>
		public virtual unsafe long SourceSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaIndex']/method[@name='getSourceSize' and count(parameter)=0]"
			[Register ("getSourceSize", "()J", "GetGetSourceSizeHandler")]
			get {
				const string __id = "getSourceSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_encode_Ljava_io_OutputStream_arrayB;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_io_OutputStream_arrayBHandler ()
		{
			if (cb_encode_Ljava_io_OutputStream_arrayB == null)
				cb_encode_Ljava_io_OutputStream_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Encode_Ljava_io_OutputStream_arrayB);
			return cb_encode_Ljava_io_OutputStream_arrayB;
		}

		static void n_Encode_Ljava_io_OutputStream_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_res)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.DeltaIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			var res = (byte[]) JNIEnv.GetArray (native_res, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Encode (@out, res);
			if (res != null)
				JNIEnv.CopyArray (res, native_res);
		}
#pragma warning restore 0169

		/// <param name="out">stream to receive the delta instructions that can transform
		///            this index's source buffer into <c>res</c>. This stream
		///            should be buffered, as instructions are written directly to it
		///            in small bursts.</param>
		/// <param name="res">the desired result buffer. The generated instructions will
		///            recreate this buffer when applied to the source buffer stored
		///            within this index.</param>
		/// <summary>Generate a delta sequence to recreate the result buffer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaIndex']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='byte[]']]"
		[Register ("encode", "(Ljava/io/OutputStream;[B)V", "GetEncode_Ljava_io_OutputStream_arrayBHandler")]
		public virtual unsafe void Encode (global::System.IO.Stream @out, byte[] res)
		{
			const string __id = "encode.(Ljava/io/OutputStream;[B)V";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			IntPtr native_res = JNIEnv.NewArray (res);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__out);
				__args [1] = new JniArgumentValue (native_res);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				if (res != null) {
					JNIEnv.CopyArray (native_res, res);
					JNIEnv.DeleteLocalRef (native_res);
				}
				global::System.GC.KeepAlive (@out);
				global::System.GC.KeepAlive (res);
			}
		}

		static Delegate cb_encode_Ljava_io_OutputStream_arrayBI;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_io_OutputStream_arrayBIHandler ()
		{
			if (cb_encode_Ljava_io_OutputStream_arrayBI == null)
				cb_encode_Ljava_io_OutputStream_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_Z) n_Encode_Ljava_io_OutputStream_arrayBI);
			return cb_encode_Ljava_io_OutputStream_arrayBI;
		}

		static bool n_Encode_Ljava_io_OutputStream_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_res, int deltaSizeLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.DeltaIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			var res = (byte[]) JNIEnv.GetArray (native_res, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Encode (@out, res, deltaSizeLimit);
			if (res != null)
				JNIEnv.CopyArray (res, native_res);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="out">stream to receive the delta instructions that can transform
		///            this index's source buffer into <c>res</c>. This stream
		///            should be buffered, as instructions are written directly to it
		///            in small bursts. If the caller might need to discard the
		///            instructions (such as when deltaSizeLimit would be exceeded)
		///            the caller is responsible for discarding or rewinding the
		///            stream when this method returns false.</param>
		/// <param name="res">the desired result buffer. The generated instructions will
		///            recreate this buffer when applied to the source buffer stored
		///            within this index.</param>
		/// <param name="deltaSizeLimit">maximum number of bytes that the delta instructions can
		///            occupy. If the generated instructions would be longer than
		///            this amount, this method returns false. If 0, there is no
		///            limit on the length of delta created.</param>
		/// <summary>Generate a delta sequence to recreate the result buffer.</summary>
		/// <returns>true if the delta is smaller than deltaSizeLimit; false if the
		///         encoder aborted because the encoded delta instructions would be
		///         longer than deltaSizeLimit bytes.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaIndex']/method[@name='encode' and count(parameter)=3 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("encode", "(Ljava/io/OutputStream;[BI)Z", "GetEncode_Ljava_io_OutputStream_arrayBIHandler")]
		public virtual unsafe bool Encode (global::System.IO.Stream @out, byte[] res, int deltaSizeLimit)
		{
			const string __id = "encode.(Ljava/io/OutputStream;[BI)Z";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			IntPtr native_res = JNIEnv.NewArray (res);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__out);
				__args [1] = new JniArgumentValue (native_res);
				__args [2] = new JniArgumentValue (deltaSizeLimit);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				if (res != null) {
					JNIEnv.CopyArray (native_res, res);
					JNIEnv.DeleteLocalRef (native_res);
				}
				global::System.GC.KeepAlive (@out);
				global::System.GC.KeepAlive (res);
			}
		}

		/// <param name="sourceLength">length of the source, in bytes.</param>
		/// <summary>Estimate the size of an index for a given source.</summary>
		/// <returns>estimated size. Approximately <c>1.75 * sourceLength</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='DeltaIndex']/method[@name='estimateIndexSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("estimateIndexSize", "(I)J", "")]
		public static unsafe long EstimateIndexSize (int sourceLength)
		{
			const string __id = "estimateIndexSize.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sourceLength);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
