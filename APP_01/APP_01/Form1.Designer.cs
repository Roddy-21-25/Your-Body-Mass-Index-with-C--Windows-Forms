namespace APP_01
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
            txt_1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txt_age = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txt_1
            // 
            txt_1.AutoSize = true;
            txt_1.Location = new System.Drawing.Point(62, 64);
            txt_1.Name = "txt_1";
            txt_1.Size = new System.Drawing.Size(69, 15);
            txt_1.TabIndex = 0;
            txt_1.Text = "Hola Roddy";
            txt_1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(11, 82);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(170, 37);
            button1.TabIndex = 1;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(82, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Edad";
            // 
            // txt_age
            // 
            txt_age.Location = new System.Drawing.Point(11, 33);
            txt_age.Name = "txt_age";
            txt_age.Size = new System.Drawing.Size(170, 23);
            txt_age.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(952, 525);
            Controls.Add(txt_age);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txt_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_age;
    }
}
