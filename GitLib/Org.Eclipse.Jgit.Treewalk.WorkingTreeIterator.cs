using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk {

	/// <summary>Walks a working directory tree as part of a <c>TreeWalk</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/WorkingTreeIterator", DoNotGenerateAcw=true)]
	public abstract partial class WorkingTreeIterator : global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator {

		/// <summary>Repository that is the root level being iterated over</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/field[@name='repository']"
		[Register ("repository")]
		protected global::Org.Eclipse.Jgit.Lib.Repository Repository {
			get {
				const string __id = "repository.Lorg/eclipse/jgit/lib/Repository;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repository.Lorg/eclipse/jgit/lib/Repository;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		/// <summary>A single entry within a working directory tree.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/WorkingTreeIterator$Entry", DoNotGenerateAcw=true)]
		protected internal abstract partial class Entry : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/WorkingTreeIterator$Entry", typeof (Entry));

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

			protected Entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/constructor[@name='WorkingTreeIterator.Entry' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe Entry () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_getLastModified;
#pragma warning disable 0169
			static Delegate GetGetLastModifiedHandler ()
			{
				if (cb_getLastModified == null)
					cb_getLastModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLastModified);
				return cb_getLastModified;
			}

			static long n_GetLastModified (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LastModified;
			}
#pragma warning restore 0169

			public abstract long LastModified {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='getLastModified' and count(parameter)=0]"
				[Register ("getLastModified", "()J", "GetGetLastModifiedHandler")]
				get; 
			}

			static Delegate cb_getLength;
#pragma warning disable 0169
			static Delegate GetGetLengthHandler ()
			{
				if (cb_getLength == null)
					cb_getLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLength);
				return cb_getLength;
			}

			static long n_GetLength (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Length;
			}
#pragma warning restore 0169

			public abstract long Length {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='getLength' and count(parameter)=0]"
				[Register ("getLength", "()J", "GetGetLengthHandler")]
				get; 
			}

			static Delegate cb_getMode;
#pragma warning disable 0169
			static Delegate GetGetModeHandler ()
			{
				if (cb_getMode == null)
					cb_getMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMode);
				return cb_getMode;
			}

			static IntPtr n_GetMode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Mode);
			}
#pragma warning restore 0169

			public abstract global::Org.Eclipse.Jgit.Lib.FileMode Mode {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='getMode' and count(parameter)=0]"
				[Register ("getMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetModeHandler")]
				get; 
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			public abstract string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get; 
			}

			static Delegate cb_openInputStream;
#pragma warning disable 0169
			static Delegate GetOpenInputStreamHandler ()
			{
				if (cb_openInputStream == null)
					cb_openInputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenInputStream);
				return cb_openInputStream;
			}

			static IntPtr n_OpenInputStream (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.OpenInputStream ());
			}
#pragma warning restore 0169

			/// <summary>Obtain an input stream to read the file content.</summary>
			/// <returns>a stream to read from the file.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='openInputStream' and count(parameter)=0]"
			[Register ("openInputStream", "()Ljava/io/InputStream;", "GetOpenInputStreamHandler")]
			public abstract global::System.IO.Stream OpenInputStream ();

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/WorkingTreeIterator$Entry", DoNotGenerateAcw=true)]
		internal partial class EntryInvoker : Entry {
			public EntryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/WorkingTreeIterator$Entry", typeof (EntryInvoker));

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			/// <summary>Get the last modified time of this entry.</summary>
			/// <returns>time since the epoch (in ms) of the last change.</returns>
			public override unsafe long LastModified {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='getLastModified' and count(parameter)=0]"
				[Register ("getLastModified", "()J", "GetGetLastModifiedHandler")]
				get {
					const string __id = "getLastModified.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			/// <summary>Get the byte length of this entry.</summary>
			/// <returns>size of this file, in bytes.</returns>
			public override unsafe long Length {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='getLength' and count(parameter)=0]"
				[Register ("getLength", "()J", "GetGetLengthHandler")]
				get {
					const string __id = "getLength.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			/// <summary>Get the type of this entry.</summary>
			/// <returns>a file mode constant from <c>FileMode</c>.</returns>
			public override unsafe global::Org.Eclipse.Jgit.Lib.FileMode Mode {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='getMode' and count(parameter)=0]"
				[Register ("getMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetModeHandler")]
				get {
					const string __id = "getMode.()Lorg/eclipse/jgit/lib/FileMode;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			/// <summary>Get the name of this entry within its directory.</summary>
			/// <returns>name of the entry.</returns>
			public override unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			/// <summary>Obtain an input stream to read the file content.</summary>
			/// <returns>a stream to read from the file.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.Entry']/method[@name='openInputStream' and count(parameter)=0]"
			[Register ("openInputStream", "()Ljava/io/InputStream;", "GetOpenInputStreamHandler")]
			public override unsafe global::System.IO.Stream OpenInputStream ()
			{
				const string __id = "openInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		/// <summary>The result of a metadata-comparison between the current entry and a
		/// <c>DirCacheEntry</c></summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.MetadataDiff']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff", DoNotGenerateAcw=true)]
		public sealed partial class MetadataDiff : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.MetadataDiff']/field[@name='DIFFER_BY_METADATA']"
			[Register ("DIFFER_BY_METADATA")]
			public static global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff DifferByMetadata {
				get {
					const string __id = "DIFFER_BY_METADATA.Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.MetadataDiff']/field[@name='DIFFER_BY_TIMESTAMP']"
			[Register ("DIFFER_BY_TIMESTAMP")]
			public static global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff DifferByTimestamp {
				get {
					const string __id = "DIFFER_BY_TIMESTAMP.Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.MetadataDiff']/field[@name='EQUAL']"
			[Register ("EQUAL")]
			public static global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff Equal {
				get {
					const string __id = "EQUAL.Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.MetadataDiff']/field[@name='SMUDGED']"
			[Register ("SMUDGED")]
			public static global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff Smudged {
				get {
					const string __id = "SMUDGED.Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff", typeof (MetadataDiff));

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

			internal MetadataDiff (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.MetadataDiff']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator.MetadataDiff']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/WorkingTreeIterator", typeof (WorkingTreeIterator));

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

		protected WorkingTreeIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="prefix">position of this iterator in the repository tree. The value
		///            may be null or the empty string to indicate the prefix is the
		///            root of the repository. A trailing slash ('/') is
		///            automatically appended if the prefix does not end in '/'.</param>
		/// <param name="options">working tree options to be used</param>
		/// <summary>Create a new iterator with no parent and a prefix.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/constructor[@name='WorkingTreeIterator' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.treewalk.WorkingTreeOptions']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/eclipse/jgit/treewalk/WorkingTreeOptions;)V", "")]
		protected unsafe WorkingTreeIterator (string prefix, global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions options) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/eclipse/jgit/treewalk/WorkingTreeOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_prefix);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				global::System.GC.KeepAlive (options);
			}
		}

		/// <param name="p">parent tree iterator.</param>
		/// <summary>Create an iterator for a subtree of an existing iterator.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/constructor[@name='WorkingTreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V", "")]
		protected unsafe WorkingTreeIterator (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p);
			}
		}

		/// <param name="options">working tree options to be used</param>
		/// <summary>Create a new iterator with no parent.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/constructor[@name='WorkingTreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.WorkingTreeOptions']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/treewalk/WorkingTreeOptions;)V", "")]
		protected unsafe WorkingTreeIterator (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions options) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/treewalk/WorkingTreeOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (options);
			}
		}

		static Delegate cb_getEntryAttributesNode;
#pragma warning disable 0169
		static Delegate GetGetEntryAttributesNodeHandler ()
		{
			if (cb_getEntryAttributesNode == null)
				cb_getEntryAttributesNode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEntryAttributesNode);
			return cb_getEntryAttributesNode;
		}

		static IntPtr n_GetEntryAttributesNode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EntryAttributesNode);
		}
#pragma warning restore 0169

		/// <summary>Retrieves the <c>AttributesNode</c> for the current entry.</summary>
		/// <returns>
		///   <c>AttributesNode</c> for the current entry.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Attributes.AttributesNode EntryAttributesNode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='getEntryAttributesNode' and count(parameter)=0]"
			[Register ("getEntryAttributesNode", "()Lorg/eclipse/jgit/attributes/AttributesNode;", "GetGetEntryAttributesNodeHandler")]
			get {
				const string __id = "getEntryAttributesNode.()Lorg/eclipse/jgit/attributes/AttributesNode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesNode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEntryContentLength;
#pragma warning disable 0169
		static Delegate GetGetEntryContentLengthHandler ()
		{
			if (cb_getEntryContentLength == null)
				cb_getEntryContentLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetEntryContentLength);
			return cb_getEntryContentLength;
		}

		static long n_GetEntryContentLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryContentLength;
		}
#pragma warning restore 0169

		/// <summary>Get the filtered input length of this entry</summary>
		/// <returns>size of the content, in bytes</returns>
		public virtual unsafe long EntryContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='getEntryContentLength' and count(parameter)=0]"
			[Register ("getEntryContentLength", "()J", "GetGetEntryContentLengthHandler")]
			get {
				const string __id = "getEntryContentLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getEntryLastModified;
#pragma warning disable 0169
		static Delegate GetGetEntryLastModifiedHandler ()
		{
			if (cb_getEntryLastModified == null)
				cb_getEntryLastModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetEntryLastModified);
			return cb_getEntryLastModified;
		}

		static long n_GetEntryLastModified (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryLastModified;
		}
#pragma warning restore 0169

		/// <summary>Get the last modified time of this entry.</summary>
		/// <returns>last modified time of this file, in milliseconds since the epoch
		///         (Jan 1, 1970 UTC).</returns>
		public virtual unsafe long EntryLastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='getEntryLastModified' and count(parameter)=0]"
			[Register ("getEntryLastModified", "()J", "GetGetEntryLastModifiedHandler")]
			get {
				const string __id = "getEntryLastModified.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getEntryLength;
#pragma warning disable 0169
		static Delegate GetGetEntryLengthHandler ()
		{
			if (cb_getEntryLength == null)
				cb_getEntryLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetEntryLength);
			return cb_getEntryLength;
		}

		static long n_GetEntryLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryLength;
		}
#pragma warning restore 0169

		/// <summary>Get the raw byte length of this entry.</summary>
		/// <returns>size of this file, in bytes.</returns>
		public virtual unsafe long EntryLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='getEntryLength' and count(parameter)=0]"
			[Register ("getEntryLength", "()J", "GetGetEntryLengthHandler")]
			get {
				const string __id = "getEntryLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getGlobalAttributesNode;
#pragma warning disable 0169
		static Delegate GetGetGlobalAttributesNodeHandler ()
		{
			if (cb_getGlobalAttributesNode == null)
				cb_getGlobalAttributesNode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGlobalAttributesNode);
			return cb_getGlobalAttributesNode;
		}

		static IntPtr n_GetGlobalAttributesNode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GlobalAttributesNode);
		}
#pragma warning restore 0169

		/// <summary>Retrieves the <c>AttributesNode</c> that holds the information located
		/// in system-wide file.</summary>
		/// <returns>the <c>AttributesNode</c> that holds the information located in
		///         system-wide file.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Attributes.AttributesNode GlobalAttributesNode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='getGlobalAttributesNode' and count(parameter)=0]"
			[Register ("getGlobalAttributesNode", "()Lorg/eclipse/jgit/attributes/AttributesNode;", "GetGetGlobalAttributesNodeHandler")]
			get {
				const string __id = "getGlobalAttributesNode.()Lorg/eclipse/jgit/attributes/AttributesNode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesNode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasId;
#pragma warning disable 0169
		static Delegate GetHasIdHandler ()
		{
			if (cb_hasId == null)
				cb_hasId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasId);
			return cb_hasId;
		}

		static bool n_HasId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasId;
		}
#pragma warning restore 0169

		public override unsafe bool HasId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='hasId' and count(parameter)=0]"
			[Register ("hasId", "()Z", "GetHasIdHandler")]
			get {
				const string __id = "hasId.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getInfoAttributesNode;
#pragma warning disable 0169
		static Delegate GetGetInfoAttributesNodeHandler ()
		{
			if (cb_getInfoAttributesNode == null)
				cb_getInfoAttributesNode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInfoAttributesNode);
			return cb_getInfoAttributesNode;
		}

		static IntPtr n_GetInfoAttributesNode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InfoAttributesNode);
		}
#pragma warning restore 0169

		/// <summary>Retrieves the <c>AttributesNode</c> that holds the information located
		/// in $GIT_DIR/info/attributes file.</summary>
		/// <returns>the <c>AttributesNode</c> that holds the information located in
		///         $GIT_DIR/info/attributes file.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Attributes.AttributesNode InfoAttributesNode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='getInfoAttributesNode' and count(parameter)=0]"
			[Register ("getInfoAttributesNode", "()Lorg/eclipse/jgit/attributes/AttributesNode;", "GetGetInfoAttributesNodeHandler")]
			get {
				const string __id = "getInfoAttributesNode.()Lorg/eclipse/jgit/attributes/AttributesNode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesNode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEntryIgnored;
#pragma warning disable 0169
		static Delegate GetIsEntryIgnoredHandler ()
		{
			if (cb_isEntryIgnored == null)
				cb_isEntryIgnored = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEntryIgnored);
			return cb_isEntryIgnored;
		}

		static bool n_IsEntryIgnored (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEntryIgnored;
		}
#pragma warning restore 0169

		/// <summary>Determine if the current entry path is ignored by an ignore rule.</summary>
		/// <returns>true if the entry was ignored by an ignore rule file.</returns>
		public virtual unsafe bool IsEntryIgnored {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='isEntryIgnored' and count(parameter)=0]"
			[Register ("isEntryIgnored", "()Z", "GetIsEntryIgnoredHandler")]
			get {
				const string __id = "isEntryIgnored.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOptions;
#pragma warning disable 0169
		static Delegate GetGetOptionsHandler ()
		{
			if (cb_getOptions == null)
				cb_getOptions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOptions);
			return cb_getOptions;
		}

		static IntPtr n_GetOptions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Options);
		}
#pragma warning restore 0169

		/// <summary>Returns the working tree options used by this iterator.</summary>
		/// <returns>working tree options</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions Options {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='getOptions' and count(parameter)=0]"
			[Register ("getOptions", "()Lorg/eclipse/jgit/treewalk/WorkingTreeOptions;", "GetGetOptionsHandler")]
			get {
				const string __id = "getOptions.()Lorg/eclipse/jgit/treewalk/WorkingTreeOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_back_I;
#pragma warning disable 0169
		static Delegate GetBack_IHandler ()
		{
			if (cb_back_I == null)
				cb_back_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Back_I);
			return cb_back_I;
		}

		static void n_Back_I (IntPtr jnienv, IntPtr native__this, int delta)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Back (delta);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='back' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("back", "(I)V", "GetBack_IHandler")]
		public override unsafe void Back (int delta)
		{
			const string __id = "back.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delta);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_compareMetadata_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
#pragma warning disable 0169
		static Delegate GetCompareMetadata_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler ()
		{
			if (cb_compareMetadata_Lorg_eclipse_jgit_dircache_DirCacheEntry_ == null)
				cb_compareMetadata_Lorg_eclipse_jgit_dircache_DirCacheEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CompareMetadata_Lorg_eclipse_jgit_dircache_DirCacheEntry_);
			return cb_compareMetadata_Lorg_eclipse_jgit_dircache_DirCacheEntry_;
		}

		static IntPtr n_CompareMetadata_Lorg_eclipse_jgit_dircache_DirCacheEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entry = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (native_entry, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompareMetadata (entry));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='compareMetadata' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry']]"
		[Register ("compareMetadata", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;)Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;", "GetCompareMetadata_Lorg_eclipse_jgit_dircache_DirCacheEntry_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff CompareMetadata (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry entry)
		{
			const string __id = "compareMetadata.(Lorg/eclipse/jgit/dircache/DirCacheEntry;)Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$MetadataDiff;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.MetadataDiff> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (entry);
			}
		}

		static Delegate cb_current;
#pragma warning disable 0169
		static Delegate GetCurrentHandler ()
		{
			if (cb_current == null)
				cb_current = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Current);
			return cb_current;
		}

		static IntPtr n_Current (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Current ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='current' and count(parameter)=0]"
		[Register ("current", "()Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$Entry;", "GetCurrentHandler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry Current ()
		{
			const string __id = "current.()Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$Entry;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_eof;
#pragma warning disable 0169
		static Delegate GetEofHandler ()
		{
			if (cb_eof == null)
				cb_eof = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Eof);
			return cb_eof;
		}

		static bool n_Eof (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Eof ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='eof' and count(parameter)=0]"
		[Register ("eof", "()Z", "GetEofHandler")]
		public override unsafe bool Eof ()
		{
			const string __id = "eof.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_first;
#pragma warning disable 0169
		static Delegate GetFirstHandler ()
		{
			if (cb_first == null)
				cb_first = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_First);
			return cb_first;
		}

		static bool n_First (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.First ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='first' and count(parameter)=0]"
		[Register ("first", "()Z", "GetFirstHandler")]
		public override unsafe bool First ()
		{
			const string __id = "first.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getIndexFileMode_Lorg_eclipse_jgit_dircache_DirCacheIterator_;
#pragma warning disable 0169
		static Delegate GetGetIndexFileMode_Lorg_eclipse_jgit_dircache_DirCacheIterator_Handler ()
		{
			if (cb_getIndexFileMode_Lorg_eclipse_jgit_dircache_DirCacheIterator_ == null)
				cb_getIndexFileMode_Lorg_eclipse_jgit_dircache_DirCacheIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetIndexFileMode_Lorg_eclipse_jgit_dircache_DirCacheIterator_);
			return cb_getIndexFileMode_Lorg_eclipse_jgit_dircache_DirCacheIterator_;
		}

		static IntPtr n_GetIndexFileMode_Lorg_eclipse_jgit_dircache_DirCacheIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_indexIter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var indexIter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheIterator> (native_indexIter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetIndexFileMode (indexIter));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="indexIter">
		///   <c>DirCacheIterator</c> positioned at the same entry as this
		///            iterator or null if no <c>DirCacheIterator</c> is available
		///            at this iterator's current entry</param>
		/// <summary>Get the file mode to use for the current entry when it is to be updated
		/// in the index.</summary>
		/// <returns>index file mode</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='getIndexFileMode' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheIterator']]"
		[Register ("getIndexFileMode", "(Lorg/eclipse/jgit/dircache/DirCacheIterator;)Lorg/eclipse/jgit/lib/FileMode;", "GetGetIndexFileMode_Lorg_eclipse_jgit_dircache_DirCacheIterator_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode GetIndexFileMode (global::Org.Eclipse.Jgit.Dircache.DirCacheIterator indexIter)
		{
			const string __id = "getIndexFileMode.(Lorg/eclipse/jgit/dircache/DirCacheIterator;)Lorg/eclipse/jgit/lib/FileMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((indexIter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indexIter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (indexIter);
			}
		}

		static Delegate cb_idBuffer;
#pragma warning disable 0169
		static Delegate GetIdBufferHandler ()
		{
			if (cb_idBuffer == null)
				cb_idBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IdBuffer);
			return cb_idBuffer;
		}

		static IntPtr n_IdBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.IdBuffer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='idBuffer' and count(parameter)=0]"
		[Register ("idBuffer", "()[B", "GetIdBufferHandler")]
		public override unsafe byte[] IdBuffer ()
		{
			const string __id = "idBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_idOffset;
#pragma warning disable 0169
		static Delegate GetIdOffsetHandler ()
		{
			if (cb_idOffset == null)
				cb_idOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_IdOffset);
			return cb_idOffset;
		}

		static int n_IdOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdOffset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='idOffset' and count(parameter)=0]"
		[Register ("idOffset", "()I", "GetIdOffsetHandler")]
		public override unsafe int IdOffset ()
		{
			const string __id = "idOffset.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_idSubmodule_Ljava_io_File_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_;
#pragma warning disable 0169
		static Delegate GetIdSubmodule_Ljava_io_File_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_Handler ()
		{
			if (cb_idSubmodule_Ljava_io_File_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_ == null)
				cb_idSubmodule_Ljava_io_File_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_IdSubmodule_Ljava_io_File_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_);
			return cb_idSubmodule_Ljava_io_File_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_;
		}

		static IntPtr n_IdSubmodule_Ljava_io_File_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_directory, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var directory = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_directory, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.IdSubmodule (directory, e));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='idSubmodule' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator.Entry']]"
		[Register ("idSubmodule", "(Ljava/io/File;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$Entry;)[B", "GetIdSubmodule_Ljava_io_File_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_Handler")]
		protected virtual unsafe byte[] IdSubmodule (global::Java.IO.File directory, global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry e)
		{
			const string __id = "idSubmodule.(Ljava/io/File;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$Entry;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((directory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directory).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (directory);
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_idSubmodule_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_;
#pragma warning disable 0169
		static Delegate GetIdSubmodule_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_Handler ()
		{
			if (cb_idSubmodule_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_ == null)
				cb_idSubmodule_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_IdSubmodule_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_);
			return cb_idSubmodule_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_;
		}

		static IntPtr n_IdSubmodule_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.IdSubmodule (e));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='idSubmodule' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator.Entry']]"
		[Register ("idSubmodule", "(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$Entry;)[B", "GetIdSubmodule_Lorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_Handler")]
		protected virtual unsafe byte[] IdSubmodule (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry e)
		{
			const string __id = "idSubmodule.(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$Entry;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_init_arrayLorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_;
#pragma warning disable 0169
		static Delegate GetInit_arrayLorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_Handler ()
		{
			if (cb_init_arrayLorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_ == null)
				cb_init_arrayLorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Init_arrayLorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_);
			return cb_init_arrayLorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_;
		}

		static void n_Init_arrayLorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_list)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var list = (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry[]) JNIEnv.GetArray (native_list, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry));
			__this.Init (list);
			if (list != null)
				JNIEnv.CopyArray (list, native_list);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='init' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator.Entry[]']]"
		[Register ("init", "([Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$Entry;)V", "GetInit_arrayLorg_eclipse_jgit_treewalk_WorkingTreeIterator_Entry_Handler")]
		protected virtual unsafe void Init (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator.Entry[] list)
		{
			const string __id = "init.([Lorg/eclipse/jgit/treewalk/WorkingTreeIterator$Entry;)V";
			IntPtr native_list = JNIEnv.NewArray (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (list != null) {
					JNIEnv.CopyArray (native_list, list);
					JNIEnv.DeleteLocalRef (native_list);
				}
				global::System.GC.KeepAlive (list);
			}
		}

		static Delegate cb_initRootIterator_Lorg_eclipse_jgit_lib_Repository_;
#pragma warning disable 0169
		static Delegate GetInitRootIterator_Lorg_eclipse_jgit_lib_Repository_Handler ()
		{
			if (cb_initRootIterator_Lorg_eclipse_jgit_lib_Repository_ == null)
				cb_initRootIterator_Lorg_eclipse_jgit_lib_Repository_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InitRootIterator_Lorg_eclipse_jgit_lib_Repository_);
			return cb_initRootIterator_Lorg_eclipse_jgit_lib_Repository_;
		}

		static void n_InitRootIterator_Lorg_eclipse_jgit_lib_Repository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var repo = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repo, JniHandleOwnership.DoNotTransfer);
			__this.InitRootIterator (repo);
		}
#pragma warning restore 0169

		/// <param name="repo">the repository.</param>
		/// <summary>Initialize this iterator for the root level of a repository.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='initRootIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("initRootIterator", "(Lorg/eclipse/jgit/lib/Repository;)V", "GetInitRootIterator_Lorg_eclipse_jgit_lib_Repository_Handler")]
		protected virtual unsafe void InitRootIterator (global::Org.Eclipse.Jgit.Lib.Repository repo)
		{
			const string __id = "initRootIterator.(Lorg/eclipse/jgit/lib/Repository;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_isEntryIgnored_I;
#pragma warning disable 0169
		static Delegate GetInvokeIsEntryIgnored_IHandler ()
		{
			if (cb_isEntryIgnored_I == null)
				cb_isEntryIgnored_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_InvokeIsEntryIgnored_I);
			return cb_isEntryIgnored_I;
		}

		static bool n_InvokeIsEntryIgnored_I (IntPtr jnienv, IntPtr native__this, int pLen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeIsEntryIgnored (pLen);
		}
#pragma warning restore 0169

		/// <param name="pLen">the length of the path in the path buffer.</param>
		/// <summary>Determine if the entry path is ignored by an ignore rule.</summary>
		/// <returns>true if the entry is ignored by an ignore rule.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='isEntryIgnored' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isEntryIgnored", "(I)Z", "GetInvokeIsEntryIgnored_IHandler")]
		protected virtual unsafe bool InvokeIsEntryIgnored (int pLen)
		{
			const string __id = "isEntryIgnored.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pLen);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isModeDifferent_I;
#pragma warning disable 0169
		static Delegate GetIsModeDifferent_IHandler ()
		{
			if (cb_isModeDifferent_I == null)
				cb_isModeDifferent_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsModeDifferent_I);
			return cb_isModeDifferent_I;
		}

		static bool n_IsModeDifferent_I (IntPtr jnienv, IntPtr native__this, int rawMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsModeDifferent (rawMode);
		}
#pragma warning restore 0169

		/// <param name="rawMode">rawMode</param>
		/// <summary>Is the file mode of the current entry different than the given raw mode?</summary>
		/// <returns>true if different, false otherwise</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='isModeDifferent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isModeDifferent", "(I)Z", "GetIsModeDifferent_IHandler")]
		public virtual unsafe bool IsModeDifferent (int rawMode)
		{
			const string __id = "isModeDifferent.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rawMode);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZHandler ()
		{
			if (cb_isModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_Z == null)
				cb_isModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_IsModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_Z);
			return cb_isModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_Z;
		}

		[Obsolete]
		static bool n_IsModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_entry, bool forceContentCheck)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entry = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (native_entry, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsModified (entry, forceContentCheck);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="entry">the entry from the dircache we want to compare against</param>
		/// <param name="forceContentCheck">True if the actual file content should be checked if
		///            modification time differs.</param>
		/// <summary>Checks whether this entry differs from a given entry from the
		/// <c>DirCache</c>.</summary>
		/// <returns>true if content is most likely different.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='isModified' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry'] and parameter[2][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("isModified", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;Z)Z", "GetIsModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZHandler")]
		public virtual unsafe bool IsModified (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry entry, bool forceContentCheck)
		{
			const string __id = "isModified.(Lorg/eclipse/jgit/dircache/DirCacheEntry;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				__args [1] = new JniArgumentValue (forceContentCheck);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (entry);
			}
		}

		static Delegate cb_isModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZLorg_eclipse_jgit_lib_ObjectReader_;
#pragma warning disable 0169
		static Delegate GetIsModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZLorg_eclipse_jgit_lib_ObjectReader_Handler ()
		{
			if (cb_isModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZLorg_eclipse_jgit_lib_ObjectReader_ == null)
				cb_isModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZLorg_eclipse_jgit_lib_ObjectReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_Z) n_IsModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZLorg_eclipse_jgit_lib_ObjectReader_);
			return cb_isModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZLorg_eclipse_jgit_lib_ObjectReader_;
		}

		static bool n_IsModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZLorg_eclipse_jgit_lib_ObjectReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entry, bool forceContentCheck, IntPtr native_reader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entry = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheEntry> (native_entry, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsModified (entry, forceContentCheck, reader);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="entry">the entry from the dircache we want to compare against</param>
		/// <param name="forceContentCheck">True if the actual file content should be checked if
		///            modification time differs.</param>
		/// <param name="reader">access to repository objects if necessary. Should not be null.</param>
		/// <summary>Checks whether this entry differs from a given entry from the
		/// <c>DirCache</c>.</summary>
		/// <returns>true if content is most likely different.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='isModified' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.dircache.DirCacheEntry'] and parameter[2][@type='boolean'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register ("isModified", "(Lorg/eclipse/jgit/dircache/DirCacheEntry;ZLorg/eclipse/jgit/lib/ObjectReader;)Z", "GetIsModified_Lorg_eclipse_jgit_dircache_DirCacheEntry_ZLorg_eclipse_jgit_lib_ObjectReader_Handler")]
		public virtual unsafe bool IsModified (global::Org.Eclipse.Jgit.Dircache.DirCacheEntry entry, bool forceContentCheck, global::Org.Eclipse.Jgit.Lib.ObjectReader reader)
		{
			const string __id = "isModified.(Lorg/eclipse/jgit/dircache/DirCacheEntry;ZLorg/eclipse/jgit/lib/ObjectReader;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				__args [1] = new JniArgumentValue (forceContentCheck);
				__args [2] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (entry);
				global::System.GC.KeepAlive (reader);
			}
		}

		static Delegate cb_next_I;
#pragma warning disable 0169
		static Delegate GetNext_IHandler ()
		{
			if (cb_next_I == null)
				cb_next_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Next_I);
			return cb_next_I;
		}

		static void n_Next_I (IntPtr jnienv, IntPtr native__this, int delta)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Next (delta);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='next' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("next", "(I)V", "GetNext_IHandler")]
		public override unsafe void Next (int delta)
		{
			const string __id = "next.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delta);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_openEntryStream;
#pragma warning disable 0169
		static Delegate GetOpenEntryStreamHandler ()
		{
			if (cb_openEntryStream == null)
				cb_openEntryStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenEntryStream);
			return cb_openEntryStream;
		}

		static IntPtr n_OpenEntryStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.OpenEntryStream ());
		}
#pragma warning restore 0169

		/// <summary>Obtain an input stream to read the file content.</summary>
		/// <returns>a stream to read from the file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='openEntryStream' and count(parameter)=0]"
		[Register ("openEntryStream", "()Ljava/io/InputStream;", "GetOpenEntryStreamHandler")]
		public virtual unsafe global::System.IO.Stream OpenEntryStream ()
		{
			const string __id = "openEntryStream.()Ljava/io/InputStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDirCacheIterator_Lorg_eclipse_jgit_treewalk_TreeWalk_I;
#pragma warning disable 0169
		static Delegate GetSetDirCacheIterator_Lorg_eclipse_jgit_treewalk_TreeWalk_IHandler ()
		{
			if (cb_setDirCacheIterator_Lorg_eclipse_jgit_treewalk_TreeWalk_I == null)
				cb_setDirCacheIterator_Lorg_eclipse_jgit_treewalk_TreeWalk_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SetDirCacheIterator_Lorg_eclipse_jgit_treewalk_TreeWalk_I);
			return cb_setDirCacheIterator_Lorg_eclipse_jgit_treewalk_TreeWalk_I;
		}

		static void n_SetDirCacheIterator_Lorg_eclipse_jgit_treewalk_TreeWalk_I (IntPtr jnienv, IntPtr native__this, IntPtr native_walk, int treeId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.TreeWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			__this.SetDirCacheIterator (walk, treeId);
		}
#pragma warning restore 0169

		/// <param name="walk">the walk that will be advancing this iterator.</param>
		/// <param name="treeId">index of the matching <c>DirCacheIterator</c>.</param>
		/// <summary>Define the matching <c>DirCacheIterator</c>, to optimize ObjectIds.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeIterator']/method[@name='setDirCacheIterator' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.treewalk.TreeWalk'] and parameter[2][@type='int']]"
		[Register ("setDirCacheIterator", "(Lorg/eclipse/jgit/treewalk/TreeWalk;I)V", "GetSetDirCacheIterator_Lorg_eclipse_jgit_treewalk_TreeWalk_IHandler")]
		public virtual unsafe void SetDirCacheIterator (global::Org.Eclipse.Jgit.Treewalk.TreeWalk walk, int treeId)
		{
			const string __id = "setDirCacheIterator.(Lorg/eclipse/jgit/treewalk/TreeWalk;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				__args [1] = new JniArgumentValue (treeId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (walk);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/WorkingTreeIterator", DoNotGenerateAcw=true)]
	internal partial class WorkingTreeIteratorInvoker : WorkingTreeIterator {
		public WorkingTreeIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/WorkingTreeIterator", typeof (WorkingTreeIteratorInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		/// <param name="reader">reader to load the tree data from.</param>
		/// <summary>Create a new iterator for the current entry's subtree.</summary>
		/// <returns>a new parser that walks over the current subtree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='createSubtreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register ("createSubtreeIterator", "(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;", "GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator CreateSubtreeIterator (global::Org.Eclipse.Jgit.Lib.ObjectReader reader)
		{
			const string __id = "createSubtreeIterator.(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

	}
}
