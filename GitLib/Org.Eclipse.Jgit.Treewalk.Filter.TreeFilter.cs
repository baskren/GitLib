using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk.Filter {

	/// <summary>Selects interesting tree entries during walking.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/TreeFilter", DoNotGenerateAcw=true)]
	public abstract partial class TreeFilter : global::Java.Lang.Object {

		/// <summary>Selects all tree entries.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/field[@name='ALL']"
		[Register ("ALL")]
		public static global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter All {
			get {
				const string __id = "ALL.Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Selects only tree entries which differ between at least 2 trees.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/field[@name='ANY_DIFF']"
		[Register ("ANY_DIFF")]
		public static global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter AnyDiff {
			get {
				const string __id = "ANY_DIFF.Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/TreeFilter", typeof (TreeFilter));

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

		protected TreeFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/constructor[@name='TreeFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TreeFilter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		/// <summary>Clone this tree filter, including its parameters.</summary>
		/// <returns>another copy of this filter, suitable for another thread.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/method[@name='clone' and count(parameter)=0]"
		[Register("clone", "()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "GetCloneHandler")]
		public new virtual global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter Clone()
			=> (TreeFilter)base.Clone();

		static Delegate cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_;
#pragma warning disable 0169
		static Delegate GetInclude_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler ()
		{
			if (cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_ == null)
				cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Include_Lorg_eclipse_jgit_treewalk_TreeWalk_);
			return cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_;
		}

		static bool n_Include_Lorg_eclipse_jgit_treewalk_TreeWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walker = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (native_walker, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Include (walker);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="walker">the walker the filter needs to examine.</param>
		/// <summary>Determine if the current entry is interesting to report.</summary>
		/// <returns>true if the current entry should be seen by the application;
		///         false to hide the entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk']]"
		[Register ("include", "(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z", "GetInclude_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler")]
		public abstract bool Include (global::Org.Eclipse.Jgit.Treewalk.TreeWalk walker);

		static Delegate cb_negate;
#pragma warning disable 0169
		static Delegate GetNegateHandler ()
		{
			if (cb_negate == null)
				cb_negate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Negate);
			return cb_negate;
		}

		static IntPtr n_Negate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Negate ());
		}
#pragma warning restore 0169

		/// <summary>Create a new filter that does the opposite of this filter.</summary>
		/// <returns>a new filter that includes tree entries this filter rejects.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/method[@name='negate' and count(parameter)=0]"
		[Register ("negate", "()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "GetNegateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter Negate ()
		{
			const string __id = "negate.()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldBeRecursive ();
		}
#pragma warning restore 0169

		/// <summary>Does this tree filter require a recursive walk to match everything?</summary>
		/// <returns>true if the filter would like to have the walker recurse into
		///         subtrees to make sure it matches everything correctly; false if
		///         the filter does not require entering subtrees.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilter']/method[@name='shouldBeRecursive' and count(parameter)=0]"
		[Register ("shouldBeRecursive", "()Z", "GetShouldBeRecursiveHandler")]
		public abstract bool ShouldBeRecursive ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/TreeFilter", DoNotGenerateAcw=true)]
	internal partial class TreeFilterInvoker : TreeFilter {
		public TreeFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/TreeFilter", typeof (TreeFilterInvoker));

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
