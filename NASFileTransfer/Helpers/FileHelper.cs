using System;
using System.Collections.Generic;
using System.IO;

namespace NASFileTransfer.Helpers
{
    public static class FileHelper
    {
        // Dynamically set Temp directory based on the app's directory
        public static string TempDirectory { get; set; }

        static FileHelper()
        {
            // Set TempDirectory to the "Temp" folder in the application directory
            TempDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Temp");

            // Ensure the Temp directory exists
            if (!Directory.Exists(TempDirectory))
            {
                Directory.CreateDirectory(TempDirectory);
            }
        }

        // Method to retrieve selected files (e.g., from a UI component)
        public static List<string> GetSelectedFiles()
        {
            // In a real scenario, this would be dynamic based on user selection in UI
            // Simulating the selection of files for now
            List<string> selectedFiles = new List<string>
            {
                "exampleFile1.txt",  // Replace with actual file names
                "exampleFile2.pdf"   // Replace with actual file names
            };

            return selectedFiles;
        }

        // Method to delete a file from the Temp directory
        public static void DeleteTempFile(string fileName)
        {
            try
            {
                string filePath = Path.Combine(TempDirectory, fileName);

                // Check if the file exists in the Temp directory
                if (File.Exists(filePath))
                {
                    // Delete the file
                    File.Delete(filePath);
                    Console.WriteLine($"File {fileName} has been deleted from Temp.");
                }
                else
                {
                    Console.WriteLine($"File {fileName} does not exist in Temp.");
                }
            }
            catch (Exception ex)
            {
                // Log any exceptions that occur during file deletion
                Console.WriteLine($"Error deleting file {fileName}: {ex.Message}");
            }
        }

        // Additional helper methods can be added here (e.g., checking directory contents, etc.)
    }
}
