using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>Log</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/LogCommand", DoNotGenerateAcw=true)]
	public partial class LogCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Java.Lang.IIterable> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/LogCommand", typeof (LogCommand));

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

		protected LogCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']/constructor[@name='LogCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe LogCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_add_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_add_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Add_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_add_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Add_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_start)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var start = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_start, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (start));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="start">start</param>
		/// <summary>Mark a commit to start graph traversal from.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("add", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/LogCommand;", "GetAdd_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LogCommand Add (global::Org.Eclipse.Jgit.Lib.AnyObjectId start)
		{
			const string __id = "add.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/LogCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((start == null) ? IntPtr.Zero : ((global::Java.Lang.Object) start).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (start);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPath (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">a repository-relative path (with &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>Show only commits that affect any of the specified paths.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']/method[@name='addPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPath", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/LogCommand;", "GetAddPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LogCommand AddPath (string path)
		{
			const string __id = "addPath.(Ljava/lang/String;)Lorg/eclipse/jgit/api/LogCommand;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_addRange_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAddRange_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_addRange_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_addRange_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddRange_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_addRange_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_AddRange_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_since, IntPtr native_until)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var since = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_since, JniHandleOwnership.DoNotTransfer);
			var until = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_until, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddRange (since, until));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="since">since</param>
		/// <param name="until">until</param>
		/// <summary>Adds the range <c>since..until</c></summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']/method[@name='addRange' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("addRange", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/LogCommand;", "GetAddRange_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LogCommand AddRange (global::Org.Eclipse.Jgit.Lib.AnyObjectId since, global::Org.Eclipse.Jgit.Lib.AnyObjectId until)
		{
			const string __id = "addRange.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/LogCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((since == null) ? IntPtr.Zero : ((global::Java.Lang.Object) since).Handle);
				__args [1] = new JniArgumentValue ((until == null) ? IntPtr.Zero : ((global::Java.Lang.Object) until).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (since);
				global::System.GC.KeepAlive (until);
			}
		}

		static Delegate cb_all;
#pragma warning disable 0169
		static Delegate GetAllHandler ()
		{
			if (cb_all == null)
				cb_all = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_All);
			return cb_all;
		}

		static IntPtr n_All (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.All ());
		}
#pragma warning restore 0169

		/// <summary>Add all refs as commits to start the graph traversal from.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']/method[@name='all' and count(parameter)=0]"
		[Register ("all", "()Lorg/eclipse/jgit/api/LogCommand;", "GetAllHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LogCommand All ()
		{
			const string __id = "all.()Lorg/eclipse/jgit/api/LogCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Log</c> command with all the options and parameters
		/// collected by the setter methods (e.</summary>
		/// <returns>an iteration over RevCommits</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/Iterable;", "GetCallHandler")]
		public override unsafe global::Java.Lang.IIterable Call ()
		{
			const string __id = "call.()Ljava/lang/Iterable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_not_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetNot_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_not_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_not_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Not_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_not_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Not_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_start)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var start = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_start, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Not (start));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="start">start</param>
		/// <summary>Same as <c>--not start</c>, or <c>^start</c></summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']/method[@name='not' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("not", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/LogCommand;", "GetNot_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LogCommand Not (global::Org.Eclipse.Jgit.Lib.AnyObjectId start)
		{
			const string __id = "not.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/LogCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((start == null) ? IntPtr.Zero : ((global::Java.Lang.Object) start).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (start);
			}
		}

		static Delegate cb_setMaxCount_I;
#pragma warning disable 0169
		static Delegate GetSetMaxCount_IHandler ()
		{
			if (cb_setMaxCount_I == null)
				cb_setMaxCount_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetMaxCount_I);
			return cb_setMaxCount_I;
		}

		static IntPtr n_SetMaxCount_I (IntPtr jnienv, IntPtr native__this, int maxCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMaxCount (maxCount));
		}
#pragma warning restore 0169

		/// <param name="maxCount">the limit</param>
		/// <summary>Limit the number of commits to output.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']/method[@name='setMaxCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxCount", "(I)Lorg/eclipse/jgit/api/LogCommand;", "GetSetMaxCount_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LogCommand SetMaxCount (int maxCount)
		{
			const string __id = "setMaxCount.(I)Lorg/eclipse/jgit/api/LogCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxCount);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSkip_I;
#pragma warning disable 0169
		static Delegate GetSetSkip_IHandler ()
		{
			if (cb_setSkip_I == null)
				cb_setSkip_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetSkip_I);
			return cb_setSkip_I;
		}

		static IntPtr n_SetSkip_I (IntPtr jnienv, IntPtr native__this, int skip)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSkip (skip));
		}
#pragma warning restore 0169

		/// <param name="skip">the number of commits to skip</param>
		/// <summary>Skip the number of commits before starting to show the commit output.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='LogCommand']/method[@name='setSkip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSkip", "(I)Lorg/eclipse/jgit/api/LogCommand;", "GetSetSkip_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.LogCommand SetSkip (int skip)
		{
			const string __id = "setSkip.(I)Lorg/eclipse/jgit/api/LogCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skip);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.LogCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
