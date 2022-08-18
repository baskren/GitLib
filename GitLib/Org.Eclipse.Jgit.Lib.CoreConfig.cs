using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>This class keeps git repository core parameters.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/CoreConfig", DoNotGenerateAcw=true)]
	public partial class CoreConfig : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig']/field[@name='KEY']"
		[Register ("KEY")]
		public static global::Org.Eclipse.Jgit.Lib.Config.ISectionParser Key {
			get {
				const string __id = "KEY.Lorg/eclipse/jgit/lib/Config$SectionParser;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.ISectionParser> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>Permissible values for <c>core.autocrlf</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.AutoCRLF']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/CoreConfig$AutoCRLF", DoNotGenerateAcw=true)]
		public sealed partial class AutoCRLF : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.AutoCRLF']/field[@name='FALSE']"
			[Register ("FALSE")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF False {
				get {
					const string __id = "FALSE.Lorg/eclipse/jgit/lib/CoreConfig$AutoCRLF;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.AutoCRLF']/field[@name='INPUT']"
			[Register ("INPUT")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF Input {
				get {
					const string __id = "INPUT.Lorg/eclipse/jgit/lib/CoreConfig$AutoCRLF;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.AutoCRLF']/field[@name='TRUE']"
			[Register ("TRUE")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF True {
				get {
					const string __id = "TRUE.Lorg/eclipse/jgit/lib/CoreConfig$AutoCRLF;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/CoreConfig$AutoCRLF", typeof (AutoCRLF));

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

			internal AutoCRLF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.AutoCRLF']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/CoreConfig$AutoCRLF;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/CoreConfig$AutoCRLF;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.AutoCRLF']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/lib/CoreConfig$AutoCRLF;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/lib/CoreConfig$AutoCRLF;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF));
				} finally {
				}
			}

		}

		/// <summary>Permissible values for <c>core.checkstat</c></summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.CheckStat']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/CoreConfig$CheckStat", DoNotGenerateAcw=true)]
		public sealed partial class CheckStat : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.CheckStat']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat Default {
				get {
					const string __id = "DEFAULT.Lorg/eclipse/jgit/lib/CoreConfig$CheckStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.CheckStat']/field[@name='MINIMAL']"
			[Register ("MINIMAL")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat Minimal {
				get {
					const string __id = "MINIMAL.Lorg/eclipse/jgit/lib/CoreConfig$CheckStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/CoreConfig$CheckStat", typeof (CheckStat));

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

			internal CheckStat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.CheckStat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/CoreConfig$CheckStat;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/CoreConfig$CheckStat;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.CheckStat']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/lib/CoreConfig$CheckStat;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/lib/CoreConfig$CheckStat;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat));
				} finally {
				}
			}

		}

		/// <summary>Options for hiding files whose names start with a period</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.HideDotFiles']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/CoreConfig$HideDotFiles", DoNotGenerateAcw=true)]
		public sealed partial class HideDotFiles : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.HideDotFiles']/field[@name='DOTGITONLY']"
			[Register ("DOTGITONLY")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles Dotgitonly {
				get {
					const string __id = "DOTGITONLY.Lorg/eclipse/jgit/lib/CoreConfig$HideDotFiles;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.HideDotFiles']/field[@name='FALSE']"
			[Register ("FALSE")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles False {
				get {
					const string __id = "FALSE.Lorg/eclipse/jgit/lib/CoreConfig$HideDotFiles;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.HideDotFiles']/field[@name='TRUE']"
			[Register ("TRUE")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles True {
				get {
					const string __id = "TRUE.Lorg/eclipse/jgit/lib/CoreConfig$HideDotFiles;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/CoreConfig$HideDotFiles", typeof (HideDotFiles));

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

			internal HideDotFiles (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.HideDotFiles']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/CoreConfig$HideDotFiles;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/CoreConfig$HideDotFiles;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.HideDotFiles']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/lib/CoreConfig$HideDotFiles;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/lib/CoreConfig$HideDotFiles;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles));
				} finally {
				}
			}

		}

		/// <summary>Options for symlink handling</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.SymLinks']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/CoreConfig$SymLinks", DoNotGenerateAcw=true)]
		public sealed partial class SymLinks : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.SymLinks']/field[@name='FALSE']"
			[Register ("FALSE")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks False {
				get {
					const string __id = "FALSE.Lorg/eclipse/jgit/lib/CoreConfig$SymLinks;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.SymLinks']/field[@name='TRUE']"
			[Register ("TRUE")]
			public static global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks True {
				get {
					const string __id = "TRUE.Lorg/eclipse/jgit/lib/CoreConfig$SymLinks;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/CoreConfig$SymLinks", typeof (SymLinks));

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

			internal SymLinks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.SymLinks']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/CoreConfig$SymLinks;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/CoreConfig$SymLinks;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig.SymLinks']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/lib/CoreConfig$SymLinks;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/lib/CoreConfig$SymLinks;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/CoreConfig", typeof (CoreConfig));

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

		protected CoreConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAttributesFile;
#pragma warning disable 0169
		static Delegate GetGetAttributesFileHandler ()
		{
			if (cb_getAttributesFile == null)
				cb_getAttributesFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAttributesFile);
			return cb_getAttributesFile;
		}

		static IntPtr n_GetAttributesFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AttributesFile);
		}
#pragma warning restore 0169

		/// <returns>path of attributesfile</returns>
		public virtual unsafe string AttributesFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig']/method[@name='getAttributesFile' and count(parameter)=0]"
			[Register ("getAttributesFile", "()Ljava/lang/String;", "GetGetAttributesFileHandler")]
			get {
				const string __id = "getAttributesFile.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCompression;
#pragma warning disable 0169
		static Delegate GetGetCompressionHandler ()
		{
			if (cb_getCompression == null)
				cb_getCompression = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCompression);
			return cb_getCompression;
		}

		static int n_GetCompression (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Compression;
		}
#pragma warning restore 0169

		/// <returns>The compression level to use when storing loose objects</returns>
		public virtual unsafe int Compression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig']/method[@name='getCompression' and count(parameter)=0]"
			[Register ("getCompression", "()I", "GetGetCompressionHandler")]
			get {
				const string __id = "getCompression.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getExcludesFile;
#pragma warning disable 0169
		static Delegate GetGetExcludesFileHandler ()
		{
			if (cb_getExcludesFile == null)
				cb_getExcludesFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExcludesFile);
			return cb_getExcludesFile;
		}

		static IntPtr n_GetExcludesFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExcludesFile);
		}
#pragma warning restore 0169

		/// <returns>path of excludesfile</returns>
		public virtual unsafe string ExcludesFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig']/method[@name='getExcludesFile' and count(parameter)=0]"
			[Register ("getExcludesFile", "()Ljava/lang/String;", "GetGetExcludesFileHandler")]
			get {
				const string __id = "getExcludesFile.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isLogAllRefUpdates;
#pragma warning disable 0169
		static Delegate GetIsLogAllRefUpdatesHandler ()
		{
			if (cb_isLogAllRefUpdates == null)
				cb_isLogAllRefUpdates = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLogAllRefUpdates);
			return cb_isLogAllRefUpdates;
		}

		static bool n_IsLogAllRefUpdates (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLogAllRefUpdates;
		}
#pragma warning restore 0169

		/// <returns>whether to log all refUpdates</returns>
		public virtual unsafe bool IsLogAllRefUpdates {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig']/method[@name='isLogAllRefUpdates' and count(parameter)=0]"
			[Register ("isLogAllRefUpdates", "()Z", "GetIsLogAllRefUpdatesHandler")]
			get {
				const string __id = "isLogAllRefUpdates.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPackIndexVersion;
#pragma warning disable 0169
		static Delegate GetGetPackIndexVersionHandler ()
		{
			if (cb_getPackIndexVersion == null)
				cb_getPackIndexVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPackIndexVersion);
			return cb_getPackIndexVersion;
		}

		static int n_GetPackIndexVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PackIndexVersion;
		}
#pragma warning restore 0169

		/// <returns>the preferred pack index file format; 0 for oldest possible.</returns>
		public virtual unsafe int PackIndexVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='CoreConfig']/method[@name='getPackIndexVersion' and count(parameter)=0]"
			[Register ("getPackIndexVersion", "()I", "GetGetPackIndexVersionHandler")]
			get {
				const string __id = "getPackIndexVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
