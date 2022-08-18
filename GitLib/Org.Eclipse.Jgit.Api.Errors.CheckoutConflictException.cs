using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api.Errors {

	/// <summary>Exception thrown when a command can't succeed because of unresolved
	/// conflicts.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='CheckoutConflictException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/errors/CheckoutConflictException", DoNotGenerateAcw=true)]
	public partial class CheckoutConflictException : global::Org.Eclipse.Jgit.Api.Errors.GitAPIException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/errors/CheckoutConflictException", typeof (CheckoutConflictException));

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

		protected CheckoutConflictException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="conflictingPaths">list of conflicting paths</param>
		/// <param name="e">a <c>org.eclipse.jgit.errors.CheckoutConflictException</c>
		///            exception</param>
		/// <summary>Translate internal exception to API exception</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='CheckoutConflictException']/constructor[@name='CheckoutConflictException' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='org.eclipse.jgit.errors.CheckoutConflictException']]"
		[Register (".ctor", "(Ljava/util/List;Lorg/eclipse/jgit/errors/CheckoutConflictException;)V", "")]
		public unsafe CheckoutConflictException (global::System.Collections.Generic.IList<string> conflictingPaths, global::Org.Eclipse.Jgit.Errors.CheckoutConflictException e) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Lorg/eclipse/jgit/errors/CheckoutConflictException;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_conflictingPaths = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (conflictingPaths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_conflictingPaths);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_conflictingPaths);
				global::System.GC.KeepAlive (conflictingPaths);
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_getConflictingPaths;
#pragma warning disable 0169
		static Delegate GetGetConflictingPathsHandler ()
		{
			if (cb_getConflictingPaths == null)
				cb_getConflictingPaths = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConflictingPaths);
			return cb_getConflictingPaths;
		}

		static IntPtr n_GetConflictingPaths (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Errors.CheckoutConflictException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ConflictingPaths);
		}
#pragma warning restore 0169

		/// <returns>all the paths where unresolved conflicts have been detected</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> ConflictingPaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='CheckoutConflictException']/method[@name='getConflictingPaths' and count(parameter)=0]"
			[Register ("getConflictingPaths", "()Ljava/util/List;", "GetGetConflictingPathsHandler")]
			get {
				const string __id = "getConflictingPaths.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
