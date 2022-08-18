using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Create/update an annotated tag object or a simple unannotated tag</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/TagCommand", DoNotGenerateAcw=true)]
	public partial class TagCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Lib.IRef> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/TagCommand", typeof (TagCommand));

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

		protected TagCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/constructor[@name='TagCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe TagCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isAnnotated;
#pragma warning disable 0169
		static Delegate GetIsAnnotatedHandler ()
		{
			if (cb_isAnnotated == null)
				cb_isAnnotated = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAnnotated);
			return cb_isAnnotated;
		}

		static bool n_IsAnnotated (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnnotated;
		}
#pragma warning restore 0169

		/// <returns>true if this command will create an annotated tag (default is
		///         true)</returns>
		public virtual unsafe bool IsAnnotated {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='isAnnotated' and count(parameter)=0]"
			[Register ("isAnnotated", "()Z", "GetIsAnnotatedHandler")]
			get {
				const string __id = "isAnnotated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isForceUpdate;
#pragma warning disable 0169
		static Delegate GetIsForceUpdateHandler ()
		{
			if (cb_isForceUpdate == null)
				cb_isForceUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsForceUpdate);
			return cb_isForceUpdate;
		}

		static bool n_IsForceUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsForceUpdate;
		}
#pragma warning restore 0169

		/// <returns>is this a force update</returns>
		public virtual unsafe bool IsForceUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='isForceUpdate' and count(parameter)=0]"
			[Register ("isForceUpdate", "()Z", "GetIsForceUpdateHandler")]
			get {
				const string __id = "isForceUpdate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSigned;
#pragma warning disable 0169
		static Delegate GetIsSignedHandler ()
		{
			if (cb_isSigned == null)
				cb_isSigned = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSigned);
			return cb_isSigned;
		}

		static bool n_IsSigned (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSigned;
		}
#pragma warning restore 0169

		/// <returns>whether the tag is signed</returns>
		public virtual unsafe bool IsSigned {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='isSigned' and count(parameter)=0]"
			[Register ("isSigned", "()Z", "GetIsSignedHandler")]
			get {
				const string __id = "isSigned.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		/// <returns>the tag message used for the &lt;code&gt;tag&lt;/code&gt;</returns>
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		/// <returns>the tag name used for the &lt;code&gt;tag&lt;/code&gt;</returns>
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='getName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectId);
		}
#pragma warning restore 0169

		/// <returns>the object id of the tag</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevObject ObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='getObjectId' and count(parameter)=0]"
			[Register ("getObjectId", "()Lorg/eclipse/jgit/revwalk/RevObject;", "GetGetObjectIdHandler")]
			get {
				const string __id = "getObjectId.()Lorg/eclipse/jgit/revwalk/RevObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tagger);
		}
#pragma warning restore 0169

		/// <returns>the tagger of the tag</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent Tagger {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='getTagger' and count(parameter)=0]"
			[Register ("getTagger", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetTaggerHandler")]
			get {
				const string __id = "getTagger.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>tag</c> command with all the options and parameters
		/// collected by the setter methods of this class.</summary>
		/// <returns>a <c>Ref</c> a ref pointing to a tag</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/lib/Ref;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IRef Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/lib/Ref;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAnnotated_Z;
#pragma warning disable 0169
		static Delegate GetSetAnnotated_ZHandler ()
		{
			if (cb_setAnnotated_Z == null)
				cb_setAnnotated_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAnnotated_Z);
			return cb_setAnnotated_Z;
		}

		static IntPtr n_SetAnnotated_Z (IntPtr jnienv, IntPtr native__this, bool annotated)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAnnotated (annotated));
		}
#pragma warning restore 0169

		/// <param name="annotated">annotated</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='setAnnotated' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAnnotated", "(Z)Lorg/eclipse/jgit/api/TagCommand;", "GetSetAnnotated_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.TagCommand SetAnnotated (bool annotated)
		{
			const string __id = "setAnnotated.(Z)Lorg/eclipse/jgit/api/TagCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (annotated);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setForceUpdate_Z;
#pragma warning disable 0169
		static Delegate GetSetForceUpdate_ZHandler ()
		{
			if (cb_setForceUpdate_Z == null)
				cb_setForceUpdate_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetForceUpdate_Z);
			return cb_setForceUpdate_Z;
		}

		static IntPtr n_SetForceUpdate_Z (IntPtr jnienv, IntPtr native__this, bool forceUpdate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetForceUpdate (forceUpdate));
		}
#pragma warning restore 0169

		/// <param name="forceUpdate">forceUpdate</param>
		/// <summary>If set to true the Tag command may replace an existing tag object.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='setForceUpdate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setForceUpdate", "(Z)Lorg/eclipse/jgit/api/TagCommand;", "GetSetForceUpdate_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.TagCommand SetForceUpdate (bool forceUpdate)
		{
			const string __id = "setForceUpdate.(Z)Lorg/eclipse/jgit/api/TagCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (forceUpdate);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static IntPtr n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (message));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="message">the tag message used for the <c>tag</c></param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessage", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/TagCommand;", "GetSetMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.TagCommand SetMessage (string message)
		{
			const string __id = "setMessage.(Ljava/lang/String;)Lorg/eclipse/jgit/api/TagCommand;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">the tag name used for the <c>tag</c></param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setName", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/TagCommand;", "GetSetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.TagCommand SetName (string name)
		{
			const string __id = "setName.(Ljava/lang/String;)Lorg/eclipse/jgit/api/TagCommand;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetSetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_setObjectId_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static IntPtr n_SetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetObjectId (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">id</param>
		/// <summary>Sets the object id of the tag.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='setObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("setObjectId", "(Lorg/eclipse/jgit/revwalk/RevObject;)Lorg/eclipse/jgit/api/TagCommand;", "GetSetObjectId_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.TagCommand SetObjectId (global::Org.Eclipse.Jgit.Revwalk.RevObject id)
		{
			const string __id = "setObjectId.(Lorg/eclipse/jgit/revwalk/RevObject;)Lorg/eclipse/jgit/api/TagCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_setSigned_Z;
#pragma warning disable 0169
		static Delegate GetSetSigned_ZHandler ()
		{
			if (cb_setSigned_Z == null)
				cb_setSigned_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetSigned_Z);
			return cb_setSigned_Z;
		}

		static IntPtr n_SetSigned_Z (IntPtr jnienv, IntPtr native__this, bool signed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSigned (signed));
		}
#pragma warning restore 0169

		/// <param name="signed">signed</param>
		/// <summary>If set to true the Tag command creates a signed tag object.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='setSigned' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSigned", "(Z)Lorg/eclipse/jgit/api/TagCommand;", "GetSetSigned_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.TagCommand SetSigned (bool signed)
		{
			const string __id = "setSigned.(Z)Lorg/eclipse/jgit/api/TagCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (signed);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTagger_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetTagger_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setTagger_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setTagger_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTagger_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setTagger_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static IntPtr n_SetTagger_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tagger)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tagger = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_tagger, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTagger (tagger));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="tagger">tagger</param>
		/// <summary>Sets the tagger of the tag.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='TagCommand']/method[@name='setTagger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
		[Register ("setTagger", "(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/api/TagCommand;", "GetSetTagger_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.TagCommand SetTagger (global::Org.Eclipse.Jgit.Lib.PersonIdent tagger)
		{
			const string __id = "setTagger.(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/api/TagCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tagger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tagger).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.TagCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (tagger);
			}
		}

	}
}
