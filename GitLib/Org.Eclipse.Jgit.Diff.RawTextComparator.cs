using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>Equivalence function for <c>RawText</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/RawTextComparator", DoNotGenerateAcw=true)]
	public abstract partial class RawTextComparator : global::Org.Eclipse.Jgit.Diff.SequenceComparator {

		/// <summary>No special treatment.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Org.Eclipse.Jgit.Diff.RawTextComparator Default {
			get {
				const string __id = "DEFAULT.Lorg/eclipse/jgit/diff/RawTextComparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Ignores all whitespace.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/field[@name='WS_IGNORE_ALL']"
		[Register ("WS_IGNORE_ALL")]
		public static global::Org.Eclipse.Jgit.Diff.RawTextComparator WsIgnoreAll {
			get {
				const string __id = "WS_IGNORE_ALL.Lorg/eclipse/jgit/diff/RawTextComparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Ignores whitespace occurring between non-whitespace characters.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/field[@name='WS_IGNORE_CHANGE']"
		[Register ("WS_IGNORE_CHANGE")]
		public static global::Org.Eclipse.Jgit.Diff.RawTextComparator WsIgnoreChange {
			get {
				const string __id = "WS_IGNORE_CHANGE.Lorg/eclipse/jgit/diff/RawTextComparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Ignores leading whitespace.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/field[@name='WS_IGNORE_LEADING']"
		[Register ("WS_IGNORE_LEADING")]
		public static global::Org.Eclipse.Jgit.Diff.RawTextComparator WsIgnoreLeading {
			get {
				const string __id = "WS_IGNORE_LEADING.Lorg/eclipse/jgit/diff/RawTextComparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Ignores trailing whitespace.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/field[@name='WS_IGNORE_TRAILING']"
		[Register ("WS_IGNORE_TRAILING")]
		public static global::Org.Eclipse.Jgit.Diff.RawTextComparator WsIgnoreTrailing {
			get {
				const string __id = "WS_IGNORE_TRAILING.Lorg/eclipse/jgit/diff/RawTextComparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/RawTextComparator", typeof (RawTextComparator));

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

		protected RawTextComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/constructor[@name='RawTextComparator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RawTextComparator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_hash_Lorg_eclipse_jgit_diff_RawText_I;
#pragma warning disable 0169
		static Delegate GetHash_Lorg_eclipse_jgit_diff_RawText_IHandler ()
		{
			if (cb_hash_Lorg_eclipse_jgit_diff_RawText_I == null)
				cb_hash_Lorg_eclipse_jgit_diff_RawText_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_Hash_Lorg_eclipse_jgit_diff_RawText_I);
			return cb_hash_Lorg_eclipse_jgit_diff_RawText_I;
		}

		static int n_Hash_Lorg_eclipse_jgit_diff_RawText_I (IntPtr jnienv, IntPtr native__this, IntPtr native_seq, int lno)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var seq = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_seq, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Hash (seq, lno);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/method[@name='hash' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.RawText'] and parameter[2][@type='int']]"
		[Register ("hash", "(Lorg/eclipse/jgit/diff/RawText;I)I", "GetHash_Lorg_eclipse_jgit_diff_RawText_IHandler")]
		public virtual unsafe int Hash (global::Org.Eclipse.Jgit.Diff.RawText seq, int lno)
		{
			const string __id = "hash.(Lorg/eclipse/jgit/diff/RawText;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((seq == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seq).Handle);
				__args [1] = new JniArgumentValue (lno);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (seq);
			}
		}

		static Delegate cb_hashRegion_arrayBII;
#pragma warning disable 0169
		static Delegate GetHashRegion_arrayBIIHandler ()
		{
			if (cb_hashRegion_arrayBII == null)
				cb_hashRegion_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_HashRegion_arrayBII);
			return cb_hashRegion_arrayBII;
		}

		static int n_HashRegion_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_raw, int ptr, int end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.HashRegion (raw, ptr, end);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="raw">the raw file content.</param>
		/// <param name="ptr">first byte of the region to hash.</param>
		/// <param name="end">1 past the last byte of the region.</param>
		/// <summary>Compute a hash code for a region.</summary>
		/// <returns>hash code for the region &lt;code&gt;[ptr, end)&lt;/code&gt; of raw.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/method[@name='hashRegion' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("hashRegion", "([BII)I", "GetHashRegion_arrayBIIHandler")]
		protected abstract int HashRegion (byte[] raw, int ptr, int end);

		static Delegate cb_reduceCommonStartEnd_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_Edit_;
#pragma warning disable 0169
		static Delegate GetReduceCommonStartEnd_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_Edit_Handler ()
		{
			if (cb_reduceCommonStartEnd_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_Edit_ == null)
				cb_reduceCommonStartEnd_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_Edit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_ReduceCommonStartEnd_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_Edit_);
			return cb_reduceCommonStartEnd_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_Edit_;
		}

		static IntPtr n_ReduceCommonStartEnd_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_Edit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_b, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReduceCommonStartEnd (a, b, e));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/method[@name='reduceCommonStartEnd' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.diff.RawText'] and parameter[2][@type='org.eclipse.jgit.diff.RawText'] and parameter[3][@type='org.eclipse.jgit.diff.Edit']]"
		[Register ("reduceCommonStartEnd", "(Lorg/eclipse/jgit/diff/RawText;Lorg/eclipse/jgit/diff/RawText;Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Edit;", "GetReduceCommonStartEnd_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_Edit_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.Edit ReduceCommonStartEnd (global::Org.Eclipse.Jgit.Diff.RawText a, global::Org.Eclipse.Jgit.Diff.RawText b, global::Org.Eclipse.Jgit.Diff.Edit e)
		{
			const string __id = "reduceCommonStartEnd.(Lorg/eclipse/jgit/diff/RawText;Lorg/eclipse/jgit/diff/RawText;Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Edit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
				global::System.GC.KeepAlive (e);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/RawTextComparator", DoNotGenerateAcw=true)]
	internal partial class RawTextComparatorInvoker : RawTextComparator {
		public RawTextComparatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/RawTextComparator", typeof (RawTextComparatorInvoker));

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

		/// <param name="raw">the raw file content.</param>
		/// <param name="ptr">first byte of the region to hash.</param>
		/// <param name="end">1 past the last byte of the region.</param>
		/// <summary>Compute a hash code for a region.</summary>
		/// <returns>hash code for the region &lt;code&gt;[ptr, end)&lt;/code&gt; of raw.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RawTextComparator']/method[@name='hashRegion' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("hashRegion", "([BII)I", "GetHashRegion_arrayBIIHandler")]
		protected override unsafe int HashRegion (byte[] raw, int ptr, int end)
		{
			const string __id = "hashRegion.([BII)I";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
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
