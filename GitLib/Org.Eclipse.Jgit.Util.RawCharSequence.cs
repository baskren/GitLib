using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>A rough character sequence around a raw byte buffer.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharSequence']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/RawCharSequence", DoNotGenerateAcw=true)]
	public sealed partial class RawCharSequence : global::Java.Lang.Object, global::Java.Lang.ICharSequence {

		/// <summary>A zero-length character sequence.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharSequence']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public static global::Org.Eclipse.Jgit.Util.RawCharSequence Empty {
			get {
				const string __id = "EMPTY.Lorg/eclipse/jgit/util/RawCharSequence;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RawCharSequence> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/RawCharSequence", typeof (RawCharSequence));

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

		internal RawCharSequence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="buf">buffer to scan.</param>
		/// <param name="start">starting position for the sequence.</param>
		/// <param name="end">ending position for the sequence.</param>
		/// <summary>Create a rough character sequence around the raw byte buffer.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharSequence']/constructor[@name='RawCharSequence' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "([BII)V", "")]
		public unsafe RawCharSequence (byte[] buf, int start, int end) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharSequence']/method[@name='charAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("charAt", "(I)C", "")]
		public unsafe char CharAt (int index)
		{
			const string __id = "charAt.(I)C";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractCharMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharSequence']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "")]
		public unsafe int Length ()
		{
			const string __id = "length.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RawCharSequence']/method[@name='subSequence' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("subSequence", "(II)Ljava/lang/CharSequence;", "")]
		public unsafe global::Java.Lang.ICharSequence SubSequenceFormatted (int start, int end)
		{
			const string __id = "subSequence.(II)Ljava/lang/CharSequence;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (end);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public string SubSequence (int start, int end)
		{
			global::Java.Lang.ICharSequence __result = SubSequenceFormatted (start, end);
			var __rsval = __result?.ToString ();
			return __rsval;
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}

		public global::System.Collections.Generic.IEnumerator<char> GetEnumerator ()
		{
			for (int i = 0; i < Length (); i++)
				yield return CharAt (i);
		}

	}
}
