using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Class holding result of operation on remote repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OperationResult']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/OperationResult", DoNotGenerateAcw=true)]
	public abstract partial class OperationResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/OperationResult", typeof (OperationResult));

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

		protected OperationResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OperationResult']/constructor[@name='OperationResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OperationResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAdvertisedRefs;
#pragma warning disable 0169
		static Delegate GetGetAdvertisedRefsHandler ()
		{
			if (cb_getAdvertisedRefs == null)
				cb_getAdvertisedRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdvertisedRefs);
			return cb_getAdvertisedRefs;
		}

		static IntPtr n_GetAdvertisedRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OperationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.AdvertisedRefs);
		}
#pragma warning restore 0169

		/// <summary>Get the complete list of refs advertised by the remote.</summary>
		/// <returns>available/advertised refs. Never null. Not modifiable. The
		///         collection can be empty if the remote side has no refs (it is an
		///         empty/newly created repository).</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> AdvertisedRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OperationResult']/method[@name='getAdvertisedRefs' and count(parameter)=0]"
			[Register ("getAdvertisedRefs", "()Ljava/util/Collection;", "GetGetAdvertisedRefsHandler")]
			get {
				const string __id = "getAdvertisedRefs.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessages;
#pragma warning disable 0169
		static Delegate GetGetMessagesHandler ()
		{
			if (cb_getMessages == null)
				cb_getMessages = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessages);
			return cb_getMessages;
		}

		static IntPtr n_GetMessages (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OperationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Messages);
		}
#pragma warning restore 0169

		/// <summary>Get the additional messages, if any, returned by the remote process.</summary>
		/// <returns>the messages returned by the remote, most likely terminated by a
		///         newline (LF) character. The empty string is returned if the
		///         remote produced no additional messages.</returns>
		public virtual unsafe string Messages {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OperationResult']/method[@name='getMessages' and count(parameter)=0]"
			[Register ("getMessages", "()Ljava/lang/String;", "GetGetMessagesHandler")]
			get {
				const string __id = "getMessages.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingRefUpdates;
#pragma warning disable 0169
		static Delegate GetGetTrackingRefUpdatesHandler ()
		{
			if (cb_getTrackingRefUpdates == null)
				cb_getTrackingRefUpdates = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTrackingRefUpdates);
			return cb_getTrackingRefUpdates;
		}

		static IntPtr n_GetTrackingRefUpdates (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OperationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate>.ToLocalJniHandle (__this.TrackingRefUpdates);
		}
#pragma warning restore 0169

		/// <summary>Get the status of all local tracking refs that were updated.</summary>
		/// <returns>unmodifiable collection of local updates. Never null. Empty if
		///         there were no local tracking refs updated.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate> TrackingRefUpdates {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OperationResult']/method[@name='getTrackingRefUpdates' and count(parameter)=0]"
			[Register ("getTrackingRefUpdates", "()Ljava/util/Collection;", "GetGetTrackingRefUpdatesHandler")]
			get {
				const string __id = "getTrackingRefUpdates.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getURI;
#pragma warning disable 0169
		static Delegate GetGetURIHandler ()
		{
			if (cb_getURI == null)
				cb_getURI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetURI);
			return cb_getURI;
		}

		static IntPtr n_GetURI (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OperationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.URI);
		}
#pragma warning restore 0169

		/// <summary>Get the URI this result came from.</summary>
		/// <returns>the URI describing the location of the remote repository.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.URIish URI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OperationResult']/method[@name='getURI' and count(parameter)=0]"
			[Register ("getURI", "()Lorg/eclipse/jgit/transport/URIish;", "GetGetURIHandler")]
			get {
				const string __id = "getURI.()Lorg/eclipse/jgit/transport/URIish;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OperationResult']/method[@name='getAdvertisedRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAdvertisedRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "")]
		public unsafe global::Org.Eclipse.Jgit.Lib.IRef GetAdvertisedRef (string name)
		{
			const string __id = "getAdvertisedRef.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getTrackingRefUpdate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrackingRefUpdate_Ljava_lang_String_Handler ()
		{
			if (cb_getTrackingRefUpdate_Ljava_lang_String_ == null)
				cb_getTrackingRefUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetTrackingRefUpdate_Ljava_lang_String_);
			return cb_getTrackingRefUpdate_Ljava_lang_String_;
		}

		static IntPtr n_GetTrackingRefUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_localName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.OperationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var localName = JNIEnv.GetString (native_localName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTrackingRefUpdate (localName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="localName">name of the local ref (e.g. "refs/remotes/origin/master").</param>
		/// <summary>Get the status for a specific local tracking ref update.</summary>
		/// <returns>status of the local ref; null if this local ref was not touched
		///         during this operation.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='OperationResult']/method[@name='getTrackingRefUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrackingRefUpdate", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/TrackingRefUpdate;", "GetGetTrackingRefUpdate_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate GetTrackingRefUpdate (string localName)
		{
			const string __id = "getTrackingRefUpdate.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/TrackingRefUpdate;";
			IntPtr native_localName = JNIEnv.NewString ((string)localName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_localName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_localName);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/OperationResult", DoNotGenerateAcw=true)]
	internal partial class OperationResultInvoker : OperationResult {
		public OperationResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/OperationResult", typeof (OperationResultInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
