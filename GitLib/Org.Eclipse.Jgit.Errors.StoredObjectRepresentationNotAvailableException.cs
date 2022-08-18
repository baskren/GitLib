using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>A previously selected representation is no longer available.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='StoredObjectRepresentationNotAvailableException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/StoredObjectRepresentationNotAvailableException", DoNotGenerateAcw=true)]
	public partial class StoredObjectRepresentationNotAvailableException : global::Java.Lang.Exception {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/StoredObjectRepresentationNotAvailableException", typeof (StoredObjectRepresentationNotAvailableException));

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

		protected StoredObjectRepresentationNotAvailableException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="otp">the object whose current representation is no longer present.</param>
		/// <summary>Construct an error for an object.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='StoredObjectRepresentationNotAvailableException']/constructor[@name='StoredObjectRepresentationNotAvailableException' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.ObjectToPack']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;)V", "")]
		public unsafe StoredObjectRepresentationNotAvailableException (global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack otp) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((otp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) otp).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (otp);
			}
		}

	}
}
