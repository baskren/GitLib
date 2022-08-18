using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Support for the start of <c>UploadPack</c> and <c>ReceivePack</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/RefAdvertiser", DoNotGenerateAcw=true)]
	public abstract partial class RefAdvertiser : global::Java.Lang.Object {
		/// <summary>Advertiser which frames lines in a <c>PacketLineOut</c> format.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser.PacketLineOutRefAdvertiser']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/RefAdvertiser$PacketLineOutRefAdvertiser", DoNotGenerateAcw=true)]
		public partial class PacketLineOutRefAdvertiser : global::Org.Eclipse.Jgit.Transport.RefAdvertiser {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RefAdvertiser$PacketLineOutRefAdvertiser", typeof (PacketLineOutRefAdvertiser));

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

			protected PacketLineOutRefAdvertiser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="out">the output stream.</param>
			/// <summary>Create a new advertiser for the supplied stream.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser.PacketLineOutRefAdvertiser']/constructor[@name='RefAdvertiser.PacketLineOutRefAdvertiser' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PacketLineOut']]"
			[Register (".ctor", "(Lorg/eclipse/jgit/transport/PacketLineOut;)V", "")]
			public unsafe PacketLineOutRefAdvertiser (global::Org.Eclipse.Jgit.Transport.PacketLineOut @out) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/eclipse/jgit/transport/PacketLineOut;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (@out);
				}
			}

			static Delegate cb_end;
#pragma warning disable 0169
			static Delegate GetEndHandler ()
			{
				if (cb_end == null)
					cb_end = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_End);
				return cb_end;
			}

			static void n_End (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser.PacketLineOutRefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.End ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser.PacketLineOutRefAdvertiser']/method[@name='end' and count(parameter)=0]"
			[Register ("end", "()V", "GetEndHandler")]
			protected override unsafe void End ()
			{
				const string __id = "end.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_writeOne_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetWriteOne_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_writeOne_Ljava_lang_CharSequence_ == null)
					cb_writeOne_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteOne_Ljava_lang_CharSequence_);
				return cb_writeOne_Ljava_lang_CharSequence_;
			}

			static void n_WriteOne_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_line)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser.PacketLineOutRefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var line = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_line, JniHandleOwnership.DoNotTransfer);
				__this.WriteOne (line);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser.PacketLineOutRefAdvertiser']/method[@name='writeOne' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("writeOne", "(Ljava/lang/CharSequence;)V", "GetWriteOne_Ljava_lang_CharSequence_Handler")]
			protected override unsafe void WriteOne (global::Java.Lang.ICharSequence line)
			{
				const string __id = "writeOne.(Ljava/lang/CharSequence;)V";
				IntPtr native_line = CharSequence.ToLocalJniHandle (line);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_line);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_line);
					global::System.GC.KeepAlive (line);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RefAdvertiser", typeof (RefAdvertiser));

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

		protected RefAdvertiser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/constructor[@name='RefAdvertiser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RefAdvertiser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		/// <returns>true if no advertisements have been sent yet.</returns>
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addSymref_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddSymref_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addSymref_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addSymref_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddSymref_Ljava_lang_String_Ljava_lang_String_);
			return cb_addSymref_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddSymref_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_from, IntPtr native_to)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var from = JNIEnv.GetString (native_from, JniHandleOwnership.DoNotTransfer);
			var to = JNIEnv.GetString (native_to, JniHandleOwnership.DoNotTransfer);
			__this.AddSymref (from, to);
		}
#pragma warning restore 0169

		/// <param name="from">The symbolic ref, e.g. "HEAD"</param>
		/// <param name="to">The real ref it points to, e.g. "refs/heads/master"</param>
		/// <summary>Add a symbolic ref to capabilities.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='addSymref' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addSymref", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddSymref_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddSymref (string from, string to)
		{
			const string __id = "addSymref.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_from = JNIEnv.NewString ((string)from);
			IntPtr native_to = JNIEnv.NewString ((string)to);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_from);
				__args [1] = new JniArgumentValue (native_to);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_from);
				JNIEnv.DeleteLocalRef (native_to);
			}
		}

		static Delegate cb_advertiseCapability_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdvertiseCapability_Ljava_lang_String_Handler ()
		{
			if (cb_advertiseCapability_Ljava_lang_String_ == null)
				cb_advertiseCapability_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AdvertiseCapability_Ljava_lang_String_);
			return cb_advertiseCapability_Ljava_lang_String_;
		}

		static void n_AdvertiseCapability_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseCapability (name);
		}
#pragma warning restore 0169

		/// <param name="name">the name of a single protocol capability supported by the
		///            caller. The set of capabilities are sent to the client in the
		///            advertisement, allowing the client to later selectively enable
		///            features it recognizes.</param>
		/// <summary>Add one protocol capability to the initial advertisement.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='advertiseCapability' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("advertiseCapability", "(Ljava/lang/String;)V", "GetAdvertiseCapability_Ljava_lang_String_Handler")]
		public virtual unsafe void AdvertiseCapability (string name)
		{
			const string __id = "advertiseCapability.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_advertiseHave_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetAdvertiseHave_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_advertiseHave_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_advertiseHave_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AdvertiseHave_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_advertiseHave_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static void n_AdvertiseHave_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseHave (id);
		}
#pragma warning restore 0169

		/// <param name="id">identity of the object that is assumed to exist.</param>
		/// <summary>Advertise one object is available using the magic <c>.have</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='advertiseHave' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("advertiseHave", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "GetAdvertiseHave_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe void AdvertiseHave (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "advertiseHave.(Lorg/eclipse/jgit/lib/AnyObjectId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_advertiseId_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdvertiseId_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Handler ()
		{
			if (cb_advertiseId_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_ == null)
				cb_advertiseId_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AdvertiseId_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_);
			return cb_advertiseId_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_;
		}

		static void n_AdvertiseId_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_refName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			var refName = JNIEnv.GetString (native_refName, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseId (id, refName);
		}
#pragma warning restore 0169

		/// <param name="id">the object to advertise.</param>
		/// <param name="refName">name of the reference to advertise the object as, can be any
		///            string not including the NUL byte.</param>
		/// <summary>Advertise one object under a specific name.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='advertiseId' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='java.lang.String']]"
		[Register ("advertiseId", "(Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/lang/String;)V", "GetAdvertiseId_Lorg_eclipse_jgit_lib_AnyObjectId_Ljava_lang_String_Handler")]
		public virtual unsafe void AdvertiseId (global::Org.Eclipse.Jgit.Lib.AnyObjectId id, string refName)
		{
			const string __id = "advertiseId.(Lorg/eclipse/jgit/lib/AnyObjectId;Ljava/lang/String;)V";
			IntPtr native_refName = JNIEnv.NewString ((string)refName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [1] = new JniArgumentValue (native_refName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refName);
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_end;
#pragma warning disable 0169
		static Delegate GetEndHandler ()
		{
			if (cb_end == null)
				cb_end = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_End);
			return cb_end;
		}

		static void n_End (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		/// <summary>Mark the end of the advertisements.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler")]
		protected abstract void End ();

		static Delegate cb_init_Lorg_eclipse_jgit_lib_Repository_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_eclipse_jgit_lib_Repository_Handler ()
		{
			if (cb_init_Lorg_eclipse_jgit_lib_Repository_ == null)
				cb_init_Lorg_eclipse_jgit_lib_Repository_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Init_Lorg_eclipse_jgit_lib_Repository_);
			return cb_init_Lorg_eclipse_jgit_lib_Repository_;
		}

		static void n_Init_Lorg_eclipse_jgit_lib_Repository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_src, JniHandleOwnership.DoNotTransfer);
			__this.Init (src);
		}
#pragma warning restore 0169

		/// <param name="src">the repository to read from.</param>
		/// <summary>Initialize this advertiser with a repository for peeling tags.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='init' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("init", "(Lorg/eclipse/jgit/lib/Repository;)V", "GetInit_Lorg_eclipse_jgit_lib_Repository_Handler")]
		public virtual unsafe void Init (global::Org.Eclipse.Jgit.Lib.Repository src)
		{
			const string __id = "init.(Lorg/eclipse/jgit/lib/Repository;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		static Delegate cb_send_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_util_Map_Handler ()
		{
			if (cb_send_Ljava_util_Map_ == null)
				cb_send_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Send_Ljava_util_Map_);
			return cb_send_Ljava_util_Map_;
		}

		static IntPtr n_Send_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refs = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (native_refs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.Send (refs));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="refs">zero or more refs to format for the client. The collection is
		///            sorted before display if necessary, and therefore may appear
		///            in any order.</param>
		/// <summary>Format an advertisement for the supplied refs.</summary>
		/// <returns>set of ObjectIds that were advertised to the client.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.lib.Ref&gt;']]"
		[Register ("send", "(Ljava/util/Map;)Ljava/util/Set;", "GetSend_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> Send (global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> refs)
		{
			const string __id = "send.(Ljava/util/Map;)Ljava/util/Set;";
			IntPtr native_refs = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (refs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refs);
				global::System.GC.KeepAlive (refs);
			}
		}

		static Delegate cb_setDerefTags_Z;
#pragma warning disable 0169
		static Delegate GetSetDerefTags_ZHandler ()
		{
			if (cb_setDerefTags_Z == null)
				cb_setDerefTags_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDerefTags_Z);
			return cb_setDerefTags_Z;
		}

		static void n_SetDerefTags_Z (IntPtr jnienv, IntPtr native__this, bool deref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDerefTags (deref);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='setDerefTags' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDerefTags", "(Z)V", "GetSetDerefTags_ZHandler")]
		public virtual unsafe void SetDerefTags (bool deref)
		{
			const string __id = "setDerefTags.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (deref);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeOne_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetWriteOne_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_writeOne_Ljava_lang_CharSequence_ == null)
				cb_writeOne_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteOne_Ljava_lang_CharSequence_);
			return cb_writeOne_Ljava_lang_CharSequence_;
		}

		static void n_WriteOne_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_line)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var line = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_line, JniHandleOwnership.DoNotTransfer);
			__this.WriteOne (line);
		}
#pragma warning restore 0169

		/// <param name="line">the advertisement line to be written. The line always ends
		///            with LF. Never null or the empty string.</param>
		/// <summary>Write a single advertisement line.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='writeOne' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("writeOne", "(Ljava/lang/CharSequence;)V", "GetWriteOne_Ljava_lang_CharSequence_Handler")]
		protected abstract void WriteOne (global::Java.Lang.ICharSequence line);

		/// <param name="line">the advertisement line to be written. The line always ends
		///            with LF. Never null or the empty string.</param>
		/// <summary>Write a single advertisement line.</summary>
		protected void WriteOne (string line)
		{
			var jls_line = line == null ? null : new global::Java.Lang.String (line);
			WriteOne (jls_line);
			jls_line?.Dispose ();
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/RefAdvertiser", DoNotGenerateAcw=true)]
	internal partial class RefAdvertiserInvoker : RefAdvertiser {
		public RefAdvertiserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RefAdvertiser", typeof (RefAdvertiserInvoker));

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

		/// <summary>Mark the end of the advertisements.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler")]
		protected override unsafe void End ()
		{
			const string __id = "end.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <param name="line">the advertisement line to be written. The line always ends
		///            with LF. Never null or the empty string.</param>
		/// <summary>Write a single advertisement line.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RefAdvertiser']/method[@name='writeOne' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("writeOne", "(Ljava/lang/CharSequence;)V", "GetWriteOne_Ljava_lang_CharSequence_Handler")]
		protected override unsafe void WriteOne (global::Java.Lang.ICharSequence line)
		{
			const string __id = "writeOne.(Ljava/lang/CharSequence;)V";
			IntPtr native_line = CharSequence.ToLocalJniHandle (line);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_line);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_line);
				global::System.GC.KeepAlive (line);
			}
		}

	}
}
