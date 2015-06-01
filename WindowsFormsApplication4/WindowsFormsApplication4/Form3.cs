using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "mp3 Files (*.mp3)|*.mp3|mp4 Files (*.mp4)|*.mp4";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL= dlg.FileName;
            }
            dlg.Dispose();
        }
    }
}
