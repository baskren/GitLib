using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Abstraction of arbitrary object storage.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectDatabase", DoNotGenerateAcw=true)]
	public abstract partial class ObjectDatabase : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectDatabase", typeof (ObjectDatabase));

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

		protected ObjectDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Initialize a new database instance for access.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/constructor[@name='ObjectDatabase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ObjectDatabase () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		/// <summary>Close any resources held by this database.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Create);
			return cb_create;
		}

		static void n_Create (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create ();
		}
#pragma warning restore 0169

		/// <summary>Initialize a new object database at this location.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "GetCreateHandler")]
		public virtual unsafe void Create ()
		{
			const string __id = "create.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_exists;
#pragma warning disable 0169
		static Delegate GetExistsHandler ()
		{
			if (cb_exists == null)
				cb_exists = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Exists);
			return cb_exists;
		}

		static bool n_Exists (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Exists ();
		}
#pragma warning restore 0169

		/// <summary>Does this database exist yet?</summary>
		/// <returns>true if this database is already created; false if the caller
		///         should invoke <c>#create()</c> to create this database location.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='exists' and count(parameter)=0]"
		[Register ("exists", "()Z", "GetExistsHandler")]
		public virtual unsafe bool Exists ()
		{
			const string __id = "exists.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_has_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetHas_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_has_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_has_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Has_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_has_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_Has_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Has (objectId);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to test for existence of.</param>
		/// <summary>Does the requested object exist in this database?</summary>
		/// <returns>true if the specified object is stored in this database.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='has' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("has", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetHas_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe bool Has (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			const string __id = "has.(Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		static Delegate cb_newCachedDatabase;
#pragma warning disable 0169
		static Delegate GetNewCachedDatabaseHandler ()
		{
			if (cb_newCachedDatabase == null)
				cb_newCachedDatabase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewCachedDatabase);
			return cb_newCachedDatabase;
		}

		static IntPtr n_NewCachedDatabase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewCachedDatabase ());
		}
#pragma warning restore 0169

		/// <summary>Create a new cached database instance over this database.</summary>
		/// <returns>new cached database instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='newCachedDatabase' and count(parameter)=0]"
		[Register ("newCachedDatabase", "()Lorg/eclipse/jgit/lib/ObjectDatabase;", "GetNewCachedDatabaseHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectDatabase NewCachedDatabase ()
		{
			const string __id = "newCachedDatabase.()Lorg/eclipse/jgit/lib/ObjectDatabase;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newInserter;
#pragma warning disable 0169
		static Delegate GetNewInserterHandler ()
		{
			if (cb_newInserter == null)
				cb_newInserter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewInserter);
			return cb_newInserter;
		}

		static IntPtr n_NewInserter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewInserter ());
		}
#pragma warning restore 0169

		/// <summary>Create a new <c>ObjectInserter</c> to insert new objects.</summary>
		/// <returns>writer the caller can use to create objects in this database.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='newInserter' and count(parameter)=0]"
		[Register ("newInserter", "()Lorg/eclipse/jgit/lib/ObjectInserter;", "GetNewInserterHandler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectInserter NewInserter ();

		static Delegate cb_newReader;
#pragma warning disable 0169
		static Delegate GetNewReaderHandler ()
		{
			if (cb_newReader == null)
				cb_newReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewReader);
			return cb_newReader;
		}

		static IntPtr n_NewReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewReader ());
		}
#pragma warning restore 0169

		/// <summary>Create a new <c>ObjectReader</c> to read existing objects.</summary>
		/// <returns>reader the caller can use to load objects from this database.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='newReader' and count(parameter)=0]"
		[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ();

		static Delegate cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Open_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Open_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (objectId));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to open.</param>
		/// <summary>Open an object from this database.</summary>
		/// <returns>a <c>ObjectLoader</c> for accessing the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='open' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/ObjectLoader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		static Delegate cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_Open_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_open_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static IntPtr n_Open_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId, int typeHint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (objectId, typeHint));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to open.</param>
		/// <param name="typeHint">hint about the type of object being requested, e.g.
		///            <c>Constants#OBJ_BLOB</c>; <c>ObjectReader#OBJ_ANY</c> if
		///            the object type is not known, or does not matter to the
		///            caller.</param>
		/// <summary>Open an object from this database.</summary>
		/// <returns>a <c>ObjectLoader</c> for accessing the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int typeHint)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/ObjectLoader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [1] = new JniArgumentValue (typeHint);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectDatabase", DoNotGenerateAcw=true)]
	internal partial class ObjectDatabaseInvoker : ObjectDatabase {
		public ObjectDatabaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectDatabase", typeof (ObjectDatabaseInvoker));

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

		/// <summary>Close any resources held by this database.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <summary>Create a new <c>ObjectInserter</c> to insert new objects.</summary>
		/// <returns>writer the caller can use to create objects in this database.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='newInserter' and count(parameter)=0]"
		[Register ("newInserter", "()Lorg/eclipse/jgit/lib/ObjectInserter;", "GetNewInserterHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectInserter NewInserter ()
		{
			const string __id = "newInserter.()Lorg/eclipse/jgit/lib/ObjectInserter;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Create a new <c>ObjectReader</c> to read existing objects.</summary>
		/// <returns>reader the caller can use to load objects from this database.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectDatabase']/method[@name='newReader' and count(parameter)=0]"
		[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ()
		{
			const string __id = "newReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
