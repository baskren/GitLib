using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>Keeps track of diff related configuration options.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/DiffConfig", DoNotGenerateAcw=true)]
	public partial class DiffConfig : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig']/field[@name='KEY']"
		[Register ("KEY")]
		public static global::Org.Eclipse.Jgit.Lib.Config.ISectionParser Key {
			get {
				const string __id = "KEY.Lorg/eclipse/jgit/lib/Config$SectionParser;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.ISectionParser> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>Permissible values for <c>diff.renames</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig.RenameDetectionType']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/diff/DiffConfig$RenameDetectionType", DoNotGenerateAcw=true)]
		public sealed partial class RenameDetectionType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig.RenameDetectionType']/field[@name='COPY']"
			[Register ("COPY")]
			public static global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType Copy {
				get {
					const string __id = "COPY.Lorg/eclipse/jgit/diff/DiffConfig$RenameDetectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig.RenameDetectionType']/field[@name='FALSE']"
			[Register ("FALSE")]
			public static global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType False {
				get {
					const string __id = "FALSE.Lorg/eclipse/jgit/diff/DiffConfig$RenameDetectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig.RenameDetectionType']/field[@name='TRUE']"
			[Register ("TRUE")]
			public static global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType True {
				get {
					const string __id = "TRUE.Lorg/eclipse/jgit/diff/DiffConfig$RenameDetectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/DiffConfig$RenameDetectionType", typeof (RenameDetectionType));

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

			internal RenameDetectionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig.RenameDetectionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/diff/DiffConfig$RenameDetectionType;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/diff/DiffConfig$RenameDetectionType;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig.RenameDetectionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/diff/DiffConfig$RenameDetectionType;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/diff/DiffConfig$RenameDetectionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/DiffConfig", typeof (DiffConfig));

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

		protected DiffConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_isNoPrefix;
#pragma warning disable 0169
		static Delegate GetIsNoPrefixHandler ()
		{
			if (cb_isNoPrefix == null)
				cb_isNoPrefix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNoPrefix);
			return cb_isNoPrefix;
		}

		static bool n_IsNoPrefix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNoPrefix;
		}
#pragma warning restore 0169

		/// <returns>true if the prefix "a/" and "b/" should be suppressed.</returns>
		public virtual unsafe bool IsNoPrefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig']/method[@name='isNoPrefix' and count(parameter)=0]"
			[Register ("isNoPrefix", "()Z", "GetIsNoPrefixHandler")]
			get {
				const string __id = "isNoPrefix.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRenameDetectionEnabled;
#pragma warning disable 0169
		static Delegate GetIsRenameDetectionEnabledHandler ()
		{
			if (cb_isRenameDetectionEnabled == null)
				cb_isRenameDetectionEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRenameDetectionEnabled);
			return cb_isRenameDetectionEnabled;
		}

		static bool n_IsRenameDetectionEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRenameDetectionEnabled;
		}
#pragma warning restore 0169

		/// <returns>true if rename detection is enabled by default.</returns>
		public virtual unsafe bool IsRenameDetectionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig']/method[@name='isRenameDetectionEnabled' and count(parameter)=0]"
			[Register ("isRenameDetectionEnabled", "()Z", "GetIsRenameDetectionEnabledHandler")]
			get {
				const string __id = "isRenameDetectionEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRenameLimit;
#pragma warning disable 0169
		static Delegate GetGetRenameLimitHandler ()
		{
			if (cb_getRenameLimit == null)
				cb_getRenameLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRenameLimit);
			return cb_getRenameLimit;
		}

		static int n_GetRenameLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RenameLimit;
		}
#pragma warning restore 0169

		/// <returns>limit on number of paths to perform inexact rename detection.</returns>
		public virtual unsafe int RenameLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig']/method[@name='getRenameLimit' and count(parameter)=0]"
			[Register ("getRenameLimit", "()I", "GetGetRenameLimitHandler")]
			get {
				const string __id = "getRenameLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRenameDetectionType;
#pragma warning disable 0169
		static Delegate GetGetRenameDetectionTypeHandler ()
		{
			if (cb_getRenameDetectionType == null)
				cb_getRenameDetectionType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRenameDetectionType);
			return cb_getRenameDetectionType;
		}

		static IntPtr n_GetRenameDetectionType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRenameDetectionType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='DiffConfig']/method[@name='getRenameDetectionType' and count(parameter)=0]"
		[Register ("getRenameDetectionType", "()Lorg/eclipse/jgit/diff/DiffConfig$RenameDetectionType;", "GetGetRenameDetectionTypeHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType GetRenameDetectionType ()
		{
			const string __id = "getRenameDetectionType.()Lorg/eclipse/jgit/diff/DiffConfig$RenameDetectionType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffConfig.RenameDetectionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
