using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Mutable builder to construct a commit recording the state of a project.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/CommitBuilder", DoNotGenerateAcw=true)]
	public partial class CommitBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/CommitBuilder", typeof (CommitBuilder));

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

		protected CommitBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Initialize an empty commit.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/constructor[@name='CommitBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommitBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAuthor;
#pragma warning disable 0169
		static Delegate GetGetAuthorHandler ()
		{
			if (cb_getAuthor == null)
				cb_getAuthor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthor);
			return cb_getAuthor;
		}

		static IntPtr n_GetAuthor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Author);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static void n_SetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newAuthor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newAuthor = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_newAuthor, JniHandleOwnership.DoNotTransfer);
			__this.Author = newAuthor;
		}
#pragma warning restore 0169

		/// <returns>the author of this commit (who wrote it).</returns>
		/// <summary>Set the author (name, email address, and date) of who wrote the commit.</summary>
		/// <param name="newAuthor">the new author. Should not be null.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent Author {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='getAuthor' and count(parameter)=0]"
			[Register ("getAuthor", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetAuthorHandler")]
			get {
				const string __id = "getAuthor.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setAuthor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
			[Register ("setAuthor", "(Lorg/eclipse/jgit/lib/PersonIdent;)V", "GetSetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
			set {
				const string __id = "setAuthor.(Lorg/eclipse/jgit/lib/PersonIdent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getCommitter;
#pragma warning disable 0169
		static Delegate GetGetCommitterHandler ()
		{
			if (cb_getCommitter == null)
				cb_getCommitter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommitter);
			return cb_getCommitter;
		}

		static IntPtr n_GetCommitter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Committer);
		}
#pragma warning restore 0169

		static Delegate cb_setCommitter_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetCommitter_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setCommitter_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setCommitter_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCommitter_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setCommitter_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static void n_SetCommitter_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newCommitter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newCommitter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_newCommitter, JniHandleOwnership.DoNotTransfer);
			__this.Committer = newCommitter;
		}
#pragma warning restore 0169

		/// <returns>the committer and commit time for this object.</returns>
		/// <summary>Set the committer and commit time for this object</summary>
		/// <param name="newCommitter">the committer information. Should not be null.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent Committer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='getCommitter' and count(parameter)=0]"
			[Register ("getCommitter", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetCommitterHandler")]
			get {
				const string __id = "getCommitter.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setCommitter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
			[Register ("setCommitter", "(Lorg/eclipse/jgit/lib/PersonIdent;)V", "GetSetCommitter_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
			set {
				const string __id = "setCommitter.(Lorg/eclipse/jgit/lib/PersonIdent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getEncoding;
#pragma warning disable 0169
		static Delegate GetGetEncodingHandler ()
		{
			if (cb_getEncoding == null)
				cb_getEncoding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEncoding);
			return cb_getEncoding;
		}

		static IntPtr n_GetEncoding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Encoding);
		}
#pragma warning restore 0169

		static Delegate cb_setEncoding_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetSetEncoding_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_setEncoding_Ljava_nio_charset_Charset_ == null)
				cb_setEncoding_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEncoding_Ljava_nio_charset_Charset_);
			return cb_setEncoding_Ljava_nio_charset_Charset_;
		}

		static void n_SetEncoding_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_enc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var enc = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_enc, JniHandleOwnership.DoNotTransfer);
			__this.Encoding = enc;
		}
#pragma warning restore 0169

		/// <returns>the encoding that should be used for the commit message text.</returns>
		/// <summary>Set the encoding for the commit information</summary>
		/// <param name="enc">the encoding to use.</param>
		public virtual unsafe global::Java.Nio.Charset.Charset Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/nio/charset/Charset;", "GetGetEncodingHandler")]
			get {
				const string __id = "getEncoding.()Ljava/nio/charset/Charset;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setEncoding' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
			[Register ("setEncoding", "(Ljava/nio/charset/Charset;)V", "GetSetEncoding_Ljava_nio_charset_Charset_Handler")]
			set {
				const string __id = "setEncoding.(Ljava/nio/charset/Charset;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newMessage = JNIEnv.GetString (native_newMessage, JniHandleOwnership.DoNotTransfer);
			__this.Message = newMessage;
		}
#pragma warning restore 0169

		/// <returns>the complete commit message.</returns>
		/// <summary>Set the commit message.</summary>
		/// <param name="newMessage">the commit message. Should not be null.</param>
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMessage.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTreeId;
#pragma warning disable 0169
		static Delegate GetGetTreeIdHandler ()
		{
			if (cb_getTreeId == null)
				cb_getTreeId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTreeId);
			return cb_getTreeId;
		}

		static IntPtr n_GetTreeId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TreeId);
		}
#pragma warning restore 0169

		/// <returns>id of the root tree listing this commit's snapshot.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId TreeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='getTreeId' and count(parameter)=0]"
			[Register ("getTreeId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetTreeIdHandler")]
			get {
				const string __id = "getTreeId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addParentId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAddParentId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_addParentId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_addParentId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddParentId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_addParentId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_AddParentId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_additionalParent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var additionalParent = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_additionalParent, JniHandleOwnership.DoNotTransfer);
			__this.AddParentId (additionalParent);
		}
#pragma warning restore 0169

		/// <param name="additionalParent">new parent to add onto the end of the current parent list.</param>
		/// <summary>Add a parent onto the end of the parent list.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='addParentId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("addParentId", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetAddParentId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void AddParentId (global::Org.Eclipse.Jgit.Lib.AnyObjectId additionalParent)
		{
			const string __id = "addParentId.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((additionalParent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) additionalParent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (additionalParent);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Build ());
		}
#pragma warning restore 0169

		/// <summary>Format this builder's state as a commit object.</summary>
		/// <returns>this object in the canonical commit format, suitable for storage
		///         in a repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()[B", "GetBuildHandler")]
		public virtual unsafe byte[] Build ()
		{
			const string __id = "build.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getParentIds;
#pragma warning disable 0169
		static Delegate GetGetParentIdsHandler ()
		{
			if (cb_getParentIds == null)
				cb_getParentIds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParentIds);
			return cb_getParentIds;
		}

		static IntPtr n_GetParentIds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParentIds ());
		}
#pragma warning restore 0169

		/// <returns>the ancestors of this commit. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='getParentIds' and count(parameter)=0]"
		[Register ("getParentIds", "()[Lorg/eclipse/jgit/lib/ObjectId;", "GetGetParentIdsHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId[] GetParentIds ()
		{
			const string __id = "getParentIds.()[Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Jgit.Lib.ObjectId[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.ObjectId));
			} finally {
			}
		}

		static Delegate cb_setEncoding_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncoding_Ljava_lang_String_Handler ()
		{
			if (cb_setEncoding_Ljava_lang_String_ == null)
				cb_setEncoding_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEncoding_Ljava_lang_String_);
			return cb_setEncoding_Ljava_lang_String_;
		}

		static void n_SetEncoding_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encodingName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var encodingName = JNIEnv.GetString (native_encodingName, JniHandleOwnership.DoNotTransfer);
			__this.SetEncoding (encodingName);
		}
#pragma warning restore 0169

		/// <param name="encodingName">the encoding name. See <c>Charset#forName(String)</c>.</param>
		/// <summary>Set the encoding for the commit information</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEncoding", "(Ljava/lang/String;)V", "GetSetEncoding_Ljava_lang_String_Handler")]
		public virtual unsafe void SetEncoding (string encodingName)
		{
			const string __id = "setEncoding.(Ljava/lang/String;)V";
			IntPtr native_encodingName = JNIEnv.NewString ((string)encodingName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_encodingName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_encodingName);
			}
		}

		static Delegate cb_setParentId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetParentId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setParentId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setParentId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetParentId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setParentId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_SetParentId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newParent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newParent = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_newParent, JniHandleOwnership.DoNotTransfer);
			__this.SetParentId (newParent);
		}
#pragma warning restore 0169

		/// <param name="newParent">the single parent for the commit.</param>
		/// <summary>Set the parent of this commit.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setParentId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setParentId", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetSetParentId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void SetParentId (global::Org.Eclipse.Jgit.Lib.AnyObjectId newParent)
		{
			const string __id = "setParentId.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newParent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newParent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (newParent);
			}
		}

		static Delegate cb_setParentIds_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetParentIds_Ljava_util_List_Handler ()
		{
			if (cb_setParentIds_Ljava_util_List_ == null)
				cb_setParentIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetParentIds_Ljava_util_List_);
			return cb_setParentIds_Ljava_util_List_;
		}

		static void n_SetParentIds_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newParents)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newParents = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.AnyObjectId>.FromJniHandle (native_newParents, JniHandleOwnership.DoNotTransfer);
			__this.SetParentIds (newParents);
		}
#pragma warning restore 0169

		/// <param name="newParents">the entire list of parents for this commit.</param>
		/// <summary>Set the parents of this commit.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setParentIds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends org.eclipse.jgit.lib.AnyObjectId&gt;']]"
		[Register ("setParentIds", "(Ljava/util/List;)V", "GetSetParentIds_Ljava_util_List_Handler")]
		public virtual unsafe void SetParentIds (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.AnyObjectId> newParents)
		{
			const string __id = "setParentIds.(Ljava/util/List;)V";
			IntPtr native_newParents = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.AnyObjectId>.ToLocalJniHandle (newParents);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newParents);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newParents);
				global::System.GC.KeepAlive (newParents);
			}
		}

		static Delegate cb_setParentIds_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetParentIds_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setParentIds_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setParentIds_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetParentIds_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setParentIds_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_SetParentIds_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent1, IntPtr native_parent2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_parent1, JniHandleOwnership.DoNotTransfer);
			var parent2 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_parent2, JniHandleOwnership.DoNotTransfer);
			__this.SetParentIds (parent1, parent2);
		}
#pragma warning restore 0169

		/// <param name="parent1">the first parent of this commit. Typically this is the current
		///            value of the <c>HEAD</c> reference and is thus the current
		///            branch's position in history.</param>
		/// <param name="parent2">the second parent of this merge commit. Usually this is the
		///            branch being merged into the current branch.</param>
		/// <summary>Set the parents of this commit.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setParentIds' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setParentIds", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetSetParentIds_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void SetParentIds (global::Org.Eclipse.Jgit.Lib.AnyObjectId parent1, global::Org.Eclipse.Jgit.Lib.AnyObjectId parent2)
		{
			const string __id = "setParentIds.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parent1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent1).Handle);
				__args [1] = new JniArgumentValue ((parent2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parent1);
				global::System.GC.KeepAlive (parent2);
			}
		}

		static Delegate cb_setParentIds_arrayLorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetSetParentIds_arrayLorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_setParentIds_arrayLorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_setParentIds_arrayLorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetParentIds_arrayLorg_eclipse_jgit_lib_ObjectId_);
			return cb_setParentIds_arrayLorg_eclipse_jgit_lib_ObjectId_;
		}

		static void n_SetParentIds_arrayLorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newParents)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newParents = (global::Org.Eclipse.Jgit.Lib.ObjectId[]) JNIEnv.GetArray (native_newParents, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Lib.ObjectId));
			__this.SetParentIds (newParents);
			if (newParents != null)
				JNIEnv.CopyArray (newParents, native_newParents);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setParentIds' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId...']]"
		[Register ("setParentIds", "([Lorg/eclipse/jgit/lib/ObjectId;)V", "GetSetParentIds_arrayLorg_eclipse_jgit_lib_ObjectId_Handler")]
		public virtual unsafe void SetParentIds (params global::Org.Eclipse.Jgit.Lib.ObjectId[] newParents)
		{
			const string __id = "setParentIds.([Lorg/eclipse/jgit/lib/ObjectId;)V";
			IntPtr native_newParents = JNIEnv.NewArray (newParents);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newParents);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (newParents != null) {
					JNIEnv.CopyArray (native_newParents, newParents);
					JNIEnv.DeleteLocalRef (native_newParents);
				}
				global::System.GC.KeepAlive (newParents);
			}
		}

		static Delegate cb_setTreeId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetTreeId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setTreeId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setTreeId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTreeId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setTreeId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_SetTreeId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.SetTreeId (id);
		}
#pragma warning restore 0169

		/// <param name="id">the tree identity.</param>
		/// <summary>Set the tree id for this commit object</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='setTreeId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setTreeId", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetSetTreeId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void SetTreeId (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "setTreeId.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CommitBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		/// <summary>Format this builder's state as a commit object.</summary>
		/// <returns>this object in the canonical commit format, suitable for storage
		///         in a repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CommitBuilder']/method[@name='toByteArray' and count(parameter)=0]"
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
