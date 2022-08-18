using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Describes how refs in one repository copy into another repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/RefSpec", DoNotGenerateAcw=true)]
	public partial class RefSpec : global::Java.Lang.Object, global::Java.IO.ISerializable {
		/// <summary>Suffix for wildcard ref spec component, that indicate matching all refs
		/// with specified prefix.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/field[@name='WILDCARD_SUFFIX']"
		[Register ("WILDCARD_SUFFIX")]
		public const string WildcardSuffix = (string) "/*";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RefSpec", typeof (RefSpec));

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

		protected RefSpec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Construct an empty RefSpec.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/constructor[@name='RefSpec' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RefSpec () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="spec">string describing the specification.</param>
		/// <summary>Parse a ref specification for use during transport operations.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/constructor[@name='RefSpec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RefSpec (string spec) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_spec = JNIEnv.NewString ((string)spec);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_spec);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_spec);
			}
		}

		static Delegate cb_getDestination;
#pragma warning disable 0169
		static Delegate GetGetDestinationHandler ()
		{
			if (cb_getDestination == null)
				cb_getDestination = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDestination);
			return cb_getDestination;
		}

		static IntPtr n_GetDestination (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Destination);
		}
#pragma warning restore 0169

		/// <summary>Get the destination ref description.</summary>
		/// <returns>name (or wildcard) pattern to match the destination ref.</returns>
		public virtual unsafe string Destination {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='getDestination' and count(parameter)=0]"
			[Register ("getDestination", "()Ljava/lang/String;", "GetGetDestinationHandler")]
			get {
				const string __id = "getDestination.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isForceUpdate;
#pragma warning disable 0169
		static Delegate GetIsForceUpdateHandler ()
		{
			if (cb_isForceUpdate == null)
				cb_isForceUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsForceUpdate);
			return cb_isForceUpdate;
		}

		static bool n_IsForceUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsForceUpdate;
		}
#pragma warning restore 0169

		/// <summary>Check if this specification wants to forcefully update the destination.</summary>
		/// <returns>true if this specification asks for updates without merge tests.</returns>
		public virtual unsafe bool IsForceUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='isForceUpdate' and count(parameter)=0]"
			[Register ("isForceUpdate", "()Z", "GetIsForceUpdateHandler")]
			get {
				const string __id = "isForceUpdate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isWildcard;
#pragma warning disable 0169
		static Delegate GetIsWildcardHandler ()
		{
			if (cb_isWildcard == null)
				cb_isWildcard = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsWildcard);
			return cb_isWildcard;
		}

		static bool n_IsWildcard (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWildcard;
		}
#pragma warning restore 0169

		/// <summary>Check if this specification is actually a wildcard pattern.</summary>
		/// <returns>true if this specification could match more than one ref.</returns>
		public virtual unsafe bool IsWildcard {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='isWildcard' and count(parameter)=0]"
			[Register ("isWildcard", "()Z", "GetIsWildcardHandler")]
			get {
				const string __id = "isWildcard.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSource);
			return cb_getSource;
		}

		static IntPtr n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Source);
		}
#pragma warning restore 0169

		/// <summary>Get the source ref description.</summary>
		/// <returns>name (or wildcard pattern) to match the source ref.</returns>
		public virtual unsafe string Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Ljava/lang/String;", "GetGetSourceHandler")]
			get {
				const string __id = "getSource.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_expandFromDestination_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExpandFromDestination_Ljava_lang_String_Handler ()
		{
			if (cb_expandFromDestination_Ljava_lang_String_ == null)
				cb_expandFromDestination_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ExpandFromDestination_Ljava_lang_String_);
			return cb_expandFromDestination_Ljava_lang_String_;
		}

		static IntPtr n_ExpandFromDestination_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = JNIEnv.GetString (native_r, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExpandFromDestination (r));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="r">a ref name that matched our destination specification. Could
		///            be a wildcard also.</param>
		/// <summary>Expand this specification to exactly match a ref name.</summary>
		/// <returns>a new specification expanded from provided ref name. Result
		///         specification is wildcard if and only if provided ref name is
		///         wildcard.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='expandFromDestination' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("expandFromDestination", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;", "GetExpandFromDestination_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RefSpec ExpandFromDestination (string r)
		{
			const string __id = "expandFromDestination.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;";
			IntPtr native_r = JNIEnv.NewString ((string)r);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_r);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_r);
			}
		}

		static Delegate cb_expandFromDestination_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetExpandFromDestination_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_expandFromDestination_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_expandFromDestination_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ExpandFromDestination_Lorg_eclipse_jgit_lib_Ref_);
			return cb_expandFromDestination_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_ExpandFromDestination_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_r, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExpandFromDestination (r));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="r">a ref that matched our destination specification.</param>
		/// <summary>Expand this specification to exactly match a ref.</summary>
		/// <returns>a new specification expanded from provided ref name. Result
		///         specification is wildcard if and only if provided ref name is
		///         wildcard.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='expandFromDestination' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("expandFromDestination", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/transport/RefSpec;", "GetExpandFromDestination_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RefSpec ExpandFromDestination (global::Org.Eclipse.Jgit.Lib.IRef r)
		{
			const string __id = "expandFromDestination.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/transport/RefSpec;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (r);
			}
		}

		static Delegate cb_expandFromSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExpandFromSource_Ljava_lang_String_Handler ()
		{
			if (cb_expandFromSource_Ljava_lang_String_ == null)
				cb_expandFromSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ExpandFromSource_Ljava_lang_String_);
			return cb_expandFromSource_Ljava_lang_String_;
		}

		static IntPtr n_ExpandFromSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = JNIEnv.GetString (native_r, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExpandFromSource (r));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="r">a ref name that matched our source specification. Could be a
		///            wildcard also.</param>
		/// <summary>Expand this specification to exactly match a ref name.</summary>
		/// <returns>a new specification expanded from provided ref name. Result
		///         specification is wildcard if and only if provided ref name is
		///         wildcard.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='expandFromSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("expandFromSource", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;", "GetExpandFromSource_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RefSpec ExpandFromSource (string r)
		{
			const string __id = "expandFromSource.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;";
			IntPtr native_r = JNIEnv.NewString ((string)r);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_r);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_r);
			}
		}

		static Delegate cb_expandFromSource_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetExpandFromSource_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_expandFromSource_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_expandFromSource_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ExpandFromSource_Lorg_eclipse_jgit_lib_Ref_);
			return cb_expandFromSource_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_ExpandFromSource_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_r, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExpandFromSource (r));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="r">a ref that matched our source specification. Could be a
		///            wildcard also.</param>
		/// <summary>Expand this specification to exactly match a ref.</summary>
		/// <returns>a new specification expanded from provided ref name. Result
		///         specification is wildcard if and only if provided ref name is
		///         wildcard.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='expandFromSource' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("expandFromSource", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/transport/RefSpec;", "GetExpandFromSource_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RefSpec ExpandFromSource (global::Org.Eclipse.Jgit.Lib.IRef r)
		{
			const string __id = "expandFromSource.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/transport/RefSpec;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (r);
			}
		}

		/// <param name="s">ref spec component - string to test. Can be null.</param>
		/// <summary>Check whether provided string is a wildcard ref spec component.</summary>
		/// <returns>true if provided string is a wildcard ref spec component.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='isWildcard' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isWildcard", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool InvokeIsWildcard (string s)
		{
			const string __id = "isWildcard.(Ljava/lang/String;)Z";
			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_matchDestination_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMatchDestination_Ljava_lang_String_Handler ()
		{
			if (cb_matchDestination_Ljava_lang_String_ == null)
				cb_matchDestination_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_MatchDestination_Ljava_lang_String_);
			return cb_matchDestination_Ljava_lang_String_;
		}

		static bool n_MatchDestination_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = JNIEnv.GetString (native_r, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MatchDestination (r);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="r">ref name that should be tested.</param>
		/// <summary>Does this specification's destination description match the ref name?</summary>
		/// <returns>true if the names match; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='matchDestination' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("matchDestination", "(Ljava/lang/String;)Z", "GetMatchDestination_Ljava_lang_String_Handler")]
		public virtual unsafe bool MatchDestination (string r)
		{
			const string __id = "matchDestination.(Ljava/lang/String;)Z";
			IntPtr native_r = JNIEnv.NewString ((string)r);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_r);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_r);
			}
		}

		static Delegate cb_matchDestination_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetMatchDestination_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_matchDestination_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_matchDestination_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_MatchDestination_Lorg_eclipse_jgit_lib_Ref_);
			return cb_matchDestination_Lorg_eclipse_jgit_lib_Ref_;
		}

		static bool n_MatchDestination_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_r, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MatchDestination (r);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="r">ref whose name should be tested.</param>
		/// <summary>Does this specification's destination description match the ref?</summary>
		/// <returns>true if the names match; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='matchDestination' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("matchDestination", "(Lorg/eclipse/jgit/lib/Ref;)Z", "GetMatchDestination_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe bool MatchDestination (global::Org.Eclipse.Jgit.Lib.IRef r)
		{
			const string __id = "matchDestination.(Lorg/eclipse/jgit/lib/Ref;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (r);
			}
		}

		static Delegate cb_matchSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMatchSource_Ljava_lang_String_Handler ()
		{
			if (cb_matchSource_Ljava_lang_String_ == null)
				cb_matchSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_MatchSource_Ljava_lang_String_);
			return cb_matchSource_Ljava_lang_String_;
		}

		static bool n_MatchSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = JNIEnv.GetString (native_r, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MatchSource (r);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="r">ref name that should be tested.</param>
		/// <summary>Does this specification's source description match the ref name?</summary>
		/// <returns>true if the names match; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='matchSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("matchSource", "(Ljava/lang/String;)Z", "GetMatchSource_Ljava_lang_String_Handler")]
		public virtual unsafe bool MatchSource (string r)
		{
			const string __id = "matchSource.(Ljava/lang/String;)Z";
			IntPtr native_r = JNIEnv.NewString ((string)r);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_r);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_r);
			}
		}

		static Delegate cb_matchSource_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetMatchSource_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_matchSource_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_matchSource_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_MatchSource_Lorg_eclipse_jgit_lib_Ref_);
			return cb_matchSource_Lorg_eclipse_jgit_lib_Ref_;
		}

		static bool n_MatchSource_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_r, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MatchSource (r);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="r">ref whose name should be tested.</param>
		/// <summary>Does this specification's source description match the ref?</summary>
		/// <returns>true if the names match; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='matchSource' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("matchSource", "(Lorg/eclipse/jgit/lib/Ref;)Z", "GetMatchSource_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe bool MatchSource (global::Org.Eclipse.Jgit.Lib.IRef r)
		{
			const string __id = "matchSource.(Lorg/eclipse/jgit/lib/Ref;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (r);
			}
		}

		static Delegate cb_setDestination_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDestination_Ljava_lang_String_Handler ()
		{
			if (cb_setDestination_Ljava_lang_String_ == null)
				cb_setDestination_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDestination_Ljava_lang_String_);
			return cb_setDestination_Ljava_lang_String_;
		}

		static IntPtr n_SetDestination_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_destination)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var destination = JNIEnv.GetString (native_destination, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDestination (destination));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="destination">new value for destination in the returned instance.</param>
		/// <summary>Create a new RefSpec with a different destination name setting.</summary>
		/// <returns>a new RefSpec with destination as specified.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='setDestination' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDestination", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;", "GetSetDestination_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RefSpec SetDestination (string destination)
		{
			const string __id = "setDestination.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;";
			IntPtr native_destination = JNIEnv.NewString ((string)destination);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_destination);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_destination);
			}
		}

		static Delegate cb_setForceUpdate_Z;
#pragma warning disable 0169
		static Delegate GetSetForceUpdate_ZHandler ()
		{
			if (cb_setForceUpdate_Z == null)
				cb_setForceUpdate_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetForceUpdate_Z);
			return cb_setForceUpdate_Z;
		}

		static IntPtr n_SetForceUpdate_Z (IntPtr jnienv, IntPtr native__this, bool forceUpdate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetForceUpdate (forceUpdate));
		}
#pragma warning restore 0169

		/// <param name="forceUpdate">new value for force update in the returned instance.</param>
		/// <summary>Create a new RefSpec with a different force update setting.</summary>
		/// <returns>a new RefSpec with force update as specified.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='setForceUpdate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setForceUpdate", "(Z)Lorg/eclipse/jgit/transport/RefSpec;", "GetSetForceUpdate_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RefSpec SetForceUpdate (bool forceUpdate)
		{
			const string __id = "setForceUpdate.(Z)Lorg/eclipse/jgit/transport/RefSpec;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (forceUpdate);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSource_Ljava_lang_String_Handler ()
		{
			if (cb_setSource_Ljava_lang_String_ == null)
				cb_setSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSource_Ljava_lang_String_);
			return cb_setSource_Ljava_lang_String_;
		}

		static IntPtr n_SetSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSource (source));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="source">new value for source in the returned instance.</param>
		/// <summary>Create a new RefSpec with a different source name setting.</summary>
		/// <returns>a new RefSpec with source as specified.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSource", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;", "GetSetSource_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RefSpec SetSource (string source)
		{
			const string __id = "setSource.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;";
			IntPtr native_source = JNIEnv.NewString ((string)source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_source);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
			}
		}

		static Delegate cb_setSourceDestination_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSourceDestination_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setSourceDestination_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setSourceDestination_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetSourceDestination_Ljava_lang_String_Ljava_lang_String_);
			return cb_setSourceDestination_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetSourceDestination_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_destination)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			var destination = JNIEnv.GetString (native_destination, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSourceDestination (source, destination));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="source">new value for source in the returned instance.</param>
		/// <param name="destination">new value for destination in the returned instance.</param>
		/// <summary>Create a new RefSpec with a different source/destination name setting.</summary>
		/// <returns>a new RefSpec with destination as specified.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefSpec']/method[@name='setSourceDestination' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSourceDestination", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;", "GetSetSourceDestination_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RefSpec SetSourceDestination (string source, string destination)
		{
			const string __id = "setSourceDestination.(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/jgit/transport/RefSpec;";
			IntPtr native_source = JNIEnv.NewString ((string)source);
			IntPtr native_destination = JNIEnv.NewString ((string)destination);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_source);
				__args [1] = new JniArgumentValue (native_destination);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
				JNIEnv.DeleteLocalRef (native_destination);
			}
		}

	}
}
