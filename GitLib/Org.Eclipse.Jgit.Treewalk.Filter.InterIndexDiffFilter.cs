using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk.Filter {

	/// <summary>A filter for extracting changes between two versions of the dircache.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='InterIndexDiffFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/InterIndexDiffFilter", DoNotGenerateAcw=true)]
	public sealed partial class InterIndexDiffFilter : global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter {

		/// <summary>Predefined InterIndexDiffFilter for finding changes between two dircaches</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='InterIndexDiffFilter']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter Instance {
			get {
				const string __id = "INSTANCE.Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/InterIndexDiffFilter", typeof (InterIndexDiffFilter));

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

		internal InterIndexDiffFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='InterIndexDiffFilter']/constructor[@name='InterIndexDiffFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InterIndexDiffFilter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='InterIndexDiffFilter']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk']]"
		[Register ("include", "(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z", "")]
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='InterIndexDiffFilter']/method[@name='shouldBeRecursive' and count(parameter)=0]"
		[Register ("shouldBeRecursive", "()Z", "")]
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
