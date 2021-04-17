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
        UserControl2 useCon;
        UCPUserControl ucpUC;

        List<DataStorage> dslist = new List<DataStorage>();
        List<UserControl2> ucList = new List<UserControl2>();
        List<UCPUserControl> ucpList = new List<UCPUserControl>();


        public List<DataStorage> Dslist { get => dslist; set => dslist = value; }
        public List<UserControl2> UcList { get => ucList; set => ucList = value; }



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
            /*projDet = null;*/
            
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

            
            if(UcList.Count != 0)
            {
                ucList.ForEach(val =>
                {
                    if (val.Visible)
                    {
                        val.changeLang();
                    }
                });
               /*useCon.changeLang();*/         
            }
            else
            {
                langForm = new Form2();
                langForm.Show();
            }
        }

        private void functionpointMetric_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void enterFPDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            useCon = new UserControl2(new DataStorage());
            ucList.Add(useCon);
            useCon.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage("FunctionPoint");//Create new tabpage
            myTabPage.Controls.Add(useCon);
            FPTab.TabPages.Add(myTabPage);

            DataStorage ds = new DataStorage();
            ds = useCon.Ds;
            //Add New DataStorage object to new List
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
            /*if (projDet == null)
            {
                projDet = newProj.ProjDet;
                projDet.Dslist = dslist;
            }*/

            if(newProj == null)
            {
                MessageBox.Show("Cant save without creating or opening new one");
                return;
            }

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
            this.dslist = new List<DataStorage>();
        }

        public void loadPanes()
        {
            this.Text = projDet.ProjectName;
            
            projDet.Dslist.ForEach(x =>
            {
                UserControl2 useCon = new UserControl2(x);
                ucList.Add(useCon);
                useCon.Dock = DockStyle.Fill;
                TabPage myTabPage = new TabPage("FunctionPoint");//Create new tabpage
                myTabPage.Controls.Add(useCon);
                FPTab.TabPages.Add(myTabPage);

                useCon.Ds = x;

                DataStorage ds = new DataStorage();
                ds = useCon.Ds;
                dslist.Add(ds);
            });

        }

        private void openFile_Click(object sender, EventArgs e)
        {

            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".ms";
            openFileDialog.Filter = "MS Files|*.ms";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                ucList = new List<UserControl2>();               
                string filename = openFileDialog.FileName;
                // serialize JSON directly to a file
                using (StreamReader file = File.OpenText(filename))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    projDet = (ProjectDetails)serializer.Deserialize(file, typeof(ProjectDetails));
                    newProj = new Form3(this);
                    newProj.ProjDet = projDet;
                    clearPanes();                
                    loadPanes();
                }   

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metricToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enterUCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucpUC = new UCPUserControl();
            ucpList.Add(ucpUC);
            ucpUC.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage("UseCasePoint");//Create new tabpage
            myTabPage.Controls.Add(ucpUC);
            FPTab.TabPages.Add(myTabPage);

            /*DataStorage ds = new DataStorage();
            ds = useCon.Ds;*/
            //Add New DataStorage object to new List
            //dslist.Add(ds);
        }
    }
}
