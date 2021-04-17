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

        private UCPDataStorage ucpDS = new UCPDataStorage();

        public UCPDataStorage UcpDS { get => ucpDS; set => ucpDS = value; }

        public UCPUserControl(UCPDataStorage ucpDS)
        {
            InitializeComponent();
            this.UcpDS = ucpDS;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCFform form = new TCFform(UcpDS);

            if (form.IsDisposed)
            {
                form = new TCFform(UcpDS);
            }

            form.changeLabel(tcfvallbl);
            form.Show();
        }

        private void UCPUserControl_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void dataload()
        {
            UUCWA.Value=UcpDS.UUCWAval1;
            UUCWS.Value=UcpDS.UUCWSval1;
            UUCWC.Value=UcpDS.UUCWCval1;
            UAWS.Value=UcpDS.UAWSval1;
            UAWA.Value=UcpDS.UAWAval1;
            UAWC.Value=UcpDS.UAWCval1;

            UUCWTotal.Text = UcpDS.UUCWTotalVal1.ToString();
            UAWTotal.Text = UcpDS.UAWTotalVal1.ToString();

            UCPTotal.Text = UcpDS.UCPVal1.ToString();
            UUCPTotal.Text = UcpDS.UUCPVal1.ToString();

            prodFac.Value=UcpDS.PFval1;
            locUCP.Value=UcpDS.LOCUCPval1;
            locPM.Value=UcpDS.LOCPMval1;

            estHrs.Text=UcpDS.EstHrsVal.ToString();
            estLOC.Text=UcpDS.EstLocVal.ToString();
            estPM.Text=UcpDS.EstPMVal.ToString();

            tcfvallbl.Text=UcpDS.TCFVal1.ToString();
            ecfvallbl.Text=UcpDS.ECFVal1.ToString();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ECFform form = new ECFform(UcpDS);

            if (form.IsDisposed)
            {
                form = new ECFform(UcpDS);
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
            UCP = decimal.Round(UCP, 3, MidpointRounding.AwayFromZero);
            UCPTotal.Text = UCP.ToString();
            
            estLOC.Text = decimal.Round((UCP * locUCP.Value), 3, MidpointRounding.AwayFromZero).ToString();
            estHrs.Text = decimal.Round((UCP * prodFac.Value), 3, MidpointRounding.AwayFromZero).ToString();
            estPM.Text  = decimal.Round(((UCP * locUCP.Value) / locPM.Value), 3, MidpointRounding.AwayFromZero).ToString();

            //Save To UCPDs
            UcpDS.UUCWAval1 = UUCWA.Value;
            UcpDS.UUCWSval1 = UUCWS.Value;
            UcpDS.UUCWCval1 = UUCWC.Value;
            UcpDS.UAWSval1 = UAWS.Value;
            UcpDS.UAWAval1 = UAWA.Value;
            UcpDS.UAWCval1 = UAWC.Value;

            UcpDS.UUCWTotalVal1 = UUCWVal;
            UcpDS.UAWTotalVal1 = UAWVal;

            UcpDS.UCPVal1 = UCP;
            UcpDS.UUCPVal1 = UUCP;

            UcpDS.PFval1 = prodFac.Value;
            UcpDS.LOCUCPval1 = locUCP.Value;
            UcpDS.LOCPMval1 = locPM.Value;

            UcpDS.EstHrsVal = decimal.Parse(estHrs.Text);
            UcpDS.EstLocVal = decimal.Parse(estLOC.Text);
            UcpDS.EstPMVal = decimal.Parse(estPM.Text);

            UcpDS.TCFVal1 = decimal.Parse(tcfvallbl.Text);
            UcpDS.ECFVal1 = decimal.Parse(ecfvallbl.Text);

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
