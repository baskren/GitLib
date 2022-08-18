using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Parses strings with time and date specifications into <c>Date</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateParser']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/GitDateParser", DoNotGenerateAcw=true)]
	public partial class GitDateParser : global::Java.Lang.Object {

		/// <summary>The Date representing never.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateParser']/field[@name='NEVER']"
		[Register ("NEVER")]
		public static global::Java.Util.Date Never {
			get {
				const string __id = "NEVER.Ljava/util/Date;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/GitDateParser", typeof (GitDateParser));

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

		protected GitDateParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateParser']/constructor[@name='GitDateParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GitDateParser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="dateStr">the string to be parsed</param>
		/// <param name="now">the base date which is used for the calculation of relative
		///            formats. E.g. if baseDate is "25.8.2012" then parsing of the
		///            string "1 week ago" would result in a date corresponding to
		///            "18.8.2012". This is used when a JGit command calls this
		///            parser often but wants a consistent starting point for calls.&lt;br&gt;
		///            If set to &lt;code&gt;null&lt;/code&gt; then the current time will be used
		///            instead.</param>
		/// <summary>Parses a string into a <c>Date</c> using the default locale.</summary>
		/// <returns>the parsed <c>Date</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Parse (string dateStr, global::Java.Util.Calendar now)
		{
			const string __id = "parse.(Ljava/lang/String;Ljava/util/Calendar;)Ljava/util/Date;";
			IntPtr native_dateStr = JNIEnv.NewString ((string)dateStr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_dateStr);
				__args [1] = new JniArgumentValue ((now == null) ? IntPtr.Zero : ((global::Java.Lang.Object) now).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateStr);
				global::System.GC.KeepAlive (now);
			}
		}

		/// <param name="dateStr">the string to be parsed</param>
		/// <param name="now">the base date which is used for the calculation of relative
		///            formats. E.g. if baseDate is "25.8.2012" then parsing of the
		///            string "1 week ago" would result in a date corresponding to
		///            "18.8.2012". This is used when a JGit command calls this
		///            parser often but wants a consistent starting point for calls.&lt;br&gt;
		///            If set to &lt;code&gt;null&lt;/code&gt; then the current time will be used
		///            instead.</param>
		/// <param name="locale">locale to be used to parse the date string</param>
		/// <summary>Parses a string into a <c>Date</c> using the given locale.</summary>
		/// <returns>the parsed <c>Date</c></returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='GitDateParser']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Calendar'] and parameter[3][@type='java.util.Locale']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/util/Calendar;Ljava/util/Locale;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Parse (string dateStr, global::Java.Util.Calendar now, global::Java.Util.Locale locale)
		{
			const string __id = "parse.(Ljava/lang/String;Ljava/util/Calendar;Ljava/util/Locale;)Ljava/util/Date;";
			IntPtr native_dateStr = JNIEnv.NewString ((string)dateStr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_dateStr);
				__args [1] = new JniArgumentValue ((now == null) ? IntPtr.Zero : ((global::Java.Lang.Object) now).Handle);
				__args [2] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateStr);
				global::System.GC.KeepAlive (now);
				global::System.GC.KeepAlive (locale);
			}
		}

	}
}
