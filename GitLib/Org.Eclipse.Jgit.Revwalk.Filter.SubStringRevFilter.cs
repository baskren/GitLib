using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk.Filter {

	/// <summary>Abstract filter that searches text using only substring search.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='SubStringRevFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/SubStringRevFilter", DoNotGenerateAcw=true)]
	public abstract partial class SubStringRevFilter : global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/SubStringRevFilter", typeof (SubStringRevFilter));

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

		protected SubStringRevFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="patternText">text to locate. This should be a safe string as described by
		///            the <c>#safe(String)</c> as regular expression meta
		///            characters are treated as literals.</param>
		/// <summary>Construct a new matching filter.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='SubStringRevFilter']/constructor[@name='SubStringRevFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe SubStringRevFilter (string patternText) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_patternText = JNIEnv.NewString ((string)patternText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_patternText);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_patternText);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.SubStringRevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walker = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walker, JniHandleOwnership.DoNotTransfer);
			var cmit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_cmit, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Include (walker, cmit);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='SubStringRevFilter']/method[@name='include' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
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

		/// <param name="pattern">the pattern text proposed by the user.</param>
		/// <summary>Can this string be safely handled by a substring filter?</summary>
		/// <returns>true if a substring filter can perform this pattern match; false
		///         if <c>PatternMatchRevFilter</c> must be used instead.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='SubStringRevFilter']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("safe", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool Safe (string pattern)
		{
			const string __id = "safe.(Ljava/lang/String;)Z";
			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pattern);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static Delegate cb_text_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetText_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_text_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_text_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Text_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_text_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static IntPtr n_Text_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.SubStringRevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_cmit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Text (cmit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="cmit">current commit being evaluated.</param>
		/// <summary>Obtain the raw text to match against.</summary>
		/// <returns>sequence for the commit's content that we need to match on.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='SubStringRevFilter']/method[@name='text' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("text", "(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/util/RawCharSequence;", "GetText_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		protected abstract global::Org.Eclipse.Jgit.Util.RawCharSequence Text (global::Org.Eclipse.Jgit.Revwalk.RevCommit cmit);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/SubStringRevFilter", DoNotGenerateAcw=true)]
	internal partial class SubStringRevFilterInvoker : SubStringRevFilter {
		public SubStringRevFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/SubStringRevFilter", typeof (SubStringRevFilterInvoker));

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

		/// <param name="cmit">current commit being evaluated.</param>
		/// <summary>Obtain the raw text to match against.</summary>
		/// <returns>sequence for the commit's content that we need to match on.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='SubStringRevFilter']/method[@name='text' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("text", "(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/util/RawCharSequence;", "GetText_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Util.RawCharSequence Text (global::Org.Eclipse.Jgit.Revwalk.RevCommit cmit)
		{
			const string __id = "text.(Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/util/RawCharSequence;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cmit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmit).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RawCharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cmit);
			}
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

	}
}
