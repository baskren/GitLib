using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Submodule {

	/// <summary>Walker that visits all submodule entries found in a tree</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/submodule/SubmoduleWalk", DoNotGenerateAcw=true)]
	public partial class SubmoduleWalk : global::Java.Lang.Object {
		/// <summary>The values for the config param submodule.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk.IgnoreSubmoduleMode']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode", DoNotGenerateAcw=true)]
		public sealed partial class IgnoreSubmoduleMode : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk.IgnoreSubmoduleMode']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode All {
				get {
					const string __id = "ALL.Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk.IgnoreSubmoduleMode']/field[@name='DIRTY']"
			[Register ("DIRTY")]
			public static global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode Dirty {
				get {
					const string __id = "DIRTY.Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk.IgnoreSubmoduleMode']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode None {
				get {
					const string __id = "NONE.Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk.IgnoreSubmoduleMode']/field[@name='UNTRACKED']"
			[Register ("UNTRACKED")]
			public static global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode Untracked {
				get {
					const string __id = "UNTRACKED.Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode", typeof (IgnoreSubmoduleMode));

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

			internal IgnoreSubmoduleMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk.IgnoreSubmoduleMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk.IgnoreSubmoduleMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/submodule/SubmoduleWalk", typeof (SubmoduleWalk));

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

		protected SubmoduleWalk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repository">repository</param>
		/// <summary>Create submodule generator</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/constructor[@name='SubmoduleWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe SubmoduleWalk (global::Org.Eclipse.Jgit.Lib.Repository repository) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repository);
			}
		}

		static Delegate cb_getConfigUpdate;
#pragma warning disable 0169
		static Delegate GetGetConfigUpdateHandler ()
		{
			if (cb_getConfigUpdate == null)
				cb_getConfigUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConfigUpdate);
			return cb_getConfigUpdate;
		}

		static IntPtr n_GetConfigUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConfigUpdate);
		}
#pragma warning restore 0169

		/// <summary>Get the configured update field for current entry.</summary>
		/// <returns>update value</returns>
		public virtual unsafe string ConfigUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getConfigUpdate' and count(parameter)=0]"
			[Register ("getConfigUpdate", "()Ljava/lang/String;", "GetGetConfigUpdateHandler")]
			get {
				const string __id = "getConfigUpdate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConfigUrl;
#pragma warning disable 0169
		static Delegate GetGetConfigUrlHandler ()
		{
			if (cb_getConfigUrl == null)
				cb_getConfigUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConfigUrl);
			return cb_getConfigUrl;
		}

		static IntPtr n_GetConfigUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConfigUrl);
		}
#pragma warning restore 0169

		/// <summary>Get the configured remote URL for current entry.</summary>
		/// <returns>configured URL</returns>
		public virtual unsafe string ConfigUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getConfigUrl' and count(parameter)=0]"
			[Register ("getConfigUrl", "()Ljava/lang/String;", "GetGetConfigUrlHandler")]
			get {
				const string __id = "getConfigUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDirectory;
#pragma warning disable 0169
		static Delegate GetGetDirectoryHandler ()
		{
			if (cb_getDirectory == null)
				cb_getDirectory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDirectory);
			return cb_getDirectory;
		}

		static IntPtr n_GetDirectory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Directory);
		}
#pragma warning restore 0169

		/// <summary>Get directory that will be the root of the submodule's local repository</summary>
		/// <returns>submodule repository directory</returns>
		public virtual unsafe global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "GetGetDirectoryHandler")]
			get {
				const string __id = "getDirectory.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHead;
#pragma warning disable 0169
		static Delegate GetGetHeadHandler ()
		{
			if (cb_getHead == null)
				cb_getHead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHead);
			return cb_getHead;
		}

		static IntPtr n_GetHead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Head);
		}
#pragma warning restore 0169

		/// <summary>Get commit id that HEAD points to in the current submodule's repository</summary>
		/// <returns>object id of HEAD reference</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Head {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getHead' and count(parameter)=0]"
			[Register ("getHead", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetHeadHandler")]
			get {
				const string __id = "getHead.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeadRef;
#pragma warning disable 0169
		static Delegate GetGetHeadRefHandler ()
		{
			if (cb_getHeadRef == null)
				cb_getHeadRef = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHeadRef);
			return cb_getHeadRef;
		}

		static IntPtr n_GetHeadRef (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeadRef);
		}
#pragma warning restore 0169

		/// <summary>Get ref that HEAD points to in the current submodule's repository</summary>
		/// <returns>ref name, null on failures</returns>
		public virtual unsafe string HeadRef {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getHeadRef' and count(parameter)=0]"
			[Register ("getHeadRef", "()Ljava/lang/String;", "GetGetHeadRefHandler")]
			get {
				const string __id = "getHeadRef.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModulesIgnore;
#pragma warning disable 0169
		static Delegate GetGetModulesIgnoreHandler ()
		{
			if (cb_getModulesIgnore == null)
				cb_getModulesIgnore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModulesIgnore);
			return cb_getModulesIgnore;
		}

		static IntPtr n_GetModulesIgnore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModulesIgnore);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode ModulesIgnore {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getModulesIgnore' and count(parameter)=0]"
			[Register ("getModulesIgnore", "()Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;", "GetGetModulesIgnoreHandler")]
			get {
				const string __id = "getModulesIgnore.()Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModulesPath;
#pragma warning disable 0169
		static Delegate GetGetModulesPathHandler ()
		{
			if (cb_getModulesPath == null)
				cb_getModulesPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModulesPath);
			return cb_getModulesPath;
		}

		static IntPtr n_GetModulesPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ModulesPath);
		}
#pragma warning restore 0169

		/// <summary>Get the configured path for current entry.</summary>
		/// <returns>configured path</returns>
		public virtual unsafe string ModulesPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getModulesPath' and count(parameter)=0]"
			[Register ("getModulesPath", "()Ljava/lang/String;", "GetGetModulesPathHandler")]
			get {
				const string __id = "getModulesPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModulesUpdate;
#pragma warning disable 0169
		static Delegate GetGetModulesUpdateHandler ()
		{
			if (cb_getModulesUpdate == null)
				cb_getModulesUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModulesUpdate);
			return cb_getModulesUpdate;
		}

		static IntPtr n_GetModulesUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ModulesUpdate);
		}
#pragma warning restore 0169

		/// <summary>Get the configured update field for current entry.</summary>
		/// <returns>update value</returns>
		public virtual unsafe string ModulesUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getModulesUpdate' and count(parameter)=0]"
			[Register ("getModulesUpdate", "()Ljava/lang/String;", "GetGetModulesUpdateHandler")]
			get {
				const string __id = "getModulesUpdate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModulesUrl;
#pragma warning disable 0169
		static Delegate GetGetModulesUrlHandler ()
		{
			if (cb_getModulesUrl == null)
				cb_getModulesUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModulesUrl);
			return cb_getModulesUrl;
		}

		static IntPtr n_GetModulesUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ModulesUrl);
		}
#pragma warning restore 0169

		/// <summary>Get the configured remote URL for current entry.</summary>
		/// <returns>configured URL</returns>
		public virtual unsafe string ModulesUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getModulesUrl' and count(parameter)=0]"
			[Register ("getModulesUrl", "()Ljava/lang/String;", "GetGetModulesUrlHandler")]
			get {
				const string __id = "getModulesUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectId);
		}
#pragma warning restore 0169

		/// <summary>Get object id of current submodule entry</summary>
		/// <returns>object id</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getObjectId' and count(parameter)=0]"
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

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		/// <summary>Get path of current submodule entry</summary>
		/// <returns>path</returns>
		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoteUrl;
#pragma warning disable 0169
		static Delegate GetGetRemoteUrlHandler ()
		{
			if (cb_getRemoteUrl == null)
				cb_getRemoteUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemoteUrl);
			return cb_getRemoteUrl;
		}

		static IntPtr n_GetRemoteUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemoteUrl);
		}
#pragma warning restore 0169

		/// <summary>Get the resolved remote URL for the current submodule.</summary>
		/// <returns>resolved remote URL</returns>
		public virtual unsafe string RemoteUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getRemoteUrl' and count(parameter)=0]"
			[Register ("getRemoteUrl", "()Ljava/lang/String;", "GetGetRemoteUrlHandler")]
			get {
				const string __id = "getRemoteUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRepository;
#pragma warning disable 0169
		static Delegate GetGetRepositoryHandler ()
		{
			if (cb_getRepository == null)
				cb_getRepository = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRepository);
			return cb_getRepository;
		}

		static IntPtr n_GetRepository (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repository);
		}
#pragma warning restore 0169

		/// <summary>Get repository for current submodule entry</summary>
		/// <returns>repository or null if non-existent</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "GetGetRepositoryHandler")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/lib/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <param name="repository">the repository to check</param>
		/// <summary>Checks whether the working tree (or the index in case of a bare repo)
		/// contains a .</summary>
		/// <returns>&lt;code&gt;true&lt;/code&gt; if the repo contains a .gitmodules file</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='containsGitModulesFile' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("containsGitModulesFile", "(Lorg/eclipse/jgit/lib/Repository;)Z", "")]
		public static unsafe bool ContainsGitModulesFile (global::Org.Eclipse.Jgit.Lib.Repository repository)
		{
			const string __id = "containsGitModulesFile.(Lorg/eclipse/jgit/lib/Repository;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (repository);
			}
		}

		/// <param name="repository">repository</param>
		/// <summary>Create a generator to walk over the submodule entries currently in the
		/// index
		/// 
		/// The <c>.gitmodules</c> file is read from the index.</summary>
		/// <returns>generator over submodule index entries</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='forIndex' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("forIndex", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk ForIndex (global::Org.Eclipse.Jgit.Lib.Repository repository)
		{
			const string __id = "forIndex.(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (repository);
			}
		}

		/// <param name="repository">repository</param>
		/// <param name="treeId">the root of a tree containing both a submodule at the given path
		///            and .gitmodules at the root.</param>
		/// <param name="path">path</param>
		/// <summary>Create a generator and advance it to the submodule entry at the given
		/// path</summary>
		/// <returns>generator at given path, null if no submodule at given path</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='forPath' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[3][@type='java.lang.String']]"
		[Register ("forPath", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/lang/String;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk ForPath (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Lib.AnyObjectId treeId, string path)
		{
			const string __id = "forPath.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/lang/String;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((treeId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) treeId).Handle);
				__args [2] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (treeId);
			}
		}

		/// <param name="repository">repository</param>
		/// <param name="iterator">the root of a tree containing both a submodule at the given path
		///            and .gitmodules at the root.</param>
		/// <param name="path">path</param>
		/// <summary>Create a generator and advance it to the submodule entry at the given
		/// path</summary>
		/// <returns>generator at given path, null if no submodule at given path</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='forPath' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator'] and parameter[3][@type='java.lang.String']]"
		[Register ("forPath", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;Ljava/lang/String;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk ForPath (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator iterator, string path)
		{
			const string __id = "forPath.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;Ljava/lang/String;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				__args [2] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (iterator);
			}
		}

		/// <param name="parent">parent</param>
		/// <param name="path">path</param>
		/// <summary>Get submodule directory</summary>
		/// <returns>directory</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getSubmoduleDirectory' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSubmoduleDirectory", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetSubmoduleDirectory (global::Org.Eclipse.Jgit.Lib.Repository parent, string path)
		{
			const string __id = "getSubmoduleDirectory.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (parent);
			}
		}

		/// <param name="parent">parent repository</param>
		/// <param name="url">absolute or relative URL of the submodule repository</param>
		/// <summary>Resolve submodule repository URL.</summary>
		/// <returns>resolved URL</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getSubmoduleRemoteUrl' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSubmoduleRemoteUrl", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSubmoduleRemoteUrl (global::Org.Eclipse.Jgit.Lib.Repository parent, string url)
		{
			const string __id = "getSubmoduleRemoteUrl.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString ((string)url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_url);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				global::System.GC.KeepAlive (parent);
			}
		}

		/// <param name="parent">parent</param>
		/// <param name="path">path</param>
		/// <summary>Get submodule repository at path</summary>
		/// <returns>repository or null if repository doesn't exist</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getSubmoduleRepository' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSubmoduleRepository", "(Ljava/io/File;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Repository;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.Repository GetSubmoduleRepository (global::Java.IO.File parent, string path)
		{
			const string __id = "getSubmoduleRepository.(Ljava/io/File;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Repository;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (parent);
			}
		}

		/// <param name="parent">parent</param>
		/// <param name="path">path</param>
		/// <summary>Get submodule repository</summary>
		/// <returns>repository or null if repository doesn't exist</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='getSubmoduleRepository' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSubmoduleRepository", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Repository;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.Repository GetSubmoduleRepository (global::Org.Eclipse.Jgit.Lib.Repository parent, string path)
		{
			const string __id = "getSubmoduleRepository.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Repository;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (parent);
			}
		}

		static Delegate cb_loadModulesConfig;
#pragma warning disable 0169
		static Delegate GetLoadModulesConfigHandler ()
		{
			if (cb_loadModulesConfig == null)
				cb_loadModulesConfig = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LoadModulesConfig);
			return cb_loadModulesConfig;
		}

		static IntPtr n_LoadModulesConfig (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoadModulesConfig ());
		}
#pragma warning restore 0169

		/// <summary>Load the config for this walk from <c>.gitmodules</c>.</summary>
		/// <returns>this generator</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='loadModulesConfig' and count(parameter)=0]"
		[Register ("loadModulesConfig", "()Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "GetLoadModulesConfigHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk LoadModulesConfig ()
		{
			const string __id = "loadModulesConfig.()Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Next);
			return cb_next;
		}

		static bool n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Next ();
		}
#pragma warning restore 0169

		/// <summary>Advance to next submodule in the index tree.</summary>
		/// <returns>true if entry found, false otherwise</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Z", "GetNextHandler")]
		public virtual unsafe bool Next ()
		{
			const string __id = "next.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		/// <summary>Release any resources used by this walker's reader.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Reset);
			return cb_reset;
		}

		static IntPtr n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reset ());
		}
#pragma warning restore 0169

		/// <summary>Reset generator and start new submodule walk</summary>
		/// <returns>this generator</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "GetResetHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk Reset ()
		{
			const string __id = "reset.()Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
#pragma warning disable 0169
		static Delegate GetSetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler ()
		{
			if (cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ == null)
				cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_);
			return cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
		}

		static IntPtr n_SetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFilter (filter));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="filter">filter</param>
		/// <summary>Set tree filter</summary>
		/// <returns>this generator</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.filter.TreeFilter']]"
		[Register ("setFilter", "(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "GetSetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk SetFilter (global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter filter)
		{
			const string __id = "setFilter.(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (filter);
			}
		}

		static Delegate cb_setModulesConfig_Lorg_eclipse_jgit_lib_Config_;
#pragma warning disable 0169
		static Delegate GetSetModulesConfig_Lorg_eclipse_jgit_lib_Config_Handler ()
		{
			if (cb_setModulesConfig_Lorg_eclipse_jgit_lib_Config_ == null)
				cb_setModulesConfig_Lorg_eclipse_jgit_lib_Config_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetModulesConfig_Lorg_eclipse_jgit_lib_Config_);
			return cb_setModulesConfig_Lorg_eclipse_jgit_lib_Config_;
		}

		static IntPtr n_SetModulesConfig_Lorg_eclipse_jgit_lib_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (native_config, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetModulesConfig (config));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="config">.gitmodules config object</param>
		/// <summary>Set the config used by this walk.</summary>
		/// <returns>this generator</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='setModulesConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
		[Register ("setModulesConfig", "(Lorg/eclipse/jgit/lib/Config;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "GetSetModulesConfig_Lorg_eclipse_jgit_lib_Config_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk SetModulesConfig (global::Org.Eclipse.Jgit.Lib.Config config)
		{
			const string __id = "setModulesConfig.(Lorg/eclipse/jgit/lib/Config;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

		static Delegate cb_setRootTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetRootTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setRootTree_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setRootTree_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRootTree_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setRootTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_SetRootTree_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRootTree (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">ID of a tree containing .gitmodules</param>
		/// <summary>Set the tree used by this walk for finding <c>.gitmodules</c>.</summary>
		/// <returns>this generator</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='setRootTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setRootTree", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "GetSetRootTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk SetRootTree (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "setRootTree.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_setRootTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
#pragma warning disable 0169
		static Delegate GetSetRootTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler ()
		{
			if (cb_setRootTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ == null)
				cb_setRootTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRootTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_);
			return cb_setRootTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
		}

		static IntPtr n_SetRootTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tree)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tree = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_tree, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRootTree (tree));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="tree">tree containing .gitmodules</param>
		/// <summary>Set the tree used by this walk for finding <c>.gitmodules</c>.</summary>
		/// <returns>this generator</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='setRootTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register ("setRootTree", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "GetSetRootTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk SetRootTree (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator tree)
		{
			const string __id = "setRootTree.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tree).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (tree);
			}
		}

		static Delegate cb_setTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetSetTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_setTree_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_setTree_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTree_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_setTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_SetTree_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_treeId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var treeId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_treeId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTree (treeId));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="treeId">treeId</param>
		/// <summary>Set the tree used for finding submodule entries</summary>
		/// <returns>this generator</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='setTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("setTree", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "GetSetTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk SetTree (global::Org.Eclipse.Jgit.Lib.AnyObjectId treeId)
		{
			const string __id = "setTree.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((treeId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) treeId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (treeId);
			}
		}

		static Delegate cb_setTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
#pragma warning disable 0169
		static Delegate GetSetTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler ()
		{
			if (cb_setTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ == null)
				cb_setTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_);
			return cb_setTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
		}

		static IntPtr n_SetTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_iterator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var iterator = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_iterator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTree (iterator));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="iterator">iterator</param>
		/// <summary>Set the tree iterator used for finding submodule entries</summary>
		/// <returns>this generator</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.submodule']/class[@name='SubmoduleWalk']/method[@name='setTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register ("setTree", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;", "GetSetTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk SetTree (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator iterator)
		{
			const string __id = "setTree.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Lorg/eclipse/jgit/submodule/SubmoduleWalk;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (iterator);
			}
		}

	}
}
