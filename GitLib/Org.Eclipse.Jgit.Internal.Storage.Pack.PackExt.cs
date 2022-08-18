using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>A pack file extension.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackExt']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/PackExt", DoNotGenerateAcw=true)]
	public partial class PackExt : global::Java.Lang.Object {

		/// <summary>A pack bitmap index file extension.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackExt']/field[@name='BITMAP_INDEX']"
		[Register ("BITMAP_INDEX")]
		public static global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt BitmapIndex {
			get {
				const string __id = "BITMAP_INDEX.Lorg/eclipse/jgit/internal/storage/pack/PackExt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>A pack index file extension.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackExt']/field[@name='INDEX']"
		[Register ("INDEX")]
		public static global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt Index {
			get {
				const string __id = "INDEX.Lorg/eclipse/jgit/internal/storage/pack/PackExt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>A pack file extension.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackExt']/field[@name='PACK']"
		[Register ("PACK")]
		public static global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt Pack {
			get {
				const string __id = "PACK.Lorg/eclipse/jgit/internal/storage/pack/PackExt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/PackExt", typeof (PackExt));

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

		protected PackExt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getBit;
#pragma warning disable 0169
		static Delegate GetGetBitHandler ()
		{
			if (cb_getBit == null)
				cb_getBit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBit);
			return cb_getBit;
		}

		static int n_GetBit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bit;
		}
#pragma warning restore 0169

		/// <returns>the bit mask of the extension e.g <c>1 &lt;&lt; getPosition()</c>.</returns>
		public virtual unsafe int Bit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackExt']/method[@name='getBit' and count(parameter)=0]"
			[Register ("getBit", "()I", "GetGetBitHandler")]
			get {
				const string __id = "getBit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getExtension;
#pragma warning disable 0169
		static Delegate GetGetExtensionHandler ()
		{
			if (cb_getExtension == null)
				cb_getExtension = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtension);
			return cb_getExtension;
		}

		static IntPtr n_GetExtension (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Extension);
		}
#pragma warning restore 0169

		/// <returns>the file extension.</returns>
		public virtual unsafe string Extension {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackExt']/method[@name='getExtension' and count(parameter)=0]"
			[Register ("getExtension", "()Ljava/lang/String;", "GetGetExtensionHandler")]
			get {
				const string __id = "getExtension.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPosition);
			return cb_getPosition;
		}

		static int n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position;
		}
#pragma warning restore 0169

		/// <returns>the position of the extension in the values array.</returns>
		public virtual unsafe int Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackExt']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()I", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="ext">the file extension.</param>
		/// <summary>Returns a PackExt for the file extension and registers it in the values
		/// array.</summary>
		/// <returns>the PackExt for the ext</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackExt']/method[@name='newPackExt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newPackExt", "(Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/pack/PackExt;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt NewPackExt (string ext)
		{
			const string __id = "newPackExt.(Ljava/lang/String;)Lorg/eclipse/jgit/internal/storage/pack/PackExt;";
			IntPtr native_ext = JNIEnv.NewString ((string)ext);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ext);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_ext);
			}
		}

		/// <returns>all of the PackExt values.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='PackExt']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/eclipse/jgit/internal/storage/pack/PackExt;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt[] Values ()
		{
			const string __id = "values.()[Lorg/eclipse/jgit/internal/storage/pack/PackExt;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackExt));
			} finally {
			}
		}

	}
}
