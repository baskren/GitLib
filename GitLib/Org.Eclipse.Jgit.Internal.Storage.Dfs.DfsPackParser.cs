using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Parses a pack stream into the DFS, by creating a new pack and index.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsPackParser", DoNotGenerateAcw=true)]
	public partial class DfsPackParser : global::Org.Eclipse.Jgit.Transport.PackParser {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsPackParser", typeof (DfsPackParser));

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

		protected DfsPackParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="db">database the objects will be imported into.</param>
		/// <param name="ins">inserter the parser will use to help it inject the objects.</param>
		/// <param name="in">the stream to parse.</param>
		/// <summary>Initialize a new pack parser.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/constructor[@name='DfsPackParser' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsObjDatabase'] and parameter[2][@type='org.eclipse.jgit.internal.storage.dfs.DfsInserter'] and parameter[3][@type='java.io.InputStream']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase;Lorg/eclipse/jgit/internal/storage/dfs/DfsInserter;Ljava/io/InputStream;)V", "")]
		protected unsafe DfsPackParser (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase db, global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsInserter ins, global::System.IO.Stream @in) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase;Lorg/eclipse/jgit/internal/storage/dfs/DfsInserter;Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue ((ins == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ins).Handle);
				__args [2] = new JniArgumentValue (native__in);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (db);
				global::System.GC.KeepAlive (ins);
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate cb_getPackDescription;
#pragma warning disable 0169
		static Delegate GetGetPackDescriptionHandler ()
		{
			if (cb_getPackDescription == null)
				cb_getPackDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackDescription);
			return cb_getPackDescription;
		}

		static IntPtr n_GetPackDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackDescription);
		}
#pragma warning restore 0169

		/// <returns>description of the imported pack, if one was made.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription PackDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='getPackDescription' and count(parameter)=0]"
			[Register ("getPackDescription", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;", "GetGetPackDescriptionHandler")]
			get {
				const string __id = "getPackDescription.()Lorg/eclipse/jgit/internal/storage/dfs/DfsPackDescription;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkCRC_I;
#pragma warning disable 0169
		static Delegate GetCheckCRC_IHandler ()
		{
			if (cb_checkCRC_I == null)
				cb_checkCRC_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_CheckCRC_I);
			return cb_checkCRC_I;
		}

		static bool n_CheckCRC_I (IntPtr jnienv, IntPtr native__this, int oldCRC)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckCRC (oldCRC);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='checkCRC' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkCRC", "(I)Z", "GetCheckCRC_IHandler")]
		protected override unsafe bool CheckCRC (int oldCRC)
		{
			const string __id = "checkCRC.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (oldCRC);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_;
#pragma warning disable 0169
		static Delegate GetOnAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_Handler ()
		{
			if (cb_onAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_ == null)
				cb_onAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_Z) n_OnAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_);
			return cb_onAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_;
		}

		static bool n_OnAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_ (IntPtr jnienv, IntPtr native__this, int typeCode, IntPtr native_data, IntPtr native_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var info = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (native_info, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnAppendBase (typeCode, data, info);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onAppendBase' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='org.eclipse.jgit.transport.PackedObjectInfo']]"
		[Register ("onAppendBase", "(I[BLorg/eclipse/jgit/transport/PackedObjectInfo;)Z", "GetOnAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_Handler")]
		protected override unsafe bool OnAppendBase (int typeCode, byte[] data, global::Org.Eclipse.Jgit.Transport.PackedObjectInfo info)
		{
			const string __id = "onAppendBase.(I[BLorg/eclipse/jgit/transport/PackedObjectInfo;)Z";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (typeCode);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (info);
			}
		}

		static Delegate cb_onBeginOfsDelta_JJJ;
#pragma warning disable 0169
		static Delegate GetOnBeginOfsDelta_JJJHandler ()
		{
			if (cb_onBeginOfsDelta_JJJ == null)
				cb_onBeginOfsDelta_JJJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJJ_V) n_OnBeginOfsDelta_JJJ);
			return cb_onBeginOfsDelta_JJJ;
		}

		static void n_OnBeginOfsDelta_JJJ (IntPtr jnienv, IntPtr native__this, long streamPosition, long baseStreamPosition, long inflatedSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginOfsDelta (streamPosition, baseStreamPosition, inflatedSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onBeginOfsDelta' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onBeginOfsDelta", "(JJJ)V", "GetOnBeginOfsDelta_JJJHandler")]
		protected override unsafe void OnBeginOfsDelta (long streamPosition, long baseStreamPosition, long inflatedSize)
		{
			const string __id = "onBeginOfsDelta.(JJJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (streamPosition);
				__args [1] = new JniArgumentValue (baseStreamPosition);
				__args [2] = new JniArgumentValue (inflatedSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J;
#pragma warning disable 0169
		static Delegate GetOnBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_JHandler ()
		{
			if (cb_onBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J == null)
				cb_onBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJLJ_V) n_OnBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J);
			return cb_onBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J;
		}

		static void n_OnBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J (IntPtr jnienv, IntPtr native__this, long streamPosition, IntPtr native_baseId, long inflatedSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var baseId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_baseId, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginRefDelta (streamPosition, baseId, inflatedSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onBeginRefDelta' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[3][@type='long']]"
		[Register ("onBeginRefDelta", "(JLorg/eclipse/jgit/lib/AnyObjectId;J)V", "GetOnBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_JHandler")]
		protected override unsafe void OnBeginRefDelta (long streamPosition, global::Org.Eclipse.Jgit.Lib.AnyObjectId baseId, long inflatedSize)
		{
			const string __id = "onBeginRefDelta.(JLorg/eclipse/jgit/lib/AnyObjectId;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (streamPosition);
				__args [1] = new JniArgumentValue ((baseId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseId).Handle);
				__args [2] = new JniArgumentValue (inflatedSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (baseId);
			}
		}

		static Delegate cb_onBeginWholeObject_JIJ;
#pragma warning disable 0169
		static Delegate GetOnBeginWholeObject_JIJHandler ()
		{
			if (cb_onBeginWholeObject_JIJ == null)
				cb_onBeginWholeObject_JIJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJIJ_V) n_OnBeginWholeObject_JIJ);
			return cb_onBeginWholeObject_JIJ;
		}

		static void n_OnBeginWholeObject_JIJ (IntPtr jnienv, IntPtr native__this, long streamPosition, int type, long inflatedSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginWholeObject (streamPosition, type, inflatedSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onBeginWholeObject' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("onBeginWholeObject", "(JIJ)V", "GetOnBeginWholeObject_JIJHandler")]
		protected override unsafe void OnBeginWholeObject (long streamPosition, int type, long inflatedSize)
		{
			const string __id = "onBeginWholeObject.(JIJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (streamPosition);
				__args [1] = new JniArgumentValue (type);
				__args [2] = new JniArgumentValue (inflatedSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onEndThinPack;
#pragma warning disable 0169
		static Delegate GetOnEndThinPackHandler ()
		{
			if (cb_onEndThinPack == null)
				cb_onEndThinPack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnEndThinPack);
			return cb_onEndThinPack;
		}

		static void n_OnEndThinPack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEndThinPack ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onEndThinPack' and count(parameter)=0]"
		[Register ("onEndThinPack", "()V", "GetOnEndThinPackHandler")]
		protected override unsafe void OnEndThinPack ()
		{
			const string __id = "onEndThinPack.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_;
#pragma warning disable 0169
		static Delegate GetOnEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_Handler ()
		{
			if (cb_onEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_ == null)
				cb_onEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_);
			return cb_onEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_;
		}

		static void n_OnEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var info = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (native_info, JniHandleOwnership.DoNotTransfer);
			__this.OnEndWholeObject (info);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onEndWholeObject' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PackedObjectInfo']]"
		[Register ("onEndWholeObject", "(Lorg/eclipse/jgit/transport/PackedObjectInfo;)V", "GetOnEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_Handler")]
		protected override unsafe void OnEndWholeObject (global::Org.Eclipse.Jgit.Transport.PackedObjectInfo info)
		{
			const string __id = "onEndWholeObject.(Lorg/eclipse/jgit/transport/PackedObjectInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (info);
			}
		}

		static Delegate cb_onInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB;
#pragma warning disable 0169
		static Delegate GetOnInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayBHandler ()
		{
			if (cb_onInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB == null)
				cb_onInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB);
			return cb_onInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB;
		}

		static void n_OnInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, int typeCode, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (native_obj, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnInflatedObjectData (obj, typeCode, data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onInflatedObjectData' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.PackedObjectInfo'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("onInflatedObjectData", "(Lorg/eclipse/jgit/transport/PackedObjectInfo;I[B)V", "GetOnInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayBHandler")]
		protected override unsafe void OnInflatedObjectData (global::Org.Eclipse.Jgit.Transport.PackedObjectInfo obj, int typeCode, byte[] data)
		{
			const string __id = "onInflatedObjectData.(Lorg/eclipse/jgit/transport/PackedObjectInfo;I[B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (typeCode);
				__args [2] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_onObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII;
#pragma warning disable 0169
		static Delegate GetOnObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler ()
		{
			if (cb_onObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII == null)
				cb_onObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_OnObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII);
			return cb_onObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII;
		}

		static void n_OnObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_src, IntPtr native_raw, int pos, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.Source> (native_src, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnObjectData (src, raw, pos, len);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onObjectData' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.Source'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onObjectData", "(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V", "GetOnObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler")]
		protected override unsafe void OnObjectData (global::Org.Eclipse.Jgit.Transport.PackParser.Source src, byte[] raw, int pos, int len)
		{
			const string __id = "onObjectData.(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (native_raw);
				__args [2] = new JniArgumentValue (pos);
				__args [3] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_onObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII;
#pragma warning disable 0169
		static Delegate GetOnObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler ()
		{
			if (cb_onObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII == null)
				cb_onObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_OnObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII);
			return cb_onObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII;
		}

		static void n_OnObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_src, IntPtr native_raw, int pos, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.Source> (native_src, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnObjectHeader (src, raw, pos, len);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onObjectHeader' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.Source'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onObjectHeader", "(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V", "GetOnObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler")]
		protected override unsafe void OnObjectHeader (global::Org.Eclipse.Jgit.Transport.PackParser.Source src, byte[] raw, int pos, int len)
		{
			const string __id = "onObjectHeader.(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (native_raw);
				__args [2] = new JniArgumentValue (pos);
				__args [3] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_onPackFooter_arrayB;
#pragma warning disable 0169
		static Delegate GetOnPackFooter_arrayBHandler ()
		{
			if (cb_onPackFooter_arrayB == null)
				cb_onPackFooter_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPackFooter_arrayB);
			return cb_onPackFooter_arrayB;
		}

		static void n_OnPackFooter_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_hash)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hash = (byte[]) JNIEnv.GetArray (native_hash, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnPackFooter (hash);
			if (hash != null)
				JNIEnv.CopyArray (hash, native_hash);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onPackFooter' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onPackFooter", "([B)V", "GetOnPackFooter_arrayBHandler")]
		protected override unsafe void OnPackFooter (byte[] hash)
		{
			const string __id = "onPackFooter.([B)V";
			IntPtr native_hash = JNIEnv.NewArray (hash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hash);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (hash != null) {
					JNIEnv.CopyArray (native_hash, hash);
					JNIEnv.DeleteLocalRef (native_hash);
				}
				global::System.GC.KeepAlive (hash);
			}
		}

		static Delegate cb_onPackHeader_J;
#pragma warning disable 0169
		static Delegate GetOnPackHeader_JHandler ()
		{
			if (cb_onPackHeader_J == null)
				cb_onPackHeader_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_OnPackHeader_J);
			return cb_onPackHeader_J;
		}

		static void n_OnPackHeader_J (IntPtr jnienv, IntPtr native__this, long objectCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPackHeader (objectCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onPackHeader' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onPackHeader", "(J)V", "GetOnPackHeader_JHandler")]
		protected override unsafe void OnPackHeader (long objectCount)
		{
			const string __id = "onPackHeader.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (objectCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStoreStream_arrayBII;
#pragma warning disable 0169
		static Delegate GetOnStoreStream_arrayBIIHandler ()
		{
			if (cb_onStoreStream_arrayBII == null)
				cb_onStoreStream_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnStoreStream_arrayBII);
			return cb_onStoreStream_arrayBII;
		}

		static void n_OnStoreStream_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_raw, int pos, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnStoreStream (raw, pos, len);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='onStoreStream' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStoreStream", "([BII)V", "GetOnStoreStream_arrayBIIHandler")]
		protected override unsafe void OnStoreStream (byte[] raw, int pos, int len)
		{
			const string __id = "onStoreStream.([BII)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_readDatabase_arrayBII;
#pragma warning disable 0169
		static Delegate GetReadDatabase_arrayBIIHandler ()
		{
			if (cb_readDatabase_arrayBII == null)
				cb_readDatabase_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_ReadDatabase_arrayBII);
			return cb_readDatabase_arrayBII;
		}

		static int n_ReadDatabase_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_dst, int pos, int cnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dst = (byte[]) JNIEnv.GetArray (native_dst, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadDatabase (dst, pos, cnt);
			if (dst != null)
				JNIEnv.CopyArray (dst, native_dst);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='readDatabase' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readDatabase", "([BII)I", "GetReadDatabase_arrayBIIHandler")]
		protected override unsafe int ReadDatabase (byte[] dst, int pos, int cnt)
		{
			const string __id = "readDatabase.([BII)I";
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_dst);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (cnt);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
				global::System.GC.KeepAlive (dst);
			}
		}

		static Delegate cb_seekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
#pragma warning disable 0169
		static Delegate GetSeekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler ()
		{
			if (cb_seekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ == null)
				cb_seekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SeekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_);
			return cb_seekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
		}

		static IntPtr n_SeekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (native_obj, JniHandleOwnership.DoNotTransfer);
			var info = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (native_info, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SeekDatabase (obj, info));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='seekDatabase' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.PackedObjectInfo'] and parameter[2][@type='org.eclipse.jgit.transport.PackParser.ObjectTypeAndSize']]"
		[Register ("seekDatabase", "(Lorg/eclipse/jgit/transport/PackedObjectInfo;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;", "GetSeekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize SeekDatabase (global::Org.Eclipse.Jgit.Transport.PackedObjectInfo obj, global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize info)
		{
			const string __id = "seekDatabase.(Lorg/eclipse/jgit/transport/PackedObjectInfo;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (info);
			}
		}

		static Delegate cb_seekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
#pragma warning disable 0169
		static Delegate GetSeekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler ()
		{
			if (cb_seekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ == null)
				cb_seekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SeekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_);
			return cb_seekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
		}

		static IntPtr n_SeekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_delta, IntPtr native_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var delta = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta> (native_delta, JniHandleOwnership.DoNotTransfer);
			var info = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (native_info, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SeekDatabase (delta, info));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsPackParser']/method[@name='seekDatabase' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.UnresolvedDelta'] and parameter[2][@type='org.eclipse.jgit.transport.PackParser.ObjectTypeAndSize']]"
		[Register ("seekDatabase", "(Lorg/eclipse/jgit/transport/PackParser$UnresolvedDelta;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;", "GetSeekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize SeekDatabase (global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta delta, global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize info)
		{
			const string __id = "seekDatabase.(Lorg/eclipse/jgit/transport/PackParser$UnresolvedDelta;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((delta == null) ? IntPtr.Zero : ((global::Java.Lang.Object) delta).Handle);
				__args [1] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (delta);
				global::System.GC.KeepAlive (info);
			}
		}

	}
}
