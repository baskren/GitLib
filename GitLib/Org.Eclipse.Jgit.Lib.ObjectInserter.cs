using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Inserts objects into an existing <c>ObjectDatabase</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectInserter", DoNotGenerateAcw=true)]
	public abstract partial class ObjectInserter : global::Java.Lang.Object {
		/// <summary>Wraps a delegate ObjectInserter.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Filter']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectInserter$Filter", DoNotGenerateAcw=true)]
		public abstract partial class Filter : global::Org.Eclipse.Jgit.Lib.ObjectInserter {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectInserter$Filter", typeof (Filter));

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

			protected Filter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Filter']/constructor[@name='ObjectInserter.Filter' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Filter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_delegate;
#pragma warning disable 0169
			static Delegate GetDelegateHandler ()
			{
				if (cb_delegate == null)
					cb_delegate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Delegate);
				return cb_delegate;
			}

			static IntPtr n_Delegate (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Delegate ());
			}
#pragma warning restore 0169

			/// <returns>delegate ObjectInserter to handle all processing.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Filter']/method[@name='delegate' and count(parameter)=0]"
			[Register ("delegate", "()Lorg/eclipse/jgit/lib/ObjectInserter;", "GetDelegateHandler")]
			protected abstract global::Org.Eclipse.Jgit.Lib.ObjectInserter Delegate ();

			static Delegate cb_flush;
#pragma warning disable 0169
			static Delegate GetFlushHandler ()
			{
				if (cb_flush == null)
					cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
				return cb_flush;
			}

			static void n_Flush (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Flush ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Filter']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "GetFlushHandler")]
			public override unsafe void Flush ()
			{
				const string __id = "flush.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_insert_IJLjava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetInsert_IJLjava_io_InputStream_Handler ()
			{
				if (cb_insert_IJLjava_io_InputStream_ == null)
					cb_insert_IJLjava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJL_L) n_Insert_IJLjava_io_InputStream_);
				return cb_insert_IJLjava_io_InputStream_;
			}

			static IntPtr n_Insert_IJLjava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, int objectType, long length, IntPtr native__in)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (objectType, length, @in));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Filter']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.InputStream']]"
			[Register ("insert", "(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;", "GetInsert_IJLjava_io_InputStream_Handler")]
			public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Insert (int objectType, long length, global::System.IO.Stream @in)
			{
				const string __id = "insert.(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;";
				IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (objectType);
					__args [1] = new JniArgumentValue (length);
					__args [2] = new JniArgumentValue (native__in);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native__in);
					global::System.GC.KeepAlive (@in);
				}
			}

			static Delegate cb_newPackParser_Ljava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetNewPackParser_Ljava_io_InputStream_Handler ()
			{
				if (cb_newPackParser_Ljava_io_InputStream_ == null)
					cb_newPackParser_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewPackParser_Ljava_io_InputStream_);
				return cb_newPackParser_Ljava_io_InputStream_;
			}

			static IntPtr n_NewPackParser_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewPackParser (@in));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Filter']/method[@name='newPackParser' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("newPackParser", "(Ljava/io/InputStream;)Lorg/eclipse/jgit/transport/PackParser;", "GetNewPackParser_Ljava_io_InputStream_Handler")]
			public override unsafe global::Org.Eclipse.Jgit.Transport.PackParser NewPackParser (global::System.IO.Stream @in)
			{
				const string __id = "newPackParser.(Ljava/io/InputStream;)Lorg/eclipse/jgit/transport/PackParser;";
				IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native__in);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native__in);
					global::System.GC.KeepAlive (@in);
				}
			}

			static Delegate cb_newReader;
#pragma warning disable 0169
			static Delegate GetNewReaderHandler ()
			{
				if (cb_newReader == null)
					cb_newReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewReader);
				return cb_newReader;
			}

			static IntPtr n_NewReader (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NewReader ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Filter']/method[@name='newReader' and count(parameter)=0]"
			[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
			public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ()
			{
				const string __id = "newReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Filter']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "GetReleaseHandler")]
			public override unsafe void Release ()
			{
				const string __id = "release.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectInserter$Filter", DoNotGenerateAcw=true)]
		internal partial class FilterInvoker : Filter {
			public FilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectInserter$Filter", typeof (FilterInvoker));

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

			/// <returns>delegate ObjectInserter to handle all processing.</returns>
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Filter']/method[@name='delegate' and count(parameter)=0]"
			[Register ("delegate", "()Lorg/eclipse/jgit/lib/ObjectInserter;", "GetDelegateHandler")]
			protected override unsafe global::Org.Eclipse.Jgit.Lib.ObjectInserter Delegate ()
			{
				const string __id = "delegate.()Lorg/eclipse/jgit/lib/ObjectInserter;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		/// <summary>An inserter that can be used for formatting and id generation only.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Formatter']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectInserter$Formatter", DoNotGenerateAcw=true)]
		public partial class Formatter : global::Org.Eclipse.Jgit.Lib.ObjectInserter {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectInserter$Formatter", typeof (Formatter));

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

			protected Formatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Formatter']/constructor[@name='ObjectInserter.Formatter' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Formatter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_flush;
#pragma warning disable 0169
			static Delegate GetFlushHandler ()
			{
				if (cb_flush == null)
					cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
				return cb_flush;
			}

			static void n_Flush (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Formatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Flush ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Formatter']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "GetFlushHandler")]
			public override unsafe void Flush ()
			{
				const string __id = "flush.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_insert_IJLjava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetInsert_IJLjava_io_InputStream_Handler ()
			{
				if (cb_insert_IJLjava_io_InputStream_ == null)
					cb_insert_IJLjava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJL_L) n_Insert_IJLjava_io_InputStream_);
				return cb_insert_IJLjava_io_InputStream_;
			}

			static IntPtr n_Insert_IJLjava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, int objectType, long length, IntPtr native__in)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Formatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (objectType, length, @in));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Formatter']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.InputStream']]"
			[Register ("insert", "(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;", "GetInsert_IJLjava_io_InputStream_Handler")]
			public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Insert (int objectType, long length, global::System.IO.Stream @in)
			{
				const string __id = "insert.(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;";
				IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (objectType);
					__args [1] = new JniArgumentValue (length);
					__args [2] = new JniArgumentValue (native__in);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native__in);
					global::System.GC.KeepAlive (@in);
				}
			}

			static Delegate cb_newPackParser_Ljava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetNewPackParser_Ljava_io_InputStream_Handler ()
			{
				if (cb_newPackParser_Ljava_io_InputStream_ == null)
					cb_newPackParser_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewPackParser_Ljava_io_InputStream_);
				return cb_newPackParser_Ljava_io_InputStream_;
			}

			static IntPtr n_NewPackParser_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Formatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewPackParser (@in));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Formatter']/method[@name='newPackParser' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("newPackParser", "(Ljava/io/InputStream;)Lorg/eclipse/jgit/transport/PackParser;", "GetNewPackParser_Ljava_io_InputStream_Handler")]
			public override unsafe global::Org.Eclipse.Jgit.Transport.PackParser NewPackParser (global::System.IO.Stream @in)
			{
				const string __id = "newPackParser.(Ljava/io/InputStream;)Lorg/eclipse/jgit/transport/PackParser;";
				IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native__in);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native__in);
					global::System.GC.KeepAlive (@in);
				}
			}

			static Delegate cb_newReader;
#pragma warning disable 0169
			static Delegate GetNewReaderHandler ()
			{
				if (cb_newReader == null)
					cb_newReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewReader);
				return cb_newReader;
			}

			static IntPtr n_NewReader (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Formatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NewReader ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Formatter']/method[@name='newReader' and count(parameter)=0]"
			[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
			public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ()
			{
				const string __id = "newReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter.Formatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter.Formatter']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "GetReleaseHandler")]
			public override unsafe void Release ()
			{
				const string __id = "release.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectInserter", typeof (ObjectInserter));

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

		protected ObjectInserter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Create a new inserter for a database.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/constructor[@name='ObjectInserter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ObjectInserter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Buffer ());
		}
#pragma warning restore 0169

		/// <summary>Obtain a temporary buffer for use by the ObjectInserter or its subclass.</summary>
		/// <returns>a temporary byte array for use by the caller.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='buffer' and count(parameter)=0]"
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

		static Delegate cb_digest;
#pragma warning disable 0169
		static Delegate GetDigestHandler ()
		{
			if (cb_digest == null)
				cb_digest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Digest);
			return cb_digest;
		}

		static IntPtr n_Digest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Digest ());
		}
#pragma warning restore 0169

		/// <returns>digest to help compute an ObjectId</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='digest' and count(parameter)=0]"
		[Register ("digest", "()Ljava/security/MessageDigest;", "GetDigestHandler")]
		protected virtual unsafe global::Java.Security.MessageDigest Digest ()
		{
			const string __id = "digest.()Ljava/security/MessageDigest;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		/// <summary>Make all inserted objects visible.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public abstract void Flush ();

		static Delegate cb_idFor_IarrayB;
#pragma warning disable 0169
		static Delegate GetIdFor_IarrayBHandler ()
		{
			if (cb_idFor_IarrayB == null)
				cb_idFor_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_IdFor_IarrayB);
			return cb_idFor_IarrayB;
		}

		static IntPtr n_IdFor_IarrayB (IntPtr jnienv, IntPtr native__this, int type, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IdFor (type, data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="type">type code of the object to store.</param>
		/// <param name="data">complete content of the object.</param>
		/// <summary>Compute the name of an object, without inserting it.</summary>
		/// <returns>the name of the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='idFor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("idFor", "(I[B)Lorg/eclipse/jgit/lib/ObjectId;", "GetIdFor_IarrayBHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId IdFor (int type, byte[] data)
		{
			const string __id = "idFor.(I[B)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_idFor_IarrayBII;
#pragma warning disable 0169
		static Delegate GetIdFor_IarrayBIIHandler ()
		{
			if (cb_idFor_IarrayBII == null)
				cb_idFor_IarrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILII_L) n_IdFor_IarrayBII);
			return cb_idFor_IarrayBII;
		}

		static IntPtr n_IdFor_IarrayBII (IntPtr jnienv, IntPtr native__this, int type, IntPtr native_data, int off, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IdFor (type, data, off, len));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="type">type code of the object to store.</param>
		/// <param name="data">complete content of the object.</param>
		/// <param name="off">first position within <c>data</c>.</param>
		/// <param name="len">number of bytes to copy from <c>data</c>.</param>
		/// <summary>Compute the name of an object, without inserting it.</summary>
		/// <returns>the name of the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='idFor' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("idFor", "(I[BII)Lorg/eclipse/jgit/lib/ObjectId;", "GetIdFor_IarrayBIIHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId IdFor (int type, byte[] data, int off, int len)
		{
			const string __id = "idFor.(I[BII)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue (off);
				__args [3] = new JniArgumentValue (len);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_idFor_IJLjava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetIdFor_IJLjava_io_InputStream_Handler ()
		{
			if (cb_idFor_IJLjava_io_InputStream_ == null)
				cb_idFor_IJLjava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJL_L) n_IdFor_IJLjava_io_InputStream_);
			return cb_idFor_IJLjava_io_InputStream_;
		}

		static IntPtr n_IdFor_IJLjava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, int objectType, long length, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IdFor (objectType, length, @in));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectType">type code of the object to store.</param>
		/// <param name="length">number of bytes to scan from <c>in</c>.</param>
		/// <param name="in">stream providing the object content. The caller is responsible
		///            for closing the stream.</param>
		/// <summary>Compute the name of an object, without inserting it.</summary>
		/// <returns>the name of the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='idFor' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.InputStream']]"
		[Register ("idFor", "(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;", "GetIdFor_IJLjava_io_InputStream_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId IdFor (int objectType, long length, global::System.IO.Stream @in)
		{
			const string __id = "idFor.(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (objectType);
				__args [1] = new JniArgumentValue (length);
				__args [2] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate cb_idFor_Lorg_eclipse_jgit_lib_TreeFormatter_;
#pragma warning disable 0169
		static Delegate GetIdFor_Lorg_eclipse_jgit_lib_TreeFormatter_Handler ()
		{
			if (cb_idFor_Lorg_eclipse_jgit_lib_TreeFormatter_ == null)
				cb_idFor_Lorg_eclipse_jgit_lib_TreeFormatter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_IdFor_Lorg_eclipse_jgit_lib_TreeFormatter_);
			return cb_idFor_Lorg_eclipse_jgit_lib_TreeFormatter_;
		}

		static IntPtr n_IdFor_Lorg_eclipse_jgit_lib_TreeFormatter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_formatter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var formatter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.TreeFormatter> (native_formatter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IdFor (formatter));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="formatter">formatter</param>
		/// <summary>Compute the ObjectId for the given tree without inserting it.</summary>
		/// <returns>the computed ObjectId</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='idFor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.TreeFormatter']]"
		[Register ("idFor", "(Lorg/eclipse/jgit/lib/TreeFormatter;)Lorg/eclipse/jgit/lib/ObjectId;", "GetIdFor_Lorg_eclipse_jgit_lib_TreeFormatter_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId IdFor (global::Org.Eclipse.Jgit.Lib.TreeFormatter formatter)
		{
			const string __id = "idFor.(Lorg/eclipse/jgit/lib/TreeFormatter;)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((formatter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formatter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (formatter);
			}
		}

		static Delegate cb_insert_IarrayB;
#pragma warning disable 0169
		static Delegate GetInsert_IarrayBHandler ()
		{
			if (cb_insert_IarrayB == null)
				cb_insert_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Insert_IarrayB);
			return cb_insert_IarrayB;
		}

		static IntPtr n_Insert_IarrayB (IntPtr jnienv, IntPtr native__this, int type, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (type, data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="type">type code of the object to store.</param>
		/// <param name="data">complete content of the object.</param>
		/// <summary>Insert a single object into the store, returning its unique name.</summary>
		/// <returns>the name of the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("insert", "(I[B)Lorg/eclipse/jgit/lib/ObjectId;", "GetInsert_IarrayBHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Insert (int type, byte[] data)
		{
			const string __id = "insert.(I[B)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_insert_IarrayBII;
#pragma warning disable 0169
		static Delegate GetInsert_IarrayBIIHandler ()
		{
			if (cb_insert_IarrayBII == null)
				cb_insert_IarrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILII_L) n_Insert_IarrayBII);
			return cb_insert_IarrayBII;
		}

		static IntPtr n_Insert_IarrayBII (IntPtr jnienv, IntPtr native__this, int type, IntPtr native_data, int off, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (type, data, off, len));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="type">type code of the object to store.</param>
		/// <param name="data">complete content of the object.</param>
		/// <param name="off">first position within <c>data</c>.</param>
		/// <param name="len">number of bytes to copy from <c>data</c>.</param>
		/// <summary>Insert a single object into the store, returning its unique name.</summary>
		/// <returns>the name of the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='insert' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("insert", "(I[BII)Lorg/eclipse/jgit/lib/ObjectId;", "GetInsert_IarrayBIIHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Insert (int type, byte[] data, int off, int len)
		{
			const string __id = "insert.(I[BII)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue (off);
				__args [3] = new JniArgumentValue (len);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_insert_IJLjava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetInsert_IJLjava_io_InputStream_Handler ()
		{
			if (cb_insert_IJLjava_io_InputStream_ == null)
				cb_insert_IJLjava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJL_L) n_Insert_IJLjava_io_InputStream_);
			return cb_insert_IJLjava_io_InputStream_;
		}

		static IntPtr n_Insert_IJLjava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, int objectType, long length, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (objectType, length, @in));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="objectType">type code of the object to store.</param>
		/// <param name="length">number of bytes to copy from <c>in</c>.</param>
		/// <param name="in">stream providing the object content. The caller is responsible
		///            for closing the stream.</param>
		/// <summary>Insert a single object into the store, returning its unique name.</summary>
		/// <returns>the name of the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.InputStream']]"
		[Register ("insert", "(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;", "GetInsert_IJLjava_io_InputStream_Handler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectId Insert (int objectType, long length, global::System.IO.Stream @in);

		/// <param name="builder">the builder containing the proposed commit's data.</param>
		/// <summary>Insert a single commit into the store, returning its unique name.</summary>
		/// <returns>the name of the commit object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.CommitBuilder']]"
		[Register ("insert", "(Lorg/eclipse/jgit/lib/CommitBuilder;)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Insert (global::Org.Eclipse.Jgit.Lib.CommitBuilder builder)
		{
			const string __id = "insert.(Lorg/eclipse/jgit/lib/CommitBuilder;)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

		/// <param name="builder">the builder containing the proposed tag's data.</param>
		/// <summary>Insert a single annotated tag into the store, returning its unique name.</summary>
		/// <returns>the name of the tag object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.TagBuilder']]"
		[Register ("insert", "(Lorg/eclipse/jgit/lib/TagBuilder;)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Insert (global::Org.Eclipse.Jgit.Lib.TagBuilder builder)
		{
			const string __id = "insert.(Lorg/eclipse/jgit/lib/TagBuilder;)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

		/// <param name="formatter">the formatter containing the proposed tree's data.</param>
		/// <summary>Insert a single tree into the store, returning its unique name.</summary>
		/// <returns>the name of the tree object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.TreeFormatter']]"
		[Register ("insert", "(Lorg/eclipse/jgit/lib/TreeFormatter;)Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Insert (global::Org.Eclipse.Jgit.Lib.TreeFormatter formatter)
		{
			const string __id = "insert.(Lorg/eclipse/jgit/lib/TreeFormatter;)Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((formatter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formatter).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (formatter);
			}
		}

		static Delegate cb_newPackParser_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetNewPackParser_Ljava_io_InputStream_Handler ()
		{
			if (cb_newPackParser_Ljava_io_InputStream_ == null)
				cb_newPackParser_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewPackParser_Ljava_io_InputStream_);
			return cb_newPackParser_Ljava_io_InputStream_;
		}

		static IntPtr n_NewPackParser_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewPackParser (@in));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="in">the input stream. The stream is not closed by the parser, and
		///            must instead be closed by the caller once parsing is complete.</param>
		/// <summary>Initialize a parser to read from a pack formatted stream.</summary>
		/// <returns>the pack parser.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='newPackParser' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("newPackParser", "(Ljava/io/InputStream;)Lorg/eclipse/jgit/transport/PackParser;", "GetNewPackParser_Ljava_io_InputStream_Handler")]
		public abstract global::Org.Eclipse.Jgit.Transport.PackParser NewPackParser (global::System.IO.Stream @in);

		static Delegate cb_newReader;
#pragma warning disable 0169
		static Delegate GetNewReaderHandler ()
		{
			if (cb_newReader == null)
				cb_newReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewReader);
			return cb_newReader;
		}

		static IntPtr n_NewReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewReader ());
		}
#pragma warning restore 0169

		/// <summary>Open a reader for objects that may have been written by this inserter.</summary>
		/// <returns>reader for any object, including an object recently inserted by
		///         this inserter since the last flush.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='newReader' and count(parameter)=0]"
		[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ();

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectInserter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		/// <summary>Release any resources used by this inserter.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public abstract void Release ();

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ObjectInserter", DoNotGenerateAcw=true)]
	internal partial class ObjectInserterInvoker : ObjectInserter {
		public ObjectInserterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ObjectInserter", typeof (ObjectInserterInvoker));

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

		/// <summary>Make all inserted objects visible.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public override unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		/// <param name="objectType">type code of the object to store.</param>
		/// <param name="length">number of bytes to copy from <c>in</c>.</param>
		/// <param name="in">stream providing the object content. The caller is responsible
		///            for closing the stream.</param>
		/// <summary>Insert a single object into the store, returning its unique name.</summary>
		/// <returns>the name of the object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.InputStream']]"
		[Register ("insert", "(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;", "GetInsert_IJLjava_io_InputStream_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectId Insert (int objectType, long length, global::System.IO.Stream @in)
		{
			const string __id = "insert.(IJLjava/io/InputStream;)Lorg/eclipse/jgit/lib/ObjectId;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (objectType);
				__args [1] = new JniArgumentValue (length);
				__args [2] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		/// <param name="in">the input stream. The stream is not closed by the parser, and
		///            must instead be closed by the caller once parsing is complete.</param>
		/// <summary>Initialize a parser to read from a pack formatted stream.</summary>
		/// <returns>the pack parser.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='newPackParser' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("newPackParser", "(Ljava/io/InputStream;)Lorg/eclipse/jgit/transport/PackParser;", "GetNewPackParser_Ljava_io_InputStream_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Transport.PackParser NewPackParser (global::System.IO.Stream @in)
		{
			const string __id = "newPackParser.(Ljava/io/InputStream;)Lorg/eclipse/jgit/transport/PackParser;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Transport.PackParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				global::System.GC.KeepAlive (@in);
			}
		}

		/// <summary>Open a reader for objects that may have been written by this inserter.</summary>
		/// <returns>reader for any object, including an object recently inserted by
		///         this inserter since the last flush.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='newReader' and count(parameter)=0]"
		[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "GetNewReaderHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ()
		{
			const string __id = "newReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <summary>Release any resources used by this inserter.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ObjectInserter']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public override unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
