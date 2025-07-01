using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        }

        private void buttonLetturaDeiDati_Click(object sender, EventArgs e)
        {
            Connessione connessione = new Connessione();
            System.Data.DataTable dataTable = new DataTable();
            dataTable = connessione.Tablerendi_contoAnnuale_2025_Anagrafe();
            
        }
    }
}
