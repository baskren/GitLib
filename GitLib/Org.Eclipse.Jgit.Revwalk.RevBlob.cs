using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>A binary file, or a symbolic link.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevBlob']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevBlob", DoNotGenerateAcw=true)]
	public partial class RevBlob : global::Org.Eclipse.Jgit.Revwalk.RevObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevBlob", typeof (RevBlob));

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

		protected RevBlob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="id">object name for the blob.</param>
		/// <summary>Create a new blob reference.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevBlob']/constructor[@name='RevBlob' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
		protected unsafe RevBlob (global::Org.Eclipse.Jgit.Lib.AnyObjectId id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevBlob']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
