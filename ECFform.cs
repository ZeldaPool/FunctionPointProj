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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucpDS.ECFValslist1.AddRange(new List<decimal>() { (t1.Value * (decimal)1.5), (t2.Value * (decimal)0.5), (t3.Value * 1), (t4.Value * (decimal)0.5), (t5.Value * 1), (t6.Value * 2), (t7.Value * (-1)), (t8.Value * 2) });

            ucpDS.ECFValslist1.ForEach((val) =>
            {
                ecftotalFactor += val;
            });

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
