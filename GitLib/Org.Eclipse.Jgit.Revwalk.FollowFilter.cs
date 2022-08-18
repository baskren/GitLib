using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Updates the internal path filter to follow copy/renames.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FollowFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/FollowFilter", DoNotGenerateAcw=true)]
	public partial class FollowFilter : global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/FollowFilter", typeof (FollowFilter));

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

		protected FollowFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.FollowFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		/// <returns>the path this filter matches.</returns>
		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FollowFilter']/method[@name='getPath' and count(parameter)=0]"
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

		static Delegate cb_getRenameCallback;
#pragma warning disable 0169
		static Delegate GetGetRenameCallbackHandler ()
		{
			if (cb_getRenameCallback == null)
				cb_getRenameCallback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRenameCallback);
			return cb_getRenameCallback;
		}

		static IntPtr n_GetRenameCallback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.FollowFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RenameCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setRenameCallback_Lorg_eclipse_jgit_revwalk_RenameCallback_;
#pragma warning disable 0169
		static Delegate GetSetRenameCallback_Lorg_eclipse_jgit_revwalk_RenameCallback_Handler ()
		{
			if (cb_setRenameCallback_Lorg_eclipse_jgit_revwalk_RenameCallback_ == null)
				cb_setRenameCallback_Lorg_eclipse_jgit_revwalk_RenameCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRenameCallback_Lorg_eclipse_jgit_revwalk_RenameCallback_);
			return cb_setRenameCallback_Lorg_eclipse_jgit_revwalk_RenameCallback_;
		}

		static void n_SetRenameCallback_Lorg_eclipse_jgit_revwalk_RenameCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.FollowFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RenameCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RenameCallback = @callback;
		}
#pragma warning restore 0169

		/// <returns>the callback to which renames are reported, or &lt;code&gt;null&lt;/code&gt;
		///         if none</returns>
		/// <summary>Sets the callback to which renames shall be reported.</summary>
		/// <param name="callback">the callback to use</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RenameCallback RenameCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FollowFilter']/method[@name='getRenameCallback' and count(parameter)=0]"
			[Register ("getRenameCallback", "()Lorg/eclipse/jgit/revwalk/RenameCallback;", "GetGetRenameCallbackHandler")]
			get {
				const string __id = "getRenameCallback.()Lorg/eclipse/jgit/revwalk/RenameCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RenameCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FollowFilter']/method[@name='setRenameCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RenameCallback']]"
			[Register ("setRenameCallback", "(Lorg/eclipse/jgit/revwalk/RenameCallback;)V", "GetSetRenameCallback_Lorg_eclipse_jgit_revwalk_RenameCallback_Handler")]
			set {
				const string __id = "setRenameCallback.(Lorg/eclipse/jgit/revwalk/RenameCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		/// <param name="path">the path to filter on. Must not be the empty string. All
		///            trailing '/' characters will be trimmed before string's length
		///            is checked or is used as part of the constructed filter.</param>
		/// <param name="cfg">diff config specifying rename detection options.</param>
		/// <summary>Create a new tree filter for a user supplied path.</summary>
		/// <returns>a new filter for the requested path.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FollowFilter']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.diff.DiffConfig']]"
		[Register ("create", "(Ljava/lang/String;Lorg/eclipse/jgit/diff/DiffConfig;)Lorg/eclipse/jgit/revwalk/FollowFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.FollowFilter Create (string path, global::Org.Eclipse.Jgit.Diff.DiffConfig cfg)
		{
			const string __id = "create.(Ljava/lang/String;Lorg/eclipse/jgit/diff/DiffConfig;)Lorg/eclipse/jgit/revwalk/FollowFilter;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.FollowFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (cfg);
			}
		}

		static Delegate cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_;
#pragma warning disable 0169
		static Delegate GetInclude_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler ()
		{
			if (cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_ == null)
				cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Include_Lorg_eclipse_jgit_treewalk_TreeWalk_);
			return cb_include_Lorg_eclipse_jgit_treewalk_TreeWalk_;
		}

		static bool n_Include_Lorg_eclipse_jgit_treewalk_TreeWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.FollowFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walker = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (native_walker, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Include (walker);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FollowFilter']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk']]"
		[Register ("include", "(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z", "GetInclude_Lorg_eclipse_jgit_treewalk_TreeWalk_Handler")]
		public override unsafe bool Include (global::Org.Eclipse.Jgit.Treewalk.TreeWalk walker)
		{
			const string __id = "include.(Lorg/eclipse/jgit/treewalk/TreeWalk;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((walker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walker).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (walker);
			}
		}

		static Delegate cb_shouldBeRecursive;
#pragma warning disable 0169
		static Delegate GetShouldBeRecursiveHandler ()
		{
			if (cb_shouldBeRecursive == null)
				cb_shouldBeRecursive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ShouldBeRecursive);
			return cb_shouldBeRecursive;
		}

		static bool n_ShouldBeRecursive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.FollowFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldBeRecursive ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FollowFilter']/method[@name='shouldBeRecursive' and count(parameter)=0]"
		[Register ("shouldBeRecursive", "()Z", "GetShouldBeRecursiveHandler")]
		public override unsafe bool ShouldBeRecursive ()
		{
			const string __id = "shouldBeRecursive.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
