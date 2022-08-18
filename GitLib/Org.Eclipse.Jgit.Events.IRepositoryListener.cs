using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Events {

	/// <summary>A listener can register for event delivery.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.events']/interface[@name='RepositoryListener']"
	[Register ("org/eclipse/jgit/events/RepositoryListener", "", "Org.Eclipse.Jgit.Events.IRepositoryListenerInvoker")]
	public partial interface IRepositoryListener : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/events/RepositoryListener", DoNotGenerateAcw=true)]
	internal partial class IRepositoryListenerInvoker : global::Java.Lang.Object, IRepositoryListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/events/RepositoryListener", typeof (IRepositoryListenerInvoker));

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

		public static IRepositoryListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRepositoryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.events.RepositoryListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRepositoryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/org/eclipse/jgit/events/RepositoryListenerImplementor")]
	internal sealed partial class IRepositoryListenerImplementor : global::Java.Lang.Object, IRepositoryListener {
		public IRepositoryListenerImplementor () : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/eclipse/jgit/events/RepositoryListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}

		internal static bool __IsEmpty (IRepositoryListenerImplementor value)
		{
			return true;
		}

	}
}
