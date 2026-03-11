namespace Microsoft.Unity.Cursor.Editor
{
    public class VisualStudioIntegration
    {
        internal static string PackageVersion()
        {
            var package = UnityEditor.PackageManager.PackageInfo.FindForAssembly(typeof(VisualStudioIntegration).Assembly);
            return package.version;
        }
    }
}