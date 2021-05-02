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
        SMI smiUC;
        int tabIndex = 0;

        //FP
        List<DataStorage> dslist = new List<DataStorage>();
        List<UserControl2> ucList = new List<UserControl2>();
        
        //UCP
        List<UCPDataStorage> ucpdslist = new List<UCPDataStorage>();
        List<UCPUserControl> ucpList = new List<UCPUserControl>();


        List<SMI> smiuclist = new List<SMI>();
        List<List<SMIDataStorage>> smidslist = new List<List<SMIDataStorage>>();

        IDictionary<string, TabPage> closedTabs = new Dictionary<string, TabPage>();
        // List<TabPage> closedTabs= new List<TabPage>();

        public List<DataStorage> Dslist { get => dslist; set => dslist = value; }
        public List<UserControl2> UcList { get => ucList; set => ucList = value; }
        //UCP
        public List<UCPDataStorage> Ucpdslist { get => ucpdslist; set => ucpdslist = value; }
        public List<UCPUserControl> UcpList { get => ucpList; set => ucpList = value; }
        public List<List<SMIDataStorage>> Smilist { get => smidslist; set => smidslist = value; }
        public List<SMI> Smiuclist { get => smiuclist; set => smiuclist = value; }
        public IDictionary<string, TabPage> ClosedTabs { get => closedTabs; set => closedTabs = value; }




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
            MessageBoxManager.Abort = "Save";
            MessageBoxManager.Retry = "Discard";
            MessageBoxManager.Ignore = "Cancel";
            MessageBoxManager.Register();
            DialogResult d;
            d = MessageBox.Show("Save or Discard Changes", "Exit", MessageBoxButtons.AbortRetryIgnore);
            if(d == DialogResult.Abort)
            {
                saveFile_Click(sender,e);                
            }
            if(d == DialogResult.Retry)
            {
                Application.Exit();
            }              
            if(d == DialogResult.Ignore)
            {                
            }
            MessageBoxManager.Unregister();

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
            projDet.Ucplist = Ucpdslist;
            projDet.Smilist = smidslist;

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
            this.ucpdslist = new List<UCPDataStorage>();
            this.smidslist = new List<List<SMIDataStorage>>();
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


            projDet.Ucplist.ForEach(x =>
            {
                UCPUserControl ucpuseCon = new UCPUserControl(x);
                ucpList.Add(ucpuseCon);
                ucpuseCon.Dock = DockStyle.Fill;
                TabPage myTabPage = new TabPage("UseCasePoint");//Create new tabpage
                myTabPage.Controls.Add(ucpuseCon);
                FPTab.TabPages.Add(myTabPage);

                ucpuseCon.UcpDS = x;

                UCPDataStorage ucpds = new UCPDataStorage();
                
                ucpds=ucpuseCon.UcpDS;
                Ucpdslist.Add(ucpuseCon.UcpDS);
            });

            projDet.Smilist.ForEach(x =>
            {
                SMI smiusecon = new SMI(x);
                smiuclist.Add(smiusecon);
                smiusecon.Dock = DockStyle.Fill;
                TabPage myTabPage = new TabPage("Software Maturity Index");//Create new tabpage
                myTabPage.Controls.Add(smiusecon);
                FPTab.TabPages.Add(myTabPage);

                smiusecon.SmiDataStoreList = x;

                List<SMIDataStorage> tempsmidslist = new List<SMIDataStorage>();

                tempsmidslist = smiusecon.SmiDataStoreList;
                smidslist.Add(smiusecon.SmiDataStoreList);
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
                ucpList = new List<UCPUserControl>();
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
            if (newProj == null)
            {
                enterFPDataToolStripMenuItem.Enabled = false;
                enterUCPToolStripMenuItem.Enabled = false;
                toolStripMenuItem2.Enabled = false;
            }
            else
            {
                enterFPDataToolStripMenuItem.Enabled = true;
                enterUCPToolStripMenuItem.Enabled = true;
                toolStripMenuItem2.Enabled = true;
            }
        }

        private void enterUCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucpUC = new UCPUserControl(new UCPDataStorage());
            UcpList.Add(ucpUC);
            ucpUC.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage("UseCasePoint");//Create new tabpage
            myTabPage.Controls.Add(ucpUC);
            FPTab.TabPages.Add(myTabPage);
            UCPDataStorage ucpDS = new UCPDataStorage();
            ucpDS=ucpUC.UcpDS;
            //Add new UCPDatastorage in UCPList
            Ucpdslist.Add(ucpUC.UcpDS);

           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            smiUC = new SMI(new List<SMIDataStorage>());
            smiuclist.Add(smiUC);
            smiUC.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage("Software Maturity Index");//Create new tabpage
            myTabPage.Controls.Add(smiUC);
            FPTab.TabPages.Add(myTabPage);
            // List<SMIDataStorage> tempSmiDsList=new List<SMIDataStorage>();
            // tempSmiDsList=smiUC.SmiDataStoreList;
            smidslist.Add(smiUC.SmiDataStoreList);       
            
        }

        private void tabclose_Click(object sender, EventArgs e)
        {
            
            if(FPTab.SelectedIndex == 0)
            {
                MessageBox.Show("Cannot close the welcome page !");
            }
            else if(FPTab.TabCount > 0)
            {
              string name=FPTab.SelectedTab.Text+ " " + (tabIndex);
                ClosedTabs.Add(name, FPTab.SelectedTab);
                restoreStrip.DropDownItems.Add(name);

                // restoreStrip.DropDownItems.Add(new MenuItem(name, MenuItemNew_Click);
                FPTab.TabPages.RemoveAt(FPTab.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please open/create a tab to close!");
            }
        }

        public void restoreStrip_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            string clickedtext = e.ClickedItem.Text;
            MessageBox.Show(clickedtext);
        }

        private void RestoreMenuItemNew_Click(object sender, EventArgs e){
        
        }
        private void restoreStrip_Click(object sender, EventArgs e)
        {
            
        }

    }
}
