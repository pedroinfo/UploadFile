
namespace FormsUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GroupBoxUpload = new System.Windows.Forms.GroupBox();
            this.GroupBoxGrid = new System.Windows.Forms.GroupBox();
            this.GridDocuments = new System.Windows.Forms.DataGridView();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblRole = new System.Windows.Forms.Label();
            this.TxtRole = new System.Windows.Forms.TextBox();
            this.TxtFiles = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblFiles = new System.Windows.Forms.Label();
            this.BtnFiles = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PrgProgressUpload = new System.Windows.Forms.ProgressBar();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxUpload.SuspendLayout();
            this.GroupBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxUpload
            // 
            this.GroupBoxUpload.Controls.Add(this.PrgProgressUpload);
            this.GroupBoxUpload.Controls.Add(this.BtnSave);
            this.GroupBoxUpload.Controls.Add(this.BtnFiles);
            this.GroupBoxUpload.Controls.Add(this.LblFiles);
            this.GroupBoxUpload.Controls.Add(this.BtnClear);
            this.GroupBoxUpload.Controls.Add(this.TxtFiles);
            this.GroupBoxUpload.Controls.Add(this.TxtRole);
            this.GroupBoxUpload.Controls.Add(this.LblRole);
            this.GroupBoxUpload.Controls.Add(this.TxtName);
            this.GroupBoxUpload.Controls.Add(this.LblName);
            this.GroupBoxUpload.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxUpload.Name = "GroupBoxUpload";
            this.GroupBoxUpload.Size = new System.Drawing.Size(727, 110);
            this.GroupBoxUpload.TabIndex = 0;
            this.GroupBoxUpload.TabStop = false;
            // 
            // GroupBoxGrid
            // 
            this.GroupBoxGrid.Controls.Add(this.GridDocuments);
            this.GroupBoxGrid.Location = new System.Drawing.Point(12, 128);
            this.GroupBoxGrid.Name = "GroupBoxGrid";
            this.GroupBoxGrid.Size = new System.Drawing.Size(727, 380);
            this.GroupBoxGrid.TabIndex = 1;
            this.GroupBoxGrid.TabStop = false;
            // 
            // GridDocuments
            // 
            this.GridDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2});
            this.GridDocuments.Location = new System.Drawing.Point(9, 19);
            this.GridDocuments.Name = "GridDocuments";
            this.GridDocuments.Size = new System.Drawing.Size(702, 345);
            this.GridDocuments.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(6, 16);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(9, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(159, 20);
            this.TxtName.TabIndex = 1;
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Location = new System.Drawing.Point(182, 16);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(29, 13);
            this.LblRole.TabIndex = 3;
            this.LblRole.Text = "Role";
            // 
            // TxtRole
            // 
            this.TxtRole.Location = new System.Drawing.Point(185, 32);
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(183, 20);
            this.TxtRole.TabIndex = 4;
            // 
            // TxtFiles
            // 
            this.TxtFiles.Location = new System.Drawing.Point(384, 32);
            this.TxtFiles.Name = "TxtFiles";
            this.TxtFiles.Size = new System.Drawing.Size(283, 20);
            this.TxtFiles.TabIndex = 5;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(384, 71);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(148, 23);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // LblFiles
            // 
            this.LblFiles.AutoSize = true;
            this.LblFiles.Location = new System.Drawing.Point(381, 16);
            this.LblFiles.Name = "LblFiles";
            this.LblFiles.Size = new System.Drawing.Size(85, 13);
            this.LblFiles.TabIndex = 6;
            this.LblFiles.Text = "File Attachments";
            // 
            // BtnFiles
            // 
            this.BtnFiles.Location = new System.Drawing.Point(673, 30);
            this.BtnFiles.Name = "BtnFiles";
            this.BtnFiles.Size = new System.Drawing.Size(38, 23);
            this.BtnFiles.TabIndex = 7;
            this.BtnFiles.Text = "...";
            this.BtnFiles.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(551, 71);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(160, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // PrgProgressUpload
            // 
            this.PrgProgressUpload.Location = new System.Drawing.Point(9, 71);
            this.PrgProgressUpload.Name = "PrgProgressUpload";
            this.PrgProgressUpload.Size = new System.Drawing.Size(359, 23);
            this.PrgProgressUpload.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.HeaderText = "Column1";
            this.Id.Name = "Id";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 520);
            this.Controls.Add(this.GroupBoxGrid);
            this.Controls.Add(this.GroupBoxUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Files";
            this.GroupBoxUpload.ResumeLayout(false);
            this.GroupBoxUpload.PerformLayout();
            this.GroupBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDocuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxUpload;
        private System.Windows.Forms.ProgressBar PrgProgressUpload;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnFiles;
        private System.Windows.Forms.Label LblFiles;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtFiles;
        private System.Windows.Forms.TextBox TxtRole;
        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.GroupBox GroupBoxGrid;
        private System.Windows.Forms.DataGridView GridDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

