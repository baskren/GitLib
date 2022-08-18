using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>Thrown when a pattern contains a character group which is open to the right
	/// side or a character class which is open to the right side.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoClosingBracketException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/NoClosingBracketException", DoNotGenerateAcw=true)]
	public partial class NoClosingBracketException : global::Org.Eclipse.Jgit.Errors.InvalidPatternException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/NoClosingBracketException", typeof (NoClosingBracketException));

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

		protected NoClosingBracketException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="indexOfOpeningBracket">the position of the [ character which has no ] character.</param>
		/// <param name="openingBracket">the unclosed bracket.</param>
		/// <param name="closingBracket">the missing closing bracket.</param>
		/// <param name="pattern">the invalid pattern.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='NoClosingBracketException']/constructor[@name='NoClosingBracketException' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe NoClosingBracketException (int indexOfOpeningBracket, string openingBracket, string closingBracket, string pattern) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_openingBracket = JNIEnv.NewString ((string)openingBracket);
			IntPtr native_closingBracket = JNIEnv.NewString ((string)closingBracket);
			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (indexOfOpeningBracket);
				__args [1] = new JniArgumentValue (native_openingBracket);
				__args [2] = new JniArgumentValue (native_closingBracket);
				__args [3] = new JniArgumentValue (native_pattern);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_openingBracket);
				JNIEnv.DeleteLocalRef (native_closingBracket);
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

	}
}
