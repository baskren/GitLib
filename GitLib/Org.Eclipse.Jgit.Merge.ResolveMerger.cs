using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>A three-way merger performing a content-merge if necessary</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/ResolveMerger", DoNotGenerateAcw=true)]
	public partial class ResolveMerger : global::Org.Eclipse.Jgit.Merge.ThreeWayMerger {

		/// <summary>Builder to update the cache during this merge.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='builder']"
		[Register ("builder")]
		protected global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder Builder {
			get {
				const string __id = "builder.Lorg/eclipse/jgit/dircache/DirCacheBuilder;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "builder.Lorg/eclipse/jgit/dircache/DirCacheBuilder;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>string versions of a list of commit SHA1s</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='commitNames']"
		[Register ("commitNames")]
		protected IList<string> CommitNames {
			get {
				const string __id = "commitNames.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "commitNames.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Directory cache</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='dircache']"
		[Register ("dircache")]
		protected global::Org.Eclipse.Jgit.Dircache.DirCache Dircache {
			get {
				const string __id = "dircache.Lorg/eclipse/jgit/dircache/DirCache;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dircache.Lorg/eclipse/jgit/dircache/DirCache;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Updated as we merge entries of the tree walk.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='enterSubtree']"
		[Register ("enterSubtree")]
		protected bool EnterSubtree {
			get {
				const string __id = "enterSubtree.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "enterSubtree.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		/// <summary>Set to true if this merger should use the default dircache of the
		/// repository and should handle locking and unlocking of the dircache.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='implicitDirCache']"
		[Register ("implicitDirCache")]
		protected bool ImplicitDirCache {
			get {
				const string __id = "implicitDirCache.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "implicitDirCache.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		/// <summary>Set to true if this merge should work in-memory.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='inCore']"
		[Register ("inCore")]
		protected bool InCore {
			get {
				const string __id = "inCore.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "inCore.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		/// <summary>our merge algorithm</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='mergeAlgorithm']"
		[Register ("mergeAlgorithm")]
		protected global::Org.Eclipse.Jgit.Merge.MergeAlgorithm MergeAlgorithm {
			get {
				const string __id = "mergeAlgorithm.Lorg/eclipse/jgit/merge/MergeAlgorithm;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeAlgorithm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mergeAlgorithm.Lorg/eclipse/jgit/merge/MergeAlgorithm;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>merge result as tree</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='resultTree']"
		[Register ("resultTree")]
		protected global::Org.Eclipse.Jgit.Lib.ObjectId ResultTree {
			get {
				const string __id = "resultTree.Lorg/eclipse/jgit/lib/ObjectId;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "resultTree.Lorg/eclipse/jgit/lib/ObjectId;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Paths in this list will be deleted from the local copy at the end of the
		/// operation.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='toBeDeleted']"
		[Register ("toBeDeleted")]
		protected global::System.Collections.IList ToBeDeleted {
			get {
				const string __id = "toBeDeleted.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "toBeDeleted.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>The tree walk which we'll iterate over to merge entries.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='tw']"
		[Register ("tw")]
		protected global::Org.Eclipse.Jgit.Treewalk.NameConflictTreeWalk Tw {
			get {
				const string __id = "tw.Lorg/eclipse/jgit/treewalk/NameConflictTreeWalk;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.NameConflictTreeWalk> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tw.Lorg/eclipse/jgit/treewalk/NameConflictTreeWalk;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		/// <summary>Index of the base tree within the <c>#tw tree walk</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='T_BASE']"
		[Register ("T_BASE")]
		protected const int TBase = (int) 0;

		/// <summary>Index of the working directory tree within the <c>#tw tree walk</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='T_FILE']"
		[Register ("T_FILE")]
		protected const int TFile = (int) 4;

		/// <summary>Index of the index tree within the <c>#tw tree walk</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='T_INDEX']"
		[Register ("T_INDEX")]
		protected const int TIndex = (int) 3;

		/// <summary>Index of our tree in withthe <c>#tw tree walk</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='T_OURS']"
		[Register ("T_OURS")]
		protected const int TOurs = (int) 1;

		/// <summary>Index of their tree within the <c>#tw tree walk</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='T_THEIRS']"
		[Register ("T_THEIRS")]
		protected const int TTheirs = (int) 2;


		/// <summary>The iterator to access the working tree.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/field[@name='workingTreeIterator']"
		[Register ("workingTreeIterator")]
		protected global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator WorkingTreeIterator {
			get {
				const string __id = "workingTreeIterator.Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "workingTreeIterator.Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		/// <summary>If the merge fails (means: not stopped because of unresolved conflicts)
		/// this enum is used to explain why it failed</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger.MergeFailureReason']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/merge/ResolveMerger$MergeFailureReason", DoNotGenerateAcw=true)]
		public sealed partial class MergeFailureReason : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger.MergeFailureReason']/field[@name='COULD_NOT_DELETE']"
			[Register ("COULD_NOT_DELETE")]
			public static global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason CouldNotDelete {
				get {
					const string __id = "COULD_NOT_DELETE.Lorg/eclipse/jgit/merge/ResolveMerger$MergeFailureReason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger.MergeFailureReason']/field[@name='DIRTY_INDEX']"
			[Register ("DIRTY_INDEX")]
			public static global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason DirtyIndex {
				get {
					const string __id = "DIRTY_INDEX.Lorg/eclipse/jgit/merge/ResolveMerger$MergeFailureReason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger.MergeFailureReason']/field[@name='DIRTY_WORKTREE']"
			[Register ("DIRTY_WORKTREE")]
			public static global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason DirtyWorktree {
				get {
					const string __id = "DIRTY_WORKTREE.Lorg/eclipse/jgit/merge/ResolveMerger$MergeFailureReason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/ResolveMerger$MergeFailureReason", typeof (MergeFailureReason));

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

			internal MergeFailureReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger.MergeFailureReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/merge/ResolveMerger$MergeFailureReason;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/merge/ResolveMerger$MergeFailureReason;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger.MergeFailureReason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/merge/ResolveMerger$MergeFailureReason;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/merge/ResolveMerger$MergeFailureReason;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/ResolveMerger", typeof (ResolveMerger));

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

		protected ResolveMerger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="local">local</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/constructor[@name='ResolveMerger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe ResolveMerger (global::Org.Eclipse.Jgit.Lib.Repository local) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (local);
			}
		}

		/// <param name="local">local</param>
		/// <param name="inCore">inCore</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/constructor[@name='ResolveMerger' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Z)V", "")]
		protected unsafe ResolveMerger (global::Org.Eclipse.Jgit.Lib.Repository local, bool inCore) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue (inCore);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (local);
			}
		}

		static Delegate cb_getFailingPaths;
#pragma warning disable 0169
		static Delegate GetGetFailingPathsHandler ()
		{
			if (cb_getFailingPaths == null)
				cb_getFailingPaths = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFailingPaths);
			return cb_getFailingPaths;
		}

		static IntPtr n_GetFailingPaths (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason>.ToLocalJniHandle (__this.FailingPaths);
		}
#pragma warning restore 0169

		/// <returns>lists paths causing this merge to fail (not stopped because of a
		///         conflict). &lt;code&gt;null&lt;/code&gt; is returned if this merge didn't
		///         fail.</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason> FailingPaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='getFailingPaths' and count(parameter)=0]"
			[Register ("getFailingPaths", "()Ljava/util/Map;", "GetGetFailingPathsHandler")]
			get {
				const string __id = "getFailingPaths.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.ResolveMerger.MergeFailureReason>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMergeResults;
#pragma warning disable 0169
		static Delegate GetGetMergeResultsHandler ()
		{
			if (cb_getMergeResults == null)
				cb_getMergeResults = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMergeResults);
			return cb_getMergeResults;
		}

		static IntPtr n_GetMergeResults (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.MergeResult>.ToLocalJniHandle (__this.MergeResults);
		}
#pragma warning restore 0169

		/// <returns>the mergeResults</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Merge.MergeResult> MergeResults {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='getMergeResults' and count(parameter)=0]"
			[Register ("getMergeResults", "()Ljava/util/Map;", "GetGetMergeResultsHandler")]
			get {
				const string __id = "getMergeResults.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Merge.MergeResult>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModifiedFiles;
#pragma warning disable 0169
		static Delegate GetGetModifiedFilesHandler ()
		{
			if (cb_getModifiedFiles == null)
				cb_getModifiedFiles = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModifiedFiles);
			return cb_getModifiedFiles;
		}

		static IntPtr n_GetModifiedFiles (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ModifiedFiles);
		}
#pragma warning restore 0169

		/// <returns>the paths of files which have been modified by this merge. A
		///         file will be modified if a content-merge works on this path or if
		///         the merge algorithm decides to take the theirs-version. This is a
		///         superset of the files listed by <c>#getUnmergedPaths()</c>.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> ModifiedFiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='getModifiedFiles' and count(parameter)=0]"
			[Register ("getModifiedFiles", "()Ljava/util/List;", "GetGetModifiedFilesHandler")]
			get {
				const string __id = "getModifiedFiles.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResultTreeId;
#pragma warning disable 0169
		static Delegate GetGetResultTreeIdHandler ()
		{
			if (cb_getResultTreeId == null)
				cb_getResultTreeId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResultTreeId);
			return cb_getResultTreeId;
		}

		static IntPtr n_GetResultTreeId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResultTreeId);
		}
#pragma warning restore 0169

		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ResultTreeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='getResultTreeId' and count(parameter)=0]"
			[Register ("getResultTreeId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetResultTreeIdHandler")]
			get {
				const string __id = "getResultTreeId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getToBeCheckedOut;
#pragma warning disable 0169
		static Delegate GetGetToBeCheckedOutHandler ()
		{
			if (cb_getToBeCheckedOut == null)
				cb_getToBeCheckedOut = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetToBeCheckedOut);
			return cb_getToBeCheckedOut;
		}

		static IntPtr n_GetToBeCheckedOut (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Dircache.DirCacheEntry>.ToLocalJniHandle (__this.ToBeCheckedOut);
		}
#pragma warning restore 0169

		/// <returns>a map which maps the paths of files which have to be checked out
		///         because the merge created new fully-merged content for this file
		///         into the index. This means: the merge wrote a new stage 0 entry
		///         for this path.</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> ToBeCheckedOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='getToBeCheckedOut' and count(parameter)=0]"
			[Register ("getToBeCheckedOut", "()Ljava/util/Map;", "GetGetToBeCheckedOutHandler")]
			get {
				const string __id = "getToBeCheckedOut.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Dircache.DirCacheEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnmergedPaths;
#pragma warning disable 0169
		static Delegate GetGetUnmergedPathsHandler ()
		{
			if (cb_getUnmergedPaths == null)
				cb_getUnmergedPaths = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUnmergedPaths);
			return cb_getUnmergedPaths;
		}

		static IntPtr n_GetUnmergedPaths (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UnmergedPaths);
		}
#pragma warning restore 0169

		/// <returns>the paths with conflicts. This is a subset of the files listed
		///         by <c>#getModifiedFiles()</c></returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> UnmergedPaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='getUnmergedPaths' and count(parameter)=0]"
			[Register ("getUnmergedPaths", "()Ljava/util/List;", "GetGetUnmergedPathsHandler")]
			get {
				const string __id = "getUnmergedPaths.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cleanUp;
#pragma warning disable 0169
		static Delegate GetCleanUpHandler ()
		{
			if (cb_cleanUp == null)
				cb_cleanUp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CleanUp);
			return cb_cleanUp;
		}

		static void n_CleanUp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CleanUp ();
		}
#pragma warning restore 0169

		/// <summary>Reverts the worktree after an unsuccessful merge.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='cleanUp' and count(parameter)=0]"
		[Register ("cleanUp", "()V", "GetCleanUpHandler")]
		protected virtual unsafe void CleanUp ()
		{
			const string __id = "cleanUp.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_failed;
#pragma warning disable 0169
		static Delegate GetFailedHandler ()
		{
			if (cb_failed == null)
				cb_failed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Failed);
			return cb_failed;
		}

		static bool n_Failed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Failed ();
		}
#pragma warning restore 0169

		/// <summary>Returns whether this merge failed (i.</summary>
		/// <returns>&lt;code&gt;true&lt;/code&gt; if a failure occurred, &lt;code&gt;false&lt;/code&gt;
		///         otherwise</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='failed' and count(parameter)=0]"
		[Register ("failed", "()Z", "GetFailedHandler")]
		public virtual unsafe bool Failed ()
		{
			const string __id = "failed.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getCommitNames;
#pragma warning disable 0169
		static Delegate GetGetCommitNamesHandler ()
		{
			if (cb_getCommitNames == null)
				cb_getCommitNames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommitNames);
			return cb_getCommitNames;
		}

		static IntPtr n_GetCommitNames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCommitNames ());
		}
#pragma warning restore 0169

		/// <returns>the names of the commits as they would appear in conflict
		///         markers.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='getCommitNames' and count(parameter)=0]"
		[Register ("getCommitNames", "()[Ljava/lang/String;", "GetGetCommitNamesHandler")]
		public virtual unsafe string[] GetCommitNames ()
		{
			const string __id = "getCommitNames.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_mergeImpl;
#pragma warning disable 0169
		static Delegate GetMergeImplHandler ()
		{
			if (cb_mergeImpl == null)
				cb_mergeImpl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_MergeImpl);
			return cb_mergeImpl;
		}

		static bool n_MergeImpl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MergeImpl ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='mergeImpl' and count(parameter)=0]"
		[Register ("mergeImpl", "()Z", "GetMergeImplHandler")]
		protected override unsafe bool MergeImpl ()
		{
			const string __id = "mergeImpl.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_mergeTreeWalk_Lorg_eclipse_jgit_treewalk_TreeWalk_Z;
#pragma warning disable 0169
		static Delegate GetMergeTreeWalk_Lorg_eclipse_jgit_treewalk_TreeWalk_ZHandler ()
		{
			if (cb_mergeTreeWalk_Lorg_eclipse_jgit_treewalk_TreeWalk_Z == null)
				cb_mergeTreeWalk_Lorg_eclipse_jgit_treewalk_TreeWalk_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_MergeTreeWalk_Lorg_eclipse_jgit_treewalk_TreeWalk_Z);
			return cb_mergeTreeWalk_Lorg_eclipse_jgit_treewalk_TreeWalk_Z;
		}

		static bool n_MergeTreeWalk_Lorg_eclipse_jgit_treewalk_TreeWalk_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_treeWalk, bool ignoreConflicts)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var treeWalk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (native_treeWalk, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MergeTreeWalk (treeWalk, ignoreConflicts);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="treeWalk">The walk to iterate over.</param>
		/// <param name="ignoreConflicts">see
		///            <c>ResolveMerger#mergeTrees(AbstractTreeIterator, RevTree, RevTree, boolean)</c></param>
		/// <summary>Process the given TreeWalk's entries.</summary>
		/// <returns>Whether the trees merged cleanly.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='mergeTreeWalk' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk'] and parameter[2][@type='boolean']]"
		[Register ("mergeTreeWalk", "(Lorg/eclipse/jgit/treewalk/TreeWalk;Z)Z", "GetMergeTreeWalk_Lorg_eclipse_jgit_treewalk_TreeWalk_ZHandler")]
		protected virtual unsafe bool MergeTreeWalk (global::Org.Eclipse.Jgit.Treewalk.TreeWalk treeWalk, bool ignoreConflicts)
		{
			const string __id = "mergeTreeWalk.(Lorg/eclipse/jgit/treewalk/TreeWalk;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((treeWalk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) treeWalk).Handle);
				__args [1] = new JniArgumentValue (ignoreConflicts);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (treeWalk);
			}
		}

		static Delegate cb_mergeTrees_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Z;
#pragma warning disable 0169
		static Delegate GetMergeTrees_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_ZHandler ()
		{
			if (cb_mergeTrees_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Z == null)
				cb_mergeTrees_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_Z) n_MergeTrees_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Z);
			return cb_mergeTrees_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Z;
		}

		static bool n_MergeTrees_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_baseTree, IntPtr native_headTree, IntPtr native_mergeTree, bool ignoreConflicts)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var baseTree = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_baseTree, JniHandleOwnership.DoNotTransfer);
			var headTree = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (native_headTree, JniHandleOwnership.DoNotTransfer);
			var mergeTree = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (native_mergeTree, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MergeTrees (baseTree, headTree, mergeTree, ignoreConflicts);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="baseTree">baseTree</param>
		/// <param name="headTree">headTree</param>
		/// <param name="mergeTree">mergeTree</param>
		/// <param name="ignoreConflicts">Controls what to do in case a content-merge is done and a
		///            conflict is detected. The default setting for this should be
		///            &lt;code&gt;false&lt;/code&gt;. In this case the working tree file is
		///            filled with new content (containing conflict markers) and the
		///            index is filled with multiple stages containing BASE, OURS and
		///            THEIRS content. Having such non-0 stages is the sign to git
		///            tools that there are still conflicts for that path.
		///            &lt;p&gt;
		///            If &lt;code&gt;true&lt;/code&gt; is specified the behavior is different.
		///            In case a conflict is detected the working tree file is again
		///            filled with new content (containing conflict markers). But
		///            also stage 0 of the index is filled with that content. No
		///            other stages are filled. Means: there is no conflict on that
		///            path but the new content (including conflict markers) is
		///            stored as successful merge result. This is needed in the
		///            context of <c>RecursiveMerger</c> where when determining
		///            merge bases we don't want to deal with content-merge
		///            conflicts.</param>
		/// <summary>The resolve conflict way of three way merging</summary>
		/// <returns>whether the trees merged cleanly</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='mergeTrees' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevTree'] and parameter[3][@type='org.eclipse.jgit.revwalk.RevTree'] and parameter[4][@type='boolean']]"
		[Register ("mergeTrees", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;Lorg/eclipse/jgit/revwalk/RevTree;Lorg/eclipse/jgit/revwalk/RevTree;Z)Z", "GetMergeTrees_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_ZHandler")]
		protected virtual unsafe bool MergeTrees (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator baseTree, global::Org.Eclipse.Jgit.Revwalk.RevTree headTree, global::Org.Eclipse.Jgit.Revwalk.RevTree mergeTree, bool ignoreConflicts)
		{
			const string __id = "mergeTrees.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;Lorg/eclipse/jgit/revwalk/RevTree;Lorg/eclipse/jgit/revwalk/RevTree;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((baseTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseTree).Handle);
				__args [1] = new JniArgumentValue ((headTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headTree).Handle);
				__args [2] = new JniArgumentValue ((mergeTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeTree).Handle);
				__args [3] = new JniArgumentValue (ignoreConflicts);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (baseTree);
				global::System.GC.KeepAlive (headTree);
				global::System.GC.KeepAlive (mergeTree);
			}
		}

		static Delegate cb_processEntry_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_dircache_DirCacheBuildIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Z;
#pragma warning disable 0169
		static Delegate GetProcessEntry_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_dircache_DirCacheBuildIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ZHandler ()
		{
			if (cb_processEntry_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_dircache_DirCacheBuildIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Z == null)
				cb_processEntry_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_dircache_DirCacheBuildIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLZ_Z) n_ProcessEntry_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_dircache_DirCacheBuildIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Z);
			return cb_processEntry_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_dircache_DirCacheBuildIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Z;
		}

		static bool n_ProcessEntry_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_dircache_DirCacheBuildIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Z (IntPtr jnienv, IntPtr native__this, IntPtr native__base, IntPtr native_ours, IntPtr native_theirs, IntPtr native_index, IntPtr native_work, bool ignoreConflicts)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @base = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (native__base, JniHandleOwnership.DoNotTransfer);
			var ours = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (native_ours, JniHandleOwnership.DoNotTransfer);
			var theirs = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (native_theirs, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheBuildIterator> (native_index, JniHandleOwnership.DoNotTransfer);
			var work = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (native_work, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ProcessEntry (@base, ours, theirs, index, work, ignoreConflicts);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="base">the common base for ours and theirs</param>
		/// <param name="ours">the ours side of the merge. When merging a branch into the
		///            HEAD ours will point to HEAD</param>
		/// <param name="theirs">the theirs side of the merge. When merging a branch into the
		///            current HEAD theirs will point to the branch which is merged
		///            into HEAD.</param>
		/// <param name="index">the index entry</param>
		/// <param name="work">the file in the working tree</param>
		/// <param name="ignoreConflicts">see
		///            <c>ResolveMerger#mergeTrees(AbstractTreeIterator, RevTree, RevTree, boolean)</c></param>
		/// <summary>Processes one path and tries to merge.</summary>
		/// <returns>&lt;code&gt;false&lt;/code&gt; if the merge will fail because the index entry
		///         didn't match ours or the working-dir file was dirty and a
		///         conflict occurred</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='processEntry' and count(parameter)=6 and parameter[1][@type='org.eclipse.jgit.treewalk.CanonicalTreeParser'] and parameter[2][@type='org.eclipse.jgit.treewalk.CanonicalTreeParser'] and parameter[3][@type='org.eclipse.jgit.treewalk.CanonicalTreeParser'] and parameter[4][@type='org.eclipse.jgit.dircache.DirCacheBuildIterator'] and parameter[5][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator'] and parameter[6][@type='boolean']]"
		[Register ("processEntry", "(Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;Lorg/eclipse/jgit/dircache/DirCacheBuildIterator;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;Z)Z", "GetProcessEntry_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_treewalk_CanonicalTreeParser_Lorg_eclipse_jgit_dircache_DirCacheBuildIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ZHandler")]
		protected virtual unsafe bool ProcessEntry (global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser @base, global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser ours, global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser theirs, global::Org.Eclipse.Jgit.Dircache.DirCacheBuildIterator index, global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator work, bool ignoreConflicts)
		{
			const string __id = "processEntry.(Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;Lorg/eclipse/jgit/dircache/DirCacheBuildIterator;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue ((ours == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ours).Handle);
				__args [2] = new JniArgumentValue ((theirs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theirs).Handle);
				__args [3] = new JniArgumentValue ((index == null) ? IntPtr.Zero : ((global::Java.Lang.Object) index).Handle);
				__args [4] = new JniArgumentValue ((work == null) ? IntPtr.Zero : ((global::Java.Lang.Object) work).Handle);
				__args [5] = new JniArgumentValue (ignoreConflicts);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (ours);
				global::System.GC.KeepAlive (theirs);
				global::System.GC.KeepAlive (index);
				global::System.GC.KeepAlive (work);
			}
		}

		static Delegate cb_setCommitNames_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCommitNames_arrayLjava_lang_String_Handler ()
		{
			if (cb_setCommitNames_arrayLjava_lang_String_ == null)
				cb_setCommitNames_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCommitNames_arrayLjava_lang_String_);
			return cb_setCommitNames_arrayLjava_lang_String_;
		}

		static void n_SetCommitNames_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_commitNames)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commitNames = (string[]) JNIEnv.GetArray (native_commitNames, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetCommitNames (commitNames);
			if (commitNames != null)
				JNIEnv.CopyArray (commitNames, native_commitNames);
		}
#pragma warning restore 0169

		/// <param name="commitNames">the names of the commits as they would appear in conflict
		///            markers</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='setCommitNames' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setCommitNames", "([Ljava/lang/String;)V", "GetSetCommitNames_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetCommitNames (string[] commitNames)
		{
			const string __id = "setCommitNames.([Ljava/lang/String;)V";
			IntPtr native_commitNames = JNIEnv.NewArray (commitNames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_commitNames);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (commitNames != null) {
					JNIEnv.CopyArray (native_commitNames, commitNames);
					JNIEnv.DeleteLocalRef (native_commitNames);
				}
				global::System.GC.KeepAlive (commitNames);
			}
		}

		static Delegate cb_setDirCache_Lorg_eclipse_jgit_dircache_DirCache_;
#pragma warning disable 0169
		static Delegate GetSetDirCache_Lorg_eclipse_jgit_dircache_DirCache_Handler ()
		{
			if (cb_setDirCache_Lorg_eclipse_jgit_dircache_DirCache_ == null)
				cb_setDirCache_Lorg_eclipse_jgit_dircache_DirCache_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDirCache_Lorg_eclipse_jgit_dircache_DirCache_);
			return cb_setDirCache_Lorg_eclipse_jgit_dircache_DirCache_;
		}

		static void n_SetDirCache_Lorg_eclipse_jgit_dircache_DirCache_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (native_dc, JniHandleOwnership.DoNotTransfer);
			__this.SetDirCache (dc);
		}
#pragma warning restore 0169

		/// <param name="dc">the DirCache to set</param>
		/// <summary>Sets the DirCache which shall be used by this merger.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='setDirCache' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCache']]"
		[Register ("setDirCache", "(Lorg/eclipse/jgit/dircache/DirCache;)V", "GetSetDirCache_Lorg_eclipse_jgit_dircache_DirCache_Handler")]
		public virtual unsafe void SetDirCache (global::Org.Eclipse.Jgit.Dircache.DirCache dc)
		{
			const string __id = "setDirCache.(Lorg/eclipse/jgit/dircache/DirCache;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dc).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dc);
			}
		}

		static Delegate cb_setWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_;
#pragma warning disable 0169
		static Delegate GetSetWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Handler ()
		{
			if (cb_setWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ == null)
				cb_setWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_);
			return cb_setWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_;
		}

		static void n_SetWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_workingTreeIterator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ResolveMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var workingTreeIterator = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (native_workingTreeIterator, JniHandleOwnership.DoNotTransfer);
			__this.SetWorkingTreeIterator (workingTreeIterator);
		}
#pragma warning restore 0169

		/// <param name="workingTreeIterator">the workingTreeIt to set</param>
		/// <summary>Sets the WorkingTreeIterator to be used by this merger.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ResolveMerger']/method[@name='setWorkingTreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator']]"
		[Register ("setWorkingTreeIterator", "(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V", "GetSetWorkingTreeIterator_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Handler")]
		public virtual unsafe void SetWorkingTreeIterator (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator workingTreeIterator)
		{
			const string __id = "setWorkingTreeIterator.(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((workingTreeIterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) workingTreeIterator).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (workingTreeIterator);
			}
		}

	}
}
