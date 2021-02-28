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
        private decimal totaller;
        Form2 langForm = new Form2();
        Form5 vaf = new Form5();

        public decimal fpValue;
       

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
            eottl.Text = ((ds.Eo)*ds.Eo_factor).ToString();
            eiqttl.Text = ((ds.Eiq)*ds.Eiq_factor).ToString();
            ilfttl.Text = ((ds.Ilf)*ds.Ilf_factor).ToString();
            elfttl.Text = ((ds.Elf)*ds.Elf_factor).ToString();
            totaller = (((ds.Ei) * ds.Ei_factor) + ((ds.Eo) * ds.Eo_factor) +((ds.Eiq) * ds.Eiq_factor) +((ds.Ilf) * ds.Ilf_factor) +((ds.Elf) * ds.Elf_factor));
            ttlCount.Text = totaller.ToString();
            ds.LangSel = label12.Text;

            /*FP = CT * [0.65 + 0.01 * VAF]*/

            decimal vaf = int.Parse(vaflbl.Text);
            decimal temp = Convert.ToDecimal(0.01);
            decimal temp2 = Convert.ToDecimal(0.65);


            fpValue = totaller * (temp2 + (temp * vaf));
            fpFinal.Text = fpValue.ToString("N");

            
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
               /* eirb = rb;*/
                ds.Ei_factor = decimal.Parse(rb.Text);
                

            }
        }

        private void eo_CheckedChanged(object sender, EventArgs e)
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
                ds.Eo_factor = decimal.Parse(rb.Text);


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
                ds.Eiq_factor = decimal.Parse(rb.Text);


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
                ds.Ilf_factor = decimal.Parse(rb.Text);


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
                ds.Elf_factor = decimal.Parse(rb.Text);


            }
        }

        

        private void UserControl2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("LOADLOAD");
        }

        private void changeLanguage_Click(object sender, EventArgs e)
        {
            langForm = new Form2();
            langForm.labelChange(label12, label13);
            langForm.Show();

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(vaf.IsDisposed)
            {
                vaf = new Form5();
            }
 
            vaf.labelChange(vaflbl);
            vaf.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label14.Text = (int.Parse(label13.Text) * fpValue).ToString();
        }
    }
}
