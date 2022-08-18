using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>The standard "user" configuration parameters.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/UserConfig", DoNotGenerateAcw=true)]
	public partial class UserConfig : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']/field[@name='KEY']"
		[Register ("KEY")]
		public static global::Org.Eclipse.Jgit.Lib.Config.ISectionParser Key {
			get {
				const string __id = "KEY.Lorg/eclipse/jgit/lib/Config$SectionParser;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.ISectionParser> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/UserConfig", typeof (UserConfig));

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

		protected UserConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAuthorEmail;
#pragma warning disable 0169
		static Delegate GetGetAuthorEmailHandler ()
		{
			if (cb_getAuthorEmail == null)
				cb_getAuthorEmail = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorEmail);
			return cb_getAuthorEmail;
		}

		static IntPtr n_GetAuthorEmail (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.UserConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorEmail);
		}
#pragma warning restore 0169

		/// <returns>the author email as defined in git variables and
		///         configurations. If no email could be found, try to
		///         propose one default with the user name and the
		///         host name.</returns>
		public virtual unsafe string AuthorEmail {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']/method[@name='getAuthorEmail' and count(parameter)=0]"
			[Register ("getAuthorEmail", "()Ljava/lang/String;", "GetGetAuthorEmailHandler")]
			get {
				const string __id = "getAuthorEmail.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorName;
#pragma warning disable 0169
		static Delegate GetGetAuthorNameHandler ()
		{
			if (cb_getAuthorName == null)
				cb_getAuthorName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuthorName);
			return cb_getAuthorName;
		}

		static IntPtr n_GetAuthorName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.UserConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorName);
		}
#pragma warning restore 0169

		/// <returns>the author name as defined in the git variables and
		///         configurations. If no name could be found, try to use the system
		///         user name instead.</returns>
		public virtual unsafe string AuthorName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']/method[@name='getAuthorName' and count(parameter)=0]"
			[Register ("getAuthorName", "()Ljava/lang/String;", "GetGetAuthorNameHandler")]
			get {
				const string __id = "getAuthorName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCommitterEmail;
#pragma warning disable 0169
		static Delegate GetGetCommitterEmailHandler ()
		{
			if (cb_getCommitterEmail == null)
				cb_getCommitterEmail = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommitterEmail);
			return cb_getCommitterEmail;
		}

		static IntPtr n_GetCommitterEmail (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.UserConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CommitterEmail);
		}
#pragma warning restore 0169

		/// <returns>the committer email as defined in git variables and
		///         configurations. If no email could be found, try to
		///         propose one default with the user name and the
		///         host name.</returns>
		public virtual unsafe string CommitterEmail {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']/method[@name='getCommitterEmail' and count(parameter)=0]"
			[Register ("getCommitterEmail", "()Ljava/lang/String;", "GetGetCommitterEmailHandler")]
			get {
				const string __id = "getCommitterEmail.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCommitterName;
#pragma warning disable 0169
		static Delegate GetGetCommitterNameHandler ()
		{
			if (cb_getCommitterName == null)
				cb_getCommitterName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommitterName);
			return cb_getCommitterName;
		}

		static IntPtr n_GetCommitterName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.UserConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CommitterName);
		}
#pragma warning restore 0169

		/// <returns>the committer name as defined in the git variables and
		///         configurations. If no name could be found, try to use the system
		///         user name instead.</returns>
		public virtual unsafe string CommitterName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']/method[@name='getCommitterName' and count(parameter)=0]"
			[Register ("getCommitterName", "()Ljava/lang/String;", "GetGetCommitterNameHandler")]
			get {
				const string __id = "getCommitterName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAuthorEmailImplicit;
#pragma warning disable 0169
		static Delegate GetIsAuthorEmailImplicitHandler ()
		{
			if (cb_isAuthorEmailImplicit == null)
				cb_isAuthorEmailImplicit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAuthorEmailImplicit);
			return cb_isAuthorEmailImplicit;
		}

		static bool n_IsAuthorEmailImplicit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.UserConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthorEmailImplicit;
		}
#pragma warning restore 0169

		/// <returns>true if the author email was not explicitly configured but
		///         constructed from information the system has about the logged on
		///         user</returns>
		public virtual unsafe bool IsAuthorEmailImplicit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']/method[@name='isAuthorEmailImplicit' and count(parameter)=0]"
			[Register ("isAuthorEmailImplicit", "()Z", "GetIsAuthorEmailImplicitHandler")]
			get {
				const string __id = "isAuthorEmailImplicit.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAuthorNameImplicit;
#pragma warning disable 0169
		static Delegate GetIsAuthorNameImplicitHandler ()
		{
			if (cb_isAuthorNameImplicit == null)
				cb_isAuthorNameImplicit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAuthorNameImplicit);
			return cb_isAuthorNameImplicit;
		}

		static bool n_IsAuthorNameImplicit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.UserConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthorNameImplicit;
		}
#pragma warning restore 0169

		/// <returns>true if the author name was not explicitly configured but
		///         constructed from information the system has about the logged on
		///         user</returns>
		public virtual unsafe bool IsAuthorNameImplicit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']/method[@name='isAuthorNameImplicit' and count(parameter)=0]"
			[Register ("isAuthorNameImplicit", "()Z", "GetIsAuthorNameImplicitHandler")]
			get {
				const string __id = "isAuthorNameImplicit.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isCommitterEmailImplicit;
#pragma warning disable 0169
		static Delegate GetIsCommitterEmailImplicitHandler ()
		{
			if (cb_isCommitterEmailImplicit == null)
				cb_isCommitterEmailImplicit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCommitterEmailImplicit);
			return cb_isCommitterEmailImplicit;
		}

		static bool n_IsCommitterEmailImplicit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.UserConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCommitterEmailImplicit;
		}
#pragma warning restore 0169

		/// <returns>true if the author email was not explicitly configured but
		///         constructed from information the system has about the logged on
		///         user</returns>
		public virtual unsafe bool IsCommitterEmailImplicit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']/method[@name='isCommitterEmailImplicit' and count(parameter)=0]"
			[Register ("isCommitterEmailImplicit", "()Z", "GetIsCommitterEmailImplicitHandler")]
			get {
				const string __id = "isCommitterEmailImplicit.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isCommitterNameImplicit;
#pragma warning disable 0169
		static Delegate GetIsCommitterNameImplicitHandler ()
		{
			if (cb_isCommitterNameImplicit == null)
				cb_isCommitterNameImplicit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCommitterNameImplicit);
			return cb_isCommitterNameImplicit;
		}

		static bool n_IsCommitterNameImplicit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.UserConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCommitterNameImplicit;
		}
#pragma warning restore 0169

		/// <returns>true if the committer name was not explicitly configured but
		///         constructed from information the system has about the logged on
		///         user</returns>
		public virtual unsafe bool IsCommitterNameImplicit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='UserConfig']/method[@name='isCommitterNameImplicit' and count(parameter)=0]"
			[Register ("isCommitterNameImplicit", "()Z", "GetIsCommitterNameImplicitHandler")]
			get {
				const string __id = "isCommitterNameImplicit.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
