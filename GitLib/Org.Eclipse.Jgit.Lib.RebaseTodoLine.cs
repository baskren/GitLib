using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Describes a single line in a file formatted like the git-rebase-todo file.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RebaseTodoLine", DoNotGenerateAcw=true)]
	public partial class RebaseTodoLine : global::Java.Lang.Object {
		/// <summary>Describes rebase actions</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RebaseTodoLine$Action", DoNotGenerateAcw=true)]
		public sealed partial class Action : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/field[@name='COMMENT']"
			[Register ("COMMENT")]
			public static global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action Comment {
				get {
					const string __id = "COMMENT.Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/field[@name='EDIT']"
			[Register ("EDIT")]
			public static global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action Edit {
				get {
					const string __id = "EDIT.Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/field[@name='FIXUP']"
			[Register ("FIXUP")]
			public static global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action Fixup {
				get {
					const string __id = "FIXUP.Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/field[@name='PICK']"
			[Register ("PICK")]
			public static global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action Pick {
				get {
					const string __id = "PICK.Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/field[@name='REWORD']"
			[Register ("REWORD")]
			public static global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action Reword {
				get {
					const string __id = "REWORD.Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/field[@name='SQUASH']"
			[Register ("SQUASH")]
			public static global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action Squash {
				get {
					const string __id = "SQUASH.Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RebaseTodoLine$Action", typeof (Action));

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

			internal Action (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("parse", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action Parse (string token)
			{
				const string __id = "parse.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";
				IntPtr native_token = JNIEnv.NewString ((string)token);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_token);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_token);
				}
			}

			/// <returns>full action token name</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/method[@name='toToken' and count(parameter)=0]"
			[Register ("toToken", "()Ljava/lang/String;", "")]
			public unsafe string ToToken ()
			{
				const string __id = "toToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine.Action']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RebaseTodoLine", typeof (RebaseTodoLine));

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

		protected RebaseTodoLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="newComment">the new comment</param>
		/// <summary>Create a new comment line</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']/constructor[@name='RebaseTodoLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RebaseTodoLine (string newComment) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_newComment = JNIEnv.NewString ((string)newComment);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newComment);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newComment);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']/constructor[@name='RebaseTodoLine' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.RebaseTodoLine.Action'] and parameter[2][@type='org.eclipse.jgit.lib.AbbreviatedObjectId'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;Lorg/eclipse/jgit/lib/AbbreviatedObjectId;Ljava/lang/String;)V", "")]
		public unsafe RebaseTodoLine (global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action action, global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId commit, string shortMessage) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;Lorg/eclipse/jgit/lib/AbbreviatedObjectId;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_shortMessage = JNIEnv.NewString ((string)shortMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				__args [1] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				__args [2] = new JniArgumentValue (native_shortMessage);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_shortMessage);
				global::System.GC.KeepAlive (action);
				global::System.GC.KeepAlive (commit);
			}
		}

		static Delegate cb_getComment;
#pragma warning disable 0169
		static Delegate GetGetCommentHandler ()
		{
			if (cb_getComment == null)
				cb_getComment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetComment);
			return cb_getComment;
		}

		static IntPtr n_GetComment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Comment);
		}
#pragma warning restore 0169

		static Delegate cb_setComment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetComment_Ljava_lang_String_Handler ()
		{
			if (cb_setComment_Ljava_lang_String_ == null)
				cb_setComment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetComment_Ljava_lang_String_);
			return cb_setComment_Ljava_lang_String_;
		}

		static void n_SetComment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newComment)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newComment = JNIEnv.GetString (native_newComment, JniHandleOwnership.DoNotTransfer);
			__this.Comment = newComment;
		}
#pragma warning restore 0169

		/// <returns>a comment. If the line is a comment line then the comment is
		///         returned. Lines starting with # or blank lines or lines
		///         containing only spaces and tabs are considered as comment lines.
		///         The complete line is returned (e.g. including the '#')</returns>
		/// <summary>Set a comment for this line that is used if this line's
		/// <c>RebaseTodoLine#action</c> is a <c>Action#COMMENT</c></summary>
		/// <param name="newComment">the comment</param>
		public virtual unsafe string Comment {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']/method[@name='getComment' and count(parameter)=0]"
			[Register ("getComment", "()Ljava/lang/String;", "GetGetCommentHandler")]
			get {
				const string __id = "getComment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']/method[@name='setComment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setComment", "(Ljava/lang/String;)V", "GetSetComment_Ljava_lang_String_Handler")]
			set {
				const string __id = "setComment.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCommit;
#pragma warning disable 0169
		static Delegate GetGetCommitHandler ()
		{
			if (cb_getCommit == null)
				cb_getCommit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommit);
			return cb_getCommit;
		}

		static IntPtr n_GetCommit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Commit);
		}
#pragma warning restore 0169

		/// <returns>abbreviated commit SHA-1 of commit that action will be performed
		///         on</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId Commit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']/method[@name='getCommit' and count(parameter)=0]"
			[Register ("getCommit", "()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetGetCommitHandler")]
			get {
				const string __id = "getCommit.()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShortMessage;
#pragma warning disable 0169
		static Delegate GetGetShortMessageHandler ()
		{
			if (cb_getShortMessage == null)
				cb_getShortMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetShortMessage);
			return cb_getShortMessage;
		}

		static IntPtr n_GetShortMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ShortMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setShortMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShortMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setShortMessage_Ljava_lang_String_ == null)
				cb_setShortMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetShortMessage_Ljava_lang_String_);
			return cb_setShortMessage_Ljava_lang_String_;
		}

		static void n_SetShortMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_shortMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var shortMessage = JNIEnv.GetString (native_shortMessage, JniHandleOwnership.DoNotTransfer);
			__this.ShortMessage = shortMessage;
		}
#pragma warning restore 0169

		/// <returns>the first line of the commit message of the commit the action
		///         will be performed on.</returns>
		/// <param name="shortMessage">shortMessage</param>
		public virtual unsafe string ShortMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']/method[@name='getShortMessage' and count(parameter)=0]"
			[Register ("getShortMessage", "()Ljava/lang/String;", "GetGetShortMessageHandler")]
			get {
				const string __id = "getShortMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']/method[@name='setShortMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setShortMessage", "(Ljava/lang/String;)V", "GetSetShortMessage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setShortMessage.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAction;
#pragma warning disable 0169
		static Delegate GetGetActionHandler ()
		{
			if (cb_getAction == null)
				cb_getAction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAction);
			return cb_getAction;
		}

		static IntPtr n_GetAction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAction ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']/method[@name='getAction' and count(parameter)=0]"
		[Register ("getAction", "()Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;", "GetGetActionHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action GetAction ()
		{
			const string __id = "getAction.()Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAction_Lorg_eclipse_jgit_lib_RebaseTodoLine_Action_;
#pragma warning disable 0169
		static Delegate GetSetAction_Lorg_eclipse_jgit_lib_RebaseTodoLine_Action_Handler ()
		{
			if (cb_setAction_Lorg_eclipse_jgit_lib_RebaseTodoLine_Action_ == null)
				cb_setAction_Lorg_eclipse_jgit_lib_RebaseTodoLine_Action_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAction_Lorg_eclipse_jgit_lib_RebaseTodoLine_Action_);
			return cb_setAction_Lorg_eclipse_jgit_lib_RebaseTodoLine_Action_;
		}

		static void n_SetAction_Lorg_eclipse_jgit_lib_RebaseTodoLine_Action_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newAction)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newAction = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action> (native_newAction, JniHandleOwnership.DoNotTransfer);
			__this.SetAction (newAction);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoLine']/method[@name='setAction' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.RebaseTodoLine.Action']]"
		[Register ("setAction", "(Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;)V", "GetSetAction_Lorg_eclipse_jgit_lib_RebaseTodoLine_Action_Handler")]
		public virtual unsafe void SetAction (global::Org.Eclipse.Jgit.Lib.RebaseTodoLine.Action newAction)
		{
			const string __id = "setAction.(Lorg/eclipse/jgit/lib/RebaseTodoLine$Action;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newAction).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (newAction);
			}
		}

	}
}
