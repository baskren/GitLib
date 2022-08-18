using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Read Git style pkt-line formatting from an input stream.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineIn']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PacketLineIn", DoNotGenerateAcw=true)]
	public partial class PacketLineIn : global::Java.Lang.Object {

		/// <summary>Magic return from <c>#readString()</c> when a flush packet is found.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineIn']/field[@name='END']"
		[Register ("END")]
		public static string End {
			get {
				const string __id = "END.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PacketLineIn", typeof (PacketLineIn));

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

		protected PacketLineIn (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="i">the input stream to consume.</param>
		/// <summary>Create a new packet line reader.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineIn']/constructor[@name='PacketLineIn' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe PacketLineIn (global::System.IO.Stream i) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_i = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (i);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_i);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_i);
				global::System.GC.KeepAlive (i);
			}
		}

		static Delegate cb_readString;
#pragma warning disable 0169
		static Delegate GetReadStringHandler ()
		{
			if (cb_readString == null)
				cb_readString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadString);
			return cb_readString;
		}

		static IntPtr n_ReadString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PacketLineIn> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadString ());
		}
#pragma warning restore 0169

		/// <summary>Read a single UTF-8 encoded string packet from the input stream.</summary>
		/// <returns>the string. <c>#END</c> if the string was the magic flush
		///         packet.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineIn']/method[@name='readString' and count(parameter)=0]"
		[Register ("readString", "()Ljava/lang/String;", "GetReadStringHandler")]
		public virtual unsafe string ReadString ()
		{
			const string __id = "readString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readStringRaw;
#pragma warning disable 0169
		static Delegate GetReadStringRawHandler ()
		{
			if (cb_readStringRaw == null)
				cb_readStringRaw = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadStringRaw);
			return cb_readStringRaw;
		}

		static IntPtr n_ReadStringRaw (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PacketLineIn> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadStringRaw ());
		}
#pragma warning restore 0169

		/// <summary>Read a single UTF-8 encoded string packet from the input stream.</summary>
		/// <returns>the string. <c>#END</c> if the string was the magic flush
		///         packet.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PacketLineIn']/method[@name='readStringRaw' and count(parameter)=0]"
		[Register ("readStringRaw", "()Ljava/lang/String;", "GetReadStringRawHandler")]
		public virtual unsafe string ReadStringRaw ()
		{
			const string __id = "readStringRaw.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
