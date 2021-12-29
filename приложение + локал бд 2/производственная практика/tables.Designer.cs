
namespace производственная_практика
{
    partial class tables
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
            this.inventary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.otcity = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inventary
            // 
            this.inventary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventary.Location = new System.Drawing.Point(135, 117);
            this.inventary.Name = "inventary";
            this.inventary.Size = new System.Drawing.Size(131, 35);
            this.inventary.TabIndex = 1;
            this.inventary.Text = "Инвентарь";
            this.inventary.UseVisualStyleBackColor = true;
            this.inventary.Click += new System.EventHandler(this.inventary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(130, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Меню таблиц";
            // 
            // otcity
            // 
            this.otcity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otcity.Location = new System.Drawing.Point(135, 176);
            this.otcity.Name = "otcity";
            this.otcity.Size = new System.Drawing.Size(131, 35);
            this.otcity.TabIndex = 3;
            this.otcity.Text = "Отчёты";
            this.otcity.UseVisualStyleBackColor = true;
            this.otcity.Click += new System.EventHandler(this.otcity_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(135, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Склады";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(425, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.otcity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inventary);
            this.MaximumSize = new System.Drawing.Size(441, 412);
            this.MinimumSize = new System.Drawing.Size(441, 412);
            this.Name = "tables";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button inventary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button otcity;
        private System.Windows.Forms.Button button1;
    }
}