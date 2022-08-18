using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Storage.Pack {

	/// <summary>Configuration used by a pack writer when constructing the stream.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/storage/pack/PackConfig", DoNotGenerateAcw=true)]
	public partial class PackConfig : global::Java.Lang.Object {
		/// <summary>Default big file threshold: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_BIG_FILE_THRESHOLD']"
		[Register ("DEFAULT_BIG_FILE_THRESHOLD")]
		public const int DefaultBigFileThreshold = (int) 52428800;

		/// <summary>Default value of the build bitmaps option: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_BUILD_BITMAPS']"
		[Register ("DEFAULT_BUILD_BITMAPS")]
		public const bool DefaultBuildBitmaps = (bool) true;

		/// <summary>Default value of delta base as offset option: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_DELTA_BASE_AS_OFFSET']"
		[Register ("DEFAULT_DELTA_BASE_AS_OFFSET")]
		public const bool DefaultDeltaBaseAsOffset = (bool) false;

		/// <summary>Default delta cache limit: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_DELTA_CACHE_LIMIT']"
		[Register ("DEFAULT_DELTA_CACHE_LIMIT")]
		public const int DefaultDeltaCacheLimit = (int) 100;

		/// <summary>Default delta cache size: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_DELTA_CACHE_SIZE']"
		[Register ("DEFAULT_DELTA_CACHE_SIZE")]
		public const long DefaultDeltaCacheSize = (long) 52428800;

		/// <summary>Default value of delta compress option: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_DELTA_COMPRESS']"
		[Register ("DEFAULT_DELTA_COMPRESS")]
		public const bool DefaultDeltaCompress = (bool) true;

		/// <summary>Default window size during packing: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_DELTA_SEARCH_WINDOW_SIZE']"
		[Register ("DEFAULT_DELTA_SEARCH_WINDOW_SIZE")]
		public const int DefaultDeltaSearchWindowSize = (int) 10;

		/// <summary>Default index version: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_INDEX_VERSION']"
		[Register ("DEFAULT_INDEX_VERSION")]
		public const int DefaultIndexVersion = (int) 2;

		/// <summary>Default value of maximum delta chain depth: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_MAX_DELTA_DEPTH']"
		[Register ("DEFAULT_MAX_DELTA_DEPTH")]
		public const int DefaultMaxDeltaDepth = (int) 50;

		/// <summary>Default value of deltas reuse option: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_REUSE_DELTAS']"
		[Register ("DEFAULT_REUSE_DELTAS")]
		public const bool DefaultReuseDeltas = (bool) true;

		/// <summary>Default value of objects reuse option: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/field[@name='DEFAULT_REUSE_OBJECTS']"
		[Register ("DEFAULT_REUSE_OBJECTS")]
		public const bool DefaultReuseObjects = (bool) true;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/storage/pack/PackConfig", typeof (PackConfig));

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

		protected PackConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a default configuration.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/constructor[@name='PackConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PackConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="cfg">the source to read settings from. The source is not retained
		///            by the new configuration, instead its settings are copied
		///            during the constructor.</param>
		/// <summary>Create a configuration honoring settings in a <c>Config</c>.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/constructor[@name='PackConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Config;)V", "")]
		public unsafe PackConfig (global::Org.Eclipse.Jgit.Lib.Config cfg) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Config;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cfg);
			}
		}

		/// <param name="db">the repository to read settings from. The repository is not
		///            retained by the new configuration, instead its settings are
		///            copied during the constructor.</param>
		/// <summary>Create a configuration honoring the repository's settings.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/constructor[@name='PackConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe PackConfig (global::Org.Eclipse.Jgit.Lib.Repository db) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

		/// <param name="cfg">the source configuration to copy from.</param>
		/// <summary>Copy an existing configuration to a new instance.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/constructor[@name='PackConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.storage.pack.PackConfig']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/storage/pack/PackConfig;)V", "")]
		public unsafe PackConfig (global::Org.Eclipse.Jgit.Storage.Pack.PackConfig cfg) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/storage/pack/PackConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cfg);
			}
		}

		static Delegate cb_getBigFileThreshold;
#pragma warning disable 0169
		static Delegate GetGetBigFileThresholdHandler ()
		{
			if (cb_getBigFileThreshold == null)
				cb_getBigFileThreshold = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBigFileThreshold);
			return cb_getBigFileThreshold;
		}

		static int n_GetBigFileThreshold (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BigFileThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setBigFileThreshold_I;
#pragma warning disable 0169
		static Delegate GetSetBigFileThreshold_IHandler ()
		{
			if (cb_setBigFileThreshold_I == null)
				cb_setBigFileThreshold_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBigFileThreshold_I);
			return cb_setBigFileThreshold_I;
		}

		static void n_SetBigFileThreshold_I (IntPtr jnienv, IntPtr native__this, int bigFileThreshold)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BigFileThreshold = bigFileThreshold;
		}
#pragma warning restore 0169

		/// <summary>Get the maximum file size that will be delta compressed. -or- Set the maximum file size that should be considered for deltas.</summary>
		/// <returns>the configured big file threshold.</returns>
		/// <param name="bigFileThreshold">the limit, in bytes.</param>
		public virtual unsafe int BigFileThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getBigFileThreshold' and count(parameter)=0]"
			[Register ("getBigFileThreshold", "()I", "GetGetBigFileThresholdHandler")]
			get {
				const string __id = "getBigFileThreshold.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setBigFileThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBigFileThreshold", "(I)V", "GetSetBigFileThreshold_IHandler")]
			set {
				const string __id = "setBigFileThreshold.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isBuildBitmaps;
#pragma warning disable 0169
		static Delegate GetIsBuildBitmapsHandler ()
		{
			if (cb_isBuildBitmaps == null)
				cb_isBuildBitmaps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBuildBitmaps);
			return cb_isBuildBitmaps;
		}

		static bool n_IsBuildBitmaps (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BuildBitmaps;
		}
#pragma warning restore 0169

		static Delegate cb_setBuildBitmaps_Z;
#pragma warning disable 0169
		static Delegate GetSetBuildBitmaps_ZHandler ()
		{
			if (cb_setBuildBitmaps_Z == null)
				cb_setBuildBitmaps_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetBuildBitmaps_Z);
			return cb_setBuildBitmaps_Z;
		}

		static void n_SetBuildBitmaps_Z (IntPtr jnienv, IntPtr native__this, bool buildBitmaps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BuildBitmaps = buildBitmaps;
		}
#pragma warning restore 0169

		/// <summary>True if writer is allowed to build bitmaps for indexes. -or- Set writer to allow building bitmaps for supported pack files.</summary>
		/// <returns>true if delta base is the writer can choose to output an index
		///         with bitmaps.</returns>
		/// <param name="buildBitmaps">boolean indicating whether bitmaps may be included in the
		///            index.</param>
		public virtual unsafe bool BuildBitmaps {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='isBuildBitmaps' and count(parameter)=0]"
			[Register ("isBuildBitmaps", "()Z", "GetIsBuildBitmapsHandler")]
			get {
				const string __id = "isBuildBitmaps.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setBuildBitmaps' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBuildBitmaps", "(Z)V", "GetSetBuildBitmaps_ZHandler")]
			set {
				const string __id = "setBuildBitmaps.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCompressionLevel;
#pragma warning disable 0169
		static Delegate GetGetCompressionLevelHandler ()
		{
			if (cb_getCompressionLevel == null)
				cb_getCompressionLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCompressionLevel);
			return cb_getCompressionLevel;
		}

		static int n_GetCompressionLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompressionLevel;
		}
#pragma warning restore 0169

		static Delegate cb_setCompressionLevel_I;
#pragma warning disable 0169
		static Delegate GetSetCompressionLevel_IHandler ()
		{
			if (cb_setCompressionLevel_I == null)
				cb_setCompressionLevel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCompressionLevel_I);
			return cb_setCompressionLevel_I;
		}

		static void n_SetCompressionLevel_I (IntPtr jnienv, IntPtr native__this, int level)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompressionLevel = level;
		}
#pragma warning restore 0169

		/// <summary>Get the compression level applied to objects in the pack. -or- Set the compression level applied to objects in the pack.</summary>
		/// <returns>current compression level, see <c>java.util.zip.Deflater</c>.</returns>
		/// <param name="level">compression level, must be a valid level recognized by the
		///            <c>java.util.zip.Deflater</c> class.</param>
		public virtual unsafe int CompressionLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getCompressionLevel' and count(parameter)=0]"
			[Register ("getCompressionLevel", "()I", "GetGetCompressionLevelHandler")]
			get {
				const string __id = "getCompressionLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setCompressionLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCompressionLevel", "(I)V", "GetSetCompressionLevel_IHandler")]
			set {
				const string __id = "setCompressionLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCutDeltaChains;
#pragma warning disable 0169
		static Delegate GetGetCutDeltaChainsHandler ()
		{
			if (cb_getCutDeltaChains == null)
				cb_getCutDeltaChains = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetCutDeltaChains);
			return cb_getCutDeltaChains;
		}

		static bool n_GetCutDeltaChains (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CutDeltaChains;
		}
#pragma warning restore 0169

		static Delegate cb_setCutDeltaChains_Z;
#pragma warning disable 0169
		static Delegate GetSetCutDeltaChains_ZHandler ()
		{
			if (cb_setCutDeltaChains_Z == null)
				cb_setCutDeltaChains_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCutDeltaChains_Z);
			return cb_setCutDeltaChains_Z;
		}

		static void n_SetCutDeltaChains_Z (IntPtr jnienv, IntPtr native__this, bool cut)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CutDeltaChains = cut;
		}
#pragma warning restore 0169

		/// <returns>true if existing delta chains should be cut at
		///         <c>#getMaxDeltaDepth()</c>. Default is false, allowing existing
		///         chains to be of any length.</returns>
		/// <summary>Enable cutting existing delta chains at <c>#getMaxDeltaDepth()</c>.</summary>
		/// <param name="cut">true to cut existing chains.</param>
		public virtual unsafe bool CutDeltaChains {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getCutDeltaChains' and count(parameter)=0]"
			[Register ("getCutDeltaChains", "()Z", "GetGetCutDeltaChainsHandler")]
			get {
				const string __id = "getCutDeltaChains.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setCutDeltaChains' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCutDeltaChains", "(Z)V", "GetSetCutDeltaChains_ZHandler")]
			set {
				const string __id = "setCutDeltaChains.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDeltaBaseAsOffset;
#pragma warning disable 0169
		static Delegate GetIsDeltaBaseAsOffsetHandler ()
		{
			if (cb_isDeltaBaseAsOffset == null)
				cb_isDeltaBaseAsOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDeltaBaseAsOffset);
			return cb_isDeltaBaseAsOffset;
		}

		static bool n_IsDeltaBaseAsOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaBaseAsOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setDeltaBaseAsOffset_Z;
#pragma warning disable 0169
		static Delegate GetSetDeltaBaseAsOffset_ZHandler ()
		{
			if (cb_setDeltaBaseAsOffset_Z == null)
				cb_setDeltaBaseAsOffset_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDeltaBaseAsOffset_Z);
			return cb_setDeltaBaseAsOffset_Z;
		}

		static void n_SetDeltaBaseAsOffset_Z (IntPtr jnienv, IntPtr native__this, bool deltaBaseAsOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeltaBaseAsOffset = deltaBaseAsOffset;
		}
#pragma warning restore 0169

		/// <summary>True if writer can use offsets to point to a delta base. -or- Set writer delta base format.</summary>
		/// <returns>true if delta base is stored as an offset; false if it is stored
		///         as an ObjectId.</returns>
		/// <param name="deltaBaseAsOffset">boolean indicating whether delta base can be stored as an
		///            offset.</param>
		public virtual unsafe bool DeltaBaseAsOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='isDeltaBaseAsOffset' and count(parameter)=0]"
			[Register ("isDeltaBaseAsOffset", "()Z", "GetIsDeltaBaseAsOffsetHandler")]
			get {
				const string __id = "isDeltaBaseAsOffset.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setDeltaBaseAsOffset' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDeltaBaseAsOffset", "(Z)V", "GetSetDeltaBaseAsOffset_ZHandler")]
			set {
				const string __id = "setDeltaBaseAsOffset.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeltaCacheLimit;
#pragma warning disable 0169
		static Delegate GetGetDeltaCacheLimitHandler ()
		{
			if (cb_getDeltaCacheLimit == null)
				cb_getDeltaCacheLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDeltaCacheLimit);
			return cb_getDeltaCacheLimit;
		}

		static int n_GetDeltaCacheLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaCacheLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setDeltaCacheLimit_I;
#pragma warning disable 0169
		static Delegate GetSetDeltaCacheLimit_IHandler ()
		{
			if (cb_setDeltaCacheLimit_I == null)
				cb_setDeltaCacheLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDeltaCacheLimit_I);
			return cb_setDeltaCacheLimit_I;
		}

		static void n_SetDeltaCacheLimit_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeltaCacheLimit = size;
		}
#pragma warning restore 0169

		/// <summary>Maximum size in bytes of a delta to cache. -or- Set the maximum size of a delta that should be cached.</summary>
		/// <returns>maximum size (in bytes) of a delta that should be cached.</returns>
		/// <param name="size">maximum size (in bytes) of a delta to be cached.</param>
		public virtual unsafe int DeltaCacheLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getDeltaCacheLimit' and count(parameter)=0]"
			[Register ("getDeltaCacheLimit", "()I", "GetGetDeltaCacheLimitHandler")]
			get {
				const string __id = "getDeltaCacheLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setDeltaCacheLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDeltaCacheLimit", "(I)V", "GetSetDeltaCacheLimit_IHandler")]
			set {
				const string __id = "setDeltaCacheLimit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeltaCacheSize;
#pragma warning disable 0169
		static Delegate GetGetDeltaCacheSizeHandler ()
		{
			if (cb_getDeltaCacheSize == null)
				cb_getDeltaCacheSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDeltaCacheSize);
			return cb_getDeltaCacheSize;
		}

		static long n_GetDeltaCacheSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaCacheSize;
		}
#pragma warning restore 0169

		static Delegate cb_setDeltaCacheSize_J;
#pragma warning disable 0169
		static Delegate GetSetDeltaCacheSize_JHandler ()
		{
			if (cb_setDeltaCacheSize_J == null)
				cb_setDeltaCacheSize_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetDeltaCacheSize_J);
			return cb_setDeltaCacheSize_J;
		}

		static void n_SetDeltaCacheSize_J (IntPtr jnienv, IntPtr native__this, long size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeltaCacheSize = size;
		}
#pragma warning restore 0169

		/// <summary>Get the size of the in-memory delta cache. -or- Set the maximum number of bytes of delta data to cache.</summary>
		/// <returns>maximum number of bytes worth of delta data to cache in memory.
		///         If 0 the cache is infinite in size (up to the JVM heap limit
		///         anyway). A very tiny size such as 1 indicates the cache is
		///         effectively disabled.</returns>
		/// <param name="size">number of bytes to cache. Set to 0 to enable an infinite
		///            cache, set to 1 (an impossible size for any delta) to disable
		///            the cache.</param>
		public virtual unsafe long DeltaCacheSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getDeltaCacheSize' and count(parameter)=0]"
			[Register ("getDeltaCacheSize", "()J", "GetGetDeltaCacheSizeHandler")]
			get {
				const string __id = "getDeltaCacheSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setDeltaCacheSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDeltaCacheSize", "(J)V", "GetSetDeltaCacheSize_JHandler")]
			set {
				const string __id = "setDeltaCacheSize.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDeltaCompress;
#pragma warning disable 0169
		static Delegate GetIsDeltaCompressHandler ()
		{
			if (cb_isDeltaCompress == null)
				cb_isDeltaCompress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDeltaCompress);
			return cb_isDeltaCompress;
		}

		static bool n_IsDeltaCompress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaCompress;
		}
#pragma warning restore 0169

		static Delegate cb_setDeltaCompress_Z;
#pragma warning disable 0169
		static Delegate GetSetDeltaCompress_ZHandler ()
		{
			if (cb_setDeltaCompress_Z == null)
				cb_setDeltaCompress_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDeltaCompress_Z);
			return cb_setDeltaCompress_Z;
		}

		static void n_SetDeltaCompress_Z (IntPtr jnienv, IntPtr native__this, bool deltaCompress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeltaCompress = deltaCompress;
		}
#pragma warning restore 0169

		/// <summary>Check whether the writer will create new deltas on the fly. -or- Set whether or not the writer will create new deltas on the fly.</summary>
		/// <returns>true if the writer will create a new delta when either
		///         <c>#isReuseDeltas()</c> is false, or no suitable delta is
		///         available for reuse.</returns>
		/// <param name="deltaCompress">true to create deltas when <c>#isReuseDeltas()</c> is false,
		///            or when a suitable delta isn't available for reuse. Set to
		///            false to write whole objects instead.</param>
		public virtual unsafe bool DeltaCompress {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='isDeltaCompress' and count(parameter)=0]"
			[Register ("isDeltaCompress", "()Z", "GetIsDeltaCompressHandler")]
			get {
				const string __id = "isDeltaCompress.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setDeltaCompress' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDeltaCompress", "(Z)V", "GetSetDeltaCompress_ZHandler")]
			set {
				const string __id = "setDeltaCompress.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeltaSearchMemoryLimit;
#pragma warning disable 0169
		static Delegate GetGetDeltaSearchMemoryLimitHandler ()
		{
			if (cb_getDeltaSearchMemoryLimit == null)
				cb_getDeltaSearchMemoryLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDeltaSearchMemoryLimit);
			return cb_getDeltaSearchMemoryLimit;
		}

		static long n_GetDeltaSearchMemoryLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaSearchMemoryLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setDeltaSearchMemoryLimit_J;
#pragma warning disable 0169
		static Delegate GetSetDeltaSearchMemoryLimit_JHandler ()
		{
			if (cb_setDeltaSearchMemoryLimit_J == null)
				cb_setDeltaSearchMemoryLimit_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetDeltaSearchMemoryLimit_J);
			return cb_setDeltaSearchMemoryLimit_J;
		}

		static void n_SetDeltaSearchMemoryLimit_J (IntPtr jnienv, IntPtr native__this, long memoryLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeltaSearchMemoryLimit = memoryLimit;
		}
#pragma warning restore 0169

		/// <summary>Get maximum number of bytes to put into the delta search window. -or- Set the maximum number of bytes to put into the delta search window.</summary>
		/// <returns>the memory limit.</returns>
		/// <param name="memoryLimit">Maximum number of bytes to load at once, 0 for unlimited.</param>
		public virtual unsafe long DeltaSearchMemoryLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getDeltaSearchMemoryLimit' and count(parameter)=0]"
			[Register ("getDeltaSearchMemoryLimit", "()J", "GetGetDeltaSearchMemoryLimitHandler")]
			get {
				const string __id = "getDeltaSearchMemoryLimit.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setDeltaSearchMemoryLimit' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDeltaSearchMemoryLimit", "(J)V", "GetSetDeltaSearchMemoryLimit_JHandler")]
			set {
				const string __id = "setDeltaSearchMemoryLimit.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeltaSearchWindowSize;
#pragma warning disable 0169
		static Delegate GetGetDeltaSearchWindowSizeHandler ()
		{
			if (cb_getDeltaSearchWindowSize == null)
				cb_getDeltaSearchWindowSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDeltaSearchWindowSize);
			return cb_getDeltaSearchWindowSize;
		}

		static int n_GetDeltaSearchWindowSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaSearchWindowSize;
		}
#pragma warning restore 0169

		static Delegate cb_setDeltaSearchWindowSize_I;
#pragma warning disable 0169
		static Delegate GetSetDeltaSearchWindowSize_IHandler ()
		{
			if (cb_setDeltaSearchWindowSize_I == null)
				cb_setDeltaSearchWindowSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDeltaSearchWindowSize_I);
			return cb_setDeltaSearchWindowSize_I;
		}

		static void n_SetDeltaSearchWindowSize_I (IntPtr jnienv, IntPtr native__this, int objectCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeltaSearchWindowSize = objectCount;
		}
#pragma warning restore 0169

		/// <summary>Get the number of objects to try when looking for a delta base. -or- Set the number of objects considered when searching for a delta base.</summary>
		/// <returns>the object count to be searched.</returns>
		/// <param name="objectCount">number of objects to search at once. Must be at least 2.</param>
		public virtual unsafe int DeltaSearchWindowSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getDeltaSearchWindowSize' and count(parameter)=0]"
			[Register ("getDeltaSearchWindowSize", "()I", "GetGetDeltaSearchWindowSizeHandler")]
			get {
				const string __id = "getDeltaSearchWindowSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setDeltaSearchWindowSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDeltaSearchWindowSize", "(I)V", "GetSetDeltaSearchWindowSize_IHandler")]
			set {
				const string __id = "setDeltaSearchWindowSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExecutor;
#pragma warning disable 0169
		static Delegate GetGetExecutorHandler ()
		{
			if (cb_getExecutor == null)
				cb_getExecutor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExecutor);
			return cb_getExecutor;
		}

		static IntPtr n_GetExecutor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Executor);
		}
#pragma warning restore 0169

		static Delegate cb_setExecutor_Ljava_util_concurrent_Executor_;
#pragma warning disable 0169
		static Delegate GetSetExecutor_Ljava_util_concurrent_Executor_Handler ()
		{
			if (cb_setExecutor_Ljava_util_concurrent_Executor_ == null)
				cb_setExecutor_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExecutor_Ljava_util_concurrent_Executor_);
			return cb_setExecutor_Ljava_util_concurrent_Executor_;
		}

		static void n_SetExecutor_Ljava_util_concurrent_Executor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_executor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var executor = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_executor, JniHandleOwnership.DoNotTransfer);
			__this.Executor = executor;
		}
#pragma warning restore 0169

		/// <returns>the preferred thread pool to execute delta search on.</returns>
		/// <summary>Set the executor to use when using threads.</summary>
		/// <param name="executor">executor to use for threads. Set to null to create a temporary
		///            executor just for the writer.</param>
		public virtual unsafe global::Java.Util.Concurrent.IExecutor Executor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getExecutor' and count(parameter)=0]"
			[Register ("getExecutor", "()Ljava/util/concurrent/Executor;", "GetGetExecutorHandler")]
			get {
				const string __id = "getExecutor.()Ljava/util/concurrent/Executor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setExecutor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
			[Register ("setExecutor", "(Ljava/util/concurrent/Executor;)V", "GetSetExecutor_Ljava_util_concurrent_Executor_Handler")]
			set {
				const string __id = "setExecutor.(Ljava/util/concurrent/Executor;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getIndexVersion;
#pragma warning disable 0169
		static Delegate GetGetIndexVersionHandler ()
		{
			if (cb_getIndexVersion == null)
				cb_getIndexVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIndexVersion);
			return cb_getIndexVersion;
		}

		static int n_GetIndexVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexVersion;
		}
#pragma warning restore 0169

		static Delegate cb_setIndexVersion_I;
#pragma warning disable 0169
		static Delegate GetSetIndexVersion_IHandler ()
		{
			if (cb_setIndexVersion_I == null)
				cb_setIndexVersion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetIndexVersion_I);
			return cb_setIndexVersion_I;
		}

		static void n_SetIndexVersion_I (IntPtr jnienv, IntPtr native__this, int version)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndexVersion = version;
		}
#pragma warning restore 0169

		/// <summary>Get the pack index file format version this instance creates. -or- Set the pack index file format version this instance will create.</summary>
		/// <returns>the index version, the special version 0 designates the oldest
		///         (most compatible) format available for the objects.</returns>
		/// <param name="version">the version to write. The special version 0 designates the
		///            oldest (most compatible) format available for the objects.</param>
		public virtual unsafe int IndexVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getIndexVersion' and count(parameter)=0]"
			[Register ("getIndexVersion", "()I", "GetGetIndexVersionHandler")]
			get {
				const string __id = "getIndexVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setIndexVersion' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndexVersion", "(I)V", "GetSetIndexVersion_IHandler")]
			set {
				const string __id = "setIndexVersion.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxDeltaDepth;
#pragma warning disable 0169
		static Delegate GetGetMaxDeltaDepthHandler ()
		{
			if (cb_getMaxDeltaDepth == null)
				cb_getMaxDeltaDepth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxDeltaDepth);
			return cb_getMaxDeltaDepth;
		}

		static int n_GetMaxDeltaDepth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDeltaDepth;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxDeltaDepth_I;
#pragma warning disable 0169
		static Delegate GetSetMaxDeltaDepth_IHandler ()
		{
			if (cb_setMaxDeltaDepth_I == null)
				cb_setMaxDeltaDepth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxDeltaDepth_I);
			return cb_setMaxDeltaDepth_I;
		}

		static void n_SetMaxDeltaDepth_I (IntPtr jnienv, IntPtr native__this, int maxDeltaDepth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxDeltaDepth = maxDeltaDepth;
		}
#pragma warning restore 0169

		/// <summary>Get maximum depth of delta chain set up for the writer. -or- Set up maximum depth of delta chain for the writer.</summary>
		/// <returns>maximum delta chain depth.</returns>
		/// <param name="maxDeltaDepth">maximum delta chain depth.</param>
		public virtual unsafe int MaxDeltaDepth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getMaxDeltaDepth' and count(parameter)=0]"
			[Register ("getMaxDeltaDepth", "()I", "GetGetMaxDeltaDepthHandler")]
			get {
				const string __id = "getMaxDeltaDepth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setMaxDeltaDepth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxDeltaDepth", "(I)V", "GetSetMaxDeltaDepth_IHandler")]
			set {
				const string __id = "setMaxDeltaDepth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isReuseDeltas;
#pragma warning disable 0169
		static Delegate GetIsReuseDeltasHandler ()
		{
			if (cb_isReuseDeltas == null)
				cb_isReuseDeltas = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsReuseDeltas);
			return cb_isReuseDeltas;
		}

		static bool n_IsReuseDeltas (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReuseDeltas;
		}
#pragma warning restore 0169

		static Delegate cb_setReuseDeltas_Z;
#pragma warning disable 0169
		static Delegate GetSetReuseDeltas_ZHandler ()
		{
			if (cb_setReuseDeltas_Z == null)
				cb_setReuseDeltas_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetReuseDeltas_Z);
			return cb_setReuseDeltas_Z;
		}

		static void n_SetReuseDeltas_Z (IntPtr jnienv, IntPtr native__this, bool reuseDeltas)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReuseDeltas = reuseDeltas;
		}
#pragma warning restore 0169

		/// <summary>Check whether to reuse deltas existing in repository. -or- Set reuse deltas configuration option for the writer.</summary>
		/// <returns>true if object is configured to reuse deltas; false otherwise.</returns>
		/// <param name="reuseDeltas">boolean indicating whether or not try to reuse deltas.</param>
		public virtual unsafe bool ReuseDeltas {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='isReuseDeltas' and count(parameter)=0]"
			[Register ("isReuseDeltas", "()Z", "GetIsReuseDeltasHandler")]
			get {
				const string __id = "isReuseDeltas.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setReuseDeltas' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReuseDeltas", "(Z)V", "GetSetReuseDeltas_ZHandler")]
			set {
				const string __id = "setReuseDeltas.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isReuseObjects;
#pragma warning disable 0169
		static Delegate GetIsReuseObjectsHandler ()
		{
			if (cb_isReuseObjects == null)
				cb_isReuseObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsReuseObjects);
			return cb_isReuseObjects;
		}

		static bool n_IsReuseObjects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReuseObjects;
		}
#pragma warning restore 0169

		static Delegate cb_setReuseObjects_Z;
#pragma warning disable 0169
		static Delegate GetSetReuseObjects_ZHandler ()
		{
			if (cb_setReuseObjects_Z == null)
				cb_setReuseObjects_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetReuseObjects_Z);
			return cb_setReuseObjects_Z;
		}

		static void n_SetReuseObjects_Z (IntPtr jnienv, IntPtr native__this, bool reuseObjects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReuseObjects = reuseObjects;
		}
#pragma warning restore 0169

		/// <summary>Checks whether to reuse existing objects representation in repository. -or- Set reuse objects configuration option for the writer.</summary>
		/// <returns>true if writer is configured to reuse objects representation from
		///         pack; false otherwise.</returns>
		/// <param name="reuseObjects">boolean indicating whether or not writer should reuse existing
		///            objects representation.</param>
		public virtual unsafe bool ReuseObjects {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='isReuseObjects' and count(parameter)=0]"
			[Register ("isReuseObjects", "()Z", "GetIsReuseObjectsHandler")]
			get {
				const string __id = "isReuseObjects.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setReuseObjects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReuseObjects", "(Z)V", "GetSetReuseObjects_ZHandler")]
			set {
				const string __id = "setReuseObjects.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getThreads;
#pragma warning disable 0169
		static Delegate GetGetThreadsHandler ()
		{
			if (cb_getThreads == null)
				cb_getThreads = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetThreads);
			return cb_getThreads;
		}

		static int n_GetThreads (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Threads;
		}
#pragma warning restore 0169

		static Delegate cb_setThreads_I;
#pragma warning disable 0169
		static Delegate GetSetThreads_IHandler ()
		{
			if (cb_setThreads_I == null)
				cb_setThreads_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetThreads_I);
			return cb_setThreads_I;
		}

		static void n_SetThreads_I (IntPtr jnienv, IntPtr native__this, int threads)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Threads = threads;
		}
#pragma warning restore 0169

		/// <summary>Get the number of threads used during delta compression. -or- Set the number of threads to use for delta compression.</summary>
		/// <returns>number of threads used for delta compression. 0 will auto-detect
		///         the threads to the number of available processors.</returns>
		/// <param name="threads">number of threads to use. If &amp;lt;= 0 the number of available
		///            processors for this JVM is used.</param>
		public virtual unsafe int Threads {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='getThreads' and count(parameter)=0]"
			[Register ("getThreads", "()I", "GetGetThreadsHandler")]
			get {
				const string __id = "getThreads.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='setThreads' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setThreads", "(I)V", "GetSetThreads_IHandler")]
			set {
				const string __id = "setThreads.(I)V";
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
				cb_fromConfig_Lorg_eclipse_jgit_lib_Config_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FromConfig_Lorg_eclipse_jgit_lib_Config_);
			return cb_fromConfig_Lorg_eclipse_jgit_lib_Config_;
		}

		static void n_FromConfig_Lorg_eclipse_jgit_lib_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (native_rc, JniHandleOwnership.DoNotTransfer);
			__this.FromConfig (rc);
		}
#pragma warning restore 0169

		/// <param name="rc">configuration to read properties from.</param>
		/// <summary>Update properties by setting fields from the configuration.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.pack']/class[@name='PackConfig']/method[@name='fromConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
		[Register ("fromConfig", "(Lorg/eclipse/jgit/lib/Config;)V", "GetFromConfig_Lorg_eclipse_jgit_lib_Config_Handler")]
		public virtual unsafe void FromConfig (global::Org.Eclipse.Jgit.Lib.Config rc)
		{
			const string __id = "fromConfig.(Lorg/eclipse/jgit/lib/Config;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rc).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rc);
			}
		}

	}
}
