using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>A Git version 2 pack file representation.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackFile", DoNotGenerateAcw=true)]
	public partial class PackFile : global::Java.Lang.Object, global::Java.Lang.IIterable {

		/// <summary>Sorts PackFiles to be most recently created to least recently created.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']/field[@name='SORT']"
		[Register ("SORT")]
		public static global::Java.Util.IComparator Sort {
			get {
				const string __id = "SORT.Ljava/util/Comparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackFile", typeof (PackFile));

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

		protected PackFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="packFile">path of the &lt;code&gt;.pack&lt;/code&gt; file holding the data.</param>
		/// <param name="extensions">additional pack file extensions with the same base as the pack</param>
		/// <summary>Construct a reader for an existing, pre-indexed packfile.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']/constructor[@name='PackFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/File;I)V", "")]
		public unsafe PackFile (global::Java.IO.File packFile, int extensions) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((packFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packFile).Handle);
				__args [1] = new JniArgumentValue (extensions);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (packFile);
			}
		}

		static Delegate cb_getIndex;
#pragma warning disable 0169
		static Delegate GetGetIndexHandler ()
		{
			if (cb_getIndex == null)
				cb_getIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIndex);
			return cb_getIndex;
		}

		static IntPtr n_GetIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Index);
		}
#pragma warning restore 0169

		/// <returns>the index for this pack file.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex Index {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']/method[@name='getIndex' and count(parameter)=0]"
			[Register ("getIndex", "()Lorg/eclipse/jgit/internal/storage/file/PackIndex;", "GetGetIndexHandler")]
			get {
				const string __id = "getIndex.()Lorg/eclipse/jgit/internal/storage/file/PackIndex;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackName;
#pragma warning disable 0169
		static Delegate GetGetPackNameHandler ()
		{
			if (cb_getPackName == null)
				cb_getPackName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackName);
			return cb_getPackName;
		}

		static IntPtr n_GetPackName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackName);
		}
#pragma warning restore 0169

		/// <returns>name extracted from <c>pack-*.pack</c> pattern.</returns>
		public virtual unsafe string PackName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']/method[@name='getPackName' and count(parameter)=0]"
			[Register ("getPackName", "()Ljava/lang/String;", "GetGetPackNameHandler")]
			get {
				const string __id = "getPackName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		/// <summary>Close the resources utilized by this repository</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getPackFile;
#pragma warning disable 0169
		static Delegate GetGetPackFileHandler ()
		{
			if (cb_getPackFile == null)
				cb_getPackFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackFile);
			return cb_getPackFile;
		}

		static IntPtr n_GetPackFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPackFile ());
		}
#pragma warning restore 0169

		/// <returns>the File object which locates this pack on disk.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']/method[@name='getPackFile' and count(parameter)=0]"
		[Register ("getPackFile", "()Ljava/io/File;", "GetGetPackFileHandler")]
		public virtual unsafe global::Java.IO.File GetPackFile ()
		{
			const string __id = "getPackFile.()Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetHasObject_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasObject_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_HasObject_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasObject (id);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">the object to look for. Must not be null.</param>
		/// <summary>Determine if an object is contained within the pack file.</summary>
		/// <returns>true if the object is in this pack; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']/method[@name='hasObject' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("hasObject", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetHasObject_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe bool HasObject (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "hasObject.(Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		/// <summary>Provide iterator over entries in associated pack index, that should also
		/// exist in this pack file.</summary>
		/// <returns>iterator over entries of associated pack index</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shouldBeKept;
#pragma warning disable 0169
		static Delegate GetShouldBeKeptHandler ()
		{
			if (cb_shouldBeKept == null)
				cb_shouldBeKept = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ShouldBeKept);
			return cb_shouldBeKept;
		}

		static bool n_ShouldBeKept (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldBeKept ();
		}
#pragma warning restore 0169

		/// <summary>Determines whether a .</summary>
		/// <returns>true if a .keep file exist.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackFile']/method[@name='shouldBeKept' and count(parameter)=0]"
		[Register ("shouldBeKept", "()Z", "GetShouldBeKeptHandler")]
		public virtual unsafe bool ShouldBeKept ()
		{
			const string __id = "shouldBeKept.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
