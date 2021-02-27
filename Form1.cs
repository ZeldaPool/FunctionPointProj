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
    public partial class Form1 : Form
    {
        Form2 langForm = new Form2();
        Form3 newProj;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newProj = new Form3();
            newProj.Show();
        }

        private void exitFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void languagePreference_Click(object sender, EventArgs e)
        {
            langForm = new Form2();
            langForm.Show();
            
        }

        private void functionpointMetric_Click(object sender, EventArgs e)
        {
            Console.WriteLine(langForm.LangSelected);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterFPDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl2 useCon = new UserControl2();
            useCon.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(useCon);
            FPTab.TabPages.Add(myTabPage);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
