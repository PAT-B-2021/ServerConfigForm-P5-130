using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceMtk_P1_20190140130;
using System.Windows.Forms;

namespace ServerConfigForm_P5_130
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ON_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            ON.Enabled = false;
            OFF.Enabled = true;
        }
        private void buttonOff_Click(object sender, EventArgs e)
        {

            ON.Enabled = true;
            OFF.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik ON untuk Menjalankan Server";
            labelOnOrOff.Text = "Server OFF";
        }
    }
}
