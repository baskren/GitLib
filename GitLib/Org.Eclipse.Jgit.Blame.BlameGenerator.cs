using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Blame {

	/// <summary>Generate author information for lines based on a provided file.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/blame/BlameGenerator", DoNotGenerateAcw=true)]
	public partial class BlameGenerator : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/blame/BlameGenerator", typeof (BlameGenerator));

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

		protected BlameGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repository">repository to access revision data from.</param>
		/// <param name="path">initial path of the file to start scanning (relative to the
		///            repository).</param>
		/// <summary>Create a blame generator for the repository and path (relative to
		/// repository)</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/constructor[@name='BlameGenerator' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)V", "")]
		public unsafe BlameGenerator (global::Org.Eclipse.Jgit.Lib.Repository repository, string path) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue (native_path);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (repository);
			}
		}

		static Delegate cb_getRegionLength;
#pragma warning disable 0169
		static Delegate GetGetRegionLengthHandler ()
		{
			if (cb_getRegionLength == null)
				cb_getRegionLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRegionLength);
			return cb_getRegionLength;
		}

		static int n_GetRegionLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegionLength;
		}
#pragma warning restore 0169

		/// <returns>number of lines in the current region being blamed to
		///         <c>#getSourceCommit()</c>. This is always the value of the
		///         expression <c>getResultEnd() - getResultStart()</c>, but also
		///         <c>getSourceEnd() - getSourceStart()</c>.</returns>
		public virtual unsafe int RegionLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getRegionLength' and count(parameter)=0]"
			[Register ("getRegionLength", "()I", "GetGetRegionLengthHandler")]
			get {
				const string __id = "getRegionLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRenameDetector;
#pragma warning disable 0169
		static Delegate GetGetRenameDetectorHandler ()
		{
			if (cb_getRenameDetector == null)
				cb_getRenameDetector = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRenameDetector);
			return cb_getRenameDetector;
		}

		static IntPtr n_GetRenameDetector (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RenameDetector);
		}
#pragma warning restore 0169

		/// <summary>Obtain the RenameDetector if <c>setFollowFileRenames(true)</c>.</summary>
		/// <returns>the rename detector, allowing the application to configure its
		///         settings for rename score and breaking behavior.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.RenameDetector RenameDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getRenameDetector' and count(parameter)=0]"
			[Register ("getRenameDetector", "()Lorg/eclipse/jgit/diff/RenameDetector;", "GetGetRenameDetectorHandler")]
			get {
				const string __id = "getRenameDetector.()Lorg/eclipse/jgit/diff/RenameDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRenameScore;
#pragma warning disable 0169
		static Delegate GetGetRenameScoreHandler ()
		{
			if (cb_getRenameScore == null)
				cb_getRenameScore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRenameScore);
			return cb_getRenameScore;
		}

		static int n_GetRenameScore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RenameScore;
		}
#pragma warning restore 0169

		/// <returns>rename score if a rename occurred in <c>#getSourceCommit</c>.</returns>
		public virtual unsafe int RenameScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getRenameScore' and count(parameter)=0]"
			[Register ("getRenameScore", "()I", "GetGetRenameScoreHandler")]
			get {
				const string __id = "getRenameScore.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRepository;
#pragma warning disable 0169
		static Delegate GetGetRepositoryHandler ()
		{
			if (cb_getRepository == null)
				cb_getRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepository);
			return cb_getRepository;
		}

		static IntPtr n_GetRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		/// <returns>repository being scanned for revision history.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "GetGetRepositoryHandler")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/lib/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResultContents);
		}
#pragma warning restore 0169

		/// <returns>complete file contents of the result file blame is annotating.
		///         This value is accessible only after being configured and only
		///         immediately before the first call to <c>#next()</c>. Returns
		///         null if the path does not exist.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.RawText ResultContents {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getResultContents' and count(parameter)=0]"
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

		static Delegate cb_getResultEnd;
#pragma warning disable 0169
		static Delegate GetGetResultEndHandler ()
		{
			if (cb_getResultEnd == null)
				cb_getResultEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetResultEnd);
			return cb_getResultEnd;
		}

		static int n_GetResultEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResultEnd;
		}
#pragma warning restore 0169

		/// <returns>one past the range of the result that <c>#getSourceCommit()</c>
		///         has been blamed for providing. Line numbers use 0 based indexing.
		///         Because a source cannot be blamed for an empty region of the
		///         result, <c>#getResultEnd()</c> is always at least one larger
		///         than <c>#getResultStart()</c>.</returns>
		public virtual unsafe int ResultEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getResultEnd' and count(parameter)=0]"
			[Register ("getResultEnd", "()I", "GetGetResultEndHandler")]
			get {
				const string __id = "getResultEnd.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResultPath);
		}
#pragma warning restore 0169

		/// <returns>path file path being processed.</returns>
		public virtual unsafe string ResultPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getResultPath' and count(parameter)=0]"
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

		static Delegate cb_getResultStart;
#pragma warning disable 0169
		static Delegate GetGetResultStartHandler ()
		{
			if (cb_getResultStart == null)
				cb_getResultStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetResultStart);
			return cb_getResultStart;
		}

		static int n_GetResultStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResultStart;
		}
#pragma warning restore 0169

		/// <returns>first line of the result that <c>#getSourceCommit()</c> has been
		///         blamed for providing. Line numbers use 0 based indexing.</returns>
		public virtual unsafe int ResultStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getResultStart' and count(parameter)=0]"
			[Register ("getResultStart", "()I", "GetGetResultStartHandler")]
			get {
				const string __id = "getResultStart.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSourceAuthor;
#pragma warning disable 0169
		static Delegate GetGetSourceAuthorHandler ()
		{
			if (cb_getSourceAuthor == null)
				cb_getSourceAuthor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSourceAuthor);
			return cb_getSourceAuthor;
		}

		static IntPtr n_GetSourceAuthor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceAuthor);
		}
#pragma warning restore 0169

		/// <returns>current author being blamed.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent SourceAuthor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getSourceAuthor' and count(parameter)=0]"
			[Register ("getSourceAuthor", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetSourceAuthorHandler")]
			get {
				const string __id = "getSourceAuthor.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceCommit;
#pragma warning disable 0169
		static Delegate GetGetSourceCommitHandler ()
		{
			if (cb_getSourceCommit == null)
				cb_getSourceCommit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSourceCommit);
			return cb_getSourceCommit;
		}

		static IntPtr n_GetSourceCommit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceCommit);
		}
#pragma warning restore 0169

		/// <summary>Get the revision blamed for the current region.</summary>
		/// <returns>current revision being blamed.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit SourceCommit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getSourceCommit' and count(parameter)=0]"
			[Register ("getSourceCommit", "()Lorg/eclipse/jgit/revwalk/RevCommit;", "GetGetSourceCommitHandler")]
			get {
				const string __id = "getSourceCommit.()Lorg/eclipse/jgit/revwalk/RevCommit;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceCommitter;
#pragma warning disable 0169
		static Delegate GetGetSourceCommitterHandler ()
		{
			if (cb_getSourceCommitter == null)
				cb_getSourceCommitter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSourceCommitter);
			return cb_getSourceCommitter;
		}

		static IntPtr n_GetSourceCommitter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceCommitter);
		}
#pragma warning restore 0169

		/// <returns>current committer being blamed.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent SourceCommitter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getSourceCommitter' and count(parameter)=0]"
			[Register ("getSourceCommitter", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetSourceCommitterHandler")]
			get {
				const string __id = "getSourceCommitter.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceContents;
#pragma warning disable 0169
		static Delegate GetGetSourceContentsHandler ()
		{
			if (cb_getSourceContents == null)
				cb_getSourceContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSourceContents);
			return cb_getSourceContents;
		}

		static IntPtr n_GetSourceContents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceContents);
		}
#pragma warning restore 0169

		/// <returns>complete contents of the source file blamed for the current
		///         output region. This is the contents of <c>#getSourcePath()</c>
		///         within <c>#getSourceCommit()</c>. The source contents is
		///         temporarily available as an artifact of the blame algorithm. Most
		///         applications will want the result contents for display to users.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.RawText SourceContents {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getSourceContents' and count(parameter)=0]"
			[Register ("getSourceContents", "()Lorg/eclipse/jgit/diff/RawText;", "GetGetSourceContentsHandler")]
			get {
				const string __id = "getSourceContents.()Lorg/eclipse/jgit/diff/RawText;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceEnd;
#pragma warning disable 0169
		static Delegate GetGetSourceEndHandler ()
		{
			if (cb_getSourceEnd == null)
				cb_getSourceEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSourceEnd);
			return cb_getSourceEnd;
		}

		static int n_GetSourceEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SourceEnd;
		}
#pragma warning restore 0169

		/// <returns>one past the range of the source data that has been blamed for
		///         the current region. This is line number of where the region was
		///         added during <c>#getSourceCommit()</c> in file
		///         <c>#getSourcePath()</c>.</returns>
		public virtual unsafe int SourceEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getSourceEnd' and count(parameter)=0]"
			[Register ("getSourceEnd", "()I", "GetGetSourceEndHandler")]
			get {
				const string __id = "getSourceEnd.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSourcePath;
#pragma warning disable 0169
		static Delegate GetGetSourcePathHandler ()
		{
			if (cb_getSourcePath == null)
				cb_getSourcePath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSourcePath);
			return cb_getSourcePath;
		}

		static IntPtr n_GetSourcePath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourcePath);
		}
#pragma warning restore 0169

		/// <returns>path of the file being blamed.</returns>
		public virtual unsafe string SourcePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getSourcePath' and count(parameter)=0]"
			[Register ("getSourcePath", "()Ljava/lang/String;", "GetGetSourcePathHandler")]
			get {
				const string __id = "getSourcePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceStart;
#pragma warning disable 0169
		static Delegate GetGetSourceStartHandler ()
		{
			if (cb_getSourceStart == null)
				cb_getSourceStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSourceStart);
			return cb_getSourceStart;
		}

		static int n_GetSourceStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SourceStart;
		}
#pragma warning restore 0169

		/// <returns>first line of the source data that has been blamed for the
		///         current region. This is line number of where the region was added
		///         during <c>#getSourceCommit()</c> in file
		///         <c>#getSourcePath()</c>.</returns>
		public virtual unsafe int SourceStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='getSourceStart' and count(parameter)=0]"
			[Register ("getSourceStart", "()I", "GetGetSourceStartHandler")]
			get {
				const string __id = "getSourceStart.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_computeBlameResult;
#pragma warning disable 0169
		static Delegate GetComputeBlameResultHandler ()
		{
			if (cb_computeBlameResult == null)
				cb_computeBlameResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ComputeBlameResult);
			return cb_computeBlameResult;
		}

		static IntPtr n_ComputeBlameResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ComputeBlameResult ());
		}
#pragma warning restore 0169

		/// <summary>Execute the generator in a blocking fashion until all data is ready.</summary>
		/// <returns>the complete result. Null if no file exists for the given path.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='computeBlameResult' and count(parameter)=0]"
		[Register ("computeBlameResult", "()Lorg/eclipse/jgit/blame/BlameResult;", "GetComputeBlameResultHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Blame.BlameResult ComputeBlameResult ()
		{
			const string __id = "computeBlameResult.()Lorg/eclipse/jgit/blame/BlameResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newFlag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewFlag_Ljava_lang_String_Handler ()
		{
			if (cb_newFlag_Ljava_lang_String_ == null)
				cb_newFlag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewFlag_Ljava_lang_String_);
			return cb_newFlag_Ljava_lang_String_;
		}

		static IntPtr n_NewFlag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewFlag (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">unique name of the flag in the blame context.</param>
		/// <summary>Allocate a new RevFlag for use by the caller.</summary>
		/// <returns>the newly allocated flag.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='newFlag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newFlag", "(Ljava/lang/String;)Lorg/eclipse/jgit/revwalk/RevFlag;", "GetNewFlag_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevFlag NewFlag (string name)
		{
			const string __id = "newFlag.(Ljava/lang/String;)Lorg/eclipse/jgit/revwalk/RevFlag;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Next);
			return cb_next;
		}

		static bool n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Next ();
		}
#pragma warning restore 0169

		/// <summary>Step the blame algorithm one iteration.</summary>
		/// <returns>true if the generator has found a region's source. The getSource*
		///         and <c>#getResultStart()</c>, <c>#getResultEnd()</c> methods
		///         can be used to inspect the region found. False if there are no
		///         more regions to describe.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Z", "GetNextHandler")]
		public virtual unsafe bool Next ()
		{
			const string __id = "next.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_push_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetPush_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_push_Ljava_lang_String_arrayB == null)
				cb_push_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Push_Ljava_lang_String_arrayB);
			return cb_push_Ljava_lang_String_arrayB;
		}

		static IntPtr n_Push_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_description, IntPtr native_contents)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
			var contents = (byte[]) JNIEnv.GetArray (native_contents, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Push (description, contents));
			if (contents != null)
				JNIEnv.CopyArray (contents, native_contents);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="description">description of the blob revision, such as "Working Tree".</param>
		/// <param name="contents">contents of the file.</param>
		/// <summary>Push a candidate blob onto the generator's traversal stack.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='push' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("push", "(Ljava/lang/String;[B)Lorg/eclipse/jgit/blame/BlameGenerator;", "GetPush_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Blame.BlameGenerator Push (string description, byte[] contents)
		{
			const string __id = "push.(Ljava/lang/String;[B)Lorg/eclipse/jgit/blame/BlameGenerator;";
			IntPtr native_description = JNIEnv.NewString ((string)description);
			IntPtr native_contents = JNIEnv.NewArray (contents);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_description);
				__args [1] = new JniArgumentValue (native_contents);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_description);
				if (contents != null) {
					JNIEnv.CopyArray (native_contents, contents);
					JNIEnv.DeleteLocalRef (native_contents);
				}
				global::System.GC.KeepAlive (contents);
			}
		}

		static Delegate cb_push_Ljava_lang_String_Lorg_eclipse_jgit_diff_RawText_;
#pragma warning disable 0169
		static Delegate GetPush_Ljava_lang_String_Lorg_eclipse_jgit_diff_RawText_Handler ()
		{
			if (cb_push_Ljava_lang_String_Lorg_eclipse_jgit_diff_RawText_ == null)
				cb_push_Ljava_lang_String_Lorg_eclipse_jgit_diff_RawText_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Push_Ljava_lang_String_Lorg_eclipse_jgit_diff_RawText_);
			return cb_push_Ljava_lang_String_Lorg_eclipse_jgit_diff_RawText_;
		}

		static IntPtr n_Push_Ljava_lang_String_Lorg_eclipse_jgit_diff_RawText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description, IntPtr native_contents)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
			var contents = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_contents, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Push (description, contents));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="description">description of the blob revision, such as "Working Tree".</param>
		/// <param name="contents">contents of the file.</param>
		/// <summary>Push a candidate blob onto the generator's traversal stack.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='push' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.diff.RawText']]"
		[Register ("push", "(Ljava/lang/String;Lorg/eclipse/jgit/diff/RawText;)Lorg/eclipse/jgit/blame/BlameGenerator;", "GetPush_Ljava_lang_String_Lorg_eclipse_jgit_diff_RawText_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Blame.BlameGenerator Push (string description, global::Org.Eclipse.Jgit.Diff.RawText contents)
		{
			const string __id = "push.(Ljava/lang/String;Lorg/eclipse/jgit/diff/RawText;)Lorg/eclipse/jgit/blame/BlameGenerator;";
			IntPtr native_description = JNIEnv.NewString ((string)description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_description);
				__args [1] = new JniArgumentValue ((contents == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contents).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_description);
				global::System.GC.KeepAlive (contents);
			}
		}

		static Delegate cb_push_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetPush_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_push_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_push_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Push_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_push_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Push_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Push (description, id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="description">description of the blob revision, such as "Working Tree".</param>
		/// <param name="id">may be a commit or a blob.</param>
		/// <summary>Push a candidate object onto the generator's traversal stack.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='push' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("push", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/blame/BlameGenerator;", "GetPush_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Blame.BlameGenerator Push (string description, global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "push.(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/blame/BlameGenerator;";
			IntPtr native_description = JNIEnv.NewString ((string)description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_description);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_description);
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		/// <summary>Release the current blame session.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetReverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_Handler ()
		{
			if (cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_ == null)
				cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_);
			return cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_;
		}

		static IntPtr n_Reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_start, IntPtr native_end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var start = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_start, JniHandleOwnership.DoNotTransfer);
			var end = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_end, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Reverse (start, end));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="start">oldest commit to traverse from. The result file will be loaded
		///            from this commit's tree.</param>
		/// <param name="end">most recent commits to stop traversal at. Usually an active
		///            branch tip, tag, or HEAD.</param>
		/// <summary>Configure the generator to compute reverse blame (history of deletes).</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='reverse' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("reverse", "(Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/util/Collection;)Lorg/eclipse/jgit/blame/BlameGenerator;", "GetReverse_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Blame.BlameGenerator Reverse (global::Org.Eclipse.Jgit.Lib.AnyObjectId start, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> end)
		{
			const string __id = "reverse.(Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/util/Collection;)Lorg/eclipse/jgit/blame/BlameGenerator;";
			IntPtr native_end = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (end);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((start == null) ? IntPtr.Zero : ((global::Java.Lang.Object) start).Handle);
				__args [1] = new JniArgumentValue (native_end);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_end);
				global::System.GC.KeepAlive (start);
				global::System.GC.KeepAlive (end);
			}
		}

		static Delegate cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetReverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Reverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_start, IntPtr native_end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var start = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_start, JniHandleOwnership.DoNotTransfer);
			var end = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_end, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Reverse (start, end));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="start">oldest commit to traverse from. The result file will be loaded
		///            from this commit's tree.</param>
		/// <param name="end">most recent commit to stop traversal at. Usually an active
		///            branch tip, tag, or HEAD.</param>
		/// <summary>Configure the generator to compute reverse blame (history of deletes).</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='reverse' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("reverse", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/blame/BlameGenerator;", "GetReverse_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Blame.BlameGenerator Reverse (global::Org.Eclipse.Jgit.Lib.AnyObjectId start, global::Org.Eclipse.Jgit.Lib.AnyObjectId end)
		{
			const string __id = "reverse.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/blame/BlameGenerator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((start == null) ? IntPtr.Zero : ((global::Java.Lang.Object) start).Handle);
				__args [1] = new JniArgumentValue ((end == null) ? IntPtr.Zero : ((global::Java.Lang.Object) end).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (start);
				global::System.GC.KeepAlive (end);
			}
		}

		static Delegate cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_;
#pragma warning disable 0169
		static Delegate GetSetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_Handler ()
		{
			if (cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ == null)
				cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_);
			return cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_;
		}

		static IntPtr n_SetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ (IntPtr jnienv, IntPtr native__this, IntPtr native_algorithm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var algorithm = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm> (native_algorithm, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDiffAlgorithm (algorithm));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="algorithm">algorithm</param>
		/// <summary>Difference algorithm to use when comparing revisions.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='setDiffAlgorithm' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffAlgorithm']]"
		[Register ("setDiffAlgorithm", "(Lorg/eclipse/jgit/diff/DiffAlgorithm;)Lorg/eclipse/jgit/blame/BlameGenerator;", "GetSetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Blame.BlameGenerator SetDiffAlgorithm (global::Org.Eclipse.Jgit.Diff.DiffAlgorithm algorithm)
		{
			const string __id = "setDiffAlgorithm.(Lorg/eclipse/jgit/diff/DiffAlgorithm;)Lorg/eclipse/jgit/blame/BlameGenerator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((algorithm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) algorithm).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (algorithm);
			}
		}

		static Delegate cb_setFollowFileRenames_Z;
#pragma warning disable 0169
		static Delegate GetSetFollowFileRenames_ZHandler ()
		{
			if (cb_setFollowFileRenames_Z == null)
				cb_setFollowFileRenames_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetFollowFileRenames_Z);
			return cb_setFollowFileRenames_Z;
		}

		static IntPtr n_SetFollowFileRenames_Z (IntPtr jnienv, IntPtr native__this, bool follow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFollowFileRenames (follow));
		}
#pragma warning restore 0169

		/// <param name="follow">enable following.</param>
		/// <summary>Enable (or disable) following file renames, on by default.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='setFollowFileRenames' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFollowFileRenames", "(Z)Lorg/eclipse/jgit/blame/BlameGenerator;", "GetSetFollowFileRenames_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Blame.BlameGenerator SetFollowFileRenames (bool follow)
		{
			const string __id = "setFollowFileRenames.(Z)Lorg/eclipse/jgit/blame/BlameGenerator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (follow);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_;
#pragma warning disable 0169
		static Delegate GetSetTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_Handler ()
		{
			if (cb_setTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_ == null)
				cb_setTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_);
			return cb_setTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_;
		}

		static IntPtr n_SetTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_comparator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var comparator = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (native_comparator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTextComparator (comparator));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="comparator">comparator</param>
		/// <summary>Text comparator to use when comparing revisions.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.blame']/class[@name='BlameGenerator']/method[@name='setTextComparator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.RawTextComparator']]"
		[Register ("setTextComparator", "(Lorg/eclipse/jgit/diff/RawTextComparator;)Lorg/eclipse/jgit/blame/BlameGenerator;", "GetSetTextComparator_Lorg_eclipse_jgit_diff_RawTextComparator_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Blame.BlameGenerator SetTextComparator (global::Org.Eclipse.Jgit.Diff.RawTextComparator comparator)
		{
			const string __id = "setTextComparator.(Lorg/eclipse/jgit/diff/RawTextComparator;)Lorg/eclipse/jgit/blame/BlameGenerator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Blame.BlameGenerator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (comparator);
			}
		}

	}
}
