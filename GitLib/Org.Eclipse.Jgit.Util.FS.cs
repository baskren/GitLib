using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Abstraction to support various file system operations not in Java.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/FS", DoNotGenerateAcw=true)]
	public abstract partial class FS : global::Java.Lang.Object {

		/// <summary>The auto-detected implementation selected for this operating system and JRE.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/field[@name='DETECTED']"
		[Register ("DETECTED")]
		public static global::Org.Eclipse.Jgit.Util.FS Detected {
			get {
				const string __id = "DETECTED.Lorg/eclipse/jgit/util/FS;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>File attributes we typically care for.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/FS$Attributes", DoNotGenerateAcw=true)]
		public partial class Attributes : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/FS$Attributes", typeof (Attributes));

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

			protected Attributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="fs">fs</param>
			/// <param name="path">path</param>
			/// <summary>Constructor when there are issues with reading</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/constructor[@name='FS.Attributes' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
			[Register (".ctor", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V", "")]
			public unsafe Attributes (global::Java.IO.File path, global::Org.Eclipse.Jgit.Util.FS fs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
					__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (path);
					global::System.GC.KeepAlive (fs);
				}
			}

			static Delegate cb_getCreationTime;
#pragma warning disable 0169
			static Delegate GetGetCreationTimeHandler ()
			{
				if (cb_getCreationTime == null)
					cb_getCreationTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCreationTime);
				return cb_getCreationTime;
			}

			static long n_GetCreationTime (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CreationTime;
			}
#pragma warning restore 0169

			/// <returns>the time when the file was created</returns>
			public virtual unsafe long CreationTime {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/method[@name='getCreationTime' and count(parameter)=0]"
				[Register ("getCreationTime", "()J", "GetGetCreationTimeHandler")]
				get {
					const string __id = "getCreationTime.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.File);
			}
#pragma warning restore 0169

			/// <returns>the file the attributes apply to</returns>
			public virtual unsafe global::Java.IO.File File {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/method[@name='getFile' and count(parameter)=0]"
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

			static Delegate cb_isDirectory;
#pragma warning disable 0169
			static Delegate GetIsDirectoryHandler ()
			{
				if (cb_isDirectory == null)
					cb_isDirectory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDirectory);
				return cb_isDirectory;
			}

			static bool n_IsDirectory (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsDirectory;
			}
#pragma warning restore 0169

			/// <returns>true if this are the attributes of a directory</returns>
			public virtual unsafe bool IsDirectory {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/method[@name='isDirectory' and count(parameter)=0]"
				[Register ("isDirectory", "()Z", "GetIsDirectoryHandler")]
				get {
					const string __id = "isDirectory.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_isExecutable;
#pragma warning disable 0169
			static Delegate GetIsExecutableHandler ()
			{
				if (cb_isExecutable == null)
					cb_isExecutable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExecutable);
				return cb_isExecutable;
			}

			static bool n_IsExecutable (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsExecutable;
			}
#pragma warning restore 0169

			/// <returns>true if this are the attributes of an executable file</returns>
			public virtual unsafe bool IsExecutable {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/method[@name='isExecutable' and count(parameter)=0]"
				[Register ("isExecutable", "()Z", "GetIsExecutableHandler")]
				get {
					const string __id = "isExecutable.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_isRegularFile;
#pragma warning disable 0169
			static Delegate GetIsRegularFileHandler ()
			{
				if (cb_isRegularFile == null)
					cb_isRegularFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRegularFile);
				return cb_isRegularFile;
			}

			static bool n_IsRegularFile (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsRegularFile;
			}
#pragma warning restore 0169

			/// <returns>true if this are the attributes of a regular file</returns>
			public virtual unsafe bool IsRegularFile {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/method[@name='isRegularFile' and count(parameter)=0]"
				[Register ("isRegularFile", "()Z", "GetIsRegularFileHandler")]
				get {
					const string __id = "isRegularFile.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_isSymbolicLink;
#pragma warning disable 0169
			static Delegate GetIsSymbolicLinkHandler ()
			{
				if (cb_isSymbolicLink == null)
					cb_isSymbolicLink = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSymbolicLink);
				return cb_isSymbolicLink;
			}

			static bool n_IsSymbolicLink (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSymbolicLink;
			}
#pragma warning restore 0169

			/// <returns>true if this are the attributes of a symbolic link</returns>
			public virtual unsafe bool IsSymbolicLink {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/method[@name='isSymbolicLink' and count(parameter)=0]"
				[Register ("isSymbolicLink", "()Z", "GetIsSymbolicLinkHandler")]
				get {
					const string __id = "isSymbolicLink.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getLastModifiedTime;
#pragma warning disable 0169
			static Delegate GetGetLastModifiedTimeHandler ()
			{
				if (cb_getLastModifiedTime == null)
					cb_getLastModifiedTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLastModifiedTime);
				return cb_getLastModifiedTime;
			}

			static long n_GetLastModifiedTime (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LastModifiedTime;
			}
#pragma warning restore 0169

			/// <returns>the time (milliseconds since 1970-01-01) when this object was
			///         last modified</returns>
			public virtual unsafe long LastModifiedTime {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/method[@name='getLastModifiedTime' and count(parameter)=0]"
				[Register ("getLastModifiedTime", "()J", "GetGetLastModifiedTimeHandler")]
				get {
					const string __id = "getLastModifiedTime.()J";
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Length;
			}
#pragma warning restore 0169

			/// <returns>length of this file object</returns>
			public virtual unsafe long Length {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/method[@name='getLength' and count(parameter)=0]"
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			/// <returns>the filename</returns>
			public virtual unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.Attributes']/method[@name='getName' and count(parameter)=0]"
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

		}

		/// <summary>This class creates FS instances.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.FSFactory']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/FS$FSFactory", DoNotGenerateAcw=true)]
		public partial class FSFactory : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/FS$FSFactory", typeof (FSFactory));

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

			protected FSFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <summary>Constructor</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.FSFactory']/constructor[@name='FS.FSFactory' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe FSFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_detect_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetDetect_Ljava_lang_Boolean_Handler ()
			{
				if (cb_detect_Ljava_lang_Boolean_ == null)
					cb_detect_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Detect_Ljava_lang_Boolean_);
				return cb_detect_Ljava_lang_Boolean_;
			}

			static IntPtr n_Detect_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cygwinUsed)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.FSFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cygwinUsed = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_cygwinUsed, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Detect (cygwinUsed));
				return __ret;
			}
#pragma warning restore 0169

			/// <param name="cygwinUsed">cygwinUsed</param>
			/// <summary>Detect the file system</summary>
			/// <returns>FS instance</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS.FSFactory']/method[@name='detect' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("detect", "(Ljava/lang/Boolean;)Lorg/eclipse/jgit/util/FS;", "GetDetect_Ljava_lang_Boolean_Handler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Util.FS Detect (global::Java.Lang.Boolean cygwinUsed)
			{
				const string __id = "detect.(Ljava/lang/Boolean;)Lorg/eclipse/jgit/util/FS;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cygwinUsed == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cygwinUsed).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (cygwinUsed);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/FS", typeof (FS));

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

		protected FS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Constructs a file system abstraction.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/constructor[@name='FS' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe FS () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="src">the source FS to copy from.</param>
		/// <summary>Initialize this FS using another's current settings.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/constructor[@name='FS' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.FS']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/util/FS;)V", "")]
		protected unsafe FS (global::Org.Eclipse.Jgit.Util.FS src) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/util/FS;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		static Delegate cb_isCaseSensitive;
#pragma warning disable 0169
		static Delegate GetIsCaseSensitiveHandler ()
		{
			if (cb_isCaseSensitive == null)
				cb_isCaseSensitive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCaseSensitive);
			return cb_isCaseSensitive;
		}

		static bool n_IsCaseSensitive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCaseSensitive;
		}
#pragma warning restore 0169

		public abstract bool IsCaseSensitive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='isCaseSensitive' and count(parameter)=0]"
			[Register ("isCaseSensitive", "()Z", "GetIsCaseSensitiveHandler")]
			get; 
		}

		static Delegate cb_canExecute_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetCanExecute_Ljava_io_File_Handler ()
		{
			if (cb_canExecute_Ljava_io_File_ == null)
				cb_canExecute_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanExecute_Ljava_io_File_);
			return cb_canExecute_Ljava_io_File_;
		}

		static bool n_CanExecute_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_f, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanExecute (f);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="f">abstract path to test.</param>
		/// <summary>Determine if the file is executable (or not).</summary>
		/// <returns>true if the file is believed to be executable by the user.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='canExecute' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("canExecute", "(Ljava/io/File;)Z", "GetCanExecute_Ljava_io_File_Handler")]
		public abstract bool CanExecute (global::Java.IO.File f);

		static Delegate cb_createSymLink_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateSymLink_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_createSymLink_Ljava_io_File_Ljava_lang_String_ == null)
				cb_createSymLink_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CreateSymLink_Ljava_io_File_Ljava_lang_String_);
			return cb_createSymLink_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_CreateSymLink_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			var target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			__this.CreateSymLink (path, target);
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <param name="target">target</param>
		/// <summary>Create a symbolic link</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='createSymLink' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("createSymLink", "(Ljava/io/File;Ljava/lang/String;)V", "GetCreateSymLink_Ljava_io_File_Ljava_lang_String_Handler")]
		public virtual unsafe void CreateSymLink (global::Java.IO.File path, string target)
		{
			const string __id = "createSymLink.(Ljava/io/File;Ljava/lang/String;)V";
			IntPtr native_target = JNIEnv.NewString ((string)target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				__args [1] = new JniArgumentValue (native_target);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_delete_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_io_File_Handler ()
		{
			if (cb_delete_Ljava_io_File_ == null)
				cb_delete_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_Ljava_io_File_);
			return cb_delete_Ljava_io_File_;
		}

		static void n_Delete_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.Delete (f);
		}
#pragma warning restore 0169

		/// <param name="f">f</param>
		/// <summary>Delete a file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("delete", "(Ljava/io/File;)V", "GetDelete_Ljava_io_File_Handler")]
		public virtual unsafe void Delete (global::Java.IO.File f)
		{
			const string __id = "delete.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		/// <summary>Auto-detect the appropriate file system abstraction.</summary>
		/// <returns>detected file system abstraction</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='detect' and count(parameter)=0]"
		[Register ("detect", "()Lorg/eclipse/jgit/util/FS;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Util.FS Detect ()
		{
			const string __id = "detect.()Lorg/eclipse/jgit/util/FS;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="cygwinUsed">&lt;ul&gt;
		///            &lt;li&gt;&lt;code&gt;Boolean.TRUE&lt;/code&gt; to assume that Cygwin is used in
		///            combination with jgit&lt;/li&gt;
		///            &lt;li&gt;&lt;code&gt;Boolean.FALSE&lt;/code&gt; to assume that Cygwin is
		///            &lt;b&gt;not&lt;/b&gt; used with jgit&lt;/li&gt;
		///            &lt;li&gt;&lt;code&gt;null&lt;/code&gt; to auto-detect whether a Cygwin
		///            installation is present on the system and in this case assume
		///            that Cygwin is used&lt;/li&gt;
		///            &lt;/ul&gt;
		/// 
		///            Note: this parameter is only relevant on Windows.</param>
		/// <summary>Auto-detect the appropriate file system abstraction, taking into account
		/// the presence of a Cygwin installation on the system.</summary>
		/// <returns>detected file system abstraction</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='detect' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("detect", "(Ljava/lang/Boolean;)Lorg/eclipse/jgit/util/FS;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Util.FS Detect (global::Java.Lang.Boolean cygwinUsed)
		{
			const string __id = "detect.(Ljava/lang/Boolean;)Lorg/eclipse/jgit/util/FS;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cygwinUsed == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cygwinUsed).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cygwinUsed);
			}
		}

		static Delegate cb_discoverGitPrefix;
#pragma warning disable 0169
		static Delegate GetDiscoverGitPrefixHandler ()
		{
			if (cb_discoverGitPrefix == null)
				cb_discoverGitPrefix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DiscoverGitPrefix);
			return cb_discoverGitPrefix;
		}

		static IntPtr n_DiscoverGitPrefix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DiscoverGitPrefix ());
		}
#pragma warning restore 0169

		/// <returns>the $prefix directory C Git would use.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='discoverGitPrefix' and count(parameter)=0]"
		[Register ("discoverGitPrefix", "()Ljava/io/File;", "GetDiscoverGitPrefixHandler")]
		protected abstract global::Java.IO.File DiscoverGitPrefix ();

		static Delegate cb_exists_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetExists_Ljava_io_File_Handler ()
		{
			if (cb_exists_Ljava_io_File_ == null)
				cb_exists_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Exists_Ljava_io_File_);
			return cb_exists_Ljava_io_File_;
		}

		static bool n_Exists_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Exists (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <summary>Tests if the path exists, in case of a symbolic link, true even if the
		/// target does not exist</summary>
		/// <returns>true if path exists</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='exists' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("exists", "(Ljava/io/File;)Z", "GetExists_Ljava_io_File_Handler")]
		public virtual unsafe bool Exists (global::Java.IO.File path)
		{
			const string __id = "exists.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_findHook_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_;
#pragma warning disable 0169
		static Delegate GetFindHook_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_Handler ()
		{
			if (cb_findHook_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_ == null)
				cb_findHook_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_FindHook_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_);
			return cb_findHook_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_;
		}

		static IntPtr n_FindHook_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repository, IntPtr native_hook)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var repository = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repository, JniHandleOwnership.DoNotTransfer);
			var hook = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (native_hook, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindHook (repository, hook));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="repository">The repository within which to find a hook.</param>
		/// <param name="hook">The hook we're trying to find.</param>
		/// <summary>Tries to find a hook matching the given one in the given repository.</summary>
		/// <returns>The <c>File</c> containing this particular hook if it exists in
		///         the given repository, &lt;code&gt;null&lt;/code&gt; otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='findHook' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.util.Hook']]"
		[Register ("findHook", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/util/Hook;)Ljava/io/File;", "GetFindHook_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_Handler")]
		public virtual unsafe global::Java.IO.File FindHook (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Util.Hook hook)
		{
			const string __id = "findHook.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/util/Hook;)Ljava/io/File;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((hook == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hook).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (hook);
			}
		}

		static Delegate cb_getAttributes_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetGetAttributes_Ljava_io_File_Handler ()
		{
			if (cb_getAttributes_Ljava_io_File_ == null)
				cb_getAttributes_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAttributes_Ljava_io_File_);
			return cb_getAttributes_Ljava_io_File_;
		}

		static IntPtr n_GetAttributes_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAttributes (path));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='getAttributes' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getAttributes", "(Ljava/io/File;)Lorg/eclipse/jgit/util/FS$Attributes;", "GetGetAttributes_Ljava_io_File_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Util.FS.Attributes GetAttributes (global::Java.IO.File path)
		{
			const string __id = "getAttributes.(Ljava/io/File;)Lorg/eclipse/jgit/util/FS$Attributes;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS.Attributes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_gitPrefix;
#pragma warning disable 0169
		static Delegate GetGitPrefixHandler ()
		{
			if (cb_gitPrefix == null)
				cb_gitPrefix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GitPrefix);
			return cb_gitPrefix;
		}

		static IntPtr n_GitPrefix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GitPrefix ());
		}
#pragma warning restore 0169

		/// <returns>the $prefix directory C Git would use.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='gitPrefix' and count(parameter)=0]"
		[Register ("gitPrefix", "()Ljava/io/File;", "GetGitPrefixHandler")]
		public virtual unsafe global::Java.IO.File GitPrefix ()
		{
			const string __id = "gitPrefix.()Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_internalRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInternalRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_Handler ()
		{
			if (cb_internalRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_ == null)
				cb_internalRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLL_L) n_InternalRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_);
			return cb_internalRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_;
		}

		static IntPtr n_InternalRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repository, IntPtr native_hook, IntPtr native_args, IntPtr native_outRedirect, IntPtr native_errRedirect, IntPtr native_stdinArgs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var repository = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repository, JniHandleOwnership.DoNotTransfer);
			var hook = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (native_hook, JniHandleOwnership.DoNotTransfer);
			var args = (string[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (string));
			var outRedirect = global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (native_outRedirect, JniHandleOwnership.DoNotTransfer);
			var errRedirect = global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (native_errRedirect, JniHandleOwnership.DoNotTransfer);
			var stdinArgs = JNIEnv.GetString (native_stdinArgs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalRunIfPresent (repository, hook, args, outRedirect, errRedirect, stdinArgs));
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="repository">The repository for which a hook should be run.</param>
		/// <param name="hook">The hook to be executed.</param>
		/// <param name="args">Arguments to pass to this hook. Cannot be &lt;code&gt;null&lt;/code&gt;,
		///            but can be an empty array.</param>
		/// <param name="outRedirect">A print stream on which to redirect the hook's stdout. Can be
		///            &lt;code&gt;null&lt;/code&gt;, in which case the hook's standard output
		///            will be lost.</param>
		/// <param name="errRedirect">A print stream on which to redirect the hook's stderr. Can be
		///            &lt;code&gt;null&lt;/code&gt;, in which case the hook's standard error
		///            will be lost.</param>
		/// <param name="stdinArgs">A string to pass on to the standard input of the hook. May be
		///            &lt;code&gt;null&lt;/code&gt;.</param>
		/// <summary>See
		/// <c>#runIfPresent(Repository, Hook, String[], PrintStream, PrintStream, String)</c>
		/// .</summary>
		/// <returns>The ProcessResult describing this hook's execution.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='internalRunIfPresent' and count(parameter)=6 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.util.Hook'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.io.PrintStream'] and parameter[5][@type='java.io.PrintStream'] and parameter[6][@type='java.lang.String']]"
		[Register ("internalRunIfPresent", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/util/Hook;[Ljava/lang/String;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/lang/String;)Lorg/eclipse/jgit/util/ProcessResult;", "GetInternalRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Util.ProcessResult InternalRunIfPresent (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Util.Hook hook, string[] args, global::Java.IO.PrintStream outRedirect, global::Java.IO.PrintStream errRedirect, string stdinArgs)
		{
			const string __id = "internalRunIfPresent.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/util/Hook;[Ljava/lang/String;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/lang/String;)Lorg/eclipse/jgit/util/ProcessResult;";
			IntPtr native_args = JNIEnv.NewArray (args);
			IntPtr native_stdinArgs = JNIEnv.NewString ((string)stdinArgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((hook == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hook).Handle);
				__args [2] = new JniArgumentValue (native_args);
				__args [3] = new JniArgumentValue ((outRedirect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outRedirect).Handle);
				__args [4] = new JniArgumentValue ((errRedirect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errRedirect).Handle);
				__args [5] = new JniArgumentValue (native_stdinArgs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				JNIEnv.DeleteLocalRef (native_stdinArgs);
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (hook);
				global::System.GC.KeepAlive (args);
				global::System.GC.KeepAlive (outRedirect);
				global::System.GC.KeepAlive (errRedirect);
			}
		}

		static Delegate cb_isDirectory_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetIsDirectory_Ljava_io_File_Handler ()
		{
			if (cb_isDirectory_Ljava_io_File_ == null)
				cb_isDirectory_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsDirectory_Ljava_io_File_);
			return cb_isDirectory_Ljava_io_File_;
		}

		static bool n_IsDirectory_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDirectory (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <summary>Check if path is a directory.</summary>
		/// <returns>true if file is a directory,</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='isDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("isDirectory", "(Ljava/io/File;)Z", "GetIsDirectory_Ljava_io_File_Handler")]
		public virtual unsafe bool IsDirectory (global::Java.IO.File path)
		{
			const string __id = "isDirectory.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_isFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetIsFile_Ljava_io_File_Handler ()
		{
			if (cb_isFile_Ljava_io_File_ == null)
				cb_isFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsFile_Ljava_io_File_);
			return cb_isFile_Ljava_io_File_;
		}

		static bool n_IsFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsFile (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <summary>Examine if path represents a regular file.</summary>
		/// <returns>true if path represents a regular file</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='isFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("isFile", "(Ljava/io/File;)Z", "GetIsFile_Ljava_io_File_Handler")]
		public virtual unsafe bool IsFile (global::Java.IO.File path)
		{
			const string __id = "isFile.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_isHidden_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetIsHidden_Ljava_io_File_Handler ()
		{
			if (cb_isHidden_Ljava_io_File_ == null)
				cb_isHidden_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsHidden_Ljava_io_File_);
			return cb_isHidden_Ljava_io_File_;
		}

		static bool n_IsHidden_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsHidden (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <returns>true if path is hidden, either starts with . on unix or has the
		///         hidden attribute in windows</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='isHidden' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("isHidden", "(Ljava/io/File;)Z", "GetIsHidden_Ljava_io_File_Handler")]
		public virtual unsafe bool IsHidden (global::Java.IO.File path)
		{
			const string __id = "isHidden.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_isSymLink_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetIsSymLink_Ljava_io_File_Handler ()
		{
			if (cb_isSymLink_Ljava_io_File_ == null)
				cb_isSymLink_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsSymLink_Ljava_io_File_);
			return cb_isSymLink_Ljava_io_File_;
		}

		static bool n_IsSymLink_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSymLink (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <returns>true if the path is a symbolic link (and we support these)</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='isSymLink' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("isSymLink", "(Ljava/io/File;)Z", "GetIsSymLink_Ljava_io_File_Handler")]
		public virtual unsafe bool IsSymLink (global::Java.IO.File path)
		{
			const string __id = "isSymLink.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_lastModified_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetLastModified_Ljava_io_File_Handler ()
		{
			if (cb_lastModified_Ljava_io_File_ == null)
				cb_lastModified_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_LastModified_Ljava_io_File_);
			return cb_lastModified_Ljava_io_File_;
		}

		static long n_LastModified_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_f, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.LastModified (f);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="f">f</param>
		/// <summary>Get the last modified time of a file system object.</summary>
		/// <returns>last modified time of f</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='lastModified' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("lastModified", "(Ljava/io/File;)J", "GetLastModified_Ljava_io_File_Handler")]
		public virtual unsafe long LastModified (global::Java.IO.File f)
		{
			const string __id = "lastModified.(Ljava/io/File;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		static Delegate cb_length_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetLength_Ljava_io_File_Handler ()
		{
			if (cb_length_Ljava_io_File_ == null)
				cb_length_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_Length_Ljava_io_File_);
			return cb_length_Ljava_io_File_;
		}

		static long n_Length_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Length (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <summary>Get the length of a file or link, If the OS/JRE supports symbolic links
		/// it's the length of the link, else the length of the target.</summary>
		/// <returns>length of a file</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='length' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("length", "(Ljava/io/File;)J", "GetLength_Ljava_io_File_Handler")]
		public virtual unsafe long Length (global::Java.IO.File path)
		{
			const string __id = "length.(Ljava/io/File;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_newInstance;
#pragma warning disable 0169
		static Delegate GetNewInstanceHandler ()
		{
			if (cb_newInstance == null)
				cb_newInstance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewInstance);
			return cb_newInstance;
		}

		static IntPtr n_NewInstance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewInstance ());
		}
#pragma warning restore 0169

		/// <returns>a new instance of the same type of FS.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lorg/eclipse/jgit/util/FS;", "GetNewInstanceHandler")]
		public abstract global::Org.Eclipse.Jgit.Util.FS NewInstance ();

		static Delegate cb_normalize_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetNormalize_Ljava_io_File_Handler ()
		{
			if (cb_normalize_Ljava_io_File_ == null)
				cb_normalize_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Normalize_Ljava_io_File_);
			return cb_normalize_Ljava_io_File_;
		}

		static IntPtr n_Normalize_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var file = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_file, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Normalize (file));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="file">file</param>
		/// <summary>Normalize the unicode path to composed form.</summary>
		/// <returns>NFC-format File</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("normalize", "(Ljava/io/File;)Ljava/io/File;", "GetNormalize_Ljava_io_File_Handler")]
		public virtual unsafe global::Java.IO.File Normalize (global::Java.IO.File file)
		{
			const string __id = "normalize.(Ljava/io/File;)Ljava/io/File;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (file);
			}
		}

		static Delegate cb_normalize_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNormalize_Ljava_lang_String_Handler ()
		{
			if (cb_normalize_Ljava_lang_String_ == null)
				cb_normalize_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Normalize_Ljava_lang_String_);
			return cb_normalize_Ljava_lang_String_;
		}

		static IntPtr n_Normalize_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Normalize (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">name</param>
		/// <summary>Normalize the unicode path to composed form.</summary>
		/// <returns>NFC-format string</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalize", "(Ljava/lang/String;)Ljava/lang/String;", "GetNormalize_Ljava_lang_String_Handler")]
		public virtual unsafe string Normalize (string name)
		{
			const string __id = "normalize.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		/// <param name="dir">Working directory for the command</param>
		/// <param name="command">as component array</param>
		/// <param name="encoding">encoding</param>
		/// <summary>Execute a command and return a single line of output as a String</summary>
		/// <returns>the one-line output of the command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='readPipe' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("readPipe", "(Ljava/io/File;[Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static unsafe string ReadPipe (global::Java.IO.File dir, string[] command, string encoding)
		{
			const string __id = "readPipe.(Ljava/io/File;[Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_command = JNIEnv.NewArray (command);
			IntPtr native_encoding = JNIEnv.NewString ((string)encoding);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				__args [1] = new JniArgumentValue (native_command);
				__args [2] = new JniArgumentValue (native_encoding);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (command != null) {
					JNIEnv.CopyArray (native_command, command);
					JNIEnv.DeleteLocalRef (native_command);
				}
				JNIEnv.DeleteLocalRef (native_encoding);
				global::System.GC.KeepAlive (dir);
				global::System.GC.KeepAlive (command);
			}
		}

		static Delegate cb_readSymLink_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetReadSymLink_Ljava_io_File_Handler ()
		{
			if (cb_readSymLink_Ljava_io_File_ == null)
				cb_readSymLink_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReadSymLink_Ljava_io_File_);
			return cb_readSymLink_Ljava_io_File_;
		}

		static IntPtr n_ReadSymLink_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ReadSymLink (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <summary>Check if a file is a symbolic link and read it</summary>
		/// <returns>target of link or null</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='readSymLink' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readSymLink", "(Ljava/io/File;)Ljava/lang/String;", "GetReadSymLink_Ljava_io_File_Handler")]
		public virtual unsafe string ReadSymLink (global::Java.IO.File path)
		{
			const string __id = "readSymLink.(Ljava/io/File;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_relativize_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRelativize_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_relativize_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_relativize_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Relativize_Ljava_lang_String_Ljava_lang_String_);
			return cb_relativize_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Relativize_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__base, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @base = JNIEnv.GetString (native__base, JniHandleOwnership.DoNotTransfer);
			var other = JNIEnv.GetString (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Relativize (@base, other));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="base">The path against which &lt;code&gt;other&lt;/code&gt; should be
		///            relativized.</param>
		/// <param name="other">The path that will be made relative to &lt;code&gt;base&lt;/code&gt;.</param>
		/// <summary>See <c>FileUtils#relativize(String, String)</c>.</summary>
		/// <returns>A relative path that, when resolved against &lt;code&gt;base&lt;/code&gt;,
		///         will yield the original &lt;code&gt;other&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='relativize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("relativize", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetRelativize_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string Relativize (string @base, string other)
		{
			const string __id = "relativize.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__base = JNIEnv.NewString ((string)@base);
			IntPtr native_other = JNIEnv.NewString ((string)other);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__base);
				__args [1] = new JniArgumentValue (native_other);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__base);
				JNIEnv.DeleteLocalRef (native_other);
			}
		}

		static Delegate cb_resolve_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResolve_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_resolve_Ljava_io_File_Ljava_lang_String_ == null)
				cb_resolve_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Resolve_Ljava_io_File_Ljava_lang_String_);
			return cb_resolve_Ljava_io_File_Ljava_lang_String_;
		}

		static IntPtr n_Resolve_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dir, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_dir, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Resolve (dir, name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="dir">directory relative to which the path name is.</param>
		/// <param name="name">path name to translate.</param>
		/// <summary>Resolve this file to its actual path name that the JRE can use.</summary>
		/// <returns>the translated path. &lt;code&gt;new File(dir,name)&lt;/code&gt; if this
		///         platform does not require path name translation.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='resolve' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("resolve", "(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;", "GetResolve_Ljava_io_File_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.IO.File Resolve (global::Java.IO.File dir, string name)
		{
			const string __id = "resolve.(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (dir);
			}
		}

		static Delegate cb_retryFailedLockFileCommit;
#pragma warning disable 0169
		static Delegate GetRetryFailedLockFileCommitHandler ()
		{
			if (cb_retryFailedLockFileCommit == null)
				cb_retryFailedLockFileCommit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_RetryFailedLockFileCommit);
			return cb_retryFailedLockFileCommit;
		}

		static bool n_RetryFailedLockFileCommit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryFailedLockFileCommit ();
		}
#pragma warning restore 0169

		/// <summary>Does this file system have problems with atomic renames?</summary>
		/// <returns>true if the caller should retry a failed rename of a lock file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='retryFailedLockFileCommit' and count(parameter)=0]"
		[Register ("retryFailedLockFileCommit", "()Z", "GetRetryFailedLockFileCommitHandler")]
		public abstract bool RetryFailedLockFileCommit ();

		static Delegate cb_runIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Handler ()
		{
			if (cb_runIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_ == null)
				cb_runIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_RunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_);
			return cb_runIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_;
		}

		static IntPtr n_RunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repository, IntPtr native_hook, IntPtr native_args)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var repository = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repository, JniHandleOwnership.DoNotTransfer);
			var hook = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (native_hook, JniHandleOwnership.DoNotTransfer);
			var args = (string[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RunIfPresent (repository, hook, args));
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="repository">The repository for which a hook should be run.</param>
		/// <param name="hook">The hook to be executed.</param>
		/// <param name="args">Arguments to pass to this hook. Cannot be &lt;code&gt;null&lt;/code&gt;,
		///            but can be an empty array.</param>
		/// <summary>Checks whether the given hook is defined for the given repository, then
		/// runs it with the given arguments.</summary>
		/// <returns>The ProcessResult describing this hook's execution.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='runIfPresent' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.util.Hook'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("runIfPresent", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/util/Hook;[Ljava/lang/String;)Lorg/eclipse/jgit/util/ProcessResult;", "GetRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Util.ProcessResult RunIfPresent (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Util.Hook hook, string[] args)
		{
			const string __id = "runIfPresent.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/util/Hook;[Ljava/lang/String;)Lorg/eclipse/jgit/util/ProcessResult;";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((hook == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hook).Handle);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (hook);
				global::System.GC.KeepAlive (args);
			}
		}

		static Delegate cb_runIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_Handler ()
		{
			if (cb_runIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_ == null)
				cb_runIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLL_L) n_RunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_);
			return cb_runIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_;
		}

		static IntPtr n_RunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repository, IntPtr native_hook, IntPtr native_args, IntPtr native_outRedirect, IntPtr native_errRedirect, IntPtr native_stdinArgs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var repository = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repository, JniHandleOwnership.DoNotTransfer);
			var hook = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.Hook> (native_hook, JniHandleOwnership.DoNotTransfer);
			var args = (string[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (string));
			var outRedirect = global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (native_outRedirect, JniHandleOwnership.DoNotTransfer);
			var errRedirect = global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (native_errRedirect, JniHandleOwnership.DoNotTransfer);
			var stdinArgs = JNIEnv.GetString (native_stdinArgs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RunIfPresent (repository, hook, args, outRedirect, errRedirect, stdinArgs));
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="repository">The repository for which a hook should be run.</param>
		/// <param name="hook">The hook to be executed.</param>
		/// <param name="args">Arguments to pass to this hook. Cannot be &lt;code&gt;null&lt;/code&gt;,
		///            but can be an empty array.</param>
		/// <param name="outRedirect">A print stream on which to redirect the hook's stdout. Can be
		///            &lt;code&gt;null&lt;/code&gt;, in which case the hook's standard output
		///            will be lost.</param>
		/// <param name="errRedirect">A print stream on which to redirect the hook's stderr. Can be
		///            &lt;code&gt;null&lt;/code&gt;, in which case the hook's standard error
		///            will be lost.</param>
		/// <param name="stdinArgs">A string to pass on to the standard input of the hook. May be
		///            &lt;code&gt;null&lt;/code&gt;.</param>
		/// <summary>Checks whether the given hook is defined for the given repository, then
		/// runs it with the given arguments.</summary>
		/// <returns>The ProcessResult describing this hook's execution.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='runIfPresent' and count(parameter)=6 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.util.Hook'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.io.PrintStream'] and parameter[5][@type='java.io.PrintStream'] and parameter[6][@type='java.lang.String']]"
		[Register ("runIfPresent", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/util/Hook;[Ljava/lang/String;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/lang/String;)Lorg/eclipse/jgit/util/ProcessResult;", "GetRunIfPresent_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_util_Hook_arrayLjava_lang_String_Ljava_io_PrintStream_Ljava_io_PrintStream_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Util.ProcessResult RunIfPresent (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Util.Hook hook, string[] args, global::Java.IO.PrintStream outRedirect, global::Java.IO.PrintStream errRedirect, string stdinArgs)
		{
			const string __id = "runIfPresent.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/util/Hook;[Ljava/lang/String;Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/lang/String;)Lorg/eclipse/jgit/util/ProcessResult;";
			IntPtr native_args = JNIEnv.NewArray (args);
			IntPtr native_stdinArgs = JNIEnv.NewString ((string)stdinArgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((hook == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hook).Handle);
				__args [2] = new JniArgumentValue (native_args);
				__args [3] = new JniArgumentValue ((outRedirect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outRedirect).Handle);
				__args [4] = new JniArgumentValue ((errRedirect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errRedirect).Handle);
				__args [5] = new JniArgumentValue (native_stdinArgs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				JNIEnv.DeleteLocalRef (native_stdinArgs);
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (hook);
				global::System.GC.KeepAlive (args);
				global::System.GC.KeepAlive (outRedirect);
				global::System.GC.KeepAlive (errRedirect);
			}
		}

		static Delegate cb_runInShell_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRunInShell_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_runInShell_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_runInShell_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_RunInShell_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_runInShell_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_RunInShell_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmd, IntPtr native_args)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmd = JNIEnv.GetString (native_cmd, JniHandleOwnership.DoNotTransfer);
			var args = (string[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RunInShell (cmd, args));
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="cmd">command to execute. This string should originate from the
		///            end-user, and thus is platform specific.</param>
		/// <param name="args">arguments to pass to command. These should be protected from
		///            shell evaluation.</param>
		/// <summary>Initialize a ProcesssBuilder to run a command using the system shell.</summary>
		/// <returns>a partially completed process builder. Caller should finish
		///         populating directory, environment, and then start the process.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='runInShell' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("runInShell", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/ProcessBuilder;", "GetRunInShell_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public abstract global::Java.Lang.ProcessBuilder RunInShell (string cmd, string[] args);

		static Delegate cb_runProcess_Ljava_lang_ProcessBuilder_Ljava_io_OutputStream_Ljava_io_OutputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRunProcess_Ljava_lang_ProcessBuilder_Ljava_io_OutputStream_Ljava_io_OutputStream_Ljava_lang_String_Handler ()
		{
			if (cb_runProcess_Ljava_lang_ProcessBuilder_Ljava_io_OutputStream_Ljava_io_OutputStream_Ljava_lang_String_ == null)
				cb_runProcess_Ljava_lang_ProcessBuilder_Ljava_io_OutputStream_Ljava_io_OutputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_I) n_RunProcess_Ljava_lang_ProcessBuilder_Ljava_io_OutputStream_Ljava_io_OutputStream_Ljava_lang_String_);
			return cb_runProcess_Ljava_lang_ProcessBuilder_Ljava_io_OutputStream_Ljava_io_OutputStream_Ljava_lang_String_;
		}

		static int n_RunProcess_Ljava_lang_ProcessBuilder_Ljava_io_OutputStream_Ljava_io_OutputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hookProcessBuilder, IntPtr native_outRedirect, IntPtr native_errRedirect, IntPtr native_stdinArgs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hookProcessBuilder = global::Java.Lang.Object.GetObject<global::Java.Lang.ProcessBuilder> (native_hookProcessBuilder, JniHandleOwnership.DoNotTransfer);
			var outRedirect = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_outRedirect, JniHandleOwnership.DoNotTransfer);
			var errRedirect = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_errRedirect, JniHandleOwnership.DoNotTransfer);
			var stdinArgs = JNIEnv.GetString (native_stdinArgs, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RunProcess (hookProcessBuilder, outRedirect, errRedirect, stdinArgs);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="hookProcessBuilder">The process builder configured for this hook.</param>
		/// <param name="outRedirect">A print stream on which to redirect the hook's stdout. Can be
		///            &lt;code&gt;null&lt;/code&gt;, in which case the hook's standard output
		///            will be lost.</param>
		/// <param name="errRedirect">A print stream on which to redirect the hook's stderr. Can be
		///            &lt;code&gt;null&lt;/code&gt;, in which case the hook's standard error
		///            will be lost.</param>
		/// <param name="stdinArgs">A string to pass on to the standard input of the hook. Can be
		///            &lt;code&gt;null&lt;/code&gt;.</param>
		/// <summary>Runs the given process until termination, clearing its stdout and stderr
		/// streams on-the-fly.</summary>
		/// <returns>the exit value of this hook.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='runProcess' and count(parameter)=4 and parameter[1][@type='java.lang.ProcessBuilder'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='java.io.OutputStream'] and parameter[4][@type='java.lang.String']]"
		[Register ("runProcess", "(Ljava/lang/ProcessBuilder;Ljava/io/OutputStream;Ljava/io/OutputStream;Ljava/lang/String;)I", "GetRunProcess_Ljava_lang_ProcessBuilder_Ljava_io_OutputStream_Ljava_io_OutputStream_Ljava_lang_String_Handler")]
		protected virtual unsafe int RunProcess (global::Java.Lang.ProcessBuilder hookProcessBuilder, global::System.IO.Stream outRedirect, global::System.IO.Stream errRedirect, string stdinArgs)
		{
			const string __id = "runProcess.(Ljava/lang/ProcessBuilder;Ljava/io/OutputStream;Ljava/io/OutputStream;Ljava/lang/String;)I";
			IntPtr native_outRedirect = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outRedirect);
			IntPtr native_errRedirect = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (errRedirect);
			IntPtr native_stdinArgs = JNIEnv.NewString ((string)stdinArgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((hookProcessBuilder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hookProcessBuilder).Handle);
				__args [1] = new JniArgumentValue (native_outRedirect);
				__args [2] = new JniArgumentValue (native_errRedirect);
				__args [3] = new JniArgumentValue (native_stdinArgs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_outRedirect);
				JNIEnv.DeleteLocalRef (native_errRedirect);
				JNIEnv.DeleteLocalRef (native_stdinArgs);
				global::System.GC.KeepAlive (hookProcessBuilder);
				global::System.GC.KeepAlive (outRedirect);
				global::System.GC.KeepAlive (errRedirect);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='searchPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("searchPath", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/io/File;", "")]
		protected static unsafe global::Java.IO.File SearchPath (string path, params string[] lookFor)
		{
			const string __id = "searchPath.(Ljava/lang/String;[Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			IntPtr native_lookFor = JNIEnv.NewArray (lookFor);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_lookFor);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				if (lookFor != null) {
					JNIEnv.CopyArray (native_lookFor, lookFor);
					JNIEnv.DeleteLocalRef (native_lookFor);
				}
				global::System.GC.KeepAlive (lookFor);
			}
		}

		static Delegate cb_setExecute_Ljava_io_File_Z;
#pragma warning disable 0169
		static Delegate GetSetExecute_Ljava_io_File_ZHandler ()
		{
			if (cb_setExecute_Ljava_io_File_Z == null)
				cb_setExecute_Ljava_io_File_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_SetExecute_Ljava_io_File_Z);
			return cb_setExecute_Ljava_io_File_Z;
		}

		static bool n_SetExecute_Ljava_io_File_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_f, bool canExec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_f, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetExecute (f, canExec);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="f">path to modify the executable status of.</param>
		/// <param name="canExec">true to enable execution; false to disable it.</param>
		/// <summary>Set a file to be executable by the user.</summary>
		/// <returns>true if the change succeeded; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='setExecute' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='boolean']]"
		[Register ("setExecute", "(Ljava/io/File;Z)Z", "GetSetExecute_Ljava_io_File_ZHandler")]
		public abstract bool SetExecute (global::Java.IO.File f, bool canExec);

		static Delegate cb_setGitPrefix_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetGitPrefix_Ljava_io_File_Handler ()
		{
			if (cb_setGitPrefix_Ljava_io_File_ == null)
				cb_setGitPrefix_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetGitPrefix_Ljava_io_File_);
			return cb_setGitPrefix_Ljava_io_File_;
		}

		static IntPtr n_SetGitPrefix_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGitPrefix (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">the directory. Null if C Git is not installed.</param>
		/// <summary>Set the $prefix directory C Git uses.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='setGitPrefix' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setGitPrefix", "(Ljava/io/File;)Lorg/eclipse/jgit/util/FS;", "GetSetGitPrefix_Ljava_io_File_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Util.FS SetGitPrefix (global::Java.IO.File path)
		{
			const string __id = "setGitPrefix.(Ljava/io/File;)Lorg/eclipse/jgit/util/FS;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_setHidden_Ljava_io_File_Z;
#pragma warning disable 0169
		static Delegate GetSetHidden_Ljava_io_File_ZHandler ()
		{
			if (cb_setHidden_Ljava_io_File_Z == null)
				cb_setHidden_Ljava_io_File_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_SetHidden_Ljava_io_File_Z);
			return cb_setHidden_Ljava_io_File_Z;
		}

		static void n_SetHidden_Ljava_io_File_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_path, bool hidden)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			__this.SetHidden (path, hidden);
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <param name="hidden">hidden</param>
		/// <summary>Set the hidden attribute for file whose name starts with a period.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='setHidden' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='boolean']]"
		[Register ("setHidden", "(Ljava/io/File;Z)V", "GetSetHidden_Ljava_io_File_ZHandler")]
		public virtual unsafe void SetHidden (global::Java.IO.File path, bool hidden)
		{
			const string __id = "setHidden.(Ljava/io/File;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				__args [1] = new JniArgumentValue (hidden);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_setLastModified_Ljava_io_File_J;
#pragma warning disable 0169
		static Delegate GetSetLastModified_Ljava_io_File_JHandler ()
		{
			if (cb_setLastModified_Ljava_io_File_J == null)
				cb_setLastModified_Ljava_io_File_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_V) n_SetLastModified_Ljava_io_File_J);
			return cb_setLastModified_Ljava_io_File_J;
		}

		static void n_SetLastModified_Ljava_io_File_J (IntPtr jnienv, IntPtr native__this, IntPtr native_f, long time)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.SetLastModified (f, time);
		}
#pragma warning restore 0169

		/// <param name="f">f</param>
		/// <param name="time">time</param>
		/// <summary>Set the last modified time of a file system object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='setLastModified' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='long']]"
		[Register ("setLastModified", "(Ljava/io/File;J)V", "GetSetLastModified_Ljava_io_File_JHandler")]
		public virtual unsafe void SetLastModified (global::Java.IO.File f, long time)
		{
			const string __id = "setLastModified.(Ljava/io/File;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (time);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		static Delegate cb_setUserHome_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetUserHome_Ljava_io_File_Handler ()
		{
			if (cb_setUserHome_Ljava_io_File_ == null)
				cb_setUserHome_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUserHome_Ljava_io_File_);
			return cb_setUserHome_Ljava_io_File_;
		}

		static IntPtr n_SetUserHome_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUserHome (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">the location of the user's preferences; null if there is no
		///            home directory for the current user.</param>
		/// <summary>Set the user's home directory location.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='setUserHome' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setUserHome", "(Ljava/io/File;)Lorg/eclipse/jgit/util/FS;", "GetSetUserHome_Ljava_io_File_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Util.FS SetUserHome (global::Java.IO.File path)
		{
			const string __id = "setUserHome.(Ljava/io/File;)Lorg/eclipse/jgit/util/FS;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_supportsExecute;
#pragma warning disable 0169
		static Delegate GetSupportsExecuteHandler ()
		{
			if (cb_supportsExecute == null)
				cb_supportsExecute = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_SupportsExecute);
			return cb_supportsExecute;
		}

		static bool n_SupportsExecute (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SupportsExecute ();
		}
#pragma warning restore 0169

		/// <summary>Does this operating system and JRE support the execute flag on files?</summary>
		/// <returns>true if this implementation can provide reasonably accurate
		///         executable bit information; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='supportsExecute' and count(parameter)=0]"
		[Register ("supportsExecute", "()Z", "GetSupportsExecuteHandler")]
		public abstract bool SupportsExecute ();

		static Delegate cb_supportsSymlinks;
#pragma warning disable 0169
		static Delegate GetSupportsSymlinksHandler ()
		{
			if (cb_supportsSymlinks == null)
				cb_supportsSymlinks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_SupportsSymlinks);
			return cb_supportsSymlinks;
		}

		static bool n_SupportsSymlinks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SupportsSymlinks ();
		}
#pragma warning restore 0169

		/// <summary>Does this operating system and JRE supports symbolic links.</summary>
		/// <returns>true if symbolic links may be used</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='supportsSymlinks' and count(parameter)=0]"
		[Register ("supportsSymlinks", "()Z", "GetSupportsSymlinksHandler")]
		public virtual unsafe bool SupportsSymlinks ()
		{
			const string __id = "supportsSymlinks.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_userHome;
#pragma warning disable 0169
		static Delegate GetUserHomeHandler ()
		{
			if (cb_userHome == null)
				cb_userHome = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_UserHome);
			return cb_userHome;
		}

		static IntPtr n_UserHome (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserHome ());
		}
#pragma warning restore 0169

		/// <summary>Determine the user's home directory (location where preferences are).</summary>
		/// <returns>the user's home directory; null if the user does not have one.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='userHome' and count(parameter)=0]"
		[Register ("userHome", "()Ljava/io/File;", "GetUserHomeHandler")]
		public virtual unsafe global::Java.IO.File UserHome ()
		{
			const string __id = "userHome.()Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_userHomeImpl;
#pragma warning disable 0169
		static Delegate GetUserHomeImplHandler ()
		{
			if (cb_userHomeImpl == null)
				cb_userHomeImpl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_UserHomeImpl);
			return cb_userHomeImpl;
		}

		static IntPtr n_UserHomeImpl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserHomeImpl ());
		}
#pragma warning restore 0169

		/// <summary>Determine the user's home directory (location where preferences are).</summary>
		/// <returns>the user's home directory; null if the user does not have one.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='userHomeImpl' and count(parameter)=0]"
		[Register ("userHomeImpl", "()Ljava/io/File;", "GetUserHomeImplHandler")]
		protected virtual unsafe global::Java.IO.File UserHomeImpl ()
		{
			const string __id = "userHomeImpl.()Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/util/FS", DoNotGenerateAcw=true)]
	internal partial class FSInvoker : FS {
		public FSInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/FS", typeof (FSInvoker));

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

		/// <summary>Is this file system case sensitive</summary>
		/// <returns>true if this implementation is case sensitive</returns>
		public override unsafe bool IsCaseSensitive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='isCaseSensitive' and count(parameter)=0]"
			[Register ("isCaseSensitive", "()Z", "GetIsCaseSensitiveHandler")]
			get {
				const string __id = "isCaseSensitive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="f">abstract path to test.</param>
		/// <summary>Determine if the file is executable (or not).</summary>
		/// <returns>true if the file is believed to be executable by the user.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='canExecute' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("canExecute", "(Ljava/io/File;)Z", "GetCanExecute_Ljava_io_File_Handler")]
		public override unsafe bool CanExecute (global::Java.IO.File f)
		{
			const string __id = "canExecute.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		/// <returns>the $prefix directory C Git would use.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='discoverGitPrefix' and count(parameter)=0]"
		[Register ("discoverGitPrefix", "()Ljava/io/File;", "GetDiscoverGitPrefixHandler")]
		protected override unsafe global::Java.IO.File DiscoverGitPrefix ()
		{
			const string __id = "discoverGitPrefix.()Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <returns>a new instance of the same type of FS.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lorg/eclipse/jgit/util/FS;", "GetNewInstanceHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Util.FS NewInstance ()
		{
			const string __id = "newInstance.()Lorg/eclipse/jgit/util/FS;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Does this file system have problems with atomic renames?</summary>
		/// <returns>true if the caller should retry a failed rename of a lock file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='retryFailedLockFileCommit' and count(parameter)=0]"
		[Register ("retryFailedLockFileCommit", "()Z", "GetRetryFailedLockFileCommitHandler")]
		public override unsafe bool RetryFailedLockFileCommit ()
		{
			const string __id = "retryFailedLockFileCommit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <param name="cmd">command to execute. This string should originate from the
		///            end-user, and thus is platform specific.</param>
		/// <param name="args">arguments to pass to command. These should be protected from
		///            shell evaluation.</param>
		/// <summary>Initialize a ProcesssBuilder to run a command using the system shell.</summary>
		/// <returns>a partially completed process builder. Caller should finish
		///         populating directory, environment, and then start the process.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='runInShell' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("runInShell", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/ProcessBuilder;", "GetRunInShell_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override unsafe global::Java.Lang.ProcessBuilder RunInShell (string cmd, string[] args)
		{
			const string __id = "runInShell.(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/ProcessBuilder;";
			IntPtr native_cmd = JNIEnv.NewString ((string)cmd);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_cmd);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.ProcessBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cmd);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

		/// <param name="f">path to modify the executable status of.</param>
		/// <param name="canExec">true to enable execution; false to disable it.</param>
		/// <summary>Set a file to be executable by the user.</summary>
		/// <returns>true if the change succeeded; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='setExecute' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='boolean']]"
		[Register ("setExecute", "(Ljava/io/File;Z)Z", "GetSetExecute_Ljava_io_File_ZHandler")]
		public override unsafe bool SetExecute (global::Java.IO.File f, bool canExec)
		{
			const string __id = "setExecute.(Ljava/io/File;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (canExec);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		/// <summary>Does this operating system and JRE support the execute flag on files?</summary>
		/// <returns>true if this implementation can provide reasonably accurate
		///         executable bit information; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FS']/method[@name='supportsExecute' and count(parameter)=0]"
		[Register ("supportsExecute", "()Z", "GetSupportsExecuteHandler")]
		public override unsafe bool SupportsExecute ()
		{
			const string __id = "supportsExecute.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
