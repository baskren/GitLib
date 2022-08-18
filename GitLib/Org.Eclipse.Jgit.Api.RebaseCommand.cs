using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>Rebase</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/RebaseCommand", DoNotGenerateAcw=true)]
	public partial class RebaseCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Api.RebaseResult> {
		/// <summary>The name of the "rebase-merge" folder for interactive rebases.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/field[@name='REBASE_MERGE']"
		[Register ("REBASE_MERGE")]
		public const string RebaseMerge = (string) "rebase-merge";

		/// <summary>The name of the "stopped-sha" file</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/field[@name='STOPPED_SHA']"
		[Register ("STOPPED_SHA")]
		public const string StoppedSha = (string) "stopped-sha";

		/// <summary>Allows configure rebase interactive process and modify commit message</summary>
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.api']/interface[@name='RebaseCommand.InteractiveHandler']"
		[Register ("org/eclipse/jgit/api/RebaseCommand$InteractiveHandler", "", "Org.Eclipse.Jgit.Api.RebaseCommand/IInteractiveHandlerInvoker")]
		public partial interface IInteractiveHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/interface[@name='RebaseCommand.InteractiveHandler']/method[@name='modifyCommitMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			/// <param name="commit">commit</param>
			/// <summary>Used for editing commit message on REWORD</summary>
			/// <returns>new commit message</returns>
			[Register ("modifyCommitMessage", "(Ljava/lang/String;)Ljava/lang/String;", "GetModifyCommitMessage_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Api.RebaseCommand/IInteractiveHandlerInvoker, AndroidBindableLibrary")]
			string ModifyCommitMessage (string commit);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/interface[@name='RebaseCommand.InteractiveHandler']/method[@name='prepareSteps' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.lib.RebaseTodoLine&gt;']]"
			/// <param name="steps">initial configuration of rebase interactive</param>
			/// <summary>Given list of <c>steps</c> should be modified according to user
			/// rebase configuration</summary>
			[Register ("prepareSteps", "(Ljava/util/List;)V", "GetPrepareSteps_Ljava_util_List_Handler:Org.Eclipse.Jgit.Api.RebaseCommand/IInteractiveHandlerInvoker, AndroidBindableLibrary")]
			void PrepareSteps (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> steps);

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/api/RebaseCommand$InteractiveHandler", DoNotGenerateAcw=true)]
		internal partial class IInteractiveHandlerInvoker : global::Java.Lang.Object, IInteractiveHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/RebaseCommand$InteractiveHandler", typeof (IInteractiveHandlerInvoker));

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

			public static IInteractiveHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInteractiveHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.api.RebaseCommand.InteractiveHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInteractiveHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_modifyCommitMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetModifyCommitMessage_Ljava_lang_String_Handler ()
			{
				if (cb_modifyCommitMessage_Ljava_lang_String_ == null)
					cb_modifyCommitMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ModifyCommitMessage_Ljava_lang_String_);
				return cb_modifyCommitMessage_Ljava_lang_String_;
			}

			static IntPtr n_ModifyCommitMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_commit)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.IInteractiveHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var commit = JNIEnv.GetString (native_commit, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.ModifyCommitMessage (commit));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_modifyCommitMessage_Ljava_lang_String_;
			public unsafe string ModifyCommitMessage (string commit)
			{
				if (id_modifyCommitMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_modifyCommitMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "modifyCommitMessage", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_commit = JNIEnv.NewString ((string)commit);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_commit);
				var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_modifyCommitMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_commit);
				return __ret;
			}

			static Delegate cb_prepareSteps_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetPrepareSteps_Ljava_util_List_Handler ()
			{
				if (cb_prepareSteps_Ljava_util_List_ == null)
					cb_prepareSteps_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrepareSteps_Ljava_util_List_);
				return cb_prepareSteps_Ljava_util_List_;
			}

			static void n_PrepareSteps_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_steps)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.IInteractiveHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var steps = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.FromJniHandle (native_steps, JniHandleOwnership.DoNotTransfer);
				__this.PrepareSteps (steps);
			}
#pragma warning restore 0169

			IntPtr id_prepareSteps_Ljava_util_List_;
			public unsafe void PrepareSteps (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> steps)
			{
				if (id_prepareSteps_Ljava_util_List_ == IntPtr.Zero)
					id_prepareSteps_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "prepareSteps", "(Ljava/util/List;)V");
				IntPtr native_steps = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.ToLocalJniHandle (steps);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_steps);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareSteps_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_steps);
			}

		}

		/// <summary>The available operations</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand.Operation']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/RebaseCommand$Operation", DoNotGenerateAcw=true)]
		public sealed partial class Operation : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand.Operation']/field[@name='ABORT']"
			[Register ("ABORT")]
			public static global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation Abort {
				get {
					const string __id = "ABORT.Lorg/eclipse/jgit/api/RebaseCommand$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand.Operation']/field[@name='BEGIN']"
			[Register ("BEGIN")]
			public static global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation Begin {
				get {
					const string __id = "BEGIN.Lorg/eclipse/jgit/api/RebaseCommand$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand.Operation']/field[@name='CONTINUE']"
			[Register ("CONTINUE")]
			public static global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation Continue {
				get {
					const string __id = "CONTINUE.Lorg/eclipse/jgit/api/RebaseCommand$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand.Operation']/field[@name='PROCESS_STEPS']"
			[Register ("PROCESS_STEPS")]
			public static global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation ProcessSteps {
				get {
					const string __id = "PROCESS_STEPS.Lorg/eclipse/jgit/api/RebaseCommand$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand.Operation']/field[@name='SKIP']"
			[Register ("SKIP")]
			public static global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation Skip {
				get {
					const string __id = "SKIP.Lorg/eclipse/jgit/api/RebaseCommand$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/RebaseCommand$Operation", typeof (Operation));

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

			internal Operation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand.Operation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/RebaseCommand$Operation;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/RebaseCommand$Operation;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand.Operation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/api/RebaseCommand$Operation;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/api/RebaseCommand$Operation;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/RebaseCommand", typeof (RebaseCommand));

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

		protected RebaseCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/constructor[@name='RebaseCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe RebaseCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Rebase</c> command with all the options and parameters
		/// collected by the setter methods of this class.</summary>
		/// <returns>an object describing the result of this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/api/RebaseResult;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Api.RebaseResult Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/api/RebaseResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_runInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_;
#pragma warning disable 0169
		static Delegate GetRunInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_Handler ()
		{
			if (cb_runInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_ == null)
				cb_runInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RunInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_);
			return cb_runInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_;
		}

		static IntPtr n_RunInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var handler = (global::Org.Eclipse.Jgit.Api.RebaseCommand.IInteractiveHandler)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.IInteractiveHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RunInteractively (handler));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='runInteractively' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.RebaseCommand.InteractiveHandler']]"
		[Register ("runInteractively", "(Lorg/eclipse/jgit/api/RebaseCommand$InteractiveHandler;)Lorg/eclipse/jgit/api/RebaseCommand;", "GetRunInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand RunInteractively (global::Org.Eclipse.Jgit.Api.RebaseCommand.IInteractiveHandler handler)
		{
			const string __id = "runInteractively.(Lorg/eclipse/jgit/api/RebaseCommand$InteractiveHandler;)Lorg/eclipse/jgit/api/RebaseCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (handler);
			}
		}

		static Delegate cb_runInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_Z;
#pragma warning disable 0169
		static Delegate GetRunInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_ZHandler ()
		{
			if (cb_runInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_Z == null)
				cb_runInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_RunInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_Z);
			return cb_runInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_Z;
		}

		static IntPtr n_RunInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_handler, bool stopAfterRebaseInteractiveInitialization)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var handler = (global::Org.Eclipse.Jgit.Api.RebaseCommand.IInteractiveHandler)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.IInteractiveHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RunInteractively (handler, stopAfterRebaseInteractiveInitialization));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='runInteractively' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.api.RebaseCommand.InteractiveHandler'] and parameter[2][@type='boolean']]"
		[Register ("runInteractively", "(Lorg/eclipse/jgit/api/RebaseCommand$InteractiveHandler;Z)Lorg/eclipse/jgit/api/RebaseCommand;", "GetRunInteractively_Lorg_eclipse_jgit_api_RebaseCommand_InteractiveHandler_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand RunInteractively (global::Org.Eclipse.Jgit.Api.RebaseCommand.IInteractiveHandler handler, bool stopAfterRebaseInteractiveInitialization)
		{
			const string __id = "runInteractively.(Lorg/eclipse/jgit/api/RebaseCommand$InteractiveHandler;Z)Lorg/eclipse/jgit/api/RebaseCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [1] = new JniArgumentValue (stopAfterRebaseInteractiveInitialization);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (handler);
			}
		}

		static Delegate cb_setOperation_Lorg_eclipse_jgit_api_RebaseCommand_Operation_;
#pragma warning disable 0169
		static Delegate GetSetOperation_Lorg_eclipse_jgit_api_RebaseCommand_Operation_Handler ()
		{
			if (cb_setOperation_Lorg_eclipse_jgit_api_RebaseCommand_Operation_ == null)
				cb_setOperation_Lorg_eclipse_jgit_api_RebaseCommand_Operation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOperation_Lorg_eclipse_jgit_api_RebaseCommand_Operation_);
			return cb_setOperation_Lorg_eclipse_jgit_api_RebaseCommand_Operation_;
		}

		static IntPtr n_SetOperation_Lorg_eclipse_jgit_api_RebaseCommand_Operation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operation = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation> (native_operation, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOperation (operation));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='setOperation' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.RebaseCommand.Operation']]"
		[Register ("setOperation", "(Lorg/eclipse/jgit/api/RebaseCommand$Operation;)Lorg/eclipse/jgit/api/RebaseCommand;", "GetSetOperation_Lorg_eclipse_jgit_api_RebaseCommand_Operation_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand SetOperation (global::Org.Eclipse.Jgit.Api.RebaseCommand.Operation operation)
		{
			const string __id = "setOperation.(Lorg/eclipse/jgit/api/RebaseCommand$Operation;)Lorg/eclipse/jgit/api/RebaseCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((operation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) operation).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (operation);
			}
		}

		static Delegate cb_setPreserveMerges_Z;
#pragma warning disable 0169
		static Delegate GetSetPreserveMerges_ZHandler ()
		{
			if (cb_setPreserveMerges_Z == null)
				cb_setPreserveMerges_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetPreserveMerges_Z);
			return cb_setPreserveMerges_Z;
		}

		static IntPtr n_SetPreserveMerges_Z (IntPtr jnienv, IntPtr native__this, bool preserve)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPreserveMerges (preserve));
		}
#pragma warning restore 0169

		/// <param name="preserve">True to re-create merges during rebase. Defaults to false, a
		///            flattening rebase.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='setPreserveMerges' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPreserveMerges", "(Z)Lorg/eclipse/jgit/api/RebaseCommand;", "GetSetPreserveMerges_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand SetPreserveMerges (bool preserve)
		{
			const string __id = "setPreserveMerges.(Z)Lorg/eclipse/jgit/api/RebaseCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (preserve);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (monitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">a progress monitor</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/RebaseCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/RebaseCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (monitor);
			}
		}

		static Delegate cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_;
#pragma warning disable 0169
		static Delegate GetSetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_Handler ()
		{
			if (cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_ == null)
				cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_);
			return cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_;
		}

		static IntPtr n_SetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStrategy (strategy));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="strategy">The merge strategy to use during this rebase operation.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='setStrategy' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.merge.MergeStrategy']]"
		[Register ("setStrategy", "(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/RebaseCommand;", "GetSetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand SetStrategy (global::Org.Eclipse.Jgit.Merge.MergeStrategy strategy)
		{
			const string __id = "setStrategy.(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/RebaseCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
			}
		}

		static Delegate cb_setUpstream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpstream_Ljava_lang_String_Handler ()
		{
			if (cb_setUpstream_Ljava_lang_String_ == null)
				cb_setUpstream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpstream_Ljava_lang_String_);
			return cb_setUpstream_Ljava_lang_String_;
		}

		static IntPtr n_SetUpstream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_upstream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var upstream = JNIEnv.GetString (native_upstream, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpstream (upstream));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="upstream">the upstream branch</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='setUpstream' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUpstream", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/RebaseCommand;", "GetSetUpstream_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand SetUpstream (string upstream)
		{
			const string __id = "setUpstream.(Ljava/lang/String;)Lorg/eclipse/jgit/api/RebaseCommand;";
			IntPtr native_upstream = JNIEnv.NewString ((string)upstream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_upstream);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_upstream);
			}
		}

		static Delegate cb_setUpstream_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetUpstream_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setUpstream_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setUpstream_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpstream_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setUpstream_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_SetUpstream_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_upstream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var upstream = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_upstream, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpstream (upstream));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="upstream">id of the upstream commit</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='setUpstream' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setUpstream", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/RebaseCommand;", "GetSetUpstream_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand SetUpstream (global::Org.Eclipse.Jgit.Lib.AnyObjectId upstream)
		{
			const string __id = "setUpstream.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/RebaseCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((upstream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) upstream).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (upstream);
			}
		}

		static Delegate cb_setUpstream_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetSetUpstream_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_setUpstream_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_setUpstream_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpstream_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_setUpstream_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static IntPtr n_SetUpstream_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_upstream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var upstream = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_upstream, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpstream (upstream));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="upstream">the upstream commit</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='setUpstream' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("setUpstream", "(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/api/RebaseCommand;", "GetSetUpstream_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand SetUpstream (global::Org.Eclipse.Jgit.Revwalk.RevCommit upstream)
		{
			const string __id = "setUpstream.(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/api/RebaseCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((upstream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) upstream).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (upstream);
			}
		}

		static Delegate cb_setUpstreamName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpstreamName_Ljava_lang_String_Handler ()
		{
			if (cb_setUpstreamName_Ljava_lang_String_ == null)
				cb_setUpstreamName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpstreamName_Ljava_lang_String_);
			return cb_setUpstreamName_Ljava_lang_String_;
		}

		static IntPtr n_SetUpstreamName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_upstreamName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var upstreamName = JNIEnv.GetString (native_upstreamName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpstreamName (upstreamName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="upstreamName">the name which will be used to refer to upstream in conflicts</param>
		/// <summary>Optionally override the name of the upstream.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='setUpstreamName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUpstreamName", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/RebaseCommand;", "GetSetUpstreamName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.RebaseCommand SetUpstreamName (string upstreamName)
		{
			const string __id = "setUpstreamName.(Ljava/lang/String;)Lorg/eclipse/jgit/api/RebaseCommand;";
			IntPtr native_upstreamName = JNIEnv.NewString ((string)upstreamName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_upstreamName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_upstreamName);
			}
		}

		static Delegate cb_tryFastForward_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetTryFastForward_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_tryFastForward_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_tryFastForward_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TryFastForward_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_tryFastForward_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static IntPtr n_TryFastForward_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newCommit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.RebaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newCommit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_newCommit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TryFastForward (newCommit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="newCommit">newCommit</param>
		/// <summary>checks if we can fast-forward and returns the new head if it is possible</summary>
		/// <returns>the new head, or null</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='RebaseCommand']/method[@name='tryFastForward' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("tryFastForward", "(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/revwalk/RevCommit;", "GetTryFastForward_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit TryFastForward (global::Org.Eclipse.Jgit.Revwalk.RevCommit newCommit)
		{
			const string __id = "tryFastForward.(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newCommit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newCommit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (newCommit);
			}
		}

	}
}
