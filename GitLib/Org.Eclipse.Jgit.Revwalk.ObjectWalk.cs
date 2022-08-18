using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revwalk {

	/// <summary>Specialized subclass of RevWalk to include trees, blobs and tags.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revwalk/ObjectWalk", DoNotGenerateAcw=true)]
	public partial class ObjectWalk : global::Org.Eclipse.Jgit.Revwalk.RevWalk {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revwalk/ObjectWalk", typeof (ObjectWalk));

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

		protected ObjectWalk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="or">the reader the walker will obtain data from. The reader should
		///            be released by the caller when the walker is no longer
		///            required.</param>
		/// <summary>Create a new revision and object walker for a given repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/constructor[@name='ObjectWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.ObjectReader']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/ObjectReader;)V", "")]
		public unsafe ObjectWalk (global::Org.Eclipse.Jgit.Lib.ObjectReader or) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/jgit/lib/ObjectReader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((or == null) ? IntPtr.Zero : ((global::Java.Lang.Object) or).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (or);
			}
		}

		/// <param name="repo">the repository the walker will obtain data from.</param>
		/// <summary>Create a new revision and object walker for a given repository.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/constructor[@name='ObjectWalk' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.Repository']]"
		[Register (".ctor", "(Lorg/eclipse/jgit/lib/Repository;)V", "")]
		public unsafe ObjectWalk (global::Org.Eclipse.Jgit.Lib.Repository repo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getPathHashCode;
#pragma warning disable 0169
		static Delegate GetGetPathHashCodeHandler ()
		{
			if (cb_getPathHashCode == null)
				cb_getPathHashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPathHashCode);
			return cb_getPathHashCode;
		}

		static int n_GetPathHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PathHashCode;
		}
#pragma warning restore 0169

		/// <summary>Get the current object's path hash code.</summary>
		/// <returns>path hash code; any integer may be returned.</returns>
		public virtual unsafe int PathHashCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/method[@name='getPathHashCode' and count(parameter)=0]"
			[Register ("getPathHashCode", "()I", "GetGetPathHashCodeHandler")]
			get {
				const string __id = "getPathHashCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPathLength;
#pragma warning disable 0169
		static Delegate GetGetPathLengthHandler ()
		{
			if (cb_getPathLength == null)
				cb_getPathLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPathLength);
			return cb_getPathLength;
		}

		static int n_GetPathLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PathLength;
		}
#pragma warning restore 0169

		/// <returns>length of the path in <c>#getPathBuffer()</c>.</returns>
		public virtual unsafe int PathLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/method[@name='getPathLength' and count(parameter)=0]"
			[Register ("getPathLength", "()I", "GetGetPathLengthHandler")]
			get {
				const string __id = "getPathLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPathString;
#pragma warning disable 0169
		static Delegate GetGetPathStringHandler ()
		{
			if (cb_getPathString == null)
				cb_getPathString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPathString);
			return cb_getPathString;
		}

		static IntPtr n_GetPathString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PathString);
		}
#pragma warning restore 0169

		/// <summary>Get the current object's complete path.</summary>
		/// <returns>complete path of the current entry, from the root of the
		///         repository. If the current entry is in a subtree there will be at
		///         least one '/' in the returned string. Null if the current entry
		///         has no path, such as for annotated tags or root level trees.</returns>
		public virtual unsafe string PathString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/method[@name='getPathString' and count(parameter)=0]"
			[Register ("getPathString", "()Ljava/lang/String;", "GetGetPathStringHandler")]
			get {
				const string __id = "getPathString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkConnectivity;
#pragma warning disable 0169
		static Delegate GetCheckConnectivityHandler ()
		{
			if (cb_checkConnectivity == null)
				cb_checkConnectivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CheckConnectivity);
			return cb_checkConnectivity;
		}

		static void n_CheckConnectivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckConnectivity ();
		}
#pragma warning restore 0169

		/// <summary>Verify all interesting objects are available, and reachable.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/method[@name='checkConnectivity' and count(parameter)=0]"
		[Register ("checkConnectivity", "()V", "GetCheckConnectivityHandler")]
		public virtual unsafe void CheckConnectivity ()
		{
			const string __id = "checkConnectivity.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getPathBuffer;
#pragma warning disable 0169
		static Delegate GetGetPathBufferHandler ()
		{
			if (cb_getPathBuffer == null)
				cb_getPathBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPathBuffer);
			return cb_getPathBuffer;
		}

		static IntPtr n_GetPathBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPathBuffer ());
		}
#pragma warning restore 0169

		/// <returns>the internal buffer holding the current path.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/method[@name='getPathBuffer' and count(parameter)=0]"
		[Register ("getPathBuffer", "()[B", "GetGetPathBufferHandler")]
		public virtual unsafe byte[] GetPathBuffer ()
		{
			const string __id = "getPathBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_markStart_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetMarkStart_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_markStart_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_markStart_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_MarkStart_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_markStart_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static void n_MarkStart_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_o, JniHandleOwnership.DoNotTransfer);
			__this.MarkStart (o);
		}
#pragma warning restore 0169

		/// <param name="o">the object to start traversing from. The object passed must be
		///            from this same revision walker.</param>
		/// <summary>Mark an object or commit to start graph traversal from.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/method[@name='markStart' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("markStart", "(Lorg/eclipse/jgit/revwalk/RevObject;)V", "GetMarkStart_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe void MarkStart (global::Org.Eclipse.Jgit.Revwalk.RevObject o)
		{
			const string __id = "markStart.(Lorg/eclipse/jgit/revwalk/RevObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		static Delegate cb_markUninteresting_Lorg_eclipse_jgit_revwalk_RevObject_;
#pragma warning disable 0169
		static Delegate GetMarkUninteresting_Lorg_eclipse_jgit_revwalk_RevObject_Handler ()
		{
			if (cb_markUninteresting_Lorg_eclipse_jgit_revwalk_RevObject_ == null)
				cb_markUninteresting_Lorg_eclipse_jgit_revwalk_RevObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_MarkUninteresting_Lorg_eclipse_jgit_revwalk_RevObject_);
			return cb_markUninteresting_Lorg_eclipse_jgit_revwalk_RevObject_;
		}

		static void n_MarkUninteresting_Lorg_eclipse_jgit_revwalk_RevObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (native_o, JniHandleOwnership.DoNotTransfer);
			__this.MarkUninteresting (o);
		}
#pragma warning restore 0169

		/// <param name="o">the object to start traversing from. The object passed must be</param>
		/// <summary>Mark an object to not produce in the output.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/method[@name='markUninteresting' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.revwalk.RevObject']]"
		[Register ("markUninteresting", "(Lorg/eclipse/jgit/revwalk/RevObject;)V", "GetMarkUninteresting_Lorg_eclipse_jgit_revwalk_RevObject_Handler")]
		public virtual unsafe void MarkUninteresting (global::Org.Eclipse.Jgit.Revwalk.RevObject o)
		{
			const string __id = "markUninteresting.(Lorg/eclipse/jgit/revwalk/RevObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		static Delegate cb_nextObject;
#pragma warning disable 0169
		static Delegate GetNextObjectHandler ()
		{
			if (cb_nextObject == null)
				cb_nextObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NextObject);
			return cb_nextObject;
		}

		static IntPtr n_NextObject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.ObjectWalk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextObject ());
		}
#pragma warning restore 0169

		/// <summary>Pop the next most recent object.</summary>
		/// <returns>next most recent object; null if traversal is over.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revwalk']/class[@name='ObjectWalk']/method[@name='nextObject' and count(parameter)=0]"
		[Register ("nextObject", "()Lorg/eclipse/jgit/revwalk/RevObject;", "GetNextObjectHandler")]
		public virtual unsafe global::Org.Eclipse.Jgit.Revwalk.RevObject NextObject ()
		{
			const string __id = "nextObject.()Lorg/eclipse/jgit/revwalk/RevObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revwalk.RevObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
