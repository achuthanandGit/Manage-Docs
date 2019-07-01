using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MergePdf
{
    public partial class FrmMergePdf : Form
    {
        
        private List<String> fileList = new List<string>();
        
        public FrmMergePdf()
        {
            InitializeComponent();
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            UploadFile();
        }

        private void ButtonMerge_Click(object sender, EventArgs e)
        {
            CheckAndMergeFile(); 
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            listBoxFileList.Items.Clear();
            Close();
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

        private void ContextMenuStripOne_Opening(object sender, CancelEventArgs e)
        {
            if (listBoxFileList.SelectedItems.Count == 0)
                e.Cancel = true;
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
         * this method uploads the selected file
         */
        private void UploadFile()
        {
            openPdf.Filter = "Pdf Files|*.pdf";
            if (openPdf.ShowDialog() == DialogResult.OK)
            {
                fileList.Add(openPdf.FileName);
                listBoxFileList.Items.Add(openPdf.FileName);
            }
        }

        /** 
         *  this method will check whether there exists atleast 2 files to merge.
         *  if so the initiate merge process
         *  if not then throw info message to add more files
         */
        private void CheckAndMergeFile()
        {
            if (fileList.Count() > 1)
            {
                PdfDocument resultPdf = MergePDFs(fileList);
                savePdf.Filter = "Pdf Files|*.pdf";
                if (savePdf.ShowDialog() == DialogResult.OK)
                    resultPdf.Save(savePdf.FileName);
            }
            else
                MessageBox.Show("Please upload atleast 2 files to merge.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /**
         * this method is used to update the file list when a file is drag dropped into the listbox
         */
        private void AddFileToList(DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                if (".pdf" == Path.GetExtension(file))
                {
                    fileList.Add(file);
                    listBoxFileList.Items.Add(file);
                }
            }
        }
    }
}
