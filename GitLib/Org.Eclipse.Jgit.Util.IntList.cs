using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <summary>A more efficient List&amp;lt;Integer&amp;gt; using a primitive integer array.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IntList']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/IntList", DoNotGenerateAcw=true)]
	public partial class IntList : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/IntList", typeof (IntList));

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

		protected IntList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty list with a default capacity.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IntList']/constructor[@name='IntList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IntList () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="capacity">number of entries the list can initially hold.</param>
		/// <summary>Create an empty list with the specified capacity.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IntList']/constructor[@name='IntList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe IntList (int capacity) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_add_I;
#pragma warning disable 0169
		static Delegate GetAdd_IHandler ()
		{
			if (cb_add_I == null)
				cb_add_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Add_I);
			return cb_add_I;
		}

		static void n_Add_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IntList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (n);
		}
#pragma warning restore 0169

		/// <param name="n">the number to add.</param>
		/// <summary>Add an entry to the end of the list.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IntList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("add", "(I)V", "GetAdd_IHandler")]
		public virtual unsafe void Add (int n)
		{
			const string __id = "add.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IntList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		/// <summary>Empty this list</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IntList']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fillTo_II;
#pragma warning disable 0169
		static Delegate GetFillTo_IIHandler ()
		{
			if (cb_fillTo_II == null)
				cb_fillTo_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_FillTo_II);
			return cb_fillTo_II;
		}

		static void n_FillTo_II (IntPtr jnienv, IntPtr native__this, int toIndex, int val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IntList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillTo (toIndex, val);
		}
#pragma warning restore 0169

		/// <param name="toIndex">index position to stop filling at. 0 inserts no filler. 1
		///            ensures the list has a size of 1, adding &lt;code&gt;val&lt;/code&gt; if
		///            the list is currently empty.</param>
		/// <param name="val">value to insert into padded positions.</param>
		/// <summary>Pad the list with entries.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IntList']/method[@name='fillTo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("fillTo", "(II)V", "GetFillTo_IIHandler")]
		public virtual unsafe void FillTo (int toIndex, int val)
		{
			const string __id = "fillTo.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (toIndex);
				__args [1] = new JniArgumentValue (val);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_Get_I);
			return cb_get_I;
		}

		static int n_Get_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IntList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (i);
		}
#pragma warning restore 0169

		/// <param name="i">index to read, must be in the range [0, <c>#size()</c>).</param>
		/// <returns>the number at the specified index</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IntList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)I", "GetGet_IHandler")]
		public virtual unsafe int Get (int i)
		{
			const string __id = "get.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_set_II;
#pragma warning disable 0169
		static Delegate GetSet_IIHandler ()
		{
			if (cb_set_II == null)
				cb_set_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_Set_II);
			return cb_set_II;
		}

		static void n_Set_II (IntPtr jnienv, IntPtr native__this, int index, int n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IntList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (index, n);
		}
#pragma warning restore 0169

		/// <param name="index">index to set, must be in the range [0, <c>#size()</c>).</param>
		/// <param name="n">value to store at the position.</param>
		/// <summary>Assign an entry in the list.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IntList']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("set", "(II)V", "GetSet_IIHandler")]
		public virtual unsafe void Set (int index, int n)
		{
			const string __id = "set.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (n);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.IntList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		/// <returns>number of entries in this list</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='IntList']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
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
