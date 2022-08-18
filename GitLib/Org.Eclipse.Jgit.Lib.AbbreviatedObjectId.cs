using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>A prefix abbreviation of an <c>ObjectId</c>.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/AbbreviatedObjectId", DoNotGenerateAcw=true)]
	public sealed partial class AbbreviatedObjectId : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/AbbreviatedObjectId", typeof (AbbreviatedObjectId));

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

		internal AbbreviatedObjectId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <returns>value for a fan-out style map, only valid of length &amp;gt;= 2.</returns>
		public unsafe int FirstByte {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='getFirstByte' and count(parameter)=0]"
			[Register ("getFirstByte", "()I", "")]
			get {
				const string __id = "getFirstByte.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <returns>true if this ObjectId is actually a complete id.</returns>
		public unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "")]
			get {
				const string __id = "isComplete.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		/// <param name="id">the <c>ObjectId</c> to convert from.</param>
		/// <summary>Convert an AbbreviatedObjectId from an <c>AnyObjectId</c>.</summary>
		/// <returns>the converted object id.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='fromObjectId' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("fromObjectId", "(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId FromObjectId (global::Org.Eclipse.Jgit.Lib.AnyObjectId id)
		{
			const string __id = "fromObjectId.(Lorg/eclipse/jgit/lib/AnyObjectId;)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		/// <param name="buf">the US-ASCII buffer to read from.</param>
		/// <param name="offset">position to read the first character from.</param>
		/// <param name="end">one past the last position to read (&lt;code&gt;end-offset&lt;/code&gt; is
		///            the length of the string).</param>
		/// <summary>Convert an AbbreviatedObjectId from hex characters (US-ASCII).</summary>
		/// <returns>the converted object id.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='fromString' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fromString", "([BII)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId FromString (byte[] buf, int offset, int end)
		{
			const string __id = "fromString.([BII)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buf);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

		/// <param name="str">the string to read from. Must be &amp;lt;= 40 characters.</param>
		/// <summary>Convert an AbbreviatedObjectId from hex characters.</summary>
		/// <returns>the converted object id.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId FromString (string str)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lorg/eclipse/jgit/lib/AbbreviatedObjectId;";
			IntPtr native_str = JNIEnv.NewString ((string)str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		/// <param name="id">the string to test.</param>
		/// <summary>Test a string of characters to verify it is a hex format.</summary>
		/// <returns>true if the string can converted into an AbbreviatedObjectId.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='isId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isId", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsId (string id)
		{
			const string __id = "isId.(Ljava/lang/String;)Z";
			IntPtr native_id = JNIEnv.NewString ((string)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		/// <returns>number of hex digits appearing in this id</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "")]
		public unsafe int Length ()
		{
			const string __id = "length.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		/// <returns>string form of the abbreviation, in lower case hexadecimal.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "")]
		public unsafe string Name ()
		{
			const string __id = "name.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="bs">array containing the other ObjectId in network byte order.</param>
		/// <param name="p">position within <c>bs</c> to start the compare at. At least
		///            20 bytes, starting at this position are required.</param>
		/// <summary>Compare this abbreviation to a network-byte-order ObjectId.</summary>
		/// <returns>&amp;lt;0 if this abbreviation names an object that is less than
		///         &lt;code&gt;other&lt;/code&gt;; 0 if this abbreviation exactly matches the
		///         first <c>#length()</c> digits of &lt;code&gt;other.name()&lt;/code&gt;;
		///         &amp;gt;0 if this abbreviation names an object that is after
		///         &lt;code&gt;other&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='prefixCompare' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("prefixCompare", "([BI)I", "")]
		public unsafe int PrefixCompare (byte[] bs, int p)
		{
			const string __id = "prefixCompare.([BI)I";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bs);
				__args [1] = new JniArgumentValue (p);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		/// <param name="bs">array containing the other ObjectId in network byte order.</param>
		/// <param name="p">position within <c>bs</c> to start the compare at. At least 5
		///            ints, starting at this position are required.</param>
		/// <summary>Compare this abbreviation to a network-byte-order ObjectId.</summary>
		/// <returns>&amp;lt;0 if this abbreviation names an object that is less than
		///         &lt;code&gt;other&lt;/code&gt;; 0 if this abbreviation exactly matches the
		///         first <c>#length()</c> digits of &lt;code&gt;other.name()&lt;/code&gt;;
		///         &amp;gt;0 if this abbreviation names an object that is after
		///         &lt;code&gt;other&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='prefixCompare' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("prefixCompare", "([II)I", "")]
		public unsafe int PrefixCompare (int[] bs, int p)
		{
			const string __id = "prefixCompare.([II)I";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bs);
				__args [1] = new JniArgumentValue (p);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
				global::System.GC.KeepAlive (bs);
			}
		}

		/// <param name="other">the other object id.</param>
		/// <summary>Compares this abbreviation to a full object id.</summary>
		/// <returns>&amp;lt;0 if this abbreviation names an object that is less than
		///         &lt;code&gt;other&lt;/code&gt;; 0 if this abbreviation exactly matches the
		///         first <c>#length()</c> digits of &lt;code&gt;other.name()&lt;/code&gt;;
		///         &amp;gt;0 if this abbreviation names an object that is after
		///         &lt;code&gt;other&lt;/code&gt;.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='prefixCompare' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId']]"
		[Register ("prefixCompare", "(Lorg/eclipse/jgit/lib/AnyObjectId;)I", "")]
		public unsafe int PrefixCompare (global::Org.Eclipse.Jgit.Lib.AnyObjectId other)
		{
			const string __id = "prefixCompare.(Lorg/eclipse/jgit/lib/AnyObjectId;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		/// <returns>a complete ObjectId; null if <c>#isComplete()</c> is false</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='AbbreviatedObjectId']/method[@name='toObjectId' and count(parameter)=0]"
		[Register ("toObjectId", "()Lorg/eclipse/jgit/lib/ObjectId;", "")]
		public unsafe global::Org.Eclipse.Jgit.Lib.ObjectId ToObjectId ()
		{
			const string __id = "toObjectId.()Lorg/eclipse/jgit/lib/ObjectId;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
