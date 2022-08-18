using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>A fully buffered output stream.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/TemporaryBuffer", DoNotGenerateAcw=true)]
	public abstract partial class TemporaryBuffer : global::Java.IO.OutputStream {
		/// <summary>Default limit for in-core storage.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/field[@name='DEFAULT_IN_CORE_LIMIT']"
		[Register ("DEFAULT_IN_CORE_LIMIT")]
		protected const int DefaultInCoreLimit = (int) 1048576;

		/// <summary>A temporary buffer that will never exceed its in-memory limit.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer.Heap']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/TemporaryBuffer$Heap", DoNotGenerateAcw=true)]
		public partial class Heap : global::Org.Eclipse.Jgit.Util.TemporaryBuffer {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/TemporaryBuffer$Heap", typeof (Heap));

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

			protected Heap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="limit">maximum number of bytes that can be stored in this buffer.
			///            Storing beyond this many will cause an IOException to be
			///            thrown during write.</param>
			/// <summary>Create a new heap buffer with a maximum storage limit.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer.Heap']/constructor[@name='TemporaryBuffer.Heap' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe Heap (int limit) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (limit);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_overflow;
#pragma warning disable 0169
			static Delegate GetOverflowHandler ()
			{
				if (cb_overflow == null)
					cb_overflow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Overflow);
				return cb_overflow;
			}

			static IntPtr n_Overflow (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer.Heap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Overflow ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer.Heap']/method[@name='overflow' and count(parameter)=0]"
			[Register ("overflow", "()Ljava/io/OutputStream;", "GetOverflowHandler")]
			protected override unsafe global::System.IO.Stream Overflow ()
			{
				const string __id = "overflow.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		/// <summary>A fully buffered output stream using local disk storage for large data.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer.LocalFile']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/TemporaryBuffer$LocalFile", DoNotGenerateAcw=true)]
		public partial class LocalFile : global::Org.Eclipse.Jgit.Util.TemporaryBuffer {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/TemporaryBuffer$LocalFile", typeof (LocalFile));

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

			protected LocalFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <summary>Create a new temporary buffer.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer.LocalFile']/constructor[@name='TemporaryBuffer.LocalFile' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			[Obsolete (@"deprecated")]
			public unsafe LocalFile () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			/// <param name="inCoreLimit">maximum number of bytes to store in memory. Storage beyond
			///            this limit will use the local file.</param>
			/// <summary>Create a new temporary buffer, limiting memory usage.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer.LocalFile']/constructor[@name='TemporaryBuffer.LocalFile' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe LocalFile (int inCoreLimit) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (inCoreLimit);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			/// <param name="directory">if the buffer has to spill over into a temporary file, the
			///            directory where the file should be saved. If null the
			///            system default temporary directory (for example /tmp) will
			///            be used instead.</param>
			/// <summary>Create a new temporary buffer, limiting memory usage.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer.LocalFile']/constructor[@name='TemporaryBuffer.LocalFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
			[Register (".ctor", "(Ljava/io/File;)V", "")]
			public unsafe LocalFile (global::Java.IO.File directory) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/io/File;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (directory);
				}
			}

			/// <param name="directory">if the buffer has to spill over into a temporary file, the
			///            directory where the file should be saved. If null the
			///            system default temporary directory (for example /tmp) will
			///            be used instead.</param>
			/// <param name="inCoreLimit">maximum number of bytes to store in memory. Storage beyond
			///            this limit will use the local file.</param>
			/// <summary>Create a new temporary buffer, limiting memory usage.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer.LocalFile']/constructor[@name='TemporaryBuffer.LocalFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/io/File;I)V", "")]
			public unsafe LocalFile (global::Java.IO.File directory, int inCoreLimit) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/io/File;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
					__args [1] = new JniArgumentValue (inCoreLimit);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (directory);
				}
			}

			static Delegate cb_overflow;
#pragma warning disable 0169
			static Delegate GetOverflowHandler ()
			{
				if (cb_overflow == null)
					cb_overflow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Overflow);
				return cb_overflow;
			}

			static IntPtr n_Overflow (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer.LocalFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Overflow ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer.LocalFile']/method[@name='overflow' and count(parameter)=0]"
			[Register ("overflow", "()Ljava/io/OutputStream;", "GetOverflowHandler")]
			protected override unsafe global::System.IO.Stream Overflow ()
			{
				const string __id = "overflow.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/TemporaryBuffer", typeof (TemporaryBuffer));

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

		protected TemporaryBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="limit">maximum number of bytes to store in memory before entering the
		///            overflow output path.</param>
		/// <summary>Create a new empty temporary buffer.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/constructor[@name='TemporaryBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe TemporaryBuffer (int limit) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_copy_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetCopy_Ljava_io_InputStream_Handler ()
		{
			if (cb_copy_Ljava_io_InputStream_ == null)
				cb_copy_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Copy_Ljava_io_InputStream_);
			return cb_copy_Ljava_io_InputStream_;
		}

		static void n_Copy_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			__this.Copy (@in);
		}
#pragma warning restore 0169

		/// <param name="in">the stream to read from, until EOF is reached.</param>
		/// <summary>Copy all bytes remaining on the input stream into this buffer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("copy", "(Ljava/io/InputStream;)V", "GetCopy_Ljava_io_InputStream_Handler")]
		public virtual unsafe void Copy (global::System.IO.Stream @in)
		{
			const string __id = "copy.(Ljava/io/InputStream;)V";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		/// <summary>Clear this buffer so it has no data, and cannot be used again.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doFlush;
#pragma warning disable 0169
		static Delegate GetDoFlushHandler ()
		{
			if (cb_doFlush == null)
				cb_doFlush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoFlush);
			return cb_doFlush;
		}

		static void n_DoFlush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoFlush ();
		}
#pragma warning restore 0169

		/// <summary>Dumps the entire buffer into the overflow stream, and flushes it.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='doFlush' and count(parameter)=0]"
		[Register ("doFlush", "()V", "GetDoFlushHandler")]
		protected virtual unsafe void DoFlush ()
		{
			const string __id = "doFlush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_Length);
			return cb_length;
		}

		static long n_Length (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		/// <summary>Obtain the length (in bytes) of the buffer.</summary>
		/// <returns>total length of the buffer, in bytes.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "GetLengthHandler")]
		public virtual unsafe long Length ()
		{
			const string __id = "length.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_openInputStream;
#pragma warning disable 0169
		static Delegate GetOpenInputStreamHandler ()
		{
			if (cb_openInputStream == null)
				cb_openInputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenInputStream);
			return cb_openInputStream;
		}

		static IntPtr n_OpenInputStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.OpenInputStream ());
		}
#pragma warning restore 0169

		/// <summary>Open an input stream to read from the buffered data.</summary>
		/// <returns>a stream to read from the buffer. The caller must close the
		///         stream when it is no longer useful.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='openInputStream' and count(parameter)=0]"
		[Register ("openInputStream", "()Ljava/io/InputStream;", "GetOpenInputStreamHandler")]
		public virtual unsafe global::System.IO.Stream OpenInputStream ()
		{
			const string __id = "openInputStream.()Ljava/io/InputStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_overflow;
#pragma warning disable 0169
		static Delegate GetOverflowHandler ()
		{
			if (cb_overflow == null)
				cb_overflow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Overflow);
			return cb_overflow;
		}

		static IntPtr n_Overflow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Overflow ());
		}
#pragma warning restore 0169

		/// <summary>Open the overflow output stream, so the remaining output can be stored.</summary>
		/// <returns>the output stream to receive the buffered content, followed by
		///         the remaining output.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='overflow' and count(parameter)=0]"
		[Register ("overflow", "()Ljava/io/OutputStream;", "GetOverflowHandler")]
		protected abstract global::System.IO.Stream Overflow ();

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		/// <summary>Reset this buffer for reuse, purging all buffered content.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		/// <summary>Convert this buffer's contents into a contiguous byte array.</summary>
		/// <returns>the complete byte array; length matches <c>#length()</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[] ToByteArray ()
		{
			const string __id = "toByteArray.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_write_I;
#pragma warning disable 0169
		static Delegate GetWrite_IHandler ()
		{
			if (cb_write_I == null)
				cb_write_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Write_I);
			return cb_write_I;
		}

		static void n_Write_I (IntPtr jnienv, IntPtr native__this, int b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write", "(I)V", "GetWrite_IHandler")]
		public override unsafe void Write (int b)
		{
			const string __id = "write.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeTo_Ljava_io_OutputStream_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetWriteTo_Ljava_io_OutputStream_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_writeTo_Ljava_io_OutputStream_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_writeTo_Ljava_io_OutputStream_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_WriteTo_Ljava_io_OutputStream_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_writeTo_Ljava_io_OutputStream_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static void n_WriteTo_Ljava_io_OutputStream_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_os, IntPtr native_pm)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.TemporaryBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var os = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_os, JniHandleOwnership.DoNotTransfer);
			var pm = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_pm, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (os, pm);
		}
#pragma warning restore 0169

		/// <param name="os">stream to send this buffer's complete content to.</param>
		/// <param name="pm">if not null progress updates are sent here. Caller should
		///            initialize the task and the number of work units to &lt;code&gt;
		///            <c>#length()</c>/1024&lt;/code&gt;.</param>
		/// <summary>Send this buffer to an output stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='writeTo' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;Lorg/eclipse/jgit/lib/ProgressMonitor;)V", "GetWriteTo_Ljava_io_OutputStream_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe void WriteTo (global::System.IO.Stream os, global::Org.Eclipse.Jgit.Lib.IProgressMonitor pm)
		{
			const string __id = "writeTo.(Ljava/io/OutputStream;Lorg/eclipse/jgit/lib/ProgressMonitor;)V";
			IntPtr native_os = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (os);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_os);
				__args [1] = new JniArgumentValue ((pm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pm).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_os);
				global::System.GC.KeepAlive (os);
				global::System.GC.KeepAlive (pm);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/util/TemporaryBuffer", DoNotGenerateAcw=true)]
	internal partial class TemporaryBufferInvoker : TemporaryBuffer {
		public TemporaryBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/TemporaryBuffer", typeof (TemporaryBufferInvoker));

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

		/// <summary>Open the overflow output stream, so the remaining output can be stored.</summary>
		/// <returns>the output stream to receive the buffered content, followed by
		///         the remaining output.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='TemporaryBuffer']/method[@name='overflow' and count(parameter)=0]"
		[Register ("overflow", "()Ljava/io/OutputStream;", "GetOverflowHandler")]
		protected override unsafe global::System.IO.Stream Overflow ()
		{
			const string __id = "overflow.()Ljava/io/OutputStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
