
namespace производственная_практика
{
    partial class personaladmin
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
            this.data = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.post = new System.Windows.Forms.TextBox();
            this.idsk = new System.Windows.Forms.TextBox();
            this.idseasrch = new System.Windows.Forms.TextBox();
            this.iddel = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.otobraz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.otobraz)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(594, 108);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(100, 20);
            this.data.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(700, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Id работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Удаление и поиск";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Pедактирование";
            // 
            // post
            // 
            this.post.Location = new System.Drawing.Point(594, 82);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(100, 20);
            this.post.TabIndex = 47;
            // 
            // idsk
            // 
            this.idsk.Location = new System.Drawing.Point(594, 56);
            this.idsk.Name = "idsk";
            this.idsk.Size = new System.Drawing.Size(100, 20);
            this.idsk.TabIndex = 46;
            // 
            // idseasrch
            // 
            this.idseasrch.Location = new System.Drawing.Point(594, 345);
            this.idseasrch.Name = "idseasrch";
            this.idseasrch.Size = new System.Drawing.Size(100, 20);
            this.idseasrch.TabIndex = 45;
            // 
            // iddel
            // 
            this.iddel.Location = new System.Drawing.Point(594, 382);
            this.iddel.Name = "iddel";
            this.iddel.Size = new System.Drawing.Size(100, 20);
            this.iddel.TabIndex = 44;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(711, 342);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 43;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(711, 382);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 42;
            this.del.Text = "Удаление";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(711, 420);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 41;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // otobraz
            // 
            this.otobraz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otobraz.Location = new System.Drawing.Point(10, -3);
            this.otobraz.Name = "otobraz";
            this.otobraz.Size = new System.Drawing.Size(575, 456);
            this.otobraz.TabIndex = 40;
            // 
            // personaladmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.post);
            this.Controls.Add(this.idsk);
            this.Controls.Add(this.idseasrch);
            this.Controls.Add(this.iddel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.del);
            this.Controls.Add(this.back);
            this.Controls.Add(this.otobraz);
            this.Name = "personaladmin";
            this.Text = "personaladmin";
            this.Load += new System.EventHandler(this.personaladmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otobraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox post;
        private System.Windows.Forms.TextBox idsk;
        private System.Windows.Forms.TextBox idseasrch;
        private System.Windows.Forms.TextBox iddel;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView otobraz;
    }
}