using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>A command being processed by <c>BaseReceivePack</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/ReceiveCommand", DoNotGenerateAcw=true)]
	public partial class ReceiveCommand : global::Java.Lang.Object {
		/// <summary>Result of the update command.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/ReceiveCommand$Result", DoNotGenerateAcw=true)]
		public sealed partial class Result : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/field[@name='LOCK_FAILURE']"
			[Register ("LOCK_FAILURE")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result LockFailure {
				get {
					const string __id = "LOCK_FAILURE.Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/field[@name='NOT_ATTEMPTED']"
			[Register ("NOT_ATTEMPTED")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result NotAttempted {
				get {
					const string __id = "NOT_ATTEMPTED.Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/field[@name='OK']"
			[Register ("OK")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result Ok {
				get {
					const string __id = "OK.Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/field[@name='REJECTED_CURRENT_BRANCH']"
			[Register ("REJECTED_CURRENT_BRANCH")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result RejectedCurrentBranch {
				get {
					const string __id = "REJECTED_CURRENT_BRANCH.Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/field[@name='REJECTED_MISSING_OBJECT']"
			[Register ("REJECTED_MISSING_OBJECT")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result RejectedMissingObject {
				get {
					const string __id = "REJECTED_MISSING_OBJECT.Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/field[@name='REJECTED_NOCREATE']"
			[Register ("REJECTED_NOCREATE")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result RejectedNocreate {
				get {
					const string __id = "REJECTED_NOCREATE.Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/field[@name='REJECTED_NODELETE']"
			[Register ("REJECTED_NODELETE")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result RejectedNodelete {
				get {
					const string __id = "REJECTED_NODELETE.Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/field[@name='REJECTED_NONFASTFORWARD']"
			[Register ("REJECTED_NONFASTFORWARD")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result RejectedNonfastforward {
				get {
					const string __id = "REJECTED_NONFASTFORWARD.Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/field[@name='REJECTED_OTHER_REASON']"
			[Register ("REJECTED_OTHER_REASON")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result RejectedOtherReason {
				get {
					const string __id = "REJECTED_OTHER_REASON.Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/ReceiveCommand$Result", typeof (Result));

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

			internal Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/ReceiveCommand$Result;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Result']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/transport/ReceiveCommand$Result;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result));
				} finally {
				}
			}

		}

		/// <summary>Type of operation requested.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Type']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/ReceiveCommand$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Type']/field[@name='CREATE']"
			[Register ("CREATE")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type Create {
				get {
					const string __id = "CREATE.Lorg/eclipse/jgit/transport/ReceiveCommand$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Type']/field[@name='DELETE']"
			[Register ("DELETE")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type Delete {
				get {
					const string __id = "DELETE.Lorg/eclipse/jgit/transport/ReceiveCommand$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Type']/field[@name='UPDATE']"
			[Register ("UPDATE")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type Update {
				get {
					const string __id = "UPDATE.Lorg/eclipse/jgit/transport/ReceiveCommand$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Type']/field[@name='UPDATE_NONFASTFORWARD']"
			[Register ("UPDATE_NONFASTFORWARD")]
			public static global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type UpdateNonfastforward {
				get {
					const string __id = "UPDATE_NONFASTFORWARD.Lorg/eclipse/jgit/transport/ReceiveCommand$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/ReceiveCommand$Type", typeof (Type));

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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/ReceiveCommand$Type;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/ReceiveCommand$Type;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/transport/ReceiveCommand$Type;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/transport/ReceiveCommand$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/ReceiveCommand", typeof (ReceiveCommand));

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

		protected ReceiveCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="oldId">the old object id; must not be null. Use
		///            <c>ObjectId#zeroId()</c> to indicate a ref creation.</param>
		/// <param name="newId">the new object id; must not be null. Use
		///            <c>ObjectId#zeroId()</c> to indicate a ref deletion.</param>
		/// <param name="name">name of the ref being affected.</param>
		/// <summary>Create a new command for <c>BaseReceivePack</c>.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/constructor[@name='ReceiveCommand' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;Ljava/lang/String;)V", "")]
		public unsafe ReceiveCommand (global::Org.Eclipse.Jgit.Lib.ObjectId oldId, global::Org.Eclipse.Jgit.Lib.ObjectId newId, string name) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((oldId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldId).Handle);
				__args [1] = new JniArgumentValue ((newId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newId).Handle);
				__args [2] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (oldId);
				global::System.GC.KeepAlive (newId);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/constructor[@name='ReceiveCommand' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.eclipse.jgit.transport.ReceiveCommand.Type']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;Ljava/lang/String;Lorg/eclipse/jgit/transport/ReceiveCommand$Type;)V", "")]
		public unsafe ReceiveCommand (global::Org.Eclipse.Jgit.Lib.ObjectId oldId, global::Org.Eclipse.Jgit.Lib.ObjectId newId, string name, global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/lib/ObjectId;Ljava/lang/String;Lorg/eclipse/jgit/transport/ReceiveCommand$Type;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((oldId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldId).Handle);
				__args [1] = new JniArgumentValue ((newId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newId).Handle);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (oldId);
				global::System.GC.KeepAlive (newId);
				global::System.GC.KeepAlive (type);
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		/// <returns>the message associated with a failure status.</returns>
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNewId;
#pragma warning disable 0169
		static Delegate GetGetNewIdHandler ()
		{
			if (cb_getNewId == null)
				cb_getNewId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewId);
			return cb_getNewId;
		}

		static IntPtr n_GetNewId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewId);
		}
#pragma warning restore 0169

		/// <returns>the requested new value for this ref.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId NewId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='getNewId' and count(parameter)=0]"
			[Register ("getNewId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetNewIdHandler")]
			get {
				const string __id = "getNewId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldId;
#pragma warning disable 0169
		static Delegate GetGetOldIdHandler ()
		{
			if (cb_getOldId == null)
				cb_getOldId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOldId);
			return cb_getOldId;
		}

		static IntPtr n_GetOldId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldId);
		}
#pragma warning restore 0169

		/// <returns>the old value the client thinks the ref has.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId OldId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='getOldId' and count(parameter)=0]"
			[Register ("getOldId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetOldIdHandler")]
			get {
				const string __id = "getOldId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRef;
#pragma warning disable 0169
		static Delegate GetGetRefHandler ()
		{
			if (cb_getRef == null)
				cb_getRef = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRef);
			return cb_getRef;
		}

		static IntPtr n_GetRef (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ref);
		}
#pragma warning restore 0169

		/// <returns>the ref, if this was advertised by the connection.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.IRef Ref {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='getRef' and count(parameter)=0]"
			[Register ("getRef", "()Lorg/eclipse/jgit/lib/Ref;", "GetGetRefHandler")]
			get {
				const string __id = "getRef.()Lorg/eclipse/jgit/lib/Ref;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefName;
#pragma warning disable 0169
		static Delegate GetGetRefNameHandler ()
		{
			if (cb_getRefName == null)
				cb_getRefName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefName);
			return cb_getRefName;
		}

		static IntPtr n_GetRefName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefName);
		}
#pragma warning restore 0169

		/// <returns>the name of the ref being updated.</returns>
		public virtual unsafe string RefName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='getRefName' and count(parameter)=0]"
			[Register ("getRefName", "()Ljava/lang/String;", "GetGetRefNameHandler")]
			get {
				const string __id = "getRefName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_execute_Lorg_eclipse_jgit_transport_BaseReceivePack_;
#pragma warning disable 0169
		static Delegate GetExecute_Lorg_eclipse_jgit_transport_BaseReceivePack_Handler ()
		{
			if (cb_execute_Lorg_eclipse_jgit_transport_BaseReceivePack_ == null)
				cb_execute_Lorg_eclipse_jgit_transport_BaseReceivePack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Execute_Lorg_eclipse_jgit_transport_BaseReceivePack_);
			return cb_execute_Lorg_eclipse_jgit_transport_BaseReceivePack_;
		}

		static void n_Execute_Lorg_eclipse_jgit_transport_BaseReceivePack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rp = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (native_rp, JniHandleOwnership.DoNotTransfer);
			__this.Execute (rp);
		}
#pragma warning restore 0169

		/// <param name="rp">receive-pack session.</param>
		/// <summary>Execute this command during a receive-pack session.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.BaseReceivePack']]"
		[Register ("execute", "(Lorg/eclipse/jgit/transport/BaseReceivePack;)V", "GetExecute_Lorg_eclipse_jgit_transport_BaseReceivePack_Handler")]
		public virtual unsafe void Execute (global::Org.Eclipse.Jgit.Transport.BaseReceivePack rp)
		{
			const string __id = "execute.(Lorg/eclipse/jgit/transport/BaseReceivePack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rp);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='filter' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.eclipse.jgit.transport.ReceiveCommand&gt;'] and parameter[2][@type='org.eclipse.jgit.transport.ReceiveCommand.Result']]"
		[Register ("filter", "(Ljava/util/List;Lorg/eclipse/jgit/transport/ReceiveCommand$Result;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> Filter (global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> commands, global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result want)
		{
			const string __id = "filter.(Ljava/util/List;Lorg/eclipse/jgit/transport/ReceiveCommand$Result;)Ljava/util/List;";
			IntPtr native_commands = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.ToLocalJniHandle (commands);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_commands);
				__args [1] = new JniArgumentValue ((want == null) ? IntPtr.Zero : ((global::Java.Lang.Object) want).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_commands);
				global::System.GC.KeepAlive (commands);
				global::System.GC.KeepAlive (want);
			}
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetResult ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='getResult' and count(parameter)=0]"
		[Register ("getResult", "()Lorg/eclipse/jgit/transport/ReceiveCommand$Result;", "GetGetResultHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result GetResult ()
		{
			const string __id = "getResult.()Lorg/eclipse/jgit/transport/ReceiveCommand$Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lorg/eclipse/jgit/transport/ReceiveCommand$Type;", "GetGetTypeHandler")]
		public new virtual unsafe global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type GetType ()
		{
			const string __id = "getType.()Lorg/eclipse/jgit/transport/ReceiveCommand$Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setResult_Lorg_eclipse_jgit_lib_RefUpdate_Result_;
#pragma warning disable 0169
		static Delegate GetSetResult_Lorg_eclipse_jgit_lib_RefUpdate_Result_Handler ()
		{
			if (cb_setResult_Lorg_eclipse_jgit_lib_RefUpdate_Result_ == null)
				cb_setResult_Lorg_eclipse_jgit_lib_RefUpdate_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResult_Lorg_eclipse_jgit_lib_RefUpdate_Result_);
			return cb_setResult_Lorg_eclipse_jgit_lib_RefUpdate_Result_;
		}

		static void n_SetResult_Lorg_eclipse_jgit_lib_RefUpdate_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var r = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.RefUpdate.Result> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.SetResult (r);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='setResult' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.RefUpdate.Result']]"
		[Register ("setResult", "(Lorg/eclipse/jgit/lib/RefUpdate$Result;)V", "GetSetResult_Lorg_eclipse_jgit_lib_RefUpdate_Result_Handler")]
		public virtual unsafe void SetResult (global::Org.Eclipse.Jgit.Lib.RefUpdate.Result r)
		{
			const string __id = "setResult.(Lorg/eclipse/jgit/lib/RefUpdate$Result;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (r);
			}
		}

		static Delegate cb_setResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_;
#pragma warning disable 0169
		static Delegate GetSetResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Handler ()
		{
			if (cb_setResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_ == null)
				cb_setResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_);
			return cb_setResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_;
		}

		static void n_SetResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.SetResult (s);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='setResult' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.ReceiveCommand.Result']]"
		[Register ("setResult", "(Lorg/eclipse/jgit/transport/ReceiveCommand$Result;)V", "GetSetResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Handler")]
		public virtual unsafe void SetResult (global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result s)
		{
			const string __id = "setResult.(Lorg/eclipse/jgit/transport/ReceiveCommand$Result;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_setResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Ljava_lang_String_Handler ()
		{
			if (cb_setResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Ljava_lang_String_ == null)
				cb_setResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Ljava_lang_String_);
			return cb_setResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Ljava_lang_String_;
		}

		static void n_SetResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_m)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (native_s, JniHandleOwnership.DoNotTransfer);
			var m = JNIEnv.GetString (native_m, JniHandleOwnership.DoNotTransfer);
			__this.SetResult (s, m);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='setResult' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.ReceiveCommand.Result'] and parameter[2][@type='java.lang.String']]"
		[Register ("setResult", "(Lorg/eclipse/jgit/transport/ReceiveCommand$Result;Ljava/lang/String;)V", "GetSetResult_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Ljava_lang_String_Handler")]
		public virtual unsafe void SetResult (global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result s, string m)
		{
			const string __id = "setResult.(Lorg/eclipse/jgit/transport/ReceiveCommand$Result;Ljava/lang/String;)V";
			IntPtr native_m = JNIEnv.NewString ((string)m);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				__args [1] = new JniArgumentValue (native_m);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_m);
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate cb_updateType_Lorg_eclipse_jgit_revwalk_RevWalk_;
#pragma warning disable 0169
		static Delegate GetUpdateType_Lorg_eclipse_jgit_revwalk_RevWalk_Handler ()
		{
			if (cb_updateType_Lorg_eclipse_jgit_revwalk_RevWalk_ == null)
				cb_updateType_Lorg_eclipse_jgit_revwalk_RevWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UpdateType_Lorg_eclipse_jgit_revwalk_RevWalk_);
			return cb_updateType_Lorg_eclipse_jgit_revwalk_RevWalk_;
		}

		static void n_UpdateType_Lorg_eclipse_jgit_revwalk_RevWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walk)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			__this.UpdateType (walk);
		}
#pragma warning restore 0169

		/// <param name="walk">an instance to perform the merge test with. The caller must
		///            allocate and release this object.</param>
		/// <summary>Update the type of this command by checking for fast-forward.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='ReceiveCommand']/method[@name='updateType' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk']]"
		[Register ("updateType", "(Lorg/eclipse/jgit/revwalk/RevWalk;)V", "GetUpdateType_Lorg_eclipse_jgit_revwalk_RevWalk_Handler")]
		public virtual unsafe void UpdateType (global::Org.Eclipse.Jgit.Revwalk.RevWalk walk)
		{
			const string __id = "updateType.(Lorg/eclipse/jgit/revwalk/RevWalk;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((walk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) walk).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (walk);
			}
		}

	}
}
