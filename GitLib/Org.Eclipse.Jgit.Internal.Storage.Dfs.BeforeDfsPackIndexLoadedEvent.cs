using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Describes the <c>DfsPackFile</c> just before its index is loaded.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='BeforeDfsPackIndexLoadedEvent']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/BeforeDfsPackIndexLoadedEvent", DoNotGenerateAcw=true)]
	public partial class BeforeDfsPackIndexLoadedEvent : global::Org.Eclipse.Jgit.Events.RepositoryEvent<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IBeforeDfsPackIndexLoadedListener> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/BeforeDfsPackIndexLoadedEvent", typeof (BeforeDfsPackIndexLoadedEvent));

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

		protected BeforeDfsPackIndexLoadedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="pack">the pack</param>
		/// <summary>A new event triggered before a PackFile index is loaded.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='BeforeDfsPackIndexLoadedEvent']/constructor[@name='BeforeDfsPackIndexLoadedEvent' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsPackFile']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;)V", "")]
		public unsafe BeforeDfsPackIndexLoadedEvent (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile pack) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pack).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pack);
			}
		}

		static Delegate cb_getListenerType;
#pragma warning disable 0169
		static Delegate GetGetListenerTypeHandler ()
		{
			if (cb_getListenerType == null)
				cb_getListenerType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetListenerType);
			return cb_getListenerType;
		}

		static IntPtr n_GetListenerType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.BeforeDfsPackIndexLoadedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListenerType);
		}
#pragma warning restore 0169

		public override unsafe global::Java.Lang.Class ListenerType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='BeforeDfsPackIndexLoadedEvent']/method[@name='getListenerType' and count(parameter)=0]"
			[Register ("getListenerType", "()Ljava/lang/Class;", "GetGetListenerTypeHandler")]
			get {
				const string __id = "getListenerType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackFile;
#pragma warning disable 0169
		static Delegate GetGetPackFileHandler ()
		{
			if (cb_getPackFile == null)
				cb_getPackFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackFile);
			return cb_getPackFile;
		}

		static IntPtr n_GetPackFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.BeforeDfsPackIndexLoadedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackFile);
		}
#pragma warning restore 0169

		/// <returns>the PackFile containing the index that will be loaded.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile PackFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='BeforeDfsPackIndexLoadedEvent']/method[@name='getPackFile' and count(parameter)=0]"
			[Register ("getPackFile", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;", "GetGetPackFileHandler")]
			get {
				const string __id = "getPackFile.()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_dispatch_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedListener_;
#pragma warning disable 0169
		static Delegate GetDispatch_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedListener_Handler ()
		{
			if (cb_dispatch_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedListener_ == null)
				cb_dispatch_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Dispatch_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedListener_);
			return cb_dispatch_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedListener_;
		}

		static void n_Dispatch_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.BeforeDfsPackIndexLoadedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IBeforeDfsPackIndexLoadedListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IBeforeDfsPackIndexLoadedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Dispatch (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='BeforeDfsPackIndexLoadedEvent']/method[@name='dispatch' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.BeforeDfsPackIndexLoadedListener']]"
		[Register ("dispatch", "(Lorg/eclipse/jgit/internal/storage/dfs/BeforeDfsPackIndexLoadedListener;)V", "GetDispatch_Lorg_eclipse_jgit_internal_storage_dfs_BeforeDfsPackIndexLoadedListener_Handler")]
		public override unsafe void Dispatch (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IBeforeDfsPackIndexLoadedListener listener)
		{
			const string __id = "dispatch.(Lorg/eclipse/jgit/internal/storage/dfs/BeforeDfsPackIndexLoadedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

	}
}
