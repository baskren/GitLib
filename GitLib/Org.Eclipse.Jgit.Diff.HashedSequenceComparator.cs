using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <param name="&lt;S&gt;">the base sequence type.</param>
	/// <summary>Wrap another comparator for use with <c>HashedSequence</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequenceComparator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/HashedSequenceComparator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
	public sealed partial class HashedSequenceComparator : global::Org.Eclipse.Jgit.Diff.SequenceComparator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/HashedSequenceComparator", typeof (HashedSequenceComparator));

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

		internal HashedSequenceComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequenceComparator']/method[@name='equals' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.diff.HashedSequence&lt;S&gt;'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.jgit.diff.HashedSequence&lt;S&gt;'] and parameter[4][@type='int']]"
		[Register ("equals", "(Lorg/eclipse/jgit/diff/HashedSequence;ILorg/eclipse/jgit/diff/HashedSequence;I)Z", "")]
		public unsafe bool Equals (global::Org.Eclipse.Jgit.Diff.HashedSequence a, int ai, global::Org.Eclipse.Jgit.Diff.HashedSequence b, int bi)
		{
			const string __id = "equals.(Lorg/eclipse/jgit/diff/HashedSequence;ILorg/eclipse/jgit/diff/HashedSequence;I)Z";
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

        public override bool Equals(Java.Lang.Object a, int ai, Java.Lang.Object b, int bi)
            => Equals((global::Org.Eclipse.Jgit.Diff.HashedSequence)a, ai, (global::Org.Eclipse.Jgit.Diff.HashedSequence)b, bi);


		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequenceComparator']/method[@name='hash' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.HashedSequence&lt;S&gt;'] and parameter[2][@type='int']]"
		[Register ("hash", "(Lorg/eclipse/jgit/diff/HashedSequence;I)I", "")]
		public unsafe int Hash (global::Org.Eclipse.Jgit.Diff.HashedSequence seq, int ptr)
		{
			const string __id = "hash.(Lorg/eclipse/jgit/diff/HashedSequence;I)I";
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

        public override int Hash(Java.Lang.Object seq, int ptr)
            => Hash((global::Org.Eclipse.Jgit.Diff.HashedSequence)seq, ptr);

    }
}
