using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>A garbage collector for git <c>FileRepository</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/GC", DoNotGenerateAcw=true)]
	public partial class GC : global::Java.Lang.Object {
		/// <summary>A class holding statistical data for a FileRepository regarding how many
		/// objects are stored as loose or packed objects</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC.RepoStatistics']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/GC$RepoStatistics", DoNotGenerateAcw=true)]
		public partial class RepoStatistics : global::Java.Lang.Object {

			/// <summary>The number of objects stored as loose objects.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC.RepoStatistics']/field[@name='numberOfLooseObjects']"
			[Register ("numberOfLooseObjects")]
			public long NumberOfLooseObjects {
				get {
					const string __id = "numberOfLooseObjects.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "numberOfLooseObjects.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			/// <summary>The number of loose refs.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC.RepoStatistics']/field[@name='numberOfLooseRefs']"
			[Register ("numberOfLooseRefs")]
			public long NumberOfLooseRefs {
				get {
					const string __id = "numberOfLooseRefs.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "numberOfLooseRefs.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			/// <summary>The number of objects stored in pack files.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC.RepoStatistics']/field[@name='numberOfPackedObjects']"
			[Register ("numberOfPackedObjects")]
			public long NumberOfPackedObjects {
				get {
					const string __id = "numberOfPackedObjects.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "numberOfPackedObjects.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			/// <summary>The number of refs stored in pack files.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC.RepoStatistics']/field[@name='numberOfPackedRefs']"
			[Register ("numberOfPackedRefs")]
			public long NumberOfPackedRefs {
				get {
					const string __id = "numberOfPackedRefs.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "numberOfPackedRefs.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			/// <summary>The number of pack files</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC.RepoStatistics']/field[@name='numberOfPackFiles']"
			[Register ("numberOfPackFiles")]
			public long NumberOfPackFiles {
				get {
					const string __id = "numberOfPackFiles.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "numberOfPackFiles.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			/// <summary>The sum of the sizes of all files used to persist loose objects.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC.RepoStatistics']/field[@name='sizeOfLooseObjects']"
			[Register ("sizeOfLooseObjects")]
			public long SizeOfLooseObjects {
				get {
					const string __id = "sizeOfLooseObjects.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sizeOfLooseObjects.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			/// <summary>The sum of the sizes of all pack files.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC.RepoStatistics']/field[@name='sizeOfPackedObjects']"
			[Register ("sizeOfPackedObjects")]
			public long SizeOfPackedObjects {
				get {
					const string __id = "sizeOfPackedObjects.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sizeOfPackedObjects.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/GC$RepoStatistics", typeof (RepoStatistics));

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

			protected RepoStatistics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC.RepoStatistics']/constructor[@name='GC.RepoStatistics' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.file.GC']]"
			[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/file/GC;)V", "")]
			public unsafe RepoStatistics (global::Org.Eclipse.Jgit.Internal.Storage.File.GC __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/GC", typeof (GC));

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

		protected GC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">the repo to work on</param>
		/// <summary>Creates a new garbage collector with default values.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/constructor[@name='GC' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.file.FileRepository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/file/FileRepository;)V", "")]
		public unsafe GC (global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/file/FileRepository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_getStatistics;
#pragma warning disable 0169
		static Delegate GetGetStatisticsHandler ()
		{
			if (cb_getStatistics == null)
				cb_getStatistics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatistics);
			return cb_getStatistics;
		}

		static IntPtr n_GetStatistics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Statistics);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.GC.RepoStatistics Statistics {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='getStatistics' and count(parameter)=0]"
			[Register ("getStatistics", "()Lorg/eclipse/jgit/internal/storage/file/GC$RepoStatistics;", "GetGetStatisticsHandler")]
			get {
				const string __id = "getStatistics.()Lorg/eclipse/jgit/internal/storage/file/GC$RepoStatistics;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC.RepoStatistics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_gc;
#pragma warning disable 0169
		static Delegate GetGcHandler ()
		{
			if (cb_gc == null)
				cb_gc = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Gc);
			return cb_gc;
		}

		static IntPtr n_Gc (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile>.ToLocalJniHandle (__this.Gc ());
		}
#pragma warning restore 0169

		/// <summary>Runs a garbage collector on a <c>FileRepository</c>.</summary>
		/// <returns>the collection of <c>PackFile</c>'s which are newly created</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='gc' and count(parameter)=0]"
		[Register ("gc", "()Ljava/util/Collection;", "GetGcHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> Gc ()
		{
			const string __id = "gc.()Ljava/util/Collection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_packRefs;
#pragma warning disable 0169
		static Delegate GetPackRefsHandler ()
		{
			if (cb_packRefs == null)
				cb_packRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PackRefs);
			return cb_packRefs;
		}

		static void n_PackRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PackRefs ();
		}
#pragma warning restore 0169

		/// <summary>Packs all non-symbolic, loose refs into packed-refs.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='packRefs' and count(parameter)=0]"
		[Register ("packRefs", "()V", "GetPackRefsHandler")]
		public virtual unsafe void PackRefs ()
		{
			const string __id = "packRefs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_prune_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetPrune_Ljava_util_Set_Handler ()
		{
			if (cb_prune_Ljava_util_Set_ == null)
				cb_prune_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Prune_Ljava_util_Set_);
			return cb_prune_Ljava_util_Set_;
		}

		static void n_Prune_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectsToKeep)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectsToKeep = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_objectsToKeep, JniHandleOwnership.DoNotTransfer);
			__this.Prune (objectsToKeep);
		}
#pragma warning restore 0169

		/// <param name="objectsToKeep">a set of objects which should explicitly not be pruned</param>
		/// <summary>Like "git prune" this method tries to prune all loose objects which are
		/// unreferenced.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='prune' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("prune", "(Ljava/util/Set;)V", "GetPrune_Ljava_util_Set_Handler")]
		public virtual unsafe void Prune (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> objectsToKeep)
		{
			const string __id = "prune.(Ljava/util/Set;)V";
			IntPtr native_objectsToKeep = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (objectsToKeep);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_objectsToKeep);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_objectsToKeep);
				global::System.GC.KeepAlive (objectsToKeep);
			}
		}

		static Delegate cb_prunePacked;
#pragma warning disable 0169
		static Delegate GetPrunePackedHandler ()
		{
			if (cb_prunePacked == null)
				cb_prunePacked = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PrunePacked);
			return cb_prunePacked;
		}

		static void n_PrunePacked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrunePacked ();
		}
#pragma warning restore 0169

		/// <summary>Like "git prune-packed" this method tries to prune all loose objects
		/// which can be found in packs.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='prunePacked' and count(parameter)=0]"
		[Register ("prunePacked", "()V", "GetPrunePackedHandler")]
		public virtual unsafe void PrunePacked ()
		{
			const string __id = "prunePacked.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_repack;
#pragma warning disable 0169
		static Delegate GetRepackHandler ()
		{
			if (cb_repack == null)
				cb_repack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Repack);
			return cb_repack;
		}

		static IntPtr n_Repack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile>.ToLocalJniHandle (__this.Repack ());
		}
#pragma warning restore 0169

		/// <summary>Packs all objects which reachable from any of the heads into one pack
		/// file.</summary>
		/// <returns>a collection of the newly created pack files</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='repack' and count(parameter)=0]"
		[Register ("repack", "()Ljava/util/Collection;", "GetRepackHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> Repack ()
		{
			const string __id = "repack.()Ljava/util/Collection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setExpire_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetExpire_Ljava_util_Date_Handler ()
		{
			if (cb_setExpire_Ljava_util_Date_ == null)
				cb_setExpire_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExpire_Ljava_util_Date_);
			return cb_setExpire_Ljava_util_Date_;
		}

		static void n_SetExpire_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expire)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var expire = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_expire, JniHandleOwnership.DoNotTransfer);
			__this.SetExpire (expire);
		}
#pragma warning restore 0169

		/// <param name="expire">instant in time which defines object expiration
		///            objects with modification time before this instant are expired
		///            objects with modification time newer or equal to this instant
		///            are not expired</param>
		/// <summary>During gc() or prune() each unreferenced, loose object which has been
		/// created or modified after or at &lt;code&gt;expire&lt;/code&gt; will not be pruned.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='setExpire' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("setExpire", "(Ljava/util/Date;)V", "GetSetExpire_Ljava_util_Date_Handler")]
		public virtual unsafe void SetExpire (global::Java.Util.Date expire)
		{
			const string __id = "setExpire.(Ljava/util/Date;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expire == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expire).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (expire);
			}
		}

		static Delegate cb_setExpireAgeMillis_J;
#pragma warning disable 0169
		static Delegate GetSetExpireAgeMillis_JHandler ()
		{
			if (cb_setExpireAgeMillis_J == null)
				cb_setExpireAgeMillis_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetExpireAgeMillis_J);
			return cb_setExpireAgeMillis_J;
		}

		static void n_SetExpireAgeMillis_J (IntPtr jnienv, IntPtr native__this, long expireAgeMillis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpireAgeMillis (expireAgeMillis);
		}
#pragma warning restore 0169

		/// <param name="expireAgeMillis">minimal age of objects to be pruned in milliseconds.</param>
		/// <summary>During gc() or prune() each unreferenced, loose object which has been
		/// created or modified in the last &lt;code&gt;expireAgeMillis&lt;/code&gt; milliseconds
		/// will not be pruned.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='setExpireAgeMillis' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setExpireAgeMillis", "(J)V", "GetSetExpireAgeMillis_JHandler")]
		public virtual unsafe void SetExpireAgeMillis (long expireAgeMillis)
		{
			const string __id = "setExpireAgeMillis.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expireAgeMillis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
#pragma warning disable 0169
		static Delegate GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler ()
		{
			if (cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ == null)
				cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_);
			return cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
		}

		static void n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pconfig)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pconfig = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (native_pconfig, JniHandleOwnership.DoNotTransfer);
			__this.SetPackConfig (pconfig);
		}
#pragma warning restore 0169

		/// <param name="pconfig">the <c>PackConfig</c> used when writing packs</param>
		/// <summary>Set the PackConfig used when (re-)writing packfiles.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='setPackConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.storage.pack.PackConfig']]"
		[Register ("setPackConfig", "(Lorg/eclipse/jgit/storage/pack/PackConfig;)V", "GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler")]
		public virtual unsafe void SetPackConfig (global::Org.Eclipse.Jgit.Storage.Pack.PackConfig pconfig)
		{
			const string __id = "setPackConfig.(Lorg/eclipse/jgit/storage/pack/PackConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pconfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pconfig).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pconfig);
			}
		}

		static Delegate cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pm = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_pm, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (pm));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pm">pm</param>
		/// <summary>Set the progress monitor used for garbage collection methods.</summary>
		/// <returns>this</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='GC']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/internal/storage/file/GC;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.GC SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/internal/storage/file/GC;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.GC> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (pm);
			}
		}

	}
}
