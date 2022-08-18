using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Translation bundle for the DFS storage implementation.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsText']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsText", DoNotGenerateAcw=true)]
	public partial class DfsText : global::Org.Eclipse.Jgit.Nls.TranslationBundle {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsText']/field[@name='cannotReadBackDelta']"
		[Register ("cannotReadBackDelta")]
		public string CannotReadBackDelta {
			get {
				const string __id = "cannotReadBackDelta.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotReadBackDelta.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsText']/field[@name='cannotReadIndex']"
		[Register ("cannotReadIndex")]
		public string CannotReadIndex {
			get {
				const string __id = "cannotReadIndex.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotReadIndex.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsText']/field[@name='shortReadOfBlock']"
		[Register ("shortReadOfBlock")]
		public string ShortReadOfBlock {
			get {
				const string __id = "shortReadOfBlock.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "shortReadOfBlock.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsText']/field[@name='shortReadOfIndex']"
		[Register ("shortReadOfIndex")]
		public string ShortReadOfIndex {
			get {
				const string __id = "shortReadOfIndex.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "shortReadOfIndex.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsText']/field[@name='unexpectedEofInPack']"
		[Register ("unexpectedEofInPack")]
		public string UnexpectedEofInPack {
			get {
				const string __id = "unexpectedEofInPack.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unexpectedEofInPack.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsText']/field[@name='willNotStoreEmptyPack']"
		[Register ("willNotStoreEmptyPack")]
		public string WillNotStoreEmptyPack {
			get {
				const string __id = "willNotStoreEmptyPack.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "willNotStoreEmptyPack.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsText", typeof (DfsText));

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

		protected DfsText (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsText']/constructor[@name='DfsText' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DfsText () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <returns>instance of this translation bundle</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsText']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lorg/eclipse/jgit/internal/storage/dfs/DfsText;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsText Get ()
		{
			const string __id = "get.()Lorg/eclipse/jgit/internal/storage/dfs/DfsText;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Dfs.DfsText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
