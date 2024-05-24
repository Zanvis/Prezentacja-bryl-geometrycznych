using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt3_Piwowarski62024.LaboratoriumNr3;

namespace Projekt3_Piwowarski62024
{
    internal class BrylyGeometryczne
    {
        public abstract class BrylaAbstrakcyjna : IComparable<BrylaAbstrakcyjna>
        {
            //deklaracja typu wyliczeniowego znaczników bryła
            public enum TypBG
            {
                BG_Walec, BG_Stozek, BG_Kula, BG_Graniastoslup, BG_Ostroslup
            }
            //deklaracja atrybutów wspólnych dla wszystkich BG
            protected int XsP, YsP;
            protected float KatPochylenia;
            protected Color KolorLinii;
            protected DashStyle StylLinii;
            protected float GruboscLinii;
            public bool KierunekObrotu = true; // True, to zgodnie z ruchem wskazówek zegara, False, to przciwnie do ruchu wskazówek zegara
            protected float KatProsty = 90.0f;

            //deklaracja znacznika BG
            public TypBG TypBryly
            {
                get;
                protected set;
            }
            //deklaracja konstruktora
            public BrylaAbstrakcyjna(Color KolorLinii, DashStyle StylLinii, float GruboscLinii)
            {
                this.KolorLinii = KolorLinii;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
                this.KatPochylenia = KatProsty;
            }
            public float PowierzchniaBryly
            {
                get;
                protected set;
            }

            public float ObjetoscBryly
            {
                get;
                protected set;
            }
            public float WysokoscBG
            {
                get;
                protected set;
            }

            public int CompareTo(BrylaAbstrakcyjna Bryla2)
            {
                if (UchwytFormularza.rdbWysokosc.Checked)
                {
                    if (this.WysokoscBG > Bryla2.WysokoscBG) return 1;
                    else if (this.WysokoscBG < Bryla2.WysokoscBG) return -1;
                    else return 0;
                }
                else if (UchwytFormularza.rdbObjetosc.Checked)
                {
                    if (this.ObjetoscBryly > Bryla2.ObjetoscBryly) return 1;
                    else if (this.ObjetoscBryly < Bryla2.ObjetoscBryly) return -1;
                    else return 0;
                }
                else if (UchwytFormularza.rdbPoleCalkowite.Checked)
                {
                    if (this.PowierzchniaBryly > Bryla2.PowierzchniaBryly) return 1;
                    else if (this.PowierzchniaBryly < Bryla2.PowierzchniaBryly) return -1;
                    else return 0;
                }
                else
                    return 0;
            }
            //deklaracja metod abstrakcyjnych
            public abstract void Wykresl(Graphics Rysownica);
            public abstract void Wymaz(Control Kontrolka, Graphics Rysownica);
            public abstract void Obroc_i_Wykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu);
            public abstract void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y);
        }
        //deklaracja klas potomnych od klasy 
        public class BrylyObrotowe : BrylaAbstrakcyjna
        {
            //deklaracja atrybutu wspólnego dla: Walca, Stożka i Kuli
            public int PromienBryly
            {
                get;
                protected set;
            }
            //deklaracja konstruktora
            public BrylyObrotowe(int R, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(KolorLinii, StylLinii, GruboscLinii)
            {
                //przechowanie wartości atrybutu wspólnego
                PromienBryly = R;
            }
            //nadpisanie wszystkich metod abstrakcyjnych zadeklarowanych w klasie bazowej, która jest klasą abstrakcyjną 
            public override void Wykresl(Graphics Rysownica)
            {
                //ta pusta implementacja metody abstrakcyjnej będzie ponownie nadpisana w klasach potomnych dla klasy Bryły
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                //ta pusta implementacja metody abstrakcyjnej będzie ponownie nadpisana w klasach potomnych dla klasy Bryły
            }
            public override void Obroc_i_Wykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                //ta pusta implementacja metody abstrakcyjnej będzie ponownie nadpisana w klasach potomnych dla klasy Bryły
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                //ta pusta implementacja metody abstrakcyjnej będzie ponownie nadpisana w klasach potomnych dla klasy Bryły
            }
        }
        //deklaracje klas potomnych dla klasy Bryły Obrotowe
        public class Walec : BrylyObrotowe
        {
            // uszczegółowienie deklaracji atrybutów klasy Walec
            protected int WysokoscWalca;
            // deklaracja tablicy referencji egzemplarzy wierzchołków "podłogi"
            Point[] WielokatPodlogi;
            // deklaracja tablicy referencji egzemplarzy wierzchołków "sufitu"
            Point[] WielokatSufitu;
            // stopień wielokąta "podłogi" (podstawy) i "sufitu"
            int StopienWielokataPodstawy;
            // osie elipsy "podłogi" (podstawy) i "sufitu"
            float Os_duza, Os_mala;
            // kąt środkowy między wierzchołkami wielokąta podstawy
            float KatMiedzyWierzcholkami;
            // kąt położenia pierwszego wierzchołk wielokąta podstawy
            float KatPolozenia;
            // współrzędne położenia środka "sufitu" Walca
            int XsS, YsS; // środek "sufitu" Walca
            // deklaracje pomocnicze

            public Walec(int R, int WysokoscWalca, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(R, KolorLinii, StylLinii, GruboscLinii)
            {
                this.WysokoscBG = WysokoscWalca;
                TypBryly = TypBG.BG_Walec;
                this.WysokoscWalca = WysokoscWalca;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
                Os_duza = this.PromienBryly * 2;
                Os_mala = this.PromienBryly / 2;
                // wyznaczenie współrzędnej YsS środka sufitu Walca
                this.YsS = YsP - WysokoscWalca;
                this.XsS = XsP;
                this.XsP = XsP;
                this.YsP = YsP;
                this.KatPochylenia = KatProsty;
                // wyznaczenie kąta między wierzchołkami wielokątów podłogi i sufitu
                this.KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;
                // ustalenie kąta położenia pierwszego wierzchołka wielokąta podstawy;
                this.KatPolozenia = 0.0f;
                WielokatPodlogi = new Point[StopienWielokataPodstawy];
                WielokatSufitu = new Point[StopienWielokataPodstawy];

                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    WielokatSufitu[i] = new Point();
                    // "podłoga" Walca
                    WielokatPodlogi[i].X = (int)(this.XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodlogi[i].Y = (int)(this.YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180.0f));
                    // "sufit" Walca
                    WielokatSufitu[i].X = (int)(this.XsS + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatSufitu[i].Y = (int)(this.YsS + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180.0f));
                }
                this.ObjetoscBryly = (float)(Math.PI * Math.Pow(this.PromienBryly, 2) * this.WysokoscWalca);
                this.PowierzchniaBryly = (float)(2 * Math.PI * this.PromienBryly * (this.PromienBryly + this.WysokoscWalca));
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(this.KolorLinii, GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;
                    // wykreślenie podłogi i sufitu Walca
                    Rysownica.DrawEllipse(Pioro, this.XsP - this.Os_duza / 2, this.YsP - this.Os_mala / 2, this.Os_duza, this.Os_mala);
                    Rysownica.DrawEllipse(Pioro, this.XsS - this.Os_duza / 2, this.YsS - this.Os_mala / 2, this.Os_duza, this.Os_mala);
                    // wykreślenie krawędzi bocznych
                    Rysownica.DrawLine(Pioro, this.XsP - this.Os_duza / 2, this.YsP, this.XsS - this.Os_duza / 2, this.YsS);
                    Rysownica.DrawLine(Pioro, this.XsP + this.Os_duza / 2, this.YsP, this.XsS + this.Os_duza / 2, this.YsS);

                    Pioro.Width = Pioro.Width / 2.0f;
                    for (int i = 0; i < StopienWielokataPodstawy; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatSufitu[i]);
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;
                    // wykreślenie podłogi i sufitu Walca
                    Rysownica.DrawEllipse(Pioro, this.XsP - this.Os_duza / 2, this.YsP - this.Os_mala / 2, this.Os_duza, this.Os_mala);
                    Rysownica.DrawEllipse(Pioro, this.XsS - this.Os_duza / 2, this.YsS - this.Os_mala / 2, this.Os_duza, this.Os_mala);
                    // wykreślenie krawędzi bocznych
                    Rysownica.DrawLine(Pioro, this.XsP - this.Os_duza / 2, this.YsP, this.XsS - this.Os_duza / 2, this.YsS);
                    Rysownica.DrawLine(Pioro, this.XsP + this.Os_duza / 2, this.YsP, this.XsS + this.Os_duza / 2, this.YsS);

                    Pioro.Width = Pioro.Width / 2.0f;
                    for (int i = 0; i < StopienWielokataPodstawy; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatSufitu[i]);
                }
            }
            public override void Obroc_i_Wykresl(Control Kontrolka, Graphics Rysownica, float KatObrotu)
            {
                // wymazanie Walca w jego aktualnym położeniu
                Wymaz(Kontrolka, Rysownica);
                if (!this.KierunekObrotu)
                    KatPolozenia += KatPochylenia;
                else
                    KatPolozenia -= KatPochylenia;

                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    // "podłoga" Walca
                    WielokatPodlogi[i].X = (int)(this.XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodlogi[i].Y = (int)(this.YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180.0f));

                    WielokatSufitu[i].X = WielokatPodlogi[i].X;
                    WielokatSufitu[i].Y = WielokatPodlogi[i].Y - WysokoscWalca;
                }
                // wykreślenie Walca po obrocie o KatPochylenia
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                int dX, dY;
                // wymazanie Walca w jego aktualnym położeniu (lokalizacji)
                Wymaz(Kontrolka, Rysownica);
                // wyznaczenie przyrostu zmian współrzędnych środka podłogi Walca
                dX = XsP < X ? dX = X - XsP : dX = -(XsP - X);
                dY = YsP < Y ? dY = Y - YsP : dY = -(YsP - Y);
                // ustalenie nowej lokalizacji dla Walca
                this.XsP = XsP + dX;
                this.YsP = YsP + dY;
                this.XsS = XsS + dX;
                this.YsS = YsS + dY;

                for (int i = 0; i < StopienWielokataPodstawy; i++)
                {
                    // "podłoga" Walca
                    WielokatPodlogi[i].X = (int)(this.XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodlogi[i].Y = (int)(this.YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozenia + i * KatMiedzyWierzcholkami) / 180.0f));

                    WielokatSufitu[i].X = WielokatPodlogi[i].X;
                    WielokatSufitu[i].Y = WielokatPodlogi[i].Y - WysokoscWalca;
                }
                Wykresl(Rysownica);
            }
        }
        public class Stozek : BrylyObrotowe
        {// deklaracje uzupełniające dla Stożku
            protected int XsS, YsS;
            protected int SWP; // Stopień Wielokąta Podstawy
            protected float OsDuza, OsMala;
            protected int WysokoscStozka;
            protected float KatPPWWP; // Kąt Położenia Pierwszego Wierzchołka Wielokąta Podstawy
            protected Point[] WielokatPodlogi;

            // deklaracja kontruktora
            public Stozek(int R, int WysokoscStozka, int StopienWielokata, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(R, KolorLinii, StylLinii, GruboscLinii)
            {
                this.WysokoscBG = WysokoscStozka;
                XsS = XsP; YsS = YsP - WysokoscStozka;
                this.XsP = XsP; this.YsP = YsP;
                SWP = StopienWielokata;
                OsDuza = 2.0f * R;
                OsMala = R / 2.0f;
                this.WysokoscStozka = WysokoscStozka;
                KatPPWWP = 0.0f;
                // deklaracja pomocnicza
                float KMWW = 360.0f / StopienWielokata; // KMWW: Kąt Między Wierzchołkami Wielokąta
                // utworzenie egzemplarza tablicy WielokatPodlogi
                WielokatPodlogi = new Point[StopienWielokata];
                // utworzenie egzemplarza "pojemnika" (Point) współrzędnych wierzchołków wielokąta i wyznaczenie współrzędnych wierzchołków wielokąta
                for (int i = 0; i < StopienWielokata; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2.0f * Math.Cos(Math.PI * (KatPPWWP + i * KMWW) / 180.0f));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2.0f * Math.Sin(Math.PI * (KatPPWWP + i * KMWW) / 180.0f));
                }
                float l = (float)(Math.Sqrt(R * R + WysokoscStozka * WysokoscStozka));
                this.ObjetoscBryly = (float)((Math.PI * R * R * WysokoscStozka) / 3);
                this.PowierzchniaBryly = (float)(Math.PI * R * R + Math.PI * R * l);
            }// koniec kontruktora
            // ponowne nadpisanie metod abstrakcyjnych z klasy abstrakcyjnej: BrylaAbstrakcyjna
            public override void Wykresl(Graphics Rysownica)
            {
                // utworzenie egzemplarza Pióra i wykreślenie Stożka
                using (Pen Pioro = new Pen(KolorLinii, GruboscLinii))
                {// ustawienie stylu linii dla Pióra
                    Pioro.DashStyle = StylLinii;
                    // wykreślenie podstawy Stożka
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2.0f, YsP - OsMala / 2.0f, OsDuza, OsMala);
                    // wykreślenie lewej krawędzi bocznej
                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2.0f, YsP, XsS, YsS);
                    // wykreślenie prawej krawędzi bocznej
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2.0f, YsP, XsS, YsS);

                    // wykreślenie prążków
                    // ustawienie Pióra
                    Pioro.Width = Pioro.Width / 2.0f;
                    // wykreślenie prążków
                    for (int i = 0; i < SWP; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], new Point(XsS, YsS));
                }
            }// koniec metody Wykresl
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                {// ustawienie stylu linii dla Pióra
                    Pioro.DashStyle = StylLinii;
                    // wykreślenie podstawy Stożka
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2.0f, YsP - OsMala / 2.0f, OsDuza, OsMala);
                    // wykreślenie lewej krawędzi bocznej
                    Rysownica.DrawLine(Pioro, XsP - OsDuza / 2.0f, YsP, XsS, YsS);
                    // wykreślenie prawej krawędzi bocznej
                    Rysownica.DrawLine(Pioro, XsP + OsDuza / 2.0f, YsP, XsS, YsS);

                    // wykreślenie prążków
                    // ustawienie Pióra
                    Pioro.Width = Pioro.Width / 2.0f;
                    // wykreślenie prążków
                    for (int i = 0; i < SWP; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], new Point(XsS, YsS));
                }
            }// koniec metody Wymaz
            public override void Obroc_i_Wykresl(Control Kontrolka, Graphics Rysownica, float KatObrotu)
            {
                // wymazanie bryły w aktualnym położeniu
                Wymaz(Kontrolka, Rysownica);
                // obrót bryły o KatObrotu
                if (KierunekObrotu)
                    KatPPWWP += KatObrotu;
                else
                    KatPPWWP -= KatObrotu;
                // deklaracja pomocnicza
                float KMWW = 360.0f / SWP;
                for (int i = 0; i < SWP; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2.0f * Math.Cos(Math.PI * (KatPPWWP + i * KMWW) / 180.0f));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2.0f * Math.Sin(Math.PI * (KatPPWWP + i * KMWW) / 180.0f));
                }

                // wykreślenie Stożka
                Wykresl(Rysownica);
            }// koniec metody Obroz_i_Wykresl
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                // deklaracje pomocnicze
                int dX, dY;
                // wymazanie bryły w aktualnym położeniu
                Wymaz(Kontrolka, Rysownica);
                // wyznaczenie przyrostów przesunięcia bryły
                dX = XsP < X ? dX = X - XsP : dX = -(XsP - X);
                dY = YsP < Y ? dY = Y - YsP : dY = -(YsP - Y);
                // uaktualnienie położenia środka podstawy Stożka i jego wierzchołka
                XsP = XsP + dX; YsP = YsP + dY;
                XsS = XsS + dX; YsS = YsS + dY;
                // wyznaczenie nowych współrzędnych wielokąta podstawy
                // deklaracja pomocnicza
                float KMWW = 360.0f / SWP;
                for (int i = 0; i < SWP; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    WielokatPodlogi[i].X = (int)(XsP + OsDuza / 2.0f * Math.Cos(Math.PI * (KatPPWWP + i * KMWW) / 180.0f));
                    WielokatPodlogi[i].Y = (int)(YsP + OsMala / 2.0f * Math.Sin(Math.PI * (KatPPWWP + i * KMWW) / 180.0f));
                }
                // wykreślenie Stożka w nowej lokalizacji
                Wykresl(Rysownica);
            }
        }
        public class Kula : BrylyObrotowe
        {
            // deklaracja uzupełniająca
            int StopienWielokataPrzekrojuKuli;
            float OsDuza, OsMala;
            float KatSrodkowyWielokataPrzekrojuKuli;
            float KatpolozeniaPierwszegoWierzcholka;
            Point[] WielokatPrzekrojuKuli;
            // deklaracja konstruktora
            public Kula(int R, int StopienWielokata, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(R, KolorLinii, StylLinii, GruboscLinii)
            {
                this.WysokoscBG = R;
                // Ustawienie znacznika Kuli
                TypBryly = TypBG.BG_Kula;
                StopienWielokataPrzekrojuKuli = StopienWielokata;
                this.XsP = XsP; this.YsP = YsP;
                // wyznaczenie współrzędnych wierzchołków wielokąta wpisanego w przekrój Kuli
                KatSrodkowyWielokataPrzekrojuKuli = 360.0f / StopienWielokata;
                KatpolozeniaPierwszegoWierzcholka = 0.0f;
                // utworzenie egzemplarza tablicy WielokatPrzekrojuKuli
                WielokatPrzekrojuKuli = new Point[StopienWielokata];
                OsDuza = R * 2;
                OsMala = R / 2;
                // wyznaczenie współrzędnych wierzchołków wielokąta wpisanego w przekrój Kuli
                for (int i = 0; i < WielokatPrzekrojuKuli.Length; i++)
                {// utworzenie egzemplarza i-tego "pojemnika" Point
                    WielokatPrzekrojuKuli[i] = new Point();
                    // wyznaczenie współrzędnej X i-tego wierzchołka wielokąta
                    WielokatPrzekrojuKuli[i].X = (int)(XsP + OsDuza / 2.0f * Math.Cos(Math.PI * (KatpolozeniaPierwszegoWierzcholka + i * KatSrodkowyWielokataPrzekrojuKuli) / 180.0f));
                    // wyznaczenie współrzędnej Y i-tego wierzchołka wielokąta
                    WielokatPrzekrojuKuli[i].Y = (int)(YsP + OsMala / 2.0f * Math.Sin(Math.PI * (KatpolozeniaPierwszegoWierzcholka + i * KatSrodkowyWielokataPrzekrojuKuli) / 180.0f));
                }
                this.ObjetoscBryly = (float)((4 * Math.PI * R * R * R) / 3);
                this.PowierzchniaBryly = (float)(4 * Math.PI * R * R);
            } // koniec konstruktora
            // nadpisanie (ponowne) metod abstrakcyjnych z klasy BrylaAbstrakcyjna
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(KolorLinii, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    // wykreślenie zewnętrznego konturu Kuli
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2.0f, YsP - OsDuza / 2.0f, OsDuza, OsDuza);
                    // wykreślenie środkowego przekroju poziomego Kuli
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2.0f, YsP - OsMala / 2.0f, OsDuza, OsMala);
                    // wykreślenie linii łączących środek Kuli z wierzchołkami wielokąta wpisanego w poziomy przekrój Kuli
                    for (int i = 0; i < WielokatPrzekrojuKuli.Length; i++)
                    {
                        Rysownica.DrawLine(Pioro, XsP, YsP, WielokatPrzekrojuKuli[i].X, WielokatPrzekrojuKuli[i].Y);
                    }
                }
            }// koniec Wykresl(. . .)
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    // wykreślenie zewnętrznego konturu Kuli
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2.0f, YsP - OsDuza / 2.0f, OsDuza, OsDuza);
                    // wykreślenie środkowego przekroju poziomego Kuli
                    Rysownica.DrawEllipse(Pioro, XsP - OsDuza / 2.0f, YsP - OsMala / 2.0f, OsDuza, OsMala);
                    // wykreślenie linii łączących środek Kuli z wierzchołkami wielokąta wpisanego w poziomy przekrój Kuli
                    for (int i = 0; i < WielokatPrzekrojuKuli.Length; i++)
                    {
                        Rysownica.DrawLine(Pioro, XsP, YsP, WielokatPrzekrojuKuli[i].X, WielokatPrzekrojuKuli[i].Y);
                    }
                }
            }
            public override void Obroc_i_Wykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                // wymazanie Kuli
                Wymaz(Kontrolka, Rysownica);
                // sprawdzenie kierunku obrotu Kuli
                if (KierunekObrotu)
                    KatpolozeniaPierwszegoWierzcholka += KątObrotu;
                else
                    KatpolozeniaPierwszegoWierzcholka -= KątObrotu;
                // wyznaczenie współrzędnych wielokąta przekroju po obrocie
                for (int i = 0; i < WielokatPrzekrojuKuli.Length; i++)
                {
                    // wyznaczenie współrzędnej X i-tego wierzchołka wielokąta
                    WielokatPrzekrojuKuli[i].X = (int)(XsP + OsDuza / 2.0f * Math.Cos(Math.PI * (KatpolozeniaPierwszegoWierzcholka + i * KatSrodkowyWielokataPrzekrojuKuli) / 180.0f));
                    // wyznaczenie współrzędnej Y i-tego wierzchołka wielokąta
                    WielokatPrzekrojuKuli[i].Y = (int)(YsP + OsMala / 2.0f * Math.Sin(Math.PI * (KatpolozeniaPierwszegoWierzcholka + i * KatSrodkowyWielokataPrzekrojuKuli) / 180.0f));
                }
                // wykreślenie Kuli po obrocie
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                // deklaracje pomocnicze
                int dX, dY;
                // wymazanie bryły w aktualnym położeniu
                Wymaz(Kontrolka, Rysownica);
                // wyznaczenie przyrostów przesunięcia bryły
                dX = XsP < X ? dX = X - XsP : dX = -(XsP - X);
                dY = YsP < Y ? dY = Y - YsP : dY = -(YsP - Y);
                // uaktualnienie położenia środka podstawy Stożka i jego wierzchołka
                XsP = XsP + dX; YsP = YsP + dY;
                // wyznaczenie nowych współrzędnych wielokąta podstawy
                // deklaracja pomocnicza
                float KatSrodkowyWielokataPrzekrojuKuli = 360.0f / StopienWielokataPrzekrojuKuli;
                for (int i = 0; i < StopienWielokataPrzekrojuKuli; i++)
                {
                    WielokatPrzekrojuKuli[i] = new Point();
                    WielokatPrzekrojuKuli[i].X = (int)(XsP + OsDuza / 2.0f * Math.Cos(Math.PI * (KatpolozeniaPierwszegoWierzcholka + i * KatSrodkowyWielokataPrzekrojuKuli) / 180.0f));
                    WielokatPrzekrojuKuli[i].Y = (int)(YsP + OsMala / 2.0f * Math.Sin(Math.PI * (KatpolozeniaPierwszegoWierzcholka + i * KatSrodkowyWielokataPrzekrojuKuli) / 180.0f));
                }
                // wykreślenie Stożka w nowej lokalizacji
                Wykresl(Rysownica);
            }
        }
    }
}
