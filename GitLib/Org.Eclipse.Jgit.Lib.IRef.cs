using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Location where a <c>Ref</c> is stored.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/Ref$Storage", DoNotGenerateAcw=true)]
	public sealed partial class RefStorage : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']/field[@name='LOOSE']"
		[Register ("LOOSE")]
		public static global::Org.Eclipse.Jgit.Lib.RefStorage Loose {
			get {
				const string __id = "LOOSE.Lorg/eclipse/jgit/lib/Ref$Storage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefStorage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']/field[@name='LOOSE_PACKED']"
		[Register ("LOOSE_PACKED")]
		public static global::Org.Eclipse.Jgit.Lib.RefStorage LoosePacked {
			get {
				const string __id = "LOOSE_PACKED.Lorg/eclipse/jgit/lib/Ref$Storage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefStorage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']/field[@name='NETWORK']"
		[Register ("NETWORK")]
		public static global::Org.Eclipse.Jgit.Lib.RefStorage Network {
			get {
				const string __id = "NETWORK.Lorg/eclipse/jgit/lib/Ref$Storage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefStorage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']/field[@name='NEW']"
		[Register ("NEW")]
		public static global::Org.Eclipse.Jgit.Lib.RefStorage New {
			get {
				const string __id = "NEW.Lorg/eclipse/jgit/lib/Ref$Storage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefStorage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']/field[@name='PACKED']"
		[Register ("PACKED")]
		public static global::Org.Eclipse.Jgit.Lib.RefStorage Packed {
			get {
				const string __id = "PACKED.Lorg/eclipse/jgit/lib/Ref$Storage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefStorage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/Ref$Storage", typeof (RefStorage));

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

		internal RefStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <returns>true if this storage has a loose file.</returns>
		public unsafe bool IsLoose {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']/method[@name='isLoose' and count(parameter)=0]"
			[Register ("isLoose", "()Z", "")]
			get {
				const string __id = "isLoose.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>true if this storage is inside the packed file.</returns>
		public unsafe bool IsPacked {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']/method[@name='isPacked' and count(parameter)=0]"
			[Register ("isPacked", "()Z", "")]
			get {
				const string __id = "isPacked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref$Storage;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.RefStorage ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref$Storage;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefStorage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Ref.Storage']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/eclipse/jgit/lib/Ref$Storage;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.RefStorage[] Values ()
		{
			const string __id = "values.()[Lorg/eclipse/jgit/lib/Ref$Storage;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Eclipse.Jgit.Lib.RefStorage[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.RefStorage));
			} finally {
			}
		}

	}

	/// <summary>Pairing of a name and the <c>ObjectId</c> it currently has.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Ref']"
	[Register ("org/eclipse/jgit/lib/Ref", "", "Org.Eclipse.Jgit.Lib.IRefInvoker")]
	public partial interface IRef : IJavaObject, IJavaPeerable {
		bool IsPeeled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Ref']/method[@name='isPeeled' and count(parameter)=0]"
			[Register ("isPeeled", "()Z", "GetIsPeeledHandler:Org.Eclipse.Jgit.Lib.IRefInvoker, AndroidBindableLibrary")]
			get; 
		}

		bool IsSymbolic {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Ref']/method[@name='isSymbolic' and count(parameter)=0]"
			[Register ("isSymbolic", "()Z", "GetIsSymbolicHandler:Org.Eclipse.Jgit.Lib.IRefInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Lib.IRef Leaf {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Ref']/method[@name='getLeaf' and count(parameter)=0]"
			[Register ("getLeaf", "()Lorg/eclipse/jgit/lib/Ref;", "GetGetLeafHandler:Org.Eclipse.Jgit.Lib.IRefInvoker, AndroidBindableLibrary")]
			get; 
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Ref']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Org.Eclipse.Jgit.Lib.IRefInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Lib.ObjectId ObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Ref']/method[@name='getObjectId' and count(parameter)=0]"
			[Register ("getObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObjectIdHandler:Org.Eclipse.Jgit.Lib.IRefInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Lib.ObjectId PeeledObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Ref']/method[@name='getPeeledObjectId' and count(parameter)=0]"
			[Register ("getPeeledObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetPeeledObjectIdHandler:Org.Eclipse.Jgit.Lib.IRefInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Lib.RefStorage Storage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Ref']/method[@name='getStorage' and count(parameter)=0]"
			[Register ("getStorage", "()Lorg/eclipse/jgit/lib/Ref$Storage;", "GetGetStorageHandler:Org.Eclipse.Jgit.Lib.IRefInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Lib.IRef Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Ref']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Lorg/eclipse/jgit/lib/Ref;", "GetGetTargetHandler:Org.Eclipse.Jgit.Lib.IRefInvoker, AndroidBindableLibrary")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/Ref", DoNotGenerateAcw=true)]
	internal partial class IRefInvoker : global::Java.Lang.Object, IRef {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/Ref", typeof (IRefInvoker));

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

		public static IRef GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRef> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.Ref'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isPeeled;
#pragma warning disable 0169
		static Delegate GetIsPeeledHandler ()
		{
			if (cb_isPeeled == null)
				cb_isPeeled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPeeled);
			return cb_isPeeled;
		}

		static bool n_IsPeeled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPeeled;
		}
#pragma warning restore 0169

		IntPtr id_isPeeled;
		public unsafe bool IsPeeled {
			get {
				if (id_isPeeled == IntPtr.Zero)
					id_isPeeled = JNIEnv.GetMethodID (class_ref, "isPeeled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPeeled);
			}
		}

		static Delegate cb_isSymbolic;
#pragma warning disable 0169
		static Delegate GetIsSymbolicHandler ()
		{
			if (cb_isSymbolic == null)
				cb_isSymbolic = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSymbolic);
			return cb_isSymbolic;
		}

		static bool n_IsSymbolic (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSymbolic;
		}
#pragma warning restore 0169

		IntPtr id_isSymbolic;
		public unsafe bool IsSymbolic {
			get {
				if (id_isSymbolic == IntPtr.Zero)
					id_isSymbolic = JNIEnv.GetMethodID (class_ref, "isSymbolic", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSymbolic);
			}
		}

		static Delegate cb_getLeaf;
#pragma warning disable 0169
		static Delegate GetGetLeafHandler ()
		{
			if (cb_getLeaf == null)
				cb_getLeaf = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLeaf);
			return cb_getLeaf;
		}

		static IntPtr n_GetLeaf (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Leaf);
		}
#pragma warning restore 0169

		IntPtr id_getLeaf;
		public unsafe global::Org.Eclipse.Jgit.Lib.IRef Leaf {
			get {
				if (id_getLeaf == IntPtr.Zero)
					id_getLeaf = JNIEnv.GetMethodID (class_ref, "getLeaf", "()Lorg/eclipse/jgit/lib/Ref;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLeaf), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getObjectId;
#pragma warning disable 0169
		static Delegate GetGetObjectIdHandler ()
		{
			if (cb_getObjectId == null)
				cb_getObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectId);
			return cb_getObjectId;
		}

		static IntPtr n_GetObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectId);
		}
#pragma warning restore 0169

		IntPtr id_getObjectId;
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ObjectId {
			get {
				if (id_getObjectId == IntPtr.Zero)
					id_getObjectId = JNIEnv.GetMethodID (class_ref, "getObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObjectId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPeeledObjectId;
#pragma warning disable 0169
		static Delegate GetGetPeeledObjectIdHandler ()
		{
			if (cb_getPeeledObjectId == null)
				cb_getPeeledObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPeeledObjectId);
			return cb_getPeeledObjectId;
		}

		static IntPtr n_GetPeeledObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeeledObjectId);
		}
#pragma warning restore 0169

		IntPtr id_getPeeledObjectId;
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId PeeledObjectId {
			get {
				if (id_getPeeledObjectId == IntPtr.Zero)
					id_getPeeledObjectId = JNIEnv.GetMethodID (class_ref, "getPeeledObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPeeledObjectId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStorage;
#pragma warning disable 0169
		static Delegate GetGetStorageHandler ()
		{
			if (cb_getStorage == null)
				cb_getStorage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStorage);
			return cb_getStorage;
		}

		static IntPtr n_GetStorage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Storage);
		}
#pragma warning restore 0169

		IntPtr id_getStorage;
		public unsafe global::Org.Eclipse.Jgit.Lib.RefStorage Storage {
			get {
				if (id_getStorage == IntPtr.Zero)
					id_getStorage = JNIEnv.GetMethodID (class_ref, "getStorage", "()Lorg/eclipse/jgit/lib/Ref$Storage;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefStorage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStorage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTarget;
#pragma warning disable 0169
		static Delegate GetGetTargetHandler ()
		{
			if (cb_getTarget == null)
				cb_getTarget = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTarget);
			return cb_getTarget;
		}

		static IntPtr n_GetTarget (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Target);
		}
#pragma warning restore 0169

		IntPtr id_getTarget;
		public unsafe global::Org.Eclipse.Jgit.Lib.IRef Target {
			get {
				if (id_getTarget == IntPtr.Zero)
					id_getTarget = JNIEnv.GetMethodID (class_ref, "getTarget", "()Lorg/eclipse/jgit/lib/Ref;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTarget), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
