using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Transport {

	/// <summary>Wire constants for the native Git protocol.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/transport/GitProtocolConstants", DoNotGenerateAcw=true)]
	public partial class GitProtocolConstants : global::Java.Lang.Object {
		/// <summary>The client supports atomic pushes.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='CAPABILITY_ATOMIC']"
		[Register ("CAPABILITY_ATOMIC")]
		public const string CapabilityAtomic = (string) "atomic";

		/// <summary>The server supports deleting refs.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='CAPABILITY_DELETE_REFS']"
		[Register ("CAPABILITY_DELETE_REFS")]
		public const string CapabilityDeleteRefs = (string) "delete-refs";

		/// <summary>The server supports packs with OFS deltas.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='CAPABILITY_OFS_DELTA']"
		[Register ("CAPABILITY_OFS_DELTA")]
		public const string CapabilityOfsDelta = (string) "ofs-delta";

		/// <summary>The client expects a status report after the server processes the pack.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='CAPABILITY_REPORT_STATUS']"
		[Register ("CAPABILITY_REPORT_STATUS")]
		public const string CapabilityReportStatus = (string) "report-status";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='CAPABILITY_SIDE_BAND_64K']"
		[Register ("CAPABILITY_SIDE_BAND_64K")]
		public const string CapabilitySideBand64k = (string) "side-band-64k";

		/// <summary>The client supports fetching objects at the tip of any ref, even if not
		/// advertised.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_ALLOW_TIP_SHA1_IN_WANT']"
		[Register ("OPTION_ALLOW_TIP_SHA1_IN_WANT")]
		public const string OptionAllowTipSha1InWant = (string) "allow-tip-sha1-in-want";

		/// <summary>Include tags if we are also including the referenced objects.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_INCLUDE_TAG']"
		[Register ("OPTION_INCLUDE_TAG")]
		public const string OptionIncludeTag = (string) "include-tag";

		/// <summary>Mutli-ACK support for improved negotiation.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_MULTI_ACK']"
		[Register ("OPTION_MULTI_ACK")]
		public const string OptionMultiAck = (string) "multi_ack";

		/// <summary>Mutli-ACK detailed support for improved negotiation.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_MULTI_ACK_DETAILED']"
		[Register ("OPTION_MULTI_ACK_DETAILED")]
		public const string OptionMultiAckDetailed = (string) "multi_ack_detailed";

		/// <summary>The client supports receiving a pack before it has sent "done".</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_NO_DONE']"
		[Register ("OPTION_NO_DONE")]
		public const string OptionNoDone = (string) "no-done";

		/// <summary>The client does not want progress messages and will ignore them.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_NO_PROGRESS']"
		[Register ("OPTION_NO_PROGRESS")]
		public const string OptionNoProgress = (string) "no-progress";

		/// <summary>The client supports packs with OFS deltas.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_OFS_DELTA']"
		[Register ("OPTION_OFS_DELTA")]
		public const string OptionOfsDelta = (string) "ofs-delta";

		/// <summary>The client supports shallow fetches.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_SHALLOW']"
		[Register ("OPTION_SHALLOW")]
		public const string OptionShallow = (string) "shallow";

		/// <summary>The client supports using the side-band for progress messages.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_SIDE_BAND']"
		[Register ("OPTION_SIDE_BAND")]
		public const string OptionSideBand = (string) "side-band";

		/// <summary>The client supports using the 64K side-band for progress messages.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_SIDE_BAND_64K']"
		[Register ("OPTION_SIDE_BAND_64K")]
		public const string OptionSideBand64k = (string) "side-band-64k";

		/// <summary>Symbolic reference support for better negotiation.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_SYMREF']"
		[Register ("OPTION_SYMREF")]
		public const string OptionSymref = (string) "symref";

		/// <summary>The client supports packs with deltas but not their bases.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.transport']/class[@name='GitProtocolConstants']/field[@name='OPTION_THIN_PACK']"
		[Register ("OPTION_THIN_PACK")]
		public const string OptionThinPack = (string) "thin-pack";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/transport/GitProtocolConstants", typeof (GitProtocolConstants));

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

		protected GitProtocolConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
