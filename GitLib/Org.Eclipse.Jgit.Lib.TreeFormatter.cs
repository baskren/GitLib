using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Mutable formatter to construct a single tree object.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/TreeFormatter", DoNotGenerateAcw=true)]
	public partial class TreeFormatter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/TreeFormatter", typeof (TreeFormatter));

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

		protected TreeFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty formatter with a default buffer size.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/constructor[@name='TreeFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TreeFormatter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="size">estimated size of the tree, in bytes. Callers can use
		///            <c>#entrySize(FileMode, int)</c> to estimate the size of each
		///            entry in advance of allocating the formatter.</param>
		/// <summary>Create an empty formatter with the specified buffer size.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/constructor[@name='TreeFormatter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe TreeFormatter (int size) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_append_arrayBIILorg_eclipse_jgit_lib_FileMode_arrayBI;
#pragma warning disable 0169
		static Delegate GetAppend_arrayBIILorg_eclipse_jgit_lib_FileMode_arrayBIHandler ()
		{
			if (cb_append_arrayBIILorg_eclipse_jgit_lib_FileMode_arrayBI == null)
				cb_append_arrayBIILorg_eclipse_jgit_lib_FileMode_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIILLI_V) n_Append_arrayBIILorg_eclipse_jgit_lib_FileMode_arrayBI);
			return cb_append_arrayBIILorg_eclipse_jgit_lib_FileMode_arrayBI;
		}

		static void n_Append_arrayBIILorg_eclipse_jgit_lib_FileMode_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_nameBuf, int namePos, int nameLen, IntPtr native_mode, IntPtr native_idBuf, int idPos)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nameBuf = (byte[]) JNIEnv.GetArray (native_nameBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			var idBuf = (byte[]) JNIEnv.GetArray (native_idBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Append (nameBuf, namePos, nameLen, mode, idBuf, idPos);
			if (nameBuf != null)
				JNIEnv.CopyArray (nameBuf, native_nameBuf);
			if (idBuf != null)
				JNIEnv.CopyArray (idBuf, native_idBuf);
		}
#pragma warning restore 0169

		/// <param name="nameBuf">buffer holding the name of the entry. The name should be UTF-8
		///            encoded, but file name encoding is not a well defined concept
		///            in Git.</param>
		/// <param name="namePos">first position within <c>nameBuf</c> of the name data.</param>
		/// <param name="nameLen">number of bytes from <c>nameBuf</c> to use as the name.</param>
		/// <param name="mode">mode describing the treatment of <c>id</c>.</param>
		/// <param name="idBuf">buffer holding the raw ObjectId of the entry.</param>
		/// <param name="idPos">first position within <c>idBuf</c> to copy the id from.</param>
		/// <summary>Append any entry to the tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='append' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.eclipse.jgit.lib.FileMode'] and parameter[5][@type='byte[]'] and parameter[6][@type='int']]"
		[Register ("append", "([BIILorg/eclipse/jgit/lib/FileMode;[BI)V", "GetAppend_arrayBIILorg_eclipse_jgit_lib_FileMode_arrayBIHandler")]
		public virtual unsafe void Append (byte[] nameBuf, int namePos, int nameLen, global::Org.Eclipse.Jgit.Lib.FileMode mode, byte[] idBuf, int idPos)
		{
			const string __id = "append.([BIILorg/eclipse/jgit/lib/FileMode;[BI)V";
			IntPtr native_nameBuf = JNIEnv.NewArray (nameBuf);
			IntPtr native_idBuf = JNIEnv.NewArray (idBuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_nameBuf);
				__args [1] = new JniArgumentValue (namePos);
				__args [2] = new JniArgumentValue (nameLen);
				__args [3] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [4] = new JniArgumentValue (native_idBuf);
				__args [5] = new JniArgumentValue (idPos);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (nameBuf != null) {
					JNIEnv.CopyArray (native_nameBuf, nameBuf);
					JNIEnv.DeleteLocalRef (native_nameBuf);
				}
				if (idBuf != null) {
					JNIEnv.CopyArray (native_idBuf, idBuf);
					JNIEnv.DeleteLocalRef (native_idBuf);
				}
				global::System.GC.KeepAlive (nameBuf);
				global::System.GC.KeepAlive (mode);
				global::System.GC.KeepAlive (idBuf);
			}
		}

		static Delegate cb_append_arrayBIILorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAppend_arrayBIILorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_append_arrayBIILorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_append_arrayBIILorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIILL_V) n_Append_arrayBIILorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_append_arrayBIILorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Append_arrayBIILorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nameBuf, int namePos, int nameLen, IntPtr native_mode, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nameBuf = (byte[]) JNIEnv.GetArray (native_nameBuf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.Append (nameBuf, namePos, nameLen, mode, id);
			if (nameBuf != null)
				JNIEnv.CopyArray (nameBuf, native_nameBuf);
		}
#pragma warning restore 0169

		/// <param name="nameBuf">buffer holding the name of the entry. The name should be UTF-8
		///            encoded, but file name encoding is not a well defined concept
		///            in Git.</param>
		/// <param name="namePos">first position within <c>nameBuf</c> of the name data.</param>
		/// <param name="nameLen">number of bytes from <c>nameBuf</c> to use as the name.</param>
		/// <param name="mode">mode describing the treatment of <c>id</c>.</param>
		/// <param name="id">the ObjectId to store in this entry.</param>
		/// <summary>Append any entry to the tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='append' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.eclipse.jgit.lib.FileMode'] and parameter[5][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("append", "([BIILorg/eclipse/jgit/lib/FileMode;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetAppend_arrayBIILorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void Append (byte[] nameBuf, int namePos, int nameLen, global::Org.Eclipse.Jgit.Lib.FileMode mode, global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "append.([BIILorg/eclipse/jgit/lib/FileMode;Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			IntPtr native_nameBuf = JNIEnv.NewArray (nameBuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_nameBuf);
				__args [1] = new JniArgumentValue (namePos);
				__args [2] = new JniArgumentValue (nameLen);
				__args [3] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [4] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (nameBuf != null) {
					JNIEnv.CopyArray (native_nameBuf, nameBuf);
					JNIEnv.DeleteLocalRef (native_nameBuf);
				}
				global::System.GC.KeepAlive (nameBuf);
				global::System.GC.KeepAlive (mode);
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_append_arrayBLorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAppend_arrayBLorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_append_arrayBLorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_append_arrayBLorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Append_arrayBLorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_append_arrayBLorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Append_arrayBLorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_mode, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = (byte[]) JNIEnv.GetArray (native_name, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.Append (name, mode, id);
			if (name != null)
				JNIEnv.CopyArray (name, native_name);
		}
#pragma warning restore 0169

		/// <param name="name">name of the entry. The name should be UTF-8 encoded, but file
		///            name encoding is not a well defined concept in Git.</param>
		/// <param name="mode">mode describing the treatment of <c>id</c>.</param>
		/// <param name="id">the ObjectId to store in this entry.</param>
		/// <summary>Append any entry to the tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='append' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='org.eclipse.jgit.lib.FileMode'] and parameter[3][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("append", "([BLorg/eclipse/jgit/lib/FileMode;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetAppend_arrayBLorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void Append (byte[] name, global::Org.Eclipse.Jgit.Lib.FileMode mode, global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "append.([BLorg/eclipse/jgit/lib/FileMode;Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			IntPtr native_name = JNIEnv.NewArray (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [2] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (name != null) {
					JNIEnv.CopyArray (native_name, name);
					JNIEnv.DeleteLocalRef (native_name);
				}
				global::System.GC.KeepAlive (name);
				global::System.GC.KeepAlive (mode);
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_append_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_append_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_append_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Append_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_append_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Append_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_mode, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.Append (name, mode, id);
		}
#pragma warning restore 0169

		/// <param name="name">name of the entry.</param>
		/// <param name="mode">mode describing the treatment of <c>id</c>.</param>
		/// <param name="id">the ObjectId to store in this entry.</param>
		/// <summary>Append any entry to the tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.FileMode'] and parameter[3][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("append", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/FileMode;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetAppend_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void Append (string name, global::Org.Eclipse.Jgit.Lib.FileMode mode, global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "append.(Ljava/lang/String;Lorg/eclipse/jgit/lib/FileMode;Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [2] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (mode);
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevBlob_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevBlob_Handler ()
		{
			if (cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevBlob_ == null)
				cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevBlob_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevBlob_);
			return cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevBlob_;
		}

		static void n_Append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevBlob_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_blob)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var blob = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevBlob> (native_blob, JniHandleOwnership.DoNotTransfer);
			__this.Append (name, blob);
		}
#pragma warning restore 0169

		/// <param name="name">name of the entry.</param>
		/// <param name="blob">the ObjectId to store in this entry.</param>
		/// <summary>Add a regular file, mode is <c>FileMode#REGULAR_FILE</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevBlob']]"
		[Register ("append", "(Ljava/lang/String;Lorg/eclipse/jgit/revwalk/RevBlob;)V", "GetAppend_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevBlob_Handler")]
		public virtual unsafe void Append (string name, global::Org.Eclipse.Jgit.Revwalk.RevBlob blob)
		{
			const string __id = "append.(Ljava/lang/String;Lorg/eclipse/jgit/revwalk/RevBlob;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((blob == null) ? IntPtr.Zero : ((global::Java.Lang.Object) blob).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (blob);
			}
		}

		static Delegate cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static void n_Append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_commit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var commit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_commit, JniHandleOwnership.DoNotTransfer);
			__this.Append (name, commit);
		}
#pragma warning restore 0169

		/// <param name="name">name of the entry.</param>
		/// <param name="commit">the ObjectId to store in this entry.</param>
		/// <summary>Add a link to a submodule commit, mode is <c>FileMode#GITLINK</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("append", "(Ljava/lang/String;Lorg/eclipse/jgit/revwalk/RevCommit;)V", "GetAppend_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe void Append (string name, global::Org.Eclipse.Jgit.Revwalk.RevCommit commit)
		{
			const string __id = "append.(Ljava/lang/String;Lorg/eclipse/jgit/revwalk/RevCommit;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (commit);
			}
		}

		static Delegate cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevTree_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevTree_Handler ()
		{
			if (cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevTree_ == null)
				cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevTree_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevTree_);
			return cb_append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevTree_;
		}

		static void n_Append_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevTree_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_tree)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var tree = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (native_tree, JniHandleOwnership.DoNotTransfer);
			__this.Append (name, tree);
		}
#pragma warning restore 0169

		/// <param name="name">name of the entry.</param>
		/// <param name="tree">the ObjectId to store in this entry.</param>
		/// <summary>Add a subtree, mode is <c>FileMode#TREE</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevTree']]"
		[Register ("append", "(Ljava/lang/String;Lorg/eclipse/jgit/revwalk/RevTree;)V", "GetAppend_Ljava_lang_String_Lorg_eclipse_jgit_revwalk_RevTree_Handler")]
		public virtual unsafe void Append (string name, global::Org.Eclipse.Jgit.Revwalk.RevTree tree)
		{
			const string __id = "append.(Ljava/lang/String;Lorg/eclipse/jgit/revwalk/RevTree;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((tree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tree).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (tree);
			}
		}

		static Delegate cb_computeId_Lorg_eclipse_jgit_lib_ObjectInserter_;
#pragma warning disable 0169
		static Delegate GetComputeId_Lorg_eclipse_jgit_lib_ObjectInserter_Handler ()
		{
			if (cb_computeId_Lorg_eclipse_jgit_lib_ObjectInserter_ == null)
				cb_computeId_Lorg_eclipse_jgit_lib_ObjectInserter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ComputeId_Lorg_eclipse_jgit_lib_ObjectInserter_);
			return cb_computeId_Lorg_eclipse_jgit_lib_ObjectInserter_;
		}

		static IntPtr n_ComputeId_Lorg_eclipse_jgit_lib_ObjectInserter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ins)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ins = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (native_ins, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ComputeId (ins));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ins">ins</param>
		/// <summary>Compute the ObjectId for this tree</summary>
		/// <returns>ObjectId for this tree</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='computeId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectInserter']]"
		[Register ("computeId", "(Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/lib/ObjectId;", "GetComputeId_Lorg_eclipse_jgit_lib_ObjectInserter_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ComputeId (global::Org.Eclipse.Jgit.Lib.ObjectInserter ins)
		{
			const string __id = "computeId.(Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ins == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ins).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ins);
			}
		}

		/// <param name="mode">the mode the entry will have.</param>
		/// <param name="nameLen">the length of the name, in bytes.</param>
		/// <summary>Compute the size of a tree entry record.</summary>
		/// <returns>the length of the record.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='entrySize' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.FileMode'] and parameter[2][@type='int']]"
		[Register ("entrySize", "(Lorg/eclipse/jgit/lib/FileMode;I)I", "")]
		public static unsafe int EntrySize (global::Org.Eclipse.Jgit.Lib.FileMode mode, int nameLen)
		{
			const string __id = "entrySize.(Lorg/eclipse/jgit/lib/FileMode;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [1] = new JniArgumentValue (nameLen);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (mode);
			}
		}

		static Delegate cb_insertTo_Lorg_eclipse_jgit_lib_ObjectInserter_;
#pragma warning disable 0169
		static Delegate GetInsertTo_Lorg_eclipse_jgit_lib_ObjectInserter_Handler ()
		{
			if (cb_insertTo_Lorg_eclipse_jgit_lib_ObjectInserter_ == null)
				cb_insertTo_Lorg_eclipse_jgit_lib_ObjectInserter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_InsertTo_Lorg_eclipse_jgit_lib_ObjectInserter_);
			return cb_insertTo_Lorg_eclipse_jgit_lib_ObjectInserter_;
		}

		static IntPtr n_InsertTo_Lorg_eclipse_jgit_lib_ObjectInserter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ins)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ins = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (native_ins, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InsertTo (ins));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ins">the inserter to store the tree.</param>
		/// <summary>Insert this tree and obtain its ObjectId.</summary>
		/// <returns>computed ObjectId of the tree</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='insertTo' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectInserter']]"
		[Register ("insertTo", "(Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/lib/ObjectId;", "GetInsertTo_Lorg_eclipse_jgit_lib_ObjectInserter_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId InsertTo (global::Org.Eclipse.Jgit.Lib.ObjectInserter ins)
		{
			const string __id = "insertTo.(Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ins == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ins).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ins);
			}
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		/// <summary>Copy this formatter's buffer into a byte array.</summary>
		/// <returns>a copy of this formatter's buffer.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeFormatter']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[] ToByteArray ()
		{
			const string __id = "toByteArray.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
