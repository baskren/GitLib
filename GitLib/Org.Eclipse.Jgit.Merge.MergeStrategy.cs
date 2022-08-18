using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>A method of combining two or more trees together to form an output tree.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/MergeStrategy", DoNotGenerateAcw=true)]
	public abstract partial class MergeStrategy : global::Java.Lang.Object {

		/// <summary>Simple strategy that sets the output tree to the first input tree.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/field[@name='OURS']"
		[Register ("OURS")]
		public static global::Org.Eclipse.Jgit.Merge.MergeStrategy Ours {
			get {
				const string __id = "OURS.Lorg/eclipse/jgit/merge/MergeStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Recursive strategy to merge paths.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/field[@name='RECURSIVE']"
		[Register ("RECURSIVE")]
		public static global::Org.Eclipse.Jgit.Merge.ThreeWayMergeStrategy Recursive {
			get {
				const string __id = "RECURSIVE.Lorg/eclipse/jgit/merge/ThreeWayMergeStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMergeStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Simple strategy to merge paths.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/field[@name='RESOLVE']"
		[Register ("RESOLVE")]
		public static global::Org.Eclipse.Jgit.Merge.ThreeWayMergeStrategy Resolve {
			get {
				const string __id = "RESOLVE.Lorg/eclipse/jgit/merge/ThreeWayMergeStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMergeStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Simple strategy to merge paths, without simultaneous edits.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/field[@name='SIMPLE_TWO_WAY_IN_CORE']"
		[Register ("SIMPLE_TWO_WAY_IN_CORE")]
		public static global::Org.Eclipse.Jgit.Merge.ThreeWayMergeStrategy SimpleTwoWayInCore {
			get {
				const string __id = "SIMPLE_TWO_WAY_IN_CORE.Lorg/eclipse/jgit/merge/ThreeWayMergeStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMergeStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		/// <summary>Simple strategy that sets the output tree to the second input tree.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/field[@name='THEIRS']"
		[Register ("THEIRS")]
		public static global::Org.Eclipse.Jgit.Merge.MergeStrategy Theirs {
			get {
				const string __id = "THEIRS.Lorg/eclipse/jgit/merge/MergeStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/MergeStrategy", typeof (MergeStrategy));

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

		protected MergeStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/constructor[@name='MergeStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MergeStrategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get; 
		}

		/// <summary>Get all registered strategies.</summary>
		/// <returns>the registered strategy instances. No inherit order is returned;
		///         the caller may modify (and/or sort) the returned array if
		///         necessary to obtain a reasonable ordering.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()[Lorg/eclipse/jgit/merge/MergeStrategy;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Merge.MergeStrategy[] Get ()
		{
			const string __id = "get.()[Lorg/eclipse/jgit/merge/MergeStrategy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Eclipse.Jgit.Merge.MergeStrategy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Merge.MergeStrategy));
			} finally {
			}
		}

		/// <param name="name">name of the strategy to locate.</param>
		/// <summary>Locate a strategy by name.</summary>
		/// <returns>the strategy instance; null if no strategy matches the name.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lorg/eclipse/jgit/merge/MergeStrategy;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Merge.MergeStrategy Get (string name)
		{
			const string __id = "get.(Ljava/lang/String;)Lorg/eclipse/jgit/merge/MergeStrategy;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_newMerger_Lorg_eclipse_jgit_lib_Repository_;
#pragma warning disable 0169
		static Delegate GetNewMerger_Lorg_eclipse_jgit_lib_Repository_Handler ()
		{
			if (cb_newMerger_Lorg_eclipse_jgit_lib_Repository_ == null)
				cb_newMerger_Lorg_eclipse_jgit_lib_Repository_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewMerger_Lorg_eclipse_jgit_lib_Repository_);
			return cb_newMerger_Lorg_eclipse_jgit_lib_Repository_;
		}

		static IntPtr n_NewMerger_Lorg_eclipse_jgit_lib_Repository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_db)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var db = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_db, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMerger (db));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="db">repository database the merger will read from, and eventually
		///            write results back to.</param>
		/// <summary>Create a new merge instance.</summary>
		/// <returns>the new merge instance which implements this strategy.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='newMerger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register("newMerger", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/merge/Merger;", "GetNewMerger_Lorg_eclipse_jgit_lib_Repository_Handler")]
		public virtual global::Org.Eclipse.Jgit.Merge.Merger NewMerger(global::Org.Eclipse.Jgit.Lib.Repository db)
		{
			throw new NotImplementedException();
		}

		static Delegate cb_newMerger_Lorg_eclipse_jgit_lib_Repository_Z;
#pragma warning disable 0169
		static Delegate GetNewMerger_Lorg_eclipse_jgit_lib_Repository_ZHandler ()
		{
			if (cb_newMerger_Lorg_eclipse_jgit_lib_Repository_Z == null)
				cb_newMerger_Lorg_eclipse_jgit_lib_Repository_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_NewMerger_Lorg_eclipse_jgit_lib_Repository_Z);
			return cb_newMerger_Lorg_eclipse_jgit_lib_Repository_Z;
		}

		static IntPtr n_NewMerger_Lorg_eclipse_jgit_lib_Repository_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_db, bool inCore)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.MergeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var db = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_db, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMerger (db, inCore));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="db">repository database the merger will read from, and eventually
		///            write results back to.</param>
		/// <param name="inCore">the merge will happen in memory, working folder will not be
		///            modified, in case of a non-trivial merge that requires manual
		///            resolution, the merger will fail.</param>
		/// <summary>Create a new merge instance.</summary>
		/// <returns>the new merge instance which implements this strategy.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='newMerger' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='boolean']]"
		[Register ("newMerger", "(Lorg/eclipse/jgit/lib/Repository;Z)Lorg/eclipse/jgit/merge/Merger;", "GetNewMerger_Lorg_eclipse_jgit_lib_Repository_ZHandler")]
		public virtual global::Org.Eclipse.Jgit.Merge.Merger NewMerger (global::Org.Eclipse.Jgit.Lib.Repository db, bool inCore)
		{
			throw new NotImplementedException();
		}

		/// <param name="name">name the strategy can be looked up under.</param>
		/// <param name="imp">the strategy to register.</param>
		/// <summary>Register a merge strategy so it can later be obtained by name.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='register' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.jgit.merge.MergeStrategy']]"
		[Register ("register", "(Ljava/lang/String;Lorg/eclipse/jgit/merge/MergeStrategy;)V", "")]
		public static unsafe void Register (string name, global::Org.Eclipse.Jgit.Merge.MergeStrategy imp)
		{
			const string __id = "register.(Ljava/lang/String;Lorg/eclipse/jgit/merge/MergeStrategy;)V";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((imp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imp).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (imp);
			}
		}

		/// <param name="imp">the strategy to register.</param>
		/// <summary>Register a merge strategy so it can later be obtained by name.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='register' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.merge.MergeStrategy']]"
		[Register ("register", "(Lorg/eclipse/jgit/merge/MergeStrategy;)V", "")]
		public static unsafe void Register (global::Org.Eclipse.Jgit.Merge.MergeStrategy imp)
		{
			const string __id = "register.(Lorg/eclipse/jgit/merge/MergeStrategy;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imp).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (imp);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/MergeStrategy", DoNotGenerateAcw=true)]
	internal partial class MergeStrategyInvoker : MergeStrategy {
		public MergeStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/MergeStrategy", typeof (MergeStrategyInvoker));

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

		/// <returns>default name of this strategy implementation.</returns>
		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		/// <param name="db">repository database the merger will read from, and eventually
		///            write results back to.</param>
		/// <summary>Create a new merge instance.</summary>
		/// <returns>the new merge instance which implements this strategy.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='newMerger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("newMerger", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/merge/Merger;", "GetNewMerger_Lorg_eclipse_jgit_lib_Repository_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Merge.Merger NewMerger (global::Org.Eclipse.Jgit.Lib.Repository db)
		{
			const string __id = "newMerger.(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/merge/Merger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

		/// <param name="db">repository database the merger will read from, and eventually
		///            write results back to.</param>
		/// <param name="inCore">the merge will happen in memory, working folder will not be
		///            modified, in case of a non-trivial merge that requires manual
		///            resolution, the merger will fail.</param>
		/// <summary>Create a new merge instance.</summary>
		/// <returns>the new merge instance which implements this strategy.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='MergeStrategy']/method[@name='newMerger' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='boolean']]"
		[Register ("newMerger", "(Lorg/eclipse/jgit/lib/Repository;Z)Lorg/eclipse/jgit/merge/Merger;", "GetNewMerger_Lorg_eclipse_jgit_lib_Repository_ZHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Merge.Merger NewMerger (global::Org.Eclipse.Jgit.Lib.Repository db, bool inCore)
		{
			const string __id = "newMerger.(Lorg/eclipse/jgit/lib/Repository;Z)Lorg/eclipse/jgit/merge/Merger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue (inCore);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.Merger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

	}
}
