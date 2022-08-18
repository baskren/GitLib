using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Wrapper around the general <c>ProgressMonitor</c> to make it thread safe.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ThreadSafeProgressMonitor", DoNotGenerateAcw=true)]
	public partial class ThreadSafeProgressMonitor : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Lib.IProgressMonitor {
		public static class InterfaceConsts {
			// The following are fields from: org.eclipse.jgit.lib.ProgressMonitor

			/// <summary>Constant indicating the total work units cannot be predicted.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ProgressMonitor']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public const int Unknown = (int) 0;

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ThreadSafeProgressMonitor", typeof (ThreadSafeProgressMonitor));

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

		protected ThreadSafeProgressMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="pm">the underlying monitor to receive events.</param>
		/// <summary>Wrap a ProgressMonitor to be thread safe.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/constructor[@name='ThreadSafeProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)V", "")]
		public unsafe ThreadSafeProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ProgressMonitor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pm);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='isCancelled' and count(parameter)=0]"
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

		static void n_BeginTask_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_title, int totalWork)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			__this.BeginTask (title, totalWork);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='beginTask' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("beginTask", "(Ljava/lang/String;I)V", "GetBeginTask_Ljava_lang_String_IHandler")]
		public virtual unsafe void BeginTask (string title, int totalWork)
		{
			const string __id = "beginTask.(Ljava/lang/String;I)V";
			IntPtr native_title = JNIEnv.NewString ((string)title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_title);
				__args [1] = new JniArgumentValue (totalWork);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndTask ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='endTask' and count(parameter)=0]"
		[Register ("endTask", "()V", "GetEndTaskHandler")]
		public virtual unsafe void EndTask ()
		{
			const string __id = "endTask.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_endWorker;
#pragma warning disable 0169
		static Delegate GetEndWorkerHandler ()
		{
			if (cb_endWorker == null)
				cb_endWorker = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EndWorker);
			return cb_endWorker;
		}

		static void n_EndWorker (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndWorker ();
		}
#pragma warning restore 0169

		/// <summary>Notify the monitor a worker is finished.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='endWorker' and count(parameter)=0]"
		[Register ("endWorker", "()V", "GetEndWorkerHandler")]
		public virtual unsafe void EndWorker ()
		{
			const string __id = "endWorker.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_pollForUpdates;
#pragma warning disable 0169
		static Delegate GetPollForUpdatesHandler ()
		{
			if (cb_pollForUpdates == null)
				cb_pollForUpdates = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PollForUpdates);
			return cb_pollForUpdates;
		}

		static void n_PollForUpdates (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PollForUpdates ();
		}
#pragma warning restore 0169

		/// <summary>Non-blocking poll for pending updates.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='pollForUpdates' and count(parameter)=0]"
		[Register ("pollForUpdates", "()V", "GetPollForUpdatesHandler")]
		public virtual unsafe void PollForUpdates ()
		{
			const string __id = "pollForUpdates.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (totalTasks);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='start' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_startWorker;
#pragma warning disable 0169
		static Delegate GetStartWorkerHandler ()
		{
			if (cb_startWorker == null)
				cb_startWorker = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartWorker);
			return cb_startWorker;
		}

		static void n_StartWorker (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartWorker ();
		}
#pragma warning restore 0169

		/// <summary>Notify the monitor a worker is starting.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='startWorker' and count(parameter)=0]"
		[Register ("startWorker", "()V", "GetStartWorkerHandler")]
		public virtual unsafe void StartWorker ()
		{
			const string __id = "startWorker.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startWorkers_I;
#pragma warning disable 0169
		static Delegate GetStartWorkers_IHandler ()
		{
			if (cb_startWorkers_I == null)
				cb_startWorkers_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_StartWorkers_I);
			return cb_startWorkers_I;
		}

		static void n_StartWorkers_I (IntPtr jnienv, IntPtr native__this, int count)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartWorkers (count);
		}
#pragma warning restore 0169

		/// <param name="count">the number of worker threads that are starting.</param>
		/// <summary>Notify the monitor of workers starting.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='startWorkers' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("startWorkers", "(I)V", "GetStartWorkers_IHandler")]
		public virtual unsafe void StartWorkers (int count)
		{
			const string __id = "startWorkers.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (count);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update (completed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_waitForCompletion;
#pragma warning disable 0169
		static Delegate GetWaitForCompletionHandler ()
		{
			if (cb_waitForCompletion == null)
				cb_waitForCompletion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WaitForCompletion);
			return cb_waitForCompletion;
		}

		static void n_WaitForCompletion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ThreadSafeProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion ();
		}
#pragma warning restore 0169

		/// <summary>Process pending updates and wait for workers to finish.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ThreadSafeProgressMonitor']/method[@name='waitForCompletion' and count(parameter)=0]"
		[Register ("waitForCompletion", "()V", "GetWaitForCompletionHandler")]
		public virtual unsafe void WaitForCompletion ()
		{
			const string __id = "waitForCompletion.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
