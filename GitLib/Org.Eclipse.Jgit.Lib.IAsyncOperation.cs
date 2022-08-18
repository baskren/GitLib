using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Asynchronous operation handle.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='AsyncOperation']"
	[Register ("org/eclipse/jgit/lib/AsyncOperation", "", "Org.Eclipse.Jgit.Lib.IAsyncOperationInvoker")]
	public partial interface IAsyncOperation : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='AsyncOperation']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		/// <param name="mayInterruptIfRunning">true if the thread executing this task should be interrupted;
		///            otherwise, in-progress tasks are allowed to complete</param>
		/// <summary>Cancels the running task.</summary>
		/// <returns>false if the task could not be cancelled, typically because it
		///         has already completed normally; true otherwise</returns>
		[Register ("cancel", "(Z)Z", "GetCancel_ZHandler:Org.Eclipse.Jgit.Lib.IAsyncOperationInvoker, AndroidBindableLibrary")]
		bool Cancel (bool mayInterruptIfRunning);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='AsyncOperation']/method[@name='release' and count(parameter)=0]"
		/// <summary>Release resources used by the operation, including cancellation.</summary>
		[Register ("release", "()V", "GetReleaseHandler:Org.Eclipse.Jgit.Lib.IAsyncOperationInvoker, AndroidBindableLibrary")]
		void Release ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/AsyncOperation", DoNotGenerateAcw=true)]
	internal partial class IAsyncOperationInvoker : global::Java.Lang.Object, IAsyncOperation {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/AsyncOperation", typeof (IAsyncOperationInvoker));

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

		public static IAsyncOperation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncOperation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.AsyncOperation'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncOperationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
