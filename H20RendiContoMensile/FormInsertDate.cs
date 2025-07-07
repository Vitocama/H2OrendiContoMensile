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
    public partial class FormInsertDate : Form
    {
        static  string stringConnesion = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=MMI;Integrated Security=True;Encrypt=False;";
        public FormInsertDate()
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
            FormReadDati formRicerca = new FormReadDati();
            formRicerca.Show();

        }

        private void buttonLetturaDeiDati_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (var conn = new SqlConnection(stringConnesion))
                {
                    conn.Open();

                    string query = "select cmd from rendi_contoAnnuale_2025_Anagrafe where cmd = @cmd";


                    // Passi il parametro in un oggetto anonimo
                    var param = new { cmd = textBoxCMD.Text };

                    // Esegui la query, mappando i risultati in oggetti della classe rendi_contoAnnuale_2025_Anagrafe
                   conn.Query<RendiContoAnnuale2025Anagrafe>(query, param).ToList();


                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("errore" + ex.Message, "Errore");
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

                  
                        MessageBox.Show("I dati sono stati caricati correttamente", "Conferma", MessageBoxButtons.OK);      
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

        private void conteggioH2OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormH20 formH20 = new FormH20();
            formH20.ShowDialog();
        }
    }
}
