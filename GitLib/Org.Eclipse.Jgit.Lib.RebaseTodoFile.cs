using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Offers methods to read and write files formatted like the git-rebase-todo
	/// file</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoFile']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RebaseTodoFile", DoNotGenerateAcw=true)]
	public partial class RebaseTodoFile : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RebaseTodoFile", typeof (RebaseTodoFile));

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

		protected RebaseTodoFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoFile']/constructor[@name='RebaseTodoFile' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe RebaseTodoFile (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_readRebaseTodo_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetReadRebaseTodo_Ljava_lang_String_ZHandler ()
		{
			if (cb_readRebaseTodo_Ljava_lang_String_Z == null)
				cb_readRebaseTodo_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_ReadRebaseTodo_Ljava_lang_String_Z);
			return cb_readRebaseTodo_Ljava_lang_String_Z;
		}

		static IntPtr n_ReadRebaseTodo_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_path, bool includeComments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.ToLocalJniHandle (__this.ReadRebaseTodo (path, includeComments));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path to the file relative to the repository's git-dir. E.g.
		///            "rebase-merge/git-rebase-todo" or "rebase-append/done"</param>
		/// <param name="includeComments">&lt;code&gt;true&lt;/code&gt; if also comments should be reported</param>
		/// <summary>Read a file formatted like the git-rebase-todo file.</summary>
		/// <returns>the list of steps</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoFile']/method[@name='readRebaseTodo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("readRebaseTodo", "(Ljava/lang/String;Z)Ljava/util/List;", "GetReadRebaseTodo_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> ReadRebaseTodo (string path, bool includeComments)
		{
			const string __id = "readRebaseTodo.(Ljava/lang/String;Z)Ljava/util/List;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (includeComments);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_writeRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetWriteRebaseTodoFile_Ljava_lang_String_Ljava_util_List_ZHandler ()
		{
			if (cb_writeRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z == null)
				cb_writeRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_WriteRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z);
			return cb_writeRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z;
		}

		static void n_WriteRebaseTodoFile_Ljava_lang_String_Ljava_util_List_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_steps, bool append)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RebaseTodoFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			var steps = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.FromJniHandle (native_steps, JniHandleOwnership.DoNotTransfer);
			__this.WriteRebaseTodoFile (path, steps, append);
		}
#pragma warning restore 0169

		/// <param name="path">path to the file relative to the repository's git-dir. E.g.
		///            "rebase-merge/git-rebase-todo" or "rebase-append/done"</param>
		/// <param name="steps">the steps to be written</param>
		/// <param name="append">whether to append to an existing file or to write a new file</param>
		/// <summary>Write a file formatted like a git-rebase-todo file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RebaseTodoFile']/method[@name='writeRebaseTodoFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.lib.RebaseTodoLine&gt;'] and parameter[3][@type='boolean']]"
		[Register ("writeRebaseTodoFile", "(Ljava/lang/String;Ljava/util/List;Z)V", "GetWriteRebaseTodoFile_Ljava_lang_String_Ljava_util_List_ZHandler")]
		public virtual unsafe void WriteRebaseTodoFile (string path, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine> steps, bool append)
		{
			const string __id = "writeRebaseTodoFile.(Ljava/lang/String;Ljava/util/List;Z)V";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			IntPtr native_steps = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.RebaseTodoLine>.ToLocalJniHandle (steps);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_steps);
				__args [2] = new JniArgumentValue (append);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_steps);
				global::System.GC.KeepAlive (steps);
			}
		}

	}
}
