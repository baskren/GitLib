using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk.Filter {

	/// <summary>Matches only commits with some/all RevFlags already set.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFlagFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/RevFlagFilter", DoNotGenerateAcw=true)]
	public abstract partial class RevFlagFilter : global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/RevFlagFilter", typeof (RevFlagFilter));

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

		protected RevFlagFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="a">the flag to test.</param>
		/// <summary>Create a new filter that tests for a single flag.</summary>
		/// <returns>filter that selects only commits with flag &lt;code&gt;a&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFlagFilter']/method[@name='has' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("has", "(Lorg/eclipse/jgit/revwalk/RevFlag;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Has (global::Org.Eclipse.Jgit.Revwalk.RevFlag a)
		{
			const string __id = "has.(Lorg/eclipse/jgit/revwalk/RevFlag;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFlagFilter']/method[@name='hasAll' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag...']]"
		[Register ("hasAll", "([Lorg/eclipse/jgit/revwalk/RevFlag;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter HasAll (params global::Org.Eclipse.Jgit.Revwalk.RevFlag[] a)
		{
			const string __id = "hasAll.([Lorg/eclipse/jgit/revwalk/RevFlag;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			IntPtr native_a = JNIEnv.NewArray (a);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_a);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				global::System.GC.KeepAlive (a);
			}
		}

		/// <param name="a">set of flags to test.</param>
		/// <summary>Create a new filter that tests all flags in a set.</summary>
		/// <returns>filter that selects only commits with all flags in &lt;code&gt;a&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFlagFilter']/method[@name='hasAll' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlagSet']]"
		[Register ("hasAll", "(Lorg/eclipse/jgit/revwalk/RevFlagSet;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter HasAll (global::Org.Eclipse.Jgit.Revwalk.RevFlagSet a)
		{
			const string __id = "hasAll.(Lorg/eclipse/jgit/revwalk/RevFlagSet;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFlagFilter']/method[@name='hasAny' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag...']]"
		[Register ("hasAny", "([Lorg/eclipse/jgit/revwalk/RevFlag;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter HasAny (params global::Org.Eclipse.Jgit.Revwalk.RevFlag[] a)
		{
			const string __id = "hasAny.([Lorg/eclipse/jgit/revwalk/RevFlag;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			IntPtr native_a = JNIEnv.NewArray (a);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_a);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				global::System.GC.KeepAlive (a);
			}
		}

		/// <param name="a">set of flags to test.</param>
		/// <summary>Create a new filter that tests for any flag in a set.</summary>
		/// <returns>filter that selects only commits with any flag in &lt;code&gt;a&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFlagFilter']/method[@name='hasAny' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlagSet']]"
		[Register ("hasAny", "(Lorg/eclipse/jgit/revwalk/RevFlagSet;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter HasAny (global::Org.Eclipse.Jgit.Revwalk.RevFlagSet a)
		{
			const string __id = "hasAny.(Lorg/eclipse/jgit/revwalk/RevFlagSet;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/RevFlagFilter", DoNotGenerateAcw=true)]
	internal partial class RevFlagFilterInvoker : RevFlagFilter {
		public RevFlagFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/RevFlagFilter", typeof (RevFlagFilterInvoker));

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

		/// <summary>Clone this revision filter, including its parameters.</summary>
		/// <returns>another copy of this filter, suitable for another thread.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "GetCloneHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Clone ()
		{
			const string __id = "clone.()Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="walker">the active walker this filter is being invoked from within.</param>
		/// <param name="cmit">the commit currently being tested. The commit has been parsed
		///            and its body is available for inspection only if the filter
		///            returns true from <c>#requiresCommitBody()</c>.</param>
		/// <summary>Determine if the supplied commit should be included in results.</summary>
		/// <returns>true to include this commit in the results; false to have this
		///         commit be omitted entirely from the results.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='RevFilter']/method[@name='include' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("include", "(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;)Z", "GetInclude_Lorg_eclipse_jgit_revwalk_RevWalk_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public override unsafe bool Include (global::Org.Eclipse.Jgit.Revwalk.RevWalk walker, global::Org.Eclipse.Jgit.Revwalk.RevCommit cmit)
		{
			const string __id = "include.(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((walker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walker).Handle);
				__args [1] = new JniArgumentValue ((cmit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmit).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (walker);
				global::System.GC.KeepAlive (cmit);
			}
		}

	}
}
