using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revplot {

	/// <param name="&lt;L&gt;">type of lane being used by the plotter.</param>
	/// <summary>A commit reference to a commit in the DAG.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommit']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revplot/PlotCommit", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L extends org.eclipse.jgit.revplot.PlotLane"})]
	public partial class PlotCommit : global::Org.Eclipse.Jgit.Revwalk.RevCommit {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revplot/PlotCommit", typeof (PlotCommit));

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

		protected PlotCommit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="id">the identity of this commit.</param>
		/// <summary>Create a new commit.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommit']/constructor[@name='PlotCommit' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
		protected unsafe PlotCommit (global::Org.Eclipse.Jgit.Lib.AnyObjectId id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/AnyObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		/// <summary>Get the number of child commits listed in this commit.</summary>
		/// <returns>number of children; always a positive value but can be 0.</returns>
		public unsafe int ChildCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommit']/method[@name='getChildCount' and count(parameter)=0]"
			[Register ("getChildCount", "()I", "")]
			get {
				const string __id = "getChildCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <summary>Obtain the lane this commit has been plotted into.</summary>
		/// <returns>the assigned lane for this commit.</returns>
		public unsafe global::Java.Lang.Object Lane {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommit']/method[@name='getLane' and count(parameter)=0]"
			[Register ("getLane", "()Lorg/eclipse/jgit/revplot/PlotLane;", "")]
			get {
				const string __id = "getLane.()Lorg/eclipse/jgit/revplot/PlotLane;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Get the number of refs for this commit.</summary>
		/// <returns>number of refs; always a positive value but can be 0.</returns>
		public unsafe int RefCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommit']/method[@name='getRefCount' and count(parameter)=0]"
			[Register ("getRefCount", "()I", "")]
			get {
				const string __id = "getRefCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="nth">child index to obtain. Must be in the range 0 through
		///            <c>#getChildCount()</c>-1.</param>
		/// <summary>Get the nth child from this commit's child list.</summary>
		/// <returns>the specified child.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommit']/method[@name='getChild' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getChild", "(I)Lorg/eclipse/jgit/revplot/PlotCommit;", "")]
		public unsafe global::Org.Eclipse.Jgit.Revplot.PlotCommit GetChild (int nth)
		{
			const string __id = "getChild.(I)Lorg/eclipse/jgit/revplot/PlotCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nth);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="nth">ref index to obtain. Must be in the range 0 through
		///            <c>#getRefCount()</c>-1.</param>
		/// <summary>Get the nth Ref from this commit's ref list.</summary>
		/// <returns>the specified ref.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommit']/method[@name='getRef' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRef", "(I)Lorg/eclipse/jgit/lib/Ref;", "")]
		public unsafe global::Org.Eclipse.Jgit.Lib.IRef GetRef (int nth)
		{
			const string __id = "getRef.(I)Lorg/eclipse/jgit/lib/Ref;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nth);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="c">the commit to test.</param>
		/// <summary>Determine if the given commit is a child (descendant) of this commit.</summary>
		/// <returns>true if the given commit built on top of this commit.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommit']/method[@name='isChild' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revplot.PlotCommit']]"
		[Register ("isChild", "(Lorg/eclipse/jgit/revplot/PlotCommit;)Z", "")]
		public unsafe bool IsChild (global::Org.Eclipse.Jgit.Revplot.PlotCommit c)
		{
			const string __id = "isChild.(Lorg/eclipse/jgit/revplot/PlotCommit;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

	}
}
