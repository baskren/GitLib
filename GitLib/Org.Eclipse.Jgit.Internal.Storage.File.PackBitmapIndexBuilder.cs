using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Helper for constructing <c>PackBitmapIndex</c>es.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexBuilder", DoNotGenerateAcw=true)]
	public partial class PackBitmapIndexBuilder : global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex {
		/// <summary>Data object for the on disk representation of a bitmap entry.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder.StoredEntry']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexBuilder$StoredEntry", DoNotGenerateAcw=true)]
		public sealed partial class StoredEntry : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexBuilder$StoredEntry", typeof (StoredEntry));

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

			internal StoredEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <returns>the flags</returns>
			public unsafe int Flags {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder.StoredEntry']/method[@name='getFlags' and count(parameter)=0]"
				[Register ("getFlags", "()I", "")]
				get {
					const string __id = "getFlags.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			/// <returns>the ObjectId</returns>
			public unsafe long ObjectId {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder.StoredEntry']/method[@name='getObjectId' and count(parameter)=0]"
				[Register ("getObjectId", "()J", "")]
				get {
					const string __id = "getObjectId.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			/// <returns>the xorOffset</returns>
			public unsafe int XorOffset {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder.StoredEntry']/method[@name='getXorOffset' and count(parameter)=0]"
				[Register ("getXorOffset", "()I", "")]
				get {
					const string __id = "getXorOffset.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexBuilder", typeof (PackBitmapIndexBuilder));

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

		protected PackBitmapIndexBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="byName">objects sorted by name.</param>
		/// <summary>Creates a PackBitmapIndex used for building the contents of an index
		/// file.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']/constructor[@name='PackBitmapIndexBuilder' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.internal.storage.pack.ObjectToPack&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe PackBitmapIndexBuilder (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> byName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_byName = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack>.ToLocalJniHandle (byName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_byName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_byName);
				global::System.GC.KeepAlive (byName);
			}
		}

		static Delegate cb_getBitmapCount;
#pragma warning disable 0169
		static Delegate GetGetBitmapCountHandler ()
		{
			if (cb_getBitmapCount == null)
				cb_getBitmapCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBitmapCount);
			return cb_getBitmapCount;
		}

		static int n_GetBitmapCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BitmapCount;
		}
#pragma warning restore 0169

		/// <returns>the number of bitmaps.</returns>
		public virtual unsafe int BitmapCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']/method[@name='getBitmapCount' and count(parameter)=0]"
			[Register ("getBitmapCount", "()I", "GetGetBitmapCountHandler")]
			get {
				const string __id = "getBitmapCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCompressedBitmaps;
#pragma warning disable 0169
		static Delegate GetGetCompressedBitmapsHandler ()
		{
			if (cb_getCompressedBitmaps == null)
				cb_getCompressedBitmaps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCompressedBitmaps);
			return cb_getCompressedBitmaps;
		}

		static IntPtr n_GetCompressedBitmaps (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CompressedBitmaps);
		}
#pragma warning restore 0169

		/// <returns>an iterator over the xor compressed entries.</returns>
		public virtual unsafe global::Java.Lang.IIterable CompressedBitmaps {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']/method[@name='getCompressedBitmaps' and count(parameter)=0]"
			[Register ("getCompressedBitmaps", "()Ljava/lang/Iterable;", "GetGetCompressedBitmapsHandler")]
			get {
				const string __id = "getCompressedBitmaps.()Ljava/lang/Iterable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectCount;
		}
#pragma warning restore 0169

		public override unsafe int ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()I", "GetGetObjectCountHandler")]
			get {
				const string __id = "getObjectCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOptions;
#pragma warning disable 0169
		static Delegate GetGetOptionsHandler ()
		{
			if (cb_getOptions == null)
				cb_getOptions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOptions);
			return cb_getOptions;
		}

		static int n_GetOptions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Options;
		}
#pragma warning restore 0169

		/// <returns>the index storage options.</returns>
		public virtual unsafe int Options {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']/method[@name='getOptions' and count(parameter)=0]"
			[Register ("getOptions", "()I", "GetGetOptionsHandler")]
			get {
				const string __id = "getOptions.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetAddBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_IHandler ()
		{
			if (cb_addBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_I == null)
				cb_addBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_AddBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_I);
			return cb_addBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_I;
		}

		static void n_AddBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId, IntPtr native_bitmap, int flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			var bitmap = (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.AddBitmap (objectId, bitmap, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']/method[@name='addBitmap' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.BitmapIndex.Bitmap'] and parameter[3][@type='int']]"
		[Register ("addBitmap", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;I)V", "GetAddBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_IHandler")]
		public virtual unsafe void AddBitmap (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap bitmap, int flags)
		{
			const string __id = "addBitmap.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [2] = new JniArgumentValue (flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (objectId);
				global::System.GC.KeepAlive (bitmap);
			}
		}

		static Delegate cb_clearBitmaps;
#pragma warning disable 0169
		static Delegate GetClearBitmapsHandler ()
		{
			if (cb_clearBitmaps == null)
				cb_clearBitmaps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearBitmaps);
			return cb_clearBitmaps;
		}

		static void n_ClearBitmaps (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearBitmaps ();
		}
#pragma warning restore 0169

		/// <summary>Removes all the bitmaps entries added.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']/method[@name='clearBitmaps' and count(parameter)=0]"
		[Register ("clearBitmaps", "()V", "GetClearBitmapsHandler")]
		public virtual unsafe void ClearBitmaps ()
		{
			const string __id = "clearBitmaps.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FindPosition (objectId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']/method[@name='findPosition' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("findPosition", "(Lorg/eclipse/jgit/lib/AnyObjectId;)I", "GetFindPosition_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public override unsafe int FindPosition (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			const string __id = "findPosition.(Lorg/eclipse/jgit/lib/AnyObjectId;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObject (position));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexBuilder']/method[@name='getObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObject", "(I)Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObject_IHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId GetObject (int position)
		{
			const string __id = "getObject.(I)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
