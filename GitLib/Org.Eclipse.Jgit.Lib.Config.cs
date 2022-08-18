using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Git style <c>.config</c>, <c>.gitconfig</c>, <c>.gitmodules</c> file.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Java.Lang.Object {
		/// <summary>Converts enumeration values into configuration options and vice-versa,
		/// allowing to match a config option with an enum value.</summary>
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Config.ConfigEnum']"
		[Register ("org/eclipse/jgit/lib/Config$ConfigEnum", "", "Org.Eclipse.Jgit.Lib.Config/IConfigEnumInvoker")]
		public partial interface IConfigEnum : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Config.ConfigEnum']/method[@name='matchConfigValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			/// <param name="in">the string to match</param>
			/// <summary>Checks if the given string matches with enum value.</summary>
			/// <returns>true if the given string matches enum value, false otherwise</returns>
			[Register ("matchConfigValue", "(Ljava/lang/String;)Z", "GetMatchConfigValue_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Lib.Config/IConfigEnumInvoker, AndroidBindableLibrary")]
			bool MatchConfigValue (string @in);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Config.ConfigEnum']/method[@name='toConfigValue' and count(parameter)=0]"
			/// <summary>Converts enumeration value into a string to be save in config.</summary>
			/// <returns>the enum value as config string</returns>
			[Register ("toConfigValue", "()Ljava/lang/String;", "GetToConfigValueHandler:Org.Eclipse.Jgit.Lib.Config/IConfigEnumInvoker, AndroidBindableLibrary")]
			string ToConfigValue ();

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/Config$ConfigEnum", DoNotGenerateAcw=true)]
		internal partial class IConfigEnumInvoker : global::Java.Lang.Object, IConfigEnum {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/Config$ConfigEnum", typeof (IConfigEnumInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IConfigEnum GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IConfigEnum> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.Config.ConfigEnum'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IConfigEnumInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_matchConfigValue_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetMatchConfigValue_Ljava_lang_String_Handler ()
			{
				if (cb_matchConfigValue_Ljava_lang_String_ == null)
					cb_matchConfigValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_MatchConfigValue_Ljava_lang_String_);
				return cb_matchConfigValue_Ljava_lang_String_;
			}

			static bool n_MatchConfigValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.IConfigEnum> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @in = JNIEnv.GetString (native__in, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.MatchConfigValue (@in);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_matchConfigValue_Ljava_lang_String_;
			public unsafe bool MatchConfigValue (string @in)
			{
				if (id_matchConfigValue_Ljava_lang_String_ == IntPtr.Zero)
					id_matchConfigValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "matchConfigValue", "(Ljava/lang/String;)Z");
				IntPtr native__in = JNIEnv.NewString ((string)@in);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__in);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matchConfigValue_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native__in);
				return __ret;
			}

			static Delegate cb_toConfigValue;
#pragma warning disable 0169
			static Delegate GetToConfigValueHandler ()
			{
				if (cb_toConfigValue == null)
					cb_toConfigValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToConfigValue);
				return cb_toConfigValue;
			}

			static IntPtr n_ToConfigValue (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.IConfigEnum> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToConfigValue ());
			}
#pragma warning restore 0169

			IntPtr id_toConfigValue;
			public unsafe string ToConfigValue ()
			{
				if (id_toConfigValue == IntPtr.Zero)
					id_toConfigValue = JNIEnv.GetMethodID (class_ref, "toConfigValue", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toConfigValue), JniHandleOwnership.TransferLocalRef);
			}

		}

		/// <param name="&lt;T&gt;">type of the application model created by the parser.</param>
		/// <summary>Parses a section of the configuration into an application model object.</summary>
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Config.SectionParser']"
		[Register ("org/eclipse/jgit/lib/Config$SectionParser", "", "Org.Eclipse.Jgit.Lib.Config/ISectionParserInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface ISectionParser : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='Config.SectionParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
			/// <param name="cfg">the configuration to read values from.</param>
			/// <summary>Create a model object from a configuration.</summary>
			/// <returns>the application model instance.</returns>
			[Register ("parse", "(Lorg/eclipse/jgit/lib/Config;)Ljava/lang/Object;", "GetParse_Lorg_eclipse_jgit_lib_Config_Handler:Org.Eclipse.Jgit.Lib.Config/ISectionParserInvoker, AndroidBindableLibrary")]
			global::Java.Lang.Object Parse (global::Org.Eclipse.Jgit.Lib.Config cfg);

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/Config$SectionParser", DoNotGenerateAcw=true)]
		internal partial class ISectionParserInvoker : global::Java.Lang.Object, ISectionParser {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/Config$SectionParser", typeof (ISectionParserInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ISectionParser GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISectionParser> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.Config.SectionParser'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISectionParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_parse_Lorg_eclipse_jgit_lib_Config_;
#pragma warning disable 0169
			static Delegate GetParse_Lorg_eclipse_jgit_lib_Config_Handler ()
			{
				if (cb_parse_Lorg_eclipse_jgit_lib_Config_ == null)
					cb_parse_Lorg_eclipse_jgit_lib_Config_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Parse_Lorg_eclipse_jgit_lib_Config_);
				return cb_parse_Lorg_eclipse_jgit_lib_Config_;
			}

			static IntPtr n_Parse_Lorg_eclipse_jgit_lib_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cfg)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.ISectionParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cfg = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (native_cfg, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (cfg));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_parse_Lorg_eclipse_jgit_lib_Config_;
			public unsafe global::Java.Lang.Object Parse (global::Org.Eclipse.Jgit.Lib.Config cfg)
			{
				if (id_parse_Lorg_eclipse_jgit_lib_Config_ == IntPtr.Zero)
					id_parse_Lorg_eclipse_jgit_lib_Config_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lorg/eclipse/jgit/lib/Config;)Ljava/lang/Object;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((cfg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cfg).Handle);
				var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lorg_eclipse_jgit_lib_Config_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/Config", typeof (Config));

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

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a configuration with no default fallback.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/constructor[@name='Config' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Config () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="defaultConfig">the base configuration to be consulted when a key is missing
		///            from this configuration instance.</param>
		/// <summary>Create an empty configuration with a fallback for missing keys.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/constructor[@name='Config' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Config;)V", "")]
		public unsafe Config (global::Org.Eclipse.Jgit.Lib.Config defaultConfig) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Config;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((defaultConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultConfig).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (defaultConfig);
			}
		}

		static Delegate cb_getSections;
#pragma warning disable 0169
		static Delegate GetGetSectionsHandler ()
		{
			if (cb_getSections == null)
				cb_getSections = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSections);
			return cb_getSections;
		}

		static IntPtr n_GetSections (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Sections);
		}
#pragma warning restore 0169

		/// <returns>the sections defined in this <c>Config</c>. The set's iterator
		///         returns sections in the order they are declared by the
		///         configuration starting from this instance and progressing through
		///         the base.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Sections {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getSections' and count(parameter)=0]"
			[Register ("getSections", "()Ljava/util/Set;", "GetGetSectionsHandler")]
			get {
				const string __id = "getSections.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addChangeListener_Lorg_eclipse_jgit_events_ConfigChangedListener_;
#pragma warning disable 0169
		static Delegate GetAddChangeListener_Lorg_eclipse_jgit_events_ConfigChangedListener_Handler ()
		{
			if (cb_addChangeListener_Lorg_eclipse_jgit_events_ConfigChangedListener_ == null)
				cb_addChangeListener_Lorg_eclipse_jgit_events_ConfigChangedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddChangeListener_Lorg_eclipse_jgit_events_ConfigChangedListener_);
			return cb_addChangeListener_Lorg_eclipse_jgit_events_ConfigChangedListener_;
		}

		static IntPtr n_AddChangeListener_Lorg_eclipse_jgit_events_ConfigChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Org.Eclipse.Jgit.Events.IConfigChangedListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.IConfigChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddChangeListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="listener">the listener</param>
		/// <summary>Adds a listener to be notified about changes.</summary>
		/// <returns>the handle to the registered listener</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='addChangeListener' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.events.ConfigChangedListener']]"
		[Register ("addChangeListener", "(Lorg/eclipse/jgit/events/ConfigChangedListener;)Lorg/eclipse/jgit/events/ListenerHandle;", "GetAddChangeListener_Lorg_eclipse_jgit_events_ConfigChangedListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Events.ListenerHandle AddChangeListener (global::Org.Eclipse.Jgit.Events.IConfigChangedListener listener)
		{
			const string __id = "addChangeListener.(Lorg/eclipse/jgit/events/ConfigChangedListener;)Lorg/eclipse/jgit/events/ListenerHandle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Events.ListenerHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		/// <summary>Clear the configuration file</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		protected virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fireConfigChangedEvent;
#pragma warning disable 0169
		static Delegate GetFireConfigChangedEventHandler ()
		{
			if (cb_fireConfigChangedEvent == null)
				cb_fireConfigChangedEvent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FireConfigChangedEvent);
			return cb_fireConfigChangedEvent;
		}

		static void n_FireConfigChangedEvent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FireConfigChangedEvent ();
		}
#pragma warning restore 0169

		/// <summary>Notifies the listeners</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='fireConfigChangedEvent' and count(parameter)=0]"
		[Register ("fireConfigChangedEvent", "()V", "GetFireConfigChangedEventHandler")]
		protected virtual unsafe void FireConfigChangedEvent ()
		{
			const string __id = "fireConfigChangedEvent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fromText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFromText_Ljava_lang_String_Handler ()
		{
			if (cb_fromText_Ljava_lang_String_ == null)
				cb_fromText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FromText_Ljava_lang_String_);
			return cb_fromText_Ljava_lang_String_;
		}

		static void n_FromText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.FromText (text);
		}
#pragma warning restore 0169

		/// <param name="text">Git style text file listing configuration properties.</param>
		/// <summary>Clear this configuration and reset to the contents of the parsed string.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='fromText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromText", "(Ljava/lang/String;)V", "GetFromText_Ljava_lang_String_Handler")]
		public virtual unsafe void FromText (string text)
		{
			const string __id = "fromText.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString ((string)text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_get_Lorg_eclipse_jgit_lib_Config_SectionParser_;
#pragma warning disable 0169
		static Delegate GetGet_Lorg_eclipse_jgit_lib_Config_SectionParser_Handler ()
		{
			if (cb_get_Lorg_eclipse_jgit_lib_Config_SectionParser_ == null)
				cb_get_Lorg_eclipse_jgit_lib_Config_SectionParser_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Lorg_eclipse_jgit_lib_Config_SectionParser_);
			return cb_get_Lorg_eclipse_jgit_lib_Config_SectionParser_;
		}

		static IntPtr n_Get_Lorg_eclipse_jgit_lib_Config_SectionParser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parser)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parser = (global::Org.Eclipse.Jgit.Lib.Config.ISectionParser)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.ISectionParser> (native_parser, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (parser));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='get' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config.SectionParser&lt;T&gt;']]"
		[Register ("get", "(Lorg/eclipse/jgit/lib/Config$SectionParser;)Ljava/lang/Object;", "GetGet_Lorg_eclipse_jgit_lib_Config_SectionParser_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object Get (global::Org.Eclipse.Jgit.Lib.Config.ISectionParser parser)
		{
			const string __id = "get.(Lorg/eclipse/jgit/lib/Config$SectionParser;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parser);
			}
		}

		static Delegate cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_Z) n_GetBoolean_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_name, bool defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (section, name, defaultValue);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">section the key is grouped within.</param>
		/// <param name="name">name of the key to get.</param>
		/// <param name="defaultValue">default value to return if no value was present.</param>
		/// <summary>Get a boolean value from the git config</summary>
		/// <returns>true if any value or defaultValue is true, false for missing or
		///         explicit false</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getBoolean' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool GetBoolean (string section, string name, bool defaultValue)
		{
			const string __id = "getBoolean.(Ljava/lang/String;Ljava/lang/String;Z)Z";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_Z) n_GetBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, bool defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (section, subsection, name, defaultValue);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">section the key is grouped within.</param>
		/// <param name="subsection">subsection name, such a remote or branch name.</param>
		/// <param name="name">name of the key to get.</param>
		/// <param name="defaultValue">default value to return if no value was present.</param>
		/// <summary>Get a boolean value from the git config</summary>
		/// <returns>true if any value or defaultValue is true, false for missing or
		///         explicit false</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getBoolean' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool GetBoolean (string section, string subsection, string name, bool defaultValue)
		{
			const string __id = "getBoolean.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Z";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_;
#pragma warning disable 0169
		static Delegate GetGetEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_Handler ()
		{
			if (cb_getEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_ == null)
				cb_getEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_GetEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_);
			return cb_getEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_;
		}

		static IntPtr n_GetEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, IntPtr native_defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEnum (section, subsection, name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="&lt;T&gt;">type of the enumeration object.</param>
		/// <param name="section">section the key is grouped within.</param>
		/// <param name="subsection">subsection name, such a remote or branch name.</param>
		/// <param name="name">name of the key to get.</param>
		/// <param name="defaultValue">default value to return if no value was present.</param>
		/// <summary>Parse an enumeration from the configuration.</summary>
		/// <returns>the selected enumeration value, or <c>defaultValue</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getEnum' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='T']]"
		[Register ("getEnum", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Enum;)Ljava/lang/Enum;", "GetGetEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Enum<?>"})]
		public virtual unsafe global::Java.Lang.Object GetEnum (string section, string subsection, string name, global::Java.Lang.Object defaultValue)
		{
			const string __id = "getEnum.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Enum;)Ljava/lang/Enum;";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
				global::System.GC.KeepAlive (defaultValue);
			}
		}

		static Delegate cb_getEnum_arrayLjava_lang_Enum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_;
#pragma warning disable 0169
		static Delegate GetGetEnum_arrayLjava_lang_Enum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_Handler ()
		{
			if (cb_getEnum_arrayLjava_lang_Enum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_ == null)
				cb_getEnum_arrayLjava_lang_Enum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_L) n_GetEnum_arrayLjava_lang_Enum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_);
			return cb_getEnum_arrayLjava_lang_Enum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_;
		}

		static IntPtr n_GetEnum_arrayLjava_lang_Enum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_all, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, IntPtr native_defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var all = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_all, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEnum (all, section, subsection, name, defaultValue));
			if (all != null)
				JNIEnv.CopyArray (all, native_all);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="&lt;T&gt;">type of the enumeration object.</param>
		/// <param name="all">all possible values in the enumeration which should be
		///            recognized. Typically <c>EnumType.values()</c>.</param>
		/// <param name="section">section the key is grouped within.</param>
		/// <param name="subsection">subsection name, such a remote or branch name.</param>
		/// <param name="name">name of the key to get.</param>
		/// <param name="defaultValue">default value to return if no value was present.</param>
		/// <summary>Parse an enumeration from the configuration.</summary>
		/// <returns>the selected enumeration value, or <c>defaultValue</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getEnum' and count(parameter)=5 and parameter[1][@type='T[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='T']]"
		[Register ("getEnum", "([Ljava/lang/Enum;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Enum;)Ljava/lang/Enum;", "GetGetEnum_arrayLjava_lang_Enum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Enum<?>"})]
		public virtual unsafe global::Java.Lang.Object GetEnum (global::Java.Lang.Object[] all, string section, string subsection, string name, global::Java.Lang.Object defaultValue)
		{
			const string __id = "getEnum.([Ljava/lang/Enum;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Enum;)Ljava/lang/Enum;";
			IntPtr native_all = JNIEnv.NewArray (all);
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_all);
				__args [1] = new JniArgumentValue (native_section);
				__args [2] = new JniArgumentValue (native_subsection);
				__args [3] = new JniArgumentValue (native_name);
				__args [4] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (all != null) {
					JNIEnv.CopyArray (native_all, all);
					JNIEnv.DeleteLocalRef (native_all);
				}
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
				global::System.GC.KeepAlive (all);
				global::System.GC.KeepAlive (defaultValue);
			}
		}

		static Delegate cb_getInt_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_getInt_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_I) n_GetInt_Ljava_lang_String_Ljava_lang_String_I);
			return cb_getInt_Ljava_lang_String_Ljava_lang_String_I;
		}

		static int n_GetInt_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_name, int defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (section, name, defaultValue);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">section the key is grouped within.</param>
		/// <param name="name">name of the key to get.</param>
		/// <param name="defaultValue">default value to return if no value was present.</param>
		/// <summary>Obtain an integer value from the configuration.</summary>
		/// <returns>an integer value from the configuration, or defaultValue.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getInt' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;Ljava/lang/String;I)I", "GetGetInt_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe int GetInt (string section, string name, int defaultValue)
		{
			const string __id = "getInt.(Ljava/lang/String;Ljava/lang/String;I)I";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_getInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLI_I) n_GetInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I);
			return cb_getInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		}

		static int n_GetInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, int defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (section, subsection, name, defaultValue);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">section the key is grouped within.</param>
		/// <param name="subsection">subsection name, such a remote or branch name.</param>
		/// <param name="name">name of the key to get.</param>
		/// <param name="defaultValue">default value to return if no value was present.</param>
		/// <summary>Obtain an integer value from the configuration.</summary>
		/// <returns>an integer value from the configuration, or defaultValue.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getInt' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)I", "GetGetInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe int GetInt (string section, string subsection, string name, int defaultValue)
		{
			const string __id = "getInt.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)I";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_getLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_getLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLJ_J) n_GetLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J);
			return cb_getLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		}

		static long n_GetLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, long defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (section, subsection, name, defaultValue);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">section the key is grouped within.</param>
		/// <param name="subsection">subsection name, such a remote or branch name.</param>
		/// <param name="name">name of the key to get.</param>
		/// <param name="defaultValue">default value to return if no value was present.</param>
		/// <summary>Obtain an integer value from the configuration.</summary>
		/// <returns>an integer value from the configuration, or defaultValue.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getLong' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("getLong", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)J", "GetGetLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe long GetLong (string section, string subsection, string name, long defaultValue)
		{
			const string __id = "getLong.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)J";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getLong_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_getLong_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_getLong_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_J) n_GetLong_Ljava_lang_String_Ljava_lang_String_J);
			return cb_getLong_Ljava_lang_String_Ljava_lang_String_J;
		}

		static long n_GetLong_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_name, long defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (section, name, defaultValue);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">section the key is grouped within.</param>
		/// <param name="name">name of the key to get.</param>
		/// <param name="defaultValue">default value to return if no value was present.</param>
		/// <summary>Obtain an integer value from the configuration.</summary>
		/// <returns>an integer value from the configuration, or defaultValue.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getLong' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("getLong", "(Ljava/lang/String;Ljava/lang/String;J)J", "GetGetLong_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe long GetLong (string section, string name, long defaultValue)
		{
			const string __id = "getLong.(Ljava/lang/String;Ljava/lang/String;J)J";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getNames_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNames_Ljava_lang_String_Handler ()
		{
			if (cb_getNames_Ljava_lang_String_ == null)
				cb_getNames_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetNames_Ljava_lang_String_);
			return cb_getNames_Ljava_lang_String_;
		}

		static IntPtr n_GetNames_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetNames (section));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">the section</param>
		/// <returns>the list of names defined for this section</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getNames' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNames", "(Ljava/lang/String;)Ljava/util/Set;", "GetGetNames_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> GetNames (string section)
		{
			const string __id = "getNames.(Ljava/lang/String;)Ljava/util/Set;";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_section);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
			}
		}

		static Delegate cb_getNames_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetNames_Ljava_lang_String_ZHandler ()
		{
			if (cb_getNames_Ljava_lang_String_Z == null)
				cb_getNames_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_GetNames_Ljava_lang_String_Z);
			return cb_getNames_Ljava_lang_String_Z;
		}

		static IntPtr n_GetNames_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_section, bool recursive)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetNames (section, recursive));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">the section</param>
		/// <param name="recursive">if <c>true</c> recursively adds the names defined in all base
		///            configurations</param>
		/// <returns>the list of names defined for this section</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getNames' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getNames", "(Ljava/lang/String;Z)Ljava/util/Set;", "GetGetNames_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> GetNames (string section, bool recursive)
		{
			const string __id = "getNames.(Ljava/lang/String;Z)Ljava/util/Set;";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (recursive);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
			}
		}

		static Delegate cb_getNames_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNames_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getNames_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getNames_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetNames_Ljava_lang_String_Ljava_lang_String_);
			return cb_getNames_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetNames_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetNames (section, subsection));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">the section</param>
		/// <param name="subsection">the subsection</param>
		/// <returns>the list of names defined for this subsection</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getNames' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getNames", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/Set;", "GetGetNames_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> GetNames (string section, string subsection)
		{
			const string __id = "getNames.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/Set;";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
			}
		}

		static Delegate cb_getNames_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetNames_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_getNames_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_getNames_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_GetNames_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_getNames_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static IntPtr n_GetNames_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, bool recursive)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetNames (section, subsection, recursive));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">the section</param>
		/// <param name="subsection">the subsection</param>
		/// <param name="recursive">if <c>true</c> recursively adds the names defined in all base
		///            configurations</param>
		/// <returns>the list of names defined for this subsection</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getNames' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getNames", "(Ljava/lang/String;Ljava/lang/String;Z)Ljava/util/Set;", "GetGetNames_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> GetNames (string section, string subsection, bool recursive)
		{
			const string __id = "getNames.(Ljava/lang/String;Ljava/lang/String;Z)Ljava/util/Set;";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (recursive);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
			}
		}

		static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (section, subsection, name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">the section</param>
		/// <param name="subsection">the subsection for the value</param>
		/// <param name="name">the key name</param>
		/// <summary>Get string value or null if not found.</summary>
		/// <returns>a String value from the config, &lt;code&gt;null&lt;/code&gt; if not found</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string section, string subsection, string name)
		{
			const string __id = "getString.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetStringList (section, subsection, name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">the section</param>
		/// <param name="subsection">the subsection for the value</param>
		/// <param name="name">the key name</param>
		/// <summary>Get a list of string values</summary>
		/// <returns>array of zero or more values from the configuration.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getStringList' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getStringList", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "GetGetStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string[] GetStringList (string section, string subsection, string name)
		{
			const string __id = "getStringList.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getSubsections_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSubsections_Ljava_lang_String_Handler ()
		{
			if (cb_getSubsections_Ljava_lang_String_ == null)
				cb_getSubsections_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetSubsections_Ljava_lang_String_);
			return cb_getSubsections_Ljava_lang_String_;
		}

		static IntPtr n_GetSubsections_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetSubsections (section));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="section">section to search for.</param>
		/// <returns>set of all subsections of specified section within this
		///         configuration and its base configuration; may be empty if no
		///         subsection exists. The set's iterator returns sections in the
		///         order they are declared by the configuration starting from this
		///         instance and progressing through the base.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='getSubsections' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSubsections", "(Ljava/lang/String;)Ljava/util/Set;", "GetGetSubsections_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> GetSubsections (string section)
		{
			const string __id = "getSubsections.(Ljava/lang/String;)Ljava/util/Set;";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_section);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
			}
		}

		static Delegate cb_notifyUponTransientChanges;
#pragma warning disable 0169
		static Delegate GetNotifyUponTransientChangesHandler ()
		{
			if (cb_notifyUponTransientChanges == null)
				cb_notifyUponTransientChanges = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_NotifyUponTransientChanges);
			return cb_notifyUponTransientChanges;
		}

		static bool n_NotifyUponTransientChanges (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotifyUponTransientChanges ();
		}
#pragma warning restore 0169

		/// <summary>Determine whether to issue change events for transient changes.</summary>
		/// <returns>&lt;code&gt;&lt;/code&gt;</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='notifyUponTransientChanges' and count(parameter)=0]"
		[Register ("notifyUponTransientChanges", "()Z", "GetNotifyUponTransientChangesHandler")]
		protected virtual unsafe bool NotifyUponTransientChanges ()
		{
			const string __id = "notifyUponTransientChanges.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_setBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_setBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_SetBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_setBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_SetBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.SetBoolean (section, subsection, name, value);
		}
#pragma warning restore 0169

		/// <param name="section">section name, e.g "branch"</param>
		/// <param name="subsection">optional subsection value, e.g. a branch name</param>
		/// <param name="name">parameter name, e.g. "filemode"</param>
		/// <param name="value">parameter value</param>
		/// <summary>Add or modify a configuration value.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='setBoolean' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("setBoolean", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "GetSetBoolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SetBoolean (string section, string subsection, string name, bool value)
		{
			const string __id = "setBoolean.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_;
#pragma warning disable 0169
		static Delegate GetSetEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_Handler ()
		{
			if (cb_setEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_ == null)
				cb_setEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_SetEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_);
			return cb_setEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_;
		}

		static void n_SetEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetEnum (section, subsection, name, value);
		}
#pragma warning restore 0169

		/// <param name="&lt;T&gt;">type of the enumeration object.</param>
		/// <param name="section">section name, e.g "branch"</param>
		/// <param name="subsection">optional subsection value, e.g. a branch name</param>
		/// <param name="name">parameter name, e.g. "filemode"</param>
		/// <param name="value">parameter value</param>
		/// <summary>Add or modify a configuration value.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='setEnum' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='T']]"
		[Register ("setEnum", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Enum;)V", "GetSetEnum_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Enum_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Enum<?>"})]
		public virtual unsafe void SetEnum (string section, string subsection, string name, global::Java.Lang.Object value)
		{
			const string __id = "setEnum.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Enum;)V";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (value);
			}
		}

		static Delegate cb_setInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_setInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_setInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLI_V) n_SetInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I);
			return cb_setInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_SetInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.SetInt (section, subsection, name, value);
		}
#pragma warning restore 0169

		/// <param name="section">section name, e.g "branch"</param>
		/// <param name="subsection">optional subsection value, e.g. a branch name</param>
		/// <param name="name">parameter name, e.g. "filemode"</param>
		/// <param name="value">parameter value</param>
		/// <summary>Add or modify a configuration value.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='setInt' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("setInt", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "GetSetInt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetInt (string section, string subsection, string name, int value)
		{
			const string __id = "setInt.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSetLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_setLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_setLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLJ_V) n_SetLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J);
			return cb_setLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_SetLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.SetLong (section, subsection, name, value);
		}
#pragma warning restore 0169

		/// <param name="section">section name, e.g "branch"</param>
		/// <param name="subsection">optional subsection value, e.g. a branch name</param>
		/// <param name="name">parameter name, e.g. "filemode"</param>
		/// <param name="value">parameter value</param>
		/// <summary>Add or modify a configuration value.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='setLong' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("setLong", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "GetSetLong_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe void SetLong (string section, string subsection, string name, long value)
		{
			const string __id = "setLong.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_SetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetString (section, subsection, name, value);
		}
#pragma warning restore 0169

		/// <param name="section">section name, e.g "branch"</param>
		/// <param name="subsection">optional subsection value, e.g. a branch name</param>
		/// <param name="name">parameter name, e.g. "filemode"</param>
		/// <param name="value">parameter value, e.g. "true"</param>
		/// <summary>Add or modify a configuration value.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='setString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetString (string section, string subsection, string name, string value)
		{
			const string __id = "setString.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_value = JNIEnv.NewString ((string)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_setStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == null)
				cb_setStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_SetStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_);
			return cb_setStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_SetStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name, IntPtr native_values)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<string>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			__this.SetStringList (section, subsection, name, values);
		}
#pragma warning restore 0169

		/// <param name="section">section name, e.g "branch"</param>
		/// <param name="subsection">optional subsection value, e.g. a branch name</param>
		/// <param name="name">parameter name, e.g. "filemode"</param>
		/// <param name="values">list of zero or more values for this key.</param>
		/// <summary>Set a configuration value.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='setStringList' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setStringList", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "GetSetStringList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe void SetStringList (string section, string subsection, string name, global::System.Collections.Generic.IList<string> values)
		{
			const string __id = "setStringList.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_values = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (native_values);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_values);
				global::System.GC.KeepAlive (values);
			}
		}

		static Delegate cb_toText;
#pragma warning disable 0169
		static Delegate GetToTextHandler ()
		{
			if (cb_toText == null)
				cb_toText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToText);
			return cb_toText;
		}

		static IntPtr n_ToText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToText ());
		}
#pragma warning restore 0169

		/// <returns>this configuration, formatted as a Git style text file.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='toText' and count(parameter)=0]"
		[Register ("toText", "()Ljava/lang/String;", "GetToTextHandler")]
		public virtual unsafe string ToText ()
		{
			const string __id = "toText.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_uncache_Lorg_eclipse_jgit_lib_Config_SectionParser_;
#pragma warning disable 0169
		static Delegate GetUncache_Lorg_eclipse_jgit_lib_Config_SectionParser_Handler ()
		{
			if (cb_uncache_Lorg_eclipse_jgit_lib_Config_SectionParser_ == null)
				cb_uncache_Lorg_eclipse_jgit_lib_Config_SectionParser_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Uncache_Lorg_eclipse_jgit_lib_Config_SectionParser_);
			return cb_uncache_Lorg_eclipse_jgit_lib_Config_SectionParser_;
		}

		static void n_Uncache_Lorg_eclipse_jgit_lib_Config_SectionParser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parser)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parser = (global::Org.Eclipse.Jgit.Lib.Config.ISectionParser)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.ISectionParser> (native_parser, JniHandleOwnership.DoNotTransfer);
			__this.Uncache (parser);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='uncache' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Config.SectionParser&lt;?&gt;']]"
		[Register ("uncache", "(Lorg/eclipse/jgit/lib/Config$SectionParser;)V", "GetUncache_Lorg_eclipse_jgit_lib_Config_SectionParser_Handler")]
		public virtual unsafe void Uncache (global::Org.Eclipse.Jgit.Lib.Config.ISectionParser parser)
		{
			const string __id = "uncache.(Lorg/eclipse/jgit/lib/Config$SectionParser;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parser).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parser);
			}
		}

		static Delegate cb_unset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_unset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_unset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Unset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_unset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Unset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Unset (section, subsection, name);
		}
#pragma warning restore 0169

		/// <param name="section">section name, e.g "branch"</param>
		/// <param name="subsection">optional subsection value, e.g. a branch name</param>
		/// <param name="name">parameter name, e.g. "filemode"</param>
		/// <summary>Remove a configuration value.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='unset' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("unset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetUnset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Unset (string section, string subsection, string name)
		{
			const string __id = "unset.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				__args [2] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_unsetSection_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsetSection_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_unsetSection_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_unsetSection_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UnsetSection_Ljava_lang_String_Ljava_lang_String_);
			return cb_unsetSection_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UnsetSection_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_subsection)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var section = JNIEnv.GetString (native_section, JniHandleOwnership.DoNotTransfer);
			var subsection = JNIEnv.GetString (native_subsection, JniHandleOwnership.DoNotTransfer);
			__this.UnsetSection (section, subsection);
		}
#pragma warning restore 0169

		/// <param name="section">section name, e.g "branch"</param>
		/// <param name="subsection">optional subsection value, e.g. a branch name</param>
		/// <summary>Remove all configuration values under a single section.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Config']/method[@name='unsetSection' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("unsetSection", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUnsetSection_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UnsetSection (string section, string subsection)
		{
			const string __id = "unsetSection.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_section = JNIEnv.NewString ((string)section);
			IntPtr native_subsection = JNIEnv.NewString ((string)subsection);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_section);
				__args [1] = new JniArgumentValue (native_subsection);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_section);
				JNIEnv.DeleteLocalRef (native_subsection);
			}
		}

	}
}
