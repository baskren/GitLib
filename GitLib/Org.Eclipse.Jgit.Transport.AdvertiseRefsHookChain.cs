using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>
	///   <c>AdvertiseRefsHook</c> that delegates to a list of other hooks.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AdvertiseRefsHookChain']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/AdvertiseRefsHookChain", DoNotGenerateAcw=true)]
	public partial class AdvertiseRefsHookChain : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook {
		public static class InterfaceConsts {
			// The following are fields from: org.eclipse.jgit.transport.AdvertiseRefsHook


			/// <summary>A simple hook that advertises the default refs.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='AdvertiseRefsHook']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook Default {
				get {
					const string __id = "DEFAULT.Lorg/eclipse/jgit/transport/AdvertiseRefsHook;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/AdvertiseRefsHookChain", typeof (AdvertiseRefsHookChain));

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

		protected AdvertiseRefsHookChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_;
#pragma warning disable 0169
		static Delegate GetAdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_Handler ()
		{
			if (cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ == null)
				cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_);
			return cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_;
		}

		static void n_AdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AdvertiseRefsHookChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (native_rp, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseRefs (rp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AdvertiseRefsHookChain']/method[@name='advertiseRefs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.BaseReceivePack']]"
		[Register ("advertiseRefs", "(Lorg/eclipse/jgit/transport/BaseReceivePack;)V", "GetAdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_Handler")]
		public virtual unsafe void AdvertiseRefs (global::Org.Eclipse.Jgit.Transport.BaseReceivePack rp)
		{
			const string __id = "advertiseRefs.(Lorg/eclipse/jgit/transport/BaseReceivePack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rp);
			}
		}

		static Delegate cb_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_;
#pragma warning disable 0169
		static Delegate GetAdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_Handler ()
		{
			if (cb_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_ == null)
				cb_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_);
			return cb_advertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_;
		}

		static void n_AdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AdvertiseRefsHookChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_rp, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseRefs (rp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AdvertiseRefsHookChain']/method[@name='advertiseRefs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack']]"
		[Register ("advertiseRefs", "(Lorg/eclipse/jgit/transport/UploadPack;)V", "GetAdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_Handler")]
		public virtual unsafe void AdvertiseRefs (global::Org.Eclipse.Jgit.Transport.UploadPack rp)
		{
			const string __id = "advertiseRefs.(Lorg/eclipse/jgit/transport/UploadPack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rp);
			}
		}

		/// <param name="hooks">hooks to execute, in order.</param>
		/// <summary>Create a new hook chaining the given hooks together.</summary>
		/// <returns>a new hook chain of the given hooks.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AdvertiseRefsHookChain']/method[@name='newChain' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends org.eclipse.jgit.transport.AdvertiseRefsHook&gt;']]"
		[Register ("newChain", "(Ljava/util/List;)Lorg/eclipse/jgit/transport/AdvertiseRefsHook;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook NewChain (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> hooks)
		{
			const string __id = "newChain.(Ljava/util/List;)Lorg/eclipse/jgit/transport/AdvertiseRefsHook;";
			IntPtr native_hooks = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook>.ToLocalJniHandle (hooks);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hooks);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hooks);
				global::System.GC.KeepAlive (hooks);
			}
		}

	}
}
