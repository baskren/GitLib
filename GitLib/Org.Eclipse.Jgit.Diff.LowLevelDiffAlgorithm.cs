using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>Compares two sequences primarily based upon hash codes.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='LowLevelDiffAlgorithm']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/LowLevelDiffAlgorithm", DoNotGenerateAcw=true)]
	public abstract partial class LowLevelDiffAlgorithm : global::Org.Eclipse.Jgit.Diff.DiffAlgorithm {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/LowLevelDiffAlgorithm", typeof (LowLevelDiffAlgorithm));

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

		protected LowLevelDiffAlgorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='LowLevelDiffAlgorithm']/constructor[@name='LowLevelDiffAlgorithm' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LowLevelDiffAlgorithm () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.LowLevelDiffAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var edits = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.EditList> (native_edits, JniHandleOwnership.DoNotTransfer);
			var cmp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequenceComparator> (native_cmp, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequence> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequence> (native_b, JniHandleOwnership.DoNotTransfer);
			var region = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (native_region, JniHandleOwnership.DoNotTransfer);
			__this.DiffNonCommon (edits, cmp, a, b, region);
		}
#pragma warning restore 0169

		/// <param name="&lt;S&gt;">type of sequence being compared.</param>
		/// <param name="edits">result list to append the region's edits onto.</param>
		/// <param name="cmp">the comparator supplying the element equivalence function.</param>
		/// <param name="a">the first (also known as old or pre-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'A' side: <c>Edit#getBeginA()</c>, <c>Edit#getEndA()</c>.</param>
		/// <param name="b">the second (also known as new or post-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'B' side: <c>Edit#getBeginB()</c>, <c>Edit#getEndB()</c>.</param>
		/// <param name="region">the region being compared within the two sequences.</param>
		/// <summary>Compare two sequences and identify a list of edits between them.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='LowLevelDiffAlgorithm']/method[@name='diffNonCommon' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.diff.EditList'] and parameter[2][@type='org.eclipse.jgit.diff.HashedSequenceComparator&lt;S&gt;'] and parameter[3][@type='org.eclipse.jgit.diff.HashedSequence&lt;S&gt;'] and parameter[4][@type='org.eclipse.jgit.diff.HashedSequence&lt;S&gt;'] and parameter[5][@type='org.eclipse.jgit.diff.Edit']]"
		[Register ("diffNonCommon", "(Lorg/eclipse/jgit/diff/EditList;Lorg/eclipse/jgit/diff/HashedSequenceComparator;Lorg/eclipse/jgit/diff/HashedSequence;Lorg/eclipse/jgit/diff/HashedSequence;Lorg/eclipse/jgit/diff/Edit;)V", "GetDiffNonCommon_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_HashedSequenceComparator_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_HashedSequence_Lorg_eclipse_jgit_diff_Edit_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public abstract void DiffNonCommon (global::Org.Eclipse.Jgit.Diff.EditList edits, global::Org.Eclipse.Jgit.Diff.HashedSequenceComparator cmp, global::Org.Eclipse.Jgit.Diff.HashedSequence a, global::Org.Eclipse.Jgit.Diff.HashedSequence b, global::Org.Eclipse.Jgit.Diff.Edit region);

		static Delegate cb_diffNonCommon_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_;
#pragma warning disable 0169
		static Delegate GetDiffNonCommon_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Handler ()
		{
			if (cb_diffNonCommon_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_ == null)
				cb_diffNonCommon_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_DiffNonCommon_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_);
			return cb_diffNonCommon_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_;
		}

		static IntPtr n_DiffNonCommon_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmp, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.LowLevelDiffAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.SequenceComparator> (native_cmp, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_b, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DiffNonCommon (cmp, a, b));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='LowLevelDiffAlgorithm']/method[@name='diffNonCommon' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.diff.SequenceComparator&lt;? super S&gt;'] and parameter[2][@type='S'] and parameter[3][@type='S']]"
		[Register ("diffNonCommon", "(Lorg/eclipse/jgit/diff/SequenceComparator;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;)Lorg/eclipse/jgit/diff/EditList;", "GetDiffNonCommon_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public override unsafe global::Org.Eclipse.Jgit.Diff.EditList DiffNonCommon (global::Org.Eclipse.Jgit.Diff.SequenceComparator cmp, global::Java.Lang.Object a, global::Java.Lang.Object b)
		{
			const string __id = "diffNonCommon.(Lorg/eclipse/jgit/diff/SequenceComparator;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;)Lorg/eclipse/jgit/diff/EditList;";
			IntPtr native_a = JNIEnv.ToLocalJniHandle (a);
			IntPtr native_b = JNIEnv.ToLocalJniHandle (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((cmp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmp).Handle);
				__args [1] = new JniArgumentValue (native_a);
				__args [2] = new JniArgumentValue (native_b);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.EditList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				JNIEnv.DeleteLocalRef (native_b);
				global::System.GC.KeepAlive (cmp);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/LowLevelDiffAlgorithm", DoNotGenerateAcw=true)]
	internal partial class LowLevelDiffAlgorithmInvoker : LowLevelDiffAlgorithm {
		public LowLevelDiffAlgorithmInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/LowLevelDiffAlgorithm", typeof (LowLevelDiffAlgorithmInvoker));

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

		/// <param name="&lt;S&gt;">type of sequence being compared.</param>
		/// <param name="edits">result list to append the region's edits onto.</param>
		/// <param name="cmp">the comparator supplying the element equivalence function.</param>
		/// <param name="a">the first (also known as old or pre-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'A' side: <c>Edit#getBeginA()</c>, <c>Edit#getEndA()</c>.</param>
		/// <param name="b">the second (also known as new or post-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'B' side: <c>Edit#getBeginB()</c>, <c>Edit#getEndB()</c>.</param>
		/// <param name="region">the region being compared within the two sequences.</param>
		/// <summary>Compare two sequences and identify a list of edits between them.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='LowLevelDiffAlgorithm']/method[@name='diffNonCommon' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.diff.EditList'] and parameter[2][@type='org.eclipse.jgit.diff.HashedSequenceComparator&lt;S&gt;'] and parameter[3][@type='org.eclipse.jgit.diff.HashedSequence&lt;S&gt;'] and parameter[4][@type='org.eclipse.jgit.diff.HashedSequence&lt;S&gt;'] and parameter[5][@type='org.eclipse.jgit.diff.Edit']]"
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
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (edits);
				global::System.GC.KeepAlive (cmp);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
				global::System.GC.KeepAlive (region);
			}
		}

	}
}
