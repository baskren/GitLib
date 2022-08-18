using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>A class to convert merge results into a Git conformant textual presentation</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeFormatter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/MergeFormatter", DoNotGenerateAcw=true)]
	public partial class MergeFormatter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/MergeFormatter", typeof (MergeFormatter));

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

		protected MergeFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeFormatter']/constructor[@name='MergeFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MergeFormatter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_formatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFormatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_formatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_formatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLL_V) n_FormatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_formatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_FormatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_res, IntPtr native_baseName, IntPtr native_oursName, IntPtr native_theirsName, IntPtr native_charsetName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			var res = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeResult> (native_res, JniHandleOwnership.DoNotTransfer);
			var baseName = JNIEnv.GetString (native_baseName, JniHandleOwnership.DoNotTransfer);
			var oursName = JNIEnv.GetString (native_oursName, JniHandleOwnership.DoNotTransfer);
			var theirsName = JNIEnv.GetString (native_theirsName, JniHandleOwnership.DoNotTransfer);
			var charsetName = JNIEnv.GetString (native_charsetName, JniHandleOwnership.DoNotTransfer);
			__this.FormatMerge (@out, res, baseName, oursName, theirsName, charsetName);
		}
#pragma warning restore 0169

		/// <param name="out">the <c>OutputStream</c> where to write the textual
		///            presentation</param>
		/// <param name="res">the merge result which should be presented</param>
		/// <param name="baseName">the name ranges from the base should get</param>
		/// <param name="oursName">the name ranges from ours should get</param>
		/// <param name="theirsName">the name ranges from theirs should get</param>
		/// <param name="charsetName">the name of the characterSet used when writing conflict
		///            metadata</param>
		/// <summary>Formats the results of a merge of exactly two <c>RawText</c> objects in
		/// a Git conformant way.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeFormatter']/method[@name='formatMerge' and count(parameter)=6 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='org.eclipse.jgit.merge.MergeResult'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("formatMerge", "(Ljava/io/OutputStream;Lorg/eclipse/jgit/merge/MergeResult;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetFormatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void FormatMerge (global::System.IO.Stream @out, global::Org.Eclipse.Jgit.Merge.MergeResult res, string baseName, string oursName, string theirsName, string charsetName)
		{
			const string __id = "formatMerge.(Ljava/io/OutputStream;Lorg/eclipse/jgit/merge/MergeResult;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			IntPtr native_baseName = JNIEnv.NewString ((string)baseName);
			IntPtr native_oursName = JNIEnv.NewString ((string)oursName);
			IntPtr native_theirsName = JNIEnv.NewString ((string)theirsName);
			IntPtr native_charsetName = JNIEnv.NewString ((string)charsetName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native__out);
				__args [1] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				__args [2] = new JniArgumentValue (native_baseName);
				__args [3] = new JniArgumentValue (native_oursName);
				__args [4] = new JniArgumentValue (native_theirsName);
				__args [5] = new JniArgumentValue (native_charsetName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				JNIEnv.DeleteLocalRef (native_baseName);
				JNIEnv.DeleteLocalRef (native_oursName);
				JNIEnv.DeleteLocalRef (native_theirsName);
				JNIEnv.DeleteLocalRef (native_charsetName);
				global::System.GC.KeepAlive (@out);
				global::System.GC.KeepAlive (res);
			}
		}

		static Delegate cb_formatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFormatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_formatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_util_List_Ljava_lang_String_ == null)
				cb_formatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_FormatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_util_List_Ljava_lang_String_);
			return cb_formatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_util_List_Ljava_lang_String_;
		}

		static void n_FormatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_res, IntPtr native_seqName, IntPtr native_charsetName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			var res = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeResult> (native_res, JniHandleOwnership.DoNotTransfer);
			var seqName = global::Android.Runtime.JavaList<string>.FromJniHandle (native_seqName, JniHandleOwnership.DoNotTransfer);
			var charsetName = JNIEnv.GetString (native_charsetName, JniHandleOwnership.DoNotTransfer);
			__this.FormatMerge (@out, res, seqName, charsetName);
		}
#pragma warning restore 0169

		/// <param name="out">the outputstream where to write the textual presentation</param>
		/// <param name="res">the merge result which should be presented</param>
		/// <param name="seqName">When a conflict is reported each conflicting range will get a
		///            name. This name is following the "&amp;lt;&amp;lt;&amp;lt;&amp;lt;&amp;lt;&amp;lt;&amp;lt; " or "&amp;gt;&amp;gt;&amp;gt;&amp;gt;&amp;gt;&amp;gt;&amp;gt; "
		///            conflict markers. The names for the sequences are given in
		///            this list</param>
		/// <param name="charsetName">the name of the characterSet used when writing conflict
		///            metadata</param>
		/// <summary>Formats the results of a merge of <c>RawText</c> objects in a Git
		/// conformant way.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeFormatter']/method[@name='formatMerge' and count(parameter)=4 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='org.eclipse.jgit.merge.MergeResult&lt;org.eclipse.jgit.diff.RawText&gt;'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.lang.String']]"
		[Register ("formatMerge", "(Ljava/io/OutputStream;Lorg/eclipse/jgit/merge/MergeResult;Ljava/util/List;Ljava/lang/String;)V", "GetFormatMerge_Ljava_io_OutputStream_Lorg_eclipse_jgit_merge_MergeResult_Ljava_util_List_Ljava_lang_String_Handler")]
		public virtual unsafe void FormatMerge (global::System.IO.Stream @out, global::Org.Eclipse.Jgit.Merge.MergeResult res, global::System.Collections.Generic.IList<string> seqName, string charsetName)
		{
			const string __id = "formatMerge.(Ljava/io/OutputStream;Lorg/eclipse/jgit/merge/MergeResult;Ljava/util/List;Ljava/lang/String;)V";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			IntPtr native_seqName = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (seqName);
			IntPtr native_charsetName = JNIEnv.NewString ((string)charsetName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native__out);
				__args [1] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				__args [2] = new JniArgumentValue (native_seqName);
				__args [3] = new JniArgumentValue (native_charsetName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				JNIEnv.DeleteLocalRef (native_seqName);
				JNIEnv.DeleteLocalRef (native_charsetName);
				global::System.GC.KeepAlive (@out);
				global::System.GC.KeepAlive (res);
				global::System.GC.KeepAlive (seqName);
			}
		}

	}
}
