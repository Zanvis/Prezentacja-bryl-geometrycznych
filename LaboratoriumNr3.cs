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
//udostępnienie klas zadeklarowanych w klasie Bryly Geometryczne
using static Projekt3_Piwowarski62024.BrylyGeometryczne;

namespace Projekt3_Piwowarski62024
{
    public partial class LaboratoriumNr3 : Form
    {
        //deklaracje pomocnicze
        const int PromienPunktuLokalizacji = 2;
        Point PunktLokalizacjiBryly = new Point(-1, -1);
        Graphics Rysownica;
        List<BrylaAbstrakcyjna> LBG = new List<BrylaAbstrakcyjna>();
        float KatObrotu;
        float KatProsty = 90.0f;
        public static LaboratoriumNr3 UchwytFormularza;
        public int n = 0;

        public LaboratoriumNr3()
        {
            InitializeComponent();
            UchwytFormularza = this;
            //lokalizacja i zwymiarowanie formualarza i kontrolki PictureBox
            //utworzenie Bitmapy
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //utowrzenie egzemplarza powierzchni graficznej na Bitmapie
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            // wizualizacja domyślnych ustawień wartości atrybutów bryły
            lblWysokoscBryly.Text = trbWysokoscBryly.Value.ToString();
            lblPromienBG.Text = trbPromienBryly.Value.ToString();
            lblGruboscLinii.Text = trbGruboscLinii.Value.ToString();
        }

        private void pbRysownica_MouseClick(object sender, MouseEventArgs e)
        {
            /* sprawdzenie, czy punkt lokalizacji bryły był już
            wybrany początkowe ustawienie:
            Point PunktLokalizacjiBryły = new Point(-1, -1);
            czyli punkt poza Rysownicą */
            if (PunktLokalizacjiBryly.X != -1)
                /* utworzenie Pędzla o kolorze tła powierzchni
               graficznej: pbRysownica */
                using (SolidBrush Pędzel = new SolidBrush(pbRysownica.BackColor))
                    //wymazanie poprzedniego punktu lokalizacji bryły
                    Rysownica.FillEllipse(Pędzel, PunktLokalizacjiBryly.X - PromienPunktuLokalizacji, PunktLokalizacjiBryly.Y - PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji);
            //"zapamiętanie" nowej lokalizacji bryły
            PunktLokalizacjiBryly = new Point(e.Location.X, e.Location.Y);
            /* wizualizacja nowego punktu lokalizacji bryły, czyli
           wykreślenie nowego punktu lokalizacji bryły */
            Rysownica.FillEllipse(Brushes.Red, PunktLokalizacjiBryly.X - PromienPunktuLokalizacji, PunktLokalizacjiBryly.Y - PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji);
            // odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void ZegarObrotu_Tick(object sender, EventArgs e)
        {
            KatObrotu = 5F;
            for (int i = 0; i < LBG.Count; i++)
                LBG[i].Obroc_i_Wykresl(pbRysownica, Rysownica, KatObrotu);
            //odświeżenie powierzchni graficznej
            Refresh();
        }

        private void btnDodajNowaBG_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            ZegarObrotu.Enabled = true;
            gpbKryteriaPokazu.Enabled = true;
            gpbWyborSlajdu.Enabled = true;
            btnWlaczSlajder.Enabled = true;
            //sprawdza czy użytkownik ustalił punkt dla rysowania bryły
            if (PunktLokalizacjiBryly.X == -1)
            { //nie została wybrana lokalizacja wykreślenia bryły
                errorProvider1.SetError(btnDodajNowaBG, "Musisz ustalić lokalizację (położenie) bryły (środka jej podstawy), klikając myszą dowolny punkt powierzchni graficznej: Rysownicy!");
                return;
            }
            else
            { // lokalizacja została wyznaczona i punkt lokalizacji bryły należy wymazać
                /* utworzenie Pędzla o kolorze tła powierzchni
                    graficznej: pbRysownica */
                using (SolidBrush Pędzel = new SolidBrush(pbRysownica.BackColor))
                    //wymazanie poprzedniego punktu lokalizacji bryły
                    Rysownica.FillEllipse(Pędzel, PunktLokalizacjiBryly.X - PromienPunktuLokalizacji, PunktLokalizacjiBryly.Y - PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji);
                // deklaracje zmiennych i wpisanie do nich wartości ustalonych atrybutów geometrycznych
                int PromieńBryły = trbPromienBryly.Value;
                int WysokośćBryły = trbWysokoscBryly.Value;
                int StopieńWielokątaBryły = (int)numStopieńWielokąta.Value;
                float KątPochyleniaBryły = KatProsty;
                int WspółrzędnaXpodłogiBryły = PunktLokalizacjiBryly.X;
                int WspółrzędnaYpodłogiBryły = PunktLokalizacjiBryly.Y;
                // deklaracje zmiennych i wpisanie do nich wartości ustalonych atrybutów graficznych
                Color KolorLinii = btnKolorLinii.BackColor;
                DashStyle StylLinii;
                // odczytanie wybranego stylu linii
                switch (cmbStylLinii.SelectedIndex)
                {
                    case 0:
                        StylLinii = DashStyle.Solid; break;
                    case 1:
                        StylLinii = DashStyle.Dash; break;
                    case 2:
                        StylLinii = DashStyle.Dot; break;
                    case 3:
                        StylLinii = DashStyle.DashDot; break;
                    case 4:
                        StylLinii = DashStyle.DashDotDot; break;
                    default:
                        MessageBox.Show("UWAGA: odczytano nieznany styl linii!");

                        StylLinii = DashStyle.Solid; // domyślne ustawienie stylu linii
                        break;
                }
                float GrubośćLinii = trbGruboscLinii.Value;
                // rozpoznanie wybranej bryły
                switch (cmbBrylyGeometryczne.SelectedItem)
                {
                    case "Walec":
                        Walec walec = new Walec(PromieńBryły, WysokośćBryły, StopieńWielokątaBryły, WspółrzędnaXpodłogiBryły, WspółrzędnaYpodłogiBryły, KolorLinii, StylLinii, GrubośćLinii);
                        LBG.Add(walec); LBG[LBG.Count - 1].Wykresl(Rysownica);
                        break;
                    case "Stożek":
                        Stozek stożek = new Stozek(PromieńBryły, WysokośćBryły, StopieńWielokątaBryły, WspółrzędnaXpodłogiBryły, WspółrzędnaYpodłogiBryły, KolorLinii, StylLinii, GrubośćLinii);
                        LBG.Add(stożek); LBG[LBG.Count - 1].Wykresl(Rysownica);
                        break;
                    case "Kula":
                        Kula kula = new Kula(PromieńBryły, StopieńWielokątaBryły, WspółrzędnaXpodłogiBryły, WspółrzędnaYpodłogiBryły, KolorLinii, StylLinii, GrubośćLinii);
                        LBG.Add(kula); LBG[LBG.Count - 1].Wykresl(Rysownica);
                        break;
                    default:
                        MessageBox.Show("Nie została wybrana żadna bryła! Wybierz ją w kontrolce ComboBox(jest ona w lewym górnym narożniku Twojego formularza)");
                        break;

                }
            }
            pbRysownica.Refresh();
        }

        private void cmbBrylyGeometryczne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrylyGeometryczne.SelectedIndex == 2)
            { // wybrano kulę
                trbWysokoscBryly.Enabled = false;
                trbPromienBryly.Enabled = true;
                numStopieńWielokąta.Enabled = true;
            }
            else
            { // wybrano: Walec lub Stożek
                trbWysokoscBryly.Enabled = true;
                trbPromienBryly.Enabled = true;
                numStopieńWielokąta.Enabled = true;
            }
            btnKolorLinii.Enabled = true;
            cmbStylLinii.Enabled = true;
            trbGruboscLinii.Enabled = true;
            btnDodajNowaBG.Enabled = true;
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

        private void btnKolorLinii_Click(object sender, EventArgs e)
        {
            using (ColorDialog PaletaKolorów = new ColorDialog())
            {
                PaletaKolorów.Color = btnKolorLinii.BackColor;
                if (PaletaKolorów.ShowDialog() == DialogResult.OK)
                    btnKolorLinii.BackColor = PaletaKolorów.Color;
            }
        }

        private void LaboratoriumNr3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // utworzenie okna dialogowego dla potwierdzenia zamknięcia formularza indywidualnego
            DialogResult apOknoMessage = MessageBox.Show("Laboratorium: 5.0, gdyż zrealizowano wszystkie funkcjonalności omawiane na zajęciach laboratoryjnych", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
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

        private void btnWlaczSlajder_Click(object sender, EventArgs e)
        {
            gpbWyborSlajdu.Enabled = false;
            btnWlaczSlajder.Enabled = false;
            txtN.Enabled = false;
            lblN.Enabled = false;
            btnDodajNowaBG.Enabled = false;
            gpbAtrybutyBG.Enabled = false;
            cmbBrylyGeometryczne.Enabled = false;
            gpbKryteriaPokazu.Enabled = false;
            ZegarObrotu.Enabled = false;

            if (rdbZegarowy.Checked)
            {
                if (LBG.Count > 0)
                {
                    Rysownica.Clear(pbRysownica.BackColor);
                    if (rdbObjetosc.Checked)
                        LBG.Sort((apbryla1, apbryla2) => apbryla1.ObjetoscBryly.CompareTo(apbryla2.ObjetoscBryly));
                    else if (rdbPoleCalkowite.Checked)
                        LBG.Sort((apbryla1, apbryla2) => apbryla1.PowierzchniaBryly.CompareTo(apbryla2.PowierzchniaBryly));
                    else
                        LBG.Sort((apbryla1, apbryla2) => apbryla1.WysokoscBG.CompareTo(apbryla2.WysokoscBG));
                    ZegarSlajder.Tag = 0;
                    ZegarSlajder.Enabled = true;
                    lblN.Enabled = true;
                    txtN.Enabled = true;
                    LBG[0].PrzesunDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
                    ZegarObrotowy.Enabled = true;
                }
            }
            if (rdbPrzyciskowy.Checked)
            {
                if (LBG.Count > 0)
                {
                    btnPoprzednia.Enabled = true;
                    btnNastepna.Enabled = true;
                    txtN.Enabled = true;
                    lblN.Enabled = true;
                    txtN.Text = n.ToString();
                    Rysownica.Clear(pbRysownica.BackColor);
                    if (rdbObjetosc.Checked)
                        LBG.Sort((apbryla1, apbryla2) => apbryla1.ObjetoscBryly.CompareTo(apbryla2.ObjetoscBryly));
                    else if (rdbPoleCalkowite.Checked)
                        LBG.Sort((apbryla1, apbryla2) => apbryla1.PowierzchniaBryly.CompareTo(apbryla2.PowierzchniaBryly));
                    else
                        LBG.Sort((apbryla1, apbryla2) => apbryla1.WysokoscBG.CompareTo(apbryla2.WysokoscBG));
                    //LBG.Sort();
                    LBG[0].PrzesunDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
                    ZegarObrotowy.Enabled = true;
                }
            }
            btnWylaczSlajder.Enabled = true;
            pbRysownica.Refresh();
        }

        private void btnNastepna_Click(object sender, EventArgs e)
        {
            // wymazanie powierzchni graficznej o numerze (indeksie) N
            //LBG[n].Wymaz(pbRysownica, Rysownica);
            Rysownica.Clear(pbRysownica.BackColor);
            // wyznaczenie numeru następnej figury do wykreślenia 
            if (n < (LBG.Count - 1))
                n++;
            else
                n = 0;

            txtN.Text = n.ToString();
            LBG[n].PrzesunDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
            pbRysownica.Refresh();
        }

        private void btnPoprzednia_Click(object sender, EventArgs e)
        {
            txtN.Text = n.ToString();
            // wymazanie powierzchni graficznej o numerze (indeksie) N
            //LBG[n].Wymaz(pbRysownica, Rysownica);
            Rysownica.Clear(pbRysownica.BackColor);
            // wyznaczenie numeru następnej figury do wykreślenia 
            if (n == 0)
                n = LBG.Count - 1;
            else
                n--;

            txtN.Text = n.ToString();
            LBG[n].PrzesunDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
            pbRysownica.Refresh();
        }

        private void btnWylaczSlajder_Click(object sender, EventArgs e)
        {
            ZegarSlajder.Enabled = false;
            n = 0;
            txtN.Text = n.ToString();
            Rysownica.Clear(pbRysownica.BackColor);
            Random aprnd = new Random();
            int apXn, apYn;
            int apXmax, apYmax; //rozmiar powierzchni
            // wyczyszczenie całej powierzchni graficznej
            // odczytanie rozmiaru powierzchni
            apXmax = pbRysownica.Width; apYmax = pbRysownica.Height;
            for (int api = 0; api < LBG.Count; api++)
            {// wylosowanie nowych współrzędnych nowego położenia i-tej figury geometrycznej
                apXn = aprnd.Next(50, apXmax - 50);
                apYn = aprnd.Next(50, apYmax - 50);
                LBG[api].PrzesunDoNowegoXY(pbRysownica, Rysownica, apXn, apYn);
            }
            btnWylaczSlajder.Enabled = false;
            btnPoprzednia.Enabled = false;
            btnNastepna.Enabled = false;
            lblN.Enabled = false;
            txtN.Enabled = false;
            btnWlaczSlajder.Enabled = true;
            btnDodajNowaBG.Enabled = true;
            gpbAtrybutyBG.Enabled = true;
            gpbWyborSlajdu.Enabled = true;
            cmbBrylyGeometryczne.Enabled = true;
            gpbKryteriaPokazu.Enabled = true;
            ZegarObrotu.Enabled = true;
            ZegarObrotowy.Enabled = false;
            pbRysownica.Refresh();
        }

        private void ZegarSlajder_Tick(object sender, EventArgs e)
        {
            // Wymazanie figury aktualnie wykreślonej
            Rysownica.Clear(pbRysownica.BackColor);

            // Wyznacnie rozmiaru powierzchni graficznej
            int apXmax = pbRysownica.Width;
            int apYmax = pbRysownica.Height;

            // Przesunięcie i wykreślenie figury geometrycznej o numerze timer1.Tag
            LBG[(int)ZegarSlajder.Tag].PrzesunDoNowegoXY(pbRysownica, Rysownica, apXmax / 2, apYmax / 2);
            n = (int)ZegarSlajder.Tag;
            txtN.Text = n.ToString();
            // Zwiększenie wartości ZegarSlajder.Tag i sprawdzenie warunku zakończenia sortowania
            ZegarSlajder.Tag = ((int)ZegarSlajder.Tag + 1) % (LBG.Count);

            // Odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void ZegarObrotowy_Tick(object sender, EventArgs e)
        {
            if (n != 0)
                LBG[n].Obroc_i_Wykresl(pbRysownica, Rysownica, 5.0f);
            else
                LBG[0].Obroc_i_Wykresl(pbRysownica, Rysownica, 5.0f);

            pbRysownica.Refresh();
        }

        private void btnKierunekPrawo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LBG.Count; i++)
            {
                LBG[i].KierunekObrotu = false;
            }
        }

        private void btnKierunekLewo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LBG.Count; i++)
            {
                LBG[i].KierunekObrotu = true;
            }
        }
    }
}
