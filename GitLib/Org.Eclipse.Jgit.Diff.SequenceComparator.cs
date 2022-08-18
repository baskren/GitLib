using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <param name="&lt;S&gt;">type of sequence the comparator supports.</param>
	/// <summary>Equivalence function for a <c>Sequence</c> compared by difference algorithm.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SequenceComparator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/SequenceComparator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
	public abstract partial class SequenceComparator : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/SequenceComparator", typeof (SequenceComparator));

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

		protected SequenceComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SequenceComparator']/constructor[@name='SequenceComparator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SequenceComparator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_equals_Lorg_eclipse_jgit_diff_Sequence_ILorg_eclipse_jgit_diff_Sequence_I;
#pragma warning disable 0169
		static Delegate GetEquals_Lorg_eclipse_jgit_diff_Sequence_ILorg_eclipse_jgit_diff_Sequence_IHandler ()
		{
			if (cb_equals_Lorg_eclipse_jgit_diff_Sequence_ILorg_eclipse_jgit_diff_Sequence_I == null)
				cb_equals_Lorg_eclipse_jgit_diff_Sequence_ILorg_eclipse_jgit_diff_Sequence_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILI_Z) n_Equals_Lorg_eclipse_jgit_diff_Sequence_ILorg_eclipse_jgit_diff_Sequence_I);
			return cb_equals_Lorg_eclipse_jgit_diff_Sequence_ILorg_eclipse_jgit_diff_Sequence_I;
		}

		static bool n_Equals_Lorg_eclipse_jgit_diff_Sequence_ILorg_eclipse_jgit_diff_Sequence_I (IntPtr jnienv, IntPtr native__this, IntPtr native_a, int ai, IntPtr native_b, int bi)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.SequenceComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_b, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (a, ai, b, bi);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="a">the first sequence.</param>
		/// <param name="ai">item of <c>ai</c> to compare.</param>
		/// <param name="b">the second sequence.</param>
		/// <param name="bi">item of <c>bi</c> to compare.</param>
		/// <summary>Compare two items to determine if they are equivalent.</summary>
		/// <returns>true if the two items are identical according to this function's
		///         equivalence rule.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SequenceComparator']/method[@name='equals' and count(parameter)=4 and parameter[1][@type='S'] and parameter[2][@type='int'] and parameter[3][@type='S'] and parameter[4][@type='int']]"
		[Register ("equals", "(Lorg/eclipse/jgit/diff/Sequence;ILorg/eclipse/jgit/diff/Sequence;I)Z", "GetEquals_Lorg_eclipse_jgit_diff_Sequence_ILorg_eclipse_jgit_diff_Sequence_IHandler")]
		public abstract bool Equals (global::Java.Lang.Object a, int ai, global::Java.Lang.Object b, int bi);

		static Delegate cb_hash_Lorg_eclipse_jgit_diff_Sequence_I;
#pragma warning disable 0169
		static Delegate GetHash_Lorg_eclipse_jgit_diff_Sequence_IHandler ()
		{
			if (cb_hash_Lorg_eclipse_jgit_diff_Sequence_I == null)
				cb_hash_Lorg_eclipse_jgit_diff_Sequence_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_Hash_Lorg_eclipse_jgit_diff_Sequence_I);
			return cb_hash_Lorg_eclipse_jgit_diff_Sequence_I;
		}

		static int n_Hash_Lorg_eclipse_jgit_diff_Sequence_I (IntPtr jnienv, IntPtr native__this, IntPtr native_seq, int ptr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.SequenceComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var seq = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_seq, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Hash (seq, ptr);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="seq">the sequence.</param>
		/// <param name="ptr">the item to obtain the hash for.</param>
		/// <summary>Get a hash value for an item in a sequence.</summary>
		/// <returns>hash the hash value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SequenceComparator']/method[@name='hash' and count(parameter)=2 and parameter[1][@type='S'] and parameter[2][@type='int']]"
		[Register ("hash", "(Lorg/eclipse/jgit/diff/Sequence;I)I", "GetHash_Lorg_eclipse_jgit_diff_Sequence_IHandler")]
		public abstract int Hash (global::Java.Lang.Object seq, int ptr);

		static Delegate cb_reduceCommonStartEnd_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Edit_;
#pragma warning disable 0169
		static Delegate GetReduceCommonStartEnd_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Edit_Handler ()
		{
			if (cb_reduceCommonStartEnd_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Edit_ == null)
				cb_reduceCommonStartEnd_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Edit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_ReduceCommonStartEnd_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Edit_);
			return cb_reduceCommonStartEnd_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Edit_;
		}

		static IntPtr n_ReduceCommonStartEnd_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Edit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.SequenceComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_b, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReduceCommonStartEnd (a, b, e));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="a">the first sequence.</param>
		/// <param name="b">the second sequence.</param>
		/// <param name="e">the edit to start with and update.</param>
		/// <summary>Modify the edit to remove common leading and trailing items.</summary>
		/// <returns>
		///   <c>e</c> if it was updated in-place, otherwise a new edit
		///         containing the reduced region.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SequenceComparator']/method[@name='reduceCommonStartEnd' and count(parameter)=3 and parameter[1][@type='S'] and parameter[2][@type='S'] and parameter[3][@type='org.eclipse.jgit.diff.Edit']]"
		[Register ("reduceCommonStartEnd", "(Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Edit;", "GetReduceCommonStartEnd_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Edit_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.Edit ReduceCommonStartEnd (global::Java.Lang.Object a, global::Java.Lang.Object b, global::Org.Eclipse.Jgit.Diff.Edit e)
		{
			const string __id = "reduceCommonStartEnd.(Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Edit;";
			IntPtr native_a = JNIEnv.ToLocalJniHandle (a);
			IntPtr native_b = JNIEnv.ToLocalJniHandle (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_a);
				__args [1] = new JniArgumentValue (native_b);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				JNIEnv.DeleteLocalRef (native_b);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
				global::System.GC.KeepAlive (e);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/SequenceComparator", DoNotGenerateAcw=true)]
	internal partial class SequenceComparatorInvoker : SequenceComparator {
		public SequenceComparatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/SequenceComparator", typeof (SequenceComparatorInvoker));

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

		/// <param name="a">the first sequence.</param>
		/// <param name="ai">item of <c>ai</c> to compare.</param>
		/// <param name="b">the second sequence.</param>
		/// <param name="bi">item of <c>bi</c> to compare.</param>
		/// <summary>Compare two items to determine if they are equivalent.</summary>
		/// <returns>true if the two items are identical according to this function's
		///         equivalence rule.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SequenceComparator']/method[@name='equals' and count(parameter)=4 and parameter[1][@type='S'] and parameter[2][@type='int'] and parameter[3][@type='S'] and parameter[4][@type='int']]"
		[Register ("equals", "(Lorg/eclipse/jgit/diff/Sequence;ILorg/eclipse/jgit/diff/Sequence;I)Z", "GetEquals_Lorg_eclipse_jgit_diff_Sequence_ILorg_eclipse_jgit_diff_Sequence_IHandler")]
		public override unsafe bool Equals (global::Java.Lang.Object a, int ai, global::Java.Lang.Object b, int bi)
		{
			const string __id = "equals.(Lorg/eclipse/jgit/diff/Sequence;ILorg/eclipse/jgit/diff/Sequence;I)Z";
			IntPtr native_a = JNIEnv.ToLocalJniHandle (a);
			IntPtr native_b = JNIEnv.ToLocalJniHandle (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_a);
				__args [1] = new JniArgumentValue (ai);
				__args [2] = new JniArgumentValue (native_b);
				__args [3] = new JniArgumentValue (bi);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				JNIEnv.DeleteLocalRef (native_b);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="seq">the sequence.</param>
		/// <param name="ptr">the item to obtain the hash for.</param>
		/// <summary>Get a hash value for an item in a sequence.</summary>
		/// <returns>hash the hash value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='SequenceComparator']/method[@name='hash' and count(parameter)=2 and parameter[1][@type='S'] and parameter[2][@type='int']]"
		[Register ("hash", "(Lorg/eclipse/jgit/diff/Sequence;I)I", "GetHash_Lorg_eclipse_jgit_diff_Sequence_IHandler")]
		public override unsafe int Hash (global::Java.Lang.Object seq, int ptr)
		{
			const string __id = "hash.(Lorg/eclipse/jgit/diff/Sequence;I)I";
			IntPtr native_seq = JNIEnv.ToLocalJniHandle (seq);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_seq);
				__args [1] = new JniArgumentValue (ptr);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
				global::System.GC.KeepAlive (seq);
			}
		}

	}
}
