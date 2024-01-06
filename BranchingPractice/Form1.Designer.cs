namespace BranchingPractice
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
            txtName = new TextBox();
            btnDisplayGreeting = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(75, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // btnDisplayGreeting
            // 
            btnDisplayGreeting.Location = new Point(75, 170);
            btnDisplayGreeting.Name = "btnDisplayGreeting";
            btnDisplayGreeting.Size = new Size(125, 81);
            btnDisplayGreeting.TabIndex = 1;
            btnDisplayGreeting.Text = "Display Greeting";
            btnDisplayGreeting.UseVisualStyleBackColor = true;
            btnDisplayGreeting.Click += BtnDisplayGreeting_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 425);
            Controls.Add(btnDisplayGreeting);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Branching Practice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btnDisplayGreeting;
    }
}