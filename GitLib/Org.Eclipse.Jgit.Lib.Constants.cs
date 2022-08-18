using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Lib {

	/// <summary>Misc.</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/lib/Constants", DoNotGenerateAcw=true)]
	public sealed partial class Constants : global::Java.Lang.Object {
		/// <summary>Native character encoding for commit messages, file names.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='CHARACTER_ENCODING']"
		[Register ("CHARACTER_ENCODING")]
		public const string CharacterEncoding = (string) "UTF-8";


		/// <summary>Native character encoding for commit messages, file names.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='CHARSET']"
		[Register ("CHARSET")]
		public static global::Java.Nio.Charset.Charset Charset {
			get {
				const string __id = "CHARSET.Ljava/nio/charset/Charset;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>name of the file containing the ID of a cherry pick commit in case of conflicts</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='CHERRY_PICK_HEAD']"
		[Register ("CHERRY_PICK_HEAD")]
		public const string CherryPickHead = (string) "CHERRY_PICK_HEAD";

		/// <summary>Default name for the Git repository configuration</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='CONFIG']"
		[Register ("CONFIG")]
		public const string Config = (string) "config";

		/// <summary>Default remote name used by clone, push and fetch operations</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='DEFAULT_REMOTE_NAME']"
		[Register ("DEFAULT_REMOTE_NAME")]
		public const string DefaultRemoteName = (string) "origin";

		/// <summary>Default name for the Git repository directory</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='DOT_GIT']"
		[Register ("DOT_GIT")]
		public const string DotGit = (string) ".git";

		/// <summary>Name of the attributes file</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='DOT_GIT_ATTRIBUTES']"
		[Register ("DOT_GIT_ATTRIBUTES")]
		public const string DotGitAttributes = (string) ".gitattributes";

		/// <summary>A bare repository typically ends with this string</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='DOT_GIT_EXT']"
		[Register ("DOT_GIT_EXT")]
		public const string DotGitExt = (string) ".git";

		/// <summary>Name of the ignore file</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='DOT_GIT_IGNORE']"
		[Register ("DOT_GIT_IGNORE")]
		public const string DotGitIgnore = (string) ".gitignore";

		/// <summary>Name of the submodules file</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='DOT_GIT_MODULES']"
		[Register ("DOT_GIT_MODULES")]
		public const string DotGitModules = (string) ".gitmodules";


		/// <summary>objectid for the empty blob</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='EMPTY_BLOB_ID']"
		[Register ("EMPTY_BLOB_ID")]
		public static global::Org.Eclipse.Jgit.Lib.ObjectId EmptyBlobId {
			get {
				const string __id = "EMPTY_BLOB_ID.Lorg/eclipse/jgit/lib/ObjectId;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Lib.ObjectId> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>Special name for the "FETCH_HEAD" symbolic-ref.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='FETCH_HEAD']"
		[Register ("FETCH_HEAD")]
		public const string FetchHead = (string) "FETCH_HEAD";

		/// <summary>Prefix of the first line in a ".</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GITDIR']"
		[Register ("GITDIR")]
		public const string Gitdir = (string) "gitdir: ";

		/// <summary>A gitignore file name</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GITIGNORE_FILENAME']"
		[Register ("GITIGNORE_FILENAME")]
		public const string GitignoreFilename = (string) ".gitignore";

		/// <summary>The environment variable that tells us where to look for objects, besides
		/// the default objects directory.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_ALTERNATE_OBJECT_DIRECTORIES_KEY']"
		[Register ("GIT_ALTERNATE_OBJECT_DIRECTORIES_KEY")]
		public const string GitAlternateObjectDirectoriesKey = (string) "GIT_ALTERNATE_OBJECT_DIRECTORIES";

		/// <summary>The environment variable that contains the author's email</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_AUTHOR_EMAIL_KEY']"
		[Register ("GIT_AUTHOR_EMAIL_KEY")]
		public const string GitAuthorEmailKey = (string) "GIT_AUTHOR_EMAIL";

		/// <summary>The environment variable that contains the author's name</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_AUTHOR_NAME_KEY']"
		[Register ("GIT_AUTHOR_NAME_KEY")]
		public const string GitAuthorNameKey = (string) "GIT_AUTHOR_NAME";

		/// <summary>The environment variable that limits how close to the root of the file
		/// systems JGit will traverse when looking for a repository root.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_CEILING_DIRECTORIES_KEY']"
		[Register ("GIT_CEILING_DIRECTORIES_KEY")]
		public const string GitCeilingDirectoriesKey = (string) "GIT_CEILING_DIRECTORIES";

		/// <summary>The environment variable that contains the commiter's email</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_COMMITTER_EMAIL_KEY']"
		[Register ("GIT_COMMITTER_EMAIL_KEY")]
		public const string GitCommitterEmailKey = (string) "GIT_COMMITTER_EMAIL";

		/// <summary>The environment variable that contains the commiter's name</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_COMMITTER_NAME_KEY']"
		[Register ("GIT_COMMITTER_NAME_KEY")]
		public const string GitCommitterNameKey = (string) "GIT_COMMITTER_NAME";

		/// <summary>The environment variable that blocks use of the system config file</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_CONFIG_NOSYSTEM_KEY']"
		[Register ("GIT_CONFIG_NOSYSTEM_KEY")]
		public const string GitConfigNosystemKey = (string) "GIT_CONFIG_NOSYSTEM";

		/// <summary>The environment variable that tells us which directory is the ".</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_DIR_KEY']"
		[Register ("GIT_DIR_KEY")]
		public const string GitDirKey = (string) "GIT_DIR";

		/// <summary>The environment variable that tells us which file holds the Git index.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_INDEX_FILE_KEY']"
		[Register ("GIT_INDEX_FILE_KEY")]
		public const string GitIndexFileKey = (string) "GIT_INDEX_FILE";

		/// <summary>The environment variable that tells us where objects are stored</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_OBJECT_DIRECTORY_KEY']"
		[Register ("GIT_OBJECT_DIRECTORY_KEY")]
		public const string GitObjectDirectoryKey = (string) "GIT_OBJECT_DIRECTORY";

		/// <summary>The environment variable that tells us which directory is the working
		/// directory.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='GIT_WORK_TREE_KEY']"
		[Register ("GIT_WORK_TREE_KEY")]
		public const string GitWorkTreeKey = (string) "GIT_WORK_TREE";

		/// <summary>Special name for the "HEAD" symbolic-ref.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='HEAD']"
		[Register ("HEAD")]
		public const string Head = (string) "HEAD";

		/// <summary>Name of the folder (inside gitDir) where the hooks are stored.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='HOOKS']"
		[Register ("HOOKS")]
		public const string Hooks = (string) "hooks";

		/// <summary>Excludes-file</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='INFO_EXCLUDE']"
		[Register ("INFO_EXCLUDE")]
		public const string InfoExclude = (string) "info/exclude";

		/// <summary>Info refs folder</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='INFO_REFS']"
		[Register ("INFO_REFS")]
		public const string InfoRefs = (string) "info/refs";

		/// <summary>Logs folder name</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='LOGS']"
		[Register ("LOGS")]
		public const string Logs = (string) "logs";

		/// <summary>Default main branch name</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='MASTER']"
		[Register ("MASTER")]
		public const string Master = (string) "master";

		/// <summary>name of the file containing the IDs of the parents of a merge commit</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='MERGE_HEAD']"
		[Register ("MERGE_HEAD")]
		public const string MergeHead = (string) "MERGE_HEAD";

		/// <summary>name of the file containing the commit msg for a merge commit</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='MERGE_MSG']"
		[Register ("MERGE_MSG")]
		public const string MergeMsg = (string) "MERGE_MSG";

		/// <summary>Name of the folder (inside gitDir) where submodules are stored</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='MODULES']"
		[Register ("MODULES")]
		public const string Modules = (string) "modules";

		/// <summary>A Git object hash is 160 bits, i.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJECT_ID_LENGTH']"
		[Register ("OBJECT_ID_LENGTH")]
		public const int ObjectIdLength = (int) 20;

		/// <summary>A Git object can be expressed as a 40 character string of hexadecimal
		/// digits.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJECT_ID_STRING_LENGTH']"
		[Register ("OBJECT_ID_STRING_LENGTH")]
		public const int ObjectIdStringLength = (int) 40;

		/// <summary>An unknown or invalid object type code.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJ_BAD']"
		[Register ("OBJ_BAD")]
		public const int ObjBad = (int) -1;

		/// <summary>In-pack object type: blob.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJ_BLOB']"
		[Register ("OBJ_BLOB")]
		public const int ObjBlob = (int) 3;

		/// <summary>In-pack object type: commit.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJ_COMMIT']"
		[Register ("OBJ_COMMIT")]
		public const int ObjCommit = (int) 1;

		/// <summary>In-pack object type: extended types.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJ_EXT']"
		[Register ("OBJ_EXT")]
		public const int ObjExt = (int) 0;

		/// <summary>In-pack object type: offset delta</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJ_OFS_DELTA']"
		[Register ("OBJ_OFS_DELTA")]
		public const int ObjOfsDelta = (int) 6;

		/// <summary>In-pack object type: reference delta</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJ_REF_DELTA']"
		[Register ("OBJ_REF_DELTA")]
		public const int ObjRefDelta = (int) 7;

		/// <summary>In-pack object type: annotated tag.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJ_TAG']"
		[Register ("OBJ_TAG")]
		public const int ObjTag = (int) 4;

		/// <summary>In-pack object type: tree.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJ_TREE']"
		[Register ("OBJ_TREE")]
		public const int ObjTree = (int) 2;

		/// <summary>In-pack object type: reserved for future use.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OBJ_TYPE_5']"
		[Register ("OBJ_TYPE_5")]
		public const int ObjType5 = (int) 5;

		/// <summary>name of the ref ORIG_HEAD used by certain commands to store the original
		/// value of HEAD</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='ORIG_HEAD']"
		[Register ("ORIG_HEAD")]
		public const string OrigHead = (string) "ORIG_HEAD";

		/// <summary>The system property that contains the system user name</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OS_USER_DIR']"
		[Register ("OS_USER_DIR")]
		public const string OsUserDir = (string) "user.dir";

		/// <summary>The system property that contains the system user name</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='OS_USER_NAME_KEY']"
		[Register ("OS_USER_NAME_KEY")]
		public const string OsUserNameKey = (string) "user.name";

		/// <summary>Packed refs file</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='PACKED_REFS']"
		[Register ("PACKED_REFS")]
		public const string PackedRefs = (string) "packed-refs";


		/// <summary>Pack file signature that occurs at file header - identifies file as Git
		/// packfile formatted.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='PACK_SIGNATURE']"
		[Register ("PACK_SIGNATURE")]
		public static IList<byte> PackSignature {
			get {
				const string __id = "PACK_SIGNATURE.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		/// <summary>name of the file containing the ID of a revert commit in case of conflicts</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='REVERT_HEAD']"
		[Register ("REVERT_HEAD")]
		public const string RevertHead = (string) "REVERT_HEAD";

		/// <summary>Prefix for branch refs</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='R_HEADS']"
		[Register ("R_HEADS")]
		public const string RHeads = (string) "refs/heads/";

		/// <summary>Prefix for notes refs</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='R_NOTES']"
		[Register ("R_NOTES")]
		public const string RNotes = (string) "refs/notes/";

		/// <summary>Standard notes ref</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='R_NOTES_COMMITS']"
		[Register ("R_NOTES_COMMITS")]
		public const string RNotesCommits = (string) "refs/notes/commits";

		/// <summary>Prefix for any ref</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='R_REFS']"
		[Register ("R_REFS")]
		public const string RRefs = (string) "refs/";

		/// <summary>Prefix for remotes refs</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='R_REMOTES']"
		[Register ("R_REMOTES")]
		public const string RRemotes = (string) "refs/remotes/";

		/// <summary>Standard stash ref</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='R_STASH']"
		[Register ("R_STASH")]
		public const string RStash = (string) "refs/stash";

		/// <summary>Prefix for tag refs</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='R_TAGS']"
		[Register ("R_TAGS")]
		public const string RTags = (string) "refs/tags/";

		/// <summary>Name of the .</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='SHALLOW']"
		[Register ("SHALLOW")]
		public const string Shallow = (string) "shallow";

		/// <summary>Beginning of the common "Signed-off-by: " commit message line</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='SIGNED_OFF_BY_TAG']"
		[Register ("SIGNED_OFF_BY_TAG")]
		public const string SignedOffByTag = (string) "Signed-off-by: ";

		/// <summary>name of the file containing the commit msg for a squash commit</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='SQUASH_MSG']"
		[Register ("SQUASH_MSG")]
		public const string SquashMsg = (string) "SQUASH_MSG";

		/// <summary>Default stash branch name</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='STASH']"
		[Register ("STASH")]
		public const string Stash = (string) "stash";

		/// <summary>Text string that identifies an object as a blob.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='TYPE_BLOB']"
		[Register ("TYPE_BLOB")]
		public const string TypeBlob = (string) "blob";

		/// <summary>Text string that identifies an object as a commit.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='TYPE_COMMIT']"
		[Register ("TYPE_COMMIT")]
		public const string TypeCommit = (string) "commit";

		/// <summary>Text string that identifies an object as an annotated tag.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='TYPE_TAG']"
		[Register ("TYPE_TAG")]
		public const string TypeTag = (string) "tag";

		/// <summary>Text string that identifies an object as a tree.</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='TYPE_TREE']"
		[Register ("TYPE_TREE")]
		public const string TypeTree = (string) "tree";

		/// <summary>Default value for the user name if no other information is available</summary>
		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/field[@name='UNKNOWN_USER_DEFAULT']"
		[Register ("UNKNOWN_USER_DEFAULT")]
		public const string UnknownUserDefault = (string) "unknown-user";

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/lib/Constants", typeof (Constants));

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

		internal Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		/// <param name="id">object id this type string came from; may be null if that is
		///            not known at the time the parse is occurring.</param>
		/// <param name="typeString">string version of the type code.</param>
		/// <param name="endMark">character immediately following the type string. Usually ' '
		///            (space) or '\n' (line feed).</param>
		/// <param name="offset">position within &lt;code&gt;typeString&lt;/code&gt; where the parse
		///            should start. Updated with the new position (just past
		///            &lt;code&gt;endMark&lt;/code&gt; when the parse is successful.</param>
		/// <summary>Parse an encoded type string into a type constant.</summary>
		/// <returns>a type code constant (one of <c>#OBJ_BLOB</c>,
		///         <c>#OBJ_COMMIT</c>, <c>#OBJ_TAG</c>, <c>#OBJ_TREE</c>.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/method[@name='decodeTypeString' and count(parameter)=4 and parameter[1][@type='org.eclipse.jgit.lib.AnyObjectId'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte'] and parameter[4][@type='org.eclipse.jgit.util.MutableInteger']]"
		[Register ("decodeTypeString", "(Lorg/eclipse/jgit/lib/AnyObjectId;[BBLorg/eclipse/jgit/util/MutableInteger;)I", "")]
		public static unsafe int DecodeTypeString (global::Org.Eclipse.Jgit.Lib.AnyObjectId id, byte[] typeString, sbyte endMark, global::Org.Eclipse.Jgit.Util.MutableInteger offset)
		{
			const string __id = "decodeTypeString.(Lorg/eclipse/jgit/lib/AnyObjectId;[BBLorg/eclipse/jgit/util/MutableInteger;)I";
			IntPtr native_typeString = JNIEnv.NewArray (typeString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [1] = new JniArgumentValue (native_typeString);
				__args [2] = new JniArgumentValue (endMark);
				__args [3] = new JniArgumentValue ((offset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) offset).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (typeString != null) {
					JNIEnv.CopyArray (native_typeString, typeString);
					JNIEnv.DeleteLocalRef (native_typeString);
				}
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (typeString);
				global::System.GC.KeepAlive (offset);
			}
		}

		/// <param name="str">the string to convert. May contain any Unicode characters.</param>
		/// <summary>Convert a string to a byte array in the standard character encoding.</summary>
		/// <returns>a byte array representing the requested string, encoded using the
		///         default character encoding (UTF-8).</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Encode (string str)
		{
			const string __id = "encode.(Ljava/lang/String;)[B";
			IntPtr native_str = JNIEnv.NewString ((string)str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		/// <param name="s">the string to convert. Must not contain any characters over
		///            127 (outside of 7-bit ASCII).</param>
		/// <summary>Convert a string to US-ASCII encoding.</summary>
		/// <returns>a byte array of the same length as the input string, holding the
		///         same characters, in the same order.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/method[@name='encodeASCII' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeASCII", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] EncodeASCII (string s)
		{
			const string __id = "encodeASCII.(Ljava/lang/String;)[B";
			IntPtr native_s = JNIEnv.NewString ((string)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		/// <param name="s">the integer to convert.</param>
		/// <summary>Convert an integer into its decimal representation.</summary>
		/// <returns>a decimal representation of the input integer. The returned array
		///         is the smallest array that will hold the value.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/method[@name='encodeASCII' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("encodeASCII", "(J)[B", "")]
		public static unsafe byte[] EncodeASCII (long s)
		{
			const string __id = "encodeASCII.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		/// <param name="typeCode">the type code, from a pack representation.</param>
		/// <summary>Convert an OBJ_* type constant to an ASCII encoded string constant.</summary>
		/// <returns>the canonical ASCII encoded name of this type.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/method[@name='encodedTypeString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("encodedTypeString", "(I)[B", "")]
		public static unsafe byte[] EncodedTypeString (int typeCode)
		{
			const string __id = "encodedTypeString.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (typeCode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		/// <summary>Create a new digest function for objects.</summary>
		/// <returns>a new digest object.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/method[@name='newMessageDigest' and count(parameter)=0]"
		[Register ("newMessageDigest", "()Ljava/security/MessageDigest;", "")]
		public static unsafe global::Java.Security.MessageDigest NewMessageDigest ()
		{
			const string __id = "newMessageDigest.()Ljava/security/MessageDigest;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		/// <param name="typeCode">the type code, from a pack representation.</param>
		/// <summary>Convert an OBJ_* type constant to a TYPE_* type constant.</summary>
		/// <returns>the canonical string name of this type.</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.lib']/class[@name='Constants']/method[@name='typeString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("typeString", "(I)Ljava/lang/String;", "")]
		public static unsafe string TypeString (int typeCode)
		{
			const string __id = "typeString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (typeCode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
