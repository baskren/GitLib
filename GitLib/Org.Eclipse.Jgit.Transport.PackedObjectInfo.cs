using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Description of an object stored in a pack file, including offset.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackedObjectInfo']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PackedObjectInfo", DoNotGenerateAcw=true)]
	public partial class PackedObjectInfo : global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap.Entry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PackedObjectInfo", typeof (PackedObjectInfo));

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

		protected PackedObjectInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="id">the identity of the object the new instance tracks.</param>
		/// <summary>Create a new structure to remember information about an object.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackedObjectInfo']/constructor[@name='PackedObjectInfo' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
		public unsafe PackedObjectInfo (global::Org.Eclipse.Jgit.Lib.AnyObjectId id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/AnyObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_getCRC;
#pragma warning disable 0169
		static Delegate GetGetCRCHandler ()
		{
			if (cb_getCRC == null)
				cb_getCRC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCRC);
			return cb_getCRC;
		}

		static int n_GetCRC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CRC;
		}
#pragma warning restore 0169

		static Delegate cb_setCRC_I;
#pragma warning disable 0169
		static Delegate GetSetCRC_IHandler ()
		{
			if (cb_setCRC_I == null)
				cb_setCRC_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCRC_I);
			return cb_setCRC_I;
		}

		static void n_SetCRC_I (IntPtr jnienv, IntPtr native__this, int crc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CRC = crc;
		}
#pragma warning restore 0169

		/// <returns>the 32 bit CRC checksum for the packed data.</returns>
		/// <summary>Record the 32 bit CRC checksum for the packed data.</summary>
		/// <param name="crc">checksum of all packed data (including object type code,
		///            inflated length and delta base reference) as computed by
		///            <c>java.util.zip.CRC32</c>.</param>
		public virtual unsafe int CRC {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackedObjectInfo']/method[@name='getCRC' and count(parameter)=0]"
			[Register ("getCRC", "()I", "GetGetCRCHandler")]
			get {
				const string __id = "getCRC.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackedObjectInfo']/method[@name='setCRC' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCRC", "(I)V", "GetSetCRC_IHandler")]
			set {
				const string __id = "setCRC.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetOffset);
			return cb_getOffset;
		}

		static long n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		static Delegate cb_setOffset_J;
#pragma warning disable 0169
		static Delegate GetSetOffset_JHandler ()
		{
			if (cb_setOffset_J == null)
				cb_setOffset_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetOffset_J);
			return cb_setOffset_J;
		}

		static void n_SetOffset_J (IntPtr jnienv, IntPtr native__this, long offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offset = offset;
		}
#pragma warning restore 0169

		/// <returns>offset in pack when object has been already written, or 0 if it
		///         has not been written yet</returns>
		/// <summary>Set the offset in pack when object has been written to.</summary>
		/// <param name="offset">offset where written object starts</param>
		public virtual unsafe long Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackedObjectInfo']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()J", "GetGetOffsetHandler")]
			get {
				const string __id = "getOffset.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackedObjectInfo']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setOffset", "(J)V", "GetSetOffset_JHandler")]
			set {
				const string __id = "setOffset.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
