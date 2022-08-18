using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A reference that indirectly points at another <c>Ref</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/SymbolicRef", DoNotGenerateAcw=true)]
	public partial class SymbolicRef : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Lib.IRef {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/SymbolicRef", typeof (SymbolicRef));

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

		protected SymbolicRef (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="refName">name of this ref.</param>
		/// <param name="target">the ref we reference and derive our value from.</param>
		/// <summary>Create a new ref pairing.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']/constructor[@name='SymbolicRef' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.Ref']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/Ref;)V", "")]
		public unsafe SymbolicRef (string refName, global::Org.Eclipse.Jgit.Lib.IRef target) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/eclipse/jgit/lib/Ref;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_refName);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
				global::System.GC.KeepAlive (target);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.SymbolicRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPeeled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPeeled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']/method[@name='isPeeled' and count(parameter)=0]"
			[Register ("isPeeled", "()Z", "GetIsPeeledHandler")]
			get {
				const string __id = "isPeeled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.SymbolicRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSymbolic;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSymbolic {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']/method[@name='isSymbolic' and count(parameter)=0]"
			[Register ("isSymbolic", "()Z", "GetIsSymbolicHandler")]
			get {
				const string __id = "isSymbolic.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.SymbolicRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Leaf);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IRef Leaf {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']/method[@name='getLeaf' and count(parameter)=0]"
			[Register ("getLeaf", "()Lorg/eclipse/jgit/lib/Ref;", "GetGetLeafHandler")]
			get {
				const string __id = "getLeaf.()Lorg/eclipse/jgit/lib/Ref;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.SymbolicRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.SymbolicRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectId);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']/method[@name='getObjectId' and count(parameter)=0]"
			[Register ("getObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObjectIdHandler")]
			get {
				const string __id = "getObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.SymbolicRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeeledObjectId);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId PeeledObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']/method[@name='getPeeledObjectId' and count(parameter)=0]"
			[Register ("getPeeledObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetPeeledObjectIdHandler")]
			get {
				const string __id = "getPeeledObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.SymbolicRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Storage);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefStorage Storage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']/method[@name='getStorage' and count(parameter)=0]"
			[Register ("getStorage", "()Lorg/eclipse/jgit/lib/Ref$Storage;", "GetGetStorageHandler")]
			get {
				const string __id = "getStorage.()Lorg/eclipse/jgit/lib/Ref$Storage;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefStorage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.SymbolicRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Target);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IRef Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='SymbolicRef']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Lorg/eclipse/jgit/lib/Ref;", "GetGetTargetHandler")]
			get {
				const string __id = "getTarget.()Lorg/eclipse/jgit/lib/Ref;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
