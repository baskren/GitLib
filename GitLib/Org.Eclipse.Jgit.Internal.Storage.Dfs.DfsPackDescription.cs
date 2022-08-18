using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Description of a DFS stored pack/index file.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsPackDescription", DoNotGenerateAcw=true)]
	public partial class DfsPackDescription : global::Java.Lang.Object, global::Java.Lang.IComparable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsPackDescription", typeof (DfsPackDescription));

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

		protected DfsPackDescription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="name">name of the pack file. Must end with ".pack".</param>
		/// <param name="repoDesc">description of the repo containing the pack file.</param>
		/// <summary>Initialize a description by pack name and repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/constructor[@name='DfsPackDescription' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsRepositoryDescription'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;Ljava/lang/String;)V", "")]
		public unsafe DfsPackDescription (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription repoDesc, string name) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repoDesc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repoDesc).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (repoDesc);
			}
		}

		static Delegate cb_getDeltaCount;
#pragma warning disable 0169
		static Delegate GetGetDeltaCountHandler ()
		{
			if (cb_getDeltaCount == null)
				cb_getDeltaCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDeltaCount);
			return cb_getDeltaCount;
		}

		static long n_GetDeltaCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaCount;
		}
#pragma warning restore 0169

		/// <returns>number of delta compressed objects in the pack.</returns>
		public virtual unsafe long DeltaCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='getDeltaCount' and count(parameter)=0]"
			[Register ("getDeltaCount", "()J", "GetGetDeltaCountHandler")]
			get {
				const string __id = "getDeltaCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIndexVersion;
#pragma warning disable 0169
		static Delegate GetGetIndexVersionHandler ()
		{
			if (cb_getIndexVersion == null)
				cb_getIndexVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIndexVersion);
			return cb_getIndexVersion;
		}

		static int n_GetIndexVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexVersion;
		}
#pragma warning restore 0169

		/// <returns>the version of the index file written.</returns>
		public virtual unsafe int IndexVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='getIndexVersion' and count(parameter)=0]"
			[Register ("getIndexVersion", "()I", "GetGetIndexVersionHandler")]
			get {
				const string __id = "getIndexVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastModified;
#pragma warning disable 0169
		static Delegate GetGetLastModifiedHandler ()
		{
			if (cb_getLastModified == null)
				cb_getLastModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLastModified);
			return cb_getLastModified;
		}

		static long n_GetLastModified (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastModified;
		}
#pragma warning restore 0169

		/// <returns>time the pack was created, in milliseconds.</returns>
		public virtual unsafe long LastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='getLastModified' and count(parameter)=0]"
			[Register ("getLastModified", "()J", "GetGetLastModifiedHandler")]
			get {
				const string __id = "getLastModified.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getObjectCount;
#pragma warning disable 0169
		static Delegate GetGetObjectCountHandler ()
		{
			if (cb_getObjectCount == null)
				cb_getObjectCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetObjectCount);
			return cb_getObjectCount;
		}

		static long n_GetObjectCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectCount;
		}
#pragma warning restore 0169

		/// <returns>number of objects in the pack.</returns>
		public virtual unsafe long ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()J", "GetGetObjectCountHandler")]
			get {
				const string __id = "getObjectCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPackSource;
#pragma warning disable 0169
		static Delegate GetGetPackSourceHandler ()
		{
			if (cb_getPackSource == null)
				cb_getPackSource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackSource);
			return cb_getPackSource;
		}

		static IntPtr n_GetPackSource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackSource);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource PackSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='getPackSource' and count(parameter)=0]"
			[Register ("getPackSource", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;", "GetGetPackSourceHandler")]
			get {
				const string __id = "getPackSource.()Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackStats;
#pragma warning disable 0169
		static Delegate GetGetPackStatsHandler ()
		{
			if (cb_getPackStats == null)
				cb_getPackStats = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackStats);
			return cb_getPackStats;
		}

		static IntPtr n_GetPackStats (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackStats);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics PackStats {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='getPackStats' and count(parameter)=0]"
			[Register ("getPackStats", "()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;", "GetGetPackStatsHandler")]
			get {
				const string __id = "getPackStats.()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRepositoryDescription;
#pragma warning disable 0169
		static Delegate GetGetRepositoryDescriptionHandler ()
		{
			if (cb_getRepositoryDescription == null)
				cb_getRepositoryDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepositoryDescription);
			return cb_getRepositoryDescription;
		}

		static IntPtr n_GetRepositoryDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RepositoryDescription);
		}
#pragma warning restore 0169

		/// <returns>description of the repository.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription RepositoryDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='getRepositoryDescription' and count(parameter)=0]"
			[Register ("getRepositoryDescription", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;", "GetGetRepositoryDescriptionHandler")]
			get {
				const string __id = "getRepositoryDescription.()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
#pragma warning disable 0169
		static Delegate GetAddFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler ()
		{
			if (cb_addFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ == null)
				cb_addFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_);
			return cb_addFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
		}

		static void n_AddFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ext = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (native_ext, JniHandleOwnership.DoNotTransfer);
			__this.AddFileExt (ext);
		}
#pragma warning restore 0169

		/// <param name="ext">the file extension</param>
		/// <summary>Adds the pack file extension to the known list.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='addFileExt' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackExt']]"
		[Register ("addFileExt", "(Lorg/eclipse/jgit/internal/storage/pack/PackExt;)V", "GetAddFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler")]
		public virtual unsafe void AddFileExt (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt ext)
		{
			const string __id = "addFileExt.(Lorg/eclipse/jgit/internal/storage/pack/PackExt;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ext).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (ext);
			}
		}

		static Delegate cb_clearPackStats;
#pragma warning disable 0169
		static Delegate GetClearPackStatsHandler ()
		{
			if (cb_clearPackStats == null)
				cb_clearPackStats = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ClearPackStats);
			return cb_clearPackStats;
		}

		static IntPtr n_ClearPackStats (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearPackStats ());
		}
#pragma warning restore 0169

		/// <summary>Discard the pack statistics, if it was populated.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='clearPackStats' and count(parameter)=0]"
		[Register ("clearPackStats", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetClearPackStatsHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription ClearPackStats ()
		{
			const string __id = "clearPackStats.()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compareTo_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Handler ()
		{
			if (cb_compareTo_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_ == null)
				cb_compareTo_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_);
			return cb_compareTo_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_;
		}

		static int n_CompareTo_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (native_b, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (b);
			return __ret;
		}
#pragma warning restore 0169

        public int CompareTo(Java.Lang.Object o)
        {
			return this.CompareTo((DfsPackDescription)o);
        }

        /// <param name="b">the other pack.</param>
        /// <summary>Sort packs according to the optimal lookup ordering.</summary>
        // Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsPackDescription']]"
        [Register ("compareTo", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;)I", "GetCompareTo_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Handler")]
		public virtual unsafe int CompareTo (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription b)
		{
			const string __id = "compareTo.(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_getFileName_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
#pragma warning disable 0169
		static Delegate GetGetFileName_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler ()
		{
			if (cb_getFileName_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ == null)
				cb_getFileName_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetFileName_Lorg_eclipse_jgit_internal_storage_pack_PackExt_);
			return cb_getFileName_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
		}

		static IntPtr n_GetFileName_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ext = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (native_ext, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFileName (ext));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ext">the file extension</param>
		/// <returns>name of the file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='getFileName' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackExt']]"
		[Register ("getFileName", "(Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Ljava/lang/String;", "GetGetFileName_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler")]
		public virtual unsafe string GetFileName (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt ext)
		{
			const string __id = "getFileName.(Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ext).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ext);
			}
		}

		static Delegate cb_getFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
#pragma warning disable 0169
		static Delegate GetGetFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler ()
		{
			if (cb_getFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ == null)
				cb_getFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_GetFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_);
			return cb_getFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
		}

		static long n_GetFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ext = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (native_ext, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetFileSize (ext);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ext">the file extension.</param>
		/// <returns>size of the file, in bytes. If 0 the file size is not yet known.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='getFileSize' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackExt']]"
		[Register ("getFileSize", "(Lorg/eclipse/jgit/internal/storage/pack/PackExt;)J", "GetGetFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler")]
		public virtual unsafe long GetFileSize (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt ext)
		{
			const string __id = "getFileSize.(Lorg/eclipse/jgit/internal/storage/pack/PackExt;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ext).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (ext);
			}
		}

		static Delegate cb_hasFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
#pragma warning disable 0169
		static Delegate GetHasFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler ()
		{
			if (cb_hasFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ == null)
				cb_hasFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_);
			return cb_hasFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
		}

		static bool n_HasFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ext = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (native_ext, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasFileExt (ext);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ext">the file extension</param>
		/// <returns>whether the pack file extensions is known to exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='hasFileExt' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackExt']]"
		[Register ("hasFileExt", "(Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Z", "GetHasFileExt_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler")]
		public virtual unsafe bool HasFileExt (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt ext)
		{
			const string __id = "hasFileExt.(Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ext).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (ext);
			}
		}

		static Delegate cb_setDeltaCount_J;
#pragma warning disable 0169
		static Delegate GetSetDeltaCount_JHandler ()
		{
			if (cb_setDeltaCount_J == null)
				cb_setDeltaCount_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetDeltaCount_J);
			return cb_setDeltaCount_J;
		}

		static IntPtr n_SetDeltaCount_J (IntPtr jnienv, IntPtr native__this, long cnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDeltaCount (cnt));
		}
#pragma warning restore 0169

		/// <param name="cnt">number of delta compressed objects in the pack.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='setDeltaCount' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDeltaCount", "(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetSetDeltaCount_JHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription SetDeltaCount (long cnt)
		{
			const string __id = "setDeltaCount.(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cnt);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_J;
#pragma warning disable 0169
		static Delegate GetSetFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_JHandler ()
		{
			if (cb_setFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_J == null)
				cb_setFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_SetFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_J);
			return cb_setFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_J;
		}

		static IntPtr n_SetFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_J (IntPtr jnienv, IntPtr native__this, IntPtr native_ext, long bytes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ext = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (native_ext, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFileSize (ext, bytes));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ext">the file extension.</param>
		/// <param name="bytes">size of the file in bytes. If 0 the file is not known and will
		///            be determined on first read.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='setFileSize' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackExt'] and parameter[2][@type='long']]"
		[Register ("setFileSize", "(Lorg/eclipse/jgit/internal/storage/pack/PackExt;J)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetSetFileSize_Lorg_eclipse_jgit_internal_storage_pack_PackExt_JHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription SetFileSize (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt ext, long bytes)
		{
			const string __id = "setFileSize.(Lorg/eclipse/jgit/internal/storage/pack/PackExt;J)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ext).Handle);
				__args [1] = new JniArgumentValue (bytes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ext);
			}
		}

		static Delegate cb_setIndexVersion_I;
#pragma warning disable 0169
		static Delegate GetSetIndexVersion_IHandler ()
		{
			if (cb_setIndexVersion_I == null)
				cb_setIndexVersion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetIndexVersion_I);
			return cb_setIndexVersion_I;
		}

		static IntPtr n_SetIndexVersion_I (IntPtr jnienv, IntPtr native__this, int version)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIndexVersion (version));
		}
#pragma warning restore 0169

		/// <param name="version">the version of the index file written.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='setIndexVersion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIndexVersion", "(I)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetSetIndexVersion_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription SetIndexVersion (int version)
		{
			const string __id = "setIndexVersion.(I)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (version);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLastModified_J;
#pragma warning disable 0169
		static Delegate GetSetLastModified_JHandler ()
		{
			if (cb_setLastModified_J == null)
				cb_setLastModified_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetLastModified_J);
			return cb_setLastModified_J;
		}

		static IntPtr n_SetLastModified_J (IntPtr jnienv, IntPtr native__this, long timeMillis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLastModified (timeMillis));
		}
#pragma warning restore 0169

		/// <param name="timeMillis">time the pack was created, in milliseconds. 0 if not known.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='setLastModified' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setLastModified", "(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetSetLastModified_JHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription SetLastModified (long timeMillis)
		{
			const string __id = "setLastModified.(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeMillis);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setObjectCount_J;
#pragma warning disable 0169
		static Delegate GetSetObjectCount_JHandler ()
		{
			if (cb_setObjectCount_J == null)
				cb_setObjectCount_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetObjectCount_J);
			return cb_setObjectCount_J;
		}

		static IntPtr n_SetObjectCount_J (IntPtr jnienv, IntPtr native__this, long cnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetObjectCount (cnt));
		}
#pragma warning restore 0169

		/// <param name="cnt">number of objects in the pack.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='setObjectCount' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setObjectCount", "(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetSetObjectCount_JHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription SetObjectCount (long cnt)
		{
			const string __id = "setObjectCount.(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cnt);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPackSource_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_;
#pragma warning disable 0169
		static Delegate GetSetPackSource_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_Handler ()
		{
			if (cb_setPackSource_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_ == null)
				cb_setPackSource_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPackSource_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_);
			return cb_setPackSource_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_;
		}

		static IntPtr n_SetPackSource_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPackSource (source));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackDescription']/method[@name='setPackSource' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsObjDatabase.PackSource']]"
		[Register ("setPackSource", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetSetPackSource_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription SetPackSource (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource source)
		{
			const string __id = "setPackSource.(Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (source);
			}
		}
    }
}
