using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Write Git style pkt-line formatting to an output stream.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineOut']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PacketLineOut", DoNotGenerateAcw=true)]
	public partial class PacketLineOut : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PacketLineOut", typeof (PacketLineOut));

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

		protected PacketLineOut (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="outputStream">stream.</param>
		/// <summary>Create a new packet line writer.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineOut']/constructor[@name='PacketLineOut' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		public unsafe PacketLineOut (global::System.IO.Stream outputStream) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/OutputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_outputStream);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outputStream);
				global::System.GC.KeepAlive (outputStream);
			}
		}

		static Delegate cb_end;
#pragma warning disable 0169
		static Delegate GetEndHandler ()
		{
			if (cb_end == null)
				cb_end = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_End);
			return cb_end;
		}

		static void n_End (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PacketLineOut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		/// <summary>Write a packet end marker, sometimes referred to as a flush command.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineOut']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler")]
		public virtual unsafe void End ()
		{
			const string __id = "end.()V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PacketLineOut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		/// <summary>Flush the underlying OutputStream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineOut']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setFlushOnEnd_Z;
#pragma warning disable 0169
		static Delegate GetSetFlushOnEnd_ZHandler ()
		{
			if (cb_setFlushOnEnd_Z == null)
				cb_setFlushOnEnd_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFlushOnEnd_Z);
			return cb_setFlushOnEnd_Z;
		}

		static void n_SetFlushOnEnd_Z (IntPtr jnienv, IntPtr native__this, bool flushOnEnd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PacketLineOut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFlushOnEnd (flushOnEnd);
		}
#pragma warning restore 0169

		/// <param name="flushOnEnd">if true, a flush-pkt written during <c>#end()</c> also
		///            flushes the underlying stream.</param>
		/// <summary>Set the flush behavior during <c>#end()</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineOut']/method[@name='setFlushOnEnd' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFlushOnEnd", "(Z)V", "GetSetFlushOnEnd_ZHandler")]
		public virtual unsafe void SetFlushOnEnd (bool flushOnEnd)
		{
			const string __id = "setFlushOnEnd.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flushOnEnd);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writePacket_arrayB;
#pragma warning disable 0169
		static Delegate GetWritePacket_arrayBHandler ()
		{
			if (cb_writePacket_arrayB == null)
				cb_writePacket_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WritePacket_arrayB);
			return cb_writePacket_arrayB;
		}

		static void n_WritePacket_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_packet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PacketLineOut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var packet = (byte[]) JNIEnv.GetArray (native_packet, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WritePacket (packet);
			if (packet != null)
				JNIEnv.CopyArray (packet, native_packet);
		}
#pragma warning restore 0169

		/// <param name="packet">the packet to write; the length of the packet is equal to the
		///            size of the byte array.</param>
		/// <summary>Write a binary packet to the stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineOut']/method[@name='writePacket' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writePacket", "([B)V", "GetWritePacket_arrayBHandler")]
		public virtual unsafe void WritePacket (byte[] packet)
		{
			const string __id = "writePacket.([B)V";
			IntPtr native_packet = JNIEnv.NewArray (packet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packet);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (packet != null) {
					JNIEnv.CopyArray (native_packet, packet);
					JNIEnv.DeleteLocalRef (native_packet);
				}
				global::System.GC.KeepAlive (packet);
			}
		}

		static Delegate cb_writeString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteString_Ljava_lang_String_Handler ()
		{
			if (cb_writeString_Ljava_lang_String_ == null)
				cb_writeString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteString_Ljava_lang_String_);
			return cb_writeString_Ljava_lang_String_;
		}

		static void n_WriteString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PacketLineOut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.WriteString (s);
		}
#pragma warning restore 0169

		/// <param name="s">string to write.</param>
		/// <summary>Write a UTF-8 encoded string as a single length-delimited packet.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineOut']/method[@name='writeString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeString", "(Ljava/lang/String;)V", "GetWriteString_Ljava_lang_String_Handler")]
		public virtual unsafe void WriteString (string s)
		{
			const string __id = "writeString.(Ljava/lang/String;)V";
			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

	}
}
