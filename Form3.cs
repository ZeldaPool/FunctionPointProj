using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionPoint1
{
    public partial class Form3 : Form
    {

        ProjectDetails projDet = new ProjectDetails();
        Form1 titleChange;

        internal ProjectDetails ProjDet { get => projDet; set => projDet = value; }

        public Form3(Form1 form1)
        {
            InitializeComponent();
            titleChange = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            titleChange.UcList = new List<UserControl2>();
            ProjDet.ProjectName = "CECS 543 METRIC SUITE " + textBox1.Text;
            ProjDet.ProductName = textBox2.Text;
            ProjDet.CreatorName = textBox3.Text;
            ProjDet.Comment = richTextBox1.Text;
            titleChange.Text = "CECS 543 METRIC SUITE " + textBox1.Text;
            titleChange.Update();
            titleChange.clearPanes();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
