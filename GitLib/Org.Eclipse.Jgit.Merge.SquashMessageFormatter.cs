using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>Formatter for constructing the commit message for a squashed commit.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='SquashMessageFormatter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/SquashMessageFormatter", DoNotGenerateAcw=true)]
	public partial class SquashMessageFormatter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/SquashMessageFormatter", typeof (SquashMessageFormatter));

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

		protected SquashMessageFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a new squash message formatter.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='SquashMessageFormatter']/constructor[@name='SquashMessageFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SquashMessageFormatter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_);
			return cb_format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_;
		}

		static IntPtr n_Format_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_squashedCommits, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.SquashMessageFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var squashedCommits = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Revwalk.RevCommit>.FromJniHandle (native_squashedCommits, JniHandleOwnership.DoNotTransfer);
			var target = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_target, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (squashedCommits, target));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="squashedCommits">the squashed commits</param>
		/// <param name="target">the target branch</param>
		/// <summary>Construct the squashed commit message.</summary>
		/// <returns>squashed commit message</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='SquashMessageFormatter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.revwalk.RevCommit&gt;'] and parameter[2][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("format", "(Ljava/util/List;Lorg/eclipse/jgit/lib/Ref;)Ljava/lang/String;", "GetFormat_Ljava_util_List_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe string Format (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Revwalk.RevCommit> squashedCommits, global::Org.Eclipse.Jgit.Lib.IRef target)
		{
			const string __id = "format.(Ljava/util/List;Lorg/eclipse/jgit/lib/Ref;)Ljava/lang/String;";
			IntPtr native_squashedCommits = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Revwalk.RevCommit>.ToLocalJniHandle (squashedCommits);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_squashedCommits);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_squashedCommits);
				global::System.GC.KeepAlive (squashedCommits);
				global::System.GC.KeepAlive (target);
			}
		}

	}
}
