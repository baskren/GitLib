using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>The base class for transports based on TCP sockets.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TcpTransport']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TcpTransport", DoNotGenerateAcw=true)]
	public abstract partial class TcpTransport : global::Org.Eclipse.Jgit.Transport.Transport {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TcpTransport", typeof (TcpTransport));

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

		protected TcpTransport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="local">the repository this instance will fetch into, or push out of.
		///            This must be the repository passed to
		///            <c>#open(Repository, URIish)</c>.</param>
		/// <param name="uri">the URI used to access the remote repository. This must be the
		///            URI passed to <c>#open(Repository, URIish)</c>.</param>
		/// <summary>Create a new transport instance.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TcpTransport']/constructor[@name='TcpTransport' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.URIish']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;)V", "")]
		protected unsafe TcpTransport (global::Org.Eclipse.Jgit.Lib.Repository local, global::Org.Eclipse.Jgit.Transport.URIish uri) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (uri);
			}
		}

		/// <param name="uri">the URI used to access the remote repository. This must be the
		///            URI passed to <c>#open(URIish)</c>.</param>
		/// <summary>Create a new transport instance without a local repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TcpTransport']/constructor[@name='TcpTransport' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/transport/URIish;)V", "")]
		protected unsafe TcpTransport (global::Org.Eclipse.Jgit.Transport.URIish uri) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/transport/URIish;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TcpTransport", DoNotGenerateAcw=true)]
	internal partial class TcpTransportInvoker : TcpTransport {
		public TcpTransportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TcpTransport", typeof (TcpTransportInvoker));

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

		/// <summary>Close any resources used by this transport.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <summary>Begins a new connection for fetching from the remote repository.</summary>
		/// <returns>a fresh connection to fetch from the remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openFetch' and count(parameter)=0]"
		[Register ("openFetch", "()Lorg/eclipse/jgit/transport/FetchConnection;", "GetOpenFetchHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IFetchConnection OpenFetch ()
		{
			const string __id = "openFetch.()Lorg/eclipse/jgit/transport/FetchConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Begins a new connection for pushing into the remote repository.</summary>
		/// <returns>a fresh connection to push into the remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openPush' and count(parameter)=0]"
		[Register ("openPush", "()Lorg/eclipse/jgit/transport/PushConnection;", "GetOpenPushHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IPushConnection OpenPush ()
		{
			const string __id = "openPush.()Lorg/eclipse/jgit/transport/PushConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
