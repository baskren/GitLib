using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>ProgressMonitor that batches update events.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BatchingProgressMonitor", DoNotGenerateAcw=true)]
	public abstract partial class BatchingProgressMonitor : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Lib.IProgressMonitor {
		public static class InterfaceConsts {
			// The following are fields from: org.eclipse.jgit.lib.ProgressMonitor

			/// <summary>Constant indicating the total work units cannot be predicted.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ProgressMonitor']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public const int Unknown = (int) 0;

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BatchingProgressMonitor", typeof (BatchingProgressMonitor));

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

		protected BatchingProgressMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/constructor[@name='BatchingProgressMonitor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BatchingProgressMonitor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isCancelled;
#pragma warning disable 0169
		static Delegate GetIsCancelledHandler ()
		{
			if (cb_isCancelled == null)
				cb_isCancelled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCancelled);
			return cb_isCancelled;
		}

		static bool n_IsCancelled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				const string __id = "isCancelled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_beginTask_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetBeginTask_Ljava_lang_String_IHandler ()
		{
			if (cb_beginTask_Ljava_lang_String_I == null)
				cb_beginTask_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_BeginTask_Ljava_lang_String_I);
			return cb_beginTask_Ljava_lang_String_I;
		}

		static void n_BeginTask_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_title, int work)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			__this.BeginTask (title, work);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='beginTask' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("beginTask", "(Ljava/lang/String;I)V", "GetBeginTask_Ljava_lang_String_IHandler")]
		public virtual unsafe void BeginTask (string title, int work)
		{
			const string __id = "beginTask.(Ljava/lang/String;I)V";
			IntPtr native_title = JNIEnv.NewString ((string)title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_title);
				__args [1] = new JniArgumentValue (work);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_endTask;
#pragma warning disable 0169
		static Delegate GetEndTaskHandler ()
		{
			if (cb_endTask == null)
				cb_endTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EndTask);
			return cb_endTask;
		}

		static void n_EndTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndTask ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='endTask' and count(parameter)=0]"
		[Register ("endTask", "()V", "GetEndTaskHandler")]
		public virtual unsafe void EndTask ()
		{
			const string __id = "endTask.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onEndTask_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnEndTask_Ljava_lang_String_IHandler ()
		{
			if (cb_onEndTask_Ljava_lang_String_I == null)
				cb_onEndTask_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnEndTask_Ljava_lang_String_I);
			return cb_onEndTask_Ljava_lang_String_I;
		}

		static void n_OnEndTask_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_taskName, int workCurr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var taskName = JNIEnv.GetString (native_taskName, JniHandleOwnership.DoNotTransfer);
			__this.OnEndTask (taskName, workCurr);
		}
#pragma warning restore 0169

		/// <param name="taskName">name of the task.</param>
		/// <param name="workCurr">total number of units processed.</param>
		/// <summary>Finish the progress monitor when the total wasn't known in advance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='onEndTask' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onEndTask", "(Ljava/lang/String;I)V", "GetOnEndTask_Ljava_lang_String_IHandler")]
		protected abstract void OnEndTask (string taskName, int workCurr);

		static Delegate cb_onEndTask_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetOnEndTask_Ljava_lang_String_IIIHandler ()
		{
			if (cb_onEndTask_Ljava_lang_String_III == null)
				cb_onEndTask_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_V) n_OnEndTask_Ljava_lang_String_III);
			return cb_onEndTask_Ljava_lang_String_III;
		}

		static void n_OnEndTask_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_taskName, int workCurr, int workTotal, int percentDone)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var taskName = JNIEnv.GetString (native_taskName, JniHandleOwnership.DoNotTransfer);
			__this.OnEndTask (taskName, workCurr, workTotal, percentDone);
		}
#pragma warning restore 0169

		/// <param name="taskName">name of the task.</param>
		/// <param name="workCurr">total number of units processed.</param>
		/// <param name="workTotal">estimated number of units to process.</param>
		/// <param name="percentDone">
		///   <c>workCurr * 100 / workTotal</c>.</param>
		/// <summary>Finish the progress monitor when the total is known in advance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='onEndTask' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onEndTask", "(Ljava/lang/String;III)V", "GetOnEndTask_Ljava_lang_String_IIIHandler")]
		protected abstract void OnEndTask (string taskName, int workCurr, int workTotal, int percentDone);

		static Delegate cb_onUpdate_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnUpdate_Ljava_lang_String_IHandler ()
		{
			if (cb_onUpdate_Ljava_lang_String_I == null)
				cb_onUpdate_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnUpdate_Ljava_lang_String_I);
			return cb_onUpdate_Ljava_lang_String_I;
		}

		static void n_OnUpdate_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_taskName, int workCurr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var taskName = JNIEnv.GetString (native_taskName, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdate (taskName, workCurr);
		}
#pragma warning restore 0169

		/// <param name="taskName">name of the task.</param>
		/// <param name="workCurr">number of units already completed.</param>
		/// <summary>Update the progress monitor if the total work isn't known,</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='onUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onUpdate", "(Ljava/lang/String;I)V", "GetOnUpdate_Ljava_lang_String_IHandler")]
		protected abstract void OnUpdate (string taskName, int workCurr);

		static Delegate cb_onUpdate_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetOnUpdate_Ljava_lang_String_IIIHandler ()
		{
			if (cb_onUpdate_Ljava_lang_String_III == null)
				cb_onUpdate_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_V) n_OnUpdate_Ljava_lang_String_III);
			return cb_onUpdate_Ljava_lang_String_III;
		}

		static void n_OnUpdate_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_taskName, int workCurr, int workTotal, int percentDone)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var taskName = JNIEnv.GetString (native_taskName, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdate (taskName, workCurr, workTotal, percentDone);
		}
#pragma warning restore 0169

		/// <param name="taskName">name of the task.</param>
		/// <param name="workCurr">number of units already completed.</param>
		/// <param name="workTotal">estimated number of units to process.</param>
		/// <param name="percentDone">
		///   <c>workCurr * 100 / workTotal</c>.</param>
		/// <summary>Update the progress monitor when the total is known in advance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='onUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onUpdate", "(Ljava/lang/String;III)V", "GetOnUpdate_Ljava_lang_String_IIIHandler")]
		protected abstract void OnUpdate (string taskName, int workCurr, int workTotal, int percentDone);

		static Delegate cb_setDelayStart_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetSetDelayStart_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_setDelayStart_JLjava_util_concurrent_TimeUnit_ == null)
				cb_setDelayStart_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_V) n_SetDelayStart_JLjava_util_concurrent_TimeUnit_);
			return cb_setDelayStart_JLjava_util_concurrent_TimeUnit_;
		}

		static void n_SetDelayStart_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long time, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			__this.SetDelayStart (time, unit);
		}
#pragma warning restore 0169

		/// <param name="time">how long to wait before output. If 0 output begins on the
		///            first <c>#update(int)</c> call.</param>
		/// <param name="unit">time unit of <c>time</c>.</param>
		/// <summary>Set an optional delay before the first output.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='setDelayStart' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("setDelayStart", "(JLjava/util/concurrent/TimeUnit;)V", "GetSetDelayStart_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe void SetDelayStart (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "setDelayStart.(JLjava/util/concurrent/TimeUnit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (time);
				__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (unit);
			}
		}

		static Delegate cb_start_I;
#pragma warning disable 0169
		static Delegate GetStart_IHandler ()
		{
			if (cb_start_I == null)
				cb_start_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Start_I);
			return cb_start_I;
		}

		static void n_Start_I (IntPtr jnienv, IntPtr native__this, int totalTasks)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (totalTasks);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='start' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("start", "(I)V", "GetStart_IHandler")]
		public virtual unsafe void Start (int totalTasks)
		{
			const string __id = "start.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (totalTasks);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_update_I;
#pragma warning disable 0169
		static Delegate GetUpdate_IHandler ()
		{
			if (cb_update_I == null)
				cb_update_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Update_I);
			return cb_update_I;
		}

		static void n_Update_I (IntPtr jnienv, IntPtr native__this, int completed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update (completed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("update", "(I)V", "GetUpdate_IHandler")]
		public virtual unsafe void Update (int completed)
		{
			const string __id = "update.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (completed);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BatchingProgressMonitor", DoNotGenerateAcw=true)]
	internal partial class BatchingProgressMonitorInvoker : BatchingProgressMonitor {
		public BatchingProgressMonitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BatchingProgressMonitor", typeof (BatchingProgressMonitorInvoker));

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

		/// <param name="taskName">name of the task.</param>
		/// <param name="workCurr">total number of units processed.</param>
		/// <summary>Finish the progress monitor when the total wasn't known in advance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='onEndTask' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onEndTask", "(Ljava/lang/String;I)V", "GetOnEndTask_Ljava_lang_String_IHandler")]
		protected override unsafe void OnEndTask (string taskName, int workCurr)
		{
			const string __id = "onEndTask.(Ljava/lang/String;I)V";
			IntPtr native_taskName = JNIEnv.NewString ((string)taskName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_taskName);
				__args [1] = new JniArgumentValue (workCurr);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_taskName);
			}
		}

		/// <param name="taskName">name of the task.</param>
		/// <param name="workCurr">total number of units processed.</param>
		/// <param name="workTotal">estimated number of units to process.</param>
		/// <param name="percentDone">
		///   <c>workCurr * 100 / workTotal</c>.</param>
		/// <summary>Finish the progress monitor when the total is known in advance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='onEndTask' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onEndTask", "(Ljava/lang/String;III)V", "GetOnEndTask_Ljava_lang_String_IIIHandler")]
		protected override unsafe void OnEndTask (string taskName, int workCurr, int workTotal, int percentDone)
		{
			const string __id = "onEndTask.(Ljava/lang/String;III)V";
			IntPtr native_taskName = JNIEnv.NewString ((string)taskName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_taskName);
				__args [1] = new JniArgumentValue (workCurr);
				__args [2] = new JniArgumentValue (workTotal);
				__args [3] = new JniArgumentValue (percentDone);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_taskName);
			}
		}

		/// <param name="taskName">name of the task.</param>
		/// <param name="workCurr">number of units already completed.</param>
		/// <summary>Update the progress monitor if the total work isn't known,</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='onUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onUpdate", "(Ljava/lang/String;I)V", "GetOnUpdate_Ljava_lang_String_IHandler")]
		protected override unsafe void OnUpdate (string taskName, int workCurr)
		{
			const string __id = "onUpdate.(Ljava/lang/String;I)V";
			IntPtr native_taskName = JNIEnv.NewString ((string)taskName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_taskName);
				__args [1] = new JniArgumentValue (workCurr);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_taskName);
			}
		}

		/// <param name="taskName">name of the task.</param>
		/// <param name="workCurr">number of units already completed.</param>
		/// <param name="workTotal">estimated number of units to process.</param>
		/// <param name="percentDone">
		///   <c>workCurr * 100 / workTotal</c>.</param>
		/// <summary>Update the progress monitor when the total is known in advance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BatchingProgressMonitor']/method[@name='onUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onUpdate", "(Ljava/lang/String;III)V", "GetOnUpdate_Ljava_lang_String_IIIHandler")]
		protected override unsafe void OnUpdate (string taskName, int workCurr, int workTotal, int percentDone)
		{
			const string __id = "onUpdate.(Ljava/lang/String;III)V";
			IntPtr native_taskName = JNIEnv.NewString ((string)taskName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_taskName);
				__args [1] = new JniArgumentValue (workCurr);
				__args [2] = new JniArgumentValue (workTotal);
				__args [3] = new JniArgumentValue (percentDone);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_taskName);
			}
		}

	}
}
