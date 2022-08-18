using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Notes {

	/// <summary>This exception will be thrown from the <c>NoteMerger</c> when a conflict on
	/// Notes content is found during merge.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NotesMergeConflictException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/notes/NotesMergeConflictException", DoNotGenerateAcw=true)]
	public partial class NotesMergeConflictException : global::Java.IO.IOException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/notes/NotesMergeConflictException", typeof (NotesMergeConflictException));

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

		protected NotesMergeConflictException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="base">note version</param>
		/// <param name="ours">note version</param>
		/// <param name="theirs">note version</param>
		/// <summary>Construct a NotesMergeConflictException for the specified base, ours and
		/// theirs note versions.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NotesMergeConflictException']/constructor[@name='NotesMergeConflictException' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.notes.Note'] and parameter[2][@type='org.eclipse.jgit.notes.Note'] and parameter[3][@type='org.eclipse.jgit.notes.Note']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;)V", "")]
		public unsafe NotesMergeConflictException (global::Org.Eclipse.Jgit.Notes.Note @base, global::Org.Eclipse.Jgit.Notes.Note ours, global::Org.Eclipse.Jgit.Notes.Note theirs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue ((ours == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ours).Handle);
				__args [2] = new JniArgumentValue ((theirs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theirs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (ours);
				global::System.GC.KeepAlive (theirs);
			}
		}

	}
}
