using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk.Filter {

	/// <summary>Limits the number of commits output.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='MaxCountRevFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/MaxCountRevFilter", DoNotGenerateAcw=true)]
	public partial class MaxCountRevFilter : global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/MaxCountRevFilter", typeof (MaxCountRevFilter));

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

		protected MaxCountRevFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="maxCount">the limit</param>
		/// <summary>Create a new max count filter.</summary>
		/// <returns>a new filter</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='MaxCountRevFilter']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("create", "(I)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Create (int maxCount)
		{
			const string __id = "create.(I)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxCount);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_include_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetInclude_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_include_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_include_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_Include_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_include_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static bool n_Include_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walker, IntPtr native_cmit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.MaxCountRevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walker = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walker, JniHandleOwnership.DoNotTransfer);
			var cmit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_cmit, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Include (walker, cmit);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='MaxCountRevFilter']/method[@name='include' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("include", "(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;)Z", "GetInclude_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public override unsafe bool Include (global::Org.Eclipse.Jgit.Revwalk.RevWalk walker, global::Org.Eclipse.Jgit.Revwalk.RevCommit cmit)
		{
			const string __id = "include.(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((walker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walker).Handle);
				__args [1] = new JniArgumentValue ((cmit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (walker);
				global::System.GC.KeepAlive (cmit);
			}
		}

	}
}
