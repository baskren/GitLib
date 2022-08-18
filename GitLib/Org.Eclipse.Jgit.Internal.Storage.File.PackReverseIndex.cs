using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Reverse index for forward pack index.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackReverseIndex']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackReverseIndex", DoNotGenerateAcw=true)]
	public partial class PackReverseIndex : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackReverseIndex", typeof (PackReverseIndex));

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

		protected PackReverseIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="packIndex">forward index - entries to (reverse) index.</param>
		/// <summary>Create reverse index from straight/forward pack index, by indexing all
		/// its entries.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackReverseIndex']/constructor[@name='PackReverseIndex' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.file.PackIndex']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/file/PackIndex;)V", "")]
		public unsafe PackReverseIndex (global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex packIndex) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/file/PackIndex;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((packIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packIndex).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (packIndex);
			}
		}

		static Delegate cb_findNextOffset_JJ;
#pragma warning disable 0169
		static Delegate GetFindNextOffset_JJHandler ()
		{
			if (cb_findNextOffset_JJ == null)
				cb_findNextOffset_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_J) n_FindNextOffset_JJ);
			return cb_findNextOffset_JJ;
		}

		static long n_FindNextOffset_JJ (IntPtr jnienv, IntPtr native__this, long offset, long maxOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackReverseIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FindNextOffset (offset, maxOffset);
		}
#pragma warning restore 0169

		/// <param name="offset">start offset of previous object (must be valid-existing
		///            offset).</param>
		/// <param name="maxOffset">maximum offset in a pack (returned when there is no next
		///            offset).</param>
		/// <summary>Search for the next offset to the specified offset in this pack (reverse)
		/// index.</summary>
		/// <returns>offset of the next object in a pack or maxOffset if provided
		///         offset was the last one.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackReverseIndex']/method[@name='findNextOffset' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("findNextOffset", "(JJ)J", "GetFindNextOffset_JJHandler")]
		public virtual unsafe long FindNextOffset (long offset, long maxOffset)
		{
			const string __id = "findNextOffset.(JJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue (maxOffset);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_findObject_J;
#pragma warning disable 0169
		static Delegate GetFindObject_JHandler ()
		{
			if (cb_findObject_J == null)
				cb_findObject_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_FindObject_J);
			return cb_findObject_J;
		}

		static IntPtr n_FindObject_J (IntPtr jnienv, IntPtr native__this, long offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackReverseIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindObject (offset));
		}
#pragma warning restore 0169

		/// <param name="offset">start offset of object to find.</param>
		/// <summary>Search for object id with the specified start offset in this pack
		/// (reverse) index.</summary>
		/// <returns>object id for this offset, or null if no object was found.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackReverseIndex']/method[@name='findObject' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("findObject", "(J)Lorg/eclipse/jgit/lib/ObjectId;", "GetFindObject_JHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId FindObject (long offset)
		{
			const string __id = "findObject.(J)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
