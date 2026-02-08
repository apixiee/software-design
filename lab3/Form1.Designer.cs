namespace lab3
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtIssueNumber = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            label1 = new Label();
            btnShowInfo = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIssueNumber);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Location = new Point(21, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 72);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 5;
            label4.Text = "Issue Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 72);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // txtIssueNumber
            // 
            txtIssueNumber.Location = new Point(559, 65);
            txtIssueNumber.Name = "txtIssueNumber";
            txtIssueNumber.Size = new Size(125, 27);
            txtIssueNumber.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(297, 65);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(55, 65);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(147, 27);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 44);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "BookStore System";
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(335, 263);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(94, 29);
            btnShowInfo.TabIndex = 2;
            btnShowInfo.Text = "Show";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowInfo);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnShowInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtIssueNumber;
        private TextBox txtAuthor;
        private TextBox txtTitle;
    }
}
