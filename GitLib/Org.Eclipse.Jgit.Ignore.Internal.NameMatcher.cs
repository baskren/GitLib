using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Ignore.Internal {

	/// <summary>Matcher built from patterns for file names (single path segments).</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='NameMatcher']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/ignore/internal/NameMatcher", DoNotGenerateAcw=true)]
	public partial class NameMatcher : global::Org.Eclipse.Jgit.Ignore.Internal.AbstractMatcher {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/ignore/internal/NameMatcher", typeof (NameMatcher));

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

		protected NameMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_matches_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetMatches_Ljava_lang_String_ZHandler ()
		{
			if (cb_matches_Ljava_lang_String_Z == null)
				cb_matches_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_Matches_Ljava_lang_String_Z);
			return cb_matches_Ljava_lang_String_Z;
		}

		static bool n_Matches_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_path, bool assumeDirectory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.Internal.NameMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Matches (path, assumeDirectory);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='NameMatcher']/method[@name='matches' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("matches", "(Ljava/lang/String;Z)Z", "GetMatches_Ljava_lang_String_ZHandler")]
		public override unsafe bool Matches (string path, bool assumeDirectory)
		{
			const string __id = "matches.(Ljava/lang/String;Z)Z";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (assumeDirectory);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_matches_Ljava_lang_String_IIZ;
#pragma warning disable 0169
		static Delegate GetMatches_Ljava_lang_String_IIZHandler ()
		{
			if (cb_matches_Ljava_lang_String_IIZ == null)
				cb_matches_Ljava_lang_String_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZ_Z) n_Matches_Ljava_lang_String_IIZ);
			return cb_matches_Ljava_lang_String_IIZ;
		}

		static bool n_Matches_Ljava_lang_String_IIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_segment, int startIncl, int endExcl, bool assumeDirectory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.Internal.NameMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var segment = JNIEnv.GetString (native_segment, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Matches (segment, startIncl, endExcl, assumeDirectory);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='NameMatcher']/method[@name='matches' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("matches", "(Ljava/lang/String;IIZ)Z", "GetMatches_Ljava_lang_String_IIZHandler")]
		public override unsafe bool Matches (string segment, int startIncl, int endExcl, bool assumeDirectory)
		{
			const string __id = "matches.(Ljava/lang/String;IIZ)Z";
			IntPtr native_segment = JNIEnv.NewString ((string)segment);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_segment);
				__args [1] = new JniArgumentValue (startIncl);
				__args [2] = new JniArgumentValue (endExcl);
				__args [3] = new JniArgumentValue (assumeDirectory);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_segment);
			}
		}

	}
}
