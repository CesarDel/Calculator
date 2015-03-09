using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Calculator
{
    public partial class ViewPreferences : Form
    {
        public ViewPreferences()
        {
            InitializeComponent();
            SetDefault();
        }

        private void SetDefault()
        {
            FileController f1 = new FileController();

            ArrayList qq = f1.Read(new System.IO.StreamReader("Preferences.txt"));

            string line = "", line2 = "";

            foreach (var item in qq)
            {
                line2 = (string) item;
                
                if(line2.Contains("History"))
                {
                    line = line2.Substring(line2.IndexOf("=") + 1);
                }
            }
                        
            if(line.Equals("true"))
            {
                radioButton1.Checked = true;
            }else
                if(line.Equals("false"))
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
        }

        public System.Windows.Forms.RadioButton getRadioButton1()
        {
            return radioButton1;
        }

        public System.Windows.Forms.RadioButton getRadioButton2()
        {
            return radioButton2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileController f1 = new FileController();

            if(radioButton1.Checked)
            {
                f1.Write(f1.Create("Preferences.txt"), "History=true");

            }else
                if(radioButton2.Checked)
                {
                    f1.Write(f1.Create("Preferences.txt"), "History=false");
                }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
