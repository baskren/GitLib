using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Patch {

	/// <summary>Part of a "GIT binary patch" to describe the pre-image or post-image</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/patch/BinaryHunk", DoNotGenerateAcw=true)]
	public partial class BinaryHunk : global::Java.Lang.Object {
		/// <summary>Type of information stored in a binary hunk.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk.Type']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/patch/BinaryHunk$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk.Type']/field[@name='DELTA_DEFLATED']"
			[Register ("DELTA_DEFLATED")]
			public static global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type DeltaDeflated {
				get {
					const string __id = "DELTA_DEFLATED.Lorg/eclipse/jgit/patch/BinaryHunk$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk.Type']/field[@name='LITERAL_DEFLATED']"
			[Register ("LITERAL_DEFLATED")]
			public static global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type LiteralDeflated {
				get {
					const string __id = "LITERAL_DEFLATED.Lorg/eclipse/jgit/patch/BinaryHunk$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/BinaryHunk$Type", typeof (Type));

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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/patch/BinaryHunk$Type;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/patch/BinaryHunk$Type;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/patch/BinaryHunk$Type;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/patch/BinaryHunk$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/BinaryHunk", typeof (BinaryHunk));

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

		protected BinaryHunk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getEndOffset;
#pragma warning disable 0169
		static Delegate GetGetEndOffsetHandler ()
		{
			if (cb_getEndOffset == null)
				cb_getEndOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEndOffset);
			return cb_getEndOffset;
		}

		static int n_GetEndOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndOffset;
		}
#pragma warning restore 0169

		/// <returns>offset one past the end of the hunk in <c>#getBuffer()</c>.</returns>
		public virtual unsafe int EndOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk']/method[@name='getEndOffset' and count(parameter)=0]"
			[Register ("getEndOffset", "()I", "GetGetEndOffsetHandler")]
			get {
				const string __id = "getEndOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFileHeader;
#pragma warning disable 0169
		static Delegate GetGetFileHeaderHandler ()
		{
			if (cb_getFileHeader == null)
				cb_getFileHeader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFileHeader);
			return cb_getFileHeader;
		}

		static IntPtr n_GetFileHeader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileHeader);
		}
#pragma warning restore 0169

		/// <returns>header for the file this hunk applies to</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Patch.FileHeader FileHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk']/method[@name='getFileHeader' and count(parameter)=0]"
			[Register ("getFileHeader", "()Lorg/eclipse/jgit/patch/FileHeader;", "GetGetFileHeaderHandler")]
			get {
				const string __id = "getFileHeader.()Lorg/eclipse/jgit/patch/FileHeader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		/// <returns>inflated size of this hunk's data</returns>
		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStartOffset;
#pragma warning disable 0169
		static Delegate GetGetStartOffsetHandler ()
		{
			if (cb_getStartOffset == null)
				cb_getStartOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStartOffset);
			return cb_getStartOffset;
		}

		static int n_GetStartOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartOffset;
		}
#pragma warning restore 0169

		/// <returns>offset the start of this hunk in <c>#getBuffer()</c>.</returns>
		public virtual unsafe int StartOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk']/method[@name='getStartOffset' and count(parameter)=0]"
			[Register ("getStartOffset", "()I", "GetGetStartOffsetHandler")]
			get {
				const string __id = "getStartOffset.()I";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBuffer ());
		}
#pragma warning restore 0169

		/// <returns>the byte array holding this hunk's patch script.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk']/method[@name='getBuffer' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='BinaryHunk']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lorg/eclipse/jgit/patch/BinaryHunk$Type;", "GetGetTypeHandler")]
		public new virtual unsafe global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type GetType ()
		{
			const string __id = "getType.()Lorg/eclipse/jgit/patch/BinaryHunk$Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
