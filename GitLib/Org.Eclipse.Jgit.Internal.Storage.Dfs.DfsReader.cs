using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal.Storage.Dfs {

	/// <summary>Reader to access repository content through.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/storage/dfs/DfsReader", DoNotGenerateAcw=true)]
	public sealed partial class DfsReader : global::Org.Eclipse.Jgit.Lib.ObjectReader, global::Org.Eclipse.Jgit.Internal.Storage.Pack.IObjectReuseAsIs {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/storage/dfs/DfsReader", typeof (DfsReader));

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

		internal DfsReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> ShallowCommits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='getShallowCommits' and count(parameter)=0]"
			[Register ("getShallowCommits", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getShallowCommits.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='copyObjectAsIs' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackOutputStream'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.ObjectToPack'] and parameter[3][@type='boolean']]"
		[Register ("copyObjectAsIs", "(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Z)V", "")]
		public unsafe void CopyObjectAsIs (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream @out, global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack otp, bool validate)
		{
			const string __id = "copyObjectAsIs.(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue ((otp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) otp).Handle);
				__args [2] = new JniArgumentValue (validate);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@out);
				global::System.GC.KeepAlive (otp);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='copyPackAsIs' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackOutputStream'] and parameter[2][@type='org.eclipse.jgit.internal.storage.pack.CachedPack'] and parameter[3][@type='boolean']]"
		[Register ("copyPackAsIs", "(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Lorg/eclipse/jgit/internal/storage/pack/CachedPack;Z)V", "")]
		public unsafe void CopyPackAsIs (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream @out, global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack pack, bool validate)
		{
			const string __id = "copyPackAsIs.(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Lorg/eclipse/jgit/internal/storage/pack/CachedPack;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue ((pack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pack).Handle);
				__args [2] = new JniArgumentValue (validate);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@out);
				global::System.GC.KeepAlive (pack);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='getCachedPacksAndUpdate' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.BitmapIndex.BitmapBuilder']]"
		[Register ("getCachedPacksAndUpdate", "(Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;)Ljava/util/Collection;", "")]
		public unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack> GetCachedPacksAndUpdate (global::Org.Eclipse.Jgit.Lib.IBitmapIndexBitmapBuilder needBitmap)
		{
			const string __id = "getCachedPacksAndUpdate.(Lorg/eclipse/jgit/lib/BitmapIndex$BitmapBuilder;)Ljava/util/Collection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((needBitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) needBitmap).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Internal.Storage.Pack.CachedPack>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (needBitmap);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='newObjectToPack' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("newObjectToPack", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;", "")]
		public unsafe global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack NewObjectToPack (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int type)
		{
			const string __id = "newObjectToPack.(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/internal/storage/pack/ObjectToPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [1] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='newReader' and count(parameter)=0]"
		[Register ("newReader", "()Lorg/eclipse/jgit/lib/ObjectReader;", "")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectReader NewReader ()
		{
			const string __id = "newReader.()Lorg/eclipse/jgit/lib/ObjectReader;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='open' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='int']]"
		[Register ("open", "(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/ObjectLoader;", "")]
		public override unsafe global::Org.Eclipse.Jgit.Lib.ObjectLoader Open (global::Org.Eclipse.Jgit.Lib.AnyObjectId objectId, int typeHint)
		{
			const string __id = "open.(Lorg/eclipse/jgit/lib/AnyObjectId;I)Lorg/eclipse/jgit/lib/ObjectLoader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((objectId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objectId).Handle);
				__args [1] = new JniArgumentValue (typeHint);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (objectId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='resolve' and count(parameter)=1 and parameter[1][@type='org.eclipse.jgit.lib.AbbreviatedObjectId']]"
		[Register ("resolve", "(Lorg/eclipse/jgit/lib/AbbreviatedObjectId;)Ljava/util/Collection;", "")]
		public override unsafe global::System.Collections.Generic.ICollection<global::Org.Eclipse.Jgit.Lib.ObjectId> Resolve (global::Org.Eclipse.Jgit.Lib.AbbreviatedObjectId id)
		{
			const string __id = "resolve.(Lorg/eclipse/jgit/lib/AbbreviatedObjectId;)Ljava/util/Collection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaCollection<global::Org.Eclipse.Jgit.Lib.ObjectId>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='selectObjectRepresentation' and count(parameter)=3 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackWriter'] and parameter[2][@type='org.eclipse.jgit.lib.ProgressMonitor'] and parameter[3][@type='java.lang.Iterable&lt;org.eclipse.jgit.internal.storage.pack.ObjectToPack&gt;']]"
		[Register ("selectObjectRepresentation", "(Lorg/eclipse/jgit/internal/storage/pack/PackWriter;Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/lang/Iterable;)V", "")]
		public unsafe void SelectObjectRepresentation (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackWriter packer, global::Org.Eclipse.Jgit.Lib.IProgressMonitor monitor, global::Java.Lang.IIterable objects)
		{
			const string __id = "selectObjectRepresentation.(Lorg/eclipse/jgit/internal/storage/pack/PackWriter;Lorg/eclipse/jgit/lib/ProgressMonitor;Ljava/lang/Iterable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((packer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packer).Handle);
				__args [1] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				__args [2] = new JniArgumentValue ((objects == null) ? IntPtr.Zero : ((global::Java.Lang.Object) objects).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (packer);
				global::System.GC.KeepAlive (monitor);
				global::System.GC.KeepAlive (objects);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal.storage.dfs']/class[@name='DfsReader']/method[@name='writeObjects' and count(parameter)=2 and parameter[1][@type='org.eclipse.jgit.internal.storage.pack.PackOutputStream'] and parameter[2][@type='java.util.List&lt;org.eclipse.jgit.internal.storage.pack.ObjectToPack&gt;']]"
		[Register ("writeObjects", "(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Ljava/util/List;)V", "")]
		public unsafe void WriteObjects (global::Org.Eclipse.Jgit.Internal.Storage.Pack.PackOutputStream @out, global::System.Collections.Generic.IList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack> list)
		{
			const string __id = "writeObjects.(Lorg/eclipse/jgit/internal/storage/pack/PackOutputStream;Ljava/util/List;)V";
			IntPtr native_list = global::Android.Runtime.JavaList<global::Org.Eclipse.Jgit.Internal.Storage.Pack.ObjectToPack>.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				__args [1] = new JniArgumentValue (native_list);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (@out);
				global::System.GC.KeepAlive (list);
			}
		}

	}
}
