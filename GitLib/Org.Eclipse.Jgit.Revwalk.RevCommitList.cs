using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <param name="&lt;E&gt;">type of subclass of RevCommit the list is storing.</param>
	/// <summary>An ordered list of <c>RevCommit</c> subclasses.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/RevCommitList", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends org.eclipse.jgit.revwalk.RevCommit"})]
	public partial class RevCommitList : global::Org.Eclipse.Jgit.Revwalk.RevObjectList {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/RevCommitList", typeof (RevCommitList));

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

		protected RevCommitList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/constructor[@name='RevCommitList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RevCommitList () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isPending;
#pragma warning disable 0169
		static Delegate GetIsPendingHandler ()
		{
			if (cb_isPending == null)
				cb_isPending = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPending);
			return cb_isPending;
		}

		static bool n_IsPending (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPending;
		}
#pragma warning restore 0169

		/// <summary>Is this list still pending more items?</summary>
		/// <returns>true if <c>#fillTo(int)</c> might be able to extend the list
		///         size when called.</returns>
		public virtual unsafe bool IsPending {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='isPending' and count(parameter)=0]"
			[Register ("isPending", "()Z", "GetIsPendingHandler")]
			get {
				const string __id = "isPending.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_applyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_;
#pragma warning disable 0169
		static Delegate GetApplyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_Handler ()
		{
			if (cb_applyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_ == null)
				cb_applyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ApplyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_);
			return cb_applyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_;
		}

		static void n_ApplyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matching, IntPtr native_flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matching = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (native_matching, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			__this.ApplyFlag (matching, flag);
		}
#pragma warning restore 0169

		/// <param name="matching">the filter to test commits with. If the filter includes a
		///            commit it will have the flag set; if the filter does not
		///            include the commit the flag will be unset.</param>
		/// <param name="flag">the flag to apply (or remove). Applications are responsible
		///            for allocating this flag from the source RevWalk.</param>
		/// <summary>Apply a flag to all commits matching the specified filter.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='applyFlag' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.filter.RevFilter'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("applyFlag", "(Lorg/eclipse/jgit/revwalk/filter/RevFilter;Lorg/eclipse/jgit/revwalk/RevFlag;)V", "GetApplyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_Handler")]
		public virtual unsafe void ApplyFlag (global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter matching, global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "applyFlag.(Lorg/eclipse/jgit/revwalk/filter/RevFilter;Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((matching == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matching).Handle);
				__args [1] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (matching);
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_applyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_II;
#pragma warning disable 0169
		static Delegate GetApplyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_IIHandler ()
		{
			if (cb_applyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_II == null)
				cb_applyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_ApplyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_II);
			return cb_applyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_II;
		}

		static void n_ApplyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_II (IntPtr jnienv, IntPtr native__this, IntPtr native_matching, IntPtr native_flag, int rangeBegin, int rangeEnd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matching = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter> (native_matching, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			__this.ApplyFlag (matching, flag, rangeBegin, rangeEnd);
		}
#pragma warning restore 0169

		/// <param name="matching">the filter to test commits with. If the filter includes a
		///            commit it will have the flag set; if the filter does not
		///            include the commit the flag will be unset.</param>
		/// <param name="flag">the flag to apply (or remove). Applications are responsible
		///            for allocating this flag from the source RevWalk.</param>
		/// <param name="rangeBegin">first commit within the list to begin testing at, inclusive.
		///            Must not be negative, but may be beyond the end of the list.</param>
		/// <param name="rangeEnd">last commit within the list to end testing at, exclusive. If
		///            smaller than or equal to &lt;code&gt;rangeBegin&lt;/code&gt; then no
		///            commits will be tested.</param>
		/// <summary>Apply a flag to all commits matching the specified filter.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='applyFlag' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.revwalk.filter.RevFilter'] and parameter[2][@type='org.eclipse.jgit.revwalk.RevFlag'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("applyFlag", "(Lorg/eclipse/jgit/revwalk/filter/RevFilter;Lorg/eclipse/jgit/revwalk/RevFlag;II)V", "GetApplyFlag_Lorg_eclipse_jgit_revwalk_filter_RevFilter_Lorg_eclipse_jgit_revwalk_RevFlag_IIHandler")]
		public virtual unsafe void ApplyFlag (global::Org.Eclipse.Jgit.Revwalk.Filter.RevFilter matching, global::Org.Eclipse.Jgit.Revwalk.RevFlag flag, int rangeBegin, int rangeEnd)
		{
			const string __id = "applyFlag.(Lorg/eclipse/jgit/revwalk/filter/RevFilter;Lorg/eclipse/jgit/revwalk/RevFlag;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((matching == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matching).Handle);
				__args [1] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				__args [2] = new JniArgumentValue (rangeBegin);
				__args [3] = new JniArgumentValue (rangeEnd);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (matching);
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_clearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_;
#pragma warning disable 0169
		static Delegate GetClearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_Handler ()
		{
			if (cb_clearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_ == null)
				cb_clearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_);
			return cb_clearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_;
		}

		static void n_ClearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			__this.ClearFlag (flag);
		}
#pragma warning restore 0169

		/// <param name="flag">the flag to remove. Applications are responsible for
		///            allocating this flag from the source RevWalk.</param>
		/// <summary>Remove the given flag from all commits.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='clearFlag' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag']]"
		[Register ("clearFlag", "(Lorg/eclipse/jgit/revwalk/RevFlag;)V", "GetClearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_Handler")]
		public virtual unsafe void ClearFlag (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag)
		{
			const string __id = "clearFlag.(Lorg/eclipse/jgit/revwalk/RevFlag;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_clearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_II;
#pragma warning disable 0169
		static Delegate GetClearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_IIHandler ()
		{
			if (cb_clearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_II == null)
				cb_clearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_ClearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_II);
			return cb_clearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_II;
		}

		static void n_ClearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_II (IntPtr jnienv, IntPtr native__this, IntPtr native_flag, int rangeBegin, int rangeEnd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			__this.ClearFlag (flag, rangeBegin, rangeEnd);
		}
#pragma warning restore 0169

		/// <param name="flag">the flag to remove. Applications are responsible for
		///            allocating this flag from the source RevWalk.</param>
		/// <param name="rangeBegin">first commit within the list to begin testing at, inclusive.
		///            Must not be negative, but may be beyond the end of the list.</param>
		/// <param name="rangeEnd">last commit within the list to end testing at, exclusive. If
		///            smaller than or equal to &lt;code&gt;rangeBegin&lt;/code&gt; then no
		///            commits will be tested.</param>
		/// <summary>Remove the given flag from all commits.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='clearFlag' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("clearFlag", "(Lorg/eclipse/jgit/revwalk/RevFlag;II)V", "GetClearFlag_Lorg_eclipse_jgit_revwalk_RevFlag_IIHandler")]
		public virtual unsafe void ClearFlag (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag, int rangeBegin, int rangeEnd)
		{
			const string __id = "clearFlag.(Lorg/eclipse/jgit/revwalk/RevFlag;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				__args [1] = new JniArgumentValue (rangeBegin);
				__args [2] = new JniArgumentValue (rangeEnd);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_enter_ILorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetEnter_ILorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_enter_ILorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_enter_ILorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Enter_ILorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_enter_ILorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static void n_Enter_ILorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Enter (index, e);
		}
#pragma warning restore 0169

		/// <param name="index">the list position this object will appear at.</param>
		/// <param name="e">the object being added (or set) into the list.</param>
		/// <summary>Optional callback invoked when commits enter the list by fillTo.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='enter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='E']]"
		[Register ("enter", "(ILorg/eclipse/jgit/revwalk/RevCommit;)V", "GetEnter_ILorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		protected virtual unsafe void Enter (int index, global::Java.Lang.Object e)
		{
			const string __id = "enter.(ILorg/eclipse/jgit/revwalk/RevCommit;)V";
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_e);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_fillTo_I;
#pragma warning disable 0169
		static Delegate GetFillTo_IHandler ()
		{
			if (cb_fillTo_I == null)
				cb_fillTo_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_FillTo_I);
			return cb_fillTo_I;
		}

		static void n_FillTo_I (IntPtr jnienv, IntPtr native__this, int highMark)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillTo (highMark);
		}
#pragma warning restore 0169

		/// <param name="highMark">number of commits the caller wants this list to contain when
		///            the fill operation is complete.</param>
		/// <summary>Ensure this list contains at least a specified number of commits.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='fillTo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fillTo", "(I)V", "GetFillTo_IHandler")]
		public virtual unsafe void FillTo (int highMark)
		{
			const string __id = "fillTo.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (highMark);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fillTo_Lorg_eclipse_jgit_revwalk_RevCommit_I;
#pragma warning disable 0169
		static Delegate GetFillTo_Lorg_eclipse_jgit_revwalk_RevCommit_IHandler ()
		{
			if (cb_fillTo_Lorg_eclipse_jgit_revwalk_RevCommit_I == null)
				cb_fillTo_Lorg_eclipse_jgit_revwalk_RevCommit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_FillTo_Lorg_eclipse_jgit_revwalk_RevCommit_I);
			return cb_fillTo_Lorg_eclipse_jgit_revwalk_RevCommit_I;
		}

		static void n_FillTo_Lorg_eclipse_jgit_revwalk_RevCommit_I (IntPtr jnienv, IntPtr native__this, IntPtr native_commitToLoad, int highMark)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commitToLoad = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_commitToLoad, JniHandleOwnership.DoNotTransfer);
			__this.FillTo (commitToLoad, highMark);
		}
#pragma warning restore 0169

		/// <param name="commitToLoad">commit the caller wants this list to contain when the fill
		///            operation is complete.</param>
		/// <param name="highMark">maximum number of commits the caller wants this list to
		///            contain when the fill operation is complete. If highMark is 0
		///            the walk is pumped until the specified commit or the end of
		///            the walk is reached.</param>
		/// <summary>Ensures all commits until the given commit are loaded.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='fillTo' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit'] and parameter[2][@type='int']]"
		[Register ("fillTo", "(Lorg/eclipse/jgit/revwalk/RevCommit;I)V", "GetFillTo_Lorg_eclipse_jgit_revwalk_RevCommit_IHandler")]
		public virtual unsafe void FillTo (global::Org.Eclipse.Jgit.Revwalk.RevCommit commitToLoad, int highMark)
		{
			const string __id = "fillTo.(Lorg/eclipse/jgit/revwalk/RevCommit;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((commitToLoad == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commitToLoad).Handle);
				__args [1] = new JniArgumentValue (highMark);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (commitToLoad);
			}
		}

		static Delegate cb_indexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I;
#pragma warning disable 0169
		static Delegate GetIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_IHandler ()
		{
			if (cb_indexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I == null)
				cb_indexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_IndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I);
			return cb_indexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I;
		}

		static int n_IndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I (IntPtr jnienv, IntPtr native__this, IntPtr native_flag, int begin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (flag, begin);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="flag">the flag to test commits against.</param>
		/// <param name="begin">first commit index to test at. Applications may wish to begin
		///            at 0, to test the first commit in the list.</param>
		/// <summary>Find the next commit that has the given flag set.</summary>
		/// <returns>index of the first commit at or after index &lt;code&gt;begin&lt;/code&gt;
		///         that has the specified flag set on it; -1 if no match is found.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag'] and parameter[2][@type='int']]"
		[Register ("indexOf", "(Lorg/eclipse/jgit/revwalk/RevFlag;I)I", "GetIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_IHandler")]
		public virtual unsafe int IndexOf (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag, int begin)
		{
			const string __id = "indexOf.(Lorg/eclipse/jgit/revwalk/RevFlag;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				__args [1] = new JniArgumentValue (begin);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_lastIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_IHandler ()
		{
			if (cb_lastIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I == null)
				cb_lastIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_LastIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I);
			return cb_lastIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I;
		}

		static int n_LastIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_I (IntPtr jnienv, IntPtr native__this, IntPtr native_flag, int begin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var flag = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (native_flag, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LastIndexOf (flag, begin);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="flag">the flag to test commits against.</param>
		/// <param name="begin">first commit index to test at. Applications may wish to begin
		///            at &lt;code&gt;size()-1&lt;/code&gt;, to test the last commit in the
		///            list.</param>
		/// <summary>Find the next commit that has the given flag set.</summary>
		/// <returns>index of the first commit at or before index &lt;code&gt;begin&lt;/code&gt;
		///         that has the specified flag set on it; -1 if no match is found.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revwalk.RevFlag'] and parameter[2][@type='int']]"
		[Register ("lastIndexOf", "(Lorg/eclipse/jgit/revwalk/RevFlag;I)I", "GetLastIndexOf_Lorg_eclipse_jgit_revwalk_RevFlag_IHandler")]
		public virtual unsafe int LastIndexOf (global::Org.Eclipse.Jgit.Revwalk.RevFlag flag, int begin)
		{
			const string __id = "lastIndexOf.(Lorg/eclipse/jgit/revwalk/RevFlag;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((flag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flag).Handle);
				__args [1] = new JniArgumentValue (begin);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (flag);
			}
		}

		static Delegate cb_source_Lorg_eclipse_jgit_revwalk_RevWalk_;
#pragma warning disable 0169
		static Delegate GetSource_Lorg_eclipse_jgit_revwalk_RevWalk_Handler ()
		{
			if (cb_source_Lorg_eclipse_jgit_revwalk_RevWalk_ == null)
				cb_source_Lorg_eclipse_jgit_revwalk_RevWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Source_Lorg_eclipse_jgit_revwalk_RevWalk_);
			return cb_source_Lorg_eclipse_jgit_revwalk_RevWalk_;
		}

		static void n_Source_Lorg_eclipse_jgit_revwalk_RevWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_w)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommitList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var w = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_w, JniHandleOwnership.DoNotTransfer);
			__this.Source (w);
		}
#pragma warning restore 0169

		/// <param name="w">the walker to populate from.</param>
		/// <summary>Set the revision walker this list populates itself from.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='RevCommitList']/method[@name='source' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk']]"
		[Register ("source", "(Lorg/eclipse/jgit/revwalk/RevWalk;)V", "GetSource_Lorg_eclipse_jgit_revwalk_RevWalk_Handler")]
		public virtual unsafe void Source (global::Org.Eclipse.Jgit.Revwalk.RevWalk w)
		{
			const string __id = "source.(Lorg/eclipse/jgit/revwalk/RevWalk;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((w == null) ? IntPtr.Zero : ((global::Java.Lang.Object) w).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (w);
			}
		}

	}
}
