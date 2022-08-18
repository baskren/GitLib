using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Abstract authenticator which remembers prior authentications.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='CachedAuthenticator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/CachedAuthenticator", DoNotGenerateAcw=true)]
	public abstract partial class CachedAuthenticator : global::Java.Net.Authenticator {
		/// <summary>Authentication data to remember and reuse.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='CachedAuthenticator.CachedAuthentication']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/CachedAuthenticator$CachedAuthentication", DoNotGenerateAcw=true)]
		public partial class CachedAuthentication : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/CachedAuthenticator$CachedAuthentication", typeof (CachedAuthentication));

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

			protected CachedAuthentication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="aHost">system this is for.</param>
			/// <param name="aPort">port number of the service.</param>
			/// <param name="aUser">username at the service.</param>
			/// <param name="aPass">password at the service.</param>
			/// <summary>Create a new cached authentication.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='CachedAuthenticator.CachedAuthentication']/constructor[@name='CachedAuthenticator.CachedAuthentication' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe CachedAuthentication (string aHost, int aPort, string aUser, string aPass) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_aHost = JNIEnv.NewString ((string)aHost);
				IntPtr native_aUser = JNIEnv.NewString ((string)aUser);
				IntPtr native_aPass = JNIEnv.NewString ((string)aPass);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_aHost);
					__args [1] = new JniArgumentValue (aPort);
					__args [2] = new JniArgumentValue (native_aUser);
					__args [3] = new JniArgumentValue (native_aPass);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_aHost);
					JNIEnv.DeleteLocalRef (native_aUser);
					JNIEnv.DeleteLocalRef (native_aPass);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/CachedAuthenticator", typeof (CachedAuthenticator));

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

		protected CachedAuthenticator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='CachedAuthenticator']/constructor[@name='CachedAuthenticator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CachedAuthenticator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		protected override unsafe global::Java.Net.PasswordAuthentication PasswordAuthentication {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='CachedAuthenticator']/method[@name='getPasswordAuthentication' and count(parameter)=0]"
			[Register ("getPasswordAuthentication", "()Ljava/net/PasswordAuthentication;", "")]
			get {
				const string __id = "getPasswordAuthentication.()Ljava/net/PasswordAuthentication;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.PasswordAuthentication> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='CachedAuthenticator']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.CachedAuthenticator.CachedAuthentication']]"
		[Register ("add", "(Lorg/eclipse/jgit/util/CachedAuthenticator$CachedAuthentication;)V", "")]
		public static unsafe void Add (global::Org.Eclipse.Jgit.Util.CachedAuthenticator.CachedAuthentication ca)
		{
			const string __id = "add.(Lorg/eclipse/jgit/util/CachedAuthenticator$CachedAuthentication;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ca == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ca).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (ca);
			}
		}

		static Delegate cb_promptPasswordAuthentication;
#pragma warning disable 0169
		static Delegate GetPromptPasswordAuthenticationHandler ()
		{
			if (cb_promptPasswordAuthentication == null)
				cb_promptPasswordAuthentication = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PromptPasswordAuthentication);
			return cb_promptPasswordAuthentication;
		}

		static IntPtr n_PromptPasswordAuthentication (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.CachedAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PromptPasswordAuthentication ());
		}
#pragma warning restore 0169

		/// <summary>Prompt for and request authentication from the end-user.</summary>
		/// <returns>the authentication data; null if the user canceled the request
		///         and does not want to continue.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='CachedAuthenticator']/method[@name='promptPasswordAuthentication' and count(parameter)=0]"
		[Register ("promptPasswordAuthentication", "()Ljava/net/PasswordAuthentication;", "GetPromptPasswordAuthenticationHandler")]
		protected abstract global::Java.Net.PasswordAuthentication PromptPasswordAuthentication ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/util/CachedAuthenticator", DoNotGenerateAcw=true)]
	internal partial class CachedAuthenticatorInvoker : CachedAuthenticator {
		public CachedAuthenticatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/CachedAuthenticator", typeof (CachedAuthenticatorInvoker));

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

		/// <summary>Prompt for and request authentication from the end-user.</summary>
		/// <returns>the authentication data; null if the user canceled the request
		///         and does not want to continue.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='CachedAuthenticator']/method[@name='promptPasswordAuthentication' and count(parameter)=0]"
		[Register ("promptPasswordAuthentication", "()Ljava/net/PasswordAuthentication;", "GetPromptPasswordAuthenticationHandler")]
		protected override unsafe global::Java.Net.PasswordAuthentication PromptPasswordAuthentication ()
		{
			const string __id = "promptPasswordAuthentication.()Ljava/net/PasswordAuthentication;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Net.PasswordAuthentication> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
