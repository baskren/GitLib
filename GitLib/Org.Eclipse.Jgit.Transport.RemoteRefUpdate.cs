using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Represent request and status of a remote ref update.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/RemoteRefUpdate", DoNotGenerateAcw=true)]
	public partial class RemoteRefUpdate : global::Java.Lang.Object {
		/// <summary>Represent current status of a remote ref update.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/RemoteRefUpdate$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/field[@name='AWAITING_REPORT']"
			[Register ("AWAITING_REPORT")]
			public static global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status AwaitingReport {
				get {
					const string __id = "AWAITING_REPORT.Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/field[@name='NON_EXISTING']"
			[Register ("NON_EXISTING")]
			public static global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status NonExisting {
				get {
					const string __id = "NON_EXISTING.Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/field[@name='NOT_ATTEMPTED']"
			[Register ("NOT_ATTEMPTED")]
			public static global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status NotAttempted {
				get {
					const string __id = "NOT_ATTEMPTED.Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/field[@name='OK']"
			[Register ("OK")]
			public static global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status Ok {
				get {
					const string __id = "OK.Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/field[@name='REJECTED_NODELETE']"
			[Register ("REJECTED_NODELETE")]
			public static global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status RejectedNodelete {
				get {
					const string __id = "REJECTED_NODELETE.Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/field[@name='REJECTED_NONFASTFORWARD']"
			[Register ("REJECTED_NONFASTFORWARD")]
			public static global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status RejectedNonfastforward {
				get {
					const string __id = "REJECTED_NONFASTFORWARD.Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/field[@name='REJECTED_OTHER_REASON']"
			[Register ("REJECTED_OTHER_REASON")]
			public static global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status RejectedOtherReason {
				get {
					const string __id = "REJECTED_OTHER_REASON.Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/field[@name='REJECTED_REMOTE_CHANGED']"
			[Register ("REJECTED_REMOTE_CHANGED")]
			public static global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status RejectedRemoteChanged {
				get {
					const string __id = "REJECTED_REMOTE_CHANGED.Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/field[@name='UP_TO_DATE']"
			[Register ("UP_TO_DATE")]
			public static global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status UpToDate {
				get {
					const string __id = "UP_TO_DATE.Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RemoteRefUpdate$Status", typeof (Status));

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

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/RemoteRefUpdate", typeof (RemoteRefUpdate));

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

		protected RemoteRefUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="localDb">local repository to push from.</param>
		/// <param name="srcRef">source revision - any string resolvable by
		///            <c>Repository#resolve(String)</c>. This resolves to the new
		///            object that the caller want remote ref to be after update. Use
		///            null or <c>ObjectId#zeroId()</c> string for delete request.</param>
		/// <param name="remoteName">full name of a remote ref to update, e.g. "refs/heads/master"
		///            (no wildcard, no short name).</param>
		/// <param name="forceUpdate">true when caller want remote ref to be updated regardless
		///            whether it is fast-forward update (old object is ancestor of
		///            new object).</param>
		/// <param name="localName">optional full name of a local stored tracking branch, to
		///            update after push, e.g. "refs/remotes/zawir/dirty" (no
		///            wildcard, no short name); null if no local tracking branch
		///            should be updated.</param>
		/// <param name="expectedOldObjectId">optional object id that caller is expecting, requiring to be
		///            advertised by remote side before update; update will take
		///            place ONLY if remote side advertise exactly this expected id;
		///            null if caller doesn't care what object id remote side
		///            advertise. Use <c>ObjectId#zeroId()</c> when expecting no
		///            remote ref with this name.</param>
		/// <summary>Construct remote ref update request by providing an update specification.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/constructor[@name='RemoteRefUpdate' and count(parameter)=6 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)V", "")]
		public unsafe RemoteRefUpdate (global::Org.Eclipse.Jgit.Lib.Repository localDb, string srcRef, string remoteName, bool forceUpdate, string localName, global::Org.Eclipse.Jgit.Lib.ObjectId expectedOldObjectId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_srcRef = JNIEnv.NewString ((string)srcRef);
			IntPtr native_remoteName = JNIEnv.NewString ((string)remoteName);
			IntPtr native_localName = JNIEnv.NewString ((string)localName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((localDb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localDb).Handle);
				__args [1] = new JniArgumentValue (native_srcRef);
				__args [2] = new JniArgumentValue (native_remoteName);
				__args [3] = new JniArgumentValue (forceUpdate);
				__args [4] = new JniArgumentValue (native_localName);
				__args [5] = new JniArgumentValue ((expectedOldObjectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expectedOldObjectId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_srcRef);
				JNIEnv.DeleteLocalRef (native_remoteName);
				JNIEnv.DeleteLocalRef (native_localName);
				global::System.GC.KeepAlive (localDb);
				global::System.GC.KeepAlive (expectedOldObjectId);
			}
		}

		/// <param name="localDb">local repository to push from.</param>
		/// <param name="srcRef">source revision to label srcId with. If null srcId.name() will
		///            be used instead.</param>
		/// <param name="srcId">The new object that the caller wants remote ref to be after
		///            update. Use null or <c>ObjectId#zeroId()</c> for delete
		///            request.</param>
		/// <param name="remoteName">full name of a remote ref to update, e.g. "refs/heads/master"
		///            (no wildcard, no short name).</param>
		/// <param name="forceUpdate">true when caller want remote ref to be updated regardless
		///            whether it is fast-forward update (old object is ancestor of
		///            new object).</param>
		/// <param name="localName">optional full name of a local stored tracking branch, to
		///            update after push, e.g. "refs/remotes/zawir/dirty" (no
		///            wildcard, no short name); null if no local tracking branch
		///            should be updated.</param>
		/// <param name="expectedOldObjectId">optional object id that caller is expecting, requiring to be
		///            advertised by remote side before update; update will take
		///            place ONLY if remote side advertise exactly this expected id;
		///            null if caller doesn't care what object id remote side
		///            advertise. Use <c>ObjectId#zeroId()</c> when expecting no
		///            remote ref with this name.</param>
		/// <summary>Construct remote ref update request by providing an update specification.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/constructor[@name='RemoteRefUpdate' and count(parameter)=7 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;Ljava/lang/String;ZLjava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)V", "")]
		public unsafe RemoteRefUpdate (global::Org.Eclipse.Jgit.Lib.Repository localDb, string srcRef, global::Org.Eclipse.Jgit.Lib.ObjectId srcId, string remoteName, bool forceUpdate, string localName, global::Org.Eclipse.Jgit.Lib.ObjectId expectedOldObjectId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;Ljava/lang/String;ZLjava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_srcRef = JNIEnv.NewString ((string)srcRef);
			IntPtr native_remoteName = JNIEnv.NewString ((string)remoteName);
			IntPtr native_localName = JNIEnv.NewString ((string)localName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((localDb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localDb).Handle);
				__args [1] = new JniArgumentValue (native_srcRef);
				__args [2] = new JniArgumentValue ((srcId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcId).Handle);
				__args [3] = new JniArgumentValue (native_remoteName);
				__args [4] = new JniArgumentValue (forceUpdate);
				__args [5] = new JniArgumentValue (native_localName);
				__args [6] = new JniArgumentValue ((expectedOldObjectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expectedOldObjectId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_srcRef);
				JNIEnv.DeleteLocalRef (native_remoteName);
				JNIEnv.DeleteLocalRef (native_localName);
				global::System.GC.KeepAlive (localDb);
				global::System.GC.KeepAlive (srcId);
				global::System.GC.KeepAlive (expectedOldObjectId);
			}
		}

		/// <param name="localDb">local repository to push from.</param>
		/// <param name="srcRef">source revision. Use null to delete.</param>
		/// <param name="remoteName">full name of a remote ref to update, e.g. "refs/heads/master"
		///            (no wildcard, no short name).</param>
		/// <param name="forceUpdate">true when caller want remote ref to be updated regardless
		///            whether it is fast-forward update (old object is ancestor of
		///            new object).</param>
		/// <param name="localName">optional full name of a local stored tracking branch, to
		///            update after push, e.g. "refs/remotes/zawir/dirty" (no
		///            wildcard, no short name); null if no local tracking branch
		///            should be updated.</param>
		/// <param name="expectedOldObjectId">optional object id that caller is expecting, requiring to be
		///            advertised by remote side before update; update will take
		///            place ONLY if remote side advertise exactly this expected id;
		///            null if caller doesn't care what object id remote side
		///            advertise. Use <c>ObjectId#zeroId()</c> when expecting no
		///            remote ref with this name.</param>
		/// <summary>Construct remote ref update request by providing an update specification.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/constructor[@name='RemoteRefUpdate' and count(parameter)=6 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.lib.Ref'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/Ref;Ljava/lang/String;ZLjava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)V", "")]
		public unsafe RemoteRefUpdate (global::Org.Eclipse.Jgit.Lib.Repository localDb, global::Org.Eclipse.Jgit.Lib.IRef srcRef, string remoteName, bool forceUpdate, string localName, global::Org.Eclipse.Jgit.Lib.ObjectId expectedOldObjectId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/Ref;Ljava/lang/String;ZLjava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_remoteName = JNIEnv.NewString ((string)remoteName);
			IntPtr native_localName = JNIEnv.NewString ((string)localName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((localDb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localDb).Handle);
				__args [1] = new JniArgumentValue ((srcRef == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcRef).Handle);
				__args [2] = new JniArgumentValue (native_remoteName);
				__args [3] = new JniArgumentValue (forceUpdate);
				__args [4] = new JniArgumentValue (native_localName);
				__args [5] = new JniArgumentValue ((expectedOldObjectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expectedOldObjectId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_remoteName);
				JNIEnv.DeleteLocalRef (native_localName);
				global::System.GC.KeepAlive (localDb);
				global::System.GC.KeepAlive (srcRef);
				global::System.GC.KeepAlive (expectedOldObjectId);
			}
		}

		/// <param name="base">configuration base.</param>
		/// <param name="newExpectedOldObjectId">new expected object id value.</param>
		/// <summary>Create a new instance of this object basing on existing instance for
		/// configuration.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/constructor[@name='RemoteRefUpdate' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.RemoteRefUpdate'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/transport/RemoteRefUpdate;Lorg/eclipse/jgit/lib/ObjectId;)V", "")]
		public unsafe RemoteRefUpdate (global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate @base, global::Org.Eclipse.Jgit.Lib.ObjectId newExpectedOldObjectId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/transport/RemoteRefUpdate;Lorg/eclipse/jgit/lib/ObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [1] = new JniArgumentValue ((newExpectedOldObjectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newExpectedOldObjectId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@base);
				global::System.GC.KeepAlive (newExpectedOldObjectId);
			}
		}

		static Delegate cb_getExpectedOldObjectId;
#pragma warning disable 0169
		static Delegate GetGetExpectedOldObjectIdHandler ()
		{
			if (cb_getExpectedOldObjectId == null)
				cb_getExpectedOldObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExpectedOldObjectId);
			return cb_getExpectedOldObjectId;
		}

		static IntPtr n_GetExpectedOldObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpectedOldObjectId);
		}
#pragma warning restore 0169

		/// <returns>expectedOldObjectId required to be advertised by remote side, as
		///         set in constructor; may be null.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ExpectedOldObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='getExpectedOldObjectId' and count(parameter)=0]"
			[Register ("getExpectedOldObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetExpectedOldObjectIdHandler")]
			get {
				const string __id = "getExpectedOldObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasTrackingRefUpdate;
#pragma warning disable 0169
		static Delegate GetHasTrackingRefUpdateHandler ()
		{
			if (cb_hasTrackingRefUpdate == null)
				cb_hasTrackingRefUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasTrackingRefUpdate);
			return cb_hasTrackingRefUpdate;
		}

		static bool n_HasTrackingRefUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTrackingRefUpdate;
		}
#pragma warning restore 0169

		/// <returns>true if user specified a local tracking branch for remote update;
		///         false otherwise.</returns>
		public virtual unsafe bool HasTrackingRefUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='hasTrackingRefUpdate' and count(parameter)=0]"
			[Register ("hasTrackingRefUpdate", "()Z", "GetHasTrackingRefUpdateHandler")]
			get {
				const string __id = "hasTrackingRefUpdate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDelete;
#pragma warning disable 0169
		static Delegate GetIsDeleteHandler ()
		{
			if (cb_isDelete == null)
				cb_isDelete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDelete);
			return cb_isDelete;
		}

		static bool n_IsDelete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDelete;
		}
#pragma warning restore 0169

		/// <returns>true if this update is deleting update; false otherwise.</returns>
		public virtual unsafe bool IsDelete {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='isDelete' and count(parameter)=0]"
			[Register ("isDelete", "()Z", "GetIsDeleteHandler")]
			get {
				const string __id = "isDelete.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isExpectingOldObjectId;
#pragma warning disable 0169
		static Delegate GetIsExpectingOldObjectIdHandler ()
		{
			if (cb_isExpectingOldObjectId == null)
				cb_isExpectingOldObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExpectingOldObjectId);
			return cb_isExpectingOldObjectId;
		}

		static bool n_IsExpectingOldObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpectingOldObjectId;
		}
#pragma warning restore 0169

		/// <returns>true if some object is required to be advertised by remote side,
		///         as set in constructor; false otherwise.</returns>
		public virtual unsafe bool IsExpectingOldObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='isExpectingOldObjectId' and count(parameter)=0]"
			[Register ("isExpectingOldObjectId", "()Z", "GetIsExpectingOldObjectIdHandler")]
			get {
				const string __id = "isExpectingOldObjectId.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isFastForward;
#pragma warning disable 0169
		static Delegate GetIsFastForwardHandler ()
		{
			if (cb_isFastForward == null)
				cb_isFastForward = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFastForward);
			return cb_isFastForward;
		}

		static bool n_IsFastForward (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFastForward;
		}
#pragma warning restore 0169

		/// <summary>Check whether update was fast-forward.</summary>
		/// <returns>true if update was fast-forward; false otherwise.</returns>
		public virtual unsafe bool IsFastForward {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='isFastForward' and count(parameter)=0]"
			[Register ("isFastForward", "()Z", "GetIsFastForwardHandler")]
			get {
				const string __id = "isFastForward.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isForceUpdate;
#pragma warning disable 0169
		static Delegate GetIsForceUpdateHandler ()
		{
			if (cb_isForceUpdate == null)
				cb_isForceUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsForceUpdate);
			return cb_isForceUpdate;
		}

		static bool n_IsForceUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsForceUpdate;
		}
#pragma warning restore 0169

		/// <returns>true if this update is forced regardless of old remote ref
		///         object; false otherwise.</returns>
		public virtual unsafe bool IsForceUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='isForceUpdate' and count(parameter)=0]"
			[Register ("isForceUpdate", "()Z", "GetIsForceUpdateHandler")]
			get {
				const string __id = "isForceUpdate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		/// <returns>message describing reasons of status when needed/possible; may be
		///         null.</returns>
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='getMessage' and count(parameter)=0]"
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

		static Delegate cb_getNewObjectId;
#pragma warning disable 0169
		static Delegate GetGetNewObjectIdHandler ()
		{
			if (cb_getNewObjectId == null)
				cb_getNewObjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewObjectId);
			return cb_getNewObjectId;
		}

		static IntPtr n_GetNewObjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewObjectId);
		}
#pragma warning restore 0169

		/// <returns>newObjectId for remote ref, as set in constructor.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId NewObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='getNewObjectId' and count(parameter)=0]"
			[Register ("getNewObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "GetGetNewObjectIdHandler")]
			get {
				const string __id = "getNewObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoteName;
#pragma warning disable 0169
		static Delegate GetGetRemoteNameHandler ()
		{
			if (cb_getRemoteName == null)
				cb_getRemoteName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemoteName);
			return cb_getRemoteName;
		}

		static IntPtr n_GetRemoteName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemoteName);
		}
#pragma warning restore 0169

		/// <returns>name of remote ref to update, as set in constructor.</returns>
		public virtual unsafe string RemoteName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='getRemoteName' and count(parameter)=0]"
			[Register ("getRemoteName", "()Ljava/lang/String;", "GetGetRemoteNameHandler")]
			get {
				const string __id = "getRemoteName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSrcRef;
#pragma warning disable 0169
		static Delegate GetGetSrcRefHandler ()
		{
			if (cb_getSrcRef == null)
				cb_getSrcRef = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSrcRef);
			return cb_getSrcRef;
		}

		static IntPtr n_GetSrcRef (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SrcRef);
		}
#pragma warning restore 0169

		/// <returns>source revision as specified by user (in constructor), could be
		///         any string parseable by <c>Repository#resolve(String)</c>; can
		///         be null if specified that way in constructor - this stands for
		///         delete request.</returns>
		public virtual unsafe string SrcRef {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='getSrcRef' and count(parameter)=0]"
			[Register ("getSrcRef", "()Ljava/lang/String;", "GetGetSrcRefHandler")]
			get {
				const string __id = "getSrcRef.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingRefUpdate;
#pragma warning disable 0169
		static Delegate GetGetTrackingRefUpdateHandler ()
		{
			if (cb_getTrackingRefUpdate == null)
				cb_getTrackingRefUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTrackingRefUpdate);
			return cb_getTrackingRefUpdate;
		}

		static IntPtr n_GetTrackingRefUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingRefUpdate);
		}
#pragma warning restore 0169

		/// <returns>local tracking branch update if localName was set in constructor.</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate TrackingRefUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='getTrackingRefUpdate' and count(parameter)=0]"
			[Register ("getTrackingRefUpdate", "()Lorg/eclipse/jgit/transport/TrackingRefUpdate;", "GetGetTrackingRefUpdateHandler")]
			get {
				const string __id = "getTrackingRefUpdate.()Lorg/eclipse/jgit/transport/TrackingRefUpdate;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.TrackingRefUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;", "GetGetStatusHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status GetStatus ()
		{
			const string __id = "getStatus.()Lorg/eclipse/jgit/transport/RemoteRefUpdate$Status;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_updateTrackingRef_Lorg_eclipse_jgit_revwalk_RevWalk_;
#pragma warning disable 0169
		static Delegate GetUpdateTrackingRef_Lorg_eclipse_jgit_revwalk_RevWalk_Handler ()
		{
			if (cb_updateTrackingRef_Lorg_eclipse_jgit_revwalk_RevWalk_ == null)
				cb_updateTrackingRef_Lorg_eclipse_jgit_revwalk_RevWalk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UpdateTrackingRef_Lorg_eclipse_jgit_revwalk_RevWalk_);
			return cb_updateTrackingRef_Lorg_eclipse_jgit_revwalk_RevWalk_;
		}

		static void n_UpdateTrackingRef_Lorg_eclipse_jgit_revwalk_RevWalk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_walk)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RemoteRefUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var walk = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevWalk> (native_walk, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTrackingRef (walk);
		}
#pragma warning restore 0169

		/// <param name="walk">walker used for checking update properties.</param>
		/// <summary>Update locally stored tracking branch with the new object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='RemoteRefUpdate']/method[@name='updateTrackingRef' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevWalk']]"
		[Register ("updateTrackingRef", "(Lorg/eclipse/jgit/revwalk/RevWalk;)V", "GetUpdateTrackingRef_Lorg_eclipse_jgit_revwalk_RevWalk_Handler")]
		protected virtual unsafe void UpdateTrackingRef (global::Org.Eclipse.Jgit.Revwalk.RevWalk walk)
		{
			const string __id = "updateTrackingRef.(Lorg/eclipse/jgit/revwalk/RevWalk;)V";
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
