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
    public partial class TCFform : Form
    {
        private UCPDataStorage ucpDS;
        private decimal tcfValue;
        private decimal totalFactor;
        private Label labellabel;

        public TCFform(UCPDataStorage ucpDS)
        {
            this.ucpDS = ucpDS;
            InitializeComponent();
        }

        private void tcfButton_Click(object sender, EventArgs e)
        {
            ucpDS.TCFValslist1.AddRange(new List<decimal>() { (t1.Value * 2), (t2.Value*1), (t3.Value*1), (t4.Value * 1), (t5.Value * 1), (t6.Value * (decimal)0.5), (t7.Value * (decimal)0.5), (t8.Value * 2), (t9.Value * 1), (t10.Value * 1), (t11.Value * 1), (t12.Value * 1), (t13.Value * 1) });

            ucpDS.TCFValslist1.ForEach((val) =>
            {
                totalFactor += val;
            });

            tcfValue = (decimal)0.6 + ((decimal)0.01 * totalFactor);

            ucpDS.TCFtotal1 = tcfValue;
            labellabel.Text = tcfValue.ToString();

            Hide();
        }

        public void changeLabel(Label lbl)
        {
            labellabel = lbl;
        }

        private void TCFform_Load(object sender, EventArgs e)
        {

        }
    }
}
