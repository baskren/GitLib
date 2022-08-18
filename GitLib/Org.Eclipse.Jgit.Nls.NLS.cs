using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Nls {

	/// <summary>The purpose of this class is to provide NLS (National Language Support)
	/// configurable per thread.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.nls']/class[@name='NLS']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/nls/NLS", DoNotGenerateAcw=true)]
	public partial class NLS : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.nls']/class[@name='NLS']/field[@name='ROOT_LOCALE']"
		[Register ("ROOT_LOCALE")]
		public static global::Java.Util.Locale RootLocale {
			get {
				const string __id = "ROOT_LOCALE.Ljava/util/Locale;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/nls/NLS", typeof (NLS));

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

		protected NLS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="&lt;T&gt;">required bundle type</param>
		/// <param name="type">required bundle type</param>
		/// <summary>Returns an instance of the translation bundle of the required type.</summary>
		/// <returns>an instance of the required bundle type</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.nls']/class[@name='NLS']/method[@name='getBundleFor' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getBundleFor", "(Ljava/lang/Class;)Lorg/eclipse/jgit/nls/TranslationBundle;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.nls.TranslationBundle"})]
		public static unsafe global::Java.Lang.Object GetBundleFor (global::Java.Lang.Class type)
		{
			const string __id = "getBundleFor.(Ljava/lang/Class;)Lorg/eclipse/jgit/nls/TranslationBundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

		/// <param name="locale">the preferred locale</param>
		/// <summary>Sets the locale for the calling thread.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.nls']/class[@name='NLS']/method[@name='setLocale' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("setLocale", "(Ljava/util/Locale;)V", "")]
		public static unsafe void SetLocale (global::Java.Util.Locale locale)
		{
			const string __id = "setLocale.(Ljava/util/Locale;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (locale);
			}
		}

		/// <summary>Sets the JVM default locale as the locale for the calling thread.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.nls']/class[@name='NLS']/method[@name='useJVMDefaultLocale' and count(parameter)=0]"
		[Register ("useJVMDefaultLocale", "()V", "")]
		public static unsafe void UseJVMDefaultLocale ()
		{
			const string __id = "useJVMDefaultLocale.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
