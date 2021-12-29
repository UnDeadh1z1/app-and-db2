
namespace производственная_практика
{
    partial class adminotch
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
            this.otobraz = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.iddel = new System.Windows.Forms.TextBox();
            this.idseasrch = new System.Windows.Forms.TextBox();
            this.idsk = new System.Windows.Forms.TextBox();
            this.post = new System.Windows.Forms.TextBox();
            this.nomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.otobraz)).BeginInit();
            this.SuspendLayout();
            // 
            // otobraz
            // 
            this.otobraz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otobraz.Location = new System.Drawing.Point(12, -8);
            this.otobraz.Name = "otobraz";
            this.otobraz.Size = new System.Drawing.Size(575, 456);
            this.otobraz.TabIndex = 0;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(713, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(713, 377);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 2;
            this.del.Text = "Удаление";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(713, 337);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // iddel
            // 
            this.iddel.Location = new System.Drawing.Point(596, 377);
            this.iddel.Name = "iddel";
            this.iddel.Size = new System.Drawing.Size(100, 20);
            this.iddel.TabIndex = 4;
            // 
            // idseasrch
            // 
            this.idseasrch.Location = new System.Drawing.Point(596, 340);
            this.idseasrch.Name = "idseasrch";
            this.idseasrch.Size = new System.Drawing.Size(100, 20);
            this.idseasrch.TabIndex = 5;
            // 
            // idsk
            // 
            this.idsk.Location = new System.Drawing.Point(596, 51);
            this.idsk.Name = "idsk";
            this.idsk.Size = new System.Drawing.Size(100, 20);
            this.idsk.TabIndex = 6;
            // 
            // post
            // 
            this.post.Location = new System.Drawing.Point(596, 77);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(100, 20);
            this.post.TabIndex = 7;
            // 
            // nomer
            // 
            this.nomer.Location = new System.Drawing.Point(596, 129);
            this.nomer.Name = "nomer";
            this.nomer.Size = new System.Drawing.Size(100, 20);
            this.nomer.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Добавление и редактирование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Удаление и поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Id склада";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Поставшик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата поставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Номер поставки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(596, 104);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(100, 20);
            this.data.TabIndex = 21;
            // 
            // adminotch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomer);
            this.Controls.Add(this.post);
            this.Controls.Add(this.idsk);
            this.Controls.Add(this.idseasrch);
            this.Controls.Add(this.iddel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.del);
            this.Controls.Add(this.back);
            this.Controls.Add(this.otobraz);
            this.Name = "adminotch";
            this.Text = "adminotch";
            this.Load += new System.EventHandler(this.adminotch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otobraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView otobraz;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox iddel;
        private System.Windows.Forms.TextBox idseasrch;
        private System.Windows.Forms.TextBox idsk;
        private System.Windows.Forms.TextBox post;
        private System.Windows.Forms.TextBox nomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker data;
    }
}