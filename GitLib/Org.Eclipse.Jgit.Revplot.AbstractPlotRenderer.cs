using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Revplot {

	/// <param name="&lt;TLane&gt;">type of lane being used by the application.</param>
	/// <param name="&lt;TColor&gt;">type of color object used by the graphics library.</param>
	/// <summary>Basic commit graph renderer for graphical user interfaces.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/revplot/AbstractPlotRenderer", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TLane extends org.eclipse.jgit.revplot.PlotLane", "TColor"})]
	public abstract partial class AbstractPlotRenderer : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revplot/AbstractPlotRenderer", typeof (AbstractPlotRenderer));

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

		protected AbstractPlotRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/constructor[@name='AbstractPlotRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractPlotRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_drawBoundaryDot_IIII;
#pragma warning disable 0169
		static Delegate GetDrawBoundaryDot_IIIIHandler ()
		{
			if (cb_drawBoundaryDot_IIII == null)
				cb_drawBoundaryDot_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_DrawBoundaryDot_IIII);
			return cb_drawBoundaryDot_IIII;
		}

		static void n_DrawBoundaryDot_IIII (IntPtr jnienv, IntPtr native__this, int x, int y, int w, int h)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.AbstractPlotRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawBoundaryDot (x, y, w, h);
		}
#pragma warning restore 0169

		/// <param name="x">upper left of the oval's bounding box.</param>
		/// <param name="y">upper left of the oval's bounding box.</param>
		/// <param name="w">width of the oval's bounding box.</param>
		/// <param name="h">height of the oval's bounding box.</param>
		/// <summary>Draw a single boundary commit (aka uninteresting commit) dot.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawBoundaryDot' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("drawBoundaryDot", "(IIII)V", "GetDrawBoundaryDot_IIIIHandler")]
		protected abstract void DrawBoundaryDot (int x, int y, int w, int h);

		static Delegate cb_drawCommitDot_IIII;
#pragma warning disable 0169
		static Delegate GetDrawCommitDot_IIIIHandler ()
		{
			if (cb_drawCommitDot_IIII == null)
				cb_drawCommitDot_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_DrawCommitDot_IIII);
			return cb_drawCommitDot_IIII;
		}

		static void n_DrawCommitDot_IIII (IntPtr jnienv, IntPtr native__this, int x, int y, int w, int h)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.AbstractPlotRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawCommitDot (x, y, w, h);
		}
#pragma warning restore 0169

		/// <param name="x">upper left of the oval's bounding box.</param>
		/// <param name="y">upper left of the oval's bounding box.</param>
		/// <param name="w">width of the oval's bounding box.</param>
		/// <param name="h">height of the oval's bounding box.</param>
		/// <summary>Draw a single commit dot.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawCommitDot' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("drawCommitDot", "(IIII)V", "GetDrawCommitDot_IIIIHandler")]
		protected abstract void DrawCommitDot (int x, int y, int w, int h);

		static Delegate cb_drawLabel_IILorg_eclipse_jgit_lib_Ref_;
#pragma warning disable 0169
		static Delegate GetDrawLabel_IILorg_eclipse_jgit_lib_Ref_Handler ()
		{
			if (cb_drawLabel_IILorg_eclipse_jgit_lib_Ref_ == null)
				cb_drawLabel_IILorg_eclipse_jgit_lib_Ref_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_I) n_DrawLabel_IILorg_eclipse_jgit_lib_Ref_);
			return cb_drawLabel_IILorg_eclipse_jgit_lib_Ref_;
		}

		static int n_DrawLabel_IILorg_eclipse_jgit_lib_Ref_ (IntPtr jnienv, IntPtr native__this, int x, int y, IntPtr native__ref)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.AbstractPlotRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @ref = (global::Org.Eclipse.Jgit.Lib.IRef)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IRef> (native__ref, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DrawLabel (x, y, @ref);
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="x">left</param>
		/// <param name="y">top</param>
		/// <param name="ref">A peeled ref</param>
		/// <summary>Draw a decoration for the Ref ref at x,y</summary>
		/// <returns>width of label in pixels</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawLabel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("drawLabel", "(IILorg/eclipse/jgit/lib/Ref;)I", "GetDrawLabel_IILorg_eclipse_jgit_lib_Ref_Handler")]
		protected abstract int DrawLabel (int x, int y, global::Org.Eclipse.Jgit.Lib.IRef @ref);

		static Delegate cb_drawLine_Ljava_lang_Object_IIIII;
#pragma warning disable 0169
		static Delegate GetDrawLine_Ljava_lang_Object_IIIIIHandler ()
		{
			if (cb_drawLine_Ljava_lang_Object_IIIII == null)
				cb_drawLine_Ljava_lang_Object_IIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIII_V) n_DrawLine_Ljava_lang_Object_IIIII);
			return cb_drawLine_Ljava_lang_Object_IIIII;
		}

		static void n_DrawLine_Ljava_lang_Object_IIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_color, int x1, int y1, int x2, int y2, int width)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.AbstractPlotRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var color = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_color, JniHandleOwnership.DoNotTransfer);
			__this.DrawLine (color, x1, y1, x2, y2, width);
		}
#pragma warning restore 0169

		/// <param name="color">the color to use while drawing the line.</param>
		/// <param name="x1">starting X coordinate, 0 based.</param>
		/// <param name="y1">starting Y coordinate, 0 based.</param>
		/// <param name="x2">ending X coordinate, 0 based.</param>
		/// <param name="y2">ending Y coordinate, 0 based.</param>
		/// <param name="width">number of pixels wide for the line. Always at least 1.</param>
		/// <summary>Draw a single line within this cell.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawLine' and count(parameter)=6 and parameter[1][@type='TColor'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("drawLine", "(Ljava/lang/Object;IIIII)V", "GetDrawLine_Ljava_lang_Object_IIIIIHandler")]
		protected abstract void DrawLine (global::Java.Lang.Object color, int x1, int y1, int x2, int y2, int width);

		static Delegate cb_drawText_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetDrawText_Ljava_lang_String_IIHandler ()
		{
			if (cb_drawText_Ljava_lang_String_II == null)
				cb_drawText_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_DrawText_Ljava_lang_String_II);
			return cb_drawText_Ljava_lang_String_II;
		}

		static void n_DrawText_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, int x, int y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.AbstractPlotRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.DrawText (msg, x, y);
		}
#pragma warning restore 0169

		/// <param name="msg">the text to draw. Does not contain LFs.</param>
		/// <param name="x">first pixel from the left that the text can be drawn at.
		///            Character data must not appear before this position.</param>
		/// <param name="y">pixel coordinate of the baseline of the text. Implementations
		///            must adjust this coordinate to account for the way their
		///            implementation handles font rendering.</param>
		/// <summary>Draw a single line of text.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawText' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("drawText", "(Ljava/lang/String;II)V", "GetDrawText_Ljava_lang_String_IIHandler")]
		protected abstract void DrawText (string msg, int x, int y);

		static Delegate cb_laneColor_Lorg_eclipse_jgit_revplot_PlotLane_;
#pragma warning disable 0169
		static Delegate GetLaneColor_Lorg_eclipse_jgit_revplot_PlotLane_Handler ()
		{
			if (cb_laneColor_Lorg_eclipse_jgit_revplot_PlotLane_ == null)
				cb_laneColor_Lorg_eclipse_jgit_revplot_PlotLane_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LaneColor_Lorg_eclipse_jgit_revplot_PlotLane_);
			return cb_laneColor_Lorg_eclipse_jgit_revplot_PlotLane_;
		}

		static IntPtr n_LaneColor_Lorg_eclipse_jgit_revplot_PlotLane_ (IntPtr jnienv, IntPtr native__this, IntPtr native_myLane)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.AbstractPlotRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var myLane = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_myLane, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LaneColor (myLane));
			return __ret;
		}
#pragma warning restore 0169

		/// <param name="myLane">the current lane. May be null.</param>
		/// <summary>Obtain the color reference used to paint this lane.</summary>
		/// <returns>graphics specific color reference. Must be a valid color.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='laneColor' and count(parameter)=1 and parameter[1][@type='TLane']]"
		[Register ("laneColor", "(Lorg/eclipse/jgit/revplot/PlotLane;)Ljava/lang/Object;", "GetLaneColor_Lorg_eclipse_jgit_revplot_PlotLane_Handler")]
		protected abstract global::Java.Lang.Object LaneColor (global::Java.Lang.Object myLane);

		static Delegate cb_paintCommit_Lorg_eclipse_jgit_revplot_PlotCommit_I;
#pragma warning disable 0169
		static Delegate GetPaintCommit_Lorg_eclipse_jgit_revplot_PlotCommit_IHandler ()
		{
			if (cb_paintCommit_Lorg_eclipse_jgit_revplot_PlotCommit_I == null)
				cb_paintCommit_Lorg_eclipse_jgit_revplot_PlotCommit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_PaintCommit_Lorg_eclipse_jgit_revplot_PlotCommit_I);
			return cb_paintCommit_Lorg_eclipse_jgit_revplot_PlotCommit_I;
		}

		static void n_PaintCommit_Lorg_eclipse_jgit_revplot_PlotCommit_I (IntPtr jnienv, IntPtr native__this, IntPtr native_commit, int h)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.AbstractPlotRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var commit = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Revplot.PlotCommit> (native_commit, JniHandleOwnership.DoNotTransfer);
			__this.PaintCommit (commit, h);
		}
#pragma warning restore 0169

		/// <param name="commit">the commit to render in this cell. Must not be null.</param>
		/// <param name="h">total height (in pixels) of this cell.</param>
		/// <summary>Paint one commit using the underlying graphics library.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='paintCommit' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.revplot.PlotCommit&lt;TLane&gt;'] and parameter[2][@type='int']]"
		[Register ("paintCommit", "(Lorg/eclipse/jgit/revplot/PlotCommit;I)V", "GetPaintCommit_Lorg_eclipse_jgit_revplot_PlotCommit_IHandler")]
		protected virtual unsafe void PaintCommit (global::Org.Eclipse.Jgit.Revplot.PlotCommit commit, int h)
		{
			const string __id = "paintCommit.(Lorg/eclipse/jgit/revplot/PlotCommit;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((commit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commit).Handle);
				__args [1] = new JniArgumentValue (h);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (commit);
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/revplot/AbstractPlotRenderer", DoNotGenerateAcw=true)]
	internal partial class AbstractPlotRendererInvoker : AbstractPlotRenderer {
		public AbstractPlotRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/revplot/AbstractPlotRenderer", typeof (AbstractPlotRendererInvoker));

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

		/// <param name="x">upper left of the oval's bounding box.</param>
		/// <param name="y">upper left of the oval's bounding box.</param>
		/// <param name="w">width of the oval's bounding box.</param>
		/// <param name="h">height of the oval's bounding box.</param>
		/// <summary>Draw a single boundary commit (aka uninteresting commit) dot.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawBoundaryDot' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("drawBoundaryDot", "(IIII)V", "GetDrawBoundaryDot_IIIIHandler")]
		protected override unsafe void DrawBoundaryDot (int x, int y, int w, int h)
		{
			const string __id = "drawBoundaryDot.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (w);
				__args [3] = new JniArgumentValue (h);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <param name="x">upper left of the oval's bounding box.</param>
		/// <param name="y">upper left of the oval's bounding box.</param>
		/// <param name="w">width of the oval's bounding box.</param>
		/// <param name="h">height of the oval's bounding box.</param>
		/// <summary>Draw a single commit dot.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawCommitDot' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("drawCommitDot", "(IIII)V", "GetDrawCommitDot_IIIIHandler")]
		protected override unsafe void DrawCommitDot (int x, int y, int w, int h)
		{
			const string __id = "drawCommitDot.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (w);
				__args [3] = new JniArgumentValue (h);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		/// <param name="x">left</param>
		/// <param name="y">top</param>
		/// <param name="ref">A peeled ref</param>
		/// <summary>Draw a decoration for the Ref ref at x,y</summary>
		/// <returns>width of label in pixels</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawLabel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.jgit.lib.Ref']]"
		[Register ("drawLabel", "(IILorg/eclipse/jgit/lib/Ref;)I", "GetDrawLabel_IILorg_eclipse_jgit_lib_Ref_Handler")]
		protected override unsafe int DrawLabel (int x, int y, global::Org.Eclipse.Jgit.Lib.IRef @ref)
		{
			const string __id = "drawLabel.(IILorg/eclipse/jgit/lib/Ref;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((@ref == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @ref).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (@ref);
			}
		}

		/// <param name="color">the color to use while drawing the line.</param>
		/// <param name="x1">starting X coordinate, 0 based.</param>
		/// <param name="y1">starting Y coordinate, 0 based.</param>
		/// <param name="x2">ending X coordinate, 0 based.</param>
		/// <param name="y2">ending Y coordinate, 0 based.</param>
		/// <param name="width">number of pixels wide for the line. Always at least 1.</param>
		/// <summary>Draw a single line within this cell.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawLine' and count(parameter)=6 and parameter[1][@type='TColor'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("drawLine", "(Ljava/lang/Object;IIIII)V", "GetDrawLine_Ljava_lang_Object_IIIIIHandler")]
		protected override unsafe void DrawLine (global::Java.Lang.Object color, int x1, int y1, int x2, int y2, int width)
		{
			const string __id = "drawLine.(Ljava/lang/Object;IIIII)V";
			IntPtr native_color = JNIEnv.ToLocalJniHandle (color);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_color);
				__args [1] = new JniArgumentValue (x1);
				__args [2] = new JniArgumentValue (y1);
				__args [3] = new JniArgumentValue (x2);
				__args [4] = new JniArgumentValue (y2);
				__args [5] = new JniArgumentValue (width);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_color);
				global::System.GC.KeepAlive (color);
			}
		}

		/// <param name="msg">the text to draw. Does not contain LFs.</param>
		/// <param name="x">first pixel from the left that the text can be drawn at.
		///            Character data must not appear before this position.</param>
		/// <param name="y">pixel coordinate of the baseline of the text. Implementations
		///            must adjust this coordinate to account for the way their
		///            implementation handles font rendering.</param>
		/// <summary>Draw a single line of text.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='drawText' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("drawText", "(Ljava/lang/String;II)V", "GetDrawText_Ljava_lang_String_IIHandler")]
		protected override unsafe void DrawText (string msg, int x, int y)
		{
			const string __id = "drawText.(Ljava/lang/String;II)V";
			IntPtr native_msg = JNIEnv.NewString ((string)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		/// <param name="myLane">the current lane. May be null.</param>
		/// <summary>Obtain the color reference used to paint this lane.</summary>
		/// <returns>graphics specific color reference. Must be a valid color.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.revplot']/class[@name='AbstractPlotRenderer']/method[@name='laneColor' and count(parameter)=1 and parameter[1][@type='TLane']]"
		[Register ("laneColor", "(Lorg/eclipse/jgit/revplot/PlotLane;)Ljava/lang/Object;", "GetLaneColor_Lorg_eclipse_jgit_revplot_PlotLane_Handler")]
		protected override unsafe global::Java.Lang.Object LaneColor (global::Java.Lang.Object myLane)
		{
			const string __id = "laneColor.(Lorg/eclipse/jgit/revplot/PlotLane;)Ljava/lang/Object;";
			IntPtr native_myLane = JNIEnv.ToLocalJniHandle (myLane);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_myLane);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_myLane);
				global::System.GC.KeepAlive (myLane);
			}
		}

	}
}
