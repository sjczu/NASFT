using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using NASFileTransfer.Services;

namespace NASFileTransfer.Controllers
{
    public class TransferController
    {
        private readonly FileTransferService _fileTransferService;

        public TransferController()
        {
            _fileTransferService = new FileTransferService();
        }

        public async Task TransferFilesAsync(List<string> files, string targetPath)
        {
            foreach (var file in files)
            {
                await _fileTransferService.TransferFileAsync(file, targetPath);
            }
        }
    }
}
