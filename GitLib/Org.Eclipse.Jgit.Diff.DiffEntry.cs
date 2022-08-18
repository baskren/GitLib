using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>A value class representing a change to a file</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/DiffEntry", DoNotGenerateAcw=true)]
	public partial class DiffEntry : global::Java.Lang.Object {
		/// <summary>Magical file name used for file adds or deletes.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/field[@name='DEV_NULL']"
		[Register ("DEV_NULL")]
		public const string DevNull = (string) "/dev/null";

		/// <summary>General type of change a single file-level patch describes.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.ChangeType']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/diff/DiffEntry$ChangeType", DoNotGenerateAcw=true)]
		public sealed partial class ChangeType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.ChangeType']/field[@name='ADD']"
			[Register ("ADD")]
			public static global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType Add {
				get {
					const string __id = "ADD.Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.ChangeType']/field[@name='COPY']"
			[Register ("COPY")]
			public static global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType Copy {
				get {
					const string __id = "COPY.Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.ChangeType']/field[@name='DELETE']"
			[Register ("DELETE")]
			public static global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType Delete {
				get {
					const string __id = "DELETE.Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.ChangeType']/field[@name='MODIFY']"
			[Register ("MODIFY")]
			public static global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType Modify {
				get {
					const string __id = "MODIFY.Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.ChangeType']/field[@name='RENAME']"
			[Register ("RENAME")]
			public static global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType Rename {
				get {
					const string __id = "RENAME.Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/DiffEntry$ChangeType", typeof (ChangeType));

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

			internal ChangeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.ChangeType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.ChangeType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType));
				} finally {
				}
			}

		}

		/// <summary>Specify the old or new side for more generalized access.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.Side']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/diff/DiffEntry$Side", DoNotGenerateAcw=true)]
		public sealed partial class Side : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.Side']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Org.Eclipse.Jgit.Diff.DiffEntry.Side New {
				get {
					const string __id = "NEW.Lorg/eclipse/jgit/diff/DiffEntry$Side;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.Side> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.Side']/field[@name='OLD']"
			[Register ("OLD")]
			public static global::Org.Eclipse.Jgit.Diff.DiffEntry.Side Old {
				get {
					const string __id = "OLD.Lorg/eclipse/jgit/diff/DiffEntry$Side;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.Side> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/DiffEntry$Side", typeof (Side));

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

			internal Side (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.Side']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/diff/DiffEntry$Side;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.DiffEntry.Side ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/diff/DiffEntry$Side;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.Side> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry.Side']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/diff/DiffEntry$Side;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.DiffEntry.Side[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/diff/DiffEntry$Side;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Diff.DiffEntry.Side[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Diff.DiffEntry.Side));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/DiffEntry", typeof (DiffEntry));

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

		protected DiffEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty DiffEntry</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/constructor[@name='DiffEntry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe DiffEntry () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewId);
		}
#pragma warning restore 0169

		/// <summary>Get the new object id from the &lt;code&gt;index&lt;/code&gt;.</summary>
		/// <returns>the object id; null if there is no index line</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId NewId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getNewId' and count(parameter)=0]"
			[Register ("getNewId", "()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetGetNewIdHandler")]
			get {
				const string __id = "getNewId.()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNewMode;
#pragma warning disable 0169
		static Delegate GetGetNewModeHandler ()
		{
			if (cb_getNewMode == null)
				cb_getNewMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewMode);
			return cb_getNewMode;
		}

		static IntPtr n_GetNewMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewMode);
		}
#pragma warning restore 0169

		/// <returns>the new file mode, if described in the patch</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode NewMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getNewMode' and count(parameter)=0]"
			[Register ("getNewMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetNewModeHandler")]
			get {
				const string __id = "getNewMode.()Lorg/eclipse/jgit/lib/FileMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNewPath;
#pragma warning disable 0169
		static Delegate GetGetNewPathHandler ()
		{
			if (cb_getNewPath == null)
				cb_getNewPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewPath);
			return cb_getNewPath;
		}

		static IntPtr n_GetNewPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NewPath);
		}
#pragma warning restore 0169

		/// <summary>Get the new name associated with this file.</summary>
		/// <returns>new name for this file.</returns>
		public virtual unsafe string NewPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getNewPath' and count(parameter)=0]"
			[Register ("getNewPath", "()Ljava/lang/String;", "GetGetNewPathHandler")]
			get {
				const string __id = "getNewPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldId);
		}
#pragma warning restore 0169

		/// <summary>Get the old object id from the &lt;code&gt;index&lt;/code&gt;.</summary>
		/// <returns>the object id; null if there is no index line</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId OldId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getOldId' and count(parameter)=0]"
			[Register ("getOldId", "()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetGetOldIdHandler")]
			get {
				const string __id = "getOldId.()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldMode;
#pragma warning disable 0169
		static Delegate GetGetOldModeHandler ()
		{
			if (cb_getOldMode == null)
				cb_getOldMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOldMode);
			return cb_getOldMode;
		}

		static IntPtr n_GetOldMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldMode);
		}
#pragma warning restore 0169

		/// <returns>the old file mode, if described in the patch</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode OldMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getOldMode' and count(parameter)=0]"
			[Register ("getOldMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetOldModeHandler")]
			get {
				const string __id = "getOldMode.()Lorg/eclipse/jgit/lib/FileMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldPath;
#pragma warning disable 0169
		static Delegate GetGetOldPathHandler ()
		{
			if (cb_getOldPath == null)
				cb_getOldPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOldPath);
			return cb_getOldPath;
		}

		static IntPtr n_GetOldPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OldPath);
		}
#pragma warning restore 0169

		/// <summary>Get the old name associated with this file.</summary>
		/// <returns>old name for this file.</returns>
		public virtual unsafe string OldPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getOldPath' and count(parameter)=0]"
			[Register ("getOldPath", "()Ljava/lang/String;", "GetGetOldPathHandler")]
			get {
				const string __id = "getOldPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScore;
#pragma warning disable 0169
		static Delegate GetGetScoreHandler ()
		{
			if (cb_getScore == null)
				cb_getScore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScore);
			return cb_getScore;
		}

		static int n_GetScore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Score;
		}
#pragma warning restore 0169

		/// <returns>similarity score between <c>#getOldPath()</c> and
		///         <c>#getNewPath()</c> if <c>#getChangeType()</c> is
		///         <c>ChangeType#COPY</c> or <c>ChangeType#RENAME</c>.</returns>
		public virtual unsafe int Score {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getScore' and count(parameter)=0]"
			[Register ("getScore", "()I", "GetGetScoreHandler")]
			get {
				const string __id = "getScore.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTreeFilterMarks;
#pragma warning disable 0169
		static Delegate GetGetTreeFilterMarksHandler ()
		{
			if (cb_getTreeFilterMarks == null)
				cb_getTreeFilterMarks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTreeFilterMarks);
			return cb_getTreeFilterMarks;
		}

		static int n_GetTreeFilterMarks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TreeFilterMarks;
		}
#pragma warning restore 0169

		/// <summary>Get the raw tree filter marks, as set during
		/// <c>#scan(TreeWalk, boolean, TreeFilter...)</c>.</summary>
		/// <returns>the bitset of tree filter marks</returns>
		public virtual unsafe int TreeFilterMarks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getTreeFilterMarks' and count(parameter)=0]"
			[Register ("getTreeFilterMarks", "()I", "GetGetTreeFilterMarksHandler")]
			get {
				const string __id = "getTreeFilterMarks.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getChangeType;
#pragma warning disable 0169
		static Delegate GetGetChangeTypeHandler ()
		{
			if (cb_getChangeType == null)
				cb_getChangeType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChangeType);
			return cb_getChangeType;
		}

		static IntPtr n_GetChangeType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetChangeType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getChangeType' and count(parameter)=0]"
		[Register ("getChangeType", "()Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;", "GetGetChangeTypeHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType GetChangeType ()
		{
			const string __id = "getChangeType.()Lorg/eclipse/jgit/diff/DiffEntry$ChangeType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.ChangeType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getId_Lorg_eclipse_jgit_diff_DiffEntry_Side_;
#pragma warning disable 0169
		static Delegate GetGetId_Lorg_eclipse_jgit_diff_DiffEntry_Side_Handler ()
		{
			if (cb_getId_Lorg_eclipse_jgit_diff_DiffEntry_Side_ == null)
				cb_getId_Lorg_eclipse_jgit_diff_DiffEntry_Side_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetId_Lorg_eclipse_jgit_diff_DiffEntry_Side_);
			return cb_getId_Lorg_eclipse_jgit_diff_DiffEntry_Side_;
		}

		static IntPtr n_GetId_Lorg_eclipse_jgit_diff_DiffEntry_Side_ (IntPtr jnienv, IntPtr native__this, IntPtr native_side)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var side = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.Side> (native_side, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetId (side));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry.Side']]"
		[Register ("getId", "(Lorg/eclipse/jgit/diff/DiffEntry$Side;)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetGetId_Lorg_eclipse_jgit_diff_DiffEntry_Side_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId GetId (global::Org.Eclipse.Jgit.Diff.DiffEntry.Side side)
		{
			const string __id = "getId.(Lorg/eclipse/jgit/diff/DiffEntry$Side;)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((side == null) ? IntPtr.Zero : ((global::Java.Lang.Object) side).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (side);
			}
		}

		static Delegate cb_getMode_Lorg_eclipse_jgit_diff_DiffEntry_Side_;
#pragma warning disable 0169
		static Delegate GetGetMode_Lorg_eclipse_jgit_diff_DiffEntry_Side_Handler ()
		{
			if (cb_getMode_Lorg_eclipse_jgit_diff_DiffEntry_Side_ == null)
				cb_getMode_Lorg_eclipse_jgit_diff_DiffEntry_Side_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMode_Lorg_eclipse_jgit_diff_DiffEntry_Side_);
			return cb_getMode_Lorg_eclipse_jgit_diff_DiffEntry_Side_;
		}

		static IntPtr n_GetMode_Lorg_eclipse_jgit_diff_DiffEntry_Side_ (IntPtr jnienv, IntPtr native__this, IntPtr native_side)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var side = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.Side> (native_side, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMode (side));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getMode' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry.Side']]"
		[Register ("getMode", "(Lorg/eclipse/jgit/diff/DiffEntry$Side;)Lorg/eclipse/jgit/lib/FileMode;", "GetGetMode_Lorg_eclipse_jgit_diff_DiffEntry_Side_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode GetMode (global::Org.Eclipse.Jgit.Diff.DiffEntry.Side side)
		{
			const string __id = "getMode.(Lorg/eclipse/jgit/diff/DiffEntry$Side;)Lorg/eclipse/jgit/lib/FileMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((side == null) ? IntPtr.Zero : ((global::Java.Lang.Object) side).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (side);
			}
		}

		static Delegate cb_getPath_Lorg_eclipse_jgit_diff_DiffEntry_Side_;
#pragma warning disable 0169
		static Delegate GetGetPath_Lorg_eclipse_jgit_diff_DiffEntry_Side_Handler ()
		{
			if (cb_getPath_Lorg_eclipse_jgit_diff_DiffEntry_Side_ == null)
				cb_getPath_Lorg_eclipse_jgit_diff_DiffEntry_Side_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPath_Lorg_eclipse_jgit_diff_DiffEntry_Side_);
			return cb_getPath_Lorg_eclipse_jgit_diff_DiffEntry_Side_;
		}

		static IntPtr n_GetPath_Lorg_eclipse_jgit_diff_DiffEntry_Side_ (IntPtr jnienv, IntPtr native__this, IntPtr native_side)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var side = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry.Side> (native_side, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPath (side));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='getPath' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry.Side']]"
		[Register ("getPath", "(Lorg/eclipse/jgit/diff/DiffEntry$Side;)Ljava/lang/String;", "GetGetPath_Lorg_eclipse_jgit_diff_DiffEntry_Side_Handler")]
		public virtual unsafe string GetPath (global::Org.Eclipse.Jgit.Diff.DiffEntry.Side side)
		{
			const string __id = "getPath.(Lorg/eclipse/jgit/diff/DiffEntry$Side;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((side == null) ? IntPtr.Zero : ((global::Java.Lang.Object) side).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (side);
			}
		}

		static Delegate cb_isMarked_I;
#pragma warning disable 0169
		static Delegate GetIsMarked_IHandler ()
		{
			if (cb_isMarked_I == null)
				cb_isMarked_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsMarked_I);
			return cb_isMarked_I;
		}

		static bool n_IsMarked_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMarked (index);
		}
#pragma warning restore 0169

		/// <param name="index">the index of the tree filter to check for (must be between 0
		///            and <c>Integer#SIZE</c>).</param>
		/// <summary>Whether the mark tree filter with the specified index matched during scan
		/// or not, see <c>#scan(TreeWalk, boolean, TreeFilter...)</c>.</summary>
		/// <returns>true, if the tree filter matched; false if not</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='isMarked' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isMarked", "(I)Z", "GetIsMarked_IHandler")]
		public virtual unsafe bool IsMarked (int index)
		{
			const string __id = "isMarked.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		/// <param name="walk">the TreeWalk to walk through. Must have exactly two trees.</param>
		/// <summary>Convert the TreeWalk into DiffEntry headers.</summary>
		/// <returns>headers describing the changed files.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='scan' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk']]"
		[Register ("scan", "(Lorg/eclipse/jgit/treewalk/TreeWalk;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Scan (global::Org.Eclipse.Jgit.Treewalk.TreeWalk walk)
		{
			const string __id = "scan.(Lorg/eclipse/jgit/treewalk/TreeWalk;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (walk);
			}
		}

		/// <param name="walk">the TreeWalk to walk through. Must have exactly two trees and
		///            when <c>includeTrees</c> parameter is <c>true</c> it can't
		///            be recursive.</param>
		/// <param name="includeTrees">include tree objects.</param>
		/// <summary>Convert the TreeWalk into DiffEntry headers, depending on
		/// <c>includeTrees</c> it will add tree objects into result or not.</summary>
		/// <returns>headers describing the changed files.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='scan' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk'] and parameter[2][@type='boolean']]"
		[Register ("scan", "(Lorg/eclipse/jgit/treewalk/TreeWalk;Z)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Scan (global::Org.Eclipse.Jgit.Treewalk.TreeWalk walk, bool includeTrees)
		{
			const string __id = "scan.(Lorg/eclipse/jgit/treewalk/TreeWalk;Z)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				__args [1] = new JniArgumentValue (includeTrees);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (walk);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffEntry']/method[@name='scan' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk'] and parameter[2][@type='boolean'] and parameter[3][@type='org.eclipse.jgit.treewalk.filter.TreeFilter[]']]"
		[Register ("scan", "(Lorg/eclipse/jgit/treewalk/TreeWalk;Z[Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Scan (global::Org.Eclipse.Jgit.Treewalk.TreeWalk walk, bool includeTrees, global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter[] markTreeFilters)
		{
			const string __id = "scan.(Lorg/eclipse/jgit/treewalk/TreeWalk;Z[Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Ljava/util/List;";
			IntPtr native_markTreeFilters = JNIEnv.NewArray (markTreeFilters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				__args [1] = new JniArgumentValue (includeTrees);
				__args [2] = new JniArgumentValue (native_markTreeFilters);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (markTreeFilters != null) {
					JNIEnv.CopyArray (native_markTreeFilters, markTreeFilters);
					JNIEnv.DeleteLocalRef (native_markTreeFilters);
				}
				global::System.GC.KeepAlive (walk);
				global::System.GC.KeepAlive (markTreeFilters);
			}
		}

	}
}
