using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Implementation of <c>AdvertiseRefsHook</c> that advertises the same refs for
	/// upload-pack and receive-pack.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AbstractAdvertiseRefsHook']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/AbstractAdvertiseRefsHook", DoNotGenerateAcw=true)]
	public abstract partial class AbstractAdvertiseRefsHook : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook {
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/AbstractAdvertiseRefsHook", typeof (AbstractAdvertiseRefsHook));

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

		protected AbstractAdvertiseRefsHook (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AbstractAdvertiseRefsHook']/constructor[@name='AbstractAdvertiseRefsHook' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractAdvertiseRefsHook () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_;
#pragma warning disable 0169
		static Delegate GetAdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_Handler ()
		{
			if (cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ == null)
				cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_);
			return cb_advertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_;
		}

		static void n_AdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receivePack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AbstractAdvertiseRefsHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var receivePack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (native_receivePack, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseRefs (receivePack);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AbstractAdvertiseRefsHook']/method[@name='advertiseRefs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.BaseReceivePack']]"
		[Register ("advertiseRefs", "(Lorg/eclipse/jgit/transport/BaseReceivePack;)V", "GetAdvertiseRefs_Lorg_eclipse_jgit_transport_BaseReceivePack_Handler")]
		public virtual unsafe void AdvertiseRefs (global::Org.Eclipse.Jgit.Transport.BaseReceivePack receivePack)
		{
			const string __id = "advertiseRefs.(Lorg/eclipse/jgit/transport/BaseReceivePack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((receivePack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receivePack).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (receivePack);
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

		static void n_AdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uploadPack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AbstractAdvertiseRefsHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uploadPack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_uploadPack, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseRefs (uploadPack);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AbstractAdvertiseRefsHook']/method[@name='advertiseRefs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack']]"
		[Register ("advertiseRefs", "(Lorg/eclipse/jgit/transport/UploadPack;)V", "GetAdvertiseRefs_Lorg_eclipse_jgit_transport_UploadPack_Handler")]
		public virtual unsafe void AdvertiseRefs (global::Org.Eclipse.Jgit.Transport.UploadPack uploadPack)
		{
			const string __id = "advertiseRefs.(Lorg/eclipse/jgit/transport/UploadPack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uploadPack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uploadPack).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (uploadPack);
			}
		}

		static Delegate cb_getAdvertisedHaves_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_;
#pragma warning disable 0169
		static Delegate GetGetAdvertisedHaves_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_Handler ()
		{
			if (cb_getAdvertisedHaves_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_ == null)
				cb_getAdvertisedHaves_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetAdvertisedHaves_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_);
			return cb_getAdvertisedHaves_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_;
		}

		static IntPtr n_GetAdvertisedHaves_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repository, IntPtr native_revWalk)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AbstractAdvertiseRefsHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var repository = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repository, JniHandleOwnership.DoNotTransfer);
			var revWalk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_revWalk, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.GetAdvertisedHaves (repository, revWalk));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="repository">repository instance.</param>
		/// <param name="revWalk">open rev walk on the repository.</param>
		/// <summary>Get the additional haves to advertise.</summary>
		/// <returns>set of additional haves; see
		///         <c>ReceivePack#getAdvertisedObjects()</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AbstractAdvertiseRefsHook']/method[@name='getAdvertisedHaves' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevWalk']]"
		[Register ("getAdvertisedHaves", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/revwalk/RevWalk;)Ljava/util/Set;", "GetGetAdvertisedHaves_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_Handler")]
		protected virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> GetAdvertisedHaves (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Revwalk.RevWalk revWalk)
		{
			const string __id = "getAdvertisedHaves.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/revwalk/RevWalk;)Ljava/util/Set;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((revWalk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) revWalk).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (revWalk);
			}
		}

		static Delegate cb_getAdvertisedRefs_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_;
#pragma warning disable 0169
		static Delegate GetGetAdvertisedRefs_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_Handler ()
		{
			if (cb_getAdvertisedRefs_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_ == null)
				cb_getAdvertisedRefs_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetAdvertisedRefs_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_);
			return cb_getAdvertisedRefs_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_;
		}

		static IntPtr n_GetAdvertisedRefs_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repository, IntPtr native_revWalk)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.AbstractAdvertiseRefsHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var repository = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repository, JniHandleOwnership.DoNotTransfer);
			var revWalk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_revWalk, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.GetAdvertisedRefs (repository, revWalk));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="repository">repository instance.</param>
		/// <param name="revWalk">open rev walk on the repository.</param>
		/// <summary>Get the refs to advertise.</summary>
		/// <returns>set of refs to advertise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AbstractAdvertiseRefsHook']/method[@name='getAdvertisedRefs' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevWalk']]"
		[Register ("getAdvertisedRefs", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/revwalk/RevWalk;)Ljava/util/Map;", "GetGetAdvertisedRefs_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_Handler")]
		protected abstract global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> GetAdvertisedRefs (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Revwalk.RevWalk revWalk);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/AbstractAdvertiseRefsHook", DoNotGenerateAcw=true)]
	internal partial class AbstractAdvertiseRefsHookInvoker : AbstractAdvertiseRefsHook {
		public AbstractAdvertiseRefsHookInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/AbstractAdvertiseRefsHook", typeof (AbstractAdvertiseRefsHookInvoker));

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

		/// <param name="repository">repository instance.</param>
		/// <param name="revWalk">open rev walk on the repository.</param>
		/// <summary>Get the refs to advertise.</summary>
		/// <returns>set of refs to advertise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='AbstractAdvertiseRefsHook']/method[@name='getAdvertisedRefs' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevWalk']]"
		[Register ("getAdvertisedRefs", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/revwalk/RevWalk;)Ljava/util/Map;", "GetGetAdvertisedRefs_Lorg_eclipse_jgit_lib_Repository_Lorg_eclipse_jgit_revwalk_RevWalk_Handler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> GetAdvertisedRefs (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Revwalk.RevWalk revWalk)
		{
			const string __id = "getAdvertisedRefs.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/revwalk/RevWalk;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((revWalk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) revWalk).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (revWalk);
			}
		}

	}
}
