using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lector_pdf
{
    public partial class formpdf : Form
    {
        public formpdf()
        {
            InitializeComponent();
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos PDF | *.pdf";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pdfreader.src = openFileDialog1.FileName;
            }
        }
    }
}
