using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsRefDatabase", DoNotGenerateAcw=true)]
	public abstract partial class DfsRefDatabase : global::Org.Eclipse.Jgit.Lib.RefDatabase {
		/// <summary>Collection of references managed by this database.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase.RefCache']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsRefDatabase$RefCache", DoNotGenerateAcw=true)]
		public partial class RefCache : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsRefDatabase$RefCache", typeof (RefCache));

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

			protected RefCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="ids">references that carry an ObjectId, and all of <c>sym</c>.</param>
			/// <param name="sym">references that are symbolic references to others.</param>
			/// <summary>Initialize a new reference cache.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase.RefCache']/constructor[@name='DfsRefDatabase.RefCache' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.util.RefList&lt;org.eclipse.jgit.lib.Ref&gt;'] and parameter[2][@type='org.eclipse.jgit.util.RefList&lt;org.eclipse.jgit.lib.Ref&gt;']]"
			[Register (".ctor", "(Lorg/eclipse/jgit/util/RefList;Lorg/eclipse/jgit/util/RefList;)V", "")]
			public unsafe RefCache (global::Org.Eclipse.Jgit.Util.RefList ids, global::Org.Eclipse.Jgit.Util.RefList sym) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/eclipse/jgit/util/RefList;Lorg/eclipse/jgit/util/RefList;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((ids == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ids).Handle);
					__args [1] = new JniArgumentValue ((sym == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sym).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (ids);
					global::System.GC.KeepAlive (sym);
				}
			}

			static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGet_Ljava_lang_String_Handler ()
			{
				if (cb_get_Ljava_lang_String_ == null)
					cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Ljava_lang_String_);
				return cb_get_Ljava_lang_String_;
			}

			static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (name));
				return __ret;
			}
#pragma warning restore 0169

			/// <param name="name">full name of the reference.</param>
			/// <summary>Find a reference by name.</summary>
			/// <returns>the reference, if it exists, otherwise null.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase.RefCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("get", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "GetGet_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Lib.IRef Get (string name)
			{
				const string __id = "get.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_put_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
			static Delegate GetPut_Lorg_eclipse_jgit_lib_Ref_Handler ()
			{
				if (cb_put_Lorg_eclipse_jgit_lib_Ref_ == null)
					cb_put_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Put_Lorg_eclipse_jgit_lib_Ref_);
				return cb_put_Lorg_eclipse_jgit_lib_Ref_;
			}

			static IntPtr n_Put_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @ref = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native__ref, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (@ref));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase.RefCache']/method[@name='put' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
			[Register ("put", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase$RefCache;", "GetPut_Lorg_eclipse_jgit_lib_Ref_Handler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache Put (global::Org.Eclipse.Jgit.Lib.IRef @ref)
			{
				const string __id = "put.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase$RefCache;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (@ref);
				}
			}

			static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRemove_Ljava_lang_String_Handler ()
			{
				if (cb_remove_Ljava_lang_String_ == null)
					cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Remove_Ljava_lang_String_);
				return cb_remove_Ljava_lang_String_;
			}

			static IntPtr n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (refName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase.RefCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("remove", "(Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase$RefCache;", "GetRemove_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache Remove (string refName)
			{
				const string __id = "remove.(Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase$RefCache;";
				IntPtr native_refName = JNIEnv.NewString ((string)refName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_refName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_refName);
				}
			}

			static Delegate cb_size;
#pragma warning disable 0169
			static Delegate GetSizeHandler ()
			{
				if (cb_size == null)
					cb_size = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Size);
				return cb_size;
			}

			static int n_Size (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Size ();
			}
#pragma warning restore 0169

			/// <returns>number of references in this cache.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase.RefCache']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()I", "GetSizeHandler")]
			public virtual unsafe int Size ()
			{
				const string __id = "size.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsRefDatabase", typeof (DfsRefDatabase));

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

		protected DfsRefDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repository">the repository this database instance manages references for.</param>
		/// <summary>Initialize the reference database for a repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/constructor[@name='DfsRefDatabase' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsRepository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;)V", "")]
		protected unsafe DfsRefDatabase (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository repository) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAdditionalRefs;
#pragma warning disable 0169
		static Delegate GetGetAdditionalRefsHandler ()
		{
			if (cb_getAdditionalRefs == null)
				cb_getAdditionalRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdditionalRefs);
			return cb_getAdditionalRefs;
		}

		static IntPtr n_GetAdditionalRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.AdditionalRefs);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> AdditionalRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='getAdditionalRefs' and count(parameter)=0]"
			[Register ("getAdditionalRefs", "()Ljava/util/List;", "GetGetAdditionalRefsHandler")]
			get {
				const string __id = "getAdditionalRefs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		/// <returns>the repository the database holds the references of.</returns>
		protected virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='getRepository' and count(parameter)=0]"
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

		static Delegate cb_cachePeeledState_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetCachePeeledState_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_cachePeeledState_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_cachePeeledState_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CachePeeledState_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_);
			return cb_cachePeeledState_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_;
		}

		static void n_CachePeeledState_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldLeaf, IntPtr native_newLeaf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oldLeaf = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_oldLeaf, JniHandleOwnership.DoNotTransfer);
			var newLeaf = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_newLeaf, JniHandleOwnership.DoNotTransfer);
			__this.CachePeeledState (oldLeaf, newLeaf);
		}
#pragma warning restore 0169

		/// <param name="oldLeaf">the old reference.</param>
		/// <param name="newLeaf">the new reference, with peel information.</param>
		/// <summary>Update the cached peeled state of a reference</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='cachePeeledState' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Ref'] and parameter[2][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("cachePeeledState", "(Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/Ref;)V", "GetCachePeeledState_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_Handler")]
		protected virtual unsafe void CachePeeledState (global::Org.Eclipse.Jgit.Lib.IRef oldLeaf, global::Org.Eclipse.Jgit.Lib.IRef newLeaf)
		{
			const string __id = "cachePeeledState.(Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/Ref;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((oldLeaf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldLeaf).Handle);
				__args [1] = new JniArgumentValue ((newLeaf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newLeaf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (oldLeaf);
				global::System.GC.KeepAlive (newLeaf);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_compareAndPut_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetCompareAndPut_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_compareAndPut_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_compareAndPut_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_CompareAndPut_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_);
			return cb_compareAndPut_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_;
		}

		static bool n_CompareAndPut_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldRef, IntPtr native_newRef)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oldRef = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_oldRef, JniHandleOwnership.DoNotTransfer);
			var newRef = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_newRef, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CompareAndPut (oldRef, newRef);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="oldRef">old value to compare to. If the reference is expected to not
		///            exist the old value has a storage of
		///            <c>org.eclipse.jgit.lib.Ref.Storage#NEW</c> and an ObjectId
		///            value of <c>null</c>.</param>
		/// <param name="newRef">new reference to store.</param>
		/// <summary>Compare a reference, and put if it matches.</summary>
		/// <returns>true if the put was successful; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='compareAndPut' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Ref'] and parameter[2][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("compareAndPut", "(Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/Ref;)Z", "GetCompareAndPut_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_Handler")]
		protected abstract bool CompareAndPut (global::Org.Eclipse.Jgit.Lib.IRef oldRef, global::Org.Eclipse.Jgit.Lib.IRef newRef);

		static Delegate cb_compareAndRemove_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetCompareAndRemove_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_compareAndRemove_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_compareAndRemove_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CompareAndRemove_Lorg_eclipse_jgit_lib_Ref_);
			return cb_compareAndRemove_Lorg_eclipse_jgit_lib_Ref_;
		}

		static bool n_CompareAndRemove_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldRef)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oldRef = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_oldRef, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CompareAndRemove (oldRef);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="oldRef">the old reference information that was previously read.</param>
		/// <summary>Compare a reference, and delete if it matches.</summary>
		/// <returns>true if the remove was successful; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='compareAndRemove' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("compareAndRemove", "(Lorg/eclipse/jgit/lib/Ref;)Z", "GetCompareAndRemove_Lorg_eclipse_jgit_lib_Ref_Handler")]
		protected abstract bool CompareAndRemove (global::Org.Eclipse.Jgit.Lib.IRef oldRef);

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Create);
			return cb_create;
		}

		static void n_Create (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "GetCreateHandler")]
		public override unsafe void Create ()
		{
			const string __id = "create.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRef_Ljava_lang_String_Handler ()
		{
			if (cb_getRef_Ljava_lang_String_ == null)
				cb_getRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRef_Ljava_lang_String_);
			return cb_getRef_Ljava_lang_String_;
		}

		static IntPtr n_GetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_needle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var needle = JNIEnv.GetString (native_needle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRef (needle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='getRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "GetGetRef_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IRef GetRef (string needle)
		{
			const string __id = "getRef.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;";
			IntPtr native_needle = JNIEnv.NewString ((string)needle);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_needle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_needle);
			}
		}

		static Delegate cb_getRefs_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRefs_Ljava_lang_String_Handler ()
		{
			if (cb_getRefs_Ljava_lang_String_ == null)
				cb_getRefs_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRefs_Ljava_lang_String_);
			return cb_getRefs_Ljava_lang_String_;
		}

		static IntPtr n_GetRefs_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.GetRefs (prefix));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='getRefs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRefs", "(Ljava/lang/String;)Ljava/util/Map;", "GetGetRefs_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> GetRefs (string prefix)
		{
			const string __id = "getRefs.(Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		static Delegate cb_isNameConflicting_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsNameConflicting_Ljava_lang_String_Handler ()
		{
			if (cb_isNameConflicting_Ljava_lang_String_ == null)
				cb_isNameConflicting_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsNameConflicting_Ljava_lang_String_);
			return cb_isNameConflicting_Ljava_lang_String_;
		}

		static bool n_IsNameConflicting_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsNameConflicting (refName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='isNameConflicting' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNameConflicting", "(Ljava/lang/String;)Z", "GetIsNameConflicting_Ljava_lang_String_Handler")]
		public override unsafe bool IsNameConflicting (string refName)
		{
			const string __id = "isNameConflicting.(Ljava/lang/String;)Z";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
			}
		}

		static Delegate cb_newRename_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewRename_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_newRename_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_newRename_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_NewRename_Ljava_lang_String_Ljava_lang_String_);
			return cb_newRename_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_NewRename_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fromName, IntPtr native_toName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fromName = JNIEnv.GetString (native_fromName, JniHandleOwnership.DoNotTransfer);
			var toName = JNIEnv.GetString (native_toName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewRename (fromName, toName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='newRename' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("newRename", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefRename;", "GetNewRename_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.RefRename NewRename (string fromName, string toName)
		{
			const string __id = "newRename.(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefRename;";
			IntPtr native_fromName = JNIEnv.NewString ((string)fromName);
			IntPtr native_toName = JNIEnv.NewString ((string)toName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fromName);
				__args [1] = new JniArgumentValue (native_toName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fromName);
				JNIEnv.DeleteLocalRef (native_toName);
			}
		}

		static Delegate cb_newUpdate_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetNewUpdate_Ljava_lang_String_ZHandler ()
		{
			if (cb_newUpdate_Ljava_lang_String_Z == null)
				cb_newUpdate_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_NewUpdate_Ljava_lang_String_Z);
			return cb_newUpdate_Ljava_lang_String_Z;
		}

		static IntPtr n_NewUpdate_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_refName, bool detach)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewUpdate (refName, detach));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='newUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("newUpdate", "(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/RefUpdate;", "GetNewUpdate_Ljava_lang_String_ZHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate NewUpdate (string refName, bool detach)
		{
			const string __id = "newUpdate.(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/RefUpdate;";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_refName);
				__args [1] = new JniArgumentValue (detach);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
			}
		}

		static Delegate cb_peel_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetPeel_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_peel_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_peel_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Peel_Lorg_eclipse_jgit_lib_Ref_);
			return cb_peel_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_Peel_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Peel (@ref));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='peel' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("peel", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;", "GetPeel_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IRef Peel (global::Org.Eclipse.Jgit.Lib.IRef @ref)
		{
			const string __id = "peel.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@ref);
			}
		}

		static Delegate cb_scanAllRefs;
#pragma warning disable 0169
		static Delegate GetScanAllRefsHandler ()
		{
			if (cb_scanAllRefs == null)
				cb_scanAllRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ScanAllRefs);
			return cb_scanAllRefs;
		}

		static IntPtr n_ScanAllRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScanAllRefs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='scanAllRefs' and count(parameter)=0]"
		[Register ("scanAllRefs", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase$RefCache;", "GetScanAllRefsHandler")]
		protected abstract global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache ScanAllRefs ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsRefDatabase", DoNotGenerateAcw=true)]
	internal partial class DfsRefDatabaseInvoker : DfsRefDatabase {
		public DfsRefDatabaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsRefDatabase", typeof (DfsRefDatabaseInvoker));

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

		/// <param name="oldRef">old value to compare to. If the reference is expected to not
		///            exist the old value has a storage of
		///            <c>org.eclipse.jgit.lib.Ref.Storage#NEW</c> and an ObjectId
		///            value of <c>null</c>.</param>
		/// <param name="newRef">new reference to store.</param>
		/// <summary>Compare a reference, and put if it matches.</summary>
		/// <returns>true if the put was successful; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='compareAndPut' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Ref'] and parameter[2][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("compareAndPut", "(Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/Ref;)Z", "GetCompareAndPut_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_Handler")]
		protected override unsafe bool CompareAndPut (global::Org.Eclipse.Jgit.Lib.IRef oldRef, global::Org.Eclipse.Jgit.Lib.IRef newRef)
		{
			const string __id = "compareAndPut.(Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/Ref;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((oldRef == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldRef).Handle);
				__args [1] = new JniArgumentValue ((newRef == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newRef).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (oldRef);
				global::System.GC.KeepAlive (newRef);
			}
		}

		/// <param name="oldRef">the old reference information that was previously read.</param>
		/// <summary>Compare a reference, and delete if it matches.</summary>
		/// <returns>true if the remove was successful; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='compareAndRemove' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("compareAndRemove", "(Lorg/eclipse/jgit/lib/Ref;)Z", "GetCompareAndRemove_Lorg_eclipse_jgit_lib_Ref_Handler")]
		protected override unsafe bool CompareAndRemove (global::Org.Eclipse.Jgit.Lib.IRef oldRef)
		{
			const string __id = "compareAndRemove.(Lorg/eclipse/jgit/lib/Ref;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((oldRef == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldRef).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (oldRef);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRefDatabase']/method[@name='scanAllRefs' and count(parameter)=0]"
		[Register ("scanAllRefs", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase$RefCache;", "GetScanAllRefsHandler")]
		protected override unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache ScanAllRefs ()
		{
			const string __id = "scanAllRefs.()Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase$RefCache;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase.RefCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
