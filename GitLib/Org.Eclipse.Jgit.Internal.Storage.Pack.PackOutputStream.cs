using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>Custom output stream to support <c>PackWriter</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackOutputStream']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/PackOutputStream", DoNotGenerateAcw=true)]
	public sealed partial class PackOutputStream : global::Java.IO.OutputStream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/PackOutputStream", typeof (PackOutputStream));

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

		internal PackOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="writeMonitor">monitor to update on object output progress.</param>
		/// <param name="out">target stream to receive all object contents.</param>
		/// <param name="pw">packer that is going to perform the output.</param>
		/// <summary>Initialize a pack output stream.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackOutputStream']/constructor[@name='PackOutputStream' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='org.eclipse.jgit.internal.storage.pack.PackWriter']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/io/OutputStream;Lorg/eclipse/jgit/internal/storage/pack/PackWriter;)V", "")]
		public unsafe PackOutputStream (global::Org.Eclipse.Jgit.Lib.IProgressMonitor writeMonitor, global::System.IO.Stream @out, global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter pw) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/io/OutputStream;Lorg/eclipse/jgit/internal/storage/pack/PackWriter;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((writeMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writeMonitor).Handle);
				__args [1] = new JniArgumentValue (native__out);
				__args [2] = new JniArgumentValue ((pw == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pw).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (writeMonitor);
				global::System.GC.KeepAlive (@out);
				global::System.GC.KeepAlive (pw);
			}
		}

		/// <returns>a temporary buffer writers can use to copy data with.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackOutputStream']/method[@name='getCopyBuffer' and count(parameter)=0]"
		[Register ("getCopyBuffer", "()[B", "")]
		public unsafe byte[] GetCopyBuffer ()
		{
			const string __id = "getCopyBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		/// <returns>total number of bytes written since stream start.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackOutputStream']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "")]
		public unsafe long Length ()
		{
			const string __id = "length.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackOutputStream']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([BII)V", "")]
		public override sealed unsafe void Write (byte[] b, int off, int len)
		{
			const string __id = "write.([BII)V";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue (off);
				__args [2] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (b);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write", "(I)V", "")]
		public override sealed unsafe void Write (int b)
		{
			const string __id = "write.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <param name="otp">the object to pack. Header information is obtained.</param>
		/// <param name="rawLength">number of bytes of the inflated content. For an object that is
		///            in whole object format, this is the same as the object size.
		///            For an object that is in a delta format, this is the size of
		///            the inflated delta instruction stream.</param>
		/// <summary>Commits the object header onto the stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackOutputStream']/method[@name='writeHeader' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.ObjectToPack'] and parameter[2][@type='long']]"
		[Register ("writeHeader", "(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;J)V", "")]
		public unsafe void WriteHeader (global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack otp, long rawLength)
		{
			const string __id = "writeHeader.(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((otp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) otp).Handle);
				__args [1] = new JniArgumentValue (rawLength);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (otp);
			}
		}

		/// <param name="otp">the object to write.</param>
		/// <summary>Write one object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackOutputStream']/method[@name='writeObject' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.ObjectToPack']]"
		[Register ("writeObject", "(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;)V", "")]
		public unsafe void WriteObject (global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack otp)
		{
			const string __id = "writeObject.(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((otp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) otp).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (otp);
			}
		}

	}
}
