﻿namespace Calculator
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            seven = new Button();
            eight = new Button();
            nine = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            divide = new Button();
            multiply = new Button();
            minus = new Button();
            plus = new Button();
            remove = new Button();
            zero = new Button();
            clear = new Button();
            output = new RichTextBox();
            Equals = new Button();
            percent = new Button();
            power = new Button();
            sqrt = new Button();
            SuspendLayout();

            zero.BackColor = Color.Blue;
            zero.BackgroundImageLayout = ImageLayout.None;
            zero.FlatStyle = FlatStyle.Flat;
            zero.Font = new Font("Consolas", 15F, FontStyle.Bold);
            zero.ForeColor = SystemColors.ActiveCaptionText;
            zero.Location = new Point(111, 478);
            zero.Name = "zero";
            zero.Size = new Size(90, 90);
            zero.TabIndex = 14;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += OnNumberClick;

            one.BackColor = Color.Blue;
            one.BackgroundImageLayout = ImageLayout.None;
            one.FlatStyle = FlatStyle.Flat;
            one.Font = new Font("Consolas", 15F, FontStyle.Bold);
            one.ForeColor = SystemColors.ActiveCaptionText;
            one.Location = new Point(11, 382);
            one.Name = "one";
            one.Size = new Size(90, 90);
            one.TabIndex = 6;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += OnNumberClick;

            two.BackColor = Color.Blue;
            two.BackgroundImageLayout = ImageLayout.None;
            two.FlatStyle = FlatStyle.Flat;
            two.Font = new Font("Consolas", 15F, FontStyle.Bold);
            two.ForeColor = SystemColors.ActiveCaptionText;
            two.Location = new Point(111, 382);
            two.Name = "two";
            two.Size = new Size(90, 90);
            two.TabIndex = 7;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += OnNumberClick;

            three.BackColor = Color.Blue;
            three.BackgroundImageLayout = ImageLayout.None;
            three.FlatStyle = FlatStyle.Flat;
            three.Font = new Font("Consolas", 15F, FontStyle.Bold);
            three.ForeColor = SystemColors.ActiveCaptionText;
            three.Location = new Point(211, 382);
            three.Name = "three";
            three.Size = new Size(90, 90);
            three.TabIndex = 8;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += OnNumberClick;

            four.BackColor = Color.Blue;
            four.BackgroundImageLayout = ImageLayout.None;
            four.FlatStyle = FlatStyle.Flat;
            four.Font = new Font("Consolas", 15F, FontStyle.Bold);
            four.ForeColor = SystemColors.ActiveCaptionText;
            four.Location = new Point(11, 286);
            four.Name = "four";
            four.Size = new Size(90, 90);
            four.TabIndex = 3;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += OnNumberClick;

            five.BackColor = Color.Blue;
            five.BackgroundImageLayout = ImageLayout.None;
            five.FlatStyle = FlatStyle.Flat;
            five.Font = new Font("Consolas", 15F, FontStyle.Bold);
            five.ForeColor = SystemColors.ActiveCaptionText;
            five.Location = new Point(111, 286);
            five.Name = "five";
            five.Size = new Size(90, 90);
            five.TabIndex = 4;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += OnNumberClick;

            six.BackColor = Color.Blue;
            six.BackgroundImageLayout = ImageLayout.None;
            six.FlatStyle = FlatStyle.Flat;
            six.Font = new Font("Consolas", 15F, FontStyle.Bold);
            six.ForeColor = SystemColors.ActiveCaptionText;
            six.Location = new Point(211, 286);
            six.Name = "six";
            six.Size = new Size(90, 90);
            six.TabIndex = 5;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += OnNumberClick;

            seven.BackColor = Color.Blue;
            seven.BackgroundImageLayout = ImageLayout.None;
            seven.FlatStyle = FlatStyle.Flat;
            seven.Font = new Font("Consolas", 15F, FontStyle.Bold);
            seven.ForeColor = SystemColors.ActiveCaptionText;
            seven.Location = new Point(11, 190);
            seven.Name = "seven";
            seven.Size = new Size(90, 90);
            seven.TabIndex = 0;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += OnNumberClick;

            eight.BackColor = Color.Blue;
            eight.BackgroundImageLayout = ImageLayout.None;
            eight.FlatStyle = FlatStyle.Flat;
            eight.Font = new Font("Consolas", 15F, FontStyle.Bold);
            eight.ForeColor = SystemColors.ActiveCaptionText;
            eight.Location = new Point(111, 190);
            eight.Name = "eight";
            eight.Size = new Size(90, 90);
            eight.TabIndex = 1;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += OnNumberClick;

            nine.BackColor = Color.Blue;
            nine.BackgroundImageLayout = ImageLayout.None;
            nine.FlatStyle = FlatStyle.Flat;
            nine.Font = new Font("Consolas", 15F, FontStyle.Bold);
            nine.ForeColor = SystemColors.ActiveCaptionText;
            nine.Location = new Point(211, 190);
            nine.Name = "nine";
            nine.Size = new Size(90, 90);
            nine.TabIndex = 2;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += OnNumberClick;

            divide.BackColor = Color.NavajoWhite;
            divide.BackgroundImageLayout = ImageLayout.None;
            divide.FlatStyle = FlatStyle.Flat;
            divide.Font = new Font("Consolas", 15F, FontStyle.Bold);
            divide.ForeColor = SystemColors.ActiveCaptionText;
            divide.Location = new Point(311, 190);
            divide.Name = "divide";
            divide.Size = new Size(90, 90);
            divide.TabIndex = 9;
            divide.Text = ":";
            divide.UseVisualStyleBackColor = false;
            divide.Click += OnActionClick;

            multiply.BackColor = Color.NavajoWhite;
            multiply.BackgroundImageLayout = ImageLayout.None;
            multiply.FlatStyle = FlatStyle.Flat;
            multiply.Font = new Font("Consolas", 15F, FontStyle.Bold);
            multiply.ForeColor = SystemColors.ActiveCaptionText;
            multiply.Location = new Point(311, 94);
            multiply.Name = "multiply";
            multiply.Size = new Size(90, 90);
            multiply.TabIndex = 10;
            multiply.Text = "x";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += OnActionClick;

            minus.BackColor = Color.NavajoWhite;
            minus.BackgroundImageLayout = ImageLayout.None;
            minus.FlatStyle = FlatStyle.Flat;
            minus.Font = new Font("Consolas", 15F, FontStyle.Bold);
            minus.ForeColor = SystemColors.ActiveCaptionText;
            minus.Location = new Point(311, 286);
            minus.Name = "minus";
            minus.Size = new Size(90, 90);
            minus.TabIndex = 11;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += OnActionClick;

            plus.BackColor = Color.NavajoWhite;
            plus.BackgroundImageLayout = ImageLayout.None;
            plus.FlatStyle = FlatStyle.Flat;
            plus.Font = new Font("Consolas", 15F, FontStyle.Bold);
            plus.ForeColor = SystemColors.ActiveCaptionText;
            plus.Location = new Point(311, 382);
            plus.Name = "plus";
            plus.Size = new Size(90, 90);
            plus.TabIndex = 12;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += OnActionClick;

            remove.BackColor = Color.White;
            remove.BackgroundImageLayout = ImageLayout.None;
            remove.FlatStyle = FlatStyle.Flat;
            remove.Font = new Font("Consolas", 15F, FontStyle.Bold);
            remove.ForeColor = SystemColors.ActiveCaptionText;
            remove.Location = new Point(211, 478);
            remove.Name = "remove";
            remove.Size = new Size(90, 90);
            remove.TabIndex = 13;
            remove.Text = "<";
            remove.UseVisualStyleBackColor = false;
            remove.Click += OnRemoveClick;
 
            clear.BackColor = Color.White;
            clear.BackgroundImageLayout = ImageLayout.None;
            clear.FlatStyle = FlatStyle.Flat;
            clear.Font = new Font("Consolas", 15F, FontStyle.Bold);
            clear.ForeColor = SystemColors.ActiveCaptionText;
            clear.Location = new Point(11, 478);
            clear.Name = "clear";
            clear.Size = new Size(90, 90);
            clear.TabIndex = 15;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += OnClearClick;

            output.BackColor = SystemColors.Window;
            output.BorderStyle = BorderStyle.None;
            output.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            output.ForeColor = Color.Black;
            output.Location = new Point(11, 12);
            output.MaxLength = 30;
            output.Multiline = false;
            output.Name = "output";
            output.RightToLeft = RightToLeft.No;
            output.Size = new Size(388, 76);
            output.TabIndex = 16;
            output.Text = "0";

            Equals.BackColor = Color.White;
            Equals.BackgroundImageLayout = ImageLayout.None;
            Equals.FlatStyle = FlatStyle.Flat;
            Equals.Font = new Font("Consolas", 15F, FontStyle.Bold);
            Equals.ForeColor = SystemColors.ActiveCaptionText;
            Equals.Location = new Point(311, 478);
            Equals.Name = "Equals";
            Equals.Size = new Size(90, 90);
            Equals.TabIndex = 17;
            Equals.Text = "=";
            Equals.UseVisualStyleBackColor = false;
            Equals.Click += OnEqualsClick;
 
            percent.BackColor = Color.NavajoWhite;
            percent.BackgroundImageLayout = ImageLayout.None;
            percent.FlatStyle = FlatStyle.Flat;
            percent.Font = new Font("Consolas", 15F, FontStyle.Bold);
            percent.ForeColor = SystemColors.ActiveCaptionText;
            percent.Location = new Point(111, 94);
            percent.Name = "percent";
            percent.Size = new Size(90, 90);
            percent.TabIndex = 18;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = false;
            percent.Click += OnActionClick;
 
            power.BackColor = Color.NavajoWhite;
            power.BackgroundImageLayout = ImageLayout.None;
            power.FlatStyle = FlatStyle.Flat;
            power.Font = new Font("Consolas", 15F, FontStyle.Bold);
            power.ForeColor = SystemColors.ActiveCaptionText;
            power.Location = new Point(11, 94);
            power.Name = "power";
            power.Size = new Size(90, 90);
            power.TabIndex = 19;
            power.Text = "^";
            power.UseVisualStyleBackColor = false;
            power.Click += OnActionClick;
    
            sqrt.BackColor = Color.NavajoWhite;
            sqrt.BackgroundImageLayout = ImageLayout.None;
            sqrt.FlatStyle = FlatStyle.Flat;
            sqrt.Font = new Font("Consolas", 15F, FontStyle.Bold);
            sqrt.ForeColor = SystemColors.ActiveCaptionText;
            sqrt.Location = new Point(211, 94);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(90, 90);
            sqrt.TabIndex = 20;
            sqrt.Text = "√";
            sqrt.UseVisualStyleBackColor = false;
            sqrt.Click += OnActionClick;

            AutoScaleDimensions = new SizeF(6F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(410, 575);
            Controls.Add(sqrt);
            Controls.Add(power);
            Controls.Add(percent);
            Controls.Add(Equals);
            Controls.Add(output);
            Controls.Add(clear);
            Controls.Add(zero);
            Controls.Add(remove);
            Controls.Add(plus);
            Controls.Add(minus);
            Controls.Add(multiply);
            Controls.Add(divide);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
        }

        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button multiply;
        private Button divide;
        private Button minus;
        private Button plus;
        private Button zero;
        private Button remove;
        private Button clear;
        private RichTextBox output;
        private Button Equals;
        private Button percent;
        private Button power;
        private Button sqrt;
    }
}
