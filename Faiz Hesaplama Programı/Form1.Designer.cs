
namespace Faiz_Hesaplama_Programı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.rd_365 = new System.Windows.Forms.RadioButton();
            this.rd_360 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_Gelecek = new System.Windows.Forms.RadioButton();
            this.rd_Simdi = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_donem = new System.Windows.Forms.ComboBox();
            this.cmb_vade = new System.Windows.Forms.ComboBox();
            this.cmb_faiz = new System.Windows.Forms.ComboBox();
            this.txt_donem = new System.Windows.Forms.TextBox();
            this.txt_vade = new System.Windows.Forms.TextBox();
            this.txt_faiz = new System.Windows.Forms.TextBox();
            this.txt_Anapara = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_365);
            this.panel2.Controls.Add(this.rd_360);
            this.panel2.Location = new System.Drawing.Point(631, 449);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 47);
            this.panel2.TabIndex = 36;
            // 
            // rd_365
            // 
            this.rd_365.AutoSize = true;
            this.rd_365.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_365.Location = new System.Drawing.Point(63, 2);
            this.rd_365.Margin = new System.Windows.Forms.Padding(4);
            this.rd_365.Name = "rd_365";
            this.rd_365.Size = new System.Drawing.Size(67, 27);
            this.rd_365.TabIndex = 16;
            this.rd_365.TabStop = true;
            this.rd_365.Text = "365";
            this.rd_365.UseVisualStyleBackColor = true;
            // 
            // rd_360
            // 
            this.rd_360.AutoSize = true;
            this.rd_360.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_360.Location = new System.Drawing.Point(256, 4);
            this.rd_360.Margin = new System.Windows.Forms.Padding(4);
            this.rd_360.Name = "rd_360";
            this.rd_360.Size = new System.Drawing.Size(67, 27);
            this.rd_360.TabIndex = 17;
            this.rd_360.TabStop = true;
            this.rd_360.Text = "360";
            this.rd_360.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_Gelecek);
            this.panel1.Controls.Add(this.rd_Simdi);
            this.panel1.Location = new System.Drawing.Point(627, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 123);
            this.panel1.TabIndex = 35;
            // 
            // rd_Gelecek
            // 
            this.rd_Gelecek.AutoSize = true;
            this.rd_Gelecek.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_Gelecek.Location = new System.Drawing.Point(4, 15);
            this.rd_Gelecek.Margin = new System.Windows.Forms.Padding(4);
            this.rd_Gelecek.Name = "rd_Gelecek";
            this.rd_Gelecek.Size = new System.Drawing.Size(336, 27);
            this.rd_Gelecek.TabIndex = 6;
            this.rd_Gelecek.TabStop = true;
            this.rd_Gelecek.Text = "Gelecekteki değeri ve faiz tutarı";
            this.rd_Gelecek.UseVisualStyleBackColor = true;
            // 
            // rd_Simdi
            // 
            this.rd_Simdi.AutoSize = true;
            this.rd_Simdi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_Simdi.Location = new System.Drawing.Point(4, 63);
            this.rd_Simdi.Margin = new System.Windows.Forms.Padding(4);
            this.rd_Simdi.Name = "rd_Simdi";
            this.rd_Simdi.Size = new System.Drawing.Size(298, 27);
            this.rd_Simdi.TabIndex = 7;
            this.rd_Simdi.TabStop = true;
            this.rd_Simdi.Text = "Şimdiki değeri ve faiz tutarı";
            this.rd_Simdi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(627, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 64);
            this.button1.TabIndex = 34;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_donem
            // 
            this.cmb_donem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_donem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_donem.FormattingEnabled = true;
            this.cmb_donem.Items.AddRange(new object[] {
            "Yıl",
            "Ay",
            "Gün"});
            this.cmb_donem.Location = new System.Drawing.Point(873, 385);
            this.cmb_donem.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_donem.Name = "cmb_donem";
            this.cmb_donem.Size = new System.Drawing.Size(160, 33);
            this.cmb_donem.TabIndex = 33;
            // 
            // cmb_vade
            // 
            this.cmb_vade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_vade.FormattingEnabled = true;
            this.cmb_vade.Items.AddRange(new object[] {
            "Yıl",
            "Ay",
            "Gün"});
            this.cmb_vade.Location = new System.Drawing.Point(873, 314);
            this.cmb_vade.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_vade.Name = "cmb_vade";
            this.cmb_vade.Size = new System.Drawing.Size(160, 33);
            this.cmb_vade.TabIndex = 32;
            // 
            // cmb_faiz
            // 
            this.cmb_faiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_faiz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_faiz.FormattingEnabled = true;
            this.cmb_faiz.Items.AddRange(new object[] {
            "Yıllık %",
            "Aylık %",
            "Günlük %"});
            this.cmb_faiz.Location = new System.Drawing.Point(873, 241);
            this.cmb_faiz.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_faiz.Name = "cmb_faiz";
            this.cmb_faiz.Size = new System.Drawing.Size(160, 33);
            this.cmb_faiz.TabIndex = 31;
            // 
            // txt_donem
            // 
            this.txt_donem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_donem.Location = new System.Drawing.Point(627, 384);
            this.txt_donem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_donem.Name = "txt_donem";
            this.txt_donem.Size = new System.Drawing.Size(231, 32);
            this.txt_donem.TabIndex = 30;
            // 
            // txt_vade
            // 
            this.txt_vade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_vade.Location = new System.Drawing.Point(627, 313);
            this.txt_vade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vade.Name = "txt_vade";
            this.txt_vade.Size = new System.Drawing.Size(231, 32);
            this.txt_vade.TabIndex = 29;
            // 
            // txt_faiz
            // 
            this.txt_faiz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_faiz.Location = new System.Drawing.Point(627, 241);
            this.txt_faiz.Margin = new System.Windows.Forms.Padding(4);
            this.txt_faiz.Name = "txt_faiz";
            this.txt_faiz.Size = new System.Drawing.Size(231, 32);
            this.txt_faiz.TabIndex = 28;
            // 
            // txt_Anapara
            // 
            this.txt_Anapara.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Anapara.Location = new System.Drawing.Point(627, 170);
            this.txt_Anapara.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Anapara.Name = "txt_Anapara";
            this.txt_Anapara.Size = new System.Drawing.Size(405, 32);
            this.txt_Anapara.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(257, 449);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yılın Gün Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(257, 383);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hes. Dönemleri (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(257, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(257, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Faiz Oranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(257, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Şimdiki Değer (Anapara)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(257, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ne Hesaplanacak?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_donem);
            this.Controls.Add(this.cmb_vade);
            this.Controls.Add(this.cmb_faiz);
            this.Controls.Add(this.txt_donem);
            this.Controls.Add(this.txt_vade);
            this.Controls.Add(this.txt_faiz);
            this.Controls.Add(this.txt_Anapara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rd_365;
        private System.Windows.Forms.RadioButton rd_360;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd_Gelecek;
        private System.Windows.Forms.RadioButton rd_Simdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_donem;
        private System.Windows.Forms.ComboBox cmb_vade;
        private System.Windows.Forms.ComboBox cmb_faiz;
        private System.Windows.Forms.TextBox txt_donem;
        private System.Windows.Forms.TextBox txt_vade;
        private System.Windows.Forms.TextBox txt_faiz;
        private System.Windows.Forms.TextBox txt_Anapara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

