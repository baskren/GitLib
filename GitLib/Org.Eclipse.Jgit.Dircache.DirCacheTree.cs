using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Dircache {

	/// <summary>Single tree record from the 'TREE' <c>DirCache</c> extension.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheTree']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/dircache/DirCacheTree", DoNotGenerateAcw=true)]
	public partial class DirCacheTree : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/dircache/DirCacheTree", typeof (DirCacheTree));

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

		protected DirCacheTree (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getChildCount;
#pragma warning disable 0169
		static Delegate GetGetChildCountHandler ()
		{
			if (cb_getChildCount == null)
				cb_getChildCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetChildCount);
			return cb_getChildCount;
		}

		static int n_GetChildCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheTree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChildCount;
		}
#pragma warning restore 0169

		/// <summary>Get the number of cached subtrees contained within this tree.</summary>
		/// <returns>number of child trees available through this tree.</returns>
		public virtual unsafe int ChildCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheTree']/method[@name='getChildCount' and count(parameter)=0]"
			[Register ("getChildCount", "()I", "GetGetChildCountHandler")]
			get {
				const string __id = "getChildCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getEntrySpan;
#pragma warning disable 0169
		static Delegate GetGetEntrySpanHandler ()
		{
			if (cb_getEntrySpan == null)
				cb_getEntrySpan = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEntrySpan);
			return cb_getEntrySpan;
		}

		static int n_GetEntrySpan (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheTree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntrySpan;
		}
#pragma warning restore 0169

		/// <summary>Get the number of entries this tree spans within the DirCache.</summary>
		/// <returns>total number of entries (recursively) contained within this tree.</returns>
		public virtual unsafe int EntrySpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheTree']/method[@name='getEntrySpan' and count(parameter)=0]"
			[Register ("getEntrySpan", "()I", "GetGetEntrySpanHandler")]
			get {
				const string __id = "getEntrySpan.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheTree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		/// <summary>Determine if this cache is currently valid.</summary>
		/// <returns>true if this tree is knows key details about itself; false if the
		///         tree needs to be regenerated.</returns>
		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheTree']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				const string __id = "isValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNameString;
#pragma warning disable 0169
		static Delegate GetGetNameStringHandler ()
		{
			if (cb_getNameString == null)
				cb_getNameString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNameString);
			return cb_getNameString;
		}

		static IntPtr n_GetNameString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheTree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NameString);
		}
#pragma warning restore 0169

		/// <summary>Get the tree's name within its parent.</summary>
		/// <returns>name of the tree. This does not contain any '/' characters.</returns>
		public virtual unsafe string NameString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheTree']/method[@name='getNameString' and count(parameter)=0]"
			[Register ("getNameString", "()Ljava/lang/String;", "GetGetNameStringHandler")]
			get {
				const string __id = "getNameString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPathString;
#pragma warning disable 0169
		static Delegate GetGetPathStringHandler ()
		{
			if (cb_getPathString == null)
				cb_getPathString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPathString);
			return cb_getPathString;
		}

		static IntPtr n_GetPathString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheTree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PathString);
		}
#pragma warning restore 0169

		/// <summary>Get the tree's path within the repository.</summary>
		/// <returns>path of the tree, relative to the repository root. If this is not
		///         the root tree the path ends with '/'. The root tree's path string
		///         is the empty string ("").</returns>
		public virtual unsafe string PathString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheTree']/method[@name='getPathString' and count(parameter)=0]"
			[Register ("getPathString", "()Ljava/lang/String;", "GetGetPathStringHandler")]
			get {
				const string __id = "getPathString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChild_I;
#pragma warning disable 0169
		static Delegate GetGetChild_IHandler ()
		{
			if (cb_getChild_I == null)
				cb_getChild_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetChild_I);
			return cb_getChild_I;
		}

		static IntPtr n_GetChild_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheTree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetChild (i));
		}
#pragma warning restore 0169

		/// <param name="i">index of the child to obtain.</param>
		/// <summary>Get the i-th child cache tree.</summary>
		/// <returns>the child tree.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.dircache']/class[@name='DirCacheTree']/method[@name='getChild' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getChild", "(I)Lorg/eclipse/jgit/dircache/DirCacheTree;", "GetGetChild_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Dircache.DirCacheTree GetChild (int i)
		{
			const string __id = "getChild.(I)Lorg/eclipse/jgit/dircache/DirCacheTree;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Dircache.DirCacheTree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
