using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Ignore.Internal {

	/// <summary>Various <c>String</c> related utility methods, written mostly to avoid
	/// generation of new String objects (e.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='Strings']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/ignore/internal/Strings", DoNotGenerateAcw=true)]
	public partial class Strings : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/ignore/internal/Strings", typeof (Strings));

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

		protected Strings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='Strings']/constructor[@name='Strings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Strings () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		/// <param name="pattern">non null</param>
		/// <param name="slash">separator char</param>
		/// <summary>Splits given string to substrings by given separator</summary>
		/// <returns>list of substrings</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='Strings']/method[@name='split' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("split", "(Ljava/lang/String;C)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> Split (string pattern, char slash)
		{
			const string __id = "split.(Ljava/lang/String;C)Ljava/util/List;";
			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_pattern);
				__args [1] = new JniArgumentValue (slash);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		/// <param name="pattern">non null</param>
		/// <param name="c">character to remove</param>
		/// <returns>new string with all trailing characters removed</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore.internal']/class[@name='Strings']/method[@name='stripTrailing' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("stripTrailing", "(Ljava/lang/String;C)Ljava/lang/String;", "")]
		public static unsafe string StripTrailing (string pattern, char c)
		{
			const string __id = "stripTrailing.(Ljava/lang/String;C)Ljava/lang/String;";
			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_pattern);
				__args [1] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

	}
}
