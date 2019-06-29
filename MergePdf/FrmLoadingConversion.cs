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
    public partial class FrmLoadingConversion : Form
    {
        public Action worker { get; set; }
        public FrmLoadingConversion(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentException();
            this.worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }


    }
}
