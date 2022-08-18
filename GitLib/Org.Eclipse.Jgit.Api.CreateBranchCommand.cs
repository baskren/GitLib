using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Used to create a local branch.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/CreateBranchCommand", DoNotGenerateAcw=true)]
	public partial class CreateBranchCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Lib.IRef> {
		/// <summary>The modes available for setting up the upstream configuration
		/// (corresponding to the --set-upstream, --track, --no-track options</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand.SetupUpstreamMode']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode", DoNotGenerateAcw=true)]
		public sealed partial class SetupUpstreamMode : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand.SetupUpstreamMode']/field[@name='NOTRACK']"
			[Register ("NOTRACK")]
			public static global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode Notrack {
				get {
					const string __id = "NOTRACK.Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand.SetupUpstreamMode']/field[@name='SET_UPSTREAM']"
			[Register ("SET_UPSTREAM")]
			public static global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode SetUpstream {
				get {
					const string __id = "SET_UPSTREAM.Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand.SetupUpstreamMode']/field[@name='TRACK']"
			[Register ("TRACK")]
			public static global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode Track {
				get {
					const string __id = "TRACK.Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode", typeof (SetupUpstreamMode));

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

			internal SetupUpstreamMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand.SetupUpstreamMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand.SetupUpstreamMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CreateBranchCommand", typeof (CreateBranchCommand));

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

		protected CreateBranchCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand']/constructor[@name='CreateBranchCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe CreateBranchCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <returns>the newly created branch</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/lib/Ref;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IRef Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/lib/Ref;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetForce (force));
		}
#pragma warning restore 0169

		/// <param name="force">if &lt;code&gt;true&lt;/code&gt; and the branch with the given name
		///            already exists, the start-point of an existing branch will be
		///            set to a new start-point; if false, the existing branch will
		///            not be changed</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand']/method[@name='setForce' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setForce", "(Z)Lorg/eclipse/jgit/api/CreateBranchCommand;", "GetSetForce_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CreateBranchCommand SetForce (bool force)
		{
			const string __id = "setForce.(Z)Lorg/eclipse/jgit/api/CreateBranchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (force);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">the name of the new branch</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setName", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CreateBranchCommand;", "GetSetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CreateBranchCommand SetName (string name)
		{
			const string __id = "setName.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CreateBranchCommand;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setStartPoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStartPoint_Ljava_lang_String_Handler ()
		{
			if (cb_setStartPoint_Ljava_lang_String_ == null)
				cb_setStartPoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetStartPoint_Ljava_lang_String_);
			return cb_setStartPoint_Ljava_lang_String_;
		}

		static IntPtr n_SetStartPoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_startPoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var startPoint = JNIEnv.GetString (native_startPoint, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStartPoint (startPoint));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="startPoint">corresponds to the start-point option; if &lt;code&gt;null&lt;/code&gt;,
		///            the current HEAD will be used</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand']/method[@name='setStartPoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setStartPoint", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CreateBranchCommand;", "GetSetStartPoint_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CreateBranchCommand SetStartPoint (string startPoint)
		{
			const string __id = "setStartPoint.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CreateBranchCommand;";
			IntPtr native_startPoint = JNIEnv.NewString ((string)startPoint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_startPoint);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_startPoint);
			}
		}

		static Delegate cb_setStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetSetStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_setStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_setStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_setStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static IntPtr n_SetStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_startPoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var startPoint = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_startPoint, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStartPoint (startPoint));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="startPoint">corresponds to the start-point option; if &lt;code&gt;null&lt;/code&gt;,
		///            the current HEAD will be used</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand']/method[@name='setStartPoint' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("setStartPoint", "(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/api/CreateBranchCommand;", "GetSetStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CreateBranchCommand SetStartPoint (global::Org.Eclipse.Jgit.Revwalk.RevCommit startPoint)
		{
			const string __id = "setStartPoint.(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/api/CreateBranchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((startPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) startPoint).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (startPoint);
			}
		}

		static Delegate cb_setUpstreamMode_Lorg_eclipse_jgit_api_CreateBranchCommand_SetupUpstreamMode_;
#pragma warning disable 0169
		static Delegate GetSetUpstreamMode_Lorg_eclipse_jgit_api_CreateBranchCommand_SetupUpstreamMode_Handler ()
		{
			if (cb_setUpstreamMode_Lorg_eclipse_jgit_api_CreateBranchCommand_SetupUpstreamMode_ == null)
				cb_setUpstreamMode_Lorg_eclipse_jgit_api_CreateBranchCommand_SetupUpstreamMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpstreamMode_Lorg_eclipse_jgit_api_CreateBranchCommand_SetupUpstreamMode_);
			return cb_setUpstreamMode_Lorg_eclipse_jgit_api_CreateBranchCommand_SetupUpstreamMode_;
		}

		static IntPtr n_SetUpstreamMode_Lorg_eclipse_jgit_api_CreateBranchCommand_SetupUpstreamMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpstreamMode (mode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CreateBranchCommand']/method[@name='setUpstreamMode' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.CreateBranchCommand.SetupUpstreamMode']]"
		[Register ("setUpstreamMode", "(Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;)Lorg/eclipse/jgit/api/CreateBranchCommand;", "GetSetUpstreamMode_Lorg_eclipse_jgit_api_CreateBranchCommand_SetupUpstreamMode_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CreateBranchCommand SetUpstreamMode (global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode mode)
		{
			const string __id = "setUpstreamMode.(Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;)Lorg/eclipse/jgit/api/CreateBranchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mode);
			}
		}

	}
}
