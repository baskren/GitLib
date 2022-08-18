using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revplot {

	/// <summary>Specialized RevWalk for visualization of a commit graph.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotWalk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revplot/PlotWalk", DoNotGenerateAcw=true)]
	public partial class PlotWalk : global::Org.Eclipse.Jgit.Revwalk.RevWalk {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revplot/PlotWalk", typeof (PlotWalk));

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

		protected PlotWalk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">the repository the walker will obtain data from.</param>
		/// <summary>Create a new revision walker for a given repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotWalk']/constructor[@name='PlotWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe PlotWalk (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_addAdditionalRefs_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetAddAdditionalRefs_Ljava_lang_Iterable_Handler ()
		{
			if (cb_addAdditionalRefs_Ljava_lang_Iterable_ == null)
				cb_addAdditionalRefs_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddAdditionalRefs_Ljava_lang_Iterable_);
			return cb_addAdditionalRefs_Ljava_lang_Iterable_;
		}

		static void n_AddAdditionalRefs_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refs = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_refs, JniHandleOwnership.DoNotTransfer);
			__this.AddAdditionalRefs (refs);
		}
#pragma warning restore 0169

		/// <param name="refs">additional refs</param>
		/// <summary>Add additional refs to the walk</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotWalk']/method[@name='addAdditionalRefs' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;org.eclipse.jgit.lib.Ref&gt;']]"
		[Register ("addAdditionalRefs", "(Ljava/lang/Iterable;)V", "GetAddAdditionalRefs_Ljava_lang_Iterable_Handler")]
		public virtual unsafe void AddAdditionalRefs (global::Java.Lang.IIterable refs)
		{
			const string __id = "addAdditionalRefs.(Ljava/lang/Iterable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((refs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refs).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (refs);
			}
		}

	}
}
