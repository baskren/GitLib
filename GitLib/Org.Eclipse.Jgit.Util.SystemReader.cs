using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>Interface to read values from the system.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/SystemReader", DoNotGenerateAcw=true)]
	public abstract partial class SystemReader : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/SystemReader", typeof (SystemReader));

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

		protected SystemReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/constructor[@name='SystemReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SystemReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCurrentTime;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimeHandler ()
		{
			if (cb_getCurrentTime == null)
				cb_getCurrentTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCurrentTime);
			return cb_getCurrentTime;
		}

		static long n_GetCurrentTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTime;
		}
#pragma warning restore 0169

		public abstract long CurrentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getCurrentTime' and count(parameter)=0]"
			[Register ("getCurrentTime", "()J", "GetGetCurrentTimeHandler")]
			get; 
		}

		static Delegate cb_getHostname;
#pragma warning disable 0169
		static Delegate GetGetHostnameHandler ()
		{
			if (cb_getHostname == null)
				cb_getHostname = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHostname);
			return cb_getHostname;
		}

		static IntPtr n_GetHostname (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Hostname);
		}
#pragma warning restore 0169

		public abstract string Hostname {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getHostname' and count(parameter)=0]"
			[Register ("getHostname", "()Ljava/lang/String;", "GetGetHostnameHandler")]
			get; 
		}

		/// <returns>the live instance to read system properties.</returns>
		/// <param name="newReader">the new instance to use when accessing properties, or null for
		///            the default instance.</param>
		public static unsafe global::Org.Eclipse.Jgit.Util.SystemReader Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/eclipse/jgit/util/SystemReader;", "")]
			get {
				const string __id = "getInstance.()Lorg/eclipse/jgit/util/SystemReader;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.SystemReader']]"
			[Register ("setInstance", "(Lorg/eclipse/jgit/util/SystemReader;)V", "")]
			set {
				const string __id = "setInstance.(Lorg/eclipse/jgit/util/SystemReader;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isMacOS;
#pragma warning disable 0169
		static Delegate GetIsMacOSHandler ()
		{
			if (cb_isMacOS == null)
				cb_isMacOS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMacOS);
			return cb_isMacOS;
		}

		static bool n_IsMacOS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMacOS;
		}
#pragma warning restore 0169

		/// <returns>true if we are running on Mac OS X</returns>
		public virtual unsafe bool IsMacOS {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='isMacOS' and count(parameter)=0]"
			[Register ("isMacOS", "()Z", "GetIsMacOSHandler")]
			get {
				const string __id = "isMacOS.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isWindows;
#pragma warning disable 0169
		static Delegate GetIsWindowsHandler ()
		{
			if (cb_isWindows == null)
				cb_isWindows = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsWindows);
			return cb_isWindows;
		}

		static bool n_IsWindows (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWindows;
		}
#pragma warning restore 0169

		/// <returns>true if we are running on a Windows.</returns>
		public virtual unsafe bool IsWindows {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='isWindows' and count(parameter)=0]"
			[Register ("isWindows", "()Z", "GetIsWindowsHandler")]
			get {
				const string __id = "isWindows.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLocale;
#pragma warning disable 0169
		static Delegate GetGetLocaleHandler ()
		{
			if (cb_getLocale == null)
				cb_getLocale = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocale);
			return cb_getLocale;
		}

		static IntPtr n_GetLocale (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Locale);
		}
#pragma warning restore 0169

		/// <returns>the locale to use</returns>
		public virtual unsafe global::Java.Util.Locale Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/util/Locale;", "GetGetLocaleHandler")]
			get {
				const string __id = "getLocale.()Ljava/util/Locale;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeZone;
#pragma warning disable 0169
		static Delegate GetGetTimeZoneHandler ()
		{
			if (cb_getTimeZone == null)
				cb_getTimeZone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTimeZone);
			return cb_getTimeZone;
		}

		static IntPtr n_GetTimeZone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeZone);
		}
#pragma warning restore 0169

		/// <returns>system time zone, possibly mocked for testing</returns>
		public virtual unsafe global::Java.Util.TimeZone TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/util/TimeZone;", "GetGetTimeZoneHandler")]
			get {
				const string __id = "getTimeZone.()Ljava/util/TimeZone;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckPath_Ljava_lang_String_Handler ()
		{
			if (cb_checkPath_Ljava_lang_String_ == null)
				cb_checkPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CheckPath_Ljava_lang_String_);
			return cb_checkPath_Ljava_lang_String_;
		}

		static void n_CheckPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.CheckPath (path);
		}
#pragma warning restore 0169

		/// <param name="path">path string to scan.</param>
		/// <summary>Check tree path entry for validity.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='checkPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkPath", "(Ljava/lang/String;)V", "GetCheckPath_Ljava_lang_String_Handler")]
		public virtual unsafe void CheckPath (string path)
		{
			const string __id = "checkPath.(Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_getDateTimeInstance_II;
#pragma warning disable 0169
		static Delegate GetGetDateTimeInstance_IIHandler ()
		{
			if (cb_getDateTimeInstance_II == null)
				cb_getDateTimeInstance_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_GetDateTimeInstance_II);
			return cb_getDateTimeInstance_II;
		}

		static IntPtr n_GetDateTimeInstance_II (IntPtr jnienv, IntPtr native__this, int dateStyle, int timeStyle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDateTimeInstance (dateStyle, timeStyle));
		}
#pragma warning restore 0169

		/// <param name="dateStyle">the date style as specified in
		///            <c>DateFormat#getDateTimeInstance(int, int)</c></param>
		/// <param name="timeStyle">the time style as specified in
		///            <c>DateFormat#getDateTimeInstance(int, int)</c></param>
		/// <summary>Returns a date/time format instance for the given styles.</summary>
		/// <returns>the date format</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getDateTimeInstance' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDateTimeInstance", "(II)Ljava/text/DateFormat;", "GetGetDateTimeInstance_IIHandler")]
		public virtual unsafe global::Java.Text.DateFormat GetDateTimeInstance (int dateStyle, int timeStyle)
		{
			const string __id = "getDateTimeInstance.(II)Ljava/text/DateFormat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dateStyle);
				__args [1] = new JniArgumentValue (timeStyle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Text.DateFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getProperty_Ljava_lang_String_ == null)
				cb_getProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetProperty_Ljava_lang_String_);
			return cb_getProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetProperty (key));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="key">of the system property to read</param>
		/// <returns>value of the system property</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetProperty_Ljava_lang_String_Handler")]
		public abstract string GetProperty (string key);

		static Delegate cb_getSimpleDateFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSimpleDateFormat_Ljava_lang_String_Handler ()
		{
			if (cb_getSimpleDateFormat_Ljava_lang_String_ == null)
				cb_getSimpleDateFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetSimpleDateFormat_Ljava_lang_String_);
			return cb_getSimpleDateFormat_Ljava_lang_String_;
		}

		static IntPtr n_GetSimpleDateFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pattern)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pattern = JNIEnv.GetString (native_pattern, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSimpleDateFormat (pattern));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pattern">the pattern as defined in
		///            <c>SimpleDateFormat#SimpleDateFormat(String)</c></param>
		/// <summary>Returns a simple date format instance as specified by the given pattern.</summary>
		/// <returns>the simple date format</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getSimpleDateFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSimpleDateFormat", "(Ljava/lang/String;)Ljava/text/SimpleDateFormat;", "GetGetSimpleDateFormat_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Text.SimpleDateFormat GetSimpleDateFormat (string pattern)
		{
			const string __id = "getSimpleDateFormat.(Ljava/lang/String;)Ljava/text/SimpleDateFormat;";
			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pattern);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static Delegate cb_getSimpleDateFormat_Ljava_lang_String_Ljava_util_Locale_;
#pragma warning disable 0169
		static Delegate GetGetSimpleDateFormat_Ljava_lang_String_Ljava_util_Locale_Handler ()
		{
			if (cb_getSimpleDateFormat_Ljava_lang_String_Ljava_util_Locale_ == null)
				cb_getSimpleDateFormat_Ljava_lang_String_Ljava_util_Locale_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetSimpleDateFormat_Ljava_lang_String_Ljava_util_Locale_);
			return cb_getSimpleDateFormat_Ljava_lang_String_Ljava_util_Locale_;
		}

		static IntPtr n_GetSimpleDateFormat_Ljava_lang_String_Ljava_util_Locale_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pattern, IntPtr native_locale)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pattern = JNIEnv.GetString (native_pattern, JniHandleOwnership.DoNotTransfer);
			var locale = global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (native_locale, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSimpleDateFormat (pattern, locale));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pattern">the pattern as defined in
		///            <c>SimpleDateFormat#SimpleDateFormat(String)</c></param>
		/// <param name="locale">locale to be used for the <c>SimpleDateFormat</c></param>
		/// <summary>Returns a simple date format instance as specified by the given pattern.</summary>
		/// <returns>the simple date format</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getSimpleDateFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Locale']]"
		[Register ("getSimpleDateFormat", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/text/SimpleDateFormat;", "GetGetSimpleDateFormat_Ljava_lang_String_Ljava_util_Locale_Handler")]
		public virtual unsafe global::Java.Text.SimpleDateFormat GetSimpleDateFormat (string pattern, global::Java.Util.Locale locale)
		{
			const string __id = "getSimpleDateFormat.(Ljava/lang/String;Ljava/util/Locale;)Ljava/text/SimpleDateFormat;";
			IntPtr native_pattern = JNIEnv.NewString ((string)pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_pattern);
				__args [1] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
				global::System.GC.KeepAlive (locale);
			}
		}

		static Delegate cb_getTimezone_J;
#pragma warning disable 0169
		static Delegate GetGetTimezone_JHandler ()
		{
			if (cb_getTimezone_J == null)
				cb_getTimezone_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_I) n_GetTimezone_J);
			return cb_getTimezone_J;
		}

		static int n_GetTimezone_J (IntPtr jnienv, IntPtr native__this, long when)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetTimezone (when);
		}
#pragma warning restore 0169

		/// <param name="when">TODO</param>
		/// <returns>the local time zone</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getTimezone' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getTimezone", "(J)I", "GetGetTimezone_JHandler")]
		public abstract int GetTimezone (long when);

		static Delegate cb_getenv_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetenv_Ljava_lang_String_Handler ()
		{
			if (cb_getenv_Ljava_lang_String_ == null)
				cb_getenv_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Getenv_Ljava_lang_String_);
			return cb_getenv_Ljava_lang_String_;
		}

		static IntPtr n_Getenv_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_variable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var variable = JNIEnv.GetString (native_variable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Getenv (variable));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="variable">system variable to read</param>
		/// <returns>value of the system variable</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getenv' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getenv", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetenv_Ljava_lang_String_Handler")]
		public abstract string Getenv (string variable);

		static Delegate cb_openSystemConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_;
#pragma warning disable 0169
		static Delegate GetOpenSystemConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_Handler ()
		{
			if (cb_openSystemConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_ == null)
				cb_openSystemConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_OpenSystemConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_);
			return cb_openSystemConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_;
		}

		static IntPtr n_OpenSystemConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_fs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (native_parent, JniHandleOwnership.DoNotTransfer);
			var fs = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (native_fs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenSystemConfig (parent, fs));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="parent">a config with values not found directly in the returned
		///            config. Null is a reasonable value here.</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <returns>the gitonfig configuration found in the system-wide "etc"
		///         directory</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='openSystemConfig' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register ("openSystemConfig", "(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/storage/file/FileBasedConfig;", "GetOpenSystemConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_Handler")]
		public abstract global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig OpenSystemConfig (global::Org.Eclipse.Jgit.Lib.Config parent, global::Org.Eclipse.Jgit.Util.FS fs);

		static Delegate cb_openUserConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_;
#pragma warning disable 0169
		static Delegate GetOpenUserConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_Handler ()
		{
			if (cb_openUserConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_ == null)
				cb_openUserConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_OpenUserConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_);
			return cb_openUserConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_;
		}

		static IntPtr n_OpenUserConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_fs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.SystemReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config> (native_parent, JniHandleOwnership.DoNotTransfer);
			var fs = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.FS> (native_fs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenUserConfig (parent, fs));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="parent">a config with values not found directly in the returned config</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <returns>the git configuration found in the user home</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='openUserConfig' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register ("openUserConfig", "(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/storage/file/FileBasedConfig;", "GetOpenUserConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_Handler")]
		public abstract global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig OpenUserConfig (global::Org.Eclipse.Jgit.Lib.Config parent, global::Org.Eclipse.Jgit.Util.FS fs);

		/// <summary>Should be used in tests when the platform is explicitly changed.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='setPlatformChecker' and count(parameter)=0]"
		[Register ("setPlatformChecker", "()V", "")]
		protected unsafe void SetPlatformChecker ()
		{
			const string __id = "setPlatformChecker.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/util/SystemReader", DoNotGenerateAcw=true)]
	internal partial class SystemReaderInvoker : SystemReader {
		public SystemReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/SystemReader", typeof (SystemReaderInvoker));

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

		/// <returns>the current system time</returns>
		public override unsafe long CurrentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getCurrentTime' and count(parameter)=0]"
			[Register ("getCurrentTime", "()J", "GetGetCurrentTimeHandler")]
			get {
				const string __id = "getCurrentTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Gets the hostname of the local host.</summary>
		/// <returns>the canonical hostname</returns>
		public override unsafe string Hostname {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getHostname' and count(parameter)=0]"
			[Register ("getHostname", "()Ljava/lang/String;", "GetGetHostnameHandler")]
			get {
				const string __id = "getHostname.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <param name="key">of the system property to read</param>
		/// <returns>value of the system property</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetProperty_Ljava_lang_String_Handler")]
		public override unsafe string GetProperty (string key)
		{
			const string __id = "getProperty.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString ((string)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		/// <param name="when">TODO</param>
		/// <returns>the local time zone</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getTimezone' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getTimezone", "(J)I", "GetGetTimezone_JHandler")]
		public override unsafe int GetTimezone (long when)
		{
			const string __id = "getTimezone.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (when);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		/// <param name="variable">system variable to read</param>
		/// <returns>value of the system variable</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='getenv' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getenv", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetenv_Ljava_lang_String_Handler")]
		public override unsafe string Getenv (string variable)
		{
			const string __id = "getenv.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_variable = JNIEnv.NewString ((string)variable);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_variable);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_variable);
			}
		}

		/// <param name="parent">a config with values not found directly in the returned
		///            config. Null is a reasonable value here.</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <returns>the gitonfig configuration found in the system-wide "etc"
		///         directory</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='openSystemConfig' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register ("openSystemConfig", "(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/storage/file/FileBasedConfig;", "GetOpenSystemConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig OpenSystemConfig (global::Org.Eclipse.Jgit.Lib.Config parent, global::Org.Eclipse.Jgit.Util.FS fs)
		{
			const string __id = "openSystemConfig.(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/storage/file/FileBasedConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (fs);
			}
		}

		/// <param name="parent">a config with values not found directly in the returned config</param>
		/// <param name="fs">the file system abstraction which will be necessary to perform
		///            certain file system operations.</param>
		/// <returns>the git configuration found in the user home</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='SystemReader']/method[@name='openUserConfig' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Config'] and parameter[2][@type='org.eclipse.jgit.util.FS']]"
		[Register ("openUserConfig", "(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/storage/file/FileBasedConfig;", "GetOpenUserConfig_Lorg_eclipse_jgit_lib_Config_Lorg_eclipse_jgit_util_FS_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig OpenUserConfig (global::Org.Eclipse.Jgit.Lib.Config parent, global::Org.Eclipse.Jgit.Util.FS fs)
		{
			const string __id = "openUserConfig.(Lorg/eclipse/jgit/lib/Config;Lorg/eclipse/jgit/util/FS;)Lorg/eclipse/jgit/storage/file/FileBasedConfig;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.File.FileBasedConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (fs);
			}
		}

	}
}
