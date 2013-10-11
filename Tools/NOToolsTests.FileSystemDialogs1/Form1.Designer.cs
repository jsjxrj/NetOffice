﻿namespace NOToolsTests.FileSystemDialogs1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFilePanel1 = new NOTools.FileSystemDialogs.OpenFilePanel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // openFilePanel1
            // 
            this.openFilePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.openFilePanel1.Default.AllowAddFolders = false;
            this.openFilePanel1.Default.AllowBrowseFolders = true;
            this.openFilePanel1.Default.AllowDeleteFiles = false;
            this.openFilePanel1.Default.AllowDeleteFolders = false;
            this.openFilePanel1.Default.AllowMultipleSelect = false;
            this.openFilePanel1.Default.Expanded = false;
            this.openFilePanel1.Default.ShowAccessErrorsInDialogBox = false;
            this.openFilePanel1.Default.Visible = true;
            this.openFilePanel1.Desktop.AllowAddFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.Desktop.AllowBrowseFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.Desktop.AllowDeleteFiles = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.Desktop.AllowDeleteFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.Desktop.AllowMultipleSelect = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.Desktop.Expanded = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.Desktop.ShowAccessErrorsInDialogBox = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.Desktop.Visible = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.Location = new System.Drawing.Point(0, 0);
            this.openFilePanel1.Misc.FileFilter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFilePanel1.Misc.SelectedCategory = NOTools.FileSystemDialogs.RootCategory.Desktop;
            this.openFilePanel1.Misc.ShowCategoryPanel = true;
            this.openFilePanel1.MyComputer.AllowAddFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyComputer.AllowBrowseFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyComputer.AllowDeleteFiles = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyComputer.AllowDeleteFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyComputer.AllowMultipleSelect = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyComputer.Expanded = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyComputer.ShowAccessErrorsInDialogBox = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyComputer.ShowCDRomDrives = true;
            this.openFilePanel1.MyComputer.ShowFixedDrives = true;
            this.openFilePanel1.MyComputer.ShowNetworkDrives = true;
            this.openFilePanel1.MyComputer.ShowNoRootDirectoryDrives = true;
            this.openFilePanel1.MyComputer.ShowRamDrives = true;
            this.openFilePanel1.MyComputer.ShowRemovableDrives = true;
            this.openFilePanel1.MyComputer.ShowUnknownDrives = true;
            this.openFilePanel1.MyComputer.ShowUnreadyDrives = true;
            this.openFilePanel1.MyComputer.Visible = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyDocuments.AllowAddFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyDocuments.AllowBrowseFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyDocuments.AllowDeleteFiles = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyDocuments.AllowDeleteFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyDocuments.AllowMultipleSelect = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyDocuments.Expanded = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyDocuments.ShowAccessErrorsInDialogBox = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.MyDocuments.Visible = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.Name = "openFilePanel1";
            this.openFilePanel1.Size = new System.Drawing.Size(687, 573);
            this.openFilePanel1.SpecialFolders.AllowAddFolders = NOTools.FileSystemDialogs.DefaultBoolean.False;
            this.openFilePanel1.SpecialFolders.AllowBrowseFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.SpecialFolders.AllowDeleteFiles = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.SpecialFolders.AllowDeleteFolders = NOTools.FileSystemDialogs.DefaultBoolean.False;
            this.openFilePanel1.SpecialFolders.AllowMultipleSelect = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.SpecialFolders.Expanded = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.SpecialFolders.ShowAccessErrorsInDialogBox = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.SpecialFolders.Visible = NOTools.FileSystemDialogs.DefaultBoolean.False;
            this.openFilePanel1.TabIndex = 2;
            this.openFilePanel1.TemplateFolders.AllowAddFolders = NOTools.FileSystemDialogs.DefaultBoolean.False;
            this.openFilePanel1.TemplateFolders.AllowBrowseFolders = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.TemplateFolders.AllowDeleteFiles = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.TemplateFolders.AllowDeleteFolders = NOTools.FileSystemDialogs.DefaultBoolean.False;
            this.openFilePanel1.TemplateFolders.AllowMultipleSelect = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.TemplateFolders.Expanded = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.TemplateFolders.ShowAccessErrorsInDialogBox = NOTools.FileSystemDialogs.DefaultBoolean.Default;
            this.openFilePanel1.TemplateFolders.Visible = NOTools.FileSystemDialogs.DefaultBoolean.False;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(689, 2);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.openFilePanel1;
            this.propertyGrid1.Size = new System.Drawing.Size(442, 574);
            this.propertyGrid1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 573);
            this.Controls.Add(this.openFilePanel1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "Form1";
            this.Text = "NOToolsTests.FileSystemDialogs1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private NOTools.FileSystemDialogs.OpenFilePanel openFilePanel1;
    }
}

