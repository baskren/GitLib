using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Attributes {

	/// <summary>A single attributes rule corresponding to one line in a .</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesRule']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/attributes/AttributesRule", DoNotGenerateAcw=true)]
	public partial class AttributesRule : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/attributes/AttributesRule", typeof (AttributesRule));

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

		protected AttributesRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="pattern">Base pattern for the attributes rule. This pattern will be
		///            parsed to generate rule parameters. It can not be
		///            &lt;code&gt;null&lt;/code&gt;.</param>
		/// <param name="attributes">the rule attributes. This string will be parsed to read the
		///            attributes.</param>
		/// <summary>Create a new attribute rule with the given pattern.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesRule']/constructor[@name='AttributesRule' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AttributesRule (string pattern, string attributes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			IntPtr native_attributes = JNIEnv.NewString ((string)attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_pattern);
				__args [1] = new JniArgumentValue (native_attributes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
				JNIEnv.DeleteLocalRef (native_attributes);
			}
		}

		static Delegate cb_getAttributes;
#pragma warning disable 0169
		static Delegate GetGetAttributesHandler ()
		{
			if (cb_getAttributes == null)
				cb_getAttributes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAttributes);
			return cb_getAttributes;
		}

		static IntPtr n_GetAttributes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Attributes.Attribute>.ToLocalJniHandle (__this.Attributes);
		}
#pragma warning restore 0169

		/// <summary>Returns the attributes.</summary>
		/// <returns>an unmodifiable list of attributes (never returns
		///         &lt;code&gt;null&lt;/code&gt;)</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Attributes.Attribute> Attributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesRule']/method[@name='getAttributes' and count(parameter)=0]"
			[Register ("getAttributes", "()Ljava/util/List;", "GetGetAttributesHandler")]
			get {
				const string __id = "getAttributes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Attributes.Attribute>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isNameOnly;
#pragma warning disable 0169
		static Delegate GetIsNameOnlyHandler ()
		{
			if (cb_isNameOnly == null)
				cb_isNameOnly = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNameOnly);
			return cb_isNameOnly;
		}

		static bool n_IsNameOnly (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNameOnly;
		}
#pragma warning restore 0169

		/// <returns>&lt;code&gt;true&lt;/code&gt; if the pattern is just a file name and not a
		///         path</returns>
		public virtual unsafe bool IsNameOnly {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesRule']/method[@name='isNameOnly' and count(parameter)=0]"
			[Register ("isNameOnly", "()Z", "GetIsNameOnlyHandler")]
			get {
				const string __id = "isNameOnly.()Z";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pattern);
		}
#pragma warning restore 0169

		/// <returns>The blob pattern to be used as a matcher (never returns
		///         &lt;code&gt;null&lt;/code&gt;)</returns>
		public virtual unsafe string Pattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesRule']/method[@name='getPattern' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DirOnly ();
		}
#pragma warning restore 0169

		/// <returns>True if the pattern should match directories only</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesRule']/method[@name='dirOnly' and count(parameter)=0]"
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

		static bool n_IsMatch_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_relativeTarget, bool isDirectory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var relativeTarget = JNIEnv.GetString (native_relativeTarget, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMatch (relativeTarget, isDirectory);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="relativeTarget">Name pattern of the file, relative to the base directory of
		///            this rule</param>
		/// <param name="isDirectory">Whether the target file is a directory or not</param>
		/// <summary>Returns &lt;code&gt;true&lt;/code&gt; if a match was made.</summary>
		/// <returns>True if a match was made.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesRule']/method[@name='isMatch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("isMatch", "(Ljava/lang/String;Z)Z", "GetIsMatch_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool IsMatch (string relativeTarget, bool isDirectory)
		{
			const string __id = "isMatch.(Ljava/lang/String;Z)Z";
			IntPtr native_relativeTarget = JNIEnv.NewString ((string)relativeTarget);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_relativeTarget);
				__args [1] = new JniArgumentValue (isDirectory);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_relativeTarget);
			}
		}

	}
}
