using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergePdf
{
    public partial class FrmFileMgr : Form
    {
        FrmMergePdf mergePdf = new FrmMergePdf();
        FrmWordToPdf wordToPdf = new FrmWordToPdf();
        FrmImageToPdf imageToPdf = new FrmImageToPdf();
        FrmPdfToWord pdfToWord = new FrmPdfToWord();

        public FrmFileMgr()
        {
            InitializeComponent();
        }

        private void ButtonMergePdf_Click(object sender, EventArgs e)
        {
            this.Hide();
            mergePdf.ShowDialog();
            this.Show();
        }

        private void ButtonDocToPdf_Click(object sender, EventArgs e)
        {
            this.Hide();
            wordToPdf.ShowDialog();
            this.Show();
        }

        private void ButtonImageToPdf_Click(object sender, EventArgs e)
        {
            this.Hide();
            imageToPdf.ShowDialog();
            this.Show();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPdfToDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            pdfToWord.ShowDialog();
            this.Show();
        }
    }
}
