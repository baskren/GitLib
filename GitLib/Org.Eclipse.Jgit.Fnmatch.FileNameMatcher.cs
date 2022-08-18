using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Fnmatch {

	/// <summary>This class can be used to match filenames against fnmatch like patterns.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.fnmatch']/class[@name='FileNameMatcher']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/fnmatch/FileNameMatcher", DoNotGenerateAcw=true)]
	public partial class FileNameMatcher : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/fnmatch/FileNameMatcher", typeof (FileNameMatcher));

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

		protected FileNameMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="patternString">must contain a pattern which fnmatch would accept.</param>
		/// <param name="invalidWildgetCharacter">if this parameter isn't null then this character will not
		///            match at wildcards(* and ? are wildcards).</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.fnmatch']/class[@name='FileNameMatcher']/constructor[@name='FileNameMatcher' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Character']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Character;)V", "")]
		public unsafe FileNameMatcher (string patternString, global::Java.Lang.Character invalidWildgetCharacter) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Character;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_patternString = JNIEnv.NewString ((string)patternString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_patternString);
				__args [1] = new JniArgumentValue ((invalidWildgetCharacter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) invalidWildgetCharacter).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_patternString);
				global::System.GC.KeepAlive (invalidWildgetCharacter);
			}
		}

		/// <param name="other">another <c>FileNameMatcher</c> instance.</param>
		/// <summary>A Copy Constructor which creates a new <c>FileNameMatcher</c> with the
		/// same state and reset point like &lt;code&gt;other&lt;/code&gt;.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.fnmatch']/class[@name='FileNameMatcher']/constructor[@name='FileNameMatcher' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.fnmatch.FileNameMatcher']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/fnmatch/FileNameMatcher;)V", "")]
		public unsafe FileNameMatcher (global::Org.Eclipse.Jgit.Fnmatch.FileNameMatcher other) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/fnmatch/FileNameMatcher;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		static Delegate cb_isMatch;
#pragma warning disable 0169
		static Delegate GetIsMatchHandler ()
		{
			if (cb_isMatch == null)
				cb_isMatch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMatch);
			return cb_isMatch;
		}

		static bool n_IsMatch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Fnmatch.FileNameMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMatch;
		}
#pragma warning restore 0169

		/// <returns>true, if the string currently being matched does match.</returns>
		public virtual unsafe bool IsMatch {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.fnmatch']/class[@name='FileNameMatcher']/method[@name='isMatch' and count(parameter)=0]"
			[Register ("isMatch", "()Z", "GetIsMatchHandler")]
			get {
				const string __id = "isMatch.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_append_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Handler ()
		{
			if (cb_append_Ljava_lang_String_ == null)
				cb_append_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Append_Ljava_lang_String_);
			return cb_append_Ljava_lang_String_;
		}

		static void n_Append_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stringToMatch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Fnmatch.FileNameMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var stringToMatch = JNIEnv.GetString (native_stringToMatch, JniHandleOwnership.DoNotTransfer);
			__this.Append (stringToMatch);
		}
#pragma warning restore 0169

		/// <param name="stringToMatch">extends the string which is matched against the patterns of
		///            this class.</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.fnmatch']/class[@name='FileNameMatcher']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("append", "(Ljava/lang/String;)V", "GetAppend_Ljava_lang_String_Handler")]
		public virtual unsafe void Append (string stringToMatch)
		{
			const string __id = "append.(Ljava/lang/String;)V";
			IntPtr native_stringToMatch = JNIEnv.NewString ((string)stringToMatch);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringToMatch);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringToMatch);
			}
		}

		static Delegate cb_canAppendMatch;
#pragma warning disable 0169
		static Delegate GetCanAppendMatchHandler ()
		{
			if (cb_canAppendMatch == null)
				cb_canAppendMatch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CanAppendMatch);
			return cb_canAppendMatch;
		}

		static bool n_CanAppendMatch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Fnmatch.FileNameMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanAppendMatch ();
		}
#pragma warning restore 0169

		/// <returns>false, if the string being matched will not match when the string
		///         gets extended.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.fnmatch']/class[@name='FileNameMatcher']/method[@name='canAppendMatch' and count(parameter)=0]"
		[Register ("canAppendMatch", "()Z", "GetCanAppendMatchHandler")]
		public virtual unsafe bool CanAppendMatch ()
		{
			const string __id = "canAppendMatch.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_createMatcherForSuffix;
#pragma warning disable 0169
		static Delegate GetCreateMatcherForSuffixHandler ()
		{
			if (cb_createMatcherForSuffix == null)
				cb_createMatcherForSuffix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateMatcherForSuffix);
			return cb_createMatcherForSuffix;
		}

		static IntPtr n_CreateMatcherForSuffix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Fnmatch.FileNameMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateMatcherForSuffix ());
		}
#pragma warning restore 0169

		/// <returns>a <c>FileNameMatcher</c> instance which uses the same pattern
		///         like this matcher, but has the current state of this matcher as
		///         reset and start point.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.fnmatch']/class[@name='FileNameMatcher']/method[@name='createMatcherForSuffix' and count(parameter)=0]"
		[Register ("createMatcherForSuffix", "()Lorg/eclipse/jgit/fnmatch/FileNameMatcher;", "GetCreateMatcherForSuffixHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Fnmatch.FileNameMatcher CreateMatcherForSuffix ()
		{
			const string __id = "createMatcherForSuffix.()Lorg/eclipse/jgit/fnmatch/FileNameMatcher;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Fnmatch.FileNameMatcher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Fnmatch.FileNameMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		/// <summary>Resets this matcher to it's state right after construction.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.fnmatch']/class[@name='FileNameMatcher']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
