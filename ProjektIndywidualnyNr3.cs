using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt3_Piwowarski62024.BrylyGeometryczne2;

namespace Projekt3_Piwowarski62024
{
    public partial class ProjektIndywidualnyNr3 : Form
    {
        //deklaracje pomocnicze
        const int apPromienPunktuLokalizacji = 2;
        Point apPunktLokalizacjiBryly = new Point(-1, -1);
        Graphics apRysownica;
        List<BrylaAbstrakcyjna> apLBG = new List<BrylaAbstrakcyjna>();
        float apKatObrotu;
        public static ProjektIndywidualnyNr3 apUchwytFormularza;
        public int apn = 0;

        public ProjektIndywidualnyNr3()
        {
            InitializeComponent();
            apUchwytFormularza = this;
            //lokalizacja i zwymiarowanie formualarza i kontrolki PictureBox
            //utworzenie Bitmapy
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //utowrzenie egzemplarza powierzchni graficznej na Bitmapie
            apRysownica = Graphics.FromImage(pbRysownica.Image);
            // wizualizacja domyślnych ustawień wartości atrybutów bryły
            lblWysokoscBryly.Text = trbWysokoscBryly.Value.ToString();
            lblPromienBG.Text = trbPromienBryly.Value.ToString();
            lblGruboscLinii.Text = trbGruboscLinii.Value.ToString();
            lblKatPochylenia.Text = trbKatPochylenia.Value.ToString();
            txtN.Text = apn.ToString();
        }

        private void ProjektIndywidualnyNr3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // utworzenie okna dialogowego dla potwierdzenia zamknięcia formularza indywidualnego
            DialogResult apOknoMessage = MessageBox.Show("Samodzielnie zrealizowane zadanie projektowe Nr 3: 5.0,\ngdyż zostało wszystko zaimprementowane i dokładnie przetestowane", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            // rozpoznanie wybranej odpowiedzi Użytkownika programu
            if (apOknoMessage == DialogResult.Yes)
            {
                e.Cancel = false;
                // odszukanie egzemplarza formularza głównego w kolekcji OpenForms 
                foreach (Form apFormularz in Application.OpenForms)
                    // sprawdzamy, czy został znaleziony formularz główny
                    if (apFormularz.Name == "KokpitProjektuNr3")
                    {// ukrycie bieżącego formularza 
                        this.Hide();
                        // odsłonięcie znalezionego głównego formularza
                        apFormularz.Show();
                        // wyjście z metody obsługi zdarzenia FormClosing
                        return;
                    }
                // gdy będziemy tutaj, to będzie to oznaczało, że ktoś skasował formularz główny
                // utworzenie nowego egzemplarza formularza głównego KokpitProjektuNr3
                KokpitProjektuNr3 apFormularzKokpitProjektuNr3 = new KokpitProjektuNr3();
                // ukrycie bieżącego formularza 
                this.Hide();
                // odsłonięcie nowego formularza głównego
                this.Show();
            }
            else // anulujemy zmaknięcie formularza
                e.Cancel = true;
        }

        private void pbRysownica_MouseClick(object sender, MouseEventArgs e)
        {
            /* sprawdzenie, czy punkt lokalizacji bryły był już
            wybrany początkowe ustawienie:
            Point PunktLokalizacjiBryły = new Point(-1, -1);
            czyli punkt poza Rysownicą */
            if (apPunktLokalizacjiBryly.X != -1)
                /* utworzenie Pędzla o kolorze tła powierzchni
               graficznej: pbRysownica */
                using (SolidBrush apPędzel = new SolidBrush(pbRysownica.BackColor))
                    //wymazanie poprzedniego punktu lokalizacji bryły
                    apRysownica.FillEllipse(apPędzel, apPunktLokalizacjiBryly.X - apPromienPunktuLokalizacji, apPunktLokalizacjiBryly.Y - apPromienPunktuLokalizacji, 2 * apPromienPunktuLokalizacji, 2 * apPromienPunktuLokalizacji);
            //"zapamiętanie" nowej lokalizacji bryły
            apPunktLokalizacjiBryly = new Point(e.Location.X, e.Location.Y);
            /* wizualizacja nowego punktu lokalizacji bryły, czyli
           wykreślenie nowego punktu lokalizacji bryły */
            apRysownica.FillEllipse(Brushes.Red, apPunktLokalizacjiBryly.X - apPromienPunktuLokalizacji, apPunktLokalizacjiBryly.Y - apPromienPunktuLokalizacji, 2 * apPromienPunktuLokalizacji, 2 * apPromienPunktuLokalizacji);
            // odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void ZegarObrotu_Tick(object sender, EventArgs e)
        {
            apKatObrotu = 5F;
            for (int i = 0; i < apLBG.Count; i++)
                apLBG[i].Obroc_i_Wykresl(pbRysownica, apRysownica, apKatObrotu);
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnDodajNowaBG_Click(object sender, EventArgs e)
        {// zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            // ustawienie dostępności kontrolek
            btnWylosujNowePolozenie.Enabled = true;
            btnUsunOstatniaBryle.Enabled = true;
            btnUsunPierwszaBryle.Enabled = true;
            btnUsunWybranaBryle.Enabled = true;
            numNumerBryly.Enabled = true;
            lblNumerBryly.Enabled = true;
            gpbKryteriaPokazu.Enabled = true;
            gpbWyborSlajdu.Enabled = true;
            btnWlaczSlajder.Enabled = true;
            if (btnWylaczObrot.Enabled == true)
                btnWlaczObrot.Enabled = false;
            else
                btnWlaczObrot.Enabled = true;
            btnKierunekWLewo.Enabled = true;
            btnKierunekWPrawo.Enabled = true;
            lblKierunekObrotu.Enabled = true;
            //sprawdza czy użytkownik ustalił punkt dla rysowania bryły
            if (apPunktLokalizacjiBryly.X == -1)
            { //nie została wybrana lokalizacja wykreślenia bryły
                errorProvider1.SetError(btnDodajNowaBG, "Musisz ustalić lokalizację (położenie) bryły (środka jej podstawy), klikając myszą dowolny punkt powierzchni graficznej: Rysownicy!");
                return;
            }
            else
            {
                // lokalizacja została wyznaczona i punkt lokalizacji bryły należy wymazać
                /* utworzenie Pędzla o kolorze tła powierzchni
                    graficznej: pbRysownica */
                using (SolidBrush apPędzel = new SolidBrush(pbRysownica.BackColor))
                    //wymazanie poprzedniego punktu lokalizacji bryły
                    apRysownica.FillEllipse(apPędzel, apPunktLokalizacjiBryly.X - apPromienPunktuLokalizacji, apPunktLokalizacjiBryly.Y - apPromienPunktuLokalizacji, 2 * apPromienPunktuLokalizacji, 2 * apPromienPunktuLokalizacji);
                // deklaracje zmiennych i wpisanie do nich wartości ustalonych atrybutów geometrycznych
                int apPromieńBryły = trbPromienBryly.Value;
                int apWysokośćBryły = trbWysokoscBryly.Value;
                int apStopieńWielokątaBryły = (int)numStopieńWielokąta.Value;
                float apKątPochyleniaBryły = trbKatPochylenia.Value;
                int apWspółrzędnaXpodłogiBryły = apPunktLokalizacjiBryly.X;
                int apWspółrzędnaYpodłogiBryły = apPunktLokalizacjiBryly.Y;
                int apWspolrzednaXsufituBryły = apPunktLokalizacjiBryly.X;
                int apWspolrzednaYsufituBryły = apPunktLokalizacjiBryly.Y;
                // deklaracje zmiennych i wpisanie do nich wartości ustalonych atrybutów graficznych
                Color apKolorLinii = btnKolorLinii.BackColor;
                DashStyle apStylLinii;
                // odczytanie wybranego stylu linii
                switch (cmbStylLinii.SelectedIndex)
                {
                    case 0:
                        apStylLinii = DashStyle.Solid; break;
                    case 1:
                        apStylLinii = DashStyle.Dash; break;
                    case 2:
                        apStylLinii = DashStyle.Dot; break;
                    case 3:
                        apStylLinii = DashStyle.DashDot; break;
                    case 4:
                        apStylLinii = DashStyle.DashDotDot; break;
                    default:
                        MessageBox.Show("UWAGA: odczytano nieznany styl linii!");
                        apStylLinii = DashStyle.Solid; // domyślne ustawienie stylu linii
                        break;
                }
                float apGrubośćLinii = trbGruboscLinii.Value;
                // rozpoznanie wybranej bryły
                switch (cmbBrylyGeometryczne.SelectedItem)
                {
                    case "Graniastosłup":
                        Graniastoslup apgraniastoslup = new Graniastoslup(apPromieńBryły, apWysokośćBryły, apStopieńWielokątaBryły, apWspółrzędnaXpodłogiBryły, apWspółrzędnaYpodłogiBryły, apWspolrzednaXsufituBryły, apWspolrzednaYsufituBryły, apKolorLinii, apStylLinii, apGrubośćLinii);
                        apLBG.Add(apgraniastoslup); apLBG[apLBG.Count - 1].Wykresl(apRysownica);
                        break;
                    case "Ostrosłup":
                        Ostroslup apostroslup = new Ostroslup(apPromieńBryły, apWysokośćBryły, apStopieńWielokątaBryły, apWspółrzędnaXpodłogiBryły, apWspółrzędnaYpodłogiBryły, apKolorLinii, apStylLinii, apGrubośćLinii);
                        apLBG.Add(apostroslup); apLBG[apLBG.Count - 1].Wykresl(apRysownica);
                        break;
                    case "Graniastosłup pochyły":
                        GraniastoslupPochyly apgraniastosluppochyly = new GraniastoslupPochyly(apPromieńBryły, apWysokośćBryły, apStopieńWielokątaBryły, apWspółrzędnaXpodłogiBryły, apWspółrzędnaYpodłogiBryły, apWspolrzednaXsufituBryły, apWspolrzednaYsufituBryły, apKątPochyleniaBryły, apKolorLinii, apStylLinii, apGrubośćLinii);
                        apLBG.Add(apgraniastosluppochyly); apLBG[apLBG.Count - 1].Wykresl(apRysownica);
                        break;
                    case "Ostrosłup pochyły":
                        OstroslupPochyly apostrosluppochyly = new OstroslupPochyly(apPromieńBryły, apWysokośćBryły, apStopieńWielokątaBryły, apWspółrzędnaXpodłogiBryły, apWspółrzędnaYpodłogiBryły, apKolorLinii, apStylLinii, apGrubośćLinii, apKątPochyleniaBryły);
                        apLBG.Add(apostrosluppochyly); apLBG[apLBG.Count - 1].Wykresl(apRysownica);
                        break;
                    default:
                        MessageBox.Show("Nie została wybrana żadna bryła! Wybierz ją w kontrolce ComboBox(jest ona w lewym górnym narożniku Twojego formularza)");
                        break;
                }
            }
            pbRysownica.Refresh();

        }

        private void trbWysokoscBryly_Scroll(object sender, EventArgs e)
        {
            lblWysokoscBryly.Text = trbWysokoscBryly.Value.ToString();
        }

        private void trbPromienBryly_Scroll(object sender, EventArgs e)
        {
            lblPromienBG.Text = trbPromienBryly.Value.ToString();
        }

        private void trbGruboscLinii_Scroll(object sender, EventArgs e)
        {
            lblGruboscLinii.Text = trbGruboscLinii.Value.ToString();
        }

        private void trbKatPochylenia_Scroll(object sender, EventArgs e)
        {
            lblKatPochylenia.Text = trbKatPochylenia.Value.ToString();
        }

        private void btnKolorLinii_Click(object sender, EventArgs e)
        {
            using (ColorDialog apPaletaKolorow = new ColorDialog())
            {
                apPaletaKolorow.Color = btnKolorLinii.BackColor;
                if (apPaletaKolorow.ShowDialog() == DialogResult.OK)
                    btnKolorLinii.BackColor = apPaletaKolorow.Color;
            }
        }

        private void btnUsunOstatniaBryle_Click(object sender, EventArgs e)
        {
            if (apLBG.Count > 0)
            {
                // wymazanie ostatniej bryły
                apLBG[apLBG.Count - 1].Wymaz(pbRysownica, apRysownica);
                apLBG.RemoveAt(apLBG.Count - 1);
            }
            if (apLBG.Count == 0)
            {
                btnUsunOstatniaBryle.Enabled = false;
                btnUsunPierwszaBryle.Enabled = false;
                btnWylosujNowePolozenie.Enabled = false;
                btnUsunWybranaBryle.Enabled = false;
                numNumerBryly.Enabled = false;
                lblNumerBryly.Enabled = false;
                gpbKryteriaPokazu.Enabled = false;
                gpbWyborSlajdu.Enabled = false;
                btnWlaczSlajder.Enabled = false;
                btnWylaczSlajder.Enabled = false;
                btnNastepna.Enabled = false;
                btnPoprzednia.Enabled = false;
                txtN.Enabled = false;
                lblN.Enabled = false;
                btnWlaczObrot.Enabled = false;
                btnKierunekWLewo.Enabled = false;
                btnKierunekWPrawo.Enabled = false;
                lblKierunekObrotu.Enabled = false;
            }

            pbRysownica.Refresh();
        }

        private void btnUsunPierwszaBryle_Click(object sender, EventArgs e)
        {
            if (apLBG.Count > 0)
            {
                // wymazanie pierwszej bryły
                apLBG[0].Wymaz(pbRysownica, apRysownica);
                apLBG.RemoveAt(0);
            }
            if (apLBG.Count == 0)
            {
                btnUsunOstatniaBryle.Enabled = false;
                btnUsunPierwszaBryle.Enabled = false;
                btnWylosujNowePolozenie.Enabled = false;
                btnUsunWybranaBryle.Enabled = false;
                numNumerBryly.Enabled = false;
                lblNumerBryly.Enabled = false;
                gpbKryteriaPokazu.Enabled = false;
                gpbWyborSlajdu.Enabled = false;
                btnWlaczSlajder.Enabled = false;
                btnWylaczSlajder.Enabled = false;
                btnNastepna.Enabled = false;
                btnPoprzednia.Enabled = false;
                txtN.Enabled = false;
                lblN.Enabled = false;
                btnWlaczObrot.Enabled = false;
                btnKierunekWLewo.Enabled = false;
                btnKierunekWPrawo.Enabled = false;
                lblKierunekObrotu.Enabled = false;
            }
            pbRysownica.Refresh();
        }

        private void btnUsunWybranaBryle_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            int apN = int.Parse(numNumerBryly.Value.ToString());
            if (apN >= apLBG.Count)
            {
                // zabezpieczenie się na wypadek podania nieistniejącego numeru
                errorProvider1.SetError(numNumerBryly, "ERROR: Nie narysowano bryły o takim numerze, spróbuj podać niższy numer");
                return;
            }
            if (apLBG.Count > 0 && apN < apLBG.Count())
            {
                // usunięcie wybranej bryły
                apLBG[apN].Wymaz(pbRysownica, apRysownica);
                apLBG.RemoveAt(apN);
            }
            if (apLBG.Count == 0)
            {
                btnUsunOstatniaBryle.Enabled = false;
                btnUsunPierwszaBryle.Enabled = false;
                btnWylosujNowePolozenie.Enabled = false;
                btnUsunWybranaBryle.Enabled = false;
                numNumerBryly.Enabled = false;
                lblNumerBryly.Enabled = false;
                gpbKryteriaPokazu.Enabled = false;
                gpbWyborSlajdu.Enabled = false;
                btnWlaczSlajder.Enabled = false;
                btnWylaczSlajder.Enabled = false;
                btnNastepna.Enabled = false;
                btnPoprzednia.Enabled = false;
                txtN.Enabled = false;
                lblN.Enabled = false;
                btnWlaczObrot.Enabled = false;
                btnKierunekWLewo.Enabled = false;
                btnKierunekWPrawo.Enabled = false;
                lblKierunekObrotu.Enabled = false;
            }
            pbRysownica.Refresh();
        }

        private void btnWylosujNowePolozenie_Click(object sender, EventArgs e)
        {
            if (apLBG.Count > 0)
            {
                // wylosowanie nowego położenia bryły
                Random aprnd = new Random();
                int apXn, apYn;
                int apXmax, apYmax; //rozmiar powierzchni
                                // wyczyszczenie całej powierzchni graficznej
                                // odczytanie rozmiaru powierzchni
                apXmax = pbRysownica.Width; apYmax = pbRysownica.Height;
                for (int api = 0; api < apLBG.Count; api++)
                {// wylosowanie nowych współrzędnych nowego położenia i-tej figury geometrycznej
                    apXn = aprnd.Next(50, apXmax - 50);
                    apYn = aprnd.Next(50, apYmax - 50);
                    apLBG[api].PrzesunDoNowegoXY(pbRysownica, apRysownica, apXn, apYn);
                }
            }
            if (apLBG.Count == 0)
            {
                btnUsunOstatniaBryle.Enabled = false;
                btnUsunPierwszaBryle.Enabled = false;
                btnWylosujNowePolozenie.Enabled = false;
                btnUsunWybranaBryle.Enabled = false;
                numNumerBryly.Enabled = false;
                lblNumerBryly.Enabled = false;
                gpbKryteriaPokazu.Enabled = false;
                gpbWyborSlajdu.Enabled = false;
                btnWlaczSlajder.Enabled = false;
                btnWylaczSlajder.Enabled = false;
                btnNastepna.Enabled = false;
                btnPoprzednia.Enabled = false;
                txtN.Enabled = false;
                lblN.Enabled = false;
                btnWlaczObrot.Enabled = false;
                btnKierunekWLewo.Enabled = false;
                btnKierunekWPrawo.Enabled = false;
                lblKierunekObrotu.Enabled = false;
            }
            pbRysownica.Refresh();
        }

        private void btnWlaczSlajder_Click(object sender, EventArgs e)
        {
            gpbWyborSlajdu.Enabled = false;
            btnWlaczSlajder.Enabled = false;
            btnUsunOstatniaBryle.Enabled = false;
            btnUsunPierwszaBryle.Enabled = false;
            btnWylosujNowePolozenie.Enabled = false;
            btnUsunWybranaBryle.Enabled = false;
            numNumerBryly.Enabled = false;
            lblNumerBryly.Enabled = false;
            txtN.Enabled = false;
            lblN.Enabled = false;
            btnDodajNowaBG.Enabled = false;
            gpbAtrybutyBG.Enabled = false;
            cmbBrylyGeometryczne.Enabled = false;
            gpbKryteriaPokazu.Enabled = false;
            btnWlaczObrot.Enabled = false;
            btnKierunekWLewo.Enabled = false;
            btnKierunekWPrawo.Enabled = false;
            lblKierunekObrotu.Enabled = false;
            // pokaz zegarowy
            if (rdbZegarowy.Checked)
            {
                if (apLBG.Count > 0)
                {
                    // posortowanie listy LBG w zależności od danego kryterium
                    apRysownica.Clear(pbRysownica.BackColor);
                    if (rdbObjetosc.Checked)
                        apLBG.Sort((apbryla1, apbryla2) => apbryla1.ObjetoscBryly.CompareTo(apbryla2.ObjetoscBryly));
                    else if (rdbPoleCalkowite.Checked)
                        apLBG.Sort((apbryla1, apbryla2) => apbryla1.PowierzchniaBryly.CompareTo(apbryla2.PowierzchniaBryly));
                    else
                        apLBG.Sort((apbryla1, apbryla2) => apbryla1.WysokoscBG.CompareTo(apbryla2.WysokoscBG));
                    ZegarSlajder.Tag = 0;
                    ZegarSlajder.Enabled = true;
                    txtN.Enabled = true;
                    lblN.Enabled = true;
                }
            }
            // pokaz przyciskowy
            if (rdbPrzyciskowy.Checked)
            {
                if (apLBG.Count > 0)
                {
                    btnPoprzednia.Enabled = true;
                    btnNastepna.Enabled = true;
                    txtN.Enabled = true;
                    lblN.Enabled = true;
                    txtN.Text = apn.ToString();
                    apRysownica.Clear(pbRysownica.BackColor);
                    // posortowanie listy LBG w zależności od danego kryterium
                    if (rdbObjetosc.Checked)
                        apLBG.Sort((apbryla1, apbryla2) => apbryla1.ObjetoscBryly.CompareTo(apbryla2.ObjetoscBryly));
                    else if (rdbPoleCalkowite.Checked)
                        apLBG.Sort((apbryla1, apbryla2) => apbryla1.PowierzchniaBryly.CompareTo(apbryla2.PowierzchniaBryly));
                    else
                        apLBG.Sort((apbryla1, apbryla2) => apbryla1.WysokoscBG.CompareTo(apbryla2.WysokoscBG));
                    //LBG.Sort();
                    apLBG[0].PrzesunDoNowegoXY(pbRysownica, apRysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
                }
            }
            btnWylaczSlajder.Enabled = true;
            pbRysownica.Refresh();
        }

        private void btnNastepna_Click(object sender, EventArgs e)
        {
            // wymazanie powierzchni graficznej o numerze (indeksie) N
            //LBG[n].Wymaz(pbRysownica, Rysownica);
            apRysownica.Clear(pbRysownica.BackColor);
            // wyznaczenie numeru następnej figury do wykreślenia 
            if (apn < (apLBG.Count - 1))
                apn++;
            else
                apn = 0;

            txtN.Text = apn.ToString();
            apLBG[apn].PrzesunDoNowegoXY(pbRysownica, apRysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
            pbRysownica.Refresh();
        }

        private void btnPoprzednia_Click(object sender, EventArgs e)
        {
            txtN.Text = apn.ToString();
            // wymazanie powierzchni graficznej
            apRysownica.Clear(pbRysownica.BackColor);
            // wyznaczenie numeru następnej bryły do wykreślenia 
            if (apn == 0)
                apn = apLBG.Count - 1;
            else
                apn--;

            txtN.Text = apn.ToString();
            apLBG[apn].PrzesunDoNowegoXY(pbRysownica, apRysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
            pbRysownica.Refresh();
        }

        private void btnWylaczSlajder_Click(object sender, EventArgs e)
        {
            ZegarSlajder.Enabled = false;
            apn = 0;
            txtN.Text = apn.ToString();
            apRysownica.Clear(pbRysownica.BackColor);
            Random aprnd = new Random();
            int apXn, apYn;
            int apXmax, apYmax; //rozmiar powierzchni
            // wyczyszczenie całej powierzchni graficznej
            // odczytanie rozmiaru powierzchni
            apXmax = pbRysownica.Width; apYmax = pbRysownica.Height;
            for (int api = 0; api < apLBG.Count; api++)
            {// wylosowanie nowych współrzędnych nowego położenia i-tej bryły geometrycznej
                apXn = aprnd.Next(50, apXmax - 50);
                apYn = aprnd.Next(50, apYmax - 50);
                apLBG[api].PrzesunDoNowegoXY(pbRysownica, apRysownica, apXn, apYn);
            }
            btnWylaczSlajder.Enabled = false;
            btnPoprzednia.Enabled = false;
            btnNastepna.Enabled = false;
            lblN.Enabled = false;
            txtN.Enabled = false;
            btnWlaczSlajder.Enabled = true;
            btnUsunOstatniaBryle.Enabled = true;
            btnUsunPierwszaBryle.Enabled = true;
            btnWylosujNowePolozenie.Enabled = true;
            btnUsunWybranaBryle.Enabled = true;
            numNumerBryly.Enabled = true;
            lblNumerBryly.Enabled = true;
            btnDodajNowaBG.Enabled = true;
            gpbAtrybutyBG.Enabled = true;
            gpbWyborSlajdu.Enabled = true;
            cmbBrylyGeometryczne.Enabled = true;
            gpbKryteriaPokazu.Enabled = true;
            btnWlaczObrot.Enabled = true;
            lblKierunekObrotu.Enabled = true;
            btnKierunekWLewo.Enabled = true;
            btnKierunekWPrawo.Enabled = true;
            pbRysownica.Refresh();
        }

        private void ZegarSlajder_Tick(object sender, EventArgs e)
        {
            // Wymazanie powierzchni graficznej
            apRysownica.Clear(pbRysownica.BackColor);

            // Wyznaczenie rozmiaru powierzchni graficznej
            int apXmax = pbRysownica.Width;
            int apYmax = pbRysownica.Height;

            // Przesunięcie i wykreślenie figury geometrycznej o numerze ZegarSlajder.Tag
            apLBG[(int)ZegarSlajder.Tag].PrzesunDoNowegoXY(pbRysownica, apRysownica, apXmax / 2, apYmax / 2);
            apn = (int)ZegarSlajder.Tag;
            txtN.Text = apn.ToString();

            // Zwiększenie wartości ZegarSlajder.Tag i sprawdzenie warunku zakończenia sortowania
            ZegarSlajder.Tag = ((int)ZegarSlajder.Tag + 1) % (apLBG.Count);

            // Odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnWlaczObrot_Click(object sender, EventArgs e)
        {
            // włączenie obrotu brył
            btnWylaczObrot.Enabled = true;
            btnWlaczObrot.Enabled = false;
            ZegarObrotu.Enabled = true;
            btnWlaczSlajder.Enabled = false;
        }

        private void btnWylaczObrot_Click(object sender, EventArgs e)
        {
            // wyłączenie obrotu brył
            btnWlaczObrot.Enabled = true;
            btnWylaczObrot.Enabled = false;
            ZegarObrotu.Enabled = false;
            btnWlaczSlajder.Enabled = true;
        }

        private void btnKierunekWLewo_Click(object sender, EventArgs e)
        {
            // zmiana kierunku obrotu na lewo
            for (int api = 0; api < apLBG.Count; api++)
            {
                apLBG[api].KierunekObrotu = false;
            }
            pbRysownica.Refresh();
        }

        private void btnKierunekWPrawo_Click(object sender, EventArgs e)
        {
            // zmiana kierunku obrotu na prawo
            for (int api = 0; api < apLBG.Count; api++)
            {
                apLBG[api].KierunekObrotu = true;
            }
            pbRysownica.Refresh();
        }
        private void cmbBrylyGeometryczne_SelectedIndexChanged(object sender, EventArgs e)
        {
            // blokowanie atrybutów graficznych w zależności od wybranej bryły
            switch (cmbBrylyGeometryczne.SelectedIndex)
            {
                case 0:
                    trbKatPochylenia.Enabled = false;
                    trbPromienBryly.Enabled = true;
                    break;
                case 1:
                    trbPromienBryly.Enabled = true;
                    trbKatPochylenia.Enabled = false;
                    break;
                case 2:
                    trbKatPochylenia.Enabled = true;
                    trbPromienBryly.Enabled = true;
                    break;
                case 3:
                    trbKatPochylenia.Enabled = true;
                    trbPromienBryly.Enabled = true;
                    break;
                default:
                    trbPromienBryly.Enabled = true;
                    trbKatPochylenia.Enabled = true;
                    break;
            }
        }
    }
}
