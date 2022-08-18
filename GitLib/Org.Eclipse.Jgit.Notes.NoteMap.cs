using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Notes {

	/// <summary>Index of notes from a note branch.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/notes/NoteMap", DoNotGenerateAcw=true)]
	public partial class NoteMap : global::Java.Lang.Object, global::Java.Lang.IIterable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/notes/NoteMap", typeof (NoteMap));

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

		protected NoteMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetContains_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_Contains_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (id);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">the object to look for.</param>
		/// <summary>Determine if a note exists for the specified ObjectId.</summary>
		/// <returns>true if a note exists; false if there is no note.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("contains", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetContains_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe bool Contains (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "contains.(Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_get_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetGet_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_get_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_get_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_get_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Get_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">the object to look for.</param>
		/// <summary>Lookup a note for a specific ObjectId.</summary>
		/// <returns>the note's blob ObjectId, or null if no note exists.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='get' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("get", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/ObjectId;", "GetGet_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Get (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "get.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_getCachedBytes_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetGetCachedBytes_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_getCachedBytes_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_getCachedBytes_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_GetCachedBytes_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_getCachedBytes_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static IntPtr n_GetCachedBytes_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_id, int sizeLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetCachedBytes (id, sizeLimit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">object to lookup the note of.</param>
		/// <param name="sizeLimit">maximum number of bytes to return. If the note data size is
		///            larger than this limit, LargeObjectException will be thrown.</param>
		/// <summary>Open and return the content of an object's note.</summary>
		/// <returns>if a note is defined for <c>id</c>, the note content. If no note
		///         is defined, null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='getCachedBytes' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("getCachedBytes", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)[B", "GetGetCachedBytes_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public virtual unsafe byte[] GetCachedBytes (global::Org.Eclipse.Jgit.Lib.AnyObjectId id, int sizeLimit)
		{
			const string __id = "getCachedBytes.(Lorg/eclipse/jgit/lib/AnyObjectId;I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [1] = new JniArgumentValue (sizeLimit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_getNote_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetGetNote_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_getNote_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_getNote_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetNote_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_getNote_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_GetNote_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNote (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">the object to look for.</param>
		/// <summary>Lookup a note for a specific ObjectId.</summary>
		/// <returns>the note for the given object id, or null if no note exists.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='getNote' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("getNote", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/notes/Note;", "GetGetNote_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Notes.Note GetNote (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "getNote.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/notes/Note;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.Note> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		/// <returns>an iterator that iterates over notes of this NoteMap. Non note
		///         entries are ignored by this iterator.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='iterator' and count(parameter)=0]"
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

		/// <summary>Construct a new empty note map.</summary>
		/// <returns>an empty note map.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='newEmptyMap' and count(parameter)=0]"
		[Register ("newEmptyMap", "()Lorg/eclipse/jgit/notes/NoteMap;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Notes.NoteMap NewEmptyMap ()
		{
			const string __id = "newEmptyMap.()Lorg/eclipse/jgit/notes/NoteMap;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="reader">reader to scan the note branch with. This reader may be
		///            retained by the NoteMap for the life of the map in order to
		///            support lazy loading of entries.</param>
		/// <param name="commit">the revision of the note branch to read.</param>
		/// <summary>Load a collection of notes from a branch.</summary>
		/// <returns>the note map read from the commit.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='read' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("read", "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/notes/NoteMap;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Notes.NoteMap Read (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Revwalk.RevCommit commit)
		{
			const string __id = "read.(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/revwalk/RevCommit;)Lorg/eclipse/jgit/notes/NoteMap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (commit);
			}
		}

		/// <param name="reader">reader to scan the note branch with. This reader may be
		///            retained by the NoteMap for the life of the map in order to
		///            support lazy loading of entries.</param>
		/// <param name="tree">the note tree to read.</param>
		/// <summary>Load a collection of notes from a tree.</summary>
		/// <returns>the note map read from the tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='read' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevTree']]"
		[Register ("read", "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/revwalk/RevTree;)Lorg/eclipse/jgit/notes/NoteMap;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Notes.NoteMap Read (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Revwalk.RevTree tree)
		{
			const string __id = "read.(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/revwalk/RevTree;)Lorg/eclipse/jgit/notes/NoteMap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((tree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tree).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (tree);
			}
		}

		/// <param name="reader">reader to scan the note branch with. This reader may be
		///            retained by the NoteMap for the life of the map in order to
		///            support lazy loading of entries.</param>
		/// <param name="treeId">the note tree to read.</param>
		/// <summary>Load a collection of notes from a tree.</summary>
		/// <returns>the note map read from the tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='readTree' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("readTree", "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/notes/NoteMap;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Notes.NoteMap ReadTree (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.ObjectId treeId)
		{
			const string __id = "readTree.(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/notes/NoteMap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((treeId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) treeId).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (treeId);
			}
		}

		static Delegate cb_remove_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetRemove_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_remove_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_remove_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Remove_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_remove_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Remove_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_noteOn)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var noteOn = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_noteOn, JniHandleOwnership.DoNotTransfer);
			__this.Remove (noteOn);
		}
#pragma warning restore 0169

		/// <param name="noteOn">the object to remove the note from.</param>
		/// <summary>Remove a note from an object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("remove", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetRemove_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void Remove (global::Org.Eclipse.Jgit.Lib.AnyObjectId noteOn)
		{
			const string __id = "remove.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((noteOn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) noteOn).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (noteOn);
			}
		}

		static Delegate cb_set_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectInserter_;
#pragma warning disable 0169
		static Delegate GetSet_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectInserter_Handler ()
		{
			if (cb_set_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectInserter_ == null)
				cb_set_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectInserter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Set_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectInserter_);
			return cb_set_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectInserter_;
		}

		static void n_Set_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectInserter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_noteOn, IntPtr native_noteData, IntPtr native_ins)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var noteOn = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_noteOn, JniHandleOwnership.DoNotTransfer);
			var noteData = JNIEnv.GetString (native_noteData, JniHandleOwnership.DoNotTransfer);
			var ins = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (native_ins, JniHandleOwnership.DoNotTransfer);
			__this.Set (noteOn, noteData, ins);
		}
#pragma warning restore 0169

		/// <param name="noteOn">the object to attach the note to. This same ObjectId can later
		///            be used as an argument to <c>#get(AnyObjectId)</c> or
		///            <c>#getCachedBytes(AnyObjectId, int)</c> to read back the
		///            <c>noteData</c>.</param>
		/// <param name="noteData">text to store in the note. The text will be UTF-8 encoded when
		///            stored in the repository. If null the note will be deleted, if
		///            the empty string a note with the empty string will be stored.</param>
		/// <param name="ins">inserter to write the encoded <c>noteData</c> out as a blob.
		///            The caller must ensure the inserter is flushed before the
		///            updated note map is made available for reading.</param>
		/// <summary>Attach a note to an object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='set' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectInserter']]"
		[Register ("set", "(Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectInserter;)V", "GetSet_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectInserter_Handler")]
		public virtual unsafe void Set (global::Org.Eclipse.Jgit.Lib.AnyObjectId noteOn, string noteData, global::Org.Eclipse.Jgit.Lib.ObjectInserter ins)
		{
			const string __id = "set.(Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectInserter;)V";
			IntPtr native_noteData = JNIEnv.NewString ((string)noteData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((noteOn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) noteOn).Handle);
				__args [1] = new JniArgumentValue (native_noteData);
				__args [2] = new JniArgumentValue ((ins == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ins).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_noteData);
				global::System.GC.KeepAlive (noteOn);
				global::System.GC.KeepAlive (ins);
			}
		}

		static Delegate cb_set_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetSet_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_set_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_set_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Set_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_set_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static void n_Set_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_noteOn, IntPtr native_noteData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var noteOn = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_noteOn, JniHandleOwnership.DoNotTransfer);
			var noteData = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_noteData, JniHandleOwnership.DoNotTransfer);
			__this.Set (noteOn, noteData);
		}
#pragma warning restore 0169

		/// <param name="noteOn">the object to attach the note to. This same ObjectId can later
		///            be used as an argument to <c>#get(AnyObjectId)</c> or
		///            <c>#getCachedBytes(AnyObjectId, int)</c> to read back the
		///            <c>noteData</c>.</param>
		/// <param name="noteData">data to associate with the note. This must be the ObjectId of
		///            a blob that already exists in the repository. If null the note
		///            will be deleted, if present.</param>
		/// <summary>Attach (or remove) a note on an object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='set' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("set", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/ObjectId;)V", "GetSet_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public virtual unsafe void Set (global::Org.Eclipse.Jgit.Lib.AnyObjectId noteOn, global::Org.Eclipse.Jgit.Lib.ObjectId noteData)
		{
			const string __id = "set.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/lib/ObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((noteOn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) noteOn).Handle);
				__args [1] = new JniArgumentValue ((noteData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) noteData).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (noteOn);
				global::System.GC.KeepAlive (noteData);
			}
		}

		/// <param name="noteRefName">noteRefName</param>
		/// <summary>Shorten the note ref name by trimming off the <c>Constants#R_NOTES</c>
		/// prefix if it exists.</summary>
		/// <returns>a more user friendly note name</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='shortenRefName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("shortenRefName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ShortenRefName (string noteRefName)
		{
			const string __id = "shortenRefName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_noteRefName = JNIEnv.NewString ((string)noteRefName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_noteRefName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_noteRefName);
			}
		}

		static Delegate cb_writeTree_Lorg_eclipse_jgit_lib_ObjectInserter_;
#pragma warning disable 0169
		static Delegate GetWriteTree_Lorg_eclipse_jgit_lib_ObjectInserter_Handler ()
		{
			if (cb_writeTree_Lorg_eclipse_jgit_lib_ObjectInserter_ == null)
				cb_writeTree_Lorg_eclipse_jgit_lib_ObjectInserter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WriteTree_Lorg_eclipse_jgit_lib_ObjectInserter_);
			return cb_writeTree_Lorg_eclipse_jgit_lib_ObjectInserter_;
		}

		static IntPtr n_WriteTree_Lorg_eclipse_jgit_lib_ObjectInserter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inserter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Notes.NoteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inserter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (native_inserter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteTree (inserter));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="inserter">inserter to use when writing trees to the object database.
		///            Caller is responsible for flushing the inserter before trying
		///            to read the objects, or exposing them through a reference.</param>
		/// <summary>Write this note map as a tree.</summary>
		/// <returns>the top level tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.notes']/class[@name='NoteMap']/method[@name='writeTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectInserter']]"
		[Register ("writeTree", "(Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/lib/ObjectId;", "GetWriteTree_Lorg_eclipse_jgit_lib_ObjectInserter_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId WriteTree (global::Org.Eclipse.Jgit.Lib.ObjectInserter inserter)
		{
			const string __id = "writeTree.(Lorg/eclipse/jgit/lib/ObjectInserter;)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inserter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inserter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inserter);
			}
		}

	}
}
