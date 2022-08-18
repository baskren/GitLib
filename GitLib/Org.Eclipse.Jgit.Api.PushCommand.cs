using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>Push</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/PushCommand", DoNotGenerateAcw=true)]
	public partial class PushCommand : global::Org.Eclipse.Jgit.Api.TransportCommand<global::Java.Lang.IIterable> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/PushCommand", typeof (PushCommand));

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

		protected PushCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/constructor[@name='PushCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe PushCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_isDryRun;
#pragma warning disable 0169
		static Delegate GetIsDryRunHandler ()
		{
			if (cb_isDryRun == null)
				cb_isDryRun = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDryRun);
			return cb_isDryRun;
		}

		static bool n_IsDryRun (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDryRun;
		}
#pragma warning restore 0169

		/// <returns>the dry run preference for the push operation</returns>
		public virtual unsafe bool IsDryRun {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='isDryRun' and count(parameter)=0]"
			[Register ("isDryRun", "()Z", "GetIsDryRunHandler")]
			get {
				const string __id = "isDryRun.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isForce;
#pragma warning disable 0169
		static Delegate GetIsForceHandler ()
		{
			if (cb_isForce == null)
				cb_isForce = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsForce);
			return cb_isForce;
		}

		static bool n_IsForce (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsForce;
		}
#pragma warning restore 0169

		/// <returns>the force preference for push operation</returns>
		public virtual unsafe bool IsForce {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='isForce' and count(parameter)=0]"
			[Register ("isForce", "()Z", "GetIsForceHandler")]
			get {
				const string __id = "isForce.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isThin;
#pragma warning disable 0169
		static Delegate GetIsThinHandler ()
		{
			if (cb_isThin == null)
				cb_isThin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsThin);
			return cb_isThin;
		}

		static bool n_IsThin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsThin;
		}
#pragma warning restore 0169

		/// <returns>the thin-pack preference for push operation</returns>
		public virtual unsafe bool IsThin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='isThin' and count(parameter)=0]"
			[Register ("isThin", "()Z", "GetIsThinHandler")]
			get {
				const string __id = "isThin.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProgressMonitor;
#pragma warning disable 0169
		static Delegate GetGetProgressMonitorHandler ()
		{
			if (cb_getProgressMonitor == null)
				cb_getProgressMonitor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProgressMonitor);
			return cb_getProgressMonitor;
		}

		static IntPtr n_GetProgressMonitor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProgressMonitor);
		}
#pragma warning restore 0169

		/// <returns>the progress monitor for the push operation</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IProgressMonitor ProgressMonitor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='getProgressMonitor' and count(parameter)=0]"
			[Register ("getProgressMonitor", "()Lorg/eclipse/jgit/lib/ProgressMonitor;", "GetGetProgressMonitorHandler")]
			get {
				const string __id = "getProgressMonitor.()Lorg/eclipse/jgit/lib/ProgressMonitor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReceivePack;
#pragma warning disable 0169
		static Delegate GetGetReceivePackHandler ()
		{
			if (cb_getReceivePack == null)
				cb_getReceivePack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReceivePack);
			return cb_getReceivePack;
		}

		static IntPtr n_GetReceivePack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReceivePack);
		}
#pragma warning restore 0169

		/// <returns>the receive-pack used for the remote operation</returns>
		public virtual unsafe string ReceivePack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='getReceivePack' and count(parameter)=0]"
			[Register ("getReceivePack", "()Ljava/lang/String;", "GetGetReceivePackHandler")]
			get {
				const string __id = "getReceivePack.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefSpecs;
#pragma warning disable 0169
		static Delegate GetGetRefSpecsHandler ()
		{
			if (cb_getRefSpecs == null)
				cb_getRefSpecs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefSpecs);
			return cb_getRefSpecs;
		}

		static IntPtr n_GetRefSpecs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (__this.RefSpecs);
		}
#pragma warning restore 0169

		/// <returns>the ref specs</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.RefSpec> RefSpecs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='getRefSpecs' and count(parameter)=0]"
			[Register ("getRefSpecs", "()Ljava/util/List;", "GetGetRefSpecsHandler")]
			get {
				const string __id = "getRefSpecs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemote;
#pragma warning disable 0169
		static Delegate GetGetRemoteHandler ()
		{
			if (cb_getRemote == null)
				cb_getRemote = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemote);
			return cb_getRemote;
		}

		static IntPtr n_GetRemote (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Remote);
		}
#pragma warning restore 0169

		/// <returns>the remote used for the remote operation</returns>
		public virtual unsafe string Remote {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='getRemote' and count(parameter)=0]"
			[Register ("getRemote", "()Ljava/lang/String;", "GetGetRemoteHandler")]
			get {
				const string __id = "getRemote.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		/// <returns>the timeout used for the push operation</returns>
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				const string __id = "getTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_add_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Handler ()
		{
			if (cb_add_Ljava_lang_String_ == null)
				cb_add_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Add_Ljava_lang_String_);
			return cb_add_Ljava_lang_String_;
		}

		static IntPtr n_Add_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nameOrSpec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nameOrSpec = JNIEnv.GetString (native_nameOrSpec, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (nameOrSpec));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="nameOrSpec">any reference name, or a reference specification.</param>
		/// <summary>Add a reference to push.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/PushCommand;", "GetAdd_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand Add (string nameOrSpec)
		{
			const string __id = "add.(Ljava/lang/String;)Lorg/eclipse/jgit/api/PushCommand;";
			IntPtr native_nameOrSpec = JNIEnv.NewString ((string)nameOrSpec);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_nameOrSpec);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_nameOrSpec);
			}
		}

		static Delegate cb_add_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_add_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Add_Lorg_eclipse_jgit_lib_Ref_);
			return cb_add_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_Add_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (@ref));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ref">the source reference. The remote name will match.</param>
		/// <summary>Add a reference to push.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("add", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/PushCommand;", "GetAdd_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand Add (global::Org.Eclipse.Jgit.Lib.IRef @ref)
		{
			const string __id = "add.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/PushCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@ref);
			}
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>push</c> command with all the options and parameters
		/// collected by the setter methods of this class.</summary>
		/// <returns>an iteration over <c>PushResult</c> objects</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/Iterable;", "GetCallHandler")]
		public virtual unsafe global::Java.Lang.IIterable Call ()
		{
			const string __id = "call.()Ljava/lang/Iterable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDryRun_Z;
#pragma warning disable 0169
		static Delegate GetSetDryRun_ZHandler ()
		{
			if (cb_setDryRun_Z == null)
				cb_setDryRun_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetDryRun_Z);
			return cb_setDryRun_Z;
		}

		static IntPtr n_SetDryRun_Z (IntPtr jnienv, IntPtr native__this, bool dryRun)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDryRun (dryRun));
		}
#pragma warning restore 0169

		/// <param name="dryRun">dryRun</param>
		/// <summary>Sets whether the push operation should be a dry run</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setDryRun' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDryRun", "(Z)Lorg/eclipse/jgit/api/PushCommand;", "GetSetDryRun_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetDryRun (bool dryRun)
		{
			const string __id = "setDryRun.(Z)Lorg/eclipse/jgit/api/PushCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dryRun);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setForce_Z;
#pragma warning disable 0169
		static Delegate GetSetForce_ZHandler ()
		{
			if (cb_setForce_Z == null)
				cb_setForce_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetForce_Z);
			return cb_setForce_Z;
		}

		static IntPtr n_SetForce_Z (IntPtr jnienv, IntPtr native__this, bool force)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetForce (force));
		}
#pragma warning restore 0169

		/// <param name="force">force</param>
		/// <summary>Sets the force preference for push operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setForce' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setForce", "(Z)Lorg/eclipse/jgit/api/PushCommand;", "GetSetForce_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetForce (bool force)
		{
			const string __id = "setForce.(Z)Lorg/eclipse/jgit/api/PushCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (force);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOutputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetSetOutputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_setOutputStream_Ljava_io_OutputStream_ == null)
				cb_setOutputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOutputStream_Ljava_io_OutputStream_);
			return cb_setOutputStream_Ljava_io_OutputStream_;
		}

		static IntPtr n_SetOutputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOutputStream (@out));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="out">out</param>
		/// <summary>Sets the output stream to write sideband messages to</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("setOutputStream", "(Ljava/io/OutputStream;)Lorg/eclipse/jgit/api/PushCommand;", "GetSetOutputStream_Ljava_io_OutputStream_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetOutputStream (global::System.IO.Stream @out)
		{
			const string __id = "setOutputStream.(Ljava/io/OutputStream;)Lorg/eclipse/jgit/api/PushCommand;";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (monitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">monitor</param>
		/// <summary>The progress monitor associated with the push operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/PushCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/PushCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (monitor);
			}
		}

		static Delegate cb_setPushAll;
#pragma warning disable 0169
		static Delegate GetSetPushAllHandler ()
		{
			if (cb_setPushAll == null)
				cb_setPushAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SetPushAll);
			return cb_setPushAll;
		}

		static IntPtr n_SetPushAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPushAll ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setPushAll' and count(parameter)=0]"
		[Register ("setPushAll", "()Lorg/eclipse/jgit/api/PushCommand;", "GetSetPushAllHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetPushAll ()
		{
			const string __id = "setPushAll.()Lorg/eclipse/jgit/api/PushCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPushTags;
#pragma warning disable 0169
		static Delegate GetSetPushTagsHandler ()
		{
			if (cb_setPushTags == null)
				cb_setPushTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SetPushTags);
			return cb_setPushTags;
		}

		static IntPtr n_SetPushTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPushTags ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setPushTags' and count(parameter)=0]"
		[Register ("setPushTags", "()Lorg/eclipse/jgit/api/PushCommand;", "GetSetPushTagsHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetPushTags ()
		{
			const string __id = "setPushTags.()Lorg/eclipse/jgit/api/PushCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setReceivePack_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReceivePack_Ljava_lang_String_Handler ()
		{
			if (cb_setReceivePack_Ljava_lang_String_ == null)
				cb_setReceivePack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetReceivePack_Ljava_lang_String_);
			return cb_setReceivePack_Ljava_lang_String_;
		}

		static IntPtr n_SetReceivePack_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receivePack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var receivePack = JNIEnv.GetString (native_receivePack, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReceivePack (receivePack));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="receivePack">receivePack</param>
		/// <summary>The remote executable providing receive-pack service for pack transports.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setReceivePack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setReceivePack", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/PushCommand;", "GetSetReceivePack_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetReceivePack (string receivePack)
		{
			const string __id = "setReceivePack.(Ljava/lang/String;)Lorg/eclipse/jgit/api/PushCommand;";
			IntPtr native_receivePack = JNIEnv.NewString ((string)receivePack);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_receivePack);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_receivePack);
			}
		}

		static Delegate cb_setRefSpecs_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetRefSpecs_Ljava_util_List_Handler ()
		{
			if (cb_setRefSpecs_Ljava_util_List_ == null)
				cb_setRefSpecs_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRefSpecs_Ljava_util_List_);
			return cb_setRefSpecs_Ljava_util_List_;
		}

		static IntPtr n_SetRefSpecs_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_specs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var specs = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.FromJniHandle (native_specs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefSpecs (specs));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="specs">specs</param>
		/// <summary>The ref specs to be used in the push operation</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setRefSpecs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.transport.RefSpec&gt;']]"
		[Register ("setRefSpecs", "(Ljava/util/List;)Lorg/eclipse/jgit/api/PushCommand;", "GetSetRefSpecs_Ljava_util_List_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetRefSpecs (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.RefSpec> specs)
		{
			const string __id = "setRefSpecs.(Ljava/util/List;)Lorg/eclipse/jgit/api/PushCommand;";
			IntPtr native_specs = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (specs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_specs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_specs);
				global::System.GC.KeepAlive (specs);
			}
		}

		static Delegate cb_setRefSpecs_arrayLorg_eclipse_jgit_transport_RefSpec_;
#pragma warning disable 0169
		static Delegate GetSetRefSpecs_arrayLorg_eclipse_jgit_transport_RefSpec_Handler ()
		{
			if (cb_setRefSpecs_arrayLorg_eclipse_jgit_transport_RefSpec_ == null)
				cb_setRefSpecs_arrayLorg_eclipse_jgit_transport_RefSpec_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRefSpecs_arrayLorg_eclipse_jgit_transport_RefSpec_);
			return cb_setRefSpecs_arrayLorg_eclipse_jgit_transport_RefSpec_;
		}

		static IntPtr n_SetRefSpecs_arrayLorg_eclipse_jgit_transport_RefSpec_ (IntPtr jnienv, IntPtr native__this, IntPtr native_specs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var specs = (global::Org.Eclipse.Jgit.Transport.RefSpec[]) JNIEnv.GetArray (native_specs, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Transport.RefSpec));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefSpecs (specs));
			if (specs != null)
				JNIEnv.CopyArray (specs, native_specs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setRefSpecs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefSpec...']]"
		[Register ("setRefSpecs", "([Lorg/eclipse/jgit/transport/RefSpec;)Lorg/eclipse/jgit/api/PushCommand;", "GetSetRefSpecs_arrayLorg_eclipse_jgit_transport_RefSpec_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetRefSpecs (params global::Org.Eclipse.Jgit.Transport.RefSpec[] specs)
		{
			const string __id = "setRefSpecs.([Lorg/eclipse/jgit/transport/RefSpec;)Lorg/eclipse/jgit/api/PushCommand;";
			IntPtr native_specs = JNIEnv.NewArray (specs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_specs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (specs != null) {
					JNIEnv.CopyArray (native_specs, specs);
					JNIEnv.DeleteLocalRef (native_specs);
				}
				global::System.GC.KeepAlive (specs);
			}
		}

		static Delegate cb_setRemote_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRemote_Ljava_lang_String_Handler ()
		{
			if (cb_setRemote_Ljava_lang_String_ == null)
				cb_setRemote_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRemote_Ljava_lang_String_);
			return cb_setRemote_Ljava_lang_String_;
		}

		static IntPtr n_SetRemote_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remote)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var remote = JNIEnv.GetString (native_remote, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRemote (remote));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="remote">remote</param>
		/// <summary>The remote (uri or name) used for the push operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setRemote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRemote", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/PushCommand;", "GetSetRemote_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetRemote (string remote)
		{
			const string __id = "setRemote.(Ljava/lang/String;)Lorg/eclipse/jgit/api/PushCommand;";
			IntPtr native_remote = JNIEnv.NewString ((string)remote);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_remote);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remote);
			}
		}

		static Delegate cb_setThin_Z;
#pragma warning disable 0169
		static Delegate GetSetThin_ZHandler ()
		{
			if (cb_setThin_Z == null)
				cb_setThin_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetThin_Z);
			return cb_setThin_Z;
		}

		static IntPtr n_SetThin_Z (IntPtr jnienv, IntPtr native__this, bool thin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetThin (thin));
		}
#pragma warning restore 0169

		/// <param name="thin">thin</param>
		/// <summary>Sets the thin-pack preference for push operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='PushCommand']/method[@name='setThin' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setThin", "(Z)Lorg/eclipse/jgit/api/PushCommand;", "GetSetThin_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.PushCommand SetThin (bool thin)
		{
			const string __id = "setThin.(Z)Lorg/eclipse/jgit/api/PushCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (thin);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.PushCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
