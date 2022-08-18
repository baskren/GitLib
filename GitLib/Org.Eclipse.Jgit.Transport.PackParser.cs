using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Parses a pack stream and imports it for an <c>ObjectInserter</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PackParser", DoNotGenerateAcw=true)]
	public abstract partial class PackParser : global::Java.Lang.Object {
		/// <summary>Type and size information about an object in the database buffer.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.ObjectTypeAndSize']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PackParser$ObjectTypeAndSize", DoNotGenerateAcw=true)]
		public partial class ObjectTypeAndSize : global::Java.Lang.Object {

			/// <summary>The inflated size of the object.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.ObjectTypeAndSize']/field[@name='size']"
			[Register ("size")]
			public long Size {
				get {
					const string __id = "size.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "size.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			/// <summary>The type of the object.</summary>
			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.ObjectTypeAndSize']/field[@name='type']"
			[Register ("type")]
			public int Type {
				get {
					const string __id = "type.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "type.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PackParser$ObjectTypeAndSize", typeof (ObjectTypeAndSize));

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

			protected ObjectTypeAndSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.ObjectTypeAndSize']/constructor[@name='PackParser.ObjectTypeAndSize' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ObjectTypeAndSize () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		/// <summary>Location data is being obtained from.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.Source']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PackParser$Source", DoNotGenerateAcw=true)]
		public sealed partial class Source : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.Source']/field[@name='DATABASE']"
			[Register ("DATABASE")]
			public static global::Org.Eclipse.Jgit.Transport.PackParser.Source Database {
				get {
					const string __id = "DATABASE.Lorg/eclipse/jgit/transport/PackParser$Source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.Source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.Source']/field[@name='INPUT']"
			[Register ("INPUT")]
			public static global::Org.Eclipse.Jgit.Transport.PackParser.Source Input {
				get {
					const string __id = "INPUT.Lorg/eclipse/jgit/transport/PackParser$Source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.Source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PackParser$Source", typeof (Source));

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

			internal Source (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.Source']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/transport/PackParser$Source;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.PackParser.Source ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/transport/PackParser$Source;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.Source> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.Source']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/transport/PackParser$Source;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Transport.PackParser.Source[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/transport/PackParser$Source;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Transport.PackParser.Source[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Transport.PackParser.Source));
				} finally {
				}
			}

		}

		/// <summary>Information about an unresolved delta in this pack stream.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.UnresolvedDelta']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PackParser$UnresolvedDelta", DoNotGenerateAcw=true)]
		public partial class UnresolvedDelta : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PackParser$UnresolvedDelta", typeof (UnresolvedDelta));

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

			protected UnresolvedDelta (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.UnresolvedDelta']/constructor[@name='PackParser.UnresolvedDelta' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe UnresolvedDelta () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_getCRC;
#pragma warning disable 0169
			static Delegate GetGetCRCHandler ()
			{
				if (cb_getCRC == null)
					cb_getCRC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCRC);
				return cb_getCRC;
			}

			static int n_GetCRC (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CRC;
			}
#pragma warning restore 0169

			static Delegate cb_setCRC_I;
#pragma warning disable 0169
			static Delegate GetSetCRC_IHandler ()
			{
				if (cb_setCRC_I == null)
					cb_setCRC_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCRC_I);
				return cb_setCRC_I;
			}

			static void n_SetCRC_I (IntPtr jnienv, IntPtr native__this, int crc32)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.CRC = crc32;
			}
#pragma warning restore 0169

			/// <returns>the CRC-32 checksum of the stored delta data.</returns>
			/// <param name="crc32">the CRC-32 checksum of the stored delta data.</param>
			public virtual unsafe int CRC {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.UnresolvedDelta']/method[@name='getCRC' and count(parameter)=0]"
				[Register ("getCRC", "()I", "GetGetCRCHandler")]
				get {
					const string __id = "getCRC.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.UnresolvedDelta']/method[@name='setCRC' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setCRC", "(I)V", "GetSetCRC_IHandler")]
				set {
					const string __id = "setCRC.(I)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

			static Delegate cb_getOffset;
#pragma warning disable 0169
			static Delegate GetGetOffsetHandler ()
			{
				if (cb_getOffset == null)
					cb_getOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetOffset);
				return cb_getOffset;
			}

			static long n_GetOffset (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Offset;
			}
#pragma warning restore 0169

			/// <returns>offset within the input stream.</returns>
			public virtual unsafe long Offset {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser.UnresolvedDelta']/method[@name='getOffset' and count(parameter)=0]"
				[Register ("getOffset", "()J", "GetGetOffsetHandler")]
				get {
					const string __id = "getOffset.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PackParser", typeof (PackParser));

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

		protected PackParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="odb">database the parser will write its objects into.</param>
		/// <param name="src">the stream the parser will read.</param>
		/// <summary>Initialize a pack parser.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/constructor[@name='PackParser' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectDatabase'] and parameter[2][@type='java.io.InputStream']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectDatabase;Ljava/io/InputStream;)V", "")]
		protected unsafe PackParser (global::Org.Eclipse.Jgit.Lib.ObjectDatabase odb, global::System.IO.Stream src) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectDatabase;Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_src = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (src);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((odb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) odb).Handle);
				__args [1] = new JniArgumentValue (native_src);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_src);
				global::System.GC.KeepAlive (odb);
				global::System.GC.KeepAlive (src);
			}
		}

		static Delegate cb_isAllowThin;
#pragma warning disable 0169
		static Delegate GetIsAllowThinHandler ()
		{
			if (cb_isAllowThin == null)
				cb_isAllowThin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAllowThin);
			return cb_isAllowThin;
		}

		static bool n_IsAllowThin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowThin;
		}
#pragma warning restore 0169

		static Delegate cb_setAllowThin_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowThin_ZHandler ()
		{
			if (cb_setAllowThin_Z == null)
				cb_setAllowThin_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAllowThin_Z);
			return cb_setAllowThin_Z;
		}

		static void n_SetAllowThin_Z (IntPtr jnienv, IntPtr native__this, bool allow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowThin = allow;
		}
#pragma warning restore 0169

		/// <returns>true if a thin pack (missing base objects) is permitted.</returns>
		/// <summary>Configure this index pack instance to allow a thin pack.</summary>
		/// <param name="allow">true to enable a thin pack.</param>
		public virtual unsafe bool AllowThin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='isAllowThin' and count(parameter)=0]"
			[Register ("isAllowThin", "()Z", "GetIsAllowThinHandler")]
			get {
				const string __id = "isAllowThin.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='setAllowThin' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowThin", "(Z)V", "GetSetAllowThin_ZHandler")]
			set {
				const string __id = "setAllowThin.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBaseObjectIds;
#pragma warning disable 0169
		static Delegate GetGetBaseObjectIdsHandler ()
		{
			if (cb_getBaseObjectIds == null)
				cb_getBaseObjectIds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBaseObjectIds);
			return cb_getBaseObjectIds;
		}

		static IntPtr n_GetBaseObjectIds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseObjectIds);
		}
#pragma warning restore 0169

		/// <returns>set of objects the incoming pack assumed for delta purposes</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectIdSubclassMap BaseObjectIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='getBaseObjectIds' and count(parameter)=0]"
			[Register ("getBaseObjectIds", "()Lorg/eclipse/jgit/lib/ObjectIdSubclassMap;", "GetGetBaseObjectIdsHandler")]
			get {
				const string __id = "getBaseObjectIds.()Lorg/eclipse/jgit/lib/ObjectIdSubclassMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdSubclassMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCheckEofAfterPackFooter;
#pragma warning disable 0169
		static Delegate GetIsCheckEofAfterPackFooterHandler ()
		{
			if (cb_isCheckEofAfterPackFooter == null)
				cb_isCheckEofAfterPackFooter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCheckEofAfterPackFooter);
			return cb_isCheckEofAfterPackFooter;
		}

		static bool n_IsCheckEofAfterPackFooter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckEofAfterPackFooter;
		}
#pragma warning restore 0169

		static Delegate cb_setCheckEofAfterPackFooter_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckEofAfterPackFooter_ZHandler ()
		{
			if (cb_setCheckEofAfterPackFooter_Z == null)
				cb_setCheckEofAfterPackFooter_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCheckEofAfterPackFooter_Z);
			return cb_setCheckEofAfterPackFooter_Z;
		}

		static void n_SetCheckEofAfterPackFooter_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckEofAfterPackFooter = b;
		}
#pragma warning restore 0169

		/// <returns>true if the EOF should be read from the input after the footer.</returns>
		/// <summary>Ensure EOF is read from the input stream after the footer.</summary>
		/// <param name="b">true if the EOF should be read; false if it is not checked.</param>
		public virtual unsafe bool CheckEofAfterPackFooter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='isCheckEofAfterPackFooter' and count(parameter)=0]"
			[Register ("isCheckEofAfterPackFooter", "()Z", "GetIsCheckEofAfterPackFooterHandler")]
			get {
				const string __id = "isCheckEofAfterPackFooter.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='setCheckEofAfterPackFooter' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCheckEofAfterPackFooter", "(Z)V", "GetSetCheckEofAfterPackFooter_ZHandler")]
			set {
				const string __id = "setCheckEofAfterPackFooter.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpectDataAfterPackFooter = e;
		}
#pragma warning restore 0169

		/// <returns>true if there is data expected after the pack footer.</returns>
		/// <param name="e">true if there is additional data in InputStream after pack.
		///            This requires the InputStream to support the mark and reset
		///            functions.</param>
		public virtual unsafe bool ExpectDataAfterPackFooter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='isExpectDataAfterPackFooter' and count(parameter)=0]"
			[Register ("isExpectDataAfterPackFooter", "()Z", "GetIsExpectDataAfterPackFooterHandler")]
			get {
				const string __id = "isExpectDataAfterPackFooter.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='setExpectDataAfterPackFooter' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getLockMessage;
#pragma warning disable 0169
		static Delegate GetGetLockMessageHandler ()
		{
			if (cb_getLockMessage == null)
				cb_getLockMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLockMessage);
			return cb_getLockMessage;
		}

		static IntPtr n_GetLockMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LockMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setLockMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLockMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setLockMessage_Ljava_lang_String_ == null)
				cb_setLockMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLockMessage_Ljava_lang_String_);
			return cb_setLockMessage_Ljava_lang_String_;
		}

		static void n_SetLockMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.LockMessage = msg;
		}
#pragma warning restore 0169

		/// <returns>the message to record with the pack lock.</returns>
		/// <summary>Set the lock message for the incoming pack data.</summary>
		/// <param name="msg">if not null, the message to associate with the incoming data
		///            while it is locked to prevent garbage collection.</param>
		public virtual unsafe string LockMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='getLockMessage' and count(parameter)=0]"
			[Register ("getLockMessage", "()Ljava/lang/String;", "GetGetLockMessageHandler")]
			get {
				const string __id = "getLockMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='setLockMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLockMessage", "(Ljava/lang/String;)V", "GetSetLockMessage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLockMessage.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNewObjectIds;
#pragma warning disable 0169
		static Delegate GetGetNewObjectIdsHandler ()
		{
			if (cb_getNewObjectIds == null)
				cb_getNewObjectIds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewObjectIds);
			return cb_getNewObjectIds;
		}

		static IntPtr n_GetNewObjectIds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewObjectIds);
		}
#pragma warning restore 0169

		/// <returns>the new objects that were sent by the user</returns>
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectIdSubclassMap NewObjectIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='getNewObjectIds' and count(parameter)=0]"
			[Register ("getNewObjectIds", "()Lorg/eclipse/jgit/lib/ObjectIdSubclassMap;", "GetGetNewObjectIdsHandler")]
			get {
				const string __id = "getNewObjectIds.()Lorg/eclipse/jgit/lib/ObjectIdSubclassMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectIdSubclassMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectCount;
#pragma warning disable 0169
		static Delegate GetGetObjectCountHandler ()
		{
			if (cb_getObjectCount == null)
				cb_getObjectCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetObjectCount);
			return cb_getObjectCount;
		}

		static int n_GetObjectCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectCount;
		}
#pragma warning restore 0169

		/// <summary>Get the number of objects in the stream.</summary>
		/// <returns>number of objects parsed out of the stream.</returns>
		public virtual unsafe int ObjectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='getObjectCount' and count(parameter)=0]"
			[Register ("getObjectCount", "()I", "GetGetObjectCountHandler")]
			get {
				const string __id = "getObjectCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PackSize;
		}
#pragma warning restore 0169

		/// <summary>Get the size of the parsed pack.</summary>
		/// <returns>the pack size (including the index size) or -1 if the size cannot
		///         be determined</returns>
		public virtual unsafe long PackSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='getPackSize' and count(parameter)=0]"
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

		static Delegate cb_buffer;
#pragma warning disable 0169
		static Delegate GetBufferHandler ()
		{
			if (cb_buffer == null)
				cb_buffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Buffer);
			return cb_buffer;
		}

		static IntPtr n_Buffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Buffer ());
		}
#pragma warning restore 0169

		/// <returns>a temporary byte array for use by the caller.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='buffer' and count(parameter)=0]"
		[Register ("buffer", "()[B", "GetBufferHandler")]
		protected virtual unsafe byte[] Buffer ()
		{
			const string __id = "buffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_checkCRC_I;
#pragma warning disable 0169
		static Delegate GetCheckCRC_IHandler ()
		{
			if (cb_checkCRC_I == null)
				cb_checkCRC_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_CheckCRC_I);
			return cb_checkCRC_I;
		}

		static bool n_CheckCRC_I (IntPtr jnienv, IntPtr native__this, int oldCRC)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckCRC (oldCRC);
		}
#pragma warning restore 0169

		/// <param name="oldCRC">the prior CRC that was recorded during the first scan of the
		///            object from the pack stream.</param>
		/// <summary>Check the current CRC matches the expected value.</summary>
		/// <returns>true if the CRC matches; false if it does not.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='checkCRC' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkCRC", "(I)Z", "GetCheckCRC_IHandler")]
		protected abstract bool CheckCRC (int oldCRC);

		static Delegate cb_getObject_I;
#pragma warning disable 0169
		static Delegate GetGetObject_IHandler ()
		{
			if (cb_getObject_I == null)
				cb_getObject_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetObject_I);
			return cb_getObject_I;
		}

		static IntPtr n_GetObject_I (IntPtr jnienv, IntPtr native__this, int nth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObject (nth));
		}
#pragma warning restore 0169

		/// <param name="nth">index of the object in the stream. Must be between 0 and
		///            <c>#getObjectCount()</c>-1.</param>
		/// <summary>Get the information about the requested object.</summary>
		/// <returns>the object information.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='getObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObject", "(I)Lorg/eclipse/jgit/transport/PackedObjectInfo;", "GetGetObject_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Transport.PackedObjectInfo GetObject (int nth)
		{
			const string __id = "getObject.(I)Lorg/eclipse/jgit/transport/PackedObjectInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSortedObjectList_Ljava_util_Comparator_;
#pragma warning disable 0169
		static Delegate GetGetSortedObjectList_Ljava_util_Comparator_Handler ()
		{
			if (cb_getSortedObjectList_Ljava_util_Comparator_ == null)
				cb_getSortedObjectList_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetSortedObjectList_Ljava_util_Comparator_);
			return cb_getSortedObjectList_Ljava_util_Comparator_;
		}

		static IntPtr n_GetSortedObjectList_Ljava_util_Comparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmp = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (native_cmp, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo>.ToLocalJniHandle (__this.GetSortedObjectList (cmp));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="cmp">comparison function, if null objects are stored by ObjectId.</param>
		/// <summary>Get all of the objects, sorted by their name.</summary>
		/// <returns>sorted list of objects in this pack stream.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='getSortedObjectList' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;org.eclipse.jgit.transport.PackedObjectInfo&gt;']]"
		[Register ("getSortedObjectList", "(Ljava/util/Comparator;)Ljava/util/List;", "GetGetSortedObjectList_Ljava_util_Comparator_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> GetSortedObjectList (global::Java.Util.IComparator cmp)
		{
			const string __id = "getSortedObjectList.(Ljava/util/Comparator;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cmp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cmp).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cmp);
			}
		}

		static Delegate cb_newInfo_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetNewInfo_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_newInfo_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_newInfo_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_NewInfo_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_newInfo_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static IntPtr n_NewInfo_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_delta, IntPtr native_deltaBase)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			var delta = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta> (native_delta, JniHandleOwnership.DoNotTransfer);
			var deltaBase = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_deltaBase, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewInfo (id, delta, deltaBase));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='newInfo' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='org.eclipse.jgit.transport.PackParser.UnresolvedDelta'] and parameter[3][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("newInfo", "(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/transport/PackParser$UnresolvedDelta;Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/transport/PackedObjectInfo;", "GetNewInfo_Lorg_eclipse_jgit_lib_AnyObjectId_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Transport.PackedObjectInfo NewInfo (global::Org.Eclipse.Jgit.Lib.AnyObjectId id, global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta delta, global::Org.Eclipse.Jgit.Lib.ObjectId deltaBase)
		{
			const string __id = "newInfo.(Lorg/eclipse/jgit/lib/AnyObjectId;Lorg/eclipse/jgit/transport/PackParser$UnresolvedDelta;Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/transport/PackedObjectInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [1] = new JniArgumentValue ((delta == null) ? IntPtr.Zero : ((global::Java.Lang.Object) delta).Handle);
				__args [2] = new JniArgumentValue ((deltaBase == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deltaBase).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (delta);
				global::System.GC.KeepAlive (deltaBase);
			}
		}

		static Delegate cb_onAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_;
#pragma warning disable 0169
		static Delegate GetOnAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_Handler ()
		{
			if (cb_onAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_ == null)
				cb_onAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_Z) n_OnAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_);
			return cb_onAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_;
		}

		static bool n_OnAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_ (IntPtr jnienv, IntPtr native__this, int typeCode, IntPtr native_data, IntPtr native_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var info = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (native_info, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnAppendBase (typeCode, data, info);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="typeCode">type of the base object.</param>
		/// <param name="data">complete content of the base object.</param>
		/// <param name="info">packed object information for this base. Implementors must
		///            populate the CRC and offset members if returning true.</param>
		/// <summary>Provide the implementation with a base that was outside of the pack.</summary>
		/// <returns>true if the <c>info</c> should be included in the object list
		///         returned by <c>#getSortedObjectList(Comparator)</c>, false if it
		///         should not be included.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onAppendBase' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='org.eclipse.jgit.transport.PackedObjectInfo']]"
		[Register ("onAppendBase", "(I[BLorg/eclipse/jgit/transport/PackedObjectInfo;)Z", "GetOnAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_Handler")]
		protected abstract bool OnAppendBase (int typeCode, byte[] data, global::Org.Eclipse.Jgit.Transport.PackedObjectInfo info);

		static Delegate cb_onBeginOfsDelta_JJJ;
#pragma warning disable 0169
		static Delegate GetOnBeginOfsDelta_JJJHandler ()
		{
			if (cb_onBeginOfsDelta_JJJ == null)
				cb_onBeginOfsDelta_JJJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJJ_V) n_OnBeginOfsDelta_JJJ);
			return cb_onBeginOfsDelta_JJJ;
		}

		static void n_OnBeginOfsDelta_JJJ (IntPtr jnienv, IntPtr native__this, long deltaStreamPosition, long baseStreamPosition, long inflatedSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginOfsDelta (deltaStreamPosition, baseStreamPosition, inflatedSize);
		}
#pragma warning restore 0169

		/// <param name="deltaStreamPosition">position of this object in the incoming stream.</param>
		/// <param name="baseStreamPosition">position of the base object in the incoming stream. The base
		///            must be before the delta, therefore <c>baseStreamPosition
		///            &amp;lt; deltaStreamPosition</c>. This is &lt;b&gt;not&lt;/b&gt; the position
		///            returned by a prior end object event.</param>
		/// <param name="inflatedSize">size of the delta when fully inflated. The size stored within
		///            the pack may be larger or smaller, and is not yet known.</param>
		/// <summary>Event notifying start of a delta referencing its base by offset.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onBeginOfsDelta' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onBeginOfsDelta", "(JJJ)V", "GetOnBeginOfsDelta_JJJHandler")]
		protected abstract void OnBeginOfsDelta (long deltaStreamPosition, long baseStreamPosition, long inflatedSize);

		static Delegate cb_onBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J;
#pragma warning disable 0169
		static Delegate GetOnBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_JHandler ()
		{
			if (cb_onBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J == null)
				cb_onBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJLJ_V) n_OnBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J);
			return cb_onBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J;
		}

		static void n_OnBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_J (IntPtr jnienv, IntPtr native__this, long deltaStreamPosition, IntPtr native_baseId, long inflatedSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var baseId = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AnyObjectId> (native_baseId, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginRefDelta (deltaStreamPosition, baseId, inflatedSize);
		}
#pragma warning restore 0169

		/// <param name="deltaStreamPosition">position of this object in the incoming stream.</param>
		/// <param name="baseId">name of the base object. This object may be later in the
		///            stream, or might not appear at all in the stream (in the case
		///            of a thin-pack).</param>
		/// <param name="inflatedSize">size of the delta when fully inflated. The size stored within
		///            the pack may be larger or smaller, and is not yet known.</param>
		/// <summary>Event notifying start of a delta referencing its base by ObjectId.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onBeginRefDelta' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[3][@type='long']]"
		[Register ("onBeginRefDelta", "(JLorg/eclipse/jgit/lib/AnyObjectId;J)V", "GetOnBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_JHandler")]
		protected abstract void OnBeginRefDelta (long deltaStreamPosition, global::Org.Eclipse.Jgit.Lib.AnyObjectId baseId, long inflatedSize);

		static Delegate cb_onBeginWholeObject_JIJ;
#pragma warning disable 0169
		static Delegate GetOnBeginWholeObject_JIJHandler ()
		{
			if (cb_onBeginWholeObject_JIJ == null)
				cb_onBeginWholeObject_JIJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJIJ_V) n_OnBeginWholeObject_JIJ);
			return cb_onBeginWholeObject_JIJ;
		}

		static void n_OnBeginWholeObject_JIJ (IntPtr jnienv, IntPtr native__this, long streamPosition, int type, long inflatedSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeginWholeObject (streamPosition, type, inflatedSize);
		}
#pragma warning restore 0169

		/// <param name="streamPosition">position of this object in the incoming stream.</param>
		/// <param name="type">type of the object; one of <c>Constants#OBJ_COMMIT</c>,
		///            <c>Constants#OBJ_TREE</c>, <c>Constants#OBJ_BLOB</c>, or
		///            <c>Constants#OBJ_TAG</c>.</param>
		/// <param name="inflatedSize">size of the object when fully inflated. The size stored within
		///            the pack may be larger or smaller, and is not yet known.</param>
		/// <summary>Event notifying the start of an object stored whole (not as a delta).</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onBeginWholeObject' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("onBeginWholeObject", "(JIJ)V", "GetOnBeginWholeObject_JIJHandler")]
		protected abstract void OnBeginWholeObject (long streamPosition, int type, long inflatedSize);

		static Delegate cb_onEndDelta;
#pragma warning disable 0169
		static Delegate GetOnEndDeltaHandler ()
		{
			if (cb_onEndDelta == null)
				cb_onEndDelta = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OnEndDelta);
			return cb_onEndDelta;
		}

		static IntPtr n_OnEndDelta (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnEndDelta ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onEndDelta' and count(parameter)=0]"
		[Register ("onEndDelta", "()Lorg/eclipse/jgit/transport/PackParser$UnresolvedDelta;", "GetOnEndDeltaHandler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta OnEndDelta ()
		{
			const string __id = "onEndDelta.()Lorg/eclipse/jgit/transport/PackParser$UnresolvedDelta;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onEndThinPack;
#pragma warning disable 0169
		static Delegate GetOnEndThinPackHandler ()
		{
			if (cb_onEndThinPack == null)
				cb_onEndThinPack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnEndThinPack);
			return cb_onEndThinPack;
		}

		static void n_OnEndThinPack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEndThinPack ();
		}
#pragma warning restore 0169

		/// <summary>Event indicating a thin pack has been completely processed.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onEndThinPack' and count(parameter)=0]"
		[Register ("onEndThinPack", "()V", "GetOnEndThinPackHandler")]
		protected abstract void OnEndThinPack ();

		static Delegate cb_onEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_;
#pragma warning disable 0169
		static Delegate GetOnEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_Handler ()
		{
			if (cb_onEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_ == null)
				cb_onEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_);
			return cb_onEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_;
		}

		static void n_OnEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var info = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (native_info, JniHandleOwnership.DoNotTransfer);
			__this.OnEndWholeObject (info);
		}
#pragma warning restore 0169

		/// <param name="info">object information.</param>
		/// <summary>Event notifying the the current object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onEndWholeObject' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PackedObjectInfo']]"
		[Register ("onEndWholeObject", "(Lorg/eclipse/jgit/transport/PackedObjectInfo;)V", "GetOnEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_Handler")]
		protected abstract void OnEndWholeObject (global::Org.Eclipse.Jgit.Transport.PackedObjectInfo info);

		static Delegate cb_onInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB;
#pragma warning disable 0169
		static Delegate GetOnInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayBHandler ()
		{
			if (cb_onInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB == null)
				cb_onInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB);
			return cb_onInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB;
		}

		static void n_OnInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, int typeCode, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (native_obj, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnInflatedObjectData (obj, typeCode, data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		/// <param name="obj">the object info, populated.</param>
		/// <param name="typeCode">the type of the object.</param>
		/// <param name="data">inflated data for the object.</param>
		/// <summary>Invoked for commits, trees, tags, and small blobs.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onInflatedObjectData' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.PackedObjectInfo'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("onInflatedObjectData", "(Lorg/eclipse/jgit/transport/PackedObjectInfo;I[B)V", "GetOnInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayBHandler")]
		protected abstract void OnInflatedObjectData (global::Org.Eclipse.Jgit.Transport.PackedObjectInfo obj, int typeCode, byte[] data);

		static Delegate cb_onObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII;
#pragma warning disable 0169
		static Delegate GetOnObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler ()
		{
			if (cb_onObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII == null)
				cb_onObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_OnObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII);
			return cb_onObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII;
		}

		static void n_OnObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_src, IntPtr native_raw, int pos, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.Source> (native_src, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnObjectData (src, raw, pos, len);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onObjectData' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.Source'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onObjectData", "(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V", "GetOnObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler")]
		protected abstract void OnObjectData (global::Org.Eclipse.Jgit.Transport.PackParser.Source src, byte[] raw, int pos, int len);

		static Delegate cb_onObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII;
#pragma warning disable 0169
		static Delegate GetOnObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler ()
		{
			if (cb_onObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII == null)
				cb_onObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_OnObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII);
			return cb_onObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII;
		}

		static void n_OnObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_src, IntPtr native_raw, int pos, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.Source> (native_src, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnObjectHeader (src, raw, pos, len);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onObjectHeader' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.Source'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onObjectHeader", "(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V", "GetOnObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler")]
		protected abstract void OnObjectHeader (global::Org.Eclipse.Jgit.Transport.PackParser.Source src, byte[] raw, int pos, int len);

		static Delegate cb_onPackFooter_arrayB;
#pragma warning disable 0169
		static Delegate GetOnPackFooter_arrayBHandler ()
		{
			if (cb_onPackFooter_arrayB == null)
				cb_onPackFooter_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPackFooter_arrayB);
			return cb_onPackFooter_arrayB;
		}

		static void n_OnPackFooter_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_hash)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hash = (byte[]) JNIEnv.GetArray (native_hash, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnPackFooter (hash);
			if (hash != null)
				JNIEnv.CopyArray (hash, native_hash);
		}
#pragma warning restore 0169

		/// <param name="hash">the trailing 20 bytes of the pack, this is a SHA-1 checksum of
		///            all of the pack data.</param>
		/// <summary>Provide the implementation with the original stream's pack footer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onPackFooter' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onPackFooter", "([B)V", "GetOnPackFooter_arrayBHandler")]
		protected abstract void OnPackFooter (byte[] hash);

		static Delegate cb_onPackHeader_J;
#pragma warning disable 0169
		static Delegate GetOnPackHeader_JHandler ()
		{
			if (cb_onPackHeader_J == null)
				cb_onPackHeader_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_OnPackHeader_J);
			return cb_onPackHeader_J;
		}

		static void n_OnPackHeader_J (IntPtr jnienv, IntPtr native__this, long objCnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPackHeader (objCnt);
		}
#pragma warning restore 0169

		/// <param name="objCnt">number of objects expected in the stream.</param>
		/// <summary>Provide the implementation with the original stream's pack header.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onPackHeader' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onPackHeader", "(J)V", "GetOnPackHeader_JHandler")]
		protected abstract void OnPackHeader (long objCnt);

		static Delegate cb_onStoreStream_arrayBII;
#pragma warning disable 0169
		static Delegate GetOnStoreStream_arrayBIIHandler ()
		{
			if (cb_onStoreStream_arrayBII == null)
				cb_onStoreStream_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnStoreStream_arrayBII);
			return cb_onStoreStream_arrayBII;
		}

		static void n_OnStoreStream_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_raw, int pos, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var raw = (byte[]) JNIEnv.GetArray (native_raw, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnStoreStream (raw, pos, len);
			if (raw != null)
				JNIEnv.CopyArray (raw, native_raw);
		}
#pragma warning restore 0169

		/// <param name="raw">buffer to copy data out of.</param>
		/// <param name="pos">first offset within the buffer that is valid.</param>
		/// <param name="len">number of bytes in the buffer that are valid.</param>
		/// <summary>Store bytes received from the raw stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onStoreStream' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStoreStream", "([BII)V", "GetOnStoreStream_arrayBIIHandler")]
		protected abstract void OnStoreStream (byte[] raw, int pos, int len);

		/// <param name="progress">callback to provide progress feedback during parsing. If null,
		///            <c>NullProgressMonitor</c> will be used.</param>
		/// <summary>Parse the pack stream.</summary>
		/// <returns>the pack lock, if one was requested by setting
		///         <c>#setLockMessage(String)</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("parse", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/internal/storage/file/PackLock;", "")]
		public unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock Parse (global::Org.Eclipse.Jgit.Lib.IProgressMonitor progress)
		{
			const string __id = "parse.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/internal/storage/file/PackLock;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((progress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progress).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (progress);
			}
		}

		static Delegate cb_parse_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetParse_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_parse_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_parse_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Parse_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_parse_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_Parse_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiving, IntPtr native_resolving)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var receiving = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_receiving, JniHandleOwnership.DoNotTransfer);
			var resolving = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_resolving, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (receiving, resolving));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="receiving">receives progress feedback during the initial receiving
		///            objects phase. If null, <c>NullProgressMonitor</c> will be
		///            used.</param>
		/// <param name="resolving">receives progress feedback during the resolving objects phase.</param>
		/// <summary>Parse the pack stream.</summary>
		/// <returns>the pack lock, if one was requested by setting
		///         <c>#setLockMessage(String)</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("parse", "(Lorg/eclipse/jgit/lib/ProgressMonitor;Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/internal/storage/file/PackLock;", "GetParse_Lorg_eclipse_jgit_lib_ProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock Parse (global::Org.Eclipse.Jgit.Lib.IProgressMonitor receiving, global::Org.Eclipse.Jgit.Lib.IProgressMonitor resolving)
		{
			const string __id = "parse.(Lorg/eclipse/jgit/lib/ProgressMonitor;Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/internal/storage/file/PackLock;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((receiving == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiving).Handle);
				__args [1] = new JniArgumentValue ((resolving == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resolving).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.File.PackLock> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (receiving);
				global::System.GC.KeepAlive (resolving);
			}
		}

		static Delegate cb_readDatabase_arrayBII;
#pragma warning disable 0169
		static Delegate GetReadDatabase_arrayBIIHandler ()
		{
			if (cb_readDatabase_arrayBII == null)
				cb_readDatabase_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_ReadDatabase_arrayBII);
			return cb_readDatabase_arrayBII;
		}

		static int n_ReadDatabase_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_dst, int pos, int cnt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dst = (byte[]) JNIEnv.GetArray (native_dst, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadDatabase (dst, pos, cnt);
			if (dst != null)
				JNIEnv.CopyArray (dst, native_dst);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="dst">the buffer to copy read data into.</param>
		/// <param name="pos">position within <c>dst</c> to start copying data into.</param>
		/// <param name="cnt">ideal target number of bytes to read. Actual read length may
		///            be shorter.</param>
		/// <summary>Read from the database's current position into the buffer.</summary>
		/// <returns>number of bytes stored.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='readDatabase' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readDatabase", "([BII)I", "GetReadDatabase_arrayBIIHandler")]
		protected abstract int ReadDatabase (byte[] dst, int pos, int cnt);

		static Delegate cb_readObjectHeader_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
#pragma warning disable 0169
		static Delegate GetReadObjectHeader_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler ()
		{
			if (cb_readObjectHeader_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ == null)
				cb_readObjectHeader_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReadObjectHeader_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_);
			return cb_readObjectHeader_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
		}

		static IntPtr n_ReadObjectHeader_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var info = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (native_info, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadObjectHeader (info));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='readObjectHeader' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.ObjectTypeAndSize']]"
		[Register ("readObjectHeader", "(Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;", "GetReadObjectHeader_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler")]
		protected virtual unsafe global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize ReadObjectHeader (global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize info)
		{
			const string __id = "readObjectHeader.(Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (info);
			}
		}

		static Delegate cb_seekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
#pragma warning disable 0169
		static Delegate GetSeekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler ()
		{
			if (cb_seekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ == null)
				cb_seekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SeekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_);
			return cb_seekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
		}

		static IntPtr n_SeekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackedObjectInfo> (native_obj, JniHandleOwnership.DoNotTransfer);
			var info = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (native_info, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SeekDatabase (obj, info));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='seekDatabase' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.PackedObjectInfo'] and parameter[2][@type='org.eclipse.jgit.transport.PackParser.ObjectTypeAndSize']]"
		[Register ("seekDatabase", "(Lorg/eclipse/jgit/transport/PackedObjectInfo;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;", "GetSeekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler")]
		protected abstract global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize SeekDatabase (global::Org.Eclipse.Jgit.Transport.PackedObjectInfo obj, global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize info);

		static Delegate cb_seekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
#pragma warning disable 0169
		static Delegate GetSeekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler ()
		{
			if (cb_seekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ == null)
				cb_seekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SeekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_);
			return cb_seekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_;
		}

		static IntPtr n_SeekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_delta, IntPtr native_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var delta = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta> (native_delta, JniHandleOwnership.DoNotTransfer);
			var info = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (native_info, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SeekDatabase (delta, info));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='seekDatabase' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.UnresolvedDelta'] and parameter[2][@type='org.eclipse.jgit.transport.PackParser.ObjectTypeAndSize']]"
		[Register ("seekDatabase", "(Lorg/eclipse/jgit/transport/PackParser$UnresolvedDelta;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;", "GetSeekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler")]
		protected abstract global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize SeekDatabase (global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta delta, global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize info);

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxObjectSizeLimit (limit);
		}
#pragma warning restore 0169

		/// <param name="limit">the Git object size limit. If zero then there is not limit.</param>
		/// <summary>Set the maximum allowed Git object size.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='setMaxObjectSizeLimit' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_setNeedBaseObjectIds_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedBaseObjectIds_ZHandler ()
		{
			if (cb_setNeedBaseObjectIds_Z == null)
				cb_setNeedBaseObjectIds_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetNeedBaseObjectIds_Z);
			return cb_setNeedBaseObjectIds_Z;
		}

		static void n_SetNeedBaseObjectIds_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNeedBaseObjectIds (b);
		}
#pragma warning restore 0169

		/// <param name="b">
		///   <c>true</c> to enable keeping track of delta bases.</param>
		/// <summary>Configure this index pack instance to keep track of the objects assumed
		/// for delta bases.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='setNeedBaseObjectIds' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedBaseObjectIds", "(Z)V", "GetSetNeedBaseObjectIds_ZHandler")]
		public virtual unsafe void SetNeedBaseObjectIds (bool b)
		{
			const string __id = "setNeedBaseObjectIds.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNeedNewObjectIds_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedNewObjectIds_ZHandler ()
		{
			if (cb_setNeedNewObjectIds_Z == null)
				cb_setNeedNewObjectIds_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetNeedNewObjectIds_Z);
			return cb_setNeedNewObjectIds_Z;
		}

		static void n_SetNeedNewObjectIds_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNeedNewObjectIds (b);
		}
#pragma warning restore 0169

		/// <param name="b">
		///   <c>true</c> to enable keeping track of new objects.</param>
		/// <summary>Configure this index pack instance to keep track of new objects.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='setNeedNewObjectIds' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedNewObjectIds", "(Z)V", "GetSetNeedNewObjectIds_ZHandler")]
		public virtual unsafe void SetNeedNewObjectIds (bool b)
		{
			const string __id = "setNeedNewObjectIds.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
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

		static void n_SetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oc = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectChecker> (native_oc, JniHandleOwnership.DoNotTransfer);
			__this.SetObjectChecker (oc);
		}
#pragma warning restore 0169

		/// <param name="oc">the checker instance; null to disable object checking.</param>
		/// <summary>Configure the checker used to validate received objects.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='setObjectChecker' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectChecker']]"
		[Register ("setObjectChecker", "(Lorg/eclipse/jgit/lib/ObjectChecker;)V", "GetSetObjectChecker_Lorg_eclipse_jgit_lib_ObjectChecker_Handler")]
		public virtual unsafe void SetObjectChecker (global::Org.Eclipse.Jgit.Lib.ObjectChecker oc)
		{
			const string __id = "setObjectChecker.(Lorg/eclipse/jgit/lib/ObjectChecker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((oc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oc).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (oc);
			}
		}

		static Delegate cb_setObjectChecking_Z;
#pragma warning disable 0169
		static Delegate GetSetObjectChecking_ZHandler ()
		{
			if (cb_setObjectChecking_Z == null)
				cb_setObjectChecking_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetObjectChecking_Z);
			return cb_setObjectChecking_Z;
		}

		static void n_SetObjectChecking_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetObjectChecking (on);
		}
#pragma warning restore 0169

		/// <param name="on">true to enable the default checker; false to disable it.</param>
		/// <summary>Configure the checker used to validate received objects.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='setObjectChecking' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setObjectChecking", "(Z)V", "GetSetObjectChecking_ZHandler")]
		public virtual unsafe void SetObjectChecking (bool on)
		{
			const string __id = "setObjectChecking.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/PackParser", DoNotGenerateAcw=true)]
	internal partial class PackParserInvoker : PackParser {
		public PackParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/PackParser", typeof (PackParserInvoker));

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

		/// <param name="oldCRC">the prior CRC that was recorded during the first scan of the
		///            object from the pack stream.</param>
		/// <summary>Check the current CRC matches the expected value.</summary>
		/// <returns>true if the CRC matches; false if it does not.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='checkCRC' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkCRC", "(I)Z", "GetCheckCRC_IHandler")]
		protected override unsafe bool CheckCRC (int oldCRC)
		{
			const string __id = "checkCRC.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (oldCRC);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		/// <param name="typeCode">type of the base object.</param>
		/// <param name="data">complete content of the base object.</param>
		/// <param name="info">packed object information for this base. Implementors must
		///            populate the CRC and offset members if returning true.</param>
		/// <summary>Provide the implementation with a base that was outside of the pack.</summary>
		/// <returns>true if the <c>info</c> should be included in the object list
		///         returned by <c>#getSortedObjectList(Comparator)</c>, false if it
		///         should not be included.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onAppendBase' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='org.eclipse.jgit.transport.PackedObjectInfo']]"
		[Register ("onAppendBase", "(I[BLorg/eclipse/jgit/transport/PackedObjectInfo;)Z", "GetOnAppendBase_IarrayBLorg_eclipse_jgit_transport_PackedObjectInfo_Handler")]
		protected override unsafe bool OnAppendBase (int typeCode, byte[] data, global::Org.Eclipse.Jgit.Transport.PackedObjectInfo info)
		{
			const string __id = "onAppendBase.(I[BLorg/eclipse/jgit/transport/PackedObjectInfo;)Z";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (typeCode);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (info);
			}
		}

		/// <param name="deltaStreamPosition">position of this object in the incoming stream.</param>
		/// <param name="baseStreamPosition">position of the base object in the incoming stream. The base
		///            must be before the delta, therefore <c>baseStreamPosition
		///            &amp;lt; deltaStreamPosition</c>. This is &lt;b&gt;not&lt;/b&gt; the position
		///            returned by a prior end object event.</param>
		/// <param name="inflatedSize">size of the delta when fully inflated. The size stored within
		///            the pack may be larger or smaller, and is not yet known.</param>
		/// <summary>Event notifying start of a delta referencing its base by offset.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onBeginOfsDelta' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onBeginOfsDelta", "(JJJ)V", "GetOnBeginOfsDelta_JJJHandler")]
		protected override unsafe void OnBeginOfsDelta (long deltaStreamPosition, long baseStreamPosition, long inflatedSize)
		{
			const string __id = "onBeginOfsDelta.(JJJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (deltaStreamPosition);
				__args [1] = new JniArgumentValue (baseStreamPosition);
				__args [2] = new JniArgumentValue (inflatedSize);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <param name="deltaStreamPosition">position of this object in the incoming stream.</param>
		/// <param name="baseId">name of the base object. This object may be later in the
		///            stream, or might not appear at all in the stream (in the case
		///            of a thin-pack).</param>
		/// <param name="inflatedSize">size of the delta when fully inflated. The size stored within
		///            the pack may be larger or smaller, and is not yet known.</param>
		/// <summary>Event notifying start of a delta referencing its base by ObjectId.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onBeginRefDelta' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[3][@type='long']]"
		[Register ("onBeginRefDelta", "(JLorg/eclipse/jgit/lib/AnyObjectId;J)V", "GetOnBeginRefDelta_JLorg_eclipse_jgit_lib_AnyObjectId_JHandler")]
		protected override unsafe void OnBeginRefDelta (long deltaStreamPosition, global::Org.Eclipse.Jgit.Lib.AnyObjectId baseId, long inflatedSize)
		{
			const string __id = "onBeginRefDelta.(JLorg/eclipse/jgit/lib/AnyObjectId;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (deltaStreamPosition);
				__args [1] = new JniArgumentValue ((baseId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseId).Handle);
				__args [2] = new JniArgumentValue (inflatedSize);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (baseId);
			}
		}

		/// <param name="streamPosition">position of this object in the incoming stream.</param>
		/// <param name="type">type of the object; one of <c>Constants#OBJ_COMMIT</c>,
		///            <c>Constants#OBJ_TREE</c>, <c>Constants#OBJ_BLOB</c>, or
		///            <c>Constants#OBJ_TAG</c>.</param>
		/// <param name="inflatedSize">size of the object when fully inflated. The size stored within
		///            the pack may be larger or smaller, and is not yet known.</param>
		/// <summary>Event notifying the start of an object stored whole (not as a delta).</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onBeginWholeObject' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("onBeginWholeObject", "(JIJ)V", "GetOnBeginWholeObject_JIJHandler")]
		protected override unsafe void OnBeginWholeObject (long streamPosition, int type, long inflatedSize)
		{
			const string __id = "onBeginWholeObject.(JIJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (streamPosition);
				__args [1] = new JniArgumentValue (type);
				__args [2] = new JniArgumentValue (inflatedSize);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <summary>Event indicating a thin pack has been completely processed.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onEndThinPack' and count(parameter)=0]"
		[Register ("onEndThinPack", "()V", "GetOnEndThinPackHandler")]
		protected override unsafe void OnEndThinPack ()
		{
			const string __id = "onEndThinPack.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <param name="info">object information.</param>
		/// <summary>Event notifying the the current object.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onEndWholeObject' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.transport.PackedObjectInfo']]"
		[Register ("onEndWholeObject", "(Lorg/eclipse/jgit/transport/PackedObjectInfo;)V", "GetOnEndWholeObject_Lorg_eclipse_jgit_transport_PackedObjectInfo_Handler")]
		protected override unsafe void OnEndWholeObject (global::Org.Eclipse.Jgit.Transport.PackedObjectInfo info)
		{
			const string __id = "onEndWholeObject.(Lorg/eclipse/jgit/transport/PackedObjectInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (info);
			}
		}

		/// <param name="obj">the object info, populated.</param>
		/// <param name="typeCode">the type of the object.</param>
		/// <param name="data">inflated data for the object.</param>
		/// <summary>Invoked for commits, trees, tags, and small blobs.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onInflatedObjectData' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.transport.PackedObjectInfo'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("onInflatedObjectData", "(Lorg/eclipse/jgit/transport/PackedObjectInfo;I[B)V", "GetOnInflatedObjectData_Lorg_eclipse_jgit_transport_PackedObjectInfo_IarrayBHandler")]
		protected override unsafe void OnInflatedObjectData (global::Org.Eclipse.Jgit.Transport.PackedObjectInfo obj, int typeCode, byte[] data)
		{
			const string __id = "onInflatedObjectData.(Lorg/eclipse/jgit/transport/PackedObjectInfo;I[B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (typeCode);
				__args [2] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onObjectData' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.Source'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onObjectData", "(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V", "GetOnObjectData_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler")]
		protected override unsafe void OnObjectData (global::Org.Eclipse.Jgit.Transport.PackParser.Source src, byte[] raw, int pos, int len)
		{
			const string __id = "onObjectData.(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (native_raw);
				__args [2] = new JniArgumentValue (pos);
				__args [3] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (raw);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onObjectHeader' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.Source'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onObjectHeader", "(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V", "GetOnObjectHeader_Lorg_eclipse_jgit_transport_PackParser_Source_arrayBIIHandler")]
		protected override unsafe void OnObjectHeader (global::Org.Eclipse.Jgit.Transport.PackParser.Source src, byte[] raw, int pos, int len)
		{
			const string __id = "onObjectHeader.(Lorg/eclipse/jgit/transport/PackParser$Source;[BII)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (native_raw);
				__args [2] = new JniArgumentValue (pos);
				__args [3] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="hash">the trailing 20 bytes of the pack, this is a SHA-1 checksum of
		///            all of the pack data.</param>
		/// <summary>Provide the implementation with the original stream's pack footer.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onPackFooter' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onPackFooter", "([B)V", "GetOnPackFooter_arrayBHandler")]
		protected override unsafe void OnPackFooter (byte[] hash)
		{
			const string __id = "onPackFooter.([B)V";
			IntPtr native_hash = JNIEnv.NewArray (hash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hash);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (hash != null) {
					JNIEnv.CopyArray (native_hash, hash);
					JNIEnv.DeleteLocalRef (native_hash);
				}
				global::System.GC.KeepAlive (hash);
			}
		}

		/// <param name="objCnt">number of objects expected in the stream.</param>
		/// <summary>Provide the implementation with the original stream's pack header.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onPackHeader' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onPackHeader", "(J)V", "GetOnPackHeader_JHandler")]
		protected override unsafe void OnPackHeader (long objCnt)
		{
			const string __id = "onPackHeader.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (objCnt);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <param name="raw">buffer to copy data out of.</param>
		/// <param name="pos">first offset within the buffer that is valid.</param>
		/// <param name="len">number of bytes in the buffer that are valid.</param>
		/// <summary>Store bytes received from the raw stream.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='onStoreStream' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStoreStream", "([BII)V", "GetOnStoreStream_arrayBIIHandler")]
		protected override unsafe void OnStoreStream (byte[] raw, int pos, int len)
		{
			const string __id = "onStoreStream.([BII)V";
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_raw);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (raw);
			}
		}

		/// <param name="dst">the buffer to copy read data into.</param>
		/// <param name="pos">position within <c>dst</c> to start copying data into.</param>
		/// <param name="cnt">ideal target number of bytes to read. Actual read length may
		///            be shorter.</param>
		/// <summary>Read from the database's current position into the buffer.</summary>
		/// <returns>number of bytes stored.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='readDatabase' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readDatabase", "([BII)I", "GetReadDatabase_arrayBIIHandler")]
		protected override unsafe int ReadDatabase (byte[] dst, int pos, int cnt)
		{
			const string __id = "readDatabase.([BII)I";
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_dst);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (cnt);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
				global::System.GC.KeepAlive (dst);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='seekDatabase' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.PackedObjectInfo'] and parameter[2][@type='org.eclipse.jgit.transport.PackParser.ObjectTypeAndSize']]"
		[Register ("seekDatabase", "(Lorg/eclipse/jgit/transport/PackedObjectInfo;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;", "GetSeekDatabase_Lorg_eclipse_jgit_transport_PackedObjectInfo_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize SeekDatabase (global::Org.Eclipse.Jgit.Transport.PackedObjectInfo obj, global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize info)
		{
			const string __id = "seekDatabase.(Lorg/eclipse/jgit/transport/PackedObjectInfo;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (info);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='PackParser']/method[@name='seekDatabase' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.transport.PackParser.UnresolvedDelta'] and parameter[2][@type='org.eclipse.jgit.transport.PackParser.ObjectTypeAndSize']]"
		[Register ("seekDatabase", "(Lorg/eclipse/jgit/transport/PackParser$UnresolvedDelta;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;", "GetSeekDatabase_Lorg_eclipse_jgit_transport_PackParser_UnresolvedDelta_Lorg_eclipse_jgit_transport_PackParser_ObjectTypeAndSize_Handler")]
		protected override unsafe global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize SeekDatabase (global::Org.Eclipse.Jgit.Transport.PackParser.UnresolvedDelta delta, global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize info)
		{
			const string __id = "seekDatabase.(Lorg/eclipse/jgit/transport/PackParser$UnresolvedDelta;Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;)Lorg/eclipse/jgit/transport/PackParser$ObjectTypeAndSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((delta == null) ? IntPtr.Zero : ((global::Java.Lang.Object) delta).Handle);
				__args [1] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser.ObjectTypeAndSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (delta);
				global::System.GC.KeepAlive (info);
			}
		}

	}
}
