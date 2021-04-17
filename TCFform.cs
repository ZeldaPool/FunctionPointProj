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
            ucpDS.TCFValslist1.AddRange(new List<decimal>() { (t1.Value), (t2.Value), (t3.Value), (t4.Value), (t5.Value), (t6.Value), (t7.Value), (t8.Value), (t9.Value), (t10.Value), (t11.Value), (t12.Value), (t13.Value) });

            // ucpDS.TCFValslist1.ForEach((val) =>
            // {
            //     totalFactor += val;
            // });
            totalFactor=(t1.Value * 2)+ (t2.Value*1)+ (t3.Value*1)+ (t4.Value * 1)+ (t5.Value * 1)+ (t6.Value * (decimal)0.5)+ (t7.Value * (decimal)0.5)+ (t8.Value * 2)+ (t9.Value * 1)+ (t10.Value * 1)+ (t11.Value * 1)+ (t12.Value * 1)+ (t13.Value * 1);

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
            if (ucpDS.TCFValslist1.Count != 0)
            {
                (t1.Value) = ucpDS.TCFValslist1[0];
                (t2.Value) = ucpDS.TCFValslist1[1];
                (t3.Value) = ucpDS.TCFValslist1[2];
                (t4.Value) = ucpDS.TCFValslist1[3];
                (t5.Value) = ucpDS.TCFValslist1[4];
                (t6.Value) = ucpDS.TCFValslist1[5];
                (t7.Value) = ucpDS.TCFValslist1[6];
                (t8.Value) = ucpDS.TCFValslist1[7];
                (t9.Value) = ucpDS.TCFValslist1[8];
                (t10.Value) = ucpDS.TCFValslist1[9];
                (t11.Value) = ucpDS.TCFValslist1[10];
                (t12.Value) = ucpDS.TCFValslist1[11];
                (t13.Value) = ucpDS.TCFValslist1[12];
            }
        }
    }
}
