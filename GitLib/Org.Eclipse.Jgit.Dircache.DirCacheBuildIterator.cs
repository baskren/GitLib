using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Dircache {

	/// <summary>Iterate and update a <c>DirCache</c> as part of a &lt;code&gt;TreeWalk&lt;/code&gt;.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuildIterator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheBuildIterator", DoNotGenerateAcw=true)]
	public partial class DirCacheBuildIterator : global::Org.Eclipse.Jgit.Dircache.DirCacheIterator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheBuildIterator", typeof (DirCacheBuildIterator));

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

		protected DirCacheBuildIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="dcb">the cache builder for the cache to walk. The cache must be
		///            already loaded into memory.</param>
		/// <summary>Create a new iterator for an already loaded DirCache instance.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheBuildIterator']/constructor[@name='DirCacheBuildIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheBuilder']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/dircache/DirCacheBuilder;)V", "")]
		public unsafe DirCacheBuildIterator (global::Org.Eclipse.Jgit.Dircache.DirCacheBuilder dcb) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/dircache/DirCacheBuilder;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dcb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dcb).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dcb);
			}
		}

	}
}
