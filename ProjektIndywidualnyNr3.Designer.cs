namespace Projekt3_Piwowarski62024
{
    partial class ProjektIndywidualnyNr3
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
            this.lblKierunekObrotu = new System.Windows.Forms.Label();
            this.btnKierunekWPrawo = new System.Windows.Forms.Button();
            this.btnKierunekWLewo = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.Label();
            this.btnWylaczObrot = new System.Windows.Forms.Button();
            this.btnWlaczObrot = new System.Windows.Forms.Button();
            this.gpbWyborSlajdu = new System.Windows.Forms.GroupBox();
            this.rdbPrzyciskowy = new System.Windows.Forms.RadioButton();
            this.rdbZegarowy = new System.Windows.Forms.RadioButton();
            this.lblN = new System.Windows.Forms.Label();
            this.btnWylaczSlajder = new System.Windows.Forms.Button();
            this.btnPoprzednia = new System.Windows.Forms.Button();
            this.btnNastepna = new System.Windows.Forms.Button();
            this.btnWlaczSlajder = new System.Windows.Forms.Button();
            this.gpbKryteriaPokazu = new System.Windows.Forms.GroupBox();
            this.rdbPoleCalkowite = new System.Windows.Forms.RadioButton();
            this.rdbObjetosc = new System.Windows.Forms.RadioButton();
            this.rdbWysokosc = new System.Windows.Forms.RadioButton();
            this.btnWylosujNowePolozenie = new System.Windows.Forms.Button();
            this.numNumerBryly = new System.Windows.Forms.NumericUpDown();
            this.lblNumerBryly = new System.Windows.Forms.Label();
            this.btnUsunWybranaBryle = new System.Windows.Forms.Button();
            this.btnUsunPierwszaBryle = new System.Windows.Forms.Button();
            this.btnUsunOstatniaBryle = new System.Windows.Forms.Button();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.btnDodajNowaBG = new System.Windows.Forms.Button();
            this.gpbAtrybutyBG = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trbKatPochylenia = new System.Windows.Forms.TrackBar();
            this.lblKatPochylenia = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ZegarObrotu = new System.Windows.Forms.Timer(this.components);
            this.ZegarSlajder = new System.Windows.Forms.Timer(this.components);
            this.gpbWyborSlajdu.SuspendLayout();
            this.gpbKryteriaPokazu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.gpbAtrybutyBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbKatPochylenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPromienBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGruboscLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopieńWielokąta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokoscBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKierunekObrotu
            // 
            this.lblKierunekObrotu.AutoSize = true;
            this.lblKierunekObrotu.Enabled = false;
            this.lblKierunekObrotu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKierunekObrotu.Location = new System.Drawing.Point(1057, 570);
            this.lblKierunekObrotu.Name = "lblKierunekObrotu";
            this.lblKierunekObrotu.Size = new System.Drawing.Size(159, 19);
            this.lblKierunekObrotu.TabIndex = 62;
            this.lblKierunekObrotu.Text = "Wybierz kierunek obrotu";
            // 
            // btnKierunekWPrawo
            // 
            this.btnKierunekWPrawo.Enabled = false;
            this.btnKierunekWPrawo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKierunekWPrawo.Location = new System.Drawing.Point(1136, 602);
            this.btnKierunekWPrawo.Name = "btnKierunekWPrawo";
            this.btnKierunekWPrawo.Size = new System.Drawing.Size(60, 31);
            this.btnKierunekWPrawo.TabIndex = 61;
            this.btnKierunekWPrawo.Text = "Prawo";
            this.btnKierunekWPrawo.UseVisualStyleBackColor = true;
            this.btnKierunekWPrawo.Click += new System.EventHandler(this.btnKierunekWPrawo_Click);
            // 
            // btnKierunekWLewo
            // 
            this.btnKierunekWLewo.Enabled = false;
            this.btnKierunekWLewo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKierunekWLewo.Location = new System.Drawing.Point(1070, 602);
            this.btnKierunekWLewo.Name = "btnKierunekWLewo";
            this.btnKierunekWLewo.Size = new System.Drawing.Size(60, 31);
            this.btnKierunekWLewo.TabIndex = 60;
            this.btnKierunekWLewo.Text = "Lewo";
            this.btnKierunekWLewo.UseVisualStyleBackColor = true;
            this.btnKierunekWLewo.Click += new System.EventHandler(this.btnKierunekWLewo_Click);
            // 
            // txtN
            // 
            this.txtN.AutoSize = true;
            this.txtN.Enabled = false;
            this.txtN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtN.Location = new System.Drawing.Point(1116, 295);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(17, 19);
            this.txtN.TabIndex = 59;
            this.txtN.Text = "0";
            // 
            // btnWylaczObrot
            // 
            this.btnWylaczObrot.Enabled = false;
            this.btnWylaczObrot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylaczObrot.Location = new System.Drawing.Point(1045, 639);
            this.btnWylaczObrot.Name = "btnWylaczObrot";
            this.btnWylaczObrot.Size = new System.Drawing.Size(185, 41);
            this.btnWylaczObrot.TabIndex = 58;
            this.btnWylaczObrot.Text = "Wyłącz obrót brył";
            this.btnWylaczObrot.UseVisualStyleBackColor = true;
            this.btnWylaczObrot.Click += new System.EventHandler(this.btnWylaczObrot_Click);
            // 
            // btnWlaczObrot
            // 
            this.btnWlaczObrot.Enabled = false;
            this.btnWlaczObrot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWlaczObrot.Location = new System.Drawing.Point(1045, 518);
            this.btnWlaczObrot.Name = "btnWlaczObrot";
            this.btnWlaczObrot.Size = new System.Drawing.Size(185, 41);
            this.btnWlaczObrot.TabIndex = 57;
            this.btnWlaczObrot.Text = "Włącz obrót brył";
            this.btnWlaczObrot.UseVisualStyleBackColor = true;
            this.btnWlaczObrot.Click += new System.EventHandler(this.btnWlaczObrot_Click);
            // 
            // gpbWyborSlajdu
            // 
            this.gpbWyborSlajdu.Controls.Add(this.rdbPrzyciskowy);
            this.gpbWyborSlajdu.Controls.Add(this.rdbZegarowy);
            this.gpbWyborSlajdu.Enabled = false;
            this.gpbWyborSlajdu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpbWyborSlajdu.Location = new System.Drawing.Point(1030, 72);
            this.gpbWyborSlajdu.Name = "gpbWyborSlajdu";
            this.gpbWyborSlajdu.Size = new System.Drawing.Size(200, 84);
            this.gpbWyborSlajdu.TabIndex = 56;
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
            this.lblN.Location = new System.Drawing.Point(1083, 268);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(85, 19);
            this.lblN.TabIndex = 55;
            this.lblN.Text = "Numer bryły";
            // 
            // btnWylaczSlajder
            // 
            this.btnWylaczSlajder.Enabled = false;
            this.btnWylaczSlajder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylaczSlajder.Location = new System.Drawing.Point(1020, 415);
            this.btnWylaczSlajder.Name = "btnWylaczSlajder";
            this.btnWylaczSlajder.Size = new System.Drawing.Size(228, 58);
            this.btnWylaczSlajder.TabIndex = 54;
            this.btnWylaczSlajder.Text = "Wylacz slajder";
            this.btnWylaczSlajder.UseVisualStyleBackColor = true;
            this.btnWylaczSlajder.Click += new System.EventHandler(this.btnWylaczSlajder_Click);
            // 
            // btnPoprzednia
            // 
            this.btnPoprzednia.Enabled = false;
            this.btnPoprzednia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoprzednia.Location = new System.Drawing.Point(1147, 343);
            this.btnPoprzednia.Name = "btnPoprzednia";
            this.btnPoprzednia.Size = new System.Drawing.Size(115, 58);
            this.btnPoprzednia.TabIndex = 53;
            this.btnPoprzednia.Text = "Poprzednia";
            this.btnPoprzednia.UseVisualStyleBackColor = true;
            this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
            // 
            // btnNastepna
            // 
            this.btnNastepna.Enabled = false;
            this.btnNastepna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNastepna.Location = new System.Drawing.Point(1004, 343);
            this.btnNastepna.Name = "btnNastepna";
            this.btnNastepna.Size = new System.Drawing.Size(115, 58);
            this.btnNastepna.TabIndex = 52;
            this.btnNastepna.Text = "Następna";
            this.btnNastepna.UseVisualStyleBackColor = true;
            this.btnNastepna.Click += new System.EventHandler(this.btnNastepna_Click);
            // 
            // btnWlaczSlajder
            // 
            this.btnWlaczSlajder.Enabled = false;
            this.btnWlaczSlajder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWlaczSlajder.Location = new System.Drawing.Point(1020, 199);
            this.btnWlaczSlajder.Name = "btnWlaczSlajder";
            this.btnWlaczSlajder.Size = new System.Drawing.Size(228, 58);
            this.btnWlaczSlajder.TabIndex = 51;
            this.btnWlaczSlajder.Text = "Włącz slajder";
            this.btnWlaczSlajder.UseVisualStyleBackColor = true;
            this.btnWlaczSlajder.Click += new System.EventHandler(this.btnWlaczSlajder_Click);
            // 
            // gpbKryteriaPokazu
            // 
            this.gpbKryteriaPokazu.Controls.Add(this.rdbPoleCalkowite);
            this.gpbKryteriaPokazu.Controls.Add(this.rdbObjetosc);
            this.gpbKryteriaPokazu.Controls.Add(this.rdbWysokosc);
            this.gpbKryteriaPokazu.Enabled = false;
            this.gpbKryteriaPokazu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpbKryteriaPokazu.Location = new System.Drawing.Point(334, 633);
            this.gpbKryteriaPokazu.Name = "gpbKryteriaPokazu";
            this.gpbKryteriaPokazu.Size = new System.Drawing.Size(365, 70);
            this.gpbKryteriaPokazu.TabIndex = 50;
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
            // btnWylosujNowePolozenie
            // 
            this.btnWylosujNowePolozenie.Enabled = false;
            this.btnWylosujNowePolozenie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylosujNowePolozenie.Location = new System.Drawing.Point(706, 12);
            this.btnWylosujNowePolozenie.Name = "btnWylosujNowePolozenie";
            this.btnWylosujNowePolozenie.Size = new System.Drawing.Size(185, 41);
            this.btnWylosujNowePolozenie.TabIndex = 49;
            this.btnWylosujNowePolozenie.Text = "Wylosuj nowe położenie";
            this.btnWylosujNowePolozenie.UseVisualStyleBackColor = true;
            this.btnWylosujNowePolozenie.Click += new System.EventHandler(this.btnWylosujNowePolozenie_Click);
            // 
            // numNumerBryly
            // 
            this.numNumerBryly.Enabled = false;
            this.numNumerBryly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numNumerBryly.Location = new System.Drawing.Point(647, 18);
            this.numNumerBryly.Name = "numNumerBryly";
            this.numNumerBryly.Size = new System.Drawing.Size(39, 26);
            this.numNumerBryly.TabIndex = 48;
            // 
            // lblNumerBryly
            // 
            this.lblNumerBryly.AutoSize = true;
            this.lblNumerBryly.Enabled = false;
            this.lblNumerBryly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerBryly.Location = new System.Drawing.Point(483, 12);
            this.lblNumerBryly.Name = "lblNumerBryly";
            this.lblNumerBryly.Size = new System.Drawing.Size(150, 38);
            this.lblNumerBryly.TabIndex = 47;
            this.lblNumerBryly.Text = "Podaj numer usuwanej \r\nbryły";
            this.lblNumerBryly.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUsunWybranaBryle
            // 
            this.btnUsunWybranaBryle.Enabled = false;
            this.btnUsunWybranaBryle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunWybranaBryle.Location = new System.Drawing.Point(264, 9);
            this.btnUsunWybranaBryle.Name = "btnUsunWybranaBryle";
            this.btnUsunWybranaBryle.Size = new System.Drawing.Size(194, 41);
            this.btnUsunWybranaBryle.TabIndex = 46;
            this.btnUsunWybranaBryle.Text = "Usuń wybraną bryłę";
            this.btnUsunWybranaBryle.UseVisualStyleBackColor = true;
            this.btnUsunWybranaBryle.Click += new System.EventHandler(this.btnUsunWybranaBryle_Click);
            // 
            // btnUsunPierwszaBryle
            // 
            this.btnUsunPierwszaBryle.Enabled = false;
            this.btnUsunPierwszaBryle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunPierwszaBryle.Location = new System.Drawing.Point(9, 617);
            this.btnUsunPierwszaBryle.Name = "btnUsunPierwszaBryle";
            this.btnUsunPierwszaBryle.Size = new System.Drawing.Size(209, 41);
            this.btnUsunPierwszaBryle.TabIndex = 45;
            this.btnUsunPierwszaBryle.Text = "Usuń pierwszą dodaną bryłę";
            this.btnUsunPierwszaBryle.UseVisualStyleBackColor = true;
            this.btnUsunPierwszaBryle.Click += new System.EventHandler(this.btnUsunPierwszaBryle_Click);
            // 
            // btnUsunOstatniaBryle
            // 
            this.btnUsunOstatniaBryle.Enabled = false;
            this.btnUsunOstatniaBryle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunOstatniaBryle.Location = new System.Drawing.Point(9, 570);
            this.btnUsunOstatniaBryle.Name = "btnUsunOstatniaBryle";
            this.btnUsunOstatniaBryle.Size = new System.Drawing.Size(209, 41);
            this.btnUsunOstatniaBryle.TabIndex = 44;
            this.btnUsunOstatniaBryle.Text = "Usuń ostatnią dodaną bryłę";
            this.btnUsunOstatniaBryle.UseVisualStyleBackColor = true;
            this.btnUsunOstatniaBryle.Click += new System.EventHandler(this.btnUsunOstatniaBryle_Click);
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pbRysownica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRysownica.Location = new System.Drawing.Point(226, 62);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(762, 549);
            this.pbRysownica.TabIndex = 43;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseClick);
            // 
            // btnDodajNowaBG
            // 
            this.btnDodajNowaBG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNowaBG.Location = new System.Drawing.Point(26, 530);
            this.btnDodajNowaBG.Name = "btnDodajNowaBG";
            this.btnDodajNowaBG.Size = new System.Drawing.Size(158, 29);
            this.btnDodajNowaBG.TabIndex = 42;
            this.btnDodajNowaBG.Text = "Dodaj nową BG";
            this.btnDodajNowaBG.UseVisualStyleBackColor = true;
            this.btnDodajNowaBG.Click += new System.EventHandler(this.btnDodajNowaBG_Click);
            // 
            // gpbAtrybutyBG
            // 
            this.gpbAtrybutyBG.Controls.Add(this.label5);
            this.gpbAtrybutyBG.Controls.Add(this.trbKatPochylenia);
            this.gpbAtrybutyBG.Controls.Add(this.lblKatPochylenia);
            this.gpbAtrybutyBG.Controls.Add(this.label);
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
            this.gpbAtrybutyBG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpbAtrybutyBG.Location = new System.Drawing.Point(6, 50);
            this.gpbAtrybutyBG.Name = "gpbAtrybutyBG";
            this.gpbAtrybutyBG.Size = new System.Drawing.Size(211, 461);
            this.gpbAtrybutyBG.TabIndex = 41;
            this.gpbAtrybutyBG.TabStop = false;
            this.gpbAtrybutyBG.Text = "Ustal atrybuty dla nowej bryły";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ustaw kolor linii";
            // 
            // trbKatPochylenia
            // 
            this.trbKatPochylenia.Location = new System.Drawing.Point(15, 327);
            this.trbKatPochylenia.Maximum = 180;
            this.trbKatPochylenia.Minimum = 10;
            this.trbKatPochylenia.Name = "trbKatPochylenia";
            this.trbKatPochylenia.Size = new System.Drawing.Size(172, 45);
            this.trbKatPochylenia.TabIndex = 13;
            this.trbKatPochylenia.Value = 90;
            this.trbKatPochylenia.Scroll += new System.EventHandler(this.trbKatPochylenia_Scroll);
            // 
            // lblKatPochylenia
            // 
            this.lblKatPochylenia.AutoSize = true;
            this.lblKatPochylenia.Location = new System.Drawing.Point(145, 293);
            this.lblKatPochylenia.Name = "lblKatPochylenia";
            this.lblKatPochylenia.Size = new System.Drawing.Size(60, 19);
            this.lblKatPochylenia.TabIndex = 12;
            this.lblKatPochylenia.Text = "Wartość";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 293);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(125, 19);
            this.label.TabIndex = 11;
            this.label.Text = "Kąt pochylenia BG";
            // 
            // trbPromienBryly
            // 
            this.trbPromienBryly.Location = new System.Drawing.Point(9, 121);
            this.trbPromienBryly.Maximum = 100;
            this.trbPromienBryly.Minimum = 10;
            this.trbPromienBryly.Name = "trbPromienBryly";
            this.trbPromienBryly.Size = new System.Drawing.Size(178, 45);
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
            this.cmbStylLinii.Location = new System.Drawing.Point(38, 424);
            this.cmbStylLinii.Name = "cmbStylLinii";
            this.cmbStylLinii.Size = new System.Drawing.Size(132, 27);
            this.cmbStylLinii.TabIndex = 9;
            this.cmbStylLinii.Text = "Ustaw styl linii";
            // 
            // btnKolorLinii
            // 
            this.btnKolorLinii.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKolorLinii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolorLinii.Location = new System.Drawing.Point(20, 389);
            this.btnKolorLinii.Name = "btnKolorLinii";
            this.btnKolorLinii.Size = new System.Drawing.Size(161, 29);
            this.btnKolorLinii.TabIndex = 2;
            this.btnKolorLinii.UseVisualStyleBackColor = false;
            this.btnKolorLinii.Click += new System.EventHandler(this.btnKolorLinii_Click);
            // 
            // lblGruboscLinii
            // 
            this.lblGruboscLinii.AutoSize = true;
            this.lblGruboscLinii.Location = new System.Drawing.Point(109, 218);
            this.lblGruboscLinii.Name = "lblGruboscLinii";
            this.lblGruboscLinii.Size = new System.Drawing.Size(60, 19);
            this.lblGruboscLinii.TabIndex = 8;
            this.lblGruboscLinii.Text = "Wartość";
            // 
            // trbGruboscLinii
            // 
            this.trbGruboscLinii.Location = new System.Drawing.Point(15, 245);
            this.trbGruboscLinii.Name = "trbGruboscLinii";
            this.trbGruboscLinii.Size = new System.Drawing.Size(165, 45);
            this.trbGruboscLinii.TabIndex = 7;
            this.trbGruboscLinii.Value = 3;
            this.trbGruboscLinii.Scroll += new System.EventHandler(this.trbGruboscLinii_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grubość linii";
            // 
            // numStopieńWielokąta
            // 
            this.numStopieńWielokąta.Location = new System.Drawing.Point(138, 172);
            this.numStopieńWielokąta.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numStopieńWielokąta.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numStopieńWielokąta.Name = "numStopieńWielokąta";
            this.numStopieńWielokąta.Size = new System.Drawing.Size(53, 26);
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
            this.label3.Location = new System.Drawing.Point(11, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stopień wielokąta \r\npodstawy BG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPromienBG
            // 
            this.lblPromienBG.AutoSize = true;
            this.lblPromienBG.Location = new System.Drawing.Point(118, 97);
            this.lblPromienBG.Name = "lblPromienBG";
            this.lblPromienBG.Size = new System.Drawing.Size(60, 19);
            this.lblPromienBG.TabIndex = 2;
            this.lblPromienBG.Text = "Wartość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promień BG";
            // 
            // lblWysokoscBryly
            // 
            this.lblWysokoscBryly.AutoSize = true;
            this.lblWysokoscBryly.Location = new System.Drawing.Point(122, 27);
            this.lblWysokoscBryly.Name = "lblWysokoscBryly";
            this.lblWysokoscBryly.Size = new System.Drawing.Size(60, 19);
            this.lblWysokoscBryly.TabIndex = 2;
            this.lblWysokoscBryly.Text = "Wartość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wysokość BG";
            // 
            // trbWysokoscBryly
            // 
            this.trbWysokoscBryly.Location = new System.Drawing.Point(9, 49);
            this.trbWysokoscBryly.Maximum = 100;
            this.trbWysokoscBryly.Minimum = 10;
            this.trbWysokoscBryly.Name = "trbWysokoscBryly";
            this.trbWysokoscBryly.Size = new System.Drawing.Size(173, 45);
            this.trbWysokoscBryly.TabIndex = 0;
            this.trbWysokoscBryly.Value = 45;
            this.trbWysokoscBryly.Scroll += new System.EventHandler(this.trbWysokoscBryly_Scroll);
            // 
            // cmbBrylyGeometryczne
            // 
            this.cmbBrylyGeometryczne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBrylyGeometryczne.FormattingEnabled = true;
            this.cmbBrylyGeometryczne.Items.AddRange(new object[] {
            "Graniastosłup",
            "Ostrosłup",
            "Graniastosłup pochyły",
            "Ostrosłup pochyły"});
            this.cmbBrylyGeometryczne.Location = new System.Drawing.Point(21, 17);
            this.cmbBrylyGeometryczne.Name = "cmbBrylyGeometryczne";
            this.cmbBrylyGeometryczne.Size = new System.Drawing.Size(152, 27);
            this.cmbBrylyGeometryczne.TabIndex = 40;
            this.cmbBrylyGeometryczne.Text = "Wybierz nową bryłę";
            this.cmbBrylyGeometryczne.SelectedIndexChanged += new System.EventHandler(this.cmbBrylyGeometryczne_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ZegarObrotu
            // 
            this.ZegarObrotu.Tick += new System.EventHandler(this.ZegarObrotu_Tick);
            // 
            // ZegarSlajder
            // 
            this.ZegarSlajder.Interval = 1000;
            this.ZegarSlajder.Tick += new System.EventHandler(this.ZegarSlajder_Tick);
            // 
            // ProjektIndywidualnyNr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 717);
            this.Controls.Add(this.lblKierunekObrotu);
            this.Controls.Add(this.btnKierunekWPrawo);
            this.Controls.Add(this.btnKierunekWLewo);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnWylaczObrot);
            this.Controls.Add(this.btnWlaczObrot);
            this.Controls.Add(this.gpbWyborSlajdu);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnWylaczSlajder);
            this.Controls.Add(this.btnPoprzednia);
            this.Controls.Add(this.btnNastepna);
            this.Controls.Add(this.btnWlaczSlajder);
            this.Controls.Add(this.gpbKryteriaPokazu);
            this.Controls.Add(this.btnWylosujNowePolozenie);
            this.Controls.Add(this.numNumerBryly);
            this.Controls.Add(this.lblNumerBryly);
            this.Controls.Add(this.btnUsunWybranaBryle);
            this.Controls.Add(this.btnUsunPierwszaBryle);
            this.Controls.Add(this.btnUsunOstatniaBryle);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnDodajNowaBG);
            this.Controls.Add(this.gpbAtrybutyBG);
            this.Controls.Add(this.cmbBrylyGeometryczne);
            this.Name = "ProjektIndywidualnyNr3";
            this.Text = "ProjektIndywidualnyNr3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjektIndywidualnyNr3_FormClosing);
            this.gpbWyborSlajdu.ResumeLayout(false);
            this.gpbWyborSlajdu.PerformLayout();
            this.gpbKryteriaPokazu.ResumeLayout(false);
            this.gpbKryteriaPokazu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.gpbAtrybutyBG.ResumeLayout(false);
            this.gpbAtrybutyBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbKatPochylenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPromienBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGruboscLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopieńWielokąta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokoscBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKierunekObrotu;
        private System.Windows.Forms.Button btnKierunekWPrawo;
        private System.Windows.Forms.Button btnKierunekWLewo;
        private System.Windows.Forms.Label txtN;
        private System.Windows.Forms.Button btnWylaczObrot;
        private System.Windows.Forms.Button btnWlaczObrot;
        private System.Windows.Forms.GroupBox gpbWyborSlajdu;
        private System.Windows.Forms.RadioButton rdbPrzyciskowy;
        private System.Windows.Forms.RadioButton rdbZegarowy;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button btnWylaczSlajder;
        private System.Windows.Forms.Button btnPoprzednia;
        private System.Windows.Forms.Button btnNastepna;
        private System.Windows.Forms.Button btnWlaczSlajder;
        private System.Windows.Forms.GroupBox gpbKryteriaPokazu;
        public System.Windows.Forms.RadioButton rdbPoleCalkowite;
        public System.Windows.Forms.RadioButton rdbObjetosc;
        public System.Windows.Forms.RadioButton rdbWysokosc;
        private System.Windows.Forms.Button btnWylosujNowePolozenie;
        private System.Windows.Forms.NumericUpDown numNumerBryly;
        private System.Windows.Forms.Label lblNumerBryly;
        private System.Windows.Forms.Button btnUsunWybranaBryle;
        private System.Windows.Forms.Button btnUsunPierwszaBryle;
        private System.Windows.Forms.Button btnUsunOstatniaBryle;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Button btnDodajNowaBG;
        private System.Windows.Forms.GroupBox gpbAtrybutyBG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trbKatPochylenia;
        private System.Windows.Forms.Label lblKatPochylenia;
        private System.Windows.Forms.Label label;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer ZegarObrotu;
        private System.Windows.Forms.Timer ZegarSlajder;
    }
}