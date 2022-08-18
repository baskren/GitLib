using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Multiplexes data and progress messages.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SideBandOutputStream']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/SideBandOutputStream", DoNotGenerateAcw=true)]
	public partial class SideBandOutputStream : global::Java.IO.OutputStream {
		/// <summary>Channel used for pack data.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SideBandOutputStream']/field[@name='CH_DATA']"
		[Register ("CH_DATA")]
		public const int ChData = (int) 1;

		/// <summary>Channel used for error messages.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SideBandOutputStream']/field[@name='CH_ERROR']"
		[Register ("CH_ERROR")]
		public const int ChError = (int) 3;

		/// <summary>Channel used for progress messages.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SideBandOutputStream']/field[@name='CH_PROGRESS']"
		[Register ("CH_PROGRESS")]
		public const int ChProgress = (int) 2;

		/// <summary>Maximum buffer size for a single packet of sideband data.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SideBandOutputStream']/field[@name='MAX_BUF']"
		[Register ("MAX_BUF")]
		public const int MaxBuf = (int) 65520;

		/// <summary>Default buffer size for a small amount of data.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SideBandOutputStream']/field[@name='SMALL_BUF']"
		[Register ("SMALL_BUF")]
		public const int SmallBuf = (int) 1000;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/SideBandOutputStream", typeof (SideBandOutputStream));

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

		protected SideBandOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="chan">channel number to prefix all packets with, so the remote side
		///            can demultiplex the stream and get back the original data.
		///            Must be in the range [1, 255].</param>
		/// <param name="sz">maximum size of a data packet within the stream. The remote
		///            side needs to agree to the packet size to prevent buffer
		///            overflows. Must be in the range [HDR_SIZE + 1, MAX_BUF).</param>
		/// <param name="os">stream that the packets are written onto. This stream should
		///            be attached to a SideBandInputStream on the remote side.</param>
		/// <summary>Create a new stream to write side band packets.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SideBandOutputStream']/constructor[@name='SideBandOutputStream' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.io.OutputStream']]"
		[Register (".ctor", "(IILjava/io/OutputStream;)V", "")]
		public unsafe SideBandOutputStream (int chan, int sz, global::System.IO.Stream os) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IILjava/io/OutputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_os = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (os);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (chan);
				__args [1] = new JniArgumentValue (sz);
				__args [2] = new JniArgumentValue (native_os);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_os);
				global::System.GC.KeepAlive (os);
			}
		}

		static Delegate cb_write_I;
#pragma warning disable 0169
		static Delegate GetWrite_IHandler ()
		{
			if (cb_write_I == null)
				cb_write_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Write_I);
			return cb_write_I;
		}

		static void n_Write_I (IntPtr jnienv, IntPtr native__this, int b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.SideBandOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='SideBandOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write", "(I)V", "GetWrite_IHandler")]
		public override unsafe void Write (int b)
		{
			const string __id = "write.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
