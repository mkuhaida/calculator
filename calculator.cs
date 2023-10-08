using System.Globalization;

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
            decimal.TryParse(textBox1.Text, out var number1);
            decimal.TryParse(textBox2.Text, out var number2);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox3.Text = (number1 + number2).ToString();
                    break;
                case 1:
                    textBox3.Text = (number1 - number2).ToString();
                    break;
                default:
                    textBox3.Text = string.Empty;
                    break;
            }
        }

        private void CorrectInputSymbol(KeyPressEventArgs e, string text)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = currentDelimiter;
            }

            if (!IsKeyCharValid(e.KeyChar, text)
                || DelimiterAlreadyExists(e.KeyChar, text)
                || !IsInputNumberValid(e.KeyChar, text))
            {
                e.Handled = true;
            }
        }

        private bool IsKeyCharValid(char c, string text) =>
            char.IsDigit(c) || c == '.' || c == ',' || (c == '-' && string.IsNullOrEmpty(text)) || char.IsControl(c);

        private bool DelimiterAlreadyExists(char c, string text) =>
            (c == '.' || c == ',') && text.Contains(currentDelimiter);

        private bool IsInputNumberValid(char c, string text)
        {
            return !char.IsDigit(c) || decimal.TryParse(text + c, out var number) && number <= 1000000000000 && number >= -1000000000000;
        }
    }
}