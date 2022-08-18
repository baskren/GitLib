using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <param name="&lt;S&gt;">type of sequence.</param>
	/// <summary>The result of merging a number of <c>Sequence</c> objects.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/MergeResult", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
	public partial class MergeResult : global::Java.Lang.Object, global::Java.Lang.IIterable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/MergeResult", typeof (MergeResult));

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

		protected MergeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="sequences">contains the common predecessor sequence at position 0
		///            followed by the merged sequences. This list should not be
		///            modified anymore during the lifetime of this <c>MergeResult</c>.</param>
		/// <summary>Creates a new empty MergeResult</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeResult']/constructor[@name='MergeResult' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;S&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe MergeResult (global::System.Collections.IList sequences) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sequences = global::Android.Runtime.JavaList.ToLocalJniHandle (sequences);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sequences);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sequences);
				global::System.GC.KeepAlive (sequences);
			}
		}

		static Delegate cb_getSequences;
#pragma warning disable 0169
		static Delegate GetGetSequencesHandler ()
		{
			if (cb_getSequences == null)
				cb_getSequences = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSequences);
			return cb_getSequences;
		}

		static IntPtr n_GetSequences (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Sequences);
		}
#pragma warning restore 0169

		/// <summary>Returns the common predecessor sequence and the merged sequence in one
		/// list.</summary>
		/// <returns>the common predecessor at position 0 followed by the merged
		///         sequences.</returns>
		public virtual unsafe global::System.Collections.IList Sequences {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeResult']/method[@name='getSequences' and count(parameter)=0]"
			[Register ("getSequences", "()Ljava/util/List;", "GetGetSequencesHandler")]
			get {
				const string __id = "getSequences.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_IIILorg_eclipse_jgit_merge_MergeChunk_ConflictState_;
#pragma warning disable 0169
		static Delegate GetAdd_IIILorg_eclipse_jgit_merge_MergeChunk_ConflictState_Handler ()
		{
			if (cb_add_IIILorg_eclipse_jgit_merge_MergeChunk_ConflictState_ == null)
				cb_add_IIILorg_eclipse_jgit_merge_MergeChunk_ConflictState_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_Add_IIILorg_eclipse_jgit_merge_MergeChunk_ConflictState_);
			return cb_add_IIILorg_eclipse_jgit_merge_MergeChunk_ConflictState_;
		}

		static void n_Add_IIILorg_eclipse_jgit_merge_MergeChunk_ConflictState_ (IntPtr jnienv, IntPtr native__this, int srcIdx, int begin, int end, IntPtr native_conflictState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var conflictState = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState> (native_conflictState, JniHandleOwnership.DoNotTransfer);
			__this.Add (srcIdx, begin, end, conflictState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeResult']/method[@name='add' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.eclipse.jgit.merge.MergeChunk.ConflictState']]"
		[Register ("add", "(IIILorg/eclipse/jgit/merge/MergeChunk$ConflictState;)V", "GetAdd_IIILorg_eclipse_jgit_merge_MergeChunk_ConflictState_Handler")]
		public virtual unsafe void Add (int srcIdx, int begin, int end, global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState conflictState)
		{
			const string __id = "add.(IIILorg/eclipse/jgit/merge/MergeChunk$ConflictState;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (srcIdx);
				__args [1] = new JniArgumentValue (begin);
				__args [2] = new JniArgumentValue (end);
				__args [3] = new JniArgumentValue ((conflictState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conflictState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (conflictState);
			}
		}

		static Delegate cb_containsConflicts;
#pragma warning disable 0169
		static Delegate GetContainsConflictsHandler ()
		{
			if (cb_containsConflicts == null)
				cb_containsConflicts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ContainsConflicts);
			return cb_containsConflicts;
		}

		static bool n_ContainsConflicts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainsConflicts ();
		}
#pragma warning restore 0169

		/// <returns>true if this merge result contains conflicts</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeResult']/method[@name='containsConflicts' and count(parameter)=0]"
		[Register ("containsConflicts", "()Z", "GetContainsConflictsHandler")]
		public virtual unsafe bool ContainsConflicts ()
		{
			const string __id = "containsConflicts.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		/// <returns>an iterator over the MergeChunks. The iterator does not support
		/// the remove operation</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeResult']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setContainsConflicts_Z;
#pragma warning disable 0169
		static Delegate GetSetContainsConflicts_ZHandler ()
		{
			if (cb_setContainsConflicts_Z == null)
				cb_setContainsConflicts_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetContainsConflicts_Z);
			return cb_setContainsConflicts_Z;
		}

		static void n_SetContainsConflicts_Z (IntPtr jnienv, IntPtr native__this, bool containsConflicts)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContainsConflicts (containsConflicts);
		}
#pragma warning restore 0169

		/// <param name="containsConflicts">containsConflicts</param>
		/// <summary>Sets explicitly whether this merge should be seen as containing a
		/// conflict or not.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeResult']/method[@name='setContainsConflicts' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setContainsConflicts", "(Z)V", "GetSetContainsConflicts_ZHandler")]
		protected virtual unsafe void SetContainsConflicts (bool containsConflicts)
		{
			const string __id = "setContainsConflicts.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (containsConflicts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
