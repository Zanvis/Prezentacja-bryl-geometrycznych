namespace Projekt3_Piwowarski62024
{
    partial class LaboratoriumNr3
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
            this.components = new System.ComponentModel.Container();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.btnDodajNowaBG = new System.Windows.Forms.Button();
            this.gpbAtrybutyBG = new System.Windows.Forms.GroupBox();
            this.trbPromienBryly = new System.Windows.Forms.TrackBar();
            this.cmbStylLinii = new System.Windows.Forms.ComboBox();
            this.btnKolorLinii = new System.Windows.Forms.Button();
            this.lblGruboscLinii = new System.Windows.Forms.Label();
            this.trbGruboscLinii = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.numStopieńWielokąta = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPromienBG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWysokoscBryly = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbWysokoscBryly = new System.Windows.Forms.TrackBar();
            this.cmbBrylyGeometryczne = new System.Windows.Forms.ComboBox();
            this.ZegarObrotu = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbKryteriaPokazu = new System.Windows.Forms.GroupBox();
            this.rdbPoleCalkowite = new System.Windows.Forms.RadioButton();
            this.rdbObjetosc = new System.Windows.Forms.RadioButton();
            this.rdbWysokosc = new System.Windows.Forms.RadioButton();
            this.txtN = new System.Windows.Forms.Label();
            this.gpbWyborSlajdu = new System.Windows.Forms.GroupBox();
            this.rdbPrzyciskowy = new System.Windows.Forms.RadioButton();
            this.rdbZegarowy = new System.Windows.Forms.RadioButton();
            this.lblN = new System.Windows.Forms.Label();
            this.btnWylaczSlajder = new System.Windows.Forms.Button();
            this.btnPoprzednia = new System.Windows.Forms.Button();
            this.btnNastepna = new System.Windows.Forms.Button();
            this.btnWlaczSlajder = new System.Windows.Forms.Button();
            this.ZegarSlajder = new System.Windows.Forms.Timer(this.components);
            this.ZegarObrotowy = new System.Windows.Forms.Timer(this.components);
            this.btnKierunekLewo = new System.Windows.Forms.Button();
            this.btnKierunekPrawo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.gpbAtrybutyBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPromienBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGruboscLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopieńWielokąta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokoscBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpbKryteriaPokazu.SuspendLayout();
            this.gpbWyborSlajdu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(228, 57);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(750, 503);
            this.pbRysownica.TabIndex = 19;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseClick);
            // 
            // btnDodajNowaBG
            // 
            this.btnDodajNowaBG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNowaBG.Location = new System.Drawing.Point(28, 442);
            this.btnDodajNowaBG.Name = "btnDodajNowaBG";
            this.btnDodajNowaBG.Size = new System.Drawing.Size(158, 29);
            this.btnDodajNowaBG.TabIndex = 18;
            this.btnDodajNowaBG.Text = "Dodaj nową BG";
            this.btnDodajNowaBG.UseVisualStyleBackColor = true;
            this.btnDodajNowaBG.Click += new System.EventHandler(this.btnDodajNowaBG_Click);
            // 
            // gpbAtrybutyBG
            // 
            this.gpbAtrybutyBG.Controls.Add(this.trbPromienBryly);
            this.gpbAtrybutyBG.Controls.Add(this.cmbStylLinii);
            this.gpbAtrybutyBG.Controls.Add(this.btnKolorLinii);
            this.gpbAtrybutyBG.Controls.Add(this.lblGruboscLinii);
            this.gpbAtrybutyBG.Controls.Add(this.trbGruboscLinii);
            this.gpbAtrybutyBG.Controls.Add(this.label4);
            this.gpbAtrybutyBG.Controls.Add(this.numStopieńWielokąta);
            this.gpbAtrybutyBG.Controls.Add(this.label3);
            this.gpbAtrybutyBG.Controls.Add(this.lblPromienBG);
            this.gpbAtrybutyBG.Controls.Add(this.label2);
            this.gpbAtrybutyBG.Controls.Add(this.lblWysokoscBryly);
            this.gpbAtrybutyBG.Controls.Add(this.label1);
            this.gpbAtrybutyBG.Controls.Add(this.trbWysokoscBryly);
            this.gpbAtrybutyBG.Location = new System.Drawing.Point(8, 57);
            this.gpbAtrybutyBG.Name = "gpbAtrybutyBG";
            this.gpbAtrybutyBG.Size = new System.Drawing.Size(200, 354);
            this.gpbAtrybutyBG.TabIndex = 17;
            this.gpbAtrybutyBG.TabStop = false;
            this.gpbAtrybutyBG.Text = "Ustal atrybuty dla nowej bryły";
            // 
            // trbPromienBryly
            // 
            this.trbPromienBryly.Location = new System.Drawing.Point(17, 121);
            this.trbPromienBryly.Maximum = 100;
            this.trbPromienBryly.Minimum = 10;
            this.trbPromienBryly.Name = "trbPromienBryly";
            this.trbPromienBryly.Size = new System.Drawing.Size(104, 45);
            this.trbPromienBryly.TabIndex = 10;
            this.trbPromienBryly.Value = 45;
            this.trbPromienBryly.Scroll += new System.EventHandler(this.trbPromienBryly_Scroll);
            // 
            // cmbStylLinii
            // 
            this.cmbStylLinii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStylLinii.FormattingEnabled = true;
            this.cmbStylLinii.Items.AddRange(new object[] {
            "Linia ciągła",
            "Linia kreskowa",
            "Linia kropkowa",
            "Linia kreskowo - korpkowa",
            "Linia kreskowo - kropkowa - kropkowa"});
            this.cmbStylLinii.Location = new System.Drawing.Point(23, 309);
            this.cmbStylLinii.Name = "cmbStylLinii";
            this.cmbStylLinii.Size = new System.Drawing.Size(132, 27);
            this.cmbStylLinii.TabIndex = 9;
            this.cmbStylLinii.Text = "Ustaw styl linii";
            // 
            // btnKolorLinii
            // 
            this.btnKolorLinii.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKolorLinii.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolorLinii.Location = new System.Drawing.Point(20, 264);
            this.btnKolorLinii.Name = "btnKolorLinii";
            this.btnKolorLinii.Size = new System.Drawing.Size(161, 29);
            this.btnKolorLinii.TabIndex = 2;
            this.btnKolorLinii.Text = "Ustaw kolor linii";
            this.btnKolorLinii.UseVisualStyleBackColor = false;
            this.btnKolorLinii.Click += new System.EventHandler(this.btnKolorLinii_Click);
            // 
            // lblGruboscLinii
            // 
            this.lblGruboscLinii.AutoSize = true;
            this.lblGruboscLinii.Location = new System.Drawing.Point(110, 210);
            this.lblGruboscLinii.Name = "lblGruboscLinii";
            this.lblGruboscLinii.Size = new System.Drawing.Size(47, 13);
            this.lblGruboscLinii.TabIndex = 8;
            this.lblGruboscLinii.Text = "Wartość";
            // 
            // trbGruboscLinii
            // 
            this.trbGruboscLinii.Location = new System.Drawing.Point(23, 226);
            this.trbGruboscLinii.Name = "trbGruboscLinii";
            this.trbGruboscLinii.Size = new System.Drawing.Size(104, 45);
            this.trbGruboscLinii.TabIndex = 7;
            this.trbGruboscLinii.Scroll += new System.EventHandler(this.trbGruboscLinii_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grubość linii";
            // 
            // numStopieńWielokąta
            // 
            this.numStopieńWielokąta.Location = new System.Drawing.Point(117, 175);
            this.numStopieńWielokąta.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numStopieńWielokąta.Name = "numStopieńWielokąta";
            this.numStopieńWielokąta.Size = new System.Drawing.Size(53, 20);
            this.numStopieńWielokąta.TabIndex = 5;
            this.numStopieńWielokąta.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stopień wielokąta \r\npodstawy BG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPromienBG
            // 
            this.lblPromienBG.AutoSize = true;
            this.lblPromienBG.Location = new System.Drawing.Point(107, 97);
            this.lblPromienBG.Name = "lblPromienBG";
            this.lblPromienBG.Size = new System.Drawing.Size(47, 13);
            this.lblPromienBG.TabIndex = 2;
            this.lblPromienBG.Text = "Wartość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promień BG";
            // 
            // lblWysokoscBryly
            // 
            this.lblWysokoscBryly.AutoSize = true;
            this.lblWysokoscBryly.Location = new System.Drawing.Point(107, 30);
            this.lblWysokoscBryly.Name = "lblWysokoscBryly";
            this.lblWysokoscBryly.Size = new System.Drawing.Size(47, 13);
            this.lblWysokoscBryly.TabIndex = 2;
            this.lblWysokoscBryly.Text = "Wartość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wysokość BG";
            // 
            // trbWysokoscBryly
            // 
            this.trbWysokoscBryly.Location = new System.Drawing.Point(17, 49);
            this.trbWysokoscBryly.Maximum = 100;
            this.trbWysokoscBryly.Minimum = 10;
            this.trbWysokoscBryly.Name = "trbWysokoscBryly";
            this.trbWysokoscBryly.Size = new System.Drawing.Size(104, 45);
            this.trbWysokoscBryly.TabIndex = 0;
            this.trbWysokoscBryly.Value = 45;
            this.trbWysokoscBryly.Scroll += new System.EventHandler(this.trbWysokoscBryly_Scroll);
            // 
            // cmbBrylyGeometryczne
            // 
            this.cmbBrylyGeometryczne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBrylyGeometryczne.FormattingEnabled = true;
            this.cmbBrylyGeometryczne.Items.AddRange(new object[] {
            "Walec",
            "Stożek",
            "Kula"});
            this.cmbBrylyGeometryczne.Location = new System.Drawing.Point(23, 12);
            this.cmbBrylyGeometryczne.Name = "cmbBrylyGeometryczne";
            this.cmbBrylyGeometryczne.Size = new System.Drawing.Size(152, 27);
            this.cmbBrylyGeometryczne.TabIndex = 16;
            this.cmbBrylyGeometryczne.Text = "Wybierz nową bryłę";
            this.cmbBrylyGeometryczne.SelectedIndexChanged += new System.EventHandler(this.cmbBrylyGeometryczne_SelectedIndexChanged);
            // 
            // ZegarObrotu
            // 
            this.ZegarObrotu.Tick += new System.EventHandler(this.ZegarObrotu_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gpbKryteriaPokazu
            // 
            this.gpbKryteriaPokazu.Controls.Add(this.rdbPoleCalkowite);
            this.gpbKryteriaPokazu.Controls.Add(this.rdbObjetosc);
            this.gpbKryteriaPokazu.Controls.Add(this.rdbWysokosc);
            this.gpbKryteriaPokazu.Enabled = false;
            this.gpbKryteriaPokazu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpbKryteriaPokazu.Location = new System.Drawing.Point(306, 577);
            this.gpbKryteriaPokazu.Name = "gpbKryteriaPokazu";
            this.gpbKryteriaPokazu.Size = new System.Drawing.Size(365, 70);
            this.gpbKryteriaPokazu.TabIndex = 51;
            this.gpbKryteriaPokazu.TabStop = false;
            this.gpbKryteriaPokazu.Text = "Kryteria pokazu brył geometrycznych";
            // 
            // rdbPoleCalkowite
            // 
            this.rdbPoleCalkowite.AutoSize = true;
            this.rdbPoleCalkowite.Location = new System.Drawing.Point(214, 32);
            this.rdbPoleCalkowite.Name = "rdbPoleCalkowite";
            this.rdbPoleCalkowite.Size = new System.Drawing.Size(130, 23);
            this.rdbPoleCalkowite.TabIndex = 2;
            this.rdbPoleCalkowite.Text = "Pole powierzchni";
            this.rdbPoleCalkowite.UseVisualStyleBackColor = true;
            // 
            // rdbObjetosc
            // 
            this.rdbObjetosc.AutoSize = true;
            this.rdbObjetosc.Location = new System.Drawing.Point(116, 32);
            this.rdbObjetosc.Name = "rdbObjetosc";
            this.rdbObjetosc.Size = new System.Drawing.Size(83, 23);
            this.rdbObjetosc.TabIndex = 1;
            this.rdbObjetosc.Text = "Objętość";
            this.rdbObjetosc.UseVisualStyleBackColor = true;
            // 
            // rdbWysokosc
            // 
            this.rdbWysokosc.AutoSize = true;
            this.rdbWysokosc.Checked = true;
            this.rdbWysokosc.Location = new System.Drawing.Point(23, 32);
            this.rdbWysokosc.Name = "rdbWysokosc";
            this.rdbWysokosc.Size = new System.Drawing.Size(91, 23);
            this.rdbWysokosc.TabIndex = 0;
            this.rdbWysokosc.TabStop = true;
            this.rdbWysokosc.Text = "Wysokosc";
            this.rdbWysokosc.UseVisualStyleBackColor = true;
            // 
            // txtN
            // 
            this.txtN.AutoSize = true;
            this.txtN.Enabled = false;
            this.txtN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtN.Location = new System.Drawing.Point(1119, 290);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(17, 19);
            this.txtN.TabIndex = 66;
            this.txtN.Text = "0";
            // 
            // gpbWyborSlajdu
            // 
            this.gpbWyborSlajdu.Controls.Add(this.rdbPrzyciskowy);
            this.gpbWyborSlajdu.Controls.Add(this.rdbZegarowy);
            this.gpbWyborSlajdu.Enabled = false;
            this.gpbWyborSlajdu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpbWyborSlajdu.Location = new System.Drawing.Point(1033, 67);
            this.gpbWyborSlajdu.Name = "gpbWyborSlajdu";
            this.gpbWyborSlajdu.Size = new System.Drawing.Size(200, 84);
            this.gpbWyborSlajdu.TabIndex = 65;
            this.gpbWyborSlajdu.TabStop = false;
            this.gpbWyborSlajdu.Text = "Pokaz Slajdów";
            // 
            // rdbPrzyciskowy
            // 
            this.rdbPrzyciskowy.AutoSize = true;
            this.rdbPrzyciskowy.Location = new System.Drawing.Point(15, 53);
            this.rdbPrzyciskowy.Name = "rdbPrzyciskowy";
            this.rdbPrzyciskowy.Size = new System.Drawing.Size(104, 23);
            this.rdbPrzyciskowy.TabIndex = 1;
            this.rdbPrzyciskowy.TabStop = true;
            this.rdbPrzyciskowy.Text = "Przyciskowy";
            this.rdbPrzyciskowy.UseVisualStyleBackColor = true;
            // 
            // rdbZegarowy
            // 
            this.rdbZegarowy.AutoSize = true;
            this.rdbZegarowy.Checked = true;
            this.rdbZegarowy.Location = new System.Drawing.Point(15, 25);
            this.rdbZegarowy.Name = "rdbZegarowy";
            this.rdbZegarowy.Size = new System.Drawing.Size(88, 23);
            this.rdbZegarowy.TabIndex = 0;
            this.rdbZegarowy.TabStop = true;
            this.rdbZegarowy.Text = "Zegarowy";
            this.rdbZegarowy.UseVisualStyleBackColor = true;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Enabled = false;
            this.lblN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblN.Location = new System.Drawing.Point(1086, 263);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(85, 19);
            this.lblN.TabIndex = 64;
            this.lblN.Text = "Numer bryły";
            // 
            // btnWylaczSlajder
            // 
            this.btnWylaczSlajder.Enabled = false;
            this.btnWylaczSlajder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylaczSlajder.Location = new System.Drawing.Point(1023, 410);
            this.btnWylaczSlajder.Name = "btnWylaczSlajder";
            this.btnWylaczSlajder.Size = new System.Drawing.Size(228, 58);
            this.btnWylaczSlajder.TabIndex = 63;
            this.btnWylaczSlajder.Text = "Wylacz slajder";
            this.btnWylaczSlajder.UseVisualStyleBackColor = true;
            this.btnWylaczSlajder.Click += new System.EventHandler(this.btnWylaczSlajder_Click);
            // 
            // btnPoprzednia
            // 
            this.btnPoprzednia.Enabled = false;
            this.btnPoprzednia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoprzednia.Location = new System.Drawing.Point(1150, 338);
            this.btnPoprzednia.Name = "btnPoprzednia";
            this.btnPoprzednia.Size = new System.Drawing.Size(115, 58);
            this.btnPoprzednia.TabIndex = 62;
            this.btnPoprzednia.Text = "Poprzednia";
            this.btnPoprzednia.UseVisualStyleBackColor = true;
            this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
            // 
            // btnNastepna
            // 
            this.btnNastepna.Enabled = false;
            this.btnNastepna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNastepna.Location = new System.Drawing.Point(1007, 338);
            this.btnNastepna.Name = "btnNastepna";
            this.btnNastepna.Size = new System.Drawing.Size(115, 58);
            this.btnNastepna.TabIndex = 61;
            this.btnNastepna.Text = "Następna";
            this.btnNastepna.UseVisualStyleBackColor = true;
            this.btnNastepna.Click += new System.EventHandler(this.btnNastepna_Click);
            // 
            // btnWlaczSlajder
            // 
            this.btnWlaczSlajder.Enabled = false;
            this.btnWlaczSlajder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWlaczSlajder.Location = new System.Drawing.Point(1023, 194);
            this.btnWlaczSlajder.Name = "btnWlaczSlajder";
            this.btnWlaczSlajder.Size = new System.Drawing.Size(228, 58);
            this.btnWlaczSlajder.TabIndex = 60;
            this.btnWlaczSlajder.Text = "Włącz slajder";
            this.btnWlaczSlajder.UseVisualStyleBackColor = true;
            this.btnWlaczSlajder.Click += new System.EventHandler(this.btnWlaczSlajder_Click);
            // 
            // ZegarSlajder
            // 
            this.ZegarSlajder.Interval = 1000;
            this.ZegarSlajder.Tick += new System.EventHandler(this.ZegarSlajder_Tick);
            // 
            // ZegarObrotowy
            // 
            this.ZegarObrotowy.Tick += new System.EventHandler(this.ZegarObrotowy_Tick);
            // 
            // btnKierunekLewo
            // 
            this.btnKierunekLewo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKierunekLewo.Location = new System.Drawing.Point(1023, 502);
            this.btnKierunekLewo.Name = "btnKierunekLewo";
            this.btnKierunekLewo.Size = new System.Drawing.Size(228, 58);
            this.btnKierunekLewo.TabIndex = 67;
            this.btnKierunekLewo.Text = "Kierunek obrotu w lewo";
            this.btnKierunekLewo.UseVisualStyleBackColor = true;
            this.btnKierunekLewo.Click += new System.EventHandler(this.btnKierunekLewo_Click);
            // 
            // btnKierunekPrawo
            // 
            this.btnKierunekPrawo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKierunekPrawo.Location = new System.Drawing.Point(1023, 577);
            this.btnKierunekPrawo.Name = "btnKierunekPrawo";
            this.btnKierunekPrawo.Size = new System.Drawing.Size(228, 58);
            this.btnKierunekPrawo.TabIndex = 68;
            this.btnKierunekPrawo.Text = "Kierunek obrotu w prawo";
            this.btnKierunekPrawo.UseVisualStyleBackColor = true;
            this.btnKierunekPrawo.Click += new System.EventHandler(this.btnKierunekPrawo_Click);
            // 
            // LaboratoriumNr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 666);
            this.Controls.Add(this.btnKierunekPrawo);
            this.Controls.Add(this.btnKierunekLewo);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.gpbWyborSlajdu);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnWylaczSlajder);
            this.Controls.Add(this.btnPoprzednia);
            this.Controls.Add(this.btnNastepna);
            this.Controls.Add(this.btnWlaczSlajder);
            this.Controls.Add(this.gpbKryteriaPokazu);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnDodajNowaBG);
            this.Controls.Add(this.gpbAtrybutyBG);
            this.Controls.Add(this.cmbBrylyGeometryczne);
            this.Name = "LaboratoriumNr3";
            this.Text = "LaboratoriumNr3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.gpbAtrybutyBG.ResumeLayout(false);
            this.gpbAtrybutyBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPromienBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGruboscLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopieńWielokąta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokoscBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpbKryteriaPokazu.ResumeLayout(false);
            this.gpbKryteriaPokazu.PerformLayout();
            this.gpbWyborSlajdu.ResumeLayout(false);
            this.gpbWyborSlajdu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Button btnDodajNowaBG;
        private System.Windows.Forms.GroupBox gpbAtrybutyBG;
        private System.Windows.Forms.TrackBar trbPromienBryly;
        private System.Windows.Forms.ComboBox cmbStylLinii;
        private System.Windows.Forms.Button btnKolorLinii;
        private System.Windows.Forms.Label lblGruboscLinii;
        private System.Windows.Forms.TrackBar trbGruboscLinii;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStopieńWielokąta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPromienBG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWysokoscBryly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbWysokoscBryly;
        private System.Windows.Forms.ComboBox cmbBrylyGeometryczne;
        private System.Windows.Forms.Timer ZegarObrotu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gpbKryteriaPokazu;
        public System.Windows.Forms.RadioButton rdbPoleCalkowite;
        public System.Windows.Forms.RadioButton rdbObjetosc;
        public System.Windows.Forms.RadioButton rdbWysokosc;
        private System.Windows.Forms.Label txtN;
        private System.Windows.Forms.GroupBox gpbWyborSlajdu;
        private System.Windows.Forms.RadioButton rdbPrzyciskowy;
        private System.Windows.Forms.RadioButton rdbZegarowy;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button btnWylaczSlajder;
        private System.Windows.Forms.Button btnPoprzednia;
        private System.Windows.Forms.Button btnNastepna;
        private System.Windows.Forms.Button btnWlaczSlajder;
        private System.Windows.Forms.Timer ZegarSlajder;
        private System.Windows.Forms.Timer ZegarObrotowy;
        private System.Windows.Forms.Button btnKierunekPrawo;
        private System.Windows.Forms.Button btnKierunekLewo;
    }
}