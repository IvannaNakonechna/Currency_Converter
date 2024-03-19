namespace Projekt2
{
    partial class FormPrzelicznikWalut
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
            this.textBox_ŹródłowaWaluta = new System.Windows.Forms.TextBox();
            this.label_ŹródłowaWaluta = new System.Windows.Forms.Label();
            this.label_DocelowaWaluta = new System.Windows.Forms.Label();
            this.textBox_DocelowaWaluta = new System.Windows.Forms.TextBox();
            this.groupBox_WalutaŻródłowa = new System.Windows.Forms.GroupBox();
            this.radioButton_IN_WŹ = new System.Windows.Forms.RadioButton();
            this.radioButton_EURO_WŹ = new System.Windows.Forms.RadioButton();
            this.radioButton_USD_WŹ = new System.Windows.Forms.RadioButton();
            this.radioButton_PLN_WŹ = new System.Windows.Forms.RadioButton();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox_WalutaDocelowa = new System.Windows.Forms.GroupBox();
            this.radioButton_IN_WD = new System.Windows.Forms.RadioButton();
            this.radioButton_EURO_WD = new System.Windows.Forms.RadioButton();
            this.radioButton_USD_WD = new System.Windows.Forms.RadioButton();
            this.radioButton_PLN_WD = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox_WalutaŻródłowa.SuspendLayout();
            this.groupBox_WalutaDocelowa.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ŹródłowaWaluta
            // 
            this.textBox_ŹródłowaWaluta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ŹródłowaWaluta.Location = new System.Drawing.Point(144, 25);
            this.textBox_ŹródłowaWaluta.Name = "textBox_ŹródłowaWaluta";
            this.textBox_ŹródłowaWaluta.Size = new System.Drawing.Size(614, 22);
            this.textBox_ŹródłowaWaluta.TabIndex = 0;
            this.textBox_ŹródłowaWaluta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Waluta_KeyPress);
            // 
            // label_ŹródłowaWaluta
            // 
            this.label_ŹródłowaWaluta.AutoSize = true;
            this.label_ŹródłowaWaluta.Location = new System.Drawing.Point(12, 28);
            this.label_ŹródłowaWaluta.Name = "label_ŹródłowaWaluta";
            this.label_ŹródłowaWaluta.Size = new System.Drawing.Size(44, 16);
            this.label_ŹródłowaWaluta.TabIndex = 1;
            this.label_ŹródłowaWaluta.Text = "label1";
            // 
            // label_DocelowaWaluta
            // 
            this.label_DocelowaWaluta.AutoSize = true;
            this.label_DocelowaWaluta.Location = new System.Drawing.Point(12, 69);
            this.label_DocelowaWaluta.Name = "label_DocelowaWaluta";
            this.label_DocelowaWaluta.Size = new System.Drawing.Size(44, 16);
            this.label_DocelowaWaluta.TabIndex = 3;
            this.label_DocelowaWaluta.Text = "label2";
            // 
            // textBox_DocelowaWaluta
            // 
            this.textBox_DocelowaWaluta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_DocelowaWaluta.Location = new System.Drawing.Point(144, 69);
            this.textBox_DocelowaWaluta.Name = "textBox_DocelowaWaluta";
            this.textBox_DocelowaWaluta.Size = new System.Drawing.Size(614, 22);
            this.textBox_DocelowaWaluta.TabIndex = 2;
            // 
            // groupBox_WalutaŻródłowa
            // 
            this.groupBox_WalutaŻródłowa.Controls.Add(this.radioButton_IN_WŹ);
            this.groupBox_WalutaŻródłowa.Controls.Add(this.radioButton_EURO_WŹ);
            this.groupBox_WalutaŻródłowa.Controls.Add(this.radioButton_USD_WŹ);
            this.groupBox_WalutaŻródłowa.Controls.Add(this.radioButton_PLN_WŹ);
            this.groupBox_WalutaŻródłowa.Location = new System.Drawing.Point(68, 136);
            this.groupBox_WalutaŻródłowa.Name = "groupBox_WalutaŻródłowa";
            this.groupBox_WalutaŻródłowa.Size = new System.Drawing.Size(292, 184);
            this.groupBox_WalutaŻródłowa.TabIndex = 4;
            this.groupBox_WalutaŻródłowa.TabStop = false;
            this.groupBox_WalutaŻródłowa.Text = "Waluta źródłowa";
            // 
            // radioButton_IN_WŹ
            // 
            this.radioButton_IN_WŹ.AutoSize = true;
            this.radioButton_IN_WŹ.Location = new System.Drawing.Point(7, 146);
            this.radioButton_IN_WŹ.Name = "radioButton_IN_WŹ";
            this.radioButton_IN_WŹ.Size = new System.Drawing.Size(41, 20);
            this.radioButton_IN_WŹ.TabIndex = 3;
            this.radioButton_IN_WŹ.TabStop = true;
            this.radioButton_IN_WŹ.Text = "IN";
            this.radioButton_IN_WŹ.UseVisualStyleBackColor = true;
            this.radioButton_IN_WŹ.CheckedChanged += new System.EventHandler(this.radioButton_IN_WŹ_CheckedChanged);
            // 
            // radioButton_EURO_WŹ
            // 
            this.radioButton_EURO_WŹ.AutoSize = true;
            this.radioButton_EURO_WŹ.Location = new System.Drawing.Point(7, 110);
            this.radioButton_EURO_WŹ.Name = "radioButton_EURO_WŹ";
            this.radioButton_EURO_WŹ.Size = new System.Drawing.Size(67, 20);
            this.radioButton_EURO_WŹ.TabIndex = 2;
            this.radioButton_EURO_WŹ.TabStop = true;
            this.radioButton_EURO_WŹ.Text = "EURO";
            this.radioButton_EURO_WŹ.UseVisualStyleBackColor = true;
            this.radioButton_EURO_WŹ.CheckedChanged += new System.EventHandler(this.radioButton_EURO_WŹ_CheckedChanged);
            // 
            // radioButton_USD_WŹ
            // 
            this.radioButton_USD_WŹ.AutoSize = true;
            this.radioButton_USD_WŹ.Location = new System.Drawing.Point(7, 74);
            this.radioButton_USD_WŹ.Name = "radioButton_USD_WŹ";
            this.radioButton_USD_WŹ.Size = new System.Drawing.Size(57, 20);
            this.radioButton_USD_WŹ.TabIndex = 1;
            this.radioButton_USD_WŹ.TabStop = true;
            this.radioButton_USD_WŹ.Text = "USD";
            this.radioButton_USD_WŹ.UseVisualStyleBackColor = true;
            this.radioButton_USD_WŹ.CheckedChanged += new System.EventHandler(this.radioButton_USD_WŹ_CheckedChanged);
            // 
            // radioButton_PLN_WŹ
            // 
            this.radioButton_PLN_WŹ.AutoSize = true;
            this.radioButton_PLN_WŹ.Location = new System.Drawing.Point(7, 36);
            this.radioButton_PLN_WŹ.Name = "radioButton_PLN_WŹ";
            this.radioButton_PLN_WŹ.Size = new System.Drawing.Size(54, 20);
            this.radioButton_PLN_WŹ.TabIndex = 0;
            this.radioButton_PLN_WŹ.TabStop = true;
            this.radioButton_PLN_WŹ.Text = "PLN";
            this.radioButton_PLN_WŹ.UseVisualStyleBackColor = true;
            this.radioButton_PLN_WŹ.CheckedChanged += new System.EventHandler(this.radioButton_PLN_WŹ_CheckedChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(57, 372);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(701, 21);
            this.hScrollBar1.TabIndex = 6;
            // 
            // groupBox_WalutaDocelowa
            // 
            this.groupBox_WalutaDocelowa.Controls.Add(this.radioButton_IN_WD);
            this.groupBox_WalutaDocelowa.Controls.Add(this.radioButton_EURO_WD);
            this.groupBox_WalutaDocelowa.Controls.Add(this.radioButton_USD_WD);
            this.groupBox_WalutaDocelowa.Controls.Add(this.radioButton_PLN_WD);
            this.groupBox_WalutaDocelowa.Location = new System.Drawing.Point(466, 136);
            this.groupBox_WalutaDocelowa.Name = "groupBox_WalutaDocelowa";
            this.groupBox_WalutaDocelowa.Size = new System.Drawing.Size(292, 184);
            this.groupBox_WalutaDocelowa.TabIndex = 7;
            this.groupBox_WalutaDocelowa.TabStop = false;
            this.groupBox_WalutaDocelowa.Text = "Waluta docelowa";
            // 
            // radioButton_IN_WD
            // 
            this.radioButton_IN_WD.AutoSize = true;
            this.radioButton_IN_WD.Location = new System.Drawing.Point(7, 146);
            this.radioButton_IN_WD.Name = "radioButton_IN_WD";
            this.radioButton_IN_WD.Size = new System.Drawing.Size(41, 20);
            this.radioButton_IN_WD.TabIndex = 3;
            this.radioButton_IN_WD.TabStop = true;
            this.radioButton_IN_WD.Text = "IN";
            this.radioButton_IN_WD.UseVisualStyleBackColor = true;
            this.radioButton_IN_WD.CheckedChanged += new System.EventHandler(this.radioButton_IN_WD_CheckedChanged);
            // 
            // radioButton_EURO_WD
            // 
            this.radioButton_EURO_WD.AutoSize = true;
            this.radioButton_EURO_WD.Location = new System.Drawing.Point(7, 110);
            this.radioButton_EURO_WD.Name = "radioButton_EURO_WD";
            this.radioButton_EURO_WD.Size = new System.Drawing.Size(67, 20);
            this.radioButton_EURO_WD.TabIndex = 2;
            this.radioButton_EURO_WD.TabStop = true;
            this.radioButton_EURO_WD.Text = "EURO";
            this.radioButton_EURO_WD.UseVisualStyleBackColor = true;
            this.radioButton_EURO_WD.CheckedChanged += new System.EventHandler(this.radioButton_EURO_WD_CheckedChanged);
            // 
            // radioButton_USD_WD
            // 
            this.radioButton_USD_WD.AutoSize = true;
            this.radioButton_USD_WD.Location = new System.Drawing.Point(7, 74);
            this.radioButton_USD_WD.Name = "radioButton_USD_WD";
            this.radioButton_USD_WD.Size = new System.Drawing.Size(57, 20);
            this.radioButton_USD_WD.TabIndex = 1;
            this.radioButton_USD_WD.TabStop = true;
            this.radioButton_USD_WD.Text = "USD";
            this.radioButton_USD_WD.UseVisualStyleBackColor = true;
            this.radioButton_USD_WD.CheckedChanged += new System.EventHandler(this.radioButton_USD_WD_CheckedChanged);
            // 
            // radioButton_PLN_WD
            // 
            this.radioButton_PLN_WD.AutoSize = true;
            this.radioButton_PLN_WD.Location = new System.Drawing.Point(7, 36);
            this.radioButton_PLN_WD.Name = "radioButton_PLN_WD";
            this.radioButton_PLN_WD.Size = new System.Drawing.Size(54, 20);
            this.radioButton_PLN_WD.TabIndex = 0;
            this.radioButton_PLN_WD.TabStop = true;
            this.radioButton_PLN_WD.Text = "PLN";
            this.radioButton_PLN_WD.UseVisualStyleBackColor = true;
            this.radioButton_PLN_WD.CheckedChanged += new System.EventHandler(this.radioButton_PLN_WD_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(695, 107);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FormPrzelicznikWalut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox_WalutaDocelowa);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.groupBox_WalutaŻródłowa);
            this.Controls.Add(this.label_DocelowaWaluta);
            this.Controls.Add(this.textBox_DocelowaWaluta);
            this.Controls.Add(this.label_ŹródłowaWaluta);
            this.Controls.Add(this.textBox_ŹródłowaWaluta);
            this.Name = "FormPrzelicznikWalut";
            this.Text = "    ";
            this.groupBox_WalutaŻródłowa.ResumeLayout(false);
            this.groupBox_WalutaŻródłowa.PerformLayout();
            this.groupBox_WalutaDocelowa.ResumeLayout(false);
            this.groupBox_WalutaDocelowa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ŹródłowaWaluta;
        private System.Windows.Forms.Label label_ŹródłowaWaluta;
        private System.Windows.Forms.Label label_DocelowaWaluta;
        private System.Windows.Forms.TextBox textBox_DocelowaWaluta;
        private System.Windows.Forms.GroupBox groupBox_WalutaŻródłowa;
        private System.Windows.Forms.RadioButton radioButton_IN_WŹ;
        private System.Windows.Forms.RadioButton radioButton_EURO_WŹ;
        private System.Windows.Forms.RadioButton radioButton_USD_WŹ;
        private System.Windows.Forms.RadioButton radioButton_PLN_WŹ;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox groupBox_WalutaDocelowa;
        private System.Windows.Forms.RadioButton radioButton_IN_WD;
        private System.Windows.Forms.RadioButton radioButton_EURO_WD;
        private System.Windows.Forms.RadioButton radioButton_USD_WD;
        private System.Windows.Forms.RadioButton radioButton_PLN_WD;
        private System.Windows.Forms.Button btn_ok;
    }
}

