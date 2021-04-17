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
    public partial class ECFform : Form
    {
        private UCPDataStorage ucpDS;
        private decimal ECFValue;
        private decimal ecftotalFactor;
        private Label labellabel;
        public ECFform(UCPDataStorage ucpDS)
        {
            this.ucpDS = ucpDS;
            InitializeComponent();
        }

        private void ECFform_Load(object sender, EventArgs e)
        {
            if (ucpDS.ECFValslist1.Count != 0)
            {
                (t1.Value) = ucpDS.ECFValslist1[0];
                (t2.Value) = ucpDS.ECFValslist1[1];
                (t3.Value) = ucpDS.ECFValslist1[2];
                (t4.Value) = ucpDS.ECFValslist1[3];
                (t5.Value) = ucpDS.ECFValslist1[4];
                (t6.Value) = ucpDS.ECFValslist1[5];
                (t7.Value) = ucpDS.ECFValslist1[6];
                (t8.Value) = ucpDS.ECFValslist1[7];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucpDS.ECFValslist1.AddRange(new List<decimal>() { (t1.Value), (t2.Value), (t3.Value), (t4.Value), (t5.Value), (t6.Value), (t7.Value), (t8.Value) });

            ecftotalFactor=(t1.Value * (decimal)1.5)+ (t2.Value * (decimal)0.5)+ (t3.Value * 1)+ (t4.Value * (decimal)0.5)+ (t5.Value * 1)+ (t6.Value * 2)+ (t7.Value * (-1))+ (t8.Value * 2);
            /*ucpDS.ECFValslist1.ForEach((val) =>
            {
                ecftotalFactor += val;
            });*/

            ECFValue = (decimal)1.4 + ((decimal)(-0.03) * ecftotalFactor);

            ucpDS.ECFtotal1 = ECFValue;
            labellabel.Text = ECFValue.ToString();

            Hide();
        }

        public void changeLabel(Label lbl)
        {
            labellabel = lbl;
        }
    }
}
