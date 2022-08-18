using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"org/eclipse/jgit/lib",
						"org/eclipse/jgit/revwalk",
					},
					new Converter<string, Type>[]{
						lookup_org_eclipse_jgit_lib_package,
						lookup_org_eclipse_jgit_revwalk_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_org_eclipse_jgit_lib_mappings;
		static Type lookup_org_eclipse_jgit_lib_package (string klass)
		{
			if (package_org_eclipse_jgit_lib_mappings == null) {
				package_org_eclipse_jgit_lib_mappings = new string[]{
					"org/eclipse/jgit/lib/Ref$Storage:Org.Eclipse.Jgit.Lib.RefStorage",
				};
			}

			return Lookup (package_org_eclipse_jgit_lib_mappings, klass);
		}

		static string[] package_org_eclipse_jgit_revwalk_mappings;
		static Type lookup_org_eclipse_jgit_revwalk_package (string klass)
		{
			if (package_org_eclipse_jgit_revwalk_mappings == null) {
				package_org_eclipse_jgit_revwalk_mappings = new string[]{
					"org/eclipse/jgit/revwalk/DepthWalk$Commit:Org.Eclipse.Jgit.Revwalk.DepthWalkCommit",
					"org/eclipse/jgit/revwalk/DepthWalk$ObjectWalk:Org.Eclipse.Jgit.Revwalk.DepthWalkObjectWalk",
					"org/eclipse/jgit/revwalk/DepthWalk$RevWalk:Org.Eclipse.Jgit.Revwalk.DepthWalkRevWalk",
				};
			}

			return Lookup (package_org_eclipse_jgit_revwalk_mappings, klass);
		}
	}
}
