using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Data_textBox.Clear();
            textBoxData.Clear();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DateTime data = new DateTime();
            data = DateTime.Parse(textBoxData.Text);
            Data_textBox.Text = data.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
