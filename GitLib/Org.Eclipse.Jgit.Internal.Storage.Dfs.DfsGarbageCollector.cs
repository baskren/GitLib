using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Repack and garbage collect a repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsGarbageCollector", DoNotGenerateAcw=true)]
	public partial class DfsGarbageCollector : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsGarbageCollector", typeof (DfsGarbageCollector));

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

		protected DfsGarbageCollector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repository">repository objects to be packed will be read from.</param>
		/// <summary>Initialize a garbage collector.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']/constructor[@name='DfsGarbageCollector' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsRepository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;)V", "")]
		public unsafe DfsGarbageCollector (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository repository) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repository);
			}
		}

		static Delegate cb_getCoalesceGarbageLimit;
#pragma warning disable 0169
		static Delegate GetGetCoalesceGarbageLimitHandler ()
		{
			if (cb_getCoalesceGarbageLimit == null)
				cb_getCoalesceGarbageLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCoalesceGarbageLimit);
			return cb_getCoalesceGarbageLimit;
		}

		static long n_GetCoalesceGarbageLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CoalesceGarbageLimit;
		}
#pragma warning restore 0169

		/// <returns>garbage packs smaller than this size will be repacked.</returns>
		public virtual unsafe long CoalesceGarbageLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']/method[@name='getCoalesceGarbageLimit' and count(parameter)=0]"
			[Register ("getCoalesceGarbageLimit", "()J", "GetGetCoalesceGarbageLimitHandler")]
			get {
				const string __id = "getCoalesceGarbageLimit.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNewPackStatistics;
#pragma warning disable 0169
		static Delegate GetGetNewPackStatisticsHandler ()
		{
			if (cb_getNewPackStatistics == null)
				cb_getNewPackStatistics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewPackStatistics);
			return cb_getNewPackStatistics;
		}

		static IntPtr n_GetNewPackStatistics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics>.ToLocalJniHandle (__this.NewPackStatistics);
		}
#pragma warning restore 0169

		/// <returns>statistics corresponding to the <c>#getNewPacks()</c>.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> NewPackStatistics {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']/method[@name='getNewPackStatistics' and count(parameter)=0]"
			[Register ("getNewPackStatistics", "()Ljava/util/List;", "GetGetNewPackStatisticsHandler")]
			get {
				const string __id = "getNewPackStatistics.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNewPacks;
#pragma warning disable 0169
		static Delegate GetGetNewPacksHandler ()
		{
			if (cb_getNewPacks == null)
				cb_getNewPacks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewPacks);
			return cb_getNewPacks;
		}

		static IntPtr n_GetNewPacks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (__this.NewPacks);
		}
#pragma warning restore 0169

		/// <returns>new packs created by this compaction.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> NewPacks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']/method[@name='getNewPacks' and count(parameter)=0]"
			[Register ("getNewPacks", "()Ljava/util/List;", "GetGetNewPacksHandler")]
			get {
				const string __id = "getNewPacks.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackConfig;
#pragma warning disable 0169
		static Delegate GetGetPackConfigHandler ()
		{
			if (cb_getPackConfig == null)
				cb_getPackConfig = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackConfig);
			return cb_getPackConfig;
		}

		static IntPtr n_GetPackConfig (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackConfig);
		}
#pragma warning restore 0169

		/// <returns>configuration used to generate the new pack file.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Storage.Pack.PackConfig PackConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']/method[@name='getPackConfig' and count(parameter)=0]"
			[Register ("getPackConfig", "()Lorg/eclipse/jgit/storage/pack/PackConfig;", "GetGetPackConfigHandler")]
			get {
				const string __id = "getPackConfig.()Lorg/eclipse/jgit/storage/pack/PackConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourcePacks;
#pragma warning disable 0169
		static Delegate GetGetSourcePacksHandler ()
		{
			if (cb_getSourcePacks == null)
				cb_getSourcePacks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSourcePacks);
			return cb_getSourcePacks;
		}

		static IntPtr n_GetSourcePacks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (__this.SourcePacks);
		}
#pragma warning restore 0169

		/// <returns>all of the source packs that fed into this compaction.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> SourcePacks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']/method[@name='getSourcePacks' and count(parameter)=0]"
			[Register ("getSourcePacks", "()Ljava/util/List;", "GetGetSourcePacksHandler")]
			get {
				const string __id = "getSourcePacks.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_pack_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetPack_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_pack_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_pack_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Pack_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_pack_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static bool n_Pack_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pm = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_pm, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Pack (pm);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pm">progress monitor to receive updates on as packing may take a
		///            while, depending on the size of the repository.</param>
		/// <summary>Create a single new pack file containing all of the live objects.</summary>
		/// <returns>true if the repack was successful without race conditions. False
		///         if a race condition was detected and the repack should be run
		///         again later.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']/method[@name='pack' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("pack", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Z", "GetPack_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe bool Pack (global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm)
		{
			const string __id = "pack.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (pm);
			}
		}

		static Delegate cb_setCoalesceGarbageLimit_J;
#pragma warning disable 0169
		static Delegate GetSetCoalesceGarbageLimit_JHandler ()
		{
			if (cb_setCoalesceGarbageLimit_J == null)
				cb_setCoalesceGarbageLimit_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetCoalesceGarbageLimit_J);
			return cb_setCoalesceGarbageLimit_J;
		}

		static IntPtr n_SetCoalesceGarbageLimit_J (IntPtr jnienv, IntPtr native__this, long limit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCoalesceGarbageLimit (limit));
		}
#pragma warning restore 0169

		/// <param name="limit">size in bytes.</param>
		/// <summary>Set the byte size limit for garbage packs to be repacked.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']/method[@name='setCoalesceGarbageLimit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setCoalesceGarbageLimit", "(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsGarbageCollector;", "GetSetCoalesceGarbageLimit_JHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector SetCoalesceGarbageLimit (long limit)
		{
			const string __id = "setCoalesceGarbageLimit.(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsGarbageCollector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
#pragma warning disable 0169
		static Delegate GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler ()
		{
			if (cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ == null)
				cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_);
			return cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
		}

		static IntPtr n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newConfig = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (native_newConfig, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPackConfig (newConfig));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="newConfig">the new configuration to use when creating the pack file.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsGarbageCollector']/method[@name='setPackConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.storage.pack.PackConfig']]"
		[Register ("setPackConfig", "(Lorg/eclipse/jgit/storage/pack/PackConfig;)Lorg/eclipse/jgit/internal/storage/dfs/DfsGarbageCollector;", "GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector SetPackConfig (global::Org.Eclipse.Jgit.Storage.Pack.PackConfig newConfig)
		{
			const string __id = "setPackConfig.(Lorg/eclipse/jgit/storage/pack/PackConfig;)Lorg/eclipse/jgit/internal/storage/dfs/DfsGarbageCollector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newConfig).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsGarbageCollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (newConfig);
			}
		}

	}
}
