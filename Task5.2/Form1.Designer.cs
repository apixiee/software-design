namespace Task5._2
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
            btnDisplay = new Button();
            btnSort = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = Color.CadetBlue;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(290, 92);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(422, 264);
            listBoxResults.TabIndex = 0;
            listBoxResults.SelectedIndexChanged += listBoxResults_SelectedIndexChanged;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.SeaGreen;
            btnDisplay.ForeColor = SystemColors.ButtonHighlight;
            btnDisplay.Location = new Point(81, 92);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(149, 43);
            btnDisplay.TabIndex = 1;
            btnDisplay.Text = "Display Array";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.SeaGreen;
            btnSort.ForeColor = SystemColors.ButtonHighlight;
            btnSort.Location = new Point(81, 169);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(149, 43);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sorted Array";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // button1
            // 
            button1.Location = new Point(236, 138);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnSort);
            Controls.Add(btnDisplay);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "OOP";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnDisplay;
        private Button btnSort;
        private Button button1;
    }
}
