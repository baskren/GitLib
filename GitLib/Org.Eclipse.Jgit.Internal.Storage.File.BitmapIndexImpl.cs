using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Org.Eclipse.Jgit.Lib;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>A compressed bitmap representation of the entire object graph.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='BitmapIndexImpl']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/BitmapIndexImpl", DoNotGenerateAcw=true)]
	public partial class BitmapIndexImpl : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Lib.IBitmapIndex {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/BitmapIndexImpl", typeof (BitmapIndexImpl));

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

		protected BitmapIndexImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="packIndex">the bitmap index for the pack.</param>
		/// <summary>Creates a BitmapIndex that is back by Compressed bitmaps.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='BitmapIndexImpl']/constructor[@name='BitmapIndexImpl' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.file.PackBitmapIndex']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;)V", "")]
		public unsafe BitmapIndexImpl (global::Org.Eclipse.Jgit.Internal.Storage.File.PackBitmapIndex packIndex) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/file/PackBitmapIndex;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((packIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packIndex).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (packIndex);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.BitmapIndexImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBitmap (objectId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='BitmapIndexImpl']/method[@name='getBitmap' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("getBitmap", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Ljava/lang/Object;", "GetGetBitmap_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Java.Lang.Object GetBitmap (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			const string __id = "getBitmap.(Lorg/eclipse/jgit/lib/AnyObjectId;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

        IBitmapIndexBitmap IBitmapIndex.GetBitmap(AnyObjectId objectId)
        {
			return (IBitmapIndexBitmap)GetBitmap(objectId);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.BitmapIndexImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewBitmapBuilder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='BitmapIndexImpl']/method[@name='newBitmapBuilder' and count(parameter)=0]"
		[Register ("newBitmapBuilder", "()Ljava/lang/Object;", "GetNewBitmapBuilderHandler")]
		public virtual unsafe global::Java.Lang.Object NewBitmapBuilder ()
		{
			const string __id = "newBitmapBuilder.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

        IBitmapIndexBitmapBuilder IBitmapIndex.NewBitmapBuilder()
        {
			return (IBitmapIndexBitmapBuilder)this.NewBitmapBuilder();
        }
    }
}
