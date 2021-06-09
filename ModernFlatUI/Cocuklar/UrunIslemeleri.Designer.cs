namespace Deneme
{
    partial class UrunIslemeleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunIslemeleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gizliButton = new System.Windows.Forms.Button();
            this.ekleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.yenileButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.markaText = new System.Windows.Forms.TextBox();
            this.modelText = new System.Windows.Forms.TextBox();
            this.yakıtText = new System.Windows.Forms.TextBox();
            this.kasaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gösterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 621);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(461, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 33);
            this.textBox1.TabIndex = 1;
            // 
            // gizliButton
            // 
            this.gizliButton.Location = new System.Drawing.Point(0, 2);
            this.gizliButton.Name = "gizliButton";
            this.gizliButton.Size = new System.Drawing.Size(75, 23);
            this.gizliButton.TabIndex = 2;
            this.gizliButton.Text = "button1";
            this.gizliButton.UseVisualStyleBackColor = true;
            // 
            // ekleButton
            // 
            this.ekleButton.BackColor = System.Drawing.Color.Lime;
            this.ekleButton.Location = new System.Drawing.Point(0, 31);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(114, 41);
            this.ekleButton.TabIndex = 3;
            this.ekleButton.Text = "Ürün Ekle";
            this.ekleButton.UseVisualStyleBackColor = false;
            this.ekleButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.Red;
            this.silButton.Location = new System.Drawing.Point(139, 31);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(142, 41);
            this.silButton.TabIndex = 4;
            this.silButton.Text = "Ürün Sil";
            this.silButton.UseVisualStyleBackColor = false;
            this.silButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // yenileButton
            // 
            this.yenileButton.BackColor = System.Drawing.Color.Aqua;
            this.yenileButton.Location = new System.Drawing.Point(299, 33);
            this.yenileButton.Name = "yenileButton";
            this.yenileButton.Size = new System.Drawing.Size(129, 41);
            this.yenileButton.TabIndex = 5;
            this.yenileButton.Text = "Yenile";
            this.yenileButton.UseVisualStyleBackColor = false;
            this.yenileButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(615, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // markaText
            // 
            this.markaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaText.Location = new System.Drawing.Point(63, 100);
            this.markaText.Multiline = true;
            this.markaText.Name = "markaText";
            this.markaText.Size = new System.Drawing.Size(228, 28);
            this.markaText.TabIndex = 9;
            this.markaText.TextChanged += new System.EventHandler(this.markaText_TextChanged);
            // 
            // modelText
            // 
            this.modelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelText.Location = new System.Drawing.Point(63, 152);
            this.modelText.Multiline = true;
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(228, 28);
            this.modelText.TabIndex = 10;
            // 
            // yakıtText
            // 
            this.yakıtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yakıtText.Location = new System.Drawing.Point(445, 100);
            this.yakıtText.Multiline = true;
            this.yakıtText.Name = "yakıtText";
            this.yakıtText.Size = new System.Drawing.Size(228, 28);
            this.yakıtText.TabIndex = 11;
            // 
            // kasaText
            // 
            this.kasaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasaText.Location = new System.Drawing.Point(445, 152);
            this.kasaText.Multiline = true;
            this.kasaText.Name = "kasaText";
            this.kasaText.Size = new System.Drawing.Size(228, 28);
            this.kasaText.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Yakıt Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kasa Tipi";
            // 
            // gösterButton
            // 
            this.gösterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gösterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gösterButton.Image = ((System.Drawing.Image)(resources.GetObject("gösterButton.Image")));
            this.gösterButton.Location = new System.Drawing.Point(665, 41);
            this.gösterButton.Name = "gösterButton";
            this.gösterButton.Size = new System.Drawing.Size(63, 33);
            this.gösterButton.TabIndex = 8;
            this.gösterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gösterButton.UseVisualStyleBackColor = true;
            this.gösterButton.Click += new System.EventHandler(this.göster_Click);
            // 
            // UrunIslemeleri
            // 
            this.AcceptButton = this.gizliButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 807);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kasaText);
            this.Controls.Add(this.yakıtText);
            this.Controls.Add(this.modelText);
            this.Controls.Add(this.markaText);
            this.Controls.Add(this.gösterButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.yenileButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.gizliButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UrunIslemeleri";
            this.Text = "UrunIslemeleri";
            this.Load += new System.EventHandler(this.UrunIslemeleri_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrunIslemeleri_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button gizliButton;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button yenileButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox markaText;
        private System.Windows.Forms.TextBox modelText;
        private System.Windows.Forms.TextBox yakıtText;
        private System.Windows.Forms.TextBox kasaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gösterButton;
    }
}