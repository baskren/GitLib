using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>Detect and resolve object renames.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/RenameDetector", DoNotGenerateAcw=true)]
	public partial class RenameDetector : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/RenameDetector", typeof (RenameDetector));

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

		protected RenameDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="reader">reader to obtain objects from the repository with.</param>
		/// <param name="cfg">diff config specifying rename detection options.</param>
		/// <summary>Create a new rename detector with a specified reader and diff config.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/constructor[@name='RenameDetector' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='org.eclipse.jgit.diff.DiffConfig']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/diff/DiffConfig;)V", "")]
		public unsafe RenameDetector (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Diff.DiffConfig cfg) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/diff/DiffConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (cfg);
			}
		}

		/// <param name="repo">the repository to use for rename detection</param>
		/// <summary>Create a new rename detector for the given repository</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/constructor[@name='RenameDetector' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe RenameDetector (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_getBreakScore;
#pragma warning disable 0169
		static Delegate GetGetBreakScoreHandler ()
		{
			if (cb_getBreakScore == null)
				cb_getBreakScore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBreakScore);
			return cb_getBreakScore;
		}

		static int n_GetBreakScore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BreakScore;
		}
#pragma warning restore 0169

		static Delegate cb_setBreakScore_I;
#pragma warning disable 0169
		static Delegate GetSetBreakScore_IHandler ()
		{
			if (cb_setBreakScore_I == null)
				cb_setBreakScore_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBreakScore_I);
			return cb_setBreakScore_I;
		}

		static void n_SetBreakScore_I (IntPtr jnienv, IntPtr native__this, int breakScore)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BreakScore = breakScore;
		}
#pragma warning restore 0169

		/// <returns>the similarity score required to keep modified file pairs
		///         together. Any modify pairs that score below this will be broken
		///         apart into separate add/deletes. Values less than or equal to
		///         zero indicate that no modifies will be broken apart. Values over
		///         100 cause all modify pairs to be broken.</returns>
		/// <param name="breakScore">the similarity score required to keep modified file pairs
		///            together. Any modify pairs that score below this will be
		///            broken apart into separate add/deletes. Values less than or
		///            equal to zero indicate that no modifies will be broken apart.
		///            Values over 100 cause all modify pairs to be broken.</param>
		public virtual unsafe int BreakScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='getBreakScore' and count(parameter)=0]"
			[Register ("getBreakScore", "()I", "GetGetBreakScoreHandler")]
			get {
				const string __id = "getBreakScore.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='setBreakScore' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBreakScore", "(I)V", "GetSetBreakScore_IHandler")]
			set {
				const string __id = "setBreakScore.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isOverRenameLimit;
#pragma warning disable 0169
		static Delegate GetIsOverRenameLimitHandler ()
		{
			if (cb_isOverRenameLimit == null)
				cb_isOverRenameLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOverRenameLimit);
			return cb_isOverRenameLimit;
		}

		static bool n_IsOverRenameLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOverRenameLimit;
		}
#pragma warning restore 0169

		/// <summary>Check if the detector is over the rename limit.</summary>
		/// <returns>true if the detector has more file additions or removals than the
		///         rename limit is currently set to. In such configurations the
		///         detector will skip expensive computation.</returns>
		public virtual unsafe bool IsOverRenameLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='isOverRenameLimit' and count(parameter)=0]"
			[Register ("isOverRenameLimit", "()Z", "GetIsOverRenameLimitHandler")]
			get {
				const string __id = "isOverRenameLimit.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRenameLimit;
#pragma warning disable 0169
		static Delegate GetGetRenameLimitHandler ()
		{
			if (cb_getRenameLimit == null)
				cb_getRenameLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRenameLimit);
			return cb_getRenameLimit;
		}

		static int n_GetRenameLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RenameLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setRenameLimit_I;
#pragma warning disable 0169
		static Delegate GetSetRenameLimit_IHandler ()
		{
			if (cb_setRenameLimit_I == null)
				cb_setRenameLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRenameLimit_I);
			return cb_setRenameLimit_I;
		}

		static void n_SetRenameLimit_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RenameLimit = limit;
		}
#pragma warning restore 0169

		/// <returns>limit on number of paths to perform inexact rename detection.</returns>
		/// <summary>Set the limit on the number of files to perform inexact rename detection.</summary>
		/// <param name="limit">new file limit.</param>
		public virtual unsafe int RenameLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='getRenameLimit' and count(parameter)=0]"
			[Register ("getRenameLimit", "()I", "GetGetRenameLimitHandler")]
			get {
				const string __id = "getRenameLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='setRenameLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRenameLimit", "(I)V", "GetSetRenameLimit_IHandler")]
			set {
				const string __id = "setRenameLimit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRenameScore;
#pragma warning disable 0169
		static Delegate GetGetRenameScoreHandler ()
		{
			if (cb_getRenameScore == null)
				cb_getRenameScore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRenameScore);
			return cb_getRenameScore;
		}

		static int n_GetRenameScore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RenameScore;
		}
#pragma warning restore 0169

		static Delegate cb_setRenameScore_I;
#pragma warning disable 0169
		static Delegate GetSetRenameScore_IHandler ()
		{
			if (cb_setRenameScore_I == null)
				cb_setRenameScore_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRenameScore_I);
			return cb_setRenameScore_I;
		}

		static void n_SetRenameScore_I (IntPtr jnienv, IntPtr native__this, int score)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RenameScore = score;
		}
#pragma warning restore 0169

		/// <returns>minimum score required to pair an add/delete as a rename. The
		///         score ranges are within the bounds of (0, 100).</returns>
		/// <summary>Set the minimum score required to pair an add/delete as a rename.</summary>
		/// <param name="score">new rename score, must be within [0, 100].</param>
		public virtual unsafe int RenameScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='getRenameScore' and count(parameter)=0]"
			[Register ("getRenameScore", "()I", "GetGetRenameScoreHandler")]
			get {
				const string __id = "getRenameScore.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='setRenameScore' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRenameScore", "(I)V", "GetSetRenameScore_IHandler")]
			set {
				const string __id = "setRenameScore.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lorg_eclipse_jgit_diff_DiffEntry_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_diff_DiffEntry_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_diff_DiffEntry_ == null)
				cb_add_Lorg_eclipse_jgit_diff_DiffEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Lorg_eclipse_jgit_diff_DiffEntry_);
			return cb_add_Lorg_eclipse_jgit_diff_DiffEntry_;
		}

		static void n_Add_Lorg_eclipse_jgit_diff_DiffEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entry = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (native_entry, JniHandleOwnership.DoNotTransfer);
			__this.Add (entry);
		}
#pragma warning restore 0169

		/// <param name="entry">to add.</param>
		/// <summary>Add an entry to be considered for rename detection.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry']]"
		[Register ("add", "(Lorg/eclipse/jgit/diff/DiffEntry;)V", "GetAdd_Lorg_eclipse_jgit_diff_DiffEntry_Handler")]
		public virtual unsafe void Add (global::Org.Eclipse.Jgit.Diff.DiffEntry entry)
		{
			const string __id = "add.(Lorg/eclipse/jgit/diff/DiffEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (entry);
			}
		}

		static Delegate cb_addAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_util_Collection_Handler ()
		{
			if (cb_addAll_Ljava_util_Collection_ == null)
				cb_addAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddAll_Ljava_util_Collection_);
			return cb_addAll_Ljava_util_Collection_;
		}

		static void n_AddAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entriesToAdd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entriesToAdd = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (native_entriesToAdd, JniHandleOwnership.DoNotTransfer);
			__this.AddAll (entriesToAdd);
		}
#pragma warning restore 0169

		/// <param name="entriesToAdd">one or more entries to add.</param>
		/// <summary>Add entries to be considered for rename detection.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.diff.DiffEntry&gt;']]"
		[Register ("addAll", "(Ljava/util/Collection;)V", "GetAddAll_Ljava_util_Collection_Handler")]
		public virtual unsafe void AddAll (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Diff.DiffEntry> entriesToAdd)
		{
			const string __id = "addAll.(Ljava/util/Collection;)V";
			IntPtr native_entriesToAdd = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (entriesToAdd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entriesToAdd);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entriesToAdd);
				global::System.GC.KeepAlive (entriesToAdd);
			}
		}

		static Delegate cb_compute;
#pragma warning disable 0169
		static Delegate GetComputeHandler ()
		{
			if (cb_compute == null)
				cb_compute = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Compute);
			return cb_compute;
		}

		static IntPtr n_Compute (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (__this.Compute ());
		}
#pragma warning restore 0169

		/// <summary>Detect renames in the current file set.</summary>
		/// <returns>an unmodifiable list of <c>DiffEntry</c>s representing all files
		///         that have been changed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='compute' and count(parameter)=0]"
		[Register ("compute", "()Ljava/util/List;", "GetComputeHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Compute ()
		{
			const string __id = "compute.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compute_Lorg_eclipse_jgit_diff_ContentSource_Pair_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetCompute_Lorg_eclipse_jgit_diff_ContentSource_Pair_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_compute_Lorg_eclipse_jgit_diff_ContentSource_Pair_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_compute_Lorg_eclipse_jgit_diff_ContentSource_Pair_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Compute_Lorg_eclipse_jgit_diff_ContentSource_Pair_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_compute_Lorg_eclipse_jgit_diff_ContentSource_Pair_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_Compute_Lorg_eclipse_jgit_diff_ContentSource_Pair_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader, IntPtr native_pm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.ContentSource.Pair> (native_reader, JniHandleOwnership.DoNotTransfer);
			var pm = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_pm, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (__this.Compute (reader, pm));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='compute' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.ContentSource.Pair'] and parameter[2][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("compute", "(Lorg/eclipse/jgit/diff/ContentSource$Pair;Lorg/eclipse/jgit/lib/ProgressMonitor;)Ljava/util/List;", "GetCompute_Lorg_eclipse_jgit_diff_ContentSource_Pair_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Compute (global::Org.Eclipse.Jgit.Diff.ContentSource.Pair reader, global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm)
		{
			const string __id = "compute.(Lorg/eclipse/jgit/diff/ContentSource$Pair;Lorg/eclipse/jgit/lib/ProgressMonitor;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (pm);
			}
		}

		static Delegate cb_compute_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetCompute_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_compute_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_compute_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Compute_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_compute_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_Compute_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader, IntPtr native_pm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			var pm = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_pm, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (__this.Compute (reader, pm));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="reader">reader to obtain objects from the repository with.</param>
		/// <param name="pm">report progress during the detection phases.</param>
		/// <summary>Detect renames in the current file set.</summary>
		/// <returns>an unmodifiable list of <c>DiffEntry</c>s representing all files
		///         that have been changed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='compute' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("compute", "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/ProgressMonitor;)Ljava/util/List;", "GetCompute_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Compute (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm)
		{
			const string __id = "compute.(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/ProgressMonitor;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (pm);
			}
		}

		static Delegate cb_compute_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetCompute_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_compute_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_compute_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Compute_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_compute_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_Compute_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pm = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_pm, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (__this.Compute (pm));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pm">report progress during the detection phases.</param>
		/// <summary>Detect renames in the current file set.</summary>
		/// <returns>an unmodifiable list of <c>DiffEntry</c>s representing all files
		///         that have been changed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='compute' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("compute", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Ljava/util/List;", "GetCompute_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Compute (global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm)
		{
			const string __id = "compute.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (pm);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.RenameDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		/// <summary>Reset this rename detector for another rename detection pass.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='RenameDetector']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
