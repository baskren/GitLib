using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk.Filter {

	/// <summary>Includes tree entries only if they end with the configured path (suffix
	/// match).</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='PathSuffixFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/PathSuffixFilter", DoNotGenerateAcw=true)]
	public partial class PathSuffixFilter : global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/PathSuffixFilter", typeof (PathSuffixFilter));

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

		protected PathSuffixFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="path">the path suffix to filter on. Must not be the empty string.</param>
		/// <summary>Create a new tree filter for a user supplied path suffix.</summary>
		/// <returns>a new filter for the requested path.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='PathSuffixFilter']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lorg/eclipse/jgit/treewalk/filter/PathSuffixFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.PathSuffixFilter Create (string path)
		{
			const string __id = "create.(Ljava/lang/String;)Lorg/eclipse/jgit/treewalk/filter/PathSuffixFilter;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.PathSuffixFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
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

		static bool n_Include_Lorg_eclipse_jgit_treewalk_TreeWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.PathSuffixFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walker = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (native_walker, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Include (walker);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='PathSuffixFilter']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk']]"
		[Register ("include", "(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z", "GetInclude_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler")]
		public override unsafe bool Include (global::Org.Eclipse.Jgit.Treewalk.TreeWalk walker)
		{
			const string __id = "include.(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((walker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walker).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (walker);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.PathSuffixFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldBeRecursive ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='PathSuffixFilter']/method[@name='shouldBeRecursive' and count(parameter)=0]"
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
