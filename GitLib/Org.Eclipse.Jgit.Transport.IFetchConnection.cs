using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Lists known refs from the remote and copies objects of selected refs.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='FetchConnection']"
	[Register ("org/eclipse/jgit/transport/FetchConnection", "", "Org.Eclipse.Jgit.Transport.IFetchConnectionInvoker")]
	public partial interface IFetchConnection : global::Org.Eclipse.Jgit.Transport.IConnection {
		global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock> PackLocks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='FetchConnection']/method[@name='getPackLocks' and count(parameter)=0]"
			[Register ("getPackLocks", "()Ljava/util/Collection;", "GetGetPackLocksHandler:Org.Eclipse.Jgit.Transport.IFetchConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='FetchConnection']/method[@name='didFetchIncludeTags' and count(parameter)=0]"
		/// <summary>Did the last <c>#fetch(ProgressMonitor, Collection, Set)</c> get tags?</summary>
		/// <returns>true if the last fetch call implicitly included tag objects;
		///         false if tags were not implicitly obtained.</returns>
		[Register ("didFetchIncludeTags", "()Z", "GetDidFetchIncludeTagsHandler:Org.Eclipse.Jgit.Transport.IFetchConnectionInvoker, AndroidBindableLibrary")]
		bool DidFetchIncludeTags ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='FetchConnection']/method[@name='didFetchTestConnectivity' and count(parameter)=0]"
		/// <summary>Did the last <c>#fetch(ProgressMonitor, Collection, Set)</c> validate
		/// graph?</summary>
		/// <returns>true if the last fetch had to perform a connectivity check on the
		///         client side in order to succeed; false if the last fetch assumed
		///         the remote peer supplied a complete graph.</returns>
		[Register ("didFetchTestConnectivity", "()Z", "GetDidFetchTestConnectivityHandler:Org.Eclipse.Jgit.Transport.IFetchConnectionInvoker, AndroidBindableLibrary")]
		bool DidFetchTestConnectivity ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='FetchConnection']/method[@name='fetch' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.lib.Ref&gt;'] and parameter[3][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
		/// <param name="monitor">progress monitor to inform the end-user about the amount of
		///            work completed, or to indicate cancellation. Implementations
		///            should poll the monitor at regular intervals to look for
		///            cancellation requests from the user.</param>
		/// <param name="want">one or more refs advertised by this connection that the caller
		///            wants to store locally.</param>
		/// <param name="have">additional objects known to exist in the destination
		///            repository, especially if they aren't yet reachable by the ref
		///            database. Connections should take this set as an addition to
		///            what is reachable through all Refs, not in replace of it.</param>
		/// <summary>Fetch objects we don't have but that are reachable from advertised refs.</summary>
		[Register ("fetch", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;)V", "GetFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Handler:Org.Eclipse.Jgit.Transport.IFetchConnectionInvoker, AndroidBindableLibrary")]
		void Fetch (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> want, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> have);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='FetchConnection']/method[@name='fetch' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.lib.Ref&gt;'] and parameter[3][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[4][@type='java.io.OutputStream']]"
		/// <param name="monitor">progress monitor to inform the end-user about the amount of
		///            work completed, or to indicate cancellation. Implementations
		///            should poll the monitor at regular intervals to look for
		///            cancellation requests from the user.</param>
		/// <param name="want">one or more refs advertised by this connection that the caller
		///            wants to store locally.</param>
		/// <param name="have">additional objects known to exist in the destination
		///            repository, especially if they aren't yet reachable by the ref
		///            database. Connections should take this set as an addition to
		///            what is reachable through all Refs, not in replace of it.</param>
		/// <param name="out">OutputStream to write sideband messages to</param>
		/// <summary>Fetch objects we don't have but that are reachable from advertised refs.</summary>
		[Register ("fetch", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;Ljava/io/OutputStream;)V", "GetFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_Handler:Org.Eclipse.Jgit.Transport.IFetchConnectionInvoker, AndroidBindableLibrary")]
		void Fetch (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> want, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> have, global::System.IO.Stream @out);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='FetchConnection']/method[@name='setPackLockMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		/// <param name="message">message to use when holding a pack in place.</param>
		/// <summary>Set the lock message used when holding a pack out of garbage collection.</summary>
		[Register ("setPackLockMessage", "(Ljava/lang/String;)V", "GetSetPackLockMessage_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Transport.IFetchConnectionInvoker, AndroidBindableLibrary")]
		void SetPackLockMessage (string message);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/FetchConnection", DoNotGenerateAcw=true)]
	internal partial class IFetchConnectionInvoker : global::Java.Lang.Object, IFetchConnection {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/FetchConnection", typeof (IFetchConnectionInvoker));

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

		public static IFetchConnection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFetchConnection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.FetchConnection'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFetchConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock>.ToLocalJniHandle (__this.PackLocks);
		}
#pragma warning restore 0169

		IntPtr id_getPackLocks;
		public unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock> PackLocks {
			get {
				if (id_getPackLocks == IntPtr.Zero)
					id_getPackLocks = JNIEnv.GetMethodID (class_ref, "getPackLocks", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackLocks), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DidFetchIncludeTags ();
		}
#pragma warning restore 0169

		IntPtr id_didFetchIncludeTags;
		public unsafe bool DidFetchIncludeTags ()
		{
			if (id_didFetchIncludeTags == IntPtr.Zero)
				id_didFetchIncludeTags = JNIEnv.GetMethodID (class_ref, "didFetchIncludeTags", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_didFetchIncludeTags);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DidFetchTestConnectivity ();
		}
#pragma warning restore 0169

		IntPtr id_didFetchTestConnectivity;
		public unsafe bool DidFetchTestConnectivity ()
		{
			if (id_didFetchTestConnectivity == IntPtr.Zero)
				id_didFetchTestConnectivity = JNIEnv.GetMethodID (class_ref, "didFetchTestConnectivity", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_didFetchTestConnectivity);
		}

		static Delegate cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Handler ()
		{
			if (cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_ == null)
				cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_);
			return cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_;
		}

		static void n_Fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_want, IntPtr native_have)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (native_want, JniHandleOwnership.DoNotTransfer);
			var have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_have, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (monitor, want, have);
		}
#pragma warning restore 0169

		IntPtr id_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_;
		public unsafe void Fetch (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> want, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> have)
		{
			if (id_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_ == IntPtr.Zero)
				id_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "fetch", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;)V");
			IntPtr native_want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (want);
			IntPtr native_have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (have);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
			__args [1] = new JValue (native_want);
			__args [2] = new JValue (native_have);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_, __args);
			JNIEnv.DeleteLocalRef (native_want);
			JNIEnv.DeleteLocalRef (native_have);
		}

		static Delegate cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_Handler ()
		{
			if (cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_ == null)
				cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_);
			return cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_;
		}

		static void n_Fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_want, IntPtr native_have, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (native_want, JniHandleOwnership.DoNotTransfer);
			var have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_have, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (monitor, want, have, @out);
		}
#pragma warning restore 0169

		IntPtr id_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_;
		public unsafe void Fetch (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> want, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> have, global::System.IO.Stream @out)
		{
			if (id_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "fetch", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Set;Ljava/io/OutputStream;)V");
			IntPtr native_want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (want);
			IntPtr native_have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (have);
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
			__args [1] = new JValue (native_want);
			__args [2] = new JValue (native_have);
			__args [3] = new JValue (native__out);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Set_Ljava_io_OutputStream_, __args);
			JNIEnv.DeleteLocalRef (native_want);
			JNIEnv.DeleteLocalRef (native_have);
			JNIEnv.DeleteLocalRef (native__out);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.SetPackLockMessage (message);
		}
#pragma warning restore 0169

		IntPtr id_setPackLockMessage_Ljava_lang_String_;
		public unsafe void SetPackLockMessage (string message)
		{
			if (id_setPackLockMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_setPackLockMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPackLockMessage", "(Ljava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString ((string)message);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_message);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPackLockMessage_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_message);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
