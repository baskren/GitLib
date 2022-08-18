using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Git style file locking and replacement.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/LockFile", DoNotGenerateAcw=true)]
	public partial class LockFile : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/LockFile", typeof (LockFile));

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

		protected LockFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="f">the file that will be locked.</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <summary>Create a new lock for any file.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/constructor[@name='LockFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register (".ctor", "(Ljava/io/File;Lorg/eclipse/jgit/util/FS;)V", "")]
		public unsafe LockFile (global::Java.IO.File f, global::Org.Eclipse.Jgit.Util.FS fs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCommitLastModified;
#pragma warning disable 0169
		static Delegate GetGetCommitLastModifiedHandler ()
		{
			if (cb_getCommitLastModified == null)
				cb_getCommitLastModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCommitLastModified);
			return cb_getCommitLastModified;
		}

		static long n_GetCommitLastModified (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommitLastModified;
		}
#pragma warning restore 0169

		/// <summary>Get the modification time of the output file when it was committed.</summary>
		/// <returns>modification time of the lock file right before we committed it.</returns>
		public virtual unsafe long CommitLastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='getCommitLastModified' and count(parameter)=0]"
			[Register ("getCommitLastModified", "()J", "GetGetCommitLastModifiedHandler")]
			get {
				const string __id = "getCommitLastModified.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCommitSnapshot;
#pragma warning disable 0169
		static Delegate GetGetCommitSnapshotHandler ()
		{
			if (cb_getCommitSnapshot == null)
				cb_getCommitSnapshot = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommitSnapshot);
			return cb_getCommitSnapshot;
		}

		static IntPtr n_GetCommitSnapshot (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CommitSnapshot);
		}
#pragma warning restore 0169

		/// <returns>get the <c>FileSnapshot</c> just before commit.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot CommitSnapshot {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='getCommitSnapshot' and count(parameter)=0]"
			[Register ("getCommitSnapshot", "()Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;", "GetGetCommitSnapshotHandler")]
			get {
				const string __id = "getCommitSnapshot.()Lorg/eclipse/jgit/internal/storage/file/FileSnapshot;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.FileSnapshot> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		/// <summary>Obtain the direct output stream for this lock.</summary>
		/// <returns>a stream to write to the new file. The stream is unbuffered.</returns>
		public virtual unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				const string __id = "getOutputStream.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_commit;
#pragma warning disable 0169
		static Delegate GetCommitHandler ()
		{
			if (cb_commit == null)
				cb_commit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Commit);
			return cb_commit;
		}

		static bool n_Commit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Commit ();
		}
#pragma warning restore 0169

		/// <summary>Commit this change and release the lock.</summary>
		/// <returns>true if the commit was successful and the file contains the new
		///         data; false if the commit failed and the file remains with the
		///         old data.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='commit' and count(parameter)=0]"
		[Register ("commit", "()Z", "GetCommitHandler")]
		public virtual unsafe bool Commit ()
		{
			const string __id = "commit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_copyCurrentContent;
#pragma warning disable 0169
		static Delegate GetCopyCurrentContentHandler ()
		{
			if (cb_copyCurrentContent == null)
				cb_copyCurrentContent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CopyCurrentContent);
			return cb_copyCurrentContent;
		}

		static void n_CopyCurrentContent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CopyCurrentContent ();
		}
#pragma warning restore 0169

		/// <summary>Copy the current file content into the temporary file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='copyCurrentContent' and count(parameter)=0]"
		[Register ("copyCurrentContent", "()V", "GetCopyCurrentContentHandler")]
		public virtual unsafe void CopyCurrentContent ()
		{
			const string __id = "copyCurrentContent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_createCommitSnapshot;
#pragma warning disable 0169
		static Delegate GetCreateCommitSnapshotHandler ()
		{
			if (cb_createCommitSnapshot == null)
				cb_createCommitSnapshot = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CreateCommitSnapshot);
			return cb_createCommitSnapshot;
		}

		static void n_CreateCommitSnapshot (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateCommitSnapshot ();
		}
#pragma warning restore 0169

		/// <summary>Update the commit snapshot <c>#getCommitSnapshot()</c> before commit.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='createCommitSnapshot' and count(parameter)=0]"
		[Register ("createCommitSnapshot", "()V", "GetCreateCommitSnapshotHandler")]
		public virtual unsafe void CreateCommitSnapshot ()
		{
			const string __id = "createCommitSnapshot.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_lock;
#pragma warning disable 0169
		static Delegate GetLockHandler ()
		{
			if (cb_lock == null)
				cb_lock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Lock);
			return cb_lock;
		}

		static bool n_Lock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Lock ();
		}
#pragma warning restore 0169

		/// <summary>Try to establish the lock.</summary>
		/// <returns>true if the lock is now held by the caller; false if it is held
		///         by someone else.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='lock' and count(parameter)=0]"
		[Register ("lock", "()Z", "GetLockHandler")]
		public virtual unsafe bool Lock ()
		{
			const string __id = "lock.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_lockForAppend;
#pragma warning disable 0169
		static Delegate GetLockForAppendHandler ()
		{
			if (cb_lockForAppend == null)
				cb_lockForAppend = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_LockForAppend);
			return cb_lockForAppend;
		}

		static bool n_LockForAppend (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LockForAppend ();
		}
#pragma warning restore 0169

		/// <summary>Try to establish the lock for appending.</summary>
		/// <returns>true if the lock is now held by the caller; false if it is held
		///         by someone else.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='lockForAppend' and count(parameter)=0]"
		[Register ("lockForAppend", "()Z", "GetLockForAppendHandler")]
		public virtual unsafe bool LockForAppend ()
		{
			const string __id = "lockForAppend.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setFSync_Z;
#pragma warning disable 0169
		static Delegate GetSetFSync_ZHandler ()
		{
			if (cb_setFSync_Z == null)
				cb_setFSync_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFSync_Z);
			return cb_setFSync_Z;
		}

		static void n_SetFSync_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFSync (on);
		}
#pragma warning restore 0169

		/// <param name="on">true if dirty data should be forced to the drive.</param>
		/// <summary>Request that <c>#commit()</c> force dirty data to the drive.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='setFSync' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFSync", "(Z)V", "GetSetFSync_ZHandler")]
		public virtual unsafe void SetFSync (bool on)
		{
			const string __id = "setFSync.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNeedSnapshot_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedSnapshot_ZHandler ()
		{
			if (cb_setNeedSnapshot_Z == null)
				cb_setNeedSnapshot_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetNeedSnapshot_Z);
			return cb_setNeedSnapshot_Z;
		}

		static void n_SetNeedSnapshot_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNeedSnapshot (on);
		}
#pragma warning restore 0169

		/// <param name="on">true if the commit method must remember the FileSnapshot.</param>
		/// <summary>Request that <c>#commit()</c> remember the <c>FileSnapshot</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='setNeedSnapshot' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedSnapshot", "(Z)V", "GetSetNeedSnapshot_ZHandler")]
		public virtual unsafe void SetNeedSnapshot (bool on)
		{
			const string __id = "setNeedSnapshot.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNeedStatInformation_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedStatInformation_ZHandler ()
		{
			if (cb_setNeedStatInformation_Z == null)
				cb_setNeedStatInformation_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetNeedStatInformation_Z);
			return cb_setNeedStatInformation_Z;
		}

		static void n_SetNeedStatInformation_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNeedStatInformation (on);
		}
#pragma warning restore 0169

		/// <param name="on">true if the commit method must remember the modification time.</param>
		/// <summary>Request that <c>#commit()</c> remember modification time.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='setNeedStatInformation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedStatInformation", "(Z)V", "GetSetNeedStatInformation_ZHandler")]
		public virtual unsafe void SetNeedStatInformation (bool on)
		{
			const string __id = "setNeedStatInformation.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unlock;
#pragma warning disable 0169
		static Delegate GetUnlockHandler ()
		{
			if (cb_unlock == null)
				cb_unlock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unlock);
			return cb_unlock;
		}

		static void n_Unlock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		/// <summary>Unlock this file and abort this change.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler")]
		public virtual unsafe void Unlock ()
		{
			const string __id = "unlock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <param name="file">file</param>
		/// <summary>Unlock the given file.</summary>
		/// <returns>true if unlocked, false if unlocking failed</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='unlock' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("unlock", "(Ljava/io/File;)Z", "")]
		public static unsafe bool Unlock (global::Java.IO.File file)
		{
			const string __id = "unlock.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (file);
			}
		}

		static Delegate cb_waitForStatChange;
#pragma warning disable 0169
		static Delegate GetWaitForStatChangeHandler ()
		{
			if (cb_waitForStatChange == null)
				cb_waitForStatChange = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WaitForStatChange);
			return cb_waitForStatChange;
		}

		static void n_WaitForStatChange (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForStatChange ();
		}
#pragma warning restore 0169

		/// <summary>Wait until the lock file information differs from the old file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='waitForStatChange' and count(parameter)=0]"
		[Register ("waitForStatChange", "()V", "GetWaitForStatChangeHandler")]
		public virtual unsafe void WaitForStatChange ()
		{
			const string __id = "waitForStatChange.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Write_arrayB);
			return cb_write_arrayB;
		}

		static void n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_content)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var content = (byte[]) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (content);
			if (content != null)
				JNIEnv.CopyArray (content, native_content);
		}
#pragma warning restore 0169

		/// <param name="content">the bytes to store in the temporary file. No additional bytes
		///            are added, so if the file must end with an LF it must appear
		///            at the end of the byte array.</param>
		/// <summary>Write arbitrary data to the temporary file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)V", "GetWrite_arrayBHandler")]
		public virtual unsafe void Write (byte[] content)
		{
			const string __id = "write.([B)V";
			IntPtr native_content = JNIEnv.NewArray (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_content);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
				global::System.GC.KeepAlive (content);
			}
		}

		static Delegate cb_write_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetWrite_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_write_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_write_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Write_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_write_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static void n_Write_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.LockFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.Write (id);
		}
#pragma warning restore 0169

		/// <param name="id">the id to store in the file. The id will be written in hex,
		///            followed by a sole LF.</param>
		/// <summary>Write an ObjectId and LF to the temporary file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='LockFile']/method[@name='write' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("write", "(Lorg/eclipse/jgit/lib/ObjectId;)V", "GetWrite_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public virtual unsafe void Write (global::Org.Eclipse.Jgit.Lib.ObjectId id)
		{
			const string __id = "write.(Lorg/eclipse/jgit/lib/ObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

	}
}
