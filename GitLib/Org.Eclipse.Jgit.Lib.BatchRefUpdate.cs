using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Batch of reference updates to be applied to a repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BatchRefUpdate", DoNotGenerateAcw=true)]
	public partial class BatchRefUpdate : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BatchRefUpdate", typeof (BatchRefUpdate));

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

		protected BatchRefUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="refdb">the reference database of the repository to be updated.</param>
		/// <summary>Initialize a new batch update.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/constructor[@name='BatchRefUpdate' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.RefDatabase']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/RefDatabase;)V", "")]
		protected unsafe BatchRefUpdate (global::Org.Eclipse.Jgit.Lib.RefDatabase refdb) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/RefDatabase;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((refdb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refdb).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (refdb);
			}
		}

		static Delegate cb_getCommands;
#pragma warning disable 0169
		static Delegate GetGetCommandsHandler ()
		{
			if (cb_getCommands == null)
				cb_getCommands = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommands);
			return cb_getCommands;
		}

		static IntPtr n_GetCommands (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.ToLocalJniHandle (__this.Commands);
		}
#pragma warning restore 0169

		/// <returns>commands this update will process.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> Commands {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='getCommands' and count(parameter)=0]"
			[Register ("getCommands", "()Ljava/util/List;", "GetGetCommandsHandler")]
			get {
				const string __id = "getCommands.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAllowNonFastForwards;
#pragma warning disable 0169
		static Delegate GetIsAllowNonFastForwardsHandler ()
		{
			if (cb_isAllowNonFastForwards == null)
				cb_isAllowNonFastForwards = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAllowNonFastForwards);
			return cb_isAllowNonFastForwards;
		}

		static bool n_IsAllowNonFastForwards (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAllowNonFastForwards;
		}
#pragma warning restore 0169

		/// <returns>true if the batch update will permit a non-fast-forward update to
		///         an existing reference.</returns>
		public virtual unsafe bool IsAllowNonFastForwards {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='isAllowNonFastForwards' and count(parameter)=0]"
			[Register ("isAllowNonFastForwards", "()Z", "GetIsAllowNonFastForwardsHandler")]
			get {
				const string __id = "isAllowNonFastForwards.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRefLogDisabled;
#pragma warning disable 0169
		static Delegate GetIsRefLogDisabledHandler ()
		{
			if (cb_isRefLogDisabled == null)
				cb_isRefLogDisabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRefLogDisabled);
			return cb_isRefLogDisabled;
		}

		static bool n_IsRefLogDisabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRefLogDisabled;
		}
#pragma warning restore 0169

		/// <returns>true if log has been disabled by <c>#disableRefLog()</c>.</returns>
		public virtual unsafe bool IsRefLogDisabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='isRefLogDisabled' and count(parameter)=0]"
			[Register ("isRefLogDisabled", "()Z", "GetIsRefLogDisabledHandler")]
			get {
				const string __id = "isRefLogDisabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRefLogIncludingResult;
#pragma warning disable 0169
		static Delegate GetIsRefLogIncludingResultHandler ()
		{
			if (cb_isRefLogIncludingResult == null)
				cb_isRefLogIncludingResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRefLogIncludingResult);
			return cb_isRefLogIncludingResult;
		}

		static bool n_IsRefLogIncludingResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRefLogIncludingResult;
		}
#pragma warning restore 0169

		/// <returns>
		///   <c>true</c> if the ref log message should show the result.</returns>
		public virtual unsafe bool IsRefLogIncludingResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='isRefLogIncludingResult' and count(parameter)=0]"
			[Register ("isRefLogIncludingResult", "()Z", "GetIsRefLogIncludingResultHandler")]
			get {
				const string __id = "isRefLogIncludingResult.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRefLogIdent;
#pragma warning disable 0169
		static Delegate GetGetRefLogIdentHandler ()
		{
			if (cb_getRefLogIdent == null)
				cb_getRefLogIdent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefLogIdent);
			return cb_getRefLogIdent;
		}

		static IntPtr n_GetRefLogIdent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefLogIdent);
		}
#pragma warning restore 0169

		/// <returns>identity of the user making the change in the reflog.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent RefLogIdent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='getRefLogIdent' and count(parameter)=0]"
			[Register ("getRefLogIdent", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetRefLogIdentHandler")]
			get {
				const string __id = "getRefLogIdent.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefLogMessage;
#pragma warning disable 0169
		static Delegate GetGetRefLogMessageHandler ()
		{
			if (cb_getRefLogMessage == null)
				cb_getRefLogMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefLogMessage);
			return cb_getRefLogMessage;
		}

		static IntPtr n_GetRefLogMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefLogMessage);
		}
#pragma warning restore 0169

		/// <summary>Get the message to include in the reflog.</summary>
		/// <returns>message the caller wants to include in the reflog; null if the
		///         update should not be logged.</returns>
		public virtual unsafe string RefLogMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='getRefLogMessage' and count(parameter)=0]"
			[Register ("getRefLogMessage", "()Ljava/lang/String;", "GetGetRefLogMessageHandler")]
			get {
				const string __id = "getRefLogMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addCommand_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddCommand_Ljava_util_Collection_Handler ()
		{
			if (cb_addCommand_Ljava_util_Collection_ == null)
				cb_addCommand_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddCommand_Ljava_util_Collection_);
			return cb_addCommand_Ljava_util_Collection_;
		}

		static IntPtr n_AddCommand_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmd = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.FromJniHandle (native_cmd, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCommand (cmd));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="cmd">the commands to add, must not be null.</param>
		/// <summary>Add commands to this batch update.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='addCommand' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.transport.ReceiveCommand&gt;']]"
		[Register ("addCommand", "(Ljava/util/Collection;)Lorg/eclipse/jgit/lib/BatchRefUpdate;", "GetAddCommand_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.BatchRefUpdate AddCommand (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> cmd)
		{
			const string __id = "addCommand.(Ljava/util/Collection;)Lorg/eclipse/jgit/lib/BatchRefUpdate;";
			IntPtr native_cmd = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.ToLocalJniHandle (cmd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cmd);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cmd);
				global::System.GC.KeepAlive (cmd);
			}
		}

		static Delegate cb_addCommand_Lorg_eclipse_jgit_transport_ReceiveCommand_;
#pragma warning disable 0169
		static Delegate GetAddCommand_Lorg_eclipse_jgit_transport_ReceiveCommand_Handler ()
		{
			if (cb_addCommand_Lorg_eclipse_jgit_transport_ReceiveCommand_ == null)
				cb_addCommand_Lorg_eclipse_jgit_transport_ReceiveCommand_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddCommand_Lorg_eclipse_jgit_transport_ReceiveCommand_);
			return cb_addCommand_Lorg_eclipse_jgit_transport_ReceiveCommand_;
		}

		static IntPtr n_AddCommand_Lorg_eclipse_jgit_transport_ReceiveCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmd = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (native_cmd, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCommand (cmd));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="cmd">the command to add, must not be null.</param>
		/// <summary>Add a single command to this batch update.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='addCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.ReceiveCommand']]"
		[Register ("addCommand", "(Lorg/eclipse/jgit/transport/ReceiveCommand;)Lorg/eclipse/jgit/lib/BatchRefUpdate;", "GetAddCommand_Lorg_eclipse_jgit_transport_ReceiveCommand_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.BatchRefUpdate AddCommand (global::Org.Eclipse.Jgit.Transport.ReceiveCommand cmd)
		{
			const string __id = "addCommand.(Lorg/eclipse/jgit/transport/ReceiveCommand;)Lorg/eclipse/jgit/lib/BatchRefUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cmd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmd).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cmd);
			}
		}

		static Delegate cb_addCommand_arrayLorg_eclipse_jgit_transport_ReceiveCommand_;
#pragma warning disable 0169
		static Delegate GetAddCommand_arrayLorg_eclipse_jgit_transport_ReceiveCommand_Handler ()
		{
			if (cb_addCommand_arrayLorg_eclipse_jgit_transport_ReceiveCommand_ == null)
				cb_addCommand_arrayLorg_eclipse_jgit_transport_ReceiveCommand_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddCommand_arrayLorg_eclipse_jgit_transport_ReceiveCommand_);
			return cb_addCommand_arrayLorg_eclipse_jgit_transport_ReceiveCommand_;
		}

		static IntPtr n_AddCommand_arrayLorg_eclipse_jgit_transport_ReceiveCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmd = (global::Org.Eclipse.Jgit.Transport.ReceiveCommand[]) JNIEnv.GetArray (native_cmd, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Transport.ReceiveCommand));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCommand (cmd));
			if (cmd != null)
				JNIEnv.CopyArray (cmd, native_cmd);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='addCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.ReceiveCommand...']]"
		[Register ("addCommand", "([Lorg/eclipse/jgit/transport/ReceiveCommand;)Lorg/eclipse/jgit/lib/BatchRefUpdate;", "GetAddCommand_arrayLorg_eclipse_jgit_transport_ReceiveCommand_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.BatchRefUpdate AddCommand (params global::Org.Eclipse.Jgit.Transport.ReceiveCommand[] cmd)
		{
			const string __id = "addCommand.([Lorg/eclipse/jgit/transport/ReceiveCommand;)Lorg/eclipse/jgit/lib/BatchRefUpdate;";
			IntPtr native_cmd = JNIEnv.NewArray (cmd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cmd);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (cmd != null) {
					JNIEnv.CopyArray (native_cmd, cmd);
					JNIEnv.DeleteLocalRef (native_cmd);
				}
				global::System.GC.KeepAlive (cmd);
			}
		}

		static Delegate cb_disableRefLog;
#pragma warning disable 0169
		static Delegate GetDisableRefLogHandler ()
		{
			if (cb_disableRefLog == null)
				cb_disableRefLog = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DisableRefLog);
			return cb_disableRefLog;
		}

		static IntPtr n_DisableRefLog (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisableRefLog ());
		}
#pragma warning restore 0169

		/// <summary>Don't record this update in the ref's associated reflog.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='disableRefLog' and count(parameter)=0]"
		[Register ("disableRefLog", "()Lorg/eclipse/jgit/lib/BatchRefUpdate;", "GetDisableRefLogHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.BatchRefUpdate DisableRefLog ()
		{
			const string __id = "disableRefLog.()Lorg/eclipse/jgit/lib/BatchRefUpdate;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_execute_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetExecute_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_execute_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_execute_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Execute_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_execute_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static void n_Execute_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walk, IntPtr native_monitor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			__this.Execute (walk, monitor);
		}
#pragma warning restore 0169

		/// <param name="walk">a RevWalk to parse tags in case the storage system wants to
		///            store them pre-peeled, a common performance optimization.</param>
		/// <param name="monitor">progress monitor to receive update status on.</param>
		/// <summary>Execute this batch update.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("execute", "(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/lib/ProgressMonitor;)V", "GetExecute_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe void Execute (global::Org.Eclipse.Jgit.Revwalk.RevWalk walk, global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "execute.(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/lib/ProgressMonitor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				__args [1] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (walk);
				global::System.GC.KeepAlive (monitor);
			}
		}

		static Delegate cb_newUpdate_Lorg_eclipse_jgit_transport_ReceiveCommand_;
#pragma warning disable 0169
		static Delegate GetNewUpdate_Lorg_eclipse_jgit_transport_ReceiveCommand_Handler ()
		{
			if (cb_newUpdate_Lorg_eclipse_jgit_transport_ReceiveCommand_ == null)
				cb_newUpdate_Lorg_eclipse_jgit_transport_ReceiveCommand_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewUpdate_Lorg_eclipse_jgit_transport_ReceiveCommand_);
			return cb_newUpdate_Lorg_eclipse_jgit_transport_ReceiveCommand_;
		}

		static IntPtr n_NewUpdate_Lorg_eclipse_jgit_transport_ReceiveCommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmd = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (native_cmd, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewUpdate (cmd));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="cmd">specific command the update should be created to copy.</param>
		/// <summary>Create a new RefUpdate copying the batch settings.</summary>
		/// <returns>a single reference update command.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='newUpdate' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.ReceiveCommand']]"
		[Register ("newUpdate", "(Lorg/eclipse/jgit/transport/ReceiveCommand;)Lorg/eclipse/jgit/lib/RefUpdate;", "GetNewUpdate_Lorg_eclipse_jgit_transport_ReceiveCommand_Handler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate NewUpdate (global::Org.Eclipse.Jgit.Transport.ReceiveCommand cmd)
		{
			const string __id = "newUpdate.(Lorg/eclipse/jgit/transport/ReceiveCommand;)Lorg/eclipse/jgit/lib/RefUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cmd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmd).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cmd);
			}
		}

		static Delegate cb_setAllowNonFastForwards_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowNonFastForwards_ZHandler ()
		{
			if (cb_setAllowNonFastForwards_Z == null)
				cb_setAllowNonFastForwards_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAllowNonFastForwards_Z);
			return cb_setAllowNonFastForwards_Z;
		}

		static IntPtr n_SetAllowNonFastForwards_Z (IntPtr jnienv, IntPtr native__this, bool allow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAllowNonFastForwards (allow));
		}
#pragma warning restore 0169

		/// <param name="allow">true if this update batch should ignore merge tests.</param>
		/// <summary>Set if this update wants to permit a forced update.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='setAllowNonFastForwards' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowNonFastForwards", "(Z)Lorg/eclipse/jgit/lib/BatchRefUpdate;", "GetSetAllowNonFastForwards_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.BatchRefUpdate SetAllowNonFastForwards (bool allow)
		{
			const string __id = "setAllowNonFastForwards.(Z)Lorg/eclipse/jgit/lib/BatchRefUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (allow);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static IntPtr n_SetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pi)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pi = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_pi, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefLogIdent (pi));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pi">identity of the user. If null the identity will be
		///            automatically determined based on the repository
		///            configuration.</param>
		/// <summary>Set the identity of the user appearing in the reflog.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='setRefLogIdent' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
		[Register ("setRefLogIdent", "(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/lib/BatchRefUpdate;", "GetSetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.BatchRefUpdate SetRefLogIdent (global::Org.Eclipse.Jgit.Lib.PersonIdent pi)
		{
			const string __id = "setRefLogIdent.(Lorg/eclipse/jgit/lib/PersonIdent;)Lorg/eclipse/jgit/lib/BatchRefUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pi == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pi).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (pi);
			}
		}

		static Delegate cb_setRefLogMessage_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetRefLogMessage_Ljava_lang_String_ZHandler ()
		{
			if (cb_setRefLogMessage_Ljava_lang_String_Z == null)
				cb_setRefLogMessage_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_SetRefLogMessage_Ljava_lang_String_Z);
			return cb_setRefLogMessage_Ljava_lang_String_Z;
		}

		static IntPtr n_SetRefLogMessage_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, bool appendStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefLogMessage (msg, appendStatus));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="msg">the message to describe this change. It may be null if
		///            appendStatus is null in order not to append to the reflog</param>
		/// <param name="appendStatus">true if the status of the ref change (fast-forward or
		///            forced-update) should be appended to the user supplied
		///            message.</param>
		/// <summary>Set the message to include in the reflog.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchRefUpdate']/method[@name='setRefLogMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setRefLogMessage", "(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/BatchRefUpdate;", "GetSetRefLogMessage_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.BatchRefUpdate SetRefLogMessage (string msg, bool appendStatus)
		{
			const string __id = "setRefLogMessage.(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/BatchRefUpdate;";
			IntPtr native_msg = JNIEnv.NewString ((string)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (appendStatus);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
