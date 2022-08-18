using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	[Register ("org/eclipse/jgit/transport/UploadPackLogger", DoNotGenerateAcw=true)]
	public abstract class UploadPackLogger : Java.Lang.Object {
		internal UploadPackLogger ()
		{
		}


		/// <summary>A simple no-op logger.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='UploadPackLogger']/field[@name='NULL']"
		[Register ("NULL")]
		public static global::Org.Eclipse.Jgit.Transport.IUploadPackLogger Null {
			get {
				const string __id = "NULL.Lorg/eclipse/jgit/transport/UploadPackLogger;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IUploadPackLogger> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPackLogger", typeof (UploadPackLogger));

	}

	[Register ("org/eclipse/jgit/transport/UploadPackLogger", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UploadPackLogger' type. This type will be removed in a future release.", error: true)]
	public abstract class UploadPackLoggerConsts : UploadPackLogger {
		private UploadPackLoggerConsts ()
		{
		}

	}

	/// <summary>Logs activity that occurred within <c>UploadPack</c>.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='UploadPackLogger']"
	[Register ("org/eclipse/jgit/transport/UploadPackLogger", "", "Org.Eclipse.Jgit.Transport.IUploadPackLoggerInvoker")]
	public partial interface IUploadPackLogger : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='UploadPackLogger']/method[@name='onPackStatistics' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackWriter.Statistics']]"
		[Register ("onPackStatistics", "(Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;)V", "GetOnPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_Handler:Org.Eclipse.Jgit.Transport.IUploadPackLoggerInvoker, AndroidBindableLibrary")]
		void OnPackStatistics (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics stats);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPackLogger", DoNotGenerateAcw=true)]
	internal partial class IUploadPackLoggerInvoker : global::Java.Lang.Object, IUploadPackLogger {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPackLogger", typeof (IUploadPackLoggerInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IUploadPackLogger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUploadPackLogger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.UploadPackLogger'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUploadPackLoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_;
#pragma warning disable 0169
		static Delegate GetOnPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_Handler ()
		{
			if (cb_onPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_ == null)
				cb_onPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_);
			return cb_onPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_;
		}

		static void n_OnPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stats)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IUploadPackLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var stats = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (native_stats, JniHandleOwnership.DoNotTransfer);
			__this.OnPackStatistics (stats);
		}
#pragma warning restore 0169

		IntPtr id_onPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_;
		public unsafe void OnPackStatistics (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics stats)
		{
			if (id_onPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_ == IntPtr.Zero)
				id_onPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_ = JNIEnv.GetMethodID (class_ref, "onPackStatistics", "(Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((stats == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stats).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_, __args);
		}

	}
}
