using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KJDClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://cyanogenmodroms.com/link/cm-14-1-20161225-nightly-hammerhead-zip/");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void installADBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://ava3.androidfilehost.com/dl/_amIjxsuJST1cymO2QRJcw/1694180846/746010030569952951/minimal_adb_fastboot_v1.4.3_setup.exe");
        }

        private void hHForHammerheadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://sourceforge.net/projects/hammerhead-twrp/files/beta/twrp-3.7.0_9-HH.R.17.img/download");
        }

        private void normalForHammerheadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://eu.dl.twrp.me/hammerhead/twrp-3.7.0_9-0-hammerhead.img");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
                f2.Show();
        }
    }
}
