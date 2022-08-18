using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a submodule update command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleUpdateCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/SubmoduleUpdateCommand", DoNotGenerateAcw=true)]
	public partial class SubmoduleUpdateCommand : global::Org.Eclipse.Jgit.Api.TransportCommand<global::System.Collections.Generic.ICollection<string>> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/SubmoduleUpdateCommand", typeof (SubmoduleUpdateCommand));

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

		protected SubmoduleUpdateCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleUpdateCommand']/constructor[@name='SubmoduleUpdateCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe SubmoduleUpdateCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPath (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">(with &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>Add repository-relative submodule path to initialize</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleUpdateCommand']/method[@name='addPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPath", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/SubmoduleUpdateCommand;", "GetAddPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand AddPath (string path)
		{
			const string __id = "addPath.(Ljava/lang/String;)Lorg/eclipse/jgit/api/SubmoduleUpdateCommand;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Execute the SubmoduleUpdateCommand command.</summary>
		/// <returns>a collection of updated submodule paths</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleUpdateCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/Collection;", "GetCallHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Call ()
		{
			const string __id = "call.()Ljava/util/Collection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaCollection<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (monitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">monitor</param>
		/// <summary>The progress monitor associated with the clone operation.</summary>
		/// <returns>this command</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleUpdateCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/SubmoduleUpdateCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/SubmoduleUpdateCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strategy = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (native_strategy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStrategy (strategy));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="strategy">The merge strategy to use during this update operation.</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='SubmoduleUpdateCommand']/method[@name='setStrategy' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.merge.MergeStrategy']]"
		[Register ("setStrategy", "(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/SubmoduleUpdateCommand;", "GetSetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand SetStrategy (global::Org.Eclipse.Jgit.Merge.MergeStrategy strategy)
		{
			const string __id = "setStrategy.(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/SubmoduleUpdateCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.SubmoduleUpdateCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (strategy);
			}
		}

	}
}
