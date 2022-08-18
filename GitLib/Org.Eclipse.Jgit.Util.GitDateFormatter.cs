using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>A utility for formatting dates according to the Git log.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/GitDateFormatter", DoNotGenerateAcw=true)]
	public partial class GitDateFormatter : global::Java.Lang.Object {
		/// <summary>Git and JGit formats</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/GitDateFormatter$Format", DoNotGenerateAcw=true)]
		public sealed partial class Format : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format Default {
				get {
					const string __id = "DEFAULT.Lorg/eclipse/jgit/util/GitDateFormatter$Format;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/field[@name='ISO']"
			[Register ("ISO")]
			public static global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format Iso {
				get {
					const string __id = "ISO.Lorg/eclipse/jgit/util/GitDateFormatter$Format;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/field[@name='LOCAL']"
			[Register ("LOCAL")]
			public static global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format Local {
				get {
					const string __id = "LOCAL.Lorg/eclipse/jgit/util/GitDateFormatter$Format;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/field[@name='LOCALE']"
			[Register ("LOCALE")]
			public static global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format Locale {
				get {
					const string __id = "LOCALE.Lorg/eclipse/jgit/util/GitDateFormatter$Format;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/field[@name='LOCALELOCAL']"
			[Register ("LOCALELOCAL")]
			public static global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format Localelocal {
				get {
					const string __id = "LOCALELOCAL.Lorg/eclipse/jgit/util/GitDateFormatter$Format;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/field[@name='RAW']"
			[Register ("RAW")]
			public static global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format Raw {
				get {
					const string __id = "RAW.Lorg/eclipse/jgit/util/GitDateFormatter$Format;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/field[@name='RELATIVE']"
			[Register ("RELATIVE")]
			public static global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format Relative {
				get {
					const string __id = "RELATIVE.Lorg/eclipse/jgit/util/GitDateFormatter$Format;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/field[@name='RFC']"
			[Register ("RFC")]
			public static global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format Rfc {
				get {
					const string __id = "RFC.Lorg/eclipse/jgit/util/GitDateFormatter$Format;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/field[@name='SHORT']"
			[Register ("SHORT")]
			public static global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format Short {
				get {
					const string __id = "SHORT.Lorg/eclipse/jgit/util/GitDateFormatter$Format;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/GitDateFormatter$Format", typeof (Format));

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

			internal Format (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/util/GitDateFormatter$Format;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/util/GitDateFormatter$Format;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter.Format']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/util/GitDateFormatter$Format;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/util/GitDateFormatter$Format;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/GitDateFormatter", typeof (GitDateFormatter));

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

		protected GitDateFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter']/constructor[@name='GitDateFormatter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.GitDateFormatter.Format']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/util/GitDateFormatter$Format;)V", "")]
		public unsafe GitDateFormatter (global::Org.Eclipse.Jgit.Util.GitDateFormatter.Format format) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/util/GitDateFormatter$Format;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		static Delegate cb_formatDate_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetFormatDate_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_formatDate_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_formatDate_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FormatDate_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_formatDate_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static IntPtr n_FormatDate_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ident)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.GitDateFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ident = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_ident, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.FormatDate (ident));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ident">ident</param>
		/// <summary>Format committer, author or tagger ident according to this formatter's
		/// specification.</summary>
		/// <returns>formatted version of date, time and time zone</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateFormatter']/method[@name='formatDate' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
		[Register ("formatDate", "(Lorg/eclipse/jgit/lib/PersonIdent;)Ljava/lang/String;", "GetFormatDate_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
		public virtual unsafe string FormatDate (global::Org.Eclipse.Jgit.Lib.PersonIdent ident)
		{
			const string __id = "formatDate.(Lorg/eclipse/jgit/lib/PersonIdent;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ident == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ident).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ident);
			}
		}

	}
}
