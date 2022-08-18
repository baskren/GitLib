using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>A class used to execute a <c>Merge</c> command.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/MergeCommand", DoNotGenerateAcw=true)]
	public partial class MergeCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::Org.Eclipse.Jgit.Api.MergeResult> {
		/// <summary>The modes available for fast forward merges corresponding to the
		/// &lt;code&gt;--ff&lt;/code&gt;, &lt;code&gt;--no-ff&lt;/code&gt; and &lt;code&gt;--ff-only&lt;/code&gt;
		/// options under &lt;code&gt;branch.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/api/MergeCommand$FastForwardMode", DoNotGenerateAcw=true)]
		public sealed partial class FastForwardMode : global::Java.Lang.Enum, global::Org.Eclipse.Jgit.Lib.Config.IConfigEnum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode']/field[@name='FF']"
			[Register ("FF")]
			public static global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode Ff {
				get {
					const string __id = "FF.Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode']/field[@name='FF_ONLY']"
			[Register ("FF_ONLY")]
			public static global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode FfOnly {
				get {
					const string __id = "FF_ONLY.Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode']/field[@name='NO_FF']"
			[Register ("NO_FF")]
			public static global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode NoFf {
				get {
					const string __id = "NO_FF.Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode.Merge']"
			[global::Android.Runtime.Register ("org/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge", DoNotGenerateAcw=true)]
			public sealed partial class Merge : global::Java.Lang.Enum {

				// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode.Merge']/field[@name='FALSE']"
				[Register ("FALSE")]
				public static global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge False {
					get {
						const string __id = "FALSE.Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode.Merge']/field[@name='ONLY']"
				[Register ("ONLY")]
				public static global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge Only {
					get {
						const string __id = "ONLY.Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode.Merge']/field[@name='TRUE']"
				[Register ("TRUE")]
				public static global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge True {
					get {
						const string __id = "TRUE.Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}

				static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge", typeof (Merge));

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

				internal Merge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
				{
				}

				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode.Merge']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;", "")]
				public static unsafe global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge ValueOf (string name)
				{
					const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;";
					IntPtr native_name = JNIEnv.NewString ((string)name);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_name);
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_name);
					}
				}

				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode.Merge']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.MergeCommand.FastForwardMode']]"
				[Register ("valueOf", "(Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;)Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;", "")]
				public static unsafe global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge ValueOf (global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode ffMode)
				{
					const string __id = "valueOf.(Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;)Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((ffMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffMode).Handle);
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						global::System.GC.KeepAlive (ffMode);
					}
				}

				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode.Merge']/method[@name='values' and count(parameter)=0]"
				[Register ("values", "()[Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;", "")]
				public static unsafe global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge[] Values ()
				{
					const string __id = "values.()[Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return (global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge));
					} finally {
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/MergeCommand$FastForwardMode", typeof (FastForwardMode));

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

			internal FastForwardMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode']/method[@name='matchConfigValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("matchConfigValue", "(Ljava/lang/String;)Z", "")]
			public unsafe bool MatchConfigValue (string @in)
			{
				const string __id = "matchConfigValue.(Ljava/lang/String;)Z";
				IntPtr native__in = JNIEnv.NewString ((string)@in);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native__in);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native__in);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode']/method[@name='toConfigValue' and count(parameter)=0]"
			[Register ("toConfigValue", "()Ljava/lang/String;", "")]
			public unsafe string ToConfigValue ()
			{
				const string __id = "toConfigValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.MergeCommand.FastForwardMode.Merge']]"
			[Register ("valueOf", "(Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;)Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode ValueOf (global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode.Merge ffMode)
			{
				const string __id = "valueOf.(Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode$Merge;)Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((ffMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffMode).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (ffMode);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand.FastForwardMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/MergeCommand", typeof (MergeCommand));

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

		protected MergeCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/constructor[@name='MergeCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe MergeCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Merge</c> command with all the options and parameters
		/// collected by the setter methods (e.</summary>
		/// <returns>the result of the merge</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lorg/eclipse/jgit/api/MergeResult;", "GetCallHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Api.MergeResult Call ()
		{
			const string __id = "call.()Lorg/eclipse/jgit/api/MergeResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetInclude_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Include_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_aCommit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var aCommit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_aCommit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (name, aCommit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">a name given to the commit</param>
		/// <param name="aCommit">the Id of a commit which is merged with the current head</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/method[@name='include' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("include", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/MergeCommand;", "GetInclude_Ljava_lang_String_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand Include (string name, global::Org.Eclipse.Jgit.Lib.AnyObjectId aCommit)
		{
			const string __id = "include.(Ljava/lang/String;Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/MergeCommand;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((aCommit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aCommit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (aCommit);
			}
		}

		static Delegate cb_include_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetInclude_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_include_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_include_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Include_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_include_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Include_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aCommit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var aCommit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_aCommit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (aCommit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="aCommit">the Id of a commit which is merged with the current head</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("include", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/MergeCommand;", "GetInclude_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand Include (global::Org.Eclipse.Jgit.Lib.AnyObjectId aCommit)
		{
			const string __id = "include.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/api/MergeCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((aCommit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aCommit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (aCommit);
			}
		}

		static Delegate cb_include_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetInclude_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_include_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_include_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Include_Lorg_eclipse_jgit_lib_Ref_);
			return cb_include_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_Include_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aCommit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var aCommit = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_aCommit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Include (aCommit));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="aCommit">a reference to a commit which is merged with the current head</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/method[@name='include' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("include", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/MergeCommand;", "GetInclude_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand Include (global::Org.Eclipse.Jgit.Lib.IRef aCommit)
		{
			const string __id = "include.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/api/MergeCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((aCommit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aCommit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (aCommit);
			}
		}

		static Delegate cb_setCommit_Z;
#pragma warning disable 0169
		static Delegate GetSetCommit_ZHandler ()
		{
			if (cb_setCommit_Z == null)
				cb_setCommit_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCommit_Z);
			return cb_setCommit_Z;
		}

		static IntPtr n_SetCommit_Z (IntPtr jnienv, IntPtr native__this, bool commit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCommit (commit));
		}
#pragma warning restore 0169

		/// <param name="commit">&lt;code&gt;true&lt;/code&gt; if this command should commit (this is the
		///            default behavior). &lt;code&gt;false&lt;/code&gt; if this command should
		///            not commit. In case the merge was successful but this flag was
		///            set to &lt;code&gt;false&lt;/code&gt; a <c>MergeResult</c> with type
		///            <c>MergeResult</c> with status
		///            <c>MergeStatus#MERGED_NOT_COMMITTED</c> is returned</param>
		/// <summary>Controls whether the merge command should automatically commit after a
		/// successful merge</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/method[@name='setCommit' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCommit", "(Z)Lorg/eclipse/jgit/api/MergeCommand;", "GetSetCommit_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand SetCommit (bool commit)
		{
			const string __id = "setCommit.(Z)Lorg/eclipse/jgit/api/MergeCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (commit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFastForward_Lorg_eclipse_jgit_api_MergeCommand_FastForwardMode_;
#pragma warning disable 0169
		static Delegate GetSetFastForward_Lorg_eclipse_jgit_api_MergeCommand_FastForwardMode_Handler ()
		{
			if (cb_setFastForward_Lorg_eclipse_jgit_api_MergeCommand_FastForwardMode_ == null)
				cb_setFastForward_Lorg_eclipse_jgit_api_MergeCommand_FastForwardMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetFastForward_Lorg_eclipse_jgit_api_MergeCommand_FastForwardMode_);
			return cb_setFastForward_Lorg_eclipse_jgit_api_MergeCommand_FastForwardMode_;
		}

		static IntPtr n_SetFastForward_Lorg_eclipse_jgit_api_MergeCommand_FastForwardMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fastForwardMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fastForwardMode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode> (native_fastForwardMode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFastForward (fastForwardMode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/method[@name='setFastForward' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.api.MergeCommand.FastForwardMode']]"
		[Register ("setFastForward", "(Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;)Lorg/eclipse/jgit/api/MergeCommand;", "GetSetFastForward_Lorg_eclipse_jgit_api_MergeCommand_FastForwardMode_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand SetFastForward (global::Org.Eclipse.Jgit.Api.MergeCommand.FastForwardMode fastForwardMode)
		{
			const string __id = "setFastForward.(Lorg/eclipse/jgit/api/MergeCommand$FastForwardMode;)Lorg/eclipse/jgit/api/MergeCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fastForwardMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fastForwardMode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fastForwardMode);
			}
		}

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static IntPtr n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (message));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="message">the message to be used for the merge commit</param>
		/// <summary>Set the commit message to be used for the merge commit (in case one is
		/// created)</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessage", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/MergeCommand;", "GetSetMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand SetMessage (string message)
		{
			const string __id = "setMessage.(Ljava/lang/String;)Lorg/eclipse/jgit/api/MergeCommand;";
			IntPtr native_message = JNIEnv.NewString ((string)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_setSquash_Z;
#pragma warning disable 0169
		static Delegate GetSetSquash_ZHandler ()
		{
			if (cb_setSquash_Z == null)
				cb_setSquash_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetSquash_Z);
			return cb_setSquash_Z;
		}

		static IntPtr n_SetSquash_Z (IntPtr jnienv, IntPtr native__this, bool squash)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSquash (squash));
		}
#pragma warning restore 0169

		/// <param name="squash">whether to squash commits or not</param>
		/// <summary>If &lt;code&gt;true&lt;/code&gt;, will prepare the next commit in working tree and
		/// index as if a real merge happened, but do not make the commit or move the
		/// HEAD.</summary>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/method[@name='setSquash' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSquash", "(Z)Lorg/eclipse/jgit/api/MergeCommand;", "GetSetSquash_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand SetSquash (bool squash)
		{
			const string __id = "setSquash.(Z)Lorg/eclipse/jgit/api/MergeCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (squash);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_;
#pragma warning disable 0169
		static Delegate GetSetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_Handler ()
		{
			if (cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_ == null)
				cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_);
			return cb_setStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_;
		}

		static IntPtr n_SetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mergeStrategy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mergeStrategy = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (native_mergeStrategy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStrategy (mergeStrategy));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="mergeStrategy">the <c>MergeStrategy</c> to be used</param>
		/// <returns>
		///   <c>this</c>
		/// </returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='MergeCommand']/method[@name='setStrategy' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.merge.MergeStrategy']]"
		[Register ("setStrategy", "(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/MergeCommand;", "GetSetStrategy_Lorg_eclipse_jgit_merge_MergeStrategy_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.MergeCommand SetStrategy (global::Org.Eclipse.Jgit.Merge.MergeStrategy mergeStrategy)
		{
			const string __id = "setStrategy.(Lorg/eclipse/jgit/merge/MergeStrategy;)Lorg/eclipse/jgit/api/MergeCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mergeStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeStrategy).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.MergeCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mergeStrategy);
			}
		}

	}
}
