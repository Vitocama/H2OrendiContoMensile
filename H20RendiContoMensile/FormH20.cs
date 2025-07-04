using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace H20RendiContoMensile
{
    public partial class FormH20 : Form
    {
        static FormReadDati formInsertDate = new FormReadDati();


        public FormH20()
        {

            InitializeComponent();
        }

        private void buttonAnagrafe_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(formInsertDate.connectionString))
            {
                string query = "SELECT * FROM rendicontoAnnuale_2025  WHERE cmd=@cmd";
                var presentkey = new { cmd = textBoxCMDH20.Text };
                conn.Open();
                var item = conn.QueryFirstOrDefault<RendicontoAnnuale2025>(query, presentkey);
                if (item == null)
                    MessageBox.Show("non e' presente la chiace inserita", "Messaggio di errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            int differenza = diff.Days;


            for (int i = 1; i < differenza; i++)
            {
                if (start.DayOfWeek == DayOfWeek.Sunday || end.DayOfWeek == DayOfWeek.Saturday)
                {

                    start = start.AddDays(1);
                    continue;
                }
                else
                {

                    start = end.AddDays(1);
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
