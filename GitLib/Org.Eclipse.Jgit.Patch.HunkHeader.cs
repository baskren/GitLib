using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Patch {

	/// <summary>Hunk header describing the layout of a single block of lines</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/patch/HunkHeader", DoNotGenerateAcw=true)]
	public partial class HunkHeader : global::Java.Lang.Object {
		/// <summary>Details about an old image of the file.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader.OldImage']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/patch/HunkHeader$OldImage", DoNotGenerateAcw=true)]
		public abstract partial class OldImage : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/HunkHeader$OldImage", typeof (OldImage));

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

			protected OldImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader.OldImage']/constructor[@name='HunkHeader.OldImage' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OldImage () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_getId;
#pragma warning disable 0169
			static Delegate GetGetIdHandler ()
			{
				if (cb_getId == null)
					cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetId);
				return cb_getId;
			}

			static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader.OldImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Id);
			}
#pragma warning restore 0169

			public abstract global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader.OldImage']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetGetIdHandler")]
				get; 
			}

			static Delegate cb_getLineCount;
#pragma warning disable 0169
			static Delegate GetGetLineCountHandler ()
			{
				if (cb_getLineCount == null)
					cb_getLineCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLineCount);
				return cb_getLineCount;
			}

			static int n_GetLineCount (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader.OldImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LineCount;
			}
#pragma warning restore 0169

			/// <returns>total number of lines this hunk covers in this file.</returns>
			public virtual unsafe int LineCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader.OldImage']/method[@name='getLineCount' and count(parameter)=0]"
				[Register ("getLineCount", "()I", "GetGetLineCountHandler")]
				get {
					const string __id = "getLineCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getLinesAdded;
#pragma warning disable 0169
			static Delegate GetGetLinesAddedHandler ()
			{
				if (cb_getLinesAdded == null)
					cb_getLinesAdded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLinesAdded);
				return cb_getLinesAdded;
			}

			static int n_GetLinesAdded (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader.OldImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LinesAdded;
			}
#pragma warning restore 0169

			/// <returns>number of lines added by the post-image not in this file.</returns>
			public virtual unsafe int LinesAdded {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader.OldImage']/method[@name='getLinesAdded' and count(parameter)=0]"
				[Register ("getLinesAdded", "()I", "GetGetLinesAddedHandler")]
				get {
					const string __id = "getLinesAdded.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getLinesDeleted;
#pragma warning disable 0169
			static Delegate GetGetLinesDeletedHandler ()
			{
				if (cb_getLinesDeleted == null)
					cb_getLinesDeleted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLinesDeleted);
				return cb_getLinesDeleted;
			}

			static int n_GetLinesDeleted (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader.OldImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LinesDeleted;
			}
#pragma warning restore 0169

			/// <returns>number of lines deleted by the post-image from this file.</returns>
			public virtual unsafe int LinesDeleted {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader.OldImage']/method[@name='getLinesDeleted' and count(parameter)=0]"
				[Register ("getLinesDeleted", "()I", "GetGetLinesDeletedHandler")]
				get {
					const string __id = "getLinesDeleted.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getStartLine;
#pragma warning disable 0169
			static Delegate GetGetStartLineHandler ()
			{
				if (cb_getStartLine == null)
					cb_getStartLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStartLine);
				return cb_getStartLine;
			}

			static int n_GetStartLine (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader.OldImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StartLine;
			}
#pragma warning restore 0169

			/// <returns>first line number the hunk starts on in this file.</returns>
			public virtual unsafe int StartLine {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader.OldImage']/method[@name='getStartLine' and count(parameter)=0]"
				[Register ("getStartLine", "()I", "GetGetStartLineHandler")]
				get {
					const string __id = "getStartLine.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/patch/HunkHeader$OldImage", DoNotGenerateAcw=true)]
		internal partial class OldImageInvoker : OldImage {
			public OldImageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/HunkHeader$OldImage", typeof (OldImageInvoker));

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

			/// <returns>object id of the pre-image file.</returns>
			public override unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader.OldImage']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetGetIdHandler")]
				get {
					const string __id = "getId.()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/HunkHeader", typeof (HunkHeader));

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

		protected HunkHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndOffset;
		}
#pragma warning restore 0169

		/// <returns>offset one past the end of the hunk in <c>#getBuffer()</c>.</returns>
		public virtual unsafe int EndOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']/method[@name='getEndOffset' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileHeader);
		}
#pragma warning restore 0169

		/// <returns>header for the file this hunk applies to</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Patch.FileHeader FileHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']/method[@name='getFileHeader' and count(parameter)=0]"
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

		static Delegate cb_getLinesContext;
#pragma warning disable 0169
		static Delegate GetGetLinesContextHandler ()
		{
			if (cb_getLinesContext == null)
				cb_getLinesContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLinesContext);
			return cb_getLinesContext;
		}

		static int n_GetLinesContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LinesContext;
		}
#pragma warning restore 0169

		/// <returns>total number of lines of context appearing in this hunk</returns>
		public virtual unsafe int LinesContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']/method[@name='getLinesContext' and count(parameter)=0]"
			[Register ("getLinesContext", "()I", "GetGetLinesContextHandler")]
			get {
				const string __id = "getLinesContext.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNewLineCount;
#pragma warning disable 0169
		static Delegate GetGetNewLineCountHandler ()
		{
			if (cb_getNewLineCount == null)
				cb_getNewLineCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNewLineCount);
			return cb_getNewLineCount;
		}

		static int n_GetNewLineCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NewLineCount;
		}
#pragma warning restore 0169

		/// <returns>Total number of post-image lines this hunk covers</returns>
		public virtual unsafe int NewLineCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']/method[@name='getNewLineCount' and count(parameter)=0]"
			[Register ("getNewLineCount", "()I", "GetGetNewLineCountHandler")]
			get {
				const string __id = "getNewLineCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNewStartLine;
#pragma warning disable 0169
		static Delegate GetGetNewStartLineHandler ()
		{
			if (cb_getNewStartLine == null)
				cb_getNewStartLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNewStartLine);
			return cb_getNewStartLine;
		}

		static int n_GetNewStartLine (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NewStartLine;
		}
#pragma warning restore 0169

		/// <returns>first line number in the post-image file where the hunk starts</returns>
		public virtual unsafe int NewStartLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']/method[@name='getNewStartLine' and count(parameter)=0]"
			[Register ("getNewStartLine", "()I", "GetGetNewStartLineHandler")]
			get {
				const string __id = "getNewStartLine.()I";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartOffset;
		}
#pragma warning restore 0169

		/// <returns>offset the start of this hunk in <c>#getBuffer()</c>.</returns>
		public virtual unsafe int StartOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']/method[@name='getStartOffset' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBuffer ());
		}
#pragma warning restore 0169

		/// <returns>the byte array holding this hunk's patch script.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']/method[@name='getBuffer' and count(parameter)=0]"
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

		static Delegate cb_getOldImage;
#pragma warning disable 0169
		static Delegate GetGetOldImageHandler ()
		{
			if (cb_getOldImage == null)
				cb_getOldImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOldImage);
			return cb_getOldImage;
		}

		static IntPtr n_GetOldImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOldImage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']/method[@name='getOldImage' and count(parameter)=0]"
		[Register ("getOldImage", "()Lorg/eclipse/jgit/patch/HunkHeader$OldImage;", "GetGetOldImageHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Patch.HunkHeader.OldImage GetOldImage ()
		{
			const string __id = "getOldImage.()Lorg/eclipse/jgit/patch/HunkHeader$OldImage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader.OldImage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.HunkHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToEditList ());
		}
#pragma warning restore 0169

		/// <returns>a list describing the content edits performed within the hunk.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='HunkHeader']/method[@name='toEditList' and count(parameter)=0]"
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
