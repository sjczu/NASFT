using System.Collections.Generic;

namespace NASFileTransfer.Services
{
    public class StoragePathService
    {
        private static List<string> _savedPaths = new List<string>();

        public static void AddPath(string path)
        {
            _savedPaths.Add(path);
        }

        public static void RemovePath(string path)
        {
            _savedPaths.Remove(path);
        }

        public static List<string> GetSavedPaths()
        {
            return _savedPaths;
        }

        public static string GetSelectedPath()
        {
            // Return the selected path from the dropdown
            return _savedPaths[0];
        }

        public static void ShowManagePathsDialog()
        {
            // Logic for showing the Manage Paths dialog
        }
    }
}
