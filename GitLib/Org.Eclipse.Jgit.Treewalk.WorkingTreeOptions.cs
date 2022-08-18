using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk {

	/// <summary>Options used by the <c>WorkingTreeIterator</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeOptions']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/WorkingTreeOptions", DoNotGenerateAcw=true)]
	public partial class WorkingTreeOptions : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeOptions']/field[@name='KEY']"
		[Register ("KEY")]
		public static global::Org.Eclipse.Jgit.Lib.Config.ISectionParser Key {
			get {
				const string __id = "KEY.Lorg/eclipse/jgit/lib/Config$SectionParser;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Config.ISectionParser> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/WorkingTreeOptions", typeof (WorkingTreeOptions));

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

		protected WorkingTreeOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAutoCRLF;
#pragma warning disable 0169
		static Delegate GetGetAutoCRLFHandler ()
		{
			if (cb_getAutoCRLF == null)
				cb_getAutoCRLF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAutoCRLF);
			return cb_getAutoCRLF;
		}

		static IntPtr n_GetAutoCRLF (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AutoCRLF);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF AutoCRLF {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeOptions']/method[@name='getAutoCRLF' and count(parameter)=0]"
			[Register ("getAutoCRLF", "()Lorg/eclipse/jgit/lib/CoreConfig$AutoCRLF;", "GetGetAutoCRLFHandler")]
			get {
				const string __id = "getAutoCRLF.()Lorg/eclipse/jgit/lib/CoreConfig$AutoCRLF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.AutoCRLF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCheckStat;
#pragma warning disable 0169
		static Delegate GetGetCheckStatHandler ()
		{
			if (cb_getCheckStat == null)
				cb_getCheckStat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCheckStat);
			return cb_getCheckStat;
		}

		static IntPtr n_GetCheckStat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CheckStat);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat CheckStat {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeOptions']/method[@name='getCheckStat' and count(parameter)=0]"
			[Register ("getCheckStat", "()Lorg/eclipse/jgit/lib/CoreConfig$CheckStat;", "GetGetCheckStatHandler")]
			get {
				const string __id = "getCheckStat.()Lorg/eclipse/jgit/lib/CoreConfig$CheckStat;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.CheckStat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHideDotFiles;
#pragma warning disable 0169
		static Delegate GetGetHideDotFilesHandler ()
		{
			if (cb_getHideDotFiles == null)
				cb_getHideDotFiles = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHideDotFiles);
			return cb_getHideDotFiles;
		}

		static IntPtr n_GetHideDotFiles (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideDotFiles);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles HideDotFiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeOptions']/method[@name='getHideDotFiles' and count(parameter)=0]"
			[Register ("getHideDotFiles", "()Lorg/eclipse/jgit/lib/CoreConfig$HideDotFiles;", "GetGetHideDotFilesHandler")]
			get {
				const string __id = "getHideDotFiles.()Lorg/eclipse/jgit/lib/CoreConfig$HideDotFiles;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.HideDotFiles> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isFileMode;
#pragma warning disable 0169
		static Delegate GetIsFileModeHandler ()
		{
			if (cb_isFileMode == null)
				cb_isFileMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFileMode);
			return cb_isFileMode;
		}

		static bool n_IsFileMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFileMode;
		}
#pragma warning restore 0169

		/// <returns>true if the execute bit on working files should be trusted.</returns>
		public virtual unsafe bool IsFileMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeOptions']/method[@name='isFileMode' and count(parameter)=0]"
			[Register ("isFileMode", "()Z", "GetIsFileModeHandler")]
			get {
				const string __id = "isFileMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSymLinks;
#pragma warning disable 0169
		static Delegate GetGetSymLinksHandler ()
		{
			if (cb_getSymLinks == null)
				cb_getSymLinks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSymLinks);
			return cb_getSymLinks;
		}

		static IntPtr n_GetSymLinks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SymLinks);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks SymLinks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='WorkingTreeOptions']/method[@name='getSymLinks' and count(parameter)=0]"
			[Register ("getSymLinks", "()Lorg/eclipse/jgit/lib/CoreConfig$SymLinks;", "GetGetSymLinksHandler")]
			get {
				const string __id = "getSymLinks.()Lorg/eclipse/jgit/lib/CoreConfig$SymLinks;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.CoreConfig.SymLinks> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
