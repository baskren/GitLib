using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Base implementation of the side of a push connection that receives objects.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BaseReceivePack", DoNotGenerateAcw=true)]
	public abstract partial class BaseReceivePack : global::Java.Lang.Object {

		/// <summary>Optional message output stream.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/field[@name='msgOut']"
		[Register ("msgOut")]
		protected global::System.IO.Stream MsgOut {
			get {
				const string __id = "msgOut.Ljava/io/OutputStream;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "msgOut.Ljava/io/OutputStream;";

				IntPtr native_value = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Packet line input stream around <c>#rawIn</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/field[@name='pckIn']"
		[Register ("pckIn")]
		protected global::Org.Eclipse.Jgit.Transport.PacketLineIn PckIn {
			get {
				const string __id = "pckIn.Lorg/eclipse/jgit/transport/PacketLineIn;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PacketLineIn> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pckIn.Lorg/eclipse/jgit/transport/PacketLineIn;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Packet line output stream around <c>#rawOut</c>.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/field[@name='pckOut']"
		[Register ("pckOut")]
		protected global::Org.Eclipse.Jgit.Transport.PacketLineOut PckOut {
			get {
				const string __id = "pckOut.Lorg/eclipse/jgit/transport/PacketLineOut;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PacketLineOut> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pckOut.Lorg/eclipse/jgit/transport/PacketLineOut;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Raw input stream.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/field[@name='rawIn']"
		[Register ("rawIn")]
		protected global::System.IO.Stream RawIn {
			get {
				const string __id = "rawIn.Ljava/io/InputStream;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rawIn.Ljava/io/InputStream;";

				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		/// <summary>Raw output stream.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/field[@name='rawOut']"
		[Register ("rawOut")]
		protected global::System.IO.Stream RawOut {
			get {
				const string __id = "rawOut.Ljava/io/OutputStream;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rawOut.Ljava/io/OutputStream;";

				IntPtr native_value = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		/// <summary>Data in the first line of a request, the line itself plus capabilities.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack.FirstLine']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BaseReceivePack$FirstLine", DoNotGenerateAcw=true)]
		public partial class FirstLine : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BaseReceivePack$FirstLine", typeof (FirstLine));

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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack.FirstLine']/constructor[@name='BaseReceivePack.FirstLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			static Delegate cb_getCapabilities;
#pragma warning disable 0169
			static Delegate GetGetCapabilitiesHandler ()
			{
				if (cb_getCapabilities == null)
					cb_getCapabilities = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCapabilities);
				return cb_getCapabilities;
			}

			static IntPtr n_GetCapabilities (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack.FirstLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Capabilities);
			}
#pragma warning restore 0169

			/// <returns>capabilities parsed from the line.</returns>
			public virtual unsafe global::System.Collections.Generic.ICollection<string> Capabilities {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack.FirstLine']/method[@name='getCapabilities' and count(parameter)=0]"
				[Register ("getCapabilities", "()Ljava/util/Set;", "GetGetCapabilitiesHandler")]
				get {
					const string __id = "getCapabilities.()Ljava/util/Set;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack.FirstLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Line);
			}
#pragma warning restore 0169

			/// <returns>non-capabilities part of the line.</returns>
			public virtual unsafe string Line {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack.FirstLine']/method[@name='getLine' and count(parameter)=0]"
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

		}

		/// <summary>Configuration for receive operations.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack.ReceiveConfig']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BaseReceivePack$ReceiveConfig", DoNotGenerateAcw=true)]
		protected internal partial class ReceiveConfig : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BaseReceivePack$ReceiveConfig", typeof (ReceiveConfig));

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

			protected ReceiveConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BaseReceivePack", typeof (BaseReceivePack));

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

		protected BaseReceivePack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="into">the destination repository.</param>
		/// <summary>Create a new pack receive for an open repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/constructor[@name='BaseReceivePack' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe BaseReceivePack (global::Org.Eclipse.Jgit.Lib.Repository into) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((into == null) ? IntPtr.Zero : ((global::Java.Lang.Object) into).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (into);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var advertiseRefsHook = (global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> (native_advertiseRefsHook, JniHandleOwnership.DoNotTransfer);
			__this.AdvertiseRefsHook = advertiseRefsHook;
		}
#pragma warning restore 0169

		/// <returns>the hook used while advertising the refs to the client</returns>
		/// <summary>Set the hook used while advertising the refs to the client.</summary>
		/// <param name="advertiseRefsHook">the hook; may be null to show all refs.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook AdvertiseRefsHook {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getAdvertiseRefsHook' and count(parameter)=0]"
			[Register ("getAdvertiseRefsHook", "()Lorg/eclipse/jgit/transport/AdvertiseRefsHook;", "GetGetAdvertiseRefsHookHandler")]
			get {
				const string __id = "getAdvertiseRefsHook.()Lorg/eclipse/jgit/transport/AdvertiseRefsHook;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IAdvertiseRefsHook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setAdvertiseRefsHook' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.AdvertiseRefsHook']]"
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

		/// <summary>Get objects advertised to the client.</summary>
		/// <returns>the set of objects advertised to the as present in this repository,
		///         or null if <c>#setAdvertisedRefs(Map, Set)</c> has not been called
		///         yet.</returns>
		public unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> AdvertisedObjects {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getAdvertisedObjects' and count(parameter)=0]"
			[Register ("getAdvertisedObjects", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getAdvertisedObjects.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdvertisedOrDefaultRefs;
#pragma warning disable 0169
		static Delegate GetGetAdvertisedOrDefaultRefsHandler ()
		{
			if (cb_getAdvertisedOrDefaultRefs == null)
				cb_getAdvertisedOrDefaultRefs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdvertisedOrDefaultRefs);
			return cb_getAdvertisedOrDefaultRefs;
		}

		static IntPtr n_GetAdvertisedOrDefaultRefs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (__this.AdvertisedOrDefaultRefs);
		}
#pragma warning restore 0169

		/// <returns>advertised refs, or the default if not explicitly advertised.</returns>
		protected virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> AdvertisedOrDefaultRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getAdvertisedOrDefaultRefs' and count(parameter)=0]"
			[Register ("getAdvertisedOrDefaultRefs", "()Ljava/util/Map;", "GetGetAdvertisedOrDefaultRefsHandler")]
			get {
				const string __id = "getAdvertisedOrDefaultRefs.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <summary>Get refs which were advertised to the client.</summary>
		/// <returns>all refs which were advertised to the client, or null if
		///         <c>#setAdvertisedRefs(Map, Set)</c> has not been called yet.</returns>
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> AdvertisedRefs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getAdvertisedRefs' and count(parameter)=0]"
			[Register ("getAdvertisedRefs", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getAdvertisedRefs.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAllCommands;
#pragma warning disable 0169
		static Delegate GetGetAllCommandsHandler ()
		{
			if (cb_getAllCommands == null)
				cb_getAllCommands = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllCommands);
			return cb_getAllCommands;
		}

		static IntPtr n_GetAllCommands (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.ToLocalJniHandle (__this.AllCommands);
		}
#pragma warning restore 0169

		/// <returns>all of the command received by the current request.</returns>
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> AllCommands {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getAllCommands' and count(parameter)=0]"
			[Register ("getAllCommands", "()Ljava/util/List;", "GetGetAllCommandsHandler")]
			get {
				const string __id = "getAllCommands.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAllowBranchDeletes;
#pragma warning disable 0169
		static Delegate GetIsAllowBranchDeletesHandler ()
		{
			if (cb_isAllowBranchDeletes == null)
				cb_isAllowBranchDeletes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAllowBranchDeletes);
			return cb_isAllowBranchDeletes;
		}

		static bool n_IsAllowBranchDeletes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowBranchDeletes;
		}
#pragma warning restore 0169

		static Delegate cb_setAllowBranchDeletes_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowBranchDeletes_ZHandler ()
		{
			if (cb_setAllowBranchDeletes_Z == null)
				cb_setAllowBranchDeletes_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAllowBranchDeletes_Z);
			return cb_setAllowBranchDeletes_Z;
		}

		static void n_SetAllowBranchDeletes_Z (IntPtr jnienv, IntPtr native__this, bool canDelete)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowBranchDeletes = canDelete;
		}
#pragma warning restore 0169

		/// <returns>true if the client can delete from <c>refs/heads/</c>.</returns>
		/// <param name="canDelete">true to permit deletion of branches from the
		///            <c>refs/heads/</c> namespace.</param>
		public virtual unsafe bool AllowBranchDeletes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isAllowBranchDeletes' and count(parameter)=0]"
			[Register ("isAllowBranchDeletes", "()Z", "GetIsAllowBranchDeletesHandler")]
			get {
				const string __id = "isAllowBranchDeletes.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setAllowBranchDeletes' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowBranchDeletes", "(Z)V", "GetSetAllowBranchDeletes_ZHandler")]
			set {
				const string __id = "setAllowBranchDeletes.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAllowCreates;
#pragma warning disable 0169
		static Delegate GetIsAllowCreatesHandler ()
		{
			if (cb_isAllowCreates == null)
				cb_isAllowCreates = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAllowCreates);
			return cb_isAllowCreates;
		}

		static bool n_IsAllowCreates (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowCreates;
		}
#pragma warning restore 0169

		static Delegate cb_setAllowCreates_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowCreates_ZHandler ()
		{
			if (cb_setAllowCreates_Z == null)
				cb_setAllowCreates_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAllowCreates_Z);
			return cb_setAllowCreates_Z;
		}

		static void n_SetAllowCreates_Z (IntPtr jnienv, IntPtr native__this, bool canCreate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowCreates = canCreate;
		}
#pragma warning restore 0169

		/// <returns>true if the client can request refs to be created.</returns>
		/// <param name="canCreate">true to permit create ref commands to be processed.</param>
		public virtual unsafe bool AllowCreates {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isAllowCreates' and count(parameter)=0]"
			[Register ("isAllowCreates", "()Z", "GetIsAllowCreatesHandler")]
			get {
				const string __id = "isAllowCreates.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setAllowCreates' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowCreates", "(Z)V", "GetSetAllowCreates_ZHandler")]
			set {
				const string __id = "setAllowCreates.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAllowDeletes;
#pragma warning disable 0169
		static Delegate GetIsAllowDeletesHandler ()
		{
			if (cb_isAllowDeletes == null)
				cb_isAllowDeletes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAllowDeletes);
			return cb_isAllowDeletes;
		}

		static bool n_IsAllowDeletes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowDeletes;
		}
#pragma warning restore 0169

		static Delegate cb_setAllowDeletes_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowDeletes_ZHandler ()
		{
			if (cb_setAllowDeletes_Z == null)
				cb_setAllowDeletes_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAllowDeletes_Z);
			return cb_setAllowDeletes_Z;
		}

		static void n_SetAllowDeletes_Z (IntPtr jnienv, IntPtr native__this, bool canDelete)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowDeletes = canDelete;
		}
#pragma warning restore 0169

		/// <returns>true if the client can request refs to be deleted.</returns>
		/// <param name="canDelete">true to permit delete ref commands to be processed.</param>
		public virtual unsafe bool AllowDeletes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isAllowDeletes' and count(parameter)=0]"
			[Register ("isAllowDeletes", "()Z", "GetIsAllowDeletesHandler")]
			get {
				const string __id = "isAllowDeletes.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setAllowDeletes' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowDeletes", "(Z)V", "GetSetAllowDeletes_ZHandler")]
			set {
				const string __id = "setAllowDeletes.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAllowNonFastForwards;
#pragma warning disable 0169
		static Delegate GetIsAllowNonFastForwardsHandler ()
		{
			if (cb_isAllowNonFastForwards == null)
				cb_isAllowNonFastForwards = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAllowNonFastForwards);
			return cb_isAllowNonFastForwards;
		}

		static bool n_IsAllowNonFastForwards (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowNonFastForwards;
		}
#pragma warning restore 0169

		static Delegate cb_setAllowNonFastForwards_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowNonFastForwards_ZHandler ()
		{
			if (cb_setAllowNonFastForwards_Z == null)
				cb_setAllowNonFastForwards_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAllowNonFastForwards_Z);
			return cb_setAllowNonFastForwards_Z;
		}

		static void n_SetAllowNonFastForwards_Z (IntPtr jnienv, IntPtr native__this, bool canRewind)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowNonFastForwards = canRewind;
		}
#pragma warning restore 0169

		/// <returns>true if the client can request non-fast-forward updates of a ref,
		///         possibly making objects unreachable.</returns>
		/// <param name="canRewind">true to permit the client to ask for non-fast-forward updates
		///            of an existing ref.</param>
		public virtual unsafe bool AllowNonFastForwards {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isAllowNonFastForwards' and count(parameter)=0]"
			[Register ("isAllowNonFastForwards", "()Z", "GetIsAllowNonFastForwardsHandler")]
			get {
				const string __id = "isAllowNonFastForwards.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setAllowNonFastForwards' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowNonFastForwards", "(Z)V", "GetSetAllowNonFastForwards_ZHandler")]
			set {
				const string __id = "setAllowNonFastForwards.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isBiDirectionalPipe' and count(parameter)=0]"
			[Register ("isBiDirectionalPipe", "()Z", "GetIsBiDirectionalPipeHandler")]
			get {
				const string __id = "isBiDirectionalPipe.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setBiDirectionalPipe' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_isCheckReceivedObjects;
#pragma warning disable 0169
		static Delegate GetIsCheckReceivedObjectsHandler ()
		{
			if (cb_isCheckReceivedObjects == null)
				cb_isCheckReceivedObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCheckReceivedObjects);
			return cb_isCheckReceivedObjects;
		}

		static bool n_IsCheckReceivedObjects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckReceivedObjects;
		}
#pragma warning restore 0169

		static Delegate cb_setCheckReceivedObjects_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckReceivedObjects_ZHandler ()
		{
			if (cb_setCheckReceivedObjects_Z == null)
				cb_setCheckReceivedObjects_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCheckReceivedObjects_Z);
			return cb_setCheckReceivedObjects_Z;
		}

		static void n_SetCheckReceivedObjects_Z (IntPtr jnienv, IntPtr native__this, bool check)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckReceivedObjects = check;
		}
#pragma warning restore 0169

		/// <returns>true if this instance will verify received objects are formatted
		///         correctly. Validating objects requires more CPU time on this side
		///         of the connection.</returns>
		/// <param name="check">true to enable checking received objects; false to assume all
		///            received objects are valid.</param>
		public virtual unsafe bool CheckReceivedObjects {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isCheckReceivedObjects' and count(parameter)=0]"
			[Register ("isCheckReceivedObjects", "()Z", "GetIsCheckReceivedObjectsHandler")]
			get {
				const string __id = "isCheckReceivedObjects.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setCheckReceivedObjects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCheckReceivedObjects", "(Z)V", "GetSetCheckReceivedObjects_ZHandler")]
			set {
				const string __id = "setCheckReceivedObjects.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCheckReferencedObjectsAreReachable;
#pragma warning disable 0169
		static Delegate GetIsCheckReferencedObjectsAreReachableHandler ()
		{
			if (cb_isCheckReferencedObjectsAreReachable == null)
				cb_isCheckReferencedObjectsAreReachable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCheckReferencedObjectsAreReachable);
			return cb_isCheckReferencedObjectsAreReachable;
		}

		static bool n_IsCheckReferencedObjectsAreReachable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckReferencedObjectsAreReachable;
		}
#pragma warning restore 0169

		static Delegate cb_setCheckReferencedObjectsAreReachable_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckReferencedObjectsAreReachable_ZHandler ()
		{
			if (cb_setCheckReferencedObjectsAreReachable_Z == null)
				cb_setCheckReferencedObjectsAreReachable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCheckReferencedObjectsAreReachable_Z);
			return cb_setCheckReferencedObjectsAreReachable_Z;
		}

		static void n_SetCheckReferencedObjectsAreReachable_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckReferencedObjectsAreReachable = b;
		}
#pragma warning restore 0169

		/// <returns>true if this instance will validate all referenced, but not
		///         supplied by the client, objects are reachable from another
		///         reference.</returns>
		/// <summary>Validate all referenced but not supplied objects are reachable.</summary>
		/// <param name="b">
		///   <c>true</c> to enable the additional check.</param>
		public virtual unsafe bool CheckReferencedObjectsAreReachable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isCheckReferencedObjectsAreReachable' and count(parameter)=0]"
			[Register ("isCheckReferencedObjectsAreReachable", "()Z", "GetIsCheckReferencedObjectsAreReachableHandler")]
			get {
				const string __id = "isCheckReferencedObjectsAreReachable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setCheckReferencedObjectsAreReachable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCheckReferencedObjectsAreReachable", "(Z)V", "GetSetCheckReferencedObjectsAreReachable_ZHandler")]
			set {
				const string __id = "setCheckReferencedObjectsAreReachable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getClientShallowCommits;
#pragma warning disable 0169
		static Delegate GetGetClientShallowCommitsHandler ()
		{
			if (cb_getClientShallowCommits == null)
				cb_getClientShallowCommits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientShallowCommits);
			return cb_getClientShallowCommits;
		}

		static IntPtr n_GetClientShallowCommits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (__this.ClientShallowCommits);
		}
#pragma warning restore 0169

		/// <summary>Get the commits from the client's shallow file.</summary>
		/// <returns>if the client is a shallow repository, the list of edge commits
		///     that define the client's shallow boundary. Empty set if the client
		///     is earlier than Git 1.9, or is a full clone.</returns>
		protected virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> ClientShallowCommits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getClientShallowCommits' and count(parameter)=0]"
			[Register ("getClientShallowCommits", "()Ljava/util/Set;", "GetGetClientShallowCommitsHandler")]
			get {
				const string __id = "getClientShallowCommits.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isExpectDataAfterPackFooter;
#pragma warning disable 0169
		static Delegate GetIsExpectDataAfterPackFooterHandler ()
		{
			if (cb_isExpectDataAfterPackFooter == null)
				cb_isExpectDataAfterPackFooter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExpectDataAfterPackFooter);
			return cb_isExpectDataAfterPackFooter;
		}

		static bool n_IsExpectDataAfterPackFooter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpectDataAfterPackFooter;
		}
#pragma warning restore 0169

		static Delegate cb_setExpectDataAfterPackFooter_Z;
#pragma warning disable 0169
		static Delegate GetSetExpectDataAfterPackFooter_ZHandler ()
		{
			if (cb_setExpectDataAfterPackFooter_Z == null)
				cb_setExpectDataAfterPackFooter_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetExpectDataAfterPackFooter_Z);
			return cb_setExpectDataAfterPackFooter_Z;
		}

		static void n_SetExpectDataAfterPackFooter_Z (IntPtr jnienv, IntPtr native__this, bool e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpectDataAfterPackFooter = e;
		}
#pragma warning restore 0169

		/// <returns>true if there is data expected after the pack footer.</returns>
		/// <param name="e">true if there is additional data in InputStream after pack.</param>
		public virtual unsafe bool ExpectDataAfterPackFooter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isExpectDataAfterPackFooter' and count(parameter)=0]"
			[Register ("isExpectDataAfterPackFooter", "()Z", "GetIsExpectDataAfterPackFooterHandler")]
			get {
				const string __id = "isExpectDataAfterPackFooter.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setExpectDataAfterPackFooter' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExpectDataAfterPackFooter", "(Z)V", "GetSetExpectDataAfterPackFooter_ZHandler")]
			set {
				const string __id = "setExpectDataAfterPackFooter.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_hasCommands;
#pragma warning disable 0169
		static Delegate GetHasCommandsHandler ()
		{
			if (cb_hasCommands == null)
				cb_hasCommands = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasCommands);
			return cb_hasCommands;
		}

		static bool n_HasCommands (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCommands;
		}
#pragma warning restore 0169

		/// <returns>true if any commands to be executed have been read.</returns>
		protected virtual unsafe bool HasCommands {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='hasCommands' and count(parameter)=0]"
			[Register ("hasCommands", "()Z", "GetHasCommandsHandler")]
			get {
				const string __id = "hasCommands.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasError;
#pragma warning disable 0169
		static Delegate GetHasErrorHandler ()
		{
			if (cb_hasError == null)
				cb_hasError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasError);
			return cb_hasError;
		}

		static bool n_HasError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasError;
		}
#pragma warning restore 0169

		/// <returns>true if an error occurred that should be advertised.</returns>
		protected virtual unsafe bool HasError {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='hasError' and count(parameter)=0]"
			[Register ("hasError", "()Z", "GetHasErrorHandler")]
			get {
				const string __id = "hasError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSideBand;
		}
#pragma warning restore 0169

		/// <summary>Check whether the client expects a side-band stream.</summary>
		/// <returns>true if the client has advertised a side-band capability, false
		///     otherwise.</returns>
		public virtual unsafe bool IsSideBand {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isSideBand' and count(parameter)=0]"
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

		static Delegate cb_getLockMessageProcessName;
#pragma warning disable 0169
		static Delegate GetGetLockMessageProcessNameHandler ()
		{
			if (cb_getLockMessageProcessName == null)
				cb_getLockMessageProcessName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLockMessageProcessName);
			return cb_getLockMessageProcessName;
		}

		static IntPtr n_GetLockMessageProcessName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LockMessageProcessName);
		}
#pragma warning restore 0169

		protected abstract string LockMessageProcessName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getLockMessageProcessName' and count(parameter)=0]"
			[Register ("getLockMessageProcessName", "()Ljava/lang/String;", "GetGetLockMessageProcessNameHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.MessageOutputStream);
		}
#pragma warning restore 0169

		/// <returns>an underlying stream for sending messages to the client.</returns>
		public virtual unsafe global::System.IO.Stream MessageOutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getMessageOutputStream' and count(parameter)=0]"
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

		static Delegate cb_getPackSize;
#pragma warning disable 0169
		static Delegate GetGetPackSizeHandler ()
		{
			if (cb_getPackSize == null)
				cb_getPackSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPackSize);
			return cb_getPackSize;
		}

		static long n_GetPackSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PackSize;
		}
#pragma warning restore 0169

		/// <summary>Get the size of the received pack file including the index size.</summary>
		/// <returns>the size of the received pack including index size</returns>
		public virtual unsafe long PackSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getPackSize' and count(parameter)=0]"
			[Register ("getPackSize", "()J", "GetGetPackSizeHandler")]
			get {
				const string __id = "getPackSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refFilter = (global::Org.Eclipse.Jgit.Transport.IRefFilter)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRefFilter> (native_refFilter, JniHandleOwnership.DoNotTransfer);
			__this.RefFilter = refFilter;
		}
#pragma warning restore 0169

		/// <returns>the filter used while advertising the refs to the client</returns>
		/// <summary>Set the filter used while advertising the refs to the client.</summary>
		/// <param name="refFilter">the filter; may be null to show all refs.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.IRefFilter RefFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getRefFilter' and count(parameter)=0]"
			[Register ("getRefFilter", "()Lorg/eclipse/jgit/transport/RefFilter;", "GetGetRefFilterHandler")]
			get {
				const string __id = "getRefFilter.()Lorg/eclipse/jgit/transport/RefFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.IRefFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setRefFilter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefFilter']]"
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

		static Delegate cb_getRefLogIdent;
#pragma warning disable 0169
		static Delegate GetGetRefLogIdentHandler ()
		{
			if (cb_getRefLogIdent == null)
				cb_getRefLogIdent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRefLogIdent);
			return cb_getRefLogIdent;
		}

		static IntPtr n_GetRefLogIdent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefLogIdent);
		}
#pragma warning restore 0169

		static Delegate cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_;
#pragma warning disable 0169
		static Delegate GetSetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_Handler ()
		{
			if (cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ == null)
				cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_);
			return cb_setRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_;
		}

		static void n_SetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pi)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pi = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (native_pi, JniHandleOwnership.DoNotTransfer);
			__this.RefLogIdent = pi;
		}
#pragma warning restore 0169

		/// <returns>identity of the user making the changes in the reflog.</returns>
		/// <summary>Set the identity of the user appearing in the affected reflogs.</summary>
		/// <param name="pi">identity of the user. If null the identity will be
		///            automatically determined based on the repository
		///            configuration.</param>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.PersonIdent RefLogIdent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getRefLogIdent' and count(parameter)=0]"
			[Register ("getRefLogIdent", "()Lorg/eclipse/jgit/lib/PersonIdent;", "GetGetRefLogIdentHandler")]
			get {
				const string __id = "getRefLogIdent.()Lorg/eclipse/jgit/lib/PersonIdent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.PersonIdent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setRefLogIdent' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.PersonIdent']]"
			[Register ("setRefLogIdent", "(Lorg/eclipse/jgit/lib/PersonIdent;)V", "GetSetRefLogIdent_Lorg_eclipse_jgit_lib_PersonIdent_Handler")]
			set {
				const string __id = "setRefLogIdent.(Lorg/eclipse/jgit/lib/PersonIdent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		/// <returns>the repository this receive completes into.</returns>
		public unsafe global::Org.Eclipse.Jgit.Lib.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getRepository' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getRevWalk' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = seconds;
		}
#pragma warning restore 0169

		/// <returns>timeout (in seconds) before aborting an IO operation.</returns>
		/// <summary>Set the timeout before willing to abort an IO call.</summary>
		/// <param name="seconds">number of seconds to wait (with no data transfer occurring)
		///            before aborting an IO read or write operation with the
		///            connected client.</param>
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				const string __id = "getTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_anyRejects;
#pragma warning disable 0169
		static Delegate GetAnyRejectsHandler ()
		{
			if (cb_anyRejects == null)
				cb_anyRejects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_AnyRejects);
			return cb_anyRejects;
		}

		static bool n_AnyRejects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnyRejects ();
		}
#pragma warning restore 0169

		/// <returns>if any commands have been rejected so far.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='anyRejects' and count(parameter)=0]"
		[Register ("anyRejects", "()Z", "GetAnyRejectsHandler")]
		protected virtual unsafe bool AnyRejects ()
		{
			const string __id = "anyRejects.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		/// <summary>Close and flush (if necessary) the underlying streams.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		protected virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_enableCapabilities;
#pragma warning disable 0169
		static Delegate GetEnableCapabilitiesHandler ()
		{
			if (cb_enableCapabilities == null)
				cb_enableCapabilities = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EnableCapabilities);
			return cb_enableCapabilities;
		}

		static void n_EnableCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableCapabilities ();
		}
#pragma warning restore 0169

		/// <summary>Enable capabilities based on a previously read capabilities line.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='enableCapabilities' and count(parameter)=0]"
		[Register ("enableCapabilities", "()V", "GetEnableCapabilitiesHandler")]
		protected virtual unsafe void EnableCapabilities ()
		{
			const string __id = "enableCapabilities.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_executeCommands;
#pragma warning disable 0169
		static Delegate GetExecuteCommandsHandler ()
		{
			if (cb_executeCommands == null)
				cb_executeCommands = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ExecuteCommands);
			return cb_executeCommands;
		}

		static void n_ExecuteCommands (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteCommands ();
		}
#pragma warning restore 0169

		/// <summary>Execute commands to update references.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='executeCommands' and count(parameter)=0]"
		[Register ("executeCommands", "()V", "GetExecuteCommandsHandler")]
		protected virtual unsafe void ExecuteCommands ()
		{
			const string __id = "executeCommands.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_failPendingCommands;
#pragma warning disable 0169
		static Delegate GetFailPendingCommandsHandler ()
		{
			if (cb_failPendingCommands == null)
				cb_failPendingCommands = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FailPendingCommands);
			return cb_failPendingCommands;
		}

		static void n_FailPendingCommands (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FailPendingCommands ();
		}
#pragma warning restore 0169

		/// <summary>Set the result to fail for any command that was not processed yet.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='failPendingCommands' and count(parameter)=0]"
		[Register ("failPendingCommands", "()V", "GetFailPendingCommandsHandler")]
		protected virtual unsafe void FailPendingCommands ()
		{
			const string __id = "failPendingCommands.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_filterCommands_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_;
#pragma warning disable 0169
		static Delegate GetFilterCommands_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Handler ()
		{
			if (cb_filterCommands_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_ == null)
				cb_filterCommands_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_FilterCommands_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_);
			return cb_filterCommands_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_;
		}

		static IntPtr n_FilterCommands_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_want)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var want = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result> (native_want, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.ToLocalJniHandle (__this.FilterCommands (want));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='filterCommands' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.ReceiveCommand.Result']]"
		[Register ("filterCommands", "(Lorg/eclipse/jgit/transport/ReceiveCommand$Result;)Ljava/util/List;", "GetFilterCommands_Lorg_eclipse_jgit_transport_ReceiveCommand_Result_Handler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand> FilterCommands (global::Org.Eclipse.Jgit.Transport.ReceiveCommand.Result want)
		{
			const string __id = "filterCommands.(Lorg/eclipse/jgit/transport/ReceiveCommand$Result;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((want == null) ? IntPtr.Zero : ((global::Java.Lang.Object) want).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.ReceiveCommand>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (want);
			}
		}

		static Delegate cb_init_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetInit_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_init_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_ == null)
				cb_init_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Init_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_);
			return cb_init_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_;
		}

		static void n_Init_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input, IntPtr native_output, IntPtr native_messages)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_input, JniHandleOwnership.DoNotTransfer);
			var output = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_output, JniHandleOwnership.DoNotTransfer);
			var messages = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_messages, JniHandleOwnership.DoNotTransfer);
			__this.Init (input, output, messages);
		}
#pragma warning restore 0169

		/// <param name="input">raw input to read client commands and pack data from. Caller
		///            must ensure the input is buffered, otherwise read performance
		///            may suffer.</param>
		/// <param name="output">response back to the Git network client. Caller must ensure
		///            the output is buffered, otherwise write performance may
		///            suffer.</param>
		/// <param name="messages">secondary "notice" channel to send additional messages out
		///            through. When run over SSH this should be tied back to the
		///            standard error channel of the command execution. For most
		///            other network connections this should be null.</param>
		/// <summary>Initialize the instance with the given streams.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='init' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='java.io.OutputStream']]"
		[Register ("init", "(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/io/OutputStream;)V", "GetInit_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe void Init (global::System.IO.Stream input, global::System.IO.Stream output, global::System.IO.Stream messages)
		{
			const string __id = "init.(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/io/OutputStream;)V";
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

		static Delegate cb_isCapabilityEnabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsCapabilityEnabled_Ljava_lang_String_Handler ()
		{
			if (cb_isCapabilityEnabled_Ljava_lang_String_ == null)
				cb_isCapabilityEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsCapabilityEnabled_Ljava_lang_String_);
			return cb_isCapabilityEnabled_Ljava_lang_String_;
		}

		static bool n_IsCapabilityEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsCapabilityEnabled (name);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="name">protocol name identifying the capability.</param>
		/// <summary>Check if the peer requested a capability.</summary>
		/// <returns>true if the peer requested the capability to be enabled.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='isCapabilityEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isCapabilityEnabled", "(Ljava/lang/String;)Z", "GetIsCapabilityEnabled_Ljava_lang_String_Handler")]
		protected virtual unsafe bool IsCapabilityEnabled (string name)
		{
			const string __id = "isCapabilityEnabled.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_needPack;
#pragma warning disable 0169
		static Delegate GetNeedPackHandler ()
		{
			if (cb_needPack == null)
				cb_needPack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_NeedPack);
			return cb_needPack;
		}

		static bool n_NeedPack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedPack ();
		}
#pragma warning restore 0169

		/// <returns>true if a pack is expected based on the list of commands.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='needPack' and count(parameter)=0]"
		[Register ("needPack", "()Z", "GetNeedPackHandler")]
		protected virtual unsafe bool NeedPack ()
		{
			const string __id = "needPack.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_receivePackAndCheckConnectivity;
#pragma warning disable 0169
		static Delegate GetReceivePackAndCheckConnectivityHandler ()
		{
			if (cb_receivePackAndCheckConnectivity == null)
				cb_receivePackAndCheckConnectivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReceivePackAndCheckConnectivity);
			return cb_receivePackAndCheckConnectivity;
		}

		static void n_ReceivePackAndCheckConnectivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReceivePackAndCheckConnectivity ();
		}
#pragma warning restore 0169

		/// <summary>Receive a pack from the stream and check connectivity if necessary.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='receivePackAndCheckConnectivity' and count(parameter)=0]"
		[Register ("receivePackAndCheckConnectivity", "()V", "GetReceivePackAndCheckConnectivityHandler")]
		protected virtual unsafe void ReceivePackAndCheckConnectivity ()
		{
			const string __id = "receivePackAndCheckConnectivity.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_recvCommands;
#pragma warning disable 0169
		static Delegate GetRecvCommandsHandler ()
		{
			if (cb_recvCommands == null)
				cb_recvCommands = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RecvCommands);
			return cb_recvCommands;
		}

		static void n_RecvCommands (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecvCommands ();
		}
#pragma warning restore 0169

		/// <summary>Receive a list of commands from the input.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='recvCommands' and count(parameter)=0]"
		[Register ("recvCommands", "()V", "GetRecvCommandsHandler")]
		protected virtual unsafe void RecvCommands ()
		{
			const string __id = "recvCommands.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		/// <summary>Release any resources used by this object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		protected virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adv = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.RefAdvertiser> (native_adv, JniHandleOwnership.DoNotTransfer);
			__this.SendAdvertisedRefs (adv);
		}
#pragma warning restore 0169

		/// <param name="adv">the advertisement formatter.</param>
		/// <summary>Generate an advertisement of available refs and capabilities.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='sendAdvertisedRefs' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.RefAdvertiser']]"
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

		static Delegate cb_sendError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendError_Ljava_lang_String_Handler ()
		{
			if (cb_sendError_Ljava_lang_String_ == null)
				cb_sendError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendError_Ljava_lang_String_);
			return cb_sendError_Ljava_lang_String_;
		}

		static void n_SendError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_what)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var what = JNIEnv.GetString (native_what, JniHandleOwnership.DoNotTransfer);
			__this.SendError (what);
		}
#pragma warning restore 0169

		/// <param name="what">string describing the problem identified by the hook. The
		///            string must not end with an LF, and must not contain an LF.</param>
		/// <summary>Send an error message to the client.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='sendError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendError", "(Ljava/lang/String;)V", "GetSendError_Ljava_lang_String_Handler")]
		public virtual unsafe void SendError (string what)
		{
			const string __id = "sendError.(Ljava/lang/String;)V";
			IntPtr native_what = JNIEnv.NewString ((string)what);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_what);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_what);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var what = JNIEnv.GetString (native_what, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (what);
		}
#pragma warning restore 0169

		/// <param name="what">string describing the problem identified by the hook. The
		///            string must not end with an LF, and must not contain an LF.</param>
		/// <summary>Send a message to the client, if it supports receiving them.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setAdvertisedRefs_Ljava_util_Map_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetAdvertisedRefs_Ljava_util_Map_Ljava_util_Set_Handler ()
		{
			if (cb_setAdvertisedRefs_Ljava_util_Map_Ljava_util_Set_ == null)
				cb_setAdvertisedRefs_Ljava_util_Map_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetAdvertisedRefs_Ljava_util_Map_Ljava_util_Set_);
			return cb_setAdvertisedRefs_Ljava_util_Map_Ljava_util_Set_;
		}

		static void n_SetAdvertisedRefs_Ljava_util_Map_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_allRefs, IntPtr native_additionalHaves)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var allRefs = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.FromJniHandle (native_allRefs, JniHandleOwnership.DoNotTransfer);
			var additionalHaves = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (native_additionalHaves, JniHandleOwnership.DoNotTransfer);
			__this.SetAdvertisedRefs (allRefs, additionalHaves);
		}
#pragma warning restore 0169

		/// <param name="allRefs">explicit set of references to claim as advertised by this
		///            ReceivePack instance. This overrides any references that
		///            may exist in the source repository. The map is passed
		///            to the configured <c>#getRefFilter()</c>. If null, assumes
		///            all refs were advertised.</param>
		/// <param name="additionalHaves">explicit set of additional haves to claim as advertised. If
		///            null, assumes the default set of additional haves from the
		///            repository.</param>
		/// <summary>Set the refs advertised by this ReceivePack.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setAdvertisedRefs' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, org.eclipse.jgit.lib.Ref&gt;'] and parameter[2][@type='java.util.Set&lt;org.eclipse.jgit.lib.ObjectId&gt;']]"
		[Register ("setAdvertisedRefs", "(Ljava/util/Map;Ljava/util/Set;)V", "GetSetAdvertisedRefs_Ljava_util_Map_Ljava_util_Set_Handler")]
		public virtual unsafe void SetAdvertisedRefs (global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef> allRefs, global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> additionalHaves)
		{
			const string __id = "setAdvertisedRefs.(Ljava/util/Map;Ljava/util/Set;)V";
			IntPtr native_allRefs = global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IRef>.ToLocalJniHandle (allRefs);
			IntPtr native_additionalHaves = global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.ToLocalJniHandle (additionalHaves);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_allRefs);
				__args [1] = new JniArgumentValue (native_additionalHaves);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_allRefs);
				JNIEnv.DeleteLocalRef (native_additionalHaves);
				global::System.GC.KeepAlive (allRefs);
				global::System.GC.KeepAlive (additionalHaves);
			}
		}

		static Delegate cb_setMaxObjectSizeLimit_J;
#pragma warning disable 0169
		static Delegate GetSetMaxObjectSizeLimit_JHandler ()
		{
			if (cb_setMaxObjectSizeLimit_J == null)
				cb_setMaxObjectSizeLimit_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetMaxObjectSizeLimit_J);
			return cb_setMaxObjectSizeLimit_J;
		}

		static void n_SetMaxObjectSizeLimit_J (IntPtr jnienv, IntPtr native__this, long limit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxObjectSizeLimit (limit);
		}
#pragma warning restore 0169

		/// <param name="limit">the Git object size limit. If zero then there is not limit.</param>
		/// <summary>Set the maximum allowed Git object size.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setMaxObjectSizeLimit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setMaxObjectSizeLimit", "(J)V", "GetSetMaxObjectSizeLimit_JHandler")]
		public virtual unsafe void SetMaxObjectSizeLimit (long limit)
		{
			const string __id = "setMaxObjectSizeLimit.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMaxPackSizeLimit_J;
#pragma warning disable 0169
		static Delegate GetSetMaxPackSizeLimit_JHandler ()
		{
			if (cb_setMaxPackSizeLimit_J == null)
				cb_setMaxPackSizeLimit_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetMaxPackSizeLimit_J);
			return cb_setMaxPackSizeLimit_J;
		}

		static void n_SetMaxPackSizeLimit_J (IntPtr jnienv, IntPtr native__this, long limit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxPackSizeLimit (limit);
		}
#pragma warning restore 0169

		/// <param name="limit">the pack size limit, in bytes</param>
		/// <summary>Set the maximum allowed pack size.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setMaxPackSizeLimit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setMaxPackSizeLimit", "(J)V", "GetSetMaxPackSizeLimit_JHandler")]
		public virtual unsafe void SetMaxPackSizeLimit (long limit)
		{
			const string __id = "setMaxPackSizeLimit.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_;
#pragma warning disable 0169
		static Delegate GetSetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_Handler ()
		{
			if (cb_setObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_ == null)
				cb_setObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_);
			return cb_setObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_;
		}

		static void n_SetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_impl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var impl = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (native_impl, JniHandleOwnership.DoNotTransfer);
			__this.SetObjectChecker (impl);
		}
#pragma warning restore 0169

		/// <param name="impl">if non-null the object checking instance to verify each
		///        received object with; null to disable object checking.</param>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='setObjectChecker' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectChecker']]"
		[Register ("setObjectChecker", "(Lorg/eclipse/jgit/lib/ObjectChecker;)V", "GetSetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_Handler")]
		public virtual unsafe void SetObjectChecker (global::Org.Eclipse.Jgit.Lib.ObjectChecker impl)
		{
			const string __id = "setObjectChecker.(Lorg/eclipse/jgit/lib/ObjectChecker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_unlockPack;
#pragma warning disable 0169
		static Delegate GetUnlockPackHandler ()
		{
			if (cb_unlockPack == null)
				cb_unlockPack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnlockPack);
			return cb_unlockPack;
		}

		static void n_UnlockPack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnlockPack ();
		}
#pragma warning restore 0169

		/// <summary>Unlock the pack written by this object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='unlockPack' and count(parameter)=0]"
		[Register ("unlockPack", "()V", "GetUnlockPackHandler")]
		protected virtual unsafe void UnlockPack ()
		{
			const string __id = "unlockPack.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_validateCommands;
#pragma warning disable 0169
		static Delegate GetValidateCommandsHandler ()
		{
			if (cb_validateCommands == null)
				cb_validateCommands = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ValidateCommands);
			return cb_validateCommands;
		}

		static void n_ValidateCommands (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.BaseReceivePack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValidateCommands ();
		}
#pragma warning restore 0169

		/// <summary>Validate the command list.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='validateCommands' and count(parameter)=0]"
		[Register ("validateCommands", "()V", "GetValidateCommandsHandler")]
		protected virtual unsafe void ValidateCommands ()
		{
			const string __id = "validateCommands.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/BaseReceivePack", DoNotGenerateAcw=true)]
	internal partial class BaseReceivePackInvoker : BaseReceivePack {
		public BaseReceivePackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/BaseReceivePack", typeof (BaseReceivePackInvoker));

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

		/// <returns>the process name used for pack lock messages.</returns>
		protected override unsafe string LockMessageProcessName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='BaseReceivePack']/method[@name='getLockMessageProcessName' and count(parameter)=0]"
			[Register ("getLockMessageProcessName", "()Ljava/lang/String;", "GetGetLockMessageProcessNameHandler")]
			get {
				const string __id = "getLockMessageProcessName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
