using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Api {

	/// <summary>Show changes between commits, commit and working tree, etc.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/api/DiffCommand", DoNotGenerateAcw=true)]
	public partial class DiffCommand : global::Org.Eclipse.Jgit.Api.GitCommand<global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry>> {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/api/DiffCommand", typeof (DiffCommand));

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

		protected DiffCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="repo">repo</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/constructor[@name='DiffCommand' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		protected unsafe DiffCommand (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		/// <summary>Executes the <c>Diff</c> command with all the options and parameters
		/// collected by the setter methods (e.</summary>
		/// <returns>a DiffEntry for each path which is different</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/util/List;", "GetCallHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Diff.DiffEntry> Call ()
		{
			const string __id = "call.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Diff.DiffEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCached_Z;
#pragma warning disable 0169
		static Delegate GetSetCached_ZHandler ()
		{
			if (cb_setCached_Z == null)
				cb_setCached_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCached_Z);
			return cb_setCached_Z;
		}

		static IntPtr n_SetCached_Z (IntPtr jnienv, IntPtr native__this, bool cached)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCached (cached));
		}
#pragma warning restore 0169

		/// <param name="cached">whether to view the changes you staged for the next commit</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setCached' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCached", "(Z)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetCached_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetCached (bool cached)
		{
			const string __id = "setCached.(Z)Lorg/eclipse/jgit/api/DiffCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cached);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setContextLines_I;
#pragma warning disable 0169
		static Delegate GetSetContextLines_IHandler ()
		{
			if (cb_setContextLines_I == null)
				cb_setContextLines_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetContextLines_I);
			return cb_setContextLines_I;
		}

		static IntPtr n_SetContextLines_I (IntPtr jnienv, IntPtr native__this, int contextLines)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetContextLines (contextLines));
		}
#pragma warning restore 0169

		/// <param name="contextLines">the number of context lines</param>
		/// <summary>Set number of context lines instead of the usual three.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setContextLines' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContextLines", "(I)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetContextLines_IHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetContextLines (int contextLines)
		{
			const string __id = "setContextLines.(I)Lorg/eclipse/jgit/api/DiffCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (contextLines);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDestinationPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDestinationPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setDestinationPrefix_Ljava_lang_String_ == null)
				cb_setDestinationPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDestinationPrefix_Ljava_lang_String_);
			return cb_setDestinationPrefix_Ljava_lang_String_;
		}

		static IntPtr n_SetDestinationPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_destinationPrefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var destinationPrefix = JNIEnv.GetString (native_destinationPrefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDestinationPrefix (destinationPrefix));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="destinationPrefix">the prefix</param>
		/// <summary>Set the given destination prefix instead of "b/".</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setDestinationPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDestinationPrefix", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetDestinationPrefix_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetDestinationPrefix (string destinationPrefix)
		{
			const string __id = "setDestinationPrefix.(Ljava/lang/String;)Lorg/eclipse/jgit/api/DiffCommand;";
			IntPtr native_destinationPrefix = JNIEnv.NewString ((string)destinationPrefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_destinationPrefix);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_destinationPrefix);
			}
		}

		static Delegate cb_setNewTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
#pragma warning disable 0169
		static Delegate GetSetNewTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler ()
		{
			if (cb_setNewTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ == null)
				cb_setNewTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetNewTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_);
			return cb_setNewTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
		}

		static IntPtr n_SetNewTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newTree)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newTree = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_newTree, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNewTree (newTree));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="newTree">the updated state</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setNewTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register ("setNewTree", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetNewTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetNewTree (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator newTree)
		{
			const string __id = "setNewTree.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Lorg/eclipse/jgit/api/DiffCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newTree).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (newTree);
			}
		}

		static Delegate cb_setOldTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
#pragma warning disable 0169
		static Delegate GetSetOldTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler ()
		{
			if (cb_setOldTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ == null)
				cb_setOldTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOldTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_);
			return cb_setOldTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_;
		}

		static IntPtr n_SetOldTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldTree)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oldTree = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator> (native_oldTree, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOldTree (oldTree));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="oldTree">the previous state</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setOldTree' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.AbstractTreeIterator']]"
		[Register ("setOldTree", "(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetOldTree_Lorg_eclipse_jgit_treewalk_AbstractTreeIterator_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetOldTree (global::Org.Eclipse.Jgit.Treewalk.AbstractTreeIterator oldTree)
		{
			const string __id = "setOldTree.(Lorg/eclipse/jgit/treewalk/AbstractTreeIterator;)Lorg/eclipse/jgit/api/DiffCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((oldTree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldTree).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (oldTree);
			}
		}

		static Delegate cb_setOutputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetSetOutputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_setOutputStream_Ljava_io_OutputStream_ == null)
				cb_setOutputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOutputStream_Ljava_io_OutputStream_);
			return cb_setOutputStream_Ljava_io_OutputStream_;
		}

		static IntPtr n_SetOutputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOutputStream (@out));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="out">the stream to write line data</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("setOutputStream", "(Ljava/io/OutputStream;)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetOutputStream_Ljava_io_OutputStream_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetOutputStream (global::System.IO.Stream @out)
		{
			const string __id = "setOutputStream.(Ljava/io/OutputStream;)Lorg/eclipse/jgit/api/DiffCommand;";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_setPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
#pragma warning disable 0169
		static Delegate GetSetPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler ()
		{
			if (cb_setPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ == null)
				cb_setPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_);
			return cb_setPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_;
		}

		static IntPtr n_SetPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pathFilter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pathFilter = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter> (native_pathFilter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPathFilter (pathFilter));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="pathFilter">parameter, used to limit the diff to the named path</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setPathFilter' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.treewalk.filter.TreeFilter']]"
		[Register ("setPathFilter", "(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetPathFilter_Lorg_eclipse_jgit_treewalk_filter_TreeFilter_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetPathFilter (global::Org.Eclipse.Jgit.Treewalk.Filter.TreeFilter pathFilter)
		{
			const string __id = "setPathFilter.(Lorg/eclipse/jgit/treewalk/filter/TreeFilter;)Lorg/eclipse/jgit/api/DiffCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pathFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pathFilter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (pathFilter);
			}
		}

		static Delegate cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler ()
		{
			if (cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ == null)
				cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_);
			return cb_setProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_;
		}

		static IntPtr n_SetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_monitor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var monitor = (global::Org.Eclipse.Jgit.Lib.IProgressMonitor)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IProgressMonitor> (native_monitor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressMonitor (monitor));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="monitor">a progress monitor</param>
		/// <summary>The progress monitor associated with the diff operation.</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setProgressMonitor' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ProgressMonitor']]"
		[Register ("setProgressMonitor", "(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetProgressMonitor_Lorg_eclipse_jgit_lib_ProgressMonitor_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetProgressMonitor (global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor)
		{
			const string __id = "setProgressMonitor.(Lorg/eclipse/jgit/lib/ProgressMonitor;)Lorg/eclipse/jgit/api/DiffCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (monitor);
			}
		}

		static Delegate cb_setShowNameAndStatusOnly_Z;
#pragma warning disable 0169
		static Delegate GetSetShowNameAndStatusOnly_ZHandler ()
		{
			if (cb_setShowNameAndStatusOnly_Z == null)
				cb_setShowNameAndStatusOnly_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetShowNameAndStatusOnly_Z);
			return cb_setShowNameAndStatusOnly_Z;
		}

		static IntPtr n_SetShowNameAndStatusOnly_Z (IntPtr jnienv, IntPtr native__this, bool showNameAndStatusOnly)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShowNameAndStatusOnly (showNameAndStatusOnly));
		}
#pragma warning restore 0169

		/// <param name="showNameAndStatusOnly">whether to return only names and status of changed files</param>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setShowNameAndStatusOnly' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowNameAndStatusOnly", "(Z)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetShowNameAndStatusOnly_ZHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetShowNameAndStatusOnly (bool showNameAndStatusOnly)
		{
			const string __id = "setShowNameAndStatusOnly.(Z)Lorg/eclipse/jgit/api/DiffCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showNameAndStatusOnly);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSourcePrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSourcePrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setSourcePrefix_Ljava_lang_String_ == null)
				cb_setSourcePrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSourcePrefix_Ljava_lang_String_);
			return cb_setSourcePrefix_Ljava_lang_String_;
		}

		static IntPtr n_SetSourcePrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourcePrefix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sourcePrefix = JNIEnv.GetString (native_sourcePrefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSourcePrefix (sourcePrefix));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="sourcePrefix">the prefix</param>
		/// <summary>Set the given source prefix instead of "a/".</summary>
		/// <returns>this instance</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.api']/class[@name='DiffCommand']/method[@name='setSourcePrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSourcePrefix", "(Ljava/lang/String;)Lorg/eclipse/jgit/api/DiffCommand;", "GetSetSourcePrefix_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Api.DiffCommand SetSourcePrefix (string sourcePrefix)
		{
			const string __id = "setSourcePrefix.(Ljava/lang/String;)Lorg/eclipse/jgit/api/DiffCommand;";
			IntPtr native_sourcePrefix = JNIEnv.NewString ((string)sourcePrefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sourcePrefix);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Api.DiffCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourcePrefix);
			}
		}

	}
}
