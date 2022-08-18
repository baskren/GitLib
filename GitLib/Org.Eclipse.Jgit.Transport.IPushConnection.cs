using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Lists known refs from the remote and sends objects to the remote.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PushConnection']"
	[Register ("org/eclipse/jgit/transport/PushConnection", "", "Org.Eclipse.Jgit.Transport.IPushConnectionInvoker")]
	public partial interface IPushConnection : global::Org.Eclipse.Jgit.Transport.IConnection {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PushConnection']/method[@name='push' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.transport.RemoteRefUpdate&gt;']]"
		/// <param name="monitor">progress monitor to update the end-user about the amount of
		///            work completed, or to indicate cancellation. Implementors
		///            should poll the monitor at regular intervals to look for
		///            cancellation requests from the user.</param>
		/// <param name="refUpdates">map of remote refnames to remote refs update
		///            specifications/statuses. Can't be empty. This indicate what
		///            refs caller want to update on remote side. Only refs updates
		///            with <c>Status#NOT_ATTEMPTED</c> should passed.
		///            Implementation must ensure that and appropriate status with
		///            optional message should be set during call. No refUpdate with
		///            <c>Status#AWAITING_REPORT</c> or <c>Status#NOT_ATTEMPTED</c>
		///            can be leaved by implementation after return from this call.</param>
		/// <summary>Pushes to the remote repository basing on provided specification.</summary>
		[Register ("push", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;)V", "GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Handler:Org.Eclipse.Jgit.Transport.IPushConnectionInvoker, AndroidBindableLibrary")]
		void Push (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> refUpdates);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PushConnection']/method[@name='push' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.transport.RemoteRefUpdate&gt;'] and parameter[3][@type='java.io.OutputStream']]"
		/// <param name="monitor">progress monitor to update the end-user about the amount of
		///            work completed, or to indicate cancellation. Implementors
		///            should poll the monitor at regular intervals to look for
		///            cancellation requests from the user.</param>
		/// <param name="refUpdates">map of remote refnames to remote refs update
		///            specifications/statuses. Can't be empty. This indicate what
		///            refs caller want to update on remote side. Only refs updates
		///            with <c>Status#NOT_ATTEMPTED</c> should passed.
		///            Implementation must ensure that and appropriate status with
		///            optional message should be set during call. No refUpdate with
		///            <c>Status#AWAITING_REPORT</c> or <c>Status#NOT_ATTEMPTED</c>
		///            can be leaved by implementation after return from this call.</param>
		/// <param name="out">output stream to write sideband messages to</param>
		/// <summary>Pushes to the remote repository basing on provided specification.</summary>
		[Register ("push", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;Ljava/io/OutputStream;)V", "GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_Handler:Org.Eclipse.Jgit.Transport.IPushConnectionInvoker, AndroidBindableLibrary")]
		void Push (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> refUpdates, global::System.IO.Stream @out);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PushConnection", DoNotGenerateAcw=true)]
	internal partial class IPushConnectionInvoker : global::Java.Lang.Object, IPushConnection {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PushConnection", typeof (IPushConnectionInvoker));

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

		public static IPushConnection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushConnection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.PushConnection'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Handler ()
		{
			if (cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_ == null)
				cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_);
			return cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_;
		}

		static void n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_refUpdates)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (native_refUpdates, JniHandleOwnership.DoNotTransfer);
			__this.Push (monitor, refUpdates);
		}
#pragma warning restore 0169

		IntPtr id_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_;
		public unsafe void Push (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> refUpdates)
		{
			if (id_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_ == IntPtr.Zero)
				id_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "push", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;)V");
			IntPtr native_refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.ToLocalJniHandle (refUpdates);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
			__args [1] = new JValue (native_refUpdates);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_refUpdates);
		}

		static Delegate cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_Handler ()
		{
			if (cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ == null)
				cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_);
			return cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_;
		}

		static void n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_refUpdates, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (native_refUpdates, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Push (monitor, refUpdates, @out);
		}
#pragma warning restore 0169

		IntPtr id_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_;
		public unsafe void Push (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> refUpdates, global::System.IO.Stream @out)
		{
			if (id_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "push", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;Ljava/io/OutputStream;)V");
			IntPtr native_refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.ToLocalJniHandle (refUpdates);
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
			__args [1] = new JValue (native_refUpdates);
			__args [2] = new JValue (native__out);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_, __args);
			JNIEnv.DeleteLocalRef (native_refUpdates);
			JNIEnv.DeleteLocalRef (native__out);
		}

		static Delegate cb_getMessages;
#pragma warning disable 0169
		static Delegate GetGetMessagesHandler ()
		{
			if (cb_getMessages == null)
				cb_getMessages = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessages);
			return cb_getMessages;
		}

		static IntPtr n_GetMessages (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Messages);
		}
#pragma warning restore 0169

		IntPtr id_getMessages;
		public unsafe string Messages {
			get {
				if (id_getMessages == IntPtr.Zero)
					id_getMessages = JNIEnv.GetMethodID (class_ref, "getMessages", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRefs;
#pragma warning disable 0169
		static Delegate GetGetRefsHandler ()
		{
			if (cb_getRefs == null)
				cb_getRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefs);
			return cb_getRefs;
		}

		static IntPtr n_GetRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.Refs);
		}
#pragma warning restore 0169

		IntPtr id_getRefs;
		public unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> Refs {
			get {
				if (id_getRefs == IntPtr.Zero)
					id_getRefs = JNIEnv.GetMethodID (class_ref, "getRefs", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefs), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRefsMap;
#pragma warning disable 0169
		static Delegate GetGetRefsMapHandler ()
		{
			if (cb_getRefsMap == null)
				cb_getRefsMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefsMap);
			return cb_getRefsMap;
		}

		static IntPtr n_GetRefsMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.RefsMap);
		}
#pragma warning restore 0169

		IntPtr id_getRefsMap;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> RefsMap {
			get {
				if (id_getRefsMap == IntPtr.Zero)
					id_getRefsMap = JNIEnv.GetMethodID (class_ref, "getRefsMap", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefsMap), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_getRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRef_Ljava_lang_String_Handler ()
		{
			if (cb_getRef_Ljava_lang_String_ == null)
				cb_getRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRef_Ljava_lang_String_);
			return cb_getRef_Ljava_lang_String_;
		}

		static IntPtr n_GetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRef (name));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRef_Ljava_lang_String_;
		public unsafe global::Org.Eclipse.Jgit.Lib.IRef GetRef (string name)
		{
			if (id_getRef_Ljava_lang_String_ == IntPtr.Zero)
				id_getRef_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;");
			IntPtr native_name = JNIEnv.NewString ((string)name);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_name);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRef_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

	}
}
