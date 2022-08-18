using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Reads an <c>ObjectDatabase</c> for a single thread.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectReader", DoNotGenerateAcw=true)]
	public abstract partial class ObjectReader : global::Java.Lang.Object {
		/// <summary>Type hint indicating the caller doesn't know the type.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/field[@name='OBJ_ANY']"
		[Register ("OBJ_ANY")]
		public const int ObjAny = (int) -1;

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectReader", typeof (ObjectReader));

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

		protected ObjectReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/constructor[@name='ObjectReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getBitmapIndex;
#pragma warning disable 0169
		static Delegate GetGetBitmapIndexHandler ()
		{
			if (cb_getBitmapIndex == null)
				cb_getBitmapIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBitmapIndex);
			return cb_getBitmapIndex;
		}

		static IntPtr n_GetBitmapIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BitmapIndex);
		}
#pragma warning restore 0169

		/// <summary>An index that can be used to speed up ObjectWalks.</summary>
		/// <returns>the index or null if one does not exist.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IBitmapIndex BitmapIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='getBitmapIndex' and count(parameter)=0]"
			[Register ("getBitmapIndex", "()Lorg/eclipse/jgit/lib/BitmapIndex;", "GetGetBitmapIndexHandler")]
			get {
				const string __id = "getBitmapIndex.()Lorg/eclipse/jgit/lib/BitmapIndex;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IBitmapIndex> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShallowCommits;
#pragma warning disable 0169
		static Delegate GetGetShallowCommitsHandler ()
		{
			if (cb_getShallowCommits == null)
				cb_getShallowCommits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetShallowCommits);
			return cb_getShallowCommits;
		}

		static IntPtr n_GetShallowCommits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.ShallowCommits);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> ShallowCommits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='getShallowCommits' and count(parameter)=0]"
			[Register ("getShallowCommits", "()Ljava/util/Set;", "GetGetShallowCommitsHandler")]
			get; 
		}

		static Delegate cb_abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAbbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Abbreviate (objectId));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">object identity that needs to be abbreviated.</param>
		/// <summary>Obtain a unique abbreviation (prefix) of an object SHA-1.</summary>
		/// <returns>SHA-1 abbreviation.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='abbreviate' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("abbreviate", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetAbbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId Abbreviate (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId)
		{
			const string __id = "abbreviate.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		static Delegate cb_abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetAbbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_Abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static IntPtr n_Abbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Abbreviate (objectId, len));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">object identity that needs to be abbreviated.</param>
		/// <param name="len">minimum length of the abbreviated string. Must be in the range
		///            [2, <c>Constants#OBJECT_ID_STRING_LENGTH</c>].</param>
		/// <summary>Obtain a unique abbreviation (prefix) of an object SHA-1.</summary>
		/// <returns>SHA-1 abbreviation. If no matching objects exist in the
		///         repository, the abbreviation will match the minimum length.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='abbreviate' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("abbreviate", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetAbbreviate_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId Abbreviate (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int len)
		{
			const string __id = "abbreviate.(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [1] = new JniArgumentValue (len);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		static Delegate cb_getObjectSize_Ljava_lang_Iterable_Z;
#pragma warning disable 0169
		static Delegate GetGetObjectSize_Ljava_lang_Iterable_ZHandler ()
		{
			if (cb_getObjectSize_Ljava_lang_Iterable_Z == null)
				cb_getObjectSize_Ljava_lang_Iterable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_GetObjectSize_Ljava_lang_Iterable_Z);
			return cb_getObjectSize_Ljava_lang_Iterable_Z;
		}

		static IntPtr n_GetObjectSize_Ljava_lang_Iterable_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_objectIds, bool reportMissing)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectIds = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_objectIds, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetObjectSize (objectIds, reportMissing));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="&lt;T&gt;">type of identifier being supplied.</param>
		/// <param name="objectIds">objects to get the size of from the object store. The supplied
		///            collection must not be modified until the queue has finished.</param>
		/// <param name="reportMissing">if true missing objects are reported by calling failure with a
		///            MissingObjectException. This may be more expensive for the
		///            implementation to guarantee. If false the implementation may
		///            choose to report MissingObjectException, or silently skip over
		///            the object with no warning.</param>
		/// <summary>Asynchronous object size lookup.</summary>
		/// <returns>queue to read object sizes from.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='getObjectSize' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;T&gt;'] and parameter[2][@type='boolean']]"
		[Register ("getObjectSize", "(Ljava/lang/Iterable;Z)Lorg/eclipse/jgit/lib/AsyncObjectSizeQueue;", "GetGetObjectSize_Ljava_lang_Iterable_ZHandler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.lib.ObjectId"})]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IAsyncObjectSizeQueue GetObjectSize (global::Java.Lang.IIterable objectIds, bool reportMissing)
		{
			const string __id = "getObjectSize.(Ljava/lang/Iterable;Z)Lorg/eclipse/jgit/lib/AsyncObjectSizeQueue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectIds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectIds).Handle);
				__args [1] = new JniArgumentValue (reportMissing);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncObjectSizeQueue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectIds);
			}
		}

		static Delegate cb_getObjectSize_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetGetObjectSize_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_getObjectSize_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_getObjectSize_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_J) n_GetObjectSize_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_getObjectSize_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static long n_GetObjectSize_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId, int typeHint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetObjectSize (objectId, typeHint);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to open.</param>
		/// <param name="typeHint">hint about the type of object being requested, e.g.
		///            <c>Constants#OBJ_BLOB</c>; <c>#OBJ_ANY</c> if the object
		///            type is not known, or does not matter to the caller.</param>
		/// <summary>Get only the size of an object.</summary>
		/// <returns>size of object in bytes.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='getObjectSize' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("getObjectSize", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)J", "GetGetObjectSize_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public virtual unsafe long GetObjectSize (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int typeHint)
		{
			const string __id = "getObjectSize.(Lorg/eclipse/jgit/lib/AnyObjectId;I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [1] = new JniArgumentValue (typeHint);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (objectId);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Has (objectId);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to test for existence of.</param>
		/// <summary>Does the requested object exist in this database?</summary>
		/// <returns>true if the specified object is stored in this database.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='has' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
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

		static Delegate cb_has_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetHas_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_has_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_has_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_Has_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_has_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static bool n_Has_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_objectId, int typeHint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Has (objectId, typeHint);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to test for existence of.</param>
		/// <param name="typeHint">hint about the type of object being requested, e.g.
		///            <c>Constants#OBJ_BLOB</c>; <c>#OBJ_ANY</c> if the object
		///            type is not known, or does not matter to the caller.</param>
		/// <summary>Does the requested object exist in this database?</summary>
		/// <returns>true if the specified object is stored in this database.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='has' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("has", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Z", "GetHas_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public virtual unsafe bool Has (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int typeHint)
		{
			const string __id = "has.(Lorg/eclipse/jgit/lib/AnyObjectId;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [1] = new JniArgumentValue (typeHint);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewReader ());
		}
#pragma warning restore 0169

		/// <summary>Construct a new reader from the same data.</summary>
		/// <returns>a brand new reader, using the same data source.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='newReader' and count(parameter)=0]"
		[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ();

		static Delegate cb_open_Ljava_lang_Iterable_Z;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_Iterable_ZHandler ()
		{
			if (cb_open_Ljava_lang_Iterable_Z == null)
				cb_open_Ljava_lang_Iterable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_Open_Ljava_lang_Iterable_Z);
			return cb_open_Ljava_lang_Iterable_Z;
		}

		static IntPtr n_Open_Ljava_lang_Iterable_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_objectIds, bool reportMissing)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectIds = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_objectIds, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (objectIds, reportMissing));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="&lt;T&gt;">type of identifier being supplied.</param>
		/// <param name="objectIds">objects to open from the object store. The supplied collection
		///            must not be modified until the queue has finished.</param>
		/// <param name="reportMissing">if true missing objects are reported by calling failure with a
		///            MissingObjectException. This may be more expensive for the
		///            implementation to guarantee. If false the implementation may
		///            choose to report MissingObjectException, or silently skip over
		///            the object with no warning.</param>
		/// <summary>Asynchronous object opening.</summary>
		/// <returns>queue to read the objects from.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='open' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;T&gt;'] and parameter[2][@type='boolean']]"
		[Register ("open", "(Ljava/lang/Iterable;Z)Lorg/eclipse/jgit/lib/AsyncObjectLoaderQueue;", "GetOpen_Ljava_lang_Iterable_ZHandler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.lib.ObjectId"})]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueue Open (global::Java.Lang.IIterable objectIds, bool reportMissing)
		{
			const string __id = "open.(Ljava/lang/Iterable;Z)Lorg/eclipse/jgit/lib/AsyncObjectLoaderQueue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectIds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectIds).Handle);
				__args [1] = new JniArgumentValue (reportMissing);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IAsyncObjectLoaderQueue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectIds);
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (objectId));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to open.</param>
		/// <summary>Open an object from this database.</summary>
		/// <returns>a <c>ObjectLoader</c> for accessing the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='open' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_objectId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (objectId, typeHint));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectId">identity of the object to open.</param>
		/// <param name="typeHint">hint about the type of object being requested, e.g.
		///            <c>Constants#OBJ_BLOB</c>; <c>#OBJ_ANY</c> if the object
		///            type is not known, or does not matter to the caller.</param>
		/// <summary>Open an object from this database.</summary>
		/// <returns>a <c>ObjectLoader</c> for accessing the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int typeHint);

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		/// <summary>Release any resources used by this reader.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resolve_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_;
#pragma warning disable 0169
		static Delegate GetResolve_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_Handler ()
		{
			if (cb_resolve_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_ == null)
				cb_resolve_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Resolve_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_);
			return cb_resolve_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_;
		}

		static IntPtr n_Resolve_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.Resolve (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">abbreviated id to resolve to a complete identity. The
		///            abbreviation must have a length of at least 2.</param>
		/// <summary>Resolve an abbreviated ObjectId to its full form.</summary>
		/// <returns>candidates that begin with the abbreviated identity.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='resolve' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AbbreviatedObjectId']]"
		[Register ("resolve", "(Lorg/eclipse/jgit/lib/AbbreviatedObjectId;)Ljava/util/Collection;", "GetResolve_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_Handler")]
		public abstract global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> Resolve (global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId id);

		static Delegate cb_setAvoidUnreachableObjects_Z;
#pragma warning disable 0169
		static Delegate GetSetAvoidUnreachableObjects_ZHandler ()
		{
			if (cb_setAvoidUnreachableObjects_Z == null)
				cb_setAvoidUnreachableObjects_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAvoidUnreachableObjects_Z);
			return cb_setAvoidUnreachableObjects_Z;
		}

		static void n_SetAvoidUnreachableObjects_Z (IntPtr jnienv, IntPtr native__this, bool avoid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAvoidUnreachableObjects (avoid);
		}
#pragma warning restore 0169

		/// <param name="avoid">true to avoid unreachable objects.</param>
		/// <summary>Advise the reader to avoid unreachable objects.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='setAvoidUnreachableObjects' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAvoidUnreachableObjects", "(Z)V", "GetSetAvoidUnreachableObjects_ZHandler")]
		public virtual unsafe void SetAvoidUnreachableObjects (bool avoid)
		{
			const string __id = "setAvoidUnreachableObjects.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (avoid);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_walkAdviceBeginCommits_Lorg_eclipse_jgit_revwalk_RevWalk_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetWalkAdviceBeginCommits_Lorg_eclipse_jgit_revwalk_RevWalk_Ljava_util_Collection_Handler ()
		{
			if (cb_walkAdviceBeginCommits_Lorg_eclipse_jgit_revwalk_RevWalk_Ljava_util_Collection_ == null)
				cb_walkAdviceBeginCommits_Lorg_eclipse_jgit_revwalk_RevWalk_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_WalkAdviceBeginCommits_Lorg_eclipse_jgit_revwalk_RevWalk_Ljava_util_Collection_);
			return cb_walkAdviceBeginCommits_Lorg_eclipse_jgit_revwalk_RevWalk_Ljava_util_Collection_;
		}

		static void n_WalkAdviceBeginCommits_Lorg_eclipse_jgit_revwalk_RevWalk_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walk, IntPtr native_roots)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			var roots = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Revwalk.RevCommit>.FromJniHandle (native_roots, JniHandleOwnership.DoNotTransfer);
			__this.WalkAdviceBeginCommits (walk, roots);
		}
#pragma warning restore 0169

		/// <param name="walk">the revision pool that is using this reader.</param>
		/// <param name="roots">starting points of the revision walk. The starting points have
		///            their headers parsed, but might be missing bodies.</param>
		/// <summary>Advice from a <c>RevWalk</c> that a walk is starting from these roots.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='walkAdviceBeginCommits' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.revwalk.RevCommit&gt;']]"
		[Register ("walkAdviceBeginCommits", "(Lorg/eclipse/jgit/revwalk/RevWalk;Ljava/util/Collection;)V", "GetWalkAdviceBeginCommits_Lorg_eclipse_jgit_revwalk_RevWalk_Ljava_util_Collection_Handler")]
		public virtual unsafe void WalkAdviceBeginCommits (global::Org.Eclipse.Jgit.Revwalk.RevWalk walk, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Revwalk.RevCommit> roots)
		{
			const string __id = "walkAdviceBeginCommits.(Lorg/eclipse/jgit/revwalk/RevWalk;Ljava/util/Collection;)V";
			IntPtr native_roots = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Revwalk.RevCommit>.ToLocalJniHandle (roots);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				__args [1] = new JniArgumentValue (native_roots);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_roots);
				global::System.GC.KeepAlive (walk);
				global::System.GC.KeepAlive (roots);
			}
		}

		static Delegate cb_walkAdviceBeginTrees_Lorg_eclipse_jgit_revwalk_ObjectWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetWalkAdviceBeginTrees_Lorg_eclipse_jgit_revwalk_ObjectWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_walkAdviceBeginTrees_Lorg_eclipse_jgit_revwalk_ObjectWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_walkAdviceBeginTrees_Lorg_eclipse_jgit_revwalk_ObjectWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_WalkAdviceBeginTrees_Lorg_eclipse_jgit_revwalk_ObjectWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_walkAdviceBeginTrees_Lorg_eclipse_jgit_revwalk_ObjectWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static void n_WalkAdviceBeginTrees_Lorg_eclipse_jgit_revwalk_ObjectWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ow, IntPtr native_min, IntPtr native_max)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ow = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (native_ow, JniHandleOwnership.DoNotTransfer);
			var min = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_min, JniHandleOwnership.DoNotTransfer);
			var max = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_max, JniHandleOwnership.DoNotTransfer);
			__this.WalkAdviceBeginTrees (ow, min, max);
		}
#pragma warning restore 0169

		/// <param name="ow">the object pool that is using this reader.</param>
		/// <param name="min">the first commit whose root tree will be read.</param>
		/// <param name="max">the last commit whose root tree will be read.</param>
		/// <summary>Advice from an <c>ObjectWalk</c> that trees will be traversed.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='walkAdviceBeginTrees' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.revwalk.ObjectWalk'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[3][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("walkAdviceBeginTrees", "(Lorg/eclipse/jgit/revwalk/ObjectWalk;Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)V", "GetWalkAdviceBeginTrees_Lorg_eclipse_jgit_revwalk_ObjectWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe void WalkAdviceBeginTrees (global::Org.Eclipse.Jgit.Revwalk.ObjectWalk ow, global::Org.Eclipse.Jgit.Revwalk.RevCommit min, global::Org.Eclipse.Jgit.Revwalk.RevCommit max)
		{
			const string __id = "walkAdviceBeginTrees.(Lorg/eclipse/jgit/revwalk/ObjectWalk;Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((ow == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ow).Handle);
				__args [1] = new JniArgumentValue ((min == null) ? IntPtr.Zero : ((global::Java.Lang.Object) min).Handle);
				__args [2] = new JniArgumentValue ((max == null) ? IntPtr.Zero : ((global::Java.Lang.Object) max).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (ow);
				global::System.GC.KeepAlive (min);
				global::System.GC.KeepAlive (max);
			}
		}

		static Delegate cb_walkAdviceEnd;
#pragma warning disable 0169
		static Delegate GetWalkAdviceEndHandler ()
		{
			if (cb_walkAdviceEnd == null)
				cb_walkAdviceEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WalkAdviceEnd);
			return cb_walkAdviceEnd;
		}

		static void n_WalkAdviceEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WalkAdviceEnd ();
		}
#pragma warning restore 0169

		/// <summary>Advice from that a walk is over.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='walkAdviceEnd' and count(parameter)=0]"
		[Register ("walkAdviceEnd", "()V", "GetWalkAdviceEndHandler")]
		public virtual unsafe void WalkAdviceEnd ()
		{
			const string __id = "walkAdviceEnd.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectReader", DoNotGenerateAcw=true)]
	internal partial class ObjectReaderInvoker : ObjectReader {
		public ObjectReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectReader", typeof (ObjectReaderInvoker));

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

		/// <summary>Returns IDs for those commits which should be considered as shallow.</summary>
		/// <returns>IDs of shallow commits</returns>
		public override unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> ShallowCommits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='getShallowCommits' and count(parameter)=0]"
			[Register ("getShallowCommits", "()Ljava/util/Set;", "GetGetShallowCommitsHandler")]
			get {
				const string __id = "getShallowCommits.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Construct a new reader from the same data.</summary>
		/// <returns>a brand new reader, using the same data source.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='newReader' and count(parameter)=0]"
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

		/// <param name="objectId">identity of the object to open.</param>
		/// <param name="typeHint">hint about the type of object being requested, e.g.
		///            <c>Constants#OBJ_BLOB</c>; <c>#OBJ_ANY</c> if the object
		///            type is not known, or does not matter to the caller.</param>
		/// <summary>Open an object from this database.</summary>
		/// <returns>a <c>ObjectLoader</c> for accessing the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpen_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int typeHint)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/ObjectLoader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [1] = new JniArgumentValue (typeHint);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		/// <param name="id">abbreviated id to resolve to a complete identity. The
		///            abbreviation must have a length of at least 2.</param>
		/// <summary>Resolve an abbreviated ObjectId to its full form.</summary>
		/// <returns>candidates that begin with the abbreviated identity.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectReader']/method[@name='resolve' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AbbreviatedObjectId']]"
		[Register ("resolve", "(Lorg/eclipse/jgit/lib/AbbreviatedObjectId;)Ljava/util/Collection;", "GetResolve_Lorg_eclipse_jgit_lib_AbbreviatedObjectId_Handler")]
		public override unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> Resolve (global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId id)
		{
			const string __id = "resolve.(Lorg/eclipse/jgit/lib/AbbreviatedObjectId;)Ljava/util/Collection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

	}
}
