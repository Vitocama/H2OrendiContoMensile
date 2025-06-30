using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;





namespace H20RendiContoMensile;

public partial class FormRicerca : Form
{

    public string connectionString = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=MMI;Integrated Security=True;Encrypt=False;";

    List<Button> buttons = new List<Button>();
    Connessione connessione = new Connessione();

    public FormRicerca()
    {
        InitializeComponent();
        buttons = new List<Button>() {
        button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12
        };
        foreach (Button mese in buttons)
        {
            mese.ForeColor = Color.Blue;

        }

        Color blueTenue = Color.FromArgb(191, 229, 255);
        comboBoxRicerca.SelectedItem = "Cmd";

    }

    private void button1_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            mese.ForeColor = Color.Red;
            if (mese == button1)
            {
                mese.BackColor = Color.Yellow;
                continue;
            }
            else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }

        }


    }

    private void button2_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            mese.ForeColor = Color.Red;
            if (mese == button2)
            {

                mese.BackColor = Color.Yellow;
                continue;
            }
            else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
        }


    }








    private void button3_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button3)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }




    }

    private void button4_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button4)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button5)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }
        }
    }

    private void button6_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button6)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button7_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button7)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button8_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button8)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button9_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button9)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button10_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button10)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button11_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button11)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button12_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button12)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Color blueTenue = Color.FromArgb(191, 229, 255);
        this.BackColor = blueTenue;
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void groupBoxCMD_Enter(object sender, EventArgs e)
    {

    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {



    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button13_Click(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(textBoxCerca.Text))


        {
            dataGridView1.DataSource = connessione.Tablerendi_contoAnnuale_2025_Anagrafe();
        }

        else

        {


            DataTable date = connessione.Tablerendi_contoAnnuale_2025_Anagrafe();

            DataTable ris = new DataTable();
            string query = textBoxCerca.Text;

            foreach (DataColumn col in date.Columns)
            {
                ris.Columns.Add(col.ColumnName, col.DataType);

            }


            foreach (DataRow dr in date.Rows)
            {
                if (dr[comboBoxRicerca.Text].ToString().Contains(query))
                    ris.ImportRow(dr);

            }
            dataGridView1.DataSource = ris;






        }











    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void comboBoxRicerca_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void aggiungiDatiToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormAggiungiDati formAggiungiDati = new FormAggiungiDati();
        formAggiungiDati.Show();
        
    }
}
