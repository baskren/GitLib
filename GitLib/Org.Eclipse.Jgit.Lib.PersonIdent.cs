using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A combination of a person identity and time in Git.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/PersonIdent", DoNotGenerateAcw=true)]
	public partial class PersonIdent : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/PersonIdent", typeof (PersonIdent));

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

		protected PersonIdent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="aName">aName</param>
		/// <param name="aEmailAddress">aEmailAddress</param>
		/// <summary>Construct a new <c>PersonIdent</c> with current time.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/constructor[@name='PersonIdent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PersonIdent (string aName, string aEmailAddress) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_aName = JNIEnv.NewString ((string)aName);
			IntPtr native_aEmailAddress = JNIEnv.NewString ((string)aEmailAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_aName);
				__args [1] = new JniArgumentValue (native_aEmailAddress);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aName);
				JNIEnv.DeleteLocalRef (native_aEmailAddress);
			}
		}

		/// <param name="aName">aName</param>
		/// <param name="aEmailAddress">aEmailAddress</param>
		/// <param name="aWhen">local time stamp</param>
		/// <param name="aTZ">time zone</param>
		/// <summary>Construct a PersonIdent from simple data</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/constructor[@name='PersonIdent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Date'] and parameter[4][@type='java.util.TimeZone']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/TimeZone;)V", "")]
		public unsafe PersonIdent (string aName, string aEmailAddress, global::Java.Util.Date aWhen, global::Java.Util.TimeZone aTZ) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/TimeZone;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_aName = JNIEnv.NewString ((string)aName);
			IntPtr native_aEmailAddress = JNIEnv.NewString ((string)aEmailAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_aName);
				__args [1] = new JniArgumentValue (native_aEmailAddress);
				__args [2] = new JniArgumentValue ((aWhen == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aWhen).Handle);
				__args [3] = new JniArgumentValue ((aTZ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aTZ).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aName);
				JNIEnv.DeleteLocalRef (native_aEmailAddress);
				global::System.GC.KeepAlive (aWhen);
				global::System.GC.KeepAlive (aTZ);
			}
		}

		/// <param name="aName">aName</param>
		/// <param name="aEmailAddress">aEmailAddress</param>
		/// <param name="aWhen">local time stamp</param>
		/// <param name="aTZ">time zone</param>
		/// <summary>Construct a <c>PersonIdent</c></summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/constructor[@name='PersonIdent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;JI)V", "")]
		public unsafe PersonIdent (string aName, string aEmailAddress, long aWhen, int aTZ) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;JI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_aName = JNIEnv.NewString ((string)aName);
			IntPtr native_aEmailAddress = JNIEnv.NewString ((string)aEmailAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_aName);
				__args [1] = new JniArgumentValue (native_aEmailAddress);
				__args [2] = new JniArgumentValue (aWhen);
				__args [3] = new JniArgumentValue (aTZ);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aName);
				JNIEnv.DeleteLocalRef (native_aEmailAddress);
			}
		}

		/// <param name="pi">Original <c>PersonIdent</c></param>
		/// <summary>Copy a <c>PersonIdent</c>.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/constructor[@name='PersonIdent' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/PersonIdent;)V", "")]
		public unsafe PersonIdent (global::Org.Eclipse.Jgit.Lib.PersonIdent pi) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/PersonIdent;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pi == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pi).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pi);
			}
		}

		/// <param name="pi">original <c>PersonIdent</c></param>
		/// <param name="aWhen">local time</param>
		/// <summary>Copy a <c>PersonIdent</c>, but alter the clone's time stamp</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/constructor[@name='PersonIdent' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent'] and parameter[2][@type='java.util.Date']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/PersonIdent;Ljava/util/Date;)V", "")]
		public unsafe PersonIdent (global::Org.Eclipse.Jgit.Lib.PersonIdent pi, global::Java.Util.Date aWhen) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/PersonIdent;Ljava/util/Date;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((pi == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pi).Handle);
				__args [1] = new JniArgumentValue ((aWhen == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aWhen).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pi);
				global::System.GC.KeepAlive (aWhen);
			}
		}

		/// <param name="pi">original <c>PersonIdent</c></param>
		/// <param name="when">local time</param>
		/// <param name="tz">time zone</param>
		/// <summary>Copy a PersonIdent, but alter the clone's time stamp</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/constructor[@name='PersonIdent' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.util.TimeZone']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/PersonIdent;Ljava/util/Date;Ljava/util/TimeZone;)V", "")]
		public unsafe PersonIdent (global::Org.Eclipse.Jgit.Lib.PersonIdent pi, global::Java.Util.Date when, global::Java.Util.TimeZone tz) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/PersonIdent;Ljava/util/Date;Ljava/util/TimeZone;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((pi == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pi).Handle);
				__args [1] = new JniArgumentValue ((when == null) ? IntPtr.Zero : ((global::Java.Lang.Object) when).Handle);
				__args [2] = new JniArgumentValue ((tz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tz).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pi);
				global::System.GC.KeepAlive (when);
				global::System.GC.KeepAlive (tz);
			}
		}

		/// <param name="pi">original <c>PersonIdent</c></param>
		/// <param name="aWhen">local time stamp</param>
		/// <param name="aTZ">time zone</param>
		/// <summary>Copy a PersonIdent, but alter the clone's time stamp</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/constructor[@name='PersonIdent' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/PersonIdent;JI)V", "")]
		public unsafe PersonIdent (global::Org.Eclipse.Jgit.Lib.PersonIdent pi, long aWhen, int aTZ) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/PersonIdent;JI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((pi == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pi).Handle);
				__args [1] = new JniArgumentValue (aWhen);
				__args [2] = new JniArgumentValue (aTZ);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pi);
			}
		}

		/// <param name="repo">repo</param>
		/// <summary>Creates new PersonIdent from config info in repository, with current time.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/constructor[@name='PersonIdent' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe PersonIdent (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getEmailAddress;
#pragma warning disable 0169
		static Delegate GetGetEmailAddressHandler ()
		{
			if (cb_getEmailAddress == null)
				cb_getEmailAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEmailAddress);
			return cb_getEmailAddress;
		}

		static IntPtr n_GetEmailAddress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmailAddress);
		}
#pragma warning restore 0169

		/// <returns>email address of person</returns>
		public virtual unsafe string EmailAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/method[@name='getEmailAddress' and count(parameter)=0]"
			[Register ("getEmailAddress", "()Ljava/lang/String;", "GetGetEmailAddressHandler")]
			get {
				const string __id = "getEmailAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		/// <returns>Name of person</returns>
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeZone);
		}
#pragma warning restore 0169

		/// <returns>this person's declared time zone; null if time zone is unknown.</returns>
		public virtual unsafe global::Java.Util.TimeZone TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/method[@name='getTimeZone' and count(parameter)=0]"
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

		static Delegate cb_getTimeZoneOffset;
#pragma warning disable 0169
		static Delegate GetGetTimeZoneOffsetHandler ()
		{
			if (cb_getTimeZoneOffset == null)
				cb_getTimeZoneOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeZoneOffset);
			return cb_getTimeZoneOffset;
		}

		static int n_GetTimeZoneOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeZoneOffset;
		}
#pragma warning restore 0169

		/// <returns>this person's declared time zone as minutes east of UTC. If the
		///         timezone is to the west of UTC it is negative.</returns>
		public virtual unsafe int TimeZoneOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/method[@name='getTimeZoneOffset' and count(parameter)=0]"
			[Register ("getTimeZoneOffset", "()I", "GetGetTimeZoneOffsetHandler")]
			get {
				const string __id = "getTimeZoneOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWhen;
#pragma warning disable 0169
		static Delegate GetGetWhenHandler ()
		{
			if (cb_getWhen == null)
				cb_getWhen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWhen);
			return cb_getWhen;
		}

		static IntPtr n_GetWhen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.When);
		}
#pragma warning restore 0169

		/// <returns>timestamp</returns>
		public virtual unsafe global::Java.Util.Date When {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/method[@name='getWhen' and count(parameter)=0]"
			[Register ("getWhen", "()Ljava/util/Date;", "GetGetWhenHandler")]
			get {
				const string __id = "getWhen.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_toExternalString;
#pragma warning disable 0169
		static Delegate GetToExternalStringHandler ()
		{
			if (cb_toExternalString == null)
				cb_toExternalString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToExternalString);
			return cb_toExternalString;
		}

		static IntPtr n_ToExternalString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToExternalString ());
		}
#pragma warning restore 0169

		/// <summary>Format for Git storage.</summary>
		/// <returns>a string in the git author format</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='PersonIdent']/method[@name='toExternalString' and count(parameter)=0]"
		[Register ("toExternalString", "()Ljava/lang/String;", "GetToExternalStringHandler")]
		public virtual unsafe string ToExternalString ()
		{
			const string __id = "toExternalString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
