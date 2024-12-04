using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;

namespace NASFileTransfer.Services
{
    public class GoogleDriveService
    {
        private static readonly string[] Scopes = { DriveService.Scope.DriveReadonly };
        private static readonly string ApplicationName = "NASFileTransfer";

        public static async Task<List<string>> GetFilesAsync()
        {
            var credential = await GetCredentialAsync();
            using (var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            }))
            {
                var fileList = new List<string>();

                // Define parameters of request
                FilesResource.ListRequest listRequest = service.Files.List();
                listRequest.PageSize = 10;
                listRequest.Fields = "nextPageToken, files(id, name)";

                // List files
                var request = await listRequest.ExecuteAsync();
                foreach (var file in request.Files)
                {
                    fileList.Add(file.Name);
                }

                return fileList;
            }
        }

        public static async Task DownloadFileAsync(string fileId, string tempDirectory)
        {
            var credential = await GetCredentialAsync();
            using (var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            }))
            {
                var request = service.Files.Get(fileId);
                using (var memoryStream = new MemoryStream())
                {
                    // Add progress listener if needed
                    await request.DownloadAsync(memoryStream);

                    // Save the file to the specified path
                    string tempFilePath = Path.Combine(tempDirectory, fileId);
                    memoryStream.Seek(0, SeekOrigin.Begin); // Reset stream position
                    using (var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                    {
                        await memoryStream.CopyToAsync(fileStream);
                    }
                }
            }
        }

        private static async Task<UserCredential> GetCredentialAsync()
        {
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));
            }
        }
    }
}