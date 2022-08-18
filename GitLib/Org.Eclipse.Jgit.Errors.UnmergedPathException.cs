using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>Indicates one or more paths in a DirCache have non-zero stages present.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='UnmergedPathException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/UnmergedPathException", DoNotGenerateAcw=true)]
	public partial class UnmergedPathException : global::Java.IO.IOException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/UnmergedPathException", typeof (UnmergedPathException));

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

		protected UnmergedPathException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="dce">the first non-zero stage of the unmerged path.</param>
		/// <summary>Create a new unmerged path exception.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='UnmergedPathException']/constructor[@name='UnmergedPathException' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "")]
		public unsafe UnmergedPathException (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry dce) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dce == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dce).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dce);
			}
		}

		static Delegate cb_getDirCacheEntry;
#pragma warning disable 0169
		static Delegate GetGetDirCacheEntryHandler ()
		{
			if (cb_getDirCacheEntry == null)
				cb_getDirCacheEntry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDirCacheEntry);
			return cb_getDirCacheEntry;
		}

		static IntPtr n_GetDirCacheEntry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.UnmergedPathException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DirCacheEntry);
		}
#pragma warning restore 0169

		/// <returns>the first non-zero stage of the unmerged path</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCacheEntry DirCacheEntry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='UnmergedPathException']/method[@name='getDirCacheEntry' and count(parameter)=0]"
			[Register ("getDirCacheEntry", "()Lorg/eclipse/jgit/dircache/DirCacheEntry;", "GetGetDirCacheEntryHandler")]
			get {
				const string __id = "getDirCacheEntry.()Lorg/eclipse/jgit/dircache/DirCacheEntry;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
