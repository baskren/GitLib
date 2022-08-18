using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk {

	/// <summary>Iterator over an empty tree (a directory with no files).</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/EmptyTreeIterator", DoNotGenerateAcw=true)]
	public partial class EmptyTreeIterator : global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/EmptyTreeIterator", typeof (EmptyTreeIterator));

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

		protected EmptyTreeIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a new iterator with no parent.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/constructor[@name='EmptyTreeIterator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EmptyTreeIterator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="p">parent tree iterator.</param>
		/// <param name="childPath">path array to be used by the child iterator. This path must
		///            contain the path from the top of the walk to the first child
		///            and must end with a '/'.</param>
		/// <param name="childPathOffset">position within &lt;code&gt;childPath&lt;/code&gt; where the child can
		///            insert its data. The value at
		///            &lt;code&gt;childPath[childPathOffset-1]&lt;/code&gt; must be '/'.</param>
		/// <summary>Create an iterator for a subtree of an existing iterator.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/constructor[@name='EmptyTreeIterator' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;[BI)V", "")]
		public unsafe EmptyTreeIterator (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator p, byte[] childPath, int childPathOffset) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;[BI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_childPath = JNIEnv.NewArray (childPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [1] = new JniArgumentValue (native_childPath);
				__args [2] = new JniArgumentValue (childPathOffset);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (childPath != null) {
					JNIEnv.CopyArray (native_childPath, childPath);
					JNIEnv.DeleteLocalRef (native_childPath);
				}
				global::System.GC.KeepAlive (p);
				global::System.GC.KeepAlive (childPath);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasId;
		}
#pragma warning restore 0169

		public override unsafe bool HasId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/method[@name='hasId' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Back (delta);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/method[@name='back' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSubtreeIterator (reader));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/method[@name='createSubtreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Eof ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/method[@name='eof' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.First ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/method[@name='first' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.IdBuffer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/method[@name='idBuffer' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdOffset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/method[@name='idOffset' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Next (delta);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='EmptyTreeIterator']/method[@name='next' and count(parameter)=1 and parameter[1][@type='int']]"
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
