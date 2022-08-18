using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Configuration file based on the blobs stored in the repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BlobBasedConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/BlobBasedConfig", DoNotGenerateAcw=true)]
	public partial class BlobBasedConfig : global::Org.Eclipse.Jgit.Lib.Config {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/BlobBasedConfig", typeof (BlobBasedConfig));

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

		protected BlobBasedConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="base">the base configuration file</param>
		/// <param name="blob">the byte array, should be UTF-8 encoded text.</param>
		/// <summary>Parse a configuration from a byte array.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BlobBasedConfig']/constructor[@name='BlobBasedConfig' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Config;[B)V", "")]
		public unsafe BlobBasedConfig (global::Org.Eclipse.Jgit.Lib.Config @base, byte[] blob) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Config;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_blob = JNIEnv.NewArray (blob);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue (native_blob);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (blob != null) {
					JNIEnv.CopyArray (native_blob, blob);
					JNIEnv.DeleteLocalRef (native_blob);
				}
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (blob);
			}
		}

		/// <param name="base">the base configuration file</param>
		/// <param name="db">the repository</param>
		/// <param name="objectId">the object identifier</param>
		/// <summary>Load a configuration file from a blob.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BlobBasedConfig']/constructor[@name='BlobBasedConfig' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='org.eclipse.jgit.lib.Repository'] and parameter[3][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
		public unsafe BlobBasedConfig (global::Org.Eclipse.Jgit.Lib.Config @base, global::Org.Eclipse.Jgit.Lib.Repository db, global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/AnyObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [2] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (db);
				global::System.GC.KeepAlive (objectId);
			}
		}

		/// <param name="base">the base configuration file</param>
		/// <param name="db">the repository containing the objects.</param>
		/// <param name="treeish">the tree (or commit) that contains the object</param>
		/// <param name="path">the path within the tree</param>
		/// <summary>Load a configuration file from a blob stored in a specific commit.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='BlobBasedConfig']/constructor[@name='BlobBasedConfig' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='org.eclipse.jgit.lib.Repository'] and parameter[3][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/lang/String;)V", "")]
		public unsafe BlobBasedConfig (global::Org.Eclipse.Jgit.Lib.Config @base, global::Org.Eclipse.Jgit.Lib.Repository db, global::Org.Eclipse.Jgit.Lib.AnyObjectId treeish, string path) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [2] = new JniArgumentValue ((treeish == null) ? IntPtr.Zero : ((global::Java.Lang.Object) treeish).Handle);
				__args [3] = new JniArgumentValue (native_path);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (db);
				global::System.GC.KeepAlive (treeish);
			}
		}

	}
}
