using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>An exception detailing multiple reasons for failure.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='CompoundException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/CompoundException", DoNotGenerateAcw=true)]
	public partial class CompoundException : global::Java.Lang.Exception {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/CompoundException", typeof (CompoundException));

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

		protected CompoundException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="why">Two or more exceptions that may have been the problem.</param>
		/// <summary>Constructs an exception detailing many potential reasons for failure.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='CompoundException']/constructor[@name='CompoundException' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.Throwable&gt;']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public unsafe CompoundException (global::System.Collections.Generic.ICollection<global::Java.Lang.Throwable> why) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Collection;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_why = global::Android.Runtime.JavaCollection<global::Java.Lang.Throwable>.ToLocalJniHandle (why);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_why);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_why);
				global::System.GC.KeepAlive (why);
			}
		}

		static Delegate cb_getAllCauses;
#pragma warning disable 0169
		static Delegate GetGetAllCausesHandler ()
		{
			if (cb_getAllCauses == null)
				cb_getAllCauses = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllCauses);
			return cb_getAllCauses;
		}

		static IntPtr n_GetAllCauses (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.CompoundException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.ToLocalJniHandle (__this.AllCauses);
		}
#pragma warning restore 0169

		/// <summary>Get the complete list of reasons why this failure happened.</summary>
		/// <returns>unmodifiable collection of all possible reasons.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Throwable> AllCauses {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='CompoundException']/method[@name='getAllCauses' and count(parameter)=0]"
			[Register ("getAllCauses", "()Ljava/util/List;", "GetGetAllCausesHandler")]
			get {
				const string __id = "getAllCauses.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
