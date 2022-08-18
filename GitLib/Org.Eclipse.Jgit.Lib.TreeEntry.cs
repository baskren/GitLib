using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>This class represents an entry in a tree, like a blob or another tree.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/TreeEntry", DoNotGenerateAcw=true)]
	public abstract partial class TreeEntry : global::Java.Lang.Object, global::Java.Lang.IComparable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/TreeEntry", typeof (TreeEntry));

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

		protected TreeEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="myParent">myParent</param>
		/// <param name="myId">myId</param>
		/// <param name="myNameUTF8">myNameUTF8</param>
		/// <summary>Construct a named tree entry.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/constructor[@name='TreeEntry' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Tree'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Tree;Lorg/eclipse/jgit/lib/ObjectId;[B)V", "")]
		protected unsafe TreeEntry (global::Org.Eclipse.Jgit.Lib.Tree myParent, global::Org.Eclipse.Jgit.Lib.ObjectId myId, byte[] myNameUTF8) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Tree;Lorg/eclipse/jgit/lib/ObjectId;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_myNameUTF8 = JNIEnv.NewArray (myNameUTF8);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((myParent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) myParent).Handle);
				__args [1] = new JniArgumentValue ((myId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) myId).Handle);
				__args [2] = new JniArgumentValue (native_myNameUTF8);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (myNameUTF8 != null) {
					JNIEnv.CopyArray (native_myNameUTF8, myNameUTF8);
					JNIEnv.DeleteLocalRef (native_myNameUTF8);
				}
				global::System.GC.KeepAlive (myParent);
				global::System.GC.KeepAlive (myId);
				global::System.GC.KeepAlive (myNameUTF8);
			}
		}

		static Delegate cb_getFullName;
#pragma warning disable 0169
		static Delegate GetGetFullNameHandler ()
		{
			if (cb_getFullName == null)
				cb_getFullName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFullName);
			return cb_getFullName;
		}

		static IntPtr n_GetFullName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FullName);
		}
#pragma warning restore 0169

		/// <returns>repository relative name of this entry</returns>
		public virtual unsafe string FullName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='getFullName' and count(parameter)=0]"
			[Register ("getFullName", "()Ljava/lang/String;", "GetGetFullNameHandler")]
			get {
				const string __id = "getFullName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetSetId_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_setId_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_setId_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetId_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_setId_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static void n_SetId_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_n, JniHandleOwnership.DoNotTransfer);
			__this.Id = n;
		}
#pragma warning restore 0169

		/// <returns>SHA-1 of this tree entry (null for new unhashed entries)</returns>
		/// <summary>Set (update) the SHA-1 of this entry.</summary>
		/// <param name="n">SHA-1 for this entry.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
			[Register ("setId", "(Lorg/eclipse/jgit/lib/ObjectId;)V", "GetSetId_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
			set {
				const string __id = "setId.(Lorg/eclipse/jgit/lib/ObjectId;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isModified;
#pragma warning disable 0169
		static Delegate GetIsModifiedHandler ()
		{
			if (cb_isModified == null)
				cb_isModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsModified);
			return cb_isModified;
		}

		static bool n_IsModified (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsModified;
		}
#pragma warning restore 0169

		/// <returns>true if this entry is new or modified since being loaded.</returns>
		public virtual unsafe bool IsModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='isModified' and count(parameter)=0]"
			[Register ("isModified", "()Z", "GetIsModifiedHandler")]
			get {
				const string __id = "isModified.()Z";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mode);
		}
#pragma warning restore 0169

		public abstract global::Org.Eclipse.Jgit.Lib.FileMode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetModeHandler")]
			get; 
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		/// <returns>the name of this entry.</returns>
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParent;
#pragma warning disable 0169
		static Delegate GetGetParentHandler ()
		{
			if (cb_getParent == null)
				cb_getParent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParent);
			return cb_getParent;
		}

		static IntPtr n_GetParent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parent);
		}
#pragma warning restore 0169

		/// <returns>parent of this tree.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Tree Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Lorg/eclipse/jgit/lib/Tree;", "GetGetParentHandler")]
			get {
				const string __id = "getParent.()Lorg/eclipse/jgit/lib/Tree;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Tree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		/// <returns>the repository owning this entry.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='getRepository' and count(parameter)=0]"
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

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public virtual unsafe int CompareTo (global::Java.Lang.Object o)
		{
			const string __id = "compareTo.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		/// <summary>Delete this entry.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_detachParent;
#pragma warning disable 0169
		static Delegate GetDetachParentHandler ()
		{
			if (cb_detachParent == null)
				cb_detachParent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DetachParent);
			return cb_detachParent;
		}

		static void n_DetachParent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DetachParent ();
		}
#pragma warning restore 0169

		/// <summary>Detach this entry from it's parent.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='detachParent' and count(parameter)=0]"
		[Register ("detachParent", "()V", "GetDetachParentHandler")]
		public virtual unsafe void DetachParent ()
		{
			const string __id = "detachParent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getFullNameUTF8;
#pragma warning disable 0169
		static Delegate GetGetFullNameUTF8Handler ()
		{
			if (cb_getFullNameUTF8 == null)
				cb_getFullNameUTF8 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFullNameUTF8);
			return cb_getFullNameUTF8;
		}

		static IntPtr n_GetFullNameUTF8 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFullNameUTF8 ());
		}
#pragma warning restore 0169

		/// <returns>repository relative name of the entry
		/// FIXME better encoding</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='getFullNameUTF8' and count(parameter)=0]"
		[Register ("getFullNameUTF8", "()[B", "GetGetFullNameUTF8Handler")]
		public virtual unsafe byte[] GetFullNameUTF8 ()
		{
			const string __id = "getFullNameUTF8.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getNameUTF8;
#pragma warning disable 0169
		static Delegate GetGetNameUTF8Handler ()
		{
			if (cb_getNameUTF8 == null)
				cb_getNameUTF8 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNameUTF8);
			return cb_getNameUTF8;
		}

		static IntPtr n_GetNameUTF8 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetNameUTF8 ());
		}
#pragma warning restore 0169

		/// <returns>the raw byte name of this entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='getNameUTF8' and count(parameter)=0]"
		[Register ("getNameUTF8", "()[B", "GetGetNameUTF8Handler")]
		public virtual unsafe byte[] GetNameUTF8 ()
		{
			const string __id = "getNameUTF8.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		/// <param name="treeEntry">treeEntry</param>
		/// <summary>Helper for accessing tree/blob methods.</summary>
		/// <returns>'/' for Tree entries and NUL for non-treeish objects.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='lastChar' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.TreeEntry']]"
		[Register ("lastChar", "(Lorg/eclipse/jgit/lib/TreeEntry;)I", "")]
		public static unsafe int LastChar (global::Org.Eclipse.Jgit.Lib.TreeEntry treeEntry)
		{
			const string __id = "lastChar.(Lorg/eclipse/jgit/lib/TreeEntry;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((treeEntry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) treeEntry).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (treeEntry);
			}
		}

		static Delegate cb_rename_arrayB;
#pragma warning disable 0169
		static Delegate GetRename_arrayBHandler ()
		{
			if (cb_rename_arrayB == null)
				cb_rename_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Rename_arrayB);
			return cb_rename_arrayB;
		}

		static void n_Rename_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = (byte[]) JNIEnv.GetArray (native_n, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Rename (n);
			if (n != null)
				JNIEnv.CopyArray (n, native_n);
		}
#pragma warning restore 0169

		/// <param name="n">The new name</param>
		/// <summary>Rename this entry.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='rename' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("rename", "([B)V", "GetRename_arrayBHandler")]
		public virtual unsafe void Rename (byte[] n)
		{
			const string __id = "rename.([B)V";
			IntPtr native_n = JNIEnv.NewArray (n);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_n);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (n != null) {
					JNIEnv.CopyArray (native_n, n);
					JNIEnv.DeleteLocalRef (native_n);
				}
				global::System.GC.KeepAlive (n);
			}
		}

		static Delegate cb_rename_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRename_Ljava_lang_String_Handler ()
		{
			if (cb_rename_Ljava_lang_String_ == null)
				cb_rename_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Rename_Ljava_lang_String_);
			return cb_rename_Ljava_lang_String_;
		}

		static void n_Rename_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = JNIEnv.GetString (native_n, JniHandleOwnership.DoNotTransfer);
			__this.Rename (n);
		}
#pragma warning restore 0169

		/// <param name="n">The new name</param>
		/// <summary>Rename this entry.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='rename' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rename", "(Ljava/lang/String;)V", "GetRename_Ljava_lang_String_Handler")]
		public virtual unsafe void Rename (string n)
		{
			const string __id = "rename.(Ljava/lang/String;)V";
			IntPtr native_n = JNIEnv.NewString ((string)n);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_n);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_n);
			}
		}

		static Delegate cb_setModified;
#pragma warning disable 0169
		static Delegate GetSetModifiedHandler ()
		{
			if (cb_setModified == null)
				cb_setModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetModified);
			return cb_setModified;
		}

		static void n_SetModified (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetModified ();
		}
#pragma warning restore 0169

		/// <summary>Mark this entry as modified.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='setModified' and count(parameter)=0]"
		[Register ("setModified", "()V", "GetSetModifiedHandler")]
		public virtual unsafe void SetModified ()
		{
			const string __id = "setModified.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/TreeEntry", DoNotGenerateAcw=true)]
	internal partial class TreeEntryInvoker : TreeEntry {
		public TreeEntryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/TreeEntry", typeof (TreeEntryInvoker));

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

		/// <returns>mode (type of object)</returns>
		public override unsafe global::Org.Eclipse.Jgit.Lib.FileMode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='TreeEntry']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetModeHandler")]
			get {
				const string __id = "getMode.()Lorg/eclipse/jgit/lib/FileMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
