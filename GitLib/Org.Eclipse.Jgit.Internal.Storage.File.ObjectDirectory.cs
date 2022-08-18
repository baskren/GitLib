using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Traditional file system based <c>ObjectDatabase</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/ObjectDirectory", DoNotGenerateAcw=true)]
	public partial class ObjectDirectory : global::Org.Eclipse.Jgit.Lib.ObjectDatabase {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/ObjectDirectory", typeof (ObjectDirectory));

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

		protected ObjectDirectory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="cfg">configuration this directory consults for write settings.</param>
		/// <param name="dir">the location of the &lt;code&gt;objects&lt;/code&gt; directory.</param>
		/// <param name="alternatePaths">a list of alternate object directories</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <param name="shallowFile">file which contains IDs of shallow commits, null if shallow
		///            commits handling should be turned off</param>
		/// <summary>Initialize a reference to an on-disk object directory.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']/constructor[@name='ObjectDirectory' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='java.io.File'] and parameter[3][@type='java.io.File[]'] and parameter[4][@type='org.eclipse.jgit.util.FS'] and parameter[5][@type='java.io.File']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Config;Ljava/io/File;[Ljava/io/File;Lorg/eclipse/jgit/util/FS;Ljava/io/File;)V", "")]
		public unsafe ObjectDirectory (global::Org.Eclipse.Jgit.Lib.Config cfg, global::Java.IO.File dir, global::Java.IO.File[] alternatePaths, global::Org.Eclipse.Jgit.Util.FS fs, global::Java.IO.File shallowFile) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Config;Ljava/io/File;[Ljava/io/File;Lorg/eclipse/jgit/util/FS;Ljava/io/File;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_alternatePaths = JNIEnv.NewArray (alternatePaths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				__args [1] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				__args [2] = new JniArgumentValue (native_alternatePaths);
				__args [3] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [4] = new JniArgumentValue ((shallowFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) shallowFile).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (alternatePaths != null) {
					JNIEnv.CopyArray (native_alternatePaths, alternatePaths);
					JNIEnv.DeleteLocalRef (native_alternatePaths);
				}
				global::System.GC.KeepAlive (cfg);
				global::System.GC.KeepAlive (dir);
				global::System.GC.KeepAlive (alternatePaths);
				global::System.GC.KeepAlive (fs);
				global::System.GC.KeepAlive (shallowFile);
			}
		}

		/// <returns>the location of the &lt;code&gt;objects&lt;/code&gt; directory.</returns>
		public unsafe global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "")]
			get {
				const string __id = "getDirectory.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPacks;
#pragma warning disable 0169
		static Delegate GetGetPacksHandler ()
		{
			if (cb_getPacks == null)
				cb_getPacks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPacks);
			return cb_getPacks;
		}

		static IntPtr n_GetPacks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ObjectDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile>.ToLocalJniHandle (__this.Packs);
		}
#pragma warning restore 0169

		/// <returns>unmodifiable collection of all known pack files local to this
		///         directory. Most recent packs are presented first. Packs most
		///         likely to contain more recent objects appear before packs
		///         containing objects referenced by commits further back in the
		///         history of the repository.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> Packs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']/method[@name='getPacks' and count(parameter)=0]"
			[Register ("getPacks", "()Ljava/util/Collection;", "GetGetPacksHandler")]
			get {
				const string __id = "getPacks.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ObjectDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fileFor_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetFileFor_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_fileFor_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_fileFor_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FileFor_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_fileFor_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_FileFor_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ObjectDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FileFor (objectId));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the loose object to map to the directory.</param>
		/// <summary>Compute the location of a loose object file.</summary>
		/// <returns>location of the object, if it were to exist as a loose object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']/method[@name='fileFor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("fileFor", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Ljava/io/File;", "GetFileFor_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Java.IO.File FileFor (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			const string __id = "fileFor.(Lorg/eclipse/jgit/lib/AnyObjectId;)Ljava/io/File;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		static Delegate cb_newInserter;
#pragma warning disable 0169
		static Delegate GetNewInserterHandler ()
		{
			if (cb_newInserter == null)
				cb_newInserter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewInserter);
			return cb_newInserter;
		}

		static IntPtr n_NewInserter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ObjectDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewInserter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']/method[@name='newInserter' and count(parameter)=0]"
		[Register ("newInserter", "()Lorg/eclipse/jgit/lib/ObjectInserter;", "GetNewInserterHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectInserter NewInserter ()
		{
			const string __id = "newInserter.()Lorg/eclipse/jgit/lib/ObjectInserter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}
		/*
		static Delegate cb_newInserter;
#pragma warning disable 0169
		static Delegate GetNewInserterHandler ()
		{
			if (cb_newInserter == null)
				cb_newInserter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewInserter);
			return cb_newInserter;
		}

		static IntPtr n_NewInserter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ObjectDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewInserter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']/method[@name='newInserter' and count(parameter)=0]"
		[Register ("newInserter", "()Lorg/eclipse/jgit/lib/ObjectInserter;", "GetNewInserterHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectInserter NewInserter ()
		{
			const string __id = "newInserter.()Lorg/eclipse/jgit/lib/ObjectInserter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}
		*/
		static Delegate cb_newReader;
#pragma warning disable 0169
		static Delegate GetNewReaderHandler ()
		{
			if (cb_newReader == null)
				cb_newReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewReader);
			return cb_newReader;
		}

		static IntPtr n_NewReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ObjectDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewReader ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']/method[@name='newReader' and count(parameter)=0]"
		[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ()
		{
			const string __id = "newReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_openPack_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetOpenPack_Ljava_io_File_Handler ()
		{
			if (cb_openPack_Ljava_io_File_ == null)
				cb_openPack_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OpenPack_Ljava_io_File_);
			return cb_openPack_Ljava_io_File_;
		}

		static IntPtr n_OpenPack_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ObjectDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pack = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_pack, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenPack (pack));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pack">path of the pack file to open.</param>
		/// <summary>Add a single existing pack to the list of available pack files.</summary>
		/// <returns>the pack that was opened and added to the database.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ObjectDirectory']/method[@name='openPack' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("openPack", "(Ljava/io/File;)Lorg/eclipse/jgit/internal/storage/file/PackFile;", "GetOpenPack_Ljava_io_File_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile OpenPack (global::Java.IO.File pack)
		{
			const string __id = "openPack.(Ljava/io/File;)Lorg/eclipse/jgit/internal/storage/file/PackFile;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pack).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (pack);
			}
		}

	}
}
