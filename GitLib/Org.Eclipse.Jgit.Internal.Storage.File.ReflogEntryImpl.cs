using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Parsed reflog entry</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogEntryImpl']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/ReflogEntryImpl", DoNotGenerateAcw=true)]
	public partial class ReflogEntryImpl : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Org.Eclipse.Jgit.Lib.IReflogEntry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/ReflogEntryImpl", typeof (ReflogEntryImpl));

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

		protected ReflogEntryImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getComment;
#pragma warning disable 0169
		static Delegate GetGetCommentHandler ()
		{
			if (cb_getComment == null)
				cb_getComment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetComment);
			return cb_getComment;
		}

		static IntPtr n_GetComment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Comment);
		}
#pragma warning restore 0169

		public virtual unsafe string Comment {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogEntryImpl']/method[@name='getComment' and count(parameter)=0]"
			[Register ("getComment", "()Ljava/lang/String;", "GetGetCommentHandler")]
			get {
				const string __id = "getComment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNewId;
#pragma warning disable 0169
		static Delegate GetGetNewIdHandler ()
		{
			if (cb_getNewId == null)
				cb_getNewId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewId);
			return cb_getNewId;
		}

		static IntPtr n_GetNewId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewId);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId NewId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogEntryImpl']/method[@name='getNewId' and count(parameter)=0]"
			[Register ("getNewId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetNewIdHandler")]
			get {
				const string __id = "getNewId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldId;
#pragma warning disable 0169
		static Delegate GetGetOldIdHandler ()
		{
			if (cb_getOldId == null)
				cb_getOldId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOldId);
			return cb_getOldId;
		}

		static IntPtr n_GetOldId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldId);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId OldId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogEntryImpl']/method[@name='getOldId' and count(parameter)=0]"
			[Register ("getOldId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetOldIdHandler")]
			get {
				const string __id = "getOldId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWho;
#pragma warning disable 0169
		static Delegate GetGetWhoHandler ()
		{
			if (cb_getWho == null)
				cb_getWho = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWho);
			return cb_getWho;
		}

		static IntPtr n_GetWho (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Who);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent Who {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogEntryImpl']/method[@name='getWho' and count(parameter)=0]"
			[Register ("getWho", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetWhoHandler")]
			get {
				const string __id = "getWho.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_parseCheckout;
#pragma warning disable 0169
		static Delegate GetParseCheckoutHandler ()
		{
			if (cb_parseCheckout == null)
				cb_parseCheckout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ParseCheckout);
			return cb_parseCheckout;
		}

		static IntPtr n_ParseCheckout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.ReflogEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParseCheckout ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='ReflogEntryImpl']/method[@name='parseCheckout' and count(parameter)=0]"
		[Register ("parseCheckout", "()Lorg/eclipse/jgit/lib/CheckoutEntry;", "GetParseCheckoutHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ICheckoutEntry ParseCheckout ()
		{
			const string __id = "parseCheckout.()Lorg/eclipse/jgit/lib/CheckoutEntry;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ICheckoutEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
