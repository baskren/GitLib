using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Parsed reflog entry</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogEntry']"
	[Register ("org/eclipse/jgit/lib/ReflogEntry", "", "Org.Eclipse.Jgit.Lib.IReflogEntryInvoker")]
	public partial interface IReflogEntry : IJavaObject, IJavaPeerable {
		string Comment {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogEntry']/method[@name='getComment' and count(parameter)=0]"
			[Register ("getComment", "()Ljava/lang/String;", "GetGetCommentHandler:Org.Eclipse.Jgit.Lib.IReflogEntryInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Lib.ObjectId NewId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogEntry']/method[@name='getNewId' and count(parameter)=0]"
			[Register ("getNewId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetNewIdHandler:Org.Eclipse.Jgit.Lib.IReflogEntryInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Lib.ObjectId OldId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogEntry']/method[@name='getOldId' and count(parameter)=0]"
			[Register ("getOldId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetOldIdHandler:Org.Eclipse.Jgit.Lib.IReflogEntryInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Lib.PersonIdent Who {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogEntry']/method[@name='getWho' and count(parameter)=0]"
			[Register ("getWho", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetWhoHandler:Org.Eclipse.Jgit.Lib.IReflogEntryInvoker, AndroidBindableLibrary")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogEntry']/method[@name='parseCheckout' and count(parameter)=0]"
		/// <returns>a <c>CheckoutEntry</c> with parsed information about a branch
		///         switch, or null if the entry is not a checkout</returns>
		[Register ("parseCheckout", "()Lorg/eclipse/jgit/lib/CheckoutEntry;", "GetParseCheckoutHandler:Org.Eclipse.Jgit.Lib.IReflogEntryInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.ICheckoutEntry ParseCheckout ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ReflogEntry", DoNotGenerateAcw=true)]
	internal partial class IReflogEntryInvoker : global::Java.Lang.Object, IReflogEntry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ReflogEntry", typeof (IReflogEntryInvoker));

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

		public static IReflogEntry GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReflogEntry> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.ReflogEntry'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReflogEntryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getComment;
#pragma warning disable 0169
		static Delegate GetGetCommentHandler ()
		{
			if (cb_getComment == null)
				cb_getComment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetComment);
			return cb_getComment;
		}

		static IntPtr n_GetComment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Comment);
		}
#pragma warning restore 0169

		IntPtr id_getComment;
		public unsafe string Comment {
			get {
				if (id_getComment == IntPtr.Zero)
					id_getComment = JNIEnv.GetMethodID (class_ref, "getComment", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getComment), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNewId;
#pragma warning disable 0169
		static Delegate GetGetNewIdHandler ()
		{
			if (cb_getNewId == null)
				cb_getNewId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewId);
			return cb_getNewId;
		}

		static IntPtr n_GetNewId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewId);
		}
#pragma warning restore 0169

		IntPtr id_getNewId;
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId NewId {
			get {
				if (id_getNewId == IntPtr.Zero)
					id_getNewId = JNIEnv.GetMethodID (class_ref, "getNewId", "()Lorg/eclipse/jgit/lib/ObjectId;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOldId;
#pragma warning disable 0169
		static Delegate GetGetOldIdHandler ()
		{
			if (cb_getOldId == null)
				cb_getOldId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOldId);
			return cb_getOldId;
		}

		static IntPtr n_GetOldId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldId);
		}
#pragma warning restore 0169

		IntPtr id_getOldId;
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId OldId {
			get {
				if (id_getOldId == IntPtr.Zero)
					id_getOldId = JNIEnv.GetMethodID (class_ref, "getOldId", "()Lorg/eclipse/jgit/lib/ObjectId;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWho;
#pragma warning disable 0169
		static Delegate GetGetWhoHandler ()
		{
			if (cb_getWho == null)
				cb_getWho = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWho);
			return cb_getWho;
		}

		static IntPtr n_GetWho (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Who);
		}
#pragma warning restore 0169

		IntPtr id_getWho;
		public unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent Who {
			get {
				if (id_getWho == IntPtr.Zero)
					id_getWho = JNIEnv.GetMethodID (class_ref, "getWho", "()Lorg/eclipse/jgit/lib/PersonIdent;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWho), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_parseCheckout;
#pragma warning disable 0169
		static Delegate GetParseCheckoutHandler ()
		{
			if (cb_parseCheckout == null)
				cb_parseCheckout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ParseCheckout);
			return cb_parseCheckout;
		}

		static IntPtr n_ParseCheckout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParseCheckout ());
		}
#pragma warning restore 0169

		IntPtr id_parseCheckout;
		public unsafe global::Org.Eclipse.Jgit.Lib.ICheckoutEntry ParseCheckout ()
		{
			if (id_parseCheckout == IntPtr.Zero)
				id_parseCheckout = JNIEnv.GetMethodID (class_ref, "parseCheckout", "()Lorg/eclipse/jgit/lib/CheckoutEntry;");
			return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ICheckoutEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parseCheckout), JniHandleOwnership.TransferLocalRef);
		}

	}
}
