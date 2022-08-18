using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Diff {

	/// <summary>A modified region detected between two versions of roughly the same content.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/diff/Edit", DoNotGenerateAcw=true)]
	public partial class Edit : global::Java.Lang.Object {
		/// <summary>Type of edit</summary>
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit.Type']"
		[global::Android.Runtime.Register ("org/eclipse/jgit/diff/Edit$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit.Type']/field[@name='DELETE']"
			[Register ("DELETE")]
			public static global::Org.Eclipse.Jgit.Diff.Edit.Type Delete {
				get {
					const string __id = "DELETE.Lorg/eclipse/jgit/diff/Edit$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit.Type']/field[@name='EMPTY']"
			[Register ("EMPTY")]
			public static global::Org.Eclipse.Jgit.Diff.Edit.Type Empty {
				get {
					const string __id = "EMPTY.Lorg/eclipse/jgit/diff/Edit$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit.Type']/field[@name='INSERT']"
			[Register ("INSERT")]
			public static global::Org.Eclipse.Jgit.Diff.Edit.Type Insert {
				get {
					const string __id = "INSERT.Lorg/eclipse/jgit/diff/Edit$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit.Type']/field[@name='REPLACE']"
			[Register ("REPLACE")]
			public static global::Org.Eclipse.Jgit.Diff.Edit.Type Replace {
				get {
					const string __id = "REPLACE.Lorg/eclipse/jgit/diff/Edit$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/Edit$Type", typeof (Type));

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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/jgit/diff/Edit$Type;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.Edit.Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/eclipse/jgit/diff/Edit$Type;";
				IntPtr native_name = JNIEnv.NewString ((string)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/jgit/diff/Edit$Type;", "")]
			public static unsafe global::Org.Eclipse.Jgit.Diff.Edit.Type[] Values ()
			{
				const string __id = "values.()[Lorg/eclipse/jgit/diff/Edit$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Eclipse.Jgit.Diff.Edit.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Jgit.Diff.Edit.Type));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/diff/Edit", typeof (Edit));

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

		protected Edit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="as">beginA: start and end of region in sequence A; 0 based.</param>
		/// <param name="bs">beginB: start and end of region in sequence B; 0 based.</param>
		/// <summary>Create a new empty edit.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/constructor[@name='Edit' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Edit (int @as, int bs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (@as);
				__args [1] = new JniArgumentValue (bs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		/// <param name="as">beginA: start of region in sequence A; 0 based.</param>
		/// <param name="ae">endA: end of region in sequence A; must be &amp;gt;= as.</param>
		/// <param name="bs">beginB: start of region in sequence B; 0 based.</param>
		/// <param name="be">endB: end of region in sequence B; must be &amp;gt; = bs.</param>
		/// <summary>Create a new edit.</summary>
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/constructor[@name='Edit' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe Edit (int @as, int ae, int bs, int be) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (@as);
				__args [1] = new JniArgumentValue (ae);
				__args [2] = new JniArgumentValue (bs);
				__args [3] = new JniArgumentValue (be);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		/// <returns>start point in sequence A.</returns>
		public unsafe int BeginA {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='getBeginA' and count(parameter)=0]"
			[Register ("getBeginA", "()I", "")]
			get {
				const string __id = "getBeginA.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>start point in sequence B.</returns>
		public unsafe int BeginB {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='getBeginB' and count(parameter)=0]"
			[Register ("getBeginB", "()I", "")]
			get {
				const string __id = "getBeginB.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>end point in sequence A.</returns>
		public unsafe int EndA {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='getEndA' and count(parameter)=0]"
			[Register ("getEndA", "()I", "")]
			get {
				const string __id = "getEndA.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>end point in sequence B.</returns>
		public unsafe int EndB {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='getEndB' and count(parameter)=0]"
			[Register ("getEndB", "()I", "")]
			get {
				const string __id = "getEndB.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>true if the edit is empty (lengths of both a and b is zero).</returns>
		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>length of the region in A.</returns>
		public unsafe int LengthA {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='getLengthA' and count(parameter)=0]"
			[Register ("getLengthA", "()I", "")]
			get {
				const string __id = "getLengthA.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>length of the region in B.</returns>
		public unsafe int LengthB {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='getLengthB' and count(parameter)=0]"
			[Register ("getLengthB", "()I", "")]
			get {
				const string __id = "getLengthB.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="cut">the cut point. The ending A and B points are used as the
		///            starting points of the returned edit.</param>
		/// <summary>Construct a new edit representing the region after cut.</summary>
		/// <returns>an edit representing the slice of <c>this</c> edit that occurs
		///         after <c>cut</c> ends.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='after' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.Edit']]"
		[Register ("after", "(Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Edit;", "")]
		public unsafe global::Org.Eclipse.Jgit.Diff.Edit After (global::Org.Eclipse.Jgit.Diff.Edit cut)
		{
			const string __id = "after.(Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Edit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cut == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cut).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cut);
			}
		}

		/// <param name="cut">the cut point. The beginning A and B points are used as the
		///            end points of the returned edit.</param>
		/// <summary>Construct a new edit representing the region before cut.</summary>
		/// <returns>an edit representing the slice of <c>this</c> edit that occurs
		///         before <c>cut</c> starts.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='before' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.diff.Edit']]"
		[Register ("before", "(Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Edit;", "")]
		public unsafe global::Org.Eclipse.Jgit.Diff.Edit Before (global::Org.Eclipse.Jgit.Diff.Edit cut)
		{
			const string __id = "before.(Lorg/eclipse/jgit/diff/Edit;)Lorg/eclipse/jgit/diff/Edit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cut == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cut).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cut);
			}
		}

		static Delegate cb_extendA;
#pragma warning disable 0169
		static Delegate GetExtendAHandler ()
		{
			if (cb_extendA == null)
				cb_extendA = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ExtendA);
			return cb_extendA;
		}

		static void n_ExtendA (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExtendA ();
		}
#pragma warning restore 0169

		/// <summary>Increase <c>#getEndA()</c> by 1.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='extendA' and count(parameter)=0]"
		[Register ("extendA", "()V", "GetExtendAHandler")]
		public virtual unsafe void ExtendA ()
		{
			const string __id = "extendA.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_extendB;
#pragma warning disable 0169
		static Delegate GetExtendBHandler ()
		{
			if (cb_extendB == null)
				cb_extendB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ExtendB);
			return cb_extendB;
		}

		static void n_ExtendB (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExtendB ();
		}
#pragma warning restore 0169

		/// <summary>Increase <c>#getEndB()</c> by 1.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='extendB' and count(parameter)=0]"
		[Register ("extendB", "()V", "GetExtendBHandler")]
		public virtual unsafe void ExtendB ()
		{
			const string __id = "extendB.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lorg/eclipse/jgit/diff/Edit$Type;", "")]
		public new unsafe global::Org.Eclipse.Jgit.Diff.Edit.Type GetType ()
		{
			const string __id = "getType.()Lorg/eclipse/jgit/diff/Edit$Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_swap;
#pragma warning disable 0169
		static Delegate GetSwapHandler ()
		{
			if (cb_swap == null)
				cb_swap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Swap);
			return cb_swap;
		}

		static void n_Swap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Diff.Edit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Swap ();
		}
#pragma warning restore 0169

		/// <summary>Swap A and B, so the edit goes the other direction.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.diff']/class[@name='Edit']/method[@name='swap' and count(parameter)=0]"
		[Register ("swap", "()V", "GetSwapHandler")]
		public virtual unsafe void Swap ()
		{
			const string __id = "swap.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
