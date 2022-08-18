using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>A queue of commits sorted by commit time order.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DateRevQueue']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/DateRevQueue", DoNotGenerateAcw=true)]
	public partial class DateRevQueue : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/DateRevQueue", typeof (DateRevQueue));

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

		protected DateRevQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty date queue.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DateRevQueue']/constructor[@name='DateRevQueue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateRevQueue () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_add_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_add_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_add_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static void n_Add_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DateRevQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.Add (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DateRevQueue']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("add", "(Lorg/eclipse/jgit/revwalk/RevCommit;)V", "GetAdd_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe void Add (global::Org.Eclipse.Jgit.Revwalk.RevCommit c)
		{
			const string __id = "add.(Lorg/eclipse/jgit/revwalk/RevCommit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DateRevQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DateRevQueue']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DateRevQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DateRevQueue']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Lorg/eclipse/jgit/revwalk/RevCommit;", "GetNextHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit Next ()
		{
			const string __id = "next.()Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DateRevQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peek ());
		}
#pragma warning restore 0169

		/// <summary>Peek at the next commit, without removing it.</summary>
		/// <returns>the next available commit; null if there are no commits left.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DateRevQueue']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Lorg/eclipse/jgit/revwalk/RevCommit;", "GetPeekHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit Peek ()
		{
			const string __id = "peek.()Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='AbstractRevQueue']/method[@name='add' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("add", "(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevFlag;)V", "")]
		public unsafe void Add (global::Org.Eclipse.Jgit.Revwalk.RevCommit c, global::Org.Eclipse.Jgit.Revwalk.RevFlag queueControl)
		{
			const string __id = "add.(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((queueControl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) queueControl).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (queueControl);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='AbstractRevQueue']/method[@name='addParents' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("addParents", "(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevFlag;)V", "")]
		public unsafe void AddParents (global::Org.Eclipse.Jgit.Revwalk.RevCommit c, global::Org.Eclipse.Jgit.Revwalk.RevFlag queueControl)
		{
			const string __id = "addParents.(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((queueControl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) queueControl).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (queueControl);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='AbstractRevQueue']/method[@name='describe' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("describe", "(Ljava/lang/StringBuilder;Lorg/eclipse/jgit/revwalk/RevCommit;)V", "")]
		protected static unsafe void Describe (global::Java.Lang.StringBuilder s, global::Org.Eclipse.Jgit.Revwalk.RevCommit c)
		{
			const string __id = "describe.(Ljava/lang/StringBuilder;Lorg/eclipse/jgit/revwalk/RevCommit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				__args [1] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (s);
				global::System.GC.KeepAlive (c);
			}
		}

	}
}
