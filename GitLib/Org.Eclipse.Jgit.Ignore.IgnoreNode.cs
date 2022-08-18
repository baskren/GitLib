using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Ignore {

	/// <summary>Represents a bundle of ignore rules inherited from a base directory.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/ignore/IgnoreNode", DoNotGenerateAcw=true)]
	public partial class IgnoreNode : global::Java.Lang.Object {
		/// <summary>Result from <c>IgnoreNode#isIgnored(String, boolean)</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode.MatchResult']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/ignore/IgnoreNode$MatchResult", DoNotGenerateAcw=true)]
		public sealed partial class MatchResult : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode.MatchResult']/field[@name='CHECK_PARENT']"
			[Register ("CHECK_PARENT")]
			public static global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult CheckParent {
				get {
					const string __id = "CHECK_PARENT.Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode.MatchResult']/field[@name='CHECK_PARENT_NEGATE_FIRST_MATCH']"
			[Register ("CHECK_PARENT_NEGATE_FIRST_MATCH")]
			public static global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult CheckParentNegateFirstMatch {
				get {
					const string __id = "CHECK_PARENT_NEGATE_FIRST_MATCH.Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode.MatchResult']/field[@name='IGNORED']"
			[Register ("IGNORED")]
			public static global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult Ignored {
				get {
					const string __id = "IGNORED.Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode.MatchResult']/field[@name='NOT_IGNORED']"
			[Register ("NOT_IGNORED")]
			public static global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult NotIgnored {
				get {
					const string __id = "NOT_IGNORED.Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/ignore/IgnoreNode$MatchResult", typeof (MatchResult));

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

			internal MatchResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode.MatchResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode.MatchResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/ignore/IgnoreNode", typeof (IgnoreNode));

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

		protected IgnoreNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty ignore node with no rules.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode']/constructor[@name='IgnoreNode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IgnoreNode () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode']/constructor[@name='IgnoreNode' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.ignore.FastIgnoreRule&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe IgnoreNode (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule> rules) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rules = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule>.ToLocalJniHandle (rules);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule>.ToLocalJniHandle (__this.Rules);
		}
#pragma warning restore 0169

		/// <returns>list of all ignore rules held by this node.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule> Rules {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode']/method[@name='getRules' and count(parameter)=0]"
			[Register ("getRules", "()Ljava/util/List;", "GetGetRulesHandler")]
			get {
				const string __id = "getRules.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Ignore.FastIgnoreRule>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isIgnored_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetIsIgnored_Ljava_lang_String_ZHandler ()
		{
			if (cb_isIgnored_Ljava_lang_String_Z == null)
				cb_isIgnored_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_IsIgnored_Ljava_lang_String_Z);
			return cb_isIgnored_Ljava_lang_String_Z;
		}

		static IntPtr n_IsIgnored_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_entryPath, bool isDirectory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entryPath = JNIEnv.GetString (native_entryPath, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IsIgnored (entryPath, isDirectory));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode']/method[@name='isIgnored' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("isIgnored", "(Ljava/lang/String;Z)Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;", "GetIsIgnored_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult IsIgnored (string entryPath, bool isDirectory)
		{
			const string __id = "isIgnored.(Ljava/lang/String;Z)Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;";
			IntPtr native_entryPath = JNIEnv.NewString ((string)entryPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_entryPath);
				__args [1] = new JniArgumentValue (isDirectory);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_entryPath);
			}
		}

		static Delegate cb_isIgnored_Ljava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetIsIgnored_Ljava_lang_String_ZZHandler ()
		{
			if (cb_isIgnored_Ljava_lang_String_ZZ == null)
				cb_isIgnored_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_L) n_IsIgnored_Ljava_lang_String_ZZ);
			return cb_isIgnored_Ljava_lang_String_ZZ;
		}

		static IntPtr n_IsIgnored_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_entryPath, bool isDirectory, bool negateFirstMatch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entryPath = JNIEnv.GetString (native_entryPath, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IsIgnored (entryPath, isDirectory, negateFirstMatch));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode']/method[@name='isIgnored' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("isIgnored", "(Ljava/lang/String;ZZ)Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;", "GetIsIgnored_Ljava_lang_String_ZZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult IsIgnored (string entryPath, bool isDirectory, bool negateFirstMatch)
		{
			const string __id = "isIgnored.(Ljava/lang/String;ZZ)Lorg/eclipse/jgit/ignore/IgnoreNode$MatchResult;";
			IntPtr native_entryPath = JNIEnv.NewString ((string)entryPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_entryPath);
				__args [1] = new JniArgumentValue (isDirectory);
				__args [2] = new JniArgumentValue (negateFirstMatch);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode.MatchResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_entryPath);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Ignore.IgnoreNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			__this.Parse (@in);
		}
#pragma warning restore 0169

		/// <param name="in">input stream holding the standard ignore format. The caller is
		///            responsible for closing the stream.</param>
		/// <summary>Parse files according to gitignore standards.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.ignore']/class[@name='IgnoreNode']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
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
