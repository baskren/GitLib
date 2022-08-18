using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Creates zlib based inflaters as necessary for object decompression.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='InflaterCache']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/InflaterCache", DoNotGenerateAcw=true)]
	public partial class InflaterCache : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/InflaterCache", typeof (InflaterCache));

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

		protected InflaterCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <summary>Obtain an Inflater for decompression.</summary>
		/// <returns>an available inflater. Never null.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='InflaterCache']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/util/zip/Inflater;", "")]
		public static unsafe global::Java.Util.Zip.Inflater Get ()
		{
			const string __id = "get.()Ljava/util/zip/Inflater;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Zip.Inflater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="i">the inflater to return. May be null, in which case this method
		///            does nothing.</param>
		/// <summary>Release an inflater previously obtained from this cache.</summary>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='InflaterCache']/method[@name='release' and count(parameter)=1 and parameter[1][@type='java.util.zip.Inflater']]"
		[Register ("release", "(Ljava/util/zip/Inflater;)V", "")]
		public static unsafe void Release (global::Java.Util.Zip.Inflater i)
		{
			const string __id = "release.(Ljava/util/zip/Inflater;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((i == null) ? IntPtr.Zero : ((global::Java.Lang.Object) i).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (i);
			}
		}

	}
}
