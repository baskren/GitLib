using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Utility class for character functions on raw bytes</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharUtil']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/RawCharUtil", DoNotGenerateAcw=true)]
	public partial class RawCharUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/RawCharUtil", typeof (RawCharUtil));

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

		protected RawCharUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="c">the 8-bit US-ASCII encoded character</param>
		/// <summary>Determine if an 8-bit US-ASCII encoded character is represents whitespace</summary>
		/// <returns>true if c represents a whitespace character in 8-bit US-ASCII</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharUtil']/method[@name='isWhitespace' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isWhitespace", "(B)Z", "")]
		public static unsafe bool IsWhitespace (sbyte c)
		{
			const string __id = "isWhitespace.(B)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		/// <param name="raw">the byte array containing the portion to trim whitespace for</param>
		/// <param name="start">the start of the section of bytes</param>
		/// <param name="end">the end of the section of bytes</param>
		/// <summary>Returns the new start point for the byte array passed in after trimming
		/// any leading whitespace characters, as determined by the isWhitespace()
		/// function.</summary>
		/// <returns>the new start point</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharUtil']/method[@name='trimLeadingWhitespace' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("trimLeadingWhitespace", "([BII)I", "")]
		public static unsafe int TrimLeadingWhitespace (byte[] raw, int start, int end)
		{
			const string __id = "trimLeadingWhitespace.([BII)I";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="raw">the byte array containing the portion to trim whitespace for</param>
		/// <param name="start">the start of the section of bytes</param>
		/// <param name="end">the end of the section of bytes</param>
		/// <summary>Returns the new end point for the byte array passed in after trimming any
		/// trailing whitespace characters, as determined by the isWhitespace()
		/// function.</summary>
		/// <returns>the new end point</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharUtil']/method[@name='trimTrailingWhitespace' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("trimTrailingWhitespace", "([BII)I", "")]
		public static unsafe int TrimTrailingWhitespace (byte[] raw, int start, int end)
		{
			const string __id = "trimTrailingWhitespace.([BII)I";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

	}
}
