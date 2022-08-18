using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Output stream to create a file on the DFS.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsOutputStream']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsOutputStream", DoNotGenerateAcw=true)]
	public abstract partial class DfsOutputStream : global::Java.IO.OutputStream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsOutputStream", typeof (DfsOutputStream));

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

		protected DfsOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsOutputStream']/constructor[@name='DfsOutputStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DfsOutputStream () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_blockSize;
#pragma warning disable 0169
		static Delegate GetBlockSizeHandler ()
		{
			if (cb_blockSize == null)
				cb_blockSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_BlockSize);
			return cb_blockSize;
		}

		static int n_BlockSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize ();
		}
#pragma warning restore 0169

		/// <summary>Get the recommended alignment for writing.</summary>
		/// <returns>recommended alignment size for randomly positioned reads. Does
		///         not need to be a power of 2.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsOutputStream']/method[@name='blockSize' and count(parameter)=0]"
		[Register ("blockSize", "()I", "GetBlockSizeHandler")]
		public virtual unsafe int BlockSize ()
		{
			const string __id = "blockSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_read_JLjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetRead_JLjava_nio_ByteBuffer_Handler ()
		{
			if (cb_read_JLjava_nio_ByteBuffer_ == null)
				cb_read_JLjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_I) n_Read_JLjava_nio_ByteBuffer_);
			return cb_read_JLjava_nio_ByteBuffer_;
		}

		static int n_Read_JLjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, long position, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (position, buf);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="position">offset to read from.</param>
		/// <param name="buf">buffer to populate. Up to <c>buf.remaining()</c> bytes will
		///            be read from <c>position</c>.</param>
		/// <summary>Read back a portion of already written data.</summary>
		/// <returns>number of bytes actually read.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsOutputStream']/method[@name='read' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(JLjava/nio/ByteBuffer;)I", "GetRead_JLjava_nio_ByteBuffer_Handler")]
		public abstract int Read (long position, global::Java.Nio.ByteBuffer buf);

		static Delegate cb_write_arrayBII;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIIHandler ()
		{
			if (cb_write_arrayBII == null)
				cb_write_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_Write_arrayBII);
			return cb_write_arrayBII;
		}

		static void n_Write_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, int off, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = (byte[]) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (buf, off, len);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsOutputStream']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([BII)V", "GetWrite_arrayBIIHandler")]
		public abstract void Write (byte[] buf, int off, int len);

		static Delegate cb_write_I;
#pragma warning disable 0169
		static Delegate GetWrite_IHandler ()
		{
			if (cb_write_I == null)
				cb_write_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Write_I);
			return cb_write_I;
		}

		static void n_Write_I (IntPtr jnienv, IntPtr native__this, int b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write", "(I)V", "GetWrite_IHandler")]
		public override unsafe void Write (int b)
		{
			const string __id = "write.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsOutputStream", DoNotGenerateAcw=true)]
	internal partial class DfsOutputStreamInvoker : DfsOutputStream {
		public DfsOutputStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsOutputStream", typeof (DfsOutputStreamInvoker));

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

		/// <param name="position">offset to read from.</param>
		/// <param name="buf">buffer to populate. Up to <c>buf.remaining()</c> bytes will
		///            be read from <c>position</c>.</param>
		/// <summary>Read back a portion of already written data.</summary>
		/// <returns>number of bytes actually read.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsOutputStream']/method[@name='read' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(JLjava/nio/ByteBuffer;)I", "GetRead_JLjava_nio_ByteBuffer_Handler")]
		public override unsafe int Read (long position, global::Java.Nio.ByteBuffer buf)
		{
			const string __id = "read.(JLjava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buf);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsOutputStream']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([BII)V", "GetWrite_arrayBIIHandler")]
		public override unsafe void Write (byte[] buf, int off, int len)
		{
			const string __id = "write.([BII)V";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (off);
				__args [2] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

	}
}
