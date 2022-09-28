using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_multimedia
{
    public partial class formultimedia : Form
    {
        public formultimedia()
        {
            InitializeComponent();
        }

        string[] path, files;

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[Lista.SelectedIndex];
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void btnparar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if(Lista.SelectedIndex <Lista.Items.Count - 1)
            {
                Lista.SelectedIndex = Lista.SelectedIndex + 1;
            }
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex > 0)
            {
                Lista.SelectedIndex = Lista.SelectedIndex - 1;
            }
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files= ofd.SafeFileNames;
                path = ofd.FileNames;

                for(int x = 0; x < files.Length; x++)
                {
                    Lista.Items.Add(files[x]);
                }
            }
        }
    }
}
