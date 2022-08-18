using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A RefUpdate combination for renaming a reference.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefRename", DoNotGenerateAcw=true)]
	public abstract partial class RefRename : global::Java.Lang.Object {

		/// <summary>Update operation to create/overwrite the destination reference.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/field[@name='destination']"
		[Register ("destination")]
		protected global::Org.Eclipse.Jgit.Lib.RefUpdate Destination {
			get {
				const string __id = "destination.Lorg/eclipse/jgit/lib/RefUpdate;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "destination.Lorg/eclipse/jgit/lib/RefUpdate;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Update operation to read and delete the source reference.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/field[@name='source']"
		[Register ("source")]
		protected global::Org.Eclipse.Jgit.Lib.RefUpdate Source {
			get {
				const string __id = "source.Lorg/eclipse/jgit/lib/RefUpdate;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "source.Lorg/eclipse/jgit/lib/RefUpdate;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefRename", typeof (RefRename));

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

		protected RefRename (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="src">operation to read and delete the source.</param>
		/// <param name="dst">operation to create (or overwrite) the destination.</param>
		/// <summary>Initialize a new rename operation.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/constructor[@name='RefRename' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.RefUpdate'] and parameter[2][@type='org.eclipse.jgit.lib.RefUpdate']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/RefUpdate;Lorg/eclipse/jgit/lib/RefUpdate;)V", "")]
		protected unsafe RefRename (global::Org.Eclipse.Jgit.Lib.RefUpdate src, global::Org.Eclipse.Jgit.Lib.RefUpdate dst) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/RefUpdate;Lorg/eclipse/jgit/lib/RefUpdate;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (dst);
			}
		}

		static Delegate cb_getRefLogIdent;
#pragma warning disable 0169
		static Delegate GetGetRefLogIdentHandler ()
		{
			if (cb_getRefLogIdent == null)
				cb_getRefLogIdent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefLogIdent);
			return cb_getRefLogIdent;
		}

		static IntPtr n_GetRefLogIdent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefLogIdent);
		}
#pragma warning restore 0169

		static Delegate cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static void n_SetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pi)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pi = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_pi, JniHandleOwnership.DoNotTransfer);
			__this.RefLogIdent = pi;
		}
#pragma warning restore 0169

		/// <returns>identity of the user making the change in the reflog.</returns>
		/// <summary>Set the identity of the user appearing in the reflog.</summary>
		/// <param name="pi">identity of the user. If null the identity will be
		///            automatically determined based on the repository
		///            configuration.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent RefLogIdent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='getRefLogIdent' and count(parameter)=0]"
			[Register ("getRefLogIdent", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetRefLogIdentHandler")]
			get {
				const string __id = "getRefLogIdent.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='setRefLogIdent' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
			[Register ("setRefLogIdent", "(Lorg/eclipse/jgit/lib/PersonIdent;)V", "GetSetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
			set {
				const string __id = "setRefLogIdent.(Lorg/eclipse/jgit/lib/PersonIdent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getRefLogMessage;
#pragma warning disable 0169
		static Delegate GetGetRefLogMessageHandler ()
		{
			if (cb_getRefLogMessage == null)
				cb_getRefLogMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefLogMessage);
			return cb_getRefLogMessage;
		}

		static IntPtr n_GetRefLogMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefLogMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setRefLogMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRefLogMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setRefLogMessage_Ljava_lang_String_ == null)
				cb_setRefLogMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRefLogMessage_Ljava_lang_String_);
			return cb_setRefLogMessage_Ljava_lang_String_;
		}

		static void n_SetRefLogMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.RefLogMessage = msg;
		}
#pragma warning restore 0169

		/// <summary>Get the message to include in the reflog. -or- Set the message to include in the reflog.</summary>
		/// <returns>message the caller wants to include in the reflog; null if the
		///         rename should not be logged.</returns>
		/// <param name="msg">the message to describe this change.</param>
		public virtual unsafe string RefLogMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='getRefLogMessage' and count(parameter)=0]"
			[Register ("getRefLogMessage", "()Ljava/lang/String;", "GetGetRefLogMessageHandler")]
			get {
				const string __id = "getRefLogMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='setRefLogMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRefLogMessage", "(Ljava/lang/String;)V", "GetSetRefLogMessage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRefLogMessage.(Ljava/lang/String;)V";
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

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetGetResultHandler")]
			get {
				const string __id = "getResult.()Lorg/eclipse/jgit/lib/RefUpdate$Result;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_disableRefLog;
#pragma warning disable 0169
		static Delegate GetDisableRefLogHandler ()
		{
			if (cb_disableRefLog == null)
				cb_disableRefLog = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisableRefLog);
			return cb_disableRefLog;
		}

		static void n_DisableRefLog (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableRefLog ();
		}
#pragma warning restore 0169

		/// <summary>Don't record this rename in the ref's associated reflog.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='disableRefLog' and count(parameter)=0]"
		[Register ("disableRefLog", "()V", "GetDisableRefLogHandler")]
		public virtual unsafe void DisableRefLog ()
		{
			const string __id = "disableRefLog.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doRename;
#pragma warning disable 0169
		static Delegate GetDoRenameHandler ()
		{
			if (cb_doRename == null)
				cb_doRename = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DoRename);
			return cb_doRename;
		}

		static IntPtr n_DoRename (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DoRename ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='doRename' and count(parameter)=0]"
		[Register ("doRename", "()Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDoRenameHandler")]
		protected abstract global::Org.Eclipse.Jgit.Lib.RefUpdate.Result DoRename ();

		static Delegate cb_needToUpdateHEAD;
#pragma warning disable 0169
		static Delegate GetNeedToUpdateHEADHandler ()
		{
			if (cb_needToUpdateHEAD == null)
				cb_needToUpdateHEAD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_NeedToUpdateHEAD);
			return cb_needToUpdateHEAD;
		}

		static bool n_NeedToUpdateHEAD (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedToUpdateHEAD ();
		}
#pragma warning restore 0169

		/// <returns>true if the <c>Constants#HEAD</c> reference needs to be linked
		///         to the new destination name.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='needToUpdateHEAD' and count(parameter)=0]"
		[Register ("needToUpdateHEAD", "()Z", "GetNeedToUpdateHEADHandler")]
		protected virtual unsafe bool NeedToUpdateHEAD ()
		{
			const string __id = "needToUpdateHEAD.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_rename;
#pragma warning disable 0169
		static Delegate GetRenameHandler ()
		{
			if (cb_rename == null)
				cb_rename = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Rename);
			return cb_rename;
		}

		static IntPtr n_Rename (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rename ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='rename' and count(parameter)=0]"
		[Register ("rename", "()Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetRenameHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Rename ()
		{
			const string __id = "rename.()Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefRename", DoNotGenerateAcw=true)]
	internal partial class RefRenameInvoker : RefRename {
		public RefRenameInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefRename", typeof (RefRenameInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefRename']/method[@name='doRename' and count(parameter)=0]"
		[Register ("doRename", "()Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetDoRenameHandler")]
		protected override unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result DoRename ()
		{
			const string __id = "doRename.()Lorg/eclipse/jgit/lib/RefUpdate$Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
