using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Logical representation of the bitmap data stored in the pack index.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackBitmapIndex", DoNotGenerateAcw=true)]
	public abstract partial class PackBitmapIndex : global::Java.Lang.Object {
		/// <summary>Flag bit denoting the bitmap should be reused during index creation.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/field[@name='FLAG_REUSE']"
		[Register ("FLAG_REUSE")]
		public const int FlagReuse = (int) 1;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackBitmapIndex", typeof (PackBitmapIndex));

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

		protected PackBitmapIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/constructor[@name='PackBitmapIndex' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PackBitmapIndex () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getObjectCount;
#pragma warning disable 0169
		static Delegate GetGetObjectCountHandler ()
		{
			if (cb_getObjectCount == null)
				cb_getObjectCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetObjectCount);
			return cb_getObjectCount;
		}

		static int n_GetObjectCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectCount;
		}
#pragma warning restore 0169

		public abstract int ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()I", "GetGetObjectCountHandler")]
			get; 
		}

		static Delegate cb_findPosition_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetFindPosition_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_findPosition_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_findPosition_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_FindPosition_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_findPosition_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static int n_FindPosition_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FindPosition (objectId);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">the id for which the bitmap position will be found.</param>
		/// <summary>Finds the position in the bitmap of the object.</summary>
		/// <returns>the bitmap id or -1 if the object was not found.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/method[@name='findPosition' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("findPosition", "(Lorg/eclipse/jgit/lib/AnyObjectId;)I", "GetFindPosition_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public abstract int FindPosition (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId);

		static Delegate cb_getObject_I;
#pragma warning disable 0169
		static Delegate GetGetObject_IHandler ()
		{
			if (cb_getObject_I == null)
				cb_getObject_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetObject_I);
			return cb_getObject_I;
		}

		static IntPtr n_GetObject_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObject (position));
		}
#pragma warning restore 0169

		/// <param name="position">the id for which the object will be found.</param>
		/// <summary>Get the object at the bitmap position.</summary>
		/// <returns>the ObjectId.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/method[@name='getObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObject", "(I)Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObject_IHandler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectId GetObject (int position);

		/// <param name="idxFile">existing pack .bitmap to read.</param>
		/// <param name="packIndex">the pack index for the corresponding pack file.</param>
		/// <param name="reverseIndex">the pack reverse index for the corresponding pack file.</param>
		/// <summary>Read an existing pack bitmap index file from a buffered stream.</summary>
		/// <returns>a copy of the index in-memory.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/method[@name='open' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.internal.storage.file.PackIndex'] and parameter[3][@type='org.eclipse.jgit.internal.storage.file.PackReverseIndex']]"
		[Register ("open", "(Ljava/io/File;Lorg/eclipse/jgit/internal/storage/file/PackIndex;Lorg/eclipse/jgit/internal/storage/file/PackReverseIndex;)Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex Open (global::Java.IO.File idxFile, global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex packIndex, global::Org.Eclipse.Jgit.Internal.Storage.File.PackReverseIndex reverseIndex)
		{
			const string __id = "open.(Ljava/io/File;Lorg/eclipse/jgit/internal/storage/file/PackIndex;Lorg/eclipse/jgit/internal/storage/file/PackReverseIndex;)Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((idxFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idxFile).Handle);
				__args [1] = new JniArgumentValue ((packIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packIndex).Handle);
				__args [2] = new JniArgumentValue ((reverseIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reverseIndex).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (idxFile);
				global::System.GC.KeepAlive (packIndex);
				global::System.GC.KeepAlive (reverseIndex);
			}
		}

		/// <param name="fd">stream to read the bitmap index file from. The stream must be
		///            buffered as some small IOs are performed against the stream.
		///            The caller is responsible for closing the stream.</param>
		/// <param name="packIndex">the pack index for the corresponding pack file.</param>
		/// <param name="reverseIndex">the pack reverse index for the corresponding pack file.</param>
		/// <summary>Read an existing pack bitmap index file from a buffered stream.</summary>
		/// <returns>a copy of the index in-memory.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/method[@name='read' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='org.eclipse.jgit.internal.storage.file.PackIndex'] and parameter[3][@type='org.eclipse.jgit.internal.storage.file.PackReverseIndex']]"
		[Register ("read", "(Ljava/io/InputStream;Lorg/eclipse/jgit/internal/storage/file/PackIndex;Lorg/eclipse/jgit/internal/storage/file/PackReverseIndex;)Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex Read (global::System.IO.Stream fd, global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex packIndex, global::Org.Eclipse.Jgit.Internal.Storage.File.PackReverseIndex reverseIndex)
		{
			const string __id = "read.(Ljava/io/InputStream;Lorg/eclipse/jgit/internal/storage/file/PackIndex;Lorg/eclipse/jgit/internal/storage/file/PackReverseIndex;)Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;";
			IntPtr native_fd = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (fd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_fd);
				__args [1] = new JniArgumentValue ((packIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packIndex).Handle);
				__args [2] = new JniArgumentValue ((reverseIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reverseIndex).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fd);
				global::System.GC.KeepAlive (fd);
				global::System.GC.KeepAlive (packIndex);
				global::System.GC.KeepAlive (reverseIndex);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackBitmapIndex", DoNotGenerateAcw=true)]
	internal partial class PackBitmapIndexInvoker : PackBitmapIndex {
		public PackBitmapIndexInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackBitmapIndex", typeof (PackBitmapIndexInvoker));

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

		/// <summary>Obtain the total number of objects described by this index.</summary>
		/// <returns>number of objects in this index, and likewise in the associated
		///         pack that this index was generated from.</returns>
		public override unsafe int ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()I", "GetGetObjectCountHandler")]
			get {
				const string __id = "getObjectCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="objectId">the id for which the bitmap position will be found.</param>
		/// <summary>Finds the position in the bitmap of the object.</summary>
		/// <returns>the bitmap id or -1 if the object was not found.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/method[@name='findPosition' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("findPosition", "(Lorg/eclipse/jgit/lib/AnyObjectId;)I", "GetFindPosition_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public override unsafe int FindPosition (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			const string __id = "findPosition.(Lorg/eclipse/jgit/lib/AnyObjectId;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		/// <param name="position">the id for which the object will be found.</param>
		/// <summary>Get the object at the bitmap position.</summary>
		/// <returns>the ObjectId.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndex']/method[@name='getObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObject", "(I)Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObject_IHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId GetObject (int position)
		{
			const string __id = "getObject.(I)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
