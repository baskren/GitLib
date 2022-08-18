using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Simple configuration parser for the OpenSSH ~/.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/OpenSshConfig", DoNotGenerateAcw=true)]
	public partial class OpenSshConfig : global::Java.Lang.Object {
		/// <summary>Configuration of one "Host" block in the configuration file.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/OpenSshConfig$Host", DoNotGenerateAcw=true)]
		public partial class Host : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/OpenSshConfig$Host", typeof (Host));

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

			protected Host (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']/constructor[@name='OpenSshConfig.Host' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Host () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_getConnectionAttempts;
#pragma warning disable 0169
			static Delegate GetGetConnectionAttemptsHandler ()
			{
				if (cb_getConnectionAttempts == null)
					cb_getConnectionAttempts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetConnectionAttempts);
				return cb_getConnectionAttempts;
			}

			static int n_GetConnectionAttempts (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ConnectionAttempts;
			}
#pragma warning restore 0169

			/// <returns>the number of tries (one per second) to connect before
			///         exiting. The argument must be an integer. This may be useful
			///         in scripts if the connection sometimes fails. The default is
			///         1.</returns>
			public virtual unsafe int ConnectionAttempts {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']/method[@name='getConnectionAttempts' and count(parameter)=0]"
				[Register ("getConnectionAttempts", "()I", "GetGetConnectionAttemptsHandler")]
				get {
					const string __id = "getConnectionAttempts.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getHostName;
#pragma warning disable 0169
			static Delegate GetGetHostNameHandler ()
			{
				if (cb_getHostName == null)
					cb_getHostName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHostName);
				return cb_getHostName;
			}

			static IntPtr n_GetHostName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.HostName);
			}
#pragma warning restore 0169

			/// <returns>the real IP address or host name to connect to; never null.</returns>
			public virtual unsafe string HostName {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']/method[@name='getHostName' and count(parameter)=0]"
				[Register ("getHostName", "()Ljava/lang/String;", "GetGetHostNameHandler")]
				get {
					const string __id = "getHostName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getIdentityFile;
#pragma warning disable 0169
			static Delegate GetGetIdentityFileHandler ()
			{
				if (cb_getIdentityFile == null)
					cb_getIdentityFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdentityFile);
				return cb_getIdentityFile;
			}

			static IntPtr n_GetIdentityFile (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IdentityFile);
			}
#pragma warning restore 0169

			/// <returns>path of the private key file to use for authentication; null
			///         if the caller should use default authentication strategies.</returns>
			public virtual unsafe global::Java.IO.File IdentityFile {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']/method[@name='getIdentityFile' and count(parameter)=0]"
				[Register ("getIdentityFile", "()Ljava/io/File;", "GetGetIdentityFileHandler")]
				get {
					const string __id = "getIdentityFile.()Ljava/io/File;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isBatchMode;
#pragma warning disable 0169
			static Delegate GetIsBatchModeHandler ()
			{
				if (cb_isBatchMode == null)
					cb_isBatchMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBatchMode);
				return cb_isBatchMode;
			}

			static bool n_IsBatchMode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsBatchMode;
			}
#pragma warning restore 0169

			/// <returns>true if batch (non-interactive) mode is preferred for this
			///         host connection.</returns>
			public virtual unsafe bool IsBatchMode {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']/method[@name='isBatchMode' and count(parameter)=0]"
				[Register ("isBatchMode", "()Z", "GetIsBatchModeHandler")]
				get {
					const string __id = "isBatchMode.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Port;
			}
#pragma warning restore 0169

			/// <returns>the real port number to connect to; never 0.</returns>
			public virtual unsafe int Port {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']/method[@name='getPort' and count(parameter)=0]"
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

			static Delegate cb_getPreferredAuthentications;
#pragma warning disable 0169
			static Delegate GetGetPreferredAuthenticationsHandler ()
			{
				if (cb_getPreferredAuthentications == null)
					cb_getPreferredAuthentications = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPreferredAuthentications);
				return cb_getPreferredAuthentications;
			}

			static IntPtr n_GetPreferredAuthentications (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PreferredAuthentications);
			}
#pragma warning restore 0169

			/// <returns>the preferred authentication methods, separated by commas if
			///         more than one authentication method is preferred.</returns>
			public virtual unsafe string PreferredAuthentications {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']/method[@name='getPreferredAuthentications' and count(parameter)=0]"
				[Register ("getPreferredAuthentications", "()Ljava/lang/String;", "GetGetPreferredAuthenticationsHandler")]
				get {
					const string __id = "getPreferredAuthentications.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStrictHostKeyChecking;
#pragma warning disable 0169
			static Delegate GetGetStrictHostKeyCheckingHandler ()
			{
				if (cb_getStrictHostKeyChecking == null)
					cb_getStrictHostKeyChecking = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStrictHostKeyChecking);
				return cb_getStrictHostKeyChecking;
			}

			static IntPtr n_GetStrictHostKeyChecking (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.StrictHostKeyChecking);
			}
#pragma warning restore 0169

			/// <returns>the value StrictHostKeyChecking property, the valid values
			///         are "yes" (unknown hosts are not accepted), "no" (unknown
			///         hosts are always accepted), and "ask" (user should be asked
			///         before accepting the host)</returns>
			public virtual unsafe string StrictHostKeyChecking {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']/method[@name='getStrictHostKeyChecking' and count(parameter)=0]"
				[Register ("getStrictHostKeyChecking", "()Ljava/lang/String;", "GetGetStrictHostKeyCheckingHandler")]
				get {
					const string __id = "getStrictHostKeyChecking.()Ljava/lang/String;";
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.User);
			}
#pragma warning restore 0169

			/// <returns>the real user name to connect as; never null.</returns>
			public virtual unsafe string User {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig.Host']/method[@name='getUser' and count(parameter)=0]"
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/OpenSshConfig", typeof (OpenSshConfig));

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

		protected OpenSshConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="fs">the file system abstraction which will be necessary to
		///            perform certain file system operations.</param>
		/// <summary>Obtain the user's configuration data.</summary>
		/// <returns>a caching reader of the user's configuration file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig']/method[@name='get' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.FS']]"
		[Register ("get", "(Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/transport/OpenSshConfig;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.OpenSshConfig Get (global::Org.Eclipse.Jgit.Util.FS fs)
		{
			const string __id = "get.(Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/transport/OpenSshConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fs);
			}
		}

		static Delegate cb_lookup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLookup_Ljava_lang_String_Handler ()
		{
			if (cb_lookup_Ljava_lang_String_ == null)
				cb_lookup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Lookup_Ljava_lang_String_);
			return cb_lookup_Ljava_lang_String_;
		}

		static IntPtr n_Lookup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hostName = JNIEnv.GetString (native_hostName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Lookup (hostName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OpenSshConfig']/method[@name='lookup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lookup", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/OpenSshConfig$Host;", "GetLookup_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host Lookup (string hostName)
		{
			const string __id = "lookup.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/OpenSshConfig$Host;";
			IntPtr native_hostName = JNIEnv.NewString ((string)hostName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hostName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OpenSshConfig.Host> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hostName);
			}
		}

	}
}
