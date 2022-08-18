using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Attributes {

	/// <summary>Represents a bundle of attributes inherited from a base directory.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesNode']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/attributes/AttributesNode", DoNotGenerateAcw=true)]
	public partial class AttributesNode : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/attributes/AttributesNode", typeof (AttributesNode));

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

		protected AttributesNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty ignore node with no rules.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesNode']/constructor[@name='AttributesNode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AttributesNode () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="rules">list of rules.</param>
		/// <summary>Create an ignore node with given rules.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesNode']/constructor[@name='AttributesNode' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.attributes.AttributesRule&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe AttributesNode (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Attributes.AttributesRule> rules) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rules = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Attributes.AttributesRule>.ToLocalJniHandle (rules);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rules);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_rules);
				global::System.GC.KeepAlive (rules);
			}
		}

		static Delegate cb_getRules;
#pragma warning disable 0169
		static Delegate GetGetRulesHandler ()
		{
			if (cb_getRules == null)
				cb_getRules = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRules);
			return cb_getRules;
		}

		static IntPtr n_GetRules (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Attributes.AttributesRule>.ToLocalJniHandle (__this.Rules);
		}
#pragma warning restore 0169

		/// <returns>list of all ignore rules held by this node.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Attributes.AttributesRule> Rules {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesNode']/method[@name='getRules' and count(parameter)=0]"
			[Register ("getRules", "()Ljava/util/List;", "GetGetRulesHandler")]
			get {
				const string __id = "getRules.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Attributes.AttributesRule>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAttributes_Ljava_lang_String_ZLjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetAttributes_Ljava_lang_String_ZLjava_util_Map_Handler ()
		{
			if (cb_getAttributes_Ljava_lang_String_ZLjava_util_Map_ == null)
				cb_getAttributes_Ljava_lang_String_ZLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GetAttributes_Ljava_lang_String_ZLjava_util_Map_);
			return cb_getAttributes_Ljava_lang_String_ZLjava_util_Map_;
		}

		static void n_GetAttributes_Ljava_lang_String_ZLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entryPath, bool isDirectory, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entryPath = JNIEnv.GetString (native_entryPath, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Attributes.Attribute>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.GetAttributes (entryPath, isDirectory, attributes);
		}
#pragma warning restore 0169

		/// <param name="entryPath">the path to test. The path must be relative to this attribute
		///            node's own repository path, and in repository path format
		///            (uses '/' and not '\').</param>
		/// <param name="isDirectory">true if the target item is a directory.</param>
		/// <param name="attributes">Map that will hold the attributes matching this entry path. If
		///            it is not empty, this method will NOT override any
		///            existing entry.</param>
		/// <summary>Returns the matching attributes for an entry path.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesNode']/method[@name='getAttributes' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.attributes.Attribute&gt;']]"
		[Register ("getAttributes", "(Ljava/lang/String;ZLjava/util/Map;)V", "GetGetAttributes_Ljava_lang_String_ZLjava_util_Map_Handler")]
		public virtual unsafe void GetAttributes (string entryPath, bool isDirectory, global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Attributes.Attribute> attributes)
		{
			const string __id = "getAttributes.(Ljava/lang/String;ZLjava/util/Map;)V";
			IntPtr native_entryPath = JNIEnv.NewString ((string)entryPath);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Attributes.Attribute>.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_entryPath);
				__args [1] = new JniArgumentValue (isDirectory);
				__args [2] = new JniArgumentValue (native_attributes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entryPath);
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (attributes);
			}
		}

		static Delegate cb_parse_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_io_InputStream_Handler ()
		{
			if (cb_parse_Ljava_io_InputStream_ == null)
				cb_parse_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Parse_Ljava_io_InputStream_);
			return cb_parse_Ljava_io_InputStream_;
		}

		static void n_Parse_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Attributes.AttributesNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			__this.Parse (@in);
		}
#pragma warning restore 0169

		/// <param name="in">input stream holding the standard ignore format. The caller is
		///            responsible for closing the stream.</param>
		/// <summary>Parse files according to gitattribute standards.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.attributes']/class[@name='AttributesNode']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("parse", "(Ljava/io/InputStream;)V", "GetParse_Ljava_io_InputStream_Handler")]
		public virtual unsafe void Parse (global::System.IO.Stream @in)
		{
			const string __id = "parse.(Ljava/io/InputStream;)V";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

	}
}
