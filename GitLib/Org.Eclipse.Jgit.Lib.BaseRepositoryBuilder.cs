using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <param name="&lt;B&gt;">type of the repository builder.</param>
	/// <param name="&lt;R&gt;">type of the repository that is constructed.</param>
	/// <summary>Base builder to customize repository construction.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BaseRepositoryBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"B extends org.eclipse.jgit.lib.BaseRepositoryBuilder", "R extends org.eclipse.jgit.lib.Repository"})]
	public partial class BaseRepositoryBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BaseRepositoryBuilder", typeof (BaseRepositoryBuilder));

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

		protected BaseRepositoryBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/constructor[@name='BaseRepositoryBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseRepositoryBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		/// <summary>Get the cached repository configuration, loading if not yet available.</summary>
		/// <returns>the configuration of the repository.</returns>
		protected virtual unsafe global::Org.Eclipse.Jgit.Lib.Config Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lorg/eclipse/jgit/lib/Config;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Lorg/eclipse/jgit/lib/Config;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FS);
		}
#pragma warning restore 0169

		/// <returns>the file system abstraction, or null if not set.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Util.FS FS {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='getFS' and count(parameter)=0]"
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

		static Delegate cb_getGitDir;
#pragma warning disable 0169
		static Delegate GetGetGitDirHandler ()
		{
			if (cb_getGitDir == null)
				cb_getGitDir = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGitDir);
			return cb_getGitDir;
		}

		static IntPtr n_GetGitDir (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GitDir);
		}
#pragma warning restore 0169

		/// <returns>the meta data directory; null if not set.</returns>
		public virtual unsafe global::Java.IO.File GitDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='getGitDir' and count(parameter)=0]"
			[Register ("getGitDir", "()Ljava/io/File;", "GetGetGitDirHandler")]
			get {
				const string __id = "getGitDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IndexFile);
		}
#pragma warning restore 0169

		/// <returns>the index file location, or null if not set.</returns>
		public virtual unsafe global::Java.IO.File IndexFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='getIndexFile' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBare;
		}
#pragma warning restore 0169

		/// <returns>true if this repository was forced bare by <c>#setBare()</c>.</returns>
		public virtual unsafe bool IsBare {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='isBare' and count(parameter)=0]"
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

		static Delegate cb_isMustExist;
#pragma warning disable 0169
		static Delegate GetIsMustExistHandler ()
		{
			if (cb_isMustExist == null)
				cb_isMustExist = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMustExist);
			return cb_isMustExist;
		}

		static bool n_IsMustExist (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMustExist;
		}
#pragma warning restore 0169

		/// <returns>true if the repository must exist before being opened.</returns>
		public virtual unsafe bool IsMustExist {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='isMustExist' and count(parameter)=0]"
			[Register ("isMustExist", "()Z", "GetIsMustExistHandler")]
			get {
				const string __id = "isMustExist.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getObjectDirectory;
#pragma warning disable 0169
		static Delegate GetGetObjectDirectoryHandler ()
		{
			if (cb_getObjectDirectory == null)
				cb_getObjectDirectory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectDirectory);
			return cb_getObjectDirectory;
		}

		static IntPtr n_GetObjectDirectory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectDirectory);
		}
#pragma warning restore 0169

		/// <returns>the object directory; null if not set.</returns>
		public virtual unsafe global::Java.IO.File ObjectDirectory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='getObjectDirectory' and count(parameter)=0]"
			[Register ("getObjectDirectory", "()Ljava/io/File;", "GetGetObjectDirectoryHandler")]
			get {
				const string __id = "getObjectDirectory.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WorkTree);
		}
#pragma warning restore 0169

		/// <returns>the work tree directory, or null if not set.</returns>
		public virtual unsafe global::Java.IO.File WorkTree {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='getWorkTree' and count(parameter)=0]"
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

		static Delegate cb_addAlternateObjectDirectories_arrayLjava_io_File_;
#pragma warning disable 0169
		static Delegate GetAddAlternateObjectDirectories_arrayLjava_io_File_Handler ()
		{
			if (cb_addAlternateObjectDirectories_arrayLjava_io_File_ == null)
				cb_addAlternateObjectDirectories_arrayLjava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddAlternateObjectDirectories_arrayLjava_io_File_);
			return cb_addAlternateObjectDirectories_arrayLjava_io_File_;
		}

		static IntPtr n_AddAlternateObjectDirectories_arrayLjava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inList)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inList = (global::Java.IO.File[]) JNIEnv.GetArray (native_inList, JniHandleOwnership.DoNotTransfer, typeof (global::Java.IO.File));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAlternateObjectDirectories (inList));
			if (inList != null)
				JNIEnv.CopyArray (inList, native_inList);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="inList">other object directories to search after the standard one. The
		///            array's contents is copied to an internal list.</param>
		/// <summary>Add alternate object directories to the search list.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='addAlternateObjectDirectories' and count(parameter)=1 and parameter[1][@type='java.io.File[]']]"
		[Register ("addAlternateObjectDirectories", "([Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetAddAlternateObjectDirectories_arrayLjava_io_File_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAlternateObjectDirectories (global::Java.IO.File[] inList)
		{
			const string __id = "addAlternateObjectDirectories.([Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			IntPtr native_inList = JNIEnv.NewArray (inList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inList);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (inList != null) {
					JNIEnv.CopyArray (native_inList, inList);
					JNIEnv.DeleteLocalRef (native_inList);
				}
				global::System.GC.KeepAlive (inList);
			}
		}

		static Delegate cb_addAlternateObjectDirectories_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAlternateObjectDirectories_Ljava_util_Collection_Handler ()
		{
			if (cb_addAlternateObjectDirectories_Ljava_util_Collection_ == null)
				cb_addAlternateObjectDirectories_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddAlternateObjectDirectories_Ljava_util_Collection_);
			return cb_addAlternateObjectDirectories_Ljava_util_Collection_;
		}

		static IntPtr n_AddAlternateObjectDirectories_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inList)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inList = global::Android.Runtime.JavaCollection<global::Java.IO.File>.FromJniHandle (native_inList, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAlternateObjectDirectories (inList));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="inList">other object directories to search after the standard one. The
		///            collection's contents is copied to an internal list.</param>
		/// <summary>Add alternate object directories to the search list.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='addAlternateObjectDirectories' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.io.File&gt;']]"
		[Register ("addAlternateObjectDirectories", "(Ljava/util/Collection;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetAddAlternateObjectDirectories_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAlternateObjectDirectories (global::System.Collections.Generic.ICollection<global::Java.IO.File> inList)
		{
			const string __id = "addAlternateObjectDirectories.(Ljava/util/Collection;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			IntPtr native_inList = global::Android.Runtime.JavaCollection<global::Java.IO.File>.ToLocalJniHandle (inList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inList);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inList);
				global::System.GC.KeepAlive (inList);
			}
		}

		static Delegate cb_addAlternateObjectDirectory_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetAddAlternateObjectDirectory_Ljava_io_File_Handler ()
		{
			if (cb_addAlternateObjectDirectory_Ljava_io_File_ == null)
				cb_addAlternateObjectDirectory_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddAlternateObjectDirectory_Ljava_io_File_);
			return cb_addAlternateObjectDirectory_Ljava_io_File_;
		}

		static IntPtr n_AddAlternateObjectDirectory_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAlternateObjectDirectory (other));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="other">another objects directory to search after the standard one.</param>
		/// <summary>Add an alternate object directory to the search list.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='addAlternateObjectDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("addAlternateObjectDirectory", "(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetAddAlternateObjectDirectory_Ljava_io_File_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAlternateObjectDirectory (global::Java.IO.File other)
		{
			const string __id = "addAlternateObjectDirectory.(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		static Delegate cb_addCeilingDirectories_arrayLjava_io_File_;
#pragma warning disable 0169
		static Delegate GetAddCeilingDirectories_arrayLjava_io_File_Handler ()
		{
			if (cb_addCeilingDirectories_arrayLjava_io_File_ == null)
				cb_addCeilingDirectories_arrayLjava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddCeilingDirectories_arrayLjava_io_File_);
			return cb_addCeilingDirectories_arrayLjava_io_File_;
		}

		static IntPtr n_AddCeilingDirectories_arrayLjava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inList)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inList = (global::Java.IO.File[]) JNIEnv.GetArray (native_inList, JniHandleOwnership.DoNotTransfer, typeof (global::Java.IO.File));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCeilingDirectories (inList));
			if (inList != null)
				JNIEnv.CopyArray (inList, native_inList);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="inList">directory paths to stop searching at. The array's contents is
		///            copied to an internal list.</param>
		/// <summary>Add ceiling directories to the search list.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='addCeilingDirectories' and count(parameter)=1 and parameter[1][@type='java.io.File[]']]"
		[Register ("addCeilingDirectories", "([Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetAddCeilingDirectories_arrayLjava_io_File_Handler")]
		public virtual unsafe global::Java.Lang.Object AddCeilingDirectories (global::Java.IO.File[] inList)
		{
			const string __id = "addCeilingDirectories.([Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			IntPtr native_inList = JNIEnv.NewArray (inList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inList);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (inList != null) {
					JNIEnv.CopyArray (native_inList, inList);
					JNIEnv.DeleteLocalRef (native_inList);
				}
				global::System.GC.KeepAlive (inList);
			}
		}

		static Delegate cb_addCeilingDirectories_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddCeilingDirectories_Ljava_util_Collection_Handler ()
		{
			if (cb_addCeilingDirectories_Ljava_util_Collection_ == null)
				cb_addCeilingDirectories_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddCeilingDirectories_Ljava_util_Collection_);
			return cb_addCeilingDirectories_Ljava_util_Collection_;
		}

		static IntPtr n_AddCeilingDirectories_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inList)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inList = global::Android.Runtime.JavaCollection<global::Java.IO.File>.FromJniHandle (native_inList, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCeilingDirectories (inList));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="inList">directory paths to stop searching at. The collection's
		///            contents is copied to an internal list.</param>
		/// <summary>Add ceiling directories to the search list.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='addCeilingDirectories' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.io.File&gt;']]"
		[Register ("addCeilingDirectories", "(Ljava/util/Collection;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetAddCeilingDirectories_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Java.Lang.Object AddCeilingDirectories (global::System.Collections.Generic.ICollection<global::Java.IO.File> inList)
		{
			const string __id = "addCeilingDirectories.(Ljava/util/Collection;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			IntPtr native_inList = global::Android.Runtime.JavaCollection<global::Java.IO.File>.ToLocalJniHandle (inList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inList);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inList);
				global::System.GC.KeepAlive (inList);
			}
		}

		static Delegate cb_addCeilingDirectory_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetAddCeilingDirectory_Ljava_io_File_Handler ()
		{
			if (cb_addCeilingDirectory_Ljava_io_File_ == null)
				cb_addCeilingDirectory_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddCeilingDirectory_Ljava_io_File_);
			return cb_addCeilingDirectory_Ljava_io_File_;
		}

		static IntPtr n_AddCeilingDirectory_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_root)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var root = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_root, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCeilingDirectory (root));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="root">a path to stop searching at; its parent will not be searched.</param>
		/// <summary>Add a ceiling directory to the search limit list.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='addCeilingDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("addCeilingDirectory", "(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetAddCeilingDirectory_Ljava_io_File_Handler")]
		public virtual unsafe global::Java.Lang.Object AddCeilingDirectory (global::Java.IO.File root)
		{
			const string __id = "addCeilingDirectory.(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((root == null) ? IntPtr.Zero : ((global::Java.Lang.Object) root).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (root);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		/// <summary>Create a repository matching the configuration in this builder.</summary>
		/// <returns>a repository matching this configuration.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lorg/eclipse/jgit/lib/Repository;", "GetBuildHandler")]
		public virtual unsafe global::Java.Lang.Object Build ()
		{
			const string __id = "build.()Lorg/eclipse/jgit/lib/Repository;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findGitDir;
#pragma warning disable 0169
		static Delegate GetFindGitDirHandler ()
		{
			if (cb_findGitDir == null)
				cb_findGitDir = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_FindGitDir);
			return cb_findGitDir;
		}

		static IntPtr n_FindGitDir (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindGitDir ());
		}
#pragma warning restore 0169

		/// <summary>Configure <c>GIT_DIR</c> by searching up the file system.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='findGitDir' and count(parameter)=0]"
		[Register ("findGitDir", "()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetFindGitDirHandler")]
		public virtual unsafe global::Java.Lang.Object FindGitDir ()
		{
			const string __id = "findGitDir.()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findGitDir_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetFindGitDir_Ljava_io_File_Handler ()
		{
			if (cb_findGitDir_Ljava_io_File_ == null)
				cb_findGitDir_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FindGitDir_Ljava_io_File_);
			return cb_findGitDir_Ljava_io_File_;
		}

		static IntPtr n_FindGitDir_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_current)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var current = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_current, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindGitDir (current));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="current">directory to begin searching in.</param>
		/// <summary>Configure <c>GIT_DIR</c> by searching up the file system.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='findGitDir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("findGitDir", "(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetFindGitDir_Ljava_io_File_Handler")]
		public virtual unsafe global::Java.Lang.Object FindGitDir (global::Java.IO.File current)
		{
			const string __id = "findGitDir.(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((current == null) ? IntPtr.Zero : ((global::Java.Lang.Object) current).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (current);
			}
		}

		static Delegate cb_getAlternateObjectDirectories;
#pragma warning disable 0169
		static Delegate GetGetAlternateObjectDirectoriesHandler ()
		{
			if (cb_getAlternateObjectDirectories == null)
				cb_getAlternateObjectDirectories = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAlternateObjectDirectories);
			return cb_getAlternateObjectDirectories;
		}

		static IntPtr n_GetAlternateObjectDirectories (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAlternateObjectDirectories ());
		}
#pragma warning restore 0169

		/// <returns>ordered array of alternate directories; null if non were set.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='getAlternateObjectDirectories' and count(parameter)=0]"
		[Register ("getAlternateObjectDirectories", "()[Ljava/io/File;", "GetGetAlternateObjectDirectoriesHandler")]
		public virtual unsafe global::Java.IO.File[] GetAlternateObjectDirectories ()
		{
			const string __id = "getAlternateObjectDirectories.()[Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
			}
		}

		static Delegate cb_loadConfig;
#pragma warning disable 0169
		static Delegate GetLoadConfigHandler ()
		{
			if (cb_loadConfig == null)
				cb_loadConfig = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LoadConfig);
			return cb_loadConfig;
		}

		static IntPtr n_LoadConfig (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoadConfig ());
		}
#pragma warning restore 0169

		/// <summary>Parse and load the repository specific configuration.</summary>
		/// <returns>the repository's configuration.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='loadConfig' and count(parameter)=0]"
		[Register ("loadConfig", "()Lorg/eclipse/jgit/lib/Config;", "GetLoadConfigHandler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Lib.Config LoadConfig ()
		{
			const string __id = "loadConfig.()Lorg/eclipse/jgit/lib/Config;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readEnvironment;
#pragma warning disable 0169
		static Delegate GetReadEnvironmentHandler ()
		{
			if (cb_readEnvironment == null)
				cb_readEnvironment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadEnvironment);
			return cb_readEnvironment;
		}

		static IntPtr n_ReadEnvironment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadEnvironment ());
		}
#pragma warning restore 0169

		/// <summary>Read standard Git environment variables and configure from those.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='readEnvironment' and count(parameter)=0]"
		[Register ("readEnvironment", "()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetReadEnvironmentHandler")]
		public virtual unsafe global::Java.Lang.Object ReadEnvironment ()
		{
			const string __id = "readEnvironment.()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readEnvironment_Lorg_eclipse_jgit_util_SystemReader_;
#pragma warning disable 0169
		static Delegate GetReadEnvironment_Lorg_eclipse_jgit_util_SystemReader_Handler ()
		{
			if (cb_readEnvironment_Lorg_eclipse_jgit_util_SystemReader_ == null)
				cb_readEnvironment_Lorg_eclipse_jgit_util_SystemReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReadEnvironment_Lorg_eclipse_jgit_util_SystemReader_);
			return cb_readEnvironment_Lorg_eclipse_jgit_util_SystemReader_;
		}

		static IntPtr n_ReadEnvironment_Lorg_eclipse_jgit_util_SystemReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sr = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (native_sr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadEnvironment (sr));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="sr">the SystemReader abstraction to access the environment.</param>
		/// <summary>Read standard Git environment variables and configure from those.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='readEnvironment' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.SystemReader']]"
		[Register ("readEnvironment", "(Lorg/eclipse/jgit/util/SystemReader;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetReadEnvironment_Lorg_eclipse_jgit_util_SystemReader_Handler")]
		public virtual unsafe global::Java.Lang.Object ReadEnvironment (global::Org.Eclipse.Jgit.Util.SystemReader sr)
		{
			const string __id = "readEnvironment.(Lorg/eclipse/jgit/util/SystemReader;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sr).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (sr);
			}
		}

		static Delegate cb_requireGitDirOrWorkTree;
#pragma warning disable 0169
		static Delegate GetRequireGitDirOrWorkTreeHandler ()
		{
			if (cb_requireGitDirOrWorkTree == null)
				cb_requireGitDirOrWorkTree = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RequireGitDirOrWorkTree);
			return cb_requireGitDirOrWorkTree;
		}

		static void n_RequireGitDirOrWorkTree (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequireGitDirOrWorkTree ();
		}
#pragma warning restore 0169

		/// <summary>Require either <c>gitDir</c> or <c>workTree</c> to be set.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='requireGitDirOrWorkTree' and count(parameter)=0]"
		[Register ("requireGitDirOrWorkTree", "()V", "GetRequireGitDirOrWorkTreeHandler")]
		protected virtual unsafe void RequireGitDirOrWorkTree ()
		{
			const string __id = "requireGitDirOrWorkTree.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_safeFS;
#pragma warning disable 0169
		static Delegate GetSafeFSHandler ()
		{
			if (cb_safeFS == null)
				cb_safeFS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SafeFS);
			return cb_safeFS;
		}

		static IntPtr n_SafeFS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SafeFS ());
		}
#pragma warning restore 0169

		/// <returns>the configured FS, or <c>FS#DETECTED</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='safeFS' and count(parameter)=0]"
		[Register ("safeFS", "()Lorg/eclipse/jgit/util/FS;", "GetSafeFSHandler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Util.FS SafeFS ()
		{
			const string __id = "safeFS.()Lorg/eclipse/jgit/util/FS;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='self' and count(parameter)=0]"
		[Register ("self", "()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "")]
		protected unsafe global::Java.Lang.Object Self ()
		{
			const string __id = "self.()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBare;
#pragma warning disable 0169
		static Delegate GetSetBareHandler ()
		{
			if (cb_setBare == null)
				cb_setBare = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SetBare);
			return cb_setBare;
		}

		static IntPtr n_SetBare (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBare ());
		}
#pragma warning restore 0169

		/// <summary>Force the repository to be treated as bare (have no working directory).</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setBare' and count(parameter)=0]"
		[Register ("setBare", "()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetSetBareHandler")]
		public virtual unsafe global::Java.Lang.Object SetBare ()
		{
			const string __id = "setBare.()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFS_Lorg_eclipse_jgit_util_FS_;
#pragma warning disable 0169
		static Delegate GetSetFS_Lorg_eclipse_jgit_util_FS_Handler ()
		{
			if (cb_setFS_Lorg_eclipse_jgit_util_FS_ == null)
				cb_setFS_Lorg_eclipse_jgit_util_FS_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetFS_Lorg_eclipse_jgit_util_FS_);
			return cb_setFS_Lorg_eclipse_jgit_util_FS_;
		}

		static IntPtr n_SetFS_Lorg_eclipse_jgit_util_FS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fs = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (native_fs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFS (fs));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="fs">the abstraction.</param>
		/// <summary>Set the file system abstraction needed by this repository.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setFS' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.FS']]"
		[Register ("setFS", "(Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetSetFS_Lorg_eclipse_jgit_util_FS_Handler")]
		public virtual unsafe global::Java.Lang.Object SetFS (global::Org.Eclipse.Jgit.Util.FS fs)
		{
			const string __id = "setFS.(Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fs);
			}
		}

		static Delegate cb_setGitDir_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetGitDir_Ljava_io_File_Handler ()
		{
			if (cb_setGitDir_Ljava_io_File_ == null)
				cb_setGitDir_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetGitDir_Ljava_io_File_);
			return cb_setGitDir_Ljava_io_File_;
		}

		static IntPtr n_SetGitDir_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gitDir)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gitDir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_gitDir, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGitDir (gitDir));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="gitDir">
		///   <c>GIT_DIR</c>, the repository meta directory.</param>
		/// <summary>Set the Git directory storing the repository metadata.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setGitDir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setGitDir", "(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetSetGitDir_Ljava_io_File_Handler")]
		public virtual unsafe global::Java.Lang.Object SetGitDir (global::Java.IO.File gitDir)
		{
			const string __id = "setGitDir.(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gitDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gitDir).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (gitDir);
			}
		}

		static Delegate cb_setIndexFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetIndexFile_Ljava_io_File_Handler ()
		{
			if (cb_setIndexFile_Ljava_io_File_ == null)
				cb_setIndexFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetIndexFile_Ljava_io_File_);
			return cb_setIndexFile_Ljava_io_File_;
		}

		static IntPtr n_SetIndexFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_indexFile)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var indexFile = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_indexFile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIndexFile (indexFile));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="indexFile">
		///   <c>GIT_INDEX_FILE</c>, the index file location.</param>
		/// <summary>Set the local index file that is caching checked out file status.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setIndexFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setIndexFile", "(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetSetIndexFile_Ljava_io_File_Handler")]
		public virtual unsafe global::Java.Lang.Object SetIndexFile (global::Java.IO.File indexFile)
		{
			const string __id = "setIndexFile.(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((indexFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexFile).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (indexFile);
			}
		}

		static Delegate cb_setMustExist_Z;
#pragma warning disable 0169
		static Delegate GetSetMustExist_ZHandler ()
		{
			if (cb_setMustExist_Z == null)
				cb_setMustExist_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetMustExist_Z);
			return cb_setMustExist_Z;
		}

		static IntPtr n_SetMustExist_Z (IntPtr jnienv, IntPtr native__this, bool mustExist)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMustExist (mustExist));
		}
#pragma warning restore 0169

		/// <param name="mustExist">true if it must exist; false if it can be missing and created
		///            after being built.</param>
		/// <summary>Require the repository to exist before it can be opened.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setMustExist' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMustExist", "(Z)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetSetMustExist_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetMustExist (bool mustExist)
		{
			const string __id = "setMustExist.(Z)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mustExist);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setObjectDirectory_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetObjectDirectory_Ljava_io_File_Handler ()
		{
			if (cb_setObjectDirectory_Ljava_io_File_ == null)
				cb_setObjectDirectory_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetObjectDirectory_Ljava_io_File_);
			return cb_setObjectDirectory_Ljava_io_File_;
		}

		static IntPtr n_SetObjectDirectory_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectDirectory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectDirectory = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_objectDirectory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetObjectDirectory (objectDirectory));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectDirectory">
		///   <c>GIT_OBJECT_DIRECTORY</c>, the directory where the
		///            repository's object files are stored.</param>
		/// <summary>Set the directory storing the repository's objects.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setObjectDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setObjectDirectory", "(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetSetObjectDirectory_Ljava_io_File_Handler")]
		public virtual unsafe global::Java.Lang.Object SetObjectDirectory (global::Java.IO.File objectDirectory)
		{
			const string __id = "setObjectDirectory.(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectDirectory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectDirectory).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectDirectory);
			}
		}

		static Delegate cb_setWorkTree_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetWorkTree_Ljava_io_File_Handler ()
		{
			if (cb_setWorkTree_Ljava_io_File_ == null)
				cb_setWorkTree_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetWorkTree_Ljava_io_File_);
			return cb_setWorkTree_Ljava_io_File_;
		}

		static IntPtr n_SetWorkTree_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_workTree)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var workTree = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_workTree, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetWorkTree (workTree));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="workTree">
		///   <c>GIT_WORK_TREE</c>, the working directory of the checkout.</param>
		/// <summary>Set the top level directory of the working files.</summary>
		/// <returns>
		///   <c>this</c> (for chaining calls).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setWorkTree' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setWorkTree", "(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetSetWorkTree_Ljava_io_File_Handler")]
		public virtual unsafe global::Java.Lang.Object SetWorkTree (global::Java.IO.File workTree)
		{
			const string __id = "setWorkTree.(Ljava/io/File;)Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((workTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) workTree).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (workTree);
			}
		}

		static Delegate cb_setup;
#pragma warning disable 0169
		static Delegate GetSetupHandler ()
		{
			if (cb_setup == null)
				cb_setup = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Setup);
			return cb_setup;
		}

		static IntPtr n_Setup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Setup ());
		}
#pragma warning restore 0169

		/// <summary>Guess and populate all parameters not already defined.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setup' and count(parameter)=0]"
		[Register ("setup", "()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;", "GetSetupHandler")]
		public virtual unsafe global::Java.Lang.Object Setup ()
		{
			const string __id = "setup.()Lorg/eclipse/jgit/lib/BaseRepositoryBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setupGitDir;
#pragma warning disable 0169
		static Delegate GetSetupGitDirHandler ()
		{
			if (cb_setupGitDir == null)
				cb_setupGitDir = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetupGitDir);
			return cb_setupGitDir;
		}

		static void n_SetupGitDir (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetupGitDir ();
		}
#pragma warning restore 0169

		/// <summary>Perform standard gitDir initialization.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setupGitDir' and count(parameter)=0]"
		[Register ("setupGitDir", "()V", "GetSetupGitDirHandler")]
		protected virtual unsafe void SetupGitDir ()
		{
			const string __id = "setupGitDir.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setupInternals;
#pragma warning disable 0169
		static Delegate GetSetupInternalsHandler ()
		{
			if (cb_setupInternals == null)
				cb_setupInternals = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetupInternals);
			return cb_setupInternals;
		}

		static void n_SetupInternals (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetupInternals ();
		}
#pragma warning restore 0169

		/// <summary>Configure the internal implementation details of the repository.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setupInternals' and count(parameter)=0]"
		[Register ("setupInternals", "()V", "GetSetupInternalsHandler")]
		protected virtual unsafe void SetupInternals ()
		{
			const string __id = "setupInternals.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setupWorkTree;
#pragma warning disable 0169
		static Delegate GetSetupWorkTreeHandler ()
		{
			if (cb_setupWorkTree == null)
				cb_setupWorkTree = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetupWorkTree);
			return cb_setupWorkTree;
		}

		static void n_SetupWorkTree (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetupWorkTree ();
		}
#pragma warning restore 0169

		/// <summary>Perform standard work-tree initialization.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BaseRepositoryBuilder']/method[@name='setupWorkTree' and count(parameter)=0]"
		[Register ("setupWorkTree", "()V", "GetSetupWorkTreeHandler")]
		protected virtual unsafe void SetupWorkTree ()
		{
			const string __id = "setupWorkTree.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
