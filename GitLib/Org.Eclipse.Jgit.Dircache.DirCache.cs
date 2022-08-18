using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Dircache {

	/// <summary>Support for the Git dircache (aka index file).</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCache", DoNotGenerateAcw=true)]
	public partial class DirCache : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCache", typeof (DirCache));

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

		protected DirCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="indexLocation">location of the index file on disk.</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <summary>Create a new in-core index representation.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/constructor[@name='DirCache' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register (".ctor", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V", "")]
		public unsafe DirCache (global::Java.IO.File indexLocation, global::Org.Eclipse.Jgit.Util.FS fs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((indexLocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexLocation).Handle);
				__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (indexLocation);
				global::System.GC.KeepAlive (fs);
			}
		}

		static Delegate cb_getEntryCount;
#pragma warning disable 0169
		static Delegate GetGetEntryCountHandler ()
		{
			if (cb_getEntryCount == null)
				cb_getEntryCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEntryCount);
			return cb_getEntryCount;
		}

		static int n_GetEntryCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryCount;
		}
#pragma warning restore 0169

		/// <summary>Total number of file entries stored in the index.</summary>
		/// <returns>number of entries available.</returns>
		public virtual unsafe int EntryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='getEntryCount' and count(parameter)=0]"
			[Register ("getEntryCount", "()I", "GetGetEntryCountHandler")]
			get {
				const string __id = "getEntryCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasUnmergedPaths;
#pragma warning disable 0169
		static Delegate GetHasUnmergedPathsHandler ()
		{
			if (cb_hasUnmergedPaths == null)
				cb_hasUnmergedPaths = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasUnmergedPaths);
			return cb_hasUnmergedPaths;
		}

		static bool n_HasUnmergedPaths (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUnmergedPaths;
		}
#pragma warning restore 0169

		/// <summary>Tells whether this index contains unmerged paths.</summary>
		/// <returns>
		///   <c>true</c> if this index contains unmerged paths. Means: at
		///         least one entry is of a stage different from 0. <c>false</c>
		///         will be returned if all entries are of stage 0.</returns>
		public virtual unsafe bool HasUnmergedPaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='hasUnmergedPaths' and count(parameter)=0]"
			[Register ("hasUnmergedPaths", "()Z", "GetHasUnmergedPathsHandler")]
			get {
				const string __id = "hasUnmergedPaths.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isOutdated;
#pragma warning disable 0169
		static Delegate GetIsOutdatedHandler ()
		{
			if (cb_isOutdated == null)
				cb_isOutdated = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOutdated);
			return cb_isOutdated;
		}

		static bool n_IsOutdated (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOutdated;
		}
#pragma warning restore 0169

		/// <returns>true if the memory state differs from the index file</returns>
		public virtual unsafe bool IsOutdated {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='isOutdated' and count(parameter)=0]"
			[Register ("isOutdated", "()Z", "GetIsOutdatedHandler")]
			get {
				const string __id = "isOutdated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_builder;
#pragma warning disable 0169
		static Delegate GetBuilderHandler ()
		{
			if (cb_builder == null)
				cb_builder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Builder);
			return cb_builder;
		}

		static IntPtr n_Builder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Builder ());
		}
#pragma warning restore 0169

		/// <summary>Create a new builder to update this cache.</summary>
		/// <returns>a new builder instance for this cache.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lorg/eclipse/jgit/dircache/DirCacheBuilder;", "GetBuilderHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder Builder ()
		{
			const string __id = "builder.()Lorg/eclipse/jgit/dircache/DirCacheBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		/// <summary>Empty this index, removing all entries.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Commit ();
		}
#pragma warning restore 0169

		/// <summary>Commit this change and release the lock.</summary>
		/// <returns>true if the commit was successful and the file contains the new
		///         data; false if the commit failed and the file remains with the
		///         old data.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='commit' and count(parameter)=0]"
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

		static Delegate cb_editor;
#pragma warning disable 0169
		static Delegate GetEditorHandler ()
		{
			if (cb_editor == null)
				cb_editor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Editor);
			return cb_editor;
		}

		static IntPtr n_Editor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Editor ());
		}
#pragma warning restore 0169

		/// <summary>Create a new editor to recreate this cache.</summary>
		/// <returns>a new builder instance for this cache.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='editor' and count(parameter)=0]"
		[Register ("editor", "()Lorg/eclipse/jgit/dircache/DirCacheEditor;", "GetEditorHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCacheEditor Editor ()
		{
			const string __id = "editor.()Lorg/eclipse/jgit/dircache/DirCacheEditor;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findEntry_arrayBI;
#pragma warning disable 0169
		static Delegate GetFindEntry_arrayBIHandler ()
		{
			if (cb_findEntry_arrayBI == null)
				cb_findEntry_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_FindEntry_arrayBI);
			return cb_findEntry_arrayBI;
		}

		static int n_FindEntry_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p, int pLen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = (byte[]) JNIEnv.GetArray (native_p, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.FindEntry (p, pLen);
			if (p != null)
				JNIEnv.CopyArray (p, native_p);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="p">the byte array starting with the path to search for.</param>
		/// <param name="pLen">the length of the path in bytes</param>
		/// <summary>Locate the position a path's entry is at in the index.</summary>
		/// <returns>if &amp;gt;= 0 then the return value is the position of the entry in
		///         the index; pass to <c>#getEntry(int)</c> to obtain the entry
		///         information. If &amp;lt; 0 the entry does not exist in the index.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='findEntry' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("findEntry", "([BI)I", "GetFindEntry_arrayBIHandler")]
		public virtual unsafe int FindEntry (byte[] p, int pLen)
		{
			const string __id = "findEntry.([BI)I";
			IntPtr native_p = JNIEnv.NewArray (p);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p);
				__args [1] = new JniArgumentValue (pLen);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p != null) {
					JNIEnv.CopyArray (native_p, p);
					JNIEnv.DeleteLocalRef (native_p);
				}
				global::System.GC.KeepAlive (p);
			}
		}

		static Delegate cb_findEntry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindEntry_Ljava_lang_String_Handler ()
		{
			if (cb_findEntry_Ljava_lang_String_ == null)
				cb_findEntry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_FindEntry_Ljava_lang_String_);
			return cb_findEntry_Ljava_lang_String_;
		}

		static int n_FindEntry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FindEntry (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">the path to search for.</param>
		/// <summary>Locate the position a path's entry is at in the index.</summary>
		/// <returns>if &amp;gt;= 0 then the return value is the position of the entry in
		///         the index; pass to <c>#getEntry(int)</c> to obtain the entry
		///         information. If &amp;lt; 0 the entry does not exist in the index.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='findEntry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findEntry", "(Ljava/lang/String;)I", "GetFindEntry_Ljava_lang_String_Handler")]
		public virtual unsafe int FindEntry (string path)
		{
			const string __id = "findEntry.(Ljava/lang/String;)I";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_getCacheTree_Z;
#pragma warning disable 0169
		static Delegate GetGetCacheTree_ZHandler ()
		{
			if (cb_getCacheTree_Z == null)
				cb_getCacheTree_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_GetCacheTree_Z);
			return cb_getCacheTree_Z;
		}

		static IntPtr n_GetCacheTree_Z (IntPtr jnienv, IntPtr native__this, bool build)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCacheTree (build));
		}
#pragma warning restore 0169

		/// <param name="build">if true and the cache tree is not present in the index it will
		///            be generated and returned to the caller.</param>
		/// <summary>Obtain (or build) the current cache tree structure.</summary>
		/// <returns>the cache tree; null if there is no current cache tree available
		///         and &lt;code&gt;build&lt;/code&gt; was false.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='getCacheTree' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getCacheTree", "(Z)Lorg/eclipse/jgit/dircache/DirCacheTree;", "GetGetCacheTree_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCacheTree GetCacheTree (bool build)
		{
			const string __id = "getCacheTree.(Z)Lorg/eclipse/jgit/dircache/DirCacheTree;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (build);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheTree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEntriesWithin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEntriesWithin_Ljava_lang_String_Handler ()
		{
			if (cb_getEntriesWithin_Ljava_lang_String_ == null)
				cb_getEntriesWithin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetEntriesWithin_Ljava_lang_String_);
			return cb_getEntriesWithin_Ljava_lang_String_;
		}

		static IntPtr n_GetEntriesWithin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetEntriesWithin (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">the subtree path to get all entries within.</param>
		/// <summary>Recursively get all entries within a subtree.</summary>
		/// <returns>all entries recursively contained within the subtree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='getEntriesWithin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEntriesWithin", "(Ljava/lang/String;)[Lorg/eclipse/jgit/dircache/DirCacheEntry;", "GetGetEntriesWithin_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCacheEntry[] GetEntriesWithin (string path)
		{
			const string __id = "getEntriesWithin.(Ljava/lang/String;)[Lorg/eclipse/jgit/dircache/DirCacheEntry;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry));
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_getEntry_I;
#pragma warning disable 0169
		static Delegate GetGetEntry_IHandler ()
		{
			if (cb_getEntry_I == null)
				cb_getEntry_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetEntry_I);
			return cb_getEntry_I;
		}

		static IntPtr n_GetEntry_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetEntry (i));
		}
#pragma warning restore 0169

		/// <param name="i">position of the entry to get.</param>
		/// <summary>Get a specific entry.</summary>
		/// <returns>the entry at position &lt;code&gt;i&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='getEntry' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getEntry", "(I)Lorg/eclipse/jgit/dircache/DirCacheEntry;", "GetGetEntry_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCacheEntry GetEntry (int i)
		{
			const string __id = "getEntry.(I)Lorg/eclipse/jgit/dircache/DirCacheEntry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEntry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEntry_Ljava_lang_String_Handler ()
		{
			if (cb_getEntry_Ljava_lang_String_ == null)
				cb_getEntry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetEntry_Ljava_lang_String_);
			return cb_getEntry_Ljava_lang_String_;
		}

		static IntPtr n_GetEntry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEntry (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">the path to search for.</param>
		/// <summary>Get a specific entry.</summary>
		/// <returns>the entry for the given &lt;code&gt;path&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='getEntry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEntry", "(Ljava/lang/String;)Lorg/eclipse/jgit/dircache/DirCacheEntry;", "GetGetEntry_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCacheEntry GetEntry (string path)
		{
			const string __id = "getEntry.(Ljava/lang/String;)Lorg/eclipse/jgit/dircache/DirCacheEntry;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_lock;
#pragma warning disable 0169
		static Delegate GetLockHandler ()
		{
			if (cb_lock == null)
				cb_lock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Lock);
			return cb_lock;
		}

		static bool n_Lock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Lock ();
		}
#pragma warning restore 0169

		/// <summary>Try to establish an update lock on the cache file.</summary>
		/// <returns>true if the lock is now held by the caller; false if it is held
		///         by someone else.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='lock' and count(parameter)=0]"
		[Register ("lock", "()Z", "GetLockHandler")]
		public virtual unsafe bool Lock ()
		{
			const string __id = "lock.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <param name="indexLocation">location of the index file on disk.</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <summary>Create a new in-core index representation, lock it, and read from disk.</summary>
		/// <returns>a cache representing the contents of the specified index file (if
		///         it exists) or an empty cache if the file does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='lock' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register ("lock", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/dircache/DirCache;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Dircache.DirCache Lock (global::Java.IO.File indexLocation, global::Org.Eclipse.Jgit.Util.FS fs)
		{
			const string __id = "lock.(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((indexLocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexLocation).Handle);
				__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (indexLocation);
				global::System.GC.KeepAlive (fs);
			}
		}

		/// <param name="indexLocation">location of the index file on disk.</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <param name="indexChangedListener">listener to be informed when DirCache is committed</param>
		/// <summary>Create a new in-core index representation, lock it, and read from disk.</summary>
		/// <returns>a cache representing the contents of the specified index file (if
		///         it exists) or an empty cache if the file does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='lock' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS'] and parameter[3][@type='org.eclipse.jgit.events.IndexChangedListener']]"
		[Register ("lock", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;Lorg/eclipse/jgit/events/IndexChangedListener;)Lorg/eclipse/jgit/dircache/DirCache;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Dircache.DirCache Lock (global::Java.IO.File indexLocation, global::Org.Eclipse.Jgit.Util.FS fs, global::Org.Eclipse.Jgit.Events.IIndexChangedListener indexChangedListener)
		{
			const string __id = "lock.(Ljava/io/File;Lorg/eclipse/jgit/util/FS;Lorg/eclipse/jgit/events/IndexChangedListener;)Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((indexLocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexLocation).Handle);
				__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [2] = new JniArgumentValue ((indexChangedListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexChangedListener).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (indexLocation);
				global::System.GC.KeepAlive (fs);
				global::System.GC.KeepAlive (indexChangedListener);
			}
		}

		/// <param name="repository">repository containing the index to lock and read</param>
		/// <param name="indexChangedListener">listener to be informed when DirCache is committed</param>
		/// <summary>Create a new in-core index representation, lock it, and read from disk.</summary>
		/// <returns>a cache representing the contents of the specified index file (if
		///         it exists) or an empty cache if the file does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='lock' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.events.IndexChangedListener']]"
		[Register ("lock", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/events/IndexChangedListener;)Lorg/eclipse/jgit/dircache/DirCache;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Dircache.DirCache Lock (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Events.IIndexChangedListener indexChangedListener)
		{
			const string __id = "lock.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/events/IndexChangedListener;)Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((indexChangedListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexChangedListener).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (indexChangedListener);
			}
		}

		/// <summary>Create a new empty index which is never stored on disk.</summary>
		/// <returns>an empty cache which has no backing store file. The cache may not
		///         be read or written, but it may be queried and updated (in
		///         memory).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='newInCore' and count(parameter)=0]"
		[Register ("newInCore", "()Lorg/eclipse/jgit/dircache/DirCache;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Dircache.DirCache NewInCore ()
		{
			const string __id = "newInCore.()Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nextEntry_I;
#pragma warning disable 0169
		static Delegate GetNextEntry_IHandler ()
		{
			if (cb_nextEntry_I == null)
				cb_nextEntry_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_NextEntry_I);
			return cb_nextEntry_I;
		}

		static int n_NextEntry_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextEntry (position);
		}
#pragma warning restore 0169

		/// <param name="position">entry position of the path that should be skipped.</param>
		/// <summary>Determine the next index position past all entries with the same name.</summary>
		/// <returns>position of the next entry whose path is after the input.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='nextEntry' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("nextEntry", "(I)I", "GetNextEntry_IHandler")]
		public virtual unsafe int NextEntry (int position)
		{
			const string __id = "nextEntry.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Read);
			return cb_read;
		}

		static void n_Read (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Read ();
		}
#pragma warning restore 0169

		/// <summary>Read the index from disk, if it has changed on disk.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()V", "GetReadHandler")]
		public virtual unsafe void Read ()
		{
			const string __id = "read.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <param name="indexLocation">location of the index file on disk.</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <summary>Create a new in-core index representation and read an index from disk.</summary>
		/// <returns>a cache representing the contents of the specified index file (if
		///         it exists) or an empty cache if the file does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='read' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register ("read", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/dircache/DirCache;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Dircache.DirCache Read (global::Java.IO.File indexLocation, global::Org.Eclipse.Jgit.Util.FS fs)
		{
			const string __id = "read.(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((indexLocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexLocation).Handle);
				__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (indexLocation);
				global::System.GC.KeepAlive (fs);
			}
		}

		/// <param name="repository">repository containing the index to read</param>
		/// <summary>Create a new in-core index representation and read an index from disk.</summary>
		/// <returns>a cache representing the contents of the specified index file (if
		///         it exists) or an empty cache if the file does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("read", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/dircache/DirCache;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Dircache.DirCache Read (global::Org.Eclipse.Jgit.Lib.Repository repository)
		{
			const string __id = "read.(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (repository);
			}
		}

		static Delegate cb_unlock;
#pragma warning disable 0169
		static Delegate GetUnlockHandler ()
		{
			if (cb_unlock == null)
				cb_unlock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unlock);
			return cb_unlock;
		}

		static void n_Unlock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		/// <summary>Unlock this file and abort this change.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler")]
		public virtual unsafe void Unlock ()
		{
			const string __id = "unlock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_write;
#pragma warning disable 0169
		static Delegate GetWriteHandler ()
		{
			if (cb_write == null)
				cb_write = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Write);
			return cb_write;
		}

		static void n_Write (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write ();
		}
#pragma warning restore 0169

		/// <summary>Write the entry records from memory to disk.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='write' and count(parameter)=0]"
		[Register ("write", "()V", "GetWriteHandler")]
		public virtual unsafe void Write ()
		{
			const string __id = "write.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeTree_Lorg_eclipse_jgit_lib_ObjectInserter_;
#pragma warning disable 0169
		static Delegate GetWriteTree_Lorg_eclipse_jgit_lib_ObjectInserter_Handler ()
		{
			if (cb_writeTree_Lorg_eclipse_jgit_lib_ObjectInserter_ == null)
				cb_writeTree_Lorg_eclipse_jgit_lib_ObjectInserter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WriteTree_Lorg_eclipse_jgit_lib_ObjectInserter_);
			return cb_writeTree_Lorg_eclipse_jgit_lib_ObjectInserter_;
		}

		static IntPtr n_WriteTree_Lorg_eclipse_jgit_lib_ObjectInserter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ow = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (native_ow, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteTree (ow));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ow">the writer to use when serializing to the store. The caller is
		///            responsible for flushing the inserter before trying to use the
		///            returned tree identity.</param>
		/// <summary>Write all index trees to the object store, returning the root tree.</summary>
		/// <returns>identity for the root tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCache']/method[@name='writeTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectInserter']]"
		[Register ("writeTree", "(Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/lib/ObjectId;", "GetWriteTree_Lorg_eclipse_jgit_lib_ObjectInserter_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId WriteTree (global::Org.Eclipse.Jgit.Lib.ObjectInserter ow)
		{
			const string __id = "writeTree.(Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ow == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ow).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ow);
			}
		}

	}
}
