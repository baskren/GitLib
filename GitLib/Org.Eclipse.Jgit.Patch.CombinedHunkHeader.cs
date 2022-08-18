using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Patch {

	/// <summary>Hunk header for a hunk appearing in a "diff --cc" style patch.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='CombinedHunkHeader']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/patch/CombinedHunkHeader", DoNotGenerateAcw=true)]
	public partial class CombinedHunkHeader : global::Org.Eclipse.Jgit.Patch.HunkHeader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/CombinedHunkHeader", typeof (CombinedHunkHeader));

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

		protected CombinedHunkHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getOldImage_I;
#pragma warning disable 0169
		static Delegate GetGetOldImage_IHandler ()
		{
			if (cb_getOldImage_I == null)
				cb_getOldImage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetOldImage_I);
			return cb_getOldImage_I;
		}

		static IntPtr n_GetOldImage_I (IntPtr jnienv, IntPtr native__this, int nthParent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.CombinedHunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOldImage (nthParent));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='CombinedHunkHeader']/method[@name='getOldImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOldImage", "(I)Lorg/eclipse/jgit/patch/HunkHeader$OldImage;", "GetGetOldImage_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Patch.HunkHeader.OldImage GetOldImage (int nthParent)
		{
			const string __id = "getOldImage.(I)Lorg/eclipse/jgit/patch/HunkHeader$OldImage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nthParent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader.OldImage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
