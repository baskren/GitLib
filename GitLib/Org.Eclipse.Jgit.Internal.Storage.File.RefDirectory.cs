using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Traditional file system based <c>RefDatabase</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/RefDirectory", DoNotGenerateAcw=true)]
	public partial class RefDirectory : global::Org.Eclipse.Jgit.Lib.RefDatabase {
		/// <summary>Magic string denoting the header of a packed-refs file.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/field[@name='PACKED_REFS_HEADER']"
		[Register ("PACKED_REFS_HEADER")]
		public const string PackedRefsHeader = (string) "# pack-refs with:";

		/// <summary>If in the header, denotes the file has peeled data.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/field[@name='PACKED_REFS_PEELED']"
		[Register ("PACKED_REFS_PEELED")]
		public const string PackedRefsPeeled = (string) " peeled";

		/// <summary>Magic string denoting the start of a symbolic reference file.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/field[@name='SYMREF']"
		[Register ("SYMREF")]
		public const string Symref = (string) "ref: ";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/RefDirectory", typeof (RefDirectory));

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

		protected RefDirectory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAdditionalRefs;
#pragma warning disable 0169
		static Delegate GetGetAdditionalRefsHandler ()
		{
			if (cb_getAdditionalRefs == null)
				cb_getAdditionalRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdditionalRefs);
			return cb_getAdditionalRefs;
		}

		static IntPtr n_GetAdditionalRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.AdditionalRefs);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> AdditionalRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='getAdditionalRefs' and count(parameter)=0]"
			[Register ("getAdditionalRefs", "()Ljava/util/List;", "GetGetAdditionalRefsHandler")]
			get {
				const string __id = "getAdditionalRefs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Create);
			return cb_create;
		}

		static void n_Create (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "GetCreateHandler")]
		public override unsafe void Create ()
		{
			const string __id = "create.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRef_Ljava_lang_String_Handler ()
		{
			if (cb_getRef_Ljava_lang_String_ == null)
				cb_getRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRef_Ljava_lang_String_);
			return cb_getRef_Ljava_lang_String_;
		}

		static IntPtr n_GetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_needle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var needle = JNIEnv.GetString (native_needle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRef (needle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='getRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "GetGetRef_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IRef GetRef (string needle)
		{
			const string __id = "getRef.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;";
			IntPtr native_needle = JNIEnv.NewString ((string)needle);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_needle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_needle);
			}
		}

		static Delegate cb_getRefs_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRefs_Ljava_lang_String_Handler ()
		{
			if (cb_getRefs_Ljava_lang_String_ == null)
				cb_getRefs_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRefs_Ljava_lang_String_);
			return cb_getRefs_Ljava_lang_String_;
		}

		static IntPtr n_GetRefs_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.GetRefs (prefix));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='getRefs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRefs", "(Ljava/lang/String;)Ljava/util/Map;", "GetGetRefs_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> GetRefs (string prefix)
		{
			const string __id = "getRefs.(Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		static Delegate cb_isNameConflicting_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsNameConflicting_Ljava_lang_String_Handler ()
		{
			if (cb_isNameConflicting_Ljava_lang_String_ == null)
				cb_isNameConflicting_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsNameConflicting_Ljava_lang_String_);
			return cb_isNameConflicting_Ljava_lang_String_;
		}

		static bool n_IsNameConflicting_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsNameConflicting (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='isNameConflicting' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNameConflicting", "(Ljava/lang/String;)Z", "GetIsNameConflicting_Ljava_lang_String_Handler")]
		public override unsafe bool IsNameConflicting (string name)
		{
			const string __id = "isNameConflicting.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_newRename_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewRename_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_newRename_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_newRename_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_NewRename_Ljava_lang_String_Ljava_lang_String_);
			return cb_newRename_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_NewRename_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fromName, IntPtr native_toName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fromName = JNIEnv.GetString (native_fromName, JniHandleOwnership.DoNotTransfer);
			var toName = JNIEnv.GetString (native_toName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewRename (fromName, toName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='newRename' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("newRename", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefRename;", "GetNewRename_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.RefRename NewRename (string fromName, string toName)
		{
			const string __id = "newRename.(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefRename;";
			IntPtr native_fromName = JNIEnv.NewString ((string)fromName);
			IntPtr native_toName = JNIEnv.NewString ((string)toName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fromName);
				__args [1] = new JniArgumentValue (native_toName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fromName);
				JNIEnv.DeleteLocalRef (native_toName);
			}
		}

		static Delegate cb_newUpdate_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetNewUpdate_Ljava_lang_String_ZHandler ()
		{
			if (cb_newUpdate_Ljava_lang_String_Z == null)
				cb_newUpdate_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_NewUpdate_Ljava_lang_String_Z);
			return cb_newUpdate_Ljava_lang_String_Z;
		}

		static IntPtr n_NewUpdate_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_name, bool detach)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewUpdate (name, detach));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='newUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("newUpdate", "(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/RefUpdate;", "GetNewUpdate_Ljava_lang_String_ZHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate NewUpdate (string name, bool detach)
		{
			const string __id = "newUpdate.(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/RefUpdate;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (detach);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_pack_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetPack_Ljava_util_List_Handler ()
		{
			if (cb_pack_Ljava_util_List_ == null)
				cb_pack_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Pack_Ljava_util_List_);
			return cb_pack_Ljava_util_List_;
		}

		static void n_Pack_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refs = global::Android.Runtime.JavaList<string>.FromJniHandle (native_refs, JniHandleOwnership.DoNotTransfer);
			__this.Pack (refs);
		}
#pragma warning restore 0169

		/// <param name="refs">the refs to be added. Must be fully qualified.</param>
		/// <summary>Adds a set of refs to the set of packed-refs.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='pack' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("pack", "(Ljava/util/List;)V", "GetPack_Ljava_util_List_Handler")]
		public virtual unsafe void Pack (global::System.Collections.Generic.IList<string> refs)
		{
			const string __id = "pack.(Ljava/util/List;)V";
			IntPtr native_refs = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (refs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refs);
				global::System.GC.KeepAlive (refs);
			}
		}

		static Delegate cb_peel_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetPeel_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_peel_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_peel_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Peel_Lorg_eclipse_jgit_lib_Ref_);
			return cb_peel_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_Peel_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.RefDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Peel (@ref));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='RefDirectory']/method[@name='peel' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("peel", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;", "GetPeel_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IRef Peel (global::Org.Eclipse.Jgit.Lib.IRef @ref)
		{
			const string __id = "peel.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@ref);
			}
		}

	}
}
