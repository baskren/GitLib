using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Abstraction of name to <c>ObjectId</c> mapping.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefDatabase", DoNotGenerateAcw=true)]
	public abstract partial class RefDatabase : global::Java.Lang.Object {
		/// <summary>Magic value for <c>#getRefs(String)</c> to return all references.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/field[@name='ALL']"
		[Register ("ALL")]
		public const string All = (string) "";

		/// <summary>Maximum number of times a <c>SymbolicRef</c> can be traversed.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/field[@name='MAX_SYMBOLIC_REF_DEPTH']"
		[Register ("MAX_SYMBOLIC_REF_DEPTH")]
		protected const int MaxSymbolicRefDepth = (int) 5;


		/// <summary>Order of prefixes to search when using non-absolute references.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/field[@name='SEARCH_PATH']"
		[Register ("SEARCH_PATH")]
		protected static IList<string> SearchPath {
			get {
				const string __id = "SEARCH_PATH.[Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefDatabase", typeof (RefDatabase));

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

		protected RefDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/constructor[@name='RefDatabase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RefDatabase () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAdditionalRefs;
#pragma warning disable 0169
		static Delegate GetGetAdditionalRefsHandler ()
		{
			if (cb_getAdditionalRefs == null)
				cb_getAdditionalRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdditionalRefs);
			return cb_getAdditionalRefs;
		}

		static IntPtr n_GetAdditionalRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.AdditionalRefs);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> AdditionalRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='getAdditionalRefs' and count(parameter)=0]"
			[Register ("getAdditionalRefs", "()Ljava/util/List;", "GetGetAdditionalRefsHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		/// <summary>Close any resources held by this database.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='close' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create ();
		}
#pragma warning restore 0169

		/// <summary>Initialize a new reference database at this location.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "GetCreateHandler")]
		public abstract void Create ();

		/// <param name="map">map of refs to search within. Names should be fully qualified,
		///            e.g. "refs/heads/master".</param>
		/// <param name="name">short name of ref to find, e.g. "master" to find
		///            "refs/heads/master" in map.</param>
		/// <summary>Try to find the specified name in the ref map using <c>#SEARCH_PATH</c>.</summary>
		/// <returns>The first ref matching the name, or null if not found.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='findRef' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.lib.Ref&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("findRef", "(Ljava/util/Map;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.IRef FindRef (global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> map, string name)
		{
			const string __id = "findRef.(Ljava/util/Map;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;";
			IntPtr native_map = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (map);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_map);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (map);
			}
		}

		static Delegate cb_getConflictingNames_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConflictingNames_Ljava_lang_String_Handler ()
		{
			if (cb_getConflictingNames_Ljava_lang_String_ == null)
				cb_getConflictingNames_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetConflictingNames_Ljava_lang_String_);
			return cb_getConflictingNames_Ljava_lang_String_;
		}

		static IntPtr n_GetConflictingNames_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (__this.GetConflictingNames (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">proposed name to check for conflicts against</param>
		/// <summary>Determine if a proposed reference cannot coexist with existing ones.</summary>
		/// <returns>a collection of full names of existing refs which would conflict
		///         with the passed ref name; empty collection when there are no
		///         conflicts</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='getConflictingNames' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConflictingNames", "(Ljava/lang/String;)Ljava/util/Collection;", "GetGetConflictingNames_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> GetConflictingNames (string name)
		{
			const string __id = "getConflictingNames.(Ljava/lang/String;)Ljava/util/Collection;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaCollection<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRef_Ljava_lang_String_Handler ()
		{
			if (cb_getRef_Ljava_lang_String_ == null)
				cb_getRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRef_Ljava_lang_String_);
			return cb_getRef_Ljava_lang_String_;
		}

		static IntPtr n_GetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRef (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">the name of the reference. May be a short name which must be
		///            searched for using the standard <c>#SEARCH_PATH</c>.</param>
		/// <summary>Read a single reference.</summary>
		/// <returns>the reference (if it exists); else <c>null</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='getRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "GetGetRef_Ljava_lang_String_Handler")]
		public abstract global::Org.Eclipse.Jgit.Lib.IRef GetRef (string name);

		static Delegate cb_getRefs_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRefs_Ljava_lang_String_Handler ()
		{
			if (cb_getRefs_Ljava_lang_String_ == null)
				cb_getRefs_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRefs_Ljava_lang_String_);
			return cb_getRefs_Ljava_lang_String_;
		}

		static IntPtr n_GetRefs_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.GetRefs (prefix));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="prefix">prefix to search the namespace with; must end with <c>/</c>.
		///            If the empty string (<c>#ALL</c>), obtain a complete snapshot
		///            of all references.</param>
		/// <summary>Get a section of the reference namespace.</summary>
		/// <returns>modifiable map that is a complete snapshot of the current
		///         reference namespace, with <c>prefix</c> removed from the start
		///         of each key. The map can be an unsorted map.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='getRefs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRefs", "(Ljava/lang/String;)Ljava/util/Map;", "GetGetRefs_Ljava_lang_String_Handler")]
		public abstract global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> GetRefs (string prefix);

		static Delegate cb_isNameConflicting_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsNameConflicting_Ljava_lang_String_Handler ()
		{
			if (cb_isNameConflicting_Ljava_lang_String_ == null)
				cb_isNameConflicting_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsNameConflicting_Ljava_lang_String_);
			return cb_isNameConflicting_Ljava_lang_String_;
		}

		static bool n_IsNameConflicting_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsNameConflicting (name);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">proposed name.</param>
		/// <summary>Determine if a proposed reference name overlaps with an existing one.</summary>
		/// <returns>true if the name overlaps with an existing reference; false if
		///         using this name right now would be safe.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='isNameConflicting' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNameConflicting", "(Ljava/lang/String;)Z", "GetIsNameConflicting_Ljava_lang_String_Handler")]
		public abstract bool IsNameConflicting (string name);

		static Delegate cb_newBatchUpdate;
#pragma warning disable 0169
		static Delegate GetNewBatchUpdateHandler ()
		{
			if (cb_newBatchUpdate == null)
				cb_newBatchUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewBatchUpdate);
			return cb_newBatchUpdate;
		}

		static IntPtr n_NewBatchUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewBatchUpdate ());
		}
#pragma warning restore 0169

		/// <summary>Create a new batch update to attempt on this database.</summary>
		/// <returns>a new batch update object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='newBatchUpdate' and count(parameter)=0]"
		[Register ("newBatchUpdate", "()Lorg/eclipse/jgit/lib/BatchRefUpdate;", "GetNewBatchUpdateHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.BatchRefUpdate NewBatchUpdate ()
		{
			const string __id = "newBatchUpdate.()Lorg/eclipse/jgit/lib/BatchRefUpdate;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.BatchRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newRename_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewRename_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_newRename_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_newRename_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_NewRename_Ljava_lang_String_Ljava_lang_String_);
			return cb_newRename_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_NewRename_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fromName, IntPtr native_toName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fromName = JNIEnv.GetString (native_fromName, JniHandleOwnership.DoNotTransfer);
			var toName = JNIEnv.GetString (native_toName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewRename (fromName, toName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="fromName">name of reference to rename from</param>
		/// <param name="toName">name of reference to rename to</param>
		/// <summary>Create a new update command to rename a reference.</summary>
		/// <returns>an update command that knows how to rename a branch to another.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='newRename' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("newRename", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefRename;", "GetNewRename_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::Org.Eclipse.Jgit.Lib.RefRename NewRename (string fromName, string toName);

		static Delegate cb_newUpdate_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetNewUpdate_Ljava_lang_String_ZHandler ()
		{
			if (cb_newUpdate_Ljava_lang_String_Z == null)
				cb_newUpdate_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_NewUpdate_Ljava_lang_String_Z);
			return cb_newUpdate_Ljava_lang_String_Z;
		}

		static IntPtr n_NewUpdate_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_name, bool detach)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewUpdate (name, detach));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">the name of the reference.</param>
		/// <param name="detach">if <c>true</c> and <c>name</c> is currently a
		///            <c>SymbolicRef</c>, the update will replace it with an
		///            <c>ObjectIdRef</c>. Otherwise, the update will recursively
		///            traverse <c>SymbolicRef</c>s and operate on the leaf
		///            <c>ObjectIdRef</c>.</param>
		/// <summary>Create a new update command to create, modify or delete a reference.</summary>
		/// <returns>a new update for the requested name; never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='newUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("newUpdate", "(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/RefUpdate;", "GetNewUpdate_Ljava_lang_String_ZHandler")]
		public abstract global::Org.Eclipse.Jgit.Lib.RefUpdate NewUpdate (string name, bool detach);

		static Delegate cb_peel_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetPeel_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_peel_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_peel_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Peel_Lorg_eclipse_jgit_lib_Ref_);
			return cb_peel_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_Peel_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Peel (@ref));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ref">The reference to peel</param>
		/// <summary>Peel a possibly unpeeled reference by traversing the annotated tags.</summary>
		/// <returns>
		///   <c>ref</c> if <c>ref.isPeeled()</c> is true; otherwise a new
		///         Ref object representing the same data as Ref, but isPeeled() will
		///         be true and getPeeledObjectId() will contain the peeled object
		///         (or null).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='peel' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("peel", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;", "GetPeel_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public abstract global::Org.Eclipse.Jgit.Lib.IRef Peel (global::Org.Eclipse.Jgit.Lib.IRef @ref);

		static Delegate cb_performsAtomicTransactions;
#pragma warning disable 0169
		static Delegate GetPerformsAtomicTransactionsHandler ()
		{
			if (cb_performsAtomicTransactions == null)
				cb_performsAtomicTransactions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_PerformsAtomicTransactions);
			return cb_performsAtomicTransactions;
		}

		static bool n_PerformsAtomicTransactions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PerformsAtomicTransactions ();
		}
#pragma warning restore 0169

		/// <returns>if the database performs <c>newBatchUpdate()</c> as an atomic
		///         transaction.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='performsAtomicTransactions' and count(parameter)=0]"
		[Register ("performsAtomicTransactions", "()Z", "GetPerformsAtomicTransactionsHandler")]
		public virtual unsafe bool PerformsAtomicTransactions ()
		{
			const string __id = "performsAtomicTransactions.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_refresh;
#pragma warning disable 0169
		static Delegate GetRefreshHandler ()
		{
			if (cb_refresh == null)
				cb_refresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Refresh);
			return cb_refresh;
		}

		static void n_Refresh (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Refresh ();
		}
#pragma warning restore 0169

		/// <summary>Triggers a refresh of all internal data structures.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='refresh' and count(parameter)=0]"
		[Register ("refresh", "()V", "GetRefreshHandler")]
		public virtual unsafe void Refresh ()
		{
			const string __id = "refresh.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefDatabase", DoNotGenerateAcw=true)]
	internal partial class RefDatabaseInvoker : RefDatabase {
		public RefDatabaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefDatabase", typeof (RefDatabaseInvoker));

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

		/// <summary>Get the additional reference-like entities from the repository.</summary>
		/// <returns>a list of additional refs</returns>
		public override unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> AdditionalRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='getAdditionalRefs' and count(parameter)=0]"
			[Register ("getAdditionalRefs", "()Ljava/util/List;", "GetGetAdditionalRefsHandler")]
			get {
				const string __id = "getAdditionalRefs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Close any resources held by this database.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <summary>Initialize a new reference database at this location.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "GetCreateHandler")]
		public override unsafe void Create ()
		{
			const string __id = "create.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <param name="name">the name of the reference. May be a short name which must be
		///            searched for using the standard <c>#SEARCH_PATH</c>.</param>
		/// <summary>Read a single reference.</summary>
		/// <returns>the reference (if it exists); else <c>null</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='getRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "GetGetRef_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IRef GetRef (string name)
		{
			const string __id = "getRef.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		/// <param name="prefix">prefix to search the namespace with; must end with <c>/</c>.
		///            If the empty string (<c>#ALL</c>), obtain a complete snapshot
		///            of all references.</param>
		/// <summary>Get a section of the reference namespace.</summary>
		/// <returns>modifiable map that is a complete snapshot of the current
		///         reference namespace, with <c>prefix</c> removed from the start
		///         of each key. The map can be an unsorted map.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='getRefs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRefs", "(Ljava/lang/String;)Ljava/util/Map;", "GetGetRefs_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> GetRefs (string prefix)
		{
			const string __id = "getRefs.(Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		/// <param name="name">proposed name.</param>
		/// <summary>Determine if a proposed reference name overlaps with an existing one.</summary>
		/// <returns>true if the name overlaps with an existing reference; false if
		///         using this name right now would be safe.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='isNameConflicting' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNameConflicting", "(Ljava/lang/String;)Z", "GetIsNameConflicting_Ljava_lang_String_Handler")]
		public override unsafe bool IsNameConflicting (string name)
		{
			const string __id = "isNameConflicting.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		/// <param name="fromName">name of reference to rename from</param>
		/// <param name="toName">name of reference to rename to</param>
		/// <summary>Create a new update command to rename a reference.</summary>
		/// <returns>an update command that knows how to rename a branch to another.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='newRename' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("newRename", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefRename;", "GetNewRename_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.RefRename NewRename (string fromName, string toName)
		{
			const string __id = "newRename.(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/lib/RefRename;";
			IntPtr native_fromName = JNIEnv.NewString ((string)fromName);
			IntPtr native_toName = JNIEnv.NewString ((string)toName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fromName);
				__args [1] = new JniArgumentValue (native_toName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefRename> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fromName);
				JNIEnv.DeleteLocalRef (native_toName);
			}
		}

		/// <param name="name">the name of the reference.</param>
		/// <param name="detach">if <c>true</c> and <c>name</c> is currently a
		///            <c>SymbolicRef</c>, the update will replace it with an
		///            <c>ObjectIdRef</c>. Otherwise, the update will recursively
		///            traverse <c>SymbolicRef</c>s and operate on the leaf
		///            <c>ObjectIdRef</c>.</param>
		/// <summary>Create a new update command to create, modify or delete a reference.</summary>
		/// <returns>a new update for the requested name; never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='newUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("newUpdate", "(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/RefUpdate;", "GetNewUpdate_Ljava_lang_String_ZHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.RefUpdate NewUpdate (string name, bool detach)
		{
			const string __id = "newUpdate.(Ljava/lang/String;Z)Lorg/eclipse/jgit/lib/RefUpdate;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (detach);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		/// <param name="ref">The reference to peel</param>
		/// <summary>Peel a possibly unpeeled reference by traversing the annotated tags.</summary>
		/// <returns>
		///   <c>ref</c> if <c>ref.isPeeled()</c> is true; otherwise a new
		///         Ref object representing the same data as Ref, but isPeeled() will
		///         be true and getPeeledObjectId() will contain the peeled object
		///         (or null).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefDatabase']/method[@name='peel' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("peel", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;", "GetPeel_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.IRef Peel (global::Org.Eclipse.Jgit.Lib.IRef @ref)
		{
			const string __id = "peel.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@ref);
			}
		}

	}
}
