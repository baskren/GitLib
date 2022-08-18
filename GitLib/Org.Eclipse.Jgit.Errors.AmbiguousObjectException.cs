using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Errors {

	/// <summary>An <c>AbbreviatedObjectId</c> cannot be extended.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='AmbiguousObjectException']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/errors/AmbiguousObjectException", DoNotGenerateAcw=true)]
	public partial class AmbiguousObjectException : global::Java.IO.IOException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/errors/AmbiguousObjectException", typeof (AmbiguousObjectException));

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

		protected AmbiguousObjectException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="id">SHA-1</param>
		/// <param name="candidates">the candidate matches returned by the ObjectReader.</param>
		/// <summary>Construct a MissingObjectException for the specified object id.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='AmbiguousObjectException']/constructor[@name='AmbiguousObjectException' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AbbreviatedObjectId'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AbbreviatedObjectId;Ljava/util/Collection;)V", "")]
		public unsafe AmbiguousObjectException (global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId id, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> candidates) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/AbbreviatedObjectId;Ljava/util/Collection;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_candidates = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (candidates);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [1] = new JniArgumentValue (native_candidates);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_candidates);
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (candidates);
			}
		}

		static Delegate cb_getAbbreviatedObjectId;
#pragma warning disable 0169
		static Delegate GetGetAbbreviatedObjectIdHandler ()
		{
			if (cb_getAbbreviatedObjectId == null)
				cb_getAbbreviatedObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAbbreviatedObjectId);
			return cb_getAbbreviatedObjectId;
		}

		static IntPtr n_GetAbbreviatedObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.AmbiguousObjectException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AbbreviatedObjectId);
		}
#pragma warning restore 0169

		/// <returns>the AbbreviatedObjectId that has more than one result.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId AbbreviatedObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='AmbiguousObjectException']/method[@name='getAbbreviatedObjectId' and count(parameter)=0]"
			[Register ("getAbbreviatedObjectId", "()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetGetAbbreviatedObjectIdHandler")]
			get {
				const string __id = "getAbbreviatedObjectId.()Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCandidates;
#pragma warning disable 0169
		static Delegate GetGetCandidatesHandler ()
		{
			if (cb_getCandidates == null)
				cb_getCandidates = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCandidates);
			return cb_getCandidates;
		}

		static IntPtr n_GetCandidates (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Errors.AmbiguousObjectException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.Candidates);
		}
#pragma warning restore 0169

		/// <returns>the matching candidates (or at least a subset of them).</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> Candidates {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.errors']/class[@name='AmbiguousObjectException']/method[@name='getCandidates' and count(parameter)=0]"
			[Register ("getCandidates", "()Ljava/util/Collection;", "GetGetCandidatesHandler")]
			get {
				const string __id = "getCandidates.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
