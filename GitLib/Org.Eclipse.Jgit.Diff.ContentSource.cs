using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>Supplies the content of a file for <c>DiffFormatter</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/ContentSource", DoNotGenerateAcw=true)]
	public abstract partial class ContentSource : global::Java.Lang.Object {
		/// <summary>A pair of sources to access the old and new sides of a DiffEntry.</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource.Pair']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/diff/ContentSource$Pair", DoNotGenerateAcw=true)]
		public sealed partial class Pair : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/ContentSource$Pair", typeof (Pair));

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

			internal Pair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <param name="oldSource">source to read the old side of a DiffEntry.</param>
			/// <param name="newSource">source to read the new side of a DiffEntry.</param>
			/// <summary>Construct a pair of sources.</summary>
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource.Pair']/constructor[@name='ContentSource.Pair' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.ContentSource'] and parameter[2][@type='org.eclipse.jgit.diff.ContentSource']]"
			[Register (".ctor", "(Lorg/eclipse/jgit/diff/ContentSource;Lorg/eclipse/jgit/diff/ContentSource;)V", "")]
			public unsafe Pair (global::Org.Eclipse.Jgit.Diff.ContentSource oldSource, global::Org.Eclipse.Jgit.Diff.ContentSource newSource) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/eclipse/jgit/diff/ContentSource;Lorg/eclipse/jgit/diff/ContentSource;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((oldSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldSource).Handle);
					__args [1] = new JniArgumentValue ((newSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newSource).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (oldSource);
					global::System.GC.KeepAlive (newSource);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource.Pair']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry.Side'] and parameter[2][@type='org.eclipse.jgit.diff.DiffEntry']]"
			[Register ("open", "(Lorg/eclipse/jgit/diff/DiffEntry$Side;Lorg/eclipse/jgit/diff/DiffEntry;)Lorg/eclipse/jgit/lib/ObjectLoader;", "")]
			public unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (global::Org.Eclipse.Jgit.Diff.DiffEntry.Side side, global::Org.Eclipse.Jgit.Diff.DiffEntry ent)
			{
				const string __id = "open.(Lorg/eclipse/jgit/diff/DiffEntry$Side;Lorg/eclipse/jgit/diff/DiffEntry;)Lorg/eclipse/jgit/lib/ObjectLoader;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((side == null) ? IntPtr.Zero : ((global::Java.Lang.Object) side).Handle);
					__args [1] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (side);
					global::System.GC.KeepAlive (ent);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource.Pair']/method[@name='size' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.diff.DiffEntry.Side'] and parameter[2][@type='org.eclipse.jgit.diff.DiffEntry']]"
			[Register ("size", "(Lorg/eclipse/jgit/diff/DiffEntry$Side;Lorg/eclipse/jgit/diff/DiffEntry;)J", "")]
			public unsafe long Size (global::Org.Eclipse.Jgit.Diff.DiffEntry.Side side, global::Org.Eclipse.Jgit.Diff.DiffEntry ent)
			{
				const string __id = "size.(Lorg/eclipse/jgit/diff/DiffEntry$Side;Lorg/eclipse/jgit/diff/DiffEntry;)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((side == null) ? IntPtr.Zero : ((global::Java.Lang.Object) side).Handle);
					__args [1] = new JniArgumentValue ((ent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ent).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (side);
					global::System.GC.KeepAlive (ent);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/ContentSource", typeof (ContentSource));

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

		protected ContentSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource']/constructor[@name='ContentSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContentSource () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <param name="reader">the reader to obtain blobs from.</param>
		/// <summary>Construct a content source for an ObjectReader.</summary>
		/// <returns>a source wrapping the reader.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register ("create", "(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/diff/ContentSource;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Diff.ContentSource Create (global::Org.Eclipse.Jgit.Lib.ObjectReader reader)
		{
			const string __id = "create.(Lorg/eclipse/jgit/lib/ObjectReader;)Lorg/eclipse/jgit/diff/ContentSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.ContentSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		/// <param name="iterator">the iterator to obtain source files through.</param>
		/// <summary>Construct a content source for a working directory.</summary>
		/// <returns>a content source wrapping the iterator.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator']]"
		[Register ("create", "(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)Lorg/eclipse/jgit/diff/ContentSource;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Diff.ContentSource Create (global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator iterator)
		{
			const string __id = "create.(Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)Lorg/eclipse/jgit/diff/ContentSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.ContentSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (iterator);
			}
		}

		static Delegate cb_open_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_open_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_open_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Open_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_open_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static IntPtr n_Open_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.ContentSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (path, id));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">the path of the file, relative to the root of the repository.</param>
		/// <param name="id">blob id of the file, if known.</param>
		/// <summary>Open the object.</summary>
		/// <returns>a loader that can supply the content of the file. The loader must
		///         be used before another loader can be obtained from this same
		///         source.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource']/method[@name='open' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("open", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpen_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public abstract global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (string path, global::Org.Eclipse.Jgit.Lib.ObjectId id);

		static Delegate cb_size_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_;
#pragma warning disable 0169
		static Delegate GetSize_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Handler ()
		{
			if (cb_size_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_ == null)
				cb_size_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_J) n_Size_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_);
			return cb_size_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_;
		}

		static long n_Size_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.ContentSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (native_id, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Size (path, id);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">the path of the file, relative to the root of the repository.</param>
		/// <param name="id">blob id of the file, if known.</param>
		/// <summary>Determine the size of the object.</summary>
		/// <returns>the size in bytes.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource']/method[@name='size' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("size", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)J", "GetSize_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public abstract long Size (string path, global::Org.Eclipse.Jgit.Lib.ObjectId id);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/ContentSource", DoNotGenerateAcw=true)]
	internal partial class ContentSourceInvoker : ContentSource {
		public ContentSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/ContentSource", typeof (ContentSourceInvoker));

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

		/// <param name="path">the path of the file, relative to the root of the repository.</param>
		/// <param name="id">blob id of the file, if known.</param>
		/// <summary>Open the object.</summary>
		/// <returns>a loader that can supply the content of the file. The loader must
		///         be used before another loader can be obtained from this same
		///         source.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource']/method[@name='open' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("open", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/lib/ObjectLoader;", "GetOpen_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (string path, global::Org.Eclipse.Jgit.Lib.ObjectId id)
		{
			const string __id = "open.(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)Lorg/eclipse/jgit/lib/ObjectLoader;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (id);
			}
		}

		/// <param name="path">the path of the file, relative to the root of the repository.</param>
		/// <param name="id">blob id of the file, if known.</param>
		/// <summary>Determine the size of the object.</summary>
		/// <returns>the size in bytes.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='ContentSource']/method[@name='size' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId']]"
		[Register ("size", "(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)J", "GetSize_Ljava_lang_String_Lorg_eclipse_jgit_lib_ObjectId_Handler")]
		public override unsafe long Size (string path, global::Org.Eclipse.Jgit.Lib.ObjectId id)
		{
			const string __id = "size.(Ljava/lang/String;Lorg/eclipse/jgit/lib/ObjectId;)J";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (id);
			}
		}

	}
}
