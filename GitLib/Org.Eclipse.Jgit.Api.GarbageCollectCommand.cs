using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>gc</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GarbageCollectCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/GarbageCollectCommand", DoNotGenerateAcw=true)]
	public partial class GarbageCollectCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Java.Util.Properties> {
		/// <summary>Default value of maximum delta chain depth during aggressive garbage
		/// collection: To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GarbageCollectCommand']/field[@name='DEFAULT_GC_AGGRESSIVE_DEPTH']"
		[Register ("DEFAULT_GC_AGGRESSIVE_DEPTH")]
		public const int DefaultGcAggressiveDepth = (int) 250;

		/// <summary>Default window size during packing during aggressive garbage collection:
		/// * To be added</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GarbageCollectCommand']/field[@name='DEFAULT_GC_AGGRESSIVE_WINDOW']"
		[Register ("DEFAULT_GC_AGGRESSIVE_WINDOW")]
		public const int DefaultGcAggressiveWindow = (int) 250;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/GarbageCollectCommand", typeof (GarbageCollectCommand));

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

		protected GarbageCollectCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GarbageCollectCommand']/constructor[@name='GarbageCollectCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe GarbageCollectCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getStatistics;
#pragma warning disable 0169
		static Delegate GetGetStatisticsHandler ()
		{
			if (cb_getStatistics == null)
				cb_getStatistics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatistics);
			return cb_getStatistics;
		}

		static IntPtr n_GetStatistics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GarbageCollectCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Statistics);
		}
#pragma warning restore 0169

		/// <summary>Computes and returns the repository statistics.</summary>
		/// <returns>the repository statistics</returns>
		public virtual unsafe global::Java.Util.Properties Statistics {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GarbageCollectCommand']/method[@name='getStatistics' and count(parameter)=0]"
			[Register ("getStatistics", "()Ljava/util/Properties;", "GetGetStatisticsHandler")]
			get {
				const string __id = "getStatistics.()Ljava/util/Properties;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GarbageCollectCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GarbageCollectCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/Properties;", "GetCallHandler")]
		public override unsafe global::Java.Util.Properties Call ()
		{
			const string __id = "call.()Ljava/util/Properties;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAggressive_Z;
#pragma warning disable 0169
		static Delegate GetSetAggressive_ZHandler ()
		{
			if (cb_setAggressive_Z == null)
				cb_setAggressive_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAggressive_Z);
			return cb_setAggressive_Z;
		}

		static IntPtr n_SetAggressive_Z (IntPtr jnienv, IntPtr native__this, bool aggressive)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GarbageCollectCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAggressive (aggressive));
		}
#pragma warning restore 0169

		/// <param name="aggressive">whether to turn on or off aggressive mode</param>
		/// <summary>Whether to use aggressive mode or not.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GarbageCollectCommand']/method[@name='setAggressive' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAggressive", "(Z)Lorg/eclipse/jgit/api/GarbageCollectCommand;", "GetSetAggressive_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.GarbageCollectCommand SetAggressive (bool aggressive)
		{
			const string __id = "setAggressive.(Z)Lorg/eclipse/jgit/api/GarbageCollectCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (aggressive);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GarbageCollectCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setExpire_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetExpire_Ljava_util_Date_Handler ()
		{
			if (cb_setExpire_Ljava_util_Date_ == null)
				cb_setExpire_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetExpire_Ljava_util_Date_);
			return cb_setExpire_Ljava_util_Date_;
		}

		static IntPtr n_SetExpire_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expire)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GarbageCollectCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var expire = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_expire, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetExpire (expire));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="expire">minimal age of objects to be pruned.</param>
		/// <summary>During gc() or prune() each unreferenced, loose object which has been
		/// created or modified after &lt;code&gt;expire&lt;/code&gt; will not be pruned.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GarbageCollectCommand']/method[@name='setExpire' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("setExpire", "(Ljava/util/Date;)Lorg/eclipse/jgit/api/GarbageCollectCommand;", "GetSetExpire_Ljava_util_Date_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.GarbageCollectCommand SetExpire (global::Java.Util.Date expire)
		{
			const string __id = "setExpire.(Ljava/util/Date;)Lorg/eclipse/jgit/api/GarbageCollectCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expire == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expire).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GarbageCollectCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (expire);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GarbageCollectCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (monitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">a progress monitor</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GarbageCollectCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/GarbageCollectCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.GarbageCollectCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/GarbageCollectCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GarbageCollectCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (monitor);
			}
		}

	}
}
