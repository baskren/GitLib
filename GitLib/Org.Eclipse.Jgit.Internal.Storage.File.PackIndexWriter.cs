using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Creates a table of contents to support random access by <c>PackFile</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackIndexWriter", DoNotGenerateAcw=true)]
	public abstract partial class PackIndexWriter : global::Java.Lang.Object {

		/// <summary>The entries this writer must pack.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/field[@name='entries']"
		[Register ("entries")]
		protected global::System.Collections.IList Entries {
			get {
				const string __id = "entries.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "entries.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>The index data stream we are responsible for creating.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/field[@name='out']"
		[Register ("out")]
		protected global::Java.Security.DigestOutputStream Out {
			get {
				const string __id = "out.Ljava/security/DigestOutputStream;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Security.DigestOutputStream> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "out.Ljava/security/DigestOutputStream;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>SHA-1 checksum for the entire pack data.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/field[@name='packChecksum']"
		[Register ("packChecksum")]
		protected IList<byte> PackChecksum {
			get {
				const string __id = "packChecksum.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packChecksum.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/field[@name='tmp']"
		[Register ("tmp")]
		protected IList<byte> Tmp {
			get {
				const string __id = "tmp.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tmp.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Magic constant indicating post-version 1 format.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/field[@name='TOC']"
		[Register ("TOC")]
		protected static IList<byte> Toc {
			get {
				const string __id = "TOC.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackIndexWriter", typeof (PackIndexWriter));

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

		protected PackIndexWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="dst">the stream this instance outputs to. If not already buffered
		///            it will be automatically wrapped in a buffered stream.</param>
		/// <summary>Create a new writer instance.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/constructor[@name='PackIndexWriter' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		protected unsafe PackIndexWriter (global::System.IO.Stream dst) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="dst">the stream the index data will be written to. If not already
		///            buffered it will be automatically wrapped in a buffered
		///            stream. Callers are always responsible for closing the stream.</param>
		/// <param name="objs">the objects the caller needs to store in the index. Entries
		///            will be examined until a format can be conclusively selected.</param>
		/// <summary>Create a new writer for the oldest (most widely understood) format.</summary>
		/// <returns>a new writer to output an index file of the requested format to
		///         the supplied stream.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/method[@name='createOldestPossible' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='java.util.List&lt;? extends org.eclipse.jgit.transport.PackedObjectInfo&gt;']]"
		[Register ("createOldestPossible", "(Ljava/io/OutputStream;Ljava/util/List;)Lorg/eclipse/jgit/internal/storage/file/PackIndexWriter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndexWriter CreateOldestPossible (global::System.IO.Stream dst, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> objs)
		{
			const string __id = "createOldestPossible.(Ljava/io/OutputStream;Ljava/util/List;)Lorg/eclipse/jgit/internal/storage/file/PackIndexWriter;";
			IntPtr native_dst = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (dst);
			IntPtr native_objs = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo>.ToLocalJniHandle (objs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_dst);
				__args [1] = new JniArgumentValue (native_objs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndexWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dst);
				JNIEnv.DeleteLocalRef (native_objs);
				global::System.GC.KeepAlive (dst);
				global::System.GC.KeepAlive (objs);
			}
		}

		/// <param name="dst">the stream the index data will be written to. If not already
		///            buffered it will be automatically wrapped in a buffered
		///            stream. Callers are always responsible for closing the stream.</param>
		/// <param name="version">index format version number required by the caller. Exactly
		///            this formatted version will be written.</param>
		/// <summary>Create a new writer instance for a specific index format version.</summary>
		/// <returns>a new writer to output an index file of the requested format to
		///         the supplied stream.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/method[@name='createVersion' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='int']]"
		[Register ("createVersion", "(Ljava/io/OutputStream;I)Lorg/eclipse/jgit/internal/storage/file/PackIndexWriter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndexWriter CreateVersion (global::System.IO.Stream dst, int version)
		{
			const string __id = "createVersion.(Ljava/io/OutputStream;I)Lorg/eclipse/jgit/internal/storage/file/PackIndexWriter;";
			IntPtr native_dst = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_dst);
				__args [1] = new JniArgumentValue (version);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndexWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dst);
				global::System.GC.KeepAlive (dst);
			}
		}

		/// <param name="objs">the objects the caller needs to store in the index. Entries
		///            will be examined until a format can be conclusively selected.</param>
		/// <summary>Return the oldest (most widely understood) index format.</summary>
		/// <returns>the index format.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/method[@name='oldestPossibleFormat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends org.eclipse.jgit.transport.PackedObjectInfo&gt;']]"
		[Register ("oldestPossibleFormat", "(Ljava/util/List;)I", "")]
		public static unsafe int OldestPossibleFormat (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> objs)
		{
			const string __id = "oldestPossibleFormat.(Ljava/util/List;)I";
			IntPtr native_objs = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo>.ToLocalJniHandle (objs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_objs);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_objs);
				global::System.GC.KeepAlive (objs);
			}
		}

		static Delegate cb_write_Ljava_util_List_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_util_List_arrayBHandler ()
		{
			if (cb_write_Ljava_util_List_arrayB == null)
				cb_write_Ljava_util_List_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Write_Ljava_util_List_arrayB);
			return cb_write_Ljava_util_List_arrayB;
		}

		static void n_Write_Ljava_util_List_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_toStore, IntPtr native_packDataChecksum)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndexWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var toStore = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo>.FromJniHandle (native_toStore, JniHandleOwnership.DoNotTransfer);
			var packDataChecksum = (byte[]) JNIEnv.GetArray (native_packDataChecksum, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (toStore, packDataChecksum);
			if (packDataChecksum != null)
				JNIEnv.CopyArray (packDataChecksum, native_packDataChecksum);
		}
#pragma warning restore 0169

		/// <param name="toStore">sorted list of objects to store in the index. The caller must
		///            have previously sorted the list using <c>PackedObjectInfo</c>'s
		///            native <c>Comparable</c> implementation.</param>
		/// <param name="packDataChecksum">checksum signature of the entire pack data content. This is
		///            traditionally the last 20 bytes of the pack file's own stream.</param>
		/// <summary>Write all object entries to the index stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;? extends org.eclipse.jgit.transport.PackedObjectInfo&gt;'] and parameter[2][@type='byte[]']]"
		[Register ("write", "(Ljava/util/List;[B)V", "GetWrite_Ljava_util_List_arrayBHandler")]
		public virtual unsafe void Write (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> toStore, byte[] packDataChecksum)
		{
			const string __id = "write.(Ljava/util/List;[B)V";
			IntPtr native_toStore = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo>.ToLocalJniHandle (toStore);
			IntPtr native_packDataChecksum = JNIEnv.NewArray (packDataChecksum);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_toStore);
				__args [1] = new JniArgumentValue (native_packDataChecksum);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_toStore);
				if (packDataChecksum != null) {
					JNIEnv.CopyArray (native_packDataChecksum, packDataChecksum);
					JNIEnv.DeleteLocalRef (native_packDataChecksum);
				}
				global::System.GC.KeepAlive (toStore);
				global::System.GC.KeepAlive (packDataChecksum);
			}
		}

		static Delegate cb_writeChecksumFooter;
#pragma warning disable 0169
		static Delegate GetWriteChecksumFooterHandler ()
		{
			if (cb_writeChecksumFooter == null)
				cb_writeChecksumFooter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WriteChecksumFooter);
			return cb_writeChecksumFooter;
		}

		static void n_WriteChecksumFooter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndexWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteChecksumFooter ();
		}
#pragma warning restore 0169

		/// <summary>Output the standard two-checksum index footer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/method[@name='writeChecksumFooter' and count(parameter)=0]"
		[Register ("writeChecksumFooter", "()V", "GetWriteChecksumFooterHandler")]
		protected virtual unsafe void WriteChecksumFooter ()
		{
			const string __id = "writeChecksumFooter.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeFanOutTable;
#pragma warning disable 0169
		static Delegate GetWriteFanOutTableHandler ()
		{
			if (cb_writeFanOutTable == null)
				cb_writeFanOutTable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WriteFanOutTable);
			return cb_writeFanOutTable;
		}

		static void n_WriteFanOutTable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndexWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteFanOutTable ();
		}
#pragma warning restore 0169

		/// <summary>Output the standard 256 entry first-level fan-out table.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/method[@name='writeFanOutTable' and count(parameter)=0]"
		[Register ("writeFanOutTable", "()V", "GetWriteFanOutTableHandler")]
		protected virtual unsafe void WriteFanOutTable ()
		{
			const string __id = "writeFanOutTable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeImpl;
#pragma warning disable 0169
		static Delegate GetWriteImplHandler ()
		{
			if (cb_writeImpl == null)
				cb_writeImpl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WriteImpl);
			return cb_writeImpl;
		}

		static void n_WriteImpl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndexWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteImpl ();
		}
#pragma warning restore 0169

		/// <summary>Writes the index file to <c>#out</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/method[@name='writeImpl' and count(parameter)=0]"
		[Register ("writeImpl", "()V", "GetWriteImplHandler")]
		protected abstract void WriteImpl ();

		static Delegate cb_writeTOC_I;
#pragma warning disable 0169
		static Delegate GetWriteTOC_IHandler ()
		{
			if (cb_writeTOC_I == null)
				cb_writeTOC_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_WriteTOC_I);
			return cb_writeTOC_I;
		}

		static void n_WriteTOC_I (IntPtr jnienv, IntPtr native__this, int version)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndexWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteTOC (version);
		}
#pragma warning restore 0169

		/// <param name="version">version number of this index format being written.</param>
		/// <summary>Output the version 2 (and later) TOC header, with version number.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/method[@name='writeTOC' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeTOC", "(I)V", "GetWriteTOC_IHandler")]
		protected virtual unsafe void WriteTOC (int version)
		{
			const string __id = "writeTOC.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (version);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackIndexWriter", DoNotGenerateAcw=true)]
	internal partial class PackIndexWriterInvoker : PackIndexWriter {
		public PackIndexWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackIndexWriter", typeof (PackIndexWriterInvoker));

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

		/// <summary>Writes the index file to <c>#out</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndexWriter']/method[@name='writeImpl' and count(parameter)=0]"
		[Register ("writeImpl", "()V", "GetWriteImplHandler")]
		protected override unsafe void WriteImpl ()
		{
			const string __id = "writeImpl.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
