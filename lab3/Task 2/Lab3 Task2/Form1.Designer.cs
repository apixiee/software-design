namespace Lab3_Task2
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
            lstBooks = new ListBox();
            btnShow = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.Location = new Point(34, 54);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(726, 284);
            lstBooks.TabIndex = 0;
            lstBooks.SelectedIndexChanged += lstBooks_SelectedIndexChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(341, 367);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show ";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 20);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 2;
            label1.Text = "Polymorphism";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnShow);
            Controls.Add(lstBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBooks;
        private Button btnShow;
        private Label label1;
    }
}
