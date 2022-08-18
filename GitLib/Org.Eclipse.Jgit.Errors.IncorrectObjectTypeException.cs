using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>An inconsistency with respect to handling different object types.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='IncorrectObjectTypeException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/IncorrectObjectTypeException", DoNotGenerateAcw=true)]
	public partial class IncorrectObjectTypeException : global::Java.IO.IOException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/IncorrectObjectTypeException", typeof (IncorrectObjectTypeException));

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

		protected IncorrectObjectTypeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="id">SHA-1</param>
		/// <param name="type">object type</param>
		/// <summary>Construct and IncorrectObjectTypeException for the specified object id.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='IncorrectObjectTypeException']/constructor[@name='IncorrectObjectTypeException' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectId;I)V", "")]
		public unsafe IncorrectObjectTypeException (global::Org.Eclipse.Jgit.Lib.ObjectId id, int type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectId;I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [1] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		/// <param name="id">SHA-1</param>
		/// <param name="type">object type</param>
		/// <summary>Construct and IncorrectObjectTypeException for the specified object id.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='IncorrectObjectTypeException']/constructor[@name='IncorrectObjectTypeException' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectId;Ljava/lang/String;)V", "")]
		public unsafe IncorrectObjectTypeException (global::Org.Eclipse.Jgit.Lib.ObjectId id, string type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectId;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_type = JNIEnv.NewString ((string)type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [1] = new JniArgumentValue (native_type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
				global::System.GC.KeepAlive (id);
			}
		}

	}
}
