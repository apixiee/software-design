namespace Task5._1
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
            listBoxResults = new ListBox();
            btnSort = new Button();
            btnDisplay = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = Color.Bisque;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(354, 108);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(339, 264);
            listBoxResults.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.Peru;
            btnSort.Location = new Point(118, 188);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(134, 47);
            btnSort.TabIndex = 1;
            btnSort.Text = "Bubble Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.Peru;
            btnDisplay.Location = new Point(118, 108);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(134, 45);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display Array";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisplay);
            Controls.Add(btnSort);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnSort;
        private Button btnDisplay;
    }
}
