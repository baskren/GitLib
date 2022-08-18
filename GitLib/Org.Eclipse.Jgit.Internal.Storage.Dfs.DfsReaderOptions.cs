using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Options controlling how objects are read from a DFS stored repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReaderOptions']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsReaderOptions", DoNotGenerateAcw=true)]
	public partial class DfsReaderOptions : global::Java.Lang.Object {
		/// <summary>1024 (number of bytes in one kibibyte/kilobyte)</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReaderOptions']/field[@name='KiB']"
		[Register ("KiB")]
		public const int KiB = (int) 1024;

		/// <summary>1024 <c>#KiB</c> (number of bytes in one mebibyte/megabyte)</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReaderOptions']/field[@name='MiB']"
		[Register ("MiB")]
		public const int MiB = (int) 1048576;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsReaderOptions", typeof (DfsReaderOptions));

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

		protected DfsReaderOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a default reader configuration.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReaderOptions']/constructor[@name='DfsReaderOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DfsReaderOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getDeltaBaseCacheLimit;
#pragma warning disable 0169
		static Delegate GetGetDeltaBaseCacheLimitHandler ()
		{
			if (cb_getDeltaBaseCacheLimit == null)
				cb_getDeltaBaseCacheLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDeltaBaseCacheLimit);
			return cb_getDeltaBaseCacheLimit;
		}

		static int n_GetDeltaBaseCacheLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaBaseCacheLimit;
		}
#pragma warning restore 0169

		/// <returns>maximum number of bytes to hold in per-reader DeltaBaseCache.</returns>
		public virtual unsafe int DeltaBaseCacheLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReaderOptions']/method[@name='getDeltaBaseCacheLimit' and count(parameter)=0]"
			[Register ("getDeltaBaseCacheLimit", "()I", "GetGetDeltaBaseCacheLimitHandler")]
			get {
				const string __id = "getDeltaBaseCacheLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStreamFileThreshold;
#pragma warning disable 0169
		static Delegate GetGetStreamFileThresholdHandler ()
		{
			if (cb_getStreamFileThreshold == null)
				cb_getStreamFileThreshold = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStreamFileThreshold);
			return cb_getStreamFileThreshold;
		}

		static int n_GetStreamFileThreshold (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StreamFileThreshold;
		}
#pragma warning restore 0169

		/// <returns>the size threshold beyond which objects must be streamed.</returns>
		public virtual unsafe int StreamFileThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReaderOptions']/method[@name='getStreamFileThreshold' and count(parameter)=0]"
			[Register ("getStreamFileThreshold", "()I", "GetGetStreamFileThresholdHandler")]
			get {
				const string __id = "getStreamFileThreshold.()I";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReaderOptions']/method[@name='fromConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
		[Register ("fromConfig", "(Lorg/eclipse/jgit/lib/Config;)Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;", "GetFromConfig_Lorg_eclipse_jgit_lib_Config_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions FromConfig (global::Org.Eclipse.Jgit.Lib.Config rc)
		{
			const string __id = "fromConfig.(Lorg/eclipse/jgit/lib/Config;)Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rc).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (rc);
			}
		}

		static Delegate cb_setDeltaBaseCacheLimit_I;
#pragma warning disable 0169
		static Delegate GetSetDeltaBaseCacheLimit_IHandler ()
		{
			if (cb_setDeltaBaseCacheLimit_I == null)
				cb_setDeltaBaseCacheLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetDeltaBaseCacheLimit_I);
			return cb_setDeltaBaseCacheLimit_I;
		}

		static IntPtr n_SetDeltaBaseCacheLimit_I (IntPtr jnienv, IntPtr native__this, int maxBytes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDeltaBaseCacheLimit (maxBytes));
		}
#pragma warning restore 0169

		/// <param name="maxBytes">the new limit.</param>
		/// <summary>Set the maximum number of bytes in the DeltaBaseCache.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReaderOptions']/method[@name='setDeltaBaseCacheLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDeltaBaseCacheLimit", "(I)Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;", "GetSetDeltaBaseCacheLimit_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions SetDeltaBaseCacheLimit (int maxBytes)
		{
			const string __id = "setDeltaBaseCacheLimit.(I)Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxBytes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStreamFileThreshold_I;
#pragma warning disable 0169
		static Delegate GetSetStreamFileThreshold_IHandler ()
		{
			if (cb_setStreamFileThreshold_I == null)
				cb_setStreamFileThreshold_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetStreamFileThreshold_I);
			return cb_setStreamFileThreshold_I;
		}

		static IntPtr n_SetStreamFileThreshold_I (IntPtr jnienv, IntPtr native__this, int newLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStreamFileThreshold (newLimit));
		}
#pragma warning restore 0169

		/// <param name="newLimit">new byte limit for objects that must be streamed. Objects
		///            smaller than this size can be obtained as a contiguous byte
		///            array, while objects bigger than this size require using an
		///            <c>org.eclipse.jgit.lib.ObjectStream</c>.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReaderOptions']/method[@name='setStreamFileThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStreamFileThreshold", "(I)Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;", "GetSetStreamFileThreshold_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions SetStreamFileThreshold (int newLimit)
		{
			const string __id = "setStreamFileThreshold.(I)Lorg/eclipse/jgit/internal/storage/dfs/DfsReaderOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (newLimit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReaderOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
