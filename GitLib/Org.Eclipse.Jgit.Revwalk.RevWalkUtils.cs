using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Utility methods for <c>RevWalk</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalkUtils']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevWalkUtils", DoNotGenerateAcw=true)]
	public sealed partial class RevWalkUtils : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevWalkUtils", typeof (RevWalkUtils));

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

		internal RevWalkUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="walk">the rev walk to use</param>
		/// <param name="start">the commit to start counting from</param>
		/// <param name="end">the commit where counting should end, or null if counting
		///            should be done until there are no more commits</param>
		/// <summary>Count the number of commits that are reachable from &lt;code&gt;start&lt;/code&gt;
		/// until a commit that is reachable from &lt;code&gt;end&lt;/code&gt; is encountered.</summary>
		/// <returns>the number of commits</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalkUtils']/method[@name='count' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[3][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("count", "(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)I", "")]
		public static unsafe int Count (global::Org.Eclipse.Jgit.Revwalk.RevWalk walk, global::Org.Eclipse.Jgit.Revwalk.RevCommit start, global::Org.Eclipse.Jgit.Revwalk.RevCommit end)
		{
			const string __id = "count.(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				__args [1] = new JniArgumentValue ((start == null) ? IntPtr.Zero : ((global::Java.Lang.Object) start).Handle);
				__args [2] = new JniArgumentValue ((end == null) ? IntPtr.Zero : ((global::Java.Lang.Object) end).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (walk);
				global::System.GC.KeepAlive (start);
				global::System.GC.KeepAlive (end);
			}
		}

		/// <param name="walk">the rev walk to use</param>
		/// <param name="start">the commit to start counting from</param>
		/// <param name="end">the commit where counting should end, or null if counting
		///            should be done until there are no more commits</param>
		/// <summary>Find commits that are reachable from &lt;code&gt;start&lt;/code&gt; until a commit
		/// that is reachable from &lt;code&gt;end&lt;/code&gt; is encountered.</summary>
		/// <returns>the commits found</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalkUtils']/method[@name='find' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[3][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("find", "(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Revwalk.RevCommit> Find (global::Org.Eclipse.Jgit.Revwalk.RevWalk walk, global::Org.Eclipse.Jgit.Revwalk.RevCommit start, global::Org.Eclipse.Jgit.Revwalk.RevCommit end)
		{
			const string __id = "find.(Lorg/eclipse/jgit/revwalk/RevWalk;Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				__args [1] = new JniArgumentValue ((start == null) ? IntPtr.Zero : ((global::Java.Lang.Object) start).Handle);
				__args [2] = new JniArgumentValue ((end == null) ? IntPtr.Zero : ((global::Java.Lang.Object) end).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Revwalk.RevCommit>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (walk);
				global::System.GC.KeepAlive (start);
				global::System.GC.KeepAlive (end);
			}
		}

		/// <param name="commit">the commit we are looking at</param>
		/// <param name="revWalk">The RevWalk to be used.</param>
		/// <param name="refs">the set of branches we want to see reachability from</param>
		/// <summary>Find the list of branches a given commit is reachable from when following
		/// parent.</summary>
		/// <returns>the list of branches a given commit is reachable from</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalkUtils']/method[@name='findBranchesReachableFrom' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevWalk'] and parameter[3][@type='java.util.Collection&lt;org.eclipse.jgit.lib.Ref&gt;']]"
		[Register ("findBranchesReachableFrom", "(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevWalk;Ljava/util/Collection;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> FindBranchesReachableFrom (global::Org.Eclipse.Jgit.Revwalk.RevCommit commit, global::Org.Eclipse.Jgit.Revwalk.RevWalk revWalk, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> refs)
		{
			const string __id = "findBranchesReachableFrom.(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevWalk;Ljava/util/Collection;)Ljava/util/List;";
			IntPtr native_refs = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (refs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				__args [1] = new JniArgumentValue ((revWalk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) revWalk).Handle);
				__args [2] = new JniArgumentValue (native_refs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refs);
				global::System.GC.KeepAlive (commit);
				global::System.GC.KeepAlive (revWalk);
				global::System.GC.KeepAlive (refs);
			}
		}

	}
}
