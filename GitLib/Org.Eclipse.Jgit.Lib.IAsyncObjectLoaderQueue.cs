using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <param name="&lt;T&gt;">type of identifier supplied to the call that made the queue.</param>
	/// <summary>Queue to open objects asynchronously.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='AsyncObjectLoaderQueue']"
	[Register ("org/eclipse/jgit/lib/AsyncObjectLoaderQueue", "", "Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueueInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.lib.ObjectId"})]
	public partial interface IAsyncObjectLoaderQueue : global::Org.Eclipse.Jgit.Lib.IAsyncOperation {
		global::Java.Lang.Object Current {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='AsyncObjectLoaderQueue']/method[@name='getCurrent' and count(parameter)=0]"
			[Register ("getCurrent", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetCurrentHandler:Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueueInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Lib.ObjectId ObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='AsyncObjectLoaderQueue']/method[@name='getObjectId' and count(parameter)=0]"
			[Register ("getObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObjectIdHandler:Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueueInvoker, AndroidBindableLibrary")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='AsyncObjectLoaderQueue']/method[@name='next' and count(parameter)=0]"
		/// <summary>Position this queue onto the next available result.</summary>
		/// <returns>true if there is a result available; false if the queue has
		///         finished its input iteration.</returns>
		[Register ("next", "()Z", "GetNextHandler:Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueueInvoker, AndroidBindableLibrary")]
		bool Next ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='AsyncObjectLoaderQueue']/method[@name='open' and count(parameter)=0]"
		/// <summary>Obtain a loader to read the object.</summary>
		/// <returns>the ObjectLoader to read this object. Never null.</returns>
		[Register ("open", "()Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpenHandler:Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueueInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.ObjectLoader Open ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/AsyncObjectLoaderQueue", DoNotGenerateAcw=true)]
	internal partial class IAsyncObjectLoaderQueueInvoker : global::Java.Lang.Object, IAsyncObjectLoaderQueue {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/AsyncObjectLoaderQueue", typeof (IAsyncObjectLoaderQueueInvoker));

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

		public static IAsyncObjectLoaderQueue GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncObjectLoaderQueue> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.AsyncObjectLoaderQueue'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncObjectLoaderQueueInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCurrent;
#pragma warning disable 0169
		static Delegate GetGetCurrentHandler ()
		{
			if (cb_getCurrent == null)
				cb_getCurrent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrent);
			return cb_getCurrent;
		}

		static IntPtr n_GetCurrent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Current);
		}
#pragma warning restore 0169

		IntPtr id_getCurrent;
		public unsafe global::Java.Lang.Object Current {
			get {
				if (id_getCurrent == IntPtr.Zero)
					id_getCurrent = JNIEnv.GetMethodID (class_ref, "getCurrent", "()Lorg/eclipse/jgit/lib/ObjectId;");
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getObjectId;
#pragma warning disable 0169
		static Delegate GetGetObjectIdHandler ()
		{
			if (cb_getObjectId == null)
				cb_getObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectId);
			return cb_getObjectId;
		}

		static IntPtr n_GetObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectId);
		}
#pragma warning restore 0169

		IntPtr id_getObjectId;
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ObjectId {
			get {
				if (id_getObjectId == IntPtr.Zero)
					id_getObjectId = JNIEnv.GetMethodID (class_ref, "getObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObjectId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Next);
			return cb_next;
		}

		static bool n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Next ();
		}
#pragma warning restore 0169

		IntPtr id_next;
		public unsafe bool Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_next);
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Open);
			return cb_open;
		}

		static IntPtr n_Open (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Open ());
		}
#pragma warning restore 0169

		IntPtr id_open;
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()Lorg/eclipse/jgit/lib/ObjectLoader;");
			return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_open), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
