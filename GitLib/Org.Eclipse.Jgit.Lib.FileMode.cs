using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Constants describing various file modes recognized by GIT.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/FileMode", DoNotGenerateAcw=true)]
	public abstract partial class FileMode : global::Java.Lang.Object {

		/// <summary>Mode indicating an entry is an executable file.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='EXECUTABLE_FILE']"
		[Register ("EXECUTABLE_FILE")]
		public static global::Org.Eclipse.Jgit.Lib.FileMode ExecutableFile {
			get {
				const string __id = "EXECUTABLE_FILE.Lorg/eclipse/jgit/lib/FileMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Mode indicating an entry is a submodule commit in another repository.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='GITLINK']"
		[Register ("GITLINK")]
		public static global::Org.Eclipse.Jgit.Lib.FileMode Gitlink {
			get {
				const string __id = "GITLINK.Lorg/eclipse/jgit/lib/FileMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Mode indicating an entry is missing during parallel walks.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='MISSING']"
		[Register ("MISSING")]
		public static global::Org.Eclipse.Jgit.Lib.FileMode Missing {
			get {
				const string __id = "MISSING.Lorg/eclipse/jgit/lib/FileMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Mode indicating an entry is a non-executable file.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='REGULAR_FILE']"
		[Register ("REGULAR_FILE")]
		public static global::Org.Eclipse.Jgit.Lib.FileMode RegularFile {
			get {
				const string __id = "REGULAR_FILE.Lorg/eclipse/jgit/lib/FileMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Mode indicating an entry is a symbolic link.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='SYMLINK']"
		[Register ("SYMLINK")]
		public static global::Org.Eclipse.Jgit.Lib.FileMode Symlink {
			get {
				const string __id = "SYMLINK.Lorg/eclipse/jgit/lib/FileMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Mode indicating an entry is a tree (aka directory).</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='TREE']"
		[Register ("TREE")]
		public static global::Org.Eclipse.Jgit.Lib.FileMode Tree {
			get {
				const string __id = "TREE.Lorg/eclipse/jgit/lib/FileMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>Bit pattern for <c>#TYPE_MASK</c> matching <c>#REGULAR_FILE</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='TYPE_FILE']"
		[Register ("TYPE_FILE")]
		public const int TypeFile = (int) 32768;

		/// <summary>Bit pattern for <c>#TYPE_MASK</c> matching <c>#GITLINK</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='TYPE_GITLINK']"
		[Register ("TYPE_GITLINK")]
		public const int TypeGitlink = (int) 57344;

		/// <summary>Mask to apply to a file mode to obtain its type bits.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='TYPE_MASK']"
		[Register ("TYPE_MASK")]
		public const int TypeMask = (int) 61440;

		/// <summary>Bit pattern for <c>#TYPE_MASK</c> matching <c>#MISSING</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='TYPE_MISSING']"
		[Register ("TYPE_MISSING")]
		public const int TypeMissing = (int) 0;

		/// <summary>Bit pattern for <c>#TYPE_MASK</c> matching <c>#SYMLINK</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='TYPE_SYMLINK']"
		[Register ("TYPE_SYMLINK")]
		public const int TypeSymlink = (int) 40960;

		/// <summary>Bit pattern for <c>#TYPE_MASK</c> matching <c>#TREE</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/field[@name='TYPE_TREE']"
		[Register ("TYPE_TREE")]
		public const int TypeTree = (int) 16384;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/FileMode", typeof (FileMode));

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

		protected FileMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getBits;
#pragma warning disable 0169
		static Delegate GetGetBitsHandler ()
		{
			if (cb_getBits == null)
				cb_getBits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBits);
			return cb_getBits;
		}

		static int n_GetBits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bits;
		}
#pragma warning restore 0169

		/// <returns>The mode bits as an integer.</returns>
		public virtual unsafe int Bits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/method[@name='getBits' and count(parameter)=0]"
			[Register ("getBits", "()I", "GetGetBitsHandler")]
			get {
				const string __id = "getBits.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getObjectType;
#pragma warning disable 0169
		static Delegate GetGetObjectTypeHandler ()
		{
			if (cb_getObjectType == null)
				cb_getObjectType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetObjectType);
			return cb_getObjectType;
		}

		static int n_GetObjectType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectType;
		}
#pragma warning restore 0169

		/// <summary>Get the object type that should appear for this type of mode.</summary>
		/// <returns>one of the well known object type constants.</returns>
		public virtual unsafe int ObjectType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/method[@name='getObjectType' and count(parameter)=0]"
			[Register ("getObjectType", "()I", "GetGetObjectTypeHandler")]
			get {
				const string __id = "getObjectType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_copyTo_arrayBI;
#pragma warning disable 0169
		static Delegate GetCopyTo_arrayBIHandler ()
		{
			if (cb_copyTo_arrayBI == null)
				cb_copyTo_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_CopyTo_arrayBI);
			return cb_copyTo_arrayBI;
		}

		static void n_CopyTo_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, int ptr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = (byte[]) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CopyTo (buf, ptr);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		/// <param name="buf">buffer to copy the mode to.</param>
		/// <param name="ptr">position within <c>buf</c> for first digit.</param>
		/// <summary>Copy this mode as a sequence of octal US-ASCII bytes.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/method[@name='copyTo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("copyTo", "([BI)V", "GetCopyTo_arrayBIHandler")]
		public virtual unsafe void CopyTo (byte[] buf, int ptr)
		{
			const string __id = "copyTo.([BI)V";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (ptr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

		static Delegate cb_copyTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetCopyTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_copyTo_Ljava_io_OutputStream_ == null)
				cb_copyTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CopyTo_Ljava_io_OutputStream_);
			return cb_copyTo_Ljava_io_OutputStream_;
		}

		static void n_CopyTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_os)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var os = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_os, JniHandleOwnership.DoNotTransfer);
			__this.CopyTo (os);
		}
#pragma warning restore 0169

		/// <param name="os">stream to copy the mode to.</param>
		/// <summary>Copy this mode as a sequence of octal US-ASCII bytes.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/method[@name='copyTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("copyTo", "(Ljava/io/OutputStream;)V", "GetCopyTo_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void CopyTo (global::System.IO.Stream os)
		{
			const string __id = "copyTo.(Ljava/io/OutputStream;)V";
			IntPtr native_os = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (os);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_os);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_os);
				global::System.GC.KeepAlive (os);
			}
		}

		static Delegate cb_copyToLength;
#pragma warning disable 0169
		static Delegate GetCopyToLengthHandler ()
		{
			if (cb_copyToLength == null)
				cb_copyToLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_CopyToLength);
			return cb_copyToLength;
		}

		static int n_CopyToLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CopyToLength ();
		}
#pragma warning restore 0169

		/// <returns>the number of bytes written by <c>#copyTo(OutputStream)</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/method[@name='copyToLength' and count(parameter)=0]"
		[Register ("copyToLength", "()I", "GetCopyToLengthHandler")]
		public virtual unsafe int CopyToLength ()
		{
			const string __id = "copyToLength.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_equals_I;
#pragma warning disable 0169
		static Delegate GetEquals_IHandler ()
		{
			if (cb_equals_I == null)
				cb_equals_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_Equals_I);
			return cb_equals_I;
		}

		static bool n_Equals_I (IntPtr jnienv, IntPtr native__this, int modebits)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Equals (modebits);
		}
#pragma warning restore 0169

		/// <param name="modebits">modebits</param>
		/// <summary>Test a file mode for equality with this <c>FileMode</c> object.</summary>
		/// <returns>true if the mode bits represent the same mode as this object</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("equals", "(I)Z", "GetEquals_IHandler")]
		public abstract bool Equals (int modebits);

		/// <param name="bits">the mode bits the caller has somehow obtained.</param>
		/// <summary>Convert a set of mode bits into a FileMode enumerated value.</summary>
		/// <returns>the FileMode instance that represents the given bits.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/method[@name='fromBits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromBits", "(I)Lorg/eclipse/jgit/lib/FileMode;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.FileMode FromBits (int bits)
		{
			const string __id = "fromBits.(I)Lorg/eclipse/jgit/lib/FileMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bits);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/FileMode", DoNotGenerateAcw=true)]
	internal partial class FileModeInvoker : FileMode {
		public FileModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/FileMode", typeof (FileModeInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		/// <param name="modebits">modebits</param>
		/// <summary>Test a file mode for equality with this <c>FileMode</c> object.</summary>
		/// <returns>true if the mode bits represent the same mode as this object</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileMode']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("equals", "(I)Z", "GetEquals_IHandler")]
		public override unsafe bool Equals (int modebits)
		{
			const string __id = "equals.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (modebits);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
