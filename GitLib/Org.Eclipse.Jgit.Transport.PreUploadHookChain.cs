using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>
	///   <c>PreUploadHook</c> that delegates to a list of other hooks.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PreUploadHookChain']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PreUploadHookChain", DoNotGenerateAcw=true)]
	public partial class PreUploadHookChain : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.IPreUploadHook {
		public static class InterfaceConsts {
			// The following are fields from: org.eclipse.jgit.transport.PreUploadHook


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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PreUploadHookChain", typeof (PreUploadHookChain));

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

		protected PreUploadHookChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="hooks">hooks to execute, in order.</param>
		/// <summary>Create a new hook chaining the given hooks together.</summary>
		/// <returns>a new hook chain of the given hooks.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PreUploadHookChain']/method[@name='newChain' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends org.eclipse.jgit.transport.PreUploadHook&gt;']]"
		[Register ("newChain", "(Ljava/util/List;)Lorg/eclipse/jgit/transport/PreUploadHook;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.IPreUploadHook NewChain (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.IPreUploadHook> hooks)
		{
			const string __id = "newChain.(Ljava/util/List;)Lorg/eclipse/jgit/transport/PreUploadHook;";
			IntPtr native_hooks = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.IPreUploadHook>.ToLocalJniHandle (hooks);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hooks);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreUploadHook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hooks);
				global::System.GC.KeepAlive (hooks);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PreUploadHookChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var up = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_up, JniHandleOwnership.DoNotTransfer);
			var wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_wants, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginNegotiateRound (up, wants, cntOffered);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PreUploadHookChain']/method[@name='onBeginNegotiateRound' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[3][@type='int']]"
		[Register ("onBeginNegotiateRound", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;I)V", "GetOnBeginNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IHandler")]
		public virtual unsafe void OnBeginNegotiateRound (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> wants, int cntOffered)
		{
			const string __id = "onBeginNegotiateRound.(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;I)V";
			IntPtr native_wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
				__args [1] = new JniArgumentValue (native_wants);
				__args [2] = new JniArgumentValue (cntOffered);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_wants);
				global::System.GC.KeepAlive (up);
				global::System.GC.KeepAlive (wants);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PreUploadHookChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var up = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_up, JniHandleOwnership.DoNotTransfer);
			var wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_wants, JniHandleOwnership.DoNotTransfer);
			__this.OnEndNegotiateRound (up, wants, cntCommon, cntNotFound, ready);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PreUploadHookChain']/method[@name='onEndNegotiateRound' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("onEndNegotiateRound", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;IIZ)V", "GetOnEndNegotiateRound_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_IIZHandler")]
		public virtual unsafe void OnEndNegotiateRound (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> wants, int cntCommon, int cntNotFound, bool ready)
		{
			const string __id = "onEndNegotiateRound.(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;IIZ)V";
			IntPtr native_wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
				__args [1] = new JniArgumentValue (native_wants);
				__args [2] = new JniArgumentValue (cntCommon);
				__args [3] = new JniArgumentValue (cntNotFound);
				__args [4] = new JniArgumentValue (ready);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_wants);
				global::System.GC.KeepAlive (up);
				global::System.GC.KeepAlive (wants);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PreUploadHookChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var up = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_up, JniHandleOwnership.DoNotTransfer);
			var wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_wants, JniHandleOwnership.DoNotTransfer);
			var haves = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_haves, JniHandleOwnership.DoNotTransfer);
			__this.OnSendPack (up, wants, haves);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PreUploadHookChain']/method[@name='onSendPack' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[3][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("onSendPack", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;Ljava/util/Collection;)V", "GetOnSendPack_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_Collection_Ljava_util_Collection_Handler")]
		public virtual unsafe void OnSendPack (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> wants, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> haves)
		{
			const string __id = "onSendPack.(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/Collection;Ljava/util/Collection;)V";
			IntPtr native_wants = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
			IntPtr native_haves = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (haves);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
				__args [1] = new JniArgumentValue (native_wants);
				__args [2] = new JniArgumentValue (native_haves);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_wants);
				JNIEnv.DeleteLocalRef (native_haves);
				global::System.GC.KeepAlive (up);
				global::System.GC.KeepAlive (wants);
				global::System.GC.KeepAlive (haves);
			}
		}

	}
}
