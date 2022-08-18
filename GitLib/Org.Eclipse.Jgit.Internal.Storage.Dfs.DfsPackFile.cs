using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>A Git version 2 pack file representation.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackFile']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsPackFile", DoNotGenerateAcw=true)]
	public sealed partial class DfsPackFile : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsPackFile", typeof (DfsPackFile));

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

		internal DfsPackFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <returns>bytes cached in memory for this pack, excluding the index.</returns>
		public unsafe long CachedSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackFile']/method[@name='getCachedSize' and count(parameter)=0]"
			[Register ("getCachedSize", "()J", "")]
			get {
				const string __id = "getCachedSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>whether the pack index file is loaded and cached in memory.</returns>
		public unsafe bool IsIndexLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackFile']/method[@name='isIndexLoaded' and count(parameter)=0]"
			[Register ("isIndexLoaded", "()Z", "")]
			get {
				const string __id = "isIndexLoaded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>description that was originally used to configure this pack file.</returns>
		public unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription PackDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackFile']/method[@name='getPackDescription' and count(parameter)=0]"
			[Register ("getPackDescription", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "")]
			get {
				const string __id = "getPackDescription.()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Release all memory used by this DfsPackFile instance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackFile']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <param name="ctx">reader context to support reading from the backing store if
		///            the index is not already loaded in memory.</param>
		/// <param name="id">object to be located.</param>
		/// <summary>Check if an object is stored within this pack.</summary>
		/// <returns>true if the object exists in this pack; false if it does not.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackFile']/method[@name='hasObject' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsReader'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("hasObject", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsReader;Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "")]
		public unsafe bool HasObject (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsReader ctx, global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "hasObject.(Lorg/eclipse/jgit/internal/storage/dfs/DfsReader;Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ctx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ctx).Handle);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (ctx);
				global::System.GC.KeepAlive (id);
			}
		}

	}
}
