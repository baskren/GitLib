using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>Fetch</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/FetchCommand", DoNotGenerateAcw=true)]
	public partial class FetchCommand : global::Org.Eclipse.Jgit.Api.TransportCommand<global::Org.Eclipse.Jgit.Transport.FetchResult> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/FetchCommand", typeof (FetchCommand));

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

		protected FetchCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/constructor[@name='FetchCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe FetchCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isCheckFetchedObjects;
#pragma warning disable 0169
		static Delegate GetIsCheckFetchedObjectsHandler ()
		{
			if (cb_isCheckFetchedObjects == null)
				cb_isCheckFetchedObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCheckFetchedObjects);
			return cb_isCheckFetchedObjects;
		}

		static bool n_IsCheckFetchedObjects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCheckFetchedObjects;
		}
#pragma warning restore 0169

		/// <returns>whether to check received objects checked for validity</returns>
		public virtual unsafe bool IsCheckFetchedObjects {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='isCheckFetchedObjects' and count(parameter)=0]"
			[Register ("isCheckFetchedObjects", "()Z", "GetIsCheckFetchedObjectsHandler")]
			get {
				const string __id = "isCheckFetchedObjects.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDryRun;
		}
#pragma warning restore 0169

		/// <returns>the dry run preference for the fetch operation</returns>
		public virtual unsafe bool IsDryRun {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='isDryRun' and count(parameter)=0]"
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

		static Delegate cb_isRemoveDeletedRefs;
#pragma warning disable 0169
		static Delegate GetIsRemoveDeletedRefsHandler ()
		{
			if (cb_isRemoveDeletedRefs == null)
				cb_isRemoveDeletedRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRemoveDeletedRefs);
			return cb_isRemoveDeletedRefs;
		}

		static bool n_IsRemoveDeletedRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRemoveDeletedRefs;
		}
#pragma warning restore 0169

		/// <returns>whether or not to remove refs which no longer exist in the source</returns>
		public virtual unsafe bool IsRemoveDeletedRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='isRemoveDeletedRefs' and count(parameter)=0]"
			[Register ("isRemoveDeletedRefs", "()Z", "GetIsRemoveDeletedRefsHandler")]
			get {
				const string __id = "isRemoveDeletedRefs.()Z";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsThin;
		}
#pragma warning restore 0169

		/// <returns>the thin-pack preference for fetch operation</returns>
		public virtual unsafe bool IsThin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='isThin' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProgressMonitor);
		}
#pragma warning restore 0169

		/// <returns>the progress monitor for the fetch operation</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IProgressMonitor ProgressMonitor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='getProgressMonitor' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (__this.RefSpecs);
		}
#pragma warning restore 0169

		/// <returns>the ref specs</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.RefSpec> RefSpecs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='getRefSpecs' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Remote);
		}
#pragma warning restore 0169

		/// <returns>the remote used for the remote operation</returns>
		public virtual unsafe string Remote {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='getRemote' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		/// <returns>the timeout used for the fetch operation</returns>
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='getTimeout' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>fetch</c> command with all the options and parameters
		/// collected by the setter methods of this class.</summary>
		/// <returns>a <c>FetchResult</c> object representing the successful fetch
		///         result</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/transport/FetchResult;", "GetCallHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.FetchResult Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/transport/FetchResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.FetchResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCheckFetchedObjects_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckFetchedObjects_ZHandler ()
		{
			if (cb_setCheckFetchedObjects_Z == null)
				cb_setCheckFetchedObjects_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCheckFetchedObjects_Z);
			return cb_setCheckFetchedObjects_Z;
		}

		static IntPtr n_SetCheckFetchedObjects_Z (IntPtr jnienv, IntPtr native__this, bool checkFetchedObjects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCheckFetchedObjects (checkFetchedObjects));
		}
#pragma warning restore 0169

		/// <param name="checkFetchedObjects">checkFetchedObjects</param>
		/// <summary>If set to true, objects received will be checked for validity</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='setCheckFetchedObjects' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCheckFetchedObjects", "(Z)Lorg/eclipse/jgit/api/FetchCommand;", "GetSetCheckFetchedObjects_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand SetCheckFetchedObjects (bool checkFetchedObjects)
		{
			const string __id = "setCheckFetchedObjects.(Z)Lorg/eclipse/jgit/api/FetchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (checkFetchedObjects);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDryRun (dryRun));
		}
#pragma warning restore 0169

		/// <param name="dryRun">dryRun</param>
		/// <summary>Sets whether the fetch operation should be a dry run</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='setDryRun' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDryRun", "(Z)Lorg/eclipse/jgit/api/FetchCommand;", "GetSetDryRun_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand SetDryRun (bool dryRun)
		{
			const string __id = "setDryRun.(Z)Lorg/eclipse/jgit/api/FetchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dryRun);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (monitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">monitor</param>
		/// <summary>The progress monitor associated with the fetch operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/FetchCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/FetchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (monitor);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var specs = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.FromJniHandle (native_specs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefSpecs (specs));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="specs">specs</param>
		/// <summary>The ref specs to be used in the fetch operation</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='setRefSpecs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.transport.RefSpec&gt;']]"
		[Register ("setRefSpecs", "(Ljava/util/List;)Lorg/eclipse/jgit/api/FetchCommand;", "GetSetRefSpecs_Ljava_util_List_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand SetRefSpecs (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.RefSpec> specs)
		{
			const string __id = "setRefSpecs.(Ljava/util/List;)Lorg/eclipse/jgit/api/FetchCommand;";
			IntPtr native_specs = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (specs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_specs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var specs = (global::Org.Eclipse.Jgit.Transport.RefSpec[]) JNIEnv.GetArray (native_specs, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Transport.RefSpec));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefSpecs (specs));
			if (specs != null)
				JNIEnv.CopyArray (specs, native_specs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='setRefSpecs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefSpec...']]"
		[Register ("setRefSpecs", "([Lorg/eclipse/jgit/transport/RefSpec;)Lorg/eclipse/jgit/api/FetchCommand;", "GetSetRefSpecs_arrayLorg_eclipse_jgit_transport_RefSpec_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand SetRefSpecs (params global::Org.Eclipse.Jgit.Transport.RefSpec[] specs)
		{
			const string __id = "setRefSpecs.([Lorg/eclipse/jgit/transport/RefSpec;)Lorg/eclipse/jgit/api/FetchCommand;";
			IntPtr native_specs = JNIEnv.NewArray (specs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_specs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var remote = JNIEnv.GetString (native_remote, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRemote (remote));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="remote">remote</param>
		/// <summary>The remote (uri or name) used for the fetch operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='setRemote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRemote", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/FetchCommand;", "GetSetRemote_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand SetRemote (string remote)
		{
			const string __id = "setRemote.(Ljava/lang/String;)Lorg/eclipse/jgit/api/FetchCommand;";
			IntPtr native_remote = JNIEnv.NewString ((string)remote);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_remote);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remote);
			}
		}

		static Delegate cb_setRemoveDeletedRefs_Z;
#pragma warning disable 0169
		static Delegate GetSetRemoveDeletedRefs_ZHandler ()
		{
			if (cb_setRemoveDeletedRefs_Z == null)
				cb_setRemoveDeletedRefs_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetRemoveDeletedRefs_Z);
			return cb_setRemoveDeletedRefs_Z;
		}

		static IntPtr n_SetRemoveDeletedRefs_Z (IntPtr jnienv, IntPtr native__this, bool removeDeletedRefs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRemoveDeletedRefs (removeDeletedRefs));
		}
#pragma warning restore 0169

		/// <param name="removeDeletedRefs">removeDeletedRefs</param>
		/// <summary>If set to true, refs are removed which no longer exist in the source</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='setRemoveDeletedRefs' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRemoveDeletedRefs", "(Z)Lorg/eclipse/jgit/api/FetchCommand;", "GetSetRemoveDeletedRefs_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand SetRemoveDeletedRefs (bool removeDeletedRefs)
		{
			const string __id = "setRemoveDeletedRefs.(Z)Lorg/eclipse/jgit/api/FetchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (removeDeletedRefs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_;
#pragma warning disable 0169
		static Delegate GetSetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_Handler ()
		{
			if (cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_ == null)
				cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_);
			return cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_;
		}

		static IntPtr n_SetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tagOpt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tagOpt = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (native_tagOpt, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTagOpt (tagOpt));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="tagOpt">tagOpt</param>
		/// <summary>Sets the specification of annotated tag behavior during fetch</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='setTagOpt' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.TagOpt']]"
		[Register ("setTagOpt", "(Lorg/eclipse/jgit/transport/TagOpt;)Lorg/eclipse/jgit/api/FetchCommand;", "GetSetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand SetTagOpt (global::Org.Eclipse.Jgit.Transport.TagOpt tagOpt)
		{
			const string __id = "setTagOpt.(Lorg/eclipse/jgit/transport/TagOpt;)Lorg/eclipse/jgit/api/FetchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tagOpt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tagOpt).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (tagOpt);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetThin (thin));
		}
#pragma warning restore 0169

		/// <param name="thin">thin</param>
		/// <summary>Sets the thin-pack preference for fetch operation.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='FetchCommand']/method[@name='setThin' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setThin", "(Z)Lorg/eclipse/jgit/api/FetchCommand;", "GetSetThin_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.FetchCommand SetThin (bool thin)
		{
			const string __id = "setThin.(Z)Lorg/eclipse/jgit/api/FetchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (thin);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.FetchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
