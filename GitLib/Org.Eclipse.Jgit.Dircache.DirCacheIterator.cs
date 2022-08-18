using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Dircache {

	/// <summary>Iterate a <c>DirCache</c> as part of a &lt;code&gt;TreeWalk&lt;/code&gt;.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheIterator", DoNotGenerateAcw=true)]
	public partial class DirCacheIterator : global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator {

		/// <summary>The cache this iterator was created to walk.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/field[@name='cache']"
		[Register ("cache")]
		protected global::Org.Eclipse.Jgit.Dircache.DirCache Cache {
			get {
				const string __id = "cache.Lorg/eclipse/jgit/dircache/DirCache;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cache.Lorg/eclipse/jgit/dircache/DirCache;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>The current file entry from <c>#cache</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/field[@name='currentEntry']"
		[Register ("currentEntry")]
		protected global::Org.Eclipse.Jgit.Dircache.DirCacheEntry CurrentEntry {
			get {
				const string __id = "currentEntry.Lorg/eclipse/jgit/dircache/DirCacheEntry;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "currentEntry.Lorg/eclipse/jgit/dircache/DirCacheEntry;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>The subtree containing <c>#currentEntry</c> if this is first entry.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/field[@name='currentSubtree']"
		[Register ("currentSubtree")]
		protected global::Org.Eclipse.Jgit.Dircache.DirCacheTree CurrentSubtree {
			get {
				const string __id = "currentSubtree.Lorg/eclipse/jgit/dircache/DirCacheTree;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheTree> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "currentSubtree.Lorg/eclipse/jgit/dircache/DirCacheTree;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Index of entry within <c>#cache</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/field[@name='ptr']"
		[Register ("ptr")]
		protected int Ptr {
			get {
				const string __id = "ptr.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ptr.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheIterator", typeof (DirCacheIterator));

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

		protected DirCacheIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="dc">the cache to walk. It must be already loaded into memory.</param>
		/// <summary>Create a new iterator for an already loaded DirCache instance.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/constructor[@name='DirCacheIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCache']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/dircache/DirCache;)V", "")]
		public unsafe DirCacheIterator (global::Org.Eclipse.Jgit.Dircache.DirCache dc) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/dircache/DirCache;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dc).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dc);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DirCacheEntry);
		}
#pragma warning restore 0169

		/// <summary>Get the DirCacheEntry for the current file.</summary>
		/// <returns>the current cache entry, if this iterator is positioned on a
		///         non-tree.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCacheEntry DirCacheEntry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='getDirCacheEntry' and count(parameter)=0]"
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

		static Delegate cb_hasId;
#pragma warning disable 0169
		static Delegate GetHasIdHandler ()
		{
			if (cb_hasId == null)
				cb_hasId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasId);
			return cb_hasId;
		}

		static bool n_HasId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasId;
		}
#pragma warning restore 0169

		public override unsafe bool HasId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='hasId' and count(parameter)=0]"
			[Register ("hasId", "()Z", "GetHasIdHandler")]
			get {
				const string __id = "hasId.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_back_I;
#pragma warning disable 0169
		static Delegate GetBack_IHandler ()
		{
			if (cb_back_I == null)
				cb_back_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Back_I);
			return cb_back_I;
		}

		static void n_Back_I (IntPtr jnienv, IntPtr native__this, int delta)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Back (delta);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='back' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("back", "(I)V", "GetBack_IHandler")]
		public override unsafe void Back (int delta)
		{
			const string __id = "back.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delta);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_;
#pragma warning disable 0169
		static Delegate GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Handler ()
		{
			if (cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_ == null)
				cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_);
			return cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_;
		}

		static IntPtr n_CreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSubtreeIterator (reader));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='createSubtreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register ("createSubtreeIterator", "(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;", "GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator CreateSubtreeIterator (global::Org.Eclipse.Jgit.Lib.ObjectReader reader)
		{
			const string __id = "createSubtreeIterator.(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		static Delegate cb_eof;
#pragma warning disable 0169
		static Delegate GetEofHandler ()
		{
			if (cb_eof == null)
				cb_eof = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Eof);
			return cb_eof;
		}

		static bool n_Eof (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Eof ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='eof' and count(parameter)=0]"
		[Register ("eof", "()Z", "GetEofHandler")]
		public override unsafe bool Eof ()
		{
			const string __id = "eof.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_first;
#pragma warning disable 0169
		static Delegate GetFirstHandler ()
		{
			if (cb_first == null)
				cb_first = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_First);
			return cb_first;
		}

		static bool n_First (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.First ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='first' and count(parameter)=0]"
		[Register ("first", "()Z", "GetFirstHandler")]
		public override unsafe bool First ()
		{
			const string __id = "first.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getEntryAttributesNode_Lorg_eclipse_jgit_lib_ObjectReader_;
#pragma warning disable 0169
		static Delegate GetGetEntryAttributesNode_Lorg_eclipse_jgit_lib_ObjectReader_Handler ()
		{
			if (cb_getEntryAttributesNode_Lorg_eclipse_jgit_lib_ObjectReader_ == null)
				cb_getEntryAttributesNode_Lorg_eclipse_jgit_lib_ObjectReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetEntryAttributesNode_Lorg_eclipse_jgit_lib_ObjectReader_);
			return cb_getEntryAttributesNode_Lorg_eclipse_jgit_lib_ObjectReader_;
		}

		static IntPtr n_GetEntryAttributesNode_Lorg_eclipse_jgit_lib_ObjectReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEntryAttributesNode (reader));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="reader">
		///   <c>ObjectReader</c> used to parse the .gitattributes entry.</param>
		/// <summary>Retrieves the <c>AttributesNode</c> for the current entry.</summary>
		/// <returns>
		///   <c>AttributesNode</c> for the current entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='getEntryAttributesNode' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register ("getEntryAttributesNode", "(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/attributes/AttributesNode;", "GetGetEntryAttributesNode_Lorg_eclipse_jgit_lib_ObjectReader_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Attributes.AttributesNode GetEntryAttributesNode (global::Org.Eclipse.Jgit.Lib.ObjectReader reader)
		{
			const string __id = "getEntryAttributesNode.(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/attributes/AttributesNode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesNode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		static Delegate cb_idBuffer;
#pragma warning disable 0169
		static Delegate GetIdBufferHandler ()
		{
			if (cb_idBuffer == null)
				cb_idBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IdBuffer);
			return cb_idBuffer;
		}

		static IntPtr n_IdBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.IdBuffer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='idBuffer' and count(parameter)=0]"
		[Register ("idBuffer", "()[B", "GetIdBufferHandler")]
		public override unsafe byte[] IdBuffer ()
		{
			const string __id = "idBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_idOffset;
#pragma warning disable 0169
		static Delegate GetIdOffsetHandler ()
		{
			if (cb_idOffset == null)
				cb_idOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_IdOffset);
			return cb_idOffset;
		}

		static int n_IdOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdOffset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='idOffset' and count(parameter)=0]"
		[Register ("idOffset", "()I", "GetIdOffsetHandler")]
		public override unsafe int IdOffset ()
		{
			const string __id = "idOffset.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_next_I;
#pragma warning disable 0169
		static Delegate GetNext_IHandler ()
		{
			if (cb_next_I == null)
				cb_next_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Next_I);
			return cb_next_I;
		}

		static void n_Next_I (IntPtr jnienv, IntPtr native__this, int delta)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Next (delta);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheIterator']/method[@name='next' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("next", "(I)V", "GetNext_IHandler")]
		public override unsafe void Next (int delta)
		{
			const string __id = "next.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delta);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
