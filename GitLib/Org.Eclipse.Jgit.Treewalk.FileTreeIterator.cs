using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk {

	/// <summary>Working directory iterator for standard Java IO.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/FileTreeIterator", DoNotGenerateAcw=true)]
	public partial class FileTreeIterator : global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator {

		/// <summary>the file system abstraction which will be necessary to perform certain
		/// file system operations.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator']/field[@name='fs']"
		[Register ("fs")]
		protected global::Org.Eclipse.Jgit.Util.FS Fs {
			get {
				const string __id = "fs.Lorg/eclipse/jgit/util/FS;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fs.Lorg/eclipse/jgit/util/FS;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		/// <summary>Wrapper for a standard Java IO file</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator.FileEntry']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/FileTreeIterator$FileEntry", DoNotGenerateAcw=true)]
		public partial class FileEntry : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/FileTreeIterator$FileEntry", typeof (FileEntry));

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

			protected FileEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="f">file</param>
			/// <param name="fs">file system</param>
			/// <summary>Create a new file entry.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator.FileEntry']/constructor[@name='FileTreeIterator.FileEntry' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
			[Register (".ctor", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V", "")]
			public unsafe FileEntry (global::Java.IO.File f, global::Org.Eclipse.Jgit.Util.FS fs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
					__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (f);
					global::System.GC.KeepAlive (fs);
				}
			}

			static Delegate cb_getFile;
#pragma warning disable 0169
			static Delegate GetGetFileHandler ()
			{
				if (cb_getFile == null)
					cb_getFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFile);
				return cb_getFile;
			}

			static IntPtr n_GetFile (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator.FileEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.File);
			}
#pragma warning restore 0169

			/// <summary>Get the underlying file of this entry.</summary>
			/// <returns>the underlying file of this entry</returns>
			public virtual unsafe global::Java.IO.File File {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator.FileEntry']/method[@name='getFile' and count(parameter)=0]"
				[Register ("getFile", "()Ljava/io/File;", "GetGetFileHandler")]
				get {
					const string __id = "getFile.()Ljava/io/File;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getLastModified;
#pragma warning disable 0169
			static Delegate GetGetLastModifiedHandler ()
			{
				if (cb_getLastModified == null)
					cb_getLastModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLastModified);
				return cb_getLastModified;
			}

			static long n_GetLastModified (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator.FileEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LastModified;
			}
#pragma warning restore 0169

			public virtual unsafe long LastModified {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator.FileEntry']/method[@name='getLastModified' and count(parameter)=0]"
				[Register ("getLastModified", "()J", "GetGetLastModifiedHandler")]
				get {
					const string __id = "getLastModified.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getLength;
#pragma warning disable 0169
			static Delegate GetGetLengthHandler ()
			{
				if (cb_getLength == null)
					cb_getLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLength);
				return cb_getLength;
			}

			static long n_GetLength (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator.FileEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Length;
			}
#pragma warning restore 0169

			public virtual unsafe long Length {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator.FileEntry']/method[@name='getLength' and count(parameter)=0]"
				[Register ("getLength", "()J", "GetGetLengthHandler")]
				get {
					const string __id = "getLength.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getMode;
#pragma warning disable 0169
			static Delegate GetGetModeHandler ()
			{
				if (cb_getMode == null)
					cb_getMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMode);
				return cb_getMode;
			}

			static IntPtr n_GetMode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator.FileEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Mode);
			}
#pragma warning restore 0169

			public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode Mode {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator.FileEntry']/method[@name='getMode' and count(parameter)=0]"
				[Register ("getMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetModeHandler")]
				get {
					const string __id = "getMode.()Lorg/eclipse/jgit/lib/FileMode;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator.FileEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			public virtual unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator.FileEntry']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_openInputStream;
#pragma warning disable 0169
			static Delegate GetOpenInputStreamHandler ()
			{
				if (cb_openInputStream == null)
					cb_openInputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenInputStream);
				return cb_openInputStream;
			}

			static IntPtr n_OpenInputStream (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator.FileEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.OpenInputStream ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator.FileEntry']/method[@name='openInputStream' and count(parameter)=0]"
			[Register ("openInputStream", "()Ljava/io/InputStream;", "GetOpenInputStreamHandler")]
			public virtual unsafe global::System.IO.Stream OpenInputStream ()
			{
				const string __id = "openInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator.FileEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator.FileEntry']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler")]
			public override unsafe string ToString ()
			{
				const string __id = "toString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/FileTreeIterator", typeof (FileTreeIterator));

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

		protected FileTreeIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="root">the starting directory. This directory should correspond to
		///            the root of the repository.</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <param name="options">working tree options to be used</param>
		/// <summary>Create a new iterator to traverse the given directory and its children.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator']/constructor[@name='FileTreeIterator' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS'] and parameter[3][@type='org.eclipse.jgit.treewalk.WorkingTreeOptions']]"
		[Register (".ctor", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;Lorg/eclipse/jgit/treewalk/WorkingTreeOptions;)V", "")]
		public unsafe FileTreeIterator (global::Java.IO.File root, global::Org.Eclipse.Jgit.Util.FS fs, global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions options) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;Lorg/eclipse/jgit/treewalk/WorkingTreeOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((root == null) ? IntPtr.Zero : ((global::Java.Lang.Object) root).Handle);
				__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (root);
				global::System.GC.KeepAlive (fs);
				global::System.GC.KeepAlive (options);
			}
		}

		/// <param name="repo">the repository whose working tree will be scanned.</param>
		/// <summary>Create a new iterator to traverse the work tree and its children.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator']/constructor[@name='FileTreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe FileTreeIterator (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		/// <param name="p">the parent iterator we were created from.</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <param name="root">the subdirectory. This should be a directory contained within
		///            the parent directory.</param>
		/// <summary>Create a new iterator to traverse a subdirectory.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator']/constructor[@name='FileTreeIterator' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator'] and parameter[2][@type='java.io.File'] and parameter[3][@type='org.eclipse.jgit.util.FS']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V", "")]
		protected unsafe FileTreeIterator (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator p, global::Java.IO.File root, global::Org.Eclipse.Jgit.Util.FS fs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [1] = new JniArgumentValue ((root == null) ? IntPtr.Zero : ((global::Java.Lang.Object) root).Handle);
				__args [2] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p);
				global::System.GC.KeepAlive (root);
				global::System.GC.KeepAlive (fs);
			}
		}

		static Delegate cb_getDirectory;
#pragma warning disable 0169
		static Delegate GetGetDirectoryHandler ()
		{
			if (cb_getDirectory == null)
				cb_getDirectory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDirectory);
			return cb_getDirectory;
		}

		static IntPtr n_GetDirectory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Directory);
		}
#pragma warning restore 0169

		/// <returns>The root directory of this iterator</returns>
		public virtual unsafe global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "GetGetDirectoryHandler")]
			get {
				const string __id = "getDirectory.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEntryFile;
#pragma warning disable 0169
		static Delegate GetGetEntryFileHandler ()
		{
			if (cb_getEntryFile == null)
				cb_getEntryFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEntryFile);
			return cb_getEntryFile;
		}

		static IntPtr n_GetEntryFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EntryFile);
		}
#pragma warning restore 0169

		/// <returns>The location of the working file. This is the same as <c>new
		///         File(getDirectory(), getEntryPath())</c> but may be faster by
		///         reusing an internal File instance.</returns>
		public virtual unsafe global::Java.IO.File EntryFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator']/method[@name='getEntryFile' and count(parameter)=0]"
			[Register ("getEntryFile", "()Ljava/io/File;", "GetGetEntryFileHandler")]
			get {
				const string __id = "getEntryFile.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_;
#pragma warning disable 0169
		static Delegate GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Handler ()
		{
			if (cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_ == null)
				cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_);
			return cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_;
		}

		static IntPtr n_CreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.FileTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSubtreeIterator (reader));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='FileTreeIterator']/method[@name='createSubtreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register ("createSubtreeIterator", "(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;", "GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator CreateSubtreeIterator (global::Org.Eclipse.Jgit.Lib.ObjectReader reader)
		{
			const string __id = "createSubtreeIterator.(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

	}
}
