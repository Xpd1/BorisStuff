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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form2 form2 = new Form2();
            form2.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "avi Files (*.avi)|*.avi|mkv Files (*.mkv)|*.mkv|mp4 Files (*.mp4)|*.mp4";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(dlg.FileName);
            }
            dlg.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Boris Rodic IT 59/14");
        }

  
    }
}
