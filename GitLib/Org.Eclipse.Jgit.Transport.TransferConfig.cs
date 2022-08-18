using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>The standard "transfer", "fetch", "receive", and "uploadpack" configuration
	/// parameters.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransferConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TransferConfig", DoNotGenerateAcw=true)]
	public partial class TransferConfig : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransferConfig']/field[@name='KEY']"
		[Register ("KEY")]
		public static global::Org.Eclipse.Jgit.Lib.Config.ISectionParser Key {
			get {
				const string __id = "KEY.Lorg/eclipse/jgit/lib/Config$SectionParser;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.ISectionParser> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TransferConfig", typeof (TransferConfig));

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

		protected TransferConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_isAllowTipSha1InWant;
#pragma warning disable 0169
		static Delegate GetIsAllowTipSha1InWantHandler ()
		{
			if (cb_isAllowTipSha1InWant == null)
				cb_isAllowTipSha1InWant = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAllowTipSha1InWant);
			return cb_isAllowTipSha1InWant;
		}

		static bool n_IsAllowTipSha1InWant (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransferConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAllowTipSha1InWant;
		}
#pragma warning restore 0169

		/// <returns>allow clients to request non-advertised tip SHA-1s?</returns>
		public virtual unsafe bool IsAllowTipSha1InWant {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransferConfig']/method[@name='isAllowTipSha1InWant' and count(parameter)=0]"
			[Register ("isAllowTipSha1InWant", "()Z", "GetIsAllowTipSha1InWantHandler")]
			get {
				const string __id = "isAllowTipSha1InWant.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isFsckObjects;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsFsckObjectsHandler ()
		{
			if (cb_isFsckObjects == null)
				cb_isFsckObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFsckObjects);
			return cb_isFsckObjects;
		}

		[Obsolete]
		static bool n_IsFsckObjects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransferConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFsckObjects;
		}
#pragma warning restore 0169

		/// <returns>strictly verify received objects?</returns>
		[Obsolete (@"deprecated")]
		public virtual unsafe bool IsFsckObjects {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransferConfig']/method[@name='isFsckObjects' and count(parameter)=0]"
			[Register ("isFsckObjects", "()Z", "GetIsFsckObjectsHandler")]
			get {
				const string __id = "isFsckObjects.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRefFilter;
#pragma warning disable 0169
		static Delegate GetGetRefFilterHandler ()
		{
			if (cb_getRefFilter == null)
				cb_getRefFilter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefFilter);
			return cb_getRefFilter;
		}

		static IntPtr n_GetRefFilter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransferConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefFilter);
		}
#pragma warning restore 0169

		/// <returns>
		///   <c>RefFilter</c> respecting configured hidden refs.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.IRefFilter RefFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransferConfig']/method[@name='getRefFilter' and count(parameter)=0]"
			[Register ("getRefFilter", "()Lorg/eclipse/jgit/transport/RefFilter;", "GetGetRefFilterHandler")]
			get {
				const string __id = "getRefFilter.()Lorg/eclipse/jgit/transport/RefFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRefFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_newObjectChecker;
#pragma warning disable 0169
		static Delegate GetNewObjectCheckerHandler ()
		{
			if (cb_newObjectChecker == null)
				cb_newObjectChecker = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewObjectChecker);
			return cb_newObjectChecker;
		}

		static IntPtr n_NewObjectChecker (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransferConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewObjectChecker ());
		}
#pragma warning restore 0169

		/// <returns>checker to verify fetched objects, or null if checking is not
		///         enabled in the repository configuration.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransferConfig']/method[@name='newObjectChecker' and count(parameter)=0]"
		[Register ("newObjectChecker", "()Lorg/eclipse/jgit/lib/ObjectChecker;", "GetNewObjectCheckerHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectChecker NewObjectChecker ()
		{
			const string __id = "newObjectChecker.()Lorg/eclipse/jgit/lib/ObjectChecker;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
