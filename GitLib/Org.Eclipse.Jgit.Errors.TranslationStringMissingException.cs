using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>This exception will be thrown when a translation string for a translation
	/// bundle and locale is missing.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='TranslationStringMissingException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/TranslationStringMissingException", DoNotGenerateAcw=true)]
	public partial class TranslationStringMissingException : global::Org.Eclipse.Jgit.Errors.TranslationBundleException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/TranslationStringMissingException", typeof (TranslationStringMissingException));

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

		protected TranslationStringMissingException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="bundleClass">the bundle class for which a translation string was missing</param>
		/// <param name="locale">the locale for which a translation string was missing</param>
		/// <param name="key">the key of the missing translation string</param>
		/// <param name="cause">the original exception thrown from the
		///            <c>ResourceBundle#getString(String)</c> method.</param>
		/// <summary>Construct a <c>TranslationStringMissingException</c> for the specified
		/// bundle class, locale and translation key</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='TranslationStringMissingException']/constructor[@name='TranslationStringMissingException' and count(parameter)=4 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.util.Locale'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public unsafe TranslationStringMissingException (global::Java.Lang.Class bundleClass, global::Java.Util.Locale locale, string key, global::Java.Lang.Exception cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/Exception;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewString ((string)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((bundleClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundleClass).Handle);
				__args [1] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				__args [2] = new JniArgumentValue (native_key);
				__args [3] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (bundleClass);
				global::System.GC.KeepAlive (locale);
				global::System.GC.KeepAlive (cause);
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.TranslationStringMissingException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		/// <returns>the key of the missing translation string</returns>
		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='TranslationStringMissingException']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				const string __id = "getKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
