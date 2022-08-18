using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>A three-way merger performing a content-merge if necessary across multiple
	/// bases using recursion</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='RecursiveMerger']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/RecursiveMerger", DoNotGenerateAcw=true)]
	public partial class RecursiveMerger : global::Org.Eclipse.Jgit.Merge.ResolveMerger {

		/// <summary>The maximum number of merge bases.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='RecursiveMerger']/field[@name='MAX_BASES']"
		[Register ("MAX_BASES")]
		public int MaxBases {
			get {
				const string __id = "MAX_BASES.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "MAX_BASES.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/RecursiveMerger", typeof (RecursiveMerger));

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

		protected RecursiveMerger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="local">local</param>
		/// <summary>Normal recursive merge, implies not inCore</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='RecursiveMerger']/constructor[@name='RecursiveMerger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe RecursiveMerger (global::Org.Eclipse.Jgit.Lib.Repository local) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (local);
			}
		}

		/// <param name="local">local</param>
		/// <param name="inCore">inCore</param>
		/// <summary>Normal recursive merge when you want a choice of DirCache placement
		/// inCore</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='RecursiveMerger']/constructor[@name='RecursiveMerger' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Z)V", "")]
		protected unsafe RecursiveMerger (global::Org.Eclipse.Jgit.Lib.Repository local, bool inCore) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue (inCore);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (local);
			}
		}

		static Delegate cb_getBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_I;
#pragma warning disable 0169
		static Delegate GetGetBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_IHandler ()
		{
			if (cb_getBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_I == null)
				cb_getBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_L) n_GetBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_I);
			return cb_getBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_I;
		}

		static IntPtr n_GetBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_I (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b, int callDepth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.RecursiveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_b, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBaseCommit (a, b, callDepth));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="a">the first commit to be merged</param>
		/// <param name="b">the second commit to be merged</param>
		/// <param name="callDepth">the callDepth when this method is called recursively</param>
		/// <summary>Get a single base commit for two given commits.</summary>
		/// <returns>the merge base of two commits. If a criss-cross merge required a
		///         synthetic merge base this commit is visible only the merger's
		///         RevWalk and will not be in the repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='RecursiveMerger']/method[@name='getBaseCommit' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[3][@type='int']]"
		[Register ("getBaseCommit", "(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;I)Lorg/eclipse/jgit/revwalk/RevCommit;", "GetGetBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_IHandler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit GetBaseCommit (global::Org.Eclipse.Jgit.Revwalk.RevCommit a, global::Org.Eclipse.Jgit.Revwalk.RevCommit b, int callDepth)
		{
			const string __id = "getBaseCommit.(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;I)Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [2] = new JniArgumentValue (callDepth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

	}
}
