using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Specialized Map to present a <c>RefDatabase</c> namespace.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefMap']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/RefMap", DoNotGenerateAcw=true)]
	public partial class RefMap : global::Java.Util.AbstractMap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/RefMap", typeof (RefMap));

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

		protected RefMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Construct an empty map with a small initial capacity.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefMap']/constructor[@name='RefMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RefMap () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="prefix">prefix used to slice the lists down. Only references whose
		///            names start with this prefix will appear to reside in the map.
		///            Must not be null, use <c>""</c> (the empty string) to select
		///            all list items.</param>
		/// <param name="packed">items from the packed reference list, this is the last list
		///            searched.</param>
		/// <param name="loose">items from the loose reference list, this list overrides
		///            <c>packed</c> if a name appears in both.</param>
		/// <param name="resolved">resolved symbolic references. This list overrides the prior
		///            list <c>loose</c>, if an item appears in both. Items in this
		///            list &lt;b&gt;must&lt;/b&gt; also appear in <c>loose</c>.</param>
		/// <summary>Construct a map to merge 3 collections together.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefMap']/constructor[@name='RefMap' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.util.RefList&lt;? extends org.eclipse.jgit.lib.Ref&gt;'] and parameter[3][@type='org.eclipse.jgit.util.RefList&lt;? extends org.eclipse.jgit.lib.Ref&gt;'] and parameter[4][@type='org.eclipse.jgit.util.RefList&lt;? extends org.eclipse.jgit.lib.Ref&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/eclipse/jgit/util/RefList;Lorg/eclipse/jgit/util/RefList;Lorg/eclipse/jgit/util/RefList;)V", "")]
		public unsafe RefMap (string prefix, global::Org.Eclipse.Jgit.Util.RefList packed, global::Org.Eclipse.Jgit.Util.RefList loose, global::Org.Eclipse.Jgit.Util.RefList resolved) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/eclipse/jgit/util/RefList;Lorg/eclipse/jgit/util/RefList;Lorg/eclipse/jgit/util/RefList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_prefix = JNIEnv.NewString ((string)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_prefix);
				__args [1] = new JniArgumentValue ((packed == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packed).Handle);
				__args [2] = new JniArgumentValue ((loose == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loose).Handle);
				__args [3] = new JniArgumentValue ((resolved == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resolved).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				global::System.GC.KeepAlive (packed);
				global::System.GC.KeepAlive (loose);
				global::System.GC.KeepAlive (resolved);
			}
		}

		static Delegate cb_entrySet;
#pragma warning disable 0169
		static Delegate GetEntrySetHandler ()
		{
			if (cb_entrySet == null)
				cb_entrySet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_EntrySet);
			return cb_entrySet;
		}

		static IntPtr n_EntrySet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.ToLocalJniHandle (__this.EntrySet ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefMap']/method[@name='entrySet' and count(parameter)=0]"
		[Register ("entrySet", "()Ljava/util/Set;", "GetEntrySetHandler")]
		public override unsafe global::System.Collections.ICollection EntrySet ()
		{
			const string __id = "entrySet.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_lang_String_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_put_Ljava_lang_String_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Put_Ljava_lang_String_Lorg_eclipse_jgit_lib_Ref_);
			return cb_put_Ljava_lang_String_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_Put_Ljava_lang_String_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_keyName, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var keyName = JNIEnv.GetString (native_keyName, JniHandleOwnership.DoNotTransfer);
			var value = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (keyName, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefMap']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("put", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;", "GetPut_Ljava_lang_String_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IRef Put (string keyName, global::Org.Eclipse.Jgit.Lib.IRef value)
		{
			const string __id = "put.(Ljava/lang/String;Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/lib/Ref;";
			IntPtr native_keyName = JNIEnv.NewString ((string)keyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_keyName);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyName);
				global::System.GC.KeepAlive (value);
			}
		}

	}
}
