using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	public abstract class GitCommand<T> : GitCommand
	{
        protected GitCommand(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        protected unsafe GitCommand(global::Org.Eclipse.Jgit.Lib.Repository repo) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer) { }

		public virtual T Call() { throw new NotImplementedException(); }
	}

    /// <param name="&lt;T&gt;">the return type which is expected from <c>#call()</c></param>
    /// <summary>Common superclass of all commands in the package <c>org.eclipse.jgit.api</c></summary>
    // Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GitCommand']"
    [global::Android.Runtime.Register ("org/eclipse/jgit/api/GitCommand", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class GitCommand : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable {

		/// <summary>The repository this command is working with</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GitCommand']/field[@name='repo']"
		[Register ("repo")]
		protected global::Org.Eclipse.Jgit.Lib.Repository Repo {
			get {
				const string __id = "repo.Lorg/eclipse/jgit/lib/Repository;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repo.Lorg/eclipse/jgit/lib/Repository;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/GitCommand", typeof (GitCommand));

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

		protected GitCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">the <c>Repository</c> this command should interact with</param>
		/// <summary>Creates a new command which interacts with a single repository</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GitCommand']/constructor[@name='GitCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe GitCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getRepository;
#pragma warning disable 0169
		static Delegate GetGetRepositoryHandler ()
		{
			if (cb_getRepository == null)
				cb_getRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepository);
			return cb_getRepository;
		}

		static IntPtr n_GetRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		/// <returns>the <c>Repository</c> this command is interacting with</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GitCommand']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "GetGetRepositoryHandler")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/lib/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkCallable;
#pragma warning disable 0169
		static Delegate GetCheckCallableHandler ()
		{
			if (cb_checkCallable == null)
				cb_checkCallable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CheckCallable);
			return cb_checkCallable;
		}

		static void n_CheckCallable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckCallable ();
		}
#pragma warning restore 0169

		/// <summary>Checks that the property <c>#callable</c> is <c>true</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GitCommand']/method[@name='checkCallable' and count(parameter)=0]"
		[Register ("checkCallable", "()V", "GetCheckCallableHandler")]
		protected virtual unsafe void CheckCallable ()
		{
			const string __id = "checkCallable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCallable_Z;
#pragma warning disable 0169
		static Delegate GetSetCallable_ZHandler ()
		{
			if (cb_setCallable_Z == null)
				cb_setCallable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCallable_Z);
			return cb_setCallable_Z;
		}

		static void n_SetCallable_Z (IntPtr jnienv, IntPtr native__this, bool callable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GitCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCallable (callable);
		}
#pragma warning restore 0169

		/// <param name="callable">if &lt;code&gt;true&lt;/code&gt; it is allowed to call <c>#call()</c> on
		///            this instance.</param>
		/// <summary>Set's the state which tells whether it is allowed to call <c>#call()</c>
		/// on this instance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='GitCommand']/method[@name='setCallable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCallable", "(Z)V", "GetSetCallable_ZHandler")]
		protected virtual unsafe void SetCallable (bool callable)
		{
			const string __id = "setCallable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (callable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/*
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.GitCommand<T>> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169
		*/
		//[Register("call", "()Ljava/lang/Object;", "GetCallHandler")]
		global::Java.Lang.Object Java.Util.Concurrent.ICallable.Call() { throw new NotImplementedException(); }

	}
	/*
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/GitCommand", DoNotGenerateAcw=true)]
	internal partial class GitCommandInvoker : GitCommand {
		public GitCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/GitCommand", typeof (GitCommandInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
		public override unsafe global::Java.Lang.Object Call ()
		{
			const string __id = "call.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
	*/
}
