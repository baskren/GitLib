using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Configuration parameters for <c>DfsBlockCache</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCacheConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig", DoNotGenerateAcw=true)]
	public partial class DfsBlockCacheConfig : global::Java.Lang.Object {
		/// <summary>1024 (number of bytes in one kibibyte/kilobyte)</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCacheConfig']/field[@name='KB']"
		[Register ("KB")]
		public const int Kb = (int) 1024;

		/// <summary>1024 <c>#KB</c> (number of bytes in one mebibyte/megabyte)</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCacheConfig']/field[@name='MB']"
		[Register ("MB")]
		public const int Mb = (int) 1048576;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig", typeof (DfsBlockCacheConfig));

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

		protected DfsBlockCacheConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a default configuration.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCacheConfig']/constructor[@name='DfsBlockCacheConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DfsBlockCacheConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getBlockLimit;
#pragma warning disable 0169
		static Delegate GetGetBlockLimitHandler ()
		{
			if (cb_getBlockLimit == null)
				cb_getBlockLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetBlockLimit);
			return cb_getBlockLimit;
		}

		static long n_GetBlockLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockLimit;
		}
#pragma warning restore 0169

		/// <returns>maximum number bytes of heap memory to dedicate to caching pack
		///         file data. &lt;b&gt;Default is 32 MB.&lt;/b&gt;</returns>
		public virtual unsafe long BlockLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCacheConfig']/method[@name='getBlockLimit' and count(parameter)=0]"
			[Register ("getBlockLimit", "()J", "GetGetBlockLimitHandler")]
			get {
				const string __id = "getBlockLimit.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBlockSize;
#pragma warning disable 0169
		static Delegate GetGetBlockSizeHandler ()
		{
			if (cb_getBlockSize == null)
				cb_getBlockSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBlockSize);
			return cb_getBlockSize;
		}

		static int n_GetBlockSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize;
		}
#pragma warning restore 0169

		/// <returns>size in bytes of a single window mapped or read in from the pack
		///         file. &lt;b&gt;Default is 64 KB.&lt;/b&gt;</returns>
		public virtual unsafe int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCacheConfig']/method[@name='getBlockSize' and count(parameter)=0]"
			[Register ("getBlockSize", "()I", "GetGetBlockSizeHandler")]
			get {
				const string __id = "getBlockSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_fromConfig_Lorg_eclipse_jgit_lib_Config_;
#pragma warning disable 0169
		static Delegate GetFromConfig_Lorg_eclipse_jgit_lib_Config_Handler ()
		{
			if (cb_fromConfig_Lorg_eclipse_jgit_lib_Config_ == null)
				cb_fromConfig_Lorg_eclipse_jgit_lib_Config_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FromConfig_Lorg_eclipse_jgit_lib_Config_);
			return cb_fromConfig_Lorg_eclipse_jgit_lib_Config_;
		}

		static IntPtr n_FromConfig_Lorg_eclipse_jgit_lib_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (native_rc, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromConfig (rc));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="rc">configuration to read properties from.</param>
		/// <summary>Update properties by setting fields from the configuration.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCacheConfig']/method[@name='fromConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
		[Register ("fromConfig", "(Lorg/eclipse/jgit/lib/Config;)Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig;", "GetFromConfig_Lorg_eclipse_jgit_lib_Config_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig FromConfig (global::Org.Eclipse.Jgit.Lib.Config rc)
		{
			const string __id = "fromConfig.(Lorg/eclipse/jgit/lib/Config;)Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rc).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (rc);
			}
		}

		static Delegate cb_setBlockLimit_J;
#pragma warning disable 0169
		static Delegate GetSetBlockLimit_JHandler ()
		{
			if (cb_setBlockLimit_J == null)
				cb_setBlockLimit_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetBlockLimit_J);
			return cb_setBlockLimit_J;
		}

		static IntPtr n_SetBlockLimit_J (IntPtr jnienv, IntPtr native__this, long newLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBlockLimit (newLimit));
		}
#pragma warning restore 0169

		/// <param name="newLimit">maximum number bytes of heap memory to dedicate to caching
		///            pack file data.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCacheConfig']/method[@name='setBlockLimit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setBlockLimit", "(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig;", "GetSetBlockLimit_JHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig SetBlockLimit (long newLimit)
		{
			const string __id = "setBlockLimit.(J)Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (newLimit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBlockSize_I;
#pragma warning disable 0169
		static Delegate GetSetBlockSize_IHandler ()
		{
			if (cb_setBlockSize_I == null)
				cb_setBlockSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetBlockSize_I);
			return cb_setBlockSize_I;
		}

		static IntPtr n_SetBlockSize_I (IntPtr jnienv, IntPtr native__this, int newSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBlockSize (newSize));
		}
#pragma warning restore 0169

		/// <param name="newSize">size in bytes of a single window read in from the pack file.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsBlockCacheConfig']/method[@name='setBlockSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBlockSize", "(I)Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig;", "GetSetBlockSize_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig SetBlockSize (int newSize)
		{
			const string __id = "setBlockSize.(I)Lorg/eclipse/jgit/internal/storage/dfs/DfsBlockCacheConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (newSize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsBlockCacheConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
