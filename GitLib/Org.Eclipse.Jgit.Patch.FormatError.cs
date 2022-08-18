using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Patch {

	/// <summary>An error in a patch script</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/patch/FormatError", DoNotGenerateAcw=true)]
	public partial class FormatError : global::Java.Lang.Object {
		/// <summary>Classification of an error.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError.Severity']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/patch/FormatError$Severity", DoNotGenerateAcw=true)]
		public sealed partial class Severity : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError.Severity']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Org.Eclipse.Jgit.Patch.FormatError.Severity Error {
				get {
					const string __id = "ERROR.Lorg/eclipse/jgit/patch/FormatError$Severity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError.Severity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError.Severity']/field[@name='WARNING']"
			[Register ("WARNING")]
			public static global::Org.Eclipse.Jgit.Patch.FormatError.Severity Warning {
				get {
					const string __id = "WARNING.Lorg/eclipse/jgit/patch/FormatError$Severity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError.Severity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/FormatError$Severity", typeof (Severity));

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

			internal Severity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError.Severity']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/patch/FormatError$Severity;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Patch.FormatError.Severity ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/patch/FormatError$Severity;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError.Severity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError.Severity']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/patch/FormatError$Severity;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Patch.FormatError.Severity[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/patch/FormatError$Severity;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Patch.FormatError.Severity[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Patch.FormatError.Severity));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/FormatError", typeof (FormatError));

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

		protected FormatError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getLineText;
#pragma warning disable 0169
		static Delegate GetGetLineTextHandler ()
		{
			if (cb_getLineText == null)
				cb_getLineText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLineText);
			return cb_getLineText;
		}

		static IntPtr n_GetLineText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LineText);
		}
#pragma warning restore 0169

		/// <returns>line of the patch script the error appears on.</returns>
		public virtual unsafe string LineText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError']/method[@name='getLineText' and count(parameter)=0]"
			[Register ("getLineText", "()Ljava/lang/String;", "GetGetLineTextHandler")]
			get {
				const string __id = "getLineText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		/// <returns>a message describing the error.</returns>
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError']/method[@name='getMessage' and count(parameter)=0]"
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

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOffset);
			return cb_getOffset;
		}

		static int n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		/// <returns>byte offset within <c>#getBuffer()</c> where the error is</returns>
		public virtual unsafe int Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()I", "GetGetOffsetHandler")]
			get {
				const string __id = "getOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBuffer ());
		}
#pragma warning restore 0169

		/// <returns>the byte buffer holding the patch script.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError']/method[@name='getBuffer' and count(parameter)=0]"
		[Register ("getBuffer", "()[B", "GetGetBufferHandler")]
		public virtual unsafe byte[] GetBuffer ()
		{
			const string __id = "getBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getSeverity;
#pragma warning disable 0169
		static Delegate GetGetSeverityHandler ()
		{
			if (cb_getSeverity == null)
				cb_getSeverity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSeverity);
			return cb_getSeverity;
		}

		static IntPtr n_GetSeverity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSeverity ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FormatError']/method[@name='getSeverity' and count(parameter)=0]"
		[Register ("getSeverity", "()Lorg/eclipse/jgit/patch/FormatError$Severity;", "GetGetSeverityHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Patch.FormatError.Severity GetSeverity ()
		{
			const string __id = "getSeverity.()Lorg/eclipse/jgit/patch/FormatError$Severity;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FormatError.Severity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
