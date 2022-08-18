using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Util for sorting (or comparing) Ref instances by name.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefComparator']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RefComparator", DoNotGenerateAcw=true)]
	public partial class RefComparator : global::Java.Lang.Object, global::Java.Util.IComparator {

		/// <summary>Singleton instance of RefComparator</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefComparator']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Org.Eclipse.Jgit.Lib.RefComparator Instance {
			get {
				const string __id = "INSTANCE.Lorg/eclipse/jgit/lib/RefComparator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefComparator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RefComparator", typeof (RefComparator));

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

		protected RefComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefComparator']/constructor[@name='RefComparator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RefComparator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_compare_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetCompare_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_compare_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_ == null)
				cb_compare_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_Compare_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_);
			return cb_compare_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_;
		}

		static int n_Compare_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o1, IntPtr native_o2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o1 = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_o1, JniHandleOwnership.DoNotTransfer);
			var o2 = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native_o2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Compare (o1, o2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Ref'] and parameter[2][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("compare", "(Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/Ref;)I", "GetCompare_Lorg_eclipse_jgit_lib_Ref_Lorg_eclipse_jgit_lib_Ref_Handler")]
		public virtual unsafe int Compare (global::Org.Eclipse.Jgit.Lib.IRef o1, global::Org.Eclipse.Jgit.Lib.IRef o2)
		{
			const string __id = "compare.(Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/Ref;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o1).Handle);
				__args [1] = new JniArgumentValue ((o2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o1);
				global::System.GC.KeepAlive (o2);
			}
		}

        public int Compare (Java.Lang.Object o1, Java.Lang.Object o2)
        {
			return Compare((global::Org.Eclipse.Jgit.Lib.IRef)o1, (global::Org.Eclipse.Jgit.Lib.IRef)o2);
        }

        /// <param name="o1">the reference instance.</param>
        /// <param name="o2">the name to compare to.</param>
        /// <summary>Compare a reference to a name.</summary>
        /// <returns>standard Comparator result of &amp;lt; 0, 0, &amp;gt; 0.</returns>
        // Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefComparator']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Ref'] and parameter[2][@type='java.lang.String']]"
        [Register ("compareTo", "(Lorg/eclipse/jgit/lib/Ref;Ljava/lang/String;)I", "")]
		public static unsafe int CompareTo (global::Org.Eclipse.Jgit.Lib.IRef o1, string o2)
		{
			const string __id = "compareTo.(Lorg/eclipse/jgit/lib/Ref;Ljava/lang/String;)I";
			IntPtr native_o2 = JNIEnv.NewString ((string)o2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o1).Handle);
				__args [1] = new JniArgumentValue (native_o2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_o2);
				global::System.GC.KeepAlive (o1);
			}
		}

		/// <param name="o1">the reference instance.</param>
		/// <param name="o2">the other reference instance.</param>
		/// <summary>Compare two references by name.</summary>
		/// <returns>standard Comparator result of &amp;lt; 0, 0, &amp;gt; 0.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefComparator']/method[@name='compareTo' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Ref'] and parameter[2][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("compareTo", "(Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/Ref;)I", "")]
		public static unsafe int CompareTo (global::Org.Eclipse.Jgit.Lib.IRef o1, global::Org.Eclipse.Jgit.Lib.IRef o2)
		{
			const string __id = "compareTo.(Lorg/eclipse/jgit/lib/Ref;Lorg/eclipse/jgit/lib/Ref;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o1).Handle);
				__args [1] = new JniArgumentValue ((o2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o1);
				global::System.GC.KeepAlive (o2);
			}
		}

		/// <param name="refs">collection to be sorted</param>
		/// <summary>Sorts the collection of refs, returning a new collection.</summary>
		/// <returns>sorted collection of refs</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RefComparator']/method[@name='sort' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.lib.Ref&gt;']]"
		[Register ("sort", "(Ljava/util/Collection;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> Sort (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.IRef> refs)
		{
			const string __id = "sort.(Ljava/util/Collection;)Ljava/util/Collection;";
			IntPtr native_refs = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (refs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_refs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_refs);
				global::System.GC.KeepAlive (refs);
			}
		}

    }
}
