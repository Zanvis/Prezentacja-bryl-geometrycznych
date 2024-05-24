using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3_Piwowarski62024
{
    public partial class KokpitProjektuNr3 : Form
    {
        public KokpitProjektuNr3()
        {
            InitializeComponent();
        }

        private void btnLaboratoriumNr3_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy już był utworzony egzemplarz formularza LaboratoriumNr3
            foreach (Form Formularz in Application.OpenForms)
                // sprawdzenie, czy został znaleziony formularz LaboratoriumNr3
                if (Formularz.Name == "LaboratoriumNr3")
                {
                    // ukrycie bieżącego formularza
                    this.Hide();
                    // odsłonięcie formularza znalezionego
                    Formularz.Show();
                    // bezwarunkowe zakończenie obsługi zdarzenia Click
                    return;
                }
            /* gdy będziemy tutaj, to poszukiwany fomrularz LaboratoriumNr3 nie został znaleziony,
             a to oznacza, że należy utworzyć egzemplarz tego formularza i go odsłonić */
            LaboratoriumNr3 FormLaboratoriumNr3 = new LaboratoriumNr3();
            // ukrycie bieżącego formularza
            this.Hide();
            // odsłonięcie formularza FormLaboratoriumNr3
            FormLaboratoriumNr3.Show();
        }

        private void btnProjektIndywidualnyNr3_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
                // sprawdzenie, czy został znaleziony formularz ProjektIndywidualnyNr3
                if (Formularz.Name == "ProjektIndywidualnyNr3")
                {
                    // ukrycie bieżącego formularza
                    this.Hide();
                    // odsłonięcie formularza znalezionego
                    Formularz.Show();
                    // bezwarunkowe zakończenie obsługi zdarzenia Click
                    return;
                }
            /* gdy będziemy tutaj, to poszukiwany fomrularz ProjektIndywidualnyNr3 nie został znaleziony,
             a to oznacza, że należy utworzyć egzemplarz tego formularza i go odsłonić */
            ProjektIndywidualnyNr3 FormProjektIndywidualnyNr3 = new ProjektIndywidualnyNr3();
            // ukrycie bieżącego formularza
            this.Hide();
            // odsłonięcie formularza FormProjektIndywidualnyNr3
            FormProjektIndywidualnyNr3.Show();
        }
    }
}
