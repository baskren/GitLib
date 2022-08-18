using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>Format a Git style patch script.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/DiffFormatter", DoNotGenerateAcw=true)]
	public partial class DiffFormatter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/DiffFormatter", typeof (DiffFormatter));

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

		protected DiffFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="out">the stream the formatter will write line data to. This stream
		///            should have buffering arranged by the caller, as many small
		///            writes are performed to it.</param>
		/// <summary>Create a new formatter with a default level of context.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/constructor[@name='DiffFormatter' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		public unsafe DiffFormatter (global::System.IO.Stream @out) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/OutputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_isDetectRenames;
#pragma warning disable 0169
		static Delegate GetIsDetectRenamesHandler ()
		{
			if (cb_isDetectRenames == null)
				cb_isDetectRenames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDetectRenames);
			return cb_isDetectRenames;
		}

		static bool n_IsDetectRenames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DetectRenames;
		}
#pragma warning restore 0169

		static Delegate cb_setDetectRenames_Z;
#pragma warning disable 0169
		static Delegate GetSetDetectRenames_ZHandler ()
		{
			if (cb_setDetectRenames_Z == null)
				cb_setDetectRenames_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDetectRenames_Z);
			return cb_setDetectRenames_Z;
		}

		static void n_SetDetectRenames_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DetectRenames = on;
		}
#pragma warning restore 0169

		/// <returns>true if rename detection is enabled.</returns>
		/// <summary>Enable or disable rename detection.</summary>
		/// <param name="on">if rename detection should be enabled.</param>
		public virtual unsafe bool DetectRenames {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='isDetectRenames' and count(parameter)=0]"
			[Register ("isDetectRenames", "()Z", "GetIsDetectRenamesHandler")]
			get {
				const string __id = "isDetectRenames.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setDetectRenames' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDetectRenames", "(Z)V", "GetSetDetectRenames_ZHandler")]
			set {
				const string __id = "setDetectRenames.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNewPrefix;
#pragma warning disable 0169
		static Delegate GetGetNewPrefixHandler ()
		{
			if (cb_getNewPrefix == null)
				cb_getNewPrefix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewPrefix);
			return cb_getNewPrefix;
		}

		static IntPtr n_GetNewPrefix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NewPrefix);
		}
#pragma warning restore 0169

		static Delegate cb_setNewPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNewPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setNewPrefix_Ljava_lang_String_ == null)
				cb_setNewPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNewPrefix_Ljava_lang_String_);
			return cb_setNewPrefix_Ljava_lang_String_;
		}

		static void n_SetNewPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			__this.NewPrefix = prefix;
		}
#pragma warning restore 0169

		/// <summary>Get the prefix applied in front of new file paths. -or- Set the prefix applied in front of new file paths.</summary>
		/// <returns>the prefix</returns>
		/// <param name="prefix">the prefix in front of new paths. Typically this is the
		///            standard string <c>"b/"</c>, but may be any prefix desired by
		///            the caller. Must not be null. Use the empty string to have no
		///            prefix at all.</param>
		public virtual unsafe string NewPrefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='getNewPrefix' and count(parameter)=0]"
			[Register ("getNewPrefix", "()Ljava/lang/String;", "GetGetNewPrefixHandler")]
			get {
				const string __id = "getNewPrefix.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setNewPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNewPrefix", "(Ljava/lang/String;)V", "GetSetNewPrefix_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNewPrefix.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOldPrefix;
#pragma warning disable 0169
		static Delegate GetGetOldPrefixHandler ()
		{
			if (cb_getOldPrefix == null)
				cb_getOldPrefix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOldPrefix);
			return cb_getOldPrefix;
		}

		static IntPtr n_GetOldPrefix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OldPrefix);
		}
#pragma warning restore 0169

		static Delegate cb_setOldPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOldPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setOldPrefix_Ljava_lang_String_ == null)
				cb_setOldPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOldPrefix_Ljava_lang_String_);
			return cb_setOldPrefix_Ljava_lang_String_;
		}

		static void n_SetOldPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			__this.OldPrefix = prefix;
		}
#pragma warning restore 0169

		/// <summary>Get the prefix applied in front of old file paths. -or- Set the prefix applied in front of old file paths.</summary>
		/// <returns>the prefix</returns>
		/// <param name="prefix">the prefix in front of old paths. Typically this is the
		///            standard string <c>"a/"</c>, but may be any prefix desired by
		///            the caller. Must not be null. Use the empty string to have no
		///            prefix at all.</param>
		public virtual unsafe string OldPrefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='getOldPrefix' and count(parameter)=0]"
			[Register ("getOldPrefix", "()Ljava/lang/String;", "GetGetOldPrefixHandler")]
			get {
				const string __id = "getOldPrefix.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setOldPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOldPrefix", "(Ljava/lang/String;)V", "GetSetOldPrefix_Ljava_lang_String_Handler")]
			set {
				const string __id = "setOldPrefix.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		/// <returns>the stream we are outputting data to.</returns>
		protected virtual unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				const string __id = "getOutputStream.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPathFilter;
#pragma warning disable 0169
		static Delegate GetGetPathFilterHandler ()
		{
			if (cb_getPathFilter == null)
				cb_getPathFilter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPathFilter);
			return cb_getPathFilter;
		}

		static IntPtr n_GetPathFilter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PathFilter);
		}
#pragma warning restore 0169

		static Delegate cb_setPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
#pragma warning disable 0169
		static Delegate GetSetPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler ()
		{
			if (cb_setPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ == null)
				cb_setPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_);
			return cb_setPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
		}

		static void n_SetPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.PathFilter = filter;
		}
#pragma warning restore 0169

		/// <returns>the current path filter.</returns>
		/// <summary>Set the filter to produce only specific paths.</summary>
		/// <param name="filter">the tree filter to apply.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter PathFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='getPathFilter' and count(parameter)=0]"
			[Register ("getPathFilter", "()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "GetGetPathFilterHandler")]
			get {
				const string __id = "getPathFilter.()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setPathFilter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.filter.TreeFilter']]"
			[Register ("setPathFilter", "(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V", "GetSetPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler")]
			set {
				const string __id = "setPathFilter.(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getRenameDetector;
#pragma warning disable 0169
		static Delegate GetGetRenameDetectorHandler ()
		{
			if (cb_getRenameDetector == null)
				cb_getRenameDetector = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRenameDetector);
			return cb_getRenameDetector;
		}

		static IntPtr n_GetRenameDetector (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RenameDetector);
		}
#pragma warning restore 0169

		/// <returns>the rename detector if rename detection is enabled.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.RenameDetector RenameDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='getRenameDetector' and count(parameter)=0]"
			[Register ("getRenameDetector", "()Lorg/eclipse/jgit/diff/RenameDetector;", "GetGetRenameDetectorHandler")]
			get {
				const string __id = "getRenameDetector.()Lorg/eclipse/jgit/diff/RenameDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		/// <summary>Flush the underlying output stream of this formatter.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_format_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_List_Handler ()
		{
			if (cb_format_Ljava_util_List_ == null)
				cb_format_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Format_Ljava_util_List_);
			return cb_format_Ljava_util_List_;
		}

		static void n_Format_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entries)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entries = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (native_entries, JniHandleOwnership.DoNotTransfer);
			__this.Format (entries);
		}
#pragma warning restore 0169

		/// <param name="entries">entries describing the affected files.</param>
		/// <summary>Format a patch script from a list of difference entries.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends org.eclipse.jgit.diff.DiffEntry&gt;']]"
		[Register ("format", "(Ljava/util/List;)V", "GetFormat_Ljava_util_List_Handler")]
		public virtual unsafe void Format (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> entries)
		{
			const string __id = "format.(Ljava/util/List;)V";
			IntPtr native_entries = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (entries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entries);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entries);
				global::System.GC.KeepAlive (entries);
			}
		}

		static Delegate cb_format_Lorg_eclipse_jgit_diff_DiffEntry_;
#pragma warning disable 0169
		static Delegate GetFormat_Lorg_eclipse_jgit_diff_DiffEntry_Handler ()
		{
			if (cb_format_Lorg_eclipse_jgit_diff_DiffEntry_ == null)
				cb_format_Lorg_eclipse_jgit_diff_DiffEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Format_Lorg_eclipse_jgit_diff_DiffEntry_);
			return cb_format_Lorg_eclipse_jgit_diff_DiffEntry_;
		}

		static void n_Format_Lorg_eclipse_jgit_diff_DiffEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ent = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (native_ent, JniHandleOwnership.DoNotTransfer);
			__this.Format (ent);
		}
#pragma warning restore 0169

		/// <param name="ent">the entry to be formatted.</param>
		/// <summary>Format a patch script for one file entry.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='format' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry']]"
		[Register ("format", "(Lorg/eclipse/jgit/diff/DiffEntry;)V", "GetFormat_Lorg_eclipse_jgit_diff_DiffEntry_Handler")]
		public virtual unsafe void Format (global::Org.Eclipse.Jgit.Diff.DiffEntry ent)
		{
			const string __id = "format.(Lorg/eclipse/jgit/diff/DiffEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (ent);
			}
		}

		static Delegate cb_format_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_;
#pragma warning disable 0169
		static Delegate GetFormat_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Handler ()
		{
			if (cb_format_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_ == null)
				cb_format_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Format_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_);
			return cb_format_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_;
		}

		static void n_Format_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_edits, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var edits = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.EditList> (native_edits, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_b, JniHandleOwnership.DoNotTransfer);
			__this.Format (edits, a, b);
		}
#pragma warning restore 0169

		/// <param name="edits">some differences which have been calculated between A and B</param>
		/// <param name="a">the text A which was compared</param>
		/// <param name="b">the text B which was compared</param>
		/// <summary>Formats a list of edits in unified diff format</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='format' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.diff.EditList'] and parameter[2][@type='org.eclipse.jgit.diff.RawText'] and parameter[3][@type='org.eclipse.jgit.diff.RawText']]"
		[Register ("format", "(Lorg/eclipse/jgit/diff/EditList;Lorg/eclipse/jgit/diff/RawText;Lorg/eclipse/jgit/diff/RawText;)V", "GetFormat_Lorg_eclipse_jgit_diff_EditList_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Handler")]
		public virtual unsafe void Format (global::Org.Eclipse.Jgit.Diff.EditList edits, global::Org.Eclipse.Jgit.Diff.RawText a, global::Org.Eclipse.Jgit.Diff.RawText b)
		{
			const string __id = "format.(Lorg/eclipse/jgit/diff/EditList;Lorg/eclipse/jgit/diff/RawText;Lorg/eclipse/jgit/diff/RawText;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((edits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) edits).Handle);
				__args [1] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [2] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (edits);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_format_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetFormat_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_format_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_format_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Format_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_format_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Format_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_b, JniHandleOwnership.DoNotTransfer);
			__this.Format (a, b);
		}
#pragma warning restore 0169

		/// <param name="a">the old (or previous) side or null</param>
		/// <param name="b">the new (or updated) side or null</param>
		/// <summary>Format the differences between two trees.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("format", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetFormat_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void Format (global::Org.Eclipse.Jgit.Lib.AnyObjectId a, global::Org.Eclipse.Jgit.Lib.AnyObjectId b)
		{
			const string __id = "format.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_format_Lorg_eclipse_jgit_patch_FileHeader_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_;
#pragma warning disable 0169
		static Delegate GetFormat_Lorg_eclipse_jgit_patch_FileHeader_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Handler ()
		{
			if (cb_format_Lorg_eclipse_jgit_patch_FileHeader_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_ == null)
				cb_format_Lorg_eclipse_jgit_patch_FileHeader_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Format_Lorg_eclipse_jgit_patch_FileHeader_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_);
			return cb_format_Lorg_eclipse_jgit_patch_FileHeader_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_;
		}

		static void n_Format_Lorg_eclipse_jgit_patch_FileHeader_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_head, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var head = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (native_head, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_b, JniHandleOwnership.DoNotTransfer);
			__this.Format (head, a, b);
		}
#pragma warning restore 0169

		/// <param name="head">existing file header containing the header lines to copy.</param>
		/// <param name="a">text source for the pre-image version of the content. This
		///            must match the content of <c>FileHeader#getOldId()</c>.</param>
		/// <param name="b">text source for the post-image version of the content. This
		///            must match the content of <c>FileHeader#getNewId()</c>.</param>
		/// <summary>Format a patch script, reusing a previously parsed FileHeader.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='format' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.patch.FileHeader'] and parameter[2][@type='org.eclipse.jgit.diff.RawText'] and parameter[3][@type='org.eclipse.jgit.diff.RawText']]"
		[Register ("format", "(Lorg/eclipse/jgit/patch/FileHeader;Lorg/eclipse/jgit/diff/RawText;Lorg/eclipse/jgit/diff/RawText;)V", "GetFormat_Lorg_eclipse_jgit_patch_FileHeader_Lorg_eclipse_jgit_diff_RawText_Lorg_eclipse_jgit_diff_RawText_Handler")]
		public virtual unsafe void Format (global::Org.Eclipse.Jgit.Patch.FileHeader head, global::Org.Eclipse.Jgit.Diff.RawText a, global::Org.Eclipse.Jgit.Diff.RawText b)
		{
			const string __id = "format.(Lorg/eclipse/jgit/patch/FileHeader;Lorg/eclipse/jgit/diff/RawText;Lorg/eclipse/jgit/diff/RawText;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((head == null) ? IntPtr.Zero : ((global::Java.Lang.Object) head).Handle);
				__args [1] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [2] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (head);
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_format_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_;
#pragma warning disable 0169
		static Delegate GetFormat_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Handler ()
		{
			if (cb_format_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_ == null)
				cb_format_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Format_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_);
			return cb_format_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_;
		}

		static void n_Format_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (native_b, JniHandleOwnership.DoNotTransfer);
			__this.Format (a, b);
		}
#pragma warning restore 0169

		/// <param name="a">the old (or previous) side or null</param>
		/// <param name="b">the new (or updated) side or null</param>
		/// <summary>Format the differences between two trees.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevTree'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevTree']]"
		[Register ("format", "(Lorg/eclipse/jgit/revwalk/RevTree;Lorg/eclipse/jgit/revwalk/RevTree;)V", "GetFormat_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Handler")]
		public virtual unsafe void Format (global::Org.Eclipse.Jgit.Revwalk.RevTree a, global::Org.Eclipse.Jgit.Revwalk.RevTree b)
		{
			const string __id = "format.(Lorg/eclipse/jgit/revwalk/RevTree;Lorg/eclipse/jgit/revwalk/RevTree;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_format_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
#pragma warning disable 0169
		static Delegate GetFormat_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler ()
		{
			if (cb_format_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ == null)
				cb_format_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Format_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_);
			return cb_format_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
		}

		static void n_Format_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_b, JniHandleOwnership.DoNotTransfer);
			__this.Format (a, b);
		}
#pragma warning restore 0169

		/// <param name="a">the old (or previous) side or null</param>
		/// <param name="b">the new (or updated) side or null</param>
		/// <summary>Format the differences between two trees.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator'] and parameter[2][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register ("format", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)V", "GetFormat_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler")]
		public virtual unsafe void Format (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator a, global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator b)
		{
			const string __id = "format.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_formatGitDiffFirstHeaderLine_Ljava_io_ByteArrayOutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ChangeType_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFormatGitDiffFirstHeaderLine_Ljava_io_ByteArrayOutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ChangeType_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_formatGitDiffFirstHeaderLine_Ljava_io_ByteArrayOutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ChangeType_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_formatGitDiffFirstHeaderLine_Ljava_io_ByteArrayOutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ChangeType_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_FormatGitDiffFirstHeaderLine_Ljava_io_ByteArrayOutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ChangeType_Ljava_lang_String_Ljava_lang_String_);
			return cb_formatGitDiffFirstHeaderLine_Ljava_io_ByteArrayOutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ChangeType_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_FormatGitDiffFirstHeaderLine_Ljava_io_ByteArrayOutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ChangeType_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o, IntPtr native_type, IntPtr native_oldPath, IntPtr native_newPath)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.IO.ByteArrayOutputStream> (native_o, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType> (native_type, JniHandleOwnership.DoNotTransfer);
			var oldPath = JNIEnv.GetString (native_oldPath, JniHandleOwnership.DoNotTransfer);
			var newPath = JNIEnv.GetString (native_newPath, JniHandleOwnership.DoNotTransfer);
			__this.FormatGitDiffFirstHeaderLine (o, type, oldPath, newPath);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='formatGitDiffFirstHeaderLine' and count(parameter)=4 and parameter[1][@type='java.io.ByteArrayOutputStream'] and parameter[2][@type='org.eclipse.jgit.diff.DiffEntry.ChangeType'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("formatGitDiffFirstHeaderLine", "(Ljava/io/ByteArrayOutputStream;Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;Ljava/lang/String;Ljava/lang/String;)V", "GetFormatGitDiffFirstHeaderLine_Ljava_io_ByteArrayOutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ChangeType_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void FormatGitDiffFirstHeaderLine (global::Java.IO.ByteArrayOutputStream o, global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType type, string oldPath, string newPath)
		{
			const string __id = "formatGitDiffFirstHeaderLine.(Ljava/io/ByteArrayOutputStream;Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_oldPath = JNIEnv.NewString ((string)oldPath);
			IntPtr native_newPath = JNIEnv.NewString ((string)newPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [2] = new JniArgumentValue (native_oldPath);
				__args [3] = new JniArgumentValue (native_newPath);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_oldPath);
				JNIEnv.DeleteLocalRef (native_newPath);
				global::System.GC.KeepAlive (o);
				global::System.GC.KeepAlive (type);
			}
		}

		static Delegate cb_formatIndexLine_Ljava_io_OutputStream_Lorg_eclipse_jgit_diff_DiffEntry_;
#pragma warning disable 0169
		static Delegate GetFormatIndexLine_Ljava_io_OutputStream_Lorg_eclipse_jgit_diff_DiffEntry_Handler ()
		{
			if (cb_formatIndexLine_Ljava_io_OutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ == null)
				cb_formatIndexLine_Ljava_io_OutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_FormatIndexLine_Ljava_io_OutputStream_Lorg_eclipse_jgit_diff_DiffEntry_);
			return cb_formatIndexLine_Ljava_io_OutputStream_Lorg_eclipse_jgit_diff_DiffEntry_;
		}

		static void n_FormatIndexLine_Ljava_io_OutputStream_Lorg_eclipse_jgit_diff_DiffEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o, IntPtr native_ent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_o, JniHandleOwnership.DoNotTransfer);
			var ent = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (native_ent, JniHandleOwnership.DoNotTransfer);
			__this.FormatIndexLine (o, ent);
		}
#pragma warning restore 0169

		/// <param name="o">the stream the formatter will write line data to</param>
		/// <param name="ent">the DiffEntry to create the FileHeader for</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='formatIndexLine' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='org.eclipse.jgit.diff.DiffEntry']]"
		[Register ("formatIndexLine", "(Ljava/io/OutputStream;Lorg/eclipse/jgit/diff/DiffEntry;)V", "GetFormatIndexLine_Ljava_io_OutputStream_Lorg_eclipse_jgit_diff_DiffEntry_Handler")]
		protected virtual unsafe void FormatIndexLine (global::System.IO.Stream o, global::Org.Eclipse.Jgit.Diff.DiffEntry ent)
		{
			const string __id = "formatIndexLine.(Ljava/io/OutputStream;Lorg/eclipse/jgit/diff/DiffEntry;)V";
			IntPtr native_o = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (o);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_o);
				__args [1] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_o);
				global::System.GC.KeepAlive (o);
				global::System.GC.KeepAlive (ent);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		/// <summary>Release the internal ObjectReader state.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_scan_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetScan_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_scan_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_scan_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Scan_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_scan_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Scan_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_b, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (__this.Scan (a, b));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="a">the old (or previous) side or null</param>
		/// <param name="b">the new (or updated) side or null</param>
		/// <summary>Determine the differences between two trees.</summary>
		/// <returns>the paths that are different.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='scan' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("scan", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Ljava/util/List;", "GetScan_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Scan (global::Org.Eclipse.Jgit.Lib.AnyObjectId a, global::Org.Eclipse.Jgit.Lib.AnyObjectId b)
		{
			const string __id = "scan.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/AnyObjectId;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_scan_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_;
#pragma warning disable 0169
		static Delegate GetScan_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Handler ()
		{
			if (cb_scan_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_ == null)
				cb_scan_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Scan_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_);
			return cb_scan_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_;
		}

		static IntPtr n_Scan_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (native_b, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (__this.Scan (a, b));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="a">the old (or previous) side or null</param>
		/// <param name="b">the new (or updated) side or null</param>
		/// <summary>Determine the differences between two trees.</summary>
		/// <returns>the paths that are different.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='scan' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevTree'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevTree']]"
		[Register ("scan", "(Lorg/eclipse/jgit/revwalk/RevTree;Lorg/eclipse/jgit/revwalk/RevTree;)Ljava/util/List;", "GetScan_Lorg_eclipse_jgit_revwalk_RevTree_Lorg_eclipse_jgit_revwalk_RevTree_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Scan (global::Org.Eclipse.Jgit.Revwalk.RevTree a, global::Org.Eclipse.Jgit.Revwalk.RevTree b)
		{
			const string __id = "scan.(Lorg/eclipse/jgit/revwalk/RevTree;Lorg/eclipse/jgit/revwalk/RevTree;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_scan_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
#pragma warning disable 0169
		static Delegate GetScan_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler ()
		{
			if (cb_scan_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ == null)
				cb_scan_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Scan_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_);
			return cb_scan_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
		}

		static IntPtr n_Scan_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_b, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (__this.Scan (a, b));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="a">the old (or previous) side.</param>
		/// <param name="b">the new (or updated) side.</param>
		/// <summary>Determine the differences between two trees.</summary>
		/// <returns>the paths that are different.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='scan' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator'] and parameter[2][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register ("scan", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Ljava/util/List;", "GetScan_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Scan (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator a, global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator b)
		{
			const string __id = "scan.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_setAbbreviationLength_I;
#pragma warning disable 0169
		static Delegate GetSetAbbreviationLength_IHandler ()
		{
			if (cb_setAbbreviationLength_I == null)
				cb_setAbbreviationLength_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAbbreviationLength_I);
			return cb_setAbbreviationLength_I;
		}

		static void n_SetAbbreviationLength_I (IntPtr jnienv, IntPtr native__this, int count)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAbbreviationLength (count);
		}
#pragma warning restore 0169

		/// <param name="count">number of digits to show in an ObjectId.</param>
		/// <summary>Change the number of digits to show in an ObjectId.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setAbbreviationLength' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAbbreviationLength", "(I)V", "GetSetAbbreviationLength_IHandler")]
		public virtual unsafe void SetAbbreviationLength (int count)
		{
			const string __id = "setAbbreviationLength.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (count);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBinaryFileThreshold_I;
#pragma warning disable 0169
		static Delegate GetSetBinaryFileThreshold_IHandler ()
		{
			if (cb_setBinaryFileThreshold_I == null)
				cb_setBinaryFileThreshold_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBinaryFileThreshold_I);
			return cb_setBinaryFileThreshold_I;
		}

		static void n_SetBinaryFileThreshold_I (IntPtr jnienv, IntPtr native__this, int threshold)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBinaryFileThreshold (threshold);
		}
#pragma warning restore 0169

		/// <param name="threshold">the limit, in bytes. Files larger than this size will be
		///            assumed to be binary, even if they aren't.</param>
		/// <summary>Set maximum file size for text files.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setBinaryFileThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBinaryFileThreshold", "(I)V", "GetSetBinaryFileThreshold_IHandler")]
		public virtual unsafe void SetBinaryFileThreshold (int threshold)
		{
			const string __id = "setBinaryFileThreshold.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (threshold);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setContext_I;
#pragma warning disable 0169
		static Delegate GetSetContext_IHandler ()
		{
			if (cb_setContext_I == null)
				cb_setContext_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetContext_I);
			return cb_setContext_I;
		}

		static void n_SetContext_I (IntPtr jnienv, IntPtr native__this, int lineCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (lineCount);
		}
#pragma warning restore 0169

		/// <param name="lineCount">number of lines of context to see before the first
		///            modification and after the last modification within a hunk of
		///            the modified file.</param>
		/// <summary>Change the number of lines of context to display.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContext", "(I)V", "GetSetContext_IHandler")]
		public virtual unsafe void SetContext (int lineCount)
		{
			const string __id = "setContext.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (lineCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_;
#pragma warning disable 0169
		static Delegate GetSetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_Handler ()
		{
			if (cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ == null)
				cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_);
			return cb_setDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_;
		}

		static void n_SetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var alg = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffAlgorithm> (native_alg, JniHandleOwnership.DoNotTransfer);
			__this.SetDiffAlgorithm (alg);
		}
#pragma warning restore 0169

		/// <param name="alg">the algorithm to produce text file differences.</param>
		/// <summary>Set the algorithm that constructs difference output.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setDiffAlgorithm' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffAlgorithm']]"
		[Register ("setDiffAlgorithm", "(Lorg/eclipse/jgit/diff/DiffAlgorithm;)V", "GetSetDiffAlgorithm_Lorg_eclipse_jgit_diff_DiffAlgorithm_Handler")]
		public virtual unsafe void SetDiffAlgorithm (global::Org.Eclipse.Jgit.Diff.DiffAlgorithm alg)
		{
			const string __id = "setDiffAlgorithm.(Lorg/eclipse/jgit/diff/DiffAlgorithm;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (alg);
			}
		}

		static Delegate cb_setDiffComparator_Lorg_eclipse_jgit_diff_RawTextComparator_;
#pragma warning disable 0169
		static Delegate GetSetDiffComparator_Lorg_eclipse_jgit_diff_RawTextComparator_Handler ()
		{
			if (cb_setDiffComparator_Lorg_eclipse_jgit_diff_RawTextComparator_ == null)
				cb_setDiffComparator_Lorg_eclipse_jgit_diff_RawTextComparator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDiffComparator_Lorg_eclipse_jgit_diff_RawTextComparator_);
			return cb_setDiffComparator_Lorg_eclipse_jgit_diff_RawTextComparator_;
		}

		static void n_SetDiffComparator_Lorg_eclipse_jgit_diff_RawTextComparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawTextComparator> (native_cmp, JniHandleOwnership.DoNotTransfer);
			__this.SetDiffComparator (cmp);
		}
#pragma warning restore 0169

		/// <param name="cmp">The equivalence function used to determine if two lines of
		///            text are identical. The function can be changed to ignore
		///            various types of whitespace.</param>
		/// <summary>Set the line equivalence function for text file differences.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setDiffComparator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.RawTextComparator']]"
		[Register ("setDiffComparator", "(Lorg/eclipse/jgit/diff/RawTextComparator;)V", "GetSetDiffComparator_Lorg_eclipse_jgit_diff_RawTextComparator_Handler")]
		public virtual unsafe void SetDiffComparator (global::Org.Eclipse.Jgit.Diff.RawTextComparator cmp)
		{
			const string __id = "setDiffComparator.(Lorg/eclipse/jgit/diff/RawTextComparator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cmp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cmp);
			}
		}

		static Delegate cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static void n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pm = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_pm, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressMonitor (pm);
		}
#pragma warning restore 0169

		/// <param name="pm">progress monitor to receive rename detection status through.</param>
		/// <summary>Set the progress monitor for long running rename detection.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)V", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe void SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pm);
			}
		}

		static Delegate cb_setRepository_Lorg_eclipse_jgit_lib_Repository_;
#pragma warning disable 0169
		static Delegate GetSetRepository_Lorg_eclipse_jgit_lib_Repository_Handler ()
		{
			if (cb_setRepository_Lorg_eclipse_jgit_lib_Repository_ == null)
				cb_setRepository_Lorg_eclipse_jgit_lib_Repository_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRepository_Lorg_eclipse_jgit_lib_Repository_);
			return cb_setRepository_Lorg_eclipse_jgit_lib_Repository_;
		}

		static void n_SetRepository_Lorg_eclipse_jgit_lib_Repository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repository)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var repository = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repository, JniHandleOwnership.DoNotTransfer);
			__this.SetRepository (repository);
		}
#pragma warning restore 0169

		/// <param name="repository">source repository holding referenced objects.</param>
		/// <summary>Set the repository the formatter can load object contents from.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='setRepository' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("setRepository", "(Lorg/eclipse/jgit/lib/Repository;)V", "GetSetRepository_Lorg_eclipse_jgit_lib_Repository_Handler")]
		public virtual unsafe void SetRepository (global::Org.Eclipse.Jgit.Lib.Repository repository)
		{
			const string __id = "setRepository.(Lorg/eclipse/jgit/lib/Repository;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repository);
			}
		}

		static Delegate cb_toFileHeader_Lorg_eclipse_jgit_diff_DiffEntry_;
#pragma warning disable 0169
		static Delegate GetToFileHeader_Lorg_eclipse_jgit_diff_DiffEntry_Handler ()
		{
			if (cb_toFileHeader_Lorg_eclipse_jgit_diff_DiffEntry_ == null)
				cb_toFileHeader_Lorg_eclipse_jgit_diff_DiffEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ToFileHeader_Lorg_eclipse_jgit_diff_DiffEntry_);
			return cb_toFileHeader_Lorg_eclipse_jgit_diff_DiffEntry_;
		}

		static IntPtr n_ToFileHeader_Lorg_eclipse_jgit_diff_DiffEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ent = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (native_ent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToFileHeader (ent));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ent">the DiffEntry to create the FileHeader for</param>
		/// <summary>Creates a <c>FileHeader</c> representing the given <c>DiffEntry</c></summary>
		/// <returns>a FileHeader representing the DiffEntry. The FileHeader's buffer
		///         will contain only the header of the diff output. It will also
		///         contain one <c>HunkHeader</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='toFileHeader' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry']]"
		[Register ("toFileHeader", "(Lorg/eclipse/jgit/diff/DiffEntry;)Lorg/eclipse/jgit/patch/FileHeader;", "GetToFileHeader_Lorg_eclipse_jgit_diff_DiffEntry_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Patch.FileHeader ToFileHeader (global::Org.Eclipse.Jgit.Diff.DiffEntry ent)
		{
			const string __id = "toFileHeader.(Lorg/eclipse/jgit/diff/DiffEntry;)Lorg/eclipse/jgit/patch/FileHeader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ent);
			}
		}

		static Delegate cb_writeAddedLine_Lorg_eclipse_jgit_diff_RawText_I;
#pragma warning disable 0169
		static Delegate GetWriteAddedLine_Lorg_eclipse_jgit_diff_RawText_IHandler ()
		{
			if (cb_writeAddedLine_Lorg_eclipse_jgit_diff_RawText_I == null)
				cb_writeAddedLine_Lorg_eclipse_jgit_diff_RawText_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteAddedLine_Lorg_eclipse_jgit_diff_RawText_I);
			return cb_writeAddedLine_Lorg_eclipse_jgit_diff_RawText_I;
		}

		static void n_WriteAddedLine_Lorg_eclipse_jgit_diff_RawText_I (IntPtr jnienv, IntPtr native__this, IntPtr native_text, int line)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_text, JniHandleOwnership.DoNotTransfer);
			__this.WriteAddedLine (text, line);
		}
#pragma warning restore 0169

		/// <param name="text">RawText for accessing raw data</param>
		/// <param name="line">the line number within text</param>
		/// <summary>Output an added line.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='writeAddedLine' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.RawText'] and parameter[2][@type='int']]"
		[Register ("writeAddedLine", "(Lorg/eclipse/jgit/diff/RawText;I)V", "GetWriteAddedLine_Lorg_eclipse_jgit_diff_RawText_IHandler")]
		protected virtual unsafe void WriteAddedLine (global::Org.Eclipse.Jgit.Diff.RawText text, int line)
		{
			const string __id = "writeAddedLine.(Lorg/eclipse/jgit/diff/RawText;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				__args [1] = new JniArgumentValue (line);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (text);
			}
		}

		static Delegate cb_writeContextLine_Lorg_eclipse_jgit_diff_RawText_I;
#pragma warning disable 0169
		static Delegate GetWriteContextLine_Lorg_eclipse_jgit_diff_RawText_IHandler ()
		{
			if (cb_writeContextLine_Lorg_eclipse_jgit_diff_RawText_I == null)
				cb_writeContextLine_Lorg_eclipse_jgit_diff_RawText_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteContextLine_Lorg_eclipse_jgit_diff_RawText_I);
			return cb_writeContextLine_Lorg_eclipse_jgit_diff_RawText_I;
		}

		static void n_WriteContextLine_Lorg_eclipse_jgit_diff_RawText_I (IntPtr jnienv, IntPtr native__this, IntPtr native_text, int line)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_text, JniHandleOwnership.DoNotTransfer);
			__this.WriteContextLine (text, line);
		}
#pragma warning restore 0169

		/// <param name="text">RawText for accessing raw data</param>
		/// <param name="line">the line number within text</param>
		/// <summary>Output a line of context (unmodified line).</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='writeContextLine' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.RawText'] and parameter[2][@type='int']]"
		[Register ("writeContextLine", "(Lorg/eclipse/jgit/diff/RawText;I)V", "GetWriteContextLine_Lorg_eclipse_jgit_diff_RawText_IHandler")]
		protected virtual unsafe void WriteContextLine (global::Org.Eclipse.Jgit.Diff.RawText text, int line)
		{
			const string __id = "writeContextLine.(Lorg/eclipse/jgit/diff/RawText;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				__args [1] = new JniArgumentValue (line);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (text);
			}
		}

		static Delegate cb_writeHunkHeader_IIII;
#pragma warning disable 0169
		static Delegate GetWriteHunkHeader_IIIIHandler ()
		{
			if (cb_writeHunkHeader_IIII == null)
				cb_writeHunkHeader_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_WriteHunkHeader_IIII);
			return cb_writeHunkHeader_IIII;
		}

		static void n_WriteHunkHeader_IIII (IntPtr jnienv, IntPtr native__this, int aStartLine, int aEndLine, int bStartLine, int bEndLine)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteHunkHeader (aStartLine, aEndLine, bStartLine, bEndLine);
		}
#pragma warning restore 0169

		/// <param name="aStartLine">within first source</param>
		/// <param name="aEndLine">within first source</param>
		/// <param name="bStartLine">within second source</param>
		/// <param name="bEndLine">within second source</param>
		/// <summary>Output a hunk header</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='writeHunkHeader' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeHunkHeader", "(IIII)V", "GetWriteHunkHeader_IIIIHandler")]
		protected virtual unsafe void WriteHunkHeader (int aStartLine, int aEndLine, int bStartLine, int bEndLine)
		{
			const string __id = "writeHunkHeader.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (aStartLine);
				__args [1] = new JniArgumentValue (aEndLine);
				__args [2] = new JniArgumentValue (bStartLine);
				__args [3] = new JniArgumentValue (bEndLine);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeLine_CLorg_eclipse_jgit_diff_RawText_I;
#pragma warning disable 0169
		static Delegate GetWriteLine_CLorg_eclipse_jgit_diff_RawText_IHandler ()
		{
			if (cb_writeLine_CLorg_eclipse_jgit_diff_RawText_I == null)
				cb_writeLine_CLorg_eclipse_jgit_diff_RawText_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPCLI_V) n_WriteLine_CLorg_eclipse_jgit_diff_RawText_I);
			return cb_writeLine_CLorg_eclipse_jgit_diff_RawText_I;
		}

		static void n_WriteLine_CLorg_eclipse_jgit_diff_RawText_I (IntPtr jnienv, IntPtr native__this, char prefix, IntPtr native_text, int cur)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_text, JniHandleOwnership.DoNotTransfer);
			__this.WriteLine (prefix, text, cur);
		}
#pragma warning restore 0169

		/// <param name="prefix">prefix before the line, typically '-', '+', ' '.</param>
		/// <param name="text">the text object to obtain the line from.</param>
		/// <param name="cur">line number to output.</param>
		/// <summary>Write a standard patch script line.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='writeLine' and count(parameter)=3 and parameter[1][@type='char'] and parameter[2][@type='org.eclipse.jgit.diff.RawText'] and parameter[3][@type='int']]"
		[Register ("writeLine", "(CLorg/eclipse/jgit/diff/RawText;I)V", "GetWriteLine_CLorg_eclipse_jgit_diff_RawText_IHandler")]
		protected virtual unsafe void WriteLine (char prefix, global::Org.Eclipse.Jgit.Diff.RawText text, int cur)
		{
			const string __id = "writeLine.(CLorg/eclipse/jgit/diff/RawText;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (prefix);
				__args [1] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				__args [2] = new JniArgumentValue (cur);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (text);
			}
		}

		static Delegate cb_writeRemovedLine_Lorg_eclipse_jgit_diff_RawText_I;
#pragma warning disable 0169
		static Delegate GetWriteRemovedLine_Lorg_eclipse_jgit_diff_RawText_IHandler ()
		{
			if (cb_writeRemovedLine_Lorg_eclipse_jgit_diff_RawText_I == null)
				cb_writeRemovedLine_Lorg_eclipse_jgit_diff_RawText_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteRemovedLine_Lorg_eclipse_jgit_diff_RawText_I);
			return cb_writeRemovedLine_Lorg_eclipse_jgit_diff_RawText_I;
		}

		static void n_WriteRemovedLine_Lorg_eclipse_jgit_diff_RawText_I (IntPtr jnienv, IntPtr native__this, IntPtr native_text, int line)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RawText> (native_text, JniHandleOwnership.DoNotTransfer);
			__this.WriteRemovedLine (text, line);
		}
#pragma warning restore 0169

		/// <param name="text">RawText for accessing raw data</param>
		/// <param name="line">the line number within text</param>
		/// <summary>Output a removed line</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffFormatter']/method[@name='writeRemovedLine' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.RawText'] and parameter[2][@type='int']]"
		[Register ("writeRemovedLine", "(Lorg/eclipse/jgit/diff/RawText;I)V", "GetWriteRemovedLine_Lorg_eclipse_jgit_diff_RawText_IHandler")]
		protected virtual unsafe void WriteRemovedLine (global::Org.Eclipse.Jgit.Diff.RawText text, int line)
		{
			const string __id = "writeRemovedLine.(Lorg/eclipse/jgit/diff/RawText;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((text == null) ? IntPtr.Zero : ((global::Java.Lang.Object) text).Handle);
				__args [1] = new JniArgumentValue (line);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (text);
			}
		}

	}
}
