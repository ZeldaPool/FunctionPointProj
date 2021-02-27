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
    public partial class Form2 : Form
    {
        private string langSelected;
        private RadioButton selectedrb;

        public string LangSelected { get => langSelected; set => langSelected = value; }

        public Form2()
        {
            InitializeComponent();
           
           // this.radioButton2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
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
                selectedrb = rb;
                langSelected = selectedrb.Text;
               
            }
        }


       
    }
}
