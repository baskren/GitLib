using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Checkout a branch to the working tree.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/CheckoutCommand", DoNotGenerateAcw=true)]
	public partial class CheckoutCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Lib.IRef> {
		/// <summary>Stage to check out, see <c>CheckoutCommand#setStage(Stage)</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand.Stage']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/CheckoutCommand$Stage", DoNotGenerateAcw=true)]
		public sealed partial class Stage : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand.Stage']/field[@name='BASE']"
			[Register ("BASE")]
			public static global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage Base {
				get {
					const string __id = "BASE.Lorg/eclipse/jgit/api/CheckoutCommand$Stage;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand.Stage']/field[@name='OURS']"
			[Register ("OURS")]
			public static global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage Ours {
				get {
					const string __id = "OURS.Lorg/eclipse/jgit/api/CheckoutCommand$Stage;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand.Stage']/field[@name='THEIRS']"
			[Register ("THEIRS")]
			public static global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage Theirs {
				get {
					const string __id = "THEIRS.Lorg/eclipse/jgit/api/CheckoutCommand$Stage;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CheckoutCommand$Stage", typeof (Stage));

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

			internal Stage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand.Stage']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutCommand$Stage;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutCommand$Stage;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand.Stage']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/api/CheckoutCommand$Stage;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/api/CheckoutCommand$Stage;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CheckoutCommand", typeof (CheckoutCommand));

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

		protected CheckoutCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/constructor[@name='CheckoutCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe CheckoutCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		/// <returns>the result, never &lt;code&gt;null&lt;/code&gt;</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutResult Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Lorg/eclipse/jgit/api/CheckoutResult;", "GetGetResultHandler")]
			get {
				const string __id = "getResult.()Lorg/eclipse/jgit/api/CheckoutResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddPath_Ljava_lang_String_Handler ()
		{
			if (cb_addPath_Ljava_lang_String_ == null)
				cb_addPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddPath_Ljava_lang_String_);
			return cb_addPath_Ljava_lang_String_;
		}

		static IntPtr n_AddPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPath (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path to update in the working tree and index (with
		///            &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>Add a single slash-separated path to the list of paths to check out.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='addPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPath", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetAddPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand AddPath (string path)
		{
			const string __id = "addPath.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutCommand;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <returns>the newly created branch</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='call' and count(parameter)=0]"
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

		static Delegate cb_checkoutPaths;
#pragma warning disable 0169
		static Delegate GetCheckoutPathsHandler ()
		{
			if (cb_checkoutPaths == null)
				cb_checkoutPaths = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CheckoutPaths);
			return cb_checkoutPaths;
		}

		static IntPtr n_CheckoutPaths (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CheckoutPaths ());
		}
#pragma warning restore 0169

		/// <summary>Checkout paths into index and working directory</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='checkoutPaths' and count(parameter)=0]"
		[Register ("checkoutPaths", "()Lorg/eclipse/jgit/api/CheckoutCommand;", "GetCheckoutPathsHandler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand CheckoutPaths ()
		{
			const string __id = "checkoutPaths.()Lorg/eclipse/jgit/api/CheckoutCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAllPaths_Z;
#pragma warning disable 0169
		static Delegate GetSetAllPaths_ZHandler ()
		{
			if (cb_setAllPaths_Z == null)
				cb_setAllPaths_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAllPaths_Z);
			return cb_setAllPaths_Z;
		}

		static IntPtr n_SetAllPaths_Z (IntPtr jnienv, IntPtr native__this, bool all)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAllPaths (all));
		}
#pragma warning restore 0169

		/// <param name="all">&lt;code&gt;true&lt;/code&gt; to checkout all paths, &lt;code&gt;false&lt;/code&gt;
		///            otherwise</param>
		/// <summary>Set whether to checkout all paths.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='setAllPaths' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllPaths", "(Z)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetSetAllPaths_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand SetAllPaths (bool all)
		{
			const string __id = "setAllPaths.(Z)Lorg/eclipse/jgit/api/CheckoutCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (all);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCreateBranch_Z;
#pragma warning disable 0169
		static Delegate GetSetCreateBranch_ZHandler ()
		{
			if (cb_setCreateBranch_Z == null)
				cb_setCreateBranch_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCreateBranch_Z);
			return cb_setCreateBranch_Z;
		}

		static IntPtr n_SetCreateBranch_Z (IntPtr jnienv, IntPtr native__this, bool createBranch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCreateBranch (createBranch));
		}
#pragma warning restore 0169

		/// <param name="createBranch">if &lt;code&gt;true&lt;/code&gt; a branch will be created as part of the
		///            checkout and set to the specified start point</param>
		/// <summary>Specify whether to create a new branch.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='setCreateBranch' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCreateBranch", "(Z)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetSetCreateBranch_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand SetCreateBranch (bool createBranch)
		{
			const string __id = "setCreateBranch.(Z)Lorg/eclipse/jgit/api/CheckoutCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (createBranch);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetForce (force));
		}
#pragma warning restore 0169

		/// <param name="force">if &lt;code&gt;true&lt;/code&gt; and the branch with the given name
		///            already exists, the start-point of an existing branch will be
		///            set to a new start-point; if false, the existing branch will
		///            not be changed</param>
		/// <summary>Specify to force the ref update in case of a branch switch.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='setForce' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setForce", "(Z)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetSetForce_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand SetForce (bool force)
		{
			const string __id = "setForce.(Z)Lorg/eclipse/jgit/api/CheckoutCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (force);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">the name of the branch or commit</param>
		/// <summary>Specify the name of the branch or commit to check out, or the new branch
		/// name.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setName", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetSetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand SetName (string name)
		{
			const string __id = "setName.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutCommand;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setOrphan_Z;
#pragma warning disable 0169
		static Delegate GetSetOrphan_ZHandler ()
		{
			if (cb_setOrphan_Z == null)
				cb_setOrphan_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetOrphan_Z);
			return cb_setOrphan_Z;
		}

		static IntPtr n_SetOrphan_Z (IntPtr jnienv, IntPtr native__this, bool orphan)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOrphan (orphan));
		}
#pragma warning restore 0169

		/// <param name="orphan">if &lt;code&gt;true&lt;/code&gt; a orphan branch will be created as part
		///            of the checkout to the specified start point</param>
		/// <summary>Specify whether to create a new orphan branch.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='setOrphan' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOrphan", "(Z)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetSetOrphan_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand SetOrphan (bool orphan)
		{
			const string __id = "setOrphan.(Z)Lorg/eclipse/jgit/api/CheckoutCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (orphan);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStage_Lorg_eclipse_jgit_api_CheckoutCommand_Stage_;
#pragma warning disable 0169
		static Delegate GetSetStage_Lorg_eclipse_jgit_api_CheckoutCommand_Stage_Handler ()
		{
			if (cb_setStage_Lorg_eclipse_jgit_api_CheckoutCommand_Stage_ == null)
				cb_setStage_Lorg_eclipse_jgit_api_CheckoutCommand_Stage_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetStage_Lorg_eclipse_jgit_api_CheckoutCommand_Stage_);
			return cb_setStage_Lorg_eclipse_jgit_api_CheckoutCommand_Stage_;
		}

		static IntPtr n_SetStage_Lorg_eclipse_jgit_api_CheckoutCommand_Stage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var stage = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage> (native_stage, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStage (stage));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='setStage' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.CheckoutCommand.Stage']]"
		[Register ("setStage", "(Lorg/eclipse/jgit/api/CheckoutCommand$Stage;)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetSetStage_Lorg_eclipse_jgit_api_CheckoutCommand_Stage_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand SetStage (global::Org.Eclipse.Jgit.Api.CheckoutCommand.Stage stage)
		{
			const string __id = "setStage.(Lorg/eclipse/jgit/api/CheckoutCommand$Stage;)Lorg/eclipse/jgit/api/CheckoutCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stage).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (stage);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var startPoint = JNIEnv.GetString (native_startPoint, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStartPoint (startPoint));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="startPoint">commit name to check out</param>
		/// <summary>Set the name of the commit that should be checked out.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='setStartPoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setStartPoint", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetSetStartPoint_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand SetStartPoint (string startPoint)
		{
			const string __id = "setStartPoint.(Ljava/lang/String;)Lorg/eclipse/jgit/api/CheckoutCommand;";
			IntPtr native_startPoint = JNIEnv.NewString ((string)startPoint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_startPoint);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_SetStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_startCommit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var startCommit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_startCommit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStartPoint (startCommit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="startCommit">commit to check out</param>
		/// <summary>Set the commit that should be checked out.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='setStartPoint' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("setStartPoint", "(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetSetStartPoint_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand SetStartPoint (global::Org.Eclipse.Jgit.Revwalk.RevCommit startCommit)
		{
			const string __id = "setStartPoint.(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/api/CheckoutCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((startCommit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) startCommit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (startCommit);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpstreamMode (mode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CheckoutCommand']/method[@name='setUpstreamMode' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.CreateBranchCommand.SetupUpstreamMode']]"
		[Register ("setUpstreamMode", "(Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;)Lorg/eclipse/jgit/api/CheckoutCommand;", "GetSetUpstreamMode_Lorg_eclipse_jgit_api_CreateBranchCommand_SetupUpstreamMode_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CheckoutCommand SetUpstreamMode (global::Org.Eclipse.Jgit.Api.CreateBranchCommand.SetupUpstreamMode mode)
		{
			const string __id = "setUpstreamMode.(Lorg/eclipse/jgit/api/CreateBranchCommand$SetupUpstreamMode;)Lorg/eclipse/jgit/api/CheckoutCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CheckoutCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mode);
			}
		}

	}
}
