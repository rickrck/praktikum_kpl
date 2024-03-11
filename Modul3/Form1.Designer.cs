namespace Modul3
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
            label1 = new Label();
            btnSubmit = new Button();
            labelNama = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(365, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            label1.Click += label1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(499, 45);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(112, 111);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(0, 20);
            labelNama.TabIndex = 3;
            labelNama.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 231);
            Controls.Add(labelNama);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Button btnSubmit;
        private Label labelNama;
    }
}
