namespace Calculator
{
    partial class EngineerCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngineerCalculator));
            minus = new Button();
            plus = new Button();
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
            remove = new Button();
            zero = new Button();
            clear = new Button();
            output = new RichTextBox();
            equals = new Button();
            percent = new Button();
            power = new Button();
            sqrt = new Button();
            dot = new Button();
            cotan = new Button();
            tan = new Button();
            cos = new Button();
            sin = new Button();
            exponent = new Button();
            pi = new Button();
            logarifm = new Button();
            radian = new Button();
            factorial = new Button();
            nlogarifn = new Button();
            mod = new Button();
            SuspendLayout();
            
            minus.BackColor = Color.NavajoWhite;
            resources.ApplyResources(minus, "minus");
            minus.ForeColor = SystemColors.ActiveCaptionText;
            minus.Name = "minus";
            minus.UseVisualStyleBackColor = false;
            minus.Click += OnActionClick;
            
            plus.BackColor = Color.NavajoWhite;
            resources.ApplyResources(plus, "plus");
            plus.ForeColor = SystemColors.ActiveCaptionText;
            plus.Name = "plus";
            plus.UseVisualStyleBackColor = false;
            plus.Click += OnActionClick;
          
            seven.BackColor = Color.Blue;
            resources.ApplyResources(seven, "seven");
            seven.ForeColor = SystemColors.ActiveCaptionText;
            seven.Name = "seven";
            seven.UseVisualStyleBackColor = false;
            seven.Click += OnNumberClick;
          
            eight.BackColor = Color.Blue;
            resources.ApplyResources(eight, "eight");
            eight.ForeColor = SystemColors.ActiveCaptionText;
            eight.Name = "eight";
            eight.UseVisualStyleBackColor = false;
            eight.Click += OnNumberClick;
            
            nine.BackColor = Color.Blue;
            resources.ApplyResources(nine, "nine");
            nine.ForeColor = SystemColors.ActiveCaptionText;
            nine.Name = "nine";
            nine.UseVisualStyleBackColor = false;
            nine.Click += OnNumberClick;
           
            four.BackColor = Color.Blue;
            resources.ApplyResources(four, "four");
            four.ForeColor = SystemColors.ActiveCaptionText;
            four.Name = "four";
            four.UseVisualStyleBackColor = false;
            four.Click += OnNumberClick;
          
            five.BackColor = Color.Blue;
            resources.ApplyResources(five, "five");
            five.ForeColor = SystemColors.ActiveCaptionText;
            five.Name = "five";
            five.UseVisualStyleBackColor = false;
            five.Click += OnNumberClick;
             
            six.BackColor = Color.Blue;
            resources.ApplyResources(six, "six");
            six.ForeColor = SystemColors.ActiveCaptionText;
            six.Name = "six";
            six.UseVisualStyleBackColor = false;
            six.Click += OnNumberClick;
            
            one.BackColor = Color.Blue;
            resources.ApplyResources(one, "one");
            one.ForeColor = SystemColors.ActiveCaptionText;
            one.Name = "one";
            one.UseVisualStyleBackColor = false;
            one.Click += OnNumberClick;
           
            two.BackColor = Color.Blue;
            resources.ApplyResources(two, "two");
            two.ForeColor = SystemColors.ActiveCaptionText;
            two.Name = "two";
            two.UseVisualStyleBackColor = false;
            two.Click += OnNumberClick;
          
            three.BackColor = Color.Blue;
            resources.ApplyResources(three, "three");
            three.ForeColor = SystemColors.ActiveCaptionText;
            three.Name = "three";
            three.UseVisualStyleBackColor = false;
            three.Click += OnNumberClick;
            
            divide.BackColor = Color.NavajoWhite;
            resources.ApplyResources(divide, "divide");
            divide.ForeColor = SystemColors.ActiveCaptionText;
            divide.Name = "divide";
            divide.UseVisualStyleBackColor = false;
            divide.Click += OnActionClick;
           
            multiply.BackColor = Color.NavajoWhite;
            resources.ApplyResources(multiply, "multiply");
            multiply.ForeColor = SystemColors.ActiveCaptionText;
            multiply.Name = "multiply";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += OnActionClick;
        
            remove.BackColor = Color.White;
            resources.ApplyResources(remove, "remove");
            remove.ForeColor = SystemColors.ActiveCaptionText;
            remove.Name = "remove";
            remove.UseVisualStyleBackColor = false;
            remove.Click += OnRemoveClick;
        
            zero.BackColor = Color.Blue;
            resources.ApplyResources(zero, "zero");
            zero.ForeColor = SystemColors.ActiveCaptionText;
            zero.Name = "zero";
            zero.UseVisualStyleBackColor = false;
            zero.Click += OnNumberClick;
         
            clear.BackColor = Color.White;
            resources.ApplyResources(clear, "clear");
            clear.ForeColor = SystemColors.ActiveCaptionText;
            clear.Name = "clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += OnClearClick;
            
            output.BackColor = SystemColors.Window;
            output.BorderStyle = BorderStyle.None;
            resources.ApplyResources(output, "output");
            output.ForeColor = Color.Black;
            output.Name = "output";
           
            equals.BackColor = Color.White;
            resources.ApplyResources(equals, "equals");
            equals.ForeColor = SystemColors.ActiveCaptionText;
            equals.Name = "equals";
            equals.UseVisualStyleBackColor = false;
            equals.Click += OnequalsClick;
            
            percent.BackColor = Color.NavajoWhite;
            resources.ApplyResources(percent, "percent");
            percent.ForeColor = SystemColors.ActiveCaptionText;
            percent.Name = "percent";
            percent.UseVisualStyleBackColor = false;
            percent.Click += OnActionClick;
           
            power.BackColor = Color.NavajoWhite;
            resources.ApplyResources(power, "power");
            power.ForeColor = SystemColors.ActiveCaptionText;
            power.Name = "power";
            power.UseVisualStyleBackColor = false;
            power.Click += OnActionClick;
            
            sqrt.BackColor = Color.NavajoWhite;
            resources.ApplyResources(sqrt, "sqrt");
            sqrt.ForeColor = SystemColors.ActiveCaptionText;
            sqrt.Name = "sqrt";
            sqrt.UseVisualStyleBackColor = false;
            sqrt.Click += OnActionClick;
            
            dot.BackColor = Color.Salmon;
            resources.ApplyResources(dot, "dot");
            dot.ForeColor = SystemColors.ActiveCaptionText;
            dot.Name = "dot";
            dot.UseVisualStyleBackColor = false;
            dot.Click += OnNumberClick;
            
            cotan.BackColor = Color.Salmon;
            resources.ApplyResources(cotan, "cotan");
            cotan.ForeColor = SystemColors.ActiveCaptionText;
            cotan.Name = "cotan";
            cotan.UseVisualStyleBackColor = false;
            cotan.Click += OnActionClick;
         
            tan.BackColor = Color.Salmon;
            resources.ApplyResources(tan, "tan");
            tan.ForeColor = SystemColors.ActiveCaptionText;
            tan.Name = "tan";
            tan.UseVisualStyleBackColor = false;
            tan.Click += OnActionClick;
           
            cos.BackColor = Color.Salmon;
            resources.ApplyResources(cos, "cos");
            cos.ForeColor = SystemColors.ActiveCaptionText;
            cos.Name = "cos";
            cos.UseVisualStyleBackColor = false;
            cos.Click += OnActionClick;
           
            sin.BackColor = Color.Salmon;
            resources.ApplyResources(sin, "sin");
            sin.ForeColor = SystemColors.ActiveCaptionText;
            sin.Name = "sin";
            sin.UseVisualStyleBackColor = false;
            sin.Click += OnActionClick;
          
            exponent.BackColor = Color.Salmon;
            resources.ApplyResources(exponent, "exponent");
            exponent.ForeColor = SystemColors.ActiveCaptionText;
            exponent.Name = "exponent";
            exponent.UseVisualStyleBackColor = false;
            exponent.Click += OnNumberClick;
           
            pi.BackColor = Color.Salmon;
            resources.ApplyResources(pi, "pi");
            pi.ForeColor = SystemColors.ActiveCaptionText;
            pi.Name = "pi";
            pi.UseVisualStyleBackColor = false;
            pi.Click += OnNumberClick;
            
            logarifm.BackColor = Color.Salmon;
            resources.ApplyResources(logarifm, "logarifm");
            logarifm.ForeColor = SystemColors.ActiveCaptionText;
            logarifm.Name = "logarifm";
            logarifm.UseVisualStyleBackColor = false;
            logarifm.Click += OnActionClick;
            
            radian.BackColor = Color.Salmon;
            resources.ApplyResources(radian, "radian");
            radian.ForeColor = SystemColors.ActiveCaptionText;
            radian.Name = "radian";
            radian.UseVisualStyleBackColor = false;
            radian.Click += OnActionClick;
            
            factorial.BackColor = Color.Salmon;
            resources.ApplyResources(factorial, "factorial");
            factorial.ForeColor = SystemColors.ActiveCaptionText;
            factorial.Name = "factorial";
            factorial.UseVisualStyleBackColor = false;
            factorial.Click += OnActionClick;
            
            nlogarifn.BackColor = Color.Salmon;
            resources.ApplyResources(nlogarifn, "nlogarifn");
            nlogarifn.ForeColor = SystemColors.ActiveCaptionText;
            nlogarifn.Name = "nlogarifn";
            nlogarifn.UseVisualStyleBackColor = false;
            nlogarifn.Click += OnActionClick;
            
            mod.BackColor = Color.Salmon;
            resources.ApplyResources(mod, "mod");
            mod.ForeColor = SystemColors.ActiveCaptionText;
            mod.Name = "mod";
            mod.UseVisualStyleBackColor = false;
            mod.Click += OnActionClick;
           
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            Controls.Add(mod);
            Controls.Add(nlogarifn);
            Controls.Add(factorial);
            Controls.Add(radian);
            Controls.Add(logarifm);
            Controls.Add(pi);
            Controls.Add(exponent);
            Controls.Add(sin);
            Controls.Add(cos);
            Controls.Add(tan);
            Controls.Add(remove);
            Controls.Add(plus);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(minus);
            Controls.Add(multiply);
            Controls.Add(divide);
            Controls.Add(cotan);
            Controls.Add(dot);
            Controls.Add(sqrt);
            Controls.Add(power);
            Controls.Add(percent);
            Controls.Add(equals);
            Controls.Add(output);
            Controls.Add(clear);
            Controls.Add(zero);
            Controls.Add(three);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EngineerCalculator";
            ShowIcon = false;
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
        private Button divide;
        private Button multiply;
        private Button minus;
        private Button plus;
        private Button remove;
        private Button zero;
        private Button clear;
        private RichTextBox output;
        private Button equals;
        private Button percent;
        private Button power;
        private Button sqrt;
        private Button dot;
        private Button cotan;
        private Button tan;
        private Button cos;
        private Button sin;
        private Button exponent;
        private Button pi;
        private Button logarifm;
        private Button radian;
        private Button factorial;
        private Button nlogarifn;
        private Button mod;
    }
}
