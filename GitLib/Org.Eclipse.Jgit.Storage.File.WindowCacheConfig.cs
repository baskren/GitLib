using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Storage.File {

	/// <summary>Configuration parameters for JVM-wide buffer cache used by JGit.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/storage/file/WindowCacheConfig", DoNotGenerateAcw=true)]
	public partial class WindowCacheConfig : global::Java.Lang.Object {
		/// <summary>1024 (number of bytes in one kibibyte/kilobyte)</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/field[@name='KB']"
		[Register ("KB")]
		public const int Kb = (int) 1024;

		/// <summary>1024 <c>#KB</c> (number of bytes in one mebibyte/megabyte)</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/field[@name='MB']"
		[Register ("MB")]
		public const int Mb = (int) 1048576;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/storage/file/WindowCacheConfig", typeof (WindowCacheConfig));

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

		protected WindowCacheConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a default configuration.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/constructor[@name='WindowCacheConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WindowCacheConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaBaseCacheLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setDeltaBaseCacheLimit_I;
#pragma warning disable 0169
		static Delegate GetSetDeltaBaseCacheLimit_IHandler ()
		{
			if (cb_setDeltaBaseCacheLimit_I == null)
				cb_setDeltaBaseCacheLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDeltaBaseCacheLimit_I);
			return cb_setDeltaBaseCacheLimit_I;
		}

		static void n_SetDeltaBaseCacheLimit_I (IntPtr jnienv, IntPtr native__this, int newLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeltaBaseCacheLimit = newLimit;
		}
#pragma warning restore 0169

		/// <returns>maximum number of bytes to cache in delta base cache for
		///         inflated, recently accessed objects, without delta chains.
		///         &lt;b&gt;Default 10 MB.&lt;/b&gt;</returns>
		/// <param name="newLimit">maximum number of bytes to cache in delta base cache for
		///            inflated, recently accessed objects, without delta chains.</param>
		public virtual unsafe int DeltaBaseCacheLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='getDeltaBaseCacheLimit' and count(parameter)=0]"
			[Register ("getDeltaBaseCacheLimit", "()I", "GetGetDeltaBaseCacheLimitHandler")]
			get {
				const string __id = "getDeltaBaseCacheLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='setDeltaBaseCacheLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDeltaBaseCacheLimit", "(I)V", "GetSetDeltaBaseCacheLimit_IHandler")]
			set {
				const string __id = "setDeltaBaseCacheLimit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPackedGitLimit;
#pragma warning disable 0169
		static Delegate GetGetPackedGitLimitHandler ()
		{
			if (cb_getPackedGitLimit == null)
				cb_getPackedGitLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPackedGitLimit);
			return cb_getPackedGitLimit;
		}

		static long n_GetPackedGitLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PackedGitLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setPackedGitLimit_J;
#pragma warning disable 0169
		static Delegate GetSetPackedGitLimit_JHandler ()
		{
			if (cb_setPackedGitLimit_J == null)
				cb_setPackedGitLimit_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetPackedGitLimit_J);
			return cb_setPackedGitLimit_J;
		}

		static void n_SetPackedGitLimit_J (IntPtr jnienv, IntPtr native__this, long newLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PackedGitLimit = newLimit;
		}
#pragma warning restore 0169

		/// <returns>maximum number bytes of heap memory to dedicate to caching pack
		///         file data. &lt;b&gt;Default is 10 MB.&lt;/b&gt;</returns>
		/// <param name="newLimit">maximum number bytes of heap memory to dedicate to caching
		///            pack file data.</param>
		public virtual unsafe long PackedGitLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='getPackedGitLimit' and count(parameter)=0]"
			[Register ("getPackedGitLimit", "()J", "GetGetPackedGitLimitHandler")]
			get {
				const string __id = "getPackedGitLimit.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='setPackedGitLimit' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setPackedGitLimit", "(J)V", "GetSetPackedGitLimit_JHandler")]
			set {
				const string __id = "setPackedGitLimit.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isPackedGitMMAP;
#pragma warning disable 0169
		static Delegate GetIsPackedGitMMAPHandler ()
		{
			if (cb_isPackedGitMMAP == null)
				cb_isPackedGitMMAP = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPackedGitMMAP);
			return cb_isPackedGitMMAP;
		}

		static bool n_IsPackedGitMMAP (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PackedGitMMAP;
		}
#pragma warning restore 0169

		static Delegate cb_setPackedGitMMAP_Z;
#pragma warning disable 0169
		static Delegate GetSetPackedGitMMAP_ZHandler ()
		{
			if (cb_setPackedGitMMAP_Z == null)
				cb_setPackedGitMMAP_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPackedGitMMAP_Z);
			return cb_setPackedGitMMAP_Z;
		}

		static void n_SetPackedGitMMAP_Z (IntPtr jnienv, IntPtr native__this, bool usemmap)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PackedGitMMAP = usemmap;
		}
#pragma warning restore 0169

		/// <returns>true enables use of Java NIO virtual memory mapping for windows;
		///         false reads entire window into a byte[] with standard read calls.
		///         &lt;b&gt;Default false.&lt;/b&gt;</returns>
		/// <param name="usemmap">true enables use of Java NIO virtual memory mapping for
		///            windows; false reads entire window into a byte[] with standard
		///            read calls.</param>
		public virtual unsafe bool PackedGitMMAP {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='isPackedGitMMAP' and count(parameter)=0]"
			[Register ("isPackedGitMMAP", "()Z", "GetIsPackedGitMMAPHandler")]
			get {
				const string __id = "isPackedGitMMAP.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='setPackedGitMMAP' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPackedGitMMAP", "(Z)V", "GetSetPackedGitMMAP_ZHandler")]
			set {
				const string __id = "setPackedGitMMAP.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPackedGitOpenFiles;
#pragma warning disable 0169
		static Delegate GetGetPackedGitOpenFilesHandler ()
		{
			if (cb_getPackedGitOpenFiles == null)
				cb_getPackedGitOpenFiles = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPackedGitOpenFiles);
			return cb_getPackedGitOpenFiles;
		}

		static int n_GetPackedGitOpenFiles (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PackedGitOpenFiles;
		}
#pragma warning restore 0169

		static Delegate cb_setPackedGitOpenFiles_I;
#pragma warning disable 0169
		static Delegate GetSetPackedGitOpenFiles_IHandler ()
		{
			if (cb_setPackedGitOpenFiles_I == null)
				cb_setPackedGitOpenFiles_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPackedGitOpenFiles_I);
			return cb_setPackedGitOpenFiles_I;
		}

		static void n_SetPackedGitOpenFiles_I (IntPtr jnienv, IntPtr native__this, int fdLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PackedGitOpenFiles = fdLimit;
		}
#pragma warning restore 0169

		/// <returns>maximum number of streams to open at a time. Open packs count
		///         against the process limits. &lt;b&gt;Default is 128.&lt;/b&gt;</returns>
		/// <param name="fdLimit">maximum number of streams to open at a time. Open packs count
		///            against the process limits</param>
		public virtual unsafe int PackedGitOpenFiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='getPackedGitOpenFiles' and count(parameter)=0]"
			[Register ("getPackedGitOpenFiles", "()I", "GetGetPackedGitOpenFilesHandler")]
			get {
				const string __id = "getPackedGitOpenFiles.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='setPackedGitOpenFiles' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPackedGitOpenFiles", "(I)V", "GetSetPackedGitOpenFiles_IHandler")]
			set {
				const string __id = "setPackedGitOpenFiles.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPackedGitWindowSize;
#pragma warning disable 0169
		static Delegate GetGetPackedGitWindowSizeHandler ()
		{
			if (cb_getPackedGitWindowSize == null)
				cb_getPackedGitWindowSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPackedGitWindowSize);
			return cb_getPackedGitWindowSize;
		}

		static int n_GetPackedGitWindowSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PackedGitWindowSize;
		}
#pragma warning restore 0169

		static Delegate cb_setPackedGitWindowSize_I;
#pragma warning disable 0169
		static Delegate GetSetPackedGitWindowSize_IHandler ()
		{
			if (cb_setPackedGitWindowSize_I == null)
				cb_setPackedGitWindowSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPackedGitWindowSize_I);
			return cb_setPackedGitWindowSize_I;
		}

		static void n_SetPackedGitWindowSize_I (IntPtr jnienv, IntPtr native__this, int newSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PackedGitWindowSize = newSize;
		}
#pragma warning restore 0169

		/// <returns>size in bytes of a single window mapped or read in from the pack
		///         file. &lt;b&gt;Default is 8 KB.&lt;/b&gt;</returns>
		/// <param name="newSize">size in bytes of a single window read in from the pack file.</param>
		public virtual unsafe int PackedGitWindowSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='getPackedGitWindowSize' and count(parameter)=0]"
			[Register ("getPackedGitWindowSize", "()I", "GetGetPackedGitWindowSizeHandler")]
			get {
				const string __id = "getPackedGitWindowSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='setPackedGitWindowSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPackedGitWindowSize", "(I)V", "GetSetPackedGitWindowSize_IHandler")]
			set {
				const string __id = "setPackedGitWindowSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StreamFileThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setStreamFileThreshold_I;
#pragma warning disable 0169
		static Delegate GetSetStreamFileThreshold_IHandler ()
		{
			if (cb_setStreamFileThreshold_I == null)
				cb_setStreamFileThreshold_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStreamFileThreshold_I);
			return cb_setStreamFileThreshold_I;
		}

		static void n_SetStreamFileThreshold_I (IntPtr jnienv, IntPtr native__this, int newLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StreamFileThreshold = newLimit;
		}
#pragma warning restore 0169

		/// <returns>the size threshold beyond which objects must be streamed.</returns>
		/// <param name="newLimit">new byte limit for objects that must be streamed. Objects
		///            smaller than this size can be obtained as a contiguous byte
		///            array, while objects bigger than this size require using an
		///            <c>org.eclipse.jgit.lib.ObjectStream</c>.</param>
		public virtual unsafe int StreamFileThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='getStreamFileThreshold' and count(parameter)=0]"
			[Register ("getStreamFileThreshold", "()I", "GetGetStreamFileThresholdHandler")]
			get {
				const string __id = "getStreamFileThreshold.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='setStreamFileThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStreamFileThreshold", "(I)V", "GetSetStreamFileThreshold_IHandler")]
			set {
				const string __id = "setStreamFileThreshold.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (native_rc, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromConfig (rc));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="rc">configuration to read properties from.</param>
		/// <summary>Update properties by setting fields from the configuration.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='fromConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
		[Register ("fromConfig", "(Lorg/eclipse/jgit/lib/Config;)Lorg/eclipse/jgit/storage/file/WindowCacheConfig;", "GetFromConfig_Lorg_eclipse_jgit_lib_Config_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig FromConfig (global::Org.Eclipse.Jgit.Lib.Config rc)
		{
			const string __id = "fromConfig.(Lorg/eclipse/jgit/lib/Config;)Lorg/eclipse/jgit/storage/file/WindowCacheConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rc).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (rc);
			}
		}

		static Delegate cb_install;
#pragma warning disable 0169
		static Delegate GetInstallHandler ()
		{
			if (cb_install == null)
				cb_install = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Install);
			return cb_install;
		}

		static void n_Install (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Install ();
		}
#pragma warning restore 0169

		/// <summary>Install this configuration as the live settings.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='WindowCacheConfig']/method[@name='install' and count(parameter)=0]"
		[Register ("install", "()V", "GetInstallHandler")]
		public virtual unsafe void Install ()
		{
			const string __id = "install.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
