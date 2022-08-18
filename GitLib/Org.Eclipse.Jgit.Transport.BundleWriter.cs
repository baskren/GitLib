using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Creates a Git bundle file, for sneaker-net transport to another system.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BundleWriter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BundleWriter", DoNotGenerateAcw=true)]
	public partial class BundleWriter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BundleWriter", typeof (BundleWriter));

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

		protected BundleWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repository where objects are stored.</param>
		/// <summary>Create a writer for a bundle.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BundleWriter']/constructor[@name='BundleWriter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe BundleWriter (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_assume_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetAssume_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_assume_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_assume_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Assume_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_assume_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static void n_Assume_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BundleWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.Assume (c);
		}
#pragma warning restore 0169

		/// <param name="c">the commit to assume being available. This commit should be
		///            parsed and not disposed in order to maximize the amount of
		///            debugging information available in the bundle stream.</param>
		/// <summary>Assume a commit is available on the recipient's side.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BundleWriter']/method[@name='assume' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("assume", "(Lorg/eclipse/jgit/revwalk/RevCommit;)V", "GetAssume_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe void Assume (global::Org.Eclipse.Jgit.Revwalk.RevCommit c)
		{
			const string __id = "assume.(Lorg/eclipse/jgit/revwalk/RevCommit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetInclude_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_Include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BundleWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.Include (name, id);
		}
#pragma warning restore 0169

		/// <param name="name">name the recipient can discover this object as from the
		///            bundle's list of advertised refs . The name must be a valid
		///            ref format and must not have already been included in this
		///            bundle writer.</param>
		/// <param name="id">object to pack. Multiple refs may point to the same object.</param>
		/// <summary>Include an object (and everything reachable from it) in the bundle.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BundleWriter']/method[@name='include' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("include", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetInclude_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void Include (string name, global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "include.(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_include_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetInclude_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_include_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_include_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Include_Lorg_eclipse_jgit_lib_Ref_);
			return cb_include_Lorg_eclipse_jgit_lib_Ref_;
		}

		static void n_Include_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BundleWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.Include (r);
		}
#pragma warning restore 0169

		/// <param name="r">the ref to include.</param>
		/// <summary>Include a single ref (a name/object pair) in the bundle.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BundleWriter']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("include", "(Lorg/eclipse/jgit/lib/Ref;)V", "GetInclude_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe void Include (global::Org.Eclipse.Jgit.Lib.IRef r)
		{
			const string __id = "include.(Lorg/eclipse/jgit/lib/Ref;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (r);
			}
		}

		static Delegate cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
#pragma warning disable 0169
		static Delegate GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler ()
		{
			if (cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ == null)
				cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_);
			return cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
		}

		static void n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BundleWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (native_pc, JniHandleOwnership.DoNotTransfer);
			__this.SetPackConfig (pc);
		}
#pragma warning restore 0169

		/// <param name="pc">configuration controlling packing parameters. If null the
		///            source repository's settings will be used.</param>
		/// <summary>Set the configuration used by the pack generator.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BundleWriter']/method[@name='setPackConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.storage.pack.PackConfig']]"
		[Register ("setPackConfig", "(Lorg/eclipse/jgit/storage/pack/PackConfig;)V", "GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler")]
		public virtual unsafe void SetPackConfig (global::Org.Eclipse.Jgit.Storage.Pack.PackConfig pc)
		{
			const string __id = "setPackConfig.(Lorg/eclipse/jgit/storage/pack/PackConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pc).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pc);
			}
		}

		static Delegate cb_writeBundle_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteBundle_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeBundle_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_ == null)
				cb_writeBundle_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_WriteBundle_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_);
			return cb_writeBundle_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_;
		}

		static void n_WriteBundle_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_os)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BundleWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var os = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_os, JniHandleOwnership.DoNotTransfer);
			__this.WriteBundle (monitor, os);
		}
#pragma warning restore 0169

		/// <param name="monitor">progress monitor to report bundle writing status to.</param>
		/// <param name="os">the stream the bundle is written to. The stream should be
		///            buffered by the caller. The caller is responsible for closing
		///            the stream.</param>
		/// <summary>Generate and write the bundle to the output stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BundleWriter']/method[@name='writeBundle' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("writeBundle", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/io/OutputStream;)V", "GetWriteBundle_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void WriteBundle (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.IO.Stream os)
		{
			const string __id = "writeBundle.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/io/OutputStream;)V";
			IntPtr native_os = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (os);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_os);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_os);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (os);
			}
		}

	}
}
