using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab2_os
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                try
                {
                    label1.Text += "\n" + drive.Name + "\n" + Convert.ToString(drive.DriveType)
                        + "\n" + Convert.ToString(drive.TotalSize) + "\n" + Convert.ToString(drive.AvailableFreeSpace);
                    

                }
                catch { }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = null;
        }
    }
}
