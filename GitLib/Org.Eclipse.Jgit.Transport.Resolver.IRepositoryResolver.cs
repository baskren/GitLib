using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport.Resolver {

	[Register ("org/eclipse/jgit/transport/resolver/RepositoryResolver", DoNotGenerateAcw=true)]
	public abstract class RepositoryResolver : Java.Lang.Object {
		internal RepositoryResolver ()
		{
		}


		/// <summary>Resolver configured to open nothing.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/interface[@name='RepositoryResolver']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolver None {
			get {
				const string __id = "NONE.Lorg/eclipse/jgit/transport/resolver/RepositoryResolver;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolver> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/resolver/RepositoryResolver", typeof (RepositoryResolver));

	}

	[Register ("org/eclipse/jgit/transport/resolver/RepositoryResolver", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'RepositoryResolver' type. This type will be removed in a future release.", error: true)]
	public abstract class RepositoryResolverConsts : RepositoryResolver {
		private RepositoryResolverConsts ()
		{
		}

	}

	/// <param name="&lt;C&gt;">type of connection.</param>
	/// <summary>Locate a Git <c>Repository</c> by name from the URL.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/interface[@name='RepositoryResolver']"
	[Register ("org/eclipse/jgit/transport/resolver/RepositoryResolver", "", "Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolverInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"C"})]
	public partial interface IRepositoryResolver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/interface[@name='RepositoryResolver']/method[@name='open' and count(parameter)=2 and parameter[1][@type='C'] and parameter[2][@type='java.lang.String']]"
		/// <param name="req">the current request, may be used to inspect session state
		///            including cookies or user authentication.</param>
		/// <param name="name">name of the repository, as parsed out of the URL.</param>
		/// <summary>Locate and open a reference to a <c>Repository</c>.</summary>
		/// <returns>the opened repository instance, never null.</returns>
		[Register ("open", "(Ljava/lang/Object;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Repository;", "GetOpen_Ljava_lang_Object_Ljava_lang_String_Handler:Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolverInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.Repository Open (global::Java.Lang.Object req, string name);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/resolver/RepositoryResolver", DoNotGenerateAcw=true)]
	internal partial class IRepositoryResolverInvoker : global::Java.Lang.Object, IRepositoryResolver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/resolver/RepositoryResolver", typeof (IRepositoryResolverInvoker));

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

		public static IRepositoryResolver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRepositoryResolver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.resolver.RepositoryResolver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRepositoryResolverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_open_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_open_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_open_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Open_Ljava_lang_Object_Ljava_lang_String_);
			return cb_open_Ljava_lang_Object_Ljava_lang_String_;
		}

		static IntPtr n_Open_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_req, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.IRepositoryResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var req = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_req, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (req, name));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_open_Ljava_lang_Object_Ljava_lang_String_;
		public unsafe global::Org.Eclipse.Jgit.Lib.Repository Open (global::Java.Lang.Object req, string name)
		{
			if (id_open_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_open_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/Object;Ljava/lang/String;)Lorg/eclipse/jgit/lib/Repository;");
			IntPtr native_req = JNIEnv.ToLocalJniHandle (req);
			IntPtr native_name = JNIEnv.NewString ((string)name);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_req);
			__args [1] = new JValue (native_name);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_open_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_req);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

	}
}
