using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A simple progress reporter printing on a stream.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TextProgressMonitor']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/TextProgressMonitor", DoNotGenerateAcw=true)]
	public partial class TextProgressMonitor : global::Org.Eclipse.Jgit.Lib.BatchingProgressMonitor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/TextProgressMonitor", typeof (TextProgressMonitor));

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

		protected TextProgressMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Initialize a new progress monitor.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TextProgressMonitor']/constructor[@name='TextProgressMonitor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextProgressMonitor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="out">the stream to receive messages on.</param>
		/// <summary>Initialize a new progress monitor.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TextProgressMonitor']/constructor[@name='TextProgressMonitor' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register (".ctor", "(Ljava/io/Writer;)V", "")]
		public unsafe TextProgressMonitor (global::Java.IO.Writer @out) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@out);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TextProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var taskName = JNIEnv.GetString (native_taskName, JniHandleOwnership.DoNotTransfer);
			__this.OnEndTask (taskName, workCurr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TextProgressMonitor']/method[@name='onEndTask' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onEndTask", "(Ljava/lang/String;I)V", "GetOnEndTask_Ljava_lang_String_IHandler")]
		protected override unsafe void OnEndTask (string taskName, int workCurr)
		{
			const string __id = "onEndTask.(Ljava/lang/String;I)V";
			IntPtr native_taskName = JNIEnv.NewString ((string)taskName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_taskName);
				__args [1] = new JniArgumentValue (workCurr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_taskName);
			}
		}

		static Delegate cb_onEndTask_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetOnEndTask_Ljava_lang_String_IIIHandler ()
		{
			if (cb_onEndTask_Ljava_lang_String_III == null)
				cb_onEndTask_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_V) n_OnEndTask_Ljava_lang_String_III);
			return cb_onEndTask_Ljava_lang_String_III;
		}

		static void n_OnEndTask_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_taskName, int cmp, int totalWork, int pcnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TextProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var taskName = JNIEnv.GetString (native_taskName, JniHandleOwnership.DoNotTransfer);
			__this.OnEndTask (taskName, cmp, totalWork, pcnt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TextProgressMonitor']/method[@name='onEndTask' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onEndTask", "(Ljava/lang/String;III)V", "GetOnEndTask_Ljava_lang_String_IIIHandler")]
		protected override unsafe void OnEndTask (string taskName, int cmp, int totalWork, int pcnt)
		{
			const string __id = "onEndTask.(Ljava/lang/String;III)V";
			IntPtr native_taskName = JNIEnv.NewString ((string)taskName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_taskName);
				__args [1] = new JniArgumentValue (cmp);
				__args [2] = new JniArgumentValue (totalWork);
				__args [3] = new JniArgumentValue (pcnt);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_taskName);
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TextProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var taskName = JNIEnv.GetString (native_taskName, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdate (taskName, workCurr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TextProgressMonitor']/method[@name='onUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onUpdate", "(Ljava/lang/String;I)V", "GetOnUpdate_Ljava_lang_String_IHandler")]
		protected override unsafe void OnUpdate (string taskName, int workCurr)
		{
			const string __id = "onUpdate.(Ljava/lang/String;I)V";
			IntPtr native_taskName = JNIEnv.NewString ((string)taskName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_taskName);
				__args [1] = new JniArgumentValue (workCurr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_taskName);
			}
		}

		static Delegate cb_onUpdate_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetOnUpdate_Ljava_lang_String_IIIHandler ()
		{
			if (cb_onUpdate_Ljava_lang_String_III == null)
				cb_onUpdate_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_V) n_OnUpdate_Ljava_lang_String_III);
			return cb_onUpdate_Ljava_lang_String_III;
		}

		static void n_OnUpdate_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_taskName, int cmp, int totalWork, int pcnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TextProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var taskName = JNIEnv.GetString (native_taskName, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdate (taskName, cmp, totalWork, pcnt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TextProgressMonitor']/method[@name='onUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onUpdate", "(Ljava/lang/String;III)V", "GetOnUpdate_Ljava_lang_String_IIIHandler")]
		protected override unsafe void OnUpdate (string taskName, int cmp, int totalWork, int pcnt)
		{
			const string __id = "onUpdate.(Ljava/lang/String;III)V";
			IntPtr native_taskName = JNIEnv.NewString ((string)taskName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_taskName);
				__args [1] = new JniArgumentValue (cmp);
				__args [2] = new JniArgumentValue (totalWork);
				__args [3] = new JniArgumentValue (pcnt);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_taskName);
			}
		}

	}
}
