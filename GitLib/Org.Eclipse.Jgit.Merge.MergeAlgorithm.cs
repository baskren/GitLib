using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>Provides the merge algorithm which does a three-way merge on content provided
	/// as RawText.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeAlgorithm']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/MergeAlgorithm", DoNotGenerateAcw=true)]
	public sealed partial class MergeAlgorithm : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/MergeAlgorithm", typeof (MergeAlgorithm));

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

		internal MergeAlgorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Creates a new MergeAlgorithm which uses <c>HistogramDiff</c> as diff
		/// algorithm</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeAlgorithm']/constructor[@name='MergeAlgorithm' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MergeAlgorithm () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="diff">the diff algorithm used by this merge</param>
		/// <summary>Creates a new MergeAlgorithm</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeAlgorithm']/constructor[@name='MergeAlgorithm' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffAlgorithm']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/diff/DiffAlgorithm;)V", "")]
		public unsafe MergeAlgorithm (global::Org.Eclipse.Jgit.Diff.DiffAlgorithm diff) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/diff/DiffAlgorithm;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((diff == null) ? IntPtr.Zero : ((global::Java.Lang.Object) diff).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (diff);
			}
		}

		/// <param name="&lt;S&gt;">type of sequence.</param>
		/// <param name="cmp">comparison method for this execution.</param>
		/// <param name="base">the common base sequence</param>
		/// <param name="ours">the first sequence to be merged</param>
		/// <param name="theirs">the second sequence to be merged</param>
		/// <summary>Does the three way merge between a common base and two sequences.</summary>
		/// <returns>the resulting content</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeAlgorithm']/method[@name='merge' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.diff.SequenceComparator&lt;S&gt;'] and parameter[2][@type='S'] and parameter[3][@type='S'] and parameter[4][@type='S']]"
		[Register ("merge", "(Lorg/eclipse/jgit/diff/SequenceComparator;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;)Lorg/eclipse/jgit/merge/MergeResult;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public unsafe global::Org.Eclipse.Jgit.Merge.MergeResult Merge (global::Org.Eclipse.Jgit.Diff.SequenceComparator cmp, global::Java.Lang.Object @base, global::Java.Lang.Object ours, global::Java.Lang.Object theirs)
		{
			const string __id = "merge.(Lorg/eclipse/jgit/diff/SequenceComparator;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;)Lorg/eclipse/jgit/merge/MergeResult;";
			IntPtr native__base = JNIEnv.ToLocalJniHandle (@base);
			IntPtr native_ours = JNIEnv.ToLocalJniHandle (ours);
			IntPtr native_theirs = JNIEnv.ToLocalJniHandle (theirs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((cmp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmp).Handle);
				__args [1] = new JniArgumentValue (native__base);
				__args [2] = new JniArgumentValue (native_ours);
				__args [3] = new JniArgumentValue (native_theirs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__base);
				JNIEnv.DeleteLocalRef (native_ours);
				JNIEnv.DeleteLocalRef (native_theirs);
				global::System.GC.KeepAlive (cmp);
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (ours);
				global::System.GC.KeepAlive (theirs);
			}
		}

	}
}
