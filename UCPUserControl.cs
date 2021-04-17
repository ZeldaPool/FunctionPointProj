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
    public partial class UCPUserControl : UserControl
    {

        UCPDataStorage ucpDS = new UCPDataStorage();
        public UCPUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCFform form = new TCFform(ucpDS);

            if (form.IsDisposed)
            {
                form = new TCFform(ucpDS);
            }

            form.changeLabel(tcfvallbl);
            form.Show();
        }

        private void UCPUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ECFform form = new ECFform(ucpDS);

            if (form.IsDisposed)
            {
                form = new ECFform(ucpDS);
            }

            form.changeLabel(ecfvallbl);
            form.Show();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            decimal UUCWVal, UAWVal, UUCP, UCP;
     
            UUCWVal = (UUCWS.Value * 5) + (UUCWA.Value * 10) + (UUCWC.Value * 15);
            UAWVal = (UAWS.Value * 1) + (UAWA.Value * 2) + (UAWC.Value * 3);
            UUCP = UUCWVal + UAWVal;
            UAWTotal.Text = UAWVal.ToString();
            UUCWTotal.Text = UUCWVal.ToString();
            UUCPTotal.Text = UUCP.ToString();

            UCP = decimal.Parse(tcfvallbl.Text) * decimal.Parse(ecfvallbl.Text) * (UUCWVal + UAWVal);
            UCPTotal.Text = UCP.ToString();

            estLOC.Text = (UCP * locUCP.Value).ToString();
            estHrs.Text = (UCP * prodFac.Value).ToString();
            estPM.Text = ((UCP * locUCP.Value) / locPM.Value).ToString();

            ucpDS.UUCWAval1 = UUCWA.Value;
            ucpDS.UUCWSval1 = UUCWS.Value;
            ucpDS.UUCWCval1 = UUCWC.Value;
            ucpDS.UAWSval1 = UAWS.Value;
            ucpDS.UAWAval1 = UAWA.Value;
            ucpDS.UAWCval1 = UAWC.Value;

            ucpDS.UUCWTotalVal1 = UUCWVal;
            ucpDS.UAWTotalVal1 = UAWVal;

            ucpDS.UCPVal1 = UCP;
            ucpDS.UUCPVal1 = UUCP;

            ucpDS.PFval1 = prodFac.Value;
            ucpDS.LOCUCPval1 = locUCP.Value;
            ucpDS.LOCPMval1 = locPM.Value;

            ucpDS.EstHrsVal = decimal.Parse(estHrs.Text);
            ucpDS.EstLocVal = decimal.Parse(estLOC.Text);
            ucpDS.EstPMVal = decimal.Parse(estPM.Text);

            ucpDS.TCFVal1 = decimal.Parse(tcfvallbl.Text);
            ucpDS.ECFVal1 = decimal.Parse(ecfvallbl.Text);

        }

        private void UUCWS_ValueChanged(object sender, EventArgs e)
        {
            UUCWSsum.Text = (UUCWS.Value * 5).ToString();
        }

        private void UUCWA_ValueChanged(object sender, EventArgs e)
        {
            UUCWAsum.Text = (UUCWA.Value * 10).ToString();
        }

        private void UUCWC_ValueChanged(object sender, EventArgs e)
        {
            UUCWCsum.Text = (UUCWC.Value * 15).ToString();
        }

        private void UAWS_ValueChanged(object sender, EventArgs e)
        {
            UAWSsum.Text = (UAWS.Value * 1).ToString();
        }

        private void UAWA_ValueChanged(object sender, EventArgs e)
        {
            UAWAsum.Text = (UAWA.Value * 2).ToString();
        }

        private void UAWC_ValueChanged(object sender, EventArgs e)
        {
            UAWCsum.Text = (UAWC.Value * 3).ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
