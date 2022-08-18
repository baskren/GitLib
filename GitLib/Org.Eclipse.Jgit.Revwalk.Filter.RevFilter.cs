using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk.Filter {

	/// <summary>Selects interesting revisions during walking.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/RevFilter", DoNotGenerateAcw=true)]
	public abstract partial class RevFilter : global::Java.Lang.Object {

		/// <summary>Default filter that always returns true (thread safe).</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/field[@name='ALL']"
		[Register ("ALL")]
		public static global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter All {
			get {
				const string __id = "ALL.Lorg/eclipse/jgit/revwalk/filter/RevFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Selects only merge bases of the starting points (thread safe).</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/field[@name='MERGE_BASE']"
		[Register ("MERGE_BASE")]
		public static global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter MergeBase {
			get {
				const string __id = "MERGE_BASE.Lorg/eclipse/jgit/revwalk/filter/RevFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Default filter that always returns false (thread safe).</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter None {
			get {
				const string __id = "NONE.Lorg/eclipse/jgit/revwalk/filter/RevFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Excludes commits with more than one parent (thread safe).</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/field[@name='NO_MERGES']"
		[Register ("NO_MERGES")]
		public static global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter NoMerges {
			get {
				const string __id = "NO_MERGES.Lorg/eclipse/jgit/revwalk/filter/RevFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/RevFilter", typeof (RevFilter));

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

		protected RevFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/constructor[@name='RevFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RevFilter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		/// <summary>Clone this revision filter, including its parameters.</summary>
		/// <returns>another copy of this filter, suitable for another thread.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "GetCloneHandler")]
		public new virtual global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Clone ()
		{
			return (RevFilter)base.Clone();
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walker = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walker, JniHandleOwnership.DoNotTransfer);
			var cmit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_cmit, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Include (walker, cmit);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="walker">the active walker this filter is being invoked from within.</param>
		/// <param name="cmit">the commit currently being tested. The commit has been parsed
		///            and its body is available for inspection only if the filter
		///            returns true from <c>#requiresCommitBody()</c>.</param>
		/// <summary>Determine if the supplied commit should be included in results.</summary>
		/// <returns>true to include this commit in the results; false to have this
		///         commit be omitted entirely from the results.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/method[@name='include' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("include", "(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;)Z", "GetInclude_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public abstract bool Include (global::Org.Eclipse.Jgit.Revwalk.RevWalk walker, global::Org.Eclipse.Jgit.Revwalk.RevCommit cmit);

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Negate ());
		}
#pragma warning restore 0169

		/// <summary>Create a new filter that does the opposite of this filter.</summary>
		/// <returns>a new filter that includes commits this filter rejects.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/method[@name='negate' and count(parameter)=0]"
		[Register ("negate", "()Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "GetNegateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Negate ()
		{
			const string __id = "negate.()Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_requiresCommitBody;
#pragma warning disable 0169
		static Delegate GetRequiresCommitBodyHandler ()
		{
			if (cb_requiresCommitBody == null)
				cb_requiresCommitBody = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_RequiresCommitBody);
			return cb_requiresCommitBody;
		}

		static bool n_RequiresCommitBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiresCommitBody ();
		}
#pragma warning restore 0169

		/// <returns>true if the filter needs the commit body to be parsed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/method[@name='requiresCommitBody' and count(parameter)=0]"
		[Register ("requiresCommitBody", "()Z", "GetRequiresCommitBodyHandler")]
		public virtual unsafe bool RequiresCommitBody ()
		{
			const string __id = "requiresCommitBody.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/RevFilter", DoNotGenerateAcw=true)]
	internal partial class RevFilterInvoker : RevFilter {
		public RevFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/RevFilter", typeof (RevFilterInvoker));

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

		/// <summary>Clone this revision filter, including its parameters.</summary>
		/// <returns>another copy of this filter, suitable for another thread.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "GetCloneHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Clone ()
		{
			const string __id = "clone.()Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="walker">the active walker this filter is being invoked from within.</param>
		/// <param name="cmit">the commit currently being tested. The commit has been parsed
		///            and its body is available for inspection only if the filter
		///            returns true from <c>#requiresCommitBody()</c>.</param>
		/// <summary>Determine if the supplied commit should be included in results.</summary>
		/// <returns>true to include this commit in the results; false to have this
		///         commit be omitted entirely from the results.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/method[@name='include' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("include", "(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;)Z", "GetInclude_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public override unsafe bool Include (global::Org.Eclipse.Jgit.Revwalk.RevWalk walker, global::Org.Eclipse.Jgit.Revwalk.RevCommit cmit)
		{
			const string __id = "include.(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((walker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walker).Handle);
				__args [1] = new JniArgumentValue ((cmit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmit).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (walker);
				global::System.GC.KeepAlive (cmit);
			}
		}

	}
}
