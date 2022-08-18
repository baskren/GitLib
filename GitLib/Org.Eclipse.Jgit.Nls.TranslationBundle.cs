using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Nls {

	/// <summary>Base class for all translation bundles that provides injection of translated
	/// texts into public String fields.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.nls']/class[@name='TranslationBundle']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/nls/TranslationBundle", DoNotGenerateAcw=true)]
	public abstract partial class TranslationBundle : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/nls/TranslationBundle", typeof (TranslationBundle));

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

		protected TranslationBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.nls']/class[@name='TranslationBundle']/constructor[@name='TranslationBundle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TranslationBundle () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_effectiveLocale;
#pragma warning disable 0169
		static Delegate GetEffectiveLocaleHandler ()
		{
			if (cb_effectiveLocale == null)
				cb_effectiveLocale = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_EffectiveLocale);
			return cb_effectiveLocale;
		}

		static IntPtr n_EffectiveLocale (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Nls.TranslationBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EffectiveLocale ());
		}
#pragma warning restore 0169

		/// <returns>the locale locale used for loading the resource bundle from which
		///         the field values were taken</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.nls']/class[@name='TranslationBundle']/method[@name='effectiveLocale' and count(parameter)=0]"
		[Register ("effectiveLocale", "()Ljava/util/Locale;", "GetEffectiveLocaleHandler")]
		public virtual unsafe global::Java.Util.Locale EffectiveLocale ()
		{
			const string __id = "effectiveLocale.()Ljava/util/Locale;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resourceBundle;
#pragma warning disable 0169
		static Delegate GetResourceBundleHandler ()
		{
			if (cb_resourceBundle == null)
				cb_resourceBundle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ResourceBundle);
			return cb_resourceBundle;
		}

		static IntPtr n_ResourceBundle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Nls.TranslationBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResourceBundle ());
		}
#pragma warning restore 0169

		/// <returns>the resource bundle on which this translation bundle is based</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.nls']/class[@name='TranslationBundle']/method[@name='resourceBundle' and count(parameter)=0]"
		[Register ("resourceBundle", "()Ljava/util/ResourceBundle;", "GetResourceBundleHandler")]
		public virtual unsafe global::Java.Util.ResourceBundle ResourceBundle ()
		{
			const string __id = "resourceBundle.()Ljava/util/ResourceBundle;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.ResourceBundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/nls/TranslationBundle", DoNotGenerateAcw=true)]
	internal partial class TranslationBundleInvoker : TranslationBundle {
		public TranslationBundleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/nls/TranslationBundle", typeof (TranslationBundleInvoker));

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

	}
}
