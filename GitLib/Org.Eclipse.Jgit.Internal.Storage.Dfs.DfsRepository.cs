using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>A Git repository on a DFS.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsRepository", DoNotGenerateAcw=true)]
	public abstract partial class DfsRepository : global::Org.Eclipse.Jgit.Lib.Repository {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsRepository", typeof (DfsRepository));

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

		protected DfsRepository (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="builder">description of the repository.</param>
		/// <summary>Initialize a DFS repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/constructor[@name='DfsRepository' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsRepositoryBuilder']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder;)V", "")]
		protected unsafe DfsRepository (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryBuilder builder) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (builder);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		public override unsafe global::Org.Eclipse.Jgit.Lib.StoredConfig Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lorg/eclipse/jgit/lib/StoredConfig;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Lorg/eclipse/jgit/lib/StoredConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.StoredConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Description);
		}
#pragma warning restore 0169

		/// <returns>a description of this repository.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;", "GetGetDescriptionHandler")]
			get {
				const string __id = "getDescription.()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// skipped generating property ObjectDatabase because its Java method declaration is variant that we cannot represent in C#

		// skipped generating property RefDatabase because its Java method declaration is variant that we cannot represent in C#

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create (bare);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_exists;
#pragma warning disable 0169
		static Delegate GetExistsHandler ()
		{
			if (cb_exists == null)
				cb_exists = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Exists);
			return cb_exists;
		}

		static bool n_Exists (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Exists ();
		}
#pragma warning restore 0169

		/// <summary>Check if the repository already exists.</summary>
		/// <returns>true if the repository exists; false if it is new.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/method[@name='exists' and count(parameter)=0]"
		[Register ("exists", "()Z", "GetExistsHandler")]
		public virtual unsafe bool Exists ()
		{
			const string __id = "exists.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetReflogReader (refName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/method[@name='getReflogReader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyIndexChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/method[@name='notifyIndexChanged' and count(parameter)=0]"
		[Register ("notifyIndexChanged", "()V", "GetNotifyIndexChangedHandler")]
		public override unsafe void NotifyIndexChanged ()
		{
			const string __id = "notifyIndexChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScanForRepoChanges ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/method[@name='scanForRepoChanges' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsRepository", DoNotGenerateAcw=true)]
	internal partial class DfsRepositoryInvoker : DfsRepository {
		public DfsRepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsRepository", typeof (DfsRepositoryInvoker));

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

		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectDatabase ObjectDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/method[@name='getObjectDatabase' and count(parameter)=0]"
			[Register ("getObjectDatabase", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase;", "GetGetObjectDatabaseHandler")]
			get {
				const string __id = "getObjectDatabase.()Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Org.Eclipse.Jgit.Lib.RefDatabase RefDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepository']/method[@name='getRefDatabase' and count(parameter)=0]"
			[Register ("getRefDatabase", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase;", "GetGetRefDatabaseHandler")]
			get {
				const string __id = "getRefDatabase.()Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
