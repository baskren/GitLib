using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Specification of annotated tag behavior during fetch.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TagOpt']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/TagOpt", DoNotGenerateAcw=true)]
	public sealed partial class TagOpt : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TagOpt']/field[@name='AUTO_FOLLOW']"
		[Register ("AUTO_FOLLOW")]
		public static global::Org.Eclipse.Jgit.Transport.TagOpt AutoFollow {
			get {
				const string __id = "AUTO_FOLLOW.Lorg/eclipse/jgit/transport/TagOpt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TagOpt']/field[@name='FETCH_TAGS']"
		[Register ("FETCH_TAGS")]
		public static global::Org.Eclipse.Jgit.Transport.TagOpt FetchTags {
			get {
				const string __id = "FETCH_TAGS.Lorg/eclipse/jgit/transport/TagOpt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TagOpt']/field[@name='NO_TAGS']"
		[Register ("NO_TAGS")]
		public static global::Org.Eclipse.Jgit.Transport.TagOpt NoTags {
			get {
				const string __id = "NO_TAGS.Lorg/eclipse/jgit/transport/TagOpt;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/TagOpt", typeof (TagOpt));

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

		internal TagOpt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="o">the configuration file text value.</param>
		/// <summary>Convert a command line/configuration file text into a value instance.</summary>
		/// <returns>the option that matches the passed parameter.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TagOpt']/method[@name='fromOption' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromOption", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/TagOpt;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.TagOpt FromOption (string o)
		{
			const string __id = "fromOption.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/TagOpt;";
			IntPtr native_o = JNIEnv.NewString ((string)o);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_o);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_o);
			}
		}

		/// <summary>Get the command line/configuration file text for this value.</summary>
		/// <returns>text that appears in the configuration file to activate this.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TagOpt']/method[@name='option' and count(parameter)=0]"
		[Register ("option", "()Ljava/lang/String;", "")]
		public unsafe string Option ()
		{
			const string __id = "option.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TagOpt']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/TagOpt;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.TagOpt ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/TagOpt;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TagOpt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='TagOpt']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/eclipse/jgit/transport/TagOpt;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.TagOpt[] Values ()
		{
			const string __id = "values.()[Lorg/eclipse/jgit/transport/TagOpt;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Eclipse.Jgit.Transport.TagOpt[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Transport.TagOpt));
			} finally {
			}
		}

	}
}
