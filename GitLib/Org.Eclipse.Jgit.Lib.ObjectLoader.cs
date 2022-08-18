using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Base class for a set of loaders for different representations of Git objects.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectLoader", DoNotGenerateAcw=true)]
	public abstract partial class ObjectLoader : global::Java.Lang.Object {
		/// <summary>Simple loader around the cached byte array.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader.SmallObject']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectLoader$SmallObject", DoNotGenerateAcw=true)]
		public partial class SmallObject : global::Org.Eclipse.Jgit.Lib.ObjectLoader {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectLoader$SmallObject", typeof (SmallObject));

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

			protected SmallObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="type">type of the object.</param>
			/// <param name="data">the object's data array. This array will be returned as-is
			///            for the <c>#getCachedBytes()</c> method.</param>
			/// <summary>Construct a small object loader.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader.SmallObject']/constructor[@name='ObjectLoader.SmallObject' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register (".ctor", "(I[B)V", "")]
			public unsafe SmallObject (int type, byte[] data) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I[B)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (type);
					__args [1] = new JniArgumentValue (native_data);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

			static Delegate cb_getSize;
#pragma warning disable 0169
			static Delegate GetGetSizeHandler ()
			{
				if (cb_getSize == null)
					cb_getSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSize);
				return cb_getSize;
			}

			static long n_GetSize (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader.SmallObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Size;
			}
#pragma warning restore 0169

			public override unsafe long Size {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader.SmallObject']/method[@name='getSize' and count(parameter)=0]"
				[Register ("getSize", "()J", "GetGetSizeHandler")]
				get {
					const string __id = "getSize.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetType);
				return cb_getType;
			}

			static int n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader.SmallObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader.SmallObject']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()I", "GetGetTypeHandler")]
				get {
					const string __id = "getType.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getCachedBytes;
#pragma warning disable 0169
			static Delegate GetGetCachedBytesHandler ()
			{
				if (cb_getCachedBytes == null)
					cb_getCachedBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCachedBytes);
				return cb_getCachedBytes;
			}

			static IntPtr n_GetCachedBytes (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader.SmallObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetCachedBytes ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader.SmallObject']/method[@name='getCachedBytes' and count(parameter)=0]"
			[Register ("getCachedBytes", "()[B", "GetGetCachedBytesHandler")]
			public override unsafe byte[] GetCachedBytes ()
			{
				const string __id = "getCachedBytes.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_openStream;
#pragma warning disable 0169
			static Delegate GetOpenStreamHandler ()
			{
				if (cb_openStream == null)
					cb_openStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenStream);
				return cb_openStream;
			}

			static IntPtr n_OpenStream (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader.SmallObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OpenStream ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader.SmallObject']/method[@name='openStream' and count(parameter)=0]"
			[Register ("openStream", "()Lorg/eclipse/jgit/lib/ObjectStream;", "GetOpenStreamHandler")]
			public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectStream OpenStream ()
			{
				const string __id = "openStream.()Lorg/eclipse/jgit/lib/ObjectStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectLoader", typeof (ObjectLoader));

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

		protected ObjectLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/constructor[@name='ObjectLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectLoader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isLarge;
#pragma warning disable 0169
		static Delegate GetIsLargeHandler ()
		{
			if (cb_isLarge == null)
				cb_isLarge = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLarge);
			return cb_isLarge;
		}

		static bool n_IsLarge (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLarge;
		}
#pragma warning restore 0169

		/// <returns>true if this object is too large to obtain as a byte array.
		///         Objects over a certain threshold should be accessed only by their
		///         <c>#openStream()</c> to prevent overflowing the JVM heap.</returns>
		public virtual unsafe bool IsLarge {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='isLarge' and count(parameter)=0]"
			[Register ("isLarge", "()Z", "GetIsLargeHandler")]
			get {
				const string __id = "isLarge.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		public abstract long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get; 
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public abstract int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get; 
		}

		static Delegate cb_copyTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetCopyTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_copyTo_Ljava_io_OutputStream_ == null)
				cb_copyTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CopyTo_Ljava_io_OutputStream_);
			return cb_copyTo_Ljava_io_OutputStream_;
		}

		static void n_CopyTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.CopyTo (@out);
		}
#pragma warning restore 0169

		/// <param name="out">stream to receive the complete copy of this object's data.
		///            Caller is responsible for flushing or closing this stream
		///            after this method returns.</param>
		/// <summary>Copy this object to the output stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='copyTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("copyTo", "(Ljava/io/OutputStream;)V", "GetCopyTo_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void CopyTo (global::System.IO.Stream @out)
		{
			const string __id = "copyTo.(Ljava/io/OutputStream;)V";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (@out);
			}
		}

		/// <summary>Obtain a copy of the bytes of this object.</summary>
		/// <returns>the bytes of this object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "")]
		public unsafe byte[] GetBytes ()
		{
			const string __id = "getBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		/// <param name="sizeLimit">maximum number of bytes to return. If the object is larger
		///            than this limit, <c>LargeObjectException</c> will be thrown.</param>
		/// <summary>Obtain a copy of the bytes of this object.</summary>
		/// <returns>the bytes of this object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBytes", "(I)[B", "")]
		public unsafe byte[] GetBytes (int sizeLimit)
		{
			const string __id = "getBytes.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sizeLimit);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getCachedBytes;
#pragma warning disable 0169
		static Delegate GetGetCachedBytesHandler ()
		{
			if (cb_getCachedBytes == null)
				cb_getCachedBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCachedBytes);
			return cb_getCachedBytes;
		}

		static IntPtr n_GetCachedBytes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCachedBytes ());
		}
#pragma warning restore 0169

		/// <summary>Obtain a reference to the (possibly cached) bytes of this object.</summary>
		/// <returns>the cached bytes of this object. Do not modify it.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='getCachedBytes' and count(parameter)=0]"
		[Register ("getCachedBytes", "()[B", "GetGetCachedBytesHandler")]
		public abstract byte[] GetCachedBytes ();

		static Delegate cb_getCachedBytes_I;
#pragma warning disable 0169
		static Delegate GetGetCachedBytes_IHandler ()
		{
			if (cb_getCachedBytes_I == null)
				cb_getCachedBytes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetCachedBytes_I);
			return cb_getCachedBytes_I;
		}

		static IntPtr n_GetCachedBytes_I (IntPtr jnienv, IntPtr native__this, int sizeLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCachedBytes (sizeLimit));
		}
#pragma warning restore 0169

		/// <param name="sizeLimit">maximum number of bytes to return. If the object size is
		///            larger than this limit and <c>#isLarge()</c> is true,
		///            <c>LargeObjectException</c> will be thrown.</param>
		/// <summary>Obtain a reference to the (possibly cached) bytes of this object.</summary>
		/// <returns>the cached bytes of this object. Do not modify it.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='getCachedBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCachedBytes", "(I)[B", "GetGetCachedBytes_IHandler")]
		public virtual unsafe byte[] GetCachedBytes (int sizeLimit)
		{
			const string __id = "getCachedBytes.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sizeLimit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_openStream;
#pragma warning disable 0169
		static Delegate GetOpenStreamHandler ()
		{
			if (cb_openStream == null)
				cb_openStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenStream);
			return cb_openStream;
		}

		static IntPtr n_OpenStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenStream ());
		}
#pragma warning restore 0169

		/// <summary>Obtain an input stream to read this object's data.</summary>
		/// <returns>a stream of this object's data. Caller must close the stream when
		///         through with it. The returned stream is buffered with a
		///         reasonable buffer size.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='openStream' and count(parameter)=0]"
		[Register ("openStream", "()Lorg/eclipse/jgit/lib/ObjectStream;", "GetOpenStreamHandler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectStream OpenStream ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectLoader", DoNotGenerateAcw=true)]
	internal partial class ObjectLoaderInvoker : ObjectLoader {
		public ObjectLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectLoader", typeof (ObjectLoaderInvoker));

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

		/// <returns>size of object in bytes</returns>
		public override unsafe long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>Git in pack object type, see <c>Constants</c>.</returns>
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Obtain a reference to the (possibly cached) bytes of this object.</summary>
		/// <returns>the cached bytes of this object. Do not modify it.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='getCachedBytes' and count(parameter)=0]"
		[Register ("getCachedBytes", "()[B", "GetGetCachedBytesHandler")]
		public override unsafe byte[] GetCachedBytes ()
		{
			const string __id = "getCachedBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		/// <summary>Obtain an input stream to read this object's data.</summary>
		/// <returns>a stream of this object's data. Caller must close the stream when
		///         through with it. The returned stream is buffered with a
		///         reasonable buffer size.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectLoader']/method[@name='openStream' and count(parameter)=0]"
		[Register ("openStream", "()Lorg/eclipse/jgit/lib/ObjectStream;", "GetOpenStreamHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectStream OpenStream ()
		{
			const string __id = "openStream.()Lorg/eclipse/jgit/lib/ObjectStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
