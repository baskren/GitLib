using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Base object type accessed during revision walking.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevObject", DoNotGenerateAcw=true)]
	public abstract partial class RevObject : global::Org.Eclipse.Jgit.Lib.ObjectIdOwnerMap.Entry {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevObject", typeof (RevObject));

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

		protected RevObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Get the name of this object.</summary>
		/// <returns>unique hash of this object.</returns>
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Lorg/eclipse/jgit/lib/ObjectId;", "")]
			get {
				const string __id = "getId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public abstract int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get; 
		}

		/// <param name="flag">the flag to mark on this object, for later testing.</param>
		/// <summary>Add a flag to this object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("add", "(Lorg/eclipse/jgit/revwalk/RevFlag;)V", "")]
		public unsafe void Add (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "add.(Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		/// <param name="set">the set of flags to mark on this object, for later testing.</param>
		/// <summary>Add a set of flags to this object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlagSet']]"
		[Register ("add", "(Lorg/eclipse/jgit/revwalk/RevFlagSet;)V", "")]
		public unsafe void Add (global::Org.Eclipse.Jgit.Revwalk.RevFlagSet set)
		{
			const string __id = "add.(Lorg/eclipse/jgit/revwalk/RevFlagSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (set);
			}
		}

		static Delegate cb_appendCoreFlags_Ljava_lang_StringBuilder_;
#pragma warning disable 0169
		static Delegate GetAppendCoreFlags_Ljava_lang_StringBuilder_Handler ()
		{
			if (cb_appendCoreFlags_Ljava_lang_StringBuilder_ == null)
				cb_appendCoreFlags_Ljava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AppendCoreFlags_Ljava_lang_StringBuilder_);
			return cb_appendCoreFlags_Ljava_lang_StringBuilder_;
		}

		static void n_AppendCoreFlags_Ljava_lang_StringBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.AppendCoreFlags (s);
		}
#pragma warning restore 0169

		/// <param name="s">buffer to append a debug description of core RevFlags onto.</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='appendCoreFlags' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuilder']]"
		[Register ("appendCoreFlags", "(Ljava/lang/StringBuilder;)V", "GetAppendCoreFlags_Ljava_lang_StringBuilder_Handler")]
		protected virtual unsafe void AppendCoreFlags (global::Java.Lang.StringBuilder s)
		{
			const string __id = "appendCoreFlags.(Ljava/lang/StringBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (s);
			}
		}

		/// <param name="flag">the flag to test.</param>
		/// <summary>Test to see if the flag has been set on this object.</summary>
		/// <returns>true if the flag has been added to this object; false if not.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='has' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("has", "(Lorg/eclipse/jgit/revwalk/RevFlag;)Z", "")]
		public unsafe bool Has (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "has.(Lorg/eclipse/jgit/revwalk/RevFlag;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		/// <param name="set">the flags to test.</param>
		/// <summary>Test to see if all flags in the set have been set on this object.</summary>
		/// <returns>true if all flags of the set have been added to this object;
		///         false if some or none have been added.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='hasAll' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlagSet']]"
		[Register ("hasAll", "(Lorg/eclipse/jgit/revwalk/RevFlagSet;)Z", "")]
		public unsafe bool HasAll (global::Org.Eclipse.Jgit.Revwalk.RevFlagSet set)
		{
			const string __id = "hasAll.(Lorg/eclipse/jgit/revwalk/RevFlagSet;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (set);
			}
		}

		/// <param name="set">the flags to test.</param>
		/// <summary>Test to see if any flag in the set has been set on this object.</summary>
		/// <returns>true if any flag in the set has been added to this object; false
		///         if not.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='hasAny' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlagSet']]"
		[Register ("hasAny", "(Lorg/eclipse/jgit/revwalk/RevFlagSet;)Z", "")]
		public unsafe bool HasAny (global::Org.Eclipse.Jgit.Revwalk.RevFlagSet set)
		{
			const string __id = "hasAny.(Lorg/eclipse/jgit/revwalk/RevFlagSet;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (set);
			}
		}

		/// <param name="flag">the flag to remove from this object.</param>
		/// <summary>Remove a flag from this object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("remove", "(Lorg/eclipse/jgit/revwalk/RevFlag;)V", "")]
		public unsafe void Remove (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "remove.(Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		/// <param name="set">the flag to remove from this object.</param>
		/// <summary>Remove a set of flags from this object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlagSet']]"
		[Register ("remove", "(Lorg/eclipse/jgit/revwalk/RevFlagSet;)V", "")]
		public unsafe void Remove (global::Org.Eclipse.Jgit.Revwalk.RevFlagSet set)
		{
			const string __id = "remove.(Lorg/eclipse/jgit/revwalk/RevFlagSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (set);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevObject", DoNotGenerateAcw=true)]
	internal partial class RevObjectInvoker : RevObject {
		public RevObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevObject", typeof (RevObjectInvoker));

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

		/// <summary>Get Git object type.</summary>
		/// <returns>object type</returns>
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevObject']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
}
