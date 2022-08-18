using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Compares the index, a tree, and the working directory Ignored files are not
	/// taken into account.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/IndexDiff", DoNotGenerateAcw=true)]
	public partial class IndexDiff : global::Java.Lang.Object {
		/// <summary>Represents the state of the index for a certain path regarding the stages
		/// - which stages exist for a path and which not (base, ours, theirs).</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/IndexDiff$StageState", DoNotGenerateAcw=true)]
		public sealed partial class StageState : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/field[@name='ADDED_BY_THEM']"
			[Register ("ADDED_BY_THEM")]
			public static global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState AddedByThem {
				get {
					const string __id = "ADDED_BY_THEM.Lorg/eclipse/jgit/lib/IndexDiff$StageState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/field[@name='ADDED_BY_US']"
			[Register ("ADDED_BY_US")]
			public static global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState AddedByUs {
				get {
					const string __id = "ADDED_BY_US.Lorg/eclipse/jgit/lib/IndexDiff$StageState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/field[@name='BOTH_ADDED']"
			[Register ("BOTH_ADDED")]
			public static global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState BothAdded {
				get {
					const string __id = "BOTH_ADDED.Lorg/eclipse/jgit/lib/IndexDiff$StageState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/field[@name='BOTH_DELETED']"
			[Register ("BOTH_DELETED")]
			public static global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState BothDeleted {
				get {
					const string __id = "BOTH_DELETED.Lorg/eclipse/jgit/lib/IndexDiff$StageState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/field[@name='BOTH_MODIFIED']"
			[Register ("BOTH_MODIFIED")]
			public static global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState BothModified {
				get {
					const string __id = "BOTH_MODIFIED.Lorg/eclipse/jgit/lib/IndexDiff$StageState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/field[@name='DELETED_BY_THEM']"
			[Register ("DELETED_BY_THEM")]
			public static global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState DeletedByThem {
				get {
					const string __id = "DELETED_BY_THEM.Lorg/eclipse/jgit/lib/IndexDiff$StageState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/field[@name='DELETED_BY_US']"
			[Register ("DELETED_BY_US")]
			public static global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState DeletedByUs {
				get {
					const string __id = "DELETED_BY_US.Lorg/eclipse/jgit/lib/IndexDiff$StageState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/IndexDiff$StageState", typeof (StageState));

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

			internal StageState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			/// <returns>whether there is a "base" stage entry</returns>
			public unsafe bool HasBase {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/method[@name='hasBase' and count(parameter)=0]"
				[Register ("hasBase", "()Z", "")]
				get {
					const string __id = "hasBase.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			/// <returns>whether there is an "ours" stage entry</returns>
			public unsafe bool HasOurs {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/method[@name='hasOurs' and count(parameter)=0]"
				[Register ("hasOurs", "()Z", "")]
				get {
					const string __id = "hasOurs.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			/// <returns>whether there is a "theirs" stage entry</returns>
			public unsafe bool HasTheirs {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/method[@name='hasTheirs' and count(parameter)=0]"
				[Register ("hasTheirs", "()Z", "")]
				get {
					const string __id = "hasTheirs.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/IndexDiff$StageState;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/IndexDiff$StageState;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff.StageState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/lib/IndexDiff$StageState;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/lib/IndexDiff$StageState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState));
				} finally {
				}
			}

		}

		/// <summary>A factory to producing WorkingTreeIterators</summary>
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='IndexDiff.WorkingTreeIteratorFactory']"
		[Register ("org/eclipse/jgit/lib/IndexDiff$WorkingTreeIteratorFactory", "", "Org.Eclipse.Jgit.Lib.IndexDiff/IWorkingTreeIteratorFactoryInvoker")]
		public partial interface IWorkingTreeIteratorFactory : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='IndexDiff.WorkingTreeIteratorFactory']/method[@name='getWorkingTreeIterator' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
			/// <param name="repo">repo</param>
			/// <returns>a WorkingTreeIterator for repo</returns>
			[Register ("getWorkingTreeIterator", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;", "GetGetWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_Handler:Org.Eclipse.Jgit.Lib.IndexDiff/IWorkingTreeIteratorFactoryInvoker, AndroidBindableLibrary")]
			global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator GetWorkingTreeIterator (global::Org.Eclipse.Jgit.Lib.Repository repo);

		}

		[global::Android.Runtime.Register ("org/eclipse/jgit/lib/IndexDiff$WorkingTreeIteratorFactory", DoNotGenerateAcw=true)]
		internal partial class IWorkingTreeIteratorFactoryInvoker : global::Java.Lang.Object, IWorkingTreeIteratorFactory {
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/IndexDiff$WorkingTreeIteratorFactory", typeof (IWorkingTreeIteratorFactoryInvoker));

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

			public static IWorkingTreeIteratorFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IWorkingTreeIteratorFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.IndexDiff.WorkingTreeIteratorFactory'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IWorkingTreeIteratorFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_;
#pragma warning disable 0169
			static Delegate GetGetWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_Handler ()
			{
				if (cb_getWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_ == null)
					cb_getWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_);
				return cb_getWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_;
			}

			static IntPtr n_GetWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.IWorkingTreeIteratorFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var repo = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_repo, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetWorkingTreeIterator (repo));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_;
			public unsafe global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator GetWorkingTreeIterator (global::Org.Eclipse.Jgit.Lib.Repository repo)
			{
				if (id_getWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_ == IntPtr.Zero)
					id_getWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_ = JNIEnv.GetMethodID (class_ref, "getWorkingTreeIterator", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWorkingTreeIterator_Lorg_eclipse_jgit_lib_Repository_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/IndexDiff", typeof (IndexDiff));

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

		protected IndexDiff (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repository">repository</param>
		/// <param name="revstr">symbolic name e.g. HEAD
		///            An EmptyTreeIterator is used if &lt;code&gt;revstr&lt;/code&gt; cannot be resolved.</param>
		/// <param name="workingTreeIterator">iterator for working directory</param>
		/// <summary>Construct an IndexDiff</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/constructor[@name='IndexDiff' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V", "")]
		public unsafe IndexDiff (global::Org.Eclipse.Jgit.Lib.Repository repository, string revstr, global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator workingTreeIterator) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Ljava/lang/String;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_revstr = JNIEnv.NewString ((string)revstr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue (native_revstr);
				__args [2] = new JniArgumentValue ((workingTreeIterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) workingTreeIterator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_revstr);
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (workingTreeIterator);
			}
		}

		/// <param name="repository">repository</param>
		/// <param name="objectId">tree id. If null, an EmptyTreeIterator is used.</param>
		/// <param name="workingTreeIterator">iterator for working directory</param>
		/// <summary>Construct an Indexdiff</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/constructor[@name='IndexDiff' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='org.eclipse.jgit.lib.ObjectId'] and parameter[3][@type='org.eclipse.jgit.treewalk.WorkingTreeIterator']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V", "")]
		public unsafe IndexDiff (global::Org.Eclipse.Jgit.Lib.Repository repository, global::Org.Eclipse.Jgit.Lib.ObjectId objectId, global::Org.Eclipse.Jgit.Treewalk.WorkingTreeIterator workingTreeIterator) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;Lorg/eclipse/jgit/lib/ObjectId;Lorg/eclipse/jgit/treewalk/WorkingTreeIterator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				__args [1] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [2] = new JniArgumentValue ((workingTreeIterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) workingTreeIterator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repository);
				global::System.GC.KeepAlive (objectId);
				global::System.GC.KeepAlive (workingTreeIterator);
			}
		}

		static Delegate cb_getAdded;
#pragma warning disable 0169
		static Delegate GetGetAddedHandler ()
		{
			if (cb_getAdded == null)
				cb_getAdded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdded);
			return cb_getAdded;
		}

		static IntPtr n_GetAdded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Added);
		}
#pragma warning restore 0169

		/// <returns>list of files added to the index, not in the tree</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Added {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getAdded' and count(parameter)=0]"
			[Register ("getAdded", "()Ljava/util/Set;", "GetGetAddedHandler")]
			get {
				const string __id = "getAdded.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAssumeUnchanged;
#pragma warning disable 0169
		static Delegate GetGetAssumeUnchangedHandler ()
		{
			if (cb_getAssumeUnchanged == null)
				cb_getAssumeUnchanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAssumeUnchanged);
			return cb_getAssumeUnchanged;
		}

		static IntPtr n_GetAssumeUnchanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AssumeUnchanged);
		}
#pragma warning restore 0169

		/// <returns>list of files with the flag assume-unchanged</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> AssumeUnchanged {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getAssumeUnchanged' and count(parameter)=0]"
			[Register ("getAssumeUnchanged", "()Ljava/util/Set;", "GetGetAssumeUnchangedHandler")]
			get {
				const string __id = "getAssumeUnchanged.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChanged;
#pragma warning disable 0169
		static Delegate GetGetChangedHandler ()
		{
			if (cb_getChanged == null)
				cb_getChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChanged);
			return cb_getChanged;
		}

		static IntPtr n_GetChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Changed);
		}
#pragma warning restore 0169

		/// <returns>list of files changed from tree to index</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Changed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getChanged' and count(parameter)=0]"
			[Register ("getChanged", "()Ljava/util/Set;", "GetGetChangedHandler")]
			get {
				const string __id = "getChanged.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConflicting;
#pragma warning disable 0169
		static Delegate GetGetConflictingHandler ()
		{
			if (cb_getConflicting == null)
				cb_getConflicting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConflicting);
			return cb_getConflicting;
		}

		static IntPtr n_GetConflicting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Conflicting);
		}
#pragma warning restore 0169

		/// <returns>list of files that are in conflict, corresponds to the keys of
		///         <c>#getConflictingStageStates()</c></returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Conflicting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getConflicting' and count(parameter)=0]"
			[Register ("getConflicting", "()Ljava/util/Set;", "GetGetConflictingHandler")]
			get {
				const string __id = "getConflicting.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConflictingStageStates;
#pragma warning disable 0169
		static Delegate GetGetConflictingStageStatesHandler ()
		{
			if (cb_getConflictingStageStates == null)
				cb_getConflictingStageStates = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConflictingStageStates);
			return cb_getConflictingStageStates;
		}

		static IntPtr n_GetConflictingStageStates (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState>.ToLocalJniHandle (__this.ConflictingStageStates);
		}
#pragma warning restore 0169

		/// <returns>the map from each path of <c>#getConflicting()</c> to its
		///         corresponding <c>StageState</c></returns>
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState> ConflictingStageStates {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getConflictingStageStates' and count(parameter)=0]"
			[Register ("getConflictingStageStates", "()Ljava/util/Map;", "GetGetConflictingStageStatesHandler")]
			get {
				const string __id = "getConflictingStageStates.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Eclipse.Jgit.Lib.IndexDiff.StageState>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIgnoredNotInIndex;
#pragma warning disable 0169
		static Delegate GetGetIgnoredNotInIndexHandler ()
		{
			if (cb_getIgnoredNotInIndex == null)
				cb_getIgnoredNotInIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIgnoredNotInIndex);
			return cb_getIgnoredNotInIndex;
		}

		static IntPtr n_GetIgnoredNotInIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.IgnoredNotInIndex);
		}
#pragma warning restore 0169

		/// <summary>The method returns the list of ignored files and folders.</summary>
		/// <returns>list of files / folders that are ignored</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> IgnoredNotInIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getIgnoredNotInIndex' and count(parameter)=0]"
			[Register ("getIgnoredNotInIndex", "()Ljava/util/Set;", "GetGetIgnoredNotInIndexHandler")]
			get {
				const string __id = "getIgnoredNotInIndex.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMissing;
#pragma warning disable 0169
		static Delegate GetGetMissingHandler ()
		{
			if (cb_getMissing == null)
				cb_getMissing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMissing);
			return cb_getMissing;
		}

		static IntPtr n_GetMissing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Missing);
		}
#pragma warning restore 0169

		/// <returns>list of files in index, but not filesystem</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Missing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getMissing' and count(parameter)=0]"
			[Register ("getMissing", "()Ljava/util/Set;", "GetGetMissingHandler")]
			get {
				const string __id = "getMissing.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModified;
#pragma warning disable 0169
		static Delegate GetGetModifiedHandler ()
		{
			if (cb_getModified == null)
				cb_getModified = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModified);
			return cb_getModified;
		}

		static IntPtr n_GetModified (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Modified);
		}
#pragma warning restore 0169

		/// <returns>list of files modified on disk relative to the index</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Modified {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getModified' and count(parameter)=0]"
			[Register ("getModified", "()Ljava/util/Set;", "GetGetModifiedHandler")]
			get {
				const string __id = "getModified.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoved;
#pragma warning disable 0169
		static Delegate GetGetRemovedHandler ()
		{
			if (cb_getRemoved == null)
				cb_getRemoved = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRemoved);
			return cb_getRemoved;
		}

		static IntPtr n_GetRemoved (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Removed);
		}
#pragma warning restore 0169

		/// <returns>list of files removed from index, but in tree</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Removed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getRemoved' and count(parameter)=0]"
			[Register ("getRemoved", "()Ljava/util/Set;", "GetGetRemovedHandler")]
			get {
				const string __id = "getRemoved.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUntracked;
#pragma warning disable 0169
		static Delegate GetGetUntrackedHandler ()
		{
			if (cb_getUntracked == null)
				cb_getUntracked = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUntracked);
			return cb_getUntracked;
		}

		static IntPtr n_GetUntracked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Untracked);
		}
#pragma warning restore 0169

		/// <returns>list of files that are not ignored, and not in the index.</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Untracked {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getUntracked' and count(parameter)=0]"
			[Register ("getUntracked", "()Ljava/util/Set;", "GetGetUntrackedHandler")]
			get {
				const string __id = "getUntracked.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUntrackedFolders;
#pragma warning disable 0169
		static Delegate GetGetUntrackedFoldersHandler ()
		{
			if (cb_getUntrackedFolders == null)
				cb_getUntrackedFolders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUntrackedFolders);
			return cb_getUntrackedFolders;
		}

		static IntPtr n_GetUntrackedFolders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.UntrackedFolders);
		}
#pragma warning restore 0169

		/// <returns>list of folders containing only untracked files/folders</returns>
		public virtual unsafe global::System.Collections.Generic.ICollection<string> UntrackedFolders {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getUntrackedFolders' and count(parameter)=0]"
			[Register ("getUntrackedFolders", "()Ljava/util/Set;", "GetGetUntrackedFoldersHandler")]
			get {
				const string __id = "getUntrackedFolders.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_diff;
#pragma warning disable 0169
		static Delegate GetDiffHandler ()
		{
			if (cb_diff == null)
				cb_diff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Diff);
			return cb_diff;
		}

		static bool n_Diff (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Diff ();
		}
#pragma warning restore 0169

		/// <summary>Run the diff operation.</summary>
		/// <returns>if anything is different between index, tree, and workdir</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='diff' and count(parameter)=0]"
		[Register ("diff", "()Z", "GetDiffHandler")]
		public virtual unsafe bool Diff ()
		{
			const string __id = "diff.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_diff_Lorg_eclipse_jgit_lib_ProgressMonitor_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDiff_Lorg_eclipse_jgit_lib_ProgressMonitor_IILjava_lang_String_Handler ()
		{
			if (cb_diff_Lorg_eclipse_jgit_lib_ProgressMonitor_IILjava_lang_String_ == null)
				cb_diff_Lorg_eclipse_jgit_lib_ProgressMonitor_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_Z) n_Diff_Lorg_eclipse_jgit_lib_ProgressMonitor_IILjava_lang_String_);
			return cb_diff_Lorg_eclipse_jgit_lib_ProgressMonitor_IILjava_lang_String_;
		}

		static bool n_Diff_Lorg_eclipse_jgit_lib_ProgressMonitor_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor, int estWorkTreeSize, int estIndexSize, IntPtr native_title)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Diff (monitor, estWorkTreeSize, estIndexSize, title);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">for reporting progress, may be null</param>
		/// <param name="estWorkTreeSize">number or estimated files in the working tree</param>
		/// <param name="estIndexSize">number of estimated entries in the cache</param>
		/// <param name="title">title</param>
		/// <summary>Run the diff operation.</summary>
		/// <returns>if anything is different between index, tree, and workdir</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='diff' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("diff", "(Lorg/eclipse/jgit/lib/ProgressMonitor;IILjava/lang/String;)Z", "GetDiff_Lorg_eclipse_jgit_lib_ProgressMonitor_IILjava_lang_String_Handler")]
		public virtual unsafe bool Diff (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, int estWorkTreeSize, int estIndexSize, string title)
		{
			const string __id = "diff.(Lorg/eclipse/jgit/lib/ProgressMonitor;IILjava/lang/String;)Z";
			IntPtr native_title = JNIEnv.NewString ((string)title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [1] = new JniArgumentValue (estWorkTreeSize);
				__args [2] = new JniArgumentValue (estIndexSize);
				__args [3] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
				global::System.GC.KeepAlive (monitor);
			}
		}

		static Delegate cb_getIndexMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetIndexMode_Ljava_lang_String_Handler ()
		{
			if (cb_getIndexMode_Ljava_lang_String_ == null)
				cb_getIndexMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetIndexMode_Ljava_lang_String_);
			return cb_getIndexMode_Ljava_lang_String_;
		}

		static IntPtr n_GetIndexMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetIndexMode (path));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="path">path</param>
		/// <summary>Get the file mode of the given path in the index</summary>
		/// <returns>file mode</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getIndexMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getIndexMode", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/FileMode;", "GetGetIndexMode_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Lib.FileMode GetIndexMode (string path)
		{
			const string __id = "getIndexMode.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/FileMode;";
			IntPtr native_path = JNIEnv.NewString ((string)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_getPathsWithIndexMode_Lorg_eclipse_jgit_lib_FileMode_;
#pragma warning disable 0169
		static Delegate GetGetPathsWithIndexMode_Lorg_eclipse_jgit_lib_FileMode_Handler ()
		{
			if (cb_getPathsWithIndexMode_Lorg_eclipse_jgit_lib_FileMode_ == null)
				cb_getPathsWithIndexMode_Lorg_eclipse_jgit_lib_FileMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPathsWithIndexMode_Lorg_eclipse_jgit_lib_FileMode_);
			return cb_getPathsWithIndexMode_Lorg_eclipse_jgit_lib_FileMode_;
		}

		static IntPtr n_GetPathsWithIndexMode_Lorg_eclipse_jgit_lib_FileMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.FileMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetPathsWithIndexMode (mode));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="mode">mode</param>
		/// <summary>Get the list of paths that IndexDiff has detected to differ and have the
		/// given file mode</summary>
		/// <returns>the list of paths that IndexDiff has detected to differ and have
		///         the given file mode</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='getPathsWithIndexMode' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.FileMode']]"
		[Register ("getPathsWithIndexMode", "(Lorg/eclipse/jgit/lib/FileMode;)Ljava/util/Set;", "GetGetPathsWithIndexMode_Lorg_eclipse_jgit_lib_FileMode_Handler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> GetPathsWithIndexMode (global::Org.Eclipse.Jgit.Lib.FileMode mode)
		{
			const string __id = "getPathsWithIndexMode.(Lorg/eclipse/jgit/lib/FileMode;)Ljava/util/Set;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mode);
			}
		}

		static Delegate cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
#pragma warning disable 0169
		static Delegate GetSetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler ()
		{
			if (cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ == null)
				cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_);
			return cb_setFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
		}

		static void n_SetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.SetFilter (filter);
		}
#pragma warning restore 0169

		/// <param name="filter">filter</param>
		/// <summary>Sets a filter.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.filter.TreeFilter']]"
		[Register ("setFilter", "(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V", "GetSetFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler")]
		public virtual unsafe void SetFilter (global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter filter)
		{
			const string __id = "setFilter.(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (filter);
			}
		}

		static Delegate cb_setIgnoreSubmoduleMode_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_;
#pragma warning disable 0169
		static Delegate GetSetIgnoreSubmoduleMode_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_Handler ()
		{
			if (cb_setIgnoreSubmoduleMode_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_ == null)
				cb_setIgnoreSubmoduleMode_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIgnoreSubmoduleMode_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_);
			return cb_setIgnoreSubmoduleMode_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_;
		}

		static void n_SetIgnoreSubmoduleMode_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			__this.SetIgnoreSubmoduleMode (mode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='setIgnoreSubmoduleMode' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.submodule.SubmoduleWalk.IgnoreSubmoduleMode']]"
		[Register ("setIgnoreSubmoduleMode", "(Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;)V", "GetSetIgnoreSubmoduleMode_Lorg_eclipse_jgit_submodule_SubmoduleWalk_IgnoreSubmoduleMode_Handler")]
		public virtual unsafe void SetIgnoreSubmoduleMode (global::Org.Eclipse.Jgit.Submodule.SubmoduleWalk.IgnoreSubmoduleMode mode)
		{
			const string __id = "setIgnoreSubmoduleMode.(Lorg/eclipse/jgit/submodule/SubmoduleWalk$IgnoreSubmoduleMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mode);
			}
		}

		static Delegate cb_setWorkingTreeItFactory_Lorg_eclipse_jgit_lib_IndexDiff_WorkingTreeIteratorFactory_;
#pragma warning disable 0169
		static Delegate GetSetWorkingTreeItFactory_Lorg_eclipse_jgit_lib_IndexDiff_WorkingTreeIteratorFactory_Handler ()
		{
			if (cb_setWorkingTreeItFactory_Lorg_eclipse_jgit_lib_IndexDiff_WorkingTreeIteratorFactory_ == null)
				cb_setWorkingTreeItFactory_Lorg_eclipse_jgit_lib_IndexDiff_WorkingTreeIteratorFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetWorkingTreeItFactory_Lorg_eclipse_jgit_lib_IndexDiff_WorkingTreeIteratorFactory_);
			return cb_setWorkingTreeItFactory_Lorg_eclipse_jgit_lib_IndexDiff_WorkingTreeIteratorFactory_;
		}

		static void n_SetWorkingTreeItFactory_Lorg_eclipse_jgit_lib_IndexDiff_WorkingTreeIteratorFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_wTreeIt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var wTreeIt = (global::Org.Eclipse.Jgit.Lib.IndexDiff.IWorkingTreeIteratorFactory)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IndexDiff.IWorkingTreeIteratorFactory> (native_wTreeIt, JniHandleOwnership.DoNotTransfer);
			__this.SetWorkingTreeItFactory (wTreeIt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='IndexDiff']/method[@name='setWorkingTreeItFactory' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.IndexDiff.WorkingTreeIteratorFactory']]"
		[Register ("setWorkingTreeItFactory", "(Lorg/eclipse/jgit/lib/IndexDiff$WorkingTreeIteratorFactory;)V", "GetSetWorkingTreeItFactory_Lorg_eclipse_jgit_lib_IndexDiff_WorkingTreeIteratorFactory_Handler")]
		public virtual unsafe void SetWorkingTreeItFactory (global::Org.Eclipse.Jgit.Lib.IndexDiff.IWorkingTreeIteratorFactory wTreeIt)
		{
			const string __id = "setWorkingTreeItFactory.(Lorg/eclipse/jgit/lib/IndexDiff$WorkingTreeIteratorFactory;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((wTreeIt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wTreeIt).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (wTreeIt);
			}
		}

	}
}
