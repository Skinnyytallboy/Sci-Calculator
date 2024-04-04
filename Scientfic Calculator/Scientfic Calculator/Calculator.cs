using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientfic_Calculator
{
    public partial class Calculator : Form
    {
        double FirstValue = 0,SecondValue = 0,ThirdValue = 0;
        string sym;
        bool isfirst = true;
        public Calculator()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            Screen.Text += "0";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            sym = "+";
            FirstValue = double.Parse(Screen.Text);
            Screen.Text = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            SecondValue= double.Parse(Screen.Text);
            Screen.Text += "=";

            switch (sym) {
                case "+":
                    Screen.Text= (FirstValue+SecondValue).ToString();
                    isfirst = true;
                    break;
                case "-":
                    Screen.Text = (FirstValue - SecondValue).ToString();
                    isfirst = true;
                    break;
                case "*":
                    Screen.Text = (FirstValue * SecondValue).ToString();
                    isfirst = true;
                    break;
                case "/":
                    Screen.Text = (FirstValue / SecondValue).ToString();
                    isfirst = true;
                    break;
                case "%":
                    Screen.Text = (FirstValue % SecondValue).ToString();
                    isfirst = true;
                    break;
                case "pow":
                    Power();
                    Screen.Text = FirstValue.ToString();
                    isfirst=true;
                    break;


            }
        }

        private void Power()
        {
            double pow = FirstValue;
            int i = 1;
            while (i < SecondValue) { FirstValue = FirstValue * pow; i++; }
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            sym = "-";
            FirstValue = double.Parse(Screen.Text);
            Screen.Text = "";
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            sym = "*";
            FirstValue = double.Parse(Screen.Text);
            Screen.Text = "";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            sym = "/";
            FirstValue = double.Parse(Screen.Text);
            Screen.Text = "";
        }

        private void Deci_Click(object sender, EventArgs e)
        {
            if (isfirst) { Screen.Text = ""; isfirst = false; }
            if (Screen.Text == "") { Screen.Text = "0."; }
            Screen.Text += ".";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "") {
                ThirdValue = double.Parse(Screen.Text);
                int temp = (int)ThirdValue / 10;
                Screen.Text= temp.ToString();
            }
        }

        private void Sine_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "" || Screen.Text[0] == '-')
                Screen.Text = "";
            else
            { FirstValue = double.Parse(Screen.Text); Screen.Text = Math.Sin(FirstValue).ToString(); }
            isfirst = true;
        }

        private void pow_Click(object sender, EventArgs e)
        {
            sym = "pow";
            FirstValue = double.Parse(Screen.Text);
            Screen.Text = "";
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            sym = "%";
            FirstValue = double.Parse(Screen.Text);
            Screen.Text = "";
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "" || Screen.Text[0] == '-')
                Screen.Text = "";
            else
                { FirstValue = double.Parse(Screen.Text); Screen.Text = Math.Log10(FirstValue).ToString(); }
            isfirst = true;
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "" || Screen.Text[0] == '-')
                Screen.Text = "";
            else
            { 
                FirstValue = double.Parse(Screen.Text);
                double fact = FirstValue;
                for (double i = FirstValue - 1; i >= 1; i--)
                    fact = fact * i;
                Screen.Text = fact.ToString();
            }
            isfirst = true;
        }

        private void Cose_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "" || Screen.Text[0] == '-')
                Screen.Text = "";
            else
            { FirstValue = double.Parse(Screen.Text); Screen.Text = Math.Cos(FirstValue).ToString(); }
            isfirst = true;
        }

        private void Tane_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "" || Screen.Text[0] == '-')
                Screen.Text = "";
            else
            { FirstValue = double.Parse(Screen.Text); Screen.Text = Math.Tan(FirstValue).ToString(); }
            isfirst = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "" || Screen.Text[0] == '-')
                Screen.Text = "";
            else
            { FirstValue = double.Parse(Screen.Text); Screen.Text = Math.Sinh(FirstValue).ToString(); }
            isfirst = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "" || Screen.Text[0] == '-')
                Screen.Text = "";
            else
            { FirstValue = double.Parse(Screen.Text); Screen.Text = Math.Cosh(FirstValue).ToString(); }
            isfirst = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "" || Screen.Text[0] == '-')
                Screen.Text = "";
            else
            { FirstValue = double.Parse(Screen.Text); Screen.Text = Math.Tanh(FirstValue).ToString(); }
            isfirst = true;
        }
     
        private void Binary_Click(object sender, EventArgs e)
        {
            ThirdValue = double.Parse(Screen.Text);
            Screen.Text = Convert.ToString((int)ThirdValue,2);
            isfirst = true;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {

            ThirdValue = double.Parse(Screen.Text);
            Screen.Text = Convert.ToString((int)ThirdValue, 10);
            isfirst = true;
        }

        private void Octal_Click(object sender, EventArgs e)
        {
            ThirdValue = double.Parse(Screen.Text);
            Screen.Text = Convert.ToString((int)ThirdValue, 8);
            isfirst = true;
        }

        private void HEX_Click(object sender, EventArgs e)
        {
            ThirdValue = double.Parse(Screen.Text);
            Screen.Text = Convert.ToString((int)ThirdValue, 16);
            isfirst = true;
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "" || Screen.Text[0] == '-')
                Screen.Text = "";
            else
            { FirstValue = double.Parse(Screen.Text); Screen.Text = Math.Sqrt(FirstValue).ToString(); }
            isfirst = true;
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            ThirdValue = double.Parse(Screen.Text);
            if (ThirdValue >= 0) { Screen.Text = "-"; Screen.Text += ThirdValue.ToString(); }
            if (ThirdValue < 0) { Screen.Text = "+"; Screen.Text += ThirdValue.ToString(); }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
