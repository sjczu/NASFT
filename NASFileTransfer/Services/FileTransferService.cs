using System.IO;
using System.Threading.Tasks;
using NASFileTransfer.Helpers;

namespace NASFileTransfer.Services
{
    public class FileTransferService
    {
        public async Task TransferFileAsync(string file, string targetPath)
        {
            string tempFilePath = Path.Combine(FileHelper.TempDirectory, file);
            string destinationPath = Path.Combine(targetPath, file);

            // Perform actual transfer
            if (File.Exists(tempFilePath))
            {
                await Task.Run(() => File.Copy(tempFilePath, destinationPath));
                FileHelper.DeleteTempFile(file);
            }
        }
    }
}
