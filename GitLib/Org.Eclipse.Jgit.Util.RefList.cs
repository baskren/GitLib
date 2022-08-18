using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Util {

	/// <param name="&lt;T&gt;">the type of reference being stored in the collection.</param>
	/// <summary>Specialized variant of an ArrayList to support a <c>RefDatabase</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/util/RefList", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.lib.Ref"})]
	public partial class RefList : global::Java.Lang.Object, global::Java.Lang.IIterable {
		/// <param name="&lt;T&gt;">type of reference being stored.</param>
		/// <summary>Builder to facilitate fast construction of an immutable RefList.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/util/RefList$Builder", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.lib.Ref"})]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/RefList$Builder", typeof (Builder));

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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <summary>Create an empty list ready for items to be added.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/constructor[@name='RefList.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			/// <param name="capacity">the new capacity.</param>
			/// <summary>Create an empty list with at least the specified capacity.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/constructor[@name='RefList.Builder' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe Builder (int capacity) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_add_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
			static Delegate GetAdd_Lorg_eclipse_jgit_lib_Ref_Handler ()
			{
				if (cb_add_Lorg_eclipse_jgit_lib_Ref_ == null)
					cb_add_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Lorg_eclipse_jgit_lib_Ref_);
				return cb_add_Lorg_eclipse_jgit_lib_Ref_;
			}

			static void n_Add_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @ref = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__ref, JniHandleOwnership.DoNotTransfer);
				__this.Add (@ref);
			}
#pragma warning restore 0169

			/// <param name="ref">ref</param>
			/// <summary>Add the reference to the end of the array.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/method[@name='add' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("add", "(Lorg/eclipse/jgit/lib/Ref;)V", "GetAdd_Lorg_eclipse_jgit_lib_Ref_Handler")]
			public virtual unsafe void Add (global::Java.Lang.Object @ref)
			{
				const string __id = "add.(Lorg/eclipse/jgit/lib/Ref;)V";
				IntPtr native__ref = JNIEnv.ToLocalJniHandle (@ref);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native__ref);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native__ref);
					global::System.GC.KeepAlive (@ref);
				}
			}

			static Delegate cb_addAll_arrayLorg_eclipse_jgit_lib_Ref_II;
#pragma warning disable 0169
			static Delegate GetAddAll_arrayLorg_eclipse_jgit_lib_Ref_IIHandler ()
			{
				if (cb_addAll_arrayLorg_eclipse_jgit_lib_Ref_II == null)
					cb_addAll_arrayLorg_eclipse_jgit_lib_Ref_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_AddAll_arrayLorg_eclipse_jgit_lib_Ref_II);
				return cb_addAll_arrayLorg_eclipse_jgit_lib_Ref_II;
			}

			static void n_AddAll_arrayLorg_eclipse_jgit_lib_Ref_II (IntPtr jnienv, IntPtr native__this, IntPtr native_src, int off, int cnt)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var src = (global::Org.Eclipse.Jgit.Lib.IRef[]) JNIEnv.GetArray (native_src, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Jgit.Lib.IRef));
				__this.AddAll (src, off, cnt);
				if (src != null)
					JNIEnv.CopyArray (src, native_src);
			}
#pragma warning restore 0169

			/// <param name="src">the source array.</param>
			/// <param name="off">position within <c>src</c> to start copying from.</param>
			/// <param name="cnt">number of items to copy from <c>src</c>.</param>
			/// <summary>Add all items from a source array.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/method[@name='addAll' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Ref[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("addAll", "([Lorg/eclipse/jgit/lib/Ref;II)V", "GetAddAll_arrayLorg_eclipse_jgit_lib_Ref_IIHandler")]
			public virtual unsafe void AddAll (global::Org.Eclipse.Jgit.Lib.IRef[] src, int off, int cnt)
			{
				const string __id = "addAll.([Lorg/eclipse/jgit/lib/Ref;II)V";
				IntPtr native_src = JNIEnv.NewArray (src);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_src);
					__args [1] = new JniArgumentValue (off);
					__args [2] = new JniArgumentValue (cnt);
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

			static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int idx)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Get (idx));
			}
#pragma warning restore 0169

			/// <param name="idx">the index to obtain. Must be <c>0 &lt;= idx &lt; size()</c>.</param>
			/// <summary>Get the reference at a particular index.</summary>
			/// <returns>the reference value, never null.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("get", "(I)Lorg/eclipse/jgit/lib/Ref;", "GetGet_IHandler")]
			public virtual unsafe global::Java.Lang.Object Get (int idx)
			{
				const string __id = "get.(I)Lorg/eclipse/jgit/lib/Ref;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (idx);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_remove_I;
#pragma warning disable 0169
			static Delegate GetRemove_IHandler ()
			{
				if (cb_remove_I == null)
					cb_remove_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Remove_I);
				return cb_remove_I;
			}

			static void n_Remove_I (IntPtr jnienv, IntPtr native__this, int idx)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Remove (idx);
			}
#pragma warning restore 0169

			/// <param name="idx">position to remove the item from.</param>
			/// <summary>Remove an item at a specific index.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("remove", "(I)V", "GetRemove_IHandler")]
			public virtual unsafe void Remove (int idx)
			{
				const string __id = "remove.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (idx);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_set_ILorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
			static Delegate GetSet_ILorg_eclipse_jgit_lib_Ref_Handler ()
			{
				if (cb_set_ILorg_eclipse_jgit_lib_Ref_ == null)
					cb_set_ILorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Set_ILorg_eclipse_jgit_lib_Ref_);
				return cb_set_ILorg_eclipse_jgit_lib_Ref_;
			}

			static void n_Set_ILorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, int idx, IntPtr native__ref)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @ref = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__ref, JniHandleOwnership.DoNotTransfer);
				__this.Set (idx, @ref);
			}
#pragma warning restore 0169

			/// <param name="idx">index, must have already been added previously.</param>
			/// <param name="ref">the new reference.</param>
			/// <summary>Replace a single existing element.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
			[Register ("set", "(ILorg/eclipse/jgit/lib/Ref;)V", "GetSet_ILorg_eclipse_jgit_lib_Ref_Handler")]
			public virtual unsafe void Set (int idx, global::Java.Lang.Object @ref)
			{
				const string __id = "set.(ILorg/eclipse/jgit/lib/Ref;)V";
				IntPtr native__ref = JNIEnv.ToLocalJniHandle (@ref);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (idx);
					__args [1] = new JniArgumentValue (native__ref);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native__ref);
					global::System.GC.KeepAlive (@ref);
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Size ();
			}
#pragma warning restore 0169

			/// <returns>number of items in this builder's internal collection.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/method[@name='size' and count(parameter)=0]"
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

			static Delegate cb_sort;
#pragma warning disable 0169
			static Delegate GetSortHandler ()
			{
				if (cb_sort == null)
					cb_sort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Sort);
				return cb_sort;
			}

			static void n_Sort (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Sort ();
			}
#pragma warning restore 0169

			/// <summary>Sort the list's backing array in-place.</summary>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/method[@name='sort' and count(parameter)=0]"
			[Register ("sort", "()V", "GetSortHandler")]
			public virtual unsafe void Sort ()
			{
				const string __id = "sort.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_toRefList;
#pragma warning disable 0169
			static Delegate GetToRefListHandler ()
			{
				if (cb_toRefList == null)
					cb_toRefList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToRefList);
				return cb_toRefList;
			}

			static IntPtr n_ToRefList (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ToRefList ());
			}
#pragma warning restore 0169

			/// <returns>an unmodifiable list using this collection's backing array.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList.Builder']/method[@name='toRefList' and count(parameter)=0]"
			[Register ("toRefList", "()Lorg/eclipse/jgit/util/RefList;", "GetToRefListHandler")]
			public virtual unsafe global::Org.Eclipse.Jgit.Util.RefList ToRefList ()
			{
				const string __id = "toRefList.()Lorg/eclipse/jgit/util/RefList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/util/RefList", typeof (RefList));

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

		protected RefList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="src">the source list.</param>
		/// <summary>Initialize this list to use the same backing array as another list.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/constructor[@name='RefList' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.util.RefList&lt;T&gt;']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/util/RefList;)V", "")]
		protected unsafe RefList (global::Org.Eclipse.Jgit.Util.RefList src) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/util/RefList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		/// <returns>true if the size of this list is 0.</returns>
		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="idx">position to add the item at. If negative the method assumes it
		///            was a direct return value from <c>#find(String)</c> and will
		///            adjust it to the correct position.</param>
		/// <param name="ref">the new reference to insert.</param>
		/// <summary>Add an item at a specific index.</summary>
		/// <returns>copy of this list, after making space for and adding <c>ref</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("add", "(ILorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/util/RefList;", "")]
		public unsafe global::Org.Eclipse.Jgit.Util.RefList Add (int idx, global::Java.Lang.Object @ref)
		{
			const string __id = "add.(ILorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/util/RefList;";
			IntPtr native__ref = JNIEnv.ToLocalJniHandle (@ref);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (idx);
				__args [1] = new JniArgumentValue (native__ref);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__ref);
				global::System.GC.KeepAlive (@ref);
			}
		}

		/// <returns>this cast as an immutable, standard <c>java.util.List</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='asList' and count(parameter)=0]"
		[Register ("asList", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IRef> AsList ()
		{
			const string __id = "asList.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="name">name of the reference to find.</param>
		/// <summary>Determine if a reference is present.</summary>
		/// <returns>true if the reference is present; false if it is not.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Contains (string name)
		{
			const string __id = "contains.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("copy", "(I)Lorg/eclipse/jgit/util/RefList$Builder;", "")]
		public unsafe global::Org.Eclipse.Jgit.Util.RefList.Builder Copy (int n)
		{
			const string __id = "copy.(I)Lorg/eclipse/jgit/util/RefList$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="&lt;T&gt;">the type of reference being stored in the collection.</param>
		/// <returns>an empty unmodifiable reference list.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='emptyList' and count(parameter)=0]"
		[Register ("emptyList", "()Lorg/eclipse/jgit/util/RefList;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.lib.Ref"})]
		public static unsafe global::Org.Eclipse.Jgit.Util.RefList EmptyList ()
		{
			const string __id = "emptyList.()Lorg/eclipse/jgit/util/RefList;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="name">the name of the reference to find.</param>
		/// <summary>Locate an entry by name.</summary>
		/// <returns>the index the reference is at. If the entry is not present
		///         returns a negative value. The insertion position for the given
		///         name can be computed from <c>-(index + 1)</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='find' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("find", "(Ljava/lang/String;)I", "")]
		public unsafe int Find (string name)
		{
			const string __id = "find.(Ljava/lang/String;)I";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		/// <param name="idx">the index to obtain. Must be <c>0 &lt;= idx &lt; size()</c>.</param>
		/// <summary>Get the reference at a particular index.</summary>
		/// <returns>the reference value, never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lorg/eclipse/jgit/lib/Ref;", "")]
		public unsafe global::Java.Lang.Object Get (int idx)
		{
			const string __id = "get.(I)Lorg/eclipse/jgit/lib/Ref;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="name">the name of the reference.</param>
		/// <summary>Get a reference object by name.</summary>
		/// <returns>the reference object; null if it does not exist in this list.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;", "")]
		public unsafe global::Java.Lang.Object Get (string name)
		{
			const string __id = "get.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/Ref;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="ref">the reference to store.</param>
		/// <summary>Store a reference, adding or replacing as necessary.</summary>
		/// <returns>copy of this list, after performing the addition or replacement.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='put' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("put", "(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/util/RefList;", "")]
		public unsafe global::Org.Eclipse.Jgit.Util.RefList Put (global::Java.Lang.Object @ref)
		{
			const string __id = "put.(Lorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/util/RefList;";
			IntPtr native__ref = JNIEnv.ToLocalJniHandle (@ref);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__ref);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__ref);
				global::System.GC.KeepAlive (@ref);
			}
		}

		/// <param name="idx">position to remove the item from.</param>
		/// <summary>Remove an item at a specific index.</summary>
		/// <returns>copy of this list, after making removing the item at <c>idx</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Lorg/eclipse/jgit/util/RefList;", "")]
		public unsafe global::Org.Eclipse.Jgit.Util.RefList Remove (int idx)
		{
			const string __id = "remove.(I)Lorg/eclipse/jgit/util/RefList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="idx">index of the element to change.</param>
		/// <param name="ref">the new value, must not be null.</param>
		/// <summary>Obtain a new copy of the list after changing one element.</summary>
		/// <returns>copy of this list, after replacing <c>idx</c> with <c>ref</c> .</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("set", "(ILorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/util/RefList;", "")]
		public unsafe global::Org.Eclipse.Jgit.Util.RefList Set (int idx, global::Java.Lang.Object @ref)
		{
			const string __id = "set.(ILorg/eclipse/jgit/lib/Ref;)Lorg/eclipse/jgit/util/RefList;";
			IntPtr native__ref = JNIEnv.ToLocalJniHandle (@ref);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (idx);
				__args [1] = new JniArgumentValue (native__ref);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Util.RefList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__ref);
				global::System.GC.KeepAlive (@ref);
			}
		}

		/// <returns>number of items in this list.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.util']/class[@name='RefList']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
