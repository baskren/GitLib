using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk.Filter {

	/// <summary>Skip <c>WorkingTreeIterator</c> entries that appear in gitignore files.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='NotIgnoredFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/NotIgnoredFilter", DoNotGenerateAcw=true)]
	public partial class NotIgnoredFilter : global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/NotIgnoredFilter", typeof (NotIgnoredFilter));

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

		protected NotIgnoredFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="workdirTreeIndex">index of the workdir tree in the tree walk</param>
		/// <summary>Construct a filter to ignore paths known to a particular iterator.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='NotIgnoredFilter']/constructor[@name='NotIgnoredFilter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NotIgnoredFilter (int workdirTreeIndex) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (workdirTreeIndex);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.NotIgnoredFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tw = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (native_tw, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Include (tw);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='NotIgnoredFilter']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.NotIgnoredFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldBeRecursive ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='NotIgnoredFilter']/method[@name='shouldBeRecursive' and count(parameter)=0]"
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
