using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Miscellaneous string comparison utility methods.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/StringUtils", DoNotGenerateAcw=true)]
	public sealed partial class StringUtils : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/StringUtils", typeof (StringUtils));

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

		internal StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="a">first string to compare.</param>
		/// <param name="b">second string to compare.</param>
		/// <summary>Compare two strings, ignoring case.</summary>
		/// <returns>negative, zero or positive if a sorts before, is equal to, or
		///         sorts after b.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='compareIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compareIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CompareIgnoreCase (string a, string b)
		{
			const string __id = "compareIgnoreCase.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_a = JNIEnv.NewString ((string)a);
			IntPtr native_b = JNIEnv.NewString ((string)b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_a);
				__args [1] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				JNIEnv.DeleteLocalRef (native_b);
			}
		}

		/// <param name="a">first string to compare.</param>
		/// <param name="b">second string to compare.</param>
		/// <summary>Compare two strings, honoring case.</summary>
		/// <returns>negative, zero or positive if a sorts before, is equal to, or
		///         sorts after b.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='compareWithCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compareWithCase", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CompareWithCase (string a, string b)
		{
			const string __id = "compareWithCase.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_a = JNIEnv.NewString ((string)a);
			IntPtr native_b = JNIEnv.NewString ((string)b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_a);
				__args [1] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				JNIEnv.DeleteLocalRef (native_b);
			}
		}

		/// <param name="a">first string to compare.</param>
		/// <param name="b">second string to compare.</param>
		/// <summary>Test if two strings are equal, ignoring case.</summary>
		/// <returns>true if a equals b</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='equalsIgnoreCase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("equalsIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool EqualsIgnoreCase (string a, string b)
		{
			const string __id = "equalsIgnoreCase.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_a = JNIEnv.NewString ((string)a);
			IntPtr native_b = JNIEnv.NewString ((string)b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_a);
				__args [1] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				JNIEnv.DeleteLocalRef (native_b);
			}
		}

		/// <param name="stringValue">the string to check</param>
		/// <summary>Test if a string is empty or null.</summary>
		/// <returns>&lt;code&gt;true&lt;/code&gt; if the string is &lt;code&gt;null&lt;/code&gt; or empty</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='isEmptyOrNull' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmptyOrNull", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsEmptyOrNull (string stringValue)
		{
			const string __id = "isEmptyOrNull.(Ljava/lang/String;)Z";
			IntPtr native_stringValue = JNIEnv.NewString ((string)stringValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringValue);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringValue);
			}
		}

		/// <param name="parts">Strings to join</param>
		/// <param name="separator">used to join</param>
		/// <summary>Join a collection of Strings together using the specified separator.</summary>
		/// <returns>a String with all the joined parts</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("join", "(Ljava/util/Collection;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Join (global::System.Collections.Generic.ICollection<string> parts, string separator)
		{
			const string __id = "join.(Ljava/util/Collection;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_parts = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (parts);
			IntPtr native_separator = JNIEnv.NewString ((string)separator);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_parts);
				__args [1] = new JniArgumentValue (native_separator);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_parts);
				JNIEnv.DeleteLocalRef (native_separator);
				global::System.GC.KeepAlive (parts);
			}
		}

		/// <param name="parts">Strings to join</param>
		/// <param name="separator">separator used to join all but the two last elements</param>
		/// <param name="lastSeparator">separator to use for joining the last two elements</param>
		/// <summary>Join a collection of Strings together using the specified separator and a
		/// lastSeparator which is used for joining the second last and the last
		/// part.</summary>
		/// <returns>a String with all the joined parts</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='join' and count(parameter)=3 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("join", "(Ljava/util/Collection;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Join (global::System.Collections.Generic.ICollection<string> parts, string separator, string lastSeparator)
		{
			const string __id = "join.(Ljava/util/Collection;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_parts = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (parts);
			IntPtr native_separator = JNIEnv.NewString ((string)separator);
			IntPtr native_lastSeparator = JNIEnv.NewString ((string)lastSeparator);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_parts);
				__args [1] = new JniArgumentValue (native_separator);
				__args [2] = new JniArgumentValue (native_lastSeparator);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_parts);
				JNIEnv.DeleteLocalRef (native_separator);
				JNIEnv.DeleteLocalRef (native_lastSeparator);
				global::System.GC.KeepAlive (parts);
			}
		}

		/// <param name="in">A string with line breaks</param>
		/// <summary>Replace CRLF, CR or LF with a single space.</summary>
		/// <returns>in without line breaks</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='replaceLineBreaksWithSpace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("replaceLineBreaksWithSpace", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReplaceLineBreaksWithSpace (string @in)
		{
			const string __id = "replaceLineBreaksWithSpace.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__in = JNIEnv.NewString ((string)@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		/// <param name="stringValue">the string to parse.</param>
		/// <summary>Parse a string as a standard Git boolean value.</summary>
		/// <returns>the boolean interpretation of <c>value</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='toBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toBoolean", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ToBoolean (string stringValue)
		{
			const string __id = "toBoolean.(Ljava/lang/String;)Z";
			IntPtr native_stringValue = JNIEnv.NewString ((string)stringValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringValue);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_stringValue);
			}
		}

		/// <param name="stringValue">the string to parse.</param>
		/// <summary>Parse a string as a standard Git boolean value.</summary>
		/// <returns>the boolean interpretation of <c>value</c> or null in case the
		///         string does not represent a boolean value</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='toBooleanOrNull' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toBooleanOrNull", "(Ljava/lang/String;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean ToBooleanOrNull (string stringValue)
		{
			const string __id = "toBooleanOrNull.(Ljava/lang/String;)Ljava/lang/Boolean;";
			IntPtr native_stringValue = JNIEnv.NewString ((string)stringValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringValue);
			}
		}

		/// <param name="c">the input character.</param>
		/// <summary>Convert the input to lowercase.</summary>
		/// <returns>lowercase version of the input.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='toLowerCase' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("toLowerCase", "(C)C", "")]
		public static unsafe char ToLowerCase (char c)
		{
			const string __id = "toLowerCase.(C)C";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeCharMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		/// <param name="in">the input string. Must not be null.</param>
		/// <summary>Convert the input string to lower case, according to the "C" locale.</summary>
		/// <returns>a copy of the input string, after converting characters in the
		///         range 'A'..'Z' to 'a'..'z'.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='StringUtils']/method[@name='toLowerCase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toLowerCase", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToLowerCase (string @in)
		{
			const string __id = "toLowerCase.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__in = JNIEnv.NewString ((string)@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

	}
}
