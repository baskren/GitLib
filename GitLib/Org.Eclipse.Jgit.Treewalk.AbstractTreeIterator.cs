using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk {

	/// <summary>Walks a Git tree (directory) in Git sort order.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/AbstractTreeIterator", DoNotGenerateAcw=true)]
	public abstract partial class AbstractTreeIterator : global::Java.Lang.Object {
		/// <summary>Default size for the <c>#path</c> buffer.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/field[@name='DEFAULT_PATH_SIZE']"
		[Register ("DEFAULT_PATH_SIZE")]
		protected const int DefaultPathSize = (int) 128;


		/// <summary>Mode bits for the current entry.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/field[@name='mode']"
		[Register ("mode")]
		protected int Mode {
			get {
				const string __id = "mode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		/// <summary>Path buffer for the current entry.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/field[@name='path']"
		[Register ("path")]
		protected IList<byte> Path {
			get {
				const string __id = "path.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "path.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Total length of the current entry's complete path from the root.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/field[@name='pathLen']"
		[Register ("pathLen")]
		protected int PathLen {
			get {
				const string __id = "pathLen.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pathLen.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		/// <summary>Position within <c>#path</c> this iterator starts writing at.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/field[@name='pathOffset']"
		[Register ("pathOffset")]
		protected int PathOffset {
			get {
				const string __id = "pathOffset.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pathOffset.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		/// <summary>A dummy object id buffer that matches the zero ObjectId.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/field[@name='zeroid']"
		[Register ("zeroid")]
		protected static IList<byte> Zeroid {
			get {
				const string __id = "zeroid.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/AbstractTreeIterator", typeof (AbstractTreeIterator));

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

		protected AbstractTreeIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a new iterator with no parent.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/constructor[@name='AbstractTreeIterator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AbstractTreeIterator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="prefix">position of this iterator in the repository tree. The value
		///            may be null or the empty array to indicate the prefix is the
		///            root of the repository. A trailing slash ('/') is
		///            automatically appended if the prefix does not end in '/'.</param>
		/// <summary>Create a new iterator with no parent and a prefix.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/constructor[@name='AbstractTreeIterator' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		protected unsafe AbstractTreeIterator (byte[] prefix) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_prefix = JNIEnv.NewArray (prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (prefix != null) {
					JNIEnv.CopyArray (native_prefix, prefix);
					JNIEnv.DeleteLocalRef (native_prefix);
				}
				global::System.GC.KeepAlive (prefix);
			}
		}

		/// <param name="prefix">position of this iterator in the repository tree. The value
		///            may be null or the empty string to indicate the prefix is the
		///            root of the repository. A trailing slash ('/') is
		///            automatically appended if the prefix does not end in '/'.</param>
		/// <summary>Create a new iterator with no parent and a prefix.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/constructor[@name='AbstractTreeIterator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe AbstractTreeIterator (string prefix) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		/// <param name="p">parent tree iterator.</param>
		/// <summary>Create an iterator for a subtree of an existing iterator.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/constructor[@name='AbstractTreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)V", "")]
		protected unsafe AbstractTreeIterator (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)V";

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

		/// <param name="p">parent tree iterator.</param>
		/// <param name="childPath">path array to be used by the child iterator. This path must
		///            contain the path from the top of the walk to the first child
		///            and must end with a '/'.</param>
		/// <param name="childPathOffset">position within &lt;code&gt;childPath&lt;/code&gt; where the child can
		///            insert its data. The value at
		///            &lt;code&gt;childPath[childPathOffset-1]&lt;/code&gt; must be '/'.</param>
		/// <summary>Create an iterator for a subtree of an existing iterator.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/constructor[@name='AbstractTreeIterator' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;[BI)V", "")]
		protected unsafe AbstractTreeIterator (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator p, byte[] childPath, int childPathOffset) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;[BI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_childPath = JNIEnv.NewArray (childPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [1] = new JniArgumentValue (native_childPath);
				__args [2] = new JniArgumentValue (childPathOffset);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (childPath != null) {
					JNIEnv.CopyArray (native_childPath, childPath);
					JNIEnv.DeleteLocalRef (native_childPath);
				}
				global::System.GC.KeepAlive (p);
				global::System.GC.KeepAlive (childPath);
			}
		}

		static Delegate cb_getEntryFileMode;
#pragma warning disable 0169
		static Delegate GetGetEntryFileModeHandler ()
		{
			if (cb_getEntryFileMode == null)
				cb_getEntryFileMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEntryFileMode);
			return cb_getEntryFileMode;
		}

		static IntPtr n_GetEntryFileMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EntryFileMode);
		}
#pragma warning restore 0169

		/// <returns>the file mode of the current entry.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode EntryFileMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getEntryFileMode' and count(parameter)=0]"
			[Register ("getEntryFileMode", "()Lorg/eclipse/jgit/lib/FileMode;", "GetGetEntryFileModeHandler")]
			get {
				const string __id = "getEntryFileMode.()Lorg/eclipse/jgit/lib/FileMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEntryObjectId;
#pragma warning disable 0169
		static Delegate GetGetEntryObjectIdHandler ()
		{
			if (cb_getEntryObjectId == null)
				cb_getEntryObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEntryObjectId);
			return cb_getEntryObjectId;
		}

		static IntPtr n_GetEntryObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EntryObjectId);
		}
#pragma warning restore 0169

		/// <summary>Get the object id of the current entry.</summary>
		/// <returns>an object id for the current entry.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId EntryObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getEntryObjectId' and count(parameter)=0]"
			[Register ("getEntryObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetEntryObjectIdHandler")]
			get {
				const string __id = "getEntryObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEntryPathHashCode;
#pragma warning disable 0169
		static Delegate GetGetEntryPathHashCodeHandler ()
		{
			if (cb_getEntryPathHashCode == null)
				cb_getEntryPathHashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEntryPathHashCode);
			return cb_getEntryPathHashCode;
		}

		static int n_GetEntryPathHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryPathHashCode;
		}
#pragma warning restore 0169

		/// <summary>Get the current entry's path hash code.</summary>
		/// <returns>path hash code; any integer may be returned.</returns>
		public virtual unsafe int EntryPathHashCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getEntryPathHashCode' and count(parameter)=0]"
			[Register ("getEntryPathHashCode", "()I", "GetGetEntryPathHashCodeHandler")]
			get {
				const string __id = "getEntryPathHashCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getEntryPathLength;
#pragma warning disable 0169
		static Delegate GetGetEntryPathLengthHandler ()
		{
			if (cb_getEntryPathLength == null)
				cb_getEntryPathLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEntryPathLength);
			return cb_getEntryPathLength;
		}

		static int n_GetEntryPathLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryPathLength;
		}
#pragma warning restore 0169

		/// <returns>length of the path in <c>#getEntryPathBuffer()</c>.</returns>
		public virtual unsafe int EntryPathLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getEntryPathLength' and count(parameter)=0]"
			[Register ("getEntryPathLength", "()I", "GetGetEntryPathLengthHandler")]
			get {
				const string __id = "getEntryPathLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getEntryPathString;
#pragma warning disable 0169
		static Delegate GetGetEntryPathStringHandler ()
		{
			if (cb_getEntryPathString == null)
				cb_getEntryPathString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEntryPathString);
			return cb_getEntryPathString;
		}

		static IntPtr n_GetEntryPathString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EntryPathString);
		}
#pragma warning restore 0169

		/// <returns>path of the current entry, as a string.</returns>
		public virtual unsafe string EntryPathString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getEntryPathString' and count(parameter)=0]"
			[Register ("getEntryPathString", "()Ljava/lang/String;", "GetGetEntryPathStringHandler")]
			get {
				const string __id = "getEntryPathString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEntryRawMode;
#pragma warning disable 0169
		static Delegate GetGetEntryRawModeHandler ()
		{
			if (cb_getEntryRawMode == null)
				cb_getEntryRawMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEntryRawMode);
			return cb_getEntryRawMode;
		}

		static int n_GetEntryRawMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryRawMode;
		}
#pragma warning restore 0169

		/// <returns>the file mode of the current entry as bits</returns>
		public virtual unsafe int EntryRawMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getEntryRawMode' and count(parameter)=0]"
			[Register ("getEntryRawMode", "()I", "GetGetEntryRawModeHandler")]
			get {
				const string __id = "getEntryRawMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasId;
		}
#pragma warning restore 0169

		public abstract bool HasId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='hasId' and count(parameter)=0]"
			[Register ("hasId", "()Z", "GetHasIdHandler")]
			get; 
		}

		static Delegate cb_getNameLength;
#pragma warning disable 0169
		static Delegate GetGetNameLengthHandler ()
		{
			if (cb_getNameLength == null)
				cb_getNameLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNameLength);
			return cb_getNameLength;
		}

		static int n_GetNameLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NameLength;
		}
#pragma warning restore 0169

		/// <returns>the length of the name component of the path for the current entry</returns>
		public virtual unsafe int NameLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getNameLength' and count(parameter)=0]"
			[Register ("getNameLength", "()I", "GetGetNameLengthHandler")]
			get {
				const string __id = "getNameLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNameOffset;
#pragma warning disable 0169
		static Delegate GetGetNameOffsetHandler ()
		{
			if (cb_getNameOffset == null)
				cb_getNameOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNameOffset);
			return cb_getNameOffset;
		}

		static int n_GetNameOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NameOffset;
		}
#pragma warning restore 0169

		/// <summary>JGit internal API for use by <c>DirCacheCheckout</c></summary>
		/// <returns>start of name component part within <c>#getEntryPathBuffer()</c></returns>
		public virtual unsafe int NameOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getNameOffset' and count(parameter)=0]"
			[Register ("getNameOffset", "()I", "GetGetNameOffsetHandler")]
			get {
				const string __id = "getNameOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Back (delta);
		}
#pragma warning restore 0169

		/// <param name="delta">number of entries to move the iterator by. Must be a positive,
		///            non-zero integer.</param>
		/// <summary>Move to prior entry, populating this iterator with the entry data.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='back' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("back", "(I)V", "GetBack_IHandler")]
		public abstract void Back (int delta);

		static Delegate cb_createEmptyTreeIterator;
#pragma warning disable 0169
		static Delegate GetCreateEmptyTreeIteratorHandler ()
		{
			if (cb_createEmptyTreeIterator == null)
				cb_createEmptyTreeIterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateEmptyTreeIterator);
			return cb_createEmptyTreeIterator;
		}

		static IntPtr n_CreateEmptyTreeIterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateEmptyTreeIterator ());
		}
#pragma warning restore 0169

		/// <summary>Create a new iterator as though the current entry were a subtree.</summary>
		/// <returns>a new empty tree iterator.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='createEmptyTreeIterator' and count(parameter)=0]"
		[Register ("createEmptyTreeIterator", "()Lorg/eclipse/jgit/treewalk/EmptyTreeIterator;", "GetCreateEmptyTreeIteratorHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator CreateEmptyTreeIterator ()
		{
			const string __id = "createEmptyTreeIterator.()Lorg/eclipse/jgit/treewalk/EmptyTreeIterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.EmptyTreeIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_;
#pragma warning disable 0169
		static Delegate GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Handler ()
		{
			if (cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_ == null)
				cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_);
			return cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_;
		}

		static IntPtr n_CreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSubtreeIterator (reader));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="reader">reader to load the tree data from.</param>
		/// <summary>Create a new iterator for the current entry's subtree.</summary>
		/// <returns>a new parser that walks over the current subtree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='createSubtreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register ("createSubtreeIterator", "(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;", "GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Handler")]
		public abstract global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator CreateSubtreeIterator (global::Org.Eclipse.Jgit.Lib.ObjectReader reader);

		static Delegate cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_MutableObjectId_;
#pragma warning disable 0169
		static Delegate GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_MutableObjectId_Handler ()
		{
			if (cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_MutableObjectId_ == null)
				cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_MutableObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_MutableObjectId_);
			return cb_createSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_MutableObjectId_;
		}

		static IntPtr n_CreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_MutableObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader, IntPtr native_idBuffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reader = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			var idBuffer = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (native_idBuffer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSubtreeIterator (reader, idBuffer));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="reader">reader to load the tree data from.</param>
		/// <param name="idBuffer">temporary ObjectId buffer for use by this method.</param>
		/// <summary>Create a new iterator for the current entry's subtree.</summary>
		/// <returns>a new parser that walks over the current subtree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='createSubtreeIterator' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='org.eclipse.jgit.lib.MutableObjectId']]"
		[Register ("createSubtreeIterator", "(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/MutableObjectId;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;", "GetCreateSubtreeIterator_Lorg_eclipse_jgit_lib_ObjectReader_Lorg_eclipse_jgit_lib_MutableObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator CreateSubtreeIterator (global::Org.Eclipse.Jgit.Lib.ObjectReader reader, global::Org.Eclipse.Jgit.Lib.MutableObjectId idBuffer)
		{
			const string __id = "createSubtreeIterator.(Lorg/eclipse/jgit/lib/ObjectReader;Lorg/eclipse/jgit/lib/MutableObjectId;)Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				__args [1] = new JniArgumentValue ((idBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idBuffer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
				global::System.GC.KeepAlive (idBuffer);
			}
		}

		static Delegate cb_ensurePathCapacity_II;
#pragma warning disable 0169
		static Delegate GetEnsurePathCapacity_IIHandler ()
		{
			if (cb_ensurePathCapacity_II == null)
				cb_ensurePathCapacity_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_EnsurePathCapacity_II);
			return cb_ensurePathCapacity_II;
		}

		static void n_EnsurePathCapacity_II (IntPtr jnienv, IntPtr native__this, int capacity, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnsurePathCapacity (capacity, len);
		}
#pragma warning restore 0169

		/// <param name="capacity">the amount of bytes to hold</param>
		/// <param name="len">the amount of live bytes in path buffer</param>
		/// <summary>Ensure that path is capable to hold at least <c>capacity</c> bytes</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='ensurePathCapacity' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ensurePathCapacity", "(II)V", "GetEnsurePathCapacity_IIHandler")]
		protected virtual unsafe void EnsurePathCapacity (int capacity, int len)
		{
			const string __id = "ensurePathCapacity.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (capacity);
				__args [1] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Eof ();
		}
#pragma warning restore 0169

		/// <summary>Is this tree iterator at its EOF point (no more entries)?</summary>
		/// <returns>true if we have walked all entries and have none left.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='eof' and count(parameter)=0]"
		[Register ("eof", "()Z", "GetEofHandler")]
		public abstract bool Eof ();

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.First ();
		}
#pragma warning restore 0169

		/// <summary>Is this tree iterator positioned on its first entry?</summary>
		/// <returns>true if the iterator is positioned on the first entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='first' and count(parameter)=0]"
		[Register ("first", "()Z", "GetFirstHandler")]
		public abstract bool First ();

		static Delegate cb_getEntryObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_;
#pragma warning disable 0169
		static Delegate GetGetEntryObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_Handler ()
		{
			if (cb_getEntryObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_ == null)
				cb_getEntryObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetEntryObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_);
			return cb_getEntryObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_;
		}

		static void n_GetEntryObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.MutableObjectId> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.GetEntryObjectId (@out);
		}
#pragma warning restore 0169

		/// <param name="out">buffer to copy the object id into.</param>
		/// <summary>Obtain the ObjectId for the current entry.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getEntryObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.MutableObjectId']]"
		[Register ("getEntryObjectId", "(Lorg/eclipse/jgit/lib/MutableObjectId;)V", "GetGetEntryObjectId_Lorg_eclipse_jgit_lib_MutableObjectId_Handler")]
		public virtual unsafe void GetEntryObjectId (global::Org.Eclipse.Jgit.Lib.MutableObjectId @out)
		{
			const string __id = "getEntryObjectId.(Lorg/eclipse/jgit/lib/MutableObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_getEntryPathBuffer;
#pragma warning disable 0169
		static Delegate GetGetEntryPathBufferHandler ()
		{
			if (cb_getEntryPathBuffer == null)
				cb_getEntryPathBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEntryPathBuffer);
			return cb_getEntryPathBuffer;
		}

		static IntPtr n_GetEntryPathBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEntryPathBuffer ());
		}
#pragma warning restore 0169

		/// <summary>Get the current entry path buffer.</summary>
		/// <returns>the internal buffer holding the current path.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getEntryPathBuffer' and count(parameter)=0]"
		[Register ("getEntryPathBuffer", "()[B", "GetGetEntryPathBufferHandler")]
		public virtual unsafe byte[] GetEntryPathBuffer ()
		{
			const string __id = "getEntryPathBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getName_arrayBI;
#pragma warning disable 0169
		static Delegate GetGetName_arrayBIHandler ()
		{
			if (cb_getName_arrayBI == null)
				cb_getName_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_GetName_arrayBI);
			return cb_getName_arrayBI;
		}

		static void n_GetName_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, int offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.GetName (buffer, offset);
			if (buffer != null)
				JNIEnv.CopyArray (buffer, native_buffer);
		}
#pragma warning restore 0169

		/// <param name="buffer">the buffer to get the name into, it is assumed that buffer can
		///            hold the name</param>
		/// <param name="offset">the offset of the name in the buffer</param>
		/// <summary>Get the name component of the current entry path into the provided
		/// buffer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='getName' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getName", "([BI)V", "GetGetName_arrayBIHandler")]
		public virtual unsafe void GetName (byte[] buffer, int offset)
		{
			const string __id = "getName.([BI)V";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (buffer);
			}
		}

		static Delegate cb_growPath_I;
#pragma warning disable 0169
		static Delegate GetGrowPath_IHandler ()
		{
			if (cb_growPath_I == null)
				cb_growPath_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_GrowPath_I);
			return cb_growPath_I;
		}

		static void n_GrowPath_I (IntPtr jnienv, IntPtr native__this, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GrowPath (len);
		}
#pragma warning restore 0169

		/// <param name="len">number of live bytes in the path buffer. This many bytes will
		///            be moved into the larger buffer.</param>
		/// <summary>Grow the path buffer larger.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='growPath' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("growPath", "(I)V", "GetGrowPath_IHandler")]
		protected virtual unsafe void GrowPath (int len)
		{
			const string __id = "growPath.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.IdBuffer ());
		}
#pragma warning restore 0169

		/// <summary>Get the byte array buffer object IDs must be copied out of.</summary>
		/// <returns>byte array the implementation stores object IDs within.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='idBuffer' and count(parameter)=0]"
		[Register ("idBuffer", "()[B", "GetIdBufferHandler")]
		public abstract byte[] IdBuffer ();

		static Delegate cb_idEqual_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
#pragma warning disable 0169
		static Delegate GetIdEqual_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler ()
		{
			if (cb_idEqual_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ == null)
				cb_idEqual_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IdEqual_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_);
			return cb_idEqual_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
		}

		static bool n_IdEqual_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_otherIterator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var otherIterator = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_otherIterator, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IdEqual (otherIterator);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="otherIterator">the other iterator to test against.</param>
		/// <summary>Check if the current entry of both iterators has the same id.</summary>
		/// <returns>true if both iterators have the same object id; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='idEqual' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register ("idEqual", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Z", "GetIdEqual_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler")]
		public virtual unsafe bool IdEqual (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator otherIterator)
		{
			const string __id = "idEqual.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((otherIterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) otherIterator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (otherIterator);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdOffset ();
		}
#pragma warning restore 0169

		/// <summary>Get the position within <c>#idBuffer()</c> of this entry's ObjectId.</summary>
		/// <returns>offset into the array returned by <c>#idBuffer()</c> where the
		///         ObjectId must be copied out of.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='idOffset' and count(parameter)=0]"
		[Register ("idOffset", "()I", "GetIdOffsetHandler")]
		public abstract int IdOffset ();

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Next (delta);
		}
#pragma warning restore 0169

		/// <param name="delta">number of entries to move the iterator by. Must be a positive,
		///            non-zero integer.</param>
		/// <summary>Move to next entry, populating this iterator with the entry data.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='next' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("next", "(I)V", "GetNext_IHandler")]
		public abstract void Next (int delta);

		static Delegate cb_pathCompare_arrayBIII;
#pragma warning disable 0169
		static Delegate GetPathCompare_arrayBIIIHandler ()
		{
			if (cb_pathCompare_arrayBIII == null)
				cb_pathCompare_arrayBIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_I) n_PathCompare_arrayBIII);
			return cb_pathCompare_arrayBIII;
		}

		static int n_PathCompare_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, int pos, int end, int pathMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = (byte[]) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PathCompare (buf, pos, end, pathMode);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="buf">the raw path buffer.</param>
		/// <param name="pos">position to start reading the raw buffer.</param>
		/// <param name="end">one past the end of the raw buffer (length is end - pos).</param>
		/// <param name="pathMode">the mode of the path.</param>
		/// <summary>Compare the path of this current entry to a raw buffer.</summary>
		/// <returns>-1 if this entry sorts first; 0 if the entries are equal; 1 if
		///         p's entry sorts first.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='pathCompare' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("pathCompare", "([BIII)I", "GetPathCompare_arrayBIIIHandler")]
		public virtual unsafe int PathCompare (byte[] buf, int pos, int end, int pathMode)
		{
			const string __id = "pathCompare.([BIII)I";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (end);
				__args [3] = new JniArgumentValue (pathMode);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

		static Delegate cb_pathCompare_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
#pragma warning disable 0169
		static Delegate GetPathCompare_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler ()
		{
			if (cb_pathCompare_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ == null)
				cb_pathCompare_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PathCompare_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_);
			return cb_pathCompare_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
		}

		static int n_PathCompare_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_p, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PathCompare (p);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="p">the other iterator to compare the path against.</param>
		/// <summary>Compare the path of this current entry to another iterator's entry.</summary>
		/// <returns>-1 if this entry sorts first; 0 if the entries are equal; 1 if
		///         p's entry sorts first.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='pathCompare' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register ("pathCompare", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)I", "GetPathCompare_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler")]
		public virtual unsafe int PathCompare (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator p)
		{
			const string __id = "pathCompare.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		/// <summary>Position this iterator on the first entry.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_skip;
#pragma warning disable 0169
		static Delegate GetSkipHandler ()
		{
			if (cb_skip == null)
				cb_skip = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Skip);
			return cb_skip;
		}

		static void n_Skip (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Skip ();
		}
#pragma warning restore 0169

		/// <summary>Advance to the next tree entry, populating this iterator with its data.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='skip' and count(parameter)=0]"
		[Register ("skip", "()V", "GetSkipHandler")]
		public virtual unsafe void Skip ()
		{
			const string __id = "skip.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopWalk;
#pragma warning disable 0169
		static Delegate GetStopWalkHandler ()
		{
			if (cb_stopWalk == null)
				cb_stopWalk = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopWalk);
			return cb_stopWalk;
		}

		static void n_StopWalk (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopWalk ();
		}
#pragma warning restore 0169

		/// <summary>Indicates to the iterator that no more entries will be read.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='stopWalk' and count(parameter)=0]"
		[Register ("stopWalk", "()V", "GetStopWalkHandler")]
		public virtual unsafe void StopWalk ()
		{
			const string __id = "stopWalk.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/AbstractTreeIterator", DoNotGenerateAcw=true)]
	internal partial class AbstractTreeIteratorInvoker : AbstractTreeIterator {
		public AbstractTreeIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/AbstractTreeIterator", typeof (AbstractTreeIteratorInvoker));

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

		/// <returns>true if the entry has a valid ObjectId.</returns>
		public override unsafe bool HasId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='hasId' and count(parameter)=0]"
			[Register ("hasId", "()Z", "GetHasIdHandler")]
			get {
				const string __id = "hasId.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="delta">number of entries to move the iterator by. Must be a positive,
		///            non-zero integer.</param>
		/// <summary>Move to prior entry, populating this iterator with the entry data.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='back' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("back", "(I)V", "GetBack_IHandler")]
		public override unsafe void Back (int delta)
		{
			const string __id = "back.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delta);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
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

		/// <summary>Is this tree iterator at its EOF point (no more entries)?</summary>
		/// <returns>true if we have walked all entries and have none left.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='eof' and count(parameter)=0]"
		[Register ("eof", "()Z", "GetEofHandler")]
		public override unsafe bool Eof ()
		{
			const string __id = "eof.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <summary>Is this tree iterator positioned on its first entry?</summary>
		/// <returns>true if the iterator is positioned on the first entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='first' and count(parameter)=0]"
		[Register ("first", "()Z", "GetFirstHandler")]
		public override unsafe bool First ()
		{
			const string __id = "first.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <summary>Get the byte array buffer object IDs must be copied out of.</summary>
		/// <returns>byte array the implementation stores object IDs within.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='idBuffer' and count(parameter)=0]"
		[Register ("idBuffer", "()[B", "GetIdBufferHandler")]
		public override unsafe byte[] IdBuffer ()
		{
			const string __id = "idBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		/// <summary>Get the position within <c>#idBuffer()</c> of this entry's ObjectId.</summary>
		/// <returns>offset into the array returned by <c>#idBuffer()</c> where the
		///         ObjectId must be copied out of.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='idOffset' and count(parameter)=0]"
		[Register ("idOffset", "()I", "GetIdOffsetHandler")]
		public override unsafe int IdOffset ()
		{
			const string __id = "idOffset.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <param name="delta">number of entries to move the iterator by. Must be a positive,
		///            non-zero integer.</param>
		/// <summary>Move to next entry, populating this iterator with the entry data.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='AbstractTreeIterator']/method[@name='next' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("next", "(I)V", "GetNext_IHandler")]
		public override unsafe void Next (int delta)
		{
			const string __id = "next.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delta);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
