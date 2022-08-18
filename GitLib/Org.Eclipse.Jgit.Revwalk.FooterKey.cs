using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Case insensitive key for a <c>FooterLine</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FooterKey']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/FooterKey", DoNotGenerateAcw=true)]
	public sealed partial class FooterKey : global::Java.Lang.Object {

		/// <summary>Standard <c>Acked-by</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FooterKey']/field[@name='ACKED_BY']"
		[Register ("ACKED_BY")]
		public static global::Org.Eclipse.Jgit.Revwalk.FooterKey AckedBy {
			get {
				const string __id = "ACKED_BY.Lorg/eclipse/jgit/revwalk/FooterKey;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.FooterKey> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FooterKey']/field[@name='CC']"
		[Register ("CC")]
		public static global::Org.Eclipse.Jgit.Revwalk.FooterKey Cc {
			get {
				const string __id = "CC.Lorg/eclipse/jgit/revwalk/FooterKey;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.FooterKey> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Standard <c>Signed-off-by</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FooterKey']/field[@name='SIGNED_OFF_BY']"
		[Register ("SIGNED_OFF_BY")]
		public static global::Org.Eclipse.Jgit.Revwalk.FooterKey SignedOffBy {
			get {
				const string __id = "SIGNED_OFF_BY.Lorg/eclipse/jgit/revwalk/FooterKey;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.FooterKey> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/FooterKey", typeof (FooterKey));

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

		internal FooterKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="keyName">name of the footer line.</param>
		/// <summary>Create a key for a specific footer line.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FooterKey']/constructor[@name='FooterKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe FooterKey (string keyName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_keyName = JNIEnv.NewString ((string)keyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_keyName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyName);
			}
		}

		/// <returns>name of this footer line.</returns>
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='FooterKey']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
