using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <param name="&lt;S&gt;">the base sequence type.</param>
	/// <summary>Wraps a <c>Sequence</c> to have a narrower range of elements.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Subsequence']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/Subsequence", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
	public sealed partial class Subsequence : global::Org.Eclipse.Jgit.Diff.Sequence {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/Subsequence", typeof (Subsequence));

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

		internal Subsequence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="base">the real sequence.</param>
		/// <param name="begin">First element index of <c>base</c> that will be part of this
		///            new subsequence. The element at <c>begin</c> will be this
		///            sequence's element 0.</param>
		/// <param name="end">One past the last element index of <c>base</c> that will be
		///            part of this new subsequence.</param>
		/// <summary>Construct a subset of another sequence.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Subsequence']/constructor[@name='Subsequence' and count(parameter)=3 and parameter[1][@type='S'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/diff/Sequence;II)V", "")]
		public unsafe Subsequence (global::Java.Lang.Object @base, int begin, int end) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/diff/Sequence;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__base = JNIEnv.ToLocalJniHandle (@base);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__base);
				__args [1] = new JniArgumentValue (begin);
				__args [2] = new JniArgumentValue (end);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__base);
				global::System.GC.KeepAlive (@base);
			}
		}

		/// <param name="&lt;S&gt;">the base sequence type.</param>
		/// <param name="a">the A sequence.</param>
		/// <param name="region">the region of <c>a</c> to create a subsequence around.</param>
		/// <summary>Construct a subsequence around the A region/base sequence.</summary>
		/// <returns>subsequence of <c>base</c> as described by A in <c>region</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Subsequence']/method[@name='a' and count(parameter)=2 and parameter[1][@type='S'] and parameter[2][@type='org.eclipse.jgit.diff.Edit']]"
		[Register ("a", "(Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Subsequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public static unsafe global::Org.Eclipse.Jgit.Diff.Subsequence A (global::Java.Lang.Object a, global::Org.Eclipse.Jgit.Diff.Edit region)
		{
			const string __id = "a.(Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Subsequence;";
			IntPtr native_a = JNIEnv.ToLocalJniHandle (a);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_a);
				__args [1] = new JniArgumentValue ((region == null) ? IntPtr.Zero : ((global::Java.Lang.Object) region).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Subsequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (region);
			}
		}

		/// <param name="&lt;S&gt;">the base sequence type.</param>
		/// <param name="b">the B sequence.</param>
		/// <param name="region">the region of <c>b</c> to create a subsequence around.</param>
		/// <summary>Construct a subsequence around the B region/base sequence.</summary>
		/// <returns>subsequence of <c>base</c> as described by B in <c>region</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Subsequence']/method[@name='b' and count(parameter)=2 and parameter[1][@type='S'] and parameter[2][@type='org.eclipse.jgit.diff.Edit']]"
		[Register ("b", "(Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Subsequence;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public static unsafe global::Org.Eclipse.Jgit.Diff.Subsequence B (global::Java.Lang.Object b, global::Org.Eclipse.Jgit.Diff.Edit region)
		{
			const string __id = "b.(Lorg/eclipse/jgit/diff/Sequence;Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Subsequence;";
			IntPtr native_b = JNIEnv.ToLocalJniHandle (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_b);
				__args [1] = new JniArgumentValue ((region == null) ? IntPtr.Zero : ((global::Java.Lang.Object) region).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Subsequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_b);
				global::System.GC.KeepAlive (b);
				global::System.GC.KeepAlive (region);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Subsequence']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public override unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <param name="&lt;S&gt;">the base sequence type.</param>
		/// <param name="e">edit to adjust in-place. Prior to invocation the indexes are
		///            in terms of the two subsequences; after invocation the indexes
		///            are in terms of the base sequences.</param>
		/// <param name="a">the A sequence.</param>
		/// <param name="b">the B sequence.</param>
		/// <summary>Adjust the Edit to reflect positions in the base sequence.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Subsequence']/method[@name='toBase' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.diff.Edit'] and parameter[2][@type='org.eclipse.jgit.diff.Subsequence&lt;S&gt;'] and parameter[3][@type='org.eclipse.jgit.diff.Subsequence&lt;S&gt;']]"
		[Register ("toBase", "(Lorg/eclipse/jgit/diff/Edit;Lorg/eclipse/jgit/diff/Subsequence;Lorg/eclipse/jgit/diff/Subsequence;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public static unsafe void ToBase (global::Org.Eclipse.Jgit.Diff.Edit e, global::Org.Eclipse.Jgit.Diff.Subsequence a, global::Org.Eclipse.Jgit.Diff.Subsequence b)
		{
			const string __id = "toBase.(Lorg/eclipse/jgit/diff/Edit;Lorg/eclipse/jgit/diff/Subsequence;Lorg/eclipse/jgit/diff/Subsequence;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [2] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (e);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="&lt;S&gt;">the base sequence type.</param>
		/// <param name="edits">edits to adjust in-place. Prior to invocation the indexes are
		///            in terms of the two subsequences; after invocation the indexes
		///            are in terms of the base sequences.</param>
		/// <param name="a">the A sequence.</param>
		/// <param name="b">the B sequence.</param>
		/// <summary>Adjust the Edits to reflect positions in the base sequence.</summary>
		/// <returns>always <c>edits</c> (as the list was updated in-place).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Subsequence']/method[@name='toBase' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.diff.EditList'] and parameter[2][@type='org.eclipse.jgit.diff.Subsequence&lt;S&gt;'] and parameter[3][@type='org.eclipse.jgit.diff.Subsequence&lt;S&gt;']]"
		[Register ("toBase", "(Lorg/eclipse/jgit/diff/EditList;Lorg/eclipse/jgit/diff/Subsequence;Lorg/eclipse/jgit/diff/Subsequence;)Lorg/eclipse/jgit/diff/EditList;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
		public static unsafe global::Org.Eclipse.Jgit.Diff.EditList ToBase (global::Org.Eclipse.Jgit.Diff.EditList edits, global::Org.Eclipse.Jgit.Diff.Subsequence a, global::Org.Eclipse.Jgit.Diff.Subsequence b)
		{
			const string __id = "toBase.(Lorg/eclipse/jgit/diff/EditList;Lorg/eclipse/jgit/diff/Subsequence;Lorg/eclipse/jgit/diff/Subsequence;)Lorg/eclipse/jgit/diff/EditList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((edits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) edits).Handle);
				__args [1] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [2] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.EditList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (edits);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

	}
}
