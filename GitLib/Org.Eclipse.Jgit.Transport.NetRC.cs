using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>NetRC file parser.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/NetRC", DoNotGenerateAcw=true)]
	public partial class NetRC : global::Java.Lang.Object {
		/// <summary>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC.NetRCEntry']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/NetRC$NetRCEntry", DoNotGenerateAcw=true)]
		public partial class NetRCEntry : global::Java.Lang.Object {

			/// <summary>account netrc entry</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC.NetRCEntry']/field[@name='account']"
			[Register ("account")]
			public string Account {
				get {
					const string __id = "account.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "account.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			/// <summary>login netrc entry</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC.NetRCEntry']/field[@name='login']"
			[Register ("login")]
			public string Login {
				get {
					const string __id = "login.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "login.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			/// <summary>macro script body of macdef entry.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC.NetRCEntry']/field[@name='macbody']"
			[Register ("macbody")]
			public string Macbody {
				get {
					const string __id = "macbody.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "macbody.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			/// <summary>macdef netrc entry.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC.NetRCEntry']/field[@name='macdef']"
			[Register ("macdef")]
			public string Macdef {
				get {
					const string __id = "macdef.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "macdef.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			/// <summary>machine netrc entry</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC.NetRCEntry']/field[@name='machine']"
			[Register ("machine")]
			public string Machine {
				get {
					const string __id = "machine.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "machine.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			/// <summary>password netrc entry</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC.NetRCEntry']/field[@name='password']"
			[Register ("password")]
			public IList<char> Password {
				get {
					const string __id = "password.[C";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<char>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "password.[C";

					IntPtr native_value = global::Android.Runtime.JavaArray<char>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/NetRC$NetRCEntry", typeof (NetRCEntry));

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

			protected NetRCEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <summary>Default constructor</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC.NetRCEntry']/constructor[@name='NetRC.NetRCEntry' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe NetRCEntry () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/NetRC", typeof (NetRC));

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

		protected NetRC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC']/constructor[@name='NetRC' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetRC () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="netrc">the .netrc file</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC']/constructor[@name='NetRC' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe NetRC (global::Java.IO.File netrc) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((netrc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) netrc).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (netrc);
			}
		}

		static Delegate cb_getEntries;
#pragma warning disable 0169
		static Delegate GetGetEntriesHandler ()
		{
			if (cb_getEntries == null)
				cb_getEntries = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEntries);
			return cb_getEntries;
		}

		static IntPtr n_GetEntries (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.NetRC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.NetRC.NetRCEntry>.ToLocalJniHandle (__this.Entries);
		}
#pragma warning restore 0169

		/// <returns>all entries collected from .netrc file</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.NetRC.NetRCEntry> Entries {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC']/method[@name='getEntries' and count(parameter)=0]"
			[Register ("getEntries", "()Ljava/util/Collection;", "GetGetEntriesHandler")]
			get {
				const string __id = "getEntries.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.NetRC.NetRCEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEntry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEntry_Ljava_lang_String_Handler ()
		{
			if (cb_getEntry_Ljava_lang_String_ == null)
				cb_getEntry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetEntry_Ljava_lang_String_);
			return cb_getEntry_Ljava_lang_String_;
		}

		static IntPtr n_GetEntry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_host)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.NetRC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEntry (host));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='NetRC']/method[@name='getEntry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEntry", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/NetRC$NetRCEntry;", "GetGetEntry_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.NetRC.NetRCEntry GetEntry (string host)
		{
			const string __id = "getEntry.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/NetRC$NetRCEntry;";
			IntPtr native_host = JNIEnv.NewString ((string)host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_host);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.NetRC.NetRCEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

	}
}
