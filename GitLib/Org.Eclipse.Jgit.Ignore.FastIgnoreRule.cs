using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Ignore {

	/// <summary>"Fast" (compared with IgnoreRule) git ignore rule implementation supporting
	/// also double star &lt;code&gt;**&lt;code&gt; pattern.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='FastIgnoreRule']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/ignore/FastIgnoreRule", DoNotGenerateAcw=true)]
	public partial class FastIgnoreRule : global::Java.Lang.Object {
		/// <summary>Character used as default path separator for ignore entries</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='FastIgnoreRule']/field[@name='PATH_SEPARATOR']"
		[Register ("PATH_SEPARATOR")]
		public const char PathSeparator = (char) (char)47;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/ignore/FastIgnoreRule", typeof (FastIgnoreRule));

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

		protected FastIgnoreRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="pattern">ignore pattern as described in <see href="https://www.kernel.org/pub/software/scm/git/docs/gitignore.html">git manual</see>. If pattern is invalid or is not a pattern
		///            (comment), this rule doesn't match anything.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='FastIgnoreRule']/constructor[@name='FastIgnoreRule' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe FastIgnoreRule (string pattern) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NameOnly;
		}
#pragma warning restore 0169

		/// <returns>True if the pattern is just a file name and not a path</returns>
		public virtual unsafe bool NameOnly {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='FastIgnoreRule']/method[@name='getNameOnly' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Negation;
		}
#pragma warning restore 0169

		/// <summary>Indicates whether the rule is non-negation or negation.</summary>
		/// <returns>True if the pattern had a "!" in front of it</returns>
		public virtual unsafe bool Negation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='FastIgnoreRule']/method[@name='getNegation' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Result;
		}
#pragma warning restore 0169

		/// <summary>Indicates whether the rule is non-negation or negation.</summary>
		/// <returns>True if the target is to be ignored, false otherwise.</returns>
		public virtual unsafe bool Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='FastIgnoreRule']/method[@name='getResult' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DirOnly ();
		}
#pragma warning restore 0169

		/// <returns>True if the pattern should match directories only</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='FastIgnoreRule']/method[@name='dirOnly' and count(parameter)=0]"
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

		static bool n_IsMatch_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_path, bool directory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMatch (path, directory);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">Name pattern of the file, relative to the base directory of
		///            this rule</param>
		/// <param name="directory">Whether the target file is a directory or not</param>
		/// <summary>Returns true if a match was made.</summary>
		/// <returns>True if a match was made. This does not necessarily mean that the
		///         target is ignored. Call <c>#getResult() getResult()</c> for the
		///         result.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='FastIgnoreRule']/method[@name='isMatch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("isMatch", "(Ljava/lang/String;Z)Z", "GetIsMatch_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool IsMatch (string path, bool directory)
		{
			const string __id = "isMatch.(Ljava/lang/String;Z)Z";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (directory);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

	}
}
