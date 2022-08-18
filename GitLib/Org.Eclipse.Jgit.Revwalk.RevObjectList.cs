using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <param name="&lt;E&gt;">type of subclass of RevObject the list is storing.</param>
	/// <summary>An ordered list of <c>RevObject</c> subclasses.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObjectList']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevObjectList", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends org.eclipse.jgit.revwalk.RevObject"})]
	public partial class RevObjectList : global::Java.Util.AbstractList {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObjectList']/field[@name='contents']"
		[Register ("contents")]
		protected global::Org.Eclipse.Jgit.Revwalk.RevObjectList.Block Contents {
			get {
				const string __id = "contents.Lorg/eclipse/jgit/revwalk/RevObjectList$Block;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObjectList.Block> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "contents.Lorg/eclipse/jgit/revwalk/RevObjectList$Block;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		/// <summary>One level of contents, either an intermediate level or a leaf level.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObjectList.Block']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevObjectList$Block", DoNotGenerateAcw=true)]
		protected internal partial class Block : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevObjectList$Block", typeof (Block));

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

			protected Block (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevObjectList", typeof (RevObjectList));

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

		protected RevObjectList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty object list.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObjectList']/constructor[@name='RevObjectList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RevObjectList () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_add_ILorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetAdd_ILorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_add_ILorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_add_ILorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Add_ILorg_eclipse_jgit_revwalk_RevObject_);
			return cb_add_ILorg_eclipse_jgit_revwalk_RevObject_;
		}

		static void n_Add_ILorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var element = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_element, JniHandleOwnership.DoNotTransfer);
			__this.Add (index, element);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObjectList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='E']]"
		[Register ("add", "(ILorg/eclipse/jgit/revwalk/RevObject;)V", "GetAdd_ILorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public override unsafe void Add (int index, global::Java.Lang.Object element)
		{
			const string __id = "add.(ILorg/eclipse/jgit/revwalk/RevObject;)V";
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_element);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
				global::System.GC.KeepAlive (element);
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObjectList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lorg/eclipse/jgit/revwalk/RevObject;", "GetGet_IHandler")]
		public override unsafe global::Java.Lang.Object Get (int index)
		{
			const string __id = "get.(I)Lorg/eclipse/jgit/revwalk/RevObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_ILorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetSet_ILorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_set_ILorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_set_ILorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Set_ILorg_eclipse_jgit_revwalk_RevObject_);
			return cb_set_ILorg_eclipse_jgit_revwalk_RevObject_;
		}

		static IntPtr n_Set_ILorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var element = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_element, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (index, element));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObjectList']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='E']]"
		[Register ("set", "(ILorg/eclipse/jgit/revwalk/RevObject;)Lorg/eclipse/jgit/revwalk/RevObject;", "GetSet_ILorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public override unsafe global::Java.Lang.Object Set (int index, global::Java.Lang.Object element)
		{
			const string __id = "set.(ILorg/eclipse/jgit/revwalk/RevObject;)Lorg/eclipse/jgit/revwalk/RevObject;";
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_element);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
				global::System.GC.KeepAlive (element);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObjectList']/method[@name='size' and count(parameter)=0]"
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
