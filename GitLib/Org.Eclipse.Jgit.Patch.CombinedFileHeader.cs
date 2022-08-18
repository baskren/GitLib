using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Patch {

	/// <summary>A file in the Git "diff --cc" or "diff --combined" format.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='CombinedFileHeader']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/patch/CombinedFileHeader", DoNotGenerateAcw=true)]
	public partial class CombinedFileHeader : global::Org.Eclipse.Jgit.Patch.FileHeader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/patch/CombinedFileHeader", typeof (CombinedFileHeader));

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

		protected CombinedFileHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getParentCount;
#pragma warning disable 0169
		static Delegate GetGetParentCountHandler ()
		{
			if (cb_getParentCount == null)
				cb_getParentCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetParentCount);
			return cb_getParentCount;
		}

		static int n_GetParentCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.CombinedFileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ParentCount;
		}
#pragma warning restore 0169

		/// <returns>number of ancestor revisions mentioned in this diff.</returns>
		public virtual unsafe int ParentCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='CombinedFileHeader']/method[@name='getParentCount' and count(parameter)=0]"
			[Register ("getParentCount", "()I", "GetGetParentCountHandler")]
			get {
				const string __id = "getParentCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOldId_I;
#pragma warning disable 0169
		static Delegate GetGetOldId_IHandler ()
		{
			if (cb_getOldId_I == null)
				cb_getOldId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetOldId_I);
			return cb_getOldId_I;
		}

		static IntPtr n_GetOldId_I (IntPtr jnienv, IntPtr native__this, int nthParent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.CombinedFileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOldId (nthParent));
		}
#pragma warning restore 0169

		/// <param name="nthParent">the ancestor to get the object id of</param>
		/// <summary>Get the ObjectId of the nth ancestor</summary>
		/// <returns>the id of the requested ancestor.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='CombinedFileHeader']/method[@name='getOldId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOldId", "(I)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "GetGetOldId_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId GetOldId (int nthParent)
		{
			const string __id = "getOldId.(I)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nthParent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getOldMode_I;
#pragma warning disable 0169
		static Delegate GetGetOldMode_IHandler ()
		{
			if (cb_getOldMode_I == null)
				cb_getOldMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetOldMode_I);
			return cb_getOldMode_I;
		}

		static IntPtr n_GetOldMode_I (IntPtr jnienv, IntPtr native__this, int nthParent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.CombinedFileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOldMode (nthParent));
		}
#pragma warning restore 0169

		/// <param name="nthParent">the ancestor to get the mode of</param>
		/// <summary>Get the file mode of the nth ancestor</summary>
		/// <returns>the mode of the requested ancestor.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='CombinedFileHeader']/method[@name='getOldMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOldMode", "(I)Lorg/eclipse/jgit/lib/FileMode;", "GetGetOldMode_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode GetOldMode (int nthParent)
		{
			const string __id = "getOldMode.(I)Lorg/eclipse/jgit/lib/FileMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nthParent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getScriptText_arrayLjava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetGetScriptText_arrayLjava_nio_charset_Charset_Handler ()
		{
			if (cb_getScriptText_arrayLjava_nio_charset_Charset_ == null)
				cb_getScriptText_arrayLjava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetScriptText_arrayLjava_nio_charset_Charset_);
			return cb_getScriptText_arrayLjava_nio_charset_Charset_;
		}

		static IntPtr n_GetScriptText_arrayLjava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_charsetGuess)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.CombinedFileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var charsetGuess = (global::Java.Nio.Charset.Charset[]) JNIEnv.GetArray (native_charsetGuess, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.Charset.Charset));
			IntPtr __ret = JNIEnv.NewString (__this.GetScriptText (charsetGuess));
			if (charsetGuess != null)
				JNIEnv.CopyArray (charsetGuess, native_charsetGuess);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="charsetGuess">optional array to suggest the character set to use when
		///            decoding each file's line. If supplied the array must have a
		///            length of &lt;code&gt;<c>#getParentCount()</c> + 1&lt;/code&gt;
		///            representing the old revision character sets and the new
		///            revision character set.</param>
		/// <summary>Convert the patch script for this file into a string.</summary>
		/// <returns>the patch script, as a Unicode string.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='CombinedFileHeader']/method[@name='getScriptText' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset[]']]"
		[Register ("getScriptText", "([Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetGetScriptText_arrayLjava_nio_charset_Charset_Handler")]
		public virtual unsafe string GetScriptText (global::Java.Nio.Charset.Charset[] charsetGuess)
		{
			const string __id = "getScriptText.([Ljava/nio/charset/Charset;)Ljava/lang/String;";
			IntPtr native_charsetGuess = JNIEnv.NewArray (charsetGuess);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_charsetGuess);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (charsetGuess != null) {
					JNIEnv.CopyArray (native_charsetGuess, charsetGuess);
					JNIEnv.DeleteLocalRef (native_charsetGuess);
				}
				global::System.GC.KeepAlive (charsetGuess);
			}
		}

		static Delegate cb_parseIndexLine_II;
#pragma warning disable 0169
		static Delegate GetParseIndexLine_IIHandler ()
		{
			if (cb_parseIndexLine_II == null)
				cb_parseIndexLine_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_ParseIndexLine_II);
			return cb_parseIndexLine_II;
		}

		static void n_ParseIndexLine_II (IntPtr jnienv, IntPtr native__this, int ptr, int eol)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.CombinedFileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseIndexLine (ptr, eol);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='CombinedFileHeader']/method[@name='parseIndexLine' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("parseIndexLine", "(II)V", "GetParseIndexLine_IIHandler")]
		protected virtual unsafe void ParseIndexLine (int ptr, int eol)
		{
			const string __id = "parseIndexLine.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (ptr);
				__args [1] = new JniArgumentValue (eol);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_parseNewFileMode_II;
#pragma warning disable 0169
		static Delegate GetParseNewFileMode_IIHandler ()
		{
			if (cb_parseNewFileMode_II == null)
				cb_parseNewFileMode_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_ParseNewFileMode_II);
			return cb_parseNewFileMode_II;
		}

		static void n_ParseNewFileMode_II (IntPtr jnienv, IntPtr native__this, int ptr, int eol)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Patch.CombinedFileHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseNewFileMode (ptr, eol);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.patch']/class[@name='CombinedFileHeader']/method[@name='parseNewFileMode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("parseNewFileMode", "(II)V", "GetParseNewFileMode_IIHandler")]
		protected virtual unsafe void ParseNewFileMode (int ptr, int eol)
		{
			const string __id = "parseNewFileMode.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (ptr);
				__args [1] = new JniArgumentValue (eol);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
