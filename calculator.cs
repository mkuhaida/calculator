using System.Globalization;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private readonly char currentDelimiter;

        public Calculator()
        {
            currentDelimiter = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBox3Value();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBox3Value();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBox3Value();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CorrectInputSymbol(e, textBox1.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CorrectInputSymbol(e, textBox2.Text);
        }


        private void UpdateTextBox3Value()
        {
            if (!Regex.IsMatch(textBox1.Text, @"^(-)?(\d+|(\d+(\s\d{3}))*)(\.\d+)?$")
                || !Regex.IsMatch(textBox2.Text, @"^(-)?(\d+|(\d+(\s\d{3}))*)(\.\d+)?$"))
            {
                label3.Text = "Incorrect input data.";
                return;
            }

            var parse1 = decimal.TryParse(Regex.Replace(textBox1.Text, @"\s+", ""), out var number1);
            var parse2 = decimal.TryParse(Regex.Replace(textBox2.Text, @"\s+", ""), out var number2);

            if(!parse1 || !parse2)
            {
                label3.Text = "Incorrect input data.";
                return;
            }

            decimal result;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    result = number1 + number2;
                    break;
                case 1:
                    result = number1 - number2;
                    break;
                case 2:
                    result = number1 * number2;
                    break;
                case 3:
                    if (number2 == 0)
                    {
                        label3.Text = "Can't divide by zero.";
                        return;
                    }
                    else
                    {
                        result = number1 / number2;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }
            textBox3.Text = result.ToString("#,0.######").Replace(',', ' ');
            label3.Text = string.Empty;
        }

        private void CorrectInputSymbol(KeyPressEventArgs e, string text)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = currentDelimiter;
            }

            if (!IsKeyCharValid(e.KeyChar) || DelimiterAlreadyExists(e.KeyChar, text))
            {
                e.Handled = true;
            }
        }

        private bool IsKeyCharValid(char c) =>
            char.IsDigit(c)
            || c == '.' || c == ',' || c == ' ' || c == '-'
            || char.IsControl(c);

        private bool DelimiterAlreadyExists(char c, string text) =>
            (c == '.' || c == ',') && text.Contains(currentDelimiter);
    }
}