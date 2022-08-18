using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	[Register ("org/eclipse/jgit/transport/PreUploadHook", DoNotGenerateAcw=true)]
	public abstract class PreUploadHook : Java.Lang.Object {
		internal PreUploadHook ()
		{
		}


		/// <summary>A simple no-op hook.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PreUploadHook']/field[@name='NULL']"
		[Register ("NULL")]
		public static global::Org.Eclipse.Jgit.Transport.IPreUploadHook Null {
			get {
				const string __id = "NULL.Lorg/eclipse/jgit/transport/PreUploadHook;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreUploadHook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PreUploadHook", typeof (PreUploadHook));

	}

	[Register ("org/eclipse/jgit/transport/PreUploadHook", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'PreUploadHook' type. This type will be removed in a future release.", error: true)]
	public abstract class PreUploadHookConsts : PreUploadHook {
		private PreUploadHookConsts ()
		{
		}

	}

	/// <summary>Hook invoked by <c>UploadPack</c> before during critical phases.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PreUploadHook']"
	[Register ("org/eclipse/jgit/transport/PreUploadHook", "", "Org.Eclipse.Jgit.Transport.IPreUploadHookInvoker")]
	public partial interface IPreUploadHook : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PreUploadHook']/method[@name='onBeginNegotiateRound' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[3][@type='int']]"
		/// <param name="up">the upload pack instance handling the connection.</param>
		/// <param name="wants">the list of wanted objects.</param>
		/// <param name="cntOffered">number of objects the client has offered.</param>
		/// <summary>Invoked before negotiation round is started.</summary>
		[Register ("onBeginNegotiateRound", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;I)V", "GetOnBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IHandler:Org.Eclipse.Jgit.Transport.IPreUploadHookInvoker, AndroidBindableLibrary")]
		void OnBeginNegotiateRound (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> wants, int cntOffered);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PreUploadHook']/method[@name='onEndNegotiateRound' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		/// <param name="up">the upload pack instance handling the connection.</param>
		/// <param name="wants">the list of wanted objects.</param>
		/// <param name="cntCommon">number of objects this round found to be common. In a smart
		///            HTTP transaction this includes the objects that were
		///            previously found to be common.</param>
		/// <param name="cntNotFound">number of objects in this round the local repository does not
		///            have, but that were offered as potential common bases.</param>
		/// <param name="ready">true if a pack is ready to be sent (the commit graph was
		///            successfully cut).</param>
		/// <summary>Invoked after a negotiation round is completed.</summary>
		[Register ("onEndNegotiateRound", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;IIZ)V", "GetOnEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZHandler:Org.Eclipse.Jgit.Transport.IPreUploadHookInvoker, AndroidBindableLibrary")]
		void OnEndNegotiateRound (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> wants, int cntCommon, int cntNotFound, bool ready);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PreUploadHook']/method[@name='onSendPack' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[3][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		/// <param name="up">the upload pack instance handling the connection.</param>
		/// <param name="wants">the list of wanted objects. These may be RevObject or
		///            RevCommit if the processed parsed them. Implementors should
		///            not rely on the values being parsed.</param>
		/// <param name="haves">the list of common objects. Empty on an initial clone request.
		///            These may be RevObject or RevCommit if the processed parsed
		///            them. Implementors should not rely on the values being parsed.</param>
		/// <summary>Invoked just before a pack will be sent to the client.</summary>
		[Register ("onSendPack", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;Ljava/util/Collection;)V", "GetOnSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_Handler:Org.Eclipse.Jgit.Transport.IPreUploadHookInvoker, AndroidBindableLibrary")]
		void OnSendPack (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> wants, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> haves);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PreUploadHook", DoNotGenerateAcw=true)]
	internal partial class IPreUploadHookInvoker : global::Java.Lang.Object, IPreUploadHook {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PreUploadHook", typeof (IPreUploadHookInvoker));

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

		public static IPreUploadHook GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPreUploadHook> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.PreUploadHook'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPreUploadHookInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I;
#pragma warning disable 0169
		static Delegate GetOnBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IHandler ()
		{
			if (cb_onBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I == null)
				cb_onBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_OnBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I);
			return cb_onBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I;
		}

		static void n_OnBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I (IntPtr jnienv, IntPtr native__this, IntPtr native_up, IntPtr native_wants, int cntOffered)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreUploadHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var up = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_up, JniHandleOwnership.DoNotTransfer);
			var wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_wants, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginNegotiateRound (up, wants, cntOffered);
		}
#pragma warning restore 0169

		IntPtr id_onBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I;
		public unsafe void OnBeginNegotiateRound (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> wants, int cntOffered)
		{
			if (id_onBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I == IntPtr.Zero)
				id_onBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I = JNIEnv.GetMethodID (class_ref, "onBeginNegotiateRound", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;I)V");
			IntPtr native_wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
			__args [1] = new JValue (native_wants);
			__args [2] = new JValue (cntOffered);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_I, __args);
			JNIEnv.DeleteLocalRef (native_wants);
		}

		static Delegate cb_onEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ;
#pragma warning disable 0169
		static Delegate GetOnEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZHandler ()
		{
			if (cb_onEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ == null)
				cb_onEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIIZ_V) n_OnEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ);
			return cb_onEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ;
		}

		static void n_OnEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_up, IntPtr native_wants, int cntCommon, int cntNotFound, bool ready)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreUploadHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var up = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_up, JniHandleOwnership.DoNotTransfer);
			var wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_wants, JniHandleOwnership.DoNotTransfer);
			__this.OnEndNegotiateRound (up, wants, cntCommon, cntNotFound, ready);
		}
#pragma warning restore 0169

		IntPtr id_onEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ;
		public unsafe void OnEndNegotiateRound (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> wants, int cntCommon, int cntNotFound, bool ready)
		{
			if (id_onEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ == IntPtr.Zero)
				id_onEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ = JNIEnv.GetMethodID (class_ref, "onEndNegotiateRound", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;IIZ)V");
			IntPtr native_wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
			__args [1] = new JValue (native_wants);
			__args [2] = new JValue (cntCommon);
			__args [3] = new JValue (cntNotFound);
			__args [4] = new JValue (ready);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZ, __args);
			JNIEnv.DeleteLocalRef (native_wants);
		}

		static Delegate cb_onSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetOnSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_Handler ()
		{
			if (cb_onSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_ == null)
				cb_onSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_);
			return cb_onSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_;
		}

		static void n_OnSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_up, IntPtr native_wants, IntPtr native_haves)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreUploadHook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var up = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_up, JniHandleOwnership.DoNotTransfer);
			var wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_wants, JniHandleOwnership.DoNotTransfer);
			var haves = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_haves, JniHandleOwnership.DoNotTransfer);
			__this.OnSendPack (up, wants, haves);
		}
#pragma warning restore 0169

		IntPtr id_onSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_;
		public unsafe void OnSendPack (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> wants, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> haves)
		{
			if (id_onSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_ == IntPtr.Zero)
				id_onSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "onSendPack", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;Ljava/util/Collection;)V");
			IntPtr native_wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
			IntPtr native_haves = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (haves);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
			__args [1] = new JValue (native_wants);
			__args [2] = new JValue (native_haves);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_, __args);
			JNIEnv.DeleteLocalRef (native_wants);
			JNIEnv.DeleteLocalRef (native_haves);
		}

	}
}
