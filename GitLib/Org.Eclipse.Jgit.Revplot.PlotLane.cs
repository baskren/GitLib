using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revplot {

	/// <summary>A line space within the graph.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotLane']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revplot/PlotLane", DoNotGenerateAcw=true)]
	public partial class PlotLane : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revplot/PlotLane", typeof (PlotLane));

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

		protected PlotLane (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotLane']/constructor[@name='PlotLane' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlotLane () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPosition);
			return cb_getPosition;
		}

		static int n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotLane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position;
		}
#pragma warning restore 0169

		/// <summary>Logical location of this lane within the graphing plane.</summary>
		/// <returns>location of this lane, 0 through the maximum number of lanes.</returns>
		public virtual unsafe int Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='PlotLane']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()I", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
