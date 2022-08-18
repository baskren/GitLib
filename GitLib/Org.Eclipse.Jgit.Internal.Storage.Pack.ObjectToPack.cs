using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>Per-object state used by <c>PackWriter</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/ObjectToPack", DoNotGenerateAcw=true)]
	public partial class ObjectToPack : global::Org.Eclipse.Jgit.Transport.PackedObjectInfo {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/ObjectToPack", typeof (ObjectToPack));

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

		protected ObjectToPack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="src">object id of object for packing</param>
		/// <param name="type">real type code of the object, not its in-pack type.</param>
		/// <summary>Construct for the specified object id.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/constructor[@name='ObjectToPack' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)V", "")]
		public unsafe ObjectToPack (global::Org.Eclipse.Jgit.Lib.AnyObjectId src, int type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/AnyObjectId;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		/// <returns>delta base object to pack if object is going to be packed in
		///         delta representation and delta is specified as object to
		///         pack; null otherwise - if going to be packed as a whole
		///         object or delta base is specified only as id.</returns>
		public unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack DeltaBase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='getDeltaBase' and count(parameter)=0]"
			[Register ("getDeltaBase", "()Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;", "")]
			get {
				const string __id = "getDeltaBase.()Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>delta base object id if object is going to be packed in delta
		///         representation; null otherwise - if going to be packed as a
		///         whole object.</returns>
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId DeltaBaseId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='getDeltaBaseId' and count(parameter)=0]"
			[Register ("getDeltaBaseId", "()Lorg/eclipse/jgit/lib/ObjectId;", "")]
			get {
				const string __id = "getDeltaBaseId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>the extended flags on this object, in the range [0x0, 0xf].</returns>
		/// <summary>Set the extended flags used by the subclass.</summary>
		/// <param name="extFlags">additional flag bits to store in the flags field. Due to space
		///            constraints only values [0x0, 0xf] are permitted.</param>
		protected unsafe int ExtendedFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='getExtendedFlags' and count(parameter)=0]"
			[Register ("getExtendedFlags", "()I", "")]
			get {
				const string __id = "getExtendedFlags.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='setExtendedFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExtendedFlags", "(I)V", "")]
			set {
				const string __id = "setExtendedFlags.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		/// <returns>true if object is going to be written as delta; false
		///         otherwise.</returns>
		public unsafe bool IsDeltaRepresentation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='isDeltaRepresentation' and count(parameter)=0]"
			[Register ("isDeltaRepresentation", "()Z", "")]
			get {
				const string __id = "isDeltaRepresentation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>true if an existing representation was selected to be reused
		///         as-is into the pack stream.</returns>
		public unsafe bool IsReuseAsIs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='isReuseAsIs' and count(parameter)=0]"
			[Register ("isReuseAsIs", "()Z", "")]
			get {
				const string __id = "isReuseAsIs.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Check if object is already written in a pack.</summary>
		/// <returns>true if object is already written; false otherwise.</returns>
		public unsafe bool IsWritten {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='isWritten' and count(parameter)=0]"
			[Register ("isWritten", "()Z", "")]
			get {
				const string __id = "isWritten.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>the type of this object.</returns>
		public unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="flag">the bits to clear, must be between 0x0 and 0xf.</param>
		/// <summary>Clear an extended flag bit.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='clearExtendedFlag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clearExtendedFlag", "(I)V", "")]
		protected unsafe void ClearExtendedFlag (int flag)
		{
			const string __id = "clearExtendedFlag.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clearReuseAsIs;
#pragma warning disable 0169
		static Delegate GetClearReuseAsIsHandler ()
		{
			if (cb_clearReuseAsIs == null)
				cb_clearReuseAsIs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearReuseAsIs);
			return cb_clearReuseAsIs;
		}

		static void n_ClearReuseAsIs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearReuseAsIs ();
		}
#pragma warning restore 0169

		/// <summary>Forget the reuse information previously stored.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='clearReuseAsIs' and count(parameter)=0]"
		[Register ("clearReuseAsIs", "()V", "GetClearReuseAsIsHandler")]
		protected virtual unsafe void ClearReuseAsIs ()
		{
			const string __id = "clearReuseAsIs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <param name="flag">the flag mask to test, must be between 0x0 and 0xf.</param>
		/// <summary>Determine if a particular extended flag bit has been set.</summary>
		/// <returns>true if any of the bits matching the mask are non-zero.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='isExtendedFlag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isExtendedFlag", "(I)Z", "")]
		protected unsafe bool IsExtendedFlag (int flag)
		{
			const string __id = "isExtendedFlag.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_select_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_;
#pragma warning disable 0169
		static Delegate GetSelect_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_Handler ()
		{
			if (cb_select_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_ == null)
				cb_select_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Select_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_);
			return cb_select_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_;
		}

		static void n_Select_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation> (native__ref, JniHandleOwnership.DoNotTransfer);
			__this.Select (@ref);
		}
#pragma warning restore 0169

		/// <param name="ref">the object representation.</param>
		/// <summary>Remember a specific representation for reuse at a later time.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='select' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.StoredObjectRepresentation']]"
		[Register ("select", "(Lorg/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation;)V", "GetSelect_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_Handler")]
		public virtual unsafe void Select (global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation @ref)
		{
			const string __id = "select.(Lorg/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@ref);
			}
		}

		/// <param name="flag">the bits to set, must be between 0x0 and 0xf.</param>
		/// <summary>Set an extended flag bit.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='ObjectToPack']/method[@name='setExtendedFlag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setExtendedFlag", "(I)V", "")]
		protected unsafe void SetExtendedFlag (int flag)
		{
			const string __id = "setExtendedFlag.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
