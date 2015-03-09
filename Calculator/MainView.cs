using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainView : Form
    {
        int calcSelection = 0; // variable used for selection of calculation requested
        double param1 = 0;     // variable used to store a parameter for the calculation

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            textBox3.Select();
        }

        private void CursorFocus()
        {
            textBox3.Focus();
            textBox3.SelectionStart = textBox3.Text.Length;
        }

        // addition method
        private void button1_Click(object sender, EventArgs e)
        {

            if (calcSelection != 0)
            {
                Result r1 = Calculation();
                textBox3.Text = Convert.ToString(r1.getValue());
            }

            calcSelection = 1;

            param1 = Double.Parse(textBox3.Text);

            textBox3.Text = null;

            CursorFocus();

        }

        // subtract method
        private void button2_Click(object sender, EventArgs e)
        {
            if (calcSelection != 0)
            {
                Result r1 = Calculation();
                textBox3.Text = Convert.ToString(r1.getValue());
            }

            calcSelection = 2;

            param1 = Double.Parse(textBox3.Text);

            textBox3.Text = null;

            CursorFocus();

        }

        // multiply method
        private void button3_Click(object sender, EventArgs e)
        {
            if (calcSelection != 0)
            {
                Result r1 = Calculation();
                textBox3.Text = Convert.ToString(r1.getValue());
            }

            calcSelection = 3;

            param1 = Double.Parse(textBox3.Text);

            textBox3.Text = null;

            CursorFocus();

        }

        // division method
        private void button4_Click(object sender, EventArgs e)
        {
            if (calcSelection != 0)
            {
                Result r1 = Calculation();
                textBox3.Text = Convert.ToString(r1.getValue());
            }

            calcSelection = 4;

            param1 = Double.Parse(textBox3.Text);

            textBox3.Text = null;

            CursorFocus();

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Show();
        }

        // button used to clear the text box and reset any variables needed to reset
        private void button5_Click(object sender, EventArgs e)
        {
            calcSelection = 0;
            textBox3.Text = null;
            CursorFocus();
        }


        #region Buttons to text
        // puts the number from the button text on the display to do the maths
        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text += button12.Text;
            textBox3.Show();
            
            CursorFocus();
            
        }

        // puts the number from the button text on the display to do the maths
        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text += button13.Text;
            textBox3.Show();
            CursorFocus();
        }

        // puts the number from the button text on the display to do the maths
        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text += button14.Text;
            textBox3.Show();
            CursorFocus();
        }

        // puts the number from the button text on the display to do the maths
        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text += button9.Text;
            textBox3.Show();
            CursorFocus();
        }

        // puts the number from the button text on the display to do the maths
        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text += button10.Text;
            textBox3.Show();
            CursorFocus();
        }

        // puts the number from the button text on the display to do the maths
        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text += button11.Text;
            textBox3.Show();
            CursorFocus();
        }

        // puts the number from the button text on the display to do the maths
        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text += button6.Text;
            textBox3.Show();
            CursorFocus();
        }

        // puts the number from the button text on the display to do the maths
        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text += button7.Text;
            textBox3.Show();
            CursorFocus();
        }

        // puts the number from the button text on the display to do the maths
        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text += button8.Text;
            textBox3.Show();
            CursorFocus();
        }

        // puts the number from the button text on the display to do the maths
        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.Text += button15.Text;
            textBox3.Show();
            CursorFocus();
        }

        // puts the number from the button text on the display to do the maths
        private void button16_Click(object sender, EventArgs e)
        {
            if (!textBox3.Text.Contains("."))
            {
                textBox3.Text += button16.Text;
                textBox3.Show();
                CursorFocus();
            }
        }

        #endregion

        // button that will present the result of the calculation selected
        private void button17_Click(object sender, EventArgs e)
        {
            Result r1 = Calculation();

            textBox3.Text = Convert.ToString(r1.getValue());
        }

        #region KeyPress event handler

        // boolean flag used to determine when a character other than a number is pressed
        private Boolean nonNumberEntered = false;

        // Handle the KeyDown event to determine the type of the character entered into the control
        private void textBox3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // initializing the flag to false
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard. 
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad. 
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace. 
                    if (e.KeyCode != Keys.Back)
                    {

                        if (e.KeyCode == Keys.Add)
                        {
                            if (calcSelection != 0)
                            {
                                Result r1 = Calculation();
                                textBox3.Text = Convert.ToString(r1.getValue());
                            }

                            calcSelection = 1;

                            param1 = Double.Parse(textBox3.Text);

                            textBox3.Text = null;

                            CursorFocus();
                        }

                        if (e.KeyCode == Keys.Subtract)
                        {
                            if (calcSelection != 0)
                            {
                                Result r1 = Calculation();
                                textBox3.Text = Convert.ToString(r1.getValue());
                            }

                            calcSelection = 2;

                            param1 = Double.Parse(textBox3.Text);

                            textBox3.Text = null;

                            CursorFocus();
                        }

                        if (e.KeyCode == Keys.Multiply)
                        {
                            if (calcSelection != 0)
                            {
                                Result r1 = Calculation();
                                textBox3.Text = Convert.ToString(r1.getValue());
                            }

                            calcSelection = 3;

                            param1 = Double.Parse(textBox3.Text);

                            textBox3.Text = null;

                            CursorFocus();
                        }

                        if (e.KeyCode == Keys.Divide)
                        {
                            if (calcSelection != 0)
                            {
                                Result r1 = Calculation();
                                textBox3.Text = Convert.ToString(r1.getValue());
                            }

                            calcSelection = 4;

                            param1 = Double.Parse(textBox3.Text);

                            textBox3.Text = null;

                            CursorFocus();
                        }

                        if (e.KeyCode == Keys.Enter)
                        {
                            Result r1 = Calculation();

                            textBox3.Text = Convert.ToString(r1.getValue());
                        }

                        if (e.KeyCode == Keys.Delete)
                        {
                            calcSelection = 0;
                            textBox3.Text = null;
                        }

                        if (e.KeyCode == Keys.Decimal)
                        {
                            if (!textBox3.Text.Contains("."))
                            {
                                textBox3.Text += button16.Text;
                                textBox3.Show();
                                CursorFocus();
                            }

                        }


                        // A non-numerical keystroke was pressed. 
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }

            //If shift key was pressed, it's not a number. 
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

        }

        // This event occurs after the KeyDown event and can be used to prevent 
        // characters from entering the control. 
        private void textBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event. 
            if (nonNumberEntered == true)
            {

                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        #endregion

        private Result Calculation()
        {

            if (calcSelection == 1)
            { return MainController.Add(new Parameter(param1), new Parameter(Double.Parse(textBox3.Text))); }
            if (calcSelection == 2)
            { return MainController.Subtract(new Parameter(param1), new Parameter(Double.Parse(textBox3.Text))); }
            if (calcSelection == 3)
            { return MainController.Multiply(new Parameter(param1), new Parameter(Double.Parse(textBox3.Text))); }
            if (calcSelection == 4)
            { return MainController.Divide(new Parameter(param1), new Parameter(Double.Parse(textBox3.Text))); }

            calcSelection = 0;

            return null;
        }
    }
}
