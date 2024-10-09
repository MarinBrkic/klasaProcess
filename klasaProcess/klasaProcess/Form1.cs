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

namespace klasaProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("IExplorer.exe");
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            Process.Start("Word.exe");
        }

        private void buttonStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
            Process.Start(startInfo);
        }
    }
}
