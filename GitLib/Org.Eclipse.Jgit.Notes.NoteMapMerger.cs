using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Notes {

	/// <summary>Three-way note tree merge.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMapMerger']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/notes/NoteMapMerger", DoNotGenerateAcw=true)]
	public partial class NoteMapMerger : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/notes/NoteMapMerger", typeof (NoteMapMerger));

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

		protected NoteMapMerger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="db">Git repository</param>
		/// <summary>Constructs a NoteMapMerger with <c>DefaultNoteMerger</c> as the merger
		/// for notes and the <c>MergeStrategy#RESOLVE</c> as the strategy for
		/// resolving conflicts on non-notes</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMapMerger']/constructor[@name='NoteMapMerger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe NoteMapMerger (global::Org.Eclipse.Jgit.Lib.Repository db) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

		/// <param name="db">Git repository</param>
		/// <param name="noteMerger">note merger for merging conflicting changes on a note</param>
		/// <param name="nonNotesMergeStrategy">merge strategy for merging non-note entries</param>
		/// <summary>Constructs a NoteMapMerger with custom <c>NoteMerger</c> and custom
		/// <c>MergeStrategy</c>.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMapMerger']/constructor[@name='NoteMapMerger' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.notes.NoteMerger'] and parameter[3][@type='org.eclipse.jgit.merge.MergeStrategy']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/notes/NoteMerger;Lorg/eclipse/jgit/merge/MergeStrategy;)V", "")]
		public unsafe NoteMapMerger (global::Org.Eclipse.Jgit.Lib.Repository db, global::Org.Eclipse.Jgit.Notes.INoteMerger noteMerger, global::Org.Eclipse.Jgit.Merge.MergeStrategy nonNotesMergeStrategy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/notes/NoteMerger;Lorg/eclipse/jgit/merge/MergeStrategy;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue ((noteMerger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) noteMerger).Handle);
				__args [2] = new JniArgumentValue ((nonNotesMergeStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nonNotesMergeStrategy).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (db);
				global::System.GC.KeepAlive (noteMerger);
				global::System.GC.KeepAlive (nonNotesMergeStrategy);
			}
		}

		static Delegate cb_merge_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_;
#pragma warning disable 0169
		static Delegate GetMerge_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Handler ()
		{
			if (cb_merge_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_ == null)
				cb_merge_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Merge_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_);
			return cb_merge_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_;
		}

		static IntPtr n_Merge_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native__base, IntPtr native_ours, IntPtr native_theirs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMapMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @base = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (native__base, JniHandleOwnership.DoNotTransfer);
			var ours = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (native_ours, JniHandleOwnership.DoNotTransfer);
			var theirs = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (native_theirs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Merge (@base, ours, theirs));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="base">base version of the note tree</param>
		/// <param name="ours">ours version of the note tree</param>
		/// <param name="theirs">theirs version of the note tree</param>
		/// <summary>Performs the merge.</summary>
		/// <returns>merge result as a new NoteMap</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMapMerger']/method[@name='merge' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.notes.NoteMap'] and parameter[2][@type='org.eclipse.jgit.notes.NoteMap'] and parameter[3][@type='org.eclipse.jgit.notes.NoteMap']]"
		[Register ("merge", "(Lorg/eclipse/jgit/notes/NoteMap;Lorg/eclipse/jgit/notes/NoteMap;Lorg/eclipse/jgit/notes/NoteMap;)Lorg/eclipse/jgit/notes/NoteMap;", "GetMerge_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Lorg_eclipse_jgit_notes_NoteMap_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Notes.NoteMap Merge (global::Org.Eclipse.Jgit.Notes.NoteMap @base, global::Org.Eclipse.Jgit.Notes.NoteMap ours, global::Org.Eclipse.Jgit.Notes.NoteMap theirs)
		{
			const string __id = "merge.(Lorg/eclipse/jgit/notes/NoteMap;Lorg/eclipse/jgit/notes/NoteMap;Lorg/eclipse/jgit/notes/NoteMap;)Lorg/eclipse/jgit/notes/NoteMap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue ((ours == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ours).Handle);
				__args [2] = new JniArgumentValue ((theirs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theirs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (ours);
				global::System.GC.KeepAlive (theirs);
			}
		}

	}
}
