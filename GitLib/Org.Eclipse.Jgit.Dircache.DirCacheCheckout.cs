using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Dircache {

	/// <summary>This class handles checking out one or two trees merging with the index.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheCheckout", DoNotGenerateAcw=true)]
	public partial class DirCacheCheckout : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheCheckout", typeof (DirCacheCheckout));

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

		protected DirCacheCheckout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">the repository in which we do the checkout</param>
		/// <param name="dc">the (already locked) Dircache for this repo</param>
		/// <param name="mergeCommitTree">the id of the tree of the</param>
		/// <summary>Constructs a DirCacheCeckout for checking out one tree, merging with the
		/// index.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/constructor[@name='DirCacheCheckout' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.dircache.DirCache'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/dircache/DirCache;Lorg/eclipse/jgit/lib/ObjectId;)V", "")]
		public unsafe DirCacheCheckout (global::Org.Eclipse.Jgit.Lib.Repository repo, global::Org.Eclipse.Jgit.Dircache.DirCache dc, global::Org.Eclipse.Jgit.Lib.ObjectId mergeCommitTree) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/dircache/DirCache;Lorg/eclipse/jgit/lib/ObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue ((dc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dc).Handle);
				__args [2] = new JniArgumentValue ((mergeCommitTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeCommitTree).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
				global::System.GC.KeepAlive (dc);
				global::System.GC.KeepAlive (mergeCommitTree);
			}
		}

		/// <param name="repo">the repository in which we do the checkout</param>
		/// <param name="dc">the (already locked) Dircache for this repo</param>
		/// <param name="mergeCommitTree">the id of the tree we want to fast-forward to</param>
		/// <param name="workingTree">an iterator over the repositories Working Tree</param>
		/// <summary>Constructs a DirCacheCeckout for checking out one tree, merging with the
		/// index.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/constructor[@name='DirCacheCheckout' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.dircache.DirCache'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[4][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/dircache/DirCache;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V", "")]
		public unsafe DirCacheCheckout (global::Org.Eclipse.Jgit.Lib.Repository repo, global::Org.Eclipse.Jgit.Dircache.DirCache dc, global::Org.Eclipse.Jgit.Lib.ObjectId mergeCommitTree, global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator workingTree) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/dircache/DirCache;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue ((dc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dc).Handle);
				__args [2] = new JniArgumentValue ((mergeCommitTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeCommitTree).Handle);
				__args [3] = new JniArgumentValue ((workingTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) workingTree).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
				global::System.GC.KeepAlive (dc);
				global::System.GC.KeepAlive (mergeCommitTree);
				global::System.GC.KeepAlive (workingTree);
			}
		}

		/// <param name="repo">the repository in which we do the checkout</param>
		/// <param name="headCommitTree">the id of the tree of the head commit</param>
		/// <param name="dc">the (already locked) Dircache for this repo</param>
		/// <param name="mergeCommitTree">the id of the tree we want to fast-forward to</param>
		/// <summary>Constructs a DirCacheCeckout for merging and checking out two trees (HEAD
		/// and mergeCommitTree) and the index.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/constructor[@name='DirCacheCheckout' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='org.eclipse.jgit.dircache.DirCache'] and parameter[4][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/dircache/DirCache;Lorg/eclipse/jgit/lib/ObjectId;)V", "")]
		public unsafe DirCacheCheckout (global::Org.Eclipse.Jgit.Lib.Repository repo, global::Org.Eclipse.Jgit.Lib.ObjectId headCommitTree, global::Org.Eclipse.Jgit.Dircache.DirCache dc, global::Org.Eclipse.Jgit.Lib.ObjectId mergeCommitTree) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/dircache/DirCache;Lorg/eclipse/jgit/lib/ObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue ((headCommitTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headCommitTree).Handle);
				__args [2] = new JniArgumentValue ((dc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dc).Handle);
				__args [3] = new JniArgumentValue ((mergeCommitTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeCommitTree).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
				global::System.GC.KeepAlive (headCommitTree);
				global::System.GC.KeepAlive (dc);
				global::System.GC.KeepAlive (mergeCommitTree);
			}
		}

		/// <param name="repo">the repository in which we do the checkout</param>
		/// <param name="headCommitTree">the id of the tree of the head commit</param>
		/// <param name="dc">the (already locked) Dircache for this repo</param>
		/// <param name="mergeCommitTree">the id of the tree we want to fast-forward to</param>
		/// <param name="workingTree">an iterator over the repositories Working Tree</param>
		/// <summary>Constructs a DirCacheCeckout for merging and checking out two trees (HEAD
		/// and mergeCommitTree) and the index.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/constructor[@name='DirCacheCheckout' and count(parameter)=5 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='org.eclipse.jgit.dircache.DirCache'] and parameter[4][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[5][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/dircache/DirCache;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V", "")]
		public unsafe DirCacheCheckout (global::Org.Eclipse.Jgit.Lib.Repository repo, global::Org.Eclipse.Jgit.Lib.ObjectId headCommitTree, global::Org.Eclipse.Jgit.Dircache.DirCache dc, global::Org.Eclipse.Jgit.Lib.ObjectId mergeCommitTree, global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator workingTree) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/dircache/DirCache;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue ((headCommitTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headCommitTree).Handle);
				__args [2] = new JniArgumentValue ((dc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dc).Handle);
				__args [3] = new JniArgumentValue ((mergeCommitTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeCommitTree).Handle);
				__args [4] = new JniArgumentValue ((workingTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) workingTree).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
				global::System.GC.KeepAlive (headCommitTree);
				global::System.GC.KeepAlive (dc);
				global::System.GC.KeepAlive (mergeCommitTree);
				global::System.GC.KeepAlive (workingTree);
			}
		}

		static Delegate cb_getConflicts;
#pragma warning disable 0169
		static Delegate GetGetConflictsHandler ()
		{
			if (cb_getConflicts == null)
				cb_getConflicts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConflicts);
			return cb_getConflicts;
		}

		static IntPtr n_GetConflicts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheCheckout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Conflicts);
		}
#pragma warning restore 0169

		/// <returns>a list of conflicts created by this checkout</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> Conflicts {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='getConflicts' and count(parameter)=0]"
			[Register ("getConflicts", "()Ljava/util/List;", "GetGetConflictsHandler")]
			get {
				const string __id = "getConflicts.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheCheckout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Removed);
		}
#pragma warning restore 0169

		/// <returns>a list of all files removed by this checkout</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> Removed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='getRemoved' and count(parameter)=0]"
			[Register ("getRemoved", "()Ljava/util/List;", "GetGetRemovedHandler")]
			get {
				const string __id = "getRemoved.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getToBeDeleted;
#pragma warning disable 0169
		static Delegate GetGetToBeDeletedHandler ()
		{
			if (cb_getToBeDeleted == null)
				cb_getToBeDeleted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetToBeDeleted);
			return cb_getToBeDeleted;
		}

		static IntPtr n_GetToBeDeleted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheCheckout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ToBeDeleted);
		}
#pragma warning restore 0169

		/// <returns>a list of paths (relative to the start of the working tree) of
		///         files which couldn't be deleted during last call to
		///         <c>#checkout()</c> . <c>#checkout()</c> detected that these
		///         files should be deleted but the deletion in the filesystem failed
		///         (e.g. because a file was locked). To have a consistent state of
		///         the working tree these files have to be deleted by the callers of
		///         <c>DirCacheCheckout</c>.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<string> ToBeDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='getToBeDeleted' and count(parameter)=0]"
			[Register ("getToBeDeleted", "()Ljava/util/List;", "GetGetToBeDeletedHandler")]
			get {
				const string __id = "getToBeDeleted.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdated;
#pragma warning disable 0169
		static Delegate GetGetUpdatedHandler ()
		{
			if (cb_getUpdated == null)
				cb_getUpdated = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUpdated);
			return cb_getUpdated;
		}

		static IntPtr n_GetUpdated (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheCheckout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.Updated);
		}
#pragma warning restore 0169

		/// <returns>a list of updated paths and objectIds</returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.ObjectId> Updated {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='getUpdated' and count(parameter)=0]"
			[Register ("getUpdated", "()Ljava/util/Map;", "GetGetUpdatedHandler")]
			get {
				const string __id = "getUpdated.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <param name="path">path</param>
		/// <summary>Check if path is a valid path for a checked out file name or ref name.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='checkValidPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("checkValidPath", "(Ljava/lang/String;)V", "")]
		public static unsafe void CheckValidPath (string path)
		{
			const string __id = "checkValidPath.(Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_checkout;
#pragma warning disable 0169
		static Delegate GetCheckoutHandler ()
		{
			if (cb_checkout == null)
				cb_checkout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Checkout);
			return cb_checkout;
		}

		static bool n_Checkout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheCheckout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Checkout ();
		}
#pragma warning restore 0169

		/// <summary>Execute this checkout</summary>
		/// <returns>&lt;code&gt;false&lt;/code&gt; if this method could not delete all the files
		///         which should be deleted (e.g. because of of the files was
		///         locked). In this case <c>#getToBeDeleted()</c> lists the files
		///         which should be tried to be deleted outside of this method.
		///         Although &lt;code&gt;false&lt;/code&gt; is returned the checkout was
		///         successful and the working tree was updated for all other files.
		///         &lt;code&gt;true&lt;/code&gt; is returned when no such problem occurred</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='checkout' and count(parameter)=0]"
		[Register ("checkout", "()Z", "GetCheckoutHandler")]
		public virtual unsafe bool Checkout ()
		{
			const string __id = "checkout.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <param name="repository">repository</param>
		/// <param name="f">this parameter is ignored.</param>
		/// <param name="entry">the entry containing new mode and content</param>
		/// <summary>Updates the file in the working tree with content and mode from an entry
		/// in the index.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='checkoutEntry' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.io.File'] and parameter[3][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
		[Obsolete (@"deprecated")]
		[Register ("checkoutEntry", "(Lorg/eclipse/jgit/lib/Repository;Ljava/io/File;Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "")]
		public static unsafe void CheckoutEntry (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Java.IO.File f, global::Org.Eclipse.Jgit.Dircache.DirCacheEntry entry)
		{
			const string __id = "checkoutEntry.(Lorg/eclipse/jgit/lib/Repository;Ljava/io/File;Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [2] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (f);
				global::System.GC.KeepAlive (entry);
			}
		}

		/// <param name="repo">repo</param>
		/// <param name="f">this parameter is ignored.</param>
		/// <param name="entry">the entry containing new mode and content</param>
		/// <param name="or">object reader to use for checkout</param>
		/// <summary>Updates the file in the working tree with content and mode from an entry
		/// in the index.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='checkoutEntry' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.io.File'] and parameter[3][@type='org.eclipse.jgit.dircache.DirCacheEntry'] and parameter[4][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Obsolete (@"deprecated")]
		[Register ("checkoutEntry", "(Lorg/eclipse/jgit/lib/Repository;Ljava/io/File;Lorg/eclipse/jgit/dircache/DirCacheEntry;Lorg/eclipse/jgit/lib/ObjectReader;)V", "")]
		public static unsafe void CheckoutEntry (global::Org.Eclipse.Jgit.Lib.Repository repo, global::Java.IO.File f, global::Org.Eclipse.Jgit.Dircache.DirCacheEntry entry, global::Org.Eclipse.Jgit.Lib.ObjectReader or)
		{
			const string __id = "checkoutEntry.(Lorg/eclipse/jgit/lib/Repository;Ljava/io/File;Lorg/eclipse/jgit/dircache/DirCacheEntry;Lorg/eclipse/jgit/lib/ObjectReader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [2] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				__args [3] = new JniArgumentValue ((or == null) ? IntPtr.Zero : ((global::Java.Lang.Object) or).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
				global::System.GC.KeepAlive (f);
				global::System.GC.KeepAlive (entry);
				global::System.GC.KeepAlive (or);
			}
		}

		/// <param name="repo">repository managing the destination work tree.</param>
		/// <param name="entry">the entry containing new mode and content</param>
		/// <param name="or">object reader to use for checkout</param>
		/// <summary>Updates the file in the working tree with content and mode from an entry
		/// in the index.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='checkoutEntry' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.dircache.DirCacheEntry'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register ("checkoutEntry", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/dircache/DirCacheEntry;Lorg/eclipse/jgit/lib/ObjectReader;)V", "")]
		public static unsafe void CheckoutEntry (global::Org.Eclipse.Jgit.Lib.Repository repo, global::Org.Eclipse.Jgit.Dircache.DirCacheEntry entry, global::Org.Eclipse.Jgit.Lib.ObjectReader or)
		{
			const string __id = "checkoutEntry.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/dircache/DirCacheEntry;Lorg/eclipse/jgit/lib/ObjectReader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				__args [2] = new JniArgumentValue ((or == null) ? IntPtr.Zero : ((global::Java.Lang.Object) or).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
				global::System.GC.KeepAlive (entry);
				global::System.GC.KeepAlive (or);
			}
		}

		static Delegate cb_preScanTwoTrees;
#pragma warning disable 0169
		static Delegate GetPreScanTwoTreesHandler ()
		{
			if (cb_preScanTwoTrees == null)
				cb_preScanTwoTrees = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PreScanTwoTrees);
			return cb_preScanTwoTrees;
		}

		static void n_PreScanTwoTrees (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheCheckout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreScanTwoTrees ();
		}
#pragma warning restore 0169

		/// <summary>Scan head, index and merge tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='preScanTwoTrees' and count(parameter)=0]"
		[Register ("preScanTwoTrees", "()V", "GetPreScanTwoTreesHandler")]
		public virtual unsafe void PreScanTwoTrees ()
		{
			const string __id = "preScanTwoTrees.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_prescanOneTree;
#pragma warning disable 0169
		static Delegate GetPrescanOneTreeHandler ()
		{
			if (cb_prescanOneTree == null)
				cb_prescanOneTree = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PrescanOneTree);
			return cb_prescanOneTree;
		}

		static void n_PrescanOneTree (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheCheckout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrescanOneTree ();
		}
#pragma warning restore 0169

		/// <summary>Scan index and merge tree (no HEAD).</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='prescanOneTree' and count(parameter)=0]"
		[Register ("prescanOneTree", "()V", "GetPrescanOneTreeHandler")]
		public virtual unsafe void PrescanOneTree ()
		{
			const string __id = "prescanOneTree.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setFailOnConflict_Z;
#pragma warning disable 0169
		static Delegate GetSetFailOnConflict_ZHandler ()
		{
			if (cb_setFailOnConflict_Z == null)
				cb_setFailOnConflict_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFailOnConflict_Z);
			return cb_setFailOnConflict_Z;
		}

		static void n_SetFailOnConflict_Z (IntPtr jnienv, IntPtr native__this, bool failOnConflict)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheCheckout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFailOnConflict (failOnConflict);
		}
#pragma warning restore 0169

		/// <param name="failOnConflict">failOnConflict</param>
		/// <summary>If &lt;code&gt;true&lt;/code&gt;, will scan first to see if it's possible to check
		/// out, otherwise throw <c>CheckoutConflictException</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheCheckout']/method[@name='setFailOnConflict' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFailOnConflict", "(Z)V", "GetSetFailOnConflict_ZHandler")]
		public virtual unsafe void SetFailOnConflict (bool failOnConflict)
		{
			const string __id = "setFailOnConflict.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (failOnConflict);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
