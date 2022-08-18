using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Searches text using only substring search.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawSubStringPattern']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/RawSubStringPattern", DoNotGenerateAcw=true)]
	public partial class RawSubStringPattern : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/RawSubStringPattern", typeof (RawSubStringPattern));

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

		protected RawSubStringPattern (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="patternText">text to locate. This should be a literal string, as no
		///            meta-characters are supported by this implementation. The
		///            string may not be the empty string.</param>
		/// <summary>Construct a new substring pattern.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawSubStringPattern']/constructor[@name='RawSubStringPattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RawSubStringPattern (string patternText) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_match_Lorg_eclipse_jgit_util_RawCharSequence_;
#pragma warning disable 0169
		static Delegate GetMatch_Lorg_eclipse_jgit_util_RawCharSequence_Handler ()
		{
			if (cb_match_Lorg_eclipse_jgit_util_RawCharSequence_ == null)
				cb_match_Lorg_eclipse_jgit_util_RawCharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_Match_Lorg_eclipse_jgit_util_RawCharSequence_);
			return cb_match_Lorg_eclipse_jgit_util_RawCharSequence_;
		}

		static int n_Match_Lorg_eclipse_jgit_util_RawCharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rcs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RawSubStringPattern> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rcs = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RawCharSequence> (native_rcs, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Match (rcs);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="rcs">the sequence to match. Must not be null but the length of the
		///            sequence is permitted to be 0.</param>
		/// <summary>Match a character sequence against this pattern.</summary>
		/// <returns>offset within &lt;code&gt;rcs&lt;/code&gt; of the first occurrence of this
		///         pattern; -1 if this pattern does not appear at any position of
		///         &lt;code&gt;rcs&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawSubStringPattern']/method[@name='match' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.RawCharSequence']]"
		[Register ("match", "(Lorg/eclipse/jgit/util/RawCharSequence;)I", "GetMatch_Lorg_eclipse_jgit_util_RawCharSequence_Handler")]
		public virtual unsafe int Match (global::Org.Eclipse.Jgit.Util.RawCharSequence rcs)
		{
			const string __id = "match.(Lorg/eclipse/jgit/util/RawCharSequence;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rcs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rcs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (rcs);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RawSubStringPattern> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pattern ());
		}
#pragma warning restore 0169

		/// <summary>Get the literal pattern string this instance searches for.</summary>
		/// <returns>the pattern string given to our constructor.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawSubStringPattern']/method[@name='pattern' and count(parameter)=0]"
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

	}
}
