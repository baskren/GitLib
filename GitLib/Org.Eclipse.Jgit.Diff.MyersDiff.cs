using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <param name="&lt;S&gt;">type of sequence.</param>
	/// <summary>Diff algorithm, based on "An O(ND) Difference Algorithm and its Variations",
	/// by Eugene Myers.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='MyersDiff']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/MyersDiff", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S extends org.eclipse.jgit.diff.Sequence"})]
	public partial class MyersDiff : global::Java.Lang.Object {

		/// <summary>The first text to be compared.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='MyersDiff']/field[@name='a']"
		[Register ("a")]
		protected global::Org.Eclipse.Jgit.Diff.HashedSequence A {
			get {
				const string __id = "a.Lorg/eclipse/jgit/diff/HashedSequence;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequence> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lorg/eclipse/jgit/diff/HashedSequence;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>The second text to be compared.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='MyersDiff']/field[@name='b']"
		[Register ("b")]
		protected global::Org.Eclipse.Jgit.Diff.HashedSequence B {
			get {
				const string __id = "b.Lorg/eclipse/jgit/diff/HashedSequence;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequence> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lorg/eclipse/jgit/diff/HashedSequence;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Comparison function for sequences.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='MyersDiff']/field[@name='cmp']"
		[Register ("cmp")]
		protected global::Org.Eclipse.Jgit.Diff.HashedSequenceComparator Cmp {
			get {
				const string __id = "cmp.Lorg/eclipse/jgit/diff/HashedSequenceComparator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.HashedSequenceComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cmp.Lorg/eclipse/jgit/diff/HashedSequenceComparator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>The list of edits found during the last call to
		/// <c>#calculateEdits(Edit)</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='MyersDiff']/field[@name='edits']"
		[Register ("edits")]
		protected global::Org.Eclipse.Jgit.Diff.EditList Edits {
			get {
				const string __id = "edits.Lorg/eclipse/jgit/diff/EditList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.EditList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "edits.Lorg/eclipse/jgit/diff/EditList;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Singleton instance of MyersDiff.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='MyersDiff']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Org.Eclipse.Jgit.Diff.DiffAlgorithm Instance {
			get {
				const string __id = "INSTANCE.Lorg/eclipse/jgit/diff/DiffAlgorithm;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/MyersDiff", typeof (MyersDiff));

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

		protected MyersDiff (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_calculateEdits_IIII;
#pragma warning disable 0169
		static Delegate GetCalculateEdits_IIIIHandler ()
		{
			if (cb_calculateEdits_IIII == null)
				cb_calculateEdits_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_CalculateEdits_IIII);
			return cb_calculateEdits_IIII;
		}

		static void n_CalculateEdits_IIII (IntPtr jnienv, IntPtr native__this, int beginA, int endA, int beginB, int endB)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.MyersDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateEdits (beginA, endA, beginB, endB);
		}
#pragma warning restore 0169

		/// <param name="beginA">start of the part of A which should be compared
		///            (0&amp;lt;=beginA&amp;lt;sizeof(A))</param>
		/// <param name="endA">end of the part of A which should be compared
		///            (beginA&amp;lt;=endA&amp;lt;sizeof(A))</param>
		/// <param name="beginB">start of the part of B which should be compared
		///            (0&amp;lt;=beginB&amp;lt;sizeof(B))</param>
		/// <param name="endB">end of the part of B which should be compared
		///            (beginB&amp;lt;=endB&amp;lt;sizeof(B))</param>
		/// <summary>Calculates the differences between a given part of A against another
		/// given part of B</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='MyersDiff']/method[@name='calculateEdits' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("calculateEdits", "(IIII)V", "GetCalculateEdits_IIIIHandler")]
		protected virtual unsafe void CalculateEdits (int beginA, int endA, int beginB, int endB)
		{
			const string __id = "calculateEdits.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (beginA);
				__args [1] = new JniArgumentValue (endA);
				__args [2] = new JniArgumentValue (beginB);
				__args [3] = new JniArgumentValue (endB);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <param name="args">two filenames specifying the contents to be diffed</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='MyersDiff']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] args)
		{
			const string __id = "main.([Ljava/lang/String;)V";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

	}
}
