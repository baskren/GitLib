using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Notes {

	/// <summary>Three-way note merge operation.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.notes']/interface[@name='NoteMerger']"
	[Register ("org/eclipse/jgit/notes/NoteMerger", "", "Org.Eclipse.Jgit.Notes.INoteMergerInvoker")]
	public partial interface INoteMerger : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/interface[@name='NoteMerger']/method[@name='merge' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.notes.Note'] and parameter[2][@type='org.eclipse.jgit.notes.Note'] and parameter[3][@type='org.eclipse.jgit.notes.Note'] and parameter[4][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[5][@type='org.eclipse.jgit.lib.ObjectInserter']]"
		/// <param name="base">version of the Note</param>
		/// <param name="ours">version of the Note</param>
		/// <param name="their">version of the Note</param>
		/// <param name="reader">the object reader that must be used to read Git objects</param>
		/// <param name="inserter">the object inserter that must be used to insert Git objects</param>
		/// <summary>Merges the conflicting note changes.</summary>
		/// <returns>the merge result</returns>
		[Register ("merge", "(Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/notes/Note;", "GetMerge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_Handler:Org.Eclipse.Jgit.Notes.INoteMergerInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Notes.Note Merge (global::Org.Eclipse.Jgit.Notes.Note @base, global::Org.Eclipse.Jgit.Notes.Note ours, global::Org.Eclipse.Jgit.Notes.Note their, global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.ObjectInserter inserter);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/notes/NoteMerger", DoNotGenerateAcw=true)]
	internal partial class INoteMergerInvoker : global::Java.Lang.Object, INoteMerger {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/notes/NoteMerger", typeof (INoteMergerInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static INoteMerger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INoteMerger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.notes.NoteMerger'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INoteMergerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_;
#pragma warning disable 0169
		static Delegate GetMerge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_Handler ()
		{
			if (cb_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_ == null)
				cb_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_L) n_Merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_);
			return cb_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_;
		}

		static IntPtr n_Merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_ (IntPtr jnienv, IntPtr native__this, IntPtr native__base, IntPtr native_ours, IntPtr native_their, IntPtr native_reader, IntPtr native_inserter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.INoteMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @base = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (native__base, JniHandleOwnership.DoNotTransfer);
			var ours = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (native_ours, JniHandleOwnership.DoNotTransfer);
			var their = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (native_their, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			var inserter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (native_inserter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Merge (@base, ours, their, reader, inserter));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_;
		public unsafe global::Org.Eclipse.Jgit.Notes.Note Merge (global::Org.Eclipse.Jgit.Notes.Note @base, global::Org.Eclipse.Jgit.Notes.Note ours, global::Org.Eclipse.Jgit.Notes.Note their, global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.ObjectInserter inserter)
		{
			if (id_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_ == IntPtr.Zero)
				id_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_ = JNIEnv.GetMethodID (class_ref, "merge", "(Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/notes/Note;Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/notes/Note;");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
			__args [1] = new JValue ((ours == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ours).Handle);
			__args [2] = new JValue ((their == null) ? IntPtr.Zero : ((global::Java.Lang.Object) their).Handle);
			__args [3] = new JValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
			__args [4] = new JValue ((inserter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inserter).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_merge_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_notes_Note_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_ObjectInserter_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
