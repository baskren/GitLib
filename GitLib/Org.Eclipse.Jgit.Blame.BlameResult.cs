using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Blame {

	/// <summary>Collects line annotations for inspection by applications.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/blame/BlameResult", DoNotGenerateAcw=true)]
	public partial class BlameResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/blame/BlameResult", typeof (BlameResult));

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

		protected BlameResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getResultContents;
#pragma warning disable 0169
		static Delegate GetGetResultContentsHandler ()
		{
			if (cb_getResultContents == null)
				cb_getResultContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResultContents);
			return cb_getResultContents;
		}

		static IntPtr n_GetResultContents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResultContents);
		}
#pragma warning restore 0169

		/// <returns>contents of the result file, available for display.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.RawText ResultContents {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='getResultContents' and count(parameter)=0]"
			[Register ("getResultContents", "()Lorg/eclipse/jgit/diff/RawText;", "GetGetResultContentsHandler")]
			get {
				const string __id = "getResultContents.()Lorg/eclipse/jgit/diff/RawText;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResultPath;
#pragma warning disable 0169
		static Delegate GetGetResultPathHandler ()
		{
			if (cb_getResultPath == null)
				cb_getResultPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResultPath);
			return cb_getResultPath;
		}

		static IntPtr n_GetResultPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResultPath);
		}
#pragma warning restore 0169

		/// <returns>path of the file this result annotates.</returns>
		public virtual unsafe string ResultPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='getResultPath' and count(parameter)=0]"
			[Register ("getResultPath", "()Ljava/lang/String;", "GetGetResultPathHandler")]
			get {
				const string __id = "getResultPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_computeAll;
#pragma warning disable 0169
		static Delegate GetComputeAllHandler ()
		{
			if (cb_computeAll == null)
				cb_computeAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ComputeAll);
			return cb_computeAll;
		}

		static void n_ComputeAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ComputeAll ();
		}
#pragma warning restore 0169

		/// <summary>Compute all pending information.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='computeAll' and count(parameter)=0]"
		[Register ("computeAll", "()V", "GetComputeAllHandler")]
		public virtual unsafe void ComputeAll ()
		{
			const string __id = "computeAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_computeNext;
#pragma warning disable 0169
		static Delegate GetComputeNextHandler ()
		{
			if (cb_computeNext == null)
				cb_computeNext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_ComputeNext);
			return cb_computeNext;
		}

		static int n_ComputeNext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeNext ();
		}
#pragma warning restore 0169

		/// <summary>Compute the next available segment and return the first index.</summary>
		/// <returns>index that is now available. -1 if no more are available.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='computeNext' and count(parameter)=0]"
		[Register ("computeNext", "()I", "GetComputeNextHandler")]
		public virtual unsafe int ComputeNext ()
		{
			const string __id = "computeNext.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_computeRange_II;
#pragma warning disable 0169
		static Delegate GetComputeRange_IIHandler ()
		{
			if (cb_computeRange_II == null)
				cb_computeRange_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_ComputeRange_II);
			return cb_computeRange_II;
		}

		static void n_ComputeRange_II (IntPtr jnienv, IntPtr native__this, int start, int end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ComputeRange (start, end);
		}
#pragma warning restore 0169

		/// <param name="start">first index to examine (inclusive).</param>
		/// <param name="end">end index (exclusive).</param>
		/// <summary>Compute until the entire range has been populated.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='computeRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("computeRange", "(II)V", "GetComputeRange_IIHandler")]
		public virtual unsafe void ComputeRange (int start, int end)
		{
			const string __id = "computeRange.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (end);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <param name="gen">the generator the result will consume records from.</param>
		/// <summary>Construct a new BlameResult for a generator.</summary>
		/// <returns>the new result object. null if the generator cannot find the path
		///         it starts from.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.blame.BlameGenerator']]"
		[Register ("create", "(Lorg/eclipse/jgit/blame/BlameGenerator;)Lorg/eclipse/jgit/blame/BlameResult;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Blame.BlameResult Create (global::Org.Eclipse.Jgit.Blame.BlameGenerator gen)
		{
			const string __id = "create.(Lorg/eclipse/jgit/blame/BlameGenerator;)Lorg/eclipse/jgit/blame/BlameResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gen == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gen).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (gen);
			}
		}

		static Delegate cb_discardResultContents;
#pragma warning disable 0169
		static Delegate GetDiscardResultContentsHandler ()
		{
			if (cb_discardResultContents == null)
				cb_discardResultContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DiscardResultContents);
			return cb_discardResultContents;
		}

		static void n_DiscardResultContents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DiscardResultContents ();
		}
#pragma warning restore 0169

		/// <summary>Throw away the <c>#getResultContents()</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='discardResultContents' and count(parameter)=0]"
		[Register ("discardResultContents", "()V", "GetDiscardResultContentsHandler")]
		public virtual unsafe void DiscardResultContents ()
		{
			const string __id = "discardResultContents.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getSourceAuthor_I;
#pragma warning disable 0169
		static Delegate GetGetSourceAuthor_IHandler ()
		{
			if (cb_getSourceAuthor_I == null)
				cb_getSourceAuthor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetSourceAuthor_I);
			return cb_getSourceAuthor_I;
		}

		static IntPtr n_GetSourceAuthor_I (IntPtr jnienv, IntPtr native__this, int idx)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSourceAuthor (idx));
		}
#pragma warning restore 0169

		/// <param name="idx">line to read data of, 0 based.</param>
		/// <summary>Get the author that provided the specified line of the result.</summary>
		/// <returns>author that provided line <c>idx</c>. May be null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='getSourceAuthor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSourceAuthor", "(I)Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetSourceAuthor_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent GetSourceAuthor (int idx)
		{
			const string __id = "getSourceAuthor.(I)Lorg/eclipse/jgit/lib/PersonIdent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSourceCommit_I;
#pragma warning disable 0169
		static Delegate GetGetSourceCommit_IHandler ()
		{
			if (cb_getSourceCommit_I == null)
				cb_getSourceCommit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetSourceCommit_I);
			return cb_getSourceCommit_I;
		}

		static IntPtr n_GetSourceCommit_I (IntPtr jnienv, IntPtr native__this, int idx)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSourceCommit (idx));
		}
#pragma warning restore 0169

		/// <param name="idx">line to read data of, 0 based.</param>
		/// <summary>Get the commit that provided the specified line of the result.</summary>
		/// <returns>commit that provided line <c>idx</c>. May be null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='getSourceCommit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSourceCommit", "(I)Lorg/eclipse/jgit/revwalk/RevCommit;", "GetGetSourceCommit_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit GetSourceCommit (int idx)
		{
			const string __id = "getSourceCommit.(I)Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSourceCommitter_I;
#pragma warning disable 0169
		static Delegate GetGetSourceCommitter_IHandler ()
		{
			if (cb_getSourceCommitter_I == null)
				cb_getSourceCommitter_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetSourceCommitter_I);
			return cb_getSourceCommitter_I;
		}

		static IntPtr n_GetSourceCommitter_I (IntPtr jnienv, IntPtr native__this, int idx)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSourceCommitter (idx));
		}
#pragma warning restore 0169

		/// <param name="idx">line to read data of, 0 based.</param>
		/// <summary>Get the committer that provided the specified line of the result.</summary>
		/// <returns>committer that provided line <c>idx</c>. May be null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='getSourceCommitter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSourceCommitter", "(I)Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetSourceCommitter_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent GetSourceCommitter (int idx)
		{
			const string __id = "getSourceCommitter.(I)Lorg/eclipse/jgit/lib/PersonIdent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSourceLine_I;
#pragma warning disable 0169
		static Delegate GetGetSourceLine_IHandler ()
		{
			if (cb_getSourceLine_I == null)
				cb_getSourceLine_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetSourceLine_I);
			return cb_getSourceLine_I;
		}

		static int n_GetSourceLine_I (IntPtr jnienv, IntPtr native__this, int idx)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSourceLine (idx);
		}
#pragma warning restore 0169

		/// <param name="idx">line to read data of, 0 based.</param>
		/// <summary>Get the corresponding line number in the source file.</summary>
		/// <returns>matching line number in the source file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='getSourceLine' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSourceLine", "(I)I", "GetGetSourceLine_IHandler")]
		public virtual unsafe int GetSourceLine (int idx)
		{
			const string __id = "getSourceLine.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getSourcePath_I;
#pragma warning disable 0169
		static Delegate GetGetSourcePath_IHandler ()
		{
			if (cb_getSourcePath_I == null)
				cb_getSourcePath_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetSourcePath_I);
			return cb_getSourcePath_I;
		}

		static IntPtr n_GetSourcePath_I (IntPtr jnienv, IntPtr native__this, int idx)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetSourcePath (idx));
		}
#pragma warning restore 0169

		/// <param name="idx">line to read data of, 0 based.</param>
		/// <summary>Get the file path that provided the specified line of the result.</summary>
		/// <returns>source file path that provided line <c>idx</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='getSourcePath' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSourcePath", "(I)Ljava/lang/String;", "GetGetSourcePath_IHandler")]
		public virtual unsafe string GetSourcePath (int idx)
		{
			const string __id = "getSourcePath.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hasSourceData_I;
#pragma warning disable 0169
		static Delegate GetHasSourceData_IHandler ()
		{
			if (cb_hasSourceData_I == null)
				cb_hasSourceData_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_HasSourceData_I);
			return cb_hasSourceData_I;
		}

		static bool n_HasSourceData_I (IntPtr jnienv, IntPtr native__this, int idx)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSourceData (idx);
		}
#pragma warning restore 0169

		/// <param name="idx">line to read data of, 0 based.</param>
		/// <summary>Check if the given result line has been annotated yet.</summary>
		/// <returns>true if the data has been annotated, false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='hasSourceData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasSourceData", "(I)Z", "GetHasSourceData_IHandler")]
		public virtual unsafe bool HasSourceData (int idx)
		{
			const string __id = "hasSourceData.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_hasSourceData_II;
#pragma warning disable 0169
		static Delegate GetHasSourceData_IIHandler ()
		{
			if (cb_hasSourceData_II == null)
				cb_hasSourceData_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_Z) n_HasSourceData_II);
			return cb_hasSourceData_II;
		}

		static bool n_HasSourceData_II (IntPtr jnienv, IntPtr native__this, int start, int end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSourceData (start, end);
		}
#pragma warning restore 0169

		/// <param name="start">first index to examine.</param>
		/// <param name="end">last index to examine.</param>
		/// <summary>Check if the given result line has been annotated yet.</summary>
		/// <returns>true if the data has been annotated, false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='hasSourceData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("hasSourceData", "(II)Z", "GetHasSourceData_IIHandler")]
		public virtual unsafe bool HasSourceData (int start, int end)
		{
			const string __id = "hasSourceData.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (end);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_lastLength;
#pragma warning disable 0169
		static Delegate GetLastLengthHandler ()
		{
			if (cb_lastLength == null)
				cb_lastLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_LastLength);
			return cb_lastLength;
		}

		static int n_LastLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastLength ();
		}
#pragma warning restore 0169

		/// <returns>length of the last segment found by <c>#computeNext()</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameResult']/method[@name='lastLength' and count(parameter)=0]"
		[Register ("lastLength", "()I", "GetLastLengthHandler")]
		public virtual unsafe int LastLength ()
		{
			const string __id = "lastLength.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
