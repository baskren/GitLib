using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>Common base class for all translation bundle related exceptions.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='TranslationBundleException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/TranslationBundleException", DoNotGenerateAcw=true)]
	public abstract partial class TranslationBundleException : global::Java.Lang.RuntimeException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/TranslationBundleException", typeof (TranslationBundleException));

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

		protected TranslationBundleException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="message">exception message</param>
		/// <param name="bundleClass">bundle class for which the exception occurred</param>
		/// <param name="locale">locale for which the exception occurred</param>
		/// <param name="cause">original exception that caused this exception. Usually thrown
		///            from the <c>ResourceBundle</c> class.</param>
		/// <summary>To construct an instance of <c>TranslationBundleException</c></summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='TranslationBundleException']/constructor[@name='TranslationBundleException' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='java.util.Locale'] and parameter[4][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Class;Ljava/util/Locale;Ljava/lang/Exception;)V", "")]
		protected unsafe TranslationBundleException (string message, global::Java.Lang.Class bundleClass, global::Java.Util.Locale locale, global::Java.Lang.Exception cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Class;Ljava/util/Locale;Ljava/lang/Exception;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((bundleClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundleClass).Handle);
				__args [2] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				__args [3] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (bundleClass);
				global::System.GC.KeepAlive (locale);
				global::System.GC.KeepAlive (cause);
			}
		}

		/// <returns>bundle class for which the exception occurred</returns>
		public unsafe global::Java.Lang.Class BundleClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='TranslationBundleException']/method[@name='getBundleClass' and count(parameter)=0]"
			[Register ("getBundleClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getBundleClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>locale for which the exception occurred</returns>
		public unsafe global::Java.Util.Locale Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='TranslationBundleException']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/util/Locale;", "")]
			get {
				const string __id = "getLocale.()Ljava/util/Locale;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/TranslationBundleException", DoNotGenerateAcw=true)]
	internal partial class TranslationBundleExceptionInvoker : TranslationBundleException {
		public TranslationBundleExceptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/TranslationBundleException", typeof (TranslationBundleExceptionInvoker));

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
