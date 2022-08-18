using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Important state of the repository that affects what can and cannot bed
	/// done.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RepositoryState", DoNotGenerateAcw=true)]
	public abstract partial class RepositoryState : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='APPLY']"
		[Register ("APPLY")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState Apply {
			get {
				const string __id = "APPLY.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='BARE']"
		[Register ("BARE")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState Bare {
			get {
				const string __id = "BARE.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='BISECTING']"
		[Register ("BISECTING")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState Bisecting {
			get {
				const string __id = "BISECTING.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='CHERRY_PICKING']"
		[Register ("CHERRY_PICKING")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState CherryPicking {
			get {
				const string __id = "CHERRY_PICKING.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='CHERRY_PICKING_RESOLVED']"
		[Register ("CHERRY_PICKING_RESOLVED")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState CherryPickingResolved {
			get {
				const string __id = "CHERRY_PICKING_RESOLVED.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='MERGING']"
		[Register ("MERGING")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState Merging {
			get {
				const string __id = "MERGING.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='MERGING_RESOLVED']"
		[Register ("MERGING_RESOLVED")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState MergingResolved {
			get {
				const string __id = "MERGING_RESOLVED.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='REBASING']"
		[Register ("REBASING")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState Rebasing {
			get {
				const string __id = "REBASING.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='REBASING_INTERACTIVE']"
		[Register ("REBASING_INTERACTIVE")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState RebasingInteractive {
			get {
				const string __id = "REBASING_INTERACTIVE.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='REBASING_MERGE']"
		[Register ("REBASING_MERGE")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState RebasingMerge {
			get {
				const string __id = "REBASING_MERGE.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='REBASING_REBASING']"
		[Register ("REBASING_REBASING")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState RebasingRebasing {
			get {
				const string __id = "REBASING_REBASING.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='REVERTING']"
		[Register ("REVERTING")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState Reverting {
			get {
				const string __id = "REVERTING.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='REVERTING_RESOLVED']"
		[Register ("REVERTING_RESOLVED")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState RevertingResolved {
			get {
				const string __id = "REVERTING_RESOLVED.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/field[@name='SAFE']"
		[Register ("SAFE")]
		public static global::Org.Eclipse.Jgit.Lib.RepositoryState Safe {
			get {
				const string __id = "SAFE.Lorg/eclipse/jgit/lib/RepositoryState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RepositoryState", typeof (RepositoryState));

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

		protected RepositoryState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		public abstract string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get; 
		}

		static Delegate cb_isRebasing;
#pragma warning disable 0169
		static Delegate GetIsRebasingHandler ()
		{
			if (cb_isRebasing == null)
				cb_isRebasing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRebasing);
			return cb_isRebasing;
		}

		static bool n_IsRebasing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRebasing;
		}
#pragma warning restore 0169

		public abstract bool IsRebasing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='isRebasing' and count(parameter)=0]"
			[Register ("isRebasing", "()Z", "GetIsRebasingHandler")]
			get; 
		}

		static Delegate cb_canAmend;
#pragma warning disable 0169
		static Delegate GetCanAmendHandler ()
		{
			if (cb_canAmend == null)
				cb_canAmend = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CanAmend);
			return cb_canAmend;
		}

		static bool n_CanAmend (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanAmend ();
		}
#pragma warning restore 0169

		/// <returns>true if amending is considered SAFE</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='canAmend' and count(parameter)=0]"
		[Register ("canAmend", "()Z", "GetCanAmendHandler")]
		public abstract bool CanAmend ();

		static Delegate cb_canCheckout;
#pragma warning disable 0169
		static Delegate GetCanCheckoutHandler ()
		{
			if (cb_canCheckout == null)
				cb_canCheckout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CanCheckout);
			return cb_canCheckout;
		}

		static bool n_CanCheckout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanCheckout ();
		}
#pragma warning restore 0169

		/// <returns>true if changing HEAD is sane.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='canCheckout' and count(parameter)=0]"
		[Register ("canCheckout", "()Z", "GetCanCheckoutHandler")]
		public abstract bool CanCheckout ();

		static Delegate cb_canCommit;
#pragma warning disable 0169
		static Delegate GetCanCommitHandler ()
		{
			if (cb_canCommit == null)
				cb_canCommit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CanCommit);
			return cb_canCommit;
		}

		static bool n_CanCommit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanCommit ();
		}
#pragma warning restore 0169

		/// <returns>true if we can commit</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='canCommit' and count(parameter)=0]"
		[Register ("canCommit", "()Z", "GetCanCommitHandler")]
		public abstract bool CanCommit ();

		static Delegate cb_canResetHead;
#pragma warning disable 0169
		static Delegate GetCanResetHeadHandler ()
		{
			if (cb_canResetHead == null)
				cb_canResetHead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CanResetHead);
			return cb_canResetHead;
		}

		static bool n_CanResetHead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanResetHead ();
		}
#pragma warning restore 0169

		/// <returns>true if reset to another HEAD is considered SAFE</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='canResetHead' and count(parameter)=0]"
		[Register ("canResetHead", "()Z", "GetCanResetHeadHandler")]
		public abstract bool CanResetHead ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RepositoryState;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.RepositoryState ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/RepositoryState;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RepositoryState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/eclipse/jgit/lib/RepositoryState;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.RepositoryState[] Values ()
		{
			const string __id = "values.()[Lorg/eclipse/jgit/lib/RepositoryState;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Eclipse.Jgit.Lib.RepositoryState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.RepositoryState));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/RepositoryState", DoNotGenerateAcw=true)]
	internal partial class RepositoryStateInvoker : RepositoryState {
		public RepositoryStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/RepositoryState", typeof (RepositoryStateInvoker));

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

		/// <returns>a human readable description of the state.</returns>
		public override unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				const string __id = "getDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>true if the repository is currently in a rebase</returns>
		public override unsafe bool IsRebasing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='isRebasing' and count(parameter)=0]"
			[Register ("isRebasing", "()Z", "GetIsRebasingHandler")]
			get {
				const string __id = "isRebasing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>true if amending is considered SAFE</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='canAmend' and count(parameter)=0]"
		[Register ("canAmend", "()Z", "GetCanAmendHandler")]
		public override unsafe bool CanAmend ()
		{
			const string __id = "canAmend.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <returns>true if changing HEAD is sane.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='canCheckout' and count(parameter)=0]"
		[Register ("canCheckout", "()Z", "GetCanCheckoutHandler")]
		public override unsafe bool CanCheckout ()
		{
			const string __id = "canCheckout.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <returns>true if we can commit</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='canCommit' and count(parameter)=0]"
		[Register ("canCommit", "()Z", "GetCanCommitHandler")]
		public override unsafe bool CanCommit ()
		{
			const string __id = "canCommit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <returns>true if reset to another HEAD is considered SAFE</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='RepositoryState']/method[@name='canResetHead' and count(parameter)=0]"
		[Register ("canResetHead", "()Z", "GetCanResetHeadHandler")]
		public override unsafe bool CanResetHead ()
		{
			const string __id = "canResetHead.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
