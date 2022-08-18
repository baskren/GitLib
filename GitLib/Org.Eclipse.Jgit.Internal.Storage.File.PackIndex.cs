using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.File {

	/// <summary>Access path to locate objects by <c>ObjectId</c> in a <c>PackFile</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackIndex", DoNotGenerateAcw=true)]
	public abstract partial class PackIndex : global::Java.Lang.Object, global::Java.Lang.IIterable {

		/// <summary>Footer checksum applied on the bottom of the pack file.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/field[@name='packChecksum']"
		[Register ("packChecksum")]
		protected IList<byte> PackChecksum {
			get {
				const string __id = "packChecksum.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packChecksum.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		/// <summary>Represent mutable entry of pack index consisting of object id and offset
		/// in pack (both mutable).</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex.MutableEntry']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackIndex$MutableEntry", DoNotGenerateAcw=true)]
		public partial class MutableEntry : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackIndex$MutableEntry", typeof (MutableEntry));

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

			protected MutableEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex.MutableEntry']/constructor[@name='PackIndex.MutableEntry' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MutableEntry () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_getOffset;
#pragma warning disable 0169
			static Delegate GetGetOffsetHandler ()
			{
				if (cb_getOffset == null)
					cb_getOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetOffset);
				return cb_getOffset;
			}

			static long n_GetOffset (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex.MutableEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Offset;
			}
#pragma warning restore 0169

			/// <summary>Returns offset for this index object entry</summary>
			/// <returns>offset of this object in a pack file</returns>
			public virtual unsafe long Offset {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex.MutableEntry']/method[@name='getOffset' and count(parameter)=0]"
				[Register ("getOffset", "()J", "GetGetOffsetHandler")]
				get {
					const string __id = "getOffset.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_cloneEntry;
#pragma warning disable 0169
			static Delegate GetCloneEntryHandler ()
			{
				if (cb_cloneEntry == null)
					cb_cloneEntry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CloneEntry);
				return cb_cloneEntry;
			}

			static IntPtr n_CloneEntry (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex.MutableEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CloneEntry ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex.MutableEntry']/method[@name='cloneEntry' and count(parameter)=0]"
			[Register ("cloneEntry", "()Lorg/eclipse/jgit/internal/storage/file/PackIndex$MutableEntry;", "GetCloneEntryHandler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex.MutableEntry CloneEntry ()
			{
				const string __id = "cloneEntry.()Lorg/eclipse/jgit/internal/storage/file/PackIndex$MutableEntry;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex.MutableEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_name;
#pragma warning disable 0169
			static Delegate GetNameHandler ()
			{
				if (cb_name == null)
					cb_name = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Name);
				return cb_name;
			}

			static IntPtr n_Name (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex.MutableEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name ());
			}
#pragma warning restore 0169

			/// <returns>hex string describing the object id of this entry.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex.MutableEntry']/method[@name='name' and count(parameter)=0]"
			[Register ("name", "()Ljava/lang/String;", "GetNameHandler")]
			public virtual unsafe string Name ()
			{
				const string __id = "name.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_toObjectId;
#pragma warning disable 0169
			static Delegate GetToObjectIdHandler ()
			{
				if (cb_toObjectId == null)
					cb_toObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToObjectId);
				return cb_toObjectId;
			}

			static IntPtr n_ToObjectId (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex.MutableEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ToObjectId ());
			}
#pragma warning restore 0169

			/// <returns>a copy of the object id.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex.MutableEntry']/method[@name='toObjectId' and count(parameter)=0]"
			[Register ("toObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetToObjectIdHandler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ToObjectId ()
			{
				const string __id = "toObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackIndex", typeof (PackIndex));

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

		protected PackIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/constructor[@name='PackIndex' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PackIndex () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_hasCRC32Support;
#pragma warning disable 0169
		static Delegate GetHasCRC32SupportHandler ()
		{
			if (cb_hasCRC32Support == null)
				cb_hasCRC32Support = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasCRC32Support);
			return cb_hasCRC32Support;
		}

		static bool n_HasCRC32Support (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCRC32Support;
		}
#pragma warning restore 0169

		public abstract bool HasCRC32Support {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='hasCRC32Support' and count(parameter)=0]"
			[Register ("hasCRC32Support", "()Z", "GetHasCRC32SupportHandler")]
			get; 
		}

		static Delegate cb_getObjectCount;
#pragma warning disable 0169
		static Delegate GetGetObjectCountHandler ()
		{
			if (cb_getObjectCount == null)
				cb_getObjectCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetObjectCount);
			return cb_getObjectCount;
		}

		static long n_GetObjectCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectCount;
		}
#pragma warning restore 0169

		public abstract long ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()J", "GetGetObjectCountHandler")]
			get; 
		}

		static Delegate cb_getOffset64Count;
#pragma warning disable 0169
		static Delegate GetGetOffset64CountHandler ()
		{
			if (cb_getOffset64Count == null)
				cb_getOffset64Count = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetOffset64Count);
			return cb_getOffset64Count;
		}

		static long n_GetOffset64Count (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset64Count;
		}
#pragma warning restore 0169

		public abstract long Offset64Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='getOffset64Count' and count(parameter)=0]"
			[Register ("getOffset64Count", "()J", "GetGetOffset64CountHandler")]
			get; 
		}

		static Delegate cb_findCRC32_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetFindCRC32_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_findCRC32_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_findCRC32_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_FindCRC32_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_findCRC32_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static long n_FindCRC32_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objId, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.FindCRC32 (objId);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objId">id of object to look for</param>
		/// <summary>Retrieve stored CRC32 checksum of the requested object raw-data
		/// (including header).</summary>
		/// <returns>CRC32 checksum of specified object (at 32 less significant bits)</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='findCRC32' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("findCRC32", "(Lorg/eclipse/jgit/lib/AnyObjectId;)J", "GetFindCRC32_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public abstract long FindCRC32 (global::Org.Eclipse.Jgit.Lib.AnyObjectId objId);

		static Delegate cb_findOffset_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetFindOffset_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_findOffset_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_findOffset_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_FindOffset_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_findOffset_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static long n_FindOffset_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objId, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.FindOffset (objId);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objId">name of the object to locate within the pack.</param>
		/// <summary>Locate the file offset position for the requested object.</summary>
		/// <returns>offset of the object's header and compressed content; -1 if the
		///         object does not exist in this index and is thus not stored in the
		///         associated pack.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='findOffset' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("findOffset", "(Lorg/eclipse/jgit/lib/AnyObjectId;)J", "GetFindOffset_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public abstract long FindOffset (global::Org.Eclipse.Jgit.Lib.AnyObjectId objId);

		/// <param name="nthPosition">unsigned 32 bit position within the traversal of
		///            <c>#iterator()</c> that the caller needs the object for. The
		///            first returned <c>MutableEntry</c> is 0, the second is 1,
		///            etc. Positions past 2**31-1 are negative, but still valid.</param>
		/// <summary>Get ObjectId for the n-th object entry returned by <c>#iterator()</c>.</summary>
		/// <returns>the ObjectId for the corresponding entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='getObjectId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObjectId", "(I)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId GetObjectId (int nthPosition)
		{
			const string __id = "getObjectId.(I)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nthPosition);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getObjectId_J;
#pragma warning disable 0169
		static Delegate GetGetObjectId_JHandler ()
		{
			if (cb_getObjectId_J == null)
				cb_getObjectId_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_GetObjectId_J);
			return cb_getObjectId_J;
		}

		static IntPtr n_GetObjectId_J (IntPtr jnienv, IntPtr native__this, long nthPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObjectId (nthPosition));
		}
#pragma warning restore 0169

		/// <param name="nthPosition">position within the traversal of <c>#iterator()</c> that the
		///            caller needs the object for. The first returned
		///            <c>MutableEntry</c> is 0, the second is 1, etc.</param>
		/// <summary>Get ObjectId for the n-th object entry returned by <c>#iterator()</c>.</summary>
		/// <returns>the ObjectId for the corresponding entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='getObjectId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getObjectId", "(J)Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObjectId_JHandler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectId GetObjectId (long nthPosition);

		static Delegate cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetHasObject_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasObject_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_hasObject_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_HasObject_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasObject (id);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">the object to look for. Must not be null.</param>
		/// <summary>Determine if an object is contained within the pack file.</summary>
		/// <returns>true if the object is listed in this index; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='hasObject' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("hasObject", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetHasObject_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe bool HasObject (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "hasObject.(Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		/// <summary>Provide iterator that gives access to index entries.</summary>
		/// <returns>iterator over pack index entries</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public abstract global::Java.Util.IIterator Iterator ();

		/// <param name="idxFile">existing pack .idx to read.</param>
		/// <summary>Open an existing pack &lt;code&gt;.</summary>
		/// <returns>access implementation for the requested file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='open' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("open", "(Ljava/io/File;)Lorg/eclipse/jgit/internal/storage/file/PackIndex;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex Open (global::Java.IO.File idxFile)
		{
			const string __id = "open.(Ljava/io/File;)Lorg/eclipse/jgit/internal/storage/file/PackIndex;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((idxFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idxFile).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (idxFile);
			}
		}

		/// <param name="fd">stream to read the index file from. The stream must be
		///            buffered as some small IOs are performed against the stream.
		///            The caller is responsible for closing the stream.</param>
		/// <summary>Read an existing pack index file from a buffered stream.</summary>
		/// <returns>a copy of the index in-memory.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("read", "(Ljava/io/InputStream;)Lorg/eclipse/jgit/internal/storage/file/PackIndex;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex Read (global::System.IO.Stream fd)
		{
			const string __id = "read.(Ljava/io/InputStream;)Lorg/eclipse/jgit/internal/storage/file/PackIndex;";
			IntPtr native_fd = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (fd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fd);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fd);
				global::System.GC.KeepAlive (fd);
			}
		}

		static Delegate cb_resolve_Ljava_util_Set_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_I;
#pragma warning disable 0169
		static Delegate GetResolve_Ljava_util_Set_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_IHandler ()
		{
			if (cb_resolve_Ljava_util_Set_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_I == null)
				cb_resolve_Ljava_util_Set_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Resolve_Ljava_util_Set_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_I);
			return cb_resolve_Ljava_util_Set_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_I;
		}

		static void n_Resolve_Ljava_util_Set_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_matches, IntPtr native_id, int matchLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackIndex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matches = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_matches, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.Resolve (matches, id, matchLimit);
		}
#pragma warning restore 0169

		/// <param name="matches">set to add any located ObjectIds to. This is an output
		///            parameter.</param>
		/// <param name="id">prefix to search for.</param>
		/// <param name="matchLimit">maximum number of results to return. At most this many
		///            ObjectIds should be added to matches before returning.</param>
		/// <summary>Find objects matching the prefix abbreviation.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='resolve' and count(parameter)=3 and parameter[1][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[2][@type='org.eclipse.jgit.lib.AbbreviatedObjectId'] and parameter[3][@type='int']]"
		[Register ("resolve", "(Ljava/util/Set;Lorg/eclipse/jgit/lib/AbbreviatedObjectId;I)V", "GetResolve_Ljava_util_Set_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_IHandler")]
		public abstract void Resolve (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> matches, global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId id, int matchLimit);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/file/PackIndex", DoNotGenerateAcw=true)]
	internal partial class PackIndexInvoker : PackIndex {
		public PackIndexInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/file/PackIndex", typeof (PackIndexInvoker));

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

		/// <summary>Check whether this index supports (has) CRC32 checksums for objects.</summary>
		/// <returns>true if CRC32 is stored, false otherwise</returns>
		public override unsafe bool HasCRC32Support {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='hasCRC32Support' and count(parameter)=0]"
			[Register ("hasCRC32Support", "()Z", "GetHasCRC32SupportHandler")]
			get {
				const string __id = "hasCRC32Support.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Obtain the total number of objects described by this index.</summary>
		/// <returns>number of objects in this index, and likewise in the associated
		///         pack that this index was generated from.</returns>
		public override unsafe long ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()J", "GetGetObjectCountHandler")]
			get {
				const string __id = "getObjectCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Obtain the total number of objects needing 64 bit offsets.</summary>
		/// <returns>number of objects in this index using a 64 bit offset; that is an
		///         object positioned after the 2 GB position within the file.</returns>
		public override unsafe long Offset64Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='getOffset64Count' and count(parameter)=0]"
			[Register ("getOffset64Count", "()J", "GetGetOffset64CountHandler")]
			get {
				const string __id = "getOffset64Count.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="objId">id of object to look for</param>
		/// <summary>Retrieve stored CRC32 checksum of the requested object raw-data
		/// (including header).</summary>
		/// <returns>CRC32 checksum of specified object (at 32 less significant bits)</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='findCRC32' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("findCRC32", "(Lorg/eclipse/jgit/lib/AnyObjectId;)J", "GetFindCRC32_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public override unsafe long FindCRC32 (global::Org.Eclipse.Jgit.Lib.AnyObjectId objId)
		{
			const string __id = "findCRC32.(Lorg/eclipse/jgit/lib/AnyObjectId;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objId).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (objId);
			}
		}

		/// <param name="objId">name of the object to locate within the pack.</param>
		/// <summary>Locate the file offset position for the requested object.</summary>
		/// <returns>offset of the object's header and compressed content; -1 if the
		///         object does not exist in this index and is thus not stored in the
		///         associated pack.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='findOffset' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("findOffset", "(Lorg/eclipse/jgit/lib/AnyObjectId;)J", "GetFindOffset_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public override unsafe long FindOffset (global::Org.Eclipse.Jgit.Lib.AnyObjectId objId)
		{
			const string __id = "findOffset.(Lorg/eclipse/jgit/lib/AnyObjectId;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objId).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (objId);
			}
		}

		/// <param name="nthPosition">position within the traversal of <c>#iterator()</c> that the
		///            caller needs the object for. The first returned
		///            <c>MutableEntry</c> is 0, the second is 1, etc.</param>
		/// <summary>Get ObjectId for the n-th object entry returned by <c>#iterator()</c>.</summary>
		/// <returns>the ObjectId for the corresponding entry.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='getObjectId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getObjectId", "(J)Lorg/eclipse/jgit/lib/ObjectId;", "GetGetObjectId_JHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId GetObjectId (long nthPosition)
		{
			const string __id = "getObjectId.(J)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nthPosition);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Provide iterator that gives access to index entries.</summary>
		/// <returns>iterator over pack index entries</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public override unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="matches">set to add any located ObjectIds to. This is an output
		///            parameter.</param>
		/// <param name="id">prefix to search for.</param>
		/// <param name="matchLimit">maximum number of results to return. At most this many
		///            ObjectIds should be added to matches before returning.</param>
		/// <summary>Find objects matching the prefix abbreviation.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.file']/class[@name='PackIndex']/method[@name='resolve' and count(parameter)=3 and parameter[1][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;'] and parameter[2][@type='org.eclipse.jgit.lib.AbbreviatedObjectId'] and parameter[3][@type='int']]"
		[Register ("resolve", "(Ljava/util/Set;Lorg/eclipse/jgit/lib/AbbreviatedObjectId;I)V", "GetResolve_Ljava_util_Set_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_IHandler")]
		public override unsafe void Resolve (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> matches, global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId id, int matchLimit)
		{
			const string __id = "resolve.(Ljava/util/Set;Lorg/eclipse/jgit/lib/AbbreviatedObjectId;I)V";
			IntPtr native_matches = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (matches);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_matches);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [2] = new JniArgumentValue (matchLimit);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_matches);
				global::System.GC.KeepAlive (matches);
				global::System.GC.KeepAlive (id);
			}
		}

	}
}
