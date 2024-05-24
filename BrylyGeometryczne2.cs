using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt3_Piwowarski62024.ProjektIndywidualnyNr3;

namespace Projekt3_Piwowarski62024
{
    internal class BrylyGeometryczne2
    {
        public abstract class BrylaAbstrakcyjna : IComparable<BrylaAbstrakcyjna>
        {
            //deklaracja typu wyliczeniowego znaczników bryła
            public enum TypBG
            {
                BG_Graniastoslup, BG_Ostroslup, BG_Szescian
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
                if (apUchwytFormularza.rdbWysokosc.Checked)
                {
                    if (this.WysokoscBG > Bryla2.WysokoscBG) return 1;
                    else if (this.WysokoscBG < Bryla2.WysokoscBG) return -1;
                    else return 0;
                }
                else if (apUchwytFormularza.rdbObjetosc.Checked)
                {
                    if (this.ObjetoscBryly > Bryla2.ObjetoscBryly) return 1;
                    else if (this.ObjetoscBryly < Bryla2.ObjetoscBryly) return -1;
                    else return 0;
                }
                else if (apUchwytFormularza.rdbPoleCalkowite.Checked)
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
        public class Wielosciany : BrylaAbstrakcyjna
        {
            //deklaracja atrybutu wspólnego dla: Walca, Stożka i Kuli
            protected int Promien;
            protected int StopienWielokataPodstawy;
            //deklaracja konstruktora
            public Wielosciany(int R, int StopienWielokataPodstawy, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(KolorLinii, StylLinii, GruboscLinii)
            {
                //przechowanie wartości atrybutu wspólnego
                this.Promien = R;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
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
        public class Graniastoslup : Wielosciany
        {
            // deklaracja tablicy referencji egzemplarzy wierzchołków "podłogi"
            Point[] WielokatPodlogi;
            // deklaracja tablicy referencji egzemplarzy wierzchołków "sufitu"
            Point[] WielokatSufitu;
            // osie elipsy "podłogi" (podstawy) i "sufitu"
            float Os_duza, Os_mala;
            // kąt położenia pierwszego wierzchołka wielokąta podstawy
            float KatPolozeniaPierwszegoWierzcholka;
            int WysokoscBryly;
            int XsS, YsS;

            public Graniastoslup(int R, int Wysokosc, int StopienWielokataPodstawy, int XsS, int YsS, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(R, StopienWielokataPodstawy, KolorLinii, StylLinii, GruboscLinii)
            {
                this.WysokoscBG = Wysokosc;
                TypBryly = TypBG.BG_Graniastoslup;
                this.WysokoscBryly = Wysokosc;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
                Os_duza = this.Promien * 2.0f;
                Os_mala = this.Promien / 2.0f;
                // wyznaczenie współrzędnej YsS środka sufitu Walca
                this.XsS = XsS;
                this.YsS = YsS;
                this.XsP = XsP;
                this.YsP = YsP;
                // wyznaczenie kąta środkowego między wierzchołkami wielokątów podłogi i sufitu
                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;
                // ustalenie kąta położenia pierwszego wierzchołka wielokąta podstawy;
                this.KatPolozeniaPierwszegoWierzcholka = 0.0f;
                this.WielokatPodlogi = new Point[StopienWielokataPodstawy + 1];
                this.WielokatSufitu = new Point[StopienWielokataPodstawy + 1];

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    WielokatSufitu[i] = new Point();
                    // "podłoga" Walca
                    WielokatPodlogi[i].X = (int)(XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodlogi[i].Y = (int)(YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    // "sufit" Walca
                    WielokatSufitu[i].X = WielokatPodlogi[i].X;
                    WielokatSufitu[i].Y = WielokatPodlogi[i].Y - WysokoscBryly;
                }
                float podstawa = (float)(Math.PI * R * R);
                this.ObjetoscBryly = podstawa * WysokoscBG;
                this.PowierzchniaBryly = (2 * podstawa) + (StopienWielokataPodstawy * WysokoscBG * Promien * 2);
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(this.KolorLinii, this.GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;

                    // wykreślenie podłogi
                    for (int i = 0; i < WielokatPodlogi.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatPodlogi[i + 1]);

                    // wykreślenie sufitu
                    for (int i = 0; i < WielokatSufitu.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatSufitu[i], WielokatSufitu[i + 1]);

                    // wykreślenie krawędzi bocznych
                    for (int i = 0; i <= StopienWielokataPodstawy; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatSufitu[i]);
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kontrolka.BackColor, this.GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;

                    // wykreślenie podłogi
                    for (int i = 0; i < WielokatPodlogi.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatPodlogi[i + 1]);

                    // wykreślenie sufitu
                    for (int i = 0; i < WielokatSufitu.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatSufitu[i], WielokatSufitu[i + 1]);

                    // wykreślenie krawędzi bocznych
                    for (int i = 0; i <= StopienWielokataPodstawy; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatSufitu[i]);
                }
            }
            public override void Obroc_i_Wykresl(Control Kontrolka, Graphics Rysownica, float KatObrotu)
            {
                // wymazanie Graniastosłupa w jego aktualnym położeniu
                Wymaz(Kontrolka, Rysownica);
                // wyznaczenie nowego kąta położenia pierwszego wierzchołka wielokąta
                if (!this.KierunekObrotu)
                    this.KatPolozeniaPierwszegoWierzcholka += KatPochylenia;
                else
                    this.KatPolozeniaPierwszegoWierzcholka -= KatPochylenia;

                // wyznaczenie kąta środkowego między wierzchołkami wielokątów podłogi i sufitu
                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X = (int)(this.XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodlogi[i].Y = (int)(this.YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));

                    WielokatSufitu[i].X = WielokatPodlogi[i].X;
                    WielokatSufitu[i].Y = WielokatPodlogi[i].Y - WysokoscBryly;
                }
                // wykreślenie Walca po obrocie o KatPochylenia
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                // wymazanie Graniastoslupa w jego aktualnym położeniu (lokalizacji)
                Wymaz(Kontrolka, Rysownica);
                XsP = X; YsP = Y;
                XsS = X; YsS = Y - WysokoscBryly;

                // wyznaczenie kąta środkowego między wierzchołkami wielokątów podłogi i sufitu
                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    // "podłoga" Walca
                    WielokatPodlogi[i].X = (int)(this.XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodlogi[i].Y = (int)(this.YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));

                    WielokatSufitu[i].X = WielokatPodlogi[i].X;
                    WielokatSufitu[i].Y = WielokatPodlogi[i].Y - WysokoscBryly;
                }
                Wykresl(Rysownica);
            }
        }
        public class Ostroslup : Wielosciany
        {
            // deklaracja tablicy referencji egzemplarzy wierzchołków "podstawy"
            Point[] WielokatPodstawy;
            // deklaracja referencji egzemplarza wierzchołka "szczytu"
            Point WierzcholekGorny;
            // osie elipsy "podstawy"
            float Os_duza, Os_mala;
            // kąt położenia pierwszego wierzchołka wielokąta podstawy
            float KatPolozeniaPierwszegoWierzcholka;
            int WysokoscBryly;

            public Ostroslup(int R, int Wysokosc, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(R, StopienWielokataPodstawy, KolorLinii, StylLinii, GruboscLinii)
            {
                this.WysokoscBG = Wysokosc;
                TypBryly = TypBG.BG_Ostroslup;
                this.WysokoscBryly = Wysokosc;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
                Os_duza = this.Promien * 2.0f;
                Os_mala = this.Promien / 2.0f;
                this.XsP = XsP;
                this.YsP = YsP;
                // wyznaczenie kąta środkowego między wierzchołkami wielokąta podstawy
                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;
                // ustalenie kąta położenia pierwszego wierzchołka wielokąta podstawy;
                this.KatPolozeniaPierwszegoWierzcholka = 0.0f;
                this.WielokatPodstawy = new Point[StopienWielokataPodstawy + 1];
                this.WierzcholekGorny = new Point();

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    // podstawa ostrosłupa
                    WielokatPodstawy[i].X = (int)(XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodstawy[i].Y = (int)(YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                }

                // szczyt ostrosłupa
                WierzcholekGorny.X = XsP;
                WierzcholekGorny.Y = YsP - WysokoscBryly;

                float podstawa = (float)(Math.PI * R * R);
                this.ObjetoscBryly = (podstawa * WysokoscBG) / 3;
                this.PowierzchniaBryly = podstawa + (StopienWielokataPodstawy * WysokoscBG * Promien);
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(this.KolorLinii, this.GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;

                    // wykreślenie podstawy
                    for (int i = 0; i < WielokatPodstawy.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodstawy[i], WielokatPodstawy[i + 1]);

                    // wykreślenie krawędzi bocznych
                    for (int i = 0; i < WielokatPodstawy.Length; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodstawy[i], WierzcholekGorny);
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kontrolka.BackColor, this.GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;

                    // wykreślenie podstawy
                    for (int i = 0; i < WielokatPodstawy.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodstawy[i], WielokatPodstawy[i + 1]);

                    // wykreślenie krawędzi bocznych
                    for (int i = 0; i < WielokatPodstawy.Length; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodstawy[i], WierzcholekGorny);
                }
            }
            public override void Obroc_i_Wykresl(Control Kontrolka, Graphics Rysownica, float KątObrotu)
            {
                // wymazanie Graniastosłupa w jego aktualnym położeniu
                Wymaz(Kontrolka, Rysownica);
                // wyznaczenie nowego kąta położenia pierwszego wierzchołka wielokąta
                if (!this.KierunekObrotu)
                    this.KatPolozeniaPierwszegoWierzcholka += KatPochylenia;
                else
                    this.KatPolozeniaPierwszegoWierzcholka -= KatPochylenia;

                // wyznaczenie kąta środkowego między wierzchołkami wielokątów podłogi i sufitu
                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;
                this.WielokatPodstawy = new Point[StopienWielokataPodstawy + 1];
                this.WierzcholekGorny = new Point();

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    // podstawa ostrosłupa
                    WielokatPodstawy[i].X = (int)(XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodstawy[i].Y = (int)(YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                }

                // szczyt ostrosłupa
                WierzcholekGorny.X = XsP;
                WierzcholekGorny.Y = YsP - WysokoscBryly;
                Wykresl(Rysownica);

            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                // wymazanie Ostroslupa w jego aktualnym położeniu (lokalizacji)
                Wymaz(Kontrolka, Rysownica);
                XsP = X; YsP = Y;

                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;
                // ustalenie kąta położenia pierwszego wierzchołka wielokąta podstawy;
                this.KatPolozeniaPierwszegoWierzcholka = 0.0f;
                this.WielokatPodstawy = new Point[StopienWielokataPodstawy + 1];
                this.WierzcholekGorny = new Point();

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodstawy[i] = new Point();
                    // podstawa ostrosłupa
                    WielokatPodstawy[i].X = (int)(XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodstawy[i].Y = (int)(YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                }

                // szczyt ostrosłupa
                WierzcholekGorny.X = XsP;
                WierzcholekGorny.Y = YsP - WysokoscBryly;
                Wykresl(Rysownica);
            }
        }
        public class GraniastoslupPochyly : Wielosciany
        {
            // deklaracja tablicy referencji egzemplarzy wierzchołków "podłogi"
            Point[] WielokatPodlogi;
            // deklaracja tablicy referencji egzemplarzy wierzchołków "sufitu"
            Point[] WielokatSufitu;
            // osie elipsy "podłogi" (podstawy) i "sufitu"
            float Os_duza, Os_mala;
            // kąt położenia pierwszego wierzchołka wielokąta podstawy
            float KatPolozeniaPierwszegoWierzcholka;
            int WysokoscBryly;
            int XsS, YsS;

            public GraniastoslupPochyly(int R, int Wysokosc, int StopienWielokataPodstawy, int XsS, int YsS, int XsP, int YsP, float KatPochylenia, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(R, StopienWielokataPodstawy, KolorLinii, StylLinii, GruboscLinii)
            {
                this.WysokoscBG = Wysokosc;
                TypBryly = TypBG.BG_Graniastoslup;
                this.WysokoscBryly = Wysokosc;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
                Os_duza = this.Promien * 2.0f;
                Os_mala = this.Promien / 2.0f;
                this.XsS = XsS;
                this.YsS = YsS;
                this.XsP = XsP;
                this.YsP = YsP;
                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;
                this.KatPolozeniaPierwszegoWierzcholka = 0.0f;
                this.WielokatPodlogi = new Point[StopienWielokataPodstawy + 1];
                this.WielokatSufitu = new Point[StopienWielokataPodstawy + 1];

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i] = new Point();
                    WielokatSufitu[i] = new Point();

                    float KatPochyleniaRad = KatPochylenia * (float)Math.PI / 180.0f;
                    float KatObrotuRad = (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) * (float)Math.PI / 180.0f;

                    // "podłoga" Graniastoslupa
                    WielokatPodlogi[i].X = (int)(XsP + Os_duza / 2 * Math.Cos(KatObrotuRad));
                    WielokatPodlogi[i].Y = (int)(YsP + Os_mala / 2 * Math.Sin(KatObrotuRad));

                    // "sufit" Graniastoslupa
                    WielokatSufitu[i].X = (int)(WielokatPodlogi[i].X + WysokoscBryly * Math.Cos(KatPochyleniaRad));
                    WielokatSufitu[i].Y = (int)(WielokatPodlogi[i].Y + WysokoscBryly * Math.Sin(KatPochyleniaRad));
                }
                float podstawa = (float)(Math.PI * R * R);
                this.ObjetoscBryly = podstawa * WysokoscBG;
                this.PowierzchniaBryly = (2 * podstawa) + (StopienWielokataPodstawy * WysokoscBG * Promien * 2);
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(this.KolorLinii, this.GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;

                    // Wykreślenie podłogi
                    for (int i = 0; i < WielokatPodlogi.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatPodlogi[i + 1]);
                    Rysownica.DrawLine(Pioro, WielokatPodlogi[WielokatPodlogi.Length - 1], WielokatPodlogi[0]); // Zamknięcie podłogi

                    // Wykreślenie sufitu
                    for (int i = 0; i < WielokatSufitu.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatSufitu[i], WielokatSufitu[i + 1]);
                    Rysownica.DrawLine(Pioro, WielokatSufitu[WielokatSufitu.Length - 1], WielokatSufitu[0]); // Zamknięcie sufitu

                    // Wykreślenie krawędzi bocznych
                    for (int i = 0; i < WielokatPodlogi.Length; i++)
                    {
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatSufitu[i]);
                    }
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kontrolka.BackColor, this.GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;

                    // Wykreślenie podłogi
                    for (int i = 0; i < WielokatPodlogi.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatPodlogi[i + 1]);
                    Rysownica.DrawLine(Pioro, WielokatPodlogi[WielokatPodlogi.Length - 1], WielokatPodlogi[0]); // Zamknięcie podłogi

                    // Wykreślenie sufitu
                    for (int i = 0; i < WielokatSufitu.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatSufitu[i], WielokatSufitu[i + 1]);
                    Rysownica.DrawLine(Pioro, WielokatSufitu[WielokatSufitu.Length - 1], WielokatSufitu[0]); // Zamknięcie sufitu

                    // Wykreślenie krawędzi bocznych
                    for (int i = 0; i < WielokatPodlogi.Length; i++)
                    {
                        Rysownica.DrawLine(Pioro, WielokatPodlogi[i], WielokatSufitu[i]);
                    }
                }
            }
            public override void Obroc_i_Wykresl(Control Kontrolka, Graphics Rysownica, float KatObrotu)
            {
                // Wymaż graniastosłup w jego aktualnym położeniu
                Wymaz(Kontrolka, Rysownica);

                // Wyznaczenie nowego kąta położenia pierwszego wierzchołka wielokąta
                if (!this.KierunekObrotu)
                    this.KatPolozeniaPierwszegoWierzcholka += KatObrotu;
                else
                    this.KatPolozeniaPierwszegoWierzcholka -= KatObrotu;

                // Wyznaczenie kąta środkowego między wierzchołkami wielokątów podłogi i sufitu
                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    // Oblicz nowe współrzędne wierzchołków podłogi i sufitu po obróceniu
                    double katRad = Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f;
                    int przesuniecieX = (int)(Os_duza / 2 * Math.Cos(katRad));
                    int przesuniecieY = (int)(Os_mala / 2 * Math.Sin(katRad));

                    WielokatPodlogi[i].X = this.XsP + przesuniecieX;
                    WielokatPodlogi[i].Y = this.YsP + przesuniecieY;

                    WielokatSufitu[i].X = WielokatPodlogi[i].X;
                    WielokatSufitu[i].Y = WielokatPodlogi[i].Y - WysokoscBryly;
                }
                // Wykreślenie graniastosłupa po obrocie
                Wykresl(Rysownica);
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                // wymazanie Graniastoslupa w jego aktualnym położeniu (lokalizacji)
                Wymaz(Kontrolka, Rysownica);

                int przesuniecieX = X - XsP;
                int przesuniecieY = Y - YsP;
                XsP = X;
                YsP = Y;
                XsS = X;
                YsS = Y - WysokoscBryly;

                // Wykonaj przesunięcie wierzchołków podłogi i sufitu
                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodlogi[i].X += przesuniecieX;
                    WielokatPodlogi[i].Y += przesuniecieY;
                    WielokatSufitu[i].X += przesuniecieX;
                    WielokatSufitu[i].Y += przesuniecieY;
                }

                Wykresl(Rysownica);
            }
        }
        public class OstroslupPochyly : Wielosciany
        {
            private Point[] WielokatPodstawy;
            private Point WierzcholekGorny;
            private float Os_duza;
            private float Os_mala;
            private float KatPolozeniaPierwszegoWierzcholka;
            private int WysokoscBryly;

            public OstroslupPochyly(int R, int Wysokosc, int StopienWielokataPodstawy, int XsP, int YsP, Color KolorLinii, DashStyle StylLinii, float GruboscLinii, float KatPochylenia) : base(R, StopienWielokataPodstawy, KolorLinii, StylLinii, GruboscLinii)
            {
                this.WysokoscBG = Wysokosc;
                TypBryly = TypBG.BG_Ostroslup;
                this.WysokoscBryly = Wysokosc;
                this.StopienWielokataPodstawy = StopienWielokataPodstawy;
                this.Os_duza = this.Promien * 2.0f;
                this.Os_mala = this.Promien / 2.0f;
                this.XsP = XsP;
                this.YsP = YsP;
                this.KatPochylenia = KatPochylenia;

                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;
                this.KatPolozeniaPierwszegoWierzcholka = 0.0f;
                this.WielokatPodstawy = new Point[StopienWielokataPodstawy + 1];
                this.WierzcholekGorny = new Point();

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodstawy[i].X = (int)(XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodstawy[i].Y = (int)(YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                }

                WierzcholekGorny.X = XsP;
                WierzcholekGorny.Y = YsP - WysokoscBryly;

                float podstawa = (float)(Math.PI * R * R);
                this.ObjetoscBryly = (podstawa * WysokoscBG) / 3;
                this.PowierzchniaBryly = podstawa + (StopienWielokataPodstawy * WysokoscBG * Promien);
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(this.KolorLinii, this.GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;

                    for (int i = 0; i < WielokatPodstawy.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodstawy[i], WielokatPodstawy[i + 1]);

                    for (int i = 0; i < WielokatPodstawy.Length; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodstawy[i], WierzcholekGorny);
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kontrolka.BackColor, this.GruboscLinii))
                {
                    Pioro.DashStyle = this.StylLinii;

                    for (int i = 0; i < WielokatPodstawy.Length - 1; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodstawy[i], WielokatPodstawy[i + 1]);

                    for (int i = 0; i < WielokatPodstawy.Length; i++)
                        Rysownica.DrawLine(Pioro, WielokatPodstawy[i], WierzcholekGorny);
                }
            }

            public override void Obroc_i_Wykresl(Control Kontrolka, Graphics Rysownica, float KatObrotu)
            {
                Wymaz(Kontrolka, Rysownica);
                if (!this.KierunekObrotu)
                    this.KatPolozeniaPierwszegoWierzcholka += KatPochylenia;
                else
                    this.KatPolozeniaPierwszegoWierzcholka -= KatPochylenia;

                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;
                this.WielokatPodstawy = new Point[StopienWielokataPodstawy + 1];
                this.WierzcholekGorny = new Point();

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodstawy[i].X = (int)(XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodstawy[i].Y = (int)(YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                }

                WierzcholekGorny.X = XsP;
                WierzcholekGorny.Y = YsP - WysokoscBryly;
                Wykresl(Rysownica);
            }

            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int X, int Y)
            {
                Wymaz(Kontrolka, Rysownica);
                XsP = X;
                YsP = Y;

                float KatMiedzyWierzcholkami = 360.0f / StopienWielokataPodstawy;
                this.KatPolozeniaPierwszegoWierzcholka = 0.0f;
                this.WielokatPodstawy = new Point[StopienWielokataPodstawy + 1];
                this.WierzcholekGorny = new Point();

                for (int i = 0; i <= StopienWielokataPodstawy; i++)
                {
                    WielokatPodstawy[i].X = (int)(XsP + Os_duza / 2 * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                    WielokatPodstawy[i].Y = (int)(YsP + Os_mala / 2 * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0f));
                }

                WierzcholekGorny.X = XsP;
                WierzcholekGorny.Y = YsP - WysokoscBryly;
                Wykresl(Rysownica);
            }
        }
    }
}
