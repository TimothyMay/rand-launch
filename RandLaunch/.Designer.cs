namespace RandLaunch
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.dataGridViewFoundFiles = new System.Windows.Forms.DataGridView();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoundFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(384, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDefaultLocationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setDefaultLocationToolStripMenuItem
            // 
            this.setDefaultLocationToolStripMenuItem.Name = "setDefaultLocationToolStripMenuItem";
            this.setDefaultLocationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDefaultLocationToolStripMenuItem.Text = "Set Default Location";
            this.setDefaultLocationToolStripMenuItem.Click += new System.EventHandler(this.setDefaultLocationToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 27);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(100, 25);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open Directory";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // dataGridViewFoundFiles
            // 
            this.dataGridViewFoundFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFoundFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoundFiles.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewFoundFiles.Name = "dataGridViewFoundFiles";
            this.dataGridViewFoundFiles.ReadOnly = true;
            this.dataGridViewFoundFiles.RowHeadersVisible = false;
            this.dataGridViewFoundFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFoundFiles.Size = new System.Drawing.Size(360, 261);
            this.dataGridViewFoundFiles.TabIndex = 2;
            this.dataGridViewFoundFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFoundFiles_CellDoubleClick);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoose.Location = new System.Drawing.Point(272, 325);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(100, 25);
            this.buttonChoose.TabIndex = 3;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.dataGridViewFoundFiles);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Open Random File";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoundFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem setDefaultLocationToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.DataGridView dataGridViewFoundFiles;
        private System.Windows.Forms.Button buttonChoose;
    }
}

