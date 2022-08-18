using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Represent connection for operation on a remote repository.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='Connection']"
	[Register ("org/eclipse/jgit/transport/Connection", "", "Org.Eclipse.Jgit.Transport.IConnectionInvoker")]
	public partial interface IConnection : IJavaObject, IJavaPeerable {
		string Messages {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='Connection']/method[@name='getMessages' and count(parameter)=0]"
			[Register ("getMessages", "()Ljava/lang/String;", "GetGetMessagesHandler:Org.Eclipse.Jgit.Transport.IConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> Refs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='Connection']/method[@name='getRefs' and count(parameter)=0]"
			[Register ("getRefs", "()Ljava/util/Collection;", "GetGetRefsHandler:Org.Eclipse.Jgit.Transport.IConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> RefsMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='Connection']/method[@name='getRefsMap' and count(parameter)=0]"
			[Register ("getRefsMap", "()Ljava/util/Map;", "GetGetRefsMapHandler:Org.Eclipse.Jgit.Transport.IConnectionInvoker, AndroidBindableLibrary")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='Connection']/method[@name='close' and count(parameter)=0]"
		/// <summary>Close any resources used by this connection.</summary>
		[Register ("close", "()V", "GetCloseHandler:Org.Eclipse.Jgit.Transport.IConnectionInvoker, AndroidBindableLibrary")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='Connection']/method[@name='getRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "GetGetRef_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Transport.IConnectionInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IRef GetRef (string name);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/Connection", DoNotGenerateAcw=true)]
	internal partial class IConnectionInvoker : global::Java.Lang.Object, IConnection {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/Connection", typeof (IConnectionInvoker));

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

		public static IConnection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.Connection'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMessages;
#pragma warning disable 0169
		static Delegate GetGetMessagesHandler ()
		{
			if (cb_getMessages == null)
				cb_getMessages = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessages);
			return cb_getMessages;
		}

		static IntPtr n_GetMessages (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Messages);
		}
#pragma warning restore 0169

		IntPtr id_getMessages;
		public unsafe string Messages {
			get {
				if (id_getMessages == IntPtr.Zero)
					id_getMessages = JNIEnv.GetMethodID (class_ref, "getMessages", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRefs;
#pragma warning disable 0169
		static Delegate GetGetRefsHandler ()
		{
			if (cb_getRefs == null)
				cb_getRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefs);
			return cb_getRefs;
		}

		static IntPtr n_GetRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.Refs);
		}
#pragma warning restore 0169

		IntPtr id_getRefs;
		public unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> Refs {
			get {
				if (id_getRefs == IntPtr.Zero)
					id_getRefs = JNIEnv.GetMethodID (class_ref, "getRefs", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefs), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRefsMap;
#pragma warning disable 0169
		static Delegate GetGetRefsMapHandler ()
		{
			if (cb_getRefsMap == null)
				cb_getRefsMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefsMap);
			return cb_getRefsMap;
		}

		static IntPtr n_GetRefsMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.RefsMap);
		}
#pragma warning restore 0169

		IntPtr id_getRefsMap;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> RefsMap {
			get {
				if (id_getRefsMap == IntPtr.Zero)
					id_getRefsMap = JNIEnv.GetMethodID (class_ref, "getRefsMap", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefsMap), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_getRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRef_Ljava_lang_String_Handler ()
		{
			if (cb_getRef_Ljava_lang_String_ == null)
				cb_getRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetRef_Ljava_lang_String_);
			return cb_getRef_Ljava_lang_String_;
		}

		static IntPtr n_GetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRef (name));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRef_Ljava_lang_String_;
		public unsafe global::Org.Eclipse.Jgit.Lib.IRef GetRef (string name)
		{
			if (id_getRef_Ljava_lang_String_ == IntPtr.Zero)
				id_getRef_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRef", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;");
			IntPtr native_name = JNIEnv.NewString ((string)name);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_name);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRef_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

	}
}
