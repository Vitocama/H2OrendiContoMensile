using Dapper;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
        string stringConnesion = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=MMI;Integrated Security=True;Encrypt=False;";
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
          
            try
            {
                using (var conn = new SqlConnection())
                {
                    conn.Open();

                    string query = "select cmd from rendi_contoAnnuale_2025_Anagrafe where cmd = @cmd";
                    

                    // Passi il parametro in un oggetto anonimo
                    var param = new { cmd = textBoxCMD.Text };

                    // Esegui la query, mappando i risultati in oggetti della classe rendi_contoAnnuale_2025_Anagrafe
                    var risultati = conn.Query<RendiContoAnnuale2025Anagrafe>(query, param).ToList();
                     

                    if (risultati.Count > 0)
                    {
                        MessageBox.Show("errore di key");

                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("errore" + ex.Message, "Errore");
            }



            if (string.IsNullOrEmpty(textBoxCMD.Text))

            {
                MessageBox.Show("compilare CMD");
                return;
            }
            int Numero_bottiglie = 0;


            DateTime startday = monthCalendar.SelectionStart.Date;
            DateTime endday = monthCalendar.SelectionEnd.Date;
            TimeSpan difference = endday - startday;
            int giorni = (int)difference.TotalDays + 1;

            for (int i = 0; i < giorni; i++)
            {
                if (endday.DayOfWeek == DayOfWeek.Sunday || startday.DayOfWeek == DayOfWeek.Saturday)
                {
                    startday = startday.AddDays(1);
                    continue;
                }
                else
                { 
                    Numero_bottiglie++;
                    startday = startday.AddDays(1);
                }
                if (startday == endday)
                {
                    break;
                }  
            }

            try
            {



                string messaggio = @"CMD: " + textBoxCMD.Text + "\n" +
           "NOME: " + textBoxNome.Text + "\n" +
           "COGNOME: " + textBoxCognome.Text + "\n" +
           "DATA DI NASCITA: " + dateTimePickerNascita.Text + "\n" +
           "LUOGO DI NASCITA: " + textBoxLuogoNascita.Text + "\n" +
           "RESIDENZA: " + textBoxResidenza.Text + "\n" +
           "EMAIL: " + textBoxEmail.Text + "\n" +
           "CONTATTO: " + textBoxContatto.Text + "\n" +
           "NUMERO DI BOTTIGLIE: " + Numero_bottiglie.ToString() +
               "\nCONFERMI?";
                DialogResult ris = MessageBox.Show(messaggio, "Dati Inseriti", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);



                if (ris == System.Windows.Forms.DialogResult.Yes)
                {
                    string query = @"
    INSERT INTO rendi_contoAnnuale_2025_Anagrafe
    (cmd, nome, cognome, data_nascita, luogo_di_nascita, residenza, email, contatto)
    VALUES
    (@cmd, @nome, @cognome, @data_nascita, @luogo_di_nascita, @residenza, @email, @contatto)";
                    var tab = new { cmd = textBoxCMD.Text, nome = textBoxNome.Text, cognome = textBoxCognome.Text, data_nascita = dateTimePickerNascita.Text, luogo_di_nascita = textBoxLuogoNascita.Text, residenza = textBoxResidenza.Text, email = textBoxEmail.Text, contatto = textBoxContatto.Text };

                    using (var connect = new SqlConnection(stringConnesion))
                    {
                        connect.Open();
                        connect.Execute(query, tab);

                       var tab1 = new { cmd = textBoxCMD.Text, Numero_bottiglie=Numero_bottiglie };

                        
                        query = "insert into rendicontoAnnuale_2025(cmd,Numero_bottiglie)values(@cmd,@Numero_bottiglie)";

                        connect.Execute(query, tab1);
                        MessageBox.Show("I dati sono stati caricati correttamente", "Conferma", MessageBoxButtons.OK);
                    }
                    textBoxCMD.Clear();
                    textBoxNome.Clear();
                    textBoxCognome.Clear();
                    textBoxLuogoNascita.Clear();
                    textBoxResidenza.Clear();
                    textBoxEmail.Clear();
                    textBoxContatto.Clear();
                }
                else if (ris == System.Windows.Forms.DialogResult.No)
                {
                    textBoxCMD.Clear();
                    textBoxNome.Clear();
                    textBoxCognome.Clear();
                    textBoxLuogoNascita.Clear();
                    textBoxResidenza.Clear();
                    textBoxEmail.Clear();
                    textBoxContatto.Clear();
                    MessageBox.Show("Operazione annullata", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Operazione annullata", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxCMD.Clear();
                    textBoxNome.Clear();
                    textBoxCognome.Clear();
                    textBoxLuogoNascita.Clear();
                    textBoxResidenza.Clear();
                    textBoxEmail.Clear();
                    textBoxContatto.Clear();
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

        private void textBoxCMD_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBoxCMD_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCMD.Clear();
            textBoxNome.Clear();
            textBoxCognome.Clear();
            textBoxLuogoNascita.Clear();
            textBoxResidenza.Clear();
            textBoxEmail.Clear();
            textBoxContatto.Clear();
        }
    }
}
