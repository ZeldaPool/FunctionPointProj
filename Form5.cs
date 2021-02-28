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
    public partial class Form5 : Form
    {
        public decimal vafttl;
        private Label labellabel;

        List<decimal> vafVals = new List<decimal>();

        public List<decimal> VafVals { get => vafVals; set => vafVals = value; }

        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* vafVals.AddRange(new List<decimal>() { vf1.SelectedItem , vf2.SelectedItem , vf3.SelectedItem , vf4.SelectedItem , vf5.SelectedItem , vf6.SelectedItem , vf7.SelectedItem , vf8.SelectedItem , vf9.SelectedItem , vf10.SelectedItem , vf11.SelectedItem , vf12.SelectedItem , vf13.SelectedItem , vf14.SelectedItem });*/
            int totalvf = int.Parse(vf1.SelectedItem.ToString()) +
            int.Parse(vf2.SelectedItem.ToString()) +
            int.Parse(vf3.SelectedItem.ToString()) +
            int.Parse(vf4.SelectedItem.ToString())+
            int.Parse(vf5.SelectedItem.ToString())+
            int.Parse(vf6.SelectedItem.ToString())+
            int.Parse(vf7.SelectedItem.ToString())+
            int.Parse(vf8.SelectedItem.ToString())+
            int.Parse(vf9.SelectedItem.ToString())+
            int.Parse(vf10.SelectedItem.ToString())+
            int.Parse(vf11.SelectedItem.ToString())+
            int.Parse(vf12.SelectedItem.ToString())+
            int.Parse(vf13.SelectedItem.ToString())+
            int.Parse(vf14.SelectedItem.ToString());
            vafttl = totalvf;
            labellabel.Text = vafttl.ToString();
            Hide();
        }

        public void labelChange(Label lbl)
        {
            labellabel = lbl;

        }

       

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vf1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
