using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Treewalk.Filter {

	/// <summary>Includes tree entries only if they match one or more configured paths.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='PathFilterGroup']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/treewalk/filter/PathFilterGroup", DoNotGenerateAcw=true)]
	public partial class PathFilterGroup : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/treewalk/filter/PathFilterGroup", typeof (PathFilterGroup));

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

		protected PathFilterGroup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='PathFilterGroup']/constructor[@name='PathFilterGroup' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PathFilterGroup () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="paths">the paths to test against. Must have at least one entry.</param>
		/// <summary>Create a collection of path filters.</summary>
		/// <returns>a new filter for the list of paths supplied.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='PathFilterGroup']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.treewalk.filter.PathFilter&gt;']]"
		[Register ("create", "(Ljava/util/Collection;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter Create (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Treewalk.Filter.PathFilter> paths)
		{
			const string __id = "create.(Ljava/util/Collection;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
			IntPtr native_paths = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Treewalk.Filter.PathFilter>.ToLocalJniHandle (paths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paths);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_paths);
				global::System.GC.KeepAlive (paths);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='PathFilterGroup']/method[@name='createFromStrings' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("createFromStrings", "([Ljava/lang/String;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter CreateFromStrings (params string[] paths)
		{
			const string __id = "createFromStrings.([Ljava/lang/String;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
			IntPtr native_paths = JNIEnv.NewArray (paths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paths);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (paths != null) {
					JNIEnv.CopyArray (native_paths, paths);
					JNIEnv.DeleteLocalRef (native_paths);
				}
				global::System.GC.KeepAlive (paths);
			}
		}

		/// <param name="paths">the paths to test against. Must have at least one entry.</param>
		/// <summary>Create a collection of path filters from Java strings.</summary>
		/// <returns>a new filter for the list of paths supplied.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.treewalk.filter']/class[@name='PathFilterGroup']/method[@name='createFromStrings' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("createFromStrings", "(Ljava/util/Collection;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter CreateFromStrings (global::System.Collections.Generic.ICollection<string> paths)
		{
			const string __id = "createFromStrings.(Ljava/util/Collection;)Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
			IntPtr native_paths = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (paths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paths);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_paths);
				global::System.GC.KeepAlive (paths);
			}
		}

	}
}
