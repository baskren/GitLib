using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Dircache {

	/// <summary>Updates a <c>DirCache</c> by adding individual <c>DirCacheEntry</c>s.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuilder']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheBuilder", DoNotGenerateAcw=true)]
	public partial class DirCacheBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheBuilder", typeof (DirCacheBuilder));

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

		protected DirCacheBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="dc">the cache this builder will eventually update.</param>
		/// <param name="ecnt">estimated number of entries the builder will have upon
		///            completion. This sizes the initial entry table.</param>
		/// <summary>Construct a new builder.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuilder']/constructor[@name='DirCacheBuilder' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.dircache.DirCache'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/dircache/DirCache;I)V", "")]
		protected unsafe DirCacheBuilder (global::Org.Eclipse.Jgit.Dircache.DirCache dc, int ecnt) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/dircache/DirCache;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dc).Handle);
				__args [1] = new JniArgumentValue (ecnt);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dc);
			}
		}

		static Delegate cb_getDirCache;
#pragma warning disable 0169
		static Delegate GetGetDirCacheHandler ()
		{
			if (cb_getDirCache == null)
				cb_getDirCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDirCache);
			return cb_getDirCache;
		}

		static IntPtr n_GetDirCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DirCache);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCache DirCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuilder']/method[@name='getDirCache' and count(parameter)=0]"
			[Register ("getDirCache", "()Lorg/eclipse/jgit/dircache/DirCache;", "GetGetDirCacheHandler")]
			get {
				const string __id = "getDirCache.()Lorg/eclipse/jgit/dircache/DirCache;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_dircache_DirCacheEntry_ == null)
				cb_add_Lorg_eclipse_jgit_dircache_DirCacheEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Lorg_eclipse_jgit_dircache_DirCacheEntry_);
			return cb_add_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
		}

		static void n_Add_Lorg_eclipse_jgit_dircache_DirCacheEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newEntry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newEntry = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (native_newEntry, JniHandleOwnership.DoNotTransfer);
			__this.Add (newEntry);
		}
#pragma warning restore 0169

		/// <param name="newEntry">the new entry to add.</param>
		/// <summary>Append one entry into the resulting entry list.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuilder']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
		[Register ("add", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "GetAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler")]
		public virtual unsafe void Add (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry newEntry)
		{
			const string __id = "add.(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newEntry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newEntry).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (newEntry);
			}
		}

		static Delegate cb_addTree_arrayBILorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAddTree_arrayBILorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_addTree_arrayBILorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_addTree_arrayBILorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_V) n_AddTree_arrayBILorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_addTree_arrayBILorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_AddTree_arrayBILorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pathPrefix, int stage, IntPtr native_reader, IntPtr native_tree)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pathPrefix = (byte[]) JNIEnv.GetArray (native_pathPrefix, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			var tree = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_tree, JniHandleOwnership.DoNotTransfer);
			__this.AddTree (pathPrefix, stage, reader, tree);
			if (pathPrefix != null)
				JNIEnv.CopyArray (pathPrefix, native_pathPrefix);
		}
#pragma warning restore 0169

		/// <param name="pathPrefix">UTF-8 encoded prefix to mount the tree's entries at. If the
		///            path does not end with '/' one will be automatically inserted
		///            as necessary.</param>
		/// <param name="stage">stage of the entries when adding them.</param>
		/// <param name="reader">reader the tree(s) will be read from during recursive
		///            traversal. This must be the same repository that the resulting
		///            DirCache would be written out to (or used in) otherwise the
		///            caller is simply asking for deferred MissingObjectExceptions.
		///            Caller is responsible for releasing this reader when done.</param>
		/// <param name="tree">the tree to recursively add. This tree's contents will appear
		///            under &lt;code&gt;pathPrefix&lt;/code&gt;. The ObjectId must be that of a
		///            tree; the caller is responsible for dereferencing a tag or
		///            commit (if necessary).</param>
		/// <summary>Recursively add an entire tree into this builder.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuilder']/method[@name='addTree' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[4][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("addTree", "([BILorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetAddTree_arrayBILorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void AddTree (byte[] pathPrefix, int stage, global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.AnyObjectId tree)
		{
			const string __id = "addTree.([BILorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			IntPtr native_pathPrefix = JNIEnv.NewArray (pathPrefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_pathPrefix);
				__args [1] = new JniArgumentValue (stage);
				__args [2] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [3] = new JniArgumentValue ((tree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tree).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (pathPrefix != null) {
					JNIEnv.CopyArray (native_pathPrefix, pathPrefix);
					JNIEnv.DeleteLocalRef (native_pathPrefix);
				}
				global::System.GC.KeepAlive (pathPrefix);
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (tree);
			}
		}

		static Delegate cb_commit;
#pragma warning disable 0169
		static Delegate GetCommitHandler ()
		{
			if (cb_commit == null)
				cb_commit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Commit);
			return cb_commit;
		}

		static bool n_Commit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Commit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuilder']/method[@name='commit' and count(parameter)=0]"
		[Register ("commit", "()Z", "GetCommitHandler")]
		public virtual unsafe bool Commit ()
		{
			const string __id = "commit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuilder']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_keep_II;
#pragma warning disable 0169
		static Delegate GetKeep_IIHandler ()
		{
			if (cb_keep_II == null)
				cb_keep_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_Keep_II);
			return cb_keep_II;
		}

		static void n_Keep_II (IntPtr jnienv, IntPtr native__this, int pos, int cnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Keep (pos, cnt);
		}
#pragma warning restore 0169

		/// <param name="pos">first entry to copy from the destination cache.</param>
		/// <param name="cnt">number of entries to copy.</param>
		/// <summary>Add a range of existing entries from the destination cache.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuilder']/method[@name='keep' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("keep", "(II)V", "GetKeep_IIHandler")]
		public virtual unsafe void Keep (int pos, int cnt)
		{
			const string __id = "keep.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (pos);
				__args [1] = new JniArgumentValue (cnt);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
#pragma warning disable 0169
		static Delegate GetFastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler ()
		{
			if (cb_fastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_ == null)
				cb_fastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_);
			return cb_fastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
		}

		static void n_FastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newEntry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newEntry = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (native_newEntry, JniHandleOwnership.DoNotTransfer);
			__this.FastAdd (newEntry);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='BaseDirCacheEditor']/method[@name='fastAdd' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
		[Register ("fastAdd", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "GetFastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler")]
		protected virtual unsafe void FastAdd (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry newEntry)
		{
			const string __id = "fastAdd.(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newEntry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newEntry).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (newEntry);
			}
		}

		static Delegate cb_fastKeep_II;
#pragma warning disable 0169
		static Delegate GetFastKeep_IIHandler ()
		{
			if (cb_fastKeep_II == null)
				cb_fastKeep_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_FastKeep_II);
			return cb_fastKeep_II;
		}

		static void n_FastKeep_II (IntPtr jnienv, IntPtr native__this, int pos, int cnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FastKeep (pos, cnt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='BaseDirCacheEditor']/method[@name='fastKeep' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("fastKeep", "(II)V", "GetFastKeep_IIHandler")]
		protected virtual unsafe void FastKeep (int pos, int cnt)
		{
			const string __id = "fastKeep.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (pos);
				__args [1] = new JniArgumentValue (cnt);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_replace;
#pragma warning disable 0169
		static Delegate GetReplaceHandler ()
		{
			if (cb_replace == null)
				cb_replace = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Replace);
			return cb_replace;
		}

		static void n_Replace (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Replace ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='BaseDirCacheEditor']/method[@name='replace' and count(parameter)=0]"
		[Register ("replace", "()V", "GetReplaceHandler")]
		protected virtual unsafe void Replace ()
		{
			const string __id = "replace.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
