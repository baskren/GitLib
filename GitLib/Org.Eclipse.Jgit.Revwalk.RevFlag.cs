using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Application level mark bit for <c>RevObject</c>s.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlag']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevFlag", DoNotGenerateAcw=true)]
	public partial class RevFlag : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlag']/field[@name='SEEN']"
		[Register ("SEEN")]
		public static global::Org.Eclipse.Jgit.Revwalk.RevFlag Seen {
			get {
				const string __id = "SEEN.Lorg/eclipse/jgit/revwalk/RevFlag;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Uninteresting by <c>RevWalk#markUninteresting(RevCommit)</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlag']/field[@name='UNINTERESTING']"
		[Register ("UNINTERESTING")]
		public static global::Org.Eclipse.Jgit.Revwalk.RevFlag Uninteresting {
			get {
				const string __id = "UNINTERESTING.Lorg/eclipse/jgit/revwalk/RevFlag;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevFlag", typeof (RevFlag));

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

		protected RevFlag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getRevWalk;
#pragma warning disable 0169
		static Delegate GetGetRevWalkHandler ()
		{
			if (cb_getRevWalk == null)
				cb_getRevWalk = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRevWalk);
			return cb_getRevWalk;
		}

		static IntPtr n_GetRevWalk (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RevWalk);
		}
#pragma warning restore 0169

		/// <summary>Get the revision walk instance this flag was created from.</summary>
		/// <returns>the walker this flag was allocated out of, and belongs to.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevWalk RevWalk {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlag']/method[@name='getRevWalk' and count(parameter)=0]"
			[Register ("getRevWalk", "()Lorg/eclipse/jgit/revwalk/RevWalk;", "GetGetRevWalkHandler")]
			get {
				const string __id = "getRevWalk.()Lorg/eclipse/jgit/revwalk/RevWalk;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
