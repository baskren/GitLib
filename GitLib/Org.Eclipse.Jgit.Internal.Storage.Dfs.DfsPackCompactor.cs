using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Combine several pack files into one pack.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsPackCompactor", DoNotGenerateAcw=true)]
	public partial class DfsPackCompactor : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsPackCompactor", typeof (DfsPackCompactor));

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

		protected DfsPackCompactor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repository">repository objects to be packed will be read from.</param>
		/// <summary>Initialize a pack compactor.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']/constructor[@name='DfsPackCompactor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsRepository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;)V", "")]
		public unsafe DfsPackCompactor (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository repository) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics>.ToLocalJniHandle (__this.NewPackStatistics);
		}
#pragma warning restore 0169

		/// <returns>statistics corresponding to the <c>#getNewPacks()</c>.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> NewPackStatistics {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']/method[@name='getNewPackStatistics' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (__this.NewPacks);
		}
#pragma warning restore 0169

		/// <returns>new packs created by this compaction.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> NewPacks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']/method[@name='getNewPacks' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (__this.SourcePacks);
		}
#pragma warning restore 0169

		/// <returns>all of the source packs that fed into this compaction.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> SourcePacks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']/method[@name='getSourcePacks' and count(parameter)=0]"
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

		static Delegate cb_add_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_ == null)
				cb_add_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Add_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_);
			return cb_add_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_;
		}

		static IntPtr n_Add_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile> (native_pack, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (pack));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pack">a pack to combine into the resulting pack.</param>
		/// <summary>Add a pack to be compacted.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsPackFile']]"
		[Register ("add", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackCompactor;", "GetAdd_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor Add (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile pack)
		{
			const string __id = "add.(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackCompactor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pack).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (pack);
			}
		}

		static Delegate cb_autoAdd;
#pragma warning disable 0169
		static Delegate GetAutoAddHandler ()
		{
			if (cb_autoAdd == null)
				cb_autoAdd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AutoAdd);
			return cb_autoAdd;
		}

		static IntPtr n_AutoAdd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AutoAdd ());
		}
#pragma warning restore 0169

		/// <summary>Automatically select packs to be included, and add them.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']/method[@name='autoAdd' and count(parameter)=0]"
		[Register ("autoAdd", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackCompactor;", "GetAutoAddHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor AutoAdd ()
		{
			const string __id = "autoAdd.()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackCompactor;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compact_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetCompact_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_compact_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_compact_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Compact_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_compact_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static void n_Compact_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pm = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_pm, JniHandleOwnership.DoNotTransfer);
			__this.Compact (pm);
		}
#pragma warning restore 0169

		/// <param name="pm">progress monitor to receive updates on as packing may take a
		///            while, depending on the size of the repository.</param>
		/// <summary>Compact the pack files together.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']/method[@name='compact' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("compact", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)V", "GetCompact_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe void Compact (global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm)
		{
			const string __id = "compact.(Lorg/eclipse/jgit/lib/ProgressMonitor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pm);
			}
		}

		static Delegate cb_exclude_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_;
#pragma warning disable 0169
		static Delegate GetExclude_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_Handler ()
		{
			if (cb_exclude_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_ == null)
				cb_exclude_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Exclude_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_);
			return cb_exclude_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_;
		}

		static IntPtr n_Exclude_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile> (native_pack, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Exclude (pack));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pack">objects to not include.</param>
		/// <summary>Exclude objects from the compacted pack.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']/method[@name='exclude' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsPackFile']]"
		[Register ("exclude", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackCompactor;", "GetExclude_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackFile_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor Exclude (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile pack)
		{
			const string __id = "exclude.(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackCompactor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pack).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (pack);
			}
		}

		static Delegate cb_exclude_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_;
#pragma warning disable 0169
		static Delegate GetExclude_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_Handler ()
		{
			if (cb_exclude_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_ == null)
				cb_exclude_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Exclude_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_);
			return cb_exclude_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_;
		}

		static IntPtr n_Exclude_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_set)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var set = (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.IObjectIdSet)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.IObjectIdSet> (native_set, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Exclude (set));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackCompactor']/method[@name='exclude' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackWriter.ObjectIdSet']]"
		[Register ("exclude", "(Lorg/eclipse/jgit/internal/storage/pack/PackWriter$ObjectIdSet;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackCompactor;", "GetExclude_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor Exclude (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.IObjectIdSet set)
		{
			const string __id = "exclude.(Lorg/eclipse/jgit/internal/storage/pack/PackWriter$ObjectIdSet;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackCompactor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackCompactor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (set);
			}
		}

	}
}
