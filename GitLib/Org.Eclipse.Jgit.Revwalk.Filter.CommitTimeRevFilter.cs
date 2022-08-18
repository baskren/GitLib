using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk.Filter {

	/// <summary>Selects commits based upon the commit time field.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='CommitTimeRevFilter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/CommitTimeRevFilter", DoNotGenerateAcw=true)]
	public abstract partial class CommitTimeRevFilter : global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/CommitTimeRevFilter", typeof (CommitTimeRevFilter));

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

		protected CommitTimeRevFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="ts">the point in time to cut on.</param>
		/// <summary>Create a new filter to select commits after a given date/time.</summary>
		/// <returns>a new filter to select commits on or after &lt;code&gt;ts&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='CommitTimeRevFilter']/method[@name='after' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("after", "(Ljava/util/Date;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter After (global::Java.Util.Date ts)
		{
			const string __id = "after.(Ljava/util/Date;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ts == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ts).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ts);
			}
		}

		/// <param name="ts">the point in time to cut on, in milliseconds.</param>
		/// <summary>Create a new filter to select commits after a given date/time.</summary>
		/// <returns>a new filter to select commits on or after &lt;code&gt;ts&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='CommitTimeRevFilter']/method[@name='after' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("after", "(J)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter After (long ts)
		{
			const string __id = "after.(J)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ts);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="ts">the point in time to cut on.</param>
		/// <summary>Create a new filter to select commits before a given date/time.</summary>
		/// <returns>a new filter to select commits on or before &lt;code&gt;ts&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='CommitTimeRevFilter']/method[@name='before' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("before", "(Ljava/util/Date;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Before (global::Java.Util.Date ts)
		{
			const string __id = "before.(Ljava/util/Date;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ts == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ts).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ts);
			}
		}

		/// <param name="ts">the point in time to cut on, in milliseconds</param>
		/// <summary>Create a new filter to select commits before a given date/time.</summary>
		/// <returns>a new filter to select commits on or before &lt;code&gt;ts&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='CommitTimeRevFilter']/method[@name='before' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("before", "(J)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Before (long ts)
		{
			const string __id = "before.(J)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ts);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="since">the point in time to cut on.</param>
		/// <param name="until">the point in time to cut off.</param>
		/// <summary>Create a new filter to select commits after or equal a given date/time &lt;code&gt;since&lt;/code&gt;
		/// and before or equal a given date/time &lt;code&gt;until&lt;/code&gt;.</summary>
		/// <returns>a new filter to select commits between the given date/times.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='CommitTimeRevFilter']/method[@name='between' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.Date']]"
		[Register ("between", "(Ljava/util/Date;Ljava/util/Date;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Between (global::Java.Util.Date since, global::Java.Util.Date until)
		{
			const string __id = "between.(Ljava/util/Date;Ljava/util/Date;)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((since == null) ? IntPtr.Zero : ((global::Java.Lang.Object) since).Handle);
				__args [1] = new JniArgumentValue ((until == null) ? IntPtr.Zero : ((global::Java.Lang.Object) until).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (since);
				global::System.GC.KeepAlive (until);
			}
		}

		/// <param name="since">the point in time to cut on, in milliseconds.</param>
		/// <param name="until">the point in time to cut off, in millisconds.</param>
		/// <summary>Create a new filter to select commits after or equal a given date/time &lt;code&gt;since&lt;/code&gt;
		/// and before or equal a given date/time &lt;code&gt;until&lt;/code&gt;.</summary>
		/// <returns>a new filter to select commits between the given date/times.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk.filter']/class[@name='CommitTimeRevFilter']/method[@name='between' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("between", "(JJ)Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter Between (long since, long until)
		{
			const string __id = "between.(JJ)Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (since);
				__args [1] = new JniArgumentValue (until);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/filter/CommitTimeRevFilter", DoNotGenerateAcw=true)]
	internal partial class CommitTimeRevFilterInvoker : CommitTimeRevFilter {
		public CommitTimeRevFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/filter/CommitTimeRevFilter", typeof (CommitTimeRevFilterInvoker));

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
