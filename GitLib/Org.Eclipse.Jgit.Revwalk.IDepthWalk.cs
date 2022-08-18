using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>RevCommit with a depth (in commits) from a root.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.Commit']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/DepthWalk$Commit", DoNotGenerateAcw=true)]
	public partial class DepthWalkCommit : global::Org.Eclipse.Jgit.Revwalk.RevCommit {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/DepthWalk$Commit", typeof (DepthWalkCommit));

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

		protected DepthWalkCommit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="id">object name for the commit.</param>
		/// <summary>Initialize a new commit.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.Commit']/constructor[@name='DepthWalk.Commit' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/AnyObjectId;)V", "")]
		protected unsafe DepthWalkCommit (global::Org.Eclipse.Jgit.Lib.AnyObjectId id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/AnyObjectId;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_getDepth;
#pragma warning disable 0169
		static Delegate GetGetDepthHandler ()
		{
			if (cb_getDepth == null)
				cb_getDepth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDepth);
			return cb_getDepth;
		}

		static int n_GetDepth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkCommit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Depth;
		}
#pragma warning restore 0169

		/// <returns>depth of this commit, as found by the shortest path.</returns>
		public virtual unsafe int Depth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.Commit']/method[@name='getDepth' and count(parameter)=0]"
			[Register ("getDepth", "()I", "GetGetDepthHandler")]
			get {
				const string __id = "getDepth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

	/// <summary>Subclass of ObjectWalk that performs depth filtering.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.ObjectWalk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/DepthWalk$ObjectWalk", DoNotGenerateAcw=true)]
	public partial class DepthWalkObjectWalk : global::Org.Eclipse.Jgit.Revwalk.ObjectWalk, global::Org.Eclipse.Jgit.Revwalk.IDepthWalk {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/DepthWalk$ObjectWalk", typeof (DepthWalkObjectWalk));

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

		protected DepthWalkObjectWalk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="or">Object Reader</param>
		/// <param name="depth">Maximum depth to return</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.ObjectWalk']/constructor[@name='DepthWalk.ObjectWalk' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectReader;I)V", "")]
		public unsafe DepthWalkObjectWalk (global::Org.Eclipse.Jgit.Lib.ObjectReader or, int depth) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectReader;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((or == null) ? IntPtr.Zero : ((global::Java.Lang.Object) or).Handle);
				__args [1] = new JniArgumentValue (depth);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (or);
			}
		}

		/// <param name="repo">Repository to walk</param>
		/// <param name="depth">Maximum depth to return</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.ObjectWalk']/constructor[@name='DepthWalk.ObjectWalk' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;I)V", "")]
		public unsafe DepthWalkObjectWalk (global::Org.Eclipse.Jgit.Lib.Repository repo, int depth) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue (depth);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_getDepth;
#pragma warning disable 0169
		static Delegate GetGetDepthHandler ()
		{
			if (cb_getDepth == null)
				cb_getDepth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDepth);
			return cb_getDepth;
		}

		static int n_GetDepth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Depth;
		}
#pragma warning restore 0169

		public virtual unsafe int Depth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.ObjectWalk']/method[@name='getDepth' and count(parameter)=0]"
			[Register ("getDepth", "()I", "GetGetDepthHandler")]
			get {
				const string __id = "getDepth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getReinterestingFlag;
#pragma warning disable 0169
		static Delegate GetGetReinterestingFlagHandler ()
		{
			if (cb_getReinterestingFlag == null)
				cb_getReinterestingFlag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReinterestingFlag);
			return cb_getReinterestingFlag;
		}

		static IntPtr n_GetReinterestingFlag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReinterestingFlag);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevFlag ReinterestingFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.ObjectWalk']/method[@name='getReinterestingFlag' and count(parameter)=0]"
			[Register ("getReinterestingFlag", "()Lorg/eclipse/jgit/revwalk/RevFlag;", "GetGetReinterestingFlagHandler")]
			get {
				const string __id = "getReinterestingFlag.()Lorg/eclipse/jgit/revwalk/RevFlag;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnshallowFlag;
#pragma warning disable 0169
		static Delegate GetGetUnshallowFlagHandler ()
		{
			if (cb_getUnshallowFlag == null)
				cb_getUnshallowFlag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUnshallowFlag);
			return cb_getUnshallowFlag;
		}

		static IntPtr n_GetUnshallowFlag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnshallowFlag);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevFlag UnshallowFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.ObjectWalk']/method[@name='getUnshallowFlag' and count(parameter)=0]"
			[Register ("getUnshallowFlag", "()Lorg/eclipse/jgit/revwalk/RevFlag;", "GetGetUnshallowFlagHandler")]
			get {
				const string __id = "getUnshallowFlag.()Lorg/eclipse/jgit/revwalk/RevFlag;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_markRoot_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetMarkRoot_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_markRoot_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_markRoot_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_MarkRoot_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_markRoot_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static void n_MarkRoot_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_o, JniHandleOwnership.DoNotTransfer);
			__this.MarkRoot (o);
		}
#pragma warning restore 0169

		/// <param name="o">Commit to mark</param>
		/// <summary>Mark a root commit (i.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.ObjectWalk']/method[@name='markRoot' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("markRoot", "(Lorg/eclipse/jgit/revwalk/RevObject;)V", "GetMarkRoot_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe void MarkRoot (global::Org.Eclipse.Jgit.Revwalk.RevObject o)
		{
			const string __id = "markRoot.(Lorg/eclipse/jgit/revwalk/RevObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		static Delegate cb_markUnshallow_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetMarkUnshallow_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_markUnshallow_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_markUnshallow_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_MarkUnshallow_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_markUnshallow_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static void n_MarkUnshallow_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.MarkUnshallow (c);
		}
#pragma warning restore 0169

		/// <param name="c">Commit to mark</param>
		/// <summary>Mark an element which used to be shallow in the client, but which
		/// should now be considered a full commit.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.ObjectWalk']/method[@name='markUnshallow' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("markUnshallow", "(Lorg/eclipse/jgit/revwalk/RevObject;)V", "GetMarkUnshallow_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe void MarkUnshallow (global::Org.Eclipse.Jgit.Revwalk.RevObject c)
		{
			const string __id = "markUnshallow.(Lorg/eclipse/jgit/revwalk/RevObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

	}

	/// <summary>Subclass of RevWalk that performs depth filtering.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.RevWalk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/DepthWalk$RevWalk", DoNotGenerateAcw=true)]
	public partial class DepthWalkRevWalk : global::Org.Eclipse.Jgit.Revwalk.RevWalk, global::Org.Eclipse.Jgit.Revwalk.IDepthWalk {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/DepthWalk$RevWalk", typeof (DepthWalkRevWalk));

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

		protected DepthWalkRevWalk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="or">ObjectReader to use</param>
		/// <param name="depth">Maximum depth to return</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.RevWalk']/constructor[@name='DepthWalk.RevWalk' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectReader;I)V", "")]
		public unsafe DepthWalkRevWalk (global::Org.Eclipse.Jgit.Lib.ObjectReader or, int depth) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectReader;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((or == null) ? IntPtr.Zero : ((global::Java.Lang.Object) or).Handle);
				__args [1] = new JniArgumentValue (depth);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (or);
			}
		}

		/// <param name="repo">Repository to walk</param>
		/// <param name="depth">Maximum depth to return</param>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.RevWalk']/constructor[@name='DepthWalk.RevWalk' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.Repository'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;I)V", "")]
		public unsafe DepthWalkRevWalk (global::Org.Eclipse.Jgit.Lib.Repository repo, int depth) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/Repository;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((repo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repo).Handle);
				__args [1] = new JniArgumentValue (depth);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (repo);
			}
		}

		static Delegate cb_getDepth;
#pragma warning disable 0169
		static Delegate GetGetDepthHandler ()
		{
			if (cb_getDepth == null)
				cb_getDepth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDepth);
			return cb_getDepth;
		}

		static int n_GetDepth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkRevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Depth;
		}
#pragma warning restore 0169

		public virtual unsafe int Depth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.RevWalk']/method[@name='getDepth' and count(parameter)=0]"
			[Register ("getDepth", "()I", "GetGetDepthHandler")]
			get {
				const string __id = "getDepth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getReinterestingFlag;
#pragma warning disable 0169
		static Delegate GetGetReinterestingFlagHandler ()
		{
			if (cb_getReinterestingFlag == null)
				cb_getReinterestingFlag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReinterestingFlag);
			return cb_getReinterestingFlag;
		}

		static IntPtr n_GetReinterestingFlag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkRevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReinterestingFlag);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevFlag ReinterestingFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.RevWalk']/method[@name='getReinterestingFlag' and count(parameter)=0]"
			[Register ("getReinterestingFlag", "()Lorg/eclipse/jgit/revwalk/RevFlag;", "GetGetReinterestingFlagHandler")]
			get {
				const string __id = "getReinterestingFlag.()Lorg/eclipse/jgit/revwalk/RevFlag;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnshallowFlag;
#pragma warning disable 0169
		static Delegate GetGetUnshallowFlagHandler ()
		{
			if (cb_getUnshallowFlag == null)
				cb_getUnshallowFlag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUnshallowFlag);
			return cb_getUnshallowFlag;
		}

		static IntPtr n_GetUnshallowFlag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkRevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnshallowFlag);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevFlag UnshallowFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.RevWalk']/method[@name='getUnshallowFlag' and count(parameter)=0]"
			[Register ("getUnshallowFlag", "()Lorg/eclipse/jgit/revwalk/RevFlag;", "GetGetUnshallowFlagHandler")]
			get {
				const string __id = "getUnshallowFlag.()Lorg/eclipse/jgit/revwalk/RevFlag;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_markRoot_Lorg_eclipse_jgit_revwalk_RevCommit_;
#pragma warning disable 0169
		static Delegate GetMarkRoot_Lorg_eclipse_jgit_revwalk_RevCommit_Handler ()
		{
			if (cb_markRoot_Lorg_eclipse_jgit_revwalk_RevCommit_ == null)
				cb_markRoot_Lorg_eclipse_jgit_revwalk_RevCommit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_MarkRoot_Lorg_eclipse_jgit_revwalk_RevCommit_);
			return cb_markRoot_Lorg_eclipse_jgit_revwalk_RevCommit_;
		}

		static void n_MarkRoot_Lorg_eclipse_jgit_revwalk_RevCommit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.DepthWalkRevWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevCommit> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.MarkRoot (c);
		}
#pragma warning restore 0169

		/// <param name="c">Commit to mark</param>
		/// <summary>Mark a root commit (i.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='DepthWalk.RevWalk']/method[@name='markRoot' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevCommit']]"
		[Register ("markRoot", "(Lorg/eclipse/jgit/revwalk/RevCommit;)V", "GetMarkRoot_Lorg_eclipse_jgit_revwalk_RevCommit_Handler")]
		public virtual unsafe void MarkRoot (global::Org.Eclipse.Jgit.Revwalk.RevCommit c)
		{
			const string __id = "markRoot.(Lorg/eclipse/jgit/revwalk/RevCommit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

	}

	/// <summary>Interface for revision walkers that perform depth filtering.</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/interface[@name='DepthWalk']"
	[Register ("org/eclipse/jgit/revwalk/DepthWalk", "", "Org.Eclipse.Jgit.Revwalk.IDepthWalkInvoker")]
	public partial interface IDepthWalk : IJavaObject, IJavaPeerable {
		int Depth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/interface[@name='DepthWalk']/method[@name='getDepth' and count(parameter)=0]"
			[Register ("getDepth", "()I", "GetGetDepthHandler:Org.Eclipse.Jgit.Revwalk.IDepthWalkInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Revwalk.RevFlag ReinterestingFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/interface[@name='DepthWalk']/method[@name='getReinterestingFlag' and count(parameter)=0]"
			[Register ("getReinterestingFlag", "()Lorg/eclipse/jgit/revwalk/RevFlag;", "GetGetReinterestingFlagHandler:Org.Eclipse.Jgit.Revwalk.IDepthWalkInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::Org.Eclipse.Jgit.Revwalk.RevFlag UnshallowFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/interface[@name='DepthWalk']/method[@name='getUnshallowFlag' and count(parameter)=0]"
			[Register ("getUnshallowFlag", "()Lorg/eclipse/jgit/revwalk/RevFlag;", "GetGetUnshallowFlagHandler:Org.Eclipse.Jgit.Revwalk.IDepthWalkInvoker, AndroidBindableLibrary")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/DepthWalk", DoNotGenerateAcw=true)]
	internal partial class IDepthWalkInvoker : global::Java.Lang.Object, IDepthWalk {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/DepthWalk", typeof (IDepthWalkInvoker));

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

		public static IDepthWalk GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDepthWalk> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.revwalk.DepthWalk'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDepthWalkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDepth;
#pragma warning disable 0169
		static Delegate GetGetDepthHandler ()
		{
			if (cb_getDepth == null)
				cb_getDepth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDepth);
			return cb_getDepth;
		}

		static int n_GetDepth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.IDepthWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Depth;
		}
#pragma warning restore 0169

		IntPtr id_getDepth;
		public unsafe int Depth {
			get {
				if (id_getDepth == IntPtr.Zero)
					id_getDepth = JNIEnv.GetMethodID (class_ref, "getDepth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDepth);
			}
		}

		static Delegate cb_getReinterestingFlag;
#pragma warning disable 0169
		static Delegate GetGetReinterestingFlagHandler ()
		{
			if (cb_getReinterestingFlag == null)
				cb_getReinterestingFlag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReinterestingFlag);
			return cb_getReinterestingFlag;
		}

		static IntPtr n_GetReinterestingFlag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.IDepthWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReinterestingFlag);
		}
#pragma warning restore 0169

		IntPtr id_getReinterestingFlag;
		public unsafe global::Org.Eclipse.Jgit.Revwalk.RevFlag ReinterestingFlag {
			get {
				if (id_getReinterestingFlag == IntPtr.Zero)
					id_getReinterestingFlag = JNIEnv.GetMethodID (class_ref, "getReinterestingFlag", "()Lorg/eclipse/jgit/revwalk/RevFlag;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReinterestingFlag), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUnshallowFlag;
#pragma warning disable 0169
		static Delegate GetGetUnshallowFlagHandler ()
		{
			if (cb_getUnshallowFlag == null)
				cb_getUnshallowFlag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUnshallowFlag);
			return cb_getUnshallowFlag;
		}

		static IntPtr n_GetUnshallowFlag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.IDepthWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnshallowFlag);
		}
#pragma warning restore 0169

		IntPtr id_getUnshallowFlag;
		public unsafe global::Org.Eclipse.Jgit.Revwalk.RevFlag UnshallowFlag {
			get {
				if (id_getUnshallowFlag == IntPtr.Zero)
					id_getUnshallowFlag = JNIEnv.GetMethodID (class_ref, "getUnshallowFlag", "()Lorg/eclipse/jgit/revwalk/RevFlag;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevFlag> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnshallowFlag), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
