using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A bitmap representation of ObjectIds that can be iterated to return the
	/// underlying <c>ObjectId</c>s or operated on with other <c>Bitmap</c>s.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.Bitmap']"
	[Register ("org/eclipse/jgit/lib/BitmapIndex$Bitmap", "", "Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapInvoker")]
	public partial interface IBitmapIndexBitmap : global::Java.Lang.IIterable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.Bitmap']/method[@name='andNot' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BitmapIndex.Bitmap']]"
		[Register ("andNot", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;", "GetAndNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap AndNot (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.Bitmap']/method[@name='iterator' and count(parameter)=0]"
		/// <summary>Returns an iterator over a set of elements of type BitmapObject.</summary>
		/// <returns>an Iterator.</returns>
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapInvoker, AndroidBindableLibrary")]
		global::Java.Util.IIterator Iterator ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.Bitmap']/method[@name='or' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BitmapIndex.Bitmap']]"
		[Register ("or", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;", "GetOr_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap Or (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.Bitmap']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BitmapIndex.Bitmap']]"
		[Register ("xor", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;", "GetXor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap Xor (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BitmapIndex$Bitmap", DoNotGenerateAcw=true)]
	internal partial class IBitmapIndexBitmapInvoker : global::Java.Lang.Object, IBitmapIndexBitmap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BitmapIndex$Bitmap", typeof (IBitmapIndexBitmapInvoker));

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

		public static IBitmapIndexBitmap GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBitmapIndexBitmap> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.BitmapIndex.Bitmap'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBitmapIndexBitmapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
#pragma warning disable 0169
		static Delegate GetAndNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler ()
		{
			if (cb_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == null)
				cb_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AndNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_);
			return cb_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		}

		static IntPtr n_AndNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AndNot (other));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		public unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap AndNot (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other)
		{
			if (id_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == IntPtr.Zero)
				id_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNIEnv.GetMethodID (class_ref, "andNot", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
#pragma warning disable 0169
		static Delegate GetOr_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler ()
		{
			if (cb_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == null)
				cb_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_);
			return cb_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		}

		static IntPtr n_Or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Or (other));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		public unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap Or (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other)
		{
			if (id_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == IntPtr.Zero)
				id_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNIEnv.GetMethodID (class_ref, "or", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
#pragma warning disable 0169
		static Delegate GetXor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler ()
		{
			if (cb_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == null)
				cb_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_);
			return cb_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		}

		static IntPtr n_Xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Xor (other));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		public unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap Xor (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other)
		{
			if (id_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == IntPtr.Zero)
				id_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNIEnv.GetMethodID (class_ref, "xor", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

	/// <summary>A builder for a bitmap.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']"
	[Register ("org/eclipse/jgit/lib/BitmapIndex$BitmapBuilder", "", "Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker")]
	public partial interface IBitmapIndexBitmapBuilder : global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		/// <param name="objectId">the object ID</param>
		/// <param name="type">the Git object type. See <c>Constants</c>.</param>
		/// <summary>Adds the id and the existing bitmap for the id, if one exists, to the
		/// bitmap.</summary>
		/// <returns>true if the value was not contained or able to be loaded.</returns>
		[Register ("add", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Z", "GetAdd_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker, AndroidBindableLibrary")]
		bool Add (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int type);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']/method[@name='andNot' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BitmapIndex.Bitmap']]"
		[Register ("andNot", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;", "GetAndNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder AndNot (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;", "GetBuildHandler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap Build ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']/method[@name='cardinality' and count(parameter)=0]"
		/// <returns>the number of elements in the bitmap.</returns>
		[Register ("cardinality", "()I", "GetCardinalityHandler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker, AndroidBindableLibrary")]
		int Cardinality ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		/// <param name="objectId">the object ID</param>
		/// <summary>Whether the bitmap has the id set.</summary>
		/// <returns>whether the bitmap currently contains the object ID</returns>
		[Register ("contains", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetContains_Lorg_eclipse_jgit_lib_AnyObjectId_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker, AndroidBindableLibrary")]
		bool Contains (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']/method[@name='or' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BitmapIndex.Bitmap']]"
		[Register ("or", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;", "GetOr_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder Or (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		/// <param name="objectId">the object ID</param>
		/// <summary>Remove the id from the bitmap.</summary>
		[Register ("remove", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetRemove_Lorg_eclipse_jgit_lib_AnyObjectId_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker, AndroidBindableLibrary")]
		void Remove (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']/method[@name='removeAllOrNone' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.file.PackBitmapIndex']]"
		/// <param name="bitmapIndex">the bitmap index to check if it is completely contained
		///            inside of the current bitmap.</param>
		/// <summary>Determines if the entire bitmap index is contained in the bitmap.</summary>
		/// <returns>
		///   <c>true</c> if the bitmap index was a complete match.</returns>
		[Register ("removeAllOrNone", "(Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;)Z", "GetRemoveAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker, AndroidBindableLibrary")]
		bool RemoveAllOrNone (global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex bitmapIndex);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex.BitmapBuilder']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BitmapIndex.Bitmap']]"
		[Register ("xor", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;", "GetXor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilderInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder Xor (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BitmapIndex$BitmapBuilder", DoNotGenerateAcw=true)]
	internal partial class IBitmapIndexBitmapBuilderInvoker : global::Java.Lang.Object, IBitmapIndexBitmapBuilder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BitmapIndex$BitmapBuilder", typeof (IBitmapIndexBitmapBuilderInvoker));

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

		public static IBitmapIndexBitmapBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBitmapIndexBitmapBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.BitmapIndex.BitmapBuilder'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBitmapIndexBitmapBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_add_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_add_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_add_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_Add_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_add_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static bool n_Add_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (objectId, type);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_add_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		public unsafe bool Add (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int type)
		{
			if (id_add_Lorg_eclipse_jgit_lib_AnyObjectId_I == IntPtr.Zero)
				id_add_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
			__args [1] = new JValue (type);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_add_Lorg_eclipse_jgit_lib_AnyObjectId_I, __args);
			return __ret;
		}

		static Delegate cb_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
#pragma warning disable 0169
		static Delegate GetAndNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler ()
		{
			if (cb_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == null)
				cb_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AndNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_);
			return cb_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		}

		static IntPtr n_AndNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AndNot (other));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		public unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder AndNot (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other)
		{
			if (id_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == IntPtr.Zero)
				id_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNIEnv.GetMethodID (class_ref, "andNot", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_andNot_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		IntPtr id_build;
		public unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;");
			return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_cardinality;
#pragma warning disable 0169
		static Delegate GetCardinalityHandler ()
		{
			if (cb_cardinality == null)
				cb_cardinality = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Cardinality);
			return cb_cardinality;
		}

		static int n_Cardinality (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cardinality ();
		}
#pragma warning restore 0169

		IntPtr id_cardinality;
		public unsafe int Cardinality ()
		{
			if (id_cardinality == IntPtr.Zero)
				id_cardinality = JNIEnv.GetMethodID (class_ref, "cardinality", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cardinality);
		}

		static Delegate cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetContains_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_Contains_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (objectId);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
		public unsafe bool Contains (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			if (id_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ == IntPtr.Zero)
				id_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lorg_eclipse_jgit_lib_AnyObjectId_, __args);
			return __ret;
		}

		static Delegate cb_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
#pragma warning disable 0169
		static Delegate GetOr_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler ()
		{
			if (cb_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == null)
				cb_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_);
			return cb_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		}

		static IntPtr n_Or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Or (other));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		public unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder Or (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other)
		{
			if (id_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == IntPtr.Zero)
				id_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNIEnv.GetMethodID (class_ref, "or", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_or_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_remove_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetRemove_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_remove_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_remove_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Remove_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_remove_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Remove_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			__this.Remove (objectId);
		}
#pragma warning restore 0169

		IntPtr id_remove_Lorg_eclipse_jgit_lib_AnyObjectId_;
		public unsafe void Remove (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			if (id_remove_Lorg_eclipse_jgit_lib_AnyObjectId_ == IntPtr.Zero)
				id_remove_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lorg_eclipse_jgit_lib_AnyObjectId_, __args);
		}

		static Delegate cb_removeAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_;
#pragma warning disable 0169
		static Delegate GetRemoveAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_Handler ()
		{
			if (cb_removeAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_ == null)
				cb_removeAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_);
			return cb_removeAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_;
		}

		static bool n_RemoveAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmapIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmapIndex = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex> (native_bitmapIndex, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAllOrNone (bitmapIndex);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_;
		public unsafe bool RemoveAllOrNone (global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex bitmapIndex)
		{
			if (id_removeAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_ == IntPtr.Zero)
				id_removeAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_ = JNIEnv.GetMethodID (class_ref, "removeAllOrNone", "(Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((bitmapIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmapIndex).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeAllOrNone_Lorg_eclipse_jgit_internal_storage_file_PackBitmapIndex_, __args);
			return __ret;
		}

		static Delegate cb_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
#pragma warning disable 0169
		static Delegate GetXor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_Handler ()
		{
			if (cb_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == null)
				cb_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_);
			return cb_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		}

		static IntPtr n_Xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Xor (other));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_;
		public unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder Xor (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap other)
		{
			if (id_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ == IntPtr.Zero)
				id_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_ = JNIEnv.GetMethodID (class_ref, "xor", "(Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;)Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_xor_Lorg_eclipse_jgit_lib_BitmapIndex_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		IBitmapIndexBitmap IBitmapIndexBitmap.AndNot(IBitmapIndexBitmap other)
			=> this.AndNot(other);

		IBitmapIndexBitmap IBitmapIndexBitmap.Or(IBitmapIndexBitmap other)
			=> this.Or(other);

		IBitmapIndexBitmap IBitmapIndexBitmap.Xor(IBitmapIndexBitmap other)
			=> this.Xor(other);
    }

	/// <summary>A compressed bitmap representation of the entire object graph.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex']"
	[Register ("org/eclipse/jgit/lib/BitmapIndex", "", "Org.Eclipse.Jgit.Lib.IBitmapIndexInvoker")]
	public partial interface IBitmapIndex : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex']/method[@name='getBitmap' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("getBitmap", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;", "GetGetBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Handler:Org.Eclipse.Jgit.Lib.IBitmapIndexInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap GetBitmap (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='BitmapIndex']/method[@name='newBitmapBuilder' and count(parameter)=0]"
		[Register ("newBitmapBuilder", "()Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;", "GetNewBitmapBuilderHandler:Org.Eclipse.Jgit.Lib.IBitmapIndexInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder NewBitmapBuilder ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BitmapIndex", DoNotGenerateAcw=true)]
	internal partial class IBitmapIndexInvoker : global::Java.Lang.Object, IBitmapIndex {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BitmapIndex", typeof (IBitmapIndexInvoker));

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

		public static IBitmapIndex GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBitmapIndex> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.BitmapIndex'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBitmapIndexInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetGetBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_getBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_getBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_getBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_GetBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBitmap (objectId));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_;
		public unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap GetBitmap (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			if (id_getBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_ == IntPtr.Zero)
				id_getBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNIEnv.GetMethodID (class_ref, "getBitmap", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/BitmapIndex$Bitmap;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_newBitmapBuilder;
#pragma warning disable 0169
		static Delegate GetNewBitmapBuilderHandler ()
		{
			if (cb_newBitmapBuilder == null)
				cb_newBitmapBuilder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewBitmapBuilder);
			return cb_newBitmapBuilder;
		}

		static IntPtr n_NewBitmapBuilder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewBitmapBuilder ());
		}
#pragma warning restore 0169

		IntPtr id_newBitmapBuilder;
		public unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder NewBitmapBuilder ()
		{
			if (id_newBitmapBuilder == IntPtr.Zero)
				id_newBitmapBuilder = JNIEnv.GetMethodID (class_ref, "newBitmapBuilder", "()Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;");
			return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newBitmapBuilder), JniHandleOwnership.TransferLocalRef);
		}

	}
}
