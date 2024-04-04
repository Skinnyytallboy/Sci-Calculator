namespace Scientfic_Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Screen = new System.Windows.Forms.TextBox();
            this.Sign = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Deci = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.HEX = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.Tane = new System.Windows.Forms.Button();
            this.Cose = new System.Windows.Forms.Button();
            this.Sine = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Cut = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Octal = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.Location = new System.Drawing.Point(33, 39);
            this.Screen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.ReadOnly = true;
            this.Screen.Size = new System.Drawing.Size(416, 98);
            this.Screen.TabIndex = 1;
            this.Screen.Text = "0";
            this.Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Sign
            // 
            this.Sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.Location = new System.Drawing.Point(0, 586);
            this.Sign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(100, 62);
            this.Sign.TabIndex = 0;
            this.Sign.Text = "±";
            this.Sign.UseVisualStyleBackColor = false;
            this.Sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(97, 586);
            this.Zero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(100, 62);
            this.Zero.TabIndex = 2;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.Yellow;
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(292, 527);
            this.Equal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(100, 123);
            this.Equal.TabIndex = 4;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Deci
            // 
            this.Deci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Deci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deci.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deci.Location = new System.Drawing.Point(195, 586);
            this.Deci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deci.Name = "Deci";
            this.Deci.Size = new System.Drawing.Size(100, 62);
            this.Deci.TabIndex = 3;
            this.Deci.Text = ".";
            this.Deci.UseVisualStyleBackColor = false;
            this.Deci.Click += new System.EventHandler(this.Deci_Click);
            // 
            // pow
            // 
            this.pow.BackColor = System.Drawing.Color.Teal;
            this.pow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pow.Location = new System.Drawing.Point(389, 586);
            this.pow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(100, 62);
            this.pow.TabIndex = 5;
            this.pow.Text = "pow";
            this.pow.UseVisualStyleBackColor = false;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Teal;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.log.Location = new System.Drawing.Point(389, 527);
            this.log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(100, 62);
            this.log.TabIndex = 10;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(195, 527);
            this.Three.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(100, 62);
            this.Three.TabIndex = 8;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(97, 527);
            this.Two.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(100, 62);
            this.Two.TabIndex = 7;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(0, 527);
            this.One.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(100, 62);
            this.One.TabIndex = 6;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.Color.Teal;
            this.Mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Mult.Location = new System.Drawing.Point(292, 409);
            this.Mult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(100, 62);
            this.Mult.TabIndex = 19;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(195, 409);
            this.Nine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(100, 62);
            this.Nine.TabIndex = 18;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(97, 409);
            this.Eight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(100, 62);
            this.Eight.TabIndex = 17;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(0, 409);
            this.Seven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(100, 62);
            this.Seven.TabIndex = 16;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Factorial
            // 
            this.Factorial.BackColor = System.Drawing.Color.Teal;
            this.Factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Factorial.Location = new System.Drawing.Point(389, 468);
            this.Factorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(100, 62);
            this.Factorial.TabIndex = 15;
            this.Factorial.Text = "n!";
            this.Factorial.UseVisualStyleBackColor = false;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Teal;
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Divide.Location = new System.Drawing.Point(292, 468);
            this.Divide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(100, 62);
            this.Divide.TabIndex = 14;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(195, 468);
            this.Six.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(100, 62);
            this.Six.TabIndex = 13;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(97, 468);
            this.Five.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(100, 62);
            this.Five.TabIndex = 12;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(0, 468);
            this.Four.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(100, 62);
            this.Four.TabIndex = 11;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // HEX
            // 
            this.HEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEX.Location = new System.Drawing.Point(389, 231);
            this.HEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HEX.Name = "HEX";
            this.HEX.Size = new System.Drawing.Size(100, 62);
            this.HEX.TabIndex = 35;
            this.HEX.Text = "HEX";
            this.HEX.UseVisualStyleBackColor = false;
            this.HEX.Click += new System.EventHandler(this.HEX_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(195, 231);
            this.button28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(100, 62);
            this.button28.TabIndex = 33;
            this.button28.Text = "tanh";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(97, 231);
            this.button29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(100, 62);
            this.button29.TabIndex = 32;
            this.button29.Text = "cosh";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(0, 231);
            this.button30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(100, 62);
            this.button30.TabIndex = 31;
            this.button30.Text = "sinh";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // Tane
            // 
            this.Tane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Tane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tane.Location = new System.Drawing.Point(194, 290);
            this.Tane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tane.Name = "Tane";
            this.Tane.Size = new System.Drawing.Size(100, 62);
            this.Tane.TabIndex = 29;
            this.Tane.Text = "tan";
            this.Tane.UseVisualStyleBackColor = false;
            this.Tane.Click += new System.EventHandler(this.Tane_Click);
            // 
            // Cose
            // 
            this.Cose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Cose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cose.Location = new System.Drawing.Point(97, 290);
            this.Cose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cose.Name = "Cose";
            this.Cose.Size = new System.Drawing.Size(100, 62);
            this.Cose.TabIndex = 28;
            this.Cose.Text = "cos";
            this.Cose.UseVisualStyleBackColor = false;
            this.Cose.Click += new System.EventHandler(this.Cose_Click);
            // 
            // Sine
            // 
            this.Sine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Sine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sine.Location = new System.Drawing.Point(-1, 290);
            this.Sine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sine.Name = "Sine";
            this.Sine.Size = new System.Drawing.Size(100, 62);
            this.Sine.TabIndex = 27;
            this.Sine.Text = "sin";
            this.Sine.UseVisualStyleBackColor = false;
            this.Sine.Click += new System.EventHandler(this.Sine_Click);
            // 
            // Mod
            // 
            this.Mod.BackColor = System.Drawing.Color.Teal;
            this.Mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Mod.Location = new System.Drawing.Point(292, 290);
            this.Mod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(100, 62);
            this.Mod.TabIndex = 26;
            this.Mod.Text = "%";
            this.Mod.UseVisualStyleBackColor = false;
            this.Mod.Click += new System.EventHandler(this.Mod_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.Teal;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Plus.Location = new System.Drawing.Point(292, 350);
            this.Plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(100, 62);
            this.Plus.TabIndex = 24;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.Color.Teal;
            this.Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Subtract.Location = new System.Drawing.Point(195, 350);
            this.Subtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(100, 62);
            this.Subtract.TabIndex = 23;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(97, 350);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 62);
            this.Clear.TabIndex = 22;
            this.Clear.Text = "CE";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Cut
            // 
            this.Cut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cut.Location = new System.Drawing.Point(0, 350);
            this.Cut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(100, 62);
            this.Cut.TabIndex = 21;
            this.Cut.Text = "⌫";
            this.Cut.UseVisualStyleBackColor = false;
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.Color.Teal;
            this.Sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sqrt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sqrt.Location = new System.Drawing.Point(292, 231);
            this.Sqrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(100, 62);
            this.Sqrt.TabIndex = 34;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Octal
            // 
            this.Octal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Octal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Octal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Octal.Location = new System.Drawing.Point(389, 290);
            this.Octal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Octal.Name = "Octal";
            this.Octal.Size = new System.Drawing.Size(100, 62);
            this.Octal.TabIndex = 36;
            this.Octal.Text = "Octal";
            this.Octal.UseVisualStyleBackColor = false;
            this.Octal.Click += new System.EventHandler(this.Octal_Click);
            // 
            // Binary
            // 
            this.Binary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Binary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Binary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binary.Location = new System.Drawing.Point(389, 409);
            this.Binary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(100, 62);
            this.Binary.TabIndex = 38;
            this.Binary.Text = "Binary";
            this.Binary.UseVisualStyleBackColor = false;
            this.Binary.Click += new System.EventHandler(this.Binary_Click);
            // 
            // Decimal
            // 
            this.Decimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Decimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.Location = new System.Drawing.Point(389, 350);
            this.Decimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(100, 62);
            this.Decimal.TabIndex = 37;
            this.Decimal.Text = "Decimal";
            this.Decimal.UseVisualStyleBackColor = false;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(489, 646);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Octal);
            this.Controls.Add(this.HEX);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.Tane);
            this.Controls.Add(this.Cose);
            this.Controls.Add(this.Sine);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Cut);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Deci);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.Sign);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator";
            this.Text = "Scientific Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button Sign;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Deci;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button HEX;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button Tane;
        private System.Windows.Forms.Button Cose;
        private System.Windows.Forms.Button Sine;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Cut;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Octal;
        private System.Windows.Forms.Button Binary;
        private System.Windows.Forms.Button Decimal;
    }
}

