using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Fetch implementation using the native Git pack transfer service.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BasePackFetchConnection", DoNotGenerateAcw=true)]
	public abstract partial class BasePackFetchConnection : global::Org.Eclipse.Jgit.Transport.BaseConnection, global::Org.Eclipse.Jgit.Transport.IFetchConnection {
		/// <summary>Amount of data the client sends before starting to read.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='MIN_CLIENT_BUFFER']"
		[Register ("MIN_CLIENT_BUFFER")]
		protected const int MinClientBuffer = (int) 2952;

		/// <summary>The client supports fetching objects at the tip of any ref, even if not
		/// advertised.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_ALLOW_TIP_SHA1_IN_WANT']"
		[Register ("OPTION_ALLOW_TIP_SHA1_IN_WANT")]
		public const string OptionAllowTipSha1InWant = (string) "allow-tip-sha1-in-want";

		/// <summary>Include tags if we are also including the referenced objects.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_INCLUDE_TAG']"
		[Register ("OPTION_INCLUDE_TAG")]
		public const string OptionIncludeTag = (string) "include-tag";

		/// <summary>Mutli-ACK support for improved negotiation.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_MULTI_ACK']"
		[Register ("OPTION_MULTI_ACK")]
		public const string OptionMultiAck = (string) "multi_ack";

		/// <summary>Mutli-ACK detailed support for improved negotiation.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_MULTI_ACK_DETAILED']"
		[Register ("OPTION_MULTI_ACK_DETAILED")]
		public const string OptionMultiAckDetailed = (string) "multi_ack_detailed";

		/// <summary>The client supports receiving a pack before it has sent "done".</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_NO_DONE']"
		[Register ("OPTION_NO_DONE")]
		public const string OptionNoDone = (string) "no-done";

		/// <summary>The client does not want progress messages and will ignore them.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_NO_PROGRESS']"
		[Register ("OPTION_NO_PROGRESS")]
		public const string OptionNoProgress = (string) "no-progress";

		/// <summary>The client supports packs with OFS deltas.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_OFS_DELTA']"
		[Register ("OPTION_OFS_DELTA")]
		public const string OptionOfsDelta = (string) "ofs-delta";

		/// <summary>The client supports shallow fetches.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_SHALLOW']"
		[Register ("OPTION_SHALLOW")]
		public const string OptionShallow = (string) "shallow";

		/// <summary>The client supports using the side-band for progress messages.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_SIDE_BAND']"
		[Register ("OPTION_SIDE_BAND")]
		public const string OptionSideBand = (string) "side-band";

		/// <summary>The client supports using the 64K side-band for progress messages.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_SIDE_BAND_64K']"
		[Register ("OPTION_SIDE_BAND_64K")]
		public const string OptionSideBand64k = (string) "side-band-64k";

		/// <summary>The client supports packs with deltas but not their bases.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/field[@name='OPTION_THIN_PACK']"
		[Register ("OPTION_THIN_PACK")]
		public const string OptionThinPack = (string) "thin-pack";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BasePackFetchConnection", typeof (BasePackFetchConnection));

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

		protected BasePackFetchConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="packTransport">the transport.</param>
		/// <summary>Create a new connection to fetch using the native git transport.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/constructor[@name='BasePackFetchConnection' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PackTransport']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/transport/PackTransport;)V", "")]
		public unsafe BasePackFetchConnection (global::Org.Eclipse.Jgit.Transport.IPackTransport packTransport) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getPackLocks;
#pragma warning disable 0169
		static Delegate GetGetPackLocksHandler ()
		{
			if (cb_getPackLocks == null)
				cb_getPackLocks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackLocks);
			return cb_getPackLocks;
		}

		static IntPtr n_GetPackLocks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock>.ToLocalJniHandle (__this.PackLocks);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock> PackLocks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/method[@name='getPackLocks' and count(parameter)=0]"
			[Register ("getPackLocks", "()Ljava/util/Collection;", "GetGetPackLocksHandler")]
			get {
				const string __id = "getPackLocks.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_didFetchIncludeTags;
#pragma warning disable 0169
		static Delegate GetDidFetchIncludeTagsHandler ()
		{
			if (cb_didFetchIncludeTags == null)
				cb_didFetchIncludeTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DidFetchIncludeTags);
			return cb_didFetchIncludeTags;
		}

		static bool n_DidFetchIncludeTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DidFetchIncludeTags ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/method[@name='didFetchIncludeTags' and count(parameter)=0]"
		[Register ("didFetchIncludeTags", "()Z", "GetDidFetchIncludeTagsHandler")]
		public virtual unsafe bool DidFetchIncludeTags ()
		{
			const string __id = "didFetchIncludeTags.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_didFetchTestConnectivity;
#pragma warning disable 0169
		static Delegate GetDidFetchTestConnectivityHandler ()
		{
			if (cb_didFetchTestConnectivity == null)
				cb_didFetchTestConnectivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DidFetchTestConnectivity);
			return cb_didFetchTestConnectivity;
		}

		static bool n_DidFetchTestConnectivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DidFetchTestConnectivity ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/method[@name='didFetchTestConnectivity' and count(parameter)=0]"
		[Register ("didFetchTestConnectivity", "()Z", "GetDidFetchTestConnectivityHandler")]
		public virtual unsafe bool DidFetchTestConnectivity ()
		{
			const string __id = "didFetchTestConnectivity.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_doFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDoFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_Handler ()
		{
			if (cb_doFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_ == null)
				cb_doFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_DoFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_);
			return cb_doFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_;
		}

		static void n_DoFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_want, IntPtr native_have, IntPtr native_outputStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (native_want, JniHandleOwnership.DoNotTransfer);
			var have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_have, JniHandleOwnership.DoNotTransfer);
			var outputStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_outputStream, JniHandleOwnership.DoNotTransfer);
			__this.DoFetch (monitor, want, have, outputStream);
		}
#pragma warning restore 0169

		/// <param name="monitor">progress monitor to receive status updates. If the monitor is
		///            the <c>NullProgressMonitor#INSTANCE</c>, then the no-progress
		///            option enabled.</param>
		/// <param name="want">the advertised remote references the caller wants to fetch.</param>
		/// <param name="have">additional objects to assume that already exist locally. This
		///            will be added to the set of objects reachable from the
		///            destination repository's references.</param>
		/// <param name="outputStream">ouputStream to write sideband messages to</param>
		/// <summary>Execute common ancestor negotiation and fetch the objects.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/method[@name='doFetch' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.lib.Ref&gt;'] and parameter[3][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[4][@type='java.io.OutputStream']]"
		[Register ("doFetch", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;Ljava/io/OutputStream;)V", "GetDoFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe void DoFetch (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> want, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> have, global::System.IO.Stream outputStream)
		{
			const string __id = "doFetch.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;Ljava/io/OutputStream;)V";
			IntPtr native_want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (want);
			IntPtr native_have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (have);
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_want);
				__args [2] = new JniArgumentValue (native_have);
				__args [3] = new JniArgumentValue (native_outputStream);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_want);
				JNIEnv.DeleteLocalRef (native_have);
				JNIEnv.DeleteLocalRef (native_outputStream);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (want);
				global::System.GC.KeepAlive (have);
				global::System.GC.KeepAlive (outputStream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/method[@name='fetch' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.lib.Ref&gt;'] and parameter[3][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("fetch", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;)V", "")]
		public unsafe void Fetch (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> want, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> have)
		{
			const string __id = "fetch.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;)V";
			IntPtr native_want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (want);
			IntPtr native_have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (have);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_want);
				__args [2] = new JniArgumentValue (native_have);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_want);
				JNIEnv.DeleteLocalRef (native_have);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (want);
				global::System.GC.KeepAlive (have);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/method[@name='fetch' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.lib.Ref&gt;'] and parameter[3][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[4][@type='java.io.OutputStream']]"
		[Register ("fetch", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;Ljava/io/OutputStream;)V", "")]
		public unsafe void Fetch (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> want, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> have, global::System.IO.Stream outputStream)
		{
			const string __id = "fetch.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;Ljava/io/OutputStream;)V";
			IntPtr native_want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (want);
			IntPtr native_have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (have);
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_want);
				__args [2] = new JniArgumentValue (native_have);
				__args [3] = new JniArgumentValue (native_outputStream);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_want);
				JNIEnv.DeleteLocalRef (native_have);
				JNIEnv.DeleteLocalRef (native_outputStream);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (want);
				global::System.GC.KeepAlive (have);
				global::System.GC.KeepAlive (outputStream);
			}
		}

		static Delegate cb_onReceivePack;
#pragma warning disable 0169
		static Delegate GetOnReceivePackHandler ()
		{
			if (cb_onReceivePack == null)
				cb_onReceivePack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnReceivePack);
			return cb_onReceivePack;
		}

		static void n_OnReceivePack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReceivePack ();
		}
#pragma warning restore 0169

		/// <summary>Notification event delivered just before the pack is received from the
		/// network.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/method[@name='onReceivePack' and count(parameter)=0]"
		[Register ("onReceivePack", "()V", "GetOnReceivePackHandler")]
		protected virtual unsafe void OnReceivePack ()
		{
			const string __id = "onReceivePack.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setPackLockMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPackLockMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setPackLockMessage_Ljava_lang_String_ == null)
				cb_setPackLockMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPackLockMessage_Ljava_lang_String_);
			return cb_setPackLockMessage_Ljava_lang_String_;
		}

		static void n_SetPackLockMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.SetPackLockMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackFetchConnection']/method[@name='setPackLockMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPackLockMessage", "(Ljava/lang/String;)V", "GetSetPackLockMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void SetPackLockMessage (string message)
		{
			const string __id = "setPackLockMessage.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NoRepository ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BasePackConnection']/method[@name='noRepository' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BasePackFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BasePackFetchConnection", DoNotGenerateAcw=true)]
	internal partial class BasePackFetchConnectionInvoker : BasePackFetchConnection {
		public BasePackFetchConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BasePackFetchConnection", typeof (BasePackFetchConnectionInvoker));

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
