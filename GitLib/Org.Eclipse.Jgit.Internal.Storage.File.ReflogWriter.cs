using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Utility for writing reflog entries</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/ReflogWriter", DoNotGenerateAcw=true)]
	public partial class ReflogWriter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/ReflogWriter", typeof (ReflogWriter));

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

		protected ReflogWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repository">repository</param>
		/// <summary>Create write for repository</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']/constructor[@name='ReflogWriter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe ReflogWriter (global::Org.Eclipse.Jgit.Lib.Repository repository) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repository);
			}
		}

		/// <param name="repository">repository</param>
		/// <param name="forceWrite">true to write to disk all entries logged, false to respect the
		///            repository's config and current log file status</param>
		/// <summary>Create write for repository</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']/constructor[@name='ReflogWriter' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Z)V", "")]
		public unsafe ReflogWriter (global::Org.Eclipse.Jgit.Lib.Repository repository, bool forceWrite) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue (forceWrite);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repository);
			}
		}

		static Delegate cb_getRepository;
#pragma warning disable 0169
		static Delegate GetGetRepositoryHandler ()
		{
			if (cb_getRepository == null)
				cb_getRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepository);
			return cb_getRepository;
		}

		static IntPtr n_GetRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		/// <summary>Get repository that reflog is being written for</summary>
		/// <returns>file repository</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "GetGetRepositoryHandler")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/lib/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Create);
			return cb_create;
		}

		static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Create ());
		}
#pragma warning restore 0169

		/// <summary>Create the log directories</summary>
		/// <returns>this writer</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/eclipse/jgit/internal/storage/file/ReflogWriter;", "GetCreateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter Create ()
		{
			const string __id = "create.()Lorg/eclipse/jgit/internal/storage/file/ReflogWriter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_PersonIdent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_PersonIdent_Ljava_lang_String_Handler ()
		{
			if (cb_log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_PersonIdent_Ljava_lang_String_ == null)
				cb_log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_PersonIdent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_L) n_Log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_PersonIdent_Ljava_lang_String_);
			return cb_log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_PersonIdent_Ljava_lang_String_;
		}

		static IntPtr n_Log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_PersonIdent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refName, IntPtr native_oldId, IntPtr native_newId, IntPtr native_ident, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			var oldId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_oldId, JniHandleOwnership.DoNotTransfer);
			var newId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_newId, JniHandleOwnership.DoNotTransfer);
			var ident = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_ident, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Log (refName, oldId, newId, ident, message));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="refName">refName</param>
		/// <param name="oldId">oldId</param>
		/// <param name="newId">newId</param>
		/// <param name="ident">ident</param>
		/// <param name="message">message</param>
		/// <summary>Write the given entry information to the ref's log</summary>
		/// <returns>this writer</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']/method[@name='log' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[4][@type='org.eclipse.jgit.lib.PersonIdent'] and parameter[5][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/PersonIdent;Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/file/ReflogWriter;", "GetLog_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_ObjectId_Lorg_eclipse_jgit_lib_PersonIdent_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter Log (string refName, global::Org.Eclipse.Jgit.Lib.ObjectId oldId, global::Org.Eclipse.Jgit.Lib.ObjectId newId, global::Org.Eclipse.Jgit.Lib.PersonIdent ident, string message)
		{
			const string __id = "log.(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/PersonIdent;Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/file/ReflogWriter;";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_refName);
				__args [1] = new JniArgumentValue ((oldId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldId).Handle);
				__args [2] = new JniArgumentValue ((newId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newId).Handle);
				__args [3] = new JniArgumentValue ((ident == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ident).Handle);
				__args [4] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (oldId);
				global::System.GC.KeepAlive (newId);
				global::System.GC.KeepAlive (ident);
			}
		}

		static Delegate cb_log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ReflogEntry_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_lang_String_Lorg_eclipse_jgit_lib_ReflogEntry_Handler ()
		{
			if (cb_log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ReflogEntry_ == null)
				cb_log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ReflogEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ReflogEntry_);
			return cb_log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ReflogEntry_;
		}

		static IntPtr n_Log_Ljava_lang_String_Lorg_eclipse_jgit_lib_ReflogEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refName, IntPtr native_entry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			var entry = (global::Org.Eclipse.Jgit.Lib.IReflogEntry)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogEntry> (native_entry, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Log (refName, entry));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="refName">refName</param>
		/// <param name="entry">entry</param>
		/// <summary>Write the given <c>ReflogEntry</c> entry to the ref's log</summary>
		/// <returns>this writer</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.ReflogEntry']]"
		[Register ("log", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/ReflogEntry;)Lorg/eclipse/jgit/internal/storage/file/ReflogWriter;", "GetLog_Ljava_lang_String_Lorg_eclipse_jgit_lib_ReflogEntry_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter Log (string refName, global::Org.Eclipse.Jgit.Lib.IReflogEntry entry)
		{
			const string __id = "log.(Ljava/lang/String;Lorg/eclipse/jgit/lib/ReflogEntry;)Lorg/eclipse/jgit/internal/storage/file/ReflogWriter;";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_refName);
				__args [1] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
				global::System.GC.KeepAlive (entry);
			}
		}

		static Delegate cb_log_Lorg_eclipse_jgit_lib_RefUpdate_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetLog_Lorg_eclipse_jgit_lib_RefUpdate_Ljava_lang_String_ZHandler ()
		{
			if (cb_log_Lorg_eclipse_jgit_lib_RefUpdate_Ljava_lang_String_Z == null)
				cb_log_Lorg_eclipse_jgit_lib_RefUpdate_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_Log_Lorg_eclipse_jgit_lib_RefUpdate_Ljava_lang_String_Z);
			return cb_log_Lorg_eclipse_jgit_lib_RefUpdate_Ljava_lang_String_Z;
		}

		static IntPtr n_Log_Lorg_eclipse_jgit_lib_RefUpdate_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_update, IntPtr native_msg, bool deref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var update = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (native_update, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Log (update, msg, deref));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="update">update</param>
		/// <param name="msg">msg</param>
		/// <param name="deref">deref</param>
		/// <summary>Write the given ref update to the ref's log</summary>
		/// <returns>this writer</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']/method[@name='log' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.RefUpdate'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("log", "(Lorg/eclipse/jgit/lib/RefUpdate;Ljava/lang/String;Z)Lorg/eclipse/jgit/internal/storage/file/ReflogWriter;", "GetLog_Lorg_eclipse_jgit_lib_RefUpdate_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter Log (global::Org.Eclipse.Jgit.Lib.RefUpdate update, string msg, bool deref)
		{
			const string __id = "log.(Lorg/eclipse/jgit/lib/RefUpdate;Ljava/lang/String;Z)Lorg/eclipse/jgit/internal/storage/file/ReflogWriter;";
			IntPtr native_msg = JNIEnv.NewString ((string)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((update == null) ? IntPtr.Zero : ((global::Java.Lang.Object) update).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue (deref);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (update);
			}
		}

		static Delegate cb_logFor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogFor_Ljava_lang_String_Handler ()
		{
			if (cb_logFor_Ljava_lang_String_ == null)
				cb_logFor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LogFor_Ljava_lang_String_);
			return cb_logFor_Ljava_lang_String_;
		}

		static IntPtr n_LogFor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LogFor (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">name of the ref, relative to the Git repository top level
		///            directory (so typically starts with refs/).</param>
		/// <summary>Locate the log file on disk for a single reference name.</summary>
		/// <returns>the log file location.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']/method[@name='logFor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logFor", "(Ljava/lang/String;)Ljava/io/File;", "GetLogFor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.IO.File LogFor (string name)
		{
			const string __id = "logFor.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		/// <param name="name">name of the ref, relative to the Git repository top level
		///            directory (so typically starts with refs/).</param>
		/// <summary>Get the ref name to be used for when locking a ref's log for rewriting</summary>
		/// <returns>the name of the ref's lock ref</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogWriter']/method[@name='refLockFor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("refLockFor", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RefLockFor (string name)
		{
			const string __id = "refLockFor.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
