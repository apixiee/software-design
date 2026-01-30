namespace task4
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
            txtBase = new TextBox();
            label1 = new Label();
            lblPowerResult = new Label();
            btnPower = new Button();
            txtExponent = new TextBox();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Location = new Point(222, 114);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(117, 27);
            txtBase.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(222, 72);
            label1.Name = "label1";
            label1.Size = new Size(210, 21);
            label1.TabIndex = 1;
            label1.Text = "Exponent Calculator";
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.ForeColor = Color.DarkRed;
            lblPowerResult.Location = new Point(222, 164);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(58, 20);
            lblPowerResult.TabIndex = 2;
            lblPowerResult.Text = "Results:";
            // 
            // btnPower
            // 
            btnPower.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPower.ForeColor = SystemColors.GrayText;
            btnPower.Location = new Point(503, 112);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(120, 29);
            btnPower.TabIndex = 3;
            btnPower.Text = "Calculate";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnPower_Click;
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(372, 114);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(104, 27);
            txtExponent.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtExponent);
            Controls.Add(btnPower);
            Controls.Add(lblPowerResult);
            Controls.Add(label1);
            Controls.Add(txtBase);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBase;
        private Label label1;
        private Label lblPowerResult;
        private Button btnPower;
        private TextBox txtExponent;
    }
}
