using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Command class to delete a stashed commit reference</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashDropCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/StashDropCommand", DoNotGenerateAcw=true)]
	public partial class StashDropCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Lib.ObjectId> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/StashDropCommand", typeof (StashDropCommand));

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

		protected StashDropCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashDropCommand']/constructor[@name='StashDropCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe StashDropCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashDropCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Drop the configured entry from the stash reflog and return value of the
		/// stash reference after the drop occurs</summary>
		/// <returns>commit id of stash reference or null if no more stashed changes</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashDropCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAll_Z;
#pragma warning disable 0169
		static Delegate GetSetAll_ZHandler ()
		{
			if (cb_setAll_Z == null)
				cb_setAll_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAll_Z);
			return cb_setAll_Z;
		}

		static IntPtr n_SetAll_Z (IntPtr jnienv, IntPtr native__this, bool all)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashDropCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAll (all));
		}
#pragma warning restore 0169

		/// <param name="all">true to drop all stashed commits, false to drop only the
		///            stashed commit set via calling <c>#setStashRef(int)</c></param>
		/// <summary>Set wheter drop all stashed commits</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashDropCommand']/method[@name='setAll' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAll", "(Z)Lorg/eclipse/jgit/api/StashDropCommand;", "GetSetAll_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashDropCommand SetAll (bool all)
		{
			const string __id = "setAll.(Z)Lorg/eclipse/jgit/api/StashDropCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (all);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashDropCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStashRef_I;
#pragma warning disable 0169
		static Delegate GetSetStashRef_IHandler ()
		{
			if (cb_setStashRef_I == null)
				cb_setStashRef_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetStashRef_I);
			return cb_setStashRef_I;
		}

		static IntPtr n_SetStashRef_I (IntPtr jnienv, IntPtr native__this, int stashRef)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashDropCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStashRef (stashRef));
		}
#pragma warning restore 0169

		/// <param name="stashRef">stashRef</param>
		/// <summary>Set the stash reference to drop (0-based).</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='StashDropCommand']/method[@name='setStashRef' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStashRef", "(I)Lorg/eclipse/jgit/api/StashDropCommand;", "GetSetStashRef_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.StashDropCommand SetStashRef (int stashRef)
		{
			const string __id = "setStashRef.(I)Lorg/eclipse/jgit/api/StashDropCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (stashRef);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.StashDropCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
