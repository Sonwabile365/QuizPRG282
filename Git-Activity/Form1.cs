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

namespace Git_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Untitled.txt");
            List<string> TextfileList = File.ReadAllLines(path).ToList<string>();
            foreach(var item in TextfileList)
            {
                lstBox1.Items.Add((item));
            }
        }
    }
}
