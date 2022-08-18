using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Simple .</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRCCredentialsProvider']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/NetRCCredentialsProvider", DoNotGenerateAcw=true)]
	public partial class NetRCCredentialsProvider : global::Org.Eclipse.Jgit.Transport.CredentialsProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/NetRCCredentialsProvider", typeof (NetRCCredentialsProvider));

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

		protected NetRCCredentialsProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRCCredentialsProvider']/constructor[@name='NetRCCredentialsProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetRCCredentialsProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isInteractive;
#pragma warning disable 0169
		static Delegate GetIsInteractiveHandler ()
		{
			if (cb_isInteractive == null)
				cb_isInteractive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInteractive);
			return cb_isInteractive;
		}

		static bool n_IsInteractive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.NetRCCredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInteractive;
		}
#pragma warning restore 0169

		public override unsafe bool IsInteractive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRCCredentialsProvider']/method[@name='isInteractive' and count(parameter)=0]"
			[Register ("isInteractive", "()Z", "GetIsInteractiveHandler")]
			get {
				const string __id = "isInteractive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_get_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_;
#pragma warning disable 0169
		static Delegate GetGet_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_Handler ()
		{
			if (cb_get_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_ == null)
				cb_get_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_Get_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_);
			return cb_get_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_;
		}

		static bool n_Get_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_items)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.NetRCCredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			var items = (global::Org.Eclipse.Jgit.Transport.CredentialItem[]) JNIEnv.GetArray (native_items, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Transport.CredentialItem));
			bool __ret = __this.Get (uri, items);
			if (items != null)
				JNIEnv.CopyArray (items, native_items);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRCCredentialsProvider']/method[@name='get' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.transport.CredentialItem...']]"
		[Register ("get", "(Lorg/eclipse/jgit/transport/URIish;[Lorg/eclipse/jgit/transport/CredentialItem;)Z", "GetGet_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_Handler")]
		public override unsafe bool Get (global::Org.Eclipse.Jgit.Transport.URIish uri, params global::Org.Eclipse.Jgit.Transport.CredentialItem[] items)
		{
			const string __id = "get.(Lorg/eclipse/jgit/transport/URIish;[Lorg/eclipse/jgit/transport/CredentialItem;)Z";
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_items);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (items);
			}
		}

		/// <summary>Install default provider for the .</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRCCredentialsProvider']/method[@name='install' and count(parameter)=0]"
		[Register ("install", "()V", "")]
		public static unsafe void Install ()
		{
			const string __id = "install.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_supports_arrayLorg_eclipse_jgit_transport_CredentialItem_;
#pragma warning disable 0169
		static Delegate GetSupports_arrayLorg_eclipse_jgit_transport_CredentialItem_Handler ()
		{
			if (cb_supports_arrayLorg_eclipse_jgit_transport_CredentialItem_ == null)
				cb_supports_arrayLorg_eclipse_jgit_transport_CredentialItem_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Supports_arrayLorg_eclipse_jgit_transport_CredentialItem_);
			return cb_supports_arrayLorg_eclipse_jgit_transport_CredentialItem_;
		}

		static bool n_Supports_arrayLorg_eclipse_jgit_transport_CredentialItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_items)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.NetRCCredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var items = (global::Org.Eclipse.Jgit.Transport.CredentialItem[]) JNIEnv.GetArray (native_items, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Transport.CredentialItem));
			bool __ret = __this.Supports (items);
			if (items != null)
				JNIEnv.CopyArray (items, native_items);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRCCredentialsProvider']/method[@name='supports' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.CredentialItem...']]"
		[Register ("supports", "([Lorg/eclipse/jgit/transport/CredentialItem;)Z", "GetSupports_arrayLorg_eclipse_jgit_transport_CredentialItem_Handler")]
		public override unsafe bool Supports (params global::Org.Eclipse.Jgit.Transport.CredentialItem[] items)
		{
			const string __id = "supports.([Lorg/eclipse/jgit/transport/CredentialItem;)Z";
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_items);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
				global::System.GC.KeepAlive (items);
			}
		}

	}
}
