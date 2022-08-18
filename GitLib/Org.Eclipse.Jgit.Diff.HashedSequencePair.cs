using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <param name="&lt;S&gt;">the base sequence type.</param>
	/// <summary>Wraps two <c>Sequence</c> instances to cache their element hash codes.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequencePair']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/HashedSequencePair", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
	public partial class HashedSequencePair : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/HashedSequencePair", typeof (HashedSequencePair));

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

		protected HashedSequencePair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="cmp">the base comparator for the sequence elements.</param>
		/// <param name="a">the A sequence.</param>
		/// <param name="b">the B sequence.</param>
		/// <summary>Construct a pair to provide fast hash codes.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequencePair']/constructor[@name='HashedSequencePair' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.diff.SequenceComparator&lt;? super S&gt;'] and parameter[2][@type='S'] and parameter[3][@type='S']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/diff/SequenceComparator;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;)V", "")]
		public unsafe HashedSequencePair (global::Org.Eclipse.Jgit.Diff.SequenceComparator cmp, global::Java.Lang.Object a, global::Java.Lang.Object b) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/diff/SequenceComparator;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_a = JNIEnv.ToLocalJniHandle (a);
			IntPtr native_b = JNIEnv.ToLocalJniHandle (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((cmp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmp).Handle);
				__args [1] = new JniArgumentValue (native_a);
				__args [2] = new JniArgumentValue (native_b);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				JNIEnv.DeleteLocalRef (native_b);
				global::System.GC.KeepAlive (cmp);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_getComparator;
#pragma warning disable 0169
		static Delegate GetGetComparatorHandler ()
		{
			if (cb_getComparator == null)
				cb_getComparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetComparator);
			return cb_getComparator;
		}

		static IntPtr n_GetComparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequencePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Comparator);
		}
#pragma warning restore 0169

		/// <returns>obtain a comparator that uses the cached hash codes.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.HashedSequenceComparator Comparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequencePair']/method[@name='getComparator' and count(parameter)=0]"
			[Register ("getComparator", "()Lorg/eclipse/jgit/diff/HashedSequenceComparator;", "GetGetComparatorHandler")]
			get {
				const string __id = "getComparator.()Lorg/eclipse/jgit/diff/HashedSequenceComparator;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequenceComparator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getA;
#pragma warning disable 0169
		static Delegate GetGetAHandler ()
		{
			if (cb_getA == null)
				cb_getA = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetA);
			return cb_getA;
		}

		static IntPtr n_GetA (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequencePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetA ());
		}
#pragma warning restore 0169

		/// <returns>wrapper around A that includes cached hash codes.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequencePair']/method[@name='getA' and count(parameter)=0]"
		[Register ("getA", "()Lorg/eclipse/jgit/diff/HashedSequence;", "GetGetAHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.HashedSequence GetA ()
		{
			const string __id = "getA.()Lorg/eclipse/jgit/diff/HashedSequence;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getB;
#pragma warning disable 0169
		static Delegate GetGetBHandler ()
		{
			if (cb_getB == null)
				cb_getB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetB);
			return cb_getB;
		}

		static IntPtr n_GetB (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequencePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetB ());
		}
#pragma warning restore 0169

		/// <returns>wrapper around B that includes cached hash codes.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='HashedSequencePair']/method[@name='getB' and count(parameter)=0]"
		[Register ("getB", "()Lorg/eclipse/jgit/diff/HashedSequence;", "GetGetBHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.HashedSequence GetB ()
		{
			const string __id = "getB.()Lorg/eclipse/jgit/diff/HashedSequence;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
