using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	[Register ("org/eclipse/jgit/transport/RefFilter", DoNotGenerateAcw=true)]
	public abstract class RefFilter : Java.Lang.Object {
		internal RefFilter ()
		{
		}


		/// <summary>The default filter, allows all refs to be shown.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='RefFilter']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Org.Eclipse.Jgit.Transport.IRefFilter Default {
			get {
				const string __id = "DEFAULT.Lorg/eclipse/jgit/transport/RefFilter;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRefFilter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RefFilter", typeof (RefFilter));

	}

	[Register ("org/eclipse/jgit/transport/RefFilter", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'RefFilter' type. This type will be removed in a future release.", error: true)]
	public abstract class RefFilterConsts : RefFilter {
		private RefFilterConsts ()
		{
		}

	}

	/// <summary>Filters the list of refs that are advertised to the client.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='RefFilter']"
	[Register ("org/eclipse/jgit/transport/RefFilter", "", "Org.Eclipse.Jgit.Transport.IRefFilterInvoker")]
	public partial interface IRefFilter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='RefFilter']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.lib.Ref&gt;']]"
		/// <param name="refs">the refs which this method need to consider.</param>
		/// <summary>Filters a <c>Map</c> of refs before it is advertised to the client.</summary>
		/// <returns>the filtered map of refs.</returns>
		[Register ("filter", "(Ljava/util/Map;)Ljava/util/Map;", "GetFilter_Ljava_util_Map_Handler:Org.Eclipse.Jgit.Transport.IRefFilterInvoker, AndroidBindableLibrary")]
		global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> Filter (global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> refs);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/RefFilter", DoNotGenerateAcw=true)]
	internal partial class IRefFilterInvoker : global::Java.Lang.Object, IRefFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RefFilter", typeof (IRefFilterInvoker));

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

		public static IRefFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRefFilter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.RefFilter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_filter_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetFilter_Ljava_util_Map_Handler ()
		{
			if (cb_filter_Ljava_util_Map_ == null)
				cb_filter_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Filter_Ljava_util_Map_);
			return cb_filter_Ljava_util_Map_;
		}

		static IntPtr n_Filter_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRefFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refs = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (native_refs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.Filter (refs));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_filter_Ljava_util_Map_;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> Filter (global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> refs)
		{
			if (id_filter_Ljava_util_Map_ == IntPtr.Zero)
				id_filter_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "filter", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_refs = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (refs);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_refs);
			var __ret = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_filter_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_refs);
			return __ret;
		}

	}
}
