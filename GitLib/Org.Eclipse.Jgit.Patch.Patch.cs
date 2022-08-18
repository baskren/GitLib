using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Patch {

	/// <summary>A parsed collection of <c>FileHeader</c>s from a unified diff patch file</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='Patch']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/patch/Patch", DoNotGenerateAcw=true)]
	public partial class Patch : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/Patch", typeof (Patch));

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

		protected Patch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty patch.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='Patch']/constructor[@name='Patch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Patch () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getErrors;
#pragma warning disable 0169
		static Delegate GetGetErrorsHandler ()
		{
			if (cb_getErrors == null)
				cb_getErrors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrors);
			return cb_getErrors;
		}

		static IntPtr n_GetErrors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Patch.FormatError>.ToLocalJniHandle (__this.Errors);
		}
#pragma warning restore 0169

		/// <returns>collection of formatting errors, if any.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Patch.FormatError> Errors {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='Patch']/method[@name='getErrors' and count(parameter)=0]"
			[Register ("getErrors", "()Ljava/util/List;", "GetGetErrorsHandler")]
			get {
				const string __id = "getErrors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Patch.FormatError>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFiles;
#pragma warning disable 0169
		static Delegate GetGetFilesHandler ()
		{
			if (cb_getFiles == null)
				cb_getFiles = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFiles);
			return cb_getFiles;
		}

		static IntPtr n_GetFiles (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Patch.FileHeader>.ToLocalJniHandle (__this.Files);
		}
#pragma warning restore 0169

		/// <returns>list of files described in the patch, in occurrence order.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Patch.FileHeader> Files {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='Patch']/method[@name='getFiles' and count(parameter)=0]"
			[Register ("getFiles", "()Ljava/util/List;", "GetGetFilesHandler")]
			get {
				const string __id = "getFiles.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Patch.FileHeader>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addError_Lorg_eclipse_jgit_patch_FormatError_;
#pragma warning disable 0169
		static Delegate GetAddError_Lorg_eclipse_jgit_patch_FormatError_Handler ()
		{
			if (cb_addError_Lorg_eclipse_jgit_patch_FormatError_ == null)
				cb_addError_Lorg_eclipse_jgit_patch_FormatError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddError_Lorg_eclipse_jgit_patch_FormatError_);
			return cb_addError_Lorg_eclipse_jgit_patch_FormatError_;
		}

		static void n_AddError_Lorg_eclipse_jgit_patch_FormatError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_err)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var err = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError> (native_err, JniHandleOwnership.DoNotTransfer);
			__this.AddError (err);
		}
#pragma warning restore 0169

		/// <param name="err">the error description.</param>
		/// <summary>Add a formatting error to this patch script.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='Patch']/method[@name='addError' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.patch.FormatError']]"
		[Register ("addError", "(Lorg/eclipse/jgit/patch/FormatError;)V", "GetAddError_Lorg_eclipse_jgit_patch_FormatError_Handler")]
		public virtual unsafe void AddError (global::Org.Eclipse.Jgit.Patch.FormatError err)
		{
			const string __id = "addError.(Lorg/eclipse/jgit/patch/FormatError;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((err == null) ? IntPtr.Zero : ((global::Java.Lang.Object) err).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (err);
			}
		}

		static Delegate cb_addFile_Lorg_eclipse_jgit_patch_FileHeader_;
#pragma warning disable 0169
		static Delegate GetAddFile_Lorg_eclipse_jgit_patch_FileHeader_Handler ()
		{
			if (cb_addFile_Lorg_eclipse_jgit_patch_FileHeader_ == null)
				cb_addFile_Lorg_eclipse_jgit_patch_FileHeader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddFile_Lorg_eclipse_jgit_patch_FileHeader_);
			return cb_addFile_Lorg_eclipse_jgit_patch_FileHeader_;
		}

		static void n_AddFile_Lorg_eclipse_jgit_patch_FileHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fh)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fh = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (native_fh, JniHandleOwnership.DoNotTransfer);
			__this.AddFile (fh);
		}
#pragma warning restore 0169

		/// <param name="fh">the header of the file.</param>
		/// <summary>Add a single file to this patch.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='Patch']/method[@name='addFile' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.patch.FileHeader']]"
		[Register ("addFile", "(Lorg/eclipse/jgit/patch/FileHeader;)V", "GetAddFile_Lorg_eclipse_jgit_patch_FileHeader_Handler")]
		public virtual unsafe void AddFile (global::Org.Eclipse.Jgit.Patch.FileHeader fh)
		{
			const string __id = "addFile.(Lorg/eclipse/jgit/patch/FileHeader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fh == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fh).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (fh);
			}
		}

		static Delegate cb_parse_arrayBII;
#pragma warning disable 0169
		static Delegate GetParse_arrayBIIHandler ()
		{
			if (cb_parse_arrayBII == null)
				cb_parse_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_Parse_arrayBII);
			return cb_parse_arrayBII;
		}

		static void n_Parse_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, int ptr, int end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = (byte[]) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Parse (buf, ptr, end);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		/// <param name="buf">the buffer to parse.</param>
		/// <param name="ptr">starting position to parse from.</param>
		/// <param name="end">1 past the last position to end parsing. The total length to
		///            be parsed is &lt;code&gt;end - ptr&lt;/code&gt;.</param>
		/// <summary>Parse a patch stored in a byte[].</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='Patch']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("parse", "([BII)V", "GetParse_arrayBIIHandler")]
		public virtual unsafe void Parse (byte[] buf, int ptr, int end)
		{
			const string __id = "parse.([BII)V";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (end);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

		static Delegate cb_parse_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_io_InputStream_Handler ()
		{
			if (cb_parse_Ljava_io_InputStream_ == null)
				cb_parse_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Parse_Ljava_io_InputStream_);
			return cb_parse_Ljava_io_InputStream_;
		}

		static void n_Parse_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__is)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.Patch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @is = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__is, JniHandleOwnership.DoNotTransfer);
			__this.Parse (@is);
		}
#pragma warning restore 0169

		/// <param name="is">the stream to read the patch data from. The stream is read
		///            until EOF is reached.</param>
		/// <summary>Parse a patch received from an InputStream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='Patch']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("parse", "(Ljava/io/InputStream;)V", "GetParse_Ljava_io_InputStream_Handler")]
		public virtual unsafe void Parse (global::System.IO.Stream @is)
		{
			const string __id = "parse.(Ljava/io/InputStream;)V";
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__is);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
				global::System.GC.KeepAlive (@is);
			}
		}

	}
}
