using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Ignore {

	/// <summary>A single ignore rule corresponding to one line in a .</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreRule']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/eclipse/jgit/ignore/IgnoreRule", DoNotGenerateAcw=true)]
	public partial class IgnoreRule : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/ignore/IgnoreRule", typeof (IgnoreRule));

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

		protected IgnoreRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="pattern">Base pattern for the ignore rule. This pattern will
		/// 			  be parsed to generate rule parameters.</param>
		/// <summary>Create a new ignore rule with the given pattern.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreRule']/constructor[@name='IgnoreRule' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe IgnoreRule (string pattern) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pattern);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static Delegate cb_getNameOnly;
#pragma warning disable 0169
		static Delegate GetGetNameOnlyHandler ()
		{
			if (cb_getNameOnly == null)
				cb_getNameOnly = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetNameOnly);
			return cb_getNameOnly;
		}

		static bool n_GetNameOnly (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NameOnly;
		}
#pragma warning restore 0169

		/// <returns>True if the pattern is just a file name and not a path</returns>
		public virtual unsafe bool NameOnly {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreRule']/method[@name='getNameOnly' and count(parameter)=0]"
			[Register ("getNameOnly", "()Z", "GetGetNameOnlyHandler")]
			get {
				const string __id = "getNameOnly.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNegation;
#pragma warning disable 0169
		static Delegate GetGetNegationHandler ()
		{
			if (cb_getNegation == null)
				cb_getNegation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetNegation);
			return cb_getNegation;
		}

		static bool n_GetNegation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Negation;
		}
#pragma warning restore 0169

		/// <returns>True if the pattern had a "!" in front of it</returns>
		public virtual unsafe bool Negation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreRule']/method[@name='getNegation' and count(parameter)=0]"
			[Register ("getNegation", "()Z", "GetGetNegationHandler")]
			get {
				const string __id = "getNegation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPattern;
#pragma warning disable 0169
		static Delegate GetGetPatternHandler ()
		{
			if (cb_getPattern == null)
				cb_getPattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPattern);
			return cb_getPattern;
		}

		static IntPtr n_GetPattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pattern);
		}
#pragma warning restore 0169

		/// <returns>The blob pattern to be used as a matcher</returns>
		public virtual unsafe string Pattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreRule']/method[@name='getPattern' and count(parameter)=0]"
			[Register ("getPattern", "()Ljava/lang/String;", "GetGetPatternHandler")]
			get {
				const string __id = "getPattern.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetResult);
			return cb_getResult;
		}

		static bool n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Result;
		}
#pragma warning restore 0169

		/// <summary>If a call to &lt;code&gt;isMatch(String, boolean)&lt;/code&gt; was previously
		/// made, this will return whether or not the target was ignored.</summary>
		/// <returns>True if the target is to be ignored, false otherwise.</returns>
		public virtual unsafe bool Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreRule']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Z", "GetGetResultHandler")]
			get {
				const string __id = "getResult.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_dirOnly;
#pragma warning disable 0169
		static Delegate GetDirOnlyHandler ()
		{
			if (cb_dirOnly == null)
				cb_dirOnly = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DirOnly);
			return cb_dirOnly;
		}

		static bool n_DirOnly (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DirOnly ();
		}
#pragma warning restore 0169

		/// <returns>True if the pattern should match directories only</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreRule']/method[@name='dirOnly' and count(parameter)=0]"
		[Register ("dirOnly", "()Z", "GetDirOnlyHandler")]
		public virtual unsafe bool DirOnly ()
		{
			const string __id = "dirOnly.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isMatch_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetIsMatch_Ljava_lang_String_ZHandler ()
		{
			if (cb_isMatch_Ljava_lang_String_Z == null)
				cb_isMatch_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_IsMatch_Ljava_lang_String_Z);
			return cb_isMatch_Ljava_lang_String_Z;
		}

		static bool n_IsMatch_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_target, bool isDirectory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMatch (target, isDirectory);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="target">Name pattern of the file, relative to the base directory of this rule</param>
		/// <param name="isDirectory">Whether the target file is a directory or not</param>
		/// <summary>Returns true if a match was made.</summary>
		/// <returns>True if a match was made. This does not necessarily mean that
		/// 			  the target is ignored. Call <c>IgnoreRule#getResult() getResult()</c> for the result.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreRule']/method[@name='isMatch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("isMatch", "(Ljava/lang/String;Z)Z", "GetIsMatch_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool IsMatch (string target, bool isDirectory)
		{
			const string __id = "isMatch.(Ljava/lang/String;Z)Z";
			IntPtr native_target = JNIEnv.NewString ((string)target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_target);
				__args [1] = new JniArgumentValue (isDirectory);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
			}
		}

	}
}
