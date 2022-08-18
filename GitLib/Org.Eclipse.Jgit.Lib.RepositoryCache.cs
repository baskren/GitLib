using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Cache of active <c>Repository</c> instances.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RepositoryCache", DoNotGenerateAcw=true)]
	public partial class RepositoryCache : global::Java.Lang.Object {
		/// <summary>Location of a Repository, using the standard java.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache.FileKey']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RepositoryCache$FileKey", DoNotGenerateAcw=true)]
		public partial class FileKey : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Lib.RepositoryCache.IKey {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RepositoryCache$FileKey", typeof (FileKey));

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

			protected FileKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="directory">exact location of the repository.</param>
			/// <param name="fs">the file system abstraction which will be necessary to
			///            perform certain file system operations.</param>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache.FileKey']/constructor[@name='RepositoryCache.FileKey' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
			[Register (".ctor", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V", "")]
			protected unsafe FileKey (global::Java.IO.File directory, global::Org.Eclipse.Jgit.Util.FS fs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
					__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (directory);
					global::System.GC.KeepAlive (fs);
				}
			}

			/// <returns>location supplied to the constructor.</returns>
			public unsafe global::Java.IO.File File {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache.FileKey']/method[@name='getFile' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache.FileKey']/method[@name='exact' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
			[Register ("exact", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/lib/RepositoryCache$FileKey;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.RepositoryCache.FileKey Exact (global::Java.IO.File directory, global::Org.Eclipse.Jgit.Util.FS fs)
			{
				const string __id = "exact.(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/lib/RepositoryCache$FileKey;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
					__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryCache.FileKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (directory);
					global::System.GC.KeepAlive (fs);
				}
			}

			/// <param name="dir">the location of the directory to examine.</param>
			/// <param name="fs">the file system abstraction which will be necessary to
			///            perform certain file system operations.</param>
			/// <summary>Guess if a directory contains a Git repository.</summary>
			/// <returns>true if the directory "looks like" a Git repository; false if
			///         it doesn't look enough like a Git directory to really be a
			///         Git directory.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache.FileKey']/method[@name='isGitRepository' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
			[Register ("isGitRepository", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Z", "")]
			public static unsafe bool IsGitRepository (global::Java.IO.File dir, global::Org.Eclipse.Jgit.Util.FS fs)
			{
				const string __id = "isGitRepository.(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
					__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (dir);
					global::System.GC.KeepAlive (fs);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache.FileKey']/method[@name='lenient' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
			[Register ("lenient", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/lib/RepositoryCache$FileKey;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.RepositoryCache.FileKey Lenient (global::Java.IO.File directory, global::Org.Eclipse.Jgit.Util.FS fs)
			{
				const string __id = "lenient.(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/lib/RepositoryCache$FileKey;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
					__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryCache.FileKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (directory);
					global::System.GC.KeepAlive (fs);
				}
			}

			static Delegate cb_open_Z;
#pragma warning disable 0169
			static Delegate GetOpen_ZHandler ()
			{
				if (cb_open_Z == null)
					cb_open_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Open_Z);
				return cb_open_Z;
			}

			static IntPtr n_Open_Z (IntPtr jnienv, IntPtr native__this, bool mustExist)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryCache.FileKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Open (mustExist));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache.FileKey']/method[@name='open' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("open", "(Z)Lorg/eclipse/jgit/lib/Repository;", "GetOpen_ZHandler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Open (bool mustExist)
			{
				const string __id = "open.(Z)Lorg/eclipse/jgit/lib/Repository;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (mustExist);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			/// <param name="directory">location to guess from. Several permutations are tried.</param>
			/// <param name="fs">the file system abstraction which will be necessary to
			///            perform certain file system operations.</param>
			/// <summary>Guess the proper path for a Git repository.</summary>
			/// <returns>the actual directory location if a better match is found;
			///         null if there is no suitable match.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache.FileKey']/method[@name='resolve' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
			[Register ("resolve", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Ljava/io/File;", "")]
			public static unsafe global::Java.IO.File Resolve (global::Java.IO.File directory, global::Org.Eclipse.Jgit.Util.FS fs)
			{
				const string __id = "resolve.(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)Ljava/io/File;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
					__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (directory);
					global::System.GC.KeepAlive (fs);
				}
			}

		}

		/// <summary>Abstract hash key for <c>RepositoryCache</c> entries.</summary>
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='RepositoryCache.Key']"
		[Register ("org/eclipse/jgit/lib/RepositoryCache$Key", "", "Org.Eclipse.Jgit.Lib.RepositoryCache/IKeyInvoker")]
		public partial interface IKey : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='RepositoryCache.Key']/method[@name='open' and count(parameter)=1 and parameter[1][@type='boolean']]"
			/// <param name="mustExist">true if the repository must exist in order to be opened;
			///            false if a new non-existent repository is permitted to be
			///            created (the caller is responsible for calling create).</param>
			/// <summary>Called by <c>RepositoryCache#open(Key)</c> if it doesn't exist yet.</summary>
			/// <returns>the new repository instance.</returns>
			[Register ("open", "(Z)Lorg/eclipse/jgit/lib/Repository;", "GetOpen_ZHandler:Org.Eclipse.Jgit.Lib.RepositoryCache/IKeyInvoker, AndroidBindableLibrary")]
			global::Org.Eclipse.Jgit.Lib.Repository Open (bool mustExist);

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RepositoryCache$Key", DoNotGenerateAcw=true)]
		internal partial class IKeyInvoker : global::Java.Lang.Object, IKey {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RepositoryCache$Key", typeof (IKeyInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IKey GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IKey> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.RepositoryCache.Key'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IKeyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_open_Z;
#pragma warning disable 0169
			static Delegate GetOpen_ZHandler ()
			{
				if (cb_open_Z == null)
					cb_open_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Open_Z);
				return cb_open_Z;
			}

			static IntPtr n_Open_Z (IntPtr jnienv, IntPtr native__this, bool mustExist)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryCache.IKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Open (mustExist));
			}
#pragma warning restore 0169

			IntPtr id_open_Z;
			public unsafe global::Org.Eclipse.Jgit.Lib.Repository Open (bool mustExist)
			{
				if (id_open_Z == IntPtr.Zero)
					id_open_Z = JNIEnv.GetMethodID (class_ref, "open", "(Z)Lorg/eclipse/jgit/lib/Repository;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mustExist);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_open_Z, __args), JniHandleOwnership.TransferLocalRef);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RepositoryCache", typeof (RepositoryCache));

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

		protected RepositoryCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Unregister all repositories from the cache.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public static unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		/// <param name="db">repository to unregister.</param>
		/// <summary>Remove a repository from the cache.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache']/method[@name='close' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("close", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public static unsafe void Close (global::Org.Eclipse.Jgit.Lib.Repository db)
		{
			const string __id = "close.(Lorg/eclipse/jgit/lib/Repository;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache']/method[@name='open' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.RepositoryCache.Key']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/RepositoryCache$Key;)Lorg/eclipse/jgit/lib/Repository;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.Repository Open (global::Org.Eclipse.Jgit.Lib.RepositoryCache.IKey location)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/RepositoryCache$Key;)Lorg/eclipse/jgit/lib/Repository;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((location == null) ? IntPtr.Zero : ((global::Java.Lang.Object) location).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (location);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.RepositoryCache.Key'] and parameter[2][@type='boolean']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/RepositoryCache$Key;Z)Lorg/eclipse/jgit/lib/Repository;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.Repository Open (global::Org.Eclipse.Jgit.Lib.RepositoryCache.IKey location, bool mustExist)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/RepositoryCache$Key;Z)Lorg/eclipse/jgit/lib/Repository;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((location == null) ? IntPtr.Zero : ((global::Java.Lang.Object) location).Handle);
				__args [1] = new JniArgumentValue (mustExist);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (location);
			}
		}

		/// <param name="db">repository to register.</param>
		/// <summary>Register one repository into the cache.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryCache']/method[@name='register' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("register", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public static unsafe void Register (global::Org.Eclipse.Jgit.Lib.Repository db)
		{
			const string __id = "register.(Lorg/eclipse/jgit/lib/Repository;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

	}
}
