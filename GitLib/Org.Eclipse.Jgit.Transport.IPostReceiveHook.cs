using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	[Register ("org/eclipse/jgit/transport/PostReceiveHook", DoNotGenerateAcw=true)]
	public abstract class PostReceiveHook : Java.Lang.Object {
		internal PostReceiveHook ()
		{
		}


		/// <summary>A simple no-op hook.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PostReceiveHook']/field[@name='NULL']"
		[Register ("NULL")]
		public static global::Org.Eclipse.Jgit.Transport.IPostReceiveHook Null {
			get {
				const string __id = "NULL.Lorg/eclipse/jgit/transport/PostReceiveHook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPostReceiveHook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PostReceiveHook", typeof (PostReceiveHook));

	}

	[Register ("org/eclipse/jgit/transport/PostReceiveHook", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'PostReceiveHook' type. This type will be removed in a future release.", error: true)]
	public abstract class PostReceiveHookConsts : PostReceiveHook {
		private PostReceiveHookConsts ()
		{
		}

	}

	/// <summary>Hook invoked by <c>ReceivePack</c> after all updates are executed.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PostReceiveHook']"
	[Register ("org/eclipse/jgit/transport/PostReceiveHook", "", "Org.Eclipse.Jgit.Transport.IPostReceiveHookInvoker")]
	public partial interface IPostReceiveHook : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PostReceiveHook']/method[@name='onPostReceive' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.ReceivePack'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.transport.ReceiveCommand&gt;']]"
		/// <param name="rp">the process handling the current receive. Hooks may obtain
		///            details about the destination repository through this handle.</param>
		/// <param name="commands">unmodifiable set of successfully completed commands. May be
		///            the empty set.</param>
		/// <summary>Invoked after all commands are executed and status has been returned.</summary>
		[Register ("onPostReceive", "(Lorg/eclipse/jgit/transport/ReceivePack;Ljava/util/Collection;)V", "GetOnPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_Handler:Org.Eclipse.Jgit.Transport.IPostReceiveHookInvoker, AndroidBindableLibrary")]
		void OnPostReceive (global::Org.Eclipse.Jgit.Transport.ReceivePack rp, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> commands);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PostReceiveHook", DoNotGenerateAcw=true)]
	internal partial class IPostReceiveHookInvoker : global::Java.Lang.Object, IPostReceiveHook {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PostReceiveHook", typeof (IPostReceiveHookInvoker));

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

		public static IPostReceiveHook GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPostReceiveHook> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.PostReceiveHook'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPostReceiveHookInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetOnPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_Handler ()
		{
			if (cb_onPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ == null)
				cb_onPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_);
			return cb_onPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_;
		}

		static void n_OnPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rp, IntPtr native_commands)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPostReceiveHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (native_rp, JniHandleOwnership.DoNotTransfer);
			var commands = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.FromJniHandle (native_commands, JniHandleOwnership.DoNotTransfer);
			__this.OnPostReceive (rp, commands);
		}
#pragma warning restore 0169

		IntPtr id_onPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_;
		public unsafe void OnPostReceive (global::Org.Eclipse.Jgit.Transport.ReceivePack rp, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> commands)
		{
			if (id_onPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ == IntPtr.Zero)
				id_onPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "onPostReceive", "(Lorg/eclipse/jgit/transport/ReceivePack;Ljava/util/Collection;)V");
			IntPtr native_commands = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.ToLocalJniHandle (commands);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((rp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rp).Handle);
			__args [1] = new JValue (native_commands);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_, __args);
			JNIEnv.DeleteLocalRef (native_commands);
		}

	}
}
