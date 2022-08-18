using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Submodule {

	/// <summary>Status class containing the type, path, and commit id of the submodule.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatus']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/submodule/SubmoduleStatus", DoNotGenerateAcw=true)]
	public partial class SubmoduleStatus : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/submodule/SubmoduleStatus", typeof (SubmoduleStatus));

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

		protected SubmoduleStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="type">type</param>
		/// <param name="path">path</param>
		/// <param name="indexId">indexId</param>
		/// <summary>Create submodule status</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatus']/constructor[@name='SubmoduleStatus' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.submodule.SubmoduleStatusType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/submodule/SubmoduleStatusType;Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)V", "")]
		public unsafe SubmoduleStatus (global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType type, string path, global::Org.Eclipse.Jgit.Lib.ObjectId indexId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/submodule/SubmoduleStatusType;Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue ((indexId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (indexId);
			}
		}

		/// <param name="type">type</param>
		/// <param name="path">path</param>
		/// <param name="indexId">indexId</param>
		/// <param name="headId">headId</param>
		/// <summary>Create submodule status</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatus']/constructor[@name='SubmoduleStatus' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.submodule.SubmoduleStatusType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[4][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/submodule/SubmoduleStatusType;Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;)V", "")]
		public unsafe SubmoduleStatus (global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType type, string path, global::Org.Eclipse.Jgit.Lib.ObjectId indexId, global::Org.Eclipse.Jgit.Lib.ObjectId headId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/submodule/SubmoduleStatusType;Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue ((indexId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexId).Handle);
				__args [3] = new JniArgumentValue ((headId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (indexId);
				global::System.GC.KeepAlive (headId);
			}
		}

		static Delegate cb_getHeadId;
#pragma warning disable 0169
		static Delegate GetGetHeadIdHandler ()
		{
			if (cb_getHeadId == null)
				cb_getHeadId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHeadId);
			return cb_getHeadId;
		}

		static IntPtr n_GetHeadId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeadId);
		}
#pragma warning restore 0169

		/// <returns>HEAD object id</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId HeadId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatus']/method[@name='getHeadId' and count(parameter)=0]"
			[Register ("getHeadId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetHeadIdHandler")]
			get {
				const string __id = "getHeadId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIndexId;
#pragma warning disable 0169
		static Delegate GetGetIndexIdHandler ()
		{
			if (cb_getIndexId == null)
				cb_getIndexId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIndexId);
			return cb_getIndexId;
		}

		static IntPtr n_GetIndexId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IndexId);
		}
#pragma warning restore 0169

		/// <returns>index object id</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId IndexId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatus']/method[@name='getIndexId' and count(parameter)=0]"
			[Register ("getIndexId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetIndexIdHandler")]
			get {
				const string __id = "getIndexId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		/// <returns>path</returns>
		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatus']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		/// <returns>type</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleStatus']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lorg/eclipse/jgit/submodule/SubmoduleStatusType;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Lorg/eclipse/jgit/submodule/SubmoduleStatusType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleStatusType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
