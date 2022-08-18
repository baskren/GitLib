using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Utility for reading reflog entries</summary>
	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogReader']"
	[Register ("org/eclipse/jgit/lib/ReflogReader", "", "Org.Eclipse.Jgit.Lib.IReflogReaderInvoker")]
	public partial interface IReflogReader : IJavaObject, IJavaPeerable {
		global::Org.Eclipse.Jgit.Lib.IReflogEntry LastEntry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogReader']/method[@name='getLastEntry' and count(parameter)=0]"
			[Register ("getLastEntry", "()Lorg/eclipse/jgit/lib/ReflogEntry;", "GetGetLastEntryHandler:Org.Eclipse.Jgit.Lib.IReflogReaderInvoker, AndroidBindableLibrary")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IReflogEntry> ReverseEntries {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogReader']/method[@name='getReverseEntries' and count(parameter)=0]"
			[Register ("getReverseEntries", "()Ljava/util/List;", "GetGetReverseEntriesHandler:Org.Eclipse.Jgit.Lib.IReflogReaderInvoker, AndroidBindableLibrary")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogReader']/method[@name='getReverseEntries' and count(parameter)=1 and parameter[1][@type='int']]"
		/// <param name="max">max number of entries to read</param>
		/// <returns>all reflog entries in reverse order</returns>
		[Register ("getReverseEntries", "(I)Ljava/util/List;", "GetGetReverseEntries_IHandler:Org.Eclipse.Jgit.Lib.IReflogReaderInvoker, AndroidBindableLibrary")]
		global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IReflogEntry> GetReverseEntries (int max);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/interface[@name='ReflogReader']/method[@name='getReverseEntry' and count(parameter)=1 and parameter[1][@type='int']]"
		/// <param name="number">number</param>
		/// <summary>Get specific entry in the reflog relative to the last entry which is
		/// considered entry zero.</summary>
		/// <returns>reflog entry or null if not found</returns>
		[Register ("getReverseEntry", "(I)Lorg/eclipse/jgit/lib/ReflogEntry;", "GetGetReverseEntry_IHandler:Org.Eclipse.Jgit.Lib.IReflogReaderInvoker, AndroidBindableLibrary")]
		global::Org.Eclipse.Jgit.Lib.IReflogEntry GetReverseEntry (int number);

	}

	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ReflogReader", DoNotGenerateAcw=true)]
	internal partial class IReflogReaderInvoker : global::Java.Lang.Object, IReflogReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ReflogReader", typeof (IReflogReaderInvoker));

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

		public static IReflogReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReflogReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'org.eclipse.jgit.lib.ReflogReader'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReflogReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLastEntry;
#pragma warning disable 0169
		static Delegate GetGetLastEntryHandler ()
		{
			if (cb_getLastEntry == null)
				cb_getLastEntry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLastEntry);
			return cb_getLastEntry;
		}

		static IntPtr n_GetLastEntry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastEntry);
		}
#pragma warning restore 0169

		IntPtr id_getLastEntry;
		public unsafe global::Org.Eclipse.Jgit.Lib.IReflogEntry LastEntry {
			get {
				if (id_getLastEntry == IntPtr.Zero)
					id_getLastEntry = JNIEnv.GetMethodID (class_ref, "getLastEntry", "()Lorg/eclipse/jgit/lib/ReflogEntry;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastEntry), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReverseEntries;
#pragma warning disable 0169
		static Delegate GetGetReverseEntriesHandler ()
		{
			if (cb_getReverseEntries == null)
				cb_getReverseEntries = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReverseEntries);
			return cb_getReverseEntries;
		}

		static IntPtr n_GetReverseEntries (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IReflogEntry>.ToLocalJniHandle (__this.ReverseEntries);
		}
#pragma warning restore 0169

		IntPtr id_getReverseEntries;
		public unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IReflogEntry> ReverseEntries {
			get {
				if (id_getReverseEntries == IntPtr.Zero)
					id_getReverseEntries = JNIEnv.GetMethodID (class_ref, "getReverseEntries", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IReflogEntry>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReverseEntries), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReverseEntries_I;
#pragma warning disable 0169
		static Delegate GetGetReverseEntries_IHandler ()
		{
			if (cb_getReverseEntries_I == null)
				cb_getReverseEntries_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetReverseEntries_I);
			return cb_getReverseEntries_I;
		}

		static IntPtr n_GetReverseEntries_I (IntPtr jnienv, IntPtr native__this, int max)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IReflogEntry>.ToLocalJniHandle (__this.GetReverseEntries (max));
		}
#pragma warning restore 0169

		IntPtr id_getReverseEntries_I;
		public unsafe global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Lib.IReflogEntry> GetReverseEntries (int max)
		{
			if (id_getReverseEntries_I == IntPtr.Zero)
				id_getReverseEntries_I = JNIEnv.GetMethodID (class_ref, "getReverseEntries", "(I)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (max);
			return global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Lib.IReflogEntry>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReverseEntries_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getReverseEntry_I;
#pragma warning disable 0169
		static Delegate GetGetReverseEntry_IHandler ()
		{
			if (cb_getReverseEntry_I == null)
				cb_getReverseEntry_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetReverseEntry_I);
			return cb_getReverseEntry_I;
		}

		static IntPtr n_GetReverseEntry_I (IntPtr jnienv, IntPtr native__this, int number)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetReverseEntry (number));
		}
#pragma warning restore 0169

		IntPtr id_getReverseEntry_I;
		public unsafe global::Org.Eclipse.Jgit.Lib.IReflogEntry GetReverseEntry (int number)
		{
			if (id_getReverseEntry_I == IntPtr.Zero)
				id_getReverseEntry_I = JNIEnv.GetMethodID (class_ref, "getReverseEntry", "(I)Lorg/eclipse/jgit/lib/ReflogEntry;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (number);
			return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.IReflogEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReverseEntry_I, __args), JniHandleOwnership.TransferLocalRef);
		}

	}
}
