using System.Threading.Tasks;
using System.Windows.Forms;
using NASFileTransfer.Helpers;
using NASFileTransfer.Services;
using NASFileTransfer.Forms;

namespace NASFileTransfer.Controllers
{
    public class ClickController
    {
        private readonly AppForm _form;
        private readonly TransferController _transferController;
        private readonly DownloadController _downloadController;

        public ClickController(AppForm form)
        {
            _form = form;
            _transferController = new TransferController();
            _downloadController = new DownloadController();
        }

        public async Task LoginClickAsync()
        {
            // Handle login logic (e.g., open a Google login form)
            bool isLoggedIn = await SessionValidator.ValidateSessionAsync();
            if (isLoggedIn)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
        }

        public async Task SelectFilesClickAsync()
        {
            // Call GoogleDriveService to fetch files from GDrive
            var files = await GoogleDriveService.GetFilesAsync();

            // Populate the UI with file options for user to select
            _form.checkedListBox1.Items.Clear();
            foreach (var file in files)
            {
                _form.checkedListBox1.Items.Add(file);
            }
        }

        public async Task TransferClickAsync()
        {
            // Handle file transfer logic (based on the user selection of files and target path)
            var selectedFiles = FileHelper.GetSelectedFiles();
            string targetPath = StoragePathService.GetSelectedPath();
            await _transferController.TransferFilesAsync(selectedFiles, targetPath);
        }

        public void ManagePathsClick()
        {
            // Open a dialog to manage paths (add/remove paths)
            StoragePathService.ShowManagePathsDialog();
        }
    }
}
