using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	[Register ("org/eclipse/jgit/transport/PreReceiveHook", DoNotGenerateAcw=true)]
	public abstract class PreReceiveHook : Java.Lang.Object {
		internal PreReceiveHook ()
		{
		}


		/// <summary>A simple no-op hook.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PreReceiveHook']/field[@name='NULL']"
		[Register ("NULL")]
		public static global::Org.Eclipse.Jgit.Transport.IPreReceiveHook Null {
			get {
				const string __id = "NULL.Lorg/eclipse/jgit/transport/PreReceiveHook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreReceiveHook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PreReceiveHook", typeof (PreReceiveHook));

	}

	[Register ("org/eclipse/jgit/transport/PreReceiveHook", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'PreReceiveHook' type. This type will be removed in a future release.", error: true)]
	public abstract class PreReceiveHookConsts : PreReceiveHook {
		private PreReceiveHookConsts ()
		{
		}

	}

	/// <summary>Hook invoked by <c>ReceivePack</c> before any updates are executed.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PreReceiveHook']"
	[Register ("org/eclipse/jgit/transport/PreReceiveHook", "", "Org.Eclipse.Jgit.Transport.IPreReceiveHookInvoker")]
	public partial interface IPreReceiveHook : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PreReceiveHook']/method[@name='onPreReceive' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.ReceivePack'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.transport.ReceiveCommand&gt;']]"
		/// <param name="rp">the process handling the current receive. Hooks may obtain
		///            details about the destination repository through this handle.</param>
		/// <param name="commands">unmodifiable set of valid commands still pending execution.
		///            May be the empty set.</param>
		/// <summary>Invoked just before commands are executed.</summary>
		[Register ("onPreReceive", "(Lorg/eclipse/jgit/transport/ReceivePack;Ljava/util/Collection;)V", "GetOnPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_Handler:Org.Eclipse.Jgit.Transport.IPreReceiveHookInvoker, AndroidBindableLibrary")]
		void OnPreReceive (global::Org.Eclipse.Jgit.Transport.ReceivePack rp, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> commands);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PreReceiveHook", DoNotGenerateAcw=true)]
	internal partial class IPreReceiveHookInvoker : global::Java.Lang.Object, IPreReceiveHook {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PreReceiveHook", typeof (IPreReceiveHookInvoker));

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

		public static IPreReceiveHook GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPreReceiveHook> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.PreReceiveHook'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPreReceiveHookInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetOnPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_Handler ()
		{
			if (cb_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ == null)
				cb_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_);
			return cb_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_;
		}

		static void n_OnPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rp, IntPtr native_commands)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreReceiveHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (native_rp, JniHandleOwnership.DoNotTransfer);
			var commands = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.FromJniHandle (native_commands, JniHandleOwnership.DoNotTransfer);
			__this.OnPreReceive (rp, commands);
		}
#pragma warning restore 0169

		IntPtr id_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_;
		public unsafe void OnPreReceive (global::Org.Eclipse.Jgit.Transport.ReceivePack rp, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> commands)
		{
			if (id_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ == IntPtr.Zero)
				id_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "onPreReceive", "(Lorg/eclipse/jgit/transport/ReceivePack;Ljava/util/Collection;)V");
			IntPtr native_commands = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.ToLocalJniHandle (commands);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((rp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rp).Handle);
			__args [1] = new JValue (native_commands);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_, __args);
			JNIEnv.DeleteLocalRef (native_commands);
		}

	}
}
