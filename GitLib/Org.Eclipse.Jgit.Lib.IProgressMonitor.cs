using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	[Register ("org/eclipse/jgit/lib/ProgressMonitor", DoNotGenerateAcw=true)]
	public abstract class ProgressMonitor : Java.Lang.Object {
		internal ProgressMonitor ()
		{
		}

		/// <summary>Constant indicating the total work units cannot be predicted.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ProgressMonitor']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public const int Unknown = (int) 0;

	}

	[Register ("org/eclipse/jgit/lib/ProgressMonitor", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ProgressMonitor' type. This type will be removed in a future release.", error: true)]
	public abstract class ProgressMonitorConsts : ProgressMonitor {
		private ProgressMonitorConsts ()
		{
		}

	}

	/// <summary>A progress reporting interface.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ProgressMonitor']"
	[Register ("org/eclipse/jgit/lib/ProgressMonitor", "", "Org.Eclipse.Jgit.Lib.IProgressMonitorInvoker")]
	public partial interface IProgressMonitor : IJavaObject, IJavaPeerable {
		bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ProgressMonitor']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler:Org.Eclipse.Jgit.Lib.IProgressMonitorInvoker, AndroidBindableLibrary")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ProgressMonitor']/method[@name='beginTask' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		/// <param name="title">title to describe the task. Callers should publish these as
		///            stable string constants that implementations could match
		///            against for translation support.</param>
		/// <param name="totalWork">total number of work units the application will perform;
		///            <c>#UNKNOWN</c> if it cannot be predicted in advance.</param>
		/// <summary>Begin processing a single task.</summary>
		[Register ("beginTask", "(Ljava/lang/String;I)V", "GetBeginTask_Ljava_lang_String_IHandler:Org.Eclipse.Jgit.Lib.IProgressMonitorInvoker, AndroidBindableLibrary")]
		void BeginTask (string title, int totalWork);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ProgressMonitor']/method[@name='endTask' and count(parameter)=0]"
		/// <summary>Finish the current task, so the next can begin.</summary>
		[Register ("endTask", "()V", "GetEndTaskHandler:Org.Eclipse.Jgit.Lib.IProgressMonitorInvoker, AndroidBindableLibrary")]
		void EndTask ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ProgressMonitor']/method[@name='start' and count(parameter)=1 and parameter[1][@type='int']]"
		/// <param name="totalTasks">the total number of tasks the caller will need to complete
		///            their processing.</param>
		/// <summary>Advise the monitor of the total number of subtasks.</summary>
		[Register ("start", "(I)V", "GetStart_IHandler:Org.Eclipse.Jgit.Lib.IProgressMonitorInvoker, AndroidBindableLibrary")]
		void Start (int totalTasks);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ProgressMonitor']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
		/// <param name="completed">the number of work units completed since the last call.</param>
		/// <summary>Denote that some work units have been completed.</summary>
		[Register ("update", "(I)V", "GetUpdate_IHandler:Org.Eclipse.Jgit.Lib.IProgressMonitorInvoker, AndroidBindableLibrary")]
		void Update (int completed);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ProgressMonitor", DoNotGenerateAcw=true)]
	internal partial class IProgressMonitorInvoker : global::Java.Lang.Object, IProgressMonitor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ProgressMonitor", typeof (IProgressMonitorInvoker));

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

		public static IProgressMonitor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProgressMonitor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.ProgressMonitor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProgressMonitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		IntPtr id_isCancelled;
		public unsafe bool IsCancelled {
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCancelled);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			__this.BeginTask (title, totalWork);
		}
#pragma warning restore 0169

		IntPtr id_beginTask_Ljava_lang_String_I;
		public unsafe void BeginTask (string title, int totalWork)
		{
			if (id_beginTask_Ljava_lang_String_I == IntPtr.Zero)
				id_beginTask_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "beginTask", "(Ljava/lang/String;I)V");
			IntPtr native_title = JNIEnv.NewString ((string)title);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_title);
			__args [1] = new JValue (totalWork);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_beginTask_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_title);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndTask ();
		}
#pragma warning restore 0169

		IntPtr id_endTask;
		public unsafe void EndTask ()
		{
			if (id_endTask == IntPtr.Zero)
				id_endTask = JNIEnv.GetMethodID (class_ref, "endTask", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endTask);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (totalTasks);
		}
#pragma warning restore 0169

		IntPtr id_start_I;
		public unsafe void Start (int totalTasks)
		{
			if (id_start_I == IntPtr.Zero)
				id_start_I = JNIEnv.GetMethodID (class_ref, "start", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (totalTasks);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update (completed);
		}
#pragma warning restore 0169

		IntPtr id_update_I;
		public unsafe void Update (int completed)
		{
			if (id_update_I == IntPtr.Zero)
				id_update_I = JNIEnv.GetMethodID (class_ref, "update", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (completed);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_I, __args);
		}

	}
}
