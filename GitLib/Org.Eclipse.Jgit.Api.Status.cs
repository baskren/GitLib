using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class telling where the working-tree, the index and the current HEAD differ
	/// from each other.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/Status", DoNotGenerateAcw=true)]
	public partial class Status : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/Status", typeof (Status));

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

		protected Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="diff">diff</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/constructor[@name='Status' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.IndexDiff']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/IndexDiff;)V", "")]
		public unsafe Status (global::Org.Eclipse.Jgit.Lib.IndexDiff diff) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/IndexDiff;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((diff == null) ? IntPtr.Zero : ((global::Java.Lang.Object) diff).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (diff);
			}
		}

		static Delegate cb_getAdded;
#pragma warning disable 0169
		static Delegate GetGetAddedHandler ()
		{
			if (cb_getAdded == null)
				cb_getAdded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdded);
			return cb_getAdded;
		}

		static IntPtr n_GetAdded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Added);
		}
#pragma warning restore 0169

		/// <returns>list of files added to the index, not in HEAD (e.g. what you get
		///         if you call 'git add ...' on a newly created file)</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Added {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getAdded' and count(parameter)=0]"
			[Register ("getAdded", "()Ljava/util/Set;", "GetGetAddedHandler")]
			get {
				const string __id = "getAdded.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChanged;
#pragma warning disable 0169
		static Delegate GetGetChangedHandler ()
		{
			if (cb_getChanged == null)
				cb_getChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChanged);
			return cb_getChanged;
		}

		static IntPtr n_GetChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Changed);
		}
#pragma warning restore 0169

		/// <returns>list of files changed from HEAD to index (e.g. what you get if
		///         you modify an existing file and call 'git add ...' on it)</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Changed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getChanged' and count(parameter)=0]"
			[Register ("getChanged", "()Ljava/util/Set;", "GetGetChangedHandler")]
			get {
				const string __id = "getChanged.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConflicting;
#pragma warning disable 0169
		static Delegate GetGetConflictingHandler ()
		{
			if (cb_getConflicting == null)
				cb_getConflicting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConflicting);
			return cb_getConflicting;
		}

		static IntPtr n_GetConflicting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Conflicting);
		}
#pragma warning restore 0169

		/// <returns>list of files that are in conflict. (e.g what you get if you
		///         modify file that was modified by someone else in the meantime)</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Conflicting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getConflicting' and count(parameter)=0]"
			[Register ("getConflicting", "()Ljava/util/Set;", "GetGetConflictingHandler")]
			get {
				const string __id = "getConflicting.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConflictingStageState;
#pragma warning disable 0169
		static Delegate GetGetConflictingStageStateHandler ()
		{
			if (cb_getConflictingStageState == null)
				cb_getConflictingStageState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConflictingStageState);
			return cb_getConflictingStageState;
		}

		static IntPtr n_GetConflictingStageState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState>.ToLocalJniHandle (__this.ConflictingStageState);
		}
#pragma warning restore 0169

		/// <returns>a map from conflicting path to its <c>StageState</c>.</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> ConflictingStageState {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getConflictingStageState' and count(parameter)=0]"
			[Register ("getConflictingStageState", "()Ljava/util/Map;", "GetGetConflictingStageStateHandler")]
			get {
				const string __id = "getConflictingStageState.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasUncommittedChanges;
#pragma warning disable 0169
		static Delegate GetHasUncommittedChangesHandler ()
		{
			if (cb_hasUncommittedChanges == null)
				cb_hasUncommittedChanges = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasUncommittedChanges);
			return cb_hasUncommittedChanges;
		}

		static bool n_HasUncommittedChanges (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUncommittedChanges;
		}
#pragma warning restore 0169

		/// <returns>true if any tracked file is changed</returns>
		public virtual unsafe bool HasUncommittedChanges {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='hasUncommittedChanges' and count(parameter)=0]"
			[Register ("hasUncommittedChanges", "()Z", "GetHasUncommittedChangesHandler")]
			get {
				const string __id = "hasUncommittedChanges.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIgnoredNotInIndex;
#pragma warning disable 0169
		static Delegate GetGetIgnoredNotInIndexHandler ()
		{
			if (cb_getIgnoredNotInIndex == null)
				cb_getIgnoredNotInIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIgnoredNotInIndex);
			return cb_getIgnoredNotInIndex;
		}

		static IntPtr n_GetIgnoredNotInIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.IgnoredNotInIndex);
		}
#pragma warning restore 0169

		/// <returns>set of files and folders that are ignored and not in the index.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> IgnoredNotInIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getIgnoredNotInIndex' and count(parameter)=0]"
			[Register ("getIgnoredNotInIndex", "()Ljava/util/Set;", "GetGetIgnoredNotInIndexHandler")]
			get {
				const string __id = "getIgnoredNotInIndex.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isClean;
#pragma warning disable 0169
		static Delegate GetIsCleanHandler ()
		{
			if (cb_isClean == null)
				cb_isClean = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsClean);
			return cb_isClean;
		}

		static bool n_IsClean (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClean;
		}
#pragma warning restore 0169

		/// <returns>true if no differences exist between the working-tree, the index,
		///         and the current HEAD, false if differences do exist</returns>
		public virtual unsafe bool IsClean {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='isClean' and count(parameter)=0]"
			[Register ("isClean", "()Z", "GetIsCleanHandler")]
			get {
				const string __id = "isClean.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMissing;
#pragma warning disable 0169
		static Delegate GetGetMissingHandler ()
		{
			if (cb_getMissing == null)
				cb_getMissing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMissing);
			return cb_getMissing;
		}

		static IntPtr n_GetMissing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Missing);
		}
#pragma warning restore 0169

		/// <returns>list of files in index, but not filesystem (e.g. what you get if
		///         you call 'rm ...' on a existing file)</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Missing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getMissing' and count(parameter)=0]"
			[Register ("getMissing", "()Ljava/util/Set;", "GetGetMissingHandler")]
			get {
				const string __id = "getMissing.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModified;
#pragma warning disable 0169
		static Delegate GetGetModifiedHandler ()
		{
			if (cb_getModified == null)
				cb_getModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModified);
			return cb_getModified;
		}

		static IntPtr n_GetModified (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Modified);
		}
#pragma warning restore 0169

		/// <returns>list of files modified on disk relative to the index (e.g. what
		///         you get if you modify an existing file without adding it to the
		///         index)</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Modified {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getModified' and count(parameter)=0]"
			[Register ("getModified", "()Ljava/util/Set;", "GetGetModifiedHandler")]
			get {
				const string __id = "getModified.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoved;
#pragma warning disable 0169
		static Delegate GetGetRemovedHandler ()
		{
			if (cb_getRemoved == null)
				cb_getRemoved = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemoved);
			return cb_getRemoved;
		}

		static IntPtr n_GetRemoved (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Removed);
		}
#pragma warning restore 0169

		/// <returns>list of files removed from index, but in HEAD (e.g. what you get
		///         if you call 'git rm ...' on a existing file)</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Removed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getRemoved' and count(parameter)=0]"
			[Register ("getRemoved", "()Ljava/util/Set;", "GetGetRemovedHandler")]
			get {
				const string __id = "getRemoved.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUncommittedChanges;
#pragma warning disable 0169
		static Delegate GetGetUncommittedChangesHandler ()
		{
			if (cb_getUncommittedChanges == null)
				cb_getUncommittedChanges = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUncommittedChanges);
			return cb_getUncommittedChanges;
		}

		static IntPtr n_GetUncommittedChanges (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.UncommittedChanges);
		}
#pragma warning restore 0169

		/// <returns>set of files and folders that are known to the repo and changed
		///         either in the index or in the working tree.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> UncommittedChanges {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getUncommittedChanges' and count(parameter)=0]"
			[Register ("getUncommittedChanges", "()Ljava/util/Set;", "GetGetUncommittedChangesHandler")]
			get {
				const string __id = "getUncommittedChanges.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUntracked;
#pragma warning disable 0169
		static Delegate GetGetUntrackedHandler ()
		{
			if (cb_getUntracked == null)
				cb_getUntracked = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUntracked);
			return cb_getUntracked;
		}

		static IntPtr n_GetUntracked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Untracked);
		}
#pragma warning restore 0169

		/// <returns>list of files that are not ignored, and not in the index. (e.g.
		///         what you get if you create a new file without adding it to the
		///         index)</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Untracked {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getUntracked' and count(parameter)=0]"
			[Register ("getUntracked", "()Ljava/util/Set;", "GetGetUntrackedHandler")]
			get {
				const string __id = "getUntracked.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUntrackedFolders;
#pragma warning disable 0169
		static Delegate GetGetUntrackedFoldersHandler ()
		{
			if (cb_getUntrackedFolders == null)
				cb_getUntrackedFolders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUntrackedFolders);
			return cb_getUntrackedFolders;
		}

		static IntPtr n_GetUntrackedFolders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.UntrackedFolders);
		}
#pragma warning restore 0169

		/// <returns>set of directories that are not ignored, and not in the index.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> UntrackedFolders {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='Status']/method[@name='getUntrackedFolders' and count(parameter)=0]"
			[Register ("getUntrackedFolders", "()Ljava/util/Set;", "GetGetUntrackedFoldersHandler")]
			get {
				const string __id = "getUntrackedFolders.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
