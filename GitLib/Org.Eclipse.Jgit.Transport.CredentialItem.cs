using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>A credential requested from a <c>CredentialsProvider</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialItem", DoNotGenerateAcw=true)]
	public abstract partial class CredentialItem : global::Java.Lang.Object {
		/// <summary>An item whose value is stored as a char[] and is therefore clearable.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.CharArrayType']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialItem$CharArrayType", DoNotGenerateAcw=true)]
		public partial class CharArrayType : global::Org.Eclipse.Jgit.Transport.CredentialItem {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialItem$CharArrayType", typeof (CharArrayType));

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

			protected CharArrayType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="promptText">prompt to display to the user alongside of the input
			///            field. Should be sufficient text to indicate what to
			///            supply for this item.</param>
			/// <param name="maskValue">true if the value should be masked from displaying during
			///            input. This should be true for passwords and other
			///            secrets, false for names and other public data.</param>
			/// <summary>Initialize a prompt for a secure value stored in a character array.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.CharArrayType']/constructor[@name='CredentialItem.CharArrayType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
			public unsafe CharArrayType (string promptText, bool maskValue) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_promptText = JNIEnv.NewString ((string)promptText);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_promptText);
					__args [1] = new JniArgumentValue (maskValue);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_promptText);
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.CharArrayType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			/// <summary>Destroys the current value, clearing the internal array.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.CharArrayType']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public override unsafe void Clear ()
			{
				const string __id = "clear.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValue);
				return cb_getValue;
			}

			static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.CharArrayType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetValue ());
			}
#pragma warning restore 0169

			/// <summary>Get the current value.</summary>
			/// <returns>the current value array. The actual internal array is
			///         returned, reducing the number of copies present in memory.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.CharArrayType']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()[C", "GetGetValueHandler")]
			public virtual unsafe char[] GetValue ()
			{
				const string __id = "getValue.()[C";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
				} finally {
				}
			}

			static Delegate cb_setValue_arrayC;
#pragma warning disable 0169
			static Delegate GetSetValue_arrayCHandler ()
			{
				if (cb_setValue_arrayC == null)
					cb_setValue_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValue_arrayC);
				return cb_setValue_arrayC;
			}

			static void n_SetValue_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_newValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.CharArrayType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var newValue = (char[]) JNIEnv.GetArray (native_newValue, JniHandleOwnership.DoNotTransfer, typeof (char));
				__this.SetValue (newValue);
				if (newValue != null)
					JNIEnv.CopyArray (newValue, native_newValue);
			}
#pragma warning restore 0169

			/// <param name="newValue">if not null, the array is copied.</param>
			/// <summary>Set the new value, clearing the old value array.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.CharArrayType']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='char[]']]"
			[Register ("setValue", "([C)V", "GetSetValue_arrayCHandler")]
			public virtual unsafe void SetValue (char[] newValue)
			{
				const string __id = "setValue.([C)V";
				IntPtr native_newValue = JNIEnv.NewArray (newValue);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_newValue);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (newValue != null) {
						JNIEnv.CopyArray (native_newValue, newValue);
						JNIEnv.DeleteLocalRef (native_newValue);
					}
					global::System.GC.KeepAlive (newValue);
				}
			}

			static Delegate cb_setValueNoCopy_arrayC;
#pragma warning disable 0169
			static Delegate GetSetValueNoCopy_arrayCHandler ()
			{
				if (cb_setValueNoCopy_arrayC == null)
					cb_setValueNoCopy_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValueNoCopy_arrayC);
				return cb_setValueNoCopy_arrayC;
			}

			static void n_SetValueNoCopy_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_newValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.CharArrayType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var newValue = (char[]) JNIEnv.GetArray (native_newValue, JniHandleOwnership.DoNotTransfer, typeof (char));
				__this.SetValueNoCopy (newValue);
				if (newValue != null)
					JNIEnv.CopyArray (newValue, native_newValue);
			}
#pragma warning restore 0169

			/// <param name="newValue">the new internal array. The array is &lt;b&gt;NOT&lt;/b&gt; copied.</param>
			/// <summary>Set the new value, clearing the old value array.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.CharArrayType']/method[@name='setValueNoCopy' and count(parameter)=1 and parameter[1][@type='char[]']]"
			[Register ("setValueNoCopy", "([C)V", "GetSetValueNoCopy_arrayCHandler")]
			public virtual unsafe void SetValueNoCopy (char[] newValue)
			{
				const string __id = "setValueNoCopy.([C)V";
				IntPtr native_newValue = JNIEnv.NewArray (newValue);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_newValue);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (newValue != null) {
						JNIEnv.CopyArray (native_newValue, newValue);
						JNIEnv.DeleteLocalRef (native_newValue);
					}
					global::System.GC.KeepAlive (newValue);
				}
			}

		}

		/// <summary>An advice message presented to the user, with no response required.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.InformationalMessage']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialItem$InformationalMessage", DoNotGenerateAcw=true)]
		public partial class InformationalMessage : global::Org.Eclipse.Jgit.Transport.CredentialItem {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialItem$InformationalMessage", typeof (InformationalMessage));

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

			protected InformationalMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="messageText">message to display to the user.</param>
			/// <summary>Initialize an informational message.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.InformationalMessage']/constructor[@name='CredentialItem.InformationalMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe InformationalMessage (string messageText) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_messageText = JNIEnv.NewString ((string)messageText);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_messageText);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_messageText);
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.InformationalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.InformationalMessage']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public override unsafe void Clear ()
			{
				const string __id = "clear.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		/// <summary>Prompt for a password, which is masked on input.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.Password']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialItem$Password", DoNotGenerateAcw=true)]
		public partial class Password : global::Org.Eclipse.Jgit.Transport.CredentialItem.CharArrayType {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialItem$Password", typeof (Password));

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

			protected Password (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <summary>Initialize a new password item, with a default password prompt.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.Password']/constructor[@name='CredentialItem.Password' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Password () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			/// <param name="msg">prompt message</param>
			/// <summary>Initialize a new password item, with given prompt.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.Password']/constructor[@name='CredentialItem.Password' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Password (string msg) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_msg = JNIEnv.NewString ((string)msg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_msg);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_msg);
				}
			}

		}

		/// <summary>An item whose value is stored as a string.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.StringType']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialItem$StringType", DoNotGenerateAcw=true)]
		public partial class StringType : global::Org.Eclipse.Jgit.Transport.CredentialItem {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialItem$StringType", typeof (StringType));

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

			protected StringType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="promptText">prompt to display to the user alongside of the input
			///            field. Should be sufficient text to indicate what to
			///            supply for this item.</param>
			/// <param name="maskValue">true if the value should be masked from displaying during
			///            input. This should be true for passwords and other
			///            secrets, false for names and other public data.</param>
			/// <summary>Initialize a prompt for a single string.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.StringType']/constructor[@name='CredentialItem.StringType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
			public unsafe StringType (string promptText, bool maskValue) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_promptText = JNIEnv.NewString ((string)promptText);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_promptText);
					__args [1] = new JniArgumentValue (maskValue);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_promptText);
				}
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValue);
				return cb_getValue;
			}

			static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.StringType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Value);
			}
#pragma warning restore 0169

			static Delegate cb_setValue_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetValue_Ljava_lang_String_Handler ()
			{
				if (cb_setValue_Ljava_lang_String_ == null)
					cb_setValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValue_Ljava_lang_String_);
				return cb_setValue_Ljava_lang_String_;
			}

			static void n_SetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.StringType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var newValue = JNIEnv.GetString (native_newValue, JniHandleOwnership.DoNotTransfer);
				__this.Value = newValue;
			}
#pragma warning restore 0169

			/// <returns>the current value</returns>
			/// <param name="newValue">newValue</param>
			public virtual unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.StringType']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					const string __id = "getValue.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.StringType']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setValue", "(Ljava/lang/String;)V", "GetSetValue_Ljava_lang_String_Handler")]
				set {
					const string __id = "setValue.(Ljava/lang/String;)V";
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.StringType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.StringType']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public override unsafe void Clear ()
			{
				const string __id = "clear.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		/// <summary>Prompt for a username, which is not masked on input.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.Username']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialItem$Username", DoNotGenerateAcw=true)]
		public partial class Username : global::Org.Eclipse.Jgit.Transport.CredentialItem.StringType {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialItem$Username", typeof (Username));

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

			protected Username (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <summary>Initialize a new username item, with a default username prompt.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.Username']/constructor[@name='CredentialItem.Username' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Username () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		/// <summary>An item whose value is a boolean choice, presented as Yes/No.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.YesNoType']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialItem$YesNoType", DoNotGenerateAcw=true)]
		public partial class YesNoType : global::Org.Eclipse.Jgit.Transport.CredentialItem {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialItem$YesNoType", typeof (YesNoType));

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

			protected YesNoType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="promptText">prompt to display to the user alongside of the input
			///            field. Should be sufficient text to indicate what to
			///            supply for this item.</param>
			/// <summary>Initialize a prompt for a single boolean answer.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.YesNoType']/constructor[@name='CredentialItem.YesNoType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe YesNoType (string promptText) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_promptText = JNIEnv.NewString ((string)promptText);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_promptText);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_promptText);
				}
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetValue);
				return cb_getValue;
			}

			static bool n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.YesNoType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Value;
			}
#pragma warning restore 0169

			static Delegate cb_setValue_Z;
#pragma warning disable 0169
			static Delegate GetSetValue_ZHandler ()
			{
				if (cb_setValue_Z == null)
					cb_setValue_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetValue_Z);
				return cb_setValue_Z;
			}

			static void n_SetValue_Z (IntPtr jnienv, IntPtr native__this, bool newValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.YesNoType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Value = newValue;
			}
#pragma warning restore 0169

			/// <returns>the current value</returns>
			/// <summary>Set the new value.</summary>
			/// <param name="newValue">newValue</param>
			public virtual unsafe bool Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.YesNoType']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Z", "GetGetValueHandler")]
				get {
					const string __id = "getValue.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.YesNoType']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setValue", "(Z)V", "GetSetValue_ZHandler")]
				set {
					const string __id = "setValue.(Z)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
					}
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem.YesNoType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem.YesNoType']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public override unsafe void Clear ()
			{
				const string __id = "clear.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialItem", typeof (CredentialItem));

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

		protected CredentialItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="promptText">prompt to display to the user alongside of the input field.
		///            Should be sufficient text to indicate what to supply for this
		///            item.</param>
		/// <param name="maskValue">true if the value should be masked from displaying during
		///            input. This should be true for passwords and other secrets,
		///            false for names and other public data.</param>
		/// <summary>Initialize a prompt.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem']/constructor[@name='CredentialItem' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public unsafe CredentialItem (string promptText, bool maskValue) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_promptText = JNIEnv.NewString ((string)promptText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_promptText);
				__args [1] = new JniArgumentValue (maskValue);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_promptText);
			}
		}

		static Delegate cb_isValueSecure;
#pragma warning disable 0169
		static Delegate GetIsValueSecureHandler ()
		{
			if (cb_isValueSecure == null)
				cb_isValueSecure = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsValueSecure);
			return cb_isValueSecure;
		}

		static bool n_IsValueSecure (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValueSecure;
		}
#pragma warning restore 0169

		/// <returns>true if the value should be masked when entered.</returns>
		public virtual unsafe bool IsValueSecure {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem']/method[@name='isValueSecure' and count(parameter)=0]"
			[Register ("isValueSecure", "()Z", "GetIsValueSecureHandler")]
			get {
				const string __id = "isValueSecure.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPromptText;
#pragma warning disable 0169
		static Delegate GetGetPromptTextHandler ()
		{
			if (cb_getPromptText == null)
				cb_getPromptText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPromptText);
			return cb_getPromptText;
		}

		static IntPtr n_GetPromptText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PromptText);
		}
#pragma warning restore 0169

		/// <returns>prompt to display to the user.</returns>
		public virtual unsafe string PromptText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem']/method[@name='getPromptText' and count(parameter)=0]"
			[Register ("getPromptText", "()Ljava/lang/String;", "GetGetPromptTextHandler")]
			get {
				const string __id = "getPromptText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.CredentialItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		/// <summary>Clear the stored value, destroying it as much as possible.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public abstract void Clear ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/CredentialItem", DoNotGenerateAcw=true)]
	internal partial class CredentialItemInvoker : CredentialItem {
		public CredentialItemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/CredentialItem", typeof (CredentialItemInvoker));

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

		/// <summary>Clear the stored value, destroying it as much as possible.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='CredentialItem']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public override unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
