using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Writes out refs to the <c>Constants#INFO_REFS</c> and
	/// <c>Constants#PACKED_REFS</c> files.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefWriter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefWriter", DoNotGenerateAcw=true)]
	public abstract partial class RefWriter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefWriter", typeof (RefWriter));

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

		protected RefWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="refs">the complete set of references. This should have been computed
		///            by applying updates to the advertised refs already discovered.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefWriter']/constructor[@name='RefWriter' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.lib.Ref&gt;']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public unsafe RefWriter (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> refs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Collection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_refs = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (refs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refs);
				global::System.GC.KeepAlive (refs);
			}
		}

		/// <param name="refs">the complete set of references. This should have been computed
		///            by applying updates to the advertised refs already discovered.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefWriter']/constructor[@name='RefWriter' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.lib.Ref&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe RefWriter (global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> refs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_refs = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (refs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_refs);
				global::System.GC.KeepAlive (refs);
			}
		}

		/// <param name="refs">the complete set of references. This should have been computed
		///            by applying updates to the advertised refs already discovered.</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefWriter']/constructor[@name='RefWriter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.RefList&lt;org.eclipse.jgit.lib.Ref&gt;']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/util/RefList;)V", "")]
		public unsafe RefWriter (global::Org.Eclipse.Jgit.Util.RefList refs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/util/RefList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((refs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (refs);
			}
		}

		static Delegate cb_writeFile_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteFile_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_writeFile_Ljava_lang_String_arrayB == null)
				cb_writeFile_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_WriteFile_Ljava_lang_String_arrayB);
			return cb_writeFile_Ljava_lang_String_arrayB;
		}

		static void n_WriteFile_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_file, IntPtr native_content)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var file = JNIEnv.GetString (native_file, JniHandleOwnership.DoNotTransfer);
			var content = (byte[]) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteFile (file, content);
			if (content != null)
				JNIEnv.CopyArray (content, native_content);
		}
#pragma warning restore 0169

		/// <param name="file">path to ref file.</param>
		/// <param name="content">byte content of file to be written.</param>
		/// <summary>Handles actual writing of ref files to the git repository, which may
		/// differ slightly depending on the destination and transport.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefWriter']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("writeFile", "(Ljava/lang/String;[B)V", "GetWriteFile_Ljava_lang_String_arrayBHandler")]
		protected abstract void WriteFile (string file, byte[] content);

		static Delegate cb_writeInfoRefs;
#pragma warning disable 0169
		static Delegate GetWriteInfoRefsHandler ()
		{
			if (cb_writeInfoRefs == null)
				cb_writeInfoRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WriteInfoRefs);
			return cb_writeInfoRefs;
		}

		static void n_WriteInfoRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteInfoRefs ();
		}
#pragma warning restore 0169

		/// <summary>Rebuild the <c>Constants#INFO_REFS</c>.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefWriter']/method[@name='writeInfoRefs' and count(parameter)=0]"
		[Register ("writeInfoRefs", "()V", "GetWriteInfoRefsHandler")]
		public virtual unsafe void WriteInfoRefs ()
		{
			const string __id = "writeInfoRefs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writePackedRefs;
#pragma warning disable 0169
		static Delegate GetWritePackedRefsHandler ()
		{
			if (cb_writePackedRefs == null)
				cb_writePackedRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WritePackedRefs);
			return cb_writePackedRefs;
		}

		static void n_WritePackedRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WritePackedRefs ();
		}
#pragma warning restore 0169

		/// <summary>Rebuild the <c>Constants#PACKED_REFS</c> file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefWriter']/method[@name='writePackedRefs' and count(parameter)=0]"
		[Register ("writePackedRefs", "()V", "GetWritePackedRefsHandler")]
		public virtual unsafe void WritePackedRefs ()
		{
			const string __id = "writePackedRefs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefWriter", DoNotGenerateAcw=true)]
	internal partial class RefWriterInvoker : RefWriter {
		public RefWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefWriter", typeof (RefWriterInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		/// <param name="file">path to ref file.</param>
		/// <param name="content">byte content of file to be written.</param>
		/// <summary>Handles actual writing of ref files to the git repository, which may
		/// differ slightly depending on the destination and transport.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefWriter']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("writeFile", "(Ljava/lang/String;[B)V", "GetWriteFile_Ljava_lang_String_arrayBHandler")]
		protected override unsafe void WriteFile (string file, byte[] content)
		{
			const string __id = "writeFile.(Ljava/lang/String;[B)V";
			IntPtr native_file = JNIEnv.NewString ((string)file);
			IntPtr native_content = JNIEnv.NewArray (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_file);
				__args [1] = new JniArgumentValue (native_content);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_file);
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
				global::System.GC.KeepAlive (content);
			}
		}

	}
}
