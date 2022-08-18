using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Receives <c>DfsPacksChangedEvent</c>s.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/interface[@name='DfsPacksChangedListener']"
	[Register ("org/eclipse/jgit/internal/storage/dfs/DfsPacksChangedListener", "", "Org.Eclipse.Jgit.Internal.Storage.Dfs.IDfsPacksChangedListenerInvoker")]
	public partial interface IDfsPacksChangedListener : global::Org.Eclipse.Jgit.Events.IRepositoryListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/interface[@name='DfsPacksChangedListener']/method[@name='onPacksChanged' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsPacksChangedEvent']]"
		/// <param name="event">information about the packs.</param>
		/// <summary>Invoked when all packs in a repository are listed.</summary>
		[Register ("onPacksChanged", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPacksChangedEvent;)V", "GetOnPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_Handler:Org.Eclipse.Jgit.Internal.Storage.Dfs.IDfsPacksChangedListenerInvoker, AndroidBindableLibrary")]
		void OnPacksChanged (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPacksChangedEvent e);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsPacksChangedListener", DoNotGenerateAcw=true)]
	internal partial class IDfsPacksChangedListenerInvoker : global::Java.Lang.Object, IDfsPacksChangedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsPacksChangedListener", typeof (IDfsPacksChangedListenerInvoker));

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

		public static IDfsPacksChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDfsPacksChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.internal.storage.dfs.DfsPacksChangedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDfsPacksChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_;
#pragma warning disable 0169
		static Delegate GetOnPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_Handler ()
		{
			if (cb_onPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_ == null)
				cb_onPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_);
			return cb_onPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_;
		}

		static void n_OnPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IDfsPacksChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPacksChangedEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnPacksChanged (e);
		}
#pragma warning restore 0169

		IntPtr id_onPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_;
		public unsafe void OnPacksChanged (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPacksChangedEvent e)
		{
			if (id_onPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_ == IntPtr.Zero)
				id_onPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_ = JNIEnv.GetMethodID (class_ref, "onPacksChanged", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPacksChangedEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPacksChanged_Lorg_eclipse_jgit_internal_storage_dfs_DfsPacksChangedEvent_, __args);
		}

	}
}
