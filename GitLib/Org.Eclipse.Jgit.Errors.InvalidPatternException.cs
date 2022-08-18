using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>Thrown when a pattern passed in an argument was wrong.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='InvalidPatternException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/InvalidPatternException", DoNotGenerateAcw=true)]
	public partial class InvalidPatternException : global::Java.Lang.Exception {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/InvalidPatternException", typeof (InvalidPatternException));

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

		protected InvalidPatternException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="message">explains what was wrong with the pattern.</param>
		/// <param name="pattern">the invalid pattern.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='InvalidPatternException']/constructor[@name='InvalidPatternException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe InvalidPatternException (string message, string pattern) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string)message);
			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_pattern);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_pattern);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.InvalidPatternException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pattern);
		}
#pragma warning restore 0169

		/// <returns>the invalid pattern.</returns>
		public virtual unsafe string Pattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='InvalidPatternException']/method[@name='getPattern' and count(parameter)=0]"
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

	}
}
