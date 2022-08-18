using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Multiple application level mark bits for <c>RevObject</c>s.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlagSet']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevFlagSet", DoNotGenerateAcw=true)]
	public partial class RevFlagSet : global::Java.Util.AbstractSet {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevFlagSet", typeof (RevFlagSet));

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

		protected RevFlagSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty set of flags.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlagSet']/constructor[@name='RevFlagSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RevFlagSet () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="s">the collection to copy flags from.</param>
		/// <summary>Create a set of flags, copied from an existing collection.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlagSet']/constructor[@name='RevFlagSet' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.revwalk.RevFlag&gt;']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public unsafe RevFlagSet (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Revwalk.RevFlag> s) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Collection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_s = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Revwalk.RevFlag>.ToLocalJniHandle (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				global::System.GC.KeepAlive (s);
			}
		}

		/// <param name="s">the set to copy flags from.</param>
		/// <summary>Create a set of flags, copied from an existing set.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlagSet']/constructor[@name='RevFlagSet' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlagSet']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/revwalk/RevFlagSet;)V", "")]
		public unsafe RevFlagSet (global::Org.Eclipse.Jgit.Revwalk.RevFlagSet s) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/revwalk/RevFlagSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_add_Lorg_eclipse_jgit_revwalk_RevFlag_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_revwalk_RevFlag_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_revwalk_RevFlag_ == null)
				cb_add_Lorg_eclipse_jgit_revwalk_RevFlag_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Add_Lorg_eclipse_jgit_revwalk_RevFlag_);
			return cb_add_Lorg_eclipse_jgit_revwalk_RevFlag_;
		}

		static bool n_Add_Lorg_eclipse_jgit_revwalk_RevFlag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlagSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (flag);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlagSet']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("add", "(Lorg/eclipse/jgit/revwalk/RevFlag;)Z", "GetAdd_Lorg_eclipse_jgit_revwalk_RevFlag_Handler")]
		public virtual unsafe bool Add (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "add.(Lorg/eclipse/jgit/revwalk/RevFlag;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_containsAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetContainsAll_Ljava_util_Collection_Handler ()
		{
			if (cb_containsAll_Ljava_util_Collection_ == null)
				cb_containsAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ContainsAll_Ljava_util_Collection_);
			return cb_containsAll_Ljava_util_Collection_;
		}

		static bool n_ContainsAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlagSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Android.Runtime.JavaCollection<object>.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsAll (c);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlagSet']/method[@name='containsAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;?&gt;']]"
		[Register ("containsAll", "(Ljava/util/Collection;)Z", "GetContainsAll_Ljava_util_Collection_Handler")]
		public virtual unsafe bool ContainsAll (global::System.Collections.Generic.ICollection<object> c)
		{
			const string __id = "containsAll.(Ljava/util/Collection;)Z";
			IntPtr native_c = global::Android.Runtime.JavaCollection<object>.ToLocalJniHandle (c);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_c);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlagSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlagSet']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public override unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlagSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevFlagSet']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
