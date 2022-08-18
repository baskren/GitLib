using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Caches slices of a <c>PackFile</c> in memory for faster read access.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='WindowCache']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/WindowCache", DoNotGenerateAcw=true)]
	public partial class WindowCache : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/WindowCache", typeof (WindowCache));

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

		protected WindowCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="cfg">the new window cache configuration.</param>
		/// <summary>Modify the configuration of the window cache.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='WindowCache']/method[@name='reconfigure' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.storage.file.WindowCacheConfig']]"
		[Obsolete (@"deprecated")]
		[Register ("reconfigure", "(Lorg/eclipse/jgit/storage/file/WindowCacheConfig;)V", "")]
		public static unsafe void Reconfigure (global::Org.Eclipse.Jgit.Storage.File.WindowCacheConfig cfg)
		{
			const string __id = "reconfigure.(Lorg/eclipse/jgit/storage/file/WindowCacheConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (cfg);
			}
		}

	}
}
