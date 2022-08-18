using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Git repository stored entirely in the local process memory.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='InMemoryRepository']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/InMemoryRepository", DoNotGenerateAcw=true)]
	public partial class InMemoryRepository : global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepository {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/InMemoryRepository", typeof (InMemoryRepository));

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

		protected InMemoryRepository (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repoDesc">description of the repository.</param>
		/// <summary>Initialize a new in-memory repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='InMemoryRepository']/constructor[@name='InMemoryRepository' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsRepositoryDescription']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;)V", "")]
		public unsafe InMemoryRepository (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription repoDesc) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repoDesc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repoDesc).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repoDesc);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.InMemoryRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectDatabase);
		}
#pragma warning restore 0169

		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectDatabase ObjectDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='InMemoryRepository']/method[@name='getObjectDatabase' and count(parameter)=0]"
			[Register ("getObjectDatabase", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase;", "GetGetObjectDatabaseHandler")]
			get {
				const string __id = "getObjectDatabase.()Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.InMemoryRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefDatabase);
		}
#pragma warning restore 0169

		public override unsafe global::Org.Eclipse.Jgit.Lib.RefDatabase RefDatabase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='InMemoryRepository']/method[@name='getRefDatabase' and count(parameter)=0]"
			[Register ("getRefDatabase", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase;", "GetGetRefDatabaseHandler")]
			get {
				const string __id = "getRefDatabase.()Lorg/eclipse/jgit/internal/storage/dfs/DfsRefDatabase;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRefDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
