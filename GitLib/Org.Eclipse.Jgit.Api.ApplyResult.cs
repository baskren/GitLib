using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Encapsulates the result of a <c>ApplyCommand</c></summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ApplyResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/ApplyResult", DoNotGenerateAcw=true)]
	public partial class ApplyResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/ApplyResult", typeof (ApplyResult));

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

		protected ApplyResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ApplyResult']/constructor[@name='ApplyResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApplyResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getUpdatedFiles;
#pragma warning disable 0169
		static Delegate GetGetUpdatedFilesHandler ()
		{
			if (cb_getUpdatedFiles == null)
				cb_getUpdatedFiles = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUpdatedFiles);
			return cb_getUpdatedFiles;
		}

		static IntPtr n_GetUpdatedFiles (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ApplyResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.IO.File>.ToLocalJniHandle (__this.UpdatedFiles);
		}
#pragma warning restore 0169

		/// <returns>updated files</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.IO.File> UpdatedFiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ApplyResult']/method[@name='getUpdatedFiles' and count(parameter)=0]"
			[Register ("getUpdatedFiles", "()Ljava/util/List;", "GetGetUpdatedFilesHandler")]
			get {
				const string __id = "getUpdatedFiles.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.IO.File>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addUpdatedFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetAddUpdatedFile_Ljava_io_File_Handler ()
		{
			if (cb_addUpdatedFile_Ljava_io_File_ == null)
				cb_addUpdatedFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddUpdatedFile_Ljava_io_File_);
			return cb_addUpdatedFile_Ljava_io_File_;
		}

		static IntPtr n_AddUpdatedFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ApplyResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_f, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddUpdatedFile (f));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="f">an updated file</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ApplyResult']/method[@name='addUpdatedFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("addUpdatedFile", "(Ljava/io/File;)Lorg/eclipse/jgit/api/ApplyResult;", "GetAddUpdatedFile_Ljava_io_File_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ApplyResult AddUpdatedFile (global::Java.IO.File f)
		{
			const string __id = "addUpdatedFile.(Ljava/io/File;)Lorg/eclipse/jgit/api/ApplyResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ApplyResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

	}
}
