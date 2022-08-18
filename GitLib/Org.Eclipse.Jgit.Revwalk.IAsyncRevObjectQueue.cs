using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Queue to lookup and parse objects asynchronously.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/interface[@name='AsyncRevObjectQueue']"
	[Register ("org/eclipse/jgit/revwalk/AsyncRevObjectQueue", "", "Org.Eclipse.Jgit.Revwalk.IAsyncRevObjectQueueInvoker")]
	public partial interface IAsyncRevObjectQueue : global::Org.Eclipse.Jgit.Lib.IAsyncOperation {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/interface[@name='AsyncRevObjectQueue']/method[@name='next' and count(parameter)=0]"
		/// <summary>Obtain the next object.</summary>
		/// <returns>the object; null if there are no more objects remaining.</returns>
		[Register ("next", "()Lorg/eclipse/jgit/revwalk/RevObject;", "GetNextHandler:Org.Eclipse.Jgit.Revwalk.IAsyncRevObjectQueueInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Revwalk.RevObject Next ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/AsyncRevObjectQueue", DoNotGenerateAcw=true)]
	internal partial class IAsyncRevObjectQueueInvoker : global::Java.Lang.Object, IAsyncRevObjectQueue {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/AsyncRevObjectQueue", typeof (IAsyncRevObjectQueueInvoker));

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

		public static IAsyncRevObjectQueue GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncRevObjectQueue> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.revwalk.AsyncRevObjectQueue'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncRevObjectQueueInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.IAsyncRevObjectQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		IntPtr id_next;
		public unsafe global::Org.Eclipse.Jgit.Revwalk.RevObject Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Lorg/eclipse/jgit/revwalk/RevObject;");
			return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_next), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_cancel_Z;
#pragma warning disable 0169
		static Delegate GetCancel_ZHandler ()
		{
			if (cb_cancel_Z == null)
				cb_cancel_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_Cancel_Z);
			return cb_cancel_Z;
		}

		static bool n_Cancel_Z (IntPtr jnienv, IntPtr native__this, bool mayInterruptIfRunning)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.IAsyncRevObjectQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (mayInterruptIfRunning);
		}
#pragma warning restore 0169

		IntPtr id_cancel_Z;
		public unsafe bool Cancel (bool mayInterruptIfRunning)
		{
			if (id_cancel_Z == IntPtr.Zero)
				id_cancel_Z = JNIEnv.GetMethodID (class_ref, "cancel", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (mayInterruptIfRunning);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Z, __args);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.IAsyncRevObjectQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

	}
}
