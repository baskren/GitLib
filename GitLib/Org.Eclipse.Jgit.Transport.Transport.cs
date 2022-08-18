using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Connects two Git repositories together and copies objects between them.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/Transport", DoNotGenerateAcw=true)]
	public abstract partial class Transport : global::Java.Lang.Object {
		/// <summary>Default setting for <c>#fetchThin</c> option.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/field[@name='DEFAULT_FETCH_THIN']"
		[Register ("DEFAULT_FETCH_THIN")]
		public const bool DefaultFetchThin = (bool) true;

		/// <summary>Default setting for <c>#pushThin</c> option.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/field[@name='DEFAULT_PUSH_THIN']"
		[Register ("DEFAULT_PUSH_THIN")]
		public const bool DefaultPushThin = (bool) false;


		/// <summary>The repository this transport fetches into, or pushes out of.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/field[@name='local']"
		[Register ("local")]
		protected global::Org.Eclipse.Jgit.Lib.Repository Local {
			get {
				const string __id = "local.Lorg/eclipse/jgit/lib/Repository;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "local.Lorg/eclipse/jgit/lib/Repository;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Specification for push operation, to push all refs under refs/heads.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/field[@name='REFSPEC_PUSH_ALL']"
		[Register ("REFSPEC_PUSH_ALL")]
		public static global::Org.Eclipse.Jgit.Transport.RefSpec RefspecPushAll {
			get {
				const string __id = "REFSPEC_PUSH_ALL.Lorg/eclipse/jgit/transport/RefSpec;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Specification for fetch or push operations, to fetch or push all tags.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/field[@name='REFSPEC_TAGS']"
		[Register ("REFSPEC_TAGS")]
		public static global::Org.Eclipse.Jgit.Transport.RefSpec RefspecTags {
			get {
				const string __id = "REFSPEC_TAGS.Lorg/eclipse/jgit/transport/RefSpec;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefSpec> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>The URI used to create this transport.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/field[@name='uri']"
		[Register ("uri")]
		protected global::Org.Eclipse.Jgit.Transport.URIish Uri {
			get {
				const string __id = "uri.Lorg/eclipse/jgit/transport/URIish;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uri.Lorg/eclipse/jgit/transport/URIish;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		/// <summary>Type of operation a Transport is being opened for.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport.Operation']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/Transport$Operation", DoNotGenerateAcw=true)]
		public sealed partial class Operation : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport.Operation']/field[@name='FETCH']"
			[Register ("FETCH")]
			public static global::Org.Eclipse.Jgit.Transport.Transport.Operation Fetch {
				get {
					const string __id = "FETCH.Lorg/eclipse/jgit/transport/Transport$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport.Operation']/field[@name='PUSH']"
			[Register ("PUSH")]
			public static global::Org.Eclipse.Jgit.Transport.Transport.Operation Push {
				get {
					const string __id = "PUSH.Lorg/eclipse/jgit/transport/Transport$Operation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport.Operation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/Transport$Operation", typeof (Operation));

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

			internal Operation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport.Operation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/Transport$Operation;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.Transport.Operation ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/Transport$Operation;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport.Operation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport.Operation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/transport/Transport$Operation;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.Transport.Operation[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/transport/Transport$Operation;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Transport.Transport.Operation[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Transport.Transport.Operation));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/Transport", typeof (Transport));

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

		protected Transport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="local">the repository this instance will fetch into, or push out of.
		///            This must be the repository passed to
		///            <c>#open(Repository, URIish)</c>.</param>
		/// <param name="uri">the URI used to access the remote repository. This must be the
		///            URI passed to <c>#open(Repository, URIish)</c>.</param>
		/// <summary>Create a new transport instance.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/constructor[@name='Transport' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.URIish']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;)V", "")]
		protected unsafe Transport (global::Org.Eclipse.Jgit.Lib.Repository local, global::Org.Eclipse.Jgit.Transport.URIish uri) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (uri);
			}
		}

		/// <param name="uri">uri</param>
		/// <summary>Create a minimal transport instance not tied to a single repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/constructor[@name='Transport' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/transport/URIish;)V", "")]
		protected unsafe Transport (global::Org.Eclipse.Jgit.Transport.URIish uri) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/transport/URIish;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		static Delegate cb_isCheckFetchedObjects;
#pragma warning disable 0169
		static Delegate GetIsCheckFetchedObjectsHandler ()
		{
			if (cb_isCheckFetchedObjects == null)
				cb_isCheckFetchedObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCheckFetchedObjects);
			return cb_isCheckFetchedObjects;
		}

		static bool n_IsCheckFetchedObjects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckFetchedObjects;
		}
#pragma warning restore 0169

		static Delegate cb_setCheckFetchedObjects_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckFetchedObjects_ZHandler ()
		{
			if (cb_setCheckFetchedObjects_Z == null)
				cb_setCheckFetchedObjects_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCheckFetchedObjects_Z);
			return cb_setCheckFetchedObjects_Z;
		}

		static void n_SetCheckFetchedObjects_Z (IntPtr jnienv, IntPtr native__this, bool check)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckFetchedObjects = check;
		}
#pragma warning restore 0169

		/// <returns>true if fetch will verify received objects are formatted
		///         correctly. Validating objects requires more CPU time on the
		///         client side of the connection.</returns>
		/// <param name="check">true to enable checking received objects; false to assume all
		///            received objects are valid.</param>
		public virtual unsafe bool CheckFetchedObjects {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='isCheckFetchedObjects' and count(parameter)=0]"
			[Register ("isCheckFetchedObjects", "()Z", "GetIsCheckFetchedObjectsHandler")]
			get {
				const string __id = "isCheckFetchedObjects.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setCheckFetchedObjects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCheckFetchedObjects", "(Z)V", "GetSetCheckFetchedObjects_ZHandler")]
			set {
				const string __id = "setCheckFetchedObjects.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCredentialsProvider;
#pragma warning disable 0169
		static Delegate GetGetCredentialsProviderHandler ()
		{
			if (cb_getCredentialsProvider == null)
				cb_getCredentialsProvider = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCredentialsProvider);
			return cb_getCredentialsProvider;
		}

		static IntPtr n_GetCredentialsProvider (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CredentialsProvider);
		}
#pragma warning restore 0169

		static Delegate cb_setCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_;
#pragma warning disable 0169
		static Delegate GetSetCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_Handler ()
		{
			if (cb_setCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_ == null)
				cb_setCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_);
			return cb_setCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_;
		}

		static void n_SetCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentialsProvider)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var credentialsProvider = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (native_credentialsProvider, JniHandleOwnership.DoNotTransfer);
			__this.CredentialsProvider = credentialsProvider;
		}
#pragma warning restore 0169

		/// <summary>The configured credentials provider. -or- A credentials provider to assist with authentication connections.</summary>
		/// <returns>the credentials provider, or null if no credentials provider is
		///         associated with this transport.</returns>
		/// <param name="credentialsProvider">the credentials provider, or null if there is none</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.CredentialsProvider CredentialsProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='getCredentialsProvider' and count(parameter)=0]"
			[Register ("getCredentialsProvider", "()Lorg/eclipse/jgit/transport/CredentialsProvider;", "GetGetCredentialsProviderHandler")]
			get {
				const string __id = "getCredentialsProvider.()Lorg/eclipse/jgit/transport/CredentialsProvider;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialsProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setCredentialsProvider' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.CredentialsProvider']]"
			[Register ("setCredentialsProvider", "(Lorg/eclipse/jgit/transport/CredentialsProvider;)V", "GetSetCredentialsProvider_Lorg_eclipse_jgit_transport_CredentialsProvider_Handler")]
			set {
				const string __id = "setCredentialsProvider.(Lorg/eclipse/jgit/transport/CredentialsProvider;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isDryRun;
#pragma warning disable 0169
		static Delegate GetIsDryRunHandler ()
		{
			if (cb_isDryRun == null)
				cb_isDryRun = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDryRun);
			return cb_isDryRun;
		}

		static bool n_IsDryRun (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DryRun;
		}
#pragma warning restore 0169

		static Delegate cb_setDryRun_Z;
#pragma warning disable 0169
		static Delegate GetSetDryRun_ZHandler ()
		{
			if (cb_setDryRun_Z == null)
				cb_setDryRun_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDryRun_Z);
			return cb_setDryRun_Z;
		}

		static void n_SetDryRun_Z (IntPtr jnienv, IntPtr native__this, bool dryRun)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DryRun = dryRun;
		}
#pragma warning restore 0169

		/// <returns>true if push operation should just check for possible result and
		///         not really update remote refs, false otherwise - when push should
		///         act normally.</returns>
		/// <summary>Set dry run option for push operation.</summary>
		/// <param name="dryRun">true if push operation should just check for possible result
		///            and not really update remote refs, false otherwise - when push
		///            should act normally.</param>
		public virtual unsafe bool DryRun {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='isDryRun' and count(parameter)=0]"
			[Register ("isDryRun", "()Z", "GetIsDryRunHandler")]
			get {
				const string __id = "isDryRun.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setDryRun' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDryRun", "(Z)V", "GetSetDryRun_ZHandler")]
			set {
				const string __id = "setDryRun.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isFetchThin;
#pragma warning disable 0169
		static Delegate GetIsFetchThinHandler ()
		{
			if (cb_isFetchThin == null)
				cb_isFetchThin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFetchThin);
			return cb_isFetchThin;
		}

		static bool n_IsFetchThin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FetchThin;
		}
#pragma warning restore 0169

		static Delegate cb_setFetchThin_Z;
#pragma warning disable 0169
		static Delegate GetSetFetchThin_ZHandler ()
		{
			if (cb_setFetchThin_Z == null)
				cb_setFetchThin_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFetchThin_Z);
			return cb_setFetchThin_Z;
		}

		static void n_SetFetchThin_Z (IntPtr jnienv, IntPtr native__this, bool fetchThin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FetchThin = fetchThin;
		}
#pragma warning restore 0169

		/// <summary>Default setting is: <c>#DEFAULT_FETCH_THIN</c> -or- Set the thin-pack preference for fetch operation.</summary>
		/// <returns>true if fetch should request thin-pack when possible; false
		///         otherwise</returns>
		/// <param name="fetchThin">true when fetch should request thin-pack when possible; false
		///            when it shouldn't</param>
		public virtual unsafe bool FetchThin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='isFetchThin' and count(parameter)=0]"
			[Register ("isFetchThin", "()Z", "GetIsFetchThinHandler")]
			get {
				const string __id = "isFetchThin.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setFetchThin' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFetchThin", "(Z)V", "GetSetFetchThin_ZHandler")]
			set {
				const string __id = "setFetchThin.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectChecker;
#pragma warning disable 0169
		static Delegate GetGetObjectCheckerHandler ()
		{
			if (cb_getObjectChecker == null)
				cb_getObjectChecker = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectChecker);
			return cb_getObjectChecker;
		}

		static IntPtr n_GetObjectChecker (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectChecker);
		}
#pragma warning restore 0169

		static Delegate cb_setObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_;
#pragma warning disable 0169
		static Delegate GetSetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_Handler ()
		{
			if (cb_setObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_ == null)
				cb_setObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_);
			return cb_setObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_;
		}

		static void n_SetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_impl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var impl = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (native_impl, JniHandleOwnership.DoNotTransfer);
			__this.ObjectChecker = impl;
		}
#pragma warning restore 0169

		/// <returns>configured object checker for received objects, or null.</returns>
		/// <param name="impl">if non-null the object checking instance to verify each
		///            received object with; null to disable object checking.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectChecker ObjectChecker {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='getObjectChecker' and count(parameter)=0]"
			[Register ("getObjectChecker", "()Lorg/eclipse/jgit/lib/ObjectChecker;", "GetGetObjectCheckerHandler")]
			get {
				const string __id = "getObjectChecker.()Lorg/eclipse/jgit/lib/ObjectChecker;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setObjectChecker' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectChecker']]"
			[Register ("setObjectChecker", "(Lorg/eclipse/jgit/lib/ObjectChecker;)V", "GetSetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_Handler")]
			set {
				const string __id = "setObjectChecker.(Lorg/eclipse/jgit/lib/ObjectChecker;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getOptionReceivePack;
#pragma warning disable 0169
		static Delegate GetGetOptionReceivePackHandler ()
		{
			if (cb_getOptionReceivePack == null)
				cb_getOptionReceivePack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOptionReceivePack);
			return cb_getOptionReceivePack;
		}

		static IntPtr n_GetOptionReceivePack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OptionReceivePack);
		}
#pragma warning restore 0169

		static Delegate cb_setOptionReceivePack_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOptionReceivePack_Ljava_lang_String_Handler ()
		{
			if (cb_setOptionReceivePack_Ljava_lang_String_ == null)
				cb_setOptionReceivePack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOptionReceivePack_Ljava_lang_String_);
			return cb_setOptionReceivePack_Ljava_lang_String_;
		}

		static void n_SetOptionReceivePack_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_optionReceivePack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var optionReceivePack = JNIEnv.GetString (native_optionReceivePack, JniHandleOwnership.DoNotTransfer);
			__this.OptionReceivePack = optionReceivePack;
		}
#pragma warning restore 0169

		/// <summary>Default setting is: <c>RemoteConfig#DEFAULT_RECEIVE_PACK</c> -or- Set remote executable providing receive-pack service for pack transports.</summary>
		/// <returns>remote executable providing receive-pack service for pack
		///         transports.</returns>
		/// <param name="optionReceivePack">remote executable, if null or empty default one is set;</param>
		public virtual unsafe string OptionReceivePack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='getOptionReceivePack' and count(parameter)=0]"
			[Register ("getOptionReceivePack", "()Ljava/lang/String;", "GetGetOptionReceivePackHandler")]
			get {
				const string __id = "getOptionReceivePack.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setOptionReceivePack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOptionReceivePack", "(Ljava/lang/String;)V", "GetSetOptionReceivePack_Ljava_lang_String_Handler")]
			set {
				const string __id = "setOptionReceivePack.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOptionUploadPack;
#pragma warning disable 0169
		static Delegate GetGetOptionUploadPackHandler ()
		{
			if (cb_getOptionUploadPack == null)
				cb_getOptionUploadPack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOptionUploadPack);
			return cb_getOptionUploadPack;
		}

		static IntPtr n_GetOptionUploadPack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OptionUploadPack);
		}
#pragma warning restore 0169

		static Delegate cb_setOptionUploadPack_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOptionUploadPack_Ljava_lang_String_Handler ()
		{
			if (cb_setOptionUploadPack_Ljava_lang_String_ == null)
				cb_setOptionUploadPack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOptionUploadPack_Ljava_lang_String_);
			return cb_setOptionUploadPack_Ljava_lang_String_;
		}

		static void n_SetOptionUploadPack_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__where)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @where = JNIEnv.GetString (native__where, JniHandleOwnership.DoNotTransfer);
			__this.OptionUploadPack = @where;
		}
#pragma warning restore 0169

		/// <summary>Get the name of the remote executable providing upload-pack service. -or- Set the name of the remote executable providing upload-pack services.</summary>
		/// <returns>typically "git-upload-pack".</returns>
		/// <param name="where">name of the executable.</param>
		public virtual unsafe string OptionUploadPack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='getOptionUploadPack' and count(parameter)=0]"
			[Register ("getOptionUploadPack", "()Ljava/lang/String;", "GetGetOptionUploadPackHandler")]
			get {
				const string __id = "getOptionUploadPack.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setOptionUploadPack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOptionUploadPack", "(Ljava/lang/String;)V", "GetSetOptionUploadPack_Ljava_lang_String_Handler")]
			set {
				const string __id = "setOptionUploadPack.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPackConfig;
#pragma warning disable 0169
		static Delegate GetGetPackConfigHandler ()
		{
			if (cb_getPackConfig == null)
				cb_getPackConfig = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackConfig);
			return cb_getPackConfig;
		}

		static IntPtr n_GetPackConfig (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackConfig);
		}
#pragma warning restore 0169

		static Delegate cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
#pragma warning disable 0169
		static Delegate GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler ()
		{
			if (cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ == null)
				cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_);
			return cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
		}

		static void n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (native_pc, JniHandleOwnership.DoNotTransfer);
			__this.PackConfig = pc;
		}
#pragma warning restore 0169

		/// <summary>Get the configuration used by the pack generator to make packs. -or- Set the configuration used by the pack generator.</summary>
		/// <returns>the pack configuration. Never null.</returns>
		/// <param name="pc">configuration controlling packing parameters. If null the
		///            source repository's settings will be used.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Storage.Pack.PackConfig PackConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='getPackConfig' and count(parameter)=0]"
			[Register ("getPackConfig", "()Lorg/eclipse/jgit/storage/pack/PackConfig;", "GetGetPackConfigHandler")]
			get {
				const string __id = "getPackConfig.()Lorg/eclipse/jgit/storage/pack/PackConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setPackConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.storage.pack.PackConfig']]"
			[Register ("setPackConfig", "(Lorg/eclipse/jgit/storage/pack/PackConfig;)V", "GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler")]
			set {
				const string __id = "setPackConfig.(Lorg/eclipse/jgit/storage/pack/PackConfig;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isPushThin;
#pragma warning disable 0169
		static Delegate GetIsPushThinHandler ()
		{
			if (cb_isPushThin == null)
				cb_isPushThin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPushThin);
			return cb_isPushThin;
		}

		static bool n_IsPushThin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PushThin;
		}
#pragma warning restore 0169

		static Delegate cb_setPushThin_Z;
#pragma warning disable 0169
		static Delegate GetSetPushThin_ZHandler ()
		{
			if (cb_setPushThin_Z == null)
				cb_setPushThin_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPushThin_Z);
			return cb_setPushThin_Z;
		}

		static void n_SetPushThin_Z (IntPtr jnienv, IntPtr native__this, bool pushThin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PushThin = pushThin;
		}
#pragma warning restore 0169

		/// <summary>Default setting is: <c>#DEFAULT_PUSH_THIN</c> -or- Set thin-pack preference for push operation.</summary>
		/// <returns>true if push should produce thin-pack in pack transports</returns>
		/// <param name="pushThin">true when push should produce thin-pack in pack transports;
		///            false when it shouldn't</param>
		public virtual unsafe bool PushThin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='isPushThin' and count(parameter)=0]"
			[Register ("isPushThin", "()Z", "GetIsPushThinHandler")]
			get {
				const string __id = "isPushThin.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setPushThin' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPushThin", "(Z)V", "GetSetPushThin_ZHandler")]
			set {
				const string __id = "setPushThin.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRemoveDeletedRefs;
#pragma warning disable 0169
		static Delegate GetIsRemoveDeletedRefsHandler ()
		{
			if (cb_isRemoveDeletedRefs == null)
				cb_isRemoveDeletedRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRemoveDeletedRefs);
			return cb_isRemoveDeletedRefs;
		}

		static bool n_IsRemoveDeletedRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveDeletedRefs;
		}
#pragma warning restore 0169

		static Delegate cb_setRemoveDeletedRefs_Z;
#pragma warning disable 0169
		static Delegate GetSetRemoveDeletedRefs_ZHandler ()
		{
			if (cb_setRemoveDeletedRefs_Z == null)
				cb_setRemoveDeletedRefs_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetRemoveDeletedRefs_Z);
			return cb_setRemoveDeletedRefs_Z;
		}

		static void n_SetRemoveDeletedRefs_Z (IntPtr jnienv, IntPtr native__this, bool @remove)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDeletedRefs = @remove;
		}
#pragma warning restore 0169

		/// <returns>true if destination refs should be removed if they no longer
		///         exist at the source repository.</returns>
		/// <summary>Set whether or not to remove refs which no longer exist in the source.</summary>
		/// <param name="remove">true to remove refs that no longer exist.</param>
		public virtual unsafe bool RemoveDeletedRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='isRemoveDeletedRefs' and count(parameter)=0]"
			[Register ("isRemoveDeletedRefs", "()Z", "GetIsRemoveDeletedRefsHandler")]
			get {
				const string __id = "isRemoveDeletedRefs.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setRemoveDeletedRefs' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRemoveDeletedRefs", "(Z)V", "GetSetRemoveDeletedRefs_ZHandler")]
			set {
				const string __id = "setRemoveDeletedRefs.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTagOpt;
#pragma warning disable 0169
		static Delegate GetGetTagOptHandler ()
		{
			if (cb_getTagOpt == null)
				cb_getTagOpt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTagOpt);
			return cb_getTagOpt;
		}

		static IntPtr n_GetTagOpt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TagOpt);
		}
#pragma warning restore 0169

		static Delegate cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_;
#pragma warning disable 0169
		static Delegate GetSetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_Handler ()
		{
			if (cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_ == null)
				cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_);
			return cb_setTagOpt_Lorg_eclipse_jgit_transport_TagOpt_;
		}

		static void n_SetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_option)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var option = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (native_option, JniHandleOwnership.DoNotTransfer);
			__this.TagOpt = option;
		}
#pragma warning restore 0169

		/// <summary>Get the description of how annotated tags should be treated during fetch. -or- Set the description of how annotated tags should be treated on fetch.</summary>
		/// <returns>option indicating the behavior of annotated tags in fetch.</returns>
		/// <param name="option">method to use when handling annotated tags.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.TagOpt TagOpt {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='getTagOpt' and count(parameter)=0]"
			[Register ("getTagOpt", "()Lorg/eclipse/jgit/transport/TagOpt;", "GetGetTagOptHandler")]
			get {
				const string __id = "getTagOpt.()Lorg/eclipse/jgit/transport/TagOpt;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setTagOpt' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.TagOpt']]"
			[Register ("setTagOpt", "(Lorg/eclipse/jgit/transport/TagOpt;)V", "GetSetTagOpt_Lorg_eclipse_jgit_transport_TagOpt_Handler")]
			set {
				const string __id = "setTagOpt.(Lorg/eclipse/jgit/transport/TagOpt;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int seconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = seconds;
		}
#pragma warning restore 0169

		/// <returns>timeout (in seconds) before aborting an IO operation.</returns>
		/// <summary>Set the timeout before willing to abort an IO call.</summary>
		/// <param name="seconds">number of seconds to wait (with no data transfer occurring)
		///            before aborting an IO read or write operation with this
		///            remote.</param>
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				const string __id = "getTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
			set {
				const string __id = "setTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		/// <summary>Obtain a copy of the registered protocols.</summary>
		/// <returns>an immutable copy of the currently registered protocols.</returns>
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.TransportProtocol> TransportProtocols {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='getTransportProtocols' and count(parameter)=0]"
			[Register ("getTransportProtocols", "()Ljava/util/List;", "")]
			get {
				const string __id = "getTransportProtocols.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.TransportProtocol>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getURI;
#pragma warning disable 0169
		static Delegate GetGetURIHandler ()
		{
			if (cb_getURI == null)
				cb_getURI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetURI);
			return cb_getURI;
		}

		static IntPtr n_GetURI (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.URI);
		}
#pragma warning restore 0169

		/// <summary>Get the URI this transport connects to.</summary>
		/// <returns>the URI describing the location of the remote repository.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.URIish URI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='getURI' and count(parameter)=0]"
			[Register ("getURI", "()Lorg/eclipse/jgit/transport/URIish;", "GetGetURIHandler")]
			get {
				const string __id = "getURI.()Lorg/eclipse/jgit/transport/URIish;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_applyConfig_Lorg_eclipse_jgit_transport_RemoteConfig_;
#pragma warning disable 0169
		static Delegate GetApplyConfig_Lorg_eclipse_jgit_transport_RemoteConfig_Handler ()
		{
			if (cb_applyConfig_Lorg_eclipse_jgit_transport_RemoteConfig_ == null)
				cb_applyConfig_Lorg_eclipse_jgit_transport_RemoteConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ApplyConfig_Lorg_eclipse_jgit_transport_RemoteConfig_);
			return cb_applyConfig_Lorg_eclipse_jgit_transport_RemoteConfig_;
		}

		static void n_ApplyConfig_Lorg_eclipse_jgit_transport_RemoteConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cfg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cfg = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteConfig> (native_cfg, JniHandleOwnership.DoNotTransfer);
			__this.ApplyConfig (cfg);
		}
#pragma warning restore 0169

		/// <param name="cfg">configuration to apply on this transport.</param>
		/// <summary>Apply provided remote configuration on this transport.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='applyConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RemoteConfig']]"
		[Register ("applyConfig", "(Lorg/eclipse/jgit/transport/RemoteConfig;)V", "GetApplyConfig_Lorg_eclipse_jgit_transport_RemoteConfig_Handler")]
		public virtual unsafe void ApplyConfig (global::Org.Eclipse.Jgit.Transport.RemoteConfig cfg)
		{
			const string __id = "applyConfig.(Lorg/eclipse/jgit/transport/RemoteConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cfg);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		/// <summary>Close any resources used by this transport.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

		static Delegate cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Handler ()
		{
			if (cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_ == null)
				cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_);
			return cb_fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_;
		}

		static IntPtr n_Fetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_toFetch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var toFetch = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RefSpec>.FromJniHandle (native_toFetch, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Fetch (monitor, toFetch));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">progress monitor to inform the user about our processing
		///            activity. Must not be null. Use <c>NullProgressMonitor</c> if
		///            progress updates are not interesting or necessary.</param>
		/// <param name="toFetch">specification of refs to fetch locally. May be null or the
		///            empty collection to use the specifications from the
		///            RemoteConfig. Source for each RefSpec can't be null.</param>
		/// <summary>Fetch objects and refs from the remote repository to the local one.</summary>
		/// <returns>information describing the tracking refs updated.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.transport.RefSpec&gt;']]"
		[Register ("fetch", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;)Lorg/eclipse/jgit/transport/FetchResult;", "GetFetch_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.FetchResult Fetch (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.RefSpec> toFetch)
		{
			const string __id = "fetch.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;)Lorg/eclipse/jgit/transport/FetchResult;";
			IntPtr native_toFetch = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (toFetch);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_toFetch);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.FetchResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_toFetch);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (toFetch);
			}
		}

		static Delegate cb_findRemoteRefUpdatesFor_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetFindRemoteRefUpdatesFor_Ljava_util_Collection_Handler ()
		{
			if (cb_findRemoteRefUpdatesFor_Ljava_util_Collection_ == null)
				cb_findRemoteRefUpdatesFor_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FindRemoteRefUpdatesFor_Ljava_util_Collection_);
			return cb_findRemoteRefUpdatesFor_Ljava_util_Collection_;
		}

		static IntPtr n_FindRemoteRefUpdatesFor_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_specs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var specs = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RefSpec>.FromJniHandle (native_specs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.ToLocalJniHandle (__this.FindRemoteRefUpdatesFor (specs));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="specs">collection of RefSpec to convert.</param>
		/// <summary>Convert push remote refs update specification from <c>RefSpec</c> form
		/// to <c>RemoteRefUpdate</c>.</summary>
		/// <returns>collection of set up <c>RemoteRefUpdate</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='findRemoteRefUpdatesFor' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.transport.RefSpec&gt;']]"
		[Register ("findRemoteRefUpdatesFor", "(Ljava/util/Collection;)Ljava/util/Collection;", "GetFindRemoteRefUpdatesFor_Ljava_util_Collection_Handler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> FindRemoteRefUpdatesFor (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.RefSpec> specs)
		{
			const string __id = "findRemoteRefUpdatesFor.(Ljava/util/Collection;)Ljava/util/Collection;";
			IntPtr native_specs = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (specs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_specs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_specs);
				global::System.GC.KeepAlive (specs);
			}
		}

		/// <param name="db">local database.</param>
		/// <param name="specs">collection of RefSpec to convert.</param>
		/// <param name="fetchSpecs">fetch specifications used for finding localtracking refs. May
		///            be null or empty collection.</param>
		/// <summary>Convert push remote refs update specification from <c>RefSpec</c> form
		/// to <c>RemoteRefUpdate</c>.</summary>
		/// <returns>collection of set up <c>RemoteRefUpdate</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='findRemoteRefUpdatesFor' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.transport.RefSpec&gt;'] and parameter[3][@type='java.util.Collection&lt;org.eclipse.jgit.transport.RefSpec&gt;']]"
		[Register ("findRemoteRefUpdatesFor", "(Lorg/eclipse/jgit/lib/Repository;Ljava/util/Collection;Ljava/util/Collection;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> FindRemoteRefUpdatesFor (global::Org.Eclipse.Jgit.Lib.Repository db, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.RefSpec> specs, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.RefSpec> fetchSpecs)
		{
			const string __id = "findRemoteRefUpdatesFor.(Lorg/eclipse/jgit/lib/Repository;Ljava/util/Collection;Ljava/util/Collection;)Ljava/util/Collection;";
			IntPtr native_specs = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (specs);
			IntPtr native_fetchSpecs = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RefSpec>.ToLocalJniHandle (fetchSpecs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue (native_specs);
				__args [2] = new JniArgumentValue (native_fetchSpecs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_specs);
				JNIEnv.DeleteLocalRef (native_fetchSpecs);
				global::System.GC.KeepAlive (db);
				global::System.GC.KeepAlive (specs);
				global::System.GC.KeepAlive (fetchSpecs);
			}
		}

		/// <param name="local">existing local repository.</param>
		/// <param name="remote">location of the remote repository - may be URI or remote
		///            configuration name.</param>
		/// <summary>Open a new transport instance to connect two repositories.</summary>
		/// <returns>the new transport instance. Never null. In case of multiple URIs
		///         in remote configuration, only the first is chosen.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Lorg/eclipse/jgit/transport/Transport;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Lib.Repository local, string remote)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Lorg/eclipse/jgit/transport/Transport;";
			IntPtr native_remote = JNIEnv.NewString ((string)remote);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue (native_remote);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remote);
				global::System.GC.KeepAlive (local);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='open' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.transport.Transport.Operation']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/transport/Transport$Operation;)Lorg/eclipse/jgit/transport/Transport;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Lib.Repository local, string remote, global::Org.Eclipse.Jgit.Transport.Transport.Operation op)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/transport/Transport$Operation;)Lorg/eclipse/jgit/transport/Transport;";
			IntPtr native_remote = JNIEnv.NewString ((string)remote);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue (native_remote);
				__args [2] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remote);
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (op);
			}
		}

		/// <param name="local">existing local repository.</param>
		/// <param name="cfg">configuration describing how to connect to the remote
		///            repository.</param>
		/// <summary>Open a new transport instance to connect two repositories.</summary>
		/// <returns>the new transport instance. Never null. In case of multiple URIs
		///         in remote configuration, only the first is chosen.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.RemoteConfig']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/RemoteConfig;)Lorg/eclipse/jgit/transport/Transport;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Lib.Repository local, global::Org.Eclipse.Jgit.Transport.RemoteConfig cfg)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/RemoteConfig;)Lorg/eclipse/jgit/transport/Transport;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (cfg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='open' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.RemoteConfig'] and parameter[3][@type='org.eclipse.jgit.transport.Transport.Operation']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/RemoteConfig;Lorg/eclipse/jgit/transport/Transport$Operation;)Lorg/eclipse/jgit/transport/Transport;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Lib.Repository local, global::Org.Eclipse.Jgit.Transport.RemoteConfig cfg, global::Org.Eclipse.Jgit.Transport.Transport.Operation op)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/RemoteConfig;Lorg/eclipse/jgit/transport/Transport$Operation;)Lorg/eclipse/jgit/transport/Transport;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				__args [2] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (cfg);
				global::System.GC.KeepAlive (op);
			}
		}

		/// <param name="local">existing local repository.</param>
		/// <param name="uri">location of the remote repository.</param>
		/// <summary>Open a new transport instance to connect two repositories.</summary>
		/// <returns>the new transport instance. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.URIish']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;)Lorg/eclipse/jgit/transport/Transport;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Lib.Repository local, global::Org.Eclipse.Jgit.Transport.URIish uri)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;)Lorg/eclipse/jgit/transport/Transport;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (uri);
			}
		}

		/// <param name="local">existing local repository.</param>
		/// <param name="uri">location of the remote repository.</param>
		/// <param name="remoteName">name of the remote, if the remote as configured in
		///            <c>local</c>; otherwise null.</param>
		/// <summary>Open a new transport instance to connect two repositories.</summary>
		/// <returns>the new transport instance. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='open' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.URIish'] and parameter[3][@type='java.lang.String']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;Ljava/lang/String;)Lorg/eclipse/jgit/transport/Transport;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Lib.Repository local, global::Org.Eclipse.Jgit.Transport.URIish uri, string remoteName)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/URIish;Ljava/lang/String;)Lorg/eclipse/jgit/transport/Transport;";
			IntPtr native_remoteName = JNIEnv.NewString ((string)remoteName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native_remoteName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remoteName);
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (uri);
			}
		}

		/// <param name="uri">uri</param>
		/// <summary>Open a new transport with no local repository.</summary>
		/// <returns>new Transport instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='open' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register ("open", "(Lorg/eclipse/jgit/transport/URIish;)Lorg/eclipse/jgit/transport/Transport;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Transport.URIish uri)
		{
			const string __id = "open.(Lorg/eclipse/jgit/transport/URIish;)Lorg/eclipse/jgit/transport/Transport;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		/// <param name="local">existing local repository.</param>
		/// <param name="remote">location of the remote repository - may be URI or remote
		///            configuration name.</param>
		/// <summary>Open new transport instances to connect two repositories.</summary>
		/// <returns>the list of new transport instances for every URI in remote
		///         configuration.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openAll' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String']]"
		[Register ("openAll", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.Transport> OpenAll (global::Org.Eclipse.Jgit.Lib.Repository local, string remote)
		{
			const string __id = "openAll.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_remote = JNIEnv.NewString ((string)remote);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue (native_remote);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.Transport>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remote);
				global::System.GC.KeepAlive (local);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openAll' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.transport.Transport.Operation']]"
		[Register ("openAll", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/transport/Transport$Operation;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.Transport> OpenAll (global::Org.Eclipse.Jgit.Lib.Repository local, string remote, global::Org.Eclipse.Jgit.Transport.Transport.Operation op)
		{
			const string __id = "openAll.(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/transport/Transport$Operation;)Ljava/util/List;";
			IntPtr native_remote = JNIEnv.NewString ((string)remote);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue (native_remote);
				__args [2] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.Transport>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remote);
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (op);
			}
		}

		/// <param name="local">existing local repository.</param>
		/// <param name="cfg">configuration describing how to connect to the remote
		///            repository.</param>
		/// <summary>Open new transport instances to connect two repositories.</summary>
		/// <returns>the list of new transport instances for every URI in remote
		///         configuration.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openAll' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.RemoteConfig']]"
		[Register ("openAll", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/RemoteConfig;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.Transport> OpenAll (global::Org.Eclipse.Jgit.Lib.Repository local, global::Org.Eclipse.Jgit.Transport.RemoteConfig cfg)
		{
			const string __id = "openAll.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/RemoteConfig;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.Transport>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (cfg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openAll' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.transport.RemoteConfig'] and parameter[3][@type='org.eclipse.jgit.transport.Transport.Operation']]"
		[Register ("openAll", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/RemoteConfig;Lorg/eclipse/jgit/transport/Transport$Operation;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.Transport> OpenAll (global::Org.Eclipse.Jgit.Lib.Repository local, global::Org.Eclipse.Jgit.Transport.RemoteConfig cfg, global::Org.Eclipse.Jgit.Transport.Transport.Operation op)
		{
			const string __id = "openAll.(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/transport/RemoteConfig;Lorg/eclipse/jgit/transport/Transport$Operation;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [1] = new JniArgumentValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				__args [2] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.Transport>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (local);
				global::System.GC.KeepAlive (cfg);
				global::System.GC.KeepAlive (op);
			}
		}

		static Delegate cb_openFetch;
#pragma warning disable 0169
		static Delegate GetOpenFetchHandler ()
		{
			if (cb_openFetch == null)
				cb_openFetch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenFetch);
			return cb_openFetch;
		}

		static IntPtr n_OpenFetch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenFetch ());
		}
#pragma warning restore 0169

		/// <summary>Begins a new connection for fetching from the remote repository.</summary>
		/// <returns>a fresh connection to fetch from the remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openFetch' and count(parameter)=0]"
		[Register ("openFetch", "()Lorg/eclipse/jgit/transport/FetchConnection;", "GetOpenFetchHandler")]
		public abstract global::Org.Eclipse.Jgit.Transport.IFetchConnection OpenFetch ();

		static Delegate cb_openPush;
#pragma warning disable 0169
		static Delegate GetOpenPushHandler ()
		{
			if (cb_openPush == null)
				cb_openPush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenPush);
			return cb_openPush;
		}

		static IntPtr n_OpenPush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenPush ());
		}
#pragma warning restore 0169

		/// <summary>Begins a new connection for pushing into the remote repository.</summary>
		/// <returns>a fresh connection to push into the remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openPush' and count(parameter)=0]"
		[Register ("openPush", "()Lorg/eclipse/jgit/transport/PushConnection;", "GetOpenPushHandler")]
		public abstract global::Org.Eclipse.Jgit.Transport.IPushConnection OpenPush ();

		static Delegate cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Handler ()
		{
			if (cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_ == null)
				cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_);
			return cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_;
		}

		static IntPtr n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_toPush)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var toPush = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (native_toPush, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Push (monitor, toPush));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">progress monitor to inform the user about our processing
		///            activity. Must not be null. Use <c>NullProgressMonitor</c> if
		///            progress updates are not interesting or necessary.</param>
		/// <param name="toPush">specification of refs to push. May be null or the empty
		///            collection to use the specifications from the RemoteConfig
		///            converted by <c>#findRemoteRefUpdatesFor(Collection)</c>. No
		///            more than 1 RemoteRefUpdate with the same remoteName is
		///            allowed. These objects are modified during this call.</param>
		/// <summary>Push objects and refs from the local repository to the remote one.</summary>
		/// <returns>information about results of remote refs updates, tracking refs
		///         updates and refs advertised by remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='push' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.transport.RemoteRefUpdate&gt;']]"
		[Register ("push", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;)Lorg/eclipse/jgit/transport/PushResult;", "GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.PushResult Push (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> toPush)
		{
			const string __id = "push.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;)Lorg/eclipse/jgit/transport/PushResult;";
			IntPtr native_toPush = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.ToLocalJniHandle (toPush);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_toPush);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PushResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_toPush);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (toPush);
			}
		}

		static Delegate cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_io_OutputStream_Handler ()
		{
			if (cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_io_OutputStream_ == null)
				cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_io_OutputStream_);
			return cb_push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_io_OutputStream_;
		}

		static IntPtr n_Push_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, IntPtr native_toPush, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var toPush = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.FromJniHandle (native_toPush, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Push (monitor, toPush, @out));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">progress monitor to inform the user about our processing
		///            activity. Must not be null. Use <c>NullProgressMonitor</c> if
		///            progress updates are not interesting or necessary.</param>
		/// <param name="toPush">specification of refs to push. May be null or the empty
		///            collection to use the specifications from the RemoteConfig
		///            converted by <c>#findRemoteRefUpdatesFor(Collection)</c>. No
		///            more than 1 RemoteRefUpdate with the same remoteName is
		///            allowed. These objects are modified during this call.</param>
		/// <param name="out">output stream to write messages to</param>
		/// <summary>Push objects and refs from the local repository to the remote one.</summary>
		/// <returns>information about results of remote refs updates, tracking refs
		///         updates and refs advertised by remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='push' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.transport.RemoteRefUpdate&gt;'] and parameter[3][@type='java.io.OutputStream']]"
		[Register ("push", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/io/OutputStream;)Lorg/eclipse/jgit/transport/PushResult;", "GetPush_Lorg_eclipse_jgit_lib_ProgressMonitor_Ljava_util_Collection_Ljava_io_OutputStream_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.PushResult Push (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> toPush, global::System.IO.Stream @out)
		{
			const string __id = "push.(Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/util/Collection;Ljava/io/OutputStream;)Lorg/eclipse/jgit/transport/PushResult;";
			IntPtr native_toPush = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate>.ToLocalJniHandle (toPush);
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (native_toPush);
				__args [2] = new JniArgumentValue (native__out);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PushResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_toPush);
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (toPush);
				global::System.GC.KeepAlive (@out);
			}
		}

		/// <param name="proto">the protocol definition. Must not be null.</param>
		/// <summary>Register a TransportProtocol instance for use during open.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='register' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.TransportProtocol']]"
		[Register ("register", "(Lorg/eclipse/jgit/transport/TransportProtocol;)V", "")]
		public static unsafe void Register (global::Org.Eclipse.Jgit.Transport.TransportProtocol proto)
		{
			const string __id = "register.(Lorg/eclipse/jgit/transport/TransportProtocol;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((proto == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proto).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (proto);
			}
		}

		/// <param name="proto">the exact object previously given to register.</param>
		/// <summary>Unregister a TransportProtocol instance.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.TransportProtocol']]"
		[Register ("unregister", "(Lorg/eclipse/jgit/transport/TransportProtocol;)V", "")]
		public static unsafe void Unregister (global::Org.Eclipse.Jgit.Transport.TransportProtocol proto)
		{
			const string __id = "unregister.(Lorg/eclipse/jgit/transport/TransportProtocol;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((proto == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proto).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (proto);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/Transport", DoNotGenerateAcw=true)]
	internal partial class TransportInvoker : Transport {
		public TransportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/Transport", typeof (TransportInvoker));

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

		/// <summary>Close any resources used by this transport.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <summary>Begins a new connection for fetching from the remote repository.</summary>
		/// <returns>a fresh connection to fetch from the remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openFetch' and count(parameter)=0]"
		[Register ("openFetch", "()Lorg/eclipse/jgit/transport/FetchConnection;", "GetOpenFetchHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IFetchConnection OpenFetch ()
		{
			const string __id = "openFetch.()Lorg/eclipse/jgit/transport/FetchConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IFetchConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Begins a new connection for pushing into the remote repository.</summary>
		/// <returns>a fresh connection to push into the remote repository.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='Transport']/method[@name='openPush' and count(parameter)=0]"
		[Register ("openPush", "()Lorg/eclipse/jgit/transport/PushConnection;", "GetOpenPushHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.IPushConnection OpenPush ()
		{
			const string __id = "openPush.()Lorg/eclipse/jgit/transport/PushConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPushConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
