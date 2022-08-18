using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Storage.File {

	/// <summary>The configuration file that is stored in the file of the file system.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileBasedConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/storage/file/FileBasedConfig", DoNotGenerateAcw=true)]
	public partial class FileBasedConfig : global::Org.Eclipse.Jgit.Lib.StoredConfig {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/storage/file/FileBasedConfig", typeof (FileBasedConfig));

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

		protected FileBasedConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="cfgLocation">the location of the configuration file on the file system</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <summary>Create a configuration with no default fallback.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileBasedConfig']/constructor[@name='FileBasedConfig' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register (".ctor", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V", "")]
		public unsafe FileBasedConfig (global::Java.IO.File cfgLocation, global::Org.Eclipse.Jgit.Util.FS fs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cfgLocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfgLocation).Handle);
				__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cfgLocation);
				global::System.GC.KeepAlive (fs);
			}
		}

		/// <param name="base">the base configuration file</param>
		/// <param name="cfgLocation">the location of the configuration file on the file system</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <summary>The constructor</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileBasedConfig']/constructor[@name='FileBasedConfig' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='java.io.File'] and parameter[3][@type='org.eclipse.jgit.util.FS']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Config;Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V", "")]
		public unsafe FileBasedConfig (global::Org.Eclipse.Jgit.Lib.Config @base, global::Java.IO.File cfgLocation, global::Org.Eclipse.Jgit.Util.FS fs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Config;Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue ((cfgLocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfgLocation).Handle);
				__args [2] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (cfgLocation);
				global::System.GC.KeepAlive (fs);
			}
		}

		/// <returns>location of the configuration file on disk</returns>
		public unsafe global::Java.IO.File File {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileBasedConfig']/method[@name='getFile' and count(parameter)=0]"
			[Register ("getFile", "()Ljava/io/File;", "")]
			get {
				const string __id = "getFile.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOutdated;
		}
#pragma warning restore 0169

		/// <returns>returns true if the currently loaded configuration file is older
		/// than the file on disk</returns>
		public virtual unsafe bool IsOutdated {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileBasedConfig']/method[@name='isOutdated' and count(parameter)=0]"
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

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Load);
			return cb_load;
		}

		static void n_Load (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		/// <summary>Load the configuration as a Git text style configuration file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileBasedConfig']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "GetLoadHandler")]
		public override unsafe void Load ()
		{
			const string __id = "load.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_save;
#pragma warning disable 0169
		static Delegate GetSaveHandler ()
		{
			if (cb_save == null)
				cb_save = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Save);
			return cb_save;
		}

		static void n_Save (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Save ();
		}
#pragma warning restore 0169

		/// <summary>Save the configuration as a Git text style configuration file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileBasedConfig']/method[@name='save' and count(parameter)=0]"
		[Register ("save", "()V", "GetSaveHandler")]
		public override unsafe void Save ()
		{
			const string __id = "save.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
