using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Gitrepo.Internal {

	/// <summary>Translation bundle for repo command</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/gitrepo/internal/RepoText", DoNotGenerateAcw=true)]
	public partial class RepoText : global::Org.Eclipse.Jgit.Nls.TranslationBundle {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/field[@name='copyFileFailed']"
		[Register ("copyFileFailed")]
		public string CopyFileFailed {
			get {
				const string __id = "copyFileFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "copyFileFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/field[@name='errorIncludeFile']"
		[Register ("errorIncludeFile")]
		public string ErrorIncludeFile {
			get {
				const string __id = "errorIncludeFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorIncludeFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/field[@name='errorIncludeNotImplemented']"
		[Register ("errorIncludeNotImplemented")]
		public string ErrorIncludeNotImplemented {
			get {
				const string __id = "errorIncludeNotImplemented.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorIncludeNotImplemented.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/field[@name='errorNoDefault']"
		[Register ("errorNoDefault")]
		public string ErrorNoDefault {
			get {
				const string __id = "errorNoDefault.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorNoDefault.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/field[@name='errorNoDefaultFilename']"
		[Register ("errorNoDefaultFilename")]
		public string ErrorNoDefaultFilename {
			get {
				const string __id = "errorNoDefaultFilename.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorNoDefaultFilename.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/field[@name='errorParsingManifestFile']"
		[Register ("errorParsingManifestFile")]
		public string ErrorParsingManifestFile {
			get {
				const string __id = "errorParsingManifestFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorParsingManifestFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/field[@name='errorRemoteUnavailable']"
		[Register ("errorRemoteUnavailable")]
		public string ErrorRemoteUnavailable {
			get {
				const string __id = "errorRemoteUnavailable.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorRemoteUnavailable.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/field[@name='invalidManifest']"
		[Register ("invalidManifest")]
		public string InvalidManifest {
			get {
				const string __id = "invalidManifest.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidManifest.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/field[@name='repoCommitMessage']"
		[Register ("repoCommitMessage")]
		public string RepoCommitMessage {
			get {
				const string __id = "repoCommitMessage.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repoCommitMessage.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/gitrepo/internal/RepoText", typeof (RepoText));

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

		protected RepoText (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/constructor[@name='RepoText' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RepoText () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <returns>an instance of this translation bundle</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.gitrepo.internal']/class[@name='RepoText']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lorg/eclipse/jgit/gitrepo/internal/RepoText;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Gitrepo.Internal.RepoText Get ()
		{
			const string __id = "get.()Lorg/eclipse/jgit/gitrepo/internal/RepoText;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Gitrepo.Internal.RepoText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
