using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Represents a Git repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/Repository", DoNotGenerateAcw=true)]
	public abstract partial class Repository : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/Repository", typeof (Repository));

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

		protected Repository (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="options">options to configure the repository.</param>
		/// <summary>Initialize a new repository instance.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/constructor[@name='Repository' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BaseRepositoryBuilder']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;)V", "")]
		protected unsafe Repository (global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder options) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (options);
			}
		}

		static Delegate cb_getAdditionalHaves;
#pragma warning disable 0169
		static Delegate GetGetAdditionalHavesHandler ()
		{
			if (cb_getAdditionalHaves == null)
				cb_getAdditionalHaves = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdditionalHaves);
			return cb_getAdditionalHaves;
		}

		static IntPtr n_GetAdditionalHaves (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.AdditionalHaves);
		}
#pragma warning restore 0169

		/// <summary>Objects known to exist but not expressed by <c>#getAllRefs()</c>.</summary>
		/// <returns>unmodifiable collection of other known objects.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> AdditionalHaves {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getAdditionalHaves' and count(parameter)=0]"
			[Register ("getAdditionalHaves", "()Ljava/util/Set;", "GetGetAdditionalHavesHandler")]
			get {
				const string __id = "getAdditionalHaves.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAllRefs;
#pragma warning disable 0169
		static Delegate GetGetAllRefsHandler ()
		{
			if (cb_getAllRefs == null)
				cb_getAllRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllRefs);
			return cb_getAllRefs;
		}

		static IntPtr n_GetAllRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.AllRefs);
		}
#pragma warning restore 0169

		/// <returns>mutable map of all known refs (heads, tags, remotes).</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> AllRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getAllRefs' and count(parameter)=0]"
			[Register ("getAllRefs", "()Ljava/util/Map;", "GetGetAllRefsHandler")]
			get {
				const string __id = "getAllRefs.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAllRefsByPeeledObjectId;
#pragma warning disable 0169
		static Delegate GetGetAllRefsByPeeledObjectIdHandler ()
		{
			if (cb_getAllRefsByPeeledObjectId == null)
				cb_getAllRefsByPeeledObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllRefsByPeeledObjectId);
			return cb_getAllRefsByPeeledObjectId;
		}

		static IntPtr n_GetAllRefsByPeeledObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Org.Eclipse.Jgit.Lib.AnyObjectId, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef>>.ToLocalJniHandle (__this.AllRefsByPeeledObjectId);
		}
#pragma warning restore 0169

		/// <returns>a map with all objects referenced by a peeled ref.</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Org.Eclipse.Jgit.Lib.AnyObjectId, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef>> AllRefsByPeeledObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getAllRefsByPeeledObjectId' and count(parameter)=0]"
			[Register ("getAllRefsByPeeledObjectId", "()Ljava/util/Map;", "GetGetAllRefsByPeeledObjectIdHandler")]
			get {
				const string __id = "getAllRefsByPeeledObjectId.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Org.Eclipse.Jgit.Lib.AnyObjectId, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBranch;
#pragma warning disable 0169
		static Delegate GetGetBranchHandler ()
		{
			if (cb_getBranch == null)
				cb_getBranch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBranch);
			return cb_getBranch;
		}

		static IntPtr n_GetBranch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Branch);
		}
#pragma warning restore 0169

		/// <summary>Get the short name of the current branch that <c>HEAD</c> points to.</summary>
		/// <returns>name of current branch (for example <c>master</c>), or an
		///         ObjectId in hex format if the current branch is detached.</returns>
		public virtual unsafe string Branch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getBranch' and count(parameter)=0]"
			[Register ("getBranch", "()Ljava/lang/String;", "GetGetBranchHandler")]
			get {
				const string __id = "getBranch.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		public abstract global::Org.Eclipse.Jgit.Lib.StoredConfig Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lorg/eclipse/jgit/lib/StoredConfig;", "GetGetConfigHandler")]
			get; 
		}

		static Delegate cb_getDirectory;
#pragma warning disable 0169
		static Delegate GetGetDirectoryHandler ()
		{
			if (cb_getDirectory == null)
				cb_getDirectory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDirectory);
			return cb_getDirectory;
		}

		static IntPtr n_GetDirectory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Directory);
		}
#pragma warning restore 0169

		/// <returns>local metadata directory; null if repository isn't local.</returns>
		public virtual unsafe global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "GetGetDirectoryHandler")]
			get {
				const string __id = "getDirectory.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFS;
#pragma warning disable 0169
		static Delegate GetGetFSHandler ()
		{
			if (cb_getFS == null)
				cb_getFS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFS);
			return cb_getFS;
		}

		static IntPtr n_GetFS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FS);
		}
#pragma warning restore 0169

		/// <returns>the used file system abstraction</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Util.FS FS {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getFS' and count(parameter)=0]"
			[Register ("getFS", "()Lorg/eclipse/jgit/util/FS;", "GetGetFSHandler")]
			get {
				const string __id = "getFS.()Lorg/eclipse/jgit/util/FS;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFullBranch;
#pragma warning disable 0169
		static Delegate GetGetFullBranchHandler ()
		{
			if (cb_getFullBranch == null)
				cb_getFullBranch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFullBranch);
			return cb_getFullBranch;
		}

		static IntPtr n_GetFullBranch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FullBranch);
		}
#pragma warning restore 0169

		/// <summary>Get the name of the reference that <c>HEAD</c> points to.</summary>
		/// <returns>name of current branch (for example <c>refs/heads/master</c>) or
		///         an ObjectId in hex format if the current branch is detached.</returns>
		public virtual unsafe string FullBranch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getFullBranch' and count(parameter)=0]"
			[Register ("getFullBranch", "()Ljava/lang/String;", "GetGetFullBranchHandler")]
			get {
				const string __id = "getFullBranch.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>the global listener list observing all events in this JVM.</returns>
		public static unsafe global::Org.Eclipse.Jgit.Events.ListenerList GlobalListenerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getGlobalListenerList' and count(parameter)=0]"
			[Register ("getGlobalListenerList", "()Lorg/eclipse/jgit/events/ListenerList;", "")]
			get {
				const string __id = "getGlobalListenerList.()Lorg/eclipse/jgit/events/ListenerList;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIndexFile;
#pragma warning disable 0169
		static Delegate GetGetIndexFileHandler ()
		{
			if (cb_getIndexFile == null)
				cb_getIndexFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIndexFile);
			return cb_getIndexFile;
		}

		static IntPtr n_GetIndexFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IndexFile);
		}
#pragma warning restore 0169

		/// <returns>the index file location</returns>
		public virtual unsafe global::Java.IO.File IndexFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getIndexFile' and count(parameter)=0]"
			[Register ("getIndexFile", "()Ljava/io/File;", "GetGetIndexFileHandler")]
			get {
				const string __id = "getIndexFile.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isBare;
#pragma warning disable 0169
		static Delegate GetIsBareHandler ()
		{
			if (cb_isBare == null)
				cb_isBare = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBare);
			return cb_isBare;
		}

		static bool n_IsBare (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBare;
		}
#pragma warning restore 0169

		/// <returns>true if this is bare, which implies it has no working directory.</returns>
		public virtual unsafe bool IsBare {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='isBare' and count(parameter)=0]"
			[Register ("isBare", "()Z", "GetIsBareHandler")]
			get {
				const string __id = "isBare.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getListenerList;
#pragma warning disable 0169
		static Delegate GetGetListenerListHandler ()
		{
			if (cb_getListenerList == null)
				cb_getListenerList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetListenerList);
			return cb_getListenerList;
		}

		static IntPtr n_GetListenerList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListenerList);
		}
#pragma warning restore 0169

		/// <returns>listeners observing only events on this repository.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Events.ListenerList ListenerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getListenerList' and count(parameter)=0]"
			[Register ("getListenerList", "()Lorg/eclipse/jgit/events/ListenerList;", "GetGetListenerListHandler")]
			get {
				const string __id = "getListenerList.()Lorg/eclipse/jgit/events/ListenerList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectDatabase;
#pragma warning disable 0169
		static Delegate GetGetObjectDatabaseHandler ()
		{
			if (cb_getObjectDatabase == null)
				cb_getObjectDatabase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectDatabase);
			return cb_getObjectDatabase;
		}

		static IntPtr n_GetObjectDatabase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectDatabase);
		}
#pragma warning restore 0169

		public abstract global::Org.Eclipse.Jgit.Lib.ObjectDatabase ObjectDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getObjectDatabase' and count(parameter)=0]"
			[Register ("getObjectDatabase", "()Lorg/eclipse/jgit/lib/ObjectDatabase;", "GetGetObjectDatabaseHandler")]
			get; 
		}

		static Delegate cb_getRefDatabase;
#pragma warning disable 0169
		static Delegate GetGetRefDatabaseHandler ()
		{
			if (cb_getRefDatabase == null)
				cb_getRefDatabase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefDatabase);
			return cb_getRefDatabase;
		}

		static IntPtr n_GetRefDatabase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefDatabase);
		}
#pragma warning restore 0169

		public abstract global::Org.Eclipse.Jgit.Lib.RefDatabase RefDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getRefDatabase' and count(parameter)=0]"
			[Register ("getRefDatabase", "()Lorg/eclipse/jgit/lib/RefDatabase;", "GetGetRefDatabaseHandler")]
			get; 
		}

		static Delegate cb_getRemoteNames;
#pragma warning disable 0169
		static Delegate GetGetRemoteNamesHandler ()
		{
			if (cb_getRemoteNames == null)
				cb_getRemoteNames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemoteNames);
			return cb_getRemoteNames;
		}

		static IntPtr n_GetRemoteNames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.RemoteNames);
		}
#pragma warning restore 0169

		/// <returns>the names of all known remotes</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> RemoteNames {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getRemoteNames' and count(parameter)=0]"
			[Register ("getRemoteNames", "()Ljava/util/Set;", "GetGetRemoteNamesHandler")]
			get {
				const string __id = "getRemoteNames.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRepositoryState;
#pragma warning disable 0169
		static Delegate GetGetRepositoryStateHandler ()
		{
			if (cb_getRepositoryState == null)
				cb_getRepositoryState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepositoryState);
			return cb_getRepositoryState;
		}

		static IntPtr n_GetRepositoryState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RepositoryState);
		}
#pragma warning restore 0169

		/// <returns>an important state</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RepositoryState RepositoryState {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getRepositoryState' and count(parameter)=0]"
			[Register ("getRepositoryState", "()Lorg/eclipse/jgit/lib/RepositoryState;", "GetGetRepositoryStateHandler")]
			get {
				const string __id = "getRepositoryState.()Lorg/eclipse/jgit/lib/RepositoryState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		/// <returns>mutable map of all tags; key is short tag name ("v1.0") and value
		///         of the entry contains the ref with the full tag name
		///         ("refs/tags/v1.0").</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Ljava/util/Map;", "GetGetTagsHandler")]
			get {
				const string __id = "getTags.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWorkTree;
#pragma warning disable 0169
		static Delegate GetGetWorkTreeHandler ()
		{
			if (cb_getWorkTree == null)
				cb_getWorkTree = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWorkTree);
			return cb_getWorkTree;
		}

		static IntPtr n_GetWorkTree (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WorkTree);
		}
#pragma warning restore 0169

		/// <returns>the root directory of the working tree, where files are checked
		///         out for viewing and editing.</returns>
		public virtual unsafe global::Java.IO.File WorkTree {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getWorkTree' and count(parameter)=0]"
			[Register ("getWorkTree", "()Ljava/io/File;", "GetGetWorkTreeHandler")]
			get {
				const string __id = "getWorkTree.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		/// <summary>Decrement the use count, and maybe close resources.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create ();
		}
#pragma warning restore 0169

		/// <summary>Create a new Git repository.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "GetCreateHandler")]
		public virtual unsafe void Create ()
		{
			const string __id = "create.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_create_Z;
#pragma warning disable 0169
		static Delegate GetCreate_ZHandler ()
		{
			if (cb_create_Z == null)
				cb_create_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Create_Z);
			return cb_create_Z;
		}

		static void n_Create_Z (IntPtr jnienv, IntPtr native__this, bool bare)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create (bare);
		}
#pragma warning restore 0169

		/// <param name="bare">if true, a bare repository (a repository without a working
		///            directory) is created.</param>
		/// <summary>Create a new Git repository initializing the necessary files and
		/// directories.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("create", "(Z)V", "GetCreate_ZHandler")]
		public abstract void Create (bool bare);

		static Delegate cb_doClose;
#pragma warning disable 0169
		static Delegate GetDoCloseHandler ()
		{
			if (cb_doClose == null)
				cb_doClose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoClose);
			return cb_doClose;
		}

		static void n_DoClose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoClose ();
		}
#pragma warning restore 0169

		/// <summary>Invoked when the use count drops to zero during <c>#close()</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='doClose' and count(parameter)=0]"
		[Register ("doClose", "()V", "GetDoCloseHandler")]
		protected virtual unsafe void DoClose ()
		{
			const string __id = "doClose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fireEvent_Lorg_eclipse_jgit_events_RepositoryEvent_;
#pragma warning disable 0169
		static Delegate GetFireEvent_Lorg_eclipse_jgit_events_RepositoryEvent_Handler ()
		{
			if (cb_fireEvent_Lorg_eclipse_jgit_events_RepositoryEvent_ == null)
				cb_fireEvent_Lorg_eclipse_jgit_events_RepositoryEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FireEvent_Lorg_eclipse_jgit_events_RepositoryEvent_);
			return cb_fireEvent_Lorg_eclipse_jgit_events_RepositoryEvent_;
		}

		static void n_FireEvent_Lorg_eclipse_jgit_events_RepositoryEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.RepositoryEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.FireEvent (e);
		}
#pragma warning restore 0169

		/// <param name="event">the event to deliver.</param>
		/// <summary>Fire an event to all registered listeners.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='fireEvent' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.events.RepositoryEvent&lt;?&gt;']]"
		[Register ("fireEvent", "(Lorg/eclipse/jgit/events/RepositoryEvent;)V", "GetFireEvent_Lorg_eclipse_jgit_events_RepositoryEvent_Handler")]
		public virtual unsafe void FireEvent (global::Org.Eclipse.Jgit.Events.RepositoryEvent e)
		{
			const string __id = "fireEvent.(Lorg/eclipse/jgit/events/RepositoryEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
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

		static IntPtr n_GetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRef (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">the name of the ref to lookup. May be a short-hand form, e.g.
		///            "master" which is is automatically expanded to
		///            "refs/heads/master" if "refs/heads/master" already exists.</param>
		/// <summary>Get a ref by name.</summary>
		/// <returns>the Ref with the given name, or null if it does not exist</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "GetGetRef_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IRef GetRef (string name)
		{
			const string __id = "getRef.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;";
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

		static Delegate cb_getReflogReader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetReflogReader_Ljava_lang_String_Handler ()
		{
			if (cb_getReflogReader_Ljava_lang_String_ == null)
				cb_getReflogReader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetReflogReader_Ljava_lang_String_);
			return cb_getReflogReader_Ljava_lang_String_;
		}

		static IntPtr n_GetReflogReader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetReflogReader (refName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="refName">refName</param>
		/// <returns>a <c>ReflogReader</c> for the supplied refname, or null if the
		///         named ref does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getReflogReader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getReflogReader", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/ReflogReader;", "GetGetReflogReader_Ljava_lang_String_Handler")]
		public abstract global::Org.Eclipse.Jgit.Lib.IReflogReader GetReflogReader (string refName);

		static Delegate cb_getRemoteName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRemoteName_Ljava_lang_String_Handler ()
		{
			if (cb_getRemoteName_Ljava_lang_String_ == null)
				cb_getRemoteName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRemoteName_Ljava_lang_String_);
			return cb_getRemoteName_Ljava_lang_String_;
		}

		static IntPtr n_GetRemoteName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetRemoteName (refName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="refName">refName</param>
		/// <returns>the remote name part of &lt;code&gt;refName&lt;/code&gt;, i.e. without the
		///         &lt;code&gt;refs/remotes/&amp;lt;remote&amp;gt;&lt;/code&gt; prefix, if
		///         &lt;code&gt;refName&lt;/code&gt; represents a remote tracking branch;
		///         otherwise null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getRemoteName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRemoteName", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetRemoteName_Ljava_lang_String_Handler")]
		public virtual unsafe string GetRemoteName (string refName)
		{
			const string __id = "getRemoteName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
			}
		}

		static Delegate cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetHasObject_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasObject_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_HasObject_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasObject (objectId);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">objectId</param>
		/// <returns>true if the specified object is stored in this repo or any of the
		///         known shared repositories.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='hasObject' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("hasObject", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetHasObject_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe bool HasObject (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			const string __id = "hasObject.(Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		static Delegate cb_incrementOpen;
#pragma warning disable 0169
		static Delegate GetIncrementOpenHandler ()
		{
			if (cb_incrementOpen == null)
				cb_incrementOpen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_IncrementOpen);
			return cb_incrementOpen;
		}

		static void n_IncrementOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IncrementOpen ();
		}
#pragma warning restore 0169

		/// <summary>Increment the use counter by one, requiring a matched <c>#close()</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='incrementOpen' and count(parameter)=0]"
		[Register ("incrementOpen", "()V", "GetIncrementOpenHandler")]
		public virtual unsafe void IncrementOpen ()
		{
			const string __id = "incrementOpen.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <param name="refName">refName</param>
		/// <summary>Check validity of a ref name.</summary>
		/// <returns>true if refName is a valid ref name</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='isValidRefName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isValidRefName", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsValidRefName (string refName)
		{
			const string __id = "isValidRefName.(Ljava/lang/String;)Z";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
			}
		}

		static Delegate cb_lockDirCache;
#pragma warning disable 0169
		static Delegate GetLockDirCacheHandler ()
		{
			if (cb_lockDirCache == null)
				cb_lockDirCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LockDirCache);
			return cb_lockDirCache;
		}

		static IntPtr n_LockDirCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LockDirCache ());
		}
#pragma warning restore 0169

		/// <summary>Create a new in-core index representation, lock it, and read from disk.</summary>
		/// <returns>a cache representing the contents of the specified index file (if
		///         it exists) or an empty cache if the file does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='lockDirCache' and count(parameter)=0]"
		[Register ("lockDirCache", "()Lorg/eclipse/jgit/dircache/DirCache;", "GetLockDirCacheHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCache LockDirCache ()
		{
			const string __id = "lockDirCache.()Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newObjectInserter;
#pragma warning disable 0169
		static Delegate GetNewObjectInserterHandler ()
		{
			if (cb_newObjectInserter == null)
				cb_newObjectInserter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewObjectInserter);
			return cb_newObjectInserter;
		}

		static IntPtr n_NewObjectInserter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewObjectInserter ());
		}
#pragma warning restore 0169

		/// <returns>a new inserter to create objects in <c>#getObjectDatabase()</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='newObjectInserter' and count(parameter)=0]"
		[Register ("newObjectInserter", "()Lorg/eclipse/jgit/lib/ObjectInserter;", "GetNewObjectInserterHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectInserter NewObjectInserter ()
		{
			const string __id = "newObjectInserter.()Lorg/eclipse/jgit/lib/ObjectInserter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newObjectReader;
#pragma warning disable 0169
		static Delegate GetNewObjectReaderHandler ()
		{
			if (cb_newObjectReader == null)
				cb_newObjectReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewObjectReader);
			return cb_newObjectReader;
		}

		static IntPtr n_NewObjectReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewObjectReader ());
		}
#pragma warning restore 0169

		/// <returns>a new reader to read objects from <c>#getObjectDatabase()</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='newObjectReader' and count(parameter)=0]"
		[Register ("newObjectReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewObjectReaderHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader NewObjectReader ()
		{
			const string __id = "newObjectReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notifyIndexChanged;
#pragma warning disable 0169
		static Delegate GetNotifyIndexChangedHandler ()
		{
			if (cb_notifyIndexChanged == null)
				cb_notifyIndexChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_NotifyIndexChanged);
			return cb_notifyIndexChanged;
		}

		static void n_NotifyIndexChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyIndexChanged ();
		}
#pragma warning restore 0169

		/// <summary>Notify that the index changed</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='notifyIndexChanged' and count(parameter)=0]"
		[Register ("notifyIndexChanged", "()V", "GetNotifyIndexChangedHandler")]
		public abstract void NotifyIndexChanged ();

		static Delegate cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Open_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Open_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (objectId));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to open.</param>
		/// <summary>Open an object from this repository.</summary>
		/// <returns>a <c>ObjectLoader</c> for accessing the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='open' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/ObjectLoader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		static Delegate cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_Open_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static IntPtr n_Open_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId, int typeHint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (objectId, typeHint));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to open.</param>
		/// <param name="typeHint">hint about the type of object being requested, e.g.
		///            <c>Constants#OBJ_BLOB</c>; <c>ObjectReader#OBJ_ANY</c> if
		///            the object type is not known, or does not matter to the
		///            caller.</param>
		/// <summary>Open an object from this repository.</summary>
		/// <returns>a <c>ObjectLoader</c> for accessing the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int typeHint)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/ObjectLoader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [1] = new JniArgumentValue (typeHint);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Peel (@ref));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ref">The ref to peel</param>
		/// <summary>Peel a possibly unpeeled reference to an annotated tag.</summary>
		/// <returns>&lt;code&gt;ref&lt;/code&gt; if &lt;code&gt;ref.isPeeled()&lt;/code&gt; is true; else a
		///         new Ref object representing the same data as Ref, but isPeeled()
		///         will be true and getPeeledObjectId will contain the peeled object
		///         (or null).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='peel' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("peel", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;", "GetPeel_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IRef Peel (global::Org.Eclipse.Jgit.Lib.IRef @ref)
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

		static Delegate cb_readCherryPickHead;
#pragma warning disable 0169
		static Delegate GetReadCherryPickHeadHandler ()
		{
			if (cb_readCherryPickHead == null)
				cb_readCherryPickHead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadCherryPickHead);
			return cb_readCherryPickHead;
		}

		static IntPtr n_ReadCherryPickHead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadCherryPickHead ());
		}
#pragma warning restore 0169

		/// <summary>Return the information stored in the file $GIT_DIR/CHERRY_PICK_HEAD.</summary>
		/// <returns>object id from CHERRY_PICK_HEAD file or <c>null</c> if this file
		///         doesn't exist. Also if the file exists but is empty <c>null</c>
		///         will be returned</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='readCherryPickHead' and count(parameter)=0]"
		[Register ("readCherryPickHead", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetReadCherryPickHeadHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ReadCherryPickHead ()
		{
			const string __id = "readCherryPickHead.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readDirCache;
#pragma warning disable 0169
		static Delegate GetReadDirCacheHandler ()
		{
			if (cb_readDirCache == null)
				cb_readDirCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadDirCache);
			return cb_readDirCache;
		}

		static IntPtr n_ReadDirCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadDirCache ());
		}
#pragma warning restore 0169

		/// <summary>Create a new in-core index representation and read an index from disk.</summary>
		/// <returns>a cache representing the contents of the specified index file (if
		///         it exists) or an empty cache if the file does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='readDirCache' and count(parameter)=0]"
		[Register ("readDirCache", "()Lorg/eclipse/jgit/dircache/DirCache;", "GetReadDirCacheHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCache ReadDirCache ()
		{
			const string __id = "readDirCache.()Lorg/eclipse/jgit/dircache/DirCache;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readMergeCommitMsg;
#pragma warning disable 0169
		static Delegate GetReadMergeCommitMsgHandler ()
		{
			if (cb_readMergeCommitMsg == null)
				cb_readMergeCommitMsg = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadMergeCommitMsg);
			return cb_readMergeCommitMsg;
		}

		static IntPtr n_ReadMergeCommitMsg (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadMergeCommitMsg ());
		}
#pragma warning restore 0169

		/// <summary>Return the information stored in the file $GIT_DIR/MERGE_MSG.</summary>
		/// <returns>a String containing the content of the MERGE_MSG file or
		///         <c>null</c> if this file doesn't exist</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='readMergeCommitMsg' and count(parameter)=0]"
		[Register ("readMergeCommitMsg", "()Ljava/lang/String;", "GetReadMergeCommitMsgHandler")]
		public virtual unsafe string ReadMergeCommitMsg ()
		{
			const string __id = "readMergeCommitMsg.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readMergeHeads;
#pragma warning disable 0169
		static Delegate GetReadMergeHeadsHandler ()
		{
			if (cb_readMergeHeads == null)
				cb_readMergeHeads = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadMergeHeads);
			return cb_readMergeHeads;
		}

		static IntPtr n_ReadMergeHeads (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.ReadMergeHeads ());
		}
#pragma warning restore 0169

		/// <summary>Return the information stored in the file $GIT_DIR/MERGE_HEAD.</summary>
		/// <returns>a list of commits which IDs are listed in the MERGE_HEAD file or
		///         <c>null</c> if this file doesn't exist. Also if the file exists
		///         but is empty <c>null</c> will be returned</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='readMergeHeads' and count(parameter)=0]"
		[Register ("readMergeHeads", "()Ljava/util/List;", "GetReadMergeHeadsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.ObjectId> ReadMergeHeads ()
		{
			const string __id = "readMergeHeads.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readOrigHead;
#pragma warning disable 0169
		static Delegate GetReadOrigHeadHandler ()
		{
			if (cb_readOrigHead == null)
				cb_readOrigHead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadOrigHead);
			return cb_readOrigHead;
		}

		static IntPtr n_ReadOrigHead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadOrigHead ());
		}
#pragma warning restore 0169

		/// <summary>Return the information stored in the file $GIT_DIR/ORIG_HEAD.</summary>
		/// <returns>object id from ORIG_HEAD file or <c>null</c> if this file
		///         doesn't exist. Also if the file exists but is empty <c>null</c>
		///         will be returned</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='readOrigHead' and count(parameter)=0]"
		[Register ("readOrigHead", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetReadOrigHeadHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ReadOrigHead ()
		{
			const string __id = "readOrigHead.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readRebaseTodo_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetReadRebaseTodo_Ljava_lang_String_ZHandler ()
		{
			if (cb_readRebaseTodo_Ljava_lang_String_Z == null)
				cb_readRebaseTodo_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_ReadRebaseTodo_Ljava_lang_String_Z);
			return cb_readRebaseTodo_Ljava_lang_String_Z;
		}

		static IntPtr n_ReadRebaseTodo_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_path, bool includeComments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.ToLocalJniHandle (__this.ReadRebaseTodo (path, includeComments));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path to the file relative to the repository's git-dir. E.g.
		///            "rebase-merge/git-rebase-todo" or "rebase-append/done"</param>
		/// <param name="includeComments">&lt;code&gt;true&lt;/code&gt; if also comments should be reported</param>
		/// <summary>Read a file formatted like the git-rebase-todo file.</summary>
		/// <returns>the list of steps</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='readRebaseTodo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("readRebaseTodo", "(Ljava/lang/String;Z)Ljava/util/List;", "GetReadRebaseTodo_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> ReadRebaseTodo (string path, bool includeComments)
		{
			const string __id = "readRebaseTodo.(Ljava/lang/String;Z)Ljava/util/List;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (includeComments);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_readRevertHead;
#pragma warning disable 0169
		static Delegate GetReadRevertHeadHandler ()
		{
			if (cb_readRevertHead == null)
				cb_readRevertHead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadRevertHead);
			return cb_readRevertHead;
		}

		static IntPtr n_ReadRevertHead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadRevertHead ());
		}
#pragma warning restore 0169

		/// <summary>Return the information stored in the file $GIT_DIR/REVERT_HEAD.</summary>
		/// <returns>object id from REVERT_HEAD file or <c>null</c> if this file
		///         doesn't exist. Also if the file exists but is empty <c>null</c>
		///         will be returned</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='readRevertHead' and count(parameter)=0]"
		[Register ("readRevertHead", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetReadRevertHeadHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ReadRevertHead ()
		{
			const string __id = "readRevertHead.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readSquashCommitMsg;
#pragma warning disable 0169
		static Delegate GetReadSquashCommitMsgHandler ()
		{
			if (cb_readSquashCommitMsg == null)
				cb_readSquashCommitMsg = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadSquashCommitMsg);
			return cb_readSquashCommitMsg;
		}

		static IntPtr n_ReadSquashCommitMsg (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadSquashCommitMsg ());
		}
#pragma warning restore 0169

		/// <summary>Return the information stored in the file $GIT_DIR/SQUASH_MSG.</summary>
		/// <returns>a String containing the content of the SQUASH_MSG file or
		///         <c>null</c> if this file doesn't exist</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='readSquashCommitMsg' and count(parameter)=0]"
		[Register ("readSquashCommitMsg", "()Ljava/lang/String;", "GetReadSquashCommitMsgHandler")]
		public virtual unsafe string ReadSquashCommitMsg ()
		{
			const string __id = "readSquashCommitMsg.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_renameRef_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRenameRef_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_renameRef_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_renameRef_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_RenameRef_Ljava_lang_String_Ljava_lang_String_);
			return cb_renameRef_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_RenameRef_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fromRef, IntPtr native_toRef)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fromRef = JNIEnv.GetString (native_fromRef, JniHandleOwnership.DoNotTransfer);
			var toRef = JNIEnv.GetString (native_toRef, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RenameRef (fromRef, toRef));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="fromRef">name of ref to rename from</param>
		/// <param name="toRef">name of ref to rename to</param>
		/// <summary>Create a command to rename a ref in this repository</summary>
		/// <returns>an update command that knows how to rename a branch to another.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='renameRef' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("renameRef", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefRename;", "GetRenameRef_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefRename RenameRef (string fromRef, string toRef)
		{
			const string __id = "renameRef.(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefRename;";
			IntPtr native_fromRef = JNIEnv.NewString ((string)fromRef);
			IntPtr native_toRef = JNIEnv.NewString ((string)toRef);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fromRef);
				__args [1] = new JniArgumentValue (native_toRef);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fromRef);
				JNIEnv.DeleteLocalRef (native_toRef);
			}
		}

		static Delegate cb_resolve_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResolve_Ljava_lang_String_Handler ()
		{
			if (cb_resolve_Ljava_lang_String_ == null)
				cb_resolve_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Resolve_Ljava_lang_String_);
			return cb_resolve_Ljava_lang_String_;
		}

		static IntPtr n_Resolve_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_revstr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var revstr = JNIEnv.GetString (native_revstr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Resolve (revstr));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='resolve' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("resolve", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;", "GetResolve_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Resolve (string revstr)
		{
			const string __id = "resolve.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_revstr = JNIEnv.NewString ((string)revstr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_revstr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_revstr);
			}
		}

		static Delegate cb_scanForRepoChanges;
#pragma warning disable 0169
		static Delegate GetScanForRepoChangesHandler ()
		{
			if (cb_scanForRepoChanges == null)
				cb_scanForRepoChanges = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ScanForRepoChanges);
			return cb_scanForRepoChanges;
		}

		static void n_ScanForRepoChanges (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScanForRepoChanges ();
		}
#pragma warning restore 0169

		/// <summary>Force a scan for changed refs.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='scanForRepoChanges' and count(parameter)=0]"
		[Register ("scanForRepoChanges", "()V", "GetScanForRepoChangesHandler")]
		public abstract void ScanForRepoChanges ();

		/// <param name="refName">refName</param>
		/// <returns>a more user friendly ref name</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='shortenRefName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("shortenRefName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ShortenRefName (string refName)
		{
			const string __id = "shortenRefName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
			}
		}

		static Delegate cb_shortenRemoteBranchName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShortenRemoteBranchName_Ljava_lang_String_Handler ()
		{
			if (cb_shortenRemoteBranchName_Ljava_lang_String_ == null)
				cb_shortenRemoteBranchName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ShortenRemoteBranchName_Ljava_lang_String_);
			return cb_shortenRemoteBranchName_Ljava_lang_String_;
		}

		static IntPtr n_ShortenRemoteBranchName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ShortenRemoteBranchName (refName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="refName">refName</param>
		/// <returns>the remote branch name part of &lt;code&gt;refName&lt;/code&gt;, i.e. without
		///         the &lt;code&gt;refs/remotes/&amp;lt;remote&amp;gt;&lt;/code&gt; prefix, if
		///         &lt;code&gt;refName&lt;/code&gt; represents a remote tracking branch;
		///         otherwise null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='shortenRemoteBranchName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("shortenRemoteBranchName", "(Ljava/lang/String;)Ljava/lang/String;", "GetShortenRemoteBranchName_Ljava_lang_String_Handler")]
		public virtual unsafe string ShortenRemoteBranchName (string refName)
		{
			const string __id = "shortenRemoteBranchName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
			}
		}

		static Delegate cb_simplify_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSimplify_Ljava_lang_String_Handler ()
		{
			if (cb_simplify_Ljava_lang_String_ == null)
				cb_simplify_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Simplify_Ljava_lang_String_);
			return cb_simplify_Ljava_lang_String_;
		}

		static IntPtr n_Simplify_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_revstr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var revstr = JNIEnv.GetString (native_revstr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Simplify (revstr));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="revstr">revstr</param>
		/// <summary>Simplify an expression, but unlike <c>#resolve(String)</c> it will not
		/// resolve a branch passed or resulting from the expression, such as</summary>
		/// <returns>object id or ref name from resolved expression</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='simplify' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("simplify", "(Ljava/lang/String;)Ljava/lang/String;", "GetSimplify_Ljava_lang_String_Handler")]
		public virtual unsafe string Simplify (string revstr)
		{
			const string __id = "simplify.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_revstr = JNIEnv.NewString ((string)revstr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_revstr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_revstr);
			}
		}

		/// <param name="workDir">Work dir</param>
		/// <param name="file">File whose path shall be stripped of its workdir</param>
		/// <summary>Strip work dir and return normalized repository path.</summary>
		/// <returns>normalized repository relative path or the empty
		///         string if the file is not relative to the work directory.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='stripWorkDir' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File']]"
		[Register ("stripWorkDir", "(Ljava/io/File;Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string StripWorkDir (global::Java.IO.File workDir, global::Java.IO.File file)
		{
			const string __id = "stripWorkDir.(Ljava/io/File;Ljava/io/File;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((workDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) workDir).Handle);
				__args [1] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (workDir);
				global::System.GC.KeepAlive (file);
			}
		}

		static Delegate cb_updateRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateRef_Ljava_lang_String_Handler ()
		{
			if (cb_updateRef_Ljava_lang_String_ == null)
				cb_updateRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_UpdateRef_Ljava_lang_String_);
			return cb_updateRef_Ljava_lang_String_;
		}

		static IntPtr n_UpdateRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateRef (@ref));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ref">name of the ref the caller wants to modify.</param>
		/// <summary>Create a command to update, create or delete a ref in this repository.</summary>
		/// <returns>an update command. The caller must finish populating this command
		///         and then invoke one of the update methods to actually make a
		///         change.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='updateRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefUpdate;", "GetUpdateRef_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate UpdateRef (string @ref)
		{
			const string __id = "updateRef.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefUpdate;";
			IntPtr native__ref = JNIEnv.NewString ((string)@ref);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__ref);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__ref);
			}
		}

		static Delegate cb_updateRef_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateRef_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateRef_Ljava_lang_String_Z == null)
				cb_updateRef_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_UpdateRef_Ljava_lang_String_Z);
			return cb_updateRef_Ljava_lang_String_Z;
		}

		static IntPtr n_UpdateRef_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, bool detach)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateRef (@ref, detach));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ref">name of the ref the caller wants to modify.</param>
		/// <param name="detach">true to create a detached head</param>
		/// <summary>Create a command to update, create or delete a ref in this repository.</summary>
		/// <returns>an update command. The caller must finish populating this command
		///         and then invoke one of the update methods to actually make a
		///         change.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='updateRef' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateRef", "(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/RefUpdate;", "GetUpdateRef_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate UpdateRef (string @ref, bool detach)
		{
			const string __id = "updateRef.(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/RefUpdate;";
			IntPtr native__ref = JNIEnv.NewString ((string)@ref);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__ref);
				__args [1] = new JniArgumentValue (detach);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__ref);
			}
		}

		static Delegate cb_writeCherryPickHead_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetWriteCherryPickHead_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_writeCherryPickHead_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_writeCherryPickHead_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteCherryPickHead_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_writeCherryPickHead_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static void n_WriteCherryPickHead_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_head)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var head = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_head, JniHandleOwnership.DoNotTransfer);
			__this.WriteCherryPickHead (head);
		}
#pragma warning restore 0169

		/// <param name="head">an object id of the cherry commit or &lt;code&gt;null&lt;/code&gt; to
		///            delete the file</param>
		/// <summary>Write cherry pick commit into $GIT_DIR/CHERRY_PICK_HEAD.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='writeCherryPickHead' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("writeCherryPickHead", "(Lorg/eclipse/jgit/lib/ObjectId;)V", "GetWriteCherryPickHead_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public virtual unsafe void WriteCherryPickHead (global::Org.Eclipse.Jgit.Lib.ObjectId head)
		{
			const string __id = "writeCherryPickHead.(Lorg/eclipse/jgit/lib/ObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((head == null) ? IntPtr.Zero : ((global::Java.Lang.Object) head).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (head);
			}
		}

		static Delegate cb_writeMergeCommitMsg_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteMergeCommitMsg_Ljava_lang_String_Handler ()
		{
			if (cb_writeMergeCommitMsg_Ljava_lang_String_ == null)
				cb_writeMergeCommitMsg_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteMergeCommitMsg_Ljava_lang_String_);
			return cb_writeMergeCommitMsg_Ljava_lang_String_;
		}

		static void n_WriteMergeCommitMsg_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.WriteMergeCommitMsg (msg);
		}
#pragma warning restore 0169

		/// <param name="msg">the message which should be written or &lt;code&gt;null&lt;/code&gt; to
		///            delete the file</param>
		/// <summary>Write new content to the file $GIT_DIR/MERGE_MSG.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='writeMergeCommitMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeMergeCommitMsg", "(Ljava/lang/String;)V", "GetWriteMergeCommitMsg_Ljava_lang_String_Handler")]
		public virtual unsafe void WriteMergeCommitMsg (string msg)
		{
			const string __id = "writeMergeCommitMsg.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_writeMergeHeads_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWriteMergeHeads_Ljava_util_List_Handler ()
		{
			if (cb_writeMergeHeads_Ljava_util_List_ == null)
				cb_writeMergeHeads_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteMergeHeads_Ljava_util_List_);
			return cb_writeMergeHeads_Ljava_util_List_;
		}

		static void n_WriteMergeHeads_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_heads)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var heads = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_heads, JniHandleOwnership.DoNotTransfer);
			__this.WriteMergeHeads (heads);
		}
#pragma warning restore 0169

		/// <param name="heads">a list of commits which IDs should be written to
		///            $GIT_DIR/MERGE_HEAD or &lt;code&gt;null&lt;/code&gt; to delete the file</param>
		/// <summary>Write new merge-heads into $GIT_DIR/MERGE_HEAD.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='writeMergeHeads' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("writeMergeHeads", "(Ljava/util/List;)V", "GetWriteMergeHeads_Ljava_util_List_Handler")]
		public virtual unsafe void WriteMergeHeads (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.ObjectId> heads)
		{
			const string __id = "writeMergeHeads.(Ljava/util/List;)V";
			IntPtr native_heads = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (heads);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_heads);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_heads);
				global::System.GC.KeepAlive (heads);
			}
		}

		static Delegate cb_writeOrigHead_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetWriteOrigHead_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_writeOrigHead_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_writeOrigHead_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteOrigHead_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_writeOrigHead_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static void n_WriteOrigHead_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_head)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var head = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_head, JniHandleOwnership.DoNotTransfer);
			__this.WriteOrigHead (head);
		}
#pragma warning restore 0169

		/// <param name="head">an object id of the original HEAD commit or &lt;code&gt;null&lt;/code&gt;
		///            to delete the file</param>
		/// <summary>Write original HEAD commit into $GIT_DIR/ORIG_HEAD.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='writeOrigHead' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("writeOrigHead", "(Lorg/eclipse/jgit/lib/ObjectId;)V", "GetWriteOrigHead_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public virtual unsafe void WriteOrigHead (global::Org.Eclipse.Jgit.Lib.ObjectId head)
		{
			const string __id = "writeOrigHead.(Lorg/eclipse/jgit/lib/ObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((head == null) ? IntPtr.Zero : ((global::Java.Lang.Object) head).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (head);
			}
		}

		static Delegate cb_writeRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetWriteRebaseTodoFile_Ljava_lang_String_Ljava_util_List_ZHandler ()
		{
			if (cb_writeRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z == null)
				cb_writeRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_WriteRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z);
			return cb_writeRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z;
		}

		static void n_WriteRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_steps, bool append)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			var steps = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.FromJniHandle (native_steps, JniHandleOwnership.DoNotTransfer);
			__this.WriteRebaseTodoFile (path, steps, append);
		}
#pragma warning restore 0169

		/// <param name="path">path to the file relative to the repository's git-dir. E.g.
		///            "rebase-merge/git-rebase-todo" or "rebase-append/done"</param>
		/// <param name="steps">the steps to be written</param>
		/// <param name="append">whether to append to an existing file or to write a new file</param>
		/// <summary>Write a file formatted like a git-rebase-todo file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='writeRebaseTodoFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.lib.RebaseTodoLine&gt;'] and parameter[3][@type='boolean']]"
		[Register ("writeRebaseTodoFile", "(Ljava/lang/String;Ljava/util/List;Z)V", "GetWriteRebaseTodoFile_Ljava_lang_String_Ljava_util_List_ZHandler")]
		public virtual unsafe void WriteRebaseTodoFile (string path, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> steps, bool append)
		{
			const string __id = "writeRebaseTodoFile.(Ljava/lang/String;Ljava/util/List;Z)V";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			IntPtr native_steps = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.ToLocalJniHandle (steps);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_steps);
				__args [2] = new JniArgumentValue (append);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_steps);
				global::System.GC.KeepAlive (steps);
			}
		}

		static Delegate cb_writeRevertHead_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetWriteRevertHead_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_writeRevertHead_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_writeRevertHead_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteRevertHead_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_writeRevertHead_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static void n_WriteRevertHead_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_head)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var head = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_head, JniHandleOwnership.DoNotTransfer);
			__this.WriteRevertHead (head);
		}
#pragma warning restore 0169

		/// <param name="head">an object id of the revert commit or &lt;code&gt;null&lt;/code&gt; to
		///            delete the file</param>
		/// <summary>Write revert commit into $GIT_DIR/REVERT_HEAD.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='writeRevertHead' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("writeRevertHead", "(Lorg/eclipse/jgit/lib/ObjectId;)V", "GetWriteRevertHead_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public virtual unsafe void WriteRevertHead (global::Org.Eclipse.Jgit.Lib.ObjectId head)
		{
			const string __id = "writeRevertHead.(Lorg/eclipse/jgit/lib/ObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((head == null) ? IntPtr.Zero : ((global::Java.Lang.Object) head).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (head);
			}
		}

		static Delegate cb_writeSquashCommitMsg_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteSquashCommitMsg_Ljava_lang_String_Handler ()
		{
			if (cb_writeSquashCommitMsg_Ljava_lang_String_ == null)
				cb_writeSquashCommitMsg_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteSquashCommitMsg_Ljava_lang_String_);
			return cb_writeSquashCommitMsg_Ljava_lang_String_;
		}

		static void n_WriteSquashCommitMsg_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.WriteSquashCommitMsg (msg);
		}
#pragma warning restore 0169

		/// <param name="msg">the message which should be written or &lt;code&gt;null&lt;/code&gt; to
		///            delete the file</param>
		/// <summary>Write new content to the file $GIT_DIR/SQUASH_MSG.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='writeSquashCommitMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeSquashCommitMsg", "(Ljava/lang/String;)V", "GetWriteSquashCommitMsg_Ljava_lang_String_Handler")]
		public virtual unsafe void WriteSquashCommitMsg (string msg)
		{
			const string __id = "writeSquashCommitMsg.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/Repository", DoNotGenerateAcw=true)]
	internal partial class RepositoryInvoker : Repository {
		public RepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/Repository", typeof (RepositoryInvoker));

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

		/// <returns>the configuration of this repository</returns>
		public override unsafe global::Org.Eclipse.Jgit.Lib.StoredConfig Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lorg/eclipse/jgit/lib/StoredConfig;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Lorg/eclipse/jgit/lib/StoredConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.StoredConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>the object database which stores this repository's data.</returns>
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectDatabase ObjectDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getObjectDatabase' and count(parameter)=0]"
			[Register ("getObjectDatabase", "()Lorg/eclipse/jgit/lib/ObjectDatabase;", "GetGetObjectDatabaseHandler")]
			get {
				const string __id = "getObjectDatabase.()Lorg/eclipse/jgit/lib/ObjectDatabase;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>the reference database which stores the reference namespace.</returns>
		public override unsafe global::Org.Eclipse.Jgit.Lib.RefDatabase RefDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getRefDatabase' and count(parameter)=0]"
			[Register ("getRefDatabase", "()Lorg/eclipse/jgit/lib/RefDatabase;", "GetGetRefDatabaseHandler")]
			get {
				const string __id = "getRefDatabase.()Lorg/eclipse/jgit/lib/RefDatabase;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <param name="bare">if true, a bare repository (a repository without a working
		///            directory) is created.</param>
		/// <summary>Create a new Git repository initializing the necessary files and
		/// directories.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("create", "(Z)V", "GetCreate_ZHandler")]
		public override unsafe void Create (bool bare)
		{
			const string __id = "create.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bare);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <param name="refName">refName</param>
		/// <returns>a <c>ReflogReader</c> for the supplied refname, or null if the
		///         named ref does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='getReflogReader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getReflogReader", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/ReflogReader;", "GetGetReflogReader_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IReflogReader GetReflogReader (string refName)
		{
			const string __id = "getReflogReader.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/ReflogReader;";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
			}
		}

		/// <summary>Notify that the index changed</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='notifyIndexChanged' and count(parameter)=0]"
		[Register ("notifyIndexChanged", "()V", "GetNotifyIndexChangedHandler")]
		public override unsafe void NotifyIndexChanged ()
		{
			const string __id = "notifyIndexChanged.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <summary>Force a scan for changed refs.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Repository']/method[@name='scanForRepoChanges' and count(parameter)=0]"
		[Register ("scanForRepoChanges", "()V", "GetScanForRepoChangesHandler")]
		public override unsafe void ScanForRepoChanges ()
		{
			const string __id = "scanForRepoChanges.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
