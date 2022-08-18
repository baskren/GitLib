using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>Compares two <c>Sequence</c>s to create an <c>EditList</c> of changes.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/DiffAlgorithm", DoNotGenerateAcw=true)]
	public abstract partial class DiffAlgorithm : global::Java.Lang.Object {
		/// <summary>Supported diff algorithm</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm.SupportedAlgorithm']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm", DoNotGenerateAcw=true)]
		public sealed partial class SupportedAlgorithm : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm.SupportedAlgorithm']/field[@name='HISTOGRAM']"
			[Register ("HISTOGRAM")]
			public static global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm Histogram {
				get {
					const string __id = "HISTOGRAM.Lorg/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm.SupportedAlgorithm']/field[@name='MYERS']"
			[Register ("MYERS")]
			public static global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm Myers {
				get {
					const string __id = "MYERS.Lorg/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm", typeof (SupportedAlgorithm));

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

			internal SupportedAlgorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm.SupportedAlgorithm']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm.SupportedAlgorithm']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/DiffAlgorithm", typeof (DiffAlgorithm));

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

		protected DiffAlgorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm']/constructor[@name='DiffAlgorithm' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DiffAlgorithm () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_diff_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_;
#pragma warning disable 0169
		static Delegate GetDiff_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Handler ()
		{
			if (cb_diff_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_ == null)
				cb_diff_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Diff_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_);
			return cb_diff_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_;
		}

		static IntPtr n_Diff_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmp, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.SequenceComparator> (native_cmp, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_b, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Diff (cmp, a, b));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="&lt;S&gt;">type of sequence being compared.</param>
		/// <param name="cmp">the comparator supplying the element equivalence function.</param>
		/// <param name="a">the first (also known as old or pre-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'A' side: <c>Edit#getBeginA()</c>, <c>Edit#getEndA()</c>.</param>
		/// <param name="b">the second (also known as new or post-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'B' side: <c>Edit#getBeginB()</c>, <c>Edit#getEndB()</c>.</param>
		/// <summary>Compare two sequences and identify a list of edits between them.</summary>
		/// <returns>a modifiable edit list comparing the two sequences. If empty, the
		///         sequences are identical according to <c>cmp</c>'s rules. The
		///         result list is never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm']/method[@name='diff' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.diff.SequenceComparator&lt;? super S&gt;'] and parameter[2][@type='S'] and parameter[3][@type='S']]"
		[Register ("diff", "(Lorg/eclipse/jgit/diff/SequenceComparator;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;)Lorg/eclipse/jgit/diff/EditList;", "GetDiff_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.EditList Diff (global::Org.Eclipse.Jgit.Diff.SequenceComparator cmp, global::Java.Lang.Object a, global::Java.Lang.Object b)
		{
			const string __id = "diff.(Lorg/eclipse/jgit/diff/SequenceComparator;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;)Lorg/eclipse/jgit/diff/EditList;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.SequenceComparator> (native_cmp, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_b, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DiffNonCommon (cmp, a, b));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="&lt;S&gt;">type of sequence being compared.</param>
		/// <param name="cmp">the comparator supplying the element equivalence function.</param>
		/// <param name="a">the first (also known as old or pre-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'A' side: <c>Edit#getBeginA()</c>, <c>Edit#getEndA()</c>.</param>
		/// <param name="b">the second (also known as new or post-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'B' side: <c>Edit#getBeginB()</c>, <c>Edit#getEndB()</c>.</param>
		/// <summary>Compare two sequences and identify a list of edits between them.</summary>
		/// <returns>a modifiable edit list comparing the two sequences.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm']/method[@name='diffNonCommon' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.diff.SequenceComparator&lt;? super S&gt;'] and parameter[2][@type='S'] and parameter[3][@type='S']]"
		[Register ("diffNonCommon", "(Lorg/eclipse/jgit/diff/SequenceComparator;Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Sequence;)Lorg/eclipse/jgit/diff/EditList;", "GetDiffNonCommon_Lorg_eclipse_jgit_diff_SequenceComparator_Lorg_eclipse_jgit_diff_Sequence_Lorg_eclipse_jgit_diff_Sequence_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public abstract global::Org.Eclipse.Jgit.Diff.EditList DiffNonCommon (global::Org.Eclipse.Jgit.Diff.SequenceComparator cmp, global::Java.Lang.Object a, global::Java.Lang.Object b);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm']/method[@name='getAlgorithm' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffAlgorithm.SupportedAlgorithm']]"
		[Register ("getAlgorithm", "(Lorg/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm;)Lorg/eclipse/jgit/diff/DiffAlgorithm;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Diff.DiffAlgorithm GetAlgorithm (global::Org.Eclipse.Jgit.Diff.DiffAlgorithm.SupportedAlgorithm alg)
		{
			const string __id = "getAlgorithm.(Lorg/eclipse/jgit/diff/DiffAlgorithm$SupportedAlgorithm;)Lorg/eclipse/jgit/diff/DiffAlgorithm;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alg).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (alg);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/DiffAlgorithm", DoNotGenerateAcw=true)]
	internal partial class DiffAlgorithmInvoker : DiffAlgorithm {
		public DiffAlgorithmInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/DiffAlgorithm", typeof (DiffAlgorithmInvoker));

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
		/// <param name="cmp">the comparator supplying the element equivalence function.</param>
		/// <param name="a">the first (also known as old or pre-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'A' side: <c>Edit#getBeginA()</c>, <c>Edit#getEndA()</c>.</param>
		/// <param name="b">the second (also known as new or post-image) sequence. Edits
		///            returned by this algorithm will reference indexes using the
		///            'B' side: <c>Edit#getBeginB()</c>, <c>Edit#getEndB()</c>.</param>
		/// <summary>Compare two sequences and identify a list of edits between them.</summary>
		/// <returns>a modifiable edit list comparing the two sequences.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffAlgorithm']/method[@name='diffNonCommon' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.diff.SequenceComparator&lt;? super S&gt;'] and parameter[2][@type='S'] and parameter[3][@type='S']]"
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
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
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
}
