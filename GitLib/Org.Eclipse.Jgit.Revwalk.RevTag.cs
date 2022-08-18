using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>An annotated tag.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevTag", DoNotGenerateAcw=true)]
	public partial class RevTag : global::Org.Eclipse.Jgit.Revwalk.RevObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevTag", typeof (RevTag));

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

		protected RevTag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="id">object name for the tag.</param>
		/// <summary>Create a new tag reference.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']/constructor[@name='RevTag' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
		protected unsafe RevTag (global::Org.Eclipse.Jgit.Lib.AnyObjectId id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <summary>Parse the complete tag message and decode it to a string.</summary>
		/// <returns>decoded tag message as a string. Never null.</returns>
		public unsafe string FullMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']/method[@name='getFullMessage' and count(parameter)=0]"
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

		/// <summary>Get a reference to the object this tag was placed on.</summary>
		/// <returns>object this tag refers to (only looked up, not parsed)</returns>
		public unsafe global::Org.Eclipse.Jgit.Revwalk.RevObject Object {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']/method[@name='getObject' and count(parameter)=0]"
			[Register ("getObject", "()Lorg/eclipse/jgit/revwalk/RevObject;", "")]
			get {
				const string __id = "getObject.()Lorg/eclipse/jgit/revwalk/RevObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Parse the tag message and return the first "line" of it.</summary>
		/// <returns>decoded tag message as a string. Never null. The returned string
		///         does not contain any LFs, even if the first paragraph spanned
		///         multiple lines. Embedded LFs are converted to spaces.</returns>
		public unsafe string ShortMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']/method[@name='getShortMessage' and count(parameter)=0]"
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

		/// <summary>Get the name of this tag, from the tag header.</summary>
		/// <returns>name of the tag, according to the tag header.</returns>
		public unsafe string TagName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']/method[@name='getTagName' and count(parameter)=0]"
			[Register ("getTagName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTagName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Parse the tagger identity from the raw buffer.</summary>
		/// <returns>identity of the tagger (name, email) and the time the tag
		///         was made by the tagger; null if no tagger line was found.</returns>
		public unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent TaggerIdent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']/method[@name='getTaggerIdent' and count(parameter)=0]"
			[Register ("getTaggerIdent", "()Lorg/eclipse/jgit/lib/PersonIdent;", "")]
			get {
				const string __id = "getTaggerIdent.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']/method[@name='getType' and count(parameter)=0]"
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

		/// <param name="raw">the canonical formatted tag to be parsed.</param>
		/// <summary>Parse an annotated tag from its canonical format.</summary>
		/// <returns>the parsed tag, in an isolated revision pool that is not
		///         available to the caller.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parse", "([B)Lorg/eclipse/jgit/revwalk/RevTag;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.RevTag Parse (byte[] raw)
		{
			const string __id = "parse.([B)Lorg/eclipse/jgit/revwalk/RevTag;";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_raw);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="rw">the revision pool to allocate the tag within. The tag's object
		///            pointer will be obtained from this pool.</param>
		/// <param name="raw">the canonical formatted tag to be parsed.</param>
		/// <summary>Parse an annotated tag from its canonical format.</summary>
		/// <returns>the parsed tag, in an isolated revision pool that is not
		///         available to the caller.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevTag']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='byte[]']]"
		[Register ("parse", "(Lorg/eclipse/jgit/revwalk/RevWalk;[B)Lorg/eclipse/jgit/revwalk/RevTag;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.RevTag Parse (global::Org.Eclipse.Jgit.Revwalk.RevWalk rw, byte[] raw)
		{
			const string __id = "parse.(Lorg/eclipse/jgit/revwalk/RevWalk;[B)Lorg/eclipse/jgit/revwalk/RevTag;";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rw == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rw).Handle);
				__args [1] = new JniArgumentValue (native_raw);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (rw);
				global::System.GC.KeepAlive (raw);
			}
		}

	}
}
