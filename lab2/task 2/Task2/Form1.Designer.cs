namespace Task2
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
            txtArrayInput = new TextBox();
            label1 = new Label();
            lblSumResult = new Label();
            btnFibonacci = new Button();
            SuspendLayout();
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(213, 113);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(208, 27);
            txtArrayInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(213, 76);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 1;
            label1.Text = "Sum Calculator";
            label1.Click += label1_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.ForeColor = SystemColors.ButtonFace;
            lblSumResult.Location = new Point(213, 162);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(58, 20);
            lblSumResult.TabIndex = 2;
            lblSumResult.Text = "Results:";
            // 
            // btnFibonacci
            // 
            btnFibonacci.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFibonacci.ForeColor = SystemColors.HotTrack;
            btnFibonacci.Location = new Point(470, 113);
            btnFibonacci.Name = "btnFibonacci";
            btnFibonacci.Size = new Size(132, 27);
            btnFibonacci.TabIndex = 3;
            btnFibonacci.Text = "Calculate";
            btnFibonacci.UseVisualStyleBackColor = true;
            btnFibonacci.Click += btnCalculateSum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFibonacci);
            Controls.Add(lblSumResult);
            Controls.Add(label1);
            Controls.Add(txtArrayInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArrayInput;
        private Label label1;
        private Label lblSumResult;
        private Button btnFibonacci;
    }
}
