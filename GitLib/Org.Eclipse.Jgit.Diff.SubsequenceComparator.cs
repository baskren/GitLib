using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <param name="&lt;S&gt;">the base sequence type.</param>
	/// <summary>Wrap another comparator for use with <c>Subsequence</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SubsequenceComparator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/SubsequenceComparator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
	public sealed partial class SubsequenceComparator : global::Org.Eclipse.Jgit.Diff.SequenceComparator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/SubsequenceComparator", typeof (SubsequenceComparator));

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

		internal SubsequenceComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="cmp">the real comparator.</param>
		/// <summary>Construct a comparator wrapping another comparator.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SubsequenceComparator']/constructor[@name='SubsequenceComparator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.SequenceComparator&lt;? super S&gt;']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/diff/SequenceComparator;)V", "")]
		public unsafe SubsequenceComparator (global::Org.Eclipse.Jgit.Diff.SequenceComparator cmp) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/diff/SequenceComparator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cmp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmp).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cmp);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SubsequenceComparator']/method[@name='equals' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.diff.Subsequence&lt;S&gt;'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.jgit.diff.Subsequence&lt;S&gt;'] and parameter[4][@type='int']]"
		[Register ("equals", "(Lorg/eclipse/jgit/diff/Subsequence;ILorg/eclipse/jgit/diff/Subsequence;I)Z", "")]
		public unsafe bool Equals (global::Org.Eclipse.Jgit.Diff.Subsequence a, int ai, global::Org.Eclipse.Jgit.Diff.Subsequence b, int bi)
		{
			const string __id = "equals.(Lorg/eclipse/jgit/diff/Subsequence;ILorg/eclipse/jgit/diff/Subsequence;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue (ai);
				__args [2] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [3] = new JniArgumentValue (bi);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SubsequenceComparator']/method[@name='hash' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.Subsequence&lt;S&gt;'] and parameter[2][@type='int']]"
		[Register ("hash", "(Lorg/eclipse/jgit/diff/Subsequence;I)I", "")]
		public unsafe int Hash (global::Org.Eclipse.Jgit.Diff.Subsequence seq, int ptr)
		{
			const string __id = "hash.(Lorg/eclipse/jgit/diff/Subsequence;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((seq == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seq).Handle);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (seq);
			}
		}

        public override bool Equals(Java.Lang.Object a, int ai, Java.Lang.Object b, int bi)
        {
			return Equals((Subsequence)a, ai, (Subsequence)b, bi);
        }

        public override int Hash(Java.Lang.Object seq, int ptr)
        {
			return Hash((Subsequence)seq, ptr);
        }
    }
}
