using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Patch {

	/// <summary>Patch header describing an action for a single file path.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/patch/FileHeader", DoNotGenerateAcw=true)]
	public partial class FileHeader : global::Org.Eclipse.Jgit.Diff.DiffEntry {
		/// <summary>Type of patch used by this file.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader.PatchType']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/patch/FileHeader$PatchType", DoNotGenerateAcw=true)]
		public sealed partial class PatchType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader.PatchType']/field[@name='BINARY']"
			[Register ("BINARY")]
			public static global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType Binary {
				get {
					const string __id = "BINARY.Lorg/eclipse/jgit/patch/FileHeader$PatchType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader.PatchType']/field[@name='GIT_BINARY']"
			[Register ("GIT_BINARY")]
			public static global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType GitBinary {
				get {
					const string __id = "GIT_BINARY.Lorg/eclipse/jgit/patch/FileHeader$PatchType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader.PatchType']/field[@name='UNIFIED']"
			[Register ("UNIFIED")]
			public static global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType Unified {
				get {
					const string __id = "UNIFIED.Lorg/eclipse/jgit/patch/FileHeader$PatchType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/FileHeader$PatchType", typeof (PatchType));

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

			internal PatchType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader.PatchType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/patch/FileHeader$PatchType;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/patch/FileHeader$PatchType;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader.PatchType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/patch/FileHeader$PatchType;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/patch/FileHeader$PatchType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/FileHeader", typeof (FileHeader));

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

		protected FileHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/constructor[@name='FileHeader' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='org.eclipse.jgit.diff.EditList'] and parameter[3][@type='org.eclipse.jgit.patch.FileHeader.PatchType']]"
		[Register (".ctor", "([BLorg/eclipse/jgit/diff/EditList;Lorg/eclipse/jgit/patch/FileHeader$PatchType;)V", "")]
		public unsafe FileHeader (byte[] headerLines, global::Org.Eclipse.Jgit.Diff.EditList edits, global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BLorg/eclipse/jgit/diff/EditList;Lorg/eclipse/jgit/patch/FileHeader$PatchType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_headerLines = JNIEnv.NewArray (headerLines);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_headerLines);
				__args [1] = new JniArgumentValue ((edits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) edits).Handle);
				__args [2] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (headerLines != null) {
					JNIEnv.CopyArray (native_headerLines, headerLines);
					JNIEnv.DeleteLocalRef (native_headerLines);
				}
				global::System.GC.KeepAlive (headerLines);
				global::System.GC.KeepAlive (edits);
				global::System.GC.KeepAlive (type);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndOffset;
		}
#pragma warning restore 0169

		/// <returns>offset one past the end of the file script.</returns>
		public virtual unsafe int EndOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='getEndOffset' and count(parameter)=0]"
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

		static Delegate cb_getForwardBinaryHunk;
#pragma warning disable 0169
		static Delegate GetGetForwardBinaryHunkHandler ()
		{
			if (cb_getForwardBinaryHunk == null)
				cb_getForwardBinaryHunk = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetForwardBinaryHunk);
			return cb_getForwardBinaryHunk;
		}

		static IntPtr n_GetForwardBinaryHunk (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForwardBinaryHunk);
		}
#pragma warning restore 0169

		/// <returns>if a <c>PatchType#GIT_BINARY</c>, the new-image delta/literal</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Patch.BinaryHunk ForwardBinaryHunk {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='getForwardBinaryHunk' and count(parameter)=0]"
			[Register ("getForwardBinaryHunk", "()Lorg/eclipse/jgit/patch/BinaryHunk;", "GetGetForwardBinaryHunkHandler")]
			get {
				const string __id = "getForwardBinaryHunk.()Lorg/eclipse/jgit/patch/BinaryHunk;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasMetaDataChanges;
#pragma warning disable 0169
		static Delegate GetHasMetaDataChangesHandler ()
		{
			if (cb_hasMetaDataChanges == null)
				cb_hasMetaDataChanges = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasMetaDataChanges);
			return cb_hasMetaDataChanges;
		}

		static bool n_HasMetaDataChanges (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMetaDataChanges;
		}
#pragma warning restore 0169

		/// <returns>true if this patch modifies metadata about a file</returns>
		public virtual unsafe bool HasMetaDataChanges {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='hasMetaDataChanges' and count(parameter)=0]"
			[Register ("hasMetaDataChanges", "()Z", "GetHasMetaDataChangesHandler")]
			get {
				const string __id = "hasMetaDataChanges.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHunks;
#pragma warning disable 0169
		static Delegate GetGetHunksHandler ()
		{
			if (cb_getHunks == null)
				cb_getHunks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHunks);
			return cb_getHunks;
		}

		static IntPtr n_GetHunks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Patch.HunkHeader>.ToLocalJniHandle (__this.Hunks);
		}
#pragma warning restore 0169

		/// <returns>hunks altering this file; in order of appearance in patch</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Patch.HunkHeader> Hunks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='getHunks' and count(parameter)=0]"
			[Register ("getHunks", "()Ljava/util/List;", "GetGetHunksHandler")]
			get {
				const string __id = "getHunks.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Patch.HunkHeader>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReverseBinaryHunk;
#pragma warning disable 0169
		static Delegate GetGetReverseBinaryHunkHandler ()
		{
			if (cb_getReverseBinaryHunk == null)
				cb_getReverseBinaryHunk = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReverseBinaryHunk);
			return cb_getReverseBinaryHunk;
		}

		static IntPtr n_GetReverseBinaryHunk (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReverseBinaryHunk);
		}
#pragma warning restore 0169

		/// <returns>if a <c>PatchType#GIT_BINARY</c>, the old-image delta/literal</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Patch.BinaryHunk ReverseBinaryHunk {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='getReverseBinaryHunk' and count(parameter)=0]"
			[Register ("getReverseBinaryHunk", "()Lorg/eclipse/jgit/patch/BinaryHunk;", "GetGetReverseBinaryHunkHandler")]
			get {
				const string __id = "getReverseBinaryHunk.()Lorg/eclipse/jgit/patch/BinaryHunk;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.BinaryHunk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScriptText;
#pragma warning disable 0169
		static Delegate GetGetScriptTextHandler ()
		{
			if (cb_getScriptText == null)
				cb_getScriptText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScriptText);
			return cb_getScriptText;
		}

		static IntPtr n_GetScriptText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScriptText);
		}
#pragma warning restore 0169

		/// <summary>Convert the patch script for this file into a string.</summary>
		/// <returns>the patch script, as a Unicode string.</returns>
		public virtual unsafe string ScriptText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='getScriptText' and count(parameter)=0]"
			[Register ("getScriptText", "()Ljava/lang/String;", "GetGetScriptTextHandler")]
			get {
				const string __id = "getScriptText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartOffset;
		}
#pragma warning restore 0169

		/// <returns>offset the start of this file's script in <c>#getBuffer()</c>.</returns>
		public virtual unsafe int StartOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='getStartOffset' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBuffer ());
		}
#pragma warning restore 0169

		/// <returns>the byte array holding this file's patch script.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='getBuffer' and count(parameter)=0]"
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

		static Delegate cb_getPatchType;
#pragma warning disable 0169
		static Delegate GetGetPatchTypeHandler ()
		{
			if (cb_getPatchType == null)
				cb_getPatchType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPatchType);
			return cb_getPatchType;
		}

		static IntPtr n_GetPatchType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPatchType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='getPatchType' and count(parameter)=0]"
		[Register ("getPatchType", "()Lorg/eclipse/jgit/patch/FileHeader$PatchType;", "GetGetPatchTypeHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType GetPatchType ()
		{
			const string __id = "getPatchType.()Lorg/eclipse/jgit/patch/FileHeader$PatchType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader.PatchType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getScriptText_Ljava_nio_charset_Charset_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetGetScriptText_Ljava_nio_charset_Charset_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_getScriptText_Ljava_nio_charset_Charset_Ljava_nio_charset_Charset_ == null)
				cb_getScriptText_Ljava_nio_charset_Charset_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetScriptText_Ljava_nio_charset_Charset_Ljava_nio_charset_Charset_);
			return cb_getScriptText_Ljava_nio_charset_Charset_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_GetScriptText_Ljava_nio_charset_Charset_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldCharset, IntPtr native_newCharset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oldCharset = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_oldCharset, JniHandleOwnership.DoNotTransfer);
			var newCharset = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_newCharset, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetScriptText (oldCharset, newCharset));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="oldCharset">hint character set to decode the old lines with.</param>
		/// <param name="newCharset">hint character set to decode the new lines with.</param>
		/// <summary>Convert the patch script for this file into a string.</summary>
		/// <returns>the patch script, as a Unicode string.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='getScriptText' and count(parameter)=2 and parameter[1][@type='java.nio.charset.Charset'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("getScriptText", "(Ljava/nio/charset/Charset;Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetGetScriptText_Ljava_nio_charset_Charset_Ljava_nio_charset_Charset_Handler")]
		public virtual unsafe string GetScriptText (global::Java.Nio.Charset.Charset oldCharset, global::Java.Nio.Charset.Charset newCharset)
		{
			const string __id = "getScriptText.(Ljava/nio/charset/Charset;Ljava/nio/charset/Charset;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((oldCharset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldCharset).Handle);
				__args [1] = new JniArgumentValue ((newCharset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newCharset).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (oldCharset);
				global::System.GC.KeepAlive (newCharset);
			}
		}

		static Delegate cb_toEditList;
#pragma warning disable 0169
		static Delegate GetToEditListHandler ()
		{
			if (cb_toEditList == null)
				cb_toEditList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToEditList);
			return cb_toEditList;
		}

		static IntPtr n_ToEditList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.FileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToEditList ());
		}
#pragma warning restore 0169

		/// <returns>a list describing the content edits performed on this file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='FileHeader']/method[@name='toEditList' and count(parameter)=0]"
		[Register ("toEditList", "()Lorg/eclipse/jgit/diff/EditList;", "GetToEditListHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.EditList ToEditList ()
		{
			const string __id = "toEditList.()Lorg/eclipse/jgit/diff/EditList;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.EditList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
