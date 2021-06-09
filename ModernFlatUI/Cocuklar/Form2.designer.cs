namespace Deneme
{
    partial class Yönetici
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menüBar = new System.Windows.Forms.Button();
            this.mb1 = new System.Windows.Forms.Button();
            this.mb2 = new System.Windows.Forms.Button();
            this.mb3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Personel İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ürün İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanımda Olan Araçlar";
            // 
            // menüBar
            // 
            this.menüBar.Location = new System.Drawing.Point(267, 93);
            this.menüBar.Name = "menüBar";
            this.menüBar.Size = new System.Drawing.Size(210, 44);
            this.menüBar.TabIndex = 3;
            this.menüBar.Text = "button3";
            this.menüBar.UseVisualStyleBackColor = true;
            this.menüBar.Click += new System.EventHandler(this.menüBar_Click);
            // 
            // mb1
            // 
            this.mb1.Location = new System.Drawing.Point(267, 134);
            this.mb1.Name = "mb1";
            this.mb1.Size = new System.Drawing.Size(210, 44);
            this.mb1.TabIndex = 4;
            this.mb1.Text = "button4";
            this.mb1.UseVisualStyleBackColor = true;
            // 
            // mb2
            // 
            this.mb2.Location = new System.Drawing.Point(267, 174);
            this.mb2.Name = "mb2";
            this.mb2.Size = new System.Drawing.Size(210, 44);
            this.mb2.TabIndex = 5;
            this.mb2.Text = "button5";
            this.mb2.UseVisualStyleBackColor = true;
            // 
            // mb3
            // 
            this.mb3.Location = new System.Drawing.Point(267, 212);
            this.mb3.Name = "mb3";
            this.mb3.Size = new System.Drawing.Size(210, 44);
            this.mb3.TabIndex = 6;
            this.mb3.Text = "button6";
            this.mb3.UseVisualStyleBackColor = true;
            // 
            // Yönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mb3);
            this.Controls.Add(this.mb2);
            this.Controls.Add(this.mb1);
            this.Controls.Add(this.menüBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Yönetici";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Yönetici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menüBar;
        private System.Windows.Forms.Button mb1;
        private System.Windows.Forms.Button mb2;
        private System.Windows.Forms.Button mb3;
    }
}