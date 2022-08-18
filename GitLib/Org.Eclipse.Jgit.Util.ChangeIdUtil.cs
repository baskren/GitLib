using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Utilities for creating and working with Change-Id's, like the one used by
	/// Gerrit Code Review.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ChangeIdUtil']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/ChangeIdUtil", DoNotGenerateAcw=true)]
	public partial class ChangeIdUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/ChangeIdUtil", typeof (ChangeIdUtil));

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

		protected ChangeIdUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ChangeIdUtil']/constructor[@name='ChangeIdUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChangeIdUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="treeId">The id of the tree that would be committed</param>
		/// <param name="firstParentId">parent id of previous commit or null</param>
		/// <param name="author">the <c>PersonIdent</c> for the presumed author and time</param>
		/// <param name="committer">the <c>PersonIdent</c> for the presumed committer and time</param>
		/// <param name="message">The commit message</param>
		/// <summary>Compute a Change-Id.</summary>
		/// <returns>the change id SHA1 string (without the 'I') or null if the
		///         message is not complete enough</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ChangeIdUtil']/method[@name='computeChangeId' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='org.eclipse.jgit.lib.PersonIdent'] and parameter[4][@type='org.eclipse.jgit.lib.PersonIdent'] and parameter[5][@type='java.lang.String']]"
		[Register ("computeChangeId", "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/PersonIdent;Lorg/eclipse/jgit/lib/PersonIdent;Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ComputeChangeId (global::Org.Eclipse.Jgit.Lib.ObjectId treeId, global::Org.Eclipse.Jgit.Lib.ObjectId firstParentId, global::Org.Eclipse.Jgit.Lib.PersonIdent author, global::Org.Eclipse.Jgit.Lib.PersonIdent committer, string message)
		{
			const string __id = "computeChangeId.(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/PersonIdent;Lorg/eclipse/jgit/lib/PersonIdent;Ljava/lang/String;)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((treeId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) treeId).Handle);
				__args [1] = new JniArgumentValue ((firstParentId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstParentId).Handle);
				__args [2] = new JniArgumentValue ((author == null) ? IntPtr.Zero : ((global::Java.Lang.Object) author).Handle);
				__args [3] = new JniArgumentValue ((committer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) committer).Handle);
				__args [4] = new JniArgumentValue (native_message);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (treeId);
				global::System.GC.KeepAlive (firstParentId);
				global::System.GC.KeepAlive (author);
				global::System.GC.KeepAlive (committer);
			}
		}

		/// <param name="message">message</param>
		/// <param name="delimiter">the line delimiter, like "\n" or "\r\n", needed to find the
		///            footer</param>
		/// <summary>Return the index in the String <c>message</c> where the Change-Id entry
		/// in the footer begins.</summary>
		/// <returns>the index of the ChangeId footer in the message, or -1 if no
		///         ChangeId footer available</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ChangeIdUtil']/method[@name='indexOfChangeId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("indexOfChangeId", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int IndexOfChangeId (string message, string delimiter)
		{
			const string __id = "indexOfChangeId.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			IntPtr native_delimiter = JNIEnv.NewString ((string)delimiter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_delimiter);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_delimiter);
			}
		}

		/// <param name="lines">the commit message split into lines and the line delimiters
		///            stripped off</param>
		/// <summary>Find the index of the first line of the footer paragraph in an array of
		/// the lines, or lines.</summary>
		/// <returns>the index of the first line of the footer paragraph, or
		///         lines.length if no footer is available</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ChangeIdUtil']/method[@name='indexOfFirstFooterLine' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("indexOfFirstFooterLine", "([Ljava/lang/String;)I", "")]
		public static unsafe int IndexOfFirstFooterLine (string[] lines)
		{
			const string __id = "indexOfFirstFooterLine.([Ljava/lang/String;)I";
			IntPtr native_lines = JNIEnv.NewArray (lines);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_lines);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (lines != null) {
					JNIEnv.CopyArray (native_lines, lines);
					JNIEnv.DeleteLocalRef (native_lines);
				}
				global::System.GC.KeepAlive (lines);
			}
		}

		/// <param name="message">message</param>
		/// <param name="changeId">changeId</param>
		/// <summary>Find the right place to insert a Change-Id and return it.</summary>
		/// <returns>a commit message with an inserted Change-Id line</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ChangeIdUtil']/method[@name='insertId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("insertId", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)Ljava/lang/String;", "")]
		public static unsafe string InsertId (string message, global::Org.Eclipse.Jgit.Lib.ObjectId changeId)
		{
			const string __id = "insertId.(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)Ljava/lang/String;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((changeId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) changeId).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (changeId);
			}
		}

		/// <param name="message">message</param>
		/// <param name="changeId">changeId</param>
		/// <param name="replaceExisting">replaceExisting</param>
		/// <summary>Find the right place to insert a Change-Id and return it.</summary>
		/// <returns>a commit message with an inserted Change-Id line</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='ChangeIdUtil']/method[@name='insertId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='boolean']]"
		[Register ("insertId", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;Z)Ljava/lang/String;", "")]
		public static unsafe string InsertId (string message, global::Org.Eclipse.Jgit.Lib.ObjectId changeId, bool replaceExisting)
		{
			const string __id = "insertId.(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;Z)Ljava/lang/String;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((changeId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) changeId).Handle);
				__args [2] = new JniArgumentValue (replaceExisting);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (changeId);
			}
		}

	}
}
