using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>A PackBitmapIndex that remaps the bitmaps in the previous index to the
	/// positions in the new pack index.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexRemapper']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexRemapper", DoNotGenerateAcw=true)]
	public partial class PackBitmapIndexRemapper : global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex, global::Java.Lang.IIterable {
		/// <summary>An entry in the old PackBitmapIndex.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexRemapper.Entry']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexRemapper$Entry", DoNotGenerateAcw=true)]
		public sealed partial class Entry : global::Org.Eclipse.Jgit.Lib.ObjectId {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexRemapper$Entry", typeof (Entry));

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

			internal Entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <returns>the flags associated with the bitmap.</returns>
			public unsafe int Flags {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexRemapper.Entry']/method[@name='getFlags' and count(parameter)=0]"
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackBitmapIndexRemapper", typeof (PackBitmapIndexRemapper));

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

		protected PackBitmapIndexRemapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexRemapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectCount;
		}
#pragma warning restore 0169

		public override unsafe int ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexRemapper']/method[@name='getObjectCount' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexRemapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FindPosition (objectId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexRemapper']/method[@name='findPosition' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexRemapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObject (position));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexRemapper']/method[@name='getObject' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexRemapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexRemapper']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="prevBitmapIndex">the bitmap index with the old mapping.</param>
		/// <param name="newIndex">the bitmap index with the new mapping.</param>
		/// <summary>A PackBitmapIndex that maps the positions in the prevBitmapIndex to the
		/// ones in the newIndex.</summary>
		/// <returns>a bitmap index that attempts to do the mapping between the two.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackBitmapIndexRemapper']/method[@name='newPackBitmapIndex' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.BitmapIndex'] and parameter[2][@type='org.eclipse.jgit.internal.storage.file.PackBitmapIndex']]"
		[Register ("newPackBitmapIndex", "(Lorg/eclipse/jgit/lib/BitmapIndex;Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;)Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndexRemapper;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexRemapper NewPackBitmapIndex (global::Org.Eclipse.Jgit.Lib.IBitmapIndex prevBitmapIndex, global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex newIndex)
		{
			const string __id = "newPackBitmapIndex.(Lorg/eclipse/jgit/lib/BitmapIndex;Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;)Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndexRemapper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((prevBitmapIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prevBitmapIndex).Handle);
				__args [1] = new JniArgumentValue ((newIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newIndex).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndexRemapper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (prevBitmapIndex);
				global::System.GC.KeepAlive (newIndex);
			}
		}

	}
}
