using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>A credentials provider chaining multiple credentials providers</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ChainingCredentialsProvider']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/ChainingCredentialsProvider", DoNotGenerateAcw=true)]
	public partial class ChainingCredentialsProvider : global::Org.Eclipse.Jgit.Transport.CredentialsProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/ChainingCredentialsProvider", typeof (ChainingCredentialsProvider));

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

		protected ChainingCredentialsProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ChainingCredentialsProvider']/constructor[@name='ChainingCredentialsProvider' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.CredentialsProvider...']]"
		[Register (".ctor", "([Lorg/eclipse/jgit/transport/CredentialsProvider;)V", "")]
		public unsafe ChainingCredentialsProvider (params global::Org.Eclipse.Jgit.Transport.CredentialsProvider[] providers) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lorg/eclipse/jgit/transport/CredentialsProvider;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_providers = JNIEnv.NewArray (providers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_providers);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (providers != null) {
					JNIEnv.CopyArray (native_providers, providers);
					JNIEnv.DeleteLocalRef (native_providers);
				}
				global::System.GC.KeepAlive (providers);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ChainingCredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInteractive;
		}
#pragma warning restore 0169

		/// <returns>
		///   <c>true</c> if any of the credential providers in the list is
		///         interactive, otherwise <c>false</c></returns>
		public override unsafe bool IsInteractive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ChainingCredentialsProvider']/method[@name='isInteractive' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ChainingCredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			var items = (global::Org.Eclipse.Jgit.Transport.CredentialItem[]) JNIEnv.GetArray (native_items, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Transport.CredentialItem));
			bool __ret = __this.Get (uri, items);
			if (items != null)
				JNIEnv.CopyArray (items, native_items);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ChainingCredentialsProvider']/method[@name='get' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.transport.CredentialItem...']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ChainingCredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var items = (global::Org.Eclipse.Jgit.Transport.CredentialItem[]) JNIEnv.GetArray (native_items, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Transport.CredentialItem));
			bool __ret = __this.Supports (items);
			if (items != null)
				JNIEnv.CopyArray (items, native_items);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ChainingCredentialsProvider']/method[@name='supports' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.CredentialItem...']]"
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
