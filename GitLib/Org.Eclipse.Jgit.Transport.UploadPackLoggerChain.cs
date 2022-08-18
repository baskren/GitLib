using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>
	///   <c>UploadPackLogger</c> that delegates to a list of other loggers.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPackLoggerChain']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPackLoggerChain", DoNotGenerateAcw=true)]
	public partial class UploadPackLoggerChain : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.IUploadPackLogger {
		public static class InterfaceConsts {
			// The following are fields from: org.eclipse.jgit.transport.UploadPackLogger


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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPackLoggerChain", typeof (UploadPackLoggerChain));

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

		protected UploadPackLoggerChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="loggers">loggers to execute, in order.</param>
		/// <summary>Create a new logger chaining the given loggers together.</summary>
		/// <returns>a new logger chain of the given loggers.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPackLoggerChain']/method[@name='newChain' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends org.eclipse.jgit.transport.UploadPackLogger&gt;']]"
		[Register ("newChain", "(Ljava/util/List;)Lorg/eclipse/jgit/transport/UploadPackLogger;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.IUploadPackLogger NewChain (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.IUploadPackLogger> loggers)
		{
			const string __id = "newChain.(Ljava/util/List;)Lorg/eclipse/jgit/transport/UploadPackLogger;";
			IntPtr native_loggers = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.IUploadPackLogger>.ToLocalJniHandle (loggers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_loggers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IUploadPackLogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_loggers);
				global::System.GC.KeepAlive (loggers);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPackLoggerChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var stats = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (native_stats, JniHandleOwnership.DoNotTransfer);
			__this.OnPackStatistics (stats);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPackLoggerChain']/method[@name='onPackStatistics' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackWriter.Statistics']]"
		[Register ("onPackStatistics", "(Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;)V", "GetOnPackStatistics_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_Statistics_Handler")]
		public virtual unsafe void OnPackStatistics (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics stats)
		{
			const string __id = "onPackStatistics.(Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stats == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stats).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (stats);
			}
		}

	}
}
