using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>A commit reference to a commit in the DAG.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevCommit", DoNotGenerateAcw=true)]
	public partial class RevCommit : global::Org.Eclipse.Jgit.Revwalk.RevObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevCommit", typeof (RevCommit));

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

		protected RevCommit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="id">object name for the commit.</param>
		/// <summary>Create a new commit reference.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/constructor[@name='RevCommit' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
		protected unsafe RevCommit (global::Org.Eclipse.Jgit.Lib.AnyObjectId id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <summary>Parse the author identity from the raw buffer.</summary>
		/// <returns>identity of the author (name, email) and the time the commit was
		///         made by the author; null if no author line was found.</returns>
		public unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent AuthorIdent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getAuthorIdent' and count(parameter)=0]"
			[Register ("getAuthorIdent", "()Lorg/eclipse/jgit/lib/PersonIdent;", "")]
			get {
				const string __id = "getAuthorIdent.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Time from the "committer " line of the buffer.</summary>
		/// <returns>time, expressed as seconds since the epoch.</returns>
		public unsafe int CommitTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getCommitTime' and count(parameter)=0]"
			[Register ("getCommitTime", "()I", "")]
			get {
				const string __id = "getCommitTime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Parse the committer identity from the raw buffer.</summary>
		/// <returns>identity of the committer (name, email) and the time the commit
		///         was made by the committer; null if no committer line was found.</returns>
		public unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent CommitterIdent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getCommitterIdent' and count(parameter)=0]"
			[Register ("getCommitterIdent", "()Lorg/eclipse/jgit/lib/PersonIdent;", "")]
			get {
				const string __id = "getCommitterIdent.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Determine the encoding of the commit message buffer.</summary>
		/// <returns>the preferred encoding of <c>#getRawBuffer()</c>.</returns>
		public unsafe global::Java.Nio.Charset.Charset Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/nio/charset/Charset;", "")]
			get {
				const string __id = "getEncoding.()Ljava/nio/charset/Charset;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Parse the footer lines (e.</summary>
		/// <returns>ordered list of footer lines; empty list if no footers found.</returns>
		public unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Revwalk.FooterLine> FooterLines {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getFooterLines' and count(parameter)=0]"
			[Register ("getFooterLines", "()Ljava/util/List;", "")]
			get {
				const string __id = "getFooterLines.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Revwalk.FooterLine>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Parse the complete commit message and decode it to a string.</summary>
		/// <returns>decoded commit message as a string. Never null.</returns>
		public unsafe string FullMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getFullMessage' and count(parameter)=0]"
			[Register ("getFullMessage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFullMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Get the number of parent commits listed in this commit.</summary>
		/// <returns>number of parents; always a positive value but can be 0.</returns>
		public unsafe int ParentCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getParentCount' and count(parameter)=0]"
			[Register ("getParentCount", "()I", "")]
			get {
				const string __id = "getParentCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Parse the commit message and return the first "line" of it.</summary>
		/// <returns>decoded commit message as a string. Never null. The returned
		///         string does not contain any LFs, even if the first paragraph
		///         spanned multiple lines. Embedded LFs are converted to spaces.</returns>
		public unsafe string ShortMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getShortMessage' and count(parameter)=0]"
			[Register ("getShortMessage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getShortMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Get a reference to this commit's tree.</summary>
		/// <returns>tree of this commit.</returns>
		public unsafe global::Org.Eclipse.Jgit.Revwalk.RevTree Tree {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getTree' and count(parameter)=0]"
			[Register ("getTree", "()Lorg/eclipse/jgit/revwalk/RevTree;", "")]
			get {
				const string __id = "getTree.()Lorg/eclipse/jgit/revwalk/RevTree;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_carry_Lorg_eclipse_jgit_revwalk_RevFlag_;
#pragma warning disable 0169
		static Delegate GetCarry_Lorg_eclipse_jgit_revwalk_RevFlag_Handler ()
		{
			if (cb_carry_Lorg_eclipse_jgit_revwalk_RevFlag_ == null)
				cb_carry_Lorg_eclipse_jgit_revwalk_RevFlag_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Carry_Lorg_eclipse_jgit_revwalk_RevFlag_);
			return cb_carry_Lorg_eclipse_jgit_revwalk_RevFlag_;
		}

		static void n_Carry_Lorg_eclipse_jgit_revwalk_RevFlag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			__this.Carry (flag);
		}
#pragma warning restore 0169

		/// <param name="flag">the single flag value to carry back onto parents.</param>
		/// <summary>Carry a RevFlag set on this commit to its parents.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='carry' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("carry", "(Lorg/eclipse/jgit/revwalk/RevFlag;)V", "GetCarry_Lorg_eclipse_jgit_revwalk_RevFlag_Handler")]
		public virtual unsafe void Carry (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "carry.(Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		/// <param name="keyName">footer key to find values of, case insensitive.</param>
		/// <summary>Get the values of all footer lines with the given key.</summary>
		/// <returns>values of footers with key of <c>keyName</c>, ordered by their
		///         order of appearance. Duplicates may be returned if the same
		///         footer appeared more than once. Empty list if no footers appear
		///         with the specified key, or there are no footers at all.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getFooterLines' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFooterLines", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> GetFooterLines (string keyName)
		{
			const string __id = "getFooterLines.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_keyName = JNIEnv.NewString ((string)keyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_keyName);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyName);
			}
		}

		/// <param name="keyName">footer key to find values of, case insensitive.</param>
		/// <summary>Get the values of all footer lines with the given key.</summary>
		/// <returns>values of footers with key of <c>keyName</c>, ordered by their
		///         order of appearance. Duplicates may be returned if the same
		///         footer appeared more than once. Empty list if no footers appear
		///         with the specified key, or there are no footers at all.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getFooterLines' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.FooterKey']]"
		[Register ("getFooterLines", "(Lorg/eclipse/jgit/revwalk/FooterKey;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> GetFooterLines (global::Org.Eclipse.Jgit.Revwalk.FooterKey keyName)
		{
			const string __id = "getFooterLines.(Lorg/eclipse/jgit/revwalk/FooterKey;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyName == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyName).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (keyName);
			}
		}

		/// <param name="nth">parent index to obtain. Must be in the range 0 through
		///            <c>#getParentCount()</c>-1.</param>
		/// <summary>Get the nth parent from this commit's parent list.</summary>
		/// <returns>the specified parent.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getParent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getParent", "(I)Lorg/eclipse/jgit/revwalk/RevCommit;", "")]
		public unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit GetParent (int nth)
		{
			const string __id = "getParent.(I)Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nth);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Obtain an array of all parents (&lt;b&gt;NOTE - THIS IS NOT A COPY&lt;/b&gt;).</summary>
		/// <returns>the array of parents.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getParents' and count(parameter)=0]"
		[Register ("getParents", "()[Lorg/eclipse/jgit/revwalk/RevCommit;", "")]
		public unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit[] GetParents ()
		{
			const string __id = "getParents.()[Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Jgit.Revwalk.RevCommit[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Revwalk.RevCommit));
			} finally {
			}
		}

		/// <summary>Obtain the raw unparsed commit body (&lt;b&gt;NOTE - THIS IS NOT A COPY&lt;/b&gt;).</summary>
		/// <returns>the raw unparsed commit body. This is &lt;b&gt;NOT A COPY&lt;/b&gt;.
		///         Altering the contents of this buffer may alter the walker's
		///         knowledge of this commit, and the results it produces.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='getRawBuffer' and count(parameter)=0]"
		[Register ("getRawBuffer", "()[B", "")]
		public unsafe byte[] GetRawBuffer ()
		{
			const string __id = "getRawBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		/// <param name="raw">the canonical formatted commit to be parsed.</param>
		/// <summary>Parse a commit from its canonical format.</summary>
		/// <returns>the parsed commit, in an isolated revision pool that is not
		///         available to the caller.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parse", "([B)Lorg/eclipse/jgit/revwalk/RevCommit;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit Parse (byte[] raw)
		{
			const string __id = "parse.([B)Lorg/eclipse/jgit/revwalk/RevCommit;";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_raw);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="rw">the revision pool to allocate the commit within. The commit's
		///            tree and parent pointers will be obtained from this pool.</param>
		/// <param name="raw">the canonical formatted commit to be parsed.</param>
		/// <summary>Parse a commit from its canonical format.</summary>
		/// <returns>the parsed commit, in an isolated revision pool that is not
		///         available to the caller.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='byte[]']]"
		[Register ("parse", "(Lorg/eclipse/jgit/revwalk/RevWalk;[B)Lorg/eclipse/jgit/revwalk/RevCommit;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit Parse (global::Org.Eclipse.Jgit.Revwalk.RevWalk rw, byte[] raw)
		{
			const string __id = "parse.(Lorg/eclipse/jgit/revwalk/RevWalk;[B)Lorg/eclipse/jgit/revwalk/RevCommit;";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rw == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rw).Handle);
				__args [1] = new JniArgumentValue (native_raw);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (rw);
				global::System.GC.KeepAlive (raw);
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		/// <summary>Reset this commit to allow another RevWalk with the same instances.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommit']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
