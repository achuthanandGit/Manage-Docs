namespace MergePdf
{
    partial class FrmImageToPdf
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
            this.labelNote = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.openPdf = new System.Windows.Forms.OpenFileDialog();
            this.savePdf = new System.Windows.Forms.SaveFileDialog();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMerge = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.contextMenuStripOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFileList
            // 
            this.listBoxFileList.AllowDrop = true;
            this.listBoxFileList.ContextMenuStrip = this.contextMenuStripOne;
            this.listBoxFileList.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFileList.FormattingEnabled = true;
            this.listBoxFileList.HorizontalScrollbar = true;
            this.listBoxFileList.ItemHeight = 19;
            this.listBoxFileList.Location = new System.Drawing.Point(35, 134);
            this.listBoxFileList.Name = "listBoxFileList";
            this.listBoxFileList.Size = new System.Drawing.Size(528, 175);
            this.listBoxFileList.TabIndex = 6;
            this.listBoxFileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxFileList_DragDrop);
            this.listBoxFileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBoxFileList_DragEnter);
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
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(34, 100);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(261, 19);
            this.labelNote.TabIndex = 9;
            this.labelNote.Text = "Drag and drop image files to convert.";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Location = new System.Drawing.Point(381, 364);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(90, 33);
            this.buttonUpload.TabIndex = 7;
            this.buttonUpload.Text = "Convert";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // openPdf
            // 
            this.openPdf.FileName = "openPdf";
            // 
            // savePdf
            // 
            this.savePdf.FileName = "savePdf";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(488, 364);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Image to PDF";
            // 
            // checkBoxMerge
            // 
            this.checkBoxMerge.AutoSize = true;
            this.checkBoxMerge.Location = new System.Drawing.Point(35, 315);
            this.checkBoxMerge.Name = "checkBoxMerge";
            this.checkBoxMerge.Size = new System.Drawing.Size(326, 21);
            this.checkBoxMerge.TabIndex = 13;
            this.checkBoxMerge.Text = "Check to convert and merge into single pdf file.";
            this.checkBoxMerge.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(35, 364);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 33);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // FrmImageToPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 414);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxMerge);
            this.Controls.Add(this.listBoxFileList);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Name = "FrmImageToPdf";
            this.Text = "Image to PDF convertor";
            this.contextMenuStripOne.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFileList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOne;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.OpenFileDialog openPdf;
        private System.Windows.Forms.SaveFileDialog savePdf;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMerge;
        private System.Windows.Forms.Button buttonClear;
    }
}