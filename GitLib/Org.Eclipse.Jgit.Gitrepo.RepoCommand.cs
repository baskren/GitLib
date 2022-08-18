using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Gitrepo {

	/// <summary>A class used to execute a repo command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/gitrepo/RepoCommand", DoNotGenerateAcw=true)]
	public partial class RepoCommand : global::Org.Eclipse.Jgit.Api.GitCommand {
		/// <summary>A default implementation of <c>RemoteReader</c> callback.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand.DefaultRemoteReader']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/gitrepo/RepoCommand$DefaultRemoteReader", DoNotGenerateAcw=true)]
		public partial class DefaultRemoteReader : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IRemoteReader {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/gitrepo/RepoCommand$DefaultRemoteReader", typeof (DefaultRemoteReader));

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

			protected DefaultRemoteReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand.DefaultRemoteReader']/constructor[@name='RepoCommand.DefaultRemoteReader' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DefaultRemoteReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetReadFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_ReadFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
				return cb_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_ReadFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native__ref, IntPtr native_path)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.DefaultRemoteReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
				var @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
				var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.ReadFile (uri, @ref, path));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand.DefaultRemoteReader']/method[@name='readFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("readFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)[B", "GetReadFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe byte[] ReadFile (string uri, string @ref, string path)
			{
				const string __id = "readFile.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)[B";
				IntPtr native_uri = JNIEnv.NewString ((string)uri);
				IntPtr native__ref = JNIEnv.NewString ((string)@ref);
				IntPtr native_path = JNIEnv.NewString ((string)path);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_uri);
					__args [1] = new JniArgumentValue (native__ref);
					__args [2] = new JniArgumentValue (native_path);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native_uri);
					JNIEnv.DeleteLocalRef (native__ref);
					JNIEnv.DeleteLocalRef (native_path);
				}
			}

			static Delegate cb_readFileFromRepo_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetReadFileFromRepo_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_readFileFromRepo_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_readFileFromRepo_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_ReadFileFromRepo_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Ljava_lang_String_);
				return cb_readFileFromRepo_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_ReadFileFromRepo_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repo, IntPtr native__ref, IntPtr native_path)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.DefaultRemoteReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var repo = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repo, JniHandleOwnership.DoNotTransfer);
				var @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
				var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.ReadFileFromRepo (repo, @ref, path));
				return __ret;
			}
#pragma warning restore 0169

			/// <param name="repo">The repository containing the file</param>
			/// <param name="ref">The ref (branch/tag/etc.) to read</param>
			/// <param name="path">The relative path (inside the repo) to the file to read</param>
			/// <summary>Read a file from the repository</summary>
			/// <returns>the file's content</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand.DefaultRemoteReader']/method[@name='readFileFromRepo' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("readFileFromRepo", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Ljava/lang/String;)[B", "GetReadFileFromRepo_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Ljava_lang_String_Handler")]
			protected virtual unsafe byte[] ReadFileFromRepo (global::Org.Eclipse.Jgit.Lib.Repository repo, string @ref, string path)
			{
				const string __id = "readFileFromRepo.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Ljava/lang/String;)[B";
				IntPtr native__ref = JNIEnv.NewString ((string)@ref);
				IntPtr native_path = JNIEnv.NewString ((string)path);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
					__args [1] = new JniArgumentValue (native__ref);
					__args [2] = new JniArgumentValue (native_path);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					JNIEnv.DeleteLocalRef (native__ref);
					JNIEnv.DeleteLocalRef (native_path);
					global::System.GC.KeepAlive (repo);
				}
			}

			static Delegate cb_sha1_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSha1_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_sha1_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_sha1_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Sha1_Ljava_lang_String_Ljava_lang_String_);
				return cb_sha1_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_Sha1_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native__ref)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.DefaultRemoteReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
				var @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sha1 (uri, @ref));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand.DefaultRemoteReader']/method[@name='sha1' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("sha1", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;", "GetSha1_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Sha1 (string uri, string @ref)
			{
				const string __id = "sha1.(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;";
				IntPtr native_uri = JNIEnv.NewString ((string)uri);
				IntPtr native__ref = JNIEnv.NewString ((string)@ref);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_uri);
					__args [1] = new JniArgumentValue (native__ref);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_uri);
					JNIEnv.DeleteLocalRef (native__ref);
				}
			}

		}

		/// <summary>A callback to read included xml files.</summary>
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/interface[@name='RepoCommand.IncludedFileReader']"
		[Register ("org/eclipse/jgit/gitrepo/RepoCommand$IncludedFileReader", "", "Org.Eclipse.Jgit.Gitrepo.RepoCommand/IIncludedFileReaderInvoker")]
		public partial interface IIncludedFileReader : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/interface[@name='RepoCommand.IncludedFileReader']/method[@name='readIncludeFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			/// <param name="path">The relative path to the file to read</param>
			/// <summary>Read a file from the same base dir of the manifest xml file.</summary>
			/// <returns>the <c>InputStream</c> of the file.</returns>
			[Register ("readIncludeFile", "(Ljava/lang/String;)Ljava/io/InputStream;", "GetReadIncludeFile_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Gitrepo.RepoCommand/IIncludedFileReaderInvoker, AndroidBindableLibrary")]
			global::System.IO.Stream ReadIncludeFile (string path);

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/gitrepo/RepoCommand$IncludedFileReader", DoNotGenerateAcw=true)]
		internal partial class IIncludedFileReaderInvoker : global::Java.Lang.Object, IIncludedFileReader {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/gitrepo/RepoCommand$IncludedFileReader", typeof (IIncludedFileReaderInvoker));

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

			public static IIncludedFileReader GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IIncludedFileReader> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.gitrepo.RepoCommand.IncludedFileReader'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IIncludedFileReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_readIncludeFile_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetReadIncludeFile_Ljava_lang_String_Handler ()
			{
				if (cb_readIncludeFile_Ljava_lang_String_ == null)
					cb_readIncludeFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReadIncludeFile_Ljava_lang_String_);
				return cb_readIncludeFile_Ljava_lang_String_;
			}

			static IntPtr n_ReadIncludeFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IIncludedFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.ReadIncludeFile (path));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_readIncludeFile_Ljava_lang_String_;
			public unsafe global::System.IO.Stream ReadIncludeFile (string path)
			{
				if (id_readIncludeFile_Ljava_lang_String_ == IntPtr.Zero)
					id_readIncludeFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readIncludeFile", "(Ljava/lang/String;)Ljava/io/InputStream;");
				IntPtr native_path = JNIEnv.NewString ((string)path);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_path);
				var __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readIncludeFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_path);
				return __ret;
			}

		}

		/// <summary>A callback to get ref sha1 of a repository from its uri.</summary>
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/interface[@name='RepoCommand.RemoteReader']"
		[Register ("org/eclipse/jgit/gitrepo/RepoCommand$RemoteReader", "", "Org.Eclipse.Jgit.Gitrepo.RepoCommand/IRemoteReaderInvoker")]
		public partial interface IRemoteReader : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/interface[@name='RepoCommand.RemoteReader']/method[@name='readFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			/// <param name="uri">The URI of the remote repository</param>
			/// <param name="ref">The ref (branch/tag/etc.) to read</param>
			/// <param name="path">The relative path (inside the repo) to the file to read</param>
			/// <summary>Read a file from a remote repository.</summary>
			/// <returns>the file content.</returns>
			[Register ("readFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)[B", "GetReadFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Gitrepo.RepoCommand/IRemoteReaderInvoker, AndroidBindableLibrary")]
			byte[] ReadFile (string uri, string @ref, string path);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/interface[@name='RepoCommand.RemoteReader']/method[@name='sha1' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			/// <param name="uri">The URI of the remote repository</param>
			/// <param name="ref">The ref (branch/tag/etc.) to read</param>
			/// <summary>Read a remote ref sha1.</summary>
			/// <returns>the sha1 of the remote repository</returns>
			[Register ("sha1", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;", "GetSha1_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Gitrepo.RepoCommand/IRemoteReaderInvoker, AndroidBindableLibrary")]
			global::Org.Eclipse.Jgit.Lib.ObjectId Sha1 (string uri, string @ref);

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/gitrepo/RepoCommand$RemoteReader", DoNotGenerateAcw=true)]
		internal partial class IRemoteReaderInvoker : global::Java.Lang.Object, IRemoteReader {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/gitrepo/RepoCommand$RemoteReader", typeof (IRemoteReaderInvoker));

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

			public static IRemoteReader GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRemoteReader> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.gitrepo.RepoCommand.RemoteReader'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRemoteReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetReadFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_ReadFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
				return cb_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_ReadFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native__ref, IntPtr native_path)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IRemoteReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
				var @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
				var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.ReadFile (uri, @ref, path));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			public unsafe byte[] ReadFile (string uri, string @ref, string path)
			{
				if (id_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)[B");
				IntPtr native_uri = JNIEnv.NewString ((string)uri);
				IntPtr native__ref = JNIEnv.NewString ((string)@ref);
				IntPtr native_path = JNIEnv.NewString ((string)path);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_uri);
				__args [1] = new JValue (native__ref);
				__args [2] = new JValue (native_path);
				var __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readFile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				JNIEnv.DeleteLocalRef (native_uri);
				JNIEnv.DeleteLocalRef (native__ref);
				JNIEnv.DeleteLocalRef (native_path);
				return __ret;
			}

			static Delegate cb_sha1_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSha1_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_sha1_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_sha1_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Sha1_Ljava_lang_String_Ljava_lang_String_);
				return cb_sha1_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_Sha1_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native__ref)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IRemoteReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
				var @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sha1 (uri, @ref));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_sha1_Ljava_lang_String_Ljava_lang_String_;
			public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Sha1 (string uri, string @ref)
			{
				if (id_sha1_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_sha1_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sha1", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;");
				IntPtr native_uri = JNIEnv.NewString ((string)uri);
				IntPtr native__ref = JNIEnv.NewString ((string)@ref);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_uri);
				__args [1] = new JValue (native__ref);
				var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sha1_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_uri);
				JNIEnv.DeleteLocalRef (native__ref);
				return __ret;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/gitrepo/RepoCommand", typeof (RepoCommand));

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

		protected RepoCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/constructor[@name='RepoCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe RepoCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/revwalk/RevCommit;", "GetCallHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setAuthor_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static IntPtr n_SetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_author)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var author = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_author, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAuthor (author));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="author">author</param>
		/// <summary>Set the author/committer for the bare repository commit.</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='setAuthor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
		[Register ("setAuthor", "(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/gitrepo/RepoCommand;", "GetSetAuthor_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Gitrepo.RepoCommand SetAuthor (global::Org.Eclipse.Jgit.Lib.PersonIdent author)
		{
			const string __id = "setAuthor.(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/gitrepo/RepoCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((author == null) ? IntPtr.Zero : ((global::Java.Lang.Object) author).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (author);
			}
		}

		static Delegate cb_setBranch_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBranch_Ljava_lang_String_Handler ()
		{
			if (cb_setBranch_Ljava_lang_String_ == null)
				cb_setBranch_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetBranch_Ljava_lang_String_);
			return cb_setBranch_Ljava_lang_String_;
		}

		static IntPtr n_SetBranch_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_branch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var branch = JNIEnv.GetString (native_branch, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBranch (branch));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="branch">branch</param>
		/// <summary>Set default branch.</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='setBranch' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBranch", "(Ljava/lang/String;)Lorg/eclipse/jgit/gitrepo/RepoCommand;", "GetSetBranch_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Gitrepo.RepoCommand SetBranch (string branch)
		{
			const string __id = "setBranch.(Ljava/lang/String;)Lorg/eclipse/jgit/gitrepo/RepoCommand;";
			IntPtr native_branch = JNIEnv.NewString ((string)branch);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_branch);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_branch);
			}
		}

		static Delegate cb_setGroups_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGroups_Ljava_lang_String_Handler ()
		{
			if (cb_setGroups_Ljava_lang_String_ == null)
				cb_setGroups_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetGroups_Ljava_lang_String_);
			return cb_setGroups_Ljava_lang_String_;
		}

		static IntPtr n_SetGroups_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_groups)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var groups = JNIEnv.GetString (native_groups, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGroups (groups));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="groups">groups separated by comma, examples: default|all|G1,-G2,-G3</param>
		/// <summary>Set groups to sync</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='setGroups' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setGroups", "(Ljava/lang/String;)Lorg/eclipse/jgit/gitrepo/RepoCommand;", "GetSetGroups_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Gitrepo.RepoCommand SetGroups (string groups)
		{
			const string __id = "setGroups.(Ljava/lang/String;)Lorg/eclipse/jgit/gitrepo/RepoCommand;";
			IntPtr native_groups = JNIEnv.NewString ((string)groups);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_groups);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_groups);
			}
		}

		static Delegate cb_setIncludedFileReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_IncludedFileReader_;
#pragma warning disable 0169
		static Delegate GetSetIncludedFileReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_IncludedFileReader_Handler ()
		{
			if (cb_setIncludedFileReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_IncludedFileReader_ == null)
				cb_setIncludedFileReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_IncludedFileReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetIncludedFileReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_IncludedFileReader_);
			return cb_setIncludedFileReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_IncludedFileReader_;
		}

		static IntPtr n_SetIncludedFileReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_IncludedFileReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = (global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IIncludedFileReader)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IIncludedFileReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIncludedFileReader (reader));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='setIncludedFileReader' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.gitrepo.RepoCommand.IncludedFileReader']]"
		[Register ("setIncludedFileReader", "(Lorg/eclipse/jgit/gitrepo/RepoCommand$IncludedFileReader;)Lorg/eclipse/jgit/gitrepo/RepoCommand;", "GetSetIncludedFileReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_IncludedFileReader_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Gitrepo.RepoCommand SetIncludedFileReader (global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IIncludedFileReader reader)
		{
			const string __id = "setIncludedFileReader.(Lorg/eclipse/jgit/gitrepo/RepoCommand$IncludedFileReader;)Lorg/eclipse/jgit/gitrepo/RepoCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		static Delegate cb_setInputStream_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetInputStream_Ljava_io_InputStream_Handler ()
		{
			if (cb_setInputStream_Ljava_io_InputStream_ == null)
				cb_setInputStream_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetInputStream_Ljava_io_InputStream_);
			return cb_setInputStream_Ljava_io_InputStream_;
		}

		static IntPtr n_SetInputStream_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_inputStream, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInputStream (inputStream));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="inputStream">inputStream</param>
		/// <summary>Set the input stream to the manifest XML.</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='setInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("setInputStream", "(Ljava/io/InputStream;)Lorg/eclipse/jgit/gitrepo/RepoCommand;", "GetSetInputStream_Ljava_io_InputStream_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Gitrepo.RepoCommand SetInputStream (global::System.IO.Stream inputStream)
		{
			const string __id = "setInputStream.(Ljava/io/InputStream;)Lorg/eclipse/jgit/gitrepo/RepoCommand;";
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputStream);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
				global::System.GC.KeepAlive (inputStream);
			}
		}

		static Delegate cb_setPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPath_Ljava_lang_String_Handler ()
		{
			if (cb_setPath_Ljava_lang_String_ == null)
				cb_setPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPath_Ljava_lang_String_);
			return cb_setPath_Ljava_lang_String_;
		}

		static IntPtr n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPath (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">(with &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>Set path to the manifest XML file.</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPath", "(Ljava/lang/String;)Lorg/eclipse/jgit/gitrepo/RepoCommand;", "GetSetPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Gitrepo.RepoCommand SetPath (string path)
		{
			const string __id = "setPath.(Ljava/lang/String;)Lorg/eclipse/jgit/gitrepo/RepoCommand;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (monitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">monitor</param>
		/// <summary>The progress monitor associated with the clone operation.</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/gitrepo/RepoCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Gitrepo.RepoCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/gitrepo/RepoCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (monitor);
			}
		}

		static Delegate cb_setRemoteReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_RemoteReader_;
#pragma warning disable 0169
		static Delegate GetSetRemoteReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_RemoteReader_Handler ()
		{
			if (cb_setRemoteReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_RemoteReader_ == null)
				cb_setRemoteReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_RemoteReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRemoteReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_RemoteReader_);
			return cb_setRemoteReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_RemoteReader_;
		}

		static IntPtr n_SetRemoteReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_RemoteReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IRemoteReader)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IRemoteReader> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRemoteReader (@callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='setRemoteReader' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.gitrepo.RepoCommand.RemoteReader']]"
		[Register ("setRemoteReader", "(Lorg/eclipse/jgit/gitrepo/RepoCommand$RemoteReader;)Lorg/eclipse/jgit/gitrepo/RepoCommand;", "GetSetRemoteReader_Lorg_eclipse_jgit_gitrepo_RepoCommand_RemoteReader_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Gitrepo.RepoCommand SetRemoteReader (global::Org.Eclipse.Jgit.Gitrepo.RepoCommand.IRemoteReader @callback)
		{
			const string __id = "setRemoteReader.(Lorg/eclipse/jgit/gitrepo/RepoCommand$RemoteReader;)Lorg/eclipse/jgit/gitrepo/RepoCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setURI_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetURI_Ljava_lang_String_Handler ()
		{
			if (cb_setURI_Ljava_lang_String_ == null)
				cb_setURI_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetURI_Ljava_lang_String_);
			return cb_setURI_Ljava_lang_String_;
		}

		static IntPtr n_SetURI_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetURI (uri));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uri">uri</param>
		/// <summary>Set base URI of the pathes inside the XML</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo']/class[@name='RepoCommand']/method[@name='setURI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setURI", "(Ljava/lang/String;)Lorg/eclipse/jgit/gitrepo/RepoCommand;", "GetSetURI_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Gitrepo.RepoCommand SetURI (string uri)
		{
			const string __id = "setURI.(Ljava/lang/String;)Lorg/eclipse/jgit/gitrepo/RepoCommand;";
			IntPtr native_uri = JNIEnv.NewString ((string)uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.RepoCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

	}
}
