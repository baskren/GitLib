using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport.Resolver {

	/// <param name="&lt;C&gt;">type of connection</param>
	/// <summary>Default resolver serving from the local filesystem.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/class[@name='FileResolver']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/resolver/FileResolver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"C"})]
	public partial class FileResolver : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolver {
		public static class InterfaceConsts {
			// The following are fields from: org.eclipse.jgit.transport.resolver.RepositoryResolver


			/// <summary>Resolver configured to open nothing.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/interface[@name='RepositoryResolver']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolver None {
				get {
					const string __id = "NONE.Lorg/eclipse/jgit/transport/resolver/RepositoryResolver;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolver> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/resolver/FileResolver", typeof (FileResolver));

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

		protected FileResolver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Initialize an empty file based resolver.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/class[@name='FileResolver']/constructor[@name='FileResolver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileResolver () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="basePath">the base path all repositories are rooted under.</param>
		/// <param name="exportAll">if true, exports all repositories, ignoring the check for the
		///            <c>git-daemon-export-ok</c> files.</param>
		/// <summary>Create a new resolver for the given path.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/class[@name='FileResolver']/constructor[@name='FileResolver' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/File;Z)V", "")]
		public unsafe FileResolver (global::Java.IO.File basePath, bool exportAll) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((basePath == null) ? IntPtr.Zero : ((global::Java.Lang.Object) basePath).Handle);
				__args [1] = new JniArgumentValue (exportAll);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (basePath);
			}
		}

		static Delegate cb_isExportAll;
#pragma warning disable 0169
		static Delegate GetIsExportAllHandler ()
		{
			if (cb_isExportAll == null)
				cb_isExportAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExportAll);
			return cb_isExportAll;
		}

		static bool n_IsExportAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.FileResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExportAll;
		}
#pragma warning restore 0169

		static Delegate cb_setExportAll_Z;
#pragma warning disable 0169
		static Delegate GetSetExportAll_ZHandler ()
		{
			if (cb_setExportAll_Z == null)
				cb_setExportAll_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetExportAll_Z);
			return cb_setExportAll_Z;
		}

		static void n_SetExportAll_Z (IntPtr jnienv, IntPtr native__this, bool export)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.FileResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExportAll = export;
		}
#pragma warning restore 0169

		/// <returns>false if &lt;code&gt;git-daemon-export-ok&lt;/code&gt; is required to export
		///         a repository; true if &lt;code&gt;git-daemon-export-ok&lt;/code&gt; is
		///         ignored.</returns>
		/// <summary>Set whether or not to export all repositories.</summary>
		/// <param name="export">export</param>
		public virtual unsafe bool ExportAll {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/class[@name='FileResolver']/method[@name='isExportAll' and count(parameter)=0]"
			[Register ("isExportAll", "()Z", "GetIsExportAllHandler")]
			get {
				const string __id = "isExportAll.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/class[@name='FileResolver']/method[@name='setExportAll' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExportAll", "(Z)V", "GetSetExportAll_ZHandler")]
			set {
				const string __id = "setExportAll.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_exportDirectory_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetExportDirectory_Ljava_io_File_Handler ()
		{
			if (cb_exportDirectory_Ljava_io_File_ == null)
				cb_exportDirectory_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ExportDirectory_Ljava_io_File_);
			return cb_exportDirectory_Ljava_io_File_;
		}

		static void n_ExportDirectory_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dir)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.FileResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_dir, JniHandleOwnership.DoNotTransfer);
			__this.ExportDirectory (dir);
		}
#pragma warning restore 0169

		/// <param name="dir">the directory to export. This directory must not itself be a
		///            git repository, but any directory below it which has a file
		///            named &lt;code&gt;git-daemon-export-ok&lt;/code&gt; will be published.</param>
		/// <summary>Recursively export all Git repositories within a directory.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/class[@name='FileResolver']/method[@name='exportDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("exportDirectory", "(Ljava/io/File;)V", "GetExportDirectory_Ljava_io_File_Handler")]
		public virtual unsafe void ExportDirectory (global::Java.IO.File dir)
		{
			const string __id = "exportDirectory.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dir);
			}
		}

		static Delegate cb_exportRepository_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_;
#pragma warning disable 0169
		static Delegate GetExportRepository_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_Handler ()
		{
			if (cb_exportRepository_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_ == null)
				cb_exportRepository_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ExportRepository_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_);
			return cb_exportRepository_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_;
		}

		static void n_ExportRepository_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_db)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.FileResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var db = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_db, JniHandleOwnership.DoNotTransfer);
			__this.ExportRepository (name, db);
		}
#pragma warning restore 0169

		/// <param name="name">name the repository will be published under.</param>
		/// <param name="db">the repository instance.</param>
		/// <summary>Add a single repository to the set that is exported by this daemon.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/class[@name='FileResolver']/method[@name='exportRepository' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("exportRepository", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/Repository;)V", "GetExportRepository_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_Handler")]
		public virtual unsafe void ExportRepository (string name, global::Org.Eclipse.Jgit.Lib.Repository db)
		{
			const string __id = "exportRepository.(Ljava/lang/String;Lorg/eclipse/jgit/lib/Repository;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (db);
			}
		}

		static Delegate cb_isExportOk_Ljava_lang_Object_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_;
#pragma warning disable 0169
		static Delegate GetIsExportOk_Ljava_lang_Object_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_Handler ()
		{
			if (cb_isExportOk_Ljava_lang_Object_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_ == null)
				cb_isExportOk_Ljava_lang_Object_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_IsExportOk_Ljava_lang_Object_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_);
			return cb_isExportOk_Ljava_lang_Object_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_;
		}

		static bool n_IsExportOk_Ljava_lang_Object_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_req, IntPtr native_repositoryName, IntPtr native_db)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.FileResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var req = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_req, JniHandleOwnership.DoNotTransfer);
			var repositoryName = JNIEnv.GetString (native_repositoryName, JniHandleOwnership.DoNotTransfer);
			var db = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_db, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsExportOk (req, repositoryName, db);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="req">the current HTTP request.</param>
		/// <param name="repositoryName">name of the repository, as present in the URL.</param>
		/// <param name="db">the opened repository instance.</param>
		/// <summary>Check if this repository can be served.</summary>
		/// <returns>true if the repository is accessible; false if not.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/class[@name='FileResolver']/method[@name='isExportOk' and count(parameter)=3 and parameter[1][@type='C'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("isExportOk", "(Ljava/lang/Object;Ljava/lang/String;Lorg/eclipse/jgit/lib/Repository;)Z", "GetIsExportOk_Ljava_lang_Object_Ljava_lang_String_Lorg_eclipse_jgit_lib_Repository_Handler")]
		protected virtual unsafe bool IsExportOk (global::Java.Lang.Object req, string repositoryName, global::Org.Eclipse.Jgit.Lib.Repository db)
		{
			const string __id = "isExportOk.(Ljava/lang/Object;Ljava/lang/String;Lorg/eclipse/jgit/lib/Repository;)Z";
			IntPtr native_req = JNIEnv.ToLocalJniHandle (req);
			IntPtr native_repositoryName = JNIEnv.NewString ((string)repositoryName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_req);
				__args [1] = new JniArgumentValue (native_repositoryName);
				__args [2] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_req);
				JNIEnv.DeleteLocalRef (native_repositoryName);
				global::System.GC.KeepAlive (req);
				global::System.GC.KeepAlive (db);
			}
		}

		static Delegate cb_open_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_open_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_open_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Open_Ljava_lang_Object_Ljava_lang_String_);
			return cb_open_Ljava_lang_Object_Ljava_lang_String_;
		}

		static IntPtr n_Open_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_req, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.FileResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var req = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_req, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (req, name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/class[@name='FileResolver']/method[@name='open' and count(parameter)=2 and parameter[1][@type='C'] and parameter[2][@type='java.lang.String']]"
		[Register ("open", "(Ljava/lang/Object;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Repository;", "GetOpen_Ljava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Open (global::Java.Lang.Object req, string name)
		{
			const string __id = "open.(Ljava/lang/Object;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Repository;";
			IntPtr native_req = JNIEnv.ToLocalJniHandle (req);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_req);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_req);
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (req);
			}
		}

	}
}
