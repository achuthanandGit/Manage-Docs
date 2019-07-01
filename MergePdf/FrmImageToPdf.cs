using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;

namespace MergePdf
{
    public partial class FrmImageToPdf : Form
    {
        private List<String> fileList = new List<string>();
        public FrmImageToPdf()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            listBoxFileList.Items.Clear();
            Close();
        }

        private void ContextMenuStripOne_Opening(object sender, CancelEventArgs e)
        {
            if (listBoxFileList.SelectedItems.Count == 0)
                e.Cancel = true;
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFile();
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            fileList.Clear();
            listBoxFileList.Items.Clear();
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            ConvertAndMerge();
        }

        private void ListBoxFileList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ListBoxFileList_DragDrop(object sender, DragEventArgs e)
        {
            AddFileToList(e);
        }

        /**
       * this method will remvove the selected file from the uploaded files
       */
        private void RemoveFile()
        {
            fileList.Remove(listBoxFileList.SelectedItem.ToString());
            listBoxFileList.Items.Remove(listBoxFileList.SelectedItem);
        }

        /**
         * this method is used to update the file list when a  file is dragged and dropped in to the list box
         */
        private void AddFileToList(DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                if (".jpg" == Path.GetExtension(file))
                {
                    fileList.Add(file);
                    listBoxFileList.Items.Add(file);
                }
            }
        }
        /**
         * this method is used to initiate the conversion process according to the updloaded files and user choices
         */
        private void ConvertAndMerge()
        {
            bool isChecked = checkBoxMerge.Checked;
            if (fileList.Count == 0)
                MessageBox.Show("Please upload atleast one image file to convert.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (isChecked || fileList.Count == 1)
            {
                PdfDocument pdfDoc = new PdfDocument();
                foreach (string file in fileList)
                {
                    PdfPage pdfPage = pdfDoc.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
                    DrawImage(gfx, file, 0, 0, (int)pdfPage.Width, (int)pdfPage.Height);
                }
                savePdf.Filter = "Pdf Files|*.pdf";
                if (savePdf.ShowDialog() == DialogResult.OK)
                    pdfDoc.Save(savePdf.FileName);
            } else
            {
                ConvertAndSave();
            }
        }

        /**
         * this method is used to convert each image file into pdf file and will save it 
         */
        private void ConvertAndSave()
        {
            foreach (string file in fileList)
            {
                PdfDocument pdfDoc = new PdfDocument();
                PdfPage pdfPage = pdfDoc.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
                DrawImage(gfx, file, 0, 0, (int)pdfPage.Width, (int)pdfPage.Height);
                pdfDoc.Save(Path.GetFullPath(file) + Path.GetFileName(file) + ".pdf");
            }
            MessageBox.Show("Converted files are saved in the same folder.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
         * this method is used to draw the image in pdf page
         */
        private void DrawImage(XGraphics gfx, string file, int x, int y, int width, int height)
        {
            XImage xImage = XImage.FromFile(file);
            gfx.DrawImage(xImage, x, y, width, height);
        }

        /**
        * this method will merge uploaded files and return merge pdf
        */
        private static PdfDocument MergePDFs(List<String> fileList)
        {
            using (PdfDocument targetDoc = new PdfDocument())
            {
                foreach (string pdf in fileList)
                {
                    using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (int i = 0; i < pdfDoc.PageCount; i++)
                        {
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                        }
                    }
                }
                return targetDoc;
            }
        }
    }
}
