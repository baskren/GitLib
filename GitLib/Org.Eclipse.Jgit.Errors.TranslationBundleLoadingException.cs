using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>This exception will be thrown when a translation bundle loading
	/// fails.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='TranslationBundleLoadingException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/TranslationBundleLoadingException", DoNotGenerateAcw=true)]
	public partial class TranslationBundleLoadingException : global::Org.Eclipse.Jgit.Errors.TranslationBundleException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/TranslationBundleLoadingException", typeof (TranslationBundleLoadingException));

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

		protected TranslationBundleLoadingException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="bundleClass">the bundle class for which the loading failed</param>
		/// <param name="locale">the locale for which the loading failed</param>
		/// <param name="cause">the original exception thrown from the
		///            <c>ResourceBundle#getBundle(String, Locale)</c> method.</param>
		/// <summary>Construct a <c>TranslationBundleLoadingException</c> for the specified
		/// bundle class and locale.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='TranslationBundleLoadingException']/constructor[@name='TranslationBundleLoadingException' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.util.Locale'] and parameter[3][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/util/Locale;Ljava/lang/Exception;)V", "")]
		public unsafe TranslationBundleLoadingException (global::Java.Lang.Class bundleClass, global::Java.Util.Locale locale, global::Java.Lang.Exception cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;Ljava/util/Locale;Ljava/lang/Exception;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bundleClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundleClass).Handle);
				__args [1] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				__args [2] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bundleClass);
				global::System.GC.KeepAlive (locale);
				global::System.GC.KeepAlive (cause);
			}
		}

	}
}
