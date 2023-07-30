namespace Otomasyon
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            PerMaas = new MaskedTextBox();
            comboBox1 = new ComboBox();
            PerMeslek = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            PerSoyad = new TextBox();
            label2 = new Label();
            PerAd = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            PerId = new TextBox();
            btnclear = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            btnsave = new Button();
            btnlist = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(PerMaas);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(PerMeslek);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PerSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(PerAd);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 352);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Giriş";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(159, 209);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "bekar";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(89, 208);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "evli";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 209);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 12;
            label6.Text = "Durum:";
            // 
            // PerMaas
            // 
            PerMaas.Location = new Point(79, 156);
            PerMaas.Mask = "00000";
            PerMaas.Name = "PerMaas";
            PerMaas.Size = new Size(151, 27);
            PerMaas.TabIndex = 11;
            PerMaas.ValidatingType = typeof(int);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // PerMeslek
            // 
            PerMeslek.Location = new Point(79, 262);
            PerMeslek.Name = "PerMeslek";
            PerMeslek.Size = new Size(147, 27);
            PerMeslek.TabIndex = 9;
            PerMeslek.TextChanged += PerMeslek_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 265);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 8;
            label5.Text = "Meslek:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 156);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 6;
            label4.Text = "Maaş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 118);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 4;
            label3.Text = "Şehir:";
            // 
            // PerSoyad
            // 
            PerSoyad.Location = new Point(79, 73);
            PerSoyad.Name = "PerSoyad";
            PerSoyad.Size = new Size(147, 27);
            PerSoyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 76);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Soyadı:";
            // 
            // PerAd
            // 
            PerAd.Location = new Point(79, 33);
            PerAd.Name = "PerAd";
            PerAd.Size = new Size(147, 27);
            PerAd.TabIndex = 1;
            PerAd.TextChanged += PerAd_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 36);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(PerId);
            groupBox2.Controls.Add(btnclear);
            groupBox2.Controls.Add(btnupdate);
            groupBox2.Controls.Add(btndelete);
            groupBox2.Controls.Add(btnsave);
            groupBox2.Controls.Add(btnlist);
            groupBox2.Location = new Point(359, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 285);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlemler";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 238);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 15;
            label8.Text = "PersonelId";
            // 
            // PerId
            // 
            PerId.Location = new Point(104, 235);
            PerId.Name = "PerId";
            PerId.Size = new Size(52, 27);
            PerId.TabIndex = 15;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(41, 156);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(115, 29);
            btnclear.TabIndex = 4;
            btnclear.Text = "Temizle";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(41, 117);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(115, 29);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "Güncelle";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(41, 200);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(115, 29);
            btndelete.TabIndex = 2;
            btndelete.Text = "Sil";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(41, 76);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(115, 29);
            btnsave.TabIndex = 1;
            btnsave.Text = "Kaydet";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnlist
            // 
            btnlist.Location = new Point(41, 36);
            btnlist.Name = "btnlist";
            btnlist.Size = new Size(115, 29);
            btnlist.TabIndex = 0;
            btnlist.Text = "Listele";
            btnlist.UseVisualStyleBackColor = true;
            btnlist.Click += btnlist_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(18, 403);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(857, 185);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(851, 159);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(916, 645);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 3;
            label7.Text = "label7";
            label7.TextChanged += label7_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(638, 283);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 4;
            label9.Text = "label7";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 663);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox PerAd;
        private Label label1;
        private TextBox PerMeslek;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox PerSoyad;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private MaskedTextBox PerMaas;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Button btnclear;
        private Button btnupdate;
        private Button btndelete;
        private Button btnsave;
        private Button btnlist;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label8;
        private TextBox PerId;
        private Label label9;
    }
}