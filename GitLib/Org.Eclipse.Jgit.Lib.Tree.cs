using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A representation of a Git tree entry.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/Tree", DoNotGenerateAcw=true)]
	public partial class Tree : global::Org.Eclipse.Jgit.Lib.TreeEntry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/Tree", typeof (Tree));

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

		protected Tree (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">The repository that owns the Tree.</param>
		/// <summary>Constructor for a new Tree</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/constructor[@name='Tree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe Tree (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		/// <param name="repo">repo</param>
		/// <param name="myId">myId</param>
		/// <param name="raw">raw</param>
		/// <summary>Construct a Tree object with known content and hash value</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/constructor[@name='Tree' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectId;[B)V", "")]
		public unsafe Tree (global::Org.Eclipse.Jgit.Lib.Repository repo, global::Org.Eclipse.Jgit.Lib.ObjectId myId, byte[] raw) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectId;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue ((myId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) myId).Handle);
				__args [2] = new JniArgumentValue (native_raw);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (repo);
				global::System.GC.KeepAlive (myId);
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="parent">parent</param>
		/// <param name="nameUTF8">nameUTF8</param>
		/// <summary>Construct a new Tree under another Tree</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/constructor[@name='Tree' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Tree'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Tree;[B)V", "")]
		public unsafe Tree (global::Org.Eclipse.Jgit.Lib.Tree parent, byte[] nameUTF8) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Tree;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_nameUTF8 = JNIEnv.NewArray (nameUTF8);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_nameUTF8);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (nameUTF8 != null) {
					JNIEnv.CopyArray (native_nameUTF8, nameUTF8);
					JNIEnv.DeleteLocalRef (native_nameUTF8);
				}
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (nameUTF8);
			}
		}

		/// <param name="parent">parent</param>
		/// <param name="id">id</param>
		/// <param name="nameUTF8">nameUTF8</param>
		/// <summary>Construct a Tree with a known SHA-1 under another tree.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/constructor[@name='Tree' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Tree'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Tree;Lorg/eclipse/jgit/lib/ObjectId;[B)V", "")]
		public unsafe Tree (global::Org.Eclipse.Jgit.Lib.Tree parent, global::Org.Eclipse.Jgit.Lib.ObjectId id, byte[] nameUTF8) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isLoaded;
#pragma warning disable 0169
		static Delegate GetIsLoadedHandler ()
		{
			if (cb_isLoaded == null)
				cb_isLoaded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLoaded);
			return cb_isLoaded;
		}

		static bool n_IsLoaded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoaded;
		}
#pragma warning restore 0169

		/// <returns>true of the data of this Tree is loaded</returns>
		public virtual unsafe bool IsLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='isLoaded' and count(parameter)=0]"
			[Register ("isLoaded", "()Z", "GetIsLoadedHandler")]
			get {
				const string __id = "isLoaded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRoot;
#pragma warning disable 0169
		static Delegate GetIsRootHandler ()
		{
			if (cb_isRoot == null)
				cb_isRoot = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRoot);
			return cb_isRoot;
		}

		static bool n_IsRoot (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRoot;
		}
#pragma warning restore 0169

		/// <returns>true if this Tree is the top level Tree.</returns>
		public virtual unsafe bool IsRoot {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='isRoot' and count(parameter)=0]"
			[Register ("isRoot", "()Z", "GetIsRootHandler")]
			get {
				const string __id = "isRoot.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mode);
		}
#pragma warning restore 0169

		public override unsafe global::Org.Eclipse.Jgit.Lib.FileMode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='getMode' and count(parameter)=0]"
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

		static Delegate cb_addEntry_Lorg_eclipse_jgit_lib_TreeEntry_;
#pragma warning disable 0169
		static Delegate GetAddEntry_Lorg_eclipse_jgit_lib_TreeEntry_Handler ()
		{
			if (cb_addEntry_Lorg_eclipse_jgit_lib_TreeEntry_ == null)
				cb_addEntry_Lorg_eclipse_jgit_lib_TreeEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddEntry_Lorg_eclipse_jgit_lib_TreeEntry_);
			return cb_addEntry_Lorg_eclipse_jgit_lib_TreeEntry_;
		}

		static void n_AddEntry_Lorg_eclipse_jgit_lib_TreeEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddEntry (e);
		}
#pragma warning restore 0169

		/// <param name="e">e</param>
		/// <summary>Add the specified tree entry to this tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='addEntry' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.TreeEntry']]"
		[Register ("addEntry", "(Lorg/eclipse/jgit/lib/TreeEntry;)V", "GetAddEntry_Lorg_eclipse_jgit_lib_TreeEntry_Handler")]
		public virtual unsafe void AddEntry (global::Org.Eclipse.Jgit.Lib.TreeEntry e)
		{
			const string __id = "addEntry.(Lorg/eclipse/jgit/lib/TreeEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_addFile_arrayBI;
#pragma warning disable 0169
		static Delegate GetAddFile_arrayBIHandler ()
		{
			if (cb_addFile_arrayBI == null)
				cb_addFile_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AddFile_arrayBI);
			return cb_addFile_arrayBI;
		}

		static IntPtr n_AddFile_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_s, int offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = (byte[]) JNIEnv.GetArray (native_s, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddFile (s, offset));
			if (s != null)
				JNIEnv.CopyArray (s, native_s);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="s">an array containing the name</param>
		/// <param name="offset">when the name starts in the tree.</param>
		/// <summary>Adds a new or existing file with the specified name to this tree.</summary>
		/// <returns>a <c>FileTreeEntry</c> for the added file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='addFile' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("addFile", "([BI)Lorg/eclipse/jgit/lib/FileTreeEntry;", "GetAddFile_arrayBIHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileTreeEntry AddFile (byte[] s, int offset)
		{
			const string __id = "addFile.([BI)Lorg/eclipse/jgit/lib/FileTreeEntry;";
			IntPtr native_s = JNIEnv.NewArray (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileTreeEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (s != null) {
					JNIEnv.CopyArray (native_s, s);
					JNIEnv.DeleteLocalRef (native_s);
				}
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_addFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddFile_Ljava_lang_String_Handler ()
		{
			if (cb_addFile_Ljava_lang_String_ == null)
				cb_addFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddFile_Ljava_lang_String_);
			return cb_addFile_Ljava_lang_String_;
		}

		static IntPtr n_AddFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddFile (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">Name</param>
		/// <summary>Adds a new or existing file with the specified name to this tree.</summary>
		/// <returns>a <c>FileTreeEntry</c> for the added file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='addFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addFile", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/FileTreeEntry;", "GetAddFile_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileTreeEntry AddFile (string name)
		{
			const string __id = "addFile.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/FileTreeEntry;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileTreeEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_addTree_arrayBI;
#pragma warning disable 0169
		static Delegate GetAddTree_arrayBIHandler ()
		{
			if (cb_addTree_arrayBI == null)
				cb_addTree_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AddTree_arrayBI);
			return cb_addTree_arrayBI;
		}

		static IntPtr n_AddTree_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_s, int offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = (byte[]) JNIEnv.GetArray (native_s, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTree (s, offset));
			if (s != null)
				JNIEnv.CopyArray (s, native_s);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="s">an array containing the name</param>
		/// <param name="offset">when the name starts in the tree.</param>
		/// <summary>Adds a new or existing Tree with the specified name to this tree.</summary>
		/// <returns>a <c>FileTreeEntry</c> for the added tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='addTree' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("addTree", "([BI)Lorg/eclipse/jgit/lib/Tree;", "GetAddTree_arrayBIHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Tree AddTree (byte[] s, int offset)
		{
			const string __id = "addTree.([BI)Lorg/eclipse/jgit/lib/Tree;";
			IntPtr native_s = JNIEnv.NewArray (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (s != null) {
					JNIEnv.CopyArray (native_s, s);
					JNIEnv.DeleteLocalRef (native_s);
				}
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_addTree_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddTree_Ljava_lang_String_Handler ()
		{
			if (cb_addTree_Ljava_lang_String_ == null)
				cb_addTree_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddTree_Ljava_lang_String_);
			return cb_addTree_Ljava_lang_String_;
		}

		static IntPtr n_AddTree_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTree (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">Name</param>
		/// <summary>Adds a new or existing Tree with the specified name to this tree.</summary>
		/// <returns>a <c>FileTreeEntry</c> for the added tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='addTree' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addTree", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Tree;", "GetAddTree_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Tree AddTree (string name)
		{
			const string __id = "addTree.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Tree;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		/// <param name="a">name</param>
		/// <param name="b">name</param>
		/// <param name="lasta">'/' if a is a tree, else NUL</param>
		/// <param name="lastb">'/' if b is a tree, else NUL</param>
		/// <summary>Compare two names represented as bytes.</summary>
		/// <returns>&amp;lt; 0 if a is sorted before b, 0 if they are the same, else b</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='compareNames' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("compareNames", "([B[BII)I", "")]
		public static unsafe int CompareNames (byte[] a, byte[] b, int lasta, int lastb)
		{
			const string __id = "compareNames.([B[BII)I";
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_a);
				__args [1] = new JniArgumentValue (native_b);
				__args [2] = new JniArgumentValue (lasta);
				__args [3] = new JniArgumentValue (lastb);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		static Delegate cb_existsBlob_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExistsBlob_Ljava_lang_String_Handler ()
		{
			if (cb_existsBlob_Ljava_lang_String_ == null)
				cb_existsBlob_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ExistsBlob_Ljava_lang_String_);
			return cb_existsBlob_Ljava_lang_String_;
		}

		static bool n_ExistsBlob_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ExistsBlob (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">of the non-tree entry.</param>
		/// <returns>true if a blob, symlink, or gitlink with the specified name
		///         can be found under this tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='existsBlob' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("existsBlob", "(Ljava/lang/String;)Z", "GetExistsBlob_Ljava_lang_String_Handler")]
		public virtual unsafe bool ExistsBlob (string path)
		{
			const string __id = "existsBlob.(Ljava/lang/String;)Z";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_existsTree_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExistsTree_Ljava_lang_String_Handler ()
		{
			if (cb_existsTree_Ljava_lang_String_ == null)
				cb_existsTree_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ExistsTree_Ljava_lang_String_);
			return cb_existsTree_Ljava_lang_String_;
		}

		static bool n_ExistsTree_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ExistsTree (path);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">to the tree.</param>
		/// <returns>true if a tree with the specified path can be found under this
		///         tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='existsTree' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("existsTree", "(Ljava/lang/String;)Z", "GetExistsTree_Ljava_lang_String_Handler")]
		public virtual unsafe bool ExistsTree (string path)
		{
			const string __id = "existsTree.(Ljava/lang/String;)Z";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_findBlobMember_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindBlobMember_Ljava_lang_String_Handler ()
		{
			if (cb_findBlobMember_Ljava_lang_String_ == null)
				cb_findBlobMember_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FindBlobMember_Ljava_lang_String_);
			return cb_findBlobMember_Ljava_lang_String_;
		}

		static IntPtr n_FindBlobMember_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindBlobMember (s));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="s">blob name</param>
		/// <returns>a <c>TreeEntry</c> representing an object with the specified
		///         relative path.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='findBlobMember' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findBlobMember", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/TreeEntry;", "GetFindBlobMember_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.TreeEntry FindBlobMember (string s)
		{
			const string __id = "findBlobMember.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/TreeEntry;";
			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_findTreeMember_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindTreeMember_Ljava_lang_String_Handler ()
		{
			if (cb_findTreeMember_Ljava_lang_String_ == null)
				cb_findTreeMember_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FindTreeMember_Ljava_lang_String_);
			return cb_findTreeMember_Ljava_lang_String_;
		}

		static IntPtr n_FindTreeMember_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindTreeMember (s));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="s">Tree Name</param>
		/// <returns>a Tree with the name s or null</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='findTreeMember' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findTreeMember", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/TreeEntry;", "GetFindTreeMember_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.TreeEntry FindTreeMember (string s)
		{
			const string __id = "findTreeMember.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/TreeEntry;";
			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_format;
#pragma warning disable 0169
		static Delegate GetFormatHandler ()
		{
			if (cb_format == null)
				cb_format = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Format);
			return cb_format;
		}

		static IntPtr n_Format (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Format ());
		}
#pragma warning restore 0169

		/// <summary>Format this Tree in canonical format.</summary>
		/// <returns>canonical encoding of the tree object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='format' and count(parameter)=0]"
		[Register ("format", "()[B", "GetFormatHandler")]
		public virtual unsafe byte[] Format ()
		{
			const string __id = "format.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_memberCount;
#pragma warning disable 0169
		static Delegate GetMemberCountHandler ()
		{
			if (cb_memberCount == null)
				cb_memberCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_MemberCount);
			return cb_memberCount;
		}

		static int n_MemberCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MemberCount ();
		}
#pragma warning restore 0169

		/// <returns>number of members in this tree</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='memberCount' and count(parameter)=0]"
		[Register ("memberCount", "()I", "GetMemberCountHandler")]
		public virtual unsafe int MemberCount ()
		{
			const string __id = "memberCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_members;
#pragma warning disable 0169
		static Delegate GetMembersHandler ()
		{
			if (cb_members == null)
				cb_members = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Members);
			return cb_members;
		}

		static IntPtr n_Members (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Members ());
		}
#pragma warning restore 0169

		/// <summary>Return all members of the tree sorted in Git order.</summary>
		/// <returns>all entries in this Tree, sorted.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='members' and count(parameter)=0]"
		[Register ("members", "()[Lorg/eclipse/jgit/lib/TreeEntry;", "GetMembersHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.TreeEntry[] Members ()
		{
			const string __id = "members.()[Lorg/eclipse/jgit/lib/TreeEntry;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Jgit.Lib.TreeEntry[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.TreeEntry));
			} finally {
			}
		}

		static Delegate cb_unload;
#pragma warning disable 0169
		static Delegate GetUnloadHandler ()
		{
			if (cb_unload == null)
				cb_unload = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unload);
			return cb_unload;
		}

		static void n_Unload (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unload ();
		}
#pragma warning restore 0169

		/// <summary>Forget the in-memory data for this tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Tree']/method[@name='unload' and count(parameter)=0]"
		[Register ("unload", "()V", "GetUnloadHandler")]
		public virtual unsafe void Unload ()
		{
			const string __id = "unload.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
