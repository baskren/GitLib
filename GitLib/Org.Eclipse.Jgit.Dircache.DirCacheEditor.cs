using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Dircache {

	/// <summary>Updates a <c>DirCache</c> by supplying discrete edit commands.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheEditor", DoNotGenerateAcw=true)]
	public partial class DirCacheEditor : global::Java.Lang.Object {
		/// <summary>Deletes a single file entry from the index.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.DeletePath']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheEditor$DeletePath", DoNotGenerateAcw=true)]
		public sealed partial class DeletePath : global::Org.Eclipse.Jgit.Dircache.DirCacheEditor.PathEdit {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheEditor$DeletePath", typeof (DeletePath));

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

			internal DeletePath (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="entryPath">path of the file within the repository.</param>
			/// <summary>Create a new deletion command by path name.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.DeletePath']/constructor[@name='DirCacheEditor.DeletePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe DeletePath (string entryPath) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_entryPath = JNIEnv.NewString ((string)entryPath);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_entryPath);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_entryPath);
				}
			}

			/// <param name="ent">entry instance to remove. Only the path of this entry is
			///            actually considered during command evaluation.</param>
			/// <summary>Create a new deletion command for an existing entry instance.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.DeletePath']/constructor[@name='DirCacheEditor.DeletePath' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
			[Register (".ctor", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "")]
			public unsafe DeletePath (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry ent) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (ent);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.DeletePath']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
			[Register ("apply", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "")]
			public override unsafe void Apply (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry ent)
			{
				const string __id = "apply.(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (ent);
				}
			}

		}

		/// <summary>Recursively deletes all paths under a subtree.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.DeleteTree']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheEditor$DeleteTree", DoNotGenerateAcw=true)]
		public sealed partial class DeleteTree : global::Org.Eclipse.Jgit.Dircache.DirCacheEditor.PathEdit {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheEditor$DeleteTree", typeof (DeleteTree));

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

			internal DeleteTree (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="entryPath">path of the subtree within the repository. If the path
			///            does not end with "/" a "/" is implicitly added to ensure
			///            only the subtree's contents are matched by the command.
			///            The special case "" (not "/"!) deletes all entries.</param>
			/// <summary>Create a new tree deletion command by path name.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.DeleteTree']/constructor[@name='DirCacheEditor.DeleteTree' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe DeleteTree (string entryPath) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_entryPath = JNIEnv.NewString ((string)entryPath);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_entryPath);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_entryPath);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.DeleteTree']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
			[Register ("apply", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "")]
			public override unsafe void Apply (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry ent)
			{
				const string __id = "apply.(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (ent);
				}
			}

		}

		/// <summary>Any index record update.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.PathEdit']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheEditor$PathEdit", DoNotGenerateAcw=true)]
		public abstract partial class PathEdit : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheEditor$PathEdit", typeof (PathEdit));

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

			protected PathEdit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="entryPath">path of the file within the repository.</param>
			/// <summary>Create a new update command by path name.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.PathEdit']/constructor[@name='DirCacheEditor.PathEdit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe PathEdit (string entryPath) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_entryPath = JNIEnv.NewString ((string)entryPath);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_entryPath);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_entryPath);
				}
			}

			/// <param name="ent">entry instance to match path of. Only the path of this
			///            entry is actually considered during command evaluation.</param>
			/// <summary>Create a new update command for an existing entry instance.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.PathEdit']/constructor[@name='DirCacheEditor.PathEdit' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
			[Register (".ctor", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "")]
			public unsafe PathEdit (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry ent) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (ent);
				}
			}

			static Delegate cb_apply_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
#pragma warning disable 0169
			static Delegate GetApply_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler ()
			{
				if (cb_apply_Lorg_eclipse_jgit_dircache_DirCacheEntry_ == null)
					cb_apply_Lorg_eclipse_jgit_dircache_DirCacheEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Apply_Lorg_eclipse_jgit_dircache_DirCacheEntry_);
				return cb_apply_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
			}

			static void n_Apply_Lorg_eclipse_jgit_dircache_DirCacheEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ent)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor.PathEdit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var ent = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (native_ent, JniHandleOwnership.DoNotTransfer);
				__this.Apply (ent);
			}
#pragma warning restore 0169

			/// <param name="ent">the entry being processed. All fields are zeroed out if
			///            the path is a new path in the index.</param>
			/// <summary>Apply the update to a single cache entry matching the path.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.PathEdit']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
			[Register ("apply", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "GetApply_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler")]
			public abstract void Apply (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry ent);

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheEditor$PathEdit", DoNotGenerateAcw=true)]
		internal partial class PathEditInvoker : PathEdit {
			public PathEditInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheEditor$PathEdit", typeof (PathEditInvoker));

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

			/// <param name="ent">the entry being processed. All fields are zeroed out if
			///            the path is a new path in the index.</param>
			/// <summary>Apply the update to a single cache entry matching the path.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor.PathEdit']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
			[Register ("apply", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "GetApply_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler")]
			public override unsafe void Apply (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry ent)
			{
				const string __id = "apply.(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (ent);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheEditor", typeof (DirCacheEditor));

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

		protected DirCacheEditor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="dc">the cache this editor will eventually update.</param>
		/// <param name="ecnt">estimated number of entries the editor will have upon
		///            completion. This sizes the initial entry table.</param>
		/// <summary>Construct a new editor.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor']/constructor[@name='DirCacheEditor' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.dircache.DirCache'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/dircache/DirCache;I)V", "")]
		protected unsafe DirCacheEditor (global::Org.Eclipse.Jgit.Dircache.DirCache dc, int ecnt) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/dircache/DirCache;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dc).Handle);
				__args [1] = new JniArgumentValue (ecnt);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dc);
			}
		}

		static Delegate cb_getDirCache;
#pragma warning disable 0169
		static Delegate GetGetDirCacheHandler ()
		{
			if (cb_getDirCache == null)
				cb_getDirCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDirCache);
			return cb_getDirCache;
		}

		static IntPtr n_GetDirCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DirCache);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCache DirCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor']/method[@name='getDirCache' and count(parameter)=0]"
			[Register ("getDirCache", "()Lorg/eclipse/jgit/dircache/DirCache;", "GetGetDirCacheHandler")]
			get {
				const string __id = "getDirCache.()Lorg/eclipse/jgit/dircache/DirCache;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lorg_eclipse_jgit_dircache_DirCacheEditor_PathEdit_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_dircache_DirCacheEditor_PathEdit_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_dircache_DirCacheEditor_PathEdit_ == null)
				cb_add_Lorg_eclipse_jgit_dircache_DirCacheEditor_PathEdit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Lorg_eclipse_jgit_dircache_DirCacheEditor_PathEdit_);
			return cb_add_Lorg_eclipse_jgit_dircache_DirCacheEditor_PathEdit_;
		}

		static void n_Add_Lorg_eclipse_jgit_dircache_DirCacheEditor_PathEdit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_edit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var edit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor.PathEdit> (native_edit, JniHandleOwnership.DoNotTransfer);
			__this.Add (edit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEditor.PathEdit']]"
		[Register ("add", "(Lorg/eclipse/jgit/dircache/DirCacheEditor$PathEdit;)V", "GetAdd_Lorg_eclipse_jgit_dircache_DirCacheEditor_PathEdit_Handler")]
		public virtual unsafe void Add (global::Org.Eclipse.Jgit.Dircache.DirCacheEditor.PathEdit edit)
		{
			const string __id = "add.(Lorg/eclipse/jgit/dircache/DirCacheEditor$PathEdit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((edit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) edit).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (edit);
			}
		}

		static Delegate cb_commit;
#pragma warning disable 0169
		static Delegate GetCommitHandler ()
		{
			if (cb_commit == null)
				cb_commit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Commit);
			return cb_commit;
		}

		static bool n_Commit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Commit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor']/method[@name='commit' and count(parameter)=0]"
		[Register ("commit", "()Z", "GetCommitHandler")]
		public virtual unsafe bool Commit ()
		{
			const string __id = "commit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheEditor']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
#pragma warning disable 0169
		static Delegate GetFastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler ()
		{
			if (cb_fastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_ == null)
				cb_fastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_);
			return cb_fastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
		}

		static void n_FastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newEntry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newEntry = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (native_newEntry, JniHandleOwnership.DoNotTransfer);
			__this.FastAdd (newEntry);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='BaseDirCacheEditor']/method[@name='fastAdd' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
		[Register ("fastAdd", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V", "GetFastAdd_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler")]
		protected virtual unsafe void FastAdd (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry newEntry)
		{
			const string __id = "fastAdd.(Lorg/eclipse/jgit/dircache/DirCacheEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newEntry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newEntry).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (newEntry);
			}
		}

		static Delegate cb_fastKeep_II;
#pragma warning disable 0169
		static Delegate GetFastKeep_IIHandler ()
		{
			if (cb_fastKeep_II == null)
				cb_fastKeep_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_FastKeep_II);
			return cb_fastKeep_II;
		}

		static void n_FastKeep_II (IntPtr jnienv, IntPtr native__this, int pos, int cnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FastKeep (pos, cnt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='BaseDirCacheEditor']/method[@name='fastKeep' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("fastKeep", "(II)V", "GetFastKeep_IIHandler")]
		protected virtual unsafe void FastKeep (int pos, int cnt)
		{
			const string __id = "fastKeep.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (pos);
				__args [1] = new JniArgumentValue (cnt);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_replace;
#pragma warning disable 0169
		static Delegate GetReplaceHandler ()
		{
			if (cb_replace == null)
				cb_replace = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Replace);
			return cb_replace;
		}

		static void n_Replace (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Replace ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='BaseDirCacheEditor']/method[@name='replace' and count(parameter)=0]"
		[Register ("replace", "()V", "GetReplaceHandler")]
		protected virtual unsafe void Replace ()
		{
			const string __id = "replace.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
