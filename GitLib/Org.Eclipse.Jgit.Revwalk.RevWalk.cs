using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Walks a commit graph and produces the matching commits in order.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevWalk", DoNotGenerateAcw=true)]
	public partial class RevWalk : global::Java.Lang.Object, global::Java.Lang.IIterable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevWalk", typeof (RevWalk));

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

		protected RevWalk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="or">the reader the walker will obtain data from. The reader should
		///            be released by the caller when the walker is no longer
		///            required.</param>
		/// <summary>Create a new revision walker for a given repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/constructor[@name='RevWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectReader;)V", "")]
		public unsafe RevWalk (global::Org.Eclipse.Jgit.Lib.ObjectReader or) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectReader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((or == null) ? IntPtr.Zero : ((global::Java.Lang.Object) or).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (or);
			}
		}

		/// <param name="repo">the repository the walker will obtain data from. An
		///            ObjectReader will be created by the walker, and must be
		///            released by the caller.</param>
		/// <summary>Create a new revision walker for a given repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/constructor[@name='RevWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe RevWalk (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_getObjectReader;
#pragma warning disable 0169
		static Delegate GetGetObjectReaderHandler ()
		{
			if (cb_getObjectReader == null)
				cb_getObjectReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObjectReader);
			return cb_getObjectReader;
		}

		static IntPtr n_GetObjectReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectReader);
		}
#pragma warning restore 0169

		/// <returns>the reader this walker is using to load objects.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader ObjectReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='getObjectReader' and count(parameter)=0]"
			[Register ("getObjectReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetGetObjectReaderHandler")]
			get {
				const string __id = "getObjectReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRetainBody;
#pragma warning disable 0169
		static Delegate GetIsRetainBodyHandler ()
		{
			if (cb_isRetainBody == null)
				cb_isRetainBody = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRetainBody);
			return cb_isRetainBody;
		}

		static bool n_IsRetainBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetainBody;
		}
#pragma warning restore 0169

		static Delegate cb_setRetainBody_Z;
#pragma warning disable 0169
		static Delegate GetSetRetainBody_ZHandler ()
		{
			if (cb_setRetainBody_Z == null)
				cb_setRetainBody_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetRetainBody_Z);
			return cb_setRetainBody_Z;
		}

		static void n_SetRetainBody_Z (IntPtr jnienv, IntPtr native__this, bool retain)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetainBody = retain;
		}
#pragma warning restore 0169

		/// <summary>Should the body of a commit or tag be retained after parsing its headers? -or- Set whether or not the body of a commit or tag is retained.</summary>
		/// <returns>true if the body should be retained; false it is discarded.</returns>
		/// <param name="retain">true to retain bodies; false to discard them early.</param>
		public virtual unsafe bool RetainBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='isRetainBody' and count(parameter)=0]"
			[Register ("isRetainBody", "()Z", "GetIsRetainBodyHandler")]
			get {
				const string __id = "isRetainBody.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='setRetainBody' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRetainBody", "(Z)V", "GetSetRetainBody_ZHandler")]
			set {
				const string __id = "setRetainBody.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRevFilter;
#pragma warning disable 0169
		static Delegate GetGetRevFilterHandler ()
		{
			if (cb_getRevFilter == null)
				cb_getRevFilter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRevFilter);
			return cb_getRevFilter;
		}

		static IntPtr n_GetRevFilter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RevFilter);
		}
#pragma warning restore 0169

		static Delegate cb_setRevFilter_Lorg_eclipse_jgit_revwalk_filter_RevFilter_;
#pragma warning disable 0169
		static Delegate GetSetRevFilter_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Handler ()
		{
			if (cb_setRevFilter_Lorg_eclipse_jgit_revwalk_filter_RevFilter_ == null)
				cb_setRevFilter_Lorg_eclipse_jgit_revwalk_filter_RevFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRevFilter_Lorg_eclipse_jgit_revwalk_filter_RevFilter_);
			return cb_setRevFilter_Lorg_eclipse_jgit_revwalk_filter_RevFilter_;
		}

		static void n_SetRevFilter_Lorg_eclipse_jgit_revwalk_filter_RevFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newFilter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newFilter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (native_newFilter, JniHandleOwnership.DoNotTransfer);
			__this.RevFilter = newFilter;
		}
#pragma warning restore 0169

		/// <summary>Get the currently configured commit filter. -or- Set the commit filter for this walker.</summary>
		/// <returns>the current filter. Never null as a filter is always needed.</returns>
		/// <param name="newFilter">the new filter. If null the special <c>RevFilter#ALL</c>
		///            filter will be used instead, as it matches every commit.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter RevFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='getRevFilter' and count(parameter)=0]"
			[Register ("getRevFilter", "()Lorg/eclipse/jgit/revwalk/filter/RevFilter;", "GetGetRevFilterHandler")]
			get {
				const string __id = "getRevFilter.()Lorg/eclipse/jgit/revwalk/filter/RevFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='setRevFilter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.filter.RevFilter']]"
			[Register ("setRevFilter", "(Lorg/eclipse/jgit/revwalk/filter/RevFilter;)V", "GetSetRevFilter_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Handler")]
			set {
				const string __id = "setRevFilter.(Lorg/eclipse/jgit/revwalk/filter/RevFilter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getRevSort;
#pragma warning disable 0169
		static Delegate GetGetRevSortHandler ()
		{
			if (cb_getRevSort == null)
				cb_getRevSort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRevSort);
			return cb_getRevSort;
		}

		static IntPtr n_GetRevSort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RevSort);
		}
#pragma warning restore 0169

		/// <summary>Obtain the sort types applied to the commits returned.</summary>
		/// <returns>the sorting strategies employed. At least one strategy is always
		///         used, but that strategy may be <c>RevSort#NONE</c>.</returns>
		public virtual unsafe global::Java.Util.EnumSet RevSort {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='getRevSort' and count(parameter)=0]"
			[Register ("getRevSort", "()Ljava/util/EnumSet;", "GetGetRevSortHandler")]
			get {
				const string __id = "getRevSort.()Ljava/util/EnumSet;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTreeFilter;
#pragma warning disable 0169
		static Delegate GetGetTreeFilterHandler ()
		{
			if (cb_getTreeFilter == null)
				cb_getTreeFilter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTreeFilter);
			return cb_getTreeFilter;
		}

		static IntPtr n_GetTreeFilter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TreeFilter);
		}
#pragma warning restore 0169

		static Delegate cb_setTreeFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
#pragma warning disable 0169
		static Delegate GetSetTreeFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler ()
		{
			if (cb_setTreeFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ == null)
				cb_setTreeFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTreeFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_);
			return cb_setTreeFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
		}

		static void n_SetTreeFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newFilter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newFilter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (native_newFilter, JniHandleOwnership.DoNotTransfer);
			__this.TreeFilter = newFilter;
		}
#pragma warning restore 0169

		/// <summary>Get the tree filter used to simplify commits by modified paths. -or- Set the tree filter used to simplify commits by modified paths.</summary>
		/// <returns>the current filter. Never null as a filter is always needed. If
		///         no filter is being applied <c>TreeFilter#ALL</c> is returned.</returns>
		/// <param name="newFilter">new filter. If null the special <c>TreeFilter#ALL</c> filter
		///            will be used instead, as it matches everything.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter TreeFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='getTreeFilter' and count(parameter)=0]"
			[Register ("getTreeFilter", "()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;", "GetGetTreeFilterHandler")]
			get {
				const string __id = "getTreeFilter.()Lorg/eclipse/jgit/treewalk/filter/TreeFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='setTreeFilter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.filter.TreeFilter']]"
			[Register ("setTreeFilter", "(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V", "GetSetTreeFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler")]
			set {
				const string __id = "setTreeFilter.(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_assertNotStarted;
#pragma warning disable 0169
		static Delegate GetAssertNotStartedHandler ()
		{
			if (cb_assertNotStarted == null)
				cb_assertNotStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AssertNotStarted);
			return cb_assertNotStarted;
		}

		static void n_AssertNotStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AssertNotStarted ();
		}
#pragma warning restore 0169

		/// <summary>Throws an exception if we have started producing output.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='assertNotStarted' and count(parameter)=0]"
		[Register ("assertNotStarted", "()V", "GetAssertNotStartedHandler")]
		protected virtual unsafe void AssertNotStarted ()
		{
			const string __id = "assertNotStarted.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_assumeShallow_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAssumeShallow_Ljava_util_Collection_Handler ()
		{
			if (cb_assumeShallow_Ljava_util_Collection_ == null)
				cb_assumeShallow_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AssumeShallow_Ljava_util_Collection_);
			return cb_assumeShallow_Ljava_util_Collection_;
		}

		static void n_AssumeShallow_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ids)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ids = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_ids, JniHandleOwnership.DoNotTransfer);
			__this.AssumeShallow (ids);
		}
#pragma warning restore 0169

		/// <param name="ids">commits that should be treated as shallow commits, in addition
		///            to any commits already known to be shallow by the repository.</param>
		/// <summary>Assume additional commits are shallow (have no parents).</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='assumeShallow' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("assumeShallow", "(Ljava/util/Collection;)V", "GetAssumeShallow_Ljava_util_Collection_Handler")]
		public virtual unsafe void AssumeShallow (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> ids)
		{
			const string __id = "assumeShallow.(Ljava/util/Collection;)V";
			IntPtr native_ids = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (ids);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ids);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ids);
				global::System.GC.KeepAlive (ids);
			}
		}

		static Delegate cb_carry_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetCarry_Ljava_util_Collection_Handler ()
		{
			if (cb_carry_Ljava_util_Collection_ == null)
				cb_carry_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Carry_Ljava_util_Collection_);
			return cb_carry_Ljava_util_Collection_;
		}

		static void n_Carry_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_set)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var set = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Revwalk.RevFlag>.FromJniHandle (native_set, JniHandleOwnership.DoNotTransfer);
			__this.Carry (set);
		}
#pragma warning restore 0169

		/// <param name="set">the flags to carry onto parents, if set on a descendant.</param>
		/// <summary>Automatically carry flags from a child commit to its parents.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='carry' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.revwalk.RevFlag&gt;']]"
		[Register ("carry", "(Ljava/util/Collection;)V", "GetCarry_Ljava_util_Collection_Handler")]
		public virtual unsafe void Carry (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Revwalk.RevFlag> set)
		{
			const string __id = "carry.(Ljava/util/Collection;)V";
			IntPtr native_set = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Revwalk.RevFlag>.ToLocalJniHandle (set);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_set);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_set);
				global::System.GC.KeepAlive (set);
			}
		}

		static Delegate cb_carry_Lorg_eclipse_jgit_revwalk_RevFlag_;
#pragma warning disable 0169
		static Delegate GetCarry_Lorg_eclipse_jgit_revwalk_RevFlag_Handler ()
		{
			if (cb_carry_Lorg_eclipse_jgit_revwalk_RevFlag_ == null)
				cb_carry_Lorg_eclipse_jgit_revwalk_RevFlag_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Carry_Lorg_eclipse_jgit_revwalk_RevFlag_);
			return cb_carry_Lorg_eclipse_jgit_revwalk_RevFlag_;
		}

		static void n_Carry_Lorg_eclipse_jgit_revwalk_RevFlag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			__this.Carry (flag);
		}
#pragma warning restore 0169

		/// <param name="flag">the flag to carry onto parents, if set on a descendant.</param>
		/// <summary>Automatically carry a flag from a child commit to its parents.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='carry' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("carry", "(Lorg/eclipse/jgit/revwalk/RevFlag;)V", "GetCarry_Lorg_eclipse_jgit_revwalk_RevFlag_Handler")]
		public virtual unsafe void Carry (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "carry.(Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_createCommit_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetCreateCommit_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_createCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_createCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateCommit_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_createCommit_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_CreateCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateCommit (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">the object this walker requires a commit reference for.</param>
		/// <summary>Construct a new unparsed commit for the given object.</summary>
		/// <returns>a new unparsed reference for the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='createCommit' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("createCommit", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevCommit;", "GetCreateCommit_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit CreateCommit (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "createCommit.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		/// <summary>Dispose all internal state and invalidate all RevObject instances.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disposeFlag_Lorg_eclipse_jgit_revwalk_RevFlag_;
#pragma warning disable 0169
		static Delegate GetDisposeFlag_Lorg_eclipse_jgit_revwalk_RevFlag_Handler ()
		{
			if (cb_disposeFlag_Lorg_eclipse_jgit_revwalk_RevFlag_ == null)
				cb_disposeFlag_Lorg_eclipse_jgit_revwalk_RevFlag_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DisposeFlag_Lorg_eclipse_jgit_revwalk_RevFlag_);
			return cb_disposeFlag_Lorg_eclipse_jgit_revwalk_RevFlag_;
		}

		static void n_DisposeFlag_Lorg_eclipse_jgit_revwalk_RevFlag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			__this.DisposeFlag (flag);
		}
#pragma warning restore 0169

		/// <param name="flag">the to recycle.</param>
		/// <summary>Allow a flag to be recycled for a different use.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='disposeFlag' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("disposeFlag", "(Lorg/eclipse/jgit/revwalk/RevFlag;)V", "GetDisposeFlag_Lorg_eclipse_jgit_revwalk_RevFlag_Handler")]
		public virtual unsafe void DisposeFlag (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "disposeFlag.(Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_hasRevSort_Lorg_eclipse_jgit_revwalk_RevSort_;
#pragma warning disable 0169
		static Delegate GetHasRevSort_Lorg_eclipse_jgit_revwalk_RevSort_Handler ()
		{
			if (cb_hasRevSort_Lorg_eclipse_jgit_revwalk_RevSort_ == null)
				cb_hasRevSort_Lorg_eclipse_jgit_revwalk_RevSort_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasRevSort_Lorg_eclipse_jgit_revwalk_RevSort_);
			return cb_hasRevSort_Lorg_eclipse_jgit_revwalk_RevSort_;
		}

		static bool n_HasRevSort_Lorg_eclipse_jgit_revwalk_RevSort_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sort)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sort = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevSort> (native_sort, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasRevSort (sort);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="sort">a sorting strategy to look for.</param>
		/// <summary>Check whether the provided sorting strategy is enabled.</summary>
		/// <returns>true if this strategy is enabled, false otherwise</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='hasRevSort' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevSort']]"
		[Register ("hasRevSort", "(Lorg/eclipse/jgit/revwalk/RevSort;)Z", "GetHasRevSort_Lorg_eclipse_jgit_revwalk_RevSort_Handler")]
		public virtual unsafe bool HasRevSort (global::Org.Eclipse.Jgit.Revwalk.RevSort sort)
		{
			const string __id = "hasRevSort.(Lorg/eclipse/jgit/revwalk/RevSort;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sort == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sort).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (sort);
			}
		}

		static Delegate cb_isMergedInto_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetIsMergedInto_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_isMergedInto_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_isMergedInto_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_IsMergedInto_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_isMergedInto_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static bool n_IsMergedInto_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native__base, IntPtr native_tip)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @base = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native__base, JniHandleOwnership.DoNotTransfer);
			var tip = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_tip, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMergedInto (@base, tip);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="base">commit the caller thinks is reachable from &lt;code&gt;tip&lt;/code&gt;.</param>
		/// <param name="tip">commit to start iteration from, and which is most likely a
		///            descendant (child) of &lt;code&gt;base&lt;/code&gt;.</param>
		/// <summary>Determine if a commit is reachable from another commit.</summary>
		/// <returns>true if there is a path directly from &lt;code&gt;tip&lt;/code&gt; to
		///         &lt;code&gt;base&lt;/code&gt; (and thus &lt;code&gt;base&lt;/code&gt; is fully merged
		///         into &lt;code&gt;tip&lt;/code&gt;); false otherwise.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='isMergedInto' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("isMergedInto", "(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)Z", "GetIsMergedInto_Lorg_eclipse_jgit_revwalk_RevCommit_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe bool IsMergedInto (global::Org.Eclipse.Jgit.Revwalk.RevCommit @base, global::Org.Eclipse.Jgit.Revwalk.RevCommit tip)
		{
			const string __id = "isMergedInto.(Lorg/eclipse/jgit/revwalk/RevCommit;Lorg/eclipse/jgit/revwalk/RevCommit;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue ((tip == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tip).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (tip);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		/// <summary>Returns an Iterator over the commits of this walker.</summary>
		/// <returns>an iterator over this walker's commits.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='iterator' and count(parameter)=0]"
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

		static Delegate cb_lookupAny_Lorg_eclipse_jgit_lib_AnyObjectId_I;
#pragma warning disable 0169
		static Delegate GetLookupAny_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler ()
		{
			if (cb_lookupAny_Lorg_eclipse_jgit_lib_AnyObjectId_I == null)
				cb_lookupAny_Lorg_eclipse_jgit_lib_AnyObjectId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_LookupAny_Lorg_eclipse_jgit_lib_AnyObjectId_I);
			return cb_lookupAny_Lorg_eclipse_jgit_lib_AnyObjectId_I;
		}

		static IntPtr n_LookupAny_Lorg_eclipse_jgit_lib_AnyObjectId_I (IntPtr jnienv, IntPtr native__this, IntPtr native_id, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LookupAny (id, type));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the object.</param>
		/// <param name="type">type of the object. Must be a valid Git object type.</param>
		/// <summary>Locate a reference to any object without loading it.</summary>
		/// <returns>reference to the object. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='lookupAny' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("lookupAny", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/revwalk/RevObject;", "GetLookupAny_Lorg_eclipse_jgit_lib_AnyObjectId_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevObject LookupAny (global::Org.Eclipse.Jgit.Lib.AnyObjectId id, int type)
		{
			const string __id = "lookupAny.(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/revwalk/RevObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [1] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_lookupBlob_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetLookupBlob_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_lookupBlob_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_lookupBlob_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LookupBlob_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_lookupBlob_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_LookupBlob_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LookupBlob (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the blob object.</param>
		/// <summary>Locate a reference to a blob without loading it.</summary>
		/// <returns>reference to the blob object. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='lookupBlob' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("lookupBlob", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevBlob;", "GetLookupBlob_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevBlob LookupBlob (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "lookupBlob.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevBlob;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevBlob> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_lookupCommit_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetLookupCommit_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_lookupCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_lookupCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LookupCommit_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_lookupCommit_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_LookupCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LookupCommit (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the commit object.</param>
		/// <summary>Locate a reference to a commit without loading it.</summary>
		/// <returns>reference to the commit object. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='lookupCommit' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("lookupCommit", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevCommit;", "GetLookupCommit_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit LookupCommit (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "lookupCommit.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_lookupOrNull_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetLookupOrNull_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_lookupOrNull_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_lookupOrNull_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LookupOrNull_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_lookupOrNull_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_LookupOrNull_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LookupOrNull (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the object.</param>
		/// <summary>Locate an object that was previously allocated in this walk.</summary>
		/// <returns>reference to the object if it has been previously located;
		///         otherwise null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='lookupOrNull' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("lookupOrNull", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevObject;", "GetLookupOrNull_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevObject LookupOrNull (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "lookupOrNull.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_lookupTag_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetLookupTag_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_lookupTag_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_lookupTag_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LookupTag_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_lookupTag_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_LookupTag_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LookupTag (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the tag object.</param>
		/// <summary>Locate a reference to a tag without loading it.</summary>
		/// <returns>reference to the tag object. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='lookupTag' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("lookupTag", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevTag;", "GetLookupTag_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevTag LookupTag (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "lookupTag.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevTag;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_lookupTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetLookupTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_lookupTree_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_lookupTree_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LookupTree_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_lookupTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_LookupTree_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LookupTree (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the tree object.</param>
		/// <summary>Locate a reference to a tree without loading it.</summary>
		/// <returns>reference to the tree object. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='lookupTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("lookupTree", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevTree;", "GetLookupTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevTree LookupTree (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "lookupTree.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevTree;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_markStart_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetMarkStart_Ljava_util_Collection_Handler ()
		{
			if (cb_markStart_Ljava_util_Collection_ == null)
				cb_markStart_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_MarkStart_Ljava_util_Collection_);
			return cb_markStart_Ljava_util_Collection_;
		}

		static void n_MarkStart_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_list)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var list = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Revwalk.RevCommit>.FromJniHandle (native_list, JniHandleOwnership.DoNotTransfer);
			__this.MarkStart (list);
		}
#pragma warning restore 0169

		/// <param name="list">commits to start traversing from. The commits passed must be
		///            from this same revision walker.</param>
		/// <summary>Mark commits to start graph traversal from.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='markStart' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.revwalk.RevCommit&gt;']]"
		[Register ("markStart", "(Ljava/util/Collection;)V", "GetMarkStart_Ljava_util_Collection_Handler")]
		public virtual unsafe void MarkStart (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Revwalk.RevCommit> list)
		{
			const string __id = "markStart.(Ljava/util/Collection;)V";
			IntPtr native_list = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Revwalk.RevCommit>.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (list);
			}
		}

		static Delegate cb_markStart_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetMarkStart_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_markStart_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_markStart_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_MarkStart_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_markStart_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static void n_MarkStart_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.MarkStart (c);
		}
#pragma warning restore 0169

		/// <param name="c">the commit to start traversing from. The commit passed must be
		///            from this same revision walker.</param>
		/// <summary>Mark a commit to start graph traversal from.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='markStart' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("markStart", "(Lorg/eclipse/jgit/revwalk/RevCommit;)V", "GetMarkStart_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe void MarkStart (global::Org.Eclipse.Jgit.Revwalk.RevCommit c)
		{
			const string __id = "markStart.(Lorg/eclipse/jgit/revwalk/RevCommit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_markUninteresting_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetMarkUninteresting_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_markUninteresting_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_markUninteresting_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_MarkUninteresting_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_markUninteresting_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static void n_MarkUninteresting_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.MarkUninteresting (c);
		}
#pragma warning restore 0169

		/// <param name="c">the commit to start traversing from. The commit passed must be
		///            from this same revision walker.</param>
		/// <summary>Mark a commit to not produce in the output.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='markUninteresting' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("markUninteresting", "(Lorg/eclipse/jgit/revwalk/RevCommit;)V", "GetMarkUninteresting_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe void MarkUninteresting (global::Org.Eclipse.Jgit.Revwalk.RevCommit c)
		{
			const string __id = "markUninteresting.(Lorg/eclipse/jgit/revwalk/RevCommit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_newFlag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewFlag_Ljava_lang_String_Handler ()
		{
			if (cb_newFlag_Ljava_lang_String_ == null)
				cb_newFlag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewFlag_Ljava_lang_String_);
			return cb_newFlag_Ljava_lang_String_;
		}

		static IntPtr n_NewFlag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewFlag (name));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">description of the flag, primarily useful for debugging.</param>
		/// <summary>Create a new flag for application use during walking.</summary>
		/// <returns>newly constructed flag instance.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='newFlag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newFlag", "(Ljava/lang/String;)Lorg/eclipse/jgit/revwalk/RevFlag;", "GetNewFlag_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevFlag NewFlag (string name)
		{
			const string __id = "newFlag.(Ljava/lang/String;)Lorg/eclipse/jgit/revwalk/RevFlag;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		/// <summary>Pop the next most recent commit.</summary>
		/// <returns>next most recent commit; null if traversal is over.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='next' and count(parameter)=0]"
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

		static Delegate cb_parseAny_Ljava_lang_Iterable_Z;
#pragma warning disable 0169
		static Delegate GetParseAny_Ljava_lang_Iterable_ZHandler ()
		{
			if (cb_parseAny_Ljava_lang_Iterable_Z == null)
				cb_parseAny_Ljava_lang_Iterable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_ParseAny_Ljava_lang_Iterable_Z);
			return cb_parseAny_Ljava_lang_Iterable_Z;
		}

		static IntPtr n_ParseAny_Ljava_lang_Iterable_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_objectIds, bool reportMissing)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objectIds = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_objectIds, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseAny (objectIds, reportMissing));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="&lt;T&gt;">any ObjectId type.</param>
		/// <param name="objectIds">objects to open from the object store. The supplied collection
		///            must not be modified until the queue has finished.</param>
		/// <param name="reportMissing">if true missing objects are reported by calling failure with a
		///            MissingObjectException. This may be more expensive for the
		///            implementation to guarantee. If false the implementation may
		///            choose to report MissingObjectException, or silently skip over
		///            the object with no warning.</param>
		/// <summary>Asynchronous object parsing.</summary>
		/// <returns>queue to read the objects from.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='parseAny' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;T&gt;'] and parameter[2][@type='boolean']]"
		[Register ("parseAny", "(Ljava/lang/Iterable;Z)Lorg/eclipse/jgit/revwalk/AsyncRevObjectQueue;", "GetParseAny_Ljava_lang_Iterable_ZHandler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.eclipse.jgit.lib.ObjectId"})]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.IAsyncRevObjectQueue ParseAny (global::Java.Lang.IIterable objectIds, bool reportMissing)
		{
			const string __id = "parseAny.(Ljava/lang/Iterable;Z)Lorg/eclipse/jgit/revwalk/AsyncRevObjectQueue;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectIds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectIds).Handle);
				__args [1] = new JniArgumentValue (reportMissing);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.IAsyncRevObjectQueue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectIds);
			}
		}

		static Delegate cb_parseAny_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetParseAny_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_parseAny_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_parseAny_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ParseAny_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_parseAny_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_ParseAny_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseAny (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the object.</param>
		/// <summary>Locate a reference to any object and immediately parse its headers.</summary>
		/// <returns>reference to the object. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='parseAny' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("parseAny", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevObject;", "GetParseAny_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevObject ParseAny (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "parseAny.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_parseBody_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetParseBody_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_parseBody_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_parseBody_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ParseBody_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_parseBody_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static void n_ParseBody_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.ParseBody (obj);
		}
#pragma warning restore 0169

		/// <param name="obj">the object the caller needs to be parsed.</param>
		/// <summary>Ensure the object's full body content is available.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='parseBody' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("parseBody", "(Lorg/eclipse/jgit/revwalk/RevObject;)V", "GetParseBody_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe void ParseBody (global::Org.Eclipse.Jgit.Revwalk.RevObject obj)
		{
			const string __id = "parseBody.(Lorg/eclipse/jgit/revwalk/RevObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_parseCommit_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetParseCommit_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_parseCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_parseCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ParseCommit_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_parseCommit_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_ParseCommit_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseCommit (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the commit object.</param>
		/// <summary>Locate a reference to a commit and immediately parse its content.</summary>
		/// <returns>reference to the commit object. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='parseCommit' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("parseCommit", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevCommit;", "GetParseCommit_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevCommit ParseCommit (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "parseCommit.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevCommit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_parseHeaders_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetParseHeaders_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_parseHeaders_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_parseHeaders_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ParseHeaders_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_parseHeaders_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static void n_ParseHeaders_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.ParseHeaders (obj);
		}
#pragma warning restore 0169

		/// <param name="obj">the object the caller needs to be parsed.</param>
		/// <summary>Ensure the object's critical headers have been parsed.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='parseHeaders' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("parseHeaders", "(Lorg/eclipse/jgit/revwalk/RevObject;)V", "GetParseHeaders_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe void ParseHeaders (global::Org.Eclipse.Jgit.Revwalk.RevObject obj)
		{
			const string __id = "parseHeaders.(Lorg/eclipse/jgit/revwalk/RevObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_parseTag_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetParseTag_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_parseTag_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_parseTag_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ParseTag_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_parseTag_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_ParseTag_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseTag (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the tag object.</param>
		/// <summary>Locate a reference to an annotated tag and immediately parse its content.</summary>
		/// <returns>reference to the tag object. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='parseTag' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("parseTag", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevTag;", "GetParseTag_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevTag ParseTag (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "parseTag.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevTag;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_parseTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
#pragma warning disable 0169
		static Delegate GetParseTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler ()
		{
			if (cb_parseTree_Lorg_eclipse_jgit_lib_AnyObjectId_ == null)
				cb_parseTree_Lorg_eclipse_jgit_lib_AnyObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ParseTree_Lorg_eclipse_jgit_lib_AnyObjectId_);
			return cb_parseTree_Lorg_eclipse_jgit_lib_AnyObjectId_;
		}

		static IntPtr n_ParseTree_Lorg_eclipse_jgit_lib_AnyObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseTree (id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="id">name of the tree object, or a commit or annotated tag that may
		///            reference a tree.</param>
		/// <summary>Locate a reference to a tree.</summary>
		/// <returns>reference to the tree object. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='parseTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("parseTree", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevTree;", "GetParseTree_Lorg_eclipse_jgit_lib_AnyObjectId_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevTree ParseTree (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "parseTree.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/revwalk/RevTree;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevTree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_peel_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetPeel_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_peel_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_peel_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Peel_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_peel_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static IntPtr n_Peel_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Peel (obj));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="obj">the starting object.</param>
		/// <summary>Peel back annotated tags until a non-tag object is found.</summary>
		/// <returns>If <c>obj</c> is not an annotated tag, <c>obj</c>. Otherwise
		///         the first non-tag object that <c>obj</c> references. The
		///         returned object's headers have been parsed.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='peel' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("peel", "(Lorg/eclipse/jgit/revwalk/RevObject;)Lorg/eclipse/jgit/revwalk/RevObject;", "GetPeel_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevObject Peel (global::Org.Eclipse.Jgit.Revwalk.RevObject obj)
		{
			const string __id = "peel.(Lorg/eclipse/jgit/revwalk/RevObject;)Lorg/eclipse/jgit/revwalk/RevObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		/// <summary>Release any resources used by this walker's reader.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <summary>Resets internal state and allows this instance to be used again.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reset_I;
#pragma warning disable 0169
		static Delegate GetReset_IHandler ()
		{
			if (cb_reset_I == null)
				cb_reset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Reset_I);
			return cb_reset_I;
		}

		static void n_Reset_I (IntPtr jnienv, IntPtr native__this, int retainFlags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset (retainFlags);
		}
#pragma warning restore 0169

		/// <param name="retainFlags">application flags that should &lt;b&gt;not&lt;/b&gt; be cleared from
		///            existing commit objects.</param>
		/// <summary>Resets internal state and allows this instance to be used again.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reset", "(I)V", "GetReset_IHandler")]
		protected virtual unsafe void Reset (int retainFlags)
		{
			const string __id = "reset.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (retainFlags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='resetRetain' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag...']]"
		[Register ("resetRetain", "([Lorg/eclipse/jgit/revwalk/RevFlag;)V", "")]
		public unsafe void ResetRetain (params global::Org.Eclipse.Jgit.Revwalk.RevFlag[] retainFlags)
		{
			const string __id = "resetRetain.([Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			IntPtr native_retainFlags = JNIEnv.NewArray (retainFlags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_retainFlags);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				if (retainFlags != null) {
					JNIEnv.CopyArray (native_retainFlags, retainFlags);
					JNIEnv.DeleteLocalRef (native_retainFlags);
				}
				global::System.GC.KeepAlive (retainFlags);
			}
		}

		/// <param name="retainFlags">application flags that should &lt;b&gt;not&lt;/b&gt; be cleared from
		///            existing commit objects.</param>
		/// <summary>Resets internal state and allows this instance to be used again.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='resetRetain' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlagSet']]"
		[Register ("resetRetain", "(Lorg/eclipse/jgit/revwalk/RevFlagSet;)V", "")]
		public unsafe void ResetRetain (global::Org.Eclipse.Jgit.Revwalk.RevFlagSet retainFlags)
		{
			const string __id = "resetRetain.(Lorg/eclipse/jgit/revwalk/RevFlagSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((retainFlags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) retainFlags).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (retainFlags);
			}
		}

		/// <param name="flags">the flags to retain during all resets.</param>
		/// <summary>Preserve a set of RevFlags during all <c>reset</c> methods.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='retainOnReset' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.eclipse.jgit.revwalk.RevFlag&gt;']]"
		[Register ("retainOnReset", "(Ljava/util/Collection;)V", "")]
		public unsafe void RetainOnReset (global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Revwalk.RevFlag> flags)
		{
			const string __id = "retainOnReset.(Ljava/util/Collection;)V";
			IntPtr native_flags = global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Revwalk.RevFlag>.ToLocalJniHandle (flags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_flags);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_flags);
				global::System.GC.KeepAlive (flags);
			}
		}

		/// <param name="flag">the flag to retain during all resets.</param>
		/// <summary>Preserve a RevFlag during all <c>reset</c> methods.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='retainOnReset' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("retainOnReset", "(Lorg/eclipse/jgit/revwalk/RevFlag;)V", "")]
		public unsafe void RetainOnReset (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "retainOnReset.(Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_setRewriteParents_Z;
#pragma warning disable 0169
		static Delegate GetSetRewriteParents_ZHandler ()
		{
			if (cb_setRewriteParents_Z == null)
				cb_setRewriteParents_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetRewriteParents_Z);
			return cb_setRewriteParents_Z;
		}

		static void n_SetRewriteParents_Z (IntPtr jnienv, IntPtr native__this, bool rewrite)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRewriteParents (rewrite);
		}
#pragma warning restore 0169

		/// <param name="rewrite">whether to rewrite parents; defaults to true.</param>
		/// <summary>Set whether to rewrite parent pointers when filtering by modified paths.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='setRewriteParents' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRewriteParents", "(Z)V", "GetSetRewriteParents_ZHandler")]
		public virtual unsafe void SetRewriteParents (bool rewrite)
		{
			const string __id = "setRewriteParents.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rewrite);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sort_Lorg_eclipse_jgit_revwalk_RevSort_;
#pragma warning disable 0169
		static Delegate GetSort_Lorg_eclipse_jgit_revwalk_RevSort_Handler ()
		{
			if (cb_sort_Lorg_eclipse_jgit_revwalk_RevSort_ == null)
				cb_sort_Lorg_eclipse_jgit_revwalk_RevSort_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Sort_Lorg_eclipse_jgit_revwalk_RevSort_);
			return cb_sort_Lorg_eclipse_jgit_revwalk_RevSort_;
		}

		static void n_Sort_Lorg_eclipse_jgit_revwalk_RevSort_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevSort> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.Sort (s);
		}
#pragma warning restore 0169

		/// <param name="s">a sorting strategy to enable.</param>
		/// <summary>Select a single sorting strategy for the returned commits.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='sort' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevSort']]"
		[Register ("sort", "(Lorg/eclipse/jgit/revwalk/RevSort;)V", "GetSort_Lorg_eclipse_jgit_revwalk_RevSort_Handler")]
		public virtual unsafe void Sort (global::Org.Eclipse.Jgit.Revwalk.RevSort s)
		{
			const string __id = "sort.(Lorg/eclipse/jgit/revwalk/RevSort;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_sort_Lorg_eclipse_jgit_revwalk_RevSort_Z;
#pragma warning disable 0169
		static Delegate GetSort_Lorg_eclipse_jgit_revwalk_RevSort_ZHandler ()
		{
			if (cb_sort_Lorg_eclipse_jgit_revwalk_RevSort_Z == null)
				cb_sort_Lorg_eclipse_jgit_revwalk_RevSort_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_Sort_Lorg_eclipse_jgit_revwalk_RevSort_Z);
			return cb_sort_Lorg_eclipse_jgit_revwalk_RevSort_Z;
		}

		static void n_Sort_Lorg_eclipse_jgit_revwalk_RevSort_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_s, bool use)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevSort> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.Sort (s, use);
		}
#pragma warning restore 0169

		/// <param name="s">a sorting strategy to enable or disable.</param>
		/// <param name="use">true if this strategy should be used, false if it should be
		///            removed.</param>
		/// <summary>Add or remove a sorting strategy for the returned commits.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='sort' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevSort'] and parameter[2][@type='boolean']]"
		[Register ("sort", "(Lorg/eclipse/jgit/revwalk/RevSort;Z)V", "GetSort_Lorg_eclipse_jgit_revwalk_RevSort_ZHandler")]
		public virtual unsafe void Sort (global::Org.Eclipse.Jgit.Revwalk.RevSort s, bool use)
		{
			const string __id = "sort.(Lorg/eclipse/jgit/revwalk/RevSort;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				__args [1] = new JniArgumentValue (use);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_toObjectWalkWithSameObjects;
#pragma warning disable 0169
		static Delegate GetToObjectWalkWithSameObjectsHandler ()
		{
			if (cb_toObjectWalkWithSameObjects == null)
				cb_toObjectWalkWithSameObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToObjectWalkWithSameObjects);
			return cb_toObjectWalkWithSameObjects;
		}

		static IntPtr n_ToObjectWalkWithSameObjects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToObjectWalkWithSameObjects ());
		}
#pragma warning restore 0169

		/// <summary>Create and return an <c>ObjectWalk</c> using the same objects.</summary>
		/// <returns>a new walk, using the exact same object pool.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevWalk']/method[@name='toObjectWalkWithSameObjects' and count(parameter)=0]"
		[Register ("toObjectWalkWithSameObjects", "()Lorg/eclipse/jgit/revwalk/ObjectWalk;", "GetToObjectWalkWithSameObjectsHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.ObjectWalk ToObjectWalkWithSameObjects ()
		{
			const string __id = "toObjectWalkWithSameObjects.()Lorg/eclipse/jgit/revwalk/ObjectWalk;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
