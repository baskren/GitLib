using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Implements the server side of a fetch connection, transmitting objects.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPack", DoNotGenerateAcw=true)]
	public partial class UploadPack : global::Java.Lang.Object {
		/// <summary>Validator corresponding to <c>RequestPolicy#ADVERTISED</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.AdvertisedRequestValidator']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPack$AdvertisedRequestValidator", DoNotGenerateAcw=true)]
		public sealed partial class AdvertisedRequestValidator : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.UploadPack.IRequestValidator {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPack$AdvertisedRequestValidator", typeof (AdvertisedRequestValidator));

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

			internal AdvertisedRequestValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.AdvertisedRequestValidator']/constructor[@name='UploadPack.AdvertisedRequestValidator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AdvertisedRequestValidator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.AdvertisedRequestValidator']/method[@name='checkWants' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
			[Register ("checkWants", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V", "")]
			public unsafe void CheckWants (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.ObjectId> wants)
			{
				const string __id = "checkWants.(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V";
				IntPtr native_wants = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
					__args [1] = new JniArgumentValue (native_wants);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_wants);
					global::System.GC.KeepAlive (up);
					global::System.GC.KeepAlive (wants);
				}
			}

		}

		/// <summary>Validator corresponding to <c>RequestPolicy#ANY</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.AnyRequestValidator']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPack$AnyRequestValidator", DoNotGenerateAcw=true)]
		public sealed partial class AnyRequestValidator : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.UploadPack.IRequestValidator {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPack$AnyRequestValidator", typeof (AnyRequestValidator));

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

			internal AnyRequestValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.AnyRequestValidator']/constructor[@name='UploadPack.AnyRequestValidator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AnyRequestValidator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.AnyRequestValidator']/method[@name='checkWants' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
			[Register ("checkWants", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V", "")]
			public unsafe void CheckWants (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.ObjectId> wants)
			{
				const string __id = "checkWants.(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V";
				IntPtr native_wants = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
					__args [1] = new JniArgumentValue (native_wants);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_wants);
					global::System.GC.KeepAlive (up);
					global::System.GC.KeepAlive (wants);
				}
			}

		}

		/// <summary>Data in the first line of a request, the line itself plus options.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.FirstLine']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPack$FirstLine", DoNotGenerateAcw=true)]
		public partial class FirstLine : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPack$FirstLine", typeof (FirstLine));

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

			protected FirstLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="line">line from the client.</param>
			/// <summary>Parse the first line of a receive-pack request.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.FirstLine']/constructor[@name='UploadPack.FirstLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe FirstLine (string line) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_line = JNIEnv.NewString ((string)line);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_line);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_line);
				}
			}

			static Delegate cb_getLine;
#pragma warning disable 0169
			static Delegate GetGetLineHandler ()
			{
				if (cb_getLine == null)
					cb_getLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLine);
				return cb_getLine;
			}

			static IntPtr n_GetLine (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.FirstLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Line);
			}
#pragma warning restore 0169

			/// <returns>non-capabilities part of the line.</returns>
			public virtual unsafe string Line {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.FirstLine']/method[@name='getLine' and count(parameter)=0]"
				[Register ("getLine", "()Ljava/lang/String;", "GetGetLineHandler")]
				get {
					const string __id = "getLine.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getOptions;
#pragma warning disable 0169
			static Delegate GetGetOptionsHandler ()
			{
				if (cb_getOptions == null)
					cb_getOptions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOptions);
				return cb_getOptions;
			}

			static IntPtr n_GetOptions (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.FirstLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Options);
			}
#pragma warning restore 0169

			/// <returns>options parsed from the line.</returns>
			public virtual unsafe global::System.Collections.Generic.ICollection<string> Options {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.FirstLine']/method[@name='getOptions' and count(parameter)=0]"
				[Register ("getOptions", "()Ljava/util/Set;", "GetGetOptionsHandler")]
				get {
					const string __id = "getOptions.()Ljava/util/Set;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		/// <summary>Validator corresponding to <c>RequestPolicy#REACHABLE_COMMIT</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.ReachableCommitRequestValidator']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPack$ReachableCommitRequestValidator", DoNotGenerateAcw=true)]
		public sealed partial class ReachableCommitRequestValidator : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.UploadPack.IRequestValidator {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPack$ReachableCommitRequestValidator", typeof (ReachableCommitRequestValidator));

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

			internal ReachableCommitRequestValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.ReachableCommitRequestValidator']/constructor[@name='UploadPack.ReachableCommitRequestValidator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ReachableCommitRequestValidator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.ReachableCommitRequestValidator']/method[@name='checkWants' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
			[Register ("checkWants", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V", "")]
			public unsafe void CheckWants (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.ObjectId> wants)
			{
				const string __id = "checkWants.(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V";
				IntPtr native_wants = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
					__args [1] = new JniArgumentValue (native_wants);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_wants);
					global::System.GC.KeepAlive (up);
					global::System.GC.KeepAlive (wants);
				}
			}

		}

		/// <summary>Validator corresponding to <c>RequestPolicy#REACHABLE_COMMIT_TIP</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.ReachableCommitTipRequestValidator']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPack$ReachableCommitTipRequestValidator", DoNotGenerateAcw=true)]
		public sealed partial class ReachableCommitTipRequestValidator : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.UploadPack.IRequestValidator {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPack$ReachableCommitTipRequestValidator", typeof (ReachableCommitTipRequestValidator));

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

			internal ReachableCommitTipRequestValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.ReachableCommitTipRequestValidator']/constructor[@name='UploadPack.ReachableCommitTipRequestValidator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ReachableCommitTipRequestValidator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.ReachableCommitTipRequestValidator']/method[@name='checkWants' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
			[Register ("checkWants", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V", "")]
			public unsafe void CheckWants (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.ObjectId> wants)
			{
				const string __id = "checkWants.(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V";
				IntPtr native_wants = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
					__args [1] = new JniArgumentValue (native_wants);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_wants);
					global::System.GC.KeepAlive (up);
					global::System.GC.KeepAlive (wants);
				}
			}

		}

		/// <summary>Policy the server uses to validate client requests</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.RequestPolicy']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPack$RequestPolicy", DoNotGenerateAcw=true)]
		public sealed partial class RequestPolicy : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.RequestPolicy']/field[@name='ADVERTISED']"
			[Register ("ADVERTISED")]
			public static global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy Advertised {
				get {
					const string __id = "ADVERTISED.Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.RequestPolicy']/field[@name='ANY']"
			[Register ("ANY")]
			public static global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy Any {
				get {
					const string __id = "ANY.Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.RequestPolicy']/field[@name='REACHABLE_COMMIT']"
			[Register ("REACHABLE_COMMIT")]
			public static global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy ReachableCommit {
				get {
					const string __id = "REACHABLE_COMMIT.Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.RequestPolicy']/field[@name='REACHABLE_COMMIT_TIP']"
			[Register ("REACHABLE_COMMIT_TIP")]
			public static global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy ReachableCommitTip {
				get {
					const string __id = "REACHABLE_COMMIT_TIP.Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.RequestPolicy']/field[@name='TIP']"
			[Register ("TIP")]
			public static global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy Tip {
				get {
					const string __id = "TIP.Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPack$RequestPolicy", typeof (RequestPolicy));

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

			internal RequestPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.RequestPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.RequestPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy));
				} finally {
				}
			}

		}

		/// <summary>Validator for client requests.</summary>
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='UploadPack.RequestValidator']"
		[Register ("org/eclipse/jgit/transport/UploadPack$RequestValidator", "", "Org.Eclipse.Jgit.Transport.UploadPack/IRequestValidatorInvoker")]
		public partial interface IRequestValidator : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/interface[@name='UploadPack.RequestValidator']/method[@name='checkWants' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
			/// <param name="up">
			///   <c>UploadPack</c> instance.</param>
			/// <param name="wants">objects the client requested that were not advertised.</param>
			/// <summary>Check a list of client wants against the request policy.</summary>
			[Register ("checkWants", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V", "GetCheckWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_Handler:Org.Eclipse.Jgit.Transport.UploadPack/IRequestValidatorInvoker, AndroidBindableLibrary")]
			void CheckWants (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.ObjectId> wants);

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPack$RequestValidator", DoNotGenerateAcw=true)]
		internal partial class IRequestValidatorInvoker : global::Java.Lang.Object, IRequestValidator {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPack$RequestValidator", typeof (IRequestValidatorInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IRequestValidator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRequestValidator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.transport.UploadPack.RequestValidator'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRequestValidatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_checkWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetCheckWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_Handler ()
			{
				if (cb_checkWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_ == null)
					cb_checkWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CheckWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_);
				return cb_checkWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_;
			}

			static void n_CheckWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_up, IntPtr native_wants)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.IRequestValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var up = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (native_up, JniHandleOwnership.DoNotTransfer);
				var wants = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_wants, JniHandleOwnership.DoNotTransfer);
				__this.CheckWants (up, wants);
			}
#pragma warning restore 0169

			IntPtr id_checkWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_;
			public unsafe void CheckWants (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.ObjectId> wants)
			{
				if (id_checkWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_ == IntPtr.Zero)
					id_checkWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "checkWants", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V");
				IntPtr native_wants = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
				__args [1] = new JValue (native_wants);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkWants_Lorg_eclipse_jgit_transport_UploadPack_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_wants);
			}

		}

		/// <summary>Validator corresponding to <c>RequestPolicy#TIP</c>.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.TipRequestValidator']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/UploadPack$TipRequestValidator", DoNotGenerateAcw=true)]
		public sealed partial class TipRequestValidator : global::Java.Lang.Object, global::Org.Eclipse.Jgit.Transport.UploadPack.IRequestValidator {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPack$TipRequestValidator", typeof (TipRequestValidator));

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

			internal TipRequestValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.TipRequestValidator']/constructor[@name='UploadPack.TipRequestValidator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe TipRequestValidator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack.TipRequestValidator']/method[@name='checkWants' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
			[Register ("checkWants", "(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V", "")]
			public unsafe void CheckWants (global::Org.Eclipse.Jgit.Transport.UploadPack up, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.ObjectId> wants)
			{
				const string __id = "checkWants.(Lorg/eclipse/jgit/transport/UploadPack;Ljava/util/List;)V";
				IntPtr native_wants = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (wants);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((up == null) ? IntPtr.Zero : ((global::Java.Lang.Object) up).Handle);
					__args [1] = new JniArgumentValue (native_wants);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_wants);
					global::System.GC.KeepAlive (up);
					global::System.GC.KeepAlive (wants);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/UploadPack", typeof (UploadPack));

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

		protected UploadPack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="copyFrom">the source repository.</param>
		/// <summary>Create a new pack upload for an open repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/constructor[@name='UploadPack' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe UploadPack (global::Org.Eclipse.Jgit.Lib.Repository copyFrom) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((copyFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) copyFrom).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (copyFrom);
			}
		}

		static Delegate cb_getAdvertiseRefsHook;
#pragma warning disable 0169
		static Delegate GetGetAdvertiseRefsHookHandler ()
		{
			if (cb_getAdvertiseRefsHook == null)
				cb_getAdvertiseRefsHook = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdvertiseRefsHook);
			return cb_getAdvertiseRefsHook;
		}

		static IntPtr n_GetAdvertiseRefsHook (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdvertiseRefsHook);
		}
#pragma warning restore 0169

		static Delegate cb_setAdvertiseRefsHook_Lorg_eclipse_jgit_transport_AdvertiseRefsHook_;
#pragma warning disable 0169
		static Delegate GetSetAdvertiseRefsHook_Lorg_eclipse_jgit_transport_AdvertiseRefsHook_Handler ()
		{
			if (cb_setAdvertiseRefsHook_Lorg_eclipse_jgit_transport_AdvertiseRefsHook_ == null)
				cb_setAdvertiseRefsHook_Lorg_eclipse_jgit_transport_AdvertiseRefsHook_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAdvertiseRefsHook_Lorg_eclipse_jgit_transport_AdvertiseRefsHook_);
			return cb_setAdvertiseRefsHook_Lorg_eclipse_jgit_transport_AdvertiseRefsHook_;
		}

		static void n_SetAdvertiseRefsHook_Lorg_eclipse_jgit_transport_AdvertiseRefsHook_ (IntPtr jnienv, IntPtr native__this, IntPtr native_advertiseRefsHook)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var advertiseRefsHook = (global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> (native_advertiseRefsHook, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseRefsHook = advertiseRefsHook;
		}
#pragma warning restore 0169

		/// <returns>the hook used while advertising the refs to the client</returns>
		/// <summary>Set the hook used while advertising the refs to the client.</summary>
		/// <param name="advertiseRefsHook">the hook; may be null to show all refs.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook AdvertiseRefsHook {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getAdvertiseRefsHook' and count(parameter)=0]"
			[Register ("getAdvertiseRefsHook", "()Lorg/eclipse/jgit/transport/AdvertiseRefsHook;", "GetGetAdvertiseRefsHookHandler")]
			get {
				const string __id = "getAdvertiseRefsHook.()Lorg/eclipse/jgit/transport/AdvertiseRefsHook;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setAdvertiseRefsHook' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.AdvertiseRefsHook']]"
			[Register ("setAdvertiseRefsHook", "(Lorg/eclipse/jgit/transport/AdvertiseRefsHook;)V", "GetSetAdvertiseRefsHook_Lorg_eclipse_jgit_transport_AdvertiseRefsHook_Handler")]
			set {
				const string __id = "setAdvertiseRefsHook.(Lorg/eclipse/jgit/transport/AdvertiseRefsHook;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		/// <summary>Get refs which were advertised to the client. -or- Set the refs advertised by this UploadPack.</summary>
		/// <returns>all refs which were advertised to the client, or null if
		///         <c>#setAdvertisedRefs(Map)</c> has not been called yet.</returns>
		/// <param name="allRefs">explicit set of references to claim as advertised by this
		///            UploadPack instance. This overrides any references that
		///            may exist in the source repository. The map is passed
		///            to the configured <c>#getRefFilter()</c>. If null, assumes
		///            all refs were advertised.</param>
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> AdvertisedRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getAdvertisedRefs' and count(parameter)=0]"
			[Register ("getAdvertisedRefs", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getAdvertisedRefs.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setAdvertisedRefs' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.lib.Ref&gt;']]"
			[Register ("setAdvertisedRefs", "(Ljava/util/Map;)V", "GetSetAdvertisedRefs_Ljava_util_Map_Handler")]
			set {
				const string __id = "setAdvertisedRefs.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isBiDirectionalPipe;
#pragma warning disable 0169
		static Delegate GetIsBiDirectionalPipeHandler ()
		{
			if (cb_isBiDirectionalPipe == null)
				cb_isBiDirectionalPipe = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBiDirectionalPipe);
			return cb_isBiDirectionalPipe;
		}

		static bool n_IsBiDirectionalPipe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BiDirectionalPipe;
		}
#pragma warning restore 0169

		static Delegate cb_setBiDirectionalPipe_Z;
#pragma warning disable 0169
		static Delegate GetSetBiDirectionalPipe_ZHandler ()
		{
			if (cb_setBiDirectionalPipe_Z == null)
				cb_setBiDirectionalPipe_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetBiDirectionalPipe_Z);
			return cb_setBiDirectionalPipe_Z;
		}

		static void n_SetBiDirectionalPipe_Z (IntPtr jnienv, IntPtr native__this, bool twoWay)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BiDirectionalPipe = twoWay;
		}
#pragma warning restore 0169

		/// <returns>true if this class expects a bi-directional pipe opened between
		///         the client and itself. The default is true.</returns>
		/// <param name="twoWay">if true, this class will assume the socket is a fully
		///            bidirectional pipe between the two peers and takes advantage
		///            of that by first transmitting the known refs, then waiting to
		///            read commands. If false, this class assumes it must read the
		///            commands before writing output and does not perform the
		///            initial advertising.</param>
		public virtual unsafe bool BiDirectionalPipe {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='isBiDirectionalPipe' and count(parameter)=0]"
			[Register ("isBiDirectionalPipe", "()Z", "GetIsBiDirectionalPipeHandler")]
			get {
				const string __id = "isBiDirectionalPipe.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setBiDirectionalPipe' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBiDirectionalPipe", "(Z)V", "GetSetBiDirectionalPipe_ZHandler")]
			set {
				const string __id = "setBiDirectionalPipe.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSideBand;
#pragma warning disable 0169
		static Delegate GetIsSideBandHandler ()
		{
			if (cb_isSideBand == null)
				cb_isSideBand = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSideBand);
			return cb_isSideBand;
		}

		static bool n_IsSideBand (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSideBand;
		}
#pragma warning restore 0169

		/// <summary>Check whether the client expects a side-band stream.</summary>
		/// <returns>true if the client has advertised a side-band capability, false
		///     otherwise.</returns>
		public virtual unsafe bool IsSideBand {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='isSideBand' and count(parameter)=0]"
			[Register ("isSideBand", "()Z", "GetIsSideBandHandler")]
			get {
				const string __id = "isSideBand.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLogger;
#pragma warning disable 0169
		static Delegate GetGetLoggerHandler ()
		{
			if (cb_getLogger == null)
				cb_getLogger = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLogger);
			return cb_getLogger;
		}

		static IntPtr n_GetLogger (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Logger);
		}
#pragma warning restore 0169

		static Delegate cb_setLogger_Lorg_eclipse_jgit_transport_UploadPackLogger_;
#pragma warning disable 0169
		static Delegate GetSetLogger_Lorg_eclipse_jgit_transport_UploadPackLogger_Handler ()
		{
			if (cb_setLogger_Lorg_eclipse_jgit_transport_UploadPackLogger_ == null)
				cb_setLogger_Lorg_eclipse_jgit_transport_UploadPackLogger_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLogger_Lorg_eclipse_jgit_transport_UploadPackLogger_);
			return cb_setLogger_Lorg_eclipse_jgit_transport_UploadPackLogger_;
		}

		static void n_SetLogger_Lorg_eclipse_jgit_transport_UploadPackLogger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logger)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var logger = (global::Org.Eclipse.Jgit.Transport.IUploadPackLogger)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IUploadPackLogger> (native_logger, JniHandleOwnership.DoNotTransfer);
			__this.Logger = logger;
		}
#pragma warning restore 0169

		/// <returns>the configured logger.</returns>
		/// <summary>Set the logger.</summary>
		/// <param name="logger">the logger instance. If null, no logging occurs.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.IUploadPackLogger Logger {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getLogger' and count(parameter)=0]"
			[Register ("getLogger", "()Lorg/eclipse/jgit/transport/UploadPackLogger;", "GetGetLoggerHandler")]
			get {
				const string __id = "getLogger.()Lorg/eclipse/jgit/transport/UploadPackLogger;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IUploadPackLogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.UploadPackLogger']]"
			[Register ("setLogger", "(Lorg/eclipse/jgit/transport/UploadPackLogger;)V", "GetSetLogger_Lorg_eclipse_jgit_transport_UploadPackLogger_Handler")]
			set {
				const string __id = "setLogger.(Lorg/eclipse/jgit/transport/UploadPackLogger;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getMessageOutputStream;
#pragma warning disable 0169
		static Delegate GetGetMessageOutputStreamHandler ()
		{
			if (cb_getMessageOutputStream == null)
				cb_getMessageOutputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessageOutputStream);
			return cb_getMessageOutputStream;
		}

		static IntPtr n_GetMessageOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.MessageOutputStream);
		}
#pragma warning restore 0169

		/// <returns>an underlying stream for sending messages to the client, or null.</returns>
		public virtual unsafe global::System.IO.Stream MessageOutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getMessageOutputStream' and count(parameter)=0]"
			[Register ("getMessageOutputStream", "()Ljava/io/OutputStream;", "GetGetMessageOutputStreamHandler")]
			get {
				const string __id = "getMessageOutputStream.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackStatistics;
#pragma warning disable 0169
		static Delegate GetGetPackStatisticsHandler ()
		{
			if (cb_getPackStatistics == null)
				cb_getPackStatistics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackStatistics);
			return cb_getPackStatistics;
		}

		static IntPtr n_GetPackStatistics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackStatistics);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics PackStatistics {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getPackStatistics' and count(parameter)=0]"
			[Register ("getPackStatistics", "()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;", "GetGetPackStatisticsHandler")]
			get {
				const string __id = "getPackStatistics.()Lorg/eclipse/jgit/internal/storage/pack/PackWriter$Statistics;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter.Statistics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPreUploadHook;
#pragma warning disable 0169
		static Delegate GetGetPreUploadHookHandler ()
		{
			if (cb_getPreUploadHook == null)
				cb_getPreUploadHook = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPreUploadHook);
			return cb_getPreUploadHook;
		}

		static IntPtr n_GetPreUploadHook (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreUploadHook);
		}
#pragma warning restore 0169

		static Delegate cb_setPreUploadHook_Lorg_eclipse_jgit_transport_PreUploadHook_;
#pragma warning disable 0169
		static Delegate GetSetPreUploadHook_Lorg_eclipse_jgit_transport_PreUploadHook_Handler ()
		{
			if (cb_setPreUploadHook_Lorg_eclipse_jgit_transport_PreUploadHook_ == null)
				cb_setPreUploadHook_Lorg_eclipse_jgit_transport_PreUploadHook_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPreUploadHook_Lorg_eclipse_jgit_transport_PreUploadHook_);
			return cb_setPreUploadHook_Lorg_eclipse_jgit_transport_PreUploadHook_;
		}

		static void n_SetPreUploadHook_Lorg_eclipse_jgit_transport_PreUploadHook_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hook)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hook = (global::Org.Eclipse.Jgit.Transport.IPreUploadHook)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreUploadHook> (native_hook, JniHandleOwnership.DoNotTransfer);
			__this.PreUploadHook = hook;
		}
#pragma warning restore 0169

		/// <returns>the configured upload hook.</returns>
		/// <summary>Set the hook that controls how this instance will behave.</summary>
		/// <param name="hook">the hook; if null no special actions are taken.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.IPreUploadHook PreUploadHook {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getPreUploadHook' and count(parameter)=0]"
			[Register ("getPreUploadHook", "()Lorg/eclipse/jgit/transport/PreUploadHook;", "GetGetPreUploadHookHandler")]
			get {
				const string __id = "getPreUploadHook.()Lorg/eclipse/jgit/transport/PreUploadHook;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IPreUploadHook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setPreUploadHook' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PreUploadHook']]"
			[Register ("setPreUploadHook", "(Lorg/eclipse/jgit/transport/PreUploadHook;)V", "GetSetPreUploadHook_Lorg_eclipse_jgit_transport_PreUploadHook_Handler")]
			set {
				const string __id = "setPreUploadHook.(Lorg/eclipse/jgit/transport/PreUploadHook;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getRefFilter;
#pragma warning disable 0169
		static Delegate GetGetRefFilterHandler ()
		{
			if (cb_getRefFilter == null)
				cb_getRefFilter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefFilter);
			return cb_getRefFilter;
		}

		static IntPtr n_GetRefFilter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefFilter);
		}
#pragma warning restore 0169

		static Delegate cb_setRefFilter_Lorg_eclipse_jgit_transport_RefFilter_;
#pragma warning disable 0169
		static Delegate GetSetRefFilter_Lorg_eclipse_jgit_transport_RefFilter_Handler ()
		{
			if (cb_setRefFilter_Lorg_eclipse_jgit_transport_RefFilter_ == null)
				cb_setRefFilter_Lorg_eclipse_jgit_transport_RefFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRefFilter_Lorg_eclipse_jgit_transport_RefFilter_);
			return cb_setRefFilter_Lorg_eclipse_jgit_transport_RefFilter_;
		}

		static void n_SetRefFilter_Lorg_eclipse_jgit_transport_RefFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refFilter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refFilter = (global::Org.Eclipse.Jgit.Transport.IRefFilter)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRefFilter> (native_refFilter, JniHandleOwnership.DoNotTransfer);
			__this.RefFilter = refFilter;
		}
#pragma warning restore 0169

		/// <returns>the filter used while advertising the refs to the client</returns>
		/// <summary>Set the filter used while advertising the refs to the client.</summary>
		/// <param name="refFilter">the filter; may be null to show all refs.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.IRefFilter RefFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getRefFilter' and count(parameter)=0]"
			[Register ("getRefFilter", "()Lorg/eclipse/jgit/transport/RefFilter;", "GetGetRefFilterHandler")]
			get {
				const string __id = "getRefFilter.()Lorg/eclipse/jgit/transport/RefFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRefFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setRefFilter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefFilter']]"
			[Register ("setRefFilter", "(Lorg/eclipse/jgit/transport/RefFilter;)V", "GetSetRefFilter_Lorg_eclipse_jgit_transport_RefFilter_Handler")]
			set {
				const string __id = "setRefFilter.(Lorg/eclipse/jgit/transport/RefFilter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		/// <returns>the repository this upload is reading from.</returns>
		public unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lorg/eclipse/jgit/lib/Repository;", "")]
			get {
				const string __id = "getRepository.()Lorg/eclipse/jgit/lib/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <returns>the RevWalk instance used by this connection.</returns>
		public unsafe global::Org.Eclipse.Jgit.Revwalk.RevWalk RevWalk {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getRevWalk' and count(parameter)=0]"
			[Register ("getRevWalk", "()Lorg/eclipse/jgit/revwalk/RevWalk;", "")]
			get {
				const string __id = "getRevWalk.()Lorg/eclipse/jgit/revwalk/RevWalk;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int seconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = seconds;
		}
#pragma warning restore 0169

		/// <returns>timeout (in seconds) before aborting an IO operation.</returns>
		/// <summary>Set the timeout before willing to abort an IO call.</summary>
		/// <param name="seconds">number of seconds to wait (with no data transfer occurring)
		///            before aborting an IO read or write operation with the
		///            connected client.</param>
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				const string __id = "getTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
			set {
				const string __id = "setTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestPolicy;
#pragma warning disable 0169
		static Delegate GetGetRequestPolicyHandler ()
		{
			if (cb_getRequestPolicy == null)
				cb_getRequestPolicy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestPolicy);
			return cb_getRequestPolicy;
		}

		static IntPtr n_GetRequestPolicy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRequestPolicy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='getRequestPolicy' and count(parameter)=0]"
		[Register ("getRequestPolicy", "()Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;", "GetGetRequestPolicyHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy GetRequestPolicy ()
		{
			const string __id = "getRequestPolicy.()Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sendAdvertisedRefs_Lorg_eclipse_jgit_transport_RefAdvertiser_;
#pragma warning disable 0169
		static Delegate GetSendAdvertisedRefs_Lorg_eclipse_jgit_transport_RefAdvertiser_Handler ()
		{
			if (cb_sendAdvertisedRefs_Lorg_eclipse_jgit_transport_RefAdvertiser_ == null)
				cb_sendAdvertisedRefs_Lorg_eclipse_jgit_transport_RefAdvertiser_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendAdvertisedRefs_Lorg_eclipse_jgit_transport_RefAdvertiser_);
			return cb_sendAdvertisedRefs_Lorg_eclipse_jgit_transport_RefAdvertiser_;
		}

		static void n_SendAdvertisedRefs_Lorg_eclipse_jgit_transport_RefAdvertiser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adv)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adv = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (native_adv, JniHandleOwnership.DoNotTransfer);
			__this.SendAdvertisedRefs (adv);
		}
#pragma warning restore 0169

		/// <param name="adv">the advertisement formatter.</param>
		/// <summary>Generate an advertisement of available refs and capabilities.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='sendAdvertisedRefs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefAdvertiser']]"
		[Register ("sendAdvertisedRefs", "(Lorg/eclipse/jgit/transport/RefAdvertiser;)V", "GetSendAdvertisedRefs_Lorg_eclipse_jgit_transport_RefAdvertiser_Handler")]
		public virtual unsafe void SendAdvertisedRefs (global::Org.Eclipse.Jgit.Transport.RefAdvertiser adv)
		{
			const string __id = "sendAdvertisedRefs.(Lorg/eclipse/jgit/transport/RefAdvertiser;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adv == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adv).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adv);
			}
		}

		static Delegate cb_sendMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_ == null)
				cb_sendMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendMessage_Ljava_lang_String_);
			return cb_sendMessage_Ljava_lang_String_;
		}

		static void n_SendMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var what = JNIEnv.GetString (native_what, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (what);
		}
#pragma warning restore 0169

		/// <param name="what">string describing the problem identified by the hook. The
		///            string must not end with an LF, and must not contain an LF.</param>
		/// <summary>Send a message to the client, if it supports receiving them.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendMessage", "(Ljava/lang/String;)V", "GetSendMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void SendMessage (string what)
		{
			const string __id = "sendMessage.(Ljava/lang/String;)V";
			IntPtr native_what = JNIEnv.NewString ((string)what);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_what);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_what);
			}
		}

		static Delegate cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
#pragma warning disable 0169
		static Delegate GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler ()
		{
			if (cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ == null)
				cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_);
			return cb_setPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_;
		}

		static void n_SetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Storage.Pack.PackConfig> (native_pc, JniHandleOwnership.DoNotTransfer);
			__this.SetPackConfig (pc);
		}
#pragma warning restore 0169

		/// <param name="pc">configuration controlling packing parameters. If null the
		///            source repository's settings will be used.</param>
		/// <summary>Set the configuration used by the pack generator.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setPackConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.storage.pack.PackConfig']]"
		[Register ("setPackConfig", "(Lorg/eclipse/jgit/storage/pack/PackConfig;)V", "GetSetPackConfig_Lorg_eclipse_jgit_storage_pack_PackConfig_Handler")]
		public virtual unsafe void SetPackConfig (global::Org.Eclipse.Jgit.Storage.Pack.PackConfig pc)
		{
			const string __id = "setPackConfig.(Lorg/eclipse/jgit/storage/pack/PackConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pc).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pc);
			}
		}

		static Delegate cb_setRequestPolicy_Lorg_eclipse_jgit_transport_UploadPack_RequestPolicy_;
#pragma warning disable 0169
		static Delegate GetSetRequestPolicy_Lorg_eclipse_jgit_transport_UploadPack_RequestPolicy_Handler ()
		{
			if (cb_setRequestPolicy_Lorg_eclipse_jgit_transport_UploadPack_RequestPolicy_ == null)
				cb_setRequestPolicy_Lorg_eclipse_jgit_transport_UploadPack_RequestPolicy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestPolicy_Lorg_eclipse_jgit_transport_UploadPack_RequestPolicy_);
			return cb_setRequestPolicy_Lorg_eclipse_jgit_transport_UploadPack_RequestPolicy_;
		}

		static void n_SetRequestPolicy_Lorg_eclipse_jgit_transport_UploadPack_RequestPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_policy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var policy = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy> (native_policy, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestPolicy (policy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setRequestPolicy' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack.RequestPolicy']]"
		[Register ("setRequestPolicy", "(Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;)V", "GetSetRequestPolicy_Lorg_eclipse_jgit_transport_UploadPack_RequestPolicy_Handler")]
		public virtual unsafe void SetRequestPolicy (global::Org.Eclipse.Jgit.Transport.UploadPack.RequestPolicy policy)
		{
			const string __id = "setRequestPolicy.(Lorg/eclipse/jgit/transport/UploadPack$RequestPolicy;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((policy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) policy).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (policy);
			}
		}

		static Delegate cb_setRequestValidator_Lorg_eclipse_jgit_transport_UploadPack_RequestValidator_;
#pragma warning disable 0169
		static Delegate GetSetRequestValidator_Lorg_eclipse_jgit_transport_UploadPack_RequestValidator_Handler ()
		{
			if (cb_setRequestValidator_Lorg_eclipse_jgit_transport_UploadPack_RequestValidator_ == null)
				cb_setRequestValidator_Lorg_eclipse_jgit_transport_UploadPack_RequestValidator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRequestValidator_Lorg_eclipse_jgit_transport_UploadPack_RequestValidator_);
			return cb_setRequestValidator_Lorg_eclipse_jgit_transport_UploadPack_RequestValidator_;
		}

		static void n_SetRequestValidator_Lorg_eclipse_jgit_transport_UploadPack_RequestValidator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_validator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var validator = (global::Org.Eclipse.Jgit.Transport.UploadPack.IRequestValidator)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack.IRequestValidator> (native_validator, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestValidator (validator);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setRequestValidator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.UploadPack.RequestValidator']]"
		[Register ("setRequestValidator", "(Lorg/eclipse/jgit/transport/UploadPack$RequestValidator;)V", "GetSetRequestValidator_Lorg_eclipse_jgit_transport_UploadPack_RequestValidator_Handler")]
		public virtual unsafe void SetRequestValidator (global::Org.Eclipse.Jgit.Transport.UploadPack.IRequestValidator validator)
		{
			const string __id = "setRequestValidator.(Lorg/eclipse/jgit/transport/UploadPack$RequestValidator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((validator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) validator).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (validator);
			}
		}

		static Delegate cb_setTransferConfig_Lorg_eclipse_jgit_transport_TransferConfig_;
#pragma warning disable 0169
		static Delegate GetSetTransferConfig_Lorg_eclipse_jgit_transport_TransferConfig_Handler ()
		{
			if (cb_setTransferConfig_Lorg_eclipse_jgit_transport_TransferConfig_ == null)
				cb_setTransferConfig_Lorg_eclipse_jgit_transport_TransferConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTransferConfig_Lorg_eclipse_jgit_transport_TransferConfig_);
			return cb_setTransferConfig_Lorg_eclipse_jgit_transport_TransferConfig_;
		}

		static void n_SetTransferConfig_Lorg_eclipse_jgit_transport_TransferConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TransferConfig> (native_tc, JniHandleOwnership.DoNotTransfer);
			__this.SetTransferConfig (tc);
		}
#pragma warning restore 0169

		/// <param name="tc">configuration controlling transfer options. If null the source
		///            repository's settings will be used.</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='setTransferConfig' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.TransferConfig']]"
		[Register ("setTransferConfig", "(Lorg/eclipse/jgit/transport/TransferConfig;)V", "GetSetTransferConfig_Lorg_eclipse_jgit_transport_TransferConfig_Handler")]
		public virtual unsafe void SetTransferConfig (global::Org.Eclipse.Jgit.Transport.TransferConfig tc)
		{
			const string __id = "setTransferConfig.(Lorg/eclipse/jgit/transport/TransferConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tc).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (tc);
			}
		}

		static Delegate cb_upload_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetUpload_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_upload_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_ == null)
				cb_upload_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Upload_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_);
			return cb_upload_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_;
		}

		static void n_Upload_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input, IntPtr native_output, IntPtr native_messages)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.UploadPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_input, JniHandleOwnership.DoNotTransfer);
			var output = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_output, JniHandleOwnership.DoNotTransfer);
			var messages = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_messages, JniHandleOwnership.DoNotTransfer);
			__this.Upload (input, output, messages);
		}
#pragma warning restore 0169

		/// <param name="input">raw input to read client commands from. Caller must ensure the
		///            input is buffered, otherwise read performance may suffer.</param>
		/// <param name="output">response back to the Git network client, to write the pack
		///            data onto. Caller must ensure the output is buffered,
		///            otherwise write performance may suffer.</param>
		/// <param name="messages">secondary "notice" channel to send additional messages out
		///            through. When run over SSH this should be tied back to the
		///            standard error channel of the command execution. For most
		///            other network connections this should be null.</param>
		/// <summary>Execute the upload task on the socket.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='UploadPack']/method[@name='upload' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='java.io.OutputStream']]"
		[Register ("upload", "(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/io/OutputStream;)V", "GetUpload_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Upload (global::System.IO.Stream input, global::System.IO.Stream output, global::System.IO.Stream messages)
		{
			const string __id = "upload.(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/io/OutputStream;)V";
			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			IntPtr native_output = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (output);
			IntPtr native_messages = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (messages);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (native_output);
				__args [2] = new JniArgumentValue (native_messages);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_output);
				JNIEnv.DeleteLocalRef (native_messages);
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (output);
				global::System.GC.KeepAlive (messages);
			}
		}

	}
}
