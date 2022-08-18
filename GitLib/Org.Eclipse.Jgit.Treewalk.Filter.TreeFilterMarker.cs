using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk.Filter {

	/// <summary>For testing an array of <c>TreeFilter</c> during a <c>TreeWalk</c> for each
	/// entry and returning the result as a bitmask.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilterMarker']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/TreeFilterMarker", DoNotGenerateAcw=true)]
	public partial class TreeFilterMarker : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/TreeFilterMarker", typeof (TreeFilterMarker));

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

		protected TreeFilterMarker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="markTreeFilters">the filters to use for marking, must not have more elements
		///            than <c>Integer#SIZE</c>.</param>
		/// <summary>Construct a TreeFilterMarker.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilterMarker']/constructor[@name='TreeFilterMarker' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.filter.TreeFilter[]']]"
		[Register (".ctor", "([Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V", "")]
		public unsafe TreeFilterMarker (global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter[] markTreeFilters) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_markTreeFilters = JNIEnv.NewArray (markTreeFilters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_markTreeFilters);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (markTreeFilters != null) {
					JNIEnv.CopyArray (native_markTreeFilters, markTreeFilters);
					JNIEnv.DeleteLocalRef (native_markTreeFilters);
				}
				global::System.GC.KeepAlive (markTreeFilters);
			}
		}

		static Delegate cb_getMarks_Lorg_eclipse_jgit_treewalk_TreeWalk_;
#pragma warning disable 0169
		static Delegate GetGetMarks_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler ()
		{
			if (cb_getMarks_Lorg_eclipse_jgit_treewalk_TreeWalk_ == null)
				cb_getMarks_Lorg_eclipse_jgit_treewalk_TreeWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetMarks_Lorg_eclipse_jgit_treewalk_TreeWalk_);
			return cb_getMarks_Lorg_eclipse_jgit_treewalk_TreeWalk_;
		}

		static int n_GetMarks_Lorg_eclipse_jgit_treewalk_TreeWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walk)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilterMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMarks (walk);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="walk">the walk from which to test the current entry</param>
		/// <summary>Test the filters against the walk.</summary>
		/// <returns>the marks bitmask</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='TreeFilterMarker']/method[@name='getMarks' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk']]"
		[Register ("getMarks", "(Lorg/eclipse/jgit/treewalk/TreeWalk;)I", "GetGetMarks_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler")]
		public virtual unsafe int GetMarks (global::Org.Eclipse.Jgit.Treewalk.TreeWalk walk)
		{
			const string __id = "getMarks.(Lorg/eclipse/jgit/treewalk/TreeWalk;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (walk);
			}
		}

	}
}
