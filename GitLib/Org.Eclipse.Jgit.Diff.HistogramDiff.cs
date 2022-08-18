using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>An extended form of Bram Cohen's patience diff algorithm.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HistogramDiff']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/HistogramDiff", DoNotGenerateAcw=true)]
	public partial class HistogramDiff : global::Org.Eclipse.Jgit.Diff.LowLevelDiffAlgorithm {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/HistogramDiff", typeof (HistogramDiff));

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

		protected HistogramDiff (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HistogramDiff']/constructor[@name='HistogramDiff' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HistogramDiff () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_diffNonCommon_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_HashedSequenceComparator_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_Edit_;
#pragma warning disable 0169
		static Delegate GetDiffNonCommon_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_HashedSequenceComparator_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_Edit_Handler ()
		{
			if (cb_diffNonCommon_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_HashedSequenceComparator_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_Edit_ == null)
				cb_diffNonCommon_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_HashedSequenceComparator_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_Edit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_DiffNonCommon_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_HashedSequenceComparator_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_Edit_);
			return cb_diffNonCommon_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_HashedSequenceComparator_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_Edit_;
		}

		static void n_DiffNonCommon_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_HashedSequenceComparator_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_Edit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_edits, IntPtr native_cmp, IntPtr native_a, IntPtr native_b, IntPtr native_region)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HistogramDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var edits = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.EditList> (native_edits, JniHandleOwnership.DoNotTransfer);
			var cmp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequenceComparator> (native_cmp, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequence> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequence> (native_b, JniHandleOwnership.DoNotTransfer);
			var region = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (native_region, JniHandleOwnership.DoNotTransfer);
			__this.DiffNonCommon (edits, cmp, a, b, region);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HistogramDiff']/method[@name='diffNonCommon' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.diff.EditList'] and parameter[2][@type='org.eclipse.jgit.diff.HashedSequenceComparator&lt;S&gt;'] and parameter[3][@type='org.eclipse.jgit.diff.HashedSequence&lt;S&gt;'] and parameter[4][@type='org.eclipse.jgit.diff.HashedSequence&lt;S&gt;'] and parameter[5][@type='org.eclipse.jgit.diff.Edit']]"
		[Register ("diffNonCommon", "(Lorg/eclipse/jgit/diff/EditList;Lorg/eclipse/jgit/diff/HashedSequenceComparator;Lorg/eclipse/jgit/diff/HashedSequence;Lorg/eclipse/jgit/diff/HashedSequence;Lorg/eclipse/jgit/diff/Edit;)V", "GetDiffNonCommon_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_HashedSequenceComparator_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_Edit_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public override unsafe void DiffNonCommon (global::Org.Eclipse.Jgit.Diff.EditList edits, global::Org.Eclipse.Jgit.Diff.HashedSequenceComparator cmp, global::Org.Eclipse.Jgit.Diff.HashedSequence a, global::Org.Eclipse.Jgit.Diff.HashedSequence b, global::Org.Eclipse.Jgit.Diff.Edit region)
		{
			const string __id = "diffNonCommon.(Lorg/eclipse/jgit/diff/EditList;Lorg/eclipse/jgit/diff/HashedSequenceComparator;Lorg/eclipse/jgit/diff/HashedSequence;Lorg/eclipse/jgit/diff/HashedSequence;Lorg/eclipse/jgit/diff/Edit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((edits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) edits).Handle);
				__args [1] = new JniArgumentValue ((cmp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmp).Handle);
				__args [2] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [3] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [4] = new JniArgumentValue ((region == null) ? IntPtr.Zero : ((global::Java.Lang.Object) region).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (edits);
				global::System.GC.KeepAlive (cmp);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
				global::System.GC.KeepAlive (region);
			}
		}

		static Delegate cb_setFallbackAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_;
#pragma warning disable 0169
		static Delegate GetSetFallbackAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_Handler ()
		{
			if (cb_setFallbackAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ == null)
				cb_setFallbackAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFallbackAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_);
			return cb_setFallbackAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_;
		}

		static void n_SetFallbackAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HistogramDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var alg = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm> (native_alg, JniHandleOwnership.DoNotTransfer);
			__this.SetFallbackAlgorithm (alg);
		}
#pragma warning restore 0169

		/// <param name="alg">the secondary algorithm. If null the region will be denoted as
		///            a single REPLACE block.</param>
		/// <summary>Set the algorithm used when there are too many element occurrences.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HistogramDiff']/method[@name='setFallbackAlgorithm' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffAlgorithm']]"
		[Register ("setFallbackAlgorithm", "(Lorg/eclipse/jgit/diff/DiffAlgorithm;)V", "GetSetFallbackAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_Handler")]
		public virtual unsafe void SetFallbackAlgorithm (global::Org.Eclipse.Jgit.Diff.DiffAlgorithm alg)
		{
			const string __id = "setFallbackAlgorithm.(Lorg/eclipse/jgit/diff/DiffAlgorithm;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (alg);
			}
		}

		static Delegate cb_setMaxChainLength_I;
#pragma warning disable 0169
		static Delegate GetSetMaxChainLength_IHandler ()
		{
			if (cb_setMaxChainLength_I == null)
				cb_setMaxChainLength_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxChainLength_I);
			return cb_setMaxChainLength_I;
		}

		static void n_SetMaxChainLength_I (IntPtr jnienv, IntPtr native__this, int maxLen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HistogramDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxChainLength (maxLen);
		}
#pragma warning restore 0169

		/// <param name="maxLen">new maximum length.</param>
		/// <summary>Maximum number of positions to consider for a given element hash.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HistogramDiff']/method[@name='setMaxChainLength' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxChainLength", "(I)V", "GetSetMaxChainLength_IHandler")]
		public virtual unsafe void SetMaxChainLength (int maxLen)
		{
			const string __id = "setMaxChainLength.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxLen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
