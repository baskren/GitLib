using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>This URI like construct used for referencing Git archives over the net, as
	/// well as locally stored archives.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/URIish", DoNotGenerateAcw=true)]
	public partial class URIish : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/URIish", typeof (URIish));

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

		protected URIish (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty, non-configured URI.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/constructor[@name='URIish' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe URIish () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="s">s</param>
		/// <summary>Parse and construct an <c>URIish</c> from a string</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/constructor[@name='URIish' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe URIish (string s) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		/// <param name="u">the source URL to convert from.</param>
		/// <summary>Construct a URIish from a standard URL.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/constructor[@name='URIish' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/net/URL;)V", "")]
		public unsafe URIish (global::Java.Net.URL u) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URL;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((u == null) ? IntPtr.Zero : ((global::Java.Lang.Object) u).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (u);
			}
		}

		static Delegate cb_getHost;
#pragma warning disable 0169
		static Delegate GetGetHostHandler ()
		{
			if (cb_getHost == null)
				cb_getHost = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHost);
			return cb_getHost;
		}

		static IntPtr n_GetHost (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Host);
		}
#pragma warning restore 0169

		/// <returns>host name part or null</returns>
		public virtual unsafe string Host {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='getHost' and count(parameter)=0]"
			[Register ("getHost", "()Ljava/lang/String;", "GetGetHostHandler")]
			get {
				const string __id = "getHost.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHumanishName;
#pragma warning disable 0169
		static Delegate GetGetHumanishNameHandler ()
		{
			if (cb_getHumanishName == null)
				cb_getHumanishName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHumanishName);
			return cb_getHumanishName;
		}

		static IntPtr n_GetHumanishName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HumanishName);
		}
#pragma warning restore 0169

		/// <summary>Get the "humanish" part of the path.</summary>
		/// <returns>the "humanish" part of the path. May be an empty string. Never
		///         <c>null</c>.</returns>
		public virtual unsafe string HumanishName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='getHumanishName' and count(parameter)=0]"
			[Register ("getHumanishName", "()Ljava/lang/String;", "GetGetHumanishNameHandler")]
			get {
				const string __id = "getHumanishName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRemote;
#pragma warning disable 0169
		static Delegate GetIsRemoteHandler ()
		{
			if (cb_isRemote == null)
				cb_isRemote = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRemote);
			return cb_isRemote;
		}

		static bool n_IsRemote (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRemote;
		}
#pragma warning restore 0169

		/// <returns>true if this URI references a repository on another system.</returns>
		public virtual unsafe bool IsRemote {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='isRemote' and count(parameter)=0]"
			[Register ("isRemote", "()Z", "GetIsRemoteHandler")]
			get {
				const string __id = "isRemote.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPass;
#pragma warning disable 0169
		static Delegate GetGetPassHandler ()
		{
			if (cb_getPass == null)
				cb_getPass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPass);
			return cb_getPass;
		}

		static IntPtr n_GetPass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pass);
		}
#pragma warning restore 0169

		/// <returns>password requested for transfer or null</returns>
		public virtual unsafe string Pass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='getPass' and count(parameter)=0]"
			[Register ("getPass", "()Ljava/lang/String;", "GetGetPassHandler")]
			get {
				const string __id = "getPass.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		/// <returns>path name component</returns>
		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		/// <returns>port number requested for transfer or -1 if not explicit</returns>
		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				const string __id = "getPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRawPath;
#pragma warning disable 0169
		static Delegate GetGetRawPathHandler ()
		{
			if (cb_getRawPath == null)
				cb_getRawPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawPath);
			return cb_getRawPath;
		}

		static IntPtr n_GetRawPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RawPath);
		}
#pragma warning restore 0169

		/// <returns>path name component</returns>
		public virtual unsafe string RawPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='getRawPath' and count(parameter)=0]"
			[Register ("getRawPath", "()Ljava/lang/String;", "GetGetRawPathHandler")]
			get {
				const string __id = "getRawPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScheme;
#pragma warning disable 0169
		static Delegate GetGetSchemeHandler ()
		{
			if (cb_getScheme == null)
				cb_getScheme = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScheme);
			return cb_getScheme;
		}

		static IntPtr n_GetScheme (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scheme);
		}
#pragma warning restore 0169

		/// <returns>protocol name or null for local references</returns>
		public virtual unsafe string Scheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='getScheme' and count(parameter)=0]"
			[Register ("getScheme", "()Ljava/lang/String;", "GetGetSchemeHandler")]
			get {
				const string __id = "getScheme.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUser;
#pragma warning disable 0169
		static Delegate GetGetUserHandler ()
		{
			if (cb_getUser == null)
				cb_getUser = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUser);
			return cb_getUser;
		}

		static IntPtr n_GetUser (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.User);
		}
#pragma warning restore 0169

		/// <returns>user name requested for transfer or null</returns>
		public virtual unsafe string User {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='getUser' and count(parameter)=0]"
			[Register ("getUser", "()Ljava/lang/String;", "GetGetUserHandler")]
			get {
				const string __id = "getUser.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHost_Ljava_lang_String_Handler ()
		{
			if (cb_setHost_Ljava_lang_String_ == null)
				cb_setHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetHost_Ljava_lang_String_);
			return cb_setHost_Ljava_lang_String_;
		}

		static IntPtr n_SetHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = JNIEnv.GetString (native_n, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHost (n));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="n">the new value for host.</param>
		/// <summary>Return a new URI matching this one, but with a different host.</summary>
		/// <returns>a new URI with the updated value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='setHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHost", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;", "GetSetHost_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.URIish SetHost (string n)
		{
			const string __id = "setHost.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;";
			IntPtr native_n = JNIEnv.NewString ((string)n);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_n);
			}
		}

		static Delegate cb_setPass_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPass_Ljava_lang_String_Handler ()
		{
			if (cb_setPass_Ljava_lang_String_ == null)
				cb_setPass_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPass_Ljava_lang_String_);
			return cb_setPass_Ljava_lang_String_;
		}

		static IntPtr n_SetPass_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = JNIEnv.GetString (native_n, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPass (n));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="n">the new value for password.</param>
		/// <summary>Return a new URI matching this one, but with a different password.</summary>
		/// <returns>a new URI with the updated value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='setPass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPass", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;", "GetSetPass_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.URIish SetPass (string n)
		{
			const string __id = "setPass.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;";
			IntPtr native_n = JNIEnv.NewString ((string)n);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_n);
			}
		}

		static Delegate cb_setPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPath_Ljava_lang_String_Handler ()
		{
			if (cb_setPath_Ljava_lang_String_ == null)
				cb_setPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPath_Ljava_lang_String_);
			return cb_setPath_Ljava_lang_String_;
		}

		static IntPtr n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = JNIEnv.GetString (native_n, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPath (n));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="n">the new value for path.</param>
		/// <summary>Return a new URI matching this one, but with a different path.</summary>
		/// <returns>a new URI with the updated value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPath", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;", "GetSetPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.URIish SetPath (string n)
		{
			const string __id = "setPath.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;";
			IntPtr native_n = JNIEnv.NewString ((string)n);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_n);
			}
		}

		static Delegate cb_setPort_I;
#pragma warning disable 0169
		static Delegate GetSetPort_IHandler ()
		{
			if (cb_setPort_I == null)
				cb_setPort_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetPort_I);
			return cb_setPort_I;
		}

		static IntPtr n_SetPort_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPort (n));
		}
#pragma warning restore 0169

		/// <param name="n">the new value for port.</param>
		/// <summary>Return a new URI matching this one, but with a different port.</summary>
		/// <returns>a new URI with the updated value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='setPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPort", "(I)Lorg/eclipse/jgit/transport/URIish;", "GetSetPort_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.URIish SetPort (int n)
		{
			const string __id = "setPort.(I)Lorg/eclipse/jgit/transport/URIish;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRawPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRawPath_Ljava_lang_String_Handler ()
		{
			if (cb_setRawPath_Ljava_lang_String_ == null)
				cb_setRawPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRawPath_Ljava_lang_String_);
			return cb_setRawPath_Ljava_lang_String_;
		}

		static IntPtr n_SetRawPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = JNIEnv.GetString (native_n, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRawPath (n));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="n">the new value for path.</param>
		/// <summary>Return a new URI matching this one, but with a different (raw) path.</summary>
		/// <returns>a new URI with the updated value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='setRawPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRawPath", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;", "GetSetRawPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.URIish SetRawPath (string n)
		{
			const string __id = "setRawPath.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;";
			IntPtr native_n = JNIEnv.NewString ((string)n);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_n);
			}
		}

		static Delegate cb_setScheme_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScheme_Ljava_lang_String_Handler ()
		{
			if (cb_setScheme_Ljava_lang_String_ == null)
				cb_setScheme_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetScheme_Ljava_lang_String_);
			return cb_setScheme_Ljava_lang_String_;
		}

		static IntPtr n_SetScheme_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = JNIEnv.GetString (native_n, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetScheme (n));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="n">the new value for scheme.</param>
		/// <summary>Return a new URI matching this one, but with a different scheme.</summary>
		/// <returns>a new URI with the updated value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='setScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setScheme", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;", "GetSetScheme_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.URIish SetScheme (string n)
		{
			const string __id = "setScheme.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;";
			IntPtr native_n = JNIEnv.NewString ((string)n);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_n);
			}
		}

		static Delegate cb_setUser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUser_Ljava_lang_String_Handler ()
		{
			if (cb_setUser_Ljava_lang_String_ == null)
				cb_setUser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUser_Ljava_lang_String_);
			return cb_setUser_Ljava_lang_String_;
		}

		static IntPtr n_SetUser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = JNIEnv.GetString (native_n, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUser (n));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="n">the new value for user.</param>
		/// <summary>Return a new URI matching this one, but with a different user.</summary>
		/// <returns>a new URI with the updated value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='setUser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUser", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;", "GetSetUser_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.URIish SetUser (string n)
		{
			const string __id = "setUser.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/URIish;";
			IntPtr native_n = JNIEnv.NewString ((string)n);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_n);
			}
		}

		static Delegate cb_toASCIIString;
#pragma warning disable 0169
		static Delegate GetToASCIIStringHandler ()
		{
			if (cb_toASCIIString == null)
				cb_toASCIIString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToASCIIString);
			return cb_toASCIIString;
		}

		static IntPtr n_ToASCIIString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToASCIIString ());
		}
#pragma warning restore 0169

		/// <returns>the URI as an ASCII string. Password is not included.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='toASCIIString' and count(parameter)=0]"
		[Register ("toASCIIString", "()Ljava/lang/String;", "GetToASCIIStringHandler")]
		public virtual unsafe string ToASCIIString ()
		{
			const string __id = "toASCIIString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toPrivateASCIIString;
#pragma warning disable 0169
		static Delegate GetToPrivateASCIIStringHandler ()
		{
			if (cb_toPrivateASCIIString == null)
				cb_toPrivateASCIIString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToPrivateASCIIString);
			return cb_toPrivateASCIIString;
		}

		static IntPtr n_ToPrivateASCIIString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToPrivateASCIIString ());
		}
#pragma warning restore 0169

		/// <returns>the URI including password, formatted with only ASCII characters
		///         such that it will be valid for use over the network.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='toPrivateASCIIString' and count(parameter)=0]"
		[Register ("toPrivateASCIIString", "()Ljava/lang/String;", "GetToPrivateASCIIStringHandler")]
		public virtual unsafe string ToPrivateASCIIString ()
		{
			const string __id = "toPrivateASCIIString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toPrivateString;
#pragma warning disable 0169
		static Delegate GetToPrivateStringHandler ()
		{
			if (cb_toPrivateString == null)
				cb_toPrivateString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToPrivateString);
			return cb_toPrivateString;
		}

		static IntPtr n_ToPrivateString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToPrivateString ());
		}
#pragma warning restore 0169

		/// <summary>Obtain the string form of the URI, with the password included.</summary>
		/// <returns>the URI, including its password field, if any.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='URIish']/method[@name='toPrivateString' and count(parameter)=0]"
		[Register ("toPrivateString", "()Ljava/lang/String;", "GetToPrivateStringHandler")]
		public virtual unsafe string ToPrivateString ()
		{
			const string __id = "toPrivateString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
