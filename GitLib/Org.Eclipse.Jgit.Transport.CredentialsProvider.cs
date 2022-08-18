using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Provide credentials for use in connecting to Git repositories.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialsProvider", DoNotGenerateAcw=true)]
	public abstract partial class CredentialsProvider : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialsProvider", typeof (CredentialsProvider));

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

		protected CredentialsProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/constructor[@name='CredentialsProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CredentialsProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <returns>the default credentials provider, or null.</returns>
		/// <summary>Set the default credentials provider.</summary>
		/// <param name="p">the new default provider, may be null to select no default.</param>
		public static unsafe global::Org.Eclipse.Jgit.Transport.CredentialsProvider Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Lorg/eclipse/jgit/transport/CredentialsProvider;", "")]
			get {
				const string __id = "getDefault.()Lorg/eclipse/jgit/transport/CredentialsProvider;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='setDefault' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.CredentialsProvider']]"
			[Register ("setDefault", "(Lorg/eclipse/jgit/transport/CredentialsProvider;)V", "")]
			set {
				const string __id = "setDefault.(Lorg/eclipse/jgit/transport/CredentialsProvider;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInteractive;
		}
#pragma warning restore 0169

		public abstract bool IsInteractive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='isInteractive' and count(parameter)=0]"
			[Register ("isInteractive", "()Z", "GetIsInteractiveHandler")]
			get; 
		}

		static Delegate cb_get_Lorg_eclipse_jgit_transport_URIish_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGet_Lorg_eclipse_jgit_transport_URIish_Ljava_util_List_Handler ()
		{
			if (cb_get_Lorg_eclipse_jgit_transport_URIish_Ljava_util_List_ == null)
				cb_get_Lorg_eclipse_jgit_transport_URIish_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_Get_Lorg_eclipse_jgit_transport_URIish_Ljava_util_List_);
			return cb_get_Lorg_eclipse_jgit_transport_URIish_Ljava_util_List_;
		}

		static bool n_Get_Lorg_eclipse_jgit_transport_URIish_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_items)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			var items = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.CredentialItem>.FromJniHandle (native_items, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Get (uri, items);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uri">the URI of the remote resource that needs authentication.</param>
		/// <param name="items">the items the application requires to complete authentication.</param>
		/// <summary>Ask for the credential items to be populated.</summary>
		/// <returns>
		///   <c>true</c> if the request was successful and values were
		///         supplied; <c>false</c> if the user canceled the request and did
		///         not supply all requested values.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='get' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.transport.CredentialItem&gt;']]"
		[Register ("get", "(Lorg/eclipse/jgit/transport/URIish;Ljava/util/List;)Z", "GetGet_Lorg_eclipse_jgit_transport_URIish_Ljava_util_List_Handler")]
		public virtual unsafe bool Get (global::Org.Eclipse.Jgit.Transport.URIish uri, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.CredentialItem> items)
		{
			const string __id = "get.(Lorg/eclipse/jgit/transport/URIish;Ljava/util/List;)Z";
			IntPtr native_items = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.CredentialItem>.ToLocalJniHandle (items);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_items);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_items);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (items);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			var items = (global::Org.Eclipse.Jgit.Transport.CredentialItem[]) JNIEnv.GetArray (native_items, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Transport.CredentialItem));
			bool __ret = __this.Get (uri, items);
			if (items != null)
				JNIEnv.CopyArray (items, native_items);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='get' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.transport.CredentialItem...']]"
		[Register ("get", "(Lorg/eclipse/jgit/transport/URIish;[Lorg/eclipse/jgit/transport/CredentialItem;)Z", "GetGet_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_Handler")]
		public abstract bool Get (global::Org.Eclipse.Jgit.Transport.URIish uri, params global::Org.Eclipse.Jgit.Transport.CredentialItem[] items);

		static Delegate cb_reset_Lorg_eclipse_jgit_transport_URIish_;
#pragma warning disable 0169
		static Delegate GetReset_Lorg_eclipse_jgit_transport_URIish_Handler ()
		{
			if (cb_reset_Lorg_eclipse_jgit_transport_URIish_ == null)
				cb_reset_Lorg_eclipse_jgit_transport_URIish_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Reset_Lorg_eclipse_jgit_transport_URIish_);
			return cb_reset_Lorg_eclipse_jgit_transport_URIish_;
		}

		static void n_Reset_Lorg_eclipse_jgit_transport_URIish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.Reset (uri);
		}
#pragma warning restore 0169

		/// <param name="uri">uri</param>
		/// <summary>Reset the credentials provider for the given URI</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register ("reset", "(Lorg/eclipse/jgit/transport/URIish;)V", "GetReset_Lorg_eclipse_jgit_transport_URIish_Handler")]
		public virtual unsafe void Reset (global::Org.Eclipse.Jgit.Transport.URIish uri)
		{
			const string __id = "reset.(Lorg/eclipse/jgit/transport/URIish;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (uri);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var items = (global::Org.Eclipse.Jgit.Transport.CredentialItem[]) JNIEnv.GetArray (native_items, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Transport.CredentialItem));
			bool __ret = __this.Supports (items);
			if (items != null)
				JNIEnv.CopyArray (items, native_items);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='supports' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.CredentialItem...']]"
		[Register ("supports", "([Lorg/eclipse/jgit/transport/CredentialItem;)Z", "GetSupports_arrayLorg_eclipse_jgit_transport_CredentialItem_Handler")]
		public abstract bool Supports (params global::Org.Eclipse.Jgit.Transport.CredentialItem[] items);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialsProvider", DoNotGenerateAcw=true)]
	internal partial class CredentialsProviderInvoker : CredentialsProvider {
		public CredentialsProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialsProvider", typeof (CredentialsProviderInvoker));

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

		/// <summary>Check if the provider is interactive with the end-user.</summary>
		/// <returns>
		///   <c>true</c> if the provider is interactive with the end-user.</returns>
		public override unsafe bool IsInteractive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='isInteractive' and count(parameter)=0]"
			[Register ("isInteractive", "()Z", "GetIsInteractiveHandler")]
			get {
				const string __id = "isInteractive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='get' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.transport.CredentialItem...']]"
		[Register ("get", "(Lorg/eclipse/jgit/transport/URIish;[Lorg/eclipse/jgit/transport/CredentialItem;)Z", "GetGet_Lorg_eclipse_jgit_transport_URIish_arrayLorg_eclipse_jgit_transport_CredentialItem_Handler")]
		public override unsafe bool Get (global::Org.Eclipse.Jgit.Transport.URIish uri, params global::Org.Eclipse.Jgit.Transport.CredentialItem[] items)
		{
			const string __id = "get.(Lorg/eclipse/jgit/transport/URIish;[Lorg/eclipse/jgit/transport/CredentialItem;)Z";
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_items);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialsProvider']/method[@name='supports' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.CredentialItem...']]"
		[Register ("supports", "([Lorg/eclipse/jgit/transport/CredentialItem;)Z", "GetSupports_arrayLorg_eclipse_jgit_transport_CredentialItem_Handler")]
		public override unsafe bool Supports (params global::Org.Eclipse.Jgit.Transport.CredentialItem[] items)
		{
			const string __id = "supports.([Lorg/eclipse/jgit/transport/CredentialItem;)Z";
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_items);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
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
