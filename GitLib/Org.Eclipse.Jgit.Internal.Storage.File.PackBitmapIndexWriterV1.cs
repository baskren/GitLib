using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Creates the version 1 pack bitmap index files.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexWriterV1']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexWriterV1", DoNotGenerateAcw=true)]
	public partial class PackBitmapIndexWriterV1 : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexWriterV1", typeof (PackBitmapIndexWriterV1));

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

		protected PackBitmapIndexWriterV1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="dst">the output stream to which the index will be written.</param>
		/// <summary>Creates the version 1 pack bitmap index files.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexWriterV1']/constructor[@name='PackBitmapIndexWriterV1' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		public unsafe PackBitmapIndexWriterV1 (global::System.IO.Stream dst) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/OutputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dst = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dst);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dst);
				global::System.GC.KeepAlive (dst);
			}
		}

		static Delegate cb_write_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndexBuilder_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndexBuilder_arrayBHandler ()
		{
			if (cb_write_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndexBuilder_arrayB == null)
				cb_write_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndexBuilder_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Write_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndexBuilder_arrayB);
			return cb_write_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndexBuilder_arrayB;
		}

		static void n_Write_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndexBuilder_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmaps, IntPtr native_packDataChecksum)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexWriterV1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmaps = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder> (native_bitmaps, JniHandleOwnership.DoNotTransfer);
			var packDataChecksum = (byte[]) JNIEnv.GetArray (native_packDataChecksum, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (bitmaps, packDataChecksum);
			if (packDataChecksum != null)
				JNIEnv.CopyArray (packDataChecksum, native_packDataChecksum);
		}
#pragma warning restore 0169

		/// <param name="bitmaps">the index data for the bitmaps</param>
		/// <param name="packDataChecksum">checksum signature of the entire pack data content. This is
		///            traditionally the last 20 bytes of the pack file's own stream.</param>
		/// <summary>Write all object entries to the index stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexWriterV1']/method[@name='write' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.file.PackBitmapIndexBuilder'] and parameter[2][@type='byte[]']]"
		[Register ("write", "(Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndexBuilder;[B)V", "GetWrite_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndexBuilder_arrayBHandler")]
		public virtual unsafe void Write (global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder bitmaps, byte[] packDataChecksum)
		{
			const string __id = "write.(Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndexBuilder;[B)V";
			IntPtr native_packDataChecksum = JNIEnv.NewArray (packDataChecksum);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitmaps == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmaps).Handle);
				__args [1] = new JniArgumentValue (native_packDataChecksum);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (packDataChecksum != null) {
					JNIEnv.CopyArray (native_packDataChecksum, packDataChecksum);
					JNIEnv.DeleteLocalRef (native_packDataChecksum);
				}
				global::System.GC.KeepAlive (bitmaps);
				global::System.GC.KeepAlive (packDataChecksum);
			}
		}

	}
}
