using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport.Resolver {

	[Register ("org/eclipse/jgit/transport/resolver/ReceivePackFactory", DoNotGenerateAcw=true)]
	public abstract class ReceivePackFactory : Java.Lang.Object {
		internal ReceivePackFactory ()
		{
		}


		/// <summary>A factory disabling the ReceivePack service for all repositories</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/interface[@name='ReceivePackFactory']/field[@name='DISABLED']"
		[Register ("DISABLED")]
		public static global::Org.Eclipse.Jgit.Transport.Resolver.IReceivePackFactory Disabled {
			get {
				const string __id = "DISABLED.Lorg/eclipse/jgit/transport/resolver/ReceivePackFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.IReceivePackFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/resolver/ReceivePackFactory", typeof (ReceivePackFactory));

	}

	[Register ("org/eclipse/jgit/transport/resolver/ReceivePackFactory", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ReceivePackFactory' type. This type will be removed in a future release.", error: true)]
	public abstract class ReceivePackFactoryConsts : ReceivePackFactory {
		private ReceivePackFactoryConsts ()
		{
		}

	}

	/// <param name="&lt;C&gt;">type of connection</param>
	/// <summary>Create and configure <c>ReceivePack</c> service instance.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/interface[@name='ReceivePackFactory']"
	[Register ("org/eclipse/jgit/transport/resolver/ReceivePackFactory", "", "Org.Eclipse.Jgit.Transport.Resolver.IReceivePackFactoryInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"C"})]
	public partial interface IReceivePackFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport.resolver']/interface[@name='ReceivePackFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='C'] and parameter[2][@type='org.eclipse.jgit.lib.Repository']]"
		/// <param name="req">current request, in case information from the request may help
		///            configure the ReceivePack instance.</param>
		/// <param name="db">the repository the receive would write into.</param>
		/// <summary>Create and configure a new ReceivePack instance for a repository.</summary>
		/// <returns>the newly configured ReceivePack instance, must not be null.</returns>
		[Register ("create", "(Ljava/lang/Object;Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/transport/ReceivePack;", "GetCreate_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_Handler:Org.Eclipse.Jgit.Transport.Resolver.IReceivePackFactoryInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Transport.ReceivePack Create (global::Java.Lang.Object req, global::Org.Eclipse.Jgit.Lib.Repository db);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/resolver/ReceivePackFactory", DoNotGenerateAcw=true)]
	internal partial class IReceivePackFactoryInvoker : global::Java.Lang.Object, IReceivePackFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/resolver/ReceivePackFactory", typeof (IReceivePackFactoryInvoker));

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

		public static IReceivePackFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReceivePackFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.resolver.ReceivePackFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReceivePackFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_;
#pragma warning disable 0169
		static Delegate GetCreate_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_Handler ()
		{
			if (cb_create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_ == null)
				cb_create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_);
			return cb_create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_;
		}

		static IntPtr n_Create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_req, IntPtr native_db)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.Resolver.IReceivePackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var req = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_req, JniHandleOwnership.DoNotTransfer);
			var db = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_db, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (req, db));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_;
		public unsafe global::Org.Eclipse.Jgit.Transport.ReceivePack Create (global::Java.Lang.Object req, global::Org.Eclipse.Jgit.Lib.Repository db)
		{
			if (id_create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_ == IntPtr.Zero)
				id_create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_ = JNIEnv.GetMethodID (class_ref, "create", "(Ljava/lang/Object;Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/transport/ReceivePack;");
			IntPtr native_req = JNIEnv.ToLocalJniHandle (req);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_req);
			__args [1] = new JValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Ljava_lang_Object_Lorg_eclipse_jgit_lib_Repository_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_req);
			return __ret;
		}

	}
}
