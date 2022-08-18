using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A tree entry representing a gitlink entry used for submodules.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='GitlinkTreeEntry']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/GitlinkTreeEntry", DoNotGenerateAcw=true)]
	public partial class GitlinkTreeEntry : global::Org.Eclipse.Jgit.Lib.TreeEntry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/GitlinkTreeEntry", typeof (GitlinkTreeEntry));

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

		protected GitlinkTreeEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="parent">parent</param>
		/// <param name="id">id</param>
		/// <param name="nameUTF8">nameUTF8</param>
		/// <summary>Construct a <c>GitlinkTreeEntry</c> with the specified name and SHA-1 in
		/// the specified parent</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='GitlinkTreeEntry']/constructor[@name='GitlinkTreeEntry' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Tree'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Tree;Lorg/eclipse/jgit/lib/ObjectId;[B)V", "")]
		public unsafe GitlinkTreeEntry (global::Org.Eclipse.Jgit.Lib.Tree parent, global::Org.Eclipse.Jgit.Lib.ObjectId id, byte[] nameUTF8) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Tree;Lorg/eclipse/jgit/lib/ObjectId;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_nameUTF8 = JNIEnv.NewArray (nameUTF8);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [2] = new JniArgumentValue (native_nameUTF8);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (nameUTF8 != null) {
					JNIEnv.CopyArray (native_nameUTF8, nameUTF8);
					JNIEnv.DeleteLocalRef (native_nameUTF8);
				}
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (nameUTF8);
			}
		}

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMode);
			return cb_getMode;
		}

		static IntPtr n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.GitlinkTreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mode);
		}
#pragma warning restore 0169

		public override unsafe global::Org.Eclipse.Jgit.Lib.FileMode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='GitlinkTreeEntry']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetModeHandler")]
			get {
				const string __id = "getMode.()Lorg/eclipse/jgit/lib/FileMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
