using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>PackWriter class is responsible for generating pack files from specified set
	/// of objects from repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/PackWriter", DoNotGenerateAcw=true)]
	public partial class PackWriter : global::Java.Lang.Object {
		/// <summary>A collection of object ids.</summary>
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/interface[@name='PackWriter.ObjectIdSet']"
		[Register ("org/eclipse/jgit/internal/storage/pack/PackWriter$ObjectIdSet", "", "Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter/IObjectIdSetInvoker")]
		public partial interface IObjectIdSet : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/interface[@name='PackWriter.ObjectIdSet']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
			/// <param name="objectId">the objectId to find</param>
			/// <summary>Returns true if the objectId is contained within the collection.</summary>
			/// <returns>whether the collection contains the objectId.</returns>
			[Register ("contains", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetContains_Lorg_eclipse_jgit_lib_AnyObjectId_Handler:Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter/IObjectIdSetInvoker, AndroidBindableLibrary")]
			bool Contains (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId);

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/PackWriter$ObjectIdSet", DoNotGenerateAcw=true)]
		internal partial class IObjectIdSetInvoker : global::Java.Lang.Object, IObjectIdSet {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/PackWriter$ObjectIdSet", typeof (IObjectIdSetInvoker));

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

			public static IObjectIdSet GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IObjectIdSet> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.internal.storage.pack.PackWriter.ObjectIdSet'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IObjectIdSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
			static Delegate GetContains_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
			{
				if (cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
					cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Lorg_eclipse_jgit_lib_AnyObjectId_);
				return cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
			}

			static bool n_Contains_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.IObjectIdSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Contains (objectId);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
			public unsafe bool Contains (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
			{
				if (id_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ == IntPtr.Zero)
					id_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lorg_eclipse_jgit_lib_AnyObjectId_, __args);
				return __ret;
			}

		}

		/// <summary>Possible states that a PackWriter can be in.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.PackingPhase']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase", DoNotGenerateAcw=true)]
		public sealed partial class PackingPhase : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.PackingPhase']/field[@name='BUILDING_BITMAPS']"
			[Register ("BUILDING_BITMAPS")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase BuildingBitmaps {
				get {
					const string __id = "BUILDING_BITMAPS.Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.PackingPhase']/field[@name='COMPRESSING']"
			[Register ("COMPRESSING")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase Compressing {
				get {
					const string __id = "COMPRESSING.Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.PackingPhase']/field[@name='COUNTING']"
			[Register ("COUNTING")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase Counting {
				get {
					const string __id = "COUNTING.Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.PackingPhase']/field[@name='FINDING_SOURCES']"
			[Register ("FINDING_SOURCES")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase FindingSources {
				get {
					const string __id = "FINDING_SOURCES.Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.PackingPhase']/field[@name='GETTING_SIZES']"
			[Register ("GETTING_SIZES")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase GettingSizes {
				get {
					const string __id = "GETTING_SIZES.Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.PackingPhase']/field[@name='WRITING']"
			[Register ("WRITING")]
			public static global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase Writing {
				get {
					const string __id = "WRITING.Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase", typeof (PackingPhase));

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

			internal PackingPhase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.PackingPhase']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.PackingPhase']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase));
				} finally {
				}
			}

		}

		/// <summary>Summary of the current state of a PackWriter.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.State']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/PackWriter$State", DoNotGenerateAcw=true)]
		public partial class State : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/PackWriter$State", typeof (State));

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

			protected State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate cb_getConfig;
#pragma warning disable 0169
			static Delegate GetGetConfigHandler ()
			{
				if (cb_getConfig == null)
					cb_getConfig = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConfig);
				return cb_getConfig;
			}

			static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.State> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Config);
			}
#pragma warning restore 0169

			/// <returns>the PackConfig used to build the writer.</returns>
			public virtual unsafe global::Org.Eclipse.Jgit.Storage.Pack.PackConfig Config {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.State']/method[@name='getConfig' and count(parameter)=0]"
				[Register ("getConfig", "()Lorg/eclipse/jgit/storage/pack/PackConfig;", "GetGetConfigHandler")]
				get {
					const string __id = "getConfig.()Lorg/eclipse/jgit/storage/pack/PackConfig;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getPhase;
#pragma warning disable 0169
			static Delegate GetGetPhaseHandler ()
			{
				if (cb_getPhase == null)
					cb_getPhase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPhase);
				return cb_getPhase;
			}

			static IntPtr n_GetPhase (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.State> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Phase);
			}
#pragma warning restore 0169

			public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase Phase {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.State']/method[@name='getPhase' and count(parameter)=0]"
				[Register ("getPhase", "()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;", "GetGetPhaseHandler")]
				get {
					const string __id = "getPhase.()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$PackingPhase;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.PackingPhase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_estimateBytesUsed;
#pragma warning disable 0169
			static Delegate GetEstimateBytesUsedHandler ()
			{
				if (cb_estimateBytesUsed == null)
					cb_estimateBytesUsed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_EstimateBytesUsed);
				return cb_estimateBytesUsed;
			}

			static long n_EstimateBytesUsed (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.State> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.EstimateBytesUsed ();
			}
#pragma warning restore 0169

			/// <returns>an estimate of the total memory used by the writer.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.State']/method[@name='estimateBytesUsed' and count(parameter)=0]"
			[Register ("estimateBytesUsed", "()J", "GetEstimateBytesUsedHandler")]
			public virtual unsafe long EstimateBytesUsed ()
			{
				const string __id = "estimateBytesUsed.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		/// <summary>Summary of how PackWriter created the pack.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/PackWriter$Statistics", DoNotGenerateAcw=true)]
		public partial class Statistics : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics.ObjectType']"
			[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/PackWriter$Statistics$ObjectType", DoNotGenerateAcw=true)]
			public partial class ObjectType : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/PackWriter$Statistics$ObjectType", typeof (ObjectType));

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

				protected ObjectType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
				{
				}

				// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics.ObjectType']/constructor[@name='PackWriter.Statistics.ObjectType' and count(parameter)=0]"
				[Register (".ctor", "()V", "")]
				public unsafe ObjectType () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

				static Delegate cb_getBytes;
#pragma warning disable 0169
				static Delegate GetGetBytesHandler ()
				{
					if (cb_getBytes == null)
						cb_getBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetBytes);
					return cb_getBytes;
				}

				static long n_GetBytes (IntPtr jnienv, IntPtr native__this)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics.ObjectType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.Bytes;
				}
#pragma warning restore 0169

				public virtual unsafe long Bytes {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics.ObjectType']/method[@name='getBytes' and count(parameter)=0]"
					[Register ("getBytes", "()J", "GetGetBytesHandler")]
					get {
						const string __id = "getBytes.()J";
						try {
							var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
							return __rm;
						} finally {
						}
					}
				}

				static Delegate cb_getDeltaBytes;
#pragma warning disable 0169
				static Delegate GetGetDeltaBytesHandler ()
				{
					if (cb_getDeltaBytes == null)
						cb_getDeltaBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDeltaBytes);
					return cb_getDeltaBytes;
				}

				static long n_GetDeltaBytes (IntPtr jnienv, IntPtr native__this)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics.ObjectType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.DeltaBytes;
				}
#pragma warning restore 0169

				public virtual unsafe long DeltaBytes {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics.ObjectType']/method[@name='getDeltaBytes' and count(parameter)=0]"
					[Register ("getDeltaBytes", "()J", "GetGetDeltaBytesHandler")]
					get {
						const string __id = "getDeltaBytes.()J";
						try {
							var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
							return __rm;
						} finally {
						}
					}
				}

				static Delegate cb_getDeltas;
#pragma warning disable 0169
				static Delegate GetGetDeltasHandler ()
				{
					if (cb_getDeltas == null)
						cb_getDeltas = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDeltas);
					return cb_getDeltas;
				}

				static long n_GetDeltas (IntPtr jnienv, IntPtr native__this)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics.ObjectType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.Deltas;
				}
#pragma warning restore 0169

				public virtual unsafe long Deltas {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics.ObjectType']/method[@name='getDeltas' and count(parameter)=0]"
					[Register ("getDeltas", "()J", "GetGetDeltasHandler")]
					get {
						const string __id = "getDeltas.()J";
						try {
							var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
							return __rm;
						} finally {
						}
					}
				}

				static Delegate cb_getObjects;
#pragma warning disable 0169
				static Delegate GetGetObjectsHandler ()
				{
					if (cb_getObjects == null)
						cb_getObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetObjects);
					return cb_getObjects;
				}

				static long n_GetObjects (IntPtr jnienv, IntPtr native__this)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics.ObjectType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.Objects;
				}
#pragma warning restore 0169

				public virtual unsafe long Objects {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics.ObjectType']/method[@name='getObjects' and count(parameter)=0]"
					[Register ("getObjects", "()J", "GetGetObjectsHandler")]
					get {
						const string __id = "getObjects.()J";
						try {
							var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
							return __rm;
						} finally {
						}
					}
				}

				static Delegate cb_getReusedDeltas;
#pragma warning disable 0169
				static Delegate GetGetReusedDeltasHandler ()
				{
					if (cb_getReusedDeltas == null)
						cb_getReusedDeltas = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetReusedDeltas);
					return cb_getReusedDeltas;
				}

				static long n_GetReusedDeltas (IntPtr jnienv, IntPtr native__this)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics.ObjectType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.ReusedDeltas;
				}
#pragma warning restore 0169

				public virtual unsafe long ReusedDeltas {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics.ObjectType']/method[@name='getReusedDeltas' and count(parameter)=0]"
					[Register ("getReusedDeltas", "()J", "GetGetReusedDeltasHandler")]
					get {
						const string __id = "getReusedDeltas.()J";
						try {
							var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
							return __rm;
						} finally {
						}
					}
				}

				static Delegate cb_getReusedObjects;
#pragma warning disable 0169
				static Delegate GetGetReusedObjectsHandler ()
				{
					if (cb_getReusedObjects == null)
						cb_getReusedObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetReusedObjects);
					return cb_getReusedObjects;
				}

				static long n_GetReusedObjects (IntPtr jnienv, IntPtr native__this)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics.ObjectType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.ReusedObjects;
				}
#pragma warning restore 0169

				public virtual unsafe long ReusedObjects {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics.ObjectType']/method[@name='getReusedObjects' and count(parameter)=0]"
					[Register ("getReusedObjects", "()J", "GetGetReusedObjectsHandler")]
					get {
						const string __id = "getReusedObjects.()J";
						try {
							var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
							return __rm;
						} finally {
						}
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/PackWriter$Statistics", typeof (Statistics));

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

			protected Statistics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/constructor[@name='PackWriter.Statistics' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Statistics () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_getDeltaSearchNonEdgeObjects;
#pragma warning disable 0169
			static Delegate GetGetDeltaSearchNonEdgeObjectsHandler ()
			{
				if (cb_getDeltaSearchNonEdgeObjects == null)
					cb_getDeltaSearchNonEdgeObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDeltaSearchNonEdgeObjects);
				return cb_getDeltaSearchNonEdgeObjects;
			}

			static int n_GetDeltaSearchNonEdgeObjects (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DeltaSearchNonEdgeObjects;
			}
#pragma warning restore 0169

			/// <returns>number of objects in the output pack that went through the
			///         delta search process in order to find a potential delta base.</returns>
			public virtual unsafe int DeltaSearchNonEdgeObjects {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getDeltaSearchNonEdgeObjects' and count(parameter)=0]"
				[Register ("getDeltaSearchNonEdgeObjects", "()I", "GetGetDeltaSearchNonEdgeObjectsHandler")]
				get {
					const string __id = "getDeltaSearchNonEdgeObjects.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getDeltasFound;
#pragma warning disable 0169
			static Delegate GetGetDeltasFoundHandler ()
			{
				if (cb_getDeltasFound == null)
					cb_getDeltasFound = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDeltasFound);
				return cb_getDeltasFound;
			}

			static int n_GetDeltasFound (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DeltasFound;
			}
#pragma warning restore 0169

			/// <returns>number of objects in the output pack that went through delta
			///         base search and found a suitable base. This is a subset of
			///         <c>#getDeltaSearchNonEdgeObjects()</c>.</returns>
			public virtual unsafe int DeltasFound {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getDeltasFound' and count(parameter)=0]"
				[Register ("getDeltasFound", "()I", "GetGetDeltasFoundHandler")]
				get {
					const string __id = "getDeltasFound.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getDepth;
#pragma warning disable 0169
			static Delegate GetGetDepthHandler ()
			{
				if (cb_getDepth == null)
					cb_getDepth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDepth);
				return cb_getDepth;
			}

			static int n_GetDepth (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Depth;
			}
#pragma warning restore 0169

			/// <returns>depth (in commits) the pack includes if shallow.</returns>
			public virtual unsafe int Depth {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getDepth' and count(parameter)=0]"
				[Register ("getDepth", "()I", "GetGetDepthHandler")]
				get {
					const string __id = "getDepth.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getInterestingObjects;
#pragma warning disable 0169
			static Delegate GetGetInterestingObjectsHandler ()
			{
				if (cb_getInterestingObjects == null)
					cb_getInterestingObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInterestingObjects);
				return cb_getInterestingObjects;
			}

			static IntPtr n_GetInterestingObjects (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.InterestingObjects);
			}
#pragma warning restore 0169

			/// <returns>unmodifiable collection of objects to be included in the
			///         pack. May be null if the pack was hand-crafted in a unit
			///         test.</returns>
			public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> InterestingObjects {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getInterestingObjects' and count(parameter)=0]"
				[Register ("getInterestingObjects", "()Ljava/util/Set;", "GetGetInterestingObjectsHandler")]
				get {
					const string __id = "getInterestingObjects.()Ljava/util/Set;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isShallow;
#pragma warning disable 0169
			static Delegate GetIsShallowHandler ()
			{
				if (cb_isShallow == null)
					cb_isShallow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsShallow);
				return cb_isShallow;
			}

			static bool n_IsShallow (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsShallow;
			}
#pragma warning restore 0169

			/// <returns>true if the resulting pack file was a shallow pack.</returns>
			public virtual unsafe bool IsShallow {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='isShallow' and count(parameter)=0]"
				[Register ("isShallow", "()Z", "GetIsShallowHandler")]
				get {
					const string __id = "isShallow.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getMessage;
#pragma warning disable 0169
			static Delegate GetGetMessageHandler ()
			{
				if (cb_getMessage == null)
					cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
				return cb_getMessage;
			}

			static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Message);
			}
#pragma warning restore 0169

			/// <returns>formatted message string for display to clients.</returns>
			public virtual unsafe string Message {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getMessage' and count(parameter)=0]"
				[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
				get {
					const string __id = "getMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getReusedDeltas;
#pragma warning disable 0169
			static Delegate GetGetReusedDeltasHandler ()
			{
				if (cb_getReusedDeltas == null)
					cb_getReusedDeltas = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetReusedDeltas);
				return cb_getReusedDeltas;
			}

			static long n_GetReusedDeltas (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ReusedDeltas;
			}
#pragma warning restore 0169

			/// <returns>number of deltas whose existing representation was reused in
			///         the output, as their base object was also output or was
			///         assumed present for a thin pack. This may be lower than the
			///         actual number of reused deltas if a cached pack was reused.</returns>
			public virtual unsafe long ReusedDeltas {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getReusedDeltas' and count(parameter)=0]"
				[Register ("getReusedDeltas", "()J", "GetGetReusedDeltasHandler")]
				get {
					const string __id = "getReusedDeltas.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getReusedObjects;
#pragma warning disable 0169
			static Delegate GetGetReusedObjectsHandler ()
			{
				if (cb_getReusedObjects == null)
					cb_getReusedObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetReusedObjects);
				return cb_getReusedObjects;
			}

			static long n_GetReusedObjects (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ReusedObjects;
			}
#pragma warning restore 0169

			/// <returns>number of objects whose existing representation was reused in
			///         the output. This count includes <c>#getReusedDeltas()</c>.</returns>
			public virtual unsafe long ReusedObjects {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getReusedObjects' and count(parameter)=0]"
				[Register ("getReusedObjects", "()J", "GetGetReusedObjectsHandler")]
				get {
					const string __id = "getReusedObjects.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getReusedPacks;
#pragma warning disable 0169
			static Delegate GetGetReusedPacksHandler ()
			{
				if (cb_getReusedPacks == null)
					cb_getReusedPacks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReusedPacks);
				return cb_getReusedPacks;
			}

			static IntPtr n_GetReusedPacks (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack>.ToLocalJniHandle (__this.ReusedPacks);
			}
#pragma warning restore 0169

			/// <returns>unmodifiable collection of the cached packs that were reused
			///         in the output, if any were selected for reuse.</returns>
			public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack> ReusedPacks {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getReusedPacks' and count(parameter)=0]"
				[Register ("getReusedPacks", "()Ljava/util/Collection;", "GetGetReusedPacksHandler")]
				get {
					const string __id = "getReusedPacks.()Ljava/util/Collection;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getThinPackBytes;
#pragma warning disable 0169
			static Delegate GetGetThinPackBytesHandler ()
			{
				if (cb_getThinPackBytes == null)
					cb_getThinPackBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetThinPackBytes);
				return cb_getThinPackBytes;
			}

			static long n_GetThinPackBytes (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ThinPackBytes;
			}
#pragma warning restore 0169

			/// <returns>size of the thin pack in bytes, if a thin pack was generated.
			///         A thin pack is created when the client already has objects
			///         and some deltas are created against those objects, or if a
			///         cached pack is being used and some deltas will reference
			///         objects in the cached pack. This size does not include the
			///         pack header or trailer.</returns>
			public virtual unsafe long ThinPackBytes {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getThinPackBytes' and count(parameter)=0]"
				[Register ("getThinPackBytes", "()J", "GetGetThinPackBytesHandler")]
				get {
					const string __id = "getThinPackBytes.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTimeCompressing;
#pragma warning disable 0169
			static Delegate GetGetTimeCompressingHandler ()
			{
				if (cb_getTimeCompressing == null)
					cb_getTimeCompressing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTimeCompressing);
				return cb_getTimeCompressing;
			}

			static long n_GetTimeCompressing (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TimeCompressing;
			}
#pragma warning restore 0169

			/// <returns>time in milliseconds spent on delta compression. This is
			///         observed wall-clock time and does not accurately track CPU
			///         time used when multiple threads were used to perform the
			///         delta compression.</returns>
			public virtual unsafe long TimeCompressing {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTimeCompressing' and count(parameter)=0]"
				[Register ("getTimeCompressing", "()J", "GetGetTimeCompressingHandler")]
				get {
					const string __id = "getTimeCompressing.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTimeCounting;
#pragma warning disable 0169
			static Delegate GetGetTimeCountingHandler ()
			{
				if (cb_getTimeCounting == null)
					cb_getTimeCounting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTimeCounting);
				return cb_getTimeCounting;
			}

			static long n_GetTimeCounting (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TimeCounting;
			}
#pragma warning restore 0169

			/// <returns>time in milliseconds spent enumerating the objects that need
			///         to be included in the output. This time includes any restarts
			///         that occur when a cached pack is selected for reuse.</returns>
			public virtual unsafe long TimeCounting {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTimeCounting' and count(parameter)=0]"
				[Register ("getTimeCounting", "()J", "GetGetTimeCountingHandler")]
				get {
					const string __id = "getTimeCounting.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTimeSearchingForReuse;
#pragma warning disable 0169
			static Delegate GetGetTimeSearchingForReuseHandler ()
			{
				if (cb_getTimeSearchingForReuse == null)
					cb_getTimeSearchingForReuse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTimeSearchingForReuse);
				return cb_getTimeSearchingForReuse;
			}

			static long n_GetTimeSearchingForReuse (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TimeSearchingForReuse;
			}
#pragma warning restore 0169

			/// <returns>time in milliseconds spent matching existing representations
			///         against objects that will be transmitted, or that the client
			///         can be assumed to already have.</returns>
			public virtual unsafe long TimeSearchingForReuse {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTimeSearchingForReuse' and count(parameter)=0]"
				[Register ("getTimeSearchingForReuse", "()J", "GetGetTimeSearchingForReuseHandler")]
				get {
					const string __id = "getTimeSearchingForReuse.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTimeSearchingForSizes;
#pragma warning disable 0169
			static Delegate GetGetTimeSearchingForSizesHandler ()
			{
				if (cb_getTimeSearchingForSizes == null)
					cb_getTimeSearchingForSizes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTimeSearchingForSizes);
				return cb_getTimeSearchingForSizes;
			}

			static long n_GetTimeSearchingForSizes (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TimeSearchingForSizes;
			}
#pragma warning restore 0169

			/// <returns>time in milliseconds spent finding the sizes of all objects
			///         that will enter the delta compression search window. The
			///         sizes need to be known to better match similar objects
			///         together and improve delta compression ratios.</returns>
			public virtual unsafe long TimeSearchingForSizes {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTimeSearchingForSizes' and count(parameter)=0]"
				[Register ("getTimeSearchingForSizes", "()J", "GetGetTimeSearchingForSizesHandler")]
				get {
					const string __id = "getTimeSearchingForSizes.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTimeTotal;
#pragma warning disable 0169
			static Delegate GetGetTimeTotalHandler ()
			{
				if (cb_getTimeTotal == null)
					cb_getTimeTotal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTimeTotal);
				return cb_getTimeTotal;
			}

			static long n_GetTimeTotal (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TimeTotal;
			}
#pragma warning restore 0169

			/// <returns>total time spent processing this pack.</returns>
			public virtual unsafe long TimeTotal {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTimeTotal' and count(parameter)=0]"
				[Register ("getTimeTotal", "()J", "GetGetTimeTotalHandler")]
				get {
					const string __id = "getTimeTotal.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTimeWriting;
#pragma warning disable 0169
			static Delegate GetGetTimeWritingHandler ()
			{
				if (cb_getTimeWriting == null)
					cb_getTimeWriting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTimeWriting);
				return cb_getTimeWriting;
			}

			static long n_GetTimeWriting (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TimeWriting;
			}
#pragma warning restore 0169

			/// <returns>time in milliseconds spent writing the pack output, from
			///         start of header until end of trailer. The transfer speed can
			///         be approximated by dividing <c>#getTotalBytes()</c> by this
			///         value.</returns>
			public virtual unsafe long TimeWriting {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTimeWriting' and count(parameter)=0]"
				[Register ("getTimeWriting", "()J", "GetGetTimeWritingHandler")]
				get {
					const string __id = "getTimeWriting.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTotalBytes;
#pragma warning disable 0169
			static Delegate GetGetTotalBytesHandler ()
			{
				if (cb_getTotalBytes == null)
					cb_getTotalBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTotalBytes);
				return cb_getTotalBytes;
			}

			static long n_GetTotalBytes (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TotalBytes;
			}
#pragma warning restore 0169

			/// <returns>total number of bytes written. This size includes the pack
			///         header, trailer, thin pack, and reused cached pack(s).</returns>
			public virtual unsafe long TotalBytes {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTotalBytes' and count(parameter)=0]"
				[Register ("getTotalBytes", "()J", "GetGetTotalBytesHandler")]
				get {
					const string __id = "getTotalBytes.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTotalDeltas;
#pragma warning disable 0169
			static Delegate GetGetTotalDeltasHandler ()
			{
				if (cb_getTotalDeltas == null)
					cb_getTotalDeltas = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTotalDeltas);
				return cb_getTotalDeltas;
			}

			static long n_GetTotalDeltas (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TotalDeltas;
			}
#pragma warning restore 0169

			/// <returns>total number of deltas output. This may be lower than the
			///         actual number of deltas if a cached pack was reused.</returns>
			public virtual unsafe long TotalDeltas {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTotalDeltas' and count(parameter)=0]"
				[Register ("getTotalDeltas", "()J", "GetGetTotalDeltasHandler")]
				get {
					const string __id = "getTotalDeltas.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTotalObjects;
#pragma warning disable 0169
			static Delegate GetGetTotalObjectsHandler ()
			{
				if (cb_getTotalObjects == null)
					cb_getTotalObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTotalObjects);
				return cb_getTotalObjects;
			}

			static long n_GetTotalObjects (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TotalObjects;
			}
#pragma warning restore 0169

			/// <returns>total number of objects output. This total includes the value
			///         of <c>#getTotalDeltas()</c>.</returns>
			public virtual unsafe long TotalObjects {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTotalObjects' and count(parameter)=0]"
				[Register ("getTotalObjects", "()J", "GetGetTotalObjectsHandler")]
				get {
					const string __id = "getTotalObjects.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTransferRate;
#pragma warning disable 0169
			static Delegate GetGetTransferRateHandler ()
			{
				if (cb_getTransferRate == null)
					cb_getTransferRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetTransferRate);
				return cb_getTransferRate;
			}

			static double n_GetTransferRate (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TransferRate;
			}
#pragma warning restore 0169

			/// <returns>get the average output speed in terms of bytes-per-second.
			///         <c>getTotalBytes() / (getTimeWriting() / 1000.0)</c>.</returns>
			public virtual unsafe double TransferRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getTransferRate' and count(parameter)=0]"
				[Register ("getTransferRate", "()D", "GetGetTransferRateHandler")]
				get {
					const string __id = "getTransferRate.()D";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getUninterestingObjects;
#pragma warning disable 0169
			static Delegate GetGetUninterestingObjectsHandler ()
			{
				if (cb_getUninterestingObjects == null)
					cb_getUninterestingObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUninterestingObjects);
				return cb_getUninterestingObjects;
			}

			static IntPtr n_GetUninterestingObjects (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.UninterestingObjects);
			}
#pragma warning restore 0169

			/// <returns>unmodifiable collection of objects that should be excluded
			///         from the pack, as the peer that will receive the pack already
			///         has these objects.</returns>
			public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> UninterestingObjects {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='getUninterestingObjects' and count(parameter)=0]"
				[Register ("getUninterestingObjects", "()Ljava/util/Set;", "GetGetUninterestingObjectsHandler")]
				get {
					const string __id = "getUninterestingObjects.()Ljava/util/Set;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_byObjectType_I;
#pragma warning disable 0169
			static Delegate GetByObjectType_IHandler ()
			{
				if (cb_byObjectType_I == null)
					cb_byObjectType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_ByObjectType_I);
				return cb_byObjectType_I;
			}

			static IntPtr n_ByObjectType_I (IntPtr jnienv, IntPtr native__this, int typeCode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ByObjectType (typeCode));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter.Statistics']/method[@name='byObjectType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("byObjectType", "(I)Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics$ObjectType;", "GetByObjectType_IHandler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics.ObjectType ByObjectType (int typeCode)
			{
				const string __id = "byObjectType.(I)Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics$ObjectType;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (typeCode);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics.ObjectType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/PackWriter", typeof (PackWriter));

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

		protected PackWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="reader">reader to read from the repository with.</param>
		/// <summary>Create a writer to load objects from the specified reader.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/constructor[@name='PackWriter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectReader;)V", "")]
		public unsafe PackWriter (global::Org.Eclipse.Jgit.Lib.ObjectReader reader) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectReader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		/// <param name="repo">repository where objects are stored.</param>
		/// <summary>Create writer for specified repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/constructor[@name='PackWriter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe PackWriter (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		/// <param name="repo">repository where objects are stored.</param>
		/// <param name="reader">reader to read from the repository with.</param>
		/// <summary>Create writer for specified repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/constructor[@name='PackWriter' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectReader;)V", "")]
		public unsafe PackWriter (global::Org.Eclipse.Jgit.Lib.Repository repo, global::Org.Eclipse.Jgit.Lib.ObjectReader reader) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectReader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
				global::System.GC.KeepAlive (reader);
			}
		}

		/// <param name="config">configuration for the pack writer.</param>
		/// <param name="reader">reader to read from the repository with.</param>
		/// <summary>Create writer with a specified configuration.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/constructor[@name='PackWriter' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.storage.pack.PackConfig'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/storage/pack/PackConfig;Lorg/eclipse/jgit/lib/ObjectReader;)V", "")]
		public unsafe PackWriter (global::Org.Eclipse.Jgit.Storage.Pack.PackConfig config, global::Org.Eclipse.Jgit.Lib.ObjectReader reader) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/storage/pack/PackConfig;Lorg/eclipse/jgit/lib/ObjectReader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [1] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (reader);
			}
		}

		static Delegate cb_isDeltaBaseAsOffset;
#pragma warning disable 0169
		static Delegate GetIsDeltaBaseAsOffsetHandler ()
		{
			if (cb_isDeltaBaseAsOffset == null)
				cb_isDeltaBaseAsOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDeltaBaseAsOffset);
			return cb_isDeltaBaseAsOffset;
		}

		static bool n_IsDeltaBaseAsOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaBaseAsOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setDeltaBaseAsOffset_Z;
#pragma warning disable 0169
		static Delegate GetSetDeltaBaseAsOffset_ZHandler ()
		{
			if (cb_setDeltaBaseAsOffset_Z == null)
				cb_setDeltaBaseAsOffset_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDeltaBaseAsOffset_Z);
			return cb_setDeltaBaseAsOffset_Z;
		}

		static void n_SetDeltaBaseAsOffset_Z (IntPtr jnienv, IntPtr native__this, bool deltaBaseAsOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeltaBaseAsOffset = deltaBaseAsOffset;
		}
#pragma warning restore 0169

		/// <summary>Check whether writer can store delta base as an offset (new style
		/// reducing pack size) or should store it as an object id (legacy style,
		/// compatible with old readers). -or- Set writer delta base format.</summary>
		/// <returns>true if delta base is stored as an offset; false if it is stored
		///         as an object id.</returns>
		/// <param name="deltaBaseAsOffset">boolean indicating whether delta base can be stored as an
		///            offset.</param>
		public virtual unsafe bool DeltaBaseAsOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='isDeltaBaseAsOffset' and count(parameter)=0]"
			[Register ("isDeltaBaseAsOffset", "()Z", "GetIsDeltaBaseAsOffsetHandler")]
			get {
				const string __id = "isDeltaBaseAsOffset.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setDeltaBaseAsOffset' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDeltaBaseAsOffset", "(Z)V", "GetSetDeltaBaseAsOffset_ZHandler")]
			set {
				const string __id = "setDeltaBaseAsOffset.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isIgnoreMissingUninteresting;
#pragma warning disable 0169
		static Delegate GetIsIgnoreMissingUninterestingHandler ()
		{
			if (cb_isIgnoreMissingUninteresting == null)
				cb_isIgnoreMissingUninteresting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIgnoreMissingUninteresting);
			return cb_isIgnoreMissingUninteresting;
		}

		static bool n_IsIgnoreMissingUninteresting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IgnoreMissingUninteresting;
		}
#pragma warning restore 0169

		static Delegate cb_setIgnoreMissingUninteresting_Z;
#pragma warning disable 0169
		static Delegate GetSetIgnoreMissingUninteresting_ZHandler ()
		{
			if (cb_setIgnoreMissingUninteresting_Z == null)
				cb_setIgnoreMissingUninteresting_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetIgnoreMissingUninteresting_Z);
			return cb_setIgnoreMissingUninteresting_Z;
		}

		static void n_SetIgnoreMissingUninteresting_Z (IntPtr jnienv, IntPtr native__this, bool ignore)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IgnoreMissingUninteresting = ignore;
		}
#pragma warning restore 0169

		/// <returns>true to ignore objects that are uninteresting and also not found
		///         on local disk; false to throw a <c>MissingObjectException</c>
		///         out of <c>#preparePack(ProgressMonitor, Collection, Collection)</c> if an
		///         uninteresting object is not in the source repository. By default,
		///         true, permitting gracefully ignoring of uninteresting objects.</returns>
		/// <param name="ignore">true if writer should ignore non existing uninteresting
		///            objects during construction set of objects to pack; false
		///            otherwise - non existing uninteresting objects may cause
		///            <c>MissingObjectException</c></param>
		public virtual unsafe bool IgnoreMissingUninteresting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='isIgnoreMissingUninteresting' and count(parameter)=0]"
			[Register ("isIgnoreMissingUninteresting", "()Z", "GetIsIgnoreMissingUninterestingHandler")]
			get {
				const string __id = "isIgnoreMissingUninteresting.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setIgnoreMissingUninteresting' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIgnoreMissingUninteresting", "(Z)V", "GetSetIgnoreMissingUninteresting_ZHandler")]
			set {
				const string __id = "setIgnoreMissingUninteresting.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isIndexDisabled;
#pragma warning disable 0169
		static Delegate GetIsIndexDisabledHandler ()
		{
			if (cb_isIndexDisabled == null)
				cb_isIndexDisabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIndexDisabled);
			return cb_isIndexDisabled;
		}

		static bool n_IsIndexDisabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexDisabled;
		}
#pragma warning restore 0169

		static Delegate cb_setIndexDisabled_Z;
#pragma warning disable 0169
		static Delegate GetSetIndexDisabled_ZHandler ()
		{
			if (cb_setIndexDisabled_Z == null)
				cb_setIndexDisabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetIndexDisabled_Z);
			return cb_setIndexDisabled_Z;
		}

		static void n_SetIndexDisabled_Z (IntPtr jnienv, IntPtr native__this, bool noIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndexDisabled = noIndex;
		}
#pragma warning restore 0169

		/// <returns>true if the index file cannot be created by this PackWriter.</returns>
		/// <param name="noIndex">true to disable creation of the index file.</param>
		public virtual unsafe bool IndexDisabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='isIndexDisabled' and count(parameter)=0]"
			[Register ("isIndexDisabled", "()Z", "GetIsIndexDisabledHandler")]
			get {
				const string __id = "isIndexDisabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setIndexDisabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIndexDisabled", "(Z)V", "GetSetIndexDisabled_ZHandler")]
			set {
				const string __id = "setIndexDisabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndexVersion;
#pragma warning disable 0169
		static Delegate GetGetIndexVersionHandler ()
		{
			if (cb_getIndexVersion == null)
				cb_getIndexVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIndexVersion);
			return cb_getIndexVersion;
		}

		static int n_GetIndexVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexVersion;
		}
#pragma warning restore 0169

		/// <summary>Returns the index format version that will be written.</summary>
		/// <returns>the index format version.</returns>
		public virtual unsafe int IndexVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='getIndexVersion' and count(parameter)=0]"
			[Register ("getIndexVersion", "()I", "GetGetIndexVersionHandler")]
			get {
				const string __id = "getIndexVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>all allocated, non-released PackWriters instances.</returns>
		public static unsafe global::Java.Lang.IIterable Instances {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='getInstances' and count(parameter)=0]"
			[Register ("getInstances", "()Ljava/lang/Iterable;", "")]
			get {
				const string __id = "getInstances.()Ljava/lang/Iterable;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectCount;
		}
#pragma warning restore 0169

		/// <summary>Returns objects number in a pack file that was created by this writer.</summary>
		/// <returns>number of objects in pack.</returns>
		public virtual unsafe long ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='getObjectCount' and count(parameter)=0]"
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

		static Delegate cb_getObjectSet;
#pragma warning disable 0169
		static Delegate GetGetObjectSetHandler ()
		{
			if (cb_getObjectSet == null)
				cb_getObjectSet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectSet);
			return cb_getObjectSet;
		}

		static IntPtr n_GetObjectSet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectSet);
		}
#pragma warning restore 0169

		/// <summary>Returns the object ids in the pack file that was created by this writer.</summary>
		/// <returns>number of objects in pack.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap ObjectSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='getObjectSet' and count(parameter)=0]"
			[Register ("getObjectSet", "()Lorg/eclipse/jgit/lib/ObjectIdOwnerMap;", "GetGetObjectSetHandler")]
			get {
				const string __id = "getObjectSet.()Lorg/eclipse/jgit/lib/ObjectIdOwnerMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isReuseDeltaCommits;
#pragma warning disable 0169
		static Delegate GetIsReuseDeltaCommitsHandler ()
		{
			if (cb_isReuseDeltaCommits == null)
				cb_isReuseDeltaCommits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsReuseDeltaCommits);
			return cb_isReuseDeltaCommits;
		}

		static bool n_IsReuseDeltaCommits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReuseDeltaCommits;
		}
#pragma warning restore 0169

		static Delegate cb_setReuseDeltaCommits_Z;
#pragma warning disable 0169
		static Delegate GetSetReuseDeltaCommits_ZHandler ()
		{
			if (cb_setReuseDeltaCommits_Z == null)
				cb_setReuseDeltaCommits_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetReuseDeltaCommits_Z);
			return cb_setReuseDeltaCommits_Z;
		}

		static void n_SetReuseDeltaCommits_Z (IntPtr jnienv, IntPtr native__this, bool reuse)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReuseDeltaCommits = reuse;
		}
#pragma warning restore 0169

		/// <summary>Check if the writer will reuse commits that are already stored as deltas. -or- Set the writer to reuse existing delta versions of commits.</summary>
		/// <returns>true if the writer would reuse commits stored as deltas, assuming
		///         delta reuse is already enabled.</returns>
		/// <param name="reuse">if true, the writer will reuse any commits stored as deltas.
		///            By default the writer does not reuse delta commits.</param>
		public virtual unsafe bool ReuseDeltaCommits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='isReuseDeltaCommits' and count(parameter)=0]"
			[Register ("isReuseDeltaCommits", "()Z", "GetIsReuseDeltaCommitsHandler")]
			get {
				const string __id = "isReuseDeltaCommits.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setReuseDeltaCommits' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReuseDeltaCommits", "(Z)V", "GetSetReuseDeltaCommits_ZHandler")]
			set {
				const string __id = "setReuseDeltaCommits.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isReuseValidatingObjects;
#pragma warning disable 0169
		static Delegate GetIsReuseValidatingObjectsHandler ()
		{
			if (cb_isReuseValidatingObjects == null)
				cb_isReuseValidatingObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsReuseValidatingObjects);
			return cb_isReuseValidatingObjects;
		}

		static bool n_IsReuseValidatingObjects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReuseValidatingObjects;
		}
#pragma warning restore 0169

		static Delegate cb_setReuseValidatingObjects_Z;
#pragma warning disable 0169
		static Delegate GetSetReuseValidatingObjects_ZHandler ()
		{
			if (cb_setReuseValidatingObjects_Z == null)
				cb_setReuseValidatingObjects_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetReuseValidatingObjects_Z);
			return cb_setReuseValidatingObjects_Z;
		}

		static void n_SetReuseValidatingObjects_Z (IntPtr jnienv, IntPtr native__this, bool validate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReuseValidatingObjects = validate;
		}
#pragma warning restore 0169

		/// <summary>Check if the writer validates objects before copying them. -or- Enable (or disable) object validation during packing.</summary>
		/// <returns>true if validation is enabled; false if the reader will handle
		///         object validation as a side-effect of it consuming the output.</returns>
		/// <param name="validate">if true the pack writer will validate an object before it is
		///            put into the output. This additional validation work may be
		///            necessary to avoid propagating corruption from one local pack
		///            file to another local pack file.</param>
		public virtual unsafe bool ReuseValidatingObjects {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='isReuseValidatingObjects' and count(parameter)=0]"
			[Register ("isReuseValidatingObjects", "()Z", "GetIsReuseValidatingObjectsHandler")]
			get {
				const string __id = "isReuseValidatingObjects.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setReuseValidatingObjects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReuseValidatingObjects", "(Z)V", "GetSetReuseValidatingObjects_ZHandler")]
			set {
				const string __id = "setReuseValidatingObjects.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isThin;
#pragma warning disable 0169
		static Delegate GetIsThinHandler ()
		{
			if (cb_isThin == null)
				cb_isThin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsThin);
			return cb_isThin;
		}

		static bool n_IsThin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Thin;
		}
#pragma warning restore 0169

		static Delegate cb_setThin_Z;
#pragma warning disable 0169
		static Delegate GetSetThin_ZHandler ()
		{
			if (cb_setThin_Z == null)
				cb_setThin_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetThin_Z);
			return cb_setThin_Z;
		}

		static void n_SetThin_Z (IntPtr jnienv, IntPtr native__this, bool packthin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Thin = packthin;
		}
#pragma warning restore 0169

		/// <returns>true if this writer is producing a thin pack.</returns>
		/// <param name="packthin">a boolean indicating whether writer may pack objects with
		///            delta base object not within set of objects to pack, but
		///            belonging to party repository (uninteresting/boundary) as
		///            determined by set; this kind of pack is used only for
		///            transport; true - to produce thin pack, false - otherwise.</param>
		public virtual unsafe bool Thin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='isThin' and count(parameter)=0]"
			[Register ("isThin", "()Z", "GetIsThinHandler")]
			get {
				const string __id = "isThin.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setThin' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setThin", "(Z)V", "GetSetThin_ZHandler")]
			set {
				const string __id = "setThin.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseBitmaps;
#pragma warning disable 0169
		static Delegate GetIsUseBitmapsHandler ()
		{
			if (cb_isUseBitmaps == null)
				cb_isUseBitmaps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseBitmaps);
			return cb_isUseBitmaps;
		}

		static bool n_IsUseBitmaps (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseBitmaps;
		}
#pragma warning restore 0169

		static Delegate cb_setUseBitmaps_Z;
#pragma warning disable 0169
		static Delegate GetSetUseBitmaps_ZHandler ()
		{
			if (cb_setUseBitmaps_Z == null)
				cb_setUseBitmaps_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseBitmaps_Z);
			return cb_setUseBitmaps_Z;
		}

		static void n_SetUseBitmaps_Z (IntPtr jnienv, IntPtr native__this, bool useBitmaps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseBitmaps = useBitmaps;
		}
#pragma warning restore 0169

		/// <returns>true to use bitmaps for ObjectWalks, if available.</returns>
		/// <param name="useBitmaps">if set to true, bitmaps will be used when preparing a pack.</param>
		public virtual unsafe bool UseBitmaps {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='isUseBitmaps' and count(parameter)=0]"
			[Register ("isUseBitmaps", "()Z", "GetIsUseBitmapsHandler")]
			get {
				const string __id = "isUseBitmaps.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setUseBitmaps' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseBitmaps", "(Z)V", "GetSetUseBitmaps_ZHandler")]
			set {
				const string __id = "setUseBitmaps.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseCachedPacks;
#pragma warning disable 0169
		static Delegate GetIsUseCachedPacksHandler ()
		{
			if (cb_isUseCachedPacks == null)
				cb_isUseCachedPacks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseCachedPacks);
			return cb_isUseCachedPacks;
		}

		static bool n_IsUseCachedPacks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseCachedPacks;
		}
#pragma warning restore 0169

		static Delegate cb_setUseCachedPacks_Z;
#pragma warning disable 0169
		static Delegate GetSetUseCachedPacks_ZHandler ()
		{
			if (cb_setUseCachedPacks_Z == null)
				cb_setUseCachedPacks_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseCachedPacks_Z);
			return cb_setUseCachedPacks_Z;
		}

		static void n_SetUseCachedPacks_Z (IntPtr jnienv, IntPtr native__this, bool useCached)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseCachedPacks = useCached;
		}
#pragma warning restore 0169

		/// <returns>true to reuse cached packs. If true index creation isn't available.</returns>
		/// <param name="useCached">if set to true and a cached pack is present, it will be
		///            appended onto the end of a thin-pack, reducing the amount of
		///            working set space and CPU used by PackWriter. Enabling this
		///            feature prevents PackWriter from creating an index for the
		///            newly created pack, so its only suitable for writing to a
		///            network client, where the client will make the index.</param>
		public virtual unsafe bool UseCachedPacks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='isUseCachedPacks' and count(parameter)=0]"
			[Register ("isUseCachedPacks", "()Z", "GetIsUseCachedPacksHandler")]
			get {
				const string __id = "isUseCachedPacks.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setUseCachedPacks' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseCachedPacks", "(Z)V", "GetSetUseCachedPacks_ZHandler")]
			set {
				const string __id = "setUseCachedPacks.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addObject_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetAddObject_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_addObject_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_addObject_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddObject_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_addObject_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static void n_AddObject_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native__object, JniHandleOwnership.DoNotTransfer);
			__this.AddObject (@object);
		}
#pragma warning restore 0169

		/// <param name="object">the object to add.</param>
		/// <summary>Include one object to the output file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='addObject' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("addObject", "(Lorg/eclipse/jgit/revwalk/RevObject;)V", "GetAddObject_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe void AddObject (global::Org.Eclipse.Jgit.Revwalk.RevObject @object)
		{
			const string __id = "addObject.(Lorg/eclipse/jgit/revwalk/RevObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@object);
			}
		}

		static Delegate cb_computeName;
#pragma warning disable 0169
		static Delegate GetComputeNameHandler ()
		{
			if (cb_computeName == null)
				cb_computeName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ComputeName);
			return cb_computeName;
		}

		static IntPtr n_ComputeName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ComputeName ());
		}
#pragma warning restore 0169

		/// <summary>Computes SHA-1 of lexicographically sorted objects ids written in this
		/// pack, as used to name a pack file in repository.</summary>
		/// <returns>ObjectId representing SHA-1 name of a pack that was created.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='computeName' and count(parameter)=0]"
		[Register ("computeName", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetComputeNameHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ComputeName ()
		{
			const string __id = "computeName.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_excludeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_;
#pragma warning disable 0169
		static Delegate GetExcludeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_Handler ()
		{
			if (cb_excludeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_ == null)
				cb_excludeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ExcludeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_);
			return cb_excludeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_;
		}

		static void n_ExcludeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idx)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var idx = (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.IObjectIdSet)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.IObjectIdSet> (native_idx, JniHandleOwnership.DoNotTransfer);
			__this.ExcludeObjects (idx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='excludeObjects' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackWriter.ObjectIdSet']]"
		[Register ("excludeObjects", "(Lorg/eclipse/jgit/internal/storage/pack/PackWriter$ObjectIdSet;)V", "GetExcludeObjects_Lorg_eclipse_jgit_internal_storage_pack_PackWriter_ObjectIdSet_Handler")]
		public virtual unsafe void ExcludeObjects (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.IObjectIdSet idx)
		{
			const string __id = "excludeObjects.(Lorg/eclipse/jgit/internal/storage/pack/PackWriter$ObjectIdSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((idx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idx).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (idx);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">the object to find in the pack.</param>
		/// <summary>Lookup the ObjectToPack object for a given ObjectId.</summary>
		/// <returns>the object we are packing, or null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='get' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("get", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;", "GetGet_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack Get (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "get.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$State;", "GetGetStateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.State GetState ()
		{
			const string __id = "getState.()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getStatistics;
#pragma warning disable 0169
		static Delegate GetGetStatisticsHandler ()
		{
			if (cb_getStatistics == null)
				cb_getStatistics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatistics);
			return cb_getStatistics;
		}

		static IntPtr n_GetStatistics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatistics ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='getStatistics' and count(parameter)=0]"
		[Register ("getStatistics", "()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;", "GetGetStatisticsHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics GetStatistics ()
		{
			const string __id = "getStatistics.()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_prepareBitmapIndex_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetPrepareBitmapIndex_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_prepareBitmapIndex_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_prepareBitmapIndex_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_PrepareBitmapIndex_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_prepareBitmapIndex_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static bool n_PrepareBitmapIndex_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pm = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_pm, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PrepareBitmapIndex (pm);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pm">progress monitor to report bitmap building work.</param>
		/// <summary>Prepares the bitmaps to be written to the pack index.</summary>
		/// <returns>whether a bitmap index may be written.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='prepareBitmapIndex' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("prepareBitmapIndex", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Z", "GetPrepareBitmapIndex_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe bool PrepareBitmapIndex (global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm)
		{
			const string __id = "prepareBitmapIndex.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (pm);
			}
		}

		static Delegate cb_preparePack_Ljava_util_Iterator_;
#pragma warning disable 0169
		static Delegate GetPreparePack_Ljava_util_Iterator_Handler ()
		{
			if (cb_preparePack_Ljava_util_Iterator_ == null)
				cb_preparePack_Ljava_util_Iterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PreparePack_Ljava_util_Iterator_);
			return cb_preparePack_Ljava_util_Iterator_;
		}

		static void n_PreparePack_Ljava_util_Iterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectsSource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectsSource = (global::Java.Util.IIterator)global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (native_objectsSource, JniHandleOwnership.DoNotTransfer);
			__this.PreparePack (objectsSource);
		}
#pragma warning restore 0169

		/// <param name="objectsSource">iterator of object to store in a pack; order of objects within
		///            each type is important, ordering by type is not needed;
		///            allowed types for objects are <c>Constants#OBJ_COMMIT</c>,
		///            <c>Constants#OBJ_TREE</c>, <c>Constants#OBJ_BLOB</c> and
		///            <c>Constants#OBJ_TAG</c>; objects returned by iterator may be
		///            later reused by caller as object id and type are internally
		///            copied in each iteration.</param>
		/// <summary>Prepare the list of objects to be written to the pack stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='preparePack' and count(parameter)=1 and parameter[1][@type='java.util.Iterator&lt;org.eclipse.jgit.revwalk.RevObject&gt;']]"
		[Register ("preparePack", "(Ljava/util/Iterator;)V", "GetPreparePack_Ljava_util_Iterator_Handler")]
		public virtual unsafe void PreparePack (global::Java.Util.IIterator objectsSource)
		{
			const string __id = "preparePack.(Ljava/util/Iterator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectsSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectsSource).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (objectsSource);
			}
		}

		static Delegate cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Collection_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetPreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Collection_Handler ()
		{
			if (cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Collection_ == null)
				cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Collection_);
			return cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Collection_;
		}

		[Obsolete]
		static void n_PreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_countingMonitor, IntPtr native_want, IntPtr native_have)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var countingMonitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_countingMonitor, JniHandleOwnership.DoNotTransfer);
			var want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_want, JniHandleOwnership.DoNotTransfer);
			var have = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_have, JniHandleOwnership.DoNotTransfer);
			__this.PreparePack (countingMonitor, want, have);
		}
#pragma warning restore 0169

		/// <param name="countingMonitor">progress during object enumeration.</param>
		/// <param name="want">collection of objects to be marked as interesting (start
		///            points of graph traversal).</param>
		/// <param name="have">collection of objects to be marked as uninteresting (end
		///            points of graph traversal).</param>
		/// <summary>Prepare the list of objects to be written to the pack stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='preparePack' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[3][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("preparePack", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Collection;)V", "GetPreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_util_Collection_Handler")]
		public virtual unsafe void PreparePack (Lib.IProgressMonitor countingMonitor, ICollection<Lib.ObjectId> want, ICollection<Lib.ObjectId> have)
		{
			const string __id = "preparePack.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/util/Collection;)V";
			IntPtr native_want = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (want);
			IntPtr native_have = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (have);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((countingMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) countingMonitor).Handle);
				__args [1] = new JniArgumentValue (native_want);
				__args [2] = new JniArgumentValue (native_have);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_want);
				JNIEnv.DeleteLocalRef (native_have);
				global::System.GC.KeepAlive (countingMonitor);
				global::System.GC.KeepAlive (want);
				global::System.GC.KeepAlive (have);
			}
		}

		static Delegate cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Set_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetPreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Set_Ljava_util_Set_Handler ()
		{
			if (cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Set_Ljava_util_Set_ == null)
				cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Set_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Set_Ljava_util_Set_);
			return cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Set_Ljava_util_Set_;
		}

		static void n_PreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Set_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_countingMonitor, IntPtr native_want, IntPtr native_have)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var countingMonitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_countingMonitor, JniHandleOwnership.DoNotTransfer);
			var want = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_want, JniHandleOwnership.DoNotTransfer);
			var have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_have, JniHandleOwnership.DoNotTransfer);
			__this.PreparePack (countingMonitor, want, have);
		}
#pragma warning restore 0169
		/*
		/// <param name="countingMonitor">progress during object enumeration.</param>
		/// <param name="want">collection of objects to be marked as interesting (start
		///            points of graph traversal).</param>
		/// <param name="have">collection of objects to be marked as uninteresting (end
		///            points of graph traversal).</param>
		/// <summary>Prepare the list of objects to be written to the pack stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='preparePack' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Set&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[3][@type='java.util.Set&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("preparePack", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Set;Ljava/util/Set;)V", "GetPreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Set_Ljava_util_Set_Handler")]
		public virtual unsafe void PreparePack (Lib.IProgressMonitor countingMonitor, ICollection<Lib.ObjectId> want, ICollection<Lib.ObjectId> have)
		{
			const string __id = "preparePack.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Set;Ljava/util/Set;)V";
			IntPtr native_want = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (want);
			IntPtr native_have = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (have);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((countingMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) countingMonitor).Handle);
				__args [1] = new JniArgumentValue (native_want);
				__args [2] = new JniArgumentValue (native_have);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_want);
				JNIEnv.DeleteLocalRef (native_have);
				global::System.GC.KeepAlive (countingMonitor);
				global::System.GC.KeepAlive (want);
				global::System.GC.KeepAlive (have);
			}
		}
		*/
		static Delegate cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Collection_Ljava_util_Collection_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetPreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Collection_Ljava_util_Collection_Handler ()
		{
			if (cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Collection_Ljava_util_Collection_ == null)
				cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Collection_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Collection_Ljava_util_Collection_);
			return cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Collection_Ljava_util_Collection_;
		}

		[Obsolete]
		static void n_PreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Collection_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_countingMonitor, IntPtr native_walk, IntPtr native_interestingObjects, IntPtr native_uninterestingObjects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var countingMonitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_countingMonitor, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			var interestingObjects = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_interestingObjects, JniHandleOwnership.DoNotTransfer);
			var uninterestingObjects = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_uninterestingObjects, JniHandleOwnership.DoNotTransfer);
			__this.PreparePack (countingMonitor, walk, interestingObjects, uninterestingObjects);
		}
#pragma warning restore 0169

		/// <param name="countingMonitor">progress during object enumeration.</param>
		/// <param name="walk">ObjectWalk to perform enumeration.</param>
		/// <param name="interestingObjects">collection of objects to be marked as interesting (start
		///            points of graph traversal).</param>
		/// <param name="uninterestingObjects">collection of objects to be marked as uninteresting (end
		///            points of graph traversal).</param>
		/// <summary>Prepare the list of objects to be written to the pack stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='preparePack' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='org.eclipse.jgit.revwalk.ObjectWalk'] and parameter[3][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[4][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("preparePack", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Lorg/eclipse/jgit/revwalk/ObjectWalk;Ljava/util/Collection;Ljava/util/Collection;)V", "GetPreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Collection_Ljava_util_Collection_Handler")]
		public virtual unsafe void PreparePack (global::Org.Eclipse.Jgit.Lib.IProgressMonitor countingMonitor, global::Org.Eclipse.Jgit.Revwalk.ObjectWalk walk, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> interestingObjects, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> uninterestingObjects)
		{
			const string __id = "preparePack.(Lorg/eclipse/jgit/lib/ProgressMonitor;Lorg/eclipse/jgit/revwalk/ObjectWalk;Ljava/util/Collection;Ljava/util/Collection;)V";
			IntPtr native_interestingObjects = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (interestingObjects);
			IntPtr native_uninterestingObjects = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (uninterestingObjects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((countingMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) countingMonitor).Handle);
				__args [1] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				__args [2] = new JniArgumentValue (native_interestingObjects);
				__args [3] = new JniArgumentValue (native_uninterestingObjects);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_interestingObjects);
				JNIEnv.DeleteLocalRef (native_uninterestingObjects);
				global::System.GC.KeepAlive (countingMonitor);
				global::System.GC.KeepAlive (walk);
				global::System.GC.KeepAlive (interestingObjects);
				global::System.GC.KeepAlive (uninterestingObjects);
			}
		}

		static Delegate cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Set_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetPreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Set_Ljava_util_Set_Handler ()
		{
			if (cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Set_Ljava_util_Set_ == null)
				cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Set_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Set_Ljava_util_Set_);
			return cb_preparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Set_Ljava_util_Set_;
		}

		static void n_PreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Set_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_countingMonitor, IntPtr native_walk, IntPtr native_interestingObjects, IntPtr native_uninterestingObjects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var countingMonitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_countingMonitor, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			var interestingObjects = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_interestingObjects, JniHandleOwnership.DoNotTransfer);
			var uninterestingObjects = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_uninterestingObjects, JniHandleOwnership.DoNotTransfer);
			__this.PreparePack (countingMonitor, walk, interestingObjects, uninterestingObjects);
		}
#pragma warning restore 0169
		/*
		/// <param name="countingMonitor">progress during object enumeration.</param>
		/// <param name="walk">ObjectWalk to perform enumeration.</param>
		/// <param name="interestingObjects">collection of objects to be marked as interesting (start
		///            points of graph traversal).</param>
		/// <param name="uninterestingObjects">collection of objects to be marked as uninteresting (end
		///            points of graph traversal).</param>
		/// <summary>Prepare the list of objects to be written to the pack stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='preparePack' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='org.eclipse.jgit.revwalk.ObjectWalk'] and parameter[3][@type='java.util.Set&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[4][@type='java.util.Set&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("preparePack", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Lorg/eclipse/jgit/revwalk/ObjectWalk;Ljava/util/Set;Ljava/util/Set;)V", "GetPreparePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_revwalk_ObjectWalk_Ljava_util_Set_Ljava_util_Set_Handler")]
		public virtual unsafe void PreparePack (global::Org.Eclipse.Jgit.Lib.IProgressMonitor countingMonitor, global::Org.Eclipse.Jgit.Revwalk.ObjectWalk walk, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> interestingObjects, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> uninterestingObjects)
		{
			const string __id = "preparePack.(Lorg/eclipse/jgit/lib/ProgressMonitor;Lorg/eclipse/jgit/revwalk/ObjectWalk;Ljava/util/Set;Ljava/util/Set;)V";
			IntPtr native_interestingObjects = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (interestingObjects);
			IntPtr native_uninterestingObjects = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (uninterestingObjects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((countingMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) countingMonitor).Handle);
				__args [1] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				__args [2] = new JniArgumentValue (native_interestingObjects);
				__args [3] = new JniArgumentValue (native_uninterestingObjects);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_interestingObjects);
				JNIEnv.DeleteLocalRef (native_uninterestingObjects);
				global::System.GC.KeepAlive (countingMonitor);
				global::System.GC.KeepAlive (walk);
				global::System.GC.KeepAlive (interestingObjects);
				global::System.GC.KeepAlive (uninterestingObjects);
			}
		}
		*/
		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		/// <summary>Release all resources used by this writer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_select_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_;
#pragma warning disable 0169
		static Delegate GetSelect_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_Handler ()
		{
			if (cb_select_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_ == null)
				cb_select_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Select_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_);
			return cb_select_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_;
		}

		static void n_Select_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_otp, IntPtr native_next)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var otp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (native_otp, JniHandleOwnership.DoNotTransfer);
			var next = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation> (native_next, JniHandleOwnership.DoNotTransfer);
			__this.Select (otp, next);
		}
#pragma warning restore 0169

		/// <param name="otp">the object being packed.</param>
		/// <param name="next">the next available representation from the repository.</param>
		/// <summary>Select an object representation for this writer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='select' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.ObjectToPack'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.StoredObjectRepresentation']]"
		[Register ("select", "(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Lorg/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation;)V", "GetSelect_Lorg_eclipse_jgit_internal_storage_pack_ObjectToPack_Lorg_eclipse_jgit_internal_storage_pack_StoredObjectRepresentation_Handler")]
		public virtual unsafe void Select (global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack otp, global::Org.Eclipse.Jgit.Internal.Storage.Pack.StoredObjectRepresentation next)
		{
			const string __id = "select.(Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Lorg/eclipse/jgit/internal/storage/pack/StoredObjectRepresentation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((otp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) otp).Handle);
				__args [1] = new JniArgumentValue ((next == null) ? IntPtr.Zero : ((global::Java.Lang.Object) next).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (otp);
				global::System.GC.KeepAlive (next);
			}
		}

		static Delegate cb_setShallowPack_ILjava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetShallowPack_ILjava_util_Collection_Handler ()
		{
			if (cb_setShallowPack_ILjava_util_Collection_ == null)
				cb_setShallowPack_ILjava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetShallowPack_ILjava_util_Collection_);
			return cb_setShallowPack_ILjava_util_Collection_;
		}

		static void n_SetShallowPack_ILjava_util_Collection_ (IntPtr jnienv, IntPtr native__this, int depth, IntPtr native_unshallow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var unshallow = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_unshallow, JniHandleOwnership.DoNotTransfer);
			__this.SetShallowPack (depth, unshallow);
		}
#pragma warning restore 0169

		/// <param name="depth">maximum depth to traverse the commit graph</param>
		/// <param name="unshallow">objects which used to be shallow on the client, but are being
		///            extended as part of this fetch</param>
		/// <summary>Configure this pack for a shallow clone.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setShallowPack' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("setShallowPack", "(ILjava/util/Collection;)V", "GetSetShallowPack_ILjava_util_Collection_Handler")]
		public virtual unsafe void SetShallowPack (int depth, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> unshallow)
		{
			const string __id = "setShallowPack.(ILjava/util/Collection;)V";
			IntPtr native_unshallow = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (unshallow);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (depth);
				__args [1] = new JniArgumentValue (native_unshallow);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_unshallow);
				global::System.GC.KeepAlive (unshallow);
			}
		}

		static Delegate cb_setTagTargets_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetTagTargets_Ljava_util_Set_Handler ()
		{
			if (cb_setTagTargets_Ljava_util_Set_ == null)
				cb_setTagTargets_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTagTargets_Ljava_util_Set_);
			return cb_setTagTargets_Ljava_util_Set_;
		}

		static void n_SetTagTargets_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objects = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_objects, JniHandleOwnership.DoNotTransfer);
			__this.SetTagTargets (objects);
		}
#pragma warning restore 0169

		/// <param name="objects">objects that annotated tags point at.</param>
		/// <summary>Set the tag targets that should be hoisted earlier during packing.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='setTagTargets' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("setTagTargets", "(Ljava/util/Set;)V", "GetSetTagTargets_Ljava_util_Set_Handler")]
		public virtual unsafe void SetTagTargets (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> objects)
		{
			const string __id = "setTagTargets.(Ljava/util/Set;)V";
			IntPtr native_objects = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (objects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_objects);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_objects);
				global::System.GC.KeepAlive (objects);
			}
		}

		static Delegate cb_willInclude_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetWillInclude_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_willInclude_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_willInclude_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_WillInclude_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_willInclude_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_WillInclude_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.WillInclude (id);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">the object to test the existence of.</param>
		/// <summary>Determine if the pack file will contain the requested object.</summary>
		/// <returns>true if the object will appear in the output pack file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='willInclude' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("willInclude", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetWillInclude_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe bool WillInclude (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "willInclude.(Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_writeBitmapIndex_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteBitmapIndex_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeBitmapIndex_Ljava_io_OutputStream_ == null)
				cb_writeBitmapIndex_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteBitmapIndex_Ljava_io_OutputStream_);
			return cb_writeBitmapIndex_Ljava_io_OutputStream_;
		}

		static void n_WriteBitmapIndex_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmapIndexStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmapIndexStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_bitmapIndexStream, JniHandleOwnership.DoNotTransfer);
			__this.WriteBitmapIndex (bitmapIndexStream);
		}
#pragma warning restore 0169

		/// <param name="bitmapIndexStream">output for the bitmap index data. Caller is responsible for
		///            closing this stream.</param>
		/// <summary>Create a bitmap index file to match the pack file just written.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='writeBitmapIndex' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeBitmapIndex", "(Ljava/io/OutputStream;)V", "GetWriteBitmapIndex_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void WriteBitmapIndex (global::System.IO.Stream bitmapIndexStream)
		{
			const string __id = "writeBitmapIndex.(Ljava/io/OutputStream;)V";
			IntPtr native_bitmapIndexStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (bitmapIndexStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bitmapIndexStream);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bitmapIndexStream);
				global::System.GC.KeepAlive (bitmapIndexStream);
			}
		}

		static Delegate cb_writeIndex_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteIndex_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeIndex_Ljava_io_OutputStream_ == null)
				cb_writeIndex_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteIndex_Ljava_io_OutputStream_);
			return cb_writeIndex_Ljava_io_OutputStream_;
		}

		static void n_WriteIndex_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_indexStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var indexStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_indexStream, JniHandleOwnership.DoNotTransfer);
			__this.WriteIndex (indexStream);
		}
#pragma warning restore 0169

		/// <param name="indexStream">output for the index data. Caller is responsible for closing
		///            this stream.</param>
		/// <summary>Create an index file to match the pack file just written.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='writeIndex' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeIndex", "(Ljava/io/OutputStream;)V", "GetWriteIndex_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void WriteIndex (global::System.IO.Stream indexStream)
		{
			const string __id = "writeIndex.(Ljava/io/OutputStream;)V";
			IntPtr native_indexStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (indexStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_indexStream);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_indexStream);
				global::System.GC.KeepAlive (indexStream);
			}
		}

		static Delegate cb_writePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWritePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_ == null)
				cb_writePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_WritePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_);
			return cb_writePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_;
		}

		static void n_WritePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_compressMonitor, IntPtr native_writeMonitor, IntPtr native_packStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var compressMonitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_compressMonitor, JniHandleOwnership.DoNotTransfer);
			var writeMonitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_writeMonitor, JniHandleOwnership.DoNotTransfer);
			var packStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_packStream, JniHandleOwnership.DoNotTransfer);
			__this.WritePack (compressMonitor, writeMonitor, packStream);
		}
#pragma warning restore 0169

		/// <param name="compressMonitor">progress monitor to report object compression work.</param>
		/// <param name="writeMonitor">progress monitor to report the number of objects written.</param>
		/// <param name="packStream">output stream of pack data. The stream should be buffered by
		///            the caller. The caller is responsible for closing the stream.</param>
		/// <summary>Write the prepared pack to the supplied stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackWriter']/method[@name='writePack' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[3][@type='java.io.OutputStream']]"
		[Register ("writePack", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/io/OutputStream;)V", "GetWritePack_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void WritePack (global::Org.Eclipse.Jgit.Lib.IProgressMonitor compressMonitor, global::Org.Eclipse.Jgit.Lib.IProgressMonitor writeMonitor, global::System.IO.Stream packStream)
		{
			const string __id = "writePack.(Lorg/eclipse/jgit/lib/ProgressMonitor;Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/io/OutputStream;)V";
			IntPtr native_packStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (packStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((compressMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compressMonitor).Handle);
				__args [1] = new JniArgumentValue ((writeMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writeMonitor).Handle);
				__args [2] = new JniArgumentValue (native_packStream);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_packStream);
				global::System.GC.KeepAlive (compressMonitor);
				global::System.GC.KeepAlive (writeMonitor);
				global::System.GC.KeepAlive (packStream);
			}
		}

	}
}
