using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>
	///   <c>PreReceiveHook</c> that delegates to a list of other hooks.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PreReceiveHookChain']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PreReceiveHookChain", DoNotGenerateAcw=true)]
	public partial class PreReceiveHookChain : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.IPreReceiveHook {
		public static class InterfaceConsts {
			// The following are fields from: org.eclipse.jgit.transport.PreReceiveHook


			/// <summary>A simple no-op hook.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='PreReceiveHook']/field[@name='NULL']"
			[Register ("NULL")]
			public static global::Org.Eclipse.Jgit.Transport.IPreReceiveHook Null {
				get {
					const string __id = "NULL.Lorg/eclipse/jgit/transport/PreReceiveHook;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreReceiveHook> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PreReceiveHookChain", typeof (PreReceiveHookChain));

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

		protected PreReceiveHookChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="hooks">hooks to execute, in order.</param>
		/// <summary>Create a new hook chaining the given hooks together.</summary>
		/// <returns>a new hook chain of the given hooks.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PreReceiveHookChain']/method[@name='newChain' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends org.eclipse.jgit.transport.PreReceiveHook&gt;']]"
		[Register ("newChain", "(Ljava/util/List;)Lorg/eclipse/jgit/transport/PreReceiveHook;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Transport.IPreReceiveHook NewChain (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.IPreReceiveHook> hooks)
		{
			const string __id = "newChain.(Ljava/util/List;)Lorg/eclipse/jgit/transport/PreReceiveHook;";
			IntPtr native_hooks = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.IPreReceiveHook>.ToLocalJniHandle (hooks);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hooks);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreReceiveHook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hooks);
				global::System.GC.KeepAlive (hooks);
			}
		}

		static Delegate cb_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetOnPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_Handler ()
		{
			if (cb_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ == null)
				cb_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_);
			return cb_onPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_;
		}

		static void n_OnPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rp, IntPtr native_commands)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PreReceiveHookChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceivePack> (native_rp, JniHandleOwnership.DoNotTransfer);
			var commands = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.FromJniHandle (native_commands, JniHandleOwnership.DoNotTransfer);
			__this.OnPreReceive (rp, commands);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PreReceiveHookChain']/method[@name='onPreReceive' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.ReceivePack'] and parameter[2][@type='java.util.Collection&lt;org.eclipse.jgit.transport.ReceiveCommand&gt;']]"
		[Register ("onPreReceive", "(Lorg/eclipse/jgit/transport/ReceivePack;Ljava/util/Collection;)V", "GetOnPreReceive_Lorg_eclipse_jgit_transport_ReceivePack_Ljava_util_Collection_Handler")]
		public virtual unsafe void OnPreReceive (global::Org.Eclipse.Jgit.Transport.ReceivePack rp, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> commands)
		{
			const string __id = "onPreReceive.(Lorg/eclipse/jgit/transport/ReceivePack;Ljava/util/Collection;)V";
			IntPtr native_commands = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.ToLocalJniHandle (commands);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rp).Handle);
				__args [1] = new JniArgumentValue (native_commands);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_commands);
				global::System.GC.KeepAlive (rp);
				global::System.GC.KeepAlive (commands);
			}
		}

	}
}
