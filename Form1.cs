using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Программное_обеспечение_для_Диспетчеров_Службы_Спасения
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void Btnreducethewindow_Click(object sender, EventArgs e)
        {
            btnreducethewindow.Visible = false;
            btnexpandthewindow.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Btnexpandthewindow_Click(object sender, EventArgs e)
        {
            btnexpandthewindow.Visible = false;
            btnreducethewindow.Visible = true;
            this.WindowState = FormWindowState.Normal;
            
        }

        private void Btnturn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Btnapplications_Click(object sender, EventArgs e)
        {
            pnlswitch.Height = btnapplications.Height;
            pnlswitch.Top = btnapplications.Top;
           // panelcontent.Visible = true;
            LoadHost.Child = LoadWpf.UserControls[0];

        }

        private void Btnperformed_Click(object sender, EventArgs e)
        {
            pnlswitch.Height = btnperformed.Height;
            pnlswitch.Top = btnperformed.Top;
           // panelcontent.Visible = false;
            LoadHost.Child = LoadWpf.UserControls[1];
        }

        private void Btnstatistics_Click(object sender, EventArgs e)
        {
            pnlswitch.Height = btnstatistics.Height;
            pnlswitch.Top = btnstatistics.Top;
          //  panelcontent.Visible = false;
            LoadHost.Child = LoadWpf.UserControls[2];
        }

        private void Btnmaps_Click(object sender, EventArgs e)
        {
            pnlswitch.Height = btnmaps.Height;
            pnlswitch.Top = btnmaps.Top;
        //    panelcontent.Visible = false;
            MessageBox.Show(@"В разработке!!!");
        }
    }
}
