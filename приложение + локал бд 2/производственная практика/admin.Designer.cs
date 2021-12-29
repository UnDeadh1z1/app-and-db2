
namespace производственная_практика
{
    partial class admin
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
            this.label3 = new System.Windows.Forms.Label();
            this.inventary = new System.Windows.Forms.Button();
            this.personal = new System.Windows.Forms.Button();
            this.sklady = new System.Windows.Forms.Button();
            this.otchety = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(126, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Администрование таблиц";
            // 
            // inventary
            // 
            this.inventary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventary.Location = new System.Drawing.Point(167, 117);
            this.inventary.Name = "inventary";
            this.inventary.Size = new System.Drawing.Size(131, 35);
            this.inventary.TabIndex = 7;
            this.inventary.Text = "Инвентарь";
            this.inventary.UseVisualStyleBackColor = true;
            this.inventary.Click += new System.EventHandler(this.inventary_Click);
            // 
            // personal
            // 
            this.personal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personal.Location = new System.Drawing.Point(167, 183);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(131, 35);
            this.personal.TabIndex = 8;
            this.personal.Text = "Персонал";
            this.personal.UseVisualStyleBackColor = true;
            this.personal.Click += new System.EventHandler(this.personal_Click);
            // 
            // sklady
            // 
            this.sklady.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sklady.Location = new System.Drawing.Point(167, 249);
            this.sklady.Name = "sklady";
            this.sklady.Size = new System.Drawing.Size(131, 35);
            this.sklady.TabIndex = 9;
            this.sklady.Text = "Склады";
            this.sklady.UseVisualStyleBackColor = true;
            this.sklady.Click += new System.EventHandler(this.sklady_Click);
            // 
            // otchety
            // 
            this.otchety.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchety.Location = new System.Drawing.Point(130, 320);
            this.otchety.Name = "otchety";
            this.otchety.Size = new System.Drawing.Size(221, 35);
            this.otchety.TabIndex = 10;
            this.otchety.Text = "Отчёты по поставкам";
            this.otchety.UseVisualStyleBackColor = true;
            this.otchety.Click += new System.EventHandler(this.otchety_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(331, 423);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 35);
            this.back.TabIndex = 12;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(474, 470);
            this.Controls.Add(this.back);
            this.Controls.Add(this.otchety);
            this.Controls.Add(this.sklady);
            this.Controls.Add(this.personal);
            this.Controls.Add(this.inventary);
            this.Controls.Add(this.label3);
            this.Name = "admin";
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inventary;
        private System.Windows.Forms.Button personal;
        private System.Windows.Forms.Button sklady;
        private System.Windows.Forms.Button otchety;
        private System.Windows.Forms.Button back;
    }
}