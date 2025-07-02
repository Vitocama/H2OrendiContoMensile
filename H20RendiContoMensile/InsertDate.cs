using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace H20RendiContoMensile
{
    public partial class FormAggiungiDati : Form
    {
        public FormAggiungiDati()
        {
            InitializeComponent();
        }

        private void FormAggiungiDati_Load(object sender, EventArgs e)
        {

        }

        private void aggiungiDatiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void letturaDatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRicerca formRicerca = new FormRicerca();
            formRicerca.Show();

        }

        private void buttonLetturaDeiDati_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCMD.Text))

            {
                MessageBox.Show("compilare CMD");
                return;
            }
                int Numero_bottiglie = 0;
                Connessione connessione = new Connessione();

                DateTime startday = monthCalendar.SelectionStart.Date;
                DateTime endday = monthCalendar.SelectionEnd.Date;
                TimeSpan difference = endday - startday;
                int giorni = (int)difference.TotalDays + 1;

                for (int i = 0; i < giorni; i++)
                {
                    if (endday.DayOfWeek == DayOfWeek.Sunday || startday.DayOfWeek == DayOfWeek.Saturday)
                    {
                        continue;
                    }
                    else
                        Numero_bottiglie++;
                    if (startday < endday)
                        startday = startday.AddDays(1);
                    else break;
                }
                string query = @"
    INSERT INTO rendi_contoAnnuale_2025_Anagrafe
    (cmd, nome, cognome, data_nascita, luogo_di_nascita, residenza, email, contatto)
    VALUES
    (@cmd, @nome, @cognome, @data_nascita, @luogo_di_nascita, @residenza, @email, @contatto)";
                try
                {
                    var tab = new { cmd = textBoxCMD.Text, nome = textBoxNome.Text, cognome = textBoxCognome.Text, data_nascita = dateTimePickerNascita.Text, luogo_di_nascita = textBoxLuogoNascita.Text, residenza = textBoxResidenza.Text, email = textBoxEmail.Text, contatto = textBoxContatto.Text };

                    using (var connect = new SqlConnection(connessione.connectionString))
                    {
                        connect.Open();
                        connect.Execute(query, tab);
                        MessageBox.Show("dati inseriti correttamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nell'inserimento dei dati:\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            

            }
        








        private void aggiungiDatiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
