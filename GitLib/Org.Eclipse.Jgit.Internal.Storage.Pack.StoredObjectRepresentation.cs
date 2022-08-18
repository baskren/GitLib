using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>An object representation <c>PackWriter</c> can consider for packing.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation", DoNotGenerateAcw=true)]
	public partial class StoredObjectRepresentation : global::Java.Lang.Object {
		/// <summary>Only available after inflating to canonical format.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']/field[@name='FORMAT_OTHER']"
		[Register ("FORMAT_OTHER")]
		public const int FormatOther = (int) 2;

		/// <summary>Stored in pack format, as a delta to another object.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']/field[@name='PACK_DELTA']"
		[Register ("PACK_DELTA")]
		public const int PackDelta = (int) 0;

		/// <summary>Stored in pack format, without delta.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']/field[@name='PACK_WHOLE']"
		[Register ("PACK_WHOLE")]
		public const int PackWhole = (int) 1;

		/// <summary>Special unknown value for <c>#getWeight()</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']/field[@name='WEIGHT_UNKNOWN']"
		[Register ("WEIGHT_UNKNOWN")]
		public const int WeightUnknown = (int) 2147483647;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation", typeof (StoredObjectRepresentation));

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

		protected StoredObjectRepresentation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']/constructor[@name='StoredObjectRepresentation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StoredObjectRepresentation () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getDeltaBase;
#pragma warning disable 0169
		static Delegate GetGetDeltaBaseHandler ()
		{
			if (cb_getDeltaBase == null)
				cb_getDeltaBase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeltaBase);
			return cb_getDeltaBase;
		}

		static IntPtr n_GetDeltaBase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeltaBase);
		}
#pragma warning restore 0169

		/// <returns>identity of the object this delta applies to in order to recover
		///         the original object content. This method should only be called if
		///         <c>#getFormat()</c> returned <c>#PACK_DELTA</c>.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId DeltaBase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']/method[@name='getDeltaBase' and count(parameter)=0]"
			[Register ("getDeltaBase", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetDeltaBaseHandler")]
			get {
				const string __id = "getDeltaBase.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFormat);
			return cb_getFormat;
		}

		static int n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Format;
		}
#pragma warning restore 0169

		/// <returns>the storage format type, which must be one of
		///         <c>#PACK_DELTA</c>, <c>#PACK_WHOLE</c>, or
		///         <c>#FORMAT_OTHER</c>.</returns>
		public virtual unsafe int Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()I", "GetGetFormatHandler")]
			get {
				const string __id = "getFormat.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWeight;
#pragma warning disable 0169
		static Delegate GetGetWeightHandler ()
		{
			if (cb_getWeight == null)
				cb_getWeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetWeight);
			return cb_getWeight;
		}

		static int n_GetWeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Weight;
		}
#pragma warning restore 0169

		/// <returns>relative size of this object's packed form. The special value
		///         <c>#WEIGHT_UNKNOWN</c> can be returned to indicate the
		///         implementation doesn't know, or cannot supply the weight up
		///         front.</returns>
		public virtual unsafe int Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()I", "GetGetWeightHandler")]
			get {
				const string __id = "getWeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_wasDeltaAttempted;
#pragma warning disable 0169
		static Delegate GetWasDeltaAttemptedHandler ()
		{
			if (cb_wasDeltaAttempted == null)
				cb_wasDeltaAttempted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_WasDeltaAttempted);
			return cb_wasDeltaAttempted;
		}

		static bool n_WasDeltaAttempted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WasDeltaAttempted ();
		}
#pragma warning restore 0169

		/// <returns>whether the current representation of the object has had delta
		///         compression attempted on it.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='StoredObjectRepresentation']/method[@name='wasDeltaAttempted' and count(parameter)=0]"
		[Register ("wasDeltaAttempted", "()Z", "GetWasDeltaAttemptedHandler")]
		public virtual unsafe bool WasDeltaAttempted ()
		{
			const string __id = "wasDeltaAttempted.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
