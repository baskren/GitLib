using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Describes a way to connect to another Git repository.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TransportProtocol", DoNotGenerateAcw=true)]
	public abstract partial class TransportProtocol : global::Java.Lang.Object {
		/// <summary>Fields within a <c>URIish</c> that a transport uses.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol.URIishField']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TransportProtocol$URIishField", DoNotGenerateAcw=true)]
		public sealed partial class URIishField : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol.URIishField']/field[@name='HOST']"
			[Register ("HOST")]
			public static global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField Host {
				get {
					const string __id = "HOST.Lorg/eclipse/jgit/transport/TransportProtocol$URIishField;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol.URIishField']/field[@name='PASS']"
			[Register ("PASS")]
			public static global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField Pass {
				get {
					const string __id = "PASS.Lorg/eclipse/jgit/transport/TransportProtocol$URIishField;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol.URIishField']/field[@name='PATH']"
			[Register ("PATH")]
			public static global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField Path {
				get {
					const string __id = "PATH.Lorg/eclipse/jgit/transport/TransportProtocol$URIishField;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol.URIishField']/field[@name='PORT']"
			[Register ("PORT")]
			public static global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField Port {
				get {
					const string __id = "PORT.Lorg/eclipse/jgit/transport/TransportProtocol$URIishField;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol.URIishField']/field[@name='USER']"
			[Register ("USER")]
			public static global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField User {
				get {
					const string __id = "USER.Lorg/eclipse/jgit/transport/TransportProtocol$URIishField;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TransportProtocol$URIishField", typeof (URIishField));

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

			internal URIishField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol.URIishField']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/TransportProtocol$URIishField;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/TransportProtocol$URIishField;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol.URIishField']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/transport/TransportProtocol$URIishField;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/transport/TransportProtocol$URIishField;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TransportProtocol", typeof (TransportProtocol));

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

		protected TransportProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/constructor[@name='TransportProtocol' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransportProtocol () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getDefaultPort;
#pragma warning disable 0169
		static Delegate GetGetDefaultPortHandler ()
		{
			if (cb_getDefaultPort == null)
				cb_getDefaultPort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDefaultPort);
			return cb_getDefaultPort;
		}

		static int n_GetDefaultPort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultPort;
		}
#pragma warning restore 0169

		/// <returns>if a port is supported, the default port, else -1.</returns>
		public virtual unsafe int DefaultPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='getDefaultPort' and count(parameter)=0]"
			[Register ("getDefaultPort", "()I", "GetGetDefaultPortHandler")]
			get {
				const string __id = "getDefaultPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get; 
		}

		static Delegate cb_getOptionalFields;
#pragma warning disable 0169
		static Delegate GetGetOptionalFieldsHandler ()
		{
			if (cb_getOptionalFields == null)
				cb_getOptionalFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOptionalFields);
			return cb_getOptionalFields;
		}

		static IntPtr n_GetOptionalFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField>.ToLocalJniHandle (__this.OptionalFields);
		}
#pragma warning restore 0169

		/// <returns>immutable set of URIishFields that may be filled in.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField> OptionalFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='getOptionalFields' and count(parameter)=0]"
			[Register ("getOptionalFields", "()Ljava/util/Set;", "GetGetOptionalFieldsHandler")]
			get {
				const string __id = "getOptionalFields.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequiredFields;
#pragma warning disable 0169
		static Delegate GetGetRequiredFieldsHandler ()
		{
			if (cb_getRequiredFields == null)
				cb_getRequiredFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequiredFields);
			return cb_getRequiredFields;
		}

		static IntPtr n_GetRequiredFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField>.ToLocalJniHandle (__this.RequiredFields);
		}
#pragma warning restore 0169

		/// <returns>immutable set of URIishFields that must be filled in.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField> RequiredFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='getRequiredFields' and count(parameter)=0]"
			[Register ("getRequiredFields", "()Ljava/util/Set;", "GetGetRequiredFieldsHandler")]
			get {
				const string __id = "getRequiredFields.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Transport.TransportProtocol.URIishField>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSchemes;
#pragma warning disable 0169
		static Delegate GetGetSchemesHandler ()
		{
			if (cb_getSchemes == null)
				cb_getSchemes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSchemes);
			return cb_getSchemes;
		}

		static IntPtr n_GetSchemes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Schemes);
		}
#pragma warning restore 0169

		/// <returns>immutable set of schemes supported by this protocol.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Schemes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='getSchemes' and count(parameter)=0]"
			[Register ("getSchemes", "()Ljava/util/Set;", "GetGetSchemesHandler")]
			get {
				const string __id = "getSchemes.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canHandle_Lorg_eclipse_jgit_transport_URIish_;
#pragma warning disable 0169
		static Delegate GetCanHandle_Lorg_eclipse_jgit_transport_URIish_Handler ()
		{
			if (cb_canHandle_Lorg_eclipse_jgit_transport_URIish_ == null)
				cb_canHandle_Lorg_eclipse_jgit_transport_URIish_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanHandle_Lorg_eclipse_jgit_transport_URIish_);
			return cb_canHandle_Lorg_eclipse_jgit_transport_URIish_;
		}

		static bool n_CanHandle_Lorg_eclipse_jgit_transport_URIish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanHandle (uri);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uri">address of the Git repository; never null.</param>
		/// <summary>Determine if this protocol can handle a particular URI.</summary>
		/// <returns>true if this protocol can handle this URI; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='canHandle' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register ("canHandle", "(Lorg/eclipse/jgit/transport/URIish;)Z", "GetCanHandle_Lorg_eclipse_jgit_transport_URIish_Handler")]
		public virtual unsafe bool CanHandle (global::Org.Eclipse.Jgit.Transport.URIish uri)
		{
			const string __id = "canHandle.(Lorg/eclipse/jgit/transport/URIish;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		static Delegate cb_canHandle_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCanHandle_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Handler ()
		{
			if (cb_canHandle_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_ == null)
				cb_canHandle_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_CanHandle_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_);
			return cb_canHandle_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_;
		}

		static bool n_CanHandle_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_local, IntPtr native_remoteName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			var local = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_local, JniHandleOwnership.DoNotTransfer);
			var remoteName = JNIEnv.GetString (native_remoteName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanHandle (uri, local, remoteName);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uri">address of the Git repository; never null.</param>
		/// <param name="local">the local repository that will communicate with the other Git
		///            repository. May be null if the caller is only asking about a
		///            specific URI and does not have a local Repository.</param>
		/// <param name="remoteName">name of the remote, if the remote as configured in
		///            <c>local</c>; otherwise null.</param>
		/// <summary>Determine if this protocol can handle a particular URI.</summary>
		/// <returns>true if this protocol can handle this URI; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='canHandle' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.lib.Repository'] and parameter[3][@type='java.lang.String']]"
		[Register ("canHandle", "(Lorg/eclipse/jgit/transport/URIish;Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Z", "GetCanHandle_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Handler")]
		public virtual unsafe bool CanHandle (global::Org.Eclipse.Jgit.Transport.URIish uri, global::Org.Eclipse.Jgit.Lib.Repository local, string remoteName)
		{
			const string __id = "canHandle.(Lorg/eclipse/jgit/transport/URIish;Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Z";
			IntPtr native_remoteName = JNIEnv.NewString ((string)remoteName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [2] = new JniArgumentValue (native_remoteName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_remoteName);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (local);
			}
		}

		static Delegate cb_open_Lorg_eclipse_jgit_transport_URIish_;
#pragma warning disable 0169
		static Delegate GetOpen_Lorg_eclipse_jgit_transport_URIish_Handler ()
		{
			if (cb_open_Lorg_eclipse_jgit_transport_URIish_ == null)
				cb_open_Lorg_eclipse_jgit_transport_URIish_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Open_Lorg_eclipse_jgit_transport_URIish_);
			return cb_open_Lorg_eclipse_jgit_transport_URIish_;
		}

		static IntPtr n_Open_Lorg_eclipse_jgit_transport_URIish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (uri));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uri">uri</param>
		/// <summary>Open a new transport instance to the remote repository.</summary>
		/// <returns>new Transport</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='open' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.URIish']]"
		[Register ("open", "(Lorg/eclipse/jgit/transport/URIish;)Lorg/eclipse/jgit/transport/Transport;", "GetOpen_Lorg_eclipse_jgit_transport_URIish_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Transport.URIish uri)
		{
			const string __id = "open.(Lorg/eclipse/jgit/transport/URIish;)Lorg/eclipse/jgit/transport/Transport;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		static Delegate cb_open_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Handler ()
		{
			if (cb_open_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_ == null)
				cb_open_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Open_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_);
			return cb_open_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_;
		}

		static IntPtr n_Open_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_local, IntPtr native_remoteName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransportProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.URIish> (native_uri, JniHandleOwnership.DoNotTransfer);
			var local = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_local, JniHandleOwnership.DoNotTransfer);
			var remoteName = JNIEnv.GetString (native_remoteName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (uri, local, remoteName));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="uri">address of the Git repository.</param>
		/// <param name="local">the local repository that will communicate with the other Git
		///            repository.</param>
		/// <param name="remoteName">name of the remote, if the remote as configured in
		///            <c>local</c>; otherwise null.</param>
		/// <summary>Open a Transport instance to the other repository.</summary>
		/// <returns>the transport.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='open' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.lib.Repository'] and parameter[3][@type='java.lang.String']]"
		[Register ("open", "(Lorg/eclipse/jgit/transport/URIish;Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Lorg/eclipse/jgit/transport/Transport;", "GetOpen_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Handler")]
		public abstract global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Transport.URIish uri, global::Org.Eclipse.Jgit.Lib.Repository local, string remoteName);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TransportProtocol", DoNotGenerateAcw=true)]
	internal partial class TransportProtocolInvoker : TransportProtocol {
		public TransportProtocolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TransportProtocol", typeof (TransportProtocolInvoker));

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

		/// <returns>text name of the protocol suitable for display to a user.</returns>
		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='getName' and count(parameter)=0]"
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

		/// <param name="uri">address of the Git repository.</param>
		/// <param name="local">the local repository that will communicate with the other Git
		///            repository.</param>
		/// <param name="remoteName">name of the remote, if the remote as configured in
		///            <c>local</c>; otherwise null.</param>
		/// <summary>Open a Transport instance to the other repository.</summary>
		/// <returns>the transport.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TransportProtocol']/method[@name='open' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.URIish'] and parameter[2][@type='org.eclipse.jgit.lib.Repository'] and parameter[3][@type='java.lang.String']]"
		[Register ("open", "(Lorg/eclipse/jgit/transport/URIish;Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Lorg/eclipse/jgit/transport/Transport;", "GetOpen_Lorg_eclipse_jgit_transport_URIish_Lorg_eclipse_jgit_lib_Repository_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.Transport Open (global::Org.Eclipse.Jgit.Transport.URIish uri, global::Org.Eclipse.Jgit.Lib.Repository local, string remoteName)
		{
			const string __id = "open.(Lorg/eclipse/jgit/transport/URIish;Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;)Lorg/eclipse/jgit/transport/Transport;";
			IntPtr native_remoteName = JNIEnv.NewString ((string)remoteName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue ((local == null) ? IntPtr.Zero : ((global::Java.Lang.Object) local).Handle);
				__args [2] = new JniArgumentValue (native_remoteName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remoteName);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (local);
			}
		}

	}
}
