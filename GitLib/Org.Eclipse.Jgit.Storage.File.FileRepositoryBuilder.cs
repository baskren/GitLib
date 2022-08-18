using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Storage.File {

	/// <summary>Constructs a <c>FileRepository</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileRepositoryBuilder']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/storage/file/FileRepositoryBuilder", DoNotGenerateAcw=true)]
	public partial class FileRepositoryBuilder : global::Org.Eclipse.Jgit.Lib.BaseRepositoryBuilder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/storage/file/FileRepositoryBuilder", typeof (FileRepositoryBuilder));

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

		protected FileRepositoryBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileRepositoryBuilder']/constructor[@name='FileRepositoryBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileRepositoryBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="gitDir">
		///   <c>GIT_DIR</c>, the repository meta directory.</param>
		/// <summary>Convenience factory method to construct a <c>FileRepository</c>.</summary>
		/// <returns>a repository matching this configuration.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.storage.file']/class[@name='FileRepositoryBuilder']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("create", "(Ljava/io/File;)Lorg/eclipse/jgit/lib/Repository;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.Repository Create (global::Java.IO.File gitDir)
		{
			const string __id = "create.(Ljava/io/File;)Lorg/eclipse/jgit/lib/Repository;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gitDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gitDir).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (gitDir);
			}
		}

	}
}
