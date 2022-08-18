using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk {

	/// <summary>Specialized TreeWalk to detect directory-file (D/F) name conflicts.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='NameConflictTreeWalk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/NameConflictTreeWalk", DoNotGenerateAcw=true)]
	public partial class NameConflictTreeWalk : global::Org.Eclipse.Jgit.Treewalk.TreeWalk {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/NameConflictTreeWalk", typeof (NameConflictTreeWalk));

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

		protected NameConflictTreeWalk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="or">the reader the walker will obtain tree data from.</param>
		/// <summary>Create a new tree walker for a given repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='NameConflictTreeWalk']/constructor[@name='NameConflictTreeWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectReader;)V", "")]
		public unsafe NameConflictTreeWalk (global::Org.Eclipse.Jgit.Lib.ObjectReader or) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectReader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((or == null) ? IntPtr.Zero : ((global::Java.Lang.Object) or).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (or);
			}
		}

		/// <param name="repo">the repository the walker will obtain data from.</param>
		/// <summary>Create a new tree walker for a given repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='NameConflictTreeWalk']/constructor[@name='NameConflictTreeWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe NameConflictTreeWalk (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isDirectoryFileConflict;
#pragma warning disable 0169
		static Delegate GetIsDirectoryFileConflictHandler ()
		{
			if (cb_isDirectoryFileConflict == null)
				cb_isDirectoryFileConflict = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDirectoryFileConflict);
			return cb_isDirectoryFileConflict;
		}

		static bool n_IsDirectoryFileConflict (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.NameConflictTreeWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDirectoryFileConflict;
		}
#pragma warning restore 0169

		/// <summary>True if the current entry is covered by a directory/file conflict.</summary>
		/// <returns>&lt;code&gt;true&lt;/code&gt; if the current entry is covered by a
		///         directory/file conflict, &lt;code&gt;false&lt;/code&gt; otherwise</returns>
		public virtual unsafe bool IsDirectoryFileConflict {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk']/class[@name='NameConflictTreeWalk']/method[@name='isDirectoryFileConflict' and count(parameter)=0]"
			[Register ("isDirectoryFileConflict", "()Z", "GetIsDirectoryFileConflictHandler")]
			get {
				const string __id = "isDirectoryFileConflict.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
