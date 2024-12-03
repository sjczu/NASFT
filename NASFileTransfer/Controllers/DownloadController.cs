using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using NASFileTransfer.Services;

namespace NASFileTransfer.Controllers
{
    public class DownloadController
    {
        public async Task DownloadFilesAsync(List<string> fileIds, string tempDirectory)
        {
            foreach (var fileId in fileIds)
            {
                await GoogleDriveService.DownloadFileAsync(fileId, tempDirectory);
            }
        }
    }
}
