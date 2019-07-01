namespace MergePdf
{
    partial class FrmFileMgr
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMergePdf = new System.Windows.Forms.Button();
            this.buttonDocToPdf = new System.Windows.Forms.Button();
            this.buttonImageToPdf = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPdfToDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "File Manager";
            // 
            // buttonMergePdf
            // 
            this.buttonMergePdf.Location = new System.Drawing.Point(39, 117);
            this.buttonMergePdf.Name = "buttonMergePdf";
            this.buttonMergePdf.Size = new System.Drawing.Size(294, 30);
            this.buttonMergePdf.TabIndex = 13;
            this.buttonMergePdf.Text = "Merge multiple pdf";
            this.buttonMergePdf.UseVisualStyleBackColor = true;
            this.buttonMergePdf.Click += new System.EventHandler(this.ButtonMergePdf_Click);
            // 
            // buttonDocToPdf
            // 
            this.buttonDocToPdf.Location = new System.Drawing.Point(39, 162);
            this.buttonDocToPdf.Name = "buttonDocToPdf";
            this.buttonDocToPdf.Size = new System.Drawing.Size(294, 30);
            this.buttonDocToPdf.TabIndex = 19;
            this.buttonDocToPdf.Text = "Convert Doc file to PDF";
            this.buttonDocToPdf.UseVisualStyleBackColor = true;
            this.buttonDocToPdf.Click += new System.EventHandler(this.ButtonDocToPdf_Click);
            // 
            // buttonImageToPdf
            // 
            this.buttonImageToPdf.Location = new System.Drawing.Point(39, 248);
            this.buttonImageToPdf.Name = "buttonImageToPdf";
            this.buttonImageToPdf.Size = new System.Drawing.Size(294, 30);
            this.buttonImageToPdf.TabIndex = 20;
            this.buttonImageToPdf.Text = "Convert Image to PDF";
            this.buttonImageToPdf.UseVisualStyleBackColor = true;
            this.buttonImageToPdf.Click += new System.EventHandler(this.ButtonImageToPdf_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(258, 310);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 32);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonPdfToDoc
            // 
            this.buttonPdfToDoc.Location = new System.Drawing.Point(39, 205);
            this.buttonPdfToDoc.Name = "buttonPdfToDoc";
            this.buttonPdfToDoc.Size = new System.Drawing.Size(294, 30);
            this.buttonPdfToDoc.TabIndex = 22;
            this.buttonPdfToDoc.Text = "Convert PDF file to Doc";
            this.buttonPdfToDoc.UseVisualStyleBackColor = true;
            this.buttonPdfToDoc.Click += new System.EventHandler(this.ButtonPdfToDoc_Click);
            // 
            // FrmFileMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 365);
            this.Controls.Add(this.buttonPdfToDoc);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonImageToPdf);
            this.Controls.Add(this.buttonDocToPdf);
            this.Controls.Add(this.buttonMergePdf);
            this.Controls.Add(this.label1);
            this.Name = "FrmFileMgr";
            this.Text = "File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMergePdf;
        private System.Windows.Forms.Button buttonDocToPdf;
        private System.Windows.Forms.Button buttonImageToPdf;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonPdfToDoc;
    }
}