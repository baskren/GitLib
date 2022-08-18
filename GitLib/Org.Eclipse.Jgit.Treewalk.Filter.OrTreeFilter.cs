using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk.Filter {

	/// <summary>Includes a tree entry if any subfilters include the same tree entry.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='OrTreeFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/OrTreeFilter", DoNotGenerateAcw=true)]
	public abstract partial class OrTreeFilter : global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/OrTreeFilter", typeof (OrTreeFilter));

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

		protected OrTreeFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='OrTreeFilter']/constructor[@name='OrTreeFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OrTreeFilter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="list">list of filters to match against. Must contain at least 2
		///            filters.</param>
		/// <summary>Create a filter around many filters, one of which must match.</summary>
		/// <returns>a filter that must match at least one input filter.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='OrTreeFilter']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.treewalk.filter.TreeFilter&gt;']]"
		[Register ("create", "(Ljava/util/Collection;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter Create (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> list)
		{
			const string __id = "create.(Ljava/util/Collection;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
			IntPtr native_list = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter>.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (list);
			}
		}

		/// <param name="a">first filter to test.</param>
		/// <param name="b">second filter to test.</param>
		/// <summary>Create a filter with two filters, one of which must match.</summary>
		/// <returns>a filter that must match at least one input filter.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='OrTreeFilter']/method[@name='create' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.treewalk.filter.TreeFilter'] and parameter[2][@type='org.eclipse.jgit.treewalk.filter.TreeFilter']]"
		[Register ("create", "(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter Create (global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter a, global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter b)
		{
			const string __id = "create.(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="list">list of filters to match against. Must contain at least 2
		///            filters.</param>
		/// <summary>Create a filter around many filters, one of which must match.</summary>
		/// <returns>a filter that must match at least one input filter.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='OrTreeFilter']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.filter.TreeFilter[]']]"
		[Register ("create", "([Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter Create (global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter[] list)
		{
			const string __id = "create.([Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
			IntPtr native_list = JNIEnv.NewArray (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (list != null) {
					JNIEnv.CopyArray (native_list, list);
					JNIEnv.DeleteLocalRef (native_list);
				}
				global::System.GC.KeepAlive (list);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/OrTreeFilter", DoNotGenerateAcw=true)]
	internal partial class OrTreeFilterInvoker : OrTreeFilter {
		public OrTreeFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/OrTreeFilter", typeof (OrTreeFilterInvoker));

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

		/// <summary>Clone this tree filter, including its parameters.</summary>
		/// <returns>another copy of this filter, suitable for another thread.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "GetCloneHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter Clone ()
		{
			const string __id = "clone.()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="walker">the walker the filter needs to examine.</param>
		/// <summary>Determine if the current entry is interesting to report.</summary>
		/// <returns>true if the current entry should be seen by the application;
		///         false to hide the entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk']]"
		[Register ("include", "(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z", "GetInclude_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler")]
		public override unsafe bool Include (global::Org.Eclipse.Jgit.Treewalk.TreeWalk walker)
		{
			const string __id = "include.(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((walker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walker).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (walker);
			}
		}

		/// <summary>Does this tree filter require a recursive walk to match everything?</summary>
		/// <returns>true if the filter would like to have the walker recurse into
		///         subtrees to make sure it matches everything correctly; false if
		///         the filter does not require entering subtrees.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/method[@name='shouldBeRecursive' and count(parameter)=0]"
		[Register ("shouldBeRecursive", "()Z", "GetShouldBeRecursiveHandler")]
		public override unsafe bool ShouldBeRecursive ()
		{
			const string __id = "shouldBeRecursive.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
