
namespace производственная_практика
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.avtlog = new System.Windows.Forms.TextBox();
            this.avtpas = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.zareg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.singup = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // avtlog
            // 
            this.avtlog.Location = new System.Drawing.Point(206, 154);
            this.avtlog.Name = "avtlog";
            this.avtlog.Size = new System.Drawing.Size(144, 20);
            this.avtlog.TabIndex = 0;
            // 
            // avtpas
            // 
            this.avtpas.Location = new System.Drawing.Point(206, 202);
            this.avtpas.Name = "avtpas";
            this.avtpas.Size = new System.Drawing.Size(144, 20);
            this.avtpas.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 97);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(126, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // zareg
            // 
            this.zareg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zareg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zareg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zareg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zareg.Location = new System.Drawing.Point(120, 310);
            this.zareg.Name = "zareg";
            this.zareg.Size = new System.Drawing.Size(195, 33);
            this.zareg.TabIndex = 7;
            this.zareg.Text = "Зарегистрироваться ";
            this.zareg.UseVisualStyleBackColor = false;
            this.zareg.Click += new System.EventHandler(this.zareg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(79, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите логин:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(71, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите пароль:";
            // 
            // singup
            // 
            this.singup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.singup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singup.Location = new System.Drawing.Point(120, 271);
            this.singup.Name = "singup";
            this.singup.Size = new System.Drawing.Size(195, 33);
            this.singup.TabIndex = 6;
            this.singup.Text = "Войти";
            this.singup.UseVisualStyleBackColor = false;
            this.singup.Click += new System.EventHandler(this.singup_Click);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admin.Location = new System.Drawing.Point(120, 349);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(195, 33);
            this.admin.TabIndex = 8;
            this.admin.Text = "Я администратор";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(426, 407);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.zareg);
            this.Controls.Add(this.singup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.avtpas);
            this.Controls.Add(this.avtlog);
            this.MaximumSize = new System.Drawing.Size(442, 446);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox avtlog;
        private System.Windows.Forms.TextBox avtpas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button singup;
        private System.Windows.Forms.Button zareg;
        private System.Windows.Forms.Button admin;
    }
}

