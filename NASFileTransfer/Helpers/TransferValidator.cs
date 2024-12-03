using System.IO;

namespace NASFileTransfer.Helpers
{
    public static class TransferValidator
    {
        // Check if there is enough space on the target directory for the file transfer
        public static bool IsEnoughSpace(string targetPath, long requiredSpace)
        {
            // Get available space on the target drive (in bytes)
            DriveInfo driveInfo = new DriveInfo(Path.GetPathRoot(targetPath));
            long availableSpace = driveInfo.AvailableFreeSpace;

            return availableSpace >= requiredSpace;
        }

        // Check if the target path is reachable
        public static bool IsPathReachable(string targetPath)
        {
            try
            {
                // Check if the directory exists and is accessible
                return Directory.Exists(targetPath);
            }
            catch (IOException)
            {
                // If there's an issue accessing the directory, return false
                return false;
            }
        }

        // Validate if the file transfer can proceed based on the target path and file size
        public static bool CanTransfer(string targetPath, string fileName, out bool isTransferOk)
        {
            // Get the size of the file
            string tempFilePath = Path.Combine(FileHelper.TempDirectory, fileName);
            long fileSize = new FileInfo(tempFilePath).Length;

            // Validate space and path
            bool isPathValid = IsPathReachable(targetPath);
            bool isSpaceAvailable = IsEnoughSpace(targetPath, fileSize);

            // Set isTransferOk based on the conditions
            isTransferOk = isPathValid && isSpaceAvailable;

            return isTransferOk;
        }

        // This method could also be used to display transfer status if needed
        public static string GetTransferStatus(string targetPath, string fileName)
        {
            bool isTransferOk;
            bool canTransfer = CanTransfer(targetPath, fileName, out isTransferOk);

            if (!canTransfer)
            {
                if (!isTransferOk)
                {
                    return "Transfer failed: Not enough space or path is not reachable.";
                }
            }
            return "Transfer ready: All checks passed.";
        }
    }
}
