using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Ignore.Internal {

	[Register ("org/eclipse/jgit/ignore/internal/IMatcher", DoNotGenerateAcw=true)]
	public abstract class Matcher : Java.Lang.Object {
		internal Matcher ()
		{
		}


		/// <summary>Matcher that does not match any pattern.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/interface[@name='IMatcher']/field[@name='NO_MATCH']"
		[Register ("NO_MATCH")]
		public static global::Org.Eclipse.Jgit.Ignore.Internal.IMatcher NoMatch {
			get {
				const string __id = "NO_MATCH.Lorg/eclipse/jgit/ignore/internal/IMatcher;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.Internal.IMatcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/ignore/internal/IMatcher", typeof (Matcher));

	}

	[Register ("org/eclipse/jgit/ignore/internal/IMatcher", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Matcher' type. This type will be removed in a future release.", error: true)]
	public abstract class MatcherConsts : Matcher {
		private MatcherConsts ()
		{
		}

	}

	/// <summary>Generic string matcher</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/interface[@name='IMatcher']"
	[Register ("org/eclipse/jgit/ignore/internal/IMatcher", "", "Org.Eclipse.Jgit.Ignore.Internal.IMatcherInvoker")]
	public partial interface IMatcher : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/interface[@name='IMatcher']/method[@name='matches' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		/// <param name="path">string which is not null, but might be empty</param>
		/// <param name="assumeDirectory">true to assume this path as directory (even if it doesn't end
		///            with a slash)</param>
		/// <summary>Matches entire given string</summary>
		/// <returns>true if this matcher pattern matches given string</returns>
		[Register ("matches", "(Ljava/lang/String;Z)Z", "GetMatches_Ljava_lang_String_ZHandler:Org.Eclipse.Jgit.Ignore.Internal.IMatcherInvoker, AndroidBindableLibrary")]
		bool Matches (string path, bool assumeDirectory);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/interface[@name='IMatcher']/method[@name='matches' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		/// <param name="segment">string which is not null, but might be empty</param>
		/// <param name="startIncl">start index, inclusive</param>
		/// <param name="endExcl">end index, exclusive</param>
		/// <param name="assumeDirectory">true to assume this path as directory (even if it doesn't end
		///            with a slash)</param>
		/// <summary>Matches only part of given string</summary>
		/// <returns>true if this matcher pattern matches given string</returns>
		[Register ("matches", "(Ljava/lang/String;IIZ)Z", "GetMatches_Ljava_lang_String_IIZHandler:Org.Eclipse.Jgit.Ignore.Internal.IMatcherInvoker, AndroidBindableLibrary")]
		bool Matches (string segment, int startIncl, int endExcl, bool assumeDirectory);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/ignore/internal/IMatcher", DoNotGenerateAcw=true)]
	internal partial class IMatcherInvoker : global::Java.Lang.Object, IMatcher {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/ignore/internal/IMatcher", typeof (IMatcherInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMatcher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMatcher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.ignore.internal.IMatcher'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMatcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.Internal.IMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Matches (path, assumeDirectory);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_matches_Ljava_lang_String_Z;
		public unsafe bool Matches (string path, bool assumeDirectory)
		{
			if (id_matches_Ljava_lang_String_Z == IntPtr.Zero)
				id_matches_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "matches", "(Ljava/lang/String;Z)Z");
			IntPtr native_path = JNIEnv.NewString ((string)path);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_path);
			__args [1] = new JValue (assumeDirectory);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_path);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.Internal.IMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var segment = JNIEnv.GetString (native_segment, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Matches (segment, startIncl, endExcl, assumeDirectory);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_matches_Ljava_lang_String_IIZ;
		public unsafe bool Matches (string segment, int startIncl, int endExcl, bool assumeDirectory)
		{
			if (id_matches_Ljava_lang_String_IIZ == IntPtr.Zero)
				id_matches_Ljava_lang_String_IIZ = JNIEnv.GetMethodID (class_ref, "matches", "(Ljava/lang/String;IIZ)Z");
			IntPtr native_segment = JNIEnv.NewString ((string)segment);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_segment);
			__args [1] = new JValue (startIncl);
			__args [2] = new JValue (endExcl);
			__args [3] = new JValue (assumeDirectory);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Ljava_lang_String_IIZ, __args);
			JNIEnv.DeleteLocalRef (native_segment);
			return __ret;
		}

	}
}
