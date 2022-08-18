using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>Instance of a specific <c>MergeStrategy</c> for a single <c>Repository</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/Merger", DoNotGenerateAcw=true)]
	public abstract partial class Merger : global::Java.Lang.Object {

		/// <summary>The repository this merger operates on.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/field[@name='db']"
		[Register ("db")]
		protected global::Org.Eclipse.Jgit.Lib.Repository Db {
			get {
				const string __id = "db.Lorg/eclipse/jgit/lib/Repository;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "db.Lorg/eclipse/jgit/lib/Repository;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Reader to support <c>#walk</c> and other object loading.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/field[@name='reader']"
		[Register ("reader")]
		protected global::Org.Eclipse.Jgit.Lib.ObjectReader Reader {
			get {
				const string __id = "reader.Lorg/eclipse/jgit/lib/ObjectReader;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "reader.Lorg/eclipse/jgit/lib/ObjectReader;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>If <c>#sourceObjects</c>[i] is a commit, this is the commit.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/field[@name='sourceCommits']"
		[Register ("sourceCommits")]
		protected IList<Org.Eclipse.Jgit.Revwalk.RevCommit> SourceCommits {
			get {
				const string __id = "sourceCommits.[Lorg/eclipse/jgit/revwalk/RevCommit;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Org.Eclipse.Jgit.Revwalk.RevCommit>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sourceCommits.[Lorg/eclipse/jgit/revwalk/RevCommit;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Eclipse.Jgit.Revwalk.RevCommit>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>The original objects supplied in the merge; this can be any tree-ish.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/field[@name='sourceObjects']"
		[Register ("sourceObjects")]
		protected IList<Org.Eclipse.Jgit.Revwalk.RevObject> SourceObjects {
			get {
				const string __id = "sourceObjects.[Lorg/eclipse/jgit/revwalk/RevObject;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Org.Eclipse.Jgit.Revwalk.RevObject>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sourceObjects.[Lorg/eclipse/jgit/revwalk/RevObject;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Eclipse.Jgit.Revwalk.RevObject>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>The trees matching every entry in <c>#sourceObjects</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/field[@name='sourceTrees']"
		[Register ("sourceTrees")]
		protected IList<Org.Eclipse.Jgit.Revwalk.RevTree> SourceTrees {
			get {
				const string __id = "sourceTrees.[Lorg/eclipse/jgit/revwalk/RevTree;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Org.Eclipse.Jgit.Revwalk.RevTree>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sourceTrees.[Lorg/eclipse/jgit/revwalk/RevTree;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Eclipse.Jgit.Revwalk.RevTree>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>A RevWalk for computing merge bases, or listing incoming commits.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/field[@name='walk']"
		[Register ("walk")]
		protected global::Org.Eclipse.Jgit.Revwalk.RevWalk Walk {
			get {
				const string __id = "walk.Lorg/eclipse/jgit/revwalk/RevWalk;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "walk.Lorg/eclipse/jgit/revwalk/RevWalk;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/Merger", typeof (Merger));

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

		protected Merger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="local">the repository this merger will read and write data on.</param>
		/// <summary>Create a new merge instance for a repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/constructor[@name='Merger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe Merger (global::Org.Eclipse.Jgit.Lib.Repository local) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseCommitId);
		}
#pragma warning restore 0169

		public abstract global::Org.Eclipse.Jgit.Lib.ObjectId BaseCommitId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='getBaseCommitId' and count(parameter)=0]"
			[Register ("getBaseCommitId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetBaseCommitIdHandler")]
			get; 
		}

		static Delegate cb_getObjectInserter;
#pragma warning disable 0169
		static Delegate GetGetObjectInserterHandler ()
		{
			if (cb_getObjectInserter == null)
				cb_getObjectInserter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectInserter);
			return cb_getObjectInserter;
		}

		static IntPtr n_GetObjectInserter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectInserter);
		}
#pragma warning restore 0169

		static Delegate cb_setObjectInserter_Lorg_eclipse_jgit_lib_ObjectInserter_;
#pragma warning disable 0169
		static Delegate GetSetObjectInserter_Lorg_eclipse_jgit_lib_ObjectInserter_Handler ()
		{
			if (cb_setObjectInserter_Lorg_eclipse_jgit_lib_ObjectInserter_ == null)
				cb_setObjectInserter_Lorg_eclipse_jgit_lib_ObjectInserter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetObjectInserter_Lorg_eclipse_jgit_lib_ObjectInserter_);
			return cb_setObjectInserter_Lorg_eclipse_jgit_lib_ObjectInserter_;
		}

		static void n_SetObjectInserter_Lorg_eclipse_jgit_lib_ObjectInserter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oi)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oi = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (native_oi, JniHandleOwnership.DoNotTransfer);
			__this.ObjectInserter = oi;
		}
#pragma warning restore 0169

		/// <returns>an object writer to create objects in <c>#getRepository()</c>.</returns>
		/// <summary>Set the inserter this merger will use to create objects.</summary>
		/// <param name="oi">the inserter instance to use. Must be associated with the
		///            repository instance returned by <c>#getRepository()</c>.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectInserter ObjectInserter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='getObjectInserter' and count(parameter)=0]"
			[Register ("getObjectInserter", "()Lorg/eclipse/jgit/lib/ObjectInserter;", "GetGetObjectInserterHandler")]
			get {
				const string __id = "getObjectInserter.()Lorg/eclipse/jgit/lib/ObjectInserter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='setObjectInserter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectInserter']]"
			[Register ("setObjectInserter", "(Lorg/eclipse/jgit/lib/ObjectInserter;)V", "GetSetObjectInserter_Lorg_eclipse_jgit_lib_ObjectInserter_Handler")]
			set {
				const string __id = "setObjectInserter.(Lorg/eclipse/jgit/lib/ObjectInserter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getRepository;
#pragma warning disable 0169
		static Delegate GetGetRepositoryHandler ()
		{
			if (cb_getRepository == null)
				cb_getRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepository);
			return cb_getRepository;
		}

		static IntPtr n_GetRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		/// <returns>the repository this merger operates on.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "GetGetRepositoryHandler")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/lib/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResultTreeId;
#pragma warning disable 0169
		static Delegate GetGetResultTreeIdHandler ()
		{
			if (cb_getResultTreeId == null)
				cb_getResultTreeId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResultTreeId);
			return cb_getResultTreeId;
		}

		static IntPtr n_GetResultTreeId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResultTreeId);
		}
#pragma warning restore 0169

		public abstract global::Org.Eclipse.Jgit.Lib.ObjectId ResultTreeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='getResultTreeId' and count(parameter)=0]"
			[Register ("getResultTreeId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetResultTreeIdHandler")]
			get; 
		}

		static Delegate cb_getBaseCommit_II;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetBaseCommit_IIHandler ()
		{
			if (cb_getBaseCommit_II == null)
				cb_getBaseCommit_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_GetBaseCommit_II);
			return cb_getBaseCommit_II;
		}

		[Obsolete]
		static IntPtr n_GetBaseCommit_II (IntPtr jnienv, IntPtr native__this, int aIdx, int bIdx)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBaseCommit (aIdx, bIdx));
		}
#pragma warning restore 0169

		/// <param name="aIdx">index of the first commit in tips passed to
		///            <c>#merge(RevCommit...)</c>.</param>
		/// <param name="bIdx">index of the second commit in tips passed to
		///            <c>#merge(RevCommit...)</c>.</param>
		/// <summary>Return the merge base of two commits.</summary>
		/// <returns>the merge base of two commits</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='getBaseCommit' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("getBaseCommit", "(II)Lorg/eclipse/jgit/revwalk/RevCommit;", "GetGetBaseCommit_IIHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit GetBaseCommit (int aIdx, int bIdx)
		{
			const string __id = "getBaseCommit.(II)Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (aIdx);
				__args [1] = new JniArgumentValue (bIdx);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetGetBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_getBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_getBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_getBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static IntPtr n_GetBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var a = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_a, JniHandleOwnership.DoNotTransfer);
			var b = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_b, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBaseCommit (a, b));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="a">the first commit in <c>#sourceObjects</c>.</param>
		/// <param name="b">the second commit in <c>#sourceObjects</c>.</param>
		/// <summary>Return the merge base of two commits.</summary>
		/// <returns>the merge base of two commits</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='getBaseCommit' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("getBaseCommit", "(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/revwalk/RevCommit;", "GetGetBaseCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit GetBaseCommit (global::Org.Eclipse.Jgit.Revwalk.RevCommit a, global::Org.Eclipse.Jgit.Revwalk.RevCommit b)
		{
			const string __id = "getBaseCommit.(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_merge_ZarrayLorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetMerge_ZarrayLorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_merge_ZarrayLorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_merge_ZarrayLorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_Z) n_Merge_ZarrayLorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_merge_ZarrayLorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_Merge_ZarrayLorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, bool flush, IntPtr native_tips)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tips = (global::Org.Eclipse.Jgit.Lib.AnyObjectId[]) JNIEnv.GetArray (native_tips, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Lib.AnyObjectId));
			bool __ret = __this.Merge (flush, tips);
			if (tips != null)
				JNIEnv.CopyArray (tips, native_tips);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='merge' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId...']]"
		[Register ("merge", "(Z[Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetMerge_ZarrayLorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe bool Merge (bool flush, params global::Org.Eclipse.Jgit.Lib.AnyObjectId[] tips)
		{
			const string __id = "merge.(Z[Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			IntPtr native_tips = JNIEnv.NewArray (tips);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (flush);
				__args [1] = new JniArgumentValue (native_tips);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (tips != null) {
					JNIEnv.CopyArray (native_tips, tips);
					JNIEnv.DeleteLocalRef (native_tips);
				}
				global::System.GC.KeepAlive (tips);
			}
		}

		static Delegate cb_merge_arrayLorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetMerge_arrayLorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_merge_arrayLorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_merge_arrayLorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Merge_arrayLorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_merge_arrayLorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_Merge_arrayLorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tips)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tips = (global::Org.Eclipse.Jgit.Lib.AnyObjectId[]) JNIEnv.GetArray (native_tips, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Lib.AnyObjectId));
			bool __ret = __this.Merge (tips);
			if (tips != null)
				JNIEnv.CopyArray (tips, native_tips);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId...']]"
		[Register ("merge", "([Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetMerge_arrayLorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe bool Merge (params global::Org.Eclipse.Jgit.Lib.AnyObjectId[] tips)
		{
			const string __id = "merge.([Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			IntPtr native_tips = JNIEnv.NewArray (tips);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tips);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (tips != null) {
					JNIEnv.CopyArray (native_tips, tips);
					JNIEnv.DeleteLocalRef (native_tips);
				}
				global::System.GC.KeepAlive (tips);
			}
		}

		static Delegate cb_mergeImpl;
#pragma warning disable 0169
		static Delegate GetMergeImplHandler ()
		{
			if (cb_mergeImpl == null)
				cb_mergeImpl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_MergeImpl);
			return cb_mergeImpl;
		}

		static bool n_MergeImpl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MergeImpl ();
		}
#pragma warning restore 0169

		/// <summary>Execute the merge.</summary>
		/// <returns>true if the merge was completed without conflicts; false if the
		///         merge strategy cannot handle this merge or there were conflicts
		///         preventing it from automatically resolving all paths.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='mergeImpl' and count(parameter)=0]"
		[Register ("mergeImpl", "()Z", "GetMergeImplHandler")]
		protected abstract bool MergeImpl ();

		static Delegate cb_openTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetOpenTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_openTree_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_openTree_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OpenTree_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_openTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_OpenTree_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_treeId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var treeId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_treeId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenTree (treeId));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="treeId">the tree to scan; must be a tree (not a treeish).</param>
		/// <summary>Open an iterator over a tree.</summary>
		/// <returns>an iterator for the tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='openTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("openTree", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;", "GetOpenTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator OpenTree (global::Org.Eclipse.Jgit.Lib.AnyObjectId treeId)
		{
			const string __id = "openTree.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((treeId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) treeId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (treeId);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/Merger", DoNotGenerateAcw=true)]
	internal partial class MergerInvoker : Merger {
		public MergerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/Merger", typeof (MergerInvoker));

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

		/// <returns>the ID of the commit that was used as merge base for merging, or
		///         null if no merge base was used or it was set manually</returns>
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId BaseCommitId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='Merger']/method[@name='getBaseCommitId' and count(parameter)=0]"
			[Register ("getBaseCommitId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetBaseCommitIdHandler")]
			get {
				const string __id = "getBaseCommitId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
