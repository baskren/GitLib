using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Used to obtain a list of branches.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/ListBranchCommand", DoNotGenerateAcw=true)]
	public partial class ListBranchCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef>> {
		/// <summary>The modes available for listing branches (corresponding to the -r and -a
		/// options)</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand.ListMode']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/ListBranchCommand$ListMode", DoNotGenerateAcw=true)]
		public sealed partial class ListMode : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand.ListMode']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode All {
				get {
					const string __id = "ALL.Lorg/eclipse/jgit/api/ListBranchCommand$ListMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand.ListMode']/field[@name='REMOTE']"
			[Register ("REMOTE")]
			public static global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode Remote {
				get {
					const string __id = "REMOTE.Lorg/eclipse/jgit/api/ListBranchCommand$ListMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/ListBranchCommand$ListMode", typeof (ListMode));

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

			internal ListMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand.ListMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/ListBranchCommand$ListMode;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/ListBranchCommand$ListMode;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand.ListMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/api/ListBranchCommand$ListMode;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/api/ListBranchCommand$ListMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/ListBranchCommand", typeof (ListBranchCommand));

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

		protected ListBranchCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand']/constructor[@name='ListBranchCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe ListBranchCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/List;", "GetCallHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> Call ()
		{
			const string __id = "call.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setContains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContains_Ljava_lang_String_Handler ()
		{
			if (cb_setContains_Ljava_lang_String_ == null)
				cb_setContains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetContains_Ljava_lang_String_);
			return cb_setContains_Ljava_lang_String_;
		}

		static IntPtr n_SetContains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_containsCommitish)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var containsCommitish = JNIEnv.GetString (native_containsCommitish, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContains (containsCommitish));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="containsCommitish">a commit ID or ref name</param>
		/// <summary>If this is set, only the branches that contain the specified commit-ish
		/// as an ancestor are returned.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand']/method[@name='setContains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContains", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/ListBranchCommand;", "GetSetContains_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ListBranchCommand SetContains (string containsCommitish)
		{
			const string __id = "setContains.(Ljava/lang/String;)Lorg/eclipse/jgit/api/ListBranchCommand;";
			IntPtr native_containsCommitish = JNIEnv.NewString ((string)containsCommitish);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_containsCommitish);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_containsCommitish);
			}
		}

		static Delegate cb_setListMode_Lorg_eclipse_jgit_api_ListBranchCommand_ListMode_;
#pragma warning disable 0169
		static Delegate GetSetListMode_Lorg_eclipse_jgit_api_ListBranchCommand_ListMode_Handler ()
		{
			if (cb_setListMode_Lorg_eclipse_jgit_api_ListBranchCommand_ListMode_ == null)
				cb_setListMode_Lorg_eclipse_jgit_api_ListBranchCommand_ListMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetListMode_Lorg_eclipse_jgit_api_ListBranchCommand_ListMode_);
			return cb_setListMode_Lorg_eclipse_jgit_api_ListBranchCommand_ListMode_;
		}

		static IntPtr n_SetListMode_Lorg_eclipse_jgit_api_ListBranchCommand_ListMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listMode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode> (native_listMode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetListMode (listMode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='ListBranchCommand']/method[@name='setListMode' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.ListBranchCommand.ListMode']]"
		[Register ("setListMode", "(Lorg/eclipse/jgit/api/ListBranchCommand$ListMode;)Lorg/eclipse/jgit/api/ListBranchCommand;", "GetSetListMode_Lorg_eclipse_jgit_api_ListBranchCommand_ListMode_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.ListBranchCommand SetListMode (global::Org.Eclipse.Jgit.Api.ListBranchCommand.ListMode listMode)
		{
			const string __id = "setListMode.(Lorg/eclipse/jgit/api/ListBranchCommand$ListMode;)Lorg/eclipse/jgit/api/ListBranchCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listMode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.ListBranchCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listMode);
			}
		}

	}
}
