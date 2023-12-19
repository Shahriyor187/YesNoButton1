namespace YesNoButton1
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
            Yes_btn = new Button();
            No_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Yes_btn
            // 
            Yes_btn.Location = new Point(253, 284);
            Yes_btn.Name = "Yes_btn";
            Yes_btn.Size = new Size(94, 43);
            Yes_btn.TabIndex = 0;
            Yes_btn.Text = "Yes";
            Yes_btn.UseVisualStyleBackColor = true;
            Yes_btn.Click += button1_Click;
            // 
            // No_btn
            // 
            No_btn.Location = new Point(58, 284);
            No_btn.Name = "No_btn";
            No_btn.Size = new Size(94, 43);
            No_btn.TabIndex = 1;
            No_btn.Text = "No";
            No_btn.UseVisualStyleBackColor = true;
            No_btn.Click += No_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 75);
            label1.Name = "label1";
            label1.Size = new Size(219, 38);
            label1.TabIndex = 2;
            label1.Text = "Are you stupid ?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 383);
            Controls.Add(label1);
            Controls.Add(No_btn);
            Controls.Add(Yes_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Yes_btn;
        private Button No_btn;
        private Label label1;
    }
}
