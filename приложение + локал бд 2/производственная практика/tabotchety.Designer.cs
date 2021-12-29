
namespace производственная_практика
{
    partial class tabotchety
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
            ((System.ComponentModel.ISupportInitialize)(this.otobraz)).BeginInit();
            this.SuspendLayout();
            // 
            // otobraz
            // 
            this.otobraz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otobraz.Location = new System.Drawing.Point(1, -2);
            this.otobraz.Name = "otobraz";
            this.otobraz.Size = new System.Drawing.Size(800, 418);
            this.otobraz.TabIndex = 1;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(713, 422);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tabotchety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.otobraz);
            this.Name = "tabotchety";
            this.Text = "tabotchety";
            this.Load += new System.EventHandler(this.tabotchety_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.otobraz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView otobraz;
        private System.Windows.Forms.Button back;
    }
}