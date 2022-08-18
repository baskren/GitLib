using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Push implementation using the native Git pack transfer service.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BasePackPushConnection", DoNotGenerateAcw=true)]
	public abstract partial class BasePackPushConnection : global::Org.Eclipse.Jgit.Transport.BaseConnection, global::Org.Eclipse.Jgit.Transport.IPushConnection {
		/// <summary>The server supports deleting refs.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/field[@name='CAPABILITY_DELETE_REFS']"
		[Register ("CAPABILITY_DELETE_REFS")]
		public const string CapabilityDeleteRefs = (string) "delete-refs";

		/// <summary>The server supports packs with OFS deltas.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/field[@name='CAPABILITY_OFS_DELTA']"
		[Register ("CAPABILITY_OFS_DELTA")]
		public const string CapabilityOfsDelta = (string) "ofs-delta";

		/// <summary>The client expects a status report after the server processes the pack.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/field[@name='CAPABILITY_REPORT_STATUS']"
		[Register ("CAPABILITY_REPORT_STATUS")]
		public const string CapabilityReportStatus = (string) "report-status";

		/// <summary>The client supports using the 64K side-band for progress messages.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/field[@name='CAPABILITY_SIDE_BAND_64K']"
		[Register ("CAPABILITY_SIDE_BAND_64K")]
		public const string CapabilitySideBand64k = (string) "side-band-64k";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BasePackPushConnection", typeof (BasePackPushConnection));

		internal static new IntPtr class_ref {
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

		protected BasePackPushConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="packTransport">the transport.</param>
		/// <summary>Create a new connection to push using the native git transport.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/constructor[@name='BasePackPushConnection' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PackTransport']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/transport/PackTransport;)V", "")]
		public unsafe BasePackPushConnection (global::Org.Eclipse.Jgit.Transport.IPackTransport packTransport) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/transport/PackTransport;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((packTransport == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packTransport).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (packTransport);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDoPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_Handler ()
		{
			if (cb_doPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ == null)
				cb_doPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_DoPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_);
			return cb_doPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_;
		}

		static void n_DoPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_refUpdates, IntPtr native_outputStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (native_refUpdates, JniHandleOwnership.DoNotTransfer);
			var outputStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_outputStream, JniHandleOwnership.DoNotTransfer);
			__this.DoPush (monitor, refUpdates, outputStream);
		}
#pragma warning restore 0169

		/// <param name="monitor">progress monitor to receive status updates.</param>
		/// <param name="refUpdates">update commands to be applied to the remote repository.</param>
		/// <param name="outputStream">output stream to write sideband messages to</param>
		/// <summary>Push one or more objects and update the remote repository.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/method[@name='doPush' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.transport.RemoteRefUpdate&gt;'] and parameter[3][@type='java.io.OutputStream']]"
		[Register ("doPush", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;Ljava/io/OutputStream;)V", "GetDoPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe void DoPush (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> refUpdates, global::System.IO.Stream outputStream)
		{
			const string __id = "doPush.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;Ljava/io/OutputStream;)V";
			IntPtr native_refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.ToLocalJniHandle (refUpdates);
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_refUpdates);
				__args [2] = new JniArgumentValue (native_outputStream);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refUpdates);
				JNIEnv.DeleteLocalRef (native_outputStream);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (refUpdates);
				global::System.GC.KeepAlive (outputStream);
			}
		}

		static Delegate cb_noRepository;
#pragma warning disable 0169
		static Delegate GetNoRepositoryHandler ()
		{
			if (cb_noRepository == null)
				cb_noRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NoRepository);
			return cb_noRepository;
		}

		static IntPtr n_NoRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NoRepository ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/method[@name='noRepository' and count(parameter)=0]"
		[Register ("noRepository", "()Lorg/eclipse/jgit/errors/TransportException;", "GetNoRepositoryHandler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Errors.TransportException NoRepository ()
		{
			const string __id = "noRepository.()Lorg/eclipse/jgit/errors/TransportException;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.TransportException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (native_refUpdates, JniHandleOwnership.DoNotTransfer);
			__this.Push (monitor, refUpdates);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/method[@name='push' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.transport.RemoteRefUpdate&gt;']]"
		[Register ("push", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;)V", "GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Handler")]
		public virtual unsafe void Push (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> refUpdates)
		{
			const string __id = "push.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;)V";
			IntPtr native_refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.ToLocalJniHandle (refUpdates);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_refUpdates);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refUpdates);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (refUpdates);
			}
		}

		static Delegate cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_Handler ()
		{
			if (cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ == null)
				cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_);
			return cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_;
		}

		static void n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_refUpdates, IntPtr native_outputStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (native_refUpdates, JniHandleOwnership.DoNotTransfer);
			var outputStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_outputStream, JniHandleOwnership.DoNotTransfer);
			__this.Push (monitor, refUpdates, outputStream);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackPushConnection']/method[@name='push' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.transport.RemoteRefUpdate&gt;'] and parameter[3][@type='java.io.OutputStream']]"
		[Register ("push", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;Ljava/io/OutputStream;)V", "GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Map_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Push (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> refUpdates, global::System.IO.Stream outputStream)
		{
			const string __id = "push.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Map;Ljava/io/OutputStream;)V";
			IntPtr native_refUpdates = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.ToLocalJniHandle (refUpdates);
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_refUpdates);
				__args [2] = new JniArgumentValue (native_outputStream);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refUpdates);
				JNIEnv.DeleteLocalRef (native_outputStream);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (refUpdates);
				global::System.GC.KeepAlive (outputStream);
			}
		}

		static Delegate cb_endOut;
#pragma warning disable 0169
		static Delegate GetEndOutHandler ()
		{
			if (cb_endOut == null)
				cb_endOut = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EndOut);
			return cb_endOut;
		}

		static void n_EndOut (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndOut ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackConnection']/method[@name='endOut' and count(parameter)=0]"
		[Register ("endOut", "()V", "GetEndOutHandler")]
		protected virtual unsafe void EndOut ()
		{
			const string __id = "endOut.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackConnection']/method[@name='init' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("init", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "")]
		protected unsafe void Init (global::System.IO.Stream myIn, global::System.IO.Stream myOut)
		{
			const string __id = "init.(Ljava/io/InputStream;Ljava/io/OutputStream;)V";
			IntPtr native_myIn = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (myIn);
			IntPtr native_myOut = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (myOut);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_myIn);
				__args [1] = new JniArgumentValue (native_myOut);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_myIn);
				JNIEnv.DeleteLocalRef (native_myOut);
				global::System.GC.KeepAlive (myIn);
				global::System.GC.KeepAlive (myOut);
			}
		}

		static Delegate cb_isCapableOf_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsCapableOf_Ljava_lang_String_Handler ()
		{
			if (cb_isCapableOf_Ljava_lang_String_ == null)
				cb_isCapableOf_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsCapableOf_Ljava_lang_String_);
			return cb_isCapableOf_Ljava_lang_String_;
		}

		static bool n_IsCapableOf_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_option)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var option = JNIEnv.GetString (native_option, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsCapableOf (option);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackConnection']/method[@name='isCapableOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isCapableOf", "(Ljava/lang/String;)Z", "GetIsCapableOf_Ljava_lang_String_Handler")]
		protected virtual unsafe bool IsCapableOf (string option)
		{
			const string __id = "isCapableOf.(Ljava/lang/String;)Z";
			IntPtr native_option = JNIEnv.NewString ((string)option);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_option);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_option);
			}
		}

		static Delegate cb_readAdvertisedRefs;
#pragma warning disable 0169
		static Delegate GetReadAdvertisedRefsHandler ()
		{
			if (cb_readAdvertisedRefs == null)
				cb_readAdvertisedRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReadAdvertisedRefs);
			return cb_readAdvertisedRefs;
		}

		static void n_ReadAdvertisedRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadAdvertisedRefs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackConnection']/method[@name='readAdvertisedRefs' and count(parameter)=0]"
		[Register ("readAdvertisedRefs", "()V", "GetReadAdvertisedRefsHandler")]
		protected virtual unsafe void ReadAdvertisedRefs ()
		{
			const string __id = "readAdvertisedRefs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_wantCapability_Ljava_lang_StringBuilder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWantCapability_Ljava_lang_StringBuilder_Ljava_lang_String_Handler ()
		{
			if (cb_wantCapability_Ljava_lang_StringBuilder_Ljava_lang_String_ == null)
				cb_wantCapability_Ljava_lang_StringBuilder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_WantCapability_Ljava_lang_StringBuilder_Ljava_lang_String_);
			return cb_wantCapability_Ljava_lang_StringBuilder_Ljava_lang_String_;
		}

		static bool n_WantCapability_Ljava_lang_StringBuilder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_b, IntPtr native_option)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackPushConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_b, JniHandleOwnership.DoNotTransfer);
			var option = JNIEnv.GetString (native_option, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.WantCapability (b, option);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackConnection']/method[@name='wantCapability' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='java.lang.String']]"
		[Register ("wantCapability", "(Ljava/lang/StringBuilder;Ljava/lang/String;)Z", "GetWantCapability_Ljava_lang_StringBuilder_Ljava_lang_String_Handler")]
		protected virtual unsafe bool WantCapability (global::Java.Lang.StringBuilder b, string option)
		{
			const string __id = "wantCapability.(Ljava/lang/StringBuilder;Ljava/lang/String;)Z";
			IntPtr native_option = JNIEnv.NewString ((string)option);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (native_option);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_option);
				global::System.GC.KeepAlive (b);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BasePackPushConnection", DoNotGenerateAcw=true)]
	internal partial class BasePackPushConnectionInvoker : BasePackPushConnection {
		public BasePackPushConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BasePackPushConnection", typeof (BasePackPushConnectionInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
