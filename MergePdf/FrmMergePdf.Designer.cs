namespace MergePdf
{
    partial class FrmMergePdf
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
            this.components = new System.ComponentModel.Container();
            this.listBoxFileList = new System.Windows.Forms.ListBox();
            this.contextMenuStripOne = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.openPdf = new System.Windows.Forms.OpenFileDialog();
            this.savePdf = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.contextMenuStripOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFileList
            // 
            this.listBoxFileList.ContextMenuStrip = this.contextMenuStripOne;
            this.listBoxFileList.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFileList.FormattingEnabled = true;
            this.listBoxFileList.ItemHeight = 15;
            this.listBoxFileList.Location = new System.Drawing.Point(24, 129);
            this.listBoxFileList.Name = "listBoxFileList";
            this.listBoxFileList.Size = new System.Drawing.Size(528, 184);
            this.listBoxFileList.TabIndex = 0;
            // 
            // contextMenuStripOne
            // 
            this.contextMenuStripOne.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStripOne.Name = "contextMenuStripOne";
            this.contextMenuStripOne.Size = new System.Drawing.Size(133, 28);
            this.contextMenuStripOne.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripOne_Opening);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Location = new System.Drawing.Point(293, 332);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 33);
            this.buttonUpload.TabIndex = 1;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMerge.Location = new System.Drawing.Point(387, 332);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(75, 33);
            this.buttonMerge.TabIndex = 2;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.ButtonMerge_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(21, 95);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(295, 19);
            this.labelNote.TabIndex = 3;
            this.labelNote.Text = "Upload files in the order it need to merge.";
            // 
            // openPdf
            // 
            this.openPdf.FileName = "openPdf";
            // 
            // savePdf
            // 
            this.savePdf.FileName = "savePdf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Merge PDF";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(477, 332);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FrmMergePdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 388);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.listBoxFileList);
            this.Name = "FrmMergePdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge PDF";
            this.contextMenuStripOne.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFileList;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.OpenFileDialog openPdf;
        private System.Windows.Forms.SaveFileDialog savePdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOne;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

