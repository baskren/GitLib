using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Describes the result of running an external process.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/ProcessResult", DoNotGenerateAcw=true)]
	public partial class ProcessResult : global::Java.Lang.Object {
		/// <summary>Status of a process' execution.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult.Status']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/ProcessResult$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult.Status']/field[@name='NOT_PRESENT']"
			[Register ("NOT_PRESENT")]
			public static global::Org.Eclipse.Jgit.Util.ProcessResult.Status NotPresent {
				get {
					const string __id = "NOT_PRESENT.Lorg/eclipse/jgit/util/ProcessResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult.Status']/field[@name='NOT_SUPPORTED']"
			[Register ("NOT_SUPPORTED")]
			public static global::Org.Eclipse.Jgit.Util.ProcessResult.Status NotSupported {
				get {
					const string __id = "NOT_SUPPORTED.Lorg/eclipse/jgit/util/ProcessResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult.Status']/field[@name='OK']"
			[Register ("OK")]
			public static global::Org.Eclipse.Jgit.Util.ProcessResult.Status Ok {
				get {
					const string __id = "OK.Lorg/eclipse/jgit/util/ProcessResult$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/ProcessResult$Status", typeof (Status));

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

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/util/ProcessResult$Status;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Util.ProcessResult.Status ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/util/ProcessResult$Status;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/util/ProcessResult$Status;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Util.ProcessResult.Status[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/util/ProcessResult$Status;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Util.ProcessResult.Status[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Util.ProcessResult.Status));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/ProcessResult", typeof (ProcessResult));

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

		protected ProcessResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult']/constructor[@name='ProcessResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.eclipse.jgit.util.ProcessResult.Status']]"
		[Register (".ctor", "(ILorg/eclipse/jgit/util/ProcessResult$Status;)V", "")]
		public unsafe ProcessResult (int exitCode, global::Org.Eclipse.Jgit.Util.ProcessResult.Status status) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILorg/eclipse/jgit/util/ProcessResult$Status;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (exitCode);
				__args [1] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (status);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult']/constructor[@name='ProcessResult' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.ProcessResult.Status']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/util/ProcessResult$Status;)V", "")]
		public unsafe ProcessResult (global::Org.Eclipse.Jgit.Util.ProcessResult.Status status) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/util/ProcessResult$Status;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (status);
			}
		}

		static Delegate cb_getExitCode;
#pragma warning disable 0169
		static Delegate GetGetExitCodeHandler ()
		{
			if (cb_getExitCode == null)
				cb_getExitCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetExitCode);
			return cb_getExitCode;
		}

		static int n_GetExitCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExitCode;
		}
#pragma warning restore 0169

		/// <returns>The exit code of the process.</returns>
		public virtual unsafe int ExitCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult']/method[@name='getExitCode' and count(parameter)=0]"
			[Register ("getExitCode", "()I", "GetGetExitCodeHandler")]
			get {
				const string __id = "getExitCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ProcessResult']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lorg/eclipse/jgit/util/ProcessResult$Status;", "GetGetStatusHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Util.ProcessResult.Status GetStatus ()
		{
			const string __id = "getStatus.()Lorg/eclipse/jgit/util/ProcessResult$Status;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.ProcessResult.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
