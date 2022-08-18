using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk {

	/// <summary>Walks one or more <c>AbstractTreeIterator</c>s in parallel.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/TreeWalk", DoNotGenerateAcw=true)]
	public partial class TreeWalk : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/TreeWalk", typeof (TreeWalk));

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

		protected TreeWalk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="or">the reader the walker will obtain tree data from.</param>
		/// <summary>Create a new tree walker for a given repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/constructor[@name='TreeWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectReader;)V", "")]
		public unsafe TreeWalk (global::Org.Eclipse.Jgit.Lib.ObjectReader or) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectReader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((or == null) ? IntPtr.Zero : ((global::Java.Lang.Object) or).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (or);
			}
		}

		/// <param name="repo">the repository the walker will obtain data from.</param>
		/// <summary>Create a new tree walker for a given repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/constructor[@name='TreeWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe TreeWalk (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_getDepth;
#pragma warning disable 0169
		static Delegate GetGetDepthHandler ()
		{
			if (cb_getDepth == null)
				cb_getDepth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDepth);
			return cb_getDepth;
		}

		static int n_GetDepth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Depth;
		}
#pragma warning restore 0169

		/// <summary>Get the current subtree depth of this walker.</summary>
		/// <returns>the current subtree depth of this walker.</returns>
		public virtual unsafe int Depth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getDepth' and count(parameter)=0]"
			[Register ("getDepth", "()I", "GetGetDepthHandler")]
			get {
				const string __id = "getDepth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFilter;
#pragma warning disable 0169
		static Delegate GetGetFilterHandler ()
		{
			if (cb_getFilter == null)
				cb_getFilter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFilter);
			return cb_getFilter;
		}

		static IntPtr n_GetFilter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Filter);
		}
#pragma warning restore 0169

		static Delegate cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
#pragma warning disable 0169
		static Delegate GetSetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler ()
		{
			if (cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ == null)
				cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_);
			return cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
		}

		static void n_SetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newFilter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newFilter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (native_newFilter, JniHandleOwnership.DoNotTransfer);
			__this.Filter = newFilter;
		}
#pragma warning restore 0169

		/// <summary>Get the currently configured filter. -or- Set the tree entry filter for this walker.</summary>
		/// <returns>the current filter. Never null as a filter is always needed.</returns>
		/// <param name="newFilter">the new filter. If null the special <c>TreeFilter#ALL</c>
		///            filter will be used instead, as it matches every entry.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "GetGetFilterHandler")]
			get {
				const string __id = "getFilter.()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.filter.TreeFilter']]"
			[Register ("setFilter", "(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V", "GetSetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler")]
			set {
				const string __id = "setFilter.(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isPostChildren;
#pragma warning disable 0169
		static Delegate GetIsPostChildrenHandler ()
		{
			if (cb_isPostChildren == null)
				cb_isPostChildren = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPostChildren);
			return cb_isPostChildren;
		}

		static bool n_IsPostChildren (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPostChildren;
		}
#pragma warning restore 0169

		/// <summary>Is the current entry a subtree returned after its children?</summary>
		/// <returns>true if the current node is a tree that has been returned after
		///         its children were already processed.</returns>
		public virtual unsafe bool IsPostChildren {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='isPostChildren' and count(parameter)=0]"
			[Register ("isPostChildren", "()Z", "GetIsPostChildrenHandler")]
			get {
				const string __id = "isPostChildren.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSubtree;
#pragma warning disable 0169
		static Delegate GetIsSubtreeHandler ()
		{
			if (cb_isSubtree == null)
				cb_isSubtree = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSubtree);
			return cb_isSubtree;
		}

		static bool n_IsSubtree (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSubtree;
		}
#pragma warning restore 0169

		/// <summary>Is the current entry a subtree?</summary>
		/// <returns>true if <c>#enterSubtree()</c> will work on the current node.</returns>
		public virtual unsafe bool IsSubtree {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='isSubtree' and count(parameter)=0]"
			[Register ("isSubtree", "()Z", "GetIsSubtreeHandler")]
			get {
				const string __id = "isSubtree.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNameString;
#pragma warning disable 0169
		static Delegate GetGetNameStringHandler ()
		{
			if (cb_getNameString == null)
				cb_getNameString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNameString);
			return cb_getNameString;
		}

		static IntPtr n_GetNameString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NameString);
		}
#pragma warning restore 0169

		/// <summary>Get the current entry's name within its parent tree.</summary>
		/// <returns>name of the current entry within the parent tree (or directory).
		///         The name never includes a '/'.</returns>
		public virtual unsafe string NameString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getNameString' and count(parameter)=0]"
			[Register ("getNameString", "()Ljava/lang/String;", "GetGetNameStringHandler")]
			get {
				const string __id = "getNameString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectReader;
#pragma warning disable 0169
		static Delegate GetGetObjectReaderHandler ()
		{
			if (cb_getObjectReader == null)
				cb_getObjectReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectReader);
			return cb_getObjectReader;
		}

		static IntPtr n_GetObjectReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectReader);
		}
#pragma warning restore 0169

		/// <returns>the reader this walker is using to load objects.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader ObjectReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getObjectReader' and count(parameter)=0]"
			[Register ("getObjectReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetGetObjectReaderHandler")]
			get {
				const string __id = "getObjectReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPathLength;
#pragma warning disable 0169
		static Delegate GetGetPathLengthHandler ()
		{
			if (cb_getPathLength == null)
				cb_getPathLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPathLength);
			return cb_getPathLength;
		}

		static int n_GetPathLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PathLength;
		}
#pragma warning restore 0169

		/// <returns>The path length of the current entry.</returns>
		public virtual unsafe int PathLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getPathLength' and count(parameter)=0]"
			[Register ("getPathLength", "()I", "GetGetPathLengthHandler")]
			get {
				const string __id = "getPathLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPathString;
#pragma warning disable 0169
		static Delegate GetGetPathStringHandler ()
		{
			if (cb_getPathString == null)
				cb_getPathString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPathString);
			return cb_getPathString;
		}

		static IntPtr n_GetPathString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PathString);
		}
#pragma warning restore 0169

		/// <summary>Get the current entry's complete path.</summary>
		/// <returns>complete path of the current entry, from the root of the
		///         repository. If the current entry is in a subtree there will be at
		///         least one '/' in the returned string.</returns>
		public virtual unsafe string PathString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getPathString' and count(parameter)=0]"
			[Register ("getPathString", "()Ljava/lang/String;", "GetGetPathStringHandler")]
			get {
				const string __id = "getPathString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isPostOrderTraversal;
#pragma warning disable 0169
		static Delegate GetIsPostOrderTraversalHandler ()
		{
			if (cb_isPostOrderTraversal == null)
				cb_isPostOrderTraversal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPostOrderTraversal);
			return cb_isPostOrderTraversal;
		}

		static bool n_IsPostOrderTraversal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PostOrderTraversal;
		}
#pragma warning restore 0169

		static Delegate cb_setPostOrderTraversal_Z;
#pragma warning disable 0169
		static Delegate GetSetPostOrderTraversal_ZHandler ()
		{
			if (cb_setPostOrderTraversal_Z == null)
				cb_setPostOrderTraversal_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPostOrderTraversal_Z);
			return cb_setPostOrderTraversal_Z;
		}

		static void n_SetPostOrderTraversal_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostOrderTraversal = b;
		}
#pragma warning restore 0169

		/// <summary>Does this walker return a tree entry after it exits the subtree? -or- Set the walker to return trees after their children.</summary>
		/// <returns>true if subtrees are returned after entries within the subtree.</returns>
		/// <param name="b">true to get trees after their children.</param>
		public virtual unsafe bool PostOrderTraversal {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='isPostOrderTraversal' and count(parameter)=0]"
			[Register ("isPostOrderTraversal", "()Z", "GetIsPostOrderTraversalHandler")]
			get {
				const string __id = "isPostOrderTraversal.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='setPostOrderTraversal' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPostOrderTraversal", "(Z)V", "GetSetPostOrderTraversal_ZHandler")]
			set {
				const string __id = "setPostOrderTraversal.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRecursive;
#pragma warning disable 0169
		static Delegate GetIsRecursiveHandler ()
		{
			if (cb_isRecursive == null)
				cb_isRecursive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRecursive);
			return cb_isRecursive;
		}

		static bool n_IsRecursive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Recursive;
		}
#pragma warning restore 0169

		static Delegate cb_setRecursive_Z;
#pragma warning disable 0169
		static Delegate GetSetRecursive_ZHandler ()
		{
			if (cb_setRecursive_Z == null)
				cb_setRecursive_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetRecursive_Z);
			return cb_setRecursive_Z;
		}

		static void n_SetRecursive_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recursive = b;
		}
#pragma warning restore 0169

		/// <summary>Is this walker automatically entering into subtrees? -or- Set the walker to enter (or not enter) subtrees automatically.</summary>
		/// <returns>true if automatically entering subtrees is enabled.</returns>
		/// <param name="b">true to skip subtree nodes and only obtain files nodes.</param>
		public virtual unsafe bool Recursive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='isRecursive' and count(parameter)=0]"
			[Register ("isRecursive", "()Z", "GetIsRecursiveHandler")]
			get {
				const string __id = "isRecursive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='setRecursive' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRecursive", "(Z)V", "GetSetRecursive_ZHandler")]
			set {
				const string __id = "setRecursive.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTreeCount;
#pragma warning disable 0169
		static Delegate GetGetTreeCountHandler ()
		{
			if (cb_getTreeCount == null)
				cb_getTreeCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTreeCount);
			return cb_getTreeCount;
		}

		static int n_GetTreeCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TreeCount;
		}
#pragma warning restore 0169

		/// <summary>Get the number of trees known to this walker.</summary>
		/// <returns>the total number of trees this walker is iterating over.</returns>
		public virtual unsafe int TreeCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getTreeCount' and count(parameter)=0]"
			[Register ("getTreeCount", "()I", "GetGetTreeCountHandler")]
			get {
				const string __id = "getTreeCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAddTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_addTree_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_addTree_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_AddTree_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_addTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static int n_AddTree_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddTree (id);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">identity of the tree object the caller wants walked.</param>
		/// <summary>Add an already existing tree object for walking.</summary>
		/// <returns>position of this tree within the walker.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='addTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("addTree", "(Lorg/eclipse/jgit/lib/AnyObjectId;)I", "GetAddTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe int AddTree (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "addTree.(Lorg/eclipse/jgit/lib/AnyObjectId;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_addTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
#pragma warning disable 0169
		static Delegate GetAddTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler ()
		{
			if (cb_addTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ == null)
				cb_addTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_AddTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_);
			return cb_addTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
		}

		static int n_AddTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_p, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddTree (p);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="p">an iterator to walk over. The iterator should be new, with no
		///            parent, and should still be positioned before the first entry.
		///            The tree which the iterator operates on must have the same root
		///            as other trees in the walk.</param>
		/// <summary>Add an already created tree iterator for walking.</summary>
		/// <returns>position of this tree within the walker.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='addTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register ("addTree", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)I", "GetAddTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler")]
		public virtual unsafe int AddTree (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator p)
		{
			const string __id = "addTree.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p);
			}
		}

		static Delegate cb_enterSubtree;
#pragma warning disable 0169
		static Delegate GetEnterSubtreeHandler ()
		{
			if (cb_enterSubtree == null)
				cb_enterSubtree = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EnterSubtree);
			return cb_enterSubtree;
		}

		static void n_EnterSubtree (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnterSubtree ();
		}
#pragma warning restore 0169

		/// <summary>Enter into the current subtree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='enterSubtree' and count(parameter)=0]"
		[Register ("enterSubtree", "()V", "GetEnterSubtreeHandler")]
		public virtual unsafe void EnterSubtree ()
		{
			const string __id = "enterSubtree.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='forPath' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.lib.AnyObjectId...']]"
		[Register ("forPath", "(Lorg/eclipse/jgit/lib/ObjectReader;Ljava/lang/String;[Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/TreeWalk;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.TreeWalk ForPath (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, string path, params global::Org.Eclipse.Jgit.Lib.AnyObjectId[] trees)
		{
			const string __id = "forPath.(Lorg/eclipse/jgit/lib/ObjectReader;Ljava/lang/String;[Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/TreeWalk;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			IntPtr native_trees = JNIEnv.NewArray (trees);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue (native_trees);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				if (trees != null) {
					JNIEnv.CopyArray (native_trees, trees);
					JNIEnv.DeleteLocalRef (native_trees);
				}
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (trees);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='forPath' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.lib.AnyObjectId...']]"
		[Register ("forPath", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;[Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/TreeWalk;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.TreeWalk ForPath (global::Org.Eclipse.Jgit.Lib.Repository db, string path, params global::Org.Eclipse.Jgit.Lib.AnyObjectId[] trees)
		{
			const string __id = "forPath.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;[Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/TreeWalk;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			IntPtr native_trees = JNIEnv.NewArray (trees);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue (native_trees);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				if (trees != null) {
					JNIEnv.CopyArray (native_trees, trees);
					JNIEnv.DeleteLocalRef (native_trees);
				}
				global::System.GC.KeepAlive (db);
				global::System.GC.KeepAlive (trees);
			}
		}

		/// <param name="db">repository to read tree object data from.</param>
		/// <param name="path">single path to advance the tree walk instance into.</param>
		/// <param name="tree">the single tree to walk through.</param>
		/// <summary>Open a tree walk and filter to exactly one path.</summary>
		/// <returns>a new tree walk configured for exactly this one path; null if no
		///         path was found in any of the trees.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='forPath' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.revwalk.RevTree']]"
		[Register ("forPath", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/revwalk/RevTree;)Lorg/eclipse/jgit/treewalk/TreeWalk;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.TreeWalk ForPath (global::Org.Eclipse.Jgit.Lib.Repository db, string path, global::Org.Eclipse.Jgit.Revwalk.RevTree tree)
		{
			const string __id = "forPath.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/revwalk/RevTree;)Lorg/eclipse/jgit/treewalk/TreeWalk;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue ((tree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tree).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (db);
				global::System.GC.KeepAlive (tree);
			}
		}

		static Delegate cb_getFileMode_I;
#pragma warning disable 0169
		static Delegate GetGetFileMode_IHandler ()
		{
			if (cb_getFileMode_I == null)
				cb_getFileMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetFileMode_I);
			return cb_getFileMode_I;
		}

		static IntPtr n_GetFileMode_I (IntPtr jnienv, IntPtr native__this, int nth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFileMode (nth));
		}
#pragma warning restore 0169

		/// <param name="nth">tree to obtain the mode from.</param>
		/// <summary>Obtain the <c>FileMode</c> for the current entry.</summary>
		/// <returns>mode for the current entry of the nth tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getFileMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFileMode", "(I)Lorg/eclipse/jgit/lib/FileMode;", "GetGetFileMode_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode GetFileMode (int nth)
		{
			const string __id = "getFileMode.(I)Lorg/eclipse/jgit/lib/FileMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getObjectId_I;
#pragma warning disable 0169
		static Delegate GetGetObjectId_IHandler ()
		{
			if (cb_getObjectId_I == null)
				cb_getObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetObjectId_I);
			return cb_getObjectId_I;
		}

		static IntPtr n_GetObjectId_I (IntPtr jnienv, IntPtr native__this, int nth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObjectId (nth));
		}
#pragma warning restore 0169

		/// <param name="nth">tree to obtain the object identifier from.</param>
		/// <summary>Obtain the ObjectId for the current entry.</summary>
		/// <returns>object identifier for the current tree entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getObjectId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObjectId", "(I)Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObjectId_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId GetObjectId (int nth)
		{
			const string __id = "getObjectId.(I)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_I;
#pragma warning disable 0169
		static Delegate GetGetObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_IHandler ()
		{
			if (cb_getObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_I == null)
				cb_getObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_GetObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_I);
			return cb_getObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_I;
		}

		static void n_GetObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native__out, int nth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.GetObjectId (@out, nth);
		}
#pragma warning restore 0169

		/// <param name="out">buffer to copy the object id into.</param>
		/// <param name="nth">tree to obtain the object identifier from.</param>
		/// <summary>Obtain the ObjectId for the current entry.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getObjectId' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.MutableObjectId'] and parameter[2][@type='int']]"
		[Register ("getObjectId", "(Lorg/eclipse/jgit/lib/MutableObjectId;I)V", "GetGetObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_IHandler")]
		public virtual unsafe void GetObjectId (global::Org.Eclipse.Jgit.Lib.MutableObjectId @out, int nth)
		{
			const string __id = "getObjectId.(Lorg/eclipse/jgit/lib/MutableObjectId;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue (nth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_getRawMode_I;
#pragma warning disable 0169
		static Delegate GetGetRawMode_IHandler ()
		{
			if (cb_getRawMode_I == null)
				cb_getRawMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRawMode_I);
			return cb_getRawMode_I;
		}

		static int n_GetRawMode_I (IntPtr jnienv, IntPtr native__this, int nth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRawMode (nth);
		}
#pragma warning restore 0169

		/// <param name="nth">tree to obtain the mode bits from.</param>
		/// <summary>Obtain the raw <c>FileMode</c> bits for the current entry.</summary>
		/// <returns>mode bits for the current entry of the nth tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getRawMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRawMode", "(I)I", "GetGetRawMode_IHandler")]
		public virtual unsafe int GetRawMode (int nth)
		{
			const string __id = "getRawMode.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nth);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getRawPath;
#pragma warning disable 0169
		static Delegate GetGetRawPathHandler ()
		{
			if (cb_getRawPath == null)
				cb_getRawPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawPath);
			return cb_getRawPath;
		}

		static IntPtr n_GetRawPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRawPath ());
		}
#pragma warning restore 0169

		/// <summary>Get the current entry's complete path as a UTF-8 byte array.</summary>
		/// <returns>complete path of the current entry, from the root of the
		///         repository. If the current entry is in a subtree there will be at
		///         least one '/' in the returned string.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getRawPath' and count(parameter)=0]"
		[Register ("getRawPath", "()[B", "GetGetRawPathHandler")]
		public virtual unsafe byte[] GetRawPath ()
		{
			const string __id = "getRawPath.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getTree_ILjava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetTree_ILjava_lang_Class_Handler ()
		{
			if (cb_getTree_ILjava_lang_Class_ == null)
				cb_getTree_ILjava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_GetTree_ILjava_lang_Class_);
			return cb_getTree_ILjava_lang_Class_;
		}

		static IntPtr n_GetTree_ILjava_lang_Class_ (IntPtr jnienv, IntPtr native__this, int nth, IntPtr native_clazz)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTree (nth, clazz));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="&lt;T&gt;">type of the tree iterator expected by the caller.</param>
		/// <param name="nth">tree to obtain the current iterator of.</param>
		/// <param name="clazz">type of the tree iterator expected by the caller.</param>
		/// <summary>Obtain the tree iterator for the current entry.</summary>
		/// <returns>r the current iterator of the requested type; null if the tree
		///         has no entry to match the current path.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='getTree' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getTree", "(ILjava/lang/Class;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;", "GetGetTree_ILjava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.treewalk.AbstractTreeIterator"})]
		public virtual unsafe global::Java.Lang.Object GetTree (int nth, global::Java.Lang.Class clazz)
		{
			const string __id = "getTree.(ILjava/lang/Class;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (nth);
				__args [1] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (clazz);
			}
		}

		static Delegate cb_idEqual_II;
#pragma warning disable 0169
		static Delegate GetIdEqual_IIHandler ()
		{
			if (cb_idEqual_II == null)
				cb_idEqual_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_Z) n_IdEqual_II);
			return cb_idEqual_II;
		}

		static bool n_IdEqual_II (IntPtr jnienv, IntPtr native__this, int nthA, int nthB)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdEqual (nthA, nthB);
		}
#pragma warning restore 0169

		/// <param name="nthA">first tree to compare the object id from.</param>
		/// <param name="nthB">second tree to compare the object id from.</param>
		/// <summary>Compare two tree's current ObjectId values for equality.</summary>
		/// <returns>result of
		///         &lt;code&gt;getObjectId(nthA).equals(getObjectId(nthB))&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='idEqual' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("idEqual", "(II)Z", "GetIdEqual_IIHandler")]
		public virtual unsafe bool IdEqual (int nthA, int nthB)
		{
			const string __id = "idEqual.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (nthA);
				__args [1] = new JniArgumentValue (nthB);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isPathPrefix_arrayBI;
#pragma warning disable 0169
		static Delegate GetIsPathPrefix_arrayBIHandler ()
		{
			if (cb_isPathPrefix_arrayBI == null)
				cb_isPathPrefix_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_IsPathPrefix_arrayBI);
			return cb_isPathPrefix_arrayBI;
		}

		static int n_IsPathPrefix_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p, int pLen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = (byte[]) JNIEnv.GetArray (native_p, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.IsPathPrefix (p, pLen);
			if (p != null)
				JNIEnv.CopyArray (p, native_p);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="p">path buffer to test. Callers should ensure the path does not
		///            end with '/' prior to invocation.</param>
		/// <param name="pLen">number of bytes from &lt;code&gt;buf&lt;/code&gt; to test.</param>
		/// <summary>Test if the supplied path matches the current entry's path.</summary>
		/// <returns>&amp;lt; 0 if p is before the current path; 0 if p matches the current
		///         path; 1 if the current path is past p and p will never match
		///         again on this tree walk.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='isPathPrefix' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("isPathPrefix", "([BI)I", "GetIsPathPrefix_arrayBIHandler")]
		public virtual unsafe int IsPathPrefix (byte[] p, int pLen)
		{
			const string __id = "isPathPrefix.([BI)I";
			IntPtr native_p = JNIEnv.NewArray (p);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p);
				__args [1] = new JniArgumentValue (pLen);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p != null) {
					JNIEnv.CopyArray (native_p, p);
					JNIEnv.DeleteLocalRef (native_p);
				}
				global::System.GC.KeepAlive (p);
			}
		}

		static Delegate cb_isPathSuffix_arrayBI;
#pragma warning disable 0169
		static Delegate GetIsPathSuffix_arrayBIHandler ()
		{
			if (cb_isPathSuffix_arrayBI == null)
				cb_isPathSuffix_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_IsPathSuffix_arrayBI);
			return cb_isPathSuffix_arrayBI;
		}

		static bool n_IsPathSuffix_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p, int pLen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = (byte[]) JNIEnv.GetArray (native_p, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.IsPathSuffix (p, pLen);
			if (p != null)
				JNIEnv.CopyArray (p, native_p);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="p">path buffer to test.</param>
		/// <param name="pLen">number of bytes from &lt;code&gt;buf&lt;/code&gt; to test.</param>
		/// <summary>Test if the supplied path matches (being suffix of) the current entry's
		/// path.</summary>
		/// <returns>true if p is suffix of the current path;
		///         false if otherwise</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='isPathSuffix' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("isPathSuffix", "([BI)Z", "GetIsPathSuffix_arrayBIHandler")]
		public virtual unsafe bool IsPathSuffix (byte[] p, int pLen)
		{
			const string __id = "isPathSuffix.([BI)Z";
			IntPtr native_p = JNIEnv.NewArray (p);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p);
				__args [1] = new JniArgumentValue (pLen);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p != null) {
					JNIEnv.CopyArray (native_p, p);
					JNIEnv.DeleteLocalRef (native_p);
				}
				global::System.GC.KeepAlive (p);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Next ();
		}
#pragma warning restore 0169

		/// <summary>Advance this walker to the next relevant entry.</summary>
		/// <returns>true if there is an entry available; false if all entries have
		///         been walked and the walk of this set of tree iterators is over.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='next' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		/// <summary>Release any resources used by this walker's reader.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		/// <summary>Reset this walker so new tree iterators can be added to it.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reset_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetReset_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_reset_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_reset_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Reset_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_reset_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Reset_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.Reset (id);
		}
#pragma warning restore 0169

		/// <param name="id">the tree we need to parse. The walker will execute over this
		///            single tree if the reset is successful.</param>
		/// <summary>Reset this walker to run over a single existing tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("reset", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetReset_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void Reset (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "reset.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_reset_arrayLorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetReset_arrayLorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_reset_arrayLorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_reset_arrayLorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Reset_arrayLorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_reset_arrayLorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Reset_arrayLorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ids)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ids = (global::Org.Eclipse.Jgit.Lib.AnyObjectId[]) JNIEnv.GetArray (native_ids, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Lib.AnyObjectId));
			__this.Reset (ids);
			if (ids != null)
				JNIEnv.CopyArray (ids, native_ids);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='TreeWalk']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId...']]"
		[Register ("reset", "([Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetReset_arrayLorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void Reset (params global::Org.Eclipse.Jgit.Lib.AnyObjectId[] ids)
		{
			const string __id = "reset.([Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			IntPtr native_ids = JNIEnv.NewArray (ids);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ids);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (ids != null) {
					JNIEnv.CopyArray (native_ids, ids);
					JNIEnv.DeleteLocalRef (native_ids);
				}
				global::System.GC.KeepAlive (ids);
			}
		}

	}
}
