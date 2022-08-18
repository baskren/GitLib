using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>A DfsPackFile available for reuse as-is.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsCachedPack']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsCachedPack", DoNotGenerateAcw=true)]
	public partial class DfsCachedPack : global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsCachedPack", typeof (DfsCachedPack));

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

		protected DfsCachedPack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getObjectCount;
#pragma warning disable 0169
		static Delegate GetGetObjectCountHandler ()
		{
			if (cb_getObjectCount == null)
				cb_getObjectCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetObjectCount);
			return cb_getObjectCount;
		}

		static long n_GetObjectCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsCachedPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectCount;
		}
#pragma warning restore 0169

		public override unsafe long ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsCachedPack']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()J", "GetGetObjectCountHandler")]
			get {
				const string __id = "getObjectCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsCachedPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackDescription);
		}
#pragma warning restore 0169

		/// <returns>the description of the pack.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackDescription PackDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsCachedPack']/method[@name='getPackDescription' and count(parameter)=0]"
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

		static Delegate cb_hasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_;
#pragma warning disable 0169
		static Delegate GetHasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_Handler ()
		{
			if (cb_hasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_ == null)
				cb_hasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_HasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_);
			return cb_hasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_;
		}

		static bool n_HasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_rep)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsCachedPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (native_obj, JniHandleOwnership.DoNotTransfer);
			var rep = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation> (native_rep, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasObject (obj, rep);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsCachedPack']/method[@name='hasObject' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.ObjectToPack'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.StoredObjectRepresentation']]"
		[Register ("hasObject", "(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Lorg/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation;)Z", "GetHasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_Handler")]
		public override unsafe bool HasObject (global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack obj, global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation rep)
		{
			const string __id = "hasObject.(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Lorg/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue ((rep == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rep).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (rep);
			}
		}

	}
}
