using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Single shot fetch from a streamed Git bundle.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportBundleStream']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TransportBundleStream", DoNotGenerateAcw=true)]
	public partial class TransportBundleStream : global::Org.Eclipse.Jgit.Transport.Transport, global::Org.Eclipse.Jgit.Transport.ITransportBundle {
		public static class InterfaceConsts {
			// The following are fields from: org.eclipse.jgit.transport.TransportBundle

			/// <summary>Bundle signature</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='TransportBundle']/field[@name='V2_BUNDLE_SIGNATURE']"
			[Register ("V2_BUNDLE_SIGNATURE")]
			public const string V2BundleSignature = (string) "# v2 git bundle";

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TransportBundleStream", typeof (TransportBundleStream));

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

		protected TransportBundleStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="db">repository the fetched objects will be loaded into.</param>
		/// <param name="uri">symbolic name of the source of the stream. The URI can
		///            reference a non-existent resource. It is used only for
		///            exception reporting.</param>
		/// <param name="in">the stream to read the bundle from.</param>
		/// <summary>Create a new transport to fetch objects from a streamed bundle.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportBundleStream']/constructor[@name='TransportBundleStream' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.URIish'] and parameter[3][@type='java.io.InputStream']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;Ljava/io/InputStream;)V", "")]
		public unsafe TransportBundleStream (global::Org.Eclipse.Jgit.Lib.Repository db, global::Org.Eclipse.Jgit.Transport.URIish uri, global::System.IO.Stream @in) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native__in);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (db);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (@in);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportBundleStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportBundleStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_openFetch;
#pragma warning disable 0169
		static Delegate GetOpenFetchHandler ()
		{
			if (cb_openFetch == null)
				cb_openFetch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenFetch);
			return cb_openFetch;
		}

		static IntPtr n_OpenFetch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportBundleStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenFetch ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportBundleStream']/method[@name='openFetch' and count(parameter)=0]"
		[Register ("openFetch", "()Lorg/eclipse/jgit/transport/FetchConnection;", "GetOpenFetchHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IFetchConnection OpenFetch ()
		{
			const string __id = "openFetch.()Lorg/eclipse/jgit/transport/FetchConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_openPush;
#pragma warning disable 0169
		static Delegate GetOpenPushHandler ()
		{
			if (cb_openPush == null)
				cb_openPush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenPush);
			return cb_openPush;
		}

		static IntPtr n_OpenPush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportBundleStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenPush ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportBundleStream']/method[@name='openPush' and count(parameter)=0]"
		[Register ("openPush", "()Lorg/eclipse/jgit/transport/PushConnection;", "GetOpenPushHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IPushConnection OpenPush ()
		{
			const string __id = "openPush.()Lorg/eclipse/jgit/transport/PushConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
