using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>Extension of <c>ObjectReader</c> that supports reusing objects in packs.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/interface[@name='ObjectReuseAsIs']"
	[Register ("org/eclipse/jgit/internal/storage/pack/ObjectReuseAsIs", "", "Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIsInvoker")]
	public partial interface IObjectReuseAsIs : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/interface[@name='ObjectReuseAsIs']/method[@name='copyObjectAsIs' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackOutputStream'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.ObjectToPack'] and parameter[3][@type='boolean']]"
		/// <param name="out">stream the object should be written to.</param>
		/// <param name="otp">the object's saved representation information.</param>
		/// <param name="validate">if true the representation must be validated and not be
		///            corrupt before being reused. If false, validation may be
		///            skipped as it will be performed elsewhere in the processing
		///            pipeline.</param>
		/// <summary>Output a previously selected representation.</summary>
		[Register ("copyObjectAsIs", "(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Z)V", "GetCopyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_ZHandler:Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIsInvoker, AndroidBindableLibrary")]
		void CopyObjectAsIs (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream @out, global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack otp, bool validate);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/interface[@name='ObjectReuseAsIs']/method[@name='copyPackAsIs' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackOutputStream'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.CachedPack'] and parameter[3][@type='boolean']]"
		/// <param name="out">stream to append the pack onto.</param>
		/// <param name="pack">the cached pack to send.</param>
		/// <param name="validate">if true the representation must be validated and not be
		///            corrupt before being reused. If false, validation may be
		///            skipped as it will be performed elsewhere in the processing
		///            pipeline.</param>
		/// <summary>Append an entire pack's contents onto the output stream.</summary>
		[Register ("copyPackAsIs", "(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Lorg/eclipse/jgit/internal/storage/pack/CachedPack;Z)V", "GetCopyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_ZHandler:Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIsInvoker, AndroidBindableLibrary")]
		void CopyPackAsIs (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream @out, global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack pack, bool validate);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/interface[@name='ObjectReuseAsIs']/method[@name='getCachedPacksAndUpdate' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BitmapIndex.BitmapBuilder']]"
		[Register ("getCachedPacksAndUpdate", "(Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;)Ljava/util/Collection;", "GetGetCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_Handler:Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIsInvoker, AndroidBindableLibrary")]
		global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack> GetCachedPacksAndUpdate (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder needBitmap);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/interface[@name='ObjectReuseAsIs']/method[@name='newObjectToPack' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		/// <param name="objectId">the id of the object that will be packed.</param>
		/// <param name="type">the Git type of the object that will be packed.</param>
		/// <summary>Allocate a new <c>PackWriter</c> state structure for an object.</summary>
		/// <returns>a new instance for this object.</returns>
		[Register ("newObjectToPack", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;", "GetNewObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler:Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIsInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack NewObjectToPack (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int type);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/interface[@name='ObjectReuseAsIs']/method[@name='selectObjectRepresentation' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackWriter'] and parameter[2][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[3][@type='java.lang.Iterable&lt;org.eclipse.jgit.internal.storage.pack.ObjectToPack&gt;']]"
		/// <param name="packer">the packer that will write the object in the near future.</param>
		/// <param name="monitor">progress monitor, implementation should update the monitor
		///            once for each item in the iteration when selection is done.</param>
		/// <param name="objects">the objects that are being packed.</param>
		/// <summary>Select the best object representation for a packer.</summary>
		[Register ("selectObjectRepresentation", "(Lorg/eclipse/jgit/internal/storage/pack/PackWriter;Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/lang/Iterable;)V", "GetSelectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_Handler:Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIsInvoker, AndroidBindableLibrary")]
		void SelectObjectRepresentation (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter packer, global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::Java.Lang.IIterable objects);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/interface[@name='ObjectReuseAsIs']/method[@name='writeObjects' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackOutputStream'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.internal.storage.pack.ObjectToPack&gt;']]"
		/// <param name="out">the stream to write each object to.</param>
		/// <param name="list">the list of objects to write. Objects should be written in
		///            approximately this order. Implementors may resort the list
		///            elements in-place during writing if desired.</param>
		/// <summary>Write objects to the pack stream in roughly the order given.</summary>
		[Register ("writeObjects", "(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Ljava/util/List;)V", "GetWriteObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_Handler:Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIsInvoker, AndroidBindableLibrary")]
		void WriteObjects (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream @out, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> list);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/ObjectReuseAsIs", DoNotGenerateAcw=true)]
	internal partial class IObjectReuseAsIsInvoker : global::Java.Lang.Object, IObjectReuseAsIs {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/ObjectReuseAsIs", typeof (IObjectReuseAsIsInvoker));

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

		public static IObjectReuseAsIs GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObjectReuseAsIs> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.internal.storage.pack.ObjectReuseAsIs'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObjectReuseAsIsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_copyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z;
#pragma warning disable 0169
		static Delegate GetCopyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_ZHandler ()
		{
			if (cb_copyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z == null)
				cb_copyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_CopyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z);
			return cb_copyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z;
		}

		static void n_CopyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_otp, bool validate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			var otp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (native_otp, JniHandleOwnership.DoNotTransfer);
			__this.CopyObjectAsIs (@out, otp, validate);
		}
#pragma warning restore 0169

		IntPtr id_copyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z;
		public unsafe void CopyObjectAsIs (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream @out, global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack otp, bool validate)
		{
			if (id_copyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z == IntPtr.Zero)
				id_copyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z = JNIEnv.GetMethodID (class_ref, "copyObjectAsIs", "(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Z)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
			__args [1] = new JValue ((otp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) otp).Handle);
			__args [2] = new JValue (validate);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyObjectAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Z, __args);
		}

		static Delegate cb_copyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z;
#pragma warning disable 0169
		static Delegate GetCopyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_ZHandler ()
		{
			if (cb_copyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z == null)
				cb_copyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_CopyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z);
			return cb_copyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z;
		}

		static void n_CopyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_pack, bool validate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			var pack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack> (native_pack, JniHandleOwnership.DoNotTransfer);
			__this.CopyPackAsIs (@out, pack, validate);
		}
#pragma warning restore 0169

		IntPtr id_copyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z;
		public unsafe void CopyPackAsIs (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream @out, global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack pack, bool validate)
		{
			if (id_copyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z == IntPtr.Zero)
				id_copyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z = JNIEnv.GetMethodID (class_ref, "copyPackAsIs", "(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Lorg/eclipse/jgit/internal/storage/pack/CachedPack;Z)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
			__args [1] = new JValue ((pack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pack).Handle);
			__args [2] = new JValue (validate);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyPackAsIs_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Lorg_eclipse_jgit_internal_storage_pack_CachedPack_Z, __args);
		}

		static Delegate cb_getCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_;
#pragma warning disable 0169
		static Delegate GetGetCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_Handler ()
		{
			if (cb_getCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_ == null)
				cb_getCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_);
			return cb_getCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_;
		}

		static IntPtr n_GetCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_needBitmap)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var needBitmap = (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (native_needBitmap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack>.ToLocalJniHandle (__this.GetCachedPacksAndUpdate (needBitmap));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_;
		public unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack> GetCachedPacksAndUpdate (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder needBitmap)
		{
			if (id_getCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_ == IntPtr.Zero)
				id_getCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_ = JNIEnv.GetMethodID (class_ref, "getCachedPacksAndUpdate", "(Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;)Ljava/util/Collection;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((needBitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) needBitmap).Handle);
			var __ret = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedPacksAndUpdate_Lorg_eclipse_jgit_lib_BitmapIndex_BitmapBuilder_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_newObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetNewObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_newObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_newObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_NewObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_newObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static IntPtr n_NewObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewObjectToPack (objectId, type));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_newObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		public unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack NewObjectToPack (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int type)
		{
			if (id_newObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I == IntPtr.Zero)
				id_newObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNIEnv.GetMethodID (class_ref, "newObjectToPack", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
			__args [1] = new JValue (type);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newObjectToPack_Lorg_eclipse_jgit_lib_AnyObjectId_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_selectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetSelectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_Handler ()
		{
			if (cb_selectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_ == null)
				cb_selectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SelectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_);
			return cb_selectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_;
		}

		static void n_SelectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_packer, IntPtr native_monitor, IntPtr native_objects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var packer = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (native_packer, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var objects = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_objects, JniHandleOwnership.DoNotTransfer);
			__this.SelectObjectRepresentation (packer, monitor, objects);
		}
#pragma warning restore 0169

		IntPtr id_selectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_;
		public unsafe void SelectObjectRepresentation (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter packer, global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::Java.Lang.IIterable objects)
		{
			if (id_selectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_selectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "selectObjectRepresentation", "(Lorg/eclipse/jgit/internal/storage/pack/PackWriter;Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/lang/Iterable;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((packer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packer).Handle);
			__args [1] = new JValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
			__args [2] = new JValue ((objects == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objects).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectObjectRepresentation_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_lang_Iterable_, __args);
		}

		static Delegate cb_writeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWriteObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_Handler ()
		{
			if (cb_writeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_ == null)
				cb_writeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_WriteObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_);
			return cb_writeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_;
		}

		static void n_WriteObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_list)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			var list = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack>.FromJniHandle (native_list, JniHandleOwnership.DoNotTransfer);
			__this.WriteObjects (@out, list);
		}
#pragma warning restore 0169

		IntPtr id_writeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_;
		public unsafe void WriteObjects (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream @out, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> list)
		{
			if (id_writeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_ == IntPtr.Zero)
				id_writeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "writeObjects", "(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Ljava/util/List;)V");
			IntPtr native_list = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack>.ToLocalJniHandle (list);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
			__args [1] = new JValue (native_list);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackOutputStream_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_list);
		}

	}
}
