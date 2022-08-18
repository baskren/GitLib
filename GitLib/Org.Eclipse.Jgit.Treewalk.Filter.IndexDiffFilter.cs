using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk.Filter {

	/// <summary>A performance optimized variant of <c>TreeFilter#ANY_DIFF</c> which should
	/// be used when among the walked trees there is a <c>DirCacheIterator</c> and a
	/// <c>WorkingTreeIterator</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='IndexDiffFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/IndexDiffFilter", DoNotGenerateAcw=true)]
	public partial class IndexDiffFilter : global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/IndexDiffFilter", typeof (IndexDiffFilter));

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

		protected IndexDiffFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="dirCacheIndex">the index of the <c>DirCacheIterator</c> in the associated
		///            treewalk</param>
		/// <param name="workingTreeIndex">the index of the <c>WorkingTreeIterator</c> in the associated
		///            treewalk</param>
		/// <summary>Creates a new instance of this filter.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='IndexDiffFilter']/constructor[@name='IndexDiffFilter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe IndexDiffFilter (int dirCacheIndex, int workingTreeIndex) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dirCacheIndex);
				__args [1] = new JniArgumentValue (workingTreeIndex);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		/// <param name="dirCacheIndex">the index of the <c>DirCacheIterator</c> in the associated
		///            treewalk</param>
		/// <param name="workingTreeIndex">the index of the <c>WorkingTreeIterator</c> in the associated
		///            treewalk</param>
		/// <param name="honorIgnores">true if the filter should skip working tree files that are
		///            declared as ignored by the standard exclude mechanisms..</param>
		/// <summary>Creates a new instance of this filter.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='IndexDiffFilter']/constructor[@name='IndexDiffFilter' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(IIZ)V", "")]
		public unsafe IndexDiffFilter (int dirCacheIndex, int workingTreeIndex, bool honorIgnores) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (dirCacheIndex);
				__args [1] = new JniArgumentValue (workingTreeIndex);
				__args [2] = new JniArgumentValue (honorIgnores);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getIgnoredPaths;
#pragma warning disable 0169
		static Delegate GetGetIgnoredPathsHandler ()
		{
			if (cb_getIgnoredPaths == null)
				cb_getIgnoredPaths = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIgnoredPaths);
			return cb_getIgnoredPaths;
		}

		static IntPtr n_GetIgnoredPaths (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.IndexDiffFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.IgnoredPaths);
		}
#pragma warning restore 0169

		/// <summary>The method returns the list of ignored files and folders.</summary>
		/// <returns>ignored paths</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> IgnoredPaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='IndexDiffFilter']/method[@name='getIgnoredPaths' and count(parameter)=0]"
			[Register ("getIgnoredPaths", "()Ljava/util/Set;", "GetGetIgnoredPathsHandler")]
			get {
				const string __id = "getIgnoredPaths.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUntrackedFolders;
#pragma warning disable 0169
		static Delegate GetGetUntrackedFoldersHandler ()
		{
			if (cb_getUntrackedFolders == null)
				cb_getUntrackedFolders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUntrackedFolders);
			return cb_getUntrackedFolders;
		}

		static IntPtr n_GetUntrackedFolders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.IndexDiffFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UntrackedFolders);
		}
#pragma warning restore 0169

		/// <returns>all paths of folders which contain only untracked files/folders.
		///         If on the associated treewalk postorder traversal was turned on
		///         (see <c>TreeWalk#setPostOrderTraversal(boolean)</c>) then an
		///         empty list will be returned.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> UntrackedFolders {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='IndexDiffFilter']/method[@name='getUntrackedFolders' and count(parameter)=0]"
			[Register ("getUntrackedFolders", "()Ljava/util/List;", "GetGetUntrackedFoldersHandler")]
			get {
				const string __id = "getUntrackedFolders.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_;
#pragma warning disable 0169
		static Delegate GetInclude_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler ()
		{
			if (cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_ == null)
				cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Include_Lorg_eclipse_jgit_treewalk_TreeWalk_);
			return cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_;
		}

		static bool n_Include_Lorg_eclipse_jgit_treewalk_TreeWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tw)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.IndexDiffFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tw = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (native_tw, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Include (tw);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='IndexDiffFilter']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk']]"
		[Register ("include", "(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z", "GetInclude_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler")]
		public override unsafe bool Include (global::Org.Eclipse.Jgit.Treewalk.TreeWalk tw)
		{
			const string __id = "include.(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tw == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tw).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (tw);
			}
		}

		static Delegate cb_shouldBeRecursive;
#pragma warning disable 0169
		static Delegate GetShouldBeRecursiveHandler ()
		{
			if (cb_shouldBeRecursive == null)
				cb_shouldBeRecursive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ShouldBeRecursive);
			return cb_shouldBeRecursive;
		}

		static bool n_ShouldBeRecursive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.IndexDiffFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldBeRecursive ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='IndexDiffFilter']/method[@name='shouldBeRecursive' and count(parameter)=0]"
		[Register ("shouldBeRecursive", "()Z", "GetShouldBeRecursiveHandler")]
		public override unsafe bool ShouldBeRecursive ()
		{
			const string __id = "shouldBeRecursive.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
