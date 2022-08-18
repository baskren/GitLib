using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Manages objects stored in <c>DfsPackFile</c> on a storage system.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsObjDatabase", DoNotGenerateAcw=true)]
	public abstract partial class DfsObjDatabase : global::Org.Eclipse.Jgit.Lib.ObjectDatabase {
		/// <summary>Sources for a pack file.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase.PackSource']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource", DoNotGenerateAcw=true)]
		public sealed partial class PackSource : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase.PackSource']/field[@name='COMPACT']"
			[Register ("COMPACT")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource Compact {
				get {
					const string __id = "COMPACT.Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase.PackSource']/field[@name='GC']"
			[Register ("GC")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource Gc {
				get {
					const string __id = "GC.Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase.PackSource']/field[@name='INSERT']"
			[Register ("INSERT")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource Insert {
				get {
					const string __id = "INSERT.Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase.PackSource']/field[@name='RECEIVE']"
			[Register ("RECEIVE")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource Receive {
				get {
					const string __id = "RECEIVE.Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase.PackSource']/field[@name='UNREACHABLE_GARBAGE']"
			[Register ("UNREACHABLE_GARBAGE")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource UnreachableGarbage {
				get {
					const string __id = "UNREACHABLE_GARBAGE.Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource", typeof (PackSource));

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

			internal PackSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase.PackSource']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase.PackSource']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsObjDatabase", typeof (DfsObjDatabase));

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

		protected DfsObjDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repository">repository owning this object database.</param>
		/// <param name="options">how readers should access the object database.</param>
		/// <summary>Initialize an object database for our repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/constructor[@name='DfsObjDatabase' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsRepository'] and parameter[2][@type='org.eclipse.jgit.internal.storage.dfs.DfsReaderOptions']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;)V", "")]
		protected unsafe DfsObjDatabase (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository repository, global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions options) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (options);
			}
		}

		static Delegate cb_getReaderOptions;
#pragma warning disable 0169
		static Delegate GetGetReaderOptionsHandler ()
		{
			if (cb_getReaderOptions == null)
				cb_getReaderOptions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReaderOptions);
			return cb_getReaderOptions;
		}

		static IntPtr n_GetReaderOptions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReaderOptions);
		}
#pragma warning restore 0169

		/// <returns>configured reader options, such as read-ahead.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions ReaderOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='getReaderOptions' and count(parameter)=0]"
			[Register ("getReaderOptions", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;", "GetGetReaderOptionsHandler")]
			get {
				const string __id = "getReaderOptions.()Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRepository;
#pragma warning disable 0169
		static Delegate GetGetRepositoryHandler ()
		{
			if (cb_getRepository == null)
				cb_getRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepository);
			return cb_getRepository;
		}

		static IntPtr n_GetRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		/// <returns>repository owning this object database.</returns>
		protected virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;", "GetGetRepositoryHandler")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearCache;
#pragma warning disable 0169
		static Delegate GetClearCacheHandler ()
		{
			if (cb_clearCache == null)
				cb_clearCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearCache);
			return cb_clearCache;
		}

		static void n_ClearCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCache ();
		}
#pragma warning restore 0169

		/// <summary>Clears the cached list of packs, forcing them to be scanned again.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='clearCache' and count(parameter)=0]"
		[Register ("clearCache", "()V", "GetClearCacheHandler")]
		protected virtual unsafe void ClearCache ()
		{
			const string __id = "clearCache.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_commitPack_Ljava_util_Collection_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetCommitPack_Ljava_util_Collection_Ljava_util_Collection_Handler ()
		{
			if (cb_commitPack_Ljava_util_Collection_Ljava_util_Collection_ == null)
				cb_commitPack_Ljava_util_Collection_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CommitPack_Ljava_util_Collection_Ljava_util_Collection_);
			return cb_commitPack_Ljava_util_Collection_Ljava_util_Collection_;
		}

		static void n_CommitPack_Ljava_util_Collection_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_desc, IntPtr native_replaces)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desc = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.FromJniHandle (native_desc, JniHandleOwnership.DoNotTransfer);
			var replaces = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.FromJniHandle (native_replaces, JniHandleOwnership.DoNotTransfer);
			__this.CommitPack (desc, replaces);
		}
#pragma warning restore 0169

		/// <param name="desc">description of the new packs.</param>
		/// <param name="replaces">if not null, list of packs to remove.</param>
		/// <summary>Commit a pack and index pair that was written to the DFS.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='commitPack' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.internal.storage.dfs.DfsPackDescription&gt;'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.internal.storage.dfs.DfsPackDescription&gt;']]"
		[Register ("commitPack", "(Ljava/util/Collection;Ljava/util/Collection;)V", "GetCommitPack_Ljava_util_Collection_Ljava_util_Collection_Handler")]
		protected virtual unsafe void CommitPack (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> desc, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> replaces)
		{
			const string __id = "commitPack.(Ljava/util/Collection;Ljava/util/Collection;)V";
			IntPtr native_desc = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (desc);
			IntPtr native_replaces = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (replaces);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_desc);
				__args [1] = new JniArgumentValue (native_replaces);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_desc);
				JNIEnv.DeleteLocalRef (native_replaces);
				global::System.GC.KeepAlive (desc);
				global::System.GC.KeepAlive (replaces);
			}
		}

		static Delegate cb_commitPackImpl_Ljava_util_Collection_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetCommitPackImpl_Ljava_util_Collection_Ljava_util_Collection_Handler ()
		{
			if (cb_commitPackImpl_Ljava_util_Collection_Ljava_util_Collection_ == null)
				cb_commitPackImpl_Ljava_util_Collection_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CommitPackImpl_Ljava_util_Collection_Ljava_util_Collection_);
			return cb_commitPackImpl_Ljava_util_Collection_Ljava_util_Collection_;
		}

		static void n_CommitPackImpl_Ljava_util_Collection_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_desc, IntPtr native_replaces)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desc = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.FromJniHandle (native_desc, JniHandleOwnership.DoNotTransfer);
			var replaces = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.FromJniHandle (native_replaces, JniHandleOwnership.DoNotTransfer);
			__this.CommitPackImpl (desc, replaces);
		}
#pragma warning restore 0169

		/// <param name="desc">description of the new packs.</param>
		/// <param name="replaces">if not null, list of packs to remove.</param>
		/// <summary>Implementation of pack commit.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='commitPackImpl' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.internal.storage.dfs.DfsPackDescription&gt;'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.internal.storage.dfs.DfsPackDescription&gt;']]"
		[Register ("commitPackImpl", "(Ljava/util/Collection;Ljava/util/Collection;)V", "GetCommitPackImpl_Ljava_util_Collection_Ljava_util_Collection_Handler")]
		protected abstract void CommitPackImpl (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> desc, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> replaces);

		static Delegate cb_getCurrentPacks;
#pragma warning disable 0169
		static Delegate GetGetCurrentPacksHandler ()
		{
			if (cb_getCurrentPacks == null)
				cb_getCurrentPacks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentPacks);
			return cb_getCurrentPacks;
		}

		static IntPtr n_GetCurrentPacks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCurrentPacks ());
		}
#pragma warning restore 0169

		/// <summary>List currently known pack files in the repository, without scanning.</summary>
		/// <returns>list of available packs. The returned array is shared with the
		///         implementation and must not be modified by the caller.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='getCurrentPacks' and count(parameter)=0]"
		[Register ("getCurrentPacks", "()[Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;", "GetGetCurrentPacksHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile[] GetCurrentPacks ()
		{
			const string __id = "getCurrentPacks.()[Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile));
			} finally {
			}
		}

		static Delegate cb_getPacks;
#pragma warning disable 0169
		static Delegate GetGetPacksHandler ()
		{
			if (cb_getPacks == null)
				cb_getPacks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPacks);
			return cb_getPacks;
		}

		static IntPtr n_GetPacks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPacks ());
		}
#pragma warning restore 0169

		/// <summary>Scan and list all available pack files in the repository.</summary>
		/// <returns>list of available packs. The returned array is shared with the
		///         implementation and must not be modified by the caller.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='getPacks' and count(parameter)=0]"
		[Register ("getPacks", "()[Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;", "GetGetPacksHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile[] GetPacks ()
		{
			const string __id = "getPacks.()[Lorg/eclipse/jgit/internal/storage/dfs/DfsPackFile;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile));
			} finally {
			}
		}

		static Delegate cb_listPacks;
#pragma warning disable 0169
		static Delegate GetListPacksHandler ()
		{
			if (cb_listPacks == null)
				cb_listPacks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ListPacks);
			return cb_listPacks;
		}

		static IntPtr n_ListPacks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (__this.ListPacks ());
		}
#pragma warning restore 0169

		/// <summary>List the available pack files.</summary>
		/// <returns>available packs. May be empty if there are no packs.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='listPacks' and count(parameter)=0]"
		[Register ("listPacks", "()Ljava/util/List;", "GetListPacksHandler")]
		protected abstract global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> ListPacks ();

		static Delegate cb_newInserter;
#pragma warning disable 0169
		static Delegate GetNewInserterHandler ()
		{
			if (cb_newInserter == null)
				cb_newInserter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewInserter);
			return cb_newInserter;
		}

		static IntPtr n_NewInserter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewInserter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='newInserter' and count(parameter)=0]"
		[Register ("newInserter", "()Lorg/eclipse/jgit/lib/ObjectInserter;", "GetNewInserterHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectInserter NewInserter ()
		{
			const string __id = "newInserter.()Lorg/eclipse/jgit/lib/ObjectInserter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newPack_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_;
#pragma warning disable 0169
		static Delegate GetNewPack_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_Handler ()
		{
			if (cb_newPack_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_ == null)
				cb_newPack_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewPack_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_);
			return cb_newPack_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_;
		}

		static IntPtr n_NewPack_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewPack (source));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='newPack' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsObjDatabase.PackSource']]"
		[Register ("newPack", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetNewPack_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_Handler")]
		protected abstract global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription NewPack (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource source);

		static Delegate cb_newReader;
#pragma warning disable 0169
		static Delegate GetNewReaderHandler ()
		{
			if (cb_newReader == null)
				cb_newReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewReader);
			return cb_newReader;
		}

		static IntPtr n_NewReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewReader ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='newReader' and count(parameter)=0]"
		[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ()
		{
			const string __id = "newReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_openFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
#pragma warning disable 0169
		static Delegate GetOpenFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler ()
		{
			if (cb_openFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ == null)
				cb_openFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_OpenFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_);
			return cb_openFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
		}

		static IntPtr n_OpenFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_desc, IntPtr native_ext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (native_desc, JniHandleOwnership.DoNotTransfer);
			var ext = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (native_ext, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenFile (desc, ext));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="desc">description of pack related to the data that will be read.
		///            This is an instance previously obtained from
		///            <c>#listPacks()</c>, but not necessarily from the same
		///            DfsObjDatabase instance.</param>
		/// <param name="ext">file extension that will be read i.e "pack" or "idx".</param>
		/// <summary>Open a pack, pack index, or other related file for reading.</summary>
		/// <returns>channel to read the file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='openFile' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsPackDescription'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.PackExt']]"
		[Register ("openFile", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Lorg/eclipse/jgit/internal/storage/dfs/ReadableChannel;", "GetOpenFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler")]
		protected abstract global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel OpenFile (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription desc, global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt ext);

		static Delegate cb_rollbackPack_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetRollbackPack_Ljava_util_Collection_Handler ()
		{
			if (cb_rollbackPack_Ljava_util_Collection_ == null)
				cb_rollbackPack_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RollbackPack_Ljava_util_Collection_);
			return cb_rollbackPack_Ljava_util_Collection_;
		}

		static void n_RollbackPack_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_desc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desc = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.FromJniHandle (native_desc, JniHandleOwnership.DoNotTransfer);
			__this.RollbackPack (desc);
		}
#pragma warning restore 0169

		/// <param name="desc">pack to delete.</param>
		/// <summary>Try to rollback a pack creation.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='rollbackPack' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.internal.storage.dfs.DfsPackDescription&gt;']]"
		[Register ("rollbackPack", "(Ljava/util/Collection;)V", "GetRollbackPack_Ljava_util_Collection_Handler")]
		protected abstract void RollbackPack (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> desc);

		static Delegate cb_writeFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
#pragma warning disable 0169
		static Delegate GetWriteFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler ()
		{
			if (cb_writeFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ == null)
				cb_writeFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_WriteFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_);
			return cb_writeFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_;
		}

		static IntPtr n_WriteFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_desc, IntPtr native_ext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (native_desc, JniHandleOwnership.DoNotTransfer);
			var ext = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (native_ext, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteFile (desc, ext));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="desc">description of pack related to the data that will be written.
		///            This is an instance previously obtained from
		///            <c>#newPack(PackSource)</c>.</param>
		/// <param name="ext">file extension that will be written i.e "pack" or "idx".</param>
		/// <summary>Open a pack, pack index, or other related file for writing.</summary>
		/// <returns>channel to write the file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsPackDescription'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.PackExt']]"
		[Register ("writeFile", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Lorg/eclipse/jgit/internal/storage/dfs/DfsOutputStream;", "GetWriteFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler")]
		protected abstract global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsOutputStream WriteFile (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription desc, global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt ext);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsObjDatabase", DoNotGenerateAcw=true)]
	internal partial class DfsObjDatabaseInvoker : DfsObjDatabase {
		public DfsObjDatabaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsObjDatabase", typeof (DfsObjDatabaseInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		/// <param name="desc">description of the new packs.</param>
		/// <param name="replaces">if not null, list of packs to remove.</param>
		/// <summary>Implementation of pack commit.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='commitPackImpl' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.internal.storage.dfs.DfsPackDescription&gt;'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.internal.storage.dfs.DfsPackDescription&gt;']]"
		[Register ("commitPackImpl", "(Ljava/util/Collection;Ljava/util/Collection;)V", "GetCommitPackImpl_Ljava_util_Collection_Ljava_util_Collection_Handler")]
		protected override unsafe void CommitPackImpl (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> desc, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> replaces)
		{
			const string __id = "commitPackImpl.(Ljava/util/Collection;Ljava/util/Collection;)V";
			IntPtr native_desc = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (desc);
			IntPtr native_replaces = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (replaces);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_desc);
				__args [1] = new JniArgumentValue (native_replaces);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_desc);
				JNIEnv.DeleteLocalRef (native_replaces);
				global::System.GC.KeepAlive (desc);
				global::System.GC.KeepAlive (replaces);
			}
		}

		/// <summary>List the available pack files.</summary>
		/// <returns>available packs. May be empty if there are no packs.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='listPacks' and count(parameter)=0]"
		[Register ("listPacks", "()Ljava/util/List;", "GetListPacksHandler")]
		protected override unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> ListPacks ()
		{
			const string __id = "listPacks.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='newPack' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsObjDatabase.PackSource']]"
		[Register ("newPack", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetNewPack_Lorg_eclipse_jgit_internal_storage_dfs_DfsObjDatabase_PackSource_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription NewPack (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase.PackSource source)
		{
			const string __id = "newPack.(Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase$PackSource;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (source);
			}
		}

		/// <param name="desc">description of pack related to the data that will be read.
		///            This is an instance previously obtained from
		///            <c>#listPacks()</c>, but not necessarily from the same
		///            DfsObjDatabase instance.</param>
		/// <param name="ext">file extension that will be read i.e "pack" or "idx".</param>
		/// <summary>Open a pack, pack index, or other related file for reading.</summary>
		/// <returns>channel to read the file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='openFile' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsPackDescription'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.PackExt']]"
		[Register ("openFile", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Lorg/eclipse/jgit/internal/storage/dfs/ReadableChannel;", "GetOpenFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel OpenFile (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription desc, global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt ext)
		{
			const string __id = "openFile.(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Lorg/eclipse/jgit/internal/storage/dfs/ReadableChannel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((desc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) desc).Handle);
				__args [1] = new JniArgumentValue ((ext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ext).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.IReadableChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (desc);
				global::System.GC.KeepAlive (ext);
			}
		}

		/// <param name="desc">pack to delete.</param>
		/// <summary>Try to rollback a pack creation.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='rollbackPack' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.internal.storage.dfs.DfsPackDescription&gt;']]"
		[Register ("rollbackPack", "(Ljava/util/Collection;)V", "GetRollbackPack_Ljava_util_Collection_Handler")]
		protected override unsafe void RollbackPack (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> desc)
		{
			const string __id = "rollbackPack.(Ljava/util/Collection;)V";
			IntPtr native_desc = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription>.ToLocalJniHandle (desc);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_desc);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_desc);
				global::System.GC.KeepAlive (desc);
			}
		}

		/// <param name="desc">description of pack related to the data that will be written.
		///            This is an instance previously obtained from
		///            <c>#newPack(PackSource)</c>.</param>
		/// <param name="ext">file extension that will be written i.e "pack" or "idx".</param>
		/// <summary>Open a pack, pack index, or other related file for writing.</summary>
		/// <returns>channel to write the file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsObjDatabase']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsPackDescription'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.PackExt']]"
		[Register ("writeFile", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Lorg/eclipse/jgit/internal/storage/dfs/DfsOutputStream;", "GetWriteFile_Lorg_eclipse_jgit_internal_storage_dfs_DfsPackDescription_Lorg_eclipse_jgit_internal_storage_pack_PackExt_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsOutputStream WriteFile (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription desc, global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt ext)
		{
			const string __id = "writeFile.(Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;Lorg/eclipse/jgit/internal/storage/pack/PackExt;)Lorg/eclipse/jgit/internal/storage/dfs/DfsOutputStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((desc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) desc).Handle);
				__args [1] = new JniArgumentValue ((ext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ext).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsOutputStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (desc);
				global::System.GC.KeepAlive (ext);
			}
		}

	}
}
