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
    public partial class UserControl2 : UserControl
    {

        DataStorage ds = new DataStorage();
        private RadioButton eirb;
        private RadioButton eorb;
        private RadioButton eiqrb;
        private RadioButton ilfrb;
        private RadioButton elfrb;

        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            compFP();
        }

        private void compFP()
        {
            eittl.Text = ((ds.Ei)*ds.Ei_factor).ToString();
            eottl.Text = (ds.Eo).ToString();
            eiqttl.Text = (ds.Eiq).ToString();
            ilfttl.Text = (ds.Ilf).ToString();
            elfttl.Text = (ds.Elf).ToString();

        }

        private void eival_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            ds.Ei = nm1.Value;
        }

        private void eoval_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            ds.Eo = nm1.Value;
        }

        private void eiqval_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            ds.Eiq = nm1.Value;
        }

        private void ilfval_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            ds.Ilf = nm1.Value;
        }

        private void elfval_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            ds.Elf = nm1.Value;
        }

        private void ei_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                eirb = rb;
                ds.Ei_factor = decimal.Parse(eirb.Text);
                

            }
        }

        /*private void eo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                eorb = rb;
               

            }
        }

        private void eiq_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                eiqrb = rb;
                

            }
        }

        private void ilf_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                ilfrb = rb;
                

            }
        }

        private void elf_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                elfrb = rb;
                

            }
        }*/

        private void eiwf1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
