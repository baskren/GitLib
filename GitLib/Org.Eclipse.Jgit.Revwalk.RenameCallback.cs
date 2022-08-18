using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>An instance of this class can be used in conjunction with a
	/// <c>FollowFilter</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RenameCallback']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RenameCallback", DoNotGenerateAcw=true)]
	public abstract partial class RenameCallback : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RenameCallback", typeof (RenameCallback));

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

		protected RenameCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RenameCallback']/constructor[@name='RenameCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RenameCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_renamed_Lorg_eclipse_jgit_diff_DiffEntry_;
#pragma warning disable 0169
		static Delegate GetRenamed_Lorg_eclipse_jgit_diff_DiffEntry_Handler ()
		{
			if (cb_renamed_Lorg_eclipse_jgit_diff_DiffEntry_ == null)
				cb_renamed_Lorg_eclipse_jgit_diff_DiffEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Renamed_Lorg_eclipse_jgit_diff_DiffEntry_);
			return cb_renamed_Lorg_eclipse_jgit_diff_DiffEntry_;
		}

		static void n_Renamed_Lorg_eclipse_jgit_diff_DiffEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RenameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entry = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.DiffEntry> (native_entry, JniHandleOwnership.DoNotTransfer);
			__this.Renamed (entry);
		}
#pragma warning restore 0169

		/// <param name="entry">the entry representing the rename/copy</param>
		/// <summary>Called whenever a diff was found that is actually a rename or copy of a
		/// file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RenameCallback']/method[@name='renamed' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry']]"
		[Register ("renamed", "(Lorg/eclipse/jgit/diff/DiffEntry;)V", "GetRenamed_Lorg_eclipse_jgit_diff_DiffEntry_Handler")]
		public abstract void Renamed (global::Org.Eclipse.Jgit.Diff.DiffEntry entry);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RenameCallback", DoNotGenerateAcw=true)]
	internal partial class RenameCallbackInvoker : RenameCallback {
		public RenameCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RenameCallback", typeof (RenameCallbackInvoker));

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

		/// <param name="entry">the entry representing the rename/copy</param>
		/// <summary>Called whenever a diff was found that is actually a rename or copy of a
		/// file.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RenameCallback']/method[@name='renamed' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry']]"
		[Register ("renamed", "(Lorg/eclipse/jgit/diff/DiffEntry;)V", "GetRenamed_Lorg_eclipse_jgit_diff_DiffEntry_Handler")]
		public override unsafe void Renamed (global::Org.Eclipse.Jgit.Diff.DiffEntry entry)
		{
			const string __id = "renamed.(Lorg/eclipse/jgit/diff/DiffEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (entry);
			}
		}

	}
}
