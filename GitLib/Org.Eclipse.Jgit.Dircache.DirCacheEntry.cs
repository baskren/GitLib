using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Dircache {

	/// <summary>A single file (or stage of a file) in a <c>DirCache</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheEntry", DoNotGenerateAcw=true)]
	public partial class DirCacheEntry : global::Java.Lang.Object {
		/// <summary>The standard (fully merged) stage for an entry.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/field[@name='STAGE_0']"
		[Register ("STAGE_0")]
		public const int Stage0 = (int) 0;

		/// <summary>The base tree revision for an entry.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/field[@name='STAGE_1']"
		[Register ("STAGE_1")]
		public const int Stage1 = (int) 1;

		/// <summary>The first tree revision (usually called "ours").</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/field[@name='STAGE_2']"
		[Register ("STAGE_2")]
		public const int Stage2 = (int) 2;

		/// <summary>The second tree revision (usually called "theirs").</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/field[@name='STAGE_3']"
		[Register ("STAGE_3")]
		public const int Stage3 = (int) 3;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheEntry", typeof (DirCacheEntry));

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

		protected DirCacheEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="newPath">name of the cache entry, in the standard encoding.</param>
		/// <summary>Create an empty entry at stage 0.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/constructor[@name='DirCacheEntry' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe DirCacheEntry (byte[] newPath) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_newPath = JNIEnv.NewArray (newPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newPath);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (newPath != null) {
					JNIEnv.CopyArray (native_newPath, newPath);
					JNIEnv.DeleteLocalRef (native_newPath);
				}
				global::System.GC.KeepAlive (newPath);
			}
		}

		/// <param name="newPath">name of the cache entry, in the standard encoding.</param>
		/// <param name="stage">the stage index of the new entry.</param>
		/// <summary>Create an empty entry at the specified stage.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/constructor[@name='DirCacheEntry' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([BI)V", "")]
		public unsafe DirCacheEntry (byte[] newPath, int stage) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_newPath = JNIEnv.NewArray (newPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_newPath);
				__args [1] = new JniArgumentValue (stage);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (newPath != null) {
					JNIEnv.CopyArray (native_newPath, newPath);
					JNIEnv.DeleteLocalRef (native_newPath);
				}
				global::System.GC.KeepAlive (newPath);
			}
		}

		/// <param name="newPath">name of the cache entry.</param>
		/// <summary>Create an empty entry at stage 0.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/constructor[@name='DirCacheEntry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DirCacheEntry (string newPath) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_newPath = JNIEnv.NewString ((string)newPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newPath);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newPath);
			}
		}

		/// <param name="newPath">name of the cache entry.</param>
		/// <param name="stage">the stage index of the new entry.</param>
		/// <summary>Create an empty entry at the specified stage.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/constructor[@name='DirCacheEntry' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe DirCacheEntry (string newPath, int stage) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_newPath = JNIEnv.NewString ((string)newPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_newPath);
				__args [1] = new JniArgumentValue (stage);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newPath);
			}
		}

		static Delegate cb_isAssumeValid;
#pragma warning disable 0169
		static Delegate GetIsAssumeValidHandler ()
		{
			if (cb_isAssumeValid == null)
				cb_isAssumeValid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAssumeValid);
			return cb_isAssumeValid;
		}

		static bool n_IsAssumeValid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AssumeValid;
		}
#pragma warning restore 0169

		static Delegate cb_setAssumeValid_Z;
#pragma warning disable 0169
		static Delegate GetSetAssumeValid_ZHandler ()
		{
			if (cb_setAssumeValid_Z == null)
				cb_setAssumeValid_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAssumeValid_Z);
			return cb_setAssumeValid_Z;
		}

		static void n_SetAssumeValid_Z (IntPtr jnienv, IntPtr native__this, bool assume)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AssumeValid = assume;
		}
#pragma warning restore 0169

		/// <summary>Is this entry always thought to be unmodified? -or- Set the assume valid flag for this entry,</summary>
		/// <returns>true if we must assume the entry is unmodified.</returns>
		/// <param name="assume">true to ignore apparent modifications; false to look at last
		///            modified to detect file modifications.</param>
		public virtual unsafe bool AssumeValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='isAssumeValid' and count(parameter)=0]"
			[Register ("isAssumeValid", "()Z", "GetIsAssumeValidHandler")]
			get {
				const string __id = "isAssumeValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='setAssumeValid' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAssumeValid", "(Z)V", "GetSetAssumeValid_ZHandler")]
			set {
				const string __id = "setAssumeValid.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCreationTime;
#pragma warning disable 0169
		static Delegate GetGetCreationTimeHandler ()
		{
			if (cb_getCreationTime == null)
				cb_getCreationTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCreationTime);
			return cb_getCreationTime;
		}

		static long n_GetCreationTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreationTime;
		}
#pragma warning restore 0169

		static Delegate cb_setCreationTime_J;
#pragma warning disable 0169
		static Delegate GetSetCreationTime_JHandler ()
		{
			if (cb_setCreationTime_J == null)
				cb_setCreationTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetCreationTime_J);
			return cb_setCreationTime_J;
		}

		static void n_SetCreationTime_J (IntPtr jnienv, IntPtr native__this, long when)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreationTime = when;
		}
#pragma warning restore 0169

		/// <summary>Get the cached creation time of this file, in milliseconds. -or- Set the cached creation time of this file, using milliseconds.</summary>
		/// <returns>cached creation time of this file, in milliseconds since the
		///         Java epoch (midnight Jan 1, 1970 UTC).</returns>
		/// <param name="when">new cached creation time of the file, in milliseconds.</param>
		public virtual unsafe long CreationTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='getCreationTime' and count(parameter)=0]"
			[Register ("getCreationTime", "()J", "GetGetCreationTimeHandler")]
			get {
				const string __id = "getCreationTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='setCreationTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCreationTime", "(J)V", "GetSetCreationTime_JHandler")]
			set {
				const string __id = "setCreationTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFileMode;
#pragma warning disable 0169
		static Delegate GetGetFileModeHandler ()
		{
			if (cb_getFileMode == null)
				cb_getFileMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFileMode);
			return cb_getFileMode;
		}

		static IntPtr n_GetFileMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileMode);
		}
#pragma warning restore 0169

		static Delegate cb_setFileMode_Lorg_eclipse_jgit_lib_FileMode_;
#pragma warning disable 0169
		static Delegate GetSetFileMode_Lorg_eclipse_jgit_lib_FileMode_Handler ()
		{
			if (cb_setFileMode_Lorg_eclipse_jgit_lib_FileMode_ == null)
				cb_setFileMode_Lorg_eclipse_jgit_lib_FileMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFileMode_Lorg_eclipse_jgit_lib_FileMode_);
			return cb_setFileMode_Lorg_eclipse_jgit_lib_FileMode_;
		}

		static void n_SetFileMode_Lorg_eclipse_jgit_lib_FileMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			__this.FileMode = mode;
		}
#pragma warning restore 0169

		/// <summary>Obtain the <c>FileMode</c> for this entry. -or- Set the file mode for this entry.</summary>
		/// <returns>the file mode singleton for this entry.</returns>
		/// <param name="mode">the new mode constant.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode FileMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='getFileMode' and count(parameter)=0]"
			[Register ("getFileMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetFileModeHandler")]
			get {
				const string __id = "getFileMode.()Lorg/eclipse/jgit/lib/FileMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='setFileMode' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.FileMode']]"
			[Register ("setFileMode", "(Lorg/eclipse/jgit/lib/FileMode;)V", "GetSetFileMode_Lorg_eclipse_jgit_lib_FileMode_Handler")]
			set {
				const string __id = "setFileMode.(Lorg/eclipse/jgit/lib/FileMode;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isIntentToAdd;
#pragma warning disable 0169
		static Delegate GetIsIntentToAddHandler ()
		{
			if (cb_isIntentToAdd == null)
				cb_isIntentToAdd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIntentToAdd);
			return cb_isIntentToAdd;
		}

		static bool n_IsIntentToAdd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIntentToAdd;
		}
#pragma warning restore 0169

		/// <summary>Returns whether this entry is intent to be added to the Index.</summary>
		/// <returns>true if this entry is intent to add.</returns>
		public virtual unsafe bool IsIntentToAdd {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='isIntentToAdd' and count(parameter)=0]"
			[Register ("isIntentToAdd", "()Z", "GetIsIntentToAddHandler")]
			get {
				const string __id = "isIntentToAdd.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isMerged;
#pragma warning disable 0169
		static Delegate GetIsMergedHandler ()
		{
			if (cb_isMerged == null)
				cb_isMerged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMerged);
			return cb_isMerged;
		}

		static bool n_IsMerged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMerged;
		}
#pragma warning restore 0169

		/// <summary>Returns whether this entry is in the fully-merged stage (0).</summary>
		/// <returns>true if this entry is merged</returns>
		public virtual unsafe bool IsMerged {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='isMerged' and count(parameter)=0]"
			[Register ("isMerged", "()Z", "GetIsMergedHandler")]
			get {
				const string __id = "isMerged.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSkipWorkTree;
#pragma warning disable 0169
		static Delegate GetIsSkipWorkTreeHandler ()
		{
			if (cb_isSkipWorkTree == null)
				cb_isSkipWorkTree = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSkipWorkTree);
			return cb_isSkipWorkTree;
		}

		static bool n_IsSkipWorkTree (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSkipWorkTree;
		}
#pragma warning restore 0169

		/// <summary>Returns whether this entry should be skipped from the working tree.</summary>
		/// <returns>true if this entry should be skipepd.</returns>
		public virtual unsafe bool IsSkipWorkTree {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='isSkipWorkTree' and count(parameter)=0]"
			[Register ("isSkipWorkTree", "()Z", "GetIsSkipWorkTreeHandler")]
			get {
				const string __id = "isSkipWorkTree.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Check whether this entry has been smudged or not</summary>
		/// <returns>&lt;code&gt;true&lt;/code&gt; if the entry is smudged, &lt;code&gt;false&lt;/code&gt;
		///         otherwise</returns>
		public unsafe bool IsSmudged {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='isSmudged' and count(parameter)=0]"
			[Register ("isSmudged", "()Z", "")]
			get {
				const string __id = "isSmudged.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastModified;
#pragma warning disable 0169
		static Delegate GetGetLastModifiedHandler ()
		{
			if (cb_getLastModified == null)
				cb_getLastModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLastModified);
			return cb_getLastModified;
		}

		static long n_GetLastModified (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastModified;
		}
#pragma warning restore 0169

		static Delegate cb_setLastModified_J;
#pragma warning disable 0169
		static Delegate GetSetLastModified_JHandler ()
		{
			if (cb_setLastModified_J == null)
				cb_setLastModified_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetLastModified_J);
			return cb_setLastModified_J;
		}

		static void n_SetLastModified_J (IntPtr jnienv, IntPtr native__this, long when)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastModified = when;
		}
#pragma warning restore 0169

		/// <summary>Get the cached last modification date of this file, in milliseconds. -or- Set the cached last modification date of this file, using milliseconds.</summary>
		/// <returns>last modification time of this file, in milliseconds since the
		///         Java epoch (midnight Jan 1, 1970 UTC).</returns>
		/// <param name="when">new cached modification date of the file, in milliseconds.</param>
		public virtual unsafe long LastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='getLastModified' and count(parameter)=0]"
			[Register ("getLastModified", "()J", "GetGetLastModifiedHandler")]
			get {
				const string __id = "getLastModified.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='setLastModified' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastModified", "(J)V", "GetSetLastModified_JHandler")]
			set {
				const string __id = "setLastModified.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLength;
#pragma warning disable 0169
		static Delegate GetGetLengthHandler ()
		{
			if (cb_getLength == null)
				cb_getLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLength);
			return cb_getLength;
		}

		static int n_GetLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		static Delegate cb_setLength_I;
#pragma warning disable 0169
		static Delegate GetSetLength_IHandler ()
		{
			if (cb_setLength_I == null)
				cb_setLength_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLength_I);
			return cb_setLength_I;
		}

		static void n_SetLength_I (IntPtr jnienv, IntPtr native__this, int sz)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Length = sz;
		}
#pragma warning restore 0169

		/// <summary>Get the cached size (mod 4 GB) (in bytes) of this file. -or- Set the cached size (in bytes) of this file.</summary>
		/// <returns>cached size of the working directory file, in bytes.</returns>
		/// <param name="sz">new cached size of the file, as bytes. If the file is larger
		///            than 2G, cast it to (int) before calling this method.</param>
		public virtual unsafe int Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()I", "GetGetLengthHandler")]
			get {
				const string __id = "getLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='setLength' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLength", "(I)V", "GetSetLength_IHandler")]
			set {
				const string __id = "setLength.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectId;
#pragma warning disable 0169
		static Delegate GetGetObjectIdHandler ()
		{
			if (cb_getObjectId == null)
				cb_getObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectId);
			return cb_getObjectId;
		}

		static IntPtr n_GetObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectId);
		}
#pragma warning restore 0169

		/// <summary>Obtain the ObjectId for the entry.</summary>
		/// <returns>object identifier for the entry.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='getObjectId' and count(parameter)=0]"
			[Register ("getObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObjectIdHandler")]
			get {
				const string __id = "getObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPathString;
#pragma warning disable 0169
		static Delegate GetGetPathStringHandler ()
		{
			if (cb_getPathString == null)
				cb_getPathString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPathString);
			return cb_getPathString;
		}

		static IntPtr n_GetPathString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PathString);
		}
#pragma warning restore 0169

		/// <summary>Get the entry's complete path.</summary>
		/// <returns>complete path of the entry, from the root of the repository. If
		///         the entry is in a subtree there will be at least one '/' in the
		///         returned string.</returns>
		public virtual unsafe string PathString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='getPathString' and count(parameter)=0]"
			[Register ("getPathString", "()Ljava/lang/String;", "GetGetPathStringHandler")]
			get {
				const string __id = "getPathString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRawMode;
#pragma warning disable 0169
		static Delegate GetGetRawModeHandler ()
		{
			if (cb_getRawMode == null)
				cb_getRawMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRawMode);
			return cb_getRawMode;
		}

		static int n_GetRawMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawMode;
		}
#pragma warning restore 0169

		/// <summary>Obtain the raw <c>FileMode</c> bits for this entry.</summary>
		/// <returns>mode bits for the entry.</returns>
		public virtual unsafe int RawMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='getRawMode' and count(parameter)=0]"
			[Register ("getRawMode", "()I", "GetGetRawModeHandler")]
			get {
				const string __id = "getRawMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStage;
#pragma warning disable 0169
		static Delegate GetGetStageHandler ()
		{
			if (cb_getStage == null)
				cb_getStage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStage);
			return cb_getStage;
		}

		static int n_GetStage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Stage;
		}
#pragma warning restore 0169

		/// <summary>Get the stage of this entry.</summary>
		/// <returns>the stage of this entry.</returns>
		public virtual unsafe int Stage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='getStage' and count(parameter)=0]"
			[Register ("getStage", "()I", "GetGetStageHandler")]
			get {
				const string __id = "getStage.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isUpdateNeeded;
#pragma warning disable 0169
		static Delegate GetIsUpdateNeededHandler ()
		{
			if (cb_isUpdateNeeded == null)
				cb_isUpdateNeeded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUpdateNeeded);
			return cb_isUpdateNeeded;
		}

		static bool n_IsUpdateNeeded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateNeeded;
		}
#pragma warning restore 0169

		static Delegate cb_setUpdateNeeded_Z;
#pragma warning disable 0169
		static Delegate GetSetUpdateNeeded_ZHandler ()
		{
			if (cb_setUpdateNeeded_Z == null)
				cb_setUpdateNeeded_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUpdateNeeded_Z);
			return cb_setUpdateNeeded_Z;
		}

		static void n_SetUpdateNeeded_Z (IntPtr jnienv, IntPtr native__this, bool updateNeeded)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNeeded = updateNeeded;
		}
#pragma warning restore 0169

		/// <returns>true if this entry should be checked for changes</returns>
		/// <summary>Set whether this entry must be checked for changes</summary>
		/// <param name="updateNeeded">updateNeeded</param>
		public virtual unsafe bool UpdateNeeded {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='isUpdateNeeded' and count(parameter)=0]"
			[Register ("isUpdateNeeded", "()Z", "GetIsUpdateNeededHandler")]
			get {
				const string __id = "isUpdateNeeded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='setUpdateNeeded' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUpdateNeeded", "(Z)V", "GetSetUpdateNeeded_ZHandler")]
			set {
				const string __id = "setUpdateNeeded.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_copyMetaData_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
#pragma warning disable 0169
		static Delegate GetCopyMetaData_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler ()
		{
			if (cb_copyMetaData_Lorg_eclipse_jgit_dircache_DirCacheEntry_ == null)
				cb_copyMetaData_Lorg_eclipse_jgit_dircache_DirCacheEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CopyMetaData_Lorg_eclipse_jgit_dircache_DirCacheEntry_);
			return cb_copyMetaData_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
		}

		static void n_CopyMetaData_Lorg_eclipse_jgit_dircache_DirCacheEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (native_src, JniHandleOwnership.DoNotTransfer);
			__this.CopyMetaData (src);
		}
#pragma warning restore 0169

		/// <param name="src">the entry to copy ObjectId and meta fields from.</param>
		/// <summary>Copy the ObjectId and other meta fields from an existing entry.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='copyMetaData' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
		[Register ("copyMetaData", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "GetCopyMetaData_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler")]
		public virtual unsafe void CopyMetaData (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry src)
		{
			const string __id = "copyMetaData.(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		static Delegate cb_getRawPath;
#pragma warning disable 0169
		static Delegate GetGetRawPathHandler ()
		{
			if (cb_getRawPath == null)
				cb_getRawPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawPath);
			return cb_getRawPath;
		}

		static IntPtr n_GetRawPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRawPath ());
		}
#pragma warning restore 0169

		/// <summary>Get a copy of the entry's raw path bytes.</summary>
		/// <returns>raw path bytes.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='getRawPath' and count(parameter)=0]"
		[Register ("getRawPath", "()[B", "GetGetRawPathHandler")]
		public virtual unsafe byte[] GetRawPath ()
		{
			const string __id = "getRawPath.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		/// <param name="smudge_s">seconds component of the index's last modified time.</param>
		/// <param name="smudge_ns">nanoseconds component of the index's last modified time.</param>
		/// <summary>Is it possible for this entry to be accidentally assumed clean?</summary>
		/// <returns>true if extra careful checks should be used.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='mightBeRacilyClean' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("mightBeRacilyClean", "(II)Z", "")]
		public unsafe bool MightBeRacilyClean (int smudge_s, int smudge_ns)
		{
			const string __id = "mightBeRacilyClean.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (smudge_s);
				__args [1] = new JniArgumentValue (smudge_ns);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setLength_J;
#pragma warning disable 0169
		static Delegate GetSetLength_JHandler ()
		{
			if (cb_setLength_J == null)
				cb_setLength_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetLength_J);
			return cb_setLength_J;
		}

		static void n_SetLength_J (IntPtr jnienv, IntPtr native__this, long sz)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLength (sz);
		}
#pragma warning restore 0169

		/// <param name="sz">new cached size of the file, as bytes.</param>
		/// <summary>Set the cached size (in bytes) of this file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='setLength' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setLength", "(J)V", "GetSetLength_JHandler")]
		public virtual unsafe void SetLength (long sz)
		{
			const string __id = "setLength.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sz);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_SetObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.SetObjectId (id);
		}
#pragma warning restore 0169

		/// <param name="id">new object identifier for the entry. May be
		///            <c>ObjectId#zeroId()</c> to remove the current identifier.</param>
		/// <summary>Set the ObjectId for the entry.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='setObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setObjectId", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetSetObjectId_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void SetObjectId (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "setObjectId.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_setObjectIdFromRaw_arrayBI;
#pragma warning disable 0169
		static Delegate GetSetObjectIdFromRaw_arrayBIHandler ()
		{
			if (cb_setObjectIdFromRaw_arrayBI == null)
				cb_setObjectIdFromRaw_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SetObjectIdFromRaw_arrayBI);
			return cb_setObjectIdFromRaw_arrayBI;
		}

		static void n_SetObjectIdFromRaw_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_bs, int p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bs = (byte[]) JNIEnv.GetArray (native_bs, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetObjectIdFromRaw (bs, p);
			if (bs != null)
				JNIEnv.CopyArray (bs, native_bs);
		}
#pragma warning restore 0169

		/// <param name="bs">the raw byte buffer to read from. At least 20 bytes after p
		///            must be available within this byte array.</param>
		/// <param name="p">position to read the first byte of data from.</param>
		/// <summary>Set the ObjectId for the entry from the raw binary representation.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='setObjectIdFromRaw' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("setObjectIdFromRaw", "([BI)V", "GetSetObjectIdFromRaw_arrayBIHandler")]
		public virtual unsafe void SetObjectIdFromRaw (byte[] bs, int p)
		{
			const string __id = "setObjectIdFromRaw.([BI)V";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bs);
				__args [1] = new JniArgumentValue (p);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		/// <summary>Force this entry to no longer match its working tree file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEntry']/method[@name='smudgeRacilyClean' and count(parameter)=0]"
		[Register ("smudgeRacilyClean", "()V", "")]
		public unsafe void SmudgeRacilyClean ()
		{
			const string __id = "smudgeRacilyClean.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
