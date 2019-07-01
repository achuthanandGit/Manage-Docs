using SautinSoft;
using System;
using System.Windows.Forms;

namespace MergePdf
{
    public partial class FrmPdfToWord : Form
    {
        public FrmPdfToWord()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            UploadAndConvert();
        }

        private void UploadAndConvert()
        {
            openWordDoc.Title = "Open PDF file to convert";
            openWordDoc.Filter = "PDF Files|*.pdf";
            if (openWordDoc.ShowDialog() == DialogResult.OK)
            {
                PdfFocus pdfFocus = new PdfFocus();
                pdfFocus.OpenPdf(openWordDoc.FileName);
                saveWordDoc.Title = "Save Doc file";
                saveWordDoc.Filter = "Word Files|*.docx";
                if (saveWordDoc.ShowDialog() == DialogResult.OK)
                {
                    pdfFocus.ToWord(saveWordDoc.FileName);
                    MessageBox.Show("Converted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }   
    }
}

