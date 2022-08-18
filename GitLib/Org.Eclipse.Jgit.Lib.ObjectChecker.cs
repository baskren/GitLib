using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Verifies that an object is formatted correctly.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectChecker", DoNotGenerateAcw=true)]
	public partial class ObjectChecker : global::Java.Lang.Object {

		/// <summary>Header "author "</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/field[@name='author']"
		[Register ("author")]
		public static IList<byte> Author {
			get {
				const string __id = "author.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Header "committer "</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/field[@name='committer']"
		[Register ("committer")]
		public static IList<byte> Committer {
			get {
				const string __id = "committer.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Header "encoding "</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/field[@name='encoding']"
		[Register ("encoding")]
		public static IList<byte> Encoding {
			get {
				const string __id = "encoding.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Header "object "</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/field[@name='object']"
		[Register ("object")]
		public static IList<byte> Object {
			get {
				const string __id = "object.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Header "parent "</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/field[@name='parent']"
		[Register ("parent")]
		public static IList<byte> Parent {
			get {
				const string __id = "parent.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Header "tag "</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/field[@name='tag']"
		[Register ("tag")]
		public static IList<byte> Tag {
			get {
				const string __id = "tag.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/field[@name='tagger']"
		[Register ("tagger")]
		public static IList<byte> Tagger {
			get {
				const string __id = "tagger.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Header "tree "</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/field[@name='tree']"
		[Register ("tree")]
		public static IList<byte> Tree {
			get {
				const string __id = "tree.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Header "type "</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/field[@name='type']"
		[Register ("type")]
		public static IList<byte> Type {
			get {
				const string __id = "type.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectChecker", typeof (ObjectChecker));

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

		protected ObjectChecker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/constructor[@name='ObjectChecker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectChecker () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_check_IarrayB;
#pragma warning disable 0169
		static Delegate GetCheck_IarrayBHandler ()
		{
			if (cb_check_IarrayB == null)
				cb_check_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Check_IarrayB);
			return cb_check_IarrayB;
		}

		static void n_Check_IarrayB (IntPtr jnienv, IntPtr native__this, int objType, IntPtr native_raw)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Check (objType, raw);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		/// <param name="objType">type of the object. Must be a valid object type code in
		///            <c>Constants</c>.</param>
		/// <param name="raw">the raw data which comprises the object. This should be in the
		///            canonical format (that is the format used to generate the
		///            ObjectId of the object). The array is never modified.</param>
		/// <summary>Check an object for parsing errors.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='check' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("check", "(I[B)V", "GetCheck_IarrayBHandler")]
		public virtual unsafe void Check (int objType, byte[] raw)
		{
			const string __id = "check.(I[B)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (objType);
				__args [1] = new JniArgumentValue (native_raw);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_checkBlob_arrayB;
#pragma warning disable 0169
		static Delegate GetCheckBlob_arrayBHandler ()
		{
			if (cb_checkBlob_arrayB == null)
				cb_checkBlob_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CheckBlob_arrayB);
			return cb_checkBlob_arrayB;
		}

		static void n_CheckBlob_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_raw)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CheckBlob (raw);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		/// <param name="raw">the blob data. The array is never modified.</param>
		/// <summary>Check a blob for errors.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='checkBlob' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("checkBlob", "([B)V", "GetCheckBlob_arrayBHandler")]
		public virtual unsafe void CheckBlob (byte[] raw)
		{
			const string __id = "checkBlob.([B)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_raw);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_checkCommit_arrayB;
#pragma warning disable 0169
		static Delegate GetCheckCommit_arrayBHandler ()
		{
			if (cb_checkCommit_arrayB == null)
				cb_checkCommit_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CheckCommit_arrayB);
			return cb_checkCommit_arrayB;
		}

		static void n_CheckCommit_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_raw)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CheckCommit (raw);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		/// <param name="raw">the commit data. The array is never modified.</param>
		/// <summary>Check a commit for errors.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='checkCommit' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("checkCommit", "([B)V", "GetCheckCommit_arrayBHandler")]
		public virtual unsafe void CheckCommit (byte[] raw)
		{
			const string __id = "checkCommit.([B)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_raw);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_checkPath_arrayBII;
#pragma warning disable 0169
		static Delegate GetCheckPath_arrayBIIHandler ()
		{
			if (cb_checkPath_arrayBII == null)
				cb_checkPath_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_CheckPath_arrayBII);
			return cb_checkPath_arrayBII;
		}

		static void n_CheckPath_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_raw, int ptr, int end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CheckPath (raw, ptr, end);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		/// <param name="raw">buffer to scan.</param>
		/// <param name="ptr">offset to first byte of the name.</param>
		/// <param name="end">offset to one past last byte of name.</param>
		/// <summary>Check tree path entry for validity.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='checkPath' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("checkPath", "([BII)V", "GetCheckPath_arrayBIIHandler")]
		public virtual unsafe void CheckPath (byte[] raw, int ptr, int end)
		{
			const string __id = "checkPath.([BII)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (end);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_checkPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckPath_Ljava_lang_String_Handler ()
		{
			if (cb_checkPath_Ljava_lang_String_ == null)
				cb_checkPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CheckPath_Ljava_lang_String_);
			return cb_checkPath_Ljava_lang_String_;
		}

		static void n_CheckPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.CheckPath (path);
		}
#pragma warning restore 0169

		/// <param name="path">path string to scan.</param>
		/// <summary>Check tree path entry for validity.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='checkPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkPath", "(Ljava/lang/String;)V", "GetCheckPath_Ljava_lang_String_Handler")]
		public virtual unsafe void CheckPath (string path)
		{
			const string __id = "checkPath.(Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_checkPathSegment_arrayBII;
#pragma warning disable 0169
		static Delegate GetCheckPathSegment_arrayBIIHandler ()
		{
			if (cb_checkPathSegment_arrayBII == null)
				cb_checkPathSegment_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_CheckPathSegment_arrayBII);
			return cb_checkPathSegment_arrayBII;
		}

		static void n_CheckPathSegment_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_raw, int ptr, int end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CheckPathSegment (raw, ptr, end);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		/// <param name="raw">buffer to scan.</param>
		/// <param name="ptr">offset to first byte of the name.</param>
		/// <param name="end">offset to one past last byte of name.</param>
		/// <summary>Check tree path entry for validity.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='checkPathSegment' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("checkPathSegment", "([BII)V", "GetCheckPathSegment_arrayBIIHandler")]
		public virtual unsafe void CheckPathSegment (byte[] raw, int ptr, int end)
		{
			const string __id = "checkPathSegment.([BII)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (ptr);
				__args [2] = new JniArgumentValue (end);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_checkTag_arrayB;
#pragma warning disable 0169
		static Delegate GetCheckTag_arrayBHandler ()
		{
			if (cb_checkTag_arrayB == null)
				cb_checkTag_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CheckTag_arrayB);
			return cb_checkTag_arrayB;
		}

		static void n_CheckTag_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_raw)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CheckTag (raw);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		/// <param name="raw">the tag data. The array is never modified.</param>
		/// <summary>Check an annotated tag for errors.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='checkTag' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("checkTag", "([B)V", "GetCheckTag_arrayBHandler")]
		public virtual unsafe void CheckTag (byte[] raw)
		{
			const string __id = "checkTag.([B)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_raw);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_checkTree_arrayB;
#pragma warning disable 0169
		static Delegate GetCheckTree_arrayBHandler ()
		{
			if (cb_checkTree_arrayB == null)
				cb_checkTree_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CheckTree_arrayB);
			return cb_checkTree_arrayB;
		}

		static void n_CheckTree_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_raw)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CheckTree (raw);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		/// <param name="raw">the raw tree data. The array is never modified.</param>
		/// <summary>Check a canonical formatted tree for errors.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='checkTree' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("checkTree", "([B)V", "GetCheckTree_arrayBHandler")]
		public virtual unsafe void CheckTree (byte[] raw)
		{
			const string __id = "checkTree.([B)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_raw);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_setAllowLeadingZeroFileMode_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowLeadingZeroFileMode_ZHandler ()
		{
			if (cb_setAllowLeadingZeroFileMode_Z == null)
				cb_setAllowLeadingZeroFileMode_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAllowLeadingZeroFileMode_Z);
			return cb_setAllowLeadingZeroFileMode_Z;
		}

		static IntPtr n_SetAllowLeadingZeroFileMode_Z (IntPtr jnienv, IntPtr native__this, bool allow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAllowLeadingZeroFileMode (allow));
		}
#pragma warning restore 0169

		/// <param name="allow">allow leading zero mode.</param>
		/// <summary>Enable accepting leading zero mode in tree entries.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='setAllowLeadingZeroFileMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowLeadingZeroFileMode", "(Z)Lorg/eclipse/jgit/lib/ObjectChecker;", "GetSetAllowLeadingZeroFileMode_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectChecker SetAllowLeadingZeroFileMode (bool allow)
		{
			const string __id = "setAllowLeadingZeroFileMode.(Z)Lorg/eclipse/jgit/lib/ObjectChecker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (allow);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSafeForMacOS_Z;
#pragma warning disable 0169
		static Delegate GetSetSafeForMacOS_ZHandler ()
		{
			if (cb_setSafeForMacOS_Z == null)
				cb_setSafeForMacOS_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetSafeForMacOS_Z);
			return cb_setSafeForMacOS_Z;
		}

		static IntPtr n_SetSafeForMacOS_Z (IntPtr jnienv, IntPtr native__this, bool mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSafeForMacOS (mac));
		}
#pragma warning restore 0169

		/// <param name="mac">true if Mac OS X name checking should be performed.</param>
		/// <summary>Restrict trees to only names legal on Mac OS X platforms.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='setSafeForMacOS' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSafeForMacOS", "(Z)Lorg/eclipse/jgit/lib/ObjectChecker;", "GetSetSafeForMacOS_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectChecker SetSafeForMacOS (bool mac)
		{
			const string __id = "setSafeForMacOS.(Z)Lorg/eclipse/jgit/lib/ObjectChecker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mac);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSafeForWindows_Z;
#pragma warning disable 0169
		static Delegate GetSetSafeForWindows_ZHandler ()
		{
			if (cb_setSafeForWindows_Z == null)
				cb_setSafeForWindows_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetSafeForWindows_Z);
			return cb_setSafeForWindows_Z;
		}

		static IntPtr n_SetSafeForWindows_Z (IntPtr jnienv, IntPtr native__this, bool win)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSafeForWindows (win));
		}
#pragma warning restore 0169

		/// <param name="win">true if Windows name checking should be performed.</param>
		/// <summary>Restrict trees to only names legal on Windows platforms.</summary>
		/// <returns>
		///   <c>this</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectChecker']/method[@name='setSafeForWindows' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSafeForWindows", "(Z)Lorg/eclipse/jgit/lib/ObjectChecker;", "GetSetSafeForWindows_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectChecker SetSafeForWindows (bool win)
		{
			const string __id = "setSafeForWindows.(Z)Lorg/eclipse/jgit/lib/ObjectChecker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (win);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
