using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Update of a locally stored tracking branch.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TrackingRefUpdate']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TrackingRefUpdate", DoNotGenerateAcw=true)]
	public partial class TrackingRefUpdate : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TrackingRefUpdate", typeof (TrackingRefUpdate));

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

		protected TrackingRefUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getLocalName;
#pragma warning disable 0169
		static Delegate GetGetLocalNameHandler ()
		{
			if (cb_getLocalName == null)
				cb_getLocalName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalName);
			return cb_getLocalName;
		}

		static IntPtr n_GetLocalName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalName);
		}
#pragma warning restore 0169

		/// <summary>Get the name of the local tracking ref.</summary>
		/// <returns>the name used within this local repository.</returns>
		public virtual unsafe string LocalName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TrackingRefUpdate']/method[@name='getLocalName' and count(parameter)=0]"
			[Register ("getLocalName", "()Ljava/lang/String;", "GetGetLocalNameHandler")]
			get {
				const string __id = "getLocalName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNewObjectId;
#pragma warning disable 0169
		static Delegate GetGetNewObjectIdHandler ()
		{
			if (cb_getNewObjectId == null)
				cb_getNewObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewObjectId);
			return cb_getNewObjectId;
		}

		static IntPtr n_GetNewObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewObjectId);
		}
#pragma warning restore 0169

		/// <summary>Get the new value the ref will be (or was) updated to.</summary>
		/// <returns>new value. Null if the caller has not configured it.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId NewObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TrackingRefUpdate']/method[@name='getNewObjectId' and count(parameter)=0]"
			[Register ("getNewObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetNewObjectIdHandler")]
			get {
				const string __id = "getNewObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldObjectId;
#pragma warning disable 0169
		static Delegate GetGetOldObjectIdHandler ()
		{
			if (cb_getOldObjectId == null)
				cb_getOldObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOldObjectId);
			return cb_getOldObjectId;
		}

		static IntPtr n_GetOldObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldObjectId);
		}
#pragma warning restore 0169

		/// <summary>The old value of the ref, prior to the update being attempted.</summary>
		/// <returns>the value of the ref prior to the update being attempted.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId OldObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TrackingRefUpdate']/method[@name='getOldObjectId' and count(parameter)=0]"
			[Register ("getOldObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetOldObjectIdHandler")]
			get {
				const string __id = "getOldObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoteName;
#pragma warning disable 0169
		static Delegate GetGetRemoteNameHandler ()
		{
			if (cb_getRemoteName == null)
				cb_getRemoteName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemoteName);
			return cb_getRemoteName;
		}

		static IntPtr n_GetRemoteName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemoteName);
		}
#pragma warning restore 0169

		/// <summary>Get the name of the remote ref.</summary>
		/// <returns>the name used within the remote repository.</returns>
		public virtual unsafe string RemoteName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TrackingRefUpdate']/method[@name='getRemoteName' and count(parameter)=0]"
			[Register ("getRemoteName", "()Ljava/lang/String;", "GetGetRemoteNameHandler")]
			get {
				const string __id = "getRemoteName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TrackingRefUpdate']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Lorg/eclipse/jgit/lib/RefUpdate$Result;", "GetGetResultHandler")]
			get {
				const string __id = "getResult.()Lorg/eclipse/jgit/lib/RefUpdate$Result;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asReceiveCommand;
#pragma warning disable 0169
		static Delegate GetAsReceiveCommandHandler ()
		{
			if (cb_asReceiveCommand == null)
				cb_asReceiveCommand = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsReceiveCommand);
			return cb_asReceiveCommand;
		}

		static IntPtr n_AsReceiveCommand (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsReceiveCommand ());
		}
#pragma warning restore 0169

		/// <returns>this update wrapped by a ReceiveCommand.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TrackingRefUpdate']/method[@name='asReceiveCommand' and count(parameter)=0]"
		[Register ("asReceiveCommand", "()Lorg/eclipse/jgit/transport/ReceiveCommand;", "GetAsReceiveCommandHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.ReceiveCommand AsReceiveCommand ()
		{
			const string __id = "asReceiveCommand.()Lorg/eclipse/jgit/transport/ReceiveCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
