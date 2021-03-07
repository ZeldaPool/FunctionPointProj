using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        

        public decimal fpValue;

        public DataStorage Ds { get => ds; set => ds = value; }

        /*Form5 vaf = new Form5(new DataStorage());*/

        public UserControl2(DataStorage ds)
        {
            InitializeComponent();
            Ds = ds;

                       /* Console.WriteLine("Constructor");
            eiqttl.Text = Ds.EiTotal.ToString();*/

            /* if(Ds == null)
             {
                ds = new DataStorage();
             }*/
        }

        public void dataLoad()
        {
            eittl.Text = ((Ds.Ei) * Ds.Ei_factor).ToString();
            eottl.Text = ((Ds.Eo) * Ds.Eo_factor).ToString();
            eiqttl.Text = ((Ds.Eiq) * Ds.Eiq_factor).ToString();
            ilfttl.Text = ((Ds.Ilf) * Ds.Ilf_factor).ToString();
            elfttl.Text = ((Ds.Elf) * Ds.Elf_factor).ToString();
            totaller = (((Ds.Ei) * Ds.Ei_factor) + ((Ds.Eo) * Ds.Eo_factor) + ((Ds.Eiq) * Ds.Eiq_factor) + ((Ds.Ilf) * Ds.Ilf_factor) + ((Ds.Elf) * Ds.Elf_factor));
            ttlCount.Text = totaller.ToString();
            label12.Text = Ds.LangSel;
            fpFinal.Text = Ds.ComputedFP.ToString();

            eival.Text = Ds.Ei.ToString();
            eoval.Text = Ds.Eo.ToString();
            eiqval.Text = Ds.Eiq.ToString();
            ilfval.Text = Ds.Ilf.ToString();
            elfval.Text = Ds.Elf.ToString();

            loadFactors();
            
            


            vaflbl.Text = Ds.Vaftotal.ToString();
            Console.WriteLine(Ds.Vaftotal);
 
        }

        public void loadFactors()
        {

            switch (Ds.Ei_factor)
            {
                case 3:
                    eiwf1.Checked = true;
                    break;
                case 4:
                    eiwf2.Checked = true;
                    break;
                case 6:
                    eiwf3.Checked = true;
                    break;
            }

            switch (Ds.Eo_factor)
            {
                case 4:
                    eowf1.Checked = true;
                    break;
                case 5:
                    eowf2.Checked = true;
                    break;
                case 7:
                    eowf3.Checked = true;
                    break;
            }

            switch (Ds.Eiq_factor)
            {
                case 3:
                    eiqwf1.Checked = true;
                    break;
                case 4:
                    eiqwf2.Checked = true;
                    break;
                case 6:
                    eiqwf3.Checked = true;
                    break;
            }

            switch (Ds.Ilf_factor)
            {
                case 7:
                    ilfwf1.Checked = true;
                    break;
                case 10:
                    ilfwf2.Checked = true;
                    break;
                case 15:
                    ilfwf3.Checked = true;
                    break;
            }

            switch (Ds.Elf_factor)
            {
                case 5:
                    elfwf1.Checked = true;
                    break;
                case 17:
                    elfwf2.Checked = true;
                    break;
                case 10:
                    elfwf3.Checked = true;
                    break;
            }
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
            eittl.Text = ((Ds.Ei)*Ds.Ei_factor).ToString();
            eottl.Text = ((Ds.Eo)*Ds.Eo_factor).ToString();
            eiqttl.Text = ((Ds.Eiq)*Ds.Eiq_factor).ToString();
            ilfttl.Text = ((Ds.Ilf)*Ds.Ilf_factor).ToString();
            elfttl.Text = ((Ds.Elf)*Ds.Elf_factor).ToString();
            totaller = (((Ds.Ei) * Ds.Ei_factor) + ((Ds.Eo) * Ds.Eo_factor) +((Ds.Eiq) * Ds.Eiq_factor) +((Ds.Ilf) * Ds.Ilf_factor) +((Ds.Elf) * Ds.Elf_factor));
            ttlCount.Text = totaller.ToString();
            Ds.LangSel = label12.Text;

            Ds.EiTotal  = decimal.Parse(eittl.Text);
            Ds.EoTotal  = decimal.Parse(eottl.Text);
            Ds.EiqTotal = decimal.Parse(eiqttl.Text);
            Ds.IlfTotal = decimal.Parse(ilfttl.Text);
            Ds.ElfTotal = decimal.Parse(elfttl.Text);

            /*FP = CT * [0.65 + 0.01 * VAF]*/

            decimal vaf = decimal.Parse(vaflbl.Text);
            decimal temp = Convert.ToDecimal(0.01);
            decimal temp2 = Convert.ToDecimal(0.65);


            fpValue = totaller * (temp2 + (temp * vaf));
            fpFinal.Text = fpValue.ToString("N");

            Ds.ComputedFP = decimal.Parse(fpFinal.Text);

            
        }

        private void eival_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            Ds.Ei = nm1.Value;
        }

        private void eoval_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            Ds.Eo = nm1.Value;
        }

        private void eiqval_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            Ds.Eiq = nm1.Value;
        }

        private void ilfval_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            Ds.Ilf = nm1.Value;
        }

        private void elfval_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm1 = (NumericUpDown)sender;
            Ds.Elf = nm1.Value;
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
                Ds.Ei_factor = decimal.Parse(rb.Text);
                

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
                Ds.Eo_factor = decimal.Parse(rb.Text);


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
                Ds.Eiq_factor = decimal.Parse(rb.Text);


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
                Ds.Ilf_factor = decimal.Parse(rb.Text);


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
                Ds.Elf_factor = decimal.Parse(rb.Text);


            }
        }

        

        private void UserControl2_Load(object sender, EventArgs e)
        {
            /*Console.WriteLine("DS LOAD");
            eiqttl.Text = Ds.EiTotal.ToString();*/
            dataLoad();
        }

        private void changeLanguage_Click(object sender, EventArgs e)
        {
            changeLang();
        }

        public void changeLang()
        {
            langForm = new Form2();
            langForm.labelChange(label12, label13, Ds);
            langForm.Show();
        }

     

        private void label12_Click(object sender, EventArgs e)
        {
            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 vaf = new Form5(Ds);

            if(vaf.IsDisposed)
            {
                vaf = new Form5(Ds);
            }
 
            vaf.labelChange(vaflbl, Ds);
            vaf.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label14.Text = (int.Parse(label13.Text) * fpValue).ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
