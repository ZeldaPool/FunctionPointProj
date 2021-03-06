using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        /* DataStorage ds = new DataStorage();*/
        ProjectDetails projDet;    

        List<DataStorage> dslist = new List<DataStorage>();


        public List<DataStorage> Dslist { get => dslist; set => dslist = value; }
        


        /*public DataStorage Ds { get => ds; set => ds = value; }*/

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newProj = new Form3(this);
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
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterFPDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl2 useCon = new UserControl2();
            useCon.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage("FunctionPoint");//Create new tabpage
            myTabPage.Controls.Add(useCon);
            FPTab.TabPages.Add(myTabPage);

            DataStorage ds = new DataStorage();
            ds = useCon.Ds;
            dslist.Add(ds);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            projDet = newProj.ProjDet;
            projDet.Dslist = dslist;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".ms";
            saveFileDialog.Filter = "MS Files|*.ms";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string filename = saveFileDialog.FileName;
                // serialize JSON directly to a file
                using (StreamWriter file = File.CreateText(filename))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, projDet);
                }

            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
             

        }

        public void clearPanes()
        {
            for (int i = 1; i < this.FPTab.TabCount; i++)
            {
                FPTab.TabPages.RemoveAt(i--);
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".ms";
            openFileDialog.Filter = "MS Files|*.ms";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string filename = openFileDialog.FileName;
                // serialize JSON directly to a file
                using (StreamReader file = File.OpenText(filename))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    ProjectDetails openedFile = (ProjectDetails)serializer.Deserialize(file, typeof(ProjectDetails));
                    Console.WriteLine(openedFile.ProjectName);
                }

            }
        }
    }
}
