using System.Globalization;
using System.Text.RegularExpressions;

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

        private void button1_Click(object sender, EventArgs e)
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
                || !Regex.IsMatch(textBox2.Text, @"^(-)?(\d+|(\d+(\s\d{3}))*)(\.\d+)?$")
                || !Regex.IsMatch(textBox5.Text, @"^(-)?(\d+|(\d+(\s\d{3}))*)(\.\d+)?$")
                || !Regex.IsMatch(textBox4.Text, @"^(-)?(\d+|(\d+(\s\d{3}))*)(\.\d+)?$"))
            {
                label3.Text = "Incorrect input data.";
                return;
            }

            var parse1 = decimal.TryParse(Regex.Replace(textBox1.Text, @"\s+", ""), out var number1);
            var parse2 = decimal.TryParse(Regex.Replace(textBox2.Text, @"\s+", ""), out var number2);
            var parse3 = decimal.TryParse(Regex.Replace(textBox5.Text, @"\s+", ""), out var number3);
            var parse4 = decimal.TryParse(Regex.Replace(textBox4.Text, @"\s+", ""), out var number4);

            if (!parse1 || !parse2 || !parse3 || !parse4)
            {
                label3.Text = "Incorrect input data.";
                return;
            }

            (bool, decimal) result1, result2 = (false, 0), result3 = (false, 0);

            result1 = ApplyOperation(comboBox3.SelectedIndex, number2, number3);
            if (result1.Item1) result2 = ApplyOperation(comboBox1.SelectedIndex, number1, result1.Item2);
            if (result2.Item1) result3 = ApplyOperation(comboBox2.SelectedIndex, result2.Item2, number4);

            DisplayRoundResult(comboBox4.SelectedIndex, result3.Item2);
            label3.Text = string.Empty;
        }

        private void DisplayRoundResult(int roundingType, decimal result)
        {
            switch (roundingType)
            {
                case 0:
                    textBox3.Text = Math.Round(result, 6, MidpointRounding.AwayFromZero).ToString("#,0.######").Replace(',', ' ');
                    textBox6.Text = Math.Round(result, MidpointRounding.AwayFromZero).ToString("#,0.######").Replace(',', ' ');
                    break;
                case 1:
                    textBox3.Text = Math.Round(result, 6, MidpointRounding.ToEven).ToString("#,0.######").Replace(',', ' ');
                    textBox6.Text = Math.Round(result, MidpointRounding.ToEven).ToString("#,0.######").Replace(',', ' ');
                    break;
                case 2:
                    textBox3.Text = Truncate6Nums(result).ToString("#,0.######").Replace(',', ' ');
                    textBox6.Text = decimal.Truncate(result).ToString("#,0.######").Replace(',', ' ');
                    break;
                default:
                    result = 0;
                    break;
            }
        }

        public static decimal Truncate6Nums(decimal value)
        {
            return decimal.Truncate(value * 1000000) / 1000000;
        }


        private (bool, decimal) ApplyOperation(int operation, decimal number1, decimal number2)
        {
            decimal result;
            switch (operation)
            {
                case 0:
                    result = Math.Round(number1 + number2, 10);
                    break;
                case 1:
                    result = Math.Round(number1 - number2, 10);
                    break;
                case 2:
                    result = Math.Round(number1 * number2, 10);
                    break;
                case 3:
                    if (number2 == 0)
                    {
                        label3.Text = "Can't divide by zero.";
                        return (false, number1);
                    }
                    else
                    {
                        result = Math.Round(number1 / number2, 10);
                    }
                    break;
                default:
                    result = 0;
                    break;
            }
            return (true, result);
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