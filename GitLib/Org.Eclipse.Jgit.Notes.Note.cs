using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Notes {

	/// <summary>In-memory representation of a single note attached to one object.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='Note']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/notes/Note", DoNotGenerateAcw=true)]
	public partial class Note : global::Org.Eclipse.Jgit.Lib.ObjectId {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/notes/Note", typeof (Note));

		internal static new IntPtr class_ref {
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

		protected Note (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="noteOn">the object that has a note attached to it.</param>
		/// <param name="noteData">the actual note data contained in this note</param>
		/// <summary>A Git note about the object referenced by <c>noteOn</c>.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='Note']/constructor[@name='Note' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/ObjectId;)V", "")]
		public unsafe Note (global::Org.Eclipse.Jgit.Lib.AnyObjectId noteOn, global::Org.Eclipse.Jgit.Lib.ObjectId noteData) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/ObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((noteOn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) noteOn).Handle);
				__args [1] = new JniArgumentValue ((noteData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) noteData).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (noteOn);
				global::System.GC.KeepAlive (noteData);
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		/// <returns>the note content</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='Note']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
