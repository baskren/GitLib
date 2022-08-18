using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api.Errors {

	/// <summary>Exception thrown when a command wants to update a ref but failed because
	/// another process is accessing (or even also updating) the ref.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='ConcurrentRefUpdateException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/errors/ConcurrentRefUpdateException", DoNotGenerateAcw=true)]
	public partial class ConcurrentRefUpdateException : global::Org.Eclipse.Jgit.Api.Errors.GitAPIException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/errors/ConcurrentRefUpdateException", typeof (ConcurrentRefUpdateException));

		internal static new IntPtr class_ref {
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

		protected ConcurrentRefUpdateException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='ConcurrentRefUpdateException']/constructor[@name='ConcurrentRefUpdateException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.Ref'] and parameter[3][@type='org.eclipse.jgit.lib.RefUpdate.Result']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/RefUpdate$Result;)V", "")]
		public unsafe ConcurrentRefUpdateException (string message, global::Org.Eclipse.Jgit.Lib.IRef @ref, global::Org.Eclipse.Jgit.Lib.RefUpdate.Result rc) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/RefUpdate$Result;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				__args [2] = new JniArgumentValue ((rc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rc).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (@ref);
				global::System.GC.KeepAlive (rc);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='ConcurrentRefUpdateException']/constructor[@name='ConcurrentRefUpdateException' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.Ref'] and parameter[3][@type='org.eclipse.jgit.lib.RefUpdate.Result'] and parameter[4][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/RefUpdate$Result;Ljava/lang/Throwable;)V", "")]
		public unsafe ConcurrentRefUpdateException (string message, global::Org.Eclipse.Jgit.Lib.IRef @ref, global::Org.Eclipse.Jgit.Lib.RefUpdate.Result rc, global::Java.Lang.Throwable cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/RefUpdate$Result;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				__args [2] = new JniArgumentValue ((rc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rc).Handle);
				__args [3] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (@ref);
				global::System.GC.KeepAlive (rc);
				global::System.GC.KeepAlive (cause);
			}
		}

		static Delegate cb_getRef;
#pragma warning disable 0169
		static Delegate GetGetRefHandler ()
		{
			if (cb_getRef == null)
				cb_getRef = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRef);
			return cb_getRef;
		}

		static IntPtr n_GetRef (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Errors.ConcurrentRefUpdateException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ref);
		}
#pragma warning restore 0169

		/// <returns>the <c>Ref</c> which was tried to by updated</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IRef Ref {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='ConcurrentRefUpdateException']/method[@name='getRef' and count(parameter)=0]"
			[Register ("getRef", "()Lorg/eclipse/jgit/lib/Ref;", "GetGetRefHandler")]
			get {
				const string __id = "getRef.()Lorg/eclipse/jgit/lib/Ref;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.Errors.ConcurrentRefUpdateException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate.Result Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api.errors']/class[@name='ConcurrentRefUpdateException']/method[@name='getResult' and count(parameter)=0]"
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

	}
}
