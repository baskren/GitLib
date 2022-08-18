using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk.Filter {

	/// <summary>Abstract filter that searches text using extended regular expressions.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='PatternMatchRevFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/PatternMatchRevFilter", DoNotGenerateAcw=true)]
	public abstract partial class PatternMatchRevFilter : global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/PatternMatchRevFilter", typeof (PatternMatchRevFilter));

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

		protected PatternMatchRevFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="pattern">text of the pattern. Callers may want to surround their
		///            pattern with ".*" on either end to allow matching in the
		///            middle of the string.</param>
		/// <param name="innerString">should .* be wrapped around the pattern of ^ and $ are
		///            missing? Most users will want this set.</param>
		/// <param name="rawEncoding">should <c>#forceToRaw(String)</c> be applied to the pattern
		///            before compiling it?</param>
		/// <param name="flags">flags from <c>Pattern</c> to control how matching performs.</param>
		/// <summary>Construct a new pattern matching filter.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='PatternMatchRevFilter']/constructor[@name='PatternMatchRevFilter' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;ZZI)V", "")]
		protected unsafe PatternMatchRevFilter (string pattern, bool innerString, bool rawEncoding, int flags) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;ZZI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_pattern);
				__args [1] = new JniArgumentValue (innerString);
				__args [2] = new JniArgumentValue (rawEncoding);
				__args [3] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		/// <param name="patternText">original pattern string supplied by the user or the
		///            application.</param>
		/// <summary>Encode a string pattern for faster matching on byte arrays.</summary>
		/// <returns>same pattern, but re-encoded to match our funny raw UTF-8
		///         character sequence <c>RawCharSequence</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='PatternMatchRevFilter']/method[@name='forceToRaw' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("forceToRaw", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static unsafe string ForceToRaw (string patternText)
		{
			const string __id = "forceToRaw.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_patternText = JNIEnv.NewString ((string)patternText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_patternText);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.PatternMatchRevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walker = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walker, JniHandleOwnership.DoNotTransfer);
			var cmit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_cmit, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Include (walker, cmit);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='PatternMatchRevFilter']/method[@name='include' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
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

		static Delegate cb_pattern;
#pragma warning disable 0169
		static Delegate GetPatternHandler ()
		{
			if (cb_pattern == null)
				cb_pattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Pattern);
			return cb_pattern;
		}

		static IntPtr n_Pattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.PatternMatchRevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pattern ());
		}
#pragma warning restore 0169

		/// <summary>Get the pattern this filter uses.</summary>
		/// <returns>the pattern this filter is applying to candidate strings.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='PatternMatchRevFilter']/method[@name='pattern' and count(parameter)=0]"
		[Register ("pattern", "()Ljava/lang/String;", "GetPatternHandler")]
		public virtual unsafe string Pattern ()
		{
			const string __id = "pattern.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.PatternMatchRevFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_cmit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = CharSequence.ToLocalJniHandle (__this.TextFormatted (cmit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="cmit">current commit being evaluated.</param>
		/// <summary>Obtain the raw text to match against.</summary>
		/// <returns>sequence for the commit's content that we need to match on.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='PatternMatchRevFilter']/method[@name='text' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("text", "(Lorg/eclipse/jgit/revwalk/RevCommit;)Ljava/lang/CharSequence;", "GetText_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		protected abstract global::Java.Lang.ICharSequence TextFormatted (global::Org.Eclipse.Jgit.Revwalk.RevCommit cmit);

		/// <param name="cmit">current commit being evaluated.</param>
		/// <summary>Obtain the raw text to match against.</summary>
		/// <returns>sequence for the commit's content that we need to match on.</returns>
		protected string Text (global::Org.Eclipse.Jgit.Revwalk.RevCommit cmit)
		{
			global::Java.Lang.ICharSequence __result = TextFormatted (cmit);
			var __rsval = __result?.ToString ();
			return __rsval;
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/PatternMatchRevFilter", DoNotGenerateAcw=true)]
	internal partial class PatternMatchRevFilterInvoker : PatternMatchRevFilter {
		public PatternMatchRevFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/PatternMatchRevFilter", typeof (PatternMatchRevFilterInvoker));

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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='PatternMatchRevFilter']/method[@name='text' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("text", "(Lorg/eclipse/jgit/revwalk/RevCommit;)Ljava/lang/CharSequence;", "GetText_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		protected override unsafe global::Java.Lang.ICharSequence TextFormatted (global::Org.Eclipse.Jgit.Revwalk.RevCommit cmit)
		{
			const string __id = "text.(Lorg/eclipse/jgit/revwalk/RevCommit;)Ljava/lang/CharSequence;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cmit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmit).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
