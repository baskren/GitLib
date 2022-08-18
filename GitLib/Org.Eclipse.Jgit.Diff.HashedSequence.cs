using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <param name="&lt;S&gt;">the base sequence type.</param>
	/// <summary>Wraps a <c>Sequence</c> to assign hash codes to elements.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequence']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/HashedSequence", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
	public sealed partial class HashedSequence : global::Org.Eclipse.Jgit.Diff.Sequence {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/HashedSequence", typeof (HashedSequence));

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

		internal HashedSequence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequence']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public override unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
