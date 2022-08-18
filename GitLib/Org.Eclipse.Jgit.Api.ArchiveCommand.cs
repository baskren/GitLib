using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Create an archive of files from a named tree.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/ArchiveCommand", DoNotGenerateAcw=true)]
	public partial class ArchiveCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::System.IO.Stream> {
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.api']/interface[@name='ArchiveCommand.Format']"
		[Register ("org/eclipse/jgit/api/ArchiveCommand$Format", "", "Org.Eclipse.Jgit.Api.ArchiveCommand/IFormatInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.io.Closeable"})]
		public partial interface IFormat : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/interface[@name='ArchiveCommand.Format']/method[@name='createArchiveOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			/// <param name="s">underlying output stream to which to write the archive.</param>
			/// <summary>Start a new archive.</summary>
			/// <returns>new archive object for use in putEntry</returns>
			[Register ("createArchiveOutputStream", "(Ljava/io/OutputStream;)Ljava/io/Closeable;", "GetCreateArchiveOutputStream_Ljava_io_OutputStream_Handler:Org.Eclipse.Jgit.Api.ArchiveCommand/IFormatInvoker, AndroidBindableLibrary")]
			global::Java.Lang.Object CreateArchiveOutputStream (global::System.IO.Stream s);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/interface[@name='ArchiveCommand.Format']/method[@name='putEntry' and count(parameter)=4 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.lib.FileMode'] and parameter[4][@type='org.eclipse.jgit.lib.ObjectLoader']]"
			/// <param name="out">archive object from createArchiveOutputStream</param>
			/// <param name="path">full filename relative to the root of the archive
			///            (with trailing '/' for directories)</param>
			/// <param name="mode">mode (for example FileMode.REGULAR_FILE or
			///            FileMode.SYMLINK)</param>
			/// <param name="loader">blob object with data for this entry (null for
			///            directories)</param>
			/// <summary>Write an entry to an archive.</summary>
			[Register ("putEntry", "(Ljava/io/Closeable;Ljava/lang/String;Lorg/eclipse/jgit/lib/FileMode;Lorg/eclipse/jgit/lib/ObjectLoader;)V", "GetPutEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_Handler:Org.Eclipse.Jgit.Api.ArchiveCommand/IFormatInvoker, AndroidBindableLibrary")]
			void PutEntry (global::Java.Lang.Object @out, string path, global::Org.Eclipse.Jgit.Lib.FileMode mode, global::Org.Eclipse.Jgit.Lib.ObjectLoader loader);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/interface[@name='ArchiveCommand.Format']/method[@name='suffixes' and count(parameter)=0]"
			[Register ("suffixes", "()Ljava/lang/Iterable;", "GetSuffixesHandler:Org.Eclipse.Jgit.Api.ArchiveCommand/IFormatInvoker, AndroidBindableLibrary")]
			global::Java.Lang.IIterable Suffixes ();

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/api/ArchiveCommand$Format", DoNotGenerateAcw=true)]
		internal partial class IFormatInvoker : global::Java.Lang.Object, IFormat {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/ArchiveCommand$Format", typeof (IFormatInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IFormat GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFormat> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.api.ArchiveCommand.Format'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFormatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_createArchiveOutputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
			static Delegate GetCreateArchiveOutputStream_Ljava_io_OutputStream_Handler ()
			{
				if (cb_createArchiveOutputStream_Ljava_io_OutputStream_ == null)
					cb_createArchiveOutputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateArchiveOutputStream_Ljava_io_OutputStream_);
				return cb_createArchiveOutputStream_Ljava_io_OutputStream_;
			}

			static IntPtr n_CreateArchiveOutputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand.IFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var s = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_s, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateArchiveOutputStream (s));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_createArchiveOutputStream_Ljava_io_OutputStream_;
			public unsafe global::Java.Lang.Object CreateArchiveOutputStream (global::System.IO.Stream s)
			{
				if (id_createArchiveOutputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_createArchiveOutputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "createArchiveOutputStream", "(Ljava/io/OutputStream;)Ljava/io/Closeable;");
				IntPtr native_s = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (s);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);
				var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createArchiveOutputStream_Ljava_io_OutputStream_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_s);
				return __ret;
			}

			static Delegate cb_putEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_;
#pragma warning disable 0169
			static Delegate GetPutEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_Handler ()
			{
				if (cb_putEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_ == null)
					cb_putEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PutEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_);
				return cb_putEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_;
			}

			static void n_PutEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_path, IntPtr native_mode, IntPtr native_loader)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand.IFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @out = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__out, JniHandleOwnership.DoNotTransfer);
				var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
				var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (native_mode, JniHandleOwnership.DoNotTransfer);
				var loader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (native_loader, JniHandleOwnership.DoNotTransfer);
				__this.PutEntry (@out, path, mode, loader);
			}
#pragma warning restore 0169

			IntPtr id_putEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_;
			public unsafe void PutEntry (global::Java.Lang.Object @out, string path, global::Org.Eclipse.Jgit.Lib.FileMode mode, global::Org.Eclipse.Jgit.Lib.ObjectLoader loader)
			{
				if (id_putEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_ == IntPtr.Zero)
					id_putEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_ = JNIEnv.GetMethodID (class_ref, "putEntry", "(Ljava/io/Closeable;Ljava/lang/String;Lorg/eclipse/jgit/lib/FileMode;Lorg/eclipse/jgit/lib/ObjectLoader;)V");
				IntPtr native__out = JNIEnv.ToLocalJniHandle (@out);
				IntPtr native_path = JNIEnv.NewString ((string)path);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native__out);
				__args [1] = new JValue (native_path);
				__args [2] = new JValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [3] = new JValue ((loader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loader).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putEntry_Ljava_io_Closeable_Ljava_lang_String_Lorg_eclipse_jgit_lib_FileMode_Lorg_eclipse_jgit_lib_ObjectLoader_, __args);
				JNIEnv.DeleteLocalRef (native__out);
				JNIEnv.DeleteLocalRef (native_path);
			}

			static Delegate cb_suffixes;
#pragma warning disable 0169
			static Delegate GetSuffixesHandler ()
			{
				if (cb_suffixes == null)
					cb_suffixes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Suffixes);
				return cb_suffixes;
			}

			static IntPtr n_Suffixes (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand.IFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Suffixes ());
			}
#pragma warning restore 0169

			IntPtr id_suffixes;
			public unsafe global::Java.Lang.IIterable Suffixes ()
			{
				if (id_suffixes == IntPtr.Zero)
					id_suffixes = JNIEnv.GetMethodID (class_ref, "suffixes", "()Ljava/lang/Iterable;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_suffixes), JniHandleOwnership.TransferLocalRef);
			}

		}

		/// <summary>Signals an attempt to use an archival format that ArchiveCommand
		/// doesn't know about (for example due to a typo).</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand.UnsupportedFormatException']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/ArchiveCommand$UnsupportedFormatException", DoNotGenerateAcw=true)]
		public partial class UnsupportedFormatException : global::Org.Eclipse.Jgit.Api.Errors.GitAPIException {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/ArchiveCommand$UnsupportedFormatException", typeof (UnsupportedFormatException));

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

			protected UnsupportedFormatException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="format">the problematic format name</param>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand.UnsupportedFormatException']/constructor[@name='ArchiveCommand.UnsupportedFormatException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe UnsupportedFormatException (string format) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_format = JNIEnv.NewString ((string)format);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_format);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_format);
				}
			}

			static Delegate cb_getFormat;
#pragma warning disable 0169
			static Delegate GetGetFormatHandler ()
			{
				if (cb_getFormat == null)
					cb_getFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFormat);
				return cb_getFormat;
			}

			static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand.UnsupportedFormatException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Format);
			}
#pragma warning restore 0169

			/// <returns>the problematic format name</returns>
			public virtual unsafe string Format {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand.UnsupportedFormatException']/method[@name='getFormat' and count(parameter)=0]"
				[Register ("getFormat", "()Ljava/lang/String;", "GetGetFormatHandler")]
				get {
					const string __id = "getFormat.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/ArchiveCommand", typeof (ArchiveCommand));

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

		protected ArchiveCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/constructor[@name='ArchiveCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe ArchiveCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <returns>the stream to which the archive has been written</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/io/OutputStream;", "GetCallHandler")]
		public override unsafe global::System.IO.Stream Call ()
		{
			const string __id = "call.()Ljava/io/OutputStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/method[@name='registerFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.api.ArchiveCommand.Format&lt;?&gt;']]"
		[Register ("registerFormat", "(Ljava/lang/String;Lorg/eclipse/jgit/api/ArchiveCommand$Format;)V", "")]
		public static unsafe void RegisterFormat (string name, global::Org.Eclipse.Jgit.Api.ArchiveCommand.IFormat fmt)
		{
			const string __id = "registerFormat.(Ljava/lang/String;Lorg/eclipse/jgit/api/ArchiveCommand$Format;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((fmt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fmt).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (fmt);
			}
		}

		static Delegate cb_setFilename_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFilename_Ljava_lang_String_Handler ()
		{
			if (cb_setFilename_Ljava_lang_String_ == null)
				cb_setFilename_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetFilename_Ljava_lang_String_);
			return cb_setFilename_Ljava_lang_String_;
		}

		static IntPtr n_SetFilename_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFilename (filename));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="filename">intended filename for the archive</param>
		/// <summary>Set the intended filename for the produced archive.</summary>
		/// <returns>this</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/method[@name='setFilename' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFilename", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/ArchiveCommand;", "GetSetFilename_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ArchiveCommand SetFilename (string filename)
		{
			const string __id = "setFilename.(Ljava/lang/String;)Lorg/eclipse/jgit/api/ArchiveCommand;";
			IntPtr native_filename = JNIEnv.NewString ((string)filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filename);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static Delegate cb_setFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setFormat_Ljava_lang_String_ == null)
				cb_setFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetFormat_Ljava_lang_String_);
			return cb_setFormat_Ljava_lang_String_;
		}

		static IntPtr n_SetFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fmt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fmt = JNIEnv.GetString (native_fmt, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFormat (fmt));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="fmt">archive format (e.g., "tar" or "zip").
		///       null means to choose automatically based on
		///       the archive filename.</param>
		/// <returns>this</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/method[@name='setFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFormat", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/ArchiveCommand;", "GetSetFormat_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ArchiveCommand SetFormat (string fmt)
		{
			const string __id = "setFormat.(Ljava/lang/String;)Lorg/eclipse/jgit/api/ArchiveCommand;";
			IntPtr native_fmt = JNIEnv.NewString ((string)fmt);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fmt);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fmt);
			}
		}

		static Delegate cb_setOutputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetSetOutputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_setOutputStream_Ljava_io_OutputStream_ == null)
				cb_setOutputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOutputStream_Ljava_io_OutputStream_);
			return cb_setOutputStream_Ljava_io_OutputStream_;
		}

		static IntPtr n_SetOutputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOutputStream (@out));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="out">the stream to which to write the archive</param>
		/// <returns>this</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/method[@name='setOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("setOutputStream", "(Ljava/io/OutputStream;)Lorg/eclipse/jgit/api/ArchiveCommand;", "GetSetOutputStream_Ljava_io_OutputStream_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ArchiveCommand SetOutputStream (global::System.IO.Stream @out)
		{
			const string __id = "setOutputStream.(Ljava/io/OutputStream;)Lorg/eclipse/jgit/api/ArchiveCommand;";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_setPaths_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPaths_arrayLjava_lang_String_Handler ()
		{
			if (cb_setPaths_arrayLjava_lang_String_ == null)
				cb_setPaths_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPaths_arrayLjava_lang_String_);
			return cb_setPaths_arrayLjava_lang_String_;
		}

		static IntPtr n_SetPaths_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paths)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paths = (string[]) JNIEnv.GetArray (native_paths, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPaths (paths));
			if (paths != null)
				JNIEnv.CopyArray (paths, native_paths);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/method[@name='setPaths' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setPaths", "([Ljava/lang/String;)Lorg/eclipse/jgit/api/ArchiveCommand;", "GetSetPaths_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ArchiveCommand SetPaths (params string[] paths)
		{
			const string __id = "setPaths.([Ljava/lang/String;)Lorg/eclipse/jgit/api/ArchiveCommand;";
			IntPtr native_paths = JNIEnv.NewArray (paths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paths);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (paths != null) {
					JNIEnv.CopyArray (native_paths, paths);
					JNIEnv.DeleteLocalRef (native_paths);
				}
				global::System.GC.KeepAlive (paths);
			}
		}

		static Delegate cb_setPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setPrefix_Ljava_lang_String_ == null)
				cb_setPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPrefix_Ljava_lang_String_);
			return cb_setPrefix_Ljava_lang_String_;
		}

		static IntPtr n_SetPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPrefix (prefix));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="prefix">string prefixed to filenames in archive (e.g., "master/").
		///            null means to not use any leading prefix.</param>
		/// <returns>this</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/method[@name='setPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPrefix", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/ArchiveCommand;", "GetSetPrefix_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ArchiveCommand SetPrefix (string prefix)
		{
			const string __id = "setPrefix.(Ljava/lang/String;)Lorg/eclipse/jgit/api/ArchiveCommand;";
			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		static Delegate cb_setTree_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetSetTree_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_setTree_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_setTree_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTree_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_setTree_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static IntPtr n_SetTree_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tree)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tree = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_tree, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTree (tree));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="tree">the tag, commit, or tree object to produce an archive for</param>
		/// <returns>this</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/method[@name='setTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("setTree", "(Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/api/ArchiveCommand;", "GetSetTree_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ArchiveCommand SetTree (global::Org.Eclipse.Jgit.Lib.ObjectId tree)
		{
			const string __id = "setTree.(Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/api/ArchiveCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tree).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ArchiveCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (tree);
			}
		}

		/// <param name="name">name of format (e.g., "tar" or "zip").</param>
		/// <summary>Marks support for an archival format as no longer needed so its
		/// Format can be garbage collected if no one else is using it either.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ArchiveCommand']/method[@name='unregisterFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregisterFormat", "(Ljava/lang/String;)V", "")]
		public static unsafe void UnregisterFormat (string name)
		{
			const string __id = "unregisterFormat.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
