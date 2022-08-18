using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Constants for use with the Configuration classes: section names,
	/// configuration keys</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/ConfigConstants", DoNotGenerateAcw=true)]
	public partial class ConfigConstants : global::Java.Lang.Object {
		/// <summary>The "branch" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_BRANCH_SECTION']"
		[Register ("CONFIG_BRANCH_SECTION")]
		public const string ConfigBranchSection = (string) "branch";

		/// <summary>The "core" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_CORE_SECTION']"
		[Register ("CONFIG_CORE_SECTION")]
		public const string ConfigCoreSection = (string) "core";

		/// <summary>The "dfs" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_DFS_SECTION']"
		[Register ("CONFIG_DFS_SECTION")]
		public const string ConfigDfsSection = (string) "dfs";

		/// <summary>The "diff" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_DIFF_SECTION']"
		[Register ("CONFIG_DIFF_SECTION")]
		public const string ConfigDiffSection = (string) "diff";

		/// <summary>The "fetch" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_FETCH_SECTION']"
		[Register ("CONFIG_FETCH_SECTION")]
		public const string ConfigFetchSection = (string) "fetch";

		/// <summary>The "gc" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_GC_SECTION']"
		[Register ("CONFIG_GC_SECTION")]
		public const string ConfigGcSection = (string) "gc";

		/// <summary>The "gerrit" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_GERRIT_SECTION']"
		[Register ("CONFIG_GERRIT_SECTION")]
		public const string ConfigGerritSection = (string) "gerrit";

		/// <summary>The "aggressiveDepth" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_AGGRESSIVE_DEPTH']"
		[Register ("CONFIG_KEY_AGGRESSIVE_DEPTH")]
		public const string ConfigKeyAggressiveDepth = (string) "aggressiveDepth";

		/// <summary>The "aggressiveWindow" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_AGGRESSIVE_WINDOW']"
		[Register ("CONFIG_KEY_AGGRESSIVE_WINDOW")]
		public const string ConfigKeyAggressiveWindow = (string) "aggressiveWindow";

		/// <summary>The "algorithm" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_ALGORITHM']"
		[Register ("CONFIG_KEY_ALGORITHM")]
		public const string ConfigKeyAlgorithm = (string) "algorithm";

		/// <summary>The "always" key (used to configure <c>#CONFIG_KEY_AUTOSETUPREBASE</c>
		/// and <c>#CONFIG_KEY_AUTOSETUPMERGE</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_ALWAYS']"
		[Register ("CONFIG_KEY_ALWAYS")]
		public const string ConfigKeyAlways = (string) "always";

		/// <summary>The "attributesfile" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_ATTRIBUTESFILE']"
		[Register ("CONFIG_KEY_ATTRIBUTESFILE")]
		public const string ConfigKeyAttributesfile = (string) "attributesfile";

		/// <summary>The "autocrlf" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_AUTOCRLF']"
		[Register ("CONFIG_KEY_AUTOCRLF")]
		public const string ConfigKeyAutocrlf = (string) "autocrlf";

		/// <summary>The "autosetupmerge" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_AUTOSETUPMERGE']"
		[Register ("CONFIG_KEY_AUTOSETUPMERGE")]
		public const string ConfigKeyAutosetupmerge = (string) "autosetupmerge";

		/// <summary>The "autosetuprebase" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_AUTOSETUPREBASE']"
		[Register ("CONFIG_KEY_AUTOSETUPREBASE")]
		public const string ConfigKeyAutosetuprebase = (string) "autosetuprebase";

		/// <summary>The "autostash" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_AUTOSTASH']"
		[Register ("CONFIG_KEY_AUTOSTASH")]
		public const string ConfigKeyAutostash = (string) "autostash";

		/// <summary>The "bare" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_BARE']"
		[Register ("CONFIG_KEY_BARE")]
		public const string ConfigKeyBare = (string) "bare";

		/// <summary>The "blockLimit" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_BLOCK_LIMIT']"
		[Register ("CONFIG_KEY_BLOCK_LIMIT")]
		public const string ConfigKeyBlockLimit = (string) "blockLimit";

		/// <summary>The "blockSize" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_BLOCK_SIZE']"
		[Register ("CONFIG_KEY_BLOCK_SIZE")]
		public const string ConfigKeyBlockSize = (string) "blockSize";

		/// <summary>The "checkstat" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_CHECKSTAT']"
		[Register ("CONFIG_KEY_CHECKSTAT")]
		public const string ConfigKeyCheckstat = (string) "checkstat";

		/// <summary>The "compression" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_COMPRESSION']"
		[Register ("CONFIG_KEY_COMPRESSION")]
		public const string ConfigKeyCompression = (string) "compression";

		/// <summary>The "createchangeid" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_CREATECHANGEID']"
		[Register ("CONFIG_KEY_CREATECHANGEID")]
		public const string ConfigKeyCreatechangeid = (string) "createchangeid";

		/// <summary>The "defaultsourceref" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_DEFBRANCHSTARTPOINT']"
		[Register ("CONFIG_KEY_DEFBRANCHSTARTPOINT")]
		public const string ConfigKeyDefbranchstartpoint = (string) "defbranchstartpoint";

		/// <summary>The "deltaBaseCacheLimit" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_DELTA_BASE_CACHE_LIMIT']"
		[Register ("CONFIG_KEY_DELTA_BASE_CACHE_LIMIT")]
		public const string ConfigKeyDeltaBaseCacheLimit = (string) "deltaBaseCacheLimit";

		/// <summary>The "email" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_EMAIL']"
		[Register ("CONFIG_KEY_EMAIL")]
		public const string ConfigKeyEmail = (string) "email";

		/// <summary>The "excludesfile" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_EXCLUDESFILE']"
		[Register ("CONFIG_KEY_EXCLUDESFILE")]
		public const string ConfigKeyExcludesfile = (string) "excludesfile";

		/// <summary>The "false" key (used to configure <c>#CONFIG_KEY_AUTOSETUPMERGE</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_FALSE']"
		[Register ("CONFIG_KEY_FALSE")]
		public const string ConfigKeyFalse = (string) "false";

		/// <summary>The "ff" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_FF']"
		[Register ("CONFIG_KEY_FF")]
		public const string ConfigKeyFf = (string) "ff";

		/// <summary>The "filemode" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_FILEMODE']"
		[Register ("CONFIG_KEY_FILEMODE")]
		public const string ConfigKeyFilemode = (string) "filemode";

		/// <summary>The "hidedotfiles" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_HIDEDOTFILES']"
		[Register ("CONFIG_KEY_HIDEDOTFILES")]
		public const string ConfigKeyHidedotfiles = (string) "hidedotfiles";

		/// <summary>The "ignore" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_IGNORE']"
		[Register ("CONFIG_KEY_IGNORE")]
		public const string ConfigKeyIgnore = (string) "ignore";

		/// <summary>The "indexversion" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_INDEXVERSION']"
		[Register ("CONFIG_KEY_INDEXVERSION")]
		public const string ConfigKeyIndexversion = (string) "indexversion";

		/// <summary>The "local" key (used to configure <c>#CONFIG_KEY_AUTOSETUPREBASE</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_LOCAL']"
		[Register ("CONFIG_KEY_LOCAL")]
		public const string ConfigKeyLocal = (string) "local";

		/// <summary>The "logallrefupdates" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_LOGALLREFUPDATES']"
		[Register ("CONFIG_KEY_LOGALLREFUPDATES")]
		public const string ConfigKeyLogallrefupdates = (string) "logallrefupdates";

		/// <summary>The "merge" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_MERGE']"
		[Register ("CONFIG_KEY_MERGE")]
		public const string ConfigKeyMerge = (string) "merge";

		/// <summary>The "mergeoptions" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_MERGEOPTIONS']"
		[Register ("CONFIG_KEY_MERGEOPTIONS")]
		public const string ConfigKeyMergeoptions = (string) "mergeoptions";

		/// <summary>The "name" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_NAME']"
		[Register ("CONFIG_KEY_NAME")]
		public const string ConfigKeyName = (string) "name";

		/// <summary>The "never" key (used to configure <c>#CONFIG_KEY_AUTOSETUPREBASE</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_NEVER']"
		[Register ("CONFIG_KEY_NEVER")]
		public const string ConfigKeyNever = (string) "never";

		/// <summary>The "noprefix" key in the "diff section"</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_NOPREFIX']"
		[Register ("CONFIG_KEY_NOPREFIX")]
		public const string ConfigKeyNoprefix = (string) "noprefix";

		/// <summary>The "path" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_PATH']"
		[Register ("CONFIG_KEY_PATH")]
		public const string ConfigKeyPath = (string) "path";

		/// <summary>The "precomposeunicode" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_PRECOMPOSEUNICODE']"
		[Register ("CONFIG_KEY_PRECOMPOSEUNICODE")]
		public const string ConfigKeyPrecomposeunicode = (string) "precomposeunicode";

		/// <summary>The "prune" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_PRUNE']"
		[Register ("CONFIG_KEY_PRUNE")]
		public const string ConfigKeyPrune = (string) "prune";

		/// <summary>The "pruneexpire" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_PRUNEEXPIRE']"
		[Register ("CONFIG_KEY_PRUNEEXPIRE")]
		public const string ConfigKeyPruneexpire = (string) "pruneexpire";

		/// <summary>The "rebase" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_REBASE']"
		[Register ("CONFIG_KEY_REBASE")]
		public const string ConfigKeyRebase = (string) "rebase";

		/// <summary>The "remote" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_REMOTE']"
		[Register ("CONFIG_KEY_REMOTE")]
		public const string ConfigKeyRemote = (string) "remote";

		/// <summary>The "renamelimit" key in the "diff section"</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_RENAMELIMIT']"
		[Register ("CONFIG_KEY_RENAMELIMIT")]
		public const string ConfigKeyRenamelimit = (string) "renamelimit";

		/// <summary>The "renames" key in the "diff section"</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_RENAMES']"
		[Register ("CONFIG_KEY_RENAMES")]
		public const string ConfigKeyRenames = (string) "renames";

		/// <summary>The "repositoryformatversion" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_REPO_FORMAT_VERSION']"
		[Register ("CONFIG_KEY_REPO_FORMAT_VERSION")]
		public const string ConfigKeyRepoFormatVersion = (string) "repositoryformatversion";

		/// <summary>The "streamFileThreshold" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_STREAM_FILE_TRESHOLD']"
		[Register ("CONFIG_KEY_STREAM_FILE_TRESHOLD")]
		public const string ConfigKeyStreamFileTreshold = (string) "streamFileThreshold";

		/// <summary>The "symlinks" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_SYMLINKS']"
		[Register ("CONFIG_KEY_SYMLINKS")]
		public const string ConfigKeySymlinks = (string) "symlinks";

		/// <summary>The "true" key (used to configure <c>#CONFIG_KEY_AUTOSETUPMERGE</c></summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_TRUE']"
		[Register ("CONFIG_KEY_TRUE")]
		public const string ConfigKeyTrue = (string) "true";

		/// <summary>The "trustfolderstat" key in the "core section"</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_TRUSTFOLDERSTAT']"
		[Register ("CONFIG_KEY_TRUSTFOLDERSTAT")]
		public const string ConfigKeyTrustfolderstat = (string) "trustfolderstat";

		/// <summary>The "update" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_UPDATE']"
		[Register ("CONFIG_KEY_UPDATE")]
		public const string ConfigKeyUpdate = (string) "update";

		/// <summary>The "url" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_URL']"
		[Register ("CONFIG_KEY_URL")]
		public const string ConfigKeyUrl = (string) "url";

		/// <summary>The "worktree" key</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_KEY_WORKTREE']"
		[Register ("CONFIG_KEY_WORKTREE")]
		public const string ConfigKeyWorktree = (string) "worktree";

		/// <summary>The "pack" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_PACK_SECTION']"
		[Register ("CONFIG_PACK_SECTION")]
		public const string ConfigPackSection = (string) "pack";

		/// <summary>The "pull" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_PULL_SECTION']"
		[Register ("CONFIG_PULL_SECTION")]
		public const string ConfigPullSection = (string) "pull";

		/// <summary>The "rebase" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_REBASE_SECTION']"
		[Register ("CONFIG_REBASE_SECTION")]
		public const string ConfigRebaseSection = (string) "rebase";

		/// <summary>The "remote" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_REMOTE_SECTION']"
		[Register ("CONFIG_REMOTE_SECTION")]
		public const string ConfigRemoteSection = (string) "remote";

		/// <summary>A "renamelimit" value in the "diff section"</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_RENAMELIMIT_COPIES']"
		[Register ("CONFIG_RENAMELIMIT_COPIES")]
		public const string ConfigRenamelimitCopies = (string) "copies";

		/// <summary>A "renamelimit" value in the "diff section"</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_RENAMELIMIT_COPY']"
		[Register ("CONFIG_RENAMELIMIT_COPY")]
		public const string ConfigRenamelimitCopy = (string) "copy";

		/// <summary>The "submodule" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_SUBMODULE_SECTION']"
		[Register ("CONFIG_SUBMODULE_SECTION")]
		public const string ConfigSubmoduleSection = (string) "submodule";

		/// <summary>The "user" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_USER_SECTION']"
		[Register ("CONFIG_USER_SECTION")]
		public const string ConfigUserSection = (string) "user";

		/// <summary>The "workflow" section</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/field[@name='CONFIG_WORKFLOW_SECTION']"
		[Register ("CONFIG_WORKFLOW_SECTION")]
		public const string ConfigWorkflowSection = (string) "workflow";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/ConfigConstants", typeof (ConfigConstants));

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

		protected ConfigConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='ConfigConstants']/constructor[@name='ConfigConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConfigConstants () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
