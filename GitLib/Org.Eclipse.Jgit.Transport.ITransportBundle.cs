using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	[Register ("org/eclipse/jgit/transport/TransportBundle", DoNotGenerateAcw=true)]
	public abstract class TransportBundle : Java.Lang.Object {
		internal TransportBundle ()
		{
		}

		/// <summary>Bundle signature</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='TransportBundle']/field[@name='V2_BUNDLE_SIGNATURE']"
		[Register ("V2_BUNDLE_SIGNATURE")]
		public const string V2BundleSignature = (string) "# v2 git bundle";

		// The following are fields from: org.eclipse.jgit.transport.PackTransport

	}

	[Register ("org/eclipse/jgit/transport/TransportBundle", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TransportBundle' type. This type will be removed in a future release.", error: true)]
	public abstract class TransportBundleConsts : TransportBundle {
		private TransportBundleConsts ()
		{
		}

	}

	/// <summary>Marker interface for transports that supports fetching from a git bundle
	/// (sneaker-net object transport).</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='TransportBundle']"
	[Register ("org/eclipse/jgit/transport/TransportBundle", "", "Org.Eclipse.Jgit.Transport.ITransportBundleInvoker")]
	public partial interface ITransportBundle : global::Org.Eclipse.Jgit.Transport.IPackTransport {
	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TransportBundle", DoNotGenerateAcw=true)]
	internal partial class ITransportBundleInvoker : global::Java.Lang.Object, ITransportBundle {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TransportBundle", typeof (ITransportBundleInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITransportBundle GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransportBundle> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.TransportBundle'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransportBundleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
