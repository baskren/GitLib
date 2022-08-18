using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Remove untracked files from the working tree</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CleanCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/CleanCommand", DoNotGenerateAcw=true)]
	public partial class CleanCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::System.Collections.Generic.ICollection<string>> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/CleanCommand", typeof (CleanCommand));

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

		protected CleanCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CleanCommand']/constructor[@name='CleanCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe CleanCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>clean</c> command with all the options and parameters
		/// collected by the setter methods of this class.</summary>
		/// <returns>a set of strings representing each file cleaned.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CleanCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/Set;", "GetCallHandler")]
		public override unsafe global::System.Collections.Generic.ICollection<string> Call ()
		{
			const string __id = "call.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCleanDirectories_Z;
#pragma warning disable 0169
		static Delegate GetSetCleanDirectories_ZHandler ()
		{
			if (cb_setCleanDirectories_Z == null)
				cb_setCleanDirectories_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCleanDirectories_Z);
			return cb_setCleanDirectories_Z;
		}

		static IntPtr n_SetCleanDirectories_Z (IntPtr jnienv, IntPtr native__this, bool dirs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCleanDirectories (dirs));
		}
#pragma warning restore 0169

		/// <param name="dirs">whether to clean directories too, or only files.</param>
		/// <summary>If dirs is set, in addition to files, also clean directories.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CleanCommand']/method[@name='setCleanDirectories' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCleanDirectories", "(Z)Lorg/eclipse/jgit/api/CleanCommand;", "GetSetCleanDirectories_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CleanCommand SetCleanDirectories (bool dirs)
		{
			const string __id = "setCleanDirectories.(Z)Lorg/eclipse/jgit/api/CleanCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dirs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDryRun_Z;
#pragma warning disable 0169
		static Delegate GetSetDryRun_ZHandler ()
		{
			if (cb_setDryRun_Z == null)
				cb_setDryRun_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetDryRun_Z);
			return cb_setDryRun_Z;
		}

		static IntPtr n_SetDryRun_Z (IntPtr jnienv, IntPtr native__this, bool dryRun)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDryRun (dryRun));
		}
#pragma warning restore 0169

		/// <param name="dryRun">whether to do a dry run or not</param>
		/// <summary>If dryRun is set, the paths in question will not actually be deleted.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CleanCommand']/method[@name='setDryRun' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDryRun", "(Z)Lorg/eclipse/jgit/api/CleanCommand;", "GetSetDryRun_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CleanCommand SetDryRun (bool dryRun)
		{
			const string __id = "setDryRun.(Z)Lorg/eclipse/jgit/api/CleanCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dryRun);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIgnore_Z;
#pragma warning disable 0169
		static Delegate GetSetIgnore_ZHandler ()
		{
			if (cb_setIgnore_Z == null)
				cb_setIgnore_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetIgnore_Z);
			return cb_setIgnore_Z;
		}

		static IntPtr n_SetIgnore_Z (IntPtr jnienv, IntPtr native__this, bool ignore)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIgnore (ignore));
		}
#pragma warning restore 0169

		/// <param name="ignore">whether to respect .gitignore or not.</param>
		/// <summary>If ignore is set, don't report/clean files/directories that are ignored
		/// by a .</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CleanCommand']/method[@name='setIgnore' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIgnore", "(Z)Lorg/eclipse/jgit/api/CleanCommand;", "GetSetIgnore_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CleanCommand SetIgnore (bool ignore)
		{
			const string __id = "setIgnore.(Z)Lorg/eclipse/jgit/api/CleanCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ignore);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPaths_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetPaths_Ljava_util_Set_Handler ()
		{
			if (cb_setPaths_Ljava_util_Set_ == null)
				cb_setPaths_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPaths_Ljava_util_Set_);
			return cb_setPaths_Ljava_util_Set_;
		}

		static IntPtr n_SetPaths_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paths)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paths = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_paths, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPaths (paths));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="paths">the paths to set (with &lt;code&gt;/&lt;/code&gt; as separator)</param>
		/// <summary>If paths are set, only these paths are affected by the cleaning.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='CleanCommand']/method[@name='setPaths' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("setPaths", "(Ljava/util/Set;)Lorg/eclipse/jgit/api/CleanCommand;", "GetSetPaths_Ljava_util_Set_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.CleanCommand SetPaths (global::System.Collections.Generic.ICollection<string> paths)
		{
			const string __id = "setPaths.(Ljava/util/Set;)Lorg/eclipse/jgit/api/CleanCommand;";
			IntPtr native_paths = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (paths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paths);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.CleanCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_paths);
				global::System.GC.KeepAlive (paths);
			}
		}

	}
}
