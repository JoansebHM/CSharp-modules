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

        string[] path;
        List<string> lyrics = new List<string>();

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex >= 0)
            {
                axWindowsMediaPlayer1.URL = Lista.Items[Lista.SelectedIndex].ToString();
            }//error
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
            abrir.Multiselect = true;
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                
                path = abrir.FileNames;
                for (int i = 0; i < path.Length; i++)
                {
                    lyrics.Add(path[i]);
                    Lista.Items.Add(path[i]);
                }
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Lista.Items.RemoveAt(Lista.SelectedIndex);
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
