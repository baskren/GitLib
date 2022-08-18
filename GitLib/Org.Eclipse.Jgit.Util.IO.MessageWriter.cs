using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util.IO {

	/// <summary>Combines messages from an OutputStream (hopefully in UTF-8) and a Writer.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='MessageWriter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/io/MessageWriter", DoNotGenerateAcw=true)]
	public partial class MessageWriter : global::Java.IO.Writer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/io/MessageWriter", typeof (MessageWriter));

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

		protected MessageWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty writer.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='MessageWriter']/constructor[@name='MessageWriter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageWriter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getRawStream;
#pragma warning disable 0169
		static Delegate GetGetRawStreamHandler ()
		{
			if (cb_getRawStream == null)
				cb_getRawStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawStream);
			return cb_getRawStream;
		}

		static IntPtr n_GetRawStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.MessageWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.RawStream);
		}
#pragma warning restore 0169

		/// <returns>the underlying byte stream that character writes to this writer
		///         drop into. Writes to this stream should should be in UTF-8.</returns>
		public virtual unsafe global::System.IO.Stream RawStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='MessageWriter']/method[@name='getRawStream' and count(parameter)=0]"
			[Register ("getRawStream", "()Ljava/io/OutputStream;", "GetGetRawStreamHandler")]
			get {
				const string __id = "getRawStream.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.MessageWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='MessageWriter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.MessageWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='MessageWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public override unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_write_arrayCII;
#pragma warning disable 0169
		static Delegate GetWrite_arrayCIIHandler ()
		{
			if (cb_write_arrayCII == null)
				cb_write_arrayCII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_Write_arrayCII);
			return cb_write_arrayCII;
		}

		static void n_Write_arrayCII (IntPtr jnienv, IntPtr native__this, IntPtr native_cbuf, int off, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IO.MessageWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cbuf = (char[]) JNIEnv.GetArray (native_cbuf, JniHandleOwnership.DoNotTransfer, typeof (char));
			__this.Write (cbuf, off, len);
			if (cbuf != null)
				JNIEnv.CopyArray (cbuf, native_cbuf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util.io']/class[@name='MessageWriter']/method[@name='write' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([CII)V", "GetWrite_arrayCIIHandler")]
		public override unsafe void Write (char[] cbuf, int off, int len)
		{
			const string __id = "write.([CII)V";
			IntPtr native_cbuf = JNIEnv.NewArray (cbuf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_cbuf);
				__args [1] = new JniArgumentValue (off);
				__args [2] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (cbuf != null) {
					JNIEnv.CopyArray (native_cbuf, cbuf);
					JNIEnv.DeleteLocalRef (native_cbuf);
				}
				global::System.GC.KeepAlive (cbuf);
			}
		}

	}
}
