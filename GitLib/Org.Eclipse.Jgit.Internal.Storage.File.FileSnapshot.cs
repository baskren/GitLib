using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Caches when a file was last read, making it possible to detect future edits.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileSnapshot']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/FileSnapshot", DoNotGenerateAcw=true)]
	public partial class FileSnapshot : global::Java.Lang.Object {

		/// <summary>A FileSnapshot that is considered to always be modified.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileSnapshot']/field[@name='DIRTY']"
		[Register ("DIRTY")]
		public static global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot Dirty {
			get {
				const string __id = "DIRTY.Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>A FileSnapshot that is clean if the file does not exist.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileSnapshot']/field[@name='MISSING_FILE']"
		[Register ("MISSING_FILE")]
		public static global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot MissingFile {
			get {
				const string __id = "MISSING_FILE.Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/FileSnapshot", typeof (FileSnapshot));

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

		protected FileSnapshot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_equals_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_;
#pragma warning disable 0169
		static Delegate GetEquals_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_Handler ()
		{
			if (cb_equals_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_ == null)
				cb_equals_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_);
			return cb_equals_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_;
		}

		static bool n_Equals_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (other);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="other">the other snapshot.</param>
		/// <summary>Compare two snapshots to see if they cache the same information.</summary>
		/// <returns>true if the two snapshots share the same information.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileSnapshot']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.file.FileSnapshot']]"
		[Register ("equals", "(Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;)Z", "GetEquals_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_Handler")]
		public virtual unsafe bool Equals (global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot other)
		{
			const string __id = "equals.(Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		static Delegate cb_isModified_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetIsModified_Ljava_io_File_Handler ()
		{
			if (cb_isModified_Ljava_io_File_ == null)
				cb_isModified_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsModified_Ljava_io_File_);
			return cb_isModified_Ljava_io_File_;
		}

		static bool n_IsModified_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsModified (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">the path the snapshot describes.</param>
		/// <summary>Check if the path may have been modified since the snapshot was saved.</summary>
		/// <returns>true if the path needs to be read again.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileSnapshot']/method[@name='isModified' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("isModified", "(Ljava/io/File;)Z", "GetIsModified_Ljava_io_File_Handler")]
		public virtual unsafe bool IsModified (global::Java.IO.File path)
		{
			const string __id = "isModified.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		static Delegate cb_lastModified;
#pragma warning disable 0169
		static Delegate GetLastModifiedHandler ()
		{
			if (cb_lastModified == null)
				cb_lastModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_LastModified);
			return cb_lastModified;
		}

		static long n_LastModified (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastModified ();
		}
#pragma warning restore 0169

		/// <returns>time of last snapshot update</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileSnapshot']/method[@name='lastModified' and count(parameter)=0]"
		[Register ("lastModified", "()J", "GetLastModifiedHandler")]
		public virtual unsafe long LastModified ()
		{
			const string __id = "lastModified.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <param name="path">the path to later remember. The path's current status
		///            information is saved.</param>
		/// <summary>Record a snapshot for a specific file path.</summary>
		/// <returns>the snapshot.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileSnapshot']/method[@name='save' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("save", "(Ljava/io/File;)Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot Save (global::Java.IO.File path)
		{
			const string __id = "save.(Ljava/io/File;)Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (path);
			}
		}

		/// <param name="modified">the last modification time of the file</param>
		/// <summary>Record a snapshot for a file for which the last modification time is
		/// already known.</summary>
		/// <returns>the snapshot.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileSnapshot']/method[@name='save' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("save", "(J)Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot Save (long modified)
		{
			const string __id = "save.(J)Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (modified);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setClean_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_;
#pragma warning disable 0169
		static Delegate GetSetClean_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_Handler ()
		{
			if (cb_setClean_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_ == null)
				cb_setClean_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClean_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_);
			return cb_setClean_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_;
		}

		static void n_SetClean_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (native_other, JniHandleOwnership.DoNotTransfer);
			__this.SetClean (other);
		}
#pragma warning restore 0169

		/// <param name="other">the other snapshot.</param>
		/// <summary>Update this snapshot when the content hasn't changed.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='FileSnapshot']/method[@name='setClean' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.file.FileSnapshot']]"
		[Register ("setClean", "(Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;)V", "GetSetClean_Lorg_eclipse_jgit_internal_storage_file_FileSnapshot_Handler")]
		public virtual unsafe void SetClean (global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot other)
		{
			const string __id = "setClean.(Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

	}
}
