using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>Describes a pack file <c>ObjectReuseAsIs</c> can append onto a stream.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='CachedPack']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/CachedPack", DoNotGenerateAcw=true)]
	public abstract partial class CachedPack : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/CachedPack", typeof (CachedPack));

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

		protected CachedPack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='CachedPack']/constructor[@name='CachedPack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CachedPack () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getDeltaCount;
#pragma warning disable 0169
		static Delegate GetGetDeltaCountHandler ()
		{
			if (cb_getDeltaCount == null)
				cb_getDeltaCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDeltaCount);
			return cb_getDeltaCount;
		}

		static long n_GetDeltaCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaCount;
		}
#pragma warning restore 0169

		/// <summary>Get the number of delta objects stored in this pack.</summary>
		/// <returns>the number of deltas; 0 if the number is not known or there are
		///         no deltas.</returns>
		public virtual unsafe long DeltaCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='CachedPack']/method[@name='getDeltaCount' and count(parameter)=0]"
			[Register ("getDeltaCount", "()J", "GetGetDeltaCountHandler")]
			get {
				const string __id = "getDeltaCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectCount;
		}
#pragma warning restore 0169

		public abstract long ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='CachedPack']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()J", "GetGetObjectCountHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (native_obj, JniHandleOwnership.DoNotTransfer);
			var rep = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation> (native_rep, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasObject (obj, rep);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="obj">the object being packed. Can be used as an ObjectId.</param>
		/// <param name="rep">representation from the <c>ObjectReuseAsIs</c> instance that
		///            originally supplied this CachedPack.</param>
		/// <summary>Determine if this pack contains the object representation given.</summary>
		/// <returns>true if this pack contains this object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='CachedPack']/method[@name='hasObject' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.ObjectToPack'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.StoredObjectRepresentation']]"
		[Register ("hasObject", "(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Lorg/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation;)Z", "GetHasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_Handler")]
		public abstract bool HasObject (global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack obj, global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation rep);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/CachedPack", DoNotGenerateAcw=true)]
	internal partial class CachedPackInvoker : CachedPack {
		public CachedPackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/CachedPack", typeof (CachedPackInvoker));

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

		/// <summary>Get the number of objects in this pack.</summary>
		/// <returns>the total object count for the pack.</returns>
		public override unsafe long ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='CachedPack']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()J", "GetGetObjectCountHandler")]
			get {
				const string __id = "getObjectCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="obj">the object being packed. Can be used as an ObjectId.</param>
		/// <param name="rep">representation from the <c>ObjectReuseAsIs</c> instance that
		///            originally supplied this CachedPack.</param>
		/// <summary>Determine if this pack contains the object representation given.</summary>
		/// <returns>true if this pack contains this object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='CachedPack']/method[@name='hasObject' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.ObjectToPack'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.StoredObjectRepresentation']]"
		[Register ("hasObject", "(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Lorg/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation;)Z", "GetHasObject_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_Handler")]
		public override unsafe bool HasObject (global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack obj, global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation rep)
		{
			const string __id = "hasObject.(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Lorg/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue ((rep == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rep).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (rep);
			}
		}

	}
}
