using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>One chunk from a merge result.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/MergeChunk", DoNotGenerateAcw=true)]
	public partial class MergeChunk : global::Java.Lang.Object {
		/// <summary>A state telling whether a MergeChunk belongs to a conflict or not.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk.ConflictState']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/merge/MergeChunk$ConflictState", DoNotGenerateAcw=true)]
		public sealed partial class ConflictState : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk.ConflictState']/field[@name='FIRST_CONFLICTING_RANGE']"
			[Register ("FIRST_CONFLICTING_RANGE")]
			public static global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState FirstConflictingRange {
				get {
					const string __id = "FIRST_CONFLICTING_RANGE.Lorg/eclipse/jgit/merge/MergeChunk$ConflictState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk.ConflictState']/field[@name='NEXT_CONFLICTING_RANGE']"
			[Register ("NEXT_CONFLICTING_RANGE")]
			public static global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState NextConflictingRange {
				get {
					const string __id = "NEXT_CONFLICTING_RANGE.Lorg/eclipse/jgit/merge/MergeChunk$ConflictState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk.ConflictState']/field[@name='NO_CONFLICT']"
			[Register ("NO_CONFLICT")]
			public static global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState NoConflict {
				get {
					const string __id = "NO_CONFLICT.Lorg/eclipse/jgit/merge/MergeChunk$ConflictState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/MergeChunk$ConflictState", typeof (ConflictState));

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

			internal ConflictState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk.ConflictState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/merge/MergeChunk$ConflictState;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/merge/MergeChunk$ConflictState;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk.ConflictState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/merge/MergeChunk$ConflictState;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/merge/MergeChunk$ConflictState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/MergeChunk", typeof (MergeChunk));

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

		protected MergeChunk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk']/constructor[@name='MergeChunk' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.eclipse.jgit.merge.MergeChunk.ConflictState']]"
		[Register (".ctor", "(IIILorg/eclipse/jgit/merge/MergeChunk$ConflictState;)V", "")]
		protected unsafe MergeChunk (int sequenceIndex, int begin, int end, global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState conflictState) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIILorg/eclipse/jgit/merge/MergeChunk$ConflictState;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (sequenceIndex);
				__args [1] = new JniArgumentValue (begin);
				__args [2] = new JniArgumentValue (end);
				__args [3] = new JniArgumentValue ((conflictState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conflictState).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (conflictState);
			}
		}

		static Delegate cb_getBegin;
#pragma warning disable 0169
		static Delegate GetGetBeginHandler ()
		{
			if (cb_getBegin == null)
				cb_getBegin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBegin);
			return cb_getBegin;
		}

		static int n_GetBegin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Begin;
		}
#pragma warning restore 0169

		/// <returns>the first element from the specified sequence which should be
		///         included in the merge result. Indexes start with 0.</returns>
		public virtual unsafe int Begin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk']/method[@name='getBegin' and count(parameter)=0]"
			[Register ("getBegin", "()I", "GetGetBeginHandler")]
			get {
				const string __id = "getBegin.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getEnd;
#pragma warning disable 0169
		static Delegate GetGetEndHandler ()
		{
			if (cb_getEnd == null)
				cb_getEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEnd);
			return cb_getEnd;
		}

		static int n_GetEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.End;
		}
#pragma warning restore 0169

		/// <returns>the end of the range of this chunk. The element this index
		///         points to is the first element which not added to the merge
		///         result. All elements between begin (including begin) and this
		///         element are added.</returns>
		public virtual unsafe int End {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk']/method[@name='getEnd' and count(parameter)=0]"
			[Register ("getEnd", "()I", "GetGetEndHandler")]
			get {
				const string __id = "getEnd.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSequenceIndex;
#pragma warning disable 0169
		static Delegate GetGetSequenceIndexHandler ()
		{
			if (cb_getSequenceIndex == null)
				cb_getSequenceIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSequenceIndex);
			return cb_getSequenceIndex;
		}

		static int n_GetSequenceIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SequenceIndex;
		}
#pragma warning restore 0169

		/// <returns>the index of the sequence to which sequence this chunks belongs
		///         to. Same as in <c>org.eclipse.jgit.merge.MergeResult#add</c></returns>
		public virtual unsafe int SequenceIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk']/method[@name='getSequenceIndex' and count(parameter)=0]"
			[Register ("getSequenceIndex", "()I", "GetGetSequenceIndexHandler")]
			get {
				const string __id = "getSequenceIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getConflictState;
#pragma warning disable 0169
		static Delegate GetGetConflictStateHandler ()
		{
			if (cb_getConflictState == null)
				cb_getConflictState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConflictState);
			return cb_getConflictState;
		}

		static IntPtr n_GetConflictState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetConflictState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeChunk']/method[@name='getConflictState' and count(parameter)=0]"
		[Register ("getConflictState", "()Lorg/eclipse/jgit/merge/MergeChunk$ConflictState;", "GetGetConflictStateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState GetConflictState ()
		{
			const string __id = "getConflictState.()Lorg/eclipse/jgit/merge/MergeChunk$ConflictState;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeChunk.ConflictState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
