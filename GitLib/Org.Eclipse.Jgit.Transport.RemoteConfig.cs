using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>A remembered remote repository, including URLs and RefSpecs.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/RemoteConfig", DoNotGenerateAcw=true)]
	public partial class RemoteConfig : global::Java.Lang.Object, global::Java.IO.ISerializable {
		/// <summary>Default value for <c>#getReceivePack()</c> if not specified.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/field[@name='DEFAULT_RECEIVE_PACK']"
		[Register ("DEFAULT_RECEIVE_PACK")]
		public const string DefaultReceivePack = (string) "git-receive-pack";

		/// <summary>Default value for <c>#getUploadPack()</c> if not specified.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/field[@name='DEFAULT_UPLOAD_PACK']"
		[Register ("DEFAULT_UPLOAD_PACK")]
		public const string DefaultUploadPack = (string) "git-upload-pack";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RemoteConfig", typeof (RemoteConfig));

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

		protected RemoteConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="rc">the existing configuration to get the remote settings from.
		///            The configuration must already be loaded into memory.</param>
		/// <param name="remoteName">subsection key indicating the name of this remote.</param>
		/// <summary>Parse a remote block from an existing configuration file.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/constructor[@name='RemoteConfig' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Config;Ljava/lang/String;)V", "")]
		public unsafe RemoteConfig (global::Org.Eclipse.Jgit.Lib.Config rc, string remoteName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Config;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_remoteName = JNIEnv.NewString ((string)remoteName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rc).Handle);
				__args [1] = new JniArgumentValue (native_remoteName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_remoteName);
				global::System.GC.KeepAlive (rc);
			}
		}

		static Delegate cb_getFetchRefSpecs;
#pragma warning disable 0169
		static Delegate GetGetFetchRefSpecsHandler ()
		{
			if (cb_getFetchRefSpecs == null)
				cb_getFetchRefSpecs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFetchRefSpecs);
			return cb_getFetchRefSpecs;
		}

		static IntPtr n_GetFetchRefSpecs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (__this.FetchRefSpecs);
		}
#pragma warning restore 0169

		static Delegate cb_setFetchRefSpecs_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetFetchRefSpecs_Ljava_util_List_Handler ()
		{
			if (cb_setFetchRefSpecs_Ljava_util_List_ == null)
				cb_setFetchRefSpecs_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFetchRefSpecs_Ljava_util_List_);
			return cb_setFetchRefSpecs_Ljava_util_List_;
		}

		static void n_SetFetchRefSpecs_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_specs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var specs = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.FromJniHandle (native_specs, JniHandleOwnership.DoNotTransfer);
			__this.FetchRefSpecs = specs;
		}
#pragma warning restore 0169

		/// <summary>Remembered specifications for fetching from a repository. -or- Override existing fetch specifications with new ones.</summary>
		/// <returns>set of specs used by default when fetching.</returns>
		/// <param name="specs">list of fetch specifications to set. List is copied, it can be
		///            modified after this call.</param>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.RefSpec> FetchRefSpecs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getFetchRefSpecs' and count(parameter)=0]"
			[Register ("getFetchRefSpecs", "()Ljava/util/List;", "GetGetFetchRefSpecsHandler")]
			get {
				const string __id = "getFetchRefSpecs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='setFetchRefSpecs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.transport.RefSpec&gt;']]"
			[Register ("setFetchRefSpecs", "(Ljava/util/List;)V", "GetSetFetchRefSpecs_Ljava_util_List_Handler")]
			set {
				const string __id = "setFetchRefSpecs.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isMirror;
#pragma warning disable 0169
		static Delegate GetIsMirrorHandler ()
		{
			if (cb_isMirror == null)
				cb_isMirror = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMirror);
			return cb_isMirror;
		}

		static bool n_IsMirror (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mirror;
		}
#pragma warning restore 0169

		static Delegate cb_setMirror_Z;
#pragma warning disable 0169
		static Delegate GetSetMirror_ZHandler ()
		{
			if (cb_setMirror_Z == null)
				cb_setMirror_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMirror_Z);
			return cb_setMirror_Z;
		}

		static void n_SetMirror_Z (IntPtr jnienv, IntPtr native__this, bool m)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mirror = m;
		}
#pragma warning restore 0169

		/// <returns>true if pushing to the remote automatically deletes remote refs
		///         which don't exist on the source side.</returns>
		/// <summary>Set the mirror flag to automatically delete remote refs.</summary>
		/// <param name="m">true to automatically delete remote refs during push.</param>
		public virtual unsafe bool Mirror {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='isMirror' and count(parameter)=0]"
			[Register ("isMirror", "()Z", "GetIsMirrorHandler")]
			get {
				const string __id = "isMirror.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='setMirror' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMirror", "(Z)V", "GetSetMirror_ZHandler")]
			set {
				const string __id = "setMirror.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		/// <summary>Get the local name this remote configuration is recognized as.</summary>
		/// <returns>name assigned by the user to this configuration block.</returns>
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_getPushRefSpecs;
#pragma warning disable 0169
		static Delegate GetGetPushRefSpecsHandler ()
		{
			if (cb_getPushRefSpecs == null)
				cb_getPushRefSpecs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPushRefSpecs);
			return cb_getPushRefSpecs;
		}

		static IntPtr n_GetPushRefSpecs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (__this.PushRefSpecs);
		}
#pragma warning restore 0169

		static Delegate cb_setPushRefSpecs_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPushRefSpecs_Ljava_util_List_Handler ()
		{
			if (cb_setPushRefSpecs_Ljava_util_List_ == null)
				cb_setPushRefSpecs_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPushRefSpecs_Ljava_util_List_);
			return cb_setPushRefSpecs_Ljava_util_List_;
		}

		static void n_SetPushRefSpecs_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_specs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var specs = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.FromJniHandle (native_specs, JniHandleOwnership.DoNotTransfer);
			__this.PushRefSpecs = specs;
		}
#pragma warning restore 0169

		/// <summary>Remembered specifications for pushing to a repository. -or- Override existing push specifications with new ones.</summary>
		/// <returns>set of specs used by default when pushing.</returns>
		/// <param name="specs">list of push specifications to set. List is copied, it can be
		///            modified after this call.</param>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.RefSpec> PushRefSpecs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getPushRefSpecs' and count(parameter)=0]"
			[Register ("getPushRefSpecs", "()Ljava/util/List;", "GetGetPushRefSpecsHandler")]
			get {
				const string __id = "getPushRefSpecs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='setPushRefSpecs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.transport.RefSpec&gt;']]"
			[Register ("setPushRefSpecs", "(Ljava/util/List;)V", "GetSetPushRefSpecs_Ljava_util_List_Handler")]
			set {
				const string __id = "setPushRefSpecs.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getPushURIs;
#pragma warning disable 0169
		static Delegate GetGetPushURIsHandler ()
		{
			if (cb_getPushURIs == null)
				cb_getPushURIs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPushURIs);
			return cb_getPushURIs;
		}

		static IntPtr n_GetPushURIs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.URIish>.ToLocalJniHandle (__this.PushURIs);
		}
#pragma warning restore 0169

		/// <summary>Get all configured push-only URIs under this remote.</summary>
		/// <returns>the set of URIs known to this remote.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.URIish> PushURIs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getPushURIs' and count(parameter)=0]"
			[Register ("getPushURIs", "()Ljava/util/List;", "GetGetPushURIsHandler")]
			get {
				const string __id = "getPushURIs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.URIish>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReceivePack;
#pragma warning disable 0169
		static Delegate GetGetReceivePackHandler ()
		{
			if (cb_getReceivePack == null)
				cb_getReceivePack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReceivePack);
			return cb_getReceivePack;
		}

		static IntPtr n_GetReceivePack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReceivePack);
		}
#pragma warning restore 0169

		/// <summary>Override for the location of 'git-receive-pack' on the remote system.</summary>
		/// <returns>location of 'git-receive-pack' on the remote system. If no
		///         location has been configured the default of 'git-receive-pack' is
		///         returned instead.</returns>
		public virtual unsafe string ReceivePack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getReceivePack' and count(parameter)=0]"
			[Register ("getReceivePack", "()Ljava/lang/String;", "GetGetReceivePackHandler")]
			get {
				const string __id = "getReceivePack.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTagOpt;
#pragma warning disable 0169
		static Delegate GetGetTagOptHandler ()
		{
			if (cb_getTagOpt == null)
				cb_getTagOpt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTagOpt);
			return cb_getTagOpt;
		}

		static IntPtr n_GetTagOpt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TagOpt);
		}
#pragma warning restore 0169

		static Delegate cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_;
#pragma warning disable 0169
		static Delegate GetSetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_Handler ()
		{
			if (cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_ == null)
				cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_);
			return cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_;
		}

		static void n_SetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_option)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var option = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (native_option, JniHandleOwnership.DoNotTransfer);
			__this.TagOpt = option;
		}
#pragma warning restore 0169

		/// <summary>Get the description of how annotated tags should be treated during fetch. -or- Set the description of how annotated tags should be treated on fetch.</summary>
		/// <returns>option indicating the behavior of annotated tags in fetch.</returns>
		/// <param name="option">method to use when handling annotated tags.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.TagOpt TagOpt {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getTagOpt' and count(parameter)=0]"
			[Register ("getTagOpt", "()Lorg/eclipse/jgit/transport/TagOpt;", "GetGetTagOptHandler")]
			get {
				const string __id = "getTagOpt.()Lorg/eclipse/jgit/transport/TagOpt;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='setTagOpt' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.TagOpt']]"
			[Register ("setTagOpt", "(Lorg/eclipse/jgit/transport/TagOpt;)V", "GetSetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_Handler")]
			set {
				const string __id = "setTagOpt.(Lorg/eclipse/jgit/transport/TagOpt;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int seconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = seconds;
		}
#pragma warning restore 0169

		/// <returns>timeout (in seconds) before aborting an IO operation.</returns>
		/// <summary>Set the timeout before willing to abort an IO call.</summary>
		/// <param name="seconds">number of seconds to wait (with no data transfer occurring)
		///            before aborting an IO read or write operation with this
		///            remote.  A timeout of 0 will block indefinitely.</param>
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				const string __id = "getTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
			set {
				const string __id = "setTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getURIs;
#pragma warning disable 0169
		static Delegate GetGetURIsHandler ()
		{
			if (cb_getURIs == null)
				cb_getURIs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetURIs);
			return cb_getURIs;
		}

		static IntPtr n_GetURIs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.URIish>.ToLocalJniHandle (__this.URIs);
		}
#pragma warning restore 0169

		/// <summary>Get all configured URIs under this remote.</summary>
		/// <returns>the set of URIs known to this remote.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.URIish> URIs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getURIs' and count(parameter)=0]"
			[Register ("getURIs", "()Ljava/util/List;", "GetGetURIsHandler")]
			get {
				const string __id = "getURIs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.URIish>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUploadPack;
#pragma warning disable 0169
		static Delegate GetGetUploadPackHandler ()
		{
			if (cb_getUploadPack == null)
				cb_getUploadPack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUploadPack);
			return cb_getUploadPack;
		}

		static IntPtr n_GetUploadPack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UploadPack);
		}
#pragma warning restore 0169

		/// <summary>Override for the location of 'git-upload-pack' on the remote system.</summary>
		/// <returns>location of 'git-upload-pack' on the remote system. If no
		///         location has been configured the default of 'git-upload-pack' is
		///         returned instead.</returns>
		public virtual unsafe string UploadPack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getUploadPack' and count(parameter)=0]"
			[Register ("getUploadPack", "()Ljava/lang/String;", "GetGetUploadPackHandler")]
			get {
				const string __id = "getUploadPack.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_;
#pragma warning disable 0169
		static Delegate GetAddFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_Handler ()
		{
			if (cb_addFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ == null)
				cb_addFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AddFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_);
			return cb_addFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_;
		}

		static bool n_AddFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (native_s, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddFetchRefSpec (s);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="s">the new specification to add.</param>
		/// <summary>Add a new fetch RefSpec to this remote.</summary>
		/// <returns>true if the specification was added; false if it already exists.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='addFetchRefSpec' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefSpec']]"
		[Register ("addFetchRefSpec", "(Lorg/eclipse/jgit/transport/RefSpec;)Z", "GetAddFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_Handler")]
		public virtual unsafe bool AddFetchRefSpec (global::Org.Eclipse.Jgit.Transport.RefSpec s)
		{
			const string __id = "addFetchRefSpec.(Lorg/eclipse/jgit/transport/RefSpec;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_addPushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_;
#pragma warning disable 0169
		static Delegate GetAddPushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_Handler ()
		{
			if (cb_addPushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ == null)
				cb_addPushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AddPushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_);
			return cb_addPushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_;
		}

		static bool n_AddPushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (native_s, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPushRefSpec (s);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="s">the new specification to add.</param>
		/// <summary>Add a new push RefSpec to this remote.</summary>
		/// <returns>true if the specification was added; false if it already exists.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='addPushRefSpec' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefSpec']]"
		[Register ("addPushRefSpec", "(Lorg/eclipse/jgit/transport/RefSpec;)Z", "GetAddPushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_Handler")]
		public virtual unsafe bool AddPushRefSpec (global::Org.Eclipse.Jgit.Transport.RefSpec s)
		{
			const string __id = "addPushRefSpec.(Lorg/eclipse/jgit/transport/RefSpec;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_addPushURI_Lorg_eclipse_jgit_transport_URIish_;
#pragma warning disable 0169
		static Delegate GetAddPushURI_Lorg_eclipse_jgit_transport_URIish_Handler ()
		{
			if (cb_addPushURI_Lorg_eclipse_jgit_transport_URIish_ == null)
				cb_addPushURI_Lorg_eclipse_jgit_transport_URIish_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AddPushURI_Lorg_eclipse_jgit_transport_URIish_);
			return cb_addPushURI_Lorg_eclipse_jgit_transport_URIish_;
		}

		static bool n_AddPushURI_Lorg_eclipse_jgit_transport_URIish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_toAdd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var toAdd = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_toAdd, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPushURI (toAdd);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="toAdd">the new URI to add to this remote.</param>
		/// <summary>Add a new push-only URI to the end of the list of URIs.</summary>
		/// <returns>true if the URI was added; false if it already exists.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='addPushURI' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register ("addPushURI", "(Lorg/eclipse/jgit/transport/URIish;)Z", "GetAddPushURI_Lorg_eclipse_jgit_transport_URIish_Handler")]
		public virtual unsafe bool AddPushURI (global::Org.Eclipse.Jgit.Transport.URIish toAdd)
		{
			const string __id = "addPushURI.(Lorg/eclipse/jgit/transport/URIish;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((toAdd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toAdd).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (toAdd);
			}
		}

		static Delegate cb_addURI_Lorg_eclipse_jgit_transport_URIish_;
#pragma warning disable 0169
		static Delegate GetAddURI_Lorg_eclipse_jgit_transport_URIish_Handler ()
		{
			if (cb_addURI_Lorg_eclipse_jgit_transport_URIish_ == null)
				cb_addURI_Lorg_eclipse_jgit_transport_URIish_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AddURI_Lorg_eclipse_jgit_transport_URIish_);
			return cb_addURI_Lorg_eclipse_jgit_transport_URIish_;
		}

		static bool n_AddURI_Lorg_eclipse_jgit_transport_URIish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_toAdd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var toAdd = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_toAdd, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddURI (toAdd);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="toAdd">the new URI to add to this remote.</param>
		/// <summary>Add a new URI to the end of the list of URIs.</summary>
		/// <returns>true if the URI was added; false if it already exists.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='addURI' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register ("addURI", "(Lorg/eclipse/jgit/transport/URIish;)Z", "GetAddURI_Lorg_eclipse_jgit_transport_URIish_Handler")]
		public virtual unsafe bool AddURI (global::Org.Eclipse.Jgit.Transport.URIish toAdd)
		{
			const string __id = "addURI.(Lorg/eclipse/jgit/transport/URIish;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((toAdd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toAdd).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (toAdd);
			}
		}

		/// <param name="rc">the existing configuration to get the remote settings from.
		///            The configuration must already be loaded into memory.</param>
		/// <summary>Parse all remote blocks in an existing configuration file, looking for
		/// remotes configuration.</summary>
		/// <returns>all remotes configurations existing in provided repository
		///         configuration. Returned configurations are ordered
		///         lexicographically by names.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='getAllRemoteConfigs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
		[Register ("getAllRemoteConfigs", "(Lorg/eclipse/jgit/lib/Config;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.RemoteConfig> GetAllRemoteConfigs (global::Org.Eclipse.Jgit.Lib.Config rc)
		{
			const string __id = "getAllRemoteConfigs.(Lorg/eclipse/jgit/lib/Config;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rc).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RemoteConfig>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (rc);
			}
		}

		static Delegate cb_removeFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_;
#pragma warning disable 0169
		static Delegate GetRemoveFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_Handler ()
		{
			if (cb_removeFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ == null)
				cb_removeFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_);
			return cb_removeFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_;
		}

		static bool n_RemoveFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (native_s, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFetchRefSpec (s);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="s">the specification to remove.</param>
		/// <summary>Remove a fetch RefSpec from this remote.</summary>
		/// <returns>true if the specification existed and was removed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='removeFetchRefSpec' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefSpec']]"
		[Register ("removeFetchRefSpec", "(Lorg/eclipse/jgit/transport/RefSpec;)Z", "GetRemoveFetchRefSpec_Lorg_eclipse_jgit_transport_RefSpec_Handler")]
		public virtual unsafe bool RemoveFetchRefSpec (global::Org.Eclipse.Jgit.Transport.RefSpec s)
		{
			const string __id = "removeFetchRefSpec.(Lorg/eclipse/jgit/transport/RefSpec;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_removePushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_;
#pragma warning disable 0169
		static Delegate GetRemovePushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_Handler ()
		{
			if (cb_removePushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ == null)
				cb_removePushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemovePushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_);
			return cb_removePushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_;
		}

		static bool n_RemovePushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (native_s, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemovePushRefSpec (s);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="s">the specification to remove.</param>
		/// <summary>Remove a push RefSpec from this remote.</summary>
		/// <returns>true if the specification existed and was removed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='removePushRefSpec' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefSpec']]"
		[Register ("removePushRefSpec", "(Lorg/eclipse/jgit/transport/RefSpec;)Z", "GetRemovePushRefSpec_Lorg_eclipse_jgit_transport_RefSpec_Handler")]
		public virtual unsafe bool RemovePushRefSpec (global::Org.Eclipse.Jgit.Transport.RefSpec s)
		{
			const string __id = "removePushRefSpec.(Lorg/eclipse/jgit/transport/RefSpec;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_removePushURI_Lorg_eclipse_jgit_transport_URIish_;
#pragma warning disable 0169
		static Delegate GetRemovePushURI_Lorg_eclipse_jgit_transport_URIish_Handler ()
		{
			if (cb_removePushURI_Lorg_eclipse_jgit_transport_URIish_ == null)
				cb_removePushURI_Lorg_eclipse_jgit_transport_URIish_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemovePushURI_Lorg_eclipse_jgit_transport_URIish_);
			return cb_removePushURI_Lorg_eclipse_jgit_transport_URIish_;
		}

		static bool n_RemovePushURI_Lorg_eclipse_jgit_transport_URIish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_toRemove)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var toRemove = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_toRemove, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemovePushURI (toRemove);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="toRemove">the URI to remove from this remote.</param>
		/// <summary>Remove a push-only URI from the list of URIs.</summary>
		/// <returns>true if the URI was added; false if it already exists.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='removePushURI' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register ("removePushURI", "(Lorg/eclipse/jgit/transport/URIish;)Z", "GetRemovePushURI_Lorg_eclipse_jgit_transport_URIish_Handler")]
		public virtual unsafe bool RemovePushURI (global::Org.Eclipse.Jgit.Transport.URIish toRemove)
		{
			const string __id = "removePushURI.(Lorg/eclipse/jgit/transport/URIish;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((toRemove == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toRemove).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (toRemove);
			}
		}

		static Delegate cb_removeURI_Lorg_eclipse_jgit_transport_URIish_;
#pragma warning disable 0169
		static Delegate GetRemoveURI_Lorg_eclipse_jgit_transport_URIish_Handler ()
		{
			if (cb_removeURI_Lorg_eclipse_jgit_transport_URIish_ == null)
				cb_removeURI_Lorg_eclipse_jgit_transport_URIish_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveURI_Lorg_eclipse_jgit_transport_URIish_);
			return cb_removeURI_Lorg_eclipse_jgit_transport_URIish_;
		}

		static bool n_RemoveURI_Lorg_eclipse_jgit_transport_URIish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_toRemove)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var toRemove = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_toRemove, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveURI (toRemove);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="toRemove">the URI to remove from this remote.</param>
		/// <summary>Remove a URI from the list of URIs.</summary>
		/// <returns>true if the URI was added; false if it already exists.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='removeURI' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register ("removeURI", "(Lorg/eclipse/jgit/transport/URIish;)Z", "GetRemoveURI_Lorg_eclipse_jgit_transport_URIish_Handler")]
		public virtual unsafe bool RemoveURI (global::Org.Eclipse.Jgit.Transport.URIish toRemove)
		{
			const string __id = "removeURI.(Lorg/eclipse/jgit/transport/URIish;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((toRemove == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toRemove).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (toRemove);
			}
		}

		static Delegate cb_update_Lorg_eclipse_jgit_lib_Config_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lorg_eclipse_jgit_lib_Config_Handler ()
		{
			if (cb_update_Lorg_eclipse_jgit_lib_Config_ == null)
				cb_update_Lorg_eclipse_jgit_lib_Config_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_Lorg_eclipse_jgit_lib_Config_);
			return cb_update_Lorg_eclipse_jgit_lib_Config_;
		}

		static void n_Update_Lorg_eclipse_jgit_lib_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (native_rc, JniHandleOwnership.DoNotTransfer);
			__this.Update (rc);
		}
#pragma warning restore 0169

		/// <param name="rc">the configuration file to store ourselves into.</param>
		/// <summary>Update this remote's definition within the configuration.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteConfig']/method[@name='update' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
		[Register ("update", "(Lorg/eclipse/jgit/lib/Config;)V", "GetUpdate_Lorg_eclipse_jgit_lib_Config_Handler")]
		public virtual unsafe void Update (global::Org.Eclipse.Jgit.Lib.Config rc)
		{
			const string __id = "update.(Lorg/eclipse/jgit/lib/Config;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rc).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rc);
			}
		}

	}
}
