namespace Konwersja_timestampów
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbWprowadzenie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wyswietlanieWynikow = new System.Windows.Forms.TextBox();
            this.Metra5 = new System.Windows.Forms.Button();
            this.Proxiserve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ckDane = new System.Windows.Forms.CheckBox();
            this.chRamka = new System.Windows.Forms.CheckBox();
            this.btnRozpoznanie = new System.Windows.Forms.Button();
            this.btnClearTBox = new System.Windows.Forms.Button();
            this.chbDataR = new System.Windows.Forms.CheckBox();
            this.chbDataAktualna = new System.Windows.Forms.CheckBox();
            this.chbAlarmy = new System.Windows.Forms.CheckBox();
            this.btnCeris = new System.Windows.Forms.Button();
            this.btnHistoriaAlarmow = new System.Windows.Forms.Button();
            this.btnMetra6_8 = new System.Windows.Forms.Button();
            this.btnTestDanych = new System.Windows.Forms.Button();
            this.txtbVektor = new System.Windows.Forms.TextBox();
            this.grbBoxAES = new System.Windows.Forms.GroupBox();
            this.chbAPA = new System.Windows.Forms.CheckBox();
            this.grpVersion = new System.Windows.Forms.GroupBox();
            this.txtbFrameVersion = new System.Windows.Forms.TextBox();
            this.chbAPT = new System.Windows.Forms.CheckBox();
            this.ckbEncDecMetra = new System.Windows.Forms.CheckBox();
            this.btnKoduj = new System.Windows.Forms.Button();
            this.grbb2 = new System.Windows.Forms.GroupBox();
            this.tztbVek = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.btndekodowanie = new System.Windows.Forms.Button();
            this.txtbAES = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbBoxAES.SuspendLayout();
            this.grpVersion.SuspendLayout();
            this.grbb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbWprowadzenie
            // 
            this.tbWprowadzenie.Location = new System.Drawing.Point(12, 28);
            this.tbWprowadzenie.Name = "tbWprowadzenie";
            this.tbWprowadzenie.Size = new System.Drawing.Size(716, 20);
            this.tbWprowadzenie.TabIndex = 0;
            this.tbWprowadzenie.Text = "0F 56 ED 6B EC 3F 9D 58 9D 05 96 FF 99 B7 FE 4C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wprowadź ramkę - hex";
            // 
            // wyswietlanieWynikow
            // 
            this.wyswietlanieWynikow.Location = new System.Drawing.Point(12, 186);
            this.wyswietlanieWynikow.Multiline = true;
            this.wyswietlanieWynikow.Name = "wyswietlanieWynikow";
            this.wyswietlanieWynikow.ReadOnly = true;
            this.wyswietlanieWynikow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.wyswietlanieWynikow.Size = new System.Drawing.Size(713, 290);
            this.wyswietlanieWynikow.TabIndex = 2;
            // 
            // Metra5
            // 
            this.Metra5.Location = new System.Drawing.Point(15, 52);
            this.Metra5.Name = "Metra5";
            this.Metra5.Size = new System.Drawing.Size(115, 23);
            this.Metra5.TabIndex = 3;
            this.Metra5.Text = "Konwertuj Metre 5 i 7";
            this.Metra5.UseVisualStyleBackColor = true;
            this.Metra5.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proxiserve
            // 
            this.Proxiserve.Location = new System.Drawing.Point(136, 52);
            this.Proxiserve.Name = "Proxiserve";
            this.Proxiserve.Size = new System.Drawing.Size(128, 23);
            this.Proxiserve.TabIndex = 4;
            this.Proxiserve.Text = "Konwertuj Proxiserve";
            this.Proxiserve.UseVisualStyleBackColor = true;
            this.Proxiserve.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 482);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ckDane
            // 
            this.ckDane.AutoSize = true;
            this.ckDane.Checked = true;
            this.ckDane.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDane.Location = new System.Drawing.Point(135, 4);
            this.ckDane.Name = "ckDane";
            this.ckDane.Size = new System.Drawing.Size(52, 17);
            this.ckDane.TabIndex = 6;
            this.ckDane.Text = "Dane";
            this.ckDane.UseVisualStyleBackColor = true;
            this.ckDane.CheckedChanged += new System.EventHandler(this.ckDane_CheckedChanged);
            // 
            // chRamka
            // 
            this.chRamka.AutoSize = true;
            this.chRamka.Enabled = false;
            this.chRamka.Location = new System.Drawing.Point(193, 4);
            this.chRamka.Name = "chRamka";
            this.chRamka.Size = new System.Drawing.Size(81, 17);
            this.chRamka.TabIndex = 7;
            this.chRamka.Text = "Cała ramka";
            this.chRamka.UseVisualStyleBackColor = true;
            this.chRamka.CheckedChanged += new System.EventHandler(this.chRamka_CheckedChanged);
            // 
            // btnRozpoznanie
            // 
            this.btnRozpoznanie.Enabled = false;
            this.btnRozpoznanie.Location = new System.Drawing.Point(96, 482);
            this.btnRozpoznanie.Name = "btnRozpoznanie";
            this.btnRozpoznanie.Size = new System.Drawing.Size(101, 23);
            this.btnRozpoznanie.TabIndex = 8;
            this.btnRozpoznanie.Text = "Rozpoznaj ramkę";
            this.btnRozpoznanie.UseVisualStyleBackColor = true;
            this.btnRozpoznanie.Click += new System.EventHandler(this.btnRozpoznanie_Click);
            // 
            // btnClearTBox
            // 
            this.btnClearTBox.Location = new System.Drawing.Point(653, 1);
            this.btnClearTBox.Name = "btnClearTBox";
            this.btnClearTBox.Size = new System.Drawing.Size(75, 23);
            this.btnClearTBox.TabIndex = 9;
            this.btnClearTBox.Text = "Czyść wsad";
            this.btnClearTBox.UseVisualStyleBackColor = true;
            this.btnClearTBox.Click += new System.EventHandler(this.btnClearTBox_Click);
            // 
            // chbDataR
            // 
            this.chbDataR.AutoSize = true;
            this.chbDataR.Location = new System.Drawing.Point(15, 123);
            this.chbDataR.Name = "chbDataR";
            this.chbDataR.Size = new System.Drawing.Size(101, 17);
            this.chbDataR.TabIndex = 10;
            this.chbDataR.Text = "Data rozliczenia";
            this.chbDataR.UseVisualStyleBackColor = true;
            this.chbDataR.CheckedChanged += new System.EventHandler(this.chbDataR_CheckedChanged);
            // 
            // chbDataAktualna
            // 
            this.chbDataAktualna.AutoSize = true;
            this.chbDataAktualna.Location = new System.Drawing.Point(112, 123);
            this.chbDataAktualna.Name = "chbDataAktualna";
            this.chbDataAktualna.Size = new System.Drawing.Size(92, 17);
            this.chbDataAktualna.TabIndex = 11;
            this.chbDataAktualna.Text = "Aktualna data";
            this.chbDataAktualna.UseVisualStyleBackColor = true;
            this.chbDataAktualna.CheckedChanged += new System.EventHandler(this.chbDataAktualna_CheckedChanged);
            // 
            // chbAlarmy
            // 
            this.chbAlarmy.AutoSize = true;
            this.chbAlarmy.Location = new System.Drawing.Point(210, 123);
            this.chbAlarmy.Name = "chbAlarmy";
            this.chbAlarmy.Size = new System.Drawing.Size(91, 17);
            this.chbAlarmy.TabIndex = 12;
            this.chbAlarmy.Text = "Data alarmów";
            this.chbAlarmy.UseVisualStyleBackColor = true;
            this.chbAlarmy.CheckedChanged += new System.EventHandler(this.chbAlarmy_CheckedChanged);
            // 
            // btnCeris
            // 
            this.btnCeris.Location = new System.Drawing.Point(270, 52);
            this.btnCeris.Name = "btnCeris";
            this.btnCeris.Size = new System.Drawing.Size(128, 23);
            this.btnCeris.TabIndex = 13;
            this.btnCeris.Text = "Konwertuj Ceris";
            this.btnCeris.UseVisualStyleBackColor = true;
            this.btnCeris.Click += new System.EventHandler(this.btnCeris_Click);
            // 
            // btnHistoriaAlarmow
            // 
            this.btnHistoriaAlarmow.Location = new System.Drawing.Point(270, 81);
            this.btnHistoriaAlarmow.Name = "btnHistoriaAlarmow";
            this.btnHistoriaAlarmow.Size = new System.Drawing.Size(128, 23);
            this.btnHistoriaAlarmow.TabIndex = 14;
            this.btnHistoriaAlarmow.Text = "Data typu G";
            this.btnHistoriaAlarmow.UseVisualStyleBackColor = true;
            this.btnHistoriaAlarmow.Click += new System.EventHandler(this.btnHistoriaAlarmow_Click);
            // 
            // btnMetra6_8
            // 
            this.btnMetra6_8.Location = new System.Drawing.Point(15, 81);
            this.btnMetra6_8.Name = "btnMetra6_8";
            this.btnMetra6_8.Size = new System.Drawing.Size(115, 23);
            this.btnMetra6_8.TabIndex = 15;
            this.btnMetra6_8.Text = "Konwertuj Metre 6 i 8";
            this.btnMetra6_8.UseVisualStyleBackColor = true;
            this.btnMetra6_8.Click += new System.EventHandler(this.btnMetra6_8_Click);
            // 
            // btnTestDanych
            // 
            this.btnTestDanych.Location = new System.Drawing.Point(210, 482);
            this.btnTestDanych.Name = "btnTestDanych";
            this.btnTestDanych.Size = new System.Drawing.Size(75, 23);
            this.btnTestDanych.TabIndex = 16;
            this.btnTestDanych.Text = "Test danych";
            this.btnTestDanych.UseVisualStyleBackColor = true;
            this.btnTestDanych.Click += new System.EventHandler(this.btnTestDanych_Click);
            // 
            // txtbVektor
            // 
            this.txtbVektor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbVektor.Location = new System.Drawing.Point(440, 482);
            this.txtbVektor.Name = "txtbVektor";
            this.txtbVektor.ReadOnly = true;
            this.txtbVektor.Size = new System.Drawing.Size(285, 20);
            this.txtbVektor.TabIndex = 17;
            this.txtbVektor.Text = "01 06 __ __ __ __ 20 08 lp lp lp lp lp lp lp lp";
            this.txtbVektor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbBoxAES
            // 
            this.grbBoxAES.Controls.Add(this.chbAPA);
            this.grbBoxAES.Controls.Add(this.grpVersion);
            this.grbBoxAES.Controls.Add(this.chbAPT);
            this.grbBoxAES.Controls.Add(this.ckbEncDecMetra);
            this.grbBoxAES.Controls.Add(this.btnKoduj);
            this.grbBoxAES.Controls.Add(this.grbb2);
            this.grbBoxAES.Controls.Add(this.btndekodowanie);
            this.grbBoxAES.Controls.Add(this.txtbAES);
            this.grbBoxAES.Location = new System.Drawing.Point(420, 54);
            this.grbBoxAES.Name = "grbBoxAES";
            this.grbBoxAES.Size = new System.Drawing.Size(286, 126);
            this.grbBoxAES.TabIndex = 18;
            this.grbBoxAES.TabStop = false;
            this.grbBoxAES.Text = "Szyfrowanie AES";
            // 
            // chbAPA
            // 
            this.chbAPA.AutoSize = true;
            this.chbAPA.Location = new System.Drawing.Point(170, 103);
            this.chbAPA.Name = "chbAPA";
            this.chbAPA.Size = new System.Drawing.Size(47, 17);
            this.chbAPA.TabIndex = 25;
            this.chbAPA.Text = "APA";
            this.chbAPA.UseVisualStyleBackColor = true;
            this.chbAPA.CheckedChanged += new System.EventHandler(this.chbAPA_CheckedChanged);
            // 
            // grpVersion
            // 
            this.grpVersion.Controls.Add(this.txtbFrameVersion);
            this.grpVersion.Location = new System.Drawing.Point(211, 27);
            this.grpVersion.Name = "grpVersion";
            this.grpVersion.Size = new System.Drawing.Size(69, 70);
            this.grpVersion.TabIndex = 24;
            this.grpVersion.TabStop = false;
            this.grpVersion.Text = "Version";
            // 
            // txtbFrameVersion
            // 
            this.txtbFrameVersion.Location = new System.Drawing.Point(6, 21);
            this.txtbFrameVersion.Name = "txtbFrameVersion";
            this.txtbFrameVersion.Size = new System.Drawing.Size(40, 20);
            this.txtbFrameVersion.TabIndex = 3;
            this.txtbFrameVersion.Text = "20";
            this.txtbFrameVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbAPT
            // 
            this.chbAPT.AutoSize = true;
            this.chbAPT.Location = new System.Drawing.Point(117, 103);
            this.chbAPT.Name = "chbAPT";
            this.chbAPT.Size = new System.Drawing.Size(47, 17);
            this.chbAPT.TabIndex = 23;
            this.chbAPT.Text = "APT";
            this.chbAPT.UseVisualStyleBackColor = true;
            this.chbAPT.CheckedChanged += new System.EventHandler(this.chbAPT_CheckedChanged);
            // 
            // ckbEncDecMetra
            // 
            this.ckbEncDecMetra.AutoSize = true;
            this.ckbEncDecMetra.Location = new System.Drawing.Point(20, 103);
            this.ckbEncDecMetra.Name = "ckbEncDecMetra";
            this.ckbEncDecMetra.Size = new System.Drawing.Size(84, 17);
            this.ckbEncDecMetra.TabIndex = 22;
            this.ckbEncDecMetra.Text = "profile Metra";
            this.ckbEncDecMetra.UseVisualStyleBackColor = true;
            this.ckbEncDecMetra.CheckedChanged += new System.EventHandler(this.ckbEncDecMetra_CheckedChanged);
            // 
            // btnKoduj
            // 
            this.btnKoduj.Location = new System.Drawing.Point(20, 74);
            this.btnKoduj.Name = "btnKoduj";
            this.btnKoduj.Size = new System.Drawing.Size(91, 23);
            this.btnKoduj.TabIndex = 21;
            this.btnKoduj.Text = "Kodowanie";
            this.btnKoduj.UseVisualStyleBackColor = true;
            this.btnKoduj.Click += new System.EventHandler(this.btnKoduj_Click);
            // 
            // grbb2
            // 
            this.grbb2.Controls.Add(this.tztbVek);
            this.grbb2.Controls.Add(this.txtSN);
            this.grbb2.Location = new System.Drawing.Point(117, 19);
            this.grbb2.Name = "grbb2";
            this.grbb2.Size = new System.Drawing.Size(88, 78);
            this.grbb2.TabIndex = 20;
            this.grbb2.TabStop = false;
            this.grbb2.Text = "SN i vektor";
            // 
            // tztbVek
            // 
            this.tztbVek.Location = new System.Drawing.Point(16, 48);
            this.tztbVek.Name = "tztbVek";
            this.tztbVek.Size = new System.Drawing.Size(65, 20);
            this.tztbVek.TabIndex = 2;
            this.tztbVek.Text = "5";
            this.tztbVek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(16, 19);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(65, 20);
            this.txtSN.TabIndex = 1;
            this.txtSN.Text = "004075";
            this.txtSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndekodowanie
            // 
            this.btndekodowanie.Location = new System.Drawing.Point(20, 45);
            this.btndekodowanie.Name = "btndekodowanie";
            this.btndekodowanie.Size = new System.Drawing.Size(91, 23);
            this.btndekodowanie.TabIndex = 19;
            this.btndekodowanie.Text = "Dek Niuchacz";
            this.btndekodowanie.UseVisualStyleBackColor = true;
            this.btndekodowanie.Click += new System.EventHandler(this.btndekodowanie_Click);
            // 
            // txtbAES
            // 
            this.txtbAES.Location = new System.Drawing.Point(34, 19);
            this.txtbAES.Name = "txtbAES";
            this.txtbAES.Size = new System.Drawing.Size(44, 20);
            this.txtbAES.TabIndex = 0;
            this.txtbAES.Text = "0000";
            this.txtbAES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Data typu F";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbBoxAES);
            this.Controls.Add(this.txtbVektor);
            this.Controls.Add(this.btnTestDanych);
            this.Controls.Add(this.btnMetra6_8);
            this.Controls.Add(this.btnHistoriaAlarmow);
            this.Controls.Add(this.btnCeris);
            this.Controls.Add(this.chbAlarmy);
            this.Controls.Add(this.chbDataAktualna);
            this.Controls.Add(this.chbDataR);
            this.Controls.Add(this.btnClearTBox);
            this.Controls.Add(this.btnRozpoznanie);
            this.Controls.Add(this.chRamka);
            this.Controls.Add(this.ckDane);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Proxiserve);
            this.Controls.Add(this.Metra5);
            this.Controls.Add(this.wyswietlanieWynikow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWprowadzenie);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Konwerter - wMBus v1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbBoxAES.ResumeLayout(false);
            this.grbBoxAES.PerformLayout();
            this.grpVersion.ResumeLayout(false);
            this.grpVersion.PerformLayout();
            this.grbb2.ResumeLayout(false);
            this.grbb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWprowadzenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wyswietlanieWynikow;
        private System.Windows.Forms.Button Metra5;
        private System.Windows.Forms.Button Proxiserve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox ckDane;
        private System.Windows.Forms.CheckBox chRamka;
        private System.Windows.Forms.Button btnRozpoznanie;
        private System.Windows.Forms.Button btnClearTBox;
        private System.Windows.Forms.CheckBox chbDataR;
        private System.Windows.Forms.CheckBox chbDataAktualna;
        private System.Windows.Forms.CheckBox chbAlarmy;
        private System.Windows.Forms.Button btnCeris;
        private System.Windows.Forms.Button btnHistoriaAlarmow;
        private System.Windows.Forms.Button btnMetra6_8;
        private System.Windows.Forms.Button btnTestDanych;
        private System.Windows.Forms.TextBox txtbVektor;
        private System.Windows.Forms.GroupBox grbBoxAES;
        private System.Windows.Forms.TextBox txtbAES;
        private System.Windows.Forms.Button btndekodowanie;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.GroupBox grbb2;
        private System.Windows.Forms.TextBox tztbVek;
        private System.Windows.Forms.Button btnKoduj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbEncDecMetra;
        private System.Windows.Forms.CheckBox chbAPT;
        private System.Windows.Forms.TextBox txtbFrameVersion;
        private System.Windows.Forms.GroupBox grpVersion;
        private System.Windows.Forms.CheckBox chbAPA;
    }
}

