using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A representation of a file (blob) object in a <c>Tree</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileTreeEntry']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/FileTreeEntry", DoNotGenerateAcw=true)]
	public partial class FileTreeEntry : global::Org.Eclipse.Jgit.Lib.TreeEntry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/FileTreeEntry", typeof (FileTreeEntry));

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

		protected FileTreeEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="parent">The <c>Tree</c> holding this object (or null)</param>
		/// <param name="id">the SHA-1 of the blob (or null for a yet unhashed file)</param>
		/// <param name="nameUTF8">raw object name in the parent tree</param>
		/// <param name="execute">true if the executable flag is set</param>
		/// <summary>Constructor for a File (blob) object.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileTreeEntry']/constructor[@name='FileTreeEntry' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.Tree'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Tree;Lorg/eclipse/jgit/lib/ObjectId;[BZ)V", "")]
		public unsafe FileTreeEntry (global::Org.Eclipse.Jgit.Lib.Tree parent, global::Org.Eclipse.Jgit.Lib.ObjectId id, byte[] nameUTF8, bool execute) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Tree;Lorg/eclipse/jgit/lib/ObjectId;[BZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_nameUTF8 = JNIEnv.NewArray (nameUTF8);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [2] = new JniArgumentValue (native_nameUTF8);
				__args [3] = new JniArgumentValue (execute);
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

		static Delegate cb_isExecutable;
#pragma warning disable 0169
		static Delegate GetIsExecutableHandler ()
		{
			if (cb_isExecutable == null)
				cb_isExecutable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExecutable);
			return cb_isExecutable;
		}

		static bool n_IsExecutable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileTreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Executable;
		}
#pragma warning restore 0169

		static Delegate cb_setExecutable_Z;
#pragma warning disable 0169
		static Delegate GetSetExecutable_ZHandler ()
		{
			if (cb_setExecutable_Z == null)
				cb_setExecutable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetExecutable_Z);
			return cb_setExecutable_Z;
		}

		static void n_SetExecutable_Z (IntPtr jnienv, IntPtr native__this, bool execute)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileTreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Executable = execute;
		}
#pragma warning restore 0169

		/// <returns>true if this file is executable</returns>
		/// <param name="execute">set/reset the executable flag</param>
		public virtual unsafe bool Executable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileTreeEntry']/method[@name='isExecutable' and count(parameter)=0]"
			[Register ("isExecutable", "()Z", "GetIsExecutableHandler")]
			get {
				const string __id = "isExecutable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileTreeEntry']/method[@name='setExecutable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExecutable", "(Z)V", "GetSetExecutable_ZHandler")]
			set {
				const string __id = "setExecutable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileTreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mode);
		}
#pragma warning restore 0169

		public override unsafe global::Org.Eclipse.Jgit.Lib.FileMode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileTreeEntry']/method[@name='getMode' and count(parameter)=0]"
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

		static Delegate cb_openReader;
#pragma warning disable 0169
		static Delegate GetOpenReaderHandler ()
		{
			if (cb_openReader == null)
				cb_openReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenReader);
			return cb_openReader;
		}

		static IntPtr n_OpenReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileTreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenReader ());
		}
#pragma warning restore 0169

		/// <returns>an <c>ObjectLoader</c> that will return the data</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='FileTreeEntry']/method[@name='openReader' and count(parameter)=0]"
		[Register ("openReader", "()Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpenReaderHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader OpenReader ()
		{
			const string __id = "openReader.()Lorg/eclipse/jgit/lib/ObjectLoader;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
