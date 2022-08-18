using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Caches slices of a <c>DfsPackFile</c> in memory for faster read access.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsBlockCache", DoNotGenerateAcw=true)]
	public sealed partial class DfsBlockCache : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsBlockCache", typeof (DfsBlockCache));

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

		internal DfsBlockCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <returns>total number of bytes in the cache.</returns>
		public unsafe long CurrentSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='getCurrentSize' and count(parameter)=0]"
			[Register ("getCurrentSize", "()J", "")]
			get {
				const string __id = "getCurrentSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>number of evictions performed due to cache being full.</returns>
		public unsafe long Evictions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='getEvictions' and count(parameter)=0]"
			[Register ("getEvictions", "()J", "")]
			get {
				const string __id = "getEvictions.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>0..100, defining how full the cache is.</returns>
		public unsafe long FillPercentage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='getFillPercentage' and count(parameter)=0]"
			[Register ("getFillPercentage", "()J", "")]
			get {
				const string __id = "getFillPercentage.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>number of requests for items in the cache.</returns>
		public unsafe long HitCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='getHitCount' and count(parameter)=0]"
			[Register ("getHitCount", "()J", "")]
			get {
				const string __id = "getHitCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>0..100, defining number of cache hits.</returns>
		public unsafe long HitRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='getHitRatio' and count(parameter)=0]"
			[Register ("getHitRatio", "()J", "")]
			get {
				const string __id = "getHitRatio.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>the currently active DfsBlockCache.</returns>
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCache Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCache;", "")]
			get {
				const string __id = "getInstance.()Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCache;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>number of requests for items not in the cache.</returns>
		public unsafe long MissCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='getMissCount' and count(parameter)=0]"
			[Register ("getMissCount", "()J", "")]
			get {
				const string __id = "getMissCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Get the pack files stored in this cache.</summary>
		/// <returns>a collection of pack files, some of which may not actually be
		///             present; the caller should check the pack's cached size.</returns>
		public unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile> PackFiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='getPackFiles' and count(parameter)=0]"
			[Register ("getPackFiles", "()Ljava/util/Collection;", "")]
			get {
				const string __id = "getPackFiles.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackFile>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>total number of requests (hit + miss).</returns>
		public unsafe long TotalRequestCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='getTotalRequestCount' and count(parameter)=0]"
			[Register ("getTotalRequestCount", "()J", "")]
			get {
				const string __id = "getTotalRequestCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="cfg">the new window cache configuration.</param>
		/// <summary>Modify the configuration of the window cache.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCache']/method[@name='reconfigure' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsBlockCacheConfig']]"
		[Register ("reconfigure", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig;)V", "")]
		public static unsafe void Reconfigure (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig cfg)
		{
			const string __id = "reconfigure.(Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (cfg);
			}
		}

	}
}
