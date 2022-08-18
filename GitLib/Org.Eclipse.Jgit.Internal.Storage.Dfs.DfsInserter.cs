using System;
using System.Collections.Generic;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Org.Eclipse.Jgit.Transport;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Inserts objects into the DFS.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsInserter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsInserter", DoNotGenerateAcw=true)]
	public partial class DfsInserter : global::Org.Eclipse.Jgit.Lib.ObjectInserter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsInserter", typeof (DfsInserter));

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

		protected DfsInserter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="db">database the inserter writes to.</param>
		/// <summary>Initialize a new inserter.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsInserter']/constructor[@name='DfsInserter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.internal.storage.dfs.DfsObjDatabase']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase;)V", "")]
		protected unsafe DfsInserter (global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsObjDatabase db) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/internal/storage/dfs/DfsObjDatabase;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsInserter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public override unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_insert_IJLjava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetInsert_IJLjava_io_InputStream_Handler ()
		{
			if (cb_insert_IJLjava_io_InputStream_ == null)
				cb_insert_IJLjava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJL_L) n_Insert_IJLjava_io_InputStream_);
			return cb_insert_IJLjava_io_InputStream_;
		}

		static IntPtr n_Insert_IJLjava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, int type, long len, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (type, len, @in));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsInserter']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.InputStream']]"
		[Register ("insert", "(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;", "GetInsert_IJLjava_io_InputStream_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Insert (int type, long len, global::System.IO.Stream @in)
		{
			const string __id = "insert.(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (len);
				__args [2] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate cb_newPackParser_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetNewPackParser_Ljava_io_InputStream_Handler ()
		{
			if (cb_newPackParser_Ljava_io_InputStream_ == null)
				cb_newPackParser_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewPackParser_Ljava_io_InputStream_);
			return cb_newPackParser_Ljava_io_InputStream_;
		}

		static IntPtr n_NewPackParser_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewPackParser (@in));
			return __ret;
		}
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsInserter']/method[@name='newPackParser' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
        [Register ("newPackParser", "(Ljava/io/InputStream;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackParser;", "GetNewPackParser_Ljava_io_InputStream_Handler")]
		public override unsafe PackParser NewPackParser (global::System.IO.Stream @in)
		{
			const string __id = "newPackParser.(Ljava/io/InputStream;)Lorg/eclipse/jgit/internal/storage/dfs/DfsPackParser;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsPackParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate cb_newReader;
#pragma warning disable 0169
		static Delegate GetNewReaderHandler ()
		{
			if (cb_newReader == null)
				cb_newReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewReader);
			return cb_newReader;
		}

		static IntPtr n_NewReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewReader ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsInserter']/method[@name='newReader' and count(parameter)=0]"
		[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ()
		{
			const string __id = "newReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsInserter']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public override unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

    }
}
