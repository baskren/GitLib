using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Mutable builder to construct an annotated tag recording a project state.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/TagBuilder", DoNotGenerateAcw=true)]
	public partial class TagBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/TagBuilder", typeof (TagBuilder));

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

		protected TagBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/constructor[@name='TagBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TagBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newMessage = JNIEnv.GetString (native_newMessage, JniHandleOwnership.DoNotTransfer);
			__this.Message = newMessage;
		}
#pragma warning restore 0169

		/// <returns>the complete commit message.</returns>
		/// <summary>Set the tag's message.</summary>
		/// <param name="newMessage">the tag's message.</param>
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getObjectId;
#pragma warning disable 0169
		static Delegate GetGetObjectIdHandler ()
		{
			if (cb_getObjectId == null)
				cb_getObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectId);
			return cb_getObjectId;
		}

		static IntPtr n_GetObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectId);
		}
#pragma warning restore 0169

		/// <returns>the object this tag refers to.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='getObjectId' and count(parameter)=0]"
			[Register ("getObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObjectIdHandler")]
			get {
				const string __id = "getObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectType;
#pragma warning disable 0169
		static Delegate GetGetObjectTypeHandler ()
		{
			if (cb_getObjectType == null)
				cb_getObjectType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetObjectType);
			return cb_getObjectType;
		}

		static int n_GetObjectType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectType;
		}
#pragma warning restore 0169

		/// <returns>the type of object this tag refers to.</returns>
		public virtual unsafe int ObjectType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='getObjectType' and count(parameter)=0]"
			[Register ("getObjectType", "()I", "GetGetObjectTypeHandler")]
			get {
				const string __id = "getObjectType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		static Delegate cb_setTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTag_Ljava_lang_String_Handler ()
		{
			if (cb_setTag_Ljava_lang_String_ == null)
				cb_setTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTag_Ljava_lang_String_);
			return cb_setTag_Ljava_lang_String_;
		}

		static void n_SetTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_shortName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var shortName = JNIEnv.GetString (native_shortName, JniHandleOwnership.DoNotTransfer);
			__this.Tag = shortName;
		}
#pragma warning restore 0169

		/// <returns>short name of the tag (no <c>refs/tags/</c> prefix).</returns>
		/// <summary>Set the name of this tag.</summary>
		/// <param name="shortName">new short name of the tag. This short name should not start
		///            with <c>refs/</c> as typically a tag is stored under the
		///            reference derived from <c>"refs/tags/" + getTag()</c>.</param>
		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
			get {
				const string __id = "getTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTag", "(Ljava/lang/String;)V", "GetSetTag_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTag.(Ljava/lang/String;)V";
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

		static Delegate cb_getTagger;
#pragma warning disable 0169
		static Delegate GetGetTaggerHandler ()
		{
			if (cb_getTagger == null)
				cb_getTagger = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTagger);
			return cb_getTagger;
		}

		static IntPtr n_GetTagger (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tagger);
		}
#pragma warning restore 0169

		static Delegate cb_setTagger_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetTagger_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setTagger_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setTagger_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTagger_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setTagger_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static void n_SetTagger_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_taggerIdent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var taggerIdent = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_taggerIdent, JniHandleOwnership.DoNotTransfer);
			__this.Tagger = taggerIdent;
		}
#pragma warning restore 0169

		/// <returns>creator of this tag. May be null.</returns>
		/// <summary>Set the creator of this tag.</summary>
		/// <param name="taggerIdent">the creator. May be null.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent Tagger {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='getTagger' and count(parameter)=0]"
			[Register ("getTagger", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetTaggerHandler")]
			get {
				const string __id = "getTagger.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='setTagger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
			[Register ("setTagger", "(Lorg/eclipse/jgit/lib/PersonIdent;)V", "GetSetTagger_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
			set {
				const string __id = "setTagger.(Lorg/eclipse/jgit/lib/PersonIdent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Build ());
		}
#pragma warning restore 0169

		/// <summary>Format this builder's state as an annotated tag object.</summary>
		/// <returns>this object in the canonical annotated tag format, suitable for
		///         storage in a repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='build' and count(parameter)=0]"
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

		static Delegate cb_setObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetSetObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_setObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_setObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SetObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_setObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static void n_SetObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, int objType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.SetObjectId (obj, objType);
		}
#pragma warning restore 0169

		/// <param name="obj">the object.</param>
		/// <param name="objType">the type of <c>obj</c>. Must be a valid type code.</param>
		/// <summary>Set the object this tag refers to, and its type.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='setObjectId' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("setObjectId", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)V", "GetSetObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public virtual unsafe void SetObjectId (global::Org.Eclipse.Jgit.Lib.AnyObjectId obj, int objType)
		{
			const string __id = "setObjectId.(Lorg/eclipse/jgit/lib/AnyObjectId;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (objType);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetSetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static void n_SetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.SetObjectId (obj);
		}
#pragma warning restore 0169

		/// <param name="obj">the object the tag will refer to.</param>
		/// <summary>Set the object this tag refers to, and infer its type.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='setObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("setObjectId", "(Lorg/eclipse/jgit/revwalk/RevObject;)V", "GetSetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe void SetObjectId (global::Org.Eclipse.Jgit.Revwalk.RevObject obj)
		{
			const string __id = "setObjectId.(Lorg/eclipse/jgit/revwalk/RevObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TagBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		/// <summary>Format this builder's state as an annotated tag object.</summary>
		/// <returns>this object in the canonical annotated tag format, suitable for
		///         storage in a repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TagBuilder']/method[@name='toByteArray' and count(parameter)=0]"
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
