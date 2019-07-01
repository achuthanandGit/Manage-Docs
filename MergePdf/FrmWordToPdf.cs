using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordToPDF;

namespace MergePdf
{
    public partial class FrmWordToPdf : Form
    {
        Word2Pdf objWorPdf = new Word2Pdf();
        public FrmWordToPdf()
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

        /**
         * This method will upload the selected word file and save a new converted pdf file
         */
        private void UploadAndConvert()
        {
            openWordDoc.Title = "Open doc or docx file to convert";
            openWordDoc.Filter = "Word Files|*.doc;*.docx";
            if(openWordDoc.ShowDialog() ==DialogResult.OK)
            {
                objWorPdf.InputLocation = openWordDoc.FileName;
                saveWordDoc.Title = "Save PDF file";
                saveWordDoc.Filter = "Pdf Files|*.pdf";
                if (saveWordDoc.ShowDialog() == DialogResult.OK)
                {   
                    objWorPdf.OutputLocation = saveWordDoc.FileName;
                    using (FrmLoadingConversion frm = new FrmLoadingConversion(ConvertFile))
                    {
                        frm.ShowDialog(this);
                    }
                    MessageBox.Show("Converted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void ConvertFile()
        {
            objWorPdf.Word2PdfCOnversion();
        }
    }
}
