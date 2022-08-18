using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Merge {

	/// <summary>A merge strategy to merge 2 trees, using a common base ancestor tree.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMergeStrategy']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/ThreeWayMergeStrategy", DoNotGenerateAcw=true)]
	public abstract partial class ThreeWayMergeStrategy : global::Org.Eclipse.Jgit.Merge.MergeStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/ThreeWayMergeStrategy", typeof (ThreeWayMergeStrategy));

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

		protected ThreeWayMergeStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMergeStrategy']/constructor[@name='ThreeWayMergeStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreeWayMergeStrategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMergeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var db = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_db, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMerger (db));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMergeStrategy']/method[@name='newMerger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("newMerger", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/merge/ThreeWayMerger;", "GetNewMerger_Lorg_eclipse_jgit_lib_Repository_Handler")]
		public new virtual global::Org.Eclipse.Jgit.Merge.ThreeWayMerger NewMerger (global::Org.Eclipse.Jgit.Lib.Repository db)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMergeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var db = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.Repository> (native_db, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMerger (db, inCore));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMergeStrategy']/method[@name='newMerger' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='boolean']]"
		[Register ("newMerger", "(Lorg/eclipse/jgit/lib/Repository;Z)Lorg/eclipse/jgit/merge/ThreeWayMerger;", "GetNewMerger_Lorg_eclipse_jgit_lib_Repository_ZHandler")]
		public new virtual global::Org.Eclipse.Jgit.Merge.ThreeWayMerger NewMerger (global::Org.Eclipse.Jgit.Lib.Repository db, bool inCore)
		{
			throw new NotImplementedException();
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/merge/ThreeWayMergeStrategy", DoNotGenerateAcw=true)]
	internal partial class ThreeWayMergeStrategyInvoker : ThreeWayMergeStrategy {
		public ThreeWayMergeStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/merge/ThreeWayMergeStrategy", typeof (ThreeWayMergeStrategyInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMergeStrategy']/method[@name='newMerger' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register ("newMerger", "(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/merge/ThreeWayMerger;", "GetNewMerger_Lorg_eclipse_jgit_lib_Repository_Handler")]
		public override unsafe global::Org.Eclipse.Jgit.Merge.ThreeWayMerger NewMerger (global::Org.Eclipse.Jgit.Lib.Repository db)
		{
			const string __id = "newMerger.(Lorg/eclipse/jgit/lib/Repository;)Lorg/eclipse/jgit/merge/ThreeWayMerger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMerger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.merge']/class[@name='ThreeWayMergeStrategy']/method[@name='newMerger' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='boolean']]"
		[Register ("newMerger", "(Lorg/eclipse/jgit/lib/Repository;Z)Lorg/eclipse/jgit/merge/ThreeWayMerger;", "GetNewMerger_Lorg_eclipse_jgit_lib_Repository_ZHandler")]
		public override unsafe global::Org.Eclipse.Jgit.Merge.ThreeWayMerger NewMerger (global::Org.Eclipse.Jgit.Lib.Repository db, bool inCore)
		{
			const string __id = "newMerger.(Lorg/eclipse/jgit/lib/Repository;Z)Lorg/eclipse/jgit/merge/ThreeWayMerger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				__args [1] = new JniArgumentValue (inCore);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Merge.ThreeWayMerger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (db);
			}
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
		/*
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
		*/
	}
}
