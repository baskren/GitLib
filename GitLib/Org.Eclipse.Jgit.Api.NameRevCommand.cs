using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Command to find human-readable names of revisions.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='NameRevCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/NameRevCommand", DoNotGenerateAcw=true)]
	public partial class NameRevCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::System.Collections.Generic.IDictionary<global::Org.Eclipse.Jgit.Lib.ObjectId, string>> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/NameRevCommand", typeof (NameRevCommand));

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

		protected NameRevCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		/// <summary>Create a new name-rev command.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='NameRevCommand']/constructor[@name='NameRevCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe NameRevCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_add_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Iterable_Handler ()
		{
			if (cb_add_Ljava_lang_Iterable_ == null)
				cb_add_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Add_Ljava_lang_Iterable_);
			return cb_add_Ljava_lang_Iterable_;
		}

		static IntPtr n_Add_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ids)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ids = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_ids, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (ids));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ids">object IDs to add.</param>
		/// <summary>Add multiple objects to search for.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='NameRevCommand']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("add", "(Ljava/lang/Iterable;)Lorg/eclipse/jgit/api/NameRevCommand;", "GetAdd_Ljava_lang_Iterable_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.NameRevCommand Add (global::Java.Lang.IIterable ids)
		{
			const string __id = "add.(Ljava/lang/Iterable;)Lorg/eclipse/jgit/api/NameRevCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ids == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ids).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ids);
			}
		}

		static Delegate cb_add_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_add_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Add_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_add_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static IntPtr n_Add_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">object ID to add.</param>
		/// <summary>Add an object to search for.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='NameRevCommand']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("add", "(Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/api/NameRevCommand;", "GetAdd_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.NameRevCommand Add (global::Org.Eclipse.Jgit.Lib.ObjectId id)
		{
			const string __id = "add.(Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/api/NameRevCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_addAnnotatedTags;
#pragma warning disable 0169
		static Delegate GetAddAnnotatedTagsHandler ()
		{
			if (cb_addAnnotatedTags == null)
				cb_addAnnotatedTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AddAnnotatedTags);
			return cb_addAnnotatedTags;
		}

		static IntPtr n_AddAnnotatedTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddAnnotatedTags ());
		}
#pragma warning restore 0169

		/// <summary>Add all annotated tags under <c>refs/tags/</c> to the set that all results
		/// must match.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='NameRevCommand']/method[@name='addAnnotatedTags' and count(parameter)=0]"
		[Register ("addAnnotatedTags", "()Lorg/eclipse/jgit/api/NameRevCommand;", "GetAddAnnotatedTagsHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.NameRevCommand AddAnnotatedTags ()
		{
			const string __id = "addAnnotatedTags.()Lorg/eclipse/jgit/api/NameRevCommand;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_addPrefix_Ljava_lang_String_ == null)
				cb_addPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddPrefix_Ljava_lang_String_);
			return cb_addPrefix_Ljava_lang_String_;
		}

		static IntPtr n_AddPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPrefix (prefix));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="prefix">prefix to add; see <c>RefDatabase#getRefs(String)</c></param>
		/// <summary>Add a ref prefix to the set that results must match.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='NameRevCommand']/method[@name='addPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPrefix", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/NameRevCommand;", "GetAddPrefix_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.NameRevCommand AddPrefix (string prefix)
		{
			const string __id = "addPrefix.(Ljava/lang/String;)Lorg/eclipse/jgit/api/NameRevCommand;";
			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		static Delegate cb_addRef_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetAddRef_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_addRef_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_addRef_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddRef_Lorg_eclipse_jgit_lib_Ref_);
			return cb_addRef_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_AddRef_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native__ref, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddRef (@ref));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="ref">ref to add.</param>
		/// <summary>Add a ref to the set that all results must match.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='NameRevCommand']/method[@name='addRef' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("addRef", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/NameRevCommand;", "GetAddRef_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.NameRevCommand AddRef (global::Org.Eclipse.Jgit.Lib.IRef @ref)
		{
			const string __id = "addRef.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/NameRevCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@ref);
			}
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.NameRevCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Org.Eclipse.Jgit.Lib.ObjectId, string>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='NameRevCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/Map;", "GetCallHandler")]
		public override unsafe global::System.Collections.Generic.IDictionary<global::Org.Eclipse.Jgit.Lib.ObjectId, string> Call ()
		{
			const string __id = "call.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<global::Org.Eclipse.Jgit.Lib.ObjectId, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
