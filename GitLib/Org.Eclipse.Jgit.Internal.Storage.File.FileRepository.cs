using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Represents a Git repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/FileRepository", DoNotGenerateAcw=true)]
	public partial class FileRepository : global::Org.Eclipse.Jgit.Lib.Repository {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/FileRepository", typeof (FileRepository));

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

		protected FileRepository (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="gitDir">GIT_DIR (the location of the repository metadata).</param>
		/// <summary>Construct a representation of a Git repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/constructor[@name='FileRepository' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe FileRepository (global::Java.IO.File gitDir) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gitDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gitDir).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (gitDir);
			}
		}

		/// <param name="gitDir">GIT_DIR (the location of the repository metadata).</param>
		/// <summary>A convenience API for <c>#FileRepository(File)</c>.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/constructor[@name='FileRepository' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe FileRepository (string gitDir) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_gitDir = JNIEnv.NewString ((string)gitDir);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_gitDir);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_gitDir);
			}
		}

		/// <param name="options">description of the repository's important paths.</param>
		/// <summary>Create a repository using the local file system.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/constructor[@name='FileRepository' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BaseRepositoryBuilder']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;)V", "")]
		public unsafe FileRepository (global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder options) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		/// <returns>the configuration of this repository</returns>
		public override unsafe global::Org.Eclipse.Jgit.Lib.StoredConfig Config
        {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lorg/eclipse/jgit/storage/file/FileBasedConfig;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Lorg/eclipse/jgit/storage/file/FileBasedConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectDatabase);
		}
#pragma warning restore 0169

		/// <returns>the object database which stores this repository's data.</returns>
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectDatabase ObjectDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/method[@name='getObjectDatabase' and count(parameter)=0]"
			[Register ("getObjectDatabase", "()Lorg/eclipse/jgit/internal/storage/file/ObjectDirectory;", "GetGetObjectDatabaseHandler")]
			get {
				const string __id = "getObjectDatabase.()Lorg/eclipse/jgit/internal/storage/file/ObjectDirectory;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ObjectDirectory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectsDirectory;
#pragma warning disable 0169
		static Delegate GetGetObjectsDirectoryHandler ()
		{
			if (cb_getObjectsDirectory == null)
				cb_getObjectsDirectory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectsDirectory);
			return cb_getObjectsDirectory;
		}

		static IntPtr n_GetObjectsDirectory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectsDirectory);
		}
#pragma warning restore 0169

		/// <returns>the directory containing the objects owned by this repository.</returns>
		public virtual unsafe global::Java.IO.File ObjectsDirectory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/method[@name='getObjectsDirectory' and count(parameter)=0]"
			[Register ("getObjectsDirectory", "()Ljava/io/File;", "GetGetObjectsDirectoryHandler")]
			get {
				const string __id = "getObjectsDirectory.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefDatabase);
		}
#pragma warning restore 0169

		/// <returns>the reference database which stores the reference namespace.</returns>
		public override unsafe global::Org.Eclipse.Jgit.Lib.RefDatabase RefDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/method[@name='getRefDatabase' and count(parameter)=0]"
			[Register ("getRefDatabase", "()Lorg/eclipse/jgit/lib/RefDatabase;", "GetGetRefDatabaseHandler")]
			get {
				const string __id = "getRefDatabase.()Lorg/eclipse/jgit/lib/RefDatabase;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create (bare);
		}
#pragma warning restore 0169

		/// <param name="bare">if true, a bare repository is created.</param>
		/// <summary>Create a new Git repository initializing the necessary files and
		/// directories.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("create", "(Z)V", "GetCreate_ZHandler")]
		public override unsafe void Create (bool bare)
		{
			const string __id = "create.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bare);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetReflogReader (refName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="refName">refName</param>
		/// <returns>a <c>ReflogReader</c> for the supplied refname, or null if the
		///         named ref does not exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/method[@name='getReflogReader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getReflogReader", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/ReflogReader;", "GetGetReflogReader_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IReflogReader GetReflogReader (string refName)
		{
			const string __id = "getReflogReader.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/ReflogReader;";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyIndexChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/method[@name='notifyIndexChanged' and count(parameter)=0]"
		[Register ("notifyIndexChanged", "()V", "GetNotifyIndexChangedHandler")]
		public override unsafe void NotifyIndexChanged ()
		{
			const string __id = "notifyIndexChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_openPack_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetOpenPack_Ljava_io_File_Handler ()
		{
			if (cb_openPack_Ljava_io_File_ == null)
				cb_openPack_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OpenPack_Ljava_io_File_);
			return cb_openPack_Ljava_io_File_;
		}

		static void n_OpenPack_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pack = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_pack, JniHandleOwnership.DoNotTransfer);
			__this.OpenPack (pack);
		}
#pragma warning restore 0169

		/// <param name="pack">path of the pack file to open.</param>
		/// <summary>Add a single existing pack to the list of available pack files.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/method[@name='openPack' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("openPack", "(Ljava/io/File;)V", "GetOpenPack_Ljava_io_File_Handler")]
		public virtual unsafe void OpenPack (global::Java.IO.File pack)
		{
			const string __id = "openPack.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pack).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pack);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScanForRepoChanges ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileRepository']/method[@name='scanForRepoChanges' and count(parameter)=0]"
		[Register ("scanForRepoChanges", "()V", "GetScanForRepoChangesHandler")]
		public override unsafe void ScanForRepoChanges ()
		{
			const string __id = "scanForRepoChanges.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
