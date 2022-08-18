using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Org.Eclipse.Jgit.Lib;

namespace Org.Eclipse.Jgit.Treewalk {

	/// <summary>Parses raw Git trees from the canonical semi-text/semi-binary format.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/CanonicalTreeParser", DoNotGenerateAcw=true)]
	public partial class CanonicalTreeParser : global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/CanonicalTreeParser", typeof (CanonicalTreeParser));

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

		protected CanonicalTreeParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a new parser.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/constructor[@name='CanonicalTreeParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CanonicalTreeParser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		/// <param name="prefix">position of this iterator in the repository tree. The value
		///            may be null or the empty array to indicate the prefix is the
		///            root of the repository. A trailing slash ('/') is
		///            automatically appended if the prefix does not end in '/'.</param>
		/// <param name="reader">reader to load the tree data from.</param>
		/// <param name="treeId">identity of the tree being parsed; used only in exception
		///            messages if data corruption is found.</param>
		/// <summary>Create a new parser for a tree appearing in a subset of a repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/constructor[@name='CanonicalTreeParser' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[3][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register (".ctor", "([BLorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
		public unsafe CanonicalTreeParser (byte[] prefix, global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.AnyObjectId treeId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BLorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_prefix = JNIEnv.NewArray (prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_prefix);
				__args [1] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [2] = new JniArgumentValue ((treeId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) treeId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (prefix != null) {
					JNIEnv.CopyArray (native_prefix, prefix);
					JNIEnv.DeleteLocalRef (native_prefix);
				}
				global::System.GC.KeepAlive (prefix);
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (treeId);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasId;
		}
#pragma warning restore 0169

		public override unsafe bool HasId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='hasId' and count(parameter)=0]"
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

		static Delegate cb_getParent;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetParentHandler ()
		{
			if (cb_getParent == null)
				cb_getParent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParent);
			return cb_getParent;
		}

		[Obsolete]
		static IntPtr n_GetParent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parent);
		}
#pragma warning restore 0169

		/// <returns>the parent of this tree parser</returns>
		[Obsolete (@"deprecated")]
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;", "GetGetParentHandler")]
			get {
				const string __id = "getParent.()Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Back (delta);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='back' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSubtreeIterator (reader));
			return __ret;
		}
#pragma warning restore 0169


        // Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='createSubtreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
        [Register ("createSubtreeIterator", "(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;", "GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Handler")]
		public override unsafe AbstractTreeIterator CreateSubtreeIterator (global::Org.Eclipse.Jgit.Lib.ObjectReader reader)
		{
			const string __id = "createSubtreeIterator.(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		/// <param name="reader">reader to load the tree data from.</param>
		/// <param name="id">ObjectId of the tree to open.</param>
		/// <summary>Back door to quickly create a subtree iterator for any subtree.</summary>
		/// <returns>a new parser that walks over the current subtree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='createSubtreeIterator0' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("createSubtreeIterator0", "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;", "")]
		public unsafe global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser CreateSubtreeIterator0 (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "createSubtreeIterator0.(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (id);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Eof ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='eof' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.First ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='first' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.IdBuffer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='idBuffer' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdOffset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='idOffset' and count(parameter)=0]"
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

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		/// <returns>this iterator, or its parent, if the tree is at eof.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;", "GetNextHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser Next ()
		{
			const string __id = "next.()Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Next (delta);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='next' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_reset_arrayB;
#pragma warning disable 0169
		static Delegate GetReset_arrayBHandler ()
		{
			if (cb_reset_arrayB == null)
				cb_reset_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Reset_arrayB);
			return cb_reset_arrayB;
		}

		static void n_Reset_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_treeData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var treeData = (byte[]) JNIEnv.GetArray (native_treeData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Reset (treeData);
			if (treeData != null)
				JNIEnv.CopyArray (treeData, native_treeData);
		}
#pragma warning restore 0169

		/// <param name="treeData">the raw tree content.</param>
		/// <summary>Reset this parser to walk through the given tree data.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("reset", "([B)V", "GetReset_arrayBHandler")]
		public virtual unsafe void Reset (byte[] treeData)
		{
			const string __id = "reset.([B)V";
			IntPtr native_treeData = JNIEnv.NewArray (treeData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_treeData);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (treeData != null) {
					JNIEnv.CopyArray (native_treeData, treeData);
					JNIEnv.DeleteLocalRef (native_treeData);
				}
				global::System.GC.KeepAlive (treeData);
			}
		}

		static Delegate cb_reset_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetReset_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_reset_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_reset_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Reset_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_reset_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Reset_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.Reset (reader, id);
		}
#pragma warning restore 0169

		/// <param name="reader">reader to use during repository access.</param>
		/// <param name="id">identity of the tree being parsed; used only in exception
		///            messages if data corruption is found.</param>
		/// <summary>Reset this parser to walk through the given tree.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='reset' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("reset", "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetReset_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void Reset (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "reset.(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_resetRoot_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetResetRoot_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_resetRoot_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_resetRoot_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ResetRoot_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_resetRoot_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_ResetRoot_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResetRoot (reader, id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="reader">reader to use during repository access.</param>
		/// <param name="id">identity of the tree being parsed; used only in exception
		///            messages if data corruption is found.</param>
		/// <summary>Reset this parser to walk through the given tree.</summary>
		/// <returns>the root level parser.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='CanonicalTreeParser']/method[@name='resetRoot' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("resetRoot", "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;", "GetResetRoot_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser ResetRoot (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "resetRoot.(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/treewalk/CanonicalTreeParser;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.CanonicalTreeParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (id);
			}
		}

    }
}
