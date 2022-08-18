using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Notes {

	/// <summary>Default implementation of the <c>NoteMerger</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='DefaultNoteMerger']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/notes/DefaultNoteMerger", DoNotGenerateAcw=true)]
	public partial class DefaultNoteMerger : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Notes.INoteMerger {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/notes/DefaultNoteMerger", typeof (DefaultNoteMerger));

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

		protected DefaultNoteMerger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='DefaultNoteMerger']/constructor[@name='DefaultNoteMerger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultNoteMerger () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_;
#pragma warning disable 0169
		static Delegate GetMerge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_Handler ()
		{
			if (cb_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_ == null)
				cb_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_L) n_Merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_);
			return cb_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_;
		}

		static IntPtr n_Merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_ (IntPtr jnienv, IntPtr native__this, IntPtr native__base, IntPtr native_ours, IntPtr native_theirs, IntPtr native_reader, IntPtr native_inserter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.DefaultNoteMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @base = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (native__base, JniHandleOwnership.DoNotTransfer);
			var ours = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (native_ours, JniHandleOwnership.DoNotTransfer);
			var theirs = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (native_theirs, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			var inserter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (native_inserter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Merge (@base, ours, theirs, reader, inserter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='DefaultNoteMerger']/method[@name='merge' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.notes.Note'] and parameter[2][@type='org.eclipse.jgit.notes.Note'] and parameter[3][@type='org.eclipse.jgit.notes.Note'] and parameter[4][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[5][@type='org.eclipse.jgit.lib.ObjectInserter']]"
		[Register ("merge", "(Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/notes/Note;", "GetMerge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Notes.Note Merge (global::Org.Eclipse.Jgit.Notes.Note @base, global::Org.Eclipse.Jgit.Notes.Note ours, global::Org.Eclipse.Jgit.Notes.Note theirs, global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.ObjectInserter inserter)
		{
			const string __id = "merge.(Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/notes/Note;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue ((ours == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ours).Handle);
				__args [2] = new JniArgumentValue ((theirs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theirs).Handle);
				__args [3] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [4] = new JniArgumentValue ((inserter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inserter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (ours);
				global::System.GC.KeepAlive (theirs);
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (inserter);
			}
		}

	}
}
