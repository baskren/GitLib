using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>A service exposed by <c>Daemon</c> over anonymous &lt;code&gt;git://&lt;/code&gt;.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='DaemonService']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/DaemonService", DoNotGenerateAcw=true)]
	public abstract partial class DaemonService : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/DaemonService", typeof (DaemonService));

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

		protected DaemonService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getCommandName;
#pragma warning disable 0169
		static Delegate GetGetCommandNameHandler ()
		{
			if (cb_getCommandName == null)
				cb_getCommandName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommandName);
			return cb_getCommandName;
		}

		static IntPtr n_GetCommandName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.DaemonService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CommandName);
		}
#pragma warning restore 0169

		/// <returns>name of the command requested by clients.</returns>
		public virtual unsafe string CommandName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='DaemonService']/method[@name='getCommandName' and count(parameter)=0]"
			[Register ("getCommandName", "()Ljava/lang/String;", "GetGetCommandNameHandler")]
			get {
				const string __id = "getCommandName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.DaemonService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled;
		}
#pragma warning restore 0169

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.DaemonService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enabled = on;
		}
#pragma warning restore 0169

		/// <returns>is this service enabled for invocation?</returns>
		/// <param name="on">true to allow this service to be used; false to deny it.</param>
		public virtual unsafe bool Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='DaemonService']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				const string __id = "isEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='DaemonService']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
			set {
				const string __id = "setEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isOverridable;
#pragma warning disable 0169
		static Delegate GetIsOverridableHandler ()
		{
			if (cb_isOverridable == null)
				cb_isOverridable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOverridable);
			return cb_isOverridable;
		}

		static bool n_IsOverridable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.DaemonService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Overridable;
		}
#pragma warning restore 0169

		static Delegate cb_setOverridable_Z;
#pragma warning disable 0169
		static Delegate GetSetOverridable_ZHandler ()
		{
			if (cb_setOverridable_Z == null)
				cb_setOverridable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetOverridable_Z);
			return cb_setOverridable_Z;
		}

		static void n_SetOverridable_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.DaemonService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Overridable = on;
		}
#pragma warning restore 0169

		/// <returns>can this service be configured in the repository config file?</returns>
		/// <param name="on">true to permit repositories to override this service's enabled
		///            state with the &lt;code&gt;daemon.servicename&lt;/code&gt; config setting.</param>
		public virtual unsafe bool Overridable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='DaemonService']/method[@name='isOverridable' and count(parameter)=0]"
			[Register ("isOverridable", "()Z", "GetIsOverridableHandler")]
			get {
				const string __id = "isOverridable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='DaemonService']/method[@name='setOverridable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOverridable", "(Z)V", "GetSetOverridable_ZHandler")]
			set {
				const string __id = "setOverridable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_handles_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandles_Ljava_lang_String_Handler ()
		{
			if (cb_handles_Ljava_lang_String_ == null)
				cb_handles_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Handles_Ljava_lang_String_);
			return cb_handles_Ljava_lang_String_;
		}

		static bool n_Handles_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_commandLine)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.DaemonService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commandLine = JNIEnv.GetString (native_commandLine, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Handles (commandLine);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="commandLine">input line from the client.</param>
		/// <summary>Determine if this service can handle the requested command.</summary>
		/// <returns>true if this command can accept the given command line.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='DaemonService']/method[@name='handles' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("handles", "(Ljava/lang/String;)Z", "GetHandles_Ljava_lang_String_Handler")]
		public virtual unsafe bool Handles (string commandLine)
		{
			const string __id = "handles.(Ljava/lang/String;)Z";
			IntPtr native_commandLine = JNIEnv.NewString ((string)commandLine);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_commandLine);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_commandLine);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/DaemonService", DoNotGenerateAcw=true)]
	internal partial class DaemonServiceInvoker : DaemonService {
		public DaemonServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/DaemonService", typeof (DaemonServiceInvoker));

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

	}
}
