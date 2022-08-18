using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <param name="&lt;B&gt;">type of the builder class.</param>
	/// <param name="&lt;R&gt;">type of the repository class.</param>
	/// <summary>Constructs a <c>DfsRepository</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepositoryBuilder']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"B extends org.eclipse.jgit.internal.storage.dfs.DfsRepositoryBuilder", "R extends org.eclipse.jgit.internal.storage.dfs.DfsRepository"})]
	public abstract partial class DfsRepositoryBuilder : global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder", typeof (DfsRepositoryBuilder));

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

		protected DfsRepositoryBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepositoryBuilder']/constructor[@name='DfsRepositoryBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DfsRepositoryBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReaderOptions);
		}
#pragma warning restore 0169

		/// <returns>options used by readers accessing the repository.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions ReaderOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepositoryBuilder']/method[@name='getReaderOptions' and count(parameter)=0]"
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

		static Delegate cb_getRepositoryDescription;
#pragma warning disable 0169
		static Delegate GetGetRepositoryDescriptionHandler ()
		{
			if (cb_getRepositoryDescription == null)
				cb_getRepositoryDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepositoryDescription);
			return cb_getRepositoryDescription;
		}

		static IntPtr n_GetRepositoryDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RepositoryDescription);
		}
#pragma warning restore 0169

		/// <returns>a description of the repository.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription RepositoryDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepositoryBuilder']/method[@name='getRepositoryDescription' and count(parameter)=0]"
			[Register ("getRepositoryDescription", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;", "GetGetRepositoryDescriptionHandler")]
			get {
				const string __id = "getRepositoryDescription.()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		/// <summary>Create a repository matching the configuration in this builder.</summary>
		/// <returns>a repository matching this configuration.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepositoryBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;", "GetBuildHandler")]
		public abstract global::Java.Lang.Object Build ();

		static Delegate cb_setReaderOptions_Lorg_eclipse_jgit_internal_storage_dfs_DfsReaderOptions_;
#pragma warning disable 0169
		static Delegate GetSetReaderOptions_Lorg_eclipse_jgit_internal_storage_dfs_DfsReaderOptions_Handler ()
		{
			if (cb_setReaderOptions_Lorg_eclipse_jgit_internal_storage_dfs_DfsReaderOptions_ == null)
				cb_setReaderOptions_Lorg_eclipse_jgit_internal_storage_dfs_DfsReaderOptions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetReaderOptions_Lorg_eclipse_jgit_internal_storage_dfs_DfsReaderOptions_);
			return cb_setReaderOptions_Lorg_eclipse_jgit_internal_storage_dfs_DfsReaderOptions_;
		}

		static IntPtr n_SetReaderOptions_Lorg_eclipse_jgit_internal_storage_dfs_DfsReaderOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_opt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var opt = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (native_opt, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReaderOptions (opt));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="opt">new reader options object.</param>
		/// <summary>Set the reader options.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepositoryBuilder']/method[@name='setReaderOptions' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsReaderOptions']]"
		[Register ("setReaderOptions", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;)Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder;", "GetSetReaderOptions_Lorg_eclipse_jgit_internal_storage_dfs_DfsReaderOptions_Handler")]
		public virtual unsafe global::Java.Lang.Object SetReaderOptions (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions opt)
		{
			const string __id = "setReaderOptions.(Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;)Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((opt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) opt).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (opt);
			}
		}

		static Delegate cb_setRepositoryDescription_Lorg_eclipse_jgit_internal_storage_dfs_DfsRepositoryDescription_;
#pragma warning disable 0169
		static Delegate GetSetRepositoryDescription_Lorg_eclipse_jgit_internal_storage_dfs_DfsRepositoryDescription_Handler ()
		{
			if (cb_setRepositoryDescription_Lorg_eclipse_jgit_internal_storage_dfs_DfsRepositoryDescription_ == null)
				cb_setRepositoryDescription_Lorg_eclipse_jgit_internal_storage_dfs_DfsRepositoryDescription_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRepositoryDescription_Lorg_eclipse_jgit_internal_storage_dfs_DfsRepositoryDescription_);
			return cb_setRepositoryDescription_Lorg_eclipse_jgit_internal_storage_dfs_DfsRepositoryDescription_;
		}

		static IntPtr n_SetRepositoryDescription_Lorg_eclipse_jgit_internal_storage_dfs_DfsRepositoryDescription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_desc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription> (native_desc, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRepositoryDescription (desc));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="desc">new repository description object.</param>
		/// <summary>Set the repository description.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepositoryBuilder']/method[@name='setRepositoryDescription' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsRepositoryDescription']]"
		[Register ("setRepositoryDescription", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;)Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder;", "GetSetRepositoryDescription_Lorg_eclipse_jgit_internal_storage_dfs_DfsRepositoryDescription_Handler")]
		public virtual unsafe global::Java.Lang.Object SetRepositoryDescription (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsRepositoryDescription desc)
		{
			const string __id = "setRepositoryDescription.(Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryDescription;)Lorg/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((desc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) desc).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (desc);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder", DoNotGenerateAcw=true)]
	internal partial class DfsRepositoryBuilderInvoker : DfsRepositoryBuilder {
		public DfsRepositoryBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsRepositoryBuilder", typeof (DfsRepositoryBuilderInvoker));

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

		/// <summary>Create a repository matching the configuration in this builder.</summary>
		/// <returns>a repository matching this configuration.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsRepositoryBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;", "GetBuildHandler")]
		public override unsafe global::Java.Lang.Object Build ()
		{
			const string __id = "build.()Lorg/eclipse/jgit/internal/storage/dfs/DfsRepository;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
