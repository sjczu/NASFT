using System;
using System.Windows.Forms;
using NASFileTransfer.Controllers;

namespace NASFileTransfer.Forms
{
    public partial class AppForm : Form
    {
        

        public AppForm()
        {
            InitializeComponent();
            _clickController = new ClickController(this);
        }

        private readonly ClickController _clickController;

        // Event handler for "Login" button
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await _clickController.LoginClickAsync();
        }

        // Event handler for "Select Files" button
        private async void btnSelectFiles_Click(object sender, EventArgs e)
        {
            await _clickController.SelectFilesClickAsync();
        }

        // Event handler for "Transfer" button
        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            await _clickController.TransferClickAsync();
        }

        // Event handler for "Manage Paths" button
        private void btnManagePaths_Click(object sender, EventArgs e)
        {
            _clickController.ManagePathsClick();
        }

        private void usrEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
