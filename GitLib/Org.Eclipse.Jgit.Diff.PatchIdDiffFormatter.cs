using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>A DiffFormatter used to calculate the patch-id of the diff.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='PatchIdDiffFormatter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/PatchIdDiffFormatter", DoNotGenerateAcw=true)]
	public partial class PatchIdDiffFormatter : global::Org.Eclipse.Jgit.Diff.DiffFormatter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/PatchIdDiffFormatter", typeof (PatchIdDiffFormatter));

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

		protected PatchIdDiffFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Initialize a formatter to compute a patch id.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='PatchIdDiffFormatter']/constructor[@name='PatchIdDiffFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PatchIdDiffFormatter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCalulatedPatchId;
#pragma warning disable 0169
		static Delegate GetGetCalulatedPatchIdHandler ()
		{
			if (cb_getCalulatedPatchId == null)
				cb_getCalulatedPatchId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCalulatedPatchId);
			return cb_getCalulatedPatchId;
		}

		static IntPtr n_GetCalulatedPatchId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.PatchIdDiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CalulatedPatchId);
		}
#pragma warning restore 0169

		/// <summary>Should be called after having called one of the format methods</summary>
		/// <returns>the patch id calculated for the provided diff.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId CalulatedPatchId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='PatchIdDiffFormatter']/method[@name='getCalulatedPatchId' and count(parameter)=0]"
			[Register ("getCalulatedPatchId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetCalulatedPatchIdHandler")]
			get {
				const string __id = "getCalulatedPatchId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
