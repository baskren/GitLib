using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>Formatter for constructing the commit message for a merge commit.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeMessageFormatter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/MergeMessageFormatter", DoNotGenerateAcw=true)]
	public partial class MergeMessageFormatter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/MergeMessageFormatter", typeof (MergeMessageFormatter));

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

		protected MergeMessageFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeMessageFormatter']/constructor[@name='MergeMessageFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MergeMessageFormatter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_);
			return cb_format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_Format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refsToMerge, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeMessageFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refsToMerge = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (native_refsToMerge, JniHandleOwnership.DoNotTransfer);
			var target = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_target, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (refsToMerge, target));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="refsToMerge">the refs which will be merged</param>
		/// <param name="target">the branch ref which will be merged into</param>
		/// <summary>Construct the merge commit message.</summary>
		/// <returns>merge commit message</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeMessageFormatter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.lib.Ref&gt;'] and parameter[2][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("format", "(Ljava/util/List;Lorg/eclipse/jgit/lib/Ref;)Ljava/lang/String;", "GetFormat_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe string Format (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> refsToMerge, global::Org.Eclipse.Jgit.Lib.IRef target)
		{
			const string __id = "format.(Ljava/util/List;Lorg/eclipse/jgit/lib/Ref;)Ljava/lang/String;";
			IntPtr native_refsToMerge = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (refsToMerge);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_refsToMerge);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refsToMerge);
				global::System.GC.KeepAlive (refsToMerge);
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_formatWithConflicts_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetFormatWithConflicts_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_formatWithConflicts_Ljava_lang_String_Ljava_util_List_ == null)
				cb_formatWithConflicts_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_FormatWithConflicts_Ljava_lang_String_Ljava_util_List_);
			return cb_formatWithConflicts_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_FormatWithConflicts_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_conflictingPaths)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeMessageFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var conflictingPaths = global::Android.Runtime.JavaList<string>.FromJniHandle (native_conflictingPaths, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.FormatWithConflicts (message, conflictingPaths));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="message">the original merge message</param>
		/// <param name="conflictingPaths">the paths with conflicts</param>
		/// <summary>Add section with conflicting paths to merge message.</summary>
		/// <returns>merge message with conflicting paths added</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeMessageFormatter']/method[@name='formatWithConflicts' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("formatWithConflicts", "(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;", "GetFormatWithConflicts_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe string FormatWithConflicts (string message, global::System.Collections.Generic.IList<string> conflictingPaths)
		{
			const string __id = "formatWithConflicts.(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			IntPtr native_conflictingPaths = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (conflictingPaths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_conflictingPaths);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_conflictingPaths);
				global::System.GC.KeepAlive (conflictingPaths);
			}
		}

	}
}
