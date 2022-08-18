using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revplot {

	/// <param name="&lt;L&gt;">type of lane used by the application.</param>
	/// <summary>An ordered list of <c>PlotCommit</c> subclasses.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommitList']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revplot/PlotCommitList", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L extends org.eclipse.jgit.revplot.PlotLane"})]
	public partial class PlotCommitList : global::Org.Eclipse.Jgit.Revwalk.RevCommitList {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revplot/PlotCommitList", typeof (PlotCommitList));

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

		protected PlotCommitList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommitList']/constructor[@name='PlotCommitList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlotCommitList () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_createLane;
#pragma warning disable 0169
		static Delegate GetCreateLaneHandler ()
		{
			if (cb_createLane == null)
				cb_createLane = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateLane);
			return cb_createLane;
		}

		static IntPtr n_CreateLane (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateLane ());
		}
#pragma warning restore 0169

		/// <returns>a new Lane appropriate for this particular PlotList.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommitList']/method[@name='createLane' and count(parameter)=0]"
		[Register ("createLane", "()Lorg/eclipse/jgit/revplot/PlotLane;", "GetCreateLaneHandler")]
		protected virtual unsafe global::Java.Lang.Object CreateLane ()
		{
			const string __id = "createLane.()Lorg/eclipse/jgit/revplot/PlotLane;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enter_ILorg_eclipse_jgit_revplot_PlotCommit_;
#pragma warning disable 0169
		static Delegate GetEnter_ILorg_eclipse_jgit_revplot_PlotCommit_Handler ()
		{
			if (cb_enter_ILorg_eclipse_jgit_revplot_PlotCommit_ == null)
				cb_enter_ILorg_eclipse_jgit_revplot_PlotCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Enter_ILorg_eclipse_jgit_revplot_PlotCommit_);
			return cb_enter_ILorg_eclipse_jgit_revplot_PlotCommit_;
		}

		static void n_Enter_ILorg_eclipse_jgit_revplot_PlotCommit_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_currCommit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var currCommit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotCommit> (native_currCommit, JniHandleOwnership.DoNotTransfer);
			__this.Enter (index, currCommit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommitList']/method[@name='enter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.eclipse.jgit.revplot.PlotCommit&lt;L&gt;']]"
		[Register ("enter", "(ILorg/eclipse/jgit/revplot/PlotCommit;)V", "GetEnter_ILorg_eclipse_jgit_revplot_PlotCommit_Handler")]
		protected virtual unsafe void Enter (int index, global::Org.Eclipse.Jgit.Revplot.PlotCommit currCommit)
		{
			const string __id = "enter.(ILorg/eclipse/jgit/revplot/PlotCommit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((currCommit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) currCommit).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (currCommit);
			}
		}

		static Delegate cb_findPassingThrough_Lorg_eclipse_jgit_revplot_PlotCommit_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetFindPassingThrough_Lorg_eclipse_jgit_revplot_PlotCommit_Ljava_util_Collection_Handler ()
		{
			if (cb_findPassingThrough_Lorg_eclipse_jgit_revplot_PlotCommit_Ljava_util_Collection_ == null)
				cb_findPassingThrough_Lorg_eclipse_jgit_revplot_PlotCommit_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_FindPassingThrough_Lorg_eclipse_jgit_revplot_PlotCommit_Ljava_util_Collection_);
			return cb_findPassingThrough_Lorg_eclipse_jgit_revplot_PlotCommit_Ljava_util_Collection_;
		}

		static void n_FindPassingThrough_Lorg_eclipse_jgit_revplot_PlotCommit_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_currCommit, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var currCommit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotCommit> (native_currCommit, JniHandleOwnership.DoNotTransfer);
			var result = global::Android.Runtime.JavaCollection.FromJniHandle (native_result, JniHandleOwnership.DoNotTransfer);
			__this.FindPassingThrough (currCommit, result);
		}
#pragma warning restore 0169

		/// <param name="currCommit">the commit the caller needs to get the lanes from.</param>
		/// <param name="result">collection to add the passing lanes into.</param>
		/// <summary>Find the set of lanes passing through a commit's row.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommitList']/method[@name='findPassingThrough' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revplot.PlotCommit&lt;L&gt;'] and parameter[2][@type='java.util.Collection&lt;L&gt;']]"
		[Register ("findPassingThrough", "(Lorg/eclipse/jgit/revplot/PlotCommit;Ljava/util/Collection;)V", "GetFindPassingThrough_Lorg_eclipse_jgit_revplot_PlotCommit_Ljava_util_Collection_Handler")]
		public virtual unsafe void FindPassingThrough (global::Org.Eclipse.Jgit.Revplot.PlotCommit currCommit, global::System.Collections.ICollection result)
		{
			const string __id = "findPassingThrough.(Lorg/eclipse/jgit/revplot/PlotCommit;Ljava/util/Collection;)V";
			IntPtr native_result = global::Android.Runtime.JavaCollection.ToLocalJniHandle (result);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((currCommit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) currCommit).Handle);
				__args [1] = new JniArgumentValue (native_result);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_result);
				global::System.GC.KeepAlive (currCommit);
				global::System.GC.KeepAlive (result);
			}
		}

		static Delegate cb_recycleLane_Lorg_eclipse_jgit_revplot_PlotLane_;
#pragma warning disable 0169
		static Delegate GetRecycleLane_Lorg_eclipse_jgit_revplot_PlotLane_Handler ()
		{
			if (cb_recycleLane_Lorg_eclipse_jgit_revplot_PlotLane_ == null)
				cb_recycleLane_Lorg_eclipse_jgit_revplot_PlotLane_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RecycleLane_Lorg_eclipse_jgit_revplot_PlotLane_);
			return cb_recycleLane_Lorg_eclipse_jgit_revplot_PlotLane_;
		}

		static void n_RecycleLane_Lorg_eclipse_jgit_revplot_PlotLane_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lane)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lane = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_lane, JniHandleOwnership.DoNotTransfer);
			__this.RecycleLane (lane);
		}
#pragma warning restore 0169

		/// <param name="lane">lane</param>
		/// <summary>Return colors and other reusable information to the plotter when a lane
		/// is no longer needed.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotCommitList']/method[@name='recycleLane' and count(parameter)=1 and parameter[1][@type='L']]"
		[Register ("recycleLane", "(Lorg/eclipse/jgit/revplot/PlotLane;)V", "GetRecycleLane_Lorg_eclipse_jgit_revplot_PlotLane_Handler")]
		protected virtual unsafe void RecycleLane (global::Java.Lang.Object lane)
		{
			const string __id = "recycleLane.(Lorg/eclipse/jgit/revplot/PlotLane;)V";
			IntPtr native_lane = JNIEnv.ToLocalJniHandle (lane);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_lane);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_lane);
				global::System.GC.KeepAlive (lane);
			}
		}

	}
}
