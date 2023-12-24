namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            comboBox4 = new ComboBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "0";
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLightLight;
            textBox3.Location = new Point(1147, 79);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(166, 27);
            textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DisplayMember = "+";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(182, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(69, 28);
            comboBox1.TabIndex = 3;
            comboBox1.TabStop = false;
            comboBox1.SelectedIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 21);
            label2.Name = "label2";
            label2.Size = new Size(419, 20);
            label2.TabIndex = 5;
            label2.Text = "Кугайдо Марина Александровна, 4 курс, 4 группа, 2023 год";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 143);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 82);
            label4.Name = "label4";
            label4.Size = new Size(14, 20);
            label4.TabIndex = 7;
            label4.Text = "(";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(776, 80);
            label5.Name = "label5";
            label5.Size = new Size(14, 20);
            label5.TabIndex = 11;
            label5.Text = ")";
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.DisplayMember = "+";
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox2.Location = new Point(820, 78);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(69, 28);
            comboBox2.TabIndex = 10;
            comboBox2.TabStop = false;
            comboBox2.SelectedIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(910, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 9;
            textBox4.Text = "0";
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(611, 78);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(148, 27);
            textBox5.TabIndex = 8;
            textBox5.Text = "0";
            textBox5.KeyPress += textBox5_KeyPress_1;
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.DisplayMember = "+";
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox3.Location = new Point(507, 79);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(69, 28);
            comboBox3.TabIndex = 12;
            comboBox3.TabStop = false;
            comboBox3.SelectedIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1091, 77);
            button1.Name = "button1";
            button1.Size = new Size(32, 29);
            button1.TabIndex = 13;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox4
            // 
            comboBox4.Cursor = Cursors.Hand;
            comboBox4.DisplayMember = "+";
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FlatStyle = FlatStyle.Flat;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "mathematical rounding", "accounting (banking) rounding", "truncation rounding" });
            comboBox4.Location = new Point(887, 152);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(236, 28);
            comboBox4.TabIndex = 14;
            comboBox4.TabStop = false;
            comboBox4.SelectedIndex = 0;
            // 
            // textBox6
            // 
            textBox6.AccessibleRole = AccessibleRole.None;
            textBox6.Location = new Point(1147, 152);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(166, 27);
            textBox6.TabIndex = 15;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 192);
            Controls.Add(textBox6);
            Controls.Add(comboBox4);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox3;
        private Button button1;
        private ComboBox comboBox4;
        private TextBox textBox6;
    }
}