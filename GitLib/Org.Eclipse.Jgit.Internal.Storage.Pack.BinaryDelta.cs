using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Pack {

	/// <summary>Recreate a stream from a base stream and a GIT pack delta.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='BinaryDelta']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/pack/BinaryDelta", DoNotGenerateAcw=true)]
	public partial class BinaryDelta : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/pack/BinaryDelta", typeof (BinaryDelta));

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

		protected BinaryDelta (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='BinaryDelta']/constructor[@name='BinaryDelta' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BinaryDelta () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="base">some byte representing an object of some kind.</param>
		/// <param name="delta">a git pack delta defining the transform from one version to
		///            another.</param>
		/// <summary>Apply the changes defined by delta to the data in base, yielding a new
		/// array of bytes.</summary>
		/// <returns>patched base</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='BinaryDelta']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("apply", "([B[B)[B", "")]
		public static unsafe byte[] Apply (byte[] @base, byte[] delta)
		{
			const string __id = "apply.([B[B)[B";
			IntPtr native__base = JNIEnv.NewArray (@base);
			IntPtr native_delta = JNIEnv.NewArray (delta);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__base);
				__args [1] = new JniArgumentValue (native_delta);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (@base != null) {
					JNIEnv.CopyArray (native__base, @base);
					JNIEnv.DeleteLocalRef (native__base);
				}
				if (delta != null) {
					JNIEnv.CopyArray (native_delta, delta);
					JNIEnv.DeleteLocalRef (native_delta);
				}
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (delta);
			}
		}

		/// <param name="base">some byte representing an object of some kind.</param>
		/// <param name="delta">a git pack delta defining the transform from one version to
		///            another.</param>
		/// <param name="result">array to store the result into. If null the result will be
		///            allocated and returned.</param>
		/// <summary>Apply the changes defined by delta to the data in base, yielding a new
		/// array of bytes.</summary>
		/// <returns>either <c>result</c>, or the result array allocated.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='BinaryDelta']/method[@name='apply' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("apply", "([B[B[B)[B", "")]
		public static unsafe byte[] Apply (byte[] @base, byte[] delta, byte[] result)
		{
			const string __id = "apply.([B[B[B)[B";
			IntPtr native__base = JNIEnv.NewArray (@base);
			IntPtr native_delta = JNIEnv.NewArray (delta);
			IntPtr native_result = JNIEnv.NewArray (result);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__base);
				__args [1] = new JniArgumentValue (native_delta);
				__args [2] = new JniArgumentValue (native_result);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (@base != null) {
					JNIEnv.CopyArray (native__base, @base);
					JNIEnv.DeleteLocalRef (native__base);
				}
				if (delta != null) {
					JNIEnv.CopyArray (native_delta, delta);
					JNIEnv.DeleteLocalRef (native_delta);
				}
				if (result != null) {
					JNIEnv.CopyArray (native_result, result);
					JNIEnv.DeleteLocalRef (native_result);
				}
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (delta);
				global::System.GC.KeepAlive (result);
			}
		}

		/// <param name="delta">the delta instruction sequence to format.</param>
		/// <summary>Format this delta as a human readable string.</summary>
		/// <returns>the formatted delta.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='BinaryDelta']/method[@name='format' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("format", "([B)Ljava/lang/String;", "")]
		public static unsafe string Format (byte[] delta)
		{
			const string __id = "format.([B)Ljava/lang/String;";
			IntPtr native_delta = JNIEnv.NewArray (delta);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_delta);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (delta != null) {
					JNIEnv.CopyArray (native_delta, delta);
					JNIEnv.DeleteLocalRef (native_delta);
				}
				global::System.GC.KeepAlive (delta);
			}
		}

		/// <param name="delta">the delta instruction sequence to format.</param>
		/// <param name="includeHeader">true if the header (base size and result size) should be
		///            included in the formatting.</param>
		/// <summary>Format this delta as a human readable string.</summary>
		/// <returns>the formatted delta.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='BinaryDelta']/method[@name='format' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("format", "([BZ)Ljava/lang/String;", "")]
		public static unsafe string Format (byte[] delta, bool includeHeader)
		{
			const string __id = "format.([BZ)Ljava/lang/String;";
			IntPtr native_delta = JNIEnv.NewArray (delta);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_delta);
				__args [1] = new JniArgumentValue (includeHeader);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (delta != null) {
					JNIEnv.CopyArray (native_delta, delta);
					JNIEnv.DeleteLocalRef (native_delta);
				}
				global::System.GC.KeepAlive (delta);
			}
		}

		/// <param name="delta">the delta stream, or at least the header of it.</param>
		/// <summary>Length of the base object in the delta stream.</summary>
		/// <returns>the base object's size.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='BinaryDelta']/method[@name='getBaseSize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getBaseSize", "([B)J", "")]
		public static unsafe long GetBaseSize (byte[] delta)
		{
			const string __id = "getBaseSize.([B)J";
			IntPtr native_delta = JNIEnv.NewArray (delta);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_delta);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (delta != null) {
					JNIEnv.CopyArray (native_delta, delta);
					JNIEnv.DeleteLocalRef (native_delta);
				}
				global::System.GC.KeepAlive (delta);
			}
		}

		/// <param name="delta">the delta stream, or at least the header of it.</param>
		/// <summary>Length of the resulting object in the delta stream.</summary>
		/// <returns>the resulting object's size.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.pack']/class[@name='BinaryDelta']/method[@name='getResultSize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getResultSize", "([B)J", "")]
		public static unsafe long GetResultSize (byte[] delta)
		{
			const string __id = "getResultSize.([B)J";
			IntPtr native_delta = JNIEnv.NewArray (delta);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_delta);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (delta != null) {
					JNIEnv.CopyArray (native_delta, delta);
					JNIEnv.DeleteLocalRef (native_delta);
				}
				global::System.GC.KeepAlive (delta);
			}
		}

	}
}
