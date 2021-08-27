
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
            this.PrgProgressUpload = new System.Windows.Forms.ProgressBar();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUploadFiles = new System.Windows.Forms.Button();
            this.LblFiles = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtFiles = new System.Windows.Forms.TextBox();
            this.TxtRole = new System.Windows.Forms.TextBox();
            this.LblRole = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.GroupBoxGrid = new System.Windows.Forms.GroupBox();
            this.NameFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxUpload.SuspendLayout();
            this.GroupBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxUpload
            // 
            this.GroupBoxUpload.Controls.Add(this.PrgProgressUpload);
            this.GroupBoxUpload.Controls.Add(this.BtnSave);
            this.GroupBoxUpload.Controls.Add(this.BtnUploadFiles);
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
            // PrgProgressUpload
            // 
            this.PrgProgressUpload.Location = new System.Drawing.Point(9, 71);
            this.PrgProgressUpload.Name = "PrgProgressUpload";
            this.PrgProgressUpload.Size = new System.Drawing.Size(359, 23);
            this.PrgProgressUpload.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(551, 71);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(160, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUploadFiles
            // 
            this.BtnUploadFiles.Location = new System.Drawing.Point(673, 30);
            this.BtnUploadFiles.Name = "BtnUploadFiles";
            this.BtnUploadFiles.Size = new System.Drawing.Size(38, 23);
            this.BtnUploadFiles.TabIndex = 7;
            this.BtnUploadFiles.Text = "...";
            this.BtnUploadFiles.UseVisualStyleBackColor = true;
            this.BtnUploadFiles.Click += new System.EventHandler(this.BtnUploadFiles_Click);
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
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(384, 71);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(148, 23);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtFiles
            // 
            this.TxtFiles.Location = new System.Drawing.Point(384, 32);
            this.TxtFiles.Name = "TxtFiles";
            this.TxtFiles.Size = new System.Drawing.Size(283, 20);
            this.TxtFiles.TabIndex = 5;
            // 
            // TxtRole
            // 
            this.TxtRole.Location = new System.Drawing.Point(185, 32);
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(183, 20);
            this.TxtRole.TabIndex = 4;
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
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(9, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(159, 20);
            this.TxtName.TabIndex = 1;
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
            // GroupBoxGrid
            // 
            this.GroupBoxGrid.Controls.Add(this.dataGridView1);
            this.GroupBoxGrid.Location = new System.Drawing.Point(12, 128);
            this.GroupBoxGrid.Name = "GroupBoxGrid";
            this.GroupBoxGrid.Size = new System.Drawing.Size(727, 380);
            this.GroupBoxGrid.TabIndex = 1;
            this.GroupBoxGrid.TabStop = false;
            // 
            // NameFile
            // 
            this.NameFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameFile.DataPropertyName = "Name";
            this.NameFile.HeaderText = "Name";
            this.NameFile.Name = "NameFile";
            this.NameFile.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 355);
            this.dataGridView1.TabIndex = 0;
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
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 520);
            this.Controls.Add(this.GroupBoxGrid);
            this.Controls.Add(this.GroupBoxUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Files";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GroupBoxUpload.ResumeLayout(false);
            this.GroupBoxUpload.PerformLayout();
            this.GroupBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxUpload;
        private System.Windows.Forms.ProgressBar PrgProgressUpload;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnUploadFiles;
        private System.Windows.Forms.Label LblFiles;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtFiles;
        private System.Windows.Forms.TextBox TxtRole;
        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.GroupBox GroupBoxGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

