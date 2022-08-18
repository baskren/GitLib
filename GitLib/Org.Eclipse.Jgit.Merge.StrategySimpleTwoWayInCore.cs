using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>Merges two commits together in-memory, ignoring any working directory.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='StrategySimpleTwoWayInCore']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/StrategySimpleTwoWayInCore", DoNotGenerateAcw=true)]
	public partial class StrategySimpleTwoWayInCore : global::Org.Eclipse.Jgit.Merge.ThreeWayMergeStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/StrategySimpleTwoWayInCore", typeof (StrategySimpleTwoWayInCore));

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

		protected StrategySimpleTwoWayInCore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a new instance of the strategy.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='StrategySimpleTwoWayInCore']/constructor[@name='StrategySimpleTwoWayInCore' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe StrategySimpleTwoWayInCore () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.StrategySimpleTwoWayInCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='StrategySimpleTwoWayInCore']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
