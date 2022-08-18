using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>File Utilities</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {
		/// <summary>Option to only delete empty directories.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/field[@name='EMPTY_DIRECTORIES_ONLY']"
		[Register ("EMPTY_DIRECTORIES_ONLY")]
		public const int EmptyDirectoriesOnly = (int) 16;

		/// <summary>Option not to throw exceptions when a deletion finally doesn't succeed.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/field[@name='IGNORE_ERRORS']"
		[Register ("IGNORE_ERRORS")]
		public const int IgnoreErrors = (int) 8;

		/// <summary>Option to delete given <c>File</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/field[@name='NONE']"
		[Register ("NONE")]
		public const int None = (int) 0;

		/// <summary>Option to recursively delete given <c>File</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/field[@name='RECURSIVE']"
		[Register ("RECURSIVE")]
		public const int Recursive = (int) 1;

		/// <summary>Option to retry deletion if not successful</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/field[@name='RETRY']"
		[Register ("RETRY")]
		public const int Retry = (int) 2;

		/// <summary>Option to skip deletion if file doesn't exist</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/field[@name='SKIP_MISSING']"
		[Register ("SKIP_MISSING")]
		public const int SkipMissing = (int) 4;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/FileUtils", typeof (FileUtils));

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

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/constructor[@name='FileUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="f">the file to be created</param>
		/// <summary>Atomically creates a new, empty file named by this abstract pathname if
		/// and only if a file with this name does not yet exist.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='createNewFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("createNewFile", "(Ljava/io/File;)V", "")]
		public static unsafe void CreateNewFile (global::Java.IO.File f)
		{
			const string __id = "createNewFile.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		/// <param name="path">path</param>
		/// <param name="target">target</param>
		/// <summary>Create a symbolic link</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='createSymLink' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("createSymLink", "(Ljava/io/File;Ljava/lang/String;)V", "")]
		public static unsafe void CreateSymLink (global::Java.IO.File path, string target)
		{
			const string __id = "createSymLink.(Ljava/io/File;Ljava/lang/String;)V";
			IntPtr native_target = JNIEnv.NewString ((string)target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				__args [1] = new JniArgumentValue (native_target);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
				global::System.GC.KeepAlive (path);
			}
		}

		/// <param name="prefix">prefix</param>
		/// <param name="suffix">suffix</param>
		/// <param name="dir">The parent dir, can be null to use system default temp dir.</param>
		/// <summary>Create a temporary directory.</summary>
		/// <returns>the temp dir created.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='createTempDir' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.io.File']]"
		[Register ("createTempDir", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File CreateTempDir (string prefix, string suffix, global::Java.IO.File dir)
		{
			const string __id = "createTempDir.(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;";
			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			IntPtr native_suffix = JNIEnv.NewString ((string)suffix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_prefix);
				__args [1] = new JniArgumentValue (native_suffix);
				__args [2] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
				global::System.GC.KeepAlive (dir);
			}
		}

		/// <param name="f">
		///   <c>File</c> to be deleted</param>
		/// <summary>Delete file or empty folder</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("delete", "(Ljava/io/File;)V", "")]
		public static unsafe void Delete (global::Java.IO.File f)
		{
			const string __id = "delete.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		/// <param name="f">
		///   <c>File</c> to be deleted</param>
		/// <param name="options">deletion options, <c>RECURSIVE</c> for recursive deletion of
		///            a subtree, <c>RETRY</c> to retry when deletion failed.
		///            Retrying may help if the underlying file system doesn't allow
		///            deletion of files being read by another thread.</param>
		/// <summary>Delete file or folder</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='delete' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register ("delete", "(Ljava/io/File;I)V", "")]
		public static unsafe void Delete (global::Java.IO.File f, int options)
		{
			const string __id = "delete.(Ljava/io/File;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (options);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		/// <param name="d">directory to be created</param>
		/// <summary>Creates the directory named by this abstract pathname.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='mkdir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("mkdir", "(Ljava/io/File;)V", "")]
		public static unsafe void Mkdir (global::Java.IO.File d)
		{
			const string __id = "mkdir.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((d == null) ? IntPtr.Zero : ((global::Java.Lang.Object) d).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (d);
			}
		}

		/// <param name="d">directory to be created</param>
		/// <param name="skipExisting">if <c>true</c> skip creation of the given directory if it
		///            already exists in the file system</param>
		/// <summary>Creates the directory named by this abstract pathname.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='mkdir' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='boolean']]"
		[Register ("mkdir", "(Ljava/io/File;Z)V", "")]
		public static unsafe void Mkdir (global::Java.IO.File d, bool skipExisting)
		{
			const string __id = "mkdir.(Ljava/io/File;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((d == null) ? IntPtr.Zero : ((global::Java.Lang.Object) d).Handle);
				__args [1] = new JniArgumentValue (skipExisting);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (d);
			}
		}

		/// <param name="d">directory to be created</param>
		/// <summary>Creates the directory named by this abstract pathname, including any
		/// necessary but nonexistent parent directories.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='mkdirs' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("mkdirs", "(Ljava/io/File;)V", "")]
		public static unsafe void Mkdirs (global::Java.IO.File d)
		{
			const string __id = "mkdirs.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((d == null) ? IntPtr.Zero : ((global::Java.Lang.Object) d).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (d);
			}
		}

		/// <param name="d">directory to be created</param>
		/// <param name="skipExisting">if <c>true</c> skip creation of the given directory if it
		///            already exists in the file system</param>
		/// <summary>Creates the directory named by this abstract pathname, including any
		/// necessary but nonexistent parent directories.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='mkdirs' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='boolean']]"
		[Register ("mkdirs", "(Ljava/io/File;Z)V", "")]
		public static unsafe void Mkdirs (global::Java.IO.File d, bool skipExisting)
		{
			const string __id = "mkdirs.(Ljava/io/File;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((d == null) ? IntPtr.Zero : ((global::Java.Lang.Object) d).Handle);
				__args [1] = new JniArgumentValue (skipExisting);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (d);
			}
		}

		/// <param name="path">path</param>
		/// <returns>the target of the symbolic link, or null if it is not a symbolic
		///         link</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='readSymLink' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readSymLink", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string ReadSymLink (global::Java.IO.File path)
		{
			const string __id = "readSymLink.(Ljava/io/File;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		/// <param name="base">The path against which &lt;code&gt;other&lt;/code&gt; should be
		///            relativized. This will be assumed to denote the path to a
		///            folder and not a file.</param>
		/// <param name="other">The path that will be made relative to &lt;code&gt;base&lt;/code&gt;.</param>
		/// <summary>This will try and make a given path relative to another.</summary>
		/// <returns>A relative path that, when resolved against &lt;code&gt;base&lt;/code&gt;,
		///         will yield the original &lt;code&gt;other&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='relativize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("relativize", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Relativize (string @base, string other)
		{
			const string __id = "relativize.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__base = JNIEnv.NewString ((string)@base);
			IntPtr native_other = JNIEnv.NewString ((string)other);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__base);
				__args [1] = new JniArgumentValue (native_other);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__base);
				JNIEnv.DeleteLocalRef (native_other);
			}
		}

		/// <param name="src">the old <c>File</c></param>
		/// <param name="dst">the new <c>File</c></param>
		/// <summary>Rename a file or folder.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='FileUtils']/method[@name='rename' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File']]"
		[Register ("rename", "(Ljava/io/File;Ljava/io/File;)V", "")]
		public static unsafe void Rename (global::Java.IO.File src, global::Java.IO.File dst)
		{
			const string __id = "rename.(Ljava/io/File;Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (dst);
			}
		}

	}
}
