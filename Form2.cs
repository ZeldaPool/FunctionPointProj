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
        private Label labellabel;
        private Label codecode;

        Dictionary<string, int> My_dict2 =
              new Dictionary<string, int>(){
                                  {"Assembler", 337},
                                  {"ADA 95", 154},
                                  {"C", 148},
                                  {"C++", 59},
                                  {"C#", 58},
                                  {"COBOL", 80},
                                  {"FORTRAN", 90},
                                  {"HTML", 43},
                                  {"JAVA", 55},
                                  {"JavaScript", 54},
                                  {"VB Script", 38},
                                  {"Visual Basic", 50}
              };


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
            Console.WriteLine(My_dict2["Assembler"]);
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
                labellabel.Text = langSelected;
                codecode.Text = My_dict2[langSelected].ToString();
            }
        }

        public void labelChange(Label lbl, Label codesize)
        {
            labellabel = lbl;
            codecode = codesize;

            
        }


        public static implicit operator string(Form2 v)
        {
            throw new NotImplementedException();
        }
    }
}
