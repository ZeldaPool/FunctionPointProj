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
    public partial class SMI : UserControl
    {
        decimal smiValue;

        List<SMIDataStorage> smiDataStoreList=new List<SMIDataStorage>();

        public List<SMIDataStorage> SmiDataStoreList { get => smiDataStoreList; set => smiDataStoreList = value; }

        public SMI(List<SMIDataStorage> SMIDataStorage)
        {
            
               this.SmiDataStoreList=SMIDataStorage;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get a reference to the previous existent 
            RowStyle temp = smiTable.RowStyles[smiTable.RowCount - 1];
            //increase panel rows count by one
            smiTable.RowCount++;
            //add a new RowStyle as a copy of the previous one
            smiTable.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add your three controls
            smiTable.Controls.Add(new Label() { Text = "0", ForeColor = Color.White, Dock = DockStyle.Fill }, 0, smiTable.RowCount - 1);
            smiTable.Controls.Add(new NumericUpDown() { Text = "0", Dock = DockStyle.Fill, Maximum = 999999 }, 1, smiTable.RowCount - 1);
            smiTable.Controls.Add(new NumericUpDown() { Text = "0", Dock = DockStyle.Fill, Maximum = 999999 }, 2, smiTable.RowCount - 1);
            smiTable.Controls.Add(new NumericUpDown() { Text = "0", Dock = DockStyle.Fill, Maximum = 999999 }, 3, smiTable.RowCount - 1);
            NumericUpDown num= new NumericUpDown() { Text = "0", Dock = DockStyle.Fill, Maximum = 999999, ReadOnly = true};
            num.Controls[0].Enabled = false;
            smiTable.Controls.Add(num, 4, smiTable.RowCount - 1);

            SmiDataStoreList.Add(new SMIDataStorage());

            /*smiTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));*/
        }

        private void smiTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            compute();

       
        }

        public void compute()
        {
            int rowCounter = smiTable.RowCount;
            int total=0;
            // Console.WriteLine(rowCounter);
            SMIDataStorage smiDataStore;

            for (int i = 1; i < rowCounter; i++)
            {

                smiDataStore= SmiDataStoreList[i-1];
                
                int added= int.Parse(smiTable.GetControlFromPosition(1, i).Text);
                int changed= int.Parse(smiTable.GetControlFromPosition(2, i).Text);
                int deleted= int.Parse(smiTable.GetControlFromPosition(3, i).Text);

                smiDataStore.AddedModules=added;
                smiDataStore.DeletedModules=deleted;
                smiDataStore.ChangedModules=changed;

                total = total + (added - deleted);
                
                smiTable.GetControlFromPosition(4, i).Text=total.ToString();

                try {
                 smiValue = (total - (added + changed + deleted)) / (decimal)total;
                 } catch (DivideByZeroException) {
                    MessageBox.Show("Total modules at Row " +i  +" Cannot be ZERO");
                    smiValue = 0;
                }
                
                // Console.WriteLine(smiValue.ToString());
                smiTable.GetControlFromPosition(0, i).Text = smiValue.ToString("N15");
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            
            this.SmiDataStoreList.ForEach((smiDataStore) =>
            {
                Console.WriteLine("Added : {0} , Changed : {1} , Deleted : {2}",smiDataStore.AddedModules,
                smiDataStore.ChangedModules,smiDataStore.DeletedModules);
            });

            Console.WriteLine("---------------------------------------------");
        }*/

        private void SMI_Load(object sender, EventArgs e)
        {
            this.SmiDataStoreList.ForEach((smiDataStore) =>
            {

                RowStyle temp = smiTable.RowStyles[smiTable.RowCount - 1];
                //increase panel rows count by one
                smiTable.RowCount++;
                //add a new RowStyle as a copy of the previous one
                smiTable.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
                //add your three controls
                smiTable.Controls.Add(new Label() { Text = "0", ForeColor = Color.White, Dock = DockStyle.Fill }, 0, smiTable.RowCount - 1);
                smiTable.Controls.Add(new NumericUpDown() { Text = smiDataStore.AddedModules.ToString(), Dock = DockStyle.Fill, Maximum = 999999 }, 1, smiTable.RowCount - 1);
                smiTable.Controls.Add(new NumericUpDown() { Text = smiDataStore.ChangedModules.ToString(), Dock = DockStyle.Fill, Maximum = 999999 }, 2, smiTable.RowCount - 1);
                smiTable.Controls.Add(new NumericUpDown() { Text = smiDataStore.DeletedModules.ToString(), Dock = DockStyle.Fill, Maximum = 999999 }, 3, smiTable.RowCount - 1);
                NumericUpDown num= new NumericUpDown() { Text = "0", Dock = DockStyle.Fill, Maximum = 999999, ReadOnly = true};
                num.Controls[0].Enabled = false;
                smiTable.Controls.Add(num, 4, smiTable.RowCount - 1);  
            });
            compute();

         
        }
    }
}
