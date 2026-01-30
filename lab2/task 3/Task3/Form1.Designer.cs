namespace Task3
{
    partial class Form1
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
            txtFibonacciInput = new TextBox();
            label1 = new Label();
            lblFibonacciResult = new Label();
            btnFibonacci = new Button();
            SuspendLayout();
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(224, 97);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(192, 27);
            txtFibonacciInput.TabIndex = 0;
            txtFibonacciInput.Text = "5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Swis721 Blk BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(224, 61);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 1;
            label1.Text = "Recursive Fibonacci";
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.BackColor = Color.RosyBrown;
            lblFibonacciResult.ForeColor = Color.Maroon;
            lblFibonacciResult.Location = new Point(224, 150);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(58, 20);
            lblFibonacciResult.TabIndex = 2;
            lblFibonacciResult.Text = "Results:";
            // 
            // btnFibonacci
            // 
            btnFibonacci.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFibonacci.ForeColor = Color.DarkRed;
            btnFibonacci.Location = new Point(453, 97);
            btnFibonacci.Name = "btnFibonacci";
            btnFibonacci.Size = new Size(121, 29);
            btnFibonacci.TabIndex = 3;
            btnFibonacci.Text = "Calculate";
            btnFibonacci.UseVisualStyleBackColor = true;
            btnFibonacci.Click += btnFibonacci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFibonacci);
            Controls.Add(lblFibonacciResult);
            Controls.Add(label1);
            Controls.Add(txtFibonacciInput);
            ForeColor = SystemColors.ControlDark;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFibonacciInput;
        private Label label1;
        private Label lblFibonacciResult;
        private Button btnFibonacci;
    }
}
