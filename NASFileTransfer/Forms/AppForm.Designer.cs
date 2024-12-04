namespace NASFileTransfer.Forms
{
    partial class AppForm
    {
        // Other code remains the same...

        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.usrEmailTextBox = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnManagePaths = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveToLabel = new System.Windows.Forms.Label();
            this.gdriveFilesLabel = new System.Windows.Forms.Label();
            this.loggedInAsLabel = new System.Windows.Forms.Label();
            this.storageTypeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.filesUsedLabel = new System.Windows.Forms.Label();
            this.requiredSpaceLabel = new System.Windows.Forms.Label();
            this.availableSpaceLabel = new System.Windows.Forms.Label();
            this.logOutputLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.isTransferOkLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleDescription = "Login button";
            this.btnLogin.AccessibleName = "btnLogin";
            this.btnLogin.Location = new System.Drawing.Point(466, 50);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // usrEmailTextBox
            // 
            this.usrEmailTextBox.AccessibleName = "usrEmailTextBox";
            this.usrEmailTextBox.Location = new System.Drawing.Point(270, 56);
            this.usrEmailTextBox.Name = "usrEmailTextBox";
            this.usrEmailTextBox.Size = new System.Drawing.Size(190, 20);
            this.usrEmailTextBox.TabIndex = 1;
            // 
            // btnTransfer
            // 
            this.btnTransfer.AccessibleName = "btnTransfer";
            this.btnTransfer.Location = new System.Drawing.Point(623, 249);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnManagePaths
            // 
            this.btnManagePaths.AccessibleName = "btnManagePaths";
            this.btnManagePaths.Location = new System.Drawing.Point(863, 169);
            this.btnManagePaths.Name = "btnManagePaths";
            this.btnManagePaths.Size = new System.Drawing.Size(75, 23);
            this.btnManagePaths.TabIndex = 3;
            this.btnManagePaths.Text = "Manage Paths";
            this.btnManagePaths.UseVisualStyleBackColor = true;
            this.btnManagePaths.Click += new System.EventHandler(this.btnManagePaths_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(592, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // saveToLabel
            // 
            this.saveToLabel.AccessibleName = "saveToLabel";
            this.saveToLabel.AutoSize = true;
            this.saveToLabel.Location = new System.Drawing.Point(592, 150);
            this.saveToLabel.Name = "saveToLabel";
            this.saveToLabel.Size = new System.Drawing.Size(46, 13);
            this.saveToLabel.TabIndex = 5;
            this.saveToLabel.Text = "Save To";
            // 
            // gdriveFilesLabel
            // 
            this.gdriveFilesLabel.AccessibleName = "gdriveFilesLabel";
            this.gdriveFilesLabel.AutoSize = true;
            this.gdriveFilesLabel.Location = new System.Drawing.Point(122, 119);
            this.gdriveFilesLabel.Name = "gdriveFilesLabel";
            this.gdriveFilesLabel.Size = new System.Drawing.Size(64, 13);
            this.gdriveFilesLabel.TabIndex = 6;
            this.gdriveFilesLabel.Text = "Google Drive Files";
            // 
            // loggedInAsLabel
            // 
            this.loggedInAsLabel.AccessibleName = "loggedInAsLabel";
            this.loggedInAsLabel.AutoSize = true;
            this.loggedInAsLabel.Location = new System.Drawing.Point(178, 59);
            this.loggedInAsLabel.Name = "loggedInAsLabel";
            this.loggedInAsLabel.Size = new System.Drawing.Size(70, 13);
            this.loggedInAsLabel.TabIndex = 7;
            this.loggedInAsLabel.Text = "Logged in as:";
            // 
            // storageTypeLabel
            // 
            this.storageTypeLabel.AccessibleName = "storageTypeLabel";
            this.storageTypeLabel.AutoSize = true;
            this.storageTypeLabel.Location = new System.Drawing.Point(595, 197);
            this.storageTypeLabel.Name = "storageTypeLabel";
            this.storageTypeLabel.Size = new System.Drawing.Size(70, 13);
            this.storageTypeLabel.TabIndex = 8;
            this.storageTypeLabel.Text = "Storage Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 9;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(94, 140);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(460, 334);
            this.checkedListBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 494);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(18, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 520);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 547);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 20);
            this.textBox4.TabIndex = 13;
            // 
            // filesUsedLabel
            // 
            this.filesUsedLabel.AccessibleName = "filesUsedLabel";
            this.filesUsedLabel.AutoSize = true;
            this.filesUsedLabel.Location = new System.Drawing.Point(119, 494);
            this.filesUsedLabel.Name = "filesUsedLabel";
            this.filesUsedLabel.Size = new System.Drawing.Size(62, 13);
            this.filesUsedLabel.TabIndex = 14;
            this.filesUsedLabel.Text = "Files Used:";
            // 
            // requiredSpaceLabel
            // 
            this.requiredSpaceLabel.AccessibleName = "requiredSpaceLabel";
            this.requiredSpaceLabel.AutoSize = true;
            this.requiredSpaceLabel.Location = new System.Drawing.Point(67, 523);
            this.requiredSpaceLabel.Name = "requiredSpaceLabel";
            this.requiredSpaceLabel.Size = new System.Drawing.Size(84, 13);
            this.requiredSpaceLabel.TabIndex = 15;
            this.requiredSpaceLabel.Text = "Required Space:";
            // 
            // availableSpaceLabel
            // 
            this.availableSpaceLabel.AccessibleName = "availableSpaceLabel";
            this.availableSpaceLabel.AutoSize = true;
            this.availableSpaceLabel.Location = new System.Drawing.Point(63, 550);
            this.availableSpaceLabel.Name = "availableSpaceLabel";
            this.availableSpaceLabel.Size = new System.Drawing.Size(88, 13);
            this.availableSpaceLabel.TabIndex = 16;
            this.availableSpaceLabel.Text = "Available Space:";
            // 
            // logOutputLabel
            // 
            this.logOutputLabel.AccessibleName = "logOutputLabel";
            this.logOutputLabel.AutoSize = true;
            this.logOutputLabel.Location = new System.Drawing.Point(591, 328);
            this.logOutputLabel.Name = "logOutputLabel";
            this.logOutputLabel.Size = new System.Drawing.Size(64, 13);
            this.logOutputLabel.TabIndex = 17;
            this.logOutputLabel.Text = "Log Output:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(191, 610);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 20);
            this.textBox5.TabIndex = 18;
            // 
            // isTransferOkLabel
            // 
            this.isTransferOkLabel.AccessibleName = "isTransferOkLabel";
            this.isTransferOkLabel.AutoSize = true;
            this.isTransferOkLabel.Location = new System.Drawing.Point(92, 613);
            this.isTransferOkLabel.Name = "isTransferOkLabel";
            this.isTransferOkLabel.Size = new System.Drawing.Size(93, 13);
            this.isTransferOkLabel.TabIndex = 19;
            this.isTransferOkLabel.Text = "Transfer Status:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(863, 671);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(329, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 706);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.isTransferOkLabel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.logOutputLabel);
            this.Controls.Add(this.availableSpaceLabel);
            this.Controls.Add(this.requiredSpaceLabel);
            this.Controls.Add(this.filesUsedLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.storageTypeLabel);
            this.Controls.Add(this.loggedInAsLabel);
            this.Controls.Add(this.gdriveFilesLabel);
            this.Controls.Add(this.saveToLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnManagePaths);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.usrEmailTextBox);
            this.Controls.Add(this.btnLogin);
            this.Name = "AppForm";
            this.Text = "NAS File Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox usrEmailTextBox;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnManagePaths;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label saveToLabel;
        private System.Windows.Forms.Label gdriveFilesLabel;
        private System.Windows.Forms.Label loggedInAsLabel;
        private System.Windows.Forms.Label storageTypeLabel;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label filesUsedLabel;
        private System.Windows.Forms.Label requiredSpaceLabel;
        private System.Windows.Forms.Label availableSpaceLabel;
        private System.Windows.Forms.Label logOutputLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label isTransferOkLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}