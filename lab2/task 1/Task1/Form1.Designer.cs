namespace Task1
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
            txtFactorialInput = new TextBox();
            labelFibonacci = new Label();
            lblFactorialResult = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtFactorialInput
            // 
            txtFactorialInput.Location = new Point(210, 109);
            txtFactorialInput.Name = "txtFactorialInput";
            txtFactorialInput.Size = new Size(244, 27);
            txtFactorialInput.TabIndex = 0;
            // 
            // labelFibonacci
            // 
            labelFibonacci.AutoSize = true;
            labelFibonacci.Font = new Font("Swis721 Blk BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFibonacci.ForeColor = Color.Maroon;
            labelFibonacci.Location = new Point(210, 67);
            labelFibonacci.Name = "labelFibonacci";
            labelFibonacci.Size = new Size(205, 21);
            labelFibonacci.TabIndex = 1;
            labelFibonacci.Text = "Factorial Calculator";
            labelFibonacci.Click += label1_Click;
            // 
            // lblFactorialResult
            // 
            lblFactorialResult.AutoSize = true;
            lblFactorialResult.ForeColor = Color.Maroon;
            lblFactorialResult.Location = new Point(210, 167);
            lblFactorialResult.Name = "lblFactorialResult";
            lblFactorialResult.Size = new Size(52, 20);
            lblFactorialResult.TabIndex = 2;
            lblFactorialResult.Text = "Result:";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.Brown;
            btnCalculate.Location = new Point(493, 109);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(126, 29);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblFactorialResult);
            Controls.Add(labelFibonacci);
            Controls.Add(txtFactorialInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFactorialInput;
        private Label labelFibonacci;
        private Label lblFactorialResult;
        private Button btnCalculate;
    }
}
