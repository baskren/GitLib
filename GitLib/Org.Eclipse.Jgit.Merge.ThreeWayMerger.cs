using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>A merge of 2 trees, using a common base ancestor tree.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMerger']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/ThreeWayMerger", DoNotGenerateAcw=true)]
	public abstract partial class ThreeWayMerger : global::Org.Eclipse.Jgit.Merge.Merger {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/ThreeWayMerger", typeof (ThreeWayMerger));

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

		protected ThreeWayMerger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="local">the repository this merger will read and write data on.</param>
		/// <summary>Create a new merge instance for a repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMerger']/constructor[@name='ThreeWayMerger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe ThreeWayMerger (global::Org.Eclipse.Jgit.Lib.Repository local) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (local);
			}
		}

		/// <param name="local">the repository this merger will read and write data on.</param>
		/// <param name="inCore">perform the merge in core with no working folder involved</param>
		/// <summary>Create a new merge instance for a repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMerger']/constructor[@name='ThreeWayMerger' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Z)V", "")]
		protected unsafe ThreeWayMerger (global::Org.Eclipse.Jgit.Lib.Repository local, bool inCore) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue (inCore);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (local);
			}
		}

		static Delegate cb_getBaseCommitId;
#pragma warning disable 0169
		static Delegate GetGetBaseCommitIdHandler ()
		{
			if (cb_getBaseCommitId == null)
				cb_getBaseCommitId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBaseCommitId);
			return cb_getBaseCommitId;
		}

		static IntPtr n_GetBaseCommitId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseCommitId);
		}
#pragma warning restore 0169

		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId BaseCommitId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMerger']/method[@name='getBaseCommitId' and count(parameter)=0]"
			[Register ("getBaseCommitId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetBaseCommitIdHandler")]
			get {
				const string __id = "getBaseCommitId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_mergeBase;
#pragma warning disable 0169
		static Delegate GetMergeBaseHandler ()
		{
			if (cb_mergeBase == null)
				cb_mergeBase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_MergeBase);
			return cb_mergeBase;
		}

		static IntPtr n_MergeBase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MergeBase ());
		}
#pragma warning restore 0169

		/// <summary>Create an iterator to walk the merge base.</summary>
		/// <returns>an iterator over the caller-specified merge base, or the natural
		///         merge base of the two input commits.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMerger']/method[@name='mergeBase' and count(parameter)=0]"
		[Register ("mergeBase", "()Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;", "GetMergeBaseHandler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator MergeBase ()
		{
			const string __id = "mergeBase.()Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBase_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetBase_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setBase_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setBase_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBase_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setBase_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_SetBase_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMerger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.SetBase (id);
		}
#pragma warning restore 0169

		/// <param name="id">common base treeish; null to automatically compute the common
		///            base from the input commits during
		///            <c>#merge(AnyObjectId...)</c>.</param>
		/// <summary>Set the common ancestor tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMerger']/method[@name='setBase' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setBase", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetSetBase_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void SetBase (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "setBase.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/ThreeWayMerger", DoNotGenerateAcw=true)]
	internal partial class ThreeWayMergerInvoker : ThreeWayMerger {
		public ThreeWayMergerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/ThreeWayMerger", typeof (ThreeWayMergerInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		/// <returns>resulting tree, if <c>#merge(AnyObjectId[])</c> returned true.</returns>
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ResultTreeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='getResultTreeId' and count(parameter)=0]"
			[Register ("getResultTreeId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetResultTreeIdHandler")]
			get {
				const string __id = "getResultTreeId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Execute the merge.</summary>
		/// <returns>true if the merge was completed without conflicts; false if the
		///         merge strategy cannot handle this merge or there were conflicts
		///         preventing it from automatically resolving all paths.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='mergeImpl' and count(parameter)=0]"
		[Register ("mergeImpl", "()Z", "GetMergeImplHandler")]
		protected override unsafe bool MergeImpl ()
		{
			const string __id = "mergeImpl.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
