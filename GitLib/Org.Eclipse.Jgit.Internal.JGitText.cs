using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Jgit.Internal {

	/// <summary>Translation bundle for JGit core</summary>
	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']"
	[global::Android.Runtime.Register ("org/eclipse/jgit/internal/JGitText", DoNotGenerateAcw=true)]
	public partial class JGitText : global::Org.Eclipse.Jgit.Nls.TranslationBundle {

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='abbreviationLengthMustBeNonNegative']"
		[Register ("abbreviationLengthMustBeNonNegative")]
		public string AbbreviationLengthMustBeNonNegative {
			get {
				const string __id = "abbreviationLengthMustBeNonNegative.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "abbreviationLengthMustBeNonNegative.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='abortingRebase']"
		[Register ("abortingRebase")]
		public string AbortingRebase {
			get {
				const string __id = "abortingRebase.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "abortingRebase.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='abortingRebaseFailed']"
		[Register ("abortingRebaseFailed")]
		public string AbortingRebaseFailed {
			get {
				const string __id = "abortingRebaseFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "abortingRebaseFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='abortingRebaseFailedNoOrigHead']"
		[Register ("abortingRebaseFailedNoOrigHead")]
		public string AbortingRebaseFailedNoOrigHead {
			get {
				const string __id = "abortingRebaseFailedNoOrigHead.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "abortingRebaseFailedNoOrigHead.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='advertisementCameBefore']"
		[Register ("advertisementCameBefore")]
		public string AdvertisementCameBefore {
			get {
				const string __id = "advertisementCameBefore.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "advertisementCameBefore.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='advertisementOfCameBefore']"
		[Register ("advertisementOfCameBefore")]
		public string AdvertisementOfCameBefore {
			get {
				const string __id = "advertisementOfCameBefore.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "advertisementOfCameBefore.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='amazonS3ActionFailed']"
		[Register ("amazonS3ActionFailed")]
		public string AmazonS3ActionFailed {
			get {
				const string __id = "amazonS3ActionFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "amazonS3ActionFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='amazonS3ActionFailedGivingUp']"
		[Register ("amazonS3ActionFailedGivingUp")]
		public string AmazonS3ActionFailedGivingUp {
			get {
				const string __id = "amazonS3ActionFailedGivingUp.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "amazonS3ActionFailedGivingUp.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='ambiguousObjectAbbreviation']"
		[Register ("ambiguousObjectAbbreviation")]
		public string AmbiguousObjectAbbreviation {
			get {
				const string __id = "ambiguousObjectAbbreviation.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "ambiguousObjectAbbreviation.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='aNewObjectIdIsRequired']"
		[Register ("aNewObjectIdIsRequired")]
		public string ANewObjectIdIsRequired {
			get {
				const string __id = "aNewObjectIdIsRequired.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "aNewObjectIdIsRequired.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='anExceptionOccurredWhileTryingToAddTheIdOfHEAD']"
		[Register ("anExceptionOccurredWhileTryingToAddTheIdOfHEAD")]
		public string AnExceptionOccurredWhileTryingToAddTheIdOfHEAD {
			get {
				const string __id = "anExceptionOccurredWhileTryingToAddTheIdOfHEAD.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "anExceptionOccurredWhileTryingToAddTheIdOfHEAD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='anSSHSessionHasBeenAlreadyCreated']"
		[Register ("anSSHSessionHasBeenAlreadyCreated")]
		public string AnSSHSessionHasBeenAlreadyCreated {
			get {
				const string __id = "anSSHSessionHasBeenAlreadyCreated.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "anSSHSessionHasBeenAlreadyCreated.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='applyingCommit']"
		[Register ("applyingCommit")]
		public string ApplyingCommit {
			get {
				const string __id = "applyingCommit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "applyingCommit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='archiveFormatAlreadyAbsent']"
		[Register ("archiveFormatAlreadyAbsent")]
		public string ArchiveFormatAlreadyAbsent {
			get {
				const string __id = "archiveFormatAlreadyAbsent.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "archiveFormatAlreadyAbsent.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='archiveFormatAlreadyRegistered']"
		[Register ("archiveFormatAlreadyRegistered")]
		public string ArchiveFormatAlreadyRegistered {
			get {
				const string __id = "archiveFormatAlreadyRegistered.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "archiveFormatAlreadyRegistered.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='argumentIsNotAValidCommentString']"
		[Register ("argumentIsNotAValidCommentString")]
		public string ArgumentIsNotAValidCommentString {
			get {
				const string __id = "argumentIsNotAValidCommentString.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "argumentIsNotAValidCommentString.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='atLeastOnePathIsRequired']"
		[Register ("atLeastOnePathIsRequired")]
		public string AtLeastOnePathIsRequired {
			get {
				const string __id = "atLeastOnePathIsRequired.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "atLeastOnePathIsRequired.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='atLeastOnePatternIsRequired']"
		[Register ("atLeastOnePatternIsRequired")]
		public string AtLeastOnePatternIsRequired {
			get {
				const string __id = "atLeastOnePatternIsRequired.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "atLeastOnePatternIsRequired.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='atLeastTwoFiltersNeeded']"
		[Register ("atLeastTwoFiltersNeeded")]
		public string AtLeastTwoFiltersNeeded {
			get {
				const string __id = "atLeastTwoFiltersNeeded.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "atLeastTwoFiltersNeeded.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='authenticationNotSupported']"
		[Register ("authenticationNotSupported")]
		public string AuthenticationNotSupported {
			get {
				const string __id = "authenticationNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "authenticationNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='badBase64InputCharacterAt']"
		[Register ("badBase64InputCharacterAt")]
		public string BadBase64InputCharacterAt {
			get {
				const string __id = "badBase64InputCharacterAt.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "badBase64InputCharacterAt.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='badEntryDelimiter']"
		[Register ("badEntryDelimiter")]
		public string BadEntryDelimiter {
			get {
				const string __id = "badEntryDelimiter.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "badEntryDelimiter.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='badEntryName']"
		[Register ("badEntryName")]
		public string BadEntryName {
			get {
				const string __id = "badEntryName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "badEntryName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='badEscape']"
		[Register ("badEscape")]
		public string BadEscape {
			get {
				const string __id = "badEscape.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "badEscape.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='badGroupHeader']"
		[Register ("badGroupHeader")]
		public string BadGroupHeader {
			get {
				const string __id = "badGroupHeader.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "badGroupHeader.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='badObjectType']"
		[Register ("badObjectType")]
		public string BadObjectType {
			get {
				const string __id = "badObjectType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "badObjectType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='badSectionEntry']"
		[Register ("badSectionEntry")]
		public string BadSectionEntry {
			get {
				const string __id = "badSectionEntry.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "badSectionEntry.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='bareRepositoryNoWorkdirAndIndex']"
		[Register ("bareRepositoryNoWorkdirAndIndex")]
		public string BareRepositoryNoWorkdirAndIndex {
			get {
				const string __id = "bareRepositoryNoWorkdirAndIndex.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "bareRepositoryNoWorkdirAndIndex.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='base64InputNotProperlyPadded']"
		[Register ("base64InputNotProperlyPadded")]
		public string Base64InputNotProperlyPadded {
			get {
				const string __id = "base64InputNotProperlyPadded.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "base64InputNotProperlyPadded.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='baseLengthIncorrect']"
		[Register ("baseLengthIncorrect")]
		public string BaseLengthIncorrect {
			get {
				const string __id = "baseLengthIncorrect.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "baseLengthIncorrect.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='bitmapMissingObject']"
		[Register ("bitmapMissingObject")]
		public string BitmapMissingObject {
			get {
				const string __id = "bitmapMissingObject.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "bitmapMissingObject.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='bitmapsMustBePrepared']"
		[Register ("bitmapsMustBePrepared")]
		public string BitmapsMustBePrepared {
			get {
				const string __id = "bitmapsMustBePrepared.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "bitmapsMustBePrepared.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='blameNotCommittedYet']"
		[Register ("blameNotCommittedYet")]
		public string BlameNotCommittedYet {
			get {
				const string __id = "blameNotCommittedYet.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "blameNotCommittedYet.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='blobNotFound']"
		[Register ("blobNotFound")]
		public string BlobNotFound {
			get {
				const string __id = "blobNotFound.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "blobNotFound.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='blobNotFoundForPath']"
		[Register ("blobNotFoundForPath")]
		public string BlobNotFoundForPath {
			get {
				const string __id = "blobNotFoundForPath.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "blobNotFoundForPath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='branchNameInvalid']"
		[Register ("branchNameInvalid")]
		public string BranchNameInvalid {
			get {
				const string __id = "branchNameInvalid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "branchNameInvalid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='buildingBitmaps']"
		[Register ("buildingBitmaps")]
		public string BuildingBitmaps {
			get {
				const string __id = "buildingBitmaps.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "buildingBitmaps.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cachedPacksPreventsIndexCreation']"
		[Register ("cachedPacksPreventsIndexCreation")]
		public string CachedPacksPreventsIndexCreation {
			get {
				const string __id = "cachedPacksPreventsIndexCreation.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cachedPacksPreventsIndexCreation.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cachedPacksPreventsListingObjects']"
		[Register ("cachedPacksPreventsListingObjects")]
		public string CachedPacksPreventsListingObjects {
			get {
				const string __id = "cachedPacksPreventsListingObjects.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cachedPacksPreventsListingObjects.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotBeCombined']"
		[Register ("cannotBeCombined")]
		public string CannotBeCombined {
			get {
				const string __id = "cannotBeCombined.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotBeCombined.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotBeRecursiveWhenTreesAreIncluded']"
		[Register ("cannotBeRecursiveWhenTreesAreIncluded")]
		public string CannotBeRecursiveWhenTreesAreIncluded {
			get {
				const string __id = "cannotBeRecursiveWhenTreesAreIncluded.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotBeRecursiveWhenTreesAreIncluded.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotChangeActionOnComment']"
		[Register ("cannotChangeActionOnComment")]
		public string CannotChangeActionOnComment {
			get {
				const string __id = "cannotChangeActionOnComment.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotChangeActionOnComment.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotChangeToComment']"
		[Register ("cannotChangeToComment")]
		public string CannotChangeToComment {
			get {
				const string __id = "cannotChangeToComment.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotChangeToComment.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotCombineSquashWithNoff']"
		[Register ("cannotCombineSquashWithNoff")]
		public string CannotCombineSquashWithNoff {
			get {
				const string __id = "cannotCombineSquashWithNoff.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotCombineSquashWithNoff.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotCombineTreeFilterWithRevFilter']"
		[Register ("cannotCombineTreeFilterWithRevFilter")]
		public string CannotCombineTreeFilterWithRevFilter {
			get {
				const string __id = "cannotCombineTreeFilterWithRevFilter.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotCombineTreeFilterWithRevFilter.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotCommitOnARepoWithState']"
		[Register ("cannotCommitOnARepoWithState")]
		public string CannotCommitOnARepoWithState {
			get {
				const string __id = "cannotCommitOnARepoWithState.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotCommitOnARepoWithState.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotCommitWriteTo']"
		[Register ("cannotCommitWriteTo")]
		public string CannotCommitWriteTo {
			get {
				const string __id = "cannotCommitWriteTo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotCommitWriteTo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotConnectPipes']"
		[Register ("cannotConnectPipes")]
		public string CannotConnectPipes {
			get {
				const string __id = "cannotConnectPipes.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotConnectPipes.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotConvertScriptToText']"
		[Register ("cannotConvertScriptToText")]
		public string CannotConvertScriptToText {
			get {
				const string __id = "cannotConvertScriptToText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotConvertScriptToText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotCreateConfig']"
		[Register ("cannotCreateConfig")]
		public string CannotCreateConfig {
			get {
				const string __id = "cannotCreateConfig.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotCreateConfig.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotCreateDirectory']"
		[Register ("cannotCreateDirectory")]
		public string CannotCreateDirectory {
			get {
				const string __id = "cannotCreateDirectory.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotCreateDirectory.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotCreateHEAD']"
		[Register ("cannotCreateHEAD")]
		public string CannotCreateHEAD {
			get {
				const string __id = "cannotCreateHEAD.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotCreateHEAD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotCreateIndexfile']"
		[Register ("cannotCreateIndexfile")]
		public string CannotCreateIndexfile {
			get {
				const string __id = "cannotCreateIndexfile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotCreateIndexfile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotCreateTempDir']"
		[Register ("cannotCreateTempDir")]
		public string CannotCreateTempDir {
			get {
				const string __id = "cannotCreateTempDir.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotCreateTempDir.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotDeleteCheckedOutBranch']"
		[Register ("cannotDeleteCheckedOutBranch")]
		public string CannotDeleteCheckedOutBranch {
			get {
				const string __id = "cannotDeleteCheckedOutBranch.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotDeleteCheckedOutBranch.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotDeleteFile']"
		[Register ("cannotDeleteFile")]
		public string CannotDeleteFile {
			get {
				const string __id = "cannotDeleteFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotDeleteFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotDeleteStaleTrackingRef']"
		[Register ("cannotDeleteStaleTrackingRef")]
		public string CannotDeleteStaleTrackingRef {
			get {
				const string __id = "cannotDeleteStaleTrackingRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotDeleteStaleTrackingRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotDeleteStaleTrackingRef2']"
		[Register ("cannotDeleteStaleTrackingRef2")]
		public string CannotDeleteStaleTrackingRef2 {
			get {
				const string __id = "cannotDeleteStaleTrackingRef2.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotDeleteStaleTrackingRef2.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotDetermineProxyFor']"
		[Register ("cannotDetermineProxyFor")]
		public string CannotDetermineProxyFor {
			get {
				const string __id = "cannotDetermineProxyFor.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotDetermineProxyFor.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotDownload']"
		[Register ("cannotDownload")]
		public string CannotDownload {
			get {
				const string __id = "cannotDownload.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotDownload.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotExecute']"
		[Register ("cannotExecute")]
		public string CannotExecute {
			get {
				const string __id = "cannotExecute.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotExecute.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotGet']"
		[Register ("cannotGet")]
		public string CannotGet {
			get {
				const string __id = "cannotGet.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotGet.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotListRefs']"
		[Register ("cannotListRefs")]
		public string CannotListRefs {
			get {
				const string __id = "cannotListRefs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotListRefs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotLock']"
		[Register ("cannotLock")]
		public string CannotLock {
			get {
				const string __id = "cannotLock.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotLock.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotLockPackIn']"
		[Register ("cannotLockPackIn")]
		public string CannotLockPackIn {
			get {
				const string __id = "cannotLockPackIn.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotLockPackIn.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotMatchOnEmptyString']"
		[Register ("cannotMatchOnEmptyString")]
		public string CannotMatchOnEmptyString {
			get {
				const string __id = "cannotMatchOnEmptyString.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotMatchOnEmptyString.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotMoveIndexTo']"
		[Register ("cannotMoveIndexTo")]
		public string CannotMoveIndexTo {
			get {
				const string __id = "cannotMoveIndexTo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotMoveIndexTo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotMovePackTo']"
		[Register ("cannotMovePackTo")]
		public string CannotMovePackTo {
			get {
				const string __id = "cannotMovePackTo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotMovePackTo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotOpenService']"
		[Register ("cannotOpenService")]
		public string CannotOpenService {
			get {
				const string __id = "cannotOpenService.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotOpenService.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotParseDate']"
		[Register ("cannotParseDate")]
		public string CannotParseDate {
			get {
				const string __id = "cannotParseDate.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotParseDate.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotParseGitURIish']"
		[Register ("cannotParseGitURIish")]
		public string CannotParseGitURIish {
			get {
				const string __id = "cannotParseGitURIish.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotParseGitURIish.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotPullOnARepoWithState']"
		[Register ("cannotPullOnARepoWithState")]
		public string CannotPullOnARepoWithState {
			get {
				const string __id = "cannotPullOnARepoWithState.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotPullOnARepoWithState.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotRead']"
		[Register ("cannotRead")]
		public string CannotRead {
			get {
				const string __id = "cannotRead.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotRead.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotReadBlob']"
		[Register ("cannotReadBlob")]
		public string CannotReadBlob {
			get {
				const string __id = "cannotReadBlob.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotReadBlob.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotReadCommit']"
		[Register ("cannotReadCommit")]
		public string CannotReadCommit {
			get {
				const string __id = "cannotReadCommit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotReadCommit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotReadFile']"
		[Register ("cannotReadFile")]
		public string CannotReadFile {
			get {
				const string __id = "cannotReadFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotReadFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotReadHEAD']"
		[Register ("cannotReadHEAD")]
		public string CannotReadHEAD {
			get {
				const string __id = "cannotReadHEAD.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotReadHEAD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotReadObject']"
		[Register ("cannotReadObject")]
		public string CannotReadObject {
			get {
				const string __id = "cannotReadObject.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotReadObject.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotReadTree']"
		[Register ("cannotReadTree")]
		public string CannotReadTree {
			get {
				const string __id = "cannotReadTree.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotReadTree.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotRebaseWithoutCurrentHead']"
		[Register ("cannotRebaseWithoutCurrentHead")]
		public string CannotRebaseWithoutCurrentHead {
			get {
				const string __id = "cannotRebaseWithoutCurrentHead.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotRebaseWithoutCurrentHead.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotResolveLocalTrackingRefForUpdating']"
		[Register ("cannotResolveLocalTrackingRefForUpdating")]
		public string CannotResolveLocalTrackingRefForUpdating {
			get {
				const string __id = "cannotResolveLocalTrackingRefForUpdating.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotResolveLocalTrackingRefForUpdating.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotSquashFixupWithoutPreviousCommit']"
		[Register ("cannotSquashFixupWithoutPreviousCommit")]
		public string CannotSquashFixupWithoutPreviousCommit {
			get {
				const string __id = "cannotSquashFixupWithoutPreviousCommit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotSquashFixupWithoutPreviousCommit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotStoreObjects']"
		[Register ("cannotStoreObjects")]
		public string CannotStoreObjects {
			get {
				const string __id = "cannotStoreObjects.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotStoreObjects.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotUnloadAModifiedTree']"
		[Register ("cannotUnloadAModifiedTree")]
		public string CannotUnloadAModifiedTree {
			get {
				const string __id = "cannotUnloadAModifiedTree.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotUnloadAModifiedTree.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cannotWorkWithOtherStagesThanZeroRightNow']"
		[Register ("cannotWorkWithOtherStagesThanZeroRightNow")]
		public string CannotWorkWithOtherStagesThanZeroRightNow {
			get {
				const string __id = "cannotWorkWithOtherStagesThanZeroRightNow.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cannotWorkWithOtherStagesThanZeroRightNow.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='canOnlyCherryPickCommitsWithOneParent']"
		[Register ("canOnlyCherryPickCommitsWithOneParent")]
		public string CanOnlyCherryPickCommitsWithOneParent {
			get {
				const string __id = "canOnlyCherryPickCommitsWithOneParent.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "canOnlyCherryPickCommitsWithOneParent.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='canOnlyRevertCommitsWithOneParent']"
		[Register ("canOnlyRevertCommitsWithOneParent")]
		public string CanOnlyRevertCommitsWithOneParent {
			get {
				const string __id = "canOnlyRevertCommitsWithOneParent.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "canOnlyRevertCommitsWithOneParent.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cantFindObjectInReversePackIndexForTheSpecifiedOffset']"
		[Register ("cantFindObjectInReversePackIndexForTheSpecifiedOffset")]
		public string CantFindObjectInReversePackIndexForTheSpecifiedOffset {
			get {
				const string __id = "cantFindObjectInReversePackIndexForTheSpecifiedOffset.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cantFindObjectInReversePackIndexForTheSpecifiedOffset.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cantPassMeATree']"
		[Register ("cantPassMeATree")]
		public string CantPassMeATree {
			get {
				const string __id = "cantPassMeATree.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cantPassMeATree.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='channelMustBeInRange1_255']"
		[Register ("channelMustBeInRange1_255")]
		public string ChannelMustBeInRange1255 {
			get {
				const string __id = "channelMustBeInRange1_255.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "channelMustBeInRange1_255.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='characterClassIsNotSupported']"
		[Register ("characterClassIsNotSupported")]
		public string CharacterClassIsNotSupported {
			get {
				const string __id = "characterClassIsNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "characterClassIsNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='checkoutConflictWithFile']"
		[Register ("checkoutConflictWithFile")]
		public string CheckoutConflictWithFile {
			get {
				const string __id = "checkoutConflictWithFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "checkoutConflictWithFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='checkoutConflictWithFiles']"
		[Register ("checkoutConflictWithFiles")]
		public string CheckoutConflictWithFiles {
			get {
				const string __id = "checkoutConflictWithFiles.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "checkoutConflictWithFiles.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='checkoutUnexpectedResult']"
		[Register ("checkoutUnexpectedResult")]
		public string CheckoutUnexpectedResult {
			get {
				const string __id = "checkoutUnexpectedResult.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "checkoutUnexpectedResult.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='classCastNotA']"
		[Register ("classCastNotA")]
		public string ClassCastNotA {
			get {
				const string __id = "classCastNotA.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "classCastNotA.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='cloneNonEmptyDirectory']"
		[Register ("cloneNonEmptyDirectory")]
		public string CloneNonEmptyDirectory {
			get {
				const string __id = "cloneNonEmptyDirectory.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cloneNonEmptyDirectory.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='collisionOn']"
		[Register ("collisionOn")]
		public string CollisionOn {
			get {
				const string __id = "collisionOn.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "collisionOn.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='commandWasCalledInTheWrongState']"
		[Register ("commandWasCalledInTheWrongState")]
		public string CommandWasCalledInTheWrongState {
			get {
				const string __id = "commandWasCalledInTheWrongState.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "commandWasCalledInTheWrongState.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='commitAlreadyExists']"
		[Register ("commitAlreadyExists")]
		public string CommitAlreadyExists {
			get {
				const string __id = "commitAlreadyExists.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "commitAlreadyExists.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='commitAmendOnInitialNotPossible']"
		[Register ("commitAmendOnInitialNotPossible")]
		public string CommitAmendOnInitialNotPossible {
			get {
				const string __id = "commitAmendOnInitialNotPossible.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "commitAmendOnInitialNotPossible.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='commitDoesNotHaveGivenParent']"
		[Register ("commitDoesNotHaveGivenParent")]
		public string CommitDoesNotHaveGivenParent {
			get {
				const string __id = "commitDoesNotHaveGivenParent.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "commitDoesNotHaveGivenParent.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='commitMessageNotSpecified']"
		[Register ("commitMessageNotSpecified")]
		public string CommitMessageNotSpecified {
			get {
				const string __id = "commitMessageNotSpecified.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "commitMessageNotSpecified.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='commitOnRepoWithoutHEADCurrentlyNotSupported']"
		[Register ("commitOnRepoWithoutHEADCurrentlyNotSupported")]
		public string CommitOnRepoWithoutHEADCurrentlyNotSupported {
			get {
				const string __id = "commitOnRepoWithoutHEADCurrentlyNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "commitOnRepoWithoutHEADCurrentlyNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='commitRejectedByHook']"
		[Register ("commitRejectedByHook")]
		public string CommitRejectedByHook {
			get {
				const string __id = "commitRejectedByHook.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "commitRejectedByHook.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='compressingObjects']"
		[Register ("compressingObjects")]
		public string CompressingObjects {
			get {
				const string __id = "compressingObjects.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "compressingObjects.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='connectionFailed']"
		[Register ("connectionFailed")]
		public string ConnectionFailed {
			get {
				const string __id = "connectionFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "connectionFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='connectionTimeOut']"
		[Register ("connectionTimeOut")]
		public string ConnectionTimeOut {
			get {
				const string __id = "connectionTimeOut.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "connectionTimeOut.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='contextMustBeNonNegative']"
		[Register ("contextMustBeNonNegative")]
		public string ContextMustBeNonNegative {
			get {
				const string __id = "contextMustBeNonNegative.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "contextMustBeNonNegative.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptionDetectedReReadingAt']"
		[Register ("corruptionDetectedReReadingAt")]
		public string CorruptionDetectedReReadingAt {
			get {
				const string __id = "corruptionDetectedReReadingAt.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptionDetectedReReadingAt.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectBadStream']"
		[Register ("corruptObjectBadStream")]
		public string CorruptObjectBadStream {
			get {
				const string __id = "corruptObjectBadStream.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectBadStream.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectBadStreamCorruptHeader']"
		[Register ("corruptObjectBadStreamCorruptHeader")]
		public string CorruptObjectBadStreamCorruptHeader {
			get {
				const string __id = "corruptObjectBadStreamCorruptHeader.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectBadStreamCorruptHeader.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectGarbageAfterSize']"
		[Register ("corruptObjectGarbageAfterSize")]
		public string CorruptObjectGarbageAfterSize {
			get {
				const string __id = "corruptObjectGarbageAfterSize.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectGarbageAfterSize.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectIncorrectLength']"
		[Register ("corruptObjectIncorrectLength")]
		public string CorruptObjectIncorrectLength {
			get {
				const string __id = "corruptObjectIncorrectLength.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectIncorrectLength.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectInvalidEntryMode']"
		[Register ("corruptObjectInvalidEntryMode")]
		public string CorruptObjectInvalidEntryMode {
			get {
				const string __id = "corruptObjectInvalidEntryMode.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectInvalidEntryMode.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectInvalidMode']"
		[Register ("corruptObjectInvalidMode")]
		public string CorruptObjectInvalidMode {
			get {
				const string __id = "corruptObjectInvalidMode.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectInvalidMode.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectInvalidMode2']"
		[Register ("corruptObjectInvalidMode2")]
		public string CorruptObjectInvalidMode2 {
			get {
				const string __id = "corruptObjectInvalidMode2.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectInvalidMode2.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectInvalidMode3']"
		[Register ("corruptObjectInvalidMode3")]
		public string CorruptObjectInvalidMode3 {
			get {
				const string __id = "corruptObjectInvalidMode3.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectInvalidMode3.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectInvalidType']"
		[Register ("corruptObjectInvalidType")]
		public string CorruptObjectInvalidType {
			get {
				const string __id = "corruptObjectInvalidType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectInvalidType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectInvalidType2']"
		[Register ("corruptObjectInvalidType2")]
		public string CorruptObjectInvalidType2 {
			get {
				const string __id = "corruptObjectInvalidType2.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectInvalidType2.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectMalformedHeader']"
		[Register ("corruptObjectMalformedHeader")]
		public string CorruptObjectMalformedHeader {
			get {
				const string __id = "corruptObjectMalformedHeader.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectMalformedHeader.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNegativeSize']"
		[Register ("corruptObjectNegativeSize")]
		public string CorruptObjectNegativeSize {
			get {
				const string __id = "corruptObjectNegativeSize.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNegativeSize.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNoAuthor']"
		[Register ("corruptObjectNoAuthor")]
		public string CorruptObjectNoAuthor {
			get {
				const string __id = "corruptObjectNoAuthor.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNoAuthor.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNoCommitter']"
		[Register ("corruptObjectNoCommitter")]
		public string CorruptObjectNoCommitter {
			get {
				const string __id = "corruptObjectNoCommitter.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNoCommitter.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNoHeader']"
		[Register ("corruptObjectNoHeader")]
		public string CorruptObjectNoHeader {
			get {
				const string __id = "corruptObjectNoHeader.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNoHeader.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNoObject']"
		[Register ("corruptObjectNoObject")]
		public string CorruptObjectNoObject {
			get {
				const string __id = "corruptObjectNoObject.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNoObject.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNoTaggerBadHeader']"
		[Register ("corruptObjectNoTaggerBadHeader")]
		public string CorruptObjectNoTaggerBadHeader {
			get {
				const string __id = "corruptObjectNoTaggerBadHeader.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNoTaggerBadHeader.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNoTaggerHeader']"
		[Register ("corruptObjectNoTaggerHeader")]
		public string CorruptObjectNoTaggerHeader {
			get {
				const string __id = "corruptObjectNoTaggerHeader.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNoTaggerHeader.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNoTagName']"
		[Register ("corruptObjectNoTagName")]
		public string CorruptObjectNoTagName {
			get {
				const string __id = "corruptObjectNoTagName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNoTagName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNotree']"
		[Register ("corruptObjectNotree")]
		public string CorruptObjectNotree {
			get {
				const string __id = "corruptObjectNotree.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNotree.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectNoType']"
		[Register ("corruptObjectNoType")]
		public string CorruptObjectNoType {
			get {
				const string __id = "corruptObjectNoType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectNoType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptObjectPackfileChecksumIncorrect']"
		[Register ("corruptObjectPackfileChecksumIncorrect")]
		public string CorruptObjectPackfileChecksumIncorrect {
			get {
				const string __id = "corruptObjectPackfileChecksumIncorrect.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptObjectPackfileChecksumIncorrect.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='corruptPack']"
		[Register ("corruptPack")]
		public string CorruptPack {
			get {
				const string __id = "corruptPack.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "corruptPack.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotCheckOutBecauseOfConflicts']"
		[Register ("couldNotCheckOutBecauseOfConflicts")]
		public string CouldNotCheckOutBecauseOfConflicts {
			get {
				const string __id = "couldNotCheckOutBecauseOfConflicts.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotCheckOutBecauseOfConflicts.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotDeleteLockFileShouldNotHappen']"
		[Register ("couldNotDeleteLockFileShouldNotHappen")]
		public string CouldNotDeleteLockFileShouldNotHappen {
			get {
				const string __id = "couldNotDeleteLockFileShouldNotHappen.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotDeleteLockFileShouldNotHappen.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotDeleteTemporaryIndexFileShouldNotHappen']"
		[Register ("couldNotDeleteTemporaryIndexFileShouldNotHappen")]
		public string CouldNotDeleteTemporaryIndexFileShouldNotHappen {
			get {
				const string __id = "couldNotDeleteTemporaryIndexFileShouldNotHappen.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotDeleteTemporaryIndexFileShouldNotHappen.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotGetAdvertisedRef']"
		[Register ("couldNotGetAdvertisedRef")]
		public string CouldNotGetAdvertisedRef {
			get {
				const string __id = "couldNotGetAdvertisedRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotGetAdvertisedRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotGetRepoStatistics']"
		[Register ("couldNotGetRepoStatistics")]
		public string CouldNotGetRepoStatistics {
			get {
				const string __id = "couldNotGetRepoStatistics.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotGetRepoStatistics.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotLockHEAD']"
		[Register ("couldNotLockHEAD")]
		public string CouldNotLockHEAD {
			get {
				const string __id = "couldNotLockHEAD.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotLockHEAD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotReadIndexInOneGo']"
		[Register ("couldNotReadIndexInOneGo")]
		public string CouldNotReadIndexInOneGo {
			get {
				const string __id = "couldNotReadIndexInOneGo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotReadIndexInOneGo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotReadObjectWhileParsingCommit']"
		[Register ("couldNotReadObjectWhileParsingCommit")]
		public string CouldNotReadObjectWhileParsingCommit {
			get {
				const string __id = "couldNotReadObjectWhileParsingCommit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotReadObjectWhileParsingCommit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotRenameDeleteOldIndex']"
		[Register ("couldNotRenameDeleteOldIndex")]
		public string CouldNotRenameDeleteOldIndex {
			get {
				const string __id = "couldNotRenameDeleteOldIndex.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotRenameDeleteOldIndex.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotRenameTemporaryFile']"
		[Register ("couldNotRenameTemporaryFile")]
		public string CouldNotRenameTemporaryFile {
			get {
				const string __id = "couldNotRenameTemporaryFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotRenameTemporaryFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotRenameTemporaryIndexFileToIndex']"
		[Register ("couldNotRenameTemporaryIndexFileToIndex")]
		public string CouldNotRenameTemporaryIndexFileToIndex {
			get {
				const string __id = "couldNotRenameTemporaryIndexFileToIndex.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotRenameTemporaryIndexFileToIndex.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotURLEncodeToUTF8']"
		[Register ("couldNotURLEncodeToUTF8")]
		public string CouldNotURLEncodeToUTF8 {
			get {
				const string __id = "couldNotURLEncodeToUTF8.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotURLEncodeToUTF8.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='couldNotWriteFile']"
		[Register ("couldNotWriteFile")]
		public string CouldNotWriteFile {
			get {
				const string __id = "couldNotWriteFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "couldNotWriteFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='countingObjects']"
		[Register ("countingObjects")]
		public string CountingObjects {
			get {
				const string __id = "countingObjects.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "countingObjects.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='createBranchFailedUnknownReason']"
		[Register ("createBranchFailedUnknownReason")]
		public string CreateBranchFailedUnknownReason {
			get {
				const string __id = "createBranchFailedUnknownReason.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "createBranchFailedUnknownReason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='createBranchUnexpectedResult']"
		[Register ("createBranchUnexpectedResult")]
		public string CreateBranchUnexpectedResult {
			get {
				const string __id = "createBranchUnexpectedResult.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "createBranchUnexpectedResult.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='createNewFileFailed']"
		[Register ("createNewFileFailed")]
		public string CreateNewFileFailed {
			get {
				const string __id = "createNewFileFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "createNewFileFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='credentialPassword']"
		[Register ("credentialPassword")]
		public string CredentialPassword {
			get {
				const string __id = "credentialPassword.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "credentialPassword.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='credentialUsername']"
		[Register ("credentialUsername")]
		public string CredentialUsername {
			get {
				const string __id = "credentialUsername.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "credentialUsername.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='daemonAlreadyRunning']"
		[Register ("daemonAlreadyRunning")]
		public string DaemonAlreadyRunning {
			get {
				const string __id = "daemonAlreadyRunning.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "daemonAlreadyRunning.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='daysAgo']"
		[Register ("daysAgo")]
		public string DaysAgo {
			get {
				const string __id = "daysAgo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "daysAgo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='deleteBranchUnexpectedResult']"
		[Register ("deleteBranchUnexpectedResult")]
		public string DeleteBranchUnexpectedResult {
			get {
				const string __id = "deleteBranchUnexpectedResult.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deleteBranchUnexpectedResult.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='deleteFileFailed']"
		[Register ("deleteFileFailed")]
		public string DeleteFileFailed {
			get {
				const string __id = "deleteFileFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deleteFileFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='deleteTagUnexpectedResult']"
		[Register ("deleteTagUnexpectedResult")]
		public string DeleteTagUnexpectedResult {
			get {
				const string __id = "deleteTagUnexpectedResult.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deleteTagUnexpectedResult.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='deletingNotSupported']"
		[Register ("deletingNotSupported")]
		public string DeletingNotSupported {
			get {
				const string __id = "deletingNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deletingNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='destinationIsNotAWildcard']"
		[Register ("destinationIsNotAWildcard")]
		public string DestinationIsNotAWildcard {
			get {
				const string __id = "destinationIsNotAWildcard.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "destinationIsNotAWildcard.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='detachedHeadDetected']"
		[Register ("detachedHeadDetected")]
		public string DetachedHeadDetected {
			get {
				const string __id = "detachedHeadDetected.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "detachedHeadDetected.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='dirCacheDoesNotHaveABackingFile']"
		[Register ("dirCacheDoesNotHaveABackingFile")]
		public string DirCacheDoesNotHaveABackingFile {
			get {
				const string __id = "dirCacheDoesNotHaveABackingFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dirCacheDoesNotHaveABackingFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='dirCacheFileIsNotLocked']"
		[Register ("dirCacheFileIsNotLocked")]
		public string DirCacheFileIsNotLocked {
			get {
				const string __id = "dirCacheFileIsNotLocked.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dirCacheFileIsNotLocked.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='dirCacheIsNotLocked']"
		[Register ("dirCacheIsNotLocked")]
		public string DirCacheIsNotLocked {
			get {
				const string __id = "dirCacheIsNotLocked.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dirCacheIsNotLocked.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='DIRCChecksumMismatch']"
		[Register ("DIRCChecksumMismatch")]
		public string DIRCChecksumMismatch {
			get {
				const string __id = "DIRCChecksumMismatch.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "DIRCChecksumMismatch.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='DIRCExtensionIsTooLargeAt']"
		[Register ("DIRCExtensionIsTooLargeAt")]
		public string DIRCExtensionIsTooLargeAt {
			get {
				const string __id = "DIRCExtensionIsTooLargeAt.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "DIRCExtensionIsTooLargeAt.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='DIRCExtensionNotSupportedByThisVersion']"
		[Register ("DIRCExtensionNotSupportedByThisVersion")]
		public string DIRCExtensionNotSupportedByThisVersion {
			get {
				const string __id = "DIRCExtensionNotSupportedByThisVersion.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "DIRCExtensionNotSupportedByThisVersion.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='DIRCHasTooManyEntries']"
		[Register ("DIRCHasTooManyEntries")]
		public string DIRCHasTooManyEntries {
			get {
				const string __id = "DIRCHasTooManyEntries.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "DIRCHasTooManyEntries.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='DIRCUnrecognizedExtendedFlags']"
		[Register ("DIRCUnrecognizedExtendedFlags")]
		public string DIRCUnrecognizedExtendedFlags {
			get {
				const string __id = "DIRCUnrecognizedExtendedFlags.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "DIRCUnrecognizedExtendedFlags.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='dirtyFilesExist']"
		[Register ("dirtyFilesExist")]
		public string DirtyFilesExist {
			get {
				const string __id = "dirtyFilesExist.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dirtyFilesExist.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='doesNotHandleMode']"
		[Register ("doesNotHandleMode")]
		public string DoesNotHandleMode {
			get {
				const string __id = "doesNotHandleMode.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "doesNotHandleMode.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='downloadCancelled']"
		[Register ("downloadCancelled")]
		public string DownloadCancelled {
			get {
				const string __id = "downloadCancelled.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "downloadCancelled.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='downloadCancelledDuringIndexing']"
		[Register ("downloadCancelledDuringIndexing")]
		public string DownloadCancelledDuringIndexing {
			get {
				const string __id = "downloadCancelledDuringIndexing.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "downloadCancelledDuringIndexing.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='duplicateAdvertisementsOf']"
		[Register ("duplicateAdvertisementsOf")]
		public string DuplicateAdvertisementsOf {
			get {
				const string __id = "duplicateAdvertisementsOf.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "duplicateAdvertisementsOf.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='duplicateRef']"
		[Register ("duplicateRef")]
		public string DuplicateRef {
			get {
				const string __id = "duplicateRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "duplicateRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='duplicateRemoteRefUpdateIsIllegal']"
		[Register ("duplicateRemoteRefUpdateIsIllegal")]
		public string DuplicateRemoteRefUpdateIsIllegal {
			get {
				const string __id = "duplicateRemoteRefUpdateIsIllegal.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "duplicateRemoteRefUpdateIsIllegal.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='duplicateStagesNotAllowed']"
		[Register ("duplicateStagesNotAllowed")]
		public string DuplicateStagesNotAllowed {
			get {
				const string __id = "duplicateStagesNotAllowed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "duplicateStagesNotAllowed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='eitherGitDirOrWorkTreeRequired']"
		[Register ("eitherGitDirOrWorkTreeRequired")]
		public string EitherGitDirOrWorkTreeRequired {
			get {
				const string __id = "eitherGitDirOrWorkTreeRequired.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "eitherGitDirOrWorkTreeRequired.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='emptyCommit']"
		[Register ("emptyCommit")]
		public string EmptyCommit {
			get {
				const string __id = "emptyCommit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "emptyCommit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='emptyPathNotPermitted']"
		[Register ("emptyPathNotPermitted")]
		public string EmptyPathNotPermitted {
			get {
				const string __id = "emptyPathNotPermitted.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "emptyPathNotPermitted.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='encryptionError']"
		[Register ("encryptionError")]
		public string EncryptionError {
			get {
				const string __id = "encryptionError.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "encryptionError.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='endOfFileInEscape']"
		[Register ("endOfFileInEscape")]
		public string EndOfFileInEscape {
			get {
				const string __id = "endOfFileInEscape.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "endOfFileInEscape.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='entryNotFoundByPath']"
		[Register ("entryNotFoundByPath")]
		public string EntryNotFoundByPath {
			get {
				const string __id = "entryNotFoundByPath.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "entryNotFoundByPath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='enumValueNotSupported2']"
		[Register ("enumValueNotSupported2")]
		public string EnumValueNotSupported2 {
			get {
				const string __id = "enumValueNotSupported2.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "enumValueNotSupported2.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='enumValueNotSupported3']"
		[Register ("enumValueNotSupported3")]
		public string EnumValueNotSupported3 {
			get {
				const string __id = "enumValueNotSupported3.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "enumValueNotSupported3.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='enumValuesNotAvailable']"
		[Register ("enumValuesNotAvailable")]
		public string EnumValuesNotAvailable {
			get {
				const string __id = "enumValuesNotAvailable.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "enumValuesNotAvailable.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='errorDecodingFromFile']"
		[Register ("errorDecodingFromFile")]
		public string ErrorDecodingFromFile {
			get {
				const string __id = "errorDecodingFromFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorDecodingFromFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='errorEncodingFromFile']"
		[Register ("errorEncodingFromFile")]
		public string ErrorEncodingFromFile {
			get {
				const string __id = "errorEncodingFromFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorEncodingFromFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='errorInBase64CodeReadingStream']"
		[Register ("errorInBase64CodeReadingStream")]
		public string ErrorInBase64CodeReadingStream {
			get {
				const string __id = "errorInBase64CodeReadingStream.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorInBase64CodeReadingStream.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='errorInPackedRefs']"
		[Register ("errorInPackedRefs")]
		public string ErrorInPackedRefs {
			get {
				const string __id = "errorInPackedRefs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorInPackedRefs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='errorInvalidProtocolWantedOldNewRef']"
		[Register ("errorInvalidProtocolWantedOldNewRef")]
		public string ErrorInvalidProtocolWantedOldNewRef {
			get {
				const string __id = "errorInvalidProtocolWantedOldNewRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorInvalidProtocolWantedOldNewRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='errorListing']"
		[Register ("errorListing")]
		public string ErrorListing {
			get {
				const string __id = "errorListing.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorListing.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='errorOccurredDuringUnpackingOnTheRemoteEnd']"
		[Register ("errorOccurredDuringUnpackingOnTheRemoteEnd")]
		public string ErrorOccurredDuringUnpackingOnTheRemoteEnd {
			get {
				const string __id = "errorOccurredDuringUnpackingOnTheRemoteEnd.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorOccurredDuringUnpackingOnTheRemoteEnd.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='errorReadingInfoRefs']"
		[Register ("errorReadingInfoRefs")]
		public string ErrorReadingInfoRefs {
			get {
				const string __id = "errorReadingInfoRefs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorReadingInfoRefs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='errorSymlinksNotSupported']"
		[Register ("errorSymlinksNotSupported")]
		public string ErrorSymlinksNotSupported {
			get {
				const string __id = "errorSymlinksNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorSymlinksNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfAddCommand']"
		[Register ("exceptionCaughtDuringExecutionOfAddCommand")]
		public string ExceptionCaughtDuringExecutionOfAddCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfAddCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfAddCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfArchiveCommand']"
		[Register ("exceptionCaughtDuringExecutionOfArchiveCommand")]
		public string ExceptionCaughtDuringExecutionOfArchiveCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfArchiveCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfArchiveCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfCherryPickCommand']"
		[Register ("exceptionCaughtDuringExecutionOfCherryPickCommand")]
		public string ExceptionCaughtDuringExecutionOfCherryPickCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfCherryPickCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfCherryPickCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfCommitCommand']"
		[Register ("exceptionCaughtDuringExecutionOfCommitCommand")]
		public string ExceptionCaughtDuringExecutionOfCommitCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfCommitCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfCommitCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfFetchCommand']"
		[Register ("exceptionCaughtDuringExecutionOfFetchCommand")]
		public string ExceptionCaughtDuringExecutionOfFetchCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfFetchCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfFetchCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfHook']"
		[Register ("exceptionCaughtDuringExecutionOfHook")]
		public string ExceptionCaughtDuringExecutionOfHook {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfHook.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfHook.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfLsRemoteCommand']"
		[Register ("exceptionCaughtDuringExecutionOfLsRemoteCommand")]
		public string ExceptionCaughtDuringExecutionOfLsRemoteCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfLsRemoteCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfLsRemoteCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfMergeCommand']"
		[Register ("exceptionCaughtDuringExecutionOfMergeCommand")]
		public string ExceptionCaughtDuringExecutionOfMergeCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfMergeCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfMergeCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfPullCommand']"
		[Register ("exceptionCaughtDuringExecutionOfPullCommand")]
		public string ExceptionCaughtDuringExecutionOfPullCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfPullCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfPullCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfPushCommand']"
		[Register ("exceptionCaughtDuringExecutionOfPushCommand")]
		public string ExceptionCaughtDuringExecutionOfPushCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfPushCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfPushCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfResetCommand']"
		[Register ("exceptionCaughtDuringExecutionOfResetCommand")]
		public string ExceptionCaughtDuringExecutionOfResetCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfResetCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfResetCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfRevertCommand']"
		[Register ("exceptionCaughtDuringExecutionOfRevertCommand")]
		public string ExceptionCaughtDuringExecutionOfRevertCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfRevertCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfRevertCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfRmCommand']"
		[Register ("exceptionCaughtDuringExecutionOfRmCommand")]
		public string ExceptionCaughtDuringExecutionOfRmCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfRmCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfRmCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionCaughtDuringExecutionOfTagCommand']"
		[Register ("exceptionCaughtDuringExecutionOfTagCommand")]
		public string ExceptionCaughtDuringExecutionOfTagCommand {
			get {
				const string __id = "exceptionCaughtDuringExecutionOfTagCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionCaughtDuringExecutionOfTagCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionHookExecutionInterrupted']"
		[Register ("exceptionHookExecutionInterrupted")]
		public string ExceptionHookExecutionInterrupted {
			get {
				const string __id = "exceptionHookExecutionInterrupted.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionHookExecutionInterrupted.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionOccurredDuringAddingOfOptionToALogCommand']"
		[Register ("exceptionOccurredDuringAddingOfOptionToALogCommand")]
		public string ExceptionOccurredDuringAddingOfOptionToALogCommand {
			get {
				const string __id = "exceptionOccurredDuringAddingOfOptionToALogCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionOccurredDuringAddingOfOptionToALogCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionOccurredDuringReadingOfGIT_DIR']"
		[Register ("exceptionOccurredDuringReadingOfGIT_DIR")]
		public string ExceptionOccurredDuringReadingOfGITDIR {
			get {
				const string __id = "exceptionOccurredDuringReadingOfGIT_DIR.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionOccurredDuringReadingOfGIT_DIR.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='exceptionWhileReadingPack']"
		[Register ("exceptionWhileReadingPack")]
		public string ExceptionWhileReadingPack {
			get {
				const string __id = "exceptionWhileReadingPack.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exceptionWhileReadingPack.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedACKNAKFoundEOF']"
		[Register ("expectedACKNAKFoundEOF")]
		public string ExpectedACKNAKFoundEOF {
			get {
				const string __id = "expectedACKNAKFoundEOF.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedACKNAKFoundEOF.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedACKNAKGot']"
		[Register ("expectedACKNAKGot")]
		public string ExpectedACKNAKGot {
			get {
				const string __id = "expectedACKNAKGot.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedACKNAKGot.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedBooleanStringValue']"
		[Register ("expectedBooleanStringValue")]
		public string ExpectedBooleanStringValue {
			get {
				const string __id = "expectedBooleanStringValue.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedBooleanStringValue.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedCharacterEncodingGuesses']"
		[Register ("expectedCharacterEncodingGuesses")]
		public string ExpectedCharacterEncodingGuesses {
			get {
				const string __id = "expectedCharacterEncodingGuesses.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedCharacterEncodingGuesses.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedEOFReceived']"
		[Register ("expectedEOFReceived")]
		public string ExpectedEOFReceived {
			get {
				const string __id = "expectedEOFReceived.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedEOFReceived.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedGot']"
		[Register ("expectedGot")]
		public string ExpectedGot {
			get {
				const string __id = "expectedGot.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedGot.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedLessThanGot']"
		[Register ("expectedLessThanGot")]
		public string ExpectedLessThanGot {
			get {
				const string __id = "expectedLessThanGot.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedLessThanGot.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedPktLineWithService']"
		[Register ("expectedPktLineWithService")]
		public string ExpectedPktLineWithService {
			get {
				const string __id = "expectedPktLineWithService.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedPktLineWithService.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedReceivedContentType']"
		[Register ("expectedReceivedContentType")]
		public string ExpectedReceivedContentType {
			get {
				const string __id = "expectedReceivedContentType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedReceivedContentType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='expectedReportForRefNotReceived']"
		[Register ("expectedReportForRefNotReceived")]
		public string ExpectedReportForRefNotReceived {
			get {
				const string __id = "expectedReportForRefNotReceived.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "expectedReportForRefNotReceived.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='failedUpdatingRefs']"
		[Register ("failedUpdatingRefs")]
		public string FailedUpdatingRefs {
			get {
				const string __id = "failedUpdatingRefs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "failedUpdatingRefs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='failureDueToOneOfTheFollowing']"
		[Register ("failureDueToOneOfTheFollowing")]
		public string FailureDueToOneOfTheFollowing {
			get {
				const string __id = "failureDueToOneOfTheFollowing.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "failureDueToOneOfTheFollowing.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='failureUpdatingFETCH_HEAD']"
		[Register ("failureUpdatingFETCH_HEAD")]
		public string FailureUpdatingFETCHHEAD {
			get {
				const string __id = "failureUpdatingFETCH_HEAD.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "failureUpdatingFETCH_HEAD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='failureUpdatingTrackingRef']"
		[Register ("failureUpdatingTrackingRef")]
		public string FailureUpdatingTrackingRef {
			get {
				const string __id = "failureUpdatingTrackingRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "failureUpdatingTrackingRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='fileCannotBeDeleted']"
		[Register ("fileCannotBeDeleted")]
		public string FileCannotBeDeleted {
			get {
				const string __id = "fileCannotBeDeleted.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fileCannotBeDeleted.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='fileIsTooBigForThisConvenienceMethod']"
		[Register ("fileIsTooBigForThisConvenienceMethod")]
		public string FileIsTooBigForThisConvenienceMethod {
			get {
				const string __id = "fileIsTooBigForThisConvenienceMethod.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fileIsTooBigForThisConvenienceMethod.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='fileIsTooLarge']"
		[Register ("fileIsTooLarge")]
		public string FileIsTooLarge {
			get {
				const string __id = "fileIsTooLarge.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fileIsTooLarge.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='fileModeNotSetForPath']"
		[Register ("fileModeNotSetForPath")]
		public string FileModeNotSetForPath {
			get {
				const string __id = "fileModeNotSetForPath.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fileModeNotSetForPath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='flagIsDisposed']"
		[Register ("flagIsDisposed")]
		public string FlagIsDisposed {
			get {
				const string __id = "flagIsDisposed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "flagIsDisposed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='flagNotFromThis']"
		[Register ("flagNotFromThis")]
		public string FlagNotFromThis {
			get {
				const string __id = "flagNotFromThis.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "flagNotFromThis.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='flagsAlreadyCreated']"
		[Register ("flagsAlreadyCreated")]
		public string FlagsAlreadyCreated {
			get {
				const string __id = "flagsAlreadyCreated.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "flagsAlreadyCreated.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='funnyRefname']"
		[Register ("funnyRefname")]
		public string FunnyRefname {
			get {
				const string __id = "funnyRefname.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "funnyRefname.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='gcFailed']"
		[Register ("gcFailed")]
		public string GcFailed {
			get {
				const string __id = "gcFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "gcFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='gitmodulesNotFound']"
		[Register ("gitmodulesNotFound")]
		public string GitmodulesNotFound {
			get {
				const string __id = "gitmodulesNotFound.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "gitmodulesNotFound.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='headRequiredToStash']"
		[Register ("headRequiredToStash")]
		public string HeadRequiredToStash {
			get {
				const string __id = "headRequiredToStash.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "headRequiredToStash.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='hoursAgo']"
		[Register ("hoursAgo")]
		public string HoursAgo {
			get {
				const string __id = "hoursAgo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "hoursAgo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='hugeIndexesAreNotSupportedByJgitYet']"
		[Register ("hugeIndexesAreNotSupportedByJgitYet")]
		public string HugeIndexesAreNotSupportedByJgitYet {
			get {
				const string __id = "hugeIndexesAreNotSupportedByJgitYet.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "hugeIndexesAreNotSupportedByJgitYet.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='hunkBelongsToAnotherFile']"
		[Register ("hunkBelongsToAnotherFile")]
		public string HunkBelongsToAnotherFile {
			get {
				const string __id = "hunkBelongsToAnotherFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "hunkBelongsToAnotherFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='hunkDisconnectedFromFile']"
		[Register ("hunkDisconnectedFromFile")]
		public string HunkDisconnectedFromFile {
			get {
				const string __id = "hunkDisconnectedFromFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "hunkDisconnectedFromFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='hunkHeaderDoesNotMatchBodyLineCountOf']"
		[Register ("hunkHeaderDoesNotMatchBodyLineCountOf")]
		public string HunkHeaderDoesNotMatchBodyLineCountOf {
			get {
				const string __id = "hunkHeaderDoesNotMatchBodyLineCountOf.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "hunkHeaderDoesNotMatchBodyLineCountOf.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='illegalArgumentNotA']"
		[Register ("illegalArgumentNotA")]
		public string IllegalArgumentNotA {
			get {
				const string __id = "illegalArgumentNotA.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "illegalArgumentNotA.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='illegalCombinationOfArguments']"
		[Register ("illegalCombinationOfArguments")]
		public string IllegalCombinationOfArguments {
			get {
				const string __id = "illegalCombinationOfArguments.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "illegalCombinationOfArguments.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='illegalPackingPhase']"
		[Register ("illegalPackingPhase")]
		public string IllegalPackingPhase {
			get {
				const string __id = "illegalPackingPhase.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "illegalPackingPhase.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='illegalStateExists']"
		[Register ("illegalStateExists")]
		public string IllegalStateExists {
			get {
				const string __id = "illegalStateExists.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "illegalStateExists.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='improperlyPaddedBase64Input']"
		[Register ("improperlyPaddedBase64Input")]
		public string ImproperlyPaddedBase64Input {
			get {
				const string __id = "improperlyPaddedBase64Input.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "improperlyPaddedBase64Input.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='incorrectHashFor']"
		[Register ("incorrectHashFor")]
		public string IncorrectHashFor {
			get {
				const string __id = "incorrectHashFor.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "incorrectHashFor.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='incorrectOBJECT_ID_LENGTH']"
		[Register ("incorrectOBJECT_ID_LENGTH")]
		public string IncorrectOBJECTIDLENGTH {
			get {
				const string __id = "incorrectOBJECT_ID_LENGTH.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "incorrectOBJECT_ID_LENGTH.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='indexFileCorruptedNegativeBucketCount']"
		[Register ("indexFileCorruptedNegativeBucketCount")]
		public string IndexFileCorruptedNegativeBucketCount {
			get {
				const string __id = "indexFileCorruptedNegativeBucketCount.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "indexFileCorruptedNegativeBucketCount.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='indexFileIsInUse']"
		[Register ("indexFileIsInUse")]
		public string IndexFileIsInUse {
			get {
				const string __id = "indexFileIsInUse.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "indexFileIsInUse.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='indexFileIsTooLargeForJgit']"
		[Register ("indexFileIsTooLargeForJgit")]
		public string IndexFileIsTooLargeForJgit {
			get {
				const string __id = "indexFileIsTooLargeForJgit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "indexFileIsTooLargeForJgit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='indexSignatureIsInvalid']"
		[Register ("indexSignatureIsInvalid")]
		public string IndexSignatureIsInvalid {
			get {
				const string __id = "indexSignatureIsInvalid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "indexSignatureIsInvalid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='indexWriteException']"
		[Register ("indexWriteException")]
		public string IndexWriteException {
			get {
				const string __id = "indexWriteException.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "indexWriteException.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='initFailedBareRepoDifferentDirs']"
		[Register ("initFailedBareRepoDifferentDirs")]
		public string InitFailedBareRepoDifferentDirs {
			get {
				const string __id = "initFailedBareRepoDifferentDirs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "initFailedBareRepoDifferentDirs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='initFailedNonBareRepoSameDirs']"
		[Register ("initFailedNonBareRepoSameDirs")]
		public string InitFailedNonBareRepoSameDirs {
			get {
				const string __id = "initFailedNonBareRepoSameDirs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "initFailedNonBareRepoSameDirs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='inMemoryBufferLimitExceeded']"
		[Register ("inMemoryBufferLimitExceeded")]
		public string InMemoryBufferLimitExceeded {
			get {
				const string __id = "inMemoryBufferLimitExceeded.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "inMemoryBufferLimitExceeded.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='inputStreamMustSupportMark']"
		[Register ("inputStreamMustSupportMark")]
		public string InputStreamMustSupportMark {
			get {
				const string __id = "inputStreamMustSupportMark.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "inputStreamMustSupportMark.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='integerValueOutOfRange']"
		[Register ("integerValueOutOfRange")]
		public string IntegerValueOutOfRange {
			get {
				const string __id = "integerValueOutOfRange.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "integerValueOutOfRange.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='internalRevisionError']"
		[Register ("internalRevisionError")]
		public string InternalRevisionError {
			get {
				const string __id = "internalRevisionError.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "internalRevisionError.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='internalServerError']"
		[Register ("internalServerError")]
		public string InternalServerError {
			get {
				const string __id = "internalServerError.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "internalServerError.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='interruptedWriting']"
		[Register ("interruptedWriting")]
		public string InterruptedWriting {
			get {
				const string __id = "interruptedWriting.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "interruptedWriting.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='inTheFuture']"
		[Register ("inTheFuture")]
		public string InTheFuture {
			get {
				const string __id = "inTheFuture.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "inTheFuture.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidAdvertisementOf']"
		[Register ("invalidAdvertisementOf")]
		public string InvalidAdvertisementOf {
			get {
				const string __id = "invalidAdvertisementOf.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidAdvertisementOf.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidAncestryLength']"
		[Register ("invalidAncestryLength")]
		public string InvalidAncestryLength {
			get {
				const string __id = "invalidAncestryLength.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidAncestryLength.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidBooleanValue']"
		[Register ("invalidBooleanValue")]
		public string InvalidBooleanValue {
			get {
				const string __id = "invalidBooleanValue.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidBooleanValue.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidChannel']"
		[Register ("invalidChannel")]
		public string InvalidChannel {
			get {
				const string __id = "invalidChannel.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidChannel.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidCharacterInBase64Data']"
		[Register ("invalidCharacterInBase64Data")]
		public string InvalidCharacterInBase64Data {
			get {
				const string __id = "invalidCharacterInBase64Data.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidCharacterInBase64Data.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidCommitParentNumber']"
		[Register ("invalidCommitParentNumber")]
		public string InvalidCommitParentNumber {
			get {
				const string __id = "invalidCommitParentNumber.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidCommitParentNumber.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidEncryption']"
		[Register ("invalidEncryption")]
		public string InvalidEncryption {
			get {
				const string __id = "invalidEncryption.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidEncryption.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidGitdirRef']"
		[Register ("invalidGitdirRef")]
		public string InvalidGitdirRef {
			get {
				const string __id = "invalidGitdirRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidGitdirRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidGitType']"
		[Register ("invalidGitType")]
		public string InvalidGitType {
			get {
				const string __id = "invalidGitType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidGitType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidId']"
		[Register ("invalidId")]
		public string InvalidId {
			get {
				const string __id = "invalidId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidIdLength']"
		[Register ("invalidIdLength")]
		public string InvalidIdLength {
			get {
				const string __id = "invalidIdLength.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidIdLength.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidIntegerValue']"
		[Register ("invalidIntegerValue")]
		public string InvalidIntegerValue {
			get {
				const string __id = "invalidIntegerValue.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidIntegerValue.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidKey']"
		[Register ("invalidKey")]
		public string InvalidKey {
			get {
				const string __id = "invalidKey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidLineInConfigFile']"
		[Register ("invalidLineInConfigFile")]
		public string InvalidLineInConfigFile {
			get {
				const string __id = "invalidLineInConfigFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidLineInConfigFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidModeFor']"
		[Register ("invalidModeFor")]
		public string InvalidModeFor {
			get {
				const string __id = "invalidModeFor.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidModeFor.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidModeForPath']"
		[Register ("invalidModeForPath")]
		public string InvalidModeForPath {
			get {
				const string __id = "invalidModeForPath.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidModeForPath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidObject']"
		[Register ("invalidObject")]
		public string InvalidObject {
			get {
				const string __id = "invalidObject.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidObject.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidOldIdSent']"
		[Register ("invalidOldIdSent")]
		public string InvalidOldIdSent {
			get {
				const string __id = "invalidOldIdSent.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidOldIdSent.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidPacketLineHeader']"
		[Register ("invalidPacketLineHeader")]
		public string InvalidPacketLineHeader {
			get {
				const string __id = "invalidPacketLineHeader.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidPacketLineHeader.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidPath']"
		[Register ("invalidPath")]
		public string InvalidPath {
			get {
				const string __id = "invalidPath.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidPath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidPathContainsSeparator']"
		[Register ("invalidPathContainsSeparator")]
		public string InvalidPathContainsSeparator {
			get {
				const string __id = "invalidPathContainsSeparator.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidPathContainsSeparator.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidPathPeriodAtEndWindows']"
		[Register ("invalidPathPeriodAtEndWindows")]
		public string InvalidPathPeriodAtEndWindows {
			get {
				const string __id = "invalidPathPeriodAtEndWindows.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidPathPeriodAtEndWindows.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidPathReservedOnWindows']"
		[Register ("invalidPathReservedOnWindows")]
		public string InvalidPathReservedOnWindows {
			get {
				const string __id = "invalidPathReservedOnWindows.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidPathReservedOnWindows.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidPathSpaceAtEndWindows']"
		[Register ("invalidPathSpaceAtEndWindows")]
		public string InvalidPathSpaceAtEndWindows {
			get {
				const string __id = "invalidPathSpaceAtEndWindows.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidPathSpaceAtEndWindows.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidReflogRevision']"
		[Register ("invalidReflogRevision")]
		public string InvalidReflogRevision {
			get {
				const string __id = "invalidReflogRevision.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidReflogRevision.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidRefName']"
		[Register ("invalidRefName")]
		public string InvalidRefName {
			get {
				const string __id = "invalidRefName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidRefName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidRefSpec']"
		[Register ("invalidRefSpec")]
		public string InvalidRefSpec {
			get {
				const string __id = "invalidRefSpec.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidRefSpec.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidRemote']"
		[Register ("invalidRemote")]
		public string InvalidRemote {
			get {
				const string __id = "invalidRemote.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidRemote.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidStageForPath']"
		[Register ("invalidStageForPath")]
		public string InvalidStageForPath {
			get {
				const string __id = "invalidStageForPath.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidStageForPath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidTagOption']"
		[Register ("invalidTagOption")]
		public string InvalidTagOption {
			get {
				const string __id = "invalidTagOption.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidTagOption.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidTimeout']"
		[Register ("invalidTimeout")]
		public string InvalidTimeout {
			get {
				const string __id = "invalidTimeout.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidTimeout.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidURL']"
		[Register ("invalidURL")]
		public string InvalidURL {
			get {
				const string __id = "invalidURL.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidURL.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidWildcards']"
		[Register ("invalidWildcards")]
		public string InvalidWildcards {
			get {
				const string __id = "invalidWildcards.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidWildcards.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='invalidWindowSize']"
		[Register ("invalidWindowSize")]
		public string InvalidWindowSize {
			get {
				const string __id = "invalidWindowSize.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "invalidWindowSize.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='isAStaticFlagAndHasNorevWalkInstance']"
		[Register ("isAStaticFlagAndHasNorevWalkInstance")]
		public string IsAStaticFlagAndHasNorevWalkInstance {
			get {
				const string __id = "isAStaticFlagAndHasNorevWalkInstance.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "isAStaticFlagAndHasNorevWalkInstance.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='JRELacksMD5Implementation']"
		[Register ("JRELacksMD5Implementation")]
		public string JRELacksMD5Implementation {
			get {
				const string __id = "JRELacksMD5Implementation.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "JRELacksMD5Implementation.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='kNotInRange']"
		[Register ("kNotInRange")]
		public string KNotInRange {
			get {
				const string __id = "kNotInRange.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "kNotInRange.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='largeObjectExceedsByteArray']"
		[Register ("largeObjectExceedsByteArray")]
		public string LargeObjectExceedsByteArray {
			get {
				const string __id = "largeObjectExceedsByteArray.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "largeObjectExceedsByteArray.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='largeObjectExceedsLimit']"
		[Register ("largeObjectExceedsLimit")]
		public string LargeObjectExceedsLimit {
			get {
				const string __id = "largeObjectExceedsLimit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "largeObjectExceedsLimit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='largeObjectException']"
		[Register ("largeObjectException")]
		public string LargeObjectException {
			get {
				const string __id = "largeObjectException.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "largeObjectException.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='largeObjectOutOfMemory']"
		[Register ("largeObjectOutOfMemory")]
		public string LargeObjectOutOfMemory {
			get {
				const string __id = "largeObjectOutOfMemory.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "largeObjectOutOfMemory.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='lengthExceedsMaximumArraySize']"
		[Register ("lengthExceedsMaximumArraySize")]
		public string LengthExceedsMaximumArraySize {
			get {
				const string __id = "lengthExceedsMaximumArraySize.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lengthExceedsMaximumArraySize.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='listingAlternates']"
		[Register ("listingAlternates")]
		public string ListingAlternates {
			get {
				const string __id = "listingAlternates.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "listingAlternates.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='localObjectsIncomplete']"
		[Register ("localObjectsIncomplete")]
		public string LocalObjectsIncomplete {
			get {
				const string __id = "localObjectsIncomplete.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "localObjectsIncomplete.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='localRefIsMissingObjects']"
		[Register ("localRefIsMissingObjects")]
		public string LocalRefIsMissingObjects {
			get {
				const string __id = "localRefIsMissingObjects.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "localRefIsMissingObjects.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='lockCountMustBeGreaterOrEqual1']"
		[Register ("lockCountMustBeGreaterOrEqual1")]
		public string LockCountMustBeGreaterOrEqual1 {
			get {
				const string __id = "lockCountMustBeGreaterOrEqual1.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lockCountMustBeGreaterOrEqual1.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='lockError']"
		[Register ("lockError")]
		public string LockError {
			get {
				const string __id = "lockError.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lockError.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='lockOnNotClosed']"
		[Register ("lockOnNotClosed")]
		public string LockOnNotClosed {
			get {
				const string __id = "lockOnNotClosed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lockOnNotClosed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='lockOnNotHeld']"
		[Register ("lockOnNotHeld")]
		public string LockOnNotHeld {
			get {
				const string __id = "lockOnNotHeld.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lockOnNotHeld.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='malformedpersonIdentString']"
		[Register ("malformedpersonIdentString")]
		public string MalformedpersonIdentString {
			get {
				const string __id = "malformedpersonIdentString.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "malformedpersonIdentString.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='maxCountMustBeNonNegative']"
		[Register ("maxCountMustBeNonNegative")]
		public string MaxCountMustBeNonNegative {
			get {
				const string __id = "maxCountMustBeNonNegative.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "maxCountMustBeNonNegative.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mergeConflictOnNonNoteEntries']"
		[Register ("mergeConflictOnNonNoteEntries")]
		public string MergeConflictOnNonNoteEntries {
			get {
				const string __id = "mergeConflictOnNonNoteEntries.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mergeConflictOnNonNoteEntries.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mergeConflictOnNotes']"
		[Register ("mergeConflictOnNotes")]
		public string MergeConflictOnNotes {
			get {
				const string __id = "mergeConflictOnNotes.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mergeConflictOnNotes.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mergeRecursiveConflictsWhenMergingCommonAncestors']"
		[Register ("mergeRecursiveConflictsWhenMergingCommonAncestors")]
		public string MergeRecursiveConflictsWhenMergingCommonAncestors {
			get {
				const string __id = "mergeRecursiveConflictsWhenMergingCommonAncestors.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mergeRecursiveConflictsWhenMergingCommonAncestors.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mergeRecursiveReturnedNoCommit']"
		[Register ("mergeRecursiveReturnedNoCommit")]
		public string MergeRecursiveReturnedNoCommit {
			get {
				const string __id = "mergeRecursiveReturnedNoCommit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mergeRecursiveReturnedNoCommit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mergeRecursiveTooManyMergeBasesFor']"
		[Register ("mergeRecursiveTooManyMergeBasesFor")]
		public string MergeRecursiveTooManyMergeBasesFor {
			get {
				const string __id = "mergeRecursiveTooManyMergeBasesFor.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mergeRecursiveTooManyMergeBasesFor.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mergeStrategyAlreadyExistsAsDefault']"
		[Register ("mergeStrategyAlreadyExistsAsDefault")]
		public string MergeStrategyAlreadyExistsAsDefault {
			get {
				const string __id = "mergeStrategyAlreadyExistsAsDefault.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mergeStrategyAlreadyExistsAsDefault.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mergeStrategyDoesNotSupportHeads']"
		[Register ("mergeStrategyDoesNotSupportHeads")]
		public string MergeStrategyDoesNotSupportHeads {
			get {
				const string __id = "mergeStrategyDoesNotSupportHeads.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mergeStrategyDoesNotSupportHeads.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mergeUsingStrategyResultedInDescription']"
		[Register ("mergeUsingStrategyResultedInDescription")]
		public string MergeUsingStrategyResultedInDescription {
			get {
				const string __id = "mergeUsingStrategyResultedInDescription.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mergeUsingStrategyResultedInDescription.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='messageAndTaggerNotAllowedInUnannotatedTags']"
		[Register ("messageAndTaggerNotAllowedInUnannotatedTags")]
		public string MessageAndTaggerNotAllowedInUnannotatedTags {
			get {
				const string __id = "messageAndTaggerNotAllowedInUnannotatedTags.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "messageAndTaggerNotAllowedInUnannotatedTags.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='minutesAgo']"
		[Register ("minutesAgo")]
		public string MinutesAgo {
			get {
				const string __id = "minutesAgo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "minutesAgo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='missingAccesskey']"
		[Register ("missingAccesskey")]
		public string MissingAccesskey {
			get {
				const string __id = "missingAccesskey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "missingAccesskey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='missingConfigurationForKey']"
		[Register ("missingConfigurationForKey")]
		public string MissingConfigurationForKey {
			get {
				const string __id = "missingConfigurationForKey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "missingConfigurationForKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='missingDeltaBase']"
		[Register ("missingDeltaBase")]
		public string MissingDeltaBase {
			get {
				const string __id = "missingDeltaBase.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "missingDeltaBase.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='missingForwardImageInGITBinaryPatch']"
		[Register ("missingForwardImageInGITBinaryPatch")]
		public string MissingForwardImageInGITBinaryPatch {
			get {
				const string __id = "missingForwardImageInGITBinaryPatch.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "missingForwardImageInGITBinaryPatch.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='missingObject']"
		[Register ("missingObject")]
		public string MissingObject {
			get {
				const string __id = "missingObject.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "missingObject.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='missingPrerequisiteCommits']"
		[Register ("missingPrerequisiteCommits")]
		public string MissingPrerequisiteCommits {
			get {
				const string __id = "missingPrerequisiteCommits.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "missingPrerequisiteCommits.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='missingRequiredParameter']"
		[Register ("missingRequiredParameter")]
		public string MissingRequiredParameter {
			get {
				const string __id = "missingRequiredParameter.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "missingRequiredParameter.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='missingSecretkey']"
		[Register ("missingSecretkey")]
		public string MissingSecretkey {
			get {
				const string __id = "missingSecretkey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "missingSecretkey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mixedStagesNotAllowed']"
		[Register ("mixedStagesNotAllowed")]
		public string MixedStagesNotAllowed {
			get {
				const string __id = "mixedStagesNotAllowed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mixedStagesNotAllowed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mkDirFailed']"
		[Register ("mkDirFailed")]
		public string MkDirFailed {
			get {
				const string __id = "mkDirFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mkDirFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='mkDirsFailed']"
		[Register ("mkDirsFailed")]
		public string MkDirsFailed {
			get {
				const string __id = "mkDirsFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mkDirsFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='month']"
		[Register ("month")]
		public string Month {
			get {
				const string __id = "month.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "month.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='months']"
		[Register ("months")]
		public string Months {
			get {
				const string __id = "months.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "months.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='monthsAgo']"
		[Register ("monthsAgo")]
		public string MonthsAgo {
			get {
				const string __id = "monthsAgo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "monthsAgo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='multipleMergeBasesFor']"
		[Register ("multipleMergeBasesFor")]
		public string MultipleMergeBasesFor {
			get {
				const string __id = "multipleMergeBasesFor.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "multipleMergeBasesFor.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='need2Arguments']"
		[Register ("need2Arguments")]
		public string Need2Arguments {
			get {
				const string __id = "need2Arguments.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "need2Arguments.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='needPackOut']"
		[Register ("needPackOut")]
		public string NeedPackOut {
			get {
				const string __id = "needPackOut.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "needPackOut.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='needsAtLeastOneEntry']"
		[Register ("needsAtLeastOneEntry")]
		public string NeedsAtLeastOneEntry {
			get {
				const string __id = "needsAtLeastOneEntry.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "needsAtLeastOneEntry.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='needsWorkdir']"
		[Register ("needsWorkdir")]
		public string NeedsWorkdir {
			get {
				const string __id = "needsWorkdir.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "needsWorkdir.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='newlineInQuotesNotAllowed']"
		[Register ("newlineInQuotesNotAllowed")]
		public string NewlineInQuotesNotAllowed {
			get {
				const string __id = "newlineInQuotesNotAllowed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "newlineInQuotesNotAllowed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='noApplyInDelete']"
		[Register ("noApplyInDelete")]
		public string NoApplyInDelete {
			get {
				const string __id = "noApplyInDelete.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noApplyInDelete.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='noClosingBracket']"
		[Register ("noClosingBracket")]
		public string NoClosingBracket {
			get {
				const string __id = "noClosingBracket.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noClosingBracket.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='noCredentialsProvider']"
		[Register ("noCredentialsProvider")]
		public string NoCredentialsProvider {
			get {
				const string __id = "noCredentialsProvider.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noCredentialsProvider.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='noHEADExistsAndNoExplicitStartingRevisionWasSpecified']"
		[Register ("noHEADExistsAndNoExplicitStartingRevisionWasSpecified")]
		public string NoHEADExistsAndNoExplicitStartingRevisionWasSpecified {
			get {
				const string __id = "noHEADExistsAndNoExplicitStartingRevisionWasSpecified.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noHEADExistsAndNoExplicitStartingRevisionWasSpecified.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='noHMACsupport']"
		[Register ("noHMACsupport")]
		public string NoHMACsupport {
			get {
				const string __id = "noHMACsupport.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noHMACsupport.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='noMergeBase']"
		[Register ("noMergeBase")]
		public string NoMergeBase {
			get {
				const string __id = "noMergeBase.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noMergeBase.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='noMergeHeadSpecified']"
		[Register ("noMergeHeadSpecified")]
		public string NoMergeHeadSpecified {
			get {
				const string __id = "noMergeHeadSpecified.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noMergeHeadSpecified.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='noSuchRef']"
		[Register ("noSuchRef")]
		public string NoSuchRef {
			get {
				const string __id = "noSuchRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noSuchRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notABoolean']"
		[Register ("notABoolean")]
		public string NotABoolean {
			get {
				const string __id = "notABoolean.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notABoolean.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notABundle']"
		[Register ("notABundle")]
		public string NotABundle {
			get {
				const string __id = "notABundle.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notABundle.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notADIRCFile']"
		[Register ("notADIRCFile")]
		public string NotADIRCFile {
			get {
				const string __id = "notADIRCFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notADIRCFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notAGitDirectory']"
		[Register ("notAGitDirectory")]
		public string NotAGitDirectory {
			get {
				const string __id = "notAGitDirectory.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notAGitDirectory.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notAPACKFile']"
		[Register ("notAPACKFile")]
		public string NotAPACKFile {
			get {
				const string __id = "notAPACKFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notAPACKFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notARef']"
		[Register ("notARef")]
		public string NotARef {
			get {
				const string __id = "notARef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notARef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notASCIIString']"
		[Register ("notASCIIString")]
		public string NotASCIIString {
			get {
				const string __id = "notASCIIString.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notASCIIString.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notAuthorized']"
		[Register ("notAuthorized")]
		public string NotAuthorized {
			get {
				const string __id = "notAuthorized.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notAuthorized.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notAValidPack']"
		[Register ("notAValidPack")]
		public string NotAValidPack {
			get {
				const string __id = "notAValidPack.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notAValidPack.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notFound']"
		[Register ("notFound")]
		public string NotFound {
			get {
				const string __id = "notFound.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notFound.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='nothingToFetch']"
		[Register ("nothingToFetch")]
		public string NothingToFetch {
			get {
				const string __id = "nothingToFetch.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "nothingToFetch.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='nothingToPush']"
		[Register ("nothingToPush")]
		public string NothingToPush {
			get {
				const string __id = "nothingToPush.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "nothingToPush.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='notMergedExceptionMessage']"
		[Register ("notMergedExceptionMessage")]
		public string NotMergedExceptionMessage {
			get {
				const string __id = "notMergedExceptionMessage.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "notMergedExceptionMessage.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='noXMLParserAvailable']"
		[Register ("noXMLParserAvailable")]
		public string NoXMLParserAvailable {
			get {
				const string __id = "noXMLParserAvailable.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noXMLParserAvailable.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='objectAtHasBadZlibStream']"
		[Register ("objectAtHasBadZlibStream")]
		public string ObjectAtHasBadZlibStream {
			get {
				const string __id = "objectAtHasBadZlibStream.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "objectAtHasBadZlibStream.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='objectAtPathDoesNotHaveId']"
		[Register ("objectAtPathDoesNotHaveId")]
		public string ObjectAtPathDoesNotHaveId {
			get {
				const string __id = "objectAtPathDoesNotHaveId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "objectAtPathDoesNotHaveId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='objectIsCorrupt']"
		[Register ("objectIsCorrupt")]
		public string ObjectIsCorrupt {
			get {
				const string __id = "objectIsCorrupt.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "objectIsCorrupt.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='objectIsNotA']"
		[Register ("objectIsNotA")]
		public string ObjectIsNotA {
			get {
				const string __id = "objectIsNotA.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "objectIsNotA.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='objectNotFound']"
		[Register ("objectNotFound")]
		public string ObjectNotFound {
			get {
				const string __id = "objectNotFound.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "objectNotFound.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='objectNotFoundIn']"
		[Register ("objectNotFoundIn")]
		public string ObjectNotFoundIn {
			get {
				const string __id = "objectNotFoundIn.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "objectNotFoundIn.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='obtainingCommitsForCherryPick']"
		[Register ("obtainingCommitsForCherryPick")]
		public string ObtainingCommitsForCherryPick {
			get {
				const string __id = "obtainingCommitsForCherryPick.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "obtainingCommitsForCherryPick.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='offsetWrittenDeltaBaseForObjectNotFoundInAPack']"
		[Register ("offsetWrittenDeltaBaseForObjectNotFoundInAPack")]
		public string OffsetWrittenDeltaBaseForObjectNotFoundInAPack {
			get {
				const string __id = "offsetWrittenDeltaBaseForObjectNotFoundInAPack.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "offsetWrittenDeltaBaseForObjectNotFoundInAPack.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='onlyAlreadyUpToDateAndFastForwardMergesAreAvailable']"
		[Register ("onlyAlreadyUpToDateAndFastForwardMergesAreAvailable")]
		public string OnlyAlreadyUpToDateAndFastForwardMergesAreAvailable {
			get {
				const string __id = "onlyAlreadyUpToDateAndFastForwardMergesAreAvailable.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "onlyAlreadyUpToDateAndFastForwardMergesAreAvailable.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='onlyOneFetchSupported']"
		[Register ("onlyOneFetchSupported")]
		public string OnlyOneFetchSupported {
			get {
				const string __id = "onlyOneFetchSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "onlyOneFetchSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='onlyOneOperationCallPerConnectionIsSupported']"
		[Register ("onlyOneOperationCallPerConnectionIsSupported")]
		public string OnlyOneOperationCallPerConnectionIsSupported {
			get {
				const string __id = "onlyOneOperationCallPerConnectionIsSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "onlyOneOperationCallPerConnectionIsSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='openFilesMustBeAtLeast1']"
		[Register ("openFilesMustBeAtLeast1")]
		public string OpenFilesMustBeAtLeast1 {
			get {
				const string __id = "openFilesMustBeAtLeast1.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "openFilesMustBeAtLeast1.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='openingConnection']"
		[Register ("openingConnection")]
		public string OpeningConnection {
			get {
				const string __id = "openingConnection.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "openingConnection.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='operationCanceled']"
		[Register ("operationCanceled")]
		public string OperationCanceled {
			get {
				const string __id = "operationCanceled.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "operationCanceled.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='outputHasAlreadyBeenStarted']"
		[Register ("outputHasAlreadyBeenStarted")]
		public string OutputHasAlreadyBeenStarted {
			get {
				const string __id = "outputHasAlreadyBeenStarted.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "outputHasAlreadyBeenStarted.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packChecksumMismatch']"
		[Register ("packChecksumMismatch")]
		public string PackChecksumMismatch {
			get {
				const string __id = "packChecksumMismatch.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packChecksumMismatch.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packCorruptedWhileWritingToFilesystem']"
		[Register ("packCorruptedWhileWritingToFilesystem")]
		public string PackCorruptedWhileWritingToFilesystem {
			get {
				const string __id = "packCorruptedWhileWritingToFilesystem.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packCorruptedWhileWritingToFilesystem.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packDoesNotMatchIndex']"
		[Register ("packDoesNotMatchIndex")]
		public string PackDoesNotMatchIndex {
			get {
				const string __id = "packDoesNotMatchIndex.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packDoesNotMatchIndex.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packetSizeMustBeAtLeast']"
		[Register ("packetSizeMustBeAtLeast")]
		public string PacketSizeMustBeAtLeast {
			get {
				const string __id = "packetSizeMustBeAtLeast.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packetSizeMustBeAtLeast.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packetSizeMustBeAtMost']"
		[Register ("packetSizeMustBeAtMost")]
		public string PacketSizeMustBeAtMost {
			get {
				const string __id = "packetSizeMustBeAtMost.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packetSizeMustBeAtMost.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packfileCorruptionDetected']"
		[Register ("packfileCorruptionDetected")]
		public string PackfileCorruptionDetected {
			get {
				const string __id = "packfileCorruptionDetected.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packfileCorruptionDetected.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packFileInvalid']"
		[Register ("packFileInvalid")]
		public string PackFileInvalid {
			get {
				const string __id = "packFileInvalid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packFileInvalid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packfileIsTruncated']"
		[Register ("packfileIsTruncated")]
		public string PackfileIsTruncated {
			get {
				const string __id = "packfileIsTruncated.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packfileIsTruncated.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packfileIsTruncatedNoParam']"
		[Register ("packfileIsTruncatedNoParam")]
		public string PackfileIsTruncatedNoParam {
			get {
				const string __id = "packfileIsTruncatedNoParam.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packfileIsTruncatedNoParam.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packHasUnresolvedDeltas']"
		[Register ("packHasUnresolvedDeltas")]
		public string PackHasUnresolvedDeltas {
			get {
				const string __id = "packHasUnresolvedDeltas.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packHasUnresolvedDeltas.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packingCancelledDuringObjectsWriting']"
		[Register ("packingCancelledDuringObjectsWriting")]
		public string PackingCancelledDuringObjectsWriting {
			get {
				const string __id = "packingCancelledDuringObjectsWriting.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packingCancelledDuringObjectsWriting.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packObjectCountMismatch']"
		[Register ("packObjectCountMismatch")]
		public string PackObjectCountMismatch {
			get {
				const string __id = "packObjectCountMismatch.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packObjectCountMismatch.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packRefs']"
		[Register ("packRefs")]
		public string PackRefs {
			get {
				const string __id = "packRefs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packRefs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packSizeNotSetYet']"
		[Register ("packSizeNotSetYet")]
		public string PackSizeNotSetYet {
			get {
				const string __id = "packSizeNotSetYet.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packSizeNotSetYet.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packTooLargeForIndexVersion1']"
		[Register ("packTooLargeForIndexVersion1")]
		public string PackTooLargeForIndexVersion1 {
			get {
				const string __id = "packTooLargeForIndexVersion1.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packTooLargeForIndexVersion1.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packWasDeleted']"
		[Register ("packWasDeleted")]
		public string PackWasDeleted {
			get {
				const string __id = "packWasDeleted.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packWasDeleted.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='packWriterStatistics']"
		[Register ("packWriterStatistics")]
		public string PackWriterStatistics {
			get {
				const string __id = "packWriterStatistics.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packWriterStatistics.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='panicCantRenameIndexFile']"
		[Register ("panicCantRenameIndexFile")]
		public string PanicCantRenameIndexFile {
			get {
				const string __id = "panicCantRenameIndexFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "panicCantRenameIndexFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='patchApplyException']"
		[Register ("patchApplyException")]
		public string PatchApplyException {
			get {
				const string __id = "patchApplyException.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "patchApplyException.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='patchFormatException']"
		[Register ("patchFormatException")]
		public string PatchFormatException {
			get {
				const string __id = "patchFormatException.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "patchFormatException.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='pathIsNotInWorkingDir']"
		[Register ("pathIsNotInWorkingDir")]
		public string PathIsNotInWorkingDir {
			get {
				const string __id = "pathIsNotInWorkingDir.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pathIsNotInWorkingDir.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='pathNotConfigured']"
		[Register ("pathNotConfigured")]
		public string PathNotConfigured {
			get {
				const string __id = "pathNotConfigured.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pathNotConfigured.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='peeledLineBeforeRef']"
		[Register ("peeledLineBeforeRef")]
		public string PeeledLineBeforeRef {
			get {
				const string __id = "peeledLineBeforeRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "peeledLineBeforeRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='peerDidNotSupplyACompleteObjectGraph']"
		[Register ("peerDidNotSupplyACompleteObjectGraph")]
		public string PeerDidNotSupplyACompleteObjectGraph {
			get {
				const string __id = "peerDidNotSupplyACompleteObjectGraph.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "peerDidNotSupplyACompleteObjectGraph.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='prefixRemote']"
		[Register ("prefixRemote")]
		public string PrefixRemote {
			get {
				const string __id = "prefixRemote.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "prefixRemote.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='problemWithResolvingPushRefSpecsLocally']"
		[Register ("problemWithResolvingPushRefSpecsLocally")]
		public string ProblemWithResolvingPushRefSpecsLocally {
			get {
				const string __id = "problemWithResolvingPushRefSpecsLocally.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "problemWithResolvingPushRefSpecsLocally.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='progressMonUploading']"
		[Register ("progressMonUploading")]
		public string ProgressMonUploading {
			get {
				const string __id = "progressMonUploading.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "progressMonUploading.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='propertyIsAlreadyNonNull']"
		[Register ("propertyIsAlreadyNonNull")]
		public string PropertyIsAlreadyNonNull {
			get {
				const string __id = "propertyIsAlreadyNonNull.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "propertyIsAlreadyNonNull.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='pruneLoosePackedObjects']"
		[Register ("pruneLoosePackedObjects")]
		public string PruneLoosePackedObjects {
			get {
				const string __id = "pruneLoosePackedObjects.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pruneLoosePackedObjects.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='pruneLooseUnreferencedObjects']"
		[Register ("pruneLooseUnreferencedObjects")]
		public string PruneLooseUnreferencedObjects {
			get {
				const string __id = "pruneLooseUnreferencedObjects.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pruneLooseUnreferencedObjects.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='pullOnRepoWithoutHEADCurrentlyNotSupported']"
		[Register ("pullOnRepoWithoutHEADCurrentlyNotSupported")]
		public string PullOnRepoWithoutHEADCurrentlyNotSupported {
			get {
				const string __id = "pullOnRepoWithoutHEADCurrentlyNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pullOnRepoWithoutHEADCurrentlyNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='pullTaskName']"
		[Register ("pullTaskName")]
		public string PullTaskName {
			get {
				const string __id = "pullTaskName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pullTaskName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='pushCancelled']"
		[Register ("pushCancelled")]
		public string PushCancelled {
			get {
				const string __id = "pushCancelled.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pushCancelled.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='pushIsNotSupportedForBundleTransport']"
		[Register ("pushIsNotSupportedForBundleTransport")]
		public string PushIsNotSupportedForBundleTransport {
			get {
				const string __id = "pushIsNotSupportedForBundleTransport.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pushIsNotSupportedForBundleTransport.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='pushNotPermitted']"
		[Register ("pushNotPermitted")]
		public string PushNotPermitted {
			get {
				const string __id = "pushNotPermitted.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pushNotPermitted.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='rawLogMessageDoesNotParseAsLogEntry']"
		[Register ("rawLogMessageDoesNotParseAsLogEntry")]
		public string RawLogMessageDoesNotParseAsLogEntry {
			get {
				const string __id = "rawLogMessageDoesNotParseAsLogEntry.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rawLogMessageDoesNotParseAsLogEntry.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='readingObjectsFromLocalRepositoryFailed']"
		[Register ("readingObjectsFromLocalRepositoryFailed")]
		public string ReadingObjectsFromLocalRepositoryFailed {
			get {
				const string __id = "readingObjectsFromLocalRepositoryFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "readingObjectsFromLocalRepositoryFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='readTimedOut']"
		[Register ("readTimedOut")]
		public string ReadTimedOut {
			get {
				const string __id = "readTimedOut.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "readTimedOut.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='receivePackInvalidLimit']"
		[Register ("receivePackInvalidLimit")]
		public string ReceivePackInvalidLimit {
			get {
				const string __id = "receivePackInvalidLimit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "receivePackInvalidLimit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='receivePackObjectTooLarge1']"
		[Register ("receivePackObjectTooLarge1")]
		public string ReceivePackObjectTooLarge1 {
			get {
				const string __id = "receivePackObjectTooLarge1.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "receivePackObjectTooLarge1.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='receivePackObjectTooLarge2']"
		[Register ("receivePackObjectTooLarge2")]
		public string ReceivePackObjectTooLarge2 {
			get {
				const string __id = "receivePackObjectTooLarge2.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "receivePackObjectTooLarge2.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='receivePackTooLarge']"
		[Register ("receivePackTooLarge")]
		public string ReceivePackTooLarge {
			get {
				const string __id = "receivePackTooLarge.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "receivePackTooLarge.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='receivingObjects']"
		[Register ("receivingObjects")]
		public string ReceivingObjects {
			get {
				const string __id = "receivingObjects.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "receivingObjects.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='refAlreadyExists']"
		[Register ("refAlreadyExists")]
		public string RefAlreadyExists {
			get {
				const string __id = "refAlreadyExists.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "refAlreadyExists.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='refAlreadyExists1']"
		[Register ("refAlreadyExists1")]
		public string RefAlreadyExists1 {
			get {
				const string __id = "refAlreadyExists1.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "refAlreadyExists1.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='reflogEntryNotFound']"
		[Register ("reflogEntryNotFound")]
		public string ReflogEntryNotFound {
			get {
				const string __id = "reflogEntryNotFound.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "reflogEntryNotFound.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='refNotResolved']"
		[Register ("refNotResolved")]
		public string RefNotResolved {
			get {
				const string __id = "refNotResolved.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "refNotResolved.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='refUpdateReturnCodeWas']"
		[Register ("refUpdateReturnCodeWas")]
		public string RefUpdateReturnCodeWas {
			get {
				const string __id = "refUpdateReturnCodeWas.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "refUpdateReturnCodeWas.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='remoteConfigHasNoURIAssociated']"
		[Register ("remoteConfigHasNoURIAssociated")]
		public string RemoteConfigHasNoURIAssociated {
			get {
				const string __id = "remoteConfigHasNoURIAssociated.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "remoteConfigHasNoURIAssociated.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='remoteDoesNotHaveSpec']"
		[Register ("remoteDoesNotHaveSpec")]
		public string RemoteDoesNotHaveSpec {
			get {
				const string __id = "remoteDoesNotHaveSpec.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "remoteDoesNotHaveSpec.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='remoteDoesNotSupportSmartHTTPPush']"
		[Register ("remoteDoesNotSupportSmartHTTPPush")]
		public string RemoteDoesNotSupportSmartHTTPPush {
			get {
				const string __id = "remoteDoesNotSupportSmartHTTPPush.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "remoteDoesNotSupportSmartHTTPPush.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='remoteHungUpUnexpectedly']"
		[Register ("remoteHungUpUnexpectedly")]
		public string RemoteHungUpUnexpectedly {
			get {
				const string __id = "remoteHungUpUnexpectedly.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "remoteHungUpUnexpectedly.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='remoteNameCantBeNull']"
		[Register ("remoteNameCantBeNull")]
		public string RemoteNameCantBeNull {
			get {
				const string __id = "remoteNameCantBeNull.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "remoteNameCantBeNull.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='renameBranchFailedBecauseTag']"
		[Register ("renameBranchFailedBecauseTag")]
		public string RenameBranchFailedBecauseTag {
			get {
				const string __id = "renameBranchFailedBecauseTag.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "renameBranchFailedBecauseTag.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='renameBranchFailedUnknownReason']"
		[Register ("renameBranchFailedUnknownReason")]
		public string RenameBranchFailedUnknownReason {
			get {
				const string __id = "renameBranchFailedUnknownReason.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "renameBranchFailedUnknownReason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='renameBranchUnexpectedResult']"
		[Register ("renameBranchUnexpectedResult")]
		public string RenameBranchUnexpectedResult {
			get {
				const string __id = "renameBranchUnexpectedResult.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "renameBranchUnexpectedResult.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='renameFileFailed']"
		[Register ("renameFileFailed")]
		public string RenameFileFailed {
			get {
				const string __id = "renameFileFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "renameFileFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='renamesAlreadyFound']"
		[Register ("renamesAlreadyFound")]
		public string RenamesAlreadyFound {
			get {
				const string __id = "renamesAlreadyFound.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "renamesAlreadyFound.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='renamesBreakingModifies']"
		[Register ("renamesBreakingModifies")]
		public string RenamesBreakingModifies {
			get {
				const string __id = "renamesBreakingModifies.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "renamesBreakingModifies.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='renamesFindingByContent']"
		[Register ("renamesFindingByContent")]
		public string RenamesFindingByContent {
			get {
				const string __id = "renamesFindingByContent.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "renamesFindingByContent.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='renamesFindingExact']"
		[Register ("renamesFindingExact")]
		public string RenamesFindingExact {
			get {
				const string __id = "renamesFindingExact.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "renamesFindingExact.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='renamesRejoiningModifies']"
		[Register ("renamesRejoiningModifies")]
		public string RenamesRejoiningModifies {
			get {
				const string __id = "renamesRejoiningModifies.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "renamesRejoiningModifies.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryAlreadyExists']"
		[Register ("repositoryAlreadyExists")]
		public string RepositoryAlreadyExists {
			get {
				const string __id = "repositoryAlreadyExists.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryAlreadyExists.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryConfigFileInvalid']"
		[Register ("repositoryConfigFileInvalid")]
		public string RepositoryConfigFileInvalid {
			get {
				const string __id = "repositoryConfigFileInvalid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryConfigFileInvalid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryIsRequired']"
		[Register ("repositoryIsRequired")]
		public string RepositoryIsRequired {
			get {
				const string __id = "repositoryIsRequired.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryIsRequired.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryNotFound']"
		[Register ("repositoryNotFound")]
		public string RepositoryNotFound {
			get {
				const string __id = "repositoryNotFound.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryNotFound.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryState_applyMailbox']"
		[Register ("repositoryState_applyMailbox")]
		public string RepositoryStateApplyMailbox {
			get {
				const string __id = "repositoryState_applyMailbox.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryState_applyMailbox.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryState_bisecting']"
		[Register ("repositoryState_bisecting")]
		public string RepositoryStateBisecting {
			get {
				const string __id = "repositoryState_bisecting.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryState_bisecting.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryState_conflicts']"
		[Register ("repositoryState_conflicts")]
		public string RepositoryStateConflicts {
			get {
				const string __id = "repositoryState_conflicts.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryState_conflicts.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryState_merged']"
		[Register ("repositoryState_merged")]
		public string RepositoryStateMerged {
			get {
				const string __id = "repositoryState_merged.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryState_merged.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryState_normal']"
		[Register ("repositoryState_normal")]
		public string RepositoryStateNormal {
			get {
				const string __id = "repositoryState_normal.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryState_normal.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryState_rebase']"
		[Register ("repositoryState_rebase")]
		public string RepositoryStateRebase {
			get {
				const string __id = "repositoryState_rebase.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryState_rebase.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryState_rebaseInteractive']"
		[Register ("repositoryState_rebaseInteractive")]
		public string RepositoryStateRebaseInteractive {
			get {
				const string __id = "repositoryState_rebaseInteractive.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryState_rebaseInteractive.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryState_rebaseOrApplyMailbox']"
		[Register ("repositoryState_rebaseOrApplyMailbox")]
		public string RepositoryStateRebaseOrApplyMailbox {
			get {
				const string __id = "repositoryState_rebaseOrApplyMailbox.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryState_rebaseOrApplyMailbox.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='repositoryState_rebaseWithMerge']"
		[Register ("repositoryState_rebaseWithMerge")]
		public string RepositoryStateRebaseWithMerge {
			get {
				const string __id = "repositoryState_rebaseWithMerge.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "repositoryState_rebaseWithMerge.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='requiredHashFunctionNotAvailable']"
		[Register ("requiredHashFunctionNotAvailable")]
		public string RequiredHashFunctionNotAvailable {
			get {
				const string __id = "requiredHashFunctionNotAvailable.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "requiredHashFunctionNotAvailable.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='resettingHead']"
		[Register ("resettingHead")]
		public string ResettingHead {
			get {
				const string __id = "resettingHead.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "resettingHead.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='resolvingDeltas']"
		[Register ("resolvingDeltas")]
		public string ResolvingDeltas {
			get {
				const string __id = "resolvingDeltas.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "resolvingDeltas.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='resultLengthIncorrect']"
		[Register ("resultLengthIncorrect")]
		public string ResultLengthIncorrect {
			get {
				const string __id = "resultLengthIncorrect.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "resultLengthIncorrect.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='rewinding']"
		[Register ("rewinding")]
		public string Rewinding {
			get {
				const string __id = "rewinding.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rewinding.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='searchForReuse']"
		[Register ("searchForReuse")]
		public string SearchForReuse {
			get {
				const string __id = "searchForReuse.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "searchForReuse.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='searchForSizes']"
		[Register ("searchForSizes")]
		public string SearchForSizes {
			get {
				const string __id = "searchForSizes.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "searchForSizes.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='secondsAgo']"
		[Register ("secondsAgo")]
		public string SecondsAgo {
			get {
				const string __id = "secondsAgo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "secondsAgo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='selectingCommits']"
		[Register ("selectingCommits")]
		public string SelectingCommits {
			get {
				const string __id = "selectingCommits.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "selectingCommits.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='sequenceTooLargeForDiffAlgorithm']"
		[Register ("sequenceTooLargeForDiffAlgorithm")]
		public string SequenceTooLargeForDiffAlgorithm {
			get {
				const string __id = "sequenceTooLargeForDiffAlgorithm.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sequenceTooLargeForDiffAlgorithm.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='serviceNotEnabledNoName']"
		[Register ("serviceNotEnabledNoName")]
		public string ServiceNotEnabledNoName {
			get {
				const string __id = "serviceNotEnabledNoName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "serviceNotEnabledNoName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='serviceNotPermitted']"
		[Register ("serviceNotPermitted")]
		public string ServiceNotPermitted {
			get {
				const string __id = "serviceNotPermitted.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "serviceNotPermitted.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='serviceNotPermittedNoName']"
		[Register ("serviceNotPermittedNoName")]
		public string ServiceNotPermittedNoName {
			get {
				const string __id = "serviceNotPermittedNoName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "serviceNotPermittedNoName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='shallowCommitsAlreadyInitialized']"
		[Register ("shallowCommitsAlreadyInitialized")]
		public string ShallowCommitsAlreadyInitialized {
			get {
				const string __id = "shallowCommitsAlreadyInitialized.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "shallowCommitsAlreadyInitialized.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='shortCompressedStreamAt']"
		[Register ("shortCompressedStreamAt")]
		public string ShortCompressedStreamAt {
			get {
				const string __id = "shortCompressedStreamAt.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "shortCompressedStreamAt.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='shortReadOfBlock']"
		[Register ("shortReadOfBlock")]
		public string ShortReadOfBlock {
			get {
				const string __id = "shortReadOfBlock.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "shortReadOfBlock.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='shortReadOfOptionalDIRCExtensionExpectedAnotherBytes']"
		[Register ("shortReadOfOptionalDIRCExtensionExpectedAnotherBytes")]
		public string ShortReadOfOptionalDIRCExtensionExpectedAnotherBytes {
			get {
				const string __id = "shortReadOfOptionalDIRCExtensionExpectedAnotherBytes.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "shortReadOfOptionalDIRCExtensionExpectedAnotherBytes.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='shortSkipOfBlock']"
		[Register ("shortSkipOfBlock")]
		public string ShortSkipOfBlock {
			get {
				const string __id = "shortSkipOfBlock.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "shortSkipOfBlock.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='signingNotSupportedOnTag']"
		[Register ("signingNotSupportedOnTag")]
		public string SigningNotSupportedOnTag {
			get {
				const string __id = "signingNotSupportedOnTag.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "signingNotSupportedOnTag.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='similarityScoreMustBeWithinBounds']"
		[Register ("similarityScoreMustBeWithinBounds")]
		public string SimilarityScoreMustBeWithinBounds {
			get {
				const string __id = "similarityScoreMustBeWithinBounds.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "similarityScoreMustBeWithinBounds.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='sizeExceeds2GB']"
		[Register ("sizeExceeds2GB")]
		public string SizeExceeds2GB {
			get {
				const string __id = "sizeExceeds2GB.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sizeExceeds2GB.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='skipMustBeNonNegative']"
		[Register ("skipMustBeNonNegative")]
		public string SkipMustBeNonNegative {
			get {
				const string __id = "skipMustBeNonNegative.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "skipMustBeNonNegative.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='smartHTTPPushDisabled']"
		[Register ("smartHTTPPushDisabled")]
		public string SmartHTTPPushDisabled {
			get {
				const string __id = "smartHTTPPushDisabled.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "smartHTTPPushDisabled.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='sourceDestinationMustMatch']"
		[Register ("sourceDestinationMustMatch")]
		public string SourceDestinationMustMatch {
			get {
				const string __id = "sourceDestinationMustMatch.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sourceDestinationMustMatch.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='sourceIsNotAWildcard']"
		[Register ("sourceIsNotAWildcard")]
		public string SourceIsNotAWildcard {
			get {
				const string __id = "sourceIsNotAWildcard.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sourceIsNotAWildcard.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='sourceRefDoesntResolveToAnyObject']"
		[Register ("sourceRefDoesntResolveToAnyObject")]
		public string SourceRefDoesntResolveToAnyObject {
			get {
				const string __id = "sourceRefDoesntResolveToAnyObject.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sourceRefDoesntResolveToAnyObject.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='sourceRefNotSpecifiedForRefspec']"
		[Register ("sourceRefNotSpecifiedForRefspec")]
		public string SourceRefNotSpecifiedForRefspec {
			get {
				const string __id = "sourceRefNotSpecifiedForRefspec.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sourceRefNotSpecifiedForRefspec.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='squashCommitNotUpdatingHEAD']"
		[Register ("squashCommitNotUpdatingHEAD")]
		public string SquashCommitNotUpdatingHEAD {
			get {
				const string __id = "squashCommitNotUpdatingHEAD.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "squashCommitNotUpdatingHEAD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='staleRevFlagsOn']"
		[Register ("staleRevFlagsOn")]
		public string StaleRevFlagsOn {
			get {
				const string __id = "staleRevFlagsOn.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "staleRevFlagsOn.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='startingReadStageWithoutWrittenRequestDataPendingIsNotSupported']"
		[Register ("startingReadStageWithoutWrittenRequestDataPendingIsNotSupported")]
		public string StartingReadStageWithoutWrittenRequestDataPendingIsNotSupported {
			get {
				const string __id = "startingReadStageWithoutWrittenRequestDataPendingIsNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "startingReadStageWithoutWrittenRequestDataPendingIsNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashApplyConflict']"
		[Register ("stashApplyConflict")]
		public string StashApplyConflict {
			get {
				const string __id = "stashApplyConflict.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashApplyConflict.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashApplyConflictInIndex']"
		[Register ("stashApplyConflictInIndex")]
		public string StashApplyConflictInIndex {
			get {
				const string __id = "stashApplyConflictInIndex.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashApplyConflictInIndex.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashApplyFailed']"
		[Register ("stashApplyFailed")]
		public string StashApplyFailed {
			get {
				const string __id = "stashApplyFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashApplyFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashApplyOnUnsafeRepository']"
		[Register ("stashApplyOnUnsafeRepository")]
		public string StashApplyOnUnsafeRepository {
			get {
				const string __id = "stashApplyOnUnsafeRepository.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashApplyOnUnsafeRepository.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashApplyWithoutHead']"
		[Register ("stashApplyWithoutHead")]
		public string StashApplyWithoutHead {
			get {
				const string __id = "stashApplyWithoutHead.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashApplyWithoutHead.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashCommitIncorrectNumberOfParents']"
		[Register ("stashCommitIncorrectNumberOfParents")]
		public string StashCommitIncorrectNumberOfParents {
			get {
				const string __id = "stashCommitIncorrectNumberOfParents.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashCommitIncorrectNumberOfParents.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashDropDeleteRefFailed']"
		[Register ("stashDropDeleteRefFailed")]
		public string StashDropDeleteRefFailed {
			get {
				const string __id = "stashDropDeleteRefFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashDropDeleteRefFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashDropFailed']"
		[Register ("stashDropFailed")]
		public string StashDropFailed {
			get {
				const string __id = "stashDropFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashDropFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashDropMissingReflog']"
		[Register ("stashDropMissingReflog")]
		public string StashDropMissingReflog {
			get {
				const string __id = "stashDropMissingReflog.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashDropMissingReflog.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashFailed']"
		[Register ("stashFailed")]
		public string StashFailed {
			get {
				const string __id = "stashFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='stashResolveFailed']"
		[Register ("stashResolveFailed")]
		public string StashResolveFailed {
			get {
				const string __id = "stashResolveFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stashResolveFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='statelessRPCRequiresOptionToBeEnabled']"
		[Register ("statelessRPCRequiresOptionToBeEnabled")]
		public string StatelessRPCRequiresOptionToBeEnabled {
			get {
				const string __id = "statelessRPCRequiresOptionToBeEnabled.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "statelessRPCRequiresOptionToBeEnabled.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='submoduleExists']"
		[Register ("submoduleExists")]
		public string SubmoduleExists {
			get {
				const string __id = "submoduleExists.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "submoduleExists.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='submoduleParentRemoteUrlInvalid']"
		[Register ("submoduleParentRemoteUrlInvalid")]
		public string SubmoduleParentRemoteUrlInvalid {
			get {
				const string __id = "submoduleParentRemoteUrlInvalid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "submoduleParentRemoteUrlInvalid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='submodulesNotSupported']"
		[Register ("submodulesNotSupported")]
		public string SubmodulesNotSupported {
			get {
				const string __id = "submodulesNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "submodulesNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='symlinkCannotBeWrittenAsTheLinkTarget']"
		[Register ("symlinkCannotBeWrittenAsTheLinkTarget")]
		public string SymlinkCannotBeWrittenAsTheLinkTarget {
			get {
				const string __id = "symlinkCannotBeWrittenAsTheLinkTarget.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "symlinkCannotBeWrittenAsTheLinkTarget.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='systemConfigFileInvalid']"
		[Register ("systemConfigFileInvalid")]
		public string SystemConfigFileInvalid {
			get {
				const string __id = "systemConfigFileInvalid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "systemConfigFileInvalid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='tagAlreadyExists']"
		[Register ("tagAlreadyExists")]
		public string TagAlreadyExists {
			get {
				const string __id = "tagAlreadyExists.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tagAlreadyExists.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='tagNameInvalid']"
		[Register ("tagNameInvalid")]
		public string TagNameInvalid {
			get {
				const string __id = "tagNameInvalid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tagNameInvalid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='tagOnRepoWithoutHEADCurrentlyNotSupported']"
		[Register ("tagOnRepoWithoutHEADCurrentlyNotSupported")]
		public string TagOnRepoWithoutHEADCurrentlyNotSupported {
			get {
				const string __id = "tagOnRepoWithoutHEADCurrentlyNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tagOnRepoWithoutHEADCurrentlyNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='theFactoryMustNotBeNull']"
		[Register ("theFactoryMustNotBeNull")]
		public string TheFactoryMustNotBeNull {
			get {
				const string __id = "theFactoryMustNotBeNull.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "theFactoryMustNotBeNull.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='timerAlreadyTerminated']"
		[Register ("timerAlreadyTerminated")]
		public string TimerAlreadyTerminated {
			get {
				const string __id = "timerAlreadyTerminated.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "timerAlreadyTerminated.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='topologicalSortRequired']"
		[Register ("topologicalSortRequired")]
		public string TopologicalSortRequired {
			get {
				const string __id = "topologicalSortRequired.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "topologicalSortRequired.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transactionAborted']"
		[Register ("transactionAborted")]
		public string TransactionAborted {
			get {
				const string __id = "transactionAborted.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transactionAborted.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportExceptionBadRef']"
		[Register ("transportExceptionBadRef")]
		public string TransportExceptionBadRef {
			get {
				const string __id = "transportExceptionBadRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportExceptionBadRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportExceptionEmptyRef']"
		[Register ("transportExceptionEmptyRef")]
		public string TransportExceptionEmptyRef {
			get {
				const string __id = "transportExceptionEmptyRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportExceptionEmptyRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportExceptionInvalid']"
		[Register ("transportExceptionInvalid")]
		public string TransportExceptionInvalid {
			get {
				const string __id = "transportExceptionInvalid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportExceptionInvalid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportExceptionMissingAssumed']"
		[Register ("transportExceptionMissingAssumed")]
		public string TransportExceptionMissingAssumed {
			get {
				const string __id = "transportExceptionMissingAssumed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportExceptionMissingAssumed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportExceptionReadRef']"
		[Register ("transportExceptionReadRef")]
		public string TransportExceptionReadRef {
			get {
				const string __id = "transportExceptionReadRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportExceptionReadRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportNeedsRepository']"
		[Register ("transportNeedsRepository")]
		public string TransportNeedsRepository {
			get {
				const string __id = "transportNeedsRepository.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportNeedsRepository.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportProtoAmazonS3']"
		[Register ("transportProtoAmazonS3")]
		public string TransportProtoAmazonS3 {
			get {
				const string __id = "transportProtoAmazonS3.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportProtoAmazonS3.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportProtoBundleFile']"
		[Register ("transportProtoBundleFile")]
		public string TransportProtoBundleFile {
			get {
				const string __id = "transportProtoBundleFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportProtoBundleFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportProtoFTP']"
		[Register ("transportProtoFTP")]
		public string TransportProtoFTP {
			get {
				const string __id = "transportProtoFTP.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportProtoFTP.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportProtoGitAnon']"
		[Register ("transportProtoGitAnon")]
		public string TransportProtoGitAnon {
			get {
				const string __id = "transportProtoGitAnon.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportProtoGitAnon.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportProtoHTTP']"
		[Register ("transportProtoHTTP")]
		public string TransportProtoHTTP {
			get {
				const string __id = "transportProtoHTTP.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportProtoHTTP.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportProtoLocal']"
		[Register ("transportProtoLocal")]
		public string TransportProtoLocal {
			get {
				const string __id = "transportProtoLocal.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportProtoLocal.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportProtoSFTP']"
		[Register ("transportProtoSFTP")]
		public string TransportProtoSFTP {
			get {
				const string __id = "transportProtoSFTP.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportProtoSFTP.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportProtoSSH']"
		[Register ("transportProtoSSH")]
		public string TransportProtoSSH {
			get {
				const string __id = "transportProtoSSH.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportProtoSSH.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='transportSSHRetryInterrupt']"
		[Register ("transportSSHRetryInterrupt")]
		public string TransportSSHRetryInterrupt {
			get {
				const string __id = "transportSSHRetryInterrupt.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transportSSHRetryInterrupt.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='treeEntryAlreadyExists']"
		[Register ("treeEntryAlreadyExists")]
		public string TreeEntryAlreadyExists {
			get {
				const string __id = "treeEntryAlreadyExists.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "treeEntryAlreadyExists.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='treeFilterMarkerTooManyFilters']"
		[Register ("treeFilterMarkerTooManyFilters")]
		public string TreeFilterMarkerTooManyFilters {
			get {
				const string __id = "treeFilterMarkerTooManyFilters.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "treeFilterMarkerTooManyFilters.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='treeIteratorDoesNotSupportRemove']"
		[Register ("treeIteratorDoesNotSupportRemove")]
		public string TreeIteratorDoesNotSupportRemove {
			get {
				const string __id = "treeIteratorDoesNotSupportRemove.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "treeIteratorDoesNotSupportRemove.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='treeWalkMustHaveExactlyTwoTrees']"
		[Register ("treeWalkMustHaveExactlyTwoTrees")]
		public string TreeWalkMustHaveExactlyTwoTrees {
			get {
				const string __id = "treeWalkMustHaveExactlyTwoTrees.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "treeWalkMustHaveExactlyTwoTrees.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='truncatedHunkLinesMissingForAncestor']"
		[Register ("truncatedHunkLinesMissingForAncestor")]
		public string TruncatedHunkLinesMissingForAncestor {
			get {
				const string __id = "truncatedHunkLinesMissingForAncestor.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "truncatedHunkLinesMissingForAncestor.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='truncatedHunkNewLinesMissing']"
		[Register ("truncatedHunkNewLinesMissing")]
		public string TruncatedHunkNewLinesMissing {
			get {
				const string __id = "truncatedHunkNewLinesMissing.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "truncatedHunkNewLinesMissing.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='truncatedHunkOldLinesMissing']"
		[Register ("truncatedHunkOldLinesMissing")]
		public string TruncatedHunkOldLinesMissing {
			get {
				const string __id = "truncatedHunkOldLinesMissing.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "truncatedHunkOldLinesMissing.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='tSizeMustBeGreaterOrEqual1']"
		[Register ("tSizeMustBeGreaterOrEqual1")]
		public string TSizeMustBeGreaterOrEqual1 {
			get {
				const string __id = "tSizeMustBeGreaterOrEqual1.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tSizeMustBeGreaterOrEqual1.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unableToCheckConnectivity']"
		[Register ("unableToCheckConnectivity")]
		public string UnableToCheckConnectivity {
			get {
				const string __id = "unableToCheckConnectivity.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unableToCheckConnectivity.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unableToStore']"
		[Register ("unableToStore")]
		public string UnableToStore {
			get {
				const string __id = "unableToStore.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unableToStore.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unableToWrite']"
		[Register ("unableToWrite")]
		public string UnableToWrite {
			get {
				const string __id = "unableToWrite.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unableToWrite.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unencodeableFile']"
		[Register ("unencodeableFile")]
		public string UnencodeableFile {
			get {
				const string __id = "unencodeableFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unencodeableFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unexpectedCompareResult']"
		[Register ("unexpectedCompareResult")]
		public string UnexpectedCompareResult {
			get {
				const string __id = "unexpectedCompareResult.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unexpectedCompareResult.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unexpectedEndOfConfigFile']"
		[Register ("unexpectedEndOfConfigFile")]
		public string UnexpectedEndOfConfigFile {
			get {
				const string __id = "unexpectedEndOfConfigFile.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unexpectedEndOfConfigFile.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unexpectedHunkTrailer']"
		[Register ("unexpectedHunkTrailer")]
		public string UnexpectedHunkTrailer {
			get {
				const string __id = "unexpectedHunkTrailer.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unexpectedHunkTrailer.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unexpectedOddResult']"
		[Register ("unexpectedOddResult")]
		public string UnexpectedOddResult {
			get {
				const string __id = "unexpectedOddResult.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unexpectedOddResult.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unexpectedRefReport']"
		[Register ("unexpectedRefReport")]
		public string UnexpectedRefReport {
			get {
				const string __id = "unexpectedRefReport.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unexpectedRefReport.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unexpectedReportLine']"
		[Register ("unexpectedReportLine")]
		public string UnexpectedReportLine {
			get {
				const string __id = "unexpectedReportLine.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unexpectedReportLine.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unexpectedReportLine2']"
		[Register ("unexpectedReportLine2")]
		public string UnexpectedReportLine2 {
			get {
				const string __id = "unexpectedReportLine2.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unexpectedReportLine2.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unknownDIRCVersion']"
		[Register ("unknownDIRCVersion")]
		public string UnknownDIRCVersion {
			get {
				const string __id = "unknownDIRCVersion.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unknownDIRCVersion.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unknownHost']"
		[Register ("unknownHost")]
		public string UnknownHost {
			get {
				const string __id = "unknownHost.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unknownHost.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unknownIndexVersionOrCorruptIndex']"
		[Register ("unknownIndexVersionOrCorruptIndex")]
		public string UnknownIndexVersionOrCorruptIndex {
			get {
				const string __id = "unknownIndexVersionOrCorruptIndex.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unknownIndexVersionOrCorruptIndex.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unknownObject']"
		[Register ("unknownObject")]
		public string UnknownObject {
			get {
				const string __id = "unknownObject.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unknownObject.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unknownObjectType']"
		[Register ("unknownObjectType")]
		public string UnknownObjectType {
			get {
				const string __id = "unknownObjectType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unknownObjectType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unknownOrUnsupportedCommand']"
		[Register ("unknownOrUnsupportedCommand")]
		public string UnknownOrUnsupportedCommand {
			get {
				const string __id = "unknownOrUnsupportedCommand.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unknownOrUnsupportedCommand.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unknownRepositoryFormat']"
		[Register ("unknownRepositoryFormat")]
		public string UnknownRepositoryFormat {
			get {
				const string __id = "unknownRepositoryFormat.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unknownRepositoryFormat.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unknownRepositoryFormat2']"
		[Register ("unknownRepositoryFormat2")]
		public string UnknownRepositoryFormat2 {
			get {
				const string __id = "unknownRepositoryFormat2.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unknownRepositoryFormat2.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unknownZlibError']"
		[Register ("unknownZlibError")]
		public string UnknownZlibError {
			get {
				const string __id = "unknownZlibError.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unknownZlibError.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unmergedPath']"
		[Register ("unmergedPath")]
		public string UnmergedPath {
			get {
				const string __id = "unmergedPath.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unmergedPath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unmergedPaths']"
		[Register ("unmergedPaths")]
		public string UnmergedPaths {
			get {
				const string __id = "unmergedPaths.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unmergedPaths.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unpackException']"
		[Register ("unpackException")]
		public string UnpackException {
			get {
				const string __id = "unpackException.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unpackException.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unreadablePackIndex']"
		[Register ("unreadablePackIndex")]
		public string UnreadablePackIndex {
			get {
				const string __id = "unreadablePackIndex.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unreadablePackIndex.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unrecognizedRef']"
		[Register ("unrecognizedRef")]
		public string UnrecognizedRef {
			get {
				const string __id = "unrecognizedRef.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unrecognizedRef.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unsupportedArchiveFormat']"
		[Register ("unsupportedArchiveFormat")]
		public string UnsupportedArchiveFormat {
			get {
				const string __id = "unsupportedArchiveFormat.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unsupportedArchiveFormat.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unsupportedCommand0']"
		[Register ("unsupportedCommand0")]
		public string UnsupportedCommand0 {
			get {
				const string __id = "unsupportedCommand0.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unsupportedCommand0.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unsupportedEncryptionAlgorithm']"
		[Register ("unsupportedEncryptionAlgorithm")]
		public string UnsupportedEncryptionAlgorithm {
			get {
				const string __id = "unsupportedEncryptionAlgorithm.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unsupportedEncryptionAlgorithm.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unsupportedEncryptionVersion']"
		[Register ("unsupportedEncryptionVersion")]
		public string UnsupportedEncryptionVersion {
			get {
				const string __id = "unsupportedEncryptionVersion.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unsupportedEncryptionVersion.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unsupportedGC']"
		[Register ("unsupportedGC")]
		public string UnsupportedGC {
			get {
				const string __id = "unsupportedGC.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unsupportedGC.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unsupportedOperationNotAddAtEnd']"
		[Register ("unsupportedOperationNotAddAtEnd")]
		public string UnsupportedOperationNotAddAtEnd {
			get {
				const string __id = "unsupportedOperationNotAddAtEnd.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unsupportedOperationNotAddAtEnd.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unsupportedPackIndexVersion']"
		[Register ("unsupportedPackIndexVersion")]
		public string UnsupportedPackIndexVersion {
			get {
				const string __id = "unsupportedPackIndexVersion.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unsupportedPackIndexVersion.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='unsupportedPackVersion']"
		[Register ("unsupportedPackVersion")]
		public string UnsupportedPackVersion {
			get {
				const string __id = "unsupportedPackVersion.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unsupportedPackVersion.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='updatingReferences']"
		[Register ("updatingReferences")]
		public string UpdatingReferences {
			get {
				const string __id = "updatingReferences.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "updatingReferences.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='updatingRefFailed']"
		[Register ("updatingRefFailed")]
		public string UpdatingRefFailed {
			get {
				const string __id = "updatingRefFailed.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "updatingRefFailed.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='uriNotConfigured']"
		[Register ("uriNotConfigured")]
		public string UriNotConfigured {
			get {
				const string __id = "uriNotConfigured.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uriNotConfigured.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='uriNotFound']"
		[Register ("uriNotFound")]
		public string UriNotFound {
			get {
				const string __id = "uriNotFound.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uriNotFound.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='URINotSupported']"
		[Register ("URINotSupported")]
		public string URINotSupported {
			get {
				const string __id = "URINotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "URINotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='URLNotFound']"
		[Register ("URLNotFound")]
		public string URLNotFound {
			get {
				const string __id = "URLNotFound.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "URLNotFound.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='userConfigFileInvalid']"
		[Register ("userConfigFileInvalid")]
		public string UserConfigFileInvalid {
			get {
				const string __id = "userConfigFileInvalid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "userConfigFileInvalid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='walkFailure']"
		[Register ("walkFailure")]
		public string WalkFailure {
			get {
				const string __id = "walkFailure.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "walkFailure.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='wantNotValid']"
		[Register ("wantNotValid")]
		public string WantNotValid {
			get {
				const string __id = "wantNotValid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "wantNotValid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='weeksAgo']"
		[Register ("weeksAgo")]
		public string WeeksAgo {
			get {
				const string __id = "weeksAgo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "weeksAgo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='windowSizeMustBeLesserThanLimit']"
		[Register ("windowSizeMustBeLesserThanLimit")]
		public string WindowSizeMustBeLesserThanLimit {
			get {
				const string __id = "windowSizeMustBeLesserThanLimit.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "windowSizeMustBeLesserThanLimit.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='windowSizeMustBePowerOf2']"
		[Register ("windowSizeMustBePowerOf2")]
		public string WindowSizeMustBePowerOf2 {
			get {
				const string __id = "windowSizeMustBePowerOf2.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "windowSizeMustBePowerOf2.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='writerAlreadyInitialized']"
		[Register ("writerAlreadyInitialized")]
		public string WriterAlreadyInitialized {
			get {
				const string __id = "writerAlreadyInitialized.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "writerAlreadyInitialized.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='writeTimedOut']"
		[Register ("writeTimedOut")]
		public string WriteTimedOut {
			get {
				const string __id = "writeTimedOut.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "writeTimedOut.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='writingNotPermitted']"
		[Register ("writingNotPermitted")]
		public string WritingNotPermitted {
			get {
				const string __id = "writingNotPermitted.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "writingNotPermitted.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='writingNotSupported']"
		[Register ("writingNotSupported")]
		public string WritingNotSupported {
			get {
				const string __id = "writingNotSupported.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "writingNotSupported.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='writingObjects']"
		[Register ("writingObjects")]
		public string WritingObjects {
			get {
				const string __id = "writingObjects.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "writingObjects.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='wrongDecompressedLength']"
		[Register ("wrongDecompressedLength")]
		public string WrongDecompressedLength {
			get {
				const string __id = "wrongDecompressedLength.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "wrongDecompressedLength.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='wrongRepositoryState']"
		[Register ("wrongRepositoryState")]
		public string WrongRepositoryState {
			get {
				const string __id = "wrongRepositoryState.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "wrongRepositoryState.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='year']"
		[Register ("year")]
		public string Year {
			get {
				const string __id = "year.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "year.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='years']"
		[Register ("years")]
		public string Years {
			get {
				const string __id = "years.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "years.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='years0MonthsAgo']"
		[Register ("years0MonthsAgo")]
		public string Years0MonthsAgo {
			get {
				const string __id = "years0MonthsAgo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "years0MonthsAgo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='yearsAgo']"
		[Register ("yearsAgo")]
		public string YearsAgo {
			get {
				const string __id = "yearsAgo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "yearsAgo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/field[@name='yearsMonthsAgo']"
		[Register ("yearsMonthsAgo")]
		public string YearsMonthsAgo {
			get {
				const string __id = "yearsMonthsAgo.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "yearsMonthsAgo.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/jgit/internal/JGitText", typeof (JGitText));

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

		protected JGitText (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/constructor[@name='JGitText' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JGitText () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		/// <returns>an instance of this translation bundle</returns>
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.jgit.internal']/class[@name='JGitText']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lorg/eclipse/jgit/internal/JGitText;", "")]
		public static unsafe global::Org.Eclipse.Jgit.Internal.JGitText Get ()
		{
			const string __id = "get.()Lorg/eclipse/jgit/internal/JGitText;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Jgit.Internal.JGitText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
