using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Readable random access byte channel from a file.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/interface[@name='ReadableChannel']"
	[Register ("org/eclipse/jgit/internal/storage/dfs/ReadableChannel", "", "Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannelInvoker")]
	public partial interface IReadableChannel : global::Java.Nio.Channels.IReadableByteChannel {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/interface[@name='ReadableChannel']/method[@name='blockSize' and count(parameter)=0]"
		/// <summary>Get the recommended alignment for reads.</summary>
		/// <returns>recommended alignment size for randomly positioned reads. Does
		///         not need to be a power of 2.</returns>
		[Register ("blockSize", "()I", "GetBlockSizeHandler:Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannelInvoker, AndroidBindableLibrary")]
		int BlockSize ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/interface[@name='ReadableChannel']/method[@name='position' and count(parameter)=0]"
		/// <summary>Get the current position of the channel.</summary>
		/// <returns>r current offset.</returns>
		[Register ("position", "()J", "GetPositionHandler:Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannelInvoker, AndroidBindableLibrary")]
		long Position ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/interface[@name='ReadableChannel']/method[@name='position' and count(parameter)=1 and parameter[1][@type='long']]"
		/// <param name="newPosition">position to move the channel to. The next read will start from
		///            here. This should be a multiple of the <c>#blockSize()</c>.</param>
		/// <summary>Seek the current position of the channel to a new offset.</summary>
		[Register ("position", "(J)V", "GetPosition_JHandler:Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannelInvoker, AndroidBindableLibrary")]
		void Position (long newPosition);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/interface[@name='ReadableChannel']/method[@name='size' and count(parameter)=0]"
		/// <summary>Get the total size of the channel.</summary>
		/// <returns>r total size of the channel; -1 if not yet available.</returns>
		[Register ("size", "()J", "GetSizeHandler:Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannelInvoker, AndroidBindableLibrary")]
		long Size ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/ReadableChannel", DoNotGenerateAcw=true)]
	internal partial class IReadableChannelInvoker : global::Java.Lang.Object, IReadableChannel {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/ReadableChannel", typeof (IReadableChannelInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IReadableChannel GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReadableChannel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.internal.storage.dfs.ReadableChannel'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReadableChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize ();
		}
#pragma warning restore 0169

		IntPtr id_blockSize;
		public unsafe int BlockSize ()
		{
			if (id_blockSize == IntPtr.Zero)
				id_blockSize = JNIEnv.GetMethodID (class_ref, "blockSize", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_blockSize);
		}

		static Delegate cb_position;
#pragma warning disable 0169
		static Delegate GetPositionHandler ()
		{
			if (cb_position == null)
				cb_position = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_Position);
			return cb_position;
		}

		static long n_Position (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position ();
		}
#pragma warning restore 0169

		IntPtr id_position;
		public unsafe long Position ()
		{
			if (id_position == IntPtr.Zero)
				id_position = JNIEnv.GetMethodID (class_ref, "position", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_position);
		}

		static Delegate cb_position_J;
#pragma warning disable 0169
		static Delegate GetPosition_JHandler ()
		{
			if (cb_position_J == null)
				cb_position_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Position_J);
			return cb_position_J;
		}

		static void n_Position_J (IntPtr jnienv, IntPtr native__this, long newPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Position (newPosition);
		}
#pragma warning restore 0169

		IntPtr id_position_J;
		public unsafe void Position (long newPosition)
		{
			if (id_position_J == IntPtr.Zero)
				id_position_J = JNIEnv.GetMethodID (class_ref, "position", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (newPosition);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_position_J, __args);
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_Size);
			return cb_size;
		}

		static long n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		IntPtr id_size;
		public unsafe long Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_size);
		}

		static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_read_Ljava_nio_ByteBuffer_ == null)
				cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_Read_Ljava_nio_ByteBuffer_);
			return cb_read_Ljava_nio_ByteBuffer_;
		}

		static int n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dst)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_dst, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (dst);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Ljava_nio_ByteBuffer_;
		public unsafe int Read (global::Java.Nio.ByteBuffer dst)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
			return __ret;
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		IntPtr id_isOpen;
		public unsafe bool IsOpen {
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

	}
}
