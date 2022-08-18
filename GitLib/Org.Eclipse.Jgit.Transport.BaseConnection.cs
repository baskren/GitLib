using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Base helper class for implementing operations connections.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BaseConnection", DoNotGenerateAcw=true)]
	public abstract partial class BaseConnection : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.IConnection {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BaseConnection", typeof (BaseConnection));

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

		protected BaseConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/constructor[@name='BaseConnection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseConnection () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getMessageWriter;
#pragma warning disable 0169
		static Delegate GetGetMessageWriterHandler ()
		{
			if (cb_getMessageWriter == null)
				cb_getMessageWriter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessageWriter);
			return cb_getMessageWriter;
		}

		static IntPtr n_GetMessageWriter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessageWriter);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageWriter_Ljava_io_Writer_;
#pragma warning disable 0169
		static Delegate GetSetMessageWriter_Ljava_io_Writer_Handler ()
		{
			if (cb_setMessageWriter_Ljava_io_Writer_ == null)
				cb_setMessageWriter_Ljava_io_Writer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMessageWriter_Ljava_io_Writer_);
			return cb_setMessageWriter_Ljava_io_Writer_;
		}

		static void n_SetMessageWriter_Ljava_io_Writer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_writer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var writer = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_writer, JniHandleOwnership.DoNotTransfer);
			__this.MessageWriter = writer;
		}
#pragma warning restore 0169

		/// <summary>Get the writer that buffers messages from the remote side. -or- Set the writer that buffers messages from the remote side.</summary>
		/// <returns>writer to store messages from the remote.</returns>
		/// <param name="writer">the writer that messages will be delivered to. The writer's
		///            <c>toString()</c> method should be overridden to return the
		///            complete contents.</param>
		protected virtual unsafe global::Java.IO.Writer MessageWriter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='getMessageWriter' and count(parameter)=0]"
			[Register ("getMessageWriter", "()Ljava/io/Writer;", "GetGetMessageWriterHandler")]
			get {
				const string __id = "getMessageWriter.()Ljava/io/Writer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='setMessageWriter' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
			[Register ("setMessageWriter", "(Ljava/io/Writer;)V", "GetSetMessageWriter_Ljava_io_Writer_Handler")]
			set {
				const string __id = "setMessageWriter.(Ljava/io/Writer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Messages);
		}
#pragma warning restore 0169

		public virtual unsafe string Messages {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='getMessages' and count(parameter)=0]"
			[Register ("getMessages", "()Ljava/lang/String;", "GetGetMessagesHandler")]
			get {
				const string __id = "getMessages.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> Refs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='getRefs' and count(parameter)=0]"
			[Register ("getRefs", "()Ljava/util/Collection;", "")]
			get {
				const string __id = "getRefs.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.RefsMap);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> RefsMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='getRefsMap' and count(parameter)=0]"
			[Register ("getRefsMap", "()Ljava/util/Map;", "GetGetRefsMapHandler")]
			get {
				const string __id = "getRefsMap.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_available_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAvailable_Ljava_util_Map_Handler ()
		{
			if (cb_available_Ljava_util_Map_ == null)
				cb_available_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Available_Ljava_util_Map_);
			return cb_available_Ljava_util_Map_;
		}

		static void n_Available_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_all)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var all = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (native_all, JniHandleOwnership.DoNotTransfer);
			__this.Available (all);
		}
#pragma warning restore 0169

		/// <param name="all">the complete list of refs the remote has to offer. This map
		///            will be wrapped in an unmodifiable way to protect it, but it
		///            does not get copied.</param>
		/// <summary>Denote the list of refs available on the remote repository.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='available' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.lib.Ref&gt;']]"
		[Register ("available", "(Ljava/util/Map;)V", "GetAvailable_Ljava_util_Map_Handler")]
		protected virtual unsafe void Available (global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> all)
		{
			const string __id = "available.(Ljava/util/Map;)V";
			IntPtr native_all = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (all);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_all);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_all);
				global::System.GC.KeepAlive (all);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='getRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "")]
		public unsafe global::Org.Eclipse.Jgit.Lib.IRef GetRef (string name)
		{
			const string __id = "getRef.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_markStartedOperation;
#pragma warning disable 0169
		static Delegate GetMarkStartedOperationHandler ()
		{
			if (cb_markStartedOperation == null)
				cb_markStartedOperation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MarkStartedOperation);
			return cb_markStartedOperation;
		}

		static void n_MarkStartedOperation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkStartedOperation ();
		}
#pragma warning restore 0169

		/// <summary>Helper method for ensuring one-operation per connection.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='markStartedOperation' and count(parameter)=0]"
		[Register ("markStartedOperation", "()V", "GetMarkStartedOperationHandler")]
		protected virtual unsafe void MarkStartedOperation ()
		{
			const string __id = "markStartedOperation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BaseConnection", DoNotGenerateAcw=true)]
	internal partial class BaseConnectionInvoker : BaseConnection {
		public BaseConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BaseConnection", typeof (BaseConnectionInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
