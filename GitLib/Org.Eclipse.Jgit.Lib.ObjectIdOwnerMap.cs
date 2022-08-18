using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <param name="&lt;V&gt;">type of subclass of ObjectId that will be stored in the map.</param>
	/// <summary>Fast, efficient map for <c>ObjectId</c> subclasses in only one map.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectIdOwnerMap", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V extends org.eclipse.jgit.lib.ObjectIdOwnerMap.Entry"})]
	public partial class ObjectIdOwnerMap : global::Java.Lang.Object, global::Java.Lang.IIterable {
		/// <summary>Type of entry stored in the <c>ObjectIdOwnerMap</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap.Entry']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectIdOwnerMap$Entry", DoNotGenerateAcw=true)]
		public abstract partial class Entry : global::Org.Eclipse.Jgit.Lib.ObjectId {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectIdOwnerMap$Entry", typeof (Entry));

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

			protected Entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="id">the id the entry represents.</param>
			/// <summary>Initialize this entry with a specific ObjectId.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap.Entry']/constructor[@name='ObjectIdOwnerMap.Entry' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
			[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
			public unsafe Entry (global::Org.Eclipse.Jgit.Lib.AnyObjectId id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/eclipse/jgit/lib/AnyObjectId;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (id);
				}
			}

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectIdOwnerMap$Entry", DoNotGenerateAcw=true)]
		internal partial class EntryInvoker : Entry {
			public EntryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectIdOwnerMap$Entry", typeof (EntryInvoker));

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

			[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
			public override unsafe int CompareTo (global::Java.Lang.Object o)
			{
				const string __id = "compareTo.(Ljava/lang/Object;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (o);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectIdOwnerMap", typeof (ObjectIdOwnerMap));

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

		protected ObjectIdOwnerMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create an empty map.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']/constructor[@name='ObjectIdOwnerMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectIdOwnerMap () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		/// <returns>true if <c>#size()</c> is 0.</returns>
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_add_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_Handler ()
		{
			if (cb_add_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_ == null)
				cb_add_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_);
			return cb_add_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_;
		}

		static void n_Add_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_newValue, JniHandleOwnership.DoNotTransfer);
			__this.Add (newValue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']/method[@name='add' and count(parameter)=1 and parameter[1][@type='Q']]"
		[Register ("add", "(Lorg/eclipse/jgit/lib/ObjectIdOwnerMap$Entry;)V", "GetAdd_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Q extends V"})]
		public virtual unsafe void Add (global::Java.Lang.Object newValue)
		{
			const string __id = "add.(Lorg/eclipse/jgit/lib/ObjectIdOwnerMap$Entry;)V";
			IntPtr native_newValue = JNIEnv.ToLocalJniHandle (newValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newValue);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newValue);
				global::System.GC.KeepAlive (newValue);
			}
		}

		static Delegate cb_addIfAbsent_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_;
#pragma warning disable 0169
		static Delegate GetAddIfAbsent_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_Handler ()
		{
			if (cb_addIfAbsent_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_ == null)
				cb_addIfAbsent_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddIfAbsent_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_);
			return cb_addIfAbsent_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_;
		}

		static IntPtr n_AddIfAbsent_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_newValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddIfAbsent (newValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']/method[@name='addIfAbsent' and count(parameter)=1 and parameter[1][@type='Q']]"
		[Register ("addIfAbsent", "(Lorg/eclipse/jgit/lib/ObjectIdOwnerMap$Entry;)Lorg/eclipse/jgit/lib/ObjectIdOwnerMap$Entry;", "GetAddIfAbsent_Lorg_eclipse_jgit_lib_ObjectIdOwnerMap_Entry_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Q extends V"})]
		public virtual unsafe global::Java.Lang.Object AddIfAbsent (global::Java.Lang.Object newValue)
		{
			const string __id = "addIfAbsent.(Lorg/eclipse/jgit/lib/ObjectIdOwnerMap$Entry;)Lorg/eclipse/jgit/lib/ObjectIdOwnerMap$Entry;";
			IntPtr native_newValue = JNIEnv.ToLocalJniHandle (newValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_newValue);
				global::System.GC.KeepAlive (newValue);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		/// <summary>Remove all entries from this map.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetContains_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_contains_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static bool n_Contains_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_toFind)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var toFind = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_toFind, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (toFind);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="toFind">object to find.</param>
		/// <summary>Returns true if this map contains the specified object.</summary>
		/// <returns>true if the mapping exists for this object; false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("contains", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Z", "GetContains_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe bool Contains (global::Org.Eclipse.Jgit.Lib.AnyObjectId toFind)
		{
			const string __id = "contains.(Lorg/eclipse/jgit/lib/AnyObjectId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((toFind == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toFind).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (toFind);
			}
		}

		static Delegate cb_get_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetGet_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_get_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_get_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_get_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_Get_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_toFind)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var toFind = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_toFind, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (toFind));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']/method[@name='get' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("get", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/ObjectIdOwnerMap$Entry;", "GetGet_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (global::Org.Eclipse.Jgit.Lib.AnyObjectId toFind)
		{
			const string __id = "get.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/ObjectIdOwnerMap$Entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((toFind == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toFind).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (toFind);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']/method[@name='iterator' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		/// <returns>number of objects in this map.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectIdOwnerMap']/method[@name='size' and count(parameter)=0]"
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
