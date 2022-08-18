using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Receives <c>BeforeDfsPackIndexLoadedEvent</c>s.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/interface[@name='BeforeDfsPackIndexLoadedListener']"
	[Register ("org/eclipse/jgit/internal/storage/dfs/BeforeDfsPackIndexLoadedListener", "", "Org.Eclipse.Jgit.Internal.Storage.Dfs.IBeforeDfsPackIndexLoadedListenerInvoker")]
	public partial interface IBeforeDfsPackIndexLoadedListener : global::Org.Eclipse.Jgit.Events.IRepositoryListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/interface[@name='BeforeDfsPackIndexLoadedListener']/method[@name='onBeforeDfsPackIndexLoaded' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.BeforeDfsPackIndexLoadedEvent']]"
		/// <param name="event">information about the packs.</param>
		/// <summary>Invoked just before a pack index is loaded from the block cache.</summary>
		[Register ("onBeforeDfsPackIndexLoaded", "(Lorg/eclipse/jgit/internal/storage/dfs/BeforeDfsPackIndexLoadedEvent;)V", "GetOnBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_Handler:Org.Eclipse.Jgit.Internal.Storage.Dfs.IBeforeDfsPackIndexLoadedListenerInvoker, AndroidBindableLibrary")]
		void OnBeforeDfsPackIndexLoaded (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.BeforeDfsPackIndexLoadedEvent e);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/BeforeDfsPackIndexLoadedListener", DoNotGenerateAcw=true)]
	internal partial class IBeforeDfsPackIndexLoadedListenerInvoker : global::Java.Lang.Object, IBeforeDfsPackIndexLoadedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/BeforeDfsPackIndexLoadedListener", typeof (IBeforeDfsPackIndexLoadedListenerInvoker));

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

		public static IBeforeDfsPackIndexLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBeforeDfsPackIndexLoadedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.internal.storage.dfs.BeforeDfsPackIndexLoadedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBeforeDfsPackIndexLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_;
#pragma warning disable 0169
		static Delegate GetOnBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_Handler ()
		{
			if (cb_onBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_ == null)
				cb_onBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_);
			return cb_onBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_;
		}

		static void n_OnBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IBeforeDfsPackIndexLoadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.BeforeDfsPackIndexLoadedEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnBeforeDfsPackIndexLoaded (e);
		}
#pragma warning restore 0169

		IntPtr id_onBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_;
		public unsafe void OnBeforeDfsPackIndexLoaded (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.BeforeDfsPackIndexLoadedEvent e)
		{
			if (id_onBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_ == IntPtr.Zero)
				id_onBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_ = JNIEnv.GetMethodID (class_ref, "onBeforeDfsPackIndexLoaded", "(Lorg/eclipse/jgit/internal/storage/dfs/BeforeDfsPackIndexLoadedEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeforeDfsPackIndexLoaded_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedEvent_, __args);
		}

	}
}
