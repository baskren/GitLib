using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk.Filter {

	/// <summary>Includes a commit if any subfilters include the same commit.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='OrRevFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/OrRevFilter", DoNotGenerateAcw=true)]
	public abstract partial class OrRevFilter : global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/OrRevFilter", typeof (OrRevFilter));

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

		protected OrRevFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='OrRevFilter']/constructor[@name='OrRevFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OrRevFilter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="list">list of filters to match against. Must contain at least 2
		///            filters.</param>
		/// <summary>Create a filter around many filters, one of which must match.</summary>
		/// <returns>a filter that must match at least one input filter.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='OrRevFilter']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.revwalk.filter.RevFilter&gt;']]"
		[Register ("create", "(Ljava/util/Collection;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Create (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> list)
		{
			const string __id = "create.(Ljava/util/Collection;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			IntPtr native_list = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter>.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (list);
			}
		}

		/// <param name="a">first filter to test.</param>
		/// <param name="b">second filter to test.</param>
		/// <summary>Create a filter with two filters, one of which must match.</summary>
		/// <returns>a filter that must match at least one input filter.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='OrRevFilter']/method[@name='create' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.filter.RevFilter'] and parameter[2][@type='org.eclipse.jgit.revwalk.filter.RevFilter']]"
		[Register ("create", "(Lorg/eclipse/jgit/revwalk/filter/RevFilter;Lorg/eclipse/jgit/revwalk/filter/RevFilter;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Create (global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter a, global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter b)
		{
			const string __id = "create.(Lorg/eclipse/jgit/revwalk/filter/RevFilter;Lorg/eclipse/jgit/revwalk/filter/RevFilter;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		/// <param name="list">list of filters to match against. Must contain at least 2
		///            filters.</param>
		/// <summary>Create a filter around many filters, one of which must match.</summary>
		/// <returns>a filter that must match at least one input filter.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='OrRevFilter']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.filter.RevFilter[]']]"
		[Register ("create", "([Lorg/eclipse/jgit/revwalk/filter/RevFilter;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Create (global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter[] list)
		{
			const string __id = "create.([Lorg/eclipse/jgit/revwalk/filter/RevFilter;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			IntPtr native_list = JNIEnv.NewArray (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (list != null) {
					JNIEnv.CopyArray (native_list, list);
					JNIEnv.DeleteLocalRef (native_list);
				}
				global::System.GC.KeepAlive (list);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/OrRevFilter", DoNotGenerateAcw=true)]
	internal partial class OrRevFilterInvoker : OrRevFilter {
		public OrRevFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/OrRevFilter", typeof (OrRevFilterInvoker));

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
