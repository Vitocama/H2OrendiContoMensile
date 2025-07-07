using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace H20RendiContoMensile
{
    public partial class FormH20 : Form
    {
        static FormReadDati formInsertDate = new FormReadDati();


        public FormH20()
        {

           
            InitializeComponent();
            monthCalendarH20.MaxDate=DateTime.Today;
            monthCalendarH20.SelectionStart = DateTime.Today;
        }

        private void buttonAnagrafe_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(formInsertDate.connectionString))
            {
                string query = "SELECT * FROM rendi_contoAnnuale_2025_Anagrafe  WHERE cmd=@cmd";
                var presentkey = new { cmd = textBoxCMDH20.Text };
                conn.Open();
               var item = conn.QueryFirstOrDefault<RendiContoAnnuale2025Anagrafe>(query, presentkey);
                if (item == null)
                {
                    MessageBox.Show("non e' presente la chiace inserita", "Messaggio di errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxCMDH20.Clear();
                    return;
                }

            }
            int numero_botttiglie = 0;
            if (string.IsNullOrEmpty(textBoxCMDH20.Text))
            {

                MessageBox.Show("devi inserire  la CMD", "controllo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime start = monthCalendarH20.SelectionStart.Date;

            DateTime end = monthCalendarH20.SelectionEnd.Date;
            TimeSpan diff = end - start;
            int differenza = diff.Days + 1;


            for (int i = 0; i < differenza; i++)
            {

                if (start.DayOfWeek == DayOfWeek.Sunday || start.DayOfWeek == DayOfWeek.Saturday)
                {

                    start = start.AddDays(1);
                    continue;
                }
                else
                {

                    start = start.AddDays(1);
                    numero_botttiglie++;
                }

            }
                
            int error = -1;
            if (int.TryParse(textBoxGiorniDiFerie.Text, out error))
                numero_botttiglie = numero_botttiglie - int.Parse(textBoxGiorniDiFerie.Text);
            else
            {
                MessageBox.Show("errore inserimento ferie", "messaggio errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult dialog = MessageBox.Show("cmd : " + textBoxCMDH20.Text + "\nnumero bottiglie: " + numero_botttiglie, "dati salvati", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);


            if (dialog == DialogResult.Yes)
            { 
                DateTime ultima_data=monthCalendarH20.SelectionEnd.Date;
                try
                {
                    int num_mese=ultima_data.Month;

                    string mese = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num_mese);






                    using (SqlConnection conn = new SqlConnection(formInsertDate.connectionString))
                    {
                        string queryUpdate = @"UPDATE rendicontoAnnuale_2025  
                SET 
                    Ultima_data_lettura=@Ultima_data_lettura
                 
                where cmd_anagrafe=@cmd_anagrafe
            
                ";

                        conn.Open();
                        var updateVar = new { cmd_anagrafe = textBoxCMDH20.Text, Ultima_data_lettura = ultima_data };


                        int righe =  conn.Execute(queryUpdate,updateVar);

                        if (righe == 0) {
                            var insertVar = new { cmd_anagrafe = textBoxCMDH20.Text, Ultima_data_lettura = ultima_data };

                           string queryInsert = @"INSERT INTO rendicontoAnnuale_2025(cmd_anagrafe,Ultima_data_lettura) 
                                       VALUES(@cmd_anagrafe,@Ultima_data_lettura)
                               
                                 ";
                            conn.Execute(queryInsert, insertVar);


                        }

                        MessageBox.Show("dati salvati correttamente", "conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxCMDH20.Clear();
                        return;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("rilevato errore" + ex.Message,"errore",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                


            }

            if (dialog == DialogResult.No)
            {
                MessageBox.Show("dati  cancellato", "cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dialog == DialogResult.Cancel)
            {
                MessageBox.Show("operazione annullata", "abort", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dialog == DialogResult.OK)
            { MessageBox.Show("dati salvati correttamente", "conferma", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            if (dialog == DialogResult.Cancel)
            {
                MessageBox.Show("dati  cancellato", "cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dialog == DialogResult.Abort)
            {
                MessageBox.Show("operazione annullata", "abort", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }





        }


        private void textBoxCMD_TextChanged(object sender, EventArgs e)
        {

        }

        private void inserimentoDatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInsertDate formAggiungiDati = new FormInsertDate();
            formAggiungiDati.ShowDialog();
        }

        private void letturaDatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReadDati formReadDati = new FormReadDati();
            formReadDati.ShowDialog();
        }
    }
}
