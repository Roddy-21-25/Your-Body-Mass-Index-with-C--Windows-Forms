namespace APP_01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            weight = new System.Windows.Forms.TextBox();
            tall = new System.Windows.Forms.TextBox();
            result = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            imc_result = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // weight
            // 
            weight.Location = new System.Drawing.Point(265, 43);
            weight.Name = "weight";
            weight.Size = new System.Drawing.Size(225, 23);
            weight.TabIndex = 14;
            // 
            // tall
            // 
            tall.Location = new System.Drawing.Point(265, 99);
            tall.Name = "tall";
            tall.Size = new System.Drawing.Size(225, 23);
            tall.TabIndex = 13;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new System.Drawing.Point(322, 189);
            result.Name = "result";
            result.Size = new System.Drawing.Size(117, 15);
            result.TabIndex = 12;
            result.Text = "Body Mass Index: 0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(322, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 15);
            label3.TabIndex = 11;
            label3.Text = "How tall you are?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(322, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 15);
            label1.TabIndex = 10;
            label1.Text = "Whats your weight?";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(311, 134);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(135, 40);
            button1.TabIndex = 15;
            button1.Text = "Check BMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(497, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(26, 15);
            label2.TabIndex = 16;
            label2.Text = "(M)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(497, 47);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 15);
            label4.TabIndex = 17;
            label4.Text = "(KG)";
            // 
            // imc_result
            // 
            imc_result.AutoSize = true;
            imc_result.Location = new System.Drawing.Point(322, 228);
            imc_result.Name = "imc_result";
            imc_result.Size = new System.Drawing.Size(80, 15);
            imc_result.TabIndex = 18;
            imc_result.Text = "Final Desicion";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(imc_result);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(weight);
            Controls.Add(tall);
            Controls.Add(result);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox tall;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label imc_result;
    }
}