using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <param name="&lt;T&gt;">type of list element.</param>
	/// <summary>Random access list that allocates entries in blocks.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/BlockList", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class BlockList : global::Java.Util.AbstractList {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/BlockList", typeof (BlockList));

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

		protected BlockList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Initialize an empty list.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']/constructor[@name='BlockList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlockList () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="capacity">number of elements expected to be in the list.</param>
		/// <summary>Initialize an empty list with an expected capacity.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']/constructor[@name='BlockList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BlockList (int capacity) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (capacity);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_ILjava_lang_Object_Handler ()
		{
			if (cb_add_ILjava_lang_Object_ == null)
				cb_add_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Add_ILjava_lang_Object_);
			return cb_add_ILjava_lang_Object_;
		}

		static void n_Add_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.BlockList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var element = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_element, JniHandleOwnership.DoNotTransfer);
			__this.Add (index, element);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("add", "(ILjava/lang/Object;)V", "GetAdd_ILjava_lang_Object_Handler")]
		public override unsafe void Add (int index, global::Java.Lang.Object element)
		{
			const string __id = "add.(ILjava/lang/Object;)V";
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

		static Delegate cb_add_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Object_Handler ()
		{
			if (cb_add_Ljava_lang_Object_ == null)
				cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Add_Ljava_lang_Object_);
			return cb_add_Ljava_lang_Object_;
		}

		static bool n_Add_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_element)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.BlockList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var element = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_element, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (element);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("add", "(Ljava/lang/Object;)Z", "GetAdd_Ljava_lang_Object_Handler")]
		public override unsafe bool Add (global::Java.Lang.Object element)
		{
			const string __id = "add.(Ljava/lang/Object;)Z";
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_element);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
				global::System.GC.KeepAlive (element);
			}
		}

		static Delegate cb_addAll_Lorg_eclipse_jgit_util_BlockList_;
#pragma warning disable 0169
		static Delegate GetAddAll_Lorg_eclipse_jgit_util_BlockList_Handler ()
		{
			if (cb_addAll_Lorg_eclipse_jgit_util_BlockList_ == null)
				cb_addAll_Lorg_eclipse_jgit_util_BlockList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddAll_Lorg_eclipse_jgit_util_BlockList_);
			return cb_addAll_Lorg_eclipse_jgit_util_BlockList_;
		}

		static void n_AddAll_Lorg_eclipse_jgit_util_BlockList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.BlockList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.BlockList> (native_src, JniHandleOwnership.DoNotTransfer);
			__this.AddAll (src);
		}
#pragma warning restore 0169

		/// <param name="src">the list to copy elements from.</param>
		/// <summary>Quickly append all elements of another BlockList.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.BlockList&lt;T&gt;']]"
		[Register ("addAll", "(Lorg/eclipse/jgit/util/BlockList;)V", "GetAddAll_Lorg_eclipse_jgit_util_BlockList_Handler")]
		public virtual unsafe void AddAll (global::Org.Eclipse.Jgit.Util.BlockList src)
		{
			const string __id = "addAll.(Lorg/eclipse/jgit/util/BlockList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		static Delegate cb_addAll_arrayLjava_lang_Object_II;
#pragma warning disable 0169
		static Delegate GetAddAll_arrayLjava_lang_Object_IIHandler ()
		{
			if (cb_addAll_arrayLjava_lang_Object_II == null)
				cb_addAll_arrayLjava_lang_Object_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_AddAll_arrayLjava_lang_Object_II);
			return cb_addAll_arrayLjava_lang_Object_II;
		}

		static void n_AddAll_arrayLjava_lang_Object_II (IntPtr jnienv, IntPtr native__this, IntPtr native_src, int srcIdx, int srcCnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.BlockList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_src, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.AddAll (src, srcIdx, srcCnt);
			if (src != null)
				JNIEnv.CopyArray (src, native_src);
		}
#pragma warning restore 0169

		/// <param name="src">the source array.</param>
		/// <param name="srcIdx">first index to copy.</param>
		/// <param name="srcCnt">number of elements to copy.</param>
		/// <summary>Quickly append all elements from an array.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']/method[@name='addAll' and count(parameter)=3 and parameter[1][@type='T[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("addAll", "([Ljava/lang/Object;II)V", "GetAddAll_arrayLjava_lang_Object_IIHandler")]
		public virtual unsafe void AddAll (global::Java.Lang.Object[] src, int srcIdx, int srcCnt)
		{
			const string __id = "addAll.([Ljava/lang/Object;II)V";
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_src);
				__args [1] = new JniArgumentValue (srcIdx);
				__args [2] = new JniArgumentValue (srcCnt);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				global::System.GC.KeepAlive (src);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.BlockList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public override unsafe global::Java.Lang.Object Get (int index)
		{
			const string __id = "get.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSet_ILjava_lang_Object_Handler ()
		{
			if (cb_set_ILjava_lang_Object_ == null)
				cb_set_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Set_ILjava_lang_Object_);
			return cb_set_ILjava_lang_Object_;
		}

		static IntPtr n_Set_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.BlockList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var element = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_element, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (index, element));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("set", "(ILjava/lang/Object;)Ljava/lang/Object;", "GetSet_ILjava_lang_Object_Handler")]
		public override unsafe global::Java.Lang.Object Set (int index, global::Java.Lang.Object element)
		{
			const string __id = "set.(ILjava/lang/Object;)Ljava/lang/Object;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.BlockList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='BlockList']/method[@name='size' and count(parameter)=0]"
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
